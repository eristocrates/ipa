namespace http.vocab.datex.org.terms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module datex =
    let _namespace_iri = Namespace_Iri datex |> NamespaceIRI
    /// <summary>
    ///   <para>datex:AbandonedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AbandonedVehicle">http://vocab.datex.org/terms#AbandonedVehicle</seealso>
    let AbandonedVehicle = Prefixed_Name(datex, "AbandonedVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingBicycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingBicycles">http://vocab.datex.org/terms#AccidentInvolvingBicycles</seealso>
    let AccidentInvolvingBicycles =
        Prefixed_Name(datex, "AccidentInvolvingBicycles") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingHeavyLorries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingHeavyLorries">http://vocab.datex.org/terms#AccidentInvolvingHeavyLorries</seealso>
    let AccidentInvolvingHeavyLorries =
        Prefixed_Name(datex, "AccidentInvolvingHeavyLorries") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingMotorcycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingMotorcycles">http://vocab.datex.org/terms#AccidentInvolvingMotorcycles</seealso>
    let AccidentInvolvingMotorcycles =
        Prefixed_Name(datex, "AccidentInvolvingMotorcycles") |> PrefixedName

    /// <summary>
    ///   <para>datex:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Deliberate human action external to the traffic stream or roadway which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Activity">http://vocab.datex.org/terms#Activity</seealso>
    let Activity = Prefixed_Name(datex, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>datex:AirAmbulance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AirAmbulance">http://vocab.datex.org/terms#AirAmbulance</seealso>
    let AirAmbulance = Prefixed_Name(datex, "AirAmbulance") |> PrefixedName
    /// <summary>
    ///   <para>datex:Marathon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Marathon">http://vocab.datex.org/terms#Marathon</seealso>
    let Marathon = Prefixed_Name(datex, "Marathon") |> PrefixedName
    /// <summary>
    ///   <para>datex:MatrixSignFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MatrixSignFailure">http://vocab.datex.org/terms#MatrixSignFailure</seealso>
    let MatrixSignFailure = Prefixed_Name(datex, "MatrixSignFailure") |> PrefixedName
    /// <summary>
    ///   <para>datex:MudSlide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MudSlide">http://vocab.datex.org/terms#MudSlide</seealso>
    let MudSlide = Prefixed_Name(datex, "MudSlide") |> PrefixedName
    /// <summary>
    ///   <para>datex:NetworkManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Network management action which is applicable to the road network and its users.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NetworkManagement">http://vocab.datex.org/terms#NetworkManagement</seealso>
    let NetworkManagement = Prefixed_Name(datex, "NetworkManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:OilOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OilOnInfrastructure">http://vocab.datex.org/terms#OilOnInfrastructure</seealso>
    let OilOnInfrastructure =
        Prefixed_Name(datex, "OilOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:OilSpillageAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OilSpillageAccident">http://vocab.datex.org/terms#OilSpillageAccident</seealso>
    let OilSpillageAccident =
        Prefixed_Name(datex, "OilSpillageAccident") |> PrefixedName

    /// <summary>
    ///   <para>datex:PackedSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PackedSnow">http://vocab.datex.org/terms#PackedSnow</seealso>
    let PackedSnow = Prefixed_Name(datex, "PackedSnow") |> PrefixedName
    /// <summary>
    ///   <para>datex:Parade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Parade">http://vocab.datex.org/terms#Parade</seealso>
    let Parade = Prefixed_Name(datex, "Parade") |> PrefixedName
    /// <summary>
    ///   <para>datex:PoliceCheckPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PoliceCheckPoint">http://vocab.datex.org/terms#PoliceCheckPoint</seealso>
    let PoliceCheckPoint = Prefixed_Name(datex, "PoliceCheckPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:PoliceInvestigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PoliceInvestigation">http://vocab.datex.org/terms#PoliceInvestigation</seealso>
    let PoliceInvestigation =
        Prefixed_Name(datex, "PoliceInvestigation") |> PrefixedName

    /// <summary>
    ///   <para>datex:Rain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Rain">http://vocab.datex.org/terms#Rain</seealso>
    let Rain = Prefixed_Name(datex, "Rain") |> PrefixedName
    /// <summary>
    ///   <para>datex:RainChangingToSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RainChangingToSnow">http://vocab.datex.org/terms#RainChangingToSnow</seealso>
    let RainChangingToSnow = Prefixed_Name(datex, "RainChangingToSnow") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadClosure">http://vocab.datex.org/terms#RoadClosure</seealso>
    let RoadClosure = Prefixed_Name(datex, "RoadClosure") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadMarkingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadMarkingWork">http://vocab.datex.org/terms#RoadMarkingWork</seealso>
    let RoadMarkingWork = Prefixed_Name(datex, "RoadMarkingWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadWideningWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadWideningWork">http://vocab.datex.org/terms#RoadWideningWork</seealso>
    let RoadWideningWork = Prefixed_Name(datex, "RoadWideningWork") |> PrefixedName

    /// <summary>
    ///   <para>datex:RockFallPreventativeMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RockFallPreventativeMaintenance">http://vocab.datex.org/terms#RockFallPreventativeMaintenance</seealso>
    let RockFallPreventativeMaintenance =
        Prefixed_Name(datex, "RockFallPreventativeMaintenance") |> PrefixedName

    /// <summary>
    ///   <para>datex:SandStorms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SandStorms">http://vocab.datex.org/terms#SandStorms</seealso>
    let SandStorms = Prefixed_Name(datex, "SandStorms") |> PrefixedName
    /// <summary>
    ///   <para>datex:SecurityAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SecurityAlert">http://vocab.datex.org/terms#SecurityAlert</seealso>
    let SecurityAlert = Prefixed_Name(datex, "SecurityAlert") |> PrefixedName
    /// <summary>
    ///   <para>datex:Showers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Showers">http://vocab.datex.org/terms#Showers</seealso>
    let Showers = Prefixed_Name(datex, "Showers") |> PrefixedName
    /// <summary>
    ///   <para>datex:SideCollision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SideCollision">http://vocab.datex.org/terms#SideCollision</seealso>
    let SideCollision = Prefixed_Name(datex, "SideCollision") |> PrefixedName

    /// <summary>
    ///   <para>datex:SingleAlternateLineTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SingleAlternateLineTraffic">http://vocab.datex.org/terms#SingleAlternateLineTraffic</seealso>
    let SingleAlternateLineTraffic =
        Prefixed_Name(datex, "SingleAlternateLineTraffic") |> PrefixedName

    /// <summary>
    ///   <para>datex:Sleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Sleet">http://vocab.datex.org/terms#Sleet</seealso>
    let Sleet = Prefixed_Name(datex, "Sleet") |> PrefixedName
    /// <summary>
    ///   <para>datex:SlipperyRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlipperyRoad">http://vocab.datex.org/terms#SlipperyRoad</seealso>
    let SlipperyRoad = Prefixed_Name(datex, "SlipperyRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:SlowMovingMaintenanceVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlowMovingMaintenanceVehicle">http://vocab.datex.org/terms#SlowMovingMaintenanceVehicle</seealso>
    let SlowMovingMaintenanceVehicle =
        Prefixed_Name(datex, "SlowMovingMaintenanceVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:Snowplough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Snowplough">http://vocab.datex.org/terms#Snowplough</seealso>
    let Snowplough = Prefixed_Name(datex, "Snowplough") |> PrefixedName
    /// <summary>
    ///   <para>datex:SnowploughsInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SnowploughsInUse">http://vocab.datex.org/terms#SnowploughsInUse</seealso>
    let SnowploughsInUse = Prefixed_Name(datex, "SnowploughsInUse") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpeedControlSignFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedControlSignFailure">http://vocab.datex.org/terms#SpeedControlSignFailure</seealso>
    let SpeedControlSignFailure =
        Prefixed_Name(datex, "SpeedControlSignFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpeedControlSignFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedControlSignFault">http://vocab.datex.org/terms#SpeedControlSignFault</seealso>
    let SpeedControlSignFault =
        Prefixed_Name(datex, "SpeedControlSignFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2SecondaryPointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocationExtension">http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocationExtension</seealso>
    let alertCMethod2SecondaryPointLocationExtension =
        Prefixed_Name(datex, "alertCMethod2SecondaryPointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:dangerousGoodsFlashPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dangerousGoodsFlashPoint">http://vocab.datex.org/terms#dangerousGoodsFlashPoint</seealso>
    let dangerousGoodsFlashPoint =
        Prefixed_Name(datex, "dangerousGoodsFlashPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:dangerousGoodsRegulations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dangerousGoodsRegulations">http://vocab.datex.org/terms#dangerousGoodsRegulations</seealso>
    let dangerousGoodsRegulations =
        Prefixed_Name(datex, "dangerousGoodsRegulations") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardCodeIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardCodeIdentification">http://vocab.datex.org/terms#hazardCodeIdentification</seealso>
    let hazardCodeIdentification =
        Prefixed_Name(datex, "hazardCodeIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardCodeVersionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardCodeVersionNumber">http://vocab.datex.org/terms#hazardCodeVersionNumber</seealso>
    let hazardCodeVersionNumber =
        Prefixed_Name(datex, "hazardCodeVersionNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardSubstanceItemPageNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardSubstanceItemPageNumber">http://vocab.datex.org/terms#hazardSubstanceItemPageNumber</seealso>
    let hazardSubstanceItemPageNumber =
        Prefixed_Name(datex, "hazardSubstanceItemPageNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardousMaterialsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardousMaterialsExtension">http://vocab.datex.org/terms#hazardousMaterialsExtension</seealso>
    let hazardousMaterialsExtension =
        Prefixed_Name(datex, "hazardousMaterialsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfEquipmentOrServiceFacilityOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacilityOverride">http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacilityOverride</seealso>
    let numberOfEquipmentOrServiceFacilityOverride =
        Prefixed_Name(datex, "numberOfEquipmentOrServiceFacilityOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfSubitemsOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfSubitemsOverride">http://vocab.datex.org/terms#numberOfSubitemsOverride</seealso>
    let numberOfSubitemsOverride =
        Prefixed_Name(datex, "numberOfSubitemsOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingEquipmentOrServiceFacilityStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatusExtension">http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatusExtension</seealso>
    let parkingEquipmentOrServiceFacilityStatusExtension =
        Prefixed_Name(datex, "parkingEquipmentOrServiceFacilityStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordStatus">http://vocab.datex.org/terms#parkingRecordStatus</seealso>
    let parkingRecordStatus =
        Prefixed_Name(datex, "parkingRecordStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTableReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTableReference">http://vocab.datex.org/terms#parkingTableReference</seealso>
    let parkingTableReference =
        Prefixed_Name(datex, "parkingTableReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingTableVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingTableVersionedReference">http://vocab.datex.org/terms#_ParkingTableVersionedReference</seealso>
    let _ParkingTableVersionedReference =
        Prefixed_Name(datex, "_ParkingTableVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusTime">http://vocab.datex.org/terms#parkingStatusTime</seealso>
    let parkingStatusTime = Prefixed_Name(datex, "parkingStatusTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusValidityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusValidityExtension">http://vocab.datex.org/terms#parkingStatusValidityExtension</seealso>
    let parkingStatusValidityExtension =
        Prefixed_Name(datex, "parkingStatusValidityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:validityTimeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validityTimeSpecification">http://vocab.datex.org/terms#validityTimeSpecification</seealso>
    let validityTimeSpecification =
        Prefixed_Name(datex, "validityTimeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of parking records, which can be parking sites or groups of parking sites.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingTable">http://vocab.datex.org/terms#ParkingTable</seealso>
    let ParkingTable = Prefixed_Name(datex, "ParkingTable") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A name assigned to the predefined location (e.g. extracted out of the network operator's gazetteer).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationName">http://vocab.datex.org/terms#predefinedLocationName</seealso>
    let predefinedLocationName =
        Prefixed_Name(datex, "predefinedLocationName") |> PrefixedName

    /// <summary>
    ///   <para>datex:TransitInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The availability of transit services and information relating to their departures. This is limited to those transit services which are of direct relevance to road users, e.g. connecting rail or ferry services.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TransitInformation">http://vocab.datex.org/terms#TransitInformation</seealso>
    let TransitInformation = Prefixed_Name(datex, "TransitInformation") |> PrefixedName
    /// <summary>
    ///   <para>datex:journeyDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the stated termination point of the transit journey.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#journeyDestination">http://vocab.datex.org/terms#journeyDestination</seealso>
    let journeyDestination = Prefixed_Name(datex, "journeyDestination") |> PrefixedName
    /// <summary>
    ///   <para>datex:journeyOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the stated starting point of the transit journey.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#journeyOrigin">http://vocab.datex.org/terms#journeyOrigin</seealso>
    let journeyOrigin = Prefixed_Name(datex, "journeyOrigin") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogramDisplayAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogramDisplayAreaExtension">http://vocab.datex.org/terms#vmsPictogramDisplayAreaExtension</seealso>
    let vmsPictogramDisplayAreaExtension =
        Prefixed_Name(datex, "vmsPictogramDisplayAreaExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsPictogramDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Characteristics specific to the pictogram display area(s) on the VMS where pictogramDisplayAreaIndex indicates which pictogram area it relates to.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsPictogramDisplayCharacteristics">http://vocab.datex.org/terms#VmsPictogramDisplayCharacteristics</seealso>
    let VmsPictogramDisplayCharacteristics =
        Prefixed_Name(datex, "VmsPictogramDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxNumberOfSequentialPictograms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxNumberOfSequentialPictograms">http://vocab.datex.org/terms#maxNumberOfSequentialPictograms</seealso>
    let maxNumberOfSequentialPictograms =
        Prefixed_Name(datex, "maxNumberOfSequentialPictograms") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxPictogramLuminanceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxPictogramLuminanceLevel">http://vocab.datex.org/terms#maxPictogramLuminanceLevel</seealso>
    let maxPictogramLuminanceLevel =
        Prefixed_Name(datex, "maxPictogramLuminanceLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramCodeListIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramCodeListIdentifier">http://vocab.datex.org/terms#pictogramCodeListIdentifier</seealso>
    let pictogramCodeListIdentifier =
        Prefixed_Name(datex, "pictogramCodeListIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDisplayHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDisplayHeight">http://vocab.datex.org/terms#pictogramDisplayHeight</seealso>
    let pictogramDisplayHeight =
        Prefixed_Name(datex, "pictogramDisplayHeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDisplayWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDisplayWidth">http://vocab.datex.org/terms#pictogramDisplayWidth</seealso>
    let pictogramDisplayWidth =
        Prefixed_Name(datex, "pictogramDisplayWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramLanternsPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramLanternsPresent">http://vocab.datex.org/terms#pictogramLanternsPresent</seealso>
    let pictogramLanternsPresent =
        Prefixed_Name(datex, "pictogramLanternsPresent") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramNumberOfColours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramNumberOfColours">http://vocab.datex.org/terms#pictogramNumberOfColours</seealso>
    let pictogramNumberOfColours =
        Prefixed_Name(datex, "pictogramNumberOfColours") |> PrefixedName

    /// <summary>
    ///   <para>datex:Accident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Accident">http://vocab.datex.org/terms#Accident</seealso>
    let Accident = Prefixed_Name(datex, "Accident") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingHazardousMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingHazardousMaterials">http://vocab.datex.org/terms#AccidentInvolvingHazardousMaterials</seealso>
    let AccidentInvolvingHazardousMaterials =
        Prefixed_Name(datex, "AccidentInvolvingHazardousMaterials") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureMaintenance">http://vocab.datex.org/terms#InfrastructureMaintenance</seealso>
    let InfrastructureMaintenance =
        Prefixed_Name(datex, "InfrastructureMaintenance") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSidePowerSystemFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFault">http://vocab.datex.org/terms#InfrastructureSidePowerSystemFault</seealso>
    let InfrastructureSidePowerSystemFault =
        Prefixed_Name(datex, "InfrastructureSidePowerSystemFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureWorksClearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureWorksClearance">http://vocab.datex.org/terms#InfrastructureWorksClearance</seealso>
    let InfrastructureWorksClearance =
        Prefixed_Name(datex, "InfrastructureWorksClearance") |> PrefixedName

    /// <summary>
    ///   <para>datex:JackknifedArticulatedLorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#JackknifedArticulatedLorry">http://vocab.datex.org/terms#JackknifedArticulatedLorry</seealso>
    let JackknifedArticulatedLorry =
        Prefixed_Name(datex, "JackknifedArticulatedLorry") |> PrefixedName

    /// <summary>
    ///   <para>datex:JuridicalReconstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#JuridicalReconstruction">http://vocab.datex.org/terms#JuridicalReconstruction</seealso>
    let JuridicalReconstruction =
        Prefixed_Name(datex, "JuridicalReconstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:LargeAnimalsOnTheInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LargeAnimalsOnTheInfrastructure">http://vocab.datex.org/terms#LargeAnimalsOnTheInfrastructure</seealso>
    let LargeAnimalsOnTheInfrastructure =
        Prefixed_Name(datex, "LargeAnimalsOnTheInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LitterClearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LitterClearance">http://vocab.datex.org/terms#LitterClearance</seealso>
    let LitterClearance = Prefixed_Name(datex, "LitterClearance") |> PrefixedName
    /// <summary>
    ///   <para>datex:MaintenanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MaintenanceWork">http://vocab.datex.org/terms#MaintenanceWork</seealso>
    let MaintenanceWork = Prefixed_Name(datex, "MaintenanceWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:March</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#March">http://vocab.datex.org/terms#March</seealso>
    let March = Prefixed_Name(datex, "March") |> PrefixedName
    /// <summary>
    ///   <para>datex:Market</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Market">http://vocab.datex.org/terms#Market</seealso>
    let Market = Prefixed_Name(datex, "Market") |> PrefixedName

    /// <summary>
    ///   <para>datex:MultivehicleAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MultivehicleAccident">http://vocab.datex.org/terms#MultivehicleAccident</seealso>
    let MultivehicleAccident =
        Prefixed_Name(datex, "MultivehicleAccident") |> PrefixedName

    /// <summary>
    ///   <para>datex:NarrowLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NarrowLanes">http://vocab.datex.org/terms#NarrowLanes</seealso>
    let NarrowLanes = Prefixed_Name(datex, "NarrowLanes") |> PrefixedName
    /// <summary>
    ///   <para>datex:OverheadWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverheadWorks">http://vocab.datex.org/terms#OverheadWorks</seealso>
    let OverheadWorks = Prefixed_Name(datex, "OverheadWorks") |> PrefixedName
    /// <summary>
    ///   <para>datex:OverheightVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverheightVehicle">http://vocab.datex.org/terms#OverheightVehicle</seealso>
    let OverheightVehicle = Prefixed_Name(datex, "OverheightVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:PatchyFog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PatchyFog">http://vocab.datex.org/terms#PatchyFog</seealso>
    let PatchyFog = Prefixed_Name(datex, "PatchyFog") |> PrefixedName

    /// <summary>
    ///   <para>datex:PetrolOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PetrolOnInfrastructure">http://vocab.datex.org/terms#PetrolOnInfrastructure</seealso>
    let PetrolOnInfrastructure =
        Prefixed_Name(datex, "PetrolOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:PublicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Organised public event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PublicEvent">http://vocab.datex.org/terms#PublicEvent</seealso>
    let PublicEvent = Prefixed_Name(datex, "PublicEvent") |> PrefixedName
    /// <summary>
    ///   <para>datex:QueuingTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#QueuingTraffic">http://vocab.datex.org/terms#QueuingTraffic</seealso>
    let QueuingTraffic = Prefixed_Name(datex, "QueuingTraffic") |> PrefixedName
    /// <summary>
    ///   <para>datex:RampControlFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RampControlFailure">http://vocab.datex.org/terms#RampControlFailure</seealso>
    let RampControlFailure = Prefixed_Name(datex, "RampControlFailure") |> PrefixedName
    /// <summary>
    ///   <para>datex:RampControlFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RampControlFault">http://vocab.datex.org/terms#RampControlFault</seealso>
    let RampControlFault = Prefixed_Name(datex, "RampControlFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadOperatorCheckPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadOperatorCheckPoint">http://vocab.datex.org/terms#RoadOperatorCheckPoint</seealso>
    let RoadOperatorCheckPoint =
        Prefixed_Name(datex, "RoadOperatorCheckPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadOrCarriagewayOrLaneManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Road, carriageway or lane management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadOrCarriagewayOrLaneManagement">http://vocab.datex.org/terms#RoadOrCarriagewayOrLaneManagement</seealso>
    let RoadOrCarriagewayOrLaneManagement =
        Prefixed_Name(datex, "RoadOrCarriagewayOrLaneManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:Sabotage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Sabotage">http://vocab.datex.org/terms#Sabotage</seealso>
    let Sabotage = Prefixed_Name(datex, "Sabotage") |> PrefixedName
    /// <summary>
    ///   <para>datex:SaltingInProgress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SaltingInProgress">http://vocab.datex.org/terms#SaltingInProgress</seealso>
    let SaltingInProgress = Prefixed_Name(datex, "SaltingInProgress") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod2Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road between two points, Primary and Secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod2Linear">http://vocab.datex.org/terms#AlertCMethod2Linear</seealso>
    let AlertCMethod2Linear =
        Prefixed_Name(datex, "AlertCMethod2Linear") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2LinearExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2LinearExtension">http://vocab.datex.org/terms#alertCMethod2LinearExtension</seealso>
    let alertCMethod2LinearExtension =
        Prefixed_Name(datex, "alertCMethod2LinearExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocation">http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocation</seealso>
    let alertCMethod2PrimaryPointLocation =
        Prefixed_Name(datex, "alertCMethod2PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod2PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod2PrimaryPointLocation">http://vocab.datex.org/terms#AlertCMethod2PrimaryPointLocation</seealso>
    let AlertCMethod2PrimaryPointLocation =
        Prefixed_Name(datex, "AlertCMethod2PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocation">http://vocab.datex.org/terms#alertCMethod2SecondaryPointLocation</seealso>
    let alertCMethod2SecondaryPointLocation =
        Prefixed_Name(datex, "alertCMethod2SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod2Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod2Point">http://vocab.datex.org/terms#AlertCMethod2Point</seealso>
    let AlertCMethod2Point = Prefixed_Name(datex, "AlertCMethod2Point") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2PointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2PointExtension">http://vocab.datex.org/terms#alertCMethod2PointExtension</seealso>
    let alertCMethod2PointExtension =
        Prefixed_Name(datex, "alertCMethod2PointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCPoint">http://vocab.datex.org/terms#AlertCPoint</seealso>
    let AlertCPoint = Prefixed_Name(datex, "AlertCPoint") |> PrefixedName
    /// <summary>
    ///   <para>datex:alertCLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocation">http://vocab.datex.org/terms#alertCLocation</seealso>
    let alertCLocation = Prefixed_Name(datex, "alertCLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod2PrimaryPointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocationExtension">http://vocab.datex.org/terms#alertCMethod2PrimaryPointLocationExtension</seealso>
    let alertCMethod2PrimaryPointLocationExtension =
        Prefixed_Name(datex, "alertCMethod2PrimaryPointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:elaboratedDataFaultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#elaboratedDataFaultExtension">http://vocab.datex.org/terms#elaboratedDataFaultExtension</seealso>
    let elaboratedDataFaultExtension =
        Prefixed_Name(datex, "elaboratedDataFaultExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Fault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about a fault relating to a specific piece of equipment or process.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Fault">http://vocab.datex.org/terms#Fault</seealso>
    let Fault = Prefixed_Name(datex, "Fault") |> PrefixedName

    /// <summary>
    ///   <para>datex:ElaboratedDataPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more elaborated data sets.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ElaboratedDataPublication">http://vocab.datex.org/terms#ElaboratedDataPublication</seealso>
    let ElaboratedDataPublication =
        Prefixed_Name(datex, "ElaboratedDataPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:elaboratedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#elaboratedData">http://vocab.datex.org/terms#elaboratedData</seealso>
    let elaboratedData = Prefixed_Name(datex, "elaboratedData") |> PrefixedName

    /// <summary>
    ///   <para>datex:elaboratedDataPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#elaboratedDataPublicationExtension">http://vocab.datex.org/terms#elaboratedDataPublicationExtension</seealso>
    let elaboratedDataPublicationExtension =
        Prefixed_Name(datex, "elaboratedDataPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:forecastDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The default value for the publication of whether the elaborated data is a forecast (true = forecast).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#forecastDefault">http://vocab.datex.org/terms#forecastDefault</seealso>
    let forecastDefault = Prefixed_Name(datex, "forecastDefault") |> PrefixedName
    /// <summary>
    ///   <para>datex:headerInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#headerInformation">http://vocab.datex.org/terms#headerInformation</seealso>
    let headerInformation = Prefixed_Name(datex, "headerInformation") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeaderInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Management information relating to the data contained within a publication.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeaderInformation">http://vocab.datex.org/terms#HeaderInformation</seealso>
    let HeaderInformation = Prefixed_Name(datex, "HeaderInformation") |> PrefixedName
    /// <summary>
    ///   <para>datex:periodDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The default value for the publication of the time elapsed between the beginning and the end of the sampling or measurement period. This item may differ from the unit attribute; e.g. an hourly flow can be estimated from a 5-minute measurement period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#periodDefault">http://vocab.datex.org/terms#periodDefault</seealso>
    let periodDefault = Prefixed_Name(datex, "periodDefault") |> PrefixedName
    /// <summary>
    ///   <para>datex:referenceSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referenceSettings">http://vocab.datex.org/terms#referenceSettings</seealso>
    let referenceSettings = Prefixed_Name(datex, "referenceSettings") |> PrefixedName
    /// <summary>
    ///   <para>datex:ReferenceSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of the default value for traffic status on a group of predefined locations on the road network. Only when traffic status differs from this value at a location in the group need a value be sent.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ReferenceSettings">http://vocab.datex.org/terms#ReferenceSettings</seealso>
    let ReferenceSettings = Prefixed_Name(datex, "ReferenceSettings") |> PrefixedName
    /// <summary>
    ///   <para>datex:timeDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The default for the publication of the time at which the values have been computed/derived.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timeDefault">http://vocab.datex.org/terms#timeDefault</seealso>
    let timeDefault = Prefixed_Name(datex, "timeDefault") |> PrefixedName
    /// <summary>
    ///   <para>datex:tremCardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tremCardNumber">http://vocab.datex.org/terms#tremCardNumber</seealso>
    let tremCardNumber = Prefixed_Name(datex, "tremCardNumber") |> PrefixedName
    /// <summary>
    ///   <para>datex:undgNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#undgNumber">http://vocab.datex.org/terms#undgNumber</seealso>
    let undgNumber = Prefixed_Name(datex, "undgNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:volumeOfDangerousGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#volumeOfDangerousGoods">http://vocab.datex.org/terms#volumeOfDangerousGoods</seealso>
    let volumeOfDangerousGoods =
        Prefixed_Name(datex, "volumeOfDangerousGoods") |> PrefixedName

    /// <summary>
    ///   <para>datex:weightOfDangerousGoods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weightOfDangerousGoods">http://vocab.datex.org/terms#weightOfDangerousGoods</seealso>
    let weightOfDangerousGoods =
        Prefixed_Name(datex, "weightOfDangerousGoods") |> PrefixedName

    /// <summary>
    ///   <para>datex:areaOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaOfInterest">http://vocab.datex.org/terms#areaOfInterest</seealso>
    let areaOfInterest = Prefixed_Name(datex, "areaOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>datex:confidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#confidentiality">http://vocab.datex.org/terms#confidentiality</seealso>
    let confidentiality = Prefixed_Name(datex, "confidentiality") |> PrefixedName

    /// <summary>
    ///   <para>datex:headerInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#headerInformationExtension">http://vocab.datex.org/terms#headerInformationExtension</seealso>
    let headerInformationExtension =
        Prefixed_Name(datex, "headerInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:informationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#informationStatus">http://vocab.datex.org/terms#informationStatus</seealso>
    let informationStatus = Prefixed_Name(datex, "informationStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:urgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urgency">http://vocab.datex.org/terms#urgency</seealso>
    let urgency = Prefixed_Name(datex, "urgency") |> PrefixedName

    /// <summary>
    ///   <para>datex:OccupancyChangeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of change of occupied parking spaces expressed as integer.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OccupancyChangeValue">http://vocab.datex.org/terms#OccupancyChangeValue</seealso>
    let OccupancyChangeValue =
        Prefixed_Name(datex, "OccupancyChangeValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:occupancyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measured or calculated absolut change of occupied parking spaces within a specified time expressed as integer.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#occupancyChange">http://vocab.datex.org/terms#occupancyChange</seealso>
    let occupancyChange = Prefixed_Name(datex, "occupancyChange") |> PrefixedName

    /// <summary>
    ///   <para>datex:occupancyChangeValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#occupancyChangeValueExtension">http://vocab.datex.org/terms#occupancyChangeValueExtension</seealso>
    let occupancyChangeValueExtension =
        Prefixed_Name(datex, "occupancyChangeValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingColour">http://vocab.datex.org/terms#parkingColour</seealso>
    let parkingColour = Prefixed_Name(datex, "parkingColour") |> PrefixedName
    /// <summary>
    ///   <para>datex:RGBColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An RGB colour described by values for red, green and blue (0..255) as well as an optional name.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RGBColour">http://vocab.datex.org/terms#RGBColour</seealso>
    let RGBColour = Prefixed_Name(datex, "RGBColour") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingDescription">http://vocab.datex.org/terms#parkingDescription</seealso>
    let parkingDescription = Prefixed_Name(datex, "parkingDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacility">http://vocab.datex.org/terms#parkingEquipmentOrServiceFacility</seealso>
    let parkingEquipmentOrServiceFacility =
        Prefixed_Name(datex, "parkingEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility">http://vocab.datex.org/terms#_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility</seealso>
    let _ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        Prefixed_Name(datex, "_ParkingRecordEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingLocation">http://vocab.datex.org/terms#parkingLocation</seealso>
    let parkingLocation = Prefixed_Name(datex, "parkingLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingName">http://vocab.datex.org/terms#parkingName</seealso>
    let parkingName = Prefixed_Name(datex, "parkingName") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTableVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTableVersionTime">http://vocab.datex.org/terms#parkingTableVersionTime</seealso>
    let parkingTableVersionTime =
        Prefixed_Name(datex, "parkingTableVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingTablePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication defining one or more tables that have entries of parking sites or groups of them, located in an urban or interurban context.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingTablePublication">http://vocab.datex.org/terms#ParkingTablePublication</seealso>
    let ParkingTablePublication =
        Prefixed_Name(datex, "ParkingTablePublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:PredefinedNonOrderedLocationGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable versioned instance of a predefined group of non ordered locations (i.e. more than one).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PredefinedNonOrderedLocationGroup">http://vocab.datex.org/terms#PredefinedNonOrderedLocationGroup</seealso>
    let PredefinedNonOrderedLocationGroup =
        Prefixed_Name(datex, "PredefinedNonOrderedLocationGroup") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedNonOrderedLocationGroupExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupExtension">http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupExtension</seealso>
    let predefinedNonOrderedLocationGroupExtension =
        Prefixed_Name(datex, "predefinedNonOrderedLocationGroupExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedNonOrderedLocationGroupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A name assigned to the predefined group of non ordered locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupName">http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupName</seealso>
    let predefinedNonOrderedLocationGroupName =
        Prefixed_Name(datex, "predefinedNonOrderedLocationGroupName") |> PrefixedName

    /// <summary>
    ///   <para>datex:publicEventExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicEventExtension">http://vocab.datex.org/terms#publicEventExtension</seealso>
    let publicEventExtension =
        Prefixed_Name(datex, "publicEventExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PublicHoliday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of the public holiday type in a specific country or region. Use this component only when specialDayType is set to 'publicHoliday' or 'holidays'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PublicHoliday">http://vocab.datex.org/terms#PublicHoliday</seealso>
    let PublicHoliday = Prefixed_Name(datex, "PublicHoliday") |> PrefixedName
    /// <summary>
    ///   <para>datex:countrySubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#countrySubdivision">http://vocab.datex.org/terms#countrySubdivision</seealso>
    let countrySubdivision = Prefixed_Name(datex, "countrySubdivision") |> PrefixedName

    /// <summary>
    ///   <para>datex:publicHolidayExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicHolidayExtension">http://vocab.datex.org/terms#publicHolidayExtension</seealso>
    let publicHolidayExtension =
        Prefixed_Name(datex, "publicHolidayExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:publicHolidayName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicHolidayName">http://vocab.datex.org/terms#publicHolidayName</seealso>
    let publicHolidayName = Prefixed_Name(datex, "publicHolidayName") |> PrefixedName
    /// <summary>
    ///   <para>datex:publicHolidayType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicHolidayType">http://vocab.datex.org/terms#publicHolidayType</seealso>
    let publicHolidayType = Prefixed_Name(datex, "publicHolidayType") |> PrefixedName
    /// <summary>
    ///   <para>datex:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#region">http://vocab.datex.org/terms#region</seealso>
    let region = Prefixed_Name(datex, "region") |> PrefixedName
    /// <summary>
    ///   <para>datex:colourName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#colourName">http://vocab.datex.org/terms#colourName</seealso>
    let colourName = Prefixed_Name(datex, "colourName") |> PrefixedName
    /// <summary>
    ///   <para>datex:rgbBlueValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#rgbBlueValue">http://vocab.datex.org/terms#rgbBlueValue</seealso>
    let rgbBlueValue = Prefixed_Name(datex, "rgbBlueValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:rgbColourExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#rgbColourExtension">http://vocab.datex.org/terms#rgbColourExtension</seealso>
    let rgbColourExtension = Prefixed_Name(datex, "rgbColourExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:rgbGreenValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#rgbGreenValue">http://vocab.datex.org/terms#rgbGreenValue</seealso>
    let rgbGreenValue = Prefixed_Name(datex, "rgbGreenValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:rgbRedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#rgbRedValue">http://vocab.datex.org/terms#rgbRedValue</seealso>
    let rgbRedValue = Prefixed_Name(datex, "rgbRedValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:deleteSubscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deleteSubscription">http://vocab.datex.org/terms#deleteSubscription</seealso>
    let deleteSubscription = Prefixed_Name(datex, "deleteSubscription") |> PrefixedName
    /// <summary>
    ///   <para>datex:deliveryInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deliveryInterval">http://vocab.datex.org/terms#deliveryInterval</seealso>
    let deliveryInterval = Prefixed_Name(datex, "deliveryInterval") |> PrefixedName
    /// <summary>
    ///   <para>datex:operatingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operatingMode">http://vocab.datex.org/terms#operatingMode</seealso>
    let operatingMode = Prefixed_Name(datex, "operatingMode") |> PrefixedName

    /// <summary>
    ///   <para>datex:subscriptionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscriptionExtension">http://vocab.datex.org/terms#subscriptionExtension</seealso>
    let subscriptionExtension =
        Prefixed_Name(datex, "subscriptionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:subscriptionStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscriptionStartTime">http://vocab.datex.org/terms#subscriptionStartTime</seealso>
    let subscriptionStartTime =
        Prefixed_Name(datex, "subscriptionStartTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:subscriptionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscriptionState">http://vocab.datex.org/terms#subscriptionState</seealso>
    let subscriptionState = Prefixed_Name(datex, "subscriptionState") |> PrefixedName

    /// <summary>
    ///   <para>datex:subscriptionStopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscriptionStopTime">http://vocab.datex.org/terms#subscriptionStopTime</seealso>
    let subscriptionStopTime =
        Prefixed_Name(datex, "subscriptionStopTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationPrecision">http://vocab.datex.org/terms#locationPrecision</seealso>
    let locationPrecision = Prefixed_Name(datex, "locationPrecision") |> PrefixedName

    /// <summary>
    ///   <para>datex:affectedCarriagewayAndLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#affectedCarriagewayAndLanes">http://vocab.datex.org/terms#affectedCarriagewayAndLanes</seealso>
    let affectedCarriagewayAndLanes =
        Prefixed_Name(datex, "affectedCarriagewayAndLanes") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPositionalDescriptionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPositionalDescriptionExtension">http://vocab.datex.org/terms#supplementaryPositionalDescriptionExtension</seealso>
    let supplementaryPositionalDescriptionExtension =
        Prefixed_Name(datex, "supplementaryPositionalDescriptionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#address">http://vocab.datex.org/terms#address</seealso>
    let address = Prefixed_Name(datex, "address") |> PrefixedName
    /// <summary>
    ///   <para>datex:protocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#protocol">http://vocab.datex.org/terms#protocol</seealso>
    let protocol = Prefixed_Name(datex, "protocol") |> PrefixedName
    /// <summary>
    ///   <para>datex:targetExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#targetExtension">http://vocab.datex.org/terms#targetExtension</seealso>
    let targetExtension = Prefixed_Name(datex, "targetExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:acceptedMeansOfPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#acceptedMeansOfPayment">http://vocab.datex.org/terms#acceptedMeansOfPayment</seealso>
    let acceptedMeansOfPayment =
        Prefixed_Name(datex, "acceptedMeansOfPayment") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsLocation">http://vocab.datex.org/terms#vmsLocation</seealso>
    let vmsLocation = Prefixed_Name(datex, "vmsLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsManagedLogicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsManagedLogicalLocation">http://vocab.datex.org/terms#vmsManagedLogicalLocation</seealso>
    let vmsManagedLogicalLocation =
        Prefixed_Name(datex, "vmsManagedLogicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsOwner">http://vocab.datex.org/terms#vmsOwner</seealso>
    let vmsOwner = Prefixed_Name(datex, "vmsOwner") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPhysicalMounting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPhysicalMounting">http://vocab.datex.org/terms#vmsPhysicalMounting</seealso>
    let vmsPhysicalMounting =
        Prefixed_Name(datex, "vmsPhysicalMounting") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics">http://vocab.datex.org/terms#_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics</seealso>
    let _VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        Prefixed_Name(datex, "_VmsRecordPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsRecordExtension">http://vocab.datex.org/terms#vmsRecordExtension</seealso>
    let vmsRecordExtension = Prefixed_Name(datex, "vmsRecordExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsType">http://vocab.datex.org/terms#vmsType</seealso>
    let vmsType = Prefixed_Name(datex, "vmsType") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTypeCode">http://vocab.datex.org/terms#vmsTypeCode</seealso>
    let vmsTypeCode = Prefixed_Name(datex, "vmsTypeCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSettingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSettingExtension">http://vocab.datex.org/terms#vmsSettingExtension</seealso>
    let vmsSettingExtension =
        Prefixed_Name(datex, "vmsSettingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsSupplementaryPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An additional pictogram that is displayed in the panel which is supplemental to the associated pictogram display.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsSupplementaryPictogram">http://vocab.datex.org/terms#VmsSupplementaryPictogram</seealso>
    let VmsSupplementaryPictogram =
        Prefixed_Name(datex, "VmsSupplementaryPictogram") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryText">http://vocab.datex.org/terms#vmsSupplementaryText</seealso>
    let vmsSupplementaryText =
        Prefixed_Name(datex, "vmsSupplementaryText") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsTextLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single line of text on a text display area or supplementary panel.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsTextLine">http://vocab.datex.org/terms#VmsTextLine</seealso>
    let VmsTextLine = Prefixed_Name(datex, "VmsTextLine") |> PrefixedName

    /// <summary>
    ///   <para>datex:relativePositionToPictogramArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#relativePositionToPictogramArea">http://vocab.datex.org/terms#relativePositionToPictogramArea</seealso>
    let relativePositionToPictogramArea =
        Prefixed_Name(datex, "relativePositionToPictogramArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelDisplayHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelDisplayHeight">http://vocab.datex.org/terms#supplementaryPanelDisplayHeight</seealso>
    let supplementaryPanelDisplayHeight =
        Prefixed_Name(datex, "supplementaryPanelDisplayHeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelDisplayWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelDisplayWidth">http://vocab.datex.org/terms#supplementaryPanelDisplayWidth</seealso>
    let supplementaryPanelDisplayWidth =
        Prefixed_Name(datex, "supplementaryPanelDisplayWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelPixelsAcross</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelPixelsAcross">http://vocab.datex.org/terms#supplementaryPanelPixelsAcross</seealso>
    let supplementaryPanelPixelsAcross =
        Prefixed_Name(datex, "supplementaryPanelPixelsAcross") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelPixelsDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelPixelsDown">http://vocab.datex.org/terms#supplementaryPanelPixelsDown</seealso>
    let supplementaryPanelPixelsDown =
        Prefixed_Name(datex, "supplementaryPanelPixelsDown") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelPositionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelPositionX">http://vocab.datex.org/terms#supplementaryPanelPositionX</seealso>
    let supplementaryPanelPositionX =
        Prefixed_Name(datex, "supplementaryPanelPositionX") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPanelPositionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPanelPositionY">http://vocab.datex.org/terms#supplementaryPanelPositionY</seealso>
    let supplementaryPanelPositionY =
        Prefixed_Name(datex, "supplementaryPanelPositionY") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPictogramCodeListIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPictogramCodeListIdentifier">http://vocab.datex.org/terms#supplementaryPictogramCodeListIdentifier</seealso>
    let supplementaryPictogramCodeListIdentifier =
        Prefixed_Name(datex, "supplementaryPictogramCodeListIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPanelCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristicsExtension">http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristicsExtension</seealso>
    let vmsSupplementaryPanelCharacteristicsExtension =
        Prefixed_Name(datex, "vmsSupplementaryPanelCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:additionalSupplementaryPictogramDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#additionalSupplementaryPictogramDescription">http://vocab.datex.org/terms#additionalSupplementaryPictogramDescription</seealso>
    let additionalSupplementaryPictogramDescription =
        Prefixed_Name(datex, "additionalSupplementaryPictogramDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsText">http://vocab.datex.org/terms#vmsText</seealso>
    let vmsText = Prefixed_Name(datex, "vmsText") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCharacteristicsExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCharacteristicsExtended">http://vocab.datex.org/terms#vehicleCharacteristicsExtended</seealso>
    let vehicleCharacteristicsExtended =
        Prefixed_Name(datex, "vehicleCharacteristicsExtended") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDisplayAreaIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDisplayAreaIndex">http://vocab.datex.org/terms#pictogramDisplayAreaIndex</seealso>
    let pictogramDisplayAreaIndex =
        Prefixed_Name(datex, "pictogramDisplayAreaIndex") |> PrefixedName

    /// <summary>
    ///   <para>datex:messageIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#messageIndex">http://vocab.datex.org/terms#messageIndex</seealso>
    let messageIndex = Prefixed_Name(datex, "messageIndex") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramSequencingIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramSequencingIndex">http://vocab.datex.org/terms#pictogramSequencingIndex</seealso>
    let pictogramSequencingIndex =
        Prefixed_Name(datex, "pictogramSequencingIndex") |> PrefixedName

    /// <summary>
    ///   <para>datex:lineIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lineIndex">http://vocab.datex.org/terms#lineIndex</seealso>
    let lineIndex = Prefixed_Name(datex, "lineIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsIndex">http://vocab.datex.org/terms#vmsIndex</seealso>
    let vmsIndex = Prefixed_Name(datex, "vmsIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:d2LogicalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#d2LogicalModel">http://vocab.datex.org/terms#d2LogicalModel</seealso>
    let d2LogicalModel = Prefixed_Name(datex, "d2LogicalModel") |> PrefixedName
    /// <summary>
    ///   <para>datex:ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>An example mapping of Datex2 to an OWL vocabulary</para>
    /// labels<para>Linked Datex II</para></remarks>
    /// <seealso href="http://vocab.datex.org/terms#ontology">http://vocab.datex.org/terms#ontology</seealso>
    let ontology = Prefixed_Name(datex, "ontology") |> PrefixedName
    /// <summary>
    ///   <para>datex:AbnormalLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AbnormalLoad">http://vocab.datex.org/terms#AbnormalLoad</seealso>
    let AbnormalLoad = Prefixed_Name(datex, "AbnormalLoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvestigationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvestigationWork">http://vocab.datex.org/terms#AccidentInvestigationWork</seealso>
    let AccidentInvestigationWork =
        Prefixed_Name(datex, "AccidentInvestigationWork") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingRadioactiveMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingRadioactiveMaterial">http://vocab.datex.org/terms#AccidentInvolvingRadioactiveMaterial</seealso>
    let AccidentInvolvingRadioactiveMaterial =
        Prefixed_Name(datex, "AccidentInvolvingRadioactiveMaterial") |> PrefixedName

    /// <summary>
    ///   <para>datex:ActiveSpeedControlInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ActiveSpeedControlInOperation">http://vocab.datex.org/terms#ActiveSpeedControlInOperation</seealso>
    let ActiveSpeedControlInOperation =
        Prefixed_Name(datex, "ActiveSpeedControlInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AdverseInfrastructureConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AdverseInfrastructureConditions">http://vocab.datex.org/terms#AdverseInfrastructureConditions</seealso>
    let AdverseInfrastructureConditions =
        Prefixed_Name(datex, "AdverseInfrastructureConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:AirRaid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AirRaid">http://vocab.datex.org/terms#AirRaid</seealso>
    let AirRaid = Prefixed_Name(datex, "AirRaid") |> PrefixedName

    /// <summary>
    ///   <para>datex:ChargeBandByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Using (a) prior defined charge band(s), identified by its reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ChargeBandByReference">http://vocab.datex.org/terms#ChargeBandByReference</seealso>
    let ChargeBandByReference =
        Prefixed_Name(datex, "ChargeBandByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrRectangleLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrRectangleLocationReferenceExtension">http://vocab.datex.org/terms#openlrRectangleLocationReferenceExtension</seealso>
    let openlrRectangleLocationReferenceExtension =
        Prefixed_Name(datex, "openlrRectangleLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:lastCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lastCalibration">http://vocab.datex.org/terms#lastCalibration</seealso>
    let lastCalibration = Prefixed_Name(datex, "lastCalibration") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceDeclarationValidNow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceDeclarationValidNow">http://vocab.datex.org/terms#parkingSpaceDeclarationValidNow</seealso>
    let parkingSpaceDeclarationValidNow =
        Prefixed_Name(datex, "parkingSpaceDeclarationValidNow") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PolygonAreaIndexPointCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PolygonAreaIndexPointCoordinates">http://vocab.datex.org/terms#_PolygonAreaIndexPointCoordinates</seealso>
    let _PolygonAreaIndexPointCoordinates =
        Prefixed_Name(datex, "_PolygonAreaIndexPointCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>datex:polygonAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#polygonAreaExtension">http://vocab.datex.org/terms#polygonAreaExtension</seealso>
    let polygonAreaExtension =
        Prefixed_Name(datex, "polygonAreaExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PoorEnvironmentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any environmental conditions which may be affecting the driving conditions on the road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PoorEnvironmentConditions">http://vocab.datex.org/terms#PoorEnvironmentConditions</seealso>
    let PoorEnvironmentConditions =
        Prefixed_Name(datex, "PoorEnvironmentConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:poorEnvironmentConditionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#poorEnvironmentConditionsExtension">http://vocab.datex.org/terms#poorEnvironmentConditionsExtension</seealso>
    let poorEnvironmentConditionsExtension =
        Prefixed_Name(datex, "poorEnvironmentConditionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:poorEnvironmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of environment condition which is affecting driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#poorEnvironmentType">http://vocab.datex.org/terms#poorEnvironmentType</seealso>
    let poorEnvironmentType =
        Prefixed_Name(datex, "poorEnvironmentType") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationDetail">http://vocab.datex.org/terms#precipitationDetail</seealso>
    let precipitationDetail =
        Prefixed_Name(datex, "precipitationDetail") |> PrefixedName

    /// <summary>
    ///   <para>datex:PrecipitationDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of precipitation (rain, snow etc.).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PrecipitationDetail">http://vocab.datex.org/terms#PrecipitationDetail</seealso>
    let PrecipitationDetail =
        Prefixed_Name(datex, "PrecipitationDetail") |> PrefixedName

    /// <summary>
    ///   <para>datex:visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#visibility">http://vocab.datex.org/terms#visibility</seealso>
    let visibility = Prefixed_Name(datex, "visibility") |> PrefixedName
    /// <summary>
    ///   <para>datex:Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of atmospheric visibility.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Visibility">http://vocab.datex.org/terms#Visibility</seealso>
    let Visibility = Prefixed_Name(datex, "Visibility") |> PrefixedName
    /// <summary>
    ///   <para>datex:wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#wind">http://vocab.datex.org/terms#wind</seealso>
    let wind = Prefixed_Name(datex, "wind") |> PrefixedName
    /// <summary>
    ///   <para>datex:Wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wind conditions on the road. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Wind">http://vocab.datex.org/terms#Wind</seealso>
    let Wind = Prefixed_Name(datex, "Wind") |> PrefixedName
    /// <summary>
    ///   <para>datex:depositionDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#depositionDepth">http://vocab.datex.org/terms#depositionDepth</seealso>
    let depositionDepth = Prefixed_Name(datex, "depositionDepth") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationDetailExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationDetailExtension">http://vocab.datex.org/terms#precipitationDetailExtension</seealso>
    let precipitationDetailExtension =
        Prefixed_Name(datex, "precipitationDetailExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationIntensity">http://vocab.datex.org/terms#precipitationIntensity</seealso>
    let precipitationIntensity =
        Prefixed_Name(datex, "precipitationIntensity") |> PrefixedName

    /// <summary>
    ///   <para>datex:PrecipitationIntensityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the accumulation rate of precipitation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PrecipitationIntensityValue">http://vocab.datex.org/terms#PrecipitationIntensityValue</seealso>
    let PrecipitationIntensityValue =
        Prefixed_Name(datex, "PrecipitationIntensityValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:overallSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overallSeverity">http://vocab.datex.org/terms#overallSeverity</seealso>
    let overallSeverity = Prefixed_Name(datex, "overallSeverity") |> PrefixedName
    /// <summary>
    ///   <para>datex:relatedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#relatedSituation">http://vocab.datex.org/terms#relatedSituation</seealso>
    let relatedSituation = Prefixed_Name(datex, "relatedSituation") |> PrefixedName

    /// <summary>
    ///   <para>datex:_SituationVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_SituationVersionedReference">http://vocab.datex.org/terms#_SituationVersionedReference</seealso>
    let _SituationVersionedReference =
        Prefixed_Name(datex, "_SituationVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Averaged measurements or calculations of traffic speed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficSpeed">http://vocab.datex.org/terms#TrafficSpeed</seealso>
    let TrafficSpeed = Prefixed_Name(datex, "TrafficSpeed") |> PrefixedName

    /// <summary>
    ///   <para>datex:averageVehicleSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of the speed of vehicles at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#averageVehicleSpeed">http://vocab.datex.org/terms#averageVehicleSpeed</seealso>
    let averageVehicleSpeed =
        Prefixed_Name(datex, "averageVehicleSpeed") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficSpeedExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficSpeedExtension">http://vocab.datex.org/terms#trafficSpeedExtension</seealso>
    let trafficSpeedExtension =
        Prefixed_Name(datex, "trafficSpeedExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:requestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#requestedBy">http://vocab.datex.org/terms#requestedBy</seealso>
    let requestedBy = Prefixed_Name(datex, "requestedBy") |> PrefixedName
    /// <summary>
    ///   <para>datex:setBySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#setBySystem">http://vocab.datex.org/terms#setBySystem</seealso>
    let setBySystem = Prefixed_Name(datex, "setBySystem") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordToWhichMessageIsRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordToWhichMessageIsRelated">http://vocab.datex.org/terms#situationRecordToWhichMessageIsRelated</seealso>
    let situationRecordToWhichMessageIsRelated =
        Prefixed_Name(datex, "situationRecordToWhichMessageIsRelated") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationToWhichMessageIsRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationToWhichMessageIsRelated">http://vocab.datex.org/terms#situationToWhichMessageIsRelated</seealso>
    let situationToWhichMessageIsRelated =
        Prefixed_Name(datex, "situationToWhichMessageIsRelated") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPage">http://vocab.datex.org/terms#textPage</seealso>
    let textPage = Prefixed_Name(datex, "textPage") |> PrefixedName
    /// <summary>
    ///   <para>datex:_TextPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_TextPage">http://vocab.datex.org/terms#_TextPage</seealso>
    let _TextPage = Prefixed_Name(datex, "_TextPage") |> PrefixedName
    /// <summary>
    ///   <para>datex:AbnormalTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A traffic condition which is not normal.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AbnormalTraffic">http://vocab.datex.org/terms#AbnormalTraffic</seealso>
    let AbnormalTraffic = Prefixed_Name(datex, "AbnormalTraffic") |> PrefixedName

    /// <summary>
    ///   <para>datex:AnimalPresenceObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road resulting from the presence of animals.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AnimalPresenceObstruction">http://vocab.datex.org/terms#AnimalPresenceObstruction</seealso>
    let AnimalPresenceObstruction =
        Prefixed_Name(datex, "AnimalPresenceObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:AnprCameraFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AnprCameraFailure">http://vocab.datex.org/terms#AnprCameraFailure</seealso>
    let AnprCameraFailure = Prefixed_Name(datex, "AnprCameraFailure") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadSurfaceMelting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadSurfaceMelting">http://vocab.datex.org/terms#RoadSurfaceMelting</seealso>
    let RoadSurfaceMelting = Prefixed_Name(datex, "RoadSurfaceMelting") |> PrefixedName

    /// <summary>
    ///   <para>datex:SaltingOrGrittingVehicleInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SaltingOrGrittingVehicleInUse">http://vocab.datex.org/terms#SaltingOrGrittingVehicleInUse</seealso>
    let SaltingOrGrittingVehicleInUse =
        Prefixed_Name(datex, "SaltingOrGrittingVehicleInUse") |> PrefixedName

    /// <summary>
    ///   <para>datex:ShowJumping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ShowJumping">http://vocab.datex.org/terms#ShowJumping</seealso>
    let ShowJumping = Prefixed_Name(datex, "ShowJumping") |> PrefixedName

    /// <summary>
    ///   <para>datex:SightseersObstructingAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SightseersObstructingAccess">http://vocab.datex.org/terms#SightseersObstructingAccess</seealso>
    let SightseersObstructingAccess =
        Prefixed_Name(datex, "SightseersObstructingAccess") |> PrefixedName

    /// <summary>
    ///   <para>datex:SlowTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlowTraffic">http://vocab.datex.org/terms#SlowTraffic</seealso>
    let SlowTraffic = Prefixed_Name(datex, "SlowTraffic") |> PrefixedName
    /// <summary>
    ///   <para>datex:SlushOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlushOnRoad">http://vocab.datex.org/terms#SlushOnRoad</seealso>
    let SlushOnRoad = Prefixed_Name(datex, "SlushOnRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:constructionWorksExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#constructionWorksExtension">http://vocab.datex.org/terms#constructionWorksExtension</seealso>
    let constructionWorksExtension =
        Prefixed_Name(datex, "constructionWorksExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Roadworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Highway maintenance, installation and construction activities that may potentially affect traffic operations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Roadworks">http://vocab.datex.org/terms#Roadworks</seealso>
    let Roadworks = Prefixed_Name(datex, "Roadworks") |> PrefixedName
    /// <summary>
    ///   <para>datex:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Address and contact information about some person, service or the parking site, provided in detail or via reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Contact">http://vocab.datex.org/terms#Contact</seealso>
    let Contact = Prefixed_Name(datex, "Contact") |> PrefixedName

    /// <summary>
    ///   <para>datex:ElaboratedDataFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of a fault which is being reported for the related elaborated data.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ElaboratedDataFault">http://vocab.datex.org/terms#ElaboratedDataFault</seealso>
    let ElaboratedDataFault =
        Prefixed_Name(datex, "ElaboratedDataFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:forecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#forecast">http://vocab.datex.org/terms#forecast</seealso>
    let forecast = Prefixed_Name(datex, "forecast") |> PrefixedName

    /// <summary>
    ///   <para>datex:policeForceControlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#policeForceControlArea">http://vocab.datex.org/terms#policeForceControlArea</seealso>
    let policeForceControlArea =
        Prefixed_Name(datex, "policeForceControlArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#location">http://vocab.datex.org/terms#location</seealso>
    let location = Prefixed_Name(datex, "location") |> PrefixedName

    /// <summary>
    ///   <para>datex:labelSecurityLevelSelfAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#labelSecurityLevelSelfAssessment">http://vocab.datex.org/terms#labelSecurityLevelSelfAssessment</seealso>
    let labelSecurityLevelSelfAssessment =
        Prefixed_Name(datex, "labelSecurityLevelSelfAssessment") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSupervision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSupervision">http://vocab.datex.org/terms#parkingSupervision</seealso>
    let parkingSupervision = Prefixed_Name(datex, "parkingSupervision") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusColourMappingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusColourMappingExtension">http://vocab.datex.org/terms#parkingStatusColourMappingExtension</seealso>
    let parkingStatusColourMappingExtension =
        Prefixed_Name(datex, "parkingStatusColourMappingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:rgbColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#rgbColour">http://vocab.datex.org/terms#rgbColour</seealso>
    let rgbColour = Prefixed_Name(datex, "rgbColour") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationInformationExtension">http://vocab.datex.org/terms#precipitationInformationExtension</seealso>
    let precipitationInformationExtension =
        Prefixed_Name(datex, "precipitationInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of flow rate defined in terms of the number of vehicle axles passing the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleFlow">http://vocab.datex.org/terms#axleFlow</seealso>
    let axleFlow = Prefixed_Name(datex, "axleFlow") |> PrefixedName
    /// <summary>
    ///   <para>datex:pcuFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of flow rate defined in terms of the number of passenger car units passing the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pcuFlow">http://vocab.datex.org/terms#pcuFlow</seealso>
    let pcuFlow = Prefixed_Name(datex, "pcuFlow") |> PrefixedName

    /// <summary>
    ///   <para>datex:percentageLongVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of the percentage of long vehicles contained in the traffic flow at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#percentageLongVehicles">http://vocab.datex.org/terms#percentageLongVehicles</seealso>
    let percentageLongVehicles =
        Prefixed_Name(datex, "percentageLongVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:managedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managedLocation">http://vocab.datex.org/terms#managedLocation</seealso>
    let managedLocation = Prefixed_Name(datex, "managedLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:managedLogicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managedLogicalLocation">http://vocab.datex.org/terms#managedLogicalLocation</seealso>
    let managedLogicalLocation =
        Prefixed_Name(datex, "managedLogicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsManagedLogicalLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsManagedLogicalLocationExtension">http://vocab.datex.org/terms#vmsManagedLogicalLocationExtension</seealso>
    let vmsManagedLogicalLocationExtension =
        Prefixed_Name(datex, "vmsManagedLogicalLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentOrServiceFacilityIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIndex">http://vocab.datex.org/terms#equipmentOrServiceFacilityIndex</seealso>
    let equipmentOrServiceFacilityIndex =
        Prefixed_Name(datex, "equipmentOrServiceFacilityIndex") |> PrefixedName

    /// <summary>
    ///   <para>datex:GasLeak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GasLeak">http://vocab.datex.org/terms#GasLeak</seealso>
    let GasLeak = Prefixed_Name(datex, "GasLeak") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCDirectionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCDirectionExtension">http://vocab.datex.org/terms#alertCDirectionExtension</seealso>
    let alertCDirectionExtension =
        Prefixed_Name(datex, "alertCDirectionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCDirectionSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCDirectionSense">http://vocab.datex.org/terms#alertCDirectionSense</seealso>
    let alertCDirectionSense =
        Prefixed_Name(datex, "alertCDirectionSense") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfVacantParkingSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the number of vacant parking spaces available in a specified parking area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfVacantParkingSpaces">http://vocab.datex.org/terms#numberOfVacantParkingSpaces</seealso>
    let numberOfVacantParkingSpaces =
        Prefixed_Name(datex, "numberOfVacantParkingSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:occupiedSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Number of currently occupied spaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#occupiedSpaces">http://vocab.datex.org/terms#occupiedSpaces</seealso>
    let occupiedSpaces = Prefixed_Name(datex, "occupiedSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionCompassValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionCompassValueExtension">http://vocab.datex.org/terms#directionCompassValueExtension</seealso>
    let directionCompassValueExtension =
        Prefixed_Name(datex, "directionCompassValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:MicrogramsConcentrationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of concentration of a substance in micrograms per unit volume.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MicrogramsConcentrationValue">http://vocab.datex.org/terms#MicrogramsConcentrationValue</seealso>
    let MicrogramsConcentrationValue =
        Prefixed_Name(datex, "MicrogramsConcentrationValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:mobilityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mobilityExtension">http://vocab.datex.org/terms#mobilityExtension</seealso>
    let mobilityExtension = Prefixed_Name(datex, "mobilityExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:mobilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mobilityType">http://vocab.datex.org/terms#mobilityType</seealso>
    let mobilityType = Prefixed_Name(datex, "mobilityType") |> PrefixedName

    /// <summary>
    ///   <para>datex:pollutantConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pollutantConcentration">http://vocab.datex.org/terms#pollutantConcentration</seealso>
    let pollutantConcentration =
        Prefixed_Name(datex, "pollutantConcentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:pollutantType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pollutantType">http://vocab.datex.org/terms#pollutantType</seealso>
    let pollutantType = Prefixed_Name(datex, "pollutantType") |> PrefixedName

    /// <summary>
    ///   <para>datex:maintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maintenanceVehicles">http://vocab.datex.org/terms#maintenanceVehicles</seealso>
    let maintenanceVehicles =
        Prefixed_Name(datex, "maintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegIlcPointDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegIlcPointDescriptorExtension">http://vocab.datex.org/terms#tpegIlcPointDescriptorExtension</seealso>
    let tpegIlcPointDescriptorExtension =
        Prefixed_Name(datex, "tpegIlcPointDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegIlcPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegIlcPointDescriptorType">http://vocab.datex.org/terms#tpegIlcPointDescriptorType</seealso>
    let tpegIlcPointDescriptorType =
        Prefixed_Name(datex, "tpegIlcPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountWithinIntervalExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountWithinIntervalExtension">http://vocab.datex.org/terms#vehicleCountWithinIntervalExtension</seealso>
    let vehicleCountWithinIntervalExtension =
        Prefixed_Name(datex, "vehicleCountWithinIntervalExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vms">http://vocab.datex.org/terms#vms</seealso>
    let vms = Prefixed_Name(datex, "vms") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsUnitVmsIndexVms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsUnitVmsIndexVms">http://vocab.datex.org/terms#_VmsUnitVmsIndexVms</seealso>
    let _VmsUnitVmsIndexVms =
        Prefixed_Name(datex, "_VmsUnitVmsIndexVms") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitExtension">http://vocab.datex.org/terms#vmsUnitExtension</seealso>
    let vmsUnitExtension = Prefixed_Name(datex, "vmsUnitExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingMassTransitVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingMassTransitVehicle">http://vocab.datex.org/terms#AccidentInvolvingMassTransitVehicle</seealso>
    let AccidentInvolvingMassTransitVehicle =
        Prefixed_Name(datex, "AccidentInvolvingMassTransitVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:AgriculturalShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AgriculturalShow">http://vocab.datex.org/terms#AgriculturalShow</seealso>
    let AgriculturalShow = Prefixed_Name(datex, "AgriculturalShow") |> PrefixedName

    /// <summary>
    ///   <para>datex:MudOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MudOnInfrastructure">http://vocab.datex.org/terms#MudOnInfrastructure</seealso>
    let MudOnInfrastructure =
        Prefixed_Name(datex, "MudOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordVersionedReference">http://vocab.datex.org/terms#_ParkingRecordVersionedReference</seealso>
    let _ParkingRecordVersionedReference =
        Prefixed_Name(datex, "_ParkingRecordVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:values</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#values">http://vocab.datex.org/terms#values</seealso>
    let values = Prefixed_Name(datex, "values") |> PrefixedName
    /// <summary>
    ///   <para>datex:valuesType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#valuesType">http://vocab.datex.org/terms#valuesType</seealso>
    let valuesType = Prefixed_Name(datex, "valuesType") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingSpaceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Status (occupied or closed) for a single parking space which was defined in the static part of the model.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingSpaceStatus">http://vocab.datex.org/terms#ParkingSpaceStatus</seealso>
    let ParkingSpaceStatus = Prefixed_Name(datex, "ParkingSpaceStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingSpaceClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceClosed">http://vocab.datex.org/terms#parkingSpaceClosed</seealso>
    let parkingSpaceClosed = Prefixed_Name(datex, "parkingSpaceClosed") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceOccupied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceOccupied">http://vocab.datex.org/terms#parkingSpaceOccupied</seealso>
    let parkingSpaceOccupied =
        Prefixed_Name(datex, "parkingSpaceOccupied") |> PrefixedName

    /// <summary>
    ///   <para>datex:sectionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sectionName">http://vocab.datex.org/terms#sectionName</seealso>
    let sectionName = Prefixed_Name(datex, "sectionName") |> PrefixedName
    /// <summary>
    ///   <para>datex:temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value of temperature expressed in degrees Celsius.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temperature">http://vocab.datex.org/terms#temperature</seealso>
    let temperature = Prefixed_Name(datex, "temperature") |> PrefixedName
    /// <summary>
    ///   <para>datex:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of atmospheric temperature.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Temperature">http://vocab.datex.org/terms#Temperature</seealso>
    let Temperature = Prefixed_Name(datex, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>datex:concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of the concentration of vehicles at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#concentration">http://vocab.datex.org/terms#concentration</seealso>
    let concentration = Prefixed_Name(datex, "concentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfPictogramDisplayAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfPictogramDisplayAreas">http://vocab.datex.org/terms#numberOfPictogramDisplayAreas</seealso>
    let numberOfPictogramDisplayAreas =
        Prefixed_Name(datex, "numberOfPictogramDisplayAreas") |> PrefixedName

    /// <summary>
    ///   <para>datex:AltercationOfVehicleOccupants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AltercationOfVehicleOccupants">http://vocab.datex.org/terms#AltercationOfVehicleOccupants</seealso>
    let AltercationOfVehicleOccupants =
        Prefixed_Name(datex, "AltercationOfVehicleOccupants") |> PrefixedName

    /// <summary>
    ///   <para>datex:AssetDestruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AssetDestruction">http://vocab.datex.org/terms#AssetDestruction</seealso>
    let AssetDestruction = Prefixed_Name(datex, "AssetDestruction") |> PrefixedName
    /// <summary>
    ///   <para>datex:StateOccasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StateOccasion">http://vocab.datex.org/terms#StateOccasion</seealso>
    let StateOccasion = Prefixed_Name(datex, "StateOccasion") |> PrefixedName
    /// <summary>
    ///   <para>datex:Subsidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Subsidence">http://vocab.datex.org/terms#Subsidence</seealso>
    let Subsidence = Prefixed_Name(datex, "Subsidence") |> PrefixedName
    /// <summary>
    ///   <para>datex:SurfaceWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SurfaceWater">http://vocab.datex.org/terms#SurfaceWater</seealso>
    let SurfaceWater = Prefixed_Name(datex, "SurfaceWater") |> PrefixedName
    /// <summary>
    ///   <para>datex:Survey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Survey">http://vocab.datex.org/terms#Survey</seealso>
    let Survey = Prefixed_Name(datex, "Survey") |> PrefixedName
    /// <summary>
    ///   <para>datex:SweepingOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SweepingOfRoad">http://vocab.datex.org/terms#SweepingOfRoad</seealso>
    let SweepingOfRoad = Prefixed_Name(datex, "SweepingOfRoad") |> PrefixedName
    /// <summary>
    ///   <para>datex:TollGatesFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TollGatesFailure">http://vocab.datex.org/terms#TollGatesFailure</seealso>
    let TollGatesFailure = Prefixed_Name(datex, "TollGatesFailure") |> PrefixedName
    /// <summary>
    ///   <para>datex:TollGatesOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TollGatesOpen">http://vocab.datex.org/terms#TollGatesOpen</seealso>
    let TollGatesOpen = Prefixed_Name(datex, "TollGatesOpen") |> PrefixedName
    /// <summary>
    ///   <para>datex:Tournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Tournament">http://vocab.datex.org/terms#Tournament</seealso>
    let Tournament = Prefixed_Name(datex, "Tournament") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrackLayingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrackLayingVehicle">http://vocab.datex.org/terms#TrackLayingVehicle</seealso>
    let TrackLayingVehicle = Prefixed_Name(datex, "TrackLayingVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:electricCharging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#electricCharging">http://vocab.datex.org/terms#electricCharging</seealso>
    let electricCharging = Prefixed_Name(datex, "electricCharging") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusTimeOffsetToOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusTimeOffsetToOrigin">http://vocab.datex.org/terms#parkingStatusTimeOffsetToOrigin</seealso>
    let parkingStatusTimeOffsetToOrigin =
        Prefixed_Name(datex, "parkingStatusTimeOffsetToOrigin") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedItineraryExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedItineraryExtension">http://vocab.datex.org/terms#predefinedItineraryExtension</seealso>
    let predefinedItineraryExtension =
        Prefixed_Name(datex, "predefinedItineraryExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedItineraryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A name assigned to the predefined itinerary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedItineraryName">http://vocab.datex.org/terms#predefinedItineraryName</seealso>
    let predefinedItineraryName =
        Prefixed_Name(datex, "predefinedItineraryName") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocation">http://vocab.datex.org/terms#predefinedLocation</seealso>
    let predefinedLocation = Prefixed_Name(datex, "predefinedLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PredefinedItineraryIndexPredefinedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PredefinedItineraryIndexPredefinedLocation">http://vocab.datex.org/terms#_PredefinedItineraryIndexPredefinedLocation</seealso>
    let _PredefinedItineraryIndexPredefinedLocation =
        Prefixed_Name(datex, "_PredefinedItineraryIndexPredefinedLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationExtension">http://vocab.datex.org/terms#predefinedLocationExtension</seealso>
    let predefinedLocationExtension =
        Prefixed_Name(datex, "predefinedLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficView">http://vocab.datex.org/terms#trafficView</seealso>
    let trafficView = Prefixed_Name(datex, "trafficView") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficViewPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficViewPublicationExtension">http://vocab.datex.org/terms#trafficViewPublicationExtension</seealso>
    let trafficViewPublicationExtension =
        Prefixed_Name(datex, "trafficViewPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSideWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSideWork">http://vocab.datex.org/terms#InfrastructureSideWork</seealso>
    let InfrastructureSideWork =
        Prefixed_Name(datex, "InfrastructureSideWork") |> PrefixedName

    /// <summary>
    ///   <para>datex:InstallationWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InstallationWork">http://vocab.datex.org/terms#InstallationWork</seealso>
    let InstallationWork = Prefixed_Name(datex, "InstallationWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:Landslips</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Landslips">http://vocab.datex.org/terms#Landslips</seealso>
    let Landslips = Prefixed_Name(datex, "Landslips") |> PrefixedName

    /// <summary>
    ///   <para>datex:LeavesOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LeavesOnInfrastructure">http://vocab.datex.org/terms#LeavesOnInfrastructure</seealso>
    let LeavesOnInfrastructure =
        Prefixed_Name(datex, "LeavesOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LongLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LongLoad">http://vocab.datex.org/terms#LongLoad</seealso>
    let LongLoad = Prefixed_Name(datex, "LongLoad") |> PrefixedName
    /// <summary>
    ///   <para>datex:MajorEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MajorEvent">http://vocab.datex.org/terms#MajorEvent</seealso>
    let MajorEvent = Prefixed_Name(datex, "MajorEvent") |> PrefixedName
    /// <summary>
    ///   <para>datex:Match</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Match">http://vocab.datex.org/terms#Match</seealso>
    let Match = Prefixed_Name(datex, "Match") |> PrefixedName

    /// <summary>
    ///   <para>datex:MotorSportRaceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MotorSportRaceMeeting">http://vocab.datex.org/terms#MotorSportRaceMeeting</seealso>
    let MotorSportRaceMeeting =
        Prefixed_Name(datex, "MotorSportRaceMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:MultipleVehicleCollision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MultipleVehicleCollision">http://vocab.datex.org/terms#MultipleVehicleCollision</seealso>
    let MultipleVehicleCollision =
        Prefixed_Name(datex, "MultipleVehicleCollision") |> PrefixedName

    /// <summary>
    ///   <para>datex:Obstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Obstruction">http://vocab.datex.org/terms#Obstruction</seealso>
    let Obstruction = Prefixed_Name(datex, "Obstruction") |> PrefixedName
    /// <summary>
    ///   <para>datex:OperatorAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OperatorAction">http://vocab.datex.org/terms#OperatorAction</seealso>
    let OperatorAction = Prefixed_Name(datex, "OperatorAction") |> PrefixedName
    /// <summary>
    ///   <para>datex:OvernightClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OvernightClosures">http://vocab.datex.org/terms#OvernightClosures</seealso>
    let OvernightClosures = Prefixed_Name(datex, "OvernightClosures") |> PrefixedName
    /// <summary>
    ///   <para>datex:PassableWithCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PassableWithCare">http://vocab.datex.org/terms#PassableWithCare</seealso>
    let PassableWithCare = Prefixed_Name(datex, "PassableWithCare") |> PrefixedName

    /// <summary>
    ///   <para>datex:PassengerAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PassengerAssistance">http://vocab.datex.org/terms#PassengerAssistance</seealso>
    let PassengerAssistance =
        Prefixed_Name(datex, "PassengerAssistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:PoliceSpeedChecksInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PoliceSpeedChecksInOperation">http://vocab.datex.org/terms#PoliceSpeedChecksInOperation</seealso>
    let PoliceSpeedChecksInOperation =
        Prefixed_Name(datex, "PoliceSpeedChecksInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:Pollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Details of atmospheric pollution.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Pollution">http://vocab.datex.org/terms#Pollution</seealso>
    let Pollution = Prefixed_Name(datex, "Pollution") |> PrefixedName
    /// <summary>
    ///   <para>datex:RaceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RaceMeeting">http://vocab.datex.org/terms#RaceMeeting</seealso>
    let RaceMeeting = Prefixed_Name(datex, "RaceMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:RadioactiveLeakAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RadioactiveLeakAlert">http://vocab.datex.org/terms#RadioactiveLeakAlert</seealso>
    let RadioactiveLeakAlert =
        Prefixed_Name(datex, "RadioactiveLeakAlert") |> PrefixedName

    /// <summary>
    ///   <para>datex:RampMeteringInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RampMeteringInOperation">http://vocab.datex.org/terms#RampMeteringInOperation</seealso>
    let RampMeteringInOperation =
        Prefixed_Name(datex, "RampMeteringInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:RearCollision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RearCollision">http://vocab.datex.org/terms#RearCollision</seealso>
    let RearCollision = Prefixed_Name(datex, "RearCollision") |> PrefixedName
    /// <summary>
    ///   <para>datex:specificLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specificLocation">http://vocab.datex.org/terms#specificLocation</seealso>
    let specificLocation = Prefixed_Name(datex, "specificLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod2SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod2SecondaryPointLocation">http://vocab.datex.org/terms#AlertCMethod2SecondaryPointLocation</seealso>
    let AlertCMethod2SecondaryPointLocation =
        Prefixed_Name(datex, "AlertCMethod2SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:disturbanceActivityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#disturbanceActivityExtension">http://vocab.datex.org/terms#disturbanceActivityExtension</seealso>
    let disturbanceActivityExtension =
        Prefixed_Name(datex, "disturbanceActivityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:DurationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of a period of time.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DurationValue">http://vocab.datex.org/terms#DurationValue</seealso>
    let DurationValue = Prefixed_Name(datex, "DurationValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A period of time expressed in seconds.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#duration">http://vocab.datex.org/terms#duration</seealso>
    let duration = Prefixed_Name(datex, "duration") |> PrefixedName

    /// <summary>
    ///   <para>datex:durationValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#durationValueExtension">http://vocab.datex.org/terms#durationValueExtension</seealso>
    let durationValueExtension =
        Prefixed_Name(datex, "durationValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpacesStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpacesStatusExtension">http://vocab.datex.org/terms#groupOfParkingSpacesStatusExtension</seealso>
    let groupOfParkingSpacesStatusExtension =
        Prefixed_Name(datex, "groupOfParkingSpacesStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:categoryOfPeopleInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#categoryOfPeopleInvolved">http://vocab.datex.org/terms#categoryOfPeopleInvolved</seealso>
    let categoryOfPeopleInvolved =
        Prefixed_Name(datex, "categoryOfPeopleInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfPeopleInvolvedExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfPeopleInvolvedExtension">http://vocab.datex.org/terms#groupOfPeopleInvolvedExtension</seealso>
    let groupOfPeopleInvolvedExtension =
        Prefixed_Name(datex, "groupOfPeopleInvolvedExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:involvementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#involvementRole">http://vocab.datex.org/terms#involvementRole</seealso>
    let involvementRole = Prefixed_Name(datex, "involvementRole") |> PrefixedName
    /// <summary>
    ///   <para>datex:numberOfPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfPeople">http://vocab.datex.org/terms#numberOfPeople</seealso>
    let numberOfPeople = Prefixed_Name(datex, "numberOfPeople") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfVehiclesInvolvedExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfVehiclesInvolvedExtension">http://vocab.datex.org/terms#groupOfVehiclesInvolvedExtension</seealso>
    let groupOfVehiclesInvolvedExtension =
        Prefixed_Name(datex, "groupOfVehiclesInvolvedExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfVehicles">http://vocab.datex.org/terms#numberOfVehicles</seealso>
    let numberOfVehicles = Prefixed_Name(datex, "numberOfVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCharacteristics">http://vocab.datex.org/terms#vehicleCharacteristics</seealso>
    let vehicleCharacteristics =
        Prefixed_Name(datex, "vehicleCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:LinearElementByCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LinearElementByCode">http://vocab.datex.org/terms#LinearElementByCode</seealso>
    let LinearElementByCode =
        Prefixed_Name(datex, "LinearElementByCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementByCodeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementByCodeExtension">http://vocab.datex.org/terms#linearElementByCodeExtension</seealso>
    let linearElementByCodeExtension =
        Prefixed_Name(datex, "linearElementByCodeExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementIdentifier">http://vocab.datex.org/terms#linearElementIdentifier</seealso>
    let linearElementIdentifier =
        Prefixed_Name(datex, "linearElementIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:LinearElementByPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object defined by its start and end points.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LinearElementByPoints">http://vocab.datex.org/terms#LinearElementByPoints</seealso>
    let LinearElementByPoints =
        Prefixed_Name(datex, "LinearElementByPoints") |> PrefixedName

    /// <summary>
    ///   <para>datex:endPointOfLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The referent at a known location on the linear object which defines the end of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#endPointOfLinearElement">http://vocab.datex.org/terms#endPointOfLinearElement</seealso>
    let endPointOfLinearElement =
        Prefixed_Name(datex, "endPointOfLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:intermediatePointOnLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A referent at a known location on the linear object which is neither the start or end of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#intermediatePointOnLinearElement">http://vocab.datex.org/terms#intermediatePointOnLinearElement</seealso>
    let intermediatePointOnLinearElement =
        Prefixed_Name(datex, "intermediatePointOnLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:_IntermediatePointOnLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_IntermediatePointOnLinearElement">http://vocab.datex.org/terms#_IntermediatePointOnLinearElement</seealso>
    let _IntermediatePointOnLinearElement =
        Prefixed_Name(datex, "_IntermediatePointOnLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementByPointsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementByPointsExtension">http://vocab.datex.org/terms#linearElementByPointsExtension</seealso>
    let linearElementByPointsExtension =
        Prefixed_Name(datex, "linearElementByPointsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:startPointOfLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The referent at a known location on the linear object which defines the start of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#startPointOfLinearElement">http://vocab.datex.org/terms#startPointOfLinearElement</seealso>
    let startPointOfLinearElement =
        Prefixed_Name(datex, "startPointOfLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:LinearTrafficView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable instance of a linear traffic view at a single point in time relating to a linear section of road, comprising one or more traffic view records.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LinearTrafficView">http://vocab.datex.org/terms#LinearTrafficView</seealso>
    let LinearTrafficView = Prefixed_Name(datex, "LinearTrafficView") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearPredefinedLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearPredefinedLocationReference">http://vocab.datex.org/terms#linearPredefinedLocationReference</seealso>
    let linearPredefinedLocationReference =
        Prefixed_Name(datex, "linearPredefinedLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PredefinedLocationVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PredefinedLocationVersionedReference">http://vocab.datex.org/terms#_PredefinedLocationVersionedReference</seealso>
    let _PredefinedLocationVersionedReference =
        Prefixed_Name(datex, "_PredefinedLocationVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearTrafficViewExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearTrafficViewExtension">http://vocab.datex.org/terms#linearTrafficViewExtension</seealso>
    let linearTrafficViewExtension =
        Prefixed_Name(datex, "linearTrafficViewExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:administrativeAreaOfLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#administrativeAreaOfLinearSection">http://vocab.datex.org/terms#administrativeAreaOfLinearSection</seealso>
    let administrativeAreaOfLinearSection =
        Prefixed_Name(datex, "administrativeAreaOfLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionBoundOnLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionBoundOnLinearSection">http://vocab.datex.org/terms#directionBoundOnLinearSection</seealso>
    let directionBoundOnLinearSection =
        Prefixed_Name(datex, "directionBoundOnLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionRelativeOnLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionRelativeOnLinearSection">http://vocab.datex.org/terms#directionRelativeOnLinearSection</seealso>
    let directionRelativeOnLinearSection =
        Prefixed_Name(datex, "directionRelativeOnLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>datex:fromPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fromPoint">http://vocab.datex.org/terms#fromPoint</seealso>
    let fromPoint = Prefixed_Name(datex, "fromPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:heightGradeOfLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightGradeOfLinearSection">http://vocab.datex.org/terms#heightGradeOfLinearSection</seealso>
    let heightGradeOfLinearSection =
        Prefixed_Name(datex, "heightGradeOfLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElement">http://vocab.datex.org/terms#linearElement</seealso>
    let linearElement = Prefixed_Name(datex, "linearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearWithinLinearElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearWithinLinearElementExtension">http://vocab.datex.org/terms#linearWithinLinearElementExtension</seealso>
    let linearWithinLinearElementExtension =
        Prefixed_Name(datex, "linearWithinLinearElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:toPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#toPoint">http://vocab.datex.org/terms#toPoint</seealso>
    let toPoint = Prefixed_Name(datex, "toPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:externalReferencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#externalReferencing">http://vocab.datex.org/terms#externalReferencing</seealso>
    let externalReferencing =
        Prefixed_Name(datex, "externalReferencing") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationExtension">http://vocab.datex.org/terms#locationExtension</seealso>
    let locationExtension = Prefixed_Name(datex, "locationExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:locationForDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A location which may be used by clients for visual display on user interfaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationForDisplay">http://vocab.datex.org/terms#locationForDisplay</seealso>
    let locationForDisplay = Prefixed_Name(datex, "locationForDisplay") |> PrefixedName
    /// <summary>
    ///   <para>datex:PointCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pair of coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PointCoordinates">http://vocab.datex.org/terms#PointCoordinates</seealso>
    let PointCoordinates = Prefixed_Name(datex, "PointCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationByReferenceExtension">http://vocab.datex.org/terms#locationByReferenceExtension</seealso>
    let locationByReferenceExtension =
        Prefixed_Name(datex, "locationByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned predefined location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationReference">http://vocab.datex.org/terms#predefinedLocationReference</seealso>
    let predefinedLocationReference =
        Prefixed_Name(datex, "predefinedLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:LocationCharacteristicsOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location characteristics which override values set in the referenced measurement point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LocationCharacteristicsOverride">http://vocab.datex.org/terms#LocationCharacteristicsOverride</seealso>
    let LocationCharacteristicsOverride =
        Prefixed_Name(datex, "LocationCharacteristicsOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrBaseLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class used to hold data about a reference point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrBaseLocationReferencePoint">http://vocab.datex.org/terms#OpenlrBaseLocationReferencePoint</seealso>
    let OpenlrBaseLocationReferencePoint =
        Prefixed_Name(datex, "OpenlrBaseLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrBaseLocationReferencePointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrBaseLocationReferencePointExtension">http://vocab.datex.org/terms#openlrBaseLocationReferencePointExtension</seealso>
    let openlrBaseLocationReferencePointExtension =
        Prefixed_Name(datex, "openlrBaseLocationReferencePointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The coordinate of the actual point of interest</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrCoordinate">http://vocab.datex.org/terms#openlrCoordinate</seealso>
    let openlrCoordinate = Prefixed_Name(datex, "openlrCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLineAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLineAttributes">http://vocab.datex.org/terms#openlrLineAttributes</seealso>
    let openlrLineAttributes =
        Prefixed_Name(datex, "openlrLineAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrLineAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrLineAttributes">http://vocab.datex.org/terms#OpenlrLineAttributes</seealso>
    let OpenlrLineAttributes =
        Prefixed_Name(datex, "OpenlrLineAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrBasePointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrBasePointLocation">http://vocab.datex.org/terms#OpenlrBasePointLocation</seealso>
    let OpenlrBasePointLocation =
        Prefixed_Name(datex, "OpenlrBasePointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrBasePointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrBasePointLocationExtension">http://vocab.datex.org/terms#openlrBasePointLocationExtension</seealso>
    let openlrBasePointLocationExtension =
        Prefixed_Name(datex, "openlrBasePointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLastLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLastLocationReferencePoint">http://vocab.datex.org/terms#openlrLastLocationReferencePoint</seealso>
    let openlrLastLocationReferencePoint =
        Prefixed_Name(datex, "openlrLastLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrLastLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The sequence of location reference points is terminated by a last location reference point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrLastLocationReferencePoint">http://vocab.datex.org/terms#OpenlrLastLocationReferencePoint</seealso>
    let OpenlrLastLocationReferencePoint =
        Prefixed_Name(datex, "OpenlrLastLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrSideOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrSideOfRoad">http://vocab.datex.org/terms#openlrSideOfRoad</seealso>
    let openlrSideOfRoad = Prefixed_Name(datex, "openlrSideOfRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrCircleLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the openLR method of areadefinition by providing a center position and a radius</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrCircleLocationReference">http://vocab.datex.org/terms#OpenlrCircleLocationReference</seealso>
    let OpenlrCircleLocationReference =
        Prefixed_Name(datex, "OpenlrCircleLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrCircleLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrCircleLocationReferenceExtension">http://vocab.datex.org/terms#openlrCircleLocationReferenceExtension</seealso>
    let openlrCircleLocationReferenceExtension =
        Prefixed_Name(datex, "openlrCircleLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrGeoCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrGeoCoordinate">http://vocab.datex.org/terms#openlrGeoCoordinate</seealso>
    let openlrGeoCoordinate =
        Prefixed_Name(datex, "openlrGeoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrGeoCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrGeoCoordinate">http://vocab.datex.org/terms#OpenlrGeoCoordinate</seealso>
    let OpenlrGeoCoordinate =
        Prefixed_Name(datex, "OpenlrGeoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusOriginTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusOriginTime">http://vocab.datex.org/terms#parkingStatusOriginTime</seealso>
    let parkingStatusOriginTime =
        Prefixed_Name(datex, "parkingStatusOriginTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusValidity">http://vocab.datex.org/terms#parkingStatusValidity</seealso>
    let parkingStatusValidity =
        Prefixed_Name(datex, "parkingStatusValidity") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingStatusValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>To be used only for historical or forecasted data. Choose between an explicit point of time, an offset or all points of time within a specified period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingStatusValidity">http://vocab.datex.org/terms#ParkingStatusValidity</seealso>
    let ParkingStatusValidity =
        Prefixed_Name(datex, "ParkingStatusValidity") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingUsageScenarioStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingUsageScenarioStatus">http://vocab.datex.org/terms#parkingUsageScenarioStatus</seealso>
    let parkingUsageScenarioStatus =
        Prefixed_Name(datex, "parkingUsageScenarioStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus">http://vocab.datex.org/terms#_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus</seealso>
    let _ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus =
        Prefixed_Name(datex, "_ParkingRecordStatusScenarioIndexParkingUsageScenarioStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:winterEquipmentManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of winter equipment management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#winterEquipmentManagementType">http://vocab.datex.org/terms#winterEquipmentManagementType</seealso>
    let winterEquipmentManagementType =
        Prefixed_Name(datex, "winterEquipmentManagementType") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteExtension">http://vocab.datex.org/terms#parkingRouteExtension</seealso>
    let parkingRouteExtension =
        Prefixed_Name(datex, "parkingRouteExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingRouteByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A route defined by a reference to an earlier specified route.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRouteByReference">http://vocab.datex.org/terms#ParkingRouteByReference</seealso>
    let ParkingRouteByReference =
        Prefixed_Name(datex, "ParkingRouteByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteByReferenceExtension">http://vocab.datex.org/terms#parkingRouteByReferenceExtension</seealso>
    let parkingRouteByReferenceExtension =
        Prefixed_Name(datex, "parkingRouteByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a parking route.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteReference">http://vocab.datex.org/terms#parkingRouteReference</seealso>
    let parkingRouteReference =
        Prefixed_Name(datex, "parkingRouteReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRouteDetailsVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRouteDetailsVersionedReference">http://vocab.datex.org/terms#_ParkingRouteDetailsVersionedReference</seealso>
    let _ParkingRouteDetailsVersionedReference =
        Prefixed_Name(datex, "_ParkingRouteDetailsVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingRouteDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Urban context: Defining parking routes leading to the parking site. Truck parking context: Can be used to define a dynamic route management.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRouteDetails">http://vocab.datex.org/terms#ParkingRouteDetails</seealso>
    let ParkingRouteDetails =
        Prefixed_Name(datex, "ParkingRouteDetails") |> PrefixedName

    /// <summary>
    ///   <para>datex:dynamicRouteManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that there is dynamic route management for truck parking, i.e. a management system concerning several truck parkings (including this one) along a route.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dynamicRouteManagement">http://vocab.datex.org/terms#dynamicRouteManagement</seealso>
    let dynamicRouteManagement =
        Prefixed_Name(datex, "dynamicRouteManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of parking route. If not specified, the route is designed for any type of vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteType">http://vocab.datex.org/terms#parkingRouteType</seealso>
    let parkingRouteType = Prefixed_Name(datex, "parkingRouteType") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingRouteActive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteActive">http://vocab.datex.org/terms#parkingRouteActive</seealso>
    let parkingRouteActive = Prefixed_Name(datex, "parkingRouteActive") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteStatusExtension">http://vocab.datex.org/terms#parkingRouteStatusExtension</seealso>
    let parkingRouteStatusExtension =
        Prefixed_Name(datex, "parkingRouteStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:highestFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Highest floor of the parking site. It is possible to have negative values here in case it is underground only. Must be higher or equal than 'lowestFloor'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#highestFloor">http://vocab.datex.org/terms#highestFloor</seealso>
    let highestFloor = Prefixed_Name(datex, "highestFloor") |> PrefixedName
    /// <summary>
    ///   <para>datex:lowestFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Lowest floor of the parking site. Positive values may apply in case it is over ground only. Must be lower or equal than 'highestFloor'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lowestFloor">http://vocab.datex.org/terms#lowestFloor</seealso>
    let lowestFloor = Prefixed_Name(datex, "lowestFloor") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An exit from the parking facility onto the road network from any parking space unless separate exits are specified for assigned parking spaces, in which case this is an exit from only the principal parking spaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAccess">http://vocab.datex.org/terms#parkingAccess</seealso>
    let parkingAccess = Prefixed_Name(datex, "parkingAccess") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingLayout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Layout of the parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingLayout">http://vocab.datex.org/terms#parkingLayout</seealso>
    let parkingLayout = Prefixed_Name(datex, "parkingLayout") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether a parking reservation service is available and/or mandatory.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingReservation">http://vocab.datex.org/terms#parkingReservation</seealso>
    let parkingReservation = Prefixed_Name(datex, "parkingReservation") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingSiteAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information about the parking site itself (address etc.). The 'GroupOfLocations' association must not be used for this role.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteAddress">http://vocab.datex.org/terms#parkingSiteAddress</seealso>
    let parkingSiteAddress = Prefixed_Name(datex, "parkingSiteAddress") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingStandardsAndSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Security measures and standards or standard-like categorization for a parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingStandardsAndSecurity">http://vocab.datex.org/terms#ParkingStandardsAndSecurity</seealso>
    let ParkingStandardsAndSecurity =
        Prefixed_Name(datex, "ParkingStandardsAndSecurity") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingUsageScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingUsageScenario">http://vocab.datex.org/terms#parkingUsageScenario</seealso>
    let parkingUsageScenario =
        Prefixed_Name(datex, "parkingUsageScenario") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingSiteScenarioIndexParkingUsageScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingSiteScenarioIndexParkingUsageScenario">http://vocab.datex.org/terms#_ParkingSiteScenarioIndexParkingUsageScenario</seealso>
    let _ParkingSiteScenarioIndexParkingUsageScenario =
        Prefixed_Name(datex, "_ParkingSiteScenarioIndexParkingUsageScenario") |> PrefixedName

    /// <summary>
    ///   <para>datex:reservationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reservation service (for end users). It is recommended to give URL and telephone.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reservationService">http://vocab.datex.org/terms#reservationService</seealso>
    let reservationService = Prefixed_Name(datex, "reservationService") |> PrefixedName
    /// <summary>
    ///   <para>datex:temporaryParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that the parking site is on a temporary basis. It might close permanently within short notice or might only be partial equipped. The physical parking possibilities might be provisional, too.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temporaryParking">http://vocab.datex.org/terms#temporaryParking</seealso>
    let temporaryParking = Prefixed_Name(datex, "temporaryParking") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingSiteStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dynamic status information for the static object 'ParkingSite'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingSiteStatus">http://vocab.datex.org/terms#ParkingSiteStatus</seealso>
    let ParkingSiteStatus = Prefixed_Name(datex, "ParkingSiteStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteFullAtFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The parking site is full at the specified floor(s).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteFullAtFloor">http://vocab.datex.org/terms#parkingSiteFullAtFloor</seealso>
    let parkingSiteFullAtFloor =
        Prefixed_Name(datex, "parkingSiteFullAtFloor") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteOvercrowdingStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The overcrowding status of the parking site. Choose between using a two-stage approach or the more general statement ‘(not) overcrowding’. You can sharpen this information by using the ‘Thresholds’ component. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteOvercrowdingStatus">http://vocab.datex.org/terms#parkingSiteOvercrowdingStatus</seealso>
    let parkingSiteOvercrowdingStatus =
        Prefixed_Name(datex, "parkingSiteOvercrowdingStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the parking site (spaces available or not).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteStatus">http://vocab.datex.org/terms#parkingSiteStatus</seealso>
    let parkingSiteStatus = Prefixed_Name(datex, "parkingSiteStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteStatusExtension">http://vocab.datex.org/terms#parkingSiteStatusExtension</seealso>
    let parkingSiteStatusExtension =
        Prefixed_Name(datex, "parkingSiteStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single parking space. It is possible to define the same parking space more than once with different properties, e.g. when there is a different parking assignment for different times.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingSpace">http://vocab.datex.org/terms#ParkingSpace</seealso>
    let ParkingSpace = Prefixed_Name(datex, "ParkingSpace") |> PrefixedName

    /// <summary>
    ///   <para>datex:identicalToParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Points to another instance of 'ParkingSpace', which is identical from a local point of view (i.e. which is the same parking space). To be used when defining mixed parking areas (with using different time slots).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#identicalToParkingSpace">http://vocab.datex.org/terms#identicalToParkingSpace</seealso>
    let identicalToParkingSpace =
        Prefixed_Name(datex, "identicalToParkingSpace") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dimension of the parking space (not all dimension attributes need to be provided). If the parking space is not rectangular, its dimension is specified as the smallest rectangle fitting inside its shape.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceDimension">http://vocab.datex.org/terms#parkingSpaceDimension</seealso>
    let parkingSpaceDimension =
        Prefixed_Name(datex, "parkingSpaceDimension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceExtension">http://vocab.datex.org/terms#parkingSpaceExtension</seealso>
    let parkingSpaceExtension =
        Prefixed_Name(datex, "parkingSpaceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointByCoordinatesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointByCoordinatesExtension">http://vocab.datex.org/terms#pointByCoordinatesExtension</seealso>
    let pointByCoordinatesExtension =
        Prefixed_Name(datex, "pointByCoordinatesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointCoordinates">http://vocab.datex.org/terms#pointCoordinates</seealso>
    let pointCoordinates = Prefixed_Name(datex, "pointCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>datex:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#latitude">http://vocab.datex.org/terms#latitude</seealso>
    let latitude = Prefixed_Name(datex, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>datex:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#longitude">http://vocab.datex.org/terms#longitude</seealso>
    let longitude = Prefixed_Name(datex, "longitude") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointCoordinatesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointCoordinatesExtension">http://vocab.datex.org/terms#pointCoordinatesExtension</seealso>
    let pointCoordinatesExtension =
        Prefixed_Name(datex, "pointCoordinatesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PointDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of the destination of a defined route or itinerary which is a point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PointDestination">http://vocab.datex.org/terms#PointDestination</seealso>
    let PointDestination = Prefixed_Name(datex, "PointDestination") |> PrefixedName
    /// <summary>
    ///   <para>datex:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A single point defined by a coordinate set and TPEG decriptors.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#point">http://vocab.datex.org/terms#point</seealso>
    let point = Prefixed_Name(datex, "point") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointDestinationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointDestinationExtension">http://vocab.datex.org/terms#pointDestinationExtension</seealso>
    let pointDestinationExtension =
        Prefixed_Name(datex, "pointDestinationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PointExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension point for 'Point' to support the description of junctions (and other alternative point descriptions).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PointExtended">http://vocab.datex.org/terms#PointExtended</seealso>
    let PointExtended = Prefixed_Name(datex, "PointExtended") |> PrefixedName
    /// <summary>
    ///   <para>datex:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#description">http://vocab.datex.org/terms#description</seealso>
    let description = Prefixed_Name(datex, "description") |> PrefixedName
    /// <summary>
    ///   <para>datex:junction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#junction">http://vocab.datex.org/terms#junction</seealso>
    let junction = Prefixed_Name(datex, "junction") |> PrefixedName

    /// <summary>
    ///   <para>datex:deIcingApplicationRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deIcingApplicationRate">http://vocab.datex.org/terms#deIcingApplicationRate</seealso>
    let deIcingApplicationRate =
        Prefixed_Name(datex, "deIcingApplicationRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:deIcingConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deIcingConcentration">http://vocab.datex.org/terms#deIcingConcentration</seealso>
    let deIcingConcentration =
        Prefixed_Name(datex, "deIcingConcentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:depthOfSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#depthOfSnow">http://vocab.datex.org/terms#depthOfSnow</seealso>
    let depthOfSnow = Prefixed_Name(datex, "depthOfSnow") |> PrefixedName

    /// <summary>
    ///   <para>datex:protectionTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#protectionTemperature">http://vocab.datex.org/terms#protectionTemperature</seealso>
    let protectionTemperature =
        Prefixed_Name(datex, "protectionTemperature") |> PrefixedName

    /// <summary>
    ///   <para>datex:TemperatureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of temperature.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemperatureValue">http://vocab.datex.org/terms#TemperatureValue</seealso>
    let TemperatureValue = Prefixed_Name(datex, "TemperatureValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadSurfaceConditionMeasurementsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurementsExtension">http://vocab.datex.org/terms#roadSurfaceConditionMeasurementsExtension</seealso>
    let roadSurfaceConditionMeasurementsExtension =
        Prefixed_Name(datex, "roadSurfaceConditionMeasurementsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadSurfaceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadSurfaceTemperature">http://vocab.datex.org/terms#roadSurfaceTemperature</seealso>
    let roadSurfaceTemperature =
        Prefixed_Name(datex, "roadSurfaceTemperature") |> PrefixedName

    /// <summary>
    ///   <para>datex:waterFilmThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#waterFilmThickness">http://vocab.datex.org/terms#waterFilmThickness</seealso>
    let waterFilmThickness = Prefixed_Name(datex, "waterFilmThickness") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadsideAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of road side assistance required or being given.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadsideAssistance">http://vocab.datex.org/terms#RoadsideAssistance</seealso>
    let RoadsideAssistance = Prefixed_Name(datex, "RoadsideAssistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadsideAssistanceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadsideAssistanceExtension">http://vocab.datex.org/terms#roadsideAssistanceExtension</seealso>
    let roadsideAssistanceExtension =
        Prefixed_Name(datex, "roadsideAssistanceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadsideAssistanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadsideAssistanceType">http://vocab.datex.org/terms#roadsideAssistanceType</seealso>
    let roadsideAssistanceType =
        Prefixed_Name(datex, "roadsideAssistanceType") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadsideServiceDisruption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of disruption to normal roadside services (e.g. specific services at a service area).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadsideServiceDisruption">http://vocab.datex.org/terms#RoadsideServiceDisruption</seealso>
    let RoadsideServiceDisruption =
        Prefixed_Name(datex, "RoadsideServiceDisruption") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadsideServiceDisruptionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadsideServiceDisruptionExtension">http://vocab.datex.org/terms#roadsideServiceDisruptionExtension</seealso>
    let roadsideServiceDisruptionExtension =
        Prefixed_Name(datex, "roadsideServiceDisruptionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadsideServiceDisruptionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of roadside service which is disrupted.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadsideServiceDisruptionType">http://vocab.datex.org/terms#roadsideServiceDisruptionType</seealso>
    let roadsideServiceDisruptionType =
        Prefixed_Name(datex, "roadsideServiceDisruptionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a point location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegPointDescriptor">http://vocab.datex.org/terms#TpegPointDescriptor</seealso>
    let TpegPointDescriptor =
        Prefixed_Name(datex, "TpegPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is a road junction point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegJunction">http://vocab.datex.org/terms#TpegJunction</seealso>
    let TpegJunction = Prefixed_Name(datex, "TpegJunction") |> PrefixedName
    /// <summary>
    ///   <para>datex:ilc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptor for describing a junction by identifying the intersecting roads at a road junction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ilc">http://vocab.datex.org/terms#ilc</seealso>
    let ilc = Prefixed_Name(datex, "ilc") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegJunctionPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a point at a junction on a road network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegJunctionPointDescriptor">http://vocab.datex.org/terms#TpegJunctionPointDescriptor</seealso>
    let TpegJunctionPointDescriptor =
        Prefixed_Name(datex, "TpegJunctionPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:otherName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptive name which helps to identify the junction point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherName">http://vocab.datex.org/terms#otherName</seealso>
    let otherName = Prefixed_Name(datex, "otherName") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegOtherPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General descriptor for describing a point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegOtherPointDescriptor">http://vocab.datex.org/terms#TpegOtherPointDescriptor</seealso>
    let TpegOtherPointDescriptor =
        Prefixed_Name(datex, "TpegOtherPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegJunctionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegJunctionExtension">http://vocab.datex.org/terms#tpegJunctionExtension</seealso>
    let tpegJunctionExtension =
        Prefixed_Name(datex, "tpegJunctionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegJunctionPointDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorExtension">http://vocab.datex.org/terms#tpegJunctionPointDescriptorExtension</seealso>
    let tpegJunctionPointDescriptorExtension =
        Prefixed_Name(datex, "tpegJunctionPointDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegJunctionPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegJunctionPointDescriptorType">http://vocab.datex.org/terms#tpegJunctionPointDescriptorType</seealso>
    let tpegJunctionPointDescriptorType =
        Prefixed_Name(datex, "tpegJunctionPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegDirection">http://vocab.datex.org/terms#tpegDirection</seealso>
    let tpegDirection = Prefixed_Name(datex, "tpegDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegLinearLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegLinearLocationExtension">http://vocab.datex.org/terms#tpegLinearLocationExtension</seealso>
    let tpegLinearLocationExtension =
        Prefixed_Name(datex, "tpegLinearLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegLinearLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegLinearLocationType">http://vocab.datex.org/terms#tpegLinearLocationType</seealso>
    let tpegLinearLocationType =
        Prefixed_Name(datex, "tpegLinearLocationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegNamedOnlyArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by a well-known name.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegNamedOnlyArea">http://vocab.datex.org/terms#TpegNamedOnlyArea</seealso>
    let TpegNamedOnlyArea = Prefixed_Name(datex, "TpegNamedOnlyArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegNamedOnlyAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegNamedOnlyAreaExtension">http://vocab.datex.org/terms#tpegNamedOnlyAreaExtension</seealso>
    let tpegNamedOnlyAreaExtension =
        Prefixed_Name(datex, "tpegNamedOnlyAreaExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegNonJunctionPointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegNonJunctionPointExtension">http://vocab.datex.org/terms#tpegNonJunctionPointExtension</seealso>
    let tpegNonJunctionPointExtension =
        Prefixed_Name(datex, "tpegNonJunctionPointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegOtherPointDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegOtherPointDescriptorExtension">http://vocab.datex.org/terms#tpegOtherPointDescriptorExtension</seealso>
    let tpegOtherPointDescriptorExtension =
        Prefixed_Name(datex, "tpegOtherPointDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegOtherPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegOtherPointDescriptorType">http://vocab.datex.org/terms#tpegOtherPointDescriptorType</seealso>
    let tpegOtherPointDescriptorType =
        Prefixed_Name(datex, "tpegOtherPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegPointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegPointExtension">http://vocab.datex.org/terms#tpegPointExtension</seealso>
    let tpegPointExtension = Prefixed_Name(datex, "tpegPointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegPointDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegPointDescriptorExtension">http://vocab.datex.org/terms#tpegPointDescriptorExtension</seealso>
    let tpegPointDescriptorExtension =
        Prefixed_Name(datex, "tpegPointDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:visibilityInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#visibilityInformationExtension">http://vocab.datex.org/terms#visibilityInformationExtension</seealso>
    let visibilityInformationExtension =
        Prefixed_Name(datex, "visibilityInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Vms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides the current status and settings of the VMS and the currently displayed information. Where a VMS is displaying a sequence or alternating set of messages these are ordered according to the messageIndex qualifier.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Vms">http://vocab.datex.org/terms#Vms</seealso>
    let Vms = Prefixed_Name(datex, "Vms") |> PrefixedName

    /// <summary>
    ///   <para>datex:managedLogicalLocationOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managedLogicalLocationOverride">http://vocab.datex.org/terms#managedLogicalLocationOverride</seealso>
    let managedLogicalLocationOverride =
        Prefixed_Name(datex, "managedLogicalLocationOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsManagedLogicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The logical location (e.g. a car park, a section of road, a junction etc.) which a VMS contributes to the management of.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsManagedLogicalLocation">http://vocab.datex.org/terms#VmsManagedLogicalLocation</seealso>
    let VmsManagedLogicalLocation =
        Prefixed_Name(datex, "VmsManagedLogicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDisplayAreaSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDisplayAreaSettings">http://vocab.datex.org/terms#pictogramDisplayAreaSettings</seealso>
    let pictogramDisplayAreaSettings =
        Prefixed_Name(datex, "pictogramDisplayAreaSettings") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings">http://vocab.datex.org/terms#_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings</seealso>
    let _VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings =
        Prefixed_Name(datex, "_VmsPictogramDisplayAreaIndexPictogramDisplayAreaSettings") |> PrefixedName

    /// <summary>
    ///   <para>datex:textDisplayAreaSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textDisplayAreaSettings">http://vocab.datex.org/terms#textDisplayAreaSettings</seealso>
    let textDisplayAreaSettings =
        Prefixed_Name(datex, "textDisplayAreaSettings") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsDynamicCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsDynamicCharacteristics">http://vocab.datex.org/terms#vmsDynamicCharacteristics</seealso>
    let vmsDynamicCharacteristics =
        Prefixed_Name(datex, "vmsDynamicCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsDynamicCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides the current characteristic settings for the VMS which can be dynamically configured and therefore which override any corresponding characteristics set for the VMS in the relevant VmsUnitPublication.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsDynamicCharacteristics">http://vocab.datex.org/terms#VmsDynamicCharacteristics</seealso>
    let VmsDynamicCharacteristics =
        Prefixed_Name(datex, "VmsDynamicCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsExtension">http://vocab.datex.org/terms#vmsExtension</seealso>
    let vmsExtension = Prefixed_Name(datex, "vmsExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>The type of fault which is being reported for the specified variable message sign panel.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsFault">http://vocab.datex.org/terms#vmsFault</seealso>
    let vmsFault = Prefixed_Name(datex, "vmsFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the fault which is being reported for the specified variable message sign panel.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsFault">http://vocab.datex.org/terms#VmsFault</seealso>
    let VmsFault = Prefixed_Name(datex, "VmsFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsLocationOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsLocationOverride">http://vocab.datex.org/terms#vmsLocationOverride</seealso>
    let vmsLocationOverride =
        Prefixed_Name(datex, "vmsLocationOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsMessage">http://vocab.datex.org/terms#vmsMessage</seealso>
    let vmsMessage = Prefixed_Name(datex, "vmsMessage") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsMessageIndexVmsMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsMessageIndexVmsMessage">http://vocab.datex.org/terms#_VmsMessageIndexVmsMessage</seealso>
    let _VmsMessageIndexVmsMessage =
        Prefixed_Name(datex, "_VmsMessageIndexVmsMessage") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsMessageSequencingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsMessageSequencingInterval">http://vocab.datex.org/terms#vmsMessageSequencingInterval</seealso>
    let vmsMessageSequencingInterval =
        Prefixed_Name(datex, "vmsMessageSequencingInterval") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsWorking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsWorking">http://vocab.datex.org/terms#vmsWorking</seealso>
    let vmsWorking = Prefixed_Name(datex, "vmsWorking") |> PrefixedName

    /// <summary>
    ///   <para>datex:WinterDrivingManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Winter driving management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WinterDrivingManagement">http://vocab.datex.org/terms#WinterDrivingManagement</seealso>
    let WinterDrivingManagement =
        Prefixed_Name(datex, "WinterDrivingManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:winterDrivingManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#winterDrivingManagementExtension">http://vocab.datex.org/terms#winterDrivingManagementExtension</seealso>
    let winterDrivingManagementExtension =
        Prefixed_Name(datex, "winterDrivingManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:areaExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaExtended">http://vocab.datex.org/terms#areaExtended</seealso>
    let areaExtended = Prefixed_Name(datex, "areaExtended") |> PrefixedName
    /// <summary>
    ///   <para>datex:openlrExtendedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrExtendedArea">http://vocab.datex.org/terms#openlrExtendedArea</seealso>
    let openlrExtendedArea = Prefixed_Name(datex, "openlrExtendedArea") |> PrefixedName
    /// <summary>
    ///   <para>datex:any</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#any">http://vocab.datex.org/terms#any</seealso>
    let any = Prefixed_Name(datex, "any") |> PrefixedName
    /// <summary>
    ///   <para>datex:targetClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#targetClass">http://vocab.datex.org/terms#targetClass</seealso>
    let targetClass = Prefixed_Name(datex, "targetClass") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusPublication">http://vocab.datex.org/terms#parkingStatusPublication</seealso>
    let parkingStatusPublication =
        Prefixed_Name(datex, "parkingStatusPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTablePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTablePublication">http://vocab.datex.org/terms#parkingTablePublication</seealso>
    let parkingTablePublication =
        Prefixed_Name(datex, "parkingTablePublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingVehiclesPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingVehiclesPublication">http://vocab.datex.org/terms#parkingVehiclesPublication</seealso>
    let parkingVehiclesPublication =
        Prefixed_Name(datex, "parkingVehiclesPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupIndex">http://vocab.datex.org/terms#groupIndex</seealso>
    let groupIndex = Prefixed_Name(datex, "groupIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingSpaceBasics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceBasics">http://vocab.datex.org/terms#parkingSpaceBasics</seealso>
    let parkingSpaceBasics = Prefixed_Name(datex, "parkingSpaceBasics") |> PrefixedName
    /// <summary>
    ///   <para>datex:AirShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AirShow">http://vocab.datex.org/terms#AirShow</seealso>
    let AirShow = Prefixed_Name(datex, "AirShow") |> PrefixedName
    /// <summary>
    ///   <para>datex:Attack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Attack">http://vocab.datex.org/terms#Attack</seealso>
    let Attack = Prefixed_Name(datex, "Attack") |> PrefixedName
    /// <summary>
    ///   <para>datex:Avalanches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Avalanches">http://vocab.datex.org/terms#Avalanches</seealso>
    let Avalanches = Prefixed_Name(datex, "Avalanches") |> PrefixedName
    /// <summary>
    ///   <para>datex:BallGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BallGame">http://vocab.datex.org/terms#BallGame</seealso>
    let BallGame = Prefixed_Name(datex, "BallGame") |> PrefixedName
    /// <summary>
    ///   <para>datex:BicycleRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BicycleRace">http://vocab.datex.org/terms#BicycleRace</seealso>
    let BicycleRace = Prefixed_Name(datex, "BicycleRace") |> PrefixedName
    /// <summary>
    ///   <para>datex:BlastingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BlastingWork">http://vocab.datex.org/terms#BlastingWork</seealso>
    let BlastingWork = Prefixed_Name(datex, "BlastingWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:BlowingDust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BlowingDust">http://vocab.datex.org/terms#BlowingDust</seealso>
    let BlowingDust = Prefixed_Name(datex, "BlowingDust") |> PrefixedName
    /// <summary>
    ///   <para>datex:BoatShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BoatShow">http://vocab.datex.org/terms#BoatShow</seealso>
    let BoatShow = Prefixed_Name(datex, "BoatShow") |> PrefixedName
    /// <summary>
    ///   <para>datex:BoxingTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BoxingTournament">http://vocab.datex.org/terms#BoxingTournament</seealso>
    let BoxingTournament = Prefixed_Name(datex, "BoxingTournament") |> PrefixedName
    /// <summary>
    ///   <para>datex:BrokenDownVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BrokenDownVehicle">http://vocab.datex.org/terms#BrokenDownVehicle</seealso>
    let BrokenDownVehicle = Prefixed_Name(datex, "BrokenDownVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:TunnelVentilationFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TunnelVentilationFault">http://vocab.datex.org/terms#TunnelVentilationFault</seealso>
    let TunnelVentilationFault =
        Prefixed_Name(datex, "TunnelVentilationFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:TurnAroundInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TurnAroundInOperation">http://vocab.datex.org/terms#TurnAroundInOperation</seealso>
    let TurnAroundInOperation =
        Prefixed_Name(datex, "TurnAroundInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4PointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4PointExtension">http://vocab.datex.org/terms#alertCMethod4PointExtension</seealso>
    let alertCMethod4PointExtension =
        Prefixed_Name(datex, "alertCMethod4PointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:d2LogicalModelExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#d2LogicalModelExtension">http://vocab.datex.org/terms#d2LogicalModelExtension</seealso>
    let d2LogicalModelExtension =
        Prefixed_Name(datex, "d2LogicalModelExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:payloadPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#payloadPublication">http://vocab.datex.org/terms#payloadPublication</seealso>
    let payloadPublication = Prefixed_Name(datex, "payloadPublication") |> PrefixedName
    /// <summary>
    ///   <para>datex:PayloadPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PayloadPublication">http://vocab.datex.org/terms#PayloadPublication</seealso>
    let PayloadPublication = Prefixed_Name(datex, "PayloadPublication") |> PrefixedName
    /// <summary>
    ///   <para>datex:response</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#response">http://vocab.datex.org/terms#response</seealso>
    let response = Prefixed_Name(datex, "response") |> PrefixedName
    /// <summary>
    ///   <para>datex:heaviestAxleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heaviestAxleWeight">http://vocab.datex.org/terms#heaviestAxleWeight</seealso>
    let heaviestAxleWeight = Prefixed_Name(datex, "heaviestAxleWeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:heaviestAxleWeightCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristicExtension">http://vocab.datex.org/terms#heaviestAxleWeightCharacteristicExtension</seealso>
    let heaviestAxleWeightCharacteristicExtension =
        Prefixed_Name(datex, "heaviestAxleWeightCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:HeightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Height characteristic of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeightCharacteristic">http://vocab.datex.org/terms#HeightCharacteristic</seealso>
    let HeightCharacteristic =
        Prefixed_Name(datex, "HeightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOccupanyDetectionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOccupanyDetectionType">http://vocab.datex.org/terms#parkingOccupanyDetectionType</seealso>
    let parkingOccupanyDetectionType =
        Prefixed_Name(datex, "parkingOccupanyDetectionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingPrincipalNumberOfSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPrincipalNumberOfSpaces">http://vocab.datex.org/terms#parkingPrincipalNumberOfSpaces</seealso>
    let parkingPrincipalNumberOfSpaces =
        Prefixed_Name(datex, "parkingPrincipalNumberOfSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTable">http://vocab.datex.org/terms#parkingTable</seealso>
    let parkingTable = Prefixed_Name(datex, "parkingTable") |> PrefixedName

    /// <summary>
    ///   <para>datex:almostFullDecreasing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#almostFullDecreasing">http://vocab.datex.org/terms#almostFullDecreasing</seealso>
    let almostFullDecreasing =
        Prefixed_Name(datex, "almostFullDecreasing") |> PrefixedName

    /// <summary>
    ///   <para>datex:almostFullIncreasing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#almostFullIncreasing">http://vocab.datex.org/terms#almostFullIncreasing</seealso>
    let almostFullIncreasing =
        Prefixed_Name(datex, "almostFullIncreasing") |> PrefixedName

    /// <summary>
    ///   <para>datex:fullDecreasing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fullDecreasing">http://vocab.datex.org/terms#fullDecreasing</seealso>
    let fullDecreasing = Prefixed_Name(datex, "fullDecreasing") |> PrefixedName
    /// <summary>
    ///   <para>datex:fullIncreasing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fullIncreasing">http://vocab.datex.org/terms#fullIncreasing</seealso>
    let fullIncreasing = Prefixed_Name(datex, "fullIncreasing") |> PrefixedName

    /// <summary>
    ///   <para>datex:specialLocationParkingSiteExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specialLocationParkingSiteExtension">http://vocab.datex.org/terms#specialLocationParkingSiteExtension</seealso>
    let specialLocationParkingSiteExtension =
        Prefixed_Name(datex, "specialLocationParkingSiteExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AnimalsOnTheInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AnimalsOnTheInfrastructure">http://vocab.datex.org/terms#AnimalsOnTheInfrastructure</seealso>
    let AnimalsOnTheInfrastructure =
        Prefixed_Name(datex, "AnimalsOnTheInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:Assault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Assault">http://vocab.datex.org/terms#Assault</seealso>
    let Assault = Prefixed_Name(datex, "Assault") |> PrefixedName
    /// <summary>
    ///   <para>datex:AttackOnVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AttackOnVehicle">http://vocab.datex.org/terms#AttackOnVehicle</seealso>
    let AttackOnVehicle = Prefixed_Name(datex, "AttackOnVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:AutomatedTollSystemFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AutomatedTollSystemFailure">http://vocab.datex.org/terms#AutomatedTollSystemFailure</seealso>
    let AutomatedTollSystemFailure =
        Prefixed_Name(datex, "AutomatedTollSystemFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:BlackIce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BlackIce">http://vocab.datex.org/terms#BlackIce</seealso>
    let BlackIce = Prefixed_Name(datex, "BlackIce") |> PrefixedName
    /// <summary>
    ///   <para>datex:BlowingSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BlowingSnow">http://vocab.datex.org/terms#BlowingSnow</seealso>
    let BlowingSnow = Prefixed_Name(datex, "BlowingSnow") |> PrefixedName
    /// <summary>
    ///   <para>datex:BrokenDownBus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BrokenDownBus">http://vocab.datex.org/terms#BrokenDownBus</seealso>
    let BrokenDownBus = Prefixed_Name(datex, "BrokenDownBus") |> PrefixedName
    /// <summary>
    ///   <para>datex:BurstWaterMain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BurstWaterMain">http://vocab.datex.org/terms#BurstWaterMain</seealso>
    let BurstWaterMain = Prefixed_Name(datex, "BurstWaterMain") |> PrefixedName

    /// <summary>
    ///   <para>datex:CarriagewayClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CarriagewayClosures">http://vocab.datex.org/terms#CarriagewayClosures</seealso>
    let CarriagewayClosures =
        Prefixed_Name(datex, "CarriagewayClosures") |> PrefixedName

    /// <summary>
    ///   <para>datex:CeremonialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CeremonialEvent">http://vocab.datex.org/terms#CeremonialEvent</seealso>
    let CeremonialEvent = Prefixed_Name(datex, "CeremonialEvent") |> PrefixedName
    /// <summary>
    ///   <para>datex:CivilEmergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CivilEmergency">http://vocab.datex.org/terms#CivilEmergency</seealso>
    let CivilEmergency = Prefixed_Name(datex, "CivilEmergency") |> PrefixedName
    /// <summary>
    ///   <para>datex:CollapsedSewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CollapsedSewer">http://vocab.datex.org/terms#CollapsedSewer</seealso>
    let CollapsedSewer = Prefixed_Name(datex, "CollapsedSewer") |> PrefixedName
    /// <summary>
    ///   <para>datex:Concert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Concert">http://vocab.datex.org/terms#Concert</seealso>
    let Concert = Prefixed_Name(datex, "Concert") |> PrefixedName
    /// <summary>
    ///   <para>datex:Contraflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Contraflow">http://vocab.datex.org/terms#Contraflow</seealso>
    let Contraflow = Prefixed_Name(datex, "Contraflow") |> PrefixedName

    /// <summary>
    ///   <para>datex:ControlledAvalanche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ControlledAvalanche">http://vocab.datex.org/terms#ControlledAvalanche</seealso>
    let ControlledAvalanche =
        Prefixed_Name(datex, "ControlledAvalanche") |> PrefixedName

    /// <summary>
    ///   <para>datex:CulturalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CulturalEvent">http://vocab.datex.org/terms#CulturalEvent</seealso>
    let CulturalEvent = Prefixed_Name(datex, "CulturalEvent") |> PrefixedName
    /// <summary>
    ///   <para>datex:CustomsOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CustomsOperation">http://vocab.datex.org/terms#CustomsOperation</seealso>
    let CustomsOperation = Prefixed_Name(datex, "CustomsOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:totalNumberOfPeopleInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of people that are involved.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#totalNumberOfPeopleInvolved">http://vocab.datex.org/terms#totalNumberOfPeopleInvolved</seealso>
    let totalNumberOfPeopleInvolved =
        Prefixed_Name(datex, "totalNumberOfPeopleInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The vehicle involved in the accident.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleInvolved">http://vocab.datex.org/terms#vehicleInvolved</seealso>
    let vehicleInvolved = Prefixed_Name(datex, "vehicleInvolved") |> PrefixedName
    /// <summary>
    ///   <para>datex:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of an individual vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Vehicle">http://vocab.datex.org/terms#Vehicle</seealso>
    let Vehicle = Prefixed_Name(datex, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:applicableMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableMonth">http://vocab.datex.org/terms#applicableMonth</seealso>
    let applicableMonth = Prefixed_Name(datex, "applicableMonth") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingAccessReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingAccessReference">http://vocab.datex.org/terms#_ParkingAccessReference</seealso>
    let _ParkingAccessReference =
        Prefixed_Name(datex, "_ParkingAccessReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:floatingPointMetreDistanceValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#floatingPointMetreDistanceValueExtension">http://vocab.datex.org/terms#floatingPointMetreDistanceValueExtension</seealso>
    let floatingPointMetreDistanceValueExtension =
        Prefixed_Name(datex, "floatingPointMetreDistanceValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:GeneralInstructionOrMessageToRoadUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GeneralInstructionOrMessageToRoadUsers">http://vocab.datex.org/terms#GeneralInstructionOrMessageToRoadUsers</seealso>
    let GeneralInstructionOrMessageToRoadUsers =
        Prefixed_Name(datex, "GeneralInstructionOrMessageToRoadUsers") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalInstructionOrMessageToRoadUsersExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalInstructionOrMessageToRoadUsersExtension">http://vocab.datex.org/terms#generalInstructionOrMessageToRoadUsersExtension</seealso>
    let generalInstructionOrMessageToRoadUsersExtension =
        Prefixed_Name(datex, "generalInstructionOrMessageToRoadUsersExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalInstructionToRoadUsersType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalInstructionToRoadUsersType">http://vocab.datex.org/terms#generalInstructionToRoadUsersType</seealso>
    let generalInstructionToRoadUsersType =
        Prefixed_Name(datex, "generalInstructionToRoadUsersType") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalMessageToRoadUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalMessageToRoadUsers">http://vocab.datex.org/terms#generalMessageToRoadUsers</seealso>
    let generalMessageToRoadUsers =
        Prefixed_Name(datex, "generalMessageToRoadUsers") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalNetworkManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalNetworkManagementExtension">http://vocab.datex.org/terms#generalNetworkManagementExtension</seealso>
    let generalNetworkManagementExtension =
        Prefixed_Name(datex, "generalNetworkManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalNetworkManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of traffic management action instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalNetworkManagementType">http://vocab.datex.org/terms#generalNetworkManagementType</seealso>
    let generalNetworkManagementType =
        Prefixed_Name(datex, "generalNetworkManagementType") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficManuallyDirectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficManuallyDirectedBy">http://vocab.datex.org/terms#trafficManuallyDirectedBy</seealso>
    let trafficManuallyDirectedBy =
        Prefixed_Name(datex, "trafficManuallyDirectedBy") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalObstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalObstructionExtension">http://vocab.datex.org/terms#generalObstructionExtension</seealso>
    let generalObstructionExtension =
        Prefixed_Name(datex, "generalObstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:obstructionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Characterization of the type of general obstruction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#obstructionType">http://vocab.datex.org/terms#obstructionType</seealso>
    let obstructionType = Prefixed_Name(datex, "obstructionType") |> PrefixedName
    /// <summary>
    ///   <para>datex:GenericPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication used to make level B extensions at the publication level.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GenericPublication">http://vocab.datex.org/terms#GenericPublication</seealso>
    let GenericPublication = Prefixed_Name(datex, "GenericPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:genericPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#genericPublicationExtension">http://vocab.datex.org/terms#genericPublicationExtension</seealso>
    let genericPublicationExtension =
        Prefixed_Name(datex, "genericPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_GenericPublicationExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_GenericPublicationExtensionType">http://vocab.datex.org/terms#_GenericPublicationExtensionType</seealso>
    let _GenericPublicationExtensionType =
        Prefixed_Name(datex, "_GenericPublicationExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:GenericSituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A generic SituationRecord for use when adding level B extensions at the SituationRecord level.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GenericSituationRecord">http://vocab.datex.org/terms#GenericSituationRecord</seealso>
    let GenericSituationRecord =
        Prefixed_Name(datex, "GenericSituationRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:genericSituationRecordName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the GenericSituationRecord.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#genericSituationRecordName">http://vocab.datex.org/terms#genericSituationRecordName</seealso>
    let genericSituationRecordName =
        Prefixed_Name(datex, "genericSituationRecordName") |> PrefixedName

    /// <summary>
    ///   <para>datex:SituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable versioned instance of a single record/element within a situation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SituationRecord">http://vocab.datex.org/terms#SituationRecord</seealso>
    let SituationRecord = Prefixed_Name(datex, "SituationRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:GrossWeightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gross weight characteristic of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GrossWeightCharacteristic">http://vocab.datex.org/terms#GrossWeightCharacteristic</seealso>
    let GrossWeightCharacteristic =
        Prefixed_Name(datex, "GrossWeightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:comparisonOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#comparisonOperator">http://vocab.datex.org/terms#comparisonOperator</seealso>
    let comparisonOperator = Prefixed_Name(datex, "comparisonOperator") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfLocationsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfLocationsExtension">http://vocab.datex.org/terms#groupOfLocationsExtension</seealso>
    let groupOfLocationsExtension =
        Prefixed_Name(datex, "groupOfLocationsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfParkingSites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A logical composition of parking sites with aggregated properties (e.g. number of spaces). Examples: Urban parking area "West" or all truck parkings along a motorway. The included parking sites may -but must not- be specified as subcomponents.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfParkingSites">http://vocab.datex.org/terms#GroupOfParkingSites</seealso>
    let GroupOfParkingSites =
        Prefixed_Name(datex, "GroupOfParkingSites") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSitesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSitesExtension">http://vocab.datex.org/terms#groupOfParkingSitesExtension</seealso>
    let groupOfParkingSitesExtension =
        Prefixed_Name(datex, "groupOfParkingSitesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSitesType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of this group of parking sites.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSitesType">http://vocab.datex.org/terms#groupOfParkingSitesType</seealso>
    let groupOfParkingSitesType =
        Prefixed_Name(datex, "groupOfParkingSitesType") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSite">http://vocab.datex.org/terms#parkingSite</seealso>
    let parkingSite = Prefixed_Name(datex, "parkingSite") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A record containing static details of a parking site. Must be specialised as an 'Urban-' or 'InterUrbanParkingSite' or a 'SpecialLocationParkingSite'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingSite">http://vocab.datex.org/terms#ParkingSite</seealso>
    let ParkingSite = Prefixed_Name(datex, "ParkingSite") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Parking sites of this collection defined by reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteByReference">http://vocab.datex.org/terms#parkingSiteByReference</seealso>
    let parkingSiteByReference =
        Prefixed_Name(datex, "parkingSiteByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A container for static parking information. Must be specialised as a parking site or as a group of parking sites.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRecord">http://vocab.datex.org/terms#ParkingRecord</seealso>
    let ParkingRecord = Prefixed_Name(datex, "ParkingRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfParkingSitesStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dynamic status information for the static object 'GroupOfParkingSites'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfParkingSitesStatus">http://vocab.datex.org/terms#GroupOfParkingSitesStatus</seealso>
    let GroupOfParkingSitesStatus =
        Prefixed_Name(datex, "GroupOfParkingSitesStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSitesStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the group of parking sites (available spaces or not).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSitesStatus">http://vocab.datex.org/terms#groupOfParkingSitesStatus</seealso>
    let groupOfParkingSitesStatus =
        Prefixed_Name(datex, "groupOfParkingSitesStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSitesStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSitesStatusExtension">http://vocab.datex.org/terms#groupOfParkingSitesStatusExtension</seealso>
    let groupOfParkingSitesStatusExtension =
        Prefixed_Name(datex, "groupOfParkingSitesStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingRecordStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains the current status of one parking record defined in the static model (i.e. parking site or group of parking sites) or historical or forecasted data for one parking. Only for the second case, 'parkingStatusTime' must be specified.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRecordStatus">http://vocab.datex.org/terms#ParkingRecordStatus</seealso>
    let ParkingRecordStatus =
        Prefixed_Name(datex, "ParkingRecordStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfParkingSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of parking spaces. All information provided has to be identical for all places in this group. Can also be used just to give the number of lorry parkings, for example. 'GroupOfParkingSpaces' may be multiple defined or include each other.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfParkingSpaces">http://vocab.datex.org/terms#GroupOfParkingSpaces</seealso>
    let GroupOfParkingSpaces =
        Prefixed_Name(datex, "GroupOfParkingSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:dimensionOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dimension of a virtual rectangle encapsulating the group of parking spaces. Use 'dimensionUsableArea' to define the total space available for parking within this group. Do not use 'dimensionHeight'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionOfGroup">http://vocab.datex.org/terms#dimensionOfGroup</seealso>
    let dimensionOfGroup = Prefixed_Name(datex, "dimensionOfGroup") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpacesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpacesExtension">http://vocab.datex.org/terms#groupOfParkingSpacesExtension</seealso>
    let groupOfParkingSpacesExtension =
        Prefixed_Name(datex, "groupOfParkingSpacesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:identicalToGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Points to another instance of 'GroupOfParkingSpaces', which is identical from a local point of view. To be used when defining mixed parking areas with different time slots.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#identicalToGroup">http://vocab.datex.org/terms#identicalToGroup</seealso>
    let identicalToGroup = Prefixed_Name(datex, "identicalToGroup") |> PrefixedName
    /// <summary>
    ///   <para>datex:realSubsetOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Points to another instance of 'GroupOfParkingSpaces', which is a real superset from a local point of view. To be used when defining mixed parking areas with different time slots.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#realSubsetOfGroup">http://vocab.datex.org/terms#realSubsetOfGroup</seealso>
    let realSubsetOfGroup = Prefixed_Name(datex, "realSubsetOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>datex:Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a single road with optional directionality defined between two points on the same road. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Linear">http://vocab.datex.org/terms#Linear</seealso>
    let Linear = Prefixed_Name(datex, "Linear") |> PrefixedName
    /// <summary>
    ///   <para>datex:alertCLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLinear">http://vocab.datex.org/terms#alertCLinear</seealso>
    let alertCLinear = Prefixed_Name(datex, "alertCLinear") |> PrefixedName
    /// <summary>
    ///   <para>datex:linearExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearExtension">http://vocab.datex.org/terms#linearExtension</seealso>
    let linearExtension = Prefixed_Name(datex, "linearExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_LinearExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_LinearExtensionType">http://vocab.datex.org/terms#_LinearExtensionType</seealso>
    let _LinearExtensionType =
        Prefixed_Name(datex, "_LinearExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:areaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaName">http://vocab.datex.org/terms#areaName</seealso>
    let areaName = Prefixed_Name(datex, "areaName") |> PrefixedName
    /// <summary>
    ///   <para>datex:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#county">http://vocab.datex.org/terms#county</seealso>
    let county = Prefixed_Name(datex, "county") |> PrefixedName
    /// <summary>
    ///   <para>datex:namedAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#namedAreaExtension">http://vocab.datex.org/terms#namedAreaExtension</seealso>
    let namedAreaExtension = Prefixed_Name(datex, "namedAreaExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:nation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nation">http://vocab.datex.org/terms#nation</seealso>
    let nation = Prefixed_Name(datex, "nation") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOperatorControlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOperatorControlArea">http://vocab.datex.org/terms#roadOperatorControlArea</seealso>
    let roadOperatorControlArea =
        Prefixed_Name(datex, "roadOperatorControlArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:destination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#destination">http://vocab.datex.org/terms#destination</seealso>
    let destination = Prefixed_Name(datex, "destination") |> PrefixedName

    /// <summary>
    ///   <para>datex:networkLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#networkLocationExtension">http://vocab.datex.org/terms#networkLocationExtension</seealso>
    let networkLocationExtension =
        Prefixed_Name(datex, "networkLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPositionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPositionalDescription">http://vocab.datex.org/terms#supplementaryPositionalDescription</seealso>
    let supplementaryPositionalDescription =
        Prefixed_Name(datex, "supplementaryPositionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:SupplementaryPositionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of supplementary positional information which improves the precision of the location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SupplementaryPositionalDescription">http://vocab.datex.org/terms#SupplementaryPositionalDescription</seealso>
    let SupplementaryPositionalDescription =
        Prefixed_Name(datex, "SupplementaryPositionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicableForTrafficType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of traffic to which the network management is applicable.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableForTrafficType">http://vocab.datex.org/terms#applicableForTrafficType</seealso>
    let applicableForTrafficType =
        Prefixed_Name(datex, "applicableForTrafficType") |> PrefixedName

    /// <summary>
    ///   <para>datex:automaticallyInitiated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines whether the network management is initiated by an automatic system.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#automaticallyInitiated">http://vocab.datex.org/terms#automaticallyInitiated</seealso>
    let automaticallyInitiated =
        Prefixed_Name(datex, "automaticallyInitiated") |> PrefixedName

    /// <summary>
    ///   <para>datex:complianceOption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines whether the network management instruction or the control resulting from a network management action is advisory or mandatory.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#complianceOption">http://vocab.datex.org/terms#complianceOption</seealso>
    let complianceOption = Prefixed_Name(datex, "complianceOption") |> PrefixedName

    /// <summary>
    ///   <para>datex:forVehiclesWithCharacteristicsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The characteristics of those vehicles for which the network management is applicable.</para>
    ///   <para>Used to define the vehicle characteristics to which the TrafficValue is applicable primarily in Elaborated Data Publications, but may also be used in Measured Data Publications to override vehicle characteristics defined for the measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#forVehiclesWithCharacteristicsOf">http://vocab.datex.org/terms#forVehiclesWithCharacteristicsOf</seealso>
    let forVehiclesWithCharacteristicsOf =
        Prefixed_Name(datex, "forVehiclesWithCharacteristicsOf") |> PrefixedName

    /// <summary>
    ///   <para>datex:networkManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#networkManagementExtension">http://vocab.datex.org/terms#networkManagementExtension</seealso>
    let networkManagementExtension =
        Prefixed_Name(datex, "networkManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:placesAtWhichApplicable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Places, in generic terms, at which the network management applies.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#placesAtWhichApplicable">http://vocab.datex.org/terms#placesAtWhichApplicable</seealso>
    let placesAtWhichApplicable =
        Prefixed_Name(datex, "placesAtWhichApplicable") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonManagedCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cause of this situation record which is not managed by the publication creator, i.e. one which is not represented by another situation record produced by the same publication creator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonManagedCause">http://vocab.datex.org/terms#NonManagedCause</seealso>
    let NonManagedCause = Prefixed_Name(datex, "NonManagedCause") |> PrefixedName
    /// <summary>
    ///   <para>datex:causeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Description of a cause which is not managed by the publication creator (e.g. an off network cause).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#causeDescription">http://vocab.datex.org/terms#causeDescription</seealso>
    let causeDescription = Prefixed_Name(datex, "causeDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonOrderedLocationGroupByListExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonOrderedLocationGroupByListExtension">http://vocab.datex.org/terms#nonOrderedLocationGroupByListExtension</seealso>
    let nonOrderedLocationGroupByListExtension =
        Prefixed_Name(datex, "nonOrderedLocationGroupByListExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonOrderedLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple (i.e. more than one) physically separate locations which have no specific order.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonOrderedLocations">http://vocab.datex.org/terms#NonOrderedLocations</seealso>
    let NonOrderedLocations =
        Prefixed_Name(datex, "NonOrderedLocations") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonOrderedLocationGroupByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of (i.e. more than one) physically separate locations which have no specific order that are defined by reference to a predefined non ordered location group.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonOrderedLocationGroupByReference">http://vocab.datex.org/terms#NonOrderedLocationGroupByReference</seealso>
    let NonOrderedLocationGroupByReference =
        Prefixed_Name(datex, "NonOrderedLocationGroupByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonOrderedLocationGroupByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonOrderedLocationGroupByReferenceExtension">http://vocab.datex.org/terms#nonOrderedLocationGroupByReferenceExtension</seealso>
    let nonOrderedLocationGroupByReferenceExtension =
        Prefixed_Name(datex, "nonOrderedLocationGroupByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedNonOrderedLocationGroupReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned instance of a predefined non ordered location group as specified in a PredefinedLocationsPublication.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupReference">http://vocab.datex.org/terms#predefinedNonOrderedLocationGroupReference</seealso>
    let predefinedNonOrderedLocationGroupReference =
        Prefixed_Name(datex, "predefinedNonOrderedLocationGroupReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PredefinedNonOrderedLocationGroupVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PredefinedNonOrderedLocationGroupVersionedReference">http://vocab.datex.org/terms#_PredefinedNonOrderedLocationGroupVersionedReference</seealso>
    let _PredefinedNonOrderedLocationGroupVersionedReference =
        Prefixed_Name(datex, "_PredefinedNonOrderedLocationGroupVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonOrderedLocationsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonOrderedLocationsExtension">http://vocab.datex.org/terms#nonOrderedLocationsExtension</seealso>
    let nonOrderedLocationsExtension =
        Prefixed_Name(datex, "nonOrderedLocationsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegPointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegPointLocationExtension">http://vocab.datex.org/terms#tpegPointLocationExtension</seealso>
    let tpegPointLocationExtension =
        Prefixed_Name(datex, "tpegPointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegSimplePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is not bounded by any other points on the road network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegSimplePoint">http://vocab.datex.org/terms#TpegSimplePoint</seealso>
    let TpegSimplePoint = Prefixed_Name(datex, "TpegSimplePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegSimplePointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegSimplePointExtension">http://vocab.datex.org/terms#tpegSimplePointExtension</seealso>
    let tpegSimplePointExtension =
        Prefixed_Name(datex, "tpegSimplePointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegSimplePointLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegSimplePointLocationType">http://vocab.datex.org/terms#tpegSimplePointLocationType</seealso>
    let tpegSimplePointLocationType =
        Prefixed_Name(datex, "tpegSimplePointLocationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Averaged measurements or calculations of traffic concentration.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficConcentration">http://vocab.datex.org/terms#TrafficConcentration</seealso>
    let TrafficConcentration =
        Prefixed_Name(datex, "TrafficConcentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement or calculation of the percentage of time that a section of road at the specified measurement site is occupied by vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#occupancy">http://vocab.datex.org/terms#occupancy</seealso>
    let occupancy = Prefixed_Name(datex, "occupancy") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficConcentrationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficConcentrationExtension">http://vocab.datex.org/terms#trafficConcentrationExtension</seealso>
    let trafficConcentrationExtension =
        Prefixed_Name(datex, "trafficConcentrationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficDataExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficDataExtension">http://vocab.datex.org/terms#trafficDataExtension</seealso>
    let trafficDataExtension =
        Prefixed_Name(datex, "trafficDataExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficElementExtension">http://vocab.datex.org/terms#trafficElementExtension</seealso>
    let trafficElementExtension =
        Prefixed_Name(datex, "trafficElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Averaged measurements or calculations of traffic flow rates.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficFlow">http://vocab.datex.org/terms#TrafficFlow</seealso>
    let TrafficFlow = Prefixed_Name(datex, "TrafficFlow") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficFlowExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficFlowExtension">http://vocab.datex.org/terms#trafficFlowExtension</seealso>
    let trafficFlowExtension =
        Prefixed_Name(datex, "trafficFlowExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An averaged measurement of flow rate defined in terms of the number of vehicles passing the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleFlow">http://vocab.datex.org/terms#vehicleFlow</seealso>
    let vehicleFlow = Prefixed_Name(datex, "vehicleFlow") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleFlowValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the flow rate of vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleFlowValue">http://vocab.datex.org/terms#VehicleFlowValue</seealso>
    let VehicleFlowValue = Prefixed_Name(datex, "VehicleFlowValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Averaged measurements or calculations of traffic headway, i.e. the distance or time interval between vehicles. This measure is measured from the head of one vehicle to the head of the following vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficHeadway">http://vocab.datex.org/terms#TrafficHeadway</seealso>
    let TrafficHeadway = Prefixed_Name(datex, "TrafficHeadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:averageDistanceHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The average distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#averageDistanceHeadway">http://vocab.datex.org/terms#averageDistanceHeadway</seealso>
    let averageDistanceHeadway =
        Prefixed_Name(datex, "averageDistanceHeadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:averageTimeHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The average time gap between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle, averaged for all vehicles within a defined measurement period at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#averageTimeHeadway">http://vocab.datex.org/terms#averageTimeHeadway</seealso>
    let averageTimeHeadway = Prefixed_Name(datex, "averageTimeHeadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficHeadwayExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficHeadwayExtension">http://vocab.datex.org/terms#trafficHeadwayExtension</seealso>
    let trafficHeadwayExtension =
        Prefixed_Name(datex, "trafficHeadwayExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceIndex">http://vocab.datex.org/terms#parkingSpaceIndex</seealso>
    let parkingSpaceIndex = Prefixed_Name(datex, "parkingSpaceIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#index">http://vocab.datex.org/terms#index</seealso>
    let index = Prefixed_Name(datex, "index") |> PrefixedName
    /// <summary>
    ///   <para>datex:referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referent">http://vocab.datex.org/terms#referent</seealso>
    let referent = Prefixed_Name(datex, "referent") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrExtendedLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrExtendedLinear">http://vocab.datex.org/terms#openlrExtendedLinear</seealso>
    let openlrExtendedLinear =
        Prefixed_Name(datex, "openlrExtendedLinear") |> PrefixedName

    /// <summary>
    ///   <para>datex:AnprCamerasFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AnprCamerasFault">http://vocab.datex.org/terms#AnprCamerasFault</seealso>
    let AnprCamerasFault = Prefixed_Name(datex, "AnprCamerasFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:AthleticsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AthleticsMeeting">http://vocab.datex.org/terms#AthleticsMeeting</seealso>
    let AthleticsMeeting = Prefixed_Name(datex, "AthleticsMeeting") |> PrefixedName
    /// <summary>
    ///   <para>datex:SlowVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlowVehicle">http://vocab.datex.org/terms#SlowVehicle</seealso>
    let SlowVehicle = Prefixed_Name(datex, "SlowVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:SpeedRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedRestriction">http://vocab.datex.org/terms#SpeedRestriction</seealso>
    let SpeedRestriction = Prefixed_Name(datex, "SpeedRestriction") |> PrefixedName
    /// <summary>
    ///   <para>datex:SprayHazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SprayHazard">http://vocab.datex.org/terms#SprayHazard</seealso>
    let SprayHazard = Prefixed_Name(datex, "SprayHazard") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parking capacity information for the parking site as well as for AssignedParkingSpaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingOccupancy">http://vocab.datex.org/terms#ParkingOccupancy</seealso>
    let ParkingOccupancy = Prefixed_Name(datex, "ParkingOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>datex:injuryStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#injuryStatus">http://vocab.datex.org/terms#injuryStatus</seealso>
    let injuryStatus = Prefixed_Name(datex, "injuryStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:NetworkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of a location on a network (as a point or a linear location).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NetworkLocation">http://vocab.datex.org/terms#NetworkLocation</seealso>
    let NetworkLocation = Prefixed_Name(datex, "NetworkLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:LinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object, consistent with ISO 19148 definitions. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LinearElement">http://vocab.datex.org/terms#LinearElement</seealso>
    let LinearElement = Prefixed_Name(datex, "LinearElement") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadNumber">http://vocab.datex.org/terms#roadNumber</seealso>
    let roadNumber = Prefixed_Name(datex, "roadNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicableForTrafficDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ultimate traffic direction to which the network management is applicable.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableForTrafficDirection">http://vocab.datex.org/terms#applicableForTrafficDirection</seealso>
    let applicableForTrafficDirection =
        Prefixed_Name(datex, "applicableForTrafficDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:weatherRelatedRoadConditionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weatherRelatedRoadConditionsExtension">http://vocab.datex.org/terms#weatherRelatedRoadConditionsExtension</seealso>
    let weatherRelatedRoadConditionsExtension =
        Prefixed_Name(datex, "weatherRelatedRoadConditionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Snowfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Snowfall">http://vocab.datex.org/terms#Snowfall</seealso>
    let Snowfall = Prefixed_Name(datex, "Snowfall") |> PrefixedName
    /// <summary>
    ///   <para>datex:SpeedManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Speed management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedManagement">http://vocab.datex.org/terms#SpeedManagement</seealso>
    let SpeedManagement = Prefixed_Name(datex, "SpeedManagement") |> PrefixedName
    /// <summary>
    ///   <para>datex:SportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SportsMeeting">http://vocab.datex.org/terms#SportsMeeting</seealso>
    let SportsMeeting = Prefixed_Name(datex, "SportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod4Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road between two points, Primary and Secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the Secondary point TO the Primary point, i.e. the Primary point is downstream of the Secondary point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod4Linear">http://vocab.datex.org/terms#AlertCMethod4Linear</seealso>
    let AlertCMethod4Linear =
        Prefixed_Name(datex, "AlertCMethod4Linear") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4LinearExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4LinearExtension">http://vocab.datex.org/terms#alertCMethod4LinearExtension</seealso>
    let alertCMethod4LinearExtension =
        Prefixed_Name(datex, "alertCMethod4LinearExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod4PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod4PrimaryPointLocation">http://vocab.datex.org/terms#AlertCMethod4PrimaryPointLocation</seealso>
    let AlertCMethod4PrimaryPointLocation =
        Prefixed_Name(datex, "AlertCMethod4PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocation">http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocation</seealso>
    let alertCMethod4SecondaryPointLocation =
        Prefixed_Name(datex, "alertCMethod4SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCMethod4SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod4SecondaryPointLocation">http://vocab.datex.org/terms#AlertCMethod4SecondaryPointLocation</seealso>
    let AlertCMethod4SecondaryPointLocation =
        Prefixed_Name(datex, "AlertCMethod4SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentOperationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentOperationStatus">http://vocab.datex.org/terms#equipmentOperationStatus</seealso>
    let equipmentOperationStatus =
        Prefixed_Name(datex, "equipmentOperationStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingStatusColourMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines a pair of 'parkingSiteStatus' and a corresponding colour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingStatusColourMapping">http://vocab.datex.org/terms#ParkingStatusColourMapping</seealso>
    let ParkingStatusColourMapping =
        Prefixed_Name(datex, "ParkingStatusColourMapping") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingStatusPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing the current status of one or more parking sites and/or group of parking sites.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingStatusPublication">http://vocab.datex.org/terms#ParkingStatusPublication</seealso>
    let ParkingStatusPublication =
        Prefixed_Name(datex, "ParkingStatusPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:PredefinedItinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable versioned instance of a predefined itinerary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PredefinedItinerary">http://vocab.datex.org/terms#PredefinedItinerary</seealso>
    let PredefinedItinerary =
        Prefixed_Name(datex, "PredefinedItinerary") |> PrefixedName

    /// <summary>
    ///   <para>datex:generalPublicComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#generalPublicComment">http://vocab.datex.org/terms#generalPublicComment</seealso>
    let generalPublicComment =
        Prefixed_Name(datex, "generalPublicComment") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordCreationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordCreationReference">http://vocab.datex.org/terms#situationRecordCreationReference</seealso>
    let situationRecordCreationReference =
        Prefixed_Name(datex, "situationRecordCreationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordCreationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordCreationTime">http://vocab.datex.org/terms#situationRecordCreationTime</seealso>
    let situationRecordCreationTime =
        Prefixed_Name(datex, "situationRecordCreationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordExtension">http://vocab.datex.org/terms#situationRecordExtension</seealso>
    let situationRecordExtension =
        Prefixed_Name(datex, "situationRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_SituationRecordExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_SituationRecordExtensionType">http://vocab.datex.org/terms#_SituationRecordExtensionType</seealso>
    let _SituationRecordExtensionType =
        Prefixed_Name(datex, "_SituationRecordExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramUrl">http://vocab.datex.org/terms#pictogramUrl</seealso>
    let pictogramUrl = Prefixed_Name(datex, "pictogramUrl") |> PrefixedName

    /// <summary>
    ///   <para>datex:presenceOfRedTriangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#presenceOfRedTriangle">http://vocab.datex.org/terms#presenceOfRedTriangle</seealso>
    let presenceOfRedTriangle =
        Prefixed_Name(datex, "presenceOfRedTriangle") |> PrefixedName

    /// <summary>
    ///   <para>datex:scenarioIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#scenarioIndex">http://vocab.datex.org/terms#scenarioIndex</seealso>
    let scenarioIndex = Prefixed_Name(datex, "scenarioIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:periodExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#periodExtended">http://vocab.datex.org/terms#periodExtended</seealso>
    let periodExtended = Prefixed_Name(datex, "periodExtended") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrExtendedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrExtendedPoint">http://vocab.datex.org/terms#openlrExtendedPoint</seealso>
    let openlrExtendedPoint =
        Prefixed_Name(datex, "openlrExtendedPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointExtended">http://vocab.datex.org/terms#pointExtended</seealso>
    let pointExtended = Prefixed_Name(datex, "pointExtended") |> PrefixedName
    /// <summary>
    ///   <para>datex:AuthorityOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Authority initiated operation or activity that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AuthorityOperation">http://vocab.datex.org/terms#AuthorityOperation</seealso>
    let AuthorityOperation = Prefixed_Name(datex, "AuthorityOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:AutomatedTollSystemFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AutomatedTollSystemFault">http://vocab.datex.org/terms#AutomatedTollSystemFault</seealso>
    let AutomatedTollSystemFault =
        Prefixed_Name(datex, "AutomatedTollSystemFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:BaseballGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BaseballGame">http://vocab.datex.org/terms#BaseballGame</seealso>
    let BaseballGame = Prefixed_Name(datex, "BaseballGame") |> PrefixedName
    /// <summary>
    ///   <para>datex:SwarmsOfInsects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SwarmsOfInsects">http://vocab.datex.org/terms#SwarmsOfInsects</seealso>
    let SwarmsOfInsects = Prefixed_Name(datex, "SwarmsOfInsects") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocation">http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocation</seealso>
    let alertCMethod4PrimaryPointLocation =
        Prefixed_Name(datex, "alertCMethod4PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One type of equipment, that is available on the parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Equipment">http://vocab.datex.org/terms#Equipment</seealso>
    let Equipment = Prefixed_Name(datex, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>datex:equipmentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentExtension">http://vocab.datex.org/terms#equipmentExtension</seealso>
    let equipmentExtension = Prefixed_Name(datex, "equipmentExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:trafficViewRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficViewRecord">http://vocab.datex.org/terms#trafficViewRecord</seealso>
    let trafficViewRecord = Prefixed_Name(datex, "trafficViewRecord") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficViewRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable instance of a single record within a traffic view which shall comprise at most one instance of each of the following: OperatorAction, TrafficElement, ElaboratedData and CCTVImages.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficViewRecord">http://vocab.datex.org/terms#TrafficViewRecord</seealso>
    let TrafficViewRecord = Prefixed_Name(datex, "TrafficViewRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:PredefinedLocationContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A container which may comprise the definition of a predefined itinerary, non ordered group of locations or single location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PredefinedLocationContainer">http://vocab.datex.org/terms#PredefinedLocationContainer</seealso>
    let PredefinedLocationContainer =
        Prefixed_Name(datex, "PredefinedLocationContainer") |> PrefixedName

    /// <summary>
    ///   <para>datex:PredefinedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable versioned instance of a single predefined location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PredefinedLocation">http://vocab.datex.org/terms#PredefinedLocation</seealso>
    let PredefinedLocation = Prefixed_Name(datex, "PredefinedLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:BadWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BadWeather">http://vocab.datex.org/terms#BadWeather</seealso>
    let BadWeather = Prefixed_Name(datex, "BadWeather") |> PrefixedName
    /// <summary>
    ///   <para>datex:Blizzard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Blizzard">http://vocab.datex.org/terms#Blizzard</seealso>
    let Blizzard = Prefixed_Name(datex, "Blizzard") |> PrefixedName
    /// <summary>
    ///   <para>datex:BlockadeOrBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BlockadeOrBarrier">http://vocab.datex.org/terms#BlockadeOrBarrier</seealso>
    let BlockadeOrBarrier = Prefixed_Name(datex, "BlockadeOrBarrier") |> PrefixedName
    /// <summary>
    ///   <para>datex:BoatRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BoatRace">http://vocab.datex.org/terms#BoatRace</seealso>
    let BoatRace = Prefixed_Name(datex, "BoatRace") |> PrefixedName

    /// <summary>
    ///   <para>datex:BrokenDownHeavyLorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BrokenDownHeavyLorry">http://vocab.datex.org/terms#BrokenDownHeavyLorry</seealso>
    let BrokenDownHeavyLorry =
        Prefixed_Name(datex, "BrokenDownHeavyLorry") |> PrefixedName

    /// <summary>
    ///   <para>datex:BurstPipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BurstPipe">http://vocab.datex.org/terms#BurstPipe</seealso>
    let BurstPipe = Prefixed_Name(datex, "BurstPipe") |> PrefixedName
    /// <summary>
    ///   <para>datex:CctvCamerasFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CctvCamerasFailure">http://vocab.datex.org/terms#CctvCamerasFailure</seealso>
    let CctvCamerasFailure = Prefixed_Name(datex, "CctvCamerasFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:ChemicalSpillageAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ChemicalSpillageAccident">http://vocab.datex.org/terms#ChemicalSpillageAccident</seealso>
    let ChemicalSpillageAccident =
        Prefixed_Name(datex, "ChemicalSpillageAccident") |> PrefixedName

    /// <summary>
    ///   <para>datex:ClosedPermanentlyForTheWinter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ClosedPermanentlyForTheWinter">http://vocab.datex.org/terms#ClosedPermanentlyForTheWinter</seealso>
    let ClosedPermanentlyForTheWinter =
        Prefixed_Name(datex, "ClosedPermanentlyForTheWinter") |> PrefixedName

    /// <summary>
    ///   <para>datex:CollisionWithAnimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CollisionWithAnimal">http://vocab.datex.org/terms#CollisionWithAnimal</seealso>
    let CollisionWithAnimal =
        Prefixed_Name(datex, "CollisionWithAnimal") |> PrefixedName

    /// <summary>
    ///   <para>datex:CommercialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CommercialEvent">http://vocab.datex.org/terms#CommercialEvent</seealso>
    let CommercialEvent = Prefixed_Name(datex, "CommercialEvent") |> PrefixedName
    /// <summary>
    ///   <para>datex:ConstructionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ConstructionWork">http://vocab.datex.org/terms#ConstructionWork</seealso>
    let ConstructionWork = Prefixed_Name(datex, "ConstructionWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:CricketMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CricketMatch">http://vocab.datex.org/terms#CricketMatch</seealso>
    let CricketMatch = Prefixed_Name(datex, "CricketMatch") |> PrefixedName
    /// <summary>
    ///   <para>datex:Crosswinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Crosswinds">http://vocab.datex.org/terms#Crosswinds</seealso>
    let Crosswinds = Prefixed_Name(datex, "Crosswinds") |> PrefixedName

    /// <summary>
    ///   <para>datex:DamagedCrashBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedCrashBarrier">http://vocab.datex.org/terms#DamagedCrashBarrier</seealso>
    let DamagedCrashBarrier =
        Prefixed_Name(datex, "DamagedCrashBarrier") |> PrefixedName

    /// <summary>
    ///   <para>datex:DamagedFlyover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedFlyover">http://vocab.datex.org/terms#DamagedFlyover</seealso>
    let DamagedFlyover = Prefixed_Name(datex, "DamagedFlyover") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedVehicle">http://vocab.datex.org/terms#DamagedVehicle</seealso>
    let DamagedVehicle = Prefixed_Name(datex, "DamagedVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedViaduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedViaduct">http://vocab.datex.org/terms#DamagedViaduct</seealso>
    let DamagedViaduct = Prefixed_Name(datex, "DamagedViaduct") |> PrefixedName
    /// <summary>
    ///   <para>datex:DeepSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DeepSnow">http://vocab.datex.org/terms#DeepSnow</seealso>
    let DeepSnow = Prefixed_Name(datex, "DeepSnow") |> PrefixedName
    /// <summary>
    ///   <para>datex:DemolitionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DemolitionWork">http://vocab.datex.org/terms#DemolitionWork</seealso>
    let DemolitionWork = Prefixed_Name(datex, "DemolitionWork") |> PrefixedName

    /// <summary>
    ///   <para>datex:DisturbanceActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DisturbanceActivity">http://vocab.datex.org/terms#DisturbanceActivity</seealso>
    let DisturbanceActivity =
        Prefixed_Name(datex, "DisturbanceActivity") |> PrefixedName

    /// <summary>
    ///   <para>datex:DrivingCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DrivingCondition">http://vocab.datex.org/terms#DrivingCondition</seealso>
    let DrivingCondition = Prefixed_Name(datex, "DrivingCondition") |> PrefixedName
    /// <summary>
    ///   <para>datex:Eclipse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Eclipse">http://vocab.datex.org/terms#Eclipse</seealso>
    let Eclipse = Prefixed_Name(datex, "Eclipse") |> PrefixedName

    /// <summary>
    ///   <para>datex:EmergencyRoadsideTelephoneFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFailure">http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFailure</seealso>
    let EmergencyRoadsideTelephoneFailure =
        Prefixed_Name(datex, "EmergencyRoadsideTelephoneFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:Evacuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Evacuation">http://vocab.datex.org/terms#Evacuation</seealso>
    let Evacuation = Prefixed_Name(datex, "Evacuation") |> PrefixedName
    /// <summary>
    ///   <para>datex:Exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Exhibition">http://vocab.datex.org/terms#Exhibition</seealso>
    let Exhibition = Prefixed_Name(datex, "Exhibition") |> PrefixedName
    /// <summary>
    ///   <para>datex:FallenPowerCables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FallenPowerCables">http://vocab.datex.org/terms#FallenPowerCables</seealso>
    let FallenPowerCables = Prefixed_Name(datex, "FallenPowerCables") |> PrefixedName
    /// <summary>
    ///   <para>datex:FallenTrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FallenTrees">http://vocab.datex.org/terms#FallenTrees</seealso>
    let FallenTrees = Prefixed_Name(datex, "FallenTrees") |> PrefixedName
    /// <summary>
    ///   <para>datex:Festival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Festival">http://vocab.datex.org/terms#Festival</seealso>
    let Festival = Prefixed_Name(datex, "Festival") |> PrefixedName
    /// <summary>
    ///   <para>datex:FilmTVMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FilmTVMaking">http://vocab.datex.org/terms#FilmTVMaking</seealso>
    let FilmTVMaking = Prefixed_Name(datex, "FilmTVMaking") |> PrefixedName
    /// <summary>
    ///   <para>datex:FilterBlockade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FilterBlockade">http://vocab.datex.org/terms#FilterBlockade</seealso>
    let FilterBlockade = Prefixed_Name(datex, "FilterBlockade") |> PrefixedName
    /// <summary>
    ///   <para>datex:FirstAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FirstAid">http://vocab.datex.org/terms#FirstAid</seealso>
    let FirstAid = Prefixed_Name(datex, "FirstAid") |> PrefixedName
    /// <summary>
    ///   <para>datex:FootballMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FootballMatch">http://vocab.datex.org/terms#FootballMatch</seealso>
    let FootballMatch = Prefixed_Name(datex, "FootballMatch") |> PrefixedName
    /// <summary>
    ///   <para>datex:ForestFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ForestFire">http://vocab.datex.org/terms#ForestFire</seealso>
    let ForestFire = Prefixed_Name(datex, "ForestFire") |> PrefixedName
    /// <summary>
    ///   <para>datex:FreezingFog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FreezingFog">http://vocab.datex.org/terms#FreezingFog</seealso>
    let FreezingFog = Prefixed_Name(datex, "FreezingFog") |> PrefixedName

    /// <summary>
    ///   <para>datex:FreezingOfWetInfrastructureSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FreezingOfWetInfrastructureSurface">http://vocab.datex.org/terms#FreezingOfWetInfrastructureSurface</seealso>
    let FreezingOfWetInfrastructureSurface =
        Prefixed_Name(datex, "FreezingOfWetInfrastructureSurface") |> PrefixedName

    /// <summary>
    ///   <para>datex:Frost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Frost">http://vocab.datex.org/terms#Frost</seealso>
    let Frost = Prefixed_Name(datex, "Frost") |> PrefixedName

    /// <summary>
    ///   <para>datex:FuelSpillageAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FuelSpillageAccident">http://vocab.datex.org/terms#FuelSpillageAccident</seealso>
    let FuelSpillageAccident =
        Prefixed_Name(datex, "FuelSpillageAccident") |> PrefixedName

    /// <summary>
    ///   <para>datex:Funfair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Funfair">http://vocab.datex.org/terms#Funfair</seealso>
    let Funfair = Prefixed_Name(datex, "Funfair") |> PrefixedName
    /// <summary>
    ///   <para>datex:Gales</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Gales">http://vocab.datex.org/terms#Gales</seealso>
    let Gales = Prefixed_Name(datex, "Gales") |> PrefixedName
    /// <summary>
    ///   <para>datex:GoSlowOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GoSlowOperation">http://vocab.datex.org/terms#GoSlowOperation</seealso>
    let GoSlowOperation = Prefixed_Name(datex, "GoSlowOperation") |> PrefixedName
    /// <summary>
    ///   <para>datex:GolfTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GolfTournament">http://vocab.datex.org/terms#GolfTournament</seealso>
    let GolfTournament = Prefixed_Name(datex, "GolfTournament") |> PrefixedName
    /// <summary>
    ///   <para>datex:GrassCuttingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GrassCuttingWork">http://vocab.datex.org/terms#GrassCuttingWork</seealso>
    let GrassCuttingWork = Prefixed_Name(datex, "GrassCuttingWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:GrassFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GrassFire">http://vocab.datex.org/terms#GrassFire</seealso>
    let GrassFire = Prefixed_Name(datex, "GrassFire") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeavyFrost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeavyFrost">http://vocab.datex.org/terms#HeavyFrost</seealso>
    let HeavyFrost = Prefixed_Name(datex, "HeavyFrost") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeavyRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeavyRain">http://vocab.datex.org/terms#HeavyRain</seealso>
    let HeavyRain = Prefixed_Name(datex, "HeavyRain") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeavySnowfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeavySnowfall">http://vocab.datex.org/terms#HeavySnowfall</seealso>
    let HeavySnowfall = Prefixed_Name(datex, "HeavySnowfall") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeavyTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeavyTraffic">http://vocab.datex.org/terms#HeavyTraffic</seealso>
    let HeavyTraffic = Prefixed_Name(datex, "HeavyTraffic") |> PrefixedName
    /// <summary>
    ///   <para>datex:Ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Ice">http://vocab.datex.org/terms#Ice</seealso>
    let Ice = Prefixed_Name(datex, "Ice") |> PrefixedName
    /// <summary>
    ///   <para>datex:IceBuildUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IceBuildUp">http://vocab.datex.org/terms#IceBuildUp</seealso>
    let IceBuildUp = Prefixed_Name(datex, "IceBuildUp") |> PrefixedName

    /// <summary>
    ///   <para>datex:IceWithWheelBarTracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IceWithWheelBarTracks">http://vocab.datex.org/terms#IceWithWheelBarTracks</seealso>
    let IceWithWheelBarTracks =
        Prefixed_Name(datex, "IceWithWheelBarTracks") |> PrefixedName

    /// <summary>
    ///   <para>datex:IcyPatches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IcyPatches">http://vocab.datex.org/terms#IcyPatches</seealso>
    let IcyPatches = Prefixed_Name(datex, "IcyPatches") |> PrefixedName
    /// <summary>
    ///   <para>datex:grossVehicleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#grossVehicleWeight">http://vocab.datex.org/terms#grossVehicleWeight</seealso>
    let grossVehicleWeight = Prefixed_Name(datex, "grossVehicleWeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:grossWeightCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#grossWeightCharacteristicExtension">http://vocab.datex.org/terms#grossWeightCharacteristicExtension</seealso>
    let grossWeightCharacteristicExtension =
        Prefixed_Name(datex, "grossWeightCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:KilogramsConcentrationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of concentration of a substance in grams per unit volume.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#KilogramsConcentrationValue">http://vocab.datex.org/terms#KilogramsConcentrationValue</seealso>
    let KilogramsConcentrationValue =
        Prefixed_Name(datex, "KilogramsConcentrationValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:kilogramsConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value defining the amount of a substance in a given volume (concentration) expressed in kilograms per cubic metre.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#kilogramsConcentration">http://vocab.datex.org/terms#kilogramsConcentration</seealso>
    let kilogramsConcentration =
        Prefixed_Name(datex, "kilogramsConcentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:kilogramsConcentrationValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#kilogramsConcentrationValueExtension">http://vocab.datex.org/terms#kilogramsConcentrationValueExtension</seealso>
    let kilogramsConcentrationValueExtension =
        Prefixed_Name(datex, "kilogramsConcentrationValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLocationReferencePointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLocationReferencePointExtension">http://vocab.datex.org/terms#openlrLocationReferencePointExtension</seealso>
    let openlrLocationReferencePointExtension =
        Prefixed_Name(datex, "openlrLocationReferencePointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromPrimaryRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromPrimaryRoad">http://vocab.datex.org/terms#distanceFromPrimaryRoad</seealso>
    let distanceFromPrimaryRoad =
        Prefixed_Name(datex, "distanceFromPrimaryRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility">http://vocab.datex.org/terms#_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility</seealso>
    let _ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility =
        Prefixed_Name(datex, "_ParkingSpaceBasicsEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingFloorOrLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingFloorOrLevel">http://vocab.datex.org/terms#parkingFloorOrLevel</seealso>
    let parkingFloorOrLevel =
        Prefixed_Name(datex, "parkingFloorOrLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingMode">http://vocab.datex.org/terms#parkingMode</seealso>
    let parkingMode = Prefixed_Name(datex, "parkingMode") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSecurity">http://vocab.datex.org/terms#parkingSecurity</seealso>
    let parkingSecurity = Prefixed_Name(datex, "parkingSecurity") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpacePhysics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpacePhysics">http://vocab.datex.org/terms#parkingSpacePhysics</seealso>
    let parkingSpacePhysics =
        Prefixed_Name(datex, "parkingSpacePhysics") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingSpaceBasicsScenarioIndexParkingUsageScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingSpaceBasicsScenarioIndexParkingUsageScenario">http://vocab.datex.org/terms#_ParkingSpaceBasicsScenarioIndexParkingUsageScenario</seealso>
    let _ParkingSpaceBasicsScenarioIndexParkingUsageScenario =
        Prefixed_Name(datex, "_ParkingSpaceBasicsScenarioIndexParkingUsageScenario") |> PrefixedName

    /// <summary>
    ///   <para>datex:PollutionInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of atmospheric pollution.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PollutionInformation">http://vocab.datex.org/terms#PollutionInformation</seealso>
    let PollutionInformation =
        Prefixed_Name(datex, "PollutionInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:pollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pollution">http://vocab.datex.org/terms#pollution</seealso>
    let pollution = Prefixed_Name(datex, "pollution") |> PrefixedName

    /// <summary>
    ///   <para>datex:pollutionInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pollutionInformationExtension">http://vocab.datex.org/terms#pollutionInformationExtension</seealso>
    let pollutionInformationExtension =
        Prefixed_Name(datex, "pollutionInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadworksScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of the scale of the roadworks in terms of the traffic disruption they are likely to cause.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadworksScale">http://vocab.datex.org/terms#roadworksScale</seealso>
    let roadworksScale = Prefixed_Name(datex, "roadworksScale") |> PrefixedName
    /// <summary>
    ///   <para>datex:subjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subjects">http://vocab.datex.org/terms#subjects</seealso>
    let subjects = Prefixed_Name(datex, "subjects") |> PrefixedName
    /// <summary>
    ///   <para>datex:Subjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subjects with which the roadworks are associated.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Subjects">http://vocab.datex.org/terms#Subjects</seealso>
    let Subjects = Prefixed_Name(datex, "Subjects") |> PrefixedName
    /// <summary>
    ///   <para>datex:underTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#underTraffic">http://vocab.datex.org/terms#underTraffic</seealso>
    let underTraffic = Prefixed_Name(datex, "underTraffic") |> PrefixedName
    /// <summary>
    ///   <para>datex:urgentRoadworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urgentRoadworks">http://vocab.datex.org/terms#urgentRoadworks</seealso>
    let urgentRoadworks = Prefixed_Name(datex, "urgentRoadworks") |> PrefixedName
    /// <summary>
    ///   <para>datex:ServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One type of service facility that is available on the parking site or located next to it. You can specify the number of this service facility type (e.g. 5 restaurants) as well as the number of subitems (e.g. 200 restaurant places).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ServiceFacility">http://vocab.datex.org/terms#ServiceFacility</seealso>
    let ServiceFacility = Prefixed_Name(datex, "ServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromParkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>If the service facility is not located on the parking site itself, its distance can be specified here in metres.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromParkingSite">http://vocab.datex.org/terms#distanceFromParkingSite</seealso>
    let distanceFromParkingSite =
        Prefixed_Name(datex, "distanceFromParkingSite") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfSubitems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The quantity of sub items to this service facility type, e.g. the total number of restaurant places or fuel dispensers etc.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfSubitems">http://vocab.datex.org/terms#numberOfSubitems</seealso>
    let numberOfSubitems = Prefixed_Name(datex, "numberOfSubitems") |> PrefixedName

    /// <summary>
    ///   <para>datex:serviceFacilityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#serviceFacilityExtension">http://vocab.datex.org/terms#serviceFacilityExtension</seealso>
    let serviceFacilityExtension =
        Prefixed_Name(datex, "serviceFacilityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:serviceFacilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>One type of service, that is available on the parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#serviceFacilityType">http://vocab.datex.org/terms#serviceFacilityType</seealso>
    let serviceFacilityType =
        Prefixed_Name(datex, "serviceFacilityType") |> PrefixedName

    /// <summary>
    ///   <para>datex:SignSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides information on message signs and the information currently displayed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SignSetting">http://vocab.datex.org/terms#SignSetting</seealso>
    let SignSetting = Prefixed_Name(datex, "SignSetting") |> PrefixedName

    /// <summary>
    ///   <para>datex:signSettingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#signSettingExtension">http://vocab.datex.org/terms#signSettingExtension</seealso>
    let signSettingExtension =
        Prefixed_Name(datex, "signSettingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSetting">http://vocab.datex.org/terms#vmsSetting</seealso>
    let vmsSetting = Prefixed_Name(datex, "vmsSetting") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides information on variable message signs and the information currently displayed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsSetting">http://vocab.datex.org/terms#VmsSetting</seealso>
    let VmsSetting = Prefixed_Name(datex, "VmsSetting") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsDynamicCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsDynamicCharacteristicsExtension">http://vocab.datex.org/terms#vmsDynamicCharacteristicsExtension</seealso>
    let vmsDynamicCharacteristicsExtension =
        Prefixed_Name(datex, "vmsDynamicCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogramDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristics">http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristics</seealso>
    let vmsPictogramDisplayCharacteristics =
        Prefixed_Name(datex, "vmsPictogramDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics">http://vocab.datex.org/terms#_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics</seealso>
    let _VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics =
        Prefixed_Name(datex, "_VmsDynamicCharacteristicsPictogramDisplayAreaIndexVmsPictogramDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristics">http://vocab.datex.org/terms#vmsTextDisplayCharacteristics</seealso>
    let vmsTextDisplayCharacteristics =
        Prefixed_Name(datex, "vmsTextDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsTextDisplayCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Characteristics specific to the textual display area on the VMS.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsTextDisplayCharacteristics">http://vocab.datex.org/terms#VmsTextDisplayCharacteristics</seealso>
    let VmsTextDisplayCharacteristics =
        Prefixed_Name(datex, "VmsTextDisplayCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsFaultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsFaultExtension">http://vocab.datex.org/terms#vmsFaultExtension</seealso>
    let vmsFaultExtension = Prefixed_Name(datex, "vmsFaultExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromLogicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromLogicalLocation">http://vocab.datex.org/terms#distanceFromLogicalLocation</seealso>
    let distanceFromLogicalLocation =
        Prefixed_Name(datex, "distanceFromLogicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A message displayed on a VMS which may comprise one or more sequentially displayed text pages and/or pictograms with supplementary details. When in a sequence of displayed messages sequencing of text pages and pictograms within a message are prohibited.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsMessage">http://vocab.datex.org/terms#VmsMessage</seealso>
    let VmsMessage = Prefixed_Name(datex, "VmsMessage") |> PrefixedName

    /// <summary>
    ///   <para>datex:associatedManagementOrDiversionPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#associatedManagementOrDiversionPlan">http://vocab.datex.org/terms#associatedManagementOrDiversionPlan</seealso>
    let associatedManagementOrDiversionPlan =
        Prefixed_Name(datex, "associatedManagementOrDiversionPlan") |> PrefixedName

    /// <summary>
    ///   <para>datex:codedReasonForSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#codedReasonForSetting">http://vocab.datex.org/terms#codedReasonForSetting</seealso>
    let codedReasonForSetting =
        Prefixed_Name(datex, "codedReasonForSetting") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromSituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromSituationRecord">http://vocab.datex.org/terms#distanceFromSituationRecord</seealso>
    let distanceFromSituationRecord =
        Prefixed_Name(datex, "distanceFromSituationRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:mareNostrumCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mareNostrumCompliant">http://vocab.datex.org/terms#mareNostrumCompliant</seealso>
    let mareNostrumCompliant =
        Prefixed_Name(datex, "mareNostrumCompliant") |> PrefixedName

    /// <summary>
    ///   <para>datex:messageSetBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#messageSetBy">http://vocab.datex.org/terms#messageSetBy</seealso>
    let messageSetBy = Prefixed_Name(datex, "messageSetBy") |> PrefixedName
    /// <summary>
    ///   <para>datex:primarySetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#primarySetting">http://vocab.datex.org/terms#primarySetting</seealso>
    let primarySetting = Prefixed_Name(datex, "primarySetting") |> PrefixedName
    /// <summary>
    ///   <para>datex:reasonForSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reasonForSetting">http://vocab.datex.org/terms#reasonForSetting</seealso>
    let reasonForSetting = Prefixed_Name(datex, "reasonForSetting") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPictogramSequencingInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPictogramSequencingInterval">http://vocab.datex.org/terms#textPictogramSequencingInterval</seealso>
    let textPictogramSequencingInterval =
        Prefixed_Name(datex, "textPictogramSequencingInterval") |> PrefixedName

    /// <summary>
    ///   <para>datex:timeLastSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timeLastSet">http://vocab.datex.org/terms#timeLastSet</seealso>
    let timeLastSet = Prefixed_Name(datex, "timeLastSet") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsMessageExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsMessageExtension">http://vocab.datex.org/terms#vmsMessageExtension</seealso>
    let vmsMessageExtension =
        Prefixed_Name(datex, "vmsMessageExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsMessageInformationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsMessageInformationType">http://vocab.datex.org/terms#vmsMessageInformationType</seealso>
    let vmsMessageInformationType =
        Prefixed_Name(datex, "vmsMessageInformationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogramDisplayArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogramDisplayArea">http://vocab.datex.org/terms#vmsPictogramDisplayArea</seealso>
    let vmsPictogramDisplayArea =
        Prefixed_Name(datex, "vmsPictogramDisplayArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea">http://vocab.datex.org/terms#_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea</seealso>
    let _VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea =
        Prefixed_Name(datex, "_VmsMessagePictogramDisplayAreaIndexVmsPictogramDisplayArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A main pictogram displayable on the VMS panel. Note a main pictogram may have an associated supplementary panel which may itself contain a further pictogram and line of text.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsPictogram">http://vocab.datex.org/terms#VmsPictogram</seealso>
    let VmsPictogram = Prefixed_Name(datex, "VmsPictogram") |> PrefixedName

    /// <summary>
    ///   <para>datex:additionalPictogramDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#additionalPictogramDescription">http://vocab.datex.org/terms#additionalPictogramDescription</seealso>
    let additionalPictogramDescription =
        Prefixed_Name(datex, "additionalPictogramDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceAttribute">http://vocab.datex.org/terms#distanceAttribute</seealso>
    let distanceAttribute = Prefixed_Name(datex, "distanceAttribute") |> PrefixedName
    /// <summary>
    ///   <para>datex:heightAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightAttribute">http://vocab.datex.org/terms#heightAttribute</seealso>
    let heightAttribute = Prefixed_Name(datex, "heightAttribute") |> PrefixedName
    /// <summary>
    ///   <para>datex:lengthAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lengthAttribute">http://vocab.datex.org/terms#lengthAttribute</seealso>
    let lengthAttribute = Prefixed_Name(datex, "lengthAttribute") |> PrefixedName
    /// <summary>
    ///   <para>datex:pictogramCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramCode">http://vocab.datex.org/terms#pictogramCode</seealso>
    let pictogramCode = Prefixed_Name(datex, "pictogramCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDescription">http://vocab.datex.org/terms#pictogramDescription</seealso>
    let pictogramDescription =
        Prefixed_Name(datex, "pictogramDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramFlashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramFlashing">http://vocab.datex.org/terms#pictogramFlashing</seealso>
    let pictogramFlashing = Prefixed_Name(datex, "pictogramFlashing") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramInInverseColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramInInverseColour">http://vocab.datex.org/terms#pictogramInInverseColour</seealso>
    let pictogramInInverseColour =
        Prefixed_Name(datex, "pictogramInInverseColour") |> PrefixedName

    /// <summary>
    ///   <para>datex:speedAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedAttribute">http://vocab.datex.org/terms#speedAttribute</seealso>
    let speedAttribute = Prefixed_Name(datex, "speedAttribute") |> PrefixedName

    /// <summary>
    ///   <para>datex:viennaConventionCompliant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#viennaConventionCompliant">http://vocab.datex.org/terms#viennaConventionCompliant</seealso>
    let viennaConventionCompliant =
        Prefixed_Name(datex, "viennaConventionCompliant") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogramExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogramExtension">http://vocab.datex.org/terms#vmsPictogramExtension</seealso>
    let vmsPictogramExtension =
        Prefixed_Name(datex, "vmsPictogramExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPanel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPanel">http://vocab.datex.org/terms#vmsSupplementaryPanel</seealso>
    let vmsSupplementaryPanel =
        Prefixed_Name(datex, "vmsSupplementaryPanel") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsSupplementaryPanel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A panel which may display information or a regulatory instruction which is supplemental to the associated pictogram, comprising either an additional line of text or a pictogram or both.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsSupplementaryPanel">http://vocab.datex.org/terms#VmsSupplementaryPanel</seealso>
    let VmsSupplementaryPanel =
        Prefixed_Name(datex, "VmsSupplementaryPanel") |> PrefixedName

    /// <summary>
    ///   <para>datex:weightAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weightAttribute">http://vocab.datex.org/terms#weightAttribute</seealso>
    let weightAttribute = Prefixed_Name(datex, "weightAttribute") |> PrefixedName

    /// <summary>
    ///   <para>datex:weightPerAxleAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weightPerAxleAttribute">http://vocab.datex.org/terms#weightPerAxleAttribute</seealso>
    let weightPerAxleAttribute =
        Prefixed_Name(datex, "weightPerAxleAttribute") |> PrefixedName

    /// <summary>
    ///   <para>datex:widthAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#widthAttribute">http://vocab.datex.org/terms#widthAttribute</seealso>
    let widthAttribute = Prefixed_Name(datex, "widthAttribute") |> PrefixedName
    /// <summary>
    ///   <para>datex:BasketballGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BasketballGame">http://vocab.datex.org/terms#BasketballGame</seealso>
    let BasketballGame = Prefixed_Name(datex, "BasketballGame") |> PrefixedName

    /// <summary>
    ///   <para>datex:TidalFlowLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TidalFlowLaneInOperation">http://vocab.datex.org/terms#TidalFlowLaneInOperation</seealso>
    let TidalFlowLaneInOperation =
        Prefixed_Name(datex, "TidalFlowLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:TollGatesFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TollGatesFault">http://vocab.datex.org/terms#TollGatesFault</seealso>
    let TollGatesFault = Prefixed_Name(datex, "TollGatesFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:Tornadoes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Tornadoes">http://vocab.datex.org/terms#Tornadoes</seealso>
    let Tornadoes = Prefixed_Name(datex, "Tornadoes") |> PrefixedName
    /// <summary>
    ///   <para>datex:TransportOfVip</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TransportOfVip">http://vocab.datex.org/terms#TransportOfVip</seealso>
    let TransportOfVip = Prefixed_Name(datex, "TransportOfVip") |> PrefixedName
    /// <summary>
    ///   <para>datex:TunnelLightFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TunnelLightFailure">http://vocab.datex.org/terms#TunnelLightFailure</seealso>
    let TunnelLightFailure = Prefixed_Name(datex, "TunnelLightFailure") |> PrefixedName
    /// <summary>
    ///   <para>datex:TunnelLightFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TunnelLightFault">http://vocab.datex.org/terms#TunnelLightFault</seealso>
    let TunnelLightFault = Prefixed_Name(datex, "TunnelLightFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:UndefinedAuthorityActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UndefinedAuthorityActivity">http://vocab.datex.org/terms#UndefinedAuthorityActivity</seealso>
    let UndefinedAuthorityActivity =
        Prefixed_Name(datex, "UndefinedAuthorityActivity") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleInspectionCheckPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleInspectionCheckPoint">http://vocab.datex.org/terms#VehicleInspectionCheckPoint</seealso>
    let VehicleInspectionCheckPoint =
        Prefixed_Name(datex, "VehicleInspectionCheckPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleOffRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleOffRoad">http://vocab.datex.org/terms#VehicleOffRoad</seealso>
    let VehicleOffRoad = Prefixed_Name(datex, "VehicleOffRoad") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleRecovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleRecovery">http://vocab.datex.org/terms#VehicleRecovery</seealso>
    let VehicleRecovery = Prefixed_Name(datex, "VehicleRecovery") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4PrimaryPointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocationExtension">http://vocab.datex.org/terms#alertCMethod4PrimaryPointLocationExtension</seealso>
    let alertCMethod4PrimaryPointLocationExtension =
        Prefixed_Name(datex, "alertCMethod4PrimaryPointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:offsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#offsetDistance">http://vocab.datex.org/terms#offsetDistance</seealso>
    let offsetDistance = Prefixed_Name(datex, "offsetDistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:offsetDistanceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#offsetDistanceExtension">http://vocab.datex.org/terms#offsetDistanceExtension</seealso>
    let offsetDistanceExtension =
        Prefixed_Name(datex, "offsetDistanceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:lastUpdated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lastUpdated">http://vocab.datex.org/terms#lastUpdated</seealso>
    let lastUpdated = Prefixed_Name(datex, "lastUpdated") |> PrefixedName

    /// <summary>
    ///   <para>datex:openingTimesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openingTimesExtension">http://vocab.datex.org/terms#openingTimesExtension</seealso>
    let openingTimesExtension =
        Prefixed_Name(datex, "openingTimesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openingTimesNotSpecified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openingTimesNotSpecified">http://vocab.datex.org/terms#openingTimesNotSpecified</seealso>
    let openingTimesNotSpecified =
        Prefixed_Name(datex, "openingTimesNotSpecified") |> PrefixedName

    /// <summary>
    ///   <para>datex:openingTimesUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openingTimesUnknown">http://vocab.datex.org/terms#openingTimesUnknown</seealso>
    let openingTimesUnknown =
        Prefixed_Name(datex, "openingTimesUnknown") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrAreaLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represente according to the OpenLR standard for Area Locations</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrAreaLocationReference">http://vocab.datex.org/terms#OpenlrAreaLocationReference</seealso>
    let OpenlrAreaLocationReference =
        Prefixed_Name(datex, "OpenlrAreaLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrAreaLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrAreaLocationReferenceExtension">http://vocab.datex.org/terms#openlrAreaLocationReferenceExtension</seealso>
    let openlrAreaLocationReferenceExtension =
        Prefixed_Name(datex, "openlrAreaLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingUsageScenarioStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current status for this parking usage scenario.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingUsageScenarioStatus">http://vocab.datex.org/terms#ParkingUsageScenarioStatus</seealso>
    let ParkingUsageScenarioStatus =
        Prefixed_Name(datex, "ParkingUsageScenarioStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingUsageScenarioStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingUsageScenarioStatusExtension">http://vocab.datex.org/terms#parkingUsageScenarioStatusExtension</seealso>
    let parkingUsageScenarioStatusExtension =
        Prefixed_Name(datex, "parkingUsageScenarioStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:UrbanParkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parking site in an urban context.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UrbanParkingSite">http://vocab.datex.org/terms#UrbanParkingSite</seealso>
    let UrbanParkingSite = Prefixed_Name(datex, "UrbanParkingSite") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sub-record in the VMS Unit table defining the characteristics of a single variable message sign that is controlled by a specific VMS unit. Locations are on or adjacent to the road network but may be updated over time if relating to a mobile VMS unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsRecord">http://vocab.datex.org/terms#VmsRecord</seealso>
    let VmsRecord = Prefixed_Name(datex, "VmsRecord") |> PrefixedName
    /// <summary>
    ///   <para>datex:backgroundImageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#backgroundImageUrl">http://vocab.datex.org/terms#backgroundImageUrl</seealso>
    let backgroundImageUrl = Prefixed_Name(datex, "backgroundImageUrl") |> PrefixedName

    /// <summary>
    ///   <para>datex:dynamicallyConfigurableDisplayAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dynamicallyConfigurableDisplayAreas">http://vocab.datex.org/terms#dynamicallyConfigurableDisplayAreas</seealso>
    let dynamicallyConfigurableDisplayAreas =
        Prefixed_Name(datex, "dynamicallyConfigurableDisplayAreas") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordExtendedApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordExtendedApproved">http://vocab.datex.org/terms#situationRecordExtendedApproved</seealso>
    let situationRecordExtendedApproved =
        Prefixed_Name(datex, "situationRecordExtendedApproved") |> PrefixedName

    /// <summary>
    ///   <para>datex:pageNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pageNumber">http://vocab.datex.org/terms#pageNumber</seealso>
    let pageNumber = Prefixed_Name(datex, "pageNumber") |> PrefixedName
    /// <summary>
    ///   <para>datex:BombSquadInAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BombSquadInAction">http://vocab.datex.org/terms#BombSquadInAction</seealso>
    let BombSquadInAction = Prefixed_Name(datex, "BombSquadInAction") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleOnFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleOnFire">http://vocab.datex.org/terms#VehicleOnFire</seealso>
    let VehicleOnFire = Prefixed_Name(datex, "VehicleOnFire") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleSpunAround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleSpunAround">http://vocab.datex.org/terms#VehicleSpunAround</seealso>
    let VehicleSpunAround = Prefixed_Name(datex, "VehicleSpunAround") |> PrefixedName
    /// <summary>
    ///   <para>datex:VisibilityReduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VisibilityReduced">http://vocab.datex.org/terms#VisibilityReduced</seealso>
    let VisibilityReduced = Prefixed_Name(datex, "VisibilityReduced") |> PrefixedName
    /// <summary>
    ///   <para>datex:WeakBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeakBridge">http://vocab.datex.org/terms#WeakBridge</seealso>
    let WeakBridge = Prefixed_Name(datex, "WeakBridge") |> PrefixedName

    /// <summary>
    ///   <para>datex:WeatherRelatedConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeatherRelatedConditions">http://vocab.datex.org/terms#WeatherRelatedConditions</seealso>
    let WeatherRelatedConditions =
        Prefixed_Name(datex, "WeatherRelatedConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:WeightRestrictionInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeightRestrictionInOperation">http://vocab.datex.org/terms#WeightRestrictionInOperation</seealso>
    let WeightRestrictionInOperation =
        Prefixed_Name(datex, "WeightRestrictionInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:WetAndIcyRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WetAndIcyRoad">http://vocab.datex.org/terms#WetAndIcyRoad</seealso>
    let WetAndIcyRoad = Prefixed_Name(datex, "WetAndIcyRoad") |> PrefixedName
    /// <summary>
    ///   <para>datex:keepAlive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#keepAlive">http://vocab.datex.org/terms#keepAlive</seealso>
    let keepAlive = Prefixed_Name(datex, "keepAlive") |> PrefixedName
    /// <summary>
    ///   <para>datex:requestType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#requestType">http://vocab.datex.org/terms#requestType</seealso>
    let requestType = Prefixed_Name(datex, "requestType") |> PrefixedName

    /// <summary>
    ///   <para>datex:HeaviestAxleWeightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weight characteristic of the heaviest axle on the vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeaviestAxleWeightCharacteristic">http://vocab.datex.org/terms#HeaviestAxleWeightCharacteristic</seealso>
    let HeaviestAxleWeightCharacteristic =
        Prefixed_Name(datex, "HeaviestAxleWeightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpeningTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specification of opening times (e.g. for a parking site, a service facility, an access or the availability for equipment).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpeningTimes">http://vocab.datex.org/terms#OpeningTimes</seealso>
    let OpeningTimes = Prefixed_Name(datex, "OpeningTimes") |> PrefixedName
    /// <summary>
    ///   <para>datex:openAllYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openAllYear">http://vocab.datex.org/terms#openAllYear</seealso>
    let openAllYear = Prefixed_Name(datex, "openAllYear") |> PrefixedName

    /// <summary>
    ///   <para>datex:blurredAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#blurredAvailability">http://vocab.datex.org/terms#blurredAvailability</seealso>
    let blurredAvailability =
        Prefixed_Name(datex, "blurredAvailability") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpacesStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpacesStatus">http://vocab.datex.org/terms#groupOfParkingSpacesStatus</seealso>
    let groupOfParkingSpacesStatus =
        Prefixed_Name(datex, "groupOfParkingSpacesStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus">http://vocab.datex.org/terms#_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus</seealso>
    let _ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus =
        Prefixed_Name(datex, "_ParkingRecordStatusGroupIndexGroupOfParkingSpacesStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingConditions">http://vocab.datex.org/terms#parkingConditions</seealso>
    let parkingConditions = Prefixed_Name(datex, "parkingConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingEquipmentOrServiceFacilityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatus">http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityStatus</seealso>
    let parkingEquipmentOrServiceFacilityStatus =
        Prefixed_Name(datex, "parkingEquipmentOrServiceFacilityStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus">http://vocab.datex.org/terms#_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus</seealso>
    let _ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus =
        Prefixed_Name(datex, "_ParkingRecordStatusEquipmentOrServiceFacilityIndexParkingEquipmentOrServiceFacilityStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingFault">http://vocab.datex.org/terms#parkingFault</seealso>
    let parkingFault = Prefixed_Name(datex, "parkingFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingRouteStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteStatus">http://vocab.datex.org/terms#parkingRouteStatus</seealso>
    let parkingRouteStatus = Prefixed_Name(datex, "parkingRouteStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingRouteStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of a parking route (active/inactive) defined in the static part of the model.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRouteStatus">http://vocab.datex.org/terms#ParkingRouteStatus</seealso>
    let ParkingRouteStatus = Prefixed_Name(datex, "ParkingRouteStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingSpaceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceStatus">http://vocab.datex.org/terms#parkingSpaceStatus</seealso>
    let parkingSpaceStatus = Prefixed_Name(datex, "parkingSpaceStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus">http://vocab.datex.org/terms#_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus</seealso>
    let _ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus =
        Prefixed_Name(datex, "_ParkingRecordStatusParkingSpaceIndexParkingSpaceStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingVehicle">http://vocab.datex.org/terms#parkingVehicle</seealso>
    let parkingVehicle = Prefixed_Name(datex, "parkingVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:feedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#feedDescription">http://vocab.datex.org/terms#feedDescription</seealso>
    let feedDescription = Prefixed_Name(datex, "feedDescription") |> PrefixedName
    /// <summary>
    ///   <para>datex:feedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#feedType">http://vocab.datex.org/terms#feedType</seealso>
    let feedType = Prefixed_Name(datex, "feedType") |> PrefixedName

    /// <summary>
    ///   <para>datex:acceptedPaymentCards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#acceptedPaymentCards">http://vocab.datex.org/terms#acceptedPaymentCards</seealso>
    let acceptedPaymentCards =
        Prefixed_Name(datex, "acceptedPaymentCards") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBand">http://vocab.datex.org/terms#chargeBand</seealso>
    let chargeBand = Prefixed_Name(datex, "chargeBand") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBandByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBandByReference">http://vocab.datex.org/terms#chargeBandByReference</seealso>
    let chargeBandByReference =
        Prefixed_Name(datex, "chargeBandByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:freeOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#freeOfCharge">http://vocab.datex.org/terms#freeOfCharge</seealso>
    let freeOfCharge = Prefixed_Name(datex, "freeOfCharge") |> PrefixedName

    /// <summary>
    ///   <para>datex:paymentAdditionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentAdditionalDescription">http://vocab.datex.org/terms#paymentAdditionalDescription</seealso>
    let paymentAdditionalDescription =
        Prefixed_Name(datex, "paymentAdditionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:reservationFee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reservationFee">http://vocab.datex.org/terms#reservationFee</seealso>
    let reservationFee = Prefixed_Name(datex, "reservationFee") |> PrefixedName

    /// <summary>
    ///   <para>datex:tariffsAndPaymentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tariffsAndPaymentExtension">http://vocab.datex.org/terms#tariffsAndPaymentExtension</seealso>
    let tariffsAndPaymentExtension =
        Prefixed_Name(datex, "tariffsAndPaymentExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:airTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#airTemperature">http://vocab.datex.org/terms#airTemperature</seealso>
    let airTemperature = Prefixed_Name(datex, "airTemperature") |> PrefixedName

    /// <summary>
    ///   <para>datex:dewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dewPointTemperature">http://vocab.datex.org/terms#dewPointTemperature</seealso>
    let dewPointTemperature =
        Prefixed_Name(datex, "dewPointTemperature") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumTemperature">http://vocab.datex.org/terms#maximumTemperature</seealso>
    let maximumTemperature = Prefixed_Name(datex, "maximumTemperature") |> PrefixedName
    /// <summary>
    ///   <para>datex:minimumTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minimumTemperature">http://vocab.datex.org/terms#minimumTemperature</seealso>
    let minimumTemperature = Prefixed_Name(datex, "minimumTemperature") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleCharacteristicsExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension point for 'VehicleCharacteristics' to support additional attributes and literals like additional fuel types, load types etc.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCharacteristicsExtended">http://vocab.datex.org/terms#VehicleCharacteristicsExtended</seealso>
    let VehicleCharacteristicsExtended =
        Prefixed_Name(datex, "VehicleCharacteristicsExtended") |> PrefixedName

    /// <summary>
    ///   <para>datex:emissionClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#emissionClassification">http://vocab.datex.org/terms#emissionClassification</seealso>
    let emissionClassification =
        Prefixed_Name(datex, "emissionClassification") |> PrefixedName

    /// <summary>
    ///   <para>datex:fuelType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fuelType2">http://vocab.datex.org/terms#fuelType2</seealso>
    let fuelType2 = Prefixed_Name(datex, "fuelType2") |> PrefixedName
    /// <summary>
    ///   <para>datex:loadType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#loadType2">http://vocab.datex.org/terms#loadType2</seealso>
    let loadType2 = Prefixed_Name(datex, "loadType2") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleUsage2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleUsage2">http://vocab.datex.org/terms#vehicleUsage2</seealso>
    let vehicleUsage2 = Prefixed_Name(datex, "vehicleUsage2") |> PrefixedName

    /// <summary>
    ///   <para>datex:coveringPetrolStationArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#coveringPetrolStationArea">http://vocab.datex.org/terms#coveringPetrolStationArea</seealso>
    let coveringPetrolStationArea =
        Prefixed_Name(datex, "coveringPetrolStationArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountAndRateExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountAndRateExtension">http://vocab.datex.org/terms#vehicleCountAndRateExtension</seealso>
    let vehicleCountAndRateExtension =
        Prefixed_Name(datex, "vehicleCountAndRateExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountWithinInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountWithinInterval">http://vocab.datex.org/terms#vehicleCountWithinInterval</seealso>
    let vehicleCountWithinInterval =
        Prefixed_Name(datex, "vehicleCountWithinInterval") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleCountWithinInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gives incoming and/or outgoing vehicles and/or change of occupied spaces within a given interval. The interval is given in positive or negative seconds related to 'measurementOrCalculationTime' or 'measurementDefaultTime'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCountWithinInterval">http://vocab.datex.org/terms#VehicleCountWithinInterval</seealso>
    let VehicleCountWithinInterval =
        Prefixed_Name(datex, "VehicleCountWithinInterval") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleRate">http://vocab.datex.org/terms#vehicleRate</seealso>
    let vehicleRate = Prefixed_Name(datex, "vehicleRate") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gives information about fill and exit rates OR vehicle flow rate (without direction). If the time stamp is omitted, 'measurementTimeDefault' is used.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleRate">http://vocab.datex.org/terms#VehicleRate</seealso>
    let VehicleRate = Prefixed_Name(datex, "VehicleRate") |> PrefixedName
    /// <summary>
    ///   <para>datex:textPositionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPositionY">http://vocab.datex.org/terms#textPositionY</seealso>
    let textPositionY = Prefixed_Name(datex, "textPositionY") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextDisplayCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextDisplayCharacteristicsExtension">http://vocab.datex.org/terms#vmsTextDisplayCharacteristicsExtension</seealso>
    let vmsTextDisplayCharacteristicsExtension =
        Prefixed_Name(datex, "vmsTextDisplayCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:BombAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BombAlert">http://vocab.datex.org/terms#BombAlert</seealso>
    let BombAlert = Prefixed_Name(datex, "BombAlert") |> PrefixedName

    /// <summary>
    ///   <para>datex:BridgeSwingInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BridgeSwingInOperation">http://vocab.datex.org/terms#BridgeSwingInOperation</seealso>
    let BridgeSwingInOperation =
        Prefixed_Name(datex, "BridgeSwingInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:TreeAndVegetationCuttingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TreeAndVegetationCuttingWork">http://vocab.datex.org/terms#TreeAndVegetationCuttingWork</seealso>
    let TreeAndVegetationCuttingWork =
        Prefixed_Name(datex, "TreeAndVegetationCuttingWork") |> PrefixedName

    /// <summary>
    ///   <para>datex:TunnelVentilationFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TunnelVentilationFailure">http://vocab.datex.org/terms#TunnelVentilationFailure</seealso>
    let TunnelVentilationFailure =
        Prefixed_Name(datex, "TunnelVentilationFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleInDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleInDifficulty">http://vocab.datex.org/terms#VehicleInDifficulty</seealso>
    let VehicleInDifficulty =
        Prefixed_Name(datex, "VehicleInDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road caused by one or more vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleObstruction">http://vocab.datex.org/terms#VehicleObstruction</seealso>
    let VehicleObstruction = Prefixed_Name(datex, "VehicleObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleOnWrongCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleOnWrongCarriageway">http://vocab.datex.org/terms#VehicleOnWrongCarriageway</seealso>
    let VehicleOnWrongCarriageway =
        Prefixed_Name(datex, "VehicleOnWrongCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleRepair">http://vocab.datex.org/terms#VehicleRepair</seealso>
    let VehicleRepair = Prefixed_Name(datex, "VehicleRepair") |> PrefixedName
    /// <summary>
    ///   <para>datex:WaterSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WaterSportsMeeting">http://vocab.datex.org/terms#WaterSportsMeeting</seealso>
    let WaterSportsMeeting = Prefixed_Name(datex, "WaterSportsMeeting") |> PrefixedName
    /// <summary>
    ///   <para>datex:WeighInMotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeighInMotion">http://vocab.datex.org/terms#WeighInMotion</seealso>
    let WeighInMotion = Prefixed_Name(datex, "WeighInMotion") |> PrefixedName
    /// <summary>
    ///   <para>datex:Wet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Wet">http://vocab.datex.org/terms#Wet</seealso>
    let Wet = Prefixed_Name(datex, "Wet") |> PrefixedName
    /// <summary>
    ///   <para>datex:WetIcyPavement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WetIcyPavement">http://vocab.datex.org/terms#WetIcyPavement</seealso>
    let WetIcyPavement = Prefixed_Name(datex, "WetIcyPavement") |> PrefixedName

    /// <summary>
    ///   <para>datex:abnormalTrafficExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#abnormalTrafficExtension">http://vocab.datex.org/terms#abnormalTrafficExtension</seealso>
    let abnormalTrafficExtension =
        Prefixed_Name(datex, "abnormalTrafficExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ExtensionType">http://vocab.datex.org/terms#_ExtensionType</seealso>
    let _ExtensionType = Prefixed_Name(datex, "_ExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:computationalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#computationalMethod">http://vocab.datex.org/terms#computationalMethod</seealso>
    let computationalMethod =
        Prefixed_Name(datex, "computationalMethod") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfIncompleteInputs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfIncompleteInputs">http://vocab.datex.org/terms#numberOfIncompleteInputs</seealso>
    let numberOfIncompleteInputs =
        Prefixed_Name(datex, "numberOfIncompleteInputs") |> PrefixedName

    /// <summary>
    ///   <para>datex:DateTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of an instance in time.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DateTimeValue">http://vocab.datex.org/terms#DateTimeValue</seealso>
    let DateTimeValue = Prefixed_Name(datex, "DateTimeValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:dateTimeValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dateTimeValueExtension">http://vocab.datex.org/terms#dateTimeValueExtension</seealso>
    let dateTimeValueExtension =
        Prefixed_Name(datex, "dateTimeValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:capacityRemaining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#capacityRemaining">http://vocab.datex.org/terms#capacityRemaining</seealso>
    let capacityRemaining = Prefixed_Name(datex, "capacityRemaining") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfOperationalLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfOperationalLanes">http://vocab.datex.org/terms#numberOfOperationalLanes</seealso>
    let numberOfOperationalLanes =
        Prefixed_Name(datex, "numberOfOperationalLanes") |> PrefixedName

    /// <summary>
    ///   <para>datex:MaintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the maintenance vehicles involved in the roadworks activity.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MaintenanceVehicles">http://vocab.datex.org/terms#MaintenanceVehicles</seealso>
    let MaintenanceVehicles =
        Prefixed_Name(datex, "MaintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:maintenanceVehicleActions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maintenanceVehicleActions">http://vocab.datex.org/terms#maintenanceVehicleActions</seealso>
    let maintenanceVehicleActions =
        Prefixed_Name(datex, "maintenanceVehicleActions") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLocationReferencePoint">http://vocab.datex.org/terms#openlrLocationReferencePoint</seealso>
    let openlrLocationReferencePoint =
        Prefixed_Name(datex, "openlrLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The basis of a location reference is a sequence of location reference points (LRPs).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrLocationReferencePoint">http://vocab.datex.org/terms#OpenlrLocationReferencePoint</seealso>
    let OpenlrLocationReferencePoint =
        Prefixed_Name(datex, "OpenlrLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrOrientation">http://vocab.datex.org/terms#openlrOrientation</seealso>
    let openlrOrientation = Prefixed_Name(datex, "openlrOrientation") |> PrefixedName

    /// <summary>
    ///   <para>datex:overrideParkingThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overrideParkingThresholds">http://vocab.datex.org/terms#overrideParkingThresholds</seealso>
    let overrideParkingThresholds =
        Prefixed_Name(datex, "overrideParkingThresholds") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingAccessStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAccessStatus">http://vocab.datex.org/terms#parkingAccessStatus</seealso>
    let parkingAccessStatus =
        Prefixed_Name(datex, "parkingAccessStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingQueueingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingQueueingTime">http://vocab.datex.org/terms#parkingQueueingTime</seealso>
    let parkingQueueingTime =
        Prefixed_Name(datex, "parkingQueueingTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordReference">http://vocab.datex.org/terms#parkingRecordReference</seealso>
    let parkingRecordReference =
        Prefixed_Name(datex, "parkingRecordReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:usageScenarioOperationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#usageScenarioOperationStatus">http://vocab.datex.org/terms#usageScenarioOperationStatus</seealso>
    let usageScenarioOperationStatus =
        Prefixed_Name(datex, "usageScenarioOperationStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Reference">http://vocab.datex.org/terms#Reference</seealso>
    let Reference = Prefixed_Name(datex, "Reference") |> PrefixedName

    /// <summary>
    ///   <para>datex:referenceSettingsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referenceSettingsExtension">http://vocab.datex.org/terms#referenceSettingsExtension</seealso>
    let referenceSettingsExtension =
        Prefixed_Name(datex, "referenceSettingsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficStatusDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficStatusDefault">http://vocab.datex.org/terms#trafficStatusDefault</seealso>
    let trafficStatusDefault =
        Prefixed_Name(datex, "trafficStatusDefault") |> PrefixedName

    /// <summary>
    ///   <para>datex:updateMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#updateMethod">http://vocab.datex.org/terms#updateMethod</seealso>
    let updateMethod = Prefixed_Name(datex, "updateMethod") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsDescription">http://vocab.datex.org/terms#vmsDescription</seealso>
    let vmsDescription = Prefixed_Name(datex, "vmsDescription") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsDisplayHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsDisplayHeight">http://vocab.datex.org/terms#vmsDisplayHeight</seealso>
    let vmsDisplayHeight = Prefixed_Name(datex, "vmsDisplayHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsDisplayWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsDisplayWidth">http://vocab.datex.org/terms#vmsDisplayWidth</seealso>
    let vmsDisplayWidth = Prefixed_Name(datex, "vmsDisplayWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsHeightAboveRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsHeightAboveRoadway">http://vocab.datex.org/terms#vmsHeightAboveRoadway</seealso>
    let vmsHeightAboveRoadway =
        Prefixed_Name(datex, "vmsHeightAboveRoadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:ToxicCloudAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ToxicCloudAlert">http://vocab.datex.org/terms#ToxicCloudAlert</seealso>
    let ToxicCloudAlert = Prefixed_Name(datex, "ToxicCloudAlert") |> PrefixedName
    /// <summary>
    ///   <para>datex:AlertCMethod4Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCMethod4Point">http://vocab.datex.org/terms#AlertCMethod4Point</seealso>
    let AlertCMethod4Point = Prefixed_Name(datex, "AlertCMethod4Point") |> PrefixedName
    /// <summary>
    ///   <para>datex:D2LogicalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The DATEX II logical model comprising exchange, content payload and management sub-models.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#D2LogicalModel">http://vocab.datex.org/terms#D2LogicalModel</seealso>
    let D2LogicalModel = Prefixed_Name(datex, "D2LogicalModel") |> PrefixedName
    /// <summary>
    ///   <para>datex:modelBaseVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#modelBaseVersion">http://vocab.datex.org/terms#modelBaseVersion</seealso>
    let modelBaseVersion = Prefixed_Name(datex, "modelBaseVersion") |> PrefixedName
    /// <summary>
    ///   <para>datex:exchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exchange">http://vocab.datex.org/terms#exchange</seealso>
    let exchange = Prefixed_Name(datex, "exchange") |> PrefixedName
    /// <summary>
    ///   <para>datex:Exchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details associated with the management of the exchange between the supplier and the client.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Exchange">http://vocab.datex.org/terms#Exchange</seealso>
    let Exchange = Prefixed_Name(datex, "Exchange") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplierCalculatedDataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplierCalculatedDataQuality">http://vocab.datex.org/terms#supplierCalculatedDataQuality</seealso>
    let supplierCalculatedDataQuality =
        Prefixed_Name(datex, "supplierCalculatedDataQuality") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfInputValuesUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfInputValuesUsed">http://vocab.datex.org/terms#numberOfInputValuesUsed</seealso>
    let numberOfInputValuesUsed =
        Prefixed_Name(datex, "numberOfInputValuesUsed") |> PrefixedName

    /// <summary>
    ///   <para>datex:smoothingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#smoothingFactor">http://vocab.datex.org/terms#smoothingFactor</seealso>
    let smoothingFactor = Prefixed_Name(datex, "smoothingFactor") |> PrefixedName
    /// <summary>
    ///   <para>datex:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accuracy">http://vocab.datex.org/terms#accuracy</seealso>
    let accuracy = Prefixed_Name(datex, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>datex:standardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#standardDeviation">http://vocab.datex.org/terms#standardDeviation</seealso>
    let standardDeviation = Prefixed_Name(datex, "standardDeviation") |> PrefixedName
    /// <summary>
    ///   <para>datex:dataError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dataError">http://vocab.datex.org/terms#dataError</seealso>
    let dataError = Prefixed_Name(datex, "dataError") |> PrefixedName
    /// <summary>
    ///   <para>datex:dataValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dataValueExtension">http://vocab.datex.org/terms#dataValueExtension</seealso>
    let dataValueExtension = Prefixed_Name(datex, "dataValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:heightCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightCharacteristicExtension">http://vocab.datex.org/terms#heightCharacteristicExtension</seealso>
    let heightCharacteristicExtension =
        Prefixed_Name(datex, "heightCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleHeight">http://vocab.datex.org/terms#vehicleHeight</seealso>
    let vehicleHeight = Prefixed_Name(datex, "vehicleHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of atmospheric humidity.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Humidity">http://vocab.datex.org/terms#Humidity</seealso>
    let Humidity = Prefixed_Name(datex, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>datex:humidityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#humidityExtension">http://vocab.datex.org/terms#humidityExtension</seealso>
    let humidityExtension = Prefixed_Name(datex, "humidityExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:relativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#relativeHumidity">http://vocab.datex.org/terms#relativeHumidity</seealso>
    let relativeHumidity = Prefixed_Name(datex, "relativeHumidity") |> PrefixedName
    /// <summary>
    ///   <para>datex:PercentageValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value expressed as a percentage.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PercentageValue">http://vocab.datex.org/terms#PercentageValue</seealso>
    let PercentageValue = Prefixed_Name(datex, "PercentageValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#humidity">http://vocab.datex.org/terms#humidity</seealso>
    let humidity = Prefixed_Name(datex, "humidity") |> PrefixedName

    /// <summary>
    ///   <para>datex:humidityInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#humidityInformationExtension">http://vocab.datex.org/terms#humidityInformationExtension</seealso>
    let humidityInformationExtension =
        Prefixed_Name(datex, "humidityInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:WeatherData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measured or derived values relating to the weather at a specific location or locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeatherData">http://vocab.datex.org/terms#WeatherData</seealso>
    let WeatherData = Prefixed_Name(datex, "WeatherData") |> PrefixedName
    /// <summary>
    ///   <para>datex:Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Impact">http://vocab.datex.org/terms#Impact</seealso>
    let Impact = Prefixed_Name(datex, "Impact") |> PrefixedName
    /// <summary>
    ///   <para>datex:delays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#delays">http://vocab.datex.org/terms#delays</seealso>
    let delays = Prefixed_Name(datex, "delays") |> PrefixedName
    /// <summary>
    ///   <para>datex:impactExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#impactExtension">http://vocab.datex.org/terms#impactExtension</seealso>
    let impactExtension = Prefixed_Name(datex, "impactExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfLanesRestricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfLanesRestricted">http://vocab.datex.org/terms#numberOfLanesRestricted</seealso>
    let numberOfLanesRestricted =
        Prefixed_Name(datex, "numberOfLanesRestricted") |> PrefixedName

    /// <summary>
    ///   <para>datex:originalNumberOfLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#originalNumberOfLanes">http://vocab.datex.org/terms#originalNumberOfLanes</seealso>
    let originalNumberOfLanes =
        Prefixed_Name(datex, "originalNumberOfLanes") |> PrefixedName

    /// <summary>
    ///   <para>datex:residualRoadWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#residualRoadWidth">http://vocab.datex.org/terms#residualRoadWidth</seealso>
    let residualRoadWidth = Prefixed_Name(datex, "residualRoadWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficConstrictionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficConstrictionType">http://vocab.datex.org/terms#trafficConstrictionType</seealso>
    let trafficConstrictionType =
        Prefixed_Name(datex, "trafficConstrictionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationCharacteristicsOverrideExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationCharacteristicsOverrideExtension">http://vocab.datex.org/terms#locationCharacteristicsOverrideExtension</seealso>
    let locationCharacteristicsOverrideExtension =
        Prefixed_Name(datex, "locationCharacteristicsOverrideExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementLanesOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementLanesOverride">http://vocab.datex.org/terms#measurementLanesOverride</seealso>
    let measurementLanesOverride =
        Prefixed_Name(datex, "measurementLanesOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:reversedFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reversedFlow">http://vocab.datex.org/terms#reversedFlow</seealso>
    let reversedFlow = Prefixed_Name(datex, "reversedFlow") |> PrefixedName

    /// <summary>
    ///   <para>datex:maintenanceVehiclesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maintenanceVehiclesExtension">http://vocab.datex.org/terms#maintenanceVehiclesExtension</seealso>
    let maintenanceVehiclesExtension =
        Prefixed_Name(datex, "maintenanceVehiclesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfMaintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfMaintenanceVehicles">http://vocab.datex.org/terms#numberOfMaintenanceVehicles</seealso>
    let numberOfMaintenanceVehicles =
        Prefixed_Name(datex, "numberOfMaintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:MaintenanceWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Roadworks involving the maintenance or installation of infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MaintenanceWorks">http://vocab.datex.org/terms#MaintenanceWorks</seealso>
    let MaintenanceWorks = Prefixed_Name(datex, "MaintenanceWorks") |> PrefixedName

    /// <summary>
    ///   <para>datex:maintenanceWorksExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maintenanceWorksExtension">http://vocab.datex.org/terms#maintenanceWorksExtension</seealso>
    let maintenanceWorksExtension =
        Prefixed_Name(datex, "maintenanceWorksExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ManagedCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cause of this situation record which is managed by the publication creator, i.e. one which is represented by another situation record produced by the same publication creator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ManagedCause">http://vocab.datex.org/terms#ManagedCause</seealso>
    let ManagedCause = Prefixed_Name(datex, "ManagedCause") |> PrefixedName
    /// <summary>
    ///   <para>datex:managedCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to another situation record produced by the same publication creator which defines a cause of the event defined here.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managedCause">http://vocab.datex.org/terms#managedCause</seealso>
    let managedCause = Prefixed_Name(datex, "managedCause") |> PrefixedName

    /// <summary>
    ///   <para>datex:_SituationRecordVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_SituationRecordVersionedReference">http://vocab.datex.org/terms#_SituationRecordVersionedReference</seealso>
    let _SituationRecordVersionedReference =
        Prefixed_Name(datex, "_SituationRecordVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:managedCauseExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managedCauseExtension">http://vocab.datex.org/terms#managedCauseExtension</seealso>
    let managedCauseExtension =
        Prefixed_Name(datex, "managedCauseExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrClosedLineLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the openLR method of areadefinition by providing a closed path (i.e. a circuit) in the road network. The boundary always consists of road segments</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrClosedLineLocationReference">http://vocab.datex.org/terms#OpenlrClosedLineLocationReference</seealso>
    let OpenlrClosedLineLocationReference =
        Prefixed_Name(datex, "OpenlrClosedLineLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrClosedLineLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrClosedLineLocationReferenceExtension">http://vocab.datex.org/terms#openlrClosedLineLocationReferenceExtension</seealso>
    let openlrClosedLineLocationReferenceExtension =
        Prefixed_Name(datex, "openlrClosedLineLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLastLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLastLine">http://vocab.datex.org/terms#openlrLastLine</seealso>
    let openlrLastLine = Prefixed_Name(datex, "openlrLastLine") |> PrefixedName
    /// <summary>
    ///   <para>datex:OpenlrExtendedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension to provide Area information in openLR format</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrExtendedArea">http://vocab.datex.org/terms#OpenlrExtendedArea</seealso>
    let OpenlrExtendedArea = Prefixed_Name(datex, "OpenlrExtendedArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrAreaLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrAreaLocationReference">http://vocab.datex.org/terms#openlrAreaLocationReference</seealso>
    let openlrAreaLocationReference =
        Prefixed_Name(datex, "openlrAreaLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteDetailsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteDetailsExtension">http://vocab.datex.org/terms#parkingRouteDetailsExtension</seealso>
    let parkingRouteDetailsExtension =
        Prefixed_Name(datex, "parkingRouteDetailsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The direction of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteDirection">http://vocab.datex.org/terms#parkingRouteDirection</seealso>
    let parkingRouteDirection =
        Prefixed_Name(datex, "parkingRouteDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteDirection2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Additional directions of traffic, for which the parking route can be used. If not specified, the route can be used in the order of the given locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteDirection2">http://vocab.datex.org/terms#parkingRouteDirection2</seealso>
    let parkingRouteDirection2 =
        Prefixed_Name(datex, "parkingRouteDirection2") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteIconIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An index, which can identify some icon for visualisation of the route. Note that form and usage of this index as well as the icons itself are not further determined here.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteIconIndex">http://vocab.datex.org/terms#parkingRouteIconIndex</seealso>
    let parkingRouteIconIndex =
        Prefixed_Name(datex, "parkingRouteIconIndex") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRouteName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Name of the parking route.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteName">http://vocab.datex.org/terms#parkingRouteName</seealso>
    let parkingRouteName = Prefixed_Name(datex, "parkingRouteName") |> PrefixedName
    /// <summary>
    ///   <para>datex:endOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#endOfPeriod">http://vocab.datex.org/terms#endOfPeriod</seealso>
    let endOfPeriod = Prefixed_Name(datex, "endOfPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:periodExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#periodExtension">http://vocab.datex.org/terms#periodExtension</seealso>
    let periodExtension = Prefixed_Name(datex, "periodExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PeriodExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PeriodExtensionType">http://vocab.datex.org/terms#_PeriodExtensionType</seealso>
    let _PeriodExtensionType =
        Prefixed_Name(datex, "_PeriodExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:periodName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#periodName">http://vocab.datex.org/terms#periodName</seealso>
    let periodName = Prefixed_Name(datex, "periodName") |> PrefixedName

    /// <summary>
    ///   <para>datex:recurringDayWeekMonthPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#recurringDayWeekMonthPeriod">http://vocab.datex.org/terms#recurringDayWeekMonthPeriod</seealso>
    let recurringDayWeekMonthPeriod =
        Prefixed_Name(datex, "recurringDayWeekMonthPeriod") |> PrefixedName

    /// <summary>
    ///   <para>datex:reroutingManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of rerouting management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reroutingManagementType">http://vocab.datex.org/terms#reroutingManagementType</seealso>
    let reroutingManagementType =
        Prefixed_Name(datex, "reroutingManagementType") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOrJunctionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The intersecting road or the junction at which the alternative route commences.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOrJunctionNumber">http://vocab.datex.org/terms#roadOrJunctionNumber</seealso>
    let roadOrJunctionNumber =
        Prefixed_Name(datex, "roadOrJunctionNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:signedRerouting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether the rerouting is signed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#signedRerouting">http://vocab.datex.org/terms#signedRerouting</seealso>
    let signedRerouting = Prefixed_Name(datex, "signedRerouting") |> PrefixedName

    /// <summary>
    ///   <para>datex:temperatureExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temperatureExtension">http://vocab.datex.org/terms#temperatureExtension</seealso>
    let temperatureExtension =
        Prefixed_Name(datex, "temperatureExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TemperatureInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of atmospheric temperature.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemperatureInformation">http://vocab.datex.org/terms#TemperatureInformation</seealso>
    let TemperatureInformation =
        Prefixed_Name(datex, "TemperatureInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:temperatureInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temperatureInformationExtension">http://vocab.datex.org/terms#temperatureInformationExtension</seealso>
    let temperatureInformationExtension =
        Prefixed_Name(datex, "temperatureInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:temperatureValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temperatureValueExtension">http://vocab.datex.org/terms#temperatureValueExtension</seealso>
    let temperatureValueExtension =
        Prefixed_Name(datex, "temperatureValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextImageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextImageUrl">http://vocab.datex.org/terms#vmsTextImageUrl</seealso>
    let vmsTextImageUrl = Prefixed_Name(datex, "vmsTextImageUrl") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsTextLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLine">http://vocab.datex.org/terms#vmsTextLine</seealso>
    let vmsTextLine = Prefixed_Name(datex, "vmsTextLine") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsTextLineIndexVmsTextLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsTextLineIndexVmsTextLine">http://vocab.datex.org/terms#_VmsTextLineIndexVmsTextLine</seealso>
    let _VmsTextLineIndexVmsTextLine =
        Prefixed_Name(datex, "_VmsTextLineIndexVmsTextLine") |> PrefixedName

    /// <summary>
    ///   <para>datex:legendCodeListIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#legendCodeListIdentifier">http://vocab.datex.org/terms#legendCodeListIdentifier</seealso>
    let legendCodeListIdentifier =
        Prefixed_Name(datex, "legendCodeListIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxFontHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxFontHeight">http://vocab.datex.org/terms#maxFontHeight</seealso>
    let maxFontHeight = Prefixed_Name(datex, "maxFontHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:maxFontSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxFontSpacing">http://vocab.datex.org/terms#maxFontSpacing</seealso>
    let maxFontSpacing = Prefixed_Name(datex, "maxFontSpacing") |> PrefixedName
    /// <summary>
    ///   <para>datex:maxFontWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxFontWidth">http://vocab.datex.org/terms#maxFontWidth</seealso>
    let maxFontWidth = Prefixed_Name(datex, "maxFontWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxNumberOfCharacters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxNumberOfCharacters">http://vocab.datex.org/terms#maxNumberOfCharacters</seealso>
    let maxNumberOfCharacters =
        Prefixed_Name(datex, "maxNumberOfCharacters") |> PrefixedName

    /// <summary>
    ///   <para>datex:minFontHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minFontHeight">http://vocab.datex.org/terms#minFontHeight</seealso>
    let minFontHeight = Prefixed_Name(datex, "minFontHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:minFontSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minFontSpacing">http://vocab.datex.org/terms#minFontSpacing</seealso>
    let minFontSpacing = Prefixed_Name(datex, "minFontSpacing") |> PrefixedName
    /// <summary>
    ///   <para>datex:minFontWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minFontWidth">http://vocab.datex.org/terms#minFontWidth</seealso>
    let minFontWidth = Prefixed_Name(datex, "minFontWidth") |> PrefixedName
    /// <summary>
    ///   <para>datex:textDisplayHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textDisplayHeight">http://vocab.datex.org/terms#textDisplayHeight</seealso>
    let textDisplayHeight = Prefixed_Name(datex, "textDisplayHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:textDisplayWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textDisplayWidth">http://vocab.datex.org/terms#textDisplayWidth</seealso>
    let textDisplayWidth = Prefixed_Name(datex, "textDisplayWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:textLanternsPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textLanternsPresent">http://vocab.datex.org/terms#textLanternsPresent</seealso>
    let textLanternsPresent =
        Prefixed_Name(datex, "textLanternsPresent") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPageSequencingCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPageSequencingCapable">http://vocab.datex.org/terms#textPageSequencingCapable</seealso>
    let textPageSequencingCapable =
        Prefixed_Name(datex, "textPageSequencingCapable") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPixelsAcross</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPixelsAcross">http://vocab.datex.org/terms#textPixelsAcross</seealso>
    let textPixelsAcross = Prefixed_Name(datex, "textPixelsAcross") |> PrefixedName
    /// <summary>
    ///   <para>datex:textPixelsDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPixelsDown">http://vocab.datex.org/terms#textPixelsDown</seealso>
    let textPixelsDown = Prefixed_Name(datex, "textPixelsDown") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPositionAbsolute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPositionAbsolute">http://vocab.datex.org/terms#textPositionAbsolute</seealso>
    let textPositionAbsolute =
        Prefixed_Name(datex, "textPositionAbsolute") |> PrefixedName

    /// <summary>
    ///   <para>datex:textPositionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textPositionX">http://vocab.datex.org/terms#textPositionX</seealso>
    let textPositionX = Prefixed_Name(datex, "textPositionX") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsTextLineColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLineColour">http://vocab.datex.org/terms#vmsTextLineColour</seealso>
    let vmsTextLineColour = Prefixed_Name(datex, "vmsTextLineColour") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextLineExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLineExtension">http://vocab.datex.org/terms#vmsTextLineExtension</seealso>
    let vmsTextLineExtension =
        Prefixed_Name(datex, "vmsTextLineExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextLineFlashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLineFlashing">http://vocab.datex.org/terms#vmsTextLineFlashing</seealso>
    let vmsTextLineFlashing =
        Prefixed_Name(datex, "vmsTextLineFlashing") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextLineHtml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLineHtml">http://vocab.datex.org/terms#vmsTextLineHtml</seealso>
    let vmsTextLineHtml = Prefixed_Name(datex, "vmsTextLineHtml") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTextLineLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextLineLanguage">http://vocab.datex.org/terms#vmsTextLineLanguage</seealso>
    let vmsTextLineLanguage =
        Prefixed_Name(datex, "vmsTextLineLanguage") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of fault which is being reported for the VMS unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitFault">http://vocab.datex.org/terms#vmsUnitFault</seealso>
    let vmsUnitFault = Prefixed_Name(datex, "vmsUnitFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsUnitFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the fault which is being reported for the specified variable message sign control unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsUnitFault">http://vocab.datex.org/terms#VmsUnitFault</seealso>
    let VmsUnitFault = Prefixed_Name(datex, "VmsUnitFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsUnitReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned VMS unit record in a VMS Unit table which defines the characteristics of the VMS unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitReference">http://vocab.datex.org/terms#vmsUnitReference</seealso>
    let vmsUnitReference = Prefixed_Name(datex, "vmsUnitReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitTableReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned VMS Unit table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitTableReference">http://vocab.datex.org/terms#vmsUnitTableReference</seealso>
    let vmsUnitTableReference =
        Prefixed_Name(datex, "vmsUnitTableReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsUnitTableVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsUnitTableVersionedReference">http://vocab.datex.org/terms#_VmsUnitTableVersionedReference</seealso>
    let _VmsUnitTableVersionedReference =
        Prefixed_Name(datex, "_VmsUnitTableVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitFaultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitFaultExtension">http://vocab.datex.org/terms#vmsUnitFaultExtension</seealso>
    let vmsUnitFaultExtension =
        Prefixed_Name(datex, "vmsUnitFaultExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsUnitRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A versioned single VMS unit entry/record in the VMS Unit table that defines the characteristics of the VMS unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsUnitRecord">http://vocab.datex.org/terms#VmsUnitRecord</seealso>
    let VmsUnitRecord = Prefixed_Name(datex, "VmsUnitRecord") |> PrefixedName
    /// <summary>
    ///   <para>datex:BullFight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BullFight">http://vocab.datex.org/terms#BullFight</seealso>
    let BullFight = Prefixed_Name(datex, "BullFight") |> PrefixedName

    /// <summary>
    ///   <para>datex:CarPoolLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CarPoolLaneInOperation">http://vocab.datex.org/terms#CarPoolLaneInOperation</seealso>
    let CarPoolLaneInOperation =
        Prefixed_Name(datex, "CarPoolLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:OffsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The non negative offset distance from the ALERT-C referenced point to the actual point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OffsetDistance">http://vocab.datex.org/terms#OffsetDistance</seealso>
    let OffsetDistance = Prefixed_Name(datex, "OffsetDistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCMethod4SecondaryPointLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocationExtension">http://vocab.datex.org/terms#alertCMethod4SecondaryPointLocationExtension</seealso>
    let alertCMethod4SecondaryPointLocationExtension =
        Prefixed_Name(datex, "alertCMethod4SecondaryPointLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCPointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCPointExtension">http://vocab.datex.org/terms#alertCPointExtension</seealso>
    let alertCPointExtension =
        Prefixed_Name(datex, "alertCPointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A time stamp defining an instance in time.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dateTime">http://vocab.datex.org/terms#dateTime</seealso>
    let dateTime = Prefixed_Name(datex, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:DayWeekMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of periods defined by the intersection of days, weeks and months.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DayWeekMonth">http://vocab.datex.org/terms#DayWeekMonth</seealso>
    let DayWeekMonth = Prefixed_Name(datex, "DayWeekMonth") |> PrefixedName
    /// <summary>
    ///   <para>datex:applicableDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableDay">http://vocab.datex.org/terms#applicableDay</seealso>
    let applicableDay = Prefixed_Name(datex, "applicableDay") |> PrefixedName
    /// <summary>
    ///   <para>datex:applicableWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableWeek">http://vocab.datex.org/terms#applicableWeek</seealso>
    let applicableWeek = Prefixed_Name(datex, "applicableWeek") |> PrefixedName

    /// <summary>
    ///   <para>datex:dayWeekMonthExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dayWeekMonthExtension">http://vocab.datex.org/terms#dayWeekMonthExtension</seealso>
    let dayWeekMonthExtension =
        Prefixed_Name(datex, "dayWeekMonthExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:DedicatedAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reference to an access of any type (vehicles, pedestrian, ...).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DedicatedAccess">http://vocab.datex.org/terms#DedicatedAccess</seealso>
    let DedicatedAccess = Prefixed_Name(datex, "DedicatedAccess") |> PrefixedName
    /// <summary>
    ///   <para>datex:dedicatedAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dedicatedAccess">http://vocab.datex.org/terms#dedicatedAccess</seealso>
    let dedicatedAccess = Prefixed_Name(datex, "dedicatedAccess") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromParkingSpace">http://vocab.datex.org/terms#distanceFromParkingSpace</seealso>
    let distanceFromParkingSpace =
        Prefixed_Name(datex, "distanceFromParkingSpace") |> PrefixedName

    /// <summary>
    ///   <para>datex:Delays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Delays">http://vocab.datex.org/terms#Delays</seealso>
    let Delays = Prefixed_Name(datex, "Delays") |> PrefixedName
    /// <summary>
    ///   <para>datex:delayBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#delayBand">http://vocab.datex.org/terms#delayBand</seealso>
    let delayBand = Prefixed_Name(datex, "delayBand") |> PrefixedName
    /// <summary>
    ///   <para>datex:delayTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#delayTimeValue">http://vocab.datex.org/terms#delayTimeValue</seealso>
    let delayTimeValue = Prefixed_Name(datex, "delayTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:delaysExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#delaysExtension">http://vocab.datex.org/terms#delaysExtension</seealso>
    let delaysExtension = Prefixed_Name(datex, "delaysExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:delaysType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#delaysType">http://vocab.datex.org/terms#delaysType</seealso>
    let delaysType = Prefixed_Name(datex, "delaysType") |> PrefixedName

    /// <summary>
    ///   <para>datex:interUrbanParkingSiteExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#interUrbanParkingSiteExtension">http://vocab.datex.org/terms#interUrbanParkingSiteExtension</seealso>
    let interUrbanParkingSiteExtension =
        Prefixed_Name(datex, "interUrbanParkingSiteExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:interUrbanParkingSiteLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines whether the interurban parking site is located in or nearby a motorway context, is a layby or on-street parking.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#interUrbanParkingSiteLocation">http://vocab.datex.org/terms#interUrbanParkingSiteLocation</seealso>
    let interUrbanParkingSiteLocation =
        Prefixed_Name(datex, "interUrbanParkingSiteLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementEquipmentTypeUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementEquipmentTypeUsed">http://vocab.datex.org/terms#measurementEquipmentTypeUsed</seealso>
    let measurementEquipmentTypeUsed =
        Prefixed_Name(datex, "measurementEquipmentTypeUsed") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementEquipmentFaultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementEquipmentFaultExtension">http://vocab.datex.org/terms#measurementEquipmentFaultExtension</seealso>
    let measurementEquipmentFaultExtension =
        Prefixed_Name(datex, "measurementEquipmentFaultExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrExtendedLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension class for OpenLR Line location reference</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrExtendedLinear">http://vocab.datex.org/terms#OpenlrExtendedLinear</seealso>
    let OpenlrExtendedLinear =
        Prefixed_Name(datex, "OpenlrExtendedLinear") |> PrefixedName

    /// <summary>
    ///   <para>datex:firstDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#firstDirection">http://vocab.datex.org/terms#firstDirection</seealso>
    let firstDirection = Prefixed_Name(datex, "firstDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrLineLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A LineLocationReference is defined by an ordered sequence of location reference points and a terminating last location reference point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrLineLocationReference">http://vocab.datex.org/terms#OpenlrLineLocationReference</seealso>
    let OpenlrLineLocationReference =
        Prefixed_Name(datex, "OpenlrLineLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:oppositeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#oppositeDirection">http://vocab.datex.org/terms#oppositeDirection</seealso>
    let oppositeDirection = Prefixed_Name(datex, "oppositeDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPointLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point location is a zero-dimensional element in a map that specifies a geometric location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPointLocationReference">http://vocab.datex.org/terms#OpenlrPointLocationReference</seealso>
    let OpenlrPointLocationReference =
        Prefixed_Name(datex, "OpenlrPointLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrGeoCoordinateExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrGeoCoordinateExtension">http://vocab.datex.org/terms#openlrGeoCoordinateExtension</seealso>
    let openlrGeoCoordinateExtension =
        Prefixed_Name(datex, "openlrGeoCoordinateExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single geospatial point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Point">http://vocab.datex.org/terms#Point</seealso>
    let Point = Prefixed_Name(datex, "Point") |> PrefixedName
    /// <summary>
    ///   <para>datex:alertCPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCPoint">http://vocab.datex.org/terms#alertCPoint</seealso>
    let alertCPoint = Prefixed_Name(datex, "alertCPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointAlongLinearElement">http://vocab.datex.org/terms#pointAlongLinearElement</seealso>
    let pointAlongLinearElement =
        Prefixed_Name(datex, "pointAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:PointAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PointAlongLinearElement">http://vocab.datex.org/terms#PointAlongLinearElement</seealso>
    let PointAlongLinearElement =
        Prefixed_Name(datex, "PointAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegPointLocation">http://vocab.datex.org/terms#tpegPointLocation</seealso>
    let tpegPointLocation = Prefixed_Name(datex, "tpegPointLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:TpegPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegPointLocation">http://vocab.datex.org/terms#TpegPointLocation</seealso>
    let TpegPointLocation = Prefixed_Name(datex, "TpegPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:administrativeAreaOfPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#administrativeAreaOfPoint">http://vocab.datex.org/terms#administrativeAreaOfPoint</seealso>
    let administrativeAreaOfPoint =
        Prefixed_Name(datex, "administrativeAreaOfPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceAlongLinearElement">http://vocab.datex.org/terms#distanceAlongLinearElement</seealso>
    let distanceAlongLinearElement =
        Prefixed_Name(datex, "distanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:heightGradeOfPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightGradeOfPoint">http://vocab.datex.org/terms#heightGradeOfPoint</seealso>
    let heightGradeOfPoint = Prefixed_Name(datex, "heightGradeOfPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointAlongLinearElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointAlongLinearElementExtension">http://vocab.datex.org/terms#pointAlongLinearElementExtension</seealso>
    let pointAlongLinearElementExtension =
        Prefixed_Name(datex, "pointAlongLinearElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadSurfaceConditionInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of road surface conditions which are related to the weather.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadSurfaceConditionInformation">http://vocab.datex.org/terms#RoadSurfaceConditionInformation</seealso>
    let RoadSurfaceConditionInformation =
        Prefixed_Name(datex, "RoadSurfaceConditionInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadSurfaceConditionInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadSurfaceConditionInformationExtension">http://vocab.datex.org/terms#roadSurfaceConditionInformationExtension</seealso>
    let roadSurfaceConditionInformationExtension =
        Prefixed_Name(datex, "roadSurfaceConditionInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadSurfaceConditionMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadSurfaceConditionMeasurements">http://vocab.datex.org/terms#roadSurfaceConditionMeasurements</seealso>
    let roadSurfaceConditionMeasurements =
        Prefixed_Name(datex, "roadSurfaceConditionMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadSurfaceConditionMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of the road surface condition which relate specifically to the weather.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadSurfaceConditionMeasurements">http://vocab.datex.org/terms#RoadSurfaceConditionMeasurements</seealso>
    let RoadSurfaceConditionMeasurements =
        Prefixed_Name(datex, "RoadSurfaceConditionMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegFramedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is framed between two other points on the same road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegFramedPoint">http://vocab.datex.org/terms#TpegFramedPoint</seealso>
    let TpegFramedPoint = Prefixed_Name(datex, "TpegFramedPoint") |> PrefixedName
    /// <summary>
    ///   <para>datex:framedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A single non junction point on the road network which is framed between two other specified points on the road network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#framedPoint">http://vocab.datex.org/terms#framedPoint</seealso>
    let framedPoint = Prefixed_Name(datex, "framedPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegNonJunctionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is not a road junction point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegNonJunctionPoint">http://vocab.datex.org/terms#TpegNonJunctionPoint</seealso>
    let TpegNonJunctionPoint =
        Prefixed_Name(datex, "TpegNonJunctionPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location at the up stream end of the section of road which frames the TPEGFramedPoint.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#from">http://vocab.datex.org/terms#from</seealso>
    let from = Prefixed_Name(datex, "from") |> PrefixedName
    /// <summary>
    ///   <para>datex:TpegPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is either a junction point or a non junction point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegPoint">http://vocab.datex.org/terms#TpegPoint</seealso>
    let TpegPoint = Prefixed_Name(datex, "TpegPoint") |> PrefixedName
    /// <summary>
    ///   <para>datex:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location at the down stream end of the section of road which frames the TPEGFramedPoint.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#to">http://vocab.datex.org/terms#to</seealso>
    let to_ = Prefixed_Name(datex, "to") |> PrefixedName
    /// <summary>
    ///   <para>datex:VehicleCountValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of absolute count of vehicles within a specified period of time expressed as non negative integer.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCountValue">http://vocab.datex.org/terms#VehicleCountValue</seealso>
    let VehicleCountValue = Prefixed_Name(datex, "VehicleCountValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measured or calculated absolute count of vehicles within a specified period of time expressed as non negative integer.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCount">http://vocab.datex.org/terms#vehicleCount</seealso>
    let vehicleCount = Prefixed_Name(datex, "vehicleCount") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountValueExtension">http://vocab.datex.org/terms#vehicleCountValueExtension</seealso>
    let vehicleCountValueExtension =
        Prefixed_Name(datex, "vehicleCountValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:changeOfOccupiedSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#changeOfOccupiedSpaces">http://vocab.datex.org/terms#changeOfOccupiedSpaces</seealso>
    let changeOfOccupiedSpaces =
        Prefixed_Name(datex, "changeOfOccupiedSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:countedVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#countedVehicles">http://vocab.datex.org/terms#countedVehicles</seealso>
    let countedVehicles = Prefixed_Name(datex, "countedVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementInterval">http://vocab.datex.org/terms#measurementInterval</seealso>
    let measurementInterval =
        Prefixed_Name(datex, "measurementInterval") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementOrCalcualtionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementOrCalcualtionTime">http://vocab.datex.org/terms#measurementOrCalcualtionTime</seealso>
    let measurementOrCalcualtionTime =
        Prefixed_Name(datex, "measurementOrCalcualtionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfIncomingVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfIncomingVehicles">http://vocab.datex.org/terms#numberOfIncomingVehicles</seealso>
    let numberOfIncomingVehicles =
        Prefixed_Name(datex, "numberOfIncomingVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfOutgoingVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfOutgoingVehicles">http://vocab.datex.org/terms#numberOfOutgoingVehicles</seealso>
    let numberOfOutgoingVehicles =
        Prefixed_Name(datex, "numberOfOutgoingVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value of vehicle flow rate expressed in vehicles per hour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleFlowRate">http://vocab.datex.org/terms#vehicleFlowRate</seealso>
    let vehicleFlowRate = Prefixed_Name(datex, "vehicleFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleFlowValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleFlowValueExtension">http://vocab.datex.org/terms#vehicleFlowValueExtension</seealso>
    let vehicleFlowValueExtension =
        Prefixed_Name(datex, "vehicleFlowValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:obstructingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The obstructing vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#obstructingVehicle">http://vocab.datex.org/terms#obstructingVehicle</seealso>
    let obstructingVehicle = Prefixed_Name(datex, "obstructingVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleObstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleObstructionExtension">http://vocab.datex.org/terms#vehicleObstructionExtension</seealso>
    let vehicleObstructionExtension =
        Prefixed_Name(datex, "vehicleObstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleObstructionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Characterization of an obstruction on the road caused by one or more vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleObstructionType">http://vocab.datex.org/terms#vehicleObstructionType</seealso>
    let vehicleObstructionType =
        Prefixed_Name(datex, "vehicleObstructionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:measuredVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measuredVehicles">http://vocab.datex.org/terms#measuredVehicles</seealso>
    let measuredVehicles = Prefixed_Name(datex, "measuredVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleRateExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleRateExtension">http://vocab.datex.org/terms#vehicleRateExtension</seealso>
    let vehicleRateExtension =
        Prefixed_Name(datex, "vehicleRateExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VersionedReference">http://vocab.datex.org/terms#VersionedReference</seealso>
    let VersionedReference = Prefixed_Name(datex, "VersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:minimumVisibilityDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minimumVisibilityDistance">http://vocab.datex.org/terms#minimumVisibilityDistance</seealso>
    let minimumVisibilityDistance =
        Prefixed_Name(datex, "minimumVisibilityDistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleWidth">http://vocab.datex.org/terms#vehicleWidth</seealso>
    let vehicleWidth = Prefixed_Name(datex, "vehicleWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:widthCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#widthCharacteristicExtension">http://vocab.datex.org/terms#widthCharacteristicExtension</seealso>
    let widthCharacteristicExtension =
        Prefixed_Name(datex, "widthCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumWindSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumWindSpeed">http://vocab.datex.org/terms#maximumWindSpeed</seealso>
    let maximumWindSpeed = Prefixed_Name(datex, "maximumWindSpeed") |> PrefixedName

    /// <summary>
    ///   <para>datex:windDirectionBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windDirectionBearing">http://vocab.datex.org/terms#windDirectionBearing</seealso>
    let windDirectionBearing =
        Prefixed_Name(datex, "windDirectionBearing") |> PrefixedName

    /// <summary>
    ///   <para>datex:CctvCamerasFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CctvCamerasFault">http://vocab.datex.org/terms#CctvCamerasFault</seealso>
    let CctvCamerasFault = Prefixed_Name(datex, "CctvCamerasFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:ClearanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ClearanceWork">http://vocab.datex.org/terms#ClearanceWork</seealso>
    let ClearanceWork = Prefixed_Name(datex, "ClearanceWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:Collision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Collision">http://vocab.datex.org/terms#Collision</seealso>
    let Collision = Prefixed_Name(datex, "Collision") |> PrefixedName

    /// <summary>
    ///   <para>datex:CollisionWithPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CollisionWithPerson">http://vocab.datex.org/terms#CollisionWithPerson</seealso>
    let CollisionWithPerson =
        Prefixed_Name(datex, "CollisionWithPerson") |> PrefixedName

    /// <summary>
    ///   <para>datex:Convoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Convoy">http://vocab.datex.org/terms#Convoy</seealso>
    let Convoy = Prefixed_Name(datex, "Convoy") |> PrefixedName
    /// <summary>
    ///   <para>datex:ConvoyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ConvoyService">http://vocab.datex.org/terms#ConvoyService</seealso>
    let ConvoyService = Prefixed_Name(datex, "ConvoyService") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedBridge">http://vocab.datex.org/terms#DamagedBridge</seealso>
    let DamagedBridge = Prefixed_Name(datex, "DamagedBridge") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedGallery">http://vocab.datex.org/terms#DamagedGallery</seealso>
    let DamagedGallery = Prefixed_Name(datex, "DamagedGallery") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedRoadSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedRoadSurface">http://vocab.datex.org/terms#DamagedRoadSurface</seealso>
    let DamagedRoadSurface = Prefixed_Name(datex, "DamagedRoadSurface") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagingHail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagingHail">http://vocab.datex.org/terms#DamagingHail</seealso>
    let DamagingHail = Prefixed_Name(datex, "DamagingHail") |> PrefixedName
    /// <summary>
    ///   <para>datex:Demonstration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Demonstration">http://vocab.datex.org/terms#Demonstration</seealso>
    let Demonstration = Prefixed_Name(datex, "Demonstration") |> PrefixedName

    /// <summary>
    ///   <para>datex:DieselOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DieselOnInfrastructure">http://vocab.datex.org/terms#DieselOnInfrastructure</seealso>
    let DieselOnInfrastructure =
        Prefixed_Name(datex, "DieselOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:EarthquakeDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EarthquakeDamage">http://vocab.datex.org/terms#EarthquakeDamage</seealso>
    let EarthquakeDamage = Prefixed_Name(datex, "EarthquakeDamage") |> PrefixedName
    /// <summary>
    ///   <para>datex:EmergencyVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EmergencyVehicle">http://vocab.datex.org/terms#EmergencyVehicle</seealso>
    let EmergencyVehicle = Prefixed_Name(datex, "EmergencyVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:ExtremeHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ExtremeHeat">http://vocab.datex.org/terms#ExtremeHeat</seealso>
    let ExtremeHeat = Prefixed_Name(datex, "ExtremeHeat") |> PrefixedName
    /// <summary>
    ///   <para>datex:Fair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Fair">http://vocab.datex.org/terms#Fair</seealso>
    let Fair = Prefixed_Name(datex, "Fair") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCAreaExtension">http://vocab.datex.org/terms#alertCAreaExtension</seealso>
    let alertCAreaExtension =
        Prefixed_Name(datex, "alertCAreaExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLocationTableNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocationTableNumber">http://vocab.datex.org/terms#alertCLocationTableNumber</seealso>
    let alertCLocationTableNumber =
        Prefixed_Name(datex, "alertCLocationTableNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identification of a specific point, linear or area location in an ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCLocation">http://vocab.datex.org/terms#AlertCLocation</seealso>
    let AlertCLocation = Prefixed_Name(datex, "AlertCLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:routeDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Destination of a route or final location in an itinerary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#routeDestination">http://vocab.datex.org/terms#routeDestination</seealso>
    let routeDestination = Prefixed_Name(datex, "routeDestination") |> PrefixedName

    /// <summary>
    ///   <para>datex:ItineraryByIndexedLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ItineraryByIndexedLocations">http://vocab.datex.org/terms#ItineraryByIndexedLocations</seealso>
    let ItineraryByIndexedLocations =
        Prefixed_Name(datex, "ItineraryByIndexedLocations") |> PrefixedName

    /// <summary>
    ///   <para>datex:itineraryByIndexedLocationsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#itineraryByIndexedLocationsExtension">http://vocab.datex.org/terms#itineraryByIndexedLocationsExtension</seealso>
    let itineraryByIndexedLocationsExtension =
        Prefixed_Name(datex, "itineraryByIndexedLocationsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrExtendedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension class for OpenLR point.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrExtendedPoint">http://vocab.datex.org/terms#OpenlrExtendedPoint</seealso>
    let OpenlrExtendedPoint =
        Prefixed_Name(datex, "OpenlrExtendedPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPointLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPointLocationReference">http://vocab.datex.org/terms#openlrPointLocationReference</seealso>
    let openlrPointLocationReference =
        Prefixed_Name(datex, "openlrPointLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteExtension">http://vocab.datex.org/terms#parkingSiteExtension</seealso>
    let parkingSiteExtension =
        Prefixed_Name(datex, "parkingSiteExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStandardsAndSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStandardsAndSecurity">http://vocab.datex.org/terms#parkingStandardsAndSecurity</seealso>
    let parkingStandardsAndSecurity =
        Prefixed_Name(datex, "parkingStandardsAndSecurity") |> PrefixedName

    /// <summary>
    ///   <para>datex:pointByCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointByCoordinates">http://vocab.datex.org/terms#pointByCoordinates</seealso>
    let pointByCoordinates = Prefixed_Name(datex, "pointByCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>datex:PointByCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point defined only by a coordinate set with an optional bearing direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PointByCoordinates">http://vocab.datex.org/terms#PointByCoordinates</seealso>
    let PointByCoordinates = Prefixed_Name(datex, "PointByCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>datex:pointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pointExtension">http://vocab.datex.org/terms#pointExtension</seealso>
    let pointExtension = Prefixed_Name(datex, "pointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PointExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PointExtensionType">http://vocab.datex.org/terms#_PointExtensionType</seealso>
    let _PointExtensionType =
        Prefixed_Name(datex, "_PointExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionBoundAtPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionBoundAtPoint">http://vocab.datex.org/terms#directionBoundAtPoint</seealso>
    let directionBoundAtPoint =
        Prefixed_Name(datex, "directionBoundAtPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionRelativeAtPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionRelativeAtPoint">http://vocab.datex.org/terms#directionRelativeAtPoint</seealso>
    let directionRelativeAtPoint =
        Prefixed_Name(datex, "directionRelativeAtPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOrCarriagewayOrLaneManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementExtension">http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementExtension</seealso>
    let roadOrCarriagewayOrLaneManagementExtension =
        Prefixed_Name(datex, "roadOrCarriagewayOrLaneManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOrCarriagewayOrLaneManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of road, carriageway or lane management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementType">http://vocab.datex.org/terms#roadOrCarriagewayOrLaneManagementType</seealso>
    let roadOrCarriagewayOrLaneManagementType =
        Prefixed_Name(datex, "roadOrCarriagewayOrLaneManagementType") |> PrefixedName

    /// <summary>
    ///   <para>datex:textLuminanceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textLuminanceLevel">http://vocab.datex.org/terms#textLuminanceLevel</seealso>
    let textLuminanceLevel = Prefixed_Name(datex, "textLuminanceLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:textLuminanceLevelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textLuminanceLevelName">http://vocab.datex.org/terms#textLuminanceLevelName</seealso>
    let textLuminanceLevelName =
        Prefixed_Name(datex, "textLuminanceLevelName") |> PrefixedName

    /// <summary>
    ///   <para>datex:endTimeOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>End of time period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#endTimeOfPeriod">http://vocab.datex.org/terms#endTimeOfPeriod</seealso>
    let endTimeOfPeriod = Prefixed_Name(datex, "endTimeOfPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:startTimeOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Start of time period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#startTimeOfPeriod">http://vocab.datex.org/terms#startTimeOfPeriod</seealso>
    let startTimeOfPeriod = Prefixed_Name(datex, "startTimeOfPeriod") |> PrefixedName

    /// <summary>
    ///   <para>datex:timePeriodByHourExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timePeriodByHourExtension">http://vocab.datex.org/terms#timePeriodByHourExtension</seealso>
    let timePeriodByHourExtension =
        Prefixed_Name(datex, "timePeriodByHourExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measuredValueIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measuredValueIndex">http://vocab.datex.org/terms#measuredValueIndex</seealso>
    let measuredValueIndex = Prefixed_Name(datex, "measuredValueIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:keyFilterReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#keyFilterReference">http://vocab.datex.org/terms#keyFilterReference</seealso>
    let keyFilterReference = Prefixed_Name(datex, "keyFilterReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:FloatingPointMetreDistanceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of distance in metres in a floating point format.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FloatingPointMetreDistanceValue">http://vocab.datex.org/terms#FloatingPointMetreDistanceValue</seealso>
    let FloatingPointMetreDistanceValue =
        Prefixed_Name(datex, "FloatingPointMetreDistanceValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:floatingPointMetreDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of distance expressed in metres in a floating point format.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#floatingPointMetreDistance">http://vocab.datex.org/terms#floatingPointMetreDistance</seealso>
    let floatingPointMetreDistance =
        Prefixed_Name(datex, "floatingPointMetreDistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The measured distance between the front (respectively back) of this vehicle and the front (respectively  back) of the preceding vehicle at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceHeadway">http://vocab.datex.org/terms#distanceHeadway</seealso>
    let distanceHeadway = Prefixed_Name(datex, "distanceHeadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:individualVehicleDataValuesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#individualVehicleDataValuesExtension">http://vocab.datex.org/terms#individualVehicleDataValuesExtension</seealso>
    let individualVehicleDataValuesExtension =
        Prefixed_Name(datex, "individualVehicleDataValuesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPositiveOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPositiveOffset">http://vocab.datex.org/terms#openlrPositiveOffset</seealso>
    let openlrPositiveOffset =
        Prefixed_Name(datex, "openlrPositiveOffset") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordStatusExtension">http://vocab.datex.org/terms#parkingRecordStatusExtension</seealso>
    let parkingRecordStatusExtension =
        Prefixed_Name(datex, "parkingRecordStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusDescription">http://vocab.datex.org/terms#parkingStatusDescription</seealso>
    let parkingStatusDescription =
        Prefixed_Name(datex, "parkingStatusDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:referentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referentDescription">http://vocab.datex.org/terms#referentDescription</seealso>
    let referentDescription =
        Prefixed_Name(datex, "referentDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:referentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referentExtension">http://vocab.datex.org/terms#referentExtension</seealso>
    let referentExtension = Prefixed_Name(datex, "referentExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:referentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referentIdentifier">http://vocab.datex.org/terms#referentIdentifier</seealso>
    let referentIdentifier = Prefixed_Name(datex, "referentIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>datex:referentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referentType">http://vocab.datex.org/terms#referentType</seealso>
    let referentType = Prefixed_Name(datex, "referentType") |> PrefixedName
    /// <summary>
    ///   <para>datex:locationDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationDescriptor">http://vocab.datex.org/terms#locationDescriptor</seealso>
    let locationDescriptor = Prefixed_Name(datex, "locationDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:sequentialRampNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sequentialRampNumber">http://vocab.datex.org/terms#sequentialRampNumber</seealso>
    let sequentialRampNumber =
        Prefixed_Name(datex, "sequentialRampNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:overrunning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overrunning">http://vocab.datex.org/terms#overrunning</seealso>
    let overrunning = Prefixed_Name(datex, "overrunning") |> PrefixedName
    /// <summary>
    ///   <para>datex:validityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validityExtension">http://vocab.datex.org/terms#validityExtension</seealso>
    let validityExtension = Prefixed_Name(datex, "validityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryMessageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryMessageDescription">http://vocab.datex.org/terms#supplementaryMessageDescription</seealso>
    let supplementaryMessageDescription =
        Prefixed_Name(datex, "supplementaryMessageDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPanelExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPanelExtension">http://vocab.datex.org/terms#vmsSupplementaryPanelExtension</seealso>
    let vmsSupplementaryPanelExtension =
        Prefixed_Name(datex, "vmsSupplementaryPanelExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPictogram">http://vocab.datex.org/terms#vmsSupplementaryPictogram</seealso>
    let vmsSupplementaryPictogram =
        Prefixed_Name(datex, "vmsSupplementaryPictogram") |> PrefixedName

    /// <summary>
    ///   <para>datex:CollisionWithObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CollisionWithObstruction">http://vocab.datex.org/terms#CollisionWithObstruction</seealso>
    let CollisionWithObstruction =
        Prefixed_Name(datex, "CollisionWithObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:Conditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Any conditions which have the potential to degrade normal driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Conditions">http://vocab.datex.org/terms#Conditions</seealso>
    let Conditions = Prefixed_Name(datex, "Conditions") |> PrefixedName
    /// <summary>
    ///   <para>datex:accidentCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A descriptor indicating the most significant factor causing an accident.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accidentCause">http://vocab.datex.org/terms#accidentCause</seealso>
    let accidentCause = Prefixed_Name(datex, "accidentCause") |> PrefixedName
    /// <summary>
    ///   <para>datex:accidentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accidentExtension">http://vocab.datex.org/terms#accidentExtension</seealso>
    let accidentExtension = Prefixed_Name(datex, "accidentExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:accidentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A characterization of the nature of the accident.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accidentType">http://vocab.datex.org/terms#accidentType</seealso>
    let accidentType = Prefixed_Name(datex, "accidentType") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfPeopleInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfPeopleInvolved">http://vocab.datex.org/terms#groupOfPeopleInvolved</seealso>
    let groupOfPeopleInvolved =
        Prefixed_Name(datex, "groupOfPeopleInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfPeopleInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Group of people involved in the event having common characteristics and/or status.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfPeopleInvolved">http://vocab.datex.org/terms#GroupOfPeopleInvolved</seealso>
    let GroupOfPeopleInvolved =
        Prefixed_Name(datex, "GroupOfPeopleInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfVehiclesInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Group of the vehicles involved having common characteristics and/or status.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfVehiclesInvolved">http://vocab.datex.org/terms#GroupOfVehiclesInvolved</seealso>
    let GroupOfVehiclesInvolved =
        Prefixed_Name(datex, "GroupOfVehiclesInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:totalNumberOfVehiclesInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total number of vehicles that are involved.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#totalNumberOfVehiclesInvolved">http://vocab.datex.org/terms#totalNumberOfVehiclesInvolved</seealso>
    let totalNumberOfVehiclesInvolved =
        Prefixed_Name(datex, "totalNumberOfVehiclesInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:activityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#activityExtension">http://vocab.datex.org/terms#activityExtension</seealso>
    let activityExtension = Prefixed_Name(datex, "activityExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:mobilityOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Mobility of the activity.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mobilityOfActivity">http://vocab.datex.org/terms#mobilityOfActivity</seealso>
    let mobilityOfActivity = Prefixed_Name(datex, "mobilityOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>datex:Mobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Mobility">http://vocab.datex.org/terms#Mobility</seealso>
    let Mobility = Prefixed_Name(datex, "Mobility") |> PrefixedName

    /// <summary>
    ///   <para>datex:AffectedCarriagewayAndLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AffectedCarriagewayAndLanes">http://vocab.datex.org/terms#AffectedCarriagewayAndLanes</seealso>
    let AffectedCarriagewayAndLanes =
        Prefixed_Name(datex, "AffectedCarriagewayAndLanes") |> PrefixedName

    /// <summary>
    ///   <para>datex:lane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lane">http://vocab.datex.org/terms#lane</seealso>
    let lane = Prefixed_Name(datex, "lane") |> PrefixedName
    /// <summary>
    ///   <para>datex:namedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#namedArea">http://vocab.datex.org/terms#namedArea</seealso>
    let namedArea = Prefixed_Name(datex, "namedArea") |> PrefixedName
    /// <summary>
    ///   <para>datex:NamedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NamedArea">http://vocab.datex.org/terms#NamedArea</seealso>
    let NamedArea = Prefixed_Name(datex, "NamedArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:destinationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#destinationExtension">http://vocab.datex.org/terms#destinationExtension</seealso>
    let destinationExtension =
        Prefixed_Name(datex, "destinationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A component that provides dimension information. The product of width and height must not be necessarily be the square footage (e.g. in multi-storey buildings or when some zones are not part of the square footage).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Dimension">http://vocab.datex.org/terms#Dimension</seealso>
    let Dimension = Prefixed_Name(datex, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>datex:dimensionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionExtension">http://vocab.datex.org/terms#dimensionExtension</seealso>
    let dimensionExtension = Prefixed_Name(datex, "dimensionExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:dimensionLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionLength">http://vocab.datex.org/terms#dimensionLength</seealso>
    let dimensionLength = Prefixed_Name(datex, "dimensionLength") |> PrefixedName

    /// <summary>
    ///   <para>datex:dimensionUsableArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionUsableArea">http://vocab.datex.org/terms#dimensionUsableArea</seealso>
    let dimensionUsableArea =
        Prefixed_Name(datex, "dimensionUsableArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:DirectionBearingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of direction as a bearing.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DirectionBearingValue">http://vocab.datex.org/terms#DirectionBearingValue</seealso>
    let DirectionBearingValue =
        Prefixed_Name(datex, "DirectionBearingValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of direction expressed in terms of a bearing measured in whole degrees. Unless otherwise specified the reference direction corresponding to 0 degrees is North.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionBearing">http://vocab.datex.org/terms#directionBearing</seealso>
    let directionBearing = Prefixed_Name(datex, "directionBearing") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionBearingValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionBearingValueExtension">http://vocab.datex.org/terms#directionBearingValueExtension</seealso>
    let directionBearingValueExtension =
        Prefixed_Name(datex, "directionBearingValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:DirectionCompassValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of direction as a point of the compass.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DirectionCompassValue">http://vocab.datex.org/terms#DirectionCompassValue</seealso>
    let DirectionCompassValue =
        Prefixed_Name(datex, "DirectionCompassValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:directionCompass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of direction expressed in terms of points of the compass.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#directionCompass">http://vocab.datex.org/terms#directionCompass</seealso>
    let directionCompass = Prefixed_Name(datex, "directionCompass") |> PrefixedName

    /// <summary>
    ///   <para>datex:DistanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DistanceAlongLinearElement">http://vocab.datex.org/terms#DistanceAlongLinearElement</seealso>
    let DistanceAlongLinearElement =
        Prefixed_Name(datex, "DistanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceAlongLinearElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceAlongLinearElementExtension">http://vocab.datex.org/terms#distanceAlongLinearElementExtension</seealso>
    let distanceAlongLinearElementExtension =
        Prefixed_Name(datex, "distanceAlongLinearElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:DistanceFromLinearElementReferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DistanceFromLinearElementReferent">http://vocab.datex.org/terms#DistanceFromLinearElementReferent</seealso>
    let DistanceFromLinearElementReferent =
        Prefixed_Name(datex, "DistanceFromLinearElementReferent") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceAlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measure of distance along a linear element.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceAlong">http://vocab.datex.org/terms#distanceAlong</seealso>
    let distanceAlong = Prefixed_Name(datex, "distanceAlong") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromLinearElementReferentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromLinearElementReferentExtension">http://vocab.datex.org/terms#distanceFromLinearElementReferentExtension</seealso>
    let distanceFromLinearElementReferentExtension =
        Prefixed_Name(datex, "distanceFromLinearElementReferentExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:fromReferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in ISO 19148. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fromReferent">http://vocab.datex.org/terms#fromReferent</seealso>
    let fromReferent = Prefixed_Name(datex, "fromReferent") |> PrefixedName
    /// <summary>
    ///   <para>datex:Referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A referent on a linear object that has a known location such as a node, a reference marker (e.g. a markerpost), an intersection etc.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Referent">http://vocab.datex.org/terms#Referent</seealso>
    let Referent = Prefixed_Name(datex, "Referent") |> PrefixedName
    /// <summary>
    ///   <para>datex:towardsReferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in ISO 19148.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#towardsReferent">http://vocab.datex.org/terms#towardsReferent</seealso>
    let towardsReferent = Prefixed_Name(datex, "towardsReferent") |> PrefixedName

    /// <summary>
    ///   <para>datex:DistanceFromLinearElementStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DistanceFromLinearElementStart">http://vocab.datex.org/terms#DistanceFromLinearElementStart</seealso>
    let DistanceFromLinearElementStart =
        Prefixed_Name(datex, "DistanceFromLinearElementStart") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceFromLinearElementStartExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceFromLinearElementStartExtension">http://vocab.datex.org/terms#distanceFromLinearElementStartExtension</seealso>
    let distanceFromLinearElementStartExtension =
        Prefixed_Name(datex, "distanceFromLinearElementStartExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumParkingSpaceDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Dimension of the largest space within this group (i.e. there must be at least one space of this dimension). If the comparison of dimension values is not unique, the length is decisive.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumParkingSpaceDimension">http://vocab.datex.org/terms#maximumParkingSpaceDimension</seealso>
    let maximumParkingSpaceDimension =
        Prefixed_Name(datex, "maximumParkingSpaceDimension") |> PrefixedName

    /// <summary>
    ///   <para>datex:minimumParkingSpaceDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lower dimension boundaries for all spaces within the group. Note that there must not exist a space with this dimension, but each space's dimension values must be equal or higher.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minimumParkingSpaceDimension">http://vocab.datex.org/terms#minimumParkingSpaceDimension</seealso>
    let minimumParkingSpaceDimension =
        Prefixed_Name(datex, "minimumParkingSpaceDimension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of parking spaces (attribute is used for a parking record as well as for a group of parking spaces).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfSpaces">http://vocab.datex.org/terms#parkingNumberOfSpaces</seealso>
    let parkingNumberOfSpaces =
        Prefixed_Name(datex, "parkingNumberOfSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpace">http://vocab.datex.org/terms#parkingSpace</seealso>
    let parkingSpace = Prefixed_Name(datex, "parkingSpace") |> PrefixedName

    /// <summary>
    ///   <para>datex:_GroupOfParkingSpacesParkingSpaceIndexParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_GroupOfParkingSpacesParkingSpaceIndexParkingSpace">http://vocab.datex.org/terms#_GroupOfParkingSpacesParkingSpaceIndexParkingSpace</seealso>
    let _GroupOfParkingSpacesParkingSpaceIndexParkingSpace =
        Prefixed_Name(datex, "_GroupOfParkingSpacesParkingSpaceIndexParkingSpace") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTypeOfGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the type of this group specification.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTypeOfGroup">http://vocab.datex.org/terms#parkingTypeOfGroup</seealso>
    let parkingTypeOfGroup = Prefixed_Name(datex, "parkingTypeOfGroup") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingSpaceBasics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Common properties of parking spaces and groups of parking spaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingSpaceBasics">http://vocab.datex.org/terms#ParkingSpaceBasics</seealso>
    let ParkingSpaceBasics = Prefixed_Name(datex, "ParkingSpaceBasics") |> PrefixedName

    /// <summary>
    ///   <para>datex:GroupOfParkingSpacesStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of the assigned parking spaces in the specified parking site, i.e. the status of those spaces assigned for particular types of person or vehicle and/or for specific duration types (e.g. short stay).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfParkingSpacesStatus">http://vocab.datex.org/terms#GroupOfParkingSpacesStatus</seealso>
    let GroupOfParkingSpacesStatus =
        Prefixed_Name(datex, "GroupOfParkingSpacesStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupDeclarationValidNow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Override validity of AssignedParkingSpaces: True = Parking space declaration is valid now; False = Parking space declaration is invalid now; Omitted = Static validity information is significant (if static validity is omitted too, declaration is valid).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupDeclarationValidNow">http://vocab.datex.org/terms#groupDeclarationValidNow</seealso>
    let groupDeclarationValidNow =
        Prefixed_Name(datex, "groupDeclarationValidNow") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpacesClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>True: The group of parking spaces is closed / not accessible. False or omitted: The group of parking spaces is accessible. This is no statement about its occupation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpacesClosed">http://vocab.datex.org/terms#groupOfParkingSpacesClosed</seealso>
    let groupOfParkingSpacesClosed =
        Prefixed_Name(datex, "groupOfParkingSpacesClosed") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearWithinLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearWithinLinearElement">http://vocab.datex.org/terms#linearWithinLinearElement</seealso>
    let linearWithinLinearElement =
        Prefixed_Name(datex, "linearWithinLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:LinearWithinLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LinearWithinLinearElement">http://vocab.datex.org/terms#LinearWithinLinearElement</seealso>
    let LinearWithinLinearElement =
        Prefixed_Name(datex, "LinearWithinLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegLinearLocation">http://vocab.datex.org/terms#tpegLinearLocation</seealso>
    let tpegLinearLocation = Prefixed_Name(datex, "tpegLinearLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:TpegLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegLinearLocation">http://vocab.datex.org/terms#TpegLinearLocation</seealso>
    let TpegLinearLocation = Prefixed_Name(datex, "TpegLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementExtension">http://vocab.datex.org/terms#linearElementExtension</seealso>
    let linearElementExtension =
        Prefixed_Name(datex, "linearElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementNature">http://vocab.datex.org/terms#linearElementNature</seealso>
    let linearElementNature =
        Prefixed_Name(datex, "linearElementNature") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementReferenceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementReferenceModel">http://vocab.datex.org/terms#linearElementReferenceModel</seealso>
    let linearElementReferenceModel =
        Prefixed_Name(datex, "linearElementReferenceModel") |> PrefixedName

    /// <summary>
    ///   <para>datex:linearElementReferenceModelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearElementReferenceModelVersion">http://vocab.datex.org/terms#linearElementReferenceModelVersion</seealso>
    let linearElementReferenceModelVersion =
        Prefixed_Name(datex, "linearElementReferenceModelVersion") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadName">http://vocab.datex.org/terms#roadName</seealso>
    let roadName = Prefixed_Name(datex, "roadName") |> PrefixedName
    /// <summary>
    ///   <para>datex:causeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates an external influence that may be the causation of components of a situation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#causeType">http://vocab.datex.org/terms#causeType</seealso>
    let causeType = Prefixed_Name(datex, "causeType") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonManagedCauseExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonManagedCauseExtension">http://vocab.datex.org/terms#nonManagedCauseExtension</seealso>
    let nonManagedCauseExtension =
        Prefixed_Name(datex, "nonManagedCauseExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonOrderedLocationGroupByList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of (i.e. more than one) physically separate locations which have no specific order and where each location is explicitly listed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonOrderedLocationGroupByList">http://vocab.datex.org/terms#NonOrderedLocationGroupByList</seealso>
    let NonOrderedLocationGroupByList =
        Prefixed_Name(datex, "NonOrderedLocationGroupByList") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationContainedInGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A location contained in a non ordered group of locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationContainedInGroup">http://vocab.datex.org/terms#locationContainedInGroup</seealso>
    let locationContainedInGroup =
        Prefixed_Name(datex, "locationContainedInGroup") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingDuration">http://vocab.datex.org/terms#parkingDuration</seealso>
    let parkingDuration = Prefixed_Name(datex, "parkingDuration") |> PrefixedName
    /// <summary>
    ///   <para>datex:timePeriodByHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timePeriodByHour">http://vocab.datex.org/terms#timePeriodByHour</seealso>
    let timePeriodByHour = Prefixed_Name(datex, "timePeriodByHour") |> PrefixedName
    /// <summary>
    ///   <para>datex:TimePeriodByHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of a continuous period within a 24 hour period by times.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TimePeriodByHour">http://vocab.datex.org/terms#TimePeriodByHour</seealso>
    let TimePeriodByHour = Prefixed_Name(datex, "TimePeriodByHour") |> PrefixedName
    /// <summary>
    ///   <para>datex:measuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measuredValue">http://vocab.datex.org/terms#measuredValue</seealso>
    let measuredValue = Prefixed_Name(datex, "measuredValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:_SiteMeasurementsIndexMeasuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_SiteMeasurementsIndexMeasuredValue">http://vocab.datex.org/terms#_SiteMeasurementsIndexMeasuredValue</seealso>
    let _SiteMeasurementsIndexMeasuredValue =
        Prefixed_Name(datex, "_SiteMeasurementsIndexMeasuredValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteReference">http://vocab.datex.org/terms#measurementSiteReference</seealso>
    let measurementSiteReference =
        Prefixed_Name(datex, "measurementSiteReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_MeasurementSiteRecordVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_MeasurementSiteRecordVersionedReference">http://vocab.datex.org/terms#_MeasurementSiteRecordVersionedReference</seealso>
    let _MeasurementSiteRecordVersionedReference =
        Prefixed_Name(datex, "_MeasurementSiteRecordVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementTimeDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementTimeDefault">http://vocab.datex.org/terms#measurementTimeDefault</seealso>
    let measurementTimeDefault =
        Prefixed_Name(datex, "measurementTimeDefault") |> PrefixedName

    /// <summary>
    ///   <para>datex:siteMeasurementsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#siteMeasurementsExtension">http://vocab.datex.org/terms#siteMeasurementsExtension</seealso>
    let siteMeasurementsExtension =
        Prefixed_Name(datex, "siteMeasurementsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Situation">http://vocab.datex.org/terms#Situation</seealso>
    let Situation = Prefixed_Name(datex, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>datex:situationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationExtension">http://vocab.datex.org/terms#situationExtension</seealso>
    let situationExtension = Prefixed_Name(datex, "situationExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:situationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecord">http://vocab.datex.org/terms#situationRecord</seealso>
    let situationRecord = Prefixed_Name(datex, "situationRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationVersionTime">http://vocab.datex.org/terms#situationVersionTime</seealso>
    let situationVersionTime =
        Prefixed_Name(datex, "situationVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:SituationPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing zero or more traffic/travel situations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SituationPublication">http://vocab.datex.org/terms#SituationPublication</seealso>
    let SituationPublication =
        Prefixed_Name(datex, "SituationPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situation">http://vocab.datex.org/terms#situation</seealso>
    let situation = Prefixed_Name(datex, "situation") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of traffic conditions on a specific section or at a specific point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficStatus">http://vocab.datex.org/terms#TrafficStatus</seealso>
    let TrafficStatus = Prefixed_Name(datex, "TrafficStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:trafficStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Status of traffic conditions on the identified section of road in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficStatus">http://vocab.datex.org/terms#trafficStatus</seealso>
    let trafficStatus = Prefixed_Name(datex, "trafficStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficStatusValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the status of traffic conditions on a section of road in a specified direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficStatusValue">http://vocab.datex.org/terms#TrafficStatusValue</seealso>
    let TrafficStatusValue = Prefixed_Name(datex, "TrafficStatusValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficStatusExtension">http://vocab.datex.org/terms#trafficStatusExtension</seealso>
    let trafficStatusExtension =
        Prefixed_Name(datex, "trafficStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficStatusValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A status value of traffic conditions on the identified section of road in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficStatusValue">http://vocab.datex.org/terms#trafficStatusValue</seealso>
    let trafficStatusValue = Prefixed_Name(datex, "trafficStatusValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficStatusValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficStatusValueExtension">http://vocab.datex.org/terms#trafficStatusValueExtension</seealso>
    let trafficStatusValueExtension =
        Prefixed_Name(datex, "trafficStatusValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable instance of a traffic view at a single point in time relating to a predefined location set, comprising one or more linear traffic views each of which comprise one or more traffic view records.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficView">http://vocab.datex.org/terms#TrafficView</seealso>
    let TrafficView = Prefixed_Name(datex, "TrafficView") |> PrefixedName
    /// <summary>
    ///   <para>datex:linearTrafficView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#linearTrafficView">http://vocab.datex.org/terms#linearTrafficView</seealso>
    let linearTrafficView = Prefixed_Name(datex, "linearTrafficView") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficViewExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficViewExtension">http://vocab.datex.org/terms#trafficViewExtension</seealso>
    let trafficViewExtension =
        Prefixed_Name(datex, "trafficViewExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficViewTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficViewTime">http://vocab.datex.org/terms#trafficViewTime</seealso>
    let trafficViewTime = Prefixed_Name(datex, "trafficViewTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficViewPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more traffic views.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficViewPublication">http://vocab.datex.org/terms#TrafficViewPublication</seealso>
    let TrafficViewPublication =
        Prefixed_Name(datex, "TrafficViewPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:operatorAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operatorAction">http://vocab.datex.org/terms#operatorAction</seealso>
    let operatorAction = Prefixed_Name(datex, "operatorAction") |> PrefixedName

    /// <summary>
    ///   <para>datex:recordSequenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#recordSequenceNumber">http://vocab.datex.org/terms#recordSequenceNumber</seealso>
    let recordSequenceNumber =
        Prefixed_Name(datex, "recordSequenceNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficElement">http://vocab.datex.org/terms#trafficElement</seealso>
    let trafficElement = Prefixed_Name(datex, "trafficElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficViewRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficViewRecordExtension">http://vocab.datex.org/terms#trafficViewRecordExtension</seealso>
    let trafficViewRecordExtension =
        Prefixed_Name(datex, "trafficViewRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsPictogramDisplayArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area on a VMS used for the display of pictograms and associated supplemental information or instructions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsPictogramDisplayArea">http://vocab.datex.org/terms#VmsPictogramDisplayArea</seealso>
    let VmsPictogramDisplayArea =
        Prefixed_Name(datex, "VmsPictogramDisplayArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:synchronizedSequencingWithTextPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#synchronizedSequencingWithTextPages">http://vocab.datex.org/terms#synchronizedSequencingWithTextPages</seealso>
    let synchronizedSequencingWithTextPages =
        Prefixed_Name(datex, "synchronizedSequencingWithTextPages") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogram">http://vocab.datex.org/terms#vmsPictogram</seealso>
    let vmsPictogram = Prefixed_Name(datex, "vmsPictogram") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram">http://vocab.datex.org/terms#_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram</seealso>
    let _VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram =
        Prefixed_Name(datex, "_VmsPictogramDisplayAreaPictogramSequencingIndexVmsPictogram") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramPixelsAcross</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPixelsAcross">http://vocab.datex.org/terms#pictogramPixelsAcross</seealso>
    let pictogramPixelsAcross =
        Prefixed_Name(datex, "pictogramPixelsAcross") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramPixelsDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPixelsDown">http://vocab.datex.org/terms#pictogramPixelsDown</seealso>
    let pictogramPixelsDown =
        Prefixed_Name(datex, "pictogramPixelsDown") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramPositionAbsolute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPositionAbsolute">http://vocab.datex.org/terms#pictogramPositionAbsolute</seealso>
    let pictogramPositionAbsolute =
        Prefixed_Name(datex, "pictogramPositionAbsolute") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramPositionRelativeToText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPositionRelativeToText">http://vocab.datex.org/terms#pictogramPositionRelativeToText</seealso>
    let pictogramPositionRelativeToText =
        Prefixed_Name(datex, "pictogramPositionRelativeToText") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramPositionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPositionX">http://vocab.datex.org/terms#pictogramPositionX</seealso>
    let pictogramPositionX = Prefixed_Name(datex, "pictogramPositionX") |> PrefixedName
    /// <summary>
    ///   <para>datex:pictogramPositionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramPositionY">http://vocab.datex.org/terms#pictogramPositionY</seealso>
    let pictogramPositionY = Prefixed_Name(datex, "pictogramPositionY") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramSequencingCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramSequencingCapable">http://vocab.datex.org/terms#pictogramSequencingCapable</seealso>
    let pictogramSequencingCapable =
        Prefixed_Name(datex, "pictogramSequencingCapable") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPictogramDisplayCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristicsExtension">http://vocab.datex.org/terms#vmsPictogramDisplayCharacteristicsExtension</seealso>
    let vmsPictogramDisplayCharacteristicsExtension =
        Prefixed_Name(datex, "vmsPictogramDisplayCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPanelCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristics">http://vocab.datex.org/terms#vmsSupplementaryPanelCharacteristics</seealso>
    let vmsSupplementaryPanelCharacteristics =
        Prefixed_Name(datex, "vmsSupplementaryPanelCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsSupplementaryPanelCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Characteristics of a panel which may display details (sometimes regulatory in nature) that are supplemental to the main pictogram, comprising an additional line of text and/or a pictogram.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsSupplementaryPanelCharacteristics">http://vocab.datex.org/terms#VmsSupplementaryPanelCharacteristics</seealso>
    let VmsSupplementaryPanelCharacteristics =
        Prefixed_Name(datex, "VmsSupplementaryPanelCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:reasonForDataError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reasonForDataError">http://vocab.datex.org/terms#reasonForDataError</seealso>
    let reasonForDataError = Prefixed_Name(datex, "reasonForDataError") |> PrefixedName
    /// <summary>
    ///   <para>datex:faultCreationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultCreationTime">http://vocab.datex.org/terms#faultCreationTime</seealso>
    let faultCreationTime = Prefixed_Name(datex, "faultCreationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:HumidityInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of atmospheric humidity.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HumidityInformation">http://vocab.datex.org/terms#HumidityInformation</seealso>
    let HumidityInformation =
        Prefixed_Name(datex, "HumidityInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:LocationByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location defined by reference to a predefined location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LocationByReference">http://vocab.datex.org/terms#LocationByReference</seealso>
    let LocationByReference =
        Prefixed_Name(datex, "LocationByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:entranceFull</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#entranceFull">http://vocab.datex.org/terms#entranceFull</seealso>
    let entranceFull = Prefixed_Name(datex, "entranceFull") |> PrefixedName
    /// <summary>
    ///   <para>datex:publicEventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of public event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicEventType">http://vocab.datex.org/terms#publicEventType</seealso>
    let publicEventType = Prefixed_Name(datex, "publicEventType") |> PrefixedName
    /// <summary>
    ///   <para>datex:TravelTimeData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Derived/computed travel time information relating to a linear section of the road network; forecast = true means a forecast for a vehicle at the start of the specified location, forecast = false means calculation/measurement at the end.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TravelTimeData">http://vocab.datex.org/terms#TravelTimeData</seealso>
    let TravelTimeData = Prefixed_Name(datex, "TravelTimeData") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing the current status and settings of one or more VMS units, each unit controlling one or more individual variable message signs.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsPublication">http://vocab.datex.org/terms#VmsPublication</seealso>
    let VmsPublication = Prefixed_Name(datex, "VmsPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsPublicationExtension">http://vocab.datex.org/terms#vmsPublicationExtension</seealso>
    let vmsPublicationExtension =
        Prefixed_Name(datex, "vmsPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnit">http://vocab.datex.org/terms#vmsUnit</seealso>
    let vmsUnit = Prefixed_Name(datex, "vmsUnit") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Status of a VMS unit which may control one or more variable message signs on a single gantry or on different gantries.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsUnit">http://vocab.datex.org/terms#VmsUnit</seealso>
    let VmsUnit = Prefixed_Name(datex, "VmsUnit") |> PrefixedName
    /// <summary>
    ///   <para>datex:Crowd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Crowd">http://vocab.datex.org/terms#Crowd</seealso>
    let Crowd = Prefixed_Name(datex, "Crowd") |> PrefixedName
    /// <summary>
    ///   <para>datex:DamagedGantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedGantry">http://vocab.datex.org/terms#DamagedGantry</seealso>
    let DamagedGantry = Prefixed_Name(datex, "DamagedGantry") |> PrefixedName
    /// <summary>
    ///   <para>datex:carriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carriageway">http://vocab.datex.org/terms#carriageway</seealso>
    let carriageway = Prefixed_Name(datex, "carriageway") |> PrefixedName
    /// <summary>
    ///   <para>datex:AlertCArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by reference to a predefined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCArea">http://vocab.datex.org/terms#AlertCArea</seealso>
    let AlertCArea = Prefixed_Name(datex, "AlertCArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLocationCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocationCountryCode">http://vocab.datex.org/terms#alertCLocationCountryCode</seealso>
    let alertCLocationCountryCode =
        Prefixed_Name(datex, "alertCLocationCountryCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLocationTableVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocationTableVersion">http://vocab.datex.org/terms#alertCLocationTableVersion</seealso>
    let alertCLocationTableVersion =
        Prefixed_Name(datex, "alertCLocationTableVersion") |> PrefixedName

    /// <summary>
    ///   <para>datex:areaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaLocation">http://vocab.datex.org/terms#areaLocation</seealso>
    let areaLocation = Prefixed_Name(datex, "areaLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:pertinentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pertinentLocation">http://vocab.datex.org/terms#pertinentLocation</seealso>
    let pertinentLocation = Prefixed_Name(datex, "pertinentLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:GroupOfLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One or more physically separate locations. Multiple locations may be related, as in an itinerary (or route), or may be unrelated. It is not for identifying the same physical location using different Location objects for different referencing systems.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GroupOfLocations">http://vocab.datex.org/terms#GroupOfLocations</seealso>
    let GroupOfLocations = Prefixed_Name(datex, "GroupOfLocations") |> PrefixedName
    /// <summary>
    ///   <para>datex:junctionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#junctionExtension">http://vocab.datex.org/terms#junctionExtension</seealso>
    let junctionExtension = Prefixed_Name(datex, "junctionExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:motorway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#motorway">http://vocab.datex.org/terms#motorway</seealso>
    let motorway = Prefixed_Name(datex, "motorway") |> PrefixedName

    /// <summary>
    ///   <para>datex:microgramsConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of the amount of a substance in a given volume (concentration) expressed in µg/m3 (microgrammes/cubic metre).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#microgramsConcentration">http://vocab.datex.org/terms#microgramsConcentration</seealso>
    let microgramsConcentration =
        Prefixed_Name(datex, "microgramsConcentration") |> PrefixedName

    /// <summary>
    ///   <para>datex:microgramsConcentrationValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#microgramsConcentrationValueExtension">http://vocab.datex.org/terms#microgramsConcentrationValueExtension</seealso>
    let microgramsConcentrationValueExtension =
        Prefixed_Name(datex, "microgramsConcentrationValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPointAlongLineExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPointAlongLineExtension">http://vocab.datex.org/terms#openlrPointAlongLineExtension</seealso>
    let openlrPointAlongLineExtension =
        Prefixed_Name(datex, "openlrPointAlongLineExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPoiWithAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPoiWithAccessPoint">http://vocab.datex.org/terms#openlrPoiWithAccessPoint</seealso>
    let openlrPoiWithAccessPoint =
        Prefixed_Name(datex, "openlrPoiWithAccessPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPointAlongLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPointAlongLine">http://vocab.datex.org/terms#openlrPointAlongLine</seealso>
    let openlrPointAlongLine =
        Prefixed_Name(datex, "openlrPointAlongLine") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceAccessibility">http://vocab.datex.org/terms#parkingSpaceAccessibility</seealso>
    let parkingSpaceAccessibility =
        Prefixed_Name(datex, "parkingSpaceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceBasicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceBasicsExtension">http://vocab.datex.org/terms#parkingSpaceBasicsExtension</seealso>
    let parkingSpaceBasicsExtension =
        Prefixed_Name(datex, "parkingSpaceBasicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceOrGroupIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceOrGroupIdentifier">http://vocab.datex.org/terms#parkingSpaceOrGroupIdentifier</seealso>
    let parkingSpaceOrGroupIdentifier =
        Prefixed_Name(datex, "parkingSpaceOrGroupIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:pollutionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pollutionExtension">http://vocab.datex.org/terms#pollutionExtension</seealso>
    let pollutionExtension = Prefixed_Name(datex, "pollutionExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:mobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mobility">http://vocab.datex.org/terms#mobility</seealso>
    let mobility = Prefixed_Name(datex, "mobility") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadworksDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates in general terms the expected duration of the roadworks.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadworksDuration">http://vocab.datex.org/terms#roadworksDuration</seealso>
    let roadworksDuration = Prefixed_Name(datex, "roadworksDuration") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadworksExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadworksExtension">http://vocab.datex.org/terms#roadworksExtension</seealso>
    let roadworksExtension = Prefixed_Name(datex, "roadworksExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:visibilityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#visibilityExtension">http://vocab.datex.org/terms#visibilityExtension</seealso>
    let visibilityExtension =
        Prefixed_Name(datex, "visibilityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VisibilityInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of atmospheric visibility.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VisibilityInformation">http://vocab.datex.org/terms#VisibilityInformation</seealso>
    let VisibilityInformation =
        Prefixed_Name(datex, "VisibilityInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:windDirectionCompass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windDirectionCompass">http://vocab.datex.org/terms#windDirectionCompass</seealso>
    let windDirectionCompass =
        Prefixed_Name(datex, "windDirectionCompass") |> PrefixedName

    /// <summary>
    ///   <para>datex:windExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windExtension">http://vocab.datex.org/terms#windExtension</seealso>
    let windExtension = Prefixed_Name(datex, "windExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:windMeasurementHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windMeasurementHeight">http://vocab.datex.org/terms#windMeasurementHeight</seealso>
    let windMeasurementHeight =
        Prefixed_Name(datex, "windMeasurementHeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:windSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windSpeed">http://vocab.datex.org/terms#windSpeed</seealso>
    let windSpeed = Prefixed_Name(datex, "windSpeed") |> PrefixedName
    /// <summary>
    ///   <para>datex:WindInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of wind conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WindInformation">http://vocab.datex.org/terms#WindInformation</seealso>
    let WindInformation = Prefixed_Name(datex, "WindInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:windInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#windInformationExtension">http://vocab.datex.org/terms#windInformationExtension</seealso>
    let windInformationExtension =
        Prefixed_Name(datex, "windInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfVehiclesInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfVehiclesInvolved">http://vocab.datex.org/terms#groupOfVehiclesInvolved</seealso>
    let groupOfVehiclesInvolved =
        Prefixed_Name(datex, "groupOfVehiclesInvolved") |> PrefixedName

    /// <summary>
    ///   <para>datex:Destination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification a destination. This may be either a point location or an area location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Destination">http://vocab.datex.org/terms#Destination</seealso>
    let Destination = Prefixed_Name(datex, "Destination") |> PrefixedName
    /// <summary>
    ///   <para>datex:AreaExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension class for area used in parking publication extension.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AreaExtended">http://vocab.datex.org/terms#AreaExtended</seealso>
    let AreaExtended = Prefixed_Name(datex, "AreaExtended") |> PrefixedName

    /// <summary>
    ///   <para>datex:InterUrbanParkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parking site in an interurban context.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InterUrbanParkingSite">http://vocab.datex.org/terms#InterUrbanParkingSite</seealso>
    let InterUrbanParkingSite =
        Prefixed_Name(datex, "InterUrbanParkingSite") |> PrefixedName

    /// <summary>
    ///   <para>datex:internationalIdentifierExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#internationalIdentifierExtension">http://vocab.datex.org/terms#internationalIdentifierExtension</seealso>
    let internationalIdentifierExtension =
        Prefixed_Name(datex, "internationalIdentifierExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:payloadPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#payloadPublicationExtension">http://vocab.datex.org/terms#payloadPublicationExtension</seealso>
    let payloadPublicationExtension =
        Prefixed_Name(datex, "payloadPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:paymentMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentMode">http://vocab.datex.org/terms#paymentMode</seealso>
    let paymentMode = Prefixed_Name(datex, "paymentMode") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountryOfOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountryOfOrigin">http://vocab.datex.org/terms#vehicleCountryOfOrigin</seealso>
    let vehicleCountryOfOrigin =
        Prefixed_Name(datex, "vehicleCountryOfOrigin") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleExtension">http://vocab.datex.org/terms#vehicleExtension</seealso>
    let vehicleExtension = Prefixed_Name(datex, "vehicleExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleIdentifier">http://vocab.datex.org/terms#vehicleIdentifier</seealso>
    let vehicleIdentifier = Prefixed_Name(datex, "vehicleIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPictogramCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPictogramCode">http://vocab.datex.org/terms#supplementaryPictogramCode</seealso>
    let supplementaryPictogramCode =
        Prefixed_Name(datex, "supplementaryPictogramCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsSupplementaryPictogramExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsSupplementaryPictogramExtension">http://vocab.datex.org/terms#vmsSupplementaryPictogramExtension</seealso>
    let vmsSupplementaryPictogramExtension =
        Prefixed_Name(datex, "vmsSupplementaryPictogramExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:DamagedTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DamagedTunnel">http://vocab.datex.org/terms#DamagedTunnel</seealso>
    let DamagedTunnel = Prefixed_Name(datex, "DamagedTunnel") |> PrefixedName

    /// <summary>
    ///   <para>datex:DangerousSlowMovingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DangerousSlowMovingVehicle">http://vocab.datex.org/terms#DangerousSlowMovingVehicle</seealso>
    let DangerousSlowMovingVehicle =
        Prefixed_Name(datex, "DangerousSlowMovingVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:ExtremeCold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ExtremeCold">http://vocab.datex.org/terms#ExtremeCold</seealso>
    let ExtremeCold = Prefixed_Name(datex, "ExtremeCold") |> PrefixedName
    /// <summary>
    ///   <para>datex:FallingIce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FallingIce">http://vocab.datex.org/terms#FallingIce</seealso>
    let FallingIce = Prefixed_Name(datex, "FallingIce") |> PrefixedName
    /// <summary>
    ///   <para>datex:FlashFloods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FlashFloods">http://vocab.datex.org/terms#FlashFloods</seealso>
    let FlashFloods = Prefixed_Name(datex, "FlashFloods") |> PrefixedName
    /// <summary>
    ///   <para>datex:Fog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Fog">http://vocab.datex.org/terms#Fog</seealso>
    let Fog = Prefixed_Name(datex, "Fog") |> PrefixedName
    /// <summary>
    ///   <para>datex:FreezingPavements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FreezingPavements">http://vocab.datex.org/terms#FreezingPavements</seealso>
    let FreezingPavements = Prefixed_Name(datex, "FreezingPavements") |> PrefixedName
    /// <summary>
    ///   <para>datex:FreshSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FreshSnow">http://vocab.datex.org/terms#FreshSnow</seealso>
    let FreshSnow = Prefixed_Name(datex, "FreshSnow") |> PrefixedName

    /// <summary>
    ///   <para>datex:GalleryLightsFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GalleryLightsFailure">http://vocab.datex.org/terms#GalleryLightsFailure</seealso>
    let GalleryLightsFailure =
        Prefixed_Name(datex, "GalleryLightsFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:GardeningOrFlowerShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GardeningOrFlowerShow">http://vocab.datex.org/terms#GardeningOrFlowerShow</seealso>
    let GardeningOrFlowerShow =
        Prefixed_Name(datex, "GardeningOrFlowerShow") |> PrefixedName

    /// <summary>
    ///   <para>datex:GeneralObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GeneralObstruction">http://vocab.datex.org/terms#GeneralObstruction</seealso>
    let GeneralObstruction = Prefixed_Name(datex, "GeneralObstruction") |> PrefixedName
    /// <summary>
    ///   <para>datex:GustyWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GustyWinds">http://vocab.datex.org/terms#GustyWinds</seealso>
    let GustyWinds = Prefixed_Name(datex, "GustyWinds") |> PrefixedName
    /// <summary>
    ///   <para>datex:Hail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Hail">http://vocab.datex.org/terms#Hail</seealso>
    let Hail = Prefixed_Name(datex, "Hail") |> PrefixedName
    /// <summary>
    ///   <para>datex:Hazardous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Hazardous">http://vocab.datex.org/terms#Hazardous</seealso>
    let Hazardous = Prefixed_Name(datex, "Hazardous") |> PrefixedName
    /// <summary>
    ///   <para>datex:HeadOnCollision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeadOnCollision">http://vocab.datex.org/terms#HeadOnCollision</seealso>
    let HeadOnCollision = Prefixed_Name(datex, "HeadOnCollision") |> PrefixedName

    /// <summary>
    ///   <para>datex:HeightRestrictionInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeightRestrictionInOperation">http://vocab.datex.org/terms#HeightRestrictionInOperation</seealso>
    let HeightRestrictionInOperation =
        Prefixed_Name(datex, "HeightRestrictionInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:HelicopterRescue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HelicopterRescue">http://vocab.datex.org/terms#HelicopterRescue</seealso>
    let HelicopterRescue = Prefixed_Name(datex, "HelicopterRescue") |> PrefixedName
    /// <summary>
    ///   <para>datex:HockeyGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HockeyGame">http://vocab.datex.org/terms#HockeyGame</seealso>
    let HockeyGame = Prefixed_Name(datex, "HockeyGame") |> PrefixedName
    /// <summary>
    ///   <para>datex:HorseRaceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HorseRaceMeeting">http://vocab.datex.org/terms#HorseRaceMeeting</seealso>
    let HorseRaceMeeting = Prefixed_Name(datex, "HorseRaceMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:IllVehicleOccupants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IllVehicleOccupants">http://vocab.datex.org/terms#IllVehicleOccupants</seealso>
    let IllVehicleOccupants =
        Prefixed_Name(datex, "IllVehicleOccupants") |> PrefixedName

    /// <summary>
    ///   <para>datex:Impossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Impossible">http://vocab.datex.org/terms#Impossible</seealso>
    let Impossible = Prefixed_Name(datex, "Impossible") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureFailure">http://vocab.datex.org/terms#InfrastructureFailure</seealso>
    let InfrastructureFailure =
        Prefixed_Name(datex, "InfrastructureFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureFault">http://vocab.datex.org/terms#InfrastructureFault</seealso>
    let InfrastructureFault =
        Prefixed_Name(datex, "InfrastructureFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSideCommunicationsSystemFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFault">http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFault</seealso>
    let InfrastructureSideCommunicationsSystemFault =
        Prefixed_Name(datex, "InfrastructureSideCommunicationsSystemFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSidePowerSystemFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSidePowerSystemFailure">http://vocab.datex.org/terms#InfrastructureSidePowerSystemFailure</seealso>
    let InfrastructureSidePowerSystemFailure =
        Prefixed_Name(datex, "InfrastructureSidePowerSystemFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:IntermittentShortTermClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IntermittentShortTermClosures">http://vocab.datex.org/terms#IntermittentShortTermClosures</seealso>
    let IntermittentShortTermClosures =
        Prefixed_Name(datex, "IntermittentShortTermClosures") |> PrefixedName

    /// <summary>
    ///   <para>datex:InternationalSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InternationalSportsMeeting">http://vocab.datex.org/terms#InternationalSportsMeeting</seealso>
    let InternationalSportsMeeting =
        Prefixed_Name(datex, "InternationalSportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:LaneClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LaneClosure">http://vocab.datex.org/terms#LaneClosure</seealso>
    let LaneClosure = Prefixed_Name(datex, "LaneClosure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LaneControlSignFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LaneControlSignFailure">http://vocab.datex.org/terms#LaneControlSignFailure</seealso>
    let LaneControlSignFailure =
        Prefixed_Name(datex, "LaneControlSignFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LaneControlSignFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LaneControlSignFault">http://vocab.datex.org/terms#LaneControlSignFault</seealso>
    let LaneControlSignFault =
        Prefixed_Name(datex, "LaneControlSignFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:LanesDeviated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LanesDeviated">http://vocab.datex.org/terms#LanesDeviated</seealso>
    let LanesDeviated = Prefixed_Name(datex, "LanesDeviated") |> PrefixedName
    /// <summary>
    ///   <para>datex:LooseChippings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LooseChippings">http://vocab.datex.org/terms#LooseChippings</seealso>
    let LooseChippings = Prefixed_Name(datex, "LooseChippings") |> PrefixedName

    /// <summary>
    ///   <para>datex:LooseSandOnInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LooseSandOnInfrastructure">http://vocab.datex.org/terms#LooseSandOnInfrastructure</seealso>
    let LooseSandOnInfrastructure =
        Prefixed_Name(datex, "LooseSandOnInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LooseSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LooseSnow">http://vocab.datex.org/terms#LooseSnow</seealso>
    let LooseSnow = Prefixed_Name(datex, "LooseSnow") |> PrefixedName
    /// <summary>
    ///   <para>datex:LowSunGlare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LowSunGlare">http://vocab.datex.org/terms#LowSunGlare</seealso>
    let LowSunGlare = Prefixed_Name(datex, "LowSunGlare") |> PrefixedName
    /// <summary>
    ///   <para>datex:MatrixSignFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MatrixSignFault">http://vocab.datex.org/terms#MatrixSignFault</seealso>
    let MatrixSignFault = Prefixed_Name(datex, "MatrixSignFault") |> PrefixedName
    /// <summary>
    ///   <para>datex:MilitaryConvoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MilitaryConvoy">http://vocab.datex.org/terms#MilitaryConvoy</seealso>
    let MilitaryConvoy = Prefixed_Name(datex, "MilitaryConvoy") |> PrefixedName
    /// <summary>
    ///   <para>datex:ModerateFog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ModerateFog">http://vocab.datex.org/terms#ModerateFog</seealso>
    let ModerateFog = Prefixed_Name(datex, "ModerateFog") |> PrefixedName
    /// <summary>
    ///   <para>datex:MotorShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MotorShow">http://vocab.datex.org/terms#MotorShow</seealso>
    let MotorShow = Prefixed_Name(datex, "MotorShow") |> PrefixedName
    /// <summary>
    ///   <para>datex:NewRoadworksLayout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NewRoadworksLayout">http://vocab.datex.org/terms#NewRoadworksLayout</seealso>
    let NewRoadworksLayout = Prefixed_Name(datex, "NewRoadworksLayout") |> PrefixedName
    /// <summary>
    ///   <para>datex:Normal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Normal">http://vocab.datex.org/terms#Normal</seealso>
    let Normal = Prefixed_Name(datex, "Normal") |> PrefixedName

    /// <summary>
    ///   <para>datex:NormalWinterConditionsForPedestrians</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NormalWinterConditionsForPedestrians">http://vocab.datex.org/terms#NormalWinterConditionsForPedestrians</seealso>
    let NormalWinterConditionsForPedestrians =
        Prefixed_Name(datex, "NormalWinterConditionsForPedestrians") |> PrefixedName

    /// <summary>
    ///   <para>datex:ObstacleSignalling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ObstacleSignalling">http://vocab.datex.org/terms#ObstacleSignalling</seealso>
    let ObstacleSignalling = Prefixed_Name(datex, "ObstacleSignalling") |> PrefixedName

    /// <summary>
    ///   <para>datex:OverturnedHeavyLorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverturnedHeavyLorry">http://vocab.datex.org/terms#OverturnedHeavyLorry</seealso>
    let OverturnedHeavyLorry =
        Prefixed_Name(datex, "OverturnedHeavyLorry") |> PrefixedName

    /// <summary>
    ///   <para>datex:OverturnedTrailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverturnedTrailer">http://vocab.datex.org/terms#OverturnedTrailer</seealso>
    let OverturnedTrailer = Prefixed_Name(datex, "OverturnedTrailer") |> PrefixedName
    /// <summary>
    ///   <para>datex:OverturnedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverturnedVehicle">http://vocab.datex.org/terms#OverturnedVehicle</seealso>
    let OverturnedVehicle = Prefixed_Name(datex, "OverturnedVehicle") |> PrefixedName
    /// <summary>
    ///   <para>datex:OzonePollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OzonePollution">http://vocab.datex.org/terms#OzonePollution</seealso>
    let OzonePollution = Prefixed_Name(datex, "OzonePollution") |> PrefixedName

    /// <summary>
    ///   <para>datex:PrecipitationInTheArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PrecipitationInTheArea">http://vocab.datex.org/terms#PrecipitationInTheArea</seealso>
    let PrecipitationInTheArea =
        Prefixed_Name(datex, "PrecipitationInTheArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:Procession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Procession">http://vocab.datex.org/terms#Procession</seealso>
    let Procession = Prefixed_Name(datex, "Procession") |> PrefixedName

    /// <summary>
    ///   <para>datex:ProhibitedVehicleOnTheRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ProhibitedVehicleOnTheRoadway">http://vocab.datex.org/terms#ProhibitedVehicleOnTheRoadway</seealso>
    let ProhibitedVehicleOnTheRoadway =
        Prefixed_Name(datex, "ProhibitedVehicleOnTheRoadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:PublicDisturbance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PublicDisturbance">http://vocab.datex.org/terms#PublicDisturbance</seealso>
    let PublicDisturbance = Prefixed_Name(datex, "PublicDisturbance") |> PrefixedName
    /// <summary>
    ///   <para>datex:RepairWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RepairWork">http://vocab.datex.org/terms#RepairWork</seealso>
    let RepairWork = Prefixed_Name(datex, "RepairWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:ResurfacingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ResurfacingWork">http://vocab.datex.org/terms#ResurfacingWork</seealso>
    let ResurfacingWork = Prefixed_Name(datex, "ResurfacingWork") |> PrefixedName
    /// <summary>
    ///   <para>datex:Riot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Riot">http://vocab.datex.org/terms#Riot</seealso>
    let Riot = Prefixed_Name(datex, "Riot") |> PrefixedName
    /// <summary>
    ///   <para>datex:RoadCleared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadCleared">http://vocab.datex.org/terms#RoadCleared</seealso>
    let RoadCleared = Prefixed_Name(datex, "RoadCleared") |> PrefixedName
    /// <summary>
    ///   <para>datex:Rockfalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Rockfalls">http://vocab.datex.org/terms#Rockfalls</seealso>
    let Rockfalls = Prefixed_Name(datex, "Rockfalls") |> PrefixedName
    /// <summary>
    ///   <para>datex:RollingRoadBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RollingRoadBlock">http://vocab.datex.org/terms#RollingRoadBlock</seealso>
    let RollingRoadBlock = Prefixed_Name(datex, "RollingRoadBlock") |> PrefixedName
    /// <summary>
    ///   <para>datex:RugbyMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RugbyMatch">http://vocab.datex.org/terms#RugbyMatch</seealso>
    let RugbyMatch = Prefixed_Name(datex, "RugbyMatch") |> PrefixedName

    /// <summary>
    ///   <para>datex:RushHourLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RushHourLaneInOperation">http://vocab.datex.org/terms#RushHourLaneInOperation</seealso>
    let RushHourLaneInOperation =
        Prefixed_Name(datex, "RushHourLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:SecurityIncident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SecurityIncident">http://vocab.datex.org/terms#SecurityIncident</seealso>
    let SecurityIncident = Prefixed_Name(datex, "SecurityIncident") |> PrefixedName
    /// <summary>
    ///   <para>datex:SeriousAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SeriousAccident">http://vocab.datex.org/terms#SeriousAccident</seealso>
    let SeriousAccident = Prefixed_Name(datex, "SeriousAccident") |> PrefixedName
    /// <summary>
    ///   <para>datex:SeriousFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SeriousFire">http://vocab.datex.org/terms#SeriousFire</seealso>
    let SeriousFire = Prefixed_Name(datex, "SeriousFire") |> PrefixedName
    /// <summary>
    ///   <para>datex:SeveralMajorEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SeveralMajorEvents">http://vocab.datex.org/terms#SeveralMajorEvents</seealso>
    let SeveralMajorEvents = Prefixed_Name(datex, "SeveralMajorEvents") |> PrefixedName

    /// <summary>
    ///   <para>datex:SevereExhaustPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SevereExhaustPollution">http://vocab.datex.org/terms#SevereExhaustPollution</seealso>
    let SevereExhaustPollution =
        Prefixed_Name(datex, "SevereExhaustPollution") |> PrefixedName

    /// <summary>
    ///   <para>datex:SevereSmog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SevereSmog">http://vocab.datex.org/terms#SevereSmog</seealso>
    let SevereSmog = Prefixed_Name(datex, "SevereSmog") |> PrefixedName
    /// <summary>
    ///   <para>datex:SewerOverflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SewerOverflow">http://vocab.datex.org/terms#SewerOverflow</seealso>
    let SewerOverflow = Prefixed_Name(datex, "SewerOverflow") |> PrefixedName
    /// <summary>
    ///   <para>datex:Show</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Show">http://vocab.datex.org/terms#Show</seealso>
    let Show = Prefixed_Name(datex, "Show") |> PrefixedName
    /// <summary>
    ///   <para>datex:SlushStrings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SlushStrings">http://vocab.datex.org/terms#SlushStrings</seealso>
    let SlushStrings = Prefixed_Name(datex, "SlushStrings") |> PrefixedName
    /// <summary>
    ///   <para>datex:SmogAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SmogAlert">http://vocab.datex.org/terms#SmogAlert</seealso>
    let SmogAlert = Prefixed_Name(datex, "SmogAlert") |> PrefixedName
    /// <summary>
    ///   <para>datex:SmokeHazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SmokeHazard">http://vocab.datex.org/terms#SmokeHazard</seealso>
    let SmokeHazard = Prefixed_Name(datex, "SmokeHazard") |> PrefixedName
    /// <summary>
    ///   <para>datex:SmokeOrFumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SmokeOrFumes">http://vocab.datex.org/terms#SmokeOrFumes</seealso>
    let SmokeOrFumes = Prefixed_Name(datex, "SmokeOrFumes") |> PrefixedName
    /// <summary>
    ///   <para>datex:SnowChangingToRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SnowChangingToRain">http://vocab.datex.org/terms#SnowChangingToRain</seealso>
    let SnowChangingToRain = Prefixed_Name(datex, "SnowChangingToRain") |> PrefixedName
    /// <summary>
    ///   <para>datex:SnowDrifts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SnowDrifts">http://vocab.datex.org/terms#SnowDrifts</seealso>
    let SnowDrifts = Prefixed_Name(datex, "SnowDrifts") |> PrefixedName
    /// <summary>
    ///   <para>datex:SnowOnPavement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SnowOnPavement">http://vocab.datex.org/terms#SnowOnPavement</seealso>
    let SnowOnPavement = Prefixed_Name(datex, "SnowOnPavement") |> PrefixedName

    /// <summary>
    ///   <para>datex:SnowOnTheInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SnowOnTheInfrastructure">http://vocab.datex.org/terms#SnowOnTheInfrastructure</seealso>
    let SnowOnTheInfrastructure =
        Prefixed_Name(datex, "SnowOnTheInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:StationaryTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StationaryTraffic">http://vocab.datex.org/terms#StationaryTraffic</seealso>
    let StationaryTraffic = Prefixed_Name(datex, "StationaryTraffic") |> PrefixedName
    /// <summary>
    ///   <para>datex:StormDamage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StormDamage">http://vocab.datex.org/terms#StormDamage</seealso>
    let StormDamage = Prefixed_Name(datex, "StormDamage") |> PrefixedName
    /// <summary>
    ///   <para>datex:StormForceWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StormForceWinds">http://vocab.datex.org/terms#StormForceWinds</seealso>
    let StormForceWinds = Prefixed_Name(datex, "StormForceWinds") |> PrefixedName

    /// <summary>
    ///   <para>datex:StreetLightingFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StreetLightingFailure">http://vocab.datex.org/terms#StreetLightingFailure</seealso>
    let StreetLightingFailure =
        Prefixed_Name(datex, "StreetLightingFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:StreetLightingFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StreetLightingFault">http://vocab.datex.org/terms#StreetLightingFault</seealso>
    let StreetLightingFault =
        Prefixed_Name(datex, "StreetLightingFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:Strike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Strike">http://vocab.datex.org/terms#Strike</seealso>
    let Strike = Prefixed_Name(datex, "Strike") |> PrefixedName
    /// <summary>
    ///   <para>datex:StrongGustsOfWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StrongGustsOfWind">http://vocab.datex.org/terms#StrongGustsOfWind</seealso>
    let StrongGustsOfWind = Prefixed_Name(datex, "StrongGustsOfWind") |> PrefixedName
    /// <summary>
    ///   <para>datex:StrongWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#StrongWinds">http://vocab.datex.org/terms#StrongWinds</seealso>
    let StrongWinds = Prefixed_Name(datex, "StrongWinds") |> PrefixedName
    /// <summary>
    ///   <para>datex:TemperatureFalling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemperatureFalling">http://vocab.datex.org/terms#TemperatureFalling</seealso>
    let TemperatureFalling = Prefixed_Name(datex, "TemperatureFalling") |> PrefixedName

    /// <summary>
    ///   <para>datex:TemporaryTrafficLights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemporaryTrafficLights">http://vocab.datex.org/terms#TemporaryTrafficLights</seealso>
    let TemporaryTrafficLights =
        Prefixed_Name(datex, "TemporaryTrafficLights") |> PrefixedName

    /// <summary>
    ///   <para>datex:TemporaryTrafficLightsFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemporaryTrafficLightsFailure">http://vocab.datex.org/terms#TemporaryTrafficLightsFailure</seealso>
    let TemporaryTrafficLightsFailure =
        Prefixed_Name(datex, "TemporaryTrafficLightsFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:TemporaryTrafficLightsFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TemporaryTrafficLightsFault">http://vocab.datex.org/terms#TemporaryTrafficLightsFault</seealso>
    let TemporaryTrafficLightsFault =
        Prefixed_Name(datex, "TemporaryTrafficLightsFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:TennisTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TennisTournament">http://vocab.datex.org/terms#TennisTournament</seealso>
    let TennisTournament = Prefixed_Name(datex, "TennisTournament") |> PrefixedName
    /// <summary>
    ///   <para>datex:TerroristIncident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TerroristIncident">http://vocab.datex.org/terms#TerroristIncident</seealso>
    let TerroristIncident = Prefixed_Name(datex, "TerroristIncident") |> PrefixedName
    /// <summary>
    ///   <para>datex:Theft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Theft">http://vocab.datex.org/terms#Theft</seealso>
    let Theft = Prefixed_Name(datex, "Theft") |> PrefixedName
    /// <summary>
    ///   <para>datex:Thunderstorms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Thunderstorms">http://vocab.datex.org/terms#Thunderstorms</seealso>
    let Thunderstorms = Prefixed_Name(datex, "Thunderstorms") |> PrefixedName
    /// <summary>
    ///   <para>datex:TradeFair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TradeFair">http://vocab.datex.org/terms#TradeFair</seealso>
    let TradeFair = Prefixed_Name(datex, "TradeFair") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficBeingManuallyDirected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficBeingManuallyDirected">http://vocab.datex.org/terms#TrafficBeingManuallyDirected</seealso>
    let TrafficBeingManuallyDirected =
        Prefixed_Name(datex, "TrafficBeingManuallyDirected") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficElementEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficElementEvent">http://vocab.datex.org/terms#TrafficElementEvent</seealso>
    let TrafficElementEvent =
        Prefixed_Name(datex, "TrafficElementEvent") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficHeld</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficHeld">http://vocab.datex.org/terms#TrafficHeld</seealso>
    let TrafficHeld = Prefixed_Name(datex, "TrafficHeld") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficLightSetFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficLightSetFailure">http://vocab.datex.org/terms#TrafficLightSetFailure</seealso>
    let TrafficLightSetFailure =
        Prefixed_Name(datex, "TrafficLightSetFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficLightSetFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficLightSetFault">http://vocab.datex.org/terms#TrafficLightSetFault</seealso>
    let TrafficLightSetFault =
        Prefixed_Name(datex, "TrafficLightSetFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficSignalsFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficSignalsFailure">http://vocab.datex.org/terms#TrafficSignalsFailure</seealso>
    let TrafficSignalsFailure =
        Prefixed_Name(datex, "TrafficSignalsFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:TrafficSignalsFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficSignalsFault">http://vocab.datex.org/terms#TrafficSignalsFault</seealso>
    let TrafficSignalsFault =
        Prefixed_Name(datex, "TrafficSignalsFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Unknown">http://vocab.datex.org/terms#Unknown</seealso>
    let Unknown = Prefixed_Name(datex, "Unknown") |> PrefixedName

    /// <summary>
    ///   <para>datex:UnlitVehicleOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UnlitVehicleOnTheRoad">http://vocab.datex.org/terms#UnlitVehicleOnTheRoad</seealso>
    let UnlitVehicleOnTheRoad =
        Prefixed_Name(datex, "UnlitVehicleOnTheRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:UnspecifiedAbnormalTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UnspecifiedAbnormalTraffic">http://vocab.datex.org/terms#UnspecifiedAbnormalTraffic</seealso>
    let UnspecifiedAbnormalTraffic =
        Prefixed_Name(datex, "UnspecifiedAbnormalTraffic") |> PrefixedName

    /// <summary>
    ///   <para>datex:UnspecifiedAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UnspecifiedAlert">http://vocab.datex.org/terms#UnspecifiedAlert</seealso>
    let UnspecifiedAlert = Prefixed_Name(datex, "UnspecifiedAlert") |> PrefixedName

    /// <summary>
    ///   <para>datex:UseOfSpecifiedLanesOrCarriagewaysAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UseOfSpecifiedLanesOrCarriagewaysAllowed">http://vocab.datex.org/terms#UseOfSpecifiedLanesOrCarriagewaysAllowed</seealso>
    let UseOfSpecifiedLanesOrCarriagewaysAllowed =
        Prefixed_Name(datex, "UseOfSpecifiedLanesOrCarriagewaysAllowed") |> PrefixedName

    /// <summary>
    ///   <para>datex:VariableMessageSignFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VariableMessageSignFailure">http://vocab.datex.org/terms#VariableMessageSignFailure</seealso>
    let VariableMessageSignFailure =
        Prefixed_Name(datex, "VariableMessageSignFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:VariableMessageSignFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VariableMessageSignFault">http://vocab.datex.org/terms#VariableMessageSignFault</seealso>
    let VariableMessageSignFault =
        Prefixed_Name(datex, "VariableMessageSignFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleCarryingHazardousMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCarryingHazardousMaterials">http://vocab.datex.org/terms#VehicleCarryingHazardousMaterials</seealso>
    let VehicleCarryingHazardousMaterials =
        Prefixed_Name(datex, "VehicleCarryingHazardousMaterials") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleStorageInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleStorageInOperation">http://vocab.datex.org/terms#VehicleStorageInOperation</seealso>
    let VehicleStorageInOperation =
        Prefixed_Name(datex, "VehicleStorageInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleStuck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleStuck">http://vocab.datex.org/terms#VehicleStuck</seealso>
    let VehicleStuck = Prefixed_Name(datex, "VehicleStuck") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleStuckUnderBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleStuckUnderBridge">http://vocab.datex.org/terms#VehicleStuckUnderBridge</seealso>
    let VehicleStuckUnderBridge =
        Prefixed_Name(datex, "VehicleStuckUnderBridge") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleWeighing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleWeighing">http://vocab.datex.org/terms#VehicleWeighing</seealso>
    let VehicleWeighing = Prefixed_Name(datex, "VehicleWeighing") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleWithOverheightLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleWithOverheightLoad">http://vocab.datex.org/terms#VehicleWithOverheightLoad</seealso>
    let VehicleWithOverheightLoad =
        Prefixed_Name(datex, "VehicleWithOverheightLoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleWithOverwideLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleWithOverwideLoad">http://vocab.datex.org/terms#VehicleWithOverwideLoad</seealso>
    let VehicleWithOverwideLoad =
        Prefixed_Name(datex, "VehicleWithOverwideLoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:VeryHazardous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VeryHazardous">http://vocab.datex.org/terms#VeryHazardous</seealso>
    let VeryHazardous = Prefixed_Name(datex, "VeryHazardous") |> PrefixedName

    /// <summary>
    ///   <para>datex:VeryStrongGustsOfWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VeryStrongGustsOfWind">http://vocab.datex.org/terms#VeryStrongGustsOfWind</seealso>
    let VeryStrongGustsOfWind =
        Prefixed_Name(datex, "VeryStrongGustsOfWind") |> PrefixedName

    /// <summary>
    ///   <para>datex:WhiteOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WhiteOut">http://vocab.datex.org/terms#WhiteOut</seealso>
    let WhiteOut = Prefixed_Name(datex, "WhiteOut") |> PrefixedName
    /// <summary>
    ///   <para>datex:WinterConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WinterConditions">http://vocab.datex.org/terms#WinterConditions</seealso>
    let WinterConditions = Prefixed_Name(datex, "WinterConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:WinterSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WinterSportsMeeting">http://vocab.datex.org/terms#WinterSportsMeeting</seealso>
    let WinterSportsMeeting =
        Prefixed_Name(datex, "WinterSportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>datex:WinterStorm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WinterStorm">http://vocab.datex.org/terms#WinterStorm</seealso>
    let WinterStorm = Prefixed_Name(datex, "WinterStorm") |> PrefixedName
    /// <summary>
    ///   <para>datex:Ontology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.datex.org/terms#Ontology">http://vocab.datex.org/terms#Ontology</seealso>
    let Ontology = Prefixed_Name(datex, "Ontology") |> PrefixedName

    /// <summary>
    ///   <para>datex:abnormalTrafficType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#abnormalTrafficType">http://vocab.datex.org/terms#abnormalTrafficType</seealso>
    let abnormalTrafficType =
        Prefixed_Name(datex, "abnormalTrafficType") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfVehiclesWaiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of vehicles waiting in a queue.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfVehiclesWaiting">http://vocab.datex.org/terms#numberOfVehiclesWaiting</seealso>
    let numberOfVehiclesWaiting =
        Prefixed_Name(datex, "numberOfVehiclesWaiting") |> PrefixedName

    /// <summary>
    ///   <para>datex:queueLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The length of a queue or the average length of queues in separate lanes due to a situation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#queueLength">http://vocab.datex.org/terms#queueLength</seealso>
    let queueLength = Prefixed_Name(datex, "queueLength") |> PrefixedName

    /// <summary>
    ///   <para>datex:relativeTrafficFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#relativeTrafficFlow">http://vocab.datex.org/terms#relativeTrafficFlow</seealso>
    let relativeTrafficFlow =
        Prefixed_Name(datex, "relativeTrafficFlow") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficFlowCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A characterization of the traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficFlowCharacteristics">http://vocab.datex.org/terms#trafficFlowCharacteristics</seealso>
    let trafficFlowCharacteristics =
        Prefixed_Name(datex, "trafficFlowCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:trafficTrendType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#trafficTrendType">http://vocab.datex.org/terms#trafficTrendType</seealso>
    let trafficTrendType = Prefixed_Name(datex, "trafficTrendType") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficElement">http://vocab.datex.org/terms#TrafficElement</seealso>
    let TrafficElement = Prefixed_Name(datex, "TrafficElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:AcceptedPaymentCards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use this class to describe details in case acceptedMeansOfPayment is set to 'paymentCard'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AcceptedPaymentCards">http://vocab.datex.org/terms#AcceptedPaymentCards</seealso>
    let AcceptedPaymentCards =
        Prefixed_Name(datex, "AcceptedPaymentCards") |> PrefixedName

    /// <summary>
    ///   <para>datex:acceptedPaymentCardsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#acceptedPaymentCardsExtension">http://vocab.datex.org/terms#acceptedPaymentCardsExtension</seealso>
    let acceptedPaymentCardsExtension =
        Prefixed_Name(datex, "acceptedPaymentCardsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:otherPaymentCardBrands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherPaymentCardBrands">http://vocab.datex.org/terms#otherPaymentCardBrands</seealso>
    let otherPaymentCardBrands =
        Prefixed_Name(datex, "otherPaymentCardBrands") |> PrefixedName

    /// <summary>
    ///   <para>datex:otherPaymentCards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherPaymentCards">http://vocab.datex.org/terms#otherPaymentCards</seealso>
    let otherPaymentCards = Prefixed_Name(datex, "otherPaymentCards") |> PrefixedName
    /// <summary>
    ///   <para>datex:paymentCardBrands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentCardBrands">http://vocab.datex.org/terms#paymentCardBrands</seealso>
    let paymentCardBrands = Prefixed_Name(datex, "paymentCardBrands") |> PrefixedName
    /// <summary>
    ///   <para>datex:paymentCards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentCards">http://vocab.datex.org/terms#paymentCards</seealso>
    let paymentCards = Prefixed_Name(datex, "paymentCards") |> PrefixedName
    /// <summary>
    ///   <para>datex:alive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the identified animals are dead (immobile) or alive (potentially mobile).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alive">http://vocab.datex.org/terms#alive</seealso>
    let alive = Prefixed_Name(datex, "alive") |> PrefixedName

    /// <summary>
    ///   <para>datex:animalPresenceObstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#animalPresenceObstructionExtension">http://vocab.datex.org/terms#animalPresenceObstructionExtension</seealso>
    let animalPresenceObstructionExtension =
        Prefixed_Name(datex, "animalPresenceObstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:animalPresenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the nature of animals present on or near the roadway.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#animalPresenceType">http://vocab.datex.org/terms#animalPresenceType</seealso>
    let animalPresenceType = Prefixed_Name(datex, "animalPresenceType") |> PrefixedName

    /// <summary>
    ///   <para>datex:ApplicationRateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the application rate of a substance.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ApplicationRateValue">http://vocab.datex.org/terms#ApplicationRateValue</seealso>
    let ApplicationRateValue =
        Prefixed_Name(datex, "ApplicationRateValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicationRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of the rate of application of a substance expressed in kilogrammes per square metre.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicationRate">http://vocab.datex.org/terms#applicationRate</seealso>
    let applicationRate = Prefixed_Name(datex, "applicationRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicationRateValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicationRateValueExtension">http://vocab.datex.org/terms#applicationRateValueExtension</seealso>
    let applicationRateValueExtension =
        Prefixed_Name(datex, "applicationRateValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Area">http://vocab.datex.org/terms#Area</seealso>
    let Area = Prefixed_Name(datex, "Area") |> PrefixedName
    /// <summary>
    ///   <para>datex:alertCArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCArea">http://vocab.datex.org/terms#alertCArea</seealso>
    let alertCArea = Prefixed_Name(datex, "alertCArea") |> PrefixedName
    /// <summary>
    ///   <para>datex:areaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaExtension">http://vocab.datex.org/terms#areaExtension</seealso>
    let areaExtension = Prefixed_Name(datex, "areaExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:_AreaExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_AreaExtensionType">http://vocab.datex.org/terms#_AreaExtensionType</seealso>
    let _AreaExtensionType = Prefixed_Name(datex, "_AreaExtensionType") |> PrefixedName
    /// <summary>
    ///   <para>datex:tpegAreaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegAreaLocation">http://vocab.datex.org/terms#tpegAreaLocation</seealso>
    let tpegAreaLocation = Prefixed_Name(datex, "tpegAreaLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:TpegAreaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegAreaLocation">http://vocab.datex.org/terms#TpegAreaLocation</seealso>
    let TpegAreaLocation = Prefixed_Name(datex, "TpegAreaLocation") |> PrefixedName
    /// <summary>
    ///   <para>datex:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Location">http://vocab.datex.org/terms#Location</seealso>
    let Location = Prefixed_Name(datex, "Location") |> PrefixedName
    /// <summary>
    ///   <para>datex:AreaDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of the destination of a defined route or itinerary which is an area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AreaDestination">http://vocab.datex.org/terms#AreaDestination</seealso>
    let AreaDestination = Prefixed_Name(datex, "AreaDestination") |> PrefixedName
    /// <summary>
    ///   <para>datex:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#area">http://vocab.datex.org/terms#area</seealso>
    let area = Prefixed_Name(datex, "area") |> PrefixedName

    /// <summary>
    ///   <para>datex:areaDestinationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#areaDestinationExtension">http://vocab.datex.org/terms#areaDestinationExtension</seealso>
    let areaDestinationExtension =
        Prefixed_Name(datex, "areaDestinationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:polygonArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#polygonArea">http://vocab.datex.org/terms#polygonArea</seealso>
    let polygonArea = Prefixed_Name(datex, "polygonArea") |> PrefixedName
    /// <summary>
    ///   <para>datex:PolygonArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>defines points for a closed polygon-shape describing the area</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PolygonArea">http://vocab.datex.org/terms#PolygonArea</seealso>
    let PolygonArea = Prefixed_Name(datex, "PolygonArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:authorityOperationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#authorityOperationExtension">http://vocab.datex.org/terms#authorityOperationExtension</seealso>
    let authorityOperationExtension =
        Prefixed_Name(datex, "authorityOperationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:authorityOperationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of authority initiated operation or activity that could disrupt traffic. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#authorityOperationType">http://vocab.datex.org/terms#authorityOperationType</seealso>
    let authorityOperationType =
        Prefixed_Name(datex, "authorityOperationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:AxleFlowValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the flow rate of vehicle axles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AxleFlowValue">http://vocab.datex.org/terms#AxleFlowValue</seealso>
    let AxleFlowValue = Prefixed_Name(datex, "AxleFlowValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:axleFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of the flow rate of vehicle axles expressed in axles per hour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleFlowRate">http://vocab.datex.org/terms#axleFlowRate</seealso>
    let axleFlowRate = Prefixed_Name(datex, "axleFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleFlowValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleFlowValueExtension">http://vocab.datex.org/terms#axleFlowValueExtension</seealso>
    let axleFlowValueExtension =
        Prefixed_Name(datex, "axleFlowValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AxleSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The spacing details between the axle sets of an individual vehicle numbered from the front to the back of the vehicle. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AxleSpacing">http://vocab.datex.org/terms#AxleSpacing</seealso>
    let AxleSpacing = Prefixed_Name(datex, "AxleSpacing") |> PrefixedName
    /// <summary>
    ///   <para>datex:axleSpacing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleSpacing">http://vocab.datex.org/terms#axleSpacing</seealso>
    let axleSpacing = Prefixed_Name(datex, "axleSpacing") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleSpacingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleSpacingExtension">http://vocab.datex.org/terms#axleSpacingExtension</seealso>
    let axleSpacingExtension =
        Prefixed_Name(datex, "axleSpacingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleSpacingSequenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleSpacingSequenceIdentifier">http://vocab.datex.org/terms#axleSpacingSequenceIdentifier</seealso>
    let axleSpacingSequenceIdentifier =
        Prefixed_Name(datex, "axleSpacingSequenceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:AxleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The weight details of a specific axle on the vehicle. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AxleWeight">http://vocab.datex.org/terms#AxleWeight</seealso>
    let AxleWeight = Prefixed_Name(datex, "AxleWeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:axlePositionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axlePositionIdentifier">http://vocab.datex.org/terms#axlePositionIdentifier</seealso>
    let axlePositionIdentifier =
        Prefixed_Name(datex, "axlePositionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleWeightExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleWeightExtension">http://vocab.datex.org/terms#axleWeightExtension</seealso>
    let axleWeightExtension =
        Prefixed_Name(datex, "axleWeightExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumPermittedAxleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumPermittedAxleWeight">http://vocab.datex.org/terms#maximumPermittedAxleWeight</seealso>
    let maximumPermittedAxleWeight =
        Prefixed_Name(datex, "maximumPermittedAxleWeight") |> PrefixedName

    /// <summary>
    ///   <para>datex:BasicData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data that is either measured or calculated (elaborated) at the same time or over the same time period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#BasicData">http://vocab.datex.org/terms#BasicData</seealso>
    let BasicData = Prefixed_Name(datex, "BasicData") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementOrCalculatedTimePrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementOrCalculatedTimePrecision">http://vocab.datex.org/terms#measurementOrCalculatedTimePrecision</seealso>
    let measurementOrCalculatedTimePrecision =
        Prefixed_Name(datex, "measurementOrCalculatedTimePrecision") |> PrefixedName

    /// <summary>
    ///   <para>datex:basicDataExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#basicDataExtension">http://vocab.datex.org/terms#basicDataExtension</seealso>
    let basicDataExtension = Prefixed_Name(datex, "basicDataExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementOrCalculationPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementOrCalculationPeriod">http://vocab.datex.org/terms#measurementOrCalculationPeriod</seealso>
    let measurementOrCalculationPeriod =
        Prefixed_Name(datex, "measurementOrCalculationPeriod") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementOrCalculationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementOrCalculationTime">http://vocab.datex.org/terms#measurementOrCalculationTime</seealso>
    let measurementOrCalculationTime =
        Prefixed_Name(datex, "measurementOrCalculationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:CarParks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides information on the status of one or more car parks.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CarParks">http://vocab.datex.org/terms#CarParks</seealso>
    let CarParks = Prefixed_Name(datex, "CarParks") |> PrefixedName

    /// <summary>
    ///   <para>datex:carParkConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>The configuration/layout of a car park.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carParkConfiguration">http://vocab.datex.org/terms#carParkConfiguration</seealso>
    let carParkConfiguration =
        Prefixed_Name(datex, "carParkConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>datex:carParkIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The identity of one or a group of car parks.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carParkIdentity">http://vocab.datex.org/terms#carParkIdentity</seealso>
    let carParkIdentity = Prefixed_Name(datex, "carParkIdentity") |> PrefixedName
    /// <summary>
    ///   <para>datex:carParkOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The percentage value of car parking spaces occupied.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carParkOccupancy">http://vocab.datex.org/terms#carParkOccupancy</seealso>
    let carParkOccupancy = Prefixed_Name(datex, "carParkOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>datex:carParkStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the status of one or more specified car parks.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carParkStatus">http://vocab.datex.org/terms#carParkStatus</seealso>
    let carParkStatus = Prefixed_Name(datex, "carParkStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:carParksExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#carParksExtension">http://vocab.datex.org/terms#carParksExtension</seealso>
    let carParksExtension = Prefixed_Name(datex, "carParksExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:exitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The rate at which vehicles are exiting the car park.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exitRate">http://vocab.datex.org/terms#exitRate</seealso>
    let exitRate = Prefixed_Name(datex, "exitRate") |> PrefixedName
    /// <summary>
    ///   <para>datex:fillRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>The rate at which vehicles are entering the car park.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fillRate">http://vocab.datex.org/terms#fillRate</seealso>
    let fillRate = Prefixed_Name(datex, "fillRate") |> PrefixedName
    /// <summary>
    ///   <para>datex:queuingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The current queuing time (duration) for entering the car park.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#queuingTime">http://vocab.datex.org/terms#queuingTime</seealso>
    let queuingTime = Prefixed_Name(datex, "queuingTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:totalCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Total number of car parking spaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#totalCapacity">http://vocab.datex.org/terms#totalCapacity</seealso>
    let totalCapacity = Prefixed_Name(datex, "totalCapacity") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonRoadEventInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about an event which is not on the road, but which may influence the behaviour of drivers and hence the characteristics of the traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonRoadEventInformation">http://vocab.datex.org/terms#NonRoadEventInformation</seealso>
    let NonRoadEventInformation =
        Prefixed_Name(datex, "NonRoadEventInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:CatalogueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identification of the supplier's data catalogue in a data exchange context.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#CatalogueReference">http://vocab.datex.org/terms#CatalogueReference</seealso>
    let CatalogueReference = Prefixed_Name(datex, "CatalogueReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:catalogueReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#catalogueReferenceExtension">http://vocab.datex.org/terms#catalogueReferenceExtension</seealso>
    let catalogueReferenceExtension =
        Prefixed_Name(datex, "catalogueReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:keyCatalogueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#keyCatalogueReference">http://vocab.datex.org/terms#keyCatalogueReference</seealso>
    let keyCatalogueReference =
        Prefixed_Name(datex, "keyCatalogueReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:Cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains details of the cause of a record within a situation</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Cause">http://vocab.datex.org/terms#Cause</seealso>
    let Cause = Prefixed_Name(datex, "Cause") |> PrefixedName
    /// <summary>
    ///   <para>datex:causeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#causeExtension">http://vocab.datex.org/terms#causeExtension</seealso>
    let causeExtension = Prefixed_Name(datex, "causeExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:Charge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particular charge for a specified interval belonging a charge band.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Charge">http://vocab.datex.org/terms#Charge</seealso>
    let Charge = Prefixed_Name(datex, "Charge") |> PrefixedName
    /// <summary>
    ///   <para>datex:charge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#charge">http://vocab.datex.org/terms#charge</seealso>
    let charge = Prefixed_Name(datex, "charge") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeExtension">http://vocab.datex.org/terms#chargeExtension</seealso>
    let chargeExtension = Prefixed_Name(datex, "chargeExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeInterval">http://vocab.datex.org/terms#chargeInterval</seealso>
    let chargeInterval = Prefixed_Name(datex, "chargeInterval") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargeOrderIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeOrderIndex">http://vocab.datex.org/terms#chargeOrderIndex</seealso>
    let chargeOrderIndex = Prefixed_Name(datex, "chargeOrderIndex") |> PrefixedName
    /// <summary>
    ///   <para>datex:timePeriodOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timePeriodOfDay">http://vocab.datex.org/terms#timePeriodOfDay</seealso>
    let timePeriodOfDay = Prefixed_Name(datex, "timePeriodOfDay") |> PrefixedName
    /// <summary>
    ///   <para>datex:TimePeriodOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of a continuous period of time within a 24 hour period.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TimePeriodOfDay">http://vocab.datex.org/terms#TimePeriodOfDay</seealso>
    let TimePeriodOfDay = Prefixed_Name(datex, "TimePeriodOfDay") |> PrefixedName
    /// <summary>
    ///   <para>datex:ChargeBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A charge band in accordance with the specified conditions, possibly up to a maximum duration, during a specified period and for a vehicle of specified characteristics (in case of parking).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ChargeBand">http://vocab.datex.org/terms#ChargeBand</seealso>
    let ChargeBand = Prefixed_Name(datex, "ChargeBand") |> PrefixedName
    /// <summary>
    ///   <para>datex:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#version">http://vocab.datex.org/terms#version</seealso>
    let version = Prefixed_Name(datex, "version") |> PrefixedName
    /// <summary>
    ///   <para>datex:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#id">http://vocab.datex.org/terms#id</seealso>
    let id = Prefixed_Name(datex, "id") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicableForPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableForPeriod">http://vocab.datex.org/terms#applicableForPeriod</seealso>
    let applicableForPeriod =
        Prefixed_Name(datex, "applicableForPeriod") |> PrefixedName

    /// <summary>
    ///   <para>datex:OverallPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OverallPeriod">http://vocab.datex.org/terms#OverallPeriod</seealso>
    let OverallPeriod = Prefixed_Name(datex, "OverallPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:applicableForUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableForUser">http://vocab.datex.org/terms#applicableForUser</seealso>
    let applicableForUser = Prefixed_Name(datex, "applicableForUser") |> PrefixedName

    /// <summary>
    ///   <para>datex:applicableForVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#applicableForVehicles">http://vocab.datex.org/terms#applicableForVehicles</seealso>
    let applicableForVehicles =
        Prefixed_Name(datex, "applicableForVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCharacteristics">http://vocab.datex.org/terms#VehicleCharacteristics</seealso>
    let VehicleCharacteristics =
        Prefixed_Name(datex, "VehicleCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBandExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBandExtension">http://vocab.datex.org/terms#chargeBandExtension</seealso>
    let chargeBandExtension =
        Prefixed_Name(datex, "chargeBandExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBandName">http://vocab.datex.org/terms#chargeBandName</seealso>
    let chargeBandName = Prefixed_Name(datex, "chargeBandName") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargeCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeCurrency">http://vocab.datex.org/terms#chargeCurrency</seealso>
    let chargeCurrency = Prefixed_Name(datex, "chargeCurrency") |> PrefixedName
    /// <summary>
    ///   <para>datex:maximumDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumDuration">http://vocab.datex.org/terms#maximumDuration</seealso>
    let maximumDuration = Prefixed_Name(datex, "maximumDuration") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingPermit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPermit">http://vocab.datex.org/terms#parkingPermit</seealso>
    let parkingPermit = Prefixed_Name(datex, "parkingPermit") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingPermit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A permission for parking.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingPermit">http://vocab.datex.org/terms#ParkingPermit</seealso>
    let ParkingPermit = Prefixed_Name(datex, "ParkingPermit") |> PrefixedName
    /// <summary>
    ///   <para>datex:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A free text comment with an optional date/time stamp that can be used by the operator to convey un-coded observations/information.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Comment">http://vocab.datex.org/terms#Comment</seealso>
    let Comment = Prefixed_Name(datex, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>datex:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#comment">http://vocab.datex.org/terms#comment</seealso>
    let comment = Prefixed_Name(datex, "comment") |> PrefixedName
    /// <summary>
    ///   <para>datex:commentDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#commentDateTime">http://vocab.datex.org/terms#commentDateTime</seealso>
    let commentDateTime = Prefixed_Name(datex, "commentDateTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:commentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#commentExtension">http://vocab.datex.org/terms#commentExtension</seealso>
    let commentExtension = Prefixed_Name(datex, "commentExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:commentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#commentType">http://vocab.datex.org/terms#commentType</seealso>
    let commentType = Prefixed_Name(datex, "commentType") |> PrefixedName

    /// <summary>
    ///   <para>datex:ConcentrationOfVehiclesValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the concentration of vehicles on a unit stretch of road in a given direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ConcentrationOfVehiclesValue">http://vocab.datex.org/terms#ConcentrationOfVehiclesValue</seealso>
    let ConcentrationOfVehiclesValue =
        Prefixed_Name(datex, "ConcentrationOfVehiclesValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:concentrationOfVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of traffic density expressed in the number of vehicles per kilometre of road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#concentrationOfVehicles">http://vocab.datex.org/terms#concentrationOfVehicles</seealso>
    let concentrationOfVehicles =
        Prefixed_Name(datex, "concentrationOfVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:concentrationOfVehiclesValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#concentrationOfVehiclesValueExtension">http://vocab.datex.org/terms#concentrationOfVehiclesValueExtension</seealso>
    let concentrationOfVehiclesValueExtension =
        Prefixed_Name(datex, "concentrationOfVehiclesValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:conditionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#conditionsExtension">http://vocab.datex.org/terms#conditionsExtension</seealso>
    let conditionsExtension =
        Prefixed_Name(datex, "conditionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:drivingConditionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Description of the driving conditions at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#drivingConditionType">http://vocab.datex.org/terms#drivingConditionType</seealso>
    let drivingConditionType =
        Prefixed_Name(datex, "drivingConditionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:ConstructionWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Roadworks involving the construction of new infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ConstructionWorks">http://vocab.datex.org/terms#ConstructionWorks</seealso>
    let ConstructionWorks = Prefixed_Name(datex, "ConstructionWorks") |> PrefixedName

    /// <summary>
    ///   <para>datex:constructionWorkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of construction work being performed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#constructionWorkType">http://vocab.datex.org/terms#constructionWorkType</seealso>
    let constructionWorkType =
        Prefixed_Name(datex, "constructionWorkType") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactExtension">http://vocab.datex.org/terms#contactExtension</seealso>
    let contactExtension = Prefixed_Name(datex, "contactExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:contactNotDefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactNotDefined">http://vocab.datex.org/terms#contactNotDefined</seealso>
    let contactNotDefined = Prefixed_Name(datex, "contactNotDefined") |> PrefixedName
    /// <summary>
    ///   <para>datex:contactUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactUnknown">http://vocab.datex.org/terms#contactUnknown</seealso>
    let contactUnknown = Prefixed_Name(datex, "contactUnknown") |> PrefixedName
    /// <summary>
    ///   <para>datex:validityOfContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validityOfContact">http://vocab.datex.org/terms#validityOfContact</seealso>
    let validityOfContact = Prefixed_Name(datex, "validityOfContact") |> PrefixedName
    /// <summary>
    ///   <para>datex:ContactByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contact information that is addressed via a reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ContactByReference">http://vocab.datex.org/terms#ContactByReference</seealso>
    let ContactByReference = Prefixed_Name(datex, "ContactByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactByReferenceExtension">http://vocab.datex.org/terms#contactByReferenceExtension</seealso>
    let contactByReferenceExtension =
        Prefixed_Name(datex, "contactByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Contact information provided by a reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactReference">http://vocab.datex.org/terms#contactReference</seealso>
    let contactReference = Prefixed_Name(datex, "contactReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ContactDetailsVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ContactDetailsVersionedReference">http://vocab.datex.org/terms#_ContactDetailsVersionedReference</seealso>
    let _ContactDetailsVersionedReference =
        Prefixed_Name(datex, "_ContactDetailsVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:ContactDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details for some person, service or the parking site itself, especially address information.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ContactDetails">http://vocab.datex.org/terms#ContactDetails</seealso>
    let ContactDetails = Prefixed_Name(datex, "ContactDetails") |> PrefixedName
    /// <summary>
    ///   <para>datex:available24hours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies if the availability is 24 hours a day. If omitted, this information is unknown or heterogeneous.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#available24hours">http://vocab.datex.org/terms#available24hours</seealso>
    let available24hours = Prefixed_Name(datex, "available24hours") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Complete address of the contact. Alternatively use the separate fields to describe the address.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsAddress">http://vocab.datex.org/terms#contactDetailsAddress</seealso>
    let contactDetailsAddress =
        Prefixed_Name(datex, "contactDetailsAddress") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>City of the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsCity">http://vocab.datex.org/terms#contactDetailsCity</seealso>
    let contactDetailsCity = Prefixed_Name(datex, "contactDetailsCity") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsEMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>E-Mail address of the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsEMail">http://vocab.datex.org/terms#contactDetailsEMail</seealso>
    let contactDetailsEMail =
        Prefixed_Name(datex, "contactDetailsEMail") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsExtension">http://vocab.datex.org/terms#contactDetailsExtension</seealso>
    let contactDetailsExtension =
        Prefixed_Name(datex, "contactDetailsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsFax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Fax of the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsFax">http://vocab.datex.org/terms#contactDetailsFax</seealso>
    let contactDetailsFax = Prefixed_Name(datex, "contactDetailsFax") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsHouseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>House number of the contact. Supports a multiplicity up to two, to specify lower and upper numbers.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsHouseNumber">http://vocab.datex.org/terms#contactDetailsHouseNumber</seealso>
    let contactDetailsHouseNumber =
        Prefixed_Name(datex, "contactDetailsHouseNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Language(s) this contact is able to speak resp. understand.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsLanguage">http://vocab.datex.org/terms#contactDetailsLanguage</seealso>
    let contactDetailsLanguage =
        Prefixed_Name(datex, "contactDetailsLanguage") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsLogoUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Url to define a logo of this contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsLogoUrl">http://vocab.datex.org/terms#contactDetailsLogoUrl</seealso>
    let contactDetailsLogoUrl =
        Prefixed_Name(datex, "contactDetailsLogoUrl") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsMoreInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Additional information relating to the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsMoreInfo">http://vocab.datex.org/terms#contactDetailsMoreInfo</seealso>
    let contactDetailsMoreInfo =
        Prefixed_Name(datex, "contactDetailsMoreInfo") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information if the contact in question is a private or public institution.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsOwnership">http://vocab.datex.org/terms#contactDetailsOwnership</seealso>
    let contactDetailsOwnership =
        Prefixed_Name(datex, "contactDetailsOwnership") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsPostcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Postcode of the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsPostcode">http://vocab.datex.org/terms#contactDetailsPostcode</seealso>
    let contactDetailsPostcode =
        Prefixed_Name(datex, "contactDetailsPostcode") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specification of what service or equipment the contact is responsible for.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsResponsibility">http://vocab.datex.org/terms#contactDetailsResponsibility</seealso>
    let contactDetailsResponsibility =
        Prefixed_Name(datex, "contactDetailsResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsStreet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Street of the contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsStreet">http://vocab.datex.org/terms#contactDetailsStreet</seealso>
    let contactDetailsStreet =
        Prefixed_Name(datex, "contactDetailsStreet") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactDetailsTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Telephone Number of contact.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactDetailsTelephoneNumber">http://vocab.datex.org/terms#contactDetailsTelephoneNumber</seealso>
    let contactDetailsTelephoneNumber =
        Prefixed_Name(datex, "contactDetailsTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactOrganisationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Name of the organisation or service. Do not use this attribute in combination with role "parkingSiteAddress".</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactOrganisationName">http://vocab.datex.org/terms#contactOrganisationName</seealso>
    let contactOrganisationName =
        Prefixed_Name(datex, "contactOrganisationName") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactPersonFirstName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>First name of the contact person.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactPersonFirstName">http://vocab.datex.org/terms#contactPersonFirstName</seealso>
    let contactPersonFirstName =
        Prefixed_Name(datex, "contactPersonFirstName") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactPersonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the contact person.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactPersonName">http://vocab.datex.org/terms#contactPersonName</seealso>
    let contactPersonName = Prefixed_Name(datex, "contactPersonName") |> PrefixedName

    /// <summary>
    ///   <para>datex:contactPersonPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The position of the contact person.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#contactPersonPosition">http://vocab.datex.org/terms#contactPersonPosition</seealso>
    let contactPersonPosition =
        Prefixed_Name(datex, "contactPersonPosition") |> PrefixedName

    /// <summary>
    ///   <para>datex:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ISO 3166-1 two character country code.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#country">http://vocab.datex.org/terms#country</seealso>
    let country = Prefixed_Name(datex, "country") |> PrefixedName
    /// <summary>
    ///   <para>datex:groupOfLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfLocations">http://vocab.datex.org/terms#groupOfLocations</seealso>
    let groupOfLocations = Prefixed_Name(datex, "groupOfLocations") |> PrefixedName

    /// <summary>
    ///   <para>datex:publishingAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication, whether the contact accepted publishing its contact information.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publishingAgreement">http://vocab.datex.org/terms#publishingAgreement</seealso>
    let publishingAgreement =
        Prefixed_Name(datex, "publishingAgreement") |> PrefixedName

    /// <summary>
    ///   <para>datex:urlLinkAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urlLinkAddress">http://vocab.datex.org/terms#urlLinkAddress</seealso>
    let urlLinkAddress = Prefixed_Name(datex, "urlLinkAddress") |> PrefixedName
    /// <summary>
    ///   <para>datex:ElectricCharging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Additional information for the equipment 'electricChargingStation'. This component refers to the number of charging stations specified in the attribute 'numberOfEquipmentOrServiceFacilities'.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ElectricCharging">http://vocab.datex.org/terms#ElectricCharging</seealso>
    let ElectricCharging = Prefixed_Name(datex, "ElectricCharging") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargingStationConnectorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargingStationConnectorType">http://vocab.datex.org/terms#chargingStationConnectorType</seealso>
    let chargingStationConnectorType =
        Prefixed_Name(datex, "chargingStationConnectorType") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargingStationModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargingStationModelType">http://vocab.datex.org/terms#chargingStationModelType</seealso>
    let chargingStationModelType =
        Prefixed_Name(datex, "chargingStationModelType") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargingStationUsageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargingStationUsageType">http://vocab.datex.org/terms#chargingStationUsageType</seealso>
    let chargingStationUsageType =
        Prefixed_Name(datex, "chargingStationUsageType") |> PrefixedName

    /// <summary>
    ///   <para>datex:electricChargingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#electricChargingExtension">http://vocab.datex.org/terms#electricChargingExtension</seealso>
    let electricChargingExtension =
        Prefixed_Name(datex, "electricChargingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumCurrent">http://vocab.datex.org/terms#maximumCurrent</seealso>
    let maximumCurrent = Prefixed_Name(datex, "maximumCurrent") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfChargingPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfChargingPoints">http://vocab.datex.org/terms#numberOfChargingPoints</seealso>
    let numberOfChargingPoints =
        Prefixed_Name(datex, "numberOfChargingPoints") |> PrefixedName

    /// <summary>
    ///   <para>datex:voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#voltage">http://vocab.datex.org/terms#voltage</seealso>
    let voltage = Prefixed_Name(datex, "voltage") |> PrefixedName
    /// <summary>
    ///   <para>datex:depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The depth of flooding or of snow on the road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#depth">http://vocab.datex.org/terms#depth</seealso>
    let depth = Prefixed_Name(datex, "depth") |> PrefixedName

    /// <summary>
    ///   <para>datex:environmentalObstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#environmentalObstructionExtension">http://vocab.datex.org/terms#environmentalObstructionExtension</seealso>
    let environmentalObstructionExtension =
        Prefixed_Name(datex, "environmentalObstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:environmentalObstructionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Characterization of an obstruction on the road resulting from an environmental cause.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#environmentalObstructionType">http://vocab.datex.org/terms#environmentalObstructionType</seealso>
    let environmentalObstructionType =
        Prefixed_Name(datex, "environmentalObstructionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>One type of equipment, that is available on the parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentType">http://vocab.datex.org/terms#equipmentType</seealso>
    let equipmentType = Prefixed_Name(datex, "equipmentType") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One type of equipment or additional service facility that is available at the parking site, parking space or group of parking spaces.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacility">http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacility</seealso>
    let ParkingEquipmentOrServiceFacility =
        Prefixed_Name(datex, "ParkingEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:EquipmentOrSystemFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Equipment or system which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EquipmentOrSystemFault">http://vocab.datex.org/terms#EquipmentOrSystemFault</seealso>
    let EquipmentOrSystemFault =
        Prefixed_Name(datex, "EquipmentOrSystemFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentOrSystemFaultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentOrSystemFaultExtension">http://vocab.datex.org/terms#equipmentOrSystemFaultExtension</seealso>
    let equipmentOrSystemFaultExtension =
        Prefixed_Name(datex, "equipmentOrSystemFaultExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentOrSystemFaultType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Failure, malfunction or non operational condition of equipment or system.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentOrSystemFaultType">http://vocab.datex.org/terms#equipmentOrSystemFaultType</seealso>
    let equipmentOrSystemFaultType =
        Prefixed_Name(datex, "equipmentOrSystemFaultType") |> PrefixedName

    /// <summary>
    ///   <para>datex:faultyEquipmentOrSystemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of equipment or system which is faulty, malfunctioning or not in a fully operational state.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultyEquipmentOrSystemType">http://vocab.datex.org/terms#faultyEquipmentOrSystemType</seealso>
    let faultyEquipmentOrSystemType =
        Prefixed_Name(datex, "faultyEquipmentOrSystemType") |> PrefixedName

    /// <summary>
    ///   <para>datex:catalogueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#catalogueReference">http://vocab.datex.org/terms#catalogueReference</seealso>
    let catalogueReference = Prefixed_Name(datex, "catalogueReference") |> PrefixedName
    /// <summary>
    ///   <para>datex:changedFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#changedFlag">http://vocab.datex.org/terms#changedFlag</seealso>
    let changedFlag = Prefixed_Name(datex, "changedFlag") |> PrefixedName

    /// <summary>
    ///   <para>datex:clientIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#clientIdentification">http://vocab.datex.org/terms#clientIdentification</seealso>
    let clientIdentification =
        Prefixed_Name(datex, "clientIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:deliveryBreak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deliveryBreak">http://vocab.datex.org/terms#deliveryBreak</seealso>
    let deliveryBreak = Prefixed_Name(datex, "deliveryBreak") |> PrefixedName
    /// <summary>
    ///   <para>datex:denyReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#denyReason">http://vocab.datex.org/terms#denyReason</seealso>
    let denyReason = Prefixed_Name(datex, "denyReason") |> PrefixedName
    /// <summary>
    ///   <para>datex:exchangeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exchangeExtension">http://vocab.datex.org/terms#exchangeExtension</seealso>
    let exchangeExtension = Prefixed_Name(datex, "exchangeExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:filterReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterReference">http://vocab.datex.org/terms#filterReference</seealso>
    let filterReference = Prefixed_Name(datex, "filterReference") |> PrefixedName
    /// <summary>
    ///   <para>datex:FilterReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of a supplier's filter in a data exchange context.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FilterReference">http://vocab.datex.org/terms#FilterReference</seealso>
    let FilterReference = Prefixed_Name(datex, "FilterReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:historicalStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#historicalStartDate">http://vocab.datex.org/terms#historicalStartDate</seealso>
    let historicalStartDate =
        Prefixed_Name(datex, "historicalStartDate") |> PrefixedName

    /// <summary>
    ///   <para>datex:historicalStopDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#historicalStopDate">http://vocab.datex.org/terms#historicalStopDate</seealso>
    let historicalStopDate = Prefixed_Name(datex, "historicalStopDate") |> PrefixedName
    /// <summary>
    ///   <para>datex:subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscription">http://vocab.datex.org/terms#subscription</seealso>
    let subscription = Prefixed_Name(datex, "subscription") |> PrefixedName
    /// <summary>
    ///   <para>datex:Subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This item contains all information relating to a customer subscription.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Subscription">http://vocab.datex.org/terms#Subscription</seealso>
    let Subscription = Prefixed_Name(datex, "Subscription") |> PrefixedName

    /// <summary>
    ///   <para>datex:subscriptionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subscriptionReference">http://vocab.datex.org/terms#subscriptionReference</seealso>
    let subscriptionReference =
        Prefixed_Name(datex, "subscriptionReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplierIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplierIdentification">http://vocab.datex.org/terms#supplierIdentification</seealso>
    let supplierIdentification =
        Prefixed_Name(datex, "supplierIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:InternationalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifier/name whose range is specific to the particular country.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InternationalIdentifier">http://vocab.datex.org/terms#InternationalIdentifier</seealso>
    let InternationalIdentifier =
        Prefixed_Name(datex, "InternationalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#target">http://vocab.datex.org/terms#target</seealso>
    let target = Prefixed_Name(datex, "target") |> PrefixedName
    /// <summary>
    ///   <para>datex:Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The details of a DATEX II target client.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Target">http://vocab.datex.org/terms#Target</seealso>
    let Target = Prefixed_Name(datex, "Target") |> PrefixedName

    /// <summary>
    ///   <para>datex:ExternalReferencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location defined by reference to an external/other referencing system.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ExternalReferencing">http://vocab.datex.org/terms#ExternalReferencing</seealso>
    let ExternalReferencing =
        Prefixed_Name(datex, "ExternalReferencing") |> PrefixedName

    /// <summary>
    ///   <para>datex:externalLocationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#externalLocationCode">http://vocab.datex.org/terms#externalLocationCode</seealso>
    let externalLocationCode =
        Prefixed_Name(datex, "externalLocationCode") |> PrefixedName

    /// <summary>
    ///   <para>datex:externalReferencingExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#externalReferencingExtension">http://vocab.datex.org/terms#externalReferencingExtension</seealso>
    let externalReferencingExtension =
        Prefixed_Name(datex, "externalReferencingExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:externalReferencingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#externalReferencingSystem">http://vocab.datex.org/terms#externalReferencingSystem</seealso>
    let externalReferencingSystem =
        Prefixed_Name(datex, "externalReferencingSystem") |> PrefixedName

    /// <summary>
    ///   <para>datex:faultDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultDescription">http://vocab.datex.org/terms#faultDescription</seealso>
    let faultDescription = Prefixed_Name(datex, "faultDescription") |> PrefixedName
    /// <summary>
    ///   <para>datex:faultExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultExtension">http://vocab.datex.org/terms#faultExtension</seealso>
    let faultExtension = Prefixed_Name(datex, "faultExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:faultIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultIdentifier">http://vocab.datex.org/terms#faultIdentifier</seealso>
    let faultIdentifier = Prefixed_Name(datex, "faultIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:faultLastUpdateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultLastUpdateTime">http://vocab.datex.org/terms#faultLastUpdateTime</seealso>
    let faultLastUpdateTime =
        Prefixed_Name(datex, "faultLastUpdateTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:faultSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#faultSeverity">http://vocab.datex.org/terms#faultSeverity</seealso>
    let faultSeverity = Prefixed_Name(datex, "faultSeverity") |> PrefixedName

    /// <summary>
    ///   <para>datex:FilterExitManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Filter indicators management information.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FilterExitManagement">http://vocab.datex.org/terms#FilterExitManagement</seealso>
    let FilterExitManagement =
        Prefixed_Name(datex, "FilterExitManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterEnd">http://vocab.datex.org/terms#filterEnd</seealso>
    let filterEnd = Prefixed_Name(datex, "filterEnd") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterExitManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterExitManagementExtension">http://vocab.datex.org/terms#filterExitManagementExtension</seealso>
    let filterExitManagementExtension =
        Prefixed_Name(datex, "filterExitManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterOutOfRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterOutOfRange">http://vocab.datex.org/terms#filterOutOfRange</seealso>
    let filterOutOfRange = Prefixed_Name(datex, "filterOutOfRange") |> PrefixedName
    /// <summary>
    ///   <para>datex:deleteFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#deleteFilter">http://vocab.datex.org/terms#deleteFilter</seealso>
    let deleteFilter = Prefixed_Name(datex, "deleteFilter") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterOperationApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterOperationApproved">http://vocab.datex.org/terms#filterOperationApproved</seealso>
    let filterOperationApproved =
        Prefixed_Name(datex, "filterOperationApproved") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterReferenceExtension">http://vocab.datex.org/terms#filterReferenceExtension</seealso>
    let filterReferenceExtension =
        Prefixed_Name(datex, "filterReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:IndividualCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information on the individual charge for parking the specified vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IndividualCharge">http://vocab.datex.org/terms#IndividualCharge</seealso>
    let IndividualCharge = Prefixed_Name(datex, "IndividualCharge") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargePaid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargePaid">http://vocab.datex.org/terms#chargePaid</seealso>
    let chargePaid = Prefixed_Name(datex, "chargePaid") |> PrefixedName

    /// <summary>
    ///   <para>datex:individualChargeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#individualChargeExtension">http://vocab.datex.org/terms#individualChargeExtension</seealso>
    let individualChargeExtension =
        Prefixed_Name(datex, "individualChargeExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:usedMeansOfPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#usedMeansOfPayment">http://vocab.datex.org/terms#usedMeansOfPayment</seealso>
    let usedMeansOfPayment = Prefixed_Name(datex, "usedMeansOfPayment") |> PrefixedName
    /// <summary>
    ///   <para>datex:usedPaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#usedPaymentCard">http://vocab.datex.org/terms#usedPaymentCard</seealso>
    let usedPaymentCard = Prefixed_Name(datex, "usedPaymentCard") |> PrefixedName
    /// <summary>
    ///   <para>datex:UsedPaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The used payment card for this parking vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UsedPaymentCard">http://vocab.datex.org/terms#UsedPaymentCard</seealso>
    let UsedPaymentCard = Prefixed_Name(datex, "UsedPaymentCard") |> PrefixedName
    /// <summary>
    ///   <para>datex:withReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#withReservation">http://vocab.datex.org/terms#withReservation</seealso>
    let withReservation = Prefixed_Name(datex, "withReservation") |> PrefixedName

    /// <summary>
    ///   <para>datex:IndividualVehicleDataValues</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measured or calculated data values relating to individual vehicles derived from detectors at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IndividualVehicleDataValues">http://vocab.datex.org/terms#IndividualVehicleDataValues</seealso>
    let IndividualVehicleDataValues =
        Prefixed_Name(datex, "IndividualVehicleDataValues") |> PrefixedName

    /// <summary>
    ///   <para>datex:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time of the arrival of an individual vehicle in a detection zone.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#arrivalTime">http://vocab.datex.org/terms#arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(datex, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:distanceGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The measured distance between the front of this vehicle and the rear of the preceding one, in metres at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceGap">http://vocab.datex.org/terms#distanceGap</seealso>
    let distanceGap = Prefixed_Name(datex, "distanceGap") |> PrefixedName

    /// <summary>
    ///   <para>datex:individualVehicleSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The measured speed of the individual vehicle at the specified measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#individualVehicleSpeed">http://vocab.datex.org/terms#individualVehicleSpeed</seealso>
    let individualVehicleSpeed =
        Prefixed_Name(datex, "individualVehicleSpeed") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpeedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of speed.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedValue">http://vocab.datex.org/terms#SpeedValue</seealso>
    let SpeedValue = Prefixed_Name(datex, "SpeedValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:passageDurationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time elapsed between an individual vehicle entering a detection zone and exiting the same detection zone as detected by entry and exit sensors.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#passageDurationTime">http://vocab.datex.org/terms#passageDurationTime</seealso>
    let passageDurationTime =
        Prefixed_Name(datex, "passageDurationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:presenceDurationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The period of time during which a vehicle activates a presence sensor.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#presenceDurationTime">http://vocab.datex.org/terms#presenceDurationTime</seealso>
    let presenceDurationTime =
        Prefixed_Name(datex, "presenceDurationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:timeGap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time interval between the arrival of this vehicle's front at a point on the roadway, and that of the departure of the rear of the preceding one.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timeGap">http://vocab.datex.org/terms#timeGap</seealso>
    let timeGap = Prefixed_Name(datex, "timeGap") |> PrefixedName
    /// <summary>
    ///   <para>datex:timeHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The measured time interval between this vehicle's arrival at (or departure from) a point on the roadway, and that of the preceding one.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timeHeadway">http://vocab.datex.org/terms#timeHeadway</seealso>
    let timeHeadway = Prefixed_Name(datex, "timeHeadway") |> PrefixedName
    /// <summary>
    ///   <para>datex:TrafficData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measured or derived values relating to traffic or individual vehicle movements on a specific section or at a specific point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TrafficData">http://vocab.datex.org/terms#TrafficData</seealso>
    let TrafficData = Prefixed_Name(datex, "TrafficData") |> PrefixedName

    /// <summary>
    ///   <para>datex:infrastructureDamageObstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#infrastructureDamageObstructionExtension">http://vocab.datex.org/terms#infrastructureDamageObstructionExtension</seealso>
    let infrastructureDamageObstructionExtension =
        Prefixed_Name(datex, "infrastructureDamageObstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:infrastructureDamageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Characterization of an obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#infrastructureDamageType">http://vocab.datex.org/terms#infrastructureDamageType</seealso>
    let infrastructureDamageType =
        Prefixed_Name(datex, "infrastructureDamageType") |> PrefixedName

    /// <summary>
    ///   <para>datex:IntegerMetreDistanceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of distance in whole metres.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#IntegerMetreDistanceValue">http://vocab.datex.org/terms#IntegerMetreDistanceValue</seealso>
    let IntegerMetreDistanceValue =
        Prefixed_Name(datex, "IntegerMetreDistanceValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:integerMetreDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of distance expressed in metres in a non negative integer format.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#integerMetreDistance">http://vocab.datex.org/terms#integerMetreDistance</seealso>
    let integerMetreDistance =
        Prefixed_Name(datex, "integerMetreDistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:integerMetreDistanceValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#integerMetreDistanceValueExtension">http://vocab.datex.org/terms#integerMetreDistanceValueExtension</seealso>
    let integerMetreDistanceValueExtension =
        Prefixed_Name(datex, "integerMetreDistanceValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:Management</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information relating to the management of the situation record.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Management">http://vocab.datex.org/terms#Management</seealso>
    let Management = Prefixed_Name(datex, "Management") |> PrefixedName

    /// <summary>
    ///   <para>datex:filterExitManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#filterExitManagement">http://vocab.datex.org/terms#filterExitManagement</seealso>
    let filterExitManagement =
        Prefixed_Name(datex, "filterExitManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:lifeCycleManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lifeCycleManagement">http://vocab.datex.org/terms#lifeCycleManagement</seealso>
    let lifeCycleManagement =
        Prefixed_Name(datex, "lifeCycleManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:managementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#managementExtension">http://vocab.datex.org/terms#managementExtension</seealso>
    let managementExtension =
        Prefixed_Name(datex, "managementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasuredDataPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more measurement data sets, each set being measured at a single measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasuredDataPublication">http://vocab.datex.org/terms#MeasuredDataPublication</seealso>
    let MeasuredDataPublication =
        Prefixed_Name(datex, "MeasuredDataPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:measuredDataPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measuredDataPublicationExtension">http://vocab.datex.org/terms#measuredDataPublicationExtension</seealso>
    let measuredDataPublicationExtension =
        Prefixed_Name(datex, "measuredDataPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteTableReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned Measurement Site table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteTableReference">http://vocab.datex.org/terms#measurementSiteTableReference</seealso>
    let measurementSiteTableReference =
        Prefixed_Name(datex, "measurementSiteTableReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_MeasurementSiteTableVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_MeasurementSiteTableVersionedReference">http://vocab.datex.org/terms#_MeasurementSiteTableVersionedReference</seealso>
    let _MeasurementSiteTableVersionedReference =
        Prefixed_Name(datex, "_MeasurementSiteTableVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:siteMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#siteMeasurements">http://vocab.datex.org/terms#siteMeasurements</seealso>
    let siteMeasurements = Prefixed_Name(datex, "siteMeasurements") |> PrefixedName
    /// <summary>
    ///   <para>datex:SiteMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A  measurement data set derived from a specific measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SiteMeasurements">http://vocab.datex.org/terms#SiteMeasurements</seealso>
    let SiteMeasurements = Prefixed_Name(datex, "SiteMeasurements") |> PrefixedName
    /// <summary>
    ///   <para>datex:MeasuredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contains optional characteristics for the specific measured value (indexed to correspond with the defined characteristics of the measurement at the referenced measurement site) which override the static characteristics defined in the MeasurementSiteTable.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasuredValue">http://vocab.datex.org/terms#MeasuredValue</seealso>
    let MeasuredValue = Prefixed_Name(datex, "MeasuredValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationCharacteristicsOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationCharacteristicsOverride">http://vocab.datex.org/terms#locationCharacteristicsOverride</seealso>
    let locationCharacteristicsOverride =
        Prefixed_Name(datex, "locationCharacteristicsOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:measuredValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measuredValueExtension">http://vocab.datex.org/terms#measuredValueExtension</seealso>
    let measuredValueExtension =
        Prefixed_Name(datex, "measuredValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementEquipmentFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>The type of fault which is being reported for the specified measurement equipment.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementEquipmentFault">http://vocab.datex.org/terms#measurementEquipmentFault</seealso>
    let measurementEquipmentFault =
        Prefixed_Name(datex, "measurementEquipmentFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasurementEquipmentFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of a fault which is being reported for the related measurement equipment.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasurementEquipmentFault">http://vocab.datex.org/terms#MeasurementEquipmentFault</seealso>
    let MeasurementEquipmentFault =
        Prefixed_Name(datex, "MeasurementEquipmentFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasurementSiteRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable single measurement site entry/record in the Measurement Site table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasurementSiteRecord">http://vocab.datex.org/terms#MeasurementSiteRecord</seealso>
    let MeasurementSiteRecord =
        Prefixed_Name(datex, "MeasurementSiteRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:computationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#computationMethod">http://vocab.datex.org/terms#computationMethod</seealso>
    let computationMethod = Prefixed_Name(datex, "computationMethod") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementEquipmentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementEquipmentReference">http://vocab.datex.org/terms#measurementEquipmentReference</seealso>
    let measurementEquipmentReference =
        Prefixed_Name(datex, "measurementEquipmentReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSide">http://vocab.datex.org/terms#measurementSide</seealso>
    let measurementSide = Prefixed_Name(datex, "measurementSide") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteIdentification">http://vocab.datex.org/terms#measurementSiteIdentification</seealso>
    let measurementSiteIdentification =
        Prefixed_Name(datex, "measurementSiteIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteLocation">http://vocab.datex.org/terms#measurementSiteLocation</seealso>
    let measurementSiteLocation =
        Prefixed_Name(datex, "measurementSiteLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteName">http://vocab.datex.org/terms#measurementSiteName</seealso>
    let measurementSiteName =
        Prefixed_Name(datex, "measurementSiteName") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteNumberOfLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteNumberOfLanes">http://vocab.datex.org/terms#measurementSiteNumberOfLanes</seealso>
    let measurementSiteNumberOfLanes =
        Prefixed_Name(datex, "measurementSiteNumberOfLanes") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteRecordExtension">http://vocab.datex.org/terms#measurementSiteRecordExtension</seealso>
    let measurementSiteRecordExtension =
        Prefixed_Name(datex, "measurementSiteRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteRecordVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteRecordVersionTime">http://vocab.datex.org/terms#measurementSiteRecordVersionTime</seealso>
    let measurementSiteRecordVersionTime =
        Prefixed_Name(datex, "measurementSiteRecordVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSpecificCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSpecificCharacteristics">http://vocab.datex.org/terms#measurementSpecificCharacteristics</seealso>
    let measurementSpecificCharacteristics =
        Prefixed_Name(datex, "measurementSpecificCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics">http://vocab.datex.org/terms#_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics</seealso>
    let _MeasurementSiteRecordIndexMeasurementSpecificCharacteristics =
        Prefixed_Name(datex, "_MeasurementSiteRecordIndexMeasurementSpecificCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteTableExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteTableExtension">http://vocab.datex.org/terms#measurementSiteTableExtension</seealso>
    let measurementSiteTableExtension =
        Prefixed_Name(datex, "measurementSiteTableExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteTableIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteTableIdentification">http://vocab.datex.org/terms#measurementSiteTableIdentification</seealso>
    let measurementSiteTableIdentification =
        Prefixed_Name(datex, "measurementSiteTableIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasurementSiteTablePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more Measurment Site Tables.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasurementSiteTablePublication">http://vocab.datex.org/terms#MeasurementSiteTablePublication</seealso>
    let MeasurementSiteTablePublication =
        Prefixed_Name(datex, "MeasurementSiteTablePublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteTable">http://vocab.datex.org/terms#measurementSiteTable</seealso>
    let measurementSiteTable =
        Prefixed_Name(datex, "measurementSiteTable") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteTablePublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteTablePublicationExtension">http://vocab.datex.org/terms#measurementSiteTablePublicationExtension</seealso>
    let measurementSiteTablePublicationExtension =
        Prefixed_Name(datex, "measurementSiteTablePublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasurementSpecificCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Characteristics which are specific to an individual measurement type (specified in a known order) at the given measurement site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasurementSpecificCharacteristics">http://vocab.datex.org/terms#MeasurementSpecificCharacteristics</seealso>
    let MeasurementSpecificCharacteristics =
        Prefixed_Name(datex, "MeasurementSpecificCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSpecificCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSpecificCharacteristicsExtension">http://vocab.datex.org/terms#measurementSpecificCharacteristicsExtension</seealso>
    let measurementSpecificCharacteristicsExtension =
        Prefixed_Name(datex, "measurementSpecificCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#period">http://vocab.datex.org/terms#period</seealso>
    let period = Prefixed_Name(datex, "period") |> PrefixedName
    /// <summary>
    ///   <para>datex:specificLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specificLane">http://vocab.datex.org/terms#specificLane</seealso>
    let specificLane = Prefixed_Name(datex, "specificLane") |> PrefixedName

    /// <summary>
    ///   <para>datex:specificMeasurementValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specificMeasurementValueType">http://vocab.datex.org/terms#specificMeasurementValueType</seealso>
    let specificMeasurementValueType =
        Prefixed_Name(datex, "specificMeasurementValueType") |> PrefixedName

    /// <summary>
    ///   <para>datex:specificVehicleCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specificVehicleCharacteristics">http://vocab.datex.org/terms#specificVehicleCharacteristics</seealso>
    let specificVehicleCharacteristics =
        Prefixed_Name(datex, "specificVehicleCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrGridLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrGridLocationReferenceExtension">http://vocab.datex.org/terms#openlrGridLocationReferenceExtension</seealso>
    let openlrGridLocationReferenceExtension =
        Prefixed_Name(datex, "openlrGridLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrRectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrRectangle">http://vocab.datex.org/terms#openlrRectangle</seealso>
    let openlrRectangle = Prefixed_Name(datex, "openlrRectangle") |> PrefixedName
    /// <summary>
    ///   <para>datex:OpenlrRectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>two geo-coordinate pairs defining the rectangular</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrRectangle">http://vocab.datex.org/terms#OpenlrRectangle</seealso>
    let OpenlrRectangle = Prefixed_Name(datex, "OpenlrRectangle") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLastLocationReferencePointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLastLocationReferencePointExtension">http://vocab.datex.org/terms#openlrLastLocationReferencePointExtension</seealso>
    let openlrLastLocationReferencePointExtension =
        Prefixed_Name(datex, "openlrLastLocationReferencePointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrBearing">http://vocab.datex.org/terms#openlrBearing</seealso>
    let openlrBearing = Prefixed_Name(datex, "openlrBearing") |> PrefixedName
    /// <summary>
    ///   <para>datex:openlrFormOfWay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrFormOfWay">http://vocab.datex.org/terms#openlrFormOfWay</seealso>
    let openlrFormOfWay = Prefixed_Name(datex, "openlrFormOfWay") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrFunctionalRoadClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrFunctionalRoadClass">http://vocab.datex.org/terms#openlrFunctionalRoadClass</seealso>
    let openlrFunctionalRoadClass =
        Prefixed_Name(datex, "openlrFunctionalRoadClass") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLineAttributesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLineAttributesExtension">http://vocab.datex.org/terms#openlrLineAttributesExtension</seealso>
    let openlrLineAttributesExtension =
        Prefixed_Name(datex, "openlrLineAttributesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLineLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLineLocationReferenceExtension">http://vocab.datex.org/terms#openlrLineLocationReferenceExtension</seealso>
    let openlrLineLocationReferenceExtension =
        Prefixed_Name(datex, "openlrLineLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrOffsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrOffsets">http://vocab.datex.org/terms#openlrOffsets</seealso>
    let openlrOffsets = Prefixed_Name(datex, "openlrOffsets") |> PrefixedName
    /// <summary>
    ///   <para>datex:OpenlrOffsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrOffsets">http://vocab.datex.org/terms#OpenlrOffsets</seealso>
    let OpenlrOffsets = Prefixed_Name(datex, "OpenlrOffsets") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPathAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPathAttributes">http://vocab.datex.org/terms#openlrPathAttributes</seealso>
    let openlrPathAttributes =
        Prefixed_Name(datex, "openlrPathAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPathAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The field path attributes is part of a location reference point (except for the last location reference point) and consists of lowest functional road class (LFRCNP) and distance to next point (DNP) data.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPathAttributes">http://vocab.datex.org/terms#OpenlrPathAttributes</seealso>
    let OpenlrPathAttributes =
        Prefixed_Name(datex, "OpenlrPathAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrNegativeOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrNegativeOffset">http://vocab.datex.org/terms#openlrNegativeOffset</seealso>
    let openlrNegativeOffset =
        Prefixed_Name(datex, "openlrNegativeOffset") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrOffsetsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrOffsetsExtension">http://vocab.datex.org/terms#openlrOffsetsExtension</seealso>
    let openlrOffsetsExtension =
        Prefixed_Name(datex, "openlrOffsetsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrDistanceToNextLRPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrDistanceToNextLRPoint">http://vocab.datex.org/terms#openlrDistanceToNextLRPoint</seealso>
    let openlrDistanceToNextLRPoint =
        Prefixed_Name(datex, "openlrDistanceToNextLRPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLowestFRCToNextLRPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLowestFRCToNextLRPoint">http://vocab.datex.org/terms#openlrLowestFRCToNextLRPoint</seealso>
    let openlrLowestFRCToNextLRPoint =
        Prefixed_Name(datex, "openlrLowestFRCToNextLRPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPathAttributesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPathAttributesExtension">http://vocab.datex.org/terms#openlrPathAttributesExtension</seealso>
    let openlrPathAttributesExtension =
        Prefixed_Name(datex, "openlrPathAttributesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPoiWithAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Point along line with access is a point location which is defined by a line,an offset value and a coordinate.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPoiWithAccessPoint">http://vocab.datex.org/terms#OpenlrPoiWithAccessPoint</seealso>
    let OpenlrPoiWithAccessPoint =
        Prefixed_Name(datex, "OpenlrPoiWithAccessPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPoiWithAccessPointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPoiWithAccessPointExtension">http://vocab.datex.org/terms#openlrPoiWithAccessPointExtension</seealso>
    let openlrPoiWithAccessPointExtension =
        Prefixed_Name(datex, "openlrPoiWithAccessPointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPointAlongLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Point along a line</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPointAlongLine">http://vocab.datex.org/terms#OpenlrPointAlongLine</seealso>
    let OpenlrPointAlongLine =
        Prefixed_Name(datex, "OpenlrPointAlongLine") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPointLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPointLocationReferenceExtension">http://vocab.datex.org/terms#openlrPointLocationReferenceExtension</seealso>
    let openlrPointLocationReferenceExtension =
        Prefixed_Name(datex, "openlrPointLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPolygonCorners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>geo-coordinate pairs. The coordinate pairs defining the corners of the underlying geometrical polygon.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPolygonCorners">http://vocab.datex.org/terms#OpenlrPolygonCorners</seealso>
    let OpenlrPolygonCorners =
        Prefixed_Name(datex, "OpenlrPolygonCorners") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPolygonCornersExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPolygonCornersExtension">http://vocab.datex.org/terms#openlrPolygonCornersExtension</seealso>
    let openlrPolygonCornersExtension =
        Prefixed_Name(datex, "openlrPolygonCornersExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrPolygonLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the openLR method of areadefinition by providing points that bound the area</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrPolygonLocationReference">http://vocab.datex.org/terms#OpenlrPolygonLocationReference</seealso>
    let OpenlrPolygonLocationReference =
        Prefixed_Name(datex, "OpenlrPolygonLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPolygonCorners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPolygonCorners">http://vocab.datex.org/terms#openlrPolygonCorners</seealso>
    let openlrPolygonCorners =
        Prefixed_Name(datex, "openlrPolygonCorners") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrPolygonLocationReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrPolygonLocationReferenceExtension">http://vocab.datex.org/terms#openlrPolygonLocationReferenceExtension</seealso>
    let openlrPolygonLocationReferenceExtension =
        Prefixed_Name(datex, "openlrPolygonLocationReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrLowerLeft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrLowerLeft">http://vocab.datex.org/terms#openlrLowerLeft</seealso>
    let openlrLowerLeft = Prefixed_Name(datex, "openlrLowerLeft") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrRectangleExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrRectangleExtension">http://vocab.datex.org/terms#openlrRectangleExtension</seealso>
    let openlrRectangleExtension =
        Prefixed_Name(datex, "openlrRectangleExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrUpperRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrUpperRight">http://vocab.datex.org/terms#openlrUpperRight</seealso>
    let openlrUpperRight = Prefixed_Name(datex, "openlrUpperRight") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrRectangleLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the openLR method of areadefinition by providing a rectangular shape defined by two geo-coordinate pairs</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrRectangleLocationReference">http://vocab.datex.org/terms#OpenlrRectangleLocationReference</seealso>
    let OpenlrRectangleLocationReference =
        Prefixed_Name(datex, "OpenlrRectangleLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:actionOrigin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the actions to be undertaken by the operator are the result of an internal operation or external influence.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#actionOrigin">http://vocab.datex.org/terms#actionOrigin</seealso>
    let actionOrigin = Prefixed_Name(datex, "actionOrigin") |> PrefixedName

    /// <summary>
    ///   <para>datex:actionPlanIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier of the traffic management action plan to which this action relates.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#actionPlanIdentifier">http://vocab.datex.org/terms#actionPlanIdentifier</seealso>
    let actionPlanIdentifier =
        Prefixed_Name(datex, "actionPlanIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:operatorActionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operatorActionExtension">http://vocab.datex.org/terms#operatorActionExtension</seealso>
    let operatorActionExtension =
        Prefixed_Name(datex, "operatorActionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:operatorActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the defined operator action.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operatorActionStatus">http://vocab.datex.org/terms#operatorActionStatus</seealso>
    let operatorActionStatus =
        Prefixed_Name(datex, "operatorActionStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:exceptionPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exceptionPeriod">http://vocab.datex.org/terms#exceptionPeriod</seealso>
    let exceptionPeriod = Prefixed_Name(datex, "exceptionPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A continuous time period or a set of discontinuous time periods defined by the intersection of a set of criteria all within an overall delimiting interval.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Period">http://vocab.datex.org/terms#Period</seealso>
    let Period = Prefixed_Name(datex, "Period") |> PrefixedName
    /// <summary>
    ///   <para>datex:overallEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overallEndTime">http://vocab.datex.org/terms#overallEndTime</seealso>
    let overallEndTime = Prefixed_Name(datex, "overallEndTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:overallPeriodExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overallPeriodExtension">http://vocab.datex.org/terms#overallPeriodExtension</seealso>
    let overallPeriodExtension =
        Prefixed_Name(datex, "overallPeriodExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:overallStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overallStartTime">http://vocab.datex.org/terms#overallStartTime</seealso>
    let overallStartTime = Prefixed_Name(datex, "overallStartTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:validPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validPeriod">http://vocab.datex.org/terms#validPeriod</seealso>
    let validPeriod = Prefixed_Name(datex, "validPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes one entrance or exit (or both) to a parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingAccess">http://vocab.datex.org/terms#ParkingAccess</seealso>
    let ParkingAccess = Prefixed_Name(datex, "ParkingAccess") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessAssignedAmongOthers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessAssignedAmongOthers">http://vocab.datex.org/terms#accessAssignedAmongOthers</seealso>
    let accessAssignedAmongOthers =
        Prefixed_Name(datex, "accessAssignedAmongOthers") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One set of prohibited/only allowed/convenient assignment for parking space(s), parking site(s) or an access. Same kind of data forms a union (e.g. lorries OR buses), different kind of data forms an intersection (e.g. residents AND long-term).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingAssignment">http://vocab.datex.org/terms#ParkingAssignment</seealso>
    let ParkingAssignment = Prefixed_Name(datex, "ParkingAssignment") |> PrefixedName
    /// <summary>
    ///   <para>datex:accessCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessCategory">http://vocab.datex.org/terms#accessCategory</seealso>
    let accessCategory = Prefixed_Name(datex, "accessCategory") |> PrefixedName
    /// <summary>
    ///   <para>datex:accessEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessEquipment">http://vocab.datex.org/terms#accessEquipment</seealso>
    let accessEquipment = Prefixed_Name(datex, "accessEquipment") |> PrefixedName
    /// <summary>
    ///   <para>datex:accessName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessName">http://vocab.datex.org/terms#accessName</seealso>
    let accessName = Prefixed_Name(datex, "accessName") |> PrefixedName
    /// <summary>
    ///   <para>datex:openingTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openingTimes">http://vocab.datex.org/terms#openingTimes</seealso>
    let openingTimes = Prefixed_Name(datex, "openingTimes") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingAccessExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAccessExtension">http://vocab.datex.org/terms#parkingAccessExtension</seealso>
    let parkingAccessExtension =
        Prefixed_Name(datex, "parkingAccessExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:photoUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#photoUrl">http://vocab.datex.org/terms#photoUrl</seealso>
    let photoUrl = Prefixed_Name(datex, "photoUrl") |> PrefixedName
    /// <summary>
    ///   <para>datex:primaryRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#primaryRoad">http://vocab.datex.org/terms#primaryRoad</seealso>
    let primaryRoad = Prefixed_Name(datex, "primaryRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingAccessStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The opening and fault status of one access.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingAccessStatus">http://vocab.datex.org/terms#ParkingAccessStatus</seealso>
    let ParkingAccessStatus =
        Prefixed_Name(datex, "ParkingAccessStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessFault">http://vocab.datex.org/terms#accessFault</seealso>
    let accessFault = Prefixed_Name(datex, "accessFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessOpeningStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessOpeningStatus">http://vocab.datex.org/terms#accessOpeningStatus</seealso>
    let accessOpeningStatus =
        Prefixed_Name(datex, "accessOpeningStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessReference">http://vocab.datex.org/terms#accessReference</seealso>
    let accessReference = Prefixed_Name(datex, "accessReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingAccessStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAccessStatusExtension">http://vocab.datex.org/terms#parkingAccessStatusExtension</seealso>
    let parkingAccessStatusExtension =
        Prefixed_Name(datex, "parkingAccessStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardousMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardousMaterials">http://vocab.datex.org/terms#hazardousMaterials</seealso>
    let hazardousMaterials = Prefixed_Name(datex, "hazardousMaterials") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingAssignmentExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAssignmentExtension">http://vocab.datex.org/terms#parkingAssignmentExtension</seealso>
    let parkingAssignmentExtension =
        Prefixed_Name(datex, "parkingAssignmentExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:additionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#additionalDescription">http://vocab.datex.org/terms#additionalDescription</seealso>
    let additionalDescription =
        Prefixed_Name(datex, "additionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#availability">http://vocab.datex.org/terms#availability</seealso>
    let availability = Prefixed_Name(datex, "availability") |> PrefixedName

    /// <summary>
    ///   <para>datex:availabilityAndOpeningTimes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#availabilityAndOpeningTimes">http://vocab.datex.org/terms#availabilityAndOpeningTimes</seealso>
    let availabilityAndOpeningTimes =
        Prefixed_Name(datex, "availabilityAndOpeningTimes") |> PrefixedName

    /// <summary>
    ///   <para>datex:equipmentOrServiceFacilityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#equipmentOrServiceFacilityIdentifier">http://vocab.datex.org/terms#equipmentOrServiceFacilityIdentifier</seealso>
    let equipmentOrServiceFacilityIdentifier =
        Prefixed_Name(datex, "equipmentOrServiceFacilityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:nameOrBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nameOrBrand">http://vocab.datex.org/terms#nameOrBrand</seealso>
    let nameOrBrand = Prefixed_Name(datex, "nameOrBrand") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacility">http://vocab.datex.org/terms#numberOfEquipmentOrServiceFacility</seealso>
    let numberOfEquipmentOrServiceFacility =
        Prefixed_Name(datex, "numberOfEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:otherEquipmentOrServiceFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherEquipmentOrServiceFacility">http://vocab.datex.org/terms#otherEquipmentOrServiceFacility</seealso>
    let otherEquipmentOrServiceFacility =
        Prefixed_Name(datex, "otherEquipmentOrServiceFacility") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingEquipmentOrServiceFacilityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityExtension">http://vocab.datex.org/terms#parkingEquipmentOrServiceFacilityExtension</seealso>
    let parkingEquipmentOrServiceFacilityExtension =
        Prefixed_Name(datex, "parkingEquipmentOrServiceFacilityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tariffsAndPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tariffsAndPayment">http://vocab.datex.org/terms#tariffsAndPayment</seealso>
    let tariffsAndPayment = Prefixed_Name(datex, "tariffsAndPayment") |> PrefixedName
    /// <summary>
    ///   <para>datex:TariffsAndPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A table of charges under various conditions, primary used for parking. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TariffsAndPayment">http://vocab.datex.org/terms#TariffsAndPayment</seealso>
    let TariffsAndPayment = Prefixed_Name(datex, "TariffsAndPayment") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingEquipmentOrServiceFacilityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The number of E&amp;S can be overridden here (for example during restoration). Furthermore, the current availability of E&amp;S can be given (for example number of free electric charging stations). The E&amp;S are identified from the static model by an index.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacilityStatus">http://vocab.datex.org/terms#ParkingEquipmentOrServiceFacilityStatus</seealso>
    let ParkingEquipmentOrServiceFacilityStatus =
        Prefixed_Name(datex, "ParkingEquipmentOrServiceFacilityStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:serviceFacilityOpeningStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#serviceFacilityOpeningStatus">http://vocab.datex.org/terms#serviceFacilityOpeningStatus</seealso>
    let serviceFacilityOpeningStatus =
        Prefixed_Name(datex, "serviceFacilityOpeningStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:vacantEquipmentOrServiceFacilitySubitems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vacantEquipmentOrServiceFacilitySubitems">http://vocab.datex.org/terms#vacantEquipmentOrServiceFacilitySubitems</seealso>
    let vacantEquipmentOrServiceFacilitySubitems =
        Prefixed_Name(datex, "vacantEquipmentOrServiceFacilitySubitems") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNotAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNotAllowed">http://vocab.datex.org/terms#parkingNotAllowed</seealso>
    let parkingNotAllowed = Prefixed_Name(datex, "parkingNotAllowed") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfOccupiedSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfOccupiedSpaces">http://vocab.datex.org/terms#parkingNumberOfOccupiedSpaces</seealso>
    let parkingNumberOfOccupiedSpaces =
        Prefixed_Name(datex, "parkingNumberOfOccupiedSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfSpacesOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfSpacesOverride">http://vocab.datex.org/terms#parkingNumberOfSpacesOverride</seealso>
    let parkingNumberOfSpacesOverride =
        Prefixed_Name(datex, "parkingNumberOfSpacesOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfVacantSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfVacantSpaces">http://vocab.datex.org/terms#parkingNumberOfVacantSpaces</seealso>
    let parkingNumberOfVacantSpaces =
        Prefixed_Name(datex, "parkingNumberOfVacantSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfVacantSpacesGraded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesGraded">http://vocab.datex.org/terms#parkingNumberOfVacantSpacesGraded</seealso>
    let parkingNumberOfVacantSpacesGraded =
        Prefixed_Name(datex, "parkingNumberOfVacantSpacesGraded") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfVacantSpacesHigherThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesHigherThan">http://vocab.datex.org/terms#parkingNumberOfVacantSpacesHigherThan</seealso>
    let parkingNumberOfVacantSpacesHigherThan =
        Prefixed_Name(datex, "parkingNumberOfVacantSpacesHigherThan") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfVacantSpacesLowerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfVacantSpacesLowerThan">http://vocab.datex.org/terms#parkingNumberOfVacantSpacesLowerThan</seealso>
    let parkingNumberOfVacantSpacesLowerThan =
        Prefixed_Name(datex, "parkingNumberOfVacantSpacesLowerThan") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingNumberOfVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingNumberOfVehicles">http://vocab.datex.org/terms#parkingNumberOfVehicles</seealso>
    let parkingNumberOfVehicles =
        Prefixed_Name(datex, "parkingNumberOfVehicles") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOccupancy">http://vocab.datex.org/terms#parkingOccupancy</seealso>
    let parkingOccupancy = Prefixed_Name(datex, "parkingOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOccupancyExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOccupancyExtension">http://vocab.datex.org/terms#parkingOccupancyExtension</seealso>
    let parkingOccupancyExtension =
        Prefixed_Name(datex, "parkingOccupancyExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOccupancyGraded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOccupancyGraded">http://vocab.datex.org/terms#parkingOccupancyGraded</seealso>
    let parkingOccupancyGraded =
        Prefixed_Name(datex, "parkingOccupancyGraded") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOccupancyTrend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOccupancyTrend">http://vocab.datex.org/terms#parkingOccupancyTrend</seealso>
    let parkingOccupancyTrend =
        Prefixed_Name(datex, "parkingOccupancyTrend") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCountAndRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCountAndRate">http://vocab.datex.org/terms#vehicleCountAndRate</seealso>
    let vehicleCountAndRate =
        Prefixed_Name(datex, "vehicleCountAndRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:VehicleCountAndRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vehicle rates can be assigned to a parking site or to assigned parking spaces. Furthermore, they can reference to a measurement site or to an entrance/exit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VehicleCountAndRate">http://vocab.datex.org/terms#VehicleCountAndRate</seealso>
    let VehicleCountAndRate =
        Prefixed_Name(datex, "VehicleCountAndRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingPermitExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPermitExtension">http://vocab.datex.org/terms#parkingPermitExtension</seealso>
    let parkingPermitExtension =
        Prefixed_Name(datex, "parkingPermitExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingPermitIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPermitIdentifier">http://vocab.datex.org/terms#parkingPermitIdentifier</seealso>
    let parkingPermitIdentifier =
        Prefixed_Name(datex, "parkingPermitIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingPermitScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPermitScheme">http://vocab.datex.org/terms#parkingPermitScheme</seealso>
    let parkingPermitScheme =
        Prefixed_Name(datex, "parkingPermitScheme") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingPermitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPermitType">http://vocab.datex.org/terms#parkingPermitType</seealso>
    let parkingPermitType = Prefixed_Name(datex, "parkingPermitType") |> PrefixedName

    /// <summary>
    ///   <para>datex:assignedParkingAmongOthers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#assignedParkingAmongOthers">http://vocab.datex.org/terms#assignedParkingAmongOthers</seealso>
    let assignedParkingAmongOthers =
        Prefixed_Name(datex, "assignedParkingAmongOthers") |> PrefixedName

    /// <summary>
    ///   <para>datex:emergencyAssemblyPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#emergencyAssemblyPoint">http://vocab.datex.org/terms#emergencyAssemblyPoint</seealso>
    let emergencyAssemblyPoint =
        Prefixed_Name(datex, "emergencyAssemblyPoint") |> PrefixedName

    /// <summary>
    ///   <para>datex:emergencyContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#emergencyContact">http://vocab.datex.org/terms#emergencyContact</seealso>
    let emergencyContact = Prefixed_Name(datex, "emergencyContact") |> PrefixedName
    /// <summary>
    ///   <para>datex:entireArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#entireArea">http://vocab.datex.org/terms#entireArea</seealso>
    let entireArea = Prefixed_Name(datex, "entireArea") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpaces">http://vocab.datex.org/terms#groupOfParkingSpaces</seealso>
    let groupOfParkingSpaces =
        Prefixed_Name(datex, "groupOfParkingSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:_GroupOfParkingSpaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_GroupOfParkingSpaces">http://vocab.datex.org/terms#_GroupOfParkingSpaces</seealso>
    let _GroupOfParkingSpaces =
        Prefixed_Name(datex, "_GroupOfParkingSpaces") |> PrefixedName

    /// <summary>
    ///   <para>datex:maximumParkingDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maximumParkingDuration">http://vocab.datex.org/terms#maximumParkingDuration</seealso>
    let maximumParkingDuration =
        Prefixed_Name(datex, "maximumParkingDuration") |> PrefixedName

    /// <summary>
    ///   <para>datex:onlyAssignedParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#onlyAssignedParking">http://vocab.datex.org/terms#onlyAssignedParking</seealso>
    let onlyAssignedParking =
        Prefixed_Name(datex, "onlyAssignedParking") |> PrefixedName

    /// <summary>
    ///   <para>datex:operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operator">http://vocab.datex.org/terms#operator</seealso>
    let operator = Prefixed_Name(datex, "operator") |> PrefixedName
    /// <summary>
    ///   <para>datex:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#owner">http://vocab.datex.org/terms#owner</seealso>
    let owner = Prefixed_Name(datex, "owner") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingAlias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAlias">http://vocab.datex.org/terms#parkingAlias</seealso>
    let parkingAlias = Prefixed_Name(datex, "parkingAlias") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordDimension">http://vocab.datex.org/terms#parkingRecordDimension</seealso>
    let parkingRecordDimension =
        Prefixed_Name(datex, "parkingRecordDimension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordExtension">http://vocab.datex.org/terms#parkingRecordExtension</seealso>
    let parkingRecordExtension =
        Prefixed_Name(datex, "parkingRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecordVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecordVersionTime">http://vocab.datex.org/terms#parkingRecordVersionTime</seealso>
    let parkingRecordVersionTime =
        Prefixed_Name(datex, "parkingRecordVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRoute">http://vocab.datex.org/terms#parkingRoute</seealso>
    let parkingRoute = Prefixed_Name(datex, "parkingRoute") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parking route, defined by ParkingRouteDetails or by a reference.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingRoute">http://vocab.datex.org/terms#ParkingRoute</seealso>
    let ParkingRoute = Prefixed_Name(datex, "ParkingRoute") |> PrefixedName
    /// <summary>
    ///   <para>datex:_ParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ParkingSpace">http://vocab.datex.org/terms#_ParkingSpace</seealso>
    let _ParkingSpace = Prefixed_Name(datex, "_ParkingSpace") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingThresholds">http://vocab.datex.org/terms#parkingThresholds</seealso>
    let parkingThresholds = Prefixed_Name(datex, "parkingThresholds") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingThresholds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Configuration parameters of the parking site, used among others for the dynamic attribute 'parkingStatus'. This component or all elements of it can be overridden in the dynamic model.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingThresholds">http://vocab.datex.org/terms#ParkingThresholds</seealso>
    let ParkingThresholds = Prefixed_Name(datex, "ParkingThresholds") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingVMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingVMS">http://vocab.datex.org/terms#parkingVMS</seealso>
    let parkingVMS = Prefixed_Name(datex, "parkingVMS") |> PrefixedName
    /// <summary>
    ///   <para>datex:ParkingVMS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference to a record that contains the metadata for a specific VMS unit that may be used to manage the parking site (e.g. to indicate to drivers the current availability of spaces).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingVMS">http://vocab.datex.org/terms#ParkingVMS</seealso>
    let ParkingVMS = Prefixed_Name(datex, "ParkingVMS") |> PrefixedName

    /// <summary>
    ///   <para>datex:permitsAndProhibitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#permitsAndProhibitions">http://vocab.datex.org/terms#permitsAndProhibitions</seealso>
    let permitsAndProhibitions =
        Prefixed_Name(datex, "permitsAndProhibitions") |> PrefixedName

    /// <summary>
    ///   <para>datex:PermitsAndProhibitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines sets of action and regulations to specify permitted and prohibited issues.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PermitsAndProhibitions">http://vocab.datex.org/terms#PermitsAndProhibitions</seealso>
    let PermitsAndProhibitions =
        Prefixed_Name(datex, "PermitsAndProhibitions") |> PrefixedName

    /// <summary>
    ///   <para>datex:prohibitedParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#prohibitedParking">http://vocab.datex.org/terms#prohibitedParking</seealso>
    let prohibitedParking = Prefixed_Name(datex, "prohibitedParking") |> PrefixedName

    /// <summary>
    ///   <para>datex:responisbleAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#responisbleAuthority">http://vocab.datex.org/terms#responisbleAuthority</seealso>
    let responisbleAuthority =
        Prefixed_Name(datex, "responisbleAuthority") |> PrefixedName

    /// <summary>
    ///   <para>datex:securityService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#securityService">http://vocab.datex.org/terms#securityService</seealso>
    let securityService = Prefixed_Name(datex, "securityService") |> PrefixedName
    /// <summary>
    ///   <para>datex:servicePartner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#servicePartner">http://vocab.datex.org/terms#servicePartner</seealso>
    let servicePartner = Prefixed_Name(datex, "servicePartner") |> PrefixedName
    /// <summary>
    ///   <para>datex:overcrowding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overcrowding">http://vocab.datex.org/terms#overcrowding</seealso>
    let overcrowding = Prefixed_Name(datex, "overcrowding") |> PrefixedName
    /// <summary>
    ///   <para>datex:overcrowdingLevel1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overcrowdingLevel1">http://vocab.datex.org/terms#overcrowdingLevel1</seealso>
    let overcrowdingLevel1 = Prefixed_Name(datex, "overcrowdingLevel1") |> PrefixedName
    /// <summary>
    ///   <para>datex:overcrowdingLevel2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#overcrowdingLevel2">http://vocab.datex.org/terms#overcrowdingLevel2</seealso>
    let overcrowdingLevel2 = Prefixed_Name(datex, "overcrowdingLevel2") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingLastMaximumOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingLastMaximumOccupancy">http://vocab.datex.org/terms#parkingLastMaximumOccupancy</seealso>
    let parkingLastMaximumOccupancy =
        Prefixed_Name(datex, "parkingLastMaximumOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStatusColourMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStatusColourMapping">http://vocab.datex.org/terms#parkingStatusColourMapping</seealso>
    let parkingStatusColourMapping =
        Prefixed_Name(datex, "parkingStatusColourMapping") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingThresholdsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingThresholdsExtension">http://vocab.datex.org/terms#parkingThresholdsExtension</seealso>
    let parkingThresholdsExtension =
        Prefixed_Name(datex, "parkingThresholdsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingUsageScenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A special type of usage available for the parking site or the group of parking spaces. In the 'ParkingStatusPublication', the operation type (in operation or not) can be defined.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingUsageScenario">http://vocab.datex.org/terms#ParkingUsageScenario</seealso>
    let ParkingUsageScenario =
        Prefixed_Name(datex, "ParkingUsageScenario") |> PrefixedName

    /// <summary>
    ///   <para>datex:eventParkingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#eventParkingType">http://vocab.datex.org/terms#eventParkingType</seealso>
    let eventParkingType = Prefixed_Name(datex, "eventParkingType") |> PrefixedName
    /// <summary>
    ///   <para>datex:eventParkingType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#eventParkingType2">http://vocab.datex.org/terms#eventParkingType2</seealso>
    let eventParkingType2 = Prefixed_Name(datex, "eventParkingType2") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingUsageScenarioExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingUsageScenarioExtension">http://vocab.datex.org/terms#parkingUsageScenarioExtension</seealso>
    let parkingUsageScenarioExtension =
        Prefixed_Name(datex, "parkingUsageScenarioExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:scenarioAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#scenarioAvailability">http://vocab.datex.org/terms#scenarioAvailability</seealso>
    let scenarioAvailability =
        Prefixed_Name(datex, "scenarioAvailability") |> PrefixedName

    /// <summary>
    ///   <para>datex:truckParkingDynamicManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#truckParkingDynamicManagement">http://vocab.datex.org/terms#truckParkingDynamicManagement</seealso>
    let truckParkingDynamicManagement =
        Prefixed_Name(datex, "truckParkingDynamicManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingVMSExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingVMSExtension">http://vocab.datex.org/terms#parkingVMSExtension</seealso>
    let parkingVMSExtension =
        Prefixed_Name(datex, "parkingVMSExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsOperator">http://vocab.datex.org/terms#vmsOperator</seealso>
    let vmsOperator = Prefixed_Name(datex, "vmsOperator") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitUsedToManageParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitUsedToManageParking">http://vocab.datex.org/terms#vmsUnitUsedToManageParking</seealso>
    let vmsUnitUsedToManageParking =
        Prefixed_Name(datex, "vmsUnitUsedToManageParking") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsUnitRecordVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsUnitRecordVersionedReference">http://vocab.datex.org/terms#_VmsUnitRecordVersionedReference</seealso>
    let _VmsUnitRecordVersionedReference =
        Prefixed_Name(datex, "_VmsUnitRecordVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about one individual parking vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingVehicle">http://vocab.datex.org/terms#ParkingVehicle</seealso>
    let ParkingVehicle = Prefixed_Name(datex, "ParkingVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:groupOfParkingSpacesReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#groupOfParkingSpacesReference">http://vocab.datex.org/terms#groupOfParkingSpacesReference</seealso>
    let groupOfParkingSpacesReference =
        Prefixed_Name(datex, "groupOfParkingSpacesReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:individualCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#individualCharge">http://vocab.datex.org/terms#individualCharge</seealso>
    let individualCharge = Prefixed_Name(datex, "individualCharge") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingPeriod">http://vocab.datex.org/terms#parkingPeriod</seealso>
    let parkingPeriod = Prefixed_Name(datex, "parkingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceReference">http://vocab.datex.org/terms#parkingSpaceReference</seealso>
    let parkingSpaceReference =
        Prefixed_Name(datex, "parkingSpaceReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingVehicleExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingVehicleExtension">http://vocab.datex.org/terms#parkingVehicleExtension</seealso>
    let parkingVehicleExtension =
        Prefixed_Name(datex, "parkingVehicleExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicle">http://vocab.datex.org/terms#vehicle</seealso>
    let vehicle = Prefixed_Name(datex, "vehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:ParkingVehiclesPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about individual parking vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ParkingVehiclesPublication">http://vocab.datex.org/terms#ParkingVehiclesPublication</seealso>
    let ParkingVehiclesPublication =
        Prefixed_Name(datex, "ParkingVehiclesPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:publicationCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicationCreator">http://vocab.datex.org/terms#publicationCreator</seealso>
    let publicationCreator = Prefixed_Name(datex, "publicationCreator") |> PrefixedName
    /// <summary>
    ///   <para>datex:publicationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicationTime">http://vocab.datex.org/terms#publicationTime</seealso>
    let publicationTime = Prefixed_Name(datex, "publicationTime") |> PrefixedName
    /// <summary>
    ///   <para>datex:PcuFlowValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the flow rate of passenger car units.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PcuFlowValue">http://vocab.datex.org/terms#PcuFlowValue</seealso>
    let PcuFlowValue = Prefixed_Name(datex, "PcuFlowValue") |> PrefixedName
    /// <summary>
    ///   <para>datex:pcuFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of passenger car unit flow rate expressed in passenger car units per hour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pcuFlowRate">http://vocab.datex.org/terms#pcuFlowRate</seealso>
    let pcuFlowRate = Prefixed_Name(datex, "pcuFlowRate") |> PrefixedName

    /// <summary>
    ///   <para>datex:pcuFlowValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pcuFlowValueExtension">http://vocab.datex.org/terms#pcuFlowValueExtension</seealso>
    let pcuFlowValueExtension =
        Prefixed_Name(datex, "pcuFlowValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PercentageDistanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PercentageDistanceAlongLinearElement">http://vocab.datex.org/terms#PercentageDistanceAlongLinearElement</seealso>
    let PercentageDistanceAlongLinearElement =
        Prefixed_Name(datex, "PercentageDistanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>datex:percentageDistanceAlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#percentageDistanceAlong">http://vocab.datex.org/terms#percentageDistanceAlong</seealso>
    let percentageDistanceAlong =
        Prefixed_Name(datex, "percentageDistanceAlong") |> PrefixedName

    /// <summary>
    ///   <para>datex:percentageDistanceAlongLinearElementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#percentageDistanceAlongLinearElementExtension">http://vocab.datex.org/terms#percentageDistanceAlongLinearElementExtension</seealso>
    let percentageDistanceAlongLinearElementExtension =
        Prefixed_Name(datex, "percentageDistanceAlongLinearElementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:percentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value expressed as a percentage.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#percentage">http://vocab.datex.org/terms#percentage</seealso>
    let percentage = Prefixed_Name(datex, "percentage") |> PrefixedName

    /// <summary>
    ///   <para>datex:percentageValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#percentageValueExtension">http://vocab.datex.org/terms#percentageValueExtension</seealso>
    let percentageValueExtension =
        Prefixed_Name(datex, "percentageValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:recurringTimePeriodOfDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#recurringTimePeriodOfDay">http://vocab.datex.org/terms#recurringTimePeriodOfDay</seealso>
    let recurringTimePeriodOfDay =
        Prefixed_Name(datex, "recurringTimePeriodOfDay") |> PrefixedName

    /// <summary>
    ///   <para>datex:startOfPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#startOfPeriod">http://vocab.datex.org/terms#startOfPeriod</seealso>
    let startOfPeriod = Prefixed_Name(datex, "startOfPeriod") |> PrefixedName
    /// <summary>
    ///   <para>datex:PeriodExtended</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An extension point for Period offering the possibility to describe special days and public holidays.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PeriodExtended">http://vocab.datex.org/terms#PeriodExtended</seealso>
    let PeriodExtended = Prefixed_Name(datex, "PeriodExtended") |> PrefixedName

    /// <summary>
    ///   <para>datex:recurringSpecialDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#recurringSpecialDay">http://vocab.datex.org/terms#recurringSpecialDay</seealso>
    let recurringSpecialDay =
        Prefixed_Name(datex, "recurringSpecialDay") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpecialDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of a special day, for example schoolDay, electionDay, ...  Gives also the possibility to define a public holiday (country specific).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpecialDay">http://vocab.datex.org/terms#SpecialDay</seealso>
    let SpecialDay = Prefixed_Name(datex, "SpecialDay") |> PrefixedName
    /// <summary>
    ///   <para>datex:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#activity">http://vocab.datex.org/terms#activity</seealso>
    let activity = Prefixed_Name(datex, "activity") |> PrefixedName

    /// <summary>
    ///   <para>datex:permitsAndProhibitionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#permitsAndProhibitionsExtension">http://vocab.datex.org/terms#permitsAndProhibitionsExtension</seealso>
    let permitsAndProhibitionsExtension =
        Prefixed_Name(datex, "permitsAndProhibitionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#regulation">http://vocab.datex.org/terms#regulation</seealso>
    let regulation = Prefixed_Name(datex, "regulation") |> PrefixedName

    /// <summary>
    ///   <para>datex:PictogramDisplayAreaSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Settings specific to a distinct pictogram display area on the VMS (where pictogramIndex indicates which pictogram area it relates to if there is more than one pictogram display area on the VMS).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PictogramDisplayAreaSettings">http://vocab.datex.org/terms#PictogramDisplayAreaSettings</seealso>
    let PictogramDisplayAreaSettings =
        Prefixed_Name(datex, "PictogramDisplayAreaSettings") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramDisplayAreaSettingsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramDisplayAreaSettingsExtension">http://vocab.datex.org/terms#pictogramDisplayAreaSettingsExtension</seealso>
    let pictogramDisplayAreaSettingsExtension =
        Prefixed_Name(datex, "pictogramDisplayAreaSettingsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramLanternsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramLanternsOn">http://vocab.datex.org/terms#pictogramLanternsOn</seealso>
    let pictogramLanternsOn =
        Prefixed_Name(datex, "pictogramLanternsOn") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramLuminanceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramLuminanceLevel">http://vocab.datex.org/terms#pictogramLuminanceLevel</seealso>
    let pictogramLuminanceLevel =
        Prefixed_Name(datex, "pictogramLuminanceLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramLuminanceLevelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramLuminanceLevelName">http://vocab.datex.org/terms#pictogramLuminanceLevelName</seealso>
    let pictogramLuminanceLevelName =
        Prefixed_Name(datex, "pictogramLuminanceLevelName") |> PrefixedName

    /// <summary>
    ///   <para>datex:pictogramLuminanceOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#pictogramLuminanceOverride">http://vocab.datex.org/terms#pictogramLuminanceOverride</seealso>
    let pictogramLuminanceOverride =
        Prefixed_Name(datex, "pictogramLuminanceOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadDestination">http://vocab.datex.org/terms#roadDestination</seealso>
    let roadDestination = Prefixed_Name(datex, "roadDestination") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadExtension">http://vocab.datex.org/terms#roadExtension</seealso>
    let roadExtension = Prefixed_Name(datex, "roadExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadIdentifier">http://vocab.datex.org/terms#roadIdentifier</seealso>
    let roadIdentifier = Prefixed_Name(datex, "roadIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadOrigination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOrigination">http://vocab.datex.org/terms#roadOrigination</seealso>
    let roadOrigination = Prefixed_Name(datex, "roadOrigination") |> PrefixedName
    /// <summary>
    ///   <para>datex:typeOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#typeOfRoad">http://vocab.datex.org/terms#typeOfRoad</seealso>
    let typeOfRoad = Prefixed_Name(datex, "typeOfRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadConditionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadConditionsExtension">http://vocab.datex.org/terms#roadConditionsExtension</seealso>
    let roadConditionsExtension =
        Prefixed_Name(datex, "roadConditionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A road node as part of the specialised road identified by the name of a junctionon on this road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadNode">http://vocab.datex.org/terms#RoadNode</seealso>
    let RoadNode = Prefixed_Name(datex, "RoadNode") |> PrefixedName
    /// <summary>
    ///   <para>datex:roadNodeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadNodeExtension">http://vocab.datex.org/terms#roadNodeExtension</seealso>
    let roadNodeExtension = Prefixed_Name(datex, "roadNodeExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadOperatorServiceDisruption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of disruption to normal road operator services</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadOperatorServiceDisruption">http://vocab.datex.org/terms#RoadOperatorServiceDisruption</seealso>
    let RoadOperatorServiceDisruption =
        Prefixed_Name(datex, "RoadOperatorServiceDisruption") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOperatorServiceDisruptionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionExtension">http://vocab.datex.org/terms#roadOperatorServiceDisruptionExtension</seealso>
    let roadOperatorServiceDisruptionExtension =
        Prefixed_Name(datex, "roadOperatorServiceDisruptionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadOperatorServiceDisruptionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of road operator service which is disrupted.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadOperatorServiceDisruptionType">http://vocab.datex.org/terms#roadOperatorServiceDisruptionType</seealso>
    let roadOperatorServiceDisruptionType =
        Prefixed_Name(datex, "roadOperatorServiceDisruptionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:minimumCarOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minimumCarOccupancy">http://vocab.datex.org/terms#minimumCarOccupancy</seealso>
    let minimumCarOccupancy =
        Prefixed_Name(datex, "minimumCarOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>datex:timePeriodOfDayExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#timePeriodOfDayExtension">http://vocab.datex.org/terms#timePeriodOfDayExtension</seealso>
    let timePeriodOfDayExtension =
        Prefixed_Name(datex, "timePeriodOfDayExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegAreaDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing an area location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegAreaDescriptor">http://vocab.datex.org/terms#TpegAreaDescriptor</seealso>
    let TpegAreaDescriptor = Prefixed_Name(datex, "TpegAreaDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegAreaDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegAreaDescriptorExtension">http://vocab.datex.org/terms#tpegAreaDescriptorExtension</seealso>
    let tpegAreaDescriptorExtension =
        Prefixed_Name(datex, "tpegAreaDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegAreaDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegAreaDescriptorType">http://vocab.datex.org/terms#tpegAreaDescriptorType</seealso>
    let tpegAreaDescriptorType =
        Prefixed_Name(datex, "tpegAreaDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegDescriptor">http://vocab.datex.org/terms#TpegDescriptor</seealso>
    let TpegDescriptor = Prefixed_Name(datex, "TpegDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegAreaLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegAreaLocationExtension">http://vocab.datex.org/terms#tpegAreaLocationExtension</seealso>
    let tpegAreaLocationExtension =
        Prefixed_Name(datex, "tpegAreaLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegAreaLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegAreaLocationType">http://vocab.datex.org/terms#tpegAreaLocationType</seealso>
    let tpegAreaLocationType =
        Prefixed_Name(datex, "tpegAreaLocationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegHeight">http://vocab.datex.org/terms#tpegHeight</seealso>
    let tpegHeight = Prefixed_Name(datex, "tpegHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:TpegHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Height information which provides additional discrimination for the applicable area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegHeight">http://vocab.datex.org/terms#TpegHeight</seealso>
    let TpegHeight = Prefixed_Name(datex, "TpegHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#descriptor">http://vocab.datex.org/terms#descriptor</seealso>
    let descriptor = Prefixed_Name(datex, "descriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegDescriptorExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegDescriptorExtension">http://vocab.datex.org/terms#tpegDescriptorExtension</seealso>
    let tpegDescriptorExtension =
        Prefixed_Name(datex, "tpegDescriptorExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegGeometricArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geometric area defined by a centre point and a radius.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegGeometricArea">http://vocab.datex.org/terms#TpegGeometricArea</seealso>
    let TpegGeometricArea = Prefixed_Name(datex, "TpegGeometricArea") |> PrefixedName
    /// <summary>
    ///   <para>datex:centrePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Centre point of a circular geometric area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#centrePoint">http://vocab.datex.org/terms#centrePoint</seealso>
    let centrePoint = Prefixed_Name(datex, "centrePoint") |> PrefixedName
    /// <summary>
    ///   <para>datex:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptive name which helps to identify the non junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.</para>
    ///   <para>A name which identifies a junction point on the road network</para>
    ///   <para>Name of area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#name">http://vocab.datex.org/terms#name</seealso>
    let name = Prefixed_Name(datex, "name") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegGeometricAreaExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegGeometricAreaExtension">http://vocab.datex.org/terms#tpegGeometricAreaExtension</seealso>
    let tpegGeometricAreaExtension =
        Prefixed_Name(datex, "tpegGeometricAreaExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#height">http://vocab.datex.org/terms#height</seealso>
    let height = Prefixed_Name(datex, "height") |> PrefixedName
    /// <summary>
    ///   <para>datex:heightType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightType">http://vocab.datex.org/terms#heightType</seealso>
    let heightType = Prefixed_Name(datex, "heightType") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegHeightExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegHeightExtension">http://vocab.datex.org/terms#tpegHeightExtension</seealso>
    let tpegHeightExtension =
        Prefixed_Name(datex, "tpegHeightExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:TpegIlcPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a junction by defining the intersecting roads.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TpegIlcPointDescriptor">http://vocab.datex.org/terms#TpegIlcPointDescriptor</seealso>
    let TpegIlcPointDescriptor =
        Prefixed_Name(datex, "TpegIlcPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfVms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfVms">http://vocab.datex.org/terms#numberOfVms</seealso>
    let numberOfVms = Prefixed_Name(datex, "numberOfVms") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsRecord">http://vocab.datex.org/terms#vmsRecord</seealso>
    let vmsRecord = Prefixed_Name(datex, "vmsRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VmsUnitRecordVmsIndexVmsRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VmsUnitRecordVmsIndexVmsRecord">http://vocab.datex.org/terms#_VmsUnitRecordVmsIndexVmsRecord</seealso>
    let _VmsUnitRecordVmsIndexVmsRecord =
        Prefixed_Name(datex, "_VmsUnitRecordVmsIndexVmsRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitElectronicAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitElectronicAddress">http://vocab.datex.org/terms#vmsUnitElectronicAddress</seealso>
    let vmsUnitElectronicAddress =
        Prefixed_Name(datex, "vmsUnitElectronicAddress") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitIPAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitIPAddress">http://vocab.datex.org/terms#vmsUnitIPAddress</seealso>
    let vmsUnitIPAddress = Prefixed_Name(datex, "vmsUnitIPAddress") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsUnitIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitIdentifier">http://vocab.datex.org/terms#vmsUnitIdentifier</seealso>
    let vmsUnitIdentifier = Prefixed_Name(datex, "vmsUnitIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitRecordExtension">http://vocab.datex.org/terms#vmsUnitRecordExtension</seealso>
    let vmsUnitRecordExtension =
        Prefixed_Name(datex, "vmsUnitRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitRecord">http://vocab.datex.org/terms#vmsUnitRecord</seealso>
    let vmsUnitRecord = Prefixed_Name(datex, "vmsUnitRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitTableExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitTableExtension">http://vocab.datex.org/terms#vmsUnitTableExtension</seealso>
    let vmsUnitTableExtension =
        Prefixed_Name(datex, "vmsUnitTableExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitTableIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitTableIdentification">http://vocab.datex.org/terms#vmsUnitTableIdentification</seealso>
    let vmsUnitTableIdentification =
        Prefixed_Name(datex, "vmsUnitTableIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:weatherDataExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weatherDataExtension">http://vocab.datex.org/terms#weatherDataExtension</seealso>
    let weatherDataExtension =
        Prefixed_Name(datex, "weatherDataExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:WeatherRelatedRoadConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WeatherRelatedRoadConditions">http://vocab.datex.org/terms#WeatherRelatedRoadConditions</seealso>
    let WeatherRelatedRoadConditions =
        Prefixed_Name(datex, "WeatherRelatedRoadConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:DataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable. </para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DataValue">http://vocab.datex.org/terms#DataValue</seealso>
    let DataValue = Prefixed_Name(datex, "DataValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:dedicatedAccessExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dedicatedAccessExtension">http://vocab.datex.org/terms#dedicatedAccessExtension</seealso>
    let dedicatedAccessExtension =
        Prefixed_Name(datex, "dedicatedAccessExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:exitTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time when an individual vehicle leaves a detection zone.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exitTime">http://vocab.datex.org/terms#exitTime</seealso>
    let exitTime = Prefixed_Name(datex, "exitTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:roadMaintenanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of road maintenance or installation work at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#roadMaintenanceType">http://vocab.datex.org/terms#roadMaintenanceType</seealso>
    let roadMaintenanceType =
        Prefixed_Name(datex, "roadMaintenanceType") |> PrefixedName

    /// <summary>
    ///   <para>datex:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The radius of the geometric area identified.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#radius">http://vocab.datex.org/terms#radius</seealso>
    let radius = Prefixed_Name(datex, "radius") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingRouteColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRouteColour">http://vocab.datex.org/terms#parkingRouteColour</seealso>
    let parkingRouteColour = Prefixed_Name(datex, "parkingRouteColour") |> PrefixedName
    /// <summary>
    ///   <para>datex:referentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#referentName">http://vocab.datex.org/terms#referentName</seealso>
    let referentName = Prefixed_Name(datex, "referentName") |> PrefixedName

    /// <summary>
    ///   <para>datex:ReroutingManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rerouting management action that is issued by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ReroutingManagement">http://vocab.datex.org/terms#ReroutingManagement</seealso>
    let ReroutingManagement =
        Prefixed_Name(datex, "ReroutingManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:alternativeRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The definition of the alternative route (rerouting) specified as an ordered set of locations (itinerary) which may be specific to one or more defined destinations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alternativeRoute">http://vocab.datex.org/terms#alternativeRoute</seealso>
    let alternativeRoute = Prefixed_Name(datex, "alternativeRoute") |> PrefixedName
    /// <summary>
    ///   <para>datex:exit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The specified exit from the normal route/road at which the alternative route commences.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#exit">http://vocab.datex.org/terms#exit</seealso>
    let exit = Prefixed_Name(datex, "exit") |> PrefixedName

    /// <summary>
    ///   <para>datex:reroutingItineraryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A description of the rerouting itinerary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reroutingItineraryDescription">http://vocab.datex.org/terms#reroutingItineraryDescription</seealso>
    let reroutingItineraryDescription =
        Prefixed_Name(datex, "reroutingItineraryDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:widthCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#widthCharacteristic">http://vocab.datex.org/terms#widthCharacteristic</seealso>
    let widthCharacteristic =
        Prefixed_Name(datex, "widthCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:WidthCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Width characteristic of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#WidthCharacteristic">http://vocab.datex.org/terms#WidthCharacteristic</seealso>
    let WidthCharacteristic =
        Prefixed_Name(datex, "WidthCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsTablePublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTablePublicationExtension">http://vocab.datex.org/terms#vmsTablePublicationExtension</seealso>
    let vmsTablePublicationExtension =
        Prefixed_Name(datex, "vmsTablePublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A page of text (comprising one or more ordered lines) that are displayed simultaneously on the VMS. Where more than one page is defined these are sequentially displayed according to their "pageNumber".</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsText">http://vocab.datex.org/terms#VmsText</seealso>
    let VmsText = Prefixed_Name(datex, "VmsText") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsLegendCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsLegendCode">http://vocab.datex.org/terms#vmsLegendCode</seealso>
    let vmsLegendCode = Prefixed_Name(datex, "vmsLegendCode") |> PrefixedName
    /// <summary>
    ///   <para>datex:vmsTextExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsTextExtension">http://vocab.datex.org/terms#vmsTextExtension</seealso>
    let vmsTextExtension = Prefixed_Name(datex, "vmsTextExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#value">http://vocab.datex.org/terms#value</seealso>
    let value = Prefixed_Name(datex, "value") |> PrefixedName
    /// <summary>
    ///   <para>datex:DenseFog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#DenseFog">http://vocab.datex.org/terms#DenseFog</seealso>
    let DenseFog = Prefixed_Name(datex, "DenseFog") |> PrefixedName
    /// <summary>
    ///   <para>datex:Dry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Dry">http://vocab.datex.org/terms#Dry</seealso>
    let Dry = Prefixed_Name(datex, "Dry") |> PrefixedName

    /// <summary>
    ///   <para>datex:EmergencyRoadsideTelephoneFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFault">http://vocab.datex.org/terms#EmergencyRoadsideTelephoneFault</seealso>
    let EmergencyRoadsideTelephoneFault =
        Prefixed_Name(datex, "EmergencyRoadsideTelephoneFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:EnvironmentalConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EnvironmentalConditions">http://vocab.datex.org/terms#EnvironmentalConditions</seealso>
    let EnvironmentalConditions =
        Prefixed_Name(datex, "EnvironmentalConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:affectedCarriagewayAndLanesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#affectedCarriagewayAndLanesExtension">http://vocab.datex.org/terms#affectedCarriagewayAndLanesExtension</seealso>
    let affectedCarriagewayAndLanesExtension =
        Prefixed_Name(datex, "affectedCarriagewayAndLanesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:footpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#footpath">http://vocab.datex.org/terms#footpath</seealso>
    let footpath = Prefixed_Name(datex, "footpath") |> PrefixedName
    /// <summary>
    ///   <para>datex:lengthAffected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lengthAffected">http://vocab.datex.org/terms#lengthAffected</seealso>
    let lengthAffected = Prefixed_Name(datex, "lengthAffected") |> PrefixedName
    /// <summary>
    ///   <para>datex:nationalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nationalIdentifier">http://vocab.datex.org/terms#nationalIdentifier</seealso>
    let nationalIdentifier = Prefixed_Name(datex, "nationalIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>datex:Itinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Itinerary">http://vocab.datex.org/terms#Itinerary</seealso>
    let Itinerary = Prefixed_Name(datex, "Itinerary") |> PrefixedName
    /// <summary>
    ///   <para>datex:itineraryExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#itineraryExtension">http://vocab.datex.org/terms#itineraryExtension</seealso>
    let itineraryExtension = Prefixed_Name(datex, "itineraryExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationContainedInItinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationContainedInItinerary">http://vocab.datex.org/terms#locationContainedInItinerary</seealso>
    let locationContainedInItinerary =
        Prefixed_Name(datex, "locationContainedInItinerary") |> PrefixedName

    /// <summary>
    ///   <para>datex:_LocationContainedInItinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_LocationContainedInItinerary">http://vocab.datex.org/terms#_LocationContainedInItinerary</seealso>
    let _LocationContainedInItinerary =
        Prefixed_Name(datex, "_LocationContainedInItinerary") |> PrefixedName

    /// <summary>
    ///   <para>datex:itineraryByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#itineraryByReferenceExtension">http://vocab.datex.org/terms#itineraryByReferenceExtension</seealso>
    let itineraryByReferenceExtension =
        Prefixed_Name(datex, "itineraryByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:destinationMotorway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#destinationMotorway">http://vocab.datex.org/terms#destinationMotorway</seealso>
    let destinationMotorway =
        Prefixed_Name(datex, "destinationMotorway") |> PrefixedName

    /// <summary>
    ///   <para>datex:Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identification of a road by its name, identifier, type ...</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Road">http://vocab.datex.org/terms#Road</seealso>
    let Road = Prefixed_Name(datex, "Road") |> PrefixedName

    /// <summary>
    ///   <para>datex:measurementSiteRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#measurementSiteRecord">http://vocab.datex.org/terms#measurementSiteRecord</seealso>
    let measurementSiteRecord =
        Prefixed_Name(datex, "measurementSiteRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrNumColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrNumColumns">http://vocab.datex.org/terms#openlrNumColumns</seealso>
    let openlrNumColumns = Prefixed_Name(datex, "openlrNumColumns") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSiteOpeningStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The opening status of the parking site (open or not).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSiteOpeningStatus">http://vocab.datex.org/terms#parkingSiteOpeningStatus</seealso>
    let parkingSiteOpeningStatus =
        Prefixed_Name(datex, "parkingSiteOpeningStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:bearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#bearing">http://vocab.datex.org/terms#bearing</seealso>
    let bearing = Prefixed_Name(datex, "bearing") |> PrefixedName

    /// <summary>
    ///   <para>datex:weatherRelatedRoadConditionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of road surface condition that is related to the weather which is affecting the driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#weatherRelatedRoadConditionType">http://vocab.datex.org/terms#weatherRelatedRoadConditionType</seealso>
    let weatherRelatedRoadConditionType =
        Prefixed_Name(datex, "weatherRelatedRoadConditionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegFramedPointExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegFramedPointExtension">http://vocab.datex.org/terms#tpegFramedPointExtension</seealso>
    let tpegFramedPointExtension =
        Prefixed_Name(datex, "tpegFramedPointExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:tpegFramedPointLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#tpegFramedPointLocationType">http://vocab.datex.org/terms#tpegFramedPointLocationType</seealso>
    let tpegFramedPointLocationType =
        Prefixed_Name(datex, "tpegFramedPointLocationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:EmergencyServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EmergencyServices">http://vocab.datex.org/terms#EmergencyServices</seealso>
    let EmergencyServices = Prefixed_Name(datex, "EmergencyServices") |> PrefixedName
    /// <summary>
    ///   <para>datex:axleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleWeight">http://vocab.datex.org/terms#axleWeight</seealso>
    let axleWeight = Prefixed_Name(datex, "axleWeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:dimensionHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionHeight">http://vocab.datex.org/terms#dimensionHeight</seealso>
    let dimensionHeight = Prefixed_Name(datex, "dimensionHeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:dimensionWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dimensionWidth">http://vocab.datex.org/terms#dimensionWidth</seealso>
    let dimensionWidth = Prefixed_Name(datex, "dimensionWidth") |> PrefixedName

    /// <summary>
    ///   <para>datex:genericPublicationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the generic publication.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#genericPublicationName">http://vocab.datex.org/terms#genericPublicationName</seealso>
    let genericPublicationName =
        Prefixed_Name(datex, "genericPublicationName") |> PrefixedName

    /// <summary>
    ///   <para>datex:genericSituationRecordExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#genericSituationRecordExtension">http://vocab.datex.org/terms#genericSituationRecordExtension</seealso>
    let genericSituationRecordExtension =
        Prefixed_Name(datex, "genericSituationRecordExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:MeasurementSiteTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Measurement Site Table comprising a number of sets of data, each describing the location from where a stream of measured data may be derived.  Each location is known as a "measurement site" which can be a point, a linear road section or an area.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MeasurementSiteTable">http://vocab.datex.org/terms#MeasurementSiteTable</seealso>
    let MeasurementSiteTable =
        Prefixed_Name(datex, "MeasurementSiteTable") |> PrefixedName

    /// <summary>
    ///   <para>datex:entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The specified entry on to another road at which the alternative route commences.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#entry">http://vocab.datex.org/terms#entry</seealso>
    let entry = Prefixed_Name(datex, "entry") |> PrefixedName

    /// <summary>
    ///   <para>datex:reroutingManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reroutingManagementExtension">http://vocab.datex.org/terms#reroutingManagementExtension</seealso>
    let reroutingManagementExtension =
        Prefixed_Name(datex, "reroutingManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:fuelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#fuelType">http://vocab.datex.org/terms#fuelType</seealso>
    let fuelType = Prefixed_Name(datex, "fuelType") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPictogramDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPictogramDescription">http://vocab.datex.org/terms#supplementaryPictogramDescription</seealso>
    let supplementaryPictogramDescription =
        Prefixed_Name(datex, "supplementaryPictogramDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:supplementaryPictogramUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#supplementaryPictogramUrl">http://vocab.datex.org/terms#supplementaryPictogramUrl</seealso>
    let supplementaryPictogramUrl =
        Prefixed_Name(datex, "supplementaryPictogramUrl") |> PrefixedName

    /// <summary>
    ///   <para>datex:VmsTablePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more VMS Unit Tables each comprising a set of records which hold details of VMS units.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsTablePublication">http://vocab.datex.org/terms#VmsTablePublication</seealso>
    let VmsTablePublication =
        Prefixed_Name(datex, "VmsTablePublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:vmsUnitTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vmsUnitTable">http://vocab.datex.org/terms#vmsUnitTable</seealso>
    let vmsUnitTable = Prefixed_Name(datex, "vmsUnitTable") |> PrefixedName
    /// <summary>
    ///   <para>datex:VmsUnitTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A versioned VMS Unit Table comprising a number of data records, each record defining the characteristics of a specific deployed variable message sign unit.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#VmsUnitTable">http://vocab.datex.org/terms#VmsUnitTable</seealso>
    let VmsUnitTable = Prefixed_Name(datex, "VmsUnitTable") |> PrefixedName

    /// <summary>
    ///   <para>datex:EnvironmentalObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An obstruction on the road resulting from an environmental cause.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#EnvironmentalObstruction">http://vocab.datex.org/terms#EnvironmentalObstruction</seealso>
    let EnvironmentalObstruction =
        Prefixed_Name(datex, "EnvironmentalObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:Flooding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Flooding">http://vocab.datex.org/terms#Flooding</seealso>
    let Flooding = Prefixed_Name(datex, "Flooding") |> PrefixedName
    /// <summary>
    ///   <para>datex:FoodDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FoodDelivery">http://vocab.datex.org/terms#FoodDelivery</seealso>
    let FoodDelivery = Prefixed_Name(datex, "FoodDelivery") |> PrefixedName
    /// <summary>
    ///   <para>datex:FreezingRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FreezingRain">http://vocab.datex.org/terms#FreezingRain</seealso>
    let FreezingRain = Prefixed_Name(datex, "FreezingRain") |> PrefixedName
    /// <summary>
    ///   <para>datex:GalleryLightsFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GalleryLightsFault">http://vocab.datex.org/terms#GalleryLightsFault</seealso>
    let GalleryLightsFault = Prefixed_Name(datex, "GalleryLightsFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:GeneralNetworkManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Network management action that is instigated either manually or automatically by the network/road operator.  Compliance with any resulting control may be advisory or mandatory.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GeneralNetworkManagement">http://vocab.datex.org/terms#GeneralNetworkManagement</seealso>
    let GeneralNetworkManagement =
        Prefixed_Name(datex, "GeneralNetworkManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:GunfireOnRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#GunfireOnRoadway">http://vocab.datex.org/terms#GunfireOnRoadway</seealso>
    let GunfireOnRoadway = Prefixed_Name(datex, "GunfireOnRoadway") |> PrefixedName

    /// <summary>
    ///   <para>datex:HardShoulderRunningInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HardShoulderRunningInOperation">http://vocab.datex.org/terms#HardShoulderRunningInOperation</seealso>
    let HardShoulderRunningInOperation =
        Prefixed_Name(datex, "HardShoulderRunningInOperation") |> PrefixedName

    /// <summary>
    ///   <para>datex:HeadOnOrSideCollision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HeadOnOrSideCollision">http://vocab.datex.org/terms#HeadOnOrSideCollision</seealso>
    let HeadOnOrSideCollision =
        Prefixed_Name(datex, "HeadOnOrSideCollision") |> PrefixedName

    /// <summary>
    ///   <para>datex:HighSpeedEmergencyVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HighSpeedEmergencyVehicle">http://vocab.datex.org/terms#HighSpeedEmergencyVehicle</seealso>
    let HighSpeedEmergencyVehicle =
        Prefixed_Name(datex, "HighSpeedEmergencyVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureConstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureConstruction">http://vocab.datex.org/terms#InfrastructureConstruction</seealso>
    let InfrastructureConstruction =
        Prefixed_Name(datex, "InfrastructureConstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureDamageObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road resulting from the failure or damage of infrastructure on, under, above or close to the road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureDamageObstruction">http://vocab.datex.org/terms#InfrastructureDamageObstruction</seealso>
    let InfrastructureDamageObstruction =
        Prefixed_Name(datex, "InfrastructureDamageObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureImprovementOrUpgrading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureImprovementOrUpgrading">http://vocab.datex.org/terms#InfrastructureImprovementOrUpgrading</seealso>
    let InfrastructureImprovementOrUpgrading =
        Prefixed_Name(datex, "InfrastructureImprovementOrUpgrading") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSideAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSideAssistance">http://vocab.datex.org/terms#InfrastructureSideAssistance</seealso>
    let InfrastructureSideAssistance =
        Prefixed_Name(datex, "InfrastructureSideAssistance") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSideCommunicationsSystemFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFailure">http://vocab.datex.org/terms#InfrastructureSideCommunicationsSystemFailure</seealso>
    let InfrastructureSideCommunicationsSystemFailure =
        Prefixed_Name(datex, "InfrastructureSideCommunicationsSystemFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureSurfaceInPoorCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureSurfaceInPoorCondition">http://vocab.datex.org/terms#InfrastructureSurfaceInPoorCondition</seealso>
    let InfrastructureSurfaceInPoorCondition =
        Prefixed_Name(datex, "InfrastructureSurfaceInPoorCondition") |> PrefixedName

    /// <summary>
    ///   <para>datex:InfrastructureWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#InfrastructureWorks">http://vocab.datex.org/terms#InfrastructureWorks</seealso>
    let InfrastructureWorks =
        Prefixed_Name(datex, "InfrastructureWorks") |> PrefixedName

    /// <summary>
    ///   <para>datex:JackknifedCaravan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#JackknifedCaravan">http://vocab.datex.org/terms#JackknifedCaravan</seealso>
    let JackknifedCaravan = Prefixed_Name(datex, "JackknifedCaravan") |> PrefixedName
    /// <summary>
    ///   <para>datex:JackknifedTrailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#JackknifedTrailer">http://vocab.datex.org/terms#JackknifedTrailer</seealso>
    let JackknifedTrailer = Prefixed_Name(datex, "JackknifedTrailer") |> PrefixedName

    /// <summary>
    ///   <para>datex:LevelCrossingFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LevelCrossingFailure">http://vocab.datex.org/terms#LevelCrossingFailure</seealso>
    let LevelCrossingFailure =
        Prefixed_Name(datex, "LevelCrossingFailure") |> PrefixedName

    /// <summary>
    ///   <para>datex:LevelCrossingFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LevelCrossingFault">http://vocab.datex.org/terms#LevelCrossingFault</seealso>
    let LevelCrossingFault = Prefixed_Name(datex, "LevelCrossingFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLinearExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLinearExtension">http://vocab.datex.org/terms#alertCLinearExtension</seealso>
    let alertCLinearExtension =
        Prefixed_Name(datex, "alertCLinearExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCLinearByCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCLinearByCode">http://vocab.datex.org/terms#AlertCLinearByCode</seealso>
    let AlertCLinearByCode = Prefixed_Name(datex, "AlertCLinearByCode") |> PrefixedName
    /// <summary>
    ///   <para>datex:alertCDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCDirection">http://vocab.datex.org/terms#alertCDirection</seealso>
    let alertCDirection = Prefixed_Name(datex, "alertCDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLinearByCodeExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLinearByCodeExtension">http://vocab.datex.org/terms#alertCLinearByCodeExtension</seealso>
    let alertCLinearByCodeExtension =
        Prefixed_Name(datex, "alertCLinearByCodeExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:locationCodeForLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linear location defined by a specific Alert-C location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#locationCodeForLinearLocation">http://vocab.datex.org/terms#locationCodeForLinearLocation</seealso>
    let locationCodeForLinearLocation =
        Prefixed_Name(datex, "locationCodeForLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLocationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocationExtension">http://vocab.datex.org/terms#alertCLocationExtension</seealso>
    let alertCLocationExtension =
        Prefixed_Name(datex, "alertCLocationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCLocationName">http://vocab.datex.org/terms#alertCLocationName</seealso>
    let alertCLocationName = Prefixed_Name(datex, "alertCLocationName") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBandByReferenceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBandByReferenceExtension">http://vocab.datex.org/terms#chargeBandByReferenceExtension</seealso>
    let chargeBandByReferenceExtension =
        Prefixed_Name(datex, "chargeBandByReferenceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeBandReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeBandReference">http://vocab.datex.org/terms#chargeBandReference</seealso>
    let chargeBandReference =
        Prefixed_Name(datex, "chargeBandReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_ChargeBandVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_ChargeBandVersionedReference">http://vocab.datex.org/terms#_ChargeBandVersionedReference</seealso>
    let _ChargeBandVersionedReference =
        Prefixed_Name(datex, "_ChargeBandVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:disturbanceActivityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Includes all situations of a public disorder type or of an alert type, with potential to disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#disturbanceActivityType">http://vocab.datex.org/terms#disturbanceActivityType</seealso>
    let disturbanceActivityType =
        Prefixed_Name(datex, "disturbanceActivityType") |> PrefixedName

    /// <summary>
    ///   <para>datex:ElaboratedData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of data which is derived/computed from one or more measurements over a period of time. It may be a current value or a forecast value predicted from historical measurements.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ElaboratedData">http://vocab.datex.org/terms#ElaboratedData</seealso>
    let ElaboratedData = Prefixed_Name(datex, "ElaboratedData") |> PrefixedName
    /// <summary>
    ///   <para>datex:basicData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#basicData">http://vocab.datex.org/terms#basicData</seealso>
    let basicData = Prefixed_Name(datex, "basicData") |> PrefixedName

    /// <summary>
    ///   <para>datex:elaboratedDataExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#elaboratedDataExtension">http://vocab.datex.org/terms#elaboratedDataExtension</seealso>
    let elaboratedDataExtension =
        Prefixed_Name(datex, "elaboratedDataExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:elaboratedDataFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of fault which is being reported for the specified elaborated data.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#elaboratedDataFault">http://vocab.datex.org/terms#elaboratedDataFault</seealso>
    let elaboratedDataFault =
        Prefixed_Name(datex, "elaboratedDataFault") |> PrefixedName

    /// <summary>
    ///   <para>datex:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#source">http://vocab.datex.org/terms#source</seealso>
    let source = Prefixed_Name(datex, "source") |> PrefixedName
    /// <summary>
    ///   <para>datex:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the source from which the information was obtained.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Source">http://vocab.datex.org/terms#Source</seealso>
    let Source = Prefixed_Name(datex, "Source") |> PrefixedName
    /// <summary>
    ///   <para>datex:validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validity">http://vocab.datex.org/terms#validity</seealso>
    let validity = Prefixed_Name(datex, "validity") |> PrefixedName
    /// <summary>
    ///   <para>datex:Validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Validity">http://vocab.datex.org/terms#Validity</seealso>
    let Validity = Prefixed_Name(datex, "Validity") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleStatus">http://vocab.datex.org/terms#vehicleStatus</seealso>
    let vehicleStatus = Prefixed_Name(datex, "vehicleStatus") |> PrefixedName
    /// <summary>
    ///   <para>datex:HazardousMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of hazardous materials.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HazardousMaterials">http://vocab.datex.org/terms#HazardousMaterials</seealso>
    let HazardousMaterials = Prefixed_Name(datex, "HazardousMaterials") |> PrefixedName
    /// <summary>
    ///   <para>datex:chemicalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chemicalName">http://vocab.datex.org/terms#chemicalName</seealso>
    let chemicalName = Prefixed_Name(datex, "chemicalName") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonRoadEventInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonRoadEventInformationExtension">http://vocab.datex.org/terms#nonRoadEventInformationExtension</seealso>
    let nonRoadEventInformationExtension =
        Prefixed_Name(datex, "nonRoadEventInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:NonWeatherRelatedRoadConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Road surface conditions that are not related to the weather but which may affect driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NonWeatherRelatedRoadConditions">http://vocab.datex.org/terms#NonWeatherRelatedRoadConditions</seealso>
    let NonWeatherRelatedRoadConditions =
        Prefixed_Name(datex, "NonWeatherRelatedRoadConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonWeatherRelatedRoadConditionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of road conditions which are not related to the weather.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionType">http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionType</seealso>
    let nonWeatherRelatedRoadConditionType =
        Prefixed_Name(datex, "nonWeatherRelatedRoadConditionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonWeatherRelatedRoadConditionsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionsExtension">http://vocab.datex.org/terms#nonWeatherRelatedRoadConditionsExtension</seealso>
    let nonWeatherRelatedRoadConditionsExtension =
        Prefixed_Name(datex, "nonWeatherRelatedRoadConditionsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:RoadConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#RoadConditions">http://vocab.datex.org/terms#RoadConditions</seealso>
    let RoadConditions = Prefixed_Name(datex, "RoadConditions") |> PrefixedName

    /// <summary>
    ///   <para>datex:NumberOfAxlesCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of axles characteristic of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#NumberOfAxlesCharacteristic">http://vocab.datex.org/terms#NumberOfAxlesCharacteristic</seealso>
    let NumberOfAxlesCharacteristic =
        Prefixed_Name(datex, "NumberOfAxlesCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfAxles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfAxles">http://vocab.datex.org/terms#numberOfAxles</seealso>
    let numberOfAxles = Prefixed_Name(datex, "numberOfAxles") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfAxlesCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfAxlesCharacteristicExtension">http://vocab.datex.org/terms#numberOfAxlesCharacteristicExtension</seealso>
    let numberOfAxlesCharacteristicExtension =
        Prefixed_Name(datex, "numberOfAxlesCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:mobilityOfObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The mobility of the obstruction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#mobilityOfObstruction">http://vocab.datex.org/terms#mobilityOfObstruction</seealso>
    let mobilityOfObstruction =
        Prefixed_Name(datex, "mobilityOfObstruction") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfObstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of obstructions that are partly or wholly blocking the road.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfObstructions">http://vocab.datex.org/terms#numberOfObstructions</seealso>
    let numberOfObstructions =
        Prefixed_Name(datex, "numberOfObstructions") |> PrefixedName

    /// <summary>
    ///   <para>datex:obstructionExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#obstructionExtension">http://vocab.datex.org/terms#obstructionExtension</seealso>
    let obstructionExtension =
        Prefixed_Name(datex, "obstructionExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingRecord">http://vocab.datex.org/terms#parkingRecord</seealso>
    let parkingRecord = Prefixed_Name(datex, "parkingRecord") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTableExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTableExtension">http://vocab.datex.org/terms#parkingTableExtension</seealso>
    let parkingTableExtension =
        Prefixed_Name(datex, "parkingTableExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingTableName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingTableName">http://vocab.datex.org/terms#parkingTableName</seealso>
    let parkingTableName = Prefixed_Name(datex, "parkingTableName") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationContainerExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationContainerExtension">http://vocab.datex.org/terms#predefinedLocationContainerExtension</seealso>
    let predefinedLocationContainerExtension =
        Prefixed_Name(datex, "predefinedLocationContainerExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:PredefinedLocationsPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing one or more groups of predefined locations organised either as litineraries, non ordered groups or as individual locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PredefinedLocationsPublication">http://vocab.datex.org/terms#PredefinedLocationsPublication</seealso>
    let PredefinedLocationsPublication =
        Prefixed_Name(datex, "PredefinedLocationsPublication") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationContainer">http://vocab.datex.org/terms#predefinedLocationContainer</seealso>
    let predefinedLocationContainer =
        Prefixed_Name(datex, "predefinedLocationContainer") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedLocationsPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedLocationsPublicationExtension">http://vocab.datex.org/terms#predefinedLocationsPublicationExtension</seealso>
    let predefinedLocationsPublicationExtension =
        Prefixed_Name(datex, "predefinedLocationsPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:intersectWithApplicableDays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#intersectWithApplicableDays">http://vocab.datex.org/terms#intersectWithApplicableDays</seealso>
    let intersectWithApplicableDays =
        Prefixed_Name(datex, "intersectWithApplicableDays") |> PrefixedName

    /// <summary>
    ///   <para>datex:publicHoliday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#publicHoliday">http://vocab.datex.org/terms#publicHoliday</seealso>
    let publicHoliday = Prefixed_Name(datex, "publicHoliday") |> PrefixedName

    /// <summary>
    ///   <para>datex:specialDayExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specialDayExtension">http://vocab.datex.org/terms#specialDayExtension</seealso>
    let specialDayExtension =
        Prefixed_Name(datex, "specialDayExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:specialDayName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specialDayName">http://vocab.datex.org/terms#specialDayName</seealso>
    let specialDayName = Prefixed_Name(datex, "specialDayName") |> PrefixedName
    /// <summary>
    ///   <para>datex:specialDayType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specialDayType">http://vocab.datex.org/terms#specialDayType</seealso>
    let specialDayType = Prefixed_Name(datex, "specialDayType") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpecialLocationParkingSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parking site which is located at a special location, often associated with some building.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpecialLocationParkingSite">http://vocab.datex.org/terms#SpecialLocationParkingSite</seealso>
    let SpecialLocationParkingSite =
        Prefixed_Name(datex, "SpecialLocationParkingSite") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingOtherSpecialLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A special location not available in the enumeration. Use literal 'other' in this case.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingOtherSpecialLocation">http://vocab.datex.org/terms#parkingOtherSpecialLocation</seealso>
    let parkingOtherSpecialLocation =
        Prefixed_Name(datex, "parkingOtherSpecialLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpecialLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The special location of the parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpecialLocation">http://vocab.datex.org/terms#parkingSpecialLocation</seealso>
    let parkingSpecialLocation =
        Prefixed_Name(datex, "parkingSpecialLocation") |> PrefixedName

    /// <summary>
    ///   <para>datex:speedManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedManagementExtension">http://vocab.datex.org/terms#speedManagementExtension</seealso>
    let speedManagementExtension =
        Prefixed_Name(datex, "speedManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:speedManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of speed management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedManagementType">http://vocab.datex.org/terms#speedManagementType</seealso>
    let speedManagementType =
        Prefixed_Name(datex, "speedManagementType") |> PrefixedName

    /// <summary>
    ///   <para>datex:temporarySpeedLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Temporary limit defining the maximum advisory or mandatory speed of vehicles.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#temporarySpeedLimit">http://vocab.datex.org/terms#temporarySpeedLimit</seealso>
    let temporarySpeedLimit =
        Prefixed_Name(datex, "temporarySpeedLimit") |> PrefixedName

    /// <summary>
    ///   <para>datex:SpeedPercentile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of percentage (from an observation set) of vehicles whose speeds fall below a stated value.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SpeedPercentile">http://vocab.datex.org/terms#SpeedPercentile</seealso>
    let SpeedPercentile = Prefixed_Name(datex, "SpeedPercentile") |> PrefixedName
    /// <summary>
    ///   <para>datex:speedPercentile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedPercentile">http://vocab.datex.org/terms#speedPercentile</seealso>
    let speedPercentile = Prefixed_Name(datex, "speedPercentile") |> PrefixedName

    /// <summary>
    ///   <para>datex:speedPercentileExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedPercentileExtension">http://vocab.datex.org/terms#speedPercentileExtension</seealso>
    let speedPercentileExtension =
        Prefixed_Name(datex, "speedPercentileExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehiclePercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehiclePercentage">http://vocab.datex.org/terms#vehiclePercentage</seealso>
    let vehiclePercentage = Prefixed_Name(datex, "vehiclePercentage") |> PrefixedName
    /// <summary>
    ///   <para>datex:speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of speed expressed in kilometres per hour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speed">http://vocab.datex.org/terms#speed</seealso>
    let speed = Prefixed_Name(datex, "speed") |> PrefixedName

    /// <summary>
    ///   <para>datex:speedValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#speedValueExtension">http://vocab.datex.org/terms#speedValueExtension</seealso>
    let speedValueExtension =
        Prefixed_Name(datex, "speedValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfSubjects">http://vocab.datex.org/terms#numberOfSubjects</seealso>
    let numberOfSubjects = Prefixed_Name(datex, "numberOfSubjects") |> PrefixedName
    /// <summary>
    ///   <para>datex:subjectTypeOfWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subjectTypeOfWorks">http://vocab.datex.org/terms#subjectTypeOfWorks</seealso>
    let subjectTypeOfWorks = Prefixed_Name(datex, "subjectTypeOfWorks") |> PrefixedName
    /// <summary>
    ///   <para>datex:subjectsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#subjectsExtension">http://vocab.datex.org/terms#subjectsExtension</seealso>
    let subjectsExtension = Prefixed_Name(datex, "subjectsExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:parkingZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Name or identifier of a parking zone this parking site belongs to. To be filled with the string value 'True', if there is a parking zone with unknown name.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingZone">http://vocab.datex.org/terms#parkingZone</seealso>
    let parkingZone = Prefixed_Name(datex, "parkingZone") |> PrefixedName

    /// <summary>
    ///   <para>datex:urbanParkingSiteExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urbanParkingSiteExtension">http://vocab.datex.org/terms#urbanParkingSiteExtension</seealso>
    let urbanParkingSiteExtension =
        Prefixed_Name(datex, "urbanParkingSiteExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:urbanParkingSiteType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of urban parking site.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urbanParkingSiteType">http://vocab.datex.org/terms#urbanParkingSiteType</seealso>
    let urbanParkingSiteType =
        Prefixed_Name(datex, "urbanParkingSiteType") |> PrefixedName

    /// <summary>
    ///   <para>datex:urlLinkDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urlLinkDescription">http://vocab.datex.org/terms#urlLinkDescription</seealso>
    let urlLinkDescription = Prefixed_Name(datex, "urlLinkDescription") |> PrefixedName
    /// <summary>
    ///   <para>datex:urlLinkExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urlLinkExtension">http://vocab.datex.org/terms#urlLinkExtension</seealso>
    let urlLinkExtension = Prefixed_Name(datex, "urlLinkExtension") |> PrefixedName
    /// <summary>
    ///   <para>datex:urlLinkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urlLinkType">http://vocab.datex.org/terms#urlLinkType</seealso>
    let urlLinkType = Prefixed_Name(datex, "urlLinkType") |> PrefixedName
    /// <summary>
    ///   <para>datex:otherPaymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherPaymentCard">http://vocab.datex.org/terms#otherPaymentCard</seealso>
    let otherPaymentCard = Prefixed_Name(datex, "otherPaymentCard") |> PrefixedName

    /// <summary>
    ///   <para>datex:otherPaymentCardBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#otherPaymentCardBrand">http://vocab.datex.org/terms#otherPaymentCardBrand</seealso>
    let otherPaymentCardBrand =
        Prefixed_Name(datex, "otherPaymentCardBrand") |> PrefixedName

    /// <summary>
    ///   <para>datex:paymentCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentCard">http://vocab.datex.org/terms#paymentCard</seealso>
    let paymentCard = Prefixed_Name(datex, "paymentCard") |> PrefixedName
    /// <summary>
    ///   <para>datex:paymentCardBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#paymentCardBrand">http://vocab.datex.org/terms#paymentCardBrand</seealso>
    let paymentCardBrand = Prefixed_Name(datex, "paymentCardBrand") |> PrefixedName

    /// <summary>
    ///   <para>datex:usedPaymentCardExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#usedPaymentCardExtension">http://vocab.datex.org/terms#usedPaymentCardExtension</seealso>
    let usedPaymentCardExtension =
        Prefixed_Name(datex, "usedPaymentCardExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:validityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#validityStatus">http://vocab.datex.org/terms#validityStatus</seealso>
    let validityStatus = Prefixed_Name(datex, "validityStatus") |> PrefixedName

    /// <summary>
    ///   <para>datex:axleSpacingOnVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#axleSpacingOnVehicle">http://vocab.datex.org/terms#axleSpacingOnVehicle</seealso>
    let axleSpacingOnVehicle =
        Prefixed_Name(datex, "axleSpacingOnVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:hazardousGoodsAssociatedWithVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#hazardousGoodsAssociatedWithVehicle">http://vocab.datex.org/terms#hazardousGoodsAssociatedWithVehicle</seealso>
    let hazardousGoodsAssociatedWithVehicle =
        Prefixed_Name(datex, "hazardousGoodsAssociatedWithVehicle") |> PrefixedName

    /// <summary>
    ///   <para>datex:specificAxleWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#specificAxleWeight">http://vocab.datex.org/terms#specificAxleWeight</seealso>
    let specificAxleWeight = Prefixed_Name(datex, "specificAxleWeight") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleColour">http://vocab.datex.org/terms#vehicleColour</seealso>
    let vehicleColour = Prefixed_Name(datex, "vehicleColour") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleManufacturer">http://vocab.datex.org/terms#vehicleManufacturer</seealso>
    let vehicleManufacturer =
        Prefixed_Name(datex, "vehicleManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleModel">http://vocab.datex.org/terms#vehicleModel</seealso>
    let vehicleModel = Prefixed_Name(datex, "vehicleModel") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleRegistrationPlateIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleRegistrationPlateIdentifier">http://vocab.datex.org/terms#vehicleRegistrationPlateIdentifier</seealso>
    let vehicleRegistrationPlateIdentifier =
        Prefixed_Name(datex, "vehicleRegistrationPlateIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>datex:grossWeightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#grossWeightCharacteristic">http://vocab.datex.org/terms#grossWeightCharacteristic</seealso>
    let grossWeightCharacteristic =
        Prefixed_Name(datex, "grossWeightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:heaviestAxleWeightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heaviestAxleWeightCharacteristic">http://vocab.datex.org/terms#heaviestAxleWeightCharacteristic</seealso>
    let heaviestAxleWeightCharacteristic =
        Prefixed_Name(datex, "heaviestAxleWeightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:heightCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#heightCharacteristic">http://vocab.datex.org/terms#heightCharacteristic</seealso>
    let heightCharacteristic =
        Prefixed_Name(datex, "heightCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:lengthCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lengthCharacteristic">http://vocab.datex.org/terms#lengthCharacteristic</seealso>
    let lengthCharacteristic =
        Prefixed_Name(datex, "lengthCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:loadType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#loadType">http://vocab.datex.org/terms#loadType</seealso>
    let loadType = Prefixed_Name(datex, "loadType") |> PrefixedName

    /// <summary>
    ///   <para>datex:numberOfAxlesCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#numberOfAxlesCharacteristic">http://vocab.datex.org/terms#numberOfAxlesCharacteristic</seealso>
    let numberOfAxlesCharacteristic =
        Prefixed_Name(datex, "numberOfAxlesCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleCharacteristicsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleCharacteristicsExtension">http://vocab.datex.org/terms#vehicleCharacteristicsExtension</seealso>
    let vehicleCharacteristicsExtension =
        Prefixed_Name(datex, "vehicleCharacteristicsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:_VehicleCharacteristicsExtensionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_VehicleCharacteristicsExtensionType">http://vocab.datex.org/terms#_VehicleCharacteristicsExtensionType</seealso>
    let _VehicleCharacteristicsExtensionType =
        Prefixed_Name(datex, "_VehicleCharacteristicsExtensionType") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleEquipment">http://vocab.datex.org/terms#vehicleEquipment</seealso>
    let vehicleEquipment = Prefixed_Name(datex, "vehicleEquipment") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleUsage">http://vocab.datex.org/terms#vehicleUsage</seealso>
    let vehicleUsage = Prefixed_Name(datex, "vehicleUsage") |> PrefixedName

    /// <summary>
    ///   <para>datex:FallingLightIceOrSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#FallingLightIceOrSnow">http://vocab.datex.org/terms#FallingLightIceOrSnow</seealso>
    let FallingLightIceOrSnow =
        Prefixed_Name(datex, "FallingLightIceOrSnow") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The direction of traffic flow along the road to which the information relates.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCDirection">http://vocab.datex.org/terms#AlertCDirection</seealso>
    let AlertCDirection = Prefixed_Name(datex, "AlertCDirection") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCDirectionCoded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCDirectionCoded">http://vocab.datex.org/terms#alertCDirectionCoded</seealso>
    let alertCDirectionCoded =
        Prefixed_Name(datex, "alertCDirectionCoded") |> PrefixedName

    /// <summary>
    ///   <para>datex:MultilingualString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MultilingualString">http://vocab.datex.org/terms#MultilingualString</seealso>
    let MultilingualString = Prefixed_Name(datex, "MultilingualString") |> PrefixedName

    /// <summary>
    ///   <para>datex:ItineraryByReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple (i.e. more than one) physically separate locations which are ordered that constitute an itinerary or route where they are defined by reference to a predefined itinerary.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#ItineraryByReference">http://vocab.datex.org/terms#ItineraryByReference</seealso>
    let ItineraryByReference =
        Prefixed_Name(datex, "ItineraryByReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:predefinedItineraryReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A reference to a versioned instance of a predefined itinerary as specified in a PredefinedLocationsPublication.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#predefinedItineraryReference">http://vocab.datex.org/terms#predefinedItineraryReference</seealso>
    let predefinedItineraryReference =
        Prefixed_Name(datex, "predefinedItineraryReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:_PredefinedItineraryVersionedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#_PredefinedItineraryVersionedReference">http://vocab.datex.org/terms#_PredefinedItineraryVersionedReference</seealso>
    let _PredefinedItineraryVersionedReference =
        Prefixed_Name(datex, "_PredefinedItineraryVersionedReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:Junction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Junction (on a highway), can also be an interchange or if applicable also a motorway service station (see junctionClassification).</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#Junction">http://vocab.datex.org/terms#Junction</seealso>
    let Junction = Prefixed_Name(datex, "Junction") |> PrefixedName

    /// <summary>
    ///   <para>datex:junctionClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#junctionClassification">http://vocab.datex.org/terms#junctionClassification</seealso>
    let junctionClassification =
        Prefixed_Name(datex, "junctionClassification") |> PrefixedName

    /// <summary>
    ///   <para>datex:junctionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Name of the junction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#junctionName">http://vocab.datex.org/terms#junctionName</seealso>
    let junctionName = Prefixed_Name(datex, "junctionName") |> PrefixedName
    /// <summary>
    ///   <para>datex:junctionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#junctionNumber">http://vocab.datex.org/terms#junctionNumber</seealso>
    let junctionNumber = Prefixed_Name(datex, "junctionNumber") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrGridAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>attributes required for the grid method</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrGridAttributes">http://vocab.datex.org/terms#OpenlrGridAttributes</seealso>
    let OpenlrGridAttributes =
        Prefixed_Name(datex, "OpenlrGridAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrGridAttributesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrGridAttributesExtension">http://vocab.datex.org/terms#openlrGridAttributesExtension</seealso>
    let openlrGridAttributesExtension =
        Prefixed_Name(datex, "openlrGridAttributesExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrNumRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrNumRows">http://vocab.datex.org/terms#openlrNumRows</seealso>
    let openlrNumRows = Prefixed_Name(datex, "openlrNumRows") |> PrefixedName

    /// <summary>
    ///   <para>datex:OpenlrGridLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the openLR method of areadefinition by providing repeating rectangles</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#OpenlrGridLocationReference">http://vocab.datex.org/terms#OpenlrGridLocationReference</seealso>
    let OpenlrGridLocationReference =
        Prefixed_Name(datex, "OpenlrGridLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:openlrGridAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#openlrGridAttributes">http://vocab.datex.org/terms#openlrGridAttributes</seealso>
    let openlrGridAttributes =
        Prefixed_Name(datex, "openlrGridAttributes") |> PrefixedName

    /// <summary>
    ///   <para>datex:distanceToThisRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#distanceToThisRoad">http://vocab.datex.org/terms#distanceToThisRoad</seealso>
    let distanceToThisRoad = Prefixed_Name(datex, "distanceToThisRoad") |> PrefixedName
    /// <summary>
    ///   <para>datex:nameOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nameOfRoad">http://vocab.datex.org/terms#nameOfRoad</seealso>
    let nameOfRoad = Prefixed_Name(datex, "nameOfRoad") |> PrefixedName

    /// <summary>
    ///   <para>datex:TextDisplayAreaSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Settings specific to a distinct text display area on the VMS.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#TextDisplayAreaSettings">http://vocab.datex.org/terms#TextDisplayAreaSettings</seealso>
    let TextDisplayAreaSettings =
        Prefixed_Name(datex, "TextDisplayAreaSettings") |> PrefixedName

    /// <summary>
    ///   <para>datex:textDisplayAreaSettingsExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textDisplayAreaSettingsExtension">http://vocab.datex.org/terms#textDisplayAreaSettingsExtension</seealso>
    let textDisplayAreaSettingsExtension =
        Prefixed_Name(datex, "textDisplayAreaSettingsExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:textLanternsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textLanternsOn">http://vocab.datex.org/terms#textLanternsOn</seealso>
    let textLanternsOn = Prefixed_Name(datex, "textLanternsOn") |> PrefixedName

    /// <summary>
    ///   <para>datex:textLuminanceOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#textLuminanceOverride">http://vocab.datex.org/terms#textLuminanceOverride</seealso>
    let textLuminanceOverride =
        Prefixed_Name(datex, "textLuminanceOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:operationFreeOfEmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#operationFreeOfEmission">http://vocab.datex.org/terms#operationFreeOfEmission</seealso>
    let operationFreeOfEmission =
        Prefixed_Name(datex, "operationFreeOfEmission") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleType2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleType2">http://vocab.datex.org/terms#vehicleType2</seealso>
    let vehicleType2 = Prefixed_Name(datex, "vehicleType2") |> PrefixedName
    /// <summary>
    ///   <para>datex:maxNumberOfRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxNumberOfRows">http://vocab.datex.org/terms#maxNumberOfRows</seealso>
    let maxNumberOfRows = Prefixed_Name(datex, "maxNumberOfRows") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxNumberOfSequentialPages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxNumberOfSequentialPages">http://vocab.datex.org/terms#maxNumberOfSequentialPages</seealso>
    let maxNumberOfSequentialPages =
        Prefixed_Name(datex, "maxNumberOfSequentialPages") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxTextLuminanceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxTextLuminanceLevel">http://vocab.datex.org/terms#maxTextLuminanceLevel</seealso>
    let maxTextLuminanceLevel =
        Prefixed_Name(datex, "maxTextLuminanceLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingBuses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingBuses">http://vocab.datex.org/terms#AccidentInvolvingBuses</seealso>
    let AccidentInvolvingBuses =
        Prefixed_Name(datex, "AccidentInvolvingBuses") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingMopeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingMopeds">http://vocab.datex.org/terms#AccidentInvolvingMopeds</seealso>
    let AccidentInvolvingMopeds =
        Prefixed_Name(datex, "AccidentInvolvingMopeds") |> PrefixedName

    /// <summary>
    ///   <para>datex:AccidentInvolvingTrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AccidentInvolvingTrain">http://vocab.datex.org/terms#AccidentInvolvingTrain</seealso>
    let AccidentInvolvingTrain =
        Prefixed_Name(datex, "AccidentInvolvingTrain") |> PrefixedName

    /// <summary>
    ///   <para>datex:HerdOfAnimalsOnTheInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HerdOfAnimalsOnTheInfrastructure">http://vocab.datex.org/terms#HerdOfAnimalsOnTheInfrastructure</seealso>
    let HerdOfAnimalsOnTheInfrastructure =
        Prefixed_Name(datex, "HerdOfAnimalsOnTheInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>datex:HurricaneForceWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#HurricaneForceWinds">http://vocab.datex.org/terms#HurricaneForceWinds</seealso>
    let HurricaneForceWinds =
        Prefixed_Name(datex, "HurricaneForceWinds") |> PrefixedName

    /// <summary>
    ///   <para>datex:alertCDirectionNamed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#alertCDirectionNamed">http://vocab.datex.org/terms#alertCDirectionNamed</seealso>
    let alertCDirectionNamed =
        Prefixed_Name(datex, "alertCDirectionNamed") |> PrefixedName

    /// <summary>
    ///   <para>datex:AlertCLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#AlertCLinear">http://vocab.datex.org/terms#AlertCLinear</seealso>
    let AlertCLinear = Prefixed_Name(datex, "AlertCLinear") |> PrefixedName
    /// <summary>
    ///   <para>datex:chargeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeType">http://vocab.datex.org/terms#chargeType</seealso>
    let chargeType = Prefixed_Name(datex, "chargeType") |> PrefixedName

    /// <summary>
    ///   <para>datex:chargeTypeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#chargeTypeDescription">http://vocab.datex.org/terms#chargeTypeDescription</seealso>
    let chargeTypeDescription =
        Prefixed_Name(datex, "chargeTypeDescription") |> PrefixedName

    /// <summary>
    ///   <para>datex:maxIterationsOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#maxIterationsOfCharge">http://vocab.datex.org/terms#maxIterationsOfCharge</seealso>
    let maxIterationsOfCharge =
        Prefixed_Name(datex, "maxIterationsOfCharge") |> PrefixedName

    /// <summary>
    ///   <para>datex:minIterationsOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#minIterationsOfCharge">http://vocab.datex.org/terms#minIterationsOfCharge</seealso>
    let minIterationsOfCharge =
        Prefixed_Name(datex, "minIterationsOfCharge") |> PrefixedName

    /// <summary>
    ///   <para>datex:LengthCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Length characteristic of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LengthCharacteristic">http://vocab.datex.org/terms#LengthCharacteristic</seealso>
    let LengthCharacteristic =
        Prefixed_Name(datex, "LengthCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>datex:lengthCharacteristicExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lengthCharacteristicExtension">http://vocab.datex.org/terms#lengthCharacteristicExtension</seealso>
    let lengthCharacteristicExtension =
        Prefixed_Name(datex, "lengthCharacteristicExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:vehicleLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleLength">http://vocab.datex.org/terms#vehicleLength</seealso>
    let vehicleLength = Prefixed_Name(datex, "vehicleLength") |> PrefixedName

    /// <summary>
    ///   <para>datex:LifeCycleManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information relating to the life cycle management of the situation record.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#LifeCycleManagement">http://vocab.datex.org/terms#LifeCycleManagement</seealso>
    let LifeCycleManagement =
        Prefixed_Name(datex, "LifeCycleManagement") |> PrefixedName

    /// <summary>
    ///   <para>datex:cancel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#cancel">http://vocab.datex.org/terms#cancel</seealso>
    let cancel = Prefixed_Name(datex, "cancel") |> PrefixedName
    /// <summary>
    ///   <para>datex:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#end">http://vocab.datex.org/terms#end</seealso>
    let end_ = Prefixed_Name(datex, "end") |> PrefixedName

    /// <summary>
    ///   <para>datex:lifeCycleManagementExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lifeCycleManagementExtension">http://vocab.datex.org/terms#lifeCycleManagementExtension</seealso>
    let lifeCycleManagementExtension =
        Prefixed_Name(datex, "lifeCycleManagementExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:MultilingualStringValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#MultilingualStringValue">http://vocab.datex.org/terms#MultilingualStringValue</seealso>
    let MultilingualStringValue =
        Prefixed_Name(datex, "MultilingualStringValue") |> PrefixedName

    /// <summary>
    ///   <para>datex:lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#lang">http://vocab.datex.org/terms#lang</seealso>
    let lang = Prefixed_Name(datex, "lang") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessOnlyAssignedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessOnlyAssignedFor">http://vocab.datex.org/terms#accessOnlyAssignedFor</seealso>
    let accessOnlyAssignedFor =
        Prefixed_Name(datex, "accessOnlyAssignedFor") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessProhibitedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessProhibitedFor">http://vocab.datex.org/terms#accessProhibitedFor</seealso>
    let accessProhibitedFor =
        Prefixed_Name(datex, "accessProhibitedFor") |> PrefixedName

    /// <summary>
    ///   <para>datex:accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#accessibility">http://vocab.datex.org/terms#accessibility</seealso>
    let accessibility = Prefixed_Name(datex, "accessibility") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSpaceStatusExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSpaceStatusExtension">http://vocab.datex.org/terms#parkingSpaceStatusExtension</seealso>
    let parkingSpaceStatusExtension =
        Prefixed_Name(datex, "parkingSpaceStatusExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:certifiedSecureParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#certifiedSecureParking">http://vocab.datex.org/terms#certifiedSecureParking</seealso>
    let certifiedSecureParking =
        Prefixed_Name(datex, "certifiedSecureParking") |> PrefixedName

    /// <summary>
    ///   <para>datex:dateOfCertification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#dateOfCertification">http://vocab.datex.org/terms#dateOfCertification</seealso>
    let dateOfCertification =
        Prefixed_Name(datex, "dateOfCertification") |> PrefixedName

    /// <summary>
    ///   <para>datex:labelSecurityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#labelSecurityLevel">http://vocab.datex.org/terms#labelSecurityLevel</seealso>
    let labelSecurityLevel = Prefixed_Name(datex, "labelSecurityLevel") |> PrefixedName
    /// <summary>
    ///   <para>datex:labelServiceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#labelServiceLevel">http://vocab.datex.org/terms#labelServiceLevel</seealso>
    let labelServiceLevel = Prefixed_Name(datex, "labelServiceLevel") |> PrefixedName

    /// <summary>
    ///   <para>datex:labelServiceLevelSelfAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#labelServiceLevelSelfAssessment">http://vocab.datex.org/terms#labelServiceLevelSelfAssessment</seealso>
    let labelServiceLevelSelfAssessment =
        Prefixed_Name(datex, "labelServiceLevelSelfAssessment") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingAdditionalSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingAdditionalSecurity">http://vocab.datex.org/terms#parkingAdditionalSecurity</seealso>
    let parkingAdditionalSecurity =
        Prefixed_Name(datex, "parkingAdditionalSecurity") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingSecurityNationalClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingSecurityNationalClassification">http://vocab.datex.org/terms#parkingSecurityNationalClassification</seealso>
    let parkingSecurityNationalClassification =
        Prefixed_Name(datex, "parkingSecurityNationalClassification") |> PrefixedName

    /// <summary>
    ///   <para>datex:parkingStandardsAndSecurityExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#parkingStandardsAndSecurityExtension">http://vocab.datex.org/terms#parkingStandardsAndSecurityExtension</seealso>
    let parkingStandardsAndSecurityExtension =
        Prefixed_Name(datex, "parkingStandardsAndSecurityExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationType">http://vocab.datex.org/terms#precipitationType</seealso>
    let precipitationType = Prefixed_Name(datex, "precipitationType") |> PrefixedName

    /// <summary>
    ///   <para>datex:PrecipitationInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of precipitation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#PrecipitationInformation">http://vocab.datex.org/terms#PrecipitationInformation</seealso>
    let PrecipitationInformation =
        Prefixed_Name(datex, "PrecipitationInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:noPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether precipitation is present or not. True indicates there is no precipitation.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#noPrecipitation">http://vocab.datex.org/terms#noPrecipitation</seealso>
    let noPrecipitation = Prefixed_Name(datex, "noPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>datex:millimetresPerHourIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of precipitation intensity expressed in units of millimetres per hour.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#millimetresPerHourIntensity">http://vocab.datex.org/terms#millimetresPerHourIntensity</seealso>
    let millimetresPerHourIntensity =
        Prefixed_Name(datex, "millimetresPerHourIntensity") |> PrefixedName

    /// <summary>
    ///   <para>datex:precipitationIntensityValueExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#precipitationIntensityValueExtension">http://vocab.datex.org/terms#precipitationIntensityValueExtension</seealso>
    let precipitationIntensityValueExtension =
        Prefixed_Name(datex, "precipitationIntensityValueExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationPublicationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationPublicationExtension">http://vocab.datex.org/terms#situationPublicationExtension</seealso>
    let situationPublicationExtension =
        Prefixed_Name(datex, "situationPublicationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#cause">http://vocab.datex.org/terms#cause</seealso>
    let cause = Prefixed_Name(datex, "cause") |> PrefixedName

    /// <summary>
    ///   <para>datex:confidentialityOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#confidentialityOverride">http://vocab.datex.org/terms#confidentialityOverride</seealso>
    let confidentialityOverride =
        Prefixed_Name(datex, "confidentialityOverride") |> PrefixedName

    /// <summary>
    ///   <para>datex:impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#impact">http://vocab.datex.org/terms#impact</seealso>
    let impact = Prefixed_Name(datex, "impact") |> PrefixedName
    /// <summary>
    ///   <para>datex:management</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#management">http://vocab.datex.org/terms#management</seealso>
    let management = Prefixed_Name(datex, "management") |> PrefixedName

    /// <summary>
    ///   <para>datex:nonGeneralPublicComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#nonGeneralPublicComment">http://vocab.datex.org/terms#nonGeneralPublicComment</seealso>
    let nonGeneralPublicComment =
        Prefixed_Name(datex, "nonGeneralPublicComment") |> PrefixedName

    /// <summary>
    ///   <para>datex:probabilityOfOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#probabilityOfOccurrence">http://vocab.datex.org/terms#probabilityOfOccurrence</seealso>
    let probabilityOfOccurrence =
        Prefixed_Name(datex, "probabilityOfOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>datex:severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#severity">http://vocab.datex.org/terms#severity</seealso>
    let severity = Prefixed_Name(datex, "severity") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordFirstSupplierVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordFirstSupplierVersionTime">http://vocab.datex.org/terms#situationRecordFirstSupplierVersionTime</seealso>
    let situationRecordFirstSupplierVersionTime =
        Prefixed_Name(datex, "situationRecordFirstSupplierVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordObservationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordObservationTime">http://vocab.datex.org/terms#situationRecordObservationTime</seealso>
    let situationRecordObservationTime =
        Prefixed_Name(datex, "situationRecordObservationTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:situationRecordVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#situationRecordVersionTime">http://vocab.datex.org/terms#situationRecordVersionTime</seealso>
    let situationRecordVersionTime =
        Prefixed_Name(datex, "situationRecordVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:urlLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#urlLink">http://vocab.datex.org/terms#urlLink</seealso>
    let urlLink = Prefixed_Name(datex, "urlLink") |> PrefixedName
    /// <summary>
    ///   <para>datex:UrlLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of a Uniform Resource Locator (URL) address pointing to a resource available on the Internet from where further relevant information may be obtained.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#UrlLink">http://vocab.datex.org/terms#UrlLink</seealso>
    let UrlLink = Prefixed_Name(datex, "UrlLink") |> PrefixedName

    /// <summary>
    ///   <para>datex:SituationRecordExtendedApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension class for SituationRecord.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#SituationRecordExtendedApproved">http://vocab.datex.org/terms#SituationRecordExtendedApproved</seealso>
    let SituationRecordExtendedApproved =
        Prefixed_Name(datex, "SituationRecordExtendedApproved") |> PrefixedName

    /// <summary>
    ///   <para>datex:safetyRelatedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#safetyRelatedMessage">http://vocab.datex.org/terms#safetyRelatedMessage</seealso>
    let safetyRelatedMessage =
        Prefixed_Name(datex, "safetyRelatedMessage") |> PrefixedName

    /// <summary>
    ///   <para>datex:reliable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#reliable">http://vocab.datex.org/terms#reliable</seealso>
    let reliable = Prefixed_Name(datex, "reliable") |> PrefixedName
    /// <summary>
    ///   <para>datex:sourceCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sourceCountry">http://vocab.datex.org/terms#sourceCountry</seealso>
    let sourceCountry = Prefixed_Name(datex, "sourceCountry") |> PrefixedName
    /// <summary>
    ///   <para>datex:sourceExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sourceExtension">http://vocab.datex.org/terms#sourceExtension</seealso>
    let sourceExtension = Prefixed_Name(datex, "sourceExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:sourceIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sourceIdentification">http://vocab.datex.org/terms#sourceIdentification</seealso>
    let sourceIdentification =
        Prefixed_Name(datex, "sourceIdentification") |> PrefixedName

    /// <summary>
    ///   <para>datex:sourceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sourceName">http://vocab.datex.org/terms#sourceName</seealso>
    let sourceName = Prefixed_Name(datex, "sourceName") |> PrefixedName
    /// <summary>
    ///   <para>datex:sourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#sourceType">http://vocab.datex.org/terms#sourceType</seealso>
    let sourceType = Prefixed_Name(datex, "sourceType") |> PrefixedName
    /// <summary>
    ///   <para>datex:journeyReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates a transit service journey number.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#journeyReference">http://vocab.datex.org/terms#journeyReference</seealso>
    let journeyReference = Prefixed_Name(datex, "journeyReference") |> PrefixedName

    /// <summary>
    ///   <para>datex:scheduledDepartureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the timetabled departure time of a transit service for a specified location.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#scheduledDepartureTime">http://vocab.datex.org/terms#scheduledDepartureTime</seealso>
    let scheduledDepartureTime =
        Prefixed_Name(datex, "scheduledDepartureTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:transitInformationExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#transitInformationExtension">http://vocab.datex.org/terms#transitInformationExtension</seealso>
    let transitInformationExtension =
        Prefixed_Name(datex, "transitInformationExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:transitServiceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information about transit services.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#transitServiceInformation">http://vocab.datex.org/terms#transitServiceInformation</seealso>
    let transitServiceInformation =
        Prefixed_Name(datex, "transitServiceInformation") |> PrefixedName

    /// <summary>
    ///   <para>datex:transitServiceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type of transit service to which the information relates.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#transitServiceType">http://vocab.datex.org/terms#transitServiceType</seealso>
    let transitServiceType = Prefixed_Name(datex, "transitServiceType") |> PrefixedName
    /// <summary>
    ///   <para>datex:freeFlowSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The free flow speed expected under ideal conditions, corresponding to the freeFlowTravelTime.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#freeFlowSpeed">http://vocab.datex.org/terms#freeFlowSpeed</seealso>
    let freeFlowSpeed = Prefixed_Name(datex, "freeFlowSpeed") |> PrefixedName
    /// <summary>
    ///   <para>datex:freeFlowTravelTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The travel time which would be expected under ideal free flow conditions.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#freeFlowTravelTime">http://vocab.datex.org/terms#freeFlowTravelTime</seealso>
    let freeFlowTravelTime = Prefixed_Name(datex, "freeFlowTravelTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:normallyExpectedTravelTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The travel time which is expected for the given period (e.g. date/time, holiday status etc.) and any known quasi-static conditions (e.g. long term roadworks). This value is derived from historical analysis.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#normallyExpectedTravelTime">http://vocab.datex.org/terms#normallyExpectedTravelTime</seealso>
    let normallyExpectedTravelTime =
        Prefixed_Name(datex, "normallyExpectedTravelTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:travelTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Derived/computed travel time information relating to a specific group of locations.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#travelTime">http://vocab.datex.org/terms#travelTime</seealso>
    let travelTime = Prefixed_Name(datex, "travelTime") |> PrefixedName

    /// <summary>
    ///   <para>datex:travelTimeDataExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#travelTimeDataExtension">http://vocab.datex.org/terms#travelTimeDataExtension</seealso>
    let travelTimeDataExtension =
        Prefixed_Name(datex, "travelTimeDataExtension") |> PrefixedName

    /// <summary>
    ///   <para>datex:travelTimeTrendType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The current trend in the travel time between the defined locations in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#travelTimeTrendType">http://vocab.datex.org/terms#travelTimeTrendType</seealso>
    let travelTimeTrendType =
        Prefixed_Name(datex, "travelTimeTrendType") |> PrefixedName

    /// <summary>
    ///   <para>datex:travelTimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of the way in which the travel time is derived.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#travelTimeType">http://vocab.datex.org/terms#travelTimeType</seealso>
    let travelTimeType = Prefixed_Name(datex, "travelTimeType") |> PrefixedName
    /// <summary>
    ///   <para>datex:vehicleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Vehicle type.</para>
    /// </remarks>
    /// <seealso href="http://vocab.datex.org/terms#vehicleType">http://vocab.datex.org/terms#vehicleType</seealso>
    let vehicleType = Prefixed_Name(datex, "vehicleType") |> PrefixedName

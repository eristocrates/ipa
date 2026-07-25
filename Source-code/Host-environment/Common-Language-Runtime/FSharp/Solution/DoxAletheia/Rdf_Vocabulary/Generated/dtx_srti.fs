namespace http.cef.uv.es.lodroadtran18.def.transporte.dtx_srti.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dtx_srti =
    let _namespace_iri = Namespace_Iri dtx_srti |> NamespaceIRI
    /// <summary>
    ///   <para>dtx_srti:clearanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Clearance work associated with an earlier traffic problem which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearanceWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearanceWork</seealso>
    let clearanceWork = Prefixed_Name(dtx_srti, "clearanceWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:cyclistsOnRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Cyclists on the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cyclistsOnRoadway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cyclistsOnRoadway</seealso>
    let cyclistsOnRoadway = Prefixed_Name(dtx_srti, "cyclistsOnRoadway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>dtx_srti:DisturbanceActivityTypeEnum</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>dtx_srti:SpeedManagementTypeEnum</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>dtx_srti:TpegLoc01AreaLocationSubtypeEnum</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>dtx_srti:LinearElementNatureEnum</para>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>Other. Other than as defined in this enumeration.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#other">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#other</seealso>
    let other = Prefixed_Name(dtx_srti, "other") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:railCrash</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A rail crash adjacent to the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railCrash">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railCrash</seealso>
    let railCrash = Prefixed_Name(dtx_srti, "railCrash") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:unprotectedAccidentArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An accident area which has not been protected and may present a hazard to road users.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unprotectedAccidentArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unprotectedAccidentArea</seealso>
    let unprotectedAccidentArea =
        Prefixed_Name(dtx_srti, "unprotectedAccidentArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:resurfacingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>Work associated with relaying or renewal of worn-out road surface (pavement).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#resurfacingWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#resurfacingWork</seealso>
    let resurfacingWork = Prefixed_Name(dtx_srti, "resurfacingWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:spotterAircraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A spotter aircraft of an organisation specifically assigned to the monitoring of the traffic network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spotterAircraft">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spotterAircraft</seealso>
    let spotterAircraft = Prefixed_Name(dtx_srti, "spotterAircraft") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadsideDrains</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Roadside drains.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideDrains">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideDrains</seealso>
    let roadsideDrains = Prefixed_Name(dtx_srti, "roadsideDrains") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadsideEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Roadside equipment.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEquipment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEquipment</seealso>
    let roadsideEquipment = Prefixed_Name(dtx_srti, "roadsideEquipment") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:waterMain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Water main under or along the highway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterMain">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterMain</seealso>
    let waterMain = Prefixed_Name(dtx_srti, "waterMain") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:internalUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>For internal use only of the recipient organisation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internalUse">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internalUse</seealso>
    let internalUse = Prefixed_Name(dtx_srti, "internalUse") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:noRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No restriction on usage.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noRestriction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noRestriction</seealso>
    let noRestriction = Prefixed_Name(dtx_srti, "noRestriction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:restrictedToAuthoritiesAndTrafficOperators</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Restricted for use only by authorities and traffic operators.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesAndTrafficOperators">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesAndTrafficOperators</seealso>
    let restrictedToAuthoritiesAndTrafficOperators =
        Prefixed_Name(dtx_srti, "restrictedToAuthoritiesAndTrafficOperators") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:restrictedToAuthoritiesTrafficOperatorsAndPublishers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>Restricted for use only by authorities, traffic operators and publishers (service providers).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndPublishers">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndPublishers</seealso>
    let restrictedToAuthoritiesTrafficOperatorsAndPublishers =
        Prefixed_Name(dtx_srti, "restrictedToAuthoritiesTrafficOperatorsAndPublishers") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:connectingCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On the connecting carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#connectingCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#connectingCarriageway</seealso>
    let connectingCarriageway =
        Prefixed_Name(dtx_srti, "connectingCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:cycleTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>Independent road or part of a road designated for cycles, signposted as such. A cycle track is separated from other roads or other parts of the same road by structural means.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleTrack">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleTrack</seealso>
    let cycleTrack = Prefixed_Name(dtx_srti, "cycleTrack") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:flyover</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the flyover, i.e. the section of road passing over another.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flyover">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flyover</seealso>
    let flyover = Prefixed_Name(dtx_srti, "flyover") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:footpath</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the footpath</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footpath">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footpath</seealso>
    let footpath = Prefixed_Name(dtx_srti, "footpath") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:oppositeCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the opposite carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oppositeCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oppositeCarriageway</seealso>
    let oppositeCarriageway =
        Prefixed_Name(dtx_srti, "oppositeCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:parallelCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On the adjacent external parallel carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parallelCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parallelCarriageway</seealso>
    let parallelCarriageway =
        Prefixed_Name(dtx_srti, "parallelCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:serviceRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On the adjacent service road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceRoad</seealso>
    let serviceRoad = Prefixed_Name(dtx_srti, "serviceRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:slipRoads</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the slip roads.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoads">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoads</seealso>
    let slipRoads = Prefixed_Name(dtx_srti, "slipRoads") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bicycle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycle</seealso>
    let bicycle = Prefixed_Name(dtx_srti, "bicycle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bus.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bus">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bus</seealso>
    let bus = Prefixed_Name(dtx_srti, "bus") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:car</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Car.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#car">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#car</seealso>
    let car = Prefixed_Name(dtx_srti, "car") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:carOrLightVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Car or light vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carOrLightVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carOrLightVehicle</seealso>
    let carOrLightVehicle = Prefixed_Name(dtx_srti, "carOrLightVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:longHeavyLorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A heavy lorry that is longer than normal.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longHeavyLorry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longHeavyLorry</seealso>
    let longHeavyLorry = Prefixed_Name(dtx_srti, "longHeavyLorry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Lorry of any type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lorry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lorry</seealso>
    let lorry = Prefixed_Name(dtx_srti, "lorry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:moped</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Moped (a two wheeled motor vehicle characterized by a small engine typically less than 50cc and by normally having pedals).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#moped">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#moped</seealso>
    let moped = Prefixed_Name(dtx_srti, "moped") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:motorcycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Motorcycle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycle</seealso>
    let motorcycle = Prefixed_Name(dtx_srti, "motorcycle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleWithCaravan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Vehicle (of unspecified type) towing a caravan.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCaravan">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCaravan</seealso>
    let vehicleWithCaravan =
        Prefixed_Name(dtx_srti, "vehicleWithCaravan") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleWithCatalyticConverter</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle with catalytic converter.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCatalyticConverter">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithCatalyticConverter</seealso>
    let vehicleWithCatalyticConverter =
        Prefixed_Name(dtx_srti, "vehicleWithCatalyticConverter") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleWithTrailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Vehicle (of unspecified type) towing a trailer.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithTrailer">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithTrailer</seealso>
    let vehicleWithTrailer =
        Prefixed_Name(dtx_srti, "vehicleWithTrailer") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleWithoutCatalyticConverter</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle without catalytic converter.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithoutCatalyticConverter">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithoutCatalyticConverter</seealso>
    let vehicleWithoutCatalyticConverter =
        Prefixed_Name(dtx_srti, "vehicleWithoutCatalyticConverter") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:lau2Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    ///   <para>LAU 2 code</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau2Code">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau2Code</seealso>
    let lau2Code = Prefixed_Name(dtx_srti, "lau2Code") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nuts1Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>NUTS 1 code</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts1Code">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts1Code</seealso>
    let nuts1Code = Prefixed_Name(dtx_srti, "nuts1Code") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nuts2Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    ///   <para>NUTS 2 code</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts2Code">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts2Code</seealso>
    let nuts2Code = Prefixed_Name(dtx_srti, "nuts2Code") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nuts3Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    ///   <para>NUTS 3 code</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts3Code">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nuts3Code</seealso>
    let nuts3Code = Prefixed_Name(dtx_srti, "nuts3Code") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:emergencyServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Emergency services assistance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServices">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServices</seealso>
    let emergencyServices = Prefixed_Name(dtx_srti, "emergencyServices") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:firstAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>First aid assistance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#firstAid">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#firstAid</seealso>
    let firstAid = Prefixed_Name(dtx_srti, "firstAid") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:foodDelivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Food delivery.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#foodDelivery">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#foodDelivery</seealso>
    let foodDelivery = Prefixed_Name(dtx_srti, "foodDelivery") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:helicopterRescue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>Helicopter rescue.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#helicopterRescue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#helicopterRescue</seealso>
    let helicopterRescue = Prefixed_Name(dtx_srti, "helicopterRescue") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:atTollPlaza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>At toll plaza.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTollPlaza">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTollPlaza</seealso>
    let atTollPlaza = Prefixed_Name(dtx_srti, "atTollPlaza") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atTunnelEntryOrExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>At entry or exit of tunnel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTunnelEntryOrExit">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTunnelEntryOrExit</seealso>
    let atTunnelEntryOrExit =
        Prefixed_Name(dtx_srti, "atTunnelEntryOrExit") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>In gallery.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGallery">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGallery</seealso>
    let inGallery = Prefixed_Name(dtx_srti, "inGallery") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>In tunnel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnel">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnel</seealso>
    let inTunnel = Prefixed_Name(dtx_srti, "inTunnel") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onRoundabout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On roundabout.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoundabout">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoundabout</seealso>
    let onRoundabout = Prefixed_Name(dtx_srti, "onRoundabout") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onTheRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRoadway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRoadway</seealso>
    let onTheRoadway = Prefixed_Name(dtx_srti, "onTheRoadway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onUndergroundSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On underground section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSection</seealso>
    let onUndergroundSection =
        Prefixed_Name(dtx_srti, "onUndergroundSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onUnderpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On underpass, i.e. section of road which passes under another road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpass">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpass</seealso>
    let onUnderpass = Prefixed_Name(dtx_srti, "onUnderpass") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:veryLongDelays</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelaysTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Delays on the road network of abnormally unusual severity.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryLongDelays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryLongDelays</seealso>
    let veryLongDelays = Prefixed_Name(dtx_srti, "veryLongDelays") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:avalanches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>The road may be obstructed or partially obstructed due to snow slides.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avalanches">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avalanches</seealso>
    let avalanches = Prefixed_Name(dtx_srti, "avalanches") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fallenTrees</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road is obstructed or partially obstructed by one or more fallen trees.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenTrees">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenTrees</seealso>
    let fallenTrees = Prefixed_Name(dtx_srti, "fallenTrees") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:flooding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>The road is obstructed or partially obstructed by flood water.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flooding">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flooding</seealso>
    let flooding = Prefixed_Name(dtx_srti, "flooding") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:framedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc01FramedPointLocationSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A point on the road network framed by two other points on the same road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#framedPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#framedPoint</seealso>
    let framedPoint = Prefixed_Name(dtx_srti, "framedPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:carPoolLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Dedicated car pool lane(s) are in operation for vehicles carrying at least the specified number of occupants.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLaneInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLaneInOperation</seealso>
    let carPoolLaneInOperation =
        Prefixed_Name(dtx_srti, "carPoolLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:carriagewayClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Carriageway closures are in operation at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayClosures">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayClosures</seealso>
    let carriagewayClosures =
        Prefixed_Name(dtx_srti, "carriagewayClosures") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:clearALaneForEmergencyVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Clear a lane for emergency vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForEmergencyVehicles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForEmergencyVehicles</seealso>
    let clearALaneForEmergencyVehicles =
        Prefixed_Name(dtx_srti, "clearALaneForEmergencyVehicles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:clearALaneForSnowploughsAndGrittingVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Clear a lane for snow ploughs and gritting vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForSnowploughsAndGrittingVehicles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clearALaneForSnowploughsAndGrittingVehicles</seealso>
    let clearALaneForSnowploughsAndGrittingVehicles =
        Prefixed_Name(dtx_srti, "clearALaneForSnowploughsAndGrittingVehicles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hardShoulderRunningInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>The hard shoulder is open as an operational lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulderRunningInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulderRunningInOperation</seealso>
    let hardShoulderRunningInOperation =
        Prefixed_Name(dtx_srti, "hardShoulderRunningInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:heightRestrictionInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A height restriction is in operation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightRestrictionInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightRestrictionInOperation</seealso>
    let heightRestrictionInOperation =
        Prefixed_Name(dtx_srti, "heightRestrictionInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:intermittentShortTermClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Road closures occur intermittently on the specified road in the specified direction for short durations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intermittentShortTermClosures">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intermittentShortTermClosures</seealso>
    let intermittentShortTermClosures =
        Prefixed_Name(dtx_srti, "intermittentShortTermClosures") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:keepToTheLeft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Keep to the left.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheLeft">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheLeft</seealso>
    let keepToTheLeft = Prefixed_Name(dtx_srti, "keepToTheLeft") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:keepToTheRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Keep to the right.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheRight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepToTheRight</seealso>
    let keepToTheRight = Prefixed_Name(dtx_srti, "keepToTheRight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:laneClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneClosures">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneClosures</seealso>
    let laneClosures = Prefixed_Name(dtx_srti, "laneClosures") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lanesDeviated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Lane closures are in operation at the specified location for vehicles with the specified characteristics or all, if none defined, in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesDeviated">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesDeviated</seealso>
    let lanesDeviated = Prefixed_Name(dtx_srti, "lanesDeviated") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:narrowLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Normal lane widths are temporarily reduced.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#narrowLanes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#narrowLanes</seealso>
    let narrowLanes = Prefixed_Name(dtx_srti, "narrowLanes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:turnAroundInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic is being directed back down the opposite carriageway, possibly requiring the temporary removal of the central crash barrier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turnAroundInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turnAroundInOperation</seealso>
    let turnAroundInOperation =
        Prefixed_Name(dtx_srti, "turnAroundInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useOfSpecifiedLanesOrCarriagewaysAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The specified lane(s) or carriageway(s) may be used. The normal lane(s) or carriageway(s) restrictions are not currently in force.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useOfSpecifiedLanesOrCarriagewaysAllowed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useOfSpecifiedLanesOrCarriagewaysAllowed</seealso>
    let useOfSpecifiedLanesOrCarriagewaysAllowed =
        Prefixed_Name(dtx_srti, "useOfSpecifiedLanesOrCarriagewaysAllowed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useSpecifiedLanesOrCarriageways</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use the specified lane(s) or carriageway(s).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSpecifiedLanesOrCarriageways">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSpecifiedLanesOrCarriageways</seealso>
    let useSpecifiedLanesOrCarriageways =
        Prefixed_Name(dtx_srti, "useSpecifiedLanesOrCarriageways") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleStorageInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Vehicles are being stored on the roadway and/or at a rest area or service area at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStorageInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStorageInOperation</seealso>
    let vehicleStorageInOperation =
        Prefixed_Name(dtx_srti, "vehicleStorageInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:weightRestrictionInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>A weight restriction is in operation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weightRestrictionInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weightRestrictionInOperation</seealso>
    let weightRestrictionInOperation =
        Prefixed_Name(dtx_srti, "weightRestrictionInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficBuildingUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficTrendTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic conditions are changing from free-flow to heavy or slow service levels.  Queues may also be expected.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBuildingUp">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBuildingUp</seealso>
    let trafficBuildingUp = Prefixed_Name(dtx_srti, "trafficBuildingUp") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficEasing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TrafficTrendTypeEnum</para>
    ///   <para>Traffic conditions are changing from heavy or slow service levels to free-flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficEasing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficEasing</seealso>
    let trafficEasing = Prefixed_Name(dtx_srti, "trafficEasing") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficStable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TrafficTrendTypeEnum</para>
    ///   <para>Traffic conditions are currently stable.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficStable">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficStable</seealso>
    let trafficStable = Prefixed_Name(dtx_srti, "trafficStable") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadSurfaceInPoorCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road surface is damaged, severely rutted or potholed (i.e. it is in a poor state of repair).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSurfaceInPoorCondition">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSurfaceInPoorCondition</seealso>
    let roadSurfaceInPoorCondition =
        Prefixed_Name(dtx_srti, "roadSurfaceInPoorCondition") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:slipperyRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road surface is slippery due to an unspecified non-weather related cause.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipperyRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipperyRoad</seealso>
    let slipperyRoad = Prefixed_Name(dtx_srti, "slipperyRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:animalsOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AnimalPresenceTypeEmum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic may be disrupted due to animals on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#animalsOnTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#animalsOnTheRoad</seealso>
    let animalsOnTheRoad = Prefixed_Name(dtx_srti, "animalsOnTheRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:herdOfAnimalsOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AnimalPresenceTypeEmum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic may be disrupted due to a herd of animals on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#herdOfAnimalsOnTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#herdOfAnimalsOnTheRoad</seealso>
    let herdOfAnimalsOnTheRoad =
        Prefixed_Name(dtx_srti, "herdOfAnimalsOnTheRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:largeAnimalsOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AnimalPresenceTypeEmum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic may be disrupted due to large animals on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeAnimalsOnTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeAnimalsOnTheRoad</seealso>
    let largeAnimalsOnTheRoad =
        Prefixed_Name(dtx_srti, "largeAnimalsOnTheRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Carriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Carriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Carriageway</seealso>
    let Carriageway = Prefixed_Name(dtx_srti, "Carriageway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of descriptors identifying specific carriageway details.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CarriagewayEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CarriagewayEnum</seealso>
    let CarriagewayEnum = Prefixed_Name(dtx_srti, "CarriagewayEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasCarriagewayEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the section of carriageway to which the location relates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriagewayEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriagewayEnum</seealso>
    let hasCarriagewayEnum =
        Prefixed_Name(dtx_srti, "hasCarriagewayEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SupplementaryPositionalPack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Supplementary positional information</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalPack">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalPack</seealso>
    let SupplementaryPositionalPack =
        Prefixed_Name(dtx_srti, "SupplementaryPositionalPack") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of causes of situations which are not managed or are off network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CauseTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CauseTypeEnum</seealso>
    let CauseTypeEnum = Prefixed_Name(dtx_srti, "CauseTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:CommonClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Common classes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CommonClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#CommonClasses</seealso>
    let CommonClasses = Prefixed_Name(dtx_srti, "CommonClasses") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of computational methods used in deriving data values for data sets.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ComputationMethodEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ComputationMethodEnum</seealso>
    let ComputationMethodEnum =
        Prefixed_Name(dtx_srti, "ComputationMethodEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PayLoadEnumerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadEnumerations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadEnumerations</seealso>
    let PayLoadEnumerations =
        Prefixed_Name(dtx_srti, "PayLoadEnumerations") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLineAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Line attributes are part of a location reference point and consists of functional road class (FRC),form of way (FOW) and bearing (BEAR) data.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineAttributes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineAttributes</seealso>
    let OpenlrLineAttributes =
        Prefixed_Name(dtx_srti, "OpenlrLineAttributes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLineAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Properties of the line towards the topologically adjacent OpenLR location referencing point, on the shortest path to that point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLineAttributes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLineAttributes</seealso>
    let hasOpenlrLineAttributes =
        Prefixed_Name(dtx_srti, "hasOpenlrLineAttributes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrCircleLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The OpenLR method of area definition by providing a center position and a radius</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrCircleLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrCircleLocationReference</seealso>
    let OpenlrCircleLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrCircleLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:openlrRadius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The radius of the corresponding circular area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrRadius">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrRadius</seealso>
    let openlrRadius = Prefixed_Name(dtx_srti, "openlrRadius") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrGeoCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGeoCoordinate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGeoCoordinate</seealso>
    let OpenlrGeoCoordinate =
        Prefixed_Name(dtx_srti, "OpenlrGeoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrGeoCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A geo-coordinate pair is a position in a map defined by its longitude and latitude coordinate values.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrGeoCoordinate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrGeoCoordinate</seealso>
    let hasOpenlrGeoCoordinate =
        Prefixed_Name(dtx_srti, "hasOpenlrGeoCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrClosedLineLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The OpenLR method of area definition by providing a closed path (i.e. a circuit) in the road network.
    /// The boundary always consists of road segments</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrClosedLineLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrClosedLineLocationReference</seealso>
    let OpenlrClosedLineLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrClosedLineLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrEnumerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrEnumerations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrEnumerations</seealso>
    let OpenlrEnumerations =
        Prefixed_Name(dtx_srti, "OpenlrEnumerations") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of form of way</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFormOfWayEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFormOfWayEnum</seealso>
    let OpenlrFormOfWayEnum =
        Prefixed_Name(dtx_srti, "OpenlrFormOfWayEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumuration of functional road class</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFunctionalRoadClassEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrFunctionalRoadClassEnum</seealso>
    let OpenlrFunctionalRoadClassEnum =
        Prefixed_Name(dtx_srti, "OpenlrFunctionalRoadClassEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:openlrNumRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number that the base rectangle should be multiplied in the north direction</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumRows">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumRows</seealso>
    let openlrNumRows = Prefixed_Name(dtx_srti, "openlrNumRows") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:openlrNumColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number that the base rectangle should be multiplied in the east direction</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumColumns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNumColumns</seealso>
    let openlrNumColumns = Prefixed_Name(dtx_srti, "openlrNumColumns") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:OpenlrRectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangle</seealso>
    let OpenlrRectangle = Prefixed_Name(dtx_srti, "OpenlrRectangle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrRectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Area delimited by a rectangle defined by the geodetic co-ordinates of the two ends of its diagonal from south-west to north-east (the rectangle having two sides that are parallel to lines of latitude)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrRectangle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrRectangle</seealso>
    let hasOpenlrRectangle =
        Prefixed_Name(dtx_srti, "hasOpenlrRectangle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLine">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLine</seealso>
    let OpenlrLine = Prefixed_Name(dtx_srti, "OpenlrLine") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:openlrBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the bearing field as an integer value between 0 and 359</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrBearing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrBearing</seealso>
    let openlrBearing = Prefixed_Name(dtx_srti, "openlrBearing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLowestFrcToNextLRPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The lowest FRC to the next point indicates the lowest functional road class used in the location reference path to the next LR-point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowestFrcToNextLRPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowestFrcToNextLRPoint</seealso>
    let hasOpenlrLowestFrcToNextLRPoint =
        Prefixed_Name(dtx_srti, "hasOpenlrLowestFrcToNextLRPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrFormOfWayEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A classification based on the importance of the role that the Road Element (or Ferry Connection) performs in the connectivity of the total road network. (EN ISO 14825 § 7.2.88)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFormOfWayEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFormOfWayEnum</seealso>
    let hasOpenlrFormOfWayEnum =
        Prefixed_Name(dtx_srti, "hasOpenlrFormOfWayEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLineLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A line location reference is defined by an ordered sequence of location reference points and a terminating last location reference point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLineLocationReference</seealso>
    let OpenlrLineLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrLineLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrOppositeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If both direction, this is the reference in the opposite direction against firstDirection.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOppositeDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOppositeDirection</seealso>
    let hasOpenlrOppositeDirection =
        Prefixed_Name(dtx_srti, "hasOpenlrOppositeDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrFirstDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>First OpenLR reference in first/main direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFirstDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrFirstDirection</seealso>
    let hasOpenlrFirstDirection =
        Prefixed_Name(dtx_srti, "hasOpenlrFirstDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPathAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPathAttributes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPathAttributes</seealso>
    let OpenlrPathAttributes =
        Prefixed_Name(dtx_srti, "OpenlrPathAttributes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrPathAttributes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Properties of the path from the associated location reference point to the next location reference point, which are specified to assist correct identification of the point in an external map data source.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPathAttributes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPathAttributes</seealso>
    let hasOpenlrPathAttributes =
        Prefixed_Name(dtx_srti, "hasOpenlrPathAttributes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPoiWithAccessPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point of interest (POI) along a line with access is a point location which is defined by a linear reference path, an offset value (defining the access point) from the starting node of this path and a coordinate pair that defines the POI itself.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPoiWithAccessPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPoiWithAccessPoint</seealso>
    let OpenlrPoiWithAccessPoint =
        Prefixed_Name(dtx_srti, "OpenlrPoiWithAccessPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPointAlongLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Point along a line</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointAlongLine">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointAlongLine</seealso>
    let OpenlrPointAlongLine =
        Prefixed_Name(dtx_srti, "OpenlrPointAlongLine") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPolygonCorners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonCorners">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonCorners</seealso>
    let OpenlrPolygonCorners =
        Prefixed_Name(dtx_srti, "OpenlrPolygonCorners") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPolygonLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The OpenLR method of area definition by providing points that bound the area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPolygonLocationReference</seealso>
    let OpenlrPolygonLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrPolygonLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrPolygonCorners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A geodetic coordinate Tuple that defines the vertices of the underlying geometrical polygon.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPolygonCorners">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPolygonCorners</seealso>
    let hasOpenlrPolygonCorners =
        Prefixed_Name(dtx_srti, "hasOpenlrPolygonCorners") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrUpperRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The upper right corner of the rectangle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrUpperRight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrUpperRight</seealso>
    let hasOpenlrUpperRight =
        Prefixed_Name(dtx_srti, "hasOpenlrUpperRight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLowerLeft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The lower left corner of the rectangle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowerLeft">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLowerLeft</seealso>
    let hasOpenlrLowerLeft =
        Prefixed_Name(dtx_srti, "hasOpenlrLowerLeft") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrRectangleLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The openLR method of area definition by providing a rectangular shape defined by two geo-coordinate pairs</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangleLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrRectangleLocationReference</seealso>
    let OpenlrRectangleLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrRectangleLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any situation record. An identifiable versioned instance of a single record/element within a situation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationRecord">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationRecord</seealso>
    let SituationRecord = Prefixed_Name(dtx_srti, "SituationRecord") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:OverallPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A continuous or discontinuous period of validity defined by overall bounding start and end times and the possible intersection of valid periods (potentially recurring) with the complement of exception periods (also potentially recurring).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OverallPeriod">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OverallPeriod</seealso>
    let OverallPeriod = Prefixed_Name(dtx_srti, "OverallPeriod") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegFramedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A single non-junction point on the road network which is framed between two other specified points on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegFramedPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegFramedPoint</seealso>
    let hasTpegFramedPoint =
        Prefixed_Name(dtx_srti, "hasTpegFramedPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegGeometricArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geometric area defined by a centre point and a radius.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegGeometricArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegGeometricArea</seealso>
    let TpegGeometricArea = Prefixed_Name(dtx_srti, "TpegGeometricArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegAreaDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Name of area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaDescriptor</seealso>
    let hasTpegAreaDescriptor =
        Prefixed_Name(dtx_srti, "hasTpegAreaDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The radius of the corresponding circular area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#radius">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#radius</seealso>
    let radius = Prefixed_Name(dtx_srti, "radius") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasCentrePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Centre point of a circular geometric area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCentrePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCentrePoint</seealso>
    let hasCentrePoint = Prefixed_Name(dtx_srti, "hasCentrePoint") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement of height in metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#height">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#height</seealso>
    let height = Prefixed_Name(dtx_srti, "height") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of height.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc04HeightTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc04HeightTypeEnum</seealso>
    let TpegLoc04HeightTypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc04HeightTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegHeightType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptive identification of relative height using TPEG-Loc location referencing.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegHeightType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegHeightType</seealso>
    let tpegHeightType = Prefixed_Name(dtx_srti, "tpegHeightType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegIlcPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a junction by defining the intersecting roads.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegIlcPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegIlcPointDescriptor</seealso>
    let TpegIlcPointDescriptor =
        Prefixed_Name(dtx_srti, "TpegIlcPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc03IlcPointDescriptorSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptors for describing a junction by identifying the intersecting roads at a road junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03IlcPointDescriptorSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03IlcPointDescriptorSubtypeEnum</seealso>
    let TpegLoc03IlcPointDescriptorSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc03IlcPointDescriptorSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegIlcPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcPointDescriptorType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcPointDescriptorType</seealso>
    let tpegIlcPointDescriptorType =
        Prefixed_Name(dtx_srti, "tpegIlcPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a point location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointDescriptor</seealso>
    let TpegPointDescriptor =
        Prefixed_Name(dtx_srti, "TpegPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is a road junction point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunction</seealso>
    let TpegJunction = Prefixed_Name(dtx_srti, "TpegJunction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegJunctionPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing a point at a junction on a road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunctionPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegJunctionPointDescriptor</seealso>
    let TpegJunctionPointDescriptor =
        Prefixed_Name(dtx_srti, "TpegJunctionPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegJunctionPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A name which identifies a junction point on the road network</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegJunctionPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegJunctionPointDescriptor</seealso>
    let hasTpegJunctionPointDescriptor =
        Prefixed_Name(dtx_srti, "hasTpegJunctionPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegIlcPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptor for describing a junction by identifying the intersecting roads at a road junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegIlcPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegIlcPointDescriptor</seealso>
    let hasTpegIlcPointDescriptor =
        Prefixed_Name(dtx_srti, "hasTpegIlcPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:childrenOnRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>Children on the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#childrenOnRoadway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#childrenOnRoadway</seealso>
    let childrenOnRoadway = Prefixed_Name(dtx_srti, "childrenOnRoadway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:peopleOnRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>People on the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#peopleOnRoadway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#peopleOnRoadway</seealso>
    let peopleOnRoadway = Prefixed_Name(dtx_srti, "peopleOnRoadway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rescueAndRecoveryWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Work is being undertaken by emergency services which may present a hazard to road users.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rescueAndRecoveryWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rescueAndRecoveryWork</seealso>
    let rescueAndRecoveryWork =
        Prefixed_Name(dtx_srti, "rescueAndRecoveryWork") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:urgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dissemination of the information is urgent.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgent</seealso>
    let urgent = Prefixed_Name(dtx_srti, "urgent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:belowTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Height below specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowTPEGHeight</seealso>
    let belowTPEGHeight = Prefixed_Name(dtx_srti, "belowTPEGHeight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:doNoUseStudTyres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>Do not use stud tyres.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNoUseStudTyres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNoUseStudTyres</seealso>
    let doNoUseStudTyres = Prefixed_Name(dtx_srti, "doNoUseStudTyres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:winterEquipmentOnBoardRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The carrying of winter equipment (snow chains and/or snow tyres) is required.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterEquipmentOnBoardRequired">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterEquipmentOnBoardRequired</seealso>
    let winterEquipmentOnBoardRequired =
        Prefixed_Name(dtx_srti, "winterEquipmentOnBoardRequired") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onRoadOrUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrSideOfRoadEnum</para>
    ///   <para>On road or unknown</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoadOrUnknown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onRoadOrUnknown</seealso>
    let onRoadOrUnknown = Prefixed_Name(dtx_srti, "onRoadOrUnknown") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:northEastBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>North east bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northEastBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northEastBound</seealso>
    let northEastBound = Prefixed_Name(dtx_srti, "northEastBound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:outboundFromTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Heading out of or away from the town centre direction of travel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outboundFromTown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outboundFromTown</seealso>
    let outboundFromTown = Prefixed_Name(dtx_srti, "outboundFromTown") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:openlrPositiveOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The positive offset along the line of the location measured along the line reference path between the start point of the location reference and the starting node of the line reference path.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrPositiveOffset">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrPositiveOffset</seealso>
    let openlrPositiveOffset =
        Prefixed_Name(dtx_srti, "openlrPositiveOffset") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:incident</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Incidents are chance occurrences involving vehicles from the traffic stream, which could present potential hazards to road users.  This item excludes accidents.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#incident">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#incident</seealso>
    let incident = Prefixed_Name(dtx_srti, "incident") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:spillageOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Includes all situations where a spillage has occurred on the roadway due to an earlier incident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spillageOnTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spillageOnTheRoad</seealso>
    let spillageOnTheRoad = Prefixed_Name(dtx_srti, "spillageOnTheRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:repairWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Repair work to road, associated infrastructure or equipments.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#repairWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#repairWork</seealso>
    let repairWork = Prefixed_Name(dtx_srti, "repairWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:snowploughsInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Snowploughs or other similar mechanical devices in use to clear snow from the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowploughsInUse">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowploughsInUse</seealso>
    let snowploughsInUse = Prefixed_Name(dtx_srti, "snowploughsInUse") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:leaveYourVehicleProceedToNextSafePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Leave your vehicle proceed to next safe place</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leaveYourVehicleProceedToNextSafePlace">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leaveYourVehicleProceedToNextSafePlace</seealso>
    let leaveYourVehicleProceedToNextSafePlace =
        Prefixed_Name(dtx_srti, "leaveYourVehicleProceedToNextSafePlace") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:noStopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>No stopping.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noStopping">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noStopping</seealso>
    let noStopping = Prefixed_Name(dtx_srti, "noStopping") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:observeSignals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Observe signals.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSignals">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSignals</seealso>
    let observeSignals = Prefixed_Name(dtx_srti, "observeSignals") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:stopAtNextSafePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Stop at next safe place.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextSafePlace">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextSafePlace</seealso>
    let stopAtNextSafePlace =
        Prefixed_Name(dtx_srti, "stopAtNextSafePlace") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useHazardWarningLights</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use hazard warning lights.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHazardWarningLights">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHazardWarningLights</seealso>
    let useHazardWarningLights =
        Prefixed_Name(dtx_srti, "useHazardWarningLights") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useTramService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use tram service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useTramService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useTramService</seealso>
    let useTramService = Prefixed_Name(dtx_srti, "useTramService") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onTheRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RelativePositionOnCarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the right of the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheRight</seealso>
    let onTheRight = Prefixed_Name(dtx_srti, "onTheRight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:bridgeSwingInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The bridge at the specified location has swung or lifted and is therefore temporarily closed to traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridgeSwingInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridgeSwingInOperation</seealso>
    let bridgeSwingInOperation =
        Prefixed_Name(dtx_srti, "bridgeSwingInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:convoyService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>A convoy service is in operation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoyService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoyService</seealso>
    let convoyService = Prefixed_Name(dtx_srti, "convoyService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:obstacleSignalling</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Signs are being put out before or around an obstacle to protect drivers.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstacleSignalling">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstacleSignalling</seealso>
    let obstacleSignalling =
        Prefixed_Name(dtx_srti, "obstacleSignalling") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tollGatesOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>Toll gates are open with no fee collection at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGatesOpen">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGatesOpen</seealso>
    let tollGatesOpen = Prefixed_Name(dtx_srti, "tollGatesOpen") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficBeingManuallyDirected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>Traffic is being manually directed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBeingManuallyDirected">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBeingManuallyDirected</seealso>
    let trafficBeingManuallyDirected =
        Prefixed_Name(dtx_srti, "trafficBeingManuallyDirected") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:longerThanSixHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>Delay longer than six hours.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longerThanSixHours">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longerThanSixHours</seealso>
    let longerThanSixHours =
        Prefixed_Name(dtx_srti, "longerThanSixHours") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:negligible</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Negligible delay.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negligible">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negligible</seealso>
    let negligible = Prefixed_Name(dtx_srti, "negligible") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:largeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc01AreaLocationSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A geographic or geometric large area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#largeArea</seealso>
    let largeArea = Prefixed_Name(dtx_srti, "largeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:originalNumberOfLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Normal number of lanes, potentially available for moving traffic, before reduction due to situations. Hard shoulder should not be counted unless it is sometimes used operationally for moving traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#originalNumberOfLanes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#originalNumberOfLanes</seealso>
    let originalNumberOfLanes =
        Prefixed_Name(dtx_srti, "originalNumberOfLanes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:urgentRoadworks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether the roadworks are considered to be urgent whereby emergency work is being, or needs to be, undertaken to mitigate safety concerns. 'True' indicates they are urgent.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgentRoadworks">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urgentRoadworks</seealso>
    let urgentRoadworks = Prefixed_Name(dtx_srti, "urgentRoadworks") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:publicTransportAlternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes an available public transport alternative to the normal route</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportAlternative">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportAlternative</seealso>
    let publicTransportAlternative =
        Prefixed_Name(dtx_srti, "publicTransportAlternative") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadsideAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of road side assistance required or being given.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistance</seealso>
    let RoadsideAssistance =
        Prefixed_Name(dtx_srti, "RoadsideAssistance") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPublicEventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies types of public events.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPublicEventType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPublicEventType</seealso>
    let hasPublicEventType =
        Prefixed_Name(dtx_srti, "hasPublicEventType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:shedLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>Spillage of transported goods on the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shedLoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shedLoad</seealso>
    let shedLoad = Prefixed_Name(dtx_srti, "shedLoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:maintenanceWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Maintenance of road, associated infrastructure or equipments.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceWork</seealso>
    let maintenanceWork = Prefixed_Name(dtx_srti, "maintenanceWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadMarkingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    ///   <para>Striping and repainting of road markings, plus placement or replacement of reflecting studs (cats' eyes).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadMarkingWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadMarkingWork</seealso>
    let roadMarkingWork = Prefixed_Name(dtx_srti, "roadMarkingWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#region">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#region</seealso>
    let region = Prefixed_Name(dtx_srti, "region") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:unitaryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Unitary Authority</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unitaryAuthority">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unitaryAuthority</seealso>
    let unitaryAuthority = Prefixed_Name(dtx_srti, "unitaryAuthority") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:anyVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle of any type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyVehicle</seealso>
    let anyVehicle = Prefixed_Name(dtx_srti, "anyVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:carWithCaravan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Car towing a caravan.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithCaravan">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithCaravan</seealso>
    let carWithCaravan = Prefixed_Name(dtx_srti, "carWithCaravan") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fourWheelDrive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Four wheel drive vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fourWheelDrive">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fourWheelDrive</seealso>
    let fourWheelDrive = Prefixed_Name(dtx_srti, "fourWheelDrive") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod4Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road between two points, primary and secondary, which are pre-defined ALERT-C locations plus offset distance. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Linear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Linear</seealso>
    let AlertCMethod4Linear =
        Prefixed_Name(dtx_srti, "AlertCMethod4Linear") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod4PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4PrimaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4PrimaryPointLocation</seealso>
    let AlertCMethod4PrimaryPointLocation =
        Prefixed_Name(dtx_srti, "AlertCMethod4PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCMethod4PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ALERT-C method4 primary point location</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4PrimaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4PrimaryPointLocation</seealso>
    let hasAlertCMethod4PrimaryPointLocation =
        Prefixed_Name(dtx_srti, "hasAlertCMethod4PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasInformationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The status of the related information (real, test, exercise ....).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInformationStatus">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInformationStatus</seealso>
    let hasInformationStatus =
        Prefixed_Name(dtx_srti, "hasInformationStatus") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasConfidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConfidentiality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConfidentiality</seealso>
    let hasConfidentiality =
        Prefixed_Name(dtx_srti, "hasConfidentiality") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:HeightCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Third coordinate for points defined geodetically</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinate</seealso>
    let HeightCoordinate = Prefixed_Name(dtx_srti, "HeightCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:alertCLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of ALERT-C location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationName</seealso>
    let alertCLocationName =
        Prefixed_Name(dtx_srti, "alertCLocationName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ellipsoidalHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Value measured vertically above the reference ellipsoid</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ellipsoidalHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ellipsoidalHeight</seealso>
    let ellipsoidalHeight = Prefixed_Name(dtx_srti, "ellipsoidalHeight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:cameraObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A camera observation (either still or video camera).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cameraObservation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cameraObservation</seealso>
    let cameraObservation = Prefixed_Name(dtx_srti, "cameraObservation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:northBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>North bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northBound</seealso>
    let northBound = Prefixed_Name(dtx_srti, "northBound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:outerRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>Outer ring direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outerRing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outerRing</seealso>
    let outerRing = Prefixed_Name(dtx_srti, "outerRing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:openlrNegativeOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The negative offset along the line of the location measured along the line reference path between the end point of the location reference and the ending node of the line reference path.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNegativeOffset">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrNegativeOffset</seealso>
    let openlrNegativeOffset =
        Prefixed_Name(dtx_srti, "openlrNegativeOffset") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:openlrDistanceToNextLRPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The DNP attribute measures the distance in meters between two consecutive location reference-points along the location reference path described in the corresponding enumeration</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrDistanceToNextLRPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#openlrDistanceToNextLRPoint</seealso>
    let openlrDistanceToNextLRPoint =
        Prefixed_Name(dtx_srti, "openlrDistanceToNextLRPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegPointFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location at the up stream end of the linear section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointFrom">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointFrom</seealso>
    let hasTpegPointFrom = Prefixed_Name(dtx_srti, "hasTpegPointFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegNonJunctionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is not a road junction point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNonJunctionPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNonJunctionPoint</seealso>
    let TpegNonJunctionPoint =
        Prefixed_Name(dtx_srti, "TpegNonJunctionPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inRuralAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>In rural areas, i.e. outside villages, towns and cities</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inRuralAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inRuralAreas</seealso>
    let inRuralAreas = Prefixed_Name(dtx_srti, "inRuralAreas") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onBridges</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On bridges</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridges">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridges</seealso>
    let onBridges = Prefixed_Name(dtx_srti, "onBridges") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onUndergroundSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>On underground sections of the road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSections">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUndergroundSections</seealso>
    let onUndergroundSections =
        Prefixed_Name(dtx_srti, "onUndergroundSections") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:seaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>Name of a sea.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#seaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#seaName</seealso>
    let seaName = Prefixed_Name(dtx_srti, "seaName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:townName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>Name of a town.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#townName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#townName</seealso>
    let townName = Prefixed_Name(dtx_srti, "townName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:relativeHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Height type corresponding to value masured vertically above the ground level at this point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#relativeHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#relativeHeight</seealso>
    let relativeHeight = Prefixed_Name(dtx_srti, "relativeHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:freightVehicleOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>An operator of freight vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#freightVehicleOperator">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#freightVehicleOperator</seealso>
    let freightVehicleOperator =
        Prefixed_Name(dtx_srti, "freightVehicleOperator") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:longLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>A vehicle of length greater than that normally allowed which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longLoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longLoad</seealso>
    let longLoad = Prefixed_Name(dtx_srti, "longLoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:carriagewayBlocked</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The carriageway is totally obstructed in the specified direction due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayBlocked">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayBlocked</seealso>
    let carriagewayBlocked =
        Prefixed_Name(dtx_srti, "carriagewayBlocked") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:lanesPartiallyObstructed</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>One or more lanes is partially obstructed in the specified direction due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesPartiallyObstructed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesPartiallyObstructed</seealso>
    let lanesPartiallyObstructed =
        Prefixed_Name(dtx_srti, "lanesPartiallyObstructed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:harmonicAverageOfSamplesInATimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    ///   <para>Harmonic average of sample values in a time period.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#harmonicAverageOfSamplesInATimePeriod">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#harmonicAverageOfSamplesInATimePeriod</seealso>
    let harmonicAverageOfSamplesInATimePeriod =
        Prefixed_Name(dtx_srti, "harmonicAverageOfSamplesInATimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:brokenDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>Broken down vehicle (i.e. it is immobile due to mechanical breakdown).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDown</seealso>
    let brokenDown = Prefixed_Name(dtx_srti, "brokenDown") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:burntOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Burnt out vehicle, but fire is extinguished.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burntOut">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burntOut</seealso>
    let burntOut = Prefixed_Name(dtx_srti, "burntOut") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:spunAround</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>Vehicle has come to rest not facing its intended line of travel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spunAround">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#spunAround</seealso>
    let spunAround = Prefixed_Name(dtx_srti, "spunAround") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:burstWaterMain</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic may be disrupted due to local flooding and/or subsidence because of a broken water main.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstWaterMain">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstWaterMain</seealso>
    let burstWaterMain = Prefixed_Name(dtx_srti, "burstWaterMain") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:collapsedSewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>The road surface has sunken or collapsed in places due to sewer failure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collapsedSewer">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collapsedSewer</seealso>
    let collapsedSewer = Prefixed_Name(dtx_srti, "collapsedSewer") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fallenPowerCables</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road is obstructed or partially obstructed by one or more fallen power cables.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenPowerCables">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fallenPowerCables</seealso>
    let fallenPowerCables = Prefixed_Name(dtx_srti, "fallenPowerCables") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gasLeak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>Traffic may be disrupted due to an explosion hazard from gas escaping in or near the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasLeak">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasLeak</seealso>
    let gasLeak = Prefixed_Name(dtx_srti, "gasLeak") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:congestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>Traffic congestion.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#congestion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#congestion</seealso>
    let congestion = Prefixed_Name(dtx_srti, "congestion") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:equipmentFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Equipment  which is faulty, malfunctioning or not in a fully operational state that may be of interest or concern to road operators and road users.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equipmentFailure">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equipmentFailure</seealso>
    let equipmentFailure = Prefixed_Name(dtx_srti, "equipmentFailure") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:poorWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Poor weather conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorWeather">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorWeather</seealso>
    let poorWeather = Prefixed_Name(dtx_srti, "poorWeather") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:problemsAtBorderPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Problems at the border crossing.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtBorderPost">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtBorderPost</seealso>
    let problemsAtBorderPost =
        Prefixed_Name(dtx_srti, "problemsAtBorderPost") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:securityIncident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>A security incident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityIncident">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityIncident</seealso>
    let securityIncident = Prefixed_Name(dtx_srti, "securityIncident") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:terrorism</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A terrorist incident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#terrorism">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#terrorism</seealso>
    let terrorism = Prefixed_Name(dtx_srti, "terrorism") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Mobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Mobility">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Mobility</seealso>
    let Mobility = Prefixed_Name(dtx_srti, "Mobility") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasMobilityOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the mobility of activity</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfActivity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfActivity</seealso>
    let hasMobilityOfActivity =
        Prefixed_Name(dtx_srti, "hasMobilityOfActivity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:alertCLocationTableVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version number associated with an ALERT-C table reference.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableVersion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableVersion</seealso>
    let alertCLocationTableVersion =
        Prefixed_Name(dtx_srti, "alertCLocationTableVersion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identification of a specific point, linear or area location in an ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLocation</seealso>
    let AlertCLocation = Prefixed_Name(dtx_srti, "AlertCLocation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasAlertCLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identification of a specific point, linear or area location in an ALERT-C location table.</para>
    ///   <para>ALERT-C location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLocation</seealso>
    let hasAlertCLocation = Prefixed_Name(dtx_srti, "hasAlertCLocation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AlertCDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The direction of traffic flow along the road to which the information relates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirection</seealso>
    let AlertCDirection = Prefixed_Name(dtx_srti, "AlertCDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Categories of person.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PersonCategoryEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PersonCategoryEnum</seealso>
    let PersonCategoryEnum =
        Prefixed_Name(dtx_srti, "PersonCategoryEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficManuallyDirectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of person that is manually directing traffic (applicable if generalNetworkManagementType is set to "trafficBeingManuallyDirected").</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficManuallyDirectedBy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficManuallyDirectedBy</seealso>
    let trafficManuallyDirectedBy =
        Prefixed_Name(dtx_srti, "trafficManuallyDirectedBy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of network management actions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagementTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagementTypeEnum</seealso>
    let GeneralNetworkManagementTypeEnum =
        Prefixed_Name(dtx_srti, "GeneralNetworkManagementTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGeneralNetworkManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of traffic management action instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralNetworkManagementType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralNetworkManagementType</seealso>
    let hasGeneralNetworkManagementType =
        Prefixed_Name(dtx_srti, "hasGeneralNetworkManagementType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:gravityRelatedHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Height type corresponding a value measured along direction of gravity above the reference geoid i.e. equipotential surface of the Earth's gravity field which globally approximates mean sea level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gravityRelatedHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gravityRelatedHeight</seealso>
    let gravityRelatedHeight =
        Prefixed_Name(dtx_srti, "gravityRelatedHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:extremelyUrgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dissemination of the information is extremely urgent.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremelyUrgent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremelyUrgent</seealso>
    let extremelyUrgent = Prefixed_Name(dtx_srti, "extremelyUrgent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ruralCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rural county</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ruralCounty">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ruralCounty</seealso>
    let ruralCounty = Prefixed_Name(dtx_srti, "ruralCounty") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:RoadWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Highway maintenance, installation and construction activities that may potentially affect traffic operations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadWorks">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadWorks</seealso>
    let RoadWorks = Prefixed_Name(dtx_srti, "RoadWorks") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:DataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A data value of something that can be measured or calculated. Any provided meta-data values specified in the attributes override any specified generic characteristics such as defined for a specific measurement in the MeasurementSiteTable.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DataValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DataValue</seealso>
    let DataValue = Prefixed_Name(dtx_srti, "DataValue") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:SpeedManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Speed management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagement</seealso>
    let SpeedManagement = Prefixed_Name(dtx_srti, "SpeedManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SpeedManagementTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Management actions relating to speed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagementTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedManagementTypeEnum</seealso>
    let SpeedManagementTypeEnum =
        Prefixed_Name(dtx_srti, "SpeedManagementTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:skosDataProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosDataProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosDataProperties</seealso>
    let skosDataProperties =
        Prefixed_Name(dtx_srti, "skosDataProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:skosObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only for organizational purposes. Skos object properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosObjectProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#skosObjectProperties</seealso>
    let skosObjectProperties =
        Prefixed_Name(dtx_srti, "skosObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:normalUrgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dissemination of the information is of normal urgency.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normalUrgency">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normalUrgency</seealso>
    let normalUrgency = Prefixed_Name(dtx_srti, "normalUrgency") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inductionLoopMonitoringStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A station dedicated to the monitoring of the road network by processing inductive loop information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inductionLoopMonitoringStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inductionLoopMonitoringStation</seealso>
    let inductionLoopMonitoringStation =
        Prefixed_Name(dtx_srti, "inductionLoopMonitoringStation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:mobileTelephoneCaller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A caller using a mobile telephone (who may or may not be on the road network).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobileTelephoneCaller">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobileTelephoneCaller</seealso>
    let mobileTelephoneCaller =
        Prefixed_Name(dtx_srti, "mobileTelephoneCaller") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:temporarySpeedLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Temporary limit defining the maximum advisory or mandatory speed of vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporarySpeedLimit">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporarySpeedLimit</seealso>
    let temporarySpeedLimit =
        Prefixed_Name(dtx_srti, "temporarySpeedLimit") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSpeedManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of speed management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSpeedManagementType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSpeedManagementType</seealso>
    let hasSpeedManagementType =
        Prefixed_Name(dtx_srti, "hasSpeedManagementType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:automobileClubPatrol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A patrol of an automobile club.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#automobileClubPatrol">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#automobileClubPatrol</seealso>
    let automobileClubPatrol =
        Prefixed_Name(dtx_srti, "automobileClubPatrol") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:infraredMonitoringStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A station dedicated to the monitoring of the road network by processing infrared image information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infraredMonitoringStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infraredMonitoringStation</seealso>
    let infraredMonitoringStation =
        Prefixed_Name(dtx_srti, "infraredMonitoringStation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damaged</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle is damaged following an incident or collision. It may be able or not to move by itself.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damaged">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damaged</seealso>
    let damaged = Prefixed_Name(dtx_srti, "damaged") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:multipleVehicleAccident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    ///   <para>Includes all accidents involving three or more vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleVehicleAccident">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleVehicleAccident</seealso>
    let multipleVehicleAccident =
        Prefixed_Name(dtx_srti, "multipleVehicleAccident") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accidentCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A descriptor indicating the most significant factor causing an accident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentCause">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentCause</seealso>
    let accidentCause = Prefixed_Name(dtx_srti, "accidentCause") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:infrastructureFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>Failure of road infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infrastructureFailure">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infrastructureFailure</seealso>
    let infrastructureFailure =
        Prefixed_Name(dtx_srti, "infrastructureFailure") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:obstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>Obstruction (of unspecified type) on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#obstruction</seealso>
    let obstruction = Prefixed_Name(dtx_srti, "obstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:problemsAtCustomPost</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Problems at the customs post on the border.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtCustomPost">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsAtCustomPost</seealso>
    let problemsAtCustomPost =
        Prefixed_Name(dtx_srti, "problemsAtCustomPost") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadsideEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>A roadside event (of unspecified nature) whether planned or not.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEvent</seealso>
    let roadsideEvent = Prefixed_Name(dtx_srti, "roadsideEvent") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasEnvironmentalObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Characterization of an obstruction on the road resulting from an environmental cause.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasEnvironmentalObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasEnvironmentalObstructionTypeEnum</seealso>
    let hasEnvironmentalObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "hasEnvironmentalObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:bearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Accuracy defined by the 95th percentile of the cumulative distribution of position errors</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bearing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bearing</seealso>
    let bearing = Prefixed_Name(dtx_srti, "bearing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointCoordinatesAssociationsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsTo">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsTo</seealso>
    let PointCoordinatesAssociationsTo =
        Prefixed_Name(dtx_srti, "PointCoordinatesAssociationsTo") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:microwaveMonitoringStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A station dedicated to the monitoring of the road network by processing microwave information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#microwaveMonitoringStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#microwaveMonitoringStation</seealso>
    let microwaveMonitoringStation =
        Prefixed_Name(dtx_srti, "microwaveMonitoringStation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:nonPoliceEmergencyServicePatrol</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Emergency service patrols other than police.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonPoliceEmergencyServicePatrol">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonPoliceEmergencyServicePatrol</seealso>
    let nonPoliceEmergencyServicePatrol =
        Prefixed_Name(dtx_srti, "nonPoliceEmergencyServicePatrol") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:privateBreakdownService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A private breakdown service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#privateBreakdownService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#privateBreakdownService</seealso>
    let privateBreakdownService =
        Prefixed_Name(dtx_srti, "privateBreakdownService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:publicAndPrivateUtilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A utility organisation, either public or private.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicAndPrivateUtilities">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicAndPrivateUtilities</seealso>
    let publicAndPrivateUtilities =
        Prefixed_Name(dtx_srti, "publicAndPrivateUtilities") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:problemsOnLocalRoads</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Problems (of an unspecified nature) on the local roads.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsOnLocalRoads">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#problemsOnLocalRoads</seealso>
    let problemsOnLocalRoads =
        Prefixed_Name(dtx_srti, "problemsOnLocalRoads") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of information relating to human activities external to the traffic stream or roadway which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Activity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Activity</seealso>
    let Activity = Prefixed_Name(dtx_srti, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AlertC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Alert C location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertC">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertC</seealso>
    let AlertC = Prefixed_Name(dtx_srti, "AlertC") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:LocationObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationObjects">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationObjects</seealso>
    let LocationObjects = Prefixed_Name(dtx_srti, "LocationObjects") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AlertCArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by reference to a predefined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCArea</seealso>
    let AlertCArea = Prefixed_Name(dtx_srti, "AlertCArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:alertCLocationTableNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number allocated to an ALERT-C table in a country. Ref. EN ISO 14819-3 for the allocation of a location table number.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableNumber">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationTableNumber</seealso>
    let alertCLocationTableNumber =
        Prefixed_Name(dtx_srti, "alertCLocationTableNumber") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:alertCLocationCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ALERT-C country code as defined in IEC 62106.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationCountryCode">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCLocationCountryCode</seealso>
    let alertCLocationCountryCode =
        Prefixed_Name(dtx_srti, "alertCLocationCountryCode") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accuracyPercentile95</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Accuracy defined by the 95th percentile of the cumulative distribution of position errors</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile95">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile95</seealso>
    let accuracyPercentile95 =
        Prefixed_Name(dtx_srti, "accuracyPercentile95") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:semiMajorAxisOrientationError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the ellipse orientation is unavailable (True) or not (False)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientationError">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientationError</seealso>
    let semiMajorAxisOrientationError =
        Prefixed_Name(dtx_srti, "semiMajorAxisOrientationError") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:semiMinorAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Half of length of the minor axis, i.e. distance between the centre point and minor axis point of the position accuracy ellipse</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMinorAxisLength">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMinorAxisLength</seealso>
    let semiMinorAxisLength =
        Prefixed_Name(dtx_srti, "semiMinorAxisLength") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:semiMajorAxisOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Orientation direction of the ellipse major axis of the position accuracy ellipse with regards to the geographic north.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisOrientation</seealso>
    let semiMajorAxisOrientation =
        Prefixed_Name(dtx_srti, "semiMajorAxisOrientation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:semiMajorAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Half of length of the major axis, i.e. distance between the centre point and major axis point of the position accuracy ellipse.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisLength">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#semiMajorAxisLength</seealso>
    let semiMajorAxisLength =
        Prefixed_Name(dtx_srti, "semiMajorAxisLength") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PublicEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Public event</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEvent</seealso>
    let PublicEvent = Prefixed_Name(dtx_srti, "PublicEvent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:venueName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the venue at which the public event is being held</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#venueName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#venueName</seealso>
    let venueName = Prefixed_Name(dtx_srti, "venueName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of public events.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEventTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PublicEventTypeEnum</seealso>
    let PublicEventTypeEnum =
        Prefixed_Name(dtx_srti, "PublicEventTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:otherOfficialVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Personnel from a vehicle belonging to the road operator or authority or any emergency service, including authorised breakdown service organisations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#otherOfficialVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#otherOfficialVehicle</seealso>
    let otherOfficialVehicle =
        Prefixed_Name(dtx_srti, "otherOfficialVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadOperatorPatrol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A patrol of the road operator or authority.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorPatrol">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorPatrol</seealso>
    let roadOperatorPatrol =
        Prefixed_Name(dtx_srti, "roadOperatorPatrol") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleProbeMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A specially equipped vehicle used to provide measurements.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleProbeMeasurement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleProbeMeasurement</seealso>
    let vehicleProbeMeasurement =
        Prefixed_Name(dtx_srti, "vehicleProbeMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:noOrientationOrUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrOrientationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No orientation or unknown</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOrientationOrUnknown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOrientationOrUnknown</seealso>
    let noOrientationOrUnknown =
        Prefixed_Name(dtx_srti, "noOrientationOrUnknown") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:allowEmergencyVehiclesToPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Allow emergency vehicles to pass</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowEmergencyVehiclesToPass">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowEmergencyVehiclesToPass</seealso>
    let allowEmergencyVehiclesToPass =
        Prefixed_Name(dtx_srti, "allowEmergencyVehiclesToPass") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:closeAllWindowsTurnOffHeaterAndVents</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Close all windows turn off heater and vents</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closeAllWindowsTurnOffHeaterAndVents">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closeAllWindowsTurnOffHeaterAndVents</seealso>
    let closeAllWindowsTurnOffHeaterAndVents =
        Prefixed_Name(dtx_srti, "closeAllWindowsTurnOffHeaterAndVents") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotLeaveYourVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Do not leave your vehicle</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotLeaveYourVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotLeaveYourVehicle</seealso>
    let doNotLeaveYourVehicle =
        Prefixed_Name(dtx_srti, "doNotLeaveYourVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:driveCarefully</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Drive carefully.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveCarefully">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveCarefully</seealso>
    let driveCarefully = Prefixed_Name(dtx_srti, "driveCarefully") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:majorEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Significant organised event either on or near the roadway which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#majorEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#majorEvent</seealso>
    let majorEvent = Prefixed_Name(dtx_srti, "majorEvent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:rugbyMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rugby match that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rugbyMatch">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rugbyMatch</seealso>
    let rugbyMatch = Prefixed_Name(dtx_srti, "rugbyMatch") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:winterSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Winter sports meeting or event (e.g. skiing, ski jumping, skating) that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterSportsMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterSportsMeeting</seealso>
    let winterSportsMeeting =
        Prefixed_Name(dtx_srti, "winterSportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:heavyTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic is heavy at the specified location (i.e. average speed is between 75% and 90% of its free-flow level).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyTraffic</seealso>
    let heavyTraffic = Prefixed_Name(dtx_srti, "heavyTraffic") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:outOfRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PositionConfidenceCodedErrorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates the accuracy is out of range, i.e. greater than 4 093 cm for horizontal position.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outOfRange">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outOfRange</seealso>
    let outOfRange = Prefixed_Name(dtx_srti, "outOfRange") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:residualLaneWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The width of lanes after any lane narrowing</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualLaneWidth">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualLaneWidth</seealso>
    let residualLaneWidth = Prefixed_Name(dtx_srti, "residualLaneWidth") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasDelays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDelays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDelays</seealso>
    let hasDelays = Prefixed_Name(dtx_srti, "hasDelays") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:registeredMotoristObserver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>A motorist who is an officially registered observer.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#registeredMotoristObserver">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#registeredMotoristObserver</seealso>
    let registeredMotoristObserver =
        Prefixed_Name(dtx_srti, "registeredMotoristObserver") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:transitOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>An operator of a transit service, e.g. bus link operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#transitOperator">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#transitOperator</seealso>
    let transitOperator = Prefixed_Name(dtx_srti, "transitOperator") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:entrySlipRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the entry slip road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entrySlipRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entrySlipRoad</seealso>
    let entrySlipRoad = Prefixed_Name(dtx_srti, "entrySlipRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:leftHandFeederRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the left hand feeder road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandFeederRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandFeederRoad</seealso>
    let leftHandFeederRoad =
        Prefixed_Name(dtx_srti, "leftHandFeederRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:mainCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the main carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mainCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mainCarriageway</seealso>
    let mainCarriageway = Prefixed_Name(dtx_srti, "mainCarriageway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:underpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On the underpass, i.e. the section of road passing under another.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underpass">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underpass</seealso>
    let underpass = Prefixed_Name(dtx_srti, "underpass") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:articulatedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Articulated vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#articulatedVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#articulatedVehicle</seealso>
    let articulatedVehicle =
        Prefixed_Name(dtx_srti, "articulatedVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:carWithTrailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Car towing a trailer.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithTrailer">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carWithTrailer</seealso>
    let carWithTrailer = Prefixed_Name(dtx_srti, "carWithTrailer") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:highSidedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>High sided vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highSidedVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highSidedVehicle</seealso>
    let highSidedVehicle = Prefixed_Name(dtx_srti, "highSidedVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tanker</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle with large tank for carrying bulk liquids.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tanker">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tanker</seealso>
    let tanker = Prefixed_Name(dtx_srti, "tanker") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:twoWheeledVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Two wheeled vehicle of unspecified type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoWheeledVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoWheeledVehicle</seealso>
    let twoWheeledVehicle = Prefixed_Name(dtx_srti, "twoWheeledVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:van</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Van.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#van">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#van</seealso>
    let van = Prefixed_Name(dtx_srti, "van") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:withOddNumberedRegistrationPlates</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle with odd numbered registration plate.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withOddNumberedRegistrationPlates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withOddNumberedRegistrationPlates</seealso>
    let withOddNumberedRegistrationPlates =
        Prefixed_Name(dtx_srti, "withOddNumberedRegistrationPlates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:airAmbulance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>Air ambulance assistance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airAmbulance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airAmbulance</seealso>
    let airAmbulance = Prefixed_Name(dtx_srti, "airAmbulance") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vehicleRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>Vehicle repair assistance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRepair">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRepair</seealso>
    let vehicleRepair = Prefixed_Name(dtx_srti, "vehicleRepair") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:atRestArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>At rest area off the carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atRestArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atRestArea</seealso>
    let atRestArea = Prefixed_Name(dtx_srti, "atRestArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:atServiceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>At service area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atServiceArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atServiceArea</seealso>
    let atServiceArea = Prefixed_Name(dtx_srti, "atServiceArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On bridge</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridge">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBridge</seealso>
    let onBridge = Prefixed_Name(dtx_srti, "onBridge") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On connecting carriageway between two different roads or road sections.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onConnector">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onConnector</seealso>
    let onConnector = Prefixed_Name(dtx_srti, "onConnector") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onFlyover</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On flyover, i.e. on section of road over another road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyover">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyover</seealso>
    let onFlyover = Prefixed_Name(dtx_srti, "onFlyover") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onIceRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On ice road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onIceRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onIceRoad</seealso>
    let onIceRoad = Prefixed_Name(dtx_srti, "onIceRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onLevelCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On level-crossing.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLevelCrossing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLevelCrossing</seealso>
    let onLevelCrossing = Prefixed_Name(dtx_srti, "onLevelCrossing") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onLinkRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On road section linking two different roads.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLinkRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onLinkRoad</seealso>
    let onLinkRoad = Prefixed_Name(dtx_srti, "onLinkRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:unavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PositionConfidenceCodedErrorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates the accuracy information is unavailable.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unavailable">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unavailable</seealso>
    let unavailable = Prefixed_Name(dtx_srti, "unavailable") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:delays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DelaysTypeEnum</para>
    ///   <para>Delays on the road network as a result of any situation which causes hold-ups.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delays</seealso>
    let delays = Prefixed_Name(dtx_srti, "delays") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:delaysOfUncertainDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DelaysTypeEnum</para>
    ///   <para>Delays on the road network whose predicted duration cannot be estimated.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysOfUncertainDuration">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysOfUncertainDuration</seealso>
    let delaysOfUncertainDuration =
        Prefixed_Name(dtx_srti, "delaysOfUncertainDuration") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:landslips</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>The road may be obstructed or partially obstructed due to landslides.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landslips">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landslips</seealso>
    let landslips = Prefixed_Name(dtx_srti, "landslips") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:rockfalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>The road may be obstructed or partially obstructed due to fallen rocks.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rockfalls">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rockfalls</seealso>
    let rockfalls = Prefixed_Name(dtx_srti, "rockfalls") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:subsidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road surface has sunken or collapsed in places.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#subsidence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#subsidence</seealso>
    let subsidence = Prefixed_Name(dtx_srti, "subsidence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:newRoadworksLayout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>A new layout of lanes/carriageway has been implemented associated with roadworks.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#newRoadworksLayout">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#newRoadworksLayout</seealso>
    let newRoadworksLayout =
        Prefixed_Name(dtx_srti, "newRoadworksLayout") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:overnightClosures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Every night the road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction by decision of the appropriate authorities.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overnightClosures">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overnightClosures</seealso>
    let overnightClosures = Prefixed_Name(dtx_srti, "overnightClosures") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadCleared</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>The road has been cleared of earlier reported problems.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadCleared">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadCleared</seealso>
    let roadCleared = Prefixed_Name(dtx_srti, "roadCleared") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:rollingRoadBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic officers or police are driving slowly in front of a queue of traffic to create a gap in the traffic to allow for clearance activities to take place in safety on the road ahead.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rollingRoadBlock">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rollingRoadBlock</seealso>
    let rollingRoadBlock = Prefixed_Name(dtx_srti, "rollingRoadBlock") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rushHourLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dedicated rush (peak) hour lane(s) are in operation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLaneInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLaneInOperation</seealso>
    let rushHourLaneInOperation =
        Prefixed_Name(dtx_srti, "rushHourLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:singleAlternateLineTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Traffic is being controlled to move in alternate single lines. This control may be undertaken by traffic lights or flagman.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleAlternateLineTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleAlternateLineTraffic</seealso>
    let singleAlternateLineTraffic =
        Prefixed_Name(dtx_srti, "singleAlternateLineTraffic") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tidalFlowLaneInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Dedicated tidal flow lane(s) are in operation in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLaneInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLaneInOperation</seealso>
    let tidalFlowLaneInOperation =
        Prefixed_Name(dtx_srti, "tidalFlowLaneInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:longTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadworksDurationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The roadworks are expected to last for a long term ( duration &gt; 6 months)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longTerm">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longTerm</seealso>
    let longTerm = Prefixed_Name(dtx_srti, "longTerm") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:mediumTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadworksDurationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The roadworks are expected to last for a medium term (1 month &lt; duration &lt; = 6 months).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumTerm">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumTerm</seealso>
    let mediumTerm = Prefixed_Name(dtx_srti, "mediumTerm") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:shortTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadworksDurationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The roadworks are expected to last for a short term ( duration &lt; = 1 month)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shortTerm">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#shortTerm</seealso>
    let shortTerm = Prefixed_Name(dtx_srti, "shortTerm") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:mudOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Increased skid risk due to mud on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mudOnRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mudOnRoad</seealso>
    let mudOnRoad = Prefixed_Name(dtx_srti, "mudOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:oilOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>Increased skid risk due to oil on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oilOnRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#oilOnRoad</seealso>
    let oilOnRoad = Prefixed_Name(dtx_srti, "oilOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:petrolOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>Increased skid risk due to petrol on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#petrolOnRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#petrolOnRoad</seealso>
    let petrolOnRoad = Prefixed_Name(dtx_srti, "petrolOnRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:policeForceControlAreaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>Name of a police force control area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlAreaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlAreaName</seealso>
    let policeForceControlAreaName =
        Prefixed_Name(dtx_srti, "policeForceControlAreaName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:aboveGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:HeightGradeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Above or over the normal road grade elevation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveGrade">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveGrade</seealso>
    let aboveGrade = Prefixed_Name(dtx_srti, "aboveGrade") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:atGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:HeightGradeEnum</para>
    ///   <para>At the normal road grade elevation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atGrade">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atGrade</seealso>
    let atGrade = Prefixed_Name(dtx_srti, "atGrade") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:belowGrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:HeightGradeEnum</para>
    ///   <para>Below or under the normal road grade elevation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowGrade">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowGrade</seealso>
    let belowGrade = Prefixed_Name(dtx_srti, "belowGrade") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inbound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionPurposeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the carriageway or lane which is inbound towards the centre of the town or city.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inbound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inbound</seealso>
    let inbound = Prefixed_Name(dtx_srti, "inbound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:outbound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionPurposeEnum</para>
    ///   <para>On the carriageway or lane which is outbound from the centre of the town or city.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outbound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#outbound</seealso>
    let outbound = Prefixed_Name(dtx_srti, "outbound") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotFollowDiversionSigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>Do not follow diversion signs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotFollowDiversionSigns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotFollowDiversionSigns</seealso>
    let doNotFollowDiversionSigns =
        Prefixed_Name(dtx_srti, "doNotFollowDiversionSigns") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:busLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the bus lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busLane</seealso>
    let busLane = Prefixed_Name(dtx_srti, "busLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:busStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the bus stop lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStop">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStop</seealso>
    let busStop = Prefixed_Name(dtx_srti, "busStop") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:carPoolLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the carpool lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carPoolLane</seealso>
    let carPoolLane = Prefixed_Name(dtx_srti, "carPoolLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:centralReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the central reservation separating the two directional carriageways of the highway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#centralReservation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#centralReservation</seealso>
    let centralReservation =
        Prefixed_Name(dtx_srti, "centralReservation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:crawlerLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the crawler lane - a lane that should be used by slower vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crawlerLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crawlerLane</seealso>
    let crawlerLane = Prefixed_Name(dtx_srti, "crawlerLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:cycleLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Part of a carriageway designated for cycles. A cycle lane is distinguished from the rest of the carriageway by longitudinal road markings.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cycleLane</seealso>
    let cycleLane = Prefixed_Name(dtx_srti, "cycleLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:emergencyLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the emergency lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyLane</seealso>
    let emergencyLane = Prefixed_Name(dtx_srti, "emergencyLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:escapeLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the escape lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#escapeLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#escapeLane</seealso>
    let escapeLane = Prefixed_Name(dtx_srti, "escapeLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:leftHandTurningLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the left hand turning lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandTurningLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandTurningLane</seealso>
    let leftHandTurningLane =
        Prefixed_Name(dtx_srti, "leftHandTurningLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:leftLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the left lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftLane</seealso>
    let leftLane = Prefixed_Name(dtx_srti, "leftLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:localTrafficLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the local traffic lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localTrafficLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localTrafficLane</seealso>
    let localTrafficLane = Prefixed_Name(dtx_srti, "localTrafficLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:middleLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the middle lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#middleLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#middleLane</seealso>
    let middleLane = Prefixed_Name(dtx_srti, "middleLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:overtakingLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the overtaking lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakingLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakingLane</seealso>
    let overtakingLane = Prefixed_Name(dtx_srti, "overtakingLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rightHandTurningLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the right hand turning lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandTurningLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandTurningLane</seealso>
    let rightHandTurningLane =
        Prefixed_Name(dtx_srti, "rightHandTurningLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rightLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the right lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightLane</seealso>
    let rightLane = Prefixed_Name(dtx_srti, "rightLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:rushHourLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the lane dedicated for use during the rush (peak) hour.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rushHourLane</seealso>
    let rushHourLane = Prefixed_Name(dtx_srti, "rushHourLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:order1AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Order 1 administrative area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order1AdministrativeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order1AdministrativeArea</seealso>
    let order1AdministrativeArea =
        Prefixed_Name(dtx_srti, "order1AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:order2AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Order 2 administrative area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order2AdministrativeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order2AdministrativeArea</seealso>
    let order2AdministrativeArea =
        Prefixed_Name(dtx_srti, "order2AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:order3AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Order 3 administrative area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order3AdministrativeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order3AdministrativeArea</seealso>
    let order3AdministrativeArea =
        Prefixed_Name(dtx_srti, "order3AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:order4AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Order 4 administrative area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order4AdministrativeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order4AdministrativeArea</seealso>
    let order4AdministrativeArea =
        Prefixed_Name(dtx_srti, "order4AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:order5AdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Order 5 administrative area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order5AdministrativeArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#order5AdministrativeArea</seealso>
    let order5AdministrativeArea =
        Prefixed_Name(dtx_srti, "order5AdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:parkAndRideSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>A park and ride site</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkAndRideSite">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkAndRideSite</seealso>
    let parkAndRideSite = Prefixed_Name(dtx_srti, "parkAndRideSite") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:policeForceControlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Police force control area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeForceControlArea</seealso>
    let policeForceControlArea =
        Prefixed_Name(dtx_srti, "policeForceControlArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:touristArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Tourist area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#touristArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#touristArea</seealso>
    let touristArea = Prefixed_Name(dtx_srti, "touristArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficArea</seealso>
    let trafficArea = Prefixed_Name(dtx_srti, "trafficArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:urbanCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Urban county</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urbanCounty">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#urbanCounty</seealso>
    let urbanCounty = Prefixed_Name(dtx_srti, "urbanCounty") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:waterArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Water area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterArea</seealso>
    let waterArea = Prefixed_Name(dtx_srti, "waterArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:badWeather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Adverse weather conditions are affecting driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#badWeather">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#badWeather</seealso>
    let badWeather = Prefixed_Name(dtx_srti, "badWeather") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:blowingDust</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dust blowing across the roadway causing significantly reduced visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingDust">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingDust</seealso>
    let blowingDust = Prefixed_Name(dtx_srti, "blowingDust") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:blowingSnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Fallen snow moving due to the forces of wind.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingSnow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blowingSnow</seealso>
    let blowingSnow = Prefixed_Name(dtx_srti, "blowingSnow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AbnormalTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A traffic condition which is not normal.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTraffic</seealso>
    let AbnormalTraffic = Prefixed_Name(dtx_srti, "AbnormalTraffic") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfVehiclesWaiting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of vehicles waiting in a queue.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfVehiclesWaiting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfVehiclesWaiting</seealso>
    let numberOfVehiclesWaiting =
        Prefixed_Name(dtx_srti, "numberOfVehiclesWaiting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:MetresAsNonNegativeIntegerValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of distance defined in metres in a non negative integer format.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsNonNegativeIntegerValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsNonNegativeIntegerValue</seealso>
    let MetresAsNonNegativeIntegerValue =
        Prefixed_Name(dtx_srti, "MetresAsNonNegativeIntegerValue") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:queueLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The length of a queue or the average length of queues in separate lanes due to a situation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queueLength">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queueLength</seealso>
    let queueLength = Prefixed_Name(dtx_srti, "queueLength") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TrafficTrendTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficTrendTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficTrendTypeEnum</seealso>
    let TrafficTrendTypeEnum =
        Prefixed_Name(dtx_srti, "TrafficTrendTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTrafficTrendTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A characterization of the trend in the traffic conditions at the specified location and direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficTrendTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficTrendTypeEnum</seealso>
    let hasTrafficTrendTypeEnum =
        Prefixed_Name(dtx_srti, "hasTrafficTrendTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TrafficFlowCharateristicsEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The consistency (steadiness) of the traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficFlowCharateristicsEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficFlowCharateristicsEnum</seealso>
    let TrafficFlowCharateristicsEnum =
        Prefixed_Name(dtx_srti, "TrafficFlowCharateristicsEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PayloadPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A payload publication of traffic related information or associated management information created at a specific point in time that can be exchanged via a DATEX II interface.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayloadPublication">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayloadPublication</seealso>
    let PayloadPublication =
        Prefixed_Name(dtx_srti, "PayloadPublication") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:feedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A classification of the information which is to be found in the publications originating from the particular feed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedType</seealso>
    let feedType = Prefixed_Name(dtx_srti, "feedType") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:feedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of the information which is to be found in the publications originating from the particular feed (URL).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#feedDescription</seealso>
    let feedDescription = Prefixed_Name(dtx_srti, "feedDescription") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:publicationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date/time at which the payload publication was created.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationTime</seealso>
    let publicationTime = Prefixed_Name(dtx_srti, "publicationTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:publicationCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the publication creator using an international identifier</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationCreator">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicationCreator</seealso>
    let publicationCreator =
        Prefixed_Name(dtx_srti, "publicationCreator") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:defaultLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the language by an ISO 639-1 2-alpha code</para>
    ///   <para>The default language used throughout the payload publication</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#defaultLanguage">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#defaultLanguage</seealso>
    let defaultLanguage = Prefixed_Name(dtx_srti, "defaultLanguage") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PercentageDistanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from the start node expressed as a percentage of the whole length of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PercentageDistanceAlongLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PercentageDistanceAlongLinearElement</seealso>
    let PercentageDistanceAlongLinearElement =
        Prefixed_Name(dtx_srti, "PercentageDistanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:percentageDistanceAlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measure of distance along a linear element from the start of the element expressed as a percentage of the total length of the linear object.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#percentageDistanceAlong">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#percentageDistanceAlong</seealso>
    let percentageDistanceAlong =
        Prefixed_Name(dtx_srti, "percentageDistanceAlong") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc03JunctionPointDescriptorSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptors for describing a point at a road junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03JunctionPointDescriptorSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03JunctionPointDescriptorSubtypeEnum</seealso>
    let TpegLoc03JunctionPointDescriptorSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc03JunctionPointDescriptorSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegJunctionPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegJunctionPointDescriptorType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegJunctionPointDescriptorType</seealso>
    let tpegJunctionPointDescriptorType =
        Prefixed_Name(dtx_srti, "tpegJunctionPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegLinearLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegLinearLocationType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegLinearLocationType</seealso>
    let tpegLinearLocationType =
        Prefixed_Name(dtx_srti, "tpegLinearLocationType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegDirection</seealso>
    let tpegDirection = Prefixed_Name(dtx_srti, "tpegDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc01SimplePointLocationSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of simple point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01SimplePointLocationSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01SimplePointLocationSubtypeEnum</seealso>
    let TpegLoc01SimplePointLocationSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc01SimplePointLocationSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptors other than junction names and road descriptors which can help to identify the location of points on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03OtherPointDescriptorSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03OtherPointDescriptorSubtypeEnum</seealso>
    let TpegLoc03OtherPointDescriptorSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc03OtherPointDescriptorSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegNamedOnlyArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by a well-known name.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNamedOnlyArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegNamedOnlyArea</seealso>
    let TpegNamedOnlyArea = Prefixed_Name(dtx_srti, "TpegNamedOnlyArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegOtherPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General descriptor for describing a point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegOtherPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegOtherPointDescriptor</seealso>
    let TpegOtherPointDescriptor =
        Prefixed_Name(dtx_srti, "TpegOtherPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegOtherPointDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A descriptive name which helps to identify the non-junction point. At least one descriptor must identify the road on which the point is located, i.e. must be of type 'linkName' or 'localLinkName'.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegOtherPointDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegOtherPointDescriptor</seealso>
    let hasTpegOtherPointDescriptor =
        Prefixed_Name(dtx_srti, "hasTpegOtherPointDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegOtherPointDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegOtherPointDescriptorType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegOtherPointDescriptorType</seealso>
    let tpegOtherPointDescriptorType =
        Prefixed_Name(dtx_srti, "tpegOtherPointDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:timeDataProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeDataProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeDataProperties</seealso>
    let timeDataProperties =
        Prefixed_Name(dtx_srti, "timeDataProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:timeObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only for organizational purposes. Time object properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeObjectProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#timeObjectProperties</seealso>
    let timeObjectProperties =
        Prefixed_Name(dtx_srti, "timeObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadAuthorities</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A road authority.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadAuthorities">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadAuthorities</seealso>
    let roadAuthorities = Prefixed_Name(dtx_srti, "roadAuthorities") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadsideTelephoneCaller</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A caller who is using an emergency roadside telephone.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideTelephoneCaller">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideTelephoneCaller</seealso>
    let roadsideTelephoneCaller =
        Prefixed_Name(dtx_srti, "roadsideTelephoneCaller") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficMonitoringStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A station, usually automatic, dedicated to the monitoring of the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficMonitoringStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficMonitoringStation</seealso>
    let trafficMonitoringStation =
        Prefixed_Name(dtx_srti, "trafficMonitoringStation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:videoProcessingMonitoringStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A station dedicated to the monitoring of the road network by processing video image information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#videoProcessingMonitoringStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#videoProcessingMonitoringStation</seealso>
    let videoProcessingMonitoringStation =
        Prefixed_Name(dtx_srti, "videoProcessingMonitoringStation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:againstLineDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrOrientationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Against line direction</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#againstLineDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#againstLineDirection</seealso>
    let againstLineDirection =
        Prefixed_Name(dtx_srti, "againstLineDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:withLineDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrOrientationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>With line direction</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withLineDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withLineDirection</seealso>
    let withLineDirection = Prefixed_Name(dtx_srti, "withLineDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:overseasDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Overseas department</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasDepartment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasDepartment</seealso>
    let overseasDepartment =
        Prefixed_Name(dtx_srti, "overseasDepartment") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:quarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Quarter</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#quarter">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#quarter</seealso>
    let quarter = Prefixed_Name(dtx_srti, "quarter") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod2Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Point">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Point</seealso>
    let AlertCMethod2Point =
        Prefixed_Name(dtx_srti, "AlertCMethod2Point") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCPoint</seealso>
    let AlertCPoint = Prefixed_Name(dtx_srti, "AlertCPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accuracyPercentile75</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Accuracy defined by the 75th percentile of the cumulative distribution of position errors</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile75">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile75</seealso>
    let accuracyPercentile75 =
        Prefixed_Name(dtx_srti, "accuracyPercentile75") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accuracyPercentile50</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Accuracy defined by the 50th percentile of the cumulative distribution of position errors.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile50">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracyPercentile50</seealso>
    let accuracyPercentile50 =
        Prefixed_Name(dtx_srti, "accuracyPercentile50") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasValidityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specification of validity, either explicitly overriding the validity time specification or confirming it.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidityStatus">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidityStatus</seealso>
    let hasValidityStatus = Prefixed_Name(dtx_srti, "hasValidityStatus") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>Perceived by supplier as being of a medium level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medium">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medium</seealso>
    let medium = Prefixed_Name(dtx_srti, "medium") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:arcticRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Arctic region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arcticRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arcticRegion</seealso>
    let arcticRegion = Prefixed_Name(dtx_srti, "arcticRegion") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadSigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Road signs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSigns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSigns</seealso>
    let roadSigns = Prefixed_Name(dtx_srti, "roadSigns") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadsideEmbankment</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Roadside embankment.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEmbankment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadsideEmbankment</seealso>
    let roadsideEmbankment =
        Prefixed_Name(dtx_srti, "roadsideEmbankment") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tollGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Toll gate.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tollGate</seealso>
    let tollGate = Prefixed_Name(dtx_srti, "tollGate") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bothSides</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrSideOfRoadEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the both sides of the roads.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothSides">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothSides</seealso>
    let bothSides = Prefixed_Name(dtx_srti, "bothSides") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:restrictedToAuthorities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>Restricted for use only by authorities.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthorities">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthorities</seealso>
    let restrictedToAuthorities =
        Prefixed_Name(dtx_srti, "restrictedToAuthorities") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:restrictedToAuthoritiesTrafficOperatorsAndVms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    ///   <para>Restricted for use only by authorities, traffic operators, publishers (service providers) and variable message signs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndVms">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#restrictedToAuthoritiesTrafficOperatorsAndVms</seealso>
    let restrictedToAuthoritiesTrafficOperatorsAndVms =
        Prefixed_Name(dtx_srti, "restrictedToAuthoritiesTrafficOperatorsAndVms") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:exitSlipRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the exit slip road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exitSlipRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exitSlipRoad</seealso>
    let exitSlipRoad = Prefixed_Name(dtx_srti, "exitSlipRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:leftHandParallelCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On the left hand parallel carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandParallelCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leftHandParallelCarriageway</seealso>
    let leftHandParallelCarriageway =
        Prefixed_Name(dtx_srti, "leftHandParallelCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rightHandFeederRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the right hand feeder road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandFeederRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandFeederRoad</seealso>
    let rightHandFeederRoad =
        Prefixed_Name(dtx_srti, "rightHandFeederRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rightHandParallelCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the right hand parallel carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandParallelCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rightHandParallelCarriageway</seealso>
    let rightHandParallelCarriageway =
        Prefixed_Name(dtx_srti, "rightHandParallelCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:unspecifiedCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>On an unspecified carriageway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedCarriageway</seealso>
    let unspecifiedCarriageway =
        Prefixed_Name(dtx_srti, "unspecifiedCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:agriculturalVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Vehicle normally used for agricultural purposes, e.g. tractor, combined harvester etc.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalVehicle</seealso>
    let agriculturalVehicle =
        Prefixed_Name(dtx_srti, "agriculturalVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:caravan</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Caravan.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#caravan">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#caravan</seealso>
    let caravan = Prefixed_Name(dtx_srti, "caravan") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:constructionOrMaintenanceVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle normally used for construction or maintenance purposes, e.g. digger, excavator, bulldozer, lorry mounted crane etc.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionOrMaintenanceVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionOrMaintenanceVehicle</seealso>
    let constructionOrMaintenanceVehicle =
        Prefixed_Name(dtx_srti, "constructionOrMaintenanceVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:motorcycleWithSideCar</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Three wheeled vehicle comprising a motorcycle with an attached side car.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycleWithSideCar">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorcycleWithSideCar</seealso>
    let motorcycleWithSideCar =
        Prefixed_Name(dtx_srti, "motorcycleWithSideCar") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:motorscooter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>Motorscooter (a two wheeled motor vehicle characterized by a step-through frame and small diameter wheels).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorscooter">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorscooter</seealso>
    let motorscooter = Prefixed_Name(dtx_srti, "motorscooter") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Trailer.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trailer">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trailer</seealso>
    let trailer = Prefixed_Name(dtx_srti, "trailer") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tram</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Tram.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tram">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tram</seealso>
    let tram = Prefixed_Name(dtx_srti, "tram") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod4SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4SecondaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4SecondaryPointLocation</seealso>
    let AlertCMethod4SecondaryPointLocation =
        Prefixed_Name(dtx_srti, "AlertCMethod4SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCMethod4SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ALERT-C method4 secondary point location</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined Alert-C location table plus a non-negative offset distance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4SecondaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod4SecondaryPointLocation</seealso>
    let hasAlertCMethod4SecondaryPointLocation =
        Prefixed_Name(dtx_srti, "hasAlertCMethod4SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod4Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by reference to a point in a pre-defined ALERT-C location table plus an offset distance and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Point">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod4Point</seealso>
    let AlertCMethod4Point =
        Prefixed_Name(dtx_srti, "AlertCMethod4Point") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OffsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The non-negative offset distance from the ALERT-C referenced point to the actual point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OffsetDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OffsetDistance</seealso>
    let OffsetDistance = Prefixed_Name(dtx_srti, "OffsetDistance") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:TpegPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is either a junction point or a non junction point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPoint</seealso>
    let TpegPoint = Prefixed_Name(dtx_srti, "TpegPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coded level of vertical accuracy</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeAccuracyEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeAccuracyEnum</seealso>
    let AltitudeAccuracyEnum =
        Prefixed_Name(dtx_srti, "AltitudeAccuracyEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AltitudeConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeConfidence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AltitudeConfidence</seealso>
    let AltitudeConfidence =
        Prefixed_Name(dtx_srti, "AltitudeConfidence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PositionConfidenceCodedErrorEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Error code for horizontal or vertical position confidence</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceCodedErrorEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceCodedErrorEnum</seealso>
    let PositionConfidenceCodedErrorEnum =
        Prefixed_Name(dtx_srti, "PositionConfidenceCodedErrorEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPositionConfidenceCodedErrorEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Error code in case the altitude confidence is out of range or cannot be determined</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceCodedErrorEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceCodedErrorEnum</seealso>
    let hasPositionConfidenceCodedErrorEnum =
        Prefixed_Name(dtx_srti, "hasPositionConfidenceCodedErrorEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAltitudeAccuracyCodedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Absolute accuracy of reported value of a geographical point for a confidence level expressed by a coded scale.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeAccuracyCodedValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeAccuracyCodedValue</seealso>
    let hasAltitudeAccuracyCodedValue =
        Prefixed_Name(dtx_srti, "hasAltitudeAccuracyCodedValue") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AnimalPresenceObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road resulting from the presence of animals.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceObstruction</seealso>
    let AnimalPresenceObstruction =
        Prefixed_Name(dtx_srti, "AnimalPresenceObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAnimalPresenceTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the nature of animals present on or near the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAnimalPresenceTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAnimalPresenceTypeEnum</seealso>
    let hasAnimalPresenceTypeEnum =
        Prefixed_Name(dtx_srti, "hasAnimalPresenceTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:VehicleObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road caused by one or more vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstruction</seealso>
    let VehicleObstruction =
        Prefixed_Name(dtx_srti, "VehicleObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeneralObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any stationary or moving obstacle of a physical nature, other than of an animal, vehicle, environmental, or damaged equipment nature.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralObstruction</seealso>
    let GeneralObstruction =
        Prefixed_Name(dtx_srti, "GeneralObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:EnvironmentalObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road resulting from an environmental cause.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstruction</seealso>
    let EnvironmentalObstruction =
        Prefixed_Name(dtx_srti, "EnvironmentalObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegAreaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaLocation</seealso>
    let TpegAreaLocation = Prefixed_Name(dtx_srti, "TpegAreaLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegAreaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A geographic or geometric area defined by a TPEG-Loc structure which may include height information for additional geospatial discrimination.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegAreaLocation</seealso>
    let hasTpegAreaLocation =
        Prefixed_Name(dtx_srti, "hasTpegAreaLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrAreaLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrAreaLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrAreaLocationReference</seealso>
    let OpenlrAreaLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrAreaLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrAreaLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A two-dimensional part of the surface of the earth which is bounded by a closed curve. An area location may cover parts of the road network but does not necessarily need to. It is represented according to the OpenLR standard for Area Locations</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrAreaLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrAreaLocationReference</seealso>
    let hasOpenlrAreaLocationReference =
        Prefixed_Name(dtx_srti, "hasOpenlrAreaLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GmlMultiPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by a set of polygons acording to GML (EN ISO 19136).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlMultiPolygon">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlMultiPolygon</seealso>
    let GmlMultiPolygon = Prefixed_Name(dtx_srti, "GmlMultiPolygon") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGmlMultiPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An area defined by a set of polygons acording to GML (EN ISO 19136).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlMultiPolygon">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlMultiPolygon</seealso>
    let hasGmlMultiPolygon =
        Prefixed_Name(dtx_srti, "hasGmlMultiPolygon") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of area place(s)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaPlacesEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaPlacesEnum</seealso>
    let AreaPlacesEnum = Prefixed_Name(dtx_srti, "AreaPlacesEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasAreaPlacesEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Places, in generic terms, at which the corresponding information applies.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAreaPlacesEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAreaPlacesEnum</seealso>
    let hasAreaPlacesEnum = Prefixed_Name(dtx_srti, "hasAreaPlacesEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of a location either on a network (as a point or a linear location) or as an area. This may be provided in one or more referencing systems. Association: 0..1PointCoordinates. In SRTI is not included LocationByReference.</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Location">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Location</seealso>
    let Location = Prefixed_Name(dtx_srti, "Location") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAdministrativeAreaOfLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identification of the road administration area which contains the specified linear section.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfLinearSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfLinearSection</seealso>
    let hasAdministrativeAreaOfLinearSection =
        Prefixed_Name(dtx_srti, "hasAdministrativeAreaOfLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:directionRelativeOnLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    ///   <para>The direction of traffic flow on the linear section relative to the direction in which the linear element is defined.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeOnLinearSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeOnLinearSection</seealso>
    let directionRelativeOnLinearSection =
        Prefixed_Name(dtx_srti, "directionRelativeOnLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In Datex II definition, a pair of planar coordinates defining the geodetic position of a single point using the European Terrestrial Reference System 1989 (ETRS89).
    ///
    /// Note: At the moment, in Spain it is used the WGS84 and so, the 2 references are possible ( geo/wgs84_pos (lat, long) / geo_core (xETRS89,yETRS89) ).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinates</seealso>
    let PointCoordinates = Prefixed_Name(dtx_srti, "PointCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPointCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Coordinates that may be used by clients for visual display on user interfaces.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointCoordinates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointCoordinates</seealso>
    let hasPointCoordinates =
        Prefixed_Name(dtx_srti, "hasPointCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PayLoadPublishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes. Package PayloadPublication</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadPublishing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PayLoadPublishing</seealso>
    let PayLoadPublishing = Prefixed_Name(dtx_srti, "PayLoadPublishing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:MaintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the maintenance vehicles involved in the roadworks activity.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicles</seealso>
    let MaintenanceVehicles =
        Prefixed_Name(dtx_srti, "MaintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfMaintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of maintenance vehicles associated with the roadworks activities at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfMaintenanceVehicles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfMaintenanceVehicles</seealso>
    let numberOfMaintenanceVehicles =
        Prefixed_Name(dtx_srti, "numberOfMaintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:MaintenanceWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Roadworks involving the maintenance or installation of infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceWorks">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceWorks</seealso>
    let MaintenanceWorks = Prefixed_Name(dtx_srti, "MaintenanceWorks") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadMaintenanceTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of road maintenance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadMaintenanceTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadMaintenanceTypeEnum</seealso>
    let RoadMaintenanceTypeEnum =
        Prefixed_Name(dtx_srti, "RoadMaintenanceTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadMaintenanceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of road maintenance or installation work at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadMaintenanceType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadMaintenanceType</seealso>
    let hasRoadMaintenanceType =
        Prefixed_Name(dtx_srti, "hasRoadMaintenanceType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SeverityEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SeverityEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SeverityEnum</seealso>
    let SeverityEnum = Prefixed_Name(dtx_srti, "SeverityEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SingleRoadLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location representing a linear section along a single road with optional directionality defined between two points on the same road. No matter the kind of linear reference it uses, the constraint of using only a single road must be preserved. Associations:
    /// 0..1	TpegLinearLocation
    /// 0..*	AlertCLinear</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SingleRoadLinearLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SingleRoadLinearLocation</seealso>
    let SingleRoadLinearLocation =
        Prefixed_Name(dtx_srti, "SingleRoadLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLinearLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLinearLocation</seealso>
    let TpegLinearLocation =
        Prefixed_Name(dtx_srti, "TpegLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linear section along a single road defined between two points on the same road by a TPEG-Loc structure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegLinearLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegLinearLocation</seealso>
    let hasTpegLinearLocation =
        Prefixed_Name(dtx_srti, "hasTpegLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable instance of a traffic/travel situation comprising one or more traffic/travel circumstances which are linked by one or more causal relationships. Each traffic/travel circumstance is represented by a Situation Record.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Situation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Situation</seealso>
    let Situation = Prefixed_Name(dtx_srti, "Situation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasHeaderInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Management information relating to the data contained within a publication.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeaderInformation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeaderInformation</seealso>
    let hasHeaderInformation =
        Prefixed_Name(dtx_srti, "hasHeaderInformation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details of the Situation</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituationRecord">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituationRecord</seealso>
    let hasSituationRecord =
        Prefixed_Name(dtx_srti, "hasSituationRecord") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SituationPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A publication containing zero or more traffic/travel situations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationPublication">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationPublication</seealso>
    let SituationPublication =
        Prefixed_Name(dtx_srti, "SituationPublication") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Version of Situation Record</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersion</seealso>
    let situationRecordVersion =
        Prefixed_Name(dtx_srti, "situationRecordVersion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Validity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Validity</seealso>
    let Validity = Prefixed_Name(dtx_srti, "Validity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specification of validity, either explicitly or by a validity time period specification which may be discontinuous.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasValidity</seealso>
    let hasValidity = Prefixed_Name(dtx_srti, "hasValidity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bothDirections</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrOrientationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Both directions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothDirections">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothDirections</seealso>
    let bothDirections = Prefixed_Name(dtx_srti, "bothDirections") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:approachWithCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Approach with care</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#approachWithCare">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#approachWithCare</seealso>
    let approachWithCare = Prefixed_Name(dtx_srti, "approachWithCare") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:avoidTheArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Avoid the area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidTheArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidTheArea</seealso>
    let avoidTheArea = Prefixed_Name(dtx_srti, "avoidTheArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:crossJunctionWithCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Cross junction with care</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crossJunctionWithCare">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crossJunctionWithCare</seealso>
    let crossJunctionWithCare =
        Prefixed_Name(dtx_srti, "crossJunctionWithCare") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:festival</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Celebratory event or series of events which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#festival">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#festival</seealso>
    let festival = Prefixed_Name(dtx_srti, "festival") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LinearElementNatureEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The nature of the linear element is a section of a road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadSection</seealso>
    let roadSection = Prefixed_Name(dtx_srti, "roadSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:busPassengerAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bus passenger assistance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busPassengerAssistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busPassengerAssistance</seealso>
    let busPassengerAssistance =
        Prefixed_Name(dtx_srti, "busPassengerAssistance") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleRecovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle recovery.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRecovery">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleRecovery</seealso>
    let vehicleRecovery = Prefixed_Name(dtx_srti, "vehicleRecovery") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atMotorwayInterchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>At a motorway interchange.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atMotorwayInterchange">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atMotorwayInterchange</seealso>
    let atMotorwayInterchange =
        Prefixed_Name(dtx_srti, "atMotorwayInterchange") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOffsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The non-negative offset distance from the ALERT-C referenced point to the actual point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOffsetDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOffsetDistance</seealso>
    let hasOffsetDistance = Prefixed_Name(dtx_srti, "hasOffsetDistance") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RelativePositionOnCarriagewayEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Identifies a relative position across a carriageway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativePositionOnCarriagewayEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativePositionOnCarriagewayEnum</seealso>
    let RelativePositionOnCarriagewayEnum =
        Prefixed_Name(dtx_srti, "RelativePositionOnCarriagewayEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:threeWheeledVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Three wheeled vehicle of unspecified type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#threeWheeledVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#threeWheeledVehicle</seealso>
    let threeWheeledVehicle =
        Prefixed_Name(dtx_srti, "threeWheeledVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:withEvenNumberedRegistrationPlates</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle with even numbered registration plate.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withEvenNumberedRegistrationPlates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withEvenNumberedRegistrationPlates</seealso>
    let withEvenNumberedRegistrationPlates =
        Prefixed_Name(dtx_srti, "withEvenNumberedRegistrationPlates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:lau1Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>LAU 1 code</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau1Code">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lau1Code</seealso>
    let lau1Code = Prefixed_Name(dtx_srti, "lau1Code") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:HeaderInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Management information relating to the data contained within a publication.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeaderInformation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeaderInformation</seealso>
    let HeaderInformation = Prefixed_Name(dtx_srti, "HeaderInformation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InformationStatusEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Status of the related information (i.e. real, test or exercise).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationStatusEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationStatusEnum</seealso>
    let InformationStatusEnum =
        Prefixed_Name(dtx_srti, "InformationStatusEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:heightValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value in metres for the height measured vertically at to the planar coordinates the point corresponding.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heightValue</seealso>
    let heightValue = Prefixed_Name(dtx_srti, "heightValue") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotAllowUnnecessaryGaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Do not allow unnecessary gaps</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotAllowUnnecessaryGaps">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotAllowUnnecessaryGaps</seealso>
    let doNotAllowUnnecessaryGaps =
        Prefixed_Name(dtx_srti, "doNotAllowUnnecessaryGaps") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotUseNavigationSystems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Do not use navigation systems</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseNavigationSystems">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseNavigationSystems</seealso>
    let doNotUseNavigationSystems =
        Prefixed_Name(dtx_srti, "doNotUseNavigationSystems") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:followTheVehicleInFrontSmoothly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Follow the vehicle in front smoothly</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followTheVehicleInFrontSmoothly">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followTheVehicleInFrontSmoothly</seealso>
    let followTheVehicleInFrontSmoothly =
        Prefixed_Name(dtx_srti, "followTheVehicleInFrontSmoothly") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:waterSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Water sports meeting that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterSportsMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waterSportsMeeting</seealso>
    let waterSportsMeeting =
        Prefixed_Name(dtx_srti, "waterSportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onElevatedSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On elevated section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSection</seealso>
    let onElevatedSection = Prefixed_Name(dtx_srti, "onElevatedSection") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:withinJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    ///   <para>On the main carriageway within a junction between exit slip road and entry slip road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withinJunction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#withinJunction</seealso>
    let withinJunction = Prefixed_Name(dtx_srti, "withinJunction") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:longDelays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DelaysTypeEnum</para>
    ///   <para>Delays on the road network of unusual severity.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longDelays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#longDelays</seealso>
    let longDelays = Prefixed_Name(dtx_srti, "longDelays") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InformationDeliveryServicesEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationDeliveryServicesEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InformationDeliveryServicesEnum</seealso>
    let InformationDeliveryServicesEnum =
        Prefixed_Name(dtx_srti, "InformationDeliveryServicesEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotThrowOutAnyBurningObjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Do not throw out any burning objects</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotThrowOutAnyBurningObjects">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotThrowOutAnyBurningObjects</seealso>
    let doNotThrowOutAnyBurningObjects =
        Prefixed_Name(dtx_srti, "doNotThrowOutAnyBurningObjects") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:flashYourLights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Flash your lights</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flashYourLights">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#flashYourLights</seealso>
    let flashYourLights = Prefixed_Name(dtx_srti, "flashYourLights") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inEmergencyWaitForPatrolService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>In emergency wait for patrol service</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inEmergencyWaitForPatrolService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inEmergencyWaitForPatrolService</seealso>
    let inEmergencyWaitForPatrolService =
        Prefixed_Name(dtx_srti, "inEmergencyWaitForPatrolService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:excessiveDriverTiredness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Excessive tiredness of the driver.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessiveDriverTiredness">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessiveDriverTiredness</seealso>
    let excessiveDriverTiredness =
        Prefixed_Name(dtx_srti, "excessiveDriverTiredness") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:impermissibleManoeuvre</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A driving manoeuvre which was not permitted.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impermissibleManoeuvre">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impermissibleManoeuvre</seealso>
    let impermissibleManoeuvre =
        Prefixed_Name(dtx_srti, "impermissibleManoeuvre") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:poorSurfaceAdherence</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Poor road surface adherence.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorSurfaceAdherence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorSurfaceAdherence</seealso>
    let poorSurfaceAdherence =
        Prefixed_Name(dtx_srti, "poorSurfaceAdherence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:closedPermanentlyForTheWinter</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road is closed to vehicles with the specified characteristics or all, if none defined, for the duration of the winter.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closedPermanentlyForTheWinter">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#closedPermanentlyForTheWinter</seealso>
    let closedPermanentlyForTheWinter =
        Prefixed_Name(dtx_srti, "closedPermanentlyForTheWinter") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotUseSpecifiedLanesOrCarriageways</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Do not use the specified lane(s) or carriageway(s).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseSpecifiedLanesOrCarriageways">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseSpecifiedLanesOrCarriageways</seealso>
    let doNotUseSpecifiedLanesOrCarriageways =
        Prefixed_Name(dtx_srti, "doNotUseSpecifiedLanesOrCarriageways") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AngleInDegreesValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or  value of Angles. An integer number representing an angle in whole degrees between 0 and 359.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AngleInDegreesValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AngleInDegreesValue</seealso>
    let AngleInDegreesValue =
        Prefixed_Name(dtx_srti, "AngleInDegreesValue") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AnimalPresenceTypeEmum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of animal presence.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceTypeEmum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AnimalPresenceTypeEmum</seealso>
    let AnimalPresenceTypeEmum =
        Prefixed_Name(dtx_srti, "AnimalPresenceTypeEmum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:driveWithExtremeCaution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Drive with extreme caution</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveWithExtremeCaution">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driveWithExtremeCaution</seealso>
    let driveWithExtremeCaution =
        Prefixed_Name(dtx_srti, "driveWithExtremeCaution") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:keepYourDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Keep your distance.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepYourDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#keepYourDistance</seealso>
    let keepYourDistance = Prefixed_Name(dtx_srti, "keepYourDistance") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:noSmoking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>No smoking.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noSmoking">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noSmoking</seealso>
    let noSmoking = Prefixed_Name(dtx_srti, "noSmoking") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:observeSigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Observe signs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSigns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSigns</seealso>
    let observeSigns = Prefixed_Name(dtx_srti, "observeSigns") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:pullOverToTheEdgeOfTheRoadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Pull over to the edge of the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pullOverToTheEdgeOfTheRoadway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pullOverToTheEdgeOfTheRoadway</seealso>
    let pullOverToTheEdgeOfTheRoadway =
        Prefixed_Name(dtx_srti, "pullOverToTheEdgeOfTheRoadway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:switchOffEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Switch off engine.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffEngine">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffEngine</seealso>
    let switchOffEngine = Prefixed_Name(dtx_srti, "switchOffEngine") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:testYourBrakes</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Test your brakes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#testYourBrakes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#testYourBrakes</seealso>
    let testYourBrakes = Prefixed_Name(dtx_srti, "testYourBrakes") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:useFogLights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Use fog lights.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useFogLights">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useFogLights</seealso>
    let useFogLights = Prefixed_Name(dtx_srti, "useFogLights") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:useRailService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Use rail service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useRailService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useRailService</seealso>
    let useRailService = Prefixed_Name(dtx_srti, "useRailService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan100Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 100 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan100Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan100Metres</seealso>
    let equalToOrLessThan100Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan100Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of maintenance vehicle actions associated with roadworks.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicleActionsEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MaintenanceVehicleActionsEnum</seealso>
    let MaintenanceVehicleActionsEnum =
        Prefixed_Name(dtx_srti, "MaintenanceVehicleActionsEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:increaseNormalFollowingDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Increase normal following distance</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#increaseNormalFollowingDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#increaseNormalFollowingDistance</seealso>
    let increaseNormalFollowingDistance =
        Prefixed_Name(dtx_srti, "increaseNormalFollowingDistance") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:noNakedFlames</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No naked flames.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noNakedFlames">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noNakedFlames</seealso>
    let noNakedFlames = Prefixed_Name(dtx_srti, "noNakedFlames") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:noUturns</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No U-turns.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noUturns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noUturns</seealso>
    let noUturns = Prefixed_Name(dtx_srti, "noUturns") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onlyTravelIfAbsolutelyNecessary</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Only travel if absolutely necessary.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onlyTravelIfAbsolutelyNecessary">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onlyTravelIfAbsolutelyNecessary</seealso>
    let onlyTravelIfAbsolutelyNecessary =
        Prefixed_Name(dtx_srti, "onlyTravelIfAbsolutelyNecessary") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>The road is closed to vehicles with the specified characteristics or all, if none defined, in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadClosed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadClosed</seealso>
    let roadClosed = Prefixed_Name(dtx_srti, "roadClosed") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AreaLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location representing a geographic or geometric defined area which may be qualified by height information to provide additional geospatial discrimination (e.g. for snow in an area but only above a certain altitude). Associations:
    /// 0..*	AlertCArea
    /// 0..1	TpegAreaLocation
    /// 0..1	NamedArea
    /// 0..1	GmlMultiPolygon
    /// 0..1	OpenlrAreaLocationReference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AreaLocation</seealso>
    let AreaLocation = Prefixed_Name(dtx_srti, "AreaLocation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:NamedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedArea</seealso>
    let NamedArea = Prefixed_Name(dtx_srti, "NamedArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasNamedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An area defined by a name and/or in terms of known boundaries, such as country or county boundaries or allocated control area of particular authority. The attributes do not form a union; instead, the smallest intersection forms the resulting area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedArea</seealso>
    let hasNamedArea = Prefixed_Name(dtx_srti, "hasNamedArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:underTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that the road section where the roadworks are located is under traffic or not under traffic. 'True' indicates the road is under traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#underTraffic</seealso>
    let underTraffic = Prefixed_Name(dtx_srti, "underTraffic") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadworksScaleEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksScaleEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksScaleEnum</seealso>
    let hasRoadworksScaleEnum =
        Prefixed_Name(dtx_srti, "hasRoadworksScaleEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadworksIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An external identifier for the roadworks</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadworksIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadworksIdentifier</seealso>
    let roadworksIdentifier =
        Prefixed_Name(dtx_srti, "roadworksIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasMaintenanceVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Details of the maintenance vehicles involved in the roadworks activity.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicles</seealso>
    let hasMaintenanceVehicles =
        Prefixed_Name(dtx_srti, "hasMaintenanceVehicles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobility">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobility</seealso>
    let hasMobility = Prefixed_Name(dtx_srti, "hasMobility") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadworksDurationEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Expected durations of roadworks in general terms.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksDurationEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksDurationEnum</seealso>
    let RoadworksDurationEnum =
        Prefixed_Name(dtx_srti, "RoadworksDurationEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:noOvertaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No overtaking on the specified section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOvertaking">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noOvertaking</seealso>
    let noOvertaking = Prefixed_Name(dtx_srti, "noOvertaking") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:observeAmberAlert</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Observe current amber alert (an emergency alert issued for a missing or abducted child).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeAmberAlert">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeAmberAlert</seealso>
    let observeAmberAlert = Prefixed_Name(dtx_srti, "observeAmberAlert") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:contraflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    ///   <para>Two-way traffic is temporarily sharing a single carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#contraflow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#contraflow</seealso>
    let contraflow = Prefixed_Name(dtx_srti, "contraflow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:LinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object, consistent with EN ISO 19148 definitions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElement</seealso>
    let LinearElement = Prefixed_Name(dtx_srti, "LinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadworksScaleEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grade of complexity of the roadworks according to the responsible road operator. For example determined by size, duration and/or traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksScaleEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadworksScaleEnum</seealso>
    let RoadworksScaleEnum =
        Prefixed_Name(dtx_srti, "RoadworksScaleEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Subjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subjects with which the roadworks are associated.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Subjects">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Subjects</seealso>
    let Subjects = Prefixed_Name(dtx_srti, "Subjects") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubject">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubject</seealso>
    let hasSubject = Prefixed_Name(dtx_srti, "hasSubject") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadworksDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates in general terms the expected duration of the roadworks.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksDuration">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadworksDuration</seealso>
    let hasRoadworksDuration =
        Prefixed_Name(dtx_srti, "hasRoadworksDuration") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadsideAssistanceTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistanceTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadsideAssistanceTypeEnum</seealso>
    let RoadsideAssistanceTypeEnum =
        Prefixed_Name(dtx_srti, "RoadsideAssistanceTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadsideAssistenceTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the nature of the road side assistance that will be, is or has been provided.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadsideAssistenceTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadsideAssistenceTypeEnum</seealso>
    let hasRoadsideAssistenceTypeEnum =
        Prefixed_Name(dtx_srti, "hasRoadsideAssistenceTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:HeightCoordinateAssociationFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Third coordinate for points defined geodetically</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinateAssociationFrom">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightCoordinateAssociationFrom</seealso>
    let HeightCoordinateAssociationFrom =
        Prefixed_Name(dtx_srti, "HeightCoordinateAssociationFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The linear location expressed using AlertC. Multiple instances of AlertCLinear shall represent the same real-world geographic feature.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLinear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCLinear</seealso>
    let hasAlertCLinear = Prefixed_Name(dtx_srti, "hasAlertCLinear") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:overtakeWithCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Overtake with care.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakeWithCare">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overtakeWithCare</seealso>
    let overtakeWithCare = Prefixed_Name(dtx_srti, "overtakeWithCare") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:stopAtNextServiceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Stop at next rest service area or car park.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextServiceArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAtNextServiceArea</seealso>
    let stopAtNextServiceArea =
        Prefixed_Name(dtx_srti, "stopAtNextServiceArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:switchOffMobilePhonesAndTwoWayRadios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Switch off mobile phones and two-way radios.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffMobilePhonesAndTwoWayRadios">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#switchOffMobilePhonesAndTwoWayRadios</seealso>
    let switchOffMobilePhonesAndTwoWayRadios =
        Prefixed_Name(dtx_srti, "switchOffMobilePhonesAndTwoWayRadios") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useHeadlights</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use headlights.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHeadlights">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useHeadlights</seealso>
    let useHeadlights = Prefixed_Name(dtx_srti, "useHeadlights") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useUndergroundService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use underground service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useUndergroundService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useUndergroundService</seealso>
    let useUndergroundService =
        Prefixed_Name(dtx_srti, "useUndergroundService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:temporaryTrafficLights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>Traffic is being controlled by temporary traffic lights (red-yellow-green or red-green).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporaryTrafficLights">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#temporaryTrafficLights</seealso>
    let temporaryTrafficLights =
        Prefixed_Name(dtx_srti, "temporaryTrafficLights") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:administrativeAreaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>Name of an administrative area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAreaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAreaName</seealso>
    let administrativeAreaName =
        Prefixed_Name(dtx_srti, "administrativeAreaName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useBusService</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use bus service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useBusService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useBusService</seealso>
    let useBusService = Prefixed_Name(dtx_srti, "useBusService") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:atBorders</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>At national borders</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atBorders">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atBorders</seealso>
    let atBorders = Prefixed_Name(dtx_srti, "atBorders") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inLowLyingAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In low-lying areas</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inLowLyingAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inLowLyingAreas</seealso>
    let inLowLyingAreas = Prefixed_Name(dtx_srti, "inLowLyingAreas") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:parkingFacilityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a parking facility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkingFacilityName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parkingFacilityName</seealso>
    let parkingFacilityName =
        Prefixed_Name(dtx_srti, "parkingFacilityName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:pointName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a specific point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointName</seealso>
    let pointName = Prefixed_Name(dtx_srti, "pointName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:railwayStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a railway station.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railwayStation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#railwayStation</seealso>
    let railwayStation = Prefixed_Name(dtx_srti, "railwayStation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:regionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a geographic region.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#regionName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#regionName</seealso>
    let regionName = Prefixed_Name(dtx_srti, "regionName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tidalRiverName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a river which is of a tidal nature.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalRiverName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalRiverName</seealso>
    let tidalRiverName = Prefixed_Name(dtx_srti, "tidalRiverName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadOperatorControlArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Road operator control area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorControlArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadOperatorControlArea</seealso>
    let roadOperatorControlArea =
        Prefixed_Name(dtx_srti, "roadOperatorControlArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Sea</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sea</seealso>
    let sea = Prefixed_Name(dtx_srti, "sea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:reasonForDataError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason why the value is deemed to be erroneous by the supplier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reasonForDataError">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reasonForDataError</seealso>
    let reasonForDataError =
        Prefixed_Name(dtx_srti, "reasonForDataError") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:dataError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indication of whether the value is deemed to be erroneous by the supplier (true = erroneous). If not present, the data value is assumed to be ok. This may be used when automatic fault detection information relating to sensors is available.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dataError">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dataError</seealso>
    let dataError = Prefixed_Name(dtx_srti, "dataError") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The extent to which the value is expected to be free from error, measured as a percentage of the data value. 100% means fully accurate.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accuracy</seealso>
    let accuracy = Prefixed_Name(dtx_srti, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:smoothingFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Coefficient required when a moving average is computed to give specific weights to the former average and the new data. A typical formula is, F being the smoothing factor: New average = (old average) F + (new data) (1 - F).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothingFactor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothingFactor</seealso>
    let smoothingFactor = Prefixed_Name(dtx_srti, "smoothingFactor") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:DelayBandEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelayBandEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelayBandEnum</seealso>
    let DelayBandEnum = Prefixed_Name(dtx_srti, "DelayBandEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:delayTimeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of the additional travel time due to adverse travel conditions of any kind, when compared to "normal conditions", given in seconds.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayTimeValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayTimeValue</seealso>
    let delayTimeValue = Prefixed_Name(dtx_srti, "delayTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:DelaysTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coarse classification of the delay.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelaysTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DelaysTypeEnum</seealso>
    let DelaysTypeEnum = Prefixed_Name(dtx_srti, "DelaysTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:waitForEscortVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    ///   <para>Wait for escort vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waitForEscortVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#waitForEscortVehicle</seealso>
    let waitForEscortVehicle =
        Prefixed_Name(dtx_srti, "waitForEscortVehicle") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atHighAltitudes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>At high altitudes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atHighAltitudes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atHighAltitudes</seealso>
    let atHighAltitudes = Prefixed_Name(dtx_srti, "atHighAltitudes") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inForestedAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>On sections of the road where it runs through or adjacent to forested areas</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inForestedAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inForestedAreas</seealso>
    let inForestedAreas = Prefixed_Name(dtx_srti, "inForestedAreas") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inShadedAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In shaded areas</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inShadedAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inShadedAreas</seealso>
    let inShadedAreas = Prefixed_Name(dtx_srti, "inShadedAreas") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onElevatedSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On elevated sections of the road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSections">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onElevatedSections</seealso>
    let onElevatedSections =
        Prefixed_Name(dtx_srti, "onElevatedSections") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onPasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On mountain passes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPasses</seealso>
    let onPasses = Prefixed_Name(dtx_srti, "onPasses") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:securityExercise</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InformationStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The information is part of an exercise which is for testing security.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityExercise">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#securityExercise</seealso>
    let securityExercise = Prefixed_Name(dtx_srti, "securityExercise") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:slipRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>dtx_srti:LinearElementNatureEnum</para>
    ///   <para>Slip Road. The nature of the linear element is a slip road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slipRoad</seealso>
    let slipRoad = Prefixed_Name(dtx_srti, "slipRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:demonstration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DisturbanceActivityTypeEnum</para>
    ///   <para>A public protest with the potential to disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#demonstration">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#demonstration</seealso>
    let demonstration = Prefixed_Name(dtx_srti, "demonstration") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:aboveTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>Above</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveTPEGHeight</seealso>
    let aboveTPEGHeight = Prefixed_Name(dtx_srti, "aboveTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atStreetLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>At street level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atStreetLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atStreetLevelTPEGHeight</seealso>
    let atStreetLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "atStreetLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:belowStreetLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>Height below street level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowStreetLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowStreetLevelTPEGHeight</seealso>
    let belowStreetLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "belowStreetLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:clockwise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>Clockwise.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clockwise">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#clockwise</seealso>
    let clockwise = Prefixed_Name(dtx_srti, "clockwise") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:eastBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>East bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#eastBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#eastBound</seealso>
    let eastBound = Prefixed_Name(dtx_srti, "eastBound") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inboundTowardsTown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>Heading towards town centre direction of travel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inboundTowardsTown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inboundTowardsTown</seealso>
    let inboundTowardsTown =
        Prefixed_Name(dtx_srti, "inboundTowardsTown") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:innerRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Inner ring direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#innerRing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#innerRing</seealso>
    let innerRing = Prefixed_Name(dtx_srti, "innerRing") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:northWestBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>North west bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northWestBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#northWestBound</seealso>
    let northWestBound = Prefixed_Name(dtx_srti, "northWestBound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:opposite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>dtx_srti:LinearDirectionEnum</para>
    ///   <para>Indicates that the direction of traffic flow affected by the situation or related to the traffic data is in the opposite sense to the direction in which the linear element is defined.
    /// Opposite direction to the normal direction of flow at this point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#opposite">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#opposite</seealso>
    let opposite = Prefixed_Name(dtx_srti, "opposite") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:southBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>South bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southBound</seealso>
    let southBound = Prefixed_Name(dtx_srti, "southBound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:southEastBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>South east bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southEastBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southEastBound</seealso>
    let southEastBound = Prefixed_Name(dtx_srti, "southEastBound") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DistanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceAlongLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceAlongLinearElement</seealso>
    let DistanceAlongLinearElement =
        Prefixed_Name(dtx_srti, "DistanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearReferencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes.Package LinearReferencing</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearReferencing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearReferencing</seealso>
    let LinearReferencing = Prefixed_Name(dtx_srti, "LinearReferencing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:MetresAsFloatValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of distance defined in metres in a floating point format.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsFloatValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MetresAsFloatValue</seealso>
    let MetresAsFloatValue =
        Prefixed_Name(dtx_srti, "MetresAsFloatValue") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:distanceAlong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measure of distance along a linear element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#distanceAlong">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#distanceAlong</seealso>
    let distanceAlong = Prefixed_Name(dtx_srti, "distanceAlong") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DistanceFromLinearElementStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from the start node of the linear element, where start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementStart">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementStart</seealso>
    let DistanceFromLinearElementStart =
        Prefixed_Name(dtx_srti, "DistanceFromLinearElementStart") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Enums</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Data Dictionary.This clause contains the definitions of all enumerations which are used.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Enums">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Enums</seealso>
    let Enums = Prefixed_Name(dtx_srti, "Enums") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:EnvironmentalObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of environmental obstructions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#EnvironmentalObstructionTypeEnum</seealso>
    let EnvironmentalObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "EnvironmentalObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:directionRelativeAtPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The direction of traffic flow at the specified point relative to the direction in which the linear element is defined.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeAtPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionRelativeAtPoint</seealso>
    let directionRelativeAtPoint =
        Prefixed_Name(dtx_srti, "directionRelativeAtPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:directionAtPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The direction of traffic flow at the specified point in terms of general destination direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionAtPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionAtPoint</seealso>
    let directionAtPoint = Prefixed_Name(dtx_srti, "directionAtPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDistanceAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Distance of a point along a linear element either measured from the start node or a defined referent on that linear element, where the start node is relative to the element definition rather than the direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElement</seealso>
    let hasDistanceAlongLinearElement =
        Prefixed_Name(dtx_srti, "hasDistanceAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointByCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point defined only by a coordinate set with an optional bearing direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointByCoordinates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointByCoordinates</seealso>
    let PointByCoordinates =
        Prefixed_Name(dtx_srti, "PointByCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasHorizontalPositionAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the horizontal position accuracy according EN 16803-1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHorizontalPositionAccuracy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHorizontalPositionAccuracy</seealso>
    let hasHorizontalPositionAccuracy =
        Prefixed_Name(dtx_srti, "hasHorizontalPositionAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegSimplePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is not bounded by any other points on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegSimplePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegSimplePoint</seealso>
    let TpegSimplePoint = Prefixed_Name(dtx_srti, "TpegSimplePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegSimplePointLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegSimplePointLocationType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegSimplePointLocationType</seealso>
    let tpegSimplePointLocationType =
        Prefixed_Name(dtx_srti, "tpegSimplePointLocationType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A single point defined by a coordinate set and TPEG descriptors.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPoint</seealso>
    let hasTpegPoint = Prefixed_Name(dtx_srti, "hasTpegPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of constriction to which traffic is subjected as a result of an event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficConstrictionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficConstrictionTypeEnum</seealso>
    let TrafficConstrictionTypeEnum =
        Prefixed_Name(dtx_srti, "TrafficConstrictionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:rampMeteringInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>Ramp metering is now active at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rampMeteringInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rampMeteringInOperation</seealso>
    let rampMeteringInOperation =
        Prefixed_Name(dtx_srti, "rampMeteringInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficHeld</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeneralNetworkManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic in the specified direction is temporarily held up due to an unplanned event (e.g. for clearance of wreckage following an accident).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeld">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeld</seealso>
    let trafficHeld = Prefixed_Name(dtx_srti, "trafficHeld") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:administrativeReferenceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Reference name by which administrative area is known.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeReferenceName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeReferenceName</seealso>
    let administrativeReferenceName =
        Prefixed_Name(dtx_srti, "administrativeReferenceName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:expressLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the express lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#expressLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#expressLane</seealso>
    let expressLane = Prefixed_Name(dtx_srti, "expressLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hardShoulder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>On the hard shoulder.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulder">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hardShoulder</seealso>
    let hardShoulder = Prefixed_Name(dtx_srti, "hardShoulder") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:heavyVehicleLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the heavy vehicle lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyVehicleLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#heavyVehicleLane</seealso>
    let heavyVehicleLane = Prefixed_Name(dtx_srti, "heavyVehicleLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:setDownArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the area/lane reserved for passenger pick-up or set-down.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#setDownArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#setDownArea</seealso>
    let setDownArea = Prefixed_Name(dtx_srti, "setDownArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ConfidentialityValueEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>&lt;&lt;enumeration&gt;&gt; Values of confidentiality.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConfidentialityValueEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConfidentialityValueEnum</seealso>
    let ConfidentialityValueEnum =
        Prefixed_Name(dtx_srti, "ConfidentialityValueEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponding coordinates of an OpenLR point defined by its only coordinates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrCoordinates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrCoordinates</seealso>
    let hasOpenlrCoordinates =
        Prefixed_Name(dtx_srti, "hasOpenlrCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrGridLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Area defined using an OpenLR™ method consisting in defining it by a tessellation of rectangles</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGridLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrGridLocationReference</seealso>
    let OpenlrGridLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrGridLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inBuiltUpAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In built up areas, i.e. villages, towns and cities</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inBuiltUpAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inBuiltUpAreas</seealso>
    let inBuiltUpAreas = Prefixed_Name(dtx_srti, "inBuiltUpAreas") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:upToTenMinutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>Delay up to ten minutes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#upToTenMinutes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#upToTenMinutes</seealso>
    let upToTenMinutes = Prefixed_Name(dtx_srti, "upToTenMinutes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Road surface conditions that are not related to the weather but which may affect driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditions</seealso>
    let NonWeatherRelatedRoadConditions =
        Prefixed_Name(dtx_srti, "NonWeatherRelatedRoadConditions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasNonWeatherRelatedRoadConditionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of road conditions which are not related to the weather.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNonWeatherRelatedRoadConditionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNonWeatherRelatedRoadConditionTypeEnum</seealso>
    let hasNonWeatherRelatedRoadConditionTypeEnum =
        Prefixed_Name(dtx_srti, "hasNonWeatherRelatedRoadConditionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inGalleries</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In galleries</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGalleries">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inGalleries</seealso>
    let inGalleries = Prefixed_Name(dtx_srti, "inGalleries") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inTheInnerCityAreas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>In the city centre areas</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheInnerCityAreas">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheInnerCityAreas</seealso>
    let inTheInnerCityAreas =
        Prefixed_Name(dtx_srti, "inTheInnerCityAreas") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onDownhillSections</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On downhill sections of the road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onDownhillSections">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onDownhillSections</seealso>
    let onDownhillSections =
        Prefixed_Name(dtx_srti, "onDownhillSections") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onFlyovers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>On flyover sections of the road, i.e. sections of the road which pass over another road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyovers">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFlyovers</seealso>
    let onFlyovers = Prefixed_Name(dtx_srti, "onFlyovers") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:real</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationStatusEnum</para>
    ///   <para>The information is real. It is not a test or exercise.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#real">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#real</seealso>
    let real = Prefixed_Name(dtx_srti, "real") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationStatusEnum</para>
    ///   <para>The information is part of a test for checking the exchange of this type of information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#test">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#test</seealso>
    let test = Prefixed_Name(dtx_srti, "test") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:multipleCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>Multiple carriageway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#multipleCarriageway</seealso>
    let multipleCarriageway =
        Prefixed_Name(dtx_srti, "multipleCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:singleCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>Single carriageway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#singleCarriageway</seealso>
    let singleCarriageway = Prefixed_Name(dtx_srti, "singleCarriageway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic square</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficSquare">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficSquare</seealso>
    let trafficSquare = Prefixed_Name(dtx_srti, "trafficSquare") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:crowd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DisturbanceActivityTypeEnum</para>
    ///   <para>A major gathering of people that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crowd">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crowd</seealso>
    let crowd = Prefixed_Name(dtx_srti, "crowd") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:evacuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DisturbanceActivityTypeEnum</para>
    ///   <para>A situation where a definite area is being cleared due to dangerous conditions or for security reasons.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#evacuation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#evacuation</seealso>
    let evacuation = Prefixed_Name(dtx_srti, "evacuation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:aboveSeaLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>Height above mean sea high water level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveSeaLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveSeaLevelTPEGHeight</seealso>
    let aboveSeaLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "aboveSeaLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:aboveStreetLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Above street level</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveStreetLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aboveStreetLevelTPEGHeight</seealso>
    let aboveStreetLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "aboveStreetLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>At height of specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atTPEGHeight</seealso>
    let atTPEGHeight = Prefixed_Name(dtx_srti, "atTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:belowSeaLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Height below mean sea high water level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowSeaLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#belowSeaLevelTPEGHeight</seealso>
    let belowSeaLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "belowSeaLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:undefinedTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>Undefined height reference.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefinedTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefinedTPEGHeight</seealso>
    let undefinedTPEGHeight =
        Prefixed_Name(dtx_srti, "undefinedTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>dtx_srti:LinearDirectionEnum</para>
    ///   <para>dtx_srti:MobilityTypeEnum</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>dtx_srti:TrafficTrendTypeEnum</para>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>Perceived by supplier as being of an unknown level.</para>
    ///   <para>Direction is unknown.</para>
    ///   <para>Unknown height reference.</para>
    ///   <para>Driving conditions are unknown.</para>
    ///   <para>Unknow mobility of the describe element of a situation.</para>
    ///   <para>Accident cause is unknown.</para>
    ///   <para>The trend of traffic conditions is currently unknown.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unknown">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unknown</seealso>
    let unknown = Prefixed_Name(dtx_srti, "unknown") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:useSnowChains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>Use snow chains.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChains">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChains</seealso>
    let useSnowChains = Prefixed_Name(dtx_srti, "useSnowChains") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useSnowChainsOrTyres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use snow chains or snow tyres.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChainsOrTyres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowChainsOrTyres</seealso>
    let useSnowChainsOrTyres =
        Prefixed_Name(dtx_srti, "useSnowChainsOrTyres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:both</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LinearDirectionEnum</para>
    ///   <para>dtx_srti:AlertCDirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates that both directions of traffic flow are affected by the situation or relate to the traffic data.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#both">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#both</seealso>
    let both = Prefixed_Name(dtx_srti, "both") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:left</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrSideOfRoadEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On the left side of the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#left">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#left</seealso>
    let left = Prefixed_Name(dtx_srti, "left") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ferry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TransitServiceInformationEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Ferry service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferry</seealso>
    let ferry = Prefixed_Name(dtx_srti, "ferry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:junctionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03JunctionPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a road network junction where two or more roads join.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junctionName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junctionName</seealso>
    let junctionName = Prefixed_Name(dtx_srti, "junctionName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:definedByValidityTimeSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ValidityStatusEnum</para>
    ///   <para>The validity status of the described event, action or item is in accordance with the definition of the validity time specification.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#definedByValidityTimeSpec">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#definedByValidityTimeSpec</seealso>
    let definedByValidityTimeSpec =
        Prefixed_Name(dtx_srti, "definedByValidityTimeSpec") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:planned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ValidityStatusEnum</para>
    ///   <para>The described event, action or item is currently planned regardless of the definition of the validity time specification.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#planned">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#planned</seealso>
    let planned = Prefixed_Name(dtx_srti, "planned") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:brokenDownHeavyLorry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>Broken down heavy lorry/lorries on the carriageway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownHeavyLorry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownHeavyLorry</seealso>
    let brokenDownHeavyLorry =
        Prefixed_Name(dtx_srti, "brokenDownHeavyLorry") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:brokenDownVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>Broken down vehicle(s) on the carriageway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#brokenDownVehicle</seealso>
    let brokenDownVehicle = Prefixed_Name(dtx_srti, "brokenDownVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:militaryConvoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>A group of military vehicles moving together in formation which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#militaryConvoy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#militaryConvoy</seealso>
    let militaryConvoy = Prefixed_Name(dtx_srti, "militaryConvoy") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:slowVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A vehicle travelling at well below normal highway speeds which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicle</seealso>
    let slowVehicle = Prefixed_Name(dtx_srti, "slowVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vehicleOnFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>A vehicle is or has been on fire and may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnFire">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnFire</seealso>
    let vehicleOnFire = Prefixed_Name(dtx_srti, "vehicleOnFire") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleOnWrongCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A vehicle is travelling the wrong way along a divided highway (i.e. on the wrong side).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnWrongCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleOnWrongCarriageway</seealso>
    let vehicleOnWrongCarriageway =
        Prefixed_Name(dtx_srti, "vehicleOnWrongCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadBlocked</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road is totally obstructed, for all vehicles in both directions, due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadBlocked">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadBlocked</seealso>
    let roadBlocked = Prefixed_Name(dtx_srti, "roadBlocked") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:roadPartiallyObstructed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>The road is partially obstructed in both directions due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadPartiallyObstructed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadPartiallyObstructed</seealso>
    let roadPartiallyObstructed =
        Prefixed_Name(dtx_srti, "roadPartiallyObstructed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Arithmetic average of sample values based on a fixed number of samples.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples</seealso>
    let arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples =
        Prefixed_Name(dtx_srti, "arithmeticAverageOfSamplesBasedOnAFixedNumberOfSamples") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:arithmeticAverageOfSamplesInATimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Arithmetic average of sample values in a time period.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesInATimePeriod">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#arithmeticAverageOfSamplesInATimePeriod</seealso>
    let arithmeticAverageOfSamplesInATimePeriod =
        Prefixed_Name(dtx_srti, "arithmeticAverageOfSamplesInATimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damagedAndImmobililized</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle is damaged following an incident or collision. It is immobilized and therefore needs assistance to be moved.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedAndImmobililized">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedAndImmobililized</seealso>
    let damagedAndImmobililized =
        Prefixed_Name(dtx_srti, "damagedAndImmobililized") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:jacknifed</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The pulling vehicle is in a jackknifed position with its trailer</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#jacknifed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#jacknifed</seealso>
    let jacknifed = Prefixed_Name(dtx_srti, "jacknifed") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onFire</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Vehicle is on fire.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFire">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onFire</seealso>
    let onFire = Prefixed_Name(dtx_srti, "onFire") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:overturned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    ///   <para>Vehicle is on its side or upside down</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overturned">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overturned</seealso>
    let overturned = Prefixed_Name(dtx_srti, "overturned") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:damagedGantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Damage to a gantry above the roadway that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGantry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGantry</seealso>
    let damagedGantry = Prefixed_Name(dtx_srti, "damagedGantry") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damagedRoadSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>Damage to the road surface that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedRoadSurface">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedRoadSurface</seealso>
    let damagedRoadSurface =
        Prefixed_Name(dtx_srti, "damagedRoadSurface") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damagedTunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Damage to a tunnel that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedTunnel">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedTunnel</seealso>
    let damagedTunnel = Prefixed_Name(dtx_srti, "damagedTunnel") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:damagedViaduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Damage to a viaduct that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedViaduct">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedViaduct</seealso>
    let damagedViaduct = Prefixed_Name(dtx_srti, "damagedViaduct") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>Third class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc3">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc3</seealso>
    let frc3 = Prefixed_Name(dtx_srti, "frc3") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>Fourth class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc4">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc4</seealso>
    let frc4 = Prefixed_Name(dtx_srti, "frc4") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc5</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Fifth class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc5">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc5</seealso>
    let frc5 = Prefixed_Name(dtx_srti, "frc5") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>Sixth class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc6">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc6</seealso>
    let frc6 = Prefixed_Name(dtx_srti, "frc6") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:high</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Perceived by supplier as being of a high level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#high">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#high</seealso>
    let high = Prefixed_Name(dtx_srti, "high") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:highest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>Perceived by supplier as being of the highest level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highest">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#highest</seealso>
    let highest = Prefixed_Name(dtx_srti, "highest") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:low</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>Perceived by supplier as being of a low level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#low">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#low</seealso>
    let low = Prefixed_Name(dtx_srti, "low") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lowest</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Perceived by supplier as being of the lowest discernible level.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lowest">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lowest</seealso>
    let lowest = Prefixed_Name(dtx_srti, "lowest") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:autonomousCityInNorthAfrica</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Autonomous city in North Africa</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCityInNorthAfrica">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCityInNorthAfrica</seealso>
    let autonomousCityInNorthAfrica =
        Prefixed_Name(dtx_srti, "autonomousCityInNorthAfrica") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:autonomousCommunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Autonomous community</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCommunity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCommunity</seealso>
    let autonomousCommunity =
        Prefixed_Name(dtx_srti, "autonomousCommunity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:autonomousDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Autonomous district</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousDistrict">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousDistrict</seealso>
    let autonomousDistrict =
        Prefixed_Name(dtx_srti, "autonomousDistrict") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:autonomousProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Autonomous province</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousProvince">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousProvince</seealso>
    let autonomousProvince =
        Prefixed_Name(dtx_srti, "autonomousProvince") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:cityOfCountyRight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>City of county right</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityOfCountyRight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityOfCountyRight</seealso>
    let cityOfCountyRight = Prefixed_Name(dtx_srti, "cityOfCountyRight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:commune</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Commune</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commune">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commune</seealso>
    let commune = Prefixed_Name(dtx_srti, "commune") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:councilArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Council area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#councilArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#councilArea</seealso>
    let councilArea = Prefixed_Name(dtx_srti, "councilArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>EN ISO 3166-1 two-character country code.</para>
    ///   <para>Country</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#country">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#country</seealso>
    let country = Prefixed_Name(dtx_srti, "country") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Entity</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#entity</seealso>
    let entity = Prefixed_Name(dtx_srti, "entity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:geographicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Geographical entity</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geographicalEntity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geographicalEntity</seealso>
    let geographicalEntity =
        Prefixed_Name(dtx_srti, "geographicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:governorate</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Governorate</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#governorate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#governorate</seealso>
    let governorate = Prefixed_Name(dtx_srti, "governorate") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:laender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Länder</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laender">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laender</seealso>
    let laender = Prefixed_Name(dtx_srti, "laender") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:localCouncil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Local Council</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localCouncil">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localCouncil</seealso>
    let localCouncil = Prefixed_Name(dtx_srti, "localCouncil") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:londonBorough</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>London borough</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#londonBorough">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#londonBorough</seealso>
    let londonBorough = Prefixed_Name(dtx_srti, "londonBorough") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:metropolitanArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Metropolitan area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanArea</seealso>
    let metropolitanArea = Prefixed_Name(dtx_srti, "metropolitanArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:metropolitanDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Metropolitan department</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDepartment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDepartment</seealso>
    let metropolitanDepartment =
        Prefixed_Name(dtx_srti, "metropolitanDepartment") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Republic</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republic</seealso>
    let republic = Prefixed_Name(dtx_srti, "republic") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:republicanCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Republic city</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republicanCity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#republicanCity</seealso>
    let republicanCity = Prefixed_Name(dtx_srti, "republicanCity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:selfGovernedPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Self-governed part</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#selfGovernedPart">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#selfGovernedPart</seealso>
    let selfGovernedPart = Prefixed_Name(dtx_srti, "selfGovernedPart") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:specialMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Special Municipality</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specialMunicipality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specialMunicipality</seealso>
    let specialMunicipality =
        Prefixed_Name(dtx_srti, "specialMunicipality") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>State</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#state">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#state</seealso>
    let state = Prefixed_Name(dtx_srti, "state") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:territorialUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Territorial unit</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territorialUnit">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territorialUnit</seealso>
    let territorialUnit = Prefixed_Name(dtx_srti, "territorialUnit") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Territory</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territory">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#territory</seealso>
    let territory = Prefixed_Name(dtx_srti, "territory") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:twoTierCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Two tier country</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoTierCounty">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#twoTierCounty</seealso>
    let twoTierCounty = Prefixed_Name(dtx_srti, "twoTierCounty") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:athleticsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Athletics event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#athleticsMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#athleticsMeeting</seealso>
    let athleticsMeeting = Prefixed_Name(dtx_srti, "athleticsMeeting") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ballGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Ball game event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ballGame">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ballGame</seealso>
    let ballGame = Prefixed_Name(dtx_srti, "ballGame") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:baseballGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Baseball game event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#baseballGame">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#baseballGame</seealso>
    let baseballGame = Prefixed_Name(dtx_srti, "baseballGame") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:basketballGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Basketball game event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#basketballGame">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#basketballGame</seealso>
    let basketballGame = Prefixed_Name(dtx_srti, "basketballGame") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bicycleRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bicycle race that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycleRace">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bicycleRace</seealso>
    let bicycleRace = Prefixed_Name(dtx_srti, "bicycleRace") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:boatRace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Regatta (boat race event of sailing, powerboat or rowing) that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatRace">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatRace</seealso>
    let boatRace = Prefixed_Name(dtx_srti, "boatRace") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:boatShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Boat show which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatShow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boatShow</seealso>
    let boatShow = Prefixed_Name(dtx_srti, "boatShow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:boxingTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Boxing event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boxingTournament">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boxingTournament</seealso>
    let boxingTournament = Prefixed_Name(dtx_srti, "boxingTournament") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:filmTVMaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Film or TV making event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#filmTVMaking">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#filmTVMaking</seealso>
    let filmTVMaking = Prefixed_Name(dtx_srti, "filmTVMaking") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:footballMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Football match that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footballMatch">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#footballMatch</seealso>
    let footballMatch = Prefixed_Name(dtx_srti, "footballMatch") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:funfair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Periodic (e.g. annual), often traditional, gathering for entertainment, which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#funfair">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#funfair</seealso>
    let funfair = Prefixed_Name(dtx_srti, "funfair") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:gardeningOrFlowerShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Gardening and/or flower show or event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gardeningOrFlowerShow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gardeningOrFlowerShow</seealso>
    let gardeningOrFlowerShow =
        Prefixed_Name(dtx_srti, "gardeningOrFlowerShow") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:golfTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Golf tournament event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#golfTournament">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#golfTournament</seealso>
    let golfTournament = Prefixed_Name(dtx_srti, "golfTournament") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hockeyGame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Hockey game event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hockeyGame">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hockeyGame</seealso>
    let hockeyGame = Prefixed_Name(dtx_srti, "hockeyGame") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:horseRaceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Horse race meeting that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#horseRaceMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#horseRaceMeeting</seealso>
    let horseRaceMeeting = Prefixed_Name(dtx_srti, "horseRaceMeeting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:internationalSportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Large sporting event of an international nature that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internationalSportsMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#internationalSportsMeeting</seealso>
    let internationalSportsMeeting =
        Prefixed_Name(dtx_srti, "internationalSportsMeeting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:severalMajorEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>A series of significant organised events either on or near the roadway which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#severalMajorEvents">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#severalMajorEvents</seealso>
    let severalMajorEvents =
        Prefixed_Name(dtx_srti, "severalMajorEvents") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:show</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Entertainment event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#show">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#show</seealso>
    let show = Prefixed_Name(dtx_srti, "show") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:showJumping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Horse showing jumping and tournament event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#showJumping">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#showJumping</seealso>
    let showJumping = Prefixed_Name(dtx_srti, "showJumping") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:sportsMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Sports event of unspecified type that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sportsMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sportsMeeting</seealso>
    let sportsMeeting = Prefixed_Name(dtx_srti, "sportsMeeting") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:stateOccasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Public ceremony or visit of national or international significance which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stateOccasion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stateOccasion</seealso>
    let stateOccasion = Prefixed_Name(dtx_srti, "stateOccasion") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tennisTournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Tennis tournament that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tennisTournament">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tennisTournament</seealso>
    let tennisTournament = Prefixed_Name(dtx_srti, "tennisTournament") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tournament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Sporting event or series of events of unspecified type lasting more than one day which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tournament">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tournament</seealso>
    let tournament = Prefixed_Name(dtx_srti, "tournament") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tradeFair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>A periodic (e.g. annual), often traditional, gathering for trade promotion, which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tradeFair">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tradeFair</seealso>
    let tradeFair = Prefixed_Name(dtx_srti, "tradeFair") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:queuingTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>Traffic is queuing at the specified location, although there is still some traffic movement (i.e. average speed is between 10% and 25% of its free-flow level).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queuingTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#queuingTraffic</seealso>
    let queuingTraffic = Prefixed_Name(dtx_srti, "queuingTraffic") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:slowTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic is slow moving at the specified location, but not yet forming queues (i.e. average speed is between 25% and 75% of its free-flow level).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowTraffic</seealso>
    let slowTraffic = Prefixed_Name(dtx_srti, "slowTraffic") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:stationaryTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>Traffic is stationary, or very near stationary, at the specified location (i.e. average speed is less than 10% of its free-flow level).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationaryTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationaryTraffic</seealso>
    let stationaryTraffic = Prefixed_Name(dtx_srti, "stationaryTraffic") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:unspecifiedAbnormalTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>There are abnormal traffic conditions of an unspecified nature at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedAbnormalTraffic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#unspecifiedAbnormalTraffic</seealso>
    let unspecifiedAbnormalTraffic =
        Prefixed_Name(dtx_srti, "unspecifiedAbnormalTraffic") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:blastingWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ConstructionWorkTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Blasting or quarrying work at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blastingWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blastingWork</seealso>
    let blastingWork = Prefixed_Name(dtx_srti, "blastingWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:constructionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ConstructionWorkTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Construction work of a general nature at the specified location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#constructionWork</seealso>
    let constructionWork = Prefixed_Name(dtx_srti, "constructionWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:mobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:MobilityTypeEnum</para>
    ///   <para>The described element of a situation is moving.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobile">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mobile</seealso>
    let mobile = Prefixed_Name(dtx_srti, "mobile") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:limitedVisibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Limited or impaired visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#limitedVisibility">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#limitedVisibility</seealso>
    let limitedVisibility = Prefixed_Name(dtx_srti, "limitedVisibility") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:notKeepingASafeDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Not keeping a safe distance from the vehicle in front.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#notKeepingASafeDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#notKeepingASafeDistance</seealso>
    let notKeepingASafeDistance =
        Prefixed_Name(dtx_srti, "notKeepingASafeDistance") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onTheWrongSideOfTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Driving on the wrong side of the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheWrongSideOfTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheWrongSideOfTheRoad</seealso>
    let onTheWrongSideOfTheRoad =
        Prefixed_Name(dtx_srti, "onTheWrongSideOfTheRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:pedestrianInRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Pedestrian in the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pedestrianInRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pedestrianInRoad</seealso>
    let pedestrianInRoad = Prefixed_Name(dtx_srti, "pedestrianInRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:poorLaneAdherence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Not keeping to lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorLaneAdherence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorLaneAdherence</seealso>
    let poorLaneAdherence = Prefixed_Name(dtx_srti, "poorLaneAdherence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:poorMergeEntryOrExitJudgement</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Poor judgement when merging at an entry or exit point of a carriageway or junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorMergeEntryOrExitJudgement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorMergeEntryOrExitJudgement</seealso>
    let poorMergeEntryOrExitJudgement =
        Prefixed_Name(dtx_srti, "poorMergeEntryOrExitJudgement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:poorRoadSurfaceCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Poor road surface condition.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorRoadSurfaceCondition">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#poorRoadSurfaceCondition</seealso>
    let poorRoadSurfaceCondition =
        Prefixed_Name(dtx_srti, "poorRoadSurfaceCondition") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:medicalStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A member of the medical service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medicalStaff">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medicalStaff</seealso>
    let medicalStaff = Prefixed_Name(dtx_srti, "medicalStaff") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:memberOfThePublic</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A member of the general public.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#memberOfThePublic">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#memberOfThePublic</seealso>
    let memberOfThePublic = Prefixed_Name(dtx_srti, "memberOfThePublic") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:policeman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A member of the police force.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeman">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeman</seealso>
    let policeman = Prefixed_Name(dtx_srti, "policeman") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:politician</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A politician.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#politician">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#politician</seealso>
    let politician = Prefixed_Name(dtx_srti, "politician") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:publicTransportPassenger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A passenger on or from a public transport vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportPassenger">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#publicTransportPassenger</seealso>
    let publicTransportPassenger =
        Prefixed_Name(dtx_srti, "publicTransportPassenger") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:sickPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A sick person.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sickPerson">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sickPerson</seealso>
    let sickPerson = Prefixed_Name(dtx_srti, "sickPerson") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A traffic patrol officer of the road authority.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficOfficer">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficOfficer</seealso>
    let trafficOfficer = Prefixed_Name(dtx_srti, "trafficOfficer") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficWarden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A member of the local traffic warden service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficWarden">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficWarden</seealso>
    let trafficWarden = Prefixed_Name(dtx_srti, "trafficWarden") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan10Centimetres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 10 centimetres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Centimetres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Centimetres</seealso>
    let equalToOrLessThan10Centimetres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan10Centimetres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan10Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 10 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan10Metres</seealso>
    let equalToOrLessThan10Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan10Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan1Centimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 1 centimetre</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Centimetre">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Centimetre</seealso>
    let equalToOrLessThan1Centimetre =
        Prefixed_Name(dtx_srti, "equalToOrLessThan1Centimetre") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan1Metre</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 1 metre</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Metre">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan1Metre</seealso>
    let equalToOrLessThan1Metre =
        Prefixed_Name(dtx_srti, "equalToOrLessThan1Metre") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan200Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 200 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan200Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan200Metres</seealso>
    let equalToOrLessThan200Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan200Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan20Centimetres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 20 centimetres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Centimetres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Centimetres</seealso>
    let equalToOrLessThan20Centimetres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan20Centimetres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan20Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 20 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan20Metres</seealso>
    let equalToOrLessThan20Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan20Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan2Centimetres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 2 centimetres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Centimetres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Centimetres</seealso>
    let equalToOrLessThan2Centimetres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan2Centimetres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan2Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 2 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan2Metres</seealso>
    let equalToOrLessThan2Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan2Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan50Centimetres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 50 centimetres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Centimetres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Centimetres</seealso>
    let equalToOrLessThan50Centimetres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan50Centimetres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan50Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 50 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan50Metres</seealso>
    let equalToOrLessThan50Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan50Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan5Centimetres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 5 centimetres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Centimetres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Centimetres</seealso>
    let equalToOrLessThan5Centimetres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan5Centimetres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:equalToOrLessThan5Metres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AltitudeAccuracyEnum</para>
    ///   <para>Indicates if the altitude accuracy is equal to or less than 5 metres</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Metres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#equalToOrLessThan5Metres</seealso>
    let equalToOrLessThan5Metres =
        Prefixed_Name(dtx_srti, "equalToOrLessThan5Metres") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:inTheCentre</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RelativePositionOnCarriagewayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the centre of the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheCentre">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTheCentre</seealso>
    let inTheCentre = Prefixed_Name(dtx_srti, "inTheCentre") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onTheLeft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RelativePositionOnCarriagewayEnum</para>
    ///   <para>On the left of the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheLeft">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onTheLeft</seealso>
    let onTheLeft = Prefixed_Name(dtx_srti, "onTheLeft") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:airportName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of an airport.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airportName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airportName</seealso>
    let airportName = Prefixed_Name(dtx_srti, "airportName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:areaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaName</seealso>
    let areaName = Prefixed_Name(dtx_srti, "areaName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:buildingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a building.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buildingName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buildingName</seealso>
    let buildingName = Prefixed_Name(dtx_srti, "buildingName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:busStopIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Identifier of a bus stop on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopIdentifier</seealso>
    let busStopIdentifier = Prefixed_Name(dtx_srti, "busStopIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:busStopName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a bus stop on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#busStopName</seealso>
    let busStopName = Prefixed_Name(dtx_srti, "busStopName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:canalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a canal.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canalName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canalName</seealso>
    let canalName = Prefixed_Name(dtx_srti, "canalName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:countyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a county (administrative sub-division).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countyName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countyName</seealso>
    let countyName = Prefixed_Name(dtx_srti, "countyName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ferryPortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a ferry port.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferryPortName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ferryPortName</seealso>
    let ferryPortName = Prefixed_Name(dtx_srti, "ferryPortName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:intersectionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a road network intersection.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersectionName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersectionName</seealso>
    let intersectionName = Prefixed_Name(dtx_srti, "intersectionName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lakeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a lake.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lakeName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lakeName</seealso>
    let lakeName = Prefixed_Name(dtx_srti, "lakeName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:linkName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a road link.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linkName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linkName</seealso>
    let linkName = Prefixed_Name(dtx_srti, "linkName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:localLinkName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Local name of a road link.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localLinkName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#localLinkName</seealso>
    let localLinkName = Prefixed_Name(dtx_srti, "localLinkName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:metroStationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a metro/underground station.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metroStationName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metroStationName</seealso>
    let metroStationName = Prefixed_Name(dtx_srti, "metroStationName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    ///   <para>Name of a nation (e.g. Wales) which is a sub-division of a ISO recognised country.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationName</seealso>
    let nationName = Prefixed_Name(dtx_srti, "nationName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:nonLinkedPointName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>Name of a point on the road network which is not at a junction or intersection.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPointName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPointName</seealso>
    let nonLinkedPointName =
        Prefixed_Name(dtx_srti, "nonLinkedPointName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    ///   <para>A boundary between two jurisdictional or administrative areas. These may be legal boundaries such as between counties or countries, maintenance responsibility boundaries or control boundaries.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boundary">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#boundary</seealso>
    let boundary = Prefixed_Name(dtx_srti, "boundary") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:intersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc01SimplePointLocationSubtypeEnum</para>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    ///   <para>A crossing of two or more roads where the precise point of intersection is defined according to specific business rules.
    ///
    /// An point on the road network at which one or more roads intersect.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#intersection</seealso>
    let intersection = Prefixed_Name(dtx_srti, "intersection") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:landmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    ///   <para>A visible identifiable physical landmark either alongside or close to the linear object.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landmark">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#landmark</seealso>
    let landmark = Prefixed_Name(dtx_srti, "landmark") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:referenceMarker</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A marker which is usually but not necessarily physical that is one of a sequence which are spaced out along the linear object (road) to provide a location reference. The spacing of markers is not necessarily even.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referenceMarker">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referenceMarker</seealso>
    let referenceMarker = Prefixed_Name(dtx_srti, "referenceMarker") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A topological node defined on a road network. Such nodes may delineate the segmentation of the road network according to defined business rules or may constitute a purely topological representation of a road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadNode">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadNode</seealso>
    let roadNode = Prefixed_Name(dtx_srti, "roadNode") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nonLinkedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc01SimplePointLocationSubtypeEnum</para>
    ///   <para>A point on the road network which is not at a junction or intersection.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nonLinkedPoint</seealso>
    let nonLinkedPoint = Prefixed_Name(dtx_srti, "nonLinkedPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:observeSpeedLimits</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SpeedManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Observe speed limit.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSpeedLimits">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#observeSpeedLimits</seealso>
    let observeSpeedLimits =
        Prefixed_Name(dtx_srti, "observeSpeedLimits") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:policeSpeedChecksInOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SpeedManagementTypeEnum</para>
    ///   <para>Police speed checks are in operation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeSpeedChecksInOperation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policeSpeedChecksInOperation</seealso>
    let policeSpeedChecksInOperation =
        Prefixed_Name(dtx_srti, "policeSpeedChecksInOperation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:reduceYourSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SpeedManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Reduce your speed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reduceYourSpeed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reduceYourSpeed</seealso>
    let reduceYourSpeed = Prefixed_Name(dtx_srti, "reduceYourSpeed") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:aligned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LinearDirectionEnum</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>Same direction as the normal direction of flow at this point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aligned">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aligned</seealso>
    let aligned = Prefixed_Name(dtx_srti, "aligned") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:allDirections</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>All directions (where more than two are applicable) at this point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allDirections">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allDirections</seealso>
    let allDirections = Prefixed_Name(dtx_srti, "allDirections") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:anticlockwise</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Anti-clockwise.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anticlockwise">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anticlockwise</seealso>
    let anticlockwise = Prefixed_Name(dtx_srti, "anticlockwise") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bothWays</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Both directions that are applicable at this point on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothWays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bothWays</seealso>
    let bothWays = Prefixed_Name(dtx_srti, "bothWays") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:southWestBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>South west bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southWestBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#southWestBound</seealso>
    let southWestBound = Prefixed_Name(dtx_srti, "southWestBound") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:westBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DirectionEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>West bound general direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#westBound">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#westBound</seealso>
    let westBound = Prefixed_Name(dtx_srti, "westBound") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:maintenanceVehiclesMergingIntoTrafficFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Maintenance vehicles are merging into the traffic flow creating a potential hazard for road users.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceVehiclesMergingIntoTrafficFlow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#maintenanceVehiclesMergingIntoTrafficFlow</seealso>
    let maintenanceVehiclesMergingIntoTrafficFlow =
        Prefixed_Name(dtx_srti, "maintenanceVehiclesMergingIntoTrafficFlow") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:saltAndGritSpreading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    ///   <para>Maintenance vehicle(s) are spreading salt and/or grit.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#saltAndGritSpreading">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#saltAndGritSpreading</seealso>
    let saltAndGritSpreading =
        Prefixed_Name(dtx_srti, "saltAndGritSpreading") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:slowMoving</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Maintenance vehicles are slow moving.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowMoving">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowMoving</seealso>
    let slowMoving = Prefixed_Name(dtx_srti, "slowMoving") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:snowClearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Maintenance vehicle(s) are involved in the clearance of snow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowClearing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowClearing</seealso>
    let snowClearing = Prefixed_Name(dtx_srti, "snowClearing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:stoppingToServiceEquipments</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:MaintenanceVehicleActionsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Maintenance vehicles are stopping to service equipments on or next to the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stoppingToServiceEquipments">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stoppingToServiceEquipments</seealso>
    let stoppingToServiceEquipments =
        Prefixed_Name(dtx_srti, "stoppingToServiceEquipments") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AlertCDirectionEnum</para>
    ///   <para>The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negative">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#negative</seealso>
    let negative = Prefixed_Name(dtx_srti, "negative") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:positive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AlertCDirectionEnum</para>
    ///   <para>The direction of navigation in an ALERT-C table that corresponds to the negative offset usage to go from the secondary location to the primary location within the ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#positive">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#positive</seealso>
    let positive = Prefixed_Name(dtx_srti, "positive") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:accident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    ///   <para>Accidents are situations in which one or more vehicles lose control and do not recover.  They include collisions between vehicle(s) or other road user(s), between vehicle(s) and fixed obstacle(s), or they result from a vehicle running off the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accident">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accident</seealso>
    let accident = Prefixed_Name(dtx_srti, "accident") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accidentInvolvingHazardousMaterials</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Includes all accidents involving at least one vehicle believed to be carrying materials, which could present an additional hazard to road users.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHazardousMaterials">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHazardousMaterials</seealso>
    let accidentInvolvingHazardousMaterials =
        Prefixed_Name(dtx_srti, "accidentInvolvingHazardousMaterials") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accidentInvolvingHeavyLorries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    ///   <para>Includes all accidents involving at least one heavy goods vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHeavyLorries">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingHeavyLorries</seealso>
    let accidentInvolvingHeavyLorries =
        Prefixed_Name(dtx_srti, "accidentInvolvingHeavyLorries") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:collision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    ///   <para>Collision of vehicle with another object of unspecified type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collision">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#collision</seealso>
    let collision = Prefixed_Name(dtx_srti, "collision") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vandalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:CauseTypeEnum</para>
    ///   <para>A vandalism incident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vandalism">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vandalism</seealso>
    let vandalism = Prefixed_Name(dtx_srti, "vandalism") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bridge on, over or under the highway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridge">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bridge</seealso>
    let bridge = Prefixed_Name(dtx_srti, "bridge") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:buriedCables</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Buried cables under or along the highway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedCables">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedCables</seealso>
    let buriedCables = Prefixed_Name(dtx_srti, "buriedCables") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:buriedServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Unspecified buried services on, under or along the highway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedServices">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#buriedServices</seealso>
    let buriedServices = Prefixed_Name(dtx_srti, "buriedServices") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:crashBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Crash barrier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crashBarrier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crashBarrier</seealso>
    let crashBarrier = Prefixed_Name(dtx_srti, "crashBarrier") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Gallery.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gallery">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gallery</seealso>
    let gallery = Prefixed_Name(dtx_srti, "gallery") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Gantry over or above the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gantry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gantry</seealso>
    let gantry = Prefixed_Name(dtx_srti, "gantry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gasMainWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Gas mains.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasMainWork">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gasMainWork</seealso>
    let gasMainWork = Prefixed_Name(dtx_srti, "gasMainWork") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:interchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Motorway or major road interchange.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#interchange">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#interchange</seealso>
    let interchange = Prefixed_Name(dtx_srti, "interchange") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:junction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Motorway or major road junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#junction</seealso>
    let junction = Prefixed_Name(dtx_srti, "junction") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:levelCrossing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Level-crossing or associated equipment.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#levelCrossing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#levelCrossing</seealso>
    let levelCrossing = Prefixed_Name(dtx_srti, "levelCrossing") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lightingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Road lighting system.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lightingSystem">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lightingSystem</seealso>
    let lightingSystem = Prefixed_Name(dtx_srti, "lightingSystem") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:measurementEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Equipment used for determining traffic measurements.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#measurementEquipment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#measurementEquipment</seealso>
    let measurementEquipment =
        Prefixed_Name(dtx_srti, "measurementEquipment") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:noiseProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Installations along the roadway designed to reduce road noise in the surrounding environment.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noiseProtection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#noiseProtection</seealso>
    let noiseProtection = Prefixed_Name(dtx_srti, "noiseProtection") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>dtx_srti:LinearElementNatureEnum</para>
    ///   <para>road</para>
    ///   <para>The nature of the linear element is a road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#road">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#road</seealso>
    let road = Prefixed_Name(dtx_srti, "road") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCDirectionEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Direction used to reach the primary location from the secondary location in ALERT-C location table, as defined in CEN ISO 14819-1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirectionEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCDirectionEnum</seealso>
    let AlertCDirectionEnum =
        Prefixed_Name(dtx_srti, "AlertCDirectionEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCDirectionCoded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Direction of navigation with respect to secondary to primary location (RDS direction)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirectionCoded">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirectionCoded</seealso>
    let hasAlertCDirectionCoded =
        Prefixed_Name(dtx_srti, "hasAlertCDirectionCoded") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearDirectionEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Directions of traffic flow relative to the direction in which the linear element is defined.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearDirectionEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearDirectionEnum</seealso>
    let LinearDirectionEnum =
        Prefixed_Name(dtx_srti, "LinearDirectionEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCAffectedDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The direction(s) of traffic flow to which the situation, traffic data or information is related.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCAffectedDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCAffectedDirection</seealso>
    let hasAlertCAffectedDirection =
        Prefixed_Name(dtx_srti, "hasAlertCAffectedDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LocationReferencingEnumerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencingEnumerations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencingEnumerations</seealso>
    let LocationReferencingEnumerations =
        Prefixed_Name(dtx_srti, "LocationReferencingEnumerations") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road defined between two points on the road by reference to a pre-defined ALERT-C location table. When there are multiple instances of AlertCLinear they should represent the same location using different location tables.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinear</seealso>
    let AlertCLinear = Prefixed_Name(dtx_srti, "AlertCLinear") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCLinearByCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road defined by reference to a linear section in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinearByCode">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCLinearByCode</seealso>
    let AlertCLinearByCode =
        Prefixed_Name(dtx_srti, "AlertCLinearByCode") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLocationCodeForLinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specific location. Unique code within the ALERT-C location table which identifies the specific point, linear or area location.Unique code within the ALERT-C location table which identifies the specific point, linear or area location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationCodeForLinearLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationCodeForLinearLocation</seealso>
    let hasLocationCodeForLinearLocation =
        Prefixed_Name(dtx_srti, "hasLocationCodeForLinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ALERT-C direction</para>
    ///   <para>The direction of traffic flow along the road to which the information relates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCDirection</seealso>
    let hasAlertCDirection =
        Prefixed_Name(dtx_srti, "hasAlertCDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod2Linear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a road between two points, primary and secondary, which are pre-defined in an ALERT-C location table. Direction is FROM the secondary point TO the primary point, i.e. the primary point is downstream of the secondary point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Linear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2Linear</seealso>
    let AlertCMethod2Linear =
        Prefixed_Name(dtx_srti, "AlertCMethod2Linear") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod2SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2SecondaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2SecondaryPointLocation</seealso>
    let AlertCMethod2SecondaryPointLocation =
        Prefixed_Name(dtx_srti, "AlertCMethod2SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCMethod2SecondaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ALERT-C method2 secondary point location</para>
    ///   <para>The point (called Secondary point) which is at the upstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2SecondaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2SecondaryPointLocation</seealso>
    let hasAlertCMethod2SecondaryPointLocation =
        Prefixed_Name(dtx_srti, "hasAlertCMethod2SecondaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AlertCMethod2PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2PrimaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AlertCMethod2PrimaryPointLocation</seealso>
    let AlertCMethod2PrimaryPointLocation =
        Prefixed_Name(dtx_srti, "AlertCMethod2PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAlertCMethod2PrimaryPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The point (called Primary point) which is either a single point or at the downstream end of a linear road section. The point is specified by a reference to a point in a pre-defined ALERT-C location table.</para>
    ///   <para>ALERT-C method2 primary point location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2PrimaryPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCMethod2PrimaryPointLocation</seealso>
    let hasAlertCMethod2PrimaryPointLocation =
        Prefixed_Name(dtx_srti, "hasAlertCMethod2PrimaryPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ImportedClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ImportedClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ImportedClasses</seealso>
    let ImportedClasses = Prefixed_Name(dtx_srti, "ImportedClasses") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Geo_WGS84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geo WGS84 vocabulary</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Geo_WGS84">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Geo_WGS84</seealso>
    let Geo_WGS84 = Prefixed_Name(dtx_srti, "Geo_WGS84") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeographicCharacteristicEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptor to help to identify a specific location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeographicCharacteristicEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeographicCharacteristicEnum</seealso>
    let GeographicCharacteristicEnum =
        Prefixed_Name(dtx_srti, "GeographicCharacteristicEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Gml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>GML location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Gml">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Gml</seealso>
    let Gml = Prefixed_Name(dtx_srti, "Gml") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:GmlLineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLineString">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLineString</seealso>
    let GmlLineString = Prefixed_Name(dtx_srti, "GmlLineString") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:srsName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the Coordinate Reference System (CRS) used to interpret the coordinates in this GmlLineString</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsName</seealso>
    let srsName = Prefixed_Name(dtx_srti, "srsName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:srsDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the size of the tuple of coordinates of each point. This number is 2 or 3. By default when omitted the dimension shall be interpreted as 2.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsDimension">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#srsDimension</seealso>
    let srsDimension = Prefixed_Name(dtx_srti, "srsDimension") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gmlPosList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>List of coordinate Tuples define the geometry of this GmlLineString. There must be at least 2 Tuples of coordinates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlPosList">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlPosList</seealso>
    let gmlPosList = Prefixed_Name(dtx_srti, "gmlPosList") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:GmlLinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Closed line string not self-intersecting (i.e. having as last point the first point)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLinearRing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlLinearRing</seealso>
    let GmlLinearRing = Prefixed_Name(dtx_srti, "GmlLinearRing") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:gmlAreaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the multi-polygon area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlAreaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#gmlAreaName</seealso>
    let gmlAreaName = Prefixed_Name(dtx_srti, "gmlAreaName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:GmlPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Planar surface defined by 1 exterior boundary and 0 or more interior boundaries</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlPolygon">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GmlPolygon</seealso>
    let GmlPolygon = Prefixed_Name(dtx_srti, "GmlPolygon") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasGmlPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Planar surface defined by 1 exterior boundary and 0 or more interior boundaries</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlPolygon">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlPolygon</seealso>
    let hasGmlPolygon = Prefixed_Name(dtx_srti, "hasGmlPolygon") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGmlExteriorLinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A boundary of a polygonal surface consisting of a ring i.e. in the normal 2D case, a closed polygonal line distinguished as exterior. Such a polygonal line has at least 4 pairs of coordinates</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlExteriorLinearRing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlExteriorLinearRing</seealso>
    let hasGmlExteriorLinearRing =
        Prefixed_Name(dtx_srti, "hasGmlExteriorLinearRing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PositionAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Horizontal position accuracy parameters defined according to EN 16803-1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionAccuracy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionAccuracy</seealso>
    let PositionAccuracy = Prefixed_Name(dtx_srti, "PositionAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasVerticalPositionAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the horizontal position accuracy according EN 16803-1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVerticalPositionAccuracy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVerticalPositionAccuracy</seealso>
    let hasVerticalPositionAccuracy =
        Prefixed_Name(dtx_srti, "hasVerticalPositionAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:HeightTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coded value for type of height</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightTypeEnum</seealso>
    let HeightTypeEnum = Prefixed_Name(dtx_srti, "HeightTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasHeightTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of measured height.When it is omitted it is supposed to be the ellipsoidal height.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightTypeEnum</seealso>
    let hasHeightTypeEnum = Prefixed_Name(dtx_srti, "hasHeightTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAltitudeConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Evaluation of the altitude confidence assessed according to ETSI ISO 102894-2</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeConfidence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAltitudeConfidence</seealso>
    let hasAltitudeConfidence =
        Prefixed_Name(dtx_srti, "hasAltitudeConfidence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointCoordinatesAssociationsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes.Package PointCoordinates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsFrom">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointCoordinatesAssociationsFrom</seealso>
    let PointCoordinatesAssociationsFrom =
        Prefixed_Name(dtx_srti, "PointCoordinatesAssociationsFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LocationReferencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReferencing</seealso>
    let LocationReferencing =
        Prefixed_Name(dtx_srti, "LocationReferencing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:HeightGradeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of height or vertical gradings of road sections.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightGradeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#HeightGradeEnum</seealso>
    let HeightGradeEnum = Prefixed_Name(dtx_srti, "HeightGradeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Impact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Impact">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Impact</seealso>
    let Impact = Prefixed_Name(dtx_srti, "Impact") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfOperationalLanes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of usable lanes in the specified direction which remain fully operational (this may include the hard shoulder if it is being used as an operational lane).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfOperationalLanes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfOperationalLanes</seealso>
    let numberOfOperationalLanes =
        Prefixed_Name(dtx_srti, "numberOfOperationalLanes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfLanesRestricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of normally usable lanes on the carriageway which are now restricted either fully or partially (this may include the hard shoulder if it is normally available for operational use, e.g. in hard shoulder running schemes).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfLanesRestricted">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfLanesRestricted</seealso>
    let numberOfLanesRestricted =
        Prefixed_Name(dtx_srti, "numberOfLanesRestricted") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:capacityRemaining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ratio of current capacity to the normal (free flow) road capacity in the defined direction, expressed as a percentage. Capacity is the maximum number of vehicles that can pass a specified point on the road, in unit time given the specified conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capacityRemaining">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capacityRemaining</seealso>
    let capacityRemaining = Prefixed_Name(dtx_srti, "capacityRemaining") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:residualRoadWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total width of the combined operational lanes in the specified direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualRoadWidth">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#residualRoadWidth</seealso>
    let residualRoadWidth = Prefixed_Name(dtx_srti, "residualRoadWidth") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InfrastructureDamageObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An obstruction on the road caused by one Infrastructure Damage</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageObstruction</seealso>
    let InfrastructureDamageObstruction =
        Prefixed_Name(dtx_srti, "InfrastructureDamageObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of infrastructure damage which may have an effect on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDamageTypeEnum</seealso>
    let InfrastructureDamageTypeEnum =
        Prefixed_Name(dtx_srti, "InfrastructureDamageTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasInfrastructureDamageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Types of infrastructure damage which may have an effect on the road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDamageType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDamageType</seealso>
    let hasInfrastructureDamageType =
        Prefixed_Name(dtx_srti, "hasInfrastructureDamageType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InfrastructureDescriptorEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptor identifying infrastructure to help to identify a specific location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDescriptorEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InfrastructureDescriptorEnum</seealso>
    let InfrastructureDescriptorEnum =
        Prefixed_Name(dtx_srti, "InfrastructureDescriptorEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:InternationalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifier/name whose range is specific to the particular country.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InternationalIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#InternationalIdentifier</seealso>
    let InternationalIdentifier =
        Prefixed_Name(dtx_srti, "InternationalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:nationalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifier or name unique within the specified country.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationalIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nationalIdentifier</seealso>
    let nationalIdentifier =
        Prefixed_Name(dtx_srti, "nationalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:IsoNamedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Iso named area	The ISO 3166-2 representation for the named area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#IsoNamedArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#IsoNamedArea</seealso>
    let IsoNamedArea = Prefixed_Name(dtx_srti, "IsoNamedArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ISO 3166-2 subdivison types.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubdivisionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubdivisionTypeEnum</seealso>
    let SubdivisionTypeEnum =
        Prefixed_Name(dtx_srti, "SubdivisionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSubdivisionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ISO 3166-2 subdivison type for the named area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubdivisionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubdivisionTypeEnum</seealso>
    let hasSubdivisionTypeEnum =
        Prefixed_Name(dtx_srti, "hasSubdivisionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasCountrySubdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The ISO 3166-2 subdivision code for the named area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCountrySubdivision">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCountrySubdivision</seealso>
    let hasCountrySubdivision =
        Prefixed_Name(dtx_srti, "hasCountrySubdivision") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Itinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple (i.e. more than one) physically separate locations arranged as an ordered set that defines an itinerary or route. In SRTI is not included ItineraryByReference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Itinerary">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Itinerary</seealso>
    let Itinerary = Prefixed_Name(dtx_srti, "Itinerary") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:LocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents one or more physically separate locations. Multiple locations may be related, as in an itinerary or route, or may be unrelated. One LocationReference should not use multiple Location objects to represent the same physical location. In SRTI is not included LocationGroup</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LocationReference</seealso>
    let LocationReference = Prefixed_Name(dtx_srti, "LocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ItineraryByIndexedLocations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multiple physically separate locations arranged as an ordered set that defines an itinerary or route. The index qualifier indicates the order.
    /// Association: 1..1 Location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ItineraryByIndexedLocations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ItineraryByIndexedLocations</seealso>
    let ItineraryByIndexedLocations =
        Prefixed_Name(dtx_srti, "ItineraryByIndexedLocations") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLocationContainedInItinerary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A location contained in an itinerary (i.e. an ordered set of locations defining a route or itinerary).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationContainedInItinerary">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationContainedInItinerary</seealso>
    let hasLocationContainedInItinerary =
        Prefixed_Name(dtx_srti, "hasLocationContainedInItinerary") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LCC_CountryRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Country Representation ontology provides a reference model to support the first two parts of ISO 3166, along with the other coding systems:
    ///  - ISO 3166-1 (Country codes) establishes codes that represent the current names of countries, dependencies, and other areas of particular geopolitical interest, on the basis of lists of country names obtained from the United Nations.
    ///  - ISO 3166-2 (Country subdivision code) establishes a code that represents the names of the principal administrative divisions, or similar areas, of the countries, etc. included in the ISO 3166-1.
    ///  - ISO 3166-3 (Code for formerly used names of countries) establishes a code that represents non-current country names, i.e., the country names deleted from ISO 3166 since its first publication in 1974.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LCC_CountryRepresentation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LCC_CountryRepresentation</seealso>
    let LCC_CountryRepresentation =
        Prefixed_Name(dtx_srti, "LCC_CountryRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Lane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates a specific lane or group of lanes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Lane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Lane</seealso>
    let Lane = Prefixed_Name(dtx_srti, "Lane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:laneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of the lane, where 1 is nearest the hard shoulder/verge and the numbers increase towards the central reservation/road axis.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneNumber">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#laneNumber</seealso>
    let laneNumber = Prefixed_Name(dtx_srti, "laneNumber") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:LaneEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of descriptors identifying specific lanes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LaneEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LaneEnum</seealso>
    let LaneEnum = Prefixed_Name(dtx_srti, "LaneEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasLaneEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the specific lane to which the location relates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLaneEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLaneEnum</seealso>
    let hasLaneEnum = Prefixed_Name(dtx_srti, "hasLaneEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadName</seealso>
    let roadName = Prefixed_Name(dtx_srti, "roadName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:linearElementReferenceModelVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The version of the identified road network reference model.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModelVersion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModelVersion</seealso>
    let linearElementReferenceModelVersion =
        Prefixed_Name(dtx_srti, "linearElementReferenceModelVersion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:linearElementReferenceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier of a road network reference model which segments the road network according to specific business rules.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModel">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementReferenceModel</seealso>
    let linearElementReferenceModel =
        Prefixed_Name(dtx_srti, "linearElementReferenceModel") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifier/number of the road. The road number designated by the road authority</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadNumber">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadNumber</seealso>
    let hasRoadNumber = Prefixed_Name(dtx_srti, "hasRoadNumber") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearElementNatureEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of indicative natures of linear elements.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementNatureEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementNatureEnum</seealso>
    let LinearElementNatureEnum =
        Prefixed_Name(dtx_srti, "LinearElementNatureEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLinearElementNature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An indication of the nature of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElementNature">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElementNature</seealso>
    let hasLinearElementNature =
        Prefixed_Name(dtx_srti, "hasLinearElementNature") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearElementByCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object defined by its identifier or code in a road network reference model (specified in LinearElement class) which segments the road network according to specific business rules.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByCode">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByCode</seealso>
    let LinearElementByCode =
        Prefixed_Name(dtx_srti, "LinearElementByCode") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:linearElementIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An identifier or code of a linear element (or link) in the road network reference model that is specified in the LinearElement class.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#linearElementIdentifier</seealso>
    let linearElementIdentifier =
        Prefixed_Name(dtx_srti, "linearElementIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearElementByLineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element defined by a line string (class GmlLineString).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByLineString">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByLineString</seealso>
    let LinearElementByLineString =
        Prefixed_Name(dtx_srti, "LinearElementByLineString") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGmlLineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Line string based on GML (EN ISO 19136) definition: a curve defined by a series of two or more coordinate tuples. Unlike GML may be self-intersecting. If srsName attribute is not present, posList is assumed to use "ETRS89-LatLonh" reference system.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlLineString">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlLineString</seealso>
    let hasGmlLineString = Prefixed_Name(dtx_srti, "hasGmlLineString") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearElementByPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear element along a single linear object defined by its start and end points.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByPoints">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearElementByPoints</seealso>
    let LinearElementByPoints =
        Prefixed_Name(dtx_srti, "LinearElementByPoints") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentEndPointLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The referent at a known location on the linear object which defines the end of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentEndPointLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentEndPointLinearElement</seealso>
    let hasReferentEndPointLinearElement =
        Prefixed_Name(dtx_srti, "hasReferentEndPointLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentIntermediatePointLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A referent at a known location on the linear object which is neither the start or end of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentIntermediatePointLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentIntermediatePointLinearElement</seealso>
    let hasReferentIntermediatePointLinearElement =
        Prefixed_Name(dtx_srti, "hasReferentIntermediatePointLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentStartPointLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The referent at a known location on the linear object which defines the start of the linear element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentStartPointLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentStartPointLinearElement</seealso>
    let hasReferentStartPointLinearElement =
        Prefixed_Name(dtx_srti, "hasReferentStartPointLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location representing a linear section with optional directionality defined between two points. Any LinearLocation must have an instance of at least one of these classes. If using multiple instances, producers must take care to ensure they represent the same location.
    /// Associations:
    /// 0..1	OpenlrLinear
    /// 0..1	GmlLineString
    /// 0..1	SupplementaryPositionalDescription</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearLocation</seealso>
    let LinearLocation = Prefixed_Name(dtx_srti, "LinearLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SupplementaryPositionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of supplementary positional information which improves the precision of the location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SupplementaryPositionalDescription</seealso>
    let SupplementaryPositionalDescription =
        Prefixed_Name(dtx_srti, "SupplementaryPositionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSecondarySupplementaryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Supplementary description that applies to the secondary end of the linear location. Use when properties change along the Linear. For a one-way linear the secondary end should be the destination end.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSecondarySupplementaryDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSecondarySupplementaryDescription</seealso>
    let hasSecondarySupplementaryDescription =
        Prefixed_Name(dtx_srti, "hasSecondarySupplementaryDescription") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>OpenLR line location reference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLinear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLinear</seealso>
    let OpenlrLinear = Prefixed_Name(dtx_srti, "OpenlrLinear") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLinear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>OpenLR line location reference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLinear">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLinear</seealso>
    let hasOpenlrLinear = Prefixed_Name(dtx_srti, "hasOpenlrLinear") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:NetworkLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The specification of a location on a network (as a point or a linear location).Association: 0..1 SupplementaryPositionalDescription</para>
    ///   <para></para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkLocation</seealso>
    let NetworkLocation = Prefixed_Name(dtx_srti, "NetworkLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:LinearWithinLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearWithinLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#LinearWithinLinearElement</seealso>
    let LinearWithinLinearElement =
        Prefixed_Name(dtx_srti, "LinearWithinLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:directionOnLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The direction of traffic flow on the linear section in terms of general destination direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionOnLinearSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#directionOnLinearSection</seealso>
    let directionOnLinearSection =
        Prefixed_Name(dtx_srti, "directionOnLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a linear element along a single linear object, consistent with EN ISO 19148 definitions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearElement</seealso>
    let hasLinearElement = Prefixed_Name(dtx_srti, "hasLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDistanceAlongLinearElementTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A point on the linear element that defines the end node of the linear section.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementTo">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementTo</seealso>
    let hasDistanceAlongLinearElementTo =
        Prefixed_Name(dtx_srti, "hasDistanceAlongLinearElementTo") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDistanceAlongLinearElementFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A point on the linear element that defines the start node of the linear section.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementFrom">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDistanceAlongLinearElementFrom</seealso>
    let hasDistanceAlongLinearElementFrom =
        Prefixed_Name(dtx_srti, "hasDistanceAlongLinearElementFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasHeightGradeOfLinearSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identification of whether the linear section that is part of the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfLinearSection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfLinearSection</seealso>
    let hasHeightGradeOfLinearSection =
        Prefixed_Name(dtx_srti, "hasHeightGradeOfLinearSection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SpeedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of speed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SpeedValue</seealso>
    let SpeedValue = Prefixed_Name(dtx_srti, "SpeedValue") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Speed of the mobile entity.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#speed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#speed</seealso>
    let speed = Prefixed_Name(dtx_srti, "speed") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:MobilityTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An indication of whether the associated instance of a SituationRecord is mobile (e.g. a march or parade moving along a road) or stationary.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MobilityTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#MobilityTypeEnum</seealso>
    let MobilityTypeEnum = Prefixed_Name(dtx_srti, "MobilityTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasMobilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Types of mobility relating to a situation element defined by a SituationReord.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityType</seealso>
    let hasMobilityType = Prefixed_Name(dtx_srti, "hasMobilityType") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:areaNameProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaNameProperty">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#areaNameProperty</seealso>
    let areaNameProperty = Prefixed_Name(dtx_srti, "areaNameProperty") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of areas.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedAreaTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NamedAreaTypeEnum</seealso>
    let NamedAreaTypeEnum = Prefixed_Name(dtx_srti, "NamedAreaTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasNamedAreaTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedAreaTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNamedAreaTypeEnum</seealso>
    let hasNamedAreaTypeEnum =
        Prefixed_Name(dtx_srti, "hasNamedAreaTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSupplementaryPositionalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A collection of supplementary positional information which improves the precision of the location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSupplementaryPositionalDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSupplementaryPositionalDescription</seealso>
    let hasSupplementaryPositionalDescription =
        Prefixed_Name(dtx_srti, "hasSupplementaryPositionalDescription") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OperatorAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actions that a traffic operator can decide to implement to prevent or help correct dangerous or poor driving conditions, including maintenance of the road infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OperatorAction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OperatorAction</seealso>
    let OperatorAction = Prefixed_Name(dtx_srti, "OperatorAction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of road surface conditions which are not related to the weather.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NonWeatherRelatedRoadConditionTypeEnum</seealso>
    let NonWeatherRelatedRoadConditionTypeEnum =
        Prefixed_Name(dtx_srti, "NonWeatherRelatedRoadConditionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:WeatherRelatedRoadConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Road surface conditions that are related to the weather which may affect the driving conditions, such as ice, snow or water.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditions</seealso>
    let WeatherRelatedRoadConditions =
        Prefixed_Name(dtx_srti, "WeatherRelatedRoadConditions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadSurfaceConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conditions of the road surface which may affect driving conditions. These may be related to the weather (e.g. ice, snow etc.) or to other conditions (e.g. oil, mud, leaves etc. on the road)</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadSurfaceConditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadSurfaceConditions</seealso>
    let RoadSurfaceConditions =
        Prefixed_Name(dtx_srti, "RoadSurfaceConditions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:NutsCodeTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of NUTS codes (Nomenclature of territorial units for statistics) including LAU codes (Local Administrative Units).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsCodeTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsCodeTypeEnum</seealso>
    let NutsCodeTypeEnum = Prefixed_Name(dtx_srti, "NutsCodeTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:NutsNamedArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The NUTS-Code representation for the named area (Nomenclature of territorial units for statistics) or its LAU code representation (Local Administrative Unit).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsNamedArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NutsNamedArea</seealso>
    let NutsNamedArea = Prefixed_Name(dtx_srti, "NutsNamedArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:nutsCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The NUTS code for the named area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nutsCode">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#nutsCode</seealso>
    let nutsCode = Prefixed_Name(dtx_srti, "nutsCode") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasNutsCodeTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The NUTS code type for the named area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNutsCodeTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasNutsCodeTypeEnum</seealso>
    let hasNutsCodeTypeEnum =
        Prefixed_Name(dtx_srti, "hasNutsCodeTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfObstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of Obstructions. Not in SRTI profile</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfObstructions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfObstructions</seealso>
    let numberOfObstructions =
        Prefixed_Name(dtx_srti, "numberOfObstructions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasMobilityOfObstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the mobility of a obstruction</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfObstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMobilityOfObstruction</seealso>
    let hasMobilityOfObstruction =
        Prefixed_Name(dtx_srti, "hasMobilityOfObstruction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:offsetDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The non-negative offset distance from the ALERT-C referenced point to the actual point. The ALERT-C locations in the primary and secondary locations must always encompass the linear section being specified, thus offset distance is towards the other point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#offsetDistance">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#offsetDistance</seealso>
    let offsetDistance = Prefixed_Name(dtx_srti, "offsetDistance") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:OpenLR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>OpenLR location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenLR">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenLR</seealso>
    let OpenLR = Prefixed_Name(dtx_srti, "OpenLR") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrBasePointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Holds common data that are used both in OpenlrPointAccessPoint and OpenlrPointAlongLine.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBasePointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBasePointLocation</seealso>
    let OpenlrBasePointLocation =
        Prefixed_Name(dtx_srti, "OpenlrBasePointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrOffsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Offsets are used to locate the start and end of a location more precisely than bounding to the nodes in a network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOffsets">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOffsets</seealso>
    let OpenlrOffsets = Prefixed_Name(dtx_srti, "OpenlrOffsets") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasOpenlrOffsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Allows for adding offsets to the line location path defined by nodes when the starting (respectively ending) point does not coincide with a node.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOffsets">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOffsets</seealso>
    let hasOpenlrOffsets = Prefixed_Name(dtx_srti, "hasOpenlrOffsets") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrSideOfRoadEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of side of road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrSideOfRoadEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrSideOfRoadEnum</seealso>
    let OpenlrSideOfRoadEnum =
        Prefixed_Name(dtx_srti, "OpenlrSideOfRoadEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrSideOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides the of road where the corresponding point lies.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrSideOfRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrSideOfRoad</seealso>
    let hasOpenlrSideOfRoad =
        Prefixed_Name(dtx_srti, "hasOpenlrSideOfRoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrOrientationEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of side of road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOrientationEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrOrientationEnum</seealso>
    let OpenlrOrientationEnum =
        Prefixed_Name(dtx_srti, "OpenlrOrientationEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Orientation of the driving direction in relation with the direction of the underlying linear</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOrientation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrOrientation</seealso>
    let hasOpenlrOrientation =
        Prefixed_Name(dtx_srti, "hasOpenlrOrientation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The basis of a location reference is a sequence of location reference points (LRPs).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLocationReferencePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLocationReferencePoint</seealso>
    let OpenlrLocationReferencePoint =
        Prefixed_Name(dtx_srti, "OpenlrLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Allows defining the first point of the OpenLR path</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLocationReferencePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLocationReferencePoint</seealso>
    let hasOpenlrLocationReferencePoint =
        Prefixed_Name(dtx_srti, "hasOpenlrLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrLastLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The sequence of location reference points is terminated by a last location reference point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLastLocationReferencePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrLastLocationReferencePoint</seealso>
    let OpenlrLastLocationReferencePoint =
        Prefixed_Name(dtx_srti, "OpenlrLastLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrLastLocationReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Allows defining the last point of the OpenLR path</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLastLocationReferencePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrLastLocationReferencePoint</seealso>
    let hasOpenlrLastLocationReferencePoint =
        Prefixed_Name(dtx_srti, "hasOpenlrLastLocationReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrPointLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point location is a zero-dimensional element in a map that specifies a geometric location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrPointLocationReference</seealso>
    let OpenlrPointLocationReference =
        Prefixed_Name(dtx_srti, "OpenlrPointLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:OpenlrBaseReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base class used to hold data about a reference point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBaseReferencePoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#OpenlrBaseReferencePoint</seealso>
    let OpenlrBaseReferencePoint =
        Prefixed_Name(dtx_srti, "OpenlrBaseReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpact">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpact</seealso>
    let hasImpact = Prefixed_Name(dtx_srti, "hasImpact") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordObservationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordObservationTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordObservationTime</seealso>
    let situationRecordObservationTime =
        Prefixed_Name(dtx_srti, "situationRecordObservationTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:confidentialityOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The extent to which the related information may be circulated, according to the recipient type. Recipients must comply with this confidentiality statement. This overrides any confidentiality defined for the situation as a whole in the header information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#confidentialityOverride">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#confidentialityOverride</seealso>
    let confidentialityOverride =
        Prefixed_Name(dtx_srti, "confidentialityOverride") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasProbabilityOfOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An assessment of the degree of likelihood that the reported event will occur.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasProbabilityOfOccurrence">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasProbabilityOfOccurrence</seealso>
    let hasProbabilityOfOccurrence =
        Prefixed_Name(dtx_srti, "hasProbabilityOfOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordCreationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date/time that the SituationRecord object (the first version of the record) was created by the original supplier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationTime</seealso>
    let situationRecordCreationTime =
        Prefixed_Name(dtx_srti, "situationRecordCreationTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of the source from which the information was obtained.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Source">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Source</seealso>
    let Source = Prefixed_Name(dtx_srti, "Source") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSource">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSource</seealso>
    let hasSource = Prefixed_Name(dtx_srti, "hasSource") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:safetyRelatedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates, whether this SituationRecord specifies a safety related message according to Commission Delegated Regulation (EU) No 886/2013.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyRelatedMessage">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyRelatedMessage</seealso>
    let safetyRelatedMessage =
        Prefixed_Name(dtx_srti, "safetyRelatedMessage") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordCreationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique alphanumeric reference (e.g. an external reference or a UUID) of the SituationRecord object (the first version of the record) that was created by the original supplier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordCreationReference</seealso>
    let situationRecordCreationReference =
        Prefixed_Name(dtx_srti, "situationRecordCreationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordFirstSupplierVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date/time that the current version of the Situation Record was written into the database of the original supplier in the supply chain.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordFirstSupplierVersionTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordFirstSupplierVersionTime</seealso>
    let situationRecordFirstSupplierVersionTime =
        Prefixed_Name(dtx_srti, "situationRecordFirstSupplierVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Has a location reference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLocationReference</seealso>
    let hasLocationReference =
        Prefixed_Name(dtx_srti, "hasLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSeverityEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Levels of severity of a situation as whole assessed by the impact that the situation may have on traffic flow as perceived by the supplier.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSeverityEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSeverityEnum</seealso>
    let hasSeverityEnum = Prefixed_Name(dtx_srti, "hasSeverityEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasImpactOnOppositeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An assessment of the impact that an event or operator action defined by the situation record has on the driving conditions, but on opposite direction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpactOnOppositeDirection">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasImpactOnOppositeDirection</seealso>
    let hasImpactOnOppositeDirection =
        Prefixed_Name(dtx_srti, "hasImpactOnOppositeDirection") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:situationRecordVersionTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date/time that this current version of the SituationRecord within the situation was written into the database of the supplier which is involved in the data exchange. Identity and version of record are defined by the class stereotype implementation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersionTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#situationRecordVersionTime</seealso>
    let situationRecordVersionTime =
        Prefixed_Name(dtx_srti, "situationRecordVersionTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SkosClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Skos Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SkosClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SkosClasses</seealso>
    let SkosClasses = Prefixed_Name(dtx_srti, "SkosClasses") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:sourceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the organisation which has produced the information relating to this version of the information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceName</seealso>
    let sourceName = Prefixed_Name(dtx_srti, "sourceName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:sourceIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Language independent textual code or identifier for the organisation or the equipment that has produced the information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceIdentification">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceIdentification</seealso>
    let sourceIdentification =
        Prefixed_Name(dtx_srti, "sourceIdentification") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:reliable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An indication as to whether the source deems the associated information to be reliable/correct. "True" indicates it is deemed reliable.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reliable">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#reliable</seealso>
    let reliable = Prefixed_Name(dtx_srti, "reliable") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SourceTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SourceTypeEnum</seealso>
    let SourceTypeEnum = Prefixed_Name(dtx_srti, "SourceTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:sourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information about the technology used for measuring the data or the method used for obtaining qualitative descriptions relating to this version of the information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceType</seealso>
    let sourceType = Prefixed_Name(dtx_srti, "sourceType") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:sourceCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>EN ISO 3166-1 two-character country code of the source of the information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceCountry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sourceCountry</seealso>
    let sourceCountry = Prefixed_Name(dtx_srti, "sourceCountry") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The subjects with which the roadworks are associated.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubjectTypeOfWorksEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SubjectTypeOfWorksEnum</seealso>
    let SubjectTypeOfWorksEnum =
        Prefixed_Name(dtx_srti, "SubjectTypeOfWorksEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfSubjects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of subjects on which the roadworks (construction or maintenance) are being performed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfSubjects">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfSubjects</seealso>
    let numberOfSubjects = Prefixed_Name(dtx_srti, "numberOfSubjects") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSubjectTypeOfWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The subject type of the roadworks (i.e. on what the construction or maintenance work is being performed).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubjectTypeOfWorks">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSubjectTypeOfWorks</seealso>
    let hasSubjectTypeOfWorks =
        Prefixed_Name(dtx_srti, "hasSubjectTypeOfWorks") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:locationPrecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the location is given with a precision which is better than the stated value in metres.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationPrecision">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationPrecision</seealso>
    let locationPrecision = Prefixed_Name(dtx_srti, "locationPrecision") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasInfrastructureDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptor which identifies infrastructure to help identify the specific location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasInfrastructureDescriptor</seealso>
    let hasInfrastructureDescriptor =
        Prefixed_Name(dtx_srti, "hasInfrastructureDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:sequentialRampNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The sequential number of an exit/entrance ramp from a given location in a given direction (normally used to indicate a specific exit/entrance in a complex junction/intersection).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sequentialRampNumber">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sequentialRampNumber</seealso>
    let sequentialRampNumber =
        Prefixed_Name(dtx_srti, "sequentialRampNumber") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:locationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Supplementary human-readable description of the location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#locationDescription</seealso>
    let locationDescription =
        Prefixed_Name(dtx_srti, "locationDescription") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDirectionPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the main purpose of the road at the location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDirectionPurpose">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDirectionPurpose</seealso>
    let hasDirectionPurpose =
        Prefixed_Name(dtx_srti, "hasDirectionPurpose") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGeographicDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptor which identifies a geographic characteristic to help identify the specific location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeographicDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeographicDescriptor</seealso>
    let hasGeographicDescriptor =
        Prefixed_Name(dtx_srti, "hasGeographicDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:lengthAffected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This indicates the length (measured in metres) of carriageway (and lanes) affected by the associated traffic element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lengthAffected">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lengthAffected</seealso>
    let lengthAffected = Prefixed_Name(dtx_srti, "lengthAffected") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPositionOnCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relative position across carriageway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionOnCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionOnCarriageway</seealso>
    let hasPositionOnCarriageway =
        Prefixed_Name(dtx_srti, "hasPositionOnCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TPEGLoc01LinearLocationSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of linear location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TPEGLoc01LinearLocationSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TPEGLoc01LinearLocationSubtypeEnum</seealso>
    let TPEGLoc01LinearLocationSubtypeEnum =
        Prefixed_Name(dtx_srti, "TPEGLoc01LinearLocationSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegEnumerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegEnumerations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegEnumerations</seealso>
    let TpegEnumerations = Prefixed_Name(dtx_srti, "TpegEnumerations") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:TimeClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>OWL-Time is an ontology of temporal concepts, for describing the temporal properties of resources. The vocabulary provided expresses facts about relations among instants and intervals, as well as durations. Time positions and durations may be expressed using either the conventional (Gregorian) calendar and clock, or using another temporal reference system such as Unix-time, geologic time, or different calendars.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TimeClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TimeClasses</seealso>
    let TimeClasses = Prefixed_Name(dtx_srti, "TimeClasses") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegAreaDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A descriptor for describing an area location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegAreaDescriptor</seealso>
    let TpegAreaDescriptor =
        Prefixed_Name(dtx_srti, "TpegAreaDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc03AreaDescriptorSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptors for describing area locations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03AreaDescriptorSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc03AreaDescriptorSubtypeEnum</seealso>
    let TpegLoc03AreaDescriptorSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc03AreaDescriptorSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegAreaDescriptorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The nature of the descriptor used to define the location under consideration (derived from the TPEG Loc table 03).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaDescriptorType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaDescriptorType</seealso>
    let tpegAreaDescriptorType =
        Prefixed_Name(dtx_srti, "tpegAreaDescriptorType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of information providing descriptive references to locations using the TPEG-Loc location referencing approach.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegDescriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegDescriptor</seealso>
    let TpegDescriptor = Prefixed_Name(dtx_srti, "TpegDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:TpegHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Height information which provides additional discrimination for the applicable area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegHeight</seealso>
    let TpegHeight = Prefixed_Name(dtx_srti, "TpegHeight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasTpegHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Height information which provides additional discrimination for the applicable area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegHeight</seealso>
    let hasTpegHeight = Prefixed_Name(dtx_srti, "hasTpegHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc01AreaLocationSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01AreaLocationSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01AreaLocationSubtypeEnum</seealso>
    let TpegLoc01AreaLocationSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc01AreaLocationSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegAreaLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaLocationType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegAreaLocationType</seealso>
    let tpegAreaLocationType =
        Prefixed_Name(dtx_srti, "tpegAreaLocationType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tpeg location</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc</seealso>
    let TpegLoc = Prefixed_Name(dtx_srti, "TpegLoc") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:descriptorString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A text string which describes or elaborates the location. Here is used for values distinct to RoadNumbers or AdministrativeUnit.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptorString">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptorString</seealso>
    let descriptorString = Prefixed_Name(dtx_srti, "descriptorString") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes or elaborates the location. Here is used for values from RoadNumber or AdministrativeUnit.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#descriptor</seealso>
    let descriptor = Prefixed_Name(dtx_srti, "descriptor") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:TpegFramedPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on the road network which is framed between two other points on the same road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegFramedPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegFramedPoint</seealso>
    let TpegFramedPoint = Prefixed_Name(dtx_srti, "TpegFramedPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TpegLoc01FramedPointLocationSubtypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of points on the road network framed by two other points on the same road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01FramedPointLocationSubtypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegLoc01FramedPointLocationSubtypeEnum</seealso>
    let TpegLoc01FramedPointLocationSubtypeEnum =
        Prefixed_Name(dtx_srti, "TpegLoc01FramedPointLocationSubtypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tpegFramedPointLocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of TPEG location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegFramedPointLocationType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegFramedPointLocationType</seealso>
    let tpegFramedPointLocationType =
        Prefixed_Name(dtx_srti, "tpegFramedPointLocationType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegPointTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location at the down stream end of the linear section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointTo">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointTo</seealso>
    let hasTpegPointTo = Prefixed_Name(dtx_srti, "hasTpegPointTo") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:inTunnels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>In tunnels</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnels">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#inTunnels</seealso>
    let inTunnels = Prefixed_Name(dtx_srti, "inTunnels") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onEnteringOrLeavingTunnels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>On entering or leaving tunnels</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onEnteringOrLeavingTunnels">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onEnteringOrLeavingTunnels</seealso>
    let onEnteringOrLeavingTunnels =
        Prefixed_Name(dtx_srti, "onEnteringOrLeavingTunnels") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:onUnderpasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AreaPlacesEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>On underpasses, i.e. sections of the road which pass under another road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onUnderpasses</seealso>
    let onUnderpasses = Prefixed_Name(dtx_srti, "onUnderpasses") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:technicalExercise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationStatusEnum</para>
    ///   <para>The information is part of an exercise which includes tests of associated technical subsystems.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#technicalExercise">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#technicalExercise</seealso>
    let technicalExercise = Prefixed_Name(dtx_srti, "technicalExercise") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:motorway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>Motorway</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorway</seealso>
    let motorway = Prefixed_Name(dtx_srti, "motorway") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roundabout</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>dtx_srti:CarriagewayEnum</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Roundabout</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roundabout">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roundabout</seealso>
    let roundabout = Prefixed_Name(dtx_srti, "roundabout") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:undefined</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFormOfWayEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Undefined</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefined">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undefined</seealso>
    let undefined = Prefixed_Name(dtx_srti, "undefined") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:atSeaLevelTPEGHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc04HeightTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>At service area.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atSeaLevelTPEGHeight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#atSeaLevelTPEGHeight</seealso>
    let atSeaLevelTPEGHeight =
        Prefixed_Name(dtx_srti, "atSeaLevelTPEGHeight") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useSnowTyres</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Use snow tyres.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowTyres">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useSnowTyres</seealso>
    let useSnowTyres = Prefixed_Name(dtx_srti, "useSnowTyres") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:right</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrSideOfRoadEnum</para>
    ///   <para>On the right side of the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#right">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#right</seealso>
    let right = Prefixed_Name(dtx_srti, "right") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:active</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ValidityStatusEnum</para>
    ///   <para>The described event, action or item is currently active regardless of the definition of the validity time specification.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#active">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#active</seealso>
    let active = Prefixed_Name(dtx_srti, "active") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:suspended</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ValidityStatusEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The described event, action or item is currently suspended, that is inactive, regardless of the definition of the validity time specification.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#suspended">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#suspended</seealso>
    let suspended = Prefixed_Name(dtx_srti, "suspended") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:abnormalLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>Abnormal traffic information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#abnormalLoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#abnormalLoad</seealso>
    let abnormalLoad = Prefixed_Name(dtx_srti, "abnormalLoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:convoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>A group of vehicles moving together in formation which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#convoy</seealso>
    let convoy = Prefixed_Name(dtx_srti, "convoy") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:damagedVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Damaged vehicle(s) on the carriageway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedVehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedVehicle</seealso>
    let damagedVehicle = Prefixed_Name(dtx_srti, "damagedVehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vehicleStuck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>One or more vehicles are stuck (i.e. unable to move) due to environmental conditions such as a snow drift or severe icy road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStuck">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleStuck</seealso>
    let vehicleStuck = Prefixed_Name(dtx_srti, "vehicleStuck") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:vehicleWithOverwideLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A vehicle of width greater than that normally allowed which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithOverwideLoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleWithOverwideLoad</seealso>
    let vehicleWithOverwideLoad =
        Prefixed_Name(dtx_srti, "vehicleWithOverwideLoad") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:carriagewayPartiallyObstructed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>The carriageway is partially obstructed in the specified direction due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayPartiallyObstructed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carriagewayPartiallyObstructed</seealso>
    let carriagewayPartiallyObstructed =
        Prefixed_Name(dtx_srti, "carriagewayPartiallyObstructed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:lanesBlocked</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficConstrictionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>One or more lanes is totally obstructed in the specified direction due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesBlocked">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lanesBlocked</seealso>
    let lanesBlocked = Prefixed_Name(dtx_srti, "lanesBlocked") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:medianOfSamplesInATimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    ///   <para>Median of sample values taken over a time period.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medianOfSamplesInATimePeriod">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#medianOfSamplesInATimePeriod</seealso>
    let medianOfSamplesInATimePeriod =
        Prefixed_Name(dtx_srti, "medianOfSamplesInATimePeriod") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:movingAverageOfSamples</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ComputationMethodEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Moving average of sample values.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#movingAverageOfSamples">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#movingAverageOfSamples</seealso>
    let movingAverageOfSamples =
        Prefixed_Name(dtx_srti, "movingAverageOfSamples") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:burstPipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>The road surface has sunken or collapsed in places due to burst pipes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstPipe">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#burstPipe</seealso>
    let burstPipe = Prefixed_Name(dtx_srti, "burstPipe") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:damagedBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>Damage to a bridge that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedBridge">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedBridge</seealso>
    let damagedBridge = Prefixed_Name(dtx_srti, "damagedBridge") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damagedCrashBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>Damage to a crash barrier that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedCrashBarrier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedCrashBarrier</seealso>
    let damagedCrashBarrier =
        Prefixed_Name(dtx_srti, "damagedCrashBarrier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:damagedFlyover</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Damage to an elevated section of the carriageway over another carriageway that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedFlyover">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedFlyover</seealso>
    let damagedFlyover = Prefixed_Name(dtx_srti, "damagedFlyover") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:damagedGallery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>Damage to a gallery that may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGallery">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#damagedGallery</seealso>
    let damagedGallery = Prefixed_Name(dtx_srti, "damagedGallery") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:weakBridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:InfrastructureDamageTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Weak bridge capable of carrying a reduced load, typically with a reduced weight limit restriction imposed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weakBridge">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#weakBridge</seealso>
    let weakBridge = Prefixed_Name(dtx_srti, "weakBridge") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc0</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Main road, highest importanceMain road, highest importance</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc0">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc0</seealso>
    let frc0 = Prefixed_Name(dtx_srti, "frc0") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>First class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc1">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc1</seealso>
    let frc1 = Prefixed_Name(dtx_srti, "frc1") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc2</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Second class road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc2">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc2</seealso>
    let frc2 = Prefixed_Name(dtx_srti, "frc2") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:major</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadworksScaleEnum</para>
    ///   <para>The roadworks are likely to cause major traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#major">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#major</seealso>
    let major = Prefixed_Name(dtx_srti, "major") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:mediumRoadworksScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RoadworksScaleEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The roadworks are likely to cause a medium level of traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumRoadworksScale">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#mediumRoadworksScale</seealso>
    let mediumRoadworksScale =
        Prefixed_Name(dtx_srti, "mediumRoadworksScale") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RoadworksScaleEnum</para>
    ///   <para>The roadworks are likely to cause minor traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minor">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minor</seealso>
    let minor = Prefixed_Name(dtx_srti, "minor") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:administrativeAtoll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Administrative atoll</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAtoll">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeAtoll</seealso>
    let administrativeAtoll =
        Prefixed_Name(dtx_srti, "administrativeAtoll") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:administrativeRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Administrative region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeRegion</seealso>
    let administrativeRegion =
        Prefixed_Name(dtx_srti, "administrativeRegion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:administrativeTerritory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Administrative territory</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeTerritory">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#administrativeTerritory</seealso>
    let administrativeTerritory =
        Prefixed_Name(dtx_srti, "administrativeTerritory") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:autonomousRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Autonomous region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousRegion</seealso>
    let autonomousRegion = Prefixed_Name(dtx_srti, "autonomousRegion") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:canton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Canton</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canton">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#canton</seealso>
    let canton = Prefixed_Name(dtx_srti, "canton") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:capitalCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Capital city</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capitalCity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#capitalCity</seealso>
    let capitalCity = Prefixed_Name(dtx_srti, "capitalCity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:city</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>City</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#city">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#city</seealso>
    let city = Prefixed_Name(dtx_srti, "city") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:department</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Department</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#department">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#department</seealso>
    let department = Prefixed_Name(dtx_srti, "department") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dependency</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dependency">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#dependency</seealso>
    let dependency = Prefixed_Name(dtx_srti, "dependency") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:district</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>District</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#district">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#district</seealso>
    let district = Prefixed_Name(dtx_srti, "district") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:districtMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>District municipality</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtMunicipality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtMunicipality</seealso>
    let districtMunicipality =
        Prefixed_Name(dtx_srti, "districtMunicipality") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:metropolitanDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Metropolitan district</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDistrict">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanDistrict</seealso>
    let metropolitanDistrict =
        Prefixed_Name(dtx_srti, "metropolitanDistrict") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:metropolitanRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Metropolitan region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#metropolitanRegion</seealso>
    let metropolitanRegion =
        Prefixed_Name(dtx_srti, "metropolitanRegion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Municipality</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#municipality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#municipality</seealso>
    let municipality = Prefixed_Name(dtx_srti, "municipality") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:overseasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Overseas region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasRegion</seealso>
    let overseasRegion = Prefixed_Name(dtx_srti, "overseasRegion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:overseasTerritorialCollectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Overseas territorial collectivity</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasTerritorialCollectivity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overseasTerritorialCollectivity</seealso>
    let overseasTerritorialCollectivity =
        Prefixed_Name(dtx_srti, "overseasTerritorialCollectivity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:parish</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Parish</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parish">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parish</seealso>
    let parish = Prefixed_Name(dtx_srti, "parish") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Province</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#province">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#province</seealso>
    let province = Prefixed_Name(dtx_srti, "province") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ward</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>Ward</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ward">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ward</seealso>
    let ward = Prefixed_Name(dtx_srti, "ward") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:aroundABendInRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeographicCharacteristicEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Around a bend in the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aroundABendInRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#aroundABendInRoad</seealso>
    let aroundABendInRoad = Prefixed_Name(dtx_srti, "aroundABendInRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onBorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeographicCharacteristicEnum</para>
    ///   <para>On border crossing.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBorder">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onBorder</seealso>
    let onBorder = Prefixed_Name(dtx_srti, "onBorder") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:onPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:GeographicCharacteristicEnum</para>
    ///   <para>On mountain pass.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPass">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#onPass</seealso>
    let onPass = Prefixed_Name(dtx_srti, "onPass") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:overCrestOfHill</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:GeographicCharacteristicEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Over the crest of a hill.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overCrestOfHill">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#overCrestOfHill</seealso>
    let overCrestOfHill = Prefixed_Name(dtx_srti, "overCrestOfHill") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:agriculturalShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Agricultural show or event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalShow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#agriculturalShow</seealso>
    let agriculturalShow = Prefixed_Name(dtx_srti, "agriculturalShow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:airShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Air show or other aeronautical event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airShow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airShow</seealso>
    let airShow = Prefixed_Name(dtx_srti, "airShow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:bullFight</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Bull fighting event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bullFight">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#bullFight</seealso>
    let bullFight = Prefixed_Name(dtx_srti, "bullFight") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ceremonialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Formal or religious act, rite or ceremony that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ceremonialEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ceremonialEvent</seealso>
    let ceremonialEvent = Prefixed_Name(dtx_srti, "ceremonialEvent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:commercialEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Commercial event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commercialEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#commercialEvent</seealso>
    let commercialEvent = Prefixed_Name(dtx_srti, "commercialEvent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:concert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Concert event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#concert">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#concert</seealso>
    let concert = Prefixed_Name(dtx_srti, "concert") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:cricketMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Cricket match that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cricketMatch">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cricketMatch</seealso>
    let cricketMatch = Prefixed_Name(dtx_srti, "cricketMatch") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:culturalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Cultural event which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#culturalEvent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#culturalEvent</seealso>
    let culturalEvent = Prefixed_Name(dtx_srti, "culturalEvent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:exhibition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Major display or trade show which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exhibition">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exhibition</seealso>
    let exhibition = Prefixed_Name(dtx_srti, "exhibition") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Periodic (e.g. annual), often traditional, gathering for entertainment or trade promotion, which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fair">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fair</seealso>
    let fair = Prefixed_Name(dtx_srti, "fair") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:marathon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Marathon, cross-country or road running event that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#marathon">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#marathon</seealso>
    let marathon = Prefixed_Name(dtx_srti, "marathon") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:market</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Periodic (e.g. weekly) gathering for buying and selling, which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#market">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#market</seealso>
    let market = Prefixed_Name(dtx_srti, "market") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:match</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>Sports match of unspecified type that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#match">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#match</seealso>
    let match_ = Prefixed_Name(dtx_srti, "match") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:motorShow</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Motor show which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorShow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorShow</seealso>
    let motorShow = Prefixed_Name(dtx_srti, "motorShow") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:motorSportRaceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Motor sport race meeting that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorSportRaceMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#motorSportRaceMeeting</seealso>
    let motorSportRaceMeeting =
        Prefixed_Name(dtx_srti, "motorSportRaceMeeting") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:parade</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Formal display or organized procession which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parade">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#parade</seealso>
    let parade = Prefixed_Name(dtx_srti, "parade") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:procession</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An organised procession which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#procession">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#procession</seealso>
    let procession = Prefixed_Name(dtx_srti, "procession") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:raceMeeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PublicEventTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Race meeting (other than horse or motor sport) that could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#raceMeeting">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#raceMeeting</seealso>
    let raceMeeting = Prefixed_Name(dtx_srti, "raceMeeting") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hazardous</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Driving conditions are hazardous due to environmental conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hazardous">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hazardous</seealso>
    let hazardous = Prefixed_Name(dtx_srti, "hazardous") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:impossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>Current conditions are making driving impossible.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impossible">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#impossible</seealso>
    let impossible = Prefixed_Name(dtx_srti, "impossible") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:normal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>Driving conditions are normal.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#normal</seealso>
    let normal = Prefixed_Name(dtx_srti, "normal") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:passableWithCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The roadway is passable to vehicles with driver care.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#passableWithCare">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#passableWithCare</seealso>
    let passableWithCare = Prefixed_Name(dtx_srti, "passableWithCare") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:veryHazardous</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Driving conditions are very hazardous due to environmental conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryHazardous">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryHazardous</seealso>
    let veryHazardous = Prefixed_Name(dtx_srti, "veryHazardous") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:winterConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    ///   <para>Driving conditions are consistent with those expected in winter.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterConditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#winterConditions</seealso>
    let winterConditions = Prefixed_Name(dtx_srti, "winterConditions") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:stationary</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:MobilityTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The described element of a situation is stationary.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationary">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stationary</seealso>
    let stationary = Prefixed_Name(dtx_srti, "stationary") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:avoidanceOfObstacles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Avoidance of obstacles on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidanceOfObstacles">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#avoidanceOfObstacles</seealso>
    let avoidanceOfObstacles =
        Prefixed_Name(dtx_srti, "avoidanceOfObstacles") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:driverDistraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Driver distraction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDistraction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDistraction</seealso>
    let driverDistraction = Prefixed_Name(dtx_srti, "driverDistraction") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:driverDrugAbuse</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Driver under the influence of drugs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDrugAbuse">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverDrugAbuse</seealso>
    let driverDrugAbuse = Prefixed_Name(dtx_srti, "driverDrugAbuse") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:driverIllness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Driver illness.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverIllness">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#driverIllness</seealso>
    let driverIllness = Prefixed_Name(dtx_srti, "driverIllness") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:exceedingSpeedsLimits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Loss of vehicle control due to excessive vehicle speed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exceedingSpeedsLimits">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#exceedingSpeedsLimits</seealso>
    let exceedingSpeedsLimits =
        Prefixed_Name(dtx_srti, "exceedingSpeedsLimits") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:excessAlcohol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Driver abilities reduced due to driving under the influence of alcohol. Alcohol levels above nationally accepted limit.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessAlcohol">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#excessAlcohol</seealso>
    let excessAlcohol = Prefixed_Name(dtx_srti, "excessAlcohol") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:undisclosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Undisclosed cause.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undisclosed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#undisclosed</seealso>
    let undisclosed = Prefixed_Name(dtx_srti, "undisclosed") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vehicleFailure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    ///   <para>Malfunction or failure of vehicle function.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFailure">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFailure</seealso>
    let vehicleFailure = Prefixed_Name(dtx_srti, "vehicleFailure") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Adult.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#adult">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#adult</seealso>
    let adult = Prefixed_Name(dtx_srti, "adult") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:child</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Child (age 4 to 17).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#child">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#child</seealso>
    let child = Prefixed_Name(dtx_srti, "child") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:emergencyServicesPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A member of the emergency services, other than the police.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServicesPerson">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#emergencyServicesPerson</seealso>
    let emergencyServicesPerson =
        Prefixed_Name(dtx_srti, "emergencyServicesPerson") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:fireman</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A member of the fire service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fireman">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fireman</seealso>
    let fireman = Prefixed_Name(dtx_srti, "fireman") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:infant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>Infant (age 0 to 3).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infant">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#infant</seealso>
    let infant = Prefixed_Name(dtx_srti, "infant") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:veryImportantPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PersonCategoryEnum</para>
    ///   <para>A very important person.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryImportantPerson">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#veryImportantPerson</seealso>
    let veryImportantPerson =
        Prefixed_Name(dtx_srti, "veryImportantPerson") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:segment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TPEGLoc01LinearLocationSubtypeEnum</para>
    ///   <para>A segment (or link) of the road network corresponding to the way in which the road operator has segmented the network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#segment">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#segment</seealso>
    let segment = Prefixed_Name(dtx_srti, "segment") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:blackIce</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Severe skid risk due to black ice (i.e. clear ice, which is impossible or very difficult to see).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blackIce">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#blackIce</seealso>
    let blackIce = Prefixed_Name(dtx_srti, "blackIce") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:ice</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Increased skid risk due to ice (of any kind).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ice">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ice</seealso>
    let ice = Prefixed_Name(dtx_srti, "ice") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:icyPatches</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Severe skid risk due to icy patches (i.e. intermittent ice on roadway).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#icyPatches">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#icyPatches</seealso>
    let icyPatches = Prefixed_Name(dtx_srti, "icyPatches") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:snowDrifts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    ///   <para>Snow drifting is in progress or patches of deep snow are present due to earlier drifting.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowDrifts">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowDrifts</seealso>
    let snowDrifts = Prefixed_Name(dtx_srti, "snowDrifts") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:surfaceWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Water is resting on the roadway which provides an increased hazard to vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#surfaceWater">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#surfaceWater</seealso>
    let surfaceWater = Prefixed_Name(dtx_srti, "surfaceWater") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:certain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ProbabilityOfOccurrenceEnum</para>
    ///   <para>The source is completely certain of the occurrence of the situation record version content.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#certain">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#certain</seealso>
    let certain = Prefixed_Name(dtx_srti, "certain") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:improbable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ProbabilityOfOccurrenceEnum</para>
    ///   <para>The source has a reasonably low level of confidence of the occurrence of the situation record version content.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#improbable">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#improbable</seealso>
    let improbable = Prefixed_Name(dtx_srti, "improbable") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:probable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ProbabilityOfOccurrenceEnum</para>
    ///   <para>The source has a reasonably high level of confidence of the occurrence of the situation record version content.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#probable">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#probable</seealso>
    let probable = Prefixed_Name(dtx_srti, "probable") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:riskOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ProbabilityOfOccurrenceEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The source has a moderate level of confidence of the occurrence of the situation record version content.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riskOf">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riskOf</seealso>
    let riskOf = Prefixed_Name(dtx_srti, "riskOf") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:leavesOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Increased skid risk due to leaves on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leavesOnRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#leavesOnRoad</seealso>
    let leavesOnRoad = Prefixed_Name(dtx_srti, "leavesOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:looseChippings</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Increased skid risk and injury risk due to loose chippings on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseChippings">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseChippings</seealso>
    let looseChippings = Prefixed_Name(dtx_srti, "looseChippings") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:looseSandOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NonWeatherRelatedRoadConditionTypeEnum</para>
    ///   <para>Increased skid risk due to loose sand on road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseSandOnRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#looseSandOnRoad</seealso>
    let looseSandOnRoad = Prefixed_Name(dtx_srti, "looseSandOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:erraticFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TrafficFlowCharateristicsEnum</para>
    ///   <para>Traffic flow is of an irregular nature, subject to sudden changes in rates.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#erraticFlow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#erraticFlow</seealso>
    let erraticFlow = Prefixed_Name(dtx_srti, "erraticFlow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:smoothFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficFlowCharateristicsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic flow is smooth.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothFlow">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smoothFlow</seealso>
    let smoothFlow = Prefixed_Name(dtx_srti, "smoothFlow") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:stopAndGo</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficFlowCharateristicsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic flow is of a stop and go nature with queues forming and ending continuously on the specified section of road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAndGo">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stopAndGo</seealso>
    let stopAndGo = Prefixed_Name(dtx_srti, "stopAndGo") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:trafficBlocked</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TrafficFlowCharateristicsEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic is blocked at the specified location and in the specified direction due to an unplanned event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBlocked">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficBlocked</seealso>
    let trafficBlocked = Prefixed_Name(dtx_srti, "trafficBlocked") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:anyGeneralDeliveryService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationDeliveryServicesEnum</para>
    ///   <para>Includes any general delivery channel such as broadcast channels (e.g. radio, tv, RDS-TMC, TPEG services, etc.) or web publishing available to public or to specific users, depending on Service Provider policies.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyGeneralDeliveryService">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#anyGeneralDeliveryService</seealso>
    let anyGeneralDeliveryService =
        Prefixed_Name(dtx_srti, "anyGeneralDeliveryService") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:safetyServices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationDeliveryServicesEnum</para>
    ///   <para>Specific services which deliver warning alerts to end users to enhance safety via any specific application available to drivers, including C-ITS services.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyServices">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#safetyServices</seealso>
    let safetyServices = Prefixed_Name(dtx_srti, "safetyServices") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:InformationDeliveryServicesEnum</para>
    ///   <para>Variable Message Signs or any other visual roadside devices which information are accessible to drivers which aim to affect driving style improving safety and road network LoS.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vms">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vms</seealso>
    let vms = Prefixed_Name(dtx_srti, "vms") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tpegIlcName1</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03IlcPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The name of the road on which the junction point is located.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName1">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName1</seealso>
    let tpegIlcName1 = Prefixed_Name(dtx_srti, "tpegIlcName1") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tpegIlcName2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:TpegLoc03IlcPointDescriptorSubtypeEnum</para>
    ///   <para>The name of the first intersecting road at the junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName2">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName2</seealso>
    let tpegIlcName2 = Prefixed_Name(dtx_srti, "tpegIlcName2") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:tpegIlcName3</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03IlcPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The name of the second intersecting road (if one exists) at the junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName3">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tpegIlcName3</seealso>
    let tpegIlcName3 = Prefixed_Name(dtx_srti, "tpegIlcName3") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:betweenOneHourAndThreeHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Delay between one hour and three hours.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenOneHourAndThreeHours">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenOneHourAndThreeHours</seealso>
    let betweenOneHourAndThreeHours =
        Prefixed_Name(dtx_srti, "betweenOneHourAndThreeHours") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:betweenTenMinutesAndThirtyMinutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Delay between ten minutes and thirty minutes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenTenMinutesAndThirtyMinutes">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenTenMinutesAndThirtyMinutes</seealso>
    let betweenTenMinutesAndThirtyMinutes =
        Prefixed_Name(dtx_srti, "betweenTenMinutesAndThirtyMinutes") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:betweenThirtyMinutesAndOneHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Delay between thirty minutes and one hour.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThirtyMinutesAndOneHour">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThirtyMinutesAndOneHour</seealso>
    let betweenThirtyMinutesAndOneHour =
        Prefixed_Name(dtx_srti, "betweenThirtyMinutesAndOneHour") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:betweenThreeHoursAndSixHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:DelayBandEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Delay between three hours and six hours.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThreeHoursAndSixHours">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#betweenThreeHoursAndSixHours</seealso>
    let betweenThreeHoursAndSixHours =
        Prefixed_Name(dtx_srti, "betweenThreeHoursAndSixHours") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotUseEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is not to use the specified entry onto the identified road to commence the alternative route.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseEntry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseEntry</seealso>
    let doNotUseEntry = Prefixed_Name(dtx_srti, "doNotUseEntry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:doNotUseExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is not to use the specified exit from the identified road to commence the alternative route.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseExit">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseExit</seealso>
    let doNotUseExit = Prefixed_Name(dtx_srti, "doNotUseExit") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:doNotUseIntersectionOrJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>Rerouted traffic is not to use the specified intersection or junction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseIntersectionOrJunction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#doNotUseIntersectionOrJunction</seealso>
    let doNotUseIntersectionOrJunction =
        Prefixed_Name(dtx_srti, "doNotUseIntersectionOrJunction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:followDiversionSigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is to follow the diversion signs.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followDiversionSigns">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followDiversionSigns</seealso>
    let followDiversionSigns =
        Prefixed_Name(dtx_srti, "followDiversionSigns") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:followLocalDiversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is to follow local diversion.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followLocalDiversion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followLocalDiversion</seealso>
    let followLocalDiversion =
        Prefixed_Name(dtx_srti, "followLocalDiversion") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:followSpecialMarkers</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is to follow the special diversion markers.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followSpecialMarkers">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#followSpecialMarkers</seealso>
    let followSpecialMarkers =
        Prefixed_Name(dtx_srti, "followSpecialMarkers") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is to use the specified entry onto the identified road to commence the alternative route.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useEntry">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useEntry</seealso>
    let useEntry = Prefixed_Name(dtx_srti, "useEntry") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:useExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>Rerouted traffic is to use the specified exit from the identified road to commence the alternative route.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useExit">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useExit</seealso>
    let useExit = Prefixed_Name(dtx_srti, "useExit") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:useIntersectionOrJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rerouted traffic is to use the specified intersection or junction to commence the alternative route.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useIntersectionOrJunction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#useIntersectionOrJunction</seealso>
    let useIntersectionOrJunction =
        Prefixed_Name(dtx_srti, "useIntersectionOrJunction") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficFlowNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic flow normal</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficFlowNormal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficFlowNormal</seealso>
    let trafficFlowNormal = Prefixed_Name(dtx_srti, "trafficFlowNormal") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficHeavierThanNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    ///   <para>Traffic heavier than normal</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeavierThanNormal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficHeavierThanNormal</seealso>
    let trafficHeavierThanNormal =
        Prefixed_Name(dtx_srti, "trafficHeavierThanNormal") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficLighterThanNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Traffic lighter than normal</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficLighterThanNormal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficLighterThanNormal</seealso>
    let trafficLighterThanNormal =
        Prefixed_Name(dtx_srti, "trafficLighterThanNormal") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficVeryMuchHeavierThanNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    ///   <para>Traffic very much heavier than normal</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchHeavierThanNormal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchHeavierThanNormal</seealso>
    let trafficVeryMuchHeavierThanNormal =
        Prefixed_Name(dtx_srti, "trafficVeryMuchHeavierThanNormal") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:trafficVeryMuchLighterThanNormal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    ///   <para>Traffic very much lighter than normal</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchLighterThanNormal">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#trafficVeryMuchLighterThanNormal</seealso>
    let trafficVeryMuchLighterThanNormal =
        Prefixed_Name(dtx_srti, "trafficVeryMuchLighterThanNormal") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:allLanesCompleteCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In all lanes of the carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allLanesCompleteCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allLanesCompleteCarriageway</seealso>
    let allLanesCompleteCarriageway =
        Prefixed_Name(dtx_srti, "allLanesCompleteCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:slowVehicleLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In a lane dedicated to vehicles that are not permitted to exceed a fixed slow speed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicleLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#slowVehicleLane</seealso>
    let slowVehicleLane = Prefixed_Name(dtx_srti, "slowVehicleLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:throughTrafficLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the through traffic lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#throughTrafficLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#throughTrafficLane</seealso>
    let throughTrafficLane =
        Prefixed_Name(dtx_srti, "throughTrafficLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tidalFlowLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>In the lane dedicated for use as a tidal flow lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tidalFlowLane</seealso>
    let tidalFlowLane = Prefixed_Name(dtx_srti, "tidalFlowLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:turningLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In the turning lane.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turningLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#turningLane</seealso>
    let turningLane = Prefixed_Name(dtx_srti, "turningLane") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:verge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>On the verge.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#verge">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#verge</seealso>
    let verge = Prefixed_Name(dtx_srti, "verge") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:accidentInvolvingRadioactiveMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Accident involving radioactive material.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingRadioactiveMaterial">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#accidentInvolvingRadioactiveMaterial</seealso>
    let accidentInvolvingRadioactiveMaterial =
        Prefixed_Name(dtx_srti, "accidentInvolvingRadioactiveMaterial") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:applicationRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Application region</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#applicationRegion">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#applicationRegion</seealso>
    let applicationRegion = Prefixed_Name(dtx_srti, "applicationRegion") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:carParkArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Car park area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carParkArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carParkArea</seealso>
    let carParkArea = Prefixed_Name(dtx_srti, "carParkArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:carpoolArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Carpool area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carpoolArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#carpoolArea</seealso>
    let carpoolArea = Prefixed_Name(dtx_srti, "carpoolArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Continent</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#continent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#continent</seealso>
    let continent = Prefixed_Name(dtx_srti, "continent") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:countryGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Group of countries.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countryGroup">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#countryGroup</seealso>
    let countryGroup = Prefixed_Name(dtx_srti, "countryGroup") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fuzzyArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Fuzzy area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fuzzyArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fuzzyArea</seealso>
    let fuzzyArea = Prefixed_Name(dtx_srti, "fuzzyArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:industrialArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Industrial area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#industrialArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#industrialArea</seealso>
    let industrialArea = Prefixed_Name(dtx_srti, "industrialArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:lake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Lake</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lake">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#lake</seealso>
    let lake = Prefixed_Name(dtx_srti, "lake") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:meteorologicalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:NamedAreaTypeEnum</para>
    ///   <para>Meteorological area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#meteorologicalArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#meteorologicalArea</seealso>
    let meteorologicalArea =
        Prefixed_Name(dtx_srti, "meteorologicalArea") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:crosswinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Strong cross winds across the direction of the roadway (e.g. on a ridge or bridge).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crosswinds">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#crosswinds</seealso>
    let crosswinds = Prefixed_Name(dtx_srti, "crosswinds") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:extremeCold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Abnormally low temperatures.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeCold">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeCold</seealso>
    let extremeCold = Prefixed_Name(dtx_srti, "extremeCold") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:extremeHeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Abnormally high expected maximum temperature.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeHeat">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#extremeHeat</seealso>
    let extremeHeat = Prefixed_Name(dtx_srti, "extremeHeat") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:fog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Fog, visibility more than 50m.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fog">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#fog</seealso>
    let fog = Prefixed_Name(dtx_srti, "fog") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Frost can be expected.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frost">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frost</seealso>
    let frost = Prefixed_Name(dtx_srti, "frost") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hail</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Small balls of ice and compacted snow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hail">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hail</seealso>
    let hail = Prefixed_Name(dtx_srti, "hail") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:rain</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rain, visibility more than 50m.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rain">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#rain</seealso>
    let rain = Prefixed_Name(dtx_srti, "rain") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:sandStorms</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Sand blowing across the roadway causing significantly reduced visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sandStorms">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#sandStorms</seealso>
    let sandStorms = Prefixed_Name(dtx_srti, "sandStorms") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:smokeHazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Smoke drifting across the roadway causing significantly reduced visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smokeHazard">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#smokeHazard</seealso>
    let smokeHazard = Prefixed_Name(dtx_srti, "smokeHazard") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:snowFall</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Falling snow, visibility more than 50m.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowFall">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#snowFall</seealso>
    let snowFall = Prefixed_Name(dtx_srti, "snowFall") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:stormForceWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Winds between 90 km/h and 120 km/h.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stormForceWinds">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#stormForceWinds</seealso>
    let stormForceWinds = Prefixed_Name(dtx_srti, "stormForceWinds") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:strongGustsOfWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Constantly varying winds, strong at times.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongGustsOfWinds">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongGustsOfWinds</seealso>
    let strongGustsOfWinds =
        Prefixed_Name(dtx_srti, "strongGustsOfWinds") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:strongWinds</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Winds between 40 km/h and 60 km/h.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongWinds">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#strongWinds</seealso>
    let strongWinds = Prefixed_Name(dtx_srti, "strongWinds") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:swarmOfInsects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>Large numbers of insects which create a hazard for road users through reduced visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#swarmOfInsects">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#swarmOfInsects</seealso>
    let swarmOfInsects = Prefixed_Name(dtx_srti, "swarmOfInsects") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:visibilityReduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Environmental conditions causing reduced visibility.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#visibilityReduced">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#visibilityReduced</seealso>
    let visibilityReduced = Prefixed_Name(dtx_srti, "visibilityReduced") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTrafficFlowCharacteristicsEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The consistency (steadiness) of the traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficFlowCharacteristicsEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficFlowCharacteristicsEnum</seealso>
    let hasTrafficFlowCharacteristicsEnum =
        Prefixed_Name(dtx_srti, "hasTrafficFlowCharacteristicsEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RelativeTrafficFlowEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativeTrafficFlowEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RelativeTrafficFlowEnum</seealso>
    let RelativeTrafficFlowEnum =
        Prefixed_Name(dtx_srti, "RelativeTrafficFlowEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRelativeTrafficFlowEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Assessment of the traffic flow conditions relative to normally expected conditions at this date/time.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRelativeTrafficFlowEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRelativeTrafficFlowEnum</seealso>
    let hasRelativeTrafficFlowEnum =
        Prefixed_Name(dtx_srti, "hasRelativeTrafficFlowEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:AbnormalTrafficTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Descriptive terms for abnormal traffic conditions specifically relating to the nature of the traffic movement, implying levels of service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTrafficTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AbnormalTrafficTypeEnum</seealso>
    let AbnormalTrafficTypeEnum =
        Prefixed_Name(dtx_srti, "AbnormalTrafficTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAbnormalTrafficType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A characterization of the nature of abnormal traffic flow, i.e. specifically relating to the nature of the traffic movement, implying a level of service.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAbnormalTrafficType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAbnormalTrafficType</seealso>
    let hasAbnormalTrafficType =
        Prefixed_Name(dtx_srti, "hasAbnormalTrafficType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TrafficElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event which is not planned by the traffic operator, which is affecting, or has the potential to affect traffic flow.</para>
    ///   <para>Traffic element.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TrafficElement</seealso>
    let TrafficElement = Prefixed_Name(dtx_srti, "TrafficElement") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Non-SRTI_Enum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collects the added non-SRTI enumerations. Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Non-SRTI_Enum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Non-SRTI_Enum</seealso>
    let Non_SRTI_Enum = Prefixed_Name(dtx_srti, "Non-SRTI_Enum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Accident</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Accidents are events where one or more vehicles are involved in collisions or in leaving the roadway. These include collisions between vehicles or with other road users or obstacles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Accident">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Accident</seealso>
    let Accident = Prefixed_Name(dtx_srti, "Accident") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AccidentTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection of descriptive terms for types of accidents.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentTypeEnum</seealso>
    let AccidentTypeEnum = Prefixed_Name(dtx_srti, "AccidentTypeEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasAccidentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A characterization of the nature of the accident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAccidentType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAccidentType</seealso>
    let hasAccidentType = Prefixed_Name(dtx_srti, "hasAccidentType") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Obstruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any stationary or moving obstacle of a physical nature (e.g. obstacles or vehicles from an earlier accident, shed loads on carriageway, rock fall, abnormal or dangerous loads, or animals etc.) which could disrupt or endanger traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Obstruction">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Obstruction</seealso>
    let Obstruction = Prefixed_Name(dtx_srti, "Obstruction") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:Conditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any conditions which have the potential to degrade normal driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Conditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Conditions</seealso>
    let Conditions = Prefixed_Name(dtx_srti, "Conditions") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:AccidentCauseEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection of descriptive terms for causes of accidents.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentCauseEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#AccidentCauseEnum</seealso>
    let AccidentCauseEnum = Prefixed_Name(dtx_srti, "AccidentCauseEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:SituationEnumerations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Only for organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationEnumerations">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#SituationEnumerations</seealso>
    let SituationEnumerations =
        Prefixed_Name(dtx_srti, "SituationEnumerations") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General instruction and/or message that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsers">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsers</seealso>
    let GeneralInstructionOrMessageToRoadUsers =
        Prefixed_Name(dtx_srti, "GeneralInstructionOrMessageToRoadUsers") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:generalMessageToRoadUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>General message that is issued by the network/road operator which is applicable to drivers and sometimes passengers, e.g. details about an amber alert (missing or abducted child alert).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#generalMessageToRoadUsers">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#generalMessageToRoadUsers</seealso>
    let generalMessageToRoadUsers =
        Prefixed_Name(dtx_srti, "generalMessageToRoadUsers") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeneralInstructionOrMessageToRoadUsersTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>General instructions that may be issued to road users (specifically drivers and sometimes passengers) by an operator or operational system in support of network management activities or emergency situations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsersTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralInstructionOrMessageToRoadUsersTypeEnum</seealso>
    let GeneralInstructionOrMessageToRoadUsersTypeEnum =
        Prefixed_Name(dtx_srti, "GeneralInstructionOrMessageToRoadUsersTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGeneralInstructionOrMessageToRoadUsersType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>General instruction that is issued by the network/road operator which is applicable to drivers and sometimes passengers.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralInstructionOrMessageToRoadUsersType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGeneralInstructionOrMessageToRoadUsersType</seealso>
    let hasGeneralInstructionOrMessageToRoadUsersType =
        Prefixed_Name(dtx_srti, "hasGeneralInstructionOrMessageToRoadUsersType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:NetworkManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Restrictions on road usage, whether by legal order or by operational decisions. It includes road and lane closures, weight and dimensional limits, banned turns, contraflows and alternate traffic operations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#NetworkManagement</seealso>
    let NetworkManagement = Prefixed_Name(dtx_srti, "NetworkManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PositionConfidenceEllipse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceEllipse">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PositionConfidenceEllipse</seealso>
    let PositionConfidenceEllipse =
        Prefixed_Name(dtx_srti, "PositionConfidenceEllipse") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPositionConfidenceEllipse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Confidence ellipse position defined in a shape of ellipse with a predefined confidence level (e.g. 95 %). The centre of the ellipse shape corresponds to the reference position point for which the position accuracy is evaluated.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceEllipse">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPositionConfidenceEllipse</seealso>
    let hasPositionConfidenceEllipse =
        Prefixed_Name(dtx_srti, "hasPositionConfidenceEllipse") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasHeightCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Third coordinate for points defined geodetically</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightCoordinate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightCoordinate</seealso>
    let hasHeightCoordinate =
        Prefixed_Name(dtx_srti, "hasHeightCoordinate") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location representing a single geospatial point.</para>
    ///   <para>At least one of these aggregated classes must be present. If using multiple instances of the agregated classes, producers must take care to ensure they present the same location.
    ///
    /// Associations:
    /// 0..1	PointByCoordinates
    /// 0..*	PointAlongLinearElement
    /// 0..*	AlertCPoint
    /// 0..1	TpegPointLocation
    /// 0..1	OpenlrPointLocationReference</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointLocation</seealso>
    let PointLocation = Prefixed_Name(dtx_srti, "PointLocation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:TpegPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single point on the road network defined by a TPEG-Loc structure and which has an associated direction of traffic flow.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TpegPointLocation</seealso>
    let TpegPointLocation = Prefixed_Name(dtx_srti, "TpegPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTpegPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>PointLocation is associated to TpegPointLocation with cardinality 0..1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTpegPointLocation</seealso>
    let hasTpegPointLocation =
        Prefixed_Name(dtx_srti, "hasTpegPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPointByCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>PointLocation is associated to PointByCoordinates with cardinality 0..1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointByCoordinates">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointByCoordinates</seealso>
    let hasPointByCoordinates =
        Prefixed_Name(dtx_srti, "hasPointByCoordinates") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOpenlrPointLocationReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>PointLocation is associated to OpenlrPointLocationReference with cardinality 0..1</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPointLocationReference">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOpenlrPointLocationReference</seealso>
    let hasOpenlrPointLocationReference =
        Prefixed_Name(dtx_srti, "hasOpenlrPointLocationReference") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PoorEnvironmentConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any environmental conditions which may be affecting the driving conditions on the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentConditions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentConditions</seealso>
    let PoorEnvironmentConditions =
        Prefixed_Name(dtx_srti, "PoorEnvironmentConditions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PoorEnvironmentTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of poor environmental conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PoorEnvironmentTypeEnum</seealso>
    let PoorEnvironmentTypeEnum =
        Prefixed_Name(dtx_srti, "PoorEnvironmentTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPoorEnvironmentTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any environmental conditions which may be affecting the driving conditions on the road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPoorEnvironmentTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPoorEnvironmentTypeEnum</seealso>
    let hasPoorEnvironmentTypeEnum =
        Prefixed_Name(dtx_srti, "hasPoorEnvironmentTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasTrafficConstrictionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Types of the constriction to which traffic is subjected as a result of an event.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficConstrictionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasTrafficConstrictionTypeEnum</seealso>
    let hasTrafficConstrictionTypeEnum =
        Prefixed_Name(dtx_srti, "hasTrafficConstrictionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:TransitServiceInformationEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of public transport information.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TransitServiceInformationEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#TransitServiceInformationEnum</seealso>
    let TransitServiceInformationEnum =
        Prefixed_Name(dtx_srti, "TransitServiceInformationEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:validityTimeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A specification of periods of validity defined by overall bounding start and end times and the possible intersection of valid periods with exception periods (exception periods overriding valid periods).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#validityTimeSpecification">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#validityTimeSpecification</seealso>
    let validityTimeSpecification =
        Prefixed_Name(dtx_srti, "validityTimeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ValidityStatusEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Values of validity status that can be assigned to a described event, action or item</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ValidityStatusEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ValidityStatusEnum</seealso>
    let ValidityStatusEnum =
        Prefixed_Name(dtx_srti, "ValidityStatusEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Details of an individual vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Vehicle">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Vehicle</seealso>
    let Vehicle = Prefixed_Name(dtx_srti, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:VehicleStatusEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of a vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleStatusEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleStatusEnum</seealso>
    let VehicleStatusEnum = Prefixed_Name(dtx_srti, "VehicleStatusEnum") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasVehicleStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Vehicle status.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleStatus">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleStatus</seealso>
    let hasVehicleStatus = Prefixed_Name(dtx_srti, "hasVehicleStatus") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:VehicleCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleCharacteristics">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleCharacteristics</seealso>
    let VehicleCharacteristics =
        Prefixed_Name(dtx_srti, "VehicleCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasVehicleCharacteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The characteristics of a vehicle, e.g. lorry of gross weight greater than 30 tonnes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleCharacteristics">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleCharacteristics</seealso>
    let hasVehicleCharacteristics =
        Prefixed_Name(dtx_srti, "hasVehicleCharacteristics") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:VehicleFlowValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measured or calculated value of the flow rate of vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleFlowValue">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleFlowValue</seealso>
    let VehicleFlowValue = Prefixed_Name(dtx_srti, "VehicleFlowValue") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:vehicleFlowRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value of vehicle flow rate expressed in vehicles per hour.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFlowRate">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#vehicleFlowRate</seealso>
    let vehicleFlowRate = Prefixed_Name(dtx_srti, "vehicleFlowRate") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:VehicleTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of vehicle.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleTypeEnum</seealso>
    let VehicleTypeEnum = Prefixed_Name(dtx_srti, "VehicleTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasVehicleTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Vehicle type.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleTypeEnum</seealso>
    let hasVehicleTypeEnum =
        Prefixed_Name(dtx_srti, "hasVehicleTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:VehicleObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of obstructions involving vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#VehicleObstructionTypeEnum</seealso>
    let VehicleObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "VehicleObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasVehicleObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Characterization of an obstruction on the road caused by one or more vehicles.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehicleObstructionTypeEnum</seealso>
    let hasVehicleObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "hasVehicleObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:WeatherRelatedRoadConditionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of road surface conditions which are related to the weather.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditionType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WeatherRelatedRoadConditionType</seealso>
    let WeatherRelatedRoadConditionType =
        Prefixed_Name(dtx_srti, "WeatherRelatedRoadConditionType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasWeatherRelatedRoadConditionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of road surface condition that is related to the weather which is affecting the driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWeatherRelatedRoadConditionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWeatherRelatedRoadConditionTypeEnum</seealso>
    let hasWeatherRelatedRoadConditionTypeEnum =
        Prefixed_Name(dtx_srti, "hasWeatherRelatedRoadConditionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:WinterDrivingManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Winter driving management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterDrivingManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterDrivingManagement</seealso>
    let WinterDrivingManagement =
        Prefixed_Name(dtx_srti, "WinterDrivingManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:WinterEquipmentManagementTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of winter equipment management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterEquipmentManagementTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#WinterEquipmentManagementTypeEnum</seealso>
    let WinterEquipmentManagementTypeEnum =
        Prefixed_Name(dtx_srti, "WinterEquipmentManagementTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:alertCDirectionNamed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ALERT-C name of a direction e.g. Brussels -&gt; Lille.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCDirectionNamed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#alertCDirectionNamed</seealso>
    let alertCDirectionNamed =
        Prefixed_Name(dtx_srti, "alertCDirectionNamed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:allowedDeliveryChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The allowed delivery channel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowedDeliveryChannel">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#allowedDeliveryChannel</seealso>
    let allowedDeliveryChannel =
        Prefixed_Name(dtx_srti, "allowedDeliveryChannel") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:geoSparqlDataProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlDataProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlDataProperties</seealso>
    let geoSparqlDataProperties =
        Prefixed_Name(dtx_srti, "geoSparqlDataProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:importedDataProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedDataProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedDataProperties</seealso>
    let importedDataProperties =
        Prefixed_Name(dtx_srti, "importedDataProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:geoSparqlObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only for organizational purposes. GeoSparql object properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlObjectProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geoSparqlObjectProperties</seealso>
    let geoSparqlObjectProperties =
        Prefixed_Name(dtx_srti, "geoSparqlObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:importedObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only for organizational purposes. Imported object properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedObjectProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#importedObjectProperties</seealso>
    let importedObjectProperties =
        Prefixed_Name(dtx_srti, "importedObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:geo_WGS84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes. Properties of the WGS84 Geo Positioning by World Wide Web Consortium (W3C). A vocabulary for representing latitude, longitude and altitude information in the WGS84 geodetic reference datum. WGS stands for the World Geodetic Survey.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_WGS84">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_WGS84</seealso>
    let geo_WGS84 = Prefixed_Name(dtx_srti, "geo_WGS84") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:geo_core</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>For organizational purposes. Properties of the ontology for the representation of Geographical Objects https://datos.ign.es/def/geo_core</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_core">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#geo_core</seealso>
    let geo_core = Prefixed_Name(dtx_srti, "geo_core") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasAlertCArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ALERT-C Area</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCArea">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCArea</seealso>
    let hasAlertCArea = Prefixed_Name(dtx_srti, "hasAlertCArea") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasAlertCPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>PointLocation is associated to AlertCPoint with cardinality 0..*</para>
    ///   <para>A single point on the road network defined by reference to a pre-defined ALERT-C location table and which has an associated direction of traffic flow.</para>
    ///   <para>ALERT-C point</para>
    ///   <para>The point location expressed using AlertC. Multiple instances of AlertCPoint shall represent the same real-world geographic feature.They should represent the same point using different location tables.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAlertCPoint</seealso>
    let hasAlertCPoint = Prefixed_Name(dtx_srti, "hasAlertCPoint") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:hasCarriageway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Supplementary positional information which details carriageway and lane locations. Several instances may exist where the element being described extends over more than one carriageway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriageway">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasCarriageway</seealso>
    let hasCarriageway = Prefixed_Name(dtx_srti, "hasCarriageway") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDisturbanceActivityTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDisturbanceActivityTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDisturbanceActivityTypeEnum</seealso>
    let hasDisturbanceActivityTypeEnum =
        Prefixed_Name(dtx_srti, "hasDisturbanceActivityTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasGmlInteriorLinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A boundary of internal patches of a polygonal surface consisting of a ring feature</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlInteriorLinearRing">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasGmlInteriorLinearRing</seealso>
    let hasGmlInteriorLinearRing =
        Prefixed_Name(dtx_srti, "hasGmlInteriorLinearRing") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a specific lane or group of lanes.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLane">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLane</seealso>
    let hasLane = Prefixed_Name(dtx_srti, "hasLane") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasLinearWithinLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a linear section along a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with ISO 19148 definitions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearWithinLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasLinearWithinLinearElement</seealso>
    let hasLinearWithinLinearElement =
        Prefixed_Name(dtx_srti, "hasLinearWithinLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:isLocationReferenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is location reference of ...</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#isLocationReferenceOf">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#isLocationReferenceOf</seealso>
    let isLocationReferenceOf =
        Prefixed_Name(dtx_srti, "isLocationReferenceOf") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasMaintenanceVehicleActions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The actions of the maintenance vehicles associated with the roadworks activities.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicleActions">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasMaintenanceVehicleActions</seealso>
    let hasMaintenanceVehicleActions =
        Prefixed_Name(dtx_srti, "hasMaintenanceVehicleActions") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOverallEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallEndTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallEndTime</seealso>
    let hasOverallEndTime = Prefixed_Name(dtx_srti, "hasOverallEndTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasOverallStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallStartTime">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasOverallStartTime</seealso>
    let hasOverallStartTime =
        Prefixed_Name(dtx_srti, "hasOverallStartTime") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasPointAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>PointLocation is associated to PointAlongLinearElement with cardinality 0..*</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointAlongLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasPointAlongLinearElement</seealso>
    let hasPointAlongLinearElement =
        Prefixed_Name(dtx_srti, "hasPointAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies a referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferent</seealso>
    let hasReferent = Prefixed_Name(dtx_srti, "hasReferent") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information on a set of one or more roads. The location could correspond to a part of the road identified, the whole stretch of road identified, or a combination of multiple road sections.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadInformation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadInformation</seealso>
    let hasRoadInformation =
        Prefixed_Name(dtx_srti, "hasRoadInformation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasRoadOrCarriagewayOrLaneManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Management actions relating to road, carriageway or lane usage.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadOrCarriagewayOrLaneManagementType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasRoadOrCarriagewayOrLaneManagementType</seealso>
    let hasRoadOrCarriagewayOrLaneManagementType =
        Prefixed_Name(dtx_srti, "hasRoadOrCarriagewayOrLaneManagementType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>traffic/travel situations.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSituation</seealso>
    let hasSituation = Prefixed_Name(dtx_srti, "hasSituation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasVehiclesInvolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The vehicle involved in the accident.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehiclesInvolved">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasVehiclesInvolved</seealso>
    let hasVehiclesInvolved =
        Prefixed_Name(dtx_srti, "hasVehiclesInvolved") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasWinterEquipmentManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of winter equipment management action instigated by operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWinterEquipmentManagementType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasWinterEquipmentManagementType</seealso>
    let hasWinterEquipmentManagementType =
        Prefixed_Name(dtx_srti, "hasWinterEquipmentManagementType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:qudtObjectProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only for organizational purposes. Qudt object properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#qudtObjectProperties">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#qudtObjectProperties</seealso>
    let qudtObjectProperties =
        Prefixed_Name(dtx_srti, "qudtObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:pointOfInterestName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a general point of interest.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointOfInterestName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#pointOfInterestName</seealso>
    let pointOfInterestName =
        Prefixed_Name(dtx_srti, "pointOfInterestName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:riverName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a river.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riverName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#riverName</seealso>
    let riverName = Prefixed_Name(dtx_srti, "riverName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:serviceAreaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:TpegLoc03OtherPointDescriptorSubtypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Name of a service area on a road network.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceAreaName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#serviceAreaName</seealso>
    let serviceAreaName = Prefixed_Name(dtx_srti, "serviceAreaName") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:layBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:LaneEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>In a lay-by.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#layBy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#layBy</seealso>
    let layBy = Prefixed_Name(dtx_srti, "layBy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DrivingConditionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of the perceived driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DrivingConditionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DrivingConditionTypeEnum</seealso>
    let DrivingConditionTypeEnum =
        Prefixed_Name(dtx_srti, "DrivingConditionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasDrivingConditionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Types of the perceived driving conditions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDrivingConditionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasDrivingConditionTypeEnum</seealso>
    let hasDrivingConditionTypeEnum =
        Prefixed_Name(dtx_srti, "hasDrivingConditionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ConstructionWorkTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of works relating to construction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorkTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorkTypeEnum</seealso>
    let ConstructionWorkTypeEnum =
        Prefixed_Name(dtx_srti, "ConstructionWorkTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ConstructionWorks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Roadworks involving the construction of new infrastructure.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorks">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ConstructionWorks</seealso>
    let ConstructionWorks = Prefixed_Name(dtx_srti, "ConstructionWorks") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasConstructionWorkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of construction work being performed.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConstructionWorkType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasConstructionWorkType</seealso>
    let hasConstructionWorkType =
        Prefixed_Name(dtx_srti, "hasConstructionWorkType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfInputValuesUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of input values used in the sampling or measurement period to determine the data value.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfInputValuesUsed">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfInputValuesUsed</seealso>
    let numberOfInputValuesUsed =
        Prefixed_Name(dtx_srti, "numberOfInputValuesUsed") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:numberOfIncompleteInputs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of inputs detected but not completed during the sampling or measurement period; e.g. vehicles detected entering but not exiting the detection zone.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfIncompleteInputs">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#numberOfIncompleteInputs</seealso>
    let numberOfIncompleteInputs =
        Prefixed_Name(dtx_srti, "numberOfIncompleteInputs") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:standardDeviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The standard deviation of the sample of input values from which this value was derived, measured in the units of the data value.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#standardDeviation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#standardDeviation</seealso>
    let standardDeviation = Prefixed_Name(dtx_srti, "standardDeviation") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:supplierCalculatedDataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measure of data quality assigned to the value by the supplier. 100% equates to ideal/perfect quality. The method of calculation is supplier specific and needs to be agreed between supplier and client.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#supplierCalculatedDataQuality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#supplierCalculatedDataQuality</seealso>
    let supplierCalculatedDataQuality =
        Prefixed_Name(dtx_srti, "supplierCalculatedDataQuality") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasComputationMethodEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Method of computation which has been used to compute this data value.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasComputationMethodEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasComputationMethodEnum</seealso>
    let hasComputationMethodEnum =
        Prefixed_Name(dtx_srti, "hasComputationMethodEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Delays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The details of the delays being caused by the situation element defined in the situation record. It is recommended to only use one of the optional attributes to avoid confusion.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Delays">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Delays</seealso>
    let Delays = Prefixed_Name(dtx_srti, "Delays") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:delaysType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Coarse classification of the delay.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delaysType</seealso>
    let delaysType = Prefixed_Name(dtx_srti, "delaysType") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:delayBand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time band within which the additional travel time due to adverse travel conditions of any kind falls, when compared to "normal conditions".</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayBand">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#delayBand</seealso>
    let delayBand = Prefixed_Name(dtx_srti, "delayBand") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:DirectionEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>List of directions of travel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionEnum</seealso>
    let DirectionEnum = Prefixed_Name(dtx_srti, "DirectionEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DirectionPurposeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Main purpose of a direction of a road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionPurposeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DirectionPurposeEnum</seealso>
    let DirectionPurposeEnum =
        Prefixed_Name(dtx_srti, "DirectionPurposeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DistanceFromLinearElementReferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance of a point along a linear element measured from a "from referent" on the linear element, in the sense relative to the linear element definition rather than the direction of traffic flow or optionally towards a "towards referent".</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementReferent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DistanceFromLinearElementReferent</seealso>
    let DistanceFromLinearElementReferent =
        Prefixed_Name(dtx_srti, "DistanceFromLinearElementReferent") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A referent on a linear object that has a known location such as a node, a reference marker (e.g. a marker-post), an intersection etc.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Referent">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Referent</seealso>
    let Referent = Prefixed_Name(dtx_srti, "Referent") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentTowards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A known location along the linear element towards which the distanceAlong is measured, termed the "towardsReferent" in EN ISO 19148.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTowards">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTowards</seealso>
    let hasReferentTowards =
        Prefixed_Name(dtx_srti, "hasReferentTowards") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A known location along the linear element from which the distanceAlong is measured, termed the "fromReferent" in EN ISO 19148.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentFrom">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentFrom</seealso>
    let hasReferentFrom = Prefixed_Name(dtx_srti, "hasReferentFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DisturbanceActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Deliberate human action of either a public disorder nature or of a situation alert type which could disrupt traffic.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivity</seealso>
    let DisturbanceActivity =
        Prefixed_Name(dtx_srti, "DisturbanceActivity") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:DisturbanceActivityTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of disturbance activities.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivityTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#DisturbanceActivityTypeEnum</seealso>
    let DisturbanceActivityTypeEnum =
        Prefixed_Name(dtx_srti, "DisturbanceActivityTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:PointAlongLinearElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point on a linear element where the linear element is either a part of or the whole of a linear object (i.e. a road), consistent with EN ISO 19148 definitions.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointAlongLinearElement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#PointAlongLinearElement</seealso>
    let PointAlongLinearElement =
        Prefixed_Name(dtx_srti, "PointAlongLinearElement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasHeightGradeOfPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identification of whether the point on the linear element is at, above or below the normal elevation of a linear element of that type (e.g. road or road section) at that location, typically used to indicate "grade" separation.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasHeightGradeOfPoint</seealso>
    let hasHeightGradeOfPoint =
        Prefixed_Name(dtx_srti, "hasHeightGradeOfPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasAdministrativeAreaOfPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identification of the road administration area which contains the specified point.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfPoint">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasAdministrativeAreaOfPoint</seealso>
    let hasAdministrativeAreaOfPoint =
        Prefixed_Name(dtx_srti, "hasAdministrativeAreaOfPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:specificLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique code within the ALERT-C location table which identifies the specific point, linear or area location.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specificLocation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#specificLocation</seealso>
    let specificLocation = Prefixed_Name(dtx_srti, "specificLocation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:airCrash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>An air crash adjacent to the roadway which may cause traffic disruption.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airCrash">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#airCrash</seealso>
    let airCrash = Prefixed_Name(dtx_srti, "airCrash") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:objectOnTheRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The road may be obstructed or traffic hindered due to objects laying on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#objectOnTheRoad">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#objectOnTheRoad</seealso>
    let objectOnTheRoad = Prefixed_Name(dtx_srti, "objectOnTheRoad") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:policePatrol</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SourceTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A police patrol.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policePatrol">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#policePatrol</seealso>
    let policePatrol = Prefixed_Name(dtx_srti, "policePatrol") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:frc7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:OpenlrFunctionalRoadClassEnum</para>
    ///   <para>Other class road, lowest importance</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc7">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#frc7</seealso>
    let frc7 = Prefixed_Name(dtx_srti, "frc7") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:none</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SeverityEnum</para>
    ///   <para>Perceived by supplier as having a severity rating of none.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#none">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#none</seealso>
    let none = Prefixed_Name(dtx_srti, "none") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:autonomousCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Autonomous city</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCity">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#autonomousCity</seealso>
    let autonomousCity = Prefixed_Name(dtx_srti, "autonomousCity") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:cityMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>City municipality</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityMunicipality">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#cityMunicipality</seealso>
    let cityMunicipality = Prefixed_Name(dtx_srti, "cityMunicipality") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:county</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>County</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#county">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#county</seealso>
    let county = Prefixed_Name(dtx_srti, "county") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:districtWithSpecialStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubdivisionTypeEnum</para>
    ///   <para>District with special status</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtWithSpecialStatus">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#districtWithSpecialStatus</seealso>
    let districtWithSpecialStatus =
        Prefixed_Name(dtx_srti, "districtWithSpecialStatus") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:tunnel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dtx_srti:SubjectTypeOfWorksEnum</para>
    ///   <para>Road tunnel.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tunnel">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#tunnel</seealso>
    let tunnel = Prefixed_Name(dtx_srti, "tunnel") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeneralNetworkManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Network management action which is applicable to the road network and its users. "trafficManuallyDirectedBy" is only valid if "hasGeneralNetworkManagementTypeEnum" is set to "trafficBeingManuallyDirected".</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeneralNetworkManagement</seealso>
    let GeneralNetworkManagement =
        Prefixed_Name(dtx_srti, "GeneralNetworkManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Types of obstructions on the roadway.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ObstructionTypeEnum</seealso>
    let ObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "ObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasObstructionTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Characterization of the type of general obstruction.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasObstructionTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasObstructionTypeEnum</seealso>
    let hasObstructionTypeEnum =
        Prefixed_Name(dtx_srti, "hasObstructionTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:GeoSparqlClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The OGC GeoSPARQL standard supports representing and querying geospatial data on the Semantic Web. GeoSPARQL defines a vocabulary for representing geospatial data in RDF, and it defines an extension to the SPARQL query language for processing geospatial data.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeoSparqlClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#GeoSparqlClasses</seealso>
    let GeoSparqlClasses = Prefixed_Name(dtx_srti, "GeoSparqlClasses") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSemiMinorAxisLengthCodedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides a coded error in case the semi-minor axis length is not defined</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMinorAxisLengthCodedError">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMinorAxisLengthCodedError</seealso>
    let hasSemiMinorAxisLengthCodedError =
        Prefixed_Name(dtx_srti, "hasSemiMinorAxisLengthCodedError") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasSemiMajorAxisLengthCodedError</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides a coded error in case the semi-major axis length is not defined</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMajorAxisLengthCodedError">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasSemiMajorAxisLengthCodedError</seealso>
    let hasSemiMajorAxisLengthCodedError =
        Prefixed_Name(dtx_srti, "hasSemiMajorAxisLengthCodedError") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ProbabilityOfOccurrenceEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Levels of confidence that the sender has in the information, ordered {certain, probable, risk of}.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ProbabilityOfOccurrenceEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ProbabilityOfOccurrenceEnum</seealso>
    let ProbabilityOfOccurrenceEnum =
        Prefixed_Name(dtx_srti, "ProbabilityOfOccurrenceEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:Ramon_geoClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>RAMON geographic ontology describes countries, NUTS, and Local Administrative Units (LAU) related concepts and properties</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Ramon_geoClasses">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#Ramon_geoClasses</seealso>
    let Ramon_geoClasses = Prefixed_Name(dtx_srti, "Ramon_geoClasses") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:referentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the referent, e.g. a junction or intersection name.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentName">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentName</seealso>
    let referentName = Prefixed_Name(dtx_srti, "referentName") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:referentDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Description of the referent.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentDescription">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentDescription</seealso>
    let referentDescription =
        Prefixed_Name(dtx_srti, "referentDescription") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:referentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The identifier of the referent, unique on the specified linear element (i.e. road or part of).</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentIdentifier">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#referentIdentifier</seealso>
    let referentIdentifier =
        Prefixed_Name(dtx_srti, "referentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ReferentTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of types of known points along a linear object such as a road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReferentTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReferentTypeEnum</seealso>
    let ReferentTypeEnum = Prefixed_Name(dtx_srti, "ReferentTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReferentTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of the referent.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReferentTypeEnum</seealso>
    let hasReferentTypeEnum =
        Prefixed_Name(dtx_srti, "hasReferentTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ReroutingManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rerouting management action that is issued by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagement</seealso>
    let ReroutingManagement =
        Prefixed_Name(dtx_srti, "ReroutingManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:ReroutingManagementTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Management actions relating to rerouting.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagementTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#ReroutingManagementTypeEnum</seealso>
    let ReroutingManagementTypeEnum =
        Prefixed_Name(dtx_srti, "ReroutingManagementTypeEnum") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:hasReroutingManagementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Management actions relating to rerouting.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReroutingManagementType">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#hasReroutingManagementType</seealso>
    let hasReroutingManagementType =
        Prefixed_Name(dtx_srti, "hasReroutingManagementType") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information on a road</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadInformation">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadInformation</seealso>
    let RoadInformation = Prefixed_Name(dtx_srti, "RoadInformation") |> PrefixedName
    /// <summary>
    ///   <para>dtx_srti:roadDestination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A destination associated with this road.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadDestination">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#roadDestination</seealso>
    let roadDestination = Prefixed_Name(dtx_srti, "roadDestination") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Road, carriageway or lane management action that is instigated by the network/road operator.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagement">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagement</seealso>
    let RoadOrCarriagewayOrLaneManagement =
        Prefixed_Name(dtx_srti, "RoadOrCarriagewayOrLaneManagement") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:minimumCarOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The minimum number of persons required in a vehicle in order for it to be allowed to transit the specified road section.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minimumCarOccupancy">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#minimumCarOccupancy</seealso>
    let minimumCarOccupancy =
        Prefixed_Name(dtx_srti, "minimumCarOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>dtx_srti:RoadOrCarriagewayOrLaneManagementTypeEnum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Management actions relating to road, carriageway or lane usage.</para>
    /// </remarks>
    /// <seealso href="http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagementTypeEnum">http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#RoadOrCarriagewayOrLaneManagementTypeEnum</seealso>
    let RoadOrCarriagewayOrLaneManagementTypeEnum =
        Prefixed_Name(dtx_srti, "RoadOrCarriagewayOrLaneManagementTypeEnum") |> PrefixedName

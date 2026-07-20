namespace https.w3id.org.arco.ontology.location.slash

open DoxAletheia

module a_loc =
    let _namespace_name = "https://w3id.org/arco/ontology/location/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property relates a clerical administrative area (e.g. a diocese) to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isClericalAdministrativeAreaOf"></see></summary>
    let isClericalAdministrativeAreaOf = _prefix "isClericalAdministrativeAreaOf"

    /// <summary>
    /// This property links a governmental administrative area to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isGovernmentalAdministrativeAreaOf"></see></summary>
    let isGovernmentalAdministrativeAreaOf =
        _prefix "isGovernmentalAdministrativeAreaOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/1.2"></see>
    /// </summary>
    let ``_1.2`` = _prefix "1.2"
    /// <summary>
    /// This class represents the altitude, that is the height of an object above the sea level, which can be specified as maximum, minimum and relative altitude.
    /// <see href="https://w3id.org/arco/ontology/location/Altitude"></see></summary>
    let Altitude = _prefix "Altitude"
    /// <summary>
    /// This property represents the z coordinate of an object, which defines its altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/alt"></see></summary>
    let alt = _prefix "alt"
    /// <summary>
    /// This class represents the set of coordinates, geographic or projected, which allows the georeferencing of an object. For the punctual georeferencing there is only a pair of coordinates. For the linear and areal georeferencing there are more pairs of coordinates identifying those points of the line or area representing the object.
    /// <see href="https://w3id.org/arco/ontology/location/Coordinates"></see></summary>
    let Coordinates = _prefix "Coordinates"
    /// <summary>
    /// This property links the georeferencing coordinates of the altitude to an object (Geometry).
    /// <see href="https://w3id.org/arco/ontology/location/isAltitudeOf"></see></summary>
    let isAltitudeOf = _prefix "isAltitudeOf"
    /// <summary>
    /// This individual represents a specific type of location, that is the archival location.
    /// <see href="https://w3id.org/arco/ontology/location/ArchivalLocation"></see></summary>
    let ArchivalLocation = _prefix "ArchivalLocation"
    /// <summary>
    /// This class represents the type of location of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/LocationType"></see></summary>
    let LocationType = _prefix "LocationType"
    /// <summary>
    /// This class represents the base map possibly used for georeferencing activities.
    /// <see href="https://w3id.org/arco/ontology/location/BaseMap"></see></summary>
    let BaseMap = _prefix "BaseMap"
    /// <summary>
    /// This property links a base map to an object georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isBaseMapOf"></see></summary>
    let isBaseMapOf = _prefix "isBaseMapOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/BuildingAndLandCadastre"></see>
    /// </summary>
    let BuildingAndLandCadastre = _prefix "BuildingAndLandCadastre"
    /// <summary>
    /// This class represents the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).
    /// <see href="https://w3id.org/arco/ontology/location/CadastreType"></see></summary>
    let CadastreType = _prefix "CadastreType"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/BuildingCadastre"></see>
    /// </summary>
    let BuildingCadastre = _prefix "BuildingCadastre"
    /// <summary>
    /// This class represents a cadastral entity, which is intended as an object that can have a spatial representation related to the cadastral allocation.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralEntity"></see></summary>
    let CadastralEntity = _prefix "CadastralEntity"
    /// <summary>
    /// This property links a cadastral entity, understood as spatial object, to its cadastral identity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralEntityOf"></see></summary>
    let isCadastralEntityOf = _prefix "isCadastralEntityOf"
    /// <summary>
    /// This class represents the cadastral identity of an entity, which is intended as a set of location information concerning the property with reference to the national cadastral allocation. The cadastral identity can have a chronological reference indicating the dating of cadastral data.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralIdentity"></see></summary>
    let CadastralIdentity = _prefix "CadastralIdentity"
    /// <summary>
    /// This class represents a folio of a cadastral map, which contains one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralFolio"></see></summary>
    let CadastralFolio = _prefix "CadastralFolio"
    /// <summary>
    /// This property links a cadastral identity of an entity to one of the cadastral entities, understood as spatial objects, that define it.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralEntity"></see></summary>
    let hasCadastralEntity = _prefix "hasCadastralEntity"
    /// <summary>
    /// This property links a cadastral identity of an entity to the municipality to which the cadastral map is registered, as attested by the cadastre.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralCity"></see></summary>
    let hasCadastralCity = _prefix "hasCadastralCity"
    /// <summary>
    /// This property relates a cadastral identity of an entity to the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastreType"></see></summary>
    let hasCadastreType = _prefix "hasCadastreType"
    /// <summary>
    /// This property links an entity (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity) to the role of the localization referring to it (i.e current physical location, previous location, finding location, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/hasLocationType"></see></summary>
    let hasLocationType = _prefix "hasLocationType"
    /// <summary>
    /// This property links all the cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc., to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralIdentityOf"></see></summary>
    let isCadastralIdentityOf = _prefix "isCadastralIdentityOf"
    /// <summary>
    /// This class represents one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralUnitCollection"></see></summary>
    let CadastralUnitCollection = _prefix "CadastralUnitCollection"
    /// <summary>
    /// This property relates the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre) to a cadastral identity of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastreTypeOf"></see></summary>
    let isCadastreTypeOf = _prefix "isCadastreTypeOf"
    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes an old town, that is the chief town.
    /// <see href="https://w3id.org/arco/ontology/location/ChiefTown"></see></summary>
    let ChiefTown = _prefix "ChiefTown"
    /// <summary>
    /// This class represents the information clarifying the administrative character of the old town, which may be: a chief town, a town fraction, an incorporated area or a locality.
    /// <see href="https://w3id.org/arco/ontology/location/OldTownAdmistrativeType"></see></summary>
    let OldTownAdmistrativeType = _prefix "OldTownAdmistrativeType"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/CollectingLocation"></see>
    /// </summary>
    let CollectingLocation = _prefix "CollectingLocation"
    /// <summary>
    /// This class represents a Continent.
    /// <see href="https://w3id.org/arco/ontology/location/Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// This property links the continent to the location of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isContinentOf"></see></summary>
    let isContinentOf = _prefix "isContinentOf"
    /// <summary>
    /// This is the inverse property of "has coordinates".
    /// <see href="https://w3id.org/arco/ontology/location/areCoordinatesOf"></see></summary>
    let areCoordinatesOf = _prefix "areCoordinatesOf"
    /// <summary>
    /// This property links the georeferencing coordinates of an object (Geometry) to its altitude.
    /// <see href="https://w3id.org/arco/ontology/location/hasAltitude"></see></summary>
    let hasAltitude = _prefix "hasAltitude"
    /// <summary>
    /// This property represents the x coordinate, that is the longitude.
    /// <see href="https://w3id.org/arco/ontology/location/long"></see></summary>
    let long = _prefix "long"
    /// <summary>
    /// This property represents the y coordinate, that is the latitude.
    /// <see href="https://w3id.org/arco/ontology/location/lat"></see></summary>
    let lat = _prefix "lat"
    /// <summary>
    /// This class represents the type definition of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteDefinition"></see></summary>
    let CulturalInstituteOrSiteDefinition = _prefix "CulturalInstituteOrSiteDefinition"

    /// <summary>
    /// This class represents the type specification of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteSpecification"></see></summary>
    let CulturalInstituteOrSiteSpecification =
        _prefix "CulturalInstituteOrSiteSpecification"

    /// <summary>
    /// This class represents the type of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteType"></see></summary>
    let CulturalInstituteOrSiteType = _prefix "CulturalInstituteOrSiteType"
    /// <summary>
    /// This individual represents a specific type of localization, that is the current physical location.
    /// <see href="https://w3id.org/arco/ontology/location/CurrentPhysicalLocation"></see></summary>
    let CurrentPhysicalLocation = _prefix "CurrentPhysicalLocation"
    /// <summary>
    /// This individual represents a specific type of localization, that is the exhibition location.
    /// <see href="https://w3id.org/arco/ontology/location/ExhibitionLocation"></see></summary>
    let ExhibitionLocation = _prefix "ExhibitionLocation"
    /// <summary>
    /// This individual represents a specific type of context, that is the extra-urban context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/ExtraurbanContext"></see></summary>
    let ExtraurbanContext = _prefix "ExtraurbanContext"
    /// <summary>
    /// This class represents the type of geographical context where the cultural property is located: i.e. urban, suburban, extra-urban, territorial, underwater.
    /// <see href="https://w3id.org/arco/ontology/location/TypeOfContext"></see></summary>
    let TypeOfContext = _prefix "TypeOfContext"
    /// <summary>
    /// This individual represents a specific type of localization, that is the finding location.
    /// <see href="https://w3id.org/arco/ontology/location/FindingLocation"></see></summary>
    let FindingLocation = _prefix "FindingLocation"
    /// <summary>
    /// This class represents the method used for the object positioning (i.e. exact, approximate, with a symbolic representation).
    /// <see href="https://w3id.org/arco/ontology/location/GeometryMethod"></see></summary>
    let GeometryMethod = _prefix "GeometryMethod"
    /// <summary>
    /// This property links the method used for the object positioning to the georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isGeometryMethodOf"></see></summary>
    let isGeometryMethodOf = _prefix "isGeometryMethodOf"
    /// <summary>
    /// This class represents the technique of georeferencing, used for the acquisition of coordinates (i.e. survey from cartography with or without inspection, survey from aerial photos with or without inspection, satellite survey, traditional survey, survey via GPS, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/GeometryTechnique"></see></summary>
    let GeometryTechnique = _prefix "GeometryTechnique"
    /// <summary>
    /// This property links the georeferencing technique to the georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isGeometryTechniqueOf"></see></summary>
    let isGeometryTechniqueOf = _prefix "isGeometryTechniqueOf"
    /// <summary>
    /// This individual represents a specific type of localization, that is the historical location.
    /// <see href="https://w3id.org/arco/ontology/location/HistoricalLocation"></see></summary>
    let HistoricalLocation = _prefix "HistoricalLocation"
    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, that is the denomination of 'incorporated area'.
    /// <see href="https://w3id.org/arco/ontology/location/IncorporatedArea"></see></summary>
    let IncorporatedArea = _prefix "IncorporatedArea"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/LandCadastre"></see>
    /// </summary>
    let LandCadastre = _prefix "LandCadastre"
    /// <summary>
    /// Replaced by https://w3id.org/arco/ontology/location/PreviousLocation
    /// This individual represents a specific type of location, that is the place of origin or last location.
    /// <see href="https://w3id.org/arco/ontology/location/LastLocation"></see></summary>
    let LastLocation = _prefix "LastLocation"
    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, that is the locality.
    /// <see href="https://w3id.org/arco/ontology/location/Locality"></see></summary>
    let Locality = _prefix "Locality"
    /// <summary>
    /// This property links the role of a localization (i.e current physical location, previous location, finding location, etc.) to an entity referring to it (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity).
    /// <see href="https://w3id.org/arco/ontology/location/isLocationTypeOf"></see></summary>
    let isLocationTypeOf = _prefix "isLocationTypeOf"
    /// <summary>
    /// This class represents spatial entities (i.e. roads, waterways, etc.) that border one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/NeighbouringCadastralEntity"></see></summary>
    let NeighbouringCadastralEntity = _prefix "NeighbouringCadastralEntity"
    /// <summary>
    /// This individual represents a specific type of location, that is the location of observation.
    /// <see href="https://w3id.org/arco/ontology/location/ObservationLocation"></see></summary>
    let ObservationLocation = _prefix "ObservationLocation"
    /// <summary>
    /// This class represents the information describing the old town where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/OldTown"></see></summary>
    let OldTown = _prefix "OldTown"
    /// <summary>
    /// This property connects the old town with the urban area that is part of it.
    /// <see href="https://w3id.org/arco/ontology/location/hasUrbanArea"></see></summary>
    let hasUrbanArea = _prefix "hasUrbanArea"
    /// <summary>
    /// This class represents the informations on the denomination of the urban area that is part of the old town where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/UrbanArea"></see></summary>
    let UrbanArea = _prefix "UrbanArea"
    /// <summary>
    /// This property connects a historical center with information related to its administrative type.
    /// <see href="https://w3id.org/arco/ontology/location/hasOldTownAdministrativeType"></see></summary>
    let hasOldTownAdministrativeType = _prefix "hasOldTownAdministrativeType"
    /// <summary>
    /// This property connects the administrative type with the information related to its historical center.
    /// <see href="https://w3id.org/arco/ontology/location/isOldTownAdministrativeTypeOf"></see></summary>
    let isOldTownAdministrativeTypeOf = _prefix "isOldTownAdministrativeTypeOf"
    /// <summary>
    /// This individual represents a specific type of location, that is the place of origin or previous location.
    /// <see href="https://w3id.org/arco/ontology/location/PreviousLocation"></see></summary>
    let PreviousLocation = _prefix "PreviousLocation"
    /// <summary>
    /// This individual represents a specific type of location, that is the production or realization location.
    /// <see href="https://w3id.org/arco/ontology/location/ProductionRealizationLocation"></see></summary>
    let ProductionRealizationLocation = _prefix "ProductionRealizationLocation"
    /// <summary>
    /// This individual represents a specific type of localization, that is the shooting location.
    /// <see href="https://w3id.org/arco/ontology/location/ShootingLocation"></see></summary>
    let ShootingLocation = _prefix "ShootingLocation"
    /// <summary>
    /// This class represents the type definition of a physical container.
    /// <see href="https://w3id.org/arco/ontology/location/SiteDefinition"></see></summary>
    let SiteDefinition = _prefix "SiteDefinition"
    /// <summary>
    /// This class represents the type of a physical container, i.e. it contains adjectives or phrases that specify, integrate or characterize the physical container from the point of view of the legal-administrative or functional condition.
    /// <see href="https://w3id.org/arco/ontology/location/SiteType"></see></summary>
    let SiteType = _prefix "SiteType"
    /// <summary>
    /// This property links the definition of a physical container to of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteDefinitionOf"></see></summary>
    let isSiteDefinitionOf = _prefix "isSiteDefinitionOf"
    /// <summary>
    /// This class represents specifications about the physical container, i.e. the adjective or the phrase that with respect to the Site Definition specifies, integrates or characterizes the physical container from the point of view of the legal-administrative or functional condition.
    /// <see href="https://w3id.org/arco/ontology/location/SiteSpecification"></see></summary>
    let SiteSpecification = _prefix "SiteSpecification"
    /// <summary>
    /// This property links the specification of a physical container to one of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteSpecificationOf"></see></summary>
    let isSiteSpecificationOf = _prefix "isSiteSpecificationOf"
    /// <summary>
    /// This property connects the type of physical container to a physical container (Site), to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteTypeOf"></see></summary>
    let isSiteTypeOf = _prefix "isSiteTypeOf"
    /// <summary>
    /// This property links the type of a physical container to one of its components, that is to the definition of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteDefinition"></see></summary>
    let hasSiteDefinition = _prefix "hasSiteDefinition"
    /// <summary>
    /// This property links the type of a physical container to one of its components, that is to the specifications of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteSpecification"></see></summary>
    let hasSiteSpecification = _prefix "hasSiteSpecification"
    /// <summary>
    /// This individual represents a specific type of localization, that is the storage location.
    /// <see href="https://w3id.org/arco/ontology/location/StorageLocation"></see></summary>
    let StorageLocation = _prefix "StorageLocation"
    /// <summary>
    /// This individual represents a specific type of localization, that is the subject location.
    /// <see href="https://w3id.org/arco/ontology/location/SubjectLocation"></see></summary>
    let SubjectLocation = _prefix "SubjectLocation"
    /// <summary>
    /// This individual represents a specific type of geographical context, that is a suburban context, which is located in the intermediate area between the urban and extraurban context.
    /// <see href="https://w3id.org/arco/ontology/location/SuburbanContext"></see></summary>
    let SuburbanContext = _prefix "SuburbanContext"
    /// <summary>
    /// This individual represents a specific type of context, i.e. the territorial context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/TerritorialContext"></see></summary>
    let TerritorialContext = _prefix "TerritorialContext"
    /// <summary>
    /// This class represents a localization of a cultural property, within a timeframe and qualified according to the role that the localization plays in relation to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/TimeIndexedTypedLocation"></see></summary>
    let TimeIndexedTypedLocation = _prefix "TimeIndexedTypedLocation"
    /// <summary>
    /// This property links a typified location over time to an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isTimeIndexedTypedLocationOf"></see></summary>
    let isTimeIndexedTypedLocationOf = _prefix "isTimeIndexedTypedLocationOf"
    /// <summary>
    /// This property links a typed location over time to its related geographical entity.
    /// <see href="https://w3id.org/arco/ontology/location/atLocation"></see></summary>
    let atLocation = _prefix "atLocation"
    /// <summary>
    /// This property links a typified location over time to its physical container (Site).
    /// <see href="https://w3id.org/arco/ontology/location/atSite"></see></summary>
    let atSite = _prefix "atSite"
    /// <summary>
    /// This class represents other place's designations changing over time.
    /// <see href="https://w3id.org/arco/ontology/location/ToponymInTime"></see></summary>
    let ToponymInTime = _prefix "ToponymInTime"
    /// <summary>
    /// This property relates a toponym chianging over time to a geographical entity.
    /// <see href="https://w3id.org/arco/ontology/location/isToponymInTimeOf"></see></summary>
    let isToponymInTimeOf = _prefix "isToponymInTimeOf"
    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, i.e. the town fraction.
    /// <see href="https://w3id.org/arco/ontology/location/TownFraction"></see></summary>
    let TownFraction = _prefix "TownFraction"
    /// <summary>
    /// This property relates the type of context (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context) an entity where it is located.
    /// <see href="https://w3id.org/arco/ontology/location/isTypeOfContextOf"></see></summary>
    let isTypeOfContextOf = _prefix "isTypeOfContextOf"
    /// <summary>
    /// This individual represents a specific type of context, that is the underwater context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/UnderwaterContext"></see></summary>
    let UnderwaterContext = _prefix "UnderwaterContext"
    /// <summary>
    /// This individual represents a specific type of context, that is the urban context where the cultural asset is located.
    /// <see href="https://w3id.org/arco/ontology/location/UrbanContext"></see></summary>
    let UrbanContext = _prefix "UrbanContext"
    /// <summary>
    /// This property associates the order number that identifies a location intended as an administrative unit, i.e. an old town, an urban area and a sector.
    /// <see href="https://w3id.org/arco/ontology/location/administrativeOrderNumber"></see></summary>
    let administrativeOrderNumber = _prefix "administrativeOrderNumber"
    /// <summary>
    /// This property links the object georeferencing (Geometry) to its coordinates (x, y, z).
    /// <see href="https://w3id.org/arco/ontology/location/hasCoordinates"></see></summary>
    let hasCoordinates = _prefix "hasCoordinates"
    /// <summary>
    /// This property relates a geographical feature to a time indexed typed location that refers to that feature.
    /// <see href="https://w3id.org/arco/ontology/location/isLocationIn"></see></summary>
    let isLocationIn = _prefix "isLocationIn"
    /// <summary>
    /// This property relates a cultural site to the time indexed typed location.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteIn"></see></summary>
    let isSiteIn = _prefix "isSiteIn"
    /// <summary>
    /// This property represents the designation of a historical cadastre.
    /// <see href="https://w3id.org/arco/ontology/location/cadastreName"></see></summary>
    let cadastreName = _prefix "cadastreName"
    /// <summary>
    /// This property allows to associate a legal container to its code assigned by the ICCD.
    /// <see href="https://w3id.org/arco/ontology/location/culturalInstituteOrSiteIdentifier"></see></summary>
    let culturalInstituteOrSiteIdentifier = _prefix "culturalInstituteOrSiteIdentifier"
    /// <summary>
    /// This property represents the progressive number that identifies the district where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/districtNumber"></see></summary>
    let districtNumber = _prefix "districtNumber"
    /// <summary>
    /// This property links an object georeferencing to the base map possibly used.
    /// <see href="https://w3id.org/arco/ontology/location/hasBaseMap"></see></summary>
    let hasBaseMap = _prefix "hasBaseMap"
    /// <summary>
    /// This property links the municipality to which the cadastral map is registered, as attested by the cadastre, to a cadastral identity of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralCityOf"></see></summary>
    let isCadastralCityOf = _prefix "isCadastralCityOf"
    /// <summary>
    /// This property links a cultural property to all its cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralIdentity"></see></summary>
    let hasCadastralIdentity = _prefix "hasCadastralIdentity"
    /// <summary>
    /// This property relates an address to a clerical administrative area (e.g. a diocese).
    /// <see href="https://w3id.org/arco/ontology/location/hasClericalAdministrativeArea"></see></summary>
    let hasClericalAdministrativeArea = _prefix "hasClericalAdministrativeArea"
    /// <summary>
    /// This property links the location of an entity to the continent where it is located.
    /// <see href="https://w3id.org/arco/ontology/location/hasContinent"></see></summary>
    let hasContinent = _prefix "hasContinent"
    /// <summary>
    ///
    /// This property links a cultural property to the cultural institute or site
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSite"></see></summary>
    let hasCulturalInstituteOrSite = _prefix "hasCulturalInstituteOrSite"
    /// <summary>
    /// This property links a cultural institute or site to a cultural property
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteOf"></see></summary>
    let isCulturalInstituteOrSiteOf = _prefix "isCulturalInstituteOrSiteOf"

    /// <summary>
    /// This property links the type of a cultural institute or site to one of its components, that is to the definition of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteDefinition"></see></summary>
    let hasCulturalInstituteOrSiteDefinition =
        _prefix "hasCulturalInstituteOrSiteDefinition"

    /// <summary>
    /// This property links the definition of a cultural institute or site to its type.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteDefinitionOf"></see></summary>
    let isCulturalInstituteOrSiteDefinitionOf =
        _prefix "isCulturalInstituteOrSiteDefinitionOf"

    /// <summary>
    /// This property links the type of a cultural institute or site to one of its components, that is to the specifications of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteSpecification"></see></summary>
    let hasCulturalInstituteOrSiteSpecification =
        _prefix "hasCulturalInstituteOrSiteSpecification"

    /// <summary>
    /// This property links the specification of a cultural institute or site to one of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteSpecificationOf"></see></summary>
    let isCulturalInstituteOrSiteSpecificationOf =
        _prefix "isCulturalInstituteOrSiteSpecificationOf"

    /// <summary>
    /// This property connects a Cultural institute or site to its type, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteType"></see></summary>
    let hasCulturalInstituteOrSiteType = _prefix "hasCulturalInstituteOrSiteType"
    /// <summary>
    /// This property connects the type of cultural institute or site to a cultural institute or site, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteTypeof"></see></summary>
    let isCulturalInstituteOrSiteTypeof = _prefix "isCulturalInstituteOrSiteTypeof"
    /// <summary>
    /// This property represents the relationship that links a cultural property to the address of its current physical location at the cataloging time. The report provides a simplified representation, with a reduced expressivity, of the current location of the cultural property, and it causes the loss of other information regarding its location (i.e. the continent, the possible physical container, the specific location in the physical container, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalPropertyAddress"></see></summary>
    let hasCulturalPropertyAddress = _prefix "hasCulturalPropertyAddress"
    /// <summary>
    /// This property represents the relationship that links the address of the current physical location at the cataloging time to the catalogued cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalPropertyAddressOf"></see></summary>
    let isCulturalPropertyAddressOf = _prefix "isCulturalPropertyAddressOf"
    /// <summary>
    /// This property links an entity to its typified location over time.
    /// <see href="https://w3id.org/arco/ontology/location/hasTimeIndexedTypedLocation"></see></summary>
    let hasTimeIndexedTypedLocation = _prefix "hasTimeIndexedTypedLocation"
    /// <summary>
    /// This property links a georeferencing to the method used for the object positioning.
    /// <see href="https://w3id.org/arco/ontology/location/hasGeometryMethod"></see></summary>
    let hasGeometryMethod = _prefix "hasGeometryMethod"
    /// <summary>
    /// This property links a georeferencing to the georeferencing technique.
    /// <see href="https://w3id.org/arco/ontology/location/hasGeometryTechnique"></see></summary>
    let hasGeometryTechnique = _prefix "hasGeometryTechnique"
    /// <summary>
    /// This property links an address to a governmental administrative area.
    /// <see href="https://w3id.org/arco/ontology/location/hasGovernmentalAdministrativeArea"></see></summary>
    let hasGovernmentalAdministrativeArea = _prefix "hasGovernmentalAdministrativeArea"
    /// <summary>
    /// This property links an address to a historical-geographical area.
    /// <see href="https://w3id.org/arco/ontology/location/hasHistoricalArea"></see></summary>
    let hasHistoricalArea = _prefix "hasHistoricalArea"
    /// <summary>
    /// This property links a historical-geographical area to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isHistoricalAreaOf"></see></summary>
    let isHistoricalAreaOf = _prefix "isHistoricalAreaOf"
    /// <summary>
    /// This property connects a physical container (Site) to its type, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteType"></see></summary>
    let hasSiteType = _prefix "hasSiteType"
    /// <summary>
    /// This property relates a stratigraphic record to the area in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicArea"></see></summary>
    let hasStratigraphicArea = _prefix "hasStratigraphicArea"
    /// <summary>
    /// This is the inverse property of "has stratigraphic area".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicAreaOf"></see></summary>
    let isStratigraphicAreaOf = _prefix "isStratigraphicAreaOf"
    /// <summary>
    /// This property relates a stratigraphic record to the room in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicRoom"></see></summary>
    let hasStratigraphicRoom = _prefix "hasStratigraphicRoom"
    /// <summary>
    /// This is the inverse property of "has stratigraphic room".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicRoomOf"></see></summary>
    let isStratigraphicRoomOf = _prefix "isStratigraphicRoomOf"
    /// <summary>
    /// This property relates a stratigraphic record to the square in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicSquare"></see></summary>
    let hasStratigraphicSquare = _prefix "hasStratigraphicSquare"
    /// <summary>
    /// This is the inverse property of "has stratigraphic square".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicSquareOf"></see></summary>
    let isStratigraphicSquareOf = _prefix "isStratigraphicSquareOf"
    /// <summary>
    /// This property links an address to a territorial area, which may not coincide with the administrative area, to which a cultural property belongs.
    /// <see href="https://w3id.org/arco/ontology/location/hasTerritorialArea"></see></summary>
    let hasTerritorialArea = _prefix "hasTerritorialArea"
    /// <summary>
    /// This property links a territorial area (which may not coincide with the administrative area) to which a cultural property belongs to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isTerritorialAreaOf"></see></summary>
    let isTerritorialAreaOf = _prefix "isTerritorialAreaOf"
    /// <summary>
    /// This property links an address to a territorial division within a territorial area.
    /// <see href="https://w3id.org/arco/ontology/location/hasTerritorialDivision"></see></summary>
    let hasTerritorialDivision = _prefix "hasTerritorialDivision"
    /// <summary>
    /// This property links a territorial division within a territorial area to an address.
    /// <see href="https://w3id.org/arco/ontology/location/isTerritorialDivisionOf"></see></summary>
    let isTerritorialDivisionOf = _prefix "isTerritorialDivisionOf"
    /// <summary>
    /// This property relates a geographical entity to a toponym chianging over time.
    /// <see href="https://w3id.org/arco/ontology/location/hasToponymInTime"></see></summary>
    let hasToponymInTime = _prefix "hasToponymInTime"
    /// <summary>
    /// This property relates an entity to the type of context where the cultural property is located (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context).
    /// <see href="https://w3id.org/arco/ontology/location/hasTypeOfContext"></see></summary>
    let hasTypeOfContext = _prefix "hasTypeOfContext"
    /// <summary>
    /// This property connects the the urban area with the its old town.
    /// <see href="https://w3id.org/arco/ontology/location/isUrbanAreaOf"></see></summary>
    let isUrbanAreaOf = _prefix "isUrbanAreaOf"
    /// <summary>
    /// This property is used to represent other paths and details about the cultural property location.
    /// <see href="https://w3id.org/arco/ontology/location/locationDetails"></see></summary>
    let locationDetails = _prefix "locationDetails"
    /// <summary>
    /// This property represents the absolute maximum altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/maxAlt"></see></summary>
    let maxAlt = _prefix "maxAlt"
    /// <summary>
    /// This property represents the absolute minimum altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/minAlt"></see></summary>
    let minAlt = _prefix "minAlt"
    /// <summary>
    /// This property represents the type of point that georeferences the catalogued cultural property. The definition of the point type is not univocal and depends on the cultural property's type and conformation as well as on the type of location.
    /// <see href="https://w3id.org/arco/ontology/location/pointType"></see></summary>
    let pointType = _prefix "pointType"
    /// <summary>
    /// This property represents the object relative height by reference to a point or an element or a situation to be specified.
    /// <see href="https://w3id.org/arco/ontology/location/relativeAlt"></see></summary>
    let relativeAlt = _prefix "relativeAlt"
    /// <summary>
    /// This property allows to associate a physical container to its code assigned by the ICCD.
    /// <see href="https://w3id.org/arco/ontology/location/siteIdentifier"></see></summary>
    let siteIdentifier = _prefix "siteIdentifier"
    /// <summary>
    /// This property represents the reference system used for the object georeferencing (e.g. WGS84, WGS84 UTM32, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/spatialReferenceSystem"></see></summary>
    let spatialReferenceSystem = _prefix "spatialReferenceSystem"

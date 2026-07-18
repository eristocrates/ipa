namespace https.w3id.org.arco.ontology.location.slash

open DoxAletheia.Rdf_Vocabulary

module a_loc =
    let _namespace_name = "https://w3id.org/arco/ontology/location/"

    /// <summary>
    /// This property relates a clerical administrative area (e.g. a diocese) to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isClericalAdministrativeAreaOf"></see></summary>
    let isClericalAdministrativeAreaOf =
        Namespaced_IRI.parse _namespace_name "isClericalAdministrativeAreaOf" |> NamespacedName

    /// <summary>
    /// This property links a governmental administrative area to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isGovernmentalAdministrativeAreaOf"></see></summary>
    let isGovernmentalAdministrativeAreaOf =
        Namespaced_IRI.parse _namespace_name "isGovernmentalAdministrativeAreaOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/1.2"></see>
    /// </summary>
    let ``_1.2`` = Namespaced_IRI.parse _namespace_name "1.2" |> NamespacedName
    /// <summary>
    /// This class represents the altitude, that is the height of an object above the sea level, which can be specified as maximum, minimum and relative altitude.
    /// <see href="https://w3id.org/arco/ontology/location/Altitude"></see></summary>
    let Altitude = Namespaced_IRI.parse _namespace_name "Altitude" |> NamespacedName
    /// <summary>
    /// This property represents the z coordinate of an object, which defines its altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/alt"></see></summary>
    let alt = Namespaced_IRI.parse _namespace_name "alt" |> NamespacedName

    /// <summary>
    /// This class represents the set of coordinates, geographic or projected, which allows the georeferencing of an object. For the punctual georeferencing there is only a pair of coordinates. For the linear and areal georeferencing there are more pairs of coordinates identifying those points of the line or area representing the object.
    /// <see href="https://w3id.org/arco/ontology/location/Coordinates"></see></summary>
    let Coordinates =
        Namespaced_IRI.parse _namespace_name "Coordinates" |> NamespacedName

    /// <summary>
    /// This property links the georeferencing coordinates of the altitude to an object (Geometry).
    /// <see href="https://w3id.org/arco/ontology/location/isAltitudeOf"></see></summary>
    let isAltitudeOf =
        Namespaced_IRI.parse _namespace_name "isAltitudeOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of location, that is the archival location.
    /// <see href="https://w3id.org/arco/ontology/location/ArchivalLocation"></see></summary>
    let ArchivalLocation =
        Namespaced_IRI.parse _namespace_name "ArchivalLocation" |> NamespacedName

    /// <summary>
    /// This class represents the type of location of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/LocationType"></see></summary>
    let LocationType =
        Namespaced_IRI.parse _namespace_name "LocationType" |> NamespacedName

    /// <summary>
    /// This class represents the base map possibly used for georeferencing activities.
    /// <see href="https://w3id.org/arco/ontology/location/BaseMap"></see></summary>
    let BaseMap = Namespaced_IRI.parse _namespace_name "BaseMap" |> NamespacedName

    /// <summary>
    /// This property links a base map to an object georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isBaseMapOf"></see></summary>
    let isBaseMapOf =
        Namespaced_IRI.parse _namespace_name "isBaseMapOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/BuildingAndLandCadastre"></see>
    /// </summary>
    let BuildingAndLandCadastre =
        Namespaced_IRI.parse _namespace_name "BuildingAndLandCadastre" |> NamespacedName

    /// <summary>
    /// This class represents the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).
    /// <see href="https://w3id.org/arco/ontology/location/CadastreType"></see></summary>
    let CadastreType =
        Namespaced_IRI.parse _namespace_name "CadastreType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/BuildingCadastre"></see>
    /// </summary>
    let BuildingCadastre =
        Namespaced_IRI.parse _namespace_name "BuildingCadastre" |> NamespacedName

    /// <summary>
    /// This class represents a cadastral entity, which is intended as an object that can have a spatial representation related to the cadastral allocation.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralEntity"></see></summary>
    let CadastralEntity =
        Namespaced_IRI.parse _namespace_name "CadastralEntity" |> NamespacedName

    /// <summary>
    /// This property links a cadastral entity, understood as spatial object, to its cadastral identity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralEntityOf"></see></summary>
    let isCadastralEntityOf =
        Namespaced_IRI.parse _namespace_name "isCadastralEntityOf" |> NamespacedName

    /// <summary>
    /// This class represents the cadastral identity of an entity, which is intended as a set of location information concerning the property with reference to the national cadastral allocation. The cadastral identity can have a chronological reference indicating the dating of cadastral data.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralIdentity"></see></summary>
    let CadastralIdentity =
        Namespaced_IRI.parse _namespace_name "CadastralIdentity" |> NamespacedName

    /// <summary>
    /// This class represents a folio of a cadastral map, which contains one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralFolio"></see></summary>
    let CadastralFolio =
        Namespaced_IRI.parse _namespace_name "CadastralFolio" |> NamespacedName

    /// <summary>
    /// This property links a cadastral identity of an entity to one of the cadastral entities, understood as spatial objects, that define it.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralEntity"></see></summary>
    let hasCadastralEntity =
        Namespaced_IRI.parse _namespace_name "hasCadastralEntity" |> NamespacedName

    /// <summary>
    /// This property links a cadastral identity of an entity to the municipality to which the cadastral map is registered, as attested by the cadastre.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralCity"></see></summary>
    let hasCadastralCity =
        Namespaced_IRI.parse _namespace_name "hasCadastralCity" |> NamespacedName

    /// <summary>
    /// This property relates a cadastral identity of an entity to the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre).
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastreType"></see></summary>
    let hasCadastreType =
        Namespaced_IRI.parse _namespace_name "hasCadastreType" |> NamespacedName

    /// <summary>
    /// This property links an entity (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity) to the role of the localization referring to it (i.e current physical location, previous location, finding location, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/hasLocationType"></see></summary>
    let hasLocationType =
        Namespaced_IRI.parse _namespace_name "hasLocationType" |> NamespacedName

    /// <summary>
    /// This property links all the cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc., to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralIdentityOf"></see></summary>
    let isCadastralIdentityOf =
        Namespaced_IRI.parse _namespace_name "isCadastralIdentityOf" |> NamespacedName

    /// <summary>
    /// This class represents one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/CadastralUnitCollection"></see></summary>
    let CadastralUnitCollection =
        Namespaced_IRI.parse _namespace_name "CadastralUnitCollection" |> NamespacedName

    /// <summary>
    /// This property relates the type of cadastre (e.g. land cadastre, building cadastre, mixed cadastre) to a cadastral identity of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastreTypeOf"></see></summary>
    let isCadastreTypeOf =
        Namespaced_IRI.parse _namespace_name "isCadastreTypeOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes an old town, that is the chief town.
    /// <see href="https://w3id.org/arco/ontology/location/ChiefTown"></see></summary>
    let ChiefTown = Namespaced_IRI.parse _namespace_name "ChiefTown" |> NamespacedName

    /// <summary>
    /// This class represents the information clarifying the administrative character of the old town, which may be: a chief town, a town fraction, an incorporated area or a locality.
    /// <see href="https://w3id.org/arco/ontology/location/OldTownAdmistrativeType"></see></summary>
    let OldTownAdmistrativeType =
        Namespaced_IRI.parse _namespace_name "OldTownAdmistrativeType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/CollectingLocation"></see>
    /// </summary>
    let CollectingLocation =
        Namespaced_IRI.parse _namespace_name "CollectingLocation" |> NamespacedName

    /// <summary>
    /// This class represents a Continent.
    /// <see href="https://w3id.org/arco/ontology/location/Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    /// This property links the continent to the location of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isContinentOf"></see></summary>
    let isContinentOf =
        Namespaced_IRI.parse _namespace_name "isContinentOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has coordinates".
    /// <see href="https://w3id.org/arco/ontology/location/areCoordinatesOf"></see></summary>
    let areCoordinatesOf =
        Namespaced_IRI.parse _namespace_name "areCoordinatesOf" |> NamespacedName

    /// <summary>
    /// This property links the georeferencing coordinates of an object (Geometry) to its altitude.
    /// <see href="https://w3id.org/arco/ontology/location/hasAltitude"></see></summary>
    let hasAltitude =
        Namespaced_IRI.parse _namespace_name "hasAltitude" |> NamespacedName

    /// <summary>
    /// This property represents the x coordinate, that is the longitude.
    /// <see href="https://w3id.org/arco/ontology/location/long"></see></summary>
    let long = Namespaced_IRI.parse _namespace_name "long" |> NamespacedName
    /// <summary>
    /// This property represents the y coordinate, that is the latitude.
    /// <see href="https://w3id.org/arco/ontology/location/lat"></see></summary>
    let lat = Namespaced_IRI.parse _namespace_name "lat" |> NamespacedName

    /// <summary>
    /// This class represents the type definition of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteDefinition"></see></summary>
    let CulturalInstituteOrSiteDefinition =
        Namespaced_IRI.parse _namespace_name "CulturalInstituteOrSiteDefinition" |> NamespacedName

    /// <summary>
    /// This class represents the type specification of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteSpecification"></see></summary>
    let CulturalInstituteOrSiteSpecification =
        Namespaced_IRI.parse _namespace_name "CulturalInstituteOrSiteSpecification" |> NamespacedName

    /// <summary>
    /// This class represents the type of a cultural insititute or site.
    /// <see href="https://w3id.org/arco/ontology/location/CulturalInstituteOrSiteType"></see></summary>
    let CulturalInstituteOrSiteType =
        Namespaced_IRI.parse _namespace_name "CulturalInstituteOrSiteType" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the current physical location.
    /// <see href="https://w3id.org/arco/ontology/location/CurrentPhysicalLocation"></see></summary>
    let CurrentPhysicalLocation =
        Namespaced_IRI.parse _namespace_name "CurrentPhysicalLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the exhibition location.
    /// <see href="https://w3id.org/arco/ontology/location/ExhibitionLocation"></see></summary>
    let ExhibitionLocation =
        Namespaced_IRI.parse _namespace_name "ExhibitionLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of context, that is the extra-urban context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/ExtraurbanContext"></see></summary>
    let ExtraurbanContext =
        Namespaced_IRI.parse _namespace_name "ExtraurbanContext" |> NamespacedName

    /// <summary>
    /// This class represents the type of geographical context where the cultural property is located: i.e. urban, suburban, extra-urban, territorial, underwater.
    /// <see href="https://w3id.org/arco/ontology/location/TypeOfContext"></see></summary>
    let TypeOfContext =
        Namespaced_IRI.parse _namespace_name "TypeOfContext" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the finding location.
    /// <see href="https://w3id.org/arco/ontology/location/FindingLocation"></see></summary>
    let FindingLocation =
        Namespaced_IRI.parse _namespace_name "FindingLocation" |> NamespacedName

    /// <summary>
    /// This class represents the method used for the object positioning (i.e. exact, approximate, with a symbolic representation).
    /// <see href="https://w3id.org/arco/ontology/location/GeometryMethod"></see></summary>
    let GeometryMethod =
        Namespaced_IRI.parse _namespace_name "GeometryMethod" |> NamespacedName

    /// <summary>
    /// This property links the method used for the object positioning to the georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isGeometryMethodOf"></see></summary>
    let isGeometryMethodOf =
        Namespaced_IRI.parse _namespace_name "isGeometryMethodOf" |> NamespacedName

    /// <summary>
    /// This class represents the technique of georeferencing, used for the acquisition of coordinates (i.e. survey from cartography with or without inspection, survey from aerial photos with or without inspection, satellite survey, traditional survey, survey via GPS, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/GeometryTechnique"></see></summary>
    let GeometryTechnique =
        Namespaced_IRI.parse _namespace_name "GeometryTechnique" |> NamespacedName

    /// <summary>
    /// This property links the georeferencing technique to the georeferencing.
    /// <see href="https://w3id.org/arco/ontology/location/isGeometryTechniqueOf"></see></summary>
    let isGeometryTechniqueOf =
        Namespaced_IRI.parse _namespace_name "isGeometryTechniqueOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the historical location.
    /// <see href="https://w3id.org/arco/ontology/location/HistoricalLocation"></see></summary>
    let HistoricalLocation =
        Namespaced_IRI.parse _namespace_name "HistoricalLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, that is the denomination of 'incorporated area'.
    /// <see href="https://w3id.org/arco/ontology/location/IncorporatedArea"></see></summary>
    let IncorporatedArea =
        Namespaced_IRI.parse _namespace_name "IncorporatedArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/location/LandCadastre"></see>
    /// </summary>
    let LandCadastre =
        Namespaced_IRI.parse _namespace_name "LandCadastre" |> NamespacedName

    /// <summary>
    /// Replaced by https://w3id.org/arco/ontology/location/PreviousLocation
    /// This individual represents a specific type of location, that is the place of origin or last location.
    /// <see href="https://w3id.org/arco/ontology/location/LastLocation"></see></summary>
    let LastLocation =
        Namespaced_IRI.parse _namespace_name "LastLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, that is the locality.
    /// <see href="https://w3id.org/arco/ontology/location/Locality"></see></summary>
    let Locality = Namespaced_IRI.parse _namespace_name "Locality" |> NamespacedName

    /// <summary>
    /// This property links the role of a localization (i.e current physical location, previous location, finding location, etc.) to an entity referring to it (e.g. a situation in which a place plays a certain role in relation to a cultural property in a time frame, or a georeferencing, or a cadastral identity).
    /// <see href="https://w3id.org/arco/ontology/location/isLocationTypeOf"></see></summary>
    let isLocationTypeOf =
        Namespaced_IRI.parse _namespace_name "isLocationTypeOf" |> NamespacedName

    /// <summary>
    /// This class represents spatial entities (i.e. roads, waterways, etc.) that border one or more cadastral parcels.
    /// <see href="https://w3id.org/arco/ontology/location/NeighbouringCadastralEntity"></see></summary>
    let NeighbouringCadastralEntity =
        Namespaced_IRI.parse _namespace_name "NeighbouringCadastralEntity" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of location, that is the location of observation.
    /// <see href="https://w3id.org/arco/ontology/location/ObservationLocation"></see></summary>
    let ObservationLocation =
        Namespaced_IRI.parse _namespace_name "ObservationLocation" |> NamespacedName

    /// <summary>
    /// This class represents the information describing the old town where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/OldTown"></see></summary>
    let OldTown = Namespaced_IRI.parse _namespace_name "OldTown" |> NamespacedName

    /// <summary>
    /// This property connects the old town with the urban area that is part of it.
    /// <see href="https://w3id.org/arco/ontology/location/hasUrbanArea"></see></summary>
    let hasUrbanArea =
        Namespaced_IRI.parse _namespace_name "hasUrbanArea" |> NamespacedName

    /// <summary>
    /// This class represents the informations on the denomination of the urban area that is part of the old town where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/UrbanArea"></see></summary>
    let UrbanArea = Namespaced_IRI.parse _namespace_name "UrbanArea" |> NamespacedName

    /// <summary>
    /// This property connects a historical center with information related to its administrative type.
    /// <see href="https://w3id.org/arco/ontology/location/hasOldTownAdministrativeType"></see></summary>
    let hasOldTownAdministrativeType =
        Namespaced_IRI.parse _namespace_name "hasOldTownAdministrativeType" |> NamespacedName

    /// <summary>
    /// This property connects the administrative type with the information related to its historical center.
    /// <see href="https://w3id.org/arco/ontology/location/isOldTownAdministrativeTypeOf"></see></summary>
    let isOldTownAdministrativeTypeOf =
        Namespaced_IRI.parse _namespace_name "isOldTownAdministrativeTypeOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of location, that is the place of origin or previous location.
    /// <see href="https://w3id.org/arco/ontology/location/PreviousLocation"></see></summary>
    let PreviousLocation =
        Namespaced_IRI.parse _namespace_name "PreviousLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of location, that is the production or realization location.
    /// <see href="https://w3id.org/arco/ontology/location/ProductionRealizationLocation"></see></summary>
    let ProductionRealizationLocation =
        Namespaced_IRI.parse _namespace_name "ProductionRealizationLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the shooting location.
    /// <see href="https://w3id.org/arco/ontology/location/ShootingLocation"></see></summary>
    let ShootingLocation =
        Namespaced_IRI.parse _namespace_name "ShootingLocation" |> NamespacedName

    /// <summary>
    /// This class represents the type definition of a physical container.
    /// <see href="https://w3id.org/arco/ontology/location/SiteDefinition"></see></summary>
    let SiteDefinition =
        Namespaced_IRI.parse _namespace_name "SiteDefinition" |> NamespacedName

    /// <summary>
    /// This class represents the type of a physical container, i.e. it contains adjectives or phrases that specify, integrate or characterize the physical container from the point of view of the legal-administrative or functional condition.
    /// <see href="https://w3id.org/arco/ontology/location/SiteType"></see></summary>
    let SiteType = Namespaced_IRI.parse _namespace_name "SiteType" |> NamespacedName

    /// <summary>
    /// This property links the definition of a physical container to of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteDefinitionOf"></see></summary>
    let isSiteDefinitionOf =
        Namespaced_IRI.parse _namespace_name "isSiteDefinitionOf" |> NamespacedName

    /// <summary>
    /// This class represents specifications about the physical container, i.e. the adjective or the phrase that with respect to the Site Definition specifies, integrates or characterizes the physical container from the point of view of the legal-administrative or functional condition.
    /// <see href="https://w3id.org/arco/ontology/location/SiteSpecification"></see></summary>
    let SiteSpecification =
        Namespaced_IRI.parse _namespace_name "SiteSpecification" |> NamespacedName

    /// <summary>
    /// This property links the specification of a physical container to one of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteSpecificationOf"></see></summary>
    let isSiteSpecificationOf =
        Namespaced_IRI.parse _namespace_name "isSiteSpecificationOf" |> NamespacedName

    /// <summary>
    /// This property connects the type of physical container to a physical container (Site), to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteTypeOf"></see></summary>
    let isSiteTypeOf =
        Namespaced_IRI.parse _namespace_name "isSiteTypeOf" |> NamespacedName

    /// <summary>
    /// This property links the type of a physical container to one of its components, that is to the definition of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteDefinition"></see></summary>
    let hasSiteDefinition =
        Namespaced_IRI.parse _namespace_name "hasSiteDefinition" |> NamespacedName

    /// <summary>
    /// This property links the type of a physical container to one of its components, that is to the specifications of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteSpecification"></see></summary>
    let hasSiteSpecification =
        Namespaced_IRI.parse _namespace_name "hasSiteSpecification" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the storage location.
    /// <see href="https://w3id.org/arco/ontology/location/StorageLocation"></see></summary>
    let StorageLocation =
        Namespaced_IRI.parse _namespace_name "StorageLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of localization, that is the subject location.
    /// <see href="https://w3id.org/arco/ontology/location/SubjectLocation"></see></summary>
    let SubjectLocation =
        Namespaced_IRI.parse _namespace_name "SubjectLocation" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of geographical context, that is a suburban context, which is located in the intermediate area between the urban and extraurban context.
    /// <see href="https://w3id.org/arco/ontology/location/SuburbanContext"></see></summary>
    let SuburbanContext =
        Namespaced_IRI.parse _namespace_name "SuburbanContext" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of context, i.e. the territorial context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/TerritorialContext"></see></summary>
    let TerritorialContext =
        Namespaced_IRI.parse _namespace_name "TerritorialContext" |> NamespacedName

    /// <summary>
    /// This class represents a localization of a cultural property, within a timeframe and qualified according to the role that the localization plays in relation to the cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/TimeIndexedTypedLocation"></see></summary>
    let TimeIndexedTypedLocation =
        Namespaced_IRI.parse _namespace_name "TimeIndexedTypedLocation" |> NamespacedName

    /// <summary>
    /// This property links a typified location over time to an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isTimeIndexedTypedLocationOf"></see></summary>
    let isTimeIndexedTypedLocationOf =
        Namespaced_IRI.parse _namespace_name "isTimeIndexedTypedLocationOf" |> NamespacedName

    /// <summary>
    /// This property links a typed location over time to its related geographical entity.
    /// <see href="https://w3id.org/arco/ontology/location/atLocation"></see></summary>
    let atLocation = Namespaced_IRI.parse _namespace_name "atLocation" |> NamespacedName
    /// <summary>
    /// This property links a typified location over time to its physical container (Site).
    /// <see href="https://w3id.org/arco/ontology/location/atSite"></see></summary>
    let atSite = Namespaced_IRI.parse _namespace_name "atSite" |> NamespacedName

    /// <summary>
    /// This class represents other place's designations changing over time.
    /// <see href="https://w3id.org/arco/ontology/location/ToponymInTime"></see></summary>
    let ToponymInTime =
        Namespaced_IRI.parse _namespace_name "ToponymInTime" |> NamespacedName

    /// <summary>
    /// This property relates a toponym chianging over time to a geographical entity.
    /// <see href="https://w3id.org/arco/ontology/location/isToponymInTimeOf"></see></summary>
    let isToponymInTimeOf =
        Namespaced_IRI.parse _namespace_name "isToponymInTimeOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of administrative reference that characterizes the old town, i.e. the town fraction.
    /// <see href="https://w3id.org/arco/ontology/location/TownFraction"></see></summary>
    let TownFraction =
        Namespaced_IRI.parse _namespace_name "TownFraction" |> NamespacedName

    /// <summary>
    /// This property relates the type of context (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context) an entity where it is located.
    /// <see href="https://w3id.org/arco/ontology/location/isTypeOfContextOf"></see></summary>
    let isTypeOfContextOf =
        Namespaced_IRI.parse _namespace_name "isTypeOfContextOf" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of context, that is the underwater context where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/UnderwaterContext"></see></summary>
    let UnderwaterContext =
        Namespaced_IRI.parse _namespace_name "UnderwaterContext" |> NamespacedName

    /// <summary>
    /// This individual represents a specific type of context, that is the urban context where the cultural asset is located.
    /// <see href="https://w3id.org/arco/ontology/location/UrbanContext"></see></summary>
    let UrbanContext =
        Namespaced_IRI.parse _namespace_name "UrbanContext" |> NamespacedName

    /// <summary>
    /// This property associates the order number that identifies a location intended as an administrative unit, i.e. an old town, an urban area and a sector.
    /// <see href="https://w3id.org/arco/ontology/location/administrativeOrderNumber"></see></summary>
    let administrativeOrderNumber =
        Namespaced_IRI.parse _namespace_name "administrativeOrderNumber" |> NamespacedName

    /// <summary>
    /// This property links the object georeferencing (Geometry) to its coordinates (x, y, z).
    /// <see href="https://w3id.org/arco/ontology/location/hasCoordinates"></see></summary>
    let hasCoordinates =
        Namespaced_IRI.parse _namespace_name "hasCoordinates" |> NamespacedName

    /// <summary>
    /// This property relates a geographical feature to a time indexed typed location that refers to that feature.
    /// <see href="https://w3id.org/arco/ontology/location/isLocationIn"></see></summary>
    let isLocationIn =
        Namespaced_IRI.parse _namespace_name "isLocationIn" |> NamespacedName

    /// <summary>
    /// This property relates a cultural site to the time indexed typed location.
    /// <see href="https://w3id.org/arco/ontology/location/isSiteIn"></see></summary>
    let isSiteIn = Namespaced_IRI.parse _namespace_name "isSiteIn" |> NamespacedName

    /// <summary>
    /// This property represents the designation of a historical cadastre.
    /// <see href="https://w3id.org/arco/ontology/location/cadastreName"></see></summary>
    let cadastreName =
        Namespaced_IRI.parse _namespace_name "cadastreName" |> NamespacedName

    /// <summary>
    /// This property allows to associate a legal container to its code assigned by the ICCD.
    /// <see href="https://w3id.org/arco/ontology/location/culturalInstituteOrSiteIdentifier"></see></summary>
    let culturalInstituteOrSiteIdentifier =
        Namespaced_IRI.parse _namespace_name "culturalInstituteOrSiteIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the progressive number that identifies the district where the cultural property is located.
    /// <see href="https://w3id.org/arco/ontology/location/districtNumber"></see></summary>
    let districtNumber =
        Namespaced_IRI.parse _namespace_name "districtNumber" |> NamespacedName

    /// <summary>
    /// This property links an object georeferencing to the base map possibly used.
    /// <see href="https://w3id.org/arco/ontology/location/hasBaseMap"></see></summary>
    let hasBaseMap = Namespaced_IRI.parse _namespace_name "hasBaseMap" |> NamespacedName

    /// <summary>
    /// This property links the municipality to which the cadastral map is registered, as attested by the cadastre, to a cadastral identity of an entity.
    /// <see href="https://w3id.org/arco/ontology/location/isCadastralCityOf"></see></summary>
    let isCadastralCityOf =
        Namespaced_IRI.parse _namespace_name "isCadastralCityOf" |> NamespacedName

    /// <summary>
    /// This property links a cultural property to all its cadastral information related to one of its locations: i.e. historical location, current location, finding location, etc.
    /// <see href="https://w3id.org/arco/ontology/location/hasCadastralIdentity"></see></summary>
    let hasCadastralIdentity =
        Namespaced_IRI.parse _namespace_name "hasCadastralIdentity" |> NamespacedName

    /// <summary>
    /// This property relates an address to a clerical administrative area (e.g. a diocese).
    /// <see href="https://w3id.org/arco/ontology/location/hasClericalAdministrativeArea"></see></summary>
    let hasClericalAdministrativeArea =
        Namespaced_IRI.parse _namespace_name "hasClericalAdministrativeArea" |> NamespacedName

    /// <summary>
    /// This property links the location of an entity to the continent where it is located.
    /// <see href="https://w3id.org/arco/ontology/location/hasContinent"></see></summary>
    let hasContinent =
        Namespaced_IRI.parse _namespace_name "hasContinent" |> NamespacedName

    /// <summary>
    ///
    /// This property links a cultural property to the cultural institute or site
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSite"></see></summary>
    let hasCulturalInstituteOrSite =
        Namespaced_IRI.parse _namespace_name "hasCulturalInstituteOrSite" |> NamespacedName

    /// <summary>
    /// This property links a cultural institute or site to a cultural property
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteOf"></see></summary>
    let isCulturalInstituteOrSiteOf =
        Namespaced_IRI.parse _namespace_name "isCulturalInstituteOrSiteOf" |> NamespacedName

    /// <summary>
    /// This property links the type of a cultural institute or site to one of its components, that is to the definition of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteDefinition"></see></summary>
    let hasCulturalInstituteOrSiteDefinition =
        Namespaced_IRI.parse _namespace_name "hasCulturalInstituteOrSiteDefinition" |> NamespacedName

    /// <summary>
    /// This property links the definition of a cultural institute or site to its type.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteDefinitionOf"></see></summary>
    let isCulturalInstituteOrSiteDefinitionOf =
        Namespaced_IRI.parse _namespace_name "isCulturalInstituteOrSiteDefinitionOf" |> NamespacedName

    /// <summary>
    /// This property links the type of a cultural institute or site to one of its components, that is to the specifications of its type.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteSpecification"></see></summary>
    let hasCulturalInstituteOrSiteSpecification =
        Namespaced_IRI.parse _namespace_name "hasCulturalInstituteOrSiteSpecification" |> NamespacedName

    /// <summary>
    /// This property links the specification of a cultural institute or site to one of its type.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteSpecificationOf"></see></summary>
    let isCulturalInstituteOrSiteSpecificationOf =
        Namespaced_IRI.parse _namespace_name "isCulturalInstituteOrSiteSpecificationOf" |> NamespacedName

    /// <summary>
    /// This property connects a Cultural institute or site to its type, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalInstituteOrSiteType"></see></summary>
    let hasCulturalInstituteOrSiteType =
        Namespaced_IRI.parse _namespace_name "hasCulturalInstituteOrSiteType" |> NamespacedName

    /// <summary>
    /// This property connects the type of cultural institute or site to a cultural institute or site, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalInstituteOrSiteTypeof"></see></summary>
    let isCulturalInstituteOrSiteTypeof =
        Namespaced_IRI.parse _namespace_name "isCulturalInstituteOrSiteTypeof" |> NamespacedName

    /// <summary>
    /// This property represents the relationship that links a cultural property to the address of its current physical location at the cataloging time. The report provides a simplified representation, with a reduced expressivity, of the current location of the cultural property, and it causes the loss of other information regarding its location (i.e. the continent, the possible physical container, the specific location in the physical container, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/hasCulturalPropertyAddress"></see></summary>
    let hasCulturalPropertyAddress =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyAddress" |> NamespacedName

    /// <summary>
    /// This property represents the relationship that links the address of the current physical location at the cataloging time to the catalogued cultural property.
    /// <see href="https://w3id.org/arco/ontology/location/isCulturalPropertyAddressOf"></see></summary>
    let isCulturalPropertyAddressOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyAddressOf" |> NamespacedName

    /// <summary>
    /// This property links an entity to its typified location over time.
    /// <see href="https://w3id.org/arco/ontology/location/hasTimeIndexedTypedLocation"></see></summary>
    let hasTimeIndexedTypedLocation =
        Namespaced_IRI.parse _namespace_name "hasTimeIndexedTypedLocation" |> NamespacedName

    /// <summary>
    /// This property links a georeferencing to the method used for the object positioning.
    /// <see href="https://w3id.org/arco/ontology/location/hasGeometryMethod"></see></summary>
    let hasGeometryMethod =
        Namespaced_IRI.parse _namespace_name "hasGeometryMethod" |> NamespacedName

    /// <summary>
    /// This property links a georeferencing to the georeferencing technique.
    /// <see href="https://w3id.org/arco/ontology/location/hasGeometryTechnique"></see></summary>
    let hasGeometryTechnique =
        Namespaced_IRI.parse _namespace_name "hasGeometryTechnique" |> NamespacedName

    /// <summary>
    /// This property links an address to a governmental administrative area.
    /// <see href="https://w3id.org/arco/ontology/location/hasGovernmentalAdministrativeArea"></see></summary>
    let hasGovernmentalAdministrativeArea =
        Namespaced_IRI.parse _namespace_name "hasGovernmentalAdministrativeArea" |> NamespacedName

    /// <summary>
    /// This property links an address to a historical-geographical area.
    /// <see href="https://w3id.org/arco/ontology/location/hasHistoricalArea"></see></summary>
    let hasHistoricalArea =
        Namespaced_IRI.parse _namespace_name "hasHistoricalArea" |> NamespacedName

    /// <summary>
    /// This property links a historical-geographical area to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isHistoricalAreaOf"></see></summary>
    let isHistoricalAreaOf =
        Namespaced_IRI.parse _namespace_name "isHistoricalAreaOf" |> NamespacedName

    /// <summary>
    /// This property connects a physical container (Site) to its type, to allow its correct and precise identification.
    /// <see href="https://w3id.org/arco/ontology/location/hasSiteType"></see></summary>
    let hasSiteType =
        Namespaced_IRI.parse _namespace_name "hasSiteType" |> NamespacedName

    /// <summary>
    /// This property relates a stratigraphic record to the area in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicArea"></see></summary>
    let hasStratigraphicArea =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicArea" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has stratigraphic area".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicAreaOf"></see></summary>
    let isStratigraphicAreaOf =
        Namespaced_IRI.parse _namespace_name "isStratigraphicAreaOf" |> NamespacedName

    /// <summary>
    /// This property relates a stratigraphic record to the room in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicRoom"></see></summary>
    let hasStratigraphicRoom =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicRoom" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has stratigraphic room".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicRoomOf"></see></summary>
    let isStratigraphicRoomOf =
        Namespaced_IRI.parse _namespace_name "isStratigraphicRoomOf" |> NamespacedName

    /// <summary>
    /// This property relates a stratigraphic record to the square in which it took place.
    /// <see href="https://w3id.org/arco/ontology/location/hasStratigraphicSquare"></see></summary>
    let hasStratigraphicSquare =
        Namespaced_IRI.parse _namespace_name "hasStratigraphicSquare" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has stratigraphic square".
    /// <see href="https://w3id.org/arco/ontology/location/isStratigraphicSquareOf"></see></summary>
    let isStratigraphicSquareOf =
        Namespaced_IRI.parse _namespace_name "isStratigraphicSquareOf" |> NamespacedName

    /// <summary>
    /// This property links an address to a territorial area, which may not coincide with the administrative area, to which a cultural property belongs.
    /// <see href="https://w3id.org/arco/ontology/location/hasTerritorialArea"></see></summary>
    let hasTerritorialArea =
        Namespaced_IRI.parse _namespace_name "hasTerritorialArea" |> NamespacedName

    /// <summary>
    /// This property links a territorial area (which may not coincide with the administrative area) to which a cultural property belongs to its address.
    /// <see href="https://w3id.org/arco/ontology/location/isTerritorialAreaOf"></see></summary>
    let isTerritorialAreaOf =
        Namespaced_IRI.parse _namespace_name "isTerritorialAreaOf" |> NamespacedName

    /// <summary>
    /// This property links an address to a territorial division within a territorial area.
    /// <see href="https://w3id.org/arco/ontology/location/hasTerritorialDivision"></see></summary>
    let hasTerritorialDivision =
        Namespaced_IRI.parse _namespace_name "hasTerritorialDivision" |> NamespacedName

    /// <summary>
    /// This property links a territorial division within a territorial area to an address.
    /// <see href="https://w3id.org/arco/ontology/location/isTerritorialDivisionOf"></see></summary>
    let isTerritorialDivisionOf =
        Namespaced_IRI.parse _namespace_name "isTerritorialDivisionOf" |> NamespacedName

    /// <summary>
    /// This property relates a geographical entity to a toponym chianging over time.
    /// <see href="https://w3id.org/arco/ontology/location/hasToponymInTime"></see></summary>
    let hasToponymInTime =
        Namespaced_IRI.parse _namespace_name "hasToponymInTime" |> NamespacedName

    /// <summary>
    /// This property relates an entity to the type of context where the cultural property is located (i.e. urban context, suburban context, extra-urban context, territorial context, underwater context).
    /// <see href="https://w3id.org/arco/ontology/location/hasTypeOfContext"></see></summary>
    let hasTypeOfContext =
        Namespaced_IRI.parse _namespace_name "hasTypeOfContext" |> NamespacedName

    /// <summary>
    /// This property connects the the urban area with the its old town.
    /// <see href="https://w3id.org/arco/ontology/location/isUrbanAreaOf"></see></summary>
    let isUrbanAreaOf =
        Namespaced_IRI.parse _namespace_name "isUrbanAreaOf" |> NamespacedName

    /// <summary>
    /// This property is used to represent other paths and details about the cultural property location.
    /// <see href="https://w3id.org/arco/ontology/location/locationDetails"></see></summary>
    let locationDetails =
        Namespaced_IRI.parse _namespace_name "locationDetails" |> NamespacedName

    /// <summary>
    /// This property represents the absolute maximum altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/maxAlt"></see></summary>
    let maxAlt = Namespaced_IRI.parse _namespace_name "maxAlt" |> NamespacedName
    /// <summary>
    /// This property represents the absolute minimum altitude above sea level.
    /// <see href="https://w3id.org/arco/ontology/location/minAlt"></see></summary>
    let minAlt = Namespaced_IRI.parse _namespace_name "minAlt" |> NamespacedName
    /// <summary>
    /// This property represents the type of point that georeferences the catalogued cultural property. The definition of the point type is not univocal and depends on the cultural property's type and conformation as well as on the type of location.
    /// <see href="https://w3id.org/arco/ontology/location/pointType"></see></summary>
    let pointType = Namespaced_IRI.parse _namespace_name "pointType" |> NamespacedName

    /// <summary>
    /// This property represents the object relative height by reference to a point or an element or a situation to be specified.
    /// <see href="https://w3id.org/arco/ontology/location/relativeAlt"></see></summary>
    let relativeAlt =
        Namespaced_IRI.parse _namespace_name "relativeAlt" |> NamespacedName

    /// <summary>
    /// This property allows to associate a physical container to its code assigned by the ICCD.
    /// <see href="https://w3id.org/arco/ontology/location/siteIdentifier"></see></summary>
    let siteIdentifier =
        Namespaced_IRI.parse _namespace_name "siteIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the reference system used for the object georeferencing (e.g. WGS84, WGS84 UTM32, etc.).
    /// <see href="https://w3id.org/arco/ontology/location/spatialReferenceSystem"></see></summary>
    let spatialReferenceSystem =
        Namespaced_IRI.parse _namespace_name "spatialReferenceSystem" |> NamespacedName

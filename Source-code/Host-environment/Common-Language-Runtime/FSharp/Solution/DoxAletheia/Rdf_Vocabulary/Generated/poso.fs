namespace http.purl.org.poso.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module poso =
    let _namespace_iri = Namespace_Iri poso |> NamespaceIRI
    /// <summary>
    ///   <para>poso:AbsolutePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An absolute position describes the position of an entity based on a fixed point in space. Usually this space is the Earth and the position is expressed in latitude and longitude.</para>
    /// labels<para>Absolute position</para></remarks>
    /// <seealso href="http://purl.org/poso/AbsolutePosition">http://purl.org/poso/AbsolutePosition</seealso>
    let AbsolutePosition = Prefixed_Name(poso, "AbsolutePosition") |> PrefixedName
    /// <summary>
    ///   <para>poso:AngularAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Angular acceleration</para><para>Draaiversnelling</para></remarks>
    /// <seealso href="http://purl.org/poso/AngularAcceleration">http://purl.org/poso/AngularAcceleration</seealso>
    let AngularAcceleration = Prefixed_Name(poso, "AngularAcceleration") |> PrefixedName
    /// <summary>
    ///   <para>poso:zAxisValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Quantitative result value along the Z-axis of a spatial sensor.</para>
    /// labels<para>z-axis value</para></remarks>
    /// <seealso href="http://purl.org/poso/zAxisValue">http://purl.org/poso/zAxisValue</seealso>
    let zAxisValue = Prefixed_Name(poso, "zAxisValue") |> PrefixedName

    /// <summary>
    ///   <para>poso:PositioningTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A positioning technique is a procedure to sample sensor data to an output position.</para>
    /// labels<para>Positioning technique</para></remarks>
    /// <seealso href="http://purl.org/poso/PositioningTechnique">http://purl.org/poso/PositioningTechnique</seealso>
    let PositioningTechnique =
        Prefixed_Name(poso, "PositioningTechnique") |> PrefixedName

    /// <summary>
    ///   <para>poso:IndoorDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the spatial deployment of a System in an indoor environment.</para>
    /// labels<para>Indoor deployment</para></remarks>
    /// <seealso href="http://purl.org/poso/IndoorDeployment">http://purl.org/poso/IndoorDeployment</seealso>
    let IndoorDeployment = Prefixed_Name(poso, "IndoorDeployment") |> PrefixedName
    /// <summary>
    ///   <para>poso:Multilateration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Multilateration is the procedure of determining a position using relative distances to other known positions.</para>
    /// labels<para>Multilateration</para></remarks>
    /// <seealso href="http://purl.org/poso/Multilateration">http://purl.org/poso/Multilateration</seealso>
    let Multilateration = Prefixed_Name(poso, "Multilateration") |> PrefixedName
    /// <summary>
    ///   <para>poso:OutdoorDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the deployment of a System in an outdoor environment.</para>
    /// labels<para>Outdoor deployment</para></remarks>
    /// <seealso href="http://purl.org/poso/OutdoorDeployment">http://purl.org/poso/OutdoorDeployment</seealso>
    let OutdoorDeployment = Prefixed_Name(poso, "OutdoorDeployment") |> PrefixedName
    /// <summary>
    ///   <para>poso:PositionOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Position output</para></remarks>
    /// <seealso href="http://purl.org/poso/PositionOutput">http://purl.org/poso/PositionOutput</seealso>
    let PositionOutput = Prefixed_Name(poso, "PositionOutput") |> PrefixedName
    /// <summary>
    ///   <para>poso:PositioningPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A positioning platform is a framework, architecture or platform used to develop and host a positioning system.</para>
    /// labels<para>Positioning platform</para></remarks>
    /// <seealso href="http://purl.org/poso/PositioningPlatform">http://purl.org/poso/PositioningPlatform</seealso>
    let PositioningPlatform = Prefixed_Name(poso, "PositioningPlatform") |> PrefixedName
    /// <summary>
    ///   <para>poso:VSLAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Visual simultaneous localisation and mapping (VSLAM) is a positioning techniques that uses visual imagery to map an environment. Positioning works by detecting features of interest in image frames and comparing how these features move from one frame to another.</para>
    /// labels<para>Visual simultaneous localisation and mapping</para></remarks>
    /// <seealso href="http://purl.org/poso/VSLAM">http://purl.org/poso/VSLAM</seealso>
    let VSLAM = Prefixed_Name(poso, "VSLAM") |> PrefixedName
    /// <summary>
    ///   <para>poso:VisualOdometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Visual odometry is the procedure of detecting movement by analyzing how visual features are moving from one Observation image frame to another.</para>
    /// labels<para>Visual odometry</para></remarks>
    /// <seealso href="http://purl.org/poso/VisualOdometry">http://purl.org/poso/VisualOdometry</seealso>
    let VisualOdometry = Prefixed_Name(poso, "VisualOdometry") |> PrefixedName
    /// <summary>
    ///   <para>poso:isAccelerationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is versnelling van</para><para>is acceleration of</para></remarks>
    /// <seealso href="http://purl.org/poso/isAccelerationOf">http://purl.org/poso/isAccelerationOf</seealso>
    let isAccelerationOf = Prefixed_Name(poso, "isAccelerationOf") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The accuracy of an entity.</para>
    /// labels<para>heeft accuraatheid</para><para>has accuracy</para></remarks>
    /// <seealso href="http://purl.org/poso/hasAccuracy">http://purl.org/poso/hasAccuracy</seealso>
    let hasAccuracy = Prefixed_Name(poso, "hasAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>heeft een coördinaten referentiesysteem</para><para>has coordinate reference system</para></remarks>
    /// <seealso href="http://purl.org/poso/hasCRS">http://purl.org/poso/hasCRS</seealso>
    let hasCRS = Prefixed_Name(poso, "hasCRS") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Duid de snelheid van een object aan.</para>
    ///   <para>Indicates the velocity of a feature of interest.</para>
    /// labels<para>heeft snelheid</para><para>has velocity</para></remarks>
    /// <seealso href="http://purl.org/poso/hasVelocity">http://purl.org/poso/hasVelocity</seealso>
    let hasVelocity = Prefixed_Name(poso, "hasVelocity") |> PrefixedName
    /// <summary>
    ///   <para>poso:1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/poso/1.0/">http://purl.org/poso/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(poso, "1.0/") |> PrefixedName
    /// <summary>
    ///   <para>poso:Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Acceleration is the (instantaneous) rate of change of velocity.</para>
    /// labels<para>Acceleration</para><para>Versnelling</para></remarks>
    /// <seealso href="http://purl.org/poso/Acceleration">http://purl.org/poso/Acceleration</seealso>
    let Acceleration = Prefixed_Name(poso, "Acceleration") |> PrefixedName
    /// <summary>
    ///   <para>poso:Angulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Angulation is a triangulation method to determine a position based on the relative angles to other objects.</para>
    /// labels<para>Angulation</para></remarks>
    /// <seealso href="http://purl.org/poso/Angulation">http://purl.org/poso/Angulation</seealso>
    let Angulation = Prefixed_Name(poso, "Angulation") |> PrefixedName
    /// <summary>
    ///   <para>poso:Triangulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Triangulation is the procedure of determining a position using relative angles to a feature of interest with a known position.</para>
    /// labels<para>Triangulation</para></remarks>
    /// <seealso href="http://purl.org/poso/Triangulation">http://purl.org/poso/Triangulation</seealso>
    let Triangulation = Prefixed_Name(poso, "Triangulation") |> PrefixedName
    /// <summary>
    ///   <para>poso:angle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Quantitative anglue result value for axis-angle representation.</para>
    /// labels<para>angle</para><para>hoek</para></remarks>
    /// <seealso href="http://purl.org/poso/angle">http://purl.org/poso/angle</seealso>
    let angle = Prefixed_Name(poso, "angle") |> PrefixedName
    /// <summary>
    ///   <para>poso:EulerOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Euler orientation</para></remarks>
    /// <seealso href="http://purl.org/poso/EulerOrientation">http://purl.org/poso/EulerOrientation</seealso>
    let EulerOrientation = Prefixed_Name(poso, "EulerOrientation") |> PrefixedName
    /// <summary>
    ///   <para>poso:pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Pitch is the rotation around the x-axis with respect to the object the yaw applies to.</para>
    /// labels<para>pitch</para></remarks>
    /// <seealso href="http://purl.org/poso/pitch">http://purl.org/poso/pitch</seealso>
    let pitch = Prefixed_Name(poso, "pitch") |> PrefixedName
    /// <summary>
    ///   <para>poso:roll</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Roll is the rotation around the y-axis with respect to the object the roll applies to.</para>
    /// labels<para>roll</para></remarks>
    /// <seealso href="http://purl.org/poso/roll">http://purl.org/poso/roll</seealso>
    let roll = Prefixed_Name(poso, "roll") |> PrefixedName
    /// <summary>
    ///   <para>poso:yaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Yaw is the rotation around the z-axis with respect to the object the yaw applies to.</para>
    /// labels<para>yaw</para></remarks>
    /// <seealso href="http://purl.org/poso/yaw">http://purl.org/poso/yaw</seealso>
    let yaw = Prefixed_Name(poso, "yaw") |> PrefixedName
    /// <summary>
    ///   <para>poso:Fingerprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fingerprint is a scene analysis at a particular absolute position.</para>
    /// labels<para>Fingerprint</para></remarks>
    /// <seealso href="http://purl.org/poso/Fingerprint">http://purl.org/poso/Fingerprint</seealso>
    let Fingerprint = Prefixed_Name(poso, "Fingerprint") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the absolute or relative position of a feature of interest.</para>
    ///   <para>Duid de absolute of relatieve positie van een object aan.</para>
    /// labels<para>heeft positie</para><para>has position</para></remarks>
    /// <seealso href="http://purl.org/poso/hasPosition">http://purl.org/poso/hasPosition</seealso>
    let hasPosition = Prefixed_Name(poso, "hasPosition") |> PrefixedName
    /// <summary>
    ///   <para>poso:Fingerprinting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fingerprinting is a positioning Procedure where sensor data is collected at a specific position and orientation. During the offline-stage of a positioning system, the significant data features are extracted and stored for that position. In the online-stage, the closest match(es) of the features are determined to predict the position.</para>
    /// labels<para>Fingerprinting</para></remarks>
    /// <seealso href="http://purl.org/poso/Fingerprinting">http://purl.org/poso/Fingerprinting</seealso>
    let Fingerprinting = Prefixed_Name(poso, "Fingerprinting") |> PrefixedName
    /// <summary>
    ///   <para>poso:Lateration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lateration</para></remarks>
    /// <seealso href="http://purl.org/poso/Lateration">http://purl.org/poso/Lateration</seealso>
    let Lateration = Prefixed_Name(poso, "Lateration") |> PrefixedName
    /// <summary>
    ///   <para>poso:LinearAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Linear acceleration</para></remarks>
    /// <seealso href="http://purl.org/poso/LinearAcceleration">http://purl.org/poso/LinearAcceleration</seealso>
    let LinearAcceleration = Prefixed_Name(poso, "LinearAcceleration") |> PrefixedName
    /// <summary>
    ///   <para>poso:LinearMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Linear movement along a certain axis.</para>
    /// labels<para>Lineaire beweging</para><para>Linear movement</para></remarks>
    /// <seealso href="http://purl.org/poso/LinearMovement">http://purl.org/poso/LinearMovement</seealso>
    let LinearMovement = Prefixed_Name(poso, "LinearMovement") |> PrefixedName
    /// <summary>
    ///   <para>poso:LinearVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Linear velocity is the momentum along one ore more axis.</para>
    /// labels<para>Lineaire snelheid</para><para>Linear velocity</para></remarks>
    /// <seealso href="http://purl.org/poso/LinearVelocity">http://purl.org/poso/LinearVelocity</seealso>
    let LinearVelocity = Prefixed_Name(poso, "LinearVelocity") |> PrefixedName
    /// <summary>
    ///   <para>poso:LowLevelFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Low Level Sensor Fusion is about fusing the raw data coming from multiple sensors. For example, we fuse point clouds coming from LiDARs and pixels coming from cameras.</para>
    /// labels<para>Low level sensor fusion</para></remarks>
    /// <seealso href="http://purl.org/poso/LowLevelFusion">http://purl.org/poso/LowLevelFusion</seealso>
    let LowLevelFusion = Prefixed_Name(poso, "LowLevelFusion") |> PrefixedName
    /// <summary>
    ///   <para>poso:MagneticOdometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Magnetic field odometry is the procedure of detecting movement by analyizing how the magnetic field is changing from one Observation to another.</para>
    /// labels<para>Magnetic odometry</para></remarks>
    /// <seealso href="http://purl.org/poso/MagneticOdometry">http://purl.org/poso/MagneticOdometry</seealso>
    let MagneticOdometry = Prefixed_Name(poso, "MagneticOdometry") |> PrefixedName
    /// <summary>
    ///   <para>poso:MapOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Map output</para></remarks>
    /// <seealso href="http://purl.org/poso/MapOutput">http://purl.org/poso/MapOutput</seealso>
    let MapOutput = Prefixed_Name(poso, "MapOutput") |> PrefixedName
    /// <summary>
    ///   <para>poso:MidLevelFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mid-Level sensor fusion is about fusing the objects detected independently on sensor data.</para>
    /// labels<para>Mid level sensor fusion</para></remarks>
    /// <seealso href="http://purl.org/poso/MidLevelFusion">http://purl.org/poso/MidLevelFusion</seealso>
    let MidLevelFusion = Prefixed_Name(poso, "MidLevelFusion") |> PrefixedName

    /// <summary>
    ///   <para>poso:OpticalPositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An optical positioning system is a positioning system that determines the position of an object by means of the properties of light.</para>
    /// labels<para>Optical positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/OpticalPositioningSystem">http://purl.org/poso/OpticalPositioningSystem</seealso>
    let OpticalPositioningSystem =
        Prefixed_Name(poso, "OpticalPositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:SRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An identifiable and observable spatial reference system that represents the System's ability to operate its primary purpose in a specified reference system.</para>
    /// labels<para>Spatial Reference System</para></remarks>
    /// <seealso href="http://purl.org/poso/SRS">http://purl.org/poso/SRS</seealso>
    let SRS = Prefixed_Name(poso, "SRS") |> PrefixedName

    /// <summary>
    ///   <para>poso:SatellitePositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In this context, satellite positioning implies the use of radio signals transmitted from "active" artificial objects orbiting the Earth and received by "passive" instruments on or near the Earth's surface to determine position, velocity, and/or attitude of an object.</para>
    /// labels<para>Satellite positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/SatellitePositioningSystem">http://purl.org/poso/SatellitePositioningSystem</seealso>
    let SatellitePositioningSystem =
        Prefixed_Name(poso, "SatellitePositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:TrackedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A feature of interest that is being tracked by a positioning system. This is the feature for which a position is observed.</para>
    /// labels<para>Tracked feature</para></remarks>
    /// <seealso href="http://purl.org/poso/TrackedFeature">http://purl.org/poso/TrackedFeature</seealso>
    let TrackedFeature = Prefixed_Name(poso, "TrackedFeature") |> PrefixedName
    /// <summary>
    ///   <para>poso:VisualInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Visual input</para></remarks>
    /// <seealso href="http://purl.org/poso/VisualInput">http://purl.org/poso/VisualInput</seealso>
    let VisualInput = Prefixed_Name(poso, "VisualInput") |> PrefixedName
    /// <summary>
    ///   <para>poso:VisualLandmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A visual landmark is a feature of interest that visually present in the space.</para>
    /// labels<para>Visual landmark</para></remarks>
    /// <seealso href="http://purl.org/poso/VisualLandmark">http://purl.org/poso/VisualLandmark</seealso>
    let VisualLandmark = Prefixed_Name(poso, "VisualLandmark") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasAcceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that links a feature of interest to a unique acceleration property related to this feature.</para>
    /// labels<para>heeft versnelling</para><para>has acceleration</para></remarks>
    /// <seealso href="http://purl.org/poso/hasAcceleration">http://purl.org/poso/hasAcceleration</seealso>
    let hasAcceleration = Prefixed_Name(poso, "hasAcceleration") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasSRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies an entity that has a spatial reference system in order to interpret the result.</para>
    /// labels<para>heeft een ruimtelijk referentiepunt</para><para>has spatial reference system</para></remarks>
    /// <seealso href="http://purl.org/poso/hasSRS">http://purl.org/poso/hasSRS</seealso>
    let hasSRS = Prefixed_Name(poso, "hasSRS") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the orientation of a feature of interest.</para>
    ///   <para>Duid de orientatie aan van een object aan.</para>
    /// labels<para>heeft orientatie</para><para>has orientation</para></remarks>
    /// <seealso href="http://purl.org/poso/hasOrientation">http://purl.org/poso/hasOrientation</seealso>
    let hasOrientation = Prefixed_Name(poso, "hasOrientation") |> PrefixedName
    /// <summary>
    ///   <para>poso:isOrientationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is orientatie van</para><para>is orientation of</para></remarks>
    /// <seealso href="http://purl.org/poso/isOrientationOf">http://purl.org/poso/isOrientationOf</seealso>
    let isOrientationOf = Prefixed_Name(poso, "isOrientationOf") |> PrefixedName
    /// <summary>
    ///   <para>poso:isPositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is position of</para><para>is positie van</para></remarks>
    /// <seealso href="http://purl.org/poso/isPositionOf">http://purl.org/poso/isPositionOf</seealso>
    let isPositionOf = Prefixed_Name(poso, "isPositionOf") |> PrefixedName
    /// <summary>
    ///   <para>poso:hasRelativePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>heeft relatieve positie</para><para>has relative position</para></remarks>
    /// <seealso href="http://purl.org/poso/hasRelativePosition">http://purl.org/poso/hasRelativePosition</seealso>
    let hasRelativePosition = Prefixed_Name(poso, "hasRelativePosition") |> PrefixedName
    /// <summary>
    ///   <para>poso:madeBySystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to a re-usable system that computed the observation.</para>
    /// labels<para>gemaakt door systeem</para><para>made by system</para></remarks>
    /// <seealso href="http://purl.org/poso/madeBySystem">http://purl.org/poso/madeBySystem</seealso>
    let madeBySystem = Prefixed_Name(poso, "madeBySystem") |> PrefixedName
    /// <summary>
    ///   <para>poso:observesType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a system and an observable property class to identify that a system observes a specific type of property.</para>
    /// labels<para>observeert type</para><para>observes type</para></remarks>
    /// <seealso href="http://purl.org/poso/observesType">http://purl.org/poso/observesType</seealso>
    let observesType = Prefixed_Name(poso, "observesType") |> PrefixedName
    /// <summary>
    ///   <para>poso:Velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Linear or angular velocity of a feature.</para>
    /// labels<para>Velocity</para></remarks>
    /// <seealso href="http://purl.org/poso/Velocity">http://purl.org/poso/Velocity</seealso>
    let Velocity = Prefixed_Name(poso, "Velocity") |> PrefixedName
    /// <summary>
    ///   <para>poso:Landmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A landmark is a feature with a known position, that can be used to identify the position of an object that has a relative position with this feature.</para>
    /// labels<para>Landmark</para></remarks>
    /// <seealso href="http://purl.org/poso/Landmark">http://purl.org/poso/Landmark</seealso>
    let Landmark = Prefixed_Name(poso, "Landmark") |> PrefixedName
    /// <summary>
    ///   <para>poso:SLAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simultaneous localization and mapping (SLAM) is the computational problem of constructing or updating a map of an unknown environment while simultaneously keeping track of an agent's location within it.</para>
    /// labels<para>Simultaneous localisation and mapping</para></remarks>
    /// <seealso href="http://purl.org/poso/SLAM">http://purl.org/poso/SLAM</seealso>
    let SLAM = Prefixed_Name(poso, "SLAM") |> PrefixedName
    /// <summary>
    ///   <para>poso:HighLevelFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>High level sensor fusion is about fusing both objects and their trajectories. We're not only relying on detections, but also on predictions and tracking.</para>
    /// labels<para>High level sensor fusion</para></remarks>
    /// <seealso href="http://purl.org/poso/HighLevelFusion">http://purl.org/poso/HighLevelFusion</seealso>
    let HighLevelFusion = Prefixed_Name(poso, "HighLevelFusion") |> PrefixedName
    /// <summary>
    ///   <para>poso:SensorFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor fusion is a procedure where multiple sensor data is combined to obtain a more reliable or accurate result.</para>
    /// labels<para>Sensor fusion</para></remarks>
    /// <seealso href="http://purl.org/poso/SensorFusion">http://purl.org/poso/SensorFusion</seealso>
    let SensorFusion = Prefixed_Name(poso, "SensorFusion") |> PrefixedName

    /// <summary>
    ///   <para>poso:IndoorPositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A positioning system that is meant to perform indoor positioning of a feature of interest.</para>
    /// labels<para>Indoor positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/IndoorPositioningSystem">http://purl.org/poso/IndoorPositioningSystem</seealso>
    let IndoorPositioningSystem =
        Prefixed_Name(poso, "IndoorPositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:IntegratedPositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An integrated positioning system is a positioning system that incorporates multiple positioning technologies.</para>
    /// labels<para>Integrated positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/IntegratedPositioningSystem">http://purl.org/poso/IntegratedPositioningSystem</seealso>
    let IntegratedPositioningSystem =
        Prefixed_Name(poso, "IntegratedPositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:RFLandmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A radio frequency landmark is a transmitting landmark that can be observed by its transmitting signals.</para>
    /// labels<para>RF landmark</para></remarks>
    /// <seealso href="http://purl.org/poso/RFLandmark">http://purl.org/poso/RFLandmark</seealso>
    let RFLandmark = Prefixed_Name(poso, "RFLandmark") |> PrefixedName
    /// <summary>
    ///   <para>poso:RadioPropagation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The radio propagation formulas cover the computation of the radio waves through a medium (e.g. air).</para>
    /// labels<para>Radio propagation</para></remarks>
    /// <seealso href="http://purl.org/poso/RadioPropagation">http://purl.org/poso/RadioPropagation</seealso>
    let RadioPropagation = Prefixed_Name(poso, "RadioPropagation") |> PrefixedName
    /// <summary>
    ///   <para>poso:RelativeAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A relative angle is a quantitative angle relative to another feature of interest.</para>
    /// labels<para>Relatieve hoek</para><para>Relative angle</para></remarks>
    /// <seealso href="http://purl.org/poso/RelativeAngle">http://purl.org/poso/RelativeAngle</seealso>
    let RelativeAngle = Prefixed_Name(poso, "RelativeAngle") |> PrefixedName
    /// <summary>
    ///   <para>poso:RelativePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een relatieve positie is een positie van een punt, met respect tot de posities van andere objecten die relatief zijn.</para>
    ///   <para>A relative position is a position of a feature of interest with respect to the positions of other objects that this position is relative to.</para>
    /// labels<para>Relatieve positie</para><para>Relative position</para></remarks>
    /// <seealso href="http://purl.org/poso/RelativePosition">http://purl.org/poso/RelativePosition</seealso>
    let RelativePosition = Prefixed_Name(poso, "RelativePosition") |> PrefixedName
    /// <summary>
    ///   <para>poso:RelativeDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A relative distance is a quantitative distance relative to another feature of interest.</para>
    /// labels<para>Relative distance</para><para>Relatieve afstand</para></remarks>
    /// <seealso href="http://purl.org/poso/RelativeDistance">http://purl.org/poso/RelativeDistance</seealso>
    let RelativeDistance = Prefixed_Name(poso, "RelativeDistance") |> PrefixedName
    /// <summary>
    ///   <para>poso:isRelativeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a relative position to be relative to another feature of interest.</para>
    /// labels<para>is relatief met</para><para>is relative to</para></remarks>
    /// <seealso href="http://purl.org/poso/isRelativeTo">http://purl.org/poso/isRelativeTo</seealso>
    let isRelativeTo = Prefixed_Name(poso, "isRelativeTo") |> PrefixedName
    /// <summary>
    ///   <para>poso:RelativeVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A relative velocity is a quantitative velocity relative to another feature of interest.</para>
    /// labels<para>Relatieve snelheid</para><para>Relative velocity</para></remarks>
    /// <seealso href="http://purl.org/poso/RelativeVelocity">http://purl.org/poso/RelativeVelocity</seealso>
    let RelativeVelocity = Prefixed_Name(poso, "RelativeVelocity") |> PrefixedName

    /// <summary>
    ///   <para>poso:LocationBasedService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location based service (LBS) is a service that provides the location of a person or object. It provides this information without the required knowledge of the underlying technologies and algorithms.</para>
    /// labels<para>Location based service</para></remarks>
    /// <seealso href="http://purl.org/poso/LocationBasedService">http://purl.org/poso/LocationBasedService</seealso>
    let LocationBasedService =
        Prefixed_Name(poso, "LocationBasedService") |> PrefixedName

    /// <summary>
    ///   <para>poso:Odometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Odometry is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.</para>
    /// labels<para>Odometry</para></remarks>
    /// <seealso href="http://purl.org/poso/Odometry">http://purl.org/poso/Odometry</seealso>
    let Odometry = Prefixed_Name(poso, "Odometry") |> PrefixedName
    /// <summary>
    ///   <para>poso:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/poso/">http://purl.org/poso/</seealso>
    let _prefix_iri = Prefixed_Name(poso, "") |> PrefixedName
    /// <summary>
    ///   <para>poso:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A position indicates where an entity is located.</para>
    /// labels<para>Position</para><para>Positie</para></remarks>
    /// <seealso href="http://purl.org/poso/Position">http://purl.org/poso/Position</seealso>
    let Position = Prefixed_Name(poso, "Position") |> PrefixedName
    /// <summary>
    ///   <para>poso:AngularMovement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Angular movement around a certain origin point.</para>
    /// labels<para>Angular movement</para><para>Draaibeweging</para></remarks>
    /// <seealso href="http://purl.org/poso/AngularMovement">http://purl.org/poso/AngularMovement</seealso>
    let AngularMovement = Prefixed_Name(poso, "AngularMovement") |> PrefixedName
    /// <summary>
    ///   <para>poso:Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Movement stimulus triggering an update of a position.</para>
    /// labels<para>Beweging</para><para>Movement</para></remarks>
    /// <seealso href="http://purl.org/poso/Movement">http://purl.org/poso/Movement</seealso>
    let Movement = Prefixed_Name(poso, "Movement") |> PrefixedName
    /// <summary>
    ///   <para>poso:AngularVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Angular velocity is the momentum around a point of origin.</para>
    /// labels<para>Angular velocity</para><para>Draaisnelheid</para></remarks>
    /// <seealso href="http://purl.org/poso/AngularVelocity">http://purl.org/poso/AngularVelocity</seealso>
    let AngularVelocity = Prefixed_Name(poso, "AngularVelocity") |> PrefixedName
    /// <summary>
    ///   <para>poso:AuditoryLandmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A spatial landmark that can be observed by sound.</para>
    /// labels<para>Auditory landmark</para></remarks>
    /// <seealso href="http://purl.org/poso/AuditoryLandmark">http://purl.org/poso/AuditoryLandmark</seealso>
    let AuditoryLandmark = Prefixed_Name(poso, "AuditoryLandmark") |> PrefixedName

    /// <summary>
    ///   <para>poso:AxisAngleOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The axis-angle orientation is an orientation representation where the x, y and z values are rotated with a certain angle.</para>
    /// labels<para>Axis-angle orientation</para></remarks>
    /// <seealso href="http://purl.org/poso/AxisAngleOrientation">http://purl.org/poso/AxisAngleOrientation</seealso>
    let AxisAngleOrientation =
        Prefixed_Name(poso, "AxisAngleOrientation") |> PrefixedName

    /// <summary>
    ///   <para>poso:xAxisValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Quantitative result value along the X-axis of a spatial sensor or result.</para>
    /// labels<para>x-axis value</para></remarks>
    /// <seealso href="http://purl.org/poso/xAxisValue">http://purl.org/poso/xAxisValue</seealso>
    let xAxisValue = Prefixed_Name(poso, "xAxisValue") |> PrefixedName
    /// <summary>
    ///   <para>poso:yAxisValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Quantitative result value along the Y-axis of a spatial sensor or result.</para>
    /// labels<para>y-axis value</para></remarks>
    /// <seealso href="http://purl.org/poso/yAxisValue">http://purl.org/poso/yAxisValue</seealso>
    let yAxisValue = Prefixed_Name(poso, "yAxisValue") |> PrefixedName
    /// <summary>
    ///   <para>poso:Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The orientation of a feature of interest in 2D or 3D space.</para>
    ///   <para>De orientatie van een object in 2D of 3D.</para>
    /// labels<para>Orientation</para><para>Orientatie</para></remarks>
    /// <seealso href="http://purl.org/poso/Orientation">http://purl.org/poso/Orientation</seealso>
    let Orientation = Prefixed_Name(poso, "Orientation") |> PrefixedName
    /// <summary>
    ///   <para>poso:CellIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cell identification is a positioning procedure using the position of one landmark that is within the cell.</para>
    /// labels<para>Cell identification</para></remarks>
    /// <seealso href="http://purl.org/poso/CellIdentification">http://purl.org/poso/CellIdentification</seealso>
    let CellIdentification = Prefixed_Name(poso, "CellIdentification") |> PrefixedName
    /// <summary>
    ///   <para>poso:DeadReckoning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dead reckoning is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.</para>
    /// labels<para>Dead reckoning</para></remarks>
    /// <seealso href="http://purl.org/poso/DeadReckoning">http://purl.org/poso/DeadReckoning</seealso>
    let DeadReckoning = Prefixed_Name(poso, "DeadReckoning") |> PrefixedName
    /// <summary>
    ///   <para>poso:PositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A positioning system is a system of instrumental and computational components for determining position.</para>
    /// labels<para>Positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/PositioningSystem">http://purl.org/poso/PositioningSystem</seealso>
    let PositioningSystem = Prefixed_Name(poso, "PositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:InertialPositioningSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inertial positioning system is a positioning system employing accelerometers, gyroscopes, and computer as integral components to determine coordinates of points or objects relative to an initial known reference point</para>
    /// labels<para>Inertial positioning system</para></remarks>
    /// <seealso href="http://purl.org/poso/InertialPositioningSystem">http://purl.org/poso/InertialPositioningSystem</seealso>
    let InertialPositioningSystem =
        Prefixed_Name(poso, "InertialPositioningSystem") |> PrefixedName

    /// <summary>
    ///   <para>poso:PDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pedestrian dead reckoning (PDR) is a positioning technique where the object is assumed to be a pedestrian that is walking or running. Using this knowledge, the dead reckoning involves the detection of steps and the step length to more accurately predict the movement.</para>
    /// labels<para>Pedestrian dead reckoning</para></remarks>
    /// <seealso href="http://purl.org/poso/PDR">http://purl.org/poso/PDR</seealso>
    let PDR = Prefixed_Name(poso, "PDR") |> PrefixedName
    /// <summary>
    ///   <para>poso:PolygonalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polygonal accuracy</para></remarks>
    /// <seealso href="http://purl.org/poso/PolygonalAccuracy">http://purl.org/poso/PolygonalAccuracy</seealso>
    let PolygonalAccuracy = Prefixed_Name(poso, "PolygonalAccuracy") |> PrefixedName

    /// <summary>
    ///   <para>poso:QuaternionOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Quaternion orientation</para></remarks>
    /// <seealso href="http://purl.org/poso/QuaternionOrientation">http://purl.org/poso/QuaternionOrientation</seealso>
    let QuaternionOrientation =
        Prefixed_Name(poso, "QuaternionOrientation") |> PrefixedName

    /// <summary>
    ///   <para>poso:scalar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>scalar</para></remarks>
    /// <seealso href="http://purl.org/poso/scalar">http://purl.org/poso/scalar</seealso>
    let scalar = Prefixed_Name(poso, "scalar") |> PrefixedName
    /// <summary>
    ///   <para>poso:isVelocityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is de snelheid van</para><para>is velocity of</para></remarks>
    /// <seealso href="http://purl.org/poso/isVelocityOf">http://purl.org/poso/isVelocityOf</seealso>
    let isVelocityOf = Prefixed_Name(poso, "isVelocityOf") |> PrefixedName
    /// <summary>
    ///   <para>poso:inDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>in deployment</para></remarks>
    /// <seealso href="http://purl.org/poso/inDeployment">http://purl.org/poso/inDeployment</seealso>
    let inDeployment = Prefixed_Name(poso, "inDeployment") |> PrefixedName

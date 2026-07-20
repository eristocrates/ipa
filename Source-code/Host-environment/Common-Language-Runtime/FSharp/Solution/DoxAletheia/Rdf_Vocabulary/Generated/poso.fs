namespace http.purl.org.poso.slash

open DoxAletheia

module poso =
    let _namespace_name = "http://purl.org/poso/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// An absolute position describes the position of an entity based on a fixed point in space. Usually this space is the Earth and the position is expressed in latitude and longitude.
    /// <see href="http://purl.org/poso/AbsolutePosition"></see></summary>
    let AbsolutePosition = _prefix "AbsolutePosition"
    /// <summary>
    /// A position indicates where an entity is located.
    /// <see href="http://purl.org/poso/Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// Acceleration is the (instantaneous) rate of change of velocity.
    /// <see href="http://purl.org/poso/Acceleration"></see></summary>
    let Acceleration = _prefix "Acceleration"
    /// <summary>
    ///   <see href="http://purl.org/poso/AngularAcceleration"></see>
    /// </summary>
    let AngularAcceleration = _prefix "AngularAcceleration"
    /// <summary>
    /// Angular movement around a certain origin point.
    /// <see href="http://purl.org/poso/AngularMovement"></see></summary>
    let AngularMovement = _prefix "AngularMovement"
    /// <summary>
    /// Movement stimulus triggering an update of a position.
    /// <see href="http://purl.org/poso/Movement"></see></summary>
    let Movement = _prefix "Movement"
    /// <summary>
    /// Angular velocity is the momentum around a point of origin.
    /// <see href="http://purl.org/poso/AngularVelocity"></see></summary>
    let AngularVelocity = _prefix "AngularVelocity"
    /// <summary>
    /// Linear or angular velocity of a feature.
    /// <see href="http://purl.org/poso/Velocity"></see></summary>
    let Velocity = _prefix "Velocity"
    /// <summary>
    /// Angulation is a triangulation method to determine a position based on the relative angles to other objects.
    /// <see href="http://purl.org/poso/Angulation"></see></summary>
    let Angulation = _prefix "Angulation"
    /// <summary>
    /// Triangulation is the procedure of determining a position using relative angles to a feature of interest with a known position.
    /// <see href="http://purl.org/poso/Triangulation"></see></summary>
    let Triangulation = _prefix "Triangulation"
    /// <summary>
    /// A spatial landmark that can be observed by sound.
    /// <see href="http://purl.org/poso/AuditoryLandmark"></see></summary>
    let AuditoryLandmark = _prefix "AuditoryLandmark"
    /// <summary>
    /// A landmark is a feature with a known position, that can be used to identify the position of an object that has a relative position with this feature.
    /// <see href="http://purl.org/poso/Landmark"></see></summary>
    let Landmark = _prefix "Landmark"
    /// <summary>
    /// The axis-angle orientation is an orientation representation where the x, y and z values are rotated with a certain angle.
    /// <see href="http://purl.org/poso/AxisAngleOrientation"></see></summary>
    let AxisAngleOrientation = _prefix "AxisAngleOrientation"
    /// <summary>
    /// Quantitative anglue result value for axis-angle representation.
    /// <see href="http://purl.org/poso/angle"></see></summary>
    let angle = _prefix "angle"
    /// <summary>
    /// Quantitative result value along the X-axis of a spatial sensor or result.
    /// <see href="http://purl.org/poso/xAxisValue"></see></summary>
    let xAxisValue = _prefix "xAxisValue"
    /// <summary>
    /// Quantitative result value along the Y-axis of a spatial sensor or result.
    /// <see href="http://purl.org/poso/yAxisValue"></see></summary>
    let yAxisValue = _prefix "yAxisValue"
    /// <summary>
    /// Quantitative result value along the Z-axis of a spatial sensor.
    /// <see href="http://purl.org/poso/zAxisValue"></see></summary>
    let zAxisValue = _prefix "zAxisValue"
    /// <summary>
    /// The orientation of a feature of interest in 2D or 3D space.
    /// <see href="http://purl.org/poso/Orientation"></see></summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    /// Cell identification is a positioning procedure using the position of one landmark that is within the cell.
    /// <see href="http://purl.org/poso/CellIdentification"></see></summary>
    let CellIdentification = _prefix "CellIdentification"
    /// <summary>
    /// A positioning technique is a procedure to sample sensor data to an output position.
    /// <see href="http://purl.org/poso/PositioningTechnique"></see></summary>
    let PositioningTechnique = _prefix "PositioningTechnique"
    /// <summary>
    /// Dead reckoning is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.
    /// <see href="http://purl.org/poso/DeadReckoning"></see></summary>
    let DeadReckoning = _prefix "DeadReckoning"
    /// <summary>
    ///   <see href="http://purl.org/poso/EulerOrientation"></see>
    /// </summary>
    let EulerOrientation = _prefix "EulerOrientation"
    /// <summary>
    /// Pitch is the rotation around the x-axis with respect to the object the yaw applies to.
    /// <see href="http://purl.org/poso/pitch"></see></summary>
    let pitch = _prefix "pitch"
    /// <summary>
    /// Roll is the rotation around the y-axis with respect to the object the roll applies to.
    /// <see href="http://purl.org/poso/roll"></see></summary>
    let roll = _prefix "roll"
    /// <summary>
    /// Yaw is the rotation around the z-axis with respect to the object the yaw applies to.
    /// <see href="http://purl.org/poso/yaw"></see></summary>
    let yaw = _prefix "yaw"
    /// <summary>
    /// A fingerprint is a scene analysis at a particular absolute position.
    /// <see href="http://purl.org/poso/Fingerprint"></see></summary>
    let Fingerprint = _prefix "Fingerprint"
    /// <summary>
    /// Indicates the absolute or relative position of a feature of interest.
    /// <see href="http://purl.org/poso/hasPosition"></see></summary>
    let hasPosition = _prefix "hasPosition"
    /// <summary>
    /// Fingerprinting is a positioning Procedure where sensor data is collected at a specific position and orientation. During the offline-stage of a positioning system, the significant data features are extracted and stored for that position. In the online-stage, the closest match(es) of the features are determined to predict the position.
    /// <see href="http://purl.org/poso/Fingerprinting"></see></summary>
    let Fingerprinting = _prefix "Fingerprinting"
    /// <summary>
    /// High level sensor fusion is about fusing both objects and their trajectories. We're not only relying on detections, but also on predictions and tracking.
    /// <see href="http://purl.org/poso/HighLevelFusion"></see></summary>
    let HighLevelFusion = _prefix "HighLevelFusion"
    /// <summary>
    /// Sensor fusion is a procedure where multiple sensor data is combined to obtain a more reliable or accurate result.
    /// <see href="http://purl.org/poso/SensorFusion"></see></summary>
    let SensorFusion = _prefix "SensorFusion"
    /// <summary>
    /// Describes the spatial deployment of a System in an indoor environment.
    /// <see href="http://purl.org/poso/IndoorDeployment"></see></summary>
    let IndoorDeployment = _prefix "IndoorDeployment"
    /// <summary>
    /// A positioning system that is meant to perform indoor positioning of a feature of interest.
    /// <see href="http://purl.org/poso/IndoorPositioningSystem"></see></summary>
    let IndoorPositioningSystem = _prefix "IndoorPositioningSystem"
    /// <summary>
    /// A positioning system is a system of instrumental and computational components for determining position.
    /// <see href="http://purl.org/poso/PositioningSystem"></see></summary>
    let PositioningSystem = _prefix "PositioningSystem"
    /// <summary>
    /// An inertial positioning system is a positioning system employing accelerometers, gyroscopes, and computer as integral components to determine coordinates of points or objects relative to an initial known reference point
    /// <see href="http://purl.org/poso/InertialPositioningSystem"></see></summary>
    let InertialPositioningSystem = _prefix "InertialPositioningSystem"
    /// <summary>
    /// An integrated positioning system is a positioning system that incorporates multiple positioning technologies.
    /// <see href="http://purl.org/poso/IntegratedPositioningSystem"></see></summary>
    let IntegratedPositioningSystem = _prefix "IntegratedPositioningSystem"
    /// <summary>
    ///   <see href="http://purl.org/poso/Lateration"></see>
    /// </summary>
    let Lateration = _prefix "Lateration"
    /// <summary>
    ///   <see href="http://purl.org/poso/LinearAcceleration"></see>
    /// </summary>
    let LinearAcceleration = _prefix "LinearAcceleration"
    /// <summary>
    /// Linear movement along a certain axis.
    /// <see href="http://purl.org/poso/LinearMovement"></see></summary>
    let LinearMovement = _prefix "LinearMovement"
    /// <summary>
    /// Linear velocity is the momentum along one ore more axis.
    /// <see href="http://purl.org/poso/LinearVelocity"></see></summary>
    let LinearVelocity = _prefix "LinearVelocity"
    /// <summary>
    /// A location based service (LBS) is a service that provides the location of a person or object. It provides this information without the required knowledge of the underlying technologies and algorithms.
    /// <see href="http://purl.org/poso/LocationBasedService"></see></summary>
    let LocationBasedService = _prefix "LocationBasedService"
    /// <summary>
    /// Low Level Sensor Fusion is about fusing the raw data coming from multiple sensors. For example, we fuse point clouds coming from LiDARs and pixels coming from cameras.
    /// <see href="http://purl.org/poso/LowLevelFusion"></see></summary>
    let LowLevelFusion = _prefix "LowLevelFusion"
    /// <summary>
    /// Magnetic field odometry is the procedure of detecting movement by analyizing how the magnetic field is changing from one Observation to another.
    /// <see href="http://purl.org/poso/MagneticOdometry"></see></summary>
    let MagneticOdometry = _prefix "MagneticOdometry"
    /// <summary>
    /// Odometry is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.
    /// <see href="http://purl.org/poso/Odometry"></see></summary>
    let Odometry = _prefix "Odometry"
    /// <summary>
    ///   <see href="http://purl.org/poso/MapOutput"></see>
    /// </summary>
    let MapOutput = _prefix "MapOutput"
    /// <summary>
    /// Mid-Level sensor fusion is about fusing the objects detected independently on sensor data.
    /// <see href="http://purl.org/poso/MidLevelFusion"></see></summary>
    let MidLevelFusion = _prefix "MidLevelFusion"
    /// <summary>
    /// Multilateration is the procedure of determining a position using relative distances to other known positions.
    /// <see href="http://purl.org/poso/Multilateration"></see></summary>
    let Multilateration = _prefix "Multilateration"
    /// <summary>
    /// An optical positioning system is a positioning system that determines the position of an object by means of the properties of light.
    /// <see href="http://purl.org/poso/OpticalPositioningSystem"></see></summary>
    let OpticalPositioningSystem = _prefix "OpticalPositioningSystem"
    /// <summary>
    /// Describes the deployment of a System in an outdoor environment.
    /// <see href="http://purl.org/poso/OutdoorDeployment"></see></summary>
    let OutdoorDeployment = _prefix "OutdoorDeployment"
    /// <summary>
    /// Pedestrian dead reckoning (PDR) is a positioning technique where the object is assumed to be a pedestrian that is walking or running. Using this knowledge, the dead reckoning involves the detection of steps and the step length to more accurately predict the movement.
    /// <see href="http://purl.org/poso/PDR"></see></summary>
    let PDR = _prefix "PDR"
    /// <summary>
    ///   <see href="http://purl.org/poso/PolygonalAccuracy"></see>
    /// </summary>
    let PolygonalAccuracy = _prefix "PolygonalAccuracy"
    /// <summary>
    ///   <see href="http://purl.org/poso/PositionOutput"></see>
    /// </summary>
    let PositionOutput = _prefix "PositionOutput"
    /// <summary>
    /// A positioning platform is a framework, architecture or platform used to develop and host a positioning system.
    /// <see href="http://purl.org/poso/PositioningPlatform"></see></summary>
    let PositioningPlatform = _prefix "PositioningPlatform"
    /// <summary>
    ///   <see href="http://purl.org/poso/QuaternionOrientation"></see>
    /// </summary>
    let QuaternionOrientation = _prefix "QuaternionOrientation"
    /// <summary>
    ///   <see href="http://purl.org/poso/scalar"></see>
    /// </summary>
    let scalar = _prefix "scalar"
    /// <summary>
    /// A radio frequency landmark is a transmitting landmark that can be observed by its transmitting signals.
    /// <see href="http://purl.org/poso/RFLandmark"></see></summary>
    let RFLandmark = _prefix "RFLandmark"
    /// <summary>
    /// The radio propagation formulas cover the computation of the radio waves through a medium (e.g. air).
    /// <see href="http://purl.org/poso/RadioPropagation"></see></summary>
    let RadioPropagation = _prefix "RadioPropagation"
    /// <summary>
    /// A relative angle is a quantitative angle relative to another feature of interest.
    /// <see href="http://purl.org/poso/RelativeAngle"></see></summary>
    let RelativeAngle = _prefix "RelativeAngle"
    /// <summary>
    /// A relative position is a position of a feature of interest with respect to the positions of other objects that this position is relative to.
    /// <see href="http://purl.org/poso/RelativePosition"></see></summary>
    let RelativePosition = _prefix "RelativePosition"
    /// <summary>
    /// A relative distance is a quantitative distance relative to another feature of interest.
    /// <see href="http://purl.org/poso/RelativeDistance"></see></summary>
    let RelativeDistance = _prefix "RelativeDistance"
    /// <summary>
    /// Indicates a relative position to be relative to another feature of interest.
    /// <see href="http://purl.org/poso/isRelativeTo"></see></summary>
    let isRelativeTo = _prefix "isRelativeTo"
    /// <summary>
    /// A relative velocity is a quantitative velocity relative to another feature of interest.
    /// <see href="http://purl.org/poso/RelativeVelocity"></see></summary>
    let RelativeVelocity = _prefix "RelativeVelocity"
    /// <summary>
    /// Simultaneous localization and mapping (SLAM) is the computational problem of constructing or updating a map of an unknown environment while simultaneously keeping track of an agent's location within it.
    /// <see href="http://purl.org/poso/SLAM"></see></summary>
    let SLAM = _prefix "SLAM"
    /// <summary>
    /// An identifiable and observable spatial reference system that represents the System's ability to operate its primary purpose in a specified reference system.
    /// <see href="http://purl.org/poso/SRS"></see></summary>
    let SRS = _prefix "SRS"
    /// <summary>
    /// In this context, satellite positioning implies the use of radio signals transmitted from "active" artificial objects orbiting the Earth and received by "passive" instruments on or near the Earth's surface to determine position, velocity, and/or attitude of an object.
    /// <see href="http://purl.org/poso/SatellitePositioningSystem"></see></summary>
    let SatellitePositioningSystem = _prefix "SatellitePositioningSystem"
    /// <summary>
    /// A feature of interest that is being tracked by a positioning system. This is the feature for which a position is observed.
    /// <see href="http://purl.org/poso/TrackedFeature"></see></summary>
    let TrackedFeature = _prefix "TrackedFeature"
    /// <summary>
    /// Visual simultaneous localisation and mapping (VSLAM) is a positioning techniques that uses visual imagery to map an environment. Positioning works by detecting features of interest in image frames and comparing how these features move from one frame to another.
    /// <see href="http://purl.org/poso/VSLAM"></see></summary>
    let VSLAM = _prefix "VSLAM"
    /// <summary>
    ///   <see href="http://purl.org/poso/VisualInput"></see>
    /// </summary>
    let VisualInput = _prefix "VisualInput"
    /// <summary>
    /// A visual landmark is a feature of interest that visually present in the space.
    /// <see href="http://purl.org/poso/VisualLandmark"></see></summary>
    let VisualLandmark = _prefix "VisualLandmark"
    /// <summary>
    /// Visual odometry is the procedure of detecting movement by analyzing how visual features are moving from one Observation image frame to another.
    /// <see href="http://purl.org/poso/VisualOdometry"></see></summary>
    let VisualOdometry = _prefix "VisualOdometry"
    /// <summary>
    /// Property that links a feature of interest to a unique acceleration property related to this feature.
    /// <see href="http://purl.org/poso/hasAcceleration"></see></summary>
    let hasAcceleration = _prefix "hasAcceleration"
    /// <summary>
    ///   <see href="http://purl.org/poso/isAccelerationOf"></see>
    /// </summary>
    let isAccelerationOf = _prefix "isAccelerationOf"
    /// <summary>
    /// The accuracy of an entity.
    /// <see href="http://purl.org/poso/hasAccuracy"></see></summary>
    let hasAccuracy = _prefix "hasAccuracy"
    /// <summary>
    ///   <see href="http://purl.org/poso/hasCRS"></see>
    /// </summary>
    let hasCRS = _prefix "hasCRS"
    /// <summary>
    /// Identifies an entity that has a spatial reference system in order to interpret the result.
    /// <see href="http://purl.org/poso/hasSRS"></see></summary>
    let hasSRS = _prefix "hasSRS"
    /// <summary>
    /// Indicates the orientation of a feature of interest.
    /// <see href="http://purl.org/poso/hasOrientation"></see></summary>
    let hasOrientation = _prefix "hasOrientation"
    /// <summary>
    ///   <see href="http://purl.org/poso/isOrientationOf"></see>
    /// </summary>
    let isOrientationOf = _prefix "isOrientationOf"
    /// <summary>
    ///   <see href="http://purl.org/poso/isPositionOf"></see>
    /// </summary>
    let isPositionOf = _prefix "isPositionOf"
    /// <summary>
    ///   <see href="http://purl.org/poso/hasRelativePosition"></see>
    /// </summary>
    let hasRelativePosition = _prefix "hasRelativePosition"
    /// <summary>
    /// Indicates the velocity of a feature of interest.
    /// <see href="http://purl.org/poso/hasVelocity"></see></summary>
    let hasVelocity = _prefix "hasVelocity"
    /// <summary>
    ///   <see href="http://purl.org/poso/isVelocityOf"></see>
    /// </summary>
    let isVelocityOf = _prefix "isVelocityOf"
    /// <summary>
    ///   <see href="http://purl.org/poso/inDeployment"></see>
    /// </summary>
    let inDeployment = _prefix "inDeployment"
    /// <summary>
    /// A relation to a re-usable system that computed the observation.
    /// <see href="http://purl.org/poso/madeBySystem"></see></summary>
    let madeBySystem = _prefix "madeBySystem"
    /// <summary>
    /// The relation between a system and an observable property class to identify that a system observes a specific type of property.
    /// <see href="http://purl.org/poso/observesType"></see></summary>
    let observesType = _prefix "observesType"

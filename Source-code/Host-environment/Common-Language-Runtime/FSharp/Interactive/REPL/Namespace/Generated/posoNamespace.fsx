#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module poso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/poso/" "poso"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Absolute position</para>
    ///   <para>rdfs:comment : An absolute position describes the position of an entity based on a fixed point in space. Usually this space is the Earth and the position is expressed in latitude and longitude.</para>
    ///   <a href="http://purl.org/poso/AbsolutePosition">poso:AbsolutePosition</a>
    /// </summary>
    let AbsolutePosition = _prefixId.prefix "AbsolutePosition"
    /// <summary>
    ///   <para>rdfs:label : Accelerationrdfs:label : Versnelling</para>
    ///   <para>rdfs:comment : Acceleration is the (instantaneous) rate of change of velocity.</para>
    ///   <a href="http://purl.org/poso/Acceleration">poso:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>rdfs:label : Angular accelerationrdfs:label : Draaiversnelling</para>
    ///   <a href="http://purl.org/poso/AngularAcceleration">poso:AngularAcceleration</a>
    /// </summary>
    let AngularAcceleration = _prefixId.prefix "AngularAcceleration"
    /// <summary>
    ///   <para>rdfs:label : Angular movementrdfs:label : Draaibeweging</para>
    ///   <para>rdfs:comment : Angular movement around a certain origin point.</para>
    ///   <a href="http://purl.org/poso/AngularMovement">poso:AngularMovement</a>
    /// </summary>
    let AngularMovement = _prefixId.prefix "AngularMovement"
    /// <summary>
    ///   <para>rdfs:label : Angular velocityrdfs:label : Draaisnelheid</para>
    ///   <para>rdfs:comment : Angular velocity is the momentum around a point of origin.</para>
    ///   <a href="http://purl.org/poso/AngularVelocity">poso:AngularVelocity</a>
    /// </summary>
    let AngularVelocity = _prefixId.prefix "AngularVelocity"
    /// <summary>
    ///   <para>rdfs:label : Angulation</para>
    ///   <para>rdfs:comment : Angulation is a triangulation method to determine a position based on the relative angles to other objects.</para>
    ///   <a href="http://purl.org/poso/Angulation">poso:Angulation</a>
    /// </summary>
    let Angulation = _prefixId.prefix "Angulation"
    /// <summary>
    ///   <para>rdfs:label : Auditory landmark</para>
    ///   <para>rdfs:comment : A spatial landmark that can be observed by sound.</para>
    ///   <a href="http://purl.org/poso/AuditoryLandmark">poso:AuditoryLandmark</a>
    /// </summary>
    let AuditoryLandmark = _prefixId.prefix "AuditoryLandmark"
    /// <summary>
    ///   <para>rdfs:label : Axis-angle orientation</para>
    ///   <para>rdfs:comment : The axis-angle orientation is an orientation representation where the x, y and z values are rotated with a certain angle.</para>
    ///   <a href="http://purl.org/poso/AxisAngleOrientation">poso:AxisAngleOrientation</a>
    /// </summary>
    let AxisAngleOrientation = _prefixId.prefix "AxisAngleOrientation"
    /// <summary>
    ///   <para>skos:example : An example of cell identification is using the position of a Bluetooth beacon whenever this beacon has a high signal strength.skos:example : An example of cell identification is using the position of a QR-code when this code is scanned (and the user is presumably within a short distance).</para>
    ///   <para>skos:altLabel : Cell Of Origin (COO)</para>
    ///   <para>rdfs:label : Cell identification</para>
    ///   <para>rdfs:comment : Cell identification is a positioning procedure using the position of one landmark that is within the cell.</para>
    ///   <a href="http://purl.org/poso/CellIdentification">poso:CellIdentification</a>
    /// </summary>
    let CellIdentification = _prefixId.prefix "CellIdentification"
    /// <summary>
    ///   <para>skos:altLabel : Deduced reckoning</para>
    ///   <para>rdfs:label : Dead reckoning</para>
    ///   <para>rdfs:comment : Dead reckoning is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.</para>
    ///   <a href="http://purl.org/poso/DeadReckoning">poso:DeadReckoning</a>
    /// </summary>
    let DeadReckoning = _prefixId.prefix "DeadReckoning"
    /// <summary>
    ///   <para>rdfs:label : Euler orientation</para>
    ///   <a href="http://purl.org/poso/EulerOrientation">poso:EulerOrientation</a>
    /// </summary>
    let EulerOrientation = _prefixId.prefix "EulerOrientation"
    /// <summary>
    ///   <para>rdfs:label : Fingerprint</para>
    ///   <para>rdfs:comment : A fingerprint is a scene analysis at a particular absolute position.</para>
    ///   <a href="http://purl.org/poso/Fingerprint">poso:Fingerprint</a>
    /// </summary>
    let Fingerprint = _prefixId.prefix "Fingerprint"
    /// <summary>
    ///   <para>rdfs:label : Fingerprinting</para>
    ///   <para>rdfs:comment : Fingerprinting is a positioning Procedure where sensor data is collected at a specific position and orientation. During the offline-stage of a positioning system, the significant data features are extracted and stored for that position. In the online-stage, the closest match(es) of the features are determined to predict the position.</para>
    ///   <a href="http://purl.org/poso/Fingerprinting">poso:Fingerprinting</a>
    /// </summary>
    let Fingerprinting = _prefixId.prefix "Fingerprinting"
    /// <summary>
    ///   <para>skos:altLabel : Decision level sensor fusion</para>
    ///   <para>rdfs:label : High level sensor fusion</para>
    ///   <para>rdfs:isDefinedBy : https://www.thinkautonomous.ai/blog/?p=9-types-of-sensor-fusion-algorithms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : High level sensor fusion is about fusing both objects and their trajectories. We're not only relying on detections, but also on predictions and tracking.</para>
    ///   <a href="http://purl.org/poso/HighLevelFusion">poso:HighLevelFusion</a>
    /// </summary>
    let HighLevelFusion = _prefixId.prefix "HighLevelFusion"
    /// <summary>
    ///   <para>rdfs:label : Indoor deployment</para>
    ///   <para>rdfs:comment : Describes the spatial deployment of a System in an indoor environment.</para>
    ///   <a href="http://purl.org/poso/IndoorDeployment">poso:IndoorDeployment</a>
    /// </summary>
    let IndoorDeployment = _prefixId.prefix "IndoorDeployment"
    /// <summary>
    ///   <para>rdfs:label : Indoor positioning system</para>
    ///   <para>rdfs:comment : A positioning system that is meant to perform indoor positioning of a feature of interest.</para>
    ///   <a href="http://purl.org/poso/IndoorPositioningSystem">poso:IndoorPositioningSystem</a>
    /// </summary>
    let IndoorPositioningSystem = _prefixId.prefix "IndoorPositioningSystem"
    /// <summary>
    ///   <para>rdfs:label : Inertial positioning system</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/240/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An inertial positioning system is a positioning system employing accelerometers, gyroscopes, and computer as integral components to determine coordinates of points or objects relative to an initial known reference point</para>
    ///   <a href="http://purl.org/poso/InertialPositioningSystem">poso:InertialPositioningSystem</a>
    /// </summary>
    let InertialPositioningSystem = _prefixId.prefix "InertialPositioningSystem"
    /// <summary>
    ///   <para>skos:altLabel : Hybrid positioning system</para>
    ///   <para>rdfs:label : Integrated positioning system</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/250/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An integrated positioning system is a positioning system that incorporates multiple positioning technologies.</para>
    ///   <a href="http://purl.org/poso/IntegratedPositioningSystem">poso:IntegratedPositioningSystem</a>
    /// </summary>
    let IntegratedPositioningSystem = _prefixId.prefix "IntegratedPositioningSystem"
    /// <summary>
    ///   <para>rdfs:label : Landmark</para>
    ///   <para>rdfs:comment : A landmark is a feature with a known position, that can be used to identify the position of an object that has a relative position with this feature.</para>
    ///   <a href="http://purl.org/poso/Landmark">poso:Landmark</a>
    /// </summary>
    let Landmark = _prefixId.prefix "Landmark"
    /// <summary>
    ///   <para>rdfs:label : Lateration</para>
    ///   <para>rdfs:isDefinedBy : https://www.sciencedirect.com/topics/engineering/lateration^^xsd:anyURI</para>
    ///   <a href="http://purl.org/poso/Lateration">poso:Lateration</a>
    /// </summary>
    let Lateration = _prefixId.prefix "Lateration"
    /// <summary>
    ///   <para>rdfs:label : Linear acceleration</para>
    ///   <a href="http://purl.org/poso/LinearAcceleration">poso:LinearAcceleration</a>
    /// </summary>
    let LinearAcceleration = _prefixId.prefix "LinearAcceleration"
    /// <summary>
    ///   <para>rdfs:label : Lineaire bewegingrdfs:label : Linear movement</para>
    ///   <para>rdfs:comment : Linear movement along a certain axis.</para>
    ///   <a href="http://purl.org/poso/LinearMovement">poso:LinearMovement</a>
    /// </summary>
    let LinearMovement = _prefixId.prefix "LinearMovement"
    /// <summary>
    ///   <para>rdfs:label : Lineaire snelheidrdfs:label : Linear velocity</para>
    ///   <para>rdfs:comment : Linear velocity is the momentum along one ore more axis.</para>
    ///   <a href="http://purl.org/poso/LinearVelocity">poso:LinearVelocity</a>
    /// </summary>
    let LinearVelocity = _prefixId.prefix "LinearVelocity"
    /// <summary>
    ///   <para>rdfs:label : Location based service</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/278/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A location based service (LBS) is a service that provides the location of a person or object. It provides this information without the required knowledge of the underlying technologies and algorithms.</para>
    ///   <a href="http://purl.org/poso/LocationBasedService">poso:LocationBasedService</a>
    /// </summary>
    let LocationBasedService = _prefixId.prefix "LocationBasedService"
    /// <summary>
    ///   <para>rdfs:label : Low level sensor fusion</para>
    ///   <para>rdfs:isDefinedBy : https://www.thinkautonomous.ai/blog/?p=9-types-of-sensor-fusion-algorithms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Low Level Sensor Fusion is about fusing the raw data coming from multiple sensors. For example, we fuse point clouds coming from LiDARs and pixels coming from cameras.</para>
    ///   <a href="http://purl.org/poso/LowLevelFusion">poso:LowLevelFusion</a>
    /// </summary>
    let LowLevelFusion = _prefixId.prefix "LowLevelFusion"
    /// <summary>
    ///   <para>rdfs:label : Magnetic odometry</para>
    ///   <para>rdfs:comment : Magnetic field odometry is the procedure of detecting movement by analyizing how the magnetic field is changing from one Observation to another.</para>
    ///   <a href="http://purl.org/poso/MagneticOdometry">poso:MagneticOdometry</a>
    /// </summary>
    let MagneticOdometry = _prefixId.prefix "MagneticOdometry"
    /// <summary>
    ///   <para>rdfs:label : Map output</para>
    ///   <a href="http://purl.org/poso/MapOutput">poso:MapOutput</a>
    /// </summary>
    let MapOutput = _prefixId.prefix "MapOutput"
    /// <summary>
    ///   <para>rdfs:label : Mid level sensor fusion</para>
    ///   <para>rdfs:isDefinedBy : https://www.thinkautonomous.ai/blog/?p=9-types-of-sensor-fusion-algorithms^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Mid-Level sensor fusion is about fusing the objects detected independently on sensor data.</para>
    ///   <a href="http://purl.org/poso/MidLevelFusion">poso:MidLevelFusion</a>
    /// </summary>
    let MidLevelFusion = _prefixId.prefix "MidLevelFusion"
    /// <summary>
    ///   <para>rdfs:label : Bewegingrdfs:label : Movement</para>
    ///   <para>rdfs:comment : Movement stimulus triggering an update of a position.</para>
    ///   <a href="http://purl.org/poso/Movement">poso:Movement</a>
    /// </summary>
    let Movement = _prefixId.prefix "Movement"
    /// <summary>
    ///   <para>skos:altLabel : Hyperbolic positioningskos:altLabel : Trilateration</para>
    ///   <para>rdfs:label : Multilateration</para>
    ///   <para>rdfs:comment : Multilateration is the procedure of determining a position using relative distances to other known positions.</para>
    ///   <a href="http://purl.org/poso/Multilateration">poso:Multilateration</a>
    /// </summary>
    let Multilateration = _prefixId.prefix "Multilateration"
    /// <summary>
    ///   <para>rdfs:label : Odometry</para>
    ///   <para>rdfs:comment : Odometry is the Procedure of calculating the current position of a moving FeatureOfInterest by using its previous position and Sensor Observation's indicating its heading and velocity.</para>
    ///   <a href="http://purl.org/poso/Odometry">poso:Odometry</a>
    /// </summary>
    let Odometry = _prefixId.prefix "Odometry"
    /// <summary>
    ///   <para>rdfs:label : Optical positioning system</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/320/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : An optical positioning system is a positioning system that determines the position of an object by means of the properties of light.</para>
    ///   <a href="http://purl.org/poso/OpticalPositioningSystem">poso:OpticalPositioningSystem</a>
    /// </summary>
    let OpticalPositioningSystem = _prefixId.prefix "OpticalPositioningSystem"
    /// <summary>
    ///   <para>rdfs:label : Orientatierdfs:label : Orientation</para>
    ///   <para>rdfs:comment : De orientatie van een object in 2D of 3D.rdfs:comment : The orientation of a feature of interest in 2D or 3D space.</para>
    ///   <a href="http://purl.org/poso/Orientation">poso:Orientation</a>
    /// </summary>
    let Orientation = _prefixId.prefix "Orientation"
    /// <summary>
    ///   <para>rdfs:label : Outdoor deployment</para>
    ///   <para>rdfs:comment : Describes the deployment of a System in an outdoor environment.</para>
    ///   <a href="http://purl.org/poso/OutdoorDeployment">poso:OutdoorDeployment</a>
    /// </summary>
    let OutdoorDeployment = _prefixId.prefix "OutdoorDeployment"
    /// <summary>
    ///   <para>rdfs:label : Pedestrian dead reckoning</para>
    ///   <para>rdfs:comment : Pedestrian dead reckoning (PDR) is a positioning technique where the object is assumed to be a pedestrian that is walking or running. Using this knowledge, the dead reckoning involves the detection of steps and the step length to more accurately predict the movement.</para>
    ///   <a href="http://purl.org/poso/PDR">poso:PDR</a>
    /// </summary>
    let PDR = _prefixId.prefix "PDR"
    /// <summary>
    ///   <para>rdfs:label : Polygonal accuracy</para>
    ///   <a href="http://purl.org/poso/PolygonalAccuracy">poso:PolygonalAccuracy</a>
    /// </summary>
    let PolygonalAccuracy = _prefixId.prefix "PolygonalAccuracy"
    /// <summary>
    ///   <para>rdfs:label : Positierdfs:label : Position</para>
    ///   <para>rdfs:comment : A position indicates where an entity is located.</para>
    ///   <a href="http://purl.org/poso/Position">poso:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : Position output</para>
    ///   <a href="http://purl.org/poso/PositionOutput">poso:PositionOutput</a>
    /// </summary>
    let PositionOutput = _prefixId.prefix "PositionOutput"
    /// <summary>
    ///   <para>rdfs:label : Positioning platform</para>
    ///   <para>rdfs:comment : A positioning platform is a framework, architecture or platform used to develop and host a positioning system.</para>
    ///   <a href="http://purl.org/poso/PositioningPlatform">poso:PositioningPlatform</a>
    /// </summary>
    let PositioningPlatform = _prefixId.prefix "PositioningPlatform"
    /// <summary>
    ///   <para>rdfs:label : Positioning system</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/349/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A positioning system is a system of instrumental and computational components for determining position.</para>
    ///   <a href="http://purl.org/poso/PositioningSystem">poso:PositioningSystem</a>
    /// </summary>
    let PositioningSystem = _prefixId.prefix "PositioningSystem"
    /// <summary>
    ///   <para>rdfs:label : Positioning technique</para>
    ///   <para>rdfs:comment : A positioning technique is a procedure to sample sensor data to an output position.</para>
    ///   <a href="http://purl.org/poso/PositioningTechnique">poso:PositioningTechnique</a>
    /// </summary>
    let PositioningTechnique = _prefixId.prefix "PositioningTechnique"
    /// <summary>
    ///   <para>rdfs:label : Quaternion orientation</para>
    ///   <a href="http://purl.org/poso/QuaternionOrientation">poso:QuaternionOrientation</a>
    /// </summary>
    let QuaternionOrientation = _prefixId.prefix "QuaternionOrientation"
    /// <summary>
    ///   <para>skos:example : An RF landmark example is a Bluetooth beacon that sends out a signal. Receivers of this signal can use the known position of this landmark to determine their relative position.</para>
    ///   <para>rdfs:label : RF landmark</para>
    ///   <para>rdfs:comment : A radio frequency landmark is a transmitting landmark that can be observed by its transmitting signals.</para>
    ///   <a href="http://purl.org/poso/RFLandmark">poso:RFLandmark</a>
    /// </summary>
    let RFLandmark = _prefixId.prefix "RFLandmark"
    /// <summary>
    ///   <para>rdfs:label : Radio propagation</para>
    ///   <para>rdfs:isDefinedBy : https://en.wikipedia.org/wiki/Radio_propagation^^xsd:anyURI</para>
    ///   <para>rdfs:comment : The radio propagation formulas cover the computation of the radio waves through a medium (e.g. air).</para>
    ///   <a href="http://purl.org/poso/RadioPropagation">poso:RadioPropagation</a>
    /// </summary>
    let RadioPropagation = _prefixId.prefix "RadioPropagation"
    /// <summary>
    ///   <para>skos:example : An example of relative angle is the Angle of Arrival.</para>
    ///   <para>rdfs:label : Relatieve hoekrdfs:label : Relative angle</para>
    ///   <para>rdfs:comment : A relative angle is a quantitative angle relative to another feature of interest.</para>
    ///   <a href="http://purl.org/poso/RelativeAngle">poso:RelativeAngle</a>
    /// </summary>
    let RelativeAngle = _prefixId.prefix "RelativeAngle"
    /// <summary>
    ///   <para>rdfs:label : Relatieve afstandrdfs:label : Relative distance</para>
    ///   <para>rdfs:comment : A relative distance is a quantitative distance relative to another feature of interest.</para>
    ///   <a href="http://purl.org/poso/RelativeDistance">poso:RelativeDistance</a>
    /// </summary>
    let RelativeDistance = _prefixId.prefix "RelativeDistance"
    /// <summary>
    ///   <para>rdfs:label : Relatieve positierdfs:label : Relative position</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/377/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : A relative position is a position of a feature of interest with respect to the positions of other objects that this position is relative to.rdfs:comment : Een relatieve positie is een positie van een punt, met respect tot de posities van andere objecten die relatief zijn.</para>
    ///   <a href="http://purl.org/poso/RelativePosition">poso:RelativePosition</a>
    /// </summary>
    let RelativePosition = _prefixId.prefix "RelativePosition"
    /// <summary>
    ///   <para>rdfs:label : Relatieve snelheidrdfs:label : Relative velocity</para>
    ///   <para>rdfs:comment : A relative velocity is a quantitative velocity relative to another feature of interest.</para>
    ///   <a href="http://purl.org/poso/RelativeVelocity">poso:RelativeVelocity</a>
    /// </summary>
    let RelativeVelocity = _prefixId.prefix "RelativeVelocity"
    /// <summary>
    ///   <para>rdfs:label : Simultaneous localisation and mapping</para>
    ///   <para>rdfs:isDefinedBy : https://dbpedia.org/page/Simultaneous_localization_and_mapping^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Simultaneous localization and mapping (SLAM) is the computational problem of constructing or updating a map of an unknown environment while simultaneously keeping track of an agent's location within it.</para>
    ///   <a href="http://purl.org/poso/SLAM">poso:SLAM</a>
    /// </summary>
    let SLAM = _prefixId.prefix "SLAM"
    /// <summary>
    ///   <para>rdfs:label : Spatial Reference System</para>
    ///   <para>rdfs:comment : An identifiable and observable spatial reference system that represents the System's ability to operate its primary purpose in a specified reference system.</para>
    ///   <a href="http://purl.org/poso/SRS">poso:SRS</a>
    /// </summary>
    let SRS = _prefixId.prefix "SRS"
    /// <summary>
    ///   <para>rdfs:label : Satellite positioning system</para>
    ///   <para>rdfs:isDefinedBy : https://isotc211.geolexica.org/concepts/392/^^xsd:anyURI</para>
    ///   <para>rdfs:comment : In this context, satellite positioning implies the use of radio signals transmitted from "active" artificial objects orbiting the Earth and received by "passive" instruments on or near the Earth's surface to determine position, velocity, and/or attitude of an object.</para>
    ///   <a href="http://purl.org/poso/SatellitePositioningSystem">poso:SatellitePositioningSystem</a>
    /// </summary>
    let SatellitePositioningSystem = _prefixId.prefix "SatellitePositioningSystem"
    /// <summary>
    ///   <para>rdfs:label : Sensor fusion</para>
    ///   <para>rdfs:isDefinedBy : https://en.wikipedia.org/wiki/Sensor_fusion^^xsd:anyURI</para>
    ///   <para>rdfs:comment : Sensor fusion is a procedure where multiple sensor data is combined to obtain a more reliable or accurate result.</para>
    ///   <a href="http://purl.org/poso/SensorFusion">poso:SensorFusion</a>
    /// </summary>
    let SensorFusion = _prefixId.prefix "SensorFusion"
    /// <summary>
    ///   <para>skos:example : The phone of a person that is being tracked in an indoor positioning system is the tracked feature.</para>
    ///   <para>rdfs:label : Tracked feature</para>
    ///   <para>rdfs:comment : A feature of interest that is being tracked by a positioning system. This is the feature for which a position is observed.</para>
    ///   <a href="http://purl.org/poso/TrackedFeature">poso:TrackedFeature</a>
    /// </summary>
    let TrackedFeature = _prefixId.prefix "TrackedFeature"
    /// <summary>
    ///   <para>rdfs:label : Triangulation</para>
    ///   <para>rdfs:comment : Triangulation is the procedure of determining a position using relative angles to a feature of interest with a known position.</para>
    ///   <a href="http://purl.org/poso/Triangulation">poso:Triangulation</a>
    /// </summary>
    let Triangulation = _prefixId.prefix "Triangulation"
    /// <summary>
    ///   <para>rdfs:label : Visual simultaneous localisation and mapping</para>
    ///   <para>rdfs:comment : Visual simultaneous localisation and mapping (VSLAM) is a positioning techniques that uses visual imagery to map an environment. Positioning works by detecting features of interest in image frames and comparing how these features move from one frame to another.</para>
    ///   <a href="http://purl.org/poso/VSLAM">poso:VSLAM</a>
    /// </summary>
    let VSLAM = _prefixId.prefix "VSLAM"
    /// <summary>
    ///   <para>rdfs:label : Velocity</para>
    ///   <para>rdfs:comment : Linear or angular velocity of a feature.</para>
    ///   <a href="http://purl.org/poso/Velocity">poso:Velocity</a>
    /// </summary>
    let Velocity = _prefixId.prefix "Velocity"
    /// <summary>
    ///   <para>rdfs:label : Visual input</para>
    ///   <a href="http://purl.org/poso/VisualInput">poso:VisualInput</a>
    /// </summary>
    let VisualInput = _prefixId.prefix "VisualInput"
    /// <summary>
    ///   <para>rdfs:label : Visual landmark</para>
    ///   <para>rdfs:comment : A visual landmark is a feature of interest that visually present in the space.</para>
    ///   <a href="http://purl.org/poso/VisualLandmark">poso:VisualLandmark</a>
    /// </summary>
    let VisualLandmark = _prefixId.prefix "VisualLandmark"
    /// <summary>
    ///   <para>rdfs:label : Visual odometry</para>
    ///   <para>rdfs:comment : Visual odometry is the procedure of detecting movement by analyzing how visual features are moving from one Observation image frame to another.</para>
    ///   <a href="http://purl.org/poso/VisualOdometry">poso:VisualOdometry</a>
    /// </summary>
    let VisualOdometry = _prefixId.prefix "VisualOdometry"
    /// <summary>
    ///   <para>rdfs:label : anglerdfs:label : hoek</para>
    ///   <para>rdfs:comment : Quantitative anglue result value for axis-angle representation.</para>
    ///   <a href="http://purl.org/poso/angle">poso:angle</a>
    /// </summary>
    let angle = _prefixId.prefix "angle"
    /// <summary>
    ///   <para>rdfs:label : has accelerationrdfs:label : heeft versnelling</para>
    ///   <para>rdfs:comment : Property that links a feature of interest to a unique acceleration property related to this feature.</para>
    ///   <a href="http://purl.org/poso/hasAcceleration">poso:hasAcceleration</a>
    /// </summary>
    let hasAcceleration = _prefixId.prefix "hasAcceleration"
    /// <summary>
    ///   <para>rdfs:label : has accuracyrdfs:label : heeft accuraatheid</para>
    ///   <para>rdfs:comment : The accuracy of an entity.</para>
    ///   <a href="http://purl.org/poso/hasAccuracy">poso:hasAccuracy</a>
    /// </summary>
    let hasAccuracy = _prefixId.prefix "hasAccuracy"
    /// <summary>
    ///   <para>rdfs:label : has coordinate reference systemrdfs:label : heeft een coördinaten referentiesysteem</para>
    ///   <a href="http://purl.org/poso/hasCRS">poso:hasCRS</a>
    /// </summary>
    let hasCRS = _prefixId.prefix "hasCRS"
    /// <summary>
    ///   <para>rdfs:label : has orientationrdfs:label : heeft orientatie</para>
    ///   <para>rdfs:comment : Duid de orientatie aan van een object aan.rdfs:comment : Indicates the orientation of a feature of interest.</para>
    ///   <a href="http://purl.org/poso/hasOrientation">poso:hasOrientation</a>
    /// </summary>
    let hasOrientation = _prefixId.prefix "hasOrientation"
    /// <summary>
    ///   <para>rdfs:label : has positionrdfs:label : heeft positie</para>
    ///   <para>rdfs:comment : Duid de absolute of relatieve positie van een object aan.rdfs:comment : Indicates the absolute or relative position of a feature of interest.</para>
    ///   <a href="http://purl.org/poso/hasPosition">poso:hasPosition</a>
    /// </summary>
    let hasPosition = _prefixId.prefix "hasPosition"
    /// <summary>
    ///   <para>rdfs:label : has relative positionrdfs:label : heeft relatieve positie</para>
    ///   <a href="http://purl.org/poso/hasRelativePosition">poso:hasRelativePosition</a>
    /// </summary>
    let hasRelativePosition = _prefixId.prefix "hasRelativePosition"
    /// <summary>
    ///   <para>rdfs:label : has spatial reference systemrdfs:label : heeft een ruimtelijk referentiepunt</para>
    ///   <para>rdfs:comment : Identifies an entity that has a spatial reference system in order to interpret the result.</para>
    ///   <a href="http://purl.org/poso/hasSRS">poso:hasSRS</a>
    /// </summary>
    let hasSRS = _prefixId.prefix "hasSRS"
    /// <summary>
    ///   <para>rdfs:label : has velocityrdfs:label : heeft snelheid</para>
    ///   <para>rdfs:comment : Duid de snelheid van een object aan.rdfs:comment : Indicates the velocity of a feature of interest.</para>
    ///   <a href="http://purl.org/poso/hasVelocity">poso:hasVelocity</a>
    /// </summary>
    let hasVelocity = _prefixId.prefix "hasVelocity"
    /// <summary>
    ///   <para>vann:preferredNamespaceUri : Identifies an absolute position within a deployment</para>
    ///   <para>rdfs:label : in deployment</para>
    ///   <a href="http://purl.org/poso/inDeployment">poso:inDeployment</a>
    /// </summary>
    let inDeployment = _prefixId.prefix "inDeployment"
    /// <summary>
    ///   <para>rdfs:label : is acceleration ofrdfs:label : is versnelling van</para>
    ///   <a href="http://purl.org/poso/isAccelerationOf">poso:isAccelerationOf</a>
    /// </summary>
    let isAccelerationOf = _prefixId.prefix "isAccelerationOf"
    /// <summary>
    ///   <para>rdfs:label : is orientatie vanrdfs:label : is orientation of</para>
    ///   <a href="http://purl.org/poso/isOrientationOf">poso:isOrientationOf</a>
    /// </summary>
    let isOrientationOf = _prefixId.prefix "isOrientationOf"
    /// <summary>
    ///   <para>rdfs:label : is positie vanrdfs:label : is position of</para>
    ///   <a href="http://purl.org/poso/isPositionOf">poso:isPositionOf</a>
    /// </summary>
    let isPositionOf = _prefixId.prefix "isPositionOf"
    /// <summary>
    ///   <para>skos:example : A person can have a relative distance to another feature of interest. When a feature is moving (i.e. when the geometry changes based on time) the distance remains relative to the feature and not the geometry at a specific point in time.</para>
    ///   <para>rdfs:label : is relatief metrdfs:label : is relative to</para>
    ///   <para>rdfs:comment : Indicates a relative position to be relative to another feature of interest.</para>
    ///   <a href="http://purl.org/poso/isRelativeTo">poso:isRelativeTo</a>
    /// </summary>
    let isRelativeTo = _prefixId.prefix "isRelativeTo"
    /// <summary>
    ///   <para>rdfs:label : is de snelheid vanrdfs:label : is velocity of</para>
    ///   <a href="http://purl.org/poso/isVelocityOf">poso:isVelocityOf</a>
    /// </summary>
    let isVelocityOf = _prefixId.prefix "isVelocityOf"
    /// <summary>
    ///   <para>rdfs:label : gemaakt door systeemrdfs:label : made by system</para>
    ///   <para>rdfs:comment : A relation to a re-usable system that computed the observation.</para>
    ///   <a href="http://purl.org/poso/madeBySystem">poso:madeBySystem</a>
    /// </summary>
    let madeBySystem = _prefixId.prefix "madeBySystem"
    /// <summary>
    ///   <para>rdfs:label : observeert typerdfs:label : observes type</para>
    ///   <para>rdfs:comment : The relation between a system and an observable property class to identify that a system observes a specific type of property.</para>
    ///   <a href="http://purl.org/poso/observesType">poso:observesType</a>
    /// </summary>
    let observesType = _prefixId.prefix "observesType"
    /// <summary>
    ///   <para>rdfs:label : pitch</para>
    ///   <para>rdfs:comment : Pitch is the rotation around the x-axis with respect to the object the yaw applies to.</para>
    ///   <a href="http://purl.org/poso/pitch">poso:pitch</a>
    /// </summary>
    let pitch = _prefixId.prefix "pitch"
    /// <summary>
    ///   <para>rdfs:label : roll</para>
    ///   <para>rdfs:comment : Roll is the rotation around the y-axis with respect to the object the roll applies to.</para>
    ///   <a href="http://purl.org/poso/roll">poso:roll</a>
    /// </summary>
    let roll = _prefixId.prefix "roll"
    /// <summary>
    ///   <para>skos:altLabel : w^^xsd:string</para>
    ///   <para>rdfs:label : scalar</para>
    ///   <a href="http://purl.org/poso/scalar">poso:scalar</a>
    /// </summary>
    let scalar = _prefixId.prefix "scalar"
    /// <summary>
    ///   <para>rdfs:label : x-axis value</para>
    ///   <para>rdfs:comment : Quantitative result value along the X-axis of a spatial sensor or result.</para>
    ///   <a href="http://purl.org/poso/xAxisValue">poso:xAxisValue</a>
    /// </summary>
    let xAxisValue = _prefixId.prefix "xAxisValue"
    /// <summary>
    ///   <para>rdfs:label : y-axis value</para>
    ///   <para>rdfs:comment : Quantitative result value along the Y-axis of a spatial sensor or result.</para>
    ///   <a href="http://purl.org/poso/yAxisValue">poso:yAxisValue</a>
    /// </summary>
    let yAxisValue = _prefixId.prefix "yAxisValue"
    /// <summary>
    ///   <para>rdfs:label : yaw</para>
    ///   <para>rdfs:comment : Yaw is the rotation around the z-axis with respect to the object the yaw applies to.</para>
    ///   <a href="http://purl.org/poso/yaw">poso:yaw</a>
    /// </summary>
    let yaw = _prefixId.prefix "yaw"
    /// <summary>
    ///   <para>rdfs:label : z-axis value</para>
    ///   <para>rdfs:comment : Quantitative result value along the Z-axis of a spatial sensor.</para>
    ///   <a href="http://purl.org/poso/zAxisValue">poso:zAxisValue</a>
    /// </summary>
    let zAxisValue = _prefixId.prefix "zAxisValue"

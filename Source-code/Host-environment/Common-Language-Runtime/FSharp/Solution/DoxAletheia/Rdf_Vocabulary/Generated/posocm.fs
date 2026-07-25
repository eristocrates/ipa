namespace http.purl.org.poso.common.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module posocm =
    let _namespace_iri = Namespace_Iri posocm |> NamespaceIRI
    /// <summary>
    ///   <para>posocm:ORBSLAM2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:VSLAM</para>
    ///
    /// labels<para>ORB-SLAM2</para></remarks>
    /// <seealso href="http://purl.org/poso/common/ORBSLAM2">http://purl.org/poso/common/ORBSLAM2</seealso>
    let ORBSLAM2 = Prefixed_Name(posocm, "ORBSLAM2") |> PrefixedName
    /// <summary>
    ///   <para>posocm:OpenHPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:PositioningPlatform</para>
    ///   <para>OpenHPS is an open source hybrid positioning system to help developers fuse various positioning technologies and algorithms. The system offers a modular data processing framework with each modules ranging from computer vision to common algorithms such as fingerprinting or data persistence of sampled data.</para>
    /// labels<para>OpenHPS</para></remarks>
    /// <seealso href="http://purl.org/poso/common/OpenHPS">http://purl.org/poso/common/OpenHPS</seealso>
    let OpenHPS = Prefixed_Name(posocm, "OpenHPS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:SonyNimway</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:PositioningPlatform</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Nimway from Sony is a complete smart office solution for the people-centred workplace. Acting as your personal assistant throughout the workday, it facilitates many otherwise time-consuming tasks, like finding your way to a meeting room, locating a colleague or booking a desk.</para>
    /// labels<para>Sony Nimway</para></remarks>
    /// <seealso href="http://purl.org/poso/common/SonyNimway">http://purl.org/poso/common/SonyNimway</seealso>
    let SonyNimway = Prefixed_Name(posocm, "SonyNimway") |> PrefixedName
    /// <summary>
    ///   <para>posocm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/poso/common/">http://purl.org/poso/common/</seealso>
    let _prefix_iri = Prefixed_Name(posocm, "") |> PrefixedName

    /// <summary>
    ///   <para>posocm:RFCellIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:CellIdentification</para>
    ///   <para>RF cell identification is a technique that determines the position based on the closest RF landmark in range.</para>
    /// labels<para>RF cell identification</para></remarks>
    /// <seealso href="http://purl.org/poso/common/RFCellIdentification">http://purl.org/poso/common/RFCellIdentification</seealso>
    let RFCellIdentification =
        Prefixed_Name(posocm, "RFCellIdentification") |> PrefixedName

    /// <summary>
    ///   <para>posocm:ROS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:PositioningPlatform</para>
    ///   <para>ROS (Robot Operating System) provides libraries and tools to help software developers create robot applications. It provides hardware abstraction, device drivers, libraries, visualizers, message-passing, package management, and more.</para>
    /// labels<para>Robotics Operating System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/ROS">http://purl.org/poso/common/ROS</seealso>
    let ROS = Prefixed_Name(posocm, "ROS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:CSIFingerprinting</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:Fingerprinting</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Channel State Information fingerprinting</para></remarks>
    /// <seealso href="http://purl.org/poso/common/CSIFingerprinting">http://purl.org/poso/common/CSIFingerprinting</seealso>
    let CSIFingerprinting = Prefixed_Name(posocm, "CSIFingerprinting") |> PrefixedName
    /// <summary>
    ///   <para>posocm:GLONASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>GLONASS (Globalnaya Navigazionnaya Sputnikovaya Sistema, or Global Navigation Satellite System) is a global GNSS owned and operated by the Russian Federation. The fully operational system consists of 24+ satellites.</para>
    /// labels<para>Globalnaya Navigazionnaya Sputnikovaya Sistema</para><para>Global Navigation Satellite System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/GLONASS">http://purl.org/poso/common/GLONASS</seealso>
    let GLONASS = Prefixed_Name(posocm, "GLONASS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:GeolocationAPI</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:LocationBasedService</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Geolocation API is a W3C specification that provides geographical location data based on the capabilities of the hosting device.</para>
    /// labels<para>Geolocation API</para></remarks>
    /// <seealso href="http://purl.org/poso/common/GeolocationAPI">http://purl.org/poso/common/GeolocationAPI</seealso>
    let GeolocationAPI = Prefixed_Name(posocm, "GeolocationAPI") |> PrefixedName
    /// <summary>
    ///   <para>posocm:HectorSLAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:VSLAM</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Hector SLAM</para></remarks>
    /// <seealso href="http://purl.org/poso/common/HectorSLAM">http://purl.org/poso/common/HectorSLAM</seealso>
    let HectorSLAM = Prefixed_Name(posocm, "HectorSLAM") |> PrefixedName
    /// <summary>
    ///   <para>posocm:IRNSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").</para>
    /// labels<para>Indian Regional Navigation Satellite System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/IRNSS">http://purl.org/poso/common/IRNSS</seealso>
    let IRNSS = Prefixed_Name(posocm, "IRNSS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:NavIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").</para>
    /// labels<para>Navigation Indian Constellation</para></remarks>
    /// <seealso href="http://purl.org/poso/common/NavIC">http://purl.org/poso/common/NavIC</seealso>
    let NavIC = Prefixed_Name(posocm, "NavIC") |> PrefixedName
    /// <summary>
    ///   <para>posocm:IndoorAtlas</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:PositioningPlatform</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Cross-platform indoor positioning SDK powered by patented 6-layer sensor fusion core. Fast development cycles. Easy to set up. Proven by 10,000+ developers.</para>
    /// labels<para>IndoorAtlas</para></remarks>
    /// <seealso href="http://purl.org/poso/common/IndoorAtlas">http://purl.org/poso/common/IndoorAtlas</seealso>
    let IndoorAtlas = Prefixed_Name(posocm, "IndoorAtlas") |> PrefixedName
    /// <summary>
    ///   <para>posocm:LDPL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:RadioPropagation</para>
    ///   <para>The log-distance path loss model is a radio propagation model that predicts the path loss a signal encounters inside a building or densely populated areas over distance.</para>
    /// labels<para>Log-distance path loss model</para></remarks>
    /// <seealso href="http://purl.org/poso/common/LDPL">http://purl.org/poso/common/LDPL</seealso>
    let LDPL = Prefixed_Name(posocm, "LDPL") |> PrefixedName
    /// <summary>
    ///   <para>posocm:NLSMultilateration</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:Multilateration</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Non-linear least squares multilateration</para></remarks>
    /// <seealso href="http://purl.org/poso/common/NLSMultilateration">http://purl.org/poso/common/NLSMultilateration</seealso>
    let NLSMultilateration = Prefixed_Name(posocm, "NLSMultilateration") |> PrefixedName

    /// <summary>
    ///   <para>posocm:AbsolutePositionOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:PositionOutput</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:rdfp/GraphDescription</para>
    ///
    /// labels<para>Absolute position output</para></remarks>
    /// <seealso href="http://purl.org/poso/common/AbsolutePositionOutput">http://purl.org/poso/common/AbsolutePositionOutput</seealso>
    let AbsolutePositionOutput =
        Prefixed_Name(posocm, "AbsolutePositionOutput") |> PrefixedName

    /// <summary>
    ///   <para>posocm:Anyplace</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:PositioningPlatform</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Anyplace is a first-of-a-kind indoor information service offering GPS-less localization, navigation and search inside buildings using ordinary smartphones.</para>
    /// labels<para>Anyplace</para></remarks>
    /// <seealso href="http://purl.org/poso/common/Anyplace">http://purl.org/poso/common/Anyplace</seealso>
    let Anyplace = Prefixed_Name(posocm, "Anyplace") |> PrefixedName
    /// <summary>
    ///   <para>posocm:FootMountedPDR</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:PDR</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Foot-mounted pedestrian dead reckoning uses a sensor on the foot of a pedestrian to detect steps.</para>
    /// labels<para>Foot-mounted pedestrian dead reckoning</para></remarks>
    /// <seealso href="http://purl.org/poso/common/FootMountedPDR">http://purl.org/poso/common/FootMountedPDR</seealso>
    let FootMountedPDR = Prefixed_Name(posocm, "FootMountedPDR") |> PrefixedName
    /// <summary>
    ///   <para>posocm:BDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>BeiDou, or BDS, is a global GNSS owned and operated by the People's Republic of China. BDS was formally commissioned in 2020. The operational system consists of 35 satellites. BDS was previously called Compass.</para>
    /// labels<para>BeiDou Navigation Satellite System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/BDS">http://purl.org/poso/common/BDS</seealso>
    let BDS = Prefixed_Name(posocm, "BDS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:EarthDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:OutdoorDeployment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A generic deployment for any positioning system deployment on Earth.</para>
    /// labels<para>Earth deployment</para></remarks>
    /// <seealso href="http://purl.org/poso/common/EarthDeployment">http://purl.org/poso/common/EarthDeployment</seealso>
    let EarthDeployment = Prefixed_Name(posocm, "EarthDeployment") |> PrefixedName
    /// <summary>
    ///   <para>posocm:GPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>The Global Positioning System (GPS) is a U.S.-owned utility that provides users with positioning, navigation, and timing (PNT) services. This system consists of three segments: the space segment, the control segment, and the user segment. The U.S. Space Force develops, maintains, and operates the space and control segments.</para>
    /// labels<para>Global Positioning System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/GPS">http://purl.org/poso/common/GPS</seealso>
    let GPS = Prefixed_Name(posocm, "GPS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:Galileo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>Galileo is a global GNSS owned and operated by the European Union. The EU declared the start of Galileo Initial Services in 2016 and plans to complete the system of 24+ satellites in 2021.</para>
    /// labels<para>Galileo</para></remarks>
    /// <seealso href="http://purl.org/poso/common/Galileo">http://purl.org/poso/common/Galileo</seealso>
    let Galileo = Prefixed_Name(posocm, "Galileo") |> PrefixedName
    /// <summary>
    ///   <para>posocm:KNNFingerprinting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:Fingerprinting</para>
    ///   <para>k-Neirest Neighbour fingerprinting is a fingerprinting technique where a number (k) of matches are selected, as opposed to one single fingerprint match. The final output position is the (weighted) average of the k-number of selected fingerprints.</para>
    /// labels<para>k-NN fingerprinting</para></remarks>
    /// <seealso href="http://purl.org/poso/common/KNNFingerprinting">http://purl.org/poso/common/KNNFingerprinting</seealso>
    let KNNFingerprinting = Prefixed_Name(posocm, "KNNFingerprinting") |> PrefixedName
    /// <summary>
    ///   <para>posocm:MidpointLateration</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:Lateration</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Midpoint lateration uses the midpoint of two points.</para>
    /// labels<para>Midpoint lateration</para></remarks>
    /// <seealso href="http://purl.org/poso/common/MidpointLateration">http://purl.org/poso/common/MidpointLateration</seealso>
    let MidpointLateration = Prefixed_Name(posocm, "MidpointLateration") |> PrefixedName
    /// <summary>
    ///   <para>posocm:ORBSLAM3</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:VSLAM</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>ORB-SLAM3</para></remarks>
    /// <seealso href="http://purl.org/poso/common/ORBSLAM3">http://purl.org/poso/common/ORBSLAM3</seealso>
    let ORBSLAM3 = Prefixed_Name(posocm, "ORBSLAM3") |> PrefixedName
    /// <summary>
    ///   <para>posocm:OpenVSLAM</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:VSLAM</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>OpenVSLAM</para></remarks>
    /// <seealso href="http://purl.org/poso/common/OpenVSLAM">http://purl.org/poso/common/OpenVSLAM</seealso>
    let OpenVSLAM = Prefixed_Name(posocm, "OpenVSLAM") |> PrefixedName

    /// <summary>
    ///   <para>posocm:ProbabilisticFingerprinting</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:Fingerprinting</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Probabilistic fingerprinting</para></remarks>
    /// <seealso href="http://purl.org/poso/common/ProbabilisticFingerprinting">http://purl.org/poso/common/ProbabilisticFingerprinting</seealso>
    let ProbabilisticFingerprinting =
        Prefixed_Name(posocm, "ProbabilisticFingerprinting") |> PrefixedName

    /// <summary>
    ///   <para>posocm:QZSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>poso:SatellitePositioningSystem</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>QZSS is a regional GNSS owned by the Government of Japan and operated by QZS System Service Inc. (QSS). QZSS complements GPS to improve coverage in East Asia and Oceania. Japan declared the official start of QZSS services in 2018 with 4 operational satellites, and plans to expand the constellation to 7 satellites by 2023 for autonomous capability.</para>
    /// labels<para>Quasi-Zenith Satellite System</para></remarks>
    /// <seealso href="http://purl.org/poso/common/QZSS">http://purl.org/poso/common/QZSS</seealso>
    let QZSS = Prefixed_Name(posocm, "QZSS") |> PrefixedName
    /// <summary>
    ///   <para>posocm:SVMFingerprinting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:Fingerprinting</para>
    ///
    /// labels<para>Support Vector Machine fingerprinting</para></remarks>
    /// <seealso href="http://purl.org/poso/common/SVMFingerprinting">http://purl.org/poso/common/SVMFingerprinting</seealso>
    let SVMFingerprinting = Prefixed_Name(posocm, "SVMFingerprinting") |> PrefixedName

    /// <summary>
    ///   <para>posocm:WeightedAccuracyFusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>poso:HighLevelFusion</para>
    ///   <para>Decision level fusion based on weighted average of the accuracy^-1.</para>
    /// labels<para>Weighted accuracy fusion</para></remarks>
    /// <seealso href="http://purl.org/poso/common/WeightedAccuracyFusion">http://purl.org/poso/common/WeightedAccuracyFusion</seealso>
    let WeightedAccuracyFusion =
        Prefixed_Name(posocm, "WeightedAccuracyFusion") |> PrefixedName

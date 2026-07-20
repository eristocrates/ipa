namespace http.purl.org.poso.common.slash

open DoxAletheia

module posocm =
    let _namespace_name = "http://purl.org/poso/common/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/AbsolutePositionOutput"></see>
    /// </summary>
    let AbsolutePositionOutput = _prefix "AbsolutePositionOutput"
    /// <summary>
    /// Anyplace is a first-of-a-kind indoor information service offering GPS-less localization, navigation and search inside buildings using ordinary smartphones.
    /// <see href="http://purl.org/poso/common/Anyplace"></see></summary>
    let Anyplace = _prefix "Anyplace"
    /// <summary>
    /// BeiDou, or BDS, is a global GNSS owned and operated by the People's Republic of China. BDS was formally commissioned in 2020. The operational system consists of 35 satellites. BDS was previously called Compass.
    /// <see href="http://purl.org/poso/common/BDS"></see></summary>
    let BDS = _prefix "BDS"
    /// <summary>
    /// A generic deployment for any positioning system deployment on Earth.
    /// <see href="http://purl.org/poso/common/EarthDeployment"></see></summary>
    let EarthDeployment = _prefix "EarthDeployment"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/CSIFingerprinting"></see>
    /// </summary>
    let CSIFingerprinting = _prefix "CSIFingerprinting"
    /// <summary>
    /// Foot-mounted pedestrian dead reckoning uses a sensor on the foot of a pedestrian to detect steps.
    /// <see href="http://purl.org/poso/common/FootMountedPDR"></see></summary>
    let FootMountedPDR = _prefix "FootMountedPDR"
    /// <summary>
    /// GLONASS (Globalnaya Navigazionnaya Sputnikovaya Sistema, or Global Navigation Satellite System) is a global GNSS owned and operated by the Russian Federation. The fully operational system consists of 24+ satellites.
    /// <see href="http://purl.org/poso/common/GLONASS"></see></summary>
    let GLONASS = _prefix "GLONASS"
    /// <summary>
    /// The Global Positioning System (GPS) is a U.S.-owned utility that provides users with positioning, navigation, and timing (PNT) services. This system consists of three segments: the space segment, the control segment, and the user segment. The U.S. Space Force develops, maintains, and operates the space and control segments.
    /// <see href="http://purl.org/poso/common/GPS"></see></summary>
    let GPS = _prefix "GPS"
    /// <summary>
    /// Galileo is a global GNSS owned and operated by the European Union. The EU declared the start of Galileo Initial Services in 2016 and plans to complete the system of 24+ satellites in 2021.
    /// <see href="http://purl.org/poso/common/Galileo"></see></summary>
    let Galileo = _prefix "Galileo"
    /// <summary>
    /// The Geolocation API is a W3C specification that provides geographical location data based on the capabilities of the hosting device.
    /// <see href="http://purl.org/poso/common/GeolocationAPI"></see></summary>
    let GeolocationAPI = _prefix "GeolocationAPI"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/HectorSLAM"></see>
    /// </summary>
    let HectorSLAM = _prefix "HectorSLAM"
    /// <summary>
    /// IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").
    /// <see href="http://purl.org/poso/common/IRNSS"></see></summary>
    let IRNSS = _prefix "IRNSS"
    /// <summary>
    /// IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").
    /// <see href="http://purl.org/poso/common/NavIC"></see></summary>
    let NavIC = _prefix "NavIC"
    /// <summary>
    /// Cross-platform indoor positioning SDK powered by patented 6-layer sensor fusion core. Fast development cycles. Easy to set up. Proven by 10,000+ developers.
    /// <see href="http://purl.org/poso/common/IndoorAtlas"></see></summary>
    let IndoorAtlas = _prefix "IndoorAtlas"
    /// <summary>
    /// k-Neirest Neighbour fingerprinting is a fingerprinting technique where a number (k) of matches are selected, as opposed to one single fingerprint match. The final output position is the (weighted) average of the k-number of selected fingerprints.
    /// <see href="http://purl.org/poso/common/KNNFingerprinting"></see></summary>
    let KNNFingerprinting = _prefix "KNNFingerprinting"
    /// <summary>
    /// The log-distance path loss model is a radio propagation model that predicts the path loss a signal encounters inside a building or densely populated areas over distance.
    /// <see href="http://purl.org/poso/common/LDPL"></see></summary>
    let LDPL = _prefix "LDPL"
    /// <summary>
    /// Midpoint lateration uses the midpoint of two points.
    /// <see href="http://purl.org/poso/common/MidpointLateration"></see></summary>
    let MidpointLateration = _prefix "MidpointLateration"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/NLSMultilateration"></see>
    /// </summary>
    let NLSMultilateration = _prefix "NLSMultilateration"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/ORBSLAM2"></see>
    /// </summary>
    let ORBSLAM2 = _prefix "ORBSLAM2"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/ORBSLAM3"></see>
    /// </summary>
    let ORBSLAM3 = _prefix "ORBSLAM3"
    /// <summary>
    /// OpenHPS is an open source hybrid positioning system to help developers fuse various positioning technologies and algorithms. The system offers a modular data processing framework with each modules ranging from computer vision to common algorithms such as fingerprinting or data persistence of sampled data.
    /// <see href="http://purl.org/poso/common/OpenHPS"></see></summary>
    let OpenHPS = _prefix "OpenHPS"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/OpenVSLAM"></see>
    /// </summary>
    let OpenVSLAM = _prefix "OpenVSLAM"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/ProbabilisticFingerprinting"></see>
    /// </summary>
    let ProbabilisticFingerprinting = _prefix "ProbabilisticFingerprinting"
    /// <summary>
    /// QZSS is a regional GNSS owned by the Government of Japan and operated by QZS System Service Inc. (QSS). QZSS complements GPS to improve coverage in East Asia and Oceania. Japan declared the official start of QZSS services in 2018 with 4 operational satellites, and plans to expand the constellation to 7 satellites by 2023 for autonomous capability.
    /// <see href="http://purl.org/poso/common/QZSS"></see></summary>
    let QZSS = _prefix "QZSS"
    /// <summary>
    /// RF cell identification is a technique that determines the position based on the closest RF landmark in range.
    /// <see href="http://purl.org/poso/common/RFCellIdentification"></see></summary>
    let RFCellIdentification = _prefix "RFCellIdentification"
    /// <summary>
    /// ROS (Robot Operating System) provides libraries and tools to help software developers create robot applications. It provides hardware abstraction, device drivers, libraries, visualizers, message-passing, package management, and more.
    /// <see href="http://purl.org/poso/common/ROS"></see></summary>
    let ROS = _prefix "ROS"
    /// <summary>
    ///   <see href="http://purl.org/poso/common/SVMFingerprinting"></see>
    /// </summary>
    let SVMFingerprinting = _prefix "SVMFingerprinting"
    /// <summary>
    /// Nimway from Sony is a complete smart office solution for the people-centred workplace. Acting as your personal assistant throughout the workday, it facilitates many otherwise time-consuming tasks, like finding your way to a meeting room, locating a colleague or booking a desk.
    /// <see href="http://purl.org/poso/common/SonyNimway"></see></summary>
    let SonyNimway = _prefix "SonyNimway"
    /// <summary>
    /// Decision level fusion based on weighted average of the accuracy^-1.
    /// <see href="http://purl.org/poso/common/WeightedAccuracyFusion"></see></summary>
    let WeightedAccuracyFusion = _prefix "WeightedAccuracyFusion"

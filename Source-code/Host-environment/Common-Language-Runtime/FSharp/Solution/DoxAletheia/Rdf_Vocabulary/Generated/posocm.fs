namespace http.purl.org.poso.common.slash

open DoxAletheia.Rdf_Vocabulary

module posocm =
    let _namespace_name = "http://purl.org/poso/common/"

    /// <summary>
    ///   <see href="http://purl.org/poso/common/AbsolutePositionOutput"></see>
    /// </summary>
    let AbsolutePositionOutput =
        Namespaced_IRI.parse _namespace_name "AbsolutePositionOutput" |> NamespacedName

    /// <summary>
    /// Anyplace is a first-of-a-kind indoor information service offering GPS-less localization, navigation and search inside buildings using ordinary smartphones.
    /// <see href="http://purl.org/poso/common/Anyplace"></see></summary>
    let Anyplace = Namespaced_IRI.parse _namespace_name "Anyplace" |> NamespacedName
    /// <summary>
    /// BeiDou, or BDS, is a global GNSS owned and operated by the People's Republic of China. BDS was formally commissioned in 2020. The operational system consists of 35 satellites. BDS was previously called Compass.
    /// <see href="http://purl.org/poso/common/BDS"></see></summary>
    let BDS = Namespaced_IRI.parse _namespace_name "BDS" |> NamespacedName

    /// <summary>
    /// A generic deployment for any positioning system deployment on Earth.
    /// <see href="http://purl.org/poso/common/EarthDeployment"></see></summary>
    let EarthDeployment =
        Namespaced_IRI.parse _namespace_name "EarthDeployment" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/CSIFingerprinting"></see>
    /// </summary>
    let CSIFingerprinting =
        Namespaced_IRI.parse _namespace_name "CSIFingerprinting" |> NamespacedName

    /// <summary>
    /// Foot-mounted pedestrian dead reckoning uses a sensor on the foot of a pedestrian to detect steps.
    /// <see href="http://purl.org/poso/common/FootMountedPDR"></see></summary>
    let FootMountedPDR =
        Namespaced_IRI.parse _namespace_name "FootMountedPDR" |> NamespacedName

    /// <summary>
    /// GLONASS (Globalnaya Navigazionnaya Sputnikovaya Sistema, or Global Navigation Satellite System) is a global GNSS owned and operated by the Russian Federation. The fully operational system consists of 24+ satellites.
    /// <see href="http://purl.org/poso/common/GLONASS"></see></summary>
    let GLONASS = Namespaced_IRI.parse _namespace_name "GLONASS" |> NamespacedName
    /// <summary>
    /// The Global Positioning System (GPS) is a U.S.-owned utility that provides users with positioning, navigation, and timing (PNT) services. This system consists of three segments: the space segment, the control segment, and the user segment. The U.S. Space Force develops, maintains, and operates the space and control segments.
    /// <see href="http://purl.org/poso/common/GPS"></see></summary>
    let GPS = Namespaced_IRI.parse _namespace_name "GPS" |> NamespacedName
    /// <summary>
    /// Galileo is a global GNSS owned and operated by the European Union. The EU declared the start of Galileo Initial Services in 2016 and plans to complete the system of 24+ satellites in 2021.
    /// <see href="http://purl.org/poso/common/Galileo"></see></summary>
    let Galileo = Namespaced_IRI.parse _namespace_name "Galileo" |> NamespacedName

    /// <summary>
    /// The Geolocation API is a W3C specification that provides geographical location data based on the capabilities of the hosting device.
    /// <see href="http://purl.org/poso/common/GeolocationAPI"></see></summary>
    let GeolocationAPI =
        Namespaced_IRI.parse _namespace_name "GeolocationAPI" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/HectorSLAM"></see>
    /// </summary>
    let HectorSLAM = Namespaced_IRI.parse _namespace_name "HectorSLAM" |> NamespacedName
    /// <summary>
    /// IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").
    /// <see href="http://purl.org/poso/common/IRNSS"></see></summary>
    let IRNSS = Namespaced_IRI.parse _namespace_name "IRNSS" |> NamespacedName
    /// <summary>
    /// IRNSS is a regional GNSS owned and operated by the Government of India. IRNSS is an autonomous system designed to cover the Indian region and 1500 km around the Indian mainland. The system consists of 7 satellites. In 2016, India renamed IRNSS as the Navigation Indian Constellation (NavIC, meaning "sailor" or "navigator").
    /// <see href="http://purl.org/poso/common/NavIC"></see></summary>
    let NavIC = Namespaced_IRI.parse _namespace_name "NavIC" |> NamespacedName

    /// <summary>
    /// Cross-platform indoor positioning SDK powered by patented 6-layer sensor fusion core. Fast development cycles. Easy to set up. Proven by 10,000+ developers.
    /// <see href="http://purl.org/poso/common/IndoorAtlas"></see></summary>
    let IndoorAtlas =
        Namespaced_IRI.parse _namespace_name "IndoorAtlas" |> NamespacedName

    /// <summary>
    /// k-Neirest Neighbour fingerprinting is a fingerprinting technique where a number (k) of matches are selected, as opposed to one single fingerprint match. The final output position is the (weighted) average of the k-number of selected fingerprints.
    /// <see href="http://purl.org/poso/common/KNNFingerprinting"></see></summary>
    let KNNFingerprinting =
        Namespaced_IRI.parse _namespace_name "KNNFingerprinting" |> NamespacedName

    /// <summary>
    /// The log-distance path loss model is a radio propagation model that predicts the path loss a signal encounters inside a building or densely populated areas over distance.
    /// <see href="http://purl.org/poso/common/LDPL"></see></summary>
    let LDPL = Namespaced_IRI.parse _namespace_name "LDPL" |> NamespacedName

    /// <summary>
    /// Midpoint lateration uses the midpoint of two points.
    /// <see href="http://purl.org/poso/common/MidpointLateration"></see></summary>
    let MidpointLateration =
        Namespaced_IRI.parse _namespace_name "MidpointLateration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/NLSMultilateration"></see>
    /// </summary>
    let NLSMultilateration =
        Namespaced_IRI.parse _namespace_name "NLSMultilateration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/ORBSLAM2"></see>
    /// </summary>
    let ORBSLAM2 = Namespaced_IRI.parse _namespace_name "ORBSLAM2" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/poso/common/ORBSLAM3"></see>
    /// </summary>
    let ORBSLAM3 = Namespaced_IRI.parse _namespace_name "ORBSLAM3" |> NamespacedName
    /// <summary>
    /// OpenHPS is an open source hybrid positioning system to help developers fuse various positioning technologies and algorithms. The system offers a modular data processing framework with each modules ranging from computer vision to common algorithms such as fingerprinting or data persistence of sampled data.
    /// <see href="http://purl.org/poso/common/OpenHPS"></see></summary>
    let OpenHPS = Namespaced_IRI.parse _namespace_name "OpenHPS" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/poso/common/OpenVSLAM"></see>
    /// </summary>
    let OpenVSLAM = Namespaced_IRI.parse _namespace_name "OpenVSLAM" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/ProbabilisticFingerprinting"></see>
    /// </summary>
    let ProbabilisticFingerprinting =
        Namespaced_IRI.parse _namespace_name "ProbabilisticFingerprinting" |> NamespacedName

    /// <summary>
    /// QZSS is a regional GNSS owned by the Government of Japan and operated by QZS System Service Inc. (QSS). QZSS complements GPS to improve coverage in East Asia and Oceania. Japan declared the official start of QZSS services in 2018 with 4 operational satellites, and plans to expand the constellation to 7 satellites by 2023 for autonomous capability.
    /// <see href="http://purl.org/poso/common/QZSS"></see></summary>
    let QZSS = Namespaced_IRI.parse _namespace_name "QZSS" |> NamespacedName

    /// <summary>
    /// RF cell identification is a technique that determines the position based on the closest RF landmark in range.
    /// <see href="http://purl.org/poso/common/RFCellIdentification"></see></summary>
    let RFCellIdentification =
        Namespaced_IRI.parse _namespace_name "RFCellIdentification" |> NamespacedName

    /// <summary>
    /// ROS (Robot Operating System) provides libraries and tools to help software developers create robot applications. It provides hardware abstraction, device drivers, libraries, visualizers, message-passing, package management, and more.
    /// <see href="http://purl.org/poso/common/ROS"></see></summary>
    let ROS = Namespaced_IRI.parse _namespace_name "ROS" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/poso/common/SVMFingerprinting"></see>
    /// </summary>
    let SVMFingerprinting =
        Namespaced_IRI.parse _namespace_name "SVMFingerprinting" |> NamespacedName

    /// <summary>
    /// Nimway from Sony is a complete smart office solution for the people-centred workplace. Acting as your personal assistant throughout the workday, it facilitates many otherwise time-consuming tasks, like finding your way to a meeting room, locating a colleague or booking a desk.
    /// <see href="http://purl.org/poso/common/SonyNimway"></see></summary>
    let SonyNimway = Namespaced_IRI.parse _namespace_name "SonyNimway" |> NamespacedName

    /// <summary>
    /// Decision level fusion based on weighted average of the accuracy^-1.
    /// <see href="http://purl.org/poso/common/WeightedAccuracyFusion"></see></summary>
    let WeightedAccuracyFusion =
        Namespaced_IRI.parse _namespace_name "WeightedAccuracyFusion" |> NamespacedName

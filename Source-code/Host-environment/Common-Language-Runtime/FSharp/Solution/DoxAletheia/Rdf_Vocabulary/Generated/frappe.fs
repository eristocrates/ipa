namespace http.streamreasoning.org.ontologies.frappe.hash

open DoxAletheia.Rdf_Vocabulary

module frappe =
    let _namespace_name = "http://streamreasoning.org/ontologies/frappe#"
    /// <summary>
    /// Activity to create new Captured Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#Capture"></see></summary>
    let Capture = Namespaced_IRI.parse _namespace_name "Capture" |> NamespacedName

    /// <summary>
    /// Original time varying representation of a Grid, mediated by the Capture activity
    /// <see href="http://streamreasoning.org/ontologies/frappe#CapturedFrame"></see></summary>
    let CapturedFrame =
        Namespaced_IRI.parse _namespace_name "CapturedFrame" |> NamespacedName

    /// <summary>
    /// A Frame represents a time varying representation of a Grid
    /// <see href="http://streamreasoning.org/ontologies/frappe#Frame"></see></summary>
    let Frame = Namespaced_IRI.parse _namespace_name "Frame" |> NamespacedName
    /// <summary>
    /// A Cell represents the basic spatial unit of aggregation of information
    /// <see href="http://streamreasoning.org/ontologies/frappe#Cell"></see></summary>
    let Cell = Namespaced_IRI.parse _namespace_name "Cell" |> NamespacedName
    /// <summary>
    /// The Grid represents a group of contiguous Cells
    /// <see href="http://streamreasoning.org/ontologies/frappe#Grid"></see></summary>
    let Grid = Namespaced_IRI.parse _namespace_name "Grid" |> NamespacedName
    /// <summary>
    /// A Pixel is a time varying representation of a Cell
    ///
    /// <see href="http://streamreasoning.org/ontologies/frappe#Pixel"></see></summary>
    let Pixel = Namespaced_IRI.parse _namespace_name "Pixel" |> NamespacedName
    /// <summary>
    /// A Place represents a point in space
    /// <see href="http://streamreasoning.org/ontologies/frappe#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    /// Synthetic time varying representation of a Grid, mediated by the Synthetize activity. A Synthetic Frame can be be created starting from Captured Frames or Synthetic Frames
    /// <see href="http://streamreasoning.org/ontologies/frappe#SyntheticFrame"></see></summary>
    let SyntheticFrame =
        Namespaced_IRI.parse _namespace_name "SyntheticFrame" |> NamespacedName

    /// <summary>
    /// Activity to create new Synthetic Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#Synthetize"></see></summary>
    let Synthetize = Namespaced_IRI.parse _namespace_name "Synthetize" |> NamespacedName
    /// <summary>
    /// Relates a Frame with its Pixels
    /// <see href="http://streamreasoning.org/ontologies/frappe#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    ///   <see href="http://streamreasoning.org/ontologies/frappe#hasValue"></see>
    /// </summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName
    /// <summary>
    /// Relates a Pixel with its Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#isIn"></see></summary>
    let isIn = Namespaced_IRI.parse _namespace_name "isIn" |> NamespacedName

    /// <summary>
    /// Relates a Place with its Events
    /// <see href="http://streamreasoning.org/ontologies/frappe#isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName

    /// <summary>
    /// Relates a Cell with its Pixels
    /// <see href="http://streamreasoning.org/ontologies/frappe#isReferredBy"></see></summary>
    let isReferredBy =
        Namespaced_IRI.parse _namespace_name "isReferredBy" |> NamespacedName

    /// <summary>
    /// Relates an Event with its Pixel
    /// <see href="http://streamreasoning.org/ontologies/frappe#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// Relates Pixel to its Cell
    /// <see href="http://streamreasoning.org/ontologies/frappe#refers"></see></summary>
    let refers = Namespaced_IRI.parse _namespace_name "refers" |> NamespacedName

    /// <summary>
    /// Relates a Frame with its creation Instant
    /// <see href="http://streamreasoning.org/ontologies/frappe#samplingTime"></see></summary>
    let samplingTime =
        Namespaced_IRI.parse _namespace_name "samplingTime" |> NamespacedName

    /// <summary>
    /// Relate a Capture Frame to the time interval needed to capture a minimum quantity of data
    /// <see href="http://streamreasoning.org/ontologies/frappe#timeExposure"></see></summary>
    let timeExposure =
        Namespaced_IRI.parse _namespace_name "timeExposure" |> NamespacedName

    /// <summary>
    /// Relates a Frame to a Grid
    /// <see href="http://streamreasoning.org/ontologies/frappe#wasCapturedFrom"></see></summary>
    let wasCapturedFrom =
        Namespaced_IRI.parse _namespace_name "wasCapturedFrom" |> NamespacedName

    /// <summary>
    /// Relates a Synthetic Frame to the elements needed to the Synthetization
    /// <see href="http://streamreasoning.org/ontologies/frappe#wasSynthetizedFrom"></see></summary>
    let wasSynthetizedFrom =
        Namespaced_IRI.parse _namespace_name "wasSynthetizedFrom" |> NamespacedName

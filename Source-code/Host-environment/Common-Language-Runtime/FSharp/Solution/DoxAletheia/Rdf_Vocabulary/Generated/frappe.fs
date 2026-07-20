namespace http.streamreasoning.org.ontologies.frappe.hash

open DoxAletheia

module frappe =
    let _namespace_name = "http://streamreasoning.org/ontologies/frappe#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Activity to create new Captured Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#Capture"></see></summary>
    let Capture = _prefix "Capture"
    /// <summary>
    /// Original time varying representation of a Grid, mediated by the Capture activity
    /// <see href="http://streamreasoning.org/ontologies/frappe#CapturedFrame"></see></summary>
    let CapturedFrame = _prefix "CapturedFrame"
    /// <summary>
    /// A Frame represents a time varying representation of a Grid
    /// <see href="http://streamreasoning.org/ontologies/frappe#Frame"></see></summary>
    let Frame = _prefix "Frame"
    /// <summary>
    /// A Cell represents the basic spatial unit of aggregation of information
    /// <see href="http://streamreasoning.org/ontologies/frappe#Cell"></see></summary>
    let Cell = _prefix "Cell"
    /// <summary>
    /// The Grid represents a group of contiguous Cells
    /// <see href="http://streamreasoning.org/ontologies/frappe#Grid"></see></summary>
    let Grid = _prefix "Grid"
    /// <summary>
    /// A Pixel is a time varying representation of a Cell
    ///
    /// <see href="http://streamreasoning.org/ontologies/frappe#Pixel"></see></summary>
    let Pixel = _prefix "Pixel"
    /// <summary>
    /// A Place represents a point in space
    /// <see href="http://streamreasoning.org/ontologies/frappe#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// Synthetic time varying representation of a Grid, mediated by the Synthetize activity. A Synthetic Frame can be be created starting from Captured Frames or Synthetic Frames
    /// <see href="http://streamreasoning.org/ontologies/frappe#SyntheticFrame"></see></summary>
    let SyntheticFrame = _prefix "SyntheticFrame"
    /// <summary>
    /// Activity to create new Synthetic Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#Synthetize"></see></summary>
    let Synthetize = _prefix "Synthetize"
    /// <summary>
    /// Relates a Frame with its Pixels
    /// <see href="http://streamreasoning.org/ontologies/frappe#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://streamreasoning.org/ontologies/frappe#hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Relates a Pixel with its Frame
    /// <see href="http://streamreasoning.org/ontologies/frappe#isIn"></see></summary>
    let isIn = _prefix "isIn"
    /// <summary>
    /// Relates a Place with its Events
    /// <see href="http://streamreasoning.org/ontologies/frappe#isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// Relates a Cell with its Pixels
    /// <see href="http://streamreasoning.org/ontologies/frappe#isReferredBy"></see></summary>
    let isReferredBy = _prefix "isReferredBy"
    /// <summary>
    /// Relates an Event with its Pixel
    /// <see href="http://streamreasoning.org/ontologies/frappe#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Relates Pixel to its Cell
    /// <see href="http://streamreasoning.org/ontologies/frappe#refers"></see></summary>
    let refers = _prefix "refers"
    /// <summary>
    /// Relates a Frame with its creation Instant
    /// <see href="http://streamreasoning.org/ontologies/frappe#samplingTime"></see></summary>
    let samplingTime = _prefix "samplingTime"
    /// <summary>
    /// Relate a Capture Frame to the time interval needed to capture a minimum quantity of data
    /// <see href="http://streamreasoning.org/ontologies/frappe#timeExposure"></see></summary>
    let timeExposure = _prefix "timeExposure"
    /// <summary>
    /// Relates a Frame to a Grid
    /// <see href="http://streamreasoning.org/ontologies/frappe#wasCapturedFrom"></see></summary>
    let wasCapturedFrom = _prefix "wasCapturedFrom"
    /// <summary>
    /// Relates a Synthetic Frame to the elements needed to the Synthetization
    /// <see href="http://streamreasoning.org/ontologies/frappe#wasSynthetizedFrom"></see></summary>
    let wasSynthetizedFrom = _prefix "wasSynthetizedFrom"

namespace http.purl.org.dc.dcmitype.slash

open DoxAletheia

module dcmitype =
    let _namespace_name = "http://purl.org/dc/dcmitype/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An aggregation of resources.
    /// <see href="http://purl.org/dc/dcmitype/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// Data encoded in a defined structure.
    /// <see href="http://purl.org/dc/dcmitype/Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A non-persistent, time-based occurrence.
    /// <see href="http://purl.org/dc/dcmitype/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// A visual representation other than text.
    /// <see href="http://purl.org/dc/dcmitype/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A resource requiring interaction from the user to be understood, executed, or experienced.
    /// <see href="http://purl.org/dc/dcmitype/InteractiveResource"></see></summary>
    let InteractiveResource = _prefix "InteractiveResource"
    /// <summary>
    /// A series of visual representations imparting an impression of motion when shown in succession.
    /// <see href="http://purl.org/dc/dcmitype/MovingImage"></see></summary>
    let MovingImage = _prefix "MovingImage"
    /// <summary>
    /// An inanimate, three-dimensional object or substance.
    /// <see href="http://purl.org/dc/dcmitype/PhysicalObject"></see></summary>
    let PhysicalObject = _prefix "PhysicalObject"
    /// <summary>
    /// A system that provides one or more functions.
    /// <see href="http://purl.org/dc/dcmitype/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A computer program in source or compiled form.
    /// <see href="http://purl.org/dc/dcmitype/Software"></see></summary>
    let Software = _prefix "Software"
    /// <summary>
    /// A resource primarily intended to be heard.
    /// <see href="http://purl.org/dc/dcmitype/Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    /// A static visual representation.
    /// <see href="http://purl.org/dc/dcmitype/StillImage"></see></summary>
    let StillImage = _prefix "StillImage"
    /// <summary>
    /// A resource consisting primarily of words for reading.
    /// <see href="http://purl.org/dc/dcmitype/Text"></see></summary>
    let Text = _prefix "Text"

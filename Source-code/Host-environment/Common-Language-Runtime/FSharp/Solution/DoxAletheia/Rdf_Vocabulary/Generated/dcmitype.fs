namespace http.purl.org.dc.dcmitype.slash

open DoxAletheia.Rdf_Vocabulary

module dcmitype =
    let _namespace_name = "http://purl.org/dc/dcmitype/"
    /// <summary>
    /// An aggregation of resources.
    /// <see href="http://purl.org/dc/dcmitype/Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// Data encoded in a defined structure.
    /// <see href="http://purl.org/dc/dcmitype/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    /// A non-persistent, time-based occurrence.
    /// <see href="http://purl.org/dc/dcmitype/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// A visual representation other than text.
    /// <see href="http://purl.org/dc/dcmitype/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// A resource requiring interaction from the user to be understood, executed, or experienced.
    /// <see href="http://purl.org/dc/dcmitype/InteractiveResource"></see></summary>
    let InteractiveResource =
        Namespaced_IRI.parse _namespace_name "InteractiveResource" |> NamespacedName

    /// <summary>
    /// A series of visual representations imparting an impression of motion when shown in succession.
    /// <see href="http://purl.org/dc/dcmitype/MovingImage"></see></summary>
    let MovingImage =
        Namespaced_IRI.parse _namespace_name "MovingImage" |> NamespacedName

    /// <summary>
    /// An inanimate, three-dimensional object or substance.
    /// <see href="http://purl.org/dc/dcmitype/PhysicalObject"></see></summary>
    let PhysicalObject =
        Namespaced_IRI.parse _namespace_name "PhysicalObject" |> NamespacedName

    /// <summary>
    /// A system that provides one or more functions.
    /// <see href="http://purl.org/dc/dcmitype/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// A computer program in source or compiled form.
    /// <see href="http://purl.org/dc/dcmitype/Software"></see></summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
    /// <summary>
    /// A resource primarily intended to be heard.
    /// <see href="http://purl.org/dc/dcmitype/Sound"></see></summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName
    /// <summary>
    /// A static visual representation.
    /// <see href="http://purl.org/dc/dcmitype/StillImage"></see></summary>
    let StillImage = Namespaced_IRI.parse _namespace_name "StillImage" |> NamespacedName
    /// <summary>
    /// A resource consisting primarily of words for reading.
    /// <see href="http://purl.org/dc/dcmitype/Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

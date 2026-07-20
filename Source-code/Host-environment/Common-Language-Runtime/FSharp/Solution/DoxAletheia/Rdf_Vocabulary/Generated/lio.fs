namespace http.purl.org.net.lio.hash

open DoxAletheia

module lio =
    let _namespace_name = "http://purl.org/net/lio#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An image. Any PictorialElement that is considered to be a complete image. Typically the main subject of an ImageSnippets description will be in this class. An image can be a visualPartOf another image.
    /// <see href="http://purl.org/net/lio#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    ///  Any visual entity; any graphical item, part, or visual property of an image or part of an image, including the image itself. Examples include lines, areas, colors and textures. Pictorial elements may have arbitrarily complex shapes and may be implicit, e.g. lines of perspective or outlined white spaces. Rectangular regions of an image are pictorial elements, and the entire image is also. Thus, Image is a subclass of PictorialElement. PictorialElements may be included in one another, giving a simple mereology of visual forms, with the property visualPartOf. Non-visual properties such as date or manner of creation are not considered to be PictorialElements. A property or aspect of an image can be considered to be a PictorialElment when it can be apprehended by vision alone.
    /// <see href="http://purl.org/net/lio#PictorialElement"></see></summary>
    let PictorialElement = _prefix "PictorialElement"
    /// <summary>
    /// Relationship between an image and an emotion, mood or idea that it can be said to illustrate without actually depicting. FOr example, a Picasso blue period painting might convey sadness.
    /// <see href="http://purl.org/net/lio#conveys"></see></summary>
    let conveys = _prefix "conveys"
    /// <summary>
    /// Anything depicted by an image. Subproperty of lio:shows. Depiction does not imply looking like, eg an Xray of a chest can be said to depict the patient. As an intuitive guide, an image depicts anything it can be said to be a picture of.
    /// <see href="http://purl.org/net/lio#depicts"></see></summary>
    let depicts = _prefix "depicts"
    /// <summary>
    ///  Anything in the scene depicted by an image, and which is visible in the image. Meant to include incidental depictions as well as any main subjects. For example, a tree in the background of a portrait, or a person in the crowd at a parade. Images may show many things that the images are not a picture of.
    /// <see href="http://purl.org/net/lio#shows"></see></summary>
    let shows = _prefix "shows"
    /// <summary>
    /// Relationship between an image and a pictorial element in the image (a line, shape, form, texture) which is used for pictorial or artistic effect.
    /// <see href="http://purl.org/net/lio#hasArtisticElement"></see></summary>
    let hasArtisticElement = _prefix "hasArtisticElement"
    /// <summary>
    /// Relation between an image and the background of the scene depicted by the image, for example distant mountains. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class, eg http://dbpedia.org/resource/Mountain.
    /// <see href="http://purl.org/net/lio#hasDepictedBackground"></see></summary>
    let hasDepictedBackground = _prefix "hasDepictedBackground"
    /// <summary>
    /// Relationship between an image and something visible in the background of the scene depicted by the image.
    /// <see href="http://purl.org/net/lio#hasInBackground"></see></summary>
    let hasInBackground = _prefix "hasInBackground"
    /// <summary>
    /// Relationship between an image and something visible in the foreground of the scene depicted by the image.
    /// <see href="http://purl.org/net/lio#hasInForeground"></see></summary>
    let hasInForeground = _prefix "hasInForeground"
    /// <summary>
    /// The pictorial (surface) background of the image itself. For example, the ground surface of a drawing. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class.
    /// <see href="http://purl.org/net/lio#hasPictorialBackground"></see></summary>
    let hasPictorialBackground = _prefix "hasPictorialBackground"
    /// <summary>
    /// Circumstances or general location which provide a context within which the image was created. This may be a location or an event, such as http://dbpedia.org/resource/Millennium_March_on_Washington. It need not be depicted in the image explicitly. As with looksLike, when the value is a class or skos:concept, this is understood to mean a typical instance of the class, eg a photograph taken in a kitchen hasSetting http://http://dbpedia.org/resource/Kitchen.
    /// <see href="http://purl.org/net/lio#hasSetting"></see></summary>
    let hasSetting = _prefix "hasSetting"
    /// <summary>
    /// used to attach image tags within RDFa. Value is a single tag, not a list or sequence of tags.
    /// <see href="http://purl.org/net/lio#hasTag"></see></summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    /// The inverse of the part-of relation on visual elements.
    /// <see href="http://purl.org/net/lio#hasVisualPart"></see></summary>
    let hasVisualPart = _prefix "hasVisualPart"
    /// <summary>
    ///   <see href="http://purl.org/net/lio#visualPartOf"></see>
    /// </summary>
    let visualPartOf = _prefix "visualPartOf"
    /// <summary>
    /// used to attach information about the sublocation where the image was created. This could refer to any geographical level or be less precisely individuated than a traditional geographical hierarchy.
    /// <see href="http://purl.org/net/lio#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Characterization of something in terms of what it resembles or appears to be a representation of.  Examples include 'an outline of a man', a hand shape, etc.. Note, this property has a special meaning when applied to classes. When the value is a class or skos:category, this means that the visual element is a 'typical' or archetypical or iconic shape for an item in that class, such as a typical elephant outline. When the value is an individual, this means that the element visually resembles the individual, eg a profile of George Washington.
    ///
    /// <see href="http://purl.org/net/lio#looksLike"></see></summary>
    let looksLike = _prefix "looksLike"
    /// <summary>
    /// used to attach information about the materials used in the work. Intended to be synchronized with the Visual Resources Association vocabulary.
    /// <see href="http://purl.org/net/lio#materials"></see></summary>
    let materials = _prefix "materials"
    /// <summary>
    /// used to attach information about the style of the work. Intended to be synchronized with the Visual Resources Association vocabulary.
    /// <see href="http://purl.org/net/lio#style"></see></summary>
    let style = _prefix "style"
    /// <summary>
    /// used to attach information about the technique used in the work. Intended to be synchronized with the Visual Resources Association vocabulary.
    /// <see href="http://purl.org/net/lio#technique"></see></summary>
    let technique = _prefix "technique"
    /// <summary>
    /// Relationship between an image and something visible (depicted or shown) in the image when that thing is used for pictorial or artistic effect.
    /// <see href="http://purl.org/net/lio#usesPictorially"></see></summary>
    let usesPictorially = _prefix "usesPictorially"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/lio#" "lio"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : An image. Any PictorialElement that is considered to be a complete image. Typically the main subject of an ImageSnippets description will be in this class. An image can be a visualPartOf another image.</para>
    ///   <a href="http://purl.org/net/lio#Image">lio:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Pictorial element</para>
    ///   <para>rdfs:comment :  Any visual entity; any graphical item, part, or visual property of an image or part of an image, including the image itself. Examples include lines, areas, colors and textures. Pictorial elements may have arbitrarily complex shapes and may be implicit, e.g. lines of perspective or outlined white spaces. Rectangular regions of an image are pictorial elements, and the entire image is also. Thus, Image is a subclass of PictorialElement. PictorialElements may be included in one another, giving a simple mereology of visual forms, with the property visualPartOf. Non-visual properties such as date or manner of creation are not considered to be PictorialElements. A property or aspect of an image can be considered to be a PictorialElment when it can be apprehended by vision alone.</para>
    ///   <a href="http://purl.org/net/lio#PictorialElement">lio:PictorialElement</a>
    /// </summary>
    let PictorialElement = _prefixId.prefix "PictorialElement"
    /// <summary>
    ///   <para>rdfs:label : conveys</para>
    ///   <para>rdfs:comment : Relationship between an image and an emotion, mood or idea that it can be said to illustrate without actually depicting. FOr example, a Picasso blue period painting might convey sadness.</para>
    ///   <a href="http://purl.org/net/lio#conveys">lio:conveys</a>
    /// </summary>
    let conveys = _prefixId.prefix "conveys"
    /// <summary>
    ///   <para>rdfs:label : depicts</para>
    ///   <para>rdfs:comment : Anything depicted by an image. Subproperty of lio:shows. Depiction does not imply looking like, eg an Xray of a chest can be said to depict the patient. As an intuitive guide, an image depicts anything it can be said to be a picture of. </para>
    ///   <a href="http://purl.org/net/lio#depicts">lio:depicts</a>
    /// </summary>
    let depicts = _prefixId.prefix "depicts"
    /// <summary>
    ///   <para>rdfs:label : has artistic element</para>
    ///   <para>rdfs:comment : Relationship between an image and a pictorial element in the image (a line, shape, form, texture) which is used for pictorial or artistic effect. </para>
    ///   <a href="http://purl.org/net/lio#hasArtisticElement">lio:hasArtisticElement</a>
    /// </summary>
    let hasArtisticElement = _prefixId.prefix "hasArtisticElement"
    /// <summary>
    ///   <para>rdfs:label : has depicted background</para>
    ///   <para>rdfs:comment : Relation between an image and the background of the scene depicted by the image, for example distant mountains. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class, eg http://dbpedia.org/resource/Mountain. </para>
    ///   <a href="http://purl.org/net/lio#hasDepictedBackground">lio:hasDepictedBackground</a>
    /// </summary>
    let hasDepictedBackground = _prefixId.prefix "hasDepictedBackground"
    /// <summary>
    ///   <para>rdfs:label : has in background</para>
    ///   <para>rdfs:comment : Relationship between an image and something visible in the background of the scene depicted by the image.</para>
    ///   <a href="http://purl.org/net/lio#hasInBackground">lio:hasInBackground</a>
    /// </summary>
    let hasInBackground = _prefixId.prefix "hasInBackground"
    /// <summary>
    ///   <para>rdfs:label : has in foreground</para>
    ///   <para>rdfs:comment : Relationship between an image and something visible in the foreground of the scene depicted by the image. </para>
    ///   <a href="http://purl.org/net/lio#hasInForeground">lio:hasInForeground</a>
    /// </summary>
    let hasInForeground = _prefixId.prefix "hasInForeground"
    /// <summary>
    ///   <para>rdfs:label : has pictorial background</para>
    ///   <para>rdfs:comment : The pictorial (surface) background of the image itself. For example, the ground surface of a drawing. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class. </para>
    ///   <a href="http://purl.org/net/lio#hasPictorialBackground">lio:hasPictorialBackground</a>
    /// </summary>
    let hasPictorialBackground = _prefixId.prefix "hasPictorialBackground"
    /// <summary>
    ///   <para>rdfs:label : has setting</para>
    ///   <para>rdfs:comment : Circumstances or general location which provide a context within which the image was created. This may be a location or an event, such as http://dbpedia.org/resource/Millennium_March_on_Washington. It need not be depicted in the image explicitly. As with looksLike, when the value is a class or skos:concept, this is understood to mean a typical instance of the class, eg a photograph taken in a kitchen hasSetting http://http://dbpedia.org/resource/Kitchen. </para>
    ///   <a href="http://purl.org/net/lio#hasSetting">lio:hasSetting</a>
    /// </summary>
    let hasSetting = _prefixId.prefix "hasSetting"
    /// <summary>
    ///   <para>rdfs:label : has tag</para>
    ///   <para>rdfs:comment : used to attach image tags within RDFa. Value is a single tag, not a list or sequence of tags. </para>
    ///   <a href="http://purl.org/net/lio#hasTag">lio:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:label : has visual part</para>
    ///   <para>rdfs:comment : The inverse of the part-of relation on visual elements. </para>
    ///   <a href="http://purl.org/net/lio#hasVisualPart">lio:hasVisualPart</a>
    /// </summary>
    let hasVisualPart = _prefixId.prefix "hasVisualPart"
    /// <summary>
    ///   <para>rdfs:label : location</para>
    ///   <para>rdfs:comment : used to attach information about the sublocation where the image was created. This could refer to any geographical level or be less precisely individuated than a traditional geographical hierarchy. </para>
    ///   <a href="http://purl.org/net/lio#location">lio:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : looks like</para>
    ///   <para>rdfs:comment : Characterization of something in terms of what it resembles or appears to be a representation of.  Examples include 'an outline of a man', a hand shape, etc.. Note, this property has a special meaning when applied to classes. When the value is a class or skos:category, this means that the visual element is a 'typical' or archetypical or iconic shape for an item in that class, such as a typical elephant outline. When the value is an individual, this means that the element visually resembles the individual, eg a profile of George Washington.
    ///     </para>
    ///   <a href="http://purl.org/net/lio#looksLike">lio:looksLike</a>
    /// </summary>
    let looksLike = _prefixId.prefix "looksLike"
    /// <summary>
    ///   <para>rdfs:label : materials</para>
    ///   <para>rdfs:comment : used to attach information about the materials used in the work. Intended to be synchronized with the Visual Resources Association vocabulary. </para>
    ///   <a href="http://purl.org/net/lio#materials">lio:materials</a>
    /// </summary>
    let materials = _prefixId.prefix "materials"
    /// <summary>
    ///   <para>rdfs:label : shows</para>
    ///   <para>rdfs:comment :  Anything in the scene depicted by an image, and which is visible in the image. Meant to include incidental depictions as well as any main subjects. For example, a tree in the background of a portrait, or a person in the crowd at a parade. Images may show many things that the images are not a picture of. </para>
    ///   <a href="http://purl.org/net/lio#shows">lio:shows</a>
    /// </summary>
    let shows = _prefixId.prefix "shows"
    /// <summary>
    ///   <para>rdfs:label : style</para>
    ///   <para>rdfs:comment : used to attach information about the style of the work. Intended to be synchronized with the Visual Resources Association vocabulary. </para>
    ///   <a href="http://purl.org/net/lio#style">lio:style</a>
    /// </summary>
    let style = _prefixId.prefix "style"
    /// <summary>
    ///   <para>rdfs:label : technique</para>
    ///   <para>rdfs:comment : used to attach information about the technique used in the work. Intended to be synchronized with the Visual Resources Association vocabulary. </para>
    ///   <a href="http://purl.org/net/lio#technique">lio:technique</a>
    /// </summary>
    let technique = _prefixId.prefix "technique"
    /// <summary>
    ///   <para>rdfs:label : uses pictorially</para>
    ///   <para>rdfs:comment : Relationship between an image and something visible (depicted or shown) in the image when that thing is used for pictorial or artistic effect. </para>
    ///   <a href="http://purl.org/net/lio#usesPictorially">lio:usesPictorially</a>
    /// </summary>
    let usesPictorially = _prefixId.prefix "usesPictorially"
    /// <summary>
    ///   <para>rdfs:label : visual part of</para>
    ///   <a href="http://purl.org/net/lio#visualPartOf">lio:visualPartOf</a>
    /// </summary>
    let visualPartOf = _prefixId.prefix "visualPartOf"

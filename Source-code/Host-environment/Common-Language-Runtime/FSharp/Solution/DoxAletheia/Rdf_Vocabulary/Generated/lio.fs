namespace http.purl.org.net.lio.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lio =
    let _namespace_iri = Namespace_Iri lio |> NamespaceIRI
    /// <summary>
    ///   <para>lio:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An image. Any PictorialElement that is considered to be a complete image. Typically the main subject of an ImageSnippets description will be in this class. An image can be a visualPartOf another image."</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#Image">http://purl.org/net/lio#Image</seealso>
    let Image = Prefixed_Name(lio, "Image") |> PrefixedName
    /// <summary>
    ///   <para>lio:PictorialElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Any visual entity; any graphical item, part, or visual property of an image or part of an image, including the image itself. Examples include lines, areas, colors and textures. Pictorial elements may have arbitrarily complex shapes and may be implicit, e.g. lines of perspective or outlined white spaces. Rectangular regions of an image are pictorial elements, and the entire image is also. Thus, Image is a subclass of PictorialElement. PictorialElements may be included in one another, giving a simple mereology of visual forms, with the property visualPartOf. Non-visual properties such as date or manner of creation are not considered to be PictorialElements. A property or aspect of an image can be considered to be a PictorialElment when it can be apprehended by vision alone."</para>
    /// labels<para>"Pictorial element"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#PictorialElement">http://purl.org/net/lio#PictorialElement</seealso>
    let PictorialElement = Prefixed_Name(lio, "PictorialElement") |> PrefixedName
    /// <summary>
    ///   <para>lio:conveys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an image and an emotion, mood or idea that it can be said to illustrate without actually depicting. FOr example, a Picasso blue period painting might convey sadness."</para>
    /// labels<para>"conveys"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#conveys">http://purl.org/net/lio#conveys</seealso>
    let conveys = Prefixed_Name(lio, "conveys") |> PrefixedName
    /// <summary>
    ///   <para>lio:depicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Anything depicted by an image. Subproperty of lio:shows. Depiction does not imply looking like, eg an Xray of a chest can be said to depict the patient. As an intuitive guide, an image depicts anything it can be said to be a picture of. "</para>
    /// labels<para>"depicts"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#depicts">http://purl.org/net/lio#depicts</seealso>
    let depicts = Prefixed_Name(lio, "depicts") |> PrefixedName
    /// <summary>
    ///   <para>lio:hasArtisticElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an image and a pictorial element in the image (a line, shape, form, texture) which is used for pictorial or artistic effect. "</para>
    /// labels<para>"has artistic element"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasArtisticElement">http://purl.org/net/lio#hasArtisticElement</seealso>
    let hasArtisticElement = Prefixed_Name(lio, "hasArtisticElement") |> PrefixedName

    /// <summary>
    ///   <para>lio:hasDepictedBackground</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between an image and the background of the scene depicted by the image, for example distant mountains. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class, eg http://dbpedia.org/resource/Mountain. "</para>
    /// labels<para>"has depicted background"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasDepictedBackground">http://purl.org/net/lio#hasDepictedBackground</seealso>
    let hasDepictedBackground =
        Prefixed_Name(lio, "hasDepictedBackground") |> PrefixedName

    /// <summary>
    ///   <para>lio:hasInBackground</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an image and something visible in the background of the scene depicted by the image."</para>
    /// labels<para>"has in background"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasInBackground">http://purl.org/net/lio#hasInBackground</seealso>
    let hasInBackground = Prefixed_Name(lio, "hasInBackground") |> PrefixedName
    /// <summary>
    ///   <para>lio:hasInForeground</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an image and something visible in the foreground of the scene depicted by the image. "</para>
    /// labels<para>"has in foreground"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasInForeground">http://purl.org/net/lio#hasInForeground</seealso>
    let hasInForeground = Prefixed_Name(lio, "hasInForeground") |> PrefixedName

    /// <summary>
    ///   <para>lio:hasPictorialBackground</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The pictorial (surface) background of the image itself. For example, the ground surface of a drawing. Not all images need have such a background. As with looksLike, when the value is a class or skos:Concept, this means a typical element of that class. "</para>
    /// labels<para>"has pictorial background"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasPictorialBackground">http://purl.org/net/lio#hasPictorialBackground</seealso>
    let hasPictorialBackground =
        Prefixed_Name(lio, "hasPictorialBackground") |> PrefixedName

    /// <summary>
    ///   <para>lio:hasSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Circumstances or general location which provide a context within which the image was created. This may be a location or an event, such as http://dbpedia.org/resource/Millennium_March_on_Washington. It need not be depicted in the image explicitly. As with looksLike, when the value is a class or skos:concept, this is understood to mean a typical instance of the class, eg a photograph taken in a kitchen hasSetting http://http://dbpedia.org/resource/Kitchen. "</para>
    /// labels<para>"has setting"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasSetting">http://purl.org/net/lio#hasSetting</seealso>
    let hasSetting = Prefixed_Name(lio, "hasSetting") |> PrefixedName
    /// <summary>
    ///   <para>lio:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to attach image tags within RDFa. Value is a single tag, not a list or sequence of tags. "</para>
    /// labels<para>"has tag"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasTag">http://purl.org/net/lio#hasTag</seealso>
    let hasTag = Prefixed_Name(lio, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>lio:hasVisualPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The inverse of the part-of relation on visual elements. "</para>
    /// labels<para>"has visual part"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#hasVisualPart">http://purl.org/net/lio#hasVisualPart</seealso>
    let hasVisualPart = Prefixed_Name(lio, "hasVisualPart") |> PrefixedName
    /// <summary>
    ///   <para>lio:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to attach information about the sublocation where the image was created. This could refer to any geographical level or be less precisely individuated than a traditional geographical hierarchy. "</para>
    /// labels<para>"location"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#location">http://purl.org/net/lio#location</seealso>
    let location = Prefixed_Name(lio, "location") |> PrefixedName
    /// <summary>
    ///   <para>lio:looksLike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Characterization of something in terms of what it resembles or appears to be a representation of.  Examples include 'an outline of a man', a hand shape, etc.. Note, this property has a special meaning when applied to classes. When the value is a class or skos:category, this means that the visual element is a 'typical' or archetypical or iconic shape for an item in that class, such as a typical elephant outline. When the value is an individual, this means that the element visually resembles the individual, eg a profile of George Washington.
    ///     "</para>
    /// labels<para>"looks like"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#looksLike">http://purl.org/net/lio#looksLike</seealso>
    let looksLike = Prefixed_Name(lio, "looksLike") |> PrefixedName
    /// <summary>
    ///   <para>lio:materials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to attach information about the materials used in the work. Intended to be synchronized with the Visual Resources Association vocabulary. "</para>
    /// labels<para>"materials"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#materials">http://purl.org/net/lio#materials</seealso>
    let materials = Prefixed_Name(lio, "materials") |> PrefixedName
    /// <summary>
    ///   <para>lio:shows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>" Anything in the scene depicted by an image, and which is visible in the image. Meant to include incidental depictions as well as any main subjects. For example, a tree in the background of a portrait, or a person in the crowd at a parade. Images may show many things that the images are not a picture of. "</para>
    /// labels<para>"shows"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#shows">http://purl.org/net/lio#shows</seealso>
    let shows = Prefixed_Name(lio, "shows") |> PrefixedName
    /// <summary>
    ///   <para>lio:style</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to attach information about the style of the work. Intended to be synchronized with the Visual Resources Association vocabulary. "</para>
    /// labels<para>"style"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#style">http://purl.org/net/lio#style</seealso>
    let style = Prefixed_Name(lio, "style") |> PrefixedName
    /// <summary>
    ///   <para>lio:technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"used to attach information about the technique used in the work. Intended to be synchronized with the Visual Resources Association vocabulary. "</para>
    /// labels<para>"technique"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#technique">http://purl.org/net/lio#technique</seealso>
    let technique = Prefixed_Name(lio, "technique") |> PrefixedName
    /// <summary>
    ///   <para>lio:usesPictorially</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an image and something visible (depicted or shown) in the image when that thing is used for pictorial or artistic effect. "</para>
    /// labels<para>"uses pictorially"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#usesPictorially">http://purl.org/net/lio#usesPictorially</seealso>
    let usesPictorially = Prefixed_Name(lio, "usesPictorially") |> PrefixedName
    /// <summary>
    ///   <para>lio:visualPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"visual part of"</para></remarks>
    /// <seealso href="http://purl.org/net/lio#visualPartOf">http://purl.org/net/lio#visualPartOf</seealso>
    let visualPartOf = Prefixed_Name(lio, "visualPartOf") |> PrefixedName

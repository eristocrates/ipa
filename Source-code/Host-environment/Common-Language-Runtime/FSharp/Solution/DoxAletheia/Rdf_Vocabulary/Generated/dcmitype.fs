namespace http.purl.org.dc.dcmitype.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcmitype =
    let _namespace_iri = Namespace_Iri dcmitype |> NamespaceIRI
    /// <summary>
    ///   <para>dcmitype:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An aggregation of resources.</para>
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Collection">http://purl.org/dc/dcmitype/Collection</seealso>
    let Collection = Prefixed_Name(dcmitype, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A visual representation other than text.</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Image">http://purl.org/dc/dcmitype/Image</seealso>
    let Image = Prefixed_Name(dcmitype, "Image") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Data encoded in a defined structure.</para>
    /// labels<para>Dataset</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Dataset">http://purl.org/dc/dcmitype/Dataset</seealso>
    let Dataset = Prefixed_Name(dcmitype, "Dataset") |> PrefixedName

    /// <summary>
    ///   <para>dcmitype:InteractiveResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource requiring interaction from the user to be understood, executed, or experienced.</para>
    /// labels<para>Interactive Resource</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/InteractiveResource">http://purl.org/dc/dcmitype/InteractiveResource</seealso>
    let InteractiveResource =
        Prefixed_Name(dcmitype, "InteractiveResource") |> PrefixedName

    /// <summary>
    ///   <para>dcmitype:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An inanimate, three-dimensional object or substance.</para>
    /// labels<para>Physical Object</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/PhysicalObject">http://purl.org/dc/dcmitype/PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(dcmitype, "PhysicalObject") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A series of visual representations imparting an impression of motion when shown in succession.</para>
    /// labels<para>Moving Image</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/MovingImage">http://purl.org/dc/dcmitype/MovingImage</seealso>
    let MovingImage = Prefixed_Name(dcmitype, "MovingImage") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A computer program in source or compiled form.</para>
    /// labels<para>Software</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Software">http://purl.org/dc/dcmitype/Software</seealso>
    let Software = Prefixed_Name(dcmitype, "Software") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:StillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A static visual representation.</para>
    /// labels<para>Still Image</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/StillImage">http://purl.org/dc/dcmitype/StillImage</seealso>
    let StillImage = Prefixed_Name(dcmitype, "StillImage") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A system that provides one or more functions.</para>
    /// labels<para>Service</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Service">http://purl.org/dc/dcmitype/Service</seealso>
    let Service = Prefixed_Name(dcmitype, "Service") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource primarily intended to be heard.</para>
    /// labels<para>Sound</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Sound">http://purl.org/dc/dcmitype/Sound</seealso>
    let Sound = Prefixed_Name(dcmitype, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource consisting primarily of words for reading.</para>
    /// labels<para>Text</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Text">http://purl.org/dc/dcmitype/Text</seealso>
    let Text = Prefixed_Name(dcmitype, "Text") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/">http://purl.org/dc/dcmitype/</seealso>
    let _prefix_iri = Prefixed_Name(dcmitype, "") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A non-persistent, time-based occurrence.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Event">http://purl.org/dc/dcmitype/Event</seealso>
    let Event = Prefixed_Name(dcmitype, "Event") |> PrefixedName

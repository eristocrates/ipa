namespace http.purl.org.dc.dcmitype.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dcmitype =
    let _namespace_iri = Namespace_Iri dcmitype |> NamespaceIRI
    /// <summary>
    ///   <para>dcmitype:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/">http://purl.org/dc/dcmitype/</seealso>
    let _prefix_iri = Prefixed_Name(dcmitype, "") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Agent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Agent">http://purl.org/dc/dcmitype/Agent</seealso>
    let Agent = Prefixed_Name(dcmitype, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection is an aggregation of items. The term
    /// 		collection means that the resource is described as a
    /// 		group; its parts may be separately described and navigated."</para>
    ///   <para>"An aggregation of resources."</para>
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Collection">http://purl.org/dc/dcmitype/Collection</seealso>
    let Collection = Prefixed_Name(dcmitype, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A dataset is information encoded in a defined structure
    /// 		(for example, lists, tables, and databases), intended to
    /// 		be useful for direct machine processing."</para>
    ///   <para>"Data encoded in a defined structure. Examples include lists, tables, and databases. A dataset may be useful for direct machine processing."</para>
    ///   <para>"Data encoded in a defined structure."</para>
    /// labels<para>"Dataset"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Dataset">http://purl.org/dc/dcmitype/Dataset</seealso>
    let Dataset = Prefixed_Name(dcmitype, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An event is a non-persistent, time-based occurrence.
    /// 		Metadata for an event provides descriptive
    /// 		information that is the basis for discovery of the
    /// 		purpose, location, duration, responsible agents, and
    /// 		links to related events and resources.  The resource
    /// 		of type event may not be retrievable if the described
    /// 		instantiation has expired or is yet to occur.
    /// 		Examples - exhibition, web-cast, conference,
    /// 		workshop, open-day, performance, battle, trial,
    /// 		wedding, tea-party, conflagration."</para>
    ///   <para>"A non-persistent, time-based occurrence."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Event">http://purl.org/dc/dcmitype/Event</seealso>
    let Event = Prefixed_Name(dcmitype, "Event") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:Class</para>
    ///   <para>"An image is a primarily symbolic visual representation
    /// 		other than text. For example - images and photographs of
    /// 		physical objects, paintings, prints, drawings, other
    /// 		images and graphics, animations and moving pictures,
    /// 		film, diagrams, maps, musical notation. Note that image
    /// 		may include both electronic and physical representations."</para>
    ///   <para>"A visual representation other than text."</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Image">http://purl.org/dc/dcmitype/Image</seealso>
    let Image = Prefixed_Name(dcmitype, "Image") |> PrefixedName

    /// <summary>
    ///   <para>dcmitype:InteractiveResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An interactive resource is a resource which requires
    /// 		interaction from the user to be understood, executed,
    /// 		or experienced. For example - forms on web pages, applets,
    /// 		multimedia learning objects, chat services, virtual
    /// 		reality."</para>
    ///   <para>"A resource requiring interaction from the user to be understood, executed, or experienced."</para>
    /// labels<para>"Interactive Resource"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/InteractiveResource">http://purl.org/dc/dcmitype/InteractiveResource</seealso>
    let InteractiveResource =
        Prefixed_Name(dcmitype, "InteractiveResource") |> PrefixedName

    /// <summary>
    ///   <para>dcmitype:MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A series of visual representations imparting an impression of motion when shown in succession."</para>
    ///   <para>"A series of visual representations that,
    ///         when shown in succession, impart an impression
    ///         of motion.  Examples of moving images are:
    ///         animations, movies, television programs,
    ///         videos, zoetropes, or visual output from
    ///         a simulation."</para>
    /// labels<para>"Moving Image"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/MovingImage">http://purl.org/dc/dcmitype/MovingImage</seealso>
    let MovingImage = Prefixed_Name(dcmitype, "MovingImage") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>owl:Class</para>
    ///   <para>"An inanimate, three-dimensional object or substance.
    /// 		For example -- a computer, the great pyramid, a
    /// 		sculpture.  Note that digital representations
    /// 		of, or surrogates for, these things should use Image,
    /// 		Text or one of the other types."</para>
    ///   <para>"An inanimate, three-dimensional object or substance."</para>
    /// labels<para>"Physical Object"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/PhysicalObject">http://purl.org/dc/dcmitype/PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(dcmitype, "PhysicalObject") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A service is a system that provides one or more
    /// 		functions of value to the end-user. Examples include:
    /// 		a photocopying service, a banking service, an
    /// 		authentication service, interlibrary loans, a Z39.50
    /// 		or Web server."</para>
    ///   <para>"A system that provides one or more functions."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Service">http://purl.org/dc/dcmitype/Service</seealso>
    let Service = Prefixed_Name(dcmitype, "Service") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A computer program in source or compiled form."</para>
    ///   <para>"Software is a computer program in source or
    /// 		compiled form which may be available for installation
    /// 		non-transiently on another machine. For software which
    /// 		exists only to create an interactive environment, use
    /// 		interactive instead."</para>
    /// labels<para>"Software"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Software">http://purl.org/dc/dcmitype/Software</seealso>
    let Software = Prefixed_Name(dcmitype, "Software") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>"A sound is a resource whose content is primarily
    /// 		intended to be rendered as audio. For example - a
    /// 		music playback file format, an audio compact disc,
    /// 		and recorded speech or sounds."</para>
    ///   <para>"A resource primarily intended to be heard."</para>
    /// labels<para>"Sound"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Sound">http://purl.org/dc/dcmitype/Sound</seealso>
    let Sound = Prefixed_Name(dcmitype, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:StillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>"A static visual representation. Examples of
    ///         still images are: paintings, drawings, graphic designs,
    ///         plans and maps."</para>
    ///   <para>"A static visual representation."</para>
    /// labels<para>"Still Image"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/StillImage">http://purl.org/dc/dcmitype/StillImage</seealso>
    let StillImage = Prefixed_Name(dcmitype, "StillImage") |> PrefixedName
    /// <summary>
    ///   <para>dcmitype:Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdfs:Class</para>
    ///   <para>dcterms:DCMIType</para>
    ///   <para>"A text is a resource whose content is primarily
    /// 		words for reading. For example - books, letters,
    /// 		dissertations, poems, newspapers, articles,
    /// 		archives of mailing lists. Note that facsimiles
    /// 		or images of texts are still of the genre text."</para>
    ///   <para>"A resource consisting primarily of words for reading."</para>
    /// labels<para>"Text"</para></remarks>
    /// <seealso href="http://purl.org/dc/dcmitype/Text">http://purl.org/dc/dcmitype/Text</seealso>
    let Text = Prefixed_Name(dcmitype, "Text") |> PrefixedName

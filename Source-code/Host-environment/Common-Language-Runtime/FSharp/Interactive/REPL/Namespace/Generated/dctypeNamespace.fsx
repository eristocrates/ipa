#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dctype =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/dc/dcmitype/" "dctype"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : A collection is described as a group; its parts may also be separately described.</para>
    ///   <para>rdfs:comment : An aggregation of resources.</para>
    ///   <para>rdfs:label : Collection</para>
    ///   <a href="http://purl.org/dc/dcmitype/Collection">dctype:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include lists, tables, and databases.  A dataset may be useful for direct machine processing.</para>
    ///   <para>rdfs:comment : Data encoded in a defined structure.</para>
    ///   <para>rdfs:label : Dataset</para>
    ///   <a href="http://purl.org/dc/dcmitype/Dataset">dctype:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Metadata for an event provides descriptive information that is the basis for discovery of the purpose, location, duration, and responsible agents associated with an event. Examples include an exhibition, webcast, conference, workshop, open day, performance, battle, trial, wedding, tea party, conflagration.</para>
    ///   <para>rdfs:comment : A non-persistent, time-based occurrence.</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://purl.org/dc/dcmitype/Event">dctype:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include images and photographs of physical objects, paintings, prints, drawings, other images and graphics, animations and moving pictures, film, diagrams, maps, musical notation.  Note that Image may include both electronic and physical representations.</para>
    ///   <para>rdfs:comment : A visual representation other than text.</para>
    ///   <para>rdfs:label : Image</para>
    ///   <a href="http://purl.org/dc/dcmitype/Image">dctype:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include forms on Web pages, applets, multimedia learning objects, chat services, or virtual reality environments.</para>
    ///   <para>rdfs:comment : A resource requiring interaction from the user to be understood, executed, or experienced.</para>
    ///   <para>rdfs:label : Interactive Resource</para>
    ///   <a href="http://purl.org/dc/dcmitype/InteractiveResource">dctype:InteractiveResource</a>
    /// </summary>
    let InteractiveResource = _prefixId.prefix "InteractiveResource"
    /// <summary>
    ///   <para>rdfs:comment : A series of visual representations imparting an impression of motion when shown in succession.</para>
    ///   <para>dcterms:description : Examples include animations, movies, television programs, videos, zoetropes, or visual output from a simulation.  Instances of the type Moving Image must also be describable as instances of the broader type Image.</para>
    ///   <para>rdfs:label : Moving Image</para>
    ///   <para>dcterms:issued : 2003-11-18^^xsd:date</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <a href="http://purl.org/dc/dcmitype/MovingImage">dctype:MovingImage</a>
    /// </summary>
    let MovingImage = _prefixId.prefix "MovingImage"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2002-07-13^^xsd:date</para>
    ///   <para>dcterms:description : Note that digital representations of, or surrogates for, these objects should use Image, Text or one of the other types.</para>
    ///   <para>rdfs:comment : An inanimate, three-dimensional object or substance.</para>
    ///   <para>rdfs:label : Physical Object</para>
    ///   <a href="http://purl.org/dc/dcmitype/PhysicalObject">dctype:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include a photocopying service, a banking service, an authentication service, interlibrary loans, a Z39.50 or Web server.</para>
    ///   <para>rdfs:comment : A system that provides one or more functions.</para>
    ///   <para>rdfs:label : Service</para>
    ///   <a href="http://purl.org/dc/dcmitype/Service">dctype:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include a C source file, MS-Windows .exe executable, or Perl script.</para>
    ///   <para>rdfs:comment : A computer program in source or compiled form.</para>
    ///   <para>rdfs:label : Software</para>
    ///   <a href="http://purl.org/dc/dcmitype/Software">dctype:Software</a>
    /// </summary>
    let Software = _prefixId.prefix "Software"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include a music playback file format, an audio compact disc, and recorded speech or sounds.</para>
    ///   <para>rdfs:comment : A resource primarily intended to be heard.</para>
    ///   <para>rdfs:label : Sound</para>
    ///   <a href="http://purl.org/dc/dcmitype/Sound">dctype:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>dcterms:description : Examples include paintings, drawings, graphic designs, plans and maps. Recommended best practice is to assign the type Text to images of textual materials. Instances of the type Still Image must also be describable as instances of the broader type Image.</para>
    ///   <para>rdfs:comment : A static visual representation.</para>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>rdfs:label : Still Image</para>
    ///   <para>dcterms:issued : 2003-11-18^^xsd:date</para>
    ///   <a href="http://purl.org/dc/dcmitype/StillImage">dctype:StillImage</a>
    /// </summary>
    let StillImage = _prefixId.prefix "StillImage"
    /// <summary>
    ///   <para>dcterms:modified : 2008-01-14^^xsd:date</para>
    ///   <para>dcterms:issued : 2000-07-11^^xsd:date</para>
    ///   <para>dcterms:description : Examples include books, letters, dissertations, poems, newspapers, articles, archives of mailing lists. Note that facsimiles or images of texts are still of the genre Text.</para>
    ///   <para>rdfs:comment : A resource consisting primarily of words for reading.</para>
    ///   <para>rdfs:label : Text</para>
    ///   <a href="http://purl.org/dc/dcmitype/Text">dctype:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"

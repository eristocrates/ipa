namespace http.www.ics.forth.gr.isl.VoIDWarehouse.VoID_Extension_Schema.owl.bare

open DoxAletheia

module voidwh =
    let _namespace_name =
        "http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Based on the fact that a measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). The Configuration defines the polices with respect to a measurement is carried out. It defines polices about how to compare URIs and the configuration of an entity.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Configuration"></see></summary>
    let ``_#Configuration`` = _prefix "#Configuration"
    /// <summary>
    /// The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#EntityConfiguration"></see></summary>
    let ``_#EntityConfiguration`` = _prefix "#EntityConfiguration"
    /// <summary>
    /// The notion of Measurement is actually a specialization of dc:Event and therefore inherits the property date. A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal).
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Measurement"></see></summary>
    let ``_#Measurement`` = _prefix "#Measurement"
    /// <summary>
    /// A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property indicates the value produced by the measurement.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#producesValue"></see></summary>
    let ``_#producesValue`` = _prefix "#producesValue"
    /// <summary>
    /// A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). Therefore, this property links instances of Measurement class with instances of dataset class.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#over"></see></summary>
    let ``_#over`` = _prefix "#over"
    /// <summary>
    /// A metric is an individual with a URI and is defined by a resource (e.g. the DOI of the scientific paper that defined that metric).
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Metrics"></see></summary>
    let ``_#Metrics`` = _prefix "#Metrics"
    /// <summary>
    /// The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#URIEquivalence"></see></summary>
    let ``_#URIEquivalence`` = _prefix "#URIEquivalence"
    /// <summary>
    /// A measurement is carried out by an agent using a specific metric accordingTo one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of configuation class.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#accordingTo"></see></summary>
    let ``_#accordingTo`` = _prefix "#accordingTo"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#averageDegreeIncrement"></see>
    /// </summary>
    let ``_#averageDegreeIncrement`` = _prefix "#averageDegreeIncrement"
    /// <summary>
    /// A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal).
    /// Therefore, this property links an instance of measurement class with an instance of the Agent class.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#carriedOutBy"></see></summary>
    let ``_#carriedOutBy`` = _prefix "#carriedOutBy"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiterals"></see>
    /// </summary>
    let ``_#commonLiterals`` = _prefix "#commonLiterals"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiteralsPercentage"></see>
    /// </summary>
    let ``_#commonLiteralsPercentage`` = _prefix "#commonLiteralsPercentage"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUris"></see>
    /// </summary>
    let ``_#commonUris`` = _prefix "#commonUris"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUrisPercentage"></see>
    /// </summary>
    let ``_#commonUrisPercentage`` = _prefix "#commonUrisPercentage"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#complementarityFactor"></see>
    /// </summary>
    let ``_#complementarityFactor`` = _prefix "#complementarityFactor"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#entityMatching"></see>
    /// </summary>
    let ``_#entityMatching`` = _prefix "#entityMatching"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#exactStringEquality"></see>
    /// </summary>
    let ``_#exactStringEquality`` = _prefix "#exactStringEquality"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#suffixCanonicalization"></see>
    /// </summary>
    let ``_#suffixCanonicalization`` = _prefix "#suffixCanonicalization"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriples"></see>
    /// </summary>
    let ``_#uniqueTriples`` = _prefix "#uniqueTriples"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriplesPercentage"></see>
    /// </summary>
    let ``_#uniqueTriplesPercentage`` = _prefix "#uniqueTriplesPercentage"
    /// <summary>
    /// A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of metrics class.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesMetrics"></see></summary>
    let ``_#usesMetrics`` = _prefix "#usesMetrics"
    /// <summary>
    /// This property specifies the entities of interest involved in a configuration by providing a SPARQL query that returns them.
    /// <see href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesSPARQLquery"></see></summary>
    let ``_#usesSPARQLquery`` = _prefix "#usesSPARQLquery"

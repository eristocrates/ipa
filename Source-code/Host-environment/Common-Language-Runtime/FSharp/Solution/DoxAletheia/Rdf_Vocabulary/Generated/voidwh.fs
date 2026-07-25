namespace http.www.ics.forth.gr.isl.VoIDWarehouse.VoID_Extension_Schema.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voidwh =
    let _namespace_iri = Namespace_Iri voidwh |> NamespaceIRI
    /// <summary>
    ///   <para>voidwh:#Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Based on the fact that a measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). The Configuration defines the polices with respect to a measurement is carried out. It defines polices about how to compare URIs and the configuration of an entity.</para>
    /// labels<para>Configuration</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Configuration">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Configuration</seealso>
    let ``_#Configuration`` = Prefixed_Name(voidwh, "#Configuration") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#producesValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property indicates the value produced by the measurement.</para>
    /// labels<para>produces Value</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#producesValue">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#producesValue</seealso>
    let ``_#producesValue`` = Prefixed_Name(voidwh, "#producesValue") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#Metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric is an individual with a URI and is defined by a resource (e.g. the DOI of the scientific paper that defined that metric).</para>
    /// labels<para>Metrics</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Metrics">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Metrics</seealso>
    let ``_#Metrics`` = Prefixed_Name(voidwh, "#Metrics") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#averageDegreeIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#averageDegreeIncrement">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#averageDegreeIncrement</seealso>
    let ``_#averageDegreeIncrement`` =
        Prefixed_Name(voidwh, "#averageDegreeIncrement") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#carriedOutBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal).
    /// Therefore, this property links an instance of measurement class with an instance of the Agent class.</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#carriedOutBy">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#carriedOutBy</seealso>
    let ``_#carriedOutBy`` = Prefixed_Name(voidwh, "#carriedOutBy") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#commonLiterals</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiterals">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiterals</seealso>
    let ``_#commonLiterals`` = Prefixed_Name(voidwh, "#commonLiterals") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#complementarityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#complementarityFactor">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#complementarityFactor</seealso>
    let ``_#complementarityFactor`` =
        Prefixed_Name(voidwh, "#complementarityFactor") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#entityMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#URIEquivalence</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#entityMatching">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#entityMatching</seealso>
    let ``_#entityMatching`` = Prefixed_Name(voidwh, "#entityMatching") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#exactStringEquality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#URIEquivalence</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#exactStringEquality">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#exactStringEquality</seealso>
    let ``_#exactStringEquality`` =
        Prefixed_Name(voidwh, "#exactStringEquality") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl</seealso>
    let _prefix_iri = Prefixed_Name(voidwh, "") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The notion of Measurement is actually a specialization of dc:Event and therefore inherits the property date. A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal).</para>
    /// labels<para>Measurement</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Measurement">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Measurement</seealso>
    let ``_#Measurement`` = Prefixed_Name(voidwh, "#Measurement") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#over</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). Therefore, this property links instances of Measurement class with instances of dataset class.</para>
    /// labels<para>over</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#over">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#over</seealso>
    let ``_#over`` = Prefixed_Name(voidwh, "#over") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#accordingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement is carried out by an agent using a specific metric accordingTo one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of configuation class.</para>
    /// labels<para>according To</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#accordingTo">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#accordingTo</seealso>
    let ``_#accordingTo`` = Prefixed_Name(voidwh, "#accordingTo") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#EntityConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them.</para>
    /// labels<para>Entity Configuration</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#EntityConfiguration">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#EntityConfiguration</seealso>
    let ``_#EntityConfiguration`` =
        Prefixed_Name(voidwh, "#EntityConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#URIEquivalence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them.</para>
    /// labels<para>URI Equivalence</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#URIEquivalence">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#URIEquivalence</seealso>
    let ``_#URIEquivalence`` = Prefixed_Name(voidwh, "#URIEquivalence") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonUrisPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUrisPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUrisPercentage</seealso>
    let ``_#commonUrisPercentage`` =
        Prefixed_Name(voidwh, "#commonUrisPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#uniqueTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriples">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriples</seealso>
    let ``_#uniqueTriples`` = Prefixed_Name(voidwh, "#uniqueTriples") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#usesSPARQLquery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property specifies the entities of interest involved in a configuration by providing a SPARQL query that returns them.</para>
    /// labels<para>uses SPARQL query</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesSPARQLquery">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesSPARQLquery</seealso>
    let ``_#usesSPARQLquery`` =
        Prefixed_Name(voidwh, "#usesSPARQLquery") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonLiteralsPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiteralsPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiteralsPercentage</seealso>
    let ``_#commonLiteralsPercentage`` =
        Prefixed_Name(voidwh, "#commonLiteralsPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#uniqueTriplesPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriplesPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriplesPercentage</seealso>
    let ``_#uniqueTriplesPercentage`` =
        Prefixed_Name(voidwh, "#uniqueTriplesPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonUris</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUris">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUris</seealso>
    let ``_#commonUris`` = Prefixed_Name(voidwh, "#commonUris") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#usesMetrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of metrics class.</para>
    /// labels<para>uses Metrics</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesMetrics">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesMetrics</seealso>
    let ``_#usesMetrics`` = Prefixed_Name(voidwh, "#usesMetrics") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#suffixCanonicalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#URIEquivalence</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#suffixCanonicalization">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#suffixCanonicalization</seealso>
    let ``_#suffixCanonicalization`` =
        Prefixed_Name(voidwh, "#suffixCanonicalization") |> PrefixedName

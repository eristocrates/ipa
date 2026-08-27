namespace http.www.ics.forth.gr.isl.VoIDWarehouse.VoID_Extension_Schema.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module VoIDWarehouse =
    let _namespace_iri = Namespace_Iri VoIDWarehouse |> NamespaceIRI
    /// <summary>
    ///   <para>voidwh:#Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Based on the fact that a measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). The Configuration defines the polices with respect to a measurement is carried out. It defines polices about how to compare URIs and the configuration of an entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Configuration">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Configuration</seealso>
    let Configuration = Prefixed_Name(VoIDWarehouse, "Configuration") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#EntityConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity Configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#EntityConfiguration">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#EntityConfiguration</seealso>
    let EntityConfiguration =
        Prefixed_Name(VoIDWarehouse, "EntityConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The notion of Measurement is actually a specialization of dc:Event and therefore inherits the property date. A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Measurement">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Measurement</seealso>
    let Measurement = Prefixed_Name(VoIDWarehouse, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#Metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric is an individual with a URI and is defined by a resource (e.g. the DOI of the scientific paper that defined that metric)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Metrics">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#Metrics</seealso>
    let Metrics = Prefixed_Name(VoIDWarehouse, "Metrics") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#URIEquivalence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The notion of Configuration concerns issues that explain how the measurement was done. At this point, and for the requirements at hand, we need two subclasses: the first concerns the way URI equivalence is defined (see URIEquivalence class), while the second (the EntityConfiguration class) concerns how the entities of interest are defined. Regarding the latter the current modeling allows someone to specify the desired set of entities by providing a SPARQL query that returns them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URI Equivalence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#URIEquivalence">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#URIEquivalence</seealso>
    let URIEquivalence = Prefixed_Name(VoIDWarehouse, "URIEquivalence") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#accordingTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A measurement is carried out by an agent using a specific metric accordingTo one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of configuation class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"according To"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#accordingTo">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#accordingTo</seealso>
    let accordingTo = Prefixed_Name(VoIDWarehouse, "accordingTo") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#averageDegreeIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#averageDegreeIncrement">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#averageDegreeIncrement</seealso>
    let averageDegreeIncrement =
        Prefixed_Name(VoIDWarehouse, "averageDegreeIncrement") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#carriedOutBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal).
    /// Therefore, this property links an instance of measurement class with an instance of the Agent class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#carriedOutBy">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#carriedOutBy</seealso>
    let carriedOutBy = Prefixed_Name(VoIDWarehouse, "carriedOutBy") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#commonLiterals</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiterals">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiterals</seealso>
    let commonLiterals = Prefixed_Name(VoIDWarehouse, "commonLiterals") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonLiteralsPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiteralsPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonLiteralsPercentage</seealso>
    let commonLiteralsPercentage =
        Prefixed_Name(VoIDWarehouse, "commonLiteralsPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonUris</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#Metrics</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUris">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUris</seealso>
    let commonUris = Prefixed_Name(VoIDWarehouse, "commonUris") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#commonUrisPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUrisPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#commonUrisPercentage</seealso>
    let commonUrisPercentage =
        Prefixed_Name(VoIDWarehouse, "commonUrisPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#complementarityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#complementarityFactor">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#complementarityFactor</seealso>
    let complementarityFactor =
        Prefixed_Name(VoIDWarehouse, "complementarityFactor") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#entityMatching</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#URIEquivalence</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#entityMatching">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#entityMatching</seealso>
    let entityMatching = Prefixed_Name(VoIDWarehouse, "entityMatching") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#exactStringEquality</para>
    /// </summary>
    /// <remarks>
    ///   <para>voidwh:#URIEquivalence</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#exactStringEquality">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#exactStringEquality</seealso>
    let exactStringEquality =
        Prefixed_Name(VoIDWarehouse, "exactStringEquality") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#over</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets (atomic or composite) and produces a value (i.e. literal). Therefore, this property links instances of Measurement class with instances of dataset class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"over"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#over">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#over</seealso>
    let over = Prefixed_Name(VoIDWarehouse, "over") |> PrefixedName
    /// <summary>
    ///   <para>voidwh:#producesValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property indicates the value produced by the measurement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"produces Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#producesValue">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#producesValue</seealso>
    let producesValue = Prefixed_Name(VoIDWarehouse, "producesValue") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#suffixCanonicalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#URIEquivalence</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#suffixCanonicalization">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#suffixCanonicalization</seealso>
    let suffixCanonicalization =
        Prefixed_Name(VoIDWarehouse, "suffixCanonicalization") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#uniqueTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriples">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriples</seealso>
    let uniqueTriples = Prefixed_Name(VoIDWarehouse, "uniqueTriples") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#uniqueTriplesPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voidwh:#Metrics</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriplesPercentage">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#uniqueTriplesPercentage</seealso>
    let uniqueTriplesPercentage =
        Prefixed_Name(VoIDWarehouse, "uniqueTriplesPercentage") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#usesMetrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A measurement is carried out by an agent using a specific metric according to one (or more) configurations over one (or more) datasets. Therefore, this property links an instance of measurement class with an instance of metrics class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses Metrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesMetrics">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesMetrics</seealso>
    let usesMetrics = Prefixed_Name(VoIDWarehouse, "usesMetrics") |> PrefixedName

    /// <summary>
    ///   <para>voidwh:#usesSPARQLquery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the entities of interest involved in a configuration by providing a SPARQL query that returns them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses SPARQL query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesSPARQLquery">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl#usesSPARQLquery</seealso>
    let usesSPARQLquery =
        Prefixed_Name(VoIDWarehouse, "usesSPARQLquery") |> PrefixedName

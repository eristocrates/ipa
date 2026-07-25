namespace http.www.demcare.eu.ontologies.contextdescriptor.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctxdesc =
    let _namespace_iri = Namespace_Iri ctxdesc |> NamespaceIRI
    /// <summary>
    ///   <para>ctxdesc:dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used for denoting the dependencies of a particular ontology class.
    ///
    /// The model also allows annotated classes to inherit the context dependencies of the superclasses through property chain axiom (OWL 2 RL Profile).</para>
    /// labels<para>dependency</para></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/contextdescriptor.owl#dependency">http://www.demcare.eu/ontologies/contextdescriptor.owl#dependency</seealso>
    let dependency = Prefixed_Name(ctxdesc, "dependency") |> PrefixedName
    /// <summary>
    ///   <para>ctxdesc:ContextDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ContextDescriptor instance is a container class that allows the definition of relationships (dependencies) among ontology classes.
    ///
    /// The goal is to define relations among classes, therefore, the proposed ontology treats classes as instances, allowing property assertions to be made among domain concepts. Intuitively, the ontology can be thought of as a conceptual (meta) layer that can be placed on top of any domain activity ontology. This way, instances of the ContextDescriptor are used to link domain activities (describes property) with one or more lower-level conceptualisations through dependency property assertions.
    ///
    /// The pattern has been used for building human activity models by defining the dependencies between low-level observations and high-level activities.
    ///
    /// For more details, please see the relevant paper:
    /// Georgios Meditskos, Efstratios Kontopoulos, Ioannis Kompatsiaris, "Knowledge-driven Activity Recognition and Segmentation Using Context Connections", International Semantic Web Conference (ISWC), pp. 260-275, Riva del Garda, Trento, Italy, 19-23 October 2014 </para>
    /// labels<para>Context Descriptor</para></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/contextdescriptor.owl#ContextDescriptor">http://www.demcare.eu/ontologies/contextdescriptor.owl#ContextDescriptor</seealso>
    let ContextDescriptor = Prefixed_Name(ctxdesc, "ContextDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>ctxdesc:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is described by</para></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/contextdescriptor.owl#isDescribedBy">http://www.demcare.eu/ontologies/contextdescriptor.owl#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(ctxdesc, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>ctxdesc:threshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property can be used to assign a threshold to the context descriptor of a certain complex activity, specifying a minimum value of confidence (plausability).</para>
    /// labels<para>threshold</para></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/contextdescriptor.owl#threshold">http://www.demcare.eu/ontologies/contextdescriptor.owl#threshold</seealso>
    let threshold = Prefixed_Name(ctxdesc, "threshold") |> PrefixedName
    /// <summary>
    ///   <para>ctxdesc:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used for defining the higher level class of the ContextDescriptor</para>
    /// labels<para>describes</para></remarks>
    /// <seealso href="http://www.demcare.eu/ontologies/contextdescriptor.owl#describes">http://www.demcare.eu/ontologies/contextdescriptor.owl#describes</seealso>
    let describes = Prefixed_Name(ctxdesc, "describes") |> PrefixedName

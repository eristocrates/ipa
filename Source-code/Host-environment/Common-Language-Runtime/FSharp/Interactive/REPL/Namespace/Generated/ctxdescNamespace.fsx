#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ctxdesc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.demcare.eu/ontologies/contextdescriptor.owl#" "ctxdesc"

    /// <summary>
    ///   <para>rdfs:label : Context Descriptor</para>
    ///   <para>rdfs:comment : A ContextDescriptor instance is a container class that allows the definition of relationships (dependencies) among ontology classes.
    ///
    /// The goal is to define relations among classes, therefore, the proposed ontology treats classes as instances, allowing property assertions to be made among domain concepts. Intuitively, the ontology can be thought of as a conceptual (meta) layer that can be placed on top of any domain activity ontology. This way, instances of the ContextDescriptor are used to link domain activities (describes property) with one or more lower-level conceptualisations through dependency property assertions.
    ///
    /// The pattern has been used for building human activity models by defining the dependencies between low-level observations and high-level activities.
    ///
    /// For more details, please see the relevant paper:
    /// Georgios Meditskos, Efstratios Kontopoulos, Ioannis Kompatsiaris, "Knowledge-driven Activity Recognition and Segmentation Using Context Connections", International Semantic Web Conference (ISWC), pp. 260-275, Riva del Garda, Trento, Italy, 19-23 October 2014 </para>
    ///   <a href="http://www.demcare.eu/ontologies/contextdescriptor.owl#ContextDescriptor">ctxdesc:ContextDescriptor</a>
    /// </summary>
    let ContextDescriptor = _prefixId.prefix "ContextDescriptor"
    /// <summary>
    ///   <para>rdfs:label : dependency</para>
    ///   <para>rdfs:comment : This property is used for denoting the dependencies of a particular ontology class.
    ///
    /// The model also allows annotated classes to inherit the context dependencies of the superclasses through property chain axiom (OWL 2 RL Profile).</para>
    ///   <a href="http://www.demcare.eu/ontologies/contextdescriptor.owl#dependency">ctxdesc:dependency</a>
    /// </summary>
    let dependency = _prefixId.prefix "dependency"
    /// <summary>
    ///   <para>rdfs:label : describes</para>
    ///   <para>rdfs:comment : This property is used for defining the higher level class of the ContextDescriptor</para>
    ///   <a href="http://www.demcare.eu/ontologies/contextdescriptor.owl#describes">ctxdesc:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : is described by</para>
    ///   <a href="http://www.demcare.eu/ontologies/contextdescriptor.owl#isDescribedBy">ctxdesc:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : threshold</para>
    ///   <para>rdfs:comment : This property can be used to assign a threshold to the context descriptor of a certain complex activity, specifying a minimum value of confidence (plausability).</para>
    ///   <a href="http://www.demcare.eu/ontologies/contextdescriptor.owl#threshold">ctxdesc:threshold</a>
    /// </summary>
    let threshold = _prefixId.prefix "threshold"

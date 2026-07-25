namespace http.www.w3.org.ns.ssn.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ssno =
    let _namespace_iri = Namespace_Iri ssno |> NamespaceIRI
    /// <summary>
    ///   <para>ssno:isProxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.</para>
    /// labels<para>is proxy for</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/isProxyFor">http://www.w3.org/ns/ssn/isProxyFor</seealso>
    let isProxyFor = Prefixed_Name(ssno, "isProxyFor") |> PrefixedName
    /// <summary>
    ///   <para>ssno:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/Property">http://www.w3.org/ns/ssn/Property</seealso>
    let Property = Prefixed_Name(ssno, "Property") |> PrefixedName
    /// <summary>
    ///   <para>ssno:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an entity that implements a Procedure in some executable way and the Procedure (an algorithm, procedure or method).</para>
    /// labels<para>implements</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/implements">http://www.w3.org/ns/ssn/implements</seealso>
    let implements = Prefixed_Name(ssno, "implements") |> PrefixedName
    /// <summary>
    ///   <para>ssno:forProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between some aspect of an entity and a Property.</para>
    /// labels<para>for property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/forProperty">http://www.w3.org/ns/ssn/forProperty</seealso>
    let forProperty = Prefixed_Name(ssno, "forProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssno:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>System is a unit of abstraction for pieces of infrastructure that implements Procedures. A System may have components, its subsystems, which are other systems.</para>
    /// labels<para>System</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/System">http://www.w3.org/ns/ssn/System</seealso>
    let System = Prefixed_Name(ssno, "System") |> PrefixedName
    /// <summary>
    ///   <para>ssno:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an entity and a Property of that entity.</para>
    /// labels<para>has property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/hasProperty">http://www.w3.org/ns/ssn/hasProperty</seealso>
    let hasProperty = Prefixed_Name(ssno, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssno:Stimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event in the real world that 'triggers' the Sensor. The properties associated to the Stimulus may be different to the eventual observed ObservableProperty. It is the event, not the object, that triggers the Sensor.</para>
    /// labels<para>Stimulus</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/Stimulus">http://www.w3.org/ns/ssn/Stimulus</seealso>
    let Stimulus = Prefixed_Name(ssno, "Stimulus") |> PrefixedName
    /// <summary>
    ///   <para>ssno:wasOriginatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Relation between an Observation and the Stimulus that originated it.</para>
    /// labels<para>was originated by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/wasOriginatedBy">http://www.w3.org/ns/ssn/wasOriginatedBy</seealso>
    let wasOriginatedBy = Prefixed_Name(ssno, "wasOriginatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ssno:inDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Platform and a Deployment, meaning that the deployedSystems of the Deployment are hosted on the Platform.</para>
    /// labels<para>in deployment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/inDeployment">http://www.w3.org/ns/ssn/inDeployment</seealso>
    let inDeployment = Prefixed_Name(ssno, "inDeployment") |> PrefixedName
    /// <summary>
    ///   <para>ssno:Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the Deployment of one or more Systems for a particular purpose. Deployment may be done on a Platform.</para>
    /// labels<para>Deployment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/Deployment">http://www.w3.org/ns/ssn/Deployment</seealso>
    let Deployment = Prefixed_Name(ssno, "Deployment") |> PrefixedName
    /// <summary>
    ///   <para>ssno:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Procedure and an Input to it.</para>
    /// labels<para>has input</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/hasInput">http://www.w3.org/ns/ssn/hasInput</seealso>
    let hasInput = Prefixed_Name(ssno, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>ssno:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any information that is provided to a Procedure for its use.</para>
    /// labels<para>Input</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/Input">http://www.w3.org/ns/ssn/Input</seealso>
    let Input = Prefixed_Name(ssno, "Input") |> PrefixedName
    /// <summary>
    ///   <para>ssno:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Procedure and an Output of it.</para>
    /// labels<para>has output</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/hasOutput">http://www.w3.org/ns/ssn/hasOutput</seealso>
    let hasOutput = Prefixed_Name(ssno, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ssno:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any information that is reported from a Procedure.</para>
    /// labels<para>Output</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/Output">http://www.w3.org/ns/ssn/Output</seealso>
    let Output = Prefixed_Name(ssno, "Output") |> PrefixedName
    /// <summary>
    ///   <para>ssno:implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Procedure (an algorithm, procedure or method) and an entity that implements that Procedure in some executable way.</para>
    /// labels<para>implemented by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/implementedBy">http://www.w3.org/ns/ssn/implementedBy</seealso>
    let implementedBy = Prefixed_Name(ssno, "implementedBy") |> PrefixedName
    /// <summary>
    ///   <para>ssno:detects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation from a Sensor to the Stimulus that the Sensor can detect. The Stimulus itself will be serving as a proxy for some ObservableProperty.</para>
    /// labels<para>detects</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/detects">http://www.w3.org/ns/ssn/detects</seealso>
    let detects = Prefixed_Name(ssno, "detects") |> PrefixedName
    /// <summary>
    ///   <para>ssno:deployedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Deployment and a deployed System.</para>
    /// labels<para>deployed system</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/deployedSystem">http://www.w3.org/ns/ssn/deployedSystem</seealso>
    let deployedSystem = Prefixed_Name(ssno, "deployedSystem") |> PrefixedName
    /// <summary>
    ///   <para>ssno:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>Please report any errors to the W3C Spatial Data on the Web Working Group via the SDW WG Public List public-sdw-wg@w3.org</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/">http://www.w3.org/ns/ssn/</seealso>
    let _prefix_iri = Prefixed_Name(ssno, "") |> PrefixedName
    /// <summary>
    ///   <para>ssno:deployedOnPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Deployment and the Platform on which the Systems are deployed.</para>
    /// labels<para>deployed on platform</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/deployedOnPlatform">http://www.w3.org/ns/ssn/deployedOnPlatform</seealso>
    let deployedOnPlatform = Prefixed_Name(ssno, "deployedOnPlatform") |> PrefixedName
    /// <summary>
    ///   <para>ssno:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Property and the entity it belongs to.</para>
    /// labels<para>is property of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/isPropertyOf">http://www.w3.org/ns/ssn/isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(ssno, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>ssno:hasSubSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a System and its component parts.</para>
    /// labels<para>has subsystem</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/hasSubSystem">http://www.w3.org/ns/ssn/hasSubSystem</seealso>
    let hasSubSystem = Prefixed_Name(ssno, "hasSubSystem") |> PrefixedName
    /// <summary>
    ///   <para>ssno:hasDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a System and a Deployment, recording that the System is deployed in that Deployment.</para>
    /// labels<para>has deployment</para></remarks>
    /// <seealso href="http://www.w3.org/ns/ssn/hasDeployment">http://www.w3.org/ns/ssn/hasDeployment</seealso>
    let hasDeployment = Prefixed_Name(ssno, "hasDeployment") |> PrefixedName

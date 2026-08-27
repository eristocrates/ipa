namespace http.iserve.kmi._open.ac.uk.ns.msm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module msm =
    let _namespace_iri = Namespace_Iri msm |> NamespaceIRI
    /// <summary>
    ///   <para>msm:MessageContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Message Content"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#MessageContent">http://iserve.kmi.open.ac.uk/ns/msm#MessageContent</seealso>
    let MessageContent = Prefixed_Name(msm, "MessageContent") |> PrefixedName
    /// <summary>
    ///   <para>msm:MessagePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Message Part"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#MessagePart">http://iserve.kmi.open.ac.uk/ns/msm#MessagePart</seealso>
    let MessagePart = Prefixed_Name(msm, "MessagePart") |> PrefixedName
    /// <summary>
    ///   <para>msm:Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An operation is a function provided by a service. It implements a functionnality, and can be accessed by an end user by any mean offered by the service."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operation"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#Operation">http://iserve.kmi.open.ac.uk/ns/msm#Operation</seealso>
    let Operation = Prefixed_Name(msm, "Operation") |> PrefixedName
    /// <summary>
    ///   <para>msm:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A service is a set of operation, and provides a user a way to issu requests  through an interface. Underlying implementation needn't to be known by the end user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#Service">http://iserve.kmi.open.ac.uk/ns/msm#Service</seealso>
    let Service = Prefixed_Name(msm, "Service") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasFault</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Fault"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasFault">http://iserve.kmi.open.ac.uk/ns/msm#hasFault</seealso>
    let hasFault = Prefixed_Name(msm, "hasFault") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Input"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasInput">http://iserve.kmi.open.ac.uk/ns/msm#hasInput</seealso>
    let hasInput = Prefixed_Name(msm, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasInputFault</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"has Input Fault"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasInputFault">http://iserve.kmi.open.ac.uk/ns/msm#hasInputFault</seealso>
    let hasInputFault = Prefixed_Name(msm, "hasInputFault") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasMandatoryPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Mandatory Part"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasMandatoryPart">http://iserve.kmi.open.ac.uk/ns/msm#hasMandatoryPart</seealso>
    let hasMandatoryPart = Prefixed_Name(msm, "hasMandatoryPart") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Name"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasName">http://iserve.kmi.open.ac.uk/ns/msm#hasName</seealso>
    let hasName = Prefixed_Name(msm, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Operation"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasOperation">http://iserve.kmi.open.ac.uk/ns/msm#hasOperation</seealso>
    let hasOperation = Prefixed_Name(msm, "hasOperation") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasOptionalPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Optional Part"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasOptionalPart">http://iserve.kmi.open.ac.uk/ns/msm#hasOptionalPart</seealso>
    let hasOptionalPart = Prefixed_Name(msm, "hasOptionalPart") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Output"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutput">http://iserve.kmi.open.ac.uk/ns/msm#hasOutput</seealso>
    let hasOutput = Prefixed_Name(msm, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasOutputFault</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"has Output Fault"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasOutputFault">http://iserve.kmi.open.ac.uk/ns/msm#hasOutputFault</seealso>
    let hasOutputFault = Prefixed_Name(msm, "hasOutputFault") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Part"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasPart">http://iserve.kmi.open.ac.uk/ns/msm#hasPart</seealso>
    let hasPart = Prefixed_Name(msm, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>msm:hasPartTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has Part Transitive"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#hasPartTransitive">http://iserve.kmi.open.ac.uk/ns/msm#hasPartTransitive</seealso>
    let hasPartTransitive = Prefixed_Name(msm, "hasPartTransitive") |> PrefixedName
    /// <summary>
    ///   <para>msm:isGroundedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is grounded in"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/msm#isGroundedIn">http://iserve.kmi.open.ac.uk/ns/msm#isGroundedIn</seealso>
    let isGroundedIn = Prefixed_Name(msm, "isGroundedIn") |> PrefixedName

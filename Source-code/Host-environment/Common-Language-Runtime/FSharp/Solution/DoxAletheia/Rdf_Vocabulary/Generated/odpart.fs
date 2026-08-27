namespace http.www.ontologydesignpatterns.org.cp.owl.participation.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odpart =
    let _namespace_iri = Namespace_Iri odpart |> NamespaceIRI
    /// <summary>
    ///   <para>odpart:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any physical, social, or mental process, event, or state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"An event that may happen during a publishing process, such as writing a draft, sending a preprint, publishing a paper, etc."</para>
    /// labels<para>"Event"</para><para>"event"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Event">http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Event</seealso>
    let Event = Prefixed_Name(odpart, "Event") |> PrefixedName
    /// <summary>
    ///   <para>odpart:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any physical, social, or mental object, or substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Object">http://www.ontologydesignpatterns.org/cp/owl/participation.owl#Object</seealso>
    let Object = Prefixed_Name(odpart, "Object") |> PrefixedName
    /// <summary>
    ///   <para>odpart:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has participant"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#hasParticipant">http://www.ontologydesignpatterns.org/cp/owl/participation.owl#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(odpart, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>odpart:isParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is participant in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/participation.owl#isParticipantIn">http://www.ontologydesignpatterns.org/cp/owl/participation.owl#isParticipantIn</seealso>
    let isParticipantIn = Prefixed_Name(odpart, "isParticipantIn") |> PrefixedName

namespace http.open_services.net.ns.rm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osrm =
    let _namespace_iri = Namespace_Iri osrm |> NamespaceIRI

    /// <summary>
    ///   <para>osrm:RequirementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Collection of requirements. A collection uses zero or more requirements.</para>
    /// labels<para>RequirementCollection</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#RequirementCollection">http://open-services.net/ns/rm#RequirementCollection</seealso>
    let RequirementCollection =
        Prefixed_Name(osrm, "RequirementCollection") |> PrefixedName

    /// <summary>
    ///   <para>osrm:constrains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a constraining relationship between entities, where the subject entity constrains the object entity. For example, a safety requirement constrains a functional requirement.</para>
    /// labels<para>constrains</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#constrains">http://open-services.net/ns/rm#constrains</seealso>
    let constrains = Prefixed_Name(osrm, "constrains") |> PrefixedName
    /// <summary>
    ///   <para>osrm:decomposes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a decomposition relationship between entities, where the subject entity decomposes the object entity. For example, a collection of system requirements decompose a system requirement.</para>
    /// labels<para>decomposes</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#decomposes">http://open-services.net/ns/rm#decomposes</seealso>
    let decomposes = Prefixed_Name(osrm, "decomposes") |> PrefixedName
    /// <summary>
    ///   <para>osrm:elaborates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses an elaboration relationship between entities, where the subject entity elaborates the object entity. For example, a model element elaborates a requirement.</para>
    /// labels<para>elaborates</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#elaborates">http://open-services.net/ns/rm#elaborates</seealso>
    let elaborates = Prefixed_Name(osrm, "elaborates") |> PrefixedName
    /// <summary>
    ///   <para>osrm:satisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is satisfied by the object. For example, a user requirement is satisfied by a system requirement.</para>
    /// labels<para>satisfiedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#satisfiedBy">http://open-services.net/ns/rm#satisfiedBy</seealso>
    let satisfiedBy = Prefixed_Name(osrm, "satisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:specifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a specification relationship between entities, where the object entity further clarifies or specifies the subject entity. For example, a requirement is specified by a model element.</para>
    /// labels<para>specifiedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#specifiedBy">http://open-services.net/ns/rm#specifiedBy</seealso>
    let specifiedBy = Prefixed_Name(osrm, "specifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:trackedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a tracking relationship between entities, where the object entity in some way tracks or governs the evolution of the subject entity. For example, a requirement may be said to be tracked by a change request, in that it governs the changes to a requirement according to some process machinery.</para>
    /// labels<para>trackedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#trackedBy">http://open-services.net/ns/rm#trackedBy</seealso>
    let trackedBy = Prefixed_Name(osrm, "trackedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:validatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a validation relationship between entities, where the object entity in some way validates the subject entity. For example, a requirement collection may be said to be validated by a test plan.</para>
    /// labels<para>validatedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#validatedBy">http://open-services.net/ns/rm#validatedBy</seealso>
    let validatedBy = Prefixed_Name(osrm, "validatedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OSLC Requirements Management (RM) Vocabulary</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#">http://open-services.net/ns/rm#</seealso>
    let _prefix_iri = Prefixed_Name(osrm, "") |> PrefixedName
    /// <summary>
    ///   <para>osrm:Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Statement of need.</para>
    /// labels<para>Requirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#Requirement">http://open-services.net/ns/rm#Requirement</seealso>
    let Requirement = Prefixed_Name(osrm, "Requirement") |> PrefixedName
    /// <summary>
    ///   <para>osrm:affectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses an affects relationship between entities, where the object entity in some way affects the subject entity. For example, a requirement is affected by a defect.</para>
    /// labels<para>affectedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#affectedBy">http://open-services.net/ns/rm#affectedBy</seealso>
    let affectedBy = Prefixed_Name(osrm, "affectedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:constrainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a constraining relationship between entities, where the object entity constrains the subject entity. For example, a functional requirement is constrained by a safety requirement.</para>
    /// labels<para>constrainedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#constrainedBy">http://open-services.net/ns/rm#constrainedBy</seealso>
    let constrainedBy = Prefixed_Name(osrm, "constrainedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:decomposedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a decomposition relationship between entities, where the object entity decomposes the subject entity. For example, a system requirement is decomposed into a collection of system requirements.</para>
    /// labels<para>decomposedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#decomposedBy">http://open-services.net/ns/rm#decomposedBy</seealso>
    let decomposedBy = Prefixed_Name(osrm, "decomposedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:elaboratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses an elaboration relationship between entities, where the object entity elaborates the subject entity. For example, a requirement is elaborated by a model element.</para>
    /// labels<para>elaboratedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#elaboratedBy">http://open-services.net/ns/rm#elaboratedBy</seealso>
    let elaboratedBy = Prefixed_Name(osrm, "elaboratedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses an implementation relationship between entities, where the object entity is a necessary or desirable aspect of an implementation of the subject entity.</para>
    /// labels<para>implementedBy</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#implementedBy">http://open-services.net/ns/rm#implementedBy</seealso>
    let implementedBy = Prefixed_Name(osrm, "implementedBy") |> PrefixedName
    /// <summary>
    ///   <para>osrm:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a relationship between entities, where the subject entity satisfies the object entity. For example, a system requirement satisfies a user requirement.</para>
    /// labels<para>satisfies</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#satisfies">http://open-services.net/ns/rm#satisfies</seealso>
    let satisfies = Prefixed_Name(osrm, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>osrm:specifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a specification relationship between entities, where the subject entity further clarifies or specifies the object entity. For example, a model element specifies a requirement.</para>
    /// labels<para>specifies</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#specifies">http://open-services.net/ns/rm#specifies</seealso>
    let specifies = Prefixed_Name(osrm, "specifies") |> PrefixedName
    /// <summary>
    ///   <para>osrm:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expresses a use relationship between entities, where the object entity is used by the subject entity. For example, a requirement collection may use a requirement.</para>
    /// labels<para>uses</para></remarks>
    /// <seealso href="http://open-services.net/ns/rm#uses">http://open-services.net/ns/rm#uses</seealso>
    let uses = Prefixed_Name(osrm, "uses") |> PrefixedName

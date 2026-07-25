namespace http.purl.org.twc.ontologies.cmo.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cmo =
    let _namespace_iri = Namespace_Iri cmo |> NamespaceIRI
    /// <summary>
    ///   <para>cmo:hasTargetRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has target role</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRole">http://purl.org/twc/ontologies/cmo.owl#hasTargetRole</seealso>
    let hasTargetRole = Prefixed_Name(cmo, "hasTargetRole") |> PrefixedName
    /// <summary>
    ///   <para>cmo:qualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is quality of</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#qualityOf">http://purl.org/twc/ontologies/cmo.owl#qualityOf</seealso>
    let qualityOf = Prefixed_Name(cmo, "qualityOf") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has role</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasRole">http://purl.org/twc/ontologies/cmo.owl#hasRole</seealso>
    let hasRole = Prefixed_Name(cmo, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>cmo:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept representing the relationship between two independent entities.</para>
    /// labels<para>Relation</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#Relation">http://purl.org/twc/ontologies/cmo.owl#Relation</seealso>
    let Relation = Prefixed_Name(cmo, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>cmo:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Things in the real world can be represented by concepts. This is a link from the concepts and the things those concepts represent. Concepts represent things.</para>
    /// labels<para>represents</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#represents">http://purl.org/twc/ontologies/cmo.owl#represents</seealso>
    let represents = Prefixed_Name(cmo, "represents") |> PrefixedName
    /// <summary>
    ///   <para>cmo:valuesCanBe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>values can be</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#valuesCanBe">http://purl.org/twc/ontologies/cmo.owl#valuesCanBe</seealso>
    let valuesCanBe = Prefixed_Name(cmo, "valuesCanBe") |> PrefixedName
    /// <summary>
    ///   <para>cmo:Universal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Entities that describe the objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)</para>
    /// labels<para>Universal</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#Universal">http://purl.org/twc/ontologies/cmo.owl#Universal</seealso>
    let Universal = Prefixed_Name(cmo, "Universal") |> PrefixedName
    /// <summary>
    ///   <para>cmo:UniversalClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Universal (natural) sets of objects, processes, qualities, states,
    /// etc. in reality (for example on the side of the patient); (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)</para>
    /// labels<para>Universal Class</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#UniversalClass">http://purl.org/twc/ontologies/cmo.owl#UniversalClass</seealso>
    let UniversalClass = Prefixed_Name(cmo, "UniversalClass") |> PrefixedName
    /// <summary>
    ///   <para>cmo:UniversalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relationships in reality. (from http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf)</para>
    /// labels<para>Universal Relation</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#UniversalRelation">http://purl.org/twc/ontologies/cmo.owl#UniversalRelation</seealso>
    let UniversalRelation = Prefixed_Name(cmo, "UniversalRelation") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasPrimaryConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has primary concept</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasPrimaryConcept">http://purl.org/twc/ontologies/cmo.owl#hasPrimaryConcept</seealso>
    let hasPrimaryConcept = Prefixed_Name(cmo, "hasPrimaryConcept") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has qualifying concept</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasQualifier">http://purl.org/twc/ontologies/cmo.owl#hasQualifier</seealso>
    let hasQualifier = Prefixed_Name(cmo, "hasQualifier") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A conceptual type can have qualities that describe it.</para>
    /// labels<para>has quality</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasQuality">http://purl.org/twc/ontologies/cmo.owl#hasQuality</seealso>
    let hasQuality = Prefixed_Name(cmo, "hasQuality") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasSourceRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has source role</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRole">http://purl.org/twc/ontologies/cmo.owl#hasSourceRole</seealso>
    let hasSourceRole = Prefixed_Name(cmo, "hasSourceRole") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has role in relation</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasRoleIn">http://purl.org/twc/ontologies/cmo.owl#hasRoleIn</seealso>
    let hasRoleIn = Prefixed_Name(cmo, "hasRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasSourceRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has source role in relation</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasSourceRoleIn">http://purl.org/twc/ontologies/cmo.owl#hasSourceRoleIn</seealso>
    let hasSourceRoleIn = Prefixed_Name(cmo, "hasSourceRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>cmo:hasTargetRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has target role in relation</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#hasTargetRoleIn">http://purl.org/twc/ontologies/cmo.owl#hasTargetRoleIn</seealso>
    let hasTargetRoleIn = Prefixed_Name(cmo, "hasTargetRoleIn") |> PrefixedName
    /// <summary>
    ///   <para>cmo:representsUniversal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Concepts represent universals in the world.</para>
    /// labels<para>represents universal</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#representsUniversal">http://purl.org/twc/ontologies/cmo.owl#representsUniversal</seealso>
    let representsUniversal = Prefixed_Name(cmo, "representsUniversal") |> PrefixedName
    /// <summary>
    ///   <para>cmo:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The conceputal representation of anything that is a property (a thing that is inherent in an entity, like eye color) or an attribute (a thing that has been assigned, or attributed, to an entity, like name or identification number).</para>
    /// labels<para>Quality</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#Quality">http://purl.org/twc/ontologies/cmo.owl#Quality</seealso>
    let Quality = Prefixed_Name(cmo, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>cmo:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract or general idea inferred or derived from specific instances, representing a set of those instances.</para>
    /// labels<para>Type</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#Type">http://purl.org/twc/ontologies/cmo.owl#Type</seealso>
    let Type = Prefixed_Name(cmo, "Type") |> PrefixedName

    /// <summary>
    ///   <para>cmo:http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf">http://purl.org/twc/ontologies/cmo.owl#http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf</seealso>
    let ``http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf`` =
        Prefixed_Name(cmo, "http://ontology.buffalo.edu/bfo/Terminology_for_Ontologies.pdf") |> PrefixedName

    /// <summary>
    ///   <para>cmo:representedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Things in the real world can be represented by concepts. This is a link between the concepts and the things those concepts represent. Things, including sets of things, are represented by concepts.</para>
    /// labels<para>represented by</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#representedBy">http://purl.org/twc/ontologies/cmo.owl#representedBy</seealso>
    let representedBy = Prefixed_Name(cmo, "representedBy") |> PrefixedName
    /// <summary>
    ///   <para>cmo:UniversalQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Universal Quality</para></remarks>
    /// <seealso href="http://purl.org/twc/ontologies/cmo.owl#UniversalQuality">http://purl.org/twc/ontologies/cmo.owl#UniversalQuality</seealso>
    let UniversalQuality = Prefixed_Name(cmo, "UniversalQuality") |> PrefixedName

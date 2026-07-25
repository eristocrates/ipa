namespace https.w3id.org.riverbench.schema.documentation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rbdoc =
    let _namespace_iri = Namespace_Iri rbdoc |> NamespaceIRI
    /// <summary>
    ///   <para>rbdoc:groupGeneralInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/documentation#DocGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>General information</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#groupGeneralInfo">https://w3id.org/riverbench/schema/documentation#groupGeneralInfo</seealso>
    let groupGeneralInfo = Prefixed_Name(rbdoc, "groupGeneralInfo") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:isHiddenInDoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Whether a given property should be omitted in the generated documentation.</para>
    /// labels<para>Is hidden in documentation</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#isHiddenInDoc">https://w3id.org/riverbench/schema/documentation#isHiddenInDoc</seealso>
    let isHiddenInDoc = Prefixed_Name(rbdoc, "isHiddenInDoc") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:DocGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Documentation group, corresponding to a heading in the generated document.</para>
    /// labels<para>Documentation group</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#DocGroup">https://w3id.org/riverbench/schema/documentation#DocGroup</seealso>
    let DocGroup = Prefixed_Name(rbdoc, "DocGroup") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:hasLabelOverride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Top-priority label to be used in documentation pages.</para>
    /// labels<para>Has label override</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#hasLabelOverride">https://w3id.org/riverbench/schema/documentation#hasLabelOverride</seealso>
    let hasLabelOverride = Prefixed_Name(rbdoc, "hasLabelOverride") |> PrefixedName

    /// <summary>
    ///   <para>rbdoc:groupTechnicalMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/documentation#DocGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Technical metadata</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#groupTechnicalMetadata">https://w3id.org/riverbench/schema/documentation#groupTechnicalMetadata</seealso>
    let groupTechnicalMetadata =
        Prefixed_Name(rbdoc, "groupTechnicalMetadata") |> PrefixedName

    /// <summary>
    ///   <para>rbdoc:groupContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/documentation#DocGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Content</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#groupContent">https://w3id.org/riverbench/schema/documentation#groupContent</seealso>
    let groupContent = Prefixed_Name(rbdoc, "groupContent") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:groupDistributions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:riverbench/schema/documentation#DocGroup</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Distributions</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#groupDistributions">https://w3id.org/riverbench/schema/documentation#groupDistributions</seealso>
    let groupDistributions = Prefixed_Name(rbdoc, "groupDistributions") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:hasDocGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Indicates the documentation group (heading) of a property</para>
    /// labels<para>Has documentation group</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#hasDocGroup">https://w3id.org/riverbench/schema/documentation#hasDocGroup</seealso>
    let hasDocGroup = Prefixed_Name(rbdoc, "hasDocGroup") |> PrefixedName
    /// <summary>
    ///   <para>rbdoc:hasDocWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Weight of a given property or item when generating documentation (integer). Properties or items with lower values will be shown first in the generated docs.</para>
    /// labels<para>Has documentation weight</para></remarks>
    /// <seealso href="https://w3id.org/riverbench/schema/documentation#hasDocWeight">https://w3id.org/riverbench/schema/documentation#hasDocWeight</seealso>
    let hasDocWeight = Prefixed_Name(rbdoc, "hasDocWeight") |> PrefixedName

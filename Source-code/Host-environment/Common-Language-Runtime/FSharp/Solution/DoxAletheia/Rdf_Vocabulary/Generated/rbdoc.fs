namespace https.w3id.org.riverbench.schema.documentation.hash

open DoxAletheia.Rdf_Vocabulary

module rbdoc =
    let _namespace_name = "https://w3id.org/riverbench/schema/documentation#"

    /// <summary>
    /// Indicates the documentation group (heading) of a property
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasDocGroup"></see></summary>
    let hasDocGroup =
        Namespaced_IRI.parse _namespace_name "hasDocGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupGeneralInfo"></see>
    /// </summary>
    let groupGeneralInfo =
        Namespaced_IRI.parse _namespace_name "groupGeneralInfo" |> NamespacedName

    /// <summary>
    /// Whether a given property should be omitted in the generated documentation.
    /// <see href="https://w3id.org/riverbench/schema/documentation#isHiddenInDoc"></see></summary>
    let isHiddenInDoc =
        Namespaced_IRI.parse _namespace_name "isHiddenInDoc" |> NamespacedName

    /// <summary>
    /// Weight of a given property or item when generating documentation (integer). Properties or items with lower values will be shown first in the generated docs.
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasDocWeight"></see></summary>
    let hasDocWeight =
        Namespaced_IRI.parse _namespace_name "hasDocWeight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupContent"></see>
    /// </summary>
    let groupContent =
        Namespaced_IRI.parse _namespace_name "groupContent" |> NamespacedName

    /// <summary>
    /// Top-priority label to be used in documentation pages.
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasLabelOverride"></see></summary>
    let hasLabelOverride =
        Namespaced_IRI.parse _namespace_name "hasLabelOverride" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupDistributions"></see>
    /// </summary>
    let groupDistributions =
        Namespaced_IRI.parse _namespace_name "groupDistributions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupTechnicalMetadata"></see>
    /// </summary>
    let groupTechnicalMetadata =
        Namespaced_IRI.parse _namespace_name "groupTechnicalMetadata" |> NamespacedName

    /// <summary>
    /// Documentation group, corresponding to a heading in the generated document.
    /// <see href="https://w3id.org/riverbench/schema/documentation#DocGroup"></see></summary>
    let DocGroup = Namespaced_IRI.parse _namespace_name "DocGroup" |> NamespacedName

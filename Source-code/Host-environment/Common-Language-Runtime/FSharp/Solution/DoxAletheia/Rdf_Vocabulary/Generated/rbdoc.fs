namespace https.w3id.org.riverbench.schema.documentation.hash

open DoxAletheia

module rbdoc =
    let _namespace_name = "https://w3id.org/riverbench/schema/documentation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Indicates the documentation group (heading) of a property
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasDocGroup"></see></summary>
    let hasDocGroup = _prefix "hasDocGroup"
    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupGeneralInfo"></see>
    /// </summary>
    let groupGeneralInfo = _prefix "groupGeneralInfo"
    /// <summary>
    /// Whether a given property should be omitted in the generated documentation.
    /// <see href="https://w3id.org/riverbench/schema/documentation#isHiddenInDoc"></see></summary>
    let isHiddenInDoc = _prefix "isHiddenInDoc"
    /// <summary>
    /// Weight of a given property or item when generating documentation (integer). Properties or items with lower values will be shown first in the generated docs.
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasDocWeight"></see></summary>
    let hasDocWeight = _prefix "hasDocWeight"
    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupContent"></see>
    /// </summary>
    let groupContent = _prefix "groupContent"
    /// <summary>
    /// Top-priority label to be used in documentation pages.
    /// <see href="https://w3id.org/riverbench/schema/documentation#hasLabelOverride"></see></summary>
    let hasLabelOverride = _prefix "hasLabelOverride"
    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupDistributions"></see>
    /// </summary>
    let groupDistributions = _prefix "groupDistributions"
    /// <summary>
    ///   <see href="https://w3id.org/riverbench/schema/documentation#groupTechnicalMetadata"></see>
    /// </summary>
    let groupTechnicalMetadata = _prefix "groupTechnicalMetadata"
    /// <summary>
    /// Documentation group, corresponding to a heading in the generated document.
    /// <see href="https://w3id.org/riverbench/schema/documentation#DocGroup"></see></summary>
    let DocGroup = _prefix "DocGroup"

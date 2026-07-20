namespace https.www.gleif.org.ontology.EntityLegalForm.slash

open DoxAletheia

module gleif_elf =
    let _namespace_name = "https://www.gleif.org/ontology/EntityLegalForm/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/ELFregistry"></see>
    /// </summary>
    let ELFregistry = _prefix "ELFregistry"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalForm"></see>
    /// </summary>
    let EntityLegalForm = _prefix "EntityLegalForm"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalFormIdentifier"></see>
    /// </summary>
    let EntityLegalFormIdentifier = _prefix "EntityLegalFormIdentifier"

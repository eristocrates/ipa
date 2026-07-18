namespace https.www.gleif.org.ontology.EntityLegalForm.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_elf =
    let _namespace_name = "https://www.gleif.org/ontology/EntityLegalForm/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/ELFregistry"></see>
    /// </summary>
    let ELFregistry =
        Namespaced_IRI.parse _namespace_name "ELFregistry" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalForm"></see>
    /// </summary>
    let EntityLegalForm =
        Namespaced_IRI.parse _namespace_name "EntityLegalForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalFormIdentifier"></see>
    /// </summary>
    let EntityLegalFormIdentifier =
        Namespaced_IRI.parse _namespace_name "EntityLegalFormIdentifier" |> NamespacedName

namespace http.swa.cefriel.it.ontologies.botdcat_ap.hash

open DoxAletheia

module bot =
    let _namespace_name = "http://swa.cefriel.it/ontologies/botdcat-ap#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Optional class. Represents a list of all the entities that can be associated to an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#EntitiesCatalog"></see></summary>
    let EntitiesCatalog = _prefix "EntitiesCatalog"
    /// <summary>
    /// Mandatory class. An Intent exposed by the Dataset.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#Intent"></see></summary>
    let Intent = _prefix "Intent"
    /// <summary>
    /// Optional property. Cardinality [0..1]. This property contains the access URL provided by a SPARQL endpoint handling the Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasAssetURL"></see></summary>
    let hasAssetURL = _prefix "hasAssetURL"
    /// <summary>
    /// Recommended property. Cardinality [0..1]. This property refers to a Resource containg information about an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasDocumentation"></see></summary>
    let hasDocumentation = _prefix "hasDocumentation"
    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an Entities Catalog connected to an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntitiesList"></see></summary>
    let hasEntitiesList = _prefix "hasEntitiesList"
    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntity"></see></summary>
    let hasEntity = _prefix "hasEntity"
    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an entity specified as a Concept. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityConcept"></see></summary>
    let hasEntityConcept = _prefix "hasEntityConcept"
    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to a Dataset containing all the istances of an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityDataset"></see></summary>
    let hasEntityDataset = _prefix "hasEntityDataset"
    /// <summary>
    /// Mandatory property. Cardinality [1..n]. This property refers to an Intent handled by the Dataset.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasIntent"></see></summary>
    let hasIntent = _prefix "hasIntent"
    /// <summary>
    /// Optional property. Cardinality [0..1]. This property contains the access URL provided by an API service handling the Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasMethodURL"></see></summary>
    let hasMethodURL = _prefix "hasMethodURL"

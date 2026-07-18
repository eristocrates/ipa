namespace http.swa.cefriel.it.ontologies.botdcat_ap.hash

open DoxAletheia.Rdf_Vocabulary

module bot =
    let _namespace_name = "http://swa.cefriel.it/ontologies/botdcat-ap#"

    /// <summary>
    /// Optional class. Represents a list of all the entities that can be associated to an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#EntitiesCatalog"></see></summary>
    let EntitiesCatalog =
        Namespaced_IRI.parse _namespace_name "EntitiesCatalog" |> NamespacedName

    /// <summary>
    /// Mandatory class. An Intent exposed by the Dataset.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#Intent"></see></summary>
    let Intent = Namespaced_IRI.parse _namespace_name "Intent" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..1]. This property contains the access URL provided by a SPARQL endpoint handling the Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasAssetURL"></see></summary>
    let hasAssetURL =
        Namespaced_IRI.parse _namespace_name "hasAssetURL" |> NamespacedName

    /// <summary>
    /// Recommended property. Cardinality [0..1]. This property refers to a Resource containg information about an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasDocumentation"></see></summary>
    let hasDocumentation =
        Namespaced_IRI.parse _namespace_name "hasDocumentation" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an Entities Catalog connected to an Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntitiesList"></see></summary>
    let hasEntitiesList =
        Namespaced_IRI.parse _namespace_name "hasEntitiesList" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntity"></see></summary>
    let hasEntity = Namespaced_IRI.parse _namespace_name "hasEntity" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to an entity specified as a Concept. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityConcept"></see></summary>
    let hasEntityConcept =
        Namespaced_IRI.parse _namespace_name "hasEntityConcept" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..n]. This property refers to a Dataset containing all the istances of an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityDataset"></see></summary>
    let hasEntityDataset =
        Namespaced_IRI.parse _namespace_name "hasEntityDataset" |> NamespacedName

    /// <summary>
    /// Mandatory property. Cardinality [1..n]. This property refers to an Intent handled by the Dataset.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasIntent"></see></summary>
    let hasIntent = Namespaced_IRI.parse _namespace_name "hasIntent" |> NamespacedName

    /// <summary>
    /// Optional property. Cardinality [0..1]. This property contains the access URL provided by an API service handling the Intent.
    /// <see href="http://swa.cefriel.it/ontologies/botdcat-ap#hasMethodURL"></see></summary>
    let hasMethodURL =
        Namespaced_IRI.parse _namespace_name "hasMethodURL" |> NamespacedName

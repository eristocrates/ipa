namespace http.swa.cefriel.it.ontologies.botdcat_ap.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bot =
    let _namespace_iri = Namespace_Iri bot |> NamespaceIRI
    /// <summary>
    ///   <para>bot:EntitiesCatalog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Optional class. Represents a list of all the entities that can be associated to an Intent."</para>
    /// labels<para>"Entities Catalog"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#EntitiesCatalog">http://swa.cefriel.it/ontologies/botdcat-ap#EntitiesCatalog</seealso>
    let EntitiesCatalog = Prefixed_Name(bot, "EntitiesCatalog") |> PrefixedName
    /// <summary>
    ///   <para>bot:Intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mandatory class. An Intent exposed by the Dataset."</para>
    /// labels<para>"Intent"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#Intent">http://swa.cefriel.it/ontologies/botdcat-ap#Intent</seealso>
    let Intent = Prefixed_Name(bot, "Intent") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasAssetURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..1]. This property contains the access URL provided by a SPARQL endpoint handling the Intent."</para>
    /// labels<para>"has Asset URL"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasAssetURL">http://swa.cefriel.it/ontologies/botdcat-ap#hasAssetURL</seealso>
    let hasAssetURL = Prefixed_Name(bot, "hasAssetURL") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Recommended property. Cardinality [0..1]. This property refers to a Resource containg information about an Intent."</para>
    /// labels<para>"has Documentation"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasDocumentation">http://swa.cefriel.it/ontologies/botdcat-ap#hasDocumentation</seealso>
    let hasDocumentation = Prefixed_Name(bot, "hasDocumentation") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasEntitiesList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..n]. This property refers to an Entities Catalog connected to an Intent."</para>
    /// labels<para>"has Entities List"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntitiesList">http://swa.cefriel.it/ontologies/botdcat-ap#hasEntitiesList</seealso>
    let hasEntitiesList = Prefixed_Name(bot, "hasEntitiesList") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..n]. This property refers to an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used."</para>
    /// labels<para>"has Entity"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntity">http://swa.cefriel.it/ontologies/botdcat-ap#hasEntity</seealso>
    let hasEntity = Prefixed_Name(bot, "hasEntity") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasEntityConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..n]. This property refers to an entity specified as a Concept. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used."</para>
    /// labels<para>"has Entity Concept"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityConcept">http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityConcept</seealso>
    let hasEntityConcept = Prefixed_Name(bot, "hasEntityConcept") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasEntityDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..n]. This property refers to a Dataset containing all the istances of an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used."</para>
    /// labels<para>"has Entity Dataset"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityDataset">http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityDataset</seealso>
    let hasEntityDataset = Prefixed_Name(bot, "hasEntityDataset") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Mandatory property. Cardinality [1..n]. This property refers to an Intent handled by the Dataset."</para>
    /// labels<para>"has Intent"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasIntent">http://swa.cefriel.it/ontologies/botdcat-ap#hasIntent</seealso>
    let hasIntent = Prefixed_Name(bot, "hasIntent") |> PrefixedName
    /// <summary>
    ///   <para>bot:hasMethodURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optional property. Cardinality [0..1]. This property contains the access URL provided by an API service handling the Intent."</para>
    /// labels<para>"has Method URL"</para></remarks>
    /// <seealso href="http://swa.cefriel.it/ontologies/botdcat-ap#hasMethodURL">http://swa.cefriel.it/ontologies/botdcat-ap#hasMethodURL</seealso>
    let hasMethodURL = Prefixed_Name(bot, "hasMethodURL") |> PrefixedName

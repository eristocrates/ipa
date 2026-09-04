#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bot =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://swa.cefriel.it/ontologies/botdcat-ap#" "bot"

    /// <summary>
    ///   <para>vann:usageNote : Optional class. Represents a list of all the entities that can be associated to an Intent.</para>
    ///   <para>rdfs:label : Entities Catalog</para>
    ///   <para>rdfs:comment : Optional class. Represents a list of all the entities that can be associated to an Intent.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#EntitiesCatalog">bot:EntitiesCatalog</a>
    /// </summary>
    let EntitiesCatalog = _prefixId.prefix "EntitiesCatalog"
    /// <summary>
    ///   <para>vann:usageNote : Mandatory class. An Intent exposed by the Dataset.</para>
    ///   <para>rdfs:label : Intent</para>
    ///   <para>rdfs:comment : Mandatory class. An Intent exposed by the Dataset.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#Intent">bot:Intent</a>
    /// </summary>
    let Intent = _prefixId.prefix "Intent"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..1]. This property contains the access URL provided by a SPARQL endpoint handling the Intent.</para>
    ///   <para>rdfs:label : has Asset URL</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..1]. This property contains the access URL provided by a SPARQL endpoint handling the Intent.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasAssetURL">bot:hasAssetURL</a>
    /// </summary>
    let hasAssetURL = _prefixId.prefix "hasAssetURL"
    /// <summary>
    ///   <para>vann:usageNote : Recommended property. Cardinality [0..1]. This property refers to a Resource containg information about an Intent.</para>
    ///   <para>rdfs:label : has Documentation</para>
    ///   <para>rdfs:comment : Recommended property. Cardinality [0..1]. This property refers to a Resource containg information about an Intent.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasDocumentation">bot:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..n]. This property refers to an Entities Catalog describing the entities connected to an Intent.</para>
    ///   <para>rdfs:label : has Entities List</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..n]. This property refers to an Entities Catalog connected to an Intent.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntitiesList">bot:hasEntitiesList</a>
    /// </summary>
    let hasEntitiesList = _prefixId.prefix "hasEntitiesList"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..n]. This property refers to an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <para>rdfs:label : has Entity</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..n]. This property refers to an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntity">bot:hasEntity</a>
    /// </summary>
    let hasEntity = _prefixId.prefix "hasEntity"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..n]. This property refers to an entity specified as a Concept. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <para>rdfs:label : has Entity Concept</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..n]. This property refers to an entity specified as a Concept. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityConcept">bot:hasEntityConcept</a>
    /// </summary>
    let hasEntityConcept = _prefixId.prefix "hasEntityConcept"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..n]. This property refers to a Dataset containing all the istances of an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <para>rdfs:label : has Entity Dataset</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..n]. This property refers to a Dataset containing all the istances of an entity. Note that only one of bot:hasEntity, bot:hasEntityConcept and bot:hasEntityCatalog property for each entity must be used.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasEntityDataset">bot:hasEntityDataset</a>
    /// </summary>
    let hasEntityDataset = _prefixId.prefix "hasEntityDataset"
    /// <summary>
    ///   <para>vann:usageNote : Mandatory property. Cardinality [1..n]. This property refers to an Intent handled by the Dataset.</para>
    ///   <para>rdfs:label : has Intent</para>
    ///   <para>rdfs:comment : Mandatory property. Cardinality [1..n]. This property refers to an Intent handled by the Dataset.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasIntent">bot:hasIntent</a>
    /// </summary>
    let hasIntent = _prefixId.prefix "hasIntent"
    /// <summary>
    ///   <para>vann:usageNote : Optional property. Cardinality [0..1]. This property contains the access URL provided by an API service handling the Intent.</para>
    ///   <para>rdfs:label : has Method URL</para>
    ///   <para>rdfs:comment : Optional property. Cardinality [0..1]. This property contains the access URL provided by an API service handling the Intent.</para>
    ///   <a href="http://swa.cefriel.it/ontologies/botdcat-ap#hasMethodURL">bot:hasMethodURL</a>
    /// </summary>
    let hasMethodURL = _prefixId.prefix "hasMethodURL"

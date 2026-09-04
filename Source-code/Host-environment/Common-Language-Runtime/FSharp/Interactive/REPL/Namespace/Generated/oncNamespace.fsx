#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module onc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/oncm/core#" "onc"

    /// <summary>
    ///   <para>dcterms:description : A category/class of entities supported by a configuration.</para>
    ///   <para>rdfs:label : category</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#Category">onc:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>dcterms:description : The configuration supported by a NEE service.</para>
    ///   <para>rdfs:label : configuration</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#Configuration">onc:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>dcterms:description : Specification of the extra information that should be fetched for an entity URI.</para>
    ///   <para>rdfs:label : entity enrichment specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#EntityEnrichmentSpec">onc:EntityEnrichmentSpec</a>
    /// </summary>
    let EntityEnrichmentSpec = _prefixId.prefix "EntityEnrichmentSpec"
    /// <summary>
    ///   <para>dcterms:description : Specification of how an entity name corresponds to entity URIs.</para>
    ///   <para>rdfs:label : entity linking specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#EntityLinkingSpec">onc:EntityLinkingSpec</a>
    /// </summary>
    let EntityLinkingSpec = _prefixId.prefix "EntityLinkingSpec"
    /// <summary>
    ///   <para>dcterms:description : Specification of the entity names of a category.</para>
    ///   <para>rdfs:label : entity names specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#EntityNamesSpec">onc:EntityNamesSpec</a>
    /// </summary>
    let EntityNamesSpec = _prefixId.prefix "EntityNamesSpec"
    /// <summary>
    ///   <para>dcterms:description : A Knowledge Base Mirror (KBM): the gateway for accessing a Knowledge Base.</para>
    ///   <para>rdfs:label : knowledge base mirror</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#KBM">onc:KBM</a>
    /// </summary>
    let KBM = _prefixId.prefix "KBM"
    /// <summary>
    ///   <para>dcterms:description : A Named Entity Extraction (NEE) service</para>
    ///   <para>rdfs:label : named entity extraction service</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#NEEService">onc:NEEService</a>
    /// </summary>
    let NEEService = _prefixId.prefix "NEEService"
    /// <summary>
    ///   <para>dcterms:description : A method used for ranking the entities or the entity URIs.</para>
    ///   <para>rdfs:label : ranking method</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#RankingMethod">onc:RankingMethod</a>
    /// </summary>
    let RankingMethod = _prefixId.prefix "RankingMethod"
    /// <summary>
    ///   <para>dcterms:description : Relates a NEE service to a resource, e.g. to a URL describing the API of a service.</para>
    ///   <para>rdfs:label : accessible through</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#accessibleThrough">onc:accessibleThrough</a>
    /// </summary>
    let accessibleThrough = _prefixId.prefix "accessibleThrough"
    /// <summary>
    ///   <para>dcterms:description : Relates a KBM to the URL of a SPARQL endpoint.</para>
    ///   <para>rdfs:label : endpoint</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#endpoint">onc:endpoint</a>
    /// </summary>
    let endpoint = _prefixId.prefix "endpoint"
    /// <summary>
    ///   <para>dcterms:description : Relates a category to a KBM.</para>
    ///   <para>rdfs:label : entities specification from</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#entitiesSpecFrom">onc:entitiesSpecFrom</a>
    /// </summary>
    let entitiesSpecFrom = _prefixId.prefix "entitiesSpecFrom"
    /// <summary>
    ///   <para>dcterms:description : Relates a ranking method to a resource, e.g. to a URL describing the ranking approach.</para>
    ///   <para>rdfs:label : is defined by</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#isDefinedBy">onc:isDefinedBy</a>
    /// </summary>
    let isDefinedBy = _prefixId.prefix "isDefinedBy"
    /// <summary>
    ///   <para>dcterms:description : Relates a configuration to a method for ranking entities.</para>
    ///   <para>rdfs:label : ranks entities using</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#ranksEntitiesUsing">onc:ranksEntitiesUsing</a>
    /// </summary>
    let ranksEntitiesUsing = _prefixId.prefix "ranksEntitiesUsing"
    /// <summary>
    ///   <para>dcterms:description : Relates a configuration to a method for ranking resources.</para>
    ///   <para>rdfs:label : ranks resources using</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#ranksResourcesUsing">onc:ranksResourcesUsing</a>
    /// </summary>
    let ranksResourcesUsing = _prefixId.prefix "ranksResourcesUsing"
    /// <summary>
    ///   <para>dcterms:description : Relates a NEE service to a configuration, or a configuration to a supported category.</para>
    ///   <para>rdfs:label : supports</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#supports">onc:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>dcterms:description : Relates a KBM to an entity-enrichment specification.</para>
    ///   <para>rdfs:label : uses entity enrichment specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesEntityEnrichmentSpec">onc:usesEntityEnrichmentSpec</a>
    /// </summary>
    let usesEntityEnrichmentSpec = _prefixId.prefix "usesEntityEnrichmentSpec"
    /// <summary>
    ///   <para>dcterms:description : Relates a KBM to an entity-linking specification.</para>
    ///   <para>rdfs:label : uses entity linking specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesEntityLinkingSpec">onc:usesEntityLinkingSpec</a>
    /// </summary>
    let usesEntityLinkingSpec = _prefixId.prefix "usesEntityLinkingSpec"
    /// <summary>
    ///   <para>dcterms:description : Relates a KBM to specification of entity names.</para>
    ///   <para>rdfs:label : uses entity names specification</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesEntityNamesSpec">onc:usesEntityNamesSpec</a>
    /// </summary>
    let usesEntityNamesSpec = _prefixId.prefix "usesEntityNamesSpec"
    /// <summary>
    ///   <para>dcterms:description : Relates a specification of entity names to a SPARQL query.</para>
    ///   <para>rdfs:label : uses SPARQL query</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlQuery">onc:usesSparqlQuery</a>
    /// </summary>
    let usesSparqlQuery = _prefixId.prefix "usesSparqlQuery"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity-linking or entity-enrichment specification to a SPARQL template parameter.</para>
    ///   <para>rdfs:label : uses SPARQL template parameter</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateParam">onc:usesSparqlTemplateParam</a>
    /// </summary>
    let usesSparqlTemplateParam = _prefixId.prefix "usesSparqlTemplateParam"
    /// <summary>
    ///   <para>dcterms:description : Relates an entity-linking or entity-enrichment specification to a SPARQL template query.</para>
    ///   <para>rdfs:label : uses SPARQL template query</para>
    ///   <a href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateQuery">onc:usesSparqlTemplateQuery</a>
    /// </summary>
    let usesSparqlTemplateQuery = _prefixId.prefix "usesSparqlTemplateQuery"

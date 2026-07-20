namespace http.www.ics.forth.gr.isl.oncm.core.hash

open DoxAletheia

module onc =
    let _namespace_name = "http://www.ics.forth.gr/isl/oncm/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#Category"></see>
    /// </summary>
    let Category = _prefix "Category"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#Configuration"></see>
    /// </summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityEnrichmentSpec"></see>
    /// </summary>
    let EntityEnrichmentSpec = _prefix "EntityEnrichmentSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityLinkingSpec"></see>
    /// </summary>
    let EntityLinkingSpec = _prefix "EntityLinkingSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityNamesSpec"></see>
    /// </summary>
    let EntityNamesSpec = _prefix "EntityNamesSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#KBM"></see>
    /// </summary>
    let KBM = _prefix "KBM"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#NEEService"></see>
    /// </summary>
    let NEEService = _prefix "NEEService"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#RankingMethod"></see>
    /// </summary>
    let RankingMethod = _prefix "RankingMethod"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#accessibleThrough"></see>
    /// </summary>
    let accessibleThrough = _prefix "accessibleThrough"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#endpoint"></see>
    /// </summary>
    let endpoint = _prefix "endpoint"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#entitiesSpecFrom"></see>
    /// </summary>
    let entitiesSpecFrom = _prefix "entitiesSpecFrom"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#isDefinedBy"></see>
    /// </summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#ranksEntitiesUsing"></see>
    /// </summary>
    let ranksEntitiesUsing = _prefix "ranksEntitiesUsing"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#ranksResourcesUsing"></see>
    /// </summary>
    let ranksResourcesUsing = _prefix "ranksResourcesUsing"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#supports"></see>
    /// </summary>
    let supports = _prefix "supports"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityEnrichmentSpec"></see>
    /// </summary>
    let usesEntityEnrichmentSpec = _prefix "usesEntityEnrichmentSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityLinkingSpec"></see>
    /// </summary>
    let usesEntityLinkingSpec = _prefix "usesEntityLinkingSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityNamesSpec"></see>
    /// </summary>
    let usesEntityNamesSpec = _prefix "usesEntityNamesSpec"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlQuery"></see>
    /// </summary>
    let usesSparqlQuery = _prefix "usesSparqlQuery"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateParam"></see>
    /// </summary>
    let usesSparqlTemplateParam = _prefix "usesSparqlTemplateParam"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateQuery"></see>
    /// </summary>
    let usesSparqlTemplateQuery = _prefix "usesSparqlTemplateQuery"

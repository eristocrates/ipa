namespace http.www.ics.forth.gr.isl.oncm.core.hash

open DoxAletheia.Rdf_Vocabulary

module onc =
    let _namespace_name = "http://www.ics.forth.gr/isl/oncm/core#"
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#Category"></see>
    /// </summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#Configuration"></see>
    /// </summary>
    let Configuration =
        Namespaced_IRI.parse _namespace_name "Configuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityEnrichmentSpec"></see>
    /// </summary>
    let EntityEnrichmentSpec =
        Namespaced_IRI.parse _namespace_name "EntityEnrichmentSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityLinkingSpec"></see>
    /// </summary>
    let EntityLinkingSpec =
        Namespaced_IRI.parse _namespace_name "EntityLinkingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#EntityNamesSpec"></see>
    /// </summary>
    let EntityNamesSpec =
        Namespaced_IRI.parse _namespace_name "EntityNamesSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#KBM"></see>
    /// </summary>
    let KBM = Namespaced_IRI.parse _namespace_name "KBM" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#NEEService"></see>
    /// </summary>
    let NEEService = Namespaced_IRI.parse _namespace_name "NEEService" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#RankingMethod"></see>
    /// </summary>
    let RankingMethod =
        Namespaced_IRI.parse _namespace_name "RankingMethod" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#accessibleThrough"></see>
    /// </summary>
    let accessibleThrough =
        Namespaced_IRI.parse _namespace_name "accessibleThrough" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#endpoint"></see>
    /// </summary>
    let endpoint = Namespaced_IRI.parse _namespace_name "endpoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#entitiesSpecFrom"></see>
    /// </summary>
    let entitiesSpecFrom =
        Namespaced_IRI.parse _namespace_name "entitiesSpecFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#isDefinedBy"></see>
    /// </summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#ranksEntitiesUsing"></see>
    /// </summary>
    let ranksEntitiesUsing =
        Namespaced_IRI.parse _namespace_name "ranksEntitiesUsing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#ranksResourcesUsing"></see>
    /// </summary>
    let ranksResourcesUsing =
        Namespaced_IRI.parse _namespace_name "ranksResourcesUsing" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#supports"></see>
    /// </summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityEnrichmentSpec"></see>
    /// </summary>
    let usesEntityEnrichmentSpec =
        Namespaced_IRI.parse _namespace_name "usesEntityEnrichmentSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityLinkingSpec"></see>
    /// </summary>
    let usesEntityLinkingSpec =
        Namespaced_IRI.parse _namespace_name "usesEntityLinkingSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesEntityNamesSpec"></see>
    /// </summary>
    let usesEntityNamesSpec =
        Namespaced_IRI.parse _namespace_name "usesEntityNamesSpec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlQuery"></see>
    /// </summary>
    let usesSparqlQuery =
        Namespaced_IRI.parse _namespace_name "usesSparqlQuery" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateParam"></see>
    /// </summary>
    let usesSparqlTemplateParam =
        Namespaced_IRI.parse _namespace_name "usesSparqlTemplateParam" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateQuery"></see>
    /// </summary>
    let usesSparqlTemplateQuery =
        Namespaced_IRI.parse _namespace_name "usesSparqlTemplateQuery" |> NamespacedName

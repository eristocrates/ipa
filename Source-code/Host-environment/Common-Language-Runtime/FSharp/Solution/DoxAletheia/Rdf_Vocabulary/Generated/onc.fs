namespace http.www.ics.forth.gr.isl.oncm.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module onc =
    let _namespace_iri = Namespace_Iri onc |> NamespaceIRI
    /// <summary>
    ///   <para>onc:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>category</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#Category">http://www.ics.forth.gr/isl/oncm/core#Category</seealso>
    let Category = Prefixed_Name(onc, "Category") |> PrefixedName
    /// <summary>
    ///   <para>onc:EntityLinkingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entity linking specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#EntityLinkingSpec">http://www.ics.forth.gr/isl/oncm/core#EntityLinkingSpec</seealso>
    let EntityLinkingSpec = Prefixed_Name(onc, "EntityLinkingSpec") |> PrefixedName
    /// <summary>
    ///   <para>onc:KBM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>knowledge base mirror</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#KBM">http://www.ics.forth.gr/isl/oncm/core#KBM</seealso>
    let KBM = Prefixed_Name(onc, "KBM") |> PrefixedName
    /// <summary>
    ///   <para>onc:NEEService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>named entity extraction service</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#NEEService">http://www.ics.forth.gr/isl/oncm/core#NEEService</seealso>
    let NEEService = Prefixed_Name(onc, "NEEService") |> PrefixedName
    /// <summary>
    ///   <para>onc:RankingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ranking method</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#RankingMethod">http://www.ics.forth.gr/isl/oncm/core#RankingMethod</seealso>
    let RankingMethod = Prefixed_Name(onc, "RankingMethod") |> PrefixedName
    /// <summary>
    ///   <para>onc:endpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>endpoint</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#endpoint">http://www.ics.forth.gr/isl/oncm/core#endpoint</seealso>
    let endpoint = Prefixed_Name(onc, "endpoint") |> PrefixedName
    /// <summary>
    ///   <para>onc:isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is defined by</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#isDefinedBy">http://www.ics.forth.gr/isl/oncm/core#isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(onc, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>onc:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>configuration</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#Configuration">http://www.ics.forth.gr/isl/oncm/core#Configuration</seealso>
    let Configuration = Prefixed_Name(onc, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>onc:EntityNamesSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entity names specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#EntityNamesSpec">http://www.ics.forth.gr/isl/oncm/core#EntityNamesSpec</seealso>
    let EntityNamesSpec = Prefixed_Name(onc, "EntityNamesSpec") |> PrefixedName
    /// <summary>
    ///   <para>onc:entitiesSpecFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>entities specification from</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#entitiesSpecFrom">http://www.ics.forth.gr/isl/oncm/core#entitiesSpecFrom</seealso>
    let entitiesSpecFrom = Prefixed_Name(onc, "entitiesSpecFrom") |> PrefixedName
    /// <summary>
    ///   <para>onc:ranksResourcesUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ranks resources using</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#ranksResourcesUsing">http://www.ics.forth.gr/isl/oncm/core#ranksResourcesUsing</seealso>
    let ranksResourcesUsing = Prefixed_Name(onc, "ranksResourcesUsing") |> PrefixedName

    /// <summary>
    ///   <para>onc:usesEntityEnrichmentSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses entity enrichment specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesEntityEnrichmentSpec">http://www.ics.forth.gr/isl/oncm/core#usesEntityEnrichmentSpec</seealso>
    let usesEntityEnrichmentSpec =
        Prefixed_Name(onc, "usesEntityEnrichmentSpec") |> PrefixedName

    /// <summary>
    ///   <para>onc:EntityEnrichmentSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>entity enrichment specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#EntityEnrichmentSpec">http://www.ics.forth.gr/isl/oncm/core#EntityEnrichmentSpec</seealso>
    let EntityEnrichmentSpec =
        Prefixed_Name(onc, "EntityEnrichmentSpec") |> PrefixedName

    /// <summary>
    ///   <para>onc:accessibleThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>accessible through</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#accessibleThrough">http://www.ics.forth.gr/isl/oncm/core#accessibleThrough</seealso>
    let accessibleThrough = Prefixed_Name(onc, "accessibleThrough") |> PrefixedName
    /// <summary>
    ///   <para>onc:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supports</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#supports">http://www.ics.forth.gr/isl/oncm/core#supports</seealso>
    let supports = Prefixed_Name(onc, "supports") |> PrefixedName
    /// <summary>
    ///   <para>onc:ranksEntitiesUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ranks entities using</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#ranksEntitiesUsing">http://www.ics.forth.gr/isl/oncm/core#ranksEntitiesUsing</seealso>
    let ranksEntitiesUsing = Prefixed_Name(onc, "ranksEntitiesUsing") |> PrefixedName

    /// <summary>
    ///   <para>onc:usesEntityLinkingSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses entity linking specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesEntityLinkingSpec">http://www.ics.forth.gr/isl/oncm/core#usesEntityLinkingSpec</seealso>
    let usesEntityLinkingSpec =
        Prefixed_Name(onc, "usesEntityLinkingSpec") |> PrefixedName

    /// <summary>
    ///   <para>onc:usesEntityNamesSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses entity names specification</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesEntityNamesSpec">http://www.ics.forth.gr/isl/oncm/core#usesEntityNamesSpec</seealso>
    let usesEntityNamesSpec = Prefixed_Name(onc, "usesEntityNamesSpec") |> PrefixedName
    /// <summary>
    ///   <para>onc:usesSparqlQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uses SPARQL query</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlQuery">http://www.ics.forth.gr/isl/oncm/core#usesSparqlQuery</seealso>
    let usesSparqlQuery = Prefixed_Name(onc, "usesSparqlQuery") |> PrefixedName

    /// <summary>
    ///   <para>onc:usesSparqlTemplateParam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uses SPARQL template parameter</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateParam">http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateParam</seealso>
    let usesSparqlTemplateParam =
        Prefixed_Name(onc, "usesSparqlTemplateParam") |> PrefixedName

    /// <summary>
    ///   <para>onc:usesSparqlTemplateQuery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>uses SPARQL template query</para></remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateQuery">http://www.ics.forth.gr/isl/oncm/core#usesSparqlTemplateQuery</seealso>
    let usesSparqlTemplateQuery =
        Prefixed_Name(onc, "usesSparqlTemplateQuery") |> PrefixedName

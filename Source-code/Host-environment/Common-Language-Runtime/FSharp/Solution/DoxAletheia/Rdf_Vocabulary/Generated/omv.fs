namespace http.omv.ontoware.org._2005._05.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omv =
    let _namespace_iri = Namespace_Iri omv |> NamespaceIRI
    /// <summary>
    ///   <para>omv:AnnotationTask</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#AnnotationTask">http://omv.ontoware.org/2005/05/ontology#AnnotationTask</seealso>
    let AnnotationTask = Prefixed_Name(omv, "AnnotationTask") |> PrefixedName
    /// <summary>
    ///   <para>omv:IndexingTask</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#IndexingTask">http://omv.ontoware.org/2005/05/ontology#IndexingTask</seealso>
    let IndexingTask = Prefixed_Name(omv, "IndexingTask") |> PrefixedName
    /// <summary>
    ///   <para>omv:IntegrationTask</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#IntegrationTask">http://omv.ontoware.org/2005/05/ontology#IntegrationTask</seealso>
    let IntegrationTask = Prefixed_Name(omv, "IntegrationTask") |> PrefixedName
    /// <summary>
    ///   <para>omv:OWL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#OWL">http://omv.ontoware.org/2005/05/ontology#OWL</seealso>
    let OWL = Prefixed_Name(omv, "OWL") |> PrefixedName

    /// <summary>
    ///   <para>omv:QueryFormulationTask</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#QueryFormulationTask">http://omv.ontoware.org/2005/05/ontology#QueryFormulationTask</seealso>
    let QueryFormulationTask =
        Prefixed_Name(omv, "QueryFormulationTask") |> PrefixedName

    /// <summary>
    ///   <para>omv:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#URI">http://omv.ontoware.org/2005/05/ontology#URI</seealso>
    let URI = Prefixed_Name(omv, "URI") |> PrefixedName
    /// <summary>
    ///   <para>omv:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#acronym">http://omv.ontoware.org/2005/05/ontology#acronym</seealso>
    let acronym = Prefixed_Name(omv, "acronym") |> PrefixedName

    /// <summary>
    ///   <para>omv:conformsToKnowledgeRepresentationParadigm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#conformsToKnowledgeRepresentationParadigm">http://omv.ontoware.org/2005/05/ontology#conformsToKnowledgeRepresentationParadigm</seealso>
    let conformsToKnowledgeRepresentationParadigm =
        Prefixed_Name(omv, "conformsToKnowledgeRepresentationParadigm") |> PrefixedName

    /// <summary>
    ///   <para>omv:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#creationDate">http://omv.ontoware.org/2005/05/ontology#creationDate</seealso>
    let creationDate = Prefixed_Name(omv, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>omv:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#description">http://omv.ontoware.org/2005/05/ontology#description</seealso>
    let description = Prefixed_Name(omv, "description") |> PrefixedName

    /// <summary>
    ///   <para>omv:designedForOntologyTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#designedForOntologyTask">http://omv.ontoware.org/2005/05/ontology#designedForOntologyTask</seealso>
    let designedForOntologyTask =
        Prefixed_Name(omv, "designedForOntologyTask") |> PrefixedName

    /// <summary>
    ///   <para>omv:documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#documentation">http://omv.ontoware.org/2005/05/ontology#documentation</seealso>
    let documentation = Prefixed_Name(omv, "documentation") |> PrefixedName
    /// <summary>
    ///   <para>omv:endorsedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#endorsedBy">http://omv.ontoware.org/2005/05/ontology#endorsedBy</seealso>
    let endorsedBy = Prefixed_Name(omv, "endorsedBy") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasDomain">http://omv.ontoware.org/2005/05/ontology#hasDomain</seealso>
    let hasDomain = Prefixed_Name(omv, "hasDomain") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasFormalityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasFormalityLevel">http://omv.ontoware.org/2005/05/ontology#hasFormalityLevel</seealso>
    let hasFormalityLevel = Prefixed_Name(omv, "hasFormalityLevel") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasOntologyLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasOntologyLanguage">http://omv.ontoware.org/2005/05/ontology#hasOntologyLanguage</seealso>
    let hasOntologyLanguage = Prefixed_Name(omv, "hasOntologyLanguage") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasOntologyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasOntologyName">http://omv.ontoware.org/2005/05/ontology#hasOntologyName</seealso>
    let hasOntologyName = Prefixed_Name(omv, "hasOntologyName") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasOntologySyntax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasOntologySyntax">http://omv.ontoware.org/2005/05/ontology#hasOntologySyntax</seealso>
    let hasOntologySyntax = Prefixed_Name(omv, "hasOntologySyntax") |> PrefixedName
    /// <summary>
    ///   <para>omv:hasOntologyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#hasOntologyType">http://omv.ontoware.org/2005/05/ontology#hasOntologyType</seealso>
    let hasOntologyType = Prefixed_Name(omv, "hasOntologyType") |> PrefixedName
    /// <summary>
    ///   <para>omv:keywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#keywords">http://omv.ontoware.org/2005/05/ontology#keywords</seealso>
    let keywords = Prefixed_Name(omv, "keywords") |> PrefixedName
    /// <summary>
    ///   <para>omv:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#name">http://omv.ontoware.org/2005/05/ontology#name</seealso>
    let name = Prefixed_Name(omv, "name") |> PrefixedName
    /// <summary>
    ///   <para>omv:naturalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#naturalLanguage">http://omv.ontoware.org/2005/05/ontology#naturalLanguage</seealso>
    let naturalLanguage = Prefixed_Name(omv, "naturalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>omv:ontologyPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#ontologyPurpose">http://omv.ontoware.org/2005/05/ontology#ontologyPurpose</seealso>
    let ontologyPurpose = Prefixed_Name(omv, "ontologyPurpose") |> PrefixedName
    /// <summary>
    ///   <para>omv:reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#reference">http://omv.ontoware.org/2005/05/ontology#reference</seealso>
    let reference = Prefixed_Name(omv, "reference") |> PrefixedName
    /// <summary>
    ///   <para>omv:resourceLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#resourceLocator">http://omv.ontoware.org/2005/05/ontology#resourceLocator</seealso>
    let resourceLocator = Prefixed_Name(omv, "resourceLocator") |> PrefixedName
    /// <summary>
    ///   <para>omv:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#status">http://omv.ontoware.org/2005/05/ontology#status</seealso>
    let status = Prefixed_Name(omv, "status") |> PrefixedName
    /// <summary>
    ///   <para>omv:useImports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#useImports">http://omv.ontoware.org/2005/05/ontology#useImports</seealso>
    let useImports = Prefixed_Name(omv, "useImports") |> PrefixedName

    /// <summary>
    ///   <para>omv:usedOntologyEngineeringMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#usedOntologyEngineeringMethodology">http://omv.ontoware.org/2005/05/ontology#usedOntologyEngineeringMethodology</seealso>
    let usedOntologyEngineeringMethodology =
        Prefixed_Name(omv, "usedOntologyEngineeringMethodology") |> PrefixedName

    /// <summary>
    ///   <para>omv:usedOntologyEngineeringTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#usedOntologyEngineeringTool">http://omv.ontoware.org/2005/05/ontology#usedOntologyEngineeringTool</seealso>
    let usedOntologyEngineeringTool =
        Prefixed_Name(omv, "usedOntologyEngineeringTool") |> PrefixedName

    /// <summary>
    ///   <para>omv:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://omv.ontoware.org/2005/05/ontology#version">http://omv.ontoware.org/2005/05/ontology#version</seealso>
    let version = Prefixed_Name(omv, "version") |> PrefixedName

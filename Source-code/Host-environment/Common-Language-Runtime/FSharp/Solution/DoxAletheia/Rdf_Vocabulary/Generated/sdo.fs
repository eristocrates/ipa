namespace http.salt.semanticauthoring.org.ontologies.sdo.hash

open DoxAletheia.Rdf_Vocabulary

module sdo =
    let _namespace_name = "http://salt.semanticauthoring.org/ontologies/sdo#"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Figure"></see>
    /// </summary>
    let Figure = Namespaced_IRI.parse _namespace_name "Figure" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Paragraph"></see>
    /// </summary>
    let Paragraph = Namespaced_IRI.parse _namespace_name "Paragraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Publication"></see>
    /// </summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Revision"></see>
    /// </summary>
    let Revision = Namespaced_IRI.parse _namespace_name "Revision" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Section"></see>
    /// </summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Sentence"></see>
    /// </summary>
    let Sentence = Namespaced_IRI.parse _namespace_name "Sentence" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Table"></see>
    /// </summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#TextChunk"></see>
    /// </summary>
    let TextChunk = Namespaced_IRI.parse _namespace_name "TextChunk" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasAnnotation"></see>
    /// </summary>
    let hasAnnotation =
        Namespaced_IRI.parse _namespace_name "hasAnnotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasCaption"></see>
    /// </summary>
    let hasCaption = Namespaced_IRI.parse _namespace_name "hasCaption" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasEndPointer"></see>
    /// </summary>
    let hasEndPointer =
        Namespaced_IRI.parse _namespace_name "hasEndPointer" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasFigure"></see>
    /// </summary>
    let hasFigure = Namespaced_IRI.parse _namespace_name "hasFigure" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasOrderNumber"></see>
    /// </summary>
    let hasOrderNumber =
        Namespaced_IRI.parse _namespace_name "hasOrderNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasParagraph"></see>
    /// </summary>
    let hasParagraph =
        Namespaced_IRI.parse _namespace_name "hasParagraph" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasRevision"></see>
    /// </summary>
    let hasRevision =
        Namespaced_IRI.parse _namespace_name "hasRevision" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSALTVersion"></see>
    /// </summary>
    let hasSALTVersion =
        Namespaced_IRI.parse _namespace_name "hasSALTVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSection"></see>
    /// </summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSectionTitle"></see>
    /// </summary>
    let hasSectionTitle =
        Namespaced_IRI.parse _namespace_name "hasSectionTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSentence"></see>
    /// </summary>
    let hasSentence =
        Namespaced_IRI.parse _namespace_name "hasSentence" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasStartPointer"></see>
    /// </summary>
    let hasStartPointer =
        Namespaced_IRI.parse _namespace_name "hasStartPointer" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSubSection"></see>
    /// </summary>
    let hasSubSection =
        Namespaced_IRI.parse _namespace_name "hasSubSection" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasTable"></see>
    /// </summary>
    let hasTable = Namespaced_IRI.parse _namespace_name "hasTable" |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasTextChunk"></see>
    /// </summary>
    let hasTextChunk =
        Namespaced_IRI.parse _namespace_name "hasTextChunk" |> NamespacedName

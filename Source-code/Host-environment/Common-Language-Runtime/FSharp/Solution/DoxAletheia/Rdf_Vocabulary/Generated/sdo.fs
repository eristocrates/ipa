namespace http.salt.semanticauthoring.org.ontologies.sdo.hash

open DoxAletheia

module sdo =
    let _namespace_name = "http://salt.semanticauthoring.org/ontologies/sdo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Figure"></see>
    /// </summary>
    let Figure = _prefix "Figure"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Paragraph"></see>
    /// </summary>
    let Paragraph = _prefix "Paragraph"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Publication"></see>
    /// </summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Revision"></see>
    /// </summary>
    let Revision = _prefix "Revision"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Section"></see>
    /// </summary>
    let Section = _prefix "Section"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Sentence"></see>
    /// </summary>
    let Sentence = _prefix "Sentence"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#Table"></see>
    /// </summary>
    let Table = _prefix "Table"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#TextChunk"></see>
    /// </summary>
    let TextChunk = _prefix "TextChunk"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasAnnotation"></see>
    /// </summary>
    let hasAnnotation = _prefix "hasAnnotation"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasCaption"></see>
    /// </summary>
    let hasCaption = _prefix "hasCaption"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasEndPointer"></see>
    /// </summary>
    let hasEndPointer = _prefix "hasEndPointer"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasFigure"></see>
    /// </summary>
    let hasFigure = _prefix "hasFigure"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasOrderNumber"></see>
    /// </summary>
    let hasOrderNumber = _prefix "hasOrderNumber"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasParagraph"></see>
    /// </summary>
    let hasParagraph = _prefix "hasParagraph"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasRevision"></see>
    /// </summary>
    let hasRevision = _prefix "hasRevision"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSALTVersion"></see>
    /// </summary>
    let hasSALTVersion = _prefix "hasSALTVersion"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSection"></see>
    /// </summary>
    let hasSection = _prefix "hasSection"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSectionTitle"></see>
    /// </summary>
    let hasSectionTitle = _prefix "hasSectionTitle"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSentence"></see>
    /// </summary>
    let hasSentence = _prefix "hasSentence"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasStartPointer"></see>
    /// </summary>
    let hasStartPointer = _prefix "hasStartPointer"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasSubSection"></see>
    /// </summary>
    let hasSubSection = _prefix "hasSubSection"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasTable"></see>
    /// </summary>
    let hasTable = _prefix "hasTable"
    /// <summary>
    ///   <see href="http://salt.semanticauthoring.org/ontologies/sdo#hasTextChunk"></see>
    /// </summary>
    let hasTextChunk = _prefix "hasTextChunk"

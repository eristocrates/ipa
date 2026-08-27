namespace http.salt.semanticauthoring.org.ontologies.sdo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdo =
    let _namespace_iri = Namespace_Iri sdo |> NamespaceIRI
    /// <summary>
    ///   <para>sdo:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Figure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Figure">http://salt.semanticauthoring.org/ontologies/sdo#Figure</seealso>
    let Figure = Prefixed_Name(sdo, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Paragraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Paragraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Paragraph">http://salt.semanticauthoring.org/ontologies/sdo#Paragraph</seealso>
    let Paragraph = Prefixed_Name(sdo, "Paragraph") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Publication"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Publication">http://salt.semanticauthoring.org/ontologies/sdo#Publication</seealso>
    let Publication = Prefixed_Name(sdo, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Revision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Revision">http://salt.semanticauthoring.org/ontologies/sdo#Revision</seealso>
    let Revision = Prefixed_Name(sdo, "Revision") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Section">http://salt.semanticauthoring.org/ontologies/sdo#Section</seealso>
    let Section = Prefixed_Name(sdo, "Section") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Sentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Sentence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Sentence">http://salt.semanticauthoring.org/ontologies/sdo#Sentence</seealso>
    let Sentence = Prefixed_Name(sdo, "Sentence") |> PrefixedName
    /// <summary>
    ///   <para>sdo:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Table"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#Table">http://salt.semanticauthoring.org/ontologies/sdo#Table</seealso>
    let Table = Prefixed_Name(sdo, "Table") |> PrefixedName
    /// <summary>
    ///   <para>sdo:TextChunk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"TextChunk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#TextChunk">http://salt.semanticauthoring.org/ontologies/sdo#TextChunk</seealso>
    let TextChunk = Prefixed_Name(sdo, "TextChunk") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasAnnotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasAnnotation">http://salt.semanticauthoring.org/ontologies/sdo#hasAnnotation</seealso>
    let hasAnnotation = Prefixed_Name(sdo, "hasAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasCaption</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasCaption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasCaption">http://salt.semanticauthoring.org/ontologies/sdo#hasCaption</seealso>
    let hasCaption = Prefixed_Name(sdo, "hasCaption") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasEndPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasEndPointer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasEndPointer">http://salt.semanticauthoring.org/ontologies/sdo#hasEndPointer</seealso>
    let hasEndPointer = Prefixed_Name(sdo, "hasEndPointer") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasFigure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasFigure">http://salt.semanticauthoring.org/ontologies/sdo#hasFigure</seealso>
    let hasFigure = Prefixed_Name(sdo, "hasFigure") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasOrderNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasOrderNumber">http://salt.semanticauthoring.org/ontologies/sdo#hasOrderNumber</seealso>
    let hasOrderNumber = Prefixed_Name(sdo, "hasOrderNumber") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasParagraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasParagraph"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasParagraph">http://salt.semanticauthoring.org/ontologies/sdo#hasParagraph</seealso>
    let hasParagraph = Prefixed_Name(sdo, "hasParagraph") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasRevision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasRevision">http://salt.semanticauthoring.org/ontologies/sdo#hasRevision</seealso>
    let hasRevision = Prefixed_Name(sdo, "hasRevision") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasSALTVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasSALTVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasSALTVersion">http://salt.semanticauthoring.org/ontologies/sdo#hasSALTVersion</seealso>
    let hasSALTVersion = Prefixed_Name(sdo, "hasSALTVersion") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasSection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasSection">http://salt.semanticauthoring.org/ontologies/sdo#hasSection</seealso>
    let hasSection = Prefixed_Name(sdo, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasSectionTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasSectionTitle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasSectionTitle">http://salt.semanticauthoring.org/ontologies/sdo#hasSectionTitle</seealso>
    let hasSectionTitle = Prefixed_Name(sdo, "hasSectionTitle") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasSentence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasSentence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasSentence">http://salt.semanticauthoring.org/ontologies/sdo#hasSentence</seealso>
    let hasSentence = Prefixed_Name(sdo, "hasSentence") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasStartPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasStartPointer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasStartPointer">http://salt.semanticauthoring.org/ontologies/sdo#hasStartPointer</seealso>
    let hasStartPointer = Prefixed_Name(sdo, "hasStartPointer") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasSubSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasSubSection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasSubSection">http://salt.semanticauthoring.org/ontologies/sdo#hasSubSection</seealso>
    let hasSubSection = Prefixed_Name(sdo, "hasSubSection") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasTable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasTable">http://salt.semanticauthoring.org/ontologies/sdo#hasTable</seealso>
    let hasTable = Prefixed_Name(sdo, "hasTable") |> PrefixedName
    /// <summary>
    ///   <para>sdo:hasTextChunk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"hasTextChunk"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://salt.semanticauthoring.org/ontologies/sdo#hasTextChunk">http://salt.semanticauthoring.org/ontologies/sdo#hasTextChunk</seealso>
    let hasTextChunk = Prefixed_Name(sdo, "hasTextChunk") |> PrefixedName

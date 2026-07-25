namespace http.www.w3.org.ns.rdfa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdfa =
    let _namespace_iri = Namespace_Iri rdfa |> NamespaceIRI
    /// <summary>
    ///   <para>rdfa:DocumentError</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#DocumentError">http://www.w3.org/ns/rdfa#DocumentError</seealso>
    let DocumentError = Prefixed_Name(rdfa, "DocumentError") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:Info</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#Info">http://www.w3.org/ns/rdfa#Info</seealso>
    let Info = Prefixed_Name(rdfa, "Info") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:PrefixMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#PrefixMapping">http://www.w3.org/ns/rdfa#PrefixMapping</seealso>
    let PrefixMapping = Prefixed_Name(rdfa, "PrefixMapping") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:PrefixRedefinition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#PrefixRedefinition">http://www.w3.org/ns/rdfa#PrefixRedefinition</seealso>
    let PrefixRedefinition = Prefixed_Name(rdfa, "PrefixRedefinition") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:UnresolvedCURIE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#UnresolvedCURIE">http://www.w3.org/ns/rdfa#UnresolvedCURIE</seealso>
    let UnresolvedCURIE = Prefixed_Name(rdfa, "UnresolvedCURIE") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:Error</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#Error">http://www.w3.org/ns/rdfa#Error</seealso>
    let Error = Prefixed_Name(rdfa, "Error") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:PrefixOrTermMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#PrefixOrTermMapping">http://www.w3.org/ns/rdfa#PrefixOrTermMapping</seealso>
    let PrefixOrTermMapping = Prefixed_Name(rdfa, "PrefixOrTermMapping") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#Pattern">http://www.w3.org/ns/rdfa#Pattern</seealso>
    let Pattern = Prefixed_Name(rdfa, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:TermMapping</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#TermMapping">http://www.w3.org/ns/rdfa#TermMapping</seealso>
    let TermMapping = Prefixed_Name(rdfa, "TermMapping") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#context">http://www.w3.org/ns/rdfa#context</seealso>
    let context = Prefixed_Name(rdfa, "context") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:Warning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#Warning">http://www.w3.org/ns/rdfa#Warning</seealso>
    let Warning = Prefixed_Name(rdfa, "Warning") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:VocabReferenceError</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#VocabReferenceError">http://www.w3.org/ns/rdfa#VocabReferenceError</seealso>
    let VocabReferenceError = Prefixed_Name(rdfa, "VocabReferenceError") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#prefix">http://www.w3.org/ns/rdfa#prefix</seealso>
    let prefix = Prefixed_Name(rdfa, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:term</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#term">http://www.w3.org/ns/rdfa#term</seealso>
    let term = Prefixed_Name(rdfa, "term") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:usesVocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#usesVocabulary">http://www.w3.org/ns/rdfa#usesVocabulary</seealso>
    let usesVocabulary = Prefixed_Name(rdfa, "usesVocabulary") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:UnresolvedTerm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#UnresolvedTerm">http://www.w3.org/ns/rdfa#UnresolvedTerm</seealso>
    let UnresolvedTerm = Prefixed_Name(rdfa, "UnresolvedTerm") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:copy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#copy">http://www.w3.org/ns/rdfa#copy</seealso>
    let copy = Prefixed_Name(rdfa, "copy") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#uri">http://www.w3.org/ns/rdfa#uri</seealso>
    let uri = Prefixed_Name(rdfa, "uri") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#vocabulary">http://www.w3.org/ns/rdfa#vocabulary</seealso>
    let vocabulary = Prefixed_Name(rdfa, "vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#">http://www.w3.org/ns/rdfa#</seealso>
    let _prefix_iri = Prefixed_Name(rdfa, "") |> PrefixedName
    /// <summary>
    ///   <para>rdfa:PGClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/rdfa#PGClass">http://www.w3.org/ns/rdfa#PGClass</seealso>
    let PGClass = Prefixed_Name(rdfa, "PGClass") |> PrefixedName

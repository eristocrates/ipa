namespace http.www.w3.org._2004._02.skos.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module skos =
    let _namespace_iri = Namespace_Iri skos |> NamespaceIRI
    /// <summary>
    ///   <para>skos:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Collection</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#Collection">http://www.w3.org/2004/02/skos/core#Collection</seealso>
    let Collection = Prefixed_Name(skos, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>skos:ConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Concept Scheme</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#ConceptScheme">http://www.w3.org/2004/02/skos/core#ConceptScheme</seealso>
    let ConceptScheme = Prefixed_Name(skos, "ConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>skos:OrderedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ordered Collection</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#OrderedCollection">http://www.w3.org/2004/02/skos/core#OrderedCollection</seealso>
    let OrderedCollection = Prefixed_Name(skos, "OrderedCollection") |> PrefixedName
    /// <summary>
    ///   <para>skos:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Concept</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#Concept">http://www.w3.org/2004/02/skos/core#Concept</seealso>
    let Concept = Prefixed_Name(skos, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>skos:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>example</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#example">http://www.w3.org/2004/02/skos/core#example</seealso>
    let example = Prefixed_Name(skos, "example") |> PrefixedName
    /// <summary>
    ///   <para>skos:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:related is disjoint with skos:broaderTransitive</para>
    /// labels<para>has related</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#related">http://www.w3.org/2004/02/skos/core#related</seealso>
    let related = Prefixed_Name(skos, "related") |> PrefixedName
    /// <summary>
    ///   <para>skos:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>definition</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#definition">http://www.w3.org/2004/02/skos/core#definition</seealso>
    let definition = Prefixed_Name(skos, "definition") |> PrefixedName
    /// <summary>
    ///   <para>skos:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A resource has no more than one value of skos:prefLabel per language tag, and no more than one value of skos:prefLabel without language tag.</para>
    ///   <para>skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise
    ///       disjoint properties.</para>
    ///   <para>The range of skos:prefLabel is the class of RDF plain literals.</para>
    /// labels<para>preferred label</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#prefLabel">http://www.w3.org/2004/02/skos/core#prefLabel</seealso>
    let prefLabel = Prefixed_Name(skos, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:relatedMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has related match</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#relatedMatch">http://www.w3.org/2004/02/skos/core#relatedMatch</seealso>
    let relatedMatch = Prefixed_Name(skos, "relatedMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:mappingRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>These concept mapping relations mirror semantic relations, and the data model defined below is similar (with the exception of skos:exactMatch) to the data model defined for semantic relations. A distinct vocabulary is provided for concept mapping relations, to provide a convenient way to differentiate links within a concept scheme from links between concept schemes. However, this pattern of usage is not a formal requirement of the SKOS data model, and relies on informal definitions of best practice.</para>
    /// labels<para>is in mapping relation with</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#mappingRelation">http://www.w3.org/2004/02/skos/core#mappingRelation</seealso>
    let mappingRelation = Prefixed_Name(skos, "mappingRelation") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrower</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Narrower concepts are typically rendered as children in a concept hierarchy (tree).</para>
    /// labels<para>has narrower</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrower">http://www.w3.org/2004/02/skos/core#narrower</seealso>
    let narrower = Prefixed_Name(skos, "narrower") |> PrefixedName
    /// <summary>
    ///   <para>skos:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.</para>
    ///   <para>The range of skos:altLabel is the class of RDF plain literals.</para>
    /// labels<para>alternative label</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#altLabel">http://www.w3.org/2004/02/skos/core#altLabel</seealso>
    let altLabel = Prefixed_Name(skos, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:broader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Broader concepts are typically rendered as parents in a concept hierarchy (tree).</para>
    /// labels<para>has broader</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broader">http://www.w3.org/2004/02/skos/core#broader</seealso>
    let broader = Prefixed_Name(skos, "broader") |> PrefixedName
    /// <summary>
    ///   <para>skos:broadMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has broader match</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broadMatch">http://www.w3.org/2004/02/skos/core#broadMatch</seealso>
    let broadMatch = Prefixed_Name(skos, "broadMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:broaderTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has broader transitive</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#broaderTransitive">http://www.w3.org/2004/02/skos/core#broaderTransitive</seealso>
    let broaderTransitive = Prefixed_Name(skos, "broaderTransitive") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrowMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has narrower match</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrowMatch">http://www.w3.org/2004/02/skos/core#narrowMatch</seealso>
    let narrowMatch = Prefixed_Name(skos, "narrowMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:changeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>change note</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#changeNote">http://www.w3.org/2004/02/skos/core#changeNote</seealso>
    let changeNote = Prefixed_Name(skos, "changeNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:semanticRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is in semantic relation with</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#semanticRelation">http://www.w3.org/2004/02/skos/core#semanticRelation</seealso>
    let semanticRelation = Prefixed_Name(skos, "semanticRelation") |> PrefixedName
    /// <summary>
    ///   <para>skos:closeMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>has close match</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#closeMatch">http://www.w3.org/2004/02/skos/core#closeMatch</seealso>
    let closeMatch = Prefixed_Name(skos, "closeMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:exactMatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>skos:exactMatch is disjoint with each of the properties skos:broadMatch and skos:relatedMatch.</para>
    /// labels<para>has exact match</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#exactMatch">http://www.w3.org/2004/02/skos/core#exactMatch</seealso>
    let exactMatch = Prefixed_Name(skos, "exactMatch") |> PrefixedName
    /// <summary>
    ///   <para>skos:hasTopConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has top concept</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#hasTopConcept">http://www.w3.org/2004/02/skos/core#hasTopConcept</seealso>
    let hasTopConcept = Prefixed_Name(skos, "hasTopConcept") |> PrefixedName
    /// <summary>
    ///   <para>skos:topConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is top concept in scheme</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#topConceptOf">http://www.w3.org/2004/02/skos/core#topConceptOf</seealso>
    let topConceptOf = Prefixed_Name(skos, "topConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>skos:narrowerTransitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has narrower transitive</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#narrowerTransitive">http://www.w3.org/2004/02/skos/core#narrowerTransitive</seealso>
    let narrowerTransitive = Prefixed_Name(skos, "narrowerTransitive") |> PrefixedName
    /// <summary>
    ///   <para>skos:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>note</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#note">http://www.w3.org/2004/02/skos/core#note</seealso>
    let note = Prefixed_Name(skos, "note") |> PrefixedName
    /// <summary>
    ///   <para>skos:editorialNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>editorial note</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#editorialNote">http://www.w3.org/2004/02/skos/core#editorialNote</seealso>
    let editorialNote = Prefixed_Name(skos, "editorialNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:historyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>history note</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#historyNote">http://www.w3.org/2004/02/skos/core#historyNote</seealso>
    let historyNote = Prefixed_Name(skos, "historyNote") |> PrefixedName
    /// <summary>
    ///   <para>skos:hiddenLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The range of skos:hiddenLabel is the class of RDF plain literals.</para>
    ///   <para>skos:prefLabel, skos:altLabel and skos:hiddenLabel are pairwise disjoint properties.</para>
    /// labels<para>hidden label</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#hiddenLabel">http://www.w3.org/2004/02/skos/core#hiddenLabel</seealso>
    let hiddenLabel = Prefixed_Name(skos, "hiddenLabel") |> PrefixedName
    /// <summary>
    ///   <para>skos:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#member">http://www.w3.org/2004/02/skos/core#member</seealso>
    let member_ = Prefixed_Name(skos, "member") |> PrefixedName
    /// <summary>
    ///   <para>skos:memberList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>For any resource, every item in the list given as the value of the
    ///       skos:memberList property is also a value of the skos:member property.</para>
    /// labels<para>has member list</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#memberList">http://www.w3.org/2004/02/skos/core#memberList</seealso>
    let memberList = Prefixed_Name(skos, "memberList") |> PrefixedName
    /// <summary>
    ///   <para>skos:notation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>notation</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#notation">http://www.w3.org/2004/02/skos/core#notation</seealso>
    let notation = Prefixed_Name(skos, "notation") |> PrefixedName
    /// <summary>
    ///   <para>skos:inScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is in scheme</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#inScheme">http://www.w3.org/2004/02/skos/core#inScheme</seealso>
    let inScheme = Prefixed_Name(skos, "inScheme") |> PrefixedName
    /// <summary>
    ///   <para>skos:scopeNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>scope note</para></remarks>
    /// <seealso href="http://www.w3.org/2004/02/skos/core#scopeNote">http://www.w3.org/2004/02/skos/core#scopeNote</seealso>
    let scopeNote = Prefixed_Name(skos, "scopeNote") |> PrefixedName

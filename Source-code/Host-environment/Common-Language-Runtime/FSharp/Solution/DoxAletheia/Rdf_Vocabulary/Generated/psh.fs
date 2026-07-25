namespace http.ns.inria.fr.probabilistic_shacl.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module psh =
    let _namespace_iri = Namespace_Iri psh |> NamespaceIRI

    /// <summary>
    ///   <para>psh:referenceCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the number of RDF triples tested during the validation of the current shape</para>
    /// labels<para>reference cardinality</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/referenceCardinality">http://ns.inria.fr/probabilistic-shacl/referenceCardinality</seealso>
    let referenceCardinality =
        Prefixed_Name(psh, "referenceCardinality") |> PrefixedName

    /// <summary>
    ///   <para>psh:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The probabilistic validation results contained in a validation report.</para>
    /// labels<para>summary</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/summary">http://ns.inria.fr/probabilistic-shacl/summary</seealso>
    let summary = Prefixed_Name(psh, "summary") |> PrefixedName
    /// <summary>
    ///   <para>psh:ValidationSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of probabilistic validation summary</para>
    /// labels<para>Validation summary</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/ValidationSummary">http://ns.inria.fr/probabilistic-shacl/ValidationSummary</seealso>
    let ValidationSummary = Prefixed_Name(psh, "ValidationSummary") |> PrefixedName
    /// <summary>
    ///   <para>psh:generality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the representativeness of the current shape</para>
    /// labels<para>generality</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/generality">http://ns.inria.fr/probabilistic-shacl/generality</seealso>
    let generality = Prefixed_Name(psh, "generality") |> PrefixedName
    /// <summary>
    ///   <para>psh:numConfirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the number of nodes that confirm the current shape</para>
    /// labels<para>number of confirmation</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/numConfirmation">http://ns.inria.fr/probabilistic-shacl/numConfirmation</seealso>
    let numConfirmation = Prefixed_Name(psh, "numConfirmation") |> PrefixedName
    /// <summary>
    ///   <para>psh:likelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the likelihood to observe the number of exceptions among the RDF triples tested (i.e. referenceCardinality)</para>
    /// labels<para>likelihood</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/likelihood">http://ns.inria.fr/probabilistic-shacl/likelihood</seealso>
    let likelihood = Prefixed_Name(psh, "likelihood") |> PrefixedName
    /// <summary>
    ///   <para>psh:numViolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the number of nodes that contradict the current shape</para>
    /// labels<para>number of violation</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/numViolation">http://ns.inria.fr/probabilistic-shacl/numViolation</seealso>
    let numViolation = Prefixed_Name(psh, "numViolation") |> PrefixedName
    /// <summary>
    ///   <para>psh:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>This vocabulary defines terms used to include and exploit probabilistic information in SHACL validation reports</para>
    /// labels<para>Probabilistic SHACL Validation</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/">http://ns.inria.fr/probabilistic-shacl/</seealso>
    let _prefix_iri = Prefixed_Name(psh, "") |> PrefixedName
    /// <summary>
    ///   <para>psh:focusShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shape concerned by the results of the probabilistic validation</para>
    /// labels<para>focus shape</para></remarks>
    /// <seealso href="http://ns.inria.fr/probabilistic-shacl/focusShape">http://ns.inria.fr/probabilistic-shacl/focusShape</seealso>
    let focusShape = Prefixed_Name(psh, "focusShape") |> PrefixedName

namespace http.www.w3.org._2008._05.skos_xl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module skosxl =
    let _namespace_iri = Namespace_Iri skosxl |> NamespaceIRI
    /// <summary>
    ///   <para>skosxl:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Label</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#Label">http://www.w3.org/2008/05/skos-xl#Label</seealso>
    let Label = Prefixed_Name(skosxl, "Label") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:literalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The range of skosxl:literalForm is the class of RDF plain literals.</para>
    ///   <para>If two instances of the class skosxl:Label have the same literal form, they are not necessarily the same resource.</para>
    /// labels<para>literal form</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#literalForm">http://www.w3.org/2008/05/skos-xl#literalForm</seealso>
    let literalForm = Prefixed_Name(skosxl, "literalForm") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:hiddenLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>If C skosxl:hiddenLabel L and L skosxl:literalForm V, then C skos:hiddenLabel V.</para>
    /// labels<para>hidden label</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#hiddenLabel">http://www.w3.org/2008/05/skos-xl#hiddenLabel</seealso>
    let hiddenLabel = Prefixed_Name(skosxl, "hiddenLabel") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:labelRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>label relation</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#labelRelation">http://www.w3.org/2008/05/skos-xl#labelRelation</seealso>
    let labelRelation = Prefixed_Name(skosxl, "labelRelation") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If C skosxl:prefLabel L and L skosxl:literalForm V, then X skos:prefLabel V.</para>
    /// labels<para>preferred label</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#prefLabel">http://www.w3.org/2008/05/skos-xl#prefLabel</seealso>
    let prefLabel = Prefixed_Name(skosxl, "prefLabel") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If C skosxl:altLabel L and L skosxl:literalForm V, then X skos:altLabel V.</para>
    /// labels<para>alternative label</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#altLabel">http://www.w3.org/2008/05/skos-xl#altLabel</seealso>
    let altLabel = Prefixed_Name(skosxl, "altLabel") |> PrefixedName

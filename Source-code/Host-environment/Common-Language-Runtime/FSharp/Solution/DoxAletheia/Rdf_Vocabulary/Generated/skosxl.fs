namespace http.www.w3.org._2008._05.skos_xl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module skosxl =
    let _namespace_iri = Namespace_Iri skosxl |> NamespaceIRI
    /// <summary>
    ///   <para>skosxl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#">http://www.w3.org/2008/05/skos-xl#</seealso>
    let _prefix_iri = Prefixed_Name(skosxl, "") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Super class of ISO ThesaurusTerm and of ISO NodeLabel.
    ///
    /// A ThesaurusTerm has mandatory attributes lexicalValue and identifier. lexicalValue can be mapped to skos xl:literalForm. The value of identifier can be used as the URI of the skos xl:Label or as the object of a dc:identifier statement on that skos-xl:Label.
    /// A NodeLabel has mandatory attributes lexicalValue.
    ///
    /// The optional ISO25964 lang attribute of ThesaurusTerm and of NodeLabel must be mapped to RDF language tag for RDF plain literals.
    ///
    /// Attributes or associations not detailed below typically are mapped to dc: (or dct:) properties:
    /// - dct:created
    /// - dct:modified
    /// - dc:source"</para>
    /// labels<para>"Label"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#Label">http://www.w3.org/2008/05/skos-xl#Label</seealso>
    let Label = Prefixed_Name(skosxl, "Label") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Complex super property of ISO hasNonPreferredLabel
    ///
    /// Applies if the value of "hasNonPreferredLabel" is of class SimpleNonPreferredTerm with the Boolean attribute "hidden" either absent or with value false."</para>
    ///   <para>"If C skosxl:altLabel L and L skosxl:literalForm V, then X skos:altLabel V."</para>
    /// labels<para>"alternative label"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#altLabel">http://www.w3.org/2008/05/skos-xl#altLabel</seealso>
    let altLabel = Prefixed_Name(skosxl, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:hiddenLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Complex super property of ISO hasNonPreferredLabel
    ///
    /// Applies if the value of "hasNonPreferredLabel" is of class SimpleNonPreferredTerm with the Boolean attribute "hidden" having value true."</para>
    ///   <para>"If C skosxl:hiddenLabel L and L skosxl:literalForm V, then C skos:hiddenLabel V."</para>
    /// labels<para>"hidden label"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#hiddenLabel">http://www.w3.org/2008/05/skos-xl#hiddenLabel</seealso>
    let hiddenLabel = Prefixed_Name(skosxl, "hiddenLabel") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:labelRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"label relation"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#labelRelation">http://www.w3.org/2008/05/skos-xl#labelRelation</seealso>
    let labelRelation = Prefixed_Name(skosxl, "labelRelation") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:literalForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The range of skosxl:literalForm is the class of RDF plain literals."</para>
    ///   <para>"If two instances of the class skosxl:Label have the same literal form, they are not necessarily the same resource."</para>
    /// labels<para>"literal form"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#literalForm">http://www.w3.org/2008/05/skos-xl#literalForm</seealso>
    let literalForm = Prefixed_Name(skosxl, "literalForm") |> PrefixedName
    /// <summary>
    ///   <para>skosxl:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"If C skosxl:prefLabel L and L skosxl:literalForm V, then X skos:prefLabel V."</para>
    ///   <para>"Complex super property of ISO hasPreferredLabel
    ///
    /// When a label is represented as skos xl:Label, a skos:prefLabel statement is derived from the skos-xl:prefLabel one. (Likewise for altLabel and hiddenLabel.)"</para>
    /// labels<para>"preferred label"</para></remarks>
    /// <seealso href="http://www.w3.org/2008/05/skos-xl#prefLabel">http://www.w3.org/2008/05/skos-xl#prefLabel</seealso>
    let prefLabel = Prefixed_Name(skosxl, "prefLabel") |> PrefixedName

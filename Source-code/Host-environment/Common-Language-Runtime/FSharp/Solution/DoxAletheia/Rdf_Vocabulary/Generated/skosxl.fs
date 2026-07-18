namespace http.www.w3.org._2008._05.skos_xl.hash

open DoxAletheia.Rdf_Vocabulary

module skosxl =
    let _namespace_name = "http://www.w3.org/2008/05/skos-xl#"
    /// <summary>
    ///   <see href="http://www.w3.org/2008/05/skos-xl#Label"></see>
    /// </summary>
    let Label = Namespaced_IRI.parse _namespace_name "Label" |> NamespacedName

    /// <summary>
    /// The range of skosxl:literalForm is the class of RDF plain literals.
    /// If two instances of the class skosxl:Label have the same literal form, they are not necessarily the same resource.
    /// <see href="http://www.w3.org/2008/05/skos-xl#literalForm"></see></summary>
    let literalForm =
        Namespaced_IRI.parse _namespace_name "literalForm" |> NamespacedName

    /// <summary>
    /// If C skosxl:altLabel L and L skosxl:literalForm V, then X skos:altLabel V.
    /// <see href="http://www.w3.org/2008/05/skos-xl#altLabel"></see></summary>
    let altLabel = Namespaced_IRI.parse _namespace_name "altLabel" |> NamespacedName

    /// <summary>
    /// If C skosxl:hiddenLabel L and L skosxl:literalForm V, then C skos:hiddenLabel V.
    /// <see href="http://www.w3.org/2008/05/skos-xl#hiddenLabel"></see></summary>
    let hiddenLabel =
        Namespaced_IRI.parse _namespace_name "hiddenLabel" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2008/05/skos-xl#labelRelation"></see>
    /// </summary>
    let labelRelation =
        Namespaced_IRI.parse _namespace_name "labelRelation" |> NamespacedName

    /// <summary>
    /// If C skosxl:prefLabel L and L skosxl:literalForm V, then X skos:prefLabel V.
    /// <see href="http://www.w3.org/2008/05/skos-xl#prefLabel"></see></summary>
    let prefLabel = Namespaced_IRI.parse _namespace_name "prefLabel" |> NamespacedName

namespace http.data.press.net.ontology.tag.slash

open DoxAletheia.Rdf_Vocabulary

module pnt =
    let _namespace_name = "http://data.press.net/ontology/tag/"
    /// <summary>
    /// Generic Tag Class - Taggables are tagged with a Tag
    /// <see href="http://data.press.net/ontology/tag/Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// Generic Taggable Class - Taggable things can be tagged
    /// <see href="http://data.press.net/ontology/tag/Taggable"></see></summary>
    let Taggable = Namespaced_IRI.parse _namespace_name "Taggable" |> NamespacedName
    /// <summary>
    /// Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X about Tag Y.  pnt:about is a stronger relationship that pnt:mentions
    /// <see href="http://data.press.net/ontology/tag/about"></see></summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName

    /// <summary>
    /// Property that associates Tags with Taggables:  Taggable X isTaggedWith Tag Y
    /// <see href="http://data.press.net/ontology/tag/isTaggedWith"></see></summary>
    let isTaggedWith =
        Namespaced_IRI.parse _namespace_name "isTaggedWith" |> NamespacedName

    /// <summary>
    /// Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X mentions Tag Y.  pnt:mentions is a weaker relationship that pnt:about
    /// <see href="http://data.press.net/ontology/tag/mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName

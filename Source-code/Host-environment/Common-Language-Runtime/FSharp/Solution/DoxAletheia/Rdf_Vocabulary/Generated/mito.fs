namespace http.purl.org.spar.mito.slash

open DoxAletheia.Rdf_Vocabulary

module mito =
    let _namespace_name = "http://purl.org/spar/mito/"

    /// <summary>
    ///   <see href="http://purl.org/spar/mito/2024-05-09"></see>
    /// </summary>
    let ``_2024-05-09`` =
        Namespaced_IRI.parse _namespace_name "2024-05-09" |> NamespacedName

    /// <summary>
    /// Originally: the action of calling to mind or commemorating something in speech or writing. Subsequently in more restricted sense: the action or an act of referring to, remarking upon, or introducing the name of a person or thing in spoken or written discourse, often incidentally and as not necessarily essential to the discussion.
    /// Stated by https://www.oed.com/dictionary/mention_n?tl=true
    /// <see href="http://purl.org/spar/mito/Mention"></see></summary>
    let Mention = Namespaced_IRI.parse _namespace_name "Mention" |> NamespacedName

    /// <summary>
    /// The aim of this class is to reify the implicit or explicit characteristic of a mention.
    /// <see href="http://purl.org/spar/mito/MentionType"></see></summary>
    let MentionType =
        Namespaced_IRI.parse _namespace_name "MentionType" |> NamespacedName

    /// <summary>
    /// A property that aims to define the implicit or explicit character of the mention it is describing
    /// <see href="http://purl.org/spar/mito/hasMentionType"></see></summary>
    let hasMentionType =
        Namespaced_IRI.parse _namespace_name "hasMentionType" |> NamespacedName

    /// <summary>
    /// A property that relates the mention to the mentioned entity.
    /// <see href="http://purl.org/spar/mito/hasMentionedEntity"></see></summary>
    let hasMentionedEntity =
        Namespaced_IRI.parse _namespace_name "hasMentionedEntity" |> NamespacedName

    /// <summary>
    /// A property that relates the mention to the mentioning entity.
    /// <see href="http://purl.org/spar/mito/hasMentioningEntity"></see></summary>
    let hasMentioningEntity =
        Namespaced_IRI.parse _namespace_name "hasMentioningEntity" |> NamespacedName

    /// <summary>
    /// A property that connect the two sides involved in the act of mentioning
    /// <see href="http://purl.org/spar/mito/isMentionedBy"></see></summary>
    let isMentionedBy =
        Namespaced_IRI.parse _namespace_name "isMentionedBy" |> NamespacedName

    /// <summary>
    /// A property that connect the two sides involved in the act of mentioning
    /// <see href="http://purl.org/spar/mito/mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName

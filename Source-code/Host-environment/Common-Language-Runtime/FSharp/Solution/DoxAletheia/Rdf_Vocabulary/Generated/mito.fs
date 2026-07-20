namespace http.purl.org.spar.mito.slash

open DoxAletheia

module mito =
    let _namespace_name = "http://purl.org/spar/mito/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/mito/2024-05-09"></see>
    /// </summary>
    let ``_2024-05-09`` = _prefix "2024-05-09"
    /// <summary>
    /// Originally: the action of calling to mind or commemorating something in speech or writing. Subsequently in more restricted sense: the action or an act of referring to, remarking upon, or introducing the name of a person or thing in spoken or written discourse, often incidentally and as not necessarily essential to the discussion.
    /// Stated by https://www.oed.com/dictionary/mention_n?tl=true
    /// <see href="http://purl.org/spar/mito/Mention"></see></summary>
    let Mention = _prefix "Mention"
    /// <summary>
    /// The aim of this class is to reify the implicit or explicit characteristic of a mention.
    /// <see href="http://purl.org/spar/mito/MentionType"></see></summary>
    let MentionType = _prefix "MentionType"
    /// <summary>
    /// A property that aims to define the implicit or explicit character of the mention it is describing
    /// <see href="http://purl.org/spar/mito/hasMentionType"></see></summary>
    let hasMentionType = _prefix "hasMentionType"
    /// <summary>
    /// A property that relates the mention to the mentioned entity.
    /// <see href="http://purl.org/spar/mito/hasMentionedEntity"></see></summary>
    let hasMentionedEntity = _prefix "hasMentionedEntity"
    /// <summary>
    /// A property that relates the mention to the mentioning entity.
    /// <see href="http://purl.org/spar/mito/hasMentioningEntity"></see></summary>
    let hasMentioningEntity = _prefix "hasMentioningEntity"
    /// <summary>
    /// A property that connect the two sides involved in the act of mentioning
    /// <see href="http://purl.org/spar/mito/isMentionedBy"></see></summary>
    let isMentionedBy = _prefix "isMentionedBy"
    /// <summary>
    /// A property that connect the two sides involved in the act of mentioning
    /// <see href="http://purl.org/spar/mito/mentions"></see></summary>
    let mentions = _prefix "mentions"

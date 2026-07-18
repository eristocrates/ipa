namespace http.purl.org.media.hash

open DoxAletheia.Rdf_Vocabulary

module media =
    let _namespace_name = "http://purl.org/media#"
    /// <summary>
    /// A collection of
    ///             one or more media recordings.
    /// <see href="http://purl.org/media#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A recording of an item of interest in any form.
    /// <see href="http://purl.org/media#Recording"></see></summary>
    let Recording = Namespaced_IRI.parse _namespace_name "Recording" |> NamespacedName
    /// <summary>
    /// Relationship for
    ///             linking singular media recordings to collections or media recordings. Also used to denote pieces of a media recording that constitute a larger media recording..
    /// <see href="http://purl.org/media#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    /// An image summary
    ///             of the media recording.
    /// <see href="http://purl.org/media#depiction"></see></summary>
    let depiction = Namespaced_IRI.parse _namespace_name "depiction" |> NamespacedName
    /// <summary>
    /// A link to a
    ///             complete audio file representation of the media recording.
    /// <see href="http://purl.org/media#download"></see></summary>
    let download = Namespaced_IRI.parse _namespace_name "download" |> NamespacedName
    /// <summary>
    /// The length of the
    ///             media recording encoded in ISO-8601 time duration format.
    /// <see href="http://purl.org/media#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// The position of
    ///             the media recording in an album, LP, playlist, top 10 list,
    ///             podcast history or other ordered list of media recordings.
    /// <see href="http://purl.org/media#position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    /// A standards-body
    ///             rating such as PG-13, M, 18-SX, 15, AV15+, Explicit Lyrics,
    ///             etc.
    /// <see href="http://purl.org/media#rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName
    /// <summary>
    /// A link to a
    ///             sample file or stream of the media recording.
    /// <see href="http://purl.org/media#sample"></see></summary>
    let sample = Namespaced_IRI.parse _namespace_name "sample" |> NamespacedName

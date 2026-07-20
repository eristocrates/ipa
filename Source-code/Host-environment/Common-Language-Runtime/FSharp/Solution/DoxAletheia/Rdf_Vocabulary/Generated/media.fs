namespace http.purl.org.media.hash

open DoxAletheia

module media =
    let _namespace_name = "http://purl.org/media#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A collection of
    ///             one or more media recordings.
    /// <see href="http://purl.org/media#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A recording of an item of interest in any form.
    /// <see href="http://purl.org/media#Recording"></see></summary>
    let Recording = _prefix "Recording"
    /// <summary>
    /// Relationship for
    ///             linking singular media recordings to collections or media recordings. Also used to denote pieces of a media recording that constitute a larger media recording..
    /// <see href="http://purl.org/media#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// An image summary
    ///             of the media recording.
    /// <see href="http://purl.org/media#depiction"></see></summary>
    let depiction = _prefix "depiction"
    /// <summary>
    /// A link to a
    ///             complete audio file representation of the media recording.
    /// <see href="http://purl.org/media#download"></see></summary>
    let download = _prefix "download"
    /// <summary>
    /// The length of the
    ///             media recording encoded in ISO-8601 time duration format.
    /// <see href="http://purl.org/media#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The position of
    ///             the media recording in an album, LP, playlist, top 10 list,
    ///             podcast history or other ordered list of media recordings.
    /// <see href="http://purl.org/media#position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// A standards-body
    ///             rating such as PG-13, M, 18-SX, 15, AV15+, Explicit Lyrics,
    ///             etc.
    /// <see href="http://purl.org/media#rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// A link to a
    ///             sample file or stream of the media recording.
    /// <see href="http://purl.org/media#sample"></see></summary>
    let sample = _prefix "sample"

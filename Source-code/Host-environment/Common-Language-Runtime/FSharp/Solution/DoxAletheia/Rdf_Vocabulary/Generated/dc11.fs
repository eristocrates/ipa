namespace http.purl.org.dc.elements._1._1.slash

open DoxAletheia

module dc11 =
    let _namespace_name = "http://purl.org/dc/elements/1.1/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An entity responsible for making contributions to the resource.
    /// <see href="http://purl.org/dc/elements/1.1/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    /// <see href="http://purl.org/dc/elements/1.1/coverage"></see></summary>
    let coverage = _prefix "coverage"
    /// <summary>
    /// An entity primarily responsible for making the resource.
    /// <see href="http://purl.org/dc/elements/1.1/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// A point or period of time associated with an event in the lifecycle of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// An account of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// The file format, physical medium, or dimensions of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/format"></see></summary>
    let format = _prefix "format"
    /// <summary>
    /// An unambiguous reference to the resource within a given context.
    /// <see href="http://purl.org/dc/elements/1.1/identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// A language of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// An entity responsible for making the resource available.
    /// <see href="http://purl.org/dc/elements/1.1/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// A related resource.
    /// <see href="http://purl.org/dc/elements/1.1/relation"></see></summary>
    let relation = _prefix "relation"
    /// <summary>
    /// Information about rights held in and over the resource.
    /// <see href="http://purl.org/dc/elements/1.1/rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// A related resource from which the described resource is derived.
    /// <see href="http://purl.org/dc/elements/1.1/source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// The topic of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A name given to the resource.
    /// <see href="http://purl.org/dc/elements/1.1/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The nature or genre of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/type"></see></summary>
    let type_ = _prefix "type"

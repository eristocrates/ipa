namespace http.purl.org.dc.elements._1._1.slash

open DoxAletheia.Rdf_Vocabulary

module dc11 =
    let _namespace_name = "http://purl.org/dc/elements/1.1/"

    /// <summary>
    /// An entity responsible for making contributions to the resource.
    /// <see href="http://purl.org/dc/elements/1.1/contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// The spatial or temporal topic of the resource, the spatial applicability of the resource, or the jurisdiction under which the resource is relevant.
    /// <see href="http://purl.org/dc/elements/1.1/coverage"></see></summary>
    let coverage = Namespaced_IRI.parse _namespace_name "coverage" |> NamespacedName
    /// <summary>
    /// An entity primarily responsible for making the resource.
    /// <see href="http://purl.org/dc/elements/1.1/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// A point or period of time associated with an event in the lifecycle of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    /// An account of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// The file format, physical medium, or dimensions of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName
    /// <summary>
    /// An unambiguous reference to the resource within a given context.
    /// <see href="http://purl.org/dc/elements/1.1/identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName
    /// <summary>
    /// A language of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// An entity responsible for making the resource available.
    /// <see href="http://purl.org/dc/elements/1.1/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName
    /// <summary>
    /// A related resource.
    /// <see href="http://purl.org/dc/elements/1.1/relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName
    /// <summary>
    /// Information about rights held in and over the resource.
    /// <see href="http://purl.org/dc/elements/1.1/rights"></see></summary>
    let rights = Namespaced_IRI.parse _namespace_name "rights" |> NamespacedName
    /// <summary>
    /// A related resource from which the described resource is derived.
    /// <see href="http://purl.org/dc/elements/1.1/source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// The topic of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// A name given to the resource.
    /// <see href="http://purl.org/dc/elements/1.1/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// The nature or genre of the resource.
    /// <see href="http://purl.org/dc/elements/1.1/type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

namespace http.www.w3.org._2006.gen.ont.hash

open DoxAletheia.Rdf_Vocabulary

module gso =
    let _namespace_name = "http://www.w3.org/2006/gen/ont#"

    /// <summary>
    /// A resource which may have representations in
    ///     many different Content-Types.
    /// <see href="http://www.w3.org/2006/gen/ont#ContentTypeGenericResource"></see></summary>
    let ContentTypeGenericResource =
        Namespaced_IRI.parse _namespace_name "ContentTypeGenericResource" |> NamespacedName

    /// <summary>
    /// An Information Resource is defined by the Architecture of
    /// 	    the WWW.
    /// <see href="http://www.w3.org/2006/gen/ont#InformationResource"></see></summary>
    let InformationResource =
        Namespaced_IRI.parse _namespace_name "InformationResource" |> NamespacedName

    /// <summary>
    /// A resource of which all representations are in the
    /// 		same Internet media type, or 'Content-Type'.
    /// <see href="http://www.w3.org/2006/gen/ont#ContentTypeSpecificResource"></see></summary>
    let ContentTypeSpecificResource =
        Namespaced_IRI.parse _namespace_name "ContentTypeSpecificResource" |> NamespacedName

    /// <summary>
    /// A resource whose representation type and content will not
    /// 	    change under any circumstances.
    /// <see href="http://www.w3.org/2006/gen/ont#FixedResource"></see></summary>
    let FixedResource =
        Namespaced_IRI.parse _namespace_name "FixedResource" |> NamespacedName

    /// <summary>
    /// A resource of which all representations are in the
    /// 		same natural language.
    /// <see href="http://www.w3.org/2006/gen/ont#LanguageSpecificResource"></see></summary>
    let LanguageSpecificResource =
        Namespaced_IRI.parse _namespace_name "LanguageSpecificResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeSpecificResource"></see>
    /// </summary>
    let contentTypeSpecificResource =
        Namespaced_IRI.parse _namespace_name "contentTypeSpecificResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#timeSpecificResource"></see>
    /// </summary>
    let timeSpecificResource =
        Namespaced_IRI.parse _namespace_name "timeSpecificResource" |> NamespacedName

    /// <summary>
    /// A resource defiend without constraint as to
    /// 	the particular natural language in which it
    ///         maight be expressed.
    /// <see href="http://www.w3.org/2006/gen/ont#LanguageGenericResource"></see></summary>
    let LanguageGenericResource =
        Namespaced_IRI.parse _namespace_name "LanguageGenericResource" |> NamespacedName

    /// <summary>
    /// A Information Resource which may have many versions,
    ///     and therfore representations of the resource at different times may vary.
    /// <see href="http://www.w3.org/2006/gen/ont#TimeGenericResource"></see></summary>
    let TimeGenericResource =
        Namespaced_IRI.parse _namespace_name "TimeGenericResource" |> NamespacedName

    /// <summary>
    /// A resource of which all representations are in the
    /// 		same version.  Representations of the resource will
    ///                 not change as a result of th resource neing updated to a
    ///                 version with time.  The dates of creation and
    ///                 of last modification of such a resource would be
    ///                 expected to be the same.
    /// <see href="http://www.w3.org/2006/gen/ont#TimeSpecificResource"></see></summary>
    let TimeSpecificResource =
        Namespaced_IRI.parse _namespace_name "TimeSpecificResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeGeneric"></see>
    /// </summary>
    let contentTypeGeneric =
        Namespaced_IRI.parse _namespace_name "contentTypeGeneric" |> NamespacedName

    /// <summary>
    /// The equivalence relation linking all versions of a work,
    ///             specific or generic along various axes.
    /// <see href="http://www.w3.org/2006/gen/ont#sameWorkAs"></see></summary>
    let sameWorkAs = Namespaced_IRI.parse _namespace_name "sameWorkAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeSpecific"></see>
    /// </summary>
    let contentTypeSpecific =
        Namespaced_IRI.parse _namespace_name "contentTypeSpecific" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#ContentTypeGeneric"></see>
    /// </summary>
    let ContentTypeGeneric =
        Namespaced_IRI.parse _namespace_name "ContentTypeGeneric" |> NamespacedName

    /// <summary>
    /// A relation between a generic resource and a fixedResource
    ///     which is an everything-specific version of it.
    /// <see href="http://www.w3.org/2006/gen/ont#fixedResource"></see></summary>
    let fixedResource =
        Namespaced_IRI.parse _namespace_name "fixedResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#languageSpecific"></see>
    /// </summary>
    let languageSpecific =
        Namespaced_IRI.parse _namespace_name "languageSpecific" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#timeSpecific"></see>
    /// </summary>
    let timeSpecific =
        Namespaced_IRI.parse _namespace_name "timeSpecific" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#languageGeneric"></see>
    /// </summary>
    let languageGeneric =
        Namespaced_IRI.parse _namespace_name "languageGeneric" |> NamespacedName

    /// <summary>
    /// The related resource which for this time-sepcific resource
    ///             is the related time-generic resource.
    ///             A representation of the time-generic resource may be expected to be
    ///             the most recent time-specific resource at the time of
    ///             the representation.
    /// <see href="http://www.w3.org/2006/gen/ont#timeGeneric"></see></summary>
    let timeGeneric =
        Namespaced_IRI.parse _namespace_name "timeGeneric" |> NamespacedName

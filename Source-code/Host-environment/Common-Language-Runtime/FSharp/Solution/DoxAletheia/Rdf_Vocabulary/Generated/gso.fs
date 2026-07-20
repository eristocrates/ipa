namespace http.www.w3.org._2006.gen.ont.hash

open DoxAletheia

module gso =
    let _namespace_name = "http://www.w3.org/2006/gen/ont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A resource which may have representations in
    ///     many different Content-Types.
    /// <see href="http://www.w3.org/2006/gen/ont#ContentTypeGenericResource"></see></summary>
    let ContentTypeGenericResource = _prefix "ContentTypeGenericResource"
    /// <summary>
    /// An Information Resource is defined by the Architecture of
    /// 	    the WWW.
    /// <see href="http://www.w3.org/2006/gen/ont#InformationResource"></see></summary>
    let InformationResource = _prefix "InformationResource"
    /// <summary>
    /// A resource of which all representations are in the
    /// 		same Internet media type, or 'Content-Type'.
    /// <see href="http://www.w3.org/2006/gen/ont#ContentTypeSpecificResource"></see></summary>
    let ContentTypeSpecificResource = _prefix "ContentTypeSpecificResource"
    /// <summary>
    /// A resource whose representation type and content will not
    /// 	    change under any circumstances.
    /// <see href="http://www.w3.org/2006/gen/ont#FixedResource"></see></summary>
    let FixedResource = _prefix "FixedResource"
    /// <summary>
    /// A resource of which all representations are in the
    /// 		same natural language.
    /// <see href="http://www.w3.org/2006/gen/ont#LanguageSpecificResource"></see></summary>
    let LanguageSpecificResource = _prefix "LanguageSpecificResource"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeSpecificResource"></see>
    /// </summary>
    let contentTypeSpecificResource = _prefix "contentTypeSpecificResource"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#timeSpecificResource"></see>
    /// </summary>
    let timeSpecificResource = _prefix "timeSpecificResource"
    /// <summary>
    /// A resource defiend without constraint as to
    /// 	the particular natural language in which it
    ///         maight be expressed.
    /// <see href="http://www.w3.org/2006/gen/ont#LanguageGenericResource"></see></summary>
    let LanguageGenericResource = _prefix "LanguageGenericResource"
    /// <summary>
    /// A Information Resource which may have many versions,
    ///     and therfore representations of the resource at different times may vary.
    /// <see href="http://www.w3.org/2006/gen/ont#TimeGenericResource"></see></summary>
    let TimeGenericResource = _prefix "TimeGenericResource"
    /// <summary>
    /// A resource of which all representations are in the
    /// 		same version.  Representations of the resource will
    ///                 not change as a result of th resource neing updated to a
    ///                 version with time.  The dates of creation and
    ///                 of last modification of such a resource would be
    ///                 expected to be the same.
    /// <see href="http://www.w3.org/2006/gen/ont#TimeSpecificResource"></see></summary>
    let TimeSpecificResource = _prefix "TimeSpecificResource"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeGeneric"></see>
    /// </summary>
    let contentTypeGeneric = _prefix "contentTypeGeneric"
    /// <summary>
    /// The equivalence relation linking all versions of a work,
    ///             specific or generic along various axes.
    /// <see href="http://www.w3.org/2006/gen/ont#sameWorkAs"></see></summary>
    let sameWorkAs = _prefix "sameWorkAs"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#contentTypeSpecific"></see>
    /// </summary>
    let contentTypeSpecific = _prefix "contentTypeSpecific"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#ContentTypeGeneric"></see>
    /// </summary>
    let ContentTypeGeneric = _prefix "ContentTypeGeneric"
    /// <summary>
    /// A relation between a generic resource and a fixedResource
    ///     which is an everything-specific version of it.
    /// <see href="http://www.w3.org/2006/gen/ont#fixedResource"></see></summary>
    let fixedResource = _prefix "fixedResource"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#languageSpecific"></see>
    /// </summary>
    let languageSpecific = _prefix "languageSpecific"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#timeSpecific"></see>
    /// </summary>
    let timeSpecific = _prefix "timeSpecific"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/gen/ont#languageGeneric"></see>
    /// </summary>
    let languageGeneric = _prefix "languageGeneric"
    /// <summary>
    /// The related resource which for this time-sepcific resource
    ///             is the related time-generic resource.
    ///             A representation of the time-generic resource may be expected to be
    ///             the most recent time-specific resource at the time of
    ///             the representation.
    /// <see href="http://www.w3.org/2006/gen/ont#timeGeneric"></see></summary>
    let timeGeneric = _prefix "timeGeneric"

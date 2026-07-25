namespace http.www.w3.org._2006.gen.ont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gso =
    let _namespace_iri = Namespace_Iri gso |> NamespaceIRI
    /// <summary>
    ///   <para>gso:InformationResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Information Resource is defined by the Architecture of
    /// 	    the WWW.</para>
    /// labels<para>information resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#InformationResource">http://www.w3.org/2006/gen/ont#InformationResource</seealso>
    let InformationResource = Prefixed_Name(gso, "InformationResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:LanguageGenericResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A resource defiend without constraint as to
    /// 	the particular natural language in which it
    ///         maight be expressed.</para>
    /// labels<para>language-generic resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#LanguageGenericResource">http://www.w3.org/2006/gen/ont#LanguageGenericResource</seealso>
    let LanguageGenericResource =
        Prefixed_Name(gso, "LanguageGenericResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:ContentTypeGenericResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A resource which may have representations in
    ///     many different Content-Types.</para>
    /// labels<para>Content-Type-generic resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#ContentTypeGenericResource">http://www.w3.org/2006/gen/ont#ContentTypeGenericResource</seealso>
    let ContentTypeGenericResource =
        Prefixed_Name(gso, "ContentTypeGenericResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:FixedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource whose representation type and content will not
    /// 	    change under any circumstances.</para>
    /// labels<para>fixed resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#FixedResource">http://www.w3.org/2006/gen/ont#FixedResource</seealso>
    let FixedResource = Prefixed_Name(gso, "FixedResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:contentTypeSpecificResource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#contentTypeSpecificResource">http://www.w3.org/2006/gen/ont#contentTypeSpecificResource</seealso>
    let contentTypeSpecificResource =
        Prefixed_Name(gso, "contentTypeSpecificResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:TimeSpecificResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A resource of which all representations are in the
    /// 		same version.  Representations of the resource will
    ///                 not change as a result of th resource neing updated to a
    ///                 version with time.  The dates of creation and
    ///                 of last modification of such a resource would be
    ///                 expected to be the same.</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#TimeSpecificResource">http://www.w3.org/2006/gen/ont#TimeSpecificResource</seealso>
    let TimeSpecificResource =
        Prefixed_Name(gso, "TimeSpecificResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:sameWorkAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The equivalence relation linking all versions of a work,
    ///             specific or generic along various axes.</para>
    /// labels<para>same work as</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#sameWorkAs">http://www.w3.org/2006/gen/ont#sameWorkAs</seealso>
    let sameWorkAs = Prefixed_Name(gso, "sameWorkAs") |> PrefixedName
    /// <summary>
    ///   <para>gso:fixedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relation between a generic resource and a fixedResource
    ///     which is an everything-specific version of it.</para>
    /// labels<para>Content-Type specific</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#fixedResource">http://www.w3.org/2006/gen/ont#fixedResource</seealso>
    let fixedResource = Prefixed_Name(gso, "fixedResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:ContentTypeSpecificResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A resource of which all representations are in the
    /// 		same Internet media type, or 'Content-Type'.</para>
    /// labels<para>Content-Type-specific resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#ContentTypeSpecificResource">http://www.w3.org/2006/gen/ont#ContentTypeSpecificResource</seealso>
    let ContentTypeSpecificResource =
        Prefixed_Name(gso, "ContentTypeSpecificResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:LanguageSpecificResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A resource of which all representations are in the
    /// 		same natural language.</para>
    /// labels<para>language-specific resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#LanguageSpecificResource">http://www.w3.org/2006/gen/ont#LanguageSpecificResource</seealso>
    let LanguageSpecificResource =
        Prefixed_Name(gso, "LanguageSpecificResource") |> PrefixedName

    /// <summary>
    ///   <para>gso:TimeGenericResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>A Information Resource which may have many versions,
    ///     and therfore representations of the resource at different times may vary.</para>
    /// labels<para>Time-generic resource</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#TimeGenericResource">http://www.w3.org/2006/gen/ont#TimeGenericResource</seealso>
    let TimeGenericResource = Prefixed_Name(gso, "TimeGenericResource") |> PrefixedName
    /// <summary>
    ///   <para>gso:ContentTypeGeneric</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#ContentTypeGeneric">http://www.w3.org/2006/gen/ont#ContentTypeGeneric</seealso>
    let ContentTypeGeneric = Prefixed_Name(gso, "ContentTypeGeneric") |> PrefixedName
    /// <summary>
    ///   <para>gso:timeSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>version</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#timeSpecific">http://www.w3.org/2006/gen/ont#timeSpecific</seealso>
    let timeSpecific = Prefixed_Name(gso, "timeSpecific") |> PrefixedName
    /// <summary>
    ///   <para>gso:timeGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The related resource which for this time-sepcific resource
    ///             is the related time-generic resource.
    ///             A representation of the time-generic resource may be expected to be
    ///             the most recent time-specific resource at the time of
    ///             the representation.</para>
    /// labels<para>time generic</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#timeGeneric">http://www.w3.org/2006/gen/ont#timeGeneric</seealso>
    let timeGeneric = Prefixed_Name(gso, "timeGeneric") |> PrefixedName
    /// <summary>
    ///   <para>gso:contentTypeGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Content-Type generic</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#contentTypeGeneric">http://www.w3.org/2006/gen/ont#contentTypeGeneric</seealso>
    let contentTypeGeneric = Prefixed_Name(gso, "contentTypeGeneric") |> PrefixedName
    /// <summary>
    ///   <para>gso:languageSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>language specific</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#languageSpecific">http://www.w3.org/2006/gen/ont#languageSpecific</seealso>
    let languageSpecific = Prefixed_Name(gso, "languageSpecific") |> PrefixedName
    /// <summary>
    ///   <para>gso:contentTypeSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Content-Type specific</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#contentTypeSpecific">http://www.w3.org/2006/gen/ont#contentTypeSpecific</seealso>
    let contentTypeSpecific = Prefixed_Name(gso, "contentTypeSpecific") |> PrefixedName
    /// <summary>
    ///   <para>gso:languageGeneric</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>language generic</para></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#languageGeneric">http://www.w3.org/2006/gen/ont#languageGeneric</seealso>
    let languageGeneric = Prefixed_Name(gso, "languageGeneric") |> PrefixedName

    /// <summary>
    ///   <para>gso:timeSpecificResource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/gen/ont#timeSpecificResource">http://www.w3.org/2006/gen/ont#timeSpecificResource</seealso>
    let timeSpecificResource =
        Prefixed_Name(gso, "timeSpecificResource") |> PrefixedName

namespace https.www.omg.org.spec.Commons.BusinessAuthorizations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module BusinessAuthorizations =
    let _namespace_iri = Namespace_Iri BusinessAuthorizations |> NamespaceIRI
    /// <summary>
    ///   <para>BusinessAuthorizations:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/">https://www.omg.org/spec/Commons/BusinessAuthorizations/</seealso>
    let _prefix_iri = Prefixed_Name(BusinessAuthorizations, "") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:Authorization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/Authorization">https://www.omg.org/spec/Commons/BusinessAuthorizations/Authorization</seealso>
    let Authorization =
        Prefixed_Name(BusinessAuthorizations, "Authorization") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:AuthorizedParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizedParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizedParty</seealso>
    let AuthorizedParty =
        Prefixed_Name(BusinessAuthorizations, "AuthorizedParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:AuthorizingParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizingParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/AuthorizingParty</seealso>
    let AuthorizingParty =
        Prefixed_Name(BusinessAuthorizations, "AuthorizingParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:LegallyDelegatedAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/LegallyDelegatedAuthority">https://www.omg.org/spec/Commons/BusinessAuthorizations/LegallyDelegatedAuthority</seealso>
    let LegallyDelegatedAuthority =
        Prefixed_Name(BusinessAuthorizations, "LegallyDelegatedAuthority") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:ResponsibleParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/ResponsibleParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/ResponsibleParty</seealso>
    let ResponsibleParty =
        Prefixed_Name(BusinessAuthorizations, "ResponsibleParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:authorizes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizes">https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizes</seealso>
    let authorizes = Prefixed_Name(BusinessAuthorizations, "authorizes") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:authorizesThrough</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizesThrough">https://www.omg.org/spec/Commons/BusinessAuthorizations/authorizesThrough</seealso>
    let authorizesThrough =
        Prefixed_Name(BusinessAuthorizations, "authorizesThrough") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:delegatesControlTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/delegatesControlTo">https://www.omg.org/spec/Commons/BusinessAuthorizations/delegatesControlTo</seealso>
    let delegatesControlTo =
        Prefixed_Name(BusinessAuthorizations, "delegatesControlTo") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:hasAuthorizedParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizedParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizedParty</seealso>
    let hasAuthorizedParty =
        Prefixed_Name(BusinessAuthorizations, "hasAuthorizedParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:hasAuthorizingParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizingParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/hasAuthorizingParty</seealso>
    let hasAuthorizingParty =
        Prefixed_Name(BusinessAuthorizations, "hasAuthorizingParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:hasDelegatedControlOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasDelegatedControlOf">https://www.omg.org/spec/Commons/BusinessAuthorizations/hasDelegatedControlOf</seealso>
    let hasDelegatedControlOf =
        Prefixed_Name(BusinessAuthorizations, "hasDelegatedControlOf") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:hasResponsibleParty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/hasResponsibleParty">https://www.omg.org/spec/Commons/BusinessAuthorizations/hasResponsibleParty</seealso>
    let hasResponsibleParty =
        Prefixed_Name(BusinessAuthorizations, "hasResponsibleParty") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:isAuthorizedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedBy">https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedBy</seealso>
    let isAuthorizedBy =
        Prefixed_Name(BusinessAuthorizations, "isAuthorizedBy") |> PrefixedName

    /// <summary>
    ///   <para>BusinessAuthorizations:isAuthorizedThrough</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedThrough">https://www.omg.org/spec/Commons/BusinessAuthorizations/isAuthorizedThrough</seealso>
    let isAuthorizedThrough =
        Prefixed_Name(BusinessAuthorizations, "isAuthorizedThrough") |> PrefixedName

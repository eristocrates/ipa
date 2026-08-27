namespace http.d_nb.info.standards.elementset.agrelon.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module agrelon =
    let _namespace_iri = Namespace_Iri agrelon |> NamespaceIRI
    /// <summary>
    ///   <para>agrelon:hasAcquaintance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasAcquaintance">http://d-nb.info/standards/elementset/agrelon#hasAcquaintance</seealso>
    let hasAcquaintance = Prefixed_Name(agrelon, "hasAcquaintance") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:hasAssociate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasAssociate">http://d-nb.info/standards/elementset/agrelon#hasAssociate</seealso>
    let hasAssociate = Prefixed_Name(agrelon, "hasAssociate") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:hasBeginDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasBeginDate">http://d-nb.info/standards/elementset/agrelon#hasBeginDate</seealso>
    let hasBeginDate = Prefixed_Name(agrelon, "hasBeginDate") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:hasCorrespondent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasCorrespondent">http://d-nb.info/standards/elementset/agrelon#hasCorrespondent</seealso>
    let hasCorrespondent = Prefixed_Name(agrelon, "hasCorrespondent") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:hasEndDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasEndDate">http://d-nb.info/standards/elementset/agrelon#hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(agrelon, "hasEndDate") |> PrefixedName

    /// <summary>
    ///   <para>agrelon:hasProfessionalContact</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasProfessionalContact">http://d-nb.info/standards/elementset/agrelon#hasProfessionalContact</seealso>
    let hasProfessionalContact =
        Prefixed_Name(agrelon, "hasProfessionalContact") |> PrefixedName

    /// <summary>
    ///   <para>agrelon:hasRelative</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#hasRelative">http://d-nb.info/standards/elementset/agrelon#hasRelative</seealso>
    let hasRelative = Prefixed_Name(agrelon, "hasRelative") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:isMemberOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#isMemberOf">http://d-nb.info/standards/elementset/agrelon#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(agrelon, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>agrelon:relatedAgent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://d-nb.info/standards/elementset/agrelon#relatedAgent">http://d-nb.info/standards/elementset/agrelon#relatedAgent</seealso>
    let relatedAgent = Prefixed_Name(agrelon, "relatedAgent") |> PrefixedName

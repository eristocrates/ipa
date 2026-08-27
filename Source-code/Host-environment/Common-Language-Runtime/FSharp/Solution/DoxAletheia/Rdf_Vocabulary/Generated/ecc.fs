namespace https.ns.eccenca.com.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ecc =
    let _namespace_iri = Namespace_Iri ecc |> NamespaceIRI
    /// <summary>
    ///   <para>ecc:aweilandt</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://ns.eccenca.com/aweilandt">https://ns.eccenca.com/aweilandt</seealso>
    let aweilandt = Prefixed_Name(ecc, "aweilandt") |> PrefixedName
    /// <summary>
    ///   <para>ecc:eccenca-GmbH</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="https://ns.eccenca.com/eccenca-GmbH">https://ns.eccenca.com/eccenca-GmbH</seealso>
    let eccenca_GmbH = Prefixed_Name(ecc, "eccenca-GmbH") |> PrefixedName
    /// <summary>
    ///   <para>ecc:mbruemmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://ns.eccenca.com/mbruemmer">https://ns.eccenca.com/mbruemmer</seealso>
    let mbruemmer = Prefixed_Name(ecc, "mbruemmer") |> PrefixedName
    /// <summary>
    ///   <para>ecc:mfrommhold</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://ns.eccenca.com/mfrommhold">https://ns.eccenca.com/mfrommhold</seealso>
    let mfrommhold = Prefixed_Name(ecc, "mfrommhold") |> PrefixedName
    /// <summary>
    ///   <para>ecc:rnavarropiris</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:Agent</para>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="https://ns.eccenca.com/rnavarropiris">https://ns.eccenca.com/rnavarropiris</seealso>
    let rnavarropiris = Prefixed_Name(ecc, "rnavarropiris") |> PrefixedName
    /// <summary>
    ///   <para>ecc:stramp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ns.eccenca.com/stramp">https://ns.eccenca.com/stramp</seealso>
    let stramp = Prefixed_Name(ecc, "stramp") |> PrefixedName

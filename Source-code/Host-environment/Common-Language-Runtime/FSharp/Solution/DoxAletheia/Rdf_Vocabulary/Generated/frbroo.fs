namespace http.iflastandards.info.ns.fr.frbr.frbroo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frbroo =
    let _namespace_iri = Namespace_Iri frbroo |> NamespaceIRI
    /// <summary>
    ///   <para>frbroo:F38</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Character"</para></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbroo/F38">http://iflastandards.info/ns/fr/frbr/frbroo/F38</seealso>
    let F38 = Prefixed_Name(frbroo, "F38") |> PrefixedName
    /// <summary>
    ///   <para>frbroo:F38_Character</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbroo/F38_Character">http://iflastandards.info/ns/fr/frbr/frbroo/F38_Character</seealso>
    let F38_Character = Prefixed_Name(frbroo, "F38_Character") |> PrefixedName
    /// <summary>
    ///   <para>frbroo:R57_is_based_on</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbroo/R57_is_based_on">http://iflastandards.info/ns/fr/frbr/frbroo/R57_is_based_on</seealso>
    let R57_is_based_on = Prefixed_Name(frbroo, "R57_is_based_on") |> PrefixedName
    /// <summary>
    ///   <para>frbroo:R57i_is_basis_for</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iflastandards.info/ns/fr/frbr/frbroo/R57i_is_basis_for">http://iflastandards.info/ns/fr/frbr/frbroo/R57i_is_basis_for</seealso>
    let R57i_is_basis_for = Prefixed_Name(frbroo, "R57i_is_basis_for") |> PrefixedName

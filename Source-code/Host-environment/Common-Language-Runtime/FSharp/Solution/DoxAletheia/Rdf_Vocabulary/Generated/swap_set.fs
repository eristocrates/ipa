namespace http.www.w3.org._2000._10.swap.set.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swap_set =
    let _namespace_iri = Namespace_Iri swap_set |> NamespaceIRI
    /// <summary>
    ///   <para>swap_set:difference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a list of sets,
    ///     and the objet is the difference of the sets in the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"difference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#difference">http://www.w3.org/2000/10/swap/set#difference</seealso>
    let difference = Prefixed_Name(swap_set, "difference") |> PrefixedName
    /// <summary>
    ///   <para>swap_set:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This set contains that as a member.
    ///     Cwm will bind the subject to each of the members of the object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#in">http://www.w3.org/2000/10/swap/set#in</seealso>
    let in_ = Prefixed_Name(swap_set, "in") |> PrefixedName
    /// <summary>
    ///   <para>swap_set:intersection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a list of sets,
    ///     and the objet is the intersection of the sets in the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"intersection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#intersection">http://www.w3.org/2000/10/swap/set#intersection</seealso>
    let intersection = Prefixed_Name(swap_set, "intersection") |> PrefixedName
    /// <summary>
    ///   <para>swap_set:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This is a member of that set.
    ///     Cwm will bind the object to each of the members of the suject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#member">http://www.w3.org/2000/10/swap/set#member</seealso>
    let member_ = Prefixed_Name(swap_set, "member") |> PrefixedName

    /// <summary>
    ///   <para>swap_set:symmetricDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a list of sets,
    ///     and the objet is the symmetricDifference of the sets in the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"symmetric difference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#symmetricDifference">http://www.w3.org/2000/10/swap/set#symmetricDifference</seealso>
    let symmetricDifference =
        Prefixed_Name(swap_set, "symmetricDifference") |> PrefixedName

    /// <summary>
    ///   <para>swap_set:union</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The subject is a list [sic] of sets,
    ///     and the objet is the union of the sets in the object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/set#union">http://www.w3.org/2000/10/swap/set#union</seealso>
    let union = Prefixed_Name(swap_set, "union") |> PrefixedName

namespace http.www.w3.org._2000._10.swap.list.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module list =
    let _namespace_iri = Namespace_Iri list |> NamespaceIRI
    /// <summary>
    ///   <para>list:in</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// Iff the object is a list and the subject is in that list, then this is true.
    /// </para>
    /// labels<para>in</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/list#in">http://www.w3.org/2000/10/swap/list#in</seealso>
    let in_ = Prefixed_Name(list, "in") |> PrefixedName
    /// <summary>
    ///   <para>list:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// Iff the suject is a list and the obbject is the last thing that list, then this is true.
    /// The object can be calculated as a function of the list.
    /// </para>
    /// labels<para>in</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/list#last">http://www.w3.org/2000/10/swap/list#last</seealso>
    let last = Prefixed_Name(list, "last") |> PrefixedName
    /// <summary>
    ///   <para>list:append</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// Iff the subject is a list of lists and the concatenation of all those lists
    /// is the object, then this is true.
    /// eg  ( (1 2) (3 4) ) list:append (1 2 3 4).
    /// The object can be calculated as a function of the subject.
    /// </para>
    /// labels<para>concatenation</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/list#append">http://www.w3.org/2000/10/swap/list#append</seealso>
    let append = Prefixed_Name(list, "append") |> PrefixedName
    /// <summary>
    ///   <para>list:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>
    /// Iff the subject is a list and the obbject is in that list, then this is true.
    /// </para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/list#member">http://www.w3.org/2000/10/swap/list#member</seealso>
    let member_ = Prefixed_Name(list, "member") |> PrefixedName

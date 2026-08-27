namespace http.www.iana.org.assignments.relation.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module relation =
    let _namespace_iri = Namespace_Iri relation |> NamespaceIRI
    /// <summary>
    ///   <para>relation:alternate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>atomowl:#RelationType</para>
    ///   <para>"see §4.2.7.2.1 of rfc 4287. The object points to an alternate version of the subject"</para>
    /// labels<para>"alternate relation"</para></remarks>
    /// <seealso href="http://www.iana.org/assignments/relation/alternate">http://www.iana.org/assignments/relation/alternate</seealso>
    let alternate = Prefixed_Name(relation, "alternate") |> PrefixedName
    /// <summary>
    ///   <para>relation:enclosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>atomowl:#RelationType</para>
    ///   <para>"see §4.2.7.2.4 of rfc 4287. The object is a related resource that is potentially large in size and requires special handling."</para>
    /// labels<para>"enclosure relation"</para></remarks>
    /// <seealso href="http://www.iana.org/assignments/relation/enclosure">http://www.iana.org/assignments/relation/enclosure</seealso>
    let enclosure = Prefixed_Name(relation, "enclosure") |> PrefixedName
    /// <summary>
    ///   <para>relation:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>atomowl:#RelationType</para>
    ///   <para>"see §4.2.7.2.2 of rfc 4287. The object points to a related version of the subject. So if the subject is a Entry the object might be a resource with an html representation of that entry."</para>
    /// labels<para>"related"</para></remarks>
    /// <seealso href="http://www.iana.org/assignments/relation/related">http://www.iana.org/assignments/relation/related</seealso>
    let related = Prefixed_Name(relation, "related") |> PrefixedName
    /// <summary>
    ///   <para>relation:self</para>
    /// </summary>
    /// <remarks>
    ///   <para>atomowl:#RelationType</para>
    ///   <para>"see §4.2.7.2.3 of rfc 4287. The object is equivalent to the subject."</para>
    /// labels<para>"self relation"</para></remarks>
    /// <seealso href="http://www.iana.org/assignments/relation/self">http://www.iana.org/assignments/relation/self</seealso>
    let self = Prefixed_Name(relation, "self") |> PrefixedName
    /// <summary>
    ///   <para>relation:via</para>
    /// </summary>
    /// <remarks>
    ///   <para>atomowl:#RelationType</para>
    ///   <para>"see §4.2.7.2.5 of rfc 4287. The object provided a source of the information found in the subject."</para>
    /// labels<para>"via relation"</para></remarks>
    /// <seealso href="http://www.iana.org/assignments/relation/via">http://www.iana.org/assignments/relation/via</seealso>
    let via = Prefixed_Name(relation, "via") |> PrefixedName

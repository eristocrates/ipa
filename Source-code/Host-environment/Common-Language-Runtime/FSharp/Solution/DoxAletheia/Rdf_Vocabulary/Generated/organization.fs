namespace http.eulersharp.sourceforge.net._2003._03swap.organization.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module organization =
    let _namespace_iri = Namespace_Iri organization |> NamespaceIRI
    /// <summary>
    ///   <para>organization:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>company</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#Company">http://eulersharp.sourceforge.net/2003/03swap/organization#Company</seealso>
    let Company = Prefixed_Name(organization, "Company") |> PrefixedName
    /// <summary>
    ///   <para>organization:Enterprise</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>enterprise</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#Enterprise">http://eulersharp.sourceforge.net/2003/03swap/organization#Enterprise</seealso>
    let Enterprise = Prefixed_Name(organization, "Enterprise") |> PrefixedName
    /// <summary>
    ///   <para>organization:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>department</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#Department">http://eulersharp.sourceforge.net/2003/03swap/organization#Department</seealso>
    let Department = Prefixed_Name(organization, "Department") |> PrefixedName
    /// <summary>
    ///   <para>organization:LegalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>legal person</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#LegalPerson">http://eulersharp.sourceforge.net/2003/03swap/organization#LegalPerson</seealso>
    let LegalPerson = Prefixed_Name(organization, "LegalPerson") |> PrefixedName
    /// <summary>
    ///   <para>organization:hasSeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#hasSeat">http://eulersharp.sourceforge.net/2003/03swap/organization#hasSeat</seealso>
    let hasSeat = Prefixed_Name(organization, "hasSeat") |> PrefixedName
    /// <summary>
    ///   <para>organization:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#">http://eulersharp.sourceforge.net/2003/03swap/organization#</seealso>
    let _prefix_iri = Prefixed_Name(organization, "") |> PrefixedName
    /// <summary>
    ///   <para>organization:University</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>university</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/organization#University">http://eulersharp.sourceforge.net/2003/03swap/organization#University</seealso>
    let University = Prefixed_Name(organization, "University") |> PrefixedName

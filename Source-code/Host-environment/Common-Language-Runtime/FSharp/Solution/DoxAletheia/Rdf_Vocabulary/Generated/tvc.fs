namespace http.www.essepuntato.it._2012._04.tvc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tvc =
    let _namespace_iri = Namespace_Iri tvc |> NamespaceIRI
    /// <summary>
    ///   <para>tvc:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It specifies the particular temporal instant or time period in which the situation takes place.</para>
    /// labels<para>at time</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2012/04/tvc/atTime">http://www.essepuntato.it/2012/04/tvc/atTime</seealso>
    let atTime = Prefixed_Name(tvc, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>tvc:ValueInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It defines a particular kind of time-indexed situation that represents a hub linking the entity having a particular value, the value itself and the temporal and contextual extents from which the entity-value relationship depends.</para>
    /// labels<para>value in time</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2012/04/tvc/ValueInTime">http://www.essepuntato.it/2012/04/tvc/ValueInTime</seealso>
    let ValueInTime = Prefixed_Name(tvc, "ValueInTime") |> PrefixedName
    /// <summary>
    ///   <para>tvc:withValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It holds the value had by the entity taking part to the situation.</para>
    /// labels<para>with value</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2012/04/tvc/withValue">http://www.essepuntato.it/2012/04/tvc/withValue</seealso>
    let withValue = Prefixed_Name(tvc, "withValue") |> PrefixedName
    /// <summary>
    ///   <para>tvc:withinContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It links to the specific context within which the fact of the entity having the value is relevant.</para>
    /// labels<para>within context</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2012/04/tvc/withinContext">http://www.essepuntato.it/2012/04/tvc/withinContext</seealso>
    let withinContext = Prefixed_Name(tvc, "withinContext") |> PrefixedName
    /// <summary>
    ///   <para>tvc:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It links an entity (e.g., a Person) to a particular ValueInTime situation;</para>
    /// labels<para>has value</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2012/04/tvc/hasValue">http://www.essepuntato.it/2012/04/tvc/hasValue</seealso>
    let hasValue = Prefixed_Name(tvc, "hasValue") |> PrefixedName

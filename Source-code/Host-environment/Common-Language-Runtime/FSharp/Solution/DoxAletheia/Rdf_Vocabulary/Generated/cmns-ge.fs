namespace https.www.omg.org.spec.Commons.GeopoliticalEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cmns_ge =
    let _namespace_iri = Namespace_Iri cmns_ge |> NamespaceIRI

    /// <summary>
    ///   <para>cmns-ge:GeopoliticalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/GeopoliticalEntities/GeopoliticalEntity">https://www.omg.org/spec/Commons/GeopoliticalEntities/GeopoliticalEntity</seealso>
    let GeopoliticalEntity =
        Prefixed_Name(cmns_ge, "GeopoliticalEntity") |> PrefixedName

    /// <summary>
    ///   <para>cmns-ge:Subdivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/GeopoliticalEntities/Subdivision">https://www.omg.org/spec/Commons/GeopoliticalEntities/Subdivision</seealso>
    let Subdivision = Prefixed_Name(cmns_ge, "Subdivision") |> PrefixedName

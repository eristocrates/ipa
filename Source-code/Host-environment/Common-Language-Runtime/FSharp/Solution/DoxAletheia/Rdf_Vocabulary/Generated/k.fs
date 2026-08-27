namespace http.opencyc.sourceforge.net.daml.cyc.daml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module k =
    let _namespace_iri = Namespace_Iri k |> NamespaceIRI
    /// <summary>
    ///   <para>k:AirlineCompany</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://opencyc.sourceforge.net/daml/cyc.daml#AirlineCompany">http://opencyc.sourceforge.net/daml/cyc.daml#AirlineCompany</seealso>
    let AirlineCompany = Prefixed_Name(k, "AirlineCompany") |> PrefixedName
    /// <summary>
    ///   <para>k:Translocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://opencyc.sourceforge.net/daml/cyc.daml#Translocation">http://opencyc.sourceforge.net/daml/cyc.daml#Translocation</seealso>
    let Translocation = Prefixed_Name(k, "Translocation") |> PrefixedName
    /// <summary>
    ///   <para>k:nameString</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://opencyc.sourceforge.net/daml/cyc.daml#nameString">http://opencyc.sourceforge.net/daml/cyc.daml#nameString</seealso>
    let nameString = Prefixed_Name(k, "nameString") |> PrefixedName
    /// <summary>
    ///   <para>k:performedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://opencyc.sourceforge.net/daml/cyc.daml#performedBy">http://opencyc.sourceforge.net/daml/cyc.daml#performedBy</seealso>
    let performedBy = Prefixed_Name(k, "performedBy") |> PrefixedName

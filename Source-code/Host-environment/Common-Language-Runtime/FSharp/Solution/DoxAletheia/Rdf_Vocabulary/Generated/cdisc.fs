namespace http.rdf.cdisc.org.mms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cdisc =
    let _namespace_iri = Namespace_Iri cdisc |> NamespaceIRI
    /// <summary>
    ///   <para>cdisc:PermissibleValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.cdisc.org/mms#PermissibleValue">http://rdf.cdisc.org/mms#PermissibleValue</seealso>
    let PermissibleValue = Prefixed_Name(cdisc, "PermissibleValue") |> PrefixedName
    /// <summary>
    ///   <para>cdisc:ValueDomain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.cdisc.org/mms#ValueDomain">http://rdf.cdisc.org/mms#ValueDomain</seealso>
    let ValueDomain = Prefixed_Name(cdisc, "ValueDomain") |> PrefixedName

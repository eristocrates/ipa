namespace http.www.w3.org.ns.wsdl_rdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wsdl =
    let _namespace_iri = Namespace_Iri wsdl |> NamespaceIRI
    /// <summary>
    ///   <para>wsdl:Service</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/wsdl-rdf#Service">http://www.w3.org/ns/wsdl-rdf#Service</seealso>
    let Service = Prefixed_Name(wsdl, "Service") |> PrefixedName

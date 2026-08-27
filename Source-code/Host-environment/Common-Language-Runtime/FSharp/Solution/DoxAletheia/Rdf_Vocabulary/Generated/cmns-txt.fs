namespace https.www.omg.org.spec.Commons.Text.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cmns_txt =
    let _namespace_iri = Namespace_Iri cmns_txt |> NamespaceIRI
    /// <summary>
    ///   <para>cmns-txt:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Text/hasName">https://www.omg.org/spec/Commons/Text/hasName</seealso>
    let hasName = Prefixed_Name(cmns_txt, "hasName") |> PrefixedName

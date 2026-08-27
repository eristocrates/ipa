namespace https.w3id.org.oseg.ont.tsdc.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tsdc =
    let _namespace_iri = Namespace_Iri tsdc |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:oseg/ont/tsdc/core#OHTsDC</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/tsdc/core#OHTsDC">https://w3id.org/oseg/ont/tsdc/core#OHTsDC</seealso>
    let OHTsDC = Prefixed_Name(tsdc, "OHTsDC") |> PrefixedName

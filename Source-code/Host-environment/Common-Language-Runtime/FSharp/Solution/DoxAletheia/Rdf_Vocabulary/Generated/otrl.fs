namespace https.w3id.org.oseg.ont.otrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module otrl =
    let _namespace_iri = Namespace_Iri otrl |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:oseg/ont/otrl#ODRL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/otrl#ODRL">https://w3id.org/oseg/ont/otrl#ODRL</seealso>
    let ODRL = Prefixed_Name(otrl, "ODRL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:oseg/ont/otrl#OTRL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/oseg/ont/otrl#OTRL">https://w3id.org/oseg/ont/otrl#OTRL</seealso>
    let OTRL = Prefixed_Name(otrl, "OTRL") |> PrefixedName

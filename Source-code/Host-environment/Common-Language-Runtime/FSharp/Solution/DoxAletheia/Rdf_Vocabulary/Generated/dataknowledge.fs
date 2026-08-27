namespace http.www.data_knowledge.org.dk.schema.rdf.latest.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dataknowledge =
    let _namespace_iri = Namespace_Iri dataknowledge |> NamespaceIRI
    /// <summary>
    ///   <para>dk:schema/rdf/latest/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.data-knowledge.org/dk/schema/rdf/latest/">http://www.data-knowledge.org/dk/schema/rdf/latest/</seealso>
    let _prefix_iri = Prefixed_Name(dataknowledge, "") |> PrefixedName

namespace http.www.ics.forth.gr.isl.VoIDWarehouse.VoID_Extension_Schema.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voidwh =
    let _namespace_iri = Namespace_Iri voidwh |> NamespaceIRI
    /// <summary>
    ///   <para>voidwh:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl">http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl</seealso>
    let _prefix_iri = Prefixed_Name(voidwh, "") |> PrefixedName

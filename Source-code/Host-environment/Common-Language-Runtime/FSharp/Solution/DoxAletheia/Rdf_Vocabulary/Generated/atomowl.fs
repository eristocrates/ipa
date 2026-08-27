namespace http.bblfish.net.work.atom_owl._2006_06_06.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atomowl =
    let _namespace_iri = Namespace_Iri atomowl |> NamespaceIRI
    /// <summary>
    ///   <para>atomowl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The AtomOWL ontology is inspired from the work done by the atom working group. This ontology is working off the rfc 4287 published among othe places at http://www.atompub.org/rfc4287.html . The AtomOWL ontology uses as much as possible the same terms as the format there to make the relation easy to understand. The AtomOWL name space is slightly different from the atom namespace [see post http://www.imc.org/atom-syntax/mail-archive/msg16476.html]. But this is a good thing as it helps distinguish the ontology from the rfc 4287 serialisation."</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/">http://bblfish.net/work/atom-owl/2006-06-06/</seealso>
    let _prefix_iri = Prefixed_Name(atomowl, "") |> PrefixedName

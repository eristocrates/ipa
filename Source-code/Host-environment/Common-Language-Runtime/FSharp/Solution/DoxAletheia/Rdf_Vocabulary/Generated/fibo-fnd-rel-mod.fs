namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.MetadataFNDRelations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_rel_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_rel_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-rel-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Relations Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_rel_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-rel-mod:RelationsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"relations module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/RelationsModule">https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/RelationsModule</seealso>
    let RelationsModule =
        Prefixed_Name(fibo_fnd_rel_mod, "RelationsModule") |> PrefixedName

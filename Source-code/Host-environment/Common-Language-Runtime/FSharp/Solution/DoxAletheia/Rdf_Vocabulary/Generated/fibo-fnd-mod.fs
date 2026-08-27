namespace https.spec.edmcouncil.org.fibo.ontology.FND.MetadataFND.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the FIBO Foundations (FND) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/">https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-mod:FNDDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"foundations domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/FNDDomain">https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/FNDDomain</seealso>
    let FNDDomain = Prefixed_Name(fibo_fnd_mod, "FNDDomain") |> PrefixedName

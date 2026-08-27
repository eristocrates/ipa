namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.MetadataFNDUtilities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_utl_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_utl_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-utl-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Utilities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_utl_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-utl-mod:UtilitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"utilities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/UtilitiesModule">https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/UtilitiesModule</seealso>
    let UtilitiesModule =
        Prefixed_Name(fibo_fnd_utl_mod, "UtilitiesModule") |> PrefixedName

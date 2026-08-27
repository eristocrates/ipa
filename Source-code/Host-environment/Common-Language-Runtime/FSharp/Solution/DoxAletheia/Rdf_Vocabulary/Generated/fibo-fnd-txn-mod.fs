namespace https.spec.edmcouncil.org.fibo.ontology.FND.TransactionsExt.MetadataFNDTransactionsExt.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_txn_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_txn_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-txn-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) TransactionsExt Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/">https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_txn_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-txn-mod:TransactionsExtModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"transactions ext module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/TransactionsExtModule">https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/TransactionsExtModule</seealso>
    let TransactionsExtModule =
        Prefixed_Name(fibo_fnd_txn_mod, "TransactionsExtModule") |> PrefixedName

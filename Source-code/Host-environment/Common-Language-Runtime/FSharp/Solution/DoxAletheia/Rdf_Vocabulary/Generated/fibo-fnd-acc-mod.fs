namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.MetadataFNDAccounting.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_acc_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_acc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-acc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Accounting Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_acc_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-mod:AccountingModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"accounting module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/AccountingModule">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/AccountingModule</seealso>
    let AccountingModule =
        Prefixed_Name(fibo_fnd_acc_mod, "AccountingModule") |> PrefixedName

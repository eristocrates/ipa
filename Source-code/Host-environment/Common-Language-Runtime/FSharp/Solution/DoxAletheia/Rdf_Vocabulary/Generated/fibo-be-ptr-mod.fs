namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.MetadataBEPartnerships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ptr_mod =
    let _namespace_iri = Namespace_Iri fibo_be_ptr_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ptr-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Business Entities (BE) Partnerships Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ptr_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ptr-mod:PartnershipsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"partnerships module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/PartnershipsModule">https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/PartnershipsModule</seealso>
    let PartnershipsModule =
        Prefixed_Name(fibo_be_ptr_mod, "PartnershipsModule") |> PrefixedName

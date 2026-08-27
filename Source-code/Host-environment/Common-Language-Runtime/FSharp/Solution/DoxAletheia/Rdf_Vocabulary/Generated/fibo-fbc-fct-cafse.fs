namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.CAFinancialServicesEntities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_cafse =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_cafse |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-cafse:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Canadian Financial Services Entities Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_cafse, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cafse:CanadianCreditUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Canadian credit union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/CanadianCreditUnion">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/CanadianCreditUnion</seealso>
    let CanadianCreditUnion =
        Prefixed_Name(fibo_fbc_fct_cafse, "CanadianCreditUnion") |> PrefixedName

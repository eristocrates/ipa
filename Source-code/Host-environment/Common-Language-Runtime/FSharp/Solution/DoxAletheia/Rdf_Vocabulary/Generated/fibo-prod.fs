namespace https.spec.edmcouncil.org.fibo.ontology.AboutFIBOProd.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_prod =
    let _namespace_iri = Namespace_Iri fibo_prod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-prod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"About FIBO Production"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/AboutFIBOProd/">https://spec.edmcouncil.org/fibo/ontology/AboutFIBOProd/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_prod, "") |> PrefixedName

namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.ACTUSContractTermMapping.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_actus_actm =
    let _namespace_iri = Namespace_Iri fibo_actus_actm |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-actus-actm:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"ACTUS Contract Term Mapping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTermMapping/">https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTermMapping/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_actus_actm, "") |> PrefixedName

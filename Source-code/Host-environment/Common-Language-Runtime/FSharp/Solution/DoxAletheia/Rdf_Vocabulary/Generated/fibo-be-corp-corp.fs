namespace https.spec.edmcouncil.org.fibo.ontology.BE.Corporations.Corporations.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_corp_corp =
    let _namespace_iri = Namespace_Iri fibo_be_corp_corp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-corp-corp:Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/Corporations/Corporations/Corporation">https://spec.edmcouncil.org/fibo/ontology/BE/Corporations/Corporations/Corporation</seealso>
    let Corporation = Prefixed_Name(fibo_be_corp_corp, "Corporation") |> PrefixedName

namespace http.www.ontotext.com.proton.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module proton =
    let _namespace_iri = Namespace_Iri proton |> NamespaceIRI
    /// <summary>
    ///   <para>onto:proton/protontop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"PROTON (Proto Ontology), Top module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Proton Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protontop">http://www.ontotext.com/proton/protontop</seealso>
    let protontop = Prefixed_Name(proton, "protontop") |> PrefixedName
    /// <summary>
    ///   <para>onto:proton/protonext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"PROTON (Proto Ontology), Extent module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Proton Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontotext.com/proton/protonext">http://www.ontotext.com/proton/protonext</seealso>
    let protonext = Prefixed_Name(proton, "protonext") |> PrefixedName

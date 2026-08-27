namespace http.linkeddata.finki.ukim.mk.lod.ontology.cfrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cfrl =
    let _namespace_iri = Namespace_Iri cfrl |> NamespaceIRI
    /// <summary>
    ///   <para>cfrl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The Corporate Financial Reports and Loans Ontology (CFRL)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#">http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#</seealso>
    let _prefix_iri = Prefixed_Name(cfrl, "") |> PrefixedName
    /// <summary>
    ///   <para>cfrl:hasLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Company with a Loan instance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasLoan">http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasLoan</seealso>
    let hasLoan = Prefixed_Name(cfrl, "hasLoan") |> PrefixedName
    /// <summary>
    ///   <para>cfrl:hasReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links a Company with a Financial Report instance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasReport">http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#hasReport</seealso>
    let hasReport = Prefixed_Name(cfrl, "hasReport") |> PrefixedName

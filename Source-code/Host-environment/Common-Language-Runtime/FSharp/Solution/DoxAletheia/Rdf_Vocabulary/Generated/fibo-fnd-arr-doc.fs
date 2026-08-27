namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Documents.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_doc =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_doc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-doc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Documents Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_doc, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-doc:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Certificate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Certificate</seealso>
    let Certificate = Prefixed_Name(fibo_fnd_arr_doc, "Certificate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-doc:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Document">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Document</seealso>
    let Document = Prefixed_Name(fibo_fnd_arr_doc, "Document") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:FinancialRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/FinancialRecord">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/FinancialRecord</seealso>
    let FinancialRecord =
        Prefixed_Name(fibo_fnd_arr_doc, "FinancialRecord") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:LegalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/LegalDocument">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/LegalDocument</seealso>
    let LegalDocument = Prefixed_Name(fibo_fnd_arr_doc, "LegalDocument") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-doc:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Record">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/Record</seealso>
    let Record = Prefixed_Name(fibo_fnd_arr_doc, "Record") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:hasExpirationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expiration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasExpirationDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasExpirationDate</seealso>
    let hasExpirationDate =
        Prefixed_Name(fibo_fnd_arr_doc, "hasExpirationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:hasRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasRecord">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasRecord</seealso>
    let hasRecord = Prefixed_Name(fibo_fnd_arr_doc, "hasRecord") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:hasReportingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reporting period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasReportingPeriod">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasReportingPeriod</seealso>
    let hasReportingPeriod =
        Prefixed_Name(fibo_fnd_arr_doc, "hasReportingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:hasTerminationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has termination date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasTerminationDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/hasTerminationDate</seealso>
    let hasTerminationDate =
        Prefixed_Name(fibo_fnd_arr_doc, "hasTerminationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:isReferencedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/isReferencedIn">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/isReferencedIn</seealso>
    let isReferencedIn =
        Prefixed_Name(fibo_fnd_arr_doc, "isReferencedIn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-doc:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/refersTo">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/refersTo</seealso>
    let refersTo = Prefixed_Name(fibo_fnd_arr_doc, "refersTo") |> PrefixedName

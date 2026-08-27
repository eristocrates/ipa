namespace http.purl.obolibrary.org.obo.OGMS_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ogms =
    let _namespace_iri = Namespace_Iri ogms |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:OGMS_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clinical history"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000015">http://purl.obolibrary.org/obo/OGMS_0000015</seealso>
    let clinical_history = Prefixed_Name(ogms, "0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OGMS_0000023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phenotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000023">http://purl.obolibrary.org/obo/OGMS_0000023</seealso>
    let phenotype = Prefixed_Name(ogms, "0000023") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OGMS_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000031">http://purl.obolibrary.org/obo/OGMS_0000031</seealso>
    let disease = Prefixed_Name(ogms, "0000031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OGMS_0000063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disease course"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000063">http://purl.obolibrary.org/obo/OGMS_0000063</seealso>
    let disease_course = Prefixed_Name(ogms, "0000063") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OGMS_0000073</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diagnosis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000073">http://purl.obolibrary.org/obo/OGMS_0000073</seealso>
    let diagnosis = Prefixed_Name(ogms, "0000073") |> PrefixedName
    /// <summary>
    ///   <para>cdao:OGMS_0000090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"treatment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/OGMS_0000090">http://purl.obolibrary.org/obo/OGMS_0000090</seealso>
    let treatment = Prefixed_Name(ogms, "0000090") |> PrefixedName

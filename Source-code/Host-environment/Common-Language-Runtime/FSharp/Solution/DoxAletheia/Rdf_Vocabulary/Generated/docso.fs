namespace http.purl.org.ontology.dso.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module docso =
    let _namespace_iri = Namespace_Iri docso |> NamespaceIRI
    /// <summary>
    ///   <para>docso:DocumentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>DocumentService</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#DocumentService">http://purl.org/ontology/dso#DocumentService</seealso>
    let DocumentService = Prefixed_Name(docso, "DocumentService") |> PrefixedName
    /// <summary>
    ///   <para>docso:Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Loan</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#Loan">http://purl.org/ontology/dso#Loan</seealso>
    let Loan = Prefixed_Name(docso, "Loan") |> PrefixedName
    /// <summary>
    ///   <para>docso:Interloan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Interloan</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#Interloan">http://purl.org/ontology/dso#Interloan</seealso>
    let Interloan = Prefixed_Name(docso, "Interloan") |> PrefixedName
    /// <summary>
    ///   <para>docso:OpenAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Digitization</para><para>OpenAccess</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#OpenAccess">http://purl.org/ontology/dso#OpenAccess</seealso>
    let OpenAccess = Prefixed_Name(docso, "OpenAccess") |> PrefixedName
    /// <summary>
    ///   <para>docso:Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Presentation</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#Presentation">http://purl.org/ontology/dso#Presentation</seealso>
    let Presentation = Prefixed_Name(docso, "Presentation") |> PrefixedName
    /// <summary>
    ///   <para>docso:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasService</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#hasService">http://purl.org/ontology/dso#hasService</seealso>
    let hasService = Prefixed_Name(docso, "hasService") |> PrefixedName
    /// <summary>
    ///   <para>docso:hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasDocument</para></remarks>
    /// <seealso href="http://purl.org/ontology/dso#hasDocument">http://purl.org/ontology/dso#hasDocument</seealso>
    let hasDocument = Prefixed_Name(docso, "hasDocument") |> PrefixedName

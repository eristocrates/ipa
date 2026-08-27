namespace https.www.omg.org.spec.Commons.Documents.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module Documents =
    let _namespace_iri = Namespace_Iri Documents |> NamespaceIRI
    /// <summary>
    ///   <para>Documents:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/">https://www.omg.org/spec/Commons/Documents/</seealso>
    let _prefix_iri = Prefixed_Name(Documents, "") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Certificate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Certificate">https://www.omg.org/spec/Commons/Documents/Certificate</seealso>
    let Certificate = Prefixed_Name(Documents, "Certificate") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Document</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Document">https://www.omg.org/spec/Commons/Documents/Document</seealso>
    let Document = Prefixed_Name(Documents, "Document") |> PrefixedName
    /// <summary>
    ///   <para>Documents:LegalDocument</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/LegalDocument">https://www.omg.org/spec/Commons/Documents/LegalDocument</seealso>
    let LegalDocument = Prefixed_Name(Documents, "LegalDocument") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Notice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Notice">https://www.omg.org/spec/Commons/Documents/Notice</seealso>
    let Notice = Prefixed_Name(Documents, "Notice") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Record</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Record">https://www.omg.org/spec/Commons/Documents/Record</seealso>
    let Record = Prefixed_Name(Documents, "Record") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Reference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Reference">https://www.omg.org/spec/Commons/Documents/Reference</seealso>
    let Reference = Prefixed_Name(Documents, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>Documents:Specification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/Specification">https://www.omg.org/spec/Commons/Documents/Specification</seealso>
    let Specification = Prefixed_Name(Documents, "Specification") |> PrefixedName
    /// <summary>
    ///   <para>Documents:hasDataSource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/hasDataSource">https://www.omg.org/spec/Commons/Documents/hasDataSource</seealso>
    let hasDataSource = Prefixed_Name(Documents, "hasDataSource") |> PrefixedName
    /// <summary>
    ///   <para>Documents:isAbout</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/isAbout">https://www.omg.org/spec/Commons/Documents/isAbout</seealso>
    let isAbout = Prefixed_Name(Documents, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>Documents:isReferredToBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/isReferredToBy">https://www.omg.org/spec/Commons/Documents/isReferredToBy</seealso>
    let isReferredToBy = Prefixed_Name(Documents, "isReferredToBy") |> PrefixedName
    /// <summary>
    ///   <para>Documents:isSpecifiedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/isSpecifiedIn">https://www.omg.org/spec/Commons/Documents/isSpecifiedIn</seealso>
    let isSpecifiedIn = Prefixed_Name(Documents, "isSpecifiedIn") |> PrefixedName
    /// <summary>
    ///   <para>Documents:records</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/records">https://www.omg.org/spec/Commons/Documents/records</seealso>
    let records = Prefixed_Name(Documents, "records") |> PrefixedName
    /// <summary>
    ///   <para>Documents:refersTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/refersTo">https://www.omg.org/spec/Commons/Documents/refersTo</seealso>
    let refersTo = Prefixed_Name(Documents, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>Documents:specifies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Documents/specifies">https://www.omg.org/spec/Commons/Documents/specifies</seealso>
    let specifies = Prefixed_Name(Documents, "specifies") |> PrefixedName

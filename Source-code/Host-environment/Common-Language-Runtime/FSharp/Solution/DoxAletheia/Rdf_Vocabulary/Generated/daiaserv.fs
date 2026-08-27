namespace http.purl.org.ontology.daia.Service.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module daiaserv =
    let _namespace_iri = Namespace_Iri daiaserv |> NamespaceIRI
    /// <summary>
    ///   <para>daia:Service/Interloan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use mediated by another institution."</para>
    /// labels<para>"interloan service"</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Interloan">http://purl.org/ontology/daia/Service/Interloan</seealso>
    let Interloan = Prefixed_Name(daiaserv, "Interloan") |> PrefixedName
    /// <summary>
    ///   <para>daia:Service/Loan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use outside of the holding institution (by lending or online access)"</para>
    /// labels<para>"loan service"</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Loan">http://purl.org/ontology/daia/Service/Loan</seealso>
    let Loan = Prefixed_Name(daiaserv, "Loan") |> PrefixedName
    /// <summary>
    ///   <para>daia:Service/Openaccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"can be accessed freely on the Web"</para>
    /// labels<para>"open access service"</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Openaccess">http://purl.org/ontology/daia/Service/Openaccess</seealso>
    let Openaccess = Prefixed_Name(daiaserv, "Openaccess") |> PrefixedName
    /// <summary>
    ///   <para>daia:Service/Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Use within the holding institution (in their rooms, in their intranet etc.)"</para>
    /// labels<para>"presentation service"</para></remarks>
    /// <seealso href="http://purl.org/ontology/daia/Service/Presentation">http://purl.org/ontology/daia/Service/Presentation</seealso>
    let Presentation = Prefixed_Name(daiaserv, "Presentation") |> PrefixedName

namespace http.iserve.kmi._open.ac.uk.ns.hrests.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hr =
    let _namespace_iri = Namespace_Iri hr |> NamespaceIRI
    /// <summary>
    ///   <para>hr:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#">http://iserve.kmi.open.ac.uk/ns/hrests#</seealso>
    let _prefix_iri = Prefixed_Name(hr, "") |> PrefixedName

    /// <summary>
    ///   <para>hr:AuthenticationCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Authentication Credential"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#AuthenticationCredential">http://iserve.kmi.open.ac.uk/ns/hrests#AuthenticationCredential</seealso>
    let AuthenticationCredential =
        Prefixed_Name(hr, "AuthenticationCredential") |> PrefixedName

    /// <summary>
    ///   <para>hr:MediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///
    /// labels<para>"Media Type"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#MediaType">http://iserve.kmi.open.ac.uk/ns/hrests#MediaType</seealso>
    let MediaType = Prefixed_Name(hr, "MediaType") |> PrefixedName
    /// <summary>
    ///   <para>hr:Method</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#Method">http://iserve.kmi.open.ac.uk/ns/hrests#Method</seealso>
    let Method = Prefixed_Name(hr, "Method") |> PrefixedName

    /// <summary>
    ///   <para>hr:OutputFormatParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Output Format Parameter"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#OutputFormatParameter">http://iserve.kmi.open.ac.uk/ns/hrests#OutputFormatParameter</seealso>
    let OutputFormatParameter =
        Prefixed_Name(hr, "OutputFormatParameter") |> PrefixedName

    /// <summary>
    ///   <para>hr:URITemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"URI Template"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#URITemplate">http://iserve.kmi.open.ac.uk/ns/hrests#URITemplate</seealso>
    let URITemplate = Prefixed_Name(hr, "URITemplate") |> PrefixedName
    /// <summary>
    ///   <para>hr:acceptsContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"accepts Content Type"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#acceptsContentType">http://iserve.kmi.open.ac.uk/ns/hrests#acceptsContentType</seealso>
    let acceptsContentType = Prefixed_Name(hr, "acceptsContentType") |> PrefixedName

    /// <summary>
    ///   <para>hr:automaticallyExtractedDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"automatically Extracted Description"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#automaticallyExtractedDescription">http://iserve.kmi.open.ac.uk/ns/hrests#automaticallyExtractedDescription</seealso>
    let automaticallyExtractedDescription =
        Prefixed_Name(hr, "automaticallyExtractedDescription") |> PrefixedName

    /// <summary>
    ///   <para>hr:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Address"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#hasAddress">http://iserve.kmi.open.ac.uk/ns/hrests#hasAddress</seealso>
    let hasAddress = Prefixed_Name(hr, "hasAddress") |> PrefixedName
    /// <summary>
    ///   <para>hr:hasComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Comment"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#hasComment">http://iserve.kmi.open.ac.uk/ns/hrests#hasComment</seealso>
    let hasComment = Prefixed_Name(hr, "hasComment") |> PrefixedName
    /// <summary>
    ///   <para>hr:hasMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has Method"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#hasMethod">http://iserve.kmi.open.ac.uk/ns/hrests#hasMethod</seealso>
    let hasMethod = Prefixed_Name(hr, "hasMethod") |> PrefixedName
    /// <summary>
    ///   <para>hr:isGroundedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"is Grounded In"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#isGroundedIn">http://iserve.kmi.open.ac.uk/ns/hrests#isGroundedIn</seealso>
    let isGroundedIn = Prefixed_Name(hr, "isGroundedIn") |> PrefixedName
    /// <summary>
    ///   <para>hr:producesContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"produces Content Type"</para></remarks>
    /// <seealso href="http://iserve.kmi.open.ac.uk/ns/hrests#producesContentType">http://iserve.kmi.open.ac.uk/ns/hrests#producesContentType</seealso>
    let producesContentType = Prefixed_Name(hr, "producesContentType") |> PrefixedName

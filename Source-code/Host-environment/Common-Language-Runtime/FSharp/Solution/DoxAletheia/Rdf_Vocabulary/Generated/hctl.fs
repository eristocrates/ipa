namespace https.www.w3.org._2019.wot.hypermedia.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hctl =
    let _namespace_iri = Namespace_Iri hctl |> NamespaceIRI
    /// <summary>
    ///   <para>hctl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Ontology designed to provide an RDF representation of Hypermedia Controls, in particular links and forms."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypermedia Controls Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#">https://www.w3.org/2019/wot/hypermedia#</seealso>
    let _prefix_iri = Prefixed_Name(hctl, "") |> PrefixedName
    /// <summary>
    ///   <para>hctl:ExpectedResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Communication metadata describing the expected response message."</para>
    /// labels<para>"ExpectedResponse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#ExpectedResponse">https://www.w3.org/2019/wot/hypermedia#ExpectedResponse</seealso>
    let ExpectedResponse = Prefixed_Name(hctl, "ExpectedResponse") |> PrefixedName
    /// <summary>
    ///   <para>hctl:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A form can be viewed as a statement of "To perform an &lt;b&gt;&lt;em&gt;operation type&lt;/em&gt;&lt;/b&gt; operation on &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt;, make a &lt;b&gt;&lt;em&gt;request method&lt;/b&gt;&lt;/em&gt; request to &lt;b&gt;&lt;em&gt;submission target&lt;/b&gt;&lt;/em&gt;" where the optional &lt;b&gt;&lt;em&gt;form fields&lt;/b&gt;&lt;/em&gt; may further describe the required request. In Thing Descriptions, the &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt; is the surrounding Object, such as Properties, Actions, and Events or the Thing itself for meta-interactions."</para>
    /// labels<para>"Form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#Form">https://www.w3.org/2019/wot/hypermedia#Form</seealso>
    let Form = Prefixed_Name(hctl, "Form") |> PrefixedName
    /// <summary>
    ///   <para>hctl:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A link can be viewed as a statement of the form "&lt;b&gt;&lt;em&gt;link context&lt;/em&gt;&lt;/b&gt;  has a &lt;b&gt;&lt;em&gt;relation type&lt;/em&gt;&lt;/b&gt; resource at &lt;b&gt;&lt;em&gt;link target&lt;/em&gt;&lt;/b&gt;", where the optional &lt;b&gt;&lt;em&gt;target attributes&lt;/em&gt;&lt;/b&gt;  may further describe the resource."</para>
    /// labels<para>"Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#Link">https://www.w3.org/2019/wot/hypermedia#Link</seealso>
    let Link = Prefixed_Name(hctl, "Link") |> PrefixedName
    /// <summary>
    ///   <para>hctl:forContentCoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Content coding values indicate an encoding transformation that has been or can be applied to a representation. Content codings are primarily used to allow a representation to be compressed or otherwise usefully transformed without losing the identity of its underlying media type and without loss of information. Examples of content coding include "gzip", "deflate", etc. "</para>
    /// labels<para>"forContentCoding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#forContentCoding">https://www.w3.org/2019/wot/hypermedia#forContentCoding</seealso>
    let forContentCoding = Prefixed_Name(hctl, "forContentCoding") |> PrefixedName
    /// <summary>
    ///   <para>hctl:forContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Assign a content type based on a media type [[IANA-MEDIA-TYPES]] (e.g., 'text/plain') and potential parameters (e.g., 'charset=utf-8') for the media type."</para>
    /// labels<para>"forContentType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#forContentType">https://www.w3.org/2019/wot/hypermedia#forContentType</seealso>
    let forContentType = Prefixed_Name(hctl, "forContentType") |> PrefixedName
    /// <summary>
    ///   <para>hctl:forSubProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates the exact mechanism by which an interaction will be accomplished for a given protocol when there are multiple options.
    ///
    /// For example, for HTTP and Events, it indicates which of several available mechanisms should be used for asynchronous notifications such as long polling, websub (also see https://www.w3.org/TR/websub/), or server sent events (also see https://www.w3.org/TR/eventsource/). Please note that there is no restriction on the sub-protocol selection and other mechanisms can also be announced by this subprotocol term."</para>
    /// labels<para>"forSubProtocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#forSubProtocol">https://www.w3.org/2019/wot/hypermedia#forSubProtocol</seealso>
    let forSubProtocol = Prefixed_Name(hctl, "forSubProtocol") |> PrefixedName
    /// <summary>
    ///   <para>hctl:hasAnchor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"By default, the context, or anchor, of a link conveyed in the Link header field is the URL of the representation it is associated with, as defined in RFC7231, Section 3.1.4.1, and is serialized as a URI."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAnchor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#hasAnchor">https://www.w3.org/2019/wot/hypermedia#hasAnchor</seealso>
    let hasAnchor = Prefixed_Name(hctl, "hasAnchor") |> PrefixedName
    /// <summary>
    ///   <para>hctl:hasOperationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the semantic intention of performing the operation(s) described by the form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasOperationType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#hasOperationType">https://www.w3.org/2019/wot/hypermedia#hasOperationType</seealso>
    let hasOperationType = Prefixed_Name(hctl, "hasOperationType") |> PrefixedName
    /// <summary>
    ///   <para>hctl:hasRelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A link relation type identifies the semantics of a link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasRelationType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#hasRelationType">https://www.w3.org/2019/wot/hypermedia#hasRelationType</seealso>
    let hasRelationType = Prefixed_Name(hctl, "hasRelationType") |> PrefixedName
    /// <summary>
    ///   <para>hctl:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Class has target uri."</para>
    ///   <para>"target IRI of a link or submission target of a form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has target"</para><para>"hasTarget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#hasTarget">https://www.w3.org/2019/wot/hypermedia#hasTarget</seealso>
    let hasTarget = Prefixed_Name(hctl, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>hctl:hintsAtMediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Target attribute providing a hint indicating what the media type [IANA-MEDIA-TYPES] of the result of dereferencing the link should be."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hintsAtMediaType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#hintsAtMediaType">https://www.w3.org/2019/wot/hypermedia#hintsAtMediaType</seealso>
    let hintsAtMediaType = Prefixed_Name(hctl, "hintsAtMediaType") |> PrefixedName
    /// <summary>
    ///   <para>hctl:returns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This optional term can be used if, e.g., the output communication metadata differ from input metdata (e.g., output contentType differ from the
    ///      input contentType). The response name contains metadata that is only valid for the reponse messages."</para>
    /// labels<para>"returns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/2019/wot/hypermedia#returns">https://www.w3.org/2019/wot/hypermedia#returns</seealso>
    let returns = Prefixed_Name(hctl, "returns") |> PrefixedName

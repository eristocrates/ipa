#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module hctl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/hypermedia#" "hctl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ExpectedResponse^^xsd:string</para>
    ///   <para>rdfs:comment : Communication metadata describing the expected response message.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#ExpectedResponse">hctl:ExpectedResponse</a>
    /// </summary>
    let ExpectedResponse = _prefixId.prefix "ExpectedResponse"
    /// <summary>
    ///   <para>rdfs:label : Form^^xsd:string</para>
    ///   <para>rdfs:comment : A form can be viewed as a statement of "To perform an &lt;b&gt;&lt;em&gt;operation type&lt;/em&gt;&lt;/b&gt; operation on &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt;, make a &lt;b&gt;&lt;em&gt;request method&lt;/b&gt;&lt;/em&gt; request to &lt;b&gt;&lt;em&gt;submission target&lt;/b&gt;&lt;/em&gt;" where the optional &lt;b&gt;&lt;em&gt;form fields&lt;/b&gt;&lt;/em&gt; may further describe the required request. In Thing Descriptions, the &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt; is the surrounding Object, such as Properties, Actions, and Events or the Thing itself for meta-interactions.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#Form">hctl:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    /// <summary>
    ///   <para>rdfs:label : Link^^xsd:string</para>
    ///   <para>rdfs:comment : A link can be viewed as a statement of the form "&lt;b&gt;&lt;em&gt;link context&lt;/em&gt;&lt;/b&gt;  has a &lt;b&gt;&lt;em&gt;relation type&lt;/em&gt;&lt;/b&gt; resource at &lt;b&gt;&lt;em&gt;link target&lt;/em&gt;&lt;/b&gt;", where the optional &lt;b&gt;&lt;em&gt;target attributes&lt;/em&gt;&lt;/b&gt;  may further describe the resource.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#Link">hctl:Link</a>
    /// </summary>
    let Link = _prefixId.prefix "Link"
    /// <summary>
    ///   <para>rdfs:label : forContentCoding^^xsd:string</para>
    ///   <para>rdfs:comment : Content coding values indicate an encoding transformation that has been or can be applied to a representation. Content codings are primarily used to allow a representation to be compressed or otherwise usefully transformed without losing the identity of its underlying media type and without loss of information. Examples of content coding include "gzip", "deflate", etc. </para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#forContentCoding">hctl:forContentCoding</a>
    /// </summary>
    let forContentCoding = _prefixId.prefix "forContentCoding"
    /// <summary>
    ///   <para>rdfs:label : forContentType^^xsd:string</para>
    ///   <para>rdfs:comment : Assign a content type based on a media type [[IANA-MEDIA-TYPES]] (e.g., 'text/plain') and potential parameters (e.g., 'charset=utf-8') for the media type.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#forContentType">hctl:forContentType</a>
    /// </summary>
    let forContentType = _prefixId.prefix "forContentType"
    /// <summary>
    ///   <para>rdfs:label : forSubProtocol^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the exact mechanism by which an interaction will be accomplished for a given protocol when there are multiple options.
    ///
    /// For example, for HTTP and Events, it indicates which of several available mechanisms should be used for asynchronous notifications such as long polling, websub (also see https://www.w3.org/TR/websub/), or server sent events (also see https://www.w3.org/TR/eventsource/). Please note that there is no restriction on the sub-protocol selection and other mechanisms can also be announced by this subprotocol term.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#forSubProtocol">hctl:forSubProtocol</a>
    /// </summary>
    let forSubProtocol = _prefixId.prefix "forSubProtocol"
    /// <summary>
    ///   <para>rdfs:label : hasAnchor^^xsd:string</para>
    ///   <para>rdfs:comment : By default, the context, or anchor, of a link conveyed in the Link header field is the URL of the representation it is associated with, as defined in RFC7231, Section 3.1.4.1, and is serialized as a URI.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#hasAnchor">hctl:hasAnchor</a>
    /// </summary>
    let hasAnchor = _prefixId.prefix "hasAnchor"
    /// <summary>
    ///   <para>rdfs:label : hasOperationType^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the semantic intention of performing the operation(s) described by the form.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#hasOperationType">hctl:hasOperationType</a>
    /// </summary>
    let hasOperationType = _prefixId.prefix "hasOperationType"
    /// <summary>
    ///   <para>rdfs:label : hasRelationType^^xsd:string</para>
    ///   <para>rdfs:comment : A link relation type identifies the semantics of a link.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#hasRelationType">hctl:hasRelationType</a>
    /// </summary>
    let hasRelationType = _prefixId.prefix "hasRelationType"
    /// <summary>
    ///   <para>rdfs:label : hasTarget^^xsd:string</para>
    ///   <para>rdfs:comment : target IRI of a link or submission target of a form.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#hasTarget">hctl:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    /// <summary>
    ///   <para>rdfs:label : hintsAtMediaType^^xsd:string</para>
    ///   <para>rdfs:comment : Target attribute providing a hint indicating what the media type [IANA-MEDIA-TYPES] of the result of dereferencing the link should be.^^xsd:string</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#hintsAtMediaType">hctl:hintsAtMediaType</a>
    /// </summary>
    let hintsAtMediaType = _prefixId.prefix "hintsAtMediaType"
    /// <summary>
    ///   <para>rdfs:label : returns^^xsd:string</para>
    ///   <para>rdfs:comment : This optional term can be used if, e.g., the output communication metadata differ from input metdata (e.g., output contentType differ from the
    ///      input contentType). The response name contains metadata that is only valid for the reponse messages.</para>
    ///   <a href="https://www.w3.org/2019/wot/hypermedia#returns">hctl:returns</a>
    /// </summary>
    let returns = _prefixId.prefix "returns"

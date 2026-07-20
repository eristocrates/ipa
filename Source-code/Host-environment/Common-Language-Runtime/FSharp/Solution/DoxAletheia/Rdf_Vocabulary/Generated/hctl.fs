namespace https.www.w3.org._2019.wot.hypermedia.hash

open DoxAletheia

module hctl =
    let _namespace_name = "https://www.w3.org/2019/wot/hypermedia#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Communication metadata describing the expected response message.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#ExpectedResponse"></see></summary>
    let ExpectedResponse = _prefix "ExpectedResponse"
    /// <summary>
    /// A form can be viewed as a statement of "To perform an &lt;b&gt;&lt;em&gt;operation type&lt;/em&gt;&lt;/b&gt; operation on &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt;, make a &lt;b&gt;&lt;em&gt;request method&lt;/b&gt;&lt;/em&gt; request to &lt;b&gt;&lt;em&gt;submission target&lt;/b&gt;&lt;/em&gt;" where the optional &lt;b&gt;&lt;em&gt;form fields&lt;/b&gt;&lt;/em&gt; may further describe the required request. In Thing Descriptions, the &lt;b&gt;&lt;em&gt;form context&lt;/b&gt;&lt;/em&gt; is the surrounding Object, such as Properties, Actions, and Events or the Thing itself for meta-interactions.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#Form"></see></summary>
    let Form = _prefix "Form"
    /// <summary>
    /// A link can be viewed as a statement of the form "&lt;b&gt;&lt;em&gt;link context&lt;/em&gt;&lt;/b&gt;  has a &lt;b&gt;&lt;em&gt;relation type&lt;/em&gt;&lt;/b&gt; resource at &lt;b&gt;&lt;em&gt;link target&lt;/em&gt;&lt;/b&gt;", where the optional &lt;b&gt;&lt;em&gt;target attributes&lt;/em&gt;&lt;/b&gt;  may further describe the resource.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// Content coding values indicate an encoding transformation that has been or can be applied to a representation. Content codings are primarily used to allow a representation to be compressed or otherwise usefully transformed without losing the identity of its underlying media type and without loss of information. Examples of content coding include "gzip", "deflate", etc.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#forContentCoding"></see></summary>
    let forContentCoding = _prefix "forContentCoding"
    /// <summary>
    /// Assign a content type based on a media type [[IANA-MEDIA-TYPES]] (e.g., 'text/plain') and potential parameters (e.g., 'charset=utf-8') for the media type.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#forContentType"></see></summary>
    let forContentType = _prefix "forContentType"
    /// <summary>
    /// Indicates the exact mechanism by which an interaction will be accomplished for a given protocol when there are multiple options.
    ///
    /// For example, for HTTP and Events, it indicates which of several available mechanisms should be used for asynchronous notifications such as long polling, websub (also see https://www.w3.org/TR/websub/), or server sent events (also see https://www.w3.org/TR/eventsource/). Please note that there is no restriction on the sub-protocol selection and other mechanisms can also be announced by this subprotocol term.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#forSubProtocol"></see></summary>
    let forSubProtocol = _prefix "forSubProtocol"
    /// <summary>
    /// By default, the context, or anchor, of a link conveyed in the Link header field is the URL of the representation it is associated with, as defined in RFC7231, Section 3.1.4.1, and is serialized as a URI.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#hasAnchor"></see></summary>
    let hasAnchor = _prefix "hasAnchor"
    /// <summary>
    /// Indicates the semantic intention of performing the operation(s) described by the form.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#hasOperationType"></see></summary>
    let hasOperationType = _prefix "hasOperationType"
    /// <summary>
    /// A link relation type identifies the semantics of a link.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#hasRelationType"></see></summary>
    let hasRelationType = _prefix "hasRelationType"
    /// <summary>
    /// target IRI of a link or submission target of a form.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#hasTarget"></see></summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    /// Target attribute providing a hint indicating what the media type [IANA-MEDIA-TYPES] of the result of dereferencing the link should be.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#hintsAtMediaType"></see></summary>
    let hintsAtMediaType = _prefix "hintsAtMediaType"
    /// <summary>
    /// This optional term can be used if, e.g., the output communication metadata differ from input metdata (e.g., output contentType differ from the
    ///      input contentType). The response name contains metadata that is only valid for the reponse messages.
    /// <see href="https://www.w3.org/2019/wot/hypermedia#returns"></see></summary>
    let returns = _prefix "returns"

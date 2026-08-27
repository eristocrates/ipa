namespace http.purl.org.rss._1._0.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rss =
    let _namespace_iri = Namespace_Iri rss |> NamespaceIRI
    /// <summary>
    ///   <para>rss:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/rss/1.0/">http://purl.org/rss/1.0/</seealso>
    let _prefix_iri = Prefixed_Name(rss, "") |> PrefixedName
    /// <summary>
    ///   <para>rss:channel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An RSS information channel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""An RSS information channel.""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RSS1.0 News Channel"</para><para>"Channel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/channel">http://purl.org/rss/1.0/channel</seealso>
    let channel = Prefixed_Name(rss, "channel") |> PrefixedName
    /// <summary>
    ///   <para>rss:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A short text description of the subject."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"</para><para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/description">http://purl.org/rss/1.0/description</seealso>
    let description = Prefixed_Name(rss, "description") |> PrefixedName
    /// <summary>
    ///   <para>rss:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An RSS image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/image">http://purl.org/rss/1.0/image</seealso>
    let image = Prefixed_Name(rss, "image") |> PrefixedName
    /// <summary>
    ///   <para>rss:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An RSS item."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Item"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"RSS1.0 News Item"</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/item">http://purl.org/rss/1.0/item</seealso>
    let item = Prefixed_Name(rss, "item") |> PrefixedName
    /// <summary>
    ///   <para>rss:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>""Points to a list of rss:item elements that are members of the subject channel." NOTE: the range is actually rdf:Seq"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Points to a list of rss:item elements that are members of the subject channel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Items"</para><para>"Items"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/items">http://purl.org/rss/1.0/items</seealso>
    let items = Prefixed_Name(rss, "items") |> PrefixedName
    /// <summary>
    ///   <para>rss:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL to which an HTML rendering of the subject will link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"If this publication can be accessed in electronic form, the corresponding URL can be using the rss:link property. NOTE: this definition is a slightly extended version of the definition in the RSS 1.0 specification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Link"</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/link">http://purl.org/rss/1.0/link</seealso>
    let link = Prefixed_Name(rss, "link") |> PrefixedName
    /// <summary>
    ///   <para>rss:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The text input field's (variable) name."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/name">http://purl.org/rss/1.0/name</seealso>
    let name = Prefixed_Name(rss, "name") |> PrefixedName
    /// <summary>
    ///   <para>rss:textinput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An RSS text input."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Text Input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/textinput">http://purl.org/rss/1.0/textinput</seealso>
    let textinput = Prefixed_Name(rss, "textinput") |> PrefixedName
    /// <summary>
    ///   <para>rss:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A descriptive title for the channel."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Title"</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/title">http://purl.org/rss/1.0/title</seealso>
    let title = Prefixed_Name(rss, "title") |> PrefixedName
    /// <summary>
    ///   <para>rss:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The URL of the image to used in the 'src' attribute of the channel's image tag when rendered as HTML."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/rss/1.0/url">http://purl.org/rss/1.0/url</seealso>
    let url = Prefixed_Name(rss, "url") |> PrefixedName

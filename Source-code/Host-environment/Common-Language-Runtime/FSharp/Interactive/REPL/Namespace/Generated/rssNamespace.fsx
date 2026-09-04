#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rss =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/rss/1.0/" "rss"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : An RSS information channel.^^xsd:string</para>
    ///   <para>rdfs:label : Channel^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/channel">rss:channel</a>
    /// </summary>
    let channel = _prefixId.prefix "channel"
    /// <summary>
    ///   <para>rdfs:comment : A short text description of the subject.^^xsd:string</para>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/description">rss:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : An RSS image.^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/image">rss:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:comment : An RSS item.^^xsd:string</para>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/item">rss:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>rdfs:comment : Points to a list of rss:item elements that are members of the subject channel.^^xsd:string</para>
    ///   <para>rdfs:label : Items^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/items">rss:items</a>
    /// </summary>
    let items = _prefixId.prefix "items"
    /// <summary>
    ///   <para>rdfs:comment : The URL to which an HTML rendering of the subject will link.^^xsd:string</para>
    ///   <para>rdfs:label : Link^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/link">rss:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:comment : The text input field's (variable) name.^^xsd:string</para>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/name">rss:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : An RSS text input.^^xsd:string</para>
    ///   <para>rdfs:label : Text Input^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/textinput">rss:textinput</a>
    /// </summary>
    let textinput = _prefixId.prefix "textinput"
    /// <summary>
    ///   <para>rdfs:comment : A descriptive title for the channel.^^xsd:string</para>
    ///   <para>rdfs:label : Title^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/title">rss:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : The URL of the image to used in the 'src' attribute of the channel's image tag when rendered as HTML.^^xsd:string</para>
    ///   <para>rdfs:label : URL^^xsd:string</para>
    ///   <a href="http://purl.org/rss/1.0/url">rss:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"

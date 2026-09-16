#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vann =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vocab/vann/" "vann"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A reference to a resource that describes changes between this version of a vocabulary and the previous.</para>
    ///   <para>rdfs:label : Changes</para>
    ///   <a href="http://purl.org/vocab/vann/changes">vann:changes</a>
    /// </summary>
    let changes = _prefixId.prefix "changes"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a resource that provides an example of how this resource can be used.</para>
    ///   <para>rdfs:label : Example</para>
    ///   <a href="http://purl.org/vocab/vann/example">vann:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    /// <summary>
    ///   <para>rdfs:comment : The preferred namespace prefix to use when using terms from this vocabulary in an XML document.</para>
    ///   <para>rdfs:label : Preferred Namespace Prefix</para>
    ///   <a href="http://purl.org/vocab/vann/preferredNamespacePrefix">vann:preferredNamespacePrefix</a>
    /// </summary>
    let preferredNamespacePrefix = _prefixId.prefix "preferredNamespacePrefix"
    /// <summary>
    ///   <para>rdfs:comment : The preferred namespace URI to use when using terms from this vocabulary in an XML document.</para>
    ///   <para>rdfs:label : Preferred Namespace Uri</para>
    ///   <a href="http://purl.org/vocab/vann/preferredNamespaceUri">vann:preferredNamespaceUri</a>
    /// </summary>
    let preferredNamespaceUri = _prefixId.prefix "preferredNamespaceUri"
    /// <summary>
    ///   <para>rdfs:comment : A group of related terms in a vocabulary.</para>
    ///   <para>rdfs:label : Term Group</para>
    ///   <a href="http://purl.org/vocab/vann/termGroup">vann:termGroup</a>
    /// </summary>
    let termGroup = _prefixId.prefix "termGroup"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a resource that provides information on how this resource is to be used.</para>
    ///   <para>rdfs:label : Usage Note</para>
    ///   <a href="http://purl.org/vocab/vann/usageNote">vann:usageNote</a>
    /// </summary>
    let usageNote = _prefixId.prefix "usageNote"
    let vann_vocab_20040305 = _prefixId.prefix "vann-vocab-20040305"

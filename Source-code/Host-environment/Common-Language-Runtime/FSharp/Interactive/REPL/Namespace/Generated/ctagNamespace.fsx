#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ctag =
    let _prefixId = PrefixId.fromNamespaceLabel "http://commontag.org/ns#" "ctag"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Author Tag</para>
    ///   <para>rdfs:comment : A Tag asserted by the author of a content resource.</para>
    ///   <a href="http://commontag.org/ns#AuthorTag">ctag:AuthorTag</a>
    /// </summary>
    let AuthorTag = _prefixId.prefix "AuthorTag"
    /// <summary>
    ///   <para>rdfs:label : Auto Tag</para>
    ///   <para>rdfs:comment : A Tag asserted by an automated tool on a content resource.</para>
    ///   <a href="http://commontag.org/ns#AutoTag">ctag:AutoTag</a>
    /// </summary>
    let AutoTag = _prefixId.prefix "AutoTag"
    /// <summary>
    ///   <para>rdfs:label : Reader Tag</para>
    ///   <para>rdfs:comment : A Tag asserted by the reader (consumer) of a content resource.</para>
    ///   <a href="http://commontag.org/ns#ReaderTag">ctag:ReaderTag</a>
    /// </summary>
    let ReaderTag = _prefixId.prefix "ReaderTag"
    /// <summary>
    ///   <para>rdfs:label : Tag</para>
    ///   <para>rdfs:comment : A Common Tag associating a URI and a keyword to annotate a resource.</para>
    ///   <a href="http://commontag.org/ns#Tag">ctag:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:label : Tagged Content</para>
    ///   <para>rdfs:comment : Content which has one or more Common Tag.</para>
    ///   <a href="http://commontag.org/ns#TaggedContent">ctag:TaggedContent</a>
    /// </summary>
    let TaggedContent = _prefixId.prefix "TaggedContent"
    /// <summary>
    ///   <para>rdfs:label : is about</para>
    ///   <para>rdfs:comment : A resource (URI) representing the concepts described by the content.</para>
    ///   <a href="http://commontag.org/ns#isAbout">ctag:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : tag label</para>
    ///   <para>rdfs:comment : A local, human-readable name for a Tag.</para>
    ///   <a href="http://commontag.org/ns#label">ctag:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : means</para>
    ///   <para>rdfs:comment : A a resource (URI) representing the conceptual meaning of a Tag.</para>
    ///   <a href="http://commontag.org/ns#means">ctag:means</a>
    /// </summary>
    let means = _prefixId.prefix "means"
    /// <summary>
    ///   <para>rdfs:label : tagged</para>
    ///   <para>rdfs:comment : Links a resource to a Common Tag.</para>
    ///   <a href="http://commontag.org/ns#tagged">ctag:tagged</a>
    /// </summary>
    let tagged = _prefixId.prefix "tagged"
    /// <summary>
    ///   <para>rdfs:label : tagging date</para>
    ///   <para>rdfs:comment : The date the Tag was assigned.</para>
    ///   <a href="http://commontag.org/ns#taggingDate">ctag:taggingDate</a>
    /// </summary>
    let taggingDate = _prefixId.prefix "taggingDate"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module moat =
    let _prefixId = PrefixId.fromNamespaceLabel "http://moat-project.org/ns#" "moat"
    let _namespaceIri = _prefixId.prefix ""
    let AutomatedTagging = _prefixId.prefix "AutomatedTagging"
    /// <summary>
    ///   <para>rdfs:comment : A reified object to define a potential meaning for a Tag. The meaning is a unique and explicitely defined Semantic Web resource and is related to the agent that defined it with foaf:maker</para>
    ///   <para>rdfs:label : Tag Meaning^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#Meaning">moat:Meaning</a>
    /// </summary>
    let Meaning = _prefixId.prefix "Meaning"
    /// <summary>
    ///   <para>rdfs:comment : A Tag URI, that provides an unique identifier for a label attached to a resource</para>
    ///   <para>rdfs:label : Tag URI^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#Tag">moat:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    let TagType = _prefixId.prefix "TagType"
    let ValidatedTagging = _prefixId.prefix "ValidatedTagging"
    /// <summary>
    ///   <para>rdfs:comment : The link between a Tag and a Meaning object in a global context</para>
    ///   <para>rdfs:label : tag meaning object - global context^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#hasMeaning">moat:hasMeaning</a>
    /// </summary>
    let hasMeaning = _prefixId.prefix "hasMeaning"
    /// <summary>
    ///   <para>rdfs:comment : The URI used as a meaning for a local meaning of a Tag with MOAT</para>
    ///   <para>rdfs:label : local Meaning^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#localMeaning">moat:localMeaning</a>
    /// </summary>
    let localMeaning = _prefixId.prefix "localMeaning"
    /// <summary>
    ///   <para>rdfs:comment : The link between a reified Meaning object and the URI that defines a meaning</para>
    ///   <para>rdfs:label : tag meaning URI - global context^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#meaningURI">moat:meaningURI</a>
    /// </summary>
    let meaningURI = _prefixId.prefix "meaningURI"
    /// <summary>
    ///   <para>rdfs:comment : The link between a Tagging and a meaning (URI) of a tag in a given context (i.e. blog post)</para>
    ///   <para>rdfs:label : tag meaning - tagging context^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#tagMeaning">moat:tagMeaning</a>
    /// </summary>
    let tagMeaning = _prefixId.prefix "tagMeaning"
    /// <summary>
    ///   <para>rdfs:comment : The type of the tagging, i.e. automatic or has been validated</para>
    ///   <para>rdfs:label : tagging type^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#tagType">moat:tagType</a>
    /// </summary>
    let tagType = _prefixId.prefix "tagType"
    /// <summary>
    ///   <para>rdfs:comment : The URI ised to 'tag' an item with MOAT</para>
    ///   <para>rdfs:label : tagged with^^xsd:string</para>
    ///   <a href="http://moat-project.org/ns#taggedWith">moat:taggedWith</a>
    /// </summary>
    let taggedWith = _prefixId.prefix "taggedWith"

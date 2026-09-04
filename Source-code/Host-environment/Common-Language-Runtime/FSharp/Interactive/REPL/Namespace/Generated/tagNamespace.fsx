#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tag =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.holygoat.co.uk/owl/redwood/0.1/tags/" "tag"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : restricted tagging</para>
    ///   <para>rdfs:comment : A Tagging which has precisely one associated resource, and one associated tag.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/RestrictedTagging">tag:RestrictedTagging</a>
    /// </summary>
    let RestrictedTagging = _prefixId.prefix "RestrictedTagging"
    /// <summary>
    ///   <para>skos:definition : A natural-language concept which is used to annotate another resource.</para>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tag">tag:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagging</para>
    ///   <para>rdfs:comment : A reified class which defines an instance of a tagging by an agent of a resource with one or more tags.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tagging">tag:Tagging</a>
    /// </summary>
    let Tagging = _prefixId.prefix "Tagging"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : associated tag^^xsd:string</para>
    ///   <para>rdfs:comment : The object is a Tag which plays a role in the subject Tagging.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/associatedTag">tag:associatedTag</a>
    /// </summary>
    let associatedTag = _prefixId.prefix "associatedTag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : equivalent tag</para>
    ///   <para>rdfs:comment : The two tags are asserted to be equivalent --- that is, that whenever one is associated with a resource, the other tag can be logically inferred to also be associated. Be very careful with this. I'm not sure if this should be a subproperty of owl:sameAs.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/equivalentTag">tag:equivalentTag</a>
    /// </summary>
    let equivalentTag = _prefixId.prefix "equivalentTag"
    /// <summary>
    ///   <para>rdfs:label : is tag of</para>
    ///   <para>rdfs:comment : Indicates that the subject tag applies to the object resource. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/isTagOf">tag:isTagOf</a>
    /// </summary>
    let isTagOf = _prefixId.prefix "isTagOf"
    /// <summary>
    ///   <para>rdfs:label : tag name</para>
    ///   <para>rdfs:comment : The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we?</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/name">tag:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : related tag</para>
    ///   <para>rdfs:comment : The two tags are asserted as being related. This might be symmetric, but it certainly isn't transitive.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/relatedTag">tag:relatedTag</a>
    /// </summary>
    let relatedTag = _prefixId.prefix "relatedTag"
    /// <summary>
    ///   <para>rdfs:label : tag</para>
    ///   <para>rdfs:comment : The relationship between a resource and a Tagging. Note, of course, that this allows us to tag tags and taggings themselves...</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tag">tag:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:label : tag name</para>
    ///   <para>rdfs:comment : The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we? DEPRECATED 2005-05-19: redundant 'tag'.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tagName">tag:tagName</a>
    /// </summary>
    let tagName = _prefixId.prefix "tagName"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagged by</para>
    ///   <para>rdfs:comment : The object plays the role of the tagger in the subject Tagging.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedBy">tag:taggedBy</a>
    /// </summary>
    let taggedBy = _prefixId.prefix "taggedBy"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagged on</para>
    ///   <para>rdfs:comment : The subject Tagging occurred at the subject time and date.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedOn">tag:taggedOn</a>
    /// </summary>
    let taggedOn = _prefixId.prefix "taggedOn"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagged resource</para>
    ///   <para>rdfs:comment : The object is a resource which plays a role in the subject Tagging.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedResource">tag:taggedResource</a>
    /// </summary>
    let taggedResource = _prefixId.prefix "taggedResource"
    /// <summary>
    ///   <para>rdfs:label : tagged with tag</para>
    ///   <para>rdfs:comment : Indicates that the subject has been tagged with the object tag. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.</para>
    ///   <a href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedWithTag">tag:taggedWithTag</a>
    /// </summary>
    let taggedWithTag = _prefixId.prefix "taggedWithTag"

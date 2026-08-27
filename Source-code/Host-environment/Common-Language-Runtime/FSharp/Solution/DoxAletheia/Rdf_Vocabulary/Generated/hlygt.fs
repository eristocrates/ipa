namespace http.www.holygoat.co.uk.owl.redwood._0._1.tags.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hlygt =
    let _namespace_iri = Namespace_Iri hlygt |> NamespaceIRI
    /// <summary>
    ///   <para>hlygt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"An ontology for tags."</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/">http://www.holygoat.co.uk/owl/redwood/0.1/tags/</seealso>
    let _prefix_iri = Prefixed_Name(hlygt, "") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:RestrictedTagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Tagging which has precisely one associated resource, and one associated tag."</para>
    /// labels<para>"restricted tagging"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/RestrictedTagging">http://www.holygoat.co.uk/owl/redwood/0.1/tags/RestrictedTagging</seealso>
    let RestrictedTagging = Prefixed_Name(hlygt, "RestrictedTagging") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tag"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tag</seealso>
    let Tag = Prefixed_Name(hlygt, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:Tagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A reified class which defines an instance of a tagging by an agent of a resource with one or more tags."</para>
    /// labels<para>"tagging"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tagging">http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tagging</seealso>
    let Tagging = Prefixed_Name(hlygt, "Tagging") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:associatedTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object is a Tag which plays a role in the subject Tagging."</para>
    /// labels<para>"associated tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/associatedTag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/associatedTag</seealso>
    let associatedTag = Prefixed_Name(hlygt, "associatedTag") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:equivalentTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The two tags are asserted to be equivalent --- that is, that whenever one is associated with a resource, the other tag can be logically inferred to also be associated. Be very careful with this. I'm not sure if this should be a subproperty of owl:sameAs."</para>
    /// labels<para>"equivalent tag"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/equivalentTag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/equivalentTag</seealso>
    let equivalentTag = Prefixed_Name(hlygt, "equivalentTag") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:isTagOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the subject tag applies to the object resource. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource."</para>
    /// labels<para>"is tag of"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/isTagOf">http://www.holygoat.co.uk/owl/redwood/0.1/tags/isTagOf</seealso>
    let isTagOf = Prefixed_Name(hlygt, "isTagOf") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we?"</para>
    /// labels<para>"tag name"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/name">http://www.holygoat.co.uk/owl/redwood/0.1/tags/name</seealso>
    let name = Prefixed_Name(hlygt, "name") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:relatedTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The two tags are asserted as being related. This might be symmetric, but it certainly isn't transitive."</para>
    /// labels<para>"related tag"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/relatedTag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/relatedTag</seealso>
    let relatedTag = Prefixed_Name(hlygt, "relatedTag") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relationship between a resource and a Tagging. Note, of course, that this allows us to tag tags and taggings themselves..."</para>
    /// labels<para>"tag"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/tag</seealso>
    let tag = Prefixed_Name(hlygt, "tag") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:tagName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we? DEPRECATED 2005-05-19: redundant 'tag'."</para>
    /// labels<para>"tag name"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tagName">http://www.holygoat.co.uk/owl/redwood/0.1/tags/tagName</seealso>
    let tagName = Prefixed_Name(hlygt, "tagName") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:taggedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object plays the role of the tagger in the subject Tagging."</para>
    /// labels<para>"tagged by"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedBy">http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedBy</seealso>
    let taggedBy = Prefixed_Name(hlygt, "taggedBy") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:taggedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject Tagging occurred at the subject time and date."</para>
    /// labels<para>"tagged on"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedOn">http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedOn</seealso>
    let taggedOn = Prefixed_Name(hlygt, "taggedOn") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:taggedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object is a resource which plays a role in the subject Tagging."</para>
    /// labels<para>"tagged resource"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedResource">http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedResource</seealso>
    let taggedResource = Prefixed_Name(hlygt, "taggedResource") |> PrefixedName
    /// <summary>
    ///   <para>hlygt:taggedWithTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the subject has been tagged with the object tag. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource."</para>
    /// labels<para>"tagged with tag"</para></remarks>
    /// <seealso href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedWithTag">http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedWithTag</seealso>
    let taggedWithTag = Prefixed_Name(hlygt, "taggedWithTag") |> PrefixedName

namespace http.www.holygoat.co.uk.owl.redwood._0._1.tags.slash

open DoxAletheia

module hlygt =
    let _namespace_name = "http://www.holygoat.co.uk/owl/redwood/0.1/tags/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Tagging which has precisely one associated resource, and one associated tag.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/RestrictedTagging"></see></summary>
    let RestrictedTagging = _prefix "RestrictedTagging"
    /// <summary>
    /// The object is a Tag which plays a role in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/associatedTag"></see></summary>
    let associatedTag = _prefix "associatedTag"
    /// <summary>
    /// The object is a resource which plays a role in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedResource"></see></summary>
    let taggedResource = _prefix "taggedResource"
    /// <summary>
    /// A reified class which defines an instance of a tagging by an agent of a resource with one or more tags.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tagging"></see></summary>
    let Tagging = _prefix "Tagging"
    /// <summary>
    ///   <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tag"></see>
    /// </summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// The two tags are asserted to be equivalent --- that is, that whenever one is associated with a resource, the other tag can be logically inferred to also be associated. Be very careful with this. I'm not sure if this should be a subproperty of owl:sameAs.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/equivalentTag"></see></summary>
    let equivalentTag = _prefix "equivalentTag"
    /// <summary>
    /// Indicates that the subject tag applies to the object resource. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/isTagOf"></see></summary>
    let isTagOf = _prefix "isTagOf"
    /// <summary>
    /// Indicates that the subject has been tagged with the object tag. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedWithTag"></see></summary>
    let taggedWithTag = _prefix "taggedWithTag"
    /// <summary>
    /// The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we?
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The two tags are asserted as being related. This might be symmetric, but it certainly isn't transitive.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/relatedTag"></see></summary>
    let relatedTag = _prefix "relatedTag"
    /// <summary>
    /// The relationship between a resource and a Tagging. Note, of course, that this allows us to tag tags and taggings themselves...
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    /// The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we? DEPRECATED 2005-05-19: redundant 'tag'.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tagName"></see></summary>
    let tagName = _prefix "tagName"
    /// <summary>
    /// The object plays the role of the tagger in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedBy"></see></summary>
    let taggedBy = _prefix "taggedBy"
    /// <summary>
    /// The subject Tagging occurred at the subject time and date.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedOn"></see></summary>
    let taggedOn = _prefix "taggedOn"

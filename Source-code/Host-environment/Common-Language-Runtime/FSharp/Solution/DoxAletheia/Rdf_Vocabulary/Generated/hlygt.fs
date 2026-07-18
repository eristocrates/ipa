namespace http.www.holygoat.co.uk.owl.redwood._0._1.tags.slash

open DoxAletheia.Rdf_Vocabulary

module hlygt =
    let _namespace_name = "http://www.holygoat.co.uk/owl/redwood/0.1/tags/"

    /// <summary>
    /// A Tagging which has precisely one associated resource, and one associated tag.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/RestrictedTagging"></see></summary>
    let RestrictedTagging =
        Namespaced_IRI.parse _namespace_name "RestrictedTagging" |> NamespacedName

    /// <summary>
    /// The object is a Tag which plays a role in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/associatedTag"></see></summary>
    let associatedTag =
        Namespaced_IRI.parse _namespace_name "associatedTag" |> NamespacedName

    /// <summary>
    /// The object is a resource which plays a role in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedResource"></see></summary>
    let taggedResource =
        Namespaced_IRI.parse _namespace_name "taggedResource" |> NamespacedName

    /// <summary>
    /// A reified class which defines an instance of a tagging by an agent of a resource with one or more tags.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tagging"></see></summary>
    let Tagging = Namespaced_IRI.parse _namespace_name "Tagging" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/Tag"></see>
    /// </summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName

    /// <summary>
    /// The two tags are asserted to be equivalent --- that is, that whenever one is associated with a resource, the other tag can be logically inferred to also be associated. Be very careful with this. I'm not sure if this should be a subproperty of owl:sameAs.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/equivalentTag"></see></summary>
    let equivalentTag =
        Namespaced_IRI.parse _namespace_name "equivalentTag" |> NamespacedName

    /// <summary>
    /// Indicates that the subject tag applies to the object resource. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/isTagOf"></see></summary>
    let isTagOf = Namespaced_IRI.parse _namespace_name "isTagOf" |> NamespacedName

    /// <summary>
    /// Indicates that the subject has been tagged with the object tag. This does not assert by who, when, or why the tagging occurred. For that information, use a reified Tagging resource.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedWithTag"></see></summary>
    let taggedWithTag =
        Namespaced_IRI.parse _namespace_name "taggedWithTag" |> NamespacedName

    /// <summary>
    /// The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we?
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// The two tags are asserted as being related. This might be symmetric, but it certainly isn't transitive.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/relatedTag"></see></summary>
    let relatedTag = Namespaced_IRI.parse _namespace_name "relatedTag" |> NamespacedName
    /// <summary>
    /// The relationship between a resource and a Tagging. Note, of course, that this allows us to tag tags and taggings themselves...
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    /// The name of a tag. Note that we can't relate this to skos:prefLabel because we cannot guarantee that tags have unique labels in a given conceptual scheme. Or can we? DEPRECATED 2005-05-19: redundant 'tag'.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/tagName"></see></summary>
    let tagName = Namespaced_IRI.parse _namespace_name "tagName" |> NamespacedName
    /// <summary>
    /// The object plays the role of the tagger in the subject Tagging.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedBy"></see></summary>
    let taggedBy = Namespaced_IRI.parse _namespace_name "taggedBy" |> NamespacedName
    /// <summary>
    /// The subject Tagging occurred at the subject time and date.
    /// <see href="http://www.holygoat.co.uk/owl/redwood/0.1/tags/taggedOn"></see></summary>
    let taggedOn = Namespaced_IRI.parse _namespace_name "taggedOn" |> NamespacedName

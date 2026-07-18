namespace http.purl.org.muto.core.hash

open DoxAletheia.Rdf_Vocabulary

module muto =
    let _namespace_name = "http://purl.org/muto/core#"
    /// <summary>
    /// An automatic tag is a tag that is automatically associated with a resource (e.g. by a tagging system), i.e. it is not entered by a human being.
    /// <see href="http://purl.org/muto/core#AutoTag"></see></summary>
    let AutoTag = Namespaced_IRI.parse _namespace_name "AutoTag" |> NamespacedName
    /// <summary>
    /// A Tag consists of an arbitrary text label. Note that tags with the same label are NOT merged in the ontology.
    /// <see href="http://purl.org/muto/core#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName

    /// <summary>
    /// A private tagging is a tagging that is only visible to its creator (unless the creator has not granted access to others via muto:grantAccess). Every tagging that is not an instance of muto:PrivateTagging is public by default.
    /// <see href="http://purl.org/muto/core#PrivateTagging"></see></summary>
    let PrivateTagging =
        Namespaced_IRI.parse _namespace_name "PrivateTagging" |> NamespacedName

    /// <summary>
    /// A tagging links a resource to a user account and one or more tags.
    /// <see href="http://purl.org/muto/core#Tagging"></see></summary>
    let Tagging = Namespaced_IRI.parse _namespace_name "Tagging" |> NamespacedName

    /// <summary>
    /// This subproperty indicates that the meaning of a tag has been automatically defined (e.g. by a tagging system), i.e. it has not been defined by a human being. The default case is disambiguation by users via muto:tagMeaning.
    /// <see href="http://purl.org/muto/core#autoMeaning"></see></summary>
    let autoMeaning =
        Namespaced_IRI.parse _namespace_name "autoMeaning" |> NamespacedName

    /// <summary>
    /// The meaning of a tag can be expressed by a link to a well-defined resource. This can be any resource that clarifies the meaning of the tag (e.g. some DBpedia resource).
    /// <see href="http://purl.org/muto/core#tagMeaning"></see></summary>
    let tagMeaning = Namespaced_IRI.parse _namespace_name "tagMeaning" |> NamespacedName
    /// <summary>
    /// A user account can have a (theoretically unlimited) number of taggings. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.
    /// <see href="http://purl.org/muto/core#creatorOf"></see></summary>
    let creatorOf = Namespaced_IRI.parse _namespace_name "creatorOf" |> NamespacedName
    /// <summary>
    /// Every tagging is linked to at most one user account. This property can be omitted for automatic taggings. In contrast to its superproperty sioc:has_creator, it is functional and with an explicit domain. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.
    /// <see href="http://purl.org/muto/core#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName

    /// <summary>
    /// A (usually private) tagging can be linked to one or more user accounts or user groups that should have access to it (apart from the creator). This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging wants to suggest the tagging to another user).
    /// <see href="http://purl.org/muto/core#grantAccess"></see></summary>
    let grantAccess =
        Namespaced_IRI.parse _namespace_name "grantAccess" |> NamespacedName

    /// <summary>
    /// A user account or user group can have access to a private tagging from another user if the access is explicitly permitted by the creator of the tagging. This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging has suggested the tagging to another user).
    /// <see href="http://purl.org/muto/core#hasAccess"></see></summary>
    let hasAccess = Namespaced_IRI.parse _namespace_name "hasAccess" |> NamespacedName
    /// <summary>
    /// A tagging consists of a (theoretically unlimited) number of tags. A tagging may also consist of no tags, e.g. if the system allows its users to mark a resource first and add tags later.
    /// <see href="http://purl.org/muto/core#hasTag"></see></summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName
    /// <summary>
    /// The number of tags that can be linked to one and the same meaning is theoretically unlimited.
    /// <see href="http://purl.org/muto/core#meaningOf"></see></summary>
    let meaningOf = Namespaced_IRI.parse _namespace_name "meaningOf" |> NamespacedName
    /// <summary>
    /// This property indicates the tag that follows next in the list of tags. It can be used to describe the order in which the tags have been entered by the user.
    /// <see href="http://purl.org/muto/core#nextTag"></see></summary>
    let nextTag = Namespaced_IRI.parse _namespace_name "nextTag" |> NamespacedName

    /// <summary>
    /// This property indicates the tag that is preceding in the list of tags. It can be used to describe the order in which the tags have been entered by the user.
    /// <see href="http://purl.org/muto/core#previousTag"></see></summary>
    let previousTag =
        Namespaced_IRI.parse _namespace_name "previousTag" |> NamespacedName

    /// <summary>
    /// The creation date and time of a tag. This property can be omitted if muto:taggingCreated = muto:tagCreated (i.e. in the common case that a tag has been created along with a tagging, not in a later edit of the tagging). The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).
    /// <see href="http://purl.org/muto/core#tagCreated"></see></summary>
    let tagCreated = Namespaced_IRI.parse _namespace_name "tagCreated" |> NamespacedName
    /// <summary>
    /// Every tag has exactly one label (usually the one given by the user) - otherwise it is not a tag. Additional labels can be defined in the resource that is linked via muto:tagMeaning.
    /// <see href="http://purl.org/muto/core#tagLabel"></see></summary>
    let tagLabel = Namespaced_IRI.parse _namespace_name "tagLabel" |> NamespacedName
    /// <summary>
    /// Every tag is linked to exactly one tagging. This results from the fact that tags with same labels are NOT merged in the ontology.
    /// <see href="http://purl.org/muto/core#tagOf"></see></summary>
    let tagOf = Namespaced_IRI.parse _namespace_name "tagOf" |> NamespacedName

    /// <summary>
    /// Every tagging is linked to exactly one resource. This can be any kind of resource (i.e. all subclasses of rdfs:Resource), including tags and taggings.
    /// <see href="http://purl.org/muto/core#taggedResource"></see></summary>
    let taggedResource =
        Namespaced_IRI.parse _namespace_name "taggedResource" |> NamespacedName

    /// <summary>
    /// A resource can have several taggings from different users. Tags are never directly linked to resources but can be inferred from the taggings.
    /// <see href="http://purl.org/muto/core#taggedWith"></see></summary>
    let taggedWith = Namespaced_IRI.parse _namespace_name "taggedWith" |> NamespacedName

    /// <summary>
    /// Every tagging has exactly one creation date and time. The datatype of this property is xsd:dateTime (in contrast to its superproperty dcterms:created which has range rdfs:Literal).
    /// <see href="http://purl.org/muto/core#taggingCreated"></see></summary>
    let taggingCreated =
        Namespaced_IRI.parse _namespace_name "taggingCreated" |> NamespacedName

    /// <summary>
    /// A tagging can have multiple modification dates, as the number of times a tagging can be edited (e.g. to add or remove tags) is theoretically unlimited. The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).
    /// <see href="http://purl.org/muto/core#taggingModified"></see></summary>
    let taggingModified =
        Namespaced_IRI.parse _namespace_name "taggingModified" |> NamespacedName

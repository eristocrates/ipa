namespace http.moat_project.org.ns.hash

open DoxAletheia.Rdf_Vocabulary

module moat =
    let _namespace_name = "http://moat-project.org/ns#"
    /// <summary>
    /// The link between a Tagging and a meaning (URI) of a tag in a given context (i.e. blog post)
    /// <see href="http://moat-project.org/ns#tagMeaning"></see></summary>
    let tagMeaning = Namespaced_IRI.parse _namespace_name "tagMeaning" |> NamespacedName

    /// <summary>
    ///   <see href="http://moat-project.org/ns#AutomatedTagging"></see>
    /// </summary>
    let AutomatedTagging =
        Namespaced_IRI.parse _namespace_name "AutomatedTagging" |> NamespacedName

    /// <summary>
    ///   <see href="http://moat-project.org/ns#TagType"></see>
    /// </summary>
    let TagType = Namespaced_IRI.parse _namespace_name "TagType" |> NamespacedName
    /// <summary>
    /// A reified object to define a potential meaning for a Tag. The meaning is a unique and explicitely defined Semantic Web resource and is related to the agent that defined it with foaf:maker
    /// <see href="http://moat-project.org/ns#Meaning"></see></summary>
    let Meaning = Namespaced_IRI.parse _namespace_name "Meaning" |> NamespacedName
    /// <summary>
    /// The link between a reified Meaning object and the URI that defines a meaning
    /// <see href="http://moat-project.org/ns#meaningURI"></see></summary>
    let meaningURI = Namespaced_IRI.parse _namespace_name "meaningURI" |> NamespacedName
    /// <summary>
    /// A Tag URI, that provides an unique identifier for a label attached to a resource
    /// <see href="http://moat-project.org/ns#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName

    /// <summary>
    ///   <see href="http://moat-project.org/ns#ValidatedTagging"></see>
    /// </summary>
    let ValidatedTagging =
        Namespaced_IRI.parse _namespace_name "ValidatedTagging" |> NamespacedName

    /// <summary>
    /// The link between a Tag and a Meaning object in a global context
    /// <see href="http://moat-project.org/ns#hasMeaning"></see></summary>
    let hasMeaning = Namespaced_IRI.parse _namespace_name "hasMeaning" |> NamespacedName

    /// <summary>
    /// The URI used as a meaning for a local meaning of a Tag with MOAT
    /// <see href="http://moat-project.org/ns#localMeaning"></see></summary>
    let localMeaning =
        Namespaced_IRI.parse _namespace_name "localMeaning" |> NamespacedName

    /// <summary>
    /// The type of the tagging, i.e. automatic or has been validated
    /// <see href="http://moat-project.org/ns#tagType"></see></summary>
    let tagType = Namespaced_IRI.parse _namespace_name "tagType" |> NamespacedName
    /// <summary>
    /// The URI ised to 'tag' an item with MOAT
    /// <see href="http://moat-project.org/ns#taggedWith"></see></summary>
    let taggedWith = Namespaced_IRI.parse _namespace_name "taggedWith" |> NamespacedName

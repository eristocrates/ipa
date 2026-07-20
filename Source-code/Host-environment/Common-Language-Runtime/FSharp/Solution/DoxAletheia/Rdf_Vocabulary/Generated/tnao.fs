namespace http.tracker.api.gnome.org.ontology.v3.nao.hash

open DoxAletheia

module tnao =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nao#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents a generic tag
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#deprecated"></see></summary>
    let deprecated = _prefix "deprecated"
    /// <summary>
    /// In the context of the social semantic desktop the textual annotation provided via rdfs:comment is meant for technical users, the textual annotation here is aimed at average users and is meant to be used to define custom descriptions of resources on the desktop
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Defines an existing tag for a resource
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#hasTag"></see></summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    /// Defines a generic identifier for a resource
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// This property defines a symmetric relation between any two resources. In order for this property to be used legally, the relationship must be symmetric.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#isRelated"></see></summary>
    let isRelated = _prefix "isRelated"
    /// <summary>
    /// last modification date
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#numericRating"></see></summary>
    let numericRating = _prefix "numericRating"
    /// <summary>
    /// A preferred label for a resource
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nao#prefLabel"></see></summary>
    let prefLabel = _prefix "prefLabel"

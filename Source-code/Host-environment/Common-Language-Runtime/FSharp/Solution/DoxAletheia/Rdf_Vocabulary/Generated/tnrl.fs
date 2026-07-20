namespace http.tracker.api.gnome.org.ontology.v3.nrl.hash

open DoxAletheia

module tnrl =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nrl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// last modification date. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// Specifies a namespace. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#Namespace"></see></summary>
    let Namespace = _prefix "Namespace"
    /// <summary>
    /// An ontology
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// A marker class to identify inverse functional properties
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"
    /// <summary>
    /// Time of insertion of the resource. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#added"></see></summary>
    let added = _prefix "added"
    /// <summary>
    /// Whether a property has an index. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#indexed"></see></summary>
    let indexed = _prefix "indexed"
    /// <summary>
    /// Specifies a maximum value cardinality for a specific property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#maxCardinality"></see></summary>
    let maxCardinality = _prefix "maxCardinality"
    /// <summary>
    /// Link to upstream specification for an ontology class. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#classSpecification"></see></summary>
    let classSpecification = _prefix "classSpecification"
    /// <summary>
    /// If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice. This property is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#deprecated"></see></summary>
    let deprecated = _prefix "deprecated"
    /// <summary>
    /// Property is a domain index for the subject class. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#domainIndex"></see></summary>
    let domainIndex = _prefix "domainIndex"
    /// <summary>
    /// Whether the property is full-text indexed. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#fulltextIndexed"></see></summary>
    let fulltextIndexed = _prefix "fulltextIndexed"
    /// <summary>
    /// Modification sequence number. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// Whether resources of this class emits notifications on changes. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#notify"></see></summary>
    let notify = _prefix "notify"
    /// <summary>
    /// Link to upstream specification for an ontology property. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#propertySpecification"></see></summary>
    let propertySpecification = _prefix "propertySpecification"
    /// <summary>
    /// Whether subject and object properties share an index. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#secondaryIndex"></see></summary>
    let secondaryIndex = _prefix "secondaryIndex"
    /// <summary>
    /// Property weight on full-text search relevance. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#weight"></see></summary>
    let weight = _prefix "weight"

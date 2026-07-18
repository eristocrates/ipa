namespace http.tracker.api.gnome.org.ontology.v3.nrl.hash

open DoxAletheia.Rdf_Vocabulary

module tnrl =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/nrl#"

    /// <summary>
    /// last modification date. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#lastModified"></see></summary>
    let lastModified =
        Namespaced_IRI.parse _namespace_name "lastModified" |> NamespacedName

    /// <summary>
    /// This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#prefix"></see></summary>
    let prefix = Namespaced_IRI.parse _namespace_name "prefix" |> NamespacedName
    /// <summary>
    /// Specifies a namespace. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#Namespace"></see></summary>
    let Namespace = Namespaced_IRI.parse _namespace_name "Namespace" |> NamespacedName
    /// <summary>
    /// An ontology
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// A marker class to identify inverse functional properties
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty =
        Namespaced_IRI.parse _namespace_name "InverseFunctionalProperty" |> NamespacedName

    /// <summary>
    /// Time of insertion of the resource. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#added"></see></summary>
    let added = Namespaced_IRI.parse _namespace_name "added" |> NamespacedName
    /// <summary>
    /// Whether a property has an index. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#indexed"></see></summary>
    let indexed = Namespaced_IRI.parse _namespace_name "indexed" |> NamespacedName

    /// <summary>
    /// Specifies a maximum value cardinality for a specific property
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#maxCardinality"></see></summary>
    let maxCardinality =
        Namespaced_IRI.parse _namespace_name "maxCardinality" |> NamespacedName

    /// <summary>
    /// Link to upstream specification for an ontology class. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#classSpecification"></see></summary>
    let classSpecification =
        Namespaced_IRI.parse _namespace_name "classSpecification" |> NamespacedName

    /// <summary>
    /// If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice. This property is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#deprecated"></see></summary>
    let deprecated = Namespaced_IRI.parse _namespace_name "deprecated" |> NamespacedName

    /// <summary>
    /// Property is a domain index for the subject class. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#domainIndex"></see></summary>
    let domainIndex =
        Namespaced_IRI.parse _namespace_name "domainIndex" |> NamespacedName

    /// <summary>
    /// Whether the property is full-text indexed. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#fulltextIndexed"></see></summary>
    let fulltextIndexed =
        Namespaced_IRI.parse _namespace_name "fulltextIndexed" |> NamespacedName

    /// <summary>
    /// Modification sequence number. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    /// Whether resources of this class emits notifications on changes. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#notify"></see></summary>
    let notify = Namespaced_IRI.parse _namespace_name "notify" |> NamespacedName

    /// <summary>
    /// Link to upstream specification for an ontology property. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#propertySpecification"></see></summary>
    let propertySpecification =
        Namespaced_IRI.parse _namespace_name "propertySpecification" |> NamespacedName

    /// <summary>
    /// Whether subject and object properties share an index. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#secondaryIndex"></see></summary>
    let secondaryIndex =
        Namespaced_IRI.parse _namespace_name "secondaryIndex" |> NamespacedName

    /// <summary>
    /// Property weight on full-text search relevance. This is a Tracker extension
    /// <see href="http://tracker.api.gnome.org/ontology/v3/nrl#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName

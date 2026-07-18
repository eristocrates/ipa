namespace http.rdfs.org.scot.ns.hash

open DoxAletheia.Rdf_Vocabulary

module scot =
    let _namespace_name = "http://rdfs.org/scot/ns#"

    /// <summary>
    /// More than two tags are assigned to one resource. This class defines cooccurring tags and the cooccurring frequency between the tags
    /// <see href="http://rdfs.org/scot/ns#Cooccurrence"></see></summary>
    let Cooccurrence =
        Namespaced_IRI.parse _namespace_name "Cooccurrence" |> NamespacedName

    /// <summary>
    /// Tagcloud consists of metadata related to tagging activities connecting to the basic components such as users, tags, resources.
    /// <see href="http://rdfs.org/scot/ns#Tagcloud"></see></summary>
    let Tagcloud = Namespaced_IRI.parse _namespace_name "Tagcloud" |> NamespacedName
    /// <summary>
    /// A free-text keyword which is used to annotate a resource
    /// <see href="http://rdfs.org/scot/ns#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// An abbreviation formed by the first letters of the compound word.
    /// <see href="http://rdfs.org/scot/ns#acronym"></see></summary>
    let acronym = Namespaced_IRI.parse _namespace_name "acronym" |> NamespacedName

    /// <summary>
    /// A variation in the way in which a word is spelled.
    /// <see href="http://rdfs.org/scot/ns#spelling_variant"></see></summary>
    let spelling_variant =
        Namespaced_IRI.parse _namespace_name "spelling_variant" |> NamespacedName

    /// <summary>
    /// A tag in tags:Tagging is collected to scot:Tag.
    /// <see href="http://rdfs.org/scot/ns#aggregated_tag"></see></summary>
    let aggregated_tag =
        Namespaced_IRI.parse _namespace_name "aggregated_tag" |> NamespacedName

    /// <summary>
    /// An agent who makes a synonym relationship between the tags.
    /// <see href="http://rdfs.org/scot/ns#associated_by"></see></summary>
    let associated_by =
        Namespaced_IRI.parse _namespace_name "associated_by" |> NamespacedName

    /// <summary>
    /// A SCOT Tagcloud that is part of this Tagcloud(especially one Tagcloud in a group SCOT Tagcloud).
    /// <see href="http://rdfs.org/scot/ns#composed_of"></see></summary>
    let composed_of =
        Namespaced_IRI.parse _namespace_name "composed_of" |> NamespacedName

    /// <summary>
    /// An aggregated tag is contained in a tagcloud.
    /// <see href="http://rdfs.org/scot/ns#contained_in"></see></summary>
    let contained_in =
        Namespaced_IRI.parse _namespace_name "contained_in" |> NamespacedName

    /// <summary>
    /// The relationship between a tagcloud and a tag. The object is a tag which is aggregated from a tagging instance.
    /// <see href="http://rdfs.org/scot/ns#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// An absolute frequency of a particular cooccurring set of tags.
    /// <see href="http://rdfs.org/scot/ns#cooccur_afrequency"></see></summary>
    let cooccur_afrequency =
        Namespaced_IRI.parse _namespace_name "cooccur_afrequency" |> NamespacedName

    /// <summary>
    /// A percentage frequency of cooccurring set of tags relative to the sum of frequencies of cooccurrence.
    /// <see href="http://rdfs.org/scot/ns#cooccur_rfrequency"></see></summary>
    let cooccur_rfrequency =
        Namespaced_IRI.parse _namespace_name "cooccur_rfrequency" |> NamespacedName

    /// <summary>
    /// This property is used to represent relations among two or more tags.
    /// <see href="http://rdfs.org/scot/ns#cooccurs_in"></see></summary>
    let cooccurs_in =
        Namespaced_IRI.parse _namespace_name "cooccurs_in" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdfs.org/scot/ns#cooccured_with"></see>
    /// </summary>
    let cooccured_with =
        Namespaced_IRI.parse _namespace_name "cooccured_with" |> NamespacedName

    /// <summary>
    /// This property is used to represent relations among two or more tags.
    /// <see href="http://rdfs.org/scot/ns#cooccurs_with"></see></summary>
    let cooccurs_with =
        Namespaced_IRI.parse _namespace_name "cooccurs_with" |> NamespacedName

    /// <summary>
    /// Indicates that an agent as type of a foaf:Agent, who generates a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#created_by"></see></summary>
    let created_by = Namespaced_IRI.parse _namespace_name "created_by" |> NamespacedName
    /// <summary>
    /// A type of phrase in which each word is separated by a certain character.
    /// <see href="http://rdfs.org/scot/ns#delimited"></see></summary>
    let delimited = Namespaced_IRI.parse _namespace_name "delimited" |> NamespacedName
    /// <summary>
    /// An item has one and more tags.
    /// <see href="http://rdfs.org/scot/ns#has_tag"></see></summary>
    let has_tag = Namespaced_IRI.parse _namespace_name "has_tag" |> NamespacedName
    /// <summary>
    /// Indicates that a tag is assigned to the sioc:Item.
    /// <see href="http://rdfs.org/scot/ns#tag_of"></see></summary>
    let tag_of = Namespaced_IRI.parse _namespace_name "tag_of" |> NamespacedName

    /// <summary>
    /// The Usergroup that this Tagcloud is associated with.
    /// <see href="http://rdfs.org/scot/ns#has_usergroup"></see></summary>
    let has_usergroup =
        Namespaced_IRI.parse _namespace_name "has_usergroup" |> NamespacedName

    /// <summary>
    /// A type of phrase in which each word is separated by a hyphen.
    /// <see href="http://rdfs.org/scot/ns#hypenated"></see></summary>
    let hypenated = Namespaced_IRI.parse _namespace_name "hypenated" |> NamespacedName
    /// <summary>
    /// A last date on which a particular tag is used .
    /// <see href="http://rdfs.org/scot/ns#last_used"></see></summary>
    let last_used = Namespaced_IRI.parse _namespace_name "last_used" |> NamespacedName

    /// <summary>
    /// An absolute frequency of a particular tag in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#own_afrequency"></see></summary>
    let own_afrequency =
        Namespaced_IRI.parse _namespace_name "own_afrequency" |> NamespacedName

    /// <summary>
    /// A percentage frequency of a tag for a particular Tagcloud relative to the total of all Tag frequencies in that Tagcloud..
    /// <see href="http://rdfs.org/scot/ns#own_rfrequency"></see></summary>
    let own_rfrequency =
        Namespaced_IRI.parse _namespace_name "own_rfrequency" |> NamespacedName

    /// <summary>
    /// Refers to more than one thing.
    /// <see href="http://rdfs.org/scot/ns#plural"></see></summary>
    let plural = Namespaced_IRI.parse _namespace_name "plural" |> NamespacedName
    /// <summary>
    /// Refers to one thing.
    /// <see href="http://rdfs.org/scot/ns#singular"></see></summary>
    let singular = Namespaced_IRI.parse _namespace_name "singular" |> NamespacedName
    /// <summary>
    /// A type of phrase in which each word is separated by a slash.
    /// <see href="http://rdfs.org/scot/ns#slashed"></see></summary>
    let slashed = Namespaced_IRI.parse _namespace_name "slashed" |> NamespacedName
    /// <summary>
    /// A type of phrase in which each piece of word is separated by a space.
    /// <see href="http://rdfs.org/scot/ns#spaced"></see></summary>
    let spaced = Namespaced_IRI.parse _namespace_name "spaced" |> NamespacedName
    /// <summary>
    /// Word which means the same as another word.
    /// <see href="http://rdfs.org/scot/ns#synonym"></see></summary>
    let synonym = Namespaced_IRI.parse _namespace_name "synonym" |> NamespacedName

    /// <summary>
    /// The relationship between an agent and an account held by this agent.
    /// <see href="http://rdfs.org/scot/ns#tagging_account"></see></summary>
    let tagging_account =
        Namespaced_IRI.parse _namespace_name "tagging_account" |> NamespacedName

    /// <summary>
    /// The relationship between a tagcloud and a tagging. Note that a tagcloud allows us to contain one or more tagging instances.
    /// <see href="http://rdfs.org/scot/ns#tagging_activity"></see></summary>
    let tagging_activity =
        Namespaced_IRI.parse _namespace_name "tagging_activity" |> NamespacedName

    /// <summary>
    /// The environment where the tagging happens.
    /// <see href="http://rdfs.org/scot/ns#tagspace"></see></summary>
    let tagspace = Namespaced_IRI.parse _namespace_name "tagspace" |> NamespacedName

    /// <summary>
    /// A number of total frequency for all cooccurring tag sets in a Tagcloud
    /// <see href="http://rdfs.org/scot/ns#total_cooccur_frequency"></see></summary>
    let total_cooccur_frequency =
        Namespaced_IRI.parse _namespace_name "total_cooccur_frequency" |> NamespacedName

    /// <summary>
    /// The total number of cooccuring tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_cooccur_tags"></see></summary>
    let total_cooccur_tags =
        Namespaced_IRI.parse _namespace_name "total_cooccur_tags" |> NamespacedName

    /// <summary>
    /// A number of posted items with an associated Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_items"></see></summary>
    let total_items =
        Namespaced_IRI.parse _namespace_name "total_items" |> NamespacedName

    /// <summary>
    /// A number of total frequency for all Tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_tag_frequency"></see></summary>
    let total_tag_frequency =
        Namespaced_IRI.parse _namespace_name "total_tag_frequency" |> NamespacedName

    /// <summary>
    /// The total number of Tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_tags"></see></summary>
    let total_tags = Namespaced_IRI.parse _namespace_name "total_tags" |> NamespacedName

    /// <summary>
    /// A type of pharse in which each word is separated by an underscore.
    /// <see href="http://rdfs.org/scot/ns#underscored"></see></summary>
    let underscored =
        Namespaced_IRI.parse _namespace_name "underscored" |> NamespacedName

    /// <summary>
    /// Date on which a Tagcloud is updated.
    /// <see href="http://rdfs.org/scot/ns#updated"></see></summary>
    let updated = Namespaced_IRI.parse _namespace_name "updated" |> NamespacedName
    /// <summary>
    /// Refers to the sioc:User who uses or creates a tag.
    /// <see href="http://rdfs.org/scot/ns#used_by"></see></summary>
    let used_by = Namespaced_IRI.parse _namespace_name "used_by" |> NamespacedName

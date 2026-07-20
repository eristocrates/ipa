namespace http.rdfs.org.scot.ns.hash

open DoxAletheia

module scot =
    let _namespace_name = "http://rdfs.org/scot/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// More than two tags are assigned to one resource. This class defines cooccurring tags and the cooccurring frequency between the tags
    /// <see href="http://rdfs.org/scot/ns#Cooccurrence"></see></summary>
    let Cooccurrence = _prefix "Cooccurrence"
    /// <summary>
    /// Tagcloud consists of metadata related to tagging activities connecting to the basic components such as users, tags, resources.
    /// <see href="http://rdfs.org/scot/ns#Tagcloud"></see></summary>
    let Tagcloud = _prefix "Tagcloud"
    /// <summary>
    /// A free-text keyword which is used to annotate a resource
    /// <see href="http://rdfs.org/scot/ns#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// An abbreviation formed by the first letters of the compound word.
    /// <see href="http://rdfs.org/scot/ns#acronym"></see></summary>
    let acronym = _prefix "acronym"
    /// <summary>
    /// A variation in the way in which a word is spelled.
    /// <see href="http://rdfs.org/scot/ns#spelling_variant"></see></summary>
    let spelling_variant = _prefix "spelling_variant"
    /// <summary>
    /// A tag in tags:Tagging is collected to scot:Tag.
    /// <see href="http://rdfs.org/scot/ns#aggregated_tag"></see></summary>
    let aggregated_tag = _prefix "aggregated_tag"
    /// <summary>
    /// An agent who makes a synonym relationship between the tags.
    /// <see href="http://rdfs.org/scot/ns#associated_by"></see></summary>
    let associated_by = _prefix "associated_by"
    /// <summary>
    /// A SCOT Tagcloud that is part of this Tagcloud(especially one Tagcloud in a group SCOT Tagcloud).
    /// <see href="http://rdfs.org/scot/ns#composed_of"></see></summary>
    let composed_of = _prefix "composed_of"
    /// <summary>
    /// An aggregated tag is contained in a tagcloud.
    /// <see href="http://rdfs.org/scot/ns#contained_in"></see></summary>
    let contained_in = _prefix "contained_in"
    /// <summary>
    /// The relationship between a tagcloud and a tag. The object is a tag which is aggregated from a tagging instance.
    /// <see href="http://rdfs.org/scot/ns#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// An absolute frequency of a particular cooccurring set of tags.
    /// <see href="http://rdfs.org/scot/ns#cooccur_afrequency"></see></summary>
    let cooccur_afrequency = _prefix "cooccur_afrequency"
    /// <summary>
    /// A percentage frequency of cooccurring set of tags relative to the sum of frequencies of cooccurrence.
    /// <see href="http://rdfs.org/scot/ns#cooccur_rfrequency"></see></summary>
    let cooccur_rfrequency = _prefix "cooccur_rfrequency"
    /// <summary>
    /// This property is used to represent relations among two or more tags.
    /// <see href="http://rdfs.org/scot/ns#cooccurs_in"></see></summary>
    let cooccurs_in = _prefix "cooccurs_in"
    /// <summary>
    ///   <see href="http://rdfs.org/scot/ns#cooccured_with"></see>
    /// </summary>
    let cooccured_with = _prefix "cooccured_with"
    /// <summary>
    /// This property is used to represent relations among two or more tags.
    /// <see href="http://rdfs.org/scot/ns#cooccurs_with"></see></summary>
    let cooccurs_with = _prefix "cooccurs_with"
    /// <summary>
    /// Indicates that an agent as type of a foaf:Agent, who generates a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#created_by"></see></summary>
    let created_by = _prefix "created_by"
    /// <summary>
    /// A type of phrase in which each word is separated by a certain character.
    /// <see href="http://rdfs.org/scot/ns#delimited"></see></summary>
    let delimited = _prefix "delimited"
    /// <summary>
    /// An item has one and more tags.
    /// <see href="http://rdfs.org/scot/ns#has_tag"></see></summary>
    let has_tag = _prefix "has_tag"
    /// <summary>
    /// Indicates that a tag is assigned to the sioc:Item.
    /// <see href="http://rdfs.org/scot/ns#tag_of"></see></summary>
    let tag_of = _prefix "tag_of"
    /// <summary>
    /// The Usergroup that this Tagcloud is associated with.
    /// <see href="http://rdfs.org/scot/ns#has_usergroup"></see></summary>
    let has_usergroup = _prefix "has_usergroup"
    /// <summary>
    /// A type of phrase in which each word is separated by a hyphen.
    /// <see href="http://rdfs.org/scot/ns#hypenated"></see></summary>
    let hypenated = _prefix "hypenated"
    /// <summary>
    /// A last date on which a particular tag is used .
    /// <see href="http://rdfs.org/scot/ns#last_used"></see></summary>
    let last_used = _prefix "last_used"
    /// <summary>
    /// An absolute frequency of a particular tag in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#own_afrequency"></see></summary>
    let own_afrequency = _prefix "own_afrequency"
    /// <summary>
    /// A percentage frequency of a tag for a particular Tagcloud relative to the total of all Tag frequencies in that Tagcloud..
    /// <see href="http://rdfs.org/scot/ns#own_rfrequency"></see></summary>
    let own_rfrequency = _prefix "own_rfrequency"
    /// <summary>
    /// Refers to more than one thing.
    /// <see href="http://rdfs.org/scot/ns#plural"></see></summary>
    let plural = _prefix "plural"
    /// <summary>
    /// Refers to one thing.
    /// <see href="http://rdfs.org/scot/ns#singular"></see></summary>
    let singular = _prefix "singular"
    /// <summary>
    /// A type of phrase in which each word is separated by a slash.
    /// <see href="http://rdfs.org/scot/ns#slashed"></see></summary>
    let slashed = _prefix "slashed"
    /// <summary>
    /// A type of phrase in which each piece of word is separated by a space.
    /// <see href="http://rdfs.org/scot/ns#spaced"></see></summary>
    let spaced = _prefix "spaced"
    /// <summary>
    /// Word which means the same as another word.
    /// <see href="http://rdfs.org/scot/ns#synonym"></see></summary>
    let synonym = _prefix "synonym"
    /// <summary>
    /// The relationship between an agent and an account held by this agent.
    /// <see href="http://rdfs.org/scot/ns#tagging_account"></see></summary>
    let tagging_account = _prefix "tagging_account"
    /// <summary>
    /// The relationship between a tagcloud and a tagging. Note that a tagcloud allows us to contain one or more tagging instances.
    /// <see href="http://rdfs.org/scot/ns#tagging_activity"></see></summary>
    let tagging_activity = _prefix "tagging_activity"
    /// <summary>
    /// The environment where the tagging happens.
    /// <see href="http://rdfs.org/scot/ns#tagspace"></see></summary>
    let tagspace = _prefix "tagspace"
    /// <summary>
    /// A number of total frequency for all cooccurring tag sets in a Tagcloud
    /// <see href="http://rdfs.org/scot/ns#total_cooccur_frequency"></see></summary>
    let total_cooccur_frequency = _prefix "total_cooccur_frequency"
    /// <summary>
    /// The total number of cooccuring tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_cooccur_tags"></see></summary>
    let total_cooccur_tags = _prefix "total_cooccur_tags"
    /// <summary>
    /// A number of posted items with an associated Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_items"></see></summary>
    let total_items = _prefix "total_items"
    /// <summary>
    /// A number of total frequency for all Tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_tag_frequency"></see></summary>
    let total_tag_frequency = _prefix "total_tag_frequency"
    /// <summary>
    /// The total number of Tags in a Tagcloud.
    /// <see href="http://rdfs.org/scot/ns#total_tags"></see></summary>
    let total_tags = _prefix "total_tags"
    /// <summary>
    /// A type of pharse in which each word is separated by an underscore.
    /// <see href="http://rdfs.org/scot/ns#underscored"></see></summary>
    let underscored = _prefix "underscored"
    /// <summary>
    /// Date on which a Tagcloud is updated.
    /// <see href="http://rdfs.org/scot/ns#updated"></see></summary>
    let updated = _prefix "updated"
    /// <summary>
    /// Refers to the sioc:User who uses or creates a tag.
    /// <see href="http://rdfs.org/scot/ns#used_by"></see></summary>
    let used_by = _prefix "used_by"

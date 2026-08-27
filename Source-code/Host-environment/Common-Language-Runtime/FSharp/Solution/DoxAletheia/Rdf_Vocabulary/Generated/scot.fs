namespace http.rdfs.org.scot.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module scot =
    let _namespace_iri = Namespace_Iri scot |> NamespaceIRI
    /// <summary>
    ///   <para>scot:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://rdfs.org/scot/ns#">http://rdfs.org/scot/ns#</seealso>
    let _prefix_iri = Prefixed_Name(scot, "") |> PrefixedName
    /// <summary>
    ///   <para>scot:Cooccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"More than two tags are assigned to one resource. This class defines cooccurring tags and the cooccurring frequency between the tags"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cooccurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#Cooccurrence">http://rdfs.org/scot/ns#Cooccurrence</seealso>
    let Cooccurrence = Prefixed_Name(scot, "Cooccurrence") |> PrefixedName
    /// <summary>
    ///   <para>scot:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A free-text keyword which is used to annotate a resource "</para>
    /// labels<para>"Tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#Tag">http://rdfs.org/scot/ns#Tag</seealso>
    let Tag = Prefixed_Name(scot, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>scot:Tagcloud</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Tagcloud consists of metadata related to tagging activities connecting to the basic components such as users, tags, resources. "</para>
    /// labels<para>"Tagcloud"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#Tagcloud">http://rdfs.org/scot/ns#Tagcloud</seealso>
    let Tagcloud = Prefixed_Name(scot, "Tagcloud") |> PrefixedName
    /// <summary>
    ///   <para>scot:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An abbreviation formed by the first letters of the compound word."</para>
    /// labels<para>"acronym"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#acronym">http://rdfs.org/scot/ns#acronym</seealso>
    let acronym = Prefixed_Name(scot, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>scot:aggregated_tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A tag in tags:Tagging is collected to scot:Tag."</para>
    /// labels<para>"aggregated tag"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#aggregated_tag">http://rdfs.org/scot/ns#aggregated_tag</seealso>
    let aggregated_tag = Prefixed_Name(scot, "aggregated_tag") |> PrefixedName
    /// <summary>
    ///   <para>scot:associated_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An agent who makes a synonym relationship between the tags."</para>
    /// labels<para>"associated by"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#associated_by">http://rdfs.org/scot/ns#associated_by</seealso>
    let associated_by = Prefixed_Name(scot, "associated_by") |> PrefixedName
    /// <summary>
    ///   <para>scot:composed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A SCOT Tagcloud that is part of this Tagcloud(especially one Tagcloud in a group SCOT Tagcloud)."</para>
    /// labels<para>"composed of"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#composed_of">http://rdfs.org/scot/ns#composed_of</seealso>
    let composed_of = Prefixed_Name(scot, "composed_of") |> PrefixedName
    /// <summary>
    ///   <para>scot:contained_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An aggregated tag is contained in a tagcloud."</para>
    /// labels<para>"contained in"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#contained_in">http://rdfs.org/scot/ns#contained_in</seealso>
    let contained_in = Prefixed_Name(scot, "contained_in") |> PrefixedName
    /// <summary>
    ///   <para>scot:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between a tagcloud and a tag. The object is a tag which is aggregated from a tagging instance."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#contains">http://rdfs.org/scot/ns#contains</seealso>
    let contains = Prefixed_Name(scot, "contains") |> PrefixedName
    /// <summary>
    ///   <para>scot:cooccur_afrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An absolute frequency of a particular cooccurring set of tags."</para>
    /// labels<para>"cooccur absolute frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#cooccur_afrequency">http://rdfs.org/scot/ns#cooccur_afrequency</seealso>
    let cooccur_afrequency = Prefixed_Name(scot, "cooccur_afrequency") |> PrefixedName
    /// <summary>
    ///   <para>scot:cooccur_rfrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A percentage frequency of cooccurring set of tags relative to the sum of frequencies of cooccurrence."</para>
    /// labels<para>"cooccur absolute frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#cooccur_rfrequency">http://rdfs.org/scot/ns#cooccur_rfrequency</seealso>
    let cooccur_rfrequency = Prefixed_Name(scot, "cooccur_rfrequency") |> PrefixedName
    /// <summary>
    ///   <para>scot:cooccured_with</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#cooccured_with">http://rdfs.org/scot/ns#cooccured_with</seealso>
    let cooccured_with = Prefixed_Name(scot, "cooccured_with") |> PrefixedName
    /// <summary>
    ///   <para>scot:cooccurs_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"This property is used to represent relations among two or more tags."</para>
    /// labels<para>"cooccurs in"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#cooccurs_in">http://rdfs.org/scot/ns#cooccurs_in</seealso>
    let cooccurs_in = Prefixed_Name(scot, "cooccurs_in") |> PrefixedName
    /// <summary>
    ///   <para>scot:cooccurs_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to represent relations among two or more tags."</para>
    /// labels<para>"cooccurs with"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#cooccurs_with">http://rdfs.org/scot/ns#cooccurs_with</seealso>
    let cooccurs_with = Prefixed_Name(scot, "cooccurs_with") |> PrefixedName
    /// <summary>
    ///   <para>scot:created_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that an agent as type of a foaf:Agent, who generates a Tagcloud."</para>
    /// labels<para>"created by"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#created_by">http://rdfs.org/scot/ns#created_by</seealso>
    let created_by = Prefixed_Name(scot, "created_by") |> PrefixedName
    /// <summary>
    ///   <para>scot:delimited</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A type of phrase in which each word is separated by a certain character."</para>
    /// labels<para>"delimited"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#delimited">http://rdfs.org/scot/ns#delimited</seealso>
    let delimited = Prefixed_Name(scot, "delimited") |> PrefixedName
    /// <summary>
    ///   <para>scot:has_tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An item has one and more tags."</para>
    /// labels<para>"has tag"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#has_tag">http://rdfs.org/scot/ns#has_tag</seealso>
    let has_tag = Prefixed_Name(scot, "has_tag") |> PrefixedName
    /// <summary>
    ///   <para>scot:has_usergroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The Usergroup that this Tagcloud is associated with."</para>
    /// labels<para>"has usergroup"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#has_usergroup">http://rdfs.org/scot/ns#has_usergroup</seealso>
    let has_usergroup = Prefixed_Name(scot, "has_usergroup") |> PrefixedName
    /// <summary>
    ///   <para>scot:hypenated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of phrase in which each word is separated by a hyphen."</para>
    /// labels<para>"hypenated"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#hypenated">http://rdfs.org/scot/ns#hypenated</seealso>
    let hypenated = Prefixed_Name(scot, "hypenated") |> PrefixedName
    /// <summary>
    ///   <para>scot:last_used</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A last date on which a particular tag is used ."</para>
    /// labels<para>"last used"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#last_used">http://rdfs.org/scot/ns#last_used</seealso>
    let last_used = Prefixed_Name(scot, "last_used") |> PrefixedName
    /// <summary>
    ///   <para>scot:own_afrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"An absolute frequency of a particular tag in a Tagcloud."</para>
    /// labels<para>"own absolute frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#own_afrequency">http://rdfs.org/scot/ns#own_afrequency</seealso>
    let own_afrequency = Prefixed_Name(scot, "own_afrequency") |> PrefixedName
    /// <summary>
    ///   <para>scot:own_rfrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A percentage frequency of a tag for a particular Tagcloud relative to the total of all Tag frequencies in that Tagcloud.."</para>
    /// labels<para>"own relative frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#own_rfrequency">http://rdfs.org/scot/ns#own_rfrequency</seealso>
    let own_rfrequency = Prefixed_Name(scot, "own_rfrequency") |> PrefixedName
    /// <summary>
    ///   <para>scot:plural</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to more than one thing."</para>
    /// labels<para>"plural"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#plural">http://rdfs.org/scot/ns#plural</seealso>
    let plural = Prefixed_Name(scot, "plural") |> PrefixedName
    /// <summary>
    ///   <para>scot:singular</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to one thing."</para>
    /// labels<para>"singular"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#singular">http://rdfs.org/scot/ns#singular</seealso>
    let singular = Prefixed_Name(scot, "singular") |> PrefixedName
    /// <summary>
    ///   <para>scot:slashed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A type of phrase in which each word is separated by a slash."</para>
    /// labels<para>"slashed"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#slashed">http://rdfs.org/scot/ns#slashed</seealso>
    let slashed = Prefixed_Name(scot, "slashed") |> PrefixedName
    /// <summary>
    ///   <para>scot:spaced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A type of phrase in which each piece of word is separated by a space."</para>
    /// labels<para>"spaced"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#spaced">http://rdfs.org/scot/ns#spaced</seealso>
    let spaced = Prefixed_Name(scot, "spaced") |> PrefixedName
    /// <summary>
    ///   <para>scot:spelling_variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A variation in the way in which a word is spelled."</para>
    /// labels<para>"spelling variant"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#spelling_variant">http://rdfs.org/scot/ns#spelling_variant</seealso>
    let spelling_variant = Prefixed_Name(scot, "spelling_variant") |> PrefixedName
    /// <summary>
    ///   <para>scot:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Word which means the same as another word."</para>
    /// labels<para>"synonym"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#synonym">http://rdfs.org/scot/ns#synonym</seealso>
    let synonym = Prefixed_Name(scot, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>scot:tag_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Indicates that a tag is assigned to the sioc:Item."</para>
    /// labels<para>"tag of"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#tag_of">http://rdfs.org/scot/ns#tag_of</seealso>
    let tag_of = Prefixed_Name(scot, "tag_of") |> PrefixedName
    /// <summary>
    ///   <para>scot:tagging_account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The relationship between an agent and an account held by this agent."</para>
    /// labels<para>"tagging account"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#tagging_account">http://rdfs.org/scot/ns#tagging_account</seealso>
    let tagging_account = Prefixed_Name(scot, "tagging_account") |> PrefixedName
    /// <summary>
    ///   <para>scot:tagging_activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relationship between a tagcloud and a tagging. Note that a tagcloud allows us to contain one or more tagging instances."</para>
    /// labels<para>"tagging activity"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#tagging_activity">http://rdfs.org/scot/ns#tagging_activity</seealso>
    let tagging_activity = Prefixed_Name(scot, "tagging_activity") |> PrefixedName
    /// <summary>
    ///   <para>scot:tagspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The environment where the tagging happens."</para>
    /// labels<para>"tag space"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#tagspace">http://rdfs.org/scot/ns#tagspace</seealso>
    let tagspace = Prefixed_Name(scot, "tagspace") |> PrefixedName

    /// <summary>
    ///   <para>scot:total_cooccur_frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A number of total frequency for all cooccurring tag sets in a Tagcloud"</para>
    /// labels<para>"total cooccur frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#total_cooccur_frequency">http://rdfs.org/scot/ns#total_cooccur_frequency</seealso>
    let total_cooccur_frequency =
        Prefixed_Name(scot, "total_cooccur_frequency") |> PrefixedName

    /// <summary>
    ///   <para>scot:total_cooccur_tags</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The total number of cooccuring tags in a Tagcloud."</para>
    /// labels<para>"total cooccur tags"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#total_cooccur_tags">http://rdfs.org/scot/ns#total_cooccur_tags</seealso>
    let total_cooccur_tags = Prefixed_Name(scot, "total_cooccur_tags") |> PrefixedName
    /// <summary>
    ///   <para>scot:total_items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A number of posted items with an associated Tagcloud."</para>
    /// labels<para>"total items"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#total_items">http://rdfs.org/scot/ns#total_items</seealso>
    let total_items = Prefixed_Name(scot, "total_items") |> PrefixedName
    /// <summary>
    ///   <para>scot:total_tag_frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A number of total frequency for all Tags in a Tagcloud."</para>
    /// labels<para>"total tag frequency"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#total_tag_frequency">http://rdfs.org/scot/ns#total_tag_frequency</seealso>
    let total_tag_frequency = Prefixed_Name(scot, "total_tag_frequency") |> PrefixedName
    /// <summary>
    ///   <para>scot:total_tags</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The total number of Tags in a Tagcloud."</para>
    /// labels<para>"total tags"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#total_tags">http://rdfs.org/scot/ns#total_tags</seealso>
    let total_tags = Prefixed_Name(scot, "total_tags") |> PrefixedName
    /// <summary>
    ///   <para>scot:underscored</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of pharse in which each word is separated by an underscore."</para>
    /// labels<para>"underscored"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#underscored">http://rdfs.org/scot/ns#underscored</seealso>
    let underscored = Prefixed_Name(scot, "underscored") |> PrefixedName
    /// <summary>
    ///   <para>scot:updated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Date on which a Tagcloud is updated."</para>
    /// labels<para>"updated date"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#updated">http://rdfs.org/scot/ns#updated</seealso>
    let updated = Prefixed_Name(scot, "updated") |> PrefixedName
    /// <summary>
    ///   <para>scot:used_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Refers to the sioc:User who uses or creates a tag."</para>
    /// labels<para>"used by"</para></remarks>
    /// <seealso href="http://rdfs.org/scot/ns#used_by">http://rdfs.org/scot/ns#used_by</seealso>
    let used_by = Prefixed_Name(scot, "used_by") |> PrefixedName

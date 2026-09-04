#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module scot =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdfs.org/scot/ns#" "scot"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Cooccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : More than two tags are assigned to one resource. This class defines cooccurring tags and the cooccurring frequency between the tags^^xsd:string</para>
    ///   <a href="http://rdfs.org/scot/ns#Cooccurrence">scot:Cooccurrence</a>
    /// </summary>
    let Cooccurrence = _prefixId.prefix "Cooccurrence"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <para>rdfs:comment : A free-text keyword which is used to annotate a resource </para>
    ///   <a href="http://rdfs.org/scot/ns#Tag">scot:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Tagcloud</para>
    ///   <para>rdfs:comment : Tagcloud consists of metadata related to tagging activities connecting to the basic components such as users, tags, resources. </para>
    ///   <a href="http://rdfs.org/scot/ns#Tagcloud">scot:Tagcloud</a>
    /// </summary>
    let Tagcloud = _prefixId.prefix "Tagcloud"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : acronym</para>
    ///   <para>rdfs:comment : An abbreviation formed by the first letters of the compound word.</para>
    ///   <a href="http://rdfs.org/scot/ns#acronym">scot:acronym</a>
    /// </summary>
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : aggregated tag</para>
    ///   <para>rdfs:comment : A tag in tags:Tagging is collected to scot:Tag.</para>
    ///   <a href="http://rdfs.org/scot/ns#aggregated_tag">scot:aggregated_tag</a>
    /// </summary>
    let aggregated_tag = _prefixId.prefix "aggregated_tag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : associated by</para>
    ///   <para>rdfs:comment : An agent who makes a synonym relationship between the tags.</para>
    ///   <a href="http://rdfs.org/scot/ns#associated_by">scot:associated_by</a>
    /// </summary>
    let associated_by = _prefixId.prefix "associated_by"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : composed of</para>
    ///   <para>rdfs:comment : A SCOT Tagcloud that is part of this Tagcloud(especially one Tagcloud in a group SCOT Tagcloud).</para>
    ///   <a href="http://rdfs.org/scot/ns#composed_of">scot:composed_of</a>
    /// </summary>
    let composed_of = _prefixId.prefix "composed_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : contained in</para>
    ///   <para>rdfs:comment : An aggregated tag is contained in a tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#contained_in">scot:contained_in</a>
    /// </summary>
    let contained_in = _prefixId.prefix "contained_in"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : The relationship between a tagcloud and a tag. The object is a tag which is aggregated from a tagging instance.</para>
    ///   <a href="http://rdfs.org/scot/ns#contains">scot:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : cooccur absolute frequency</para>
    ///   <para>rdfs:comment : An absolute frequency of a particular cooccurring set of tags.</para>
    ///   <a href="http://rdfs.org/scot/ns#cooccur_afrequency">scot:cooccur_afrequency</a>
    /// </summary>
    let cooccur_afrequency = _prefixId.prefix "cooccur_afrequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : cooccur absolute frequency</para>
    ///   <para>rdfs:comment : A percentage frequency of cooccurring set of tags relative to the sum of frequencies of cooccurrence.</para>
    ///   <a href="http://rdfs.org/scot/ns#cooccur_rfrequency">scot:cooccur_rfrequency</a>
    /// </summary>
    let cooccur_rfrequency = _prefixId.prefix "cooccur_rfrequency"
    let cooccured_with = _prefixId.prefix "cooccured_with"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : cooccurs in</para>
    ///   <para>rdfs:comment : This property is used to represent relations among two or more tags.</para>
    ///   <a href="http://rdfs.org/scot/ns#cooccurs_in">scot:cooccurs_in</a>
    /// </summary>
    let cooccurs_in = _prefixId.prefix "cooccurs_in"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : cooccurs with</para>
    ///   <para>rdfs:comment : This property is used to represent relations among two or more tags.</para>
    ///   <a href="http://rdfs.org/scot/ns#cooccurs_with">scot:cooccurs_with</a>
    /// </summary>
    let cooccurs_with = _prefixId.prefix "cooccurs_with"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : created by</para>
    ///   <para>rdfs:comment : Indicates that an agent as type of a foaf:Agent, who generates a Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#created_by">scot:created_by</a>
    /// </summary>
    let created_by = _prefixId.prefix "created_by"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : delimited</para>
    ///   <para>rdfs:comment : A type of phrase in which each word is separated by a certain character.</para>
    ///   <a href="http://rdfs.org/scot/ns#delimited">scot:delimited</a>
    /// </summary>
    let delimited = _prefixId.prefix "delimited"
    /// <summary>
    ///   <para>rdfs:comment : An item has one and more tags.</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has tag</para>
    ///   <a href="http://rdfs.org/scot/ns#has_tag">scot:has_tag</a>
    /// </summary>
    let has_tag = _prefixId.prefix "has_tag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : has usergroup</para>
    ///   <para>rdfs:comment : The Usergroup that this Tagcloud is associated with.</para>
    ///   <a href="http://rdfs.org/scot/ns#has_usergroup">scot:has_usergroup</a>
    /// </summary>
    let has_usergroup = _prefixId.prefix "has_usergroup"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hypenated</para>
    ///   <para>rdfs:comment : A type of phrase in which each word is separated by a hyphen.</para>
    ///   <a href="http://rdfs.org/scot/ns#hypenated">scot:hypenated</a>
    /// </summary>
    let hypenated = _prefixId.prefix "hypenated"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : last used</para>
    ///   <para>rdfs:comment : A last date on which a particular tag is used .</para>
    ///   <a href="http://rdfs.org/scot/ns#last_used">scot:last_used</a>
    /// </summary>
    let last_used = _prefixId.prefix "last_used"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : own absolute frequency</para>
    ///   <para>rdfs:comment : An absolute frequency of a particular tag in a Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#own_afrequency">scot:own_afrequency</a>
    /// </summary>
    let own_afrequency = _prefixId.prefix "own_afrequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : own relative frequency</para>
    ///   <para>rdfs:comment : A percentage frequency of a tag for a particular Tagcloud relative to the total of all Tag frequencies in that Tagcloud..</para>
    ///   <a href="http://rdfs.org/scot/ns#own_rfrequency">scot:own_rfrequency</a>
    /// </summary>
    let own_rfrequency = _prefixId.prefix "own_rfrequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : plural</para>
    ///   <para>rdfs:comment : Refers to more than one thing.</para>
    ///   <a href="http://rdfs.org/scot/ns#plural">scot:plural</a>
    /// </summary>
    let plural = _prefixId.prefix "plural"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : singular</para>
    ///   <para>rdfs:comment : Refers to one thing.</para>
    ///   <a href="http://rdfs.org/scot/ns#singular">scot:singular</a>
    /// </summary>
    let singular = _prefixId.prefix "singular"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : slashed</para>
    ///   <para>rdfs:comment : A type of phrase in which each word is separated by a slash.</para>
    ///   <a href="http://rdfs.org/scot/ns#slashed">scot:slashed</a>
    /// </summary>
    let slashed = _prefixId.prefix "slashed"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : spaced</para>
    ///   <para>rdfs:comment : A type of phrase in which each piece of word is separated by a space.</para>
    ///   <a href="http://rdfs.org/scot/ns#spaced">scot:spaced</a>
    /// </summary>
    let spaced = _prefixId.prefix "spaced"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : spelling variant</para>
    ///   <para>rdfs:comment : A variation in the way in which a word is spelled.</para>
    ///   <a href="http://rdfs.org/scot/ns#spelling_variant">scot:spelling_variant</a>
    /// </summary>
    let spelling_variant = _prefixId.prefix "spelling_variant"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : synonym</para>
    ///   <para>rdfs:comment : Word which means the same as another word.</para>
    ///   <a href="http://rdfs.org/scot/ns#synonym">scot:synonym</a>
    /// </summary>
    let synonym = _prefixId.prefix "synonym"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a tag is assigned to the sioc:Item.</para>
    ///   <para>rdfs:label : tag of</para>
    ///   <a href="http://rdfs.org/scot/ns#tag_of">scot:tag_of</a>
    /// </summary>
    let tag_of = _prefixId.prefix "tag_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagging account</para>
    ///   <para>rdfs:comment : The relationship between an agent and an account held by this agent.</para>
    ///   <a href="http://rdfs.org/scot/ns#tagging_account">scot:tagging_account</a>
    /// </summary>
    let tagging_account = _prefixId.prefix "tagging_account"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tagging activity</para>
    ///   <para>rdfs:comment : The relationship between a tagcloud and a tagging. Note that a tagcloud allows us to contain one or more tagging instances.</para>
    ///   <a href="http://rdfs.org/scot/ns#tagging_activity">scot:tagging_activity</a>
    /// </summary>
    let tagging_activity = _prefixId.prefix "tagging_activity"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : tag space</para>
    ///   <para>rdfs:comment : The environment where the tagging happens.</para>
    ///   <a href="http://rdfs.org/scot/ns#tagspace">scot:tagspace</a>
    /// </summary>
    let tagspace = _prefixId.prefix "tagspace"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total cooccur frequency</para>
    ///   <para>rdfs:comment : A number of total frequency for all cooccurring tag sets in a Tagcloud</para>
    ///   <a href="http://rdfs.org/scot/ns#total_cooccur_frequency">scot:total_cooccur_frequency</a>
    /// </summary>
    let total_cooccur_frequency = _prefixId.prefix "total_cooccur_frequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total cooccur tags</para>
    ///   <para>rdfs:comment : The total number of cooccuring tags in a Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#total_cooccur_tags">scot:total_cooccur_tags</a>
    /// </summary>
    let total_cooccur_tags = _prefixId.prefix "total_cooccur_tags"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total items</para>
    ///   <para>rdfs:comment : A number of posted items with an associated Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#total_items">scot:total_items</a>
    /// </summary>
    let total_items = _prefixId.prefix "total_items"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total tag frequency</para>
    ///   <para>rdfs:comment : A number of total frequency for all Tags in a Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#total_tag_frequency">scot:total_tag_frequency</a>
    /// </summary>
    let total_tag_frequency = _prefixId.prefix "total_tag_frequency"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : total tags</para>
    ///   <para>rdfs:comment : The total number of Tags in a Tagcloud.</para>
    ///   <a href="http://rdfs.org/scot/ns#total_tags">scot:total_tags</a>
    /// </summary>
    let total_tags = _prefixId.prefix "total_tags"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : underscored</para>
    ///   <para>rdfs:comment : A type of pharse in which each word is separated by an underscore.</para>
    ///   <a href="http://rdfs.org/scot/ns#underscored">scot:underscored</a>
    /// </summary>
    let underscored = _prefixId.prefix "underscored"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : updated date</para>
    ///   <para>rdfs:comment : Date on which a Tagcloud is updated.</para>
    ///   <a href="http://rdfs.org/scot/ns#updated">scot:updated</a>
    /// </summary>
    let updated = _prefixId.prefix "updated"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : used by</para>
    ///   <para>rdfs:comment : Refers to the sioc:User who uses or creates a tag.</para>
    ///   <a href="http://rdfs.org/scot/ns#used_by">scot:used_by</a>
    /// </summary>
    let used_by = _prefixId.prefix "used_by"

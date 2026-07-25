namespace http.purl.org.muto.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module muto =
    let _namespace_iri = Namespace_Iri muto |> NamespaceIRI
    /// <summary>
    ///   <para>muto:AutoTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An automatic tag is a tag that is automatically associated with a resource (e.g. by a tagging system), i.e. it is not entered by a human being.</para>
    /// labels<para>Automatic Tag</para></remarks>
    /// <seealso href="http://purl.org/muto/core#AutoTag">http://purl.org/muto/core#AutoTag</seealso>
    let AutoTag = Prefixed_Name(muto, "AutoTag") |> PrefixedName
    /// <summary>
    ///   <para>muto:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Tag consists of an arbitrary text label. Note that tags with the same label are NOT merged in the ontology.</para>
    /// labels<para>Tag</para></remarks>
    /// <seealso href="http://purl.org/muto/core#Tag">http://purl.org/muto/core#Tag</seealso>
    let Tag = Prefixed_Name(muto, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>muto:hasAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A user account or user group can have access to a private tagging from another user if the access is explicitly permitted by the creator of the tagging. This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging has suggested the tagging to another user).</para>
    /// labels<para>has access</para></remarks>
    /// <seealso href="http://purl.org/muto/core#hasAccess">http://purl.org/muto/core#hasAccess</seealso>
    let hasAccess = Prefixed_Name(muto, "hasAccess") |> PrefixedName
    /// <summary>
    ///   <para>muto:Tagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tagging links a resource to a user account and one or more tags.</para>
    /// labels<para>Tagging</para></remarks>
    /// <seealso href="http://purl.org/muto/core#Tagging">http://purl.org/muto/core#Tagging</seealso>
    let Tagging = Prefixed_Name(muto, "Tagging") |> PrefixedName
    /// <summary>
    ///   <para>muto:tagMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The meaning of a tag can be expressed by a link to a well-defined resource. This can be any resource that clarifies the meaning of the tag (e.g. some DBpedia resource).</para>
    /// labels<para>tag meaning</para></remarks>
    /// <seealso href="http://purl.org/muto/core#tagMeaning">http://purl.org/muto/core#tagMeaning</seealso>
    let tagMeaning = Prefixed_Name(muto, "tagMeaning") |> PrefixedName
    /// <summary>
    ///   <para>muto:creatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A user account can have a (theoretically unlimited) number of taggings. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.</para>
    /// labels<para>creator of</para></remarks>
    /// <seealso href="http://purl.org/muto/core#creatorOf">http://purl.org/muto/core#creatorOf</seealso>
    let creatorOf = Prefixed_Name(muto, "creatorOf") |> PrefixedName
    /// <summary>
    ///   <para>muto:PrivateTagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A private tagging is a tagging that is only visible to its creator (unless the creator has not granted access to others via muto:grantAccess). Every tagging that is not an instance of muto:PrivateTagging is public by default.</para>
    /// labels<para>Private Tagging</para></remarks>
    /// <seealso href="http://purl.org/muto/core#PrivateTagging">http://purl.org/muto/core#PrivateTagging</seealso>
    let PrivateTagging = Prefixed_Name(muto, "PrivateTagging") |> PrefixedName
    /// <summary>
    ///   <para>muto:autoMeaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This subproperty indicates that the meaning of a tag has been automatically defined (e.g. by a tagging system), i.e. it has not been defined by a human being. The default case is disambiguation by users via muto:tagMeaning.</para>
    /// labels<para>automatic tag meaning</para></remarks>
    /// <seealso href="http://purl.org/muto/core#autoMeaning">http://purl.org/muto/core#autoMeaning</seealso>
    let autoMeaning = Prefixed_Name(muto, "autoMeaning") |> PrefixedName
    /// <summary>
    ///   <para>muto:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Every tagging is linked to at most one user account. This property can be omitted for automatic taggings. In contrast to its superproperty sioc:has_creator, it is functional and with an explicit domain. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.</para>
    /// labels<para>has creator</para></remarks>
    /// <seealso href="http://purl.org/muto/core#hasCreator">http://purl.org/muto/core#hasCreator</seealso>
    let hasCreator = Prefixed_Name(muto, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>muto:grantAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A (usually private) tagging can be linked to one or more user accounts or user groups that should have access to it (apart from the creator). This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging wants to suggest the tagging to another user).</para>
    /// labels<para>grant access</para></remarks>
    /// <seealso href="http://purl.org/muto/core#grantAccess">http://purl.org/muto/core#grantAccess</seealso>
    let grantAccess = Prefixed_Name(muto, "grantAccess") |> PrefixedName
    /// <summary>
    ///   <para>muto:previousTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property indicates the tag that is preceding in the list of tags. It can be used to describe the order in which the tags have been entered by the user.</para>
    /// labels<para>previous tag</para></remarks>
    /// <seealso href="http://purl.org/muto/core#previousTag">http://purl.org/muto/core#previousTag</seealso>
    let previousTag = Prefixed_Name(muto, "previousTag") |> PrefixedName
    /// <summary>
    ///   <para>muto:tagCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The creation date and time of a tag. This property can be omitted if muto:taggingCreated = muto:tagCreated (i.e. in the common case that a tag has been created along with a tagging, not in a later edit of the tagging). The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).</para>
    /// labels<para>tag created</para></remarks>
    /// <seealso href="http://purl.org/muto/core#tagCreated">http://purl.org/muto/core#tagCreated</seealso>
    let tagCreated = Prefixed_Name(muto, "tagCreated") |> PrefixedName
    /// <summary>
    ///   <para>muto:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A tagging consists of a (theoretically unlimited) number of tags. A tagging may also consist of no tags, e.g. if the system allows its users to mark a resource first and add tags later.</para>
    /// labels<para>has tag</para></remarks>
    /// <seealso href="http://purl.org/muto/core#hasTag">http://purl.org/muto/core#hasTag</seealso>
    let hasTag = Prefixed_Name(muto, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>muto:nextTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property indicates the tag that follows next in the list of tags. It can be used to describe the order in which the tags have been entered by the user.</para>
    /// labels<para>next tag</para></remarks>
    /// <seealso href="http://purl.org/muto/core#nextTag">http://purl.org/muto/core#nextTag</seealso>
    let nextTag = Prefixed_Name(muto, "nextTag") |> PrefixedName
    /// <summary>
    ///   <para>muto:meaningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The number of tags that can be linked to one and the same meaning is theoretically unlimited.</para>
    /// labels<para>meaning of</para></remarks>
    /// <seealso href="http://purl.org/muto/core#meaningOf">http://purl.org/muto/core#meaningOf</seealso>
    let meaningOf = Prefixed_Name(muto, "meaningOf") |> PrefixedName
    /// <summary>
    ///   <para>muto:tagLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Every tag has exactly one label (usually the one given by the user) - otherwise it is not a tag. Additional labels can be defined in the resource that is linked via muto:tagMeaning.</para>
    /// labels<para>tag label</para></remarks>
    /// <seealso href="http://purl.org/muto/core#tagLabel">http://purl.org/muto/core#tagLabel</seealso>
    let tagLabel = Prefixed_Name(muto, "tagLabel") |> PrefixedName
    /// <summary>
    ///   <para>muto:taggedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Every tagging is linked to exactly one resource. This can be any kind of resource (i.e. all subclasses of rdfs:Resource), including tags and taggings.</para>
    /// labels<para>tagged resource</para></remarks>
    /// <seealso href="http://purl.org/muto/core#taggedResource">http://purl.org/muto/core#taggedResource</seealso>
    let taggedResource = Prefixed_Name(muto, "taggedResource") |> PrefixedName
    /// <summary>
    ///   <para>muto:taggedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource can have several taggings from different users. Tags are never directly linked to resources but can be inferred from the taggings.</para>
    /// labels<para>tagged with</para></remarks>
    /// <seealso href="http://purl.org/muto/core#taggedWith">http://purl.org/muto/core#taggedWith</seealso>
    let taggedWith = Prefixed_Name(muto, "taggedWith") |> PrefixedName
    /// <summary>
    ///   <para>muto:tagOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Every tag is linked to exactly one tagging. This results from the fact that tags with same labels are NOT merged in the ontology.</para>
    /// labels<para>tag of</para></remarks>
    /// <seealso href="http://purl.org/muto/core#tagOf">http://purl.org/muto/core#tagOf</seealso>
    let tagOf = Prefixed_Name(muto, "tagOf") |> PrefixedName
    /// <summary>
    ///   <para>muto:taggingCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Every tagging has exactly one creation date and time. The datatype of this property is xsd:dateTime (in contrast to its superproperty dcterms:created which has range rdfs:Literal).</para>
    /// labels<para>tagging created</para></remarks>
    /// <seealso href="http://purl.org/muto/core#taggingCreated">http://purl.org/muto/core#taggingCreated</seealso>
    let taggingCreated = Prefixed_Name(muto, "taggingCreated") |> PrefixedName
    /// <summary>
    ///   <para>muto:taggingModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A tagging can have multiple modification dates, as the number of times a tagging can be edited (e.g. to add or remove tags) is theoretically unlimited. The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).</para>
    /// labels<para>tagging modified</para></remarks>
    /// <seealso href="http://purl.org/muto/core#taggingModified">http://purl.org/muto/core#taggingModified</seealso>
    let taggingModified = Prefixed_Name(muto, "taggingModified") |> PrefixedName
    /// <summary>
    ///   <para>muto:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/muto/core#">http://purl.org/muto/core#</seealso>
    let _prefix_iri = Prefixed_Name(muto, "") |> PrefixedName

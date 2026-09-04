#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module muto =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/muto/core#" "muto"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: muto:AutoTag was a subclass of muto:Tagging (called muto:autoTagging) in earlier versions. Defining it as a subclass of muto:Tag is more appropriate and allows for taggings that contain a combination of manually and automatically created tags.^^xsd:string</para>
    ///   <para>rdfs:comment : An automatic tag is a tag that is automatically associated with a resource (e.g. by a tagging system), i.e. it is not entered by a human being.</para>
    ///   <para>rdfs:label : Automatic Tag</para>
    ///   <a href="http://purl.org/muto/core#AutoTag">muto:AutoTag</a>
    /// </summary>
    let AutoTag = _prefixId.prefix "AutoTag"
    /// <summary>
    ///   <para>rdfs:comment : A private tagging is a tagging that is only visible to its creator (unless the creator has not granted access to others via muto:grantAccess). Every tagging that is not an instance of muto:PrivateTagging is public by default.</para>
    ///   <para>rdfs:label : Private Tagging</para>
    ///   <a href="http://purl.org/muto/core#PrivateTagging">muto:PrivateTagging</a>
    /// </summary>
    let PrivateTagging = _prefixId.prefix "PrivateTagging"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: The owl:disjointWith statement was removed to make MUTO conform to OWL Lite (the statement is not essential in this case).^^xsd:string</para>
    ///   <para>rdfs:comment : A Tag consists of an arbitrary text label. Note that tags with the same label are NOT merged in the ontology.</para>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="http://purl.org/muto/core#Tag">muto:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:comment : A tagging links a resource to a user account and one or more tags.</para>
    ///   <para>rdfs:label : Tagging</para>
    ///   <a href="http://purl.org/muto/core#Tagging">muto:Tagging</a>
    /// </summary>
    let Tagging = _prefixId.prefix "Tagging"
    /// <summary>
    ///   <para>rdfs:comment : This subproperty indicates that the meaning of a tag has been automatically defined (e.g. by a tagging system), i.e. it has not been defined by a human being. The default case is disambiguation by users via muto:tagMeaning.</para>
    ///   <para>rdfs:label : automatic tag meaning</para>
    ///   <a href="http://purl.org/muto/core#autoMeaning">muto:autoMeaning</a>
    /// </summary>
    let autoMeaning = _prefixId.prefix "autoMeaning"
    /// <summary>
    ///   <para>rdfs:comment : A user account can have a (theoretically unlimited) number of taggings. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.</para>
    ///   <para>rdfs:label : creator of</para>
    ///   <a href="http://purl.org/muto/core#creatorOf">muto:creatorOf</a>
    /// </summary>
    let creatorOf = _prefixId.prefix "creatorOf"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: The range information has been removed for greater flexibility and OWL Lite conformance (no longer owl:unionOf). Classes from different vocabularies can now be used here - such as sioc:UserAccount, sioc:Usergroup, foaf:OnlineAccount, foaf:Group, or dcterms:Agent -, though we recommend the use of sioc:UserAccount or sioc:Usergroup to remain in the SIOC namespace.^^xsd:string</para>
    ///   <para>rdfs:comment : A (usually private) tagging can be linked to one or more user accounts or user groups that should have access to it (apart from the creator). This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging wants to suggest the tagging to another user).</para>
    ///   <para>rdfs:label : grant access</para>
    ///   <a href="http://purl.org/muto/core#grantAccess">muto:grantAccess</a>
    /// </summary>
    let grantAccess = _prefixId.prefix "grantAccess"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: see muto:grantAccess^^xsd:string</para>
    ///   <para>rdfs:comment : A user account or user group can have access to a private tagging from another user if the access is explicitly permitted by the creator of the tagging. This property can also be used in public tagging to link a user account or user group to a tagging (e.g. if the creator of a tagging has suggested the tagging to another user).</para>
    ///   <para>rdfs:label : has access</para>
    ///   <a href="http://purl.org/muto/core#hasAccess">muto:hasAccess</a>
    /// </summary>
    let hasAccess = _prefixId.prefix "hasAccess"
    /// <summary>
    ///   <para>rdfs:comment : Every tagging is linked to at most one user account. This property can be omitted for automatic taggings. In contrast to its superproperty sioc:has_creator, it is functional and with an explicit domain. Use sioc:member_of to define groups for group tagging or link to foaf:Agent, foaf:Person, or foaf:Group via sioc:account_of.</para>
    ///   <para>rdfs:label : has creator</para>
    ///   <a href="http://purl.org/muto/core#hasCreator">muto:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rdfs:comment : A tagging consists of a (theoretically unlimited) number of tags. A tagging may also consist of no tags, e.g. if the system allows its users to mark a resource first and add tags later.</para>
    ///   <para>rdfs:label : has tag</para>
    ///   <a href="http://purl.org/muto/core#hasTag">muto:hasTag</a>
    /// </summary>
    let hasTag = _prefixId.prefix "hasTag"
    /// <summary>
    ///   <para>rdfs:comment : The number of tags that can be linked to one and the same meaning is theoretically unlimited.</para>
    ///   <para>rdfs:label : meaning of</para>
    ///   <a href="http://purl.org/muto/core#meaningOf">muto:meaningOf</a>
    /// </summary>
    let meaningOf = _prefixId.prefix "meaningOf"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: Earlier versions of MUTO defined a datatype property muto:tagPosition with integer values which has some drawbacks compared to this solution.^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the tag that follows next in the list of tags. It can be used to describe the order in which the tags have been entered by the user.</para>
    ///   <para>rdfs:label : next tag</para>
    ///   <a href="http://purl.org/muto/core#nextTag">muto:nextTag</a>
    /// </summary>
    let nextTag = _prefixId.prefix "nextTag"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: see muto:nextTag^^xsd:string</para>
    ///   <para>rdfs:comment : This property indicates the tag that is preceding in the list of tags. It can be used to describe the order in which the tags have been entered by the user.</para>
    ///   <para>rdfs:label : previous tag</para>
    ///   <a href="http://purl.org/muto/core#previousTag">muto:previousTag</a>
    /// </summary>
    let previousTag = _prefixId.prefix "previousTag"
    /// <summary>
    ///   <para>rdfs:comment : The creation date and time of a tag. This property can be omitted if muto:taggingCreated = muto:tagCreated (i.e. in the common case that a tag has been created along with a tagging, not in a later edit of the tagging). The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).</para>
    ///   <para>rdfs:label : tag created</para>
    ///   <a href="http://purl.org/muto/core#tagCreated">muto:tagCreated</a>
    /// </summary>
    let tagCreated = _prefixId.prefix "tagCreated"
    /// <summary>
    ///   <para>owl:versionInfo : Version 1.0: The subproperty relation to rdfs:label has been removed for OWL DL conformance (rdfs:label is an annotation property and one cannot define subproperties for annotation properties in OWL DL).^^xsd:string</para>
    ///   <para>rdfs:comment : Every tag has exactly one label (usually the one given by the user) - otherwise it is not a tag. Additional labels can be defined in the resource that is linked via muto:tagMeaning.</para>
    ///   <para>rdfs:label : tag label</para>
    ///   <a href="http://purl.org/muto/core#tagLabel">muto:tagLabel</a>
    /// </summary>
    let tagLabel = _prefixId.prefix "tagLabel"
    /// <summary>
    ///   <para>rdfs:comment : The meaning of a tag can be expressed by a link to a well-defined resource. This can be any resource that clarifies the meaning of the tag (e.g. some DBpedia resource).</para>
    ///   <para>rdfs:label : tag meaning</para>
    ///   <a href="http://purl.org/muto/core#tagMeaning">muto:tagMeaning</a>
    /// </summary>
    let tagMeaning = _prefixId.prefix "tagMeaning"
    /// <summary>
    ///   <para>rdfs:comment : Every tag is linked to exactly one tagging. This results from the fact that tags with same labels are NOT merged in the ontology.</para>
    ///   <para>rdfs:label : tag of</para>
    ///   <a href="http://purl.org/muto/core#tagOf">muto:tagOf</a>
    /// </summary>
    let tagOf = _prefixId.prefix "tagOf"
    /// <summary>
    ///   <para>rdfs:comment : Every tagging is linked to exactly one resource. This can be any kind of resource (i.e. all subclasses of rdfs:Resource), including tags and taggings.</para>
    ///   <para>rdfs:label : tagged resource</para>
    ///   <a href="http://purl.org/muto/core#taggedResource">muto:taggedResource</a>
    /// </summary>
    let taggedResource = _prefixId.prefix "taggedResource"
    /// <summary>
    ///   <para>rdfs:comment : A resource can have several taggings from different users. Tags are never directly linked to resources but can be inferred from the taggings.</para>
    ///   <para>rdfs:label : tagged with</para>
    ///   <a href="http://purl.org/muto/core#taggedWith">muto:taggedWith</a>
    /// </summary>
    let taggedWith = _prefixId.prefix "taggedWith"
    /// <summary>
    ///   <para>rdfs:comment : Every tagging has exactly one creation date and time. The datatype of this property is xsd:dateTime (in contrast to its superproperty dcterms:created which has range rdfs:Literal).</para>
    ///   <para>rdfs:label : tagging created</para>
    ///   <a href="http://purl.org/muto/core#taggingCreated">muto:taggingCreated</a>
    /// </summary>
    let taggingCreated = _prefixId.prefix "taggingCreated"
    /// <summary>
    ///   <para>rdfs:comment : A tagging can have multiple modification dates, as the number of times a tagging can be edited (e.g. to add or remove tags) is theoretically unlimited. The datatype of this property is xsd:dateTime (in contrast to it superproperty dcterms:created which has range rdfs:Literal).</para>
    ///   <para>rdfs:label : tagging modified</para>
    ///   <a href="http://purl.org/muto/core#taggingModified">muto:taggingModified</a>
    /// </summary>
    let taggingModified = _prefixId.prefix "taggingModified"

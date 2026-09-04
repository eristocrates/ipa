#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pat =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/hpi/patchr#" "pat"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ConjunctivePatchGroup</para>
    ///   <para>rdfs:comment : A conjunctive patch group is collection (list) of patches where all member patches need to be applied to the dataset to resolve the problem.</para>
    ///   <a href="http://purl.org/hpi/patchr#ConjunctivePatchGroup">pat:ConjunctivePatchGroup</a>
    /// </summary>
    let ConjunctivePatchGroup = _prefixId.prefix "ConjunctivePatchGroup"
    /// <summary>
    ///   <para>rdfs:label : DisjunctivePatchGroup</para>
    ///   <para>rdfs:comment : A disjunctive patch group is collection (alternative list) of patches where one member patch need to be applied to resolve the problem.</para>
    ///   <a href="http://purl.org/hpi/patchr#DisjunctivePatchGroup">pat:DisjunctivePatchGroup</a>
    /// </summary>
    let DisjunctivePatchGroup = _prefixId.prefix "DisjunctivePatchGroup"
    let Open = _prefixId.prefix "Open"
    /// <summary>
    ///   <para>rdfs:label : Patch</para>
    ///   <para>rdfs:comment : A patch is a request to add, change or delete certain triples (or subgraphs) within a dataset. A patch refers to an guo:UpdateInstruction. For convenient retrieval a patch should be described with provenance data, a patch type and a dataset it applies to.</para>
    ///   <a href="http://purl.org/hpi/patchr#Patch">pat:Patch</a>
    /// </summary>
    let Patch = _prefixId.prefix "Patch"
    /// <summary>
    ///   <para>rdfs:label : PatchGroup</para>
    ///   <para>rdfs:comment : A patch group is a collection of patches that apply to a common problem.</para>
    ///   <a href="http://purl.org/hpi/patchr#PatchGroup">pat:PatchGroup</a>
    /// </summary>
    let PatchGroup = _prefixId.prefix "PatchGroup"
    /// <summary>
    ///   <para>rdfs:label : PatchStatus</para>
    ///   <para>rdfs:comment : The status of the patch, might be one of Open, Resolved, Postponed, or Rejected.</para>
    ///   <a href="http://purl.org/hpi/patchr#PatchStatus">pat:PatchStatus</a>
    /// </summary>
    let PatchStatus = _prefixId.prefix "PatchStatus"
    /// <summary>
    ///   <para>rdfs:label : PatchType</para>
    ///   <a href="http://purl.org/hpi/patchr#PatchType">pat:PatchType</a>
    /// </summary>
    let PatchType = _prefixId.prefix "PatchType"
    let Postponed = _prefixId.prefix "Postponed"
    let Rejected = _prefixId.prefix "Rejected"
    let Resolved = _prefixId.prefix "Resolved"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : advocate</para>
    ///   <para>rdfs:comment : This property is deprecated and should not be used any more, rather use a positive confidence value for advocating agents.
    ///
    /// Links agents who support, i.e. vote for, a :Patch. Each time a user creates a patch request, appropriate provenance information is generated.</para>
    ///   <a href="http://purl.org/hpi/patchr#advocate">pat:advocate</a>
    /// </summary>
    let advocate = _prefixId.prefix "advocate"
    /// <summary>
    ///   <para>rdfs:label : appliesTo</para>
    ///   <para>rdfs:comment : Refers to a void:Dataset to allow convenient selection of patches per dataset.</para>
    ///   <a href="http://purl.org/hpi/patchr#appliesTo">pat:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : comment</para>
    ///   <para>rdfs:comment : This property is deprecated and should not be used any more, use dcterms:description instead.
    ///
    /// A comment on the patch. This is likely just an informal message a user wants to share when submitting a Patch.</para>
    ///   <a href="http://purl.org/hpi/patchr#comment">pat:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:label : confidence</para>
    ///   <para>rdfs:comment : A confidence assigned by the creator of the patch, e.g. in case heuristic methods identified an inconsistency. This confidence must be expressed in the range of [-1,1], whereas a high value means higher confidence and a value of 1 signifies absolute certainty. Negative values indicate criticism towards this patch.</para>
    ///   <a href="http://purl.org/hpi/patchr#confidence">pat:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : criticiser</para>
    ///   <para>rdfs:comment : This property is deprecated and should not be used any more, rather use a negative confidence value for advocating agents.
    ///
    /// Links agents who disagree, i.e. vote against, a :Patch.</para>
    ///   <a href="http://purl.org/hpi/patchr#criticiser">pat:criticiser</a>
    /// </summary>
    let criticiser = _prefixId.prefix "criticiser"
    /// <summary>
    ///   <para>rdfs:label : memberOf</para>
    ///   <para>rdfs:comment : Relates a Patch to a PatchGroup. A Patch may be part of multiple :PatchGroups.</para>
    ///   <a href="http://purl.org/hpi/patchr#memberOf">pat:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:label : patchType</para>
    ///   <para>rdfs:comment : Refers to a classification of the patch. There might be patch taxonomies from different applications that define the reason for a :Patch on their own. A :Patch may have multiple types.</para>
    ///   <a href="http://purl.org/hpi/patchr#patchType">pat:patchType</a>
    /// </summary>
    let patchType = _prefixId.prefix "patchType"
    /// <summary>
    ///   <para>rdfs:label : patchrService</para>
    ///   <para>rdfs:comment : Links a resource to the PatchR instance responsible for collecting patch requests.</para>
    ///   <a href="http://purl.org/hpi/patchr#patchrService">pat:patchrService</a>
    /// </summary>
    let patchrService = _prefixId.prefix "patchrService"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : provenance</para>
    ///   <para>rdfs:comment : This property is deprecated and should not be used any more, use prov:wasGeneratedBy instead.
    ///
    /// Refers to the provenance context where this patch was created.</para>
    ///   <a href="http://purl.org/hpi/patchr#provenance">pat:provenance</a>
    /// </summary>
    let provenance = _prefixId.prefix "provenance"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : The status of the patch, might be one of Open, Resolved, Postponed, or Rejected.</para>
    ///   <a href="http://purl.org/hpi/patchr#status">pat:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : update</para>
    ///   <para>rdfs:comment : Refers to a guo:UpdateInstruction. There must be exactly one guo:UpdateInstruction per :Patch. The guo:UpdateInstruction either is a deletion, insertion, or replacement of triples for one particular subject resource.</para>
    ///   <a href="http://purl.org/hpi/patchr#update">pat:update</a>
    /// </summary>
    let update = _prefixId.prefix "update"

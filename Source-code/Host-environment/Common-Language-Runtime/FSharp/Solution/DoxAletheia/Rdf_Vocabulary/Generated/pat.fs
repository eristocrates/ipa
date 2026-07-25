namespace http.purl.org.hpi.patchr.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pat =
    let _namespace_iri = Namespace_Iri pat |> NamespaceIRI

    /// <summary>
    ///   <para>pat:ConjunctivePatchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A conjunctive patch group is collection (list) of patches where all member patches need to be applied to the dataset to resolve the problem.</para>
    /// labels<para>ConjunctivePatchGroup</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#ConjunctivePatchGroup">http://purl.org/hpi/patchr#ConjunctivePatchGroup</seealso>
    let ConjunctivePatchGroup =
        Prefixed_Name(pat, "ConjunctivePatchGroup") |> PrefixedName

    /// <summary>
    ///   <para>pat:Open</para>
    /// </summary>
    /// <remarks>
    ///   <para>pat:PatchStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The patch has been raised.</para>
    /// labels<para>Open</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#Open">http://purl.org/hpi/patchr#Open</seealso>
    let Open = Prefixed_Name(pat, "Open") |> PrefixedName
    /// <summary>
    ///   <para>pat:Patch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A patch is a request to add, change or delete certain triples (or subgraphs) within a dataset. A patch refers to an guo:UpdateInstruction. For convenient retrieval a patch should be described with provenance data, a patch type and a dataset it applies to.</para>
    /// labels<para>Patch</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#Patch">http://purl.org/hpi/patchr#Patch</seealso>
    let Patch = Prefixed_Name(pat, "Patch") |> PrefixedName
    /// <summary>
    ///   <para>pat:appliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to a void:Dataset to allow convenient selection of patches per dataset.</para>
    /// labels<para>appliesTo</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#appliesTo">http://purl.org/hpi/patchr#appliesTo</seealso>
    let appliesTo = Prefixed_Name(pat, "appliesTo") |> PrefixedName

    /// <summary>
    ///   <para>pat:DisjunctivePatchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A disjunctive patch group is collection (alternative list) of patches where one member patch need to be applied to resolve the problem.</para>
    /// labels<para>DisjunctivePatchGroup</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#DisjunctivePatchGroup">http://purl.org/hpi/patchr#DisjunctivePatchGroup</seealso>
    let DisjunctivePatchGroup =
        Prefixed_Name(pat, "DisjunctivePatchGroup") |> PrefixedName

    /// <summary>
    ///   <para>pat:update</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to a guo:UpdateInstruction. There must be exactly one guo:UpdateInstruction per :Patch. The guo:UpdateInstruction either is a deletion, insertion, or replacement of triples for one particular subject resource.</para>
    /// labels<para>update</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#update">http://purl.org/hpi/patchr#update</seealso>
    let update = Prefixed_Name(pat, "update") |> PrefixedName
    /// <summary>
    ///   <para>pat:Resolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>pat:PatchStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The patch has been resolved, i.e. this patch has been applied. It can be more or less ignored but is kept for archival reasons, new requests for that patch will be answered as resolved.</para>
    /// labels<para>Resolved</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#Resolved">http://purl.org/hpi/patchr#Resolved</seealso>
    let Resolved = Prefixed_Name(pat, "Resolved") |> PrefixedName
    /// <summary>
    ///   <para>pat:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A confidence assigned by the creator of the patch, e.g. in case heuristic methods identified an inconsistency. This confidence must be expressed in the range of [-1,1], whereas a high value means higher confidence and a value of 1 signifies absolute certainty. Negative values indicate criticism towards this patch.</para>
    /// labels<para>confidence</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#confidence">http://purl.org/hpi/patchr#confidence</seealso>
    let confidence = Prefixed_Name(pat, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>pat:patchType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to a classification of the patch. There might be patch taxonomies from different applications that define the reason for a :Patch on their own. A :Patch may have multiple types.</para>
    /// labels<para>patchType</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#patchType">http://purl.org/hpi/patchr#patchType</seealso>
    let patchType = Prefixed_Name(pat, "patchType") |> PrefixedName
    /// <summary>
    ///   <para>pat:provenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is deprecated and should not be used any more, use prov:wasGeneratedBy instead.
    ///
    /// Refers to the provenance context where this patch was created.</para>
    /// labels<para>provenance</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#provenance">http://purl.org/hpi/patchr#provenance</seealso>
    let provenance = Prefixed_Name(pat, "provenance") |> PrefixedName
    /// <summary>
    ///   <para>pat:patchrService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a resource to the PatchR instance responsible for collecting patch requests.</para>
    /// labels<para>patchrService</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#patchrService">http://purl.org/hpi/patchr#patchrService</seealso>
    let patchrService = Prefixed_Name(pat, "patchrService") |> PrefixedName
    /// <summary>
    ///   <para>pat:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The status of the patch, might be one of Open, Resolved, Postponed, or Rejected.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#status">http://purl.org/hpi/patchr#status</seealso>
    let status = Prefixed_Name(pat, "status") |> PrefixedName
    /// <summary>
    ///   <para>pat:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/hpi/patchr#">http://purl.org/hpi/patchr#</seealso>
    let _prefix_iri = Prefixed_Name(pat, "") |> PrefixedName
    /// <summary>
    ///   <para>pat:PatchGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A patch group is a collection of patches that apply to a common problem.</para>
    /// labels<para>PatchGroup</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#PatchGroup">http://purl.org/hpi/patchr#PatchGroup</seealso>
    let PatchGroup = Prefixed_Name(pat, "PatchGroup") |> PrefixedName
    /// <summary>
    ///   <para>pat:PatchStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The status of the patch, might be one of Open, Resolved, Postponed, or Rejected.</para>
    /// labels<para>PatchStatus</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#PatchStatus">http://purl.org/hpi/patchr#PatchStatus</seealso>
    let PatchStatus = Prefixed_Name(pat, "PatchStatus") |> PrefixedName
    /// <summary>
    ///   <para>pat:PatchType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>PatchType</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#PatchType">http://purl.org/hpi/patchr#PatchType</seealso>
    let PatchType = Prefixed_Name(pat, "PatchType") |> PrefixedName
    /// <summary>
    ///   <para>pat:Postponed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>pat:PatchStatus</para>
    ///   <para>The patch has been postponed.</para>
    /// labels<para>Postponed</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#Postponed">http://purl.org/hpi/patchr#Postponed</seealso>
    let Postponed = Prefixed_Name(pat, "Postponed") |> PrefixedName
    /// <summary>
    ///   <para>pat:Rejected</para>
    /// </summary>
    /// <remarks>
    ///   <para>pat:PatchStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The patch has been rejected, i.e. this patch will not be applied. It can be more or less ignored but is kept for archival reasons, new requests for that patch will be rejected.</para>
    /// labels<para>Rejected</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#Rejected">http://purl.org/hpi/patchr#Rejected</seealso>
    let Rejected = Prefixed_Name(pat, "Rejected") |> PrefixedName
    /// <summary>
    ///   <para>pat:advocate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is deprecated and should not be used any more, rather use a positive confidence value for advocating agents.
    ///
    /// Links agents who support, i.e. vote for, a :Patch. Each time a user creates a patch request, appropriate provenance information is generated.</para>
    /// labels<para>advocate</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#advocate">http://purl.org/hpi/patchr#advocate</seealso>
    let advocate = Prefixed_Name(pat, "advocate") |> PrefixedName
    /// <summary>
    ///   <para>pat:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is deprecated and should not be used any more, use dcterms:description instead.
    ///
    /// A comment on the patch. This is likely just an informal message a user wants to share when submitting a Patch.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#comment">http://purl.org/hpi/patchr#comment</seealso>
    let comment = Prefixed_Name(pat, "comment") |> PrefixedName
    /// <summary>
    ///   <para>pat:criticiser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is deprecated and should not be used any more, rather use a negative confidence value for advocating agents.
    ///
    /// Links agents who disagree, i.e. vote against, a :Patch.</para>
    /// labels<para>criticiser</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#criticiser">http://purl.org/hpi/patchr#criticiser</seealso>
    let criticiser = Prefixed_Name(pat, "criticiser") |> PrefixedName
    /// <summary>
    ///   <para>pat:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a Patch to a PatchGroup. A Patch may be part of multiple :PatchGroups.</para>
    /// labels<para>memberOf</para></remarks>
    /// <seealso href="http://purl.org/hpi/patchr#memberOf">http://purl.org/hpi/patchr#memberOf</seealso>
    let memberOf = Prefixed_Name(pat, "memberOf") |> PrefixedName

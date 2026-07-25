namespace http.purl.org.wf4ever.ro.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ro =
    let _namespace_iri = Namespace_Iri ro |> NamespaceIRI
    /// <summary>
    ///   <para>ro:AggregatedAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An annotation aggregated within an ro:ResearchObject.
    ///
    /// Instances of this class are used to annotated resources aggregated within the aggregating research object, proxies of these resources, or the research object itself. In other words, if :ro is the ro:ResearchObject this annotation has been ore:isAggregatedBy, then the annotation should have at least one ao:annotatesResource which is an ore:AggregatedResource which is ore:isAggregatedBy :ro, or the annotated resource is an ore:Proxy which ore:proxyIn :ro, or the annotated resource is :ro.
    ///
    /// It is possible for the annotation to also annotate non-aggregated resources, but as above, at least one of them needs to be part of the RO or the RO itself.
    ///
    /// As a subclass of ro:SemanticAnnotation the ao:body must point to an rdfg:Graph which contains the actual annotation. </para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#AggregatedAnnotation">http://purl.org/wf4ever/ro#AggregatedAnnotation</seealso>
    let AggregatedAnnotation = Prefixed_Name(ro, "AggregatedAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>ro:ResearchObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A research object aggregates a number of resources. A resource can be a workflow, web service, document, data item, data set, workflow run, software or a research object.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#ResearchObject">http://purl.org/wf4ever/ro#ResearchObject</seealso>
    let ResearchObject = Prefixed_Name(ro, "ResearchObject") |> PrefixedName
    /// <summary>
    ///   <para>ro:Folder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ro:Folder is a special kind of ore:Aggregation where every ro:AggregatedResource must have a ro:FolderEntry proxy with a unique ro:entryName within that folder.
    ///
    /// Note that all resources which are aggregated within an (potentially nested) ro:Folder SHOULD also be aggregated by the same ro:ResearchObject this ro:Folder is aggregated within.
    ///
    /// Such folders can be nested and (optionally) used to organize the resources of the research object into a file-like structure. All such resources should also be aggregated by the ro:ResearchObject
    ///           </para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#Folder">http://purl.org/wf4ever/ro#Folder</seealso>
    let Folder = Prefixed_Name(ro, "Folder") |> PrefixedName
    /// <summary>
    ///   <para>ro:entryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This functional property specifies the name of a ro:FolderEntry within an ro:Folder.
    ///
    /// This name must be case-sensitively unique within the ro:Folder, similar to a filename in a directory.
    ///
    /// TODO: Need a functional property to specify the top level folder structure of an {{ro:ResearchObject}}?
    /// </para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#entryName">http://purl.org/wf4ever/ro#entryName</seealso>
    let entryName = Prefixed_Name(ro, "entryName") |> PrefixedName
    /// <summary>
    ///   <para>ro:SemanticAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ro:SemanticAnnotation is a specialisation of ao:Annotation which requires that ao:body points to an RDF Graph.
    ///
    /// This might be a Named Graph or a resource which can be resolved separately from the URI given by ao:body.
    ///
    /// This graph SHOULD mention the resources identified by ao:annotatesResource from this annotation, preferably by using their URIs as subject or object of statements.
    ///
    /// Note that this use of ao:body is distinct from ao:hasTopic, which also allows the association of a an RDF Graph with an ao:Annotation, but which also implies that this graph is the "topic" (subproperty of bookmark:hasTopic) of the annotated resource. This class does not require this interpretation, it is merely enough that the annotation body mentions the annotated resource, for instance to give it a dc:title or to relate two annotated resources.  Also note that the next version of the AO ontology (v2) might change this definition of ao:hasTopic, removing the need for this class.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#SemanticAnnotation">http://purl.org/wf4ever/ro#SemanticAnnotation</seealso>
    let SemanticAnnotation = Prefixed_Name(ro, "SemanticAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>ro:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ro:Resource is an ore:AggregatedResource which ore:isAggregatedBy an ro:ResearchObject.
    ///
    /// This specialisation requires that there exists an ore:Proxy which is ore:proxyFor this resource, and which is ore:proxyIn the same ro:ResearchObject the resource ore:isAggregatedBy. Any annotations on such a proxy will descrive the ro:Resource within that particular ro:ResearchObject, in particular dct:creator and dct:created on the proxy will specify who added the resource to the aggregation at what time.
    ///
    /// Note that annotations (ro:AggregatedAnnotation) can be added to both the ro:Resource and the ore:Proxy - depending on if the annotation is seen to be globally true (such as the provenance of how the resource was created) or locally true within the Research Object (such as the the resource playing the role of a wf4ever:Dataset).
    ///
    /// Not all resources aggregated by an ro:ResearchObject are ro:Resource instances, in particular ro:AggregatedAnnotations will also be aggregated, but will not be "true" RO resources (and thus don't need their own ore:Proxy).
    ///
    /// Aggregated resources MAY also be organised in (potentially nested) ro:Folders to reflect a file-system like structure. Note that any such resources SHOULD also be aggregated in the "mother" ro:ResearchObject.
    /// </para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#Resource">http://purl.org/wf4ever/ro#Resource</seealso>
    let Resource = Prefixed_Name(ro, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ro:FolderEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ro:FolderEntry is any ore:Proxy instance that associates a resources aggregated within an ro:Folder with a ro:entryName. This name is (case-sensitive) unique within a given folder.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#FolderEntry">http://purl.org/wf4ever/ro#FolderEntry</seealso>
    let FolderEntry = Prefixed_Name(ro, "FolderEntry") |> PrefixedName
    /// <summary>
    ///   <para>ro:Manifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ro:Manifest is used to describe an ro:ResearchObject. This identifies the resource for the manifest which lists all the aggregations of the research object, typically called ".ro/manifest.rdf" relative to the research object this manifest ore:describes.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#Manifest">http://purl.org/wf4ever/ro#Manifest</seealso>
    let Manifest = Prefixed_Name(ro, "Manifest") |> PrefixedName

    /// <summary>
    ///   <para>ro:annotatesAggregatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ro:annotatesAggregatedResource specifies that an ao:Annotation annotates an aggregated ro:Resource.
    ///
    /// When used on an ro:AggregatedAnnotation, both the domain and range of this property must ore:isAggregatedBy the same ro:ResearchObject.
    ///
    /// TODO: Should also ro:ResearchObject and ore:Proxy be in the range of this property, or is this subproperty even needed?
    /// </para>
    /// </remarks>
    /// <seealso href="http://purl.org/wf4ever/ro#annotatesAggregatedResource">http://purl.org/wf4ever/ro#annotatesAggregatedResource</seealso>
    let annotatesAggregatedResource =
        Prefixed_Name(ro, "annotatesAggregatedResource") |> PrefixedName

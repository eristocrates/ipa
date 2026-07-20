namespace http.advene.org.ns.cinelab.ld.hash

open DoxAletheia

module cl =
    let _namespace_name = "http://advene.org/ns/cinelab/ld#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Annotation"></see>
    /// </summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasAnnotationContent"></see>
    /// </summary>
    let hasAnnotationContent = _prefix "hasAnnotationContent"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Element"></see>
    /// </summary>
    let Element = _prefix "Element"
    /// <summary>
    /// Aspect of all elements supporting the :hasContent property
    /// <see href="http://advene.org/ns/cinelab/ld#WithContent"></see></summary>
    let WithContent = _prefix "WithContent"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#AnnotationType"></see>
    /// </summary>
    let AnnotationType = _prefix "AnnotationType"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Tag"></see>
    /// </summary>
    let Tag = _prefix "Tag"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Content"></see>
    /// </summary>
    let Content = _prefix "Content"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#FrameOfReference"></see>
    /// </summary>
    let FrameOfReference = _prefix "FrameOfReference"
    /// <summary>
    /// Aspect of all elements acting as collections of other elements
    /// <see href="http://advene.org/ns/cinelab/ld#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Import"></see>
    /// </summary>
    let Import = _prefix "Import"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#List"></see>
    /// </summary>
    let List = _prefix "List"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Media"></see>
    /// </summary>
    let Media = _prefix "Media"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Package"></see>
    /// </summary>
    let Package = _prefix "Package"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasElement"></see>
    /// </summary>
    let hasElement = _prefix "hasElement"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasAType"></see>
    /// </summary>
    let hasAType = _prefix "hasAType"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Relation"></see>
    /// </summary>
    let Relation = _prefix "Relation"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasRType"></see>
    /// </summary>
    let hasRType = _prefix "hasRType"
    /// <summary>
    /// Aspect of all elements able to transform other elements
    /// <see href="http://advene.org/ns/cinelab/ld#Pipe"></see></summary>
    let Pipe = _prefix "Pipe"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Query"></see>
    /// </summary>
    let Query = _prefix "Query"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#RelationType"></see>
    /// </summary>
    let RelationType = _prefix "RelationType"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Schema"></see>
    /// </summary>
    let Schema = _prefix "Schema"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Test"></see>
    /// </summary>
    let Test = _prefix "Test"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#View"></see>
    /// </summary>
    let View = _prefix "View"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#UserList"></see>
    /// </summary>
    let UserList = _prefix "UserList"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#UserTag"></see>
    /// </summary>
    let UserTag = _prefix "UserTag"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasContent"></see>
    /// </summary>
    let hasContent = _prefix "hasContent"
    /// <summary>
    /// A literal datatype to represent base64-encoded binary data.
    /// <see href="http://advene.org/ns/cinelab/ld#base64"></see></summary>
    let base64 = _prefix "base64"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#data"></see>
    /// </summary>
    let data = _prefix "data"
    /// <summary>
    /// Start-time of the fragment, in milliseconds.
    /// <see href="http://advene.org/ns/cinelab/ld#begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    /// End-time of the fragment, in milliseconds.
    /// <see href="http://advene.org/ns/cinelab/ld#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// This metadata of an annotation encodes the 'id' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimId"></see></summary>
    let fragDimId = _prefix "fragDimId"
    /// <summary>
    /// This metadata of an annotation encodes the 'track' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimTrack"></see></summary>
    let fragDimTrack = _prefix "fragDimTrack"
    /// <summary>
    /// This metadata of an annotation encodes the 'xywh' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimXywh"></see></summary>
    let fragDimXywh = _prefix "fragDimXywh"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#taggedWith"></see>
    /// </summary>
    let taggedWith = _prefix "taggedWith"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasFragment"></see>
    /// </summary>
    let hasFragment = _prefix "hasFragment"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasFrameOfReference"></see>
    /// </summary>
    let hasFrameOfReference = _prefix "hasFrameOfReference"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasImportedPackage"></see>
    /// </summary>
    let hasImportedPackage = _prefix "hasImportedPackage"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasItems"></see>
    /// </summary>
    let hasItems = _prefix "hasItems"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasMediaElement"></see>
    /// </summary>
    let hasMediaElement = _prefix "hasMediaElement"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasMembers"></see>
    /// </summary>
    let hasMembers = _prefix "hasMembers"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasModel"></see>
    /// </summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasPackage"></see>
    /// </summary>
    let hasPackage = _prefix "hasPackage"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#imports"></see>
    /// </summary>
    let imports = _prefix "imports"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#mimeType"></see>
    /// </summary>
    let mimeType = _prefix "mimeType"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#represents"></see>
    /// </summary>
    let represents = _prefix "represents"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#url"></see>
    /// </summary>
    let url = _prefix "url"

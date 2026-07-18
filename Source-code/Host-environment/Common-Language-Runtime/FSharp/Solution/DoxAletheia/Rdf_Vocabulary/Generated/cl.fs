namespace http.advene.org.ns.cinelab.ld.hash

open DoxAletheia.Rdf_Vocabulary

module cl =
    let _namespace_name = "http://advene.org/ns/cinelab/ld#"
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Annotation"></see>
    /// </summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasAnnotationContent"></see>
    /// </summary>
    let hasAnnotationContent =
        Namespaced_IRI.parse _namespace_name "hasAnnotationContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Element"></see>
    /// </summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName

    /// <summary>
    /// Aspect of all elements supporting the :hasContent property
    /// <see href="http://advene.org/ns/cinelab/ld#WithContent"></see></summary>
    let WithContent =
        Namespaced_IRI.parse _namespace_name "WithContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#AnnotationType"></see>
    /// </summary>
    let AnnotationType =
        Namespaced_IRI.parse _namespace_name "AnnotationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Tag"></see>
    /// </summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Content"></see>
    /// </summary>
    let Content = Namespaced_IRI.parse _namespace_name "Content" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#FrameOfReference"></see>
    /// </summary>
    let FrameOfReference =
        Namespaced_IRI.parse _namespace_name "FrameOfReference" |> NamespacedName

    /// <summary>
    /// Aspect of all elements acting as collections of other elements
    /// <see href="http://advene.org/ns/cinelab/ld#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Import"></see>
    /// </summary>
    let Import = Namespaced_IRI.parse _namespace_name "Import" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#List"></see>
    /// </summary>
    let List = Namespaced_IRI.parse _namespace_name "List" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Media"></see>
    /// </summary>
    let Media = Namespaced_IRI.parse _namespace_name "Media" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Package"></see>
    /// </summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasElement"></see>
    /// </summary>
    let hasElement = Namespaced_IRI.parse _namespace_name "hasElement" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasAType"></see>
    /// </summary>
    let hasAType = Namespaced_IRI.parse _namespace_name "hasAType" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Relation"></see>
    /// </summary>
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasRType"></see>
    /// </summary>
    let hasRType = Namespaced_IRI.parse _namespace_name "hasRType" |> NamespacedName
    /// <summary>
    /// Aspect of all elements able to transform other elements
    /// <see href="http://advene.org/ns/cinelab/ld#Pipe"></see></summary>
    let Pipe = Namespaced_IRI.parse _namespace_name "Pipe" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Query"></see>
    /// </summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#RelationType"></see>
    /// </summary>
    let RelationType =
        Namespaced_IRI.parse _namespace_name "RelationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Schema"></see>
    /// </summary>
    let Schema = Namespaced_IRI.parse _namespace_name "Schema" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#Test"></see>
    /// </summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#View"></see>
    /// </summary>
    let View = Namespaced_IRI.parse _namespace_name "View" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#UserList"></see>
    /// </summary>
    let UserList = Namespaced_IRI.parse _namespace_name "UserList" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#UserTag"></see>
    /// </summary>
    let UserTag = Namespaced_IRI.parse _namespace_name "UserTag" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasContent"></see>
    /// </summary>
    let hasContent = Namespaced_IRI.parse _namespace_name "hasContent" |> NamespacedName
    /// <summary>
    /// A literal datatype to represent base64-encoded binary data.
    /// <see href="http://advene.org/ns/cinelab/ld#base64"></see></summary>
    let base64 = Namespaced_IRI.parse _namespace_name "base64" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#data"></see>
    /// </summary>
    let data = Namespaced_IRI.parse _namespace_name "data" |> NamespacedName
    /// <summary>
    /// Start-time of the fragment, in milliseconds.
    /// <see href="http://advene.org/ns/cinelab/ld#begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName
    /// <summary>
    /// End-time of the fragment, in milliseconds.
    /// <see href="http://advene.org/ns/cinelab/ld#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    /// This metadata of an annotation encodes the 'id' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimId"></see></summary>
    let fragDimId = Namespaced_IRI.parse _namespace_name "fragDimId" |> NamespacedName

    /// <summary>
    /// This metadata of an annotation encodes the 'track' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimTrack"></see></summary>
    let fragDimTrack =
        Namespaced_IRI.parse _namespace_name "fragDimTrack" |> NamespacedName

    /// <summary>
    /// This metadata of an annotation encodes the 'xywh' dimension of its fragment.
    /// <see href="http://advene.org/ns/cinelab/ld#fragDimXywh"></see></summary>
    let fragDimXywh =
        Namespaced_IRI.parse _namespace_name "fragDimXywh" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#taggedWith"></see>
    /// </summary>
    let taggedWith = Namespaced_IRI.parse _namespace_name "taggedWith" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasFragment"></see>
    /// </summary>
    let hasFragment =
        Namespaced_IRI.parse _namespace_name "hasFragment" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasFrameOfReference"></see>
    /// </summary>
    let hasFrameOfReference =
        Namespaced_IRI.parse _namespace_name "hasFrameOfReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasImportedPackage"></see>
    /// </summary>
    let hasImportedPackage =
        Namespaced_IRI.parse _namespace_name "hasImportedPackage" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasItems"></see>
    /// </summary>
    let hasItems = Namespaced_IRI.parse _namespace_name "hasItems" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasMediaElement"></see>
    /// </summary>
    let hasMediaElement =
        Namespaced_IRI.parse _namespace_name "hasMediaElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasMembers"></see>
    /// </summary>
    let hasMembers = Namespaced_IRI.parse _namespace_name "hasMembers" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasModel"></see>
    /// </summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#hasPackage"></see>
    /// </summary>
    let hasPackage = Namespaced_IRI.parse _namespace_name "hasPackage" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#imports"></see>
    /// </summary>
    let imports = Namespaced_IRI.parse _namespace_name "imports" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#mimeType"></see>
    /// </summary>
    let mimeType = Namespaced_IRI.parse _namespace_name "mimeType" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#represents"></see>
    /// </summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    ///   <see href="http://advene.org/ns/cinelab/ld#url"></see>
    /// </summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

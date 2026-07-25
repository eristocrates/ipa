namespace http.advene.org.ns.cinelab.ld.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cinelab =
    let _namespace_iri = Namespace_Iri cinelab |> NamespaceIRI
    /// <summary>
    ///   <para>cinelab:hasRType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour type d'relation</para><para>has relation type</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasRType">http://advene.org/ns/cinelab/ld#hasRType</seealso>
    let hasRType = Prefixed_Name(cinelab, "hasRType") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Pipe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Aspect of all elements able to transform other elements</para>
    /// labels<para>Pipe</para><para>Tube</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Pipe">http://advene.org/ns/cinelab/ld#Pipe</seealso>
    let Pipe = Prefixed_Name(cinelab, "Pipe") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:RelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Type de Relation</para><para>Relation Type</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#RelationType">http://advene.org/ns/cinelab/ld#RelationType</seealso>
    let RelationType = Prefixed_Name(cinelab, "RelationType") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ressource</para><para>Resource</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Resource">http://advene.org/ns/cinelab/ld#Resource</seealso>
    let Resource = Prefixed_Name(cinelab, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Element</para><para>Élément</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Element">http://advene.org/ns/cinelab/ld#Element</seealso>
    let Element = Prefixed_Name(cinelab, "Element") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:FrameOfReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Frame of Reference</para><para>Référenciel</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#FrameOfReference">http://advene.org/ns/cinelab/ld#FrameOfReference</seealso>
    let FrameOfReference = Prefixed_Name(cinelab, "FrameOfReference") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Liste</para><para>List</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#List">http://advene.org/ns/cinelab/ld#List</seealso>
    let List = Prefixed_Name(cinelab, "List") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasAType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour type d'annotation</para><para>has annotation type</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasAType">http://advene.org/ns/cinelab/ld#hasAType</seealso>
    let hasAType = Prefixed_Name(cinelab, "hasAType") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relation</para><para>Relation</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Relation">http://advene.org/ns/cinelab/ld#Relation</seealso>
    let Relation = Prefixed_Name(cinelab, "Relation") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:hasAnnotationContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasAnnotationContent">http://advene.org/ns/cinelab/ld#hasAnnotationContent</seealso>
    let hasAnnotationContent =
        Prefixed_Name(cinelab, "hasAnnotationContent") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Aspect of all elements acting as collections of other elements</para>
    /// labels<para>Groupe</para><para>Group</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Group">http://advene.org/ns/cinelab/ld#Group</seealso>
    let Group = Prefixed_Name(cinelab, "Group") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:AnnotationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Type d'Annotation</para><para>Annotation Type</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#AnnotationType">http://advene.org/ns/cinelab/ld#AnnotationType</seealso>
    let AnnotationType = Prefixed_Name(cinelab, "AnnotationType") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Media</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Media</para><para>Média</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Media">http://advene.org/ns/cinelab/ld#Media</seealso>
    let Media = Prefixed_Name(cinelab, "Media") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Recueil</para><para>Package</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Package">http://advene.org/ns/cinelab/ld#Package</seealso>
    let Package = Prefixed_Name(cinelab, "Package") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Content</para><para>Contenu</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Content">http://advene.org/ns/cinelab/ld#Content</seealso>
    let Content = Prefixed_Name(cinelab, "Content") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Import</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Import</para><para>Import</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Import">http://advene.org/ns/cinelab/ld#Import</seealso>
    let Import = Prefixed_Name(cinelab, "Import") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour élément</para><para>has element</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasElement">http://advene.org/ns/cinelab/ld#hasElement</seealso>
    let hasElement = Prefixed_Name(cinelab, "hasElement") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Requête</para><para>Query</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Query">http://advene.org/ns/cinelab/ld#Query</seealso>
    let Query = Prefixed_Name(cinelab, "Query") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Test</para><para>Test</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Test">http://advene.org/ns/cinelab/ld#Test</seealso>
    let Test = Prefixed_Name(cinelab, "Test") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Schema</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Schéma</para><para>Schema</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Schema">http://advene.org/ns/cinelab/ld#Schema</seealso>
    let Schema = Prefixed_Name(cinelab, "Schema") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:UserList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Liste Utilisateur</para><para>User List</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#UserList">http://advene.org/ns/cinelab/ld#UserList</seealso>
    let UserList = Prefixed_Name(cinelab, "UserList") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:UserTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Tag Utilisateur</para><para>User Tag</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#UserTag">http://advene.org/ns/cinelab/ld#UserTag</seealso>
    let UserTag = Prefixed_Name(cinelab, "UserTag") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Start-time of the fragment, in milliseconds.</para>
    /// labels<para>a pour début</para><para>has begin</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#begin">http://advene.org/ns/cinelab/ld#begin</seealso>
    let begin_ = Prefixed_Name(cinelab, "begin") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>View</para><para>Vue</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#View">http://advene.org/ns/cinelab/ld#View</seealso>
    let View = Prefixed_Name(cinelab, "View") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour contenu</para><para>has content</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasContent">http://advene.org/ns/cinelab/ld#hasContent</seealso>
    let hasContent = Prefixed_Name(cinelab, "hasContent") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:base64</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>A literal datatype to represent base64-encoded binary data.</para>
    /// labels<para>données encodées en base64</para><para>base64 encoded data</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#base64">http://advene.org/ns/cinelab/ld#base64</seealso>
    let base64 = Prefixed_Name(cinelab, "base64") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>End-time of the fragment, in milliseconds.</para>
    /// labels<para>a pour fin</para><para>has end</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#end">http://advene.org/ns/cinelab/ld#end</seealso>
    let end_ = Prefixed_Name(cinelab, "end") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:fragDimId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This metadata of an annotation encodes the 'id' dimension of its fragment.</para>
    /// labels<para>Fragment Dimension 'id'</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#fragDimId">http://advene.org/ns/cinelab/ld#fragDimId</seealso>
    let fragDimId = Prefixed_Name(cinelab, "fragDimId") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:data</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>a pour valeur</para><para>has value</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#data">http://advene.org/ns/cinelab/ld#data</seealso>
    let data = Prefixed_Name(cinelab, "data") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:fragDimTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This metadata of an annotation encodes the 'track' dimension of its fragment.</para>
    /// labels<para>Fragment Dimension 'track'</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#fragDimTrack">http://advene.org/ns/cinelab/ld#fragDimTrack</seealso>
    let fragDimTrack = Prefixed_Name(cinelab, "fragDimTrack") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour éléments</para><para>has items</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasItems">http://advene.org/ns/cinelab/ld#hasItems</seealso>
    let hasItems = Prefixed_Name(cinelab, "hasItems") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:fragDimXywh</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This metadata of an annotation encodes the 'xywh' dimension of its fragment.</para>
    /// labels<para>Fragment Dimension 'xywh'</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#fragDimXywh">http://advene.org/ns/cinelab/ld#fragDimXywh</seealso>
    let fragDimXywh = Prefixed_Name(cinelab, "fragDimXywh") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:hasFrameOfReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>has frame of reference</para><para>a pour référenciel</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasFrameOfReference">http://advene.org/ns/cinelab/ld#hasFrameOfReference</seealso>
    let hasFrameOfReference =
        Prefixed_Name(cinelab, "hasFrameOfReference") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:hasMediaElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour élément média</para><para>has media element</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasMediaElement">http://advene.org/ns/cinelab/ld#hasMediaElement</seealso>
    let hasMediaElement = Prefixed_Name(cinelab, "hasMediaElement") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour recueil</para><para>has package</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasPackage">http://advene.org/ns/cinelab/ld#hasPackage</seealso>
    let hasPackage = Prefixed_Name(cinelab, "hasPackage") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:taggedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>tagged with</para><para>tagué avec</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#taggedWith">http://advene.org/ns/cinelab/ld#taggedWith</seealso>
    let taggedWith = Prefixed_Name(cinelab, "taggedWith") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour fragment</para><para>has fragment</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasFragment">http://advene.org/ns/cinelab/ld#hasFragment</seealso>
    let hasFragment = Prefixed_Name(cinelab, "hasFragment") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:hasImportedPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour recueil importé</para><para>has imported package</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasImportedPackage">http://advene.org/ns/cinelab/ld#hasImportedPackage</seealso>
    let hasImportedPackage =
        Prefixed_Name(cinelab, "hasImportedPackage") |> PrefixedName

    /// <summary>
    ///   <para>cinelab:hasMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>a pour membres</para><para>has members</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasMembers">http://advene.org/ns/cinelab/ld#hasMembers</seealso>
    let hasMembers = Prefixed_Name(cinelab, "hasMembers") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:mimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour type MIME</para><para>has MIME type</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#mimeType">http://advene.org/ns/cinelab/ld#mimeType</seealso>
    let mimeType = Prefixed_Name(cinelab, "mimeType") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>URL</para><para>URL</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#url">http://advene.org/ns/cinelab/ld#url</seealso>
    let url = Prefixed_Name(cinelab, "url") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>a pour modèle de contenu</para><para>has content model</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#hasModel">http://advene.org/ns/cinelab/ld#hasModel</seealso>
    let hasModel = Prefixed_Name(cinelab, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imports</para><para>importe</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#imports">http://advene.org/ns/cinelab/ld#imports</seealso>
    let imports = Prefixed_Name(cinelab, "imports") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>représente</para><para>represents</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#represents">http://advene.org/ns/cinelab/ld#represents</seealso>
    let represents = Prefixed_Name(cinelab, "represents") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Annotation</para><para>Annotation</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Annotation">http://advene.org/ns/cinelab/ld#Annotation</seealso>
    let Annotation = Prefixed_Name(cinelab, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:WithContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Aspect of all elements supporting the :hasContent property</para>
    /// labels<para>Ayant un Contenu</para><para>With Content</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#WithContent">http://advene.org/ns/cinelab/ld#WithContent</seealso>
    let WithContent = Prefixed_Name(cinelab, "WithContent") |> PrefixedName
    /// <summary>
    ///   <para>cinelab:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tag</para><para>Tag</para></remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld#Tag">http://advene.org/ns/cinelab/ld#Tag</seealso>
    let Tag = Prefixed_Name(cinelab, "Tag") |> PrefixedName

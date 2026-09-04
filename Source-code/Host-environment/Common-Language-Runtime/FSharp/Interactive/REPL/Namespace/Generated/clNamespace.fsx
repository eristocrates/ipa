#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://advene.org/ns/cinelab/ld#" "cl"
    /// <summary>
    ///   <para>rdfs:label : Annotationrdfs:label : Annotation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Annotation">cl:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : Annotation Typerdfs:label : Type d'Annotation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#AnnotationType">cl:AnnotationType</a>
    /// </summary>
    let AnnotationType = _prefixId.prefix "AnnotationType"
    /// <summary>
    ///   <para>rdfs:label : Contentrdfs:label : Contenu</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Content">cl:Content</a>
    /// </summary>
    let Content = _prefixId.prefix "Content"
    /// <summary>
    ///   <para>rdfs:label : Elementrdfs:label : Élément</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Element">cl:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:label : Frame of Referencerdfs:label : Référenciel</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#FrameOfReference">cl:FrameOfReference</a>
    /// </summary>
    let FrameOfReference = _prefixId.prefix "FrameOfReference"
    /// <summary>
    ///   <para>rdfs:label : Grouprdfs:label : Groupe</para>
    ///   <para>rdfs:comment : Aspect of all elements acting as collections of other elements</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Group">cl:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Importrdfs:label : Import</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Import">cl:Import</a>
    /// </summary>
    let Import = _prefixId.prefix "Import"
    /// <summary>
    ///   <para>rdfs:label : Listrdfs:label : Liste</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#List">cl:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:label : Mediardfs:label : Média</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Media">cl:Media</a>
    /// </summary>
    let Media = _prefixId.prefix "Media"
    /// <summary>
    ///   <para>rdfs:label : Packagerdfs:label : Recueil</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Package">cl:Package</a>
    /// </summary>
    let Package = _prefixId.prefix "Package"
    /// <summary>
    ///   <para>rdfs:label : Piperdfs:label : Tube</para>
    ///   <para>rdfs:comment : Aspect of all elements able to transform other elements</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Pipe">cl:Pipe</a>
    /// </summary>
    let Pipe = _prefixId.prefix "Pipe"
    /// <summary>
    ///   <para>rdfs:label : Queryrdfs:label : Requête</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Query">cl:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    /// <summary>
    ///   <para>rdfs:label : Relationrdfs:label : Relation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Relation">cl:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:label : Relation Typerdfs:label : Type de Relation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#RelationType">cl:RelationType</a>
    /// </summary>
    let RelationType = _prefixId.prefix "RelationType"
    /// <summary>
    ///   <para>rdfs:label : Resourcerdfs:label : Ressource</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Resource">cl:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Schemardfs:label : Schéma</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Schema">cl:Schema</a>
    /// </summary>
    let Schema = _prefixId.prefix "Schema"
    /// <summary>
    ///   <para>rdfs:label : Tagrdfs:label : Tag</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Tag">cl:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:label : Testrdfs:label : Test</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#Test">cl:Test</a>
    /// </summary>
    let Test = _prefixId.prefix "Test"
    /// <summary>
    ///   <para>rdfs:label : User Listrdfs:label : Liste Utilisateur</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#UserList">cl:UserList</a>
    /// </summary>
    let UserList = _prefixId.prefix "UserList"
    /// <summary>
    ///   <para>rdfs:label : User Tagrdfs:label : Tag Utilisateur</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#UserTag">cl:UserTag</a>
    /// </summary>
    let UserTag = _prefixId.prefix "UserTag"
    /// <summary>
    ///   <para>rdfs:label : Viewrdfs:label : Vue</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#View">cl:View</a>
    /// </summary>
    let View = _prefixId.prefix "View"
    /// <summary>
    ///   <para>rdfs:label : With Contentrdfs:label : Ayant un Contenu</para>
    ///   <para>rdfs:comment : Aspect of all elements supporting the :hasContent property</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#WithContent">cl:WithContent</a>
    /// </summary>
    let WithContent = _prefixId.prefix "WithContent"
    let base64 = _prefixId.prefix "base64"
    /// <summary>
    ///   <para>rdfs:label : has beginrdfs:label : a pour début</para>
    ///   <para>rdfs:comment : Start-time of the fragment, in milliseconds.</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#begin">cl:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : has valuerdfs:label : a pour valeur</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#data">cl:data</a>
    /// </summary>
    let data = _prefixId.prefix "data"
    /// <summary>
    ///   <para>rdfs:label : has endrdfs:label : a pour fin</para>
    ///   <para>rdfs:comment : End-time of the fragment, in milliseconds.</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#end">cl:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : Fragment Dimension 'id'^^xsd:string</para>
    ///   <para>rdfs:comment : This metadata of an annotation encodes the 'id' dimension of its fragment.</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#fragDimId">cl:fragDimId</a>
    /// </summary>
    let fragDimId = _prefixId.prefix "fragDimId"
    /// <summary>
    ///   <para>rdfs:label : Fragment Dimension 'track'^^xsd:string</para>
    ///   <para>rdfs:comment : This metadata of an annotation encodes the 'track' dimension of its fragment.</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#fragDimTrack">cl:fragDimTrack</a>
    /// </summary>
    let fragDimTrack = _prefixId.prefix "fragDimTrack"
    /// <summary>
    ///   <para>rdfs:label : Fragment Dimension 'xywh'^^xsd:string</para>
    ///   <para>rdfs:comment : This metadata of an annotation encodes the 'xywh' dimension of its fragment.</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#fragDimXywh">cl:fragDimXywh</a>
    /// </summary>
    let fragDimXywh = _prefixId.prefix "fragDimXywh"
    /// <summary>
    ///   <para>rdfs:label : has annotation typerdfs:label : a pour type d'annotation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasAType">cl:hasAType</a>
    /// </summary>
    let hasAType = _prefixId.prefix "hasAType"
    let hasAnnotationContent = _prefixId.prefix "hasAnnotationContent"
    /// <summary>
    ///   <para>rdfs:label : has contentrdfs:label : a pour contenu</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasContent">cl:hasContent</a>
    /// </summary>
    let hasContent = _prefixId.prefix "hasContent"
    /// <summary>
    ///   <para>rdfs:label : has elementrdfs:label : a pour élément</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasElement">cl:hasElement</a>
    /// </summary>
    let hasElement = _prefixId.prefix "hasElement"
    /// <summary>
    ///   <para>rdfs:label : has fragmentrdfs:label : a pour fragment</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasFragment">cl:hasFragment</a>
    /// </summary>
    let hasFragment = _prefixId.prefix "hasFragment"
    /// <summary>
    ///   <para>rdfs:label : has frame of referencerdfs:label : a pour référenciel</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasFrameOfReference">cl:hasFrameOfReference</a>
    /// </summary>
    let hasFrameOfReference = _prefixId.prefix "hasFrameOfReference"
    /// <summary>
    ///   <para>rdfs:label : has imported packagerdfs:label : a pour recueil importé</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasImportedPackage">cl:hasImportedPackage</a>
    /// </summary>
    let hasImportedPackage = _prefixId.prefix "hasImportedPackage"
    /// <summary>
    ///   <para>rdfs:label : has itemsrdfs:label : a pour éléments</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasItems">cl:hasItems</a>
    /// </summary>
    let hasItems = _prefixId.prefix "hasItems"
    /// <summary>
    ///   <para>rdfs:label : has media elementrdfs:label : a pour élément média</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasMediaElement">cl:hasMediaElement</a>
    /// </summary>
    let hasMediaElement = _prefixId.prefix "hasMediaElement"
    /// <summary>
    ///   <para>rdfs:label : has membersrdfs:label : a pour membres</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasMembers">cl:hasMembers</a>
    /// </summary>
    let hasMembers = _prefixId.prefix "hasMembers"
    /// <summary>
    ///   <para>rdfs:label : has content modelrdfs:label : a pour modèle de contenu</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasModel">cl:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : has packagerdfs:label : a pour recueil</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasPackage">cl:hasPackage</a>
    /// </summary>
    let hasPackage = _prefixId.prefix "hasPackage"
    /// <summary>
    ///   <para>rdfs:label : has relation typerdfs:label : a pour type d'relation</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#hasRType">cl:hasRType</a>
    /// </summary>
    let hasRType = _prefixId.prefix "hasRType"
    /// <summary>
    ///   <para>rdfs:label : importsrdfs:label : importe</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#imports">cl:imports</a>
    /// </summary>
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:label : has MIME typerdfs:label : a pour type MIME</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#mimeType">cl:mimeType</a>
    /// </summary>
    let mimeType = _prefixId.prefix "mimeType"
    /// <summary>
    ///   <para>rdfs:label : representsrdfs:label : représente</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#represents">cl:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:label : tagged withrdfs:label : tagué avec</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#taggedWith">cl:taggedWith</a>
    /// </summary>
    let taggedWith = _prefixId.prefix "taggedWith"
    /// <summary>
    ///   <para>rdfs:label : URLrdfs:label : URL</para>
    ///   <a href="http://advene.org/ns/cinelab/ld#url">cl:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"

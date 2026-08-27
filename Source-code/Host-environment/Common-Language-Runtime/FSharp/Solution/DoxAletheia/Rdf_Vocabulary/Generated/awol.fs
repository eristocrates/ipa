namespace http.bblfish.net.work.atom_owl._2006_06_06.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module awol =
    let _namespace_iri = Namespace_Iri awol |> NamespaceIRI
    /// <summary>
    ///   <para>atomowl:#Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.2.2 of rfc 4287. A Category Type"</para>
    /// labels<para>"Category Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Category">http://bblfish.net/work/atom-owl/2006-06-06/#Category</seealso>
    let Category = Prefixed_Name(awol, "Category") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.1.3 in rfc 4287 One way to think of this is as a class that represents what one can get from an HTTP connection. It has a body, and a number of headers, info such as mime-type, content-lenght, etc... ."</para>
    /// labels<para>"Content Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Content">http://bblfish.net/work/atom-owl/2006-06-06/#Content</seealso>
    let Content = Prefixed_Name(awol, "Content") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.1.2 of the rfc 4287 spec"</para>
    /// labels<para>"Entry Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Entry">http://bblfish.net/work/atom-owl/2006-06-06/#Entry</seealso>
    let Entry = Prefixed_Name(awol, "Entry") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Feed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Container for feed metadata."</para>
    /// labels<para>"Feed Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Feed">http://bblfish.net/work/atom-owl/2006-06-06/#Feed</seealso>
    let Feed = Prefixed_Name(awol, "Feed") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#FeedOrEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Union of the Feed and Entry class. Simplifies writing the ontology."</para>
    /// labels<para>"FeedOrEntry Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry">http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry</seealso>
    let FeedOrEntry = Prefixed_Name(awol, "FeedOrEntry") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.2.4 of rfc 4287 spec. Generator for the Feed. It has many properties in common with awol:Person"</para>
    /// labels<para>"Generator of feed"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Generator">http://bblfish.net/work/atom-owl/2006-06-06/#Generator</seealso>
    let Generator = Prefixed_Name(awol, "Generator") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#HTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §3.1.1.2 of rfc 4287. The class of html strings"</para>
    /// labels<para>"Html content class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#HTML">http://bblfish.net/work/atom-owl/2006-06-06/#HTML</seealso>
    let HTML = Prefixed_Name(awol, "HTML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.2.7 of rfc 4287 spec. Note that the href, hreflang and lengtlength attributes of rfc 4287 have been moved to the content class and a content relation from the Link to a Content class has been made. The href is translated onto the awol:src relation of the Content class. A link is a reified relation between an entry an a content, for the purpose of adding some metadata such as a title. If it is a reified statement, it is a special type of such a statement, one that implies always the reified statement itself (see N3 rule)"</para>
    /// labels<para>"Link Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Link">http://bblfish.net/work/atom-owl/2006-06-06/#Link</seealso>
    let Link = Prefixed_Name(awol, "Link") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §3.2 of rfc 4287 spec."</para>
    /// labels<para>"Person Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Person">http://bblfish.net/work/atom-owl/2006-06-06/#Person</seealso>
    let Person = Prefixed_Name(awol, "Person") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#PlainText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §3.1.1.1 of rfc 4287. The datatype of simple text elements. Essentially this is the class of all plain text literals."</para>
    /// labels<para>"Plain text content class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#PlainText">http://bblfish.net/work/atom-owl/2006-06-06/#PlainText</seealso>
    let PlainText = Prefixed_Name(awol, "PlainText") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#RelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.2.7.2 of rfc 4287. Relation types are registered, or can be created as described in rfc 4287. They are special types of properties that relate awol:Versions to :Contents."</para>
    /// labels<para>"Relation Type Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#RelationType">http://bblfish.net/work/atom-owl/2006-06-06/#RelationType</seealso>
    let RelationType = Prefixed_Name(awol, "RelationType") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#TextContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §3.1 of rfc 4287. The text constructs."</para>
    /// labels<para>"All Text Content Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#TextContent">http://bblfish.net/work/atom-owl/2006-06-06/#TextContent</seealso>
    let TextContent = Prefixed_Name(awol, "TextContent") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metadata about the state of  a resource with given awol:id at an :updated time."</para>
    /// labels<para>"Version Class"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Version">http://bblfish.net/work/atom-owl/2006-06-06/#Version</seealso>
    let Version = Prefixed_Name(awol, "Version") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#XHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §3.1.1.3 of rfc 4287. The datatype of xhtml strings"</para>
    /// labels<para>"Xhtml content class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#XHTML">http://bblfish.net/work/atom-owl/2006-06-06/#XHTML</seealso>
    let XHTML = Prefixed_Name(awol, "XHTML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#XML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"see §4.1.3.3 of rfc 4287. The datatype of xml content"</para>
    /// labels<para>"XML content class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#XML">http://bblfish.net/work/atom-owl/2006-06-06/#XML</seealso>
    let XML = Prefixed_Name(awol, "XML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#aggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The feed aggregates this given Entry.  See §4.1.1 of rfc4287. This means that the entry does not have the feed as its source. The entry was taken from a different feed."</para>
    /// labels<para>"aggregates"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#aggregates">http://bblfish.net/work/atom-owl/2006-06-06/#aggregates</seealso>
    let aggregates = Prefixed_Name(awol, "aggregates") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.1 rfc 4287 spec."</para>
    /// labels<para>"author"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#author">http://bblfish.net/work/atom-owl/2006-06-06/#author</seealso>
    let author = Prefixed_Name(awol, "author") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"the body of the content."</para>
    /// labels<para>"body relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#body">http://bblfish.net/work/atom-owl/2006-06-06/#body</seealso>
    let body = Prefixed_Name(awol, "body") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.2. A category with which the conainer is associated."</para>
    /// labels<para>"category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#category">http://bblfish.net/work/atom-owl/2006-06-06/#category</seealso>
    let category = Prefixed_Name(awol, "category") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The feed contains the given Entry. See §4.1.1 of rfc4287. This makes no statement about whether that Entry has the awol:Feed as its source."</para>
    /// labels<para>"contains relation"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#contains">http://bblfish.net/work/atom-owl/2006-06-06/#contains</seealso>
    let contains = Prefixed_Name(awol, "contains") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.1.3 of rfc 4287 spec. The content of an Entry, a Link or any of the relation types that are the object of awol:rel properties"</para>
    /// labels<para>"content"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#content">http://bblfish.net/work/atom-owl/2006-06-06/#content</seealso>
    let content = Prefixed_Name(awol, "content") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.3 of rfc 4287 spec. Someone who contributed to the Version."</para>
    /// labels<para>"contributor"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#contributor">http://bblfish.net/work/atom-owl/2006-06-06/#contributor</seealso>
    let contributor = Prefixed_Name(awol, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#dannyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A comment by Danny Ayers"</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote">http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote</seealso>
    let dannyNote = Prefixed_Name(awol, "dannyNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#eliasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A comment by Elias Torres"</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote">http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote</seealso>
    let eliasNote = Prefixed_Name(awol, "eliasNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"see §3.2.3 of rfc 4287. A mailbox of the Person"</para>
    /// labels<para>"email address"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#email">http://bblfish.net/work/atom-owl/2006-06-06/#email</seealso>
    let email = Prefixed_Name(awol, "email") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The feed contains the given Entry and that Entry has the feed as its source. See §4.1.1 of rfc 4287. This relation is a little bit more specialised than the rfc 4287 entry element. It relates only awol:Feed objects to :Entry objects where the :Feed is a :source of the :Entry. See also the :source and :contains relations. "</para>
    /// labels<para>"entry relation"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#entry">http://bblfish.net/work/atom-owl/2006-06-06/#entry</seealso>
    let entry = Prefixed_Name(awol, "entry") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.4 of rfc 4287. The generator of the object"</para>
    /// labels<para>"generator"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#generator">http://bblfish.net/work/atom-owl/2006-06-06/#generator</seealso>
    let generator = Prefixed_Name(awol, "generator") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#generatorVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"see §4.2.4 of rfc 4287. Indicates the version of the Generator"</para>
    /// labels<para>"generatorVersion"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion">http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion</seealso>
    let generatorVersion = Prefixed_Name(awol, "generatorVersion") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#html</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"see §3.1.1.2 of rfc 4287. The datatype of html text elements. It is considered to be a relation to the text."</para>
    /// labels<para>"html value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#html">http://bblfish.net/work/atom-owl/2006-06-06/#html</seealso>
    let html = Prefixed_Name(awol, "html") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"see 4.2.5 of rfc 4287. An icon associated with the object"</para>
    /// labels<para>"icon"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#icon">http://bblfish.net/work/atom-owl/2006-06-06/#icon</seealso>
    let icon = Prefixed_Name(awol, "icon") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"See §4.2.6 rfc 4287 spec. All Versions with the same id can be considered to be versions of the resource identified by the id. The id mentions the resource of which it is a representation. "</para>
    /// labels<para>"id"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#id">http://bblfish.net/work/atom-owl/2006-06-06/#id</seealso>
    let id = Prefixed_Name(awol, "id") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.2.3 of rfc 4287. A Human readable label for display."</para>
    /// labels<para>"label"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#label">http://bblfish.net/work/atom-owl/2006-06-06/#label</seealso>
    let label = Prefixed_Name(awol, "label") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.7.4 of rfc 4287. The language of the representation."</para>
    /// labels<para>"language"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#lang">http://bblfish.net/work/atom-owl/2006-06-06/#lang</seealso>
    let lang = Prefixed_Name(awol, "lang") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.7.6 of rfc 4287. The length in bytes of the representation."</para>
    /// labels<para>"length in bytes"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#length">http://bblfish.net/work/atom-owl/2006-06-06/#length</seealso>
    let length = Prefixed_Name(awol, "length") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.7 of rfc 4287 spec. A link associated with the container. If the link is unreified, we have a relation from the container to some resource"</para>
    /// labels<para>"link"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#link">http://bblfish.net/work/atom-owl/2006-06-06/#link</seealso>
    let link = Prefixed_Name(awol, "link") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"see §4.2.8 of rfc 4287. An icon associated with the object"</para>
    /// labels<para>"logo"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#logo">http://bblfish.net/work/atom-owl/2006-06-06/#logo</seealso>
    let logo = Prefixed_Name(awol, "logo") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"see §4.2.4 of rfc 4287. A name for the Generator. "</para>
    ///   <para>"see §3.2.1 of rfc 4287. A human readable name for the Person."</para>
    /// labels<para>"name"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#name">http://bblfish.net/work/atom-owl/2006-06-06/#name</seealso>
    let name = Prefixed_Name(awol, "name") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"See §4.2.9 of rfc 4287 spec. A date associated with an event early in the lifecyle of the subject."</para>
    /// labels<para>"publication date"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#published">http://bblfish.net/work/atom-owl/2006-06-06/#published</seealso>
    let published = Prefixed_Name(awol, "published") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#rel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"see §4.2.7.2 of rfc 4287. The relationship type. The relationship type is a property that relates a awol:Version to a :Content "</para>
    /// labels<para>"relation type"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#rel">http://bblfish.net/work/atom-owl/2006-06-06/#rel</seealso>
    let rel = Prefixed_Name(awol, "rel") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#retosNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A comment by Reto Bachmann-Gmuer"</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#retosNote">http://bblfish.net/work/atom-owl/2006-06-06/#retosNote</seealso>
    let retosNote = Prefixed_Name(awol, "retosNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"See §4.2.10 of rfc 4287 spec. Rights held over a Version."</para>
    /// labels<para>"rights"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#rights">http://bblfish.net/work/atom-owl/2006-06-06/#rights</seealso>
    let rights = Prefixed_Name(awol, "rights") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.2.2 of rfc 4287. Identifies a categorization scheme."</para>
    /// labels<para>"catgegorization scheme"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#scheme">http://bblfish.net/work/atom-owl/2006-06-06/#scheme</seealso>
    let scheme = Prefixed_Name(awol, "scheme") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.11 of rfc 4287 spec. The source feed where the entry was found"</para>
    /// labels<para>"source feed"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#source">http://bblfish.net/work/atom-owl/2006-06-06/#source</seealso>
    let source = Prefixed_Name(awol, "source") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#src</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a source of the representation"</para>
    /// labels<para>"source"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#src">http://bblfish.net/work/atom-owl/2006-06-06/#src</seealso>
    let src = Prefixed_Name(awol, "src") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the inverse of the awol:link relation, not specified in rfc 4287, but added here for convenience"</para>
    /// labels<para>"the object of the link"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#subject">http://bblfish.net/work/atom-owl/2006-06-06/#subject</seealso>
    let subject = Prefixed_Name(awol, "subject") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.12 of rfc 4287. Subtitle of the feed."</para>
    /// labels<para>"subtitle"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#subtitle">http://bblfish.net/work/atom-owl/2006-06-06/#subtitle</seealso>
    let subtitle = Prefixed_Name(awol, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"See §4.2.13 of rfc 4287 spec. A summary of the content of the Entry"</para>
    /// labels<para>"summary"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#summary">http://bblfish.net/work/atom-owl/2006-06-06/#summary</seealso>
    let summary = Prefixed_Name(awol, "summary") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.2.1 of rfc 4287. Identifies the category"</para>
    /// labels<para>"term"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#term">http://bblfish.net/work/atom-owl/2006-06-06/#term</seealso>
    let term = Prefixed_Name(awol, "term") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"see §3.1.1.1 of rfc 4287. The datatype of xhtml text elements"</para>
    /// labels<para>"text type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#text">http://bblfish.net/work/atom-owl/2006-06-06/#text</seealso>
    let text = Prefixed_Name(awol, "text") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"See §4.2.14. Title of a container"</para>
    /// labels<para>"title"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#title">http://bblfish.net/work/atom-owl/2006-06-06/#title</seealso>
    let title = Prefixed_Name(awol, "title") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the object of a link. We interpret here a Link to be a re-ified relation from a awol:Version to a :Content object. The relation is re-ified in order to add a :title relation to the link. This can probably usually be safely ignored"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"to"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#to">http://bblfish.net/work/atom-owl/2006-06-06/#to</seealso>
    let to_ = Prefixed_Name(awol, "to") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"see §4.2.7.3 of rfc 4287. The mime type of the representation."</para>
    /// labels<para>"mime type"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#type">http://bblfish.net/work/atom-owl/2006-06-06/#type</seealso>
    let type_ = Prefixed_Name(awol, "type") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#updated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"See §4.2.15 of rfc 4287 spec. Indicates the most recent instant in time when a resource with the given id was modified in a way the publisher considers significant. Therefore, not all modifications necessarily result in a changed atom:updated value."</para>
    /// labels<para>"updated"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#updated">http://bblfish.net/work/atom-owl/2006-06-06/#updated</seealso>
    let updated = Prefixed_Name(awol, "updated") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"see §4.2.4 of rfc 4287. A uri associated the Generator"</para>
    ///   <para>"see §3.2.2 of rfc 4287. A uri associated the Person"</para>
    /// labels<para>"a uri"</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#uri">http://bblfish.net/work/atom-owl/2006-06-06/#uri</seealso>
    let uri = Prefixed_Name(awol, "uri") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#xhtml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"see §3.1.1.3 of rfc 4287. The datatype of xhtml text elements."</para>
    /// labels<para>"xhtml type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#xhtml">http://bblfish.net/work/atom-owl/2006-06-06/#xhtml</seealso>
    let xhtml = Prefixed_Name(awol, "xhtml") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#xml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"see §4.1.3.1 of rfc 4287. Relates an awol:XML object to its content."</para>
    /// labels<para>"xml type relation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#xml">http://bblfish.net/work/atom-owl/2006-06-06/#xml</seealso>
    let xml = Prefixed_Name(awol, "xml") |> PrefixedName

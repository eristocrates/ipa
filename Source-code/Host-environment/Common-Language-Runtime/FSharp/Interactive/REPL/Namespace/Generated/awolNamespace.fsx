#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module awol =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://bblfish.net/work/atom-owl/2006-06-06/#" "awol"

    /// <summary>
    ///   <para>rdfs:label : Category Class^^xsd:string</para>
    ///   <para>rdfs:comment : see §4.2.2 of rfc 4287. A Category Type</para>
    ///   <para>awol:retosNote : The construct with term and scheme looks very much like a URI-Ref used in RDF. Isn't this just any rdfs:Resource? Maybe skos:Concept could be used as range of :category.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Category">awol:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Content Class</para>
    ///   <para>rdfs:comment : see §4.1.3 in rfc 4287 One way to think of this is as a class that represents what one can get from an HTTP connection. It has a body, and a number of headers, info such as mime-type, content-lenght, etc... .</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Content">awol:Content</a>
    /// </summary>
    let Content = _prefixId.prefix "Content"
    /// <summary>
    ///   <para>rdfs:label : Entry Class</para>
    ///   <para>rdfs:comment : see §4.1.2 of the rfc 4287 spec</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Entry">awol:Entry</a>
    /// </summary>
    let Entry = _prefixId.prefix "Entry"
    /// <summary>
    ///   <para>rdfs:label : Feed Class</para>
    ///   <para>rdfs:comment : Container for feed metadata.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Feed">awol:Feed</a>
    /// </summary>
    let Feed = _prefixId.prefix "Feed"
    /// <summary>
    ///   <para>skos:editorialNote : This class should probably be anonymous. It is really only used to make it easier to write the ontology, as it is helps regroup all the relations that are in common between a awol:Feed and an :Entry.^^xsd:string</para>
    ///   <para>rdfs:label : FeedOrEntry Class</para>
    ///   <para>rdfs:comment : Union of the Feed and Entry class. Simplifies writing the ontology.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry">awol:FeedOrEntry</a>
    /// </summary>
    let FeedOrEntry = _prefixId.prefix "FeedOrEntry"
    /// <summary>
    ///   <para>rdfs:label : Generator of feed</para>
    ///   <para>rdfs:comment : see §4.2.4 of rfc 4287 spec. Generator for the Feed. It has many properties in common with awol:Person</para>
    ///   <para>awol:retosNote : is this an instance of the piece of software or the program itself? which is the agent</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Generator">awol:Generator</a>
    /// </summary>
    let Generator = _prefixId.prefix "Generator"
    /// <summary>
    ///   <para>rdfs:label : Html content class^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.2 of rfc 4287. The class of html strings</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#HTML">awol:HTML</a>
    /// </summary>
    let HTML = _prefixId.prefix "HTML"
    /// <summary>
    ///   <para>rdfs:label : Link Class</para>
    ///   <para>rdfs:comment : see §4.2.7 of rfc 4287 spec. Note that the href, hreflang and lengtlength attributes of rfc 4287 have been moved to the content class and a content relation from the Link to a Content class has been made. The href is translated onto the awol:src relation of the Content class. A link is a reified relation between an entry an a content, for the purpose of adding some metadata such as a title. If it is a reified statement, it is a special type of such a statement, one that implies always the reified statement itself (see N3 rule)</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Link">awol:Link</a>
    /// </summary>
    let Link = _prefixId.prefix "Link"
    /// <summary>
    ///   <para>rdfs:label : Person Class</para>
    ///   <para>rdfs:comment : see §3.2 of rfc 4287 spec.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Person">awol:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Plain text content class^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.1 of rfc 4287. The datatype of simple text elements. Essentially this is the class of all plain text literals.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#PlainText">awol:PlainText</a>
    /// </summary>
    let PlainText = _prefixId.prefix "PlainText"
    /// <summary>
    ///   <para>rdfs:label : Relation Type Class</para>
    ///   <para>rdfs:comment : see §4.2.7.2 of rfc 4287. Relation types are registered, or can be created as described in rfc 4287. They are special types of properties that relate awol:Versions to :Contents.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#RelationType">awol:RelationType</a>
    /// </summary>
    let RelationType = _prefixId.prefix "RelationType"
    /// <summary>
    ///   <para>skos:editorialNote : Should awol:TextContent really be a sublcass of :Content ? If it is then all the properties that apply to text will also apply to :Content. If we want a :Content to be able to take properties such as :etag, this does not seem quite relevant to anything that is related to what should be the object of :title, :subtitle or :summary. Neither does :src really seem to be a relation that really makes sense there^^xsd:string</para>
    ///   <para>rdfs:label : All Text Content Class</para>
    ///   <para>rdfs:comment : see §3.1 of rfc 4287. The text constructs.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#TextContent">awol:TextContent</a>
    /// </summary>
    let TextContent = _prefixId.prefix "TextContent"
    /// <summary>
    ///   <para>rdfs:label : Version Class</para>
    ///   <para>rdfs:comment : Metadata about the state of  a resource with given awol:id at an :updated time.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#Version">awol:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:label : Xhtml content class^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.3 of rfc 4287. The datatype of xhtml strings</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#XHTML">awol:XHTML</a>
    /// </summary>
    let XHTML = _prefixId.prefix "XHTML"
    /// <summary>
    ///   <para>rdfs:label : XML content class^^xsd:string</para>
    ///   <para>rdfs:comment : see §4.1.3.3 of rfc 4287. The datatype of xml content</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#XML">awol:XML</a>
    /// </summary>
    let XML = _prefixId.prefix "XML"
    /// <summary>
    ///   <para>skos:editorialNote : This relation is not visible in the rfc4287 xml. It is not clear that it is needed either, though it can help simplify queries. See also N3 rule that defines this precisely ^^xsd:string</para>
    ///   <para>rdfs:label : aggregates</para>
    ///   <para>rdfs:comment : The feed aggregates this given Entry.  See §4.1.1 of rfc4287. This means that the entry does not have the feed as its source. The entry was taken from a different feed.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#aggregates">awol:aggregates</a>
    /// </summary>
    let aggregates = _prefixId.prefix "aggregates"
    /// <summary>
    ///   <para>rdfs:label : author^^xsd:string</para>
    ///   <para>rdfs:comment : See §4.2.1 rfc 4287 spec.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#author">awol:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : body relation^^xsd:string</para>
    ///   <para>rdfs:comment : the body of the content.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#body">awol:body</a>
    /// </summary>
    let body = _prefixId.prefix "body"
    /// <summary>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <para>rdfs:comment : See §4.2.2. A category with which the conainer is associated.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#category">awol:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : contains relation</para>
    ///   <para>rdfs:comment : The feed contains the given Entry. See §4.1.1 of rfc4287. This makes no statement about whether that Entry has the awol:Feed as its source.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#contains">awol:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : content</para>
    ///   <para>rdfs:comment : See §4.1.3 of rfc 4287 spec. The content of an Entry, a Link or any of the relation types that are the object of awol:rel properties</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#content">awol:content</a>
    /// </summary>
    let content = _prefixId.prefix "content"
    /// <summary>
    ///   <para>rdfs:label : contributor</para>
    ///   <para>rdfs:comment : See §4.2.3 of rfc 4287 spec. Someone who contributed to the Version.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#contributor">awol:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:comment : A comment by Danny Ayers</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote">awol:dannyNote</a>
    /// </summary>
    let dannyNote = _prefixId.prefix "dannyNote"
    /// <summary>
    ///   <para>rdfs:comment : A comment by Elias Torres</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote">awol:eliasNote</a>
    /// </summary>
    let eliasNote = _prefixId.prefix "eliasNote"
    /// <summary>
    ///   <para>rdfs:label : email address</para>
    ///   <para>rdfs:comment : see §3.2.3 of rfc 4287. A mailbox of the Person</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#email">awol:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : entry relation</para>
    ///   <para>rdfs:comment : The feed contains the given Entry and that Entry has the feed as its source. See §4.1.1 of rfc 4287. This relation is a little bit more specialised than the rfc 4287 entry element. It relates only awol:Feed objects to :Entry objects where the :Feed is a :source of the :Entry. See also the :source and :contains relations. </para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#entry">awol:entry</a>
    /// </summary>
    let entry = _prefixId.prefix "entry"
    /// <summary>
    ///   <para>skos:editorialNote : The domain should really just be awol:Version. I don't see why Entries can't have an generator too (especially as atom:entry can be a top level content).</para>
    ///   <para>rdfs:label : generator</para>
    ///   <para>rdfs:comment : see §4.2.4 of rfc 4287. The generator of the object</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#generator">awol:generator</a>
    /// </summary>
    let generator = _prefixId.prefix "generator"
    /// <summary>
    ///   <para>rdfs:label : generatorVersion</para>
    ///   <para>rdfs:comment : see §4.2.4 of rfc 4287. Indicates the version of the Generator</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion">awol:generatorVersion</a>
    /// </summary>
    let generatorVersion = _prefixId.prefix "generatorVersion"
    /// <summary>
    ///   <para>rdfs:label : html value^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.2 of rfc 4287. The datatype of html text elements. It is considered to be a relation to the text.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#html">awol:html</a>
    /// </summary>
    let html = _prefixId.prefix "html"
    /// <summary>
    ///   <para>skos:editorialNote : The domain should really just be awol:Version. I don't see why Entries can't have an icon.</para>
    ///   <para>rdfs:label : icon</para>
    ///   <para>rdfs:comment : see 4.2.5 of rfc 4287. An icon associated with the object</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#icon">awol:icon</a>
    /// </summary>
    let icon = _prefixId.prefix "icon"
    /// <summary>
    ///   <para>rdfs:label : id</para>
    ///   <para>rdfs:comment : See §4.2.6 rfc 4287 spec. All Versions with the same id can be considered to be versions of the resource identified by the id. The id mentions the resource of which it is a representation. </para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#id">awol:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>skos:editorialNote : Should this be functional? Given the language sensitivity of the label</para>
    ///   <para>rdfs:label : label</para>
    ///   <para>rdfs:comment : see §4.2.2.3 of rfc 4287. A Human readable label for display.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#label">awol:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : language</para>
    ///   <para>rdfs:comment : see §4.2.7.4 of rfc 4287. The language of the representation.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#lang">awol:lang</a>
    /// </summary>
    let lang = _prefixId.prefix "lang"
    /// <summary>
    ///   <para>rdfs:label : length in bytes</para>
    ///   <para>rdfs:comment : see §4.2.7.6 of rfc 4287. The length in bytes of the representation.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#length">awol:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : link</para>
    ///   <para>rdfs:comment : See §4.2.7 of rfc 4287 spec. A link associated with the container. If the link is unreified, we have a relation from the container to some resource</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#link">awol:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>skos:editorialNote : The domain should really just be awol:Version. I don't see why Entries can't have a logo too.</para>
    ///   <para>rdfs:label : logo</para>
    ///   <para>rdfs:comment : see §4.2.8 of rfc 4287. An icon associated with the object</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#logo">awol:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>rdfs:comment : see §4.2.4 of rfc 4287. A name for the Generator. rdfs:comment : see §3.2.1 of rfc 4287. A human readable name for the Person.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#name">awol:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : publication date</para>
    ///   <para>rdfs:comment : See §4.2.9 of rfc 4287 spec. A date associated with an event early in the lifecyle of the subject.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#published">awol:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>rdfs:label : relation type</para>
    ///   <para>rdfs:comment : see §4.2.7.2 of rfc 4287. The relationship type. The relationship type is a property that relates a awol:Version to a :Content </para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#rel">awol:rel</a>
    /// </summary>
    let rel = _prefixId.prefix "rel"
    /// <summary>
    ///   <para>rdfs:comment : A comment by Reto Bachmann-Gmuer</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#retosNote">awol:retosNote</a>
    /// </summary>
    let retosNote = _prefixId.prefix "retosNote"
    /// <summary>
    ///   <para>rdfs:label : rights</para>
    ///   <para>rdfs:comment : See §4.2.10 of rfc 4287 spec. Rights held over a Version.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#rights">awol:rights</a>
    /// </summary>
    let rights = _prefixId.prefix "rights"
    /// <summary>
    ///   <para>rdfs:label : catgegorization scheme</para>
    ///   <para>rdfs:comment : see §4.2.2.2 of rfc 4287. Identifies a categorization scheme.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#scheme">awol:scheme</a>
    /// </summary>
    let scheme = _prefixId.prefix "scheme"
    /// <summary>
    ///   <para>skos:editorialNote : This is indeed not really needed. But it is useful for explaining the relation between the source element in rfc 4287 and the awol:entry relation. It has educational value.^^xsd:string</para>
    ///   <para>rdfs:label : source feed</para>
    ///   <para>rdfs:comment : See §4.2.11 of rfc 4287 spec. The source feed where the entry was found</para>
    ///   <para>awol:eliasNote : This relation is not strictly necessary.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#source">awol:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : source</para>
    ///   <para>rdfs:comment : a source of the representation</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#src">awol:src</a>
    /// </summary>
    let src = _prefixId.prefix "src"
    /// <summary>
    ///   <para>rdfs:label : the object of the link</para>
    ///   <para>rdfs:comment : the inverse of the awol:link relation, not specified in rfc 4287, but added here for convenience</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#subject">awol:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:label : subtitle</para>
    ///   <para>rdfs:comment : see §4.2.12 of rfc 4287. Subtitle of the feed.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#subtitle">awol:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>rdfs:label : summary</para>
    ///   <para>rdfs:comment : See §4.2.13 of rfc 4287 spec. A summary of the content of the Entry</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#summary">awol:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>skos:editorialNote : should specify that there is exactly one term</para>
    ///   <para>rdfs:label : term</para>
    ///   <para>rdfs:comment : see §4.2.2.1 of rfc 4287. Identifies the category</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#term">awol:term</a>
    /// </summary>
    let term = _prefixId.prefix "term"
    /// <summary>
    ///   <para>rdfs:label : text type^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.1 of rfc 4287. The datatype of xhtml text elements</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#text">awol:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>skos:editorialNote : Reto argues that a Title should have any content attached to it. One should for example allow picture for people who can't read or audio titles for people who cannot write. This would of course make the semantics be a lot more lax that the rfc 4287 syntax allows. </para>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : See §4.2.14. Title of a container</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#title">awol:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : to</para>
    ///   <para>rdfs:comment : the object of a link. We interpret here a Link to be a re-ified relation from a awol:Version to a :Content object. The relation is re-ified in order to add a :title relation to the link. This can probably usually be safely ignored^^xsd:string</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#to">awol:to</a>
    /// </summary>
    let to_ = _prefixId.prefix "to"
    /// <summary>
    ///   <para>rdfs:label : mime type</para>
    ///   <para>rdfs:comment : see §4.2.7.3 of rfc 4287. The mime type of the representation.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#type">awol:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : updated</para>
    ///   <para>rdfs:comment : See §4.2.15 of rfc 4287 spec. Indicates the most recent instant in time when a resource with the given id was modified in a way the publisher considers significant. Therefore, not all modifications necessarily result in a changed atom:updated value.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#updated">awol:updated</a>
    /// </summary>
    let updated = _prefixId.prefix "updated"
    /// <summary>
    ///   <para>skos:editorialNote : the uri with subject awol:Agent and :Generator are really the same relation</para>
    ///   <para>rdfs:label : a uri</para>
    ///   <para>rdfs:comment : see §4.2.4 of rfc 4287. A uri associated the Generatorrdfs:comment : see §3.2.2 of rfc 4287. A uri associated the Person</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#uri">awol:uri</a>
    /// </summary>
    let uri = _prefixId.prefix "uri"
    /// <summary>
    ///   <para>skos:editorialNote : Note that there is a tricky question concerning the xml div element. The xml:lang and xml:base elements are not in fact part of xhtml and it has been argued on the atom mailing list (28 June 2006) that the div is *not* part of the xhtml. We could have this be a special literal with the div, or we could remove the div and push the xml:lang and xml:base down (this would work only if there is one element beneath I suppose) or we would have to use the awol:lang and :base relations on the :Content object. </para>
    ///   <para>rdfs:label : xhtml type^^xsd:string</para>
    ///   <para>rdfs:comment : see §3.1.1.3 of rfc 4287. The datatype of xhtml text elements.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#xhtml">awol:xhtml</a>
    /// </summary>
    let xhtml = _prefixId.prefix "xhtml"
    /// <summary>
    ///   <para>rdfs:label : xml type relation^^xsd:string</para>
    ///   <para>rdfs:comment : see §4.1.3.1 of rfc 4287. Relates an awol:XML object to its content.</para>
    ///   <a href="http://bblfish.net/work/atom-owl/2006-06-06/#xml">awol:xml</a>
    /// </summary>
    let xml = _prefixId.prefix "xml"

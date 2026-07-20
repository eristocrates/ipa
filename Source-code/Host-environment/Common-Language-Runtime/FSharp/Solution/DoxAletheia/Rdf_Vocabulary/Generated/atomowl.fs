namespace http.bblfish.net.work.atom_owl._2006_06_06.hash

open DoxAletheia

module atomowl =
    let _namespace_name = "http://bblfish.net/work/atom-owl/2006-06-06/#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// see §4.2.2.1 of rfc 4287. Identifies the category
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#term"></see></summary>
    let term = _prefix "term"
    /// <summary>
    /// see §3.2 of rfc 4287 spec.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// see §4.2.2 of rfc 4287. A Category Type
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// A comment by Reto Bachmann-Gmuer
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#retosNote"></see></summary>
    let retosNote = _prefix "retosNote"
    /// <summary>
    /// see §4.1.3 in rfc 4287 One way to think of this is as a class that represents what one can get from an HTTP connection. It has a body, and a number of headers, info such as mime-type, content-lenght, etc... .
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Content"></see></summary>
    let Content = _prefix "Content"
    /// <summary>
    /// see §4.1.2 of the rfc 4287 spec
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Entry"></see></summary>
    let Entry = _prefix "Entry"
    /// <summary>
    /// Metadata about the state of  a resource with given awol:id at an :updated time.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    /// Container for feed metadata.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Feed"></see></summary>
    let Feed = _prefix "Feed"
    /// <summary>
    /// Union of the Feed and Entry class. Simplifies writing the ontology.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry"></see></summary>
    let FeedOrEntry = _prefix "FeedOrEntry"
    /// <summary>
    /// See §4.2.14. Title of a container
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// see §4.2.4 of rfc 4287 spec. Generator for the Feed. It has many properties in common with awol:Person
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Generator"></see></summary>
    let Generator = _prefix "Generator"
    /// <summary>
    /// see §3.1.1.2 of rfc 4287. The class of html strings
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#HTML"></see></summary>
    let HTML = _prefix "HTML"
    /// <summary>
    /// see §3.1 of rfc 4287. The text constructs.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#TextContent"></see></summary>
    let TextContent = _prefix "TextContent"
    /// <summary>
    /// see §4.2.7 of rfc 4287 spec. Note that the href, hreflang and lengtlength attributes of rfc 4287 have been moved to the content class and a content relation from the Link to a Content class has been made. The href is translated onto the awol:src relation of the Content class. A link is a reified relation between an entry an a content, for the purpose of adding some metadata such as a title. If it is a reified statement, it is a special type of such a statement, one that implies always the reified statement itself (see N3 rule)
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// see §3.2.3 of rfc 4287. A mailbox of the Person
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// see §3.1.1.1 of rfc 4287. The datatype of simple text elements. Essentially this is the class of all plain text literals.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#PlainText"></see></summary>
    let PlainText = _prefix "PlainText"
    /// <summary>
    /// see §4.2.7.2 of rfc 4287. Relation types are registered, or can be created as described in rfc 4287. They are special types of properties that relate awol:Versions to :Contents.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#RelationType"></see></summary>
    let RelationType = _prefix "RelationType"
    /// <summary>
    /// See §4.2.15 of rfc 4287 spec. Indicates the most recent instant in time when a resource with the given id was modified in a way the publisher considers significant. Therefore, not all modifications necessarily result in a changed atom:updated value.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#updated"></see></summary>
    let updated = _prefix "updated"
    /// <summary>
    /// See §4.2.6 rfc 4287 spec. All Versions with the same id can be considered to be versions of the resource identified by the id. The id mentions the resource of which it is a representation.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// see §3.1.1.3 of rfc 4287. The datatype of xhtml strings
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#XHTML"></see></summary>
    let XHTML = _prefix "XHTML"
    /// <summary>
    /// see §4.1.3.3 of rfc 4287. The datatype of xml content
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#XML"></see></summary>
    let XML = _prefix "XML"
    /// <summary>
    /// The feed aggregates this given Entry.  See §4.1.1 of rfc4287. This means that the entry does not have the feed as its source. The entry was taken from a different feed.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#aggregates"></see></summary>
    let aggregates = _prefix "aggregates"
    /// <summary>
    /// See §4.1.3 of rfc 4287 spec. The content of an Entry, a Link or any of the relation types that are the object of awol:rel properties
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#content"></see></summary>
    let content = _prefix "content"
    /// <summary>
    /// See §4.2.1 rfc 4287 spec.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// the body of the content.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#body"></see></summary>
    let body = _prefix "body"
    /// <summary>
    /// See §4.2.2. A category with which the conainer is associated.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// The feed contains the given Entry. See §4.1.1 of rfc4287. This makes no statement about whether that Entry has the awol:Feed as its source.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    /// See §4.2.3 of rfc 4287 spec. Someone who contributed to the Version.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// A comment by Danny Ayers
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote"></see></summary>
    let dannyNote = _prefix "dannyNote"
    /// <summary>
    /// A comment by Elias Torres
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote"></see></summary>
    let eliasNote = _prefix "eliasNote"
    /// <summary>
    /// The feed contains the given Entry and that Entry has the feed as its source. See §4.1.1 of rfc 4287. This relation is a little bit more specialised than the rfc 4287 entry element. It relates only awol:Feed objects to :Entry objects where the :Feed is a :source of the :Entry. See also the :source and :contains relations.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#entry"></see></summary>
    let entry = _prefix "entry"
    /// <summary>
    /// See §4.2.11 of rfc 4287 spec. The source feed where the entry was found
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// see §4.2.4 of rfc 4287. The generator of the object
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#generator"></see></summary>
    let generator = _prefix "generator"
    /// <summary>
    /// see §4.2.4 of rfc 4287. Indicates the version of the Generator
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion"></see></summary>
    let generatorVersion = _prefix "generatorVersion"
    /// <summary>
    /// see §3.1.1.2 of rfc 4287. The datatype of html text elements. It is considered to be a relation to the text.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#html"></see></summary>
    let html = _prefix "html"
    /// <summary>
    /// see 4.2.5 of rfc 4287. An icon associated with the object
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#icon"></see></summary>
    let icon = _prefix "icon"
    /// <summary>
    /// see §4.2.2.3 of rfc 4287. A Human readable label for display.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// see §4.2.7.4 of rfc 4287. The language of the representation.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#lang"></see></summary>
    let lang = _prefix "lang"
    /// <summary>
    /// see §4.2.7.6 of rfc 4287. The length in bytes of the representation.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// See §4.2.7 of rfc 4287 spec. A link associated with the container. If the link is unreified, we have a relation from the container to some resource
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// see §4.2.8 of rfc 4287. An icon associated with the object
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// see §4.2.4 of rfc 4287. A name for the Generator.
    /// see §3.2.1 of rfc 4287. A human readable name for the Person.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// See §4.2.9 of rfc 4287 spec. A date associated with an event early in the lifecyle of the subject.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#published"></see></summary>
    let published = _prefix "published"
    /// <summary>
    /// see §4.2.7.2 of rfc 4287. The relationship type. The relationship type is a property that relates a awol:Version to a :Content
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#rel"></see></summary>
    let rel = _prefix "rel"
    /// <summary>
    /// See §4.2.10 of rfc 4287 spec. Rights held over a Version.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#rights"></see></summary>
    let rights = _prefix "rights"
    /// <summary>
    /// see §4.2.2.2 of rfc 4287. Identifies a categorization scheme.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#scheme"></see></summary>
    let scheme = _prefix "scheme"
    /// <summary>
    /// a source of the representation
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#src"></see></summary>
    let src = _prefix "src"
    /// <summary>
    /// the inverse of the awol:link relation, not specified in rfc 4287, but added here for convenience
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// see §4.2.12 of rfc 4287. Subtitle of the feed.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// See §4.2.13 of rfc 4287 spec. A summary of the content of the Entry
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// see §3.1.1.1 of rfc 4287. The datatype of xhtml text elements
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// the object of a link. We interpret here a Link to be a re-ified relation from a awol:Version to a :Content object. The relation is re-ified in order to add a :title relation to the link. This can probably usually be safely ignored
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#to"></see></summary>
    let to_ = _prefix "to"
    /// <summary>
    /// see §4.2.7.3 of rfc 4287. The mime type of the representation.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// see §4.2.4 of rfc 4287. A uri associated the Generator
    /// see §3.2.2 of rfc 4287. A uri associated the Person
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#uri"></see></summary>
    let uri = _prefix "uri"
    /// <summary>
    /// see §3.1.1.3 of rfc 4287. The datatype of xhtml text elements.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#xhtml"></see></summary>
    let xhtml = _prefix "xhtml"
    /// <summary>
    /// see §4.1.3.1 of rfc 4287. Relates an awol:XML object to its content.
    /// <see href="http://bblfish.net/work/atom-owl/2006-06-06/#xml"></see></summary>
    let xml = _prefix "xml"

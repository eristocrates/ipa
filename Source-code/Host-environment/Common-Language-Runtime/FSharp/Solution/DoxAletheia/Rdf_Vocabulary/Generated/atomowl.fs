namespace http.bblfish.net.work.atom_owl._2006_06_06.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atomowl =
    let _namespace_iri = Namespace_Iri atomowl |> NamespaceIRI
    /// <summary>
    ///   <para>atomowl:#term</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>see §4.2.2.1 of rfc 4287. Identifies the category</para>
    /// labels<para>term</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#term">http://bblfish.net/work/atom-owl/2006-06-06/#term</seealso>
    let ``_#term`` = Prefixed_Name(atomowl, "#term") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:Ontology</para>
    ///   <para>The AtomOWL ontology is inspired from the work done by the atom working group. This ontology is working off the rfc 4287 published among othe places at http://www.atompub.org/rfc4287.html . The AtomOWL ontology uses as much as possible the same terms as the format there to make the relation easy to understand. The AtomOWL name space is slightly different from the atom namespace [see post http://www.imc.org/atom-syntax/mail-archive/msg16476.html]. But this is a good thing as it helps distinguish the ontology from the rfc 4287 serialisation.</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/">http://bblfish.net/work/atom-owl/2006-06-06/</seealso>
    let _prefix_iri = Prefixed_Name(atomowl, "") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.1.3 in rfc 4287 One way to think of this is as a class that represents what one can get from an HTTP connection. It has a body, and a number of headers, info such as mime-type, content-lenght, etc... .</para>
    /// labels<para>Content Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Content">http://bblfish.net/work/atom-owl/2006-06-06/#Content</seealso>
    let ``_#Content`` = Prefixed_Name(atomowl, "#Content") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#FeedOrEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Union of the Feed and Entry class. Simplifies writing the ontology.</para>
    /// labels<para>FeedOrEntry Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry">http://bblfish.net/work/atom-owl/2006-06-06/#FeedOrEntry</seealso>
    let ``_#FeedOrEntry`` = Prefixed_Name(atomowl, "#FeedOrEntry") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.2.4 of rfc 4287 spec. Generator for the Feed. It has many properties in common with awol:Person</para>
    /// labels<para>Generator of feed</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Generator">http://bblfish.net/work/atom-owl/2006-06-06/#Generator</seealso>
    let ``_#Generator`` = Prefixed_Name(atomowl, "#Generator") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#HTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §3.1.1.2 of rfc 4287. The class of html strings</para>
    /// labels<para>Html content class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#HTML">http://bblfish.net/work/atom-owl/2006-06-06/#HTML</seealso>
    let ``_#HTML`` = Prefixed_Name(atomowl, "#HTML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#PlainText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §3.1.1.1 of rfc 4287. The datatype of simple text elements. Essentially this is the class of all plain text literals.</para>
    /// labels<para>Plain text content class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#PlainText">http://bblfish.net/work/atom-owl/2006-06-06/#PlainText</seealso>
    let ``_#PlainText`` = Prefixed_Name(atomowl, "#PlainText") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Feed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Container for feed metadata.</para>
    /// labels<para>Feed Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Feed">http://bblfish.net/work/atom-owl/2006-06-06/#Feed</seealso>
    let ``_#Feed`` = Prefixed_Name(atomowl, "#Feed") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metadata about the state of  a resource with given awol:id at an :updated time.</para>
    /// labels<para>Version Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Version">http://bblfish.net/work/atom-owl/2006-06-06/#Version</seealso>
    let ``_#Version`` = Prefixed_Name(atomowl, "#Version") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.14. Title of a container</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#title">http://bblfish.net/work/atom-owl/2006-06-06/#title</seealso>
    let ``_#title`` = Prefixed_Name(atomowl, "#title") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#email</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see §3.2.3 of rfc 4287. A mailbox of the Person</para>
    /// labels<para>email address</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#email">http://bblfish.net/work/atom-owl/2006-06-06/#email</seealso>
    let ``_#email`` = Prefixed_Name(atomowl, "#email") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#RelationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.2.7.2 of rfc 4287. Relation types are registered, or can be created as described in rfc 4287. They are special types of properties that relate awol:Versions to :Contents.</para>
    /// labels<para>Relation Type Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#RelationType">http://bblfish.net/work/atom-owl/2006-06-06/#RelationType</seealso>
    let ``_#RelationType`` = Prefixed_Name(atomowl, "#RelationType") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#XML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.1.3.3 of rfc 4287. The datatype of xml content</para>
    /// labels<para>XML content class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#XML">http://bblfish.net/work/atom-owl/2006-06-06/#XML</seealso>
    let ``_#XML`` = Prefixed_Name(atomowl, "#XML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>the body of the content.</para>
    /// labels<para>body relation</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#body">http://bblfish.net/work/atom-owl/2006-06-06/#body</seealso>
    let ``_#body`` = Prefixed_Name(atomowl, "#body") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#dannyNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A comment by Danny Ayers</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote">http://bblfish.net/work/atom-owl/2006-06-06/#dannyNote</seealso>
    let ``_#dannyNote`` = Prefixed_Name(atomowl, "#dannyNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>see §4.2.4 of rfc 4287. The generator of the object</para>
    /// labels<para>generator</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#generator">http://bblfish.net/work/atom-owl/2006-06-06/#generator</seealso>
    let ``_#generator`` = Prefixed_Name(atomowl, "#generator") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.1 rfc 4287 spec.</para>
    /// labels<para>author</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#author">http://bblfish.net/work/atom-owl/2006-06-06/#author</seealso>
    let ``_#author`` = Prefixed_Name(atomowl, "#author") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.3 of rfc 4287 spec. Someone who contributed to the Version.</para>
    /// labels<para>contributor</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#contributor">http://bblfish.net/work/atom-owl/2006-06-06/#contributor</seealso>
    let ``_#contributor`` = Prefixed_Name(atomowl, "#contributor") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.11 of rfc 4287 spec. The source feed where the entry was found</para>
    /// labels<para>source feed</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#source">http://bblfish.net/work/atom-owl/2006-06-06/#source</seealso>
    let ``_#source`` = Prefixed_Name(atomowl, "#source") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see 4.2.5 of rfc 4287. An icon associated with the object</para>
    /// labels<para>icon</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#icon">http://bblfish.net/work/atom-owl/2006-06-06/#icon</seealso>
    let ``_#icon`` = Prefixed_Name(atomowl, "#icon") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#lang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>see §4.2.7.4 of rfc 4287. The language of the representation.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#lang">http://bblfish.net/work/atom-owl/2006-06-06/#lang</seealso>
    let ``_#lang`` = Prefixed_Name(atomowl, "#lang") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see §4.2.8 of rfc 4287. An icon associated with the object</para>
    /// labels<para>logo</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#logo">http://bblfish.net/work/atom-owl/2006-06-06/#logo</seealso>
    let ``_#logo`` = Prefixed_Name(atomowl, "#logo") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>see §3.2.1 of rfc 4287. A human readable name for the Person.</para>
    ///   <para>see §4.2.4 of rfc 4287. A name for the Generator. </para>
    /// labels<para>name</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#name">http://bblfish.net/work/atom-owl/2006-06-06/#name</seealso>
    let ``_#name`` = Prefixed_Name(atomowl, "#name") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#rel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see §4.2.7.2 of rfc 4287. The relationship type. The relationship type is a property that relates a awol:Version to a :Content </para>
    /// labels<para>relation type</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#rel">http://bblfish.net/work/atom-owl/2006-06-06/#rel</seealso>
    let ``_#rel`` = Prefixed_Name(atomowl, "#rel") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>See §4.2.10 of rfc 4287 spec. Rights held over a Version.</para>
    /// labels<para>rights</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#rights">http://bblfish.net/work/atom-owl/2006-06-06/#rights</seealso>
    let ``_#rights`` = Prefixed_Name(atomowl, "#rights") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>See §4.2.9 of rfc 4287 spec. A date associated with an event early in the lifecyle of the subject.</para>
    /// labels<para>publication date</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#published">http://bblfish.net/work/atom-owl/2006-06-06/#published</seealso>
    let ``_#published`` = Prefixed_Name(atomowl, "#published") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#scheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see §4.2.2.2 of rfc 4287. Identifies a categorization scheme.</para>
    /// labels<para>catgegorization scheme</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#scheme">http://bblfish.net/work/atom-owl/2006-06-06/#scheme</seealso>
    let ``_#scheme`` = Prefixed_Name(atomowl, "#scheme") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#src</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a source of the representation</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#src">http://bblfish.net/work/atom-owl/2006-06-06/#src</seealso>
    let ``_#src`` = Prefixed_Name(atomowl, "#src") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the inverse of the awol:link relation, not specified in rfc 4287, but added here for convenience</para>
    /// labels<para>the object of the link</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#subject">http://bblfish.net/work/atom-owl/2006-06-06/#subject</seealso>
    let ``_#subject`` = Prefixed_Name(atomowl, "#subject") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>See §4.2.13 of rfc 4287 spec. A summary of the content of the Entry</para>
    /// labels<para>summary</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#summary">http://bblfish.net/work/atom-owl/2006-06-06/#summary</seealso>
    let ``_#summary`` = Prefixed_Name(atomowl, "#summary") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the object of a link. We interpret here a Link to be a re-ified relation from a awol:Version to a :Content object. The relation is re-ified in order to add a :title relation to the link. This can probably usually be safely ignored</para>
    /// labels<para>to</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#to">http://bblfish.net/work/atom-owl/2006-06-06/#to</seealso>
    let ``_#to`` = Prefixed_Name(atomowl, "#to") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see §4.2.12 of rfc 4287. Subtitle of the feed.</para>
    /// labels<para>subtitle</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#subtitle">http://bblfish.net/work/atom-owl/2006-06-06/#subtitle</seealso>
    let ``_#subtitle`` = Prefixed_Name(atomowl, "#subtitle") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>see §3.1.1.1 of rfc 4287. The datatype of xhtml text elements</para>
    /// labels<para>text type</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#text">http://bblfish.net/work/atom-owl/2006-06-06/#text</seealso>
    let ``_#text`` = Prefixed_Name(atomowl, "#text") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#uri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>see §3.2.2 of rfc 4287. A uri associated the Person</para>
    ///   <para>see §4.2.4 of rfc 4287. A uri associated the Generator</para>
    /// labels<para>a uri</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#uri">http://bblfish.net/work/atom-owl/2006-06-06/#uri</seealso>
    let ``_#uri`` = Prefixed_Name(atomowl, "#uri") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#xml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>see §4.1.3.1 of rfc 4287. Relates an awol:XML object to its content.</para>
    /// labels<para>xml type relation</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#xml">http://bblfish.net/work/atom-owl/2006-06-06/#xml</seealso>
    let ``_#xml`` = Prefixed_Name(atomowl, "#xml") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>see §4.2.7.3 of rfc 4287. The mime type of the representation.</para>
    /// labels<para>mime type</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#type">http://bblfish.net/work/atom-owl/2006-06-06/#type</seealso>
    let ``_#type`` = Prefixed_Name(atomowl, "#type") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#xhtml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>see §3.1.1.3 of rfc 4287. The datatype of xhtml text elements.</para>
    /// labels<para>xhtml type</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#xhtml">http://bblfish.net/work/atom-owl/2006-06-06/#xhtml</seealso>
    let ``_#xhtml`` = Prefixed_Name(atomowl, "#xhtml") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §3.2 of rfc 4287 spec.</para>
    /// labels<para>Person Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Person">http://bblfish.net/work/atom-owl/2006-06-06/#Person</seealso>
    let ``_#Person`` = Prefixed_Name(atomowl, "#Person") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.2.2 of rfc 4287. A Category Type</para>
    /// labels<para>Category Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Category">http://bblfish.net/work/atom-owl/2006-06-06/#Category</seealso>
    let ``_#Category`` = Prefixed_Name(atomowl, "#Category") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#retosNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A comment by Reto Bachmann-Gmuer</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#retosNote">http://bblfish.net/work/atom-owl/2006-06-06/#retosNote</seealso>
    let ``_#retosNote`` = Prefixed_Name(atomowl, "#retosNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.1.2 of the rfc 4287 spec</para>
    /// labels<para>Entry Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Entry">http://bblfish.net/work/atom-owl/2006-06-06/#Entry</seealso>
    let ``_#Entry`` = Prefixed_Name(atomowl, "#Entry") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#TextContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §3.1 of rfc 4287. The text constructs.</para>
    /// labels<para>All Text Content Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#TextContent">http://bblfish.net/work/atom-owl/2006-06-06/#TextContent</seealso>
    let ``_#TextContent`` = Prefixed_Name(atomowl, "#TextContent") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §4.2.7 of rfc 4287 spec. Note that the href, hreflang and lengtlength attributes of rfc 4287 have been moved to the content class and a content relation from the Link to a Content class has been made. The href is translated onto the awol:src relation of the Content class. A link is a reified relation between an entry an a content, for the purpose of adding some metadata such as a title. If it is a reified statement, it is a special type of such a statement, one that implies always the reified statement itself (see N3 rule)</para>
    /// labels<para>Link Class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#Link">http://bblfish.net/work/atom-owl/2006-06-06/#Link</seealso>
    let ``_#Link`` = Prefixed_Name(atomowl, "#Link") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#updated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>See §4.2.15 of rfc 4287 spec. Indicates the most recent instant in time when a resource with the given id was modified in a way the publisher considers significant. Therefore, not all modifications necessarily result in a changed atom:updated value.</para>
    /// labels<para>updated</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#updated">http://bblfish.net/work/atom-owl/2006-06-06/#updated</seealso>
    let ``_#updated`` = Prefixed_Name(atomowl, "#updated") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>See §4.2.6 rfc 4287 spec. All Versions with the same id can be considered to be versions of the resource identified by the id. The id mentions the resource of which it is a representation. </para>
    /// labels<para>id</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#id">http://bblfish.net/work/atom-owl/2006-06-06/#id</seealso>
    let ``_#id`` = Prefixed_Name(atomowl, "#id") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#XHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>see §3.1.1.3 of rfc 4287. The datatype of xhtml strings</para>
    /// labels<para>Xhtml content class</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#XHTML">http://bblfish.net/work/atom-owl/2006-06-06/#XHTML</seealso>
    let ``_#XHTML`` = Prefixed_Name(atomowl, "#XHTML") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#aggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The feed aggregates this given Entry.  See §4.1.1 of rfc4287. This means that the entry does not have the feed as its source. The entry was taken from a different feed.</para>
    /// labels<para>aggregates</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#aggregates">http://bblfish.net/work/atom-owl/2006-06-06/#aggregates</seealso>
    let ``_#aggregates`` = Prefixed_Name(atomowl, "#aggregates") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>See §4.1.3 of rfc 4287 spec. The content of an Entry, a Link or any of the relation types that are the object of awol:rel properties</para>
    /// labels<para>content</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#content">http://bblfish.net/work/atom-owl/2006-06-06/#content</seealso>
    let ``_#content`` = Prefixed_Name(atomowl, "#content") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.2. A category with which the conainer is associated.</para>
    /// labels<para>category</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#category">http://bblfish.net/work/atom-owl/2006-06-06/#category</seealso>
    let ``_#category`` = Prefixed_Name(atomowl, "#category") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The feed contains the given Entry. See §4.1.1 of rfc4287. This makes no statement about whether that Entry has the awol:Feed as its source.</para>
    /// labels<para>contains relation</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#contains">http://bblfish.net/work/atom-owl/2006-06-06/#contains</seealso>
    let ``_#contains`` = Prefixed_Name(atomowl, "#contains") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#eliasNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A comment by Elias Torres</para>
    /// </remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote">http://bblfish.net/work/atom-owl/2006-06-06/#eliasNote</seealso>
    let ``_#eliasNote`` = Prefixed_Name(atomowl, "#eliasNote") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The feed contains the given Entry and that Entry has the feed as its source. See §4.1.1 of rfc 4287. This relation is a little bit more specialised than the rfc 4287 entry element. It relates only awol:Feed objects to :Entry objects where the :Feed is a :source of the :Entry. See also the :source and :contains relations. </para>
    /// labels<para>entry relation</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#entry">http://bblfish.net/work/atom-owl/2006-06-06/#entry</seealso>
    let ``_#entry`` = Prefixed_Name(atomowl, "#entry") |> PrefixedName

    /// <summary>
    ///   <para>atomowl:#generatorVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>see §4.2.4 of rfc 4287. Indicates the version of the Generator</para>
    /// labels<para>generatorVersion</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion">http://bblfish.net/work/atom-owl/2006-06-06/#generatorVersion</seealso>
    let ``_#generatorVersion`` =
        Prefixed_Name(atomowl, "#generatorVersion") |> PrefixedName

    /// <summary>
    ///   <para>atomowl:#html</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>see §3.1.1.2 of rfc 4287. The datatype of html text elements. It is considered to be a relation to the text.</para>
    /// labels<para>html value</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#html">http://bblfish.net/work/atom-owl/2006-06-06/#html</seealso>
    let ``_#html`` = Prefixed_Name(atomowl, "#html") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>see §4.2.2.3 of rfc 4287. A Human readable label for display.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#label">http://bblfish.net/work/atom-owl/2006-06-06/#label</seealso>
    let ``_#label`` = Prefixed_Name(atomowl, "#label") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>see §4.2.7.6 of rfc 4287. The length in bytes of the representation.</para>
    /// labels<para>length in bytes</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#length">http://bblfish.net/work/atom-owl/2006-06-06/#length</seealso>
    let ``_#length`` = Prefixed_Name(atomowl, "#length") |> PrefixedName
    /// <summary>
    ///   <para>atomowl:#link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See §4.2.7 of rfc 4287 spec. A link associated with the container. If the link is unreified, we have a relation from the container to some resource</para>
    /// labels<para>link</para></remarks>
    /// <seealso href="http://bblfish.net/work/atom-owl/2006-06-06/#link">http://bblfish.net/work/atom-owl/2006-06-06/#link</seealso>
    let ``_#link`` = Prefixed_Name(atomowl, "#link") |> PrefixedName

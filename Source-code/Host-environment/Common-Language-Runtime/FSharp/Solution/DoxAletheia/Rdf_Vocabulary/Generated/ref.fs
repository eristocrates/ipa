namespace http.purl.org.vocab.relationship.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ref =
    let _namespace_iri = Namespace_Iri ref |> NamespaceIRI
    /// <summary>
    ///   <para>ref:</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/relationship/">http://purl.org/vocab/relationship/</seealso>
    let _prefix_iri = Prefixed_Name(ref, "") |> PrefixedName
    /// <summary>
    ///   <para>ref:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Relationship"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/Relationship">http://purl.org/vocab/relationship/Relationship</seealso>
    let Relationship = Prefixed_Name(ref, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>ref:acquaintanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Acquaintance Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/acquaintanceOf">http://purl.org/vocab/relationship/acquaintanceOf</seealso>
    let acquaintanceOf = Prefixed_Name(ref, "acquaintanceOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:ambivalentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Ambivalent Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/ambivalentOf">http://purl.org/vocab/relationship/ambivalentOf</seealso>
    let ambivalentOf = Prefixed_Name(ref, "ambivalentOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:ancestorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"Ancestor Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/ancestorOf">http://purl.org/vocab/relationship/ancestorOf</seealso>
    let ancestorOf = Prefixed_Name(ref, "ancestorOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:antagonistOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Antagonist Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/antagonistOf">http://purl.org/vocab/relationship/antagonistOf</seealso>
    let antagonistOf = Prefixed_Name(ref, "antagonistOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:apprenticeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Apprentice To"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/apprenticeTo">http://purl.org/vocab/relationship/apprenticeTo</seealso>
    let apprenticeTo = Prefixed_Name(ref, "apprenticeTo") |> PrefixedName
    /// <summary>
    ///   <para>ref:childOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Child Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/childOf">http://purl.org/vocab/relationship/childOf</seealso>
    let childOf = Prefixed_Name(ref, "childOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:closeFriendOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Close Friend Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/closeFriendOf">http://purl.org/vocab/relationship/closeFriendOf</seealso>
    let closeFriendOf = Prefixed_Name(ref, "closeFriendOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:collaboratesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Collaborates With"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/collaboratesWith">http://purl.org/vocab/relationship/collaboratesWith</seealso>
    let collaboratesWith = Prefixed_Name(ref, "collaboratesWith") |> PrefixedName
    /// <summary>
    ///   <para>ref:colleagueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Colleague Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/colleagueOf">http://purl.org/vocab/relationship/colleagueOf</seealso>
    let colleagueOf = Prefixed_Name(ref, "colleagueOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:descendantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"Descendant Of"</para><para>"Descendant Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/descendantOf">http://purl.org/vocab/relationship/descendantOf</seealso>
    let descendantOf = Prefixed_Name(ref, "descendantOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:employedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Employed By"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/employedBy">http://purl.org/vocab/relationship/employedBy</seealso>
    let employedBy = Prefixed_Name(ref, "employedBy") |> PrefixedName
    /// <summary>
    ///   <para>ref:employerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Employer Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/employerOf">http://purl.org/vocab/relationship/employerOf</seealso>
    let employerOf = Prefixed_Name(ref, "employerOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:enemyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Enemy Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/enemyOf">http://purl.org/vocab/relationship/enemyOf</seealso>
    let enemyOf = Prefixed_Name(ref, "enemyOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:engagedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Engaged To"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/engagedTo">http://purl.org/vocab/relationship/engagedTo</seealso>
    let engagedTo = Prefixed_Name(ref, "engagedTo") |> PrefixedName
    /// <summary>
    ///   <para>ref:examples/1</para>
    /// </summary>
    /// <remarks>
    ///   <para>open:SchemaExample</para>
    ///   <para>"&lt;p&gt;The RELATIONSHIP vocabulary can be used without modification with &lt;a href="http://xmlns.com/foaf/0.1/"&gt;FOAF&lt;/a&gt; documents. Simply replace &lt;code&gt;foaf:knows&lt;/code&gt; properties with a more specific property from this vocabulary. For backwards compatibility with older, non-RDF aware,  tools, you may want to keep the &lt;code&gt;foaf:knows&lt;/code&gt; property as well.&lt;/p&gt;     &lt;pre&gt;
    /// &lt;code class="xml"&gt;
    /// &amp;lt;rdf:RDF
    ///       xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
    ///       xmlns:rdfs="http://www.w3.org/2000/01/rdf-schema#"
    ///       xmlns:foaf="http://xmlns.com/foaf/0.1/"
    ///       xmlns:rel="http://purl.org/vocab/relationship/"
    ///       &amp;gt;
    ///
    ///   &amp;lt;foaf:Person rdf:nodeID="ian"&amp;gt;
    ///     &amp;lt;foaf:name&amp;gt;Ian Davis&amp;lt;/foaf:name&amp;gt;
    ///     &amp;lt;foaf:title&amp;gt;Mr&amp;lt;/foaf:title&amp;gt;
    ///     &amp;lt;foaf:firstName&amp;gt;Ian&amp;lt;/foaf:firstName&amp;gt;
    ///     &amp;lt;foaf:surname&amp;gt;Davis&amp;lt;/foaf:surname&amp;gt;
    ///
    ///     &amp;lt;rel:hasMet&amp;gt;
    ///       &amp;lt;foaf:Person&amp;gt;
    ///         &amp;lt;foaf:name&amp;gt;William Tell&amp;lt;/foaf:name&amp;gt;
    ///       &amp;lt;/foaf:Person&amp;gt;
    ///     &amp;lt;/rel:hasMet&amp;gt;
    ///
    ///     &amp;lt;rel:collaboratesWith rdf:nodeID="eric"/&amp;gt;
    ///   &amp;lt;/foaf:Person&amp;gt;
    ///
    ///   &amp;lt;foaf:Person rdf:nodeID="eric"&amp;gt;
    ///     &amp;lt;foaf:nick&amp;gt;pixel&amp;lt;/foaf:nick&amp;gt;
    ///   &amp;lt;/foaf:Person&amp;gt;
    ///
    ///
    ///
    /// &amp;lt;/rdf:RDF&amp;gt;
    /// &lt;/code&gt;
    ///     &lt;/pre&gt;
    /// "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"Using With FOAF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/examples/1">http://purl.org/vocab/relationship/examples/1</seealso>
    let ``examples/1`` = Prefixed_Name(ref, "examples/1") |> PrefixedName
    /// <summary>
    ///   <para>ref:examples/2</para>
    /// </summary>
    /// <remarks>
    ///   <para>open:SchemaExample</para>
    ///   <para>"&lt;p&gt;
    ///
    ///       The relationship vocabulary can be used to describe relationships with the people linked from a web page. This is particularly useful for blogrolls or contact lists but can be used with any type of link. The HTML &lt;code&gt;a&lt;/code&gt; element provides two attributes, &lt;a href="http://www.w3.org/TR/html401/struct/links.html#adef-rel"&gt;rel and rev&lt;/a&gt;, that can be used to specify the relationship. Both &lt;code&gt;rel&lt;/code&gt; and &lt;code&gt;rev&lt;/code&gt; take a space separated list of keywords as their value. To use a term from the relationship vocabulary just drop the &lt;code&gt;http://purl.org/vocab/relationship/&lt;/code&gt; namespace to leave the property name, e.g. &lt;code&gt;http://purl.org/vocab/relationship/worksWith&lt;/code&gt; would become &lt;code&gt;worksWith&lt;/code&gt; which can be added as the value of &lt;code&gt;rel&lt;/code&gt; or &lt;code&gt;rev&lt;/code&gt;.
    ///     &lt;/p&gt;
    ///     &lt;dl&gt;
    ///       &lt;dt&gt;
    ///         &lt;code&gt;rel&lt;/code&gt;
    ///       &lt;/dt&gt;
    ///       &lt;dd&gt;
    ///         &lt;p&gt;
    ///           The &lt;code&gt;rel&lt;/code&gt; attribute specifies a relationship that the author of the &lt;em&gt;linked&lt;/em&gt; page has with the author of the &lt;em&gt;linking&lt;/em&gt; page.
    ///           For example:
    ///         &lt;/p&gt;
    ///         &lt;pre&gt;&lt;code&gt;&lt;span class="elem"&gt;&amp;lt;a&lt;/span&gt;&lt;span class="attr"&gt;href&lt;/span&gt;="&lt;span class="attrVal"&gt;http://example.com/boats&lt;/span&gt;" &lt;span class="attr highlight"&gt;rel&lt;/span&gt;="&lt;span class="attrVal"&gt;childOf&lt;/span&gt;"&lt;span class="elem"&gt;&amp;gt;&lt;/span&gt;&lt;span class="text"&gt;The boat we restored&lt;/span&gt;&lt;span class="elem"&gt;"&amp;lt;/a&amp;gt;&lt;/span&gt;&lt;/code&gt;&lt;/pre&gt;
    ///         &lt;p&gt;This link states that the author of &lt;code&gt;http://example.com/boats&lt;/code&gt; is a child of the author of the html above. &lt;/p&gt;
    ///       &lt;/dd&gt;
    ///       &lt;dt&gt;
    ///         &lt;code&gt;rev&lt;/code&gt;
    ///       &lt;/dt&gt;
    ///       &lt;dd&gt;
    ///         &lt;p&gt;
    ///           The &lt;code&gt;rev&lt;/code&gt; attribute specifies a relationship that the author of the &lt;em&gt;linking&lt;/em&gt; page has with the author of the   &lt;em&gt;linked&lt;/em&gt; page. The example here is:
    ///         &lt;/p&gt;
    ///         &lt;pre&gt;&lt;code&gt;&lt;span class="elem"&gt;&amp;lt;a&lt;/span&gt;&lt;span class="attr"&gt;href&lt;/span&gt;="&lt;span class="attrVal"&gt;http://example.com/boats&lt;/span&gt;" &lt;span class="attr highlight"&gt;rev&lt;/span&gt;="&lt;span class="attrVal"&gt;childOf&lt;/span&gt;"&lt;span class="elem"&gt;&amp;gt;&lt;/span&gt;&lt;span class="text"&gt;The boat we restored&lt;/span&gt;&lt;span class="elem"&gt;"&amp;lt;/a&amp;gt;&lt;/span&gt;&lt;/code&gt;&lt;/pre&gt;
    ///         &lt;p&gt;In this case the meaning of the link is reversed: the author of the html above is a child of the author of &lt;code&gt;http://example.com/boats&lt;/code&gt;.&lt;/p&gt;
    ///       &lt;/dd&gt;
    ///     &lt;/dl&gt;
    ///     &lt;p&gt;The HTML and XHTML recommendations require an HTML document to declare a custom profile if it uses any non-standard &lt;code&gt;rel&lt;/code&gt; or &lt;code&gt;rev&lt;/code&gt; types. This is done by adding a &lt;code&gt;profile&lt;/code&gt; attribute with a value of &lt;code&gt;http://purl.org/vocab/relationship/&lt;/code&gt; to the document's &lt;code&gt;head&lt;/code&gt; element. &lt;/p&gt;
    ///     &lt;pre&gt;&lt;code&gt;  &amp;lt;head profile="http://purl.org/vocab/relationship/"&amp;gt;
    ///     &amp;lt;title&amp;gt;People I Know&amp;lt;/title&amp;gt;
    ///   &amp;lt;/head&amp;gt;&lt;/code&gt;&lt;/pre&gt;
    ///     &lt;h3&gt;Complete Example&lt;/h3&gt;
    ///     &lt;pre&gt;&lt;code&gt;  &amp;lt;html profile="http://purl.org/vocab/relationship/"&amp;gt;
    ///     &amp;lt;head&amp;gt;
    ///       &amp;lt;title&amp;gt;People I Know&amp;lt;/title&amp;gt;
    ///     &amp;lt;/head&amp;gt;
    ///     &amp;lt;body&amp;gt;
    ///       &amp;lt;p&amp;gt;Here are the people I know:&amp;lt;/p&amp;gt;
    ///         &amp;lt;ul&amp;gt;
    ///           &amp;lt;li&amp;gt;&amp;lt;a href="http://example.com/~freddy" rel="closeFriendOf"&amp;gt;Freddy (he's cool!)&amp;lt;/a&amp;gt;&amp;lt;/li&amp;gt;
    ///           &amp;lt;li&amp;gt;&amp;lt;a href="http://frooble.com/" rel="mentorOf"&amp;gt;Jimbo&amp;lt;/a&amp;gt;&amp;lt;/li&amp;gt;
    ///           &amp;lt;li&amp;gt;&amp;lt;a href="http://mmmm.com/klm" rel="friendOf"&amp;gt;Katie&amp;lt;/a&amp;gt;&amp;lt;/li&amp;gt;
    ///           &amp;lt;li&amp;gt;&amp;lt;a href="http://example.com/~omah" rel="worksWith"&amp;gt;Omah (does the coding)&amp;lt;/a&amp;gt;&amp;lt;/li&amp;gt;
    ///           &amp;lt;li&amp;gt;&amp;lt;a href="http://example.com/~jason" rev="closeFriendOf employedBy"&amp;gt;Jason, my henchman&amp;lt;/a&amp;gt;&amp;lt;/li&amp;gt;
    ///         &amp;lt;/ul&amp;gt;
    ///       &amp;lt;/body&amp;gt;
    ///     &amp;lt;/html&amp;gt;
    /// &lt;/code&gt;&lt;/pre&gt;
    ///     &lt;h3&gt;RDF Interpretation&lt;/h3&gt;
    ///     &lt;p&gt;Custom parsers that extract RDF from (X)HTML can use the relationships expressed in the links to infer the
    ///   equivilent RDF triples. It should be remembered that the relationship is between the authors of the pages not between
    ///   the pages themselves. Given the following link on a document at &lt;code&gt;http://example.com/mypage.html&lt;/code&gt;:
    ///   &lt;/p&gt;
    ///     &lt;pre&gt;&lt;code&gt;&lt;span class="elem"&gt;&amp;lt;a&lt;/span&gt;&lt;span class="attr"&gt;href&lt;/span&gt;="&lt;span class="attrVal"&gt;http://example.com/boats&lt;/span&gt;" &lt;span class="attr highlight"&gt;rel&lt;/span&gt;="&lt;span class="attrVal"&gt;childOf&lt;/span&gt;"&lt;span class="elem"&gt;&amp;gt;&lt;/span&gt;&lt;span class="text"&gt;The boat we restored&lt;/span&gt;&lt;span class="elem"&gt;"&amp;lt;/a&amp;gt;&lt;/span&gt;&lt;/code&gt;&lt;/pre&gt;
    ///     &lt;p&gt;a suggested RDF extraction is:&lt;/p&gt;
    ///     &lt;pre&gt;&lt;code&gt;  &amp;lt;foaf:Person&amp;gt;
    ///     &amp;lt;foaf:maker rdf:resource="http://example.com/boats"/&amp;gt;
    ///     &amp;lt;rel:childOf&amp;gt;
    ///       &amp;lt;foaf:Person&amp;gt;
    ///         &amp;lt;foaf:maker rdf:resource="http://example.com/mypage.html"/&amp;gt;
    ///       &amp;lt;/foaf:Person&amp;gt;
    ///     &amp;lt;/rel:childOf&amp;gt;
    ///   &amp;lt;/foaf:Person&amp;gt;&lt;/code&gt;&lt;/pre&gt;
    /// "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"Using With HTML and XHTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/examples/2">http://purl.org/vocab/relationship/examples/2</seealso>
    let ``examples/2`` = Prefixed_Name(ref, "examples/2") |> PrefixedName
    /// <summary>
    ///   <para>ref:friendOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Friend Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/friendOf">http://purl.org/vocab/relationship/friendOf</seealso>
    let friendOf = Prefixed_Name(ref, "friendOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:grandchildOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Grandchild Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Grandchild Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/grandchildOf">http://purl.org/vocab/relationship/grandchildOf</seealso>
    let grandchildOf = Prefixed_Name(ref, "grandchildOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:grandparentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Grandparent Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/grandparentOf">http://purl.org/vocab/relationship/grandparentOf</seealso>
    let grandparentOf = Prefixed_Name(ref, "grandparentOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:hasMet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Has Met"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/hasMet">http://purl.org/vocab/relationship/hasMet</seealso>
    let hasMet = Prefixed_Name(ref, "hasMet") |> PrefixedName
    /// <summary>
    ///   <para>ref:influencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Influenced By"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/influencedBy">http://purl.org/vocab/relationship/influencedBy</seealso>
    let influencedBy = Prefixed_Name(ref, "influencedBy") |> PrefixedName
    /// <summary>
    ///   <para>ref:knowsByReputation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Knows By Reputation"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/knowsByReputation">http://purl.org/vocab/relationship/knowsByReputation</seealso>
    let knowsByReputation = Prefixed_Name(ref, "knowsByReputation") |> PrefixedName
    /// <summary>
    ///   <para>ref:knowsInPassing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Knows In Passing"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/knowsInPassing">http://purl.org/vocab/relationship/knowsInPassing</seealso>
    let knowsInPassing = Prefixed_Name(ref, "knowsInPassing") |> PrefixedName
    /// <summary>
    ///   <para>ref:knowsOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Knows Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/knowsOf">http://purl.org/vocab/relationship/knowsOf</seealso>
    let knowsOf = Prefixed_Name(ref, "knowsOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:lifePartnerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Life Partner of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/lifePartnerOf">http://purl.org/vocab/relationship/lifePartnerOf</seealso>
    let lifePartnerOf = Prefixed_Name(ref, "lifePartnerOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:livesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"Lives With"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/livesWith">http://purl.org/vocab/relationship/livesWith</seealso>
    let livesWith = Prefixed_Name(ref, "livesWith") |> PrefixedName
    /// <summary>
    ///   <para>ref:lostContactWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Lost Contact With"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/lostContactWith">http://purl.org/vocab/relationship/lostContactWith</seealso>
    let lostContactWith = Prefixed_Name(ref, "lostContactWith") |> PrefixedName
    /// <summary>
    ///   <para>ref:mentorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Mentor Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/mentorOf">http://purl.org/vocab/relationship/mentorOf</seealso>
    let mentorOf = Prefixed_Name(ref, "mentorOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:neighborOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Neighbor Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/neighborOf">http://purl.org/vocab/relationship/neighborOf</seealso>
    let neighborOf = Prefixed_Name(ref, "neighborOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:parentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Parent Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/parentOf">http://purl.org/vocab/relationship/parentOf</seealso>
    let parentOf = Prefixed_Name(ref, "parentOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Participant"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/participant">http://purl.org/vocab/relationship/participant</seealso>
    let participant = Prefixed_Name(ref, "participant") |> PrefixedName
    /// <summary>
    ///   <para>ref:participantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Participant In"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/participantIn">http://purl.org/vocab/relationship/participantIn</seealso>
    let participantIn = Prefixed_Name(ref, "participantIn") |> PrefixedName
    /// <summary>
    ///   <para>ref:rel-vocab-20090515</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/rel-vocab-20090515">http://purl.org/vocab/relationship/rel-vocab-20090515</seealso>
    let rel_vocab_20090515 = Prefixed_Name(ref, "rel-vocab-20090515") |> PrefixedName
    /// <summary>
    ///   <para>ref:siblingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Sibling Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/siblingOf">http://purl.org/vocab/relationship/siblingOf</seealso>
    let siblingOf = Prefixed_Name(ref, "siblingOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:spouseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Spouse Of"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/spouseOf">http://purl.org/vocab/relationship/spouseOf</seealso>
    let spouseOf = Prefixed_Name(ref, "spouseOf") |> PrefixedName
    /// <summary>
    ///   <para>ref:worksWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>"Works With"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/worksWith">http://purl.org/vocab/relationship/worksWith</seealso>
    let worksWith = Prefixed_Name(ref, "worksWith") |> PrefixedName
    /// <summary>
    ///   <para>ref:wouldLikeToKnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Would Like To Know"</para></remarks>
    /// <seealso href="http://purl.org/vocab/relationship/wouldLikeToKnow">http://purl.org/vocab/relationship/wouldLikeToKnow</seealso>
    let wouldLikeToKnow = Prefixed_Name(ref, "wouldLikeToKnow") |> PrefixedName

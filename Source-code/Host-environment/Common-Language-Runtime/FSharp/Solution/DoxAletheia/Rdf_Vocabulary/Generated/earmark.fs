namespace http.www.essepuntato.it._2008._12.earmark.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module earmark =
    let _namespace_iri = Namespace_Iri earmark |> NamespaceIRI
    /// <summary>
    ///   <para>earmark:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A markup item identifying an attribute, as the item 'src' in the following XML excerpt:
    ///
    /// &lt;img src="http://palindrom.es/phd/wp-content/uploads/2009/10/EARMARKLogo.png" /&gt;"</para>
    /// labels<para>"attribute"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#Attribute">http://www.essepuntato.it/2008/12/earmark#Attribute</seealso>
    let Attribute = Prefixed_Name(earmark, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>earmark:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A markup item identifying a comment, as the item containing the string 'This is a comment' in the following XML excerpt:
    ///
    /// &lt;!-- This is a comment --&gt;"</para>
    /// labels<para>"comment"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#Comment">http://www.essepuntato.it/2008/12/earmark#Comment</seealso>
    let Comment = Prefixed_Name(earmark, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>earmark:Docuverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A container of strings that may appear in the document."</para>
    /// labels<para>"docuverse"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#Docuverse">http://www.essepuntato.it/2008/12/earmark#Docuverse</seealso>
    let Docuverse = Prefixed_Name(earmark, "Docuverse") |> PrefixedName
    /// <summary>
    ///   <para>earmark:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A markup item identifying an element, as the item 'img' in the following XML excerpt:
    ///
    /// &lt;img src="http://palindrom.es/phd/wp-content/uploads/2009/10/EARMARKLogo.png" /&gt;"</para>
    /// labels<para>"element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#Element">http://www.essepuntato.it/2008/12/earmark#Element</seealso>
    let Element = Prefixed_Name(earmark, "Element") |> PrefixedName
    /// <summary>
    ///   <para>earmark:MarkupItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An artifact to be interpreted as markup (such as elements, attributes and comments), defined as a collection – ordered (List, Bag) or not (Set) – of other markup items and ranges."</para>
    /// labels<para>"markup item"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#MarkupItem">http://www.essepuntato.it/2008/12/earmark#MarkupItem</seealso>
    let MarkupItem = Prefixed_Name(earmark, "MarkupItem") |> PrefixedName
    /// <summary>
    ///   <para>earmark:PointerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A range that refers to any text lying between two non-negative integer locations that identify precise positions withing a docuverse.
    ///
    /// Each location of this kind of range refers to a point before or after a particular character. For instance, taking into consideration the string 'This is an example' contained by a docuverse, the location '0' is immediately before the first character 'T', location '1' is immediately after the character 'T' and before the character 'h', the location '2' is after the character 'h' and before 'i', and so on.
    ///
    /// Note that these ranges allow to define (considering the string 'a devil' as content of a docuverse as example):
    /// - document-order ranges, i.e., those ranges that has the begin location lesser than the end location (e.g., begin = 2, end = 7, content result 'devil');
    /// - reverse-order ranges, i.e., those ranges that has the begin location greater than the end location (e.g., begin = 7, end = 2, content result 'lived')."</para>
    /// labels<para>"pointer range"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#PointerRange">http://www.essepuntato.it/2008/12/earmark#PointerRange</seealso>
    let PointerRange = Prefixed_Name(earmark, "PointerRange") |> PrefixedName
    /// <summary>
    ///   <para>earmark:Range</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity referring to any text of a docuverse lying between two locations."</para>
    /// labels<para>"range"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#Range">http://www.essepuntato.it/2008/12/earmark#Range</seealso>
    let Range = Prefixed_Name(earmark, "Range") |> PrefixedName
    /// <summary>
    ///   <para>earmark:StringDocuverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A docuverse that specifies all its content in form of a string, such as 'This is the string the docuverse represents.'."</para>
    /// labels<para>"string docuverse"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#StringDocuverse">http://www.essepuntato.it/2008/12/earmark#StringDocuverse</seealso>
    let StringDocuverse = Prefixed_Name(earmark, "StringDocuverse") |> PrefixedName
    /// <summary>
    ///   <para>earmark:URIDocuverse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A container of strings that may appear in the document, such as the URL 'http://www.essepuntato.it/2008/12/docuverse.txt' that contains the string 'This is the string the docuverse represents.'"</para>
    /// labels<para>"URI docuverse"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#URIDocuverse">http://www.essepuntato.it/2008/12/earmark#URIDocuverse</seealso>
    let URIDocuverse = Prefixed_Name(earmark, "URIDocuverse") |> PrefixedName
    /// <summary>
    ///   <para>earmark:XPathPointerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A range that refers to any text, obtained from a particular xpath context starting from a docuverse content, lying between two non-negative integere locations that identify precise positions.
    ///
    /// This kind of range allows to define specific positions, as explained for the class 'PointerRange', within the concatenation of strings obtained by applying the xpath context to the docuverse the range refers to, as introduce in the class 'XPathRange'.
    ///
    /// For instance, considering the following docuverse content:
    ///
    /// &lt;root&gt;&lt;p&gt;No devil &lt;/p&gt;&lt;p&gt;lived on&lt;/p&gt;&lt;/root&gt;
    ///
    /// the range defined on that docuverse as xpath_context = '//p', begin = '0', end = '17' refers to the text 'No devil lived on'.
    ///
    /// NB: if we define a standard pointer range on the same docuverse using the same begin and end locations of the previous one, what we obtain as text will be '&lt;root&gt;&lt;p&gt;No devil'."</para>
    /// labels<para>"xpath pointer range"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#XPathPointerRange">http://www.essepuntato.it/2008/12/earmark#XPathPointerRange</seealso>
    let XPathPointerRange = Prefixed_Name(earmark, "XPathPointerRange") |> PrefixedName
    /// <summary>
    ///   <para>earmark:XPathRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A range that refers to any text, obtained from a particular xpath context starting from the docuverse content, lying between two locations that identify precise positions.
    ///
    /// The semantics of this kind of range is the following:
    /// 1. assuming the content of the docuverse the range refers to as well-formed XML, we consider the sequence composed by the nodes obtained by running the xpath context (= a query) on the docuverse. If some non-nodes (e.g., strings, integers, etc.) is returned, it must be excluded from the sequence;
    /// 2. for each node in the sequence, we consider its 'value-of', i.e., the strings contained in all the text nodes reachable starting from the node itself;
    /// 3. considering the concatenation of all the strings obtained in the previous point, we now calculate the begin and end locations of the range."</para>
    /// labels<para>"xpath range"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#XPathRange">http://www.essepuntato.it/2008/12/earmark#XPathRange</seealso>
    let XPathRange = Prefixed_Name(earmark, "XPathRange") |> PrefixedName
    /// <summary>
    ///   <para>earmark:begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"It defines the starting location of a range within the docuverse it refers to."</para>
    /// labels<para>"begins at"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#begins">http://www.essepuntato.it/2008/12/earmark#begins</seealso>
    let begins = Prefixed_Name(earmark, "begins") |> PrefixedName
    /// <summary>
    ///   <para>earmark:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"It defines the ending location of a range within the docuverse it refers to."</para>
    /// labels<para>"ends at"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#ends">http://www.essepuntato.it/2008/12/earmark#ends</seealso>
    let ends = Prefixed_Name(earmark, "ends") |> PrefixedName
    /// <summary>
    ///   <para>earmark:hasContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Used to specify a content for a particular docuverse."</para>
    /// labels<para>"has content"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#hasContent">http://www.essepuntato.it/2008/12/earmark#hasContent</seealso>
    let hasContent = Prefixed_Name(earmark, "hasContent") |> PrefixedName

    /// <summary>
    ///   <para>earmark:hasGeneralIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It specifies the common name, called general identifier, of a markup item."</para>
    /// labels<para>"has general identifier"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#hasGeneralIdentifier">http://www.essepuntato.it/2008/12/earmark#hasGeneralIdentifier</seealso>
    let hasGeneralIdentifier =
        Prefixed_Name(earmark, "hasGeneralIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>earmark:hasNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It specifies the namespace of a markup item."</para>
    /// labels<para>"has namespace"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#hasNamespace">http://www.essepuntato.it/2008/12/earmark#hasNamespace</seealso>
    let hasNamespace = Prefixed_Name(earmark, "hasNamespace") |> PrefixedName
    /// <summary>
    ///   <para>earmark:hasXPathContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"It defines a particular xpath context for the range."</para>
    /// labels<para>"has xpath context"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#hasXPathContext">http://www.essepuntato.it/2008/12/earmark#hasXPathContext</seealso>
    let hasXPathContext = Prefixed_Name(earmark, "hasXPathContext") |> PrefixedName
    /// <summary>
    ///   <para>earmark:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Used to indicate the docuverse a range refers to."</para>
    /// labels<para>"refers to"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/earmark#refersTo">http://www.essepuntato.it/2008/12/earmark#refersTo</seealso>
    let refersTo = Prefixed_Name(earmark, "refersTo") |> PrefixedName

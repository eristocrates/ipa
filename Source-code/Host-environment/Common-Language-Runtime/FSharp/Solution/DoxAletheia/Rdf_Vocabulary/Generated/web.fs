namespace http.www.w3.org._2007.uwa.context.web.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module web =
    let _namespace_iri = Namespace_Iri web |> NamespaceIRI

    /// <summary>
    ///   <para>web:CTransformationProxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Content Transformation Proxy, an intermediary in the communications path between a web browser and the origin server. These intermediary adjust HTML pages designed for desktop presentation to provide an enhanced user experience when accessed from a mobile device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Content Transformation Proxy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#CTransformationProxy">http://www.w3.org/2007/uwa/context/web.owl#CTransformationProxy</seealso>
    let CTransformationProxy =
        Prefixed_Name(web, "CTransformationProxy") |> PrefixedName

    /// <summary>
    ///   <para>web:Context_WebBrowsingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class subsumes all the Delivery Context entities that have to do with web browsing characteristics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Web Browser Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Context_WebBrowsingEntity">http://www.w3.org/2007/uwa/context/web.owl#Context_WebBrowsingEntity</seealso>
    let Context_WebBrowsingEntity =
        Prefixed_Name(web, "Context_WebBrowsingEntity") |> PrefixedName

    /// <summary>
    ///   <para>web:DOMLevel3Events</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#DOMLevel3Events">http://www.w3.org/2007/uwa/context/web.owl#DOMLevel3Events</seealso>
    let DOMLevel3Events = Prefixed_Name(web, "DOMLevel3Events") |> PrefixedName
    /// <summary>
    ///   <para>web:DomLevel0</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"DOM Level 0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#DomLevel0">http://www.w3.org/2007/uwa/context/web.owl#DomLevel0</seealso>
    let DomLevel0 = Prefixed_Name(web, "DomLevel0") |> PrefixedName
    /// <summary>
    ///   <para>web:ECMAScript_1.2</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:ScriptLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#ECMAScript_1.2">http://www.w3.org/2007/uwa/context/web.owl#ECMAScript_1.2</seealso>
    let ``ECMAScript_1.2`` = Prefixed_Name(web, "ECMAScript_1.2") |> PrefixedName
    /// <summary>
    ///   <para>web:HTML_3_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>"HTML 3.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#HTML_3_2">http://www.w3.org/2007/uwa/context/web.owl#HTML_3_2</seealso>
    let HTML_3_2 = Prefixed_Name(web, "HTML_3_2") |> PrefixedName
    /// <summary>
    ///   <para>web:HTML_4_0_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>"HTML 4 Strict"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#HTML_4_0_1">http://www.w3.org/2007/uwa/context/web.owl#HTML_4_0_1</seealso>
    let HTML_4_0_1 = Prefixed_Name(web, "HTML_4_0_1") |> PrefixedName

    /// <summary>
    ///   <para>web:HTML_4_0_1_Transitional</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>"HTML 4.01 Transitional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#HTML_4_0_1_Transitional">http://www.w3.org/2007/uwa/context/web.owl#HTML_4_0_1_Transitional</seealso>
    let HTML_4_0_1_Transitional =
        Prefixed_Name(web, "HTML_4_0_1_Transitional") |> PrefixedName

    /// <summary>
    ///   <para>web:JavaScript_1.1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:ScriptLanguage</para>
    ///   <para>"Javascript 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#JavaScript_1.1">http://www.w3.org/2007/uwa/context/web.owl#JavaScript_1.1</seealso>
    let ``JavaScript_1.1`` = Prefixed_Name(web, "JavaScript_1.1") |> PrefixedName
    /// <summary>
    ///   <para>web:MarkupModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a module of a markup language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Markup Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#MarkupModule">http://www.w3.org/2007/uwa/context/web.owl#MarkupModule</seealso>
    let MarkupModule = Prefixed_Name(web, "MarkupModule") |> PrefixedName
    /// <summary>
    ///   <para>web:MarkupModule_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#MarkupModule_1">http://www.w3.org/2007/uwa/context/web.owl#MarkupModule_1</seealso>
    let MarkupModule_1 = Prefixed_Name(web, "MarkupModule_1") |> PrefixedName
    /// <summary>
    ///   <para>web:PageMarkup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A page markup language, such as HTML or WML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Standard Page Markup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#PageMarkup">http://www.w3.org/2007/uwa/context/web.owl#PageMarkup</seealso>
    let PageMarkup = Prefixed_Name(web, "PageMarkup") |> PrefixedName

    /// <summary>
    ///   <para>web:Partial_OMA_XHTML-MP_Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"Partial support of the Xhtml1 presentation module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML-MP_Presentation">http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML-MP_Presentation</seealso>
    let Partial_OMA_XHTML_MP_Presentation =
        Prefixed_Name(web, "Partial_OMA_XHTML-MP_Presentation") |> PrefixedName

    /// <summary>
    ///   <para>web:Partial_OMA_XHTML_MP_Forms</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_Forms">http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_Forms</seealso>
    let Partial_OMA_XHTML_MP_Forms =
        Prefixed_Name(web, "Partial_OMA_XHTML_MP_Forms") |> PrefixedName

    /// <summary>
    ///   <para>web:Partial_OMA_XHTML_MP_IntrinsicEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_IntrinsicEvents">http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_IntrinsicEvents</seealso>
    let Partial_OMA_XHTML_MP_IntrinsicEvents =
        Prefixed_Name(web, "Partial_OMA_XHTML_MP_IntrinsicEvents") |> PrefixedName

    /// <summary>
    ///   <para>web:Partial_OMA_XHTML_MP_Legacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_Legacy">http://www.w3.org/2007/uwa/context/web.owl#Partial_OMA_XHTML_MP_Legacy</seealso>
    let Partial_OMA_XHTML_MP_Legacy =
        Prefixed_Name(web, "Partial_OMA_XHTML_MP_Legacy") |> PrefixedName

    /// <summary>
    ///   <para>web:SVG_1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"SVG 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SVG_1_0">http://www.w3.org/2007/uwa/context/web.owl#SVG_1_0</seealso>
    let SVG_1_0 = Prefixed_Name(web, "SVG_1_0") |> PrefixedName
    /// <summary>
    ///   <para>web:SVG_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"SVG 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1">http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1</seealso>
    let SVG_1_1 = Prefixed_Name(web, "SVG_1_1") |> PrefixedName
    /// <summary>
    ///   <para>web:SVG_1_1_Basic</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"SVG 1.1 Tiny"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1_Basic">http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1_Basic</seealso>
    let SVG_1_1_Basic = Prefixed_Name(web, "SVG_1_1_Basic") |> PrefixedName
    /// <summary>
    ///   <para>web:SVG_1_1_Tiny</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"SVG 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1_Tiny">http://www.w3.org/2007/uwa/context/web.owl#SVG_1_1_Tiny</seealso>
    let SVG_1_1_Tiny = Prefixed_Name(web, "SVG_1_1_Tiny") |> PrefixedName
    /// <summary>
    ///   <para>web:SVG_1_2_Tiny</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"SVG 1.2 Tiny"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SVG_1_2_Tiny">http://www.w3.org/2007/uwa/context/web.owl#SVG_1_2_Tiny</seealso>
    let SVG_1_2_Tiny = Prefixed_Name(web, "SVG_1_2_Tiny") |> PrefixedName
    /// <summary>
    ///   <para>web:ScriptLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Script language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Script Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#ScriptLanguage">http://www.w3.org/2007/uwa/context/web.owl#ScriptLanguage</seealso>
    let ScriptLanguage = Prefixed_Name(web, "ScriptLanguage") |> PrefixedName
    /// <summary>
    ///   <para>web:SiblingDisjoint2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SiblingDisjoint2">http://www.w3.org/2007/uwa/context/web.owl#SiblingDisjoint2</seealso>
    let SiblingDisjoint2 = Prefixed_Name(web, "SiblingDisjoint2") |> PrefixedName
    /// <summary>
    ///   <para>web:SiblingDisjoint3</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#SiblingDisjoint3">http://www.w3.org/2007/uwa/context/web.owl#SiblingDisjoint3</seealso>
    let SiblingDisjoint3 = Prefixed_Name(web, "SiblingDisjoint3") |> PrefixedName
    /// <summary>
    ///   <para>web:Sibling_Disjoint1</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    ///   <para>"Web Entities Disjoint Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Entities Disjoint Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Sibling_Disjoint1">http://www.w3.org/2007/uwa/context/web.owl#Sibling_Disjoint1</seealso>
    let Sibling_Disjoint1 = Prefixed_Name(web, "Sibling_Disjoint1") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Style language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Style Language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage</seealso>
    let StyleLanguage = Prefixed_Name(web, "StyleLanguage") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_39</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_39">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_39</seealso>
    let StyleLanguage_39 = Prefixed_Name(web, "StyleLanguage_39") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_41</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_41">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_41</seealso>
    let StyleLanguage_41 = Prefixed_Name(web, "StyleLanguage_41") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_42</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_42">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_42</seealso>
    let StyleLanguage_42 = Prefixed_Name(web, "StyleLanguage_42") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_43</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_43">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_43</seealso>
    let StyleLanguage_43 = Prefixed_Name(web, "StyleLanguage_43") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_44</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_44">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_44</seealso>
    let StyleLanguage_44 = Prefixed_Name(web, "StyleLanguage_44") |> PrefixedName
    /// <summary>
    ///   <para>web:StyleLanguage_9</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_9">http://www.w3.org/2007/uwa/context/web.owl#StyleLanguage_9</seealso>
    let StyleLanguage_9 = Prefixed_Name(web, "StyleLanguage_9") |> PrefixedName
    /// <summary>
    ///   <para>web:TermGroup_Web</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"This group of terms models a minimal set of properties and classes that allow to represent the features of a Delivery Context related to the support of Web Browsing technologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Browsing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#TermGroup_Web">http://www.w3.org/2007/uwa/context/web.owl#TermGroup_Web</seealso>
    let TermGroup_Web = Prefixed_Name(web, "TermGroup_Web") |> PrefixedName
    /// <summary>
    ///   <para>web:WCSS11</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:StyleLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WCSS11">http://www.w3.org/2007/uwa/context/web.owl#WCSS11</seealso>
    let WCSS11 = Prefixed_Name(web, "WCSS11") |> PrefixedName
    /// <summary>
    ///   <para>web:WMLScript12</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:ScriptLanguage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WMLScript12">http://www.w3.org/2007/uwa/context/web.owl#WMLScript12</seealso>
    let WMLScript12 = Prefixed_Name(web, "WMLScript12") |> PrefixedName
    /// <summary>
    ///   <para>web:WMLScript13</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:ScriptLanguage</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WMLScript13">http://www.w3.org/2007/uwa/context/web.owl#WMLScript13</seealso>
    let WMLScript13 = Prefixed_Name(web, "WMLScript13") |> PrefixedName
    /// <summary>
    ///   <para>web:WML_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>"WML 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WML_1_1">http://www.w3.org/2007/uwa/context/web.owl#WML_1_1</seealso>
    let WML_1_1 = Prefixed_Name(web, "WML_1_1") |> PrefixedName
    /// <summary>
    ///   <para>web:WebBrowser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Web Browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowser">http://www.w3.org/2007/uwa/context/web.owl#WebBrowser</seealso>
    let WebBrowser = Prefixed_Name(web, "WebBrowser") |> PrefixedName
    /// <summary>
    ///   <para>web:WebBrowserApi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents APIs implemented by Web Browsers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Browser API"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi</seealso>
    let WebBrowserApi = Prefixed_Name(web, "WebBrowserApi") |> PrefixedName
    /// <summary>
    ///   <para>web:WebBrowserApi_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_5">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_5</seealso>
    let WebBrowserApi_5 = Prefixed_Name(web, "WebBrowserApi_5") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL2_CORE</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 2 Core Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 2 Core Api"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_CORE">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_CORE</seealso>
    let WebBrowserApi_DOM_LEVEL2_CORE =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL2_CORE") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL2_EVENTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 2 Events Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 2 Events API"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_EVENTS">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_EVENTS</seealso>
    let WebBrowserApi_DOM_LEVEL2_EVENTS =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL2_EVENTS") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL2_HTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 2 HTML Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 2 HTML Api"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_HTML">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_HTML</seealso>
    let WebBrowserApi_DOM_LEVEL2_HTML =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL2_HTML") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL2_STYLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 2 Style Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 2 Style Api"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_STYLE">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL2_STYLE</seealso>
    let WebBrowserApi_DOM_LEVEL2_STYLE =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL2_STYLE") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL3_CORE</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 3 Core Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 3 API"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL3_CORE">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL3_CORE</seealso>
    let WebBrowserApi_DOM_LEVEL3_CORE =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL3_CORE") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_DOM_LEVEL_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"Document Object Model (DOM) Level 1 Specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DOM Level 1 Api"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL_1">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_DOM_LEVEL_1</seealso>
    let WebBrowserApi_DOM_LEVEL_1 =
        Prefixed_Name(web, "WebBrowserApi_DOM_LEVEL_1") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserApi_SVGDOM_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"SVG Document Object Model (DOM)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_SVGDOM_1_1">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserApi_SVGDOM_1_1</seealso>
    let WebBrowserApi_SVGDOM_1_1 =
        Prefixed_Name(web, "WebBrowserApi_SVGDOM_1_1") |> PrefixedName

    /// <summary>
    ///   <para>web:WebBrowserFeatures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the features of a Web Browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Browser Features"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebBrowserFeatures">http://www.w3.org/2007/uwa/context/web.owl#WebBrowserFeatures</seealso>
    let WebBrowserFeatures = Prefixed_Name(web, "WebBrowserFeatures") |> PrefixedName
    /// <summary>
    ///   <para>web:WebRuntime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a Web Runtime capable of executing widgets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web Runtime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#WebRuntime">http://www.w3.org/2007/uwa/context/web.owl#WebRuntime</seealso>
    let WebRuntime = Prefixed_Name(web, "WebRuntime") |> PrefixedName

    /// <summary>
    ///   <para>web:XForms_OMA_TextInputModes</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XForms_OMA_TextInputModes">http://www.w3.org/2007/uwa/context/web.owl#XForms_OMA_TextInputModes</seealso>
    let XForms_OMA_TextInputModes =
        Prefixed_Name(web, "XForms_OMA_TextInputModes") |> PrefixedName

    /// <summary>
    ///   <para>web:XHTML_1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"XHTML 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_0">http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_0</seealso>
    let XHTML_1_0 = Prefixed_Name(web, "XHTML_1_0") |> PrefixedName

    /// <summary>
    ///   <para>web:XHTML_1_0_Transitional</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"XHTML 1.0 Transitional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_0_Transitional">http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_0_Transitional</seealso>
    let XHTML_1_0_Transitional =
        Prefixed_Name(web, "XHTML_1_0_Transitional") |> PrefixedName

    /// <summary>
    ///   <para>web:XHTML_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"XHTML 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_1">http://www.w3.org/2007/uwa/context/web.owl#XHTML_1_1</seealso>
    let XHTML_1_1 = Prefixed_Name(web, "XHTML_1_1") |> PrefixedName
    /// <summary>
    ///   <para>web:XHTML_Basic_1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>"XHTML Basic 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_Basic_1_0">http://www.w3.org/2007/uwa/context/web.owl#XHTML_Basic_1_0</seealso>
    let XHTML_Basic_1_0 = Prefixed_Name(web, "XHTML_Basic_1_0") |> PrefixedName
    /// <summary>
    ///   <para>web:XHTML_Basic_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"XHTML Basic 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_Basic_1_1">http://www.w3.org/2007/uwa/context/web.owl#XHTML_Basic_1_1</seealso>
    let XHTML_Basic_1_1 = Prefixed_Name(web, "XHTML_Basic_1_1") |> PrefixedName
    /// <summary>
    ///   <para>web:XHTML_MP_1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>"XHTML MP 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_0">http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_0</seealso>
    let XHTML_MP_1_0 = Prefixed_Name(web, "XHTML_MP_1_0") |> PrefixedName
    /// <summary>
    ///   <para>web:XHTML_MP_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>"XHTML MP 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_1">http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_1</seealso>
    let XHTML_MP_1_1 = Prefixed_Name(web, "XHTML_MP_1_1") |> PrefixedName
    /// <summary>
    ///   <para>web:XHTML_MP_1_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:XmlFormat</para>
    ///   <para>web:PageMarkup</para>
    ///   <para>"XHTML MP 1.2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_2">http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_1_2</seealso>
    let XHTML_MP_1_2 = Prefixed_Name(web, "XHTML_MP_1_2") |> PrefixedName

    /// <summary>
    ///   <para>web:XHTML_MP_OpenWave_Ext</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"OpenWave XHTML-MP Extensions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_OpenWave_Ext">http://www.w3.org/2007/uwa/context/web.owl#XHTML_MP_OpenWave_Ext</seealso>
    let XHTML_MP_OpenWave_Ext =
        Prefixed_Name(web, "XHTML_MP_OpenWave_Ext") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Base</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Base Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Base">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Base</seealso>
    let Xhtml11Module_Base = Prefixed_Name(web, "Xhtml11Module_Base") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_BasicForms</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Basic Forms Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_BasicForms">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_BasicForms</seealso>
    let Xhtml11Module_BasicForms =
        Prefixed_Name(web, "Xhtml11Module_BasicForms") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_BasicTables</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Basic Tables Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_BasicTables">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_BasicTables</seealso>
    let Xhtml11Module_BasicTables =
        Prefixed_Name(web, "Xhtml11Module_BasicTables") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Bidirectional</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Bidirectional Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Bidirectional">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Bidirectional</seealso>
    let Xhtml11Module_Bidirectional =
        Prefixed_Name(web, "Xhtml11Module_Bidirectional") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_ClientSideImageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Client Side Image Map Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_ClientSideImageMap">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_ClientSideImageMap</seealso>
    let Xhtml11Module_ClientSideImageMap =
        Prefixed_Name(web, "Xhtml11Module_ClientSideImageMap") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Edit</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Edit Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Edit">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Edit</seealso>
    let Xhtml11Module_Edit = Prefixed_Name(web, "Xhtml11Module_Edit") |> PrefixedName
    /// <summary>
    ///   <para>web:Xhtml11Module_Forms</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1  Forms Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Forms">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Forms</seealso>
    let Xhtml11Module_Forms = Prefixed_Name(web, "Xhtml11Module_Forms") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Hypertext</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"The Hypertext Module provides the element that is used to define hypertext links to other resources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XHTML 1 Hypertext Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Hypertext">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Hypertext</seealso>
    let Xhtml11Module_Hypertext =
        Prefixed_Name(web, "Xhtml11Module_Hypertext") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Image Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Image">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Image</seealso>
    let Xhtml11Module_Image = Prefixed_Name(web, "Xhtml11Module_Image") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_IntrinsicEvents</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Intrinsic Events Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_IntrinsicEvents">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_IntrinsicEvents</seealso>
    let Xhtml11Module_IntrinsicEvents =
        Prefixed_Name(web, "Xhtml11Module_IntrinsicEvents") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Link Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Link">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Link</seealso>
    let Xhtml11Module_Link = Prefixed_Name(web, "Xhtml11Module_Link") |> PrefixedName
    /// <summary>
    ///   <para>web:Xhtml11Module_List</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"As its name suggests, the List Module provides list-oriented elements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XHTML 1 List Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_List">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_List</seealso>
    let Xhtml11Module_List = Prefixed_Name(web, "Xhtml11Module_List") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Metainformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Metainformation Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Metainformation">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Metainformation</seealso>
    let Xhtml11Module_Metainformation =
        Prefixed_Name(web, "Xhtml11Module_Metainformation") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Object Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Object">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Object</seealso>
    let Xhtml11Module_Object =
        Prefixed_Name(web, "Xhtml11Module_Object") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Presentation Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Presentation">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Presentation</seealso>
    let Xhtml11Module_Presentation =
        Prefixed_Name(web, "Xhtml11Module_Presentation") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Scripting</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Scripting Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Scripting">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Scripting</seealso>
    let Xhtml11Module_Scripting =
        Prefixed_Name(web, "Xhtml11Module_Scripting") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_ServerSideImageMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Server Side Image Map Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_ServerSideImageMap">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_ServerSideImageMap</seealso>
    let Xhtml11Module_ServerSideImageMap =
        Prefixed_Name(web, "Xhtml11Module_ServerSideImageMap") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"The Structure Module defines the major structural elements for XHTML. These elements effectively act as the basis for the content model of many XHTML family document types."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XHTML 1 Structure Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Structure">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Structure</seealso>
    let Xhtml11Module_Structure =
        Prefixed_Name(web, "Xhtml11Module_Structure") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Stylesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1Stylesheet Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Stylesheet">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Stylesheet</seealso>
    let Xhtml11Module_Stylesheet =
        Prefixed_Name(web, "Xhtml11Module_Stylesheet") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml11Module_Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Table Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Table">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Table</seealso>
    let Xhtml11Module_Table = Prefixed_Name(web, "Xhtml11Module_Table") |> PrefixedName
    /// <summary>
    ///   <para>web:Xhtml11Module_Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"This module defines all of the basic text container elements, attributes, and their content model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XHTML 1 Text Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Text">http://www.w3.org/2007/uwa/context/web.owl#Xhtml11Module_Text</seealso>
    let Xhtml11Module_Text = Prefixed_Name(web, "Xhtml11Module_Text") |> PrefixedName
    /// <summary>
    ///   <para>web:Xhtml1Module_Iframe</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 iFrame Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Iframe">http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Iframe</seealso>
    let Xhtml1Module_Iframe = Prefixed_Name(web, "Xhtml1Module_Iframe") |> PrefixedName
    /// <summary>
    ///   <para>web:Xhtml1Module_Legacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Legacy Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Legacy">http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Legacy</seealso>
    let Xhtml1Module_Legacy = Prefixed_Name(web, "Xhtml1Module_Legacy") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml1Module_StyleAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Style Attribute Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_StyleAttribute">http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_StyleAttribute</seealso>
    let Xhtml1Module_StyleAttribute =
        Prefixed_Name(web, "Xhtml1Module_StyleAttribute") |> PrefixedName

    /// <summary>
    ///   <para>web:Xhtml1Module_Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:MarkupModule</para>
    ///   <para>"XHTML 1 Target Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Target">http://www.w3.org/2007/uwa/context/web.owl#Xhtml1Module_Target</seealso>
    let Xhtml1Module_Target = Prefixed_Name(web, "Xhtml1Module_Target") |> PrefixedName
    /// <summary>
    ///   <para>web:XmlHttpRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserApi</para>
    ///   <para>"XMLHttpRequest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#XmlHttpRequest">http://www.w3.org/2007/uwa/context/web.owl#XmlHttpRequest</seealso>
    let XmlHttpRequest = Prefixed_Name(web, "XmlHttpRequest") |> PrefixedName
    /// <summary>
    ///   <para>web:availableWREs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the Web Runtime Environments which are available on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Available Web Runtime Environments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#availableWREs">http://www.w3.org/2007/uwa/context/web.owl#availableWREs</seealso>
    let availableWREs = Prefixed_Name(web, "availableWREs") |> PrefixedName
    /// <summary>
    ///   <para>web:cHTML</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>"Compact HTML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#cHTML">http://www.w3.org/2007/uwa/context/web.owl#cHTML</seealso>
    let cHTML = Prefixed_Name(web, "cHTML") |> PrefixedName
    /// <summary>
    ///   <para>web:cacheSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The size of the cache (in bytes) implemented by the browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cache Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#cacheSize">http://www.w3.org/2007/uwa/context/web.owl#cacheSize</seealso>
    let cacheSize = Prefixed_Name(web, "cacheSize") |> PrefixedName
    /// <summary>
    ///   <para>web:defaultWRE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the default Web Runtime Environment on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Web Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#defaultWRE">http://www.w3.org/2007/uwa/context/web.owl#defaultWRE</seealso>
    let defaultWRE = Prefixed_Name(web, "defaultWRE") |> PrefixedName
    /// <summary>
    ///   <para>web:defaultWebBrowser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The default Web Browser in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Web Browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#defaultWebBrowser">http://www.w3.org/2007/uwa/context/web.owl#defaultWebBrowser</seealso>
    let defaultWebBrowser = Prefixed_Name(web, "defaultWebBrowser") |> PrefixedName
    /// <summary>
    ///   <para>web:i-HTML_7_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>"Other i-Mode steps can be easily added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#i-HTML_7_0">http://www.w3.org/2007/uwa/context/web.owl#i-HTML_7_0</seealso>
    let i_HTML_7_0 = Prefixed_Name(web, "i-HTML_7_0") |> PrefixedName
    /// <summary>
    ///   <para>web:i-XHTML_1_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:PageMarkup</para>
    ///   <para>soft:XmlFormat</para>
    ///   <para>"Japanese i-XHTML 1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#i-XHTML_1_0">http://www.w3.org/2007/uwa/context/web.owl#i-XHTML_1_0</seealso>
    let i_XHTML_1_0 = Prefixed_Name(web, "i-XHTML_1_0") |> PrefixedName
    /// <summary>
    ///   <para>web:javascriptEnabled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates whether Javascript is enabled or not in the web browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Javascript Enabled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#javascriptEnabled">http://www.w3.org/2007/uwa/context/web.owl#javascriptEnabled</seealso>
    let javascriptEnabled = Prefixed_Name(web, "javascriptEnabled") |> PrefixedName
    /// <summary>
    ///   <para>web:markupModules</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The modules used by a markup language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Markup Modules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#markupModules">http://www.w3.org/2007/uwa/context/web.owl#markupModules</seealso>
    let markupModules = Prefixed_Name(web, "markupModules") |> PrefixedName
    /// <summary>
    ///   <para>web:maxCacheObjectSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The maximum size of an object in the browser cache in bytes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Cache Object Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#maxCacheObjectSize">http://www.w3.org/2007/uwa/context/web.owl#maxCacheObjectSize</seealso>
    let maxCacheObjectSize = Prefixed_Name(web, "maxCacheObjectSize") |> PrefixedName

    /// <summary>
    ///   <para>web:maxDownloadableObjectSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum size in bytes for content (image, ringtone, etc.) downloaded via web browser"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Downloadable Object Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#maxDownloadableObjectSize">http://www.w3.org/2007/uwa/context/web.owl#maxDownloadableObjectSize</seealso>
    let maxDownloadableObjectSize =
        Prefixed_Name(web, "maxDownloadableObjectSize") |> PrefixedName

    /// <summary>
    ///   <para>web:maxEmbeddedObjectSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Maximum size in bytes for media embedded in web pages"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Embedded Object Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#maxEmbeddedObjectSize">http://www.w3.org/2007/uwa/context/web.owl#maxEmbeddedObjectSize</seealso>
    let maxEmbeddedObjectSize =
        Prefixed_Name(web, "maxEmbeddedObjectSize") |> PrefixedName

    /// <summary>
    ///   <para>web:maxTotalPageWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum page weight in bytes supported by a browser (this includes the markup and all the possible referenced objects in the page) such as images, styleSheets, script files, etc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Total Page Weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#maxTotalPageWeight">http://www.w3.org/2007/uwa/context/web.owl#maxTotalPageWeight</seealso>
    let maxTotalPageWeight = Prefixed_Name(web, "maxTotalPageWeight") |> PrefixedName
    /// <summary>
    ///   <para>web:publicIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The public identifier of an XML format or module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Public Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#publicIdentifier">http://www.w3.org/2007/uwa/context/web.owl#publicIdentifier</seealso>
    let publicIdentifier = Prefixed_Name(web, "publicIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>web:rendersTables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether the browser renders tables or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Renders Tables"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#rendersTables">http://www.w3.org/2007/uwa/context/web.owl#rendersTables</seealso>
    let rendersTables = Prefixed_Name(web, "rendersTables") |> PrefixedName
    /// <summary>
    ///   <para>web:showsAcessKeys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates whether the browser displays automatically the character associated to access keys  or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shows Access Keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#showsAcessKeys">http://www.w3.org/2007/uwa/context/web.owl#showsAcessKeys</seealso>
    let showsAcessKeys = Prefixed_Name(web, "showsAcessKeys") |> PrefixedName
    /// <summary>
    ///   <para>web:showsPageTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether the browser displays the title of the current page or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Shows Page Title"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#showsPageTitle">http://www.w3.org/2007/uwa/context/web.owl#showsPageTitle</seealso>
    let showsPageTitle = Prefixed_Name(web, "showsPageTitle") |> PrefixedName
    /// <summary>
    ///   <para>web:supportsAccessKeys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates whether the browser supports access keys or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supports Access Keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#supportsAccessKeys">http://www.w3.org/2007/uwa/context/web.owl#supportsAccessKeys</seealso>
    let supportsAccessKeys = Prefixed_Name(web, "supportsAccessKeys") |> PrefixedName
    /// <summary>
    ///   <para>web:supportsCookies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates whether the browser supports cookies or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supports Cookies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/web.owl#supportsCookies">http://www.w3.org/2007/uwa/context/web.owl#supportsCookies</seealso>
    let supportsCookies = Prefixed_Name(web, "supportsCookies") |> PrefixedName

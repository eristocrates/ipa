#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module common =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2007/uwa/context/common.owl#" "common"

    /// <summary>
    ///   <para>common:informativeReference : http://www.w3.org/TR/2004/REC-owl-semantics-20040210/syntax.html#2.3.2.1^^xsd:string</para>
    ///   <para>rdfs:label : All Disjoint Set^^xsd:string</para>
    ///   <para>rdfs:comment : This is an utility class for representing groups of classes that are pairwise disjoint, following the approach specified by the OWL Abstract Syntax. This class has been created as a workaround to the absence in OWL 1 of an specific construct for establishing class disjointness between groups of classes^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#AllDisjointSet">common:AllDisjointSet</a>
    /// </summary>
    let AllDisjointSet = _prefixId.prefix "AllDisjointSet"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : Push-SupportedBearers^^xsd:string</para>
    ///   <para>rdfs:label : Application Protocol^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents application-level protocols^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol">common:ApplicationProtocol</a>
    /// </summary>
    let ApplicationProtocol = _prefixId.prefix "ApplicationProtocol"
    let ApplicationProtocol_21 = _prefixId.prefix "ApplicationProtocol_21"
    let ApplicationProtocol_22 = _prefixId.prefix "ApplicationProtocol_22"
    let ApplicationProtocol_23 = _prefixId.prefix "ApplicationProtocol_23"
    let ApplicationProtocol_24 = _prefixId.prefix "ApplicationProtocol_24"
    let ApplicationProtocol_26 = _prefixId.prefix "ApplicationProtocol_26"
    let ApplicationProtocol_27 = _prefixId.prefix "ApplicationProtocol_27"
    let ApplicationProtocol_28 = _prefixId.prefix "ApplicationProtocol_28"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : InputCharset^^xsd:stringcommon:relatedUAProfEntity : OutputCharset^^xsd:stringcommon:relatedUAProfEntity : CcppAccept-Charset^^xsd:string</para>
    ///   <para>common:normativeReference : http://tools.ietf.org/html/rfc2045#section-2.2^^xsd:anyURI</para>
    ///   <para>rdfs:label : Character Set^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents specific character sets officially identified by IANA^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet">common:CharacterSet</a>
    /// </summary>
    let CharacterSet = _prefixId.prefix "CharacterSet"

    let CharacterSet_CharacterSet_UTF_7 = _prefixId.prefix "CharacterSet_CharacterSet_UTF-7"

    let CharacterSet_ISO_10646_UCS_2 = _prefixId.prefix "CharacterSet_ISO-10646-UCS-2"
    let CharacterSet_ISO_8859_1 = _prefixId.prefix "CharacterSet_ISO-8859-1"
    let CharacterSet_ISO_8859_2 = _prefixId.prefix "CharacterSet_ISO-8859-2"
    let CharacterSet_US_ASCII = _prefixId.prefix "CharacterSet_US-ASCII"
    let CharacterSet_UTF_16 = _prefixId.prefix "CharacterSet_UTF-16"
    let CharacterSet_UTF_16be = _prefixId.prefix "CharacterSet_UTF-16be"
    let CharacterSet_UTF_16le = _prefixId.prefix "CharacterSet_UTF-16le"
    let CharacterSet_WINDOWS_1252 = _prefixId.prefix "CharacterSet_WINDOWS-1252"
    /// <summary>
    ///   <para>common:normativeReference : http://www.ietf.org/rfc/rfc2046.txt^^xsd:anyURIcommon:normativeReference : http://www.iana.org/assignments/media-types/^^xsd:anyURI</para>
    ///   <para>rdfs:label : Content Type^^xsd:string</para>
    ///   <para>rdfs:comment : This is a class that represents content types,  the combination of a MIME media type, subtype and optional parameters^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#ContentType">common:ContentType</a>
    /// </summary>
    let ContentType = _prefixId.prefix "ContentType"
    /// <summary>
    ///   <para>rdfs:label : Context Common Entity^^xsd:string</para>
    ///   <para>rdfs:comment : This class subsumes all the general purpose classes^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#Context_CommonEntity">common:Context_CommonEntity</a>
    /// </summary>
    let Context_CommonEntity = _prefixId.prefix "Context_CommonEntity"
    let EnglishUSA = _prefixId.prefix "EnglishUSA"
    /// <summary>
    ///   <para>rdfs:label : Feature^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents features, which are distinguishing characteristics of an item^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#Feature">common:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : Feature Restriction^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents feature restrictions related to an implementation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#FeatureRestriction">common:FeatureRestriction</a>
    /// </summary>
    let FeatureRestriction = _prefixId.prefix "FeatureRestriction"
    let Informative = _prefixId.prefix "Informative"
    /// <summary>
    ///   <para>rdfs:label : Input Modality^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents input modalities^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#InputModality">common:InputModality</a>
    /// </summary>
    let InputModality = _prefixId.prefix "InputModality"
    let InputModality_GESTURE = _prefixId.prefix "InputModality_GESTURE"
    let InputModality_TACTILE = _prefixId.prefix "InputModality_TACTILE"
    let InputModality_TYPING = _prefixId.prefix "InputModality_TYPING"
    let InputModality_VOICE = _prefixId.prefix "InputModality_VOICE"
    /// <summary>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents languages^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#Language">common:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    let MIME_TYPE_GIF = _prefixId.prefix "MIME_TYPE_GIF"
    /// <summary>
    ///   <para>common:informativeReference : http://www.w3.org/TR/2003/NOTE-mmi-reqs-20030108/#modality^^xsd:string</para>
    ///   <para>rdfs:label : Modality^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents modalities, the type of communication channel used for interaction. It also covers the way an idea is expressed or perceived, or the manner in which an action is performed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#Modality">common:Modality</a>
    /// </summary>
    let Modality = _prefixId.prefix "Modality"
    let Normative = _prefixId.prefix "Normative"
    /// <summary>
    ///   <para>rdfs:label : Normative Status^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the normative status of an entity in the ontology. It is used  as an auxiliary element for automatic documentation generation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#NormativeStatus">common:NormativeStatus</a>
    /// </summary>
    let NormativeStatus = _prefixId.prefix "NormativeStatus"
    /// <summary>
    ///   <para>rdfs:label : Output Modality^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents output modalities^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality">common:OutputModality</a>
    /// </summary>
    let OutputModality = _prefixId.prefix "OutputModality"
    let OutputModality_AURAL = _prefixId.prefix "OutputModality_AURAL"
    let OutputModality_TACTILE = _prefixId.prefix "OutputModality_TACTILE"
    let OutputModality_VISUAL = _prefixId.prefix "OutputModality_VISUAL"
    let Sibling_Disjoint = _prefixId.prefix "Sibling_Disjoint"
    /// <summary>
    ///   <para>rdfs:label : Sound Mode^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the sound modes that can be chosen by the user of a device^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode">common:SoundMode</a>
    /// </summary>
    let SoundMode = _prefixId.prefix "SoundMode"
    let SoundMode_NORMAL = _prefixId.prefix "SoundMode_NORMAL"
    let SoundMode_SILENCE = _prefixId.prefix "SoundMode_SILENCE"
    let SpanishSpain = _prefixId.prefix "SpanishSpain"
    /// <summary>
    ///   <para>rdfs:label : Term Group^^xsd:string</para>
    ///   <para>rdfs:comment : This is an utility class that serves to represent the different term groups that compose the Delivery Context Ontology^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#TermGroup">common:TermGroup</a>
    /// </summary>
    let TermGroup = _prefixId.prefix "TermGroup"
    let TermGroup_Common = _prefixId.prefix "TermGroup_Common"
    /// <summary>
    ///   <para>common:informativeReference : http://www.w3.org/TR/2005/NOTE-timezone-20051013/^^xsd:string</para>
    ///   <para>rdfs:label : Timezone^^xsd:string</para>
    ///   <para>rdfs:comment : A time zone is an identifier for a specific location or region which translates into a combination of rules for calculating an UTC offset^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#TimeZone">common:TimeZone</a>
    /// </summary>
    let TimeZone = _prefixId.prefix "TimeZone"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : CcppAccept-Encoding^^xsd:string</para>
    ///   <para>common:normativeReference : http://tools.ietf.org/html/rfc2045#section-6^^xsd:anyURI</para>
    ///   <para>rdfs:label : Transfer Encoding^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents transfer encoding formats as specified by RFC 2045 and registered with IANA^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding">common:TransferEncoding</a>
    /// </summary>
    let TransferEncoding = _prefixId.prefix "TransferEncoding"
    let TransferEncoding_7bit = _prefixId.prefix "TransferEncoding_7bit"
    let TransferEncoding_8bit = _prefixId.prefix "TransferEncoding_8bit"
    let TransferEncoding_Base64 = _prefixId.prefix "TransferEncoding_Base64"
    let TransferEncoding_Binary = _prefixId.prefix "TransferEncoding_Binary"

    let TransferEncoding_QuotedPrintable = _prefixId.prefix "TransferEncoding_QuotedPrintable"

    let UTF_8 = _prefixId.prefix "UTF-8"
    let UriSchema_31 = _prefixId.prefix "UriSchema_31"
    let UriSchema_32 = _prefixId.prefix "UriSchema_32"
    let UriSchema_34 = _prefixId.prefix "UriSchema_34"
    let UriSchema_37 = _prefixId.prefix "UriSchema_37"
    /// <summary>
    ///   <para>common:normativeReference : http://tools.ietf.org/html/rfc3986^^xsd:anyURI</para>
    ///   <para>rdfs:label : URI Schema^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents URI Schemas as per RFC 3986^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#UriScheme">common:UriScheme</a>
    /// </summary>
    let UriScheme = _prefixId.prefix "UriScheme"
    let UriScheme_HTTP = _prefixId.prefix "UriScheme_HTTP"
    let Utility = _prefixId.prefix "Utility"
    /// <summary>
    ///   <para>rdfs:label : Vendor^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a vendor, i.e an entity that commercializes a product^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#Vendor">common:Vendor</a>
    /// </summary>
    let Vendor = _prefixId.prefix "Vendor"
    /// <summary>
    ///   <para>rdfs:label : Active^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents a generic relationship between a Context Entity and other Context Entities which are  active in the scope of the former. For instance, the active Bluetooth Profile of a Device or the active Font within an Application^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#active">common:active</a>
    /// </summary>
    let active = _prefixId.prefix "active"
    /// <summary>
    ///   <para>rdfs:label : Available^^xsd:string</para>
    ///   <para>rdfs:comment : A generic property that represents Context Entities that are available^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#available">common:available</a>
    /// </summary>
    let available = _prefixId.prefix "available"
    /// <summary>
    ///   <para>common:normativeReference : http://www.iana.org/assignments/character-sets^^xsd:anyURI</para>
    ///   <para>rdfs:label : Character Set Name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a charset officially assigned by IANA^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#charsetName">common:charsetName</a>
    /// </summary>
    let charsetName = _prefixId.prefix "charsetName"
    /// <summary>
    ///   <para>common:normativeReference : http://tools.ietf.org/html/rfc2045#section-5.1^^xsd:anyURI</para>
    ///   <para>rdfs:label : Content Type Name^^xsd:string</para>
    ///   <para>rdfs:comment : This property identifies unequivocally a content type. It is  the concatenation of the MIME Media type, subtype and optional parameters  according to the syntax specified on RFC 2045, section 5.1^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#contentTypeName">common:contentTypeName</a>
    /// </summary>
    let contentTypeName = _prefixId.prefix "contentTypeName"
    /// <summary>
    ///   <para>common:normativeReference : http://www.iso.org/iso/list-en1-semic-2.txt^^xsd:anyURI</para>
    ///   <para>rdfs:label : Country Code^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents a country code as per ISO 3166-1 alpha 3, so the country code is composed by a three letter code^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#countryCode">common:countryCode</a>
    /// </summary>
    let countryCode = _prefixId.prefix "countryCode"
    /// <summary>
    ///   <para>rdfs:label : Default^^xsd:string</para>
    ///   <para>rdfs:comment : This is a generic property that can be used to represent the relationship between a Context Entity and a default element for such entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#default">common:default</a>
    /// </summary>
    let default_ = _prefixId.prefix "default"
    /// <summary>
    ///   <para>rdfs:label : Disjoint Class^^xsd:string</para>
    ///   <para>rdfs:comment : This property contains the URI of a disjoint class in a AllDisjointSet. The URI is represented following the CURIE notation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#disjointClass">common:disjointClass</a>
    /// </summary>
    let disjointClass = _prefixId.prefix "disjointClass"
    /// <summary>
    ///   <para>rdfs:label : Disjoint Set^^xsd:string</para>
    ///   <para>rdfs:comment : This property is aimed at linking groups of disjoint classes between them^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#disjointSet">common:disjointSet</a>
    /// </summary>
    let disjointSet = _prefixId.prefix "disjointSet"
    /// <summary>
    ///   <para>rdfs:label : Id^^xsd:string</para>
    ///   <para>rdfs:comment : A machine-readable alphanumeric string that univoquely identifies a Context Entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#id">common:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : Informative Reference^^xsd:string</para>
    ///   <para>rdfs:comment : This annotation property serves for indicating informative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#informativeReference">common:informativeReference</a>
    /// </summary>
    let informativeReference = _prefixId.prefix "informativeReference"
    /// <summary>
    ///   <para>common:normativeReference : http://www.sil.org/iso639-3/codes.asp^^xsd:anyURI</para>
    ///   <para>rdfs:label : Language Code^^xsd:string</para>
    ///   <para>rdfs:comment : It represents a language code according to ISO 639 Part 3^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#languageCode">common:languageCode</a>
    /// </summary>
    let languageCode = _prefixId.prefix "languageCode"
    /// <summary>
    ///   <para>common:normativeReference : http://www.ietf.org/rfc/rfc4646.txt^^xsd:anyURI</para>
    ///   <para>rdfs:label : Language Tag^^xsd:string</para>
    ///   <para>rdfs:comment : A language tag according to the rules specified by RFC 4646^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#languageTag">common:languageTag</a>
    /// </summary>
    let languageTag = _prefixId.prefix "languageTag"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : Model^^xsd:stringcommon:relatedUAProfEntity : CPU^^xsd:string</para>
    ///   <para>common:relatedDDRCoreVoc : model^^xsd:string</para>
    ///   <para>rdfs:label : Model^^xsd:string</para>
    ///   <para>rdfs:comment : The model identification assigned to something by its vendor^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#model">common:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : OSName^^xsd:stringcommon:relatedUAProfEntity : BrowserName^^xsd:string</para>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a delivery context entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#name">common:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : normativeReference^^xsd:string</para>
    ///   <para>rdfs:comment : This annotation property serves for indicating normative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#normativeReference">common:normativeReference</a>
    /// </summary>
    let normativeReference = _prefixId.prefix "normativeReference"
    /// <summary>
    ///   <para>rdfs:label : Normative Status^^xsd:string</para>
    ///   <para>rdfs:comment : This annotation property indicates the normative status of an entity in the ontology. The  criteria used is that classes and properties are normative by default. On the other hand instances are not normative by default^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#normativeStatus">common:normativeStatus</a>
    /// </summary>
    let normativeStatus = _prefixId.prefix "normativeStatus"
    /// <summary>
    ///   <para>rdfs:label : Normative URI^^xsd:string</para>
    ///   <para>rdfs:comment : This property holds a URI that points to the normative specification of a software technology. One example are the estable  URIs that are associated to W3C Recommendations^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#normativeURI">common:normativeURI</a>
    /// </summary>
    let normativeURI = _prefixId.prefix "normativeURI"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : PixelAspectRatio^^xsd:string</para>
    ///   <para>rdfs:label : Pixel Aspect Ratio^^xsd:string</para>
    ///   <para>rdfs:comment : The pixel aspect ratio as a decimal value, for example 1.33 for a 4:3 aspect. The pixel aspect ratio is the ratio of the resolution width in pixels, to the resolution height in pixels^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#pixelAspectRatio">common:pixelAspectRatio</a>
    /// </summary>
    let pixelAspectRatio = _prefixId.prefix "pixelAspectRatio"
    /// <summary>
    ///   <para>rdfs:label : Related DDR Core Vocabulary Property^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a  W3C DDR Core Vocabulary property to which a property in the ontology relates to^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#relatedDDRCoreVoc">common:relatedDDRCoreVoc</a>
    /// </summary>
    let relatedDDRCoreVoc = _prefixId.prefix "relatedDDRCoreVoc"
    /// <summary>
    ///   <para>rdfs:label : Related UAProf entity^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the related UAProf entities^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#relatedUAProfEntity">common:relatedUAProfEntity</a>
    /// </summary>
    let relatedUAProfEntity = _prefixId.prefix "relatedUAProfEntity"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : ScreenSize^^xsd:string</para>
    ///   <para>common:relatedDDRCoreVoc : displayHeight^^xsd:string</para>
    ///   <para>rdfs:label : Resolution Height^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of addressable pixels in the vertical direction of a rectangular element (such as Camera, Display, Image, Video, ...) when held in its default orientation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#resolutionHeight">common:resolutionHeight</a>
    /// </summary>
    let resolutionHeight = _prefixId.prefix "resolutionHeight"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : ScreenSize^^xsd:string</para>
    ///   <para>common:relatedDDRCoreVoc : displayWidth^^xsd:string</para>
    ///   <para>rdfs:label : resolutionWidth^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of addressable pixels in the horizontal direction of a rectangular entity (such as Camera, Display, Image, Video, ...) when held in its default orientation. The Property does not apply to entities that are not rectangular or square^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#resolutionWidth">common:resolutionWidth</a>
    /// </summary>
    let resolutionWidth = _prefixId.prefix "resolutionWidth"
    /// <summary>
    ///   <para>rdfs:label : Restricted Element^^xsd:string</para>
    ///   <para>rdfs:comment : The element to which a restriction applies^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#restrictedElement">common:restrictedElement</a>
    /// </summary>
    let restrictedElement = _prefixId.prefix "restrictedElement"
    /// <summary>
    ///   <para>rdfs:label : Restriction Value^^xsd:string</para>
    ///   <para>rdfs:comment : The value of a feature restriction^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#restrictionValue">common:restrictionValue</a>
    /// </summary>
    let restrictionValue = _prefixId.prefix "restrictionValue"
    /// <summary>
    ///   <para>rdfs:label : Restrictions^^xsd:string</para>
    ///   <para>rdfs:comment : The restrictions presented by a context entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#restrictions">common:restrictions</a>
    /// </summary>
    let restrictions = _prefixId.prefix "restrictions"
    /// <summary>
    ///   <para>rdfs:label : Serial Number^^xsd:string</para>
    ///   <para>rdfs:comment : The serial number of something^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#serialNumber">common:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    let sip = _prefixId.prefix "sip"
    /// <summary>
    ///   <para>rdfs:label : Sound Mode^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the sound mode currently setted on a device^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#soundMode">common:soundMode</a>
    /// </summary>
    let soundMode = _prefixId.prefix "soundMode"
    /// <summary>
    ///   <para>rdfs:label : Standard Number^^xsd:string</para>
    ///   <para>rdfs:comment : This is a generic property that holds a  machine-readable string that identifies univoquely an standard, for example,  EN 302 409 or TS 102 221^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#standardNumber">common:standardNumber</a>
    /// </summary>
    let standardNumber = _prefixId.prefix "standardNumber"
    /// <summary>
    ///   <para>rdfs:label : Supports^^xsd:string</para>
    ///   <para>rdfs:comment : A generic property that indicates what is supported by a Context Entity^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#supports">common:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : Term Group Prefix^^xsd:string</para>
    ///   <para>rdfs:comment : The prefix used for a group of terms^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#termGroupPrefix">common:termGroupPrefix</a>
    /// </summary>
    let termGroupPrefix = _prefixId.prefix "termGroupPrefix"
    /// <summary>
    ///   <para>rdfs:label : termGroups^^xsd:string</para>
    ///   <para>rdfs:comment : An annotation property to indicate the term groups of the Delivery Context Ontology^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#termGroups">common:termGroups</a>
    /// </summary>
    let termGroups = _prefixId.prefix "termGroups"
    /// <summary>
    ///   <para>rdfs:label : Time Zone^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents a time zone^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#timeZone">common:timeZone</a>
    /// </summary>
    let timeZone = _prefixId.prefix "timeZone"
    /// <summary>
    ///   <para>rdfs:label : Time Zone String^^xsd:string</para>
    ///   <para>rdfs:comment : This property is a string that denotes the timezone as per the rules defined by POSIX 1003.1 in Section 8.3^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#timeZoneString">common:timeZoneString</a>
    /// </summary>
    let timeZoneString = _prefixId.prefix "timeZoneString"
    /// <summary>
    ///   <para>common:normativeReference : http://www.iana.org/assignments/transfer-encodings/^^xsd:anyURI</para>
    ///   <para>rdfs:label : Transfer Encoding Name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a transfer encoding as officially defined by IANA^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#transferEncodingName">common:transferEncodingName</a>
    /// </summary>
    let transferEncodingName = _prefixId.prefix "transferEncodingName"
    /// <summary>
    ///   <para>rdfs:label : TZ Name^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents the name of a Zone entry in the database commonly referred  to as the TZ database.  Specifically, in the database's  textual form,  the string refers to the name field of a zone line^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#tzName">common:tzName</a>
    /// </summary>
    let tzName = _prefixId.prefix "tzName"
    /// <summary>
    ///   <para>common:normativeReference : http://www.iana.org/assignments/uri-schemes.html^^xsd:anyURI</para>
    ///   <para>rdfs:label : URI Scheme Name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of a URI scheme as officially defined by IANA^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#uriSchemeName">common:uriSchemeName</a>
    /// </summary>
    let uriSchemeName = _prefixId.prefix "uriSchemeName"
    /// <summary>
    ///   <para>common:relatedDDRCoreVoc : vendor^^xsd:string</para>
    ///   <para>rdfs:comment : This property represents a vendor^^xsd:string</para>
    ///   <para>common:relatedUAProfEntity : Vendor^^xsd:stringcommon:relatedUAProfEntity : CPU^^xsd:stringcommon:relatedUAProfEntity : OSVendor^^xsd:stringcommon:relatedUAProfEntity : BrowserVendor^^xsd:string</para>
    ///   <para>rdfs:label : Vendor^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#vendor">common:vendor</a>
    /// </summary>
    let vendor = _prefixId.prefix "vendor"
    /// <summary>
    ///   <para>common:relatedUAProfEntity : WmlScriptVersion^^xsd:stringcommon:relatedUAProfEntity : WmlVersion^^xsd:stringcommon:relatedUAProfEntity : JavaScriptVersion^^xsd:stringcommon:relatedUAProfEntity : HtmlVersion^^xsd:stringcommon:relatedUAProfEntity : OSVersion^^xsd:stringcommon:relatedUAProfEntity : WapVersion^^xsd:stringcommon:relatedUAProfEntity : XhtmlVersion^^xsd:stringcommon:relatedUAProfEntity : WtaVersion^^xsd:stringcommon:relatedUAProfEntity : BrowserVersion^^xsd:stringcommon:relatedUAProfEntity : JVMVersion^^xsd:string</para>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <para>common:relatedDDRCoreVoc : version^^xsd:string</para>
    ///   <para>rdfs:comment : The version number assigned to something by its vendor^^xsd:string</para>
    ///   <a href="http://www.w3.org/2007/uwa/context/common.owl#version">common:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"

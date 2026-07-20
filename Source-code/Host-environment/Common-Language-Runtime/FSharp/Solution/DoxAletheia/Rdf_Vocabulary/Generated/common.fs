namespace http.www.w3.org._2007.uwa.context.common.owl.hash

open DoxAletheia

module common =
    let _namespace_name = "http://www.w3.org/2007/uwa/context/common.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Silence Sound Mode
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode_SILENCE"></see></summary>
    let SoundMode_SILENCE = _prefix "SoundMode_SILENCE"
    /// <summary>
    /// Normal Sound Mode
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode_NORMAL"></see></summary>
    let SoundMode_NORMAL = _prefix "SoundMode_NORMAL"
    /// <summary>
    /// This instance represents an "informative" status
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Informative"></see></summary>
    let Informative = _prefix "Informative"
    /// <summary>
    /// This isntance represents a "normative" status
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Normative"></see></summary>
    let Normative = _prefix "Normative"
    /// <summary>
    /// This instance represents the "utility" status
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Utility"></see></summary>
    let Utility = _prefix "Utility"
    /// <summary>
    /// The model identification assigned to something by its vendor
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// The total number of addressable pixels in the horizontal direction of a rectangular entity (such as Camera, Display, Image, Video, ...) when held in its default orientation. The Property does not apply to entities that are not rectangular or square
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#resolutionWidth"></see></summary>
    let resolutionWidth = _prefix "resolutionWidth"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#UTF-8"></see>
    /// </summary>
    let ``UTF-8`` = _prefix "UTF-8"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_CharacterSet_UTF-7"></see>
    /// </summary>
    let ``CharacterSet_CharacterSet_UTF-7`` = _prefix "CharacterSet_CharacterSet_UTF-7"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16"></see>
    /// </summary>
    let ``CharacterSet_UTF-16`` = _prefix "CharacterSet_UTF-16"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16le"></see>
    /// </summary>
    let ``CharacterSet_UTF-16le`` = _prefix "CharacterSet_UTF-16le"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16be"></see>
    /// </summary>
    let ``CharacterSet_UTF-16be`` = _prefix "CharacterSet_UTF-16be"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-2"></see>
    /// </summary>
    let ``CharacterSet_ISO-8859-2`` = _prefix "CharacterSet_ISO-8859-2"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-1"></see>
    /// </summary>
    let ``CharacterSet_ISO-8859-1`` = _prefix "CharacterSet_ISO-8859-1"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-10646-UCS-2"></see>
    /// </summary>
    let ``CharacterSet_ISO-10646-UCS-2`` = _prefix "CharacterSet_ISO-10646-UCS-2"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_WINDOWS-1252"></see>
    /// </summary>
    let ``CharacterSet_WINDOWS-1252`` = _prefix "CharacterSet_WINDOWS-1252"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_US-ASCII"></see>
    /// </summary>
    let ``CharacterSet_US-ASCII`` = _prefix "CharacterSet_US-ASCII"
    /// <summary>
    /// This property represents a vendor
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#vendor"></see></summary>
    let vendor = _prefix "vendor"
    /// <summary>
    /// The version number assigned to something by its vendor
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// This class represents feature restrictions related to an implementation
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#FeatureRestriction"></see></summary>
    let FeatureRestriction = _prefix "FeatureRestriction"
    /// <summary>
    /// A machine-readable alphanumeric string that univoquely identifies a Context Entity
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#id"></see></summary>
    let id = _prefix "id"
    /// <summary>
    /// The name of a delivery context entity
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The element to which a restriction applies
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#restrictedElement"></see></summary>
    let restrictedElement = _prefix "restrictedElement"
    /// <summary>
    /// The value of a feature restriction
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#restrictionValue"></see></summary>
    let restrictionValue = _prefix "restrictionValue"
    /// <summary>
    /// This annotation property indicates the normative status of an entity in the ontology. The  criteria used is that classes and properties are normative by default. On the other hand instances are not normative by default
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#normativeStatus"></see></summary>
    let normativeStatus = _prefix "normativeStatus"
    /// <summary>
    /// The base 64 transfer encoding format as specified in RFC4289
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Base64"></see></summary>
    let TransferEncoding_Base64 = _prefix "TransferEncoding_Base64"
    /// <summary>
    /// This class represents a vendor, i.e an entity that commercializes a product
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Vendor"></see></summary>
    let Vendor = _prefix "Vendor"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_7bit"></see>
    /// </summary>
    let TransferEncoding_7bit = _prefix "TransferEncoding_7bit"
    /// <summary>
    /// HTTP
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_24"></see></summary>
    let ApplicationProtocol_24 = _prefix "ApplicationProtocol_24"
    /// <summary>
    /// FTP
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_23"></see></summary>
    let ApplicationProtocol_23 = _prefix "ApplicationProtocol_23"
    /// <summary>
    /// HTTPS
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_22"></see></summary>
    let ApplicationProtocol_22 = _prefix "ApplicationProtocol_22"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_32"></see>
    /// </summary>
    let UriSchema_32 = _prefix "UriSchema_32"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_34"></see>
    /// </summary>
    let UriSchema_34 = _prefix "UriSchema_34"
    /// <summary>
    /// This instance represents the "http" URI Scheme
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#UriScheme_HTTP"></see></summary>
    let UriScheme_HTTP = _prefix "UriScheme_HTTP"
    /// <summary>
    /// WSP Connection Oriented
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_26"></see></summary>
    let ApplicationProtocol_26 = _prefix "ApplicationProtocol_26"
    /// <summary>
    /// This is an utility class for representing groups of classes that are pairwise disjoint, following the approach specified by the OWL Abstract Syntax. This class has been created as a workaround to the absence in OWL 1 of an specific construct for establishing class disjointness between groups of classes
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#AllDisjointSet"></see></summary>
    let AllDisjointSet = _prefix "AllDisjointSet"
    /// <summary>
    /// This property contains the URI of a disjoint class in a AllDisjointSet. The URI is represented following the CURIE notation
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#disjointClass"></see></summary>
    let disjointClass = _prefix "disjointClass"
    /// <summary>
    /// This property is aimed at linking groups of disjoint classes between them
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#disjointSet"></see></summary>
    let disjointSet = _prefix "disjointSet"
    /// <summary>
    /// This annotation property serves for indicating informative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#informativeReference"></see></summary>
    let informativeReference = _prefix "informativeReference"
    /// <summary>
    /// This class represents application-level protocols
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol"></see></summary>
    let ApplicationProtocol = _prefix "ApplicationProtocol"
    /// <summary>
    /// This class subsumes all the general purpose classes
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Context_CommonEntity"></see></summary>
    let Context_CommonEntity = _prefix "Context_CommonEntity"
    /// <summary>
    /// The name of the related UAProf entities
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#relatedUAProfEntity"></see></summary>
    let relatedUAProfEntity = _prefix "relatedUAProfEntity"
    /// <summary>
    /// W-HTTP
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_21"></see></summary>
    let ApplicationProtocol_21 = _prefix "ApplicationProtocol_21"
    /// <summary>
    /// WSP Connection-Less
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_27"></see></summary>
    let ApplicationProtocol_27 = _prefix "ApplicationProtocol_27"
    /// <summary>
    /// WTLS
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_28"></see></summary>
    let ApplicationProtocol_28 = _prefix "ApplicationProtocol_28"
    /// <summary>
    /// This class represents specific character sets officially identified by IANA
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet"></see></summary>
    let CharacterSet = _prefix "CharacterSet"
    /// <summary>
    /// The name of a charset officially assigned by IANA
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#charsetName"></see></summary>
    let charsetName = _prefix "charsetName"
    /// <summary>
    /// This annotation property serves for indicating normative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#normativeReference"></see></summary>
    let normativeReference = _prefix "normativeReference"
    /// <summary>
    /// This is a class that represents content types,  the combination of a MIME media type, subtype and optional parameters
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#ContentType"></see></summary>
    let ContentType = _prefix "ContentType"
    /// <summary>
    /// American English
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#EnglishUSA"></see></summary>
    let EnglishUSA = _prefix "EnglishUSA"
    /// <summary>
    /// This class represents languages
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// It represents a language code according to ISO 639 Part 3
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#languageCode"></see></summary>
    let languageCode = _prefix "languageCode"
    /// <summary>
    /// A language tag according to the rules specified by RFC 4646
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#languageTag"></see></summary>
    let languageTag = _prefix "languageTag"
    /// <summary>
    /// This class represents features, which are distinguishing characteristics of an item
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// This class represents the normative status of an entity in the ontology. It is used  as an auxiliary element for automatic documentation generation
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#NormativeStatus"></see></summary>
    let NormativeStatus = _prefix "NormativeStatus"
    /// <summary>
    /// This class represents input modalities
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#InputModality"></see></summary>
    let InputModality = _prefix "InputModality"
    /// <summary>
    /// This class represents modalities, the type of communication channel used for interaction. It also covers the way an idea is expressed or perceived, or the manner in which an action is performed.
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#Modality"></see></summary>
    let Modality = _prefix "Modality"
    /// <summary>
    /// Modality that consists of the realization of gestures to input information or commands to the system
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_GESTURE"></see></summary>
    let InputModality_GESTURE = _prefix "InputModality_GESTURE"
    /// <summary>
    /// An input modality in which information is entered by touching some sensor or device
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_TACTILE"></see></summary>
    let InputModality_TACTILE = _prefix "InputModality_TACTILE"
    /// <summary>
    /// An input modality in whoch the user enters information by typing using a keyboard or similar
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_TYPING"></see></summary>
    let InputModality_TYPING = _prefix "InputModality_TYPING"
    /// <summary>
    /// Modality that consists of input introduction by means of voice
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_VOICE"></see></summary>
    let InputModality_VOICE = _prefix "InputModality_VOICE"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#MIME_TYPE_GIF"></see>
    /// </summary>
    let MIME_TYPE_GIF = _prefix "MIME_TYPE_GIF"
    /// <summary>
    /// This property identifies unequivocally a content type. It is  the concatenation of the MIME Media type, subtype and optional parameters  according to the syntax specified on RFC 2045, section 5.1
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#contentTypeName"></see></summary>
    let contentTypeName = _prefix "contentTypeName"
    /// <summary>
    /// This class represents output modalities
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality"></see></summary>
    let OutputModality = _prefix "OutputModality"
    /// <summary>
    /// This modality indicates the ability to use audio as an output modality
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_AURAL"></see></summary>
    let OutputModality_AURAL = _prefix "OutputModality_AURAL"
    /// <summary>
    /// This is a tactile modality in which user receives information from the system by means of the tac
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_TACTILE"></see></summary>
    let OutputModality_TACTILE = _prefix "OutputModality_TACTILE"
    /// <summary>
    /// This is an output modality in which information is perceived visually by the user
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_VISUAL"></see></summary>
    let OutputModality_VISUAL = _prefix "OutputModality_VISUAL"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#Sibling_Disjoint"></see>
    /// </summary>
    let Sibling_Disjoint = _prefix "Sibling_Disjoint"
    /// <summary>
    /// This class represents the sound modes that can be chosen by the user of a device
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode"></see></summary>
    let SoundMode = _prefix "SoundMode"
    /// <summary>
    /// Spanish spoken Spain
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#SpanishSpain"></see></summary>
    let SpanishSpain = _prefix "SpanishSpain"
    /// <summary>
    /// This is an utility class that serves to represent the different term groups that compose the Delivery Context Ontology
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TermGroup"></see></summary>
    let TermGroup = _prefix "TermGroup"
    /// <summary>
    /// They are a set of general purpose, generic classes, properties and instances which are used to support the modelling of the different aspects of a Delivery Context
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TermGroup_Common"></see></summary>
    let TermGroup_Common = _prefix "TermGroup_Common"
    /// <summary>
    /// The prefix used for a group of terms
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#termGroupPrefix"></see></summary>
    let termGroupPrefix = _prefix "termGroupPrefix"
    /// <summary>
    /// A time zone is an identifier for a specific location or region which translates into a combination of rules for calculating an UTC offset
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TimeZone"></see></summary>
    let TimeZone = _prefix "TimeZone"
    /// <summary>
    /// This property represents the name of a Zone entry in the database commonly referred  to as the TZ database.  Specifically, in the database's  textual form,  the string refers to the name field of a zone line
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#tzName"></see></summary>
    let tzName = _prefix "tzName"
    /// <summary>
    /// This property is a string that denotes the timezone as per the rules defined by POSIX 1003.1 in Section 8.3
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#timeZoneString"></see></summary>
    let timeZoneString = _prefix "timeZoneString"
    /// <summary>
    /// This class represents transfer encoding formats as specified by RFC 2045 and registered with IANA
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding"></see></summary>
    let TransferEncoding = _prefix "TransferEncoding"
    /// <summary>
    /// The name of a transfer encoding as officially defined by IANA
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#transferEncodingName"></see></summary>
    let transferEncodingName = _prefix "transferEncodingName"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_8bit"></see>
    /// </summary>
    let TransferEncoding_8bit = _prefix "TransferEncoding_8bit"
    /// <summary>
    /// The binary encoding format as specified in RFC4289
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Binary"></see></summary>
    let TransferEncoding_Binary = _prefix "TransferEncoding_Binary"
    /// <summary>
    /// The quoted printable transfer encoding format as specified in the RFC "Multipurpose Internet Mail Extensions (MIME) Part Four
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_QuotedPrintable"></see></summary>
    let TransferEncoding_QuotedPrintable = _prefix "TransferEncoding_QuotedPrintable"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_31"></see>
    /// </summary>
    let UriSchema_31 = _prefix "UriSchema_31"
    /// <summary>
    /// This class represents URI Schemas as per RFC 3986
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#UriScheme"></see></summary>
    let UriScheme = _prefix "UriScheme"
    /// <summary>
    /// The name of a URI scheme as officially defined by IANA
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#uriSchemeName"></see></summary>
    let uriSchemeName = _prefix "uriSchemeName"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_37"></see>
    /// </summary>
    let UriSchema_37 = _prefix "UriSchema_37"
    /// <summary>
    /// This property represents a generic relationship between a Context Entity and other Context Entities which are  active in the scope of the former. For instance, the active Bluetooth Profile of a Device or the active Font within an Application
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#active"></see></summary>
    let active = _prefix "active"
    /// <summary>
    /// A generic property that represents Context Entities that are available
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#available"></see></summary>
    let available = _prefix "available"
    /// <summary>
    /// A generic property that indicates what is supported by a Context Entity
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// This property represents a country code as per ISO 3166-1 alpha 3, so the country code is composed by a three letter code
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#countryCode"></see></summary>
    let countryCode = _prefix "countryCode"
    /// <summary>
    /// This is a generic property that can be used to represent the relationship between a Context Entity and a default element for such entity
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#default"></see></summary>
    let default_ = _prefix "default"
    /// <summary>
    /// The name of a  W3C DDR Core Vocabulary property to which a property in the ontology relates to
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#relatedDDRCoreVoc"></see></summary>
    let relatedDDRCoreVoc = _prefix "relatedDDRCoreVoc"
    /// <summary>
    /// This property holds a URI that points to the normative specification of a software technology. One example are the estable  URIs that are associated to W3C Recommendations
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#normativeURI"></see></summary>
    let normativeURI = _prefix "normativeURI"
    /// <summary>
    /// The pixel aspect ratio as a decimal value, for example 1.33 for a 4:3 aspect. The pixel aspect ratio is the ratio of the resolution width in pixels, to the resolution height in pixels
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#pixelAspectRatio"></see></summary>
    let pixelAspectRatio = _prefix "pixelAspectRatio"
    /// <summary>
    /// The total number of addressable pixels in the vertical direction of a rectangular element (such as Camera, Display, Image, Video, ...) when held in its default orientation
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#resolutionHeight"></see></summary>
    let resolutionHeight = _prefix "resolutionHeight"
    /// <summary>
    /// The restrictions presented by a context entity
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#restrictions"></see></summary>
    let restrictions = _prefix "restrictions"
    /// <summary>
    /// The serial number of something
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    ///   <see href="http://www.w3.org/2007/uwa/context/common.owl#sip"></see>
    /// </summary>
    let sip = _prefix "sip"
    /// <summary>
    /// This property represents the sound mode currently setted on a device
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#soundMode"></see></summary>
    let soundMode = _prefix "soundMode"
    /// <summary>
    /// This is a generic property that holds a  machine-readable string that identifies univoquely an standard, for example,  EN 302 409 or TS 102 221
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#standardNumber"></see></summary>
    let standardNumber = _prefix "standardNumber"
    /// <summary>
    /// An annotation property to indicate the term groups of the Delivery Context Ontology
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#termGroups"></see></summary>
    let termGroups = _prefix "termGroups"
    /// <summary>
    /// This property represents a time zone
    /// <see href="http://www.w3.org/2007/uwa/context/common.owl#timeZone"></see></summary>
    let timeZone = _prefix "timeZone"

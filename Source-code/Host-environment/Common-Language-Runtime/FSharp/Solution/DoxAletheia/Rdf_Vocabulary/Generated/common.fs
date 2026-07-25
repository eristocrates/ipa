namespace http.www.w3.org._2007.uwa.context.common.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module common =
    let _namespace_iri = Namespace_Iri common |> NamespaceIRI
    /// <summary>
    ///   <para>common:SoundMode_SILENCE</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:SoundMode</para>
    ///   <para>Silence Sound Mode</para>
    /// labels<para>Silence</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode_SILENCE">http://www.w3.org/2007/uwa/context/common.owl#SoundMode_SILENCE</seealso>
    let SoundMode_SILENCE = Prefixed_Name(common, "SoundMode_SILENCE") |> PrefixedName
    /// <summary>
    ///   <para>common:Normative</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:NormativeStatus</para>
    ///   <para>This isntance represents a "normative" status</para>
    /// labels<para>Normative</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Normative">http://www.w3.org/2007/uwa/context/common.owl#Normative</seealso>
    let Normative = Prefixed_Name(common, "Normative") |> PrefixedName
    /// <summary>
    ///   <para>common:resolutionWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The total number of addressable pixels in the horizontal direction of a rectangular entity (such as Camera, Display, Image, Video, ...) when held in its default orientation. The Property does not apply to entities that are not rectangular or square</para>
    /// labels<para>resolutionWidth</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#resolutionWidth">http://www.w3.org/2007/uwa/context/common.owl#resolutionWidth</seealso>
    let resolutionWidth = Prefixed_Name(common, "resolutionWidth") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_UTF-16le</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16le">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16le</seealso>
    let CharacterSet_UTF_16le =
        Prefixed_Name(common, "CharacterSet_UTF-16le") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_UTF-16be</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16be">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16be</seealso>
    let CharacterSet_UTF_16be =
        Prefixed_Name(common, "CharacterSet_UTF-16be") |> PrefixedName

    /// <summary>
    ///   <para>common:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The version number assigned to something by its vendor</para>
    /// labels<para>Version</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#version">http://www.w3.org/2007/uwa/context/common.owl#version</seealso>
    let version = Prefixed_Name(common, "version") |> PrefixedName

    /// <summary>
    ///   <para>common:informativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This annotation property serves for indicating informative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process</para>
    /// labels<para>Informative Reference</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#informativeReference">http://www.w3.org/2007/uwa/context/common.owl#informativeReference</seealso>
    let informativeReference =
        Prefixed_Name(common, "informativeReference") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents application-level protocols</para>
    /// labels<para>Application Protocol</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol</seealso>
    let ApplicationProtocol =
        Prefixed_Name(common, "ApplicationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>common:Context_CommonEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class subsumes all the general purpose classes</para>
    /// labels<para>Context Common Entity</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Context_CommonEntity">http://www.w3.org/2007/uwa/context/common.owl#Context_CommonEntity</seealso>
    let Context_CommonEntity =
        Prefixed_Name(common, "Context_CommonEntity") |> PrefixedName

    /// <summary>
    ///   <para>common:relatedUAProfEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the related UAProf entities</para>
    /// labels<para>Related UAProf entity</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#relatedUAProfEntity">http://www.w3.org/2007/uwa/context/common.owl#relatedUAProfEntity</seealso>
    let relatedUAProfEntity =
        Prefixed_Name(common, "relatedUAProfEntity") |> PrefixedName

    /// <summary>
    ///   <para>common:Informative</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:NormativeStatus</para>
    ///   <para>This instance represents an "informative" status</para>
    /// labels<para>Informative</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Informative">http://www.w3.org/2007/uwa/context/common.owl#Informative</seealso>
    let Informative = Prefixed_Name(common, "Informative") |> PrefixedName
    /// <summary>
    ///   <para>common:vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents a vendor</para>
    /// labels<para>Vendor</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#vendor">http://www.w3.org/2007/uwa/context/common.owl#vendor</seealso>
    let vendor = Prefixed_Name(common, "vendor") |> PrefixedName
    /// <summary>
    ///   <para>common:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A machine-readable alphanumeric string that univoquely identifies a Context Entity</para>
    /// labels<para>Id</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#id">http://www.w3.org/2007/uwa/context/common.owl#id</seealso>
    let id = Prefixed_Name(common, "id") |> PrefixedName
    /// <summary>
    ///   <para>common:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a delivery context entity</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#name">http://www.w3.org/2007/uwa/context/common.owl#name</seealso>
    let name = Prefixed_Name(common, "name") |> PrefixedName
    /// <summary>
    ///   <para>common:restrictionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of a feature restriction</para>
    /// labels<para>Restriction Value</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#restrictionValue">http://www.w3.org/2007/uwa/context/common.owl#restrictionValue</seealso>
    let restrictionValue = Prefixed_Name(common, "restrictionValue") |> PrefixedName
    /// <summary>
    ///   <para>common:normativeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This annotation property indicates the normative status of an entity in the ontology. The  criteria used is that classes and properties are normative by default. On the other hand instances are not normative by default</para>
    /// labels<para>Normative Status</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#normativeStatus">http://www.w3.org/2007/uwa/context/common.owl#normativeStatus</seealso>
    let normativeStatus = Prefixed_Name(common, "normativeStatus") |> PrefixedName

    /// <summary>
    ///   <para>common:TransferEncoding_Base64</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TransferEncoding</para>
    ///   <para>The base 64 transfer encoding format as specified in RFC4289</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Base64">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Base64</seealso>
    let TransferEncoding_Base64 =
        Prefixed_Name(common, "TransferEncoding_Base64") |> PrefixedName

    /// <summary>
    ///   <para>common:Vendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a vendor, i.e an entity that commercializes a product</para>
    /// labels<para>Vendor</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Vendor">http://www.w3.org/2007/uwa/context/common.owl#Vendor</seealso>
    let Vendor = Prefixed_Name(common, "Vendor") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_26</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>WSP Connection Oriented</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_26">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_26</seealso>
    let ApplicationProtocol_26 =
        Prefixed_Name(common, "ApplicationProtocol_26") |> PrefixedName

    /// <summary>
    ///   <para>common:disjointClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property contains the URI of a disjoint class in a AllDisjointSet. The URI is represented following the CURIE notation</para>
    /// labels<para>Disjoint Class</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#disjointClass">http://www.w3.org/2007/uwa/context/common.owl#disjointClass</seealso>
    let disjointClass = Prefixed_Name(common, "disjointClass") |> PrefixedName
    /// <summary>
    ///   <para>common:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The model identification assigned to something by its vendor</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#model">http://www.w3.org/2007/uwa/context/common.owl#model</seealso>
    let model = Prefixed_Name(common, "model") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_UTF-16</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_UTF-16</seealso>
    let CharacterSet_UTF_16 =
        Prefixed_Name(common, "CharacterSet_UTF-16") |> PrefixedName

    /// <summary>
    ///   <para>common:FeatureRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents feature restrictions related to an implementation</para>
    /// labels<para>Feature Restriction</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#FeatureRestriction">http://www.w3.org/2007/uwa/context/common.owl#FeatureRestriction</seealso>
    let FeatureRestriction = Prefixed_Name(common, "FeatureRestriction") |> PrefixedName
    /// <summary>
    ///   <para>common:charsetName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a charset officially assigned by IANA</para>
    /// labels<para>Character Set Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#charsetName">http://www.w3.org/2007/uwa/context/common.owl#charsetName</seealso>
    let charsetName = Prefixed_Name(common, "charsetName") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_CharacterSet_UTF-7</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_CharacterSet_UTF-7">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_CharacterSet_UTF-7</seealso>
    let CharacterSet_CharacterSet_UTF_7 =
        Prefixed_Name(common, "CharacterSet_CharacterSet_UTF-7") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_ISO-10646-UCS-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-10646-UCS-2">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-10646-UCS-2</seealso>
    let CharacterSet_ISO_10646_UCS_2 =
        Prefixed_Name(common, "CharacterSet_ISO-10646-UCS-2") |> PrefixedName

    /// <summary>
    ///   <para>common:timeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a time zone</para>
    /// labels<para>Time Zone</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#timeZone">http://www.w3.org/2007/uwa/context/common.owl#timeZone</seealso>
    let timeZone = Prefixed_Name(common, "timeZone") |> PrefixedName
    /// <summary>
    ///   <para>common:UTF-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UTF-8">http://www.w3.org/2007/uwa/context/common.owl#UTF-8</seealso>
    let UTF_8 = Prefixed_Name(common, "UTF-8") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_ISO-8859-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-2">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-2</seealso>
    let CharacterSet_ISO_8859_2 =
        Prefixed_Name(common, "CharacterSet_ISO-8859-2") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_WINDOWS-1252</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_WINDOWS-1252">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_WINDOWS-1252</seealso>
    let CharacterSet_WINDOWS_1252 =
        Prefixed_Name(common, "CharacterSet_WINDOWS-1252") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_ISO-8859-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-1">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_ISO-8859-1</seealso>
    let CharacterSet_ISO_8859_1 =
        Prefixed_Name(common, "CharacterSet_ISO-8859-1") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet_US-ASCII</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:CharacterSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_US-ASCII">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet_US-ASCII</seealso>
    let CharacterSet_US_ASCII =
        Prefixed_Name(common, "CharacterSet_US-ASCII") |> PrefixedName

    /// <summary>
    ///   <para>common:TransferEncoding_7bit</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TransferEncoding</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_7bit">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_7bit</seealso>
    let TransferEncoding_7bit =
        Prefixed_Name(common, "TransferEncoding_7bit") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_22</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>HTTPS</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_22">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_22</seealso>
    let ApplicationProtocol_22 =
        Prefixed_Name(common, "ApplicationProtocol_22") |> PrefixedName

    /// <summary>
    ///   <para>common:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A generic property that indicates what is supported by a Context Entity</para>
    /// labels<para>Supports</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#supports">http://www.w3.org/2007/uwa/context/common.owl#supports</seealso>
    let supports = Prefixed_Name(common, "supports") |> PrefixedName
    /// <summary>
    ///   <para>common:countryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents a country code as per ISO 3166-1 alpha 3, so the country code is composed by a three letter code</para>
    /// labels<para>Country Code</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#countryCode">http://www.w3.org/2007/uwa/context/common.owl#countryCode</seealso>
    let countryCode = Prefixed_Name(common, "countryCode") |> PrefixedName
    /// <summary>
    ///   <para>common:default</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is a generic property that can be used to represent the relationship between a Context Entity and a default element for such entity</para>
    /// labels<para>Default</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#default">http://www.w3.org/2007/uwa/context/common.owl#default</seealso>
    let default_ = Prefixed_Name(common, "default") |> PrefixedName
    /// <summary>
    ///   <para>common:UriScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents URI Schemas as per RFC 3986</para>
    /// labels<para>URI Schema</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriScheme">http://www.w3.org/2007/uwa/context/common.owl#UriScheme</seealso>
    let UriScheme = Prefixed_Name(common, "UriScheme") |> PrefixedName
    /// <summary>
    ///   <para>common:UriSchema_37</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_37">http://www.w3.org/2007/uwa/context/common.owl#UriSchema_37</seealso>
    let UriSchema_37 = Prefixed_Name(common, "UriSchema_37") |> PrefixedName
    /// <summary>
    ///   <para>common:active</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a generic relationship between a Context Entity and other Context Entities which are  active in the scope of the former. For instance, the active Bluetooth Profile of a Device or the active Font within an Application</para>
    /// labels<para>Active</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#active">http://www.w3.org/2007/uwa/context/common.owl#active</seealso>
    let active = Prefixed_Name(common, "active") |> PrefixedName
    /// <summary>
    ///   <para>common:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A generic property that represents Context Entities that are available</para>
    /// labels<para>Available</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#available">http://www.w3.org/2007/uwa/context/common.owl#available</seealso>
    let available = Prefixed_Name(common, "available") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_21</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>W-HTTP</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_21">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_21</seealso>
    let ApplicationProtocol_21 =
        Prefixed_Name(common, "ApplicationProtocol_21") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_27</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>WSP Connection-Less</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_27">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_27</seealso>
    let ApplicationProtocol_27 =
        Prefixed_Name(common, "ApplicationProtocol_27") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_28</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>WTLS</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_28">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_28</seealso>
    let ApplicationProtocol_28 =
        Prefixed_Name(common, "ApplicationProtocol_28") |> PrefixedName

    /// <summary>
    ///   <para>common:CharacterSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents specific character sets officially identified by IANA</para>
    /// labels<para>Character Set</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#CharacterSet">http://www.w3.org/2007/uwa/context/common.owl#CharacterSet</seealso>
    let CharacterSet = Prefixed_Name(common, "CharacterSet") |> PrefixedName
    /// <summary>
    ///   <para>common:normativeReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This annotation property serves for indicating normative references for an entity in the ontology. It can be used in order to support the (automatic) documentation generation process</para>
    /// labels<para>normativeReference</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#normativeReference">http://www.w3.org/2007/uwa/context/common.owl#normativeReference</seealso>
    let normativeReference = Prefixed_Name(common, "normativeReference") |> PrefixedName
    /// <summary>
    ///   <para>common:ContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is a class that represents content types,  the combination of a MIME media type, subtype and optional parameters</para>
    /// labels<para>Content Type</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ContentType">http://www.w3.org/2007/uwa/context/common.owl#ContentType</seealso>
    let ContentType = Prefixed_Name(common, "ContentType") |> PrefixedName
    /// <summary>
    ///   <para>common:EnglishUSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Language</para>
    ///   <para>American English</para>
    /// labels<para>English USA</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#EnglishUSA">http://www.w3.org/2007/uwa/context/common.owl#EnglishUSA</seealso>
    let EnglishUSA = Prefixed_Name(common, "EnglishUSA") |> PrefixedName
    /// <summary>
    ///   <para>common:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents languages</para>
    /// labels<para>Language</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Language">http://www.w3.org/2007/uwa/context/common.owl#Language</seealso>
    let Language = Prefixed_Name(common, "Language") |> PrefixedName
    /// <summary>
    ///   <para>common:languageTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A language tag according to the rules specified by RFC 4646</para>
    /// labels<para>Language Tag</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#languageTag">http://www.w3.org/2007/uwa/context/common.owl#languageTag</seealso>
    let languageTag = Prefixed_Name(common, "languageTag") |> PrefixedName
    /// <summary>
    ///   <para>common:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents features, which are distinguishing characteristics of an item</para>
    /// labels<para>Feature</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Feature">http://www.w3.org/2007/uwa/context/common.owl#Feature</seealso>
    let Feature = Prefixed_Name(common, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>common:NormativeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the normative status of an entity in the ontology. It is used  as an auxiliary element for automatic documentation generation</para>
    /// labels<para>Normative Status</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#NormativeStatus">http://www.w3.org/2007/uwa/context/common.owl#NormativeStatus</seealso>
    let NormativeStatus = Prefixed_Name(common, "NormativeStatus") |> PrefixedName
    /// <summary>
    ///   <para>common:InputModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents input modalities</para>
    /// labels<para>Input Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#InputModality">http://www.w3.org/2007/uwa/context/common.owl#InputModality</seealso>
    let InputModality = Prefixed_Name(common, "InputModality") |> PrefixedName
    /// <summary>
    ///   <para>common:Modality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents modalities, the type of communication channel used for interaction. It also covers the way an idea is expressed or perceived, or the manner in which an action is performed.</para>
    /// labels<para>Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Modality">http://www.w3.org/2007/uwa/context/common.owl#Modality</seealso>
    let Modality = Prefixed_Name(common, "Modality") |> PrefixedName

    /// <summary>
    ///   <para>common:InputModality_GESTURE</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:InputModality</para>
    ///   <para>Modality that consists of the realization of gestures to input information or commands to the system</para>
    /// labels<para>Gesture Input Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_GESTURE">http://www.w3.org/2007/uwa/context/common.owl#InputModality_GESTURE</seealso>
    let InputModality_GESTURE =
        Prefixed_Name(common, "InputModality_GESTURE") |> PrefixedName

    /// <summary>
    ///   <para>common:InputModality_TYPING</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:InputModality</para>
    ///   <para>An input modality in whoch the user enters information by typing using a keyboard or similar</para>
    /// labels<para>Typing Input Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_TYPING">http://www.w3.org/2007/uwa/context/common.owl#InputModality_TYPING</seealso>
    let InputModality_TYPING =
        Prefixed_Name(common, "InputModality_TYPING") |> PrefixedName

    /// <summary>
    ///   <para>common:InputModality_VOICE</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:InputModality</para>
    ///   <para>Modality that consists of input introduction by means of voice</para>
    /// labels<para>Voice Input Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_VOICE">http://www.w3.org/2007/uwa/context/common.owl#InputModality_VOICE</seealso>
    let InputModality_VOICE =
        Prefixed_Name(common, "InputModality_VOICE") |> PrefixedName

    /// <summary>
    ///   <para>common:MIME_TYPE_GIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ContentType</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#MIME_TYPE_GIF">http://www.w3.org/2007/uwa/context/common.owl#MIME_TYPE_GIF</seealso>
    let MIME_TYPE_GIF = Prefixed_Name(common, "MIME_TYPE_GIF") |> PrefixedName
    /// <summary>
    ///   <para>common:contentTypeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property identifies unequivocally a content type. It is  the concatenation of the MIME Media type, subtype and optional parameters  according to the syntax specified on RFC 2045, section 5.1</para>
    /// labels<para>Content Type Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#contentTypeName">http://www.w3.org/2007/uwa/context/common.owl#contentTypeName</seealso>
    let contentTypeName = Prefixed_Name(common, "contentTypeName") |> PrefixedName
    /// <summary>
    ///   <para>common:restrictedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The element to which a restriction applies</para>
    /// labels<para>Restricted Element</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#restrictedElement">http://www.w3.org/2007/uwa/context/common.owl#restrictedElement</seealso>
    let restrictedElement = Prefixed_Name(common, "restrictedElement") |> PrefixedName
    /// <summary>
    ///   <para>common:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The serial number of something</para>
    /// labels<para>Serial Number</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#serialNumber">http://www.w3.org/2007/uwa/context/common.owl#serialNumber</seealso>
    let serialNumber = Prefixed_Name(common, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>common:termGroups</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An annotation property to indicate the term groups of the Delivery Context Ontology</para>
    /// labels<para>termGroups</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#termGroups">http://www.w3.org/2007/uwa/context/common.owl#termGroups</seealso>
    let termGroups = Prefixed_Name(common, "termGroups") |> PrefixedName

    /// <summary>
    ///   <para>common:InputModality_TACTILE</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:InputModality</para>
    ///   <para>An input modality in which information is entered by touching some sensor or device</para>
    /// labels<para>Tactile Input Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#InputModality_TACTILE">http://www.w3.org/2007/uwa/context/common.owl#InputModality_TACTILE</seealso>
    let InputModality_TACTILE =
        Prefixed_Name(common, "InputModality_TACTILE") |> PrefixedName

    /// <summary>
    ///   <para>common:OutputModality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents output modalities</para>
    /// labels<para>Output Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality">http://www.w3.org/2007/uwa/context/common.owl#OutputModality</seealso>
    let OutputModality = Prefixed_Name(common, "OutputModality") |> PrefixedName

    /// <summary>
    ///   <para>common:OutputModality_AURAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:OutputModality</para>
    ///   <para>This modality indicates the ability to use audio as an output modality</para>
    /// labels<para>Aural Output Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_AURAL">http://www.w3.org/2007/uwa/context/common.owl#OutputModality_AURAL</seealso>
    let OutputModality_AURAL =
        Prefixed_Name(common, "OutputModality_AURAL") |> PrefixedName

    /// <summary>
    ///   <para>common:OutputModality_VISUAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:OutputModality</para>
    ///   <para>This is an output modality in which information is perceived visually by the user</para>
    /// labels<para>Visual Output Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_VISUAL">http://www.w3.org/2007/uwa/context/common.owl#OutputModality_VISUAL</seealso>
    let OutputModality_VISUAL =
        Prefixed_Name(common, "OutputModality_VISUAL") |> PrefixedName

    /// <summary>
    ///   <para>common:Sibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    ///   <para></para>
    /// labels<para>Common Sibling</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Sibling_Disjoint">http://www.w3.org/2007/uwa/context/common.owl#Sibling_Disjoint</seealso>
    let Sibling_Disjoint = Prefixed_Name(common, "Sibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>common:timeZoneString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is a string that denotes the timezone as per the rules defined by POSIX 1003.1 in Section 8.3</para>
    /// labels<para>Time Zone String</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#timeZoneString">http://www.w3.org/2007/uwa/context/common.owl#timeZoneString</seealso>
    let timeZoneString = Prefixed_Name(common, "timeZoneString") |> PrefixedName
    /// <summary>
    ///   <para>common:TransferEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents transfer encoding formats as specified by RFC 2045 and registered with IANA</para>
    /// labels<para>Transfer Encoding</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding</seealso>
    let TransferEncoding = Prefixed_Name(common, "TransferEncoding") |> PrefixedName

    /// <summary>
    ///   <para>common:transferEncodingName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a transfer encoding as officially defined by IANA</para>
    /// labels<para>Transfer Encoding Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#transferEncodingName">http://www.w3.org/2007/uwa/context/common.owl#transferEncodingName</seealso>
    let transferEncodingName =
        Prefixed_Name(common, "transferEncodingName") |> PrefixedName

    /// <summary>
    ///   <para>common:OutputModality_TACTILE</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:OutputModality</para>
    ///   <para>This is a tactile modality in which user receives information from the system by means of the tac</para>
    /// labels<para>Tactile Output Modality</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#OutputModality_TACTILE">http://www.w3.org/2007/uwa/context/common.owl#OutputModality_TACTILE</seealso>
    let OutputModality_TACTILE =
        Prefixed_Name(common, "OutputModality_TACTILE") |> PrefixedName

    /// <summary>
    ///   <para>common:SoundMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sound modes that can be chosen by the user of a device</para>
    /// labels<para>Sound Mode</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode">http://www.w3.org/2007/uwa/context/common.owl#SoundMode</seealso>
    let SoundMode = Prefixed_Name(common, "SoundMode") |> PrefixedName
    /// <summary>
    ///   <para>common:SpanishSpain</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Language</para>
    ///   <para>Spanish spoken Spain</para>
    /// labels<para>Spanish-Spain</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#SpanishSpain">http://www.w3.org/2007/uwa/context/common.owl#SpanishSpain</seealso>
    let SpanishSpain = Prefixed_Name(common, "SpanishSpain") |> PrefixedName
    /// <summary>
    ///   <para>common:TermGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is an utility class that serves to represent the different term groups that compose the Delivery Context Ontology</para>
    /// labels<para>Term Group</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TermGroup">http://www.w3.org/2007/uwa/context/common.owl#TermGroup</seealso>
    let TermGroup = Prefixed_Name(common, "TermGroup") |> PrefixedName
    /// <summary>
    ///   <para>common:termGroupPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The prefix used for a group of terms</para>
    /// labels<para>Term Group Prefix</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#termGroupPrefix">http://www.w3.org/2007/uwa/context/common.owl#termGroupPrefix</seealso>
    let termGroupPrefix = Prefixed_Name(common, "termGroupPrefix") |> PrefixedName
    /// <summary>
    ///   <para>common:tzName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the name of a Zone entry in the database commonly referred  to as the TZ database.  Specifically, in the database's  textual form,  the string refers to the name field of a zone line</para>
    /// labels<para>TZ Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#tzName">http://www.w3.org/2007/uwa/context/common.owl#tzName</seealso>
    let tzName = Prefixed_Name(common, "tzName") |> PrefixedName

    /// <summary>
    ///   <para>common:TransferEncoding_8bit</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TransferEncoding</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_8bit">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_8bit</seealso>
    let TransferEncoding_8bit =
        Prefixed_Name(common, "TransferEncoding_8bit") |> PrefixedName

    /// <summary>
    ///   <para>common:TransferEncoding_Binary</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TransferEncoding</para>
    ///   <para>The binary encoding format as specified in RFC4289</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Binary">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_Binary</seealso>
    let TransferEncoding_Binary =
        Prefixed_Name(common, "TransferEncoding_Binary") |> PrefixedName

    /// <summary>
    ///   <para>common:TransferEncoding_QuotedPrintable</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TransferEncoding</para>
    ///   <para>The quoted printable transfer encoding format as specified in the RFC "Multipurpose Internet Mail Extensions (MIME) Part Four</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_QuotedPrintable">http://www.w3.org/2007/uwa/context/common.owl#TransferEncoding_QuotedPrintable</seealso>
    let TransferEncoding_QuotedPrintable =
        Prefixed_Name(common, "TransferEncoding_QuotedPrintable") |> PrefixedName

    /// <summary>
    ///   <para>common:uriSchemeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a URI scheme as officially defined by IANA</para>
    /// labels<para>URI Scheme Name</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#uriSchemeName">http://www.w3.org/2007/uwa/context/common.owl#uriSchemeName</seealso>
    let uriSchemeName = Prefixed_Name(common, "uriSchemeName") |> PrefixedName
    /// <summary>
    ///   <para>common:TermGroup_Common</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>They are a set of general purpose, generic classes, properties and instances which are used to support the modelling of the different aspects of a Delivery Context</para>
    /// labels<para>Common</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TermGroup_Common">http://www.w3.org/2007/uwa/context/common.owl#TermGroup_Common</seealso>
    let TermGroup_Common = Prefixed_Name(common, "TermGroup_Common") |> PrefixedName
    /// <summary>
    ///   <para>common:TimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A time zone is an identifier for a specific location or region which translates into a combination of rules for calculating an UTC offset</para>
    /// labels<para>Timezone</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#TimeZone">http://www.w3.org/2007/uwa/context/common.owl#TimeZone</seealso>
    let TimeZone = Prefixed_Name(common, "TimeZone") |> PrefixedName
    /// <summary>
    ///   <para>common:UriSchema_31</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_31">http://www.w3.org/2007/uwa/context/common.owl#UriSchema_31</seealso>
    let UriSchema_31 = Prefixed_Name(common, "UriSchema_31") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_23</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>FTP</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_23">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_23</seealso>
    let ApplicationProtocol_23 =
        Prefixed_Name(common, "ApplicationProtocol_23") |> PrefixedName

    /// <summary>
    ///   <para>common:UriScheme_HTTP</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    ///   <para>This instance represents the "http" URI Scheme</para>
    /// labels<para>HTTP Scheme</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriScheme_HTTP">http://www.w3.org/2007/uwa/context/common.owl#UriScheme_HTTP</seealso>
    let UriScheme_HTTP = Prefixed_Name(common, "UriScheme_HTTP") |> PrefixedName
    /// <summary>
    ///   <para>common:disjointSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is aimed at linking groups of disjoint classes between them</para>
    /// labels<para>Disjoint Set</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#disjointSet">http://www.w3.org/2007/uwa/context/common.owl#disjointSet</seealso>
    let disjointSet = Prefixed_Name(common, "disjointSet") |> PrefixedName
    /// <summary>
    ///   <para>common:relatedDDRCoreVoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The name of a  W3C DDR Core Vocabulary property to which a property in the ontology relates to</para>
    /// labels<para>Related DDR Core Vocabulary Property</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#relatedDDRCoreVoc">http://www.w3.org/2007/uwa/context/common.owl#relatedDDRCoreVoc</seealso>
    let relatedDDRCoreVoc = Prefixed_Name(common, "relatedDDRCoreVoc") |> PrefixedName
    /// <summary>
    ///   <para>common:normativeURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property holds a URI that points to the normative specification of a software technology. One example are the estable  URIs that are associated to W3C Recommendations</para>
    /// labels<para>Normative URI</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#normativeURI">http://www.w3.org/2007/uwa/context/common.owl#normativeURI</seealso>
    let normativeURI = Prefixed_Name(common, "normativeURI") |> PrefixedName
    /// <summary>
    ///   <para>common:pixelAspectRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The pixel aspect ratio as a decimal value, for example 1.33 for a 4:3 aspect. The pixel aspect ratio is the ratio of the resolution width in pixels, to the resolution height in pixels</para>
    /// labels<para>Pixel Aspect Ratio</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#pixelAspectRatio">http://www.w3.org/2007/uwa/context/common.owl#pixelAspectRatio</seealso>
    let pixelAspectRatio = Prefixed_Name(common, "pixelAspectRatio") |> PrefixedName
    /// <summary>
    ///   <para>common:resolutionHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The total number of addressable pixels in the vertical direction of a rectangular element (such as Camera, Display, Image, Video, ...) when held in its default orientation</para>
    /// labels<para>Resolution Height</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#resolutionHeight">http://www.w3.org/2007/uwa/context/common.owl#resolutionHeight</seealso>
    let resolutionHeight = Prefixed_Name(common, "resolutionHeight") |> PrefixedName
    /// <summary>
    ///   <para>common:restrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The restrictions presented by a context entity</para>
    /// labels<para>Restrictions</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#restrictions">http://www.w3.org/2007/uwa/context/common.owl#restrictions</seealso>
    let restrictions = Prefixed_Name(common, "restrictions") |> PrefixedName
    /// <summary>
    ///   <para>common:sip</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#sip">http://www.w3.org/2007/uwa/context/common.owl#sip</seealso>
    let sip = Prefixed_Name(common, "sip") |> PrefixedName
    /// <summary>
    ///   <para>common:soundMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents the sound mode currently setted on a device</para>
    /// labels<para>Sound Mode</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#soundMode">http://www.w3.org/2007/uwa/context/common.owl#soundMode</seealso>
    let soundMode = Prefixed_Name(common, "soundMode") |> PrefixedName
    /// <summary>
    ///   <para>common:standardNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This is a generic property that holds a  machine-readable string that identifies univoquely an standard, for example,  EN 302 409 or TS 102 221</para>
    /// labels<para>Standard Number</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#standardNumber">http://www.w3.org/2007/uwa/context/common.owl#standardNumber</seealso>
    let standardNumber = Prefixed_Name(common, "standardNumber") |> PrefixedName

    /// <summary>
    ///   <para>common:ApplicationProtocol_24</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:ApplicationProtocol</para>
    ///   <para>HTTP</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_24">http://www.w3.org/2007/uwa/context/common.owl#ApplicationProtocol_24</seealso>
    let ApplicationProtocol_24 =
        Prefixed_Name(common, "ApplicationProtocol_24") |> PrefixedName

    /// <summary>
    ///   <para>common:UriSchema_32</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_32">http://www.w3.org/2007/uwa/context/common.owl#UriSchema_32</seealso>
    let UriSchema_32 = Prefixed_Name(common, "UriSchema_32") |> PrefixedName
    /// <summary>
    ///   <para>common:UriSchema_34</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:UriScheme</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#UriSchema_34">http://www.w3.org/2007/uwa/context/common.owl#UriSchema_34</seealso>
    let UriSchema_34 = Prefixed_Name(common, "UriSchema_34") |> PrefixedName
    /// <summary>
    ///   <para>common:AllDisjointSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is an utility class for representing groups of classes that are pairwise disjoint, following the approach specified by the OWL Abstract Syntax. This class has been created as a workaround to the absence in OWL 1 of an specific construct for establishing class disjointness between groups of classes</para>
    /// labels<para>All Disjoint Set</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#AllDisjointSet">http://www.w3.org/2007/uwa/context/common.owl#AllDisjointSet</seealso>
    let AllDisjointSet = Prefixed_Name(common, "AllDisjointSet") |> PrefixedName
    /// <summary>
    ///   <para>common:SoundMode_NORMAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:SoundMode</para>
    ///   <para>Normal Sound Mode</para>
    /// labels<para>Normal</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#SoundMode_NORMAL">http://www.w3.org/2007/uwa/context/common.owl#SoundMode_NORMAL</seealso>
    let SoundMode_NORMAL = Prefixed_Name(common, "SoundMode_NORMAL") |> PrefixedName
    /// <summary>
    ///   <para>common:Utility</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:NormativeStatus</para>
    ///   <para>This instance represents the "utility" status</para>
    /// labels<para>Utility</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#Utility">http://www.w3.org/2007/uwa/context/common.owl#Utility</seealso>
    let Utility = Prefixed_Name(common, "Utility") |> PrefixedName
    /// <summary>
    ///   <para>common:languageCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>It represents a language code according to ISO 639 Part 3</para>
    /// labels<para>Language Code</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/common.owl#languageCode">http://www.w3.org/2007/uwa/context/common.owl#languageCode</seealso>
    let languageCode = Prefixed_Name(common, "languageCode") |> PrefixedName

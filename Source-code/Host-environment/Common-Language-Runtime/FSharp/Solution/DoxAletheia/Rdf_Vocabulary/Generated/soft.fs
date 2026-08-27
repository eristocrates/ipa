namespace http.www.w3.org._2007.uwa.context.software.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module soft =
    let _namespace_iri = Namespace_Iri soft |> NamespaceIRI
    /// <summary>
    ///   <para>soft:Api</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a generic class that represents an application programming interface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"API"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Api">http://www.w3.org/2007/uwa/context/software.owl#Api</seealso>
    let Api = Prefixed_Name(soft, "Api") |> PrefixedName
    /// <summary>
    ///   <para>soft:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an application program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application Program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Application">http://www.w3.org/2007/uwa/context/software.owl#Application</seealso>
    let Application = Prefixed_Name(soft, "Application") |> PrefixedName
    /// <summary>
    ///   <para>soft:AudioFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular audio format, such as MP3 or WAV"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Audio Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#AudioFormat">http://www.w3.org/2007/uwa/context/software.owl#AudioFormat</seealso>
    let AudioFormat = Prefixed_Name(soft, "AudioFormat") |> PrefixedName
    /// <summary>
    ///   <para>soft:AudioPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a user agent capable of dealing with audio formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Audio Player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#AudioPlayer">http://www.w3.org/2007/uwa/context/software.owl#AudioPlayer</seealso>
    let AudioPlayer = Prefixed_Name(soft, "AudioPlayer") |> PrefixedName
    /// <summary>
    ///   <para>soft:AudioRecorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a user agent capable of recording audio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Audio Recorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#AudioRecorder">http://www.w3.org/2007/uwa/context/software.owl#AudioRecorder</seealso>
    let AudioRecorder = Prefixed_Name(soft, "AudioRecorder") |> PrefixedName
    /// <summary>
    ///   <para>soft:Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a digital certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Certificate">http://www.w3.org/2007/uwa/context/software.owl#Certificate</seealso>
    let Certificate = Prefixed_Name(soft, "Certificate") |> PrefixedName

    /// <summary>
    ///   <para>soft:Context_SoftwareEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class subsumes all the entities in the ontology that have to do with software-specific characterisitics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Software Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Context_SoftwareEntity">http://www.w3.org/2007/uwa/context/software.owl#Context_SoftwareEntity</seealso>
    let Context_SoftwareEntity =
        Prefixed_Name(soft, "Context_SoftwareEntity") |> PrefixedName

    /// <summary>
    ///   <para>soft:DeviceSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the software in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#DeviceSoftware">http://www.w3.org/2007/uwa/context/software.owl#DeviceSoftware</seealso>
    let DeviceSoftware = Prefixed_Name(soft, "DeviceSoftware") |> PrefixedName
    /// <summary>
    ///   <para>soft:EmailClient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a user agent capable of sending and receiving e-mail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"E-Mail Client"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#EmailClient">http://www.w3.org/2007/uwa/context/software.owl#EmailClient</seealso>
    let EmailClient = Prefixed_Name(soft, "EmailClient") |> PrefixedName

    /// <summary>
    ///   <para>soft:Feature_VIRTUALKEYBOARD</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Feature</para>
    ///   <para>"Virtual keyboard feature indicates that exists a virtual keyboard that facilitiates user input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Virtual Keyboard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Feature_VIRTUALKEYBOARD">http://www.w3.org/2007/uwa/context/software.owl#Feature_VIRTUALKEYBOARD</seealso>
    let Feature_VIRTUALKEYBOARD =
        Prefixed_Name(soft, "Feature_VIRTUALKEYBOARD") |> PrefixedName

    /// <summary>
    ///   <para>soft:Font</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents fonts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Font">http://www.w3.org/2007/uwa/context/software.owl#Font</seealso>
    let Font = Prefixed_Name(soft, "Font") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents  Font Familiies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily">http://www.w3.org/2007/uwa/context/software.owl#FontFamily</seealso>
    let FontFamily = Prefixed_Name(soft, "FontFamily") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontFamily_CURSIVE</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Generic Cursive Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cursive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily_CURSIVE">http://www.w3.org/2007/uwa/context/software.owl#FontFamily_CURSIVE</seealso>
    let FontFamily_CURSIVE = Prefixed_Name(soft, "FontFamily_CURSIVE") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontFamily_FANTASY</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Generic Fantasy Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fantasy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily_FANTASY">http://www.w3.org/2007/uwa/context/software.owl#FontFamily_FANTASY</seealso>
    let FontFamily_FANTASY = Prefixed_Name(soft, "FontFamily_FANTASY") |> PrefixedName

    /// <summary>
    ///   <para>soft:FontFamily_MONOSPACE</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Generic Monospace Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Monospace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily_MONOSPACE">http://www.w3.org/2007/uwa/context/software.owl#FontFamily_MONOSPACE</seealso>
    let FontFamily_MONOSPACE =
        Prefixed_Name(soft, "FontFamily_MONOSPACE") |> PrefixedName

    /// <summary>
    ///   <para>soft:FontFamily_SANS_SERIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Generic Sans Serif Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sans Serif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily_SANS_SERIF">http://www.w3.org/2007/uwa/context/software.owl#FontFamily_SANS_SERIF</seealso>
    let FontFamily_SANS_SERIF =
        Prefixed_Name(soft, "FontFamily_SANS_SERIF") |> PrefixedName

    /// <summary>
    ///   <para>soft:FontFamily_SERIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Generic Serif Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Serif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontFamily_SERIF">http://www.w3.org/2007/uwa/context/software.owl#FontFamily_SERIF</seealso>
    let FontFamily_SERIF = Prefixed_Name(soft, "FontFamily_SERIF") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class denotes font styles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font Style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontStyle">http://www.w3.org/2007/uwa/context/software.owl#FontStyle</seealso>
    let FontStyle = Prefixed_Name(soft, "FontStyle") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontStyle_ITALICS</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontStyle</para>
    ///   <para>"Italics style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Italics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontStyle_ITALICS">http://www.w3.org/2007/uwa/context/software.owl#FontStyle_ITALICS</seealso>
    let FontStyle_ITALICS = Prefixed_Name(soft, "FontStyle_ITALICS") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontStyle_NORMAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontStyle</para>
    ///   <para>"Normal Style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Normal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontStyle_NORMAL">http://www.w3.org/2007/uwa/context/software.owl#FontStyle_NORMAL</seealso>
    let FontStyle_NORMAL = Prefixed_Name(soft, "FontStyle_NORMAL") |> PrefixedName
    /// <summary>
    ///   <para>soft:FontStyle_OBLIQUE</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontStyle</para>
    ///   <para>"Oblique Style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oblique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#FontStyle_OBLIQUE">http://www.w3.org/2007/uwa/context/software.owl#FontStyle_OBLIQUE</seealso>
    let FontStyle_OBLIQUE = Prefixed_Name(soft, "FontStyle_OBLIQUE") |> PrefixedName
    /// <summary>
    ///   <para>soft:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents formats that can be used to represent something"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Format">http://www.w3.org/2007/uwa/context/software.owl#Format</seealso>
    let Format = Prefixed_Name(soft, "Format") |> PrefixedName
    /// <summary>
    ///   <para>soft:HandlingAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the relationship between an entity (MIME Type, URI Scheme, etc.)  and a program capable of handling such entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handling Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#HandlingAssociation">http://www.w3.org/2007/uwa/context/software.owl#HandlingAssociation</seealso>
    let HandlingAssociation = Prefixed_Name(soft, "HandlingAssociation") |> PrefixedName
    /// <summary>
    ///   <para>soft:ImageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular image format, such as jpeg, gif or png"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#ImageFormat">http://www.w3.org/2007/uwa/context/software.owl#ImageFormat</seealso>
    let ImageFormat = Prefixed_Name(soft, "ImageFormat") |> PrefixedName
    /// <summary>
    ///   <para>soft:MP3</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:AudioFormat</para>
    ///   <para>"MP3 audio format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#MP3">http://www.w3.org/2007/uwa/context/software.owl#MP3</seealso>
    let MP3 = Prefixed_Name(soft, "MP3") |> PrefixedName
    /// <summary>
    ///   <para>soft:MP4</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:VideoFormat</para>
    ///   <para>"The MP4 video format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#MP4">http://www.w3.org/2007/uwa/context/software.owl#MP4</seealso>
    let MP4 = Prefixed_Name(soft, "MP4") |> PrefixedName
    /// <summary>
    ///   <para>soft:MediaPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents any kind of user agent capable of playing media"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media Player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#MediaPlayer">http://www.w3.org/2007/uwa/context/software.owl#MediaPlayer</seealso>
    let MediaPlayer = Prefixed_Name(soft, "MediaPlayer") |> PrefixedName
    /// <summary>
    ///   <para>soft:MediaRecorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a user agent capable of recording different kind of media, such as a audio or video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Media Recorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#MediaRecorder">http://www.w3.org/2007/uwa/context/software.owl#MediaRecorder</seealso>
    let MediaRecorder = Prefixed_Name(soft, "MediaRecorder") |> PrefixedName
    /// <summary>
    ///   <para>soft:OperatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents operating systems"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#OperatingSystem">http://www.w3.org/2007/uwa/context/software.owl#OperatingSystem</seealso>
    let OperatingSystem = Prefixed_Name(soft, "OperatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>soft:PDF</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:Format</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#PDF">http://www.w3.org/2007/uwa/context/software.owl#PDF</seealso>
    let PDF = Prefixed_Name(soft, "PDF") |> PrefixedName
    /// <summary>
    ///   <para>soft:PJPG</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"The progressive JPEG file image format image type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#PJPG">http://www.w3.org/2007/uwa/context/software.owl#PJPG</seealso>
    let PJPG = Prefixed_Name(soft, "PJPG") |> PrefixedName
    /// <summary>
    ///   <para>soft:Plugin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a plugin, i.e. a software piece which extends the functionality offered by a host application (web browser, drawing application, etc)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plugin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Plugin">http://www.w3.org/2007/uwa/context/software.owl#Plugin</seealso>
    let Plugin = Prefixed_Name(soft, "Plugin") |> PrefixedName
    /// <summary>
    ///   <para>soft:Program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a computer program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Program">http://www.w3.org/2007/uwa/context/software.owl#Program</seealso>
    let Program = Prefixed_Name(soft, "Program") |> PrefixedName
    /// <summary>
    ///   <para>soft:Program_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Program_Disjoint">http://www.w3.org/2007/uwa/context/software.owl#Program_Disjoint</seealso>
    let Program_Disjoint = Prefixed_Name(soft, "Program_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>soft:RuntimeEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a runtime environment present in a device. It can be a JRE, Brew or any other technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#RuntimeEnvironment">http://www.w3.org/2007/uwa/context/software.owl#RuntimeEnvironment</seealso>
    let RuntimeEnvironment = Prefixed_Name(soft, "RuntimeEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>soft:SiblingDisjoint2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#SiblingDisjoint2">http://www.w3.org/2007/uwa/context/software.owl#SiblingDisjoint2</seealso>
    let SiblingDisjoint2 = Prefixed_Name(soft, "SiblingDisjoint2") |> PrefixedName
    /// <summary>
    ///   <para>soft:SiblingDisjoint4</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#SiblingDisjoint4">http://www.w3.org/2007/uwa/context/software.owl#SiblingDisjoint4</seealso>
    let SiblingDisjoint4 = Prefixed_Name(soft, "SiblingDisjoint4") |> PrefixedName
    /// <summary>
    ///   <para>soft:Sibling_Disjoint1</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Sibling_Disjoint1">http://www.w3.org/2007/uwa/context/software.owl#Sibling_Disjoint1</seealso>
    let Sibling_Disjoint1 = Prefixed_Name(soft, "Sibling_Disjoint1") |> PrefixedName
    /// <summary>
    ///   <para>soft:Sibling_Disjoint3</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#Sibling_Disjoint3">http://www.w3.org/2007/uwa/context/software.owl#Sibling_Disjoint3</seealso>
    let Sibling_Disjoint3 = Prefixed_Name(soft, "Sibling_Disjoint3") |> PrefixedName
    /// <summary>
    ///   <para>soft:SoftwareAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a software aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software Aspect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#SoftwareAspect">http://www.w3.org/2007/uwa/context/software.owl#SoftwareAspect</seealso>
    let SoftwareAspect = Prefixed_Name(soft, "SoftwareAspect") |> PrefixedName
    /// <summary>
    ///   <para>soft:TermGroup_Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"It is a set of properties, classes and instances that model the software elements of a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#TermGroup_Software">http://www.w3.org/2007/uwa/context/software.owl#TermGroup_Software</seealso>
    let TermGroup_Software = Prefixed_Name(soft, "TermGroup_Software") |> PrefixedName
    /// <summary>
    ///   <para>soft:UserAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a client within a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#UserAgent">http://www.w3.org/2007/uwa/context/software.owl#UserAgent</seealso>
    let UserAgent = Prefixed_Name(soft, "UserAgent") |> PrefixedName
    /// <summary>
    ///   <para>soft:VideoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a particular video format, such as AVI or MP4"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Video Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#VideoFormat">http://www.w3.org/2007/uwa/context/software.owl#VideoFormat</seealso>
    let VideoFormat = Prefixed_Name(soft, "VideoFormat") |> PrefixedName
    /// <summary>
    ///   <para>soft:VideoPlayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents user agents capable of dealing with video formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Video Player"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#VideoPlayer">http://www.w3.org/2007/uwa/context/software.owl#VideoPlayer</seealso>
    let VideoPlayer = Prefixed_Name(soft, "VideoPlayer") |> PrefixedName
    /// <summary>
    ///   <para>soft:VideoRecorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a user agent capable of recording video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Video Recorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#VideoRecorder">http://www.w3.org/2007/uwa/context/software.owl#VideoRecorder</seealso>
    let VideoRecorder = Prefixed_Name(soft, "VideoRecorder") |> PrefixedName
    /// <summary>
    ///   <para>soft:X509Certificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an X.509 certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"X.509 Certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#X509Certificate">http://www.w3.org/2007/uwa/context/software.owl#X509Certificate</seealso>
    let X509Certificate = Prefixed_Name(soft, "X509Certificate") |> PrefixedName
    /// <summary>
    ///   <para>soft:XmlFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents formats that are represented using XML"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XML Format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#XmlFormat">http://www.w3.org/2007/uwa/context/software.owl#XmlFormat</seealso>
    let XmlFormat = Prefixed_Name(soft, "XmlFormat") |> PrefixedName

    /// <summary>
    ///   <para>soft:acceptedCharacterSets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the charsets accepted  by a user agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accepted Character Sets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#acceptedCharacterSets">http://www.w3.org/2007/uwa/context/software.owl#acceptedCharacterSets</seealso>
    let acceptedCharacterSets =
        Prefixed_Name(soft, "acceptedCharacterSets") |> PrefixedName

    /// <summary>
    ///   <para>soft:acceptedTransferEncodings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The accepted transfer encodings supported by a user agent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accepted Transfer Encodings"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#acceptedTransferEncodings">http://www.w3.org/2007/uwa/context/software.owl#acceptedTransferEncodings</seealso>
    let acceptedTransferEncodings =
        Prefixed_Name(soft, "acceptedTransferEncodings") |> PrefixedName

    /// <summary>
    ///   <para>soft:apis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The  APIs supported by a user agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"APIs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#apis">http://www.w3.org/2007/uwa/context/software.owl#apis</seealso>
    let apis = Prefixed_Name(soft, "apis") |> PrefixedName

    /// <summary>
    ///   <para>soft:applicationProtocols</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the  application protocols by a program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Application Protocols"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#applicationProtocols">http://www.w3.org/2007/uwa/context/software.owl#applicationProtocols</seealso>
    let applicationProtocols =
        Prefixed_Name(soft, "applicationProtocols") |> PrefixedName

    /// <summary>
    ///   <para>soft:availableUserAgents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the available User Agents on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Available User Agents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#availableUserAgents">http://www.w3.org/2007/uwa/context/software.owl#availableUserAgents</seealso>
    let availableUserAgents = Prefixed_Name(soft, "availableUserAgents") |> PrefixedName
    /// <summary>
    ///   <para>soft:certificates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Installed certificates in a device or user agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Certificates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#certificates">http://www.w3.org/2007/uwa/context/software.owl#certificates</seealso>
    let certificates = Prefixed_Name(soft, "certificates") |> PrefixedName
    /// <summary>
    ///   <para>soft:characterColumns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The typical number of characters that can be displayed in a single row on the device display. This is an estimate using the default font for the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character Columns"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#characterColumns">http://www.w3.org/2007/uwa/context/software.owl#characterColumns</seealso>
    let characterColumns = Prefixed_Name(soft, "characterColumns") |> PrefixedName
    /// <summary>
    ///   <para>soft:characterRows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The typical number of rows of characters that can be displayed on the device display. This is an estimate using the default font for the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character Rows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#characterRows">http://www.w3.org/2007/uwa/context/software.owl#characterRows</seealso>
    let characterRows = Prefixed_Name(soft, "characterRows") |> PrefixedName
    /// <summary>
    ///   <para>soft:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"These are the MIME types associated with this type of format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MIME Type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#contentType">http://www.w3.org/2007/uwa/context/software.owl#contentType</seealso>
    let contentType = Prefixed_Name(soft, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>soft:defaultHandler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a default handler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Default Handler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#defaultHandler">http://www.w3.org/2007/uwa/context/software.owl#defaultHandler</seealso>
    let defaultHandler = Prefixed_Name(soft, "defaultHandler") |> PrefixedName
    /// <summary>
    ///   <para>soft:deviceSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the software on the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#deviceSoftware">http://www.w3.org/2007/uwa/context/software.owl#deviceSoftware</seealso>
    let deviceSoftware = Prefixed_Name(soft, "deviceSoftware") |> PrefixedName
    /// <summary>
    ///   <para>soft:fontFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The font family of a font"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font Family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#fontFamily">http://www.w3.org/2007/uwa/context/software.owl#fontFamily</seealso>
    let fontFamily = Prefixed_Name(soft, "fontFamily") |> PrefixedName
    /// <summary>
    ///   <para>soft:fontSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The absolute size of a font measured in points"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#fontSize">http://www.w3.org/2007/uwa/context/software.owl#fontSize</seealso>
    let fontSize = Prefixed_Name(soft, "fontSize") |> PrefixedName
    /// <summary>
    ///   <para>soft:fontStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the font style of a font"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Font Style"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#fontStyle">http://www.w3.org/2007/uwa/context/software.owl#fontStyle</seealso>
    let fontStyle = Prefixed_Name(soft, "fontStyle") |> PrefixedName
    /// <summary>
    ///   <para>soft:fonts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The fonts provided by a Context Entity. It can be the Device Software in general, a Web Browser or other program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fonts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#fonts">http://www.w3.org/2007/uwa/context/software.owl#fonts</seealso>
    let fonts = Prefixed_Name(soft, "fonts") |> PrefixedName
    /// <summary>
    ///   <para>soft:gif87</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#gif87">http://www.w3.org/2007/uwa/context/software.owl#gif87</seealso>
    let gif87 = Prefixed_Name(soft, "gif87") |> PrefixedName
    /// <summary>
    ///   <para>soft:gif89a</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#gif89a">http://www.w3.org/2007/uwa/context/software.owl#gif89a</seealso>
    let gif89a = Prefixed_Name(soft, "gif89a") |> PrefixedName
    /// <summary>
    ///   <para>soft:handledElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the handled element in a handler relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handled Element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#handledElement">http://www.w3.org/2007/uwa/context/software.owl#handledElement</seealso>
    let handledElement = Prefixed_Name(soft, "handledElement") |> PrefixedName
    /// <summary>
    ///   <para>soft:handler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a program that acts as a handler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Handler"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#handler">http://www.w3.org/2007/uwa/context/software.owl#handler</seealso>
    let handler = Prefixed_Name(soft, "handler") |> PrefixedName
    /// <summary>
    ///   <para>soft:issuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The issuer of a certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#issuer">http://www.w3.org/2007/uwa/context/software.owl#issuer</seealso>
    let issuer = Prefixed_Name(soft, "issuer") |> PrefixedName
    /// <summary>
    ///   <para>soft:jpeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"The JPEG file image format image type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#jpeg">http://www.w3.org/2007/uwa/context/software.owl#jpeg</seealso>
    let jpeg = Prefixed_Name(soft, "jpeg") |> PrefixedName
    /// <summary>
    ///   <para>soft:maxDeliveryUnitSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The maximum message size for a delivery unit supported by a user agent measured in bytes. A Delivery Unit can be defined as a set of material transferred between two cooperating  programs as the response to a single request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maximum Delivery Unit Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#maxDeliveryUnitSize">http://www.w3.org/2007/uwa/context/software.owl#maxDeliveryUnitSize</seealso>
    let maxDeliveryUnitSize = Prefixed_Name(soft, "maxDeliveryUnitSize") |> PrefixedName
    /// <summary>
    ///   <para>soft:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The namespace of an XML format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#namespace">http://www.w3.org/2007/uwa/context/software.owl#namespace</seealso>
    let namespace_ = Prefixed_Name(soft, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>soft:notAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property conveys a date that indicates that the certificate in question will not be valid after that date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Not After"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#notAfter">http://www.w3.org/2007/uwa/context/software.owl#notAfter</seealso>
    let notAfter = Prefixed_Name(soft, "notAfter") |> PrefixedName
    /// <summary>
    ///   <para>soft:notBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates that this certificate is valid not before this date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Not Before"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#notBefore">http://www.w3.org/2007/uwa/context/software.owl#notBefore</seealso>
    let notBefore = Prefixed_Name(soft, "notBefore") |> PrefixedName
    /// <summary>
    ///   <para>soft:operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the active operating system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Active Operating System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#operatingSystem">http://www.w3.org/2007/uwa/context/software.owl#operatingSystem</seealso>
    let operatingSystem = Prefixed_Name(soft, "operatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>soft:png</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:ImageFormat</para>
    ///   <para>"The PNG file image format image type."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#png">http://www.w3.org/2007/uwa/context/software.owl#png</seealso>
    let png = Prefixed_Name(soft, "png") |> PrefixedName
    /// <summary>
    ///   <para>soft:preferredFormats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The best supported formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Preferred Formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#preferredFormats">http://www.w3.org/2007/uwa/context/software.owl#preferredFormats</seealso>
    let preferredFormats = Prefixed_Name(soft, "preferredFormats") |> PrefixedName
    /// <summary>
    ///   <para>soft:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The subject of a certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#subject">http://www.w3.org/2007/uwa/context/software.owl#subject</seealso>
    let subject = Prefixed_Name(soft, "subject") |> PrefixedName
    /// <summary>
    ///   <para>soft:supportedFormats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the formats that are supported by a program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#supportedFormats">http://www.w3.org/2007/uwa/context/software.owl#supportedFormats</seealso>
    let supportedFormats = Prefixed_Name(soft, "supportedFormats") |> PrefixedName

    /// <summary>
    ///   <para>soft:supportedStreamedFormats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the formats that are supported by a program in streaming mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Streamed Formats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#supportedStreamedFormats">http://www.w3.org/2007/uwa/context/software.owl#supportedStreamedFormats</seealso>
    let supportedStreamedFormats =
        Prefixed_Name(soft, "supportedStreamedFormats") |> PrefixedName

    /// <summary>
    ///   <para>soft:uriSchemes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The supported URI Schemes of a user agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported URI Schemes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/software.owl#uriSchemes">http://www.w3.org/2007/uwa/context/software.owl#uriSchemes</seealso>
    let uriSchemes = Prefixed_Name(soft, "uriSchemes") |> PrefixedName

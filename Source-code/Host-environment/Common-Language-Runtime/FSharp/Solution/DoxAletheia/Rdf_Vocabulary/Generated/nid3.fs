namespace http.www.semanticdesktop.org.ontologies._2007._05._10.nid3.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nid3 =
    let _namespace_iri = Namespace_Iri nid3 |> NamespaceIRI
    /// <summary>
    ///   <para>nid3:SynchronizedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>SYLT This is another way of incorporating the words, said or sung lyrics, in the audio file as text, this time, however, in sync with the audio. It might also be used to describing events e.g. occurring on a stage or on the screen in sync with the audio. The header includes a content descriptor, represented with as terminated textstring. If no descriptor is entered, 'Content descriptor' is $00 (00) only.</para>
    /// labels<para>SynchronizedText</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedText">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedText</seealso>
    let SynchronizedText = Prefixed_Name(nid3, "SynchronizedText") |> PrefixedName

    /// <summary>
    ///   <para>nid3:contentGroupDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TIT1
    /// The 'Content group description' frame is used if the sound belongs to a larger category of sounds/music. For example, classical music is often sorted in different musical sections (e.g. "Piano Concerto", "Weather - Hurricane").</para>
    /// labels<para>contentGroupDescription</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentGroupDescription">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentGroupDescription</seealso>
    let contentGroupDescription =
        Prefixed_Name(nid3, "contentGroupDescription") |> PrefixedName

    /// <summary>
    ///   <para>nid3:copyrightInformationURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WCOP
    /// The 'Copyright/Legal information' frame is a URL pointing at a webpage where the terms of use and ownership of the file is described.</para>
    /// labels<para>copyrightInformationURL</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightInformationURL">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightInformationURL</seealso>
    let copyrightInformationURL =
        Prefixed_Name(nid3, "copyrightInformationURL") |> PrefixedName

    /// <summary>
    ///   <para>nid3:InvolvedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Since there might be a lot of people contributing to an audio file in various ways, such as musicians and technicians, the 'Text information frames' are often insufficient to list everyone involved in a project. The 'Involved people list' is a frame containing the names of those involved, and how they were involved. The body simply contains a terminated string with the involvement directly followed by a terminated string with the involvee followed by a new involvement and so on. There may only be one "IPLS" frame in each tag.
    /// Note that in this RDF representation each InvolvedPerson is represented with a separate instance of the InvolvedPerson class and with a separate involvedPerson triple.</para>
    /// labels<para>InvolvedPerson</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#InvolvedPerson">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#InvolvedPerson</seealso>
    let InvolvedPerson = Prefixed_Name(nid3, "InvolvedPerson") |> PrefixedName
    /// <summary>
    ///   <para>nid3:UserDefinedFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This frame is intended for one-string text information concerning the audiofile in a similar way to the other "T"-frames. The frame body consists of a description of the string, represented as a terminated string, followed by the actual string. There may be more than one "TXXX" frame in each tag, but only one with the same description.</para>
    /// labels<para>UserDefinedFrame</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedFrame">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedFrame</seealso>
    let UserDefinedFrame = Prefixed_Name(nid3, "UserDefinedFrame") |> PrefixedName
    /// <summary>
    ///   <para>nid3:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TDAT
    /// The 'Date' frame is a numeric string in the DDMM format containing the date for the recording. This field is always four characters long.</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#date">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#date</seealso>
    let date = Prefixed_Name(nid3, "date") |> PrefixedName

    /// <summary>
    ///   <para>nid3:SynchronizedTextElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An element of the synchronized text. It aggregates the actual text content, with the timestamp.</para>
    /// labels<para>SynchronizedTextElement</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedTextElement">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedTextElement</seealso>
    let SynchronizedTextElement =
        Prefixed_Name(nid3, "SynchronizedTextElement") |> PrefixedName

    /// <summary>
    ///   <para>nid3:beatsPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TBPM
    /// The 'BPM' frame contains the number of beats per minute in the mainpart of the audio. The BPM is an integer and represented as a numerical string.</para>
    /// labels<para>beatsPerMinute</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#beatsPerMinute">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#beatsPerMinute</seealso>
    let beatsPerMinute = Prefixed_Name(nid3, "beatsPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>nid3:commercialInformationURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WCOM
    /// The 'Commercial information' frame is a URL pointing at a webpage with information such as where the album can be bought. There may be more than one "WCOM" frame in a tag, but not with the same content.</para>
    /// labels<para>commercialInformationURL</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#commercialInformationURL">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#commercialInformationURL</seealso>
    let commercialInformationURL =
        Prefixed_Name(nid3, "commercialInformationURL") |> PrefixedName

    /// <summary>
    ///   <para>nid3:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TCOM
    /// The 'Composer(s)' frame is intended for the name of the composer(s). They are seperated with the "/" character.
    /// Note that in the RDF representation each composer is represented with a separate triple.</para>
    /// labels<para>composer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#composer">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#composer</seealso>
    let composer = Prefixed_Name(nid3, "composer") |> PrefixedName
    /// <summary>
    ///   <para>nid3:conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPE3
    /// The 'Conductor' frame is used for the name of the conductor.</para>
    /// labels<para>conductor</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#conductor">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#conductor</seealso>
    let conductor = Prefixed_Name(nid3, "conductor") |> PrefixedName
    /// <summary>
    ///   <para>nid3:albumTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TALB
    /// The 'Album/Movie/Show title' frame is intended for the title of the recording(/source of sound) which the audio in the file is taken from.</para>
    /// labels<para>albumTitle</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#albumTitle">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#albumTitle</seealso>
    let albumTitle = Prefixed_Name(nid3, "albumTitle") |> PrefixedName

    /// <summary>
    ///   <para>nid3:officialInternetRadioStationHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WORS
    /// The 'Official internet radio station homepage' contains a URL pointing at the homepage of the internet radio station.</para>
    /// labels<para>officialInternetRadioStationHomepage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialInternetRadioStationHomepage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialInternetRadioStationHomepage</seealso>
    let officialInternetRadioStationHomepage =
        Prefixed_Name(nid3, "officialInternetRadioStationHomepage") |> PrefixedName

    /// <summary>
    ///   <para>nid3:partOfSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPOS
    /// The 'Part of a set' frame is a numeric string that describes which part of a set the audio came from. This frame is used if the source described in the "TALB" frame is divided into several mediums, e.g. a double CD. The value may be extended with a "/" character and a numeric string containing the total number of parts in the set. E.g. "1/2".</para>
    /// labels<para>partOfSet</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#partOfSet">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#partOfSet</seealso>
    let partOfSet = Prefixed_Name(nid3, "partOfSet") |> PrefixedName
    /// <summary>
    ///   <para>nid3:recordingYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TYER
    /// The 'Year' frame is a numeric string with a year of the recording. This frames is always four characters long (until the year 10000).</para>
    /// labels<para>recordingYear</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingYear">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingYear</seealso>
    let recordingYear = Prefixed_Name(nid3, "recordingYear") |> PrefixedName
    /// <summary>
    ///   <para>nid3:textContentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Content type:
    /// $00     is other
    /// $01     is lyrics
    /// $02     is text transcription
    /// $03     is movement/part name (e.g. "Adagio")
    /// $04     is events (e.g. "Don Quijote enters the stage")
    /// $05     is chord (e.g. "Bb F Fsus")
    /// $06     is trivia/'pop up' information</para>
    /// labels<para>textContentType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textContentType">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textContentType</seealso>
    let textContentType = Prefixed_Name(nid3, "textContentType") |> PrefixedName
    /// <summary>
    ///   <para>nid3:textWriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TEXT
    /// The 'Lyricist(s)/Text writer(s)' frame is intended for the writer(s) of the text or lyrics in the recording. They are seperated with the "/" character.
    /// Note that in the RDF representation each text writer is represented with a separate triple.</para>
    /// labels<para>textWriter</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textWriter">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textWriter</seealso>
    let textWriter = Prefixed_Name(nid3, "textWriter") |> PrefixedName
    /// <summary>
    ///   <para>nid3:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TIT2
    /// The 'Title/Songname/Content description' frame is the actual name of the piece (e.g. "Adagio", "Hurricane Donna"). Deprecated in favor of the more generic nie:title.</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#title">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#title</seealso>
    let title = Prefixed_Name(nid3, "title") |> PrefixedName

    /// <summary>
    ///   <para>nid3:unsynchronizedTextContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Unsynchronized text content. Inspired by the content part of the USLT frame defined in the ID3 2.3.0 Spec sec. 4.9</para>
    /// labels<para>unsynchronizedTextContent</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContent">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContent</seealso>
    let unsynchronizedTextContent =
        Prefixed_Name(nid3, "unsynchronizedTextContent") |> PrefixedName

    /// <summary>
    ///   <para>nid3:userDefinedFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the ID3 file to a user-defined frame.</para>
    /// labels<para>userDefinedFrame</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrame">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrame</seealso>
    let userDefinedFrame = Prefixed_Name(nid3, "userDefinedFrame") |> PrefixedName

    /// <summary>
    ///   <para>nid3:uniqueFileIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This frame's purpose is to be able to identify the audio file in a database that may contain more information relevant to the content. Since standardisation of such a database is beyond this document, all frames begin with a null-terminated string with a URL containing an email address, or a link to a location where an email address can be found, that belongs to the organisation responsible for this specific database implementation. Questions regarding the database should be sent to the indicated email address. The URL should not be used for the actual database queries. The string "http://www.id3.org/dummy/ufid.html" should be used for tests. Software that isn't told otherwise may safely remove such frames. The 'Owner identifier' must be non-empty (more than just a termination). The 'Owner identifier' is then followed by the actual identifier, which may be up to 64 bytes. There may be more than one "UFID" frame in a tag, but only one with the same 'Owner identifier'.</para>
    /// labels<para>uniqueFileIdentifier</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#uniqueFileIdentifier">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#uniqueFileIdentifier</seealso>
    let uniqueFileIdentifier =
        Prefixed_Name(nid3, "uniqueFileIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>nid3:userDefinedFrameDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Description of a user-defined frame.</para>
    /// labels<para>userDefinedFrameDescription</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameDescription">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameDescription</seealso>
    let userDefinedFrameDescription =
        Prefixed_Name(nid3, "userDefinedFrameDescription") |> PrefixedName

    /// <summary>
    ///   <para>nid3:attachedPicture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A picture attached to an audio file. The DataObject refered to by this property is usually interpreted as an nfo:Image Inspired by the attached picture tag defined in http://www.id3.org/id3v2.3.0 sec. 4.15)</para>
    /// labels<para>attachedPicture</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#attachedPicture">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#attachedPicture</seealso>
    let attachedPicture = Prefixed_Name(nid3, "attachedPicture") |> PrefixedName
    /// <summary>
    ///   <para>nid3:backgroundArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPE2
    /// The 'Band/Orchestra/Accompaniment' frame is used for additional information about the performers in the recording.</para>
    /// labels<para>backgroundArtist</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#backgroundArtist">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#backgroundArtist</seealso>
    let backgroundArtist = Prefixed_Name(nid3, "backgroundArtist") |> PrefixedName
    /// <summary>
    ///   <para>nid3:comments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>COMM - This frame is indended for any kind of full text information that does not fit in any other frame. It consists of a frame header followed by encoding, language and content descriptors and is ended with the actual comment as a text string. Newline characters are allowed in the comment text string. There may be more than one comment frame in each tag, but only one with the same language and content descriptor. Deprecated in favor of the more generic nie:comment.</para>
    /// labels<para>comments</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#comments">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#comments</seealso>
    let comments = Prefixed_Name(nid3, "comments") |> PrefixedName
    /// <summary>
    ///   <para>nid3:audiofileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TSIZ
    /// The 'Size' frame contains the size of the audiofile in bytes, excluding the ID3v2 tag, represented as a numeric string.</para>
    /// labels<para>audiofileSize</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#audiofileSize">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#audiofileSize</seealso>
    let audiofileSize = Prefixed_Name(nid3, "audiofileSize") |> PrefixedName
    /// <summary>
    ///   <para>nid3:contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TCON
    ///
    /// The 'Content type', which previously was stored as a one byte numeric value only, is now a numeric string. You may use one or several of the types as ID3v1.1 did or, since the category list would be impossible to maintain with accurate and up to date categories, define your own.
    ///
    /// References to the ID3v1 genres can be made by, as first byte, enter "(" followed by a number from the genres list (appendix A) and ended with a ")" character. This is optionally followed by a refinement, e.g. "(21)" or "(4)Eurodisco". Several references can be made in the same frame, e.g. "(51)(39)". If the refinement should begin with a "(" character it should be replaced with "((", e.g. "((I can figure out any genre)" or "(55)((I think...)". The following new content types is defined in ID3v2 and is implemented in the same way as the numerig content types, e.g. "(RX)".
    /// RX    Remix
    /// CR    Cover</para>
    /// labels<para>contentType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentType">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentType</seealso>
    let contentType = Prefixed_Name(nid3, "contentType") |> PrefixedName
    /// <summary>
    ///   <para>nid3:encodingSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TSSE
    /// The 'Software/Hardware and settings used for encoding' frame includes the used audio encoder and its settings when the file was encoded. Hardware refers to hardware encoders, not the computer on which a program was run.</para>
    /// labels<para>encodingSettings</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodingSettings">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodingSettings</seealso>
    let encodingSettings = Prefixed_Name(nid3, "encodingSettings") |> PrefixedName
    /// <summary>
    ///   <para>nid3:fileType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TFLT
    /// The 'File type' frame indicates which type of audio this tag defines. The following type and refinements are defined:
    /// MPG MPEG Audio;
    /// /1 MPEG 1/2 layer I;
    /// /2 MPEG 1/2 layer II;
    /// /3 MPEG 1/2 layer III;
    /// /2.5 MPEG 2.5;
    /// /AAC Advanced audio compression;
    /// VQF Transform-domain Weighted Interleave Vector Quantization;
    /// PCM Pulse Code Modulated audio;</para>
    /// labels<para>fileType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileType">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileType</seealso>
    let fileType = Prefixed_Name(nid3, "fileType") |> PrefixedName

    /// <summary>
    ///   <para>nid3:hasSynchronizedTextElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the synchronized text object with the text elements.</para>
    /// labels<para>hasSynchronizedTextElement</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedTextElement">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedTextElement</seealso>
    let hasSynchronizedTextElement =
        Prefixed_Name(nid3, "hasSynchronizedTextElement") |> PrefixedName

    /// <summary>
    ///   <para>nid3:internetRadioStationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TRSN
    /// The 'Internet radio station name' frame contains the name of the internet radio station from which the audio is streamed.</para>
    /// labels<para>internetRadioStationName</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationName">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationName</seealso>
    let internetRadioStationName =
        Prefixed_Name(nid3, "internetRadioStationName") |> PrefixedName

    /// <summary>
    ///   <para>nid3:copyrightMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TCOP
    /// The 'Copyright message' frame, which must begin with a year and a space character (making five characters), is intended for the copyright holder of the original sound, not the audio file itself. The absence of this frame means only that the copyright information is unavailable or has been removed, and must not be interpreted to mean that the sound is public domain. Every time this field is displayed the field must be preceded with "Copyright".</para>
    /// labels<para>copyrightMessage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightMessage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightMessage</seealso>
    let copyrightMessage = Prefixed_Name(nid3, "copyrightMessage") |> PrefixedName
    /// <summary>
    ///   <para>nid3:encodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TENC
    /// The 'Encoded by' frame contains the name of the person or organisation that encoded the audio file. This field may contain a copyright message, if the audio file also is copyrighted by the encoder.
    /// Note that the RDF representation doesn't allow the copyright message in this field. Please move it to the copyrightMessage field.</para>
    /// labels<para>encodedBy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodedBy">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodedBy</seealso>
    let encodedBy = Prefixed_Name(nid3, "encodedBy") |> PrefixedName
    /// <summary>
    ///   <para>nid3:fileOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOWN
    /// The 'File owner/licensee' frame contains the name of the owner or licensee of the file and it's contents.</para>
    /// labels<para>fileOwner</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileOwner">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileOwner</seealso>
    let fileOwner = Prefixed_Name(nid3, "fileOwner") |> PrefixedName
    /// <summary>
    ///   <para>nid3:hasSynchronizedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the ID3Audio with an instance of SynchronizedText</para>
    /// labels<para>hasSynchronizedText</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedText">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedText</seealso>
    let hasSynchronizedText = Prefixed_Name(nid3, "hasSynchronizedText") |> PrefixedName
    /// <summary>
    ///   <para>nid3:initialKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TKEY
    /// The 'Initial key' frame contains the musical key in which the sound starts. It is represented as a string with a maximum length of three characters. The ground keys are represented with "A","B","C","D","E", "F" and "G" and halfkeys represented with "b" and "#". Minor is represented as "m". Example "Cbm". Off key is represented with an "o" only.</para>
    /// labels<para>initialKey</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#initialKey">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#initialKey</seealso>
    let initialKey = Prefixed_Name(nid3, "initialKey") |> PrefixedName

    /// <summary>
    ///   <para>nid3:internetRadioStationOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TRSO
    /// The 'Internet radio station owner' frame contains the name of the owner of the internet radio station from which the audio is streamed.</para>
    /// labels<para>internetRadioStationOwner</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationOwner">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationOwner</seealso>
    let internetRadioStationOwner =
        Prefixed_Name(nid3, "internetRadioStationOwner") |> PrefixedName

    /// <summary>
    ///   <para>nid3:generalEncapsulatedObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An arbitrary file embedded in an audio file. Inspired by http://www.id3.org/id3v2.3.0 sec.
    /// 4.16)</para>
    /// labels<para>generalEncapsulatedObject</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#generalEncapsulatedObject">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#generalEncapsulatedObject</seealso>
    let generalEncapsulatedObject =
        Prefixed_Name(nid3, "generalEncapsulatedObject") |> PrefixedName

    /// <summary>
    ///   <para>nid3:internationalStandardRecordingCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TSRC
    /// The 'ISRC' frame should contain the International Standard Recording Code (ISRC) (12 characters).</para>
    /// labels<para>internationalStandardRecordingCode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internationalStandardRecordingCode">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internationalStandardRecordingCode</seealso>
    let internationalStandardRecordingCode =
        Prefixed_Name(nid3, "internationalStandardRecordingCode") |> PrefixedName

    /// <summary>
    ///   <para>nid3:interpretedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPE4
    /// The 'Interpreted, remixed, or otherwise modified by' frame contains more information about the people behind a remix and similar interpretations of another existing piece.</para>
    /// labels<para>interpretedBy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#interpretedBy">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#interpretedBy</seealso>
    let interpretedBy = Prefixed_Name(nid3, "interpretedBy") |> PrefixedName
    /// <summary>
    ///   <para>nid3:involvedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links an ID3 file to an InvolvedPerson, an equivalent of the involvedPeopleList tag. Since there might be a lot of people contributing to an audio file in various ways, such as musicians and technicians, the 'Text information frames' are often insufficient to list everyone involved in a project. The 'Involved people list' is a frame containing the names of those involved, and how they were involved. The body simply contains a terminated string with the involvement directly followed by a terminated string with the involvee followed by a new involvement and so on. There may only be one "IPLS" frame in each tag.</para>
    /// labels<para>involvedPerson</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPerson">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPerson</seealso>
    let involvedPerson = Prefixed_Name(nid3, "involvedPerson") |> PrefixedName

    /// <summary>
    ///   <para>nid3:involvedPersonContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An actual contact to the involved person.</para>
    /// labels<para>involvedPersonContact</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPersonContact">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPersonContact</seealso>
    let involvedPersonContact =
        Prefixed_Name(nid3, "involvedPersonContact") |> PrefixedName

    /// <summary>
    ///   <para>nid3:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TLAN
    /// The 'Language(s)' frame should contain the languages of the text or lyrics spoken or sung in the audio. The language is represented with three characters according to ISO-639-2. If more than one language is used in the text their language codes should follow according to their usage. Deprecated in favor of the more generic nie:language.</para>
    /// labels<para>language</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#language">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#language</seealso>
    let language = Prefixed_Name(nid3, "language") |> PrefixedName
    /// <summary>
    ///   <para>nid3:involvment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>How was this particular person involved in this particular track.</para>
    /// labels<para>involvment</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvment">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvment</seealso>
    let involvment = Prefixed_Name(nid3, "involvment") |> PrefixedName
    /// <summary>
    ///   <para>nid3:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TMED
    /// The 'Media type' frame describes from which media the sound originated. This may be a text string or a reference to the predefined media types found in the list below. References are made within "(" and ")" and are optionally followed by a text refinement, e.g. "(MC) with four channels". If a text refinement should begin with a "(" character it should be replaced with "((" in the same way as in the "TCO" frame. Predefined refinements is appended after the media type, e.g. "(CD/A)" or "(VID/PAL/VHS)".
    /// See http://www.id3.org/id3v2.3.0 for details.</para>
    /// labels<para>mediaType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#mediaType">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#mediaType</seealso>
    let mediaType = Prefixed_Name(nid3, "mediaType") |> PrefixedName

    /// <summary>
    ///   <para>nid3:officialArtistWebpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>officialArtistWebpage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialArtistWebpage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialArtistWebpage</seealso>
    let officialArtistWebpage =
        Prefixed_Name(nid3, "officialArtistWebpage") |> PrefixedName

    /// <summary>
    ///   <para>nid3:officialFileWebpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WOAF
    /// The 'Official audio file webpage' frame is a URL pointing at a file specific webpage.</para>
    /// labels<para>officialFileWebpage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialFileWebpage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialFileWebpage</seealso>
    let officialFileWebpage = Prefixed_Name(nid3, "officialFileWebpage") |> PrefixedName
    /// <summary>
    ///   <para>nid3:originalArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOPE
    /// The 'Original artist(s)/performer(s)' frame is intended for the performer(s) of the original recording, if for example the music in the file should be a cover of a previously released song. The performers are seperated with the "/" character.
    /// Note that in the RDF repressentation each orignal artist is represented with a separate triple.</para>
    /// labels<para>originalArtist</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalArtist">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalArtist</seealso>
    let originalArtist = Prefixed_Name(nid3, "originalArtist") |> PrefixedName
    /// <summary>
    ///   <para>nid3:originalReleaseYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TORY
    /// The 'Original release year' frame is intended for the year when the original recording, if for example the music in the file should be a cover of a previously released song, was released. The field is formatted as in the "TYER" frame.</para>
    /// labels<para>originalReleaseYear</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalReleaseYear">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalReleaseYear</seealso>
    let originalReleaseYear = Prefixed_Name(nid3, "originalReleaseYear") |> PrefixedName
    /// <summary>
    ///   <para>nid3:publishersWebpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WPUB
    /// The 'Publishers official webpage' frame is a URL pointing at the official wepage for the publisher.</para>
    /// labels<para>publishersWebpage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publishersWebpage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publishersWebpage</seealso>
    let publishersWebpage = Prefixed_Name(nid3, "publishersWebpage") |> PrefixedName
    /// <summary>
    ///   <para>nid3:playlistDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TDLY
    /// The 'Playlist delay' defines the numbers of milliseconds of silence between every song in a playlist. The player should use the "ETC" frame, if present, to skip initial silence and silence at the end of the audio to match the 'Playlist delay' time. The time is represented as a numeric string.</para>
    /// labels<para>playlistDelay</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#playlistDelay">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#playlistDelay</seealso>
    let playlistDelay = Prefixed_Name(nid3, "playlistDelay") |> PrefixedName

    /// <summary>
    ///   <para>nid3:synchronizedTextContentDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Synchronized text content descriptor. Inspired by the content descriptor part of the SYLT frame defined in ID3 2.3.0 spec sec. 4.10</para>
    /// labels<para>synchronizedTextContentDescriptor</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#synchronizedTextContentDescriptor">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#synchronizedTextContentDescriptor</seealso>
    let synchronizedTextContentDescriptor =
        Prefixed_Name(nid3, "synchronizedTextContentDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>nid3:textElementTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The 'time stamp' is set to zero or the whole sync is omitted if located directly at the beginning of the sound. All time stamps should be sorted in chronological order. The sync can be considered as a validator of the subsequent string.</para>
    /// labels<para>textElementTimestamp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementTimestamp">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementTimestamp</seealso>
    let textElementTimestamp =
        Prefixed_Name(nid3, "textElementTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>nid3:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TIME
    /// The 'Time' frame is a numeric string in the HHMM format containing the time for the recording. This field is always four characters long.</para>
    /// labels<para>time</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#time">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#time</seealso>
    let time = Prefixed_Name(nid3, "time") |> PrefixedName
    /// <summary>
    ///   <para>nid3:timestampFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Time stamp format is:
    /// $01 Absolute time, 32 bit sized, using MPEG frames as unit
    /// $02 Absolute time, 32 bit sized, using milliseconds as unit</para>
    /// labels<para>timestampFormat</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#timestampFormat">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#timestampFormat</seealso>
    let timestampFormat = Prefixed_Name(nid3, "timestampFormat") |> PrefixedName
    /// <summary>
    ///   <para>nid3:trackNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TRCK
    /// The 'Track number/Position in set' frame is a numeric string containing the order number of the audio-file on its original recording. This may be extended with a "/" character and a numeric string containing the total numer of tracks/elements on the original recording. E.g. "4/9".</para>
    /// labels<para>trackNumber</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#trackNumber">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#trackNumber</seealso>
    let trackNumber = Prefixed_Name(nid3, "trackNumber") |> PrefixedName

    /// <summary>
    ///   <para>nid3:unsynchronizedTextContentDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The content descriptor of the unsynchronized text. Inspired by the Content Descriptor field of the USLT frame, defined in ID3 2.3.0 Spec sec. 4.9</para>
    /// labels<para>unsynchronizedTextContentDescriptor</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContentDescriptor">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContentDescriptor</seealso>
    let unsynchronizedTextContentDescriptor =
        Prefixed_Name(nid3, "unsynchronizedTextContentDescriptor") |> PrefixedName

    /// <summary>
    ///   <para>nid3:userDefinedFrameValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Value of a user-defined frame.</para>
    /// labels<para>userDefinedFrameValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameValue</seealso>
    let userDefinedFrameValue =
        Prefixed_Name(nid3, "userDefinedFrameValue") |> PrefixedName

    /// <summary>
    ///   <para>nid3:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TIT3
    /// The 'Subtitle/Description refinement' frame is used for information directly related to the contents title (e.g. "Op. 16" or "Performed live at Wembley").</para>
    /// labels<para>subtitle</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#subtitle">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#subtitle</seealso>
    let subtitle = Prefixed_Name(nid3, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>nid3:textElementContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>textElementContent</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementContent">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementContent</seealso>
    let textElementContent = Prefixed_Name(nid3, "textElementContent") |> PrefixedName
    /// <summary>
    ///   <para>nid3:ID3Audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A File annotated with ID3 tags. Implementation notes: use nie:title for the actual name of the piece (TIT2, the 'Title/Songname/Content description' frame); use nie:language for the languages of the text or lyrics spoken or sung in the audio (TLAN, the 'Language(s)' frame); use nie:comment for any kind of full text information that does not fit in any other frame (COMM frame).</para>
    /// labels<para>ID3Audio</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#ID3Audio">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#ID3Audio</seealso>
    let ID3Audio = Prefixed_Name(nid3, "ID3Audio") |> PrefixedName
    /// <summary>
    ///   <para>nid3:UserDefinedURLFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>This frame is intended for URL links concerning the audiofile in a similar way to the other "W"-frames. The frame body consists of a description of the string, represented as a terminated string, followed by the actual URL. The URL is always encoded with ISO-8859-1. There may be more than one "WXXX" frame in each tag, but only one with the same description.</para>
    /// labels<para>UserDefinedURLFrame</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedURLFrame">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedURLFrame</seealso>
    let UserDefinedURLFrame = Prefixed_Name(nid3, "UserDefinedURLFrame") |> PrefixedName
    /// <summary>
    ///   <para>nid3:leadArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPE1
    /// The 'Lead artist(s)/Lead performer(s)/Soloist(s)/Performing group' is used for the main artist(s). They are seperated with the "/" character.</para>
    /// labels<para>leadArtist</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#leadArtist">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#leadArtist</seealso>
    let leadArtist = Prefixed_Name(nid3, "leadArtist") |> PrefixedName
    /// <summary>
    ///   <para>nid3:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TLEN
    /// The 'Length' frame contains the length of the audiofile in milliseconds, represented as a numeric string.</para>
    /// labels<para>length</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#length">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#length</seealso>
    let length = Prefixed_Name(nid3, "length") |> PrefixedName
    /// <summary>
    ///   <para>nid3:licensee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOWN
    /// The 'File owner/licensee' frame contains the name of the owner or licensee of the file and it's contents.</para>
    /// labels<para>licensee</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#licensee">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#licensee</seealso>
    let licensee = Prefixed_Name(nid3, "licensee") |> PrefixedName
    /// <summary>
    ///   <para>nid3:musicCDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This frame is intended for music that comes from a CD, so that the CD can be identified in databases such as the CDDB. The frame consists of a binary dump of the Table Of Contents, TOC, from the CD, which is a header of 4 bytes and then 8 bytes/track on the CD plus 8 bytes for the 'lead out' making a maximum of 804 bytes. The offset to the beginning of every track on the CD should be described with a four bytes absolute CD-frame address per track, and not with absolute time. This frame requires a present and valid "TRCK" frame, even if the CD's only got one track. There may only be one "MCDI" frame in each tag.</para>
    /// labels<para>musicCDIdentifier</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#musicCDIdentifier">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#musicCDIdentifier</seealso>
    let musicCDIdentifier = Prefixed_Name(nid3, "musicCDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>nid3:officialAudioSourceWebpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WOAS
    /// The 'Official audio source webpage' frame is a URL pointing at the official webpage for the source of the audio file, e.g. a movie.</para>
    /// labels<para>officialAudioSourceWebpage</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialAudioSourceWebpage">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialAudioSourceWebpage</seealso>
    let officialAudioSourceWebpage =
        Prefixed_Name(nid3, "officialAudioSourceWebpage") |> PrefixedName

    /// <summary>
    ///   <para>nid3:originalAlbumTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOAL
    /// The 'Original album/movie/show title' frame is intended for the title of the original recording (or source of sound), if for example the music in the file should be a cover of a previously released song.</para>
    /// labels<para>originalAlbumTitle</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalAlbumTitle">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalAlbumTitle</seealso>
    let originalAlbumTitle = Prefixed_Name(nid3, "originalAlbumTitle") |> PrefixedName
    /// <summary>
    ///   <para>nid3:originalFilename</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOFN
    /// The 'Original filename' frame contains the preferred filename for the file, since some media doesn't allow the desired length of the filename. The filename is case sensitive and includes its suffix.</para>
    /// labels<para>originalFilename</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalFilename">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalFilename</seealso>
    let originalFilename = Prefixed_Name(nid3, "originalFilename") |> PrefixedName
    /// <summary>
    ///   <para>nid3:originalTextWriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TOLY
    /// The 'Original lyricist(s)/text writer(s)' frame is intended for the text writer(s) of the original recording, if for example the music in the file should be a cover of a previously released song. The text writers are seperated with the "/" character.
    /// Note that in the RDF representation each original lyricist is represented with a separate triple.</para>
    /// labels<para>originalTextWriter</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalTextWriter">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalTextWriter</seealso>
    let originalTextWriter = Prefixed_Name(nid3, "originalTextWriter") |> PrefixedName
    /// <summary>
    ///   <para>nid3:paymentURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>WPAY
    /// The 'Payment' frame is a URL pointing at a webpage that will handle the process of paying for this file.</para>
    /// labels<para>paymentURL</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#paymentURL">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#paymentURL</seealso>
    let paymentURL = Prefixed_Name(nid3, "paymentURL") |> PrefixedName
    /// <summary>
    ///   <para>nid3:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TPUB
    /// The 'Publisher' frame simply contains the name of the label or publisher.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publisher">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publisher</seealso>
    let publisher = Prefixed_Name(nid3, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>nid3:recordingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>TRDA
    /// The 'Recording dates' frame is a intended to be used as complement to the "TYER", "TDAT" and "TIME" frames. E.g. "4th-7th June, 12th June" in combination with the "TYER" frame.</para>
    /// labels<para>recordingDate</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingDate">http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingDate</seealso>
    let recordingDate = Prefixed_Name(nid3, "recordingDate") |> PrefixedName

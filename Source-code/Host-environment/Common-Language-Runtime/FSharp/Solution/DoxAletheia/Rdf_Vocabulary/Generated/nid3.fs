namespace http.www.semanticdesktop.org.ontologies._2007._05._10.nid3.hash

open DoxAletheia

module nid3 =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A File annotated with ID3 tags. Implementation notes: use nie:title for the actual name of the piece (TIT2, the 'Title/Songname/Content description' frame); use nie:language for the languages of the text or lyrics spoken or sung in the audio (TLAN, the 'Language(s)' frame); use nie:comment for any kind of full text information that does not fit in any other frame (COMM frame).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#ID3Audio"></see></summary>
    let ID3Audio = _prefix "ID3Audio"
    /// <summary>
    /// Since there might be a lot of people contributing to an audio file in various ways, such as musicians and technicians, the 'Text information frames' are often insufficient to list everyone involved in a project. The 'Involved people list' is a frame containing the names of those involved, and how they were involved. The body simply contains a terminated string with the involvement directly followed by a terminated string with the involvee followed by a new involvement and so on. There may only be one "IPLS" frame in each tag.
    /// Note that in this RDF representation each InvolvedPerson is represented with a separate instance of the InvolvedPerson class and with a separate involvedPerson triple.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#InvolvedPerson"></see></summary>
    let InvolvedPerson = _prefix "InvolvedPerson"
    /// <summary>
    /// SYLT This is another way of incorporating the words, said or sung lyrics, in the audio file as text, this time, however, in sync with the audio. It might also be used to describing events e.g. occurring on a stage or on the screen in sync with the audio. The header includes a content descriptor, represented with as terminated textstring. If no descriptor is entered, 'Content descriptor' is $00 (00) only.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedText"></see></summary>
    let SynchronizedText = _prefix "SynchronizedText"
    /// <summary>
    /// An element of the synchronized text. It aggregates the actual text content, with the timestamp.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#SynchronizedTextElement"></see></summary>
    let SynchronizedTextElement = _prefix "SynchronizedTextElement"
    /// <summary>
    /// This frame is intended for one-string text information concerning the audiofile in a similar way to the other "T"-frames. The frame body consists of a description of the string, represented as a terminated string, followed by the actual string. There may be more than one "TXXX" frame in each tag, but only one with the same description.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedFrame"></see></summary>
    let UserDefinedFrame = _prefix "UserDefinedFrame"
    /// <summary>
    /// This frame is intended for URL links concerning the audiofile in a similar way to the other "W"-frames. The frame body consists of a description of the string, represented as a terminated string, followed by the actual URL. The URL is always encoded with ISO-8859-1. There may be more than one "WXXX" frame in each tag, but only one with the same description.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#UserDefinedURLFrame"></see></summary>
    let UserDefinedURLFrame = _prefix "UserDefinedURLFrame"
    /// <summary>
    /// TALB
    /// The 'Album/Movie/Show title' frame is intended for the title of the recording(/source of sound) which the audio in the file is taken from.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#albumTitle"></see></summary>
    let albumTitle = _prefix "albumTitle"
    /// <summary>
    /// A picture attached to an audio file. The DataObject refered to by this property is usually interpreted as an nfo:Image Inspired by the attached picture tag defined in http://www.id3.org/id3v2.3.0 sec. 4.15)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#attachedPicture"></see></summary>
    let attachedPicture = _prefix "attachedPicture"
    /// <summary>
    /// TSIZ
    /// The 'Size' frame contains the size of the audiofile in bytes, excluding the ID3v2 tag, represented as a numeric string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#audiofileSize"></see></summary>
    let audiofileSize = _prefix "audiofileSize"
    /// <summary>
    /// TPE2
    /// The 'Band/Orchestra/Accompaniment' frame is used for additional information about the performers in the recording.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#backgroundArtist"></see></summary>
    let backgroundArtist = _prefix "backgroundArtist"
    /// <summary>
    /// TBPM
    /// The 'BPM' frame contains the number of beats per minute in the mainpart of the audio. The BPM is an integer and represented as a numerical string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#beatsPerMinute"></see></summary>
    let beatsPerMinute = _prefix "beatsPerMinute"
    /// <summary>
    /// COMM - This frame is indended for any kind of full text information that does not fit in any other frame. It consists of a frame header followed by encoding, language and content descriptors and is ended with the actual comment as a text string. Newline characters are allowed in the comment text string. There may be more than one comment frame in each tag, but only one with the same language and content descriptor. Deprecated in favor of the more generic nie:comment.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#comments"></see></summary>
    let comments = _prefix "comments"
    /// <summary>
    /// WCOM
    /// The 'Commercial information' frame is a URL pointing at a webpage with information such as where the album can be bought. There may be more than one "WCOM" frame in a tag, but not with the same content.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#commercialInformationURL"></see></summary>
    let commercialInformationURL = _prefix "commercialInformationURL"
    /// <summary>
    /// TCOM
    /// The 'Composer(s)' frame is intended for the name of the composer(s). They are seperated with the "/" character.
    /// Note that in the RDF representation each composer is represented with a separate triple.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// TPE3
    /// The 'Conductor' frame is used for the name of the conductor.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#conductor"></see></summary>
    let conductor = _prefix "conductor"
    /// <summary>
    /// TIT1
    /// The 'Content group description' frame is used if the sound belongs to a larger category of sounds/music. For example, classical music is often sorted in different musical sections (e.g. "Piano Concerto", "Weather - Hurricane").
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentGroupDescription"></see></summary>
    let contentGroupDescription = _prefix "contentGroupDescription"
    /// <summary>
    /// TCON
    ///
    /// The 'Content type', which previously was stored as a one byte numeric value only, is now a numeric string. You may use one or several of the types as ID3v1.1 did or, since the category list would be impossible to maintain with accurate and up to date categories, define your own.
    ///
    /// References to the ID3v1 genres can be made by, as first byte, enter "(" followed by a number from the genres list (appendix A) and ended with a ")" character. This is optionally followed by a refinement, e.g. "(21)" or "(4)Eurodisco". Several references can be made in the same frame, e.g. "(51)(39)". If the refinement should begin with a "(" character it should be replaced with "((", e.g. "((I can figure out any genre)" or "(55)((I think...)". The following new content types is defined in ID3v2 and is implemented in the same way as the numerig content types, e.g. "(RX)".
    /// RX    Remix
    /// CR    Cover
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#contentType"></see></summary>
    let contentType = _prefix "contentType"
    /// <summary>
    /// WCOP
    /// The 'Copyright/Legal information' frame is a URL pointing at a webpage where the terms of use and ownership of the file is described.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightInformationURL"></see></summary>
    let copyrightInformationURL = _prefix "copyrightInformationURL"
    /// <summary>
    /// TCOP
    /// The 'Copyright message' frame, which must begin with a year and a space character (making five characters), is intended for the copyright holder of the original sound, not the audio file itself. The absence of this frame means only that the copyright information is unavailable or has been removed, and must not be interpreted to mean that the sound is public domain. Every time this field is displayed the field must be preceded with "Copyright".
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#copyrightMessage"></see></summary>
    let copyrightMessage = _prefix "copyrightMessage"
    /// <summary>
    /// TDAT
    /// The 'Date' frame is a numeric string in the DDMM format containing the date for the recording. This field is always four characters long.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// TENC
    /// The 'Encoded by' frame contains the name of the person or organisation that encoded the audio file. This field may contain a copyright message, if the audio file also is copyrighted by the encoder.
    /// Note that the RDF representation doesn't allow the copyright message in this field. Please move it to the copyrightMessage field.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodedBy"></see></summary>
    let encodedBy = _prefix "encodedBy"
    /// <summary>
    /// TSSE
    /// The 'Software/Hardware and settings used for encoding' frame includes the used audio encoder and its settings when the file was encoded. Hardware refers to hardware encoders, not the computer on which a program was run.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#encodingSettings"></see></summary>
    let encodingSettings = _prefix "encodingSettings"
    /// <summary>
    /// TOWN
    /// The 'File owner/licensee' frame contains the name of the owner or licensee of the file and it's contents.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileOwner"></see></summary>
    let fileOwner = _prefix "fileOwner"
    /// <summary>
    /// TFLT
    /// The 'File type' frame indicates which type of audio this tag defines. The following type and refinements are defined:
    /// MPG MPEG Audio;
    /// /1 MPEG 1/2 layer I;
    /// /2 MPEG 1/2 layer II;
    /// /3 MPEG 1/2 layer III;
    /// /2.5 MPEG 2.5;
    /// /AAC Advanced audio compression;
    /// VQF Transform-domain Weighted Interleave Vector Quantization;
    /// PCM Pulse Code Modulated audio;
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#fileType"></see></summary>
    let fileType = _prefix "fileType"
    /// <summary>
    /// An arbitrary file embedded in an audio file. Inspired by http://www.id3.org/id3v2.3.0 sec.
    /// 4.16)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#generalEncapsulatedObject"></see></summary>
    let generalEncapsulatedObject = _prefix "generalEncapsulatedObject"
    /// <summary>
    /// Links the ID3Audio with an instance of SynchronizedText
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedText"></see></summary>
    let hasSynchronizedText = _prefix "hasSynchronizedText"
    /// <summary>
    /// Links the synchronized text object with the text elements.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#hasSynchronizedTextElement"></see></summary>
    let hasSynchronizedTextElement = _prefix "hasSynchronizedTextElement"
    /// <summary>
    /// TKEY
    /// The 'Initial key' frame contains the musical key in which the sound starts. It is represented as a string with a maximum length of three characters. The ground keys are represented with "A","B","C","D","E", "F" and "G" and halfkeys represented with "b" and "#". Minor is represented as "m". Example "Cbm". Off key is represented with an "o" only.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#initialKey"></see></summary>
    let initialKey = _prefix "initialKey"

    /// <summary>
    /// TSRC
    /// The 'ISRC' frame should contain the International Standard Recording Code (ISRC) (12 characters).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internationalStandardRecordingCode"></see></summary>
    let internationalStandardRecordingCode =
        _prefix "internationalStandardRecordingCode"

    /// <summary>
    /// TRSN
    /// The 'Internet radio station name' frame contains the name of the internet radio station from which the audio is streamed.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationName"></see></summary>
    let internetRadioStationName = _prefix "internetRadioStationName"
    /// <summary>
    /// TRSO
    /// The 'Internet radio station owner' frame contains the name of the owner of the internet radio station from which the audio is streamed.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#internetRadioStationOwner"></see></summary>
    let internetRadioStationOwner = _prefix "internetRadioStationOwner"
    /// <summary>
    /// TPE4
    /// The 'Interpreted, remixed, or otherwise modified by' frame contains more information about the people behind a remix and similar interpretations of another existing piece.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#interpretedBy"></see></summary>
    let interpretedBy = _prefix "interpretedBy"
    /// <summary>
    /// Links an ID3 file to an InvolvedPerson, an equivalent of the involvedPeopleList tag. Since there might be a lot of people contributing to an audio file in various ways, such as musicians and technicians, the 'Text information frames' are often insufficient to list everyone involved in a project. The 'Involved people list' is a frame containing the names of those involved, and how they were involved. The body simply contains a terminated string with the involvement directly followed by a terminated string with the involvee followed by a new involvement and so on. There may only be one "IPLS" frame in each tag.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPerson"></see></summary>
    let involvedPerson = _prefix "involvedPerson"
    /// <summary>
    /// An actual contact to the involved person.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvedPersonContact"></see></summary>
    let involvedPersonContact = _prefix "involvedPersonContact"
    /// <summary>
    /// How was this particular person involved in this particular track.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#involvment"></see></summary>
    let involvment = _prefix "involvment"
    /// <summary>
    /// TLAN
    /// The 'Language(s)' frame should contain the languages of the text or lyrics spoken or sung in the audio. The language is represented with three characters according to ISO-639-2. If more than one language is used in the text their language codes should follow according to their usage. Deprecated in favor of the more generic nie:language.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// TPE1
    /// The 'Lead artist(s)/Lead performer(s)/Soloist(s)/Performing group' is used for the main artist(s). They are seperated with the "/" character.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#leadArtist"></see></summary>
    let leadArtist = _prefix "leadArtist"
    /// <summary>
    /// TLEN
    /// The 'Length' frame contains the length of the audiofile in milliseconds, represented as a numeric string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// TOWN
    /// The 'File owner/licensee' frame contains the name of the owner or licensee of the file and it's contents.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#licensee"></see></summary>
    let licensee = _prefix "licensee"
    /// <summary>
    /// TMED
    /// The 'Media type' frame describes from which media the sound originated. This may be a text string or a reference to the predefined media types found in the list below. References are made within "(" and ")" and are optionally followed by a text refinement, e.g. "(MC) with four channels". If a text refinement should begin with a "(" character it should be replaced with "((" in the same way as in the "TCO" frame. Predefined refinements is appended after the media type, e.g. "(CD/A)" or "(VID/PAL/VHS)".
    /// See http://www.id3.org/id3v2.3.0 for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    /// This frame is intended for music that comes from a CD, so that the CD can be identified in databases such as the CDDB. The frame consists of a binary dump of the Table Of Contents, TOC, from the CD, which is a header of 4 bytes and then 8 bytes/track on the CD plus 8 bytes for the 'lead out' making a maximum of 804 bytes. The offset to the beginning of every track on the CD should be described with a four bytes absolute CD-frame address per track, and not with absolute time. This frame requires a present and valid "TRCK" frame, even if the CD's only got one track. There may only be one "MCDI" frame in each tag.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#musicCDIdentifier"></see></summary>
    let musicCDIdentifier = _prefix "musicCDIdentifier"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialArtistWebpage"></see>
    /// </summary>
    let officialArtistWebpage = _prefix "officialArtistWebpage"
    /// <summary>
    /// WOAS
    /// The 'Official audio source webpage' frame is a URL pointing at the official webpage for the source of the audio file, e.g. a movie.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialAudioSourceWebpage"></see></summary>
    let officialAudioSourceWebpage = _prefix "officialAudioSourceWebpage"
    /// <summary>
    /// WOAF
    /// The 'Official audio file webpage' frame is a URL pointing at a file specific webpage.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialFileWebpage"></see></summary>
    let officialFileWebpage = _prefix "officialFileWebpage"

    /// <summary>
    /// WORS
    /// The 'Official internet radio station homepage' contains a URL pointing at the homepage of the internet radio station.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#officialInternetRadioStationHomepage"></see></summary>
    let officialInternetRadioStationHomepage =
        _prefix "officialInternetRadioStationHomepage"

    /// <summary>
    /// TOAL
    /// The 'Original album/movie/show title' frame is intended for the title of the original recording (or source of sound), if for example the music in the file should be a cover of a previously released song.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalAlbumTitle"></see></summary>
    let originalAlbumTitle = _prefix "originalAlbumTitle"
    /// <summary>
    /// TOPE
    /// The 'Original artist(s)/performer(s)' frame is intended for the performer(s) of the original recording, if for example the music in the file should be a cover of a previously released song. The performers are seperated with the "/" character.
    /// Note that in the RDF repressentation each orignal artist is represented with a separate triple.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalArtist"></see></summary>
    let originalArtist = _prefix "originalArtist"
    /// <summary>
    /// TOFN
    /// The 'Original filename' frame contains the preferred filename for the file, since some media doesn't allow the desired length of the filename. The filename is case sensitive and includes its suffix.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalFilename"></see></summary>
    let originalFilename = _prefix "originalFilename"
    /// <summary>
    /// TORY
    /// The 'Original release year' frame is intended for the year when the original recording, if for example the music in the file should be a cover of a previously released song, was released. The field is formatted as in the "TYER" frame.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalReleaseYear"></see></summary>
    let originalReleaseYear = _prefix "originalReleaseYear"
    /// <summary>
    /// TOLY
    /// The 'Original lyricist(s)/text writer(s)' frame is intended for the text writer(s) of the original recording, if for example the music in the file should be a cover of a previously released song. The text writers are seperated with the "/" character.
    /// Note that in the RDF representation each original lyricist is represented with a separate triple.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#originalTextWriter"></see></summary>
    let originalTextWriter = _prefix "originalTextWriter"
    /// <summary>
    /// TPOS
    /// The 'Part of a set' frame is a numeric string that describes which part of a set the audio came from. This frame is used if the source described in the "TALB" frame is divided into several mediums, e.g. a double CD. The value may be extended with a "/" character and a numeric string containing the total number of parts in the set. E.g. "1/2".
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#partOfSet"></see></summary>
    let partOfSet = _prefix "partOfSet"
    /// <summary>
    /// WPAY
    /// The 'Payment' frame is a URL pointing at a webpage that will handle the process of paying for this file.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#paymentURL"></see></summary>
    let paymentURL = _prefix "paymentURL"
    /// <summary>
    /// TDLY
    /// The 'Playlist delay' defines the numbers of milliseconds of silence between every song in a playlist. The player should use the "ETC" frame, if present, to skip initial silence and silence at the end of the audio to match the 'Playlist delay' time. The time is represented as a numeric string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#playlistDelay"></see></summary>
    let playlistDelay = _prefix "playlistDelay"
    /// <summary>
    /// TPUB
    /// The 'Publisher' frame simply contains the name of the label or publisher.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// WPUB
    /// The 'Publishers official webpage' frame is a URL pointing at the official wepage for the publisher.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#publishersWebpage"></see></summary>
    let publishersWebpage = _prefix "publishersWebpage"
    /// <summary>
    /// TRDA
    /// The 'Recording dates' frame is a intended to be used as complement to the "TYER", "TDAT" and "TIME" frames. E.g. "4th-7th June, 12th June" in combination with the "TYER" frame.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingDate"></see></summary>
    let recordingDate = _prefix "recordingDate"
    /// <summary>
    /// TYER
    /// The 'Year' frame is a numeric string with a year of the recording. This frames is always four characters long (until the year 10000).
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#recordingYear"></see></summary>
    let recordingYear = _prefix "recordingYear"
    /// <summary>
    /// TIT3
    /// The 'Subtitle/Description refinement' frame is used for information directly related to the contents title (e.g. "Op. 16" or "Performed live at Wembley").
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// Synchronized text content descriptor. Inspired by the content descriptor part of the SYLT frame defined in ID3 2.3.0 spec sec. 4.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#synchronizedTextContentDescriptor"></see></summary>
    let synchronizedTextContentDescriptor = _prefix "synchronizedTextContentDescriptor"
    /// <summary>
    /// Content type:
    /// $00     is other
    /// $01     is lyrics
    /// $02     is text transcription
    /// $03     is movement/part name (e.g. "Adagio")
    /// $04     is events (e.g. "Don Quijote enters the stage")
    /// $05     is chord (e.g. "Bb F Fsus")
    /// $06     is trivia/'pop up' information
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textContentType"></see></summary>
    let textContentType = _prefix "textContentType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementContent"></see>
    /// </summary>
    let textElementContent = _prefix "textElementContent"
    /// <summary>
    /// The 'time stamp' is set to zero or the whole sync is omitted if located directly at the beginning of the sound. All time stamps should be sorted in chronological order. The sync can be considered as a validator of the subsequent string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textElementTimestamp"></see></summary>
    let textElementTimestamp = _prefix "textElementTimestamp"
    /// <summary>
    /// TEXT
    /// The 'Lyricist(s)/Text writer(s)' frame is intended for the writer(s) of the text or lyrics in the recording. They are seperated with the "/" character.
    /// Note that in the RDF representation each text writer is represented with a separate triple.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#textWriter"></see></summary>
    let textWriter = _prefix "textWriter"
    /// <summary>
    /// TIME
    /// The 'Time' frame is a numeric string in the HHMM format containing the time for the recording. This field is always four characters long.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    /// Time stamp format is:
    /// $01 Absolute time, 32 bit sized, using MPEG frames as unit
    /// $02 Absolute time, 32 bit sized, using milliseconds as unit
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#timestampFormat"></see></summary>
    let timestampFormat = _prefix "timestampFormat"
    /// <summary>
    /// TIT2
    /// The 'Title/Songname/Content description' frame is the actual name of the piece (e.g. "Adagio", "Hurricane Donna"). Deprecated in favor of the more generic nie:title.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// TRCK
    /// The 'Track number/Position in set' frame is a numeric string containing the order number of the audio-file on its original recording. This may be extended with a "/" character and a numeric string containing the total numer of tracks/elements on the original recording. E.g. "4/9".
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#trackNumber"></see></summary>
    let trackNumber = _prefix "trackNumber"
    /// <summary>
    /// This frame's purpose is to be able to identify the audio file in a database that may contain more information relevant to the content. Since standardisation of such a database is beyond this document, all frames begin with a null-terminated string with a URL containing an email address, or a link to a location where an email address can be found, that belongs to the organisation responsible for this specific database implementation. Questions regarding the database should be sent to the indicated email address. The URL should not be used for the actual database queries. The string "http://www.id3.org/dummy/ufid.html" should be used for tests. Software that isn't told otherwise may safely remove such frames. The 'Owner identifier' must be non-empty (more than just a termination). The 'Owner identifier' is then followed by the actual identifier, which may be up to 64 bytes. There may be more than one "UFID" frame in a tag, but only one with the same 'Owner identifier'.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#uniqueFileIdentifier"></see></summary>
    let uniqueFileIdentifier = _prefix "uniqueFileIdentifier"
    /// <summary>
    /// Unsynchronized text content. Inspired by the content part of the USLT frame defined in the ID3 2.3.0 Spec sec. 4.9
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContent"></see></summary>
    let unsynchronizedTextContent = _prefix "unsynchronizedTextContent"

    /// <summary>
    /// The content descriptor of the unsynchronized text. Inspired by the Content Descriptor field of the USLT frame, defined in ID3 2.3.0 Spec sec. 4.9
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#unsynchronizedTextContentDescriptor"></see></summary>
    let unsynchronizedTextContentDescriptor =
        _prefix "unsynchronizedTextContentDescriptor"

    /// <summary>
    /// Links the ID3 file to a user-defined frame.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrame"></see></summary>
    let userDefinedFrame = _prefix "userDefinedFrame"
    /// <summary>
    /// Description of a user-defined frame.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameDescription"></see></summary>
    let userDefinedFrameDescription = _prefix "userDefinedFrameDescription"
    /// <summary>
    /// Value of a user-defined frame.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/05/10/nid3#userDefinedFrameValue"></see></summary>
    let userDefinedFrameValue = _prefix "userDefinedFrameValue"

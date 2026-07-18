namespace http.www.ebusiness_unibw.org.ontologies.consumerelectronics.v1.hash

open DoxAletheia.Rdf_Vocabulary

module ceo =
    let _namespace_name =
        "http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#"

    /// <summary>
    /// Format of the german institute for standardization: 841 x 1189 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A0"></see></summary>
    let A0 = Namespaced_IRI.parse _namespace_name "A0" |> NamespacedName

    /// <summary>
    /// Describes to which product categories the property or concept belongs (comma seperated, e.g. "MP3Player, TV").
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#belongsToModule"></see></summary>
    let belongsToModule =
        Namespaced_IRI.parse _namespace_name "belongsToModule" |> NamespacedName

    /// <summary>
    /// Sizes and shapes of the paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormat"></see></summary>
    let MediaFormat =
        Namespaced_IRI.parse _namespace_name "MediaFormat" |> NamespacedName

    /// <summary>
    /// Format of the german institute for standardization: 594 x 841 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A1"></see></summary>
    let A1 = Namespaced_IRI.parse _namespace_name "A1" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 420 x 594 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A2"></see></summary>
    let A2 = Namespaced_IRI.parse _namespace_name "A2" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 297 x 420 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A3"></see></summary>
    let A3 = Namespaced_IRI.parse _namespace_name "A3" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 210 x 297 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A4"></see></summary>
    let A4 = Namespaced_IRI.parse _namespace_name "A4" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 148 x 210 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A5"></see></summary>
    let A5 = Namespaced_IRI.parse _namespace_name "A5" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 105 x 148 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A6"></see></summary>
    let A6 = Namespaced_IRI.parse _namespace_name "A6" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 74 x 105 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A7"></see></summary>
    let A7 = Namespaced_IRI.parse _namespace_name "A7" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 52 x 74 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A8"></see></summary>
    let A8 = Namespaced_IRI.parse _namespace_name "A8" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 37 x 52 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A9"></see></summary>
    let A9 = Namespaced_IRI.parse _namespace_name "A9" |> NamespacedName
    /// <summary>
    /// Advanced Audio Coding (AAC) is a standardized, lossy compression and encoding scheme for digital audio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Advanced Audio Coding" (http://en.wikipedia.org/wiki/Advanced_Audio_Coding) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AAC-LC"></see></summary>
    let ``AAC-LC`` = Namespaced_IRI.parse _namespace_name "AAC-LC" |> NamespacedName

    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to audiodata).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatAudio"></see></summary>
    let DataFormatAudio =
        Namespaced_IRI.parse _namespace_name "DataFormatAudio" |> NamespacedName

    /// <summary>
    /// A linear or switched-mode power supply (or in some cases just a transformer) that is built into the top of a plug and needed for the conversion of one form of electrical power to another desired form and voltage.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Power supply" (http://en.wikipedia.org/wiki/Power_supply) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ACAdapter"></see></summary>
    let ACAdapter = Namespaced_IRI.parse _namespace_name "ACAdapter" |> NamespacedName

    /// <summary>
    /// A Power Supply Adapter is used to convert 120 or 240 volt AC supplied by a utility company to a well-regulated lower voltage DC for electronic devices.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Power supply" (http://en.wikipedia.org/wiki/Power_supply) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerSupplyUnit"></see></summary>
    let PowerSupplyUnit =
        Namespaced_IRI.parse _namespace_name "PowerSupplyUnit" |> NamespacedName

    /// <summary>
    /// A net transfer of energy over a complete cycle of the alternating current waveform.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AC_Cable"></see></summary>
    let AC_Cable = Namespaced_IRI.parse _namespace_name "AC_Cable" |> NamespacedName
    /// <summary>
    /// A subordinate or supplementary item; an adjunct.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Accessory"></see></summary>
    let Accessory = Namespaced_IRI.parse _namespace_name "Accessory" |> NamespacedName
    /// <summary>
    /// Audio Interchange File Format (AIFF) is an audio file format standard used for storing sound data for personal computers and other electronic audio devices.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Audio Interchange File Format" (http://en.wikipedia.org/wiki/Audio_Interchange_File_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AIFF"></see></summary>
    let AIFF = Namespaced_IRI.parse _namespace_name "AIFF" |> NamespacedName
    /// <summary>
    /// The business entity AIPTEK, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AIPTEK"></see></summary>
    let AIPTEK = Namespaced_IRI.parse _namespace_name "AIPTEK" |> NamespacedName
    /// <summary>
    /// Apple Lossless (also known as Apple Lossless Encoder, ALE, or Apple Lossless Audio Codec, ALAC) is an audio codec developed by Apple Inc. for lossless data compression of digital music.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Apple Lossless" (http://en.wikipedia.org/wiki/Apple_Lossless) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ALE"></see></summary>
    let ALE = Namespaced_IRI.parse _namespace_name "ALE" |> NamespacedName
    /// <summary>
    /// The business entity AOC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AOC"></see></summary>
    let AOC = Namespaced_IRI.parse _namespace_name "AOC" |> NamespacedName
    /// <summary>
    /// Advanced Systems Format (formerly Advanced Streaming Format, Active Streaming Format) is Microsoft's proprietary digital audio/digital video container format, especially meant for streaming media. ASF is part of the Windows Media framework.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Advanced Systems Format" (http://en.wikipedia.org/wiki/Advanced_Systems_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ASF"></see></summary>
    let ASF = Namespaced_IRI.parse _namespace_name "ASF" |> NamespacedName
    /// <summary>
    /// The business entity ATEC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ATEC"></see></summary>
    let ATEC = Namespaced_IRI.parse _namespace_name "ATEC" |> NamespacedName
    /// <summary>
    /// ATMT
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ATMT"></see></summary>
    let ATMT = Namespaced_IRI.parse _namespace_name "ATMT" |> NamespacedName
    /// <summary>
    /// Audio connectors and video connectors are electrical connectors for carrying an audio signal or video signal, either in an analog or digital format. Analog A/V connectors often use shielded cable to inhibit RF interference and noise.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Audio and video connector" (http://en.wikipedia.org/wiki/Audio_and_video_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AV"></see></summary>
    let AV = Namespaced_IRI.parse _namespace_name "AV" |> NamespacedName

    /// <summary>
    /// A generic term for linking devices to each other and allow sending data in one or both directions.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Connectivity"></see></summary>
    let Connectivity =
        Namespaced_IRI.parse _namespace_name "Connectivity" |> NamespacedName

    /// <summary>
    /// A high-definition and standard-definition recording format for use in digital tapeless camcorders. The format is comparable to other handheld video camera recording formats, particularly HDV and TOD.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDV" (http://en.wikipedia.org/wiki/HDV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AVCH"></see></summary>
    let AVCH = Namespaced_IRI.parse _namespace_name "AVCH" |> NamespacedName

    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to video data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatVideo"></see></summary>
    let DataFormatVideo =
        Namespaced_IRI.parse _namespace_name "DataFormatVideo" |> NamespacedName

    /// <summary>
    /// A multimedia container format introduced by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AVI"></see></summary>
    let AVI = Namespaced_IRI.parse _namespace_name "AVI" |> NamespacedName
    /// <summary>
    /// A cable to carry video and audio signals from a device, to a tv; in digital or analog format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AV_Cable"></see></summary>
    let AV_Cable = Namespaced_IRI.parse _namespace_name "AV_Cable" |> NamespacedName
    /// <summary>
    /// The business entity Acer, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Acer"></see></summary>
    let Acer = Namespaced_IRI.parse _namespace_name "Acer" |> NamespacedName
    /// <summary>
    /// The business entity Actebis Peacock GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Actebis"></see></summary>
    let Actebis = Namespaced_IRI.parse _namespace_name "Actebis" |> NamespacedName
    /// <summary>
    /// Is acuteness or clearness of vision, especially form vision, which is dependent on the sharpness of the retinal focus within the eye and the sensitivity of the interpretative faculty of the brain.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Visual acuity" (http://en.wikipedia.org/wiki/Visual_acuity) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Acuity"></see></summary>
    let Acuity = Namespaced_IRI.parse _namespace_name "Acuity" |> NamespacedName

    /// <summary>
    /// Additional video equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoFeatures"></see></summary>
    let VideoFeatures =
        Namespaced_IRI.parse _namespace_name "VideoFeatures" |> NamespacedName

    /// <summary>
    /// The business entity Agfa-Gevaert N.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Agfa"></see></summary>
    let Agfa = Namespaced_IRI.parse _namespace_name "Agfa" |> NamespacedName
    /// <summary>
    /// The business entity Beijing Huaqi Information Digital Technology Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Aigo"></see></summary>
    let Aigo = Namespaced_IRI.parse _namespace_name "Aigo" |> NamespacedName
    /// <summary>
    /// The business entity Sony Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Aiwa"></see></summary>
    let Aiwa = Namespaced_IRI.parse _namespace_name "Aiwa" |> NamespacedName
    /// <summary>
    /// The business entity Akai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Akai"></see></summary>
    let Akai = Namespaced_IRI.parse _namespace_name "Akai" |> NamespacedName
    /// <summary>
    /// Has wakeup-function.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Alert"></see></summary>
    let Alert = Namespaced_IRI.parse _namespace_name "Alert" |> NamespacedName
    /// <summary>
    /// Additional equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Features"></see></summary>
    let Features = Namespaced_IRI.parse _namespace_name "Features" |> NamespacedName
    /// <summary>
    /// Ambilight, which is short for Ambient Lighting Technology, is a feature invented by Philips Electronics, generating light effects around the TV that correspond to the video content.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Ambilight" (http://en.wikipedia.org/wiki/Ambilight) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ambilight1"></see></summary>
    let Ambilight1 = Namespaced_IRI.parse _namespace_name "Ambilight1" |> NamespacedName

    /// <summary>
    /// Ambilight Spectra 2 generates reactive ambient lighting on both sides of a Flat TV.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectra2"></see></summary>
    let AmbilightSpectra2 =
        Namespaced_IRI.parse _namespace_name "AmbilightSpectra2" |> NamespacedName

    /// <summary>
    /// Enlarges the screen further by projecting a glow of light from the back of the screen onto the surrounding wall. Ambilight adjusts automatically the colour and brightness of the light surrounding the TV to match with the picture.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectra3"></see></summary>
    let AmbilightSpectra3 =
        Namespaced_IRI.parse _namespace_name "AmbilightSpectra3" |> NamespacedName

    /// <summary>
    /// Active Frame is a single soft halo of light powered by 126 LEDs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectraActiveFrame"></see></summary>
    let AmbilightSpectraActiveFrame =
        Namespaced_IRI.parse _namespace_name "AmbilightSpectraActiveFrame" |> NamespacedName

    /// <summary>
    /// An analog or analogue signal is any continuous signal for which the time varying feature (variable) of the signal is a representation of some other time varying quantity, i.e analogous to another time varying signal.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Analog signal" (http://en.wikipedia.org/wiki/Analog_signal) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Analog"></see></summary>
    let Analog = Namespaced_IRI.parse _namespace_name "Analog" |> NamespacedName
    /// <summary>
    /// Type of TV tuner that is used to convert RF television transmissions into audio and video signals.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TunerType"></see></summary>
    let TunerType = Namespaced_IRI.parse _namespace_name "TunerType" |> NamespacedName

    /// <summary>
    /// The screen has a short persistence phosphor with an anti-reflection and anti-static coating.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Anti-ReflectionCoatedScreen"></see></summary>
    let ``Anti-ReflectionCoatedScreen`` =
        Namespaced_IRI.parse _namespace_name "Anti-ReflectionCoatedScreen" |> NamespacedName

    /// <summary>
    /// Additional general equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GeneralFeatures"></see></summary>
    let GeneralFeatures =
        Namespaced_IRI.parse _namespace_name "GeneralFeatures" |> NamespacedName

    /// <summary>
    /// The business entity Apacer Technology, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Apacer"></see></summary>
    let Apacer = Namespaced_IRI.parse _namespace_name "Apacer" |> NamespacedName
    /// <summary>
    /// The business entity Apple, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Apple"></see></summary>
    let Apple = Namespaced_IRI.parse _namespace_name "Apple" |> NamespacedName
    /// <summary>
    /// The business entity Archos GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Archos"></see></summary>
    let Archos = Namespaced_IRI.parse _namespace_name "Archos" |> NamespacedName
    /// <summary>
    /// The business entity Asus.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Asus"></see></summary>
    let Asus = Namespaced_IRI.parse _namespace_name "Asus" |> NamespacedName

    /// <summary>
    /// Audio interface type of a specific diameter.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Audio2.5mm"></see></summary>
    let ``Audio2.5mm`` =
        Namespaced_IRI.parse _namespace_name "Audio2.5mm" |> NamespacedName

    /// <summary>
    /// Interface generally refers to an abstraction that an entity provides of itself to the outside (refers to audio output).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioInterfaceType"></see></summary>
    let AudioInterfaceType =
        Namespaced_IRI.parse _namespace_name "AudioInterfaceType" |> NamespacedName

    /// <summary>
    /// Audio interface type of a specific diameter.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Audio3.5mm"></see></summary>
    let ``Audio3.5mm`` =
        Namespaced_IRI.parse _namespace_name "Audio3.5mm" |> NamespacedName

    /// <summary>
    /// Additional audio equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioFeatures"></see></summary>
    let AudioFeatures =
        Namespaced_IRI.parse _namespace_name "AudioFeatures" |> NamespacedName

    /// <summary>
    /// Defines the support of a computer soundcard driver protocol for digital audio specified by Steinberg, providing a low-latency and high fidelity interface between a software application and a computer's sound card.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioInput"></see></summary>
    let AudioInput = Namespaced_IRI.parse _namespace_name "AudioInput" |> NamespacedName

    /// <summary>
    /// Gives an indication of preprogrammed channels for the user of a television so that he does not need to programm it himself.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoChannelSearch"></see></summary>
    let AutoChannelSearch =
        Namespaced_IRI.parse _namespace_name "AutoChannelSearch" |> NamespacedName

    /// <summary>
    /// Levels the audio volume of televisions automatically so that undesired peaks in the sound can be reduced.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoVolumeLeveller"></see></summary>
    let AutoVolumeLeveller =
        Namespaced_IRI.parse _namespace_name "AutoVolumeLeveller" |> NamespacedName

    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoWhiteBalance"></see></summary>
    let AutoWhiteBalance =
        Namespaced_IRI.parse _namespace_name "AutoWhiteBalance" |> NamespacedName

    /// <summary>
    /// Is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors). An important goal of this adjustment is to render specific colors - particularly neutral colors - correctly; hence, the general method is sometimes called gray balance, neutral balance, or white balance.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White Balance" (http://en.wikipedia.org/wiki/White_Balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WhiteBalance"></see></summary>
    let WhiteBalance =
        Namespaced_IRI.parse _namespace_name "WhiteBalance" |> NamespacedName

    /// <summary>
    /// A device used to stabilize a picture in order to keep it in a steady position.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutomaticPictureStabilizer"></see></summary>
    let AutomaticPictureStabilizer =
        Namespaced_IRI.parse _namespace_name "AutomaticPictureStabilizer" |> NamespacedName

    /// <summary>
    /// The business entity Axago.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Axago"></see></summary>
    let Axago = Namespaced_IRI.parse _namespace_name "Axago" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 1000 x 1414 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B0"></see></summary>
    let B0 = Namespaced_IRI.parse _namespace_name "B0" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 707 x 1000 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B1"></see></summary>
    let B1 = Namespaced_IRI.parse _namespace_name "B1" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 500 x 707 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B2"></see></summary>
    let B2 = Namespaced_IRI.parse _namespace_name "B2" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 353 x 500 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B3"></see></summary>
    let B3 = Namespaced_IRI.parse _namespace_name "B3" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 250 x 353 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B4"></see></summary>
    let B4 = Namespaced_IRI.parse _namespace_name "B4" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 176 x 250 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B5"></see></summary>
    let B5 = Namespaced_IRI.parse _namespace_name "B5" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 125 x 176 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B6"></see></summary>
    let B6 = Namespaced_IRI.parse _namespace_name "B6" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 88 x 125 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B7"></see></summary>
    let B7 = Namespaced_IRI.parse _namespace_name "B7" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 62 x 88 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B8"></see></summary>
    let B8 = Namespaced_IRI.parse _namespace_name "B8" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 44 x 62 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B9"></see></summary>
    let B9 = Namespaced_IRI.parse _namespace_name "B9" |> NamespacedName

    /// <summary>
    /// Ability to photograph against a light source.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BacklightMode"></see></summary>
    let BacklightMode =
        Namespaced_IRI.parse _namespace_name "BacklightMode" |> NamespacedName

    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BeachAndSnow"></see></summary>
    let BeachAndSnow =
        Namespaced_IRI.parse _namespace_name "BeachAndSnow" |> NamespacedName

    /// <summary>
    /// A projection of information from any physical environment into any sensory system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SceneMode"></see></summary>
    let SceneMode = Namespaced_IRI.parse _namespace_name "SceneMode" |> NamespacedName
    /// <summary>
    /// RGB Value 245,245,220
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Beige"></see></summary>
    let Beige = Namespaced_IRI.parse _namespace_name "Beige" |> NamespacedName
    /// <summary>
    /// Color derives from the spectrum of light interacting in the eye with the spectral sensitivities of the light receptors.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Color" (http://en.wikipedia.org/wiki/Color) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Color"></see></summary>
    let Color = Namespaced_IRI.parse _namespace_name "Color" |> NamespacedName
    /// <summary>
    /// The business entity Belkin International Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Belkin"></see></summary>
    let Belkin = Namespaced_IRI.parse _namespace_name "Belkin" |> NamespacedName
    /// <summary>
    /// The business entity BenQ Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BenQ"></see></summary>
    let BenQ = Namespaced_IRI.parse _namespace_name "BenQ" |> NamespacedName
    /// <summary>
    /// In computer graphics, a bitmap or pixmap is a type of memory organization or image file format used to store digital images.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Bitmap" (http://en.wikipedia.org/wiki/Bitmap) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Bitmap"></see></summary>
    let Bitmap = Namespaced_IRI.parse _namespace_name "Bitmap" |> NamespacedName

    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to image data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatImage"></see></summary>
    let DataFormatImage =
        Namespaced_IRI.parse _namespace_name "DataFormatImage" |> NamespacedName

    /// <summary>
    /// RGB Value 0,0,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Black"></see></summary>
    let Black = Namespaced_IRI.parse _namespace_name "Black" |> NamespacedName
    /// <summary>
    /// RGB Value 0,0,255
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Blue"></see></summary>
    let Blue = Namespaced_IRI.parse _namespace_name "Blue" |> NamespacedName
    /// <summary>
    /// Bluetooth is a wireless protocol utilizing short-range communications technology facilitating data transmission over short distances from fixed and mobile devices, creating wireless personal area networks.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Bluetooth"></see></summary>
    let Bluetooth = Namespaced_IRI.parse _namespace_name "Bluetooth" |> NamespacedName

    /// <summary>
    /// Interface generally refers to an abstraction that an entity provides of itself to the outside.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataInterfaceType"></see></summary>
    let DataInterfaceType =
        Namespaced_IRI.parse _namespace_name "DataInterfaceType" |> NamespacedName

    /// <summary>
    /// Bluetooth is a wireless protocol utilizing short-range communications technology facilitating data transmission over short distances from fixed and mobile devices, creating wireless personal area networks (refers to audio).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BluetoothAudio"></see></summary>
    let BluetoothAudio =
        Namespaced_IRI.parse _namespace_name "BluetoothAudio" |> NamespacedName

    /// <summary>
    /// The business entity Brother.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Brother"></see></summary>
    let Brother = Namespaced_IRI.parse _namespace_name "Brother" |> NamespacedName
    /// <summary>
    /// RGB Value 165,42,42
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Brown"></see></summary>
    let Brown = Namespaced_IRI.parse _namespace_name "Brown" |> NamespacedName

    /// <summary>
    /// Speakers that are integrated in the hull of a electronical device, that is able to play audio signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BuiltInSpeakers"></see></summary>
    let BuiltInSpeakers =
        Namespaced_IRI.parse _namespace_name "BuiltInSpeakers" |> NamespacedName

    /// <summary>
    /// The CE marking (also known as CE mark) is a mandatory conformity mark on many products placed on the single market in the European Economic Area (EEA).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CE mark" (http://en.wikipedia.org/wiki/CE_mark) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CE_Mark"></see></summary>
    let CE_Mark = Namespaced_IRI.parse _namespace_name "CE_Mark" |> NamespacedName

    /// <summary>
    /// A certificate is an official document affirming some fact like quality standards.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Certificate" (http://en.wikipedia.org/wiki/Certificate) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Certificate"></see></summary>
    let Certificate =
        Namespaced_IRI.parse _namespace_name "Certificate" |> NamespacedName

    /// <summary>
    /// CGM (Computer Graphics Metafile) is a file format for 2D vector graphics, raster graphics, and text, and is defined by ISO/IEC 8632.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Computer Graphics Metafile" (http://en.wikipedia.org/wiki/Computer_Graphics_Metafile) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CGM"></see></summary>
    let CGM = Namespaced_IRI.parse _namespace_name "CGM" |> NamespacedName
    /// <summary>
    /// Complementary metal-oxide-semiconductor (CMOS) (pronounced "see-moss", IPA: /ˈsiːmɒs/), is a major class of integrated circuits. CMOS technology is used in microprocessors, microcontrollers, static RAM, and other digital logic circuits. CMOS technology is also used for a wide variety of analog circuits such as image sensors, data converters, and highly integrated transceivers for many types of communication. Frank Wanlass successfully patented CMOS in 1967 (US Patent 3,356,858).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CMOS" (http://en.wikipedia.org/wiki/CMOS) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CMOS"></see></summary>
    let CMOS = Namespaced_IRI.parse _namespace_name "CMOS" |> NamespacedName
    /// <summary>
    /// Type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sensor" (http://en.wikipedia.org/wiki/Sensor) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SensorType"></see></summary>
    let SensorType = Namespaced_IRI.parse _namespace_name "SensorType" |> NamespacedName
    /// <summary>
    /// The business entity CTX.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CTX"></see></summary>
    let CTX = Namespaced_IRI.parse _namespace_name "CTX" |> NamespacedName
    /// <summary>
    /// Composite video is often designated by the CVBS acronym, meaning any of "Color, Video, Blank and Sync", "Composite Video Baseband Signal", "Composite Video Burst Signal", or "Composite Video with Burst and Sync". Here the input is meant.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CVBS_in"></see></summary>
    let CVBS_in = Namespaced_IRI.parse _namespace_name "CVBS_in" |> NamespacedName
    /// <summary>
    /// Composite video is often designated by the CVBS acronym, meaning any of "Color, Video, Blank and Sync", "Composite Video Baseband Signal", "Composite Video Burst Signal", or "Composite Video with Burst and Sync". Here the output is meant.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CVBS_out"></see></summary>
    let CVBS_out = Namespaced_IRI.parse _namespace_name "CVBS_out" |> NamespacedName
    /// <summary>
    /// A camcorder is a portable consumer electronics device for recording video and audio using a built-in recorder unit.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Camcorder"></see></summary>
    let Camcorder = Namespaced_IRI.parse _namespace_name "Camcorder" |> NamespacedName
    /// <summary>
    /// The business entity Canon.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Canon"></see></summary>
    let Canon = Namespaced_IRI.parse _namespace_name "Canon" |> NamespacedName
    /// <summary>
    /// The business entity Canyon.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Canyon"></see></summary>
    let Canyon = Namespaced_IRI.parse _namespace_name "Canyon" |> NamespacedName
    /// <summary>
    /// A paper stock that is thicker and more durable than normal writing or printing paper, but thinner and more flexible than other forms of paperboard.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Cardstock" (http://en.wikipedia.org/wiki/Card_stock) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Cardstock"></see></summary>
    let Cardstock = Namespaced_IRI.parse _namespace_name "Cardstock" |> NamespacedName
    /// <summary>
    /// The type of paper a device is able to handle.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaType"></see></summary>
    let MediaType = Namespaced_IRI.parse _namespace_name "MediaType" |> NamespacedName
    /// <summary>
    /// The business entity Casio Computer Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Casio"></see></summary>
    let Casio = Namespaced_IRI.parse _namespace_name "Casio" |> NamespacedName

    /// <summary>
    /// A child safety lock is a special-purpose lock that is designed to help prevent children from getting at any dangerous contents.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Child safety lock" (http://en.wikipedia.org/wiki/Child_safety_lock) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ChildSafetyLock"></see></summary>
    let ChildSafetyLock =
        Namespaced_IRI.parse _namespace_name "ChildSafetyLock" |> NamespacedName

    /// <summary>
    /// The business entity Chimei.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Chimei"></see></summary>
    let Chimei = Namespaced_IRI.parse _namespace_name "Chimei" |> NamespacedName
    /// <summary>
    /// Can display the current time.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Clock"></see></summary>
    let Clock = Namespaced_IRI.parse _namespace_name "Clock" |> NamespacedName
    /// <summary>
    /// The business entity Coby Electronics Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Coby"></see></summary>
    let Coby = Namespaced_IRI.parse _namespace_name "Coby" |> NamespacedName
    /// <summary>
    /// The reproduction of an image or text in color on a paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ColorPrint"></see></summary>
    let ColorPrint = Namespaced_IRI.parse _namespace_name "ColorPrint" |> NamespacedName
    /// <summary>
    /// In signal processing, a comb filter adds a delayed version of a signal to itself, causing constructive and destructive interference. The frequency response of a comb filter consists of a series of regularly-spaced spikes, giving the appearance of a comb.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Comb filter" (http://en.wikipedia.org/wiki/Comb_filter) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CombFilter"></see></summary>
    let CombFilter = Namespaced_IRI.parse _namespace_name "CombFilter" |> NamespacedName

    /// <summary>
    /// The Common Interface is an extensible digital interconnect found in the digital TV market.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Common Interface" (http://en.wikipedia.org/wiki/Common_Interface) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CommonInterface"></see></summary>
    let CommonInterface =
        Namespaced_IRI.parse _namespace_name "CommonInterface" |> NamespacedName

    /// <summary>
    /// CompactFlash (CF) is a mass storage device format used in portable electronic devices. For storage, CompactFlash typically uses flash memory in a standardized enclosure.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CompactFlash" (http://en.wikipedia.org/wiki/CompactFlash) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompactFlash"></see></summary>
    let CompactFlash =
        Namespaced_IRI.parse _namespace_name "CompactFlash" |> NamespacedName

    /// <summary>
    /// A data storage device is a device for recording (storing) information (data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Data Storage Device" (http://en.wikipedia.org/wiki/Data_storage_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#StorageMedia"></see></summary>
    let StorageMedia =
        Namespaced_IRI.parse _namespace_name "StorageMedia" |> NamespacedName

    /// <summary>
    /// Ability to communicate with different kinds of operating systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompatibleOperatingSystems"></see></summary>
    let CompatibleOperatingSystems =
        Namespaced_IRI.parse _namespace_name "CompatibleOperatingSystems" |> NamespacedName

    /// <summary>
    /// Component video is a video signal that has been split into two or more components. In popular use, it refers to a type of analog video information that is transmitted or stored as three separate signals. Component video can be contrasted with composite video (NTSC, PAL or SECAM) in which all the video information is combined into a single line-level signal. Like composite, component video cables do not carry audio and are often paired with audio cables. Here the input is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Component video" (http://en.wikipedia.org/wiki/Component_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComponentVideoIn"></see></summary>
    let ComponentVideoIn =
        Namespaced_IRI.parse _namespace_name "ComponentVideoIn" |> NamespacedName

    /// <summary>
    /// Component video is a video signal that has been split into two or more components. In popular use, it refers to a type of analog video information that is transmitted or stored as three separate signals. Component video can be contrasted with composite video (NTSC, PAL or SECAM) in which all the video information is combined into a single line-level signal. Like composite, component video cables do not carry audio and are often paired with audio cables. Here the output is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Component video" (http://en.wikipedia.org/wiki/Component_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComponentVideoOut"></see></summary>
    let ComponentVideoOut =
        Namespaced_IRI.parse _namespace_name "ComponentVideoOut" |> NamespacedName

    /// <summary>
    /// Composite video is the format of an analog television (picture only) signal before it is combined with a sound signal and modulated onto an RF carrier. It is usually in a standard format such as NTSC, PAL, or SECAM. It is a composite of three source signals called Y, U and V (together referred to as YUV) with sync pulses. Here the input is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Composite video" (http://en.wikipedia.org/wiki/Composite_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompositeVideoIn"></see></summary>
    let CompositeVideoIn =
        Namespaced_IRI.parse _namespace_name "CompositeVideoIn" |> NamespacedName

    /// <summary>
    /// The display resolution of a computer display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution"></see></summary>
    let ComputerDisplayResolution =
        Namespaced_IRI.parse _namespace_name "ComputerDisplayResolution" |> NamespacedName

    /// <summary>
    /// Resolution supported by an electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SupportedResolution"></see></summary>
    let SupportedResolution =
        Namespaced_IRI.parse _namespace_name "SupportedResolution" |> NamespacedName

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Extended Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_1024x768_60_70_75_85Hz"></see></summary>
    let ComputerDisplayResolution_1024x768_60_70_75_85Hz =
        Namespaced_IRI.parse _namespace_name "ComputerDisplayResolution_1024x768_60_70_75_85Hz" |> NamespacedName

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Video Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_640x480_60_72_75_85Hz"></see></summary>
    let ComputerDisplayResolution_640x480_60_72_75_85Hz =
        Namespaced_IRI.parse _namespace_name "ComputerDisplayResolution_640x480_60_72_75_85Hz" |> NamespacedName

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Super Video Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_800x600_60_72_75_85Hz"></see></summary>
    let ComputerDisplayResolution_800x600_60_72_75_85Hz =
        Namespaced_IRI.parse _namespace_name "ComputerDisplayResolution_800x600_60_72_75_85Hz" |> NamespacedName

    /// <summary>
    /// Ensures that, according to the scene, the screen always displays the best possible contrast. This results in a depth of focus, which lends an extraordinary power to the television image, making it appear almost touchable.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ContrastPlus"></see></summary>
    let ContrastPlus =
        Namespaced_IRI.parse _namespace_name "ContrastPlus" |> NamespacedName

    /// <summary>
    /// The business entity COWON SYSTEMS, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Cowon"></see></summary>
    let Cowon = Namespaced_IRI.parse _namespace_name "Cowon" |> NamespacedName

    /// <summary>
    /// The business entity Creative Technology Limited.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Creative_Labs"></see></summary>
    let Creative_Labs =
        Namespaced_IRI.parse _namespace_name "Creative_Labs" |> NamespacedName

    /// <summary>
    /// The mean amplitude of a waveform.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DC_Cable"></see></summary>
    let DC_Cable = Namespaced_IRI.parse _namespace_name "DC_Cable" |> NamespacedName
    /// <summary>
    /// The business entity DK digital GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DK_digital"></see></summary>
    let DK_digital = Namespaced_IRI.parse _namespace_name "DK_digital" |> NamespacedName
    /// <summary>
    /// Format of the german institute for standardization: 110 x 220 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DL"></see></summary>
    let DL = Namespaced_IRI.parse _namespace_name "DL" |> NamespacedName

    /// <summary>
    /// The Digital Living Network Alliance is an international, cross-industry collaboration of consumer electronics, computing industry and mobile device companies. Members of DLNA develop a concept of wired and wireless interoperable networks where digital content such as photos, music, and videos can be shared through consumer electronics (CE), personal computers (PCs), and mobile devices in and beyond the home.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Living Network Alliance" (http://en.wikipedia.org/wiki/Digital_Living_Network_Alliance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DLNA_Ethernet"></see></summary>
    let DLNA_Ethernet =
        Namespaced_IRI.parse _namespace_name "DLNA_Ethernet" |> NamespacedName

    /// <summary>
    /// A file extension for word processing documents.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DOC"></see></summary>
    let DOC = Namespaced_IRI.parse _namespace_name "DOC" |> NamespacedName

    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to office data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatOffice"></see></summary>
    let DataFormatOffice =
        Namespaced_IRI.parse _namespace_name "DataFormatOffice" |> NamespacedName

    /// <summary>
    /// DPOF (Digital Print Order format) is a format which allows the user of a digital camera or other device such as a Mobile Phone or PDA to define which captured images on the storage card are to be printed, together with information on the number of copies or other image information such as paper size, image title text, image orientation, contact information and more.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DPOF" (http://en.wikipedia.org/wiki/DPOF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DPOF"></see></summary>
    let DPOF = Namespaced_IRI.parse _namespace_name "DPOF" |> NamespacedName
    /// <summary>
    /// Digital Video (DV) is a digital video format created by Sony, JVC, Panasonic and other video camera producers, and launched in 1995. The DV specification (originally known as the Blue Book, current official name IEC 61834) defines both the codec and the tape format.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DV" (http://en.wikipedia.org/wiki/DV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DV"></see></summary>
    let DV = Namespaced_IRI.parse _namespace_name "DV" |> NamespacedName
    /// <summary>
    /// Digital Video Broadcasting (DVB) is a suite of internationally accepted open standards for digital television. DVB systems distribute data using a variety of approaches, including by satellite (DVB-S, DVB-S2 and DVB-SH; also DVB-SMATV for distribution via SMATV); cable (DVB-C); terrestrial television (DVB-T, DVB-T2) and digital terrestrial television for handhelds (DVB-H,DVB-SH); and via microwave using DTT (DVB-MT), the MMDS (DVB-MC), and/or MVDS standards (DVB-MS).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Video Broadcasting" (http://en.wikipedia.org/wiki/Digital_Video_Broadcasting) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB"></see></summary>
    let DVB = Namespaced_IRI.parse _namespace_name "DVB" |> NamespacedName

    /// <summary>
    /// Type of the transmitted video format signal that is displayed by a monitor or TV panel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SignalFormat"></see></summary>
    let SignalFormat =
        Namespaced_IRI.parse _namespace_name "SignalFormat" |> NamespacedName

    /// <summary>
    /// DVB-T is an abbreviation for Digital Video Broadcasting - Terrestrial; it is the DVB European-based consortium standard for the broadcast transmission of digital terrestrial television. This system transmits compressed digital audio, video and other data in an MPEG transport stream, using COFDM modulation.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DVB-T" (http://en.wikipedia.org/wiki/DVB-T) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB-T"></see></summary>
    let ``DVB-T`` = Namespaced_IRI.parse _namespace_name "DVB-T" |> NamespacedName
    /// <summary>
    /// Digital Video Broadcasting (DVB) is a suite of internationally accepted open standards for digital television. Coded OFDM (COFDM) and Discrete multi-tone modulation (DMT) is a frequency-division multiplexing (FDM) scheme utilized as a digital multi-carrier modulation method. A large number of closely-spaced orthogonal sub-carriers are used to carry data. The data is divided into several parallel data streams or channels, one for each sub-carrier. Each sub-carrier is modulated with a conventional modulation scheme (such as quadrature amplitude modulation or phase shift keying) at a low symbol rate, maintaining total data rates similar to conventional single-carrier modulation schemes in the same bandwidth.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Video Broadcasting" (http://en.wikipedia.org/wiki/Digital_Video_Broadcasting) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB_COFDM"></see></summary>
    let DVB_COFDM = Namespaced_IRI.parse _namespace_name "DVB_COFDM" |> NamespacedName
    /// <summary>
    /// The Digital Visual Interface (DVI) is a video interface standard designed to maximize the visual quality of digital display devices such as flat panel LCD computer displays and digital projectors. It is designed for carrying uncompressed digital video data to a display. It is partially compatible with the High-Definition Multimedia Interface (HDMI) standard in digital mode (DVI-D), and VGA in analog mode (DVI-A).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Visual Interface" (http://en.wikipedia.org/wiki/Digital_Visual_Interface) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI"></see></summary>
    let DVI = Namespaced_IRI.parse _namespace_name "DVI" |> NamespacedName
    /// <summary>
    /// A digital video format created by Sony, JVC, Panasonic and other video camera producers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI_in"></see></summary>
    let DVI_in = Namespaced_IRI.parse _namespace_name "DVI_in" |> NamespacedName
    /// <summary>
    /// A digital video format created by Sony, JVC, Panasonic and other video camera producers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI_out"></see></summary>
    let DVI_out = Namespaced_IRI.parse _namespace_name "DVI_out" |> NamespacedName
    /// <summary>
    /// The business entity Daewoo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Daewoo"></see></summary>
    let Daewoo = Namespaced_IRI.parse _namespace_name "Daewoo" |> NamespacedName

    /// <summary>
    /// The business entity Dane-Elec GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Dane-Elec"></see></summary>
    let ``Dane-Elec`` =
        Namespaced_IRI.parse _namespace_name "Dane-Elec" |> NamespacedName

    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormat"></see></summary>
    let DataFormat = Namespaced_IRI.parse _namespace_name "DataFormat" |> NamespacedName
    /// <summary>
    /// The business entity Decktron Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Decktron"></see></summary>
    let Decktron = Namespaced_IRI.parse _namespace_name "Decktron" |> NamespacedName
    /// <summary>
    /// The business entity Dell.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Dell"></see></summary>
    let Dell = Namespaced_IRI.parse _namespace_name "Dell" |> NamespacedName
    /// <summary>
    /// The business entity Denver.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Denver"></see></summary>
    let Denver = Namespaced_IRI.parse _namespace_name "Denver" |> NamespacedName
    /// <summary>
    /// The business entity Differo Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Differo"></see></summary>
    let Differo = Namespaced_IRI.parse _namespace_name "Differo" |> NamespacedName
    /// <summary>
    /// The business entity DIFRNCE B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Difrnce"></see></summary>
    let Difrnce = Namespaced_IRI.parse _namespace_name "Difrnce" |> NamespacedName
    /// <summary>
    /// A digital system uses discrete (discontinuous) values, usually but not always symbolized numerically (hence called "digital") to represent information for input, processing, transmission, storage.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital" (http://en.wikipedia.org/wiki/Digital) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Digital"></see></summary>
    let Digital = Namespaced_IRI.parse _namespace_name "Digital" |> NamespacedName

    /// <summary>
    /// Digital audio uses digital signals for sound reproduction. This includes analog-to-digital conversion, digital-to-analog conversion, storage and transmission. From the signal point of view, a connector can be viewed as a short, rigid cable. The connector usually has the same impedance as the related cable and probably has a similar cutoff frequency although its dielectric may be different. Some connectors are gold or rhodium plated, while some connectors use nickel or tin plating. Silver is also used due to its excellent conductivity. Although silver tends to oxidize rather quickly, the silver oxide that is produced is still conductive. This may pose a cosmetic issue but it does not degrade the performance of the connector. Here the output is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital audio" (http://en.wikipedia.org/wiki/Digital_audio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalAudioCoaxialOut"></see></summary>
    let DigitalAudioCoaxialOut =
        Namespaced_IRI.parse _namespace_name "DigitalAudioCoaxialOut" |> NamespacedName

    /// <summary>
    /// Digital audio uses digital signals for sound reproduction. This includes analog-to-digital conversion, digital-to-analog conversion, storage, and transmission. TOSLINK or Optical Cable is a standardized optical fiber connection system.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital audio" (http://en.wikipedia.org/wiki/Digital_audio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalAudioOpticalOut"></see></summary>
    let DigitalAudioOpticalOut =
        Namespaced_IRI.parse _namespace_name "DigitalAudioOpticalOut" |> NamespacedName

    /// <summary>
    /// A digital camera (or digicam for short) is a camera that takes video or still photographs, or both, digitally by recording images via an electronic image sensor.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital camera" (http://en.wikipedia.org/wiki/Digital_camera) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalCamera"></see></summary>
    let DigitalCamera =
        Namespaced_IRI.parse _namespace_name "DigitalCamera" |> NamespacedName

    /// <summary>
    /// Digital Crystal Clear is a package of picture innovations that digitally adjusts and optimises picture quality to optimal contrast, colour and sharpness levels.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalCrystalClear"></see></summary>
    let DigitalCrystalClear =
        Namespaced_IRI.parse _namespace_name "DigitalCrystalClear" |> NamespacedName

    /// <summary>
    /// Seamlessly up-scales any video source to display at full high definition 1080p.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalImageScalingTechnology"></see></summary>
    let DigitalImageScalingTechnology =
        Namespaced_IRI.parse _namespace_name "DigitalImageScalingTechnology" |> NamespacedName

    /// <summary>
    /// A display device is an output device for presentation of information for visual, tactile or auditive reception, acquired, stored, or transmitted in various forms.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display device" (http://en.wikipedia.org/wiki/Display_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisplayType"></see></summary>
    let DisplayType =
        Namespaced_IRI.parse _namespace_name "DisplayType" |> NamespacedName

    /// <summary>
    /// Is any kind of electrochemical cell in which the electrochemical reaction of interest is not reversible.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisposableBattery"></see></summary>
    let DisposableBattery =
        Namespaced_IRI.parse _namespace_name "DisposableBattery" |> NamespacedName

    /// <summary>
    /// Disposable batteries are non-rechargeable batteries. When they are out of power you have to dispose them.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisposableEnergySource"></see></summary>
    let DisposableEnergySource =
        Namespaced_IRI.parse _namespace_name "DisposableEnergySource" |> NamespacedName

    /// <summary>
    /// Methods of energy storage have been developed, which transform electrical energy into forms of potential energy.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Energy development" (http://en.wikipedia.org/wiki/Energy_development) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EnergySource"></see></summary>
    let EnergySource =
        Namespaced_IRI.parse _namespace_name "EnergySource" |> NamespacedName

    /// <summary>
    /// Ability to display documents.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DocumentViewing"></see></summary>
    let DocumentViewing =
        Namespaced_IRI.parse _namespace_name "DocumentViewing" |> NamespacedName

    /// <summary>
    /// The marketing name for a series of lossy audio compression technologies developed by Dolby Laboratories.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Dolby Digital" (http://en.wikipedia.org/wiki/Dolby_Digital) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DolbyDigital"></see></summary>
    let DolbyDigital =
        Namespaced_IRI.parse _namespace_name "DolbyDigital" |> NamespacedName

    /// <summary>
    /// A feature of computer printers and MFPs that allows the automatic printing of a sheet of paper on both sides.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DuplexPrint"></see></summary>
    let DuplexPrint =
        Namespaced_IRI.parse _namespace_name "DuplexPrint" |> NamespacedName

    /// <summary>
    /// Dynamic settlement of bass audiosignals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DynamicBassEnhancement"></see></summary>
    let DynamicBassEnhancement =
        Namespaced_IRI.parse _namespace_name "DynamicBassEnhancement" |> NamespacedName

    /// <summary>
    /// 480p is the shorthand name for a video display resolution. The p stands for progressive scan, i.e. non-interlaced. The 480 denotes a vertical resolution of 480 vertically scanning lines, usually with a horizontal resolution of 640 pixels and 4:3 aspect ratio or a horizontal resolution of 854 pixels and 16:9 aspect ratio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "480p" (http://en.wikipedia.org/wiki/480p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EDTV_480p"></see></summary>
    let EDTV_480p = Namespaced_IRI.parse _namespace_name "EDTV_480p" |> NamespacedName

    /// <summary>
    /// The display resolution of a digital television or display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVDisplayResolution"></see></summary>
    let TVDisplayResolution =
        Namespaced_IRI.parse _namespace_name "TVDisplayResolution" |> NamespacedName

    /// <summary>
    /// An electronic program(me) guide (EPG) or interactive program(me) guide (IPG) or electronic service guide (ESG) is an digital guide to scheduled broadcast television or radio programs, typically displayed on-screen with functions allowing a viewer to navigate, select, and discover content by time, title, channel, genre, etc. by use of their remote control, a keyboard, or other input devices such as a phone keypad.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Electronic program guide" (http://en.wikipedia.org/wiki/Electronic_program_guide) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EPG"></see></summary>
    let EPG = Namespaced_IRI.parse _namespace_name "EPG" |> NamespacedName
    /// <summary>
    /// The business entity EACONN B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Eaconn"></see></summary>
    let Eaconn = Namespaced_IRI.parse _namespace_name "Eaconn" |> NamespacedName

    /// <summary>
    /// Equipment that allows economical printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EconomicalMode"></see></summary>
    let EconomicalMode =
        Namespaced_IRI.parse _namespace_name "EconomicalMode" |> NamespacedName

    /// <summary>
    /// The business entity Eizo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Eizo"></see></summary>
    let Eizo = Namespaced_IRI.parse _namespace_name "Eizo" |> NamespacedName

    /// <summary>
    /// The business entity Energy Sistem Soyntec S.A.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Energy_Sistem"></see></summary>
    let Energy_Sistem =
        Namespaced_IRI.parse _namespace_name "Energy_Sistem" |> NamespacedName

    /// <summary>
    /// Is a packaging product, usually made of flat material such as paper or cardboard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Envelope"></see></summary>
    let Envelope = Namespaced_IRI.parse _namespace_name "Envelope" |> NamespacedName
    /// <summary>
    /// The business entity Seiko Epson Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Epson"></see></summary>
    let Epson = Namespaced_IRI.parse _namespace_name "Epson" |> NamespacedName
    /// <summary>
    /// Equalization, equalisation or EQ is the process of using passive or active electronic elements or digital algorithms for the purpose of altering (originally flattening) the frequency response characteristics of a system.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Equalization" (http://en.wikipedia.org/wiki/Equalization) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Equalizer"></see></summary>
    let Equalizer = Namespaced_IRI.parse _namespace_name "Equalizer" |> NamespacedName
    /// <summary>
    /// The business entity Esselte.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Esselte"></see></summary>
    let Esselte = Namespaced_IRI.parse _namespace_name "Esselte" |> NamespacedName
    /// <summary>
    /// Free Lossless Audio Codec (FLAC) is a file format for lossless audio data compression.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Free Lossless Audio Codec" (http://en.wikipedia.org/wiki/Free_Lossless_Audio_Codec) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FLAC"></see></summary>
    let FLAC = Namespaced_IRI.parse _namespace_name "FLAC" |> NamespacedName

    /// <summary>
    /// Ability to identify the face and to justify the picture to it.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FaceIdendification"></see></summary>
    let FaceIdendification =
        Namespaced_IRI.parse _namespace_name "FaceIdendification" |> NamespacedName

    /// <summary>
    /// The business entity Finlux.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Finlux"></see></summary>
    let Finlux = Namespaced_IRI.parse _namespace_name "Finlux" |> NamespacedName

    /// <summary>
    /// The term upgrade refers to the replacement of a product with a newer version of that same product, here it is the replacement of the firmware with a newer version of it.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FirmwareUpgradable"></see></summary>
    let FirmwareUpgradable =
        Namespaced_IRI.parse _namespace_name "FirmwareUpgradable" |> NamespacedName

    /// <summary>
    /// Is a device used in photography that produces an instantaneous flash of artificial light.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Flash"></see></summary>
    let Flash = Namespaced_IRI.parse _namespace_name "Flash" |> NamespacedName
    /// <summary>
    /// A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Focus"></see></summary>
    let Focus = Namespaced_IRI.parse _namespace_name "Focus" |> NamespacedName
    /// <summary>
    /// Autofocus (or AF) is a feature of some optical systems that allows them to obtain (and in some systems to also continuously maintain) correct focus on a subject, instead of requiring the operator to adjust focus manually.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Autofocus" (http://en.wikipedia.org/wiki/Autofocus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusAuto"></see></summary>
    let FocusAuto = Namespaced_IRI.parse _namespace_name "FocusAuto" |> NamespacedName
    /// <summary>
    /// A photographic lens for which the focus is not adjustable is called a fixed-focus lens.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Fixed focus" (http://en.wikipedia.org/wiki/Fixed_focus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusFixed"></see></summary>
    let FocusFixed = Namespaced_IRI.parse _namespace_name "FocusFixed" |> NamespacedName

    /// <summary>
    /// A manual focus allows the operator to adjust the focus of the lens by hand.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Manual focus" (http://en.wikipedia.org/wiki/Manual_focus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusManual"></see></summary>
    let FocusManual =
        Namespaced_IRI.parse _namespace_name "FocusManual" |> NamespacedName

    /// <summary>
    /// Encompasses a range of techniques for enriching (expanding and deepening) the sound reproduction quality, of an audio source, with additional audio channels reproduced via additional, discrete speakers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Format5.1ch"></see></summary>
    let ``Format5.1ch`` =
        Namespaced_IRI.parse _namespace_name "Format5.1ch" |> NamespacedName

    /// <summary>
    /// The business entity Freecom Technologies GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Freecom"></see></summary>
    let Freecom = Namespaced_IRI.parse _namespace_name "Freecom" |> NamespacedName
    /// <summary>
    /// The business entity Fujifilm Holdings Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Fujifilm"></see></summary>
    let Fujifilm = Namespaced_IRI.parse _namespace_name "Fujifilm" |> NamespacedName

    /// <summary>
    /// The business entity Fujitsu Siemens.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Fujitsu_Siemens"></see></summary>
    let Fujitsu_Siemens =
        Namespaced_IRI.parse _namespace_name "Fujitsu_Siemens" |> NamespacedName

    /// <summary>
    /// Usually assumes a widescreen aspect ratio of 16:9, implying a horizontal resolution of 1920 pixels. This creates a frame resolution of 1920×1080, or 2,073,600 pixels in total.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080p" (http://en.wikipedia.org/wiki/1080p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FullHD"></see></summary>
    let FullHD = Namespaced_IRI.parse _namespace_name "FullHD" |> NamespacedName

    /// <summary>
    /// A designation used by Apple Computer to describe a fourth generation of 32-bit PowerPC microprocessors.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PowerPC_G4" (http://en.wikipedia.org/wiki/PowerPC_G4) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#G4_Class_Processor"></see></summary>
    let G4_Class_Processor =
        Namespaced_IRI.parse _namespace_name "G4_Class_Processor" |> NamespacedName

    /// <summary>
    /// The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ProcessorType"></see></summary>
    let ProcessorType =
        Namespaced_IRI.parse _namespace_name "ProcessorType" |> NamespacedName

    /// <summary>
    /// The business entity General Electric Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GE"></see></summary>
    let GE = Namespaced_IRI.parse _namespace_name "GE" |> NamespacedName
    /// <summary>
    /// The format supports up to 8 bits per pixel, allowing a single image to reference a palette of up to 256 distinct colors chosen from the 24-bit RGB color space.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics Interchange Format" (http://en.wikipedia.org/wiki/Graphics_Interchange_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GIF"></see></summary>
    let GIF = Namespaced_IRI.parse _namespace_name "GIF" |> NamespacedName
    /// <summary>
    /// The business entity GNR.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GNR"></see></summary>
    let GNR = Namespaced_IRI.parse _namespace_name "GNR" |> NamespacedName
    /// <summary>
    /// A special mode providing more performance of the television to optimize pictures when games are played on a LCD or plasma panel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GameMode"></see></summary>
    let GameMode = Namespaced_IRI.parse _namespace_name "GameMode" |> NamespacedName
    /// <summary>
    /// The business entity GEMBIRD ® Deutschland GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Gembird"></see></summary>
    let Gembird = Namespaced_IRI.parse _namespace_name "Gembird" |> NamespacedName
    /// <summary>
    /// RGB Value 255,215,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Gold"></see></summary>
    let Gold = Namespaced_IRI.parse _namespace_name "Gold" |> NamespacedName
    /// <summary>
    /// RGB Value 0,128,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Green"></see></summary>
    let Green = Namespaced_IRI.parse _namespace_name "Green" |> NamespacedName
    /// <summary>
    /// RGB Value 128,128,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Grey"></see></summary>
    let Grey = Namespaced_IRI.parse _namespace_name "Grey" |> NamespacedName
    /// <summary>
    /// The business entity Griffin Technology.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Griffin"></see></summary>
    let Griffin = Namespaced_IRI.parse _namespace_name "Griffin" |> NamespacedName
    /// <summary>
    /// The business entity GRUNDIG Intermedia GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Grundig"></see></summary>
    let Grundig = Namespaced_IRI.parse _namespace_name "Grundig" |> NamespacedName
    /// <summary>
    /// The business entity Guillemot Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Guillemot"></see></summary>
    let Guillemot = Namespaced_IRI.parse _namespace_name "Guillemot" |> NamespacedName
    /// <summary>
    /// H.264 is a standard for video compression, and is equivalent to MPEG-4 Part 10, or MPEG-4 AVC (for Advanced Video Coding). As of 2008, it is the latest block-oriented motion-compensation-based codec standard developed by the ITU-T Video Coding Experts Group (VCEG) together with the ISO/IEC Moving Picture Experts Group (MPEG), and it was the product of a partnership effort known as the Joint Video Team (JVT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "H.264" (http://en.wikipedia.org/wiki/H.264) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#H.264"></see></summary>
    let ``H.264`` = Namespaced_IRI.parse _namespace_name "H.264" |> NamespacedName
    /// <summary>
    /// HDMI (High-Definition Multimedia Interface) is a compact audio/video interface for transmitting uncompressed digital data. It represents a digital alternative to consumer analog standards such as Radio Frequency (RF) coaxial cable, composite video, S-Video, SCART, component video, D-Terminal, and VGA. HDMI connects digital audio/video sources such as set-top boxes, Blu-ray Disc players, personal computers (PCs), video game consoles, and AV receivers to compatible digital audio devices, computer monitors, and digital televisions.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDMI" (http://en.wikipedia.org/wiki/HDMI) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDMI"></see></summary>
    let HDMI = Namespaced_IRI.parse _namespace_name "HDMI" |> NamespacedName

    /// <summary>
    /// HDMI (High-Definition Multimedia Interface) is a compact audio/video interface for transmitting uncompressed digital data.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDMI" (http://en.wikipedia.org/wiki/HDMI) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDMI_Interface"></see></summary>
    let HDMI_Interface =
        Namespaced_IRI.parse _namespace_name "HDMI_Interface" |> NamespacedName

    /// <summary>
    /// 1080i is the shorthand name of a format of high-definition video modes. 1080 denotes the number of horizontal scan lines - also known as vertical resolution - and the letter i stands for interlaced.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080i" (http://en.wikipedia.org/wiki/1080i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_1080i"></see></summary>
    let HDTV_1080i = Namespaced_IRI.parse _namespace_name "HDTV_1080i" |> NamespacedName
    /// <summary>
    /// 1080p is the shorthand name for a category of HDTV video modes. The number "1080" represents 1,080 lines of vertical resolution (1080 horizontal scan lines), while the letter p stands for progressive scan (meaning the image is not interlaced). 1080p can be referred to as full HD or full high definition to differentiate it from other HDTV video modes.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080p" (http://en.wikipedia.org/wiki/1080p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_1080p"></see></summary>
    let HDTV_1080p = Namespaced_IRI.parse _namespace_name "HDTV_1080p" |> NamespacedName
    /// <summary>
    /// 720p is the shorthand name for a category of HDTV video modes. The number 720 stands for the 720 vertical scan lines of display resolution (also known as 720 pixels of vertical resolution), while the letter p stands for progressive scan or non-interlaced.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "720p" (http://en.wikipedia.org/wiki/720p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_720p"></see></summary>
    let HDTV_720p = Namespaced_IRI.parse _namespace_name "HDTV_720p" |> NamespacedName
    /// <summary>
    /// The business entity Hewlett-Packard Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP"></see></summary>
    let HP = Namespaced_IRI.parse _namespace_name "HP" |> NamespacedName

    /// <summary>
    /// Special printing technology invented and used by HP.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP_FastRes_1200_DPI"></see></summary>
    let HP_FastRes_1200_DPI =
        Namespaced_IRI.parse _namespace_name "HP_FastRes_1200_DPI" |> NamespacedName

    /// <summary>
    /// Defines the maximum digital resolution the device is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PrintResolution"></see></summary>
    let PrintResolution =
        Namespaced_IRI.parse _namespace_name "PrintResolution" |> NamespacedName

    /// <summary>
    /// Special printing technology invented and used by HP.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP_REt"></see></summary>
    let HP_REt = Namespaced_IRI.parse _namespace_name "HP_REt" |> NamespacedName
    /// <summary>
    /// The business entity Haier.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Haier"></see></summary>
    let Haier = Namespaced_IRI.parse _namespace_name "Haier" |> NamespacedName
    /// <summary>
    /// The business entity Hannspree.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hannspree"></see></summary>
    let Hannspree = Namespaced_IRI.parse _namespace_name "Hannspree" |> NamespacedName
    /// <summary>
    /// The business entity Harwa.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Harwa"></see></summary>
    let Harwa = Namespaced_IRI.parse _namespace_name "Harwa" |> NamespacedName

    /// <summary>
    /// Port to connect headphones with an electronical device. Here the port has the diameter of 2,5 millimetres.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HeadphoneLineOut_2.5mm"></see></summary>
    let ``HeadphoneLineOut_2.5mm`` =
        Namespaced_IRI.parse _namespace_name "HeadphoneLineOut_2.5mm" |> NamespacedName

    /// <summary>
    /// Port to connect headphones with an electronical device. Here the port has the diameter of 3,5 millimetres.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HeadphoneLineOut_3.5mm"></see></summary>
    let ``HeadphoneLineOut_3.5mm`` =
        Namespaced_IRI.parse _namespace_name "HeadphoneLineOut_3.5mm" |> NamespacedName

    /// <summary>
    /// A pair of small loudspeakers, or less commonly a single speaker, with a way of holding them close to a user's ears and a means of connecting them to a signal source such as an audio amplifier, radio or CD player.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Headphones"></see></summary>
    let Headphones = Namespaced_IRI.parse _namespace_name "Headphones" |> NamespacedName
    /// <summary>
    /// The business entity Hisense.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hisense"></see></summary>
    let Hisense = Namespaced_IRI.parse _namespace_name "Hisense" |> NamespacedName
    /// <summary>
    /// The business entity Hitachi.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hitachi"></see></summary>
    let Hitachi = Namespaced_IRI.parse _namespace_name "Hitachi" |> NamespacedName
    /// <summary>
    /// The business entity Humax.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Humax"></see></summary>
    let Humax = Namespaced_IRI.parse _namespace_name "Humax" |> NamespacedName
    /// <summary>
    /// Hyperband designates a range (band) of electromagnetic waves with frequencies between 300 MHz and 470 MHz. This is designated for kable TV especially to recieve digital TV normed for DVB-C.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hyperband"></see></summary>
    let Hyperband = Namespaced_IRI.parse _namespace_name "Hyperband" |> NamespacedName
    /// <summary>
    /// The business entity Hyundai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hyundai"></see></summary>
    let Hyundai = Namespaced_IRI.parse _namespace_name "Hyundai" |> NamespacedName
    /// <summary>
    /// The business entity IBM.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IBM"></see></summary>
    let IBM = Namespaced_IRI.parse _namespace_name "IBM" |> NamespacedName
    /// <summary>
    /// The IEEE 1394 interface is a serial bus interface standard for high-speed communications and isochronous real-time data transfer, frequently used by personal computers, as well as in digital audio, digital video, automotive, and aeronautics applications.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "firewire" (http://en.wikipedia.org/wiki/FireWire) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IEEE_1394"></see></summary>
    let IEEE_1394 = Namespaced_IRI.parse _namespace_name "IEEE_1394" |> NamespacedName

    /// <summary>
    /// IEEE 802.11 is a set of standards for wireless local area network (WLAN) computer communication, developed by the IEEE LAN/MAN Standards Committee (IEEE 802) in the 5 GHz and 2.4 GHz public spectrum bands.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "802.11" (http://en.wikipedia.org/wiki/802.11) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IEEE_802.11"></see></summary>
    let ``IEEE_802.11`` =
        Namespaced_IRI.parse _namespace_name "IEEE_802.11" |> NamespacedName

    /// <summary>
    /// Remote control with a electromagnetic radiation whose wavelength is longer than that of visible light (400-700 nm), but shorter than that of terahertz radiation (3-300 µm) and microwaves (~30,000 µm). Infrared radiation spans roughly three orders of magnitude (750 nm and 1000 µm)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IR_Remote"></see></summary>
    let IR_Remote = Namespaced_IRI.parse _namespace_name "IR_Remote" |> NamespacedName
    /// <summary>
    /// The business entity Iiyama.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Iiyama"></see></summary>
    let Iiyama = Namespaced_IRI.parse _namespace_name "Iiyama" |> NamespacedName
    /// <summary>
    /// The business entity InFocus.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InFocus"></see></summary>
    let InFocus = Namespaced_IRI.parse _namespace_name "InFocus" |> NamespacedName

    /// <summary>
    /// Psycho-acoustic method of widening the stereo spatial image especially suited for applications with limited separation of left and right speakers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IncredibleSurround"></see></summary>
    let IncredibleSurround =
        Namespaced_IRI.parse _namespace_name "IncredibleSurround" |> NamespacedName

    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IndoorWhiteBalance"></see></summary>
    let IndoorWhiteBalance =
        Namespaced_IRI.parse _namespace_name "IndoorWhiteBalance" |> NamespacedName

    /// <summary>
    /// The business entity InfoPrint.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InfoPrint"></see></summary>
    let InfoPrint = Namespaced_IRI.parse _namespace_name "InfoPrint" |> NamespacedName
    /// <summary>
    /// Infrared (IR) radiation is electromagnetic radiation whose wavelength is longer than that of visible light, but shorter than that of terahertz radiation and microwaves.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Infrared" (http://en.wikipedia.org/wiki/Infrared) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Infrared"></see></summary>
    let Infrared = Namespaced_IRI.parse _namespace_name "Infrared" |> NamespacedName

    /// <summary>
    /// Inkjet printers operate by propelling variably-sized droplets of liquid or molten material (ink) onto almost any sized page.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Inkjet printer" (http://en.wikipedia.org/wiki/Inkjet_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InkjetPrinter"></see></summary>
    let InkjetPrinter =
        Namespaced_IRI.parse _namespace_name "InkjetPrinter" |> NamespacedName

    /// <summary>
    /// A peripheral which produces a hard copy (permanent human-readable text and/or graphics) of documents stored in electronic form, usually on physical print media such as paper or transparencies.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Printer" (http://en.wikipedia.org/wiki/Computer_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Printer"></see></summary>
    let Printer = Namespaced_IRI.parse _namespace_name "Printer" |> NamespacedName

    /// <summary>
    /// Clock integrated in a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IntegratedClock"></see></summary>
    let IntegratedClock =
        Namespaced_IRI.parse _namespace_name "IntegratedClock" |> NamespacedName

    /// <summary>
    /// The business entity Intenso GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Intenso"></see></summary>
    let Intenso = Namespaced_IRI.parse _namespace_name "Intenso" |> NamespacedName

    /// <summary>
    /// Flash memory is non-volatile computer memory that can be electrically erased and reprogrammed.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InternalFlashMemory"></see></summary>
    let InternalFlashMemory =
        Namespaced_IRI.parse _namespace_name "InternalFlashMemory" |> NamespacedName

    /// <summary>
    /// Hard disk drive, a computer device which stores digitally encoded data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InternalHDD"></see></summary>
    let InternalHDD =
        Namespaced_IRI.parse _namespace_name "InternalHDD" |> NamespacedName

    /// <summary>
    /// The business entity Intuix LLC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Intuix"></see></summary>
    let Intuix = Namespaced_IRI.parse _namespace_name "Intuix" |> NamespacedName
    /// <summary>
    /// JPEG compression is used in a number of image file formats. JPEG/Exif is the most common image format used by digital cameras and other photographic image capture devices; along with JPEG/JFIF, it is the most common format for storing and transmitting photographic images on the World Wide Web.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "JPEG" (http://en.wikipedia.org/wiki/JPEG) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#JPEG"></see></summary>
    let JPEG = Namespaced_IRI.parse _namespace_name "JPEG" |> NamespacedName
    /// <summary>
    /// The business entity Victor Company of Japan, Limited.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#JVC"></see></summary>
    let JVC = Namespaced_IRI.parse _namespace_name "JVC" |> NamespacedName
    /// <summary>
    /// The business entity Eastman Kodak Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kodak"></see></summary>
    let Kodak = Namespaced_IRI.parse _namespace_name "Kodak" |> NamespacedName

    /// <summary>
    /// The business entity Konica Minolta.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Konica_Minolta"></see></summary>
    let Konica_Minolta =
        Namespaced_IRI.parse _namespace_name "Konica_Minolta" |> NamespacedName

    /// <summary>
    /// The business entity Genius, KYE Systems Corp.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kye_Genius"></see></summary>
    let Kye_Genius = Namespaced_IRI.parse _namespace_name "Kye_Genius" |> NamespacedName
    /// <summary>
    /// The business entity Kyocera.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kyocera"></see></summary>
    let Kyocera = Namespaced_IRI.parse _namespace_name "Kyocera" |> NamespacedName
    /// <summary>
    /// A liquid crystal display (LCD) is an electronically-modulated optical device shaped into a thin, flat panel made up of any number of color or monochrome pixels filled with liquid crystals and arrayed in front of a light source (backlight) or reflector.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Liquid crystal display" (http://en.wikipedia.org/wiki/Liquid_crystal_display) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LCD"></see></summary>
    let LCD = Namespaced_IRI.parse _namespace_name "LCD" |> NamespacedName
    /// <summary>
    /// The business entity LG Group.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LG"></see></summary>
    let LG = Namespaced_IRI.parse _namespace_name "LG" |> NamespacedName
    /// <summary>
    /// Media type that can be printed on one side and has a glued area on the other side.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Label"></see></summary>
    let Label = Namespaced_IRI.parse _namespace_name "Label" |> NamespacedName

    /// <summary>
    /// A label printer is a computer peripheral that prints on self-adhesive label material and sometimes card-stock (also called tags).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LabelPrinter"></see></summary>
    let LabelPrinter =
        Namespaced_IRI.parse _namespace_name "LabelPrinter" |> NamespacedName

    /// <summary>
    /// A laser printer is a common type of computer printer that rapidly produces high quality text and graphics on plain paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Laser printer" (http://en.wikipedia.org/wiki/Laser_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LaserPrinter"></see></summary>
    let LaserPrinter =
        Namespaced_IRI.parse _namespace_name "LaserPrinter" |> NamespacedName

    /// <summary>
    /// Special sort of paper used in laser printers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LaserPrintingPaper"></see></summary>
    let LaserPrintingPaper =
        Namespaced_IRI.parse _namespace_name "LaserPrintingPaper" |> NamespacedName

    /// <summary>
    /// The business entity LAVOD CORPORATION.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lavod"></see></summary>
    let Lavod = Namespaced_IRI.parse _namespace_name "Lavod" |> NamespacedName
    /// <summary>
    /// The business entity Lenco Audio-Video.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lenco"></see></summary>
    let Lenco = Namespaced_IRI.parse _namespace_name "Lenco" |> NamespacedName
    /// <summary>
    /// A lens is an optical device with perfect or approximate axial symmetry which transmits and refracts light, converging or diverging the beam.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lens (optics)" (http://en.wikipedia.org/wiki/Lens_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LensSystem"></see></summary>
    let LensSystem = Namespaced_IRI.parse _namespace_name "LensSystem" |> NamespacedName
    /// <summary>
    /// The business entity Lexar Media, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lexar"></see></summary>
    let Lexar = Namespaced_IRI.parse _namespace_name "Lexar" |> NamespacedName
    /// <summary>
    /// The business entity Lexmark.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lexmark"></see></summary>
    let Lexmark = Namespaced_IRI.parse _namespace_name "Lexmark" |> NamespacedName

    /// <summary>
    /// Lithium polymer batteries (abbreviated Li-poly, Li-Pol, LiPo, LIP, PLI or LiP) are rechargeable batteries which have technologically evolved from lithium-ion batteries.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lithium-polymer" (http://en.wikipedia.org/wiki/Lithium-polymer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Li-Ion_Polymer"></see></summary>
    let ``Li-Ion_Polymer`` =
        Namespaced_IRI.parse _namespace_name "Li-Ion_Polymer" |> NamespacedName

    /// <summary>
    /// A rechargeable battery is a kind of energy source that is able to be reused by refilling it with a charger.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RechargeableEnergySource"></see></summary>
    let RechargeableEnergySource =
        Namespaced_IRI.parse _namespace_name "RechargeableEnergySource" |> NamespacedName

    /// <summary>
    /// Is the total amount of light allowed to fall on the photographic medium during the process of taking a photograph.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LightExposureControl"></see></summary>
    let LightExposureControl =
        Namespaced_IRI.parse _namespace_name "LightExposureControl" |> NamespacedName

    /// <summary>
    /// Ability to record sounds via cable connection.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LineInRecorder"></see></summary>
    let LineInRecorder =
        Namespaced_IRI.parse _namespace_name "LineInRecorder" |> NamespacedName

    /// <summary>
    /// Linux is a generic term commonly used to refer to Unix-like computer operating systems which use the Linux kernel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Linux"></see></summary>
    let Linux = Namespaced_IRI.parse _namespace_name "Linux" |> NamespacedName
    /// <summary>
    /// Type of rechargeable battery in which a lithium ion moves between the anode and cathode.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lithium ion battery" (http://en.wikipedia.org/wiki/Lithium_ion_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lit-Ion"></see></summary>
    let ``Lit-Ion`` = Namespaced_IRI.parse _namespace_name "Lit-Ion" |> NamespacedName
    /// <summary>
    /// The business entity Logitech International S.A.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Logitech"></see></summary>
    let Logitech = Namespaced_IRI.parse _namespace_name "Logitech" |> NamespacedName
    /// <summary>
    /// A solid state disk or flash memory data storage device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MMC"></see></summary>
    let MMC = Namespaced_IRI.parse _namespace_name "MMC" |> NamespacedName
    /// <summary>
    /// The QuickTime (.mov) file format functions as a multimedia container file that contains one or more tracks, each of which stores a particular type of data: audio, video, effects, or text (e.g. for subtitles).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "QuickTime" (http://en.wikipedia.org/wiki/QuickTime) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MOV"></see></summary>
    let MOV = Namespaced_IRI.parse _namespace_name "MOV" |> NamespacedName
    /// <summary>
    /// A digital audio encoding format using a form of lossy data compression.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP3"></see></summary>
    let MP3 = Namespaced_IRI.parse _namespace_name "MP3" |> NamespacedName
    /// <summary>
    /// Playback equipment for certain data formats, especially audio data. Product is often equipped with some scope of delivery. Especially earphones, booklet, sotwareCD, charger and datacable.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP3Player"></see></summary>
    let MP3Player = Namespaced_IRI.parse _namespace_name "MP3Player" |> NamespacedName
    /// <summary>
    /// A collection of methods defining compression of audio digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP4_Audio"></see></summary>
    let MP4_Audio = Namespaced_IRI.parse _namespace_name "MP4_Audio" |> NamespacedName
    /// <summary>
    /// A collection of methods defining compression of video digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP4_Video"></see></summary>
    let MP4_Video = Namespaced_IRI.parse _namespace_name "MP4_Video" |> NamespacedName
    /// <summary>
    /// Includes all kinds of MPEG formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPEG"></see></summary>
    let MPEG = Namespaced_IRI.parse _namespace_name "MPEG" |> NamespacedName
    /// <summary>
    /// The business entity MPIO Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPIO"></see></summary>
    let MPIO = Namespaced_IRI.parse _namespace_name "MPIO" |> NamespacedName
    /// <summary>
    /// The business entity MPMAN Europe.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPMAN"></see></summary>
    let MPMAN = Namespaced_IRI.parse _namespace_name "MPMAN" |> NamespacedName
    /// <summary>
    /// The business entity Micro-Star Int'l Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MSI"></see></summary>
    let MSI = Namespaced_IRI.parse _namespace_name "MSI" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXCheetah"></see></summary>
    let MacOSXCheetah =
        Namespaced_IRI.parse _namespace_name "MacOSXCheetah" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXJaguar"></see></summary>
    let MacOSXJaguar =
        Namespaced_IRI.parse _namespace_name "MacOSXJaguar" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXLeopard"></see></summary>
    let MacOSXLeopard =
        Namespaced_IRI.parse _namespace_name "MacOSXLeopard" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXPanther"></see></summary>
    let MacOSXPanther =
        Namespaced_IRI.parse _namespace_name "MacOSXPanther" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXPuma"></see></summary>
    let MacOSXPuma = Namespaced_IRI.parse _namespace_name "MacOSXPuma" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXSnowLeopard"></see></summary>
    let MacOSXSnowLeopard =
        Namespaced_IRI.parse _namespace_name "MacOSXSnowLeopard" |> NamespacedName

    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXTiger"></see></summary>
    let MacOSXTiger =
        Namespaced_IRI.parse _namespace_name "MacOSXTiger" |> NamespacedName

    /// <summary>
    /// The business entity Maxfield GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Maxfield"></see></summary>
    let Maxfield = Namespaced_IRI.parse _namespace_name "Maxfield" |> NamespacedName

    /// <summary>
    /// Media format that is able to assume different shapes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormaPostcard"></see></summary>
    let MediaFormaPostcard =
        Namespaced_IRI.parse _namespace_name "MediaFormaPostcard" |> NamespacedName

    /// <summary>
    /// Media format that is able to assume different shapes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormatEnvelope"></see></summary>
    let MediaFormatEnvelope =
        Namespaced_IRI.parse _namespace_name "MediaFormatEnvelope" |> NamespacedName

    /// <summary>
    /// The business entity Medion AG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Medion"></see></summary>
    let Medion = Namespaced_IRI.parse _namespace_name "Medion" |> NamespacedName
    /// <summary>
    /// The business entity Memorex Products, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Memorex"></see></summary>
    let Memorex = Namespaced_IRI.parse _namespace_name "Memorex" |> NamespacedName

    /// <summary>
    /// Memory Stick is a removable flash memory card format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MemoryStick"></see></summary>
    let MemoryStick =
        Namespaced_IRI.parse _namespace_name "MemoryStick" |> NamespacedName

    /// <summary>
    /// The business entity Modul Burotic SAS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Memup"></see></summary>
    let Memup = Namespaced_IRI.parse _namespace_name "Memup" |> NamespacedName
    /// <summary>
    /// A miniature, 1-inch hard disk designed to fit in a CompactFlash (CF) Type II slot.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MicroDrive"></see></summary>
    let MicroDrive = Namespaced_IRI.parse _namespace_name "MicroDrive" |> NamespacedName
    /// <summary>
    /// Ability to record voices and sounds.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Microphon"></see></summary>
    let Microphon = Namespaced_IRI.parse _namespace_name "Microphon" |> NamespacedName
    /// <summary>
    /// The business entity Microsoft Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Microsoft"></see></summary>
    let Microsoft = Namespaced_IRI.parse _namespace_name "Microsoft" |> NamespacedName
    /// <summary>
    /// The non-standard Mini-USB's, official Mini-B, Micro-A, and Micro-B connectors are used for smaller devices such as PDAs, mobile phones or digital cameras. The Standard-A plug is approximately 4 by 12 mm, the Standard-B approximately 7 by 8 mm, and the Mini-A and Mini-B plugs approximately 2 by 7 mm.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Universial Serial Bus" (http://en.wikipedia.org/wiki/Universal_Serial_Bus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MiniUSB"></see></summary>
    let MiniUSB = Namespaced_IRI.parse _namespace_name "MiniUSB" |> NamespacedName
    /// <summary>
    /// The business entity Mirai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Mirai"></see></summary>
    let Mirai = Namespaced_IRI.parse _namespace_name "Mirai" |> NamespacedName
    /// <summary>
    /// Ability to display just two colors (black/white).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Monochrome"></see></summary>
    let Monochrome = Namespaced_IRI.parse _namespace_name "Monochrome" |> NamespacedName
    /// <summary>
    /// Ability to display more than two different kinds of color.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Multicolor"></see></summary>
    let Multicolor = Namespaced_IRI.parse _namespace_name "Multicolor" |> NamespacedName

    /// <summary>
    /// The body of the Product has more than one color.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MulticoloredBody"></see></summary>
    let MulticoloredBody =
        Namespaced_IRI.parse _namespace_name "MulticoloredBody" |> NamespacedName

    /// <summary>
    /// The business entity Mustek Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Mustek"></see></summary>
    let Mustek = Namespaced_IRI.parse _namespace_name "Mustek" |> NamespacedName
    /// <summary>
    /// The business entity NEC Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NEC"></see></summary>
    let NEC = Namespaced_IRI.parse _namespace_name "NEC" |> NamespacedName
    /// <summary>
    /// NICAM stands for Near Instantaneous Companded Audio Multiplex. It is an early form of lossy compression for digital audio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "NICAM" (http://en.wikipedia.org/wiki/NICAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NICAM"></see></summary>
    let NICAM = Namespaced_IRI.parse _namespace_name "NICAM" |> NamespacedName
    /// <summary>
    /// A nickel hydrogen battery (NIH2 or Ni-H2) is a rechargeable electrochemical power source based on nickel and hydrogen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NIH2"></see></summary>
    let NIH2 = Namespaced_IRI.parse _namespace_name "NIH2" |> NamespacedName
    /// <summary>
    /// NTSC (National Television Standard Conversion) is the analog television system used in most of the Americas, Japan, South Korea, Taiwan, the Philippines, Burma, and some Pacific island nations and territories.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "NTSC" (http://en.wikipedia.org/wiki/NTSC) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NTSC"></see></summary>
    let NTSC = Namespaced_IRI.parse _namespace_name "NTSC" |> NamespacedName
    /// <summary>
    /// The business entity Nanopoint Technology Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nanopoint"></see></summary>
    let Nanopoint = Namespaced_IRI.parse _namespace_name "Nanopoint" |> NamespacedName
    /// <summary>
    /// RGB Value 0,0,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Navy"></see></summary>
    let Navy = Namespaced_IRI.parse _namespace_name "Navy" |> NamespacedName
    /// <summary>
    /// The business entity NETGEAR, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Netgear"></see></summary>
    let Netgear = Namespaced_IRI.parse _namespace_name "Netgear" |> NamespacedName

    /// <summary>
    /// The business entity New Universe B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#New_Universe"></see></summary>
    let New_Universe =
        Namespaced_IRI.parse _namespace_name "New_Universe" |> NamespacedName

    /// <summary>
    /// A type of rechargeable battery using nickel oxide hydroxide and metallic cadmium as electrodes.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Nickel-cadmium battery" (http://en.wikipedia.org/wiki/Nickel-cadmium_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NiCd"></see></summary>
    let NiCd = Namespaced_IRI.parse _namespace_name "NiCd" |> NamespacedName
    /// <summary>
    /// A nickel-metal hydride battery, abbreviated NiMH, is a type of rechargeable battery similar to a nickel-cadmium (NiCd) battery but using a hydrogen-absorbing alloy for the negative electrode instead of cadmium.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Nickel metal hydride battery" (http://en.wikipedia.org/wiki/Nickel_metal_hydride_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NiMH"></see></summary>
    let NiMH = Namespaced_IRI.parse _namespace_name "NiMH" |> NamespacedName
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NightMode"></see></summary>
    let NightMode = Namespaced_IRI.parse _namespace_name "NightMode" |> NamespacedName
    /// <summary>
    /// The business entity Nikon Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nikon"></see></summary>
    let Nikon = Namespaced_IRI.parse _namespace_name "Nikon" |> NamespacedName
    /// <summary>
    /// The business entity Nintendo Company Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nintendo"></see></summary>
    let Nintendo = Namespaced_IRI.parse _namespace_name "Nintendo" |> NamespacedName

    /// <summary>
    /// Noise reduction is the process of removing noise from a signal.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NoiseReduction"></see></summary>
    let NoiseReduction =
        Namespaced_IRI.parse _namespace_name "NoiseReduction" |> NamespacedName

    /// <summary>
    /// The business entity Nokia Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nokia"></see></summary>
    let Nokia = Namespaced_IRI.parse _namespace_name "Nokia" |> NamespacedName
    /// <summary>
    /// The business entity ODYS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ODYS"></see></summary>
    let ODYS = Namespaced_IRI.parse _namespace_name "ODYS" |> NamespacedName
    /// <summary>
    /// Ogg is a free, open standard container format maintained by the Xiph.Org Foundation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OGG"></see></summary>
    let OGG = Namespaced_IRI.parse _namespace_name "OGG" |> NamespacedName
    /// <summary>
    /// The business entity Oki.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Oki"></see></summary>
    let Oki = Namespaced_IRI.parse _namespace_name "Oki" |> NamespacedName
    /// <summary>
    /// RGB Value 128,128,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olive"></see></summary>
    let Olive = Namespaced_IRI.parse _namespace_name "Olive" |> NamespacedName
    /// <summary>
    /// The business entity Olivetti.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olivetti"></see></summary>
    let Olivetti = Namespaced_IRI.parse _namespace_name "Olivetti" |> NamespacedName
    /// <summary>
    /// The business entity Olympus Europa Holding GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olympus"></see></summary>
    let Olympus = Namespaced_IRI.parse _namespace_name "Olympus" |> NamespacedName
    /// <summary>
    /// Describes the possibility to maintain a designated  time when the television or electrical device should be switched off or on automatically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OnOffTimer"></see></summary>
    let OnOffTimer = Namespaced_IRI.parse _namespace_name "OnOffTimer" |> NamespacedName

    /// <summary>
    /// An on-screen display (abbreviated OSD) is an image superimposed on a screen picture, commonly used by modern televisions, VCRs, and DVD players to display information such as volume, channel, and time.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "On-screen display" (http://en.wikipedia.org/wiki/On-screen_display) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OnScreenDisplay"></see></summary>
    let OnScreenDisplay =
        Namespaced_IRI.parse _namespace_name "OnScreenDisplay" |> NamespacedName

    /// <summary>
    /// A special lens system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OneStepFixed"></see></summary>
    let OneStepFixed =
        Namespaced_IRI.parse _namespace_name "OneStepFixed" |> NamespacedName

    /// <summary>
    /// The business entity Oppo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Oppo"></see></summary>
    let Oppo = Namespaced_IRI.parse _namespace_name "Oppo" |> NamespacedName
    /// <summary>
    /// RGB Value 255,165,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Orange"></see></summary>
    let Orange = Namespaced_IRI.parse _namespace_name "Orange" |> NamespacedName
    /// <summary>
    /// The business entity Orion.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Orion"></see></summary>
    let Orion = Namespaced_IRI.parse _namespace_name "Orion" |> NamespacedName

    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OutdoorWhiteBalance"></see></summary>
    let OutdoorWhiteBalance =
        Namespaced_IRI.parse _namespace_name "OutdoorWhiteBalance" |> NamespacedName

    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL"></see></summary>
    let PAL = Namespaced_IRI.parse _namespace_name "PAL" |> NamespacedName
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. This is used in western europe.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-B_G"></see></summary>
    let ``PAL-B_G`` = Namespaced_IRI.parse _namespace_name "PAL-B_G" |> NamespacedName
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. This is only used in Ireland, the UK, Hongkong and Macau.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-I"></see></summary>
    let ``PAL-I`` = Namespaced_IRI.parse _namespace_name "PAL-I" |> NamespacedName
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. PAL L is used on some hotel internal distribution systems, as well as other public display and plant television systems.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-L"></see></summary>
    let ``PAL-L`` = Namespaced_IRI.parse _namespace_name "PAL-L" |> NamespacedName
    /// <summary>
    /// Port to connect the audio cables for a PC with the electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCAudioIn"></see></summary>
    let PCAudioIn = Namespaced_IRI.parse _namespace_name "PCAudioIn" |> NamespacedName
    /// <summary>
    /// Port to connect a PC with the electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCIn"></see></summary>
    let PCIn = Namespaced_IRI.parse _namespace_name "PCIn" |> NamespacedName
    /// <summary>
    /// The Personal Computer Memory Card International Association is an international standards body that defines and promotes the PC Card (formerly known as "PCMCIA card") and ExpressCard standards. Although the organization's name refers to memory cards, their standards are not limited to memory devices. These cards can be used for wireless connectivity, modem and other functions in laptop/notebook PCs that may be lacking them natively.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PCMCIA" (http://en.wikipedia.org/wiki/PCMCIA) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCMCIA"></see></summary>
    let PCMCIA = Namespaced_IRI.parse _namespace_name "PCMCIA" |> NamespacedName
    /// <summary>
    /// Portable Document Format (PDF) is a file format created by Adobe Systems in 1993 for document exchange.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Pdf" (http://en.wikipedia.org/wiki/Pdf) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PDF"></see></summary>
    let PDF = Namespaced_IRI.parse _namespace_name "PDF" |> NamespacedName
    /// <summary>
    /// A plasma display panel (PDP) is a type of flat panel display common to large TV displays (37in. [940mm]). Many tiny cells between two panels of glass hold an inert mixture of noble gases. The gas in the cells is electrically turned into a plasma which then excites phosphors to emit light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital newspaper technology - Plasma" (http://en.wikipedia.org/wiki/Digital_newspaper_technology#Plasma) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PDP"></see></summary>
    let PDP = Namespaced_IRI.parse _namespace_name "PDP" |> NamespacedName
    /// <summary>
    /// The PNG (Portable Network Graphics) file format was created as the free, open-source successor to the GIF.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics file format" (http://en.wikipedia.org/wiki/Graphics_file_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PNG"></see></summary>
    let PNG = Namespaced_IRI.parse _namespace_name "PNG" |> NamespacedName
    /// <summary>
    /// The business entity Power Quotient International Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PQI"></see></summary>
    let PQI = Namespaced_IRI.parse _namespace_name "PQI" |> NamespacedName
    /// <summary>
    /// The .PSD (Photoshop Document) format stores an image with support for most imaging options available in Photoshop. These include layers with masks, color spaces, ICC profiles, transparency, text, alpha channels and spot colors, clipping paths, and duotone settings.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Adobe Photoshop" (http://en.wikipedia.org/wiki/Adobe_Photoshop) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PSD"></see></summary>
    let PSD = Namespaced_IRI.parse _namespace_name "PSD" |> NamespacedName

    /// <summary>
    /// The business entity Pacific Digital Home.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pacific_Digital"></see></summary>
    let Pacific_Digital =
        Namespaced_IRI.parse _namespace_name "Pacific_Digital" |> NamespacedName

    /// <summary>
    /// The business entity Packard Bell.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PackardBell"></see></summary>
    let PackardBell =
        Namespaced_IRI.parse _namespace_name "PackardBell" |> NamespacedName

    /// <summary>
    /// The business entity Palm Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Palm"></see></summary>
    let Palm = Namespaced_IRI.parse _namespace_name "Palm" |> NamespacedName
    /// <summary>
    /// The business entity Panasonic Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Panasonic"></see></summary>
    let Panasonic = Namespaced_IRI.parse _namespace_name "Panasonic" |> NamespacedName
    /// <summary>
    /// The business entity dynaTRON Electronics GmbH &amp; Co KG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pendrive"></see></summary>
    let Pendrive = Namespaced_IRI.parse _namespace_name "Pendrive" |> NamespacedName
    /// <summary>
    /// The business entity Pentax Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pentax"></see></summary>
    let Pentax = Namespaced_IRI.parse _namespace_name "Pentax" |> NamespacedName

    /// <summary>
    /// Perfect Pixel HD Engine offers the unique combination of ultimate sharpness, natural detail, vivid colours and smooth natural motion on all qualities of HD, standard TV signals and multimedia content, for high definition displays. Each pixel of the incoming picture is enhanced to better match the surrounding pixels, resulting in a more natural picture.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PerfectPixelHD"></see></summary>
    let PerfectPixelHD =
        Namespaced_IRI.parse _namespace_name "PerfectPixelHD" |> NamespacedName

    /// <summary>
    /// The business entity Koninklijke Philips Electronics N.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Philips"></see></summary>
    let Philips = Namespaced_IRI.parse _namespace_name "Philips" |> NamespacedName
    /// <summary>
    /// The business entity Phillar.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Phillar"></see></summary>
    let Phillar = Namespaced_IRI.parse _namespace_name "Phillar" |> NamespacedName
    /// <summary>
    /// The business entity Phoenix.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Phoenix"></see></summary>
    let Phoenix = Namespaced_IRI.parse _namespace_name "Phoenix" |> NamespacedName
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PhotoMode"></see></summary>
    let PhotoMode = Namespaced_IRI.parse _namespace_name "PhotoMode" |> NamespacedName

    /// <summary>
    /// A photo printer is a printer that is specifically designed to print high quality digital photos on photo paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photo printer" (http://en.wikipedia.org/wiki/Photo_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PhotoPrinter"></see></summary>
    let PhotoPrinter =
        Namespaced_IRI.parse _namespace_name "PhotoPrinter" |> NamespacedName

    /// <summary>
    /// Kind of paper that is specifically designed to print high quality digital photos.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Photopaper"></see></summary>
    let Photopaper = Namespaced_IRI.parse _namespace_name "Photopaper" |> NamespacedName
    /// <summary>
    /// Is an industry standard from the Camera &amp; Imaging Products Association (CIPA) for direct printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictBridge"></see></summary>
    let PictBridge = Namespaced_IRI.parse _namespace_name "PictBridge" |> NamespacedName

    /// <summary>
    /// Picture in Picture (PiP) is a feature of some television receivers and similar devices. One program (channel) is displayed on the full TV screen at the same time as one or more other programs are displayed in inset windows. Sound is usually from the main program only.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Picture in picture" (http://en.wikipedia.org/wiki/Picture-in-picture) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictureInPicture"></see></summary>
    let PictureInPicture =
        Namespaced_IRI.parse _namespace_name "PictureInPicture" |> NamespacedName

    /// <summary>
    /// Ability to display digital pictures.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictureViewing"></see></summary>
    let PictureViewing =
        Namespaced_IRI.parse _namespace_name "PictureViewing" |> NamespacedName

    /// <summary>
    /// RGB Value 255,192,203
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pink"></see></summary>
    let Pink = Namespaced_IRI.parse _namespace_name "Pink" |> NamespacedName
    /// <summary>
    /// The business entity Pioneer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pioneer"></see></summary>
    let Pioneer = Namespaced_IRI.parse _namespace_name "Pioneer" |> NamespacedName
    /// <summary>
    /// Pixelplus 2 is a technology which allows motion reinterpolation on 480p and 576p material.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlus2"></see></summary>
    let PixelPlus2 = Namespaced_IRI.parse _namespace_name "PixelPlus2" |> NamespacedName

    /// <summary>
    /// Pixel Plus 3 HD offers the unique combination of ultimate sharpness, natural detail, vivid colours and smooth natural motion on all qualities of HD, standard TV signals and multimedia content for high definition displays. Each pixel of the incoming picture is enhanced to better match the surrounding pixels, resulting in a more natural picture. Artefacts and noise in all sources from multimedia to standard TV and also in highly compressed HD are detected and reduced.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlus3HD"></see></summary>
    let PixelPlus3HD =
        Namespaced_IRI.parse _namespace_name "PixelPlus3HD" |> NamespacedName

    /// <summary>
    /// Pixel Plus HD is a picture processing technology that enables viewers to watch content that is vivid, natural and real.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlusHD"></see></summary>
    let PixelPlusHD =
        Namespaced_IRI.parse _namespace_name "PixelPlusHD" |> NamespacedName

    /// <summary>
    /// Thin material mainly used for writing upon, printing upon or packaging.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PlainPaper"></see></summary>
    let PlainPaper = Namespaced_IRI.parse _namespace_name "PlainPaper" |> NamespacedName
    /// <summary>
    /// Ability to put audiofiles in a playlist.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Playlist"></see></summary>
    let Playlist = Namespaced_IRI.parse _namespace_name "Playlist" |> NamespacedName

    /// <summary>
    /// Describes any hardware specification that alleviates the need for user configuration of device resources.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Legacy Plug and Play" (http://en.wikipedia.org/wiki/Legacy_Plug_and_Play) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PlugAndPlay"></see></summary>
    let PlugAndPlay =
        Namespaced_IRI.parse _namespace_name "PlugAndPlay" |> NamespacedName

    /// <summary>
    /// The business entity Polaroid.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Polaroid"></see></summary>
    let Polaroid = Namespaced_IRI.parse _namespace_name "Polaroid" |> NamespacedName
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Portrait"></see></summary>
    let Portrait = Namespaced_IRI.parse _namespace_name "Portrait" |> NamespacedName
    /// <summary>
    /// Rectangular piece of thick paper or thin cardboard intended for writing and mailing without an envelope.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Postcard"></see></summary>
    let Postcard = Namespaced_IRI.parse _namespace_name "Postcard" |> NamespacedName
    /// <summary>
    /// It is a semiconductor diode that emits light when an electric current is applied in the forward direction of the device used to show the power status of an electrical device.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "LED" (http://en.wikipedia.org/wiki/Led) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerLED"></see></summary>
    let PowerLED = Namespaced_IRI.parse _namespace_name "PowerLED" |> NamespacedName

    /// <summary>
    /// A RISC instruction set architecture created by the 1991 Apple-IBM-Motorola alliance, known as AIM. Originally intended for personal computers, PowerPC CPUs have since become popular embedded and high-performance processors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerPC_32_bit"></see></summary>
    let PowerPC_32_bit =
        Namespaced_IRI.parse _namespace_name "PowerPC_32_bit" |> NamespacedName

    /// <summary>
    /// The business entity Prestigio.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Prestigio"></see></summary>
    let Prestigio = Namespaced_IRI.parse _namespace_name "Prestigio" |> NamespacedName

    /// <summary>
    /// Progressive or noninterlaced scanning is a method for displaying, storing or transmitting moving images in which all the lines of each frame are drawn in sequence.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Progressive scan" (http://en.wikipedia.org/wiki/Progressive_scan) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ProgressiveScan"></see></summary>
    let ProgressiveScan =
        Namespaced_IRI.parse _namespace_name "ProgressiveScan" |> NamespacedName

    /// <summary>
    /// RGB Value 128,0,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Purple"></see></summary>
    let Purple = Namespaced_IRI.parse _namespace_name "Purple" |> NamespacedName
    /// <summary>
    /// An RF connector is an electrical connector designed to work at radio frequencies in the multi-megahertz range. RF connectors are typically used with coaxial cables and are designed to maintain the shielding that the coaxial design offers. Better models also minimize the change in transmission line impedance at the connection. Mechanically they provide a fastening mechanism (thread, bayonet, braces, push pull) and springs for a low ohmic electric contact while sparing the gold surface thus allowing above 1000 reconnects and reducing the insertion force. Research activity in the area of radio-frequency (RF) circuit design has surged in the last decade in direct response to the enormous market demand for inexpensive, high data rate wireless transceivers.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RF connector" (http://en.wikipedia.org/wiki/RF_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RF"></see></summary>
    let RF = Namespaced_IRI.parse _namespace_name "RF" |> NamespacedName
    /// <summary>
    /// The RGB color model is an additive color model in which red, green, and blue light are added together in various ways to reproduce a broad array of colors. The name of the model comes from the initials of the three additive primary colors, red, green, and blue. Typical RGB input devices are color TV and video cameras, image scanners, and digital cameras. Typical RGB output devices are TV sets of various technologies (CRT, LCD, plasma, etc.), computer and mobile phone displays, video projectors, multicolor LED displays, and large screens as JumboTron, etc. Color printers, on the other hand, are usually not RGB devices, but subtractive color devices (typically CMYK color model).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RGB" (http://en.wikipedia.org/wiki/RGB) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RGB"></see></summary>
    let RGB = Namespaced_IRI.parse _namespace_name "RGB" |> NamespacedName
    /// <summary>
    /// Reduced instruction set computing, represents a CPU design strategy emphasizing the insight that simplified instructions that "do less" may still provide for higher performance if this simplicity can be utilized to make instructions execute very quickly.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RISC"></see></summary>
    let RISC = Namespaced_IRI.parse _namespace_name "RISC" |> NamespacedName
    /// <summary>
    /// In telecommunications, RS-232 (Recommended Standard 232) is a standard for serial binary data signals connecting between a DTE (Data Terminal Equipment) and a DCE (Data Circuit-terminating Equipment). It is commonly used in computer serial ports.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RS-232" (http://en.wikipedia.org/wiki/RS-232) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RS-232"></see></summary>
    let ``RS-232`` = Namespaced_IRI.parse _namespace_name "RS-232" |> NamespacedName
    /// <summary>
    /// Ability to recieve radiosignal.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Radio"></see></summary>
    let Radio = Namespaced_IRI.parse _namespace_name "Radio" |> NamespacedName
    /// <summary>
    /// RGB Value 255,0,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Red"></see></summary>
    let Red = Namespaced_IRI.parse _namespace_name "Red" |> NamespacedName

    /// <summary>
    /// Defines the ability to precede the flash with a series of short, low-power flashes, or a continuous piercing bright light triggering the iris to contract.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RedEyeReduction"></see></summary>
    let RedEyeReduction =
        Namespaced_IRI.parse _namespace_name "RedEyeReduction" |> NamespacedName

    /// <summary>
    /// The business entity Ricatech B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ricatech"></see></summary>
    let Ricatech = Namespaced_IRI.parse _namespace_name "Ricatech" |> NamespacedName
    /// <summary>
    /// The business entity Ricoh.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ricoh"></see></summary>
    let Ricoh = Namespaced_IRI.parse _namespace_name "Ricoh" |> NamespacedName
    /// <summary>
    /// The Directive on the restriction of the use of certain hazardous substances in electrical and electronic equipment 2002/95/EC.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "ROHS" (http://en.wikipedia.org/wiki/ROHS) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RoHS"></see></summary>
    let RoHS = Namespaced_IRI.parse _namespace_name "RoHS" |> NamespacedName

    /// <summary>
    /// Is an analog video signal that carries the video data as two separate signals, lumen (luminance) and chroma (color).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "S-Video" (http://en.wikipedia.org/wiki/S-Video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#S-Video_in"></see></summary>
    let ``S-Video_in`` =
        Namespaced_IRI.parse _namespace_name "S-Video_in" |> NamespacedName

    /// <summary>
    /// Is an analog video signal that carries the video data as two separate signals, lumen (luminance) and chroma (color).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "S-Video" (http://en.wikipedia.org/wiki/S-Video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#S-Video_out"></see></summary>
    let ``S-Video_out`` =
        Namespaced_IRI.parse _namespace_name "S-Video_out" |> NamespacedName

    /// <summary>
    /// SCART (from Syndicat des Constructeurs d'Appareils Radiorécepteurs et Téléviseurs, Radio and Television Receiver Manufacturer's Association) is a French-originated standard and associated 21-pin connector for connecting audio-visual (AV) equipment together.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SCART" (http://en.wikipedia.org/wiki/SCART) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SCART"></see></summary>
    let SCART = Namespaced_IRI.parse _namespace_name "SCART" |> NamespacedName
    /// <summary>
    /// A flash memory card format used in portable device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SD"></see></summary>
    let SD = Namespaced_IRI.parse _namespace_name "SD" |> NamespacedName
    /// <summary>
    /// SDHC (Secure Digital High Capacity, SD 2.0) is an extension of the SD standard that appeared in June 2006.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Secure Digital card" (http://en.wikipedia.org/wiki/Secure_Digital_card) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDHC"></see></summary>
    let SDHC = Namespaced_IRI.parse _namespace_name "SDHC" |> NamespacedName
    /// <summary>
    /// 480i is the shorthand name for a video mode, namely the U.S. NTSC television system or digital television systems with the same characteristics. The i, which is sometimes uppercase, stands for interlaced, the 480 for a vertical frame resolution of 480 lines containing picture information; while NTSC has a total of 525 lines, only 480 of these are used to display the image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "480i" (http://en.wikipedia.org/wiki/480i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDTV_480i"></see></summary>
    let SDTV_480i = Namespaced_IRI.parse _namespace_name "SDTV_480i" |> NamespacedName
    /// <summary>
    /// 576i is a standard-definition video mode used in (former) PAL and SECAM countries. In digital applications it's usually referred to as "576i", in analogue contexts it's often quoted as "625 lines". The 576 identifies a vertical resolution of 576 lines (usually with a horizontal resolution of 720 or 704 pixels), and the i identifies it as an interlaced resolution.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "576ii" (http://en.wikipedia.org/wiki/576i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDTV_576i"></see></summary>
    let SDTV_576i = Namespaced_IRI.parse _namespace_name "SDTV_576i" |> NamespacedName
    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM"></see></summary>
    let SECAM = Namespaced_IRI.parse _namespace_name "SECAM" |> NamespacedName

    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. SECAM-B/G is used in the Middle East, former East Germany and Greece.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-B_G"></see></summary>
    let ``SECAM-B_G`` =
        Namespaced_IRI.parse _namespace_name "SECAM-B_G" |> NamespacedName

    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. SECAM D/K is used in the Commonwealth of Independent States and Eastern Europe (this is simply SECAM used with the D and K monochrome TV transmission standards).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-D_K"></see></summary>
    let ``SECAM-D_K`` =
        Namespaced_IRI.parse _namespace_name "SECAM-D_K" |> NamespacedName

    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. French SECAM (SECAM-L) is used only in France, Luxembourg (only RTL9 on CH 21 from Dudelange) and Tele Monte-Carlo Transmitters in the south of France.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-L"></see></summary>
    let ``SECAM-L`` = Namespaced_IRI.parse _namespace_name "SECAM-L" |> NamespacedName
    /// <summary>
    /// The business entity SIGMA GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SIGMA"></see></summary>
    let SIGMA = Namespaced_IRI.parse _namespace_name "SIGMA" |> NamespacedName
    /// <summary>
    /// The business entity SMS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SMS"></see></summary>
    let SMS = Namespaced_IRI.parse _namespace_name "SMS" |> NamespacedName
    /// <summary>
    /// SVG (Scalable Vector Graphics) is an open standard created and developed by the World Wide Web Consortium to address the need (and attempts of several corporations) for a versatile, scriptable and all-purpose vector format for the web and otherwise.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Vector graphics" (http://en.wikipedia.org/wiki/Vector_graphics) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SVG"></see></summary>
    let SVG = Namespaced_IRI.parse _namespace_name "SVG" |> NamespacedName
    /// <summary>
    /// The business entity Sagem.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sagem"></see></summary>
    let Sagem = Namespaced_IRI.parse _namespace_name "Sagem" |> NamespacedName
    /// <summary>
    /// The business entity Salora.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Salora"></see></summary>
    let Salora = Namespaced_IRI.parse _namespace_name "Salora" |> NamespacedName
    /// <summary>
    /// The business entity Samsung Group.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Samsung"></see></summary>
    let Samsung = Namespaced_IRI.parse _namespace_name "Samsung" |> NamespacedName
    /// <summary>
    /// The business entity SanDisk Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SanDisk"></see></summary>
    let SanDisk = Namespaced_IRI.parse _namespace_name "SanDisk" |> NamespacedName
    /// <summary>
    /// The business entity Sanyo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sanyo"></see></summary>
    let Sanyo = Namespaced_IRI.parse _namespace_name "Sanyo" |> NamespacedName
    /// <summary>
    /// The business entity Sapphire Technology Limited
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sapphire"></see></summary>
    let Sapphire = Namespaced_IRI.parse _namespace_name "Sapphire" |> NamespacedName

    /// <summary>
    /// Includes the possibility to switch between different screen formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ScreenFormatAdjustments"></see></summary>
    let ScreenFormatAdjustments =
        Namespaced_IRI.parse _namespace_name "ScreenFormatAdjustments" |> NamespacedName

    /// <summary>
    /// The business entity Seiko.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Seiko"></see></summary>
    let Seiko = Namespaced_IRI.parse _namespace_name "Seiko" |> NamespacedName
    /// <summary>
    /// Ability to give a delay between the pressing of the shutter release and the shutter firing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SelfTimer"></see></summary>
    let SelfTimer = Namespaced_IRI.parse _namespace_name "SelfTimer" |> NamespacedName

    /// <summary>
    /// 3CCD is a term used to describe an imaging system employed by some still cameras, video cameras, telecine and camcorders.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Three-CCD" (http://en.wikipedia.org/wiki/Three-CCD) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SensorType_3CCD"></see></summary>
    let SensorType_3CCD =
        Namespaced_IRI.parse _namespace_name "SensorType_3CCD" |> NamespacedName

    /// <summary>
    /// The business entity SHARKOON Technologies GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sharkoon"></see></summary>
    let Sharkoon = Namespaced_IRI.parse _namespace_name "Sharkoon" |> NamespacedName
    /// <summary>
    /// The business entity Sharp.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sharp"></see></summary>
    let Sharp = Namespaced_IRI.parse _namespace_name "Sharp" |> NamespacedName
    /// <summary>
    /// Ability to play files in random order.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Shuffle"></see></summary>
    let Shuffle = Namespaced_IRI.parse _namespace_name "Shuffle" |> NamespacedName
    /// <summary>
    /// A television tuner converts an RF television transmission into audio and video signals which can be further processed to produce sound and a picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVTuner"></see></summary>
    let TVTuner = Namespaced_IRI.parse _namespace_name "TVTuner" |> NamespacedName
    /// <summary>
    /// RGB Value 192,192,192
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Silver"></see></summary>
    let Silver = Namespaced_IRI.parse _namespace_name "Silver" |> NamespacedName
    /// <summary>
    /// The business entity Sitecom
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sitecom"></see></summary>
    let Sitecom = Namespaced_IRI.parse _namespace_name "Sitecom" |> NamespacedName
    /// <summary>
    /// A sleep timer is a function on many modern televisions that shut off the power after a preset amount of time. The setting is usually made either from the remote control or the television menus. They are intended to allow viewers to watch as they fall asleep.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sleep timer" (http://en.wikipedia.org/wiki/Sleep_timer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SleepTimer"></see></summary>
    let SleepTimer = Namespaced_IRI.parse _namespace_name "SleepTimer" |> NamespacedName

    /// <summary>
    /// SmartMedia is a flash memory card standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SmartMediaCard"></see></summary>
    let SmartMediaCard =
        Namespaced_IRI.parse _namespace_name "SmartMediaCard" |> NamespacedName

    /// <summary>
    /// SmartSound’s technology benefits television producers and editors by giving enhanced creative options through special music technology that delivers multiple musical variations for different moods.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SmartSoundControl"></see></summary>
    let SmartSoundControl =
        Namespaced_IRI.parse _namespace_name "SmartSoundControl" |> NamespacedName

    /// <summary>
    /// The business entity Verbatim Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Smartdisk"></see></summary>
    let Smartdisk = Namespaced_IRI.parse _namespace_name "Smartdisk" |> NamespacedName
    /// <summary>
    /// Is a shot that is aimed and fired very quickly at a target that appears suddenly and for a very short period of time.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Snapshot"></see></summary>
    let Snapshot = Namespaced_IRI.parse _namespace_name "Snapshot" |> NamespacedName
    /// <summary>
    /// Solar cell or photovoltaic cell is a wide area electronic device that converts solar energy into electricity by the photovoltaic effect.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Solar cell" (http://en.wikipedia.org/wiki/Solar_cell) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Solar"></see></summary>
    let Solar = Namespaced_IRI.parse _namespace_name "Solar" |> NamespacedName
    /// <summary>
    /// The business entity Sony Corporation
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sony"></see></summary>
    let Sony = Namespaced_IRI.parse _namespace_name "Sony" |> NamespacedName
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sports"></see></summary>
    let Sports = Namespaced_IRI.parse _namespace_name "Sports" |> NamespacedName
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Spotlight"></see></summary>
    let Spotlight = Namespaced_IRI.parse _namespace_name "Spotlight" |> NamespacedName
    /// <summary>
    /// It is a semiconductor diode that emits light when an electric current is applied in the forward direction of the device used to show the standby status of an electrical device.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "LED" (http://en.wikipedia.org/wiki/Led) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#StandbyLED"></see></summary>
    let StandbyLED = Namespaced_IRI.parse _namespace_name "StandbyLED" |> NamespacedName

    /// <summary>
    /// A connection port for a subwoover. Subwoofer is a woofer, or a complete loudspeaker dedicated to the reproduction of bass audio frequencies, from perhaps 150 Hz down as far as 20 Hz, or in rare cases lower.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Subwoofer" (http://en.wikipedia.org/wiki/Subwoofer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SubwooferOut"></see></summary>
    let SubwooferOut =
        Namespaced_IRI.parse _namespace_name "SubwooferOut" |> NamespacedName

    /// <summary>
    /// The business entity Sweex.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sweex"></see></summary>
    let Sweex = Namespaced_IRI.parse _namespace_name "Sweex" |> NamespacedName
    /// <summary>
    /// The business entity TEAC Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TEAC"></see></summary>
    let TEAC = Namespaced_IRI.parse _namespace_name "TEAC" |> NamespacedName
    /// <summary>
    /// The TIFF (Tagged Image File Format) is a flexible format that normally saves 8 bits or 16 bits per color (red, green, blue) for 24-bit and 48-bit totals, respectively, using either the TIFF or the TIF filenames.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics file format" (http://en.wikipedia.org/wiki/Graphics_file_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TIFF"></see></summary>
    let TIFF = Namespaced_IRI.parse _namespace_name "TIFF" |> NamespacedName

    /// <summary>
    /// A TRS connector (tip, ring, sleeve) also called an audio jack, phone plug, jack plug, stereo plug, mini-jack, or mini-stereo, is a common audio connector. It is cylindrical in shape, typically with three contacts, although sometimes with two (a TS connector) or four (a TRRS connector).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "TRS connector" (http://en.wikipedia.org/wiki/TRS_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TRSConnector"></see></summary>
    let TRSConnector =
        Namespaced_IRI.parse _namespace_name "TRSConnector" |> NamespacedName

    /// <summary>
    /// The business entity TRUST International B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TRUST"></see></summary>
    let TRUST = Namespaced_IRI.parse _namespace_name "TRUST" |> NamespacedName
    /// <summary>
    /// Television (TV) is a widely used telecommunication medium for transmitting and receiving moving images, either monochromatic ("black and white") or color, usually accompanied by sound. Is often deliverd with a remote control and a manual.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "TV" (http://en.wikipedia.org/wiki/Tv) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TV"></see></summary>
    let TV = Namespaced_IRI.parse _namespace_name "TV" |> NamespacedName
    /// <summary>
    /// Is a filename extension for files consisting of text usually contain very little formatting.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TXT"></see></summary>
    let TXT = Namespaced_IRI.parse _namespace_name "TXT" |> NamespacedName
    /// <summary>
    /// The business entity takeMS International AG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TakeMS"></see></summary>
    let TakeMS = Namespaced_IRI.parse _namespace_name "TakeMS" |> NamespacedName

    /// <summary>
    /// The business entity TallyGenicom.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TallyGenicom"></see></summary>
    let TallyGenicom =
        Namespaced_IRI.parse _namespace_name "TallyGenicom" |> NamespacedName

    /// <summary>
    /// The business entity Tatung Co.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Tatung"></see></summary>
    let Tatung = Namespaced_IRI.parse _namespace_name "Tatung" |> NamespacedName
    /// <summary>
    /// The business entity TechniSat.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TechniSat"></see></summary>
    let TechniSat = Namespaced_IRI.parse _namespace_name "TechniSat" |> NamespacedName
    /// <summary>
    /// The business entity Techsolo Europe B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Techsolo"></see></summary>
    let Techsolo = Namespaced_IRI.parse _namespace_name "Techsolo" |> NamespacedName
    /// <summary>
    /// The business entity Tektronix.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Tektronix"></see></summary>
    let Tektronix = Namespaced_IRI.parse _namespace_name "Tektronix" |> NamespacedName

    /// <summary>
    /// Teletext (or "broadcast Teletext") is a television information retrieval service developed in the United Kingdom in the early 1970s. It offers a range of text-based information, typically including national, international and sporting news, weather and TV schedules.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Teletext" (http://en.wikipedia.org/wiki/Teletext) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TeletextFunction"></see></summary>
    let TeletextFunction =
        Namespaced_IRI.parse _namespace_name "TeletextFunction" |> NamespacedName

    /// <summary>
    /// Ability to display text.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TextViewing"></see></summary>
    let TextViewing =
        Namespaced_IRI.parse _namespace_name "TextViewing" |> NamespacedName

    /// <summary>
    /// The business entity The Thomson Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Thomson"></see></summary>
    let Thomson = Namespaced_IRI.parse _namespace_name "Thomson" |> NamespacedName
    /// <summary>
    /// A timer is a specialized type of clock counting backwards to a predefined end.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Timer" (http://en.wikipedia.org/wiki/Timer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Timer"></see></summary>
    let Timer = Namespaced_IRI.parse _namespace_name "Timer" |> NamespacedName
    /// <summary>
    /// The business entity Toshiba Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Toshiba"></see></summary>
    let Toshiba = Namespaced_IRI.parse _namespace_name "Toshiba" |> NamespacedName
    /// <summary>
    /// The business entity Transcend Information, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Transcend"></see></summary>
    let Transcend = Namespaced_IRI.parse _namespace_name "Transcend" |> NamespacedName

    /// <summary>
    /// A thin sheet of transparent flexible material, typically cellulose acetate, onto which you can print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Transparency"></see></summary>
    let Transparency =
        Namespaced_IRI.parse _namespace_name "Transparency" |> NamespacedName

    /// <summary>
    /// The business entity TrekStore GmbH &amp; Co. KG
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TrekStor"></see></summary>
    let TrekStor = Namespaced_IRI.parse _namespace_name "TrekStor" |> NamespacedName
    /// <summary>
    /// The business entity TwinMOS Technologies Inc
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TwinMOS"></see></summary>
    let TwinMOS = Namespaced_IRI.parse _namespace_name "TwinMOS" |> NamespacedName
    /// <summary>
    /// The business entity COS Distribution GmbH
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Typhoon"></see></summary>
    let Typhoon = Namespaced_IRI.parse _namespace_name "Typhoon" |> NamespacedName
    /// <summary>
    /// Ultra high frequency (UHF) designates a range (band) of electromagnetic waves with frequencies between 300 MHz and 3 GHz (3,000 MHz).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "UHF" (http://en.wikipedia.org/wiki/UHF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#UHF"></see></summary>
    let UHF = Namespaced_IRI.parse _namespace_name "UHF" |> NamespacedName
    /// <summary>
    /// Universal Serial Bus (USB) is a serial bus standard to connect devices to a host computer.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Universal Serial Bus" (http://en.wikipedia.org/wiki/Universal_Serial_Bus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB"></see></summary>
    let USB = Namespaced_IRI.parse _namespace_name "USB" |> NamespacedName
    /// <summary>
    /// Specified data rates of 1.5 Mbit/s and 12 Mbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB1.0"></see></summary>
    let ``USB1.0`` = Namespaced_IRI.parse _namespace_name "USB1.0" |> NamespacedName
    /// <summary>
    /// Maximum speed of 480 Mbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB2.0"></see></summary>
    let ``USB2.0`` = Namespaced_IRI.parse _namespace_name "USB2.0" |> NamespacedName
    /// <summary>
    /// Maximum speed of 4,8 Gbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB3.0"></see></summary>
    let ``USB3.0`` = Namespaced_IRI.parse _namespace_name "USB3.0" |> NamespacedName

    /// <summary>
    /// USB-interface used to provide power to low-consumption devices without the need for an external power supply.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USBEnergyInterface"></see></summary>
    let USBEnergyInterface =
        Namespaced_IRI.parse _namespace_name "USBEnergyInterface" |> NamespacedName

    /// <summary>
    /// A serial bus standard to connect devices to a host computer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB_Cable"></see></summary>
    let USB_Cable = Namespaced_IRI.parse _namespace_name "USB_Cable" |> NamespacedName
    /// <summary>
    /// The business entity Videoseven.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#V7"></see></summary>
    let V7 = Namespaced_IRI.parse _namespace_name "V7" |> NamespacedName
    /// <summary>
    /// VHF (Very high frequency) is the radio frequency range from 30 MHz to 300 MHz.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "VHF" (http://en.wikipedia.org/wiki/VHF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VHF"></see></summary>
    let VHF = Namespaced_IRI.parse _namespace_name "VHF" |> NamespacedName
    /// <summary>
    /// The business entity VIVOTEK Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VIVOTEK"></see></summary>
    let VIVOTEK = Namespaced_IRI.parse _namespace_name "VIVOTEK" |> NamespacedName
    /// <summary>
    /// The business entity Verbatim Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Verbatim"></see></summary>
    let Verbatim = Namespaced_IRI.parse _namespace_name "Verbatim" |> NamespacedName
    /// <summary>
    /// The business entity Vestel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Vestel"></see></summary>
    let Vestel = Namespaced_IRI.parse _namespace_name "Vestel" |> NamespacedName
    /// <summary>
    /// The business entity Victory Niederland B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Victory"></see></summary>
    let Victory = Namespaced_IRI.parse _namespace_name "Victory" |> NamespacedName

    /// <summary>
    /// A video signal that has been split into two or more components.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoComponent_Cable"></see></summary>
    let VideoComponent_Cable =
        Namespaced_IRI.parse _namespace_name "VideoComponent_Cable" |> NamespacedName

    /// <summary>
    /// Ability to display video files.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoPlayBack"></see></summary>
    let VideoPlayBack =
        Namespaced_IRI.parse _namespace_name "VideoPlayBack" |> NamespacedName

    /// <summary>
    /// Ability to record videos.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoRecording"></see></summary>
    let VideoRecording =
        Namespaced_IRI.parse _namespace_name "VideoRecording" |> NamespacedName

    /// <summary>
    /// A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinder"></see></summary>
    let ViewFinder = Namespaced_IRI.parse _namespace_name "ViewFinder" |> NamespacedName

    /// <summary>
    /// An electronic viewfinder or EVF is a viewfinder where the image captured by the lens is projected electronically onto a miniature display. The image on this display is used to assist in aiming the camera at the scene to be photographed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Electronic viewfinder" (http://en.wikipedia.org/wiki/Electronic_viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinderElectronic"></see></summary>
    let ViewFinderElectronic =
        Namespaced_IRI.parse _namespace_name "ViewFinderElectronic" |> NamespacedName

    /// <summary>
    /// An optical viewfinder is simply a reversed telescope mounted to see what the camera will see.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinderOptical"></see></summary>
    let ViewFinderOptical =
        Namespaced_IRI.parse _namespace_name "ViewFinderOptical" |> NamespacedName

    /// <summary>
    /// The business entity ViewSonic.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewSonic"></see></summary>
    let ViewSonic = Namespaced_IRI.parse _namespace_name "ViewSonic" |> NamespacedName
    /// <summary>
    /// The business entity Viewpia.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Viewpia"></see></summary>
    let Viewpia = Namespaced_IRI.parse _namespace_name "Viewpia" |> NamespacedName
    /// <summary>
    /// The business entity Vivitar Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Vivitar"></see></summary>
    let Vivitar = Namespaced_IRI.parse _namespace_name "Vivitar" |> NamespacedName

    /// <summary>
    /// Ability to record sounds with a micro.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VoiceRecording"></see></summary>
    let VoiceRecording =
        Namespaced_IRI.parse _namespace_name "VoiceRecording" |> NamespacedName

    /// <summary>
    /// WAV (or WAVE), short for Waveform audio format, is a Microsoft and IBM audio file format standard for storing an audio bitstream on PCs.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "WAV" (http://en.wikipedia.org/wiki/WAV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WAV"></see></summary>
    let WAV = Namespaced_IRI.parse _namespace_name "WAV" |> NamespacedName
    /// <summary>
    /// An audio data compression technology developed by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WMA"></see></summary>
    let WMA = Namespaced_IRI.parse _namespace_name "WMA" |> NamespacedName
    /// <summary>
    /// A compressed video file format for several proprietary codecs developed by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WMV"></see></summary>
    let WMV = Namespaced_IRI.parse _namespace_name "WMV" |> NamespacedName
    /// <summary>
    /// RGB Value 255,255,255
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#White"></see></summary>
    let White = Namespaced_IRI.parse _namespace_name "White" |> NamespacedName
    /// <summary>
    /// Ability to filter out wind noises.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindFilter"></see></summary>
    let WindFilter = Namespaced_IRI.parse _namespace_name "WindFilter" |> NamespacedName

    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows2000"></see></summary>
    let Windows2000 =
        Namespaced_IRI.parse _namespace_name "Windows2000" |> NamespacedName

    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows2003"></see></summary>
    let Windows2003 =
        Namespaced_IRI.parse _namespace_name "Windows2003" |> NamespacedName

    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows95"></see></summary>
    let Windows95 = Namespaced_IRI.parse _namespace_name "Windows95" |> NamespacedName
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows98"></see></summary>
    let Windows98 = Namespaced_IRI.parse _namespace_name "Windows98" |> NamespacedName
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsME"></see></summary>
    let WindowsME = Namespaced_IRI.parse _namespace_name "WindowsME" |> NamespacedName
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsNT"></see></summary>
    let WindowsNT = Namespaced_IRI.parse _namespace_name "WindowsNT" |> NamespacedName

    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsVista"></see></summary>
    let WindowsVista =
        Namespaced_IRI.parse _namespace_name "WindowsVista" |> NamespacedName

    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsXP"></see></summary>
    let WindowsXP = Namespaced_IRI.parse _namespace_name "WindowsXP" |> NamespacedName

    /// <summary>
    /// The xD-Picture Card is a type of flash memory card.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#XDPictureCard"></see></summary>
    let XDPictureCard =
        Namespaced_IRI.parse _namespace_name "XDPictureCard" |> NamespacedName

    /// <summary>
    /// The business entity Xerox.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Xerox"></see></summary>
    let Xerox = Namespaced_IRI.parse _namespace_name "Xerox" |> NamespacedName
    /// <summary>
    /// YPbPR is the analog video signal carried by component video cable in consumer electronics. The green cable carries Y, the blue cable carries PB and the red cable carries PR.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "YPbPr" (http://en.wikipedia.org/wiki/YPbPr) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#YPbPr"></see></summary>
    let YPbPr = Namespaced_IRI.parse _namespace_name "YPbPr" |> NamespacedName
    /// <summary>
    /// The business entity Yakumo GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yakumo"></see></summary>
    let Yakumo = Namespaced_IRI.parse _namespace_name "Yakumo" |> NamespacedName
    /// <summary>
    /// RGB Value 255,255,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yellow"></see></summary>
    let Yellow = Namespaced_IRI.parse _namespace_name "Yellow" |> NamespacedName
    /// <summary>
    /// The business entity Yukai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yukai"></see></summary>
    let Yukai = Namespaced_IRI.parse _namespace_name "Yukai" |> NamespacedName
    /// <summary>
    /// The business entity Yuraku.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yuraku"></see></summary>
    let Yuraku = Namespaced_IRI.parse _namespace_name "Yuraku" |> NamespacedName
    /// <summary>
    /// The business entity Yusmart.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yusmart"></see></summary>
    let Yusmart = Namespaced_IRI.parse _namespace_name "Yusmart" |> NamespacedName
    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Zoom"></see></summary>
    let Zoom = Namespaced_IRI.parse _namespace_name "Zoom" |> NamespacedName

    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ZoomDigital"></see></summary>
    let ZoomDigital =
        Namespaced_IRI.parse _namespace_name "ZoomDigital" |> NamespacedName

    /// <summary>
    /// An optical zoom is a mechanical assembly of lens elements with the ability to vary its focal length (and thus angle of view), as opposed to a fixed focal length (FFL) lens (see prime lens).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Zoom lens" (http://en.wikipedia.org/wiki/Zoom_lens) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ZoomOptical"></see></summary>
    let ZoomOptical =
        Namespaced_IRI.parse _namespace_name "ZoomOptical" |> NamespacedName

    /// <summary>
    /// Defines an optical lens or assembly of lenses used in conjunction with a camera body and mechanism to make images of objects either on photographic film or on other media capable of storing an image chemically or electronically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#has35mmCameraLensEquivalentRange"></see></summary>
    let has35mmCameraLensEquivalentRange =
        Namespaced_IRI.parse _namespace_name "has35mmCameraLensEquivalentRange" |> NamespacedName

    /// <summary>
    /// Defines subordinate or supplementary items.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAccessory"></see></summary>
    let hasAccessory =
        Namespaced_IRI.parse _namespace_name "hasAccessory" |> NamespacedName

    /// <summary>
    /// Defines whether an analog video signal is supported.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAnalogVideoSignal"></see></summary>
    let hasAnalogVideoSignal =
        Namespaced_IRI.parse _namespace_name "hasAnalogVideoSignal" |> NamespacedName

    /// <summary>
    /// Defines the hole or an opening through which light is admitted.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasApertureRange"></see></summary>
    let hasApertureRange =
        Namespaced_IRI.parse _namespace_name "hasApertureRange" |> NamespacedName

    /// <summary>
    /// The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the longer one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioHorizontal"></see></summary>
    let hasAspectRatioHorizontal =
        Namespaced_IRI.parse _namespace_name "hasAspectRatioHorizontal" |> NamespacedName

    /// <summary>
    /// The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the shorter one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioVertical"></see></summary>
    let hasAspectRatioVertical =
        Namespaced_IRI.parse _namespace_name "hasAspectRatioVertical" |> NamespacedName

    /// <summary>
    /// Defines which audio input devices can be used with this object.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInputSource"></see></summary>
    let hasAudioInputSource =
        Namespaced_IRI.parse _namespace_name "hasAudioInputSource" |> NamespacedName

    /// <summary>
    /// Defines the type of interfaces used to transfer audio signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInterfaceType"></see></summary>
    let hasAudioInterfaceType =
        Namespaced_IRI.parse _namespace_name "hasAudioInterfaceType" |> NamespacedName

    /// <summary>
    /// Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioOutputPower"></see></summary>
    let hasAudioOutputPower =
        Namespaced_IRI.parse _namespace_name "hasAudioOutputPower" |> NamespacedName

    /// <summary>
    /// Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOutputPower"></see></summary>
    let hasOutputPower =
        Namespaced_IRI.parse _namespace_name "hasOutputPower" |> NamespacedName

    /// <summary>
    /// Total time needed to fully recharge a completely discharged rechargeable energy source for this mp3 player (Common unit of measurement hour, HUR).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatteryRechargeTime"></see></summary>
    let hasBatteryRechargeTime =
        Namespaced_IRI.parse _namespace_name "hasBatteryRechargeTime" |> NamespacedName

    /// <summary>
    /// Defines the size of used energy source. (Use ASIN code here. For more information we refer to http://en.wikipedia.org/wiki/List_of_battery_sizes)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatterySize"></see></summary>
    let hasBatterySize =
        Namespaced_IRI.parse _namespace_name "hasBatterySize" |> NamespacedName

    /// <summary>
    /// Defines the major color of an objects body.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBodyColor"></see></summary>
    let hasBodyColor =
        Namespaced_IRI.parse _namespace_name "hasBodyColor" |> NamespacedName

    /// <summary>
    /// Defines the type of certificate of a product used to attest quality standards.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCertificate"></see></summary>
    let hasCertificate =
        Namespaced_IRI.parse _namespace_name "hasCertificate" |> NamespacedName

    /// <summary>
    /// Defines the number of channels of a television that can be used to save specific transmitted signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasChannelQuantity"></see></summary>
    let hasChannelQuantity =
        Namespaced_IRI.parse _namespace_name "hasChannelQuantity" |> NamespacedName

    /// <summary>
    /// In photography and image processing, color balance is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White balance" (http://en.wikipedia.org/wiki/White_balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasColorBalance"></see></summary>
    let hasColorBalance =
        Namespaced_IRI.parse _namespace_name "hasColorBalance" |> NamespacedName

    /// <summary>
    /// Defines the possible external operating systems to communicate with.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCompatibleOperatingSystem"></see></summary>
    let hasCompatibleOperatingSystem =
        Namespaced_IRI.parse _namespace_name "hasCompatibleOperatingSystem" |> NamespacedName

    /// <summary>
    /// Defines the possibilities to connect different kinds of electronical devices.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasConnectivity"></see></summary>
    let hasConnectivity =
        Namespaced_IRI.parse _namespace_name "hasConnectivity" |> NamespacedName

    /// <summary>
    /// The contrast ratio is a measure of a display system, defined as the ratio of the luminance of the brightest color (white) to that of the darkest color (black) that the system is capable of producing.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Contrast ratio" (http://en.wikipedia.org/wiki/Contrast_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasContrastRatio"></see></summary>
    let hasContrastRatio =
        Namespaced_IRI.parse _namespace_name "hasContrastRatio" |> NamespacedName

    /// <summary>
    /// Defines the support of a generic term that refers to access control technologies used by hardware manufacturers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDRMSupport"></see></summary>
    let hasDRMSupport =
        Namespaced_IRI.parse _namespace_name "hasDRMSupport" |> NamespacedName

    /// <summary>
    /// Defines the supported data formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataFormat"></see></summary>
    let hasDataFormat =
        Namespaced_IRI.parse _namespace_name "hasDataFormat" |> NamespacedName

    /// <summary>
    /// Defines the type of interfaces used to exchange data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataInterfaceType"></see></summary>
    let hasDataInterfaceType =
        Namespaced_IRI.parse _namespace_name "hasDataInterfaceType" |> NamespacedName

    /// <summary>
    /// Defines the distance from side to side, measuring across the object at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepth"></see></summary>
    let hasDepth = Namespaced_IRI.parse _namespace_name "hasDepth" |> NamespacedName

    /// <summary>
    /// Defines the distance from side to side, measuring across the object with its stand at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepthWithStand"></see></summary>
    let hasDepthWithStand =
        Namespaced_IRI.parse _namespace_name "hasDepthWithStand" |> NamespacedName

    /// <summary>
    /// Digital frequency is the analogue for discrete signals as frequency is to continuous signals (Common unit of measurement hertz, HTZ).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital frequency" (http://en.wikipedia.org/wiki/Digital_frequency) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalFrequency"></see></summary>
    let hasDigitalFrequency =
        Namespaced_IRI.parse _namespace_name "hasDigitalFrequency" |> NamespacedName

    /// <summary>
    /// Speed of the process of converting an analog video signal—such as that produced by a video camera or DVD player—to digital form.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalVideoCaptureSpeed"></see></summary>
    let hasDigitalVideoCaptureSpeed =
        Namespaced_IRI.parse _namespace_name "hasDigitalVideoCaptureSpeed" |> NamespacedName

    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoom"></see></summary>
    let hasDigitalZoom =
        Namespaced_IRI.parse _namespace_name "hasDigitalZoom" |> NamespacedName

    /// <summary>
    /// Defines the stages an object can be zoomed digitally.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoomFactor"></see></summary>
    let hasDigitalZoomFactor =
        Namespaced_IRI.parse _namespace_name "hasDigitalZoomFactor" |> NamespacedName

    /// <summary>
    /// Defines if object includes a screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplay"></see></summary>
    let hasDisplay = Namespaced_IRI.parse _namespace_name "hasDisplay" |> NamespacedName

    /// <summary>
    /// Defines the brightness of a display or screen. Brightness is an attribute of visual perception in which a source appears to be radiating or reflecting light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Brightness" (http://en.wikipedia.org/wiki/Brightness) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayBrightness"></see></summary>
    let hasDisplayBrightness =
        Namespaced_IRI.parse _namespace_name "hasDisplayBrightness" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionHorizontal"></see></summary>
    let hasDisplayResolutionHorizontal =
        Namespaced_IRI.parse _namespace_name "hasDisplayResolutionHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionVertical"></see></summary>
    let hasDisplayResolutionVertical =
        Namespaced_IRI.parse _namespace_name "hasDisplayResolutionVertical" |> NamespacedName

    /// <summary>
    /// Defines the diagonal length from the upper left to the lower right angle (Common unit of measurement centimetre, CMT; or inch, INH).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplaySize"></see></summary>
    let hasDisplaySize =
        Namespaced_IRI.parse _namespace_name "hasDisplaySize" |> NamespacedName

    /// <summary>
    /// Defines the type of the display like LCD or Plasma.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayType"></see></summary>
    let hasDisplayType =
        Namespaced_IRI.parse _namespace_name "hasDisplayType" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasDraftPrintableResolutionBlackWhiteHorizontal =
        Namespaced_IRI.parse _namespace_name "hasDraftPrintableResolutionBlackWhiteHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasDraftPrintableResolutionBlackWhiteVertical =
        Namespaced_IRI.parse _namespace_name "hasDraftPrintableResolutionBlackWhiteVertical" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorHorizontal"></see></summary>
    let hasDraftPrintableResolutionColorHorizontal =
        Namespaced_IRI.parse _namespace_name "hasDraftPrintableResolutionColorHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorVertical"></see></summary>
    let hasDraftPrintableResolutionColorVertical =
        Namespaced_IRI.parse _namespace_name "hasDraftPrintableResolutionColorVertical" |> NamespacedName

    /// <summary>
    /// Amount of time the printer needs to start printing the first page.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDurationToPrintFirstPage"></see></summary>
    let hasDurationToPrintFirstPage =
        Namespaced_IRI.parse _namespace_name "hasDurationToPrintFirstPage" |> NamespacedName

    /// <summary>
    /// Describes whether or not the product is equipped with features that allow economical printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEconomicPrintMode"></see></summary>
    let hasEconomicPrintMode =
        Namespaced_IRI.parse _namespace_name "hasEconomicPrintMode" |> NamespacedName

    /// <summary>
    /// Defines the used energy source.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnergySource"></see></summary>
    let hasEnergySource =
        Namespaced_IRI.parse _namespace_name "hasEnergySource" |> NamespacedName

    /// <summary>
    /// Indicates wheter this feature is available on this product.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnvelopeFeeder"></see></summary>
    let hasEnvelopeFeeder =
        Namespaced_IRI.parse _namespace_name "hasEnvelopeFeeder" |> NamespacedName

    /// <summary>
    /// Defines the possibility to vary the audio presentation of sound.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizer"></see></summary>
    let hasEqualizer =
        Namespaced_IRI.parse _namespace_name "hasEqualizer" |> NamespacedName

    /// <summary>
    /// Defines the number of supported equalizers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizerBandsQuantity"></see></summary>
    let hasEqualizerBandsQuantity =
        Namespaced_IRI.parse _namespace_name "hasEqualizerBandsQuantity" |> NamespacedName

    /// <summary>
    /// Defines the ability to add devices (e.g. cards) to maximize the storage capacity.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasExpansionSlot"></see></summary>
    let hasExpansionSlot =
        Namespaced_IRI.parse _namespace_name "hasExpansionSlot" |> NamespacedName

    /// <summary>
    /// Defines the type of special functions the object is capable of.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFeature"></see></summary>
    let hasFeature = Namespaced_IRI.parse _namespace_name "hasFeature" |> NamespacedName
    /// <summary>
    /// Device for instantaneous illumination for picture taking.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFlash"></see></summary>
    let hasFlash = Namespaced_IRI.parse _namespace_name "hasFlash" |> NamespacedName

    /// <summary>
    /// Defines a measure of how strongly it converges (focuses) or diverges (diffuses) light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focal length" (http://en.wikipedia.org/wiki/Focal_length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocalLength"></see></summary>
    let hasFocalLength =
        Namespaced_IRI.parse _namespace_name "hasFocalLength" |> NamespacedName

    /// <summary>
    /// A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocus"></see></summary>
    let hasFocus = Namespaced_IRI.parse _namespace_name "hasFocus" |> NamespacedName

    /// <summary>
    /// Focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocusSize"></see></summary>
    let hasFocusSize =
        Namespaced_IRI.parse _namespace_name "hasFocusSize" |> NamespacedName

    /// <summary>
    /// Defines the range of supported frequency signals (Common unit of measurement megahertz, MHZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFrequencyRange"></see></summary>
    let hasFrequencyRange =
        Namespaced_IRI.parse _namespace_name "hasFrequencyRange" |> NamespacedName

    /// <summary>
    /// Defines the measurement of vertical distance (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeight"></see></summary>
    let hasHeight = Namespaced_IRI.parse _namespace_name "hasHeight" |> NamespacedName

    /// <summary>
    /// Defines the measurement of vertical distance of an object with its stand (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeightWithStand"></see></summary>
    let hasHeightWithStand =
        Namespaced_IRI.parse _namespace_name "hasHeightWithStand" |> NamespacedName

    /// <summary>
    /// Defines the support of information such as the title, artist, album, track number, or other information about the file to be stored in the file itself.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasID3Support"></see></summary>
    let hasID3Support =
        Namespaced_IRI.parse _namespace_name "hasID3Support" |> NamespacedName

    /// <summary>
    /// Defines the capacity to store data on internal memory (Common unit of measurement Megabyte, 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasInternalMemoryCapacity"></see></summary>
    let hasInternalMemoryCapacity =
        Namespaced_IRI.parse _namespace_name "hasInternalMemoryCapacity" |> NamespacedName

    /// <summary>
    /// Defines the perfect or approximate axial symmetry which transmits and refracts light.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLensSystem"></see></summary>
    let hasLensSystem =
        Namespaced_IRI.parse _namespace_name "hasLensSystem" |> NamespacedName

    /// <summary>
    /// Defines the total amount of light allowed to fall on the photographic medium (photographic film or image sensor) during the process of taking a photograph.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLightExposureControl"></see></summary>
    let hasLightExposureControl =
        Namespaced_IRI.parse _namespace_name "hasLightExposureControl" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig best quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedBestQuality"></see></summary>
    let hasMaxBlackWhitePrintSpeedBestQuality =
        Namespaced_IRI.parse _namespace_name "hasMaxBlackWhitePrintSpeedBestQuality" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig of drafts.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedDraft"></see></summary>
    let hasMaxBlackWhitePrintSpeedDraft =
        Namespaced_IRI.parse _namespace_name "hasMaxBlackWhitePrintSpeedDraft" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig normal quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedNormal"></see></summary>
    let hasMaxBlackWhitePrintSpeedNormal =
        Namespaced_IRI.parse _namespace_name "hasMaxBlackWhitePrintSpeedNormal" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig best quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedBestQuality"></see></summary>
    let hasMaxColorPrintSpeedBestQuality =
        Namespaced_IRI.parse _namespace_name "hasMaxColorPrintSpeedBestQuality" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig of drafts.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedDraft"></see></summary>
    let hasMaxColorPrintSpeedDraft =
        Namespaced_IRI.parse _namespace_name "hasMaxColorPrintSpeedDraft" |> NamespacedName

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig normal quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedNormal"></see></summary>
    let hasMaxColorPrintSpeedNormal =
        Namespaced_IRI.parse _namespace_name "hasMaxColorPrintSpeedNormal" |> NamespacedName

    /// <summary>
    /// Maximum number of sheets the device can hold in all available standard and optional output trays.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacity"></see></summary>
    let hasMaxInputCapacity =
        Namespaced_IRI.parse _namespace_name "hasMaxInputCapacity" |> NamespacedName

    /// <summary>
    /// Defines the maximum ability to hold for envelopes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacityForEnvelopes"></see></summary>
    let hasMaxInputCapacityForEnvelopes =
        Namespaced_IRI.parse _namespace_name "hasMaxInputCapacityForEnvelopes" |> NamespacedName

    /// <summary>
    /// Defines the maximum amount of memory that can be installed in the systems hardware (common unit of measurement: megabyte(MB): 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInternalMemoryCapacity"></see></summary>
    let hasMaxInternalMemoryCapacity =
        Namespaced_IRI.parse _namespace_name "hasMaxInternalMemoryCapacity" |> NamespacedName

    /// <summary>
    /// Defines the maximum size of the printed media format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaFormat"></see></summary>
    let hasMaxMediaFormat =
        Namespaced_IRI.parse _namespace_name "hasMaxMediaFormat" |> NamespacedName

    /// <summary>
    /// Describes the maximum weight of the media format (Common unit of measurement gram per square metre, GM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaWeight"></see></summary>
    let hasMaxMediaWeight =
        Namespaced_IRI.parse _namespace_name "hasMaxMediaWeight" |> NamespacedName

    /// <summary>
    /// Defines the maxium capacity that can be provided by using external memory (Common unit of measurement megabyte, 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMemoryCapacity"></see></summary>
    let hasMaxMemoryCapacity =
        Namespaced_IRI.parse _namespace_name "hasMaxMemoryCapacity" |> NamespacedName

    /// <summary>
    /// Defines the maximum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOperatingTemperature"></see></summary>
    let hasMaxOperatingTemperature =
        Namespaced_IRI.parse _namespace_name "hasMaxOperatingTemperature" |> NamespacedName

    /// <summary>
    /// Maximum number of sheets the product can hold in all available standard and optional output trays.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOutputCapacity"></see></summary>
    let hasMaxOutputCapacity =
        Namespaced_IRI.parse _namespace_name "hasMaxOutputCapacity" |> NamespacedName

    /// <summary>
    /// Describes the maximum printed sites per month.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintCapacity"></see></summary>
    let hasMaxPrintCapacity =
        Namespaced_IRI.parse _namespace_name "hasMaxPrintCapacity" |> NamespacedName

    /// <summary>
    /// Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasMaxPrintableResolutionBlackWhiteHorizontal =
        Namespaced_IRI.parse _namespace_name "hasMaxPrintableResolutionBlackWhiteHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasMaxPrintableResolutionBlackWhiteVertical =
        Namespaced_IRI.parse _namespace_name "hasMaxPrintableResolutionBlackWhiteVertical" |> NamespacedName

    /// <summary>
    /// Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorHorizontal"></see></summary>
    let hasMaxPrintableResolutionColorHorizontal =
        Namespaced_IRI.parse _namespace_name "hasMaxPrintableResolutionColorHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorVertical"></see></summary>
    let hasMaxPrintableResolutionColorVertical =
        Namespaced_IRI.parse _namespace_name "hasMaxPrintableResolutionColorVertical" |> NamespacedName

    /// <summary>
    /// Defines the maximum level of relative humidity, non-condensing, within which the product can operate.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxRelativeHumidity"></see></summary>
    let hasMaxRelativeHumidity =
        Namespaced_IRI.parse _namespace_name "hasMaxRelativeHumidity" |> NamespacedName

    /// <summary>
    /// Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 1.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray1"></see></summary>
    let hasMediaWeightTray1 =
        Namespaced_IRI.parse _namespace_name "hasMediaWeightTray1" |> NamespacedName

    /// <summary>
    /// Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 2.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray2"></see></summary>
    let hasMediaWeightTray2 =
        Namespaced_IRI.parse _namespace_name "hasMediaWeightTray2" |> NamespacedName

    /// <summary>
    /// Minimum deliberate application of light to achieve some aesthetic or practical effect (common unit of measurement: Lux; LUX).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinIllumination"></see></summary>
    let hasMinIllumination =
        Namespaced_IRI.parse _namespace_name "hasMinIllumination" |> NamespacedName

    /// <summary>
    /// Describes the minimum weight of the media format (Common unit of measurement gram per square metre, GM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinMediaWeight"></see></summary>
    let hasMinMediaWeight =
        Namespaced_IRI.parse _namespace_name "hasMinMediaWeight" |> NamespacedName

    /// <summary>
    /// Defines the minimum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinOperatingTemperature"></see></summary>
    let hasMinOperatingTemperature =
        Namespaced_IRI.parse _namespace_name "hasMinOperatingTemperature" |> NamespacedName

    /// <summary>
    /// Defines the minimum level of relative humidity, non-condensing, within which the product can operate.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinRelativeHumidity"></see></summary>
    let hasMinRelativeHumidity =
        Namespaced_IRI.parse _namespace_name "hasMinRelativeHumidity" |> NamespacedName

    /// <summary>
    /// Ability to connect the product to a network.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNetworkAbility"></see></summary>
    let hasNetworkAbility =
        Namespaced_IRI.parse _namespace_name "hasNetworkAbility" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasNormalPrintableResolutionBlackWhiteHorizontal =
        Namespaced_IRI.parse _namespace_name "hasNormalPrintableResolutionBlackWhiteHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the  digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasNormalPrintableResolutionBlackWhiteVertical =
        Namespaced_IRI.parse _namespace_name "hasNormalPrintableResolutionBlackWhiteVertical" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorHorizontal"></see></summary>
    let hasNormalPrintableResolutionColorHorizontal =
        Namespaced_IRI.parse _namespace_name "hasNormalPrintableResolutionColorHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorVertical"></see></summary>
    let hasNormalPrintableResolutionColorVertical =
        Namespaced_IRI.parse _namespace_name "hasNormalPrintableResolutionColorVertical" |> NamespacedName

    /// <summary>
    /// Defines the number of component video ports a device offers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfComponentVideoPorts"></see></summary>
    let hasNumberOfComponentVideoPorts =
        Namespaced_IRI.parse _namespace_name "hasNumberOfComponentVideoPorts" |> NamespacedName

    /// <summary>
    /// Defines the number of colors an electronical device is able to display on a screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfDisplayColors"></see></summary>
    let hasNumberOfDisplayColors =
        Namespaced_IRI.parse _namespace_name "hasNumberOfDisplayColors" |> NamespacedName

    /// <summary>
    /// Number of compact audio/video interface ports for transmitting uncompressed digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHDMIPorts"></see></summary>
    let hasNumberOfHDMIPorts =
        Namespaced_IRI.parse _namespace_name "hasNumberOfHDMIPorts" |> NamespacedName

    /// <summary>
    /// Defines the number of hypertext pages that can be displayed on the main screen of a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHyptertextPages"></see></summary>
    let hasNumberOfHyptertextPages =
        Namespaced_IRI.parse _namespace_name "hasNumberOfHyptertextPages" |> NamespacedName

    /// <summary>
    /// Counts the trays which feed the printer with paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfInputPaperTrays"></see></summary>
    let hasNumberOfInputPaperTrays =
        Namespaced_IRI.parse _namespace_name "hasNumberOfInputPaperTrays" |> NamespacedName

    /// <summary>
    /// Defines the available languages that can be chosen to be displayed on the main screen of a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfOnScreenLanguages"></see></summary>
    let hasNumberOfOnScreenLanguages =
        Namespaced_IRI.parse _namespace_name "hasNumberOfOnScreenLanguages" |> NamespacedName

    /// <summary>
    /// Number of replaceable components of a printer that contains the ink that is spread on paper during printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfPrintCartridges"></see></summary>
    let hasNumberOfPrintCartridges =
        Namespaced_IRI.parse _namespace_name "hasNumberOfPrintCartridges" |> NamespacedName

    /// <summary>
    /// Defines the number of trays able to hold sheets of paper to be printed.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfStandardInputTrays"></see></summary>
    let hasNumberOfStandardInputTrays =
        Namespaced_IRI.parse _namespace_name "hasNumberOfStandardInputTrays" |> NamespacedName

    /// <summary>
    /// Average time the object operates (Common unit of measurement hour, HUR).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOperatingTime"></see></summary>
    let hasOperatingTime =
        Namespaced_IRI.parse _namespace_name "hasOperatingTime" |> NamespacedName

    /// <summary>
    /// Describes the ability of an imaging system to resolve detail in the object that is being imaged.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorResolution"></see></summary>
    let hasOpticalSensorResolution =
        Namespaced_IRI.parse _namespace_name "hasOpticalSensorResolution" |> NamespacedName

    /// <summary>
    /// Size of the device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument (common unit of measurement: inch; INH).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorSize"></see></summary>
    let hasOpticalSensorSize =
        Namespaced_IRI.parse _namespace_name "hasOpticalSensorSize" |> NamespacedName

    /// <summary>
    /// Defines a method of decreasing (narrowing) the apparent angle of view of a digital photographic or video image with a higher optical resolution than the digital zoom.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoom"></see></summary>
    let hasOpticalZoom =
        Namespaced_IRI.parse _namespace_name "hasOpticalZoom" |> NamespacedName

    /// <summary>
    /// Defines the stages an object can be zoomed optically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoomFactor"></see></summary>
    let hasOpticalZoomFactor =
        Namespaced_IRI.parse _namespace_name "hasOpticalZoomFactor" |> NamespacedName

    /// <summary>
    /// Defines the distance from side to side, measuring across the object with its package at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageDepth"></see></summary>
    let hasPackageDepth =
        Namespaced_IRI.parse _namespace_name "hasPackageDepth" |> NamespacedName

    /// <summary>
    /// Defines the measurement of vertical distance of an object with its package (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageHeight"></see></summary>
    let hasPackageHeight =
        Namespaced_IRI.parse _namespace_name "hasPackageHeight" |> NamespacedName

    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object with its package (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWeight"></see></summary>
    let hasPackageWeight =
        Namespaced_IRI.parse _namespace_name "hasPackageWeight" |> NamespacedName

    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end with its package (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWidth"></see></summary>
    let hasPackageWidth =
        Namespaced_IRI.parse _namespace_name "hasPackageWidth" |> NamespacedName

    /// <summary>
    /// Defines the supported paper formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPaperFormat"></see></summary>
    let hasPaperFormat =
        Namespaced_IRI.parse _namespace_name "hasPaperFormat" |> NamespacedName

    /// <summary>
    /// Size of a camera accessory consisting of an optical filter that can be inserted in the optical path.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photographic filter" (http://en.wikipedia.org/wiki/Photographic_filter) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPhotographicFilterSize"></see></summary>
    let hasPhotographicFilterSize =
        Namespaced_IRI.parse _namespace_name "hasPhotographicFilterSize" |> NamespacedName

    /// <summary>
    /// Defines that an electronical screen can display minimum two pictures on one screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureInPicture"></see></summary>
    let hasPictureInPicture =
        Namespaced_IRI.parse _namespace_name "hasPictureInPicture" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the pictures (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureResolution"></see></summary>
    let hasPictureResolution =
        Namespaced_IRI.parse _namespace_name "hasPictureResolution" |> NamespacedName

    /// <summary>
    /// Defines the requirements of power an electronical device needs to operate (Common unit of measurement Ampere, AMP).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsAC"></see></summary>
    let hasPowerRequirementsAC =
        Namespaced_IRI.parse _namespace_name "hasPowerRequirementsAC" |> NamespacedName

    /// <summary>
    /// Defines the power requirements of an electronical device (Common unit of measurement hertz, HTZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsHTZ"></see></summary>
    let hasPowerRequirementsHTZ =
        Namespaced_IRI.parse _namespace_name "hasPowerRequirementsHTZ" |> NamespacedName

    /// <summary>
    /// Defines the area which can not be printed on the bottom side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderBottom"></see></summary>
    let hasPrintBorderBottom =
        Namespaced_IRI.parse _namespace_name "hasPrintBorderBottom" |> NamespacedName

    /// <summary>
    /// Defines the area which can not be printed on the left side of a paper (DIN A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderLeft"></see></summary>
    let hasPrintBorderLeft =
        Namespaced_IRI.parse _namespace_name "hasPrintBorderLeft" |> NamespacedName

    /// <summary>
    /// Defines the area which can not be printed on the right side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderRight"></see></summary>
    let hasPrintBorderRight =
        Namespaced_IRI.parse _namespace_name "hasPrintBorderRight" |> NamespacedName

    /// <summary>
    /// Defines the area which can not be printed on the top side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderTop"></see></summary>
    let hasPrintBorderTop =
        Namespaced_IRI.parse _namespace_name "hasPrintBorderTop" |> NamespacedName

    /// <summary>
    /// Defines the frequency of the clock in any synchronous circuit (common unit of measurement: hertz, HTZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorClockSpeed"></see></summary>
    let hasProcessorClockSpeed =
        Namespaced_IRI.parse _namespace_name "hasProcessorClockSpeed" |> NamespacedName

    /// <summary>
    /// The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorType"></see></summary>
    let hasProcessorType =
        Namespaced_IRI.parse _namespace_name "hasProcessorType" |> NamespacedName

    /// <summary>
    /// The red-eye effect in photography is the common appearance of red pupils in color photographs of eyes. The red-eye reduction feature reduces the red-eye effect.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasRedEyeReduction"></see></summary>
    let hasRedEyeReduction =
        Namespaced_IRI.parse _namespace_name "hasRedEyeReduction" |> NamespacedName

    /// <summary>
    /// Defines the type of resolution a screen is able to display.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResolution"></see></summary>
    let hasResolution =
        Namespaced_IRI.parse _namespace_name "hasResolution" |> NamespacedName

    /// <summary>
    /// Defines the time an electronical device needs to react on a signal (Common unit of measurement millisecond, C26).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResponseTime"></see></summary>
    let hasResponseTime =
        Namespaced_IRI.parse _namespace_name "hasResponseTime" |> NamespacedName

    /// <summary>
    /// Defines a projection of information from any physical environment into any sensory system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSceneMode"></see></summary>
    let hasSceneMode =
        Namespaced_IRI.parse _namespace_name "hasSceneMode" |> NamespacedName

    /// <summary>
    /// Defines whether the product is able  to give a delay between the pressing of the shutter release and the shutter firing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSelfTimer"></see></summary>
    let hasSelfTimer =
        Namespaced_IRI.parse _namespace_name "hasSelfTimer" |> NamespacedName

    /// <summary>
    /// Defines type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSensorType"></see></summary>
    let hasSensorType =
        Namespaced_IRI.parse _namespace_name "hasSensorType" |> NamespacedName

    /// <summary>
    /// Defines the delay between triggering the shutter and when the photograph is actually recorded (Common unit of measurement seconds, SEC).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasShutterLag"></see></summary>
    let hasShutterLag =
        Namespaced_IRI.parse _namespace_name "hasShutterLag" |> NamespacedName

    /// <summary>
    /// Defines the ability to use a mode that saves significant electrical consumption compared to leaving a device fully on and idle but allows the user to avoid having to reset programming codes (Common unit of measurement Watt, WTT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sleep mode" (http://en.wikipedia.org/wiki/Sleep_mode) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSleepModePowerConsumption"></see></summary>
    let hasSleepModePowerConsumption =
        Namespaced_IRI.parse _namespace_name "hasSleepModePowerConsumption" |> NamespacedName

    /// <summary>
    /// Level of sound power during the printing (Common unit of measurement decibel, 2N).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSoundEmission"></see></summary>
    let hasSoundEmission =
        Namespaced_IRI.parse _namespace_name "hasSoundEmission" |> NamespacedName

    /// <summary>
    /// Defines the number of integrated speakers an object includes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSpeakerQuantity"></see></summary>
    let hasSpeakerQuantity =
        Namespaced_IRI.parse _namespace_name "hasSpeakerQuantity" |> NamespacedName

    /// <summary>
    /// Amount of sheets the product can hold as standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardInputCapacity"></see></summary>
    let hasStandardInputCapacity =
        Namespaced_IRI.parse _namespace_name "hasStandardInputCapacity" |> NamespacedName

    /// <summary>
    /// Number of sheets the product can hold in all available output trays as a standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacity"></see></summary>
    let hasStandardOutputCapacity =
        Namespaced_IRI.parse _namespace_name "hasStandardOutputCapacity" |> NamespacedName

    /// <summary>
    /// Defines the maximum amount of envelopes the product is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForEnvelopes"></see></summary>
    let hasStandardOutputCapacityForEnvelopes =
        Namespaced_IRI.parse _namespace_name "hasStandardOutputCapacityForEnvelopes" |> NamespacedName

    /// <summary>
    /// Defines the maximum amount of transparancies the product is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForTransperancies"></see></summary>
    let hasStandardOutputCapacityForTransperancies =
        Namespaced_IRI.parse _namespace_name "hasStandardOutputCapacityForTransperancies" |> NamespacedName

    /// <summary>
    /// Defines the amount of consumed energy while the device is in the standby mode (Common unit of measurement Watt, WTT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandbyPowerConsumption"></see></summary>
    let hasStandbyPowerConsumption =
        Namespaced_IRI.parse _namespace_name "hasStandbyPowerConsumption" |> NamespacedName

    /// <summary>
    /// Defines the type of storage media the object uses to store data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStorageMedia"></see></summary>
    let hasStorageMedia =
        Namespaced_IRI.parse _namespace_name "hasStorageMedia" |> NamespacedName

    /// <summary>
    /// Defines the possibilty to rotate or turn an object into different directions (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSwivel"></see></summary>
    let hasSwivel = Namespaced_IRI.parse _namespace_name "hasSwivel" |> NamespacedName
    /// <summary>
    /// Defines the type of included TV tuner.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTVTuner"></see></summary>
    let hasTVTuner = Namespaced_IRI.parse _namespace_name "hasTVTuner" |> NamespacedName

    /// <summary>
    /// Defines the ability to operate an object by touching its screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTouchscreen"></see></summary>
    let hasTouchscreen =
        Namespaced_IRI.parse _namespace_name "hasTouchscreen" |> NamespacedName

    /// <summary>
    /// Number of serial bus standard ports to connect devices to a host computer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUSBPortsQuantity"></see></summary>
    let hasUSBPortsQuantity =
        Namespaced_IRI.parse _namespace_name "hasUSBPortsQuantity" |> NamespacedName

    /// <summary>
    /// Defines the necessary power for an electronical object while the device is used (Common unit of measurement Watt, WTT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUsagePowerConsumption"></see></summary>
    let hasUsagePowerConsumption =
        Namespaced_IRI.parse _namespace_name "hasUsagePowerConsumption" |> NamespacedName

    /// <summary>
    /// Defines the digital resolution of the videos (Common unit of measurement pixel, E37). (Example: 1024x768)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasVideoResolution"></see></summary>
    let hasVideoResolution =
        Namespaced_IRI.parse _namespace_name "hasVideoResolution" |> NamespacedName

    /// <summary>
    /// A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewFinder"></see></summary>
    let hasViewFinder =
        Namespaced_IRI.parse _namespace_name "hasViewFinder" |> NamespacedName

    /// <summary>
    /// Defines the angle in a horizontal axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleHorizontal"></see></summary>
    let hasViewingAngleHorizontal =
        Namespaced_IRI.parse _namespace_name "hasViewingAngleHorizontal" |> NamespacedName

    /// <summary>
    /// Defines the angle in a vertical axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleVertical"></see></summary>
    let hasViewingAngleVertical =
        Namespaced_IRI.parse _namespace_name "hasViewingAngleVertical" |> NamespacedName

    /// <summary>
    /// Defines if an object can be installed at a wall.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWallMountability"></see></summary>
    let hasWallMountability =
        Namespaced_IRI.parse _namespace_name "hasWallMountability" |> NamespacedName

    /// <summary>
    /// Defines the amount of time the device needs to be ready.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWarmupTime"></see></summary>
    let hasWarmupTime =
        Namespaced_IRI.parse _namespace_name "hasWarmupTime" |> NamespacedName

    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeight"></see></summary>
    let hasWeight = Namespaced_IRI.parse _namespace_name "hasWeight" |> NamespacedName

    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object with its stand (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeightWithStand"></see></summary>
    let hasWeightWithStand =
        Namespaced_IRI.parse _namespace_name "hasWeightWithStand" |> NamespacedName

    /// <summary>
    /// Defines the global adjustment of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWhiteBalance"></see></summary>
    let hasWhiteBalance =
        Namespaced_IRI.parse _namespace_name "hasWhiteBalance" |> NamespacedName

    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidth"></see></summary>
    let hasWidth = Namespaced_IRI.parse _namespace_name "hasWidth" |> NamespacedName

    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end with its stand (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidthWithStand"></see></summary>
    let hasWidthWithStand =
        Namespaced_IRI.parse _namespace_name "hasWidthWithStand" |> NamespacedName

    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasZoom"></see></summary>
    let hasZoom = Namespaced_IRI.parse _namespace_name "hasZoom" |> NamespacedName
    /// <summary>
    /// The business entity iDream Production Pvt. Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#iDream"></see></summary>
    let iDream = Namespaced_IRI.parse _namespace_name "iDream" |> NamespacedName
    /// <summary>
    /// The business entity iriver Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#iRiver"></see></summary>
    let iRiver = Namespaced_IRI.parse _namespace_name "iRiver" |> NamespacedName

namespace http.www.lingvoj.org.semio.hash

open DoxAletheia

module semio =
    let _namespace_name = "http://www.lingvoj.org/semio#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A string of characters, generally intended to be a unique identifier in some context
    /// <see href="http://www.lingvoj.org/semio#Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    /// A sign of which signifier is defined as the value of the Datatype Property 'signifierData'
    /// <see href="http://www.lingvoj.org/semio#DataSign"></see></summary>
    let DataSign = _prefix "DataSign"
    /// <summary>
    /// A resource describing the context. May gather any relevant piece of information: linguistic system context, space-time restrictions, information system, community of users ...
    /// <see href="http://www.lingvoj.org/semio#Context"></see></summary>
    let Context = _prefix "Context"
    /// <summary>
    /// A sign has exactly one signifier, either 'signifier data' or 'signifier resource' attribute
    /// A sign is an information resource. As such, it can be useful to attach metadata using Dublin Core attributes such as creator, creation date etc ...
    /// Something that stands for something else in a given context. A sign has a signifier (physical data which can be communicated), a signified (a concept, or formal representation), both indicating a referent, which is outside the language scope, and a context in which the signification is asserted.
    /// <see href="http://www.lingvoj.org/semio#Sign"></see></summary>
    let Sign = _prefix "Sign"
    /// <summary>
    /// A data which is the signifier, such as a word, code or any kind of identifier. URI strings can be used as signifiers. In such a case, the default signified is the resource identified by the URI.
    /// <see href="http://www.lingvoj.org/semio#signifierData"></see></summary>
    let signifierData = _prefix "signifierData"
    /// <summary>
    /// An image which is a symbolic representation of something. Flags, logos, coat of arms ...
    /// <see href="http://www.lingvoj.org/semio#Icon"></see></summary>
    let Icon = _prefix "Icon"
    /// <summary>
    /// Any image used as a sign. Either by direct denotation (a photograph of a cat for the concept of cat), or symbolic conotation (icons).
    /// <see href="http://www.lingvoj.org/semio#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A sign of which signifier is defined as the value of the Object Property 'signifierObject'
    /// <see href="http://www.lingvoj.org/semio#ObjectSign"></see></summary>
    let ObjectSign = _prefix "ObjectSign"
    /// <summary>
    /// For example a video representation
    /// <see href="http://www.lingvoj.org/semio#Multimedia"></see></summary>
    let Multimedia = _prefix "Multimedia"
    /// <summary>
    /// A resource which is the signifier. Typical examples include images or icons, or sound tracks for natural language words.
    /// <see href="http://www.lingvoj.org/semio#signifierObject"></see></summary>
    let signifierObject = _prefix "signifierObject"
    /// <summary>
    /// A string making sense in some natural language. Typically a term from a vocabulary. Other exemples include assertions, slogans, taglines ...
    /// <see href="http://www.lingvoj.org/semio#Phrase"></see></summary>
    let Phrase = _prefix "Phrase"
    /// <summary>
    /// Typically, the sound rendering of a phrase
    /// <see href="http://www.lingvoj.org/semio#Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    /// Links to an alternative, non-preferred sign for the same signified
    /// Use this property for signs defined in the same context
    /// <see href="http://www.lingvoj.org/semio#UF"></see></summary>
    let UF = _prefix "UF"
    /// <summary>
    /// A URI is a code used in the context of the Web
    /// <see href="http://www.lingvoj.org/semio#URI"></see></summary>
    let URI = _prefix "URI"
    /// <summary>
    /// Links to a preferred sign for the same signified
    /// Use this property for signs defined in the same context
    /// <see href="http://www.lingvoj.org/semio#USE"></see></summary>
    let USE = _prefix "USE"
    /// <summary>
    /// Links two signs considered as having the same referent, even if they have different signifiers. Useful to link different and possibly inconsistent views of the referent.
    /// Use this property for signs defined in different contexts
    /// <see href="http://www.lingvoj.org/semio#coreferentWith"></see></summary>
    let coreferentWith = _prefix "coreferentWith"
    /// <summary>
    /// A resource defining the signification context, in the scope of which the signifier-signified association is asserted as valid.
    /// Typically, the context ressource should be constructed as a blank node
    /// <see href="http://www.lingvoj.org/semio#significationContext"></see></summary>
    let significationContext = _prefix "significationContext"
    /// <summary>
    /// The resource for which the sign stands for
    /// <see href="http://www.lingvoj.org/semio#signified"></see></summary>
    let signified = _prefix "signified"
    /// <summary>
    /// A transcription links two signs with the same signified in different formats or supports. For example a phrase to its sound rendering, or a trade mark to a logo.
    /// Translation is considered as a particular case of transcription (debatable)
    /// <see href="http://www.lingvoj.org/semio#transcription"></see></summary>
    let transcription = _prefix "transcription"
    /// <summary>
    ///   <see href="http://www.lingvoj.org/semio#translation"></see>
    /// </summary>
    let translation = _prefix "translation"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module semio =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.lingvoj.org/semio#" "semio"
    /// <summary>
    ///   <para>rdfs:label : Code</para>
    ///   <para>rdfs:comment : A string of characters, generally intended to be a unique identifier in some context</para>
    ///   <a href="http://www.lingvoj.org/semio#Code">semio:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : A resource describing the context. May gather any relevant piece of information: linguistic system context, space-time restrictions, information system, community of users ... </para>
    ///   <a href="http://www.lingvoj.org/semio#Context">semio:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Data Sign</para>
    ///   <para>rdfs:comment : A sign of which signifier is defined as the value of the Datatype Property 'signifierData'</para>
    ///   <a href="http://www.lingvoj.org/semio#DataSign">semio:DataSign</a>
    /// </summary>
    let DataSign = _prefixId.prefix "DataSign"
    /// <summary>
    ///   <para>rdfs:label : Icon</para>
    ///   <para>rdfs:comment : An image which is a symbolic representation of something. Flags, logos, coat of arms ...</para>
    ///   <a href="http://www.lingvoj.org/semio#Icon">semio:Icon</a>
    /// </summary>
    let Icon = _prefixId.prefix "Icon"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : Any image used as a sign. Either by direct denotation (a photograph of a cat for the concept of cat), or symbolic conotation (icons).</para>
    ///   <a href="http://www.lingvoj.org/semio#Image">semio:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Multimedia</para>
    ///   <para>rdfs:comment : For example a video representation</para>
    ///   <a href="http://www.lingvoj.org/semio#Multimedia">semio:Multimedia</a>
    /// </summary>
    let Multimedia = _prefixId.prefix "Multimedia"
    /// <summary>
    ///   <para>rdfs:label : Object Sign</para>
    ///   <para>rdfs:comment : A sign of which signifier is defined as the value of the Object Property 'signifierObject'</para>
    ///   <a href="http://www.lingvoj.org/semio#ObjectSign">semio:ObjectSign</a>
    /// </summary>
    let ObjectSign = _prefixId.prefix "ObjectSign"
    /// <summary>
    ///   <para>rdfs:label : Phrase</para>
    ///   <para>rdfs:comment : A string making sense in some natural language. Typically a term from a vocabulary. Other exemples include assertions, slogans, taglines ...</para>
    ///   <a href="http://www.lingvoj.org/semio#Phrase">semio:Phrase</a>
    /// </summary>
    let Phrase = _prefixId.prefix "Phrase"
    /// <summary>
    ///   <para>rdfs:label : Sign</para>
    ///   <para>rdfs:comment : A sign has exactly one signifier, either 'signifier data' or 'signifier resource' attributerdfs:comment : A sign is an information resource. As such, it can be useful to attach metadata using Dublin Core attributes such as creator, creation date etc ...rdfs:comment : Something that stands for something else in a given context. A sign has a signifier (physical data which can be communicated), a signified (a concept, or formal representation), both indicating a referent, which is outside the language scope, and a context in which the signification is asserted.</para>
    ///   <a href="http://www.lingvoj.org/semio#Sign">semio:Sign</a>
    /// </summary>
    let Sign = _prefixId.prefix "Sign"
    /// <summary>
    ///   <para>rdfs:label : Sound</para>
    ///   <para>rdfs:comment : Typically, the sound rendering of a phrase</para>
    ///   <a href="http://www.lingvoj.org/semio#Sound">semio:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>rdfs:label : used for</para>
    ///   <para>rdfs:comment : Links to an alternative, non-preferred sign for the same signifiedrdfs:comment : Use this property for signs defined in the same context</para>
    ///   <a href="http://www.lingvoj.org/semio#UF">semio:UF</a>
    /// </summary>
    let UF = _prefixId.prefix "UF"
    /// <summary>
    ///   <para>rdfs:label : Uniform Resource Identifier</para>
    ///   <para>rdfs:comment : A URI is a code used in the context of the Web</para>
    ///   <a href="http://www.lingvoj.org/semio#URI">semio:URI</a>
    /// </summary>
    let URI = _prefixId.prefix "URI"
    /// <summary>
    ///   <para>rdfs:label : use</para>
    ///   <para>rdfs:comment : Links to a preferred sign for the same signifiedrdfs:comment : Use this property for signs defined in the same context</para>
    ///   <a href="http://www.lingvoj.org/semio#USE">semio:USE</a>
    /// </summary>
    let USE = _prefixId.prefix "USE"
    /// <summary>
    ///   <para>rdfs:label : coreference</para>
    ///   <para>rdfs:comment : Links two signs considered as having the same referent, even if they have different signifiers. Useful to link different and possibly inconsistent views of the referent.rdfs:comment : Use this property for signs defined in different contexts</para>
    ///   <a href="http://www.lingvoj.org/semio#coreferentWith">semio:coreferentWith</a>
    /// </summary>
    let coreferentWith = _prefixId.prefix "coreferentWith"
    /// <summary>
    ///   <para>rdfs:label : signification context</para>
    ///   <para>rdfs:comment : A resource defining the signification context, in the scope of which the signifier-signified association is asserted as valid.rdfs:comment : Typically, the context ressource should be constructed as a blank node</para>
    ///   <a href="http://www.lingvoj.org/semio#significationContext">semio:significationContext</a>
    /// </summary>
    let significationContext = _prefixId.prefix "significationContext"
    /// <summary>
    ///   <para>rdfs:label : signified</para>
    ///   <para>rdfs:comment : The resource for which the sign stands for</para>
    ///   <a href="http://www.lingvoj.org/semio#signified">semio:signified</a>
    /// </summary>
    let signified = _prefixId.prefix "signified"
    /// <summary>
    ///   <para>rdfs:label : signifier data</para>
    ///   <para>rdfs:comment : A data which is the signifier, such as a word, code or any kind of identifier. URI strings can be used as signifiers. In such a case, the default signified is the resource identified by the URI.</para>
    ///   <a href="http://www.lingvoj.org/semio#signifierData">semio:signifierData</a>
    /// </summary>
    let signifierData = _prefixId.prefix "signifierData"
    /// <summary>
    ///   <para>rdfs:label : signifier object</para>
    ///   <para>rdfs:comment : A resource which is the signifier. Typical examples include images or icons, or sound tracks for natural language words.</para>
    ///   <a href="http://www.lingvoj.org/semio#signifierObject">semio:signifierObject</a>
    /// </summary>
    let signifierObject = _prefixId.prefix "signifierObject"
    /// <summary>
    ///   <para>rdfs:label : transcription</para>
    ///   <para>rdfs:comment : A transcription links two signs with the same signified in different formats or supports. For example a phrase to its sound rendering, or a trade mark to a logo.rdfs:comment : Translation is considered as a particular case of transcription (debatable)</para>
    ///   <a href="http://www.lingvoj.org/semio#transcription">semio:transcription</a>
    /// </summary>
    let transcription = _prefixId.prefix "transcription"
    /// <summary>
    ///   <para>rdfs:label : translation</para>
    ///   <a href="http://www.lingvoj.org/semio#translation">semio:translation</a>
    /// </summary>
    let translation = _prefixId.prefix "translation"

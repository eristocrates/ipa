namespace http.www.lingvoj.org.semio.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module semio =
    let _namespace_iri = Namespace_Iri semio |> NamespaceIRI
    /// <summary>
    ///   <para>semio:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A resource describing the context. May gather any relevant piece of information: linguistic system context, space-time restrictions, information system, community of users ... </para>
    /// labels<para>Context</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Context">http://www.lingvoj.org/semio#Context</seealso>
    let Context = Prefixed_Name(semio, "Context") |> PrefixedName
    /// <summary>
    ///   <para>semio:ObjectSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sign of which signifier is defined as the value of the Object Property 'signifierObject'</para>
    /// labels<para>Object Sign</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#ObjectSign">http://www.lingvoj.org/semio#ObjectSign</seealso>
    let ObjectSign = Prefixed_Name(semio, "ObjectSign") |> PrefixedName
    /// <summary>
    ///   <para>semio:signified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The resource for which the sign stands for</para>
    /// labels<para>signified</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#signified">http://www.lingvoj.org/semio#signified</seealso>
    let signified = Prefixed_Name(semio, "signified") |> PrefixedName
    /// <summary>
    ///   <para>semio:Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A string of characters, generally intended to be a unique identifier in some context</para>
    /// labels<para>Code</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Code">http://www.lingvoj.org/semio#Code</seealso>
    let Code = Prefixed_Name(semio, "Code") |> PrefixedName
    /// <summary>
    ///   <para>semio:DataSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sign of which signifier is defined as the value of the Datatype Property 'signifierData'</para>
    /// labels<para>Data Sign</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#DataSign">http://www.lingvoj.org/semio#DataSign</seealso>
    let DataSign = Prefixed_Name(semio, "DataSign") |> PrefixedName
    /// <summary>
    ///   <para>semio:signifierData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A data which is the signifier, such as a word, code or any kind of identifier. URI strings can be used as signifiers. In such a case, the default signified is the resource identified by the URI.</para>
    /// labels<para>signifier data</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#signifierData">http://www.lingvoj.org/semio#signifierData</seealso>
    let signifierData = Prefixed_Name(semio, "signifierData") |> PrefixedName
    /// <summary>
    ///   <para>semio:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any image used as a sign. Either by direct denotation (a photograph of a cat for the concept of cat), or symbolic conotation (icons).</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Image">http://www.lingvoj.org/semio#Image</seealso>
    let Image = Prefixed_Name(semio, "Image") |> PrefixedName
    /// <summary>
    ///   <para>semio:Sign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something that stands for something else in a given context. A sign has a signifier (physical data which can be communicated), a signified (a concept, or formal representation), both indicating a referent, which is outside the language scope, and a context in which the signification is asserted.</para>
    ///   <para>A sign is an information resource. As such, it can be useful to attach metadata using Dublin Core attributes such as creator, creation date etc ...</para>
    ///   <para>A sign has exactly one signifier, either 'signifier data' or 'signifier resource' attribute</para>
    /// labels<para>Sign</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Sign">http://www.lingvoj.org/semio#Sign</seealso>
    let Sign = Prefixed_Name(semio, "Sign") |> PrefixedName
    /// <summary>
    ///   <para>semio:Multimedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For example a video representation</para>
    /// labels<para>Multimedia</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Multimedia">http://www.lingvoj.org/semio#Multimedia</seealso>
    let Multimedia = Prefixed_Name(semio, "Multimedia") |> PrefixedName
    /// <summary>
    ///   <para>semio:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Typically, the sound rendering of a phrase</para>
    /// labels<para>Sound</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Sound">http://www.lingvoj.org/semio#Sound</seealso>
    let Sound = Prefixed_Name(semio, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>semio:signifierObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource which is the signifier. Typical examples include images or icons, or sound tracks for natural language words.</para>
    /// labels<para>signifier object</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#signifierObject">http://www.lingvoj.org/semio#signifierObject</seealso>
    let signifierObject = Prefixed_Name(semio, "signifierObject") |> PrefixedName
    /// <summary>
    ///   <para>semio:UF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Use this property for signs defined in the same context</para>
    ///   <para>Links to an alternative, non-preferred sign for the same signified</para>
    /// labels<para>used for</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#UF">http://www.lingvoj.org/semio#UF</seealso>
    let UF = Prefixed_Name(semio, "UF") |> PrefixedName
    /// <summary>
    ///   <para>semio:URI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A URI is a code used in the context of the Web</para>
    /// labels<para>Uniform Resource Identifier</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#URI">http://www.lingvoj.org/semio#URI</seealso>
    let URI = Prefixed_Name(semio, "URI") |> PrefixedName
    /// <summary>
    ///   <para>semio:USE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Use this property for signs defined in the same context</para>
    ///   <para>Links to a preferred sign for the same signified</para>
    /// labels<para>use</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#USE">http://www.lingvoj.org/semio#USE</seealso>
    let USE = Prefixed_Name(semio, "USE") |> PrefixedName
    /// <summary>
    ///   <para>semio:coreferentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Use this property for signs defined in different contexts</para>
    ///   <para>Links two signs considered as having the same referent, even if they have different signifiers. Useful to link different and possibly inconsistent views of the referent.</para>
    /// labels<para>coreference</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#coreferentWith">http://www.lingvoj.org/semio#coreferentWith</seealso>
    let coreferentWith = Prefixed_Name(semio, "coreferentWith") |> PrefixedName

    /// <summary>
    ///   <para>semio:significationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A resource defining the signification context, in the scope of which the signifier-signified association is asserted as valid.</para>
    ///   <para>Typically, the context ressource should be constructed as a blank node</para>
    /// labels<para>signification context</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#significationContext">http://www.lingvoj.org/semio#significationContext</seealso>
    let significationContext =
        Prefixed_Name(semio, "significationContext") |> PrefixedName

    /// <summary>
    ///   <para>semio:transcription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Translation is considered as a particular case of transcription (debatable)</para>
    ///   <para>A transcription links two signs with the same signified in different formats or supports. For example a phrase to its sound rendering, or a trade mark to a logo.</para>
    /// labels<para>transcription</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#transcription">http://www.lingvoj.org/semio#transcription</seealso>
    let transcription = Prefixed_Name(semio, "transcription") |> PrefixedName
    /// <summary>
    ///   <para>semio:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#translation">http://www.lingvoj.org/semio#translation</seealso>
    let translation = Prefixed_Name(semio, "translation") |> PrefixedName
    /// <summary>
    ///   <para>semio:Icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An image which is a symbolic representation of something. Flags, logos, coat of arms ...</para>
    /// labels<para>Icon</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Icon">http://www.lingvoj.org/semio#Icon</seealso>
    let Icon = Prefixed_Name(semio, "Icon") |> PrefixedName
    /// <summary>
    ///   <para>semio:Phrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A string making sense in some natural language. Typically a term from a vocabulary. Other exemples include assertions, slogans, taglines ...</para>
    /// labels<para>Phrase</para></remarks>
    /// <seealso href="http://www.lingvoj.org/semio#Phrase">http://www.lingvoj.org/semio#Phrase</seealso>
    let Phrase = Prefixed_Name(semio, "Phrase") |> PrefixedName

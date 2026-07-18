namespace https.w3id.org.vocab.lingvoj.hash

open DoxAletheia.Rdf_Vocabulary

module lingvo =
    let _namespace_name = "https://w3id.org/vocab/lingvoj#"

    /// <summary>
    /// Dictionaries, thesauri, language courses, translation services, etc.
    /// <see href="https://w3id.org/vocab/lingvoj#LanguageResource"></see></summary>
    let LanguageResource =
        Namespaced_IRI.parse _namespace_name "LanguageResource" |> NamespacedName

    /// <summary>
    /// A language used in spoken or written human communication, or in which a resource is written or recorded. It is recommended to use instances defined on the basis of ISO 639 codes, such as those in examples
    /// <see href="https://w3id.org/vocab/lingvoj#Lingvo"></see></summary>
    let Lingvo = Namespaced_IRI.parse _namespace_name "Lingvo" |> NamespacedName

    /// <summary>
    /// Description of a Translation should include original resource, translated resource, original language and target language. It might also include translator(s) and translation date, and relevant other information using properties inherited from the generic Event class
    /// <see href="https://w3id.org/vocab/lingvoj#Translation"></see></summary>
    let Translation =
        Namespaced_IRI.parse _namespace_name "Translation" |> NamespacedName

    /// <summary>
    /// The person can read the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedReading"></see></summary>
    let advancedReading =
        Namespaced_IRI.parse _namespace_name "advancedReading" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility3"></see>
    /// </summary>
    let hasAbility3 =
        Namespaced_IRI.parse _namespace_name "hasAbility3" |> NamespacedName

    /// <summary>
    /// The person can speak the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedSpeaking"></see></summary>
    let advancedSpeaking =
        Namespaced_IRI.parse _namespace_name "advancedSpeaking" |> NamespacedName

    /// <summary>
    /// The person has an advanced understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#advancedUnderstanding"></see></summary>
    let advancedUnderstanding =
        Namespaced_IRI.parse _namespace_name "advancedUnderstanding" |> NamespacedName

    /// <summary>
    /// The person can write the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedWriting"></see></summary>
    let advancedWriting =
        Namespaced_IRI.parse _namespace_name "advancedWriting" |> NamespacedName

    /// <summary>
    /// The person can read the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicReading"></see></summary>
    let basicReading =
        Namespaced_IRI.parse _namespace_name "basicReading" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility1"></see>
    /// </summary>
    let hasAbility1 =
        Namespaced_IRI.parse _namespace_name "hasAbility1" |> NamespacedName

    /// <summary>
    /// The person can speak the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicSpeaking"></see></summary>
    let basicSpeaking =
        Namespaced_IRI.parse _namespace_name "basicSpeaking" |> NamespacedName

    /// <summary>
    /// The person has a basic understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#basicUnderstanding"></see></summary>
    let basicUnderstanding =
        Namespaced_IRI.parse _namespace_name "basicUnderstanding" |> NamespacedName

    /// <summary>
    /// The person can write the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicWriting"></see></summary>
    let basicWriting =
        Namespaced_IRI.parse _namespace_name "basicWriting" |> NamespacedName

    /// <summary>
    /// A language used for external communication
    /// <see href="https://w3id.org/vocab/lingvoj#communicationLanguage"></see></summary>
    let communicationLanguage =
        Namespaced_IRI.parse _namespace_name "communicationLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasCommunicationLanguage"></see>
    /// </summary>
    let hasCommunicationLanguage =
        Namespaced_IRI.parse _namespace_name "hasCommunicationLanguage" |> NamespacedName

    /// <summary>
    /// The language is endangered at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#endangeredLanguage"></see></summary>
    let endangeredLanguage =
        Namespaced_IRI.parse _namespace_name "endangeredLanguage" |> NamespacedName

    /// <summary>
    /// The language has speakers at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#livingLanguage"></see></summary>
    let livingLanguage =
        Namespaced_IRI.parse _namespace_name "livingLanguage" |> NamespacedName

    /// <summary>
    /// The person can read the language at a expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertReading"></see></summary>
    let expertReading =
        Namespaced_IRI.parse _namespace_name "expertReading" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility4"></see>
    /// </summary>
    let hasAbility4 =
        Namespaced_IRI.parse _namespace_name "hasAbility4" |> NamespacedName

    /// <summary>
    /// The person can speak the language at an expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertSpeaking"></see></summary>
    let expertSpeaking =
        Namespaced_IRI.parse _namespace_name "expertSpeaking" |> NamespacedName

    /// <summary>
    /// The person has an expert understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#expertUnderstanding"></see></summary>
    let expertUnderstanding =
        Namespaced_IRI.parse _namespace_name "expertUnderstanding" |> NamespacedName

    /// <summary>
    /// The person can write the language at an expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertWriting"></see></summary>
    let expertWriting =
        Namespaced_IRI.parse _namespace_name "expertWriting" |> NamespacedName

    /// <summary>
    /// The language has no longer any speaker at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#extinctLanguage"></see></summary>
    let extinctLanguage =
        Namespaced_IRI.parse _namespace_name "extinctLanguage" |> NamespacedName

    /// <summary>
    /// Country of origin of the language
    /// <see href="https://w3id.org/vocab/lingvoj#fromCountry"></see></summary>
    let fromCountry =
        Namespaced_IRI.parse _namespace_name "fromCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility2"></see>
    /// </summary>
    let hasAbility2 =
        Namespaced_IRI.parse _namespace_name "hasAbility2" |> NamespacedName

    /// <summary>
    /// The person can write the language at an intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateWriting"></see></summary>
    let intermediateWriting =
        Namespaced_IRI.parse _namespace_name "intermediateWriting" |> NamespacedName

    /// <summary>
    /// The person can read the language at a intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateReading"></see></summary>
    let intermediateReading =
        Namespaced_IRI.parse _namespace_name "intermediateReading" |> NamespacedName

    /// <summary>
    /// The person can speak the language at an intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateSpeaking"></see></summary>
    let intermediateSpeaking =
        Namespaced_IRI.parse _namespace_name "intermediateSpeaking" |> NamespacedName

    /// <summary>
    /// The person has an intermediate understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateUnderstanding"></see></summary>
    let intermediateUnderstanding =
        Namespaced_IRI.parse _namespace_name "intermediateUnderstanding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility5"></see>
    /// </summary>
    let hasAbility5 =
        Namespaced_IRI.parse _namespace_name "hasAbility5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasNativeLanguage"></see>
    /// </summary>
    let hasNativeLanguage =
        Namespaced_IRI.parse _namespace_name "hasNativeLanguage" |> NamespacedName

    /// <summary>
    /// This property is independent of the level of fluency, reading or writing ability
    /// <see href="https://w3id.org/vocab/lingvoj#nativeLanguage"></see></summary>
    let nativeLanguage =
        Namespaced_IRI.parse _namespace_name "nativeLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasWorkingLanguage"></see>
    /// </summary>
    let hasWorkingLanguage =
        Namespaced_IRI.parse _namespace_name "hasWorkingLanguage" |> NamespacedName

    /// <summary>
    /// A language the project or organization uses for internal communication
    /// <see href="https://w3id.org/vocab/lingvoj#workingLanguage"></see></summary>
    let workingLanguage =
        Namespaced_IRI.parse _namespace_name "workingLanguage" |> NamespacedName

    /// <summary>
    /// A language spoken in the past in this place, but not used anymore
    /// <see href="https://w3id.org/vocab/lingvoj#historicalLanguage"></see></summary>
    let historicalLanguage =
        Namespaced_IRI.parse _namespace_name "historicalLanguage" |> NamespacedName

    /// <summary>
    /// An agent (person or software) responsible of a real-time oral translation
    /// <see href="https://w3id.org/vocab/lingvoj#interpreter"></see></summary>
    let interpreter =
        Namespaced_IRI.parse _namespace_name "interpreter" |> NamespacedName

    /// <summary>
    /// An agent (person, organization or sofware) responsible of the translation
    /// <see href="https://w3id.org/vocab/lingvoj#translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso1"></see>
    /// </summary>
    let iso1 = Namespaced_IRI.parse _namespace_name "iso1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso2b"></see>
    /// </summary>
    let iso2b = Namespaced_IRI.parse _namespace_name "iso2b" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso2t"></see>
    /// </summary>
    let iso2t = Namespaced_IRI.parse _namespace_name "iso2t" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso3"></see>
    /// </summary>
    let iso3 = Namespaced_IRI.parse _namespace_name "iso3" |> NamespacedName

    /// <summary>
    /// The main language used in the place or language resource
    /// <see href="https://w3id.org/vocab/lingvoj#mainLanguage"></see></summary>
    let mainLanguage =
        Namespaced_IRI.parse _namespace_name "mainLanguage" |> NamespacedName

    /// <summary>
    /// A language spoken by a minority in some country, but not necessarily in a specific region
    /// <see href="https://w3id.org/vocab/lingvoj#minorityLanguage"></see></summary>
    let minorityLanguage =
        Namespaced_IRI.parse _namespace_name "minorityLanguage" |> NamespacedName

    /// <summary>
    /// The person does not read at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notRead"></see></summary>
    let notRead = Namespaced_IRI.parse _namespace_name "notRead" |> NamespacedName
    /// <summary>
    /// The person does not speak at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notSpoken"></see></summary>
    let notSpoken = Namespaced_IRI.parse _namespace_name "notSpoken" |> NamespacedName

    /// <summary>
    /// The person does not understand at all the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#notUnderstood"></see></summary>
    let notUnderstood =
        Namespaced_IRI.parse _namespace_name "notUnderstood" |> NamespacedName

    /// <summary>
    /// The person does not write at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notWritten"></see></summary>
    let notWritten = Namespaced_IRI.parse _namespace_name "notWritten" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#officialIn"></see>
    /// </summary>
    let officialIn = Namespaced_IRI.parse _namespace_name "officialIn" |> NamespacedName

    /// <summary>
    /// An official language of a country, project, organization or event
    /// <see href="https://w3id.org/vocab/lingvoj#officialLanguage"></see></summary>
    let officialLanguage =
        Namespaced_IRI.parse _namespace_name "officialLanguage" |> NamespacedName

    /// <summary>
    /// The language of the original ressource
    /// <see href="https://w3id.org/vocab/lingvoj#originalLanguage"></see></summary>
    let originalLanguage =
        Namespaced_IRI.parse _namespace_name "originalLanguage" |> NamespacedName

    /// <summary>
    /// The resource which is translated
    /// <see href="https://w3id.org/vocab/lingvoj#originalResource"></see></summary>
    let originalResource =
        Namespaced_IRI.parse _namespace_name "originalResource" |> NamespacedName

    /// <summary>
    /// The original title is a property of the original resource (use dcterms:title) and not a property of the Translation itself
    /// <see href="https://w3id.org/vocab/lingvoj#originalTitle"></see></summary>
    let originalTitle =
        Namespaced_IRI.parse _namespace_name "originalTitle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#original_resource"></see>
    /// </summary>
    let original_resource =
        Namespaced_IRI.parse _namespace_name "original_resource" |> NamespacedName

    /// <summary>
    /// A language spoken in a region of a country
    /// <see href="https://w3id.org/vocab/lingvoj#regionalLanguage"></see></summary>
    let regionalLanguage =
        Namespaced_IRI.parse _namespace_name "regionalLanguage" |> NamespacedName

    /// <summary>
    /// A concept defining the type of the language resource
    /// <see href="https://w3id.org/vocab/lingvoj#resourceType"></see></summary>
    let resourceType =
        Namespaced_IRI.parse _namespace_name "resourceType" |> NamespacedName

    /// <summary>
    /// A language which is spoken in some place or event
    /// <see href="https://w3id.org/vocab/lingvoj#spokenLanguage"></see></summary>
    let spokenLanguage =
        Namespaced_IRI.parse _namespace_name "spokenLanguage" |> NamespacedName

    /// <summary>
    /// A language supported by the language resource
    /// <see href="https://w3id.org/vocab/lingvoj#supportedLanguage"></see></summary>
    let supportedLanguage =
        Namespaced_IRI.parse _namespace_name "supportedLanguage" |> NamespacedName

    /// <summary>
    /// A language resource for this language
    /// <see href="https://w3id.org/vocab/lingvoj#supportingResource"></see></summary>
    let supportingResource =
        Namespaced_IRI.parse _namespace_name "supportingResource" |> NamespacedName

    /// <summary>
    /// The tag to use for the language, for example as value of xml:lang. See https://tools.ietf.org/html/bcp47
    /// <see href="https://w3id.org/vocab/lingvoj#tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName

    /// <summary>
    /// The language of the translated ressource
    /// <see href="https://w3id.org/vocab/lingvoj#targetLanguage"></see></summary>
    let targetLanguage =
        Namespaced_IRI.parse _namespace_name "targetLanguage" |> NamespacedName

    /// <summary>
    /// The resource which is the result of the translation
    /// <see href="https://w3id.org/vocab/lingvoj#translatedResource"></see></summary>
    let translatedResource =
        Namespaced_IRI.parse _namespace_name "translatedResource" |> NamespacedName

    /// <summary>
    /// The translated title is a property of the translated resource (use dcterms:title) and not a property of the Translation itself
    /// <see href="https://w3id.org/vocab/lingvoj#translatedTitle"></see></summary>
    let translatedTitle =
        Namespaced_IRI.parse _namespace_name "translatedTitle" |> NamespacedName

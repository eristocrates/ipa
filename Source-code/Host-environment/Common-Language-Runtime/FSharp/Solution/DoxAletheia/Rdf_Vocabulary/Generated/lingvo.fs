namespace https.w3id.org.vocab.lingvoj.hash

open DoxAletheia

module lingvo =
    let _namespace_name = "https://w3id.org/vocab/lingvoj#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Dictionaries, thesauri, language courses, translation services, etc.
    /// <see href="https://w3id.org/vocab/lingvoj#LanguageResource"></see></summary>
    let LanguageResource = _prefix "LanguageResource"
    /// <summary>
    /// A language used in spoken or written human communication, or in which a resource is written or recorded. It is recommended to use instances defined on the basis of ISO 639 codes, such as those in examples
    /// <see href="https://w3id.org/vocab/lingvoj#Lingvo"></see></summary>
    let Lingvo = _prefix "Lingvo"
    /// <summary>
    /// Description of a Translation should include original resource, translated resource, original language and target language. It might also include translator(s) and translation date, and relevant other information using properties inherited from the generic Event class
    /// <see href="https://w3id.org/vocab/lingvoj#Translation"></see></summary>
    let Translation = _prefix "Translation"
    /// <summary>
    /// The person can read the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedReading"></see></summary>
    let advancedReading = _prefix "advancedReading"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility3"></see>
    /// </summary>
    let hasAbility3 = _prefix "hasAbility3"
    /// <summary>
    /// The person can speak the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedSpeaking"></see></summary>
    let advancedSpeaking = _prefix "advancedSpeaking"
    /// <summary>
    /// The person has an advanced understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#advancedUnderstanding"></see></summary>
    let advancedUnderstanding = _prefix "advancedUnderstanding"
    /// <summary>
    /// The person can write the language at an advanced level
    /// <see href="https://w3id.org/vocab/lingvoj#advancedWriting"></see></summary>
    let advancedWriting = _prefix "advancedWriting"
    /// <summary>
    /// The person can read the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicReading"></see></summary>
    let basicReading = _prefix "basicReading"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility1"></see>
    /// </summary>
    let hasAbility1 = _prefix "hasAbility1"
    /// <summary>
    /// The person can speak the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicSpeaking"></see></summary>
    let basicSpeaking = _prefix "basicSpeaking"
    /// <summary>
    /// The person has a basic understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#basicUnderstanding"></see></summary>
    let basicUnderstanding = _prefix "basicUnderstanding"
    /// <summary>
    /// The person can write the language at a basic level
    /// <see href="https://w3id.org/vocab/lingvoj#basicWriting"></see></summary>
    let basicWriting = _prefix "basicWriting"
    /// <summary>
    /// A language used for external communication
    /// <see href="https://w3id.org/vocab/lingvoj#communicationLanguage"></see></summary>
    let communicationLanguage = _prefix "communicationLanguage"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasCommunicationLanguage"></see>
    /// </summary>
    let hasCommunicationLanguage = _prefix "hasCommunicationLanguage"
    /// <summary>
    /// The language is endangered at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#endangeredLanguage"></see></summary>
    let endangeredLanguage = _prefix "endangeredLanguage"
    /// <summary>
    /// The language has speakers at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#livingLanguage"></see></summary>
    let livingLanguage = _prefix "livingLanguage"
    /// <summary>
    /// The person can read the language at a expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertReading"></see></summary>
    let expertReading = _prefix "expertReading"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility4"></see>
    /// </summary>
    let hasAbility4 = _prefix "hasAbility4"
    /// <summary>
    /// The person can speak the language at an expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertSpeaking"></see></summary>
    let expertSpeaking = _prefix "expertSpeaking"
    /// <summary>
    /// The person has an expert understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#expertUnderstanding"></see></summary>
    let expertUnderstanding = _prefix "expertUnderstanding"
    /// <summary>
    /// The person can write the language at an expert level
    /// <see href="https://w3id.org/vocab/lingvoj#expertWriting"></see></summary>
    let expertWriting = _prefix "expertWriting"
    /// <summary>
    /// The language has no longer any speaker at the given date
    /// <see href="https://w3id.org/vocab/lingvoj#extinctLanguage"></see></summary>
    let extinctLanguage = _prefix "extinctLanguage"
    /// <summary>
    /// Country of origin of the language
    /// <see href="https://w3id.org/vocab/lingvoj#fromCountry"></see></summary>
    let fromCountry = _prefix "fromCountry"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility2"></see>
    /// </summary>
    let hasAbility2 = _prefix "hasAbility2"
    /// <summary>
    /// The person can write the language at an intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateWriting"></see></summary>
    let intermediateWriting = _prefix "intermediateWriting"
    /// <summary>
    /// The person can read the language at a intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateReading"></see></summary>
    let intermediateReading = _prefix "intermediateReading"
    /// <summary>
    /// The person can speak the language at an intermediate level
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateSpeaking"></see></summary>
    let intermediateSpeaking = _prefix "intermediateSpeaking"
    /// <summary>
    /// The person has an intermediate understanding of the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#intermediateUnderstanding"></see></summary>
    let intermediateUnderstanding = _prefix "intermediateUnderstanding"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasAbility5"></see>
    /// </summary>
    let hasAbility5 = _prefix "hasAbility5"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasNativeLanguage"></see>
    /// </summary>
    let hasNativeLanguage = _prefix "hasNativeLanguage"
    /// <summary>
    /// This property is independent of the level of fluency, reading or writing ability
    /// <see href="https://w3id.org/vocab/lingvoj#nativeLanguage"></see></summary>
    let nativeLanguage = _prefix "nativeLanguage"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#hasWorkingLanguage"></see>
    /// </summary>
    let hasWorkingLanguage = _prefix "hasWorkingLanguage"
    /// <summary>
    /// A language the project or organization uses for internal communication
    /// <see href="https://w3id.org/vocab/lingvoj#workingLanguage"></see></summary>
    let workingLanguage = _prefix "workingLanguage"
    /// <summary>
    /// A language spoken in the past in this place, but not used anymore
    /// <see href="https://w3id.org/vocab/lingvoj#historicalLanguage"></see></summary>
    let historicalLanguage = _prefix "historicalLanguage"
    /// <summary>
    /// An agent (person or software) responsible of a real-time oral translation
    /// <see href="https://w3id.org/vocab/lingvoj#interpreter"></see></summary>
    let interpreter = _prefix "interpreter"
    /// <summary>
    /// An agent (person, organization or sofware) responsible of the translation
    /// <see href="https://w3id.org/vocab/lingvoj#translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso1"></see>
    /// </summary>
    let iso1 = _prefix "iso1"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso2b"></see>
    /// </summary>
    let iso2b = _prefix "iso2b"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso2t"></see>
    /// </summary>
    let iso2t = _prefix "iso2t"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#iso3"></see>
    /// </summary>
    let iso3 = _prefix "iso3"
    /// <summary>
    /// The main language used in the place or language resource
    /// <see href="https://w3id.org/vocab/lingvoj#mainLanguage"></see></summary>
    let mainLanguage = _prefix "mainLanguage"
    /// <summary>
    /// A language spoken by a minority in some country, but not necessarily in a specific region
    /// <see href="https://w3id.org/vocab/lingvoj#minorityLanguage"></see></summary>
    let minorityLanguage = _prefix "minorityLanguage"
    /// <summary>
    /// The person does not read at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notRead"></see></summary>
    let notRead = _prefix "notRead"
    /// <summary>
    /// The person does not speak at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notSpoken"></see></summary>
    let notSpoken = _prefix "notSpoken"
    /// <summary>
    /// The person does not understand at all the spoken language
    /// <see href="https://w3id.org/vocab/lingvoj#notUnderstood"></see></summary>
    let notUnderstood = _prefix "notUnderstood"
    /// <summary>
    /// The person does not write at all the language
    /// <see href="https://w3id.org/vocab/lingvoj#notWritten"></see></summary>
    let notWritten = _prefix "notWritten"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#officialIn"></see>
    /// </summary>
    let officialIn = _prefix "officialIn"
    /// <summary>
    /// An official language of a country, project, organization or event
    /// <see href="https://w3id.org/vocab/lingvoj#officialLanguage"></see></summary>
    let officialLanguage = _prefix "officialLanguage"
    /// <summary>
    /// The language of the original ressource
    /// <see href="https://w3id.org/vocab/lingvoj#originalLanguage"></see></summary>
    let originalLanguage = _prefix "originalLanguage"
    /// <summary>
    /// The resource which is translated
    /// <see href="https://w3id.org/vocab/lingvoj#originalResource"></see></summary>
    let originalResource = _prefix "originalResource"
    /// <summary>
    /// The original title is a property of the original resource (use dcterms:title) and not a property of the Translation itself
    /// <see href="https://w3id.org/vocab/lingvoj#originalTitle"></see></summary>
    let originalTitle = _prefix "originalTitle"
    /// <summary>
    ///   <see href="https://w3id.org/vocab/lingvoj#original_resource"></see>
    /// </summary>
    let original_resource = _prefix "original_resource"
    /// <summary>
    /// A language spoken in a region of a country
    /// <see href="https://w3id.org/vocab/lingvoj#regionalLanguage"></see></summary>
    let regionalLanguage = _prefix "regionalLanguage"
    /// <summary>
    /// A concept defining the type of the language resource
    /// <see href="https://w3id.org/vocab/lingvoj#resourceType"></see></summary>
    let resourceType = _prefix "resourceType"
    /// <summary>
    /// A language which is spoken in some place or event
    /// <see href="https://w3id.org/vocab/lingvoj#spokenLanguage"></see></summary>
    let spokenLanguage = _prefix "spokenLanguage"
    /// <summary>
    /// A language supported by the language resource
    /// <see href="https://w3id.org/vocab/lingvoj#supportedLanguage"></see></summary>
    let supportedLanguage = _prefix "supportedLanguage"
    /// <summary>
    /// A language resource for this language
    /// <see href="https://w3id.org/vocab/lingvoj#supportingResource"></see></summary>
    let supportingResource = _prefix "supportingResource"
    /// <summary>
    /// The tag to use for the language, for example as value of xml:lang. See https://tools.ietf.org/html/bcp47
    /// <see href="https://w3id.org/vocab/lingvoj#tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    /// The language of the translated ressource
    /// <see href="https://w3id.org/vocab/lingvoj#targetLanguage"></see></summary>
    let targetLanguage = _prefix "targetLanguage"
    /// <summary>
    /// The resource which is the result of the translation
    /// <see href="https://w3id.org/vocab/lingvoj#translatedResource"></see></summary>
    let translatedResource = _prefix "translatedResource"
    /// <summary>
    /// The translated title is a property of the translated resource (use dcterms:title) and not a property of the Translation itself
    /// <see href="https://w3id.org/vocab/lingvoj#translatedTitle"></see></summary>
    let translatedTitle = _prefix "translatedTitle"

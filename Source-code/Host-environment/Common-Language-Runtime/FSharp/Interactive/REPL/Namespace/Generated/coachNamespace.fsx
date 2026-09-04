#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module coach =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/coach#" "coach"
    let _namespaceIri = _prefixId.prefix ""
    let AgeScheme = _prefixId.prefix "AgeScheme"
    let AgreeablenessScheme = _prefixId.prefix "AgreeablenessScheme"
    /// <summary>
    ///   <para>skos:definition : Represents an entity, real or fictional, characterized by various attributes (or dimensions) such as personality traits, cultural background, and preferences.</para>
    ///   <para>rdfs:label : Character</para>
    ///   <a href="https://w3id.org/coach#Character">coach:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    let ConscientiousnessScheme = _prefixId.prefix "ConscientiousnessScheme"
    let EducationScheme = _prefixId.prefix "EducationScheme"
    let ExtraversionScheme = _prefixId.prefix "ExtraversionScheme"
    let NeuroticismScheme = _prefixId.prefix "NeuroticismScheme"
    let OpenessScheme = _prefixId.prefix "OpenessScheme"
    let PoliticalOrientationScheme = _prefixId.prefix "PoliticalOrientationScheme"
    /// <summary>
    ///   <para>skos:definition : Identifies an essential feature or attribute of a Character, including personal, cultural, or psychological dimensions.</para>
    ///   <para>rdfs:label : hasDimension</para>
    ///   <a href="https://w3id.org/coach#dimension">coach:dimension</a>
    /// </summary>
    let dimension = _prefixId.prefix "dimension"
    /// <summary>
    ///   <para>skos:editorialNote : Better to use a wikipedia item</para>
    ///   <para>skos:definition : Represents anything a Character dislikes.</para>
    ///   <para>rdfs:label : dislikes</para>
    ///   <a href="https://w3id.org/coach#dislikes">coach:dislikes</a>
    /// </summary>
    let dislikes = _prefixId.prefix "dislikes"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their age, as defined within the AgeScheme.</para>
    ///   <para>rdfs:label : hasAge</para>
    ///   <a href="https://w3id.org/coach#hasAge">coach:hasAge</a>
    /// </summary>
    let hasAge = _prefixId.prefix "hasAge"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their level of agreeableness, as defined in the AgreeablenessScheme.</para>
    ///   <para>rdfs:label : hasAgreeableness</para>
    ///   <a href="https://w3id.org/coach#hasAgreeableness">coach:hasAgreeableness</a>
    /// </summary>
    let hasAgreeableness = _prefixId.prefix "hasAgreeableness"
    /// <summary>
    ///   <para>skos:editorialNote : More than a citizenship is allowed</para>
    ///   <para>skos:definition : Associates a Character with their country of citizenship.</para>
    ///   <para>rdfs:label : hasCitizenship</para>
    ///   <a href="https://w3id.org/coach#hasCitizenship">coach:hasCitizenship</a>
    /// </summary>
    let hasCitizenship = _prefixId.prefix "hasCitizenship"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their level of conscientiousness, as defined in the ConscientiousnessScheme.</para>
    ///   <para>rdfs:label : hasConscientiousness</para>
    ///   <a href="https://w3id.org/coach#hasConscientiousness">coach:hasConscientiousness</a>
    /// </summary>
    let hasConscientiousness = _prefixId.prefix "hasConscientiousness"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their country of birth, specifying the nation where the character was born.</para>
    ///   <para>rdfs:label : hasCountryOfBirth</para>
    ///   <a href="https://w3id.org/coach#hasCountryOfBirth">coach:hasCountryOfBirth</a>
    /// </summary>
    let hasCountryOfBirth = _prefixId.prefix "hasCountryOfBirth"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their educational background, as defined within the EducationScheme.</para>
    ///   <para>rdfs:label : hasEducation</para>
    ///   <a href="https://w3id.org/coach#hasEducation">coach:hasEducation</a>
    /// </summary>
    let hasEducation = _prefixId.prefix "hasEducation"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their level of extraversion, as defined within the ExtraversionScheme.</para>
    ///   <para>rdfs:label : hasExtraversion</para>
    ///   <a href="https://w3id.org/coach#hasExtraversion">coach:hasExtraversion</a>
    /// </summary>
    let hasExtraversion = _prefixId.prefix "hasExtraversion"
    /// <summary>
    ///   <para>skos:editorialNote : More than a language is allowed</para>
    ///   <para>skos:definition : Associates a Character with the natural languages they speak.</para>
    ///   <para>rdfs:label : hasLanguage^^xsd:string</para>
    ///   <a href="https://w3id.org/coach#hasLanguage">coach:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their level of neuroticism, as defined within the NeuroticismScheme.</para>
    ///   <para>rdfs:label : hasNeuroticism</para>
    ///   <a href="https://w3id.org/coach#hasNeuroticism">coach:hasNeuroticism</a>
    /// </summary>
    let hasNeuroticism = _prefixId.prefix "hasNeuroticism"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their level of openness, as defined within the   OpennessScheme.</para>
    ///   <para>rdfs:label : hasOpenness</para>
    ///   <a href="https://w3id.org/coach#hasOpenness">coach:hasOpenness</a>
    /// </summary>
    let hasOpenness = _prefixId.prefix "hasOpenness"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their political orientation.</para>
    ///   <para>rdfs:label : hasPoliticalOrientation</para>
    ///   <a href="https://w3id.org/coach#hasPoliticalOrientation">coach:hasPoliticalOrientation</a>
    /// </summary>
    let hasPoliticalOrientation = _prefixId.prefix "hasPoliticalOrientation"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their religion, specifying the religious belief system they adhere to.</para>
    ///   <para>rdfs:label : hasReligion</para>
    ///   <a href="https://w3id.org/coach#hasReligion">coach:hasReligion</a>
    /// </summary>
    let hasReligion = _prefixId.prefix "hasReligion"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their biological sex</para>
    ///   <para>rdfs:label : hasSex</para>
    ///   <a href="https://w3id.org/coach#hasSex">coach:hasSex</a>
    /// </summary>
    let hasSex = _prefixId.prefix "hasSex"
    /// <summary>
    ///   <para>skos:definition : Associates a Character with their sexual orientation</para>
    ///   <para>rdfs:label : hasSexualOrientation</para>
    ///   <a href="https://w3id.org/coach#hasSexualOrientation">coach:hasSexualOrientation</a>
    /// </summary>
    let hasSexualOrientation = _prefixId.prefix "hasSexualOrientation"
    /// <summary>
    ///   <para>skos:editorialNote : Better to use a wikipedia item.</para>
    ///   <para>skos:definition : Anything a Character dislikes</para>
    ///   <para>rdfs:label : likes</para>
    ///   <a href="https://w3id.org/coach#likes">coach:likes</a>
    /// </summary>
    let likes = _prefixId.prefix "likes"

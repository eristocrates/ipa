namespace https.w3id.org.coach.hash

open DoxAletheia

module coach =
    let _namespace_name = "https://w3id.org/coach#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#AgeScheme"></see>
    /// </summary>
    let AgeScheme = _prefix "AgeScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#AgreeablenessScheme"></see>
    /// </summary>
    let AgreeablenessScheme = _prefix "AgreeablenessScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#Character"></see>
    /// </summary>
    let Character = _prefix "Character"
    /// <summary>
    ///   <see href="https://w3id.org/coach#dimension"></see>
    /// </summary>
    let dimension = _prefix "dimension"
    /// <summary>
    ///   <see href="https://w3id.org/coach#ConscientiousnessScheme"></see>
    /// </summary>
    let ConscientiousnessScheme = _prefix "ConscientiousnessScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#EducationScheme"></see>
    /// </summary>
    let EducationScheme = _prefix "EducationScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#ExtraversionScheme"></see>
    /// </summary>
    let ExtraversionScheme = _prefix "ExtraversionScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#NeuroticismScheme"></see>
    /// </summary>
    let NeuroticismScheme = _prefix "NeuroticismScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#OpenessScheme"></see>
    /// </summary>
    let OpenessScheme = _prefix "OpenessScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#PoliticalOrientationScheme"></see>
    /// </summary>
    let PoliticalOrientationScheme = _prefix "PoliticalOrientationScheme"
    /// <summary>
    ///   <see href="https://w3id.org/coach#dislikes"></see>
    /// </summary>
    let dislikes = _prefix "dislikes"
    /// <summary>
    ///   <see href="https://w3id.org/coach#likes"></see>
    /// </summary>
    let likes = _prefix "likes"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasAge"></see>
    /// </summary>
    let hasAge = _prefix "hasAge"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasAgreeableness"></see>
    /// </summary>
    let hasAgreeableness = _prefix "hasAgreeableness"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasCitizenship"></see>
    /// </summary>
    let hasCitizenship = _prefix "hasCitizenship"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasConscientiousness"></see>
    /// </summary>
    let hasConscientiousness = _prefix "hasConscientiousness"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasCountryOfBirth"></see>
    /// </summary>
    let hasCountryOfBirth = _prefix "hasCountryOfBirth"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasEducation"></see>
    /// </summary>
    let hasEducation = _prefix "hasEducation"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasExtraversion"></see>
    /// </summary>
    let hasExtraversion = _prefix "hasExtraversion"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasLanguage"></see>
    /// </summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasNeuroticism"></see>
    /// </summary>
    let hasNeuroticism = _prefix "hasNeuroticism"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasOpenness"></see>
    /// </summary>
    let hasOpenness = _prefix "hasOpenness"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasPoliticalOrientation"></see>
    /// </summary>
    let hasPoliticalOrientation = _prefix "hasPoliticalOrientation"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasReligion"></see>
    /// </summary>
    let hasReligion = _prefix "hasReligion"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasSex"></see>
    /// </summary>
    let hasSex = _prefix "hasSex"
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasSexualOrientation"></see>
    /// </summary>
    let hasSexualOrientation = _prefix "hasSexualOrientation"

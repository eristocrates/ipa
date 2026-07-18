namespace https.w3id.org.coach.hash

open DoxAletheia.Rdf_Vocabulary

module coach =
    let _namespace_name = "https://w3id.org/coach#"
    /// <summary>
    ///   <see href="https://w3id.org/coach#AgeScheme"></see>
    /// </summary>
    let AgeScheme = Namespaced_IRI.parse _namespace_name "AgeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#AgreeablenessScheme"></see>
    /// </summary>
    let AgreeablenessScheme =
        Namespaced_IRI.parse _namespace_name "AgreeablenessScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#Character"></see>
    /// </summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/coach#dimension"></see>
    /// </summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#ConscientiousnessScheme"></see>
    /// </summary>
    let ConscientiousnessScheme =
        Namespaced_IRI.parse _namespace_name "ConscientiousnessScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#EducationScheme"></see>
    /// </summary>
    let EducationScheme =
        Namespaced_IRI.parse _namespace_name "EducationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#ExtraversionScheme"></see>
    /// </summary>
    let ExtraversionScheme =
        Namespaced_IRI.parse _namespace_name "ExtraversionScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#NeuroticismScheme"></see>
    /// </summary>
    let NeuroticismScheme =
        Namespaced_IRI.parse _namespace_name "NeuroticismScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#OpenessScheme"></see>
    /// </summary>
    let OpenessScheme =
        Namespaced_IRI.parse _namespace_name "OpenessScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#PoliticalOrientationScheme"></see>
    /// </summary>
    let PoliticalOrientationScheme =
        Namespaced_IRI.parse _namespace_name "PoliticalOrientationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#dislikes"></see>
    /// </summary>
    let dislikes = Namespaced_IRI.parse _namespace_name "dislikes" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/coach#likes"></see>
    /// </summary>
    let likes = Namespaced_IRI.parse _namespace_name "likes" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/coach#hasAge"></see>
    /// </summary>
    let hasAge = Namespaced_IRI.parse _namespace_name "hasAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasAgreeableness"></see>
    /// </summary>
    let hasAgreeableness =
        Namespaced_IRI.parse _namespace_name "hasAgreeableness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasCitizenship"></see>
    /// </summary>
    let hasCitizenship =
        Namespaced_IRI.parse _namespace_name "hasCitizenship" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasConscientiousness"></see>
    /// </summary>
    let hasConscientiousness =
        Namespaced_IRI.parse _namespace_name "hasConscientiousness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasCountryOfBirth"></see>
    /// </summary>
    let hasCountryOfBirth =
        Namespaced_IRI.parse _namespace_name "hasCountryOfBirth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasEducation"></see>
    /// </summary>
    let hasEducation =
        Namespaced_IRI.parse _namespace_name "hasEducation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasExtraversion"></see>
    /// </summary>
    let hasExtraversion =
        Namespaced_IRI.parse _namespace_name "hasExtraversion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasLanguage"></see>
    /// </summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasNeuroticism"></see>
    /// </summary>
    let hasNeuroticism =
        Namespaced_IRI.parse _namespace_name "hasNeuroticism" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasOpenness"></see>
    /// </summary>
    let hasOpenness =
        Namespaced_IRI.parse _namespace_name "hasOpenness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasPoliticalOrientation"></see>
    /// </summary>
    let hasPoliticalOrientation =
        Namespaced_IRI.parse _namespace_name "hasPoliticalOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasReligion"></see>
    /// </summary>
    let hasReligion =
        Namespaced_IRI.parse _namespace_name "hasReligion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasSex"></see>
    /// </summary>
    let hasSex = Namespaced_IRI.parse _namespace_name "hasSex" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/coach#hasSexualOrientation"></see>
    /// </summary>
    let hasSexualOrientation =
        Namespaced_IRI.parse _namespace_name "hasSexualOrientation" |> NamespacedName

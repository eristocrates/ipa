namespace https.w3id.org.coach.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module coach =
    let _namespace_iri = Namespace_Iri coach |> NamespaceIRI
    /// <summary>
    ///   <para>coach:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>COACH</para></remarks>
    /// <seealso href="https://w3id.org/coach#">https://w3id.org/coach#</seealso>
    let _prefix_iri = Prefixed_Name(coach, "") |> PrefixedName

    /// <summary>
    ///   <para>coach:AgreeablenessScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#AgreeablenessScheme">https://w3id.org/coach#AgreeablenessScheme</seealso>
    let AgreeablenessScheme =
        Prefixed_Name(coach, "AgreeablenessScheme") |> PrefixedName

    /// <summary>
    ///   <para>coach:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Character</para></remarks>
    /// <seealso href="https://w3id.org/coach#Character">https://w3id.org/coach#Character</seealso>
    let Character = Prefixed_Name(coach, "Character") |> PrefixedName
    /// <summary>
    ///   <para>coach:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasDimension</para></remarks>
    /// <seealso href="https://w3id.org/coach#dimension">https://w3id.org/coach#dimension</seealso>
    let dimension = Prefixed_Name(coach, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>coach:ExtraversionScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#ExtraversionScheme">https://w3id.org/coach#ExtraversionScheme</seealso>
    let ExtraversionScheme = Prefixed_Name(coach, "ExtraversionScheme") |> PrefixedName
    /// <summary>
    ///   <para>coach:NeuroticismScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#NeuroticismScheme">https://w3id.org/coach#NeuroticismScheme</seealso>
    let NeuroticismScheme = Prefixed_Name(coach, "NeuroticismScheme") |> PrefixedName
    /// <summary>
    ///   <para>coach:OpenessScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#OpenessScheme">https://w3id.org/coach#OpenessScheme</seealso>
    let OpenessScheme = Prefixed_Name(coach, "OpenessScheme") |> PrefixedName

    /// <summary>
    ///   <para>coach:PoliticalOrientationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#PoliticalOrientationScheme">https://w3id.org/coach#PoliticalOrientationScheme</seealso>
    let PoliticalOrientationScheme =
        Prefixed_Name(coach, "PoliticalOrientationScheme") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasAgreeableness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasAgreeableness</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasAgreeableness">https://w3id.org/coach#hasAgreeableness</seealso>
    let hasAgreeableness = Prefixed_Name(coach, "hasAgreeableness") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasConscientiousness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasConscientiousness</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasConscientiousness">https://w3id.org/coach#hasConscientiousness</seealso>
    let hasConscientiousness =
        Prefixed_Name(coach, "hasConscientiousness") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasCountryOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasCountryOfBirth</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasCountryOfBirth">https://w3id.org/coach#hasCountryOfBirth</seealso>
    let hasCountryOfBirth = Prefixed_Name(coach, "hasCountryOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasExtraversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasExtraversion</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasExtraversion">https://w3id.org/coach#hasExtraversion</seealso>
    let hasExtraversion = Prefixed_Name(coach, "hasExtraversion") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasLanguage</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasLanguage">https://w3id.org/coach#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(coach, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasOpenness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasOpenness</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasOpenness">https://w3id.org/coach#hasOpenness</seealso>
    let hasOpenness = Prefixed_Name(coach, "hasOpenness") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasPoliticalOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasPoliticalOrientation</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasPoliticalOrientation">https://w3id.org/coach#hasPoliticalOrientation</seealso>
    let hasPoliticalOrientation =
        Prefixed_Name(coach, "hasPoliticalOrientation") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasReligion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasReligion</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasReligion">https://w3id.org/coach#hasReligion</seealso>
    let hasReligion = Prefixed_Name(coach, "hasReligion") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasSex</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasSex">https://w3id.org/coach#hasSex</seealso>
    let hasSex = Prefixed_Name(coach, "hasSex") |> PrefixedName
    /// <summary>
    ///   <para>coach:AgeScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#AgeScheme">https://w3id.org/coach#AgeScheme</seealso>
    let AgeScheme = Prefixed_Name(coach, "AgeScheme") |> PrefixedName

    /// <summary>
    ///   <para>coach:ConscientiousnessScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#ConscientiousnessScheme">https://w3id.org/coach#ConscientiousnessScheme</seealso>
    let ConscientiousnessScheme =
        Prefixed_Name(coach, "ConscientiousnessScheme") |> PrefixedName

    /// <summary>
    ///   <para>coach:EducationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/coach#EducationScheme">https://w3id.org/coach#EducationScheme</seealso>
    let EducationScheme = Prefixed_Name(coach, "EducationScheme") |> PrefixedName
    /// <summary>
    ///   <para>coach:dislikes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dislikes</para></remarks>
    /// <seealso href="https://w3id.org/coach#dislikes">https://w3id.org/coach#dislikes</seealso>
    let dislikes = Prefixed_Name(coach, "dislikes") |> PrefixedName
    /// <summary>
    ///   <para>coach:likes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>likes</para></remarks>
    /// <seealso href="https://w3id.org/coach#likes">https://w3id.org/coach#likes</seealso>
    let likes = Prefixed_Name(coach, "likes") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>hasAge</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasAge">https://w3id.org/coach#hasAge</seealso>
    let hasAge = Prefixed_Name(coach, "hasAge") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasCitizenship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasCitizenship</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasCitizenship">https://w3id.org/coach#hasCitizenship</seealso>
    let hasCitizenship = Prefixed_Name(coach, "hasCitizenship") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasEducation</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasEducation">https://w3id.org/coach#hasEducation</seealso>
    let hasEducation = Prefixed_Name(coach, "hasEducation") |> PrefixedName
    /// <summary>
    ///   <para>coach:hasNeuroticism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasNeuroticism</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasNeuroticism">https://w3id.org/coach#hasNeuroticism</seealso>
    let hasNeuroticism = Prefixed_Name(coach, "hasNeuroticism") |> PrefixedName

    /// <summary>
    ///   <para>coach:hasSexualOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasSexualOrientation</para></remarks>
    /// <seealso href="https://w3id.org/coach#hasSexualOrientation">https://w3id.org/coach#hasSexualOrientation</seealso>
    let hasSexualOrientation =
        Prefixed_Name(coach, "hasSexualOrientation") |> PrefixedName

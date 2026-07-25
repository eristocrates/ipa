namespace http.rdf.muninn_project.org.ontologies.appearances.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module appear =
    let _namespace_iri = Namespace_Iri appear |> NamespaceIRI

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>S</para>
    /// labels<para>UK CensusCodes</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCode">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCode</seealso>
    let EthnicityUKCensusCode =
        Prefixed_Name(appear, "EthnicityUKCensusCode") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorRiddell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Riddell Eye Color Reference. The Riddell standard makes use of a three part scale that marks up the main colour of the eye, the diffuse color of the eye and any colour spots within the eye.</para>
    /// labels<para>Riddell Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorRiddell">http://rdf.muninn-project.org/ontologies/appearances#EyeColorRiddell</seealso>
    let EyeColorRiddell = Prefixed_Name(appear, "EyeColorRiddell") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorSimple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple eye color reference.</para>
    /// labels<para>Simple Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimple">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimple</seealso>
    let EyeColorSimple = Prefixed_Name(appear, "EyeColorSimple") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorSimpleGreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Green</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleGreen">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleGreen</seealso>
    let EyeColorSimpleGreen =
        Prefixed_Name(appear, "EyeColorSimpleGreen") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorSimpleGrey</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Grey</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleGrey">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleGrey</seealso>
    let EyeColorSimpleGrey = Prefixed_Name(appear, "EyeColorSimpleGrey") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeLight</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeLight">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeLight</seealso>
    let EyeColorWildeLight = Prefixed_Name(appear, "EyeColorWildeLight") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeBlue</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Blue (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBlue">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBlue</seealso>
    let EyeColorWildeBlue = Prefixed_Name(appear, "EyeColorWildeBlue") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Brown (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBrown</seealso>
    let EyeColorWildeBrown = Prefixed_Name(appear, "EyeColorWildeBrown") |> PrefixedName
    /// <summary>
    ///   <para>appear:e_s_gragoudas</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    ///   <para>swrc:Person</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#e_s_gragoudas">http://rdf.muninn-project.org/ontologies/appearances#e_s_gragoudas</seealso>
    let e_s_gragoudas = Prefixed_Name(appear, "e_s_gragoudas") |> PrefixedName
    /// <summary>
    ///   <para>appear:florent_cunier</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Organization</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#florent_cunier">http://rdf.muninn-project.org/ontologies/appearances#florent_cunier</seealso>
    let florent_cunier = Prefixed_Name(appear, "florent_cunier") |> PrefixedName
    /// <summary>
    ///   <para>appear:hasBodyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Body Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasBodyMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasBodyMeasurement</seealso>
    let hasBodyMeasurement = Prefixed_Name(appear, "hasBodyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasBandMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Band Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementInches</seealso>
    let hasBandMeasurementInches =
        Prefixed_Name(appear, "hasBandMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz8</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Yellow Brown and Brown Green (8)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz8">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz8</seealso>
    let EyeColorMartinSchultz8 =
        Prefixed_Name(appear, "EyeColorMartinSchultz8") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz12</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Brown and Brown Black (12)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz12">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz12</seealso>
    let EyeColorMartinSchultz12 =
        Prefixed_Name(appear, "EyeColorMartinSchultz12") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantK</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Most Brown (K)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantK">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantK</seealso>
    let EyeColorGrieveMorantK =
        Prefixed_Name(appear, "EyeColorGrieveMorantK") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz13</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Brown and Brown Black (13)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz13">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz13</seealso>
    let EyeColorMartinSchultz13 =
        Prefixed_Name(appear, "EyeColorMartinSchultz13") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimpleAlbino</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorSimple</para>
    ///
    /// labels<para>Simple Skin Color Albino</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleAlbino">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleAlbino</seealso>
    let SkinColorSimpleAlbino =
        Prefixed_Name(appear, "SkinColorSimpleAlbino") |> PrefixedName

    /// <summary>
    ///   <para>appear:adriel</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#adriel">http://rdf.muninn-project.org/ontologies/appearances#adriel</seealso>
    let adriel = Prefixed_Name(appear, "adriel") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantE</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Traces of Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantE">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantE</seealso>
    let EyeColorGrieveMorantE =
        Prefixed_Name(appear, "EyeColorGrieveMorantE") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantF</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>More Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantF">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantF</seealso>
    let EyeColorGrieveMorantF =
        Prefixed_Name(appear, "EyeColorGrieveMorantF") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz7</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Yellow Brown and Brown Green (7)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz7">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz7</seealso>
    let EyeColorMartinSchultz7 =
        Prefixed_Name(appear, "EyeColorMartinSchultz7") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz10</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Yellow Brown and Brown Green (10)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz10">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz10</seealso>
    let EyeColorMartinSchultz10 =
        Prefixed_Name(appear, "EyeColorMartinSchultz10") |> PrefixedName

    /// <summary>
    ///   <para>appear:AHG_AHG2288</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>swrc:Publication</para>
    ///
    /// labels<para>RIDDELL, W. J. B.. STUDIES IN THE CLASSIFICATION OF EYE COLOUR. Annals of Eugenics 11(1), Blackwell Publishing Ltd, 1941</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#AHG_AHG2288">http://rdf.muninn-project.org/ontologies/appearances#AHG_AHG2288</seealso>
    let AHG_AHG2288 = Prefixed_Name(appear, "AHG_AHG2288") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Iris Color Classification System</para>
    /// labels<para>Iris Color Classification System</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS</seealso>
    let EyeColorICCS = Prefixed_Name(appear, "EyeColorICCS") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorICCS</para>
    ///
    /// labels<para>Green with Yellow Specks (ICCS #2)</para><para>Gray with Yellow Specks (ICCS #2)</para><para>Green with Brown Specks (ICCS #2)</para><para>Blue with Yellow Specks (ICCS #2)</para><para>Gray with Brown Specks (ICCS #2)</para><para>Blue with Brown Specks (ICCS #2)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS2">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS2</seealso>
    let EyeColorICCS2 = Prefixed_Name(appear, "EyeColorICCS2") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorICCS</para>
    ///
    /// labels<para>Light Brown with Yellow Specks (ICCS #3)</para><para>Light Brown with Brown Specks (ICCS #3)</para><para>Green with Yellow Specks (ICCS #3)</para><para>Green with Brown Specks (ICCS #3)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS3">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS3</seealso>
    let EyeColorICCS3 = Prefixed_Name(appear, "EyeColorICCS3") |> PrefixedName
    /// <summary>
    ///   <para>appear:riddell_w_j_b</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#riddell_w_j_b">http://rdf.muninn-project.org/ontologies/appearances#riddell_w_j_b</seealso>
    let riddell_w_j_b = Prefixed_Name(appear, "riddell_w_j_b") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz1a</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Light Blue Iris (1a)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1a">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1a</seealso>
    let EyeColorMartinSchultz1a =
        Prefixed_Name(appear, "EyeColorMartinSchultz1a") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz2a</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Light Blue Iris (2a)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz2a">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz2a</seealso>
    let EyeColorMartinSchultz2a =
        Prefixed_Name(appear, "EyeColorMartinSchultz2a") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz4a</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Gray Iris (4a)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4a">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4a</seealso>
    let EyeColorMartinSchultz4a =
        Prefixed_Name(appear, "EyeColorMartinSchultz4a") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz6</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Gray (6)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz6">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz6</seealso>
    let EyeColorMartinSchultz6 =
        Prefixed_Name(appear, "EyeColorMartinSchultz6") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Yellow Brown and Brown Green (9)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz9">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz9</seealso>
    let EyeColorMartinSchultz9 =
        Prefixed_Name(appear, "EyeColorMartinSchultz9") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>EyeColorNebraskaDMV</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMV">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMV</seealso>
    let EyeColorNebraskaDMV =
        Prefixed_Name(appear, "EyeColorNebraskaDMV") |> PrefixedName

    /// <summary>
    ///   <para>appear:NebraskaDMVStandards</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Nebraska DMV Standards</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#NebraskaDMVStandards">http://rdf.muninn-project.org/ontologies/appearances#NebraskaDMVStandards</seealso>
    let NebraskaDMVStandards =
        Prefixed_Name(appear, "NebraskaDMVStandards") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVGray</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Gray</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVGray">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVGray</seealso>
    let EyeColorNebraskaDMVGray =
        Prefixed_Name(appear, "EyeColorNebraskaDMVGray") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVGreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Green</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVGreen">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVGreen</seealso>
    let EyeColorNebraskaDMVGreen =
        Prefixed_Name(appear, "EyeColorNebraskaDMVGreen") |> PrefixedName

    /// <summary>
    ///   <para>appear:j_petrequin</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    ///   <para>swrc:Person</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#j_petrequin">http://rdf.muninn-project.org/ontologies/appearances#j_petrequin</seealso>
    let j_petrequin = Prefixed_Name(appear, "j_petrequin") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequinBruns</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorPetrequin</para>
    ///
    /// labels<para>Brown (Pétrequin)</para><para>Bruns (Pétrequin)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinBruns">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinBruns</seealso>
    let EyeColorPetrequinBruns =
        Prefixed_Name(appear, "EyeColorPetrequinBruns") |> PrefixedName

    /// <summary>
    ///   <para>appear:c_r_sahagian</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#c_r_sahagian">http://rdf.muninn-project.org/ontologies/appearances#c_r_sahagian</seealso>
    let c_r_sahagian = Prefixed_Name(appear, "c_r_sahagian") |> PrefixedName
    /// <summary>
    ///   <para>appear:hasAppearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Appearance</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasAppearance">http://rdf.muninn-project.org/ontologies/appearances#hasAppearance</seealso>
    let hasAppearance = Prefixed_Name(appear, "hasAppearance") |> PrefixedName
    /// <summary>
    ///   <para>appear:hasArmMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Arm Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurement</seealso>
    let hasArmMeasurement = Prefixed_Name(appear, "hasArmMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasArmMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Arm Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementInches</seealso>
    let hasArmMeasurementInches =
        Prefixed_Name(appear, "hasArmMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasArmMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Arm Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementMeters</seealso>
    let hasArmMeasurementMeters =
        Prefixed_Name(appear, "hasArmMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasBandMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Band Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurement</seealso>
    let hasBandMeasurement = Prefixed_Name(appear, "hasBandMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasBandMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Band Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementMeters</seealso>
    let hasBandMeasurementMeters =
        Prefixed_Name(appear, "hasBandMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasChestMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Chest Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurement</seealso>
    let hasChestMeasurement =
        Prefixed_Name(appear, "hasChestMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasChestMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Chest Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementInches</seealso>
    let hasChestMeasurementInches =
        Prefixed_Name(appear, "hasChestMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasChestMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Chest Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementMeters</seealso>
    let hasChestMeasurementMeters =
        Prefixed_Name(appear, "hasChestMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasEntertaimentPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Entertaiment Preference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentPreference">http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentPreference</seealso>
    let hasEntertaimentPreference =
        Prefixed_Name(appear, "hasEntertaimentPreference") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Gender</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasGender">http://rdf.muninn-project.org/ontologies/appearances#hasGender</seealso>
    let hasGender = Prefixed_Name(appear, "hasGender") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHeightMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Height Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurement</seealso>
    let hasHeightMeasurement =
        Prefixed_Name(appear, "hasHeightMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHeightMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Height Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementInches</seealso>
    let hasHeightMeasurementInches =
        Prefixed_Name(appear, "hasHeightMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHeightMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Height Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementMeters</seealso>
    let hasHeightMeasurementMeters =
        Prefixed_Name(appear, "hasHeightMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHipsMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Hips Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurement</seealso>
    let hasHipsMeasurement = Prefixed_Name(appear, "hasHipsMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasInseamMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Inseam Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurement</seealso>
    let hasInseamMeasurement =
        Prefixed_Name(appear, "hasInseamMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasInseamMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Inseam Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementInches</seealso>
    let hasInseamMeasurementInches =
        Prefixed_Name(appear, "hasInseamMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasInseamMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Inseam Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementMeters</seealso>
    let hasInseamMeasurementMeters =
        Prefixed_Name(appear, "hasInseamMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasKneeLengthMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Knee Length Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurement</seealso>
    let hasKneeLengthMeasurement =
        Prefixed_Name(appear, "hasKneeLengthMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasNeckMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Neck Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurement</seealso>
    let hasNeckMeasurement = Prefixed_Name(appear, "hasNeckMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasNeckMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Neck Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementInches</seealso>
    let hasNeckMeasurementInches =
        Prefixed_Name(appear, "hasNeckMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasNeckMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Neck Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementMeters</seealso>
    let hasNeckMeasurementMeters =
        Prefixed_Name(appear, "hasNeckMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasOverArmMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Over Arm Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurement</seealso>
    let hasOverArmMeasurement =
        Prefixed_Name(appear, "hasOverArmMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasOverArmMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Over Arm Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementMeters</seealso>
    let hasOverArmMeasurementMeters =
        Prefixed_Name(appear, "hasOverArmMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasPantLengthMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Pant Length Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurement</seealso>
    let hasPantLengthMeasurement =
        Prefixed_Name(appear, "hasPantLengthMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasPantLengthMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Pant Length Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementInches</seealso>
    let hasPantLengthMeasurementInches =
        Prefixed_Name(appear, "hasPantLengthMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasPantLengthMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Pant Length Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementMeters</seealso>
    let hasPantLengthMeasurementMeters =
        Prefixed_Name(appear, "hasPantLengthMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasRomanticAversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Romantic Aversion</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasRomanticAversion">http://rdf.muninn-project.org/ontologies/appearances#hasRomanticAversion</seealso>
    let hasRomanticAversion =
        Prefixed_Name(appear, "hasRomanticAversion") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasRomanticPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Romantic Preference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasRomanticPreference">http://rdf.muninn-project.org/ontologies/appearances#hasRomanticPreference</seealso>
    let hasRomanticPreference =
        Prefixed_Name(appear, "hasRomanticPreference") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Sex</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasSex">http://rdf.muninn-project.org/ontologies/appearances#hasSex</seealso>
    let hasSex = Prefixed_Name(appear, "hasSex") |> PrefixedName
    /// <summary>
    ///   <para>appear:hasSexualAversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Sexual Aversion</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasSexualAversion">http://rdf.muninn-project.org/ontologies/appearances#hasSexualAversion</seealso>
    let hasSexualAversion = Prefixed_Name(appear, "hasSexualAversion") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasSexualPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Sexual Preference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasSexualPreference">http://rdf.muninn-project.org/ontologies/appearances#hasSexualPreference</seealso>
    let hasSexualPreference =
        Prefixed_Name(appear, "hasSexualPreference") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasThighMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Thigh Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurement</seealso>
    let hasThighMeasurement =
        Prefixed_Name(appear, "hasThighMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasThighMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Thigh Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementMeters</seealso>
    let hasThighMeasurementMeters =
        Prefixed_Name(appear, "hasThighMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasWaistMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Waist Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurement">http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurement</seealso>
    let hasWaistMeasurement =
        Prefixed_Name(appear, "hasWaistMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasWaistMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Waist Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementInches</seealso>
    let hasWaistMeasurementInches =
        Prefixed_Name(appear, "hasWaistMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasWaistMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Waist Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementMeters</seealso>
    let hasWaistMeasurementMeters =
        Prefixed_Name(appear, "hasWaistMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:john_churchill</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Organization</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#john_churchill">http://rdf.muninn-project.org/ontologies/appearances#john_churchill</seealso>
    let john_churchill = Prefixed_Name(appear, "john_churchill") |> PrefixedName
    /// <summary>
    ///   <para>appear:r_d_sperduto</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#r_d_sperduto">http://rdf.muninn-project.org/ontologies/appearances#r_d_sperduto</seealso>
    let r_d_sperduto = Prefixed_Name(appear, "r_d_sperduto") |> PrefixedName
    /// <summary>
    ///   <para>appear:r_j_glynn</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    ///   <para>swrc:Person</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#r_j_glynn">http://rdf.muninn-project.org/ontologies/appearances#r_j_glynn</seealso>
    let r_j_glynn = Prefixed_Name(appear, "r_j_glynn") |> PrefixedName

    /// <summary>
    ///   <para>appear:blackwell_publishing_ltd</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Organization</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#blackwell_publishing_ltd">http://rdf.muninn-project.org/ontologies/appearances#blackwell_publishing_ltd</seealso>
    let blackwell_publishing_ltd =
        Prefixed_Name(appear, "blackwell_publishing_ltd") |> PrefixedName

    /// <summary>
    ///   <para>appear:morant_g_m</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    ///   <para>swrc:Person</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#morant_g_m">http://rdf.muninn-project.org/ontologies/appearances#morant_g_m</seealso>
    let morant_g_m = Prefixed_Name(appear, "morant_g_m") |> PrefixedName
    /// <summary>
    ///   <para>appear:grieve_j</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    ///   <para>swrc:Person</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#grieve_j">http://rdf.muninn-project.org/ontologies/appearances#grieve_j</seealso>
    let grieve_j = Prefixed_Name(appear, "grieve_j") |> PrefixedName
    /// <summary>
    ///   <para>appear:seddon</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Publication</para>
    ///   <para>swrc:Article</para>
    ///
    /// labels<para>J. M. Seddon, C. R. Sahagian, R. J. Glynn, R. D. Sperduto, E. S. Gragoudas. Evaluation of an iris color classification system. The Eye Disorders Case-Control Study Group.. Investigative Ophthalmology &amp; Visual Science 31(8), August, 1990</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#seddon">http://rdf.muninn-project.org/ontologies/appearances#seddon</seealso>
    let seddon = Prefixed_Name(appear, "seddon") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>EyeColorMartinSchultz</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz</seealso>
    let EyeColorMartinSchultz =
        Prefixed_Name(appear, "EyeColorMartinSchultz") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz11</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Yellow Brown and Brown Green (11)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz11">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz11</seealso>
    let EyeColorMartinSchultz11 =
        Prefixed_Name(appear, "EyeColorMartinSchultz11") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz15</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Brown and Brown Black (15)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz15">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz15</seealso>
    let EyeColorMartinSchultz15 =
        Prefixed_Name(appear, "EyeColorMartinSchultz15") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz1b</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Light Blue Iris (1b)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1b">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1b</seealso>
    let EyeColorMartinSchultz1b =
        Prefixed_Name(appear, "EyeColorMartinSchultz1b") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz2b</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Blue Iris (2b)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz2b">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz2b</seealso>
    let EyeColorMartinSchultz2b =
        Prefixed_Name(appear, "EyeColorMartinSchultz2b") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultzLightBlue</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Light Blue Iris</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultzLightBlue">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultzLightBlue</seealso>
    let EyeColorMartinSchultzLightBlue =
        Prefixed_Name(appear, "EyeColorMartinSchultzLightBlue") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVBlack</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBlack">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBlack</seealso>
    let EyeColorNebraskaDMVBlack =
        Prefixed_Name(appear, "EyeColorNebraskaDMVBlack") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVBlue</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBlue">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBlue</seealso>
    let EyeColorNebraskaDMVBlue =
        Prefixed_Name(appear, "EyeColorNebraskaDMVBlue") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVBrown</seealso>
    let EyeColorNebraskaDMVBrown =
        Prefixed_Name(appear, "EyeColorNebraskaDMVBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVDichromatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Dichromatic</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVDichromatic">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVDichromatic</seealso>
    let EyeColorNebraskaDMVDichromatic =
        Prefixed_Name(appear, "EyeColorNebraskaDMVDichromatic") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVHazel</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Hazel</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVHazel">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVHazel</seealso>
    let EyeColorNebraskaDMVHazel =
        Prefixed_Name(appear, "EyeColorNebraskaDMVHazel") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVPink</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Pink</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVPink">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVPink</seealso>
    let EyeColorNebraskaDMVPink =
        Prefixed_Name(appear, "EyeColorNebraskaDMVPink") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorNebraskaDMVUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorNebraskaDMV</para>
    ///
    /// labels<para>Unknown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVUnknown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMVUnknown</seealso>
    let EyeColorNebraskaDMVUnknown =
        Prefixed_Name(appear, "EyeColorNebraskaDMVUnknown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequin</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///   <para>Pétrequin Eye Color Reference.</para>
    /// labels<para>Pétrequin Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequin">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequin</seealso>
    let EyeColorPetrequin = Prefixed_Name(appear, "EyeColorPetrequin") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequinNoirs</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorPetrequin</para>
    ///
    /// labels<para>Black (Pétrequin)</para><para>Noirs (Pétrequin)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinNoirs">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinNoirs</seealso>
    let EyeColorPetrequinNoirs =
        Prefixed_Name(appear, "EyeColorPetrequinNoirs") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequinGris</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorPetrequin</para>
    ///
    /// labels<para>Gray (Pétrequin)</para><para>Gris (Pétrequin)</para><para>Grey (Pétrequin)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinGris">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinGris</seealso>
    let EyeColorPetrequinGris =
        Prefixed_Name(appear, "EyeColorPetrequinGris") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequinBleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorPetrequin</para>
    ///
    /// labels<para>Bleus (Pétrequin)</para><para>Blue (Pétrequin)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinBleus">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinBleus</seealso>
    let EyeColorPetrequinBleus =
        Prefixed_Name(appear, "EyeColorPetrequinBleus") |> PrefixedName

    /// <summary>
    ///   <para>appear:petrequin</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>swrc:Publication</para>
    ///
    /// labels<para>J. Petrequin. Sur les diverses couleurs de l'iris et leurs proportions dens nos climats.. Annales D'oculistique 10, Florent Cunier, 1843</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#petrequin">http://rdf.muninn-project.org/ontologies/appearances#petrequin</seealso>
    let petrequin = Prefixed_Name(appear, "petrequin") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorICCS</para>
    ///
    /// labels<para>Gray with Yellow Specks (ICCS #1)</para><para>Blue with Yellow Specks (ICCS #1)</para><para>Gray with Brown Specks (ICCS #1)</para><para>Blue with Brown Specks (ICCS #1)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS1">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS1</seealso>
    let EyeColorICCS1 = Prefixed_Name(appear, "EyeColorICCS1") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS5</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorICCS</para>
    ///
    /// labels<para>Brown (ICCS #5)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS5">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS5</seealso>
    let EyeColorICCS5 = Prefixed_Name(appear, "EyeColorICCS5") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorICCS4</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorICCS</para>
    ///
    /// labels<para>Brown (ICCS #4)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS4">http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS4</seealso>
    let EyeColorICCS4 = Prefixed_Name(appear, "EyeColorICCS4") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz16</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Brown and Brown Black (16)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz16">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz16</seealso>
    let EyeColorMartinSchultz16 =
        Prefixed_Name(appear, "EyeColorMartinSchultz16") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz1c</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Light Blue Iris (1c)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1c">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1c</seealso>
    let EyeColorMartinSchultz1c =
        Prefixed_Name(appear, "EyeColorMartinSchultz1c") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz4b</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Gray Iris (4b)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4b">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4b</seealso>
    let EyeColorMartinSchultz4b =
        Prefixed_Name(appear, "EyeColorMartinSchultz4b") |> PrefixedName

    /// <summary>
    ///   <para>appear:AHG_AHG2354</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Article</para>
    ///   <para>swrc:Publication</para>
    ///
    /// labels<para>GRIEVE, J., MORANT, G. M.. RECORDS OF EYE COLOURS FOR BRITISH POPULATIONS AND A DESCRIPTION OF A NEW EYE-COLOUR SCALE. Annals of Eugenics 13(1), Blackwell Publishing Ltd, 1946</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#AHG_AHG2354">http://rdf.muninn-project.org/ontologies/appearances#AHG_AHG2354</seealso>
    let AHG_AHG2354 = Prefixed_Name(appear, "AHG_AHG2354") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorPetrequinRoux</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorPetrequin</para>
    ///
    /// labels<para>Roux (Pétrequin)</para><para>Red (Pétrequin)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinRoux">http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequinRoux</seealso>
    let EyeColorPetrequinRoux =
        Prefixed_Name(appear, "EyeColorPetrequinRoux") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorSimpleBlack</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBlack">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBlack</seealso>
    let EyeColorSimpleBlack =
        Prefixed_Name(appear, "EyeColorSimpleBlack") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorSimpleBlue</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBlue">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBlue</seealso>
    let EyeColorSimpleBlue = Prefixed_Name(appear, "EyeColorSimpleBlue") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorSimpleRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Red</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleRed">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleRed</seealso>
    let EyeColorSimpleRed = Prefixed_Name(appear, "EyeColorSimpleRed") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Dark (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeDark">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeDark</seealso>
    let EyeColorWildeDark = Prefixed_Name(appear, "EyeColorWildeDark") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeHazel</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Hazel (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeHazel">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeHazel</seealso>
    let EyeColorWildeHazel = Prefixed_Name(appear, "EyeColorWildeHazel") |> PrefixedName
    /// <summary>
    ///   <para>appear:wilde1862</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Book</para>
    ///   <para>swrc:Publication</para>
    ///
    /// labels<para>William Robert Wilde. An Essay on the malformations and congenital diseases of the organs of sight, John Churchill, 1862</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#wilde1862">http://rdf.muninn-project.org/ontologies/appearances#wilde1862</seealso>
    let wilde1862 = Prefixed_Name(appear, "wilde1862") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorWildeGray</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Gray (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeGray">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeGray</seealso>
    let EyeColorWildeGray = Prefixed_Name(appear, "EyeColorWildeGray") |> PrefixedName

    /// <summary>
    ///   <para>appear:FemaleBodyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Female Body Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FemaleBodyMeasurement">http://rdf.muninn-project.org/ontologies/appearances#FemaleBodyMeasurement</seealso>
    let FemaleBodyMeasurement =
        Prefixed_Name(appear, "FemaleBodyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:SexISO5218-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexISO5218</para>
    ///
    /// labels<para>Femme</para><para>Woman</para><para>Frau</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-2">http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-2</seealso>
    let SexISO5218_2 = Prefixed_Name(appear, "SexISO5218-2") |> PrefixedName
    /// <summary>
    ///   <para>appear:GenderSimple-F</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:GenderSimple</para>
    ///
    /// labels<para>Femme</para><para>Woman</para><para>Frau</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#GenderSimple-F">http://rdf.muninn-project.org/ontologies/appearances#GenderSimple-F</seealso>
    let GenderSimple_F = Prefixed_Name(appear, "GenderSimple-F") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hair Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColor">http://rdf.muninn-project.org/ontologies/appearances#HairColor</seealso>
    let HairColor = Prefixed_Name(appear, "HairColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBrown</seealso>
    let HairColorAtlasBrown =
        Prefixed_Name(appear, "HairColorAtlasBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBlond</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Blond (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlond">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlond</seealso>
    let HairColorAtlasBlond =
        Prefixed_Name(appear, "HairColorAtlasBlond") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasAbsent</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>White (Human Hair Atlas)</para><para>Gray (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasAbsent">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasAbsent</seealso>
    let HairColorAtlasAbsent =
        Prefixed_Name(appear, "HairColorAtlasAbsent") |> PrefixedName

    /// <summary>
    ///   <para>appear:Ogle_1999fk</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Book</para>
    ///   <para>swrc:Publication</para>
    ///
    /// labels<para>Ogle, Robert R, Fox, Michelle J. Atlas of human hair microscopic characteristics, CRC Press, 1999</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Ogle_1999fk">http://rdf.muninn-project.org/ontologies/appearances#Ogle_1999fk</seealso>
    let Ogle_1999fk = Prefixed_Name(appear, "Ogle_1999fk") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBlondDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Dark Blond (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondDark">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondDark</seealso>
    let HairColorAtlasBlondDark =
        Prefixed_Name(appear, "HairColorAtlasBlondDark") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBlondLight</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Blond (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondLight">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondLight</seealso>
    let HairColorAtlasBlondLight =
        Prefixed_Name(appear, "HairColorAtlasBlondLight") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBlondMediumDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Blond (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondMediumDark">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondMediumDark</seealso>
    let HairColorAtlasBlondMediumDark =
        Prefixed_Name(appear, "HairColorAtlasBlondMediumDark") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasDarkGoldenBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Dark Golden Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkGoldenBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkGoldenBrown</seealso>
    let HairColorAtlasDarkGoldenBrown =
        Prefixed_Name(appear, "HairColorAtlasDarkGoldenBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasDarkRedBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Dark Red Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkRedBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkRedBrown</seealso>
    let HairColorAtlasDarkRedBrown =
        Prefixed_Name(appear, "HairColorAtlasDarkRedBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightGrayBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Gray Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightGrayBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightGrayBrown</seealso>
    let HairColorAtlasLightGrayBrown =
        Prefixed_Name(appear, "HairColorAtlasLightGrayBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightMediumBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light to Medium Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumBrown</seealso>
    let HairColorAtlasLightMediumBrown =
        Prefixed_Name(appear, "HairColorAtlasLightMediumBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightMediumRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light to Medium Red (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumRed</seealso>
    let HairColorAtlasLightMediumRed =
        Prefixed_Name(appear, "HairColorAtlasLightMediumRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightMediumRedBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light to Medium Red Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumRedBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumRedBrown</seealso>
    let HairColorAtlasLightMediumRedBrown =
        Prefixed_Name(appear, "HairColorAtlasLightMediumRedBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasMediumDarkBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkBrown</seealso>
    let HairColorAtlasMediumDarkBrown =
        Prefixed_Name(appear, "HairColorAtlasMediumDarkBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasMediumDarkGoldenBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Golden Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkGoldenBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkGoldenBrown</seealso>
    let HairColorAtlasMediumDarkGoldenBrown =
        Prefixed_Name(appear, "HairColorAtlasMediumDarkGoldenBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasMediumDarkRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Red (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkRed</seealso>
    let HairColorAtlasMediumDarkRed =
        Prefixed_Name(appear, "HairColorAtlasMediumDarkRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasMediumDarkRedBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Red Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkRedBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkRedBrown</seealso>
    let HairColorAtlasMediumDarkRedBrown =
        Prefixed_Name(appear, "HairColorAtlasMediumDarkRedBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHipsMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Hips Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementInches</seealso>
    let hasHipsMeasurementInches =
        Prefixed_Name(appear, "hasHipsMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasHipsMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Hips Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementMeters</seealso>
    let hasHipsMeasurementMeters =
        Prefixed_Name(appear, "hasHipsMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeA3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Bangladeshi</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA3">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA3</seealso>
    let EthnicityUKCensusCodeA3 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeA3") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeB1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Caribbean</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB1</seealso>
    let EthnicityUKCensusCodeB1 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeB1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeB2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>African</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB2">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB2</seealso>
    let EthnicityUKCensusCodeB2 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeB2") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasDarkOpaqueGrayBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Black, Dark Gray Brown to Opaque Gray Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkOpaqueGrayBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkOpaqueGrayBrown</seealso>
    let HairColorAtlasDarkOpaqueGrayBrown =
        Prefixed_Name(appear, "HairColorAtlasDarkOpaqueGrayBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightGoldenBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Golden Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightGoldenBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightGoldenBrown</seealso>
    let HairColorAtlasLightGoldenBrown =
        Prefixed_Name(appear, "HairColorAtlasLightGoldenBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightMediumGrayBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light to Medium Gray Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumGrayBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumGrayBrown</seealso>
    let HairColorAtlasLightMediumGrayBrown =
        Prefixed_Name(appear, "HairColorAtlasLightMediumGrayBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightRedBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Red Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightRedBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightRedBrown</seealso>
    let HairColorAtlasLightRedBrown =
        Prefixed_Name(appear, "HairColorAtlasLightRedBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasMediumDarkGrayBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Medium to Dark Gray Brown, Black (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkGrayBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasMediumDarkGrayBrown</seealso>
    let HairColorAtlasMediumDarkGrayBrown =
        Prefixed_Name(appear, "HairColorAtlasMediumDarkGrayBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasOpaqueBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Opaque Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasOpaqueBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasOpaqueBrown</seealso>
    let HairColorAtlasOpaqueBrown =
        Prefixed_Name(appear, "HairColorAtlasOpaqueBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasKneeLengthMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Knee Length Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementInches</seealso>
    let hasKneeLengthMeasurementInches =
        Prefixed_Name(appear, "hasKneeLengthMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasKneeLengthMeasurementMeters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Knee Length Measurement in Meters</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementMeters">http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementMeters</seealso>
    let hasKneeLengthMeasurementMeters =
        Prefixed_Name(appear, "hasKneeLengthMeasurementMeters") |> PrefixedName

    /// <summary>
    ///   <para>appear:Appearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Appearance">http://rdf.muninn-project.org/ontologies/appearances#Appearance</seealso>
    let Appearance = Prefixed_Name(appear, "Appearance") |> PrefixedName
    /// <summary>
    ///   <para>appear:PerceivedEthnicity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#PerceivedEthnicity">http://rdf.muninn-project.org/ontologies/appearances#PerceivedEthnicity</seealso>
    let PerceivedEthnicity = Prefixed_Name(appear, "PerceivedEthnicity") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeA2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Pakistani</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA2">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA2</seealso>
    let EthnicityUKCensusCodeA2 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeA2") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorWildeBlack</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorWilde</para>
    ///
    /// labels<para>Black (Wilde)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBlack">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWildeBlack</seealso>
    let EyeColorWildeBlack = Prefixed_Name(appear, "EyeColorWildeBlack") |> PrefixedName
    /// <summary>
    ///   <para>appear:FBI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FBI">http://rdf.muninn-project.org/ontologies/appearances#FBI</seealso>
    let FBI = Prefixed_Name(appear, "FBI") |> PrefixedName
    /// <summary>
    ///   <para>appear:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gender (Generic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Gender">http://rdf.muninn-project.org/ontologies/appearances#Gender</seealso>
    let Gender = Prefixed_Name(appear, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>appear:GenderSimple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple F/M coding of Gender types.</para>
    /// labels<para>SimplebGender</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#GenderSimple">http://rdf.muninn-project.org/ontologies/appearances#GenderSimple</seealso>
    let GenderSimple = Prefixed_Name(appear, "GenderSimple") |> PrefixedName
    /// <summary>
    ///   <para>appear:GenderSimple-M</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:GenderSimple</para>
    ///
    /// labels<para>Homme</para><para>Mann</para><para>Man</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#GenderSimple-M">http://rdf.muninn-project.org/ontologies/appearances#GenderSimple-M</seealso>
    let GenderSimple_M = Prefixed_Name(appear, "GenderSimple-M") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorAtlas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>HairColorAtlas</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlas">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlas</seealso>
    let HairColorAtlas = Prefixed_Name(appear, "HairColorAtlas") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasRedBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Red Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasRedBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasRedBrown</seealso>
    let HairColorAtlasRedBrown =
        Prefixed_Name(appear, "HairColorAtlasRedBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasGoldenBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Golden Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasGoldenBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasGoldenBrown</seealso>
    let HairColorAtlasGoldenBrown =
        Prefixed_Name(appear, "HairColorAtlasGoldenBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Red (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasRed</seealso>
    let HairColorAtlasRed = Prefixed_Name(appear, "HairColorAtlasRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Other Color(Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasOther">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasOther</seealso>
    let HairColorAtlasOther =
        Prefixed_Name(appear, "HairColorAtlasOther") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasBlondLightMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Blond to Medium (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondLightMedium">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasBlondLightMedium</seealso>
    let HairColorAtlasBlondLightMedium =
        Prefixed_Name(appear, "HairColorAtlasBlondLightMedium") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasDarkOpaqueBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Dark to Opaque Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkOpaqueBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkOpaqueBrown</seealso>
    let HairColorAtlasDarkOpaqueBrown =
        Prefixed_Name(appear, "HairColorAtlasDarkOpaqueBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasDarkRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Dark Red (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasDarkRed</seealso>
    let HairColorAtlasDarkRed =
        Prefixed_Name(appear, "HairColorAtlasDarkRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightBrown</seealso>
    let HairColorAtlasLightBrown =
        Prefixed_Name(appear, "HairColorAtlasLightBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightMediumGoldenBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light to Medium Golden Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumGoldenBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightMediumGoldenBrown</seealso>
    let HairColorAtlasLightMediumGoldenBrown =
        Prefixed_Name(appear, "HairColorAtlasLightMediumGoldenBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasLightRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Light Red (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasLightRed</seealso>
    let HairColorAtlasLightRed =
        Prefixed_Name(appear, "HairColorAtlasLightRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasEntertaimentAversion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has Entertaiment Aversion</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentAversion">http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentAversion</seealso>
    let hasEntertaimentAversion =
        Prefixed_Name(appear, "hasEntertaimentAversion") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeA1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Indian</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA1</seealso>
    let EthnicityUKCensusCodeA1 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeA1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorSimpleBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorSimple</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimpleBrown</seealso>
    let EyeColorSimpleBrown =
        Prefixed_Name(appear, "EyeColorSimpleBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorWilde</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Wilde Eye Color Reference.</para>
    /// labels<para>Wilde Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWilde">http://rdf.muninn-project.org/ontologies/appearances#EyeColorWilde</seealso>
    let EyeColorWilde = Prefixed_Name(appear, "EyeColorWilde") |> PrefixedName
    /// <summary>
    ///   <para>appear:GenderStrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Strict F/M coding of Gender types, with restriction.</para>
    /// labels<para>Gender (Strict)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#GenderStrict">http://rdf.muninn-project.org/ontologies/appearances#GenderStrict</seealso>
    let GenderStrict = Prefixed_Name(appear, "GenderStrict") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorAtlasGrayBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorAtlas</para>
    ///
    /// labels<para>Gray Brown (Human Hair Atlas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasGrayBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlasGrayBrown</seealso>
    let HairColorAtlasGrayBrown =
        Prefixed_Name(appear, "HairColorAtlasGrayBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeA9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Any other Asian ethnic background</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA9">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeA9</seealso>
    let EthnicityUKCensusCodeA9 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeA9") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeB9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Any other Black ethnic background</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB9">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeB9</seealso>
    let EthnicityUKCensusCodeB9 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeB9") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeM2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>White and Black African</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM2">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM2</seealso>
    let EthnicityUKCensusCodeM2 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeM2") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeM9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Any other Mixed ethnic background</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM9">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM9</seealso>
    let EthnicityUKCensusCodeM9 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeM9") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeW1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>British</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW1</seealso>
    let EthnicityUKCensusCodeW1 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeW1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeW9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Any other White ethnic background</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW9">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW9</seealso>
    let EthnicityUKCensusCodeW9 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeW9") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorFBIBLN</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Blonde / Strawberry</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLN">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLN</seealso>
    let HairColorFBIBLN = Prefixed_Name(appear, "HairColorFBIBLN") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIGRN</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///   <para>appear:HairColorDyed</para>
    ///
    /// labels<para>Green</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIGRN">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIGRN</seealso>
    let HairColorFBIGRN = Prefixed_Name(appear, "HairColorFBIGRN") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIGRY</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///   <para>Includes partially gray.</para>
    /// labels<para>Grey/Gray</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIGRY">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIGRY</seealso>
    let HairColorFBIGRY = Prefixed_Name(appear, "HairColorFBIGRY") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIPLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///   <para>appear:HairColorDyed</para>
    ///
    /// labels<para>Purple</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIPLE">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIPLE</seealso>
    let HairColorFBIPLE = Prefixed_Name(appear, "HairColorFBIPLE") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIRED</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Red/Auburn</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIRED">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIRED</seealso>
    let HairColorFBIRED = Prefixed_Name(appear, "HairColorFBIRED") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBISDY</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Sandy</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBISDY">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBISDY</seealso>
    let HairColorFBISDY = Prefixed_Name(appear, "HairColorFBISDY") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorFBIUNKNOWN</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Unknown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIUNKNOWN">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIUNKNOWN</seealso>
    let HairColorFBIUNKNOWN =
        Prefixed_Name(appear, "HairColorFBIUNKNOWN") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorFBIWHI</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>White</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIWHI">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIWHI</seealso>
    let HairColorFBIWHI = Prefixed_Name(appear, "HairColorFBIWHI") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVBald</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Bald</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBald">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBald</seealso>
    let HairColorNebraskaDMVBald =
        Prefixed_Name(appear, "HairColorNebraskaDMVBald") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVBlonde</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Blonde</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBlonde">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBlonde</seealso>
    let HairColorNebraskaDMVBlonde =
        Prefixed_Name(appear, "HairColorNebraskaDMVBlonde") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Unknown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVUnknown">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVUnknown</seealso>
    let HairColorNebraskaDMVUnknown =
        Prefixed_Name(appear, "HairColorNebraskaDMVUnknown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVWhite</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>White</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVWhite">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVWhite</seealso>
    let HairColorNebraskaDMVWhite =
        Prefixed_Name(appear, "HairColorNebraskaDMVWhite") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RCMP Hair Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMP">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMP</seealso>
    let HairColorRCMP = Prefixed_Name(appear, "HairColorRCMP") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorRCMPBlack</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBlack">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBlack</seealso>
    let HairColorRCMPBlack = Prefixed_Name(appear, "HairColorRCMPBlack") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorRCMPBlond</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Blond</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBlond">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBlond</seealso>
    let HairColorRCMPBlond = Prefixed_Name(appear, "HairColorRCMPBlond") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorRCMPBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBrown</seealso>
    let HairColorRCMPBrown = Prefixed_Name(appear, "HairColorRCMPBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMPLightStrawberryRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Strawberry Red</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightStrawberryRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightStrawberryRed</seealso>
    let HairColorRCMPLightStrawberryRed =
        Prefixed_Name(appear, "HairColorRCMPLightStrawberryRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMPWhite</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>White</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPWhite">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPWhite</seealso>
    let HairColorRCMPWhite = Prefixed_Name(appear, "HairColorRCMPWhite") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Predominantly heterosexual, only incidentally homosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale1">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale1</seealso>
    let KinseyScale1 = Prefixed_Name(appear, "KinseyScale1") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale4</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Predominantly homosexual, but more than incidentally heterosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale4">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale4</seealso>
    let KinseyScale4 = Prefixed_Name(appear, "KinseyScale4") |> PrefixedName

    /// <summary>
    ///   <para>appear:MaleBodyMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Male Body Measurement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#MaleBodyMeasurement">http://rdf.muninn-project.org/ontologies/appearances#MaleBodyMeasurement</seealso>
    let MaleBodyMeasurement =
        Prefixed_Name(appear, "MaleBodyMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>appear:SexISO5218-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexISO5218</para>
    ///
    /// labels<para>Homme</para><para>Mann</para><para>Man</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-1">http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-1</seealso>
    let SexISO5218_1 = Prefixed_Name(appear, "SexISO5218-1") |> PrefixedName
    /// <summary>
    ///   <para>appear:Nationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Nationality">http://rdf.muninn-project.org/ontologies/appearances#Nationality</seealso>
    let Nationality = Prefixed_Name(appear, "Nationality") |> PrefixedName
    /// <summary>
    ///   <para>appear:fox_michelle_j</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#fox_michelle_j">http://rdf.muninn-project.org/ontologies/appearances#fox_michelle_j</seealso>
    let fox_michelle_j = Prefixed_Name(appear, "fox_michelle_j") |> PrefixedName
    /// <summary>
    ///   <para>appear:ogle_robert_r</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#ogle_robert_r">http://rdf.muninn-project.org/ontologies/appearances#ogle_robert_r</seealso>
    let ogle_robert_r = Prefixed_Name(appear, "ogle_robert_r") |> PrefixedName
    /// <summary>
    ///   <para>appear:crc_press</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Organization</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#crc_press">http://rdf.muninn-project.org/ontologies/appearances#crc_press</seealso>
    let crc_press = Prefixed_Name(appear, "crc_press") |> PrefixedName
    /// <summary>
    ///   <para>appear:RCMP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RCMP">http://rdf.muninn-project.org/ontologies/appearances#RCMP</seealso>
    let RCMP = Prefixed_Name(appear, "RCMP") |> PrefixedName
    /// <summary>
    ///   <para>appear:Race</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Race">http://rdf.muninn-project.org/ontologies/appearances#Race</seealso>
    let Race = Prefixed_Name(appear, "Race") |> PrefixedName
    /// <summary>
    ///   <para>appear:Religion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Religion">http://rdf.muninn-project.org/ontologies/appearances#Religion</seealso>
    let Religion = Prefixed_Name(appear, "Religion") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColorBlue</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Blue (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorBlue">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorBlue</seealso>
    let RiddellColorBlue = Prefixed_Name(appear, "RiddellColorBlue") |> PrefixedName

    /// <summary>
    ///   <para>appear:RiddellColorChocolate</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Chocolate (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorChocolate">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorChocolate</seealso>
    let RiddellColorChocolate =
        Prefixed_Name(appear, "RiddellColorChocolate") |> PrefixedName

    /// <summary>
    ///   <para>appear:RiddellColorGreen</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Green (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorGreen">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorGreen</seealso>
    let RiddellColorGreen = Prefixed_Name(appear, "RiddellColorGreen") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColorNil</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>No color (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorNil">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorNil</seealso>
    let RiddellColorNil = Prefixed_Name(appear, "RiddellColorNil") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColorTan</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Tan (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorTan">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorTan</seealso>
    let RiddellColorTan = Prefixed_Name(appear, "RiddellColorTan") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColorYellow</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Yellow (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorYellow">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorYellow</seealso>
    let RiddellColorYellow = Prefixed_Name(appear, "RiddellColorYellow") |> PrefixedName

    /// <summary>
    ///   <para>appear:RiddellGeneralColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataProperty</para>
    ///
    /// labels<para>Riddell General Eye Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellGeneralColor">http://rdf.muninn-project.org/ontologies/appearances#RiddellGeneralColor</seealso>
    let RiddellGeneralColor =
        Prefixed_Name(appear, "RiddellGeneralColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:RiddellSpotsColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataProperty</para>
    ///
    /// labels<para>Riddell Spots Eye Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellSpotsColor">http://rdf.muninn-project.org/ontologies/appearances#RiddellSpotsColor</seealso>
    let RiddellSpotsColor = Prefixed_Name(appear, "RiddellSpotsColor") |> PrefixedName
    /// <summary>
    ///   <para>appear:SelfReported</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Self Reported</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SelfReported">http://rdf.muninn-project.org/ontologies/appearances#SelfReported</seealso>
    let SelfReported = Prefixed_Name(appear, "SelfReported") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexISO5218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Strict F/M coding of Gender types, with restriction.</para>
    /// labels<para>Sex (ISO/IEC 5218)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218">http://rdf.muninn-project.org/ontologies/appearances#SexISO5218</seealso>
    let SexISO5218 = Prefixed_Name(appear, "SexISO5218") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexISO5218-0</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexISO5218</para>
    ///
    /// labels<para>Gender Unknown</para><para>Sex Inconnu</para><para>Mann</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-0">http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-0</seealso>
    let SexISO5218_0 = Prefixed_Name(appear, "SexISO5218-0") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexISO5218-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexISO5218</para>
    ///
    /// labels<para>Not Available</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-9">http://rdf.muninn-project.org/ontologies/appearances#SexISO5218-9</seealso>
    let SexISO5218_9 = Prefixed_Name(appear, "SexISO5218-9") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexTyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexTyping">http://rdf.muninn-project.org/ontologies/appearances#SexTyping</seealso>
    let SexTyping = Prefixed_Name(appear, "SexTyping") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexTypingXX</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexTyping</para>
    ///
    /// labels<para>XX</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexTypingXX">http://rdf.muninn-project.org/ontologies/appearances#SexTypingXX</seealso>
    let SexTypingXX = Prefixed_Name(appear, "SexTypingXX") |> PrefixedName
    /// <summary>
    ///   <para>appear:SexTypingXY</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SexTyping</para>
    ///
    /// labels<para>XY</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SexTypingXY">http://rdf.muninn-project.org/ontologies/appearances#SexTypingXY</seealso>
    let SexTypingXY = Prefixed_Name(appear, "SexTypingXY") |> PrefixedName
    /// <summary>
    ///   <para>appear:SkinColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Skin Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColor">http://rdf.muninn-project.org/ontologies/appearances#SkinColor</seealso>
    let SkinColor = Prefixed_Name(appear, "SkinColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fitzpatrick Scale Type</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickType">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickType</seealso>
    let SkinColorFitzpatrickType =
        Prefixed_Name(appear, "SkinColorFitzpatrickType") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColor">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColor</seealso>
    let FitzpatrickSkinColor =
        Prefixed_Name(appear, "FitzpatrickSkinColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeI</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Very Fair</para><para>Freckles</para><para>Albino</para><para>White</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeI">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeI</seealso>
    let SkinColorFitzpatrickTypeI =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeI") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan5</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 5</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan5">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan5</seealso>
    let SkinColorVonLuschan5 =
        Prefixed_Name(appear, "SkinColorVonLuschan5") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan4</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 4</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan4">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan4</seealso>
    let SkinColorVonLuschan4 =
        Prefixed_Name(appear, "SkinColorVonLuschan4") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 1</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan1">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan1</seealso>
    let SkinColorVonLuschan1 =
        Prefixed_Name(appear, "SkinColorVonLuschan1") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeII</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Light-skinned European</para><para>White</para><para>Fair</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeII">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeII</seealso>
    let SkinColorFitzpatrickTypeII =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeII") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan8</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 8</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan8">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan8</seealso>
    let SkinColorVonLuschan8 =
        Prefixed_Name(appear, "SkinColorVonLuschan8") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan10</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 10</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan10">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan10</seealso>
    let SkinColorVonLuschan10 =
        Prefixed_Name(appear, "SkinColorVonLuschan10") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan6</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 6</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan6">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan6</seealso>
    let SkinColorVonLuschan6 =
        Prefixed_Name(appear, "SkinColorVonLuschan6") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 9</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan9">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan9</seealso>
    let SkinColorVonLuschan9 =
        Prefixed_Name(appear, "SkinColorVonLuschan9") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan7</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 7</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan7">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan7</seealso>
    let SkinColorVonLuschan7 =
        Prefixed_Name(appear, "SkinColorVonLuschan7") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeIII</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Dark-skinned European</para><para>Light intermediate</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeIII">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeIII</seealso>
    let SkinColorFitzpatrickTypeIII =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeIII") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeM1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>White and Black Caribbean</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM1</seealso>
    let EthnicityUKCensusCodeM1 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeM1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeNS</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Not Stated</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeNS">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeNS</seealso>
    let EthnicityUKCensusCodeNS =
        Prefixed_Name(appear, "EthnicityUKCensusCodeNS") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeW2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Irish</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW2">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeW2</seealso>
    let EthnicityUKCensusCodeW2 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeW2") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Red</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVRed</seealso>
    let HairColorNebraskaDMVRed =
        Prefixed_Name(appear, "HairColorNebraskaDMVRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVSandy</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Sandy</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVSandy">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVSandy</seealso>
    let HairColorNebraskaDMVSandy =
        Prefixed_Name(appear, "HairColorNebraskaDMVSandy") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMPBald</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Bald</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBald">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPBald</seealso>
    let HairColorRCMPBald = Prefixed_Name(appear, "HairColorRCMPBald") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeM3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>White and Asian</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM3">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeM3</seealso>
    let EthnicityUKCensusCodeM3 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeM3") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorDyed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dyed Hair Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorDyed">http://rdf.muninn-project.org/ontologies/appearances#HairColorDyed</seealso>
    let HairColorDyed = Prefixed_Name(appear, "HairColorDyed") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorNatural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Natural Hair Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNatural">http://rdf.muninn-project.org/ontologies/appearances#HairColorNatural</seealso>
    let HairColorNatural = Prefixed_Name(appear, "HairColorNatural") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIBLD</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Bald</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLD">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLD</seealso>
    let HairColorFBIBLD = Prefixed_Name(appear, "HairColorFBIBLD") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasOverArmMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Over Arm Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementInches</seealso>
    let hasOverArmMeasurementInches =
        Prefixed_Name(appear, "hasOverArmMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeO1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Chinese</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeO1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeO1</seealso>
    let EthnicityUKCensusCodeO1 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeO1") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorFBI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FBI Hair Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBI">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBI</seealso>
    let HairColorFBI = Prefixed_Name(appear, "HairColorFBI") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIBLK</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLK">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLK</seealso>
    let HairColorFBIBLK = Prefixed_Name(appear, "HairColorFBIBLK") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIBLU</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///   <para>appear:HairColorDyed</para>
    ///
    /// labels<para>Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLU">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBLU</seealso>
    let HairColorFBIBLU = Prefixed_Name(appear, "HairColorFBIBLU") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIBRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBRO">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIBRO</seealso>
    let HairColorFBIBRO = Prefixed_Name(appear, "HairColorFBIBRO") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorFBIONG</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorFBI</para>
    ///   <para>appear:HairColorDyed</para>
    ///
    /// labels<para>Orange</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIONG">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIONG</seealso>
    let HairColorFBIONG = Prefixed_Name(appear, "HairColorFBIONG") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKCensusCodeO9</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKCensusCode</para>
    ///
    /// labels<para>Any other ethnic group</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeO9">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCodeO9</seealso>
    let EthnicityUKCensusCodeO9 =
        Prefixed_Name(appear, "EthnicityUKCensusCodeO9") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC0</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>Origin unknown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC0">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC0</seealso>
    let EthnicityUKICCodeIC0 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC0") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorFBIPNK</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorDyed</para>
    ///   <para>appear:HairColorFBI</para>
    ///
    /// labels<para>Pink</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIPNK">http://rdf.muninn-project.org/ontologies/appearances#HairColorFBIPNK</seealso>
    let HairColorFBIPNK = Prefixed_Name(appear, "HairColorFBIPNK") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NebraskaDMVHairColor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMV">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMV</seealso>
    let HairColorNebraskaDMV =
        Prefixed_Name(appear, "HairColorNebraskaDMV") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVBrown</seealso>
    let HairColorNebraskaDMVBrown =
        Prefixed_Name(appear, "HairColorNebraskaDMVBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorNebraskaDMVGray</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorNebraskaDMV</para>
    ///
    /// labels<para>Gray</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVGray">http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMVGray</seealso>
    let HairColorNebraskaDMVGray =
        Prefixed_Name(appear, "HairColorNebraskaDMVGray") |> PrefixedName

    /// <summary>
    ///   <para>appear:RCMPStandards</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>RCMP Standards</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RCMPStandards">http://rdf.muninn-project.org/ontologies/appearances#RCMPStandards</seealso>
    let RCMPStandards = Prefixed_Name(appear, "RCMPStandards") |> PrefixedName
    /// <summary>
    ///   <para>appear:HairColorRCMPGrey</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Grey / Gray</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPGrey">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPGrey</seealso>
    let HairColorRCMPGrey = Prefixed_Name(appear, "HairColorRCMPGrey") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMPLightRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Red</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightRed">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightRed</seealso>
    let HairColorRCMPLightRed =
        Prefixed_Name(appear, "HairColorRCMPLightRed") |> PrefixedName

    /// <summary>
    ///   <para>appear:KinseyScale0</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Exclusively heterosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale0">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale0</seealso>
    let KinseyScale0 = Prefixed_Name(appear, "KinseyScale0") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Equally heterosexual and homosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale3">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale3</seealso>
    let KinseyScale3 = Prefixed_Name(appear, "KinseyScale3") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale6</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Exclusively homosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale6">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale6</seealso>
    let KinseyScale6 = Prefixed_Name(appear, "KinseyScale6") |> PrefixedName
    /// <summary>
    ///   <para>appear:macroEthnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#macroEthnicity">http://rdf.muninn-project.org/ontologies/appearances#macroEthnicity</seealso>
    let macroEthnicity = Prefixed_Name(appear, "macroEthnicity") |> PrefixedName
    /// <summary>
    ///   <para>appear:NebraskaDMV</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#NebraskaDMV">http://rdf.muninn-project.org/ontologies/appearances#NebraskaDMV</seealso>
    let NebraskaDMV = Prefixed_Name(appear, "NebraskaDMV") |> PrefixedName
    /// <summary>
    ///   <para>appear:EthnicityUKICCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple F/M coding of Gender types.</para>
    /// labels<para>UK IC-Codes</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCode">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCode</seealso>
    let EthnicityUKICCode = Prefixed_Name(appear, "EthnicityUKICCode") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>Mediterranean European/Hispanic</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC2">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC2</seealso>
    let EthnicityUKICCodeIC2 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC2") |> PrefixedName

    /// <summary>
    ///   <para>appear:HairColorRCMPLightBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:HairColorRCMP</para>
    ///
    /// labels<para>Light Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightBrown">http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMPLightBrown</seealso>
    let HairColorRCMPLightBrown =
        Prefixed_Name(appear, "HairColorRCMPLightBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:KinseyScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kinsey Scale</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale</seealso>
    let KinseyScale = Prefixed_Name(appear, "KinseyScale") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Predominantly heterosexual, but more than incidentally homosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale2">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale2</seealso>
    let KinseyScale2 = Prefixed_Name(appear, "KinseyScale2") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScale5</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Predominantly homosexual, only incidentally heterosexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale5">http://rdf.muninn-project.org/ontologies/appearances#KinseyScale5</seealso>
    let KinseyScale5 = Prefixed_Name(appear, "KinseyScale5") |> PrefixedName
    /// <summary>
    ///   <para>appear:KinseyScaleX</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:KinseyScale</para>
    ///
    /// labels<para>Non-sexual</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScaleX">http://rdf.muninn-project.org/ontologies/appearances#KinseyScaleX</seealso>
    let KinseyScaleX = Prefixed_Name(appear, "KinseyScaleX") |> PrefixedName
    /// <summary>
    ///   <para>appear:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Observation">http://rdf.muninn-project.org/ontologies/appearances#Observation</seealso>
    let Observation = Prefixed_Name(appear, "Observation") |> PrefixedName

    /// <summary>
    ///   <para>appear:hasThighMeasurementInches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Thigh Measurement in Inches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementInches">http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementInches</seealso>
    let hasThighMeasurementInches =
        Prefixed_Name(appear, "hasThighMeasurementInches") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC1</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>White person, northern European type</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC1">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC1</seealso>
    let EthnicityUKICCodeIC1 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC6</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>Arab person</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC6">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC6</seealso>
    let EthnicityUKICCodeIC6 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC6") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorFBI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>FBI Eye Color Reference - Essentially the same as used by the RCMP.</para>
    /// labels<para>FBI Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBI">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBI</seealso>
    let EyeColorFBI = Prefixed_Name(appear, "EyeColorFBI") |> PrefixedName
    /// <summary>
    ///   <para>appear:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Sex">http://rdf.muninn-project.org/ontologies/appearances#Sex</seealso>
    let Sex = Prefixed_Name(appear, "Sex") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>African/Afro-Caribbean person</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC3">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC3</seealso>
    let EthnicityUKICCodeIC3 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC3") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC5</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>Chinese, Japanese, or South-East Asian person</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC5">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC5</seealso>
    let EthnicityUKICCodeIC5 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC5") |> PrefixedName

    /// <summary>
    ///   <para>appear:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Natural Person</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#Person">http://rdf.muninn-project.org/ontologies/appearances#Person</seealso>
    let Person = Prefixed_Name(appear, "Person") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>owl:Class</para>
    ///   <para>Riddell Color Reference.</para>
    /// labels<para>Riddell Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColor">http://rdf.muninn-project.org/ontologies/appearances#RiddellColor</seealso>
    let RiddellColor = Prefixed_Name(appear, "RiddellColor") |> PrefixedName
    /// <summary>
    ///   <para>appear:RiddellColorGrey</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:RiddellColor</para>
    ///
    /// labels<para>Grey (Riddell)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColorGrey">http://rdf.muninn-project.org/ontologies/appearances#RiddellColorGrey</seealso>
    let RiddellColorGrey = Prefixed_Name(appear, "RiddellColorGrey") |> PrefixedName

    /// <summary>
    ///   <para>appear:RiddellDiffuseColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DataProperty</para>
    ///
    /// labels<para>Riddell Diffuse Eye Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#RiddellDiffuseColor">http://rdf.muninn-project.org/ontologies/appearances#RiddellDiffuseColor</seealso>
    let RiddellDiffuseColor =
        Prefixed_Name(appear, "RiddellDiffuseColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:EthnicityUKICCodeIC4</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EthnicityUKICCode</para>
    ///
    /// labels<para>Indian, Pakistani, Nepalese, Maldivian, Sri Lankan, Bangladeshi, or any other (South) Asian person</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC4">http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCodeIC4</seealso>
    let EthnicityUKICCodeIC4 =
        Prefixed_Name(appear, "EthnicityUKICCodeIC4") |> PrefixedName

    /// <summary>
    ///   <para>appear:j_m_seddon</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrc:Person</para>
    ///   <para>&lt;http://xmlns.com/foaf/spec/Person&gt;</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#j_m_seddon">http://rdf.muninn-project.org/ontologies/appearances#j_m_seddon</seealso>
    let j_m_seddon = Prefixed_Name(appear, "j_m_seddon") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eye Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColor">http://rdf.muninn-project.org/ontologies/appearances#EyeColor</seealso>
    let EyeColor = Prefixed_Name(appear, "EyeColor") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIBLK</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBLK">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBLK</seealso>
    let EyeColorFBIBLK = Prefixed_Name(appear, "EyeColorFBIBLK") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIGRN</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Green</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIGRN">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIGRN</seealso>
    let EyeColorFBIGRN = Prefixed_Name(appear, "EyeColorFBIGRN") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIHAZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Hazel</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIHAZ">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIHAZ</seealso>
    let EyeColorFBIHAZ = Prefixed_Name(appear, "EyeColorFBIHAZ") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 3</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan3">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan3</seealso>
    let SkinColorVonLuschan3 =
        Prefixed_Name(appear, "SkinColorVonLuschan3") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan12</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 12</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan12">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan12</seealso>
    let SkinColorVonLuschan12 =
        Prefixed_Name(appear, "SkinColorVonLuschan12") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan14</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///   <para>This skin color is the same as number 13. </para>
    /// labels<para>Von Luschan Skin Color 14</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan14">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan14</seealso>
    let SkinColorVonLuschan14 =
        Prefixed_Name(appear, "SkinColorVonLuschan14") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan15</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 15</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan15">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan15</seealso>
    let SkinColorVonLuschan15 =
        Prefixed_Name(appear, "SkinColorVonLuschan15") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeIV</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Beige with a brown tint</para><para>Mediterranean Caucasian</para><para>Dark intermediate</para><para>Mediterranean</para><para>Olive Skin</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeIV">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeIV</seealso>
    let SkinColorFitzpatrickTypeIV =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeIV") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan17</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 17</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan17">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan17</seealso>
    let SkinColorVonLuschan17 =
        Prefixed_Name(appear, "SkinColorVonLuschan17") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan16</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 16</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan16">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan16</seealso>
    let SkinColorVonLuschan16 =
        Prefixed_Name(appear, "SkinColorVonLuschan16") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan21</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 21</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan21">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan21</seealso>
    let SkinColorVonLuschan21 =
        Prefixed_Name(appear, "SkinColorVonLuschan21") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan18</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 18</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan18">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan18</seealso>
    let SkinColorVonLuschan18 =
        Prefixed_Name(appear, "SkinColorVonLuschan18") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan23</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 23</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan23">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan23</seealso>
    let SkinColorVonLuschan23 =
        Prefixed_Name(appear, "SkinColorVonLuschan23") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan26</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 26</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan26">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan26</seealso>
    let SkinColorVonLuschan26 =
        Prefixed_Name(appear, "SkinColorVonLuschan26") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan27</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 27</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan27">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan27</seealso>
    let SkinColorVonLuschan27 =
        Prefixed_Name(appear, "SkinColorVonLuschan27") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeVI</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Very Dark</para><para>Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeVI">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeVI</seealso>
    let SkinColorFitzpatrickTypeVI =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeVI") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan31</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 31</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan31">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan31</seealso>
    let SkinColorVonLuschan31 =
        Prefixed_Name(appear, "SkinColorVonLuschan31") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan36</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 36</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan36">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan36</seealso>
    let SkinColorVonLuschan36 =
        Prefixed_Name(appear, "SkinColorVonLuschan36") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan30</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 30</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan30">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan30</seealso>
    let SkinColorVonLuschan30 =
        Prefixed_Name(appear, "SkinColorVonLuschan30") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan32</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 32</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan32">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan32</seealso>
    let SkinColorVonLuschan32 =
        Prefixed_Name(appear, "SkinColorVonLuschan32") |> PrefixedName

    /// <summary>
    ///   <para>appear:VonLuschan1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#VonLuschan1">http://rdf.muninn-project.org/ontologies/appearances#VonLuschan1</seealso>
    let VonLuschan1 = Prefixed_Name(appear, "VonLuschan1") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimpleBlack</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorSimple</para>
    ///
    /// labels<para>Simple Skin Color Black</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleBlack">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleBlack</seealso>
    let SkinColorSimpleBlack =
        Prefixed_Name(appear, "SkinColorSimpleBlack") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColorTypeV</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeV">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeV</seealso>
    let FitzpatrickSkinColorTypeV =
        Prefixed_Name(appear, "FitzpatrickSkinColorTypeV") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimpleOlive</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorSimple</para>
    ///
    /// labels<para>Simple Skin Color Olive</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleOlive">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleOlive</seealso>
    let SkinColorSimpleOlive =
        Prefixed_Name(appear, "SkinColorSimpleOlive") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColorTypeIII</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeIII">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeIII</seealso>
    let FitzpatrickSkinColorTypeIII =
        Prefixed_Name(appear, "FitzpatrickSkinColorTypeIII") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColorTypeII</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeII">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeII</seealso>
    let FitzpatrickSkinColorTypeII =
        Prefixed_Name(appear, "FitzpatrickSkinColorTypeII") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Skin Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan</seealso>
    let SkinColorVonLuschan =
        Prefixed_Name(appear, "SkinColorVonLuschan") |> PrefixedName

    /// <summary>
    ///   <para>appear:FBIStandards</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>FBI Standards</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FBIStandards">http://rdf.muninn-project.org/ontologies/appearances#FBIStandards</seealso>
    let FBIStandards = Prefixed_Name(appear, "FBIStandards") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIBLU</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBLU">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBLU</seealso>
    let EyeColorFBIBLU = Prefixed_Name(appear, "EyeColorFBIBLU") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIBRO</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBRO">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIBRO</seealso>
    let EyeColorFBIBRO = Prefixed_Name(appear, "EyeColorFBIBRO") |> PrefixedName
    /// <summary>
    ///   <para>appear:EyeColorFBIGRY</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Gray</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIGRY">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIGRY</seealso>
    let EyeColorFBIGRY = Prefixed_Name(appear, "EyeColorFBIGRY") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Grieve Morant Eye Color Reference.</para>
    /// labels<para> Grieve Morant Eye Color Reference</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorant">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorant</seealso>
    let EyeColorGrieveMorant =
        Prefixed_Name(appear, "EyeColorGrieveMorant") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantMoreBlueGreyThanBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>More Blue or Grey than Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantMoreBlueGreyThanBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantMoreBlueGreyThanBrown</seealso>
    let EyeColorGrieveMorantMoreBlueGreyThanBrown =
        Prefixed_Name(appear, "EyeColorGrieveMorantMoreBlueGreyThanBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan2</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 2</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan2">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan2</seealso>
    let SkinColorVonLuschan2 =
        Prefixed_Name(appear, "SkinColorVonLuschan2") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorFBIMAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorFBI</para>
    ///
    /// labels<para>Maroon</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIMAR">http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBIMAR</seealso>
    let EyeColorFBIMAR = Prefixed_Name(appear, "EyeColorFBIMAR") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantMoreBrownThanBlueGrey</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>More Brown Than Blue or Grey</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantMoreBrownThanBlueGrey">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantMoreBrownThanBlueGrey</seealso>
    let EyeColorGrieveMorantMoreBrownThanBlueGrey =
        Prefixed_Name(appear, "EyeColorGrieveMorantMoreBrownThanBlueGrey") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantNoBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>No Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantNoBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantNoBrown</seealso>
    let EyeColorGrieveMorantNoBrown =
        Prefixed_Name(appear, "EyeColorGrieveMorantNoBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantB</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Light Grey</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantB">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantB</seealso>
    let EyeColorGrieveMorantB =
        Prefixed_Name(appear, "EyeColorGrieveMorantB") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz5</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Blue Gray Iris (5)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz5">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz5</seealso>
    let EyeColorMartinSchultz5 =
        Prefixed_Name(appear, "EyeColorMartinSchultz5") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan11</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 11</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan11">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan11</seealso>
    let SkinColorVonLuschan11 =
        Prefixed_Name(appear, "SkinColorVonLuschan11") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan13</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///   <para>This skin color is the same as number 14. </para>
    /// labels<para>Von Luschan Skin Color 13</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan13">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan13</seealso>
    let SkinColorVonLuschan13 =
        Prefixed_Name(appear, "SkinColorVonLuschan13") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan19</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 19</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan19">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan19</seealso>
    let SkinColorVonLuschan19 =
        Prefixed_Name(appear, "SkinColorVonLuschan19") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan20</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 20</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan20">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan20</seealso>
    let SkinColorVonLuschan20 =
        Prefixed_Name(appear, "SkinColorVonLuschan20") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorFitzpatrickTypeV</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorFitzpatrickType</para>
    ///
    /// labels<para>Dark brown</para><para>Brown</para><para>Dark</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeV">http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickTypeV</seealso>
    let SkinColorFitzpatrickTypeV =
        Prefixed_Name(appear, "SkinColorFitzpatrickTypeV") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan28</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 28</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan28">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan28</seealso>
    let SkinColorVonLuschan28 =
        Prefixed_Name(appear, "SkinColorVonLuschan28") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan25</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 25</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan25">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan25</seealso>
    let SkinColorVonLuschan25 =
        Prefixed_Name(appear, "SkinColorVonLuschan25") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan22</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 22</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan22">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan22</seealso>
    let SkinColorVonLuschan22 =
        Prefixed_Name(appear, "SkinColorVonLuschan22") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan24</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 24</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan24">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan24</seealso>
    let SkinColorVonLuschan24 =
        Prefixed_Name(appear, "SkinColorVonLuschan24") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan35</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 35</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan35">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan35</seealso>
    let SkinColorVonLuschan35 =
        Prefixed_Name(appear, "SkinColorVonLuschan35") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan34</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 34</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan34">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan34</seealso>
    let SkinColorVonLuschan34 =
        Prefixed_Name(appear, "SkinColorVonLuschan34") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan29</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 29</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan29">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan29</seealso>
    let SkinColorVonLuschan29 =
        Prefixed_Name(appear, "SkinColorVonLuschan29") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorVonLuschan33</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorVonLuschan</para>
    ///
    /// labels<para>Von Luschan Skin Color 33</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan33">http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan33</seealso>
    let SkinColorVonLuschan33 =
        Prefixed_Name(appear, "SkinColorVonLuschan33") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Simple Skin Color</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimple">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimple</seealso>
    let SkinColorSimple = Prefixed_Name(appear, "SkinColorSimple") |> PrefixedName
    /// <summary>
    ///   <para>appear:htmlColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>htmlColor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#htmlColor">http://rdf.muninn-project.org/ontologies/appearances#htmlColor</seealso>
    let htmlColor = Prefixed_Name(appear, "htmlColor") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColorTypeVI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeVI">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeVI</seealso>
    let FitzpatrickSkinColorTypeVI =
        Prefixed_Name(appear, "FitzpatrickSkinColorTypeVI") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimpleBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorSimple</para>
    ///
    /// labels<para>Simple Skin Color Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleBrown">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleBrown</seealso>
    let SkinColorSimpleBrown =
        Prefixed_Name(appear, "SkinColorSimpleBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantPureBrown</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Pure Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantPureBrown">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantPureBrown</seealso>
    let EyeColorGrieveMorantPureBrown =
        Prefixed_Name(appear, "EyeColorGrieveMorantPureBrown") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantA</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Light Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantA">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantA</seealso>
    let EyeColorGrieveMorantA =
        Prefixed_Name(appear, "EyeColorGrieveMorantA") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantC</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Dark Blue</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantC">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantC</seealso>
    let EyeColorGrieveMorantC =
        Prefixed_Name(appear, "EyeColorGrieveMorantC") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantD</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Dark Grey</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantD">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantD</seealso>
    let EyeColorGrieveMorantD =
        Prefixed_Name(appear, "EyeColorGrieveMorantD") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz4</seealso>
    let EyeColorMartinSchultz4 =
        Prefixed_Name(appear, "EyeColorMartinSchultz4") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantG</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Still more Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantG">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantG</seealso>
    let EyeColorGrieveMorantG =
        Prefixed_Name(appear, "EyeColorGrieveMorantG") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantH</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Most Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantH">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantH</seealso>
    let EyeColorGrieveMorantH =
        Prefixed_Name(appear, "EyeColorGrieveMorantH") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantI</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Least Brown</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantI">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantI</seealso>
    let EyeColorGrieveMorantI =
        Prefixed_Name(appear, "EyeColorGrieveMorantI") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>More Brown (J)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantJ">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantJ</seealso>
    let EyeColorGrieveMorantJ =
        Prefixed_Name(appear, "EyeColorGrieveMorantJ") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantL</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Light</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantL">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantL</seealso>
    let EyeColorGrieveMorantL =
        Prefixed_Name(appear, "EyeColorGrieveMorantL") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantM</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantM">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantM</seealso>
    let EyeColorGrieveMorantM =
        Prefixed_Name(appear, "EyeColorGrieveMorantM") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorGrieveMorantN</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorGrieveMorant</para>
    ///
    /// labels<para>Dark</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantN">http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorantN</seealso>
    let EyeColorGrieveMorantN =
        Prefixed_Name(appear, "EyeColorGrieveMorantN") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz14</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Dark Brown and Brown Black (14)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz14">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz14</seealso>
    let EyeColorMartinSchultz14 =
        Prefixed_Name(appear, "EyeColorMartinSchultz14") |> PrefixedName

    /// <summary>
    ///   <para>appear:FitzpatrickSkinColorTypeIV</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeIV">http://rdf.muninn-project.org/ontologies/appearances#FitzpatrickSkinColorTypeIV</seealso>
    let FitzpatrickSkinColorTypeIV =
        Prefixed_Name(appear, "FitzpatrickSkinColorTypeIV") |> PrefixedName

    /// <summary>
    ///   <para>appear:SkinColorSimpleWhite</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:SkinColorSimple</para>
    ///
    /// labels<para>Simple Skin Color White</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleWhite">http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimpleWhite</seealso>
    let SkinColorSimpleWhite =
        Prefixed_Name(appear, "SkinColorSimpleWhite") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz1</seealso>
    let EyeColorMartinSchultz1 =
        Prefixed_Name(appear, "EyeColorMartinSchultz1") |> PrefixedName

    /// <summary>
    ///   <para>appear:EyeColorMartinSchultz3</para>
    /// </summary>
    /// <remarks>
    ///   <para>appear:EyeColorMartinSchultz</para>
    ///
    /// labels<para>Blue Gray Iris (3)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz3">http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz3</seealso>
    let EyeColorMartinSchultz3 =
        Prefixed_Name(appear, "EyeColorMartinSchultz3") |> PrefixedName

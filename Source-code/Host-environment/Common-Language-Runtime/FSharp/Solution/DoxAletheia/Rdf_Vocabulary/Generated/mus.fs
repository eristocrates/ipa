namespace http.data.doremus.org.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mus =
    let _namespace_iri = Namespace_Iri mus |> NamespaceIRI

    /// <summary>
    ///   <para>mus:CLU198_should_have_container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU198 should have container</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU198_should_have_container">http://data.doremus.org/ontology#CLU198_should_have_container</seealso>
    let CLU198_should_have_container =
        Prefixed_Name(mus, "CLU198_should_have_container") |> PrefixedName

    /// <summary>
    ///   <para>mus:M171_Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M171 Container</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M171_Container">http://data.doremus.org/ontology#M171_Container</seealso>
    let M171_Container = Prefixed_Name(mus, "M171_Container") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU207_should_have_carrier_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU207 should have carrier type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU207_should_have_carrier_type">http://data.doremus.org/ontology#CLU207_should_have_carrier_type</seealso>
    let CLU207_should_have_carrier_type =
        Prefixed_Name(mus, "CLU207_should_have_carrier_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU210_should_have_pagination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU210 should have pagination</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU210_should_have_pagination">http://data.doremus.org/ontology#CLU210_should_have_pagination</seealso>
    let CLU210_should_have_pagination =
        Prefixed_Name(mus, "CLU210_should_have_pagination") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU217_should_have_playing_speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU217 should have playing speed</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU217_should_have_playing_speed">http://data.doremus.org/ontology#CLU217_should_have_playing_speed</seealso>
    let CLU217_should_have_playing_speed =
        Prefixed_Name(mus, "CLU217_should_have_playing_speed") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU223i_should_be_number_of_tape_tracks_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U223i should be number of tape tracks of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU223i_should_be_number_of_tape_tracks_of">http://data.doremus.org/ontology#CLU223i_should_be_number_of_tape_tracks_of</seealso>
    let CLU223i_should_be_number_of_tape_tracks_of =
        Prefixed_Name(mus, "CLU223i_should_be_number_of_tape_tracks_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U223_has_number_of_tape_tracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U223 has number of tape tracks</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U223_has_number_of_tape_tracks">http://data.doremus.org/ontology#U223_has_number_of_tape_tracks</seealso>
    let U223_has_number_of_tape_tracks =
        Prefixed_Name(mus, "U223_has_number_of_tape_tracks") |> PrefixedName

    /// <summary>
    ///   <para>mus:M12_Opus_Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M12 Numéro d'opus</para><para>M12 Opus Number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M12_Opus_Number">http://data.doremus.org/ontology#M12_Opus_Number</seealso>
    let M12_Opus_Number = Prefixed_Name(mus, "M12_Opus_Number") |> PrefixedName
    /// <summary>
    ///   <para>mus:M13_Opus_Subnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M13 Sous-numéro d'opus</para><para>M13 Opus Subnumber</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M13_Opus_Subnumber">http://data.doremus.org/ontology#M13_Opus_Subnumber</seealso>
    let M13_Opus_Subnumber = Prefixed_Name(mus, "M13_Opus_Subnumber") |> PrefixedName
    /// <summary>
    ///   <para>mus:M154_Label_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M154 Nom du libellé</para><para>M154 Label name</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M154_Label_Name">http://data.doremus.org/ontology#M154_Label_Name</seealso>
    let M154_Label_Name = Prefixed_Name(mus, "M154_Label_Name") |> PrefixedName

    /// <summary>
    ///   <para>mus:M158_Title_and_Statement_of_Responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M158 Title and statement of responsability</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M158_Title_and_Statement_of_Responsibility">http://data.doremus.org/ontology#M158_Title_and_Statement_of_Responsibility</seealso>
    let M158_Title_and_Statement_of_Responsibility =
        Prefixed_Name(mus, "M158_Title_and_Statement_of_Responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:M159_Edition_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M159 Edition statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M159_Edition_Statement">http://data.doremus.org/ontology#M159_Edition_Statement</seealso>
    let M159_Edition_Statement =
        Prefixed_Name(mus, "M159_Edition_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M162_Series_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M162 Series statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M162_Series_Statement">http://data.doremus.org/ontology#M162_Series_Statement</seealso>
    let M162_Series_Statement =
        Prefixed_Name(mus, "M162_Series_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M163_Music_Format_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M163 Music format statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M163_Music_Format_Statement">http://data.doremus.org/ontology#M163_Music_Format_Statement</seealso>
    let M163_Music_Format_Statement =
        Prefixed_Name(mus, "M163_Music_Format_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M172_Colour_Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M172 Couleur du contenu</para><para>M172 Colour content</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M172_Colour_Content">http://data.doremus.org/ontology#M172_Colour_Content</seealso>
    let M172_Colour_Content = Prefixed_Name(mus, "M172_Colour_Content") |> PrefixedName

    /// <summary>
    ///   <para>mus:M17_Controlled_Access_Point_Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Examples:
    /// …explosante-fixe… (F22) P1 is identified by F50 Controlled Access Point R8 consists of M17 Controlled Access Point Creator { Boulez, Pierre (1925, …) } and R8 consists of M18 Controlled Access Point Denomination R8 consists of F12 Nomen { …explosante-fixe… }</para>
    ///   <para>Scope note:
    /// Sous-classe de F50 Controlled Access Point, cette classe en reprend les caractéristiques, limitées au « créateur » de l’œuvre.</para>
    /// labels<para>M17 Point d'accès contrôlé créateur</para><para>M17 Controlled Access Point Creator</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M17_Controlled_Access_Point_Creator">http://data.doremus.org/ontology#M17_Controlled_Access_Point_Creator</seealso>
    let M17_Controlled_Access_Point_Creator =
        Prefixed_Name(mus, "M17_Controlled_Access_Point_Creator") |> PrefixedName

    /// <summary>
    ///   <para>mus:U189_has_main_series_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U189 has main series statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U189_has_main_series_statement">http://data.doremus.org/ontology#U189_has_main_series_statement</seealso>
    let U189_has_main_series_statement =
        Prefixed_Name(mus, "U189_has_main_series_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M18_Controlled_Access_Point_Denomination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Examples:
    /// …explosante-fixe… (F22) P1 is identified by F50 Controlled Access Point R8 consists of M17 Controlled Access Point Creator { Boulez, Pierre (1925, …) } and R8 consists of M18 Controlled Access Point Denomination R8 consists of F12 Nomen { …explosante-fixe… }</para>
    ///   <para>Scope note:
    /// Sous-classe de F50 Controlled Access Point, cette classe en reprend les caractéristiques, limitées à la « dénomination » de l’œuvre. La dénomination peut être un titre significatif (« Le Sacre du Printemps »), ou un titre composé (« Sonates. Piano. Opus 27 no 2. Do dièse mineur.”)</para>
    /// labels<para>M18 Controlled Access Point Denomination</para><para>M18 Point d'accès contrôlé dénomination</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M18_Controlled_Access_Point_Denomination">http://data.doremus.org/ontology#M18_Controlled_Access_Point_Denomination</seealso>
    let M18_Controlled_Access_Point_Denomination =
        Prefixed_Name(mus, "M18_Controlled_Access_Point_Denomination") |> PrefixedName

    /// <summary>
    ///   <para>mus:M19_Categorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M19 Style</para><para>M19 Style</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M19_Categorization">http://data.doremus.org/ontology#M19_Categorization</seealso>
    let M19_Categorization = Prefixed_Name(mus, "M19_Categorization") |> PrefixedName
    /// <summary>
    ///   <para>mus:M23_Casting_Detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Examples:
    /// La Sonate pour piano opus 27, no 2 de Beethoven (F22) U13 has intended casting M6 Intended Casting U23 has casting detail M23 Casting Detail U1 has intended medium of performance M35 Cast Medium of Performance U39 has medium of performance M14 Medium of Performance { piano } and P90 has value { 1 }.</para>
    ///   <para>Scope note:
    /// Cette classe décrit un détail de la distribution prévue par le compositeur, par exemple une sonate pour violon et piano est décrite par deux « composantes » M23 qui sont le violon et le piano. Elle est donc obligatoirement associée à la classe M6 Intended Casting dont elle détaille les composantes. Ces composantes comprennent notamment le ou les medium of performance prévus par le compositeur, l’éventuel rôle soliste du medium of performance, le personnage interprété (par exemple dans un opéra), la tessiture précise.</para>
    /// labels<para>M23 Détail de la distribution</para><para>M23 Casting Detail</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M23_Casting_Detail">http://data.doremus.org/ontology#M23_Casting_Detail</seealso>
    let M23_Casting_Detail = Prefixed_Name(mus, "M23_Casting_Detail") |> PrefixedName
    /// <summary>
    ///   <para>mus:M24_Track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M24 Piste</para><para>M24 Track</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M24_Track">http://data.doremus.org/ontology#M24_Track</seealso>
    let M24_Track = Prefixed_Name(mus, "M24_Track") |> PrefixedName

    /// <summary>
    ///   <para>mus:M25_Foreseen_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M25 Activité prévisionnelle</para><para>M25 Foreseen Activity</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M25_Foreseen_Activity">http://data.doremus.org/ontology#M25_Foreseen_Activity</seealso>
    let M25_Foreseen_Activity =
        Prefixed_Name(mus, "M25_Foreseen_Activity") |> PrefixedName

    /// <summary>
    ///   <para>mus:M26_Foreseen_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M26 Performance prévisionnelle</para><para>M26 Foreseen Performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M26_Foreseen_Performance">http://data.doremus.org/ontology#M26_Foreseen_Performance</seealso>
    let M26_Foreseen_Performance =
        Prefixed_Name(mus, "M26_Foreseen_Performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:M27_Foreseen_Individual_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M27 Performance individuelle prévisionnelle</para><para>M27 Foreseen Individual Performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M27_Foreseen_Individual_Performance">http://data.doremus.org/ontology#M27_Foreseen_Individual_Performance</seealso>
    let M27_Foreseen_Individual_Performance =
        Prefixed_Name(mus, "M27_Foreseen_Individual_Performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:M2_Opus_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M2 Mention d'opus</para><para>M2 Opus Statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M2_Opus_Statement">http://data.doremus.org/ontology#M2_Opus_Statement</seealso>
    let M2_Opus_Statement = Prefixed_Name(mus, "M2_Opus_Statement") |> PrefixedName
    /// <summary>
    ///   <para>mus:M30_Ambitus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M30 Ambitus</para><para>M30 Ambitus</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M30_Ambitus">http://data.doremus.org/ontology#M30_Ambitus</seealso>
    let M30_Ambitus = Prefixed_Name(mus, "M30_Ambitus") |> PrefixedName

    /// <summary>
    ///   <para>mus:M33_Set_of_Characters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M33 Ensemble de personnages</para><para>M33 Set of Characters</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M33_Set_of_Characters">http://data.doremus.org/ontology#M33_Set_of_Characters</seealso>
    let M33_Set_of_Characters =
        Prefixed_Name(mus, "M33_Set_of_Characters") |> PrefixedName

    /// <summary>
    ///   <para>mus:M34_Award_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M34 Attribution de récompense</para><para>M34 Award Assignment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M34_Award_Assignment">http://data.doremus.org/ontology#M34_Award_Assignment</seealso>
    let M34_Award_Assignment =
        Prefixed_Name(mus, "M34_Award_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>mus:M36_Award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M36 Récompense</para><para>M36 Award</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M36_Award">http://data.doremus.org/ontology#M36_Award</seealso>
    let M36_Award = Prefixed_Name(mus, "M36_Award") |> PrefixedName
    /// <summary>
    ///   <para>mus:M37_Music_Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M37 Echelle Musicale</para><para>M37 Music Scale</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M37_Music_Scale">http://data.doremus.org/ontology#M37_Music_Scale</seealso>
    let M37_Music_Scale = Prefixed_Name(mus, "M37_Music_Scale") |> PrefixedName

    /// <summary>
    ///   <para>mus:M38_Rhythmic_Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M38 Rhythmic Pattern</para><para>M38 Figure Rythmique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M38_Rhythmic_Pattern">http://data.doremus.org/ontology#M38_Rhythmic_Pattern</seealso>
    let M38_Rhythmic_Pattern =
        Prefixed_Name(mus, "M38_Rhythmic_Pattern") |> PrefixedName

    /// <summary>
    ///   <para>mus:M40_Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M40 Contexte</para><para>M40 Context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M40_Context">http://data.doremus.org/ontology#M40_Context</seealso>
    let M40_Context = Prefixed_Name(mus, "M40_Context") |> PrefixedName

    /// <summary>
    ///   <para>mus:M41_Metronome_Indication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M41 Indication Métronomique</para><para>M41 Metronome Indication</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M41_Metronome_Indication">http://data.doremus.org/ontology#M41_Metronome_Indication</seealso>
    let M41_Metronome_Indication =
        Prefixed_Name(mus, "M41_Metronome_Indication") |> PrefixedName

    /// <summary>
    ///   <para>mus:M42_Performed_Expression_Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M42 Création d'Expression interprétée</para><para>M42 Performed Expression Creation</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M42_Performed_Expression_Creation">http://data.doremus.org/ontology#M42_Performed_Expression_Creation</seealso>
    let M42_Performed_Expression_Creation =
        Prefixed_Name(mus, "M42_Performed_Expression_Creation") |> PrefixedName

    /// <summary>
    ///   <para>mus:M44_Performed_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M44 Oeuvre interprétée</para><para>M44 Performed Work</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M44_Performed_Work">http://data.doremus.org/ontology#M44_Performed_Work</seealso>
    let M44_Performed_Work = Prefixed_Name(mus, "M44_Performed_Work") |> PrefixedName

    /// <summary>
    ///   <para>mus:M45_Descriptive_Expression_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M45 Attribution d'Expression Descriptive</para><para>M45 Descriptive Expression Assignment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M45_Descriptive_Expression_Assignment">http://data.doremus.org/ontology#M45_Descriptive_Expression_Assignment</seealso>
    let M45_Descriptive_Expression_Assignment =
        Prefixed_Name(mus, "M45_Descriptive_Expression_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>mus:M47_WoO_Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M47 Numéro de WoO</para><para>M47 WoO Number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M47_WoO_Number">http://data.doremus.org/ontology#M47_WoO_Number</seealso>
    let M47_WoO_Number = Prefixed_Name(mus, "M47_WoO_Number") |> PrefixedName
    /// <summary>
    ///   <para>mus:M48_WoO_Subnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M48 WoO Subnumber</para><para>WoO sous-numéro</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M48_WoO_Subnumber">http://data.doremus.org/ontology#M48_WoO_Subnumber</seealso>
    let M48_WoO_Subnumber = Prefixed_Name(mus, "M48_WoO_Subnumber") |> PrefixedName
    /// <summary>
    ///   <para>mus:M4_Key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scope note:
    /// Cette classe décrit la tonalité de l’œuvre.
    /// Les tonalités sont souvent listées sous forme de référentiels multilingues, c’est pourquoi la classe M4 Key est liée à la classe M7 Linguistic Appellation.</para>
    ///   <para>Examples:	→ Le Concerto pour Piano et orchestre en Si bémol majeur de Beethoven a pour tonalité si bémol majeur :
    /// F22 Self-Contained Expression u11 has key M4 Key { Si bémol Majeur }</para>
    /// labels<para>M4 Tonalité</para><para>M4 Key</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M4_Key">http://data.doremus.org/ontology#M4_Key</seealso>
    let M4_Key = Prefixed_Name(mus, "M4_Key") |> PrefixedName

    /// <summary>
    ///   <para>mus:M50_Creation_or_Performance_Mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M50 Mode de performance</para><para>M50 Performance mode</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M50_Creation_or_Performance_Mode">http://data.doremus.org/ontology#M50_Creation_or_Performance_Mode</seealso>
    let M50_Creation_or_Performance_Mode =
        Prefixed_Name(mus, "M50_Creation_or_Performance_Mode") |> PrefixedName

    /// <summary>
    ///   <para>mus:M52_Equalization_Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M52 Technique d'équalisation</para><para>M52 Equalization technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M52_Equalization_Technique">http://data.doremus.org/ontology#M52_Equalization_Technique</seealso>
    let M52_Equalization_Technique =
        Prefixed_Name(mus, "M52_Equalization_Technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:M53_Noise_Reduction_Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M53 Technique de réduction de bruit</para><para>M53 Noise reduction  technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M53_Noise_Reduction_Technique">http://data.doremus.org/ontology#M53_Noise_Reduction_Technique</seealso>
    let M53_Noise_Reduction_Technique =
        Prefixed_Name(mus, "M53_Noise_Reduction_Technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:M54_Sound_Spatialization_Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M54 Technique de spatialisation du son</para><para>M54 Sound spatialization technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M54_Sound_Spatialization_Technique">http://data.doremus.org/ontology#M54_Sound_Spatialization_Technique</seealso>
    let M54_Sound_Spatialization_Technique =
        Prefixed_Name(mus, "M54_Sound_Spatialization_Technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:M55_Condition_of_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M55 Condition de la performance</para><para>M55 Condition of performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M55_Condition_of_Performance">http://data.doremus.org/ontology#M55_Condition_of_Performance</seealso>
    let M55_Condition_of_Performance =
        Prefixed_Name(mus, "M55_Condition_of_Performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:M57_Vocal_or_Instrumental_Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M57 Technique vocale ou instrumentale</para><para>M57 Vocal or instrumental technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M57_Vocal_or_Instrumental_Technique">http://data.doremus.org/ontology#M57_Vocal_or_Instrumental_Technique</seealso>
    let M57_Vocal_or_Instrumental_Technique =
        Prefixed_Name(mus, "M57_Vocal_or_Instrumental_Technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:M59_Program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M59 Programme</para><para>M59 Program</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M59_Program">http://data.doremus.org/ontology#M59_Program</seealso>
    let M59_Program = Prefixed_Name(mus, "M59_Program") |> PrefixedName
    /// <summary>
    ///   <para>mus:M5_Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M5 Genre</para><para>M5 Genre</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M5_Genre">http://data.doremus.org/ontology#M5_Genre</seealso>
    let M5_Genre = Prefixed_Name(mus, "M5_Genre") |> PrefixedName

    /// <summary>
    ///   <para>mus:M60_Intended_Audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M60 Intended audience</para><para>M60 Public visé</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M60_Intended_Audience">http://data.doremus.org/ontology#M60_Intended_Audience</seealso>
    let M60_Intended_Audience =
        Prefixed_Name(mus, "M60_Intended_Audience") |> PrefixedName

    /// <summary>
    ///   <para>mus:M61_Work_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M61 Type d'oeuvre</para><para>M61 Work type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M61_Work_Type">http://data.doremus.org/ontology#M61_Work_Type</seealso>
    let M61_Work_Type = Prefixed_Name(mus, "M61_Work_Type") |> PrefixedName

    /// <summary>
    ///   <para>mus:M62_Hierarchical_Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M62 Niveau hiérarchique</para><para>M62 Hierarchical level</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M62_Hierarchical_Level">http://data.doremus.org/ontology#M62_Hierarchical_Level</seealso>
    let M62_Hierarchical_Level =
        Prefixed_Name(mus, "M62_Hierarchical_Level") |> PrefixedName

    /// <summary>
    ///   <para>mus:M6_Casting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scope note:
    /// Cette classe permet de décrire les « medium of performance » d’une œuvre, c’est-à-dire les instruments, machines, exécutants autres que musiciens (danseurs, acteurs, récitants,…) pour lesquels l’œuvre a été composée. Elle décrit donc l’intention du compositeur. M6 Casting est une « classe chapeau » qui représente la globalité de la distribution instrumentale et/ou vocale. Le détail de cette distribution est décrit via la classe M23 Casting Detail.
    /// Dans le cas de versions alternatives, on donnera deux M6 Casting différents pour la même expression.</para>
    /// labels<para>M6 Distribution vocale ou instrumentale</para><para>M6 Casting</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M6_Casting">http://data.doremus.org/ontology#M6_Casting</seealso>
    let M6_Casting = Prefixed_Name(mus, "M6_Casting") |> PrefixedName
    /// <summary>
    ///   <para>mus:M8_Tempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M8 Tempo</para><para>M8 Tempo</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M8_Tempo">http://data.doremus.org/ontology#M8_Tempo</seealso>
    let M8_Tempo = Prefixed_Name(mus, "M8_Tempo") |> PrefixedName
    /// <summary>
    ///   <para>mus:M9_Derivation_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M9 Type de dérivation</para><para>M9 Derivation Type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M9_Derivation_Type">http://data.doremus.org/ontology#M9_Derivation_Type</seealso>
    let M9_Derivation_Type = Prefixed_Name(mus, "M9_Derivation_Type") |> PrefixedName

    /// <summary>
    ///   <para>mus:U10_has_order_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U10 has order number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U10_has_order_number">http://data.doremus.org/ontology#U10_has_order_number</seealso>
    let U10_has_order_number =
        Prefixed_Name(mus, "U10_has_order_number") |> PrefixedName

    /// <summary>
    ///   <para>mus:U11_has_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U11 has key</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U11_has_key">http://data.doremus.org/ontology#U11_has_key</seealso>
    let U11_has_key = Prefixed_Name(mus, "U11_has_key") |> PrefixedName
    /// <summary>
    ///   <para>mus:U12i_is_genre_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U12i is genre of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U12i_is_genre_of">http://data.doremus.org/ontology#U12i_is_genre_of</seealso>
    let U12i_is_genre_of = Prefixed_Name(mus, "U12i_is_genre_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U13_has_casting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U13 has casting</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U13_has_casting">http://data.doremus.org/ontology#U13_has_casting</seealso>
    let U13_has_casting = Prefixed_Name(mus, "U13_has_casting") |> PrefixedName
    /// <summary>
    ///   <para>mus:U13i_is_casting_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U13i is casting of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U13i_is_casting_of">http://data.doremus.org/ontology#U13i_is_casting_of</seealso>
    let U13i_is_casting_of = Prefixed_Name(mus, "U13i_is_casting_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U14_has_tempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U14 has tempo</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U14_has_tempo">http://data.doremus.org/ontology#U14_has_tempo</seealso>
    let U14_has_tempo = Prefixed_Name(mus, "U14_has_tempo") |> PrefixedName
    /// <summary>
    ///   <para>mus:U14i_is_tempo_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U14i is tempo of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U14i_is_tempo_of">http://data.doremus.org/ontology#U14i_is_tempo_of</seealso>
    let U14i_is_tempo_of = Prefixed_Name(mus, "U14i_is_tempo_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U15_has_history</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U15 has history</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U15_has_history">http://data.doremus.org/ontology#U15_has_history</seealso>
    let U15_has_history = Prefixed_Name(mus, "U15_has_history") |> PrefixedName

    /// <summary>
    ///   <para>mus:U16_has_catalogue_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U16 has catalogue statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U16_has_catalogue_statement">http://data.doremus.org/ontology#U16_has_catalogue_statement</seealso>
    let U16_has_catalogue_statement =
        Prefixed_Name(mus, "U16_has_catalogue_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U16i_is_catalogue_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U16i is catalogue statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U16i_is_catalogue_statement_of">http://data.doremus.org/ontology#U16i_is_catalogue_statement_of</seealso>
    let U16i_is_catalogue_statement_of =
        Prefixed_Name(mus, "U16i_is_catalogue_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U170_has_title_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U170 has title statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U170_has_title_statement">http://data.doremus.org/ontology#U170_has_title_statement</seealso>
    let U170_has_title_statement =
        Prefixed_Name(mus, "U170_has_title_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U170i_is_title_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U170i is title statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U170i_is_title_statement_of">http://data.doremus.org/ontology#U170i_is_title_statement_of</seealso>
    let U170i_is_title_statement_of =
        Prefixed_Name(mus, "U170i_is_title_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U171_has_parallel_title_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U171 has parallel title statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U171_has_parallel_title_statement">http://data.doremus.org/ontology#U171_has_parallel_title_statement</seealso>
    let U171_has_parallel_title_statement =
        Prefixed_Name(mus, "U171_has_parallel_title_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U172i_is_statement_of_responsibility_relating_to_title_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U172i is statement of responsibility relating to title of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U172i_is_statement_of_responsibility_relating_to_title_of">http://data.doremus.org/ontology#U172i_is_statement_of_responsibility_relating_to_title_of</seealso>
    let U172i_is_statement_of_responsibility_relating_to_title_of =
        Prefixed_Name(mus, "U172i_is_statement_of_responsibility_relating_to_title_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U173_has_parallel_statement_of_responsibility_relating_to_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U173 has parallel statement of responsibility relating to title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U173_has_parallel_statement_of_responsibility_relating_to_title">http://data.doremus.org/ontology#U173_has_parallel_statement_of_responsibility_relating_to_title</seealso>
    let U173_has_parallel_statement_of_responsibility_relating_to_title =
        Prefixed_Name(mus, "U173_has_parallel_statement_of_responsibility_relating_to_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:U173i_is_parallel_statement_of_responsibility_relating_to_title_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U173i is parallel statement of responsibility relating to title of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U173i_is_parallel_statement_of_responsibility_relating_to_title_of">http://data.doremus.org/ontology#U173i_is_parallel_statement_of_responsibility_relating_to_title_of</seealso>
    let U173i_is_parallel_statement_of_responsibility_relating_to_title_of =
        Prefixed_Name(mus, "U173i_is_parallel_statement_of_responsibility_relating_to_title_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U174_has_cast_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U174 has cast statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U174_has_cast_statement">http://data.doremus.org/ontology#U174_has_cast_statement</seealso>
    let U174_has_cast_statement =
        Prefixed_Name(mus, "U174_has_cast_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U174i_is_cast_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U174i is cast statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U174i_is_cast_statement_of">http://data.doremus.org/ontology#U174i_is_cast_statement_of</seealso>
    let U174i_is_cast_statement_of =
        Prefixed_Name(mus, "U174i_is_cast_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U175_has_parallel_cast_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U175 has parallel cast statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U175_has_parallel_cast_statement">http://data.doremus.org/ontology#U175_has_parallel_cast_statement</seealso>
    let U175_has_parallel_cast_statement =
        Prefixed_Name(mus, "U175_has_parallel_cast_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U175i_is_parallel_cast_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U175i is parallel cast statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U175i_is_parallel_cast_statement_of">http://data.doremus.org/ontology#U175i_is_parallel_cast_statement_of</seealso>
    let U175i_is_parallel_cast_statement_of =
        Prefixed_Name(mus, "U175i_is_parallel_cast_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U176_has_edition_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U176 has edition statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U176_has_edition_statement">http://data.doremus.org/ontology#U176_has_edition_statement</seealso>
    let U176_has_edition_statement =
        Prefixed_Name(mus, "U176_has_edition_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U198_has_container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U198 has container</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U198_has_container">http://data.doremus.org/ontology#U198_has_container</seealso>
    let U198_has_container = Prefixed_Name(mus, "U198_has_container") |> PrefixedName
    /// <summary>
    ///   <para>mus:U199_has_sponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U199 has sponsor</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U199_has_sponsor">http://data.doremus.org/ontology#U199_has_sponsor</seealso>
    let U199_has_sponsor = Prefixed_Name(mus, "U199_has_sponsor") |> PrefixedName

    /// <summary>
    ///   <para>mus:U19_is_categorized_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U19 is categorized as</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U19_is_categorized_as">http://data.doremus.org/ontology#U19_is_categorized_as</seealso>
    let U19_is_categorized_as =
        Prefixed_Name(mus, "U19_is_categorized_as") |> PrefixedName

    /// <summary>
    ///   <para>mus:U19i_categorizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U19i categorizes</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U19i_categorizes">http://data.doremus.org/ontology#U19i_categorizes</seealso>
    let U19i_categorizes = Prefixed_Name(mus, "U19i_categorizes") |> PrefixedName

    /// <summary>
    ///   <para>mus:U1_used_medium_of_performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>U1 instrument ou voix utilisé pour la performance</para>
    /// labels<para>U1 used medium of performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U1_used_medium_of_performance">http://data.doremus.org/ontology#U1_used_medium_of_performance</seealso>
    let U1_used_medium_of_performance =
        Prefixed_Name(mus, "U1_used_medium_of_performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:U1i_medium_of_performance_was_used_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U1i medium of performance was used in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U1i_medium_of_performance_was_used_in">http://data.doremus.org/ontology#U1i_medium_of_performance_was_used_in</seealso>
    let U1i_medium_of_performance_was_used_in =
        Prefixed_Name(mus, "U1i_medium_of_performance_was_used_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U200_has_supplementary_content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U200 has supplementary content</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U200_has_supplementary_content">http://data.doremus.org/ontology#U200_has_supplementary_content</seealso>
    let U200_has_supplementary_content =
        Prefixed_Name(mus, "U200_has_supplementary_content") |> PrefixedName

    /// <summary>
    ///   <para>mus:U201_has_illustrative_content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U201 has illustrative content</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U201_has_illustrative_content">http://data.doremus.org/ontology#U201_has_illustrative_content</seealso>
    let U201_has_illustrative_content =
        Prefixed_Name(mus, "U201_has_illustrative_content") |> PrefixedName

    /// <summary>
    ///   <para>mus:U202_has_colour_details</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U202 has colour details</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U202_has_colour_details">http://data.doremus.org/ontology#U202_has_colour_details</seealso>
    let U202_has_colour_details =
        Prefixed_Name(mus, "U202_has_colour_details") |> PrefixedName

    /// <summary>
    ///   <para>mus:U203_has_summary_or_abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U203 has summary or abstract</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U203_has_summary_or_abstract">http://data.doremus.org/ontology#U203_has_summary_or_abstract</seealso>
    let U203_has_summary_or_abstract =
        Prefixed_Name(mus, "U203_has_summary_or_abstract") |> PrefixedName

    /// <summary>
    ///   <para>mus:U204_has_reproduction_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U204 has reproduction note</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U204_has_reproduction_note">http://data.doremus.org/ontology#U204_has_reproduction_note</seealso>
    let U204_has_reproduction_note =
        Prefixed_Name(mus, "U204_has_reproduction_note") |> PrefixedName

    /// <summary>
    ///   <para>mus:U205_has_cast_detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U205 has cast detail</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U205_has_cast_detail">http://data.doremus.org/ontology#U205_has_cast_detail</seealso>
    let U205_has_cast_detail =
        Prefixed_Name(mus, "U205_has_cast_detail") |> PrefixedName

    /// <summary>
    ///   <para>mus:U206_has_media_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U206 has media type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U206_has_media_type">http://data.doremus.org/ontology#U206_has_media_type</seealso>
    let U206_has_media_type = Prefixed_Name(mus, "U206_has_media_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:U206i_is_media_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U206i is media type of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U206i_is_media_type_of">http://data.doremus.org/ontology#U206i_is_media_type_of</seealso>
    let U206i_is_media_type_of =
        Prefixed_Name(mus, "U206i_is_media_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U33_has_set_of_characters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U33 has set of characters</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U33_has_set_of_characters">http://data.doremus.org/ontology#U33_has_set_of_characters</seealso>
    let U33_has_set_of_characters =
        Prefixed_Name(mus, "U33_has_set_of_characters") |> PrefixedName

    /// <summary>
    ///   <para>mus:U33i_is_set_of_characters_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U33i is set of characters of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U33i_is_set_of_characters_of">http://data.doremus.org/ontology#U33i_is_set_of_characters_of</seealso>
    let U33i_is_set_of_characters_of =
        Prefixed_Name(mus, "U33i_is_set_of_characters_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U34_foresees_character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U34 foresees character</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U34_foresees_character">http://data.doremus.org/ontology#U34_foresees_character</seealso>
    let U34_foresees_character =
        Prefixed_Name(mus, "U34_foresees_character") |> PrefixedName

    /// <summary>
    ///   <para>mus:U34i_is_foreseen_character_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U34i is foreseen character of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U34i_is_foreseen_character_of">http://data.doremus.org/ontology#U34i_is_foreseen_character_of</seealso>
    let U34i_is_foreseen_character_of =
        Prefixed_Name(mus, "U34i_is_foreseen_character_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U35_foresees_function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U35 foresees function</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U35_foresees_function">http://data.doremus.org/ontology#U35_foresees_function</seealso>
    let U35_foresees_function =
        Prefixed_Name(mus, "U35_foresees_function") |> PrefixedName

    /// <summary>
    ///   <para>mus:U35i_is_foreseen_function_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U35i is foreseen function of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U35i_is_foreseen_function_of">http://data.doremus.org/ontology#U35i_is_foreseen_function_of</seealso>
    let U35i_is_foreseen_function_of =
        Prefixed_Name(mus, "U35i_is_foreseen_function_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U36_foresees_responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U36 foresees responsibility</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U36_foresees_responsibility">http://data.doremus.org/ontology#U36_foresees_responsibility</seealso>
    let U36_foresees_responsibility =
        Prefixed_Name(mus, "U36_foresees_responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:U36i_is_foreseen_responsibility_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U36i is foreseen responsibility of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U36i_is_foreseen_responsibility_of">http://data.doremus.org/ontology#U36i_is_foreseen_responsibility_of</seealso>
    let U36i_is_foreseen_responsibility_of =
        Prefixed_Name(mus, "U36i_is_foreseen_responsibility_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U37_foresees_performing_character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U37 foresees performing character</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U37_foresees_performing_character">http://data.doremus.org/ontology#U37_foresees_performing_character</seealso>
    let U37_foresees_performing_character =
        Prefixed_Name(mus, "U37_foresees_performing_character") |> PrefixedName

    /// <summary>
    ///   <para>mus:U37i_is_foreseen_character_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U37i is foreseen character in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U37i_is_foreseen_character_in">http://data.doremus.org/ontology#U37i_is_foreseen_character_in</seealso>
    let U37i_is_foreseen_character_in =
        Prefixed_Name(mus, "U37i_is_foreseen_character_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U38_has_descriptive_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U38 a pour expression descriptive</para><para>U38 has descriptive expression</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U38_has_descriptive_expression">http://data.doremus.org/ontology#U38_has_descriptive_expression</seealso>
    let U38_has_descriptive_expression =
        Prefixed_Name(mus, "U38_has_descriptive_expression") |> PrefixedName

    /// <summary>
    ///   <para>mus:U38i_is_descriptive_expression_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U38i is descriptive expression of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U38i_is_descriptive_expression_of">http://data.doremus.org/ontology#U38i_is_descriptive_expression_of</seealso>
    let U38i_is_descriptive_expression_of =
        Prefixed_Name(mus, "U38i_is_descriptive_expression_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U39_has_tuned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U39 has tuned</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U39_has_tuned">http://data.doremus.org/ontology#U39_has_tuned</seealso>
    let U39_has_tuned = Prefixed_Name(mus, "U39_has_tuned") |> PrefixedName
    /// <summary>
    ///   <para>mus:U39i_was_tuned_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U39i was tuned by</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U39i_was_tuned_by">http://data.doremus.org/ontology#U39i_was_tuned_by</seealso>
    let U39i_was_tuned_by = Prefixed_Name(mus, "U39i_was_tuned_by") |> PrefixedName

    /// <summary>
    ///   <para>mus:U43_has_opus_subnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U43 has opus subnumber</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U43_has_opus_subnumber">http://data.doremus.org/ontology#U43_has_opus_subnumber</seealso>
    let U43_has_opus_subnumber =
        Prefixed_Name(mus, "U43_has_opus_subnumber") |> PrefixedName

    /// <summary>
    ///   <para>mus:U44_has_dedication_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U44 has dedication statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U44_has_dedication_statement">http://data.doremus.org/ontology#U44_has_dedication_statement</seealso>
    let U44_has_dedication_statement =
        Prefixed_Name(mus, "U44_has_dedication_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U44i_is_dedication_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U44i is dedication statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U44i_is_dedication_statement_of">http://data.doremus.org/ontology#U44i_is_dedication_statement_of</seealso>
    let U44i_is_dedication_statement_of =
        Prefixed_Name(mus, "U44i_is_dedication_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U45_has_metronome_indication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U45 a pour indication métronomique</para><para>U45 has metronome indication</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U45_has_metronome_indication">http://data.doremus.org/ontology#U45_has_metronome_indication</seealso>
    let U45_has_metronome_indication =
        Prefixed_Name(mus, "U45_has_metronome_indication") |> PrefixedName

    /// <summary>
    ///   <para>mus:U45i_is_metronome_indication_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U45i is metronome indication of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U45i_is_metronome_indication_of">http://data.doremus.org/ontology#U45i_is_metronome_indication_of</seealso>
    let U45i_is_metronome_indication_of =
        Prefixed_Name(mus, "U45i_is_metronome_indication_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U46_occurred_in_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U46 occurred in context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U46_occurred_in_context">http://data.doremus.org/ontology#U46_occurred_in_context</seealso>
    let U46_occurred_in_context =
        Prefixed_Name(mus, "U46_occurred_in_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U46i_was_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U46i was context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U46i_was_context_of">http://data.doremus.org/ontology#U46i_was_context_of</seealso>
    let U46i_was_context_of = Prefixed_Name(mus, "U46i_was_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U47_has_derivation_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U47 has derivation type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U47_has_derivation_type">http://data.doremus.org/ontology#U47_has_derivation_type</seealso>
    let U47_has_derivation_type =
        Prefixed_Name(mus, "U47_has_derivation_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:U47i_is_derivation_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U47i is derivation type of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U47i_is_derivation_type_of">http://data.doremus.org/ontology#U47i_is_derivation_type_of</seealso>
    let U47i_is_derivation_type_of =
        Prefixed_Name(mus, "U47i_is_derivation_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U48_foresees_quantity_of_actors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U48 foresees quantity of actors</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U48_foresees_quantity_of_actors">http://data.doremus.org/ontology#U48_foresees_quantity_of_actors</seealso>
    let U48_foresees_quantity_of_actors =
        Prefixed_Name(mus, "U48_foresees_quantity_of_actors") |> PrefixedName

    /// <summary>
    ///   <para>mus:U49_created_for_actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>personne ou groupe pour lequel l'Expression a été créée.</para>
    /// labels<para>U49 created for actor</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U49_created_for_actor">http://data.doremus.org/ontology#U49_created_for_actor</seealso>
    let U49_created_for_actor =
        Prefixed_Name(mus, "U49_created_for_actor") |> PrefixedName

    /// <summary>
    ///   <para>mus:U49i_actor_motivated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U49i actor motivated</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U49i_actor_motivated">http://data.doremus.org/ontology#U49i_actor_motivated</seealso>
    let U49i_actor_motivated =
        Prefixed_Name(mus, "U49i_actor_motivated") |> PrefixedName

    /// <summary>
    ///   <para>mus:U4_had_princeps_publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U4 had princeps publication</para><para>U4 a pour édition princeps</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U4_had_princeps_publication">http://data.doremus.org/ontology#U4_had_princeps_publication</seealso>
    let U4_had_princeps_publication =
        Prefixed_Name(mus, "U4_had_princeps_publication") |> PrefixedName

    /// <summary>
    ///   <para>mus:U53i_is_duration_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U53i is duration of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U53i_is_duration_of">http://data.doremus.org/ontology#U53i_is_duration_of</seealso>
    let U53i_is_duration_of = Prefixed_Name(mus, "U53i_is_duration_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U54_is_performed_expression_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U54 is performed expression of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U54_is_performed_expression_of">http://data.doremus.org/ontology#U54_is_performed_expression_of</seealso>
    let U54_is_performed_expression_of =
        Prefixed_Name(mus, "U54_is_performed_expression_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U54i_has_performed_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U54i has performed expression</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U54i_has_performed_expression">http://data.doremus.org/ontology#U54i_has_performed_expression</seealso>
    let U54i_has_performed_expression =
        Prefixed_Name(mus, "U54i_has_performed_expression") |> PrefixedName

    /// <summary>
    ///   <para>mus:U55_incorporates_performed_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U55 incorporates performed expression</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U55_incorporates_performed_expression">http://data.doremus.org/ontology#U55_incorporates_performed_expression</seealso>
    let U55_incorporates_performed_expression =
        Prefixed_Name(mus, "U55_incorporates_performed_expression") |> PrefixedName

    /// <summary>
    ///   <para>mus:U55i_performed_expression_is_incorporated_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U55i performed expression is incorporated in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U55i_performed_expression_is_incorporated_in">http://data.doremus.org/ontology#U55i_performed_expression_is_incorporated_in</seealso>
    let U55i_performed_expression_is_incorporated_in =
        Prefixed_Name(mus, "U55i_performed_expression_is_incorporated_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U56_occurred_in_historical_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U56 occurred in historical context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U56_occurred_in_historical_context">http://data.doremus.org/ontology#U56_occurred_in_historical_context</seealso>
    let U56_occurred_in_historical_context =
        Prefixed_Name(mus, "U56_occurred_in_historical_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U56i_was_historical_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U56i was historical context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U56i_was_historical_context_of">http://data.doremus.org/ontology#U56i_was_historical_context_of</seealso>
    let U56i_was_historical_context_of =
        Prefixed_Name(mus, "U56i_was_historical_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U57_occurred_in_religious_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U57 occurred in religious context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U57_occurred_in_religious_context">http://data.doremus.org/ontology#U57_occurred_in_religious_context</seealso>
    let U57_occurred_in_religious_context =
        Prefixed_Name(mus, "U57_occurred_in_religious_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U57i_was_religious_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U57i was religious context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U57i_was_religious_context_of">http://data.doremus.org/ontology#U57i_was_religious_context_of</seealso>
    let U57i_was_religious_context_of =
        Prefixed_Name(mus, "U57i_was_religious_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U58_has_full_published_recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U58 has full published recording</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U58_has_full_published_recording">http://data.doremus.org/ontology#U58_has_full_published_recording</seealso>
    let U58_has_full_published_recording =
        Prefixed_Name(mus, "U58_has_full_published_recording") |> PrefixedName

    /// <summary>
    ///   <para>mus:U58i_is_full_published_recording_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U58i is full published recording of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U58i_is_full_published_recording_of">http://data.doremus.org/ontology#U58i_is_full_published_recording_of</seealso>
    let U58i_is_full_published_recording_of =
        Prefixed_Name(mus, "U58i_is_full_published_recording_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U59_has_partial_published_recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U59 has partial published recording</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U59_has_partial_published_recording">http://data.doremus.org/ontology#U59_has_partial_published_recording</seealso>
    let U59_has_partial_published_recording =
        Prefixed_Name(mus, "U59_has_partial_published_recording") |> PrefixedName

    /// <summary>
    ///   <para>mus:U59i_is_partial_published_recording_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U59i is partial published recording of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U59i_is_partial_published_recording_of">http://data.doremus.org/ontology#U59i_is_partial_published_recording_of</seealso>
    let U59i_is_partial_published_recording_of =
        Prefixed_Name(mus, "U59i_is_partial_published_recording_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U5_had_premiere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U5 a une première</para><para>U5 had premiere</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U5_had_premiere">http://data.doremus.org/ontology#U5_had_premiere</seealso>
    let U5_had_premiere = Prefixed_Name(mus, "U5_had_premiere") |> PrefixedName

    /// <summary>
    ///   <para>mus:U63i_is_religious_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U63i is religious context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U63i_is_religious_context_of">http://data.doremus.org/ontology#U63i_is_religious_context_of</seealso>
    let U63i_is_religious_context_of =
        Prefixed_Name(mus, "U63i_is_religious_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U64_has_cultural_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U64 has cultural context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U64_has_cultural_context">http://data.doremus.org/ontology#U64_has_cultural_context</seealso>
    let U64_has_cultural_context =
        Prefixed_Name(mus, "U64_has_cultural_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U64i_is_cultural_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U64i is cultural context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U64i_is_cultural_context_of">http://data.doremus.org/ontology#U64i_is_cultural_context_of</seealso>
    let U64i_is_cultural_context_of =
        Prefixed_Name(mus, "U64i_is_cultural_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U65_has_geographical_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U65 has geographical context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U65_has_geographical_context">http://data.doremus.org/ontology#U65_has_geographical_context</seealso>
    let U65_has_geographical_context =
        Prefixed_Name(mus, "U65_has_geographical_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U65i_is_geographical_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U65i is geographical context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U65i_is_geographical_context_of">http://data.doremus.org/ontology#U65i_is_geographical_context_of</seealso>
    let U65i_is_geographical_context_of =
        Prefixed_Name(mus, "U65i_is_geographical_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U66_has_historical_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U66 has historical context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U66_has_historical_context">http://data.doremus.org/ontology#U66_has_historical_context</seealso>
    let U66_has_historical_context =
        Prefixed_Name(mus, "U66_has_historical_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U66i_is_historical_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U66i is historical context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U66i_is_historical_context_of">http://data.doremus.org/ontology#U66i_is_historical_context_of</seealso>
    let U66i_is_historical_context_of =
        Prefixed_Name(mus, "U66i_is_historical_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U67_has_subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U67 a pour sous-titre</para><para>U67 has subtitle</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U67_has_subtitle">http://data.doremus.org/ontology#U67_has_subtitle</seealso>
    let U67_has_subtitle = Prefixed_Name(mus, "U67_has_subtitle") |> PrefixedName

    /// <summary>
    ///   <para>mus:U68_has_variant_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U68 a pour variante de titre</para><para>U68 has variant title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U68_has_variant_title">http://data.doremus.org/ontology#U68_has_variant_title</seealso>
    let U68_has_variant_title =
        Prefixed_Name(mus, "U68_has_variant_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:U69_has_WoO_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U69 a pour numéro de WoO</para><para>U69 has WoO number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U69_has_WoO_number">http://data.doremus.org/ontology#U69_has_WoO_number</seealso>
    let U69_has_WoO_number = Prefixed_Name(mus, "U69_has_WoO_number") |> PrefixedName
    /// <summary>
    ///   <para>mus:U6_foresees_actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U6 foresees actor</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U6_foresees_actor">http://data.doremus.org/ontology#U6_foresees_actor</seealso>
    let U6_foresees_actor = Prefixed_Name(mus, "U6_foresees_actor") |> PrefixedName

    /// <summary>
    ///   <para>mus:U6i_is_foreseen_actor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U6i is foreseen actor of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U6i_is_foreseen_actor_of">http://data.doremus.org/ontology#U6i_is_foreseen_actor_of</seealso>
    let U6i_is_foreseen_actor_of =
        Prefixed_Name(mus, "U6i_is_foreseen_actor_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U70_has_original_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U70 a pour titre originel</para><para>U70 has original title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U70_has_original_title">http://data.doremus.org/ontology#U70_has_original_title</seealso>
    let U70_has_original_title =
        Prefixed_Name(mus, "U70_has_original_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:U71_has_uniform_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U71 a pour titre uniforme</para><para>U71 has uniform title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U71_has_uniform_title">http://data.doremus.org/ontology#U71_has_uniform_title</seealso>
    let U71_has_uniform_title =
        Prefixed_Name(mus, "U71_has_uniform_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLI198i_should_be_container_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU198i should be container of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLI198i_should_be_container_of">http://data.doremus.org/ontology#CLI198i_should_be_container_of</seealso>
    let CLI198i_should_be_container_of =
        Prefixed_Name(mus, "CLI198i_should_be_container_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:M168_Media_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M168 Type de média</para><para>M168 Media type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M168_Media_Type">http://data.doremus.org/ontology#M168_Media_Type</seealso>
    let M168_Media_Type = Prefixed_Name(mus, "M168_Media_Type") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU206i_should_be_media_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU206i should be media type of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU206i_should_be_media_type_of">http://data.doremus.org/ontology#CLU206i_should_be_media_type_of</seealso>
    let CLU206i_should_be_media_type_of =
        Prefixed_Name(mus, "CLU206i_should_be_media_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU210i_should_be_pagination_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU210i should be pagination of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU210i_should_be_pagination_of">http://data.doremus.org/ontology#CLU210i_should_be_pagination_of</seealso>
    let CLU210i_should_be_pagination_of =
        Prefixed_Name(mus, "CLU210i_should_be_pagination_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:M15_Dedication_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M15 Dedication Statement</para><para>M15 Mention de dédicace</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M15_Dedication_Statement">http://data.doremus.org/ontology#M15_Dedication_Statement</seealso>
    let M15_Dedication_Statement =
        Prefixed_Name(mus, "M15_Dedication_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M161_Distribution_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M161 Distribution statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M161_Distribution_Statement">http://data.doremus.org/ontology#M161_Distribution_Statement</seealso>
    let M161_Distribution_Statement =
        Prefixed_Name(mus, "M161_Distribution_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M164_Multipart_Monograph_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M164 Multipart monograph statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M164_Multipart_Monograph_Statement">http://data.doremus.org/ontology#M164_Multipart_Monograph_Statement</seealso>
    let M164_Multipart_Monograph_Statement =
        Prefixed_Name(mus, "M164_Multipart_Monograph_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M167_Publication_Expression_Fragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M167 Fragment d'expression de publication</para><para>M167 Publication expression fragment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M167_Publication_Expression_Fragment">http://data.doremus.org/ontology#M167_Publication_Expression_Fragment</seealso>
    let M167_Publication_Expression_Fragment =
        Prefixed_Name(mus, "M167_Publication_Expression_Fragment") |> PrefixedName

    /// <summary>
    ///   <para>mus:M16_Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M16 Maintenance</para><para>M16 Maintenance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M16_Maintenance">http://data.doremus.org/ontology#M16_Maintenance</seealso>
    let M16_Maintenance = Prefixed_Name(mus, "M16_Maintenance") |> PrefixedName
    /// <summary>
    ///   <para>mus:M175_Music_Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M175 Format musical</para><para>M175 Music format</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M175_Music_Format">http://data.doremus.org/ontology#M175_Music_Format</seealso>
    let M175_Music_Format = Prefixed_Name(mus, "M175_Music_Format") |> PrefixedName

    /// <summary>
    ///   <para>mus:M187i_is_multipart_monograph_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U187i is multipart monograph statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M187i_is_multipart_monograph_statement_of">http://data.doremus.org/ontology#M187i_is_multipart_monograph_statement_of</seealso>
    let M187i_is_multipart_monograph_statement_of =
        Prefixed_Name(mus, "M187i_is_multipart_monograph_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U187_has_multipart_monographs_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U187 has multipart monograph statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U187_has_multipart_monographs_statement">http://data.doremus.org/ontology#U187_has_multipart_monographs_statement</seealso>
    let U187_has_multipart_monographs_statement =
        Prefixed_Name(mus, "U187_has_multipart_monographs_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M1_Catalogue_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Exemples :
    /// La cantate Ich habe genug de JS Bach [BWV 82] (F22) est identifiée par  (M1 Catalogue p3 has note E62 String) BWV 82
    /// La cantate Ich habe genug de JS Bach [BWV 82] (F22) est identifiée par  (M1 Catalogue p106 is composed of M10 Catalogue Name) BWV et (M1 Catalogue p106 is composed of Catalogue Number) 82.
    /// Komm, Gott Schöpfer, heiliger Geist. No 1 de JS Bach [BWV deest] (F22) est identifiée par (M1 Catalogue p3 has note E62 String) BWV deest.
    /// Duncan Gray [WoO 156, no 2] de Beethoven (F22) est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) WoO et (M1 Catalogue p106 is composed of Catalogue Number) 156, no 2.
    /// La Sonate pour Clavier en Ut majeur de Wilhelm Friedemann Bach identifiée BR A1 par le catalogue Bach Repertorium  et identifiée F200 par le catalogue Fasch (F22) : est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) BR et (M1 Catalogue p106 is composed of Catalogue Number) A1, et est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) F et (M1 Catalogue p106 is composed of Catalogue Number) 200.</para>
    ///   <para>Scope Note:
    /// Cette classe permet de décrire, lorsqu’elles existent, les références de catalogue de l’œuvre musicale. Par catalogue, on comprend tous les catalogues thématiques à proprement parler (donc à l’exclusion des numéros d’opus) ainsi que les classifications spécifiques telles que WoO ou Anh.
    /// Selon le niveau de granularité initial, elle est décrite par une simple chaîne de caractères, ou par les objets symboliques M10 Catalogue Name et M11 Catalogue Number qui la composent. La classe M10 Catalogue Name peut-être documentée via la propriété p70i is documented in.</para>
    /// labels<para>M1 Mention de catalogue</para><para>M1 Catalogue Statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M1_Catalogue_Statement">http://data.doremus.org/ontology#M1_Catalogue_Statement</seealso>
    let M1_Catalogue_Statement =
        Prefixed_Name(mus, "M1_Catalogue_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M22_Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M22 Forme</para><para>M22 Form</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M22_Form">http://data.doremus.org/ontology#M22_Form</seealso>
    let M22_Form = Prefixed_Name(mus, "M22_Form") |> PrefixedName

    /// <summary>
    ///   <para>mus:M58_Programming_Work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M58 Oeuvre de programmation</para><para>M58 Programming Work</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M58_Programming_Work">http://data.doremus.org/ontology#M58_Programming_Work</seealso>
    let M58_Programming_Work =
        Prefixed_Name(mus, "M58_Programming_Work") |> PrefixedName

    /// <summary>
    ///   <para>mus:U168_has_parallel_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U168 has parallel title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U168_has_parallel_title">http://data.doremus.org/ontology#U168_has_parallel_title</seealso>
    let U168_has_parallel_title =
        Prefixed_Name(mus, "U168_has_parallel_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:U168i_is_parallel_title_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U168i is parallel title of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U168i_is_parallel_title_of">http://data.doremus.org/ontology#U168i_is_parallel_title_of</seealso>
    let U168i_is_parallel_title_of =
        Prefixed_Name(mus, "U168i_is_parallel_title_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U184i_is_publication_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U184i is publication statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U184i_is_publication_statement_of">http://data.doremus.org/ontology#U184i_is_publication_statement_of</seealso>
    let U184i_is_publication_statement_of =
        Prefixed_Name(mus, "U184i_is_publication_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U185_has_distribution_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U185 has distribution statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U185_has_distribution_statement">http://data.doremus.org/ontology#U185_has_distribution_statement</seealso>
    let U185_has_distribution_statement =
        Prefixed_Name(mus, "U185_has_distribution_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U191_used_equalization_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U191 used equalization technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U191_used_equalization_technique">http://data.doremus.org/ontology#U191_used_equalization_technique</seealso>
    let U191_used_equalization_technique =
        Prefixed_Name(mus, "U191_used_equalization_technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:U191i_was_technique_of_equalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U191i was technique of equalization</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U191i_was_technique_of_equalization">http://data.doremus.org/ontology#U191i_was_technique_of_equalization</seealso>
    let U191i_was_technique_of_equalization =
        Prefixed_Name(mus, "U191i_was_technique_of_equalization") |> PrefixedName

    /// <summary>
    ///   <para>mus:U192_used_noise_reduction_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U192 used noise reduction technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U192_used_noise_reduction_technique">http://data.doremus.org/ontology#U192_used_noise_reduction_technique</seealso>
    let U192_used_noise_reduction_technique =
        Prefixed_Name(mus, "U192_used_noise_reduction_technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:U194_has_system_requirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U194 has system requirements</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U194_has_system_requirements">http://data.doremus.org/ontology#U194_has_system_requirements</seealso>
    let U194_has_system_requirements =
        Prefixed_Name(mus, "U194_has_system_requirements") |> PrefixedName

    /// <summary>
    ///   <para>mus:U195_has_order_or_location_indication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U195 has order or location indication</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U195_has_order_or_location_indication">http://data.doremus.org/ontology#U195_has_order_or_location_indication</seealso>
    let U195_has_order_or_location_indication =
        Prefixed_Name(mus, "U195_has_order_or_location_indication") |> PrefixedName

    /// <summary>
    ///   <para>mus:U4i_was_princeps_publication_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U4i was princeps publication of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U4i_was_princeps_publication_of">http://data.doremus.org/ontology#U4i_was_princeps_publication_of</seealso>
    let U4i_was_princeps_publication_of =
        Prefixed_Name(mus, "U4i_was_princeps_publication_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U50_has_annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U50 Has annotation</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U50_has_annotation">http://data.doremus.org/ontology#U50_has_annotation</seealso>
    let U50_has_annotation = Prefixed_Name(mus, "U50_has_annotation") |> PrefixedName

    /// <summary>
    ///   <para>mus:U51_is_partial_or_full_recording_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U51 is partial or full recording of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U51_is_partial_or_full_recording_of">http://data.doremus.org/ontology#U51_is_partial_or_full_recording_of</seealso>
    let U51_is_partial_or_full_recording_of =
        Prefixed_Name(mus, "U51_is_partial_or_full_recording_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U84_has_parallel_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see also http://en.wikipedia.org/wiki/Parallel_key</para>
    ///   <para>Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont en une relation parallèle, c'est-à-dire l'une est la parallèle majeur ou mineur de l'autre.</para>
    ///   <para>Scope Note: This class allows to connect two M4 Keys that are in a parallel relationship, i.e. one is the parallel major or minor of the other one.</para>
    ///   <para>Examples: the key of 'C major' has 'C minor' as parallel key</para>
    ///   <para>Exemples: la clé de 'Do majeur' a 'Do mineur' pour tonalité parallèle</para>
    /// labels<para>U84 a pour tonalité parallèle</para><para>U84 has parallel key</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U84_has_parallel_key">http://data.doremus.org/ontology#U84_has_parallel_key</seealso>
    let U84_has_parallel_key =
        Prefixed_Name(mus, "U84_has_parallel_key") |> PrefixedName

    /// <summary>
    ///   <para>mus:U85_has_closely_related_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>see also http://en.wikipedia.org/wiki/Closely_related_key</para>
    ///   <para>Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont étroitement liées d'un point de vue harmonique, par ex. ceux sont des destinations ou des transpositions fréquemment utilisées dans une modulation</para>
    ///   <para>Scope Note: This class allows to connect two M4 Keys that are mutually closely related from an harmonic point of view, e.g. they are commonly used destinations or transpositions in a modulation.</para>
    ///   <para>Exemples: la clé de 'Do majeur' a 'Sol majeur' et 'Re majeur' pour tonalités étroitement liées</para>
    ///   <para>Examples: the key of 'C major' has 'G major' and 'D minor' as closely related keys</para>
    /// labels<para>U85 a pour tonalité étroitement lié</para><para>U85 has closely related key</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U85_has_closely_related_key">http://data.doremus.org/ontology#U85_has_closely_related_key</seealso>
    let U85_has_closely_related_key =
        Prefixed_Name(mus, "U85_has_closely_related_key") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU197i_should_be_binding_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU197i should be binding of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU197i_should_be_binding_of">http://data.doremus.org/ontology#CLU197i_should_be_binding_of</seealso>
    let CLU197i_should_be_binding_of =
        Prefixed_Name(mus, "CLU197i_should_be_binding_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU207i_should_be_carrier_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU207i should be carrier type of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU207i_should_be_carrier_type_of">http://data.doremus.org/ontology#CLU207i_should_be_carrier_type_of</seealso>
    let CLU207i_should_be_carrier_type_of =
        Prefixed_Name(mus, "CLU207i_should_be_carrier_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:M10_Catalogue_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M10 Nom de catalogue</para><para>M10 Catalogue Name</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M10_Catalogue_Name">http://data.doremus.org/ontology#M10_Catalogue_Name</seealso>
    let M10_Catalogue_Name = Prefixed_Name(mus, "M10_Catalogue_Name") |> PrefixedName

    /// <summary>
    ///   <para>mus:M28_Individual_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M28 Performance individuelle</para><para>M28 Individual Performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M28_Individual_Performance">http://data.doremus.org/ontology#M28_Individual_Performance</seealso>
    let M28_Individual_Performance =
        Prefixed_Name(mus, "M28_Individual_Performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:M29_Editing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M29 Post-production</para><para>M29 Editing</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M29_Editing">http://data.doremus.org/ontology#M29_Editing</seealso>
    let M29_Editing = Prefixed_Name(mus, "M29_Editing") |> PrefixedName

    /// <summary>
    ///   <para>mus:M32_Actor_Responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M32 Responsabilité de l'agent</para><para>M32 Actor's Responsibility</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M32_Actor_Responsibility">http://data.doremus.org/ontology#M32_Actor_Responsibility</seealso>
    let M32_Actor_Responsibility =
        Prefixed_Name(mus, "M32_Actor_Responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:M35_Representative_Publication_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M35 Attribution d'Expression publicationnelle représentative</para><para>M35 Representative Publication Assignment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M35_Representative_Publication_Assignment">http://data.doremus.org/ontology#M35_Representative_Publication_Assignment</seealso>
    let M35_Representative_Publication_Assignment =
        Prefixed_Name(mus, "M35_Representative_Publication_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>mus:M39_Derivation_Type_Assignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M39 Attribution de type de dérivation</para><para>M39 Derivation Type Assignment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M39_Derivation_Type_Assignment">http://data.doremus.org/ontology#M39_Derivation_Type_Assignment</seealso>
    let M39_Derivation_Type_Assignment =
        Prefixed_Name(mus, "M39_Derivation_Type_Assignment") |> PrefixedName

    /// <summary>
    ///   <para>mus:M3_Order_Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M3 Numéro d'ordre</para><para>M3 Order Number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M3_Order_Number">http://data.doremus.org/ontology#M3_Order_Number</seealso>
    let M3_Order_Number = Prefixed_Name(mus, "M3_Order_Number") |> PrefixedName

    /// <summary>
    ///   <para>mus:M43_Performed_Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M43 Expression interprétée</para><para>M43 Performed Expression</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M43_Performed_Expression">http://data.doremus.org/ontology#M43_Performed_Expression</seealso>
    let M43_Performed_Expression =
        Prefixed_Name(mus, "M43_Performed_Expression") |> PrefixedName

    /// <summary>
    ///   <para>mus:U11i_is_key_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U11i is key of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U11i_is_key_of">http://data.doremus.org/ontology#U11i_is_key_of</seealso>
    let U11i_is_key_of = Prefixed_Name(mus, "U11i_is_key_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U12_has_genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U12 has genre</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U12_has_genre">http://data.doremus.org/ontology#U12_has_genre</seealso>
    let U12_has_genre = Prefixed_Name(mus, "U12_has_genre") |> PrefixedName

    /// <summary>
    ///   <para>mus:U179i_is_parallel_statement_of_responsibility_relating_to_edition_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U179i is parallel statement of responsibility relating to edition of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U179i_is_parallel_statement_of_responsibility_relating_to_edition_of">http://data.doremus.org/ontology#U179i_is_parallel_statement_of_responsibility_relating_to_edition_of</seealso>
    let U179i_is_parallel_statement_of_responsibility_relating_to_edition_of =
        Prefixed_Name(mus, "U179i_is_parallel_statement_of_responsibility_relating_to_edition_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U17_has_opus_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U17 has opus statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U17_has_opus_statement">http://data.doremus.org/ontology#U17_has_opus_statement</seealso>
    let U17_has_opus_statement =
        Prefixed_Name(mus, "U17_has_opus_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U180i_is_additional_edition_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U180i is additional edition statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U180i_is_additional_edition_statement_of">http://data.doremus.org/ontology#U180i_is_additional_edition_statement_of</seealso>
    let U180i_is_additional_edition_statement_of =
        Prefixed_Name(mus, "U180i_is_additional_edition_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U181_has_parallel_additional_edition_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U181 has parallel additional edition statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U181_has_parallel_additional_edition_statement">http://data.doremus.org/ontology#U181_has_parallel_additional_edition_statement</seealso>
    let U181_has_parallel_additional_edition_statement =
        Prefixed_Name(mus, "U181_has_parallel_additional_edition_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U182i_is_music_format_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U182i is music format statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U182i_is_music_format_statement_of">http://data.doremus.org/ontology#U182i_is_music_format_statement_of</seealso>
    let U182i_is_music_format_statement_of =
        Prefixed_Name(mus, "U182i_is_music_format_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U183_has_parallel_music_format_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U183 has parallel music format statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U183_has_parallel_music_format_statement">http://data.doremus.org/ontology#U183_has_parallel_music_format_statement</seealso>
    let U183_has_parallel_music_format_statement =
        Prefixed_Name(mus, "U183_has_parallel_music_format_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U214_has_colour_content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U214 has colour content</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U214_has_colour_content">http://data.doremus.org/ontology#U214_has_colour_content</seealso>
    let U214_has_colour_content =
        Prefixed_Name(mus, "U214_has_colour_content") |> PrefixedName

    /// <summary>
    ///   <para>mus:U215_has_groove_caracteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U215  has groove caracteristics</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U215_has_groove_caracteristics">http://data.doremus.org/ontology#U215_has_groove_caracteristics</seealso>
    let U215_has_groove_caracteristics =
        Prefixed_Name(mus, "U215_has_groove_caracteristics") |> PrefixedName

    /// <summary>
    ///   <para>mus:U218_used_object_of_type_for_mastering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U218 used object of type for mastering</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U218_used_object_of_type_for_mastering">http://data.doremus.org/ontology#U218_used_object_of_type_for_mastering</seealso>
    let U218_used_object_of_type_for_mastering =
        Prefixed_Name(mus, "U218_used_object_of_type_for_mastering") |> PrefixedName

    /// <summary>
    ///   <para>mus:U219_used_object_of_type_for_mixing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U219 used object of type for mixing</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U219_used_object_of_type_for_mixing">http://data.doremus.org/ontology#U219_used_object_of_type_for_mixing</seealso>
    let U219_used_object_of_type_for_mixing =
        Prefixed_Name(mus, "U219_used_object_of_type_for_mixing") |> PrefixedName

    /// <summary>
    ///   <para>mus:U21i_actor_is_subject_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U21i actor is subject of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U21i_actor_is_subject_of">http://data.doremus.org/ontology#U21i_actor_is_subject_of</seealso>
    let U21i_actor_is_subject_of =
        Prefixed_Name(mus, "U21i_actor_is_subject_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U220_has_title_and_statement_of_responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U220 has title and statement of responsibility</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U220_has_title_and_statement_of_responsibility">http://data.doremus.org/ontology#U220_has_title_and_statement_of_responsibility</seealso>
    let U220_has_title_and_statement_of_responsibility =
        Prefixed_Name(mus, "U220_has_title_and_statement_of_responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:U222_has_title_proper_of_sub-series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U222 has title proper of sub-series</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U222_has_title_proper_of_sub-series">http://data.doremus.org/ontology#U222_has_title_proper_of_sub-series</seealso>
    let U222_has_title_proper_of_sub_series =
        Prefixed_Name(mus, "U222_has_title_proper_of_sub-series") |> PrefixedName

    /// <summary>
    ///   <para>mus:U222i_is_title_proper_of_sub-series_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U222i is title proper of sub-series of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U222i_is_title_proper_of_sub-series_of">http://data.doremus.org/ontology#U222i_is_title_proper_of_sub-series_of</seealso>
    let U222i_is_title_proper_of_sub_series_of =
        Prefixed_Name(mus, "U222i_is_title_proper_of_sub-series_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U224i_is_title_proper_of_multipart_monograph_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U224i is title proper of multipart monograph of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U224i_is_title_proper_of_multipart_monograph_of">http://data.doremus.org/ontology#U224i_is_title_proper_of_multipart_monograph_of</seealso>
    let U224i_is_title_proper_of_multipart_monograph_of =
        Prefixed_Name(mus, "U224i_is_title_proper_of_multipart_monograph_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U225_used_sound_spatialization_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U225 used number of sound channels</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U225_used_sound_spatialization_technique">http://data.doremus.org/ontology#U225_used_sound_spatialization_technique</seealso>
    let U225_used_sound_spatialization_technique =
        Prefixed_Name(mus, "U225_used_sound_spatialization_technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:U225i_was_sound_spatialization_technique_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U225i was sound spatialization technique of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U225i_was_sound_spatialization_technique_of">http://data.doremus.org/ontology#U225i_was_sound_spatialization_technique_of</seealso>
    let U225i_was_sound_spatialization_technique_of =
        Prefixed_Name(mus, "U225i_was_sound_spatialization_technique_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U226_has_responsibility_detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U226 has responsibility detail</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U226_has_responsibility_detail">http://data.doremus.org/ontology#U226_has_responsibility_detail</seealso>
    let U226_has_responsibility_detail =
        Prefixed_Name(mus, "U226_has_responsibility_detail") |> PrefixedName

    /// <summary>
    ///   <para>mus:U229_has_music_format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U229 has music format</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U229_has_music_format">http://data.doremus.org/ontology#U229_has_music_format</seealso>
    let U229_has_music_format =
        Prefixed_Name(mus, "U229_has_music_format") |> PrefixedName

    /// <summary>
    ///   <para>mus:U229i_is_music_format_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.doremus.org/ontology#U229i_is_music_format_of">http://data.doremus.org/ontology#U229i_is_music_format_of</seealso>
    let U229i_is_music_format_of =
        Prefixed_Name(mus, "U229i_is_music_format_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U22_is_about_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U22 is about place</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U22_is_about_place">http://data.doremus.org/ontology#U22_is_about_place</seealso>
    let U22_is_about_place = Prefixed_Name(mus, "U22_is_about_place") |> PrefixedName

    /// <summary>
    ///   <para>mus:U22i_place_is_subject_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U22i place is subject of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U22i_place_is_subject_of">http://data.doremus.org/ontology#U22i_place_is_subject_of</seealso>
    let U22i_place_is_subject_of =
        Prefixed_Name(mus, "U22i_place_is_subject_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U23i_is_casting_detail_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U23i is casting detail of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U23i_is_casting_detail_of">http://data.doremus.org/ontology#U23i_is_casting_detail_of</seealso>
    let U23i_is_casting_detail_of =
        Prefixed_Name(mus, "U23i_is_casting_detail_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U24_has_award</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U24 has award</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U24_has_award">http://data.doremus.org/ontology#U24_has_award</seealso>
    let U24_has_award = Prefixed_Name(mus, "U24_has_award") |> PrefixedName
    /// <summary>
    ///   <para>mus:U24i_is_award_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U24i is award of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U24i_is_award_of">http://data.doremus.org/ontology#U24i_is_award_of</seealso>
    let U24i_is_award_of = Prefixed_Name(mus, "U24i_is_award_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U26_has_maintained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U26 has maintained</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U26_has_maintained">http://data.doremus.org/ontology#U26_has_maintained</seealso>
    let U26_has_maintained = Prefixed_Name(mus, "U26_has_maintained") |> PrefixedName

    /// <summary>
    ///   <para>mus:U26i_was_maintained_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U26i was maintained by</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U26i_was_maintained_by">http://data.doremus.org/ontology#U26i_was_maintained_by</seealso>
    let U26i_was_maintained_by =
        Prefixed_Name(mus, "U26i_was_maintained_by") |> PrefixedName

    /// <summary>
    ///   <para>mus:U27_performed_character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U27 performed character</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U27_performed_character">http://data.doremus.org/ontology#U27_performed_character</seealso>
    let U27_performed_character =
        Prefixed_Name(mus, "U27_performed_character") |> PrefixedName

    /// <summary>
    ///   <para>mus:U28i_is_ambitus_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U28i is ambitus of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U28i_is_ambitus_of">http://data.doremus.org/ontology#U28i_is_ambitus_of</seealso>
    let U28i_is_ambitus_of = Prefixed_Name(mus, "U28i_is_ambitus_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U29_edited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U29 edited</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U29_edited">http://data.doremus.org/ontology#U29_edited</seealso>
    let U29_edited = Prefixed_Name(mus, "U29_edited") |> PrefixedName
    /// <summary>
    ///   <para>mus:U29i_was_edited_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U29i was edited by</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U29i_was_edited_by">http://data.doremus.org/ontology#U29i_was_edited_by</seealso>
    let U29i_was_edited_by = Prefixed_Name(mus, "U29i_was_edited_by") |> PrefixedName

    /// <summary>
    ///   <para>mus:U2_foresees_use_of_medium_of_performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U2 instrument ou voix prévu pour la performance</para><para>U2 foresees use of medium of performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U2_foresees_use_of_medium_of_performance">http://data.doremus.org/ontology#U2_foresees_use_of_medium_of_performance</seealso>
    let U2_foresees_use_of_medium_of_performance =
        Prefixed_Name(mus, "U2_foresees_use_of_medium_of_performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:U31i_was_function_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U31i was function of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U31i_was_function_of">http://data.doremus.org/ontology#U31i_was_function_of</seealso>
    let U31i_was_function_of =
        Prefixed_Name(mus, "U31i_was_function_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U32_had_responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U32 had responsibility</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U32_had_responsibility">http://data.doremus.org/ontology#U32_had_responsibility</seealso>
    let U32_had_responsibility =
        Prefixed_Name(mus, "U32_had_responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:U32i_was_responsibility_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U32i was responsibility of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U32i_was_responsibility_of">http://data.doremus.org/ontology#U32i_was_responsibility_of</seealso>
    let U32i_was_responsibility_of =
        Prefixed_Name(mus, "U32i_was_responsibility_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U61i_was_geographical_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U61i was geographical context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U61i_was_geographical_context_of">http://data.doremus.org/ontology#U61i_was_geographical_context_of</seealso>
    let U61i_was_geographical_context_of =
        Prefixed_Name(mus, "U61i_was_geographical_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U62_has_form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U62 has form</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U62_has_form">http://data.doremus.org/ontology#U62_has_form</seealso>
    let U62_has_form = Prefixed_Name(mus, "U62_has_form") |> PrefixedName
    /// <summary>
    ///   <para>mus:U62i_is_form_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U62i is form of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U62i_is_form_of">http://data.doremus.org/ontology#U62i_is_form_of</seealso>
    let U62i_is_form_of = Prefixed_Name(mus, "U62i_is_form_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U63_has_religious_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U63 has religious context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U63_has_religious_context">http://data.doremus.org/ontology#U63_has_religious_context</seealso>
    let U63_has_religious_context =
        Prefixed_Name(mus, "U63_has_religious_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U91_put_into_effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U91 put into effect</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U91_put_into_effect">http://data.doremus.org/ontology#U91_put_into_effect</seealso>
    let U91_put_into_effect = Prefixed_Name(mus, "U91_put_into_effect") |> PrefixedName

    /// <summary>
    ///   <para>mus:U91i_was_put_into_effect_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U91i was put into effect through</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U91i_was_put_into_effect_through">http://data.doremus.org/ontology#U91i_was_put_into_effect_through</seealso>
    let U91i_was_put_into_effect_through =
        Prefixed_Name(mus, "U91i_was_put_into_effect_through") |> PrefixedName

    /// <summary>
    ///   <para>mus:U92_foresees_to_put_into_effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U92 foresees to put into effect</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U92_foresees_to_put_into_effect">http://data.doremus.org/ontology#U92_foresees_to_put_into_effect</seealso>
    let U92_foresees_to_put_into_effect =
        Prefixed_Name(mus, "U92_foresees_to_put_into_effect") |> PrefixedName

    /// <summary>
    ///   <para>mus:U94i_is_work_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U94i is work type of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U94i_is_work_type_of">http://data.doremus.org/ontology#U94i_is_work_type_of</seealso>
    let U94i_is_work_type_of =
        Prefixed_Name(mus, "U94i_is_work_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U95_has_hierarchical_level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U95 has hierarchical level</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U95_has_hierarchical_level">http://data.doremus.org/ontology#U95_has_hierarchical_level</seealso>
    let U95_has_hierarchical_level =
        Prefixed_Name(mus, "U95_has_hierarchical_level") |> PrefixedName

    /// <summary>
    ///   <para>mus:U95i_is_hierarchical_level_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U95 is hierarchical leval of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U95i_is_hierarchical_level_of">http://data.doremus.org/ontology#U95i_is_hierarchical_level_of</seealso>
    let U95i_is_hierarchical_level_of =
        Prefixed_Name(mus, "U95i_is_hierarchical_level_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U96_foresees_vocal_or_instrumental_technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U96 foresees vocal or instrumental technique</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U96_foresees_vocal_or_instrumental_technique">http://data.doremus.org/ontology#U96_foresees_vocal_or_instrumental_technique</seealso>
    let U96_foresees_vocal_or_instrumental_technique =
        Prefixed_Name(mus, "U96_foresees_vocal_or_instrumental_technique") |> PrefixedName

    /// <summary>
    ///   <para>mus:U96i_is_foreseen_vocal_or_instrumental_technique_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U96i is foreseen vocal or instrumental technique of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U96i_is_foreseen_vocal_or_instrumental_technique_of">http://data.doremus.org/ontology#U96i_is_foreseen_vocal_or_instrumental_technique_of</seealso>
    let U96i_is_foreseen_vocal_or_instrumental_technique_of =
        Prefixed_Name(mus, "U96i_is_foreseen_vocal_or_instrumental_technique_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U9_has_quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U9 has quantity</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U9_has_quantity">http://data.doremus.org/ontology#U9_has_quantity</seealso>
    let U9_has_quantity = Prefixed_Name(mus, "U9_has_quantity") |> PrefixedName

    /// <summary>
    ///   <para>mus:M21_Harmonic_Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M21 Structure Harmonique</para><para>M21 Harmonic Structure</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M21_Harmonic_Structure">http://data.doremus.org/ontology#M21_Harmonic_Structure</seealso>
    let M21_Harmonic_Structure =
        Prefixed_Name(mus, "M21_Harmonic_Structure") |> PrefixedName

    /// <summary>
    ///   <para>mus:M46_Set_of_Tracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scope Note : ensemble des pistes constituant un enregistrement publié.</para>
    /// labels<para>M46 Ensemble de Pistes</para><para>M46 Set of Tracks</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M46_Set_of_Tracks">http://data.doremus.org/ontology#M46_Set_of_Tracks</seealso>
    let M46_Set_of_Tracks = Prefixed_Name(mus, "M46_Set_of_Tracks") |> PrefixedName
    /// <summary>
    ///   <para>mus:M31_Actor_Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M31 Fonction de l'agent</para><para>M31 Actor's Function</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M31_Actor_Function">http://data.doremus.org/ontology#M31_Actor_Function</seealso>
    let M31_Actor_Function = Prefixed_Name(mus, "M31_Actor_Function") |> PrefixedName

    /// <summary>
    ///   <para>mus:M7_Linguistic_Appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scope note:
    /// Cette classe permet de décrire une appellation et ses composantes linguistiques. Elle comprend donc les appellations originales et les traductions de ces appellations.</para>
    /// labels<para>M7 Appellation linguistique</para><para>M7 Linguistic Appellation</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M7_Linguistic_Appellation">http://data.doremus.org/ontology#M7_Linguistic_Appellation</seealso>
    let M7_Linguistic_Appellation =
        Prefixed_Name(mus, "M7_Linguistic_Appellation") |> PrefixedName

    /// <summary>
    ///   <para>mus:U176i_is_edition_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U176i is edition statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U176i_is_edition_statement_of">http://data.doremus.org/ontology#U176i_is_edition_statement_of</seealso>
    let U176i_is_edition_statement_of =
        Prefixed_Name(mus, "U176i_is_edition_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U177_has_parallel_edition_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U177 has parallel edition statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U177_has_parallel_edition_statement">http://data.doremus.org/ontology#U177_has_parallel_edition_statement</seealso>
    let U177_has_parallel_edition_statement =
        Prefixed_Name(mus, "U177_has_parallel_edition_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U178_has_statement_of_responsibility_relating_to_edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U178 has statement of responsibility relating to edition</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U178_has_statement_of_responsibility_relating_to_edition">http://data.doremus.org/ontology#U178_has_statement_of_responsibility_relating_to_edition</seealso>
    let U178_has_statement_of_responsibility_relating_to_edition =
        Prefixed_Name(mus, "U178_has_statement_of_responsibility_relating_to_edition") |> PrefixedName

    /// <summary>
    ///   <para>mus:U179_has_parallel_statement_of_responsibility_relating_to_edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U179 has parallel statement of responsibility relating to edition</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U179_has_parallel_statement_of_responsibility_relating_to_edition">http://data.doremus.org/ontology#U179_has_parallel_statement_of_responsibility_relating_to_edition</seealso>
    let U179_has_parallel_statement_of_responsibility_relating_to_edition =
        Prefixed_Name(mus, "U179_has_parallel_statement_of_responsibility_relating_to_edition") |> PrefixedName

    /// <summary>
    ///   <para>mus:U17i_is_opus_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U17i is opus statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U17i_is_opus_statement_of">http://data.doremus.org/ontology#U17i_is_opus_statement_of</seealso>
    let U17i_is_opus_statement_of =
        Prefixed_Name(mus, "U17i_is_opus_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U180_has_additional_edition_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U180 has additional edition statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U180_has_additional_edition_statement">http://data.doremus.org/ontology#U180_has_additional_edition_statement</seealso>
    let U180_has_additional_edition_statement =
        Prefixed_Name(mus, "U180_has_additional_edition_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U181i_is_parallel_additional_edition_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U181i is parallel additional edition statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U181i_is_parallel_additional_edition_statement_of">http://data.doremus.org/ontology#U181i_is_parallel_additional_edition_statement_of</seealso>
    let U181i_is_parallel_additional_edition_statement_of =
        Prefixed_Name(mus, "U181i_is_parallel_additional_edition_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U182_has_music_format_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U182 has music format statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U182_has_music_format_statement">http://data.doremus.org/ontology#U182_has_music_format_statement</seealso>
    let U182_has_music_format_statement =
        Prefixed_Name(mus, "U182_has_music_format_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U183i_is_parallel_music_format_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U183i is parallel music format statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U183i_is_parallel_music_format_statement_of">http://data.doremus.org/ontology#U183i_is_parallel_music_format_statement_of</seealso>
    let U183i_is_parallel_music_format_statement_of =
        Prefixed_Name(mus, "U183i_is_parallel_music_format_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U184_has_publication_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U184 has publication statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U184_has_publication_statement">http://data.doremus.org/ontology#U184_has_publication_statement</seealso>
    let U184_has_publication_statement =
        Prefixed_Name(mus, "U184_has_publication_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U185i_is_distribution_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U185i is distribution statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U185i_is_distribution_statement_of">http://data.doremus.org/ontology#U185i_is_distribution_statement_of</seealso>
    let U185i_is_distribution_statement_of =
        Prefixed_Name(mus, "U185i_is_distribution_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U186_has_printing_or_manufacture_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U186 has printing or manufacture statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U186_has_printing_or_manufacture_statement">http://data.doremus.org/ontology#U186_has_printing_or_manufacture_statement</seealso>
    let U186_has_printing_or_manufacture_statement =
        Prefixed_Name(mus, "U186_has_printing_or_manufacture_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U188_has_series_statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U188 has series statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U188_has_series_statement">http://data.doremus.org/ontology#U188_has_series_statement</seealso>
    let U188_has_series_statement =
        Prefixed_Name(mus, "U188_has_series_statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:U18_has_rhythmic_pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U18 has rhythmic pattern</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U18_has_rhythmic_pattern">http://data.doremus.org/ontology#U18_has_rhythmic_pattern</seealso>
    let U18_has_rhythmic_pattern =
        Prefixed_Name(mus, "U18_has_rhythmic_pattern") |> PrefixedName

    /// <summary>
    ///   <para>mus:U18i_is_rhythmic_pattern_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U18i is rhythmic pattern of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U18i_is_rhythmic_pattern_of">http://data.doremus.org/ontology#U18i_is_rhythmic_pattern_of</seealso>
    let U18i_is_rhythmic_pattern_of =
        Prefixed_Name(mus, "U18i_is_rhythmic_pattern_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U192i_was_technique_of_noise_reduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U192i was technique of noise reduction</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U192i_was_technique_of_noise_reduction">http://data.doremus.org/ontology#U192i_was_technique_of_noise_reduction</seealso>
    let U192i_was_technique_of_noise_reduction =
        Prefixed_Name(mus, "U192i_was_technique_of_noise_reduction") |> PrefixedName

    /// <summary>
    ///   <para>mus:U193_used_historical_instruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U193 used historical instruments</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U193_used_historical_instruments">http://data.doremus.org/ontology#U193_used_historical_instruments</seealso>
    let U193_used_historical_instruments =
        Prefixed_Name(mus, "U193_used_historical_instruments") |> PrefixedName

    /// <summary>
    ///   <para>mus:U197_has_binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U197 has binding</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U197_has_binding">http://data.doremus.org/ontology#U197_has_binding</seealso>
    let U197_has_binding = Prefixed_Name(mus, "U197_has_binding") |> PrefixedName
    /// <summary>
    ///   <para>mus:U197i_is_binding_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U197i is binding of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U197i_is_binding_of">http://data.doremus.org/ontology#U197i_is_binding_of</seealso>
    let U197i_is_binding_of = Prefixed_Name(mus, "U197i_is_binding_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U27i_character_was_performed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U27i character was performed by</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U27i_character_was_performed_by">http://data.doremus.org/ontology#U27i_character_was_performed_by</seealso>
    let U27i_character_was_performed_by =
        Prefixed_Name(mus, "U27i_character_was_performed_by") |> PrefixedName

    /// <summary>
    ///   <para>mus:U28_has_ambitus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>scope note: this property allows for describing the tessitura of a character, as can be drawn from the score.</para>
    /// labels<para>U28 has ambitus</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U28_has_ambitus">http://data.doremus.org/ontology#U28_has_ambitus</seealso>
    let U28_has_ambitus = Prefixed_Name(mus, "U28_has_ambitus") |> PrefixedName

    /// <summary>
    ///   <para>mus:U2i_is_foreseen_type_of_medium_of_performance_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U2i est le type d'instrument ou de voix prévu pour</para><para>U2i is foreseen type of medium of performance in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U2i_is_foreseen_type_of_medium_of_performance_in">http://data.doremus.org/ontology#U2i_is_foreseen_type_of_medium_of_performance_in</seealso>
    let U2i_is_foreseen_type_of_medium_of_performance_in =
        Prefixed_Name(mus, "U2i_is_foreseen_type_of_medium_of_performance_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U30_foresees_quantity_of_mop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U30 foresees quantity of medium of performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U30_foresees_quantity_of_mop">http://data.doremus.org/ontology#U30_foresees_quantity_of_mop</seealso>
    let U30_foresees_quantity_of_mop =
        Prefixed_Name(mus, "U30_foresees_quantity_of_mop") |> PrefixedName

    /// <summary>
    ///   <para>mus:U31_had_function</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U31 had function</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U31_had_function">http://data.doremus.org/ontology#U31_had_function</seealso>
    let U31_had_function = Prefixed_Name(mus, "U31_had_function") |> PrefixedName
    /// <summary>
    ///   <para>mus:U5i_was_premiere_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U5i was premiere of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U5i_was_premiere_of">http://data.doremus.org/ontology#U5i_was_premiere_of</seealso>
    let U5i_was_premiere_of = Prefixed_Name(mus, "U5i_was_premiere_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U60_occurred_in_cultural_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U60 occurred in cultural context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U60_occurred_in_cultural_context">http://data.doremus.org/ontology#U60_occurred_in_cultural_context</seealso>
    let U60_occurred_in_cultural_context =
        Prefixed_Name(mus, "U60_occurred_in_cultural_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U60i_was_cultural_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U60i was cultural context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U60i_was_cultural_context_of">http://data.doremus.org/ontology#U60i_was_cultural_context_of</seealso>
    let U60i_was_cultural_context_of =
        Prefixed_Name(mus, "U60i_was_cultural_context_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U61_occurred_in_geographical_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U61 occurred in geographical context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U61_occurred_in_geographical_context">http://data.doremus.org/ontology#U61_occurred_in_geographical_context</seealso>
    let U61_occurred_in_geographical_context =
        Prefixed_Name(mus, "U61_occurred_in_geographical_context") |> PrefixedName

    /// <summary>
    ///   <para>mus:U8_foresees_time_span</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U8 foresees time-span</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U8_foresees_time_span">http://data.doremus.org/ontology#U8_foresees_time_span</seealso>
    let U8_foresees_time_span =
        Prefixed_Name(mus, "U8_foresees_time_span") |> PrefixedName

    /// <summary>
    ///   <para>mus:U8i_is_foreseen_time_span_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U8i is foreseen time-span of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U8i_is_foreseen_time_span_of">http://data.doremus.org/ontology#U8i_is_foreseen_time_span_of</seealso>
    let U8i_is_foreseen_time_span_of =
        Prefixed_Name(mus, "U8i_is_foreseen_time_span_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U90_foresees_creation_or_performance_mode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U90 foresees creation or performance mode</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U90_foresees_creation_or_performance_mode">http://data.doremus.org/ontology#U90_foresees_creation_or_performance_mode</seealso>
    let U90_foresees_creation_or_performance_mode =
        Prefixed_Name(mus, "U90_foresees_creation_or_performance_mode") |> PrefixedName

    /// <summary>
    ///   <para>mus:M166_Title_Proper_of_Multipart_Monograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M166 Titre propre de monographie multipartie</para><para>M166 Title proper of multipart monograph</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M166_Title_Proper_of_Multipart_Monograph">http://data.doremus.org/ontology#M166_Title_Proper_of_Multipart_Monograph</seealso>
    let M166_Title_Proper_of_Multipart_Monograph =
        Prefixed_Name(mus, "M166_Title_Proper_of_Multipart_Monograph") |> PrefixedName

    /// <summary>
    ///   <para>mus:M49_Performer_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M49 Statut de l'interprète</para><para>M49 Performer status</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M49_Performer_Status">http://data.doremus.org/ontology#M49_Performer_Status</seealso>
    let M49_Performer_Status =
        Prefixed_Name(mus, "M49_Performer_Status") |> PrefixedName

    /// <summary>
    ///   <para>mus:U177i_is_parallel_edition_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U177i is parallel edition statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U177i_is_parallel_edition_statement_of">http://data.doremus.org/ontology#U177i_is_parallel_edition_statement_of</seealso>
    let U177i_is_parallel_edition_statement_of =
        Prefixed_Name(mus, "U177i_is_parallel_edition_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U178i_is_statement_of_responsibility_relating_to_edition_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U178i is statement of responsibility relating to edition of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U178i_is_statement_of_responsibility_relating_to_edition_of">http://data.doremus.org/ontology#U178i_is_statement_of_responsibility_relating_to_edition_of</seealso>
    let U178i_is_statement_of_responsibility_relating_to_edition_of =
        Prefixed_Name(mus, "U178i_is_statement_of_responsibility_relating_to_edition_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U207_has_carrier_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U207 has  carrier type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U207_has_carrier_type">http://data.doremus.org/ontology#U207_has_carrier_type</seealso>
    let U207_has_carrier_type =
        Prefixed_Name(mus, "U207_has_carrier_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:U208_has_extent_of_carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U208 has extent of carrier</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U208_has_extent_of_carrier">http://data.doremus.org/ontology#U208_has_extent_of_carrier</seealso>
    let U208_has_extent_of_carrier =
        Prefixed_Name(mus, "U208_has_extent_of_carrier") |> PrefixedName

    /// <summary>
    ///   <para>mus:U20i_is_music_group_formation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U20i is music group formation of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U20i_is_music_group_formation_of">http://data.doremus.org/ontology#U20i_is_music_group_formation_of</seealso>
    let U20i_is_music_group_formation_of =
        Prefixed_Name(mus, "U20i_is_music_group_formation_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U211_has_composition_of_material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U211 has composition of material</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U211_has_composition_of_material">http://data.doremus.org/ontology#U211_has_composition_of_material</seealso>
    let U211_has_composition_of_material =
        Prefixed_Name(mus, "U211_has_composition_of_material") |> PrefixedName

    /// <summary>
    ///   <para>mus:U3_foresees_use_of_specific_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U3 utilisation prévue de l'objet spécifique</para><para>U3 forees use of specific object</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U3_foresees_use_of_specific_object">http://data.doremus.org/ontology#U3_foresees_use_of_specific_object</seealso>
    let U3_foresees_use_of_specific_object =
        Prefixed_Name(mus, "U3_foresees_use_of_specific_object") |> PrefixedName

    /// <summary>
    ///   <para>mus:U3i_is_foreseen_specific_object_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U3i is foreseen specific medium of performance in</para><para>U3i est le type d'objet spécifique prévu pour</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U3i_is_foreseen_specific_object_in">http://data.doremus.org/ontology#U3i_is_foreseen_specific_object_in</seealso>
    let U3i_is_foreseen_specific_object_in =
        Prefixed_Name(mus, "U3i_is_foreseen_specific_object_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U40_has_catalogue_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U40 has catalogue name</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U40_has_catalogue_name">http://data.doremus.org/ontology#U40_has_catalogue_name</seealso>
    let U40_has_catalogue_name =
        Prefixed_Name(mus, "U40_has_catalogue_name") |> PrefixedName

    /// <summary>
    ///   <para>mus:U40i_is_catalogue_name_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U40i is catalogue name of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U40i_is_catalogue_name_of">http://data.doremus.org/ontology#U40i_is_catalogue_name_of</seealso>
    let U40i_is_catalogue_name_of =
        Prefixed_Name(mus, "U40i_is_catalogue_name_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U41_has_catalogue_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U41 has catalogue number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U41_has_catalogue_number">http://data.doremus.org/ontology#U41_has_catalogue_number</seealso>
    let U41_has_catalogue_number =
        Prefixed_Name(mus, "U41_has_catalogue_number") |> PrefixedName

    /// <summary>
    ///   <para>mus:U73_is_derivative_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U73 is derivative of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U73_is_derivative_of">http://data.doremus.org/ontology#U73_is_derivative_of</seealso>
    let U73_is_derivative_of =
        Prefixed_Name(mus, "U73_is_derivative_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U73i_has_derivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U73i has derivative</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U73i_has_derivative">http://data.doremus.org/ontology#U73i_has_derivative</seealso>
    let U73i_has_derivative = Prefixed_Name(mus, "U73i_has_derivative") |> PrefixedName

    /// <summary>
    ///   <para>mus:U76_has_WoO_subnumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U76 has WoO subnumber</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U76_has_WoO_subnumber">http://data.doremus.org/ontology#U76_has_WoO_subnumber</seealso>
    let U76_has_WoO_subnumber =
        Prefixed_Name(mus, "U76_has_WoO_subnumber") |> PrefixedName

    /// <summary>
    ///   <para>mus:U77_foresees_performing_plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U77 foresees performing plan</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U77_foresees_performing_plan">http://data.doremus.org/ontology#U77_foresees_performing_plan</seealso>
    let U77_foresees_performing_plan =
        Prefixed_Name(mus, "U77_foresees_performing_plan") |> PrefixedName

    /// <summary>
    ///   <para>mus:U7_foresees_place_at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U7 foresees place at</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U7_foresees_place_at">http://data.doremus.org/ontology#U7_foresees_place_at</seealso>
    let U7_foresees_place_at =
        Prefixed_Name(mus, "U7_foresees_place_at") |> PrefixedName

    /// <summary>
    ///   <para>mus:U7i_is_foreseen_place_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U7i is foreseen place of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U7i_is_foreseen_place_of">http://data.doremus.org/ontology#U7i_is_foreseen_place_of</seealso>
    let U7i_is_foreseen_place_of =
        Prefixed_Name(mus, "U7i_is_foreseen_place_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U81_had_performer_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U81 had performer status</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U81_had_performer_status">http://data.doremus.org/ontology#U81_had_performer_status</seealso>
    let U81_had_performer_status =
        Prefixed_Name(mus, "U81_had_performer_status") |> PrefixedName

    /// <summary>
    ///   <para>mus:U81i_is_performer_status_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U81i is performer status of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U81i_is_performer_status_of">http://data.doremus.org/ontology#U81i_is_performer_status_of</seealso>
    let U81i_is_performer_status_of =
        Prefixed_Name(mus, "U81i_is_performer_status_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U82i_is_foreseen_performer_status_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U82i is foreseen performer status of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U82i_is_foreseen_performer_status_of">http://data.doremus.org/ontology#U82i_is_foreseen_performer_status_of</seealso>
    let U82i_is_foreseen_performer_status_of =
        Prefixed_Name(mus, "U82i_is_foreseen_performer_status_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U83_has_relative_key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont en relation par rapport à l'armure, c'est-à-dire l'une est la relatif majeur ou mineur de l'autre.</para>
    ///   <para>see also http://en.wikipedia.org/wiki/Relative_key</para>
    ///   <para>Exemples: la clé de 'Do majeur' a 'La mineur' pour tonalité relative</para>
    ///   <para>Scope Note: This class allows to connect two M4 Keys that are in a relative relationship, i.e. one is the relative major or minor of the other one.</para>
    ///   <para>Examples: the key of 'C major' has 'A minor' as relative key</para>
    /// labels<para>U83 a pour tonalité relative</para><para>U83 has relative key</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U83_has_relative_key">http://data.doremus.org/ontology#U83_has_relative_key</seealso>
    let U83_has_relative_key =
        Prefixed_Name(mus, "U83_has_relative_key") |> PrefixedName

    /// <summary>
    ///   <para>mus:U87_has_member_casting_detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>U87 has member casting detail</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U87_has_member_casting_detail">http://data.doremus.org/ontology#U87_has_member_casting_detail</seealso>
    let U87_has_member_casting_detail =
        Prefixed_Name(mus, "U87_has_member_casting_detail") |> PrefixedName

    /// <summary>
    ///   <para>mus:U87i_is_member_casting_detail_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U87i is member casting detail of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U87i_is_member_casting_detail_of">http://data.doremus.org/ontology#U87i_is_member_casting_detail_of</seealso>
    let U87i_is_member_casting_detail_of =
        Prefixed_Name(mus, "U87i_is_member_casting_detail_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U88_has_medium_of_performance_section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>U88 has medium of performance section</para>
    /// </remarks>
    /// <seealso href="http://data.doremus.org/ontology#U88_has_medium_of_performance_section">http://data.doremus.org/ontology#U88_has_medium_of_performance_section</seealso>
    let U88_has_medium_of_performance_section =
        Prefixed_Name(mus, "U88_has_medium_of_performance_section") |> PrefixedName

    /// <summary>
    ///   <para>mus:U88i_is_member_of_performance_section_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U88i is member of performance section of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U88i_is_member_of_performance_section_of">http://data.doremus.org/ontology#U88i_is_member_of_performance_section_of</seealso>
    let U88i_is_member_of_performance_section_of =
        Prefixed_Name(mus, "U88i_is_member_of_performance_section_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U89_occured_in_performance_conditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U89 occured in performance conditions</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U89_occured_in_performance_conditions">http://data.doremus.org/ontology#U89_occured_in_performance_conditions</seealso>
    let U89_occured_in_performance_conditions =
        Prefixed_Name(mus, "U89_occured_in_performance_conditions") |> PrefixedName

    /// <summary>
    ///   <para>mus:U89i_were_performance_conditions_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.doremus.org/ontology#U89i_were_performance_conditions_of">http://data.doremus.org/ontology#U89i_were_performance_conditions_of</seealso>
    let U89i_were_performance_conditions_of =
        Prefixed_Name(mus, "U89i_were_performance_conditions_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U90i_were_performance_conditions_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U90i were performance conditions of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U90i_were_performance_conditions_of">http://data.doremus.org/ontology#U90i_were_performance_conditions_of</seealso>
    let U90i_were_performance_conditions_of =
        Prefixed_Name(mus, "U90i_were_performance_conditions_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U92_is_foreseen_to_be_put_into_effect_through</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U92 is foreseen to be put into effect  through</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U92_is_foreseen_to_be_put_into_effect_through">http://data.doremus.org/ontology#U92_is_foreseen_to_be_put_into_effect_through</seealso>
    let U92_is_foreseen_to_be_put_into_effect_through =
        Prefixed_Name(mus, "U92_is_foreseen_to_be_put_into_effect_through") |> PrefixedName

    /// <summary>
    ///   <para>mus:U93_is_realised_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U93 is realised in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U93_is_realised_in">http://data.doremus.org/ontology#U93_is_realised_in</seealso>
    let U93_is_realised_in = Prefixed_Name(mus, "U93_is_realised_in") |> PrefixedName
    /// <summary>
    ///   <para>mus:U93i_realises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U93 realises</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U93i_realises">http://data.doremus.org/ontology#U93i_realises</seealso>
    let U93i_realises = Prefixed_Name(mus, "U93i_realises") |> PrefixedName
    /// <summary>
    ///   <para>mus:U94_has_work_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U93 has work type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U94_has_work_type">http://data.doremus.org/ontology#U94_has_work_type</seealso>
    let U94_has_work_type = Prefixed_Name(mus, "U94_has_work_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:M160_Publication_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M160 Publication statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M160_Publication_Statement">http://data.doremus.org/ontology#M160_Publication_Statement</seealso>
    let M160_Publication_Statement =
        Prefixed_Name(mus, "M160_Publication_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M165_Title_Proper_of_Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M165 Titre propre de la série</para><para>M165 Title proper of series</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M165_Title_Proper_of_Series">http://data.doremus.org/ontology#M165_Title_Proper_of_Series</seealso>
    let M165_Title_Proper_of_Series =
        Prefixed_Name(mus, "M165_Title_Proper_of_Series") |> PrefixedName

    /// <summary>
    ///   <para>mus:U186i_is_printing_or_manufacture_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U186i is printing or manufacture statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U186i_is_printing_or_manufacture_statement_of">http://data.doremus.org/ontology#U186i_is_printing_or_manufacture_statement_of</seealso>
    let U186i_is_printing_or_manufacture_statement_of =
        Prefixed_Name(mus, "U186i_is_printing_or_manufacture_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U188i_is_series_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U188i is series statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U188i_is_series_statement_of">http://data.doremus.org/ontology#U188i_is_series_statement_of</seealso>
    let U188i_is_series_statement_of =
        Prefixed_Name(mus, "U188i_is_series_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U220i_is_title_and_statement_of_responsibility_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U220i is title and statement of responsibility of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U220i_is_title_and_statement_of_responsibility_of">http://data.doremus.org/ontology#U220i_is_title_and_statement_of_responsibility_of</seealso>
    let U220i_is_title_and_statement_of_responsibility_of =
        Prefixed_Name(mus, "U220i_is_title_and_statement_of_responsibility_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U42_has_opus_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U42 has opus number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U42_has_opus_number">http://data.doremus.org/ontology#U42_has_opus_number</seealso>
    let U42_has_opus_number = Prefixed_Name(mus, "U42_has_opus_number") |> PrefixedName

    /// <summary>
    ///   <para>mus:U80_has_highest_pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U80 has highest pitch</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U80_has_highest_pitch">http://data.doremus.org/ontology#U80_has_highest_pitch</seealso>
    let U80_has_highest_pitch =
        Prefixed_Name(mus, "U80_has_highest_pitch") |> PrefixedName

    /// <summary>
    ///   <para>mus:U82_has_foreseen_performer_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U82 has foreseen performer status</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U82_has_foreseen_performer_status">http://data.doremus.org/ontology#U82_has_foreseen_performer_status</seealso>
    let U82_has_foreseen_performer_status =
        Prefixed_Name(mus, "U82_has_foreseen_performer_status") |> PrefixedName

    /// <summary>
    ///   <para>mus:M174_Content_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M174 Type de contenu</para><para>M174 Content type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M174_Content_Type">http://data.doremus.org/ontology#M174_Content_Type</seealso>
    let M174_Content_Type = Prefixed_Name(mus, "M174_Content_Type") |> PrefixedName

    /// <summary>
    ///   <para>mus:M189i_is_main_series_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U189i is main series statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M189i_is_main_series_statement_of">http://data.doremus.org/ontology#M189i_is_main_series_statement_of</seealso>
    let M189i_is_main_series_statement_of =
        Prefixed_Name(mus, "M189i_is_main_series_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:M20_Music_Group_Formation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M20 Type de formation musicale ou vocale</para><para>M20 Music Group Formation</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M20_Music_Group_Formation">http://data.doremus.org/ontology#M20_Music_Group_Formation</seealso>
    let M20_Music_Group_Formation =
        Prefixed_Name(mus, "M20_Music_Group_Formation") |> PrefixedName

    /// <summary>
    ///   <para>mus:M51_Type_Of_Recording_Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M51 Type d'équipement d'enregistrement</para><para>M51 Type of recording equipment</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M51_Type_Of_Recording_Equipment">http://data.doremus.org/ontology#M51_Type_Of_Recording_Equipment</seealso>
    let M51_Type_Of_Recording_Equipment =
        Prefixed_Name(mus, "M51_Type_Of_Recording_Equipment") |> PrefixedName

    /// <summary>
    ///   <para>mus:U167_has_title_proper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U167 has title proper</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U167_has_title_proper">http://data.doremus.org/ontology#U167_has_title_proper</seealso>
    let U167_has_title_proper =
        Prefixed_Name(mus, "U167_has_title_proper") |> PrefixedName

    /// <summary>
    ///   <para>mus:U167i_is_title_proper_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U167i is title proper of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U167i_is_title_proper_of">http://data.doremus.org/ontology#U167i_is_title_proper_of</seealso>
    let U167i_is_title_proper_of =
        Prefixed_Name(mus, "U167i_is_title_proper_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U169_was_issued_under_label_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U169 was issued under label name</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U169_was_issued_under_label_name">http://data.doremus.org/ontology#U169_was_issued_under_label_name</seealso>
    let U169_was_issued_under_label_name =
        Prefixed_Name(mus, "U169_was_issued_under_label_name") |> PrefixedName

    /// <summary>
    ///   <para>mus:U20_has_music_group_formation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U20 has music group formation</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U20_has_music_group_formation">http://data.doremus.org/ontology#U20_has_music_group_formation</seealso>
    let U20_has_music_group_formation =
        Prefixed_Name(mus, "U20_has_music_group_formation") |> PrefixedName

    /// <summary>
    ///   <para>mus:U210_has_pagination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U210 has pagination</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U210_has_pagination">http://data.doremus.org/ontology#U210_has_pagination</seealso>
    let U210_has_pagination = Prefixed_Name(mus, "U210_has_pagination") |> PrefixedName

    /// <summary>
    ///   <para>mus:U210i_is_pagination_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U210i is pagination of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U210i_is_pagination_of">http://data.doremus.org/ontology#U210i_is_pagination_of</seealso>
    let U210i_is_pagination_of =
        Prefixed_Name(mus, "U210i_is_pagination_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U212_has_technical_features</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U212 has technical features</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U212_has_technical_features">http://data.doremus.org/ontology#U212_has_technical_features</seealso>
    let U212_has_technical_features =
        Prefixed_Name(mus, "U212_has_technical_features") |> PrefixedName

    /// <summary>
    ///   <para>mus:U213_has_recording_method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U213 has recording method</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U213_has_recording_method">http://data.doremus.org/ontology#U213_has_recording_method</seealso>
    let U213_has_recording_method =
        Prefixed_Name(mus, "U213_has_recording_method") |> PrefixedName

    /// <summary>
    ///   <para>mus:U216_has_tape_configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U216 has tape configuration</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U216_has_tape_configuration">http://data.doremus.org/ontology#U216_has_tape_configuration</seealso>
    let U216_has_tape_configuration =
        Prefixed_Name(mus, "U216_has_tape_configuration") |> PrefixedName

    /// <summary>
    ///   <para>mus:U217_has_playing_speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U217 has playing speed</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U217_has_playing_speed">http://data.doremus.org/ontology#U217_has_playing_speed</seealso>
    let U217_has_playing_speed =
        Prefixed_Name(mus, "U217_has_playing_speed") |> PrefixedName

    /// <summary>
    ///   <para>mus:U21_is_about_actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U21 is about actor</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U21_is_about_actor">http://data.doremus.org/ontology#U21_is_about_actor</seealso>
    let U21_is_about_actor = Prefixed_Name(mus, "U21_is_about_actor") |> PrefixedName

    /// <summary>
    ///   <para>mus:U221_has_title_proper_of_series</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U221 has title proper of series</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U221_has_title_proper_of_series">http://data.doremus.org/ontology#U221_has_title_proper_of_series</seealso>
    let U221_has_title_proper_of_series =
        Prefixed_Name(mus, "U221_has_title_proper_of_series") |> PrefixedName

    /// <summary>
    ///   <para>mus:U221i_is_title_proper_of_series_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U221i is  title proper of series of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U221i_is_title_proper_of_series_of">http://data.doremus.org/ontology#U221i_is_title_proper_of_series_of</seealso>
    let U221i_is_title_proper_of_series_of =
        Prefixed_Name(mus, "U221i_is_title_proper_of_series_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U223i_is_number_of_tape_tracks_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U223i is number of tape tracks of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U223i_is_number_of_tape_tracks_of">http://data.doremus.org/ontology#U223i_is_number_of_tape_tracks_of</seealso>
    let U223i_is_number_of_tape_tracks_of =
        Prefixed_Name(mus, "U223i_is_number_of_tape_tracks_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U224_has_title_proper_of_multipart_monograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U224 has title proper of multipart monograph</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U224_has_title_proper_of_multipart_monograph">http://data.doremus.org/ontology#U224_has_title_proper_of_multipart_monograph</seealso>
    let U224_has_title_proper_of_multipart_monograph =
        Prefixed_Name(mus, "U224_has_title_proper_of_multipart_monograph") |> PrefixedName

    /// <summary>
    ///   <para>mus:U227_has_content_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U227 has content type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U227_has_content_type">http://data.doremus.org/ontology#U227_has_content_type</seealso>
    let U227_has_content_type =
        Prefixed_Name(mus, "U227_has_content_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:U227i_is_content_type_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://data.doremus.org/ontology#U227i_is_content_type_of">http://data.doremus.org/ontology#U227i_is_content_type_of</seealso>
    let U227i_is_content_type_of =
        Prefixed_Name(mus, "U227i_is_content_type_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U228_has_other_distinguishing_characteristic_of_expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U226 has other distinguishing characteristic of expression</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U228_has_other_distinguishing_characteristic_of_expression">http://data.doremus.org/ontology#U228_has_other_distinguishing_characteristic_of_expression</seealso>
    let U228_has_other_distinguishing_characteristic_of_expression =
        Prefixed_Name(mus, "U228_has_other_distinguishing_characteristic_of_expression") |> PrefixedName

    /// <summary>
    ///   <para>mus:U23_has_casting_detail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U23 has casting detail</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U23_has_casting_detail">http://data.doremus.org/ontology#U23_has_casting_detail</seealso>
    let U23_has_casting_detail =
        Prefixed_Name(mus, "U23_has_casting_detail") |> PrefixedName

    /// <summary>
    ///   <para>mus:U25_has_scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U25 has scale</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U25_has_scale">http://data.doremus.org/ontology#U25_has_scale</seealso>
    let U25_has_scale = Prefixed_Name(mus, "U25_has_scale") |> PrefixedName
    /// <summary>
    ///   <para>mus:U25i_is_scale_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U25i is scale of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U25i_is_scale_of">http://data.doremus.org/ontology#U25i_is_scale_of</seealso>
    let U25i_is_scale_of = Prefixed_Name(mus, "U25i_is_scale_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U51i_has_partial_or_full_recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U51i has partial or full recording</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U51i_has_partial_or_full_recording">http://data.doremus.org/ontology#U51i_has_partial_or_full_recording</seealso>
    let U51i_has_partial_or_full_recording =
        Prefixed_Name(mus, "U51i_has_partial_or_full_recording") |> PrefixedName

    /// <summary>
    ///   <para>mus:U52_has_context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U52 has context</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U52_has_context">http://data.doremus.org/ontology#U52_has_context</seealso>
    let U52_has_context = Prefixed_Name(mus, "U52_has_context") |> PrefixedName
    /// <summary>
    ///   <para>mus:U52i_is_context_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U52i is context of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U52i_is_context_of">http://data.doremus.org/ontology#U52i_is_context_of</seealso>
    let U52i_is_context_of = Prefixed_Name(mus, "U52i_is_context_of") |> PrefixedName
    /// <summary>
    ///   <para>mus:U53_has_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U53 has duration</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U53_has_duration">http://data.doremus.org/ontology#U53_has_duration</seealso>
    let U53_has_duration = Prefixed_Name(mus, "U53_has_duration") |> PrefixedName
    /// <summary>
    ///   <para>mus:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://data.doremus.org/ontology#">http://data.doremus.org/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(mus, "") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU197_should_have_binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU197_should_have_binding</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU197_should_have_binding">http://data.doremus.org/ontology#CLU197_should_have_binding</seealso>
    let CLU197_should_have_binding =
        Prefixed_Name(mus, "CLU197_should_have_binding") |> PrefixedName

    /// <summary>
    ///   <para>mus:M170_Binding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M170 Reliure</para><para>M170 Binding</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M170_Binding">http://data.doremus.org/ontology#M170_Binding</seealso>
    let M170_Binding = Prefixed_Name(mus, "M170_Binding") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU206_should_have_media_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU206 should have media type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU206_should_have_media_type">http://data.doremus.org/ontology#CLU206_should_have_media_type</seealso>
    let CLU206_should_have_media_type =
        Prefixed_Name(mus, "CLU206_should_have_media_type") |> PrefixedName

    /// <summary>
    ///   <para>mus:M169_Carrier_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M169 Type de support</para><para>M169 Carrier type</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M169_Carrier_Type">http://data.doremus.org/ontology#M169_Carrier_Type</seealso>
    let M169_Carrier_Type = Prefixed_Name(mus, "M169_Carrier_Type") |> PrefixedName
    /// <summary>
    ///   <para>mus:M173_Playing_Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M173 Vitesse de lecture</para><para>M173 Playing speed</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M173_Playing_Speed">http://data.doremus.org/ontology#M173_Playing_Speed</seealso>
    let M173_Playing_Speed = Prefixed_Name(mus, "M173_Playing_Speed") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU217i_should_be_playing_speed_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU217i should be playing speed of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU217i_should_be_playing_speed_of">http://data.doremus.org/ontology#CLU217i_should_be_playing_speed_of</seealso>
    let CLU217i_should_be_playing_speed_of =
        Prefixed_Name(mus, "CLU217i_should_be_playing_speed_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU223_should_have_number_of_tape_tracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU223 should have number of tape tracks</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU223_should_have_number_of_tape_tracks">http://data.doremus.org/ontology#CLU223_should_have_number_of_tape_tracks</seealso>
    let CLU223_should_have_number_of_tape_tracks =
        Prefixed_Name(mus, "CLU223_should_have_number_of_tape_tracks") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU53_should_have_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU53 should have duration</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU53_should_have_duration">http://data.doremus.org/ontology#CLU53_should_have_duration</seealso>
    let CLU53_should_have_duration =
        Prefixed_Name(mus, "CLU53_should_have_duration") |> PrefixedName

    /// <summary>
    ///   <para>mus:CLU53i_should_be_duration_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>CLU53i should be duration of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#CLU53i_should_be_duration_of">http://data.doremus.org/ontology#CLU53i_should_be_duration_of</seealso>
    let CLU53i_should_be_duration_of =
        Prefixed_Name(mus, "CLU53i_should_be_duration_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:M11_Catalogue_Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M11 Numéro de catalogue</para><para>M11 Catalogue Number</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M11_Catalogue_Number">http://data.doremus.org/ontology#M11_Catalogue_Number</seealso>
    let M11_Catalogue_Number =
        Prefixed_Name(mus, "M11_Catalogue_Number") |> PrefixedName

    /// <summary>
    ///   <para>mus:M14_Medium_Of_Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M14 Distribution instrumentale ou vocale</para><para>M14 Medium of performance</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M14_Medium_Of_Performance">http://data.doremus.org/ontology#M14_Medium_Of_Performance</seealso>
    let M14_Medium_Of_Performance =
        Prefixed_Name(mus, "M14_Medium_Of_Performance") |> PrefixedName

    /// <summary>
    ///   <para>mus:M155_Cast_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M155 Cast statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M155_Cast_Statement">http://data.doremus.org/ontology#M155_Cast_Statement</seealso>
    let M155_Cast_Statement = Prefixed_Name(mus, "M155_Cast_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M156_Title_Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M156 Title statement</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M156_Title_Statement">http://data.doremus.org/ontology#M156_Title_Statement</seealso>
    let M156_Title_Statement =
        Prefixed_Name(mus, "M156_Title_Statement") |> PrefixedName

    /// <summary>
    ///   <para>mus:M157_Statement_of_Responsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>M157 Statement of responsibility</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#M157_Statement_of_Responsibility">http://data.doremus.org/ontology#M157_Statement_of_Responsibility</seealso>
    let M157_Statement_of_Responsibility =
        Prefixed_Name(mus, "M157_Statement_of_Responsibility") |> PrefixedName

    /// <summary>
    ///   <para>mus:U171i_is_parallel_title_statement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U171i is parallel title statement of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U171i_is_parallel_title_statement_of">http://data.doremus.org/ontology#U171i_is_parallel_title_statement_of</seealso>
    let U171i_is_parallel_title_statement_of =
        Prefixed_Name(mus, "U171i_is_parallel_title_statement_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U172_has_statement_of_responsibility_relating_to_title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U172 has statement of responsibility relating to title</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U172_has_statement_of_responsibility_relating_to_title">http://data.doremus.org/ontology#U172_has_statement_of_responsibility_relating_to_title</seealso>
    let U172_has_statement_of_responsibility_relating_to_title =
        Prefixed_Name(mus, "U172_has_statement_of_responsibility_relating_to_title") |> PrefixedName

    /// <summary>
    ///   <para>mus:U72_has_title_note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U72 has title note</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U72_has_title_note">http://data.doremus.org/ontology#U72_has_title_note</seealso>
    let U72_has_title_note = Prefixed_Name(mus, "U72_has_title_note") |> PrefixedName
    /// <summary>
    ///   <para>mus:U74_cited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U74 cited</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U74_cited">http://data.doremus.org/ontology#U74_cited</seealso>
    let U74_cited = Prefixed_Name(mus, "U74_cited") |> PrefixedName
    /// <summary>
    ///   <para>mus:U74i_was_cited_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U74i was cited by</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U74i_was_cited_by">http://data.doremus.org/ontology#U74i_was_cited_by</seealso>
    let U74i_was_cited_by = Prefixed_Name(mus, "U74i_was_cited_by") |> PrefixedName

    /// <summary>
    ///   <para>mus:U75_has_harmonic_structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U75 has harmonic structure</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U75_has_harmonic_structure">http://data.doremus.org/ontology#U75_has_harmonic_structure</seealso>
    let U75_has_harmonic_structure =
        Prefixed_Name(mus, "U75_has_harmonic_structure") |> PrefixedName

    /// <summary>
    ///   <para>mus:U75i_is_harmonic_structure_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U75i is harmonic structure of</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U75i_is_harmonic_structure_of">http://data.doremus.org/ontology#U75i_is_harmonic_structure_of</seealso>
    let U75i_is_harmonic_structure_of =
        Prefixed_Name(mus, "U75i_is_harmonic_structure_of") |> PrefixedName

    /// <summary>
    ///   <para>mus:U77i_is_foreseen_plan_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>U77i is foreseen plan in</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U77i_is_foreseen_plan_in">http://data.doremus.org/ontology#U77i_is_foreseen_plan_in</seealso>
    let U77i_is_foreseen_plan_in =
        Prefixed_Name(mus, "U77i_is_foreseen_plan_in") |> PrefixedName

    /// <summary>
    ///   <para>mus:U78_estimated_duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La durée éditeur n'est pas "mesurée" mais "estimée"</para>
    /// labels<para>U78 estimated duration</para><para>U78 durée estimée</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U78_estimated_duration">http://data.doremus.org/ontology#U78_estimated_duration</seealso>
    let U78_estimated_duration =
        Prefixed_Name(mus, "U78_estimated_duration") |> PrefixedName

    /// <summary>
    ///   <para>mus:U79_has_lowest_pitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>U79 has lowest pitch</para></remarks>
    /// <seealso href="http://data.doremus.org/ontology#U79_has_lowest_pitch">http://data.doremus.org/ontology#U79_has_lowest_pitch</seealso>
    let U79_has_lowest_pitch =
        Prefixed_Name(mus, "U79_has_lowest_pitch") |> PrefixedName

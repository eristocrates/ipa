#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mus =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.doremus.org/ontology#" "mus"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : CLU198i should be container of</para>
    ///   <a href="http://data.doremus.org/ontology#CLI198i_should_be_container_of">mus:CLI198i_should_be_container_of</a>
    /// </summary>
    let CLI198i_should_be_container_of =
        _prefixId.prefix "CLI198i_should_be_container_of"

    /// <summary>
    ///   <para>rdfs:label : CLU197_should_have_binding</para>
    ///   <a href="http://data.doremus.org/ontology#CLU197_should_have_binding">mus:CLU197_should_have_binding</a>
    /// </summary>
    let CLU197_should_have_binding = _prefixId.prefix "CLU197_should_have_binding"
    /// <summary>
    ///   <para>rdfs:label : CLU197i should be binding of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU197i_should_be_binding_of">mus:CLU197i_should_be_binding_of</a>
    /// </summary>
    let CLU197i_should_be_binding_of = _prefixId.prefix "CLU197i_should_be_binding_of"
    /// <summary>
    ///   <para>rdfs:label : CLU198 should have container</para>
    ///   <a href="http://data.doremus.org/ontology#CLU198_should_have_container">mus:CLU198_should_have_container</a>
    /// </summary>
    let CLU198_should_have_container = _prefixId.prefix "CLU198_should_have_container"
    /// <summary>
    ///   <para>rdfs:label : CLU206 should have media type</para>
    ///   <a href="http://data.doremus.org/ontology#CLU206_should_have_media_type">mus:CLU206_should_have_media_type</a>
    /// </summary>
    let CLU206_should_have_media_type = _prefixId.prefix "CLU206_should_have_media_type"

    /// <summary>
    ///   <para>rdfs:label : CLU206i should be media type of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU206i_should_be_media_type_of">mus:CLU206i_should_be_media_type_of</a>
    /// </summary>
    let CLU206i_should_be_media_type_of =
        _prefixId.prefix "CLU206i_should_be_media_type_of"

    /// <summary>
    ///   <para>rdfs:label : CLU207 should have carrier type</para>
    ///   <a href="http://data.doremus.org/ontology#CLU207_should_have_carrier_type">mus:CLU207_should_have_carrier_type</a>
    /// </summary>
    let CLU207_should_have_carrier_type =
        _prefixId.prefix "CLU207_should_have_carrier_type"

    /// <summary>
    ///   <para>rdfs:label : CLU207i should be carrier type of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU207i_should_be_carrier_type_of">mus:CLU207i_should_be_carrier_type_of</a>
    /// </summary>
    let CLU207i_should_be_carrier_type_of =
        _prefixId.prefix "CLU207i_should_be_carrier_type_of"

    /// <summary>
    ///   <para>rdfs:label : CLU210 should have pagination</para>
    ///   <a href="http://data.doremus.org/ontology#CLU210_should_have_pagination">mus:CLU210_should_have_pagination</a>
    /// </summary>
    let CLU210_should_have_pagination = _prefixId.prefix "CLU210_should_have_pagination"

    /// <summary>
    ///   <para>rdfs:label : CLU210i should be pagination of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU210i_should_be_pagination_of">mus:CLU210i_should_be_pagination_of</a>
    /// </summary>
    let CLU210i_should_be_pagination_of =
        _prefixId.prefix "CLU210i_should_be_pagination_of"

    /// <summary>
    ///   <para>rdfs:label : CLU217 should have playing speed</para>
    ///   <a href="http://data.doremus.org/ontology#CLU217_should_have_playing_speed">mus:CLU217_should_have_playing_speed</a>
    /// </summary>
    let CLU217_should_have_playing_speed =
        _prefixId.prefix "CLU217_should_have_playing_speed"

    /// <summary>
    ///   <para>rdfs:label : CLU217i should be playing speed of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU217i_should_be_playing_speed_of">mus:CLU217i_should_be_playing_speed_of</a>
    /// </summary>
    let CLU217i_should_be_playing_speed_of =
        _prefixId.prefix "CLU217i_should_be_playing_speed_of"

    /// <summary>
    ///   <para>rdfs:label : CLU223 should have number of tape tracks</para>
    ///   <a href="http://data.doremus.org/ontology#CLU223_should_have_number_of_tape_tracks">mus:CLU223_should_have_number_of_tape_tracks</a>
    /// </summary>
    let CLU223_should_have_number_of_tape_tracks =
        _prefixId.prefix "CLU223_should_have_number_of_tape_tracks"

    /// <summary>
    ///   <para>rdfs:label : U223i should be number of tape tracks of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU223i_should_be_number_of_tape_tracks_of">mus:CLU223i_should_be_number_of_tape_tracks_of</a>
    /// </summary>
    let CLU223i_should_be_number_of_tape_tracks_of =
        _prefixId.prefix "CLU223i_should_be_number_of_tape_tracks_of"

    /// <summary>
    ///   <para>rdfs:label : CLU53 should have duration</para>
    ///   <a href="http://data.doremus.org/ontology#CLU53_should_have_duration">mus:CLU53_should_have_duration</a>
    /// </summary>
    let CLU53_should_have_duration = _prefixId.prefix "CLU53_should_have_duration"
    /// <summary>
    ///   <para>rdfs:label : CLU53i should be duration of</para>
    ///   <a href="http://data.doremus.org/ontology#CLU53i_should_be_duration_of">mus:CLU53i_should_be_duration_of</a>
    /// </summary>
    let CLU53i_should_be_duration_of = _prefixId.prefix "CLU53i_should_be_duration_of"
    /// <summary>
    ///   <para>rdfs:label : M10 Nom de cataloguerdfs:label : M10 Catalogue Name</para>
    ///   <a href="http://data.doremus.org/ontology#M10_Catalogue_Name">mus:M10_Catalogue_Name</a>
    /// </summary>
    let M10_Catalogue_Name = _prefixId.prefix "M10_Catalogue_Name"
    /// <summary>
    ///   <para>rdfs:label : M11 Numéro de cataloguerdfs:label : M11 Catalogue Number</para>
    ///   <a href="http://data.doremus.org/ontology#M11_Catalogue_Number">mus:M11_Catalogue_Number</a>
    /// </summary>
    let M11_Catalogue_Number = _prefixId.prefix "M11_Catalogue_Number"
    /// <summary>
    ///   <para>rdfs:label : M12 Opus Numberrdfs:label : M12 Numéro d'opus</para>
    ///   <a href="http://data.doremus.org/ontology#M12_Opus_Number">mus:M12_Opus_Number</a>
    /// </summary>
    let M12_Opus_Number = _prefixId.prefix "M12_Opus_Number"
    /// <summary>
    ///   <para>rdfs:label : M13 Sous-numéro d'opusrdfs:label : M13 Opus Subnumber</para>
    ///   <a href="http://data.doremus.org/ontology#M13_Opus_Subnumber">mus:M13_Opus_Subnumber</a>
    /// </summary>
    let M13_Opus_Subnumber = _prefixId.prefix "M13_Opus_Subnumber"
    /// <summary>
    ///   <para>rdfs:label : M14 Medium of performancerdfs:label : M14 Distribution instrumentale ou vocale</para>
    ///   <a href="http://data.doremus.org/ontology#M14_Medium_Of_Performance">mus:M14_Medium_Of_Performance</a>
    /// </summary>
    let M14_Medium_Of_Performance = _prefixId.prefix "M14_Medium_Of_Performance"
    /// <summary>
    ///   <para>rdfs:label : M154 Nom du libellérdfs:label : M154 Label name</para>
    ///   <a href="http://data.doremus.org/ontology#M154_Label_Name">mus:M154_Label_Name</a>
    /// </summary>
    let M154_Label_Name = _prefixId.prefix "M154_Label_Name"
    /// <summary>
    ///   <para>rdfs:label : M155 Cast statement</para>
    ///   <a href="http://data.doremus.org/ontology#M155_Cast_Statement">mus:M155_Cast_Statement</a>
    /// </summary>
    let M155_Cast_Statement = _prefixId.prefix "M155_Cast_Statement"
    /// <summary>
    ///   <para>rdfs:label : M156 Title statement</para>
    ///   <a href="http://data.doremus.org/ontology#M156_Title_Statement">mus:M156_Title_Statement</a>
    /// </summary>
    let M156_Title_Statement = _prefixId.prefix "M156_Title_Statement"

    /// <summary>
    ///   <para>rdfs:label : M157 Statement of responsibility</para>
    ///   <a href="http://data.doremus.org/ontology#M157_Statement_of_Responsibility">mus:M157_Statement_of_Responsibility</a>
    /// </summary>
    let M157_Statement_of_Responsibility =
        _prefixId.prefix "M157_Statement_of_Responsibility"

    /// <summary>
    ///   <para>rdfs:label : M158 Title and statement of responsability</para>
    ///   <a href="http://data.doremus.org/ontology#M158_Title_and_Statement_of_Responsibility">mus:M158_Title_and_Statement_of_Responsibility</a>
    /// </summary>
    let M158_Title_and_Statement_of_Responsibility =
        _prefixId.prefix "M158_Title_and_Statement_of_Responsibility"

    /// <summary>
    ///   <para>rdfs:label : M159 Edition statement</para>
    ///   <a href="http://data.doremus.org/ontology#M159_Edition_Statement">mus:M159_Edition_Statement</a>
    /// </summary>
    let M159_Edition_Statement = _prefixId.prefix "M159_Edition_Statement"
    /// <summary>
    ///   <para>rdfs:label : M15 Mention de dédicacerdfs:label : M15 Dedication Statement</para>
    ///   <a href="http://data.doremus.org/ontology#M15_Dedication_Statement">mus:M15_Dedication_Statement</a>
    /// </summary>
    let M15_Dedication_Statement = _prefixId.prefix "M15_Dedication_Statement"
    /// <summary>
    ///   <para>rdfs:label : M160 Publication statement</para>
    ///   <a href="http://data.doremus.org/ontology#M160_Publication_Statement">mus:M160_Publication_Statement</a>
    /// </summary>
    let M160_Publication_Statement = _prefixId.prefix "M160_Publication_Statement"
    /// <summary>
    ///   <para>rdfs:label : M161 Distribution statement</para>
    ///   <a href="http://data.doremus.org/ontology#M161_Distribution_Statement">mus:M161_Distribution_Statement</a>
    /// </summary>
    let M161_Distribution_Statement = _prefixId.prefix "M161_Distribution_Statement"
    /// <summary>
    ///   <para>rdfs:label : M162 Series statement</para>
    ///   <a href="http://data.doremus.org/ontology#M162_Series_Statement">mus:M162_Series_Statement</a>
    /// </summary>
    let M162_Series_Statement = _prefixId.prefix "M162_Series_Statement"
    /// <summary>
    ///   <para>rdfs:label : M163 Music format statement</para>
    ///   <a href="http://data.doremus.org/ontology#M163_Music_Format_Statement">mus:M163_Music_Format_Statement</a>
    /// </summary>
    let M163_Music_Format_Statement = _prefixId.prefix "M163_Music_Format_Statement"

    /// <summary>
    ///   <para>rdfs:label : M164 Multipart monograph statement</para>
    ///   <a href="http://data.doremus.org/ontology#M164_Multipart_Monograph_Statement">mus:M164_Multipart_Monograph_Statement</a>
    /// </summary>
    let M164_Multipart_Monograph_Statement =
        _prefixId.prefix "M164_Multipart_Monograph_Statement"

    /// <summary>
    ///   <para>rdfs:label : M165 Titre propre de la sérierdfs:label : M165 Title proper of series</para>
    ///   <a href="http://data.doremus.org/ontology#M165_Title_Proper_of_Series">mus:M165_Title_Proper_of_Series</a>
    /// </summary>
    let M165_Title_Proper_of_Series = _prefixId.prefix "M165_Title_Proper_of_Series"

    /// <summary>
    ///   <para>rdfs:label : M166 Titre propre de monographie multipartierdfs:label : M166 Title proper of multipart monograph</para>
    ///   <a href="http://data.doremus.org/ontology#M166_Title_Proper_of_Multipart_Monograph">mus:M166_Title_Proper_of_Multipart_Monograph</a>
    /// </summary>
    let M166_Title_Proper_of_Multipart_Monograph =
        _prefixId.prefix "M166_Title_Proper_of_Multipart_Monograph"

    /// <summary>
    ///   <para>rdfs:label : M167 Publication expression fragmentrdfs:label : M167 Fragment d'expression de publication</para>
    ///   <a href="http://data.doremus.org/ontology#M167_Publication_Expression_Fragment">mus:M167_Publication_Expression_Fragment</a>
    /// </summary>
    let M167_Publication_Expression_Fragment =
        _prefixId.prefix "M167_Publication_Expression_Fragment"

    /// <summary>
    ///   <para>rdfs:label : M168 Type de médiardfs:label : M168 Media type</para>
    ///   <a href="http://data.doremus.org/ontology#M168_Media_Type">mus:M168_Media_Type</a>
    /// </summary>
    let M168_Media_Type = _prefixId.prefix "M168_Media_Type"
    /// <summary>
    ///   <para>rdfs:label : M169 Type de supportrdfs:label : M169 Carrier type</para>
    ///   <a href="http://data.doremus.org/ontology#M169_Carrier_Type">mus:M169_Carrier_Type</a>
    /// </summary>
    let M169_Carrier_Type = _prefixId.prefix "M169_Carrier_Type"
    /// <summary>
    ///   <para>rdfs:label : M16 Maintenancerdfs:label : M16 Maintenance</para>
    ///   <a href="http://data.doremus.org/ontology#M16_Maintenance">mus:M16_Maintenance</a>
    /// </summary>
    let M16_Maintenance = _prefixId.prefix "M16_Maintenance"
    /// <summary>
    ///   <para>rdfs:label : M170 Reliurerdfs:label : M170 Binding</para>
    ///   <a href="http://data.doremus.org/ontology#M170_Binding">mus:M170_Binding</a>
    /// </summary>
    let M170_Binding = _prefixId.prefix "M170_Binding"
    /// <summary>
    ///   <para>rdfs:label : M171 Container</para>
    ///   <a href="http://data.doremus.org/ontology#M171_Container">mus:M171_Container</a>
    /// </summary>
    let M171_Container = _prefixId.prefix "M171_Container"
    /// <summary>
    ///   <para>rdfs:label : M172 Couleur du contenurdfs:label : M172 Colour content</para>
    ///   <a href="http://data.doremus.org/ontology#M172_Colour_Content">mus:M172_Colour_Content</a>
    /// </summary>
    let M172_Colour_Content = _prefixId.prefix "M172_Colour_Content"
    /// <summary>
    ///   <para>rdfs:label : M173 Vitesse de lecturerdfs:label : M173 Playing speed</para>
    ///   <a href="http://data.doremus.org/ontology#M173_Playing_Speed">mus:M173_Playing_Speed</a>
    /// </summary>
    let M173_Playing_Speed = _prefixId.prefix "M173_Playing_Speed"
    /// <summary>
    ///   <para>rdfs:label : M174 Type de contenurdfs:label : M174 Content type</para>
    ///   <a href="http://data.doremus.org/ontology#M174_Content_Type">mus:M174_Content_Type</a>
    /// </summary>
    let M174_Content_Type = _prefixId.prefix "M174_Content_Type"
    /// <summary>
    ///   <para>rdfs:label : M175 Music formatrdfs:label : M175 Format musical</para>
    ///   <a href="http://data.doremus.org/ontology#M175_Music_Format">mus:M175_Music_Format</a>
    /// </summary>
    let M175_Music_Format = _prefixId.prefix "M175_Music_Format"

    /// <summary>
    ///   <para>rdfs:label : M17 Point d'accès contrôlé créateurrdfs:label : M17 Controlled Access Point Creator</para>
    ///   <para>rdfs:comment : Scope note:
    /// Sous-classe de F50 Controlled Access Point, cette classe en reprend les caractéristiques, limitées au « créateur » de l’œuvre.rdfs:comment : Examples:
    /// …explosante-fixe… (F22) P1 is identified by F50 Controlled Access Point R8 consists of M17 Controlled Access Point Creator { Boulez, Pierre (1925, …) } and R8 consists of M18 Controlled Access Point Denomination R8 consists of F12 Nomen { …explosante-fixe… }</para>
    ///   <a href="http://data.doremus.org/ontology#M17_Controlled_Access_Point_Creator">mus:M17_Controlled_Access_Point_Creator</a>
    /// </summary>
    let M17_Controlled_Access_Point_Creator =
        _prefixId.prefix "M17_Controlled_Access_Point_Creator"

    /// <summary>
    ///   <para>rdfs:label : U187i is multipart monograph statement of</para>
    ///   <a href="http://data.doremus.org/ontology#M187i_is_multipart_monograph_statement_of">mus:M187i_is_multipart_monograph_statement_of</a>
    /// </summary>
    let M187i_is_multipart_monograph_statement_of =
        _prefixId.prefix "M187i_is_multipart_monograph_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U189i is main series statement of</para>
    ///   <a href="http://data.doremus.org/ontology#M189i_is_main_series_statement_of">mus:M189i_is_main_series_statement_of</a>
    /// </summary>
    let M189i_is_main_series_statement_of =
        _prefixId.prefix "M189i_is_main_series_statement_of"

    /// <summary>
    ///   <para>rdfs:label : M18 Point d'accès contrôlé dénominationrdfs:label : M18 Controlled Access Point Denomination</para>
    ///   <para>rdfs:comment : Scope note:
    /// Sous-classe de F50 Controlled Access Point, cette classe en reprend les caractéristiques, limitées à la « dénomination » de l’œuvre. La dénomination peut être un titre significatif (« Le Sacre du Printemps »), ou un titre composé (« Sonates. Piano. Opus 27 no 2. Do dièse mineur.”)rdfs:comment : Examples:
    /// …explosante-fixe… (F22) P1 is identified by F50 Controlled Access Point R8 consists of M17 Controlled Access Point Creator { Boulez, Pierre (1925, …) } and R8 consists of M18 Controlled Access Point Denomination R8 consists of F12 Nomen { …explosante-fixe… }</para>
    ///   <a href="http://data.doremus.org/ontology#M18_Controlled_Access_Point_Denomination">mus:M18_Controlled_Access_Point_Denomination</a>
    /// </summary>
    let M18_Controlled_Access_Point_Denomination =
        _prefixId.prefix "M18_Controlled_Access_Point_Denomination"

    /// <summary>
    ///   <para>rdfs:label : M19 Stylerdfs:label : M19 Style</para>
    ///   <a href="http://data.doremus.org/ontology#M19_Categorization">mus:M19_Categorization</a>
    /// </summary>
    let M19_Categorization = _prefixId.prefix "M19_Categorization"
    /// <summary>
    ///   <para>rdfs:label : M1 Mention de cataloguerdfs:label : M1 Catalogue Statement</para>
    ///   <para>rdfs:comment : Scope Note:
    /// Cette classe permet de décrire, lorsqu’elles existent, les références de catalogue de l’œuvre musicale. Par catalogue, on comprend tous les catalogues thématiques à proprement parler (donc à l’exclusion des numéros d’opus) ainsi que les classifications spécifiques telles que WoO ou Anh.
    /// Selon le niveau de granularité initial, elle est décrite par une simple chaîne de caractères, ou par les objets symboliques M10 Catalogue Name et M11 Catalogue Number qui la composent. La classe M10 Catalogue Name peut-être documentée via la propriété p70i is documented in.rdfs:comment : Exemples :
    /// La cantate Ich habe genug de JS Bach [BWV 82] (F22) est identifiée par  (M1 Catalogue p3 has note E62 String) BWV 82
    /// La cantate Ich habe genug de JS Bach [BWV 82] (F22) est identifiée par  (M1 Catalogue p106 is composed of M10 Catalogue Name) BWV et (M1 Catalogue p106 is composed of Catalogue Number) 82.
    /// Komm, Gott Schöpfer, heiliger Geist. No 1 de JS Bach [BWV deest] (F22) est identifiée par (M1 Catalogue p3 has note E62 String) BWV deest.
    /// Duncan Gray [WoO 156, no 2] de Beethoven (F22) est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) WoO et (M1 Catalogue p106 is composed of Catalogue Number) 156, no 2.
    /// La Sonate pour Clavier en Ut majeur de Wilhelm Friedemann Bach identifiée BR A1 par le catalogue Bach Repertorium  et identifiée F200 par le catalogue Fasch (F22) : est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) BR et (M1 Catalogue p106 is composed of Catalogue Number) A1, et est identifiée par (M1 Catalogue p106 is composed of M10 Catalogue Name) F et (M1 Catalogue p106 is composed of Catalogue Number) 200.</para>
    ///   <a href="http://data.doremus.org/ontology#M1_Catalogue_Statement">mus:M1_Catalogue_Statement</a>
    /// </summary>
    let M1_Catalogue_Statement = _prefixId.prefix "M1_Catalogue_Statement"
    /// <summary>
    ///   <para>rdfs:label : M20 Type de formation musicale ou vocalerdfs:label : M20 Music Group Formation</para>
    ///   <a href="http://data.doremus.org/ontology#M20_Music_Group_Formation">mus:M20_Music_Group_Formation</a>
    /// </summary>
    let M20_Music_Group_Formation = _prefixId.prefix "M20_Music_Group_Formation"
    /// <summary>
    ///   <para>rdfs:label : M21 Structure Harmoniquerdfs:label : M21 Harmonic Structure</para>
    ///   <a href="http://data.doremus.org/ontology#M21_Harmonic_Structure">mus:M21_Harmonic_Structure</a>
    /// </summary>
    let M21_Harmonic_Structure = _prefixId.prefix "M21_Harmonic_Structure"
    /// <summary>
    ///   <para>rdfs:label : M22 Formerdfs:label : M22 Form</para>
    ///   <a href="http://data.doremus.org/ontology#M22_Form">mus:M22_Form</a>
    /// </summary>
    let M22_Form = _prefixId.prefix "M22_Form"
    /// <summary>
    ///   <para>rdfs:label : M23 Détail de la distributionrdfs:label : M23 Casting Detail</para>
    ///   <para>rdfs:comment : Scope note:
    /// Cette classe décrit un détail de la distribution prévue par le compositeur, par exemple une sonate pour violon et piano est décrite par deux « composantes » M23 qui sont le violon et le piano. Elle est donc obligatoirement associée à la classe M6 Intended Casting dont elle détaille les composantes. Ces composantes comprennent notamment le ou les medium of performance prévus par le compositeur, l’éventuel rôle soliste du medium of performance, le personnage interprété (par exemple dans un opéra), la tessiture précise.rdfs:comment : Examples:
    /// La Sonate pour piano opus 27, no 2 de Beethoven (F22) U13 has intended casting M6 Intended Casting U23 has casting detail M23 Casting Detail U1 has intended medium of performance M35 Cast Medium of Performance U39 has medium of performance M14 Medium of Performance { piano } and P90 has value { 1 }.</para>
    ///   <a href="http://data.doremus.org/ontology#M23_Casting_Detail">mus:M23_Casting_Detail</a>
    /// </summary>
    let M23_Casting_Detail = _prefixId.prefix "M23_Casting_Detail"
    /// <summary>
    ///   <para>rdfs:label : M24 Trackrdfs:label : M24 Piste</para>
    ///   <a href="http://data.doremus.org/ontology#M24_Track">mus:M24_Track</a>
    /// </summary>
    let M24_Track = _prefixId.prefix "M24_Track"
    /// <summary>
    ///   <para>rdfs:label : M25 Foreseen Activityrdfs:label : M25 Activité prévisionnelle</para>
    ///   <a href="http://data.doremus.org/ontology#M25_Foreseen_Activity">mus:M25_Foreseen_Activity</a>
    /// </summary>
    let M25_Foreseen_Activity = _prefixId.prefix "M25_Foreseen_Activity"
    /// <summary>
    ///   <para>rdfs:label : M26 Performance prévisionnellerdfs:label : M26 Foreseen Performance</para>
    ///   <a href="http://data.doremus.org/ontology#M26_Foreseen_Performance">mus:M26_Foreseen_Performance</a>
    /// </summary>
    let M26_Foreseen_Performance = _prefixId.prefix "M26_Foreseen_Performance"

    /// <summary>
    ///   <para>rdfs:label : M27 Performance individuelle prévisionnellerdfs:label : M27 Foreseen Individual Performance</para>
    ///   <a href="http://data.doremus.org/ontology#M27_Foreseen_Individual_Performance">mus:M27_Foreseen_Individual_Performance</a>
    /// </summary>
    let M27_Foreseen_Individual_Performance =
        _prefixId.prefix "M27_Foreseen_Individual_Performance"

    /// <summary>
    ///   <para>rdfs:label : M28 Performance individuellerdfs:label : M28 Individual Performance</para>
    ///   <a href="http://data.doremus.org/ontology#M28_Individual_Performance">mus:M28_Individual_Performance</a>
    /// </summary>
    let M28_Individual_Performance = _prefixId.prefix "M28_Individual_Performance"
    /// <summary>
    ///   <para>rdfs:label : M29 Post-productionrdfs:label : M29 Editing</para>
    ///   <a href="http://data.doremus.org/ontology#M29_Editing">mus:M29_Editing</a>
    /// </summary>
    let M29_Editing = _prefixId.prefix "M29_Editing"
    /// <summary>
    ///   <para>rdfs:label : M2 Opus Statementrdfs:label : M2 Mention d'opus</para>
    ///   <a href="http://data.doremus.org/ontology#M2_Opus_Statement">mus:M2_Opus_Statement</a>
    /// </summary>
    let M2_Opus_Statement = _prefixId.prefix "M2_Opus_Statement"
    /// <summary>
    ///   <para>rdfs:label : M30 Ambitusrdfs:label : M30 Ambitus</para>
    ///   <a href="http://data.doremus.org/ontology#M30_Ambitus">mus:M30_Ambitus</a>
    /// </summary>
    let M30_Ambitus = _prefixId.prefix "M30_Ambitus"
    /// <summary>
    ///   <para>rdfs:label : M31 Fonction de l'agentrdfs:label : M31 Actor's Function</para>
    ///   <a href="http://data.doremus.org/ontology#M31_Actor_Function">mus:M31_Actor_Function</a>
    /// </summary>
    let M31_Actor_Function = _prefixId.prefix "M31_Actor_Function"
    /// <summary>
    ///   <para>rdfs:label : M32 Responsabilité de l'agentrdfs:label : M32 Actor's Responsibility</para>
    ///   <a href="http://data.doremus.org/ontology#M32_Actor_Responsibility">mus:M32_Actor_Responsibility</a>
    /// </summary>
    let M32_Actor_Responsibility = _prefixId.prefix "M32_Actor_Responsibility"
    /// <summary>
    ///   <para>rdfs:label : M33 Set of Charactersrdfs:label : M33 Ensemble de personnages</para>
    ///   <a href="http://data.doremus.org/ontology#M33_Set_of_Characters">mus:M33_Set_of_Characters</a>
    /// </summary>
    let M33_Set_of_Characters = _prefixId.prefix "M33_Set_of_Characters"
    /// <summary>
    ///   <para>rdfs:label : M34 Award Assignmentrdfs:label : M34 Attribution de récompense</para>
    ///   <a href="http://data.doremus.org/ontology#M34_Award_Assignment">mus:M34_Award_Assignment</a>
    /// </summary>
    let M34_Award_Assignment = _prefixId.prefix "M34_Award_Assignment"

    /// <summary>
    ///   <para>rdfs:label : M35 Representative Publication Assignmentrdfs:label : M35 Attribution d'Expression publicationnelle représentative</para>
    ///   <a href="http://data.doremus.org/ontology#M35_Representative_Publication_Assignment">mus:M35_Representative_Publication_Assignment</a>
    /// </summary>
    let M35_Representative_Publication_Assignment =
        _prefixId.prefix "M35_Representative_Publication_Assignment"

    /// <summary>
    ///   <para>rdfs:label : M36 Récompenserdfs:label : M36 Award</para>
    ///   <a href="http://data.doremus.org/ontology#M36_Award">mus:M36_Award</a>
    /// </summary>
    let M36_Award = _prefixId.prefix "M36_Award"
    /// <summary>
    ///   <para>rdfs:label : M37 Music Scalerdfs:label : M37 Echelle Musicale</para>
    ///   <a href="http://data.doremus.org/ontology#M37_Music_Scale">mus:M37_Music_Scale</a>
    /// </summary>
    let M37_Music_Scale = _prefixId.prefix "M37_Music_Scale"
    /// <summary>
    ///   <para>rdfs:label : M38 Rhythmic Patternrdfs:label : M38 Figure Rythmique</para>
    ///   <a href="http://data.doremus.org/ontology#M38_Rhythmic_Pattern">mus:M38_Rhythmic_Pattern</a>
    /// </summary>
    let M38_Rhythmic_Pattern = _prefixId.prefix "M38_Rhythmic_Pattern"

    /// <summary>
    ///   <para>rdfs:label : M39 Derivation Type Assignmentrdfs:label : M39 Attribution de type de dérivation</para>
    ///   <a href="http://data.doremus.org/ontology#M39_Derivation_Type_Assignment">mus:M39_Derivation_Type_Assignment</a>
    /// </summary>
    let M39_Derivation_Type_Assignment =
        _prefixId.prefix "M39_Derivation_Type_Assignment"

    /// <summary>
    ///   <para>rdfs:label : M3 Order Numberrdfs:label : M3 Numéro d'ordre</para>
    ///   <a href="http://data.doremus.org/ontology#M3_Order_Number">mus:M3_Order_Number</a>
    /// </summary>
    let M3_Order_Number = _prefixId.prefix "M3_Order_Number"
    /// <summary>
    ///   <para>rdfs:label : M40 Contexterdfs:label : M40 Context</para>
    ///   <a href="http://data.doremus.org/ontology#M40_Context">mus:M40_Context</a>
    /// </summary>
    let M40_Context = _prefixId.prefix "M40_Context"
    /// <summary>
    ///   <para>rdfs:label : M41 Metronome Indicationrdfs:label : M41 Indication Métronomique</para>
    ///   <a href="http://data.doremus.org/ontology#M41_Metronome_Indication">mus:M41_Metronome_Indication</a>
    /// </summary>
    let M41_Metronome_Indication = _prefixId.prefix "M41_Metronome_Indication"

    /// <summary>
    ///   <para>rdfs:label : M42 Performed Expression Creationrdfs:label : M42 Création d'Expression interprétée</para>
    ///   <a href="http://data.doremus.org/ontology#M42_Performed_Expression_Creation">mus:M42_Performed_Expression_Creation</a>
    /// </summary>
    let M42_Performed_Expression_Creation =
        _prefixId.prefix "M42_Performed_Expression_Creation"

    /// <summary>
    ///   <para>rdfs:label : M43 Performed Expressionrdfs:label : M43 Expression interprétée</para>
    ///   <a href="http://data.doremus.org/ontology#M43_Performed_Expression">mus:M43_Performed_Expression</a>
    /// </summary>
    let M43_Performed_Expression = _prefixId.prefix "M43_Performed_Expression"
    /// <summary>
    ///   <para>rdfs:label : M44 Performed Workrdfs:label : M44 Oeuvre interprétée</para>
    ///   <a href="http://data.doremus.org/ontology#M44_Performed_Work">mus:M44_Performed_Work</a>
    /// </summary>
    let M44_Performed_Work = _prefixId.prefix "M44_Performed_Work"

    /// <summary>
    ///   <para>rdfs:label : M45 Descriptive Expression Assignmentrdfs:label : M45 Attribution d'Expression Descriptive</para>
    ///   <a href="http://data.doremus.org/ontology#M45_Descriptive_Expression_Assignment">mus:M45_Descriptive_Expression_Assignment</a>
    /// </summary>
    let M45_Descriptive_Expression_Assignment =
        _prefixId.prefix "M45_Descriptive_Expression_Assignment"

    /// <summary>
    ///   <para>rdfs:label : M46 Set of Tracksrdfs:label : M46 Ensemble de Pistes</para>
    ///   <para>rdfs:comment : Scope Note : ensemble des pistes constituant un enregistrement publié.</para>
    ///   <a href="http://data.doremus.org/ontology#M46_Set_of_Tracks">mus:M46_Set_of_Tracks</a>
    /// </summary>
    let M46_Set_of_Tracks = _prefixId.prefix "M46_Set_of_Tracks"
    /// <summary>
    ///   <para>rdfs:label : M47 WoO Numberrdfs:label : M47 Numéro de WoO</para>
    ///   <a href="http://data.doremus.org/ontology#M47_WoO_Number">mus:M47_WoO_Number</a>
    /// </summary>
    let M47_WoO_Number = _prefixId.prefix "M47_WoO_Number"
    /// <summary>
    ///   <para>rdfs:label : WoO sous-numérordfs:label : M48 WoO Subnumber</para>
    ///   <a href="http://data.doremus.org/ontology#M48_WoO_Subnumber">mus:M48_WoO_Subnumber</a>
    /// </summary>
    let M48_WoO_Subnumber = _prefixId.prefix "M48_WoO_Subnumber"
    /// <summary>
    ///   <para>rdfs:label : M49 Statut de l'interprèterdfs:label : M49 Performer status</para>
    ///   <a href="http://data.doremus.org/ontology#M49_Performer_Status">mus:M49_Performer_Status</a>
    /// </summary>
    let M49_Performer_Status = _prefixId.prefix "M49_Performer_Status"
    /// <summary>
    ///   <para>rdfs:label : M4 Tonalitérdfs:label : M4 Key</para>
    ///   <para>rdfs:comment : Scope note:
    /// Cette classe décrit la tonalité de l’œuvre.
    /// Les tonalités sont souvent listées sous forme de référentiels multilingues, c’est pourquoi la classe M4 Key est liée à la classe M7 Linguistic Appellation.rdfs:comment : Examples:	→ Le Concerto pour Piano et orchestre en Si bémol majeur de Beethoven a pour tonalité si bémol majeur :
    /// F22 Self-Contained Expression u11 has key M4 Key { Si bémol Majeur }</para>
    ///   <a href="http://data.doremus.org/ontology#M4_Key">mus:M4_Key</a>
    /// </summary>
    let M4_Key = _prefixId.prefix "M4_Key"

    /// <summary>
    ///   <para>rdfs:label : M50 Performance moderdfs:label : M50 Mode de performance</para>
    ///   <a href="http://data.doremus.org/ontology#M50_Creation_or_Performance_Mode">mus:M50_Creation_or_Performance_Mode</a>
    /// </summary>
    let M50_Creation_or_Performance_Mode =
        _prefixId.prefix "M50_Creation_or_Performance_Mode"

    /// <summary>
    ///   <para>rdfs:label : M51 Type of recording equipmentrdfs:label : M51 Type d'équipement d'enregistrement</para>
    ///   <a href="http://data.doremus.org/ontology#M51_Type_Of_Recording_Equipment">mus:M51_Type_Of_Recording_Equipment</a>
    /// </summary>
    let M51_Type_Of_Recording_Equipment =
        _prefixId.prefix "M51_Type_Of_Recording_Equipment"

    /// <summary>
    ///   <para>rdfs:label : M52 Technique d'équalisationrdfs:label : M52 Equalization technique</para>
    ///   <a href="http://data.doremus.org/ontology#M52_Equalization_Technique">mus:M52_Equalization_Technique</a>
    /// </summary>
    let M52_Equalization_Technique = _prefixId.prefix "M52_Equalization_Technique"
    /// <summary>
    ///   <para>rdfs:label : M53 Technique de réduction de bruitrdfs:label : M53 Noise reduction  technique</para>
    ///   <a href="http://data.doremus.org/ontology#M53_Noise_Reduction_Technique">mus:M53_Noise_Reduction_Technique</a>
    /// </summary>
    let M53_Noise_Reduction_Technique = _prefixId.prefix "M53_Noise_Reduction_Technique"

    /// <summary>
    ///   <para>rdfs:label : M54 Technique de spatialisation du sonrdfs:label : M54 Sound spatialization technique</para>
    ///   <a href="http://data.doremus.org/ontology#M54_Sound_Spatialization_Technique">mus:M54_Sound_Spatialization_Technique</a>
    /// </summary>
    let M54_Sound_Spatialization_Technique =
        _prefixId.prefix "M54_Sound_Spatialization_Technique"

    /// <summary>
    ///   <para>rdfs:label : M55 Condition of performancerdfs:label : M55 Condition de la performance</para>
    ///   <a href="http://data.doremus.org/ontology#M55_Condition_of_Performance">mus:M55_Condition_of_Performance</a>
    /// </summary>
    let M55_Condition_of_Performance = _prefixId.prefix "M55_Condition_of_Performance"

    /// <summary>
    ///   <para>rdfs:label : M57 Vocal or instrumental techniquerdfs:label : M57 Technique vocale ou instrumentale</para>
    ///   <a href="http://data.doremus.org/ontology#M57_Vocal_or_Instrumental_Technique">mus:M57_Vocal_or_Instrumental_Technique</a>
    /// </summary>
    let M57_Vocal_or_Instrumental_Technique =
        _prefixId.prefix "M57_Vocal_or_Instrumental_Technique"

    /// <summary>
    ///   <para>rdfs:label : M58 Programming Workrdfs:label : M58 Oeuvre de programmation</para>
    ///   <a href="http://data.doremus.org/ontology#M58_Programming_Work">mus:M58_Programming_Work</a>
    /// </summary>
    let M58_Programming_Work = _prefixId.prefix "M58_Programming_Work"
    /// <summary>
    ///   <para>rdfs:label : M59 Programmerdfs:label : M59 Program</para>
    ///   <a href="http://data.doremus.org/ontology#M59_Program">mus:M59_Program</a>
    /// </summary>
    let M59_Program = _prefixId.prefix "M59_Program"
    /// <summary>
    ///   <para>rdfs:label : M5 Genrerdfs:label : M5 Genre</para>
    ///   <a href="http://data.doremus.org/ontology#M5_Genre">mus:M5_Genre</a>
    /// </summary>
    let M5_Genre = _prefixId.prefix "M5_Genre"
    /// <summary>
    ///   <para>rdfs:label : M60 Public visérdfs:label : M60 Intended audience</para>
    ///   <a href="http://data.doremus.org/ontology#M60_Intended_Audience">mus:M60_Intended_Audience</a>
    /// </summary>
    let M60_Intended_Audience = _prefixId.prefix "M60_Intended_Audience"
    /// <summary>
    ///   <para>rdfs:label : M61 Work typerdfs:label : M61 Type d'oeuvre</para>
    ///   <a href="http://data.doremus.org/ontology#M61_Work_Type">mus:M61_Work_Type</a>
    /// </summary>
    let M61_Work_Type = _prefixId.prefix "M61_Work_Type"
    /// <summary>
    ///   <para>rdfs:label : M62 Niveau hiérarchiquerdfs:label : M62 Hierarchical level</para>
    ///   <a href="http://data.doremus.org/ontology#M62_Hierarchical_Level">mus:M62_Hierarchical_Level</a>
    /// </summary>
    let M62_Hierarchical_Level = _prefixId.prefix "M62_Hierarchical_Level"
    /// <summary>
    ///   <para>rdfs:label : M6 Distribution vocale ou instrumentalerdfs:label : M6 Casting</para>
    ///   <para>rdfs:comment : Scope note:
    /// Cette classe permet de décrire les « medium of performance » d’une œuvre, c’est-à-dire les instruments, machines, exécutants autres que musiciens (danseurs, acteurs, récitants,…) pour lesquels l’œuvre a été composée. Elle décrit donc l’intention du compositeur. M6 Casting est une « classe chapeau » qui représente la globalité de la distribution instrumentale et/ou vocale. Le détail de cette distribution est décrit via la classe M23 Casting Detail.
    /// Dans le cas de versions alternatives, on donnera deux M6 Casting différents pour la même expression.</para>
    ///   <a href="http://data.doremus.org/ontology#M6_Casting">mus:M6_Casting</a>
    /// </summary>
    let M6_Casting = _prefixId.prefix "M6_Casting"
    /// <summary>
    ///   <para>rdfs:label : M7 Linguistic Appellationrdfs:label : M7 Appellation linguistique</para>
    ///   <para>rdfs:comment : Scope note:
    /// Cette classe permet de décrire une appellation et ses composantes linguistiques. Elle comprend donc les appellations originales et les traductions de ces appellations.</para>
    ///   <a href="http://data.doremus.org/ontology#M7_Linguistic_Appellation">mus:M7_Linguistic_Appellation</a>
    /// </summary>
    let M7_Linguistic_Appellation = _prefixId.prefix "M7_Linguistic_Appellation"
    /// <summary>
    ///   <para>rdfs:label : M8 Tempordfs:label : M8 Tempo</para>
    ///   <a href="http://data.doremus.org/ontology#M8_Tempo">mus:M8_Tempo</a>
    /// </summary>
    let M8_Tempo = _prefixId.prefix "M8_Tempo"
    /// <summary>
    ///   <para>rdfs:label : M9 Type de dérivationrdfs:label : M9 Derivation Type</para>
    ///   <a href="http://data.doremus.org/ontology#M9_Derivation_Type">mus:M9_Derivation_Type</a>
    /// </summary>
    let M9_Derivation_Type = _prefixId.prefix "M9_Derivation_Type"
    /// <summary>
    ///   <para>rdfs:label : U10 has order number</para>
    ///   <a href="http://data.doremus.org/ontology#U10_has_order_number">mus:U10_has_order_number</a>
    /// </summary>
    let U10_has_order_number = _prefixId.prefix "U10_has_order_number"
    /// <summary>
    ///   <para>rdfs:label : U11 has key</para>
    ///   <a href="http://data.doremus.org/ontology#U11_has_key">mus:U11_has_key</a>
    /// </summary>
    let U11_has_key = _prefixId.prefix "U11_has_key"
    /// <summary>
    ///   <para>rdfs:label : U11i is key of</para>
    ///   <a href="http://data.doremus.org/ontology#U11i_is_key_of">mus:U11i_is_key_of</a>
    /// </summary>
    let U11i_is_key_of = _prefixId.prefix "U11i_is_key_of"
    /// <summary>
    ///   <para>rdfs:label : U12 has genre</para>
    ///   <a href="http://data.doremus.org/ontology#U12_has_genre">mus:U12_has_genre</a>
    /// </summary>
    let U12_has_genre = _prefixId.prefix "U12_has_genre"
    /// <summary>
    ///   <para>rdfs:label : U12i is genre of</para>
    ///   <a href="http://data.doremus.org/ontology#U12i_is_genre_of">mus:U12i_is_genre_of</a>
    /// </summary>
    let U12i_is_genre_of = _prefixId.prefix "U12i_is_genre_of"
    /// <summary>
    ///   <para>rdfs:label : U13 has casting</para>
    ///   <a href="http://data.doremus.org/ontology#U13_has_casting">mus:U13_has_casting</a>
    /// </summary>
    let U13_has_casting = _prefixId.prefix "U13_has_casting"
    /// <summary>
    ///   <para>rdfs:label : U13i is casting of</para>
    ///   <a href="http://data.doremus.org/ontology#U13i_is_casting_of">mus:U13i_is_casting_of</a>
    /// </summary>
    let U13i_is_casting_of = _prefixId.prefix "U13i_is_casting_of"
    /// <summary>
    ///   <para>rdfs:label : U14 has tempo</para>
    ///   <a href="http://data.doremus.org/ontology#U14_has_tempo">mus:U14_has_tempo</a>
    /// </summary>
    let U14_has_tempo = _prefixId.prefix "U14_has_tempo"
    /// <summary>
    ///   <para>rdfs:label : U14i is tempo of</para>
    ///   <a href="http://data.doremus.org/ontology#U14i_is_tempo_of">mus:U14i_is_tempo_of</a>
    /// </summary>
    let U14i_is_tempo_of = _prefixId.prefix "U14i_is_tempo_of"
    /// <summary>
    ///   <para>rdfs:label : U15 has history</para>
    ///   <a href="http://data.doremus.org/ontology#U15_has_history">mus:U15_has_history</a>
    /// </summary>
    let U15_has_history = _prefixId.prefix "U15_has_history"
    /// <summary>
    ///   <para>rdfs:label : U167 has title proper</para>
    ///   <a href="http://data.doremus.org/ontology#U167_has_title_proper">mus:U167_has_title_proper</a>
    /// </summary>
    let U167_has_title_proper = _prefixId.prefix "U167_has_title_proper"
    /// <summary>
    ///   <para>rdfs:label : U167i is title proper of</para>
    ///   <a href="http://data.doremus.org/ontology#U167i_is_title_proper_of">mus:U167i_is_title_proper_of</a>
    /// </summary>
    let U167i_is_title_proper_of = _prefixId.prefix "U167i_is_title_proper_of"
    /// <summary>
    ///   <para>rdfs:label : U168 has parallel title</para>
    ///   <a href="http://data.doremus.org/ontology#U168_has_parallel_title">mus:U168_has_parallel_title</a>
    /// </summary>
    let U168_has_parallel_title = _prefixId.prefix "U168_has_parallel_title"
    /// <summary>
    ///   <para>rdfs:label : U168i is parallel title of</para>
    ///   <a href="http://data.doremus.org/ontology#U168i_is_parallel_title_of">mus:U168i_is_parallel_title_of</a>
    /// </summary>
    let U168i_is_parallel_title_of = _prefixId.prefix "U168i_is_parallel_title_of"

    /// <summary>
    ///   <para>rdfs:label : U169 was issued under label name</para>
    ///   <a href="http://data.doremus.org/ontology#U169_was_issued_under_label_name">mus:U169_was_issued_under_label_name</a>
    /// </summary>
    let U169_was_issued_under_label_name =
        _prefixId.prefix "U169_was_issued_under_label_name"

    /// <summary>
    ///   <para>rdfs:label : U16 has catalogue statement</para>
    ///   <a href="http://data.doremus.org/ontology#U16_has_catalogue_statement">mus:U16_has_catalogue_statement</a>
    /// </summary>
    let U16_has_catalogue_statement = _prefixId.prefix "U16_has_catalogue_statement"

    /// <summary>
    ///   <para>rdfs:label : U16i is catalogue statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U16i_is_catalogue_statement_of">mus:U16i_is_catalogue_statement_of</a>
    /// </summary>
    let U16i_is_catalogue_statement_of =
        _prefixId.prefix "U16i_is_catalogue_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U170 has title statement</para>
    ///   <a href="http://data.doremus.org/ontology#U170_has_title_statement">mus:U170_has_title_statement</a>
    /// </summary>
    let U170_has_title_statement = _prefixId.prefix "U170_has_title_statement"
    /// <summary>
    ///   <para>rdfs:label : U170i is title statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U170i_is_title_statement_of">mus:U170i_is_title_statement_of</a>
    /// </summary>
    let U170i_is_title_statement_of = _prefixId.prefix "U170i_is_title_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U171 has parallel title statement</para>
    ///   <a href="http://data.doremus.org/ontology#U171_has_parallel_title_statement">mus:U171_has_parallel_title_statement</a>
    /// </summary>
    let U171_has_parallel_title_statement =
        _prefixId.prefix "U171_has_parallel_title_statement"

    /// <summary>
    ///   <para>rdfs:label : U171i is parallel title statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U171i_is_parallel_title_statement_of">mus:U171i_is_parallel_title_statement_of</a>
    /// </summary>
    let U171i_is_parallel_title_statement_of =
        _prefixId.prefix "U171i_is_parallel_title_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U172 has statement of responsibility relating to title</para>
    ///   <a href="http://data.doremus.org/ontology#U172_has_statement_of_responsibility_relating_to_title">mus:U172_has_statement_of_responsibility_relating_to_title</a>
    /// </summary>
    let U172_has_statement_of_responsibility_relating_to_title =
        _prefixId.prefix "U172_has_statement_of_responsibility_relating_to_title"

    /// <summary>
    ///   <para>rdfs:label : U172i is statement of responsibility relating to title of</para>
    ///   <a href="http://data.doremus.org/ontology#U172i_is_statement_of_responsibility_relating_to_title_of">mus:U172i_is_statement_of_responsibility_relating_to_title_of</a>
    /// </summary>
    let U172i_is_statement_of_responsibility_relating_to_title_of =
        _prefixId.prefix "U172i_is_statement_of_responsibility_relating_to_title_of"

    /// <summary>
    ///   <para>rdfs:label : U173 has parallel statement of responsibility relating to title</para>
    ///   <a href="http://data.doremus.org/ontology#U173_has_parallel_statement_of_responsibility_relating_to_title">mus:U173_has_parallel_statement_of_responsibility_relating_to_title</a>
    /// </summary>
    let U173_has_parallel_statement_of_responsibility_relating_to_title =
        _prefixId.prefix "U173_has_parallel_statement_of_responsibility_relating_to_title"

    /// <summary>
    ///   <para>rdfs:label : U173i is parallel statement of responsibility relating to title of</para>
    ///   <a href="http://data.doremus.org/ontology#U173i_is_parallel_statement_of_responsibility_relating_to_title_of">mus:U173i_is_parallel_statement_of_responsibility_relating_to_title_of</a>
    /// </summary>
    let U173i_is_parallel_statement_of_responsibility_relating_to_title_of =
        _prefixId.prefix "U173i_is_parallel_statement_of_responsibility_relating_to_title_of"

    /// <summary>
    ///   <para>rdfs:label : U174 has cast statement</para>
    ///   <a href="http://data.doremus.org/ontology#U174_has_cast_statement">mus:U174_has_cast_statement</a>
    /// </summary>
    let U174_has_cast_statement = _prefixId.prefix "U174_has_cast_statement"
    /// <summary>
    ///   <para>rdfs:label : U174i is cast statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U174i_is_cast_statement_of">mus:U174i_is_cast_statement_of</a>
    /// </summary>
    let U174i_is_cast_statement_of = _prefixId.prefix "U174i_is_cast_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U175 has parallel cast statement</para>
    ///   <a href="http://data.doremus.org/ontology#U175_has_parallel_cast_statement">mus:U175_has_parallel_cast_statement</a>
    /// </summary>
    let U175_has_parallel_cast_statement =
        _prefixId.prefix "U175_has_parallel_cast_statement"

    /// <summary>
    ///   <para>rdfs:label : U175i is parallel cast statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U175i_is_parallel_cast_statement_of">mus:U175i_is_parallel_cast_statement_of</a>
    /// </summary>
    let U175i_is_parallel_cast_statement_of =
        _prefixId.prefix "U175i_is_parallel_cast_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U176 has edition statement</para>
    ///   <a href="http://data.doremus.org/ontology#U176_has_edition_statement">mus:U176_has_edition_statement</a>
    /// </summary>
    let U176_has_edition_statement = _prefixId.prefix "U176_has_edition_statement"
    /// <summary>
    ///   <para>rdfs:label : U176i is edition statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U176i_is_edition_statement_of">mus:U176i_is_edition_statement_of</a>
    /// </summary>
    let U176i_is_edition_statement_of = _prefixId.prefix "U176i_is_edition_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U177 has parallel edition statement</para>
    ///   <a href="http://data.doremus.org/ontology#U177_has_parallel_edition_statement">mus:U177_has_parallel_edition_statement</a>
    /// </summary>
    let U177_has_parallel_edition_statement =
        _prefixId.prefix "U177_has_parallel_edition_statement"

    /// <summary>
    ///   <para>rdfs:label : U177i is parallel edition statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U177i_is_parallel_edition_statement_of">mus:U177i_is_parallel_edition_statement_of</a>
    /// </summary>
    let U177i_is_parallel_edition_statement_of =
        _prefixId.prefix "U177i_is_parallel_edition_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U178 has statement of responsibility relating to edition</para>
    ///   <a href="http://data.doremus.org/ontology#U178_has_statement_of_responsibility_relating_to_edition">mus:U178_has_statement_of_responsibility_relating_to_edition</a>
    /// </summary>
    let U178_has_statement_of_responsibility_relating_to_edition =
        _prefixId.prefix "U178_has_statement_of_responsibility_relating_to_edition"

    /// <summary>
    ///   <para>rdfs:label : U178i is statement of responsibility relating to edition of</para>
    ///   <a href="http://data.doremus.org/ontology#U178i_is_statement_of_responsibility_relating_to_edition_of">mus:U178i_is_statement_of_responsibility_relating_to_edition_of</a>
    /// </summary>
    let U178i_is_statement_of_responsibility_relating_to_edition_of =
        _prefixId.prefix "U178i_is_statement_of_responsibility_relating_to_edition_of"

    /// <summary>
    ///   <para>rdfs:label : U179 has parallel statement of responsibility relating to edition</para>
    ///   <a href="http://data.doremus.org/ontology#U179_has_parallel_statement_of_responsibility_relating_to_edition">mus:U179_has_parallel_statement_of_responsibility_relating_to_edition</a>
    /// </summary>
    let U179_has_parallel_statement_of_responsibility_relating_to_edition =
        _prefixId.prefix "U179_has_parallel_statement_of_responsibility_relating_to_edition"

    /// <summary>
    ///   <para>rdfs:label : U179i is parallel statement of responsibility relating to edition of</para>
    ///   <a href="http://data.doremus.org/ontology#U179i_is_parallel_statement_of_responsibility_relating_to_edition_of">mus:U179i_is_parallel_statement_of_responsibility_relating_to_edition_of</a>
    /// </summary>
    let U179i_is_parallel_statement_of_responsibility_relating_to_edition_of =
        _prefixId.prefix "U179i_is_parallel_statement_of_responsibility_relating_to_edition_of"

    /// <summary>
    ///   <para>rdfs:label : U17 has opus statement</para>
    ///   <a href="http://data.doremus.org/ontology#U17_has_opus_statement">mus:U17_has_opus_statement</a>
    /// </summary>
    let U17_has_opus_statement = _prefixId.prefix "U17_has_opus_statement"
    /// <summary>
    ///   <para>rdfs:label : U17i is opus statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U17i_is_opus_statement_of">mus:U17i_is_opus_statement_of</a>
    /// </summary>
    let U17i_is_opus_statement_of = _prefixId.prefix "U17i_is_opus_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U180 has additional edition statement</para>
    ///   <a href="http://data.doremus.org/ontology#U180_has_additional_edition_statement">mus:U180_has_additional_edition_statement</a>
    /// </summary>
    let U180_has_additional_edition_statement =
        _prefixId.prefix "U180_has_additional_edition_statement"

    /// <summary>
    ///   <para>rdfs:label : U180i is additional edition statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U180i_is_additional_edition_statement_of">mus:U180i_is_additional_edition_statement_of</a>
    /// </summary>
    let U180i_is_additional_edition_statement_of =
        _prefixId.prefix "U180i_is_additional_edition_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U181 has parallel additional edition statement</para>
    ///   <a href="http://data.doremus.org/ontology#U181_has_parallel_additional_edition_statement">mus:U181_has_parallel_additional_edition_statement</a>
    /// </summary>
    let U181_has_parallel_additional_edition_statement =
        _prefixId.prefix "U181_has_parallel_additional_edition_statement"

    /// <summary>
    ///   <para>rdfs:label : U181i is parallel additional edition statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U181i_is_parallel_additional_edition_statement_of">mus:U181i_is_parallel_additional_edition_statement_of</a>
    /// </summary>
    let U181i_is_parallel_additional_edition_statement_of =
        _prefixId.prefix "U181i_is_parallel_additional_edition_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U182 has music format statement</para>
    ///   <a href="http://data.doremus.org/ontology#U182_has_music_format_statement">mus:U182_has_music_format_statement</a>
    /// </summary>
    let U182_has_music_format_statement =
        _prefixId.prefix "U182_has_music_format_statement"

    /// <summary>
    ///   <para>rdfs:label : U182i is music format statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U182i_is_music_format_statement_of">mus:U182i_is_music_format_statement_of</a>
    /// </summary>
    let U182i_is_music_format_statement_of =
        _prefixId.prefix "U182i_is_music_format_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U183 has parallel music format statement</para>
    ///   <a href="http://data.doremus.org/ontology#U183_has_parallel_music_format_statement">mus:U183_has_parallel_music_format_statement</a>
    /// </summary>
    let U183_has_parallel_music_format_statement =
        _prefixId.prefix "U183_has_parallel_music_format_statement"

    /// <summary>
    ///   <para>rdfs:label : U183i is parallel music format statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U183i_is_parallel_music_format_statement_of">mus:U183i_is_parallel_music_format_statement_of</a>
    /// </summary>
    let U183i_is_parallel_music_format_statement_of =
        _prefixId.prefix "U183i_is_parallel_music_format_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U184 has publication statement</para>
    ///   <a href="http://data.doremus.org/ontology#U184_has_publication_statement">mus:U184_has_publication_statement</a>
    /// </summary>
    let U184_has_publication_statement =
        _prefixId.prefix "U184_has_publication_statement"

    /// <summary>
    ///   <para>rdfs:label : U184i is publication statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U184i_is_publication_statement_of">mus:U184i_is_publication_statement_of</a>
    /// </summary>
    let U184i_is_publication_statement_of =
        _prefixId.prefix "U184i_is_publication_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U185 has distribution statement</para>
    ///   <a href="http://data.doremus.org/ontology#U185_has_distribution_statement">mus:U185_has_distribution_statement</a>
    /// </summary>
    let U185_has_distribution_statement =
        _prefixId.prefix "U185_has_distribution_statement"

    /// <summary>
    ///   <para>rdfs:label : U185i is distribution statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U185i_is_distribution_statement_of">mus:U185i_is_distribution_statement_of</a>
    /// </summary>
    let U185i_is_distribution_statement_of =
        _prefixId.prefix "U185i_is_distribution_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U186 has printing or manufacture statement</para>
    ///   <a href="http://data.doremus.org/ontology#U186_has_printing_or_manufacture_statement">mus:U186_has_printing_or_manufacture_statement</a>
    /// </summary>
    let U186_has_printing_or_manufacture_statement =
        _prefixId.prefix "U186_has_printing_or_manufacture_statement"

    /// <summary>
    ///   <para>rdfs:label : U186i is printing or manufacture statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U186i_is_printing_or_manufacture_statement_of">mus:U186i_is_printing_or_manufacture_statement_of</a>
    /// </summary>
    let U186i_is_printing_or_manufacture_statement_of =
        _prefixId.prefix "U186i_is_printing_or_manufacture_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U187 has multipart monograph statement</para>
    ///   <a href="http://data.doremus.org/ontology#U187_has_multipart_monographs_statement">mus:U187_has_multipart_monographs_statement</a>
    /// </summary>
    let U187_has_multipart_monographs_statement =
        _prefixId.prefix "U187_has_multipart_monographs_statement"

    /// <summary>
    ///   <para>rdfs:label : U188 has series statement</para>
    ///   <a href="http://data.doremus.org/ontology#U188_has_series_statement">mus:U188_has_series_statement</a>
    /// </summary>
    let U188_has_series_statement = _prefixId.prefix "U188_has_series_statement"
    /// <summary>
    ///   <para>rdfs:label : U188i is series statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U188i_is_series_statement_of">mus:U188i_is_series_statement_of</a>
    /// </summary>
    let U188i_is_series_statement_of = _prefixId.prefix "U188i_is_series_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U189 has main series statement</para>
    ///   <a href="http://data.doremus.org/ontology#U189_has_main_series_statement">mus:U189_has_main_series_statement</a>
    /// </summary>
    let U189_has_main_series_statement =
        _prefixId.prefix "U189_has_main_series_statement"

    /// <summary>
    ///   <para>rdfs:label : U18 has rhythmic pattern</para>
    ///   <a href="http://data.doremus.org/ontology#U18_has_rhythmic_pattern">mus:U18_has_rhythmic_pattern</a>
    /// </summary>
    let U18_has_rhythmic_pattern = _prefixId.prefix "U18_has_rhythmic_pattern"
    /// <summary>
    ///   <para>rdfs:label : U18i is rhythmic pattern of</para>
    ///   <a href="http://data.doremus.org/ontology#U18i_is_rhythmic_pattern_of">mus:U18i_is_rhythmic_pattern_of</a>
    /// </summary>
    let U18i_is_rhythmic_pattern_of = _prefixId.prefix "U18i_is_rhythmic_pattern_of"

    /// <summary>
    ///   <para>rdfs:label : U191 used equalization technique</para>
    ///   <a href="http://data.doremus.org/ontology#U191_used_equalization_technique">mus:U191_used_equalization_technique</a>
    /// </summary>
    let U191_used_equalization_technique =
        _prefixId.prefix "U191_used_equalization_technique"

    /// <summary>
    ///   <para>rdfs:label : U191i was technique of equalization</para>
    ///   <a href="http://data.doremus.org/ontology#U191i_was_technique_of_equalization">mus:U191i_was_technique_of_equalization</a>
    /// </summary>
    let U191i_was_technique_of_equalization =
        _prefixId.prefix "U191i_was_technique_of_equalization"

    /// <summary>
    ///   <para>rdfs:label : U192 used noise reduction technique</para>
    ///   <a href="http://data.doremus.org/ontology#U192_used_noise_reduction_technique">mus:U192_used_noise_reduction_technique</a>
    /// </summary>
    let U192_used_noise_reduction_technique =
        _prefixId.prefix "U192_used_noise_reduction_technique"

    /// <summary>
    ///   <para>rdfs:label : U192i was technique of noise reduction</para>
    ///   <a href="http://data.doremus.org/ontology#U192i_was_technique_of_noise_reduction">mus:U192i_was_technique_of_noise_reduction</a>
    /// </summary>
    let U192i_was_technique_of_noise_reduction =
        _prefixId.prefix "U192i_was_technique_of_noise_reduction"

    /// <summary>
    ///   <para>rdfs:label : U193 used historical instruments</para>
    ///   <a href="http://data.doremus.org/ontology#U193_used_historical_instruments">mus:U193_used_historical_instruments</a>
    /// </summary>
    let U193_used_historical_instruments =
        _prefixId.prefix "U193_used_historical_instruments"

    /// <summary>
    ///   <para>rdfs:label : U194 has system requirements</para>
    ///   <a href="http://data.doremus.org/ontology#U194_has_system_requirements">mus:U194_has_system_requirements</a>
    /// </summary>
    let U194_has_system_requirements = _prefixId.prefix "U194_has_system_requirements"

    /// <summary>
    ///   <para>rdfs:label : U195 has order or location indication</para>
    ///   <a href="http://data.doremus.org/ontology#U195_has_order_or_location_indication">mus:U195_has_order_or_location_indication</a>
    /// </summary>
    let U195_has_order_or_location_indication =
        _prefixId.prefix "U195_has_order_or_location_indication"

    /// <summary>
    ///   <para>rdfs:label : U197 has binding</para>
    ///   <a href="http://data.doremus.org/ontology#U197_has_binding">mus:U197_has_binding</a>
    /// </summary>
    let U197_has_binding = _prefixId.prefix "U197_has_binding"
    /// <summary>
    ///   <para>rdfs:label : U197i is binding of</para>
    ///   <a href="http://data.doremus.org/ontology#U197i_is_binding_of">mus:U197i_is_binding_of</a>
    /// </summary>
    let U197i_is_binding_of = _prefixId.prefix "U197i_is_binding_of"
    /// <summary>
    ///   <para>rdfs:label : U198 has container</para>
    ///   <a href="http://data.doremus.org/ontology#U198_has_container">mus:U198_has_container</a>
    /// </summary>
    let U198_has_container = _prefixId.prefix "U198_has_container"
    /// <summary>
    ///   <para>rdfs:label : U199 has sponsor</para>
    ///   <a href="http://data.doremus.org/ontology#U199_has_sponsor">mus:U199_has_sponsor</a>
    /// </summary>
    let U199_has_sponsor = _prefixId.prefix "U199_has_sponsor"
    /// <summary>
    ///   <para>rdfs:label : U19 is categorized as</para>
    ///   <a href="http://data.doremus.org/ontology#U19_is_categorized_as">mus:U19_is_categorized_as</a>
    /// </summary>
    let U19_is_categorized_as = _prefixId.prefix "U19_is_categorized_as"
    /// <summary>
    ///   <para>rdfs:label : U19i categorizes</para>
    ///   <a href="http://data.doremus.org/ontology#U19i_categorizes">mus:U19i_categorizes</a>
    /// </summary>
    let U19i_categorizes = _prefixId.prefix "U19i_categorizes"
    /// <summary>
    ///   <para>rdfs:label : U1 used medium of performance</para>
    ///   <para>rdfs:comment : U1 instrument ou voix utilisé pour la performance</para>
    ///   <a href="http://data.doremus.org/ontology#U1_used_medium_of_performance">mus:U1_used_medium_of_performance</a>
    /// </summary>
    let U1_used_medium_of_performance = _prefixId.prefix "U1_used_medium_of_performance"

    /// <summary>
    ///   <para>rdfs:label : U1i medium of performance was used in</para>
    ///   <a href="http://data.doremus.org/ontology#U1i_medium_of_performance_was_used_in">mus:U1i_medium_of_performance_was_used_in</a>
    /// </summary>
    let U1i_medium_of_performance_was_used_in =
        _prefixId.prefix "U1i_medium_of_performance_was_used_in"

    /// <summary>
    ///   <para>rdfs:label : U200 has supplementary content</para>
    ///   <a href="http://data.doremus.org/ontology#U200_has_supplementary_content">mus:U200_has_supplementary_content</a>
    /// </summary>
    let U200_has_supplementary_content =
        _prefixId.prefix "U200_has_supplementary_content"

    /// <summary>
    ///   <para>rdfs:label : U201 has illustrative content</para>
    ///   <a href="http://data.doremus.org/ontology#U201_has_illustrative_content">mus:U201_has_illustrative_content</a>
    /// </summary>
    let U201_has_illustrative_content = _prefixId.prefix "U201_has_illustrative_content"
    /// <summary>
    ///   <para>rdfs:label : U202 has colour details</para>
    ///   <a href="http://data.doremus.org/ontology#U202_has_colour_details">mus:U202_has_colour_details</a>
    /// </summary>
    let U202_has_colour_details = _prefixId.prefix "U202_has_colour_details"
    /// <summary>
    ///   <para>rdfs:label : U203 has summary or abstract</para>
    ///   <a href="http://data.doremus.org/ontology#U203_has_summary_or_abstract">mus:U203_has_summary_or_abstract</a>
    /// </summary>
    let U203_has_summary_or_abstract = _prefixId.prefix "U203_has_summary_or_abstract"
    /// <summary>
    ///   <para>rdfs:label : U204 has reproduction note</para>
    ///   <a href="http://data.doremus.org/ontology#U204_has_reproduction_note">mus:U204_has_reproduction_note</a>
    /// </summary>
    let U204_has_reproduction_note = _prefixId.prefix "U204_has_reproduction_note"
    /// <summary>
    ///   <para>rdfs:label : U205 has cast detail</para>
    ///   <a href="http://data.doremus.org/ontology#U205_has_cast_detail">mus:U205_has_cast_detail</a>
    /// </summary>
    let U205_has_cast_detail = _prefixId.prefix "U205_has_cast_detail"
    /// <summary>
    ///   <para>rdfs:label : U206 has media type</para>
    ///   <a href="http://data.doremus.org/ontology#U206_has_media_type">mus:U206_has_media_type</a>
    /// </summary>
    let U206_has_media_type = _prefixId.prefix "U206_has_media_type"
    /// <summary>
    ///   <para>rdfs:label : U206i is media type of</para>
    ///   <a href="http://data.doremus.org/ontology#U206i_is_media_type_of">mus:U206i_is_media_type_of</a>
    /// </summary>
    let U206i_is_media_type_of = _prefixId.prefix "U206i_is_media_type_of"
    /// <summary>
    ///   <para>rdfs:label : U207 has  carrier type</para>
    ///   <a href="http://data.doremus.org/ontology#U207_has_carrier_type">mus:U207_has_carrier_type</a>
    /// </summary>
    let U207_has_carrier_type = _prefixId.prefix "U207_has_carrier_type"
    /// <summary>
    ///   <para>rdfs:label : U208 has extent of carrier</para>
    ///   <a href="http://data.doremus.org/ontology#U208_has_extent_of_carrier">mus:U208_has_extent_of_carrier</a>
    /// </summary>
    let U208_has_extent_of_carrier = _prefixId.prefix "U208_has_extent_of_carrier"
    /// <summary>
    ///   <para>rdfs:label : U20 has music group formation</para>
    ///   <a href="http://data.doremus.org/ontology#U20_has_music_group_formation">mus:U20_has_music_group_formation</a>
    /// </summary>
    let U20_has_music_group_formation = _prefixId.prefix "U20_has_music_group_formation"

    /// <summary>
    ///   <para>rdfs:label : U20i is music group formation of</para>
    ///   <a href="http://data.doremus.org/ontology#U20i_is_music_group_formation_of">mus:U20i_is_music_group_formation_of</a>
    /// </summary>
    let U20i_is_music_group_formation_of =
        _prefixId.prefix "U20i_is_music_group_formation_of"

    /// <summary>
    ///   <para>rdfs:label : U210 has pagination</para>
    ///   <a href="http://data.doremus.org/ontology#U210_has_pagination">mus:U210_has_pagination</a>
    /// </summary>
    let U210_has_pagination = _prefixId.prefix "U210_has_pagination"
    /// <summary>
    ///   <para>rdfs:label : U210i is pagination of</para>
    ///   <a href="http://data.doremus.org/ontology#U210i_is_pagination_of">mus:U210i_is_pagination_of</a>
    /// </summary>
    let U210i_is_pagination_of = _prefixId.prefix "U210i_is_pagination_of"

    /// <summary>
    ///   <para>rdfs:label : U211 has composition of material</para>
    ///   <a href="http://data.doremus.org/ontology#U211_has_composition_of_material">mus:U211_has_composition_of_material</a>
    /// </summary>
    let U211_has_composition_of_material =
        _prefixId.prefix "U211_has_composition_of_material"

    /// <summary>
    ///   <para>rdfs:label : U212 has technical features</para>
    ///   <a href="http://data.doremus.org/ontology#U212_has_technical_features">mus:U212_has_technical_features</a>
    /// </summary>
    let U212_has_technical_features = _prefixId.prefix "U212_has_technical_features"
    /// <summary>
    ///   <para>rdfs:label : U213 has recording method</para>
    ///   <a href="http://data.doremus.org/ontology#U213_has_recording_method">mus:U213_has_recording_method</a>
    /// </summary>
    let U213_has_recording_method = _prefixId.prefix "U213_has_recording_method"
    /// <summary>
    ///   <para>rdfs:label : U214 has colour content</para>
    ///   <a href="http://data.doremus.org/ontology#U214_has_colour_content">mus:U214_has_colour_content</a>
    /// </summary>
    let U214_has_colour_content = _prefixId.prefix "U214_has_colour_content"

    /// <summary>
    ///   <para>rdfs:label : U215  has groove caracteristics</para>
    ///   <a href="http://data.doremus.org/ontology#U215_has_groove_caracteristics">mus:U215_has_groove_caracteristics</a>
    /// </summary>
    let U215_has_groove_caracteristics =
        _prefixId.prefix "U215_has_groove_caracteristics"

    /// <summary>
    ///   <para>rdfs:label : U216 has tape configuration</para>
    ///   <a href="http://data.doremus.org/ontology#U216_has_tape_configuration">mus:U216_has_tape_configuration</a>
    /// </summary>
    let U216_has_tape_configuration = _prefixId.prefix "U216_has_tape_configuration"
    /// <summary>
    ///   <para>rdfs:label : U217 has playing speed</para>
    ///   <a href="http://data.doremus.org/ontology#U217_has_playing_speed">mus:U217_has_playing_speed</a>
    /// </summary>
    let U217_has_playing_speed = _prefixId.prefix "U217_has_playing_speed"

    /// <summary>
    ///   <para>rdfs:label : U218 used object of type for mastering</para>
    ///   <a href="http://data.doremus.org/ontology#U218_used_object_of_type_for_mastering">mus:U218_used_object_of_type_for_mastering</a>
    /// </summary>
    let U218_used_object_of_type_for_mastering =
        _prefixId.prefix "U218_used_object_of_type_for_mastering"

    /// <summary>
    ///   <para>rdfs:label : U219 used object of type for mixing</para>
    ///   <a href="http://data.doremus.org/ontology#U219_used_object_of_type_for_mixing">mus:U219_used_object_of_type_for_mixing</a>
    /// </summary>
    let U219_used_object_of_type_for_mixing =
        _prefixId.prefix "U219_used_object_of_type_for_mixing"

    /// <summary>
    ///   <para>rdfs:label : U21 is about actor</para>
    ///   <a href="http://data.doremus.org/ontology#U21_is_about_actor">mus:U21_is_about_actor</a>
    /// </summary>
    let U21_is_about_actor = _prefixId.prefix "U21_is_about_actor"
    /// <summary>
    ///   <para>rdfs:label : U21i actor is subject of</para>
    ///   <a href="http://data.doremus.org/ontology#U21i_actor_is_subject_of">mus:U21i_actor_is_subject_of</a>
    /// </summary>
    let U21i_actor_is_subject_of = _prefixId.prefix "U21i_actor_is_subject_of"

    /// <summary>
    ///   <para>rdfs:label : U220 has title and statement of responsibility</para>
    ///   <a href="http://data.doremus.org/ontology#U220_has_title_and_statement_of_responsibility">mus:U220_has_title_and_statement_of_responsibility</a>
    /// </summary>
    let U220_has_title_and_statement_of_responsibility =
        _prefixId.prefix "U220_has_title_and_statement_of_responsibility"

    /// <summary>
    ///   <para>rdfs:label : U220i is title and statement of responsibility of</para>
    ///   <a href="http://data.doremus.org/ontology#U220i_is_title_and_statement_of_responsibility_of">mus:U220i_is_title_and_statement_of_responsibility_of</a>
    /// </summary>
    let U220i_is_title_and_statement_of_responsibility_of =
        _prefixId.prefix "U220i_is_title_and_statement_of_responsibility_of"

    /// <summary>
    ///   <para>rdfs:label : U221 has title proper of series</para>
    ///   <a href="http://data.doremus.org/ontology#U221_has_title_proper_of_series">mus:U221_has_title_proper_of_series</a>
    /// </summary>
    let U221_has_title_proper_of_series =
        _prefixId.prefix "U221_has_title_proper_of_series"

    /// <summary>
    ///   <para>rdfs:label : U221i is  title proper of series of</para>
    ///   <a href="http://data.doremus.org/ontology#U221i_is_title_proper_of_series_of">mus:U221i_is_title_proper_of_series_of</a>
    /// </summary>
    let U221i_is_title_proper_of_series_of =
        _prefixId.prefix "U221i_is_title_proper_of_series_of"

    /// <summary>
    ///   <para>rdfs:label : U222 has title proper of sub-series</para>
    ///   <a href="http://data.doremus.org/ontology#U222_has_title_proper_of_sub-series">mus:U222_has_title_proper_of_sub-series</a>
    /// </summary>
    let U222_has_title_proper_of_sub_series =
        _prefixId.prefix "U222_has_title_proper_of_sub-series"

    /// <summary>
    ///   <para>rdfs:label : U222i is title proper of sub-series of</para>
    ///   <a href="http://data.doremus.org/ontology#U222i_is_title_proper_of_sub-series_of">mus:U222i_is_title_proper_of_sub-series_of</a>
    /// </summary>
    let U222i_is_title_proper_of_sub_series_of =
        _prefixId.prefix "U222i_is_title_proper_of_sub-series_of"

    /// <summary>
    ///   <para>rdfs:label : U223 has number of tape tracks</para>
    ///   <a href="http://data.doremus.org/ontology#U223_has_number_of_tape_tracks">mus:U223_has_number_of_tape_tracks</a>
    /// </summary>
    let U223_has_number_of_tape_tracks =
        _prefixId.prefix "U223_has_number_of_tape_tracks"

    /// <summary>
    ///   <para>rdfs:label : U223i is number of tape tracks of</para>
    ///   <a href="http://data.doremus.org/ontology#U223i_is_number_of_tape_tracks_of">mus:U223i_is_number_of_tape_tracks_of</a>
    /// </summary>
    let U223i_is_number_of_tape_tracks_of =
        _prefixId.prefix "U223i_is_number_of_tape_tracks_of"

    /// <summary>
    ///   <para>rdfs:label : U224 has title proper of multipart monograph</para>
    ///   <a href="http://data.doremus.org/ontology#U224_has_title_proper_of_multipart_monograph">mus:U224_has_title_proper_of_multipart_monograph</a>
    /// </summary>
    let U224_has_title_proper_of_multipart_monograph =
        _prefixId.prefix "U224_has_title_proper_of_multipart_monograph"

    /// <summary>
    ///   <para>rdfs:label : U224i is title proper of multipart monograph of</para>
    ///   <a href="http://data.doremus.org/ontology#U224i_is_title_proper_of_multipart_monograph_of">mus:U224i_is_title_proper_of_multipart_monograph_of</a>
    /// </summary>
    let U224i_is_title_proper_of_multipart_monograph_of =
        _prefixId.prefix "U224i_is_title_proper_of_multipart_monograph_of"

    /// <summary>
    ///   <para>rdfs:label : U225 used number of sound channels</para>
    ///   <a href="http://data.doremus.org/ontology#U225_used_sound_spatialization_technique">mus:U225_used_sound_spatialization_technique</a>
    /// </summary>
    let U225_used_sound_spatialization_technique =
        _prefixId.prefix "U225_used_sound_spatialization_technique"

    /// <summary>
    ///   <para>rdfs:label : U225i was sound spatialization technique of</para>
    ///   <a href="http://data.doremus.org/ontology#U225i_was_sound_spatialization_technique_of">mus:U225i_was_sound_spatialization_technique_of</a>
    /// </summary>
    let U225i_was_sound_spatialization_technique_of =
        _prefixId.prefix "U225i_was_sound_spatialization_technique_of"

    /// <summary>
    ///   <para>rdfs:label : U226 has responsibility detail</para>
    ///   <a href="http://data.doremus.org/ontology#U226_has_responsibility_detail">mus:U226_has_responsibility_detail</a>
    /// </summary>
    let U226_has_responsibility_detail =
        _prefixId.prefix "U226_has_responsibility_detail"

    /// <summary>
    ///   <para>rdfs:label : U227 has content type</para>
    ///   <a href="http://data.doremus.org/ontology#U227_has_content_type">mus:U227_has_content_type</a>
    /// </summary>
    let U227_has_content_type = _prefixId.prefix "U227_has_content_type"
    let U227i_is_content_type_of = _prefixId.prefix "U227i_is_content_type_of"

    /// <summary>
    ///   <para>rdfs:label : U226 has other distinguishing characteristic of expression</para>
    ///   <a href="http://data.doremus.org/ontology#U228_has_other_distinguishing_characteristic_of_expression">mus:U228_has_other_distinguishing_characteristic_of_expression</a>
    /// </summary>
    let U228_has_other_distinguishing_characteristic_of_expression =
        _prefixId.prefix "U228_has_other_distinguishing_characteristic_of_expression"

    /// <summary>
    ///   <para>rdfs:label : U229 has music format</para>
    ///   <a href="http://data.doremus.org/ontology#U229_has_music_format">mus:U229_has_music_format</a>
    /// </summary>
    let U229_has_music_format = _prefixId.prefix "U229_has_music_format"
    let U229i_is_music_format_of = _prefixId.prefix "U229i_is_music_format_of"
    /// <summary>
    ///   <para>rdfs:label : U22 is about place</para>
    ///   <a href="http://data.doremus.org/ontology#U22_is_about_place">mus:U22_is_about_place</a>
    /// </summary>
    let U22_is_about_place = _prefixId.prefix "U22_is_about_place"
    /// <summary>
    ///   <para>rdfs:label : U22i place is subject of</para>
    ///   <a href="http://data.doremus.org/ontology#U22i_place_is_subject_of">mus:U22i_place_is_subject_of</a>
    /// </summary>
    let U22i_place_is_subject_of = _prefixId.prefix "U22i_place_is_subject_of"
    /// <summary>
    ///   <para>rdfs:label : U23 has casting detail</para>
    ///   <a href="http://data.doremus.org/ontology#U23_has_casting_detail">mus:U23_has_casting_detail</a>
    /// </summary>
    let U23_has_casting_detail = _prefixId.prefix "U23_has_casting_detail"
    /// <summary>
    ///   <para>rdfs:label : U23i is casting detail of</para>
    ///   <a href="http://data.doremus.org/ontology#U23i_is_casting_detail_of">mus:U23i_is_casting_detail_of</a>
    /// </summary>
    let U23i_is_casting_detail_of = _prefixId.prefix "U23i_is_casting_detail_of"
    /// <summary>
    ///   <para>rdfs:label : U24 has award</para>
    ///   <a href="http://data.doremus.org/ontology#U24_has_award">mus:U24_has_award</a>
    /// </summary>
    let U24_has_award = _prefixId.prefix "U24_has_award"
    /// <summary>
    ///   <para>rdfs:label : U24i is award of</para>
    ///   <a href="http://data.doremus.org/ontology#U24i_is_award_of">mus:U24i_is_award_of</a>
    /// </summary>
    let U24i_is_award_of = _prefixId.prefix "U24i_is_award_of"
    /// <summary>
    ///   <para>rdfs:label : U25 has scale</para>
    ///   <a href="http://data.doremus.org/ontology#U25_has_scale">mus:U25_has_scale</a>
    /// </summary>
    let U25_has_scale = _prefixId.prefix "U25_has_scale"
    /// <summary>
    ///   <para>rdfs:label : U25i is scale of</para>
    ///   <a href="http://data.doremus.org/ontology#U25i_is_scale_of">mus:U25i_is_scale_of</a>
    /// </summary>
    let U25i_is_scale_of = _prefixId.prefix "U25i_is_scale_of"
    /// <summary>
    ///   <para>rdfs:label : U26 has maintained</para>
    ///   <a href="http://data.doremus.org/ontology#U26_has_maintained">mus:U26_has_maintained</a>
    /// </summary>
    let U26_has_maintained = _prefixId.prefix "U26_has_maintained"
    /// <summary>
    ///   <para>rdfs:label : U26i was maintained by</para>
    ///   <a href="http://data.doremus.org/ontology#U26i_was_maintained_by">mus:U26i_was_maintained_by</a>
    /// </summary>
    let U26i_was_maintained_by = _prefixId.prefix "U26i_was_maintained_by"
    /// <summary>
    ///   <para>rdfs:label : U27 performed character</para>
    ///   <a href="http://data.doremus.org/ontology#U27_performed_character">mus:U27_performed_character</a>
    /// </summary>
    let U27_performed_character = _prefixId.prefix "U27_performed_character"

    /// <summary>
    ///   <para>rdfs:label : U27i character was performed by</para>
    ///   <a href="http://data.doremus.org/ontology#U27i_character_was_performed_by">mus:U27i_character_was_performed_by</a>
    /// </summary>
    let U27i_character_was_performed_by =
        _prefixId.prefix "U27i_character_was_performed_by"

    /// <summary>
    ///   <para>rdfs:label : U28 has ambitus</para>
    ///   <para>rdfs:comment : scope note: this property allows for describing the tessitura of a character, as can be drawn from the score.</para>
    ///   <a href="http://data.doremus.org/ontology#U28_has_ambitus">mus:U28_has_ambitus</a>
    /// </summary>
    let U28_has_ambitus = _prefixId.prefix "U28_has_ambitus"
    /// <summary>
    ///   <para>rdfs:label : U28i is ambitus of</para>
    ///   <a href="http://data.doremus.org/ontology#U28i_is_ambitus_of">mus:U28i_is_ambitus_of</a>
    /// </summary>
    let U28i_is_ambitus_of = _prefixId.prefix "U28i_is_ambitus_of"
    /// <summary>
    ///   <para>rdfs:label : U29 edited</para>
    ///   <a href="http://data.doremus.org/ontology#U29_edited">mus:U29_edited</a>
    /// </summary>
    let U29_edited = _prefixId.prefix "U29_edited"
    /// <summary>
    ///   <para>rdfs:label : U29i was edited by</para>
    ///   <a href="http://data.doremus.org/ontology#U29i_was_edited_by">mus:U29i_was_edited_by</a>
    /// </summary>
    let U29i_was_edited_by = _prefixId.prefix "U29i_was_edited_by"

    /// <summary>
    ///   <para>rdfs:label : U2 instrument ou voix prévu pour la performancerdfs:label : U2 foresees use of medium of performance</para>
    ///   <a href="http://data.doremus.org/ontology#U2_foresees_use_of_medium_of_performance">mus:U2_foresees_use_of_medium_of_performance</a>
    /// </summary>
    let U2_foresees_use_of_medium_of_performance =
        _prefixId.prefix "U2_foresees_use_of_medium_of_performance"

    /// <summary>
    ///   <para>rdfs:label : U2i is foreseen type of medium of performance inrdfs:label : U2i est le type d'instrument ou de voix prévu pour</para>
    ///   <a href="http://data.doremus.org/ontology#U2i_is_foreseen_type_of_medium_of_performance_in">mus:U2i_is_foreseen_type_of_medium_of_performance_in</a>
    /// </summary>
    let U2i_is_foreseen_type_of_medium_of_performance_in =
        _prefixId.prefix "U2i_is_foreseen_type_of_medium_of_performance_in"

    /// <summary>
    ///   <para>rdfs:label : U30 foresees quantity of medium of performance</para>
    ///   <a href="http://data.doremus.org/ontology#U30_foresees_quantity_of_mop">mus:U30_foresees_quantity_of_mop</a>
    /// </summary>
    let U30_foresees_quantity_of_mop = _prefixId.prefix "U30_foresees_quantity_of_mop"
    /// <summary>
    ///   <para>rdfs:label : U31 had function</para>
    ///   <a href="http://data.doremus.org/ontology#U31_had_function">mus:U31_had_function</a>
    /// </summary>
    let U31_had_function = _prefixId.prefix "U31_had_function"
    /// <summary>
    ///   <para>rdfs:label : U31i was function of</para>
    ///   <a href="http://data.doremus.org/ontology#U31i_was_function_of">mus:U31i_was_function_of</a>
    /// </summary>
    let U31i_was_function_of = _prefixId.prefix "U31i_was_function_of"
    /// <summary>
    ///   <para>rdfs:label : U32 had responsibility</para>
    ///   <a href="http://data.doremus.org/ontology#U32_had_responsibility">mus:U32_had_responsibility</a>
    /// </summary>
    let U32_had_responsibility = _prefixId.prefix "U32_had_responsibility"
    /// <summary>
    ///   <para>rdfs:label : U32i was responsibility of</para>
    ///   <a href="http://data.doremus.org/ontology#U32i_was_responsibility_of">mus:U32i_was_responsibility_of</a>
    /// </summary>
    let U32i_was_responsibility_of = _prefixId.prefix "U32i_was_responsibility_of"
    /// <summary>
    ///   <para>rdfs:label : U33 has set of characters</para>
    ///   <a href="http://data.doremus.org/ontology#U33_has_set_of_characters">mus:U33_has_set_of_characters</a>
    /// </summary>
    let U33_has_set_of_characters = _prefixId.prefix "U33_has_set_of_characters"
    /// <summary>
    ///   <para>rdfs:label : U33i is set of characters of</para>
    ///   <a href="http://data.doremus.org/ontology#U33i_is_set_of_characters_of">mus:U33i_is_set_of_characters_of</a>
    /// </summary>
    let U33i_is_set_of_characters_of = _prefixId.prefix "U33i_is_set_of_characters_of"
    /// <summary>
    ///   <para>rdfs:label : U34 foresees character</para>
    ///   <a href="http://data.doremus.org/ontology#U34_foresees_character">mus:U34_foresees_character</a>
    /// </summary>
    let U34_foresees_character = _prefixId.prefix "U34_foresees_character"
    /// <summary>
    ///   <para>rdfs:label : U34i is foreseen character of</para>
    ///   <a href="http://data.doremus.org/ontology#U34i_is_foreseen_character_of">mus:U34i_is_foreseen_character_of</a>
    /// </summary>
    let U34i_is_foreseen_character_of = _prefixId.prefix "U34i_is_foreseen_character_of"
    /// <summary>
    ///   <para>rdfs:label : U35 foresees function</para>
    ///   <a href="http://data.doremus.org/ontology#U35_foresees_function">mus:U35_foresees_function</a>
    /// </summary>
    let U35_foresees_function = _prefixId.prefix "U35_foresees_function"
    /// <summary>
    ///   <para>rdfs:label : U35i is foreseen function of</para>
    ///   <a href="http://data.doremus.org/ontology#U35i_is_foreseen_function_of">mus:U35i_is_foreseen_function_of</a>
    /// </summary>
    let U35i_is_foreseen_function_of = _prefixId.prefix "U35i_is_foreseen_function_of"
    /// <summary>
    ///   <para>rdfs:label : U36 foresees responsibility</para>
    ///   <a href="http://data.doremus.org/ontology#U36_foresees_responsibility">mus:U36_foresees_responsibility</a>
    /// </summary>
    let U36_foresees_responsibility = _prefixId.prefix "U36_foresees_responsibility"

    /// <summary>
    ///   <para>rdfs:label : U36i is foreseen responsibility of</para>
    ///   <a href="http://data.doremus.org/ontology#U36i_is_foreseen_responsibility_of">mus:U36i_is_foreseen_responsibility_of</a>
    /// </summary>
    let U36i_is_foreseen_responsibility_of =
        _prefixId.prefix "U36i_is_foreseen_responsibility_of"

    /// <summary>
    ///   <para>rdfs:label : U37 foresees performing character</para>
    ///   <a href="http://data.doremus.org/ontology#U37_foresees_performing_character">mus:U37_foresees_performing_character</a>
    /// </summary>
    let U37_foresees_performing_character =
        _prefixId.prefix "U37_foresees_performing_character"

    /// <summary>
    ///   <para>rdfs:label : U37i is foreseen character in</para>
    ///   <a href="http://data.doremus.org/ontology#U37i_is_foreseen_character_in">mus:U37i_is_foreseen_character_in</a>
    /// </summary>
    let U37i_is_foreseen_character_in = _prefixId.prefix "U37i_is_foreseen_character_in"

    /// <summary>
    ///   <para>rdfs:label : U38 has descriptive expressionrdfs:label : U38 a pour expression descriptive</para>
    ///   <a href="http://data.doremus.org/ontology#U38_has_descriptive_expression">mus:U38_has_descriptive_expression</a>
    /// </summary>
    let U38_has_descriptive_expression =
        _prefixId.prefix "U38_has_descriptive_expression"

    /// <summary>
    ///   <para>rdfs:label : U38i is descriptive expression of</para>
    ///   <a href="http://data.doremus.org/ontology#U38i_is_descriptive_expression_of">mus:U38i_is_descriptive_expression_of</a>
    /// </summary>
    let U38i_is_descriptive_expression_of =
        _prefixId.prefix "U38i_is_descriptive_expression_of"

    /// <summary>
    ///   <para>rdfs:label : U39 has tuned</para>
    ///   <a href="http://data.doremus.org/ontology#U39_has_tuned">mus:U39_has_tuned</a>
    /// </summary>
    let U39_has_tuned = _prefixId.prefix "U39_has_tuned"
    /// <summary>
    ///   <para>rdfs:label : U39i was tuned by</para>
    ///   <a href="http://data.doremus.org/ontology#U39i_was_tuned_by">mus:U39i_was_tuned_by</a>
    /// </summary>
    let U39i_was_tuned_by = _prefixId.prefix "U39i_was_tuned_by"

    /// <summary>
    ///   <para>rdfs:label : U3 utilisation prévue de l'objet spécifiquerdfs:label : U3 forees use of specific object</para>
    ///   <a href="http://data.doremus.org/ontology#U3_foresees_use_of_specific_object">mus:U3_foresees_use_of_specific_object</a>
    /// </summary>
    let U3_foresees_use_of_specific_object =
        _prefixId.prefix "U3_foresees_use_of_specific_object"

    /// <summary>
    ///   <para>rdfs:label : U3i is foreseen specific medium of performance inrdfs:label : U3i est le type d'objet spécifique prévu pour</para>
    ///   <a href="http://data.doremus.org/ontology#U3i_is_foreseen_specific_object_in">mus:U3i_is_foreseen_specific_object_in</a>
    /// </summary>
    let U3i_is_foreseen_specific_object_in =
        _prefixId.prefix "U3i_is_foreseen_specific_object_in"

    /// <summary>
    ///   <para>rdfs:label : U40 has catalogue name</para>
    ///   <a href="http://data.doremus.org/ontology#U40_has_catalogue_name">mus:U40_has_catalogue_name</a>
    /// </summary>
    let U40_has_catalogue_name = _prefixId.prefix "U40_has_catalogue_name"
    /// <summary>
    ///   <para>rdfs:label : U40i is catalogue name of</para>
    ///   <a href="http://data.doremus.org/ontology#U40i_is_catalogue_name_of">mus:U40i_is_catalogue_name_of</a>
    /// </summary>
    let U40i_is_catalogue_name_of = _prefixId.prefix "U40i_is_catalogue_name_of"
    /// <summary>
    ///   <para>rdfs:label : U41 has catalogue number</para>
    ///   <a href="http://data.doremus.org/ontology#U41_has_catalogue_number">mus:U41_has_catalogue_number</a>
    /// </summary>
    let U41_has_catalogue_number = _prefixId.prefix "U41_has_catalogue_number"
    /// <summary>
    ///   <para>rdfs:label : U42 has opus number</para>
    ///   <a href="http://data.doremus.org/ontology#U42_has_opus_number">mus:U42_has_opus_number</a>
    /// </summary>
    let U42_has_opus_number = _prefixId.prefix "U42_has_opus_number"
    /// <summary>
    ///   <para>rdfs:label : U43 has opus subnumber</para>
    ///   <a href="http://data.doremus.org/ontology#U43_has_opus_subnumber">mus:U43_has_opus_subnumber</a>
    /// </summary>
    let U43_has_opus_subnumber = _prefixId.prefix "U43_has_opus_subnumber"
    /// <summary>
    ///   <para>rdfs:label : U44 has dedication statement</para>
    ///   <a href="http://data.doremus.org/ontology#U44_has_dedication_statement">mus:U44_has_dedication_statement</a>
    /// </summary>
    let U44_has_dedication_statement = _prefixId.prefix "U44_has_dedication_statement"

    /// <summary>
    ///   <para>rdfs:label : U44i is dedication statement of</para>
    ///   <a href="http://data.doremus.org/ontology#U44i_is_dedication_statement_of">mus:U44i_is_dedication_statement_of</a>
    /// </summary>
    let U44i_is_dedication_statement_of =
        _prefixId.prefix "U44i_is_dedication_statement_of"

    /// <summary>
    ///   <para>rdfs:label : U45 has metronome indicationrdfs:label : U45 a pour indication métronomique</para>
    ///   <a href="http://data.doremus.org/ontology#U45_has_metronome_indication">mus:U45_has_metronome_indication</a>
    /// </summary>
    let U45_has_metronome_indication = _prefixId.prefix "U45_has_metronome_indication"

    /// <summary>
    ///   <para>rdfs:label : U45i is metronome indication of</para>
    ///   <a href="http://data.doremus.org/ontology#U45i_is_metronome_indication_of">mus:U45i_is_metronome_indication_of</a>
    /// </summary>
    let U45i_is_metronome_indication_of =
        _prefixId.prefix "U45i_is_metronome_indication_of"

    /// <summary>
    ///   <para>rdfs:label : U46 occurred in context</para>
    ///   <a href="http://data.doremus.org/ontology#U46_occurred_in_context">mus:U46_occurred_in_context</a>
    /// </summary>
    let U46_occurred_in_context = _prefixId.prefix "U46_occurred_in_context"
    /// <summary>
    ///   <para>rdfs:label : U46i was context of</para>
    ///   <a href="http://data.doremus.org/ontology#U46i_was_context_of">mus:U46i_was_context_of</a>
    /// </summary>
    let U46i_was_context_of = _prefixId.prefix "U46i_was_context_of"
    /// <summary>
    ///   <para>rdfs:label : U47 has derivation type</para>
    ///   <a href="http://data.doremus.org/ontology#U47_has_derivation_type">mus:U47_has_derivation_type</a>
    /// </summary>
    let U47_has_derivation_type = _prefixId.prefix "U47_has_derivation_type"
    /// <summary>
    ///   <para>rdfs:label : U47i is derivation type of</para>
    ///   <a href="http://data.doremus.org/ontology#U47i_is_derivation_type_of">mus:U47i_is_derivation_type_of</a>
    /// </summary>
    let U47i_is_derivation_type_of = _prefixId.prefix "U47i_is_derivation_type_of"

    /// <summary>
    ///   <para>rdfs:label : U48 foresees quantity of actors</para>
    ///   <a href="http://data.doremus.org/ontology#U48_foresees_quantity_of_actors">mus:U48_foresees_quantity_of_actors</a>
    /// </summary>
    let U48_foresees_quantity_of_actors =
        _prefixId.prefix "U48_foresees_quantity_of_actors"

    /// <summary>
    ///   <para>rdfs:label : U49 created for actor</para>
    ///   <para>rdfs:comment : personne ou groupe pour lequel l'Expression a été créée.</para>
    ///   <a href="http://data.doremus.org/ontology#U49_created_for_actor">mus:U49_created_for_actor</a>
    /// </summary>
    let U49_created_for_actor = _prefixId.prefix "U49_created_for_actor"
    /// <summary>
    ///   <para>rdfs:label : U49i actor motivated</para>
    ///   <a href="http://data.doremus.org/ontology#U49i_actor_motivated">mus:U49i_actor_motivated</a>
    /// </summary>
    let U49i_actor_motivated = _prefixId.prefix "U49i_actor_motivated"
    /// <summary>
    ///   <para>rdfs:label : U4 had princeps publicationrdfs:label : U4 a pour édition princeps</para>
    ///   <a href="http://data.doremus.org/ontology#U4_had_princeps_publication">mus:U4_had_princeps_publication</a>
    /// </summary>
    let U4_had_princeps_publication = _prefixId.prefix "U4_had_princeps_publication"

    /// <summary>
    ///   <para>rdfs:label : U4i was princeps publication of</para>
    ///   <a href="http://data.doremus.org/ontology#U4i_was_princeps_publication_of">mus:U4i_was_princeps_publication_of</a>
    /// </summary>
    let U4i_was_princeps_publication_of =
        _prefixId.prefix "U4i_was_princeps_publication_of"

    /// <summary>
    ///   <para>rdfs:label : U50 Has annotation</para>
    ///   <a href="http://data.doremus.org/ontology#U50_has_annotation">mus:U50_has_annotation</a>
    /// </summary>
    let U50_has_annotation = _prefixId.prefix "U50_has_annotation"

    /// <summary>
    ///   <para>rdfs:label : U51 is partial or full recording of</para>
    ///   <a href="http://data.doremus.org/ontology#U51_is_partial_or_full_recording_of">mus:U51_is_partial_or_full_recording_of</a>
    /// </summary>
    let U51_is_partial_or_full_recording_of =
        _prefixId.prefix "U51_is_partial_or_full_recording_of"

    /// <summary>
    ///   <para>rdfs:label : U51i has partial or full recording</para>
    ///   <a href="http://data.doremus.org/ontology#U51i_has_partial_or_full_recording">mus:U51i_has_partial_or_full_recording</a>
    /// </summary>
    let U51i_has_partial_or_full_recording =
        _prefixId.prefix "U51i_has_partial_or_full_recording"

    /// <summary>
    ///   <para>rdfs:label : U52 has context</para>
    ///   <a href="http://data.doremus.org/ontology#U52_has_context">mus:U52_has_context</a>
    /// </summary>
    let U52_has_context = _prefixId.prefix "U52_has_context"
    /// <summary>
    ///   <para>rdfs:label : U52i is context of</para>
    ///   <a href="http://data.doremus.org/ontology#U52i_is_context_of">mus:U52i_is_context_of</a>
    /// </summary>
    let U52i_is_context_of = _prefixId.prefix "U52i_is_context_of"
    /// <summary>
    ///   <para>rdfs:label : U53 has duration</para>
    ///   <a href="http://data.doremus.org/ontology#U53_has_duration">mus:U53_has_duration</a>
    /// </summary>
    let U53_has_duration = _prefixId.prefix "U53_has_duration"
    /// <summary>
    ///   <para>rdfs:label : U53i is duration of</para>
    ///   <a href="http://data.doremus.org/ontology#U53i_is_duration_of">mus:U53i_is_duration_of</a>
    /// </summary>
    let U53i_is_duration_of = _prefixId.prefix "U53i_is_duration_of"

    /// <summary>
    ///   <para>rdfs:label : U54 is performed expression of</para>
    ///   <a href="http://data.doremus.org/ontology#U54_is_performed_expression_of">mus:U54_is_performed_expression_of</a>
    /// </summary>
    let U54_is_performed_expression_of =
        _prefixId.prefix "U54_is_performed_expression_of"

    /// <summary>
    ///   <para>rdfs:label : U54i has performed expression</para>
    ///   <a href="http://data.doremus.org/ontology#U54i_has_performed_expression">mus:U54i_has_performed_expression</a>
    /// </summary>
    let U54i_has_performed_expression = _prefixId.prefix "U54i_has_performed_expression"

    /// <summary>
    ///   <para>rdfs:label : U55 incorporates performed expression</para>
    ///   <a href="http://data.doremus.org/ontology#U55_incorporates_performed_expression">mus:U55_incorporates_performed_expression</a>
    /// </summary>
    let U55_incorporates_performed_expression =
        _prefixId.prefix "U55_incorporates_performed_expression"

    /// <summary>
    ///   <para>rdfs:label : U55i performed expression is incorporated in</para>
    ///   <a href="http://data.doremus.org/ontology#U55i_performed_expression_is_incorporated_in">mus:U55i_performed_expression_is_incorporated_in</a>
    /// </summary>
    let U55i_performed_expression_is_incorporated_in =
        _prefixId.prefix "U55i_performed_expression_is_incorporated_in"

    /// <summary>
    ///   <para>rdfs:label : U56 occurred in historical context</para>
    ///   <a href="http://data.doremus.org/ontology#U56_occurred_in_historical_context">mus:U56_occurred_in_historical_context</a>
    /// </summary>
    let U56_occurred_in_historical_context =
        _prefixId.prefix "U56_occurred_in_historical_context"

    /// <summary>
    ///   <para>rdfs:label : U56i was historical context of</para>
    ///   <a href="http://data.doremus.org/ontology#U56i_was_historical_context_of">mus:U56i_was_historical_context_of</a>
    /// </summary>
    let U56i_was_historical_context_of =
        _prefixId.prefix "U56i_was_historical_context_of"

    /// <summary>
    ///   <para>rdfs:label : U57 occurred in religious context</para>
    ///   <a href="http://data.doremus.org/ontology#U57_occurred_in_religious_context">mus:U57_occurred_in_religious_context</a>
    /// </summary>
    let U57_occurred_in_religious_context =
        _prefixId.prefix "U57_occurred_in_religious_context"

    /// <summary>
    ///   <para>rdfs:label : U57i was religious context of</para>
    ///   <a href="http://data.doremus.org/ontology#U57i_was_religious_context_of">mus:U57i_was_religious_context_of</a>
    /// </summary>
    let U57i_was_religious_context_of = _prefixId.prefix "U57i_was_religious_context_of"

    /// <summary>
    ///   <para>rdfs:label : U58 has full published recording</para>
    ///   <a href="http://data.doremus.org/ontology#U58_has_full_published_recording">mus:U58_has_full_published_recording</a>
    /// </summary>
    let U58_has_full_published_recording =
        _prefixId.prefix "U58_has_full_published_recording"

    /// <summary>
    ///   <para>rdfs:label : U58i is full published recording of</para>
    ///   <a href="http://data.doremus.org/ontology#U58i_is_full_published_recording_of">mus:U58i_is_full_published_recording_of</a>
    /// </summary>
    let U58i_is_full_published_recording_of =
        _prefixId.prefix "U58i_is_full_published_recording_of"

    /// <summary>
    ///   <para>rdfs:label : U59 has partial published recording</para>
    ///   <a href="http://data.doremus.org/ontology#U59_has_partial_published_recording">mus:U59_has_partial_published_recording</a>
    /// </summary>
    let U59_has_partial_published_recording =
        _prefixId.prefix "U59_has_partial_published_recording"

    /// <summary>
    ///   <para>rdfs:label : U59i is partial published recording of</para>
    ///   <a href="http://data.doremus.org/ontology#U59i_is_partial_published_recording_of">mus:U59i_is_partial_published_recording_of</a>
    /// </summary>
    let U59i_is_partial_published_recording_of =
        _prefixId.prefix "U59i_is_partial_published_recording_of"

    /// <summary>
    ///   <para>rdfs:label : U5 had premiererdfs:label : U5 a une première</para>
    ///   <a href="http://data.doremus.org/ontology#U5_had_premiere">mus:U5_had_premiere</a>
    /// </summary>
    let U5_had_premiere = _prefixId.prefix "U5_had_premiere"
    /// <summary>
    ///   <para>rdfs:label : U5i was premiere of</para>
    ///   <a href="http://data.doremus.org/ontology#U5i_was_premiere_of">mus:U5i_was_premiere_of</a>
    /// </summary>
    let U5i_was_premiere_of = _prefixId.prefix "U5i_was_premiere_of"

    /// <summary>
    ///   <para>rdfs:label : U60 occurred in cultural context</para>
    ///   <a href="http://data.doremus.org/ontology#U60_occurred_in_cultural_context">mus:U60_occurred_in_cultural_context</a>
    /// </summary>
    let U60_occurred_in_cultural_context =
        _prefixId.prefix "U60_occurred_in_cultural_context"

    /// <summary>
    ///   <para>rdfs:label : U60i was cultural context of</para>
    ///   <a href="http://data.doremus.org/ontology#U60i_was_cultural_context_of">mus:U60i_was_cultural_context_of</a>
    /// </summary>
    let U60i_was_cultural_context_of = _prefixId.prefix "U60i_was_cultural_context_of"

    /// <summary>
    ///   <para>rdfs:label : U61 occurred in geographical context</para>
    ///   <a href="http://data.doremus.org/ontology#U61_occurred_in_geographical_context">mus:U61_occurred_in_geographical_context</a>
    /// </summary>
    let U61_occurred_in_geographical_context =
        _prefixId.prefix "U61_occurred_in_geographical_context"

    /// <summary>
    ///   <para>rdfs:label : U61i was geographical context of</para>
    ///   <a href="http://data.doremus.org/ontology#U61i_was_geographical_context_of">mus:U61i_was_geographical_context_of</a>
    /// </summary>
    let U61i_was_geographical_context_of =
        _prefixId.prefix "U61i_was_geographical_context_of"

    /// <summary>
    ///   <para>rdfs:label : U62 has form</para>
    ///   <a href="http://data.doremus.org/ontology#U62_has_form">mus:U62_has_form</a>
    /// </summary>
    let U62_has_form = _prefixId.prefix "U62_has_form"
    /// <summary>
    ///   <para>rdfs:label : U62i is form of</para>
    ///   <a href="http://data.doremus.org/ontology#U62i_is_form_of">mus:U62i_is_form_of</a>
    /// </summary>
    let U62i_is_form_of = _prefixId.prefix "U62i_is_form_of"
    /// <summary>
    ///   <para>rdfs:label : U63 has religious context</para>
    ///   <a href="http://data.doremus.org/ontology#U63_has_religious_context">mus:U63_has_religious_context</a>
    /// </summary>
    let U63_has_religious_context = _prefixId.prefix "U63_has_religious_context"
    /// <summary>
    ///   <para>rdfs:label : U63i is religious context of</para>
    ///   <a href="http://data.doremus.org/ontology#U63i_is_religious_context_of">mus:U63i_is_religious_context_of</a>
    /// </summary>
    let U63i_is_religious_context_of = _prefixId.prefix "U63i_is_religious_context_of"
    /// <summary>
    ///   <para>rdfs:label : U64 has cultural context</para>
    ///   <a href="http://data.doremus.org/ontology#U64_has_cultural_context">mus:U64_has_cultural_context</a>
    /// </summary>
    let U64_has_cultural_context = _prefixId.prefix "U64_has_cultural_context"
    /// <summary>
    ///   <para>rdfs:label : U64i is cultural context of</para>
    ///   <a href="http://data.doremus.org/ontology#U64i_is_cultural_context_of">mus:U64i_is_cultural_context_of</a>
    /// </summary>
    let U64i_is_cultural_context_of = _prefixId.prefix "U64i_is_cultural_context_of"
    /// <summary>
    ///   <para>rdfs:label : U65 has geographical context</para>
    ///   <a href="http://data.doremus.org/ontology#U65_has_geographical_context">mus:U65_has_geographical_context</a>
    /// </summary>
    let U65_has_geographical_context = _prefixId.prefix "U65_has_geographical_context"

    /// <summary>
    ///   <para>rdfs:label : U65i is geographical context of</para>
    ///   <a href="http://data.doremus.org/ontology#U65i_is_geographical_context_of">mus:U65i_is_geographical_context_of</a>
    /// </summary>
    let U65i_is_geographical_context_of =
        _prefixId.prefix "U65i_is_geographical_context_of"

    /// <summary>
    ///   <para>rdfs:label : U66 has historical context</para>
    ///   <a href="http://data.doremus.org/ontology#U66_has_historical_context">mus:U66_has_historical_context</a>
    /// </summary>
    let U66_has_historical_context = _prefixId.prefix "U66_has_historical_context"
    /// <summary>
    ///   <para>rdfs:label : U66i is historical context of</para>
    ///   <a href="http://data.doremus.org/ontology#U66i_is_historical_context_of">mus:U66i_is_historical_context_of</a>
    /// </summary>
    let U66i_is_historical_context_of = _prefixId.prefix "U66i_is_historical_context_of"
    /// <summary>
    ///   <para>rdfs:label : U67 has subtitlerdfs:label : U67 a pour sous-titre</para>
    ///   <a href="http://data.doremus.org/ontology#U67_has_subtitle">mus:U67_has_subtitle</a>
    /// </summary>
    let U67_has_subtitle = _prefixId.prefix "U67_has_subtitle"
    /// <summary>
    ///   <para>rdfs:label : U68 has variant titlerdfs:label : U68 a pour variante de titre</para>
    ///   <a href="http://data.doremus.org/ontology#U68_has_variant_title">mus:U68_has_variant_title</a>
    /// </summary>
    let U68_has_variant_title = _prefixId.prefix "U68_has_variant_title"
    /// <summary>
    ///   <para>rdfs:label : U69 has WoO numberrdfs:label : U69 a pour numéro de WoO</para>
    ///   <a href="http://data.doremus.org/ontology#U69_has_WoO_number">mus:U69_has_WoO_number</a>
    /// </summary>
    let U69_has_WoO_number = _prefixId.prefix "U69_has_WoO_number"
    /// <summary>
    ///   <para>rdfs:label : U6 foresees actor</para>
    ///   <a href="http://data.doremus.org/ontology#U6_foresees_actor">mus:U6_foresees_actor</a>
    /// </summary>
    let U6_foresees_actor = _prefixId.prefix "U6_foresees_actor"
    /// <summary>
    ///   <para>rdfs:label : U6i is foreseen actor of</para>
    ///   <a href="http://data.doremus.org/ontology#U6i_is_foreseen_actor_of">mus:U6i_is_foreseen_actor_of</a>
    /// </summary>
    let U6i_is_foreseen_actor_of = _prefixId.prefix "U6i_is_foreseen_actor_of"
    /// <summary>
    ///   <para>rdfs:label : U70 has original titlerdfs:label : U70 a pour titre originel</para>
    ///   <a href="http://data.doremus.org/ontology#U70_has_original_title">mus:U70_has_original_title</a>
    /// </summary>
    let U70_has_original_title = _prefixId.prefix "U70_has_original_title"
    /// <summary>
    ///   <para>rdfs:label : U71 has uniform titlerdfs:label : U71 a pour titre uniforme</para>
    ///   <a href="http://data.doremus.org/ontology#U71_has_uniform_title">mus:U71_has_uniform_title</a>
    /// </summary>
    let U71_has_uniform_title = _prefixId.prefix "U71_has_uniform_title"
    /// <summary>
    ///   <para>rdfs:label : U72 has title note</para>
    ///   <a href="http://data.doremus.org/ontology#U72_has_title_note">mus:U72_has_title_note</a>
    /// </summary>
    let U72_has_title_note = _prefixId.prefix "U72_has_title_note"
    /// <summary>
    ///   <para>rdfs:label : U73 is derivative of</para>
    ///   <a href="http://data.doremus.org/ontology#U73_is_derivative_of">mus:U73_is_derivative_of</a>
    /// </summary>
    let U73_is_derivative_of = _prefixId.prefix "U73_is_derivative_of"
    /// <summary>
    ///   <para>rdfs:label : U73i has derivative</para>
    ///   <a href="http://data.doremus.org/ontology#U73i_has_derivative">mus:U73i_has_derivative</a>
    /// </summary>
    let U73i_has_derivative = _prefixId.prefix "U73i_has_derivative"
    /// <summary>
    ///   <para>rdfs:label : U74 cited</para>
    ///   <a href="http://data.doremus.org/ontology#U74_cited">mus:U74_cited</a>
    /// </summary>
    let U74_cited = _prefixId.prefix "U74_cited"
    /// <summary>
    ///   <para>rdfs:label : U74i was cited by</para>
    ///   <a href="http://data.doremus.org/ontology#U74i_was_cited_by">mus:U74i_was_cited_by</a>
    /// </summary>
    let U74i_was_cited_by = _prefixId.prefix "U74i_was_cited_by"
    /// <summary>
    ///   <para>rdfs:label : U75 has harmonic structure</para>
    ///   <a href="http://data.doremus.org/ontology#U75_has_harmonic_structure">mus:U75_has_harmonic_structure</a>
    /// </summary>
    let U75_has_harmonic_structure = _prefixId.prefix "U75_has_harmonic_structure"
    /// <summary>
    ///   <para>rdfs:label : U75i is harmonic structure of</para>
    ///   <a href="http://data.doremus.org/ontology#U75i_is_harmonic_structure_of">mus:U75i_is_harmonic_structure_of</a>
    /// </summary>
    let U75i_is_harmonic_structure_of = _prefixId.prefix "U75i_is_harmonic_structure_of"
    /// <summary>
    ///   <para>rdfs:label : U76 has WoO subnumber</para>
    ///   <a href="http://data.doremus.org/ontology#U76_has_WoO_subnumber">mus:U76_has_WoO_subnumber</a>
    /// </summary>
    let U76_has_WoO_subnumber = _prefixId.prefix "U76_has_WoO_subnumber"
    /// <summary>
    ///   <para>rdfs:label : U77 foresees performing plan</para>
    ///   <a href="http://data.doremus.org/ontology#U77_foresees_performing_plan">mus:U77_foresees_performing_plan</a>
    /// </summary>
    let U77_foresees_performing_plan = _prefixId.prefix "U77_foresees_performing_plan"
    /// <summary>
    ///   <para>rdfs:label : U77i is foreseen plan in</para>
    ///   <a href="http://data.doremus.org/ontology#U77i_is_foreseen_plan_in">mus:U77i_is_foreseen_plan_in</a>
    /// </summary>
    let U77i_is_foreseen_plan_in = _prefixId.prefix "U77i_is_foreseen_plan_in"
    /// <summary>
    ///   <para>rdfs:label : U78 estimated durationrdfs:label : U78 durée estimée</para>
    ///   <para>rdfs:comment : La durée éditeur n'est pas "mesurée" mais "estimée"</para>
    ///   <a href="http://data.doremus.org/ontology#U78_estimated_duration">mus:U78_estimated_duration</a>
    /// </summary>
    let U78_estimated_duration = _prefixId.prefix "U78_estimated_duration"
    /// <summary>
    ///   <para>rdfs:label : U79 has lowest pitch</para>
    ///   <a href="http://data.doremus.org/ontology#U79_has_lowest_pitch">mus:U79_has_lowest_pitch</a>
    /// </summary>
    let U79_has_lowest_pitch = _prefixId.prefix "U79_has_lowest_pitch"
    /// <summary>
    ///   <para>rdfs:label : U7 foresees place at</para>
    ///   <a href="http://data.doremus.org/ontology#U7_foresees_place_at">mus:U7_foresees_place_at</a>
    /// </summary>
    let U7_foresees_place_at = _prefixId.prefix "U7_foresees_place_at"
    /// <summary>
    ///   <para>rdfs:label : U7i is foreseen place of</para>
    ///   <a href="http://data.doremus.org/ontology#U7i_is_foreseen_place_of">mus:U7i_is_foreseen_place_of</a>
    /// </summary>
    let U7i_is_foreseen_place_of = _prefixId.prefix "U7i_is_foreseen_place_of"
    /// <summary>
    ///   <para>rdfs:label : U80 has highest pitch</para>
    ///   <a href="http://data.doremus.org/ontology#U80_has_highest_pitch">mus:U80_has_highest_pitch</a>
    /// </summary>
    let U80_has_highest_pitch = _prefixId.prefix "U80_has_highest_pitch"
    /// <summary>
    ///   <para>rdfs:label : U81 had performer status</para>
    ///   <a href="http://data.doremus.org/ontology#U81_had_performer_status">mus:U81_had_performer_status</a>
    /// </summary>
    let U81_had_performer_status = _prefixId.prefix "U81_had_performer_status"
    /// <summary>
    ///   <para>rdfs:label : U81i is performer status of</para>
    ///   <a href="http://data.doremus.org/ontology#U81i_is_performer_status_of">mus:U81i_is_performer_status_of</a>
    /// </summary>
    let U81i_is_performer_status_of = _prefixId.prefix "U81i_is_performer_status_of"

    /// <summary>
    ///   <para>rdfs:label : U82 has foreseen performer status</para>
    ///   <a href="http://data.doremus.org/ontology#U82_has_foreseen_performer_status">mus:U82_has_foreseen_performer_status</a>
    /// </summary>
    let U82_has_foreseen_performer_status =
        _prefixId.prefix "U82_has_foreseen_performer_status"

    /// <summary>
    ///   <para>rdfs:label : U82i is foreseen performer status of</para>
    ///   <a href="http://data.doremus.org/ontology#U82i_is_foreseen_performer_status_of">mus:U82i_is_foreseen_performer_status_of</a>
    /// </summary>
    let U82i_is_foreseen_performer_status_of =
        _prefixId.prefix "U82i_is_foreseen_performer_status_of"

    /// <summary>
    ///   <para>rdfs:comment : Examples: the key of 'C major' has 'A minor' as relative keyrdfs:comment : Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont en relation par rapport à l'armure, c'est-à-dire l'une est la relatif majeur ou mineur de l'autre.rdfs:comment : Scope Note: This class allows to connect two M4 Keys that are in a relative relationship, i.e. one is the relative major or minor of the other one.rdfs:comment : see also http://en.wikipedia.org/wiki/Relative_key^^xsd:stringrdfs:comment : Exemples: la clé de 'Do majeur' a 'La mineur' pour tonalité relative</para>
    ///   <para>rdfs:label : U83 a pour tonalité relativerdfs:label : U83 has relative key</para>
    ///   <a href="http://data.doremus.org/ontology#U83_has_relative_key">mus:U83_has_relative_key</a>
    /// </summary>
    let U83_has_relative_key = _prefixId.prefix "U83_has_relative_key"
    /// <summary>
    ///   <para>rdfs:comment : Scope Note: This class allows to connect two M4 Keys that are in a parallel relationship, i.e. one is the parallel major or minor of the other one.rdfs:comment : Examples: the key of 'C major' has 'C minor' as parallel keyrdfs:comment : see also http://en.wikipedia.org/wiki/Parallel_key^^xsd:stringrdfs:comment : Exemples: la clé de 'Do majeur' a 'Do mineur' pour tonalité parallèlerdfs:comment : Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont en une relation parallèle, c'est-à-dire l'une est la parallèle majeur ou mineur de l'autre.</para>
    ///   <para>rdfs:label : U84 a pour tonalité parallèlerdfs:label : U84 has parallel key</para>
    ///   <a href="http://data.doremus.org/ontology#U84_has_parallel_key">mus:U84_has_parallel_key</a>
    /// </summary>
    let U84_has_parallel_key = _prefixId.prefix "U84_has_parallel_key"
    /// <summary>
    ///   <para>rdfs:comment : Exemples: la clé de 'Do majeur' a 'Sol majeur' et 'Re majeur' pour tonalités étroitement liéesrdfs:comment : see also http://en.wikipedia.org/wiki/Closely_related_key^^xsd:stringrdfs:comment : Examples: the key of 'C major' has 'G major' and 'D minor' as closely related keysrdfs:comment : Scope Note: Cette classe permet de connecter deux M4 Tonalité qui sont étroitement liées d'un point de vue harmonique, par ex. ceux sont des destinations ou des transpositions fréquemment utilisées dans une modulationrdfs:comment : Scope Note: This class allows to connect two M4 Keys that are mutually closely related from an harmonic point of view, e.g. they are commonly used destinations or transpositions in a modulation.</para>
    ///   <para>rdfs:label : U85 a pour tonalité étroitement liérdfs:label : U85 has closely related key</para>
    ///   <a href="http://data.doremus.org/ontology#U85_has_closely_related_key">mus:U85_has_closely_related_key</a>
    /// </summary>
    let U85_has_closely_related_key = _prefixId.prefix "U85_has_closely_related_key"
    /// <summary>
    ///   <para>skos:scopeNote : m.o.p section as foreseen by the composer, performer or programmer.</para>
    ///   <para>rdfs:label : U87 has member casting detail</para>
    ///   <a href="http://data.doremus.org/ontology#U87_has_member_casting_detail">mus:U87_has_member_casting_detail</a>
    /// </summary>
    let U87_has_member_casting_detail = _prefixId.prefix "U87_has_member_casting_detail"

    /// <summary>
    ///   <para>rdfs:label : U87i is member casting detail of</para>
    ///   <a href="http://data.doremus.org/ontology#U87i_is_member_casting_detail_of">mus:U87i_is_member_casting_detail_of</a>
    /// </summary>
    let U87i_is_member_casting_detail_of =
        _prefixId.prefix "U87i_is_member_casting_detail_of"

    /// <summary>
    ///   <para>rdfs:comment : U88 has medium of performance section</para>
    ///   <a href="http://data.doremus.org/ontology#U88_has_medium_of_performance_section">mus:U88_has_medium_of_performance_section</a>
    /// </summary>
    let U88_has_medium_of_performance_section =
        _prefixId.prefix "U88_has_medium_of_performance_section"

    /// <summary>
    ///   <para>rdfs:label : U88i is member of performance section of</para>
    ///   <a href="http://data.doremus.org/ontology#U88i_is_member_of_performance_section_of">mus:U88i_is_member_of_performance_section_of</a>
    /// </summary>
    let U88i_is_member_of_performance_section_of =
        _prefixId.prefix "U88i_is_member_of_performance_section_of"

    /// <summary>
    ///   <para>rdfs:label : U89 occured in performance conditions</para>
    ///   <a href="http://data.doremus.org/ontology#U89_occured_in_performance_conditions">mus:U89_occured_in_performance_conditions</a>
    /// </summary>
    let U89_occured_in_performance_conditions =
        _prefixId.prefix "U89_occured_in_performance_conditions"

    let U89i_were_performance_conditions_of =
        _prefixId.prefix "U89i_were_performance_conditions_of"

    /// <summary>
    ///   <para>rdfs:label : U8 foresees time-span</para>
    ///   <a href="http://data.doremus.org/ontology#U8_foresees_time_span">mus:U8_foresees_time_span</a>
    /// </summary>
    let U8_foresees_time_span = _prefixId.prefix "U8_foresees_time_span"
    /// <summary>
    ///   <para>rdfs:label : U8i is foreseen time-span of</para>
    ///   <a href="http://data.doremus.org/ontology#U8i_is_foreseen_time_span_of">mus:U8i_is_foreseen_time_span_of</a>
    /// </summary>
    let U8i_is_foreseen_time_span_of = _prefixId.prefix "U8i_is_foreseen_time_span_of"

    /// <summary>
    ///   <para>rdfs:label : U90 foresees creation or performance mode</para>
    ///   <a href="http://data.doremus.org/ontology#U90_foresees_creation_or_performance_mode">mus:U90_foresees_creation_or_performance_mode</a>
    /// </summary>
    let U90_foresees_creation_or_performance_mode =
        _prefixId.prefix "U90_foresees_creation_or_performance_mode"

    /// <summary>
    ///   <para>rdfs:label : U90i were performance conditions of</para>
    ///   <a href="http://data.doremus.org/ontology#U90i_were_performance_conditions_of">mus:U90i_were_performance_conditions_of</a>
    /// </summary>
    let U90i_were_performance_conditions_of =
        _prefixId.prefix "U90i_were_performance_conditions_of"

    /// <summary>
    ///   <para>rdfs:label : U91 put into effect</para>
    ///   <a href="http://data.doremus.org/ontology#U91_put_into_effect">mus:U91_put_into_effect</a>
    /// </summary>
    let U91_put_into_effect = _prefixId.prefix "U91_put_into_effect"

    /// <summary>
    ///   <para>rdfs:label : U91i was put into effect through</para>
    ///   <a href="http://data.doremus.org/ontology#U91i_was_put_into_effect_through">mus:U91i_was_put_into_effect_through</a>
    /// </summary>
    let U91i_was_put_into_effect_through =
        _prefixId.prefix "U91i_was_put_into_effect_through"

    /// <summary>
    ///   <para>rdfs:label : U92 foresees to put into effect</para>
    ///   <a href="http://data.doremus.org/ontology#U92_foresees_to_put_into_effect">mus:U92_foresees_to_put_into_effect</a>
    /// </summary>
    let U92_foresees_to_put_into_effect =
        _prefixId.prefix "U92_foresees_to_put_into_effect"

    /// <summary>
    ///   <para>rdfs:label : U92 is foreseen to be put into effect  through</para>
    ///   <a href="http://data.doremus.org/ontology#U92_is_foreseen_to_be_put_into_effect_through">mus:U92_is_foreseen_to_be_put_into_effect_through</a>
    /// </summary>
    let U92_is_foreseen_to_be_put_into_effect_through =
        _prefixId.prefix "U92_is_foreseen_to_be_put_into_effect_through"

    /// <summary>
    ///   <para>rdfs:label : U93 is realised in</para>
    ///   <a href="http://data.doremus.org/ontology#U93_is_realised_in">mus:U93_is_realised_in</a>
    /// </summary>
    let U93_is_realised_in = _prefixId.prefix "U93_is_realised_in"
    /// <summary>
    ///   <para>rdfs:label : U93 realises</para>
    ///   <a href="http://data.doremus.org/ontology#U93i_realises">mus:U93i_realises</a>
    /// </summary>
    let U93i_realises = _prefixId.prefix "U93i_realises"
    /// <summary>
    ///   <para>rdfs:label : U93 has work type</para>
    ///   <a href="http://data.doremus.org/ontology#U94_has_work_type">mus:U94_has_work_type</a>
    /// </summary>
    let U94_has_work_type = _prefixId.prefix "U94_has_work_type"
    /// <summary>
    ///   <para>rdfs:label : U94i is work type of</para>
    ///   <a href="http://data.doremus.org/ontology#U94i_is_work_type_of">mus:U94i_is_work_type_of</a>
    /// </summary>
    let U94i_is_work_type_of = _prefixId.prefix "U94i_is_work_type_of"
    /// <summary>
    ///   <para>rdfs:label : U95 has hierarchical level</para>
    ///   <a href="http://data.doremus.org/ontology#U95_has_hierarchical_level">mus:U95_has_hierarchical_level</a>
    /// </summary>
    let U95_has_hierarchical_level = _prefixId.prefix "U95_has_hierarchical_level"
    /// <summary>
    ///   <para>rdfs:label : U95 is hierarchical leval of</para>
    ///   <a href="http://data.doremus.org/ontology#U95i_is_hierarchical_level_of">mus:U95i_is_hierarchical_level_of</a>
    /// </summary>
    let U95i_is_hierarchical_level_of = _prefixId.prefix "U95i_is_hierarchical_level_of"

    /// <summary>
    ///   <para>rdfs:label : U96 foresees vocal or instrumental technique</para>
    ///   <a href="http://data.doremus.org/ontology#U96_foresees_vocal_or_instrumental_technique">mus:U96_foresees_vocal_or_instrumental_technique</a>
    /// </summary>
    let U96_foresees_vocal_or_instrumental_technique =
        _prefixId.prefix "U96_foresees_vocal_or_instrumental_technique"

    /// <summary>
    ///   <para>rdfs:label : U96i is foreseen vocal or instrumental technique of</para>
    ///   <a href="http://data.doremus.org/ontology#U96i_is_foreseen_vocal_or_instrumental_technique_of">mus:U96i_is_foreseen_vocal_or_instrumental_technique_of</a>
    /// </summary>
    let U96i_is_foreseen_vocal_or_instrumental_technique_of =
        _prefixId.prefix "U96i_is_foreseen_vocal_or_instrumental_technique_of"

    /// <summary>
    ///   <para>rdfs:label : U9 has quantity</para>
    ///   <a href="http://data.doremus.org/ontology#U9_has_quantity">mus:U9_has_quantity</a>
    /// </summary>
    let U9_has_quantity = _prefixId.prefix "U9_has_quantity"

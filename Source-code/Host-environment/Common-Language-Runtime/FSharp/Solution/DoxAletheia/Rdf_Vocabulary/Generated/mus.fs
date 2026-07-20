namespace http.data.doremus.org.ontology.hash

open DoxAletheia

module mus =
    let _namespace_name = "http://data.doremus.org/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLI198i_should_be_container_of"></see>
    /// </summary>
    let CLI198i_should_be_container_of = _prefix "CLI198i_should_be_container_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU198_should_have_container"></see>
    /// </summary>
    let CLU198_should_have_container = _prefix "CLU198_should_have_container"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU197_should_have_binding"></see>
    /// </summary>
    let CLU197_should_have_binding = _prefix "CLU197_should_have_binding"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M170_Binding"></see>
    /// </summary>
    let M170_Binding = _prefix "M170_Binding"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU197i_should_be_binding_of"></see>
    /// </summary>
    let CLU197i_should_be_binding_of = _prefix "CLU197i_should_be_binding_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M171_Container"></see>
    /// </summary>
    let M171_Container = _prefix "M171_Container"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU206_should_have_media_type"></see>
    /// </summary>
    let CLU206_should_have_media_type = _prefix "CLU206_should_have_media_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M168_Media_Type"></see>
    /// </summary>
    let M168_Media_Type = _prefix "M168_Media_Type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU206i_should_be_media_type_of"></see>
    /// </summary>
    let CLU206i_should_be_media_type_of = _prefix "CLU206i_should_be_media_type_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU207_should_have_carrier_type"></see>
    /// </summary>
    let CLU207_should_have_carrier_type = _prefix "CLU207_should_have_carrier_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M169_Carrier_Type"></see>
    /// </summary>
    let M169_Carrier_Type = _prefix "M169_Carrier_Type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU207i_should_be_carrier_type_of"></see>
    /// </summary>
    let CLU207i_should_be_carrier_type_of = _prefix "CLU207i_should_be_carrier_type_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU210_should_have_pagination"></see>
    /// </summary>
    let CLU210_should_have_pagination = _prefix "CLU210_should_have_pagination"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU210i_should_be_pagination_of"></see>
    /// </summary>
    let CLU210i_should_be_pagination_of = _prefix "CLU210i_should_be_pagination_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU217_should_have_playing_speed"></see>
    /// </summary>
    let CLU217_should_have_playing_speed = _prefix "CLU217_should_have_playing_speed"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M173_Playing_Speed"></see>
    /// </summary>
    let M173_Playing_Speed = _prefix "M173_Playing_Speed"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU217i_should_be_playing_speed_of"></see>
    /// </summary>
    let CLU217i_should_be_playing_speed_of =
        _prefix "CLU217i_should_be_playing_speed_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU223_should_have_number_of_tape_tracks"></see>
    /// </summary>
    let CLU223_should_have_number_of_tape_tracks =
        _prefix "CLU223_should_have_number_of_tape_tracks"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU223i_should_be_number_of_tape_tracks_of"></see>
    /// </summary>
    let CLU223i_should_be_number_of_tape_tracks_of =
        _prefix "CLU223i_should_be_number_of_tape_tracks_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U223_has_number_of_tape_tracks"></see>
    /// </summary>
    let U223_has_number_of_tape_tracks = _prefix "U223_has_number_of_tape_tracks"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU53_should_have_duration"></see>
    /// </summary>
    let CLU53_should_have_duration = _prefix "CLU53_should_have_duration"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#CLU53i_should_be_duration_of"></see>
    /// </summary>
    let CLU53i_should_be_duration_of = _prefix "CLU53i_should_be_duration_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M10_Catalogue_Name"></see>
    /// </summary>
    let M10_Catalogue_Name = _prefix "M10_Catalogue_Name"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M11_Catalogue_Number"></see>
    /// </summary>
    let M11_Catalogue_Number = _prefix "M11_Catalogue_Number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M12_Opus_Number"></see>
    /// </summary>
    let M12_Opus_Number = _prefix "M12_Opus_Number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M13_Opus_Subnumber"></see>
    /// </summary>
    let M13_Opus_Subnumber = _prefix "M13_Opus_Subnumber"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M14_Medium_Of_Performance"></see>
    /// </summary>
    let M14_Medium_Of_Performance = _prefix "M14_Medium_Of_Performance"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M154_Label_Name"></see>
    /// </summary>
    let M154_Label_Name = _prefix "M154_Label_Name"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M155_Cast_Statement"></see>
    /// </summary>
    let M155_Cast_Statement = _prefix "M155_Cast_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M156_Title_Statement"></see>
    /// </summary>
    let M156_Title_Statement = _prefix "M156_Title_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M157_Statement_of_Responsibility"></see>
    /// </summary>
    let M157_Statement_of_Responsibility = _prefix "M157_Statement_of_Responsibility"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M158_Title_and_Statement_of_Responsibility"></see>
    /// </summary>
    let M158_Title_and_Statement_of_Responsibility =
        _prefix "M158_Title_and_Statement_of_Responsibility"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M159_Edition_Statement"></see>
    /// </summary>
    let M159_Edition_Statement = _prefix "M159_Edition_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M15_Dedication_Statement"></see>
    /// </summary>
    let M15_Dedication_Statement = _prefix "M15_Dedication_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M160_Publication_Statement"></see>
    /// </summary>
    let M160_Publication_Statement = _prefix "M160_Publication_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M161_Distribution_Statement"></see>
    /// </summary>
    let M161_Distribution_Statement = _prefix "M161_Distribution_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M162_Series_Statement"></see>
    /// </summary>
    let M162_Series_Statement = _prefix "M162_Series_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M163_Music_Format_Statement"></see>
    /// </summary>
    let M163_Music_Format_Statement = _prefix "M163_Music_Format_Statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M164_Multipart_Monograph_Statement"></see>
    /// </summary>
    let M164_Multipart_Monograph_Statement =
        _prefix "M164_Multipart_Monograph_Statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M165_Title_Proper_of_Series"></see>
    /// </summary>
    let M165_Title_Proper_of_Series = _prefix "M165_Title_Proper_of_Series"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M166_Title_Proper_of_Multipart_Monograph"></see>
    /// </summary>
    let M166_Title_Proper_of_Multipart_Monograph =
        _prefix "M166_Title_Proper_of_Multipart_Monograph"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M167_Publication_Expression_Fragment"></see>
    /// </summary>
    let M167_Publication_Expression_Fragment =
        _prefix "M167_Publication_Expression_Fragment"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M16_Maintenance"></see>
    /// </summary>
    let M16_Maintenance = _prefix "M16_Maintenance"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M172_Colour_Content"></see>
    /// </summary>
    let M172_Colour_Content = _prefix "M172_Colour_Content"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M174_Content_Type"></see>
    /// </summary>
    let M174_Content_Type = _prefix "M174_Content_Type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M175_Music_Format"></see>
    /// </summary>
    let M175_Music_Format = _prefix "M175_Music_Format"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M17_Controlled_Access_Point_Creator"></see>
    /// </summary>
    let M17_Controlled_Access_Point_Creator =
        _prefix "M17_Controlled_Access_Point_Creator"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M187i_is_multipart_monograph_statement_of"></see>
    /// </summary>
    let M187i_is_multipart_monograph_statement_of =
        _prefix "M187i_is_multipart_monograph_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U187_has_multipart_monographs_statement"></see>
    /// </summary>
    let U187_has_multipart_monographs_statement =
        _prefix "U187_has_multipart_monographs_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M189i_is_main_series_statement_of"></see>
    /// </summary>
    let M189i_is_main_series_statement_of = _prefix "M189i_is_main_series_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U189_has_main_series_statement"></see>
    /// </summary>
    let U189_has_main_series_statement = _prefix "U189_has_main_series_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M18_Controlled_Access_Point_Denomination"></see>
    /// </summary>
    let M18_Controlled_Access_Point_Denomination =
        _prefix "M18_Controlled_Access_Point_Denomination"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M19_Categorization"></see>
    /// </summary>
    let M19_Categorization = _prefix "M19_Categorization"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M1_Catalogue_Statement"></see>
    /// </summary>
    let M1_Catalogue_Statement = _prefix "M1_Catalogue_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M20_Music_Group_Formation"></see>
    /// </summary>
    let M20_Music_Group_Formation = _prefix "M20_Music_Group_Formation"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M21_Harmonic_Structure"></see>
    /// </summary>
    let M21_Harmonic_Structure = _prefix "M21_Harmonic_Structure"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M22_Form"></see>
    /// </summary>
    let M22_Form = _prefix "M22_Form"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M23_Casting_Detail"></see>
    /// </summary>
    let M23_Casting_Detail = _prefix "M23_Casting_Detail"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M24_Track"></see>
    /// </summary>
    let M24_Track = _prefix "M24_Track"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M46_Set_of_Tracks"></see>
    /// </summary>
    let M46_Set_of_Tracks = _prefix "M46_Set_of_Tracks"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M25_Foreseen_Activity"></see>
    /// </summary>
    let M25_Foreseen_Activity = _prefix "M25_Foreseen_Activity"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M26_Foreseen_Performance"></see>
    /// </summary>
    let M26_Foreseen_Performance = _prefix "M26_Foreseen_Performance"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M27_Foreseen_Individual_Performance"></see>
    /// </summary>
    let M27_Foreseen_Individual_Performance =
        _prefix "M27_Foreseen_Individual_Performance"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M28_Individual_Performance"></see>
    /// </summary>
    let M28_Individual_Performance = _prefix "M28_Individual_Performance"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M29_Editing"></see>
    /// </summary>
    let M29_Editing = _prefix "M29_Editing"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M2_Opus_Statement"></see>
    /// </summary>
    let M2_Opus_Statement = _prefix "M2_Opus_Statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M30_Ambitus"></see>
    /// </summary>
    let M30_Ambitus = _prefix "M30_Ambitus"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M31_Actor_Function"></see>
    /// </summary>
    let M31_Actor_Function = _prefix "M31_Actor_Function"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M32_Actor_Responsibility"></see>
    /// </summary>
    let M32_Actor_Responsibility = _prefix "M32_Actor_Responsibility"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M33_Set_of_Characters"></see>
    /// </summary>
    let M33_Set_of_Characters = _prefix "M33_Set_of_Characters"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M34_Award_Assignment"></see>
    /// </summary>
    let M34_Award_Assignment = _prefix "M34_Award_Assignment"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M35_Representative_Publication_Assignment"></see>
    /// </summary>
    let M35_Representative_Publication_Assignment =
        _prefix "M35_Representative_Publication_Assignment"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M36_Award"></see>
    /// </summary>
    let M36_Award = _prefix "M36_Award"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M37_Music_Scale"></see>
    /// </summary>
    let M37_Music_Scale = _prefix "M37_Music_Scale"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M38_Rhythmic_Pattern"></see>
    /// </summary>
    let M38_Rhythmic_Pattern = _prefix "M38_Rhythmic_Pattern"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M39_Derivation_Type_Assignment"></see>
    /// </summary>
    let M39_Derivation_Type_Assignment = _prefix "M39_Derivation_Type_Assignment"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M3_Order_Number"></see>
    /// </summary>
    let M3_Order_Number = _prefix "M3_Order_Number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M40_Context"></see>
    /// </summary>
    let M40_Context = _prefix "M40_Context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M41_Metronome_Indication"></see>
    /// </summary>
    let M41_Metronome_Indication = _prefix "M41_Metronome_Indication"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M42_Performed_Expression_Creation"></see>
    /// </summary>
    let M42_Performed_Expression_Creation = _prefix "M42_Performed_Expression_Creation"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M43_Performed_Expression"></see>
    /// </summary>
    let M43_Performed_Expression = _prefix "M43_Performed_Expression"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M44_Performed_Work"></see>
    /// </summary>
    let M44_Performed_Work = _prefix "M44_Performed_Work"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M45_Descriptive_Expression_Assignment"></see>
    /// </summary>
    let M45_Descriptive_Expression_Assignment =
        _prefix "M45_Descriptive_Expression_Assignment"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M47_WoO_Number"></see>
    /// </summary>
    let M47_WoO_Number = _prefix "M47_WoO_Number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M48_WoO_Subnumber"></see>
    /// </summary>
    let M48_WoO_Subnumber = _prefix "M48_WoO_Subnumber"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M49_Performer_Status"></see>
    /// </summary>
    let M49_Performer_Status = _prefix "M49_Performer_Status"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M4_Key"></see>
    /// </summary>
    let M4_Key = _prefix "M4_Key"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M50_Creation_or_Performance_Mode"></see>
    /// </summary>
    let M50_Creation_or_Performance_Mode = _prefix "M50_Creation_or_Performance_Mode"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M51_Type_Of_Recording_Equipment"></see>
    /// </summary>
    let M51_Type_Of_Recording_Equipment = _prefix "M51_Type_Of_Recording_Equipment"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M52_Equalization_Technique"></see>
    /// </summary>
    let M52_Equalization_Technique = _prefix "M52_Equalization_Technique"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M53_Noise_Reduction_Technique"></see>
    /// </summary>
    let M53_Noise_Reduction_Technique = _prefix "M53_Noise_Reduction_Technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M54_Sound_Spatialization_Technique"></see>
    /// </summary>
    let M54_Sound_Spatialization_Technique =
        _prefix "M54_Sound_Spatialization_Technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M55_Condition_of_Performance"></see>
    /// </summary>
    let M55_Condition_of_Performance = _prefix "M55_Condition_of_Performance"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M57_Vocal_or_Instrumental_Technique"></see>
    /// </summary>
    let M57_Vocal_or_Instrumental_Technique =
        _prefix "M57_Vocal_or_Instrumental_Technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M58_Programming_Work"></see>
    /// </summary>
    let M58_Programming_Work = _prefix "M58_Programming_Work"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M59_Program"></see>
    /// </summary>
    let M59_Program = _prefix "M59_Program"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M5_Genre"></see>
    /// </summary>
    let M5_Genre = _prefix "M5_Genre"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M60_Intended_Audience"></see>
    /// </summary>
    let M60_Intended_Audience = _prefix "M60_Intended_Audience"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M61_Work_Type"></see>
    /// </summary>
    let M61_Work_Type = _prefix "M61_Work_Type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M62_Hierarchical_Level"></see>
    /// </summary>
    let M62_Hierarchical_Level = _prefix "M62_Hierarchical_Level"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M6_Casting"></see>
    /// </summary>
    let M6_Casting = _prefix "M6_Casting"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M7_Linguistic_Appellation"></see>
    /// </summary>
    let M7_Linguistic_Appellation = _prefix "M7_Linguistic_Appellation"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M8_Tempo"></see>
    /// </summary>
    let M8_Tempo = _prefix "M8_Tempo"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#M9_Derivation_Type"></see>
    /// </summary>
    let M9_Derivation_Type = _prefix "M9_Derivation_Type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U10_has_order_number"></see>
    /// </summary>
    let U10_has_order_number = _prefix "U10_has_order_number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U11_has_key"></see>
    /// </summary>
    let U11_has_key = _prefix "U11_has_key"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U11i_is_key_of"></see>
    /// </summary>
    let U11i_is_key_of = _prefix "U11i_is_key_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U12_has_genre"></see>
    /// </summary>
    let U12_has_genre = _prefix "U12_has_genre"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U12i_is_genre_of"></see>
    /// </summary>
    let U12i_is_genre_of = _prefix "U12i_is_genre_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U13_has_casting"></see>
    /// </summary>
    let U13_has_casting = _prefix "U13_has_casting"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U13i_is_casting_of"></see>
    /// </summary>
    let U13i_is_casting_of = _prefix "U13i_is_casting_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U14_has_tempo"></see>
    /// </summary>
    let U14_has_tempo = _prefix "U14_has_tempo"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U14i_is_tempo_of"></see>
    /// </summary>
    let U14i_is_tempo_of = _prefix "U14i_is_tempo_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U15_has_history"></see>
    /// </summary>
    let U15_has_history = _prefix "U15_has_history"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U167_has_title_proper"></see>
    /// </summary>
    let U167_has_title_proper = _prefix "U167_has_title_proper"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U167i_is_title_proper_of"></see>
    /// </summary>
    let U167i_is_title_proper_of = _prefix "U167i_is_title_proper_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U168_has_parallel_title"></see>
    /// </summary>
    let U168_has_parallel_title = _prefix "U168_has_parallel_title"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U168i_is_parallel_title_of"></see>
    /// </summary>
    let U168i_is_parallel_title_of = _prefix "U168i_is_parallel_title_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U169_was_issued_under_label_name"></see>
    /// </summary>
    let U169_was_issued_under_label_name = _prefix "U169_was_issued_under_label_name"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U16_has_catalogue_statement"></see>
    /// </summary>
    let U16_has_catalogue_statement = _prefix "U16_has_catalogue_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U16i_is_catalogue_statement_of"></see>
    /// </summary>
    let U16i_is_catalogue_statement_of = _prefix "U16i_is_catalogue_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U170_has_title_statement"></see>
    /// </summary>
    let U170_has_title_statement = _prefix "U170_has_title_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U170i_is_title_statement_of"></see>
    /// </summary>
    let U170i_is_title_statement_of = _prefix "U170i_is_title_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U171_has_parallel_title_statement"></see>
    /// </summary>
    let U171_has_parallel_title_statement = _prefix "U171_has_parallel_title_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U171i_is_parallel_title_statement_of"></see>
    /// </summary>
    let U171i_is_parallel_title_statement_of =
        _prefix "U171i_is_parallel_title_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U172_has_statement_of_responsibility_relating_to_title"></see>
    /// </summary>
    let U172_has_statement_of_responsibility_relating_to_title =
        _prefix "U172_has_statement_of_responsibility_relating_to_title"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U172i_is_statement_of_responsibility_relating_to_title_of"></see>
    /// </summary>
    let U172i_is_statement_of_responsibility_relating_to_title_of =
        _prefix "U172i_is_statement_of_responsibility_relating_to_title_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U173_has_parallel_statement_of_responsibility_relating_to_title"></see>
    /// </summary>
    let U173_has_parallel_statement_of_responsibility_relating_to_title =
        _prefix "U173_has_parallel_statement_of_responsibility_relating_to_title"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U173i_is_parallel_statement_of_responsibility_relating_to_title_of"></see>
    /// </summary>
    let U173i_is_parallel_statement_of_responsibility_relating_to_title_of =
        _prefix "U173i_is_parallel_statement_of_responsibility_relating_to_title_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U174_has_cast_statement"></see>
    /// </summary>
    let U174_has_cast_statement = _prefix "U174_has_cast_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U174i_is_cast_statement_of"></see>
    /// </summary>
    let U174i_is_cast_statement_of = _prefix "U174i_is_cast_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U175_has_parallel_cast_statement"></see>
    /// </summary>
    let U175_has_parallel_cast_statement = _prefix "U175_has_parallel_cast_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U175i_is_parallel_cast_statement_of"></see>
    /// </summary>
    let U175i_is_parallel_cast_statement_of =
        _prefix "U175i_is_parallel_cast_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U176_has_edition_statement"></see>
    /// </summary>
    let U176_has_edition_statement = _prefix "U176_has_edition_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U176i_is_edition_statement_of"></see>
    /// </summary>
    let U176i_is_edition_statement_of = _prefix "U176i_is_edition_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U177_has_parallel_edition_statement"></see>
    /// </summary>
    let U177_has_parallel_edition_statement =
        _prefix "U177_has_parallel_edition_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U177i_is_parallel_edition_statement_of"></see>
    /// </summary>
    let U177i_is_parallel_edition_statement_of =
        _prefix "U177i_is_parallel_edition_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U178_has_statement_of_responsibility_relating_to_edition"></see>
    /// </summary>
    let U178_has_statement_of_responsibility_relating_to_edition =
        _prefix "U178_has_statement_of_responsibility_relating_to_edition"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U178i_is_statement_of_responsibility_relating_to_edition_of"></see>
    /// </summary>
    let U178i_is_statement_of_responsibility_relating_to_edition_of =
        _prefix "U178i_is_statement_of_responsibility_relating_to_edition_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U179_has_parallel_statement_of_responsibility_relating_to_edition"></see>
    /// </summary>
    let U179_has_parallel_statement_of_responsibility_relating_to_edition =
        _prefix "U179_has_parallel_statement_of_responsibility_relating_to_edition"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U179i_is_parallel_statement_of_responsibility_relating_to_edition_of"></see>
    /// </summary>
    let U179i_is_parallel_statement_of_responsibility_relating_to_edition_of =
        _prefix "U179i_is_parallel_statement_of_responsibility_relating_to_edition_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U17_has_opus_statement"></see>
    /// </summary>
    let U17_has_opus_statement = _prefix "U17_has_opus_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U17i_is_opus_statement_of"></see>
    /// </summary>
    let U17i_is_opus_statement_of = _prefix "U17i_is_opus_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U180_has_additional_edition_statement"></see>
    /// </summary>
    let U180_has_additional_edition_statement =
        _prefix "U180_has_additional_edition_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U180i_is_additional_edition_statement_of"></see>
    /// </summary>
    let U180i_is_additional_edition_statement_of =
        _prefix "U180i_is_additional_edition_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U181_has_parallel_additional_edition_statement"></see>
    /// </summary>
    let U181_has_parallel_additional_edition_statement =
        _prefix "U181_has_parallel_additional_edition_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U181i_is_parallel_additional_edition_statement_of"></see>
    /// </summary>
    let U181i_is_parallel_additional_edition_statement_of =
        _prefix "U181i_is_parallel_additional_edition_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U182_has_music_format_statement"></see>
    /// </summary>
    let U182_has_music_format_statement = _prefix "U182_has_music_format_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U182i_is_music_format_statement_of"></see>
    /// </summary>
    let U182i_is_music_format_statement_of =
        _prefix "U182i_is_music_format_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U183_has_parallel_music_format_statement"></see>
    /// </summary>
    let U183_has_parallel_music_format_statement =
        _prefix "U183_has_parallel_music_format_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U183i_is_parallel_music_format_statement_of"></see>
    /// </summary>
    let U183i_is_parallel_music_format_statement_of =
        _prefix "U183i_is_parallel_music_format_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U184_has_publication_statement"></see>
    /// </summary>
    let U184_has_publication_statement = _prefix "U184_has_publication_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U184i_is_publication_statement_of"></see>
    /// </summary>
    let U184i_is_publication_statement_of = _prefix "U184i_is_publication_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U185_has_distribution_statement"></see>
    /// </summary>
    let U185_has_distribution_statement = _prefix "U185_has_distribution_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U185i_is_distribution_statement_of"></see>
    /// </summary>
    let U185i_is_distribution_statement_of =
        _prefix "U185i_is_distribution_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U186_has_printing_or_manufacture_statement"></see>
    /// </summary>
    let U186_has_printing_or_manufacture_statement =
        _prefix "U186_has_printing_or_manufacture_statement"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U186i_is_printing_or_manufacture_statement_of"></see>
    /// </summary>
    let U186i_is_printing_or_manufacture_statement_of =
        _prefix "U186i_is_printing_or_manufacture_statement_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U188_has_series_statement"></see>
    /// </summary>
    let U188_has_series_statement = _prefix "U188_has_series_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U188i_is_series_statement_of"></see>
    /// </summary>
    let U188i_is_series_statement_of = _prefix "U188i_is_series_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U18_has_rhythmic_pattern"></see>
    /// </summary>
    let U18_has_rhythmic_pattern = _prefix "U18_has_rhythmic_pattern"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U18i_is_rhythmic_pattern_of"></see>
    /// </summary>
    let U18i_is_rhythmic_pattern_of = _prefix "U18i_is_rhythmic_pattern_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U191_used_equalization_technique"></see>
    /// </summary>
    let U191_used_equalization_technique = _prefix "U191_used_equalization_technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U191i_was_technique_of_equalization"></see>
    /// </summary>
    let U191i_was_technique_of_equalization =
        _prefix "U191i_was_technique_of_equalization"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U192_used_noise_reduction_technique"></see>
    /// </summary>
    let U192_used_noise_reduction_technique =
        _prefix "U192_used_noise_reduction_technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U192i_was_technique_of_noise_reduction"></see>
    /// </summary>
    let U192i_was_technique_of_noise_reduction =
        _prefix "U192i_was_technique_of_noise_reduction"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U193_used_historical_instruments"></see>
    /// </summary>
    let U193_used_historical_instruments = _prefix "U193_used_historical_instruments"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U194_has_system_requirements"></see>
    /// </summary>
    let U194_has_system_requirements = _prefix "U194_has_system_requirements"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U195_has_order_or_location_indication"></see>
    /// </summary>
    let U195_has_order_or_location_indication =
        _prefix "U195_has_order_or_location_indication"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U197_has_binding"></see>
    /// </summary>
    let U197_has_binding = _prefix "U197_has_binding"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U197i_is_binding_of"></see>
    /// </summary>
    let U197i_is_binding_of = _prefix "U197i_is_binding_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U198_has_container"></see>
    /// </summary>
    let U198_has_container = _prefix "U198_has_container"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U199_has_sponsor"></see>
    /// </summary>
    let U199_has_sponsor = _prefix "U199_has_sponsor"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U19_is_categorized_as"></see>
    /// </summary>
    let U19_is_categorized_as = _prefix "U19_is_categorized_as"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U19i_categorizes"></see>
    /// </summary>
    let U19i_categorizes = _prefix "U19i_categorizes"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U1_used_medium_of_performance"></see>
    /// </summary>
    let U1_used_medium_of_performance = _prefix "U1_used_medium_of_performance"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U1i_medium_of_performance_was_used_in"></see>
    /// </summary>
    let U1i_medium_of_performance_was_used_in =
        _prefix "U1i_medium_of_performance_was_used_in"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U200_has_supplementary_content"></see>
    /// </summary>
    let U200_has_supplementary_content = _prefix "U200_has_supplementary_content"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U201_has_illustrative_content"></see>
    /// </summary>
    let U201_has_illustrative_content = _prefix "U201_has_illustrative_content"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U202_has_colour_details"></see>
    /// </summary>
    let U202_has_colour_details = _prefix "U202_has_colour_details"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U203_has_summary_or_abstract"></see>
    /// </summary>
    let U203_has_summary_or_abstract = _prefix "U203_has_summary_or_abstract"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U204_has_reproduction_note"></see>
    /// </summary>
    let U204_has_reproduction_note = _prefix "U204_has_reproduction_note"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U205_has_cast_detail"></see>
    /// </summary>
    let U205_has_cast_detail = _prefix "U205_has_cast_detail"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U206_has_media_type"></see>
    /// </summary>
    let U206_has_media_type = _prefix "U206_has_media_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U206i_is_media_type_of"></see>
    /// </summary>
    let U206i_is_media_type_of = _prefix "U206i_is_media_type_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U207_has_carrier_type"></see>
    /// </summary>
    let U207_has_carrier_type = _prefix "U207_has_carrier_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U208_has_extent_of_carrier"></see>
    /// </summary>
    let U208_has_extent_of_carrier = _prefix "U208_has_extent_of_carrier"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U20_has_music_group_formation"></see>
    /// </summary>
    let U20_has_music_group_formation = _prefix "U20_has_music_group_formation"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U20i_is_music_group_formation_of"></see>
    /// </summary>
    let U20i_is_music_group_formation_of = _prefix "U20i_is_music_group_formation_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U210_has_pagination"></see>
    /// </summary>
    let U210_has_pagination = _prefix "U210_has_pagination"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U210i_is_pagination_of"></see>
    /// </summary>
    let U210i_is_pagination_of = _prefix "U210i_is_pagination_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U211_has_composition_of_material"></see>
    /// </summary>
    let U211_has_composition_of_material = _prefix "U211_has_composition_of_material"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U212_has_technical_features"></see>
    /// </summary>
    let U212_has_technical_features = _prefix "U212_has_technical_features"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U213_has_recording_method"></see>
    /// </summary>
    let U213_has_recording_method = _prefix "U213_has_recording_method"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U214_has_colour_content"></see>
    /// </summary>
    let U214_has_colour_content = _prefix "U214_has_colour_content"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U215_has_groove_caracteristics"></see>
    /// </summary>
    let U215_has_groove_caracteristics = _prefix "U215_has_groove_caracteristics"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U216_has_tape_configuration"></see>
    /// </summary>
    let U216_has_tape_configuration = _prefix "U216_has_tape_configuration"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U217_has_playing_speed"></see>
    /// </summary>
    let U217_has_playing_speed = _prefix "U217_has_playing_speed"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U218_used_object_of_type_for_mastering"></see>
    /// </summary>
    let U218_used_object_of_type_for_mastering =
        _prefix "U218_used_object_of_type_for_mastering"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U219_used_object_of_type_for_mixing"></see>
    /// </summary>
    let U219_used_object_of_type_for_mixing =
        _prefix "U219_used_object_of_type_for_mixing"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U21_is_about_actor"></see>
    /// </summary>
    let U21_is_about_actor = _prefix "U21_is_about_actor"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U21i_actor_is_subject_of"></see>
    /// </summary>
    let U21i_actor_is_subject_of = _prefix "U21i_actor_is_subject_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U220_has_title_and_statement_of_responsibility"></see>
    /// </summary>
    let U220_has_title_and_statement_of_responsibility =
        _prefix "U220_has_title_and_statement_of_responsibility"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U220i_is_title_and_statement_of_responsibility_of"></see>
    /// </summary>
    let U220i_is_title_and_statement_of_responsibility_of =
        _prefix "U220i_is_title_and_statement_of_responsibility_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U221_has_title_proper_of_series"></see>
    /// </summary>
    let U221_has_title_proper_of_series = _prefix "U221_has_title_proper_of_series"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U221i_is_title_proper_of_series_of"></see>
    /// </summary>
    let U221i_is_title_proper_of_series_of =
        _prefix "U221i_is_title_proper_of_series_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U222_has_title_proper_of_sub-series"></see>
    /// </summary>
    let ``U222_has_title_proper_of_sub-series`` =
        _prefix "U222_has_title_proper_of_sub-series"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U222i_is_title_proper_of_sub-series_of"></see>
    /// </summary>
    let ``U222i_is_title_proper_of_sub-series_of`` =
        _prefix "U222i_is_title_proper_of_sub-series_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U223i_is_number_of_tape_tracks_of"></see>
    /// </summary>
    let U223i_is_number_of_tape_tracks_of = _prefix "U223i_is_number_of_tape_tracks_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U224_has_title_proper_of_multipart_monograph"></see>
    /// </summary>
    let U224_has_title_proper_of_multipart_monograph =
        _prefix "U224_has_title_proper_of_multipart_monograph"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U224i_is_title_proper_of_multipart_monograph_of"></see>
    /// </summary>
    let U224i_is_title_proper_of_multipart_monograph_of =
        _prefix "U224i_is_title_proper_of_multipart_monograph_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U225_used_sound_spatialization_technique"></see>
    /// </summary>
    let U225_used_sound_spatialization_technique =
        _prefix "U225_used_sound_spatialization_technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U225i_was_sound_spatialization_technique_of"></see>
    /// </summary>
    let U225i_was_sound_spatialization_technique_of =
        _prefix "U225i_was_sound_spatialization_technique_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U226_has_responsibility_detail"></see>
    /// </summary>
    let U226_has_responsibility_detail = _prefix "U226_has_responsibility_detail"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U227_has_content_type"></see>
    /// </summary>
    let U227_has_content_type = _prefix "U227_has_content_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U227i_is_content_type_of"></see>
    /// </summary>
    let U227i_is_content_type_of = _prefix "U227i_is_content_type_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U228_has_other_distinguishing_characteristic_of_expression"></see>
    /// </summary>
    let U228_has_other_distinguishing_characteristic_of_expression =
        _prefix "U228_has_other_distinguishing_characteristic_of_expression"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U229_has_music_format"></see>
    /// </summary>
    let U229_has_music_format = _prefix "U229_has_music_format"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U229i_is_music_format_of"></see>
    /// </summary>
    let U229i_is_music_format_of = _prefix "U229i_is_music_format_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U22_is_about_place"></see>
    /// </summary>
    let U22_is_about_place = _prefix "U22_is_about_place"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U22i_place_is_subject_of"></see>
    /// </summary>
    let U22i_place_is_subject_of = _prefix "U22i_place_is_subject_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U23_has_casting_detail"></see>
    /// </summary>
    let U23_has_casting_detail = _prefix "U23_has_casting_detail"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U23i_is_casting_detail_of"></see>
    /// </summary>
    let U23i_is_casting_detail_of = _prefix "U23i_is_casting_detail_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U24_has_award"></see>
    /// </summary>
    let U24_has_award = _prefix "U24_has_award"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U24i_is_award_of"></see>
    /// </summary>
    let U24i_is_award_of = _prefix "U24i_is_award_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U25_has_scale"></see>
    /// </summary>
    let U25_has_scale = _prefix "U25_has_scale"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U25i_is_scale_of"></see>
    /// </summary>
    let U25i_is_scale_of = _prefix "U25i_is_scale_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U26_has_maintained"></see>
    /// </summary>
    let U26_has_maintained = _prefix "U26_has_maintained"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U26i_was_maintained_by"></see>
    /// </summary>
    let U26i_was_maintained_by = _prefix "U26i_was_maintained_by"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U27_performed_character"></see>
    /// </summary>
    let U27_performed_character = _prefix "U27_performed_character"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U27i_character_was_performed_by"></see>
    /// </summary>
    let U27i_character_was_performed_by = _prefix "U27i_character_was_performed_by"
    /// <summary>
    /// scope note: this property allows for describing the tessitura of a character, as can be drawn from the score.
    /// <see href="http://data.doremus.org/ontology#U28_has_ambitus"></see></summary>
    let U28_has_ambitus = _prefix "U28_has_ambitus"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U28i_is_ambitus_of"></see>
    /// </summary>
    let U28i_is_ambitus_of = _prefix "U28i_is_ambitus_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U29_edited"></see>
    /// </summary>
    let U29_edited = _prefix "U29_edited"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U29i_was_edited_by"></see>
    /// </summary>
    let U29i_was_edited_by = _prefix "U29i_was_edited_by"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U2_foresees_use_of_medium_of_performance"></see>
    /// </summary>
    let U2_foresees_use_of_medium_of_performance =
        _prefix "U2_foresees_use_of_medium_of_performance"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U2i_is_foreseen_type_of_medium_of_performance_in"></see>
    /// </summary>
    let U2i_is_foreseen_type_of_medium_of_performance_in =
        _prefix "U2i_is_foreseen_type_of_medium_of_performance_in"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U30_foresees_quantity_of_mop"></see>
    /// </summary>
    let U30_foresees_quantity_of_mop = _prefix "U30_foresees_quantity_of_mop"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U31_had_function"></see>
    /// </summary>
    let U31_had_function = _prefix "U31_had_function"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U31i_was_function_of"></see>
    /// </summary>
    let U31i_was_function_of = _prefix "U31i_was_function_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U32_had_responsibility"></see>
    /// </summary>
    let U32_had_responsibility = _prefix "U32_had_responsibility"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U32i_was_responsibility_of"></see>
    /// </summary>
    let U32i_was_responsibility_of = _prefix "U32i_was_responsibility_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U33_has_set_of_characters"></see>
    /// </summary>
    let U33_has_set_of_characters = _prefix "U33_has_set_of_characters"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U33i_is_set_of_characters_of"></see>
    /// </summary>
    let U33i_is_set_of_characters_of = _prefix "U33i_is_set_of_characters_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U34_foresees_character"></see>
    /// </summary>
    let U34_foresees_character = _prefix "U34_foresees_character"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U34i_is_foreseen_character_of"></see>
    /// </summary>
    let U34i_is_foreseen_character_of = _prefix "U34i_is_foreseen_character_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U35_foresees_function"></see>
    /// </summary>
    let U35_foresees_function = _prefix "U35_foresees_function"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U35i_is_foreseen_function_of"></see>
    /// </summary>
    let U35i_is_foreseen_function_of = _prefix "U35i_is_foreseen_function_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U36_foresees_responsibility"></see>
    /// </summary>
    let U36_foresees_responsibility = _prefix "U36_foresees_responsibility"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U36i_is_foreseen_responsibility_of"></see>
    /// </summary>
    let U36i_is_foreseen_responsibility_of =
        _prefix "U36i_is_foreseen_responsibility_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U37_foresees_performing_character"></see>
    /// </summary>
    let U37_foresees_performing_character = _prefix "U37_foresees_performing_character"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U37i_is_foreseen_character_in"></see>
    /// </summary>
    let U37i_is_foreseen_character_in = _prefix "U37i_is_foreseen_character_in"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U38_has_descriptive_expression"></see>
    /// </summary>
    let U38_has_descriptive_expression = _prefix "U38_has_descriptive_expression"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U38i_is_descriptive_expression_of"></see>
    /// </summary>
    let U38i_is_descriptive_expression_of = _prefix "U38i_is_descriptive_expression_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U39_has_tuned"></see>
    /// </summary>
    let U39_has_tuned = _prefix "U39_has_tuned"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U39i_was_tuned_by"></see>
    /// </summary>
    let U39i_was_tuned_by = _prefix "U39i_was_tuned_by"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U3_foresees_use_of_specific_object"></see>
    /// </summary>
    let U3_foresees_use_of_specific_object =
        _prefix "U3_foresees_use_of_specific_object"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U3i_is_foreseen_specific_object_in"></see>
    /// </summary>
    let U3i_is_foreseen_specific_object_in =
        _prefix "U3i_is_foreseen_specific_object_in"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U40_has_catalogue_name"></see>
    /// </summary>
    let U40_has_catalogue_name = _prefix "U40_has_catalogue_name"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U40i_is_catalogue_name_of"></see>
    /// </summary>
    let U40i_is_catalogue_name_of = _prefix "U40i_is_catalogue_name_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U41_has_catalogue_number"></see>
    /// </summary>
    let U41_has_catalogue_number = _prefix "U41_has_catalogue_number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U42_has_opus_number"></see>
    /// </summary>
    let U42_has_opus_number = _prefix "U42_has_opus_number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U43_has_opus_subnumber"></see>
    /// </summary>
    let U43_has_opus_subnumber = _prefix "U43_has_opus_subnumber"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U44_has_dedication_statement"></see>
    /// </summary>
    let U44_has_dedication_statement = _prefix "U44_has_dedication_statement"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U44i_is_dedication_statement_of"></see>
    /// </summary>
    let U44i_is_dedication_statement_of = _prefix "U44i_is_dedication_statement_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U45_has_metronome_indication"></see>
    /// </summary>
    let U45_has_metronome_indication = _prefix "U45_has_metronome_indication"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U45i_is_metronome_indication_of"></see>
    /// </summary>
    let U45i_is_metronome_indication_of = _prefix "U45i_is_metronome_indication_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U46_occurred_in_context"></see>
    /// </summary>
    let U46_occurred_in_context = _prefix "U46_occurred_in_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U46i_was_context_of"></see>
    /// </summary>
    let U46i_was_context_of = _prefix "U46i_was_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U47_has_derivation_type"></see>
    /// </summary>
    let U47_has_derivation_type = _prefix "U47_has_derivation_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U47i_is_derivation_type_of"></see>
    /// </summary>
    let U47i_is_derivation_type_of = _prefix "U47i_is_derivation_type_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U48_foresees_quantity_of_actors"></see>
    /// </summary>
    let U48_foresees_quantity_of_actors = _prefix "U48_foresees_quantity_of_actors"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U49_created_for_actor"></see>
    /// </summary>
    let U49_created_for_actor = _prefix "U49_created_for_actor"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U49i_actor_motivated"></see>
    /// </summary>
    let U49i_actor_motivated = _prefix "U49i_actor_motivated"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U4_had_princeps_publication"></see>
    /// </summary>
    let U4_had_princeps_publication = _prefix "U4_had_princeps_publication"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U4i_was_princeps_publication_of"></see>
    /// </summary>
    let U4i_was_princeps_publication_of = _prefix "U4i_was_princeps_publication_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U50_has_annotation"></see>
    /// </summary>
    let U50_has_annotation = _prefix "U50_has_annotation"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U51_is_partial_or_full_recording_of"></see>
    /// </summary>
    let U51_is_partial_or_full_recording_of =
        _prefix "U51_is_partial_or_full_recording_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U51i_has_partial_or_full_recording"></see>
    /// </summary>
    let U51i_has_partial_or_full_recording =
        _prefix "U51i_has_partial_or_full_recording"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U52_has_context"></see>
    /// </summary>
    let U52_has_context = _prefix "U52_has_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U52i_is_context_of"></see>
    /// </summary>
    let U52i_is_context_of = _prefix "U52i_is_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U53_has_duration"></see>
    /// </summary>
    let U53_has_duration = _prefix "U53_has_duration"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U53i_is_duration_of"></see>
    /// </summary>
    let U53i_is_duration_of = _prefix "U53i_is_duration_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U54_is_performed_expression_of"></see>
    /// </summary>
    let U54_is_performed_expression_of = _prefix "U54_is_performed_expression_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U54i_has_performed_expression"></see>
    /// </summary>
    let U54i_has_performed_expression = _prefix "U54i_has_performed_expression"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U55_incorporates_performed_expression"></see>
    /// </summary>
    let U55_incorporates_performed_expression =
        _prefix "U55_incorporates_performed_expression"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U55i_performed_expression_is_incorporated_in"></see>
    /// </summary>
    let U55i_performed_expression_is_incorporated_in =
        _prefix "U55i_performed_expression_is_incorporated_in"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U56_occurred_in_historical_context"></see>
    /// </summary>
    let U56_occurred_in_historical_context =
        _prefix "U56_occurred_in_historical_context"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U56i_was_historical_context_of"></see>
    /// </summary>
    let U56i_was_historical_context_of = _prefix "U56i_was_historical_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U57_occurred_in_religious_context"></see>
    /// </summary>
    let U57_occurred_in_religious_context = _prefix "U57_occurred_in_religious_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U57i_was_religious_context_of"></see>
    /// </summary>
    let U57i_was_religious_context_of = _prefix "U57i_was_religious_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U58_has_full_published_recording"></see>
    /// </summary>
    let U58_has_full_published_recording = _prefix "U58_has_full_published_recording"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U58i_is_full_published_recording_of"></see>
    /// </summary>
    let U58i_is_full_published_recording_of =
        _prefix "U58i_is_full_published_recording_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U59_has_partial_published_recording"></see>
    /// </summary>
    let U59_has_partial_published_recording =
        _prefix "U59_has_partial_published_recording"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U59i_is_partial_published_recording_of"></see>
    /// </summary>
    let U59i_is_partial_published_recording_of =
        _prefix "U59i_is_partial_published_recording_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U5_had_premiere"></see>
    /// </summary>
    let U5_had_premiere = _prefix "U5_had_premiere"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U5i_was_premiere_of"></see>
    /// </summary>
    let U5i_was_premiere_of = _prefix "U5i_was_premiere_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U60_occurred_in_cultural_context"></see>
    /// </summary>
    let U60_occurred_in_cultural_context = _prefix "U60_occurred_in_cultural_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U60i_was_cultural_context_of"></see>
    /// </summary>
    let U60i_was_cultural_context_of = _prefix "U60i_was_cultural_context_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U61_occurred_in_geographical_context"></see>
    /// </summary>
    let U61_occurred_in_geographical_context =
        _prefix "U61_occurred_in_geographical_context"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U61i_was_geographical_context_of"></see>
    /// </summary>
    let U61i_was_geographical_context_of = _prefix "U61i_was_geographical_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U62_has_form"></see>
    /// </summary>
    let U62_has_form = _prefix "U62_has_form"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U62i_is_form_of"></see>
    /// </summary>
    let U62i_is_form_of = _prefix "U62i_is_form_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U63_has_religious_context"></see>
    /// </summary>
    let U63_has_religious_context = _prefix "U63_has_religious_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U63i_is_religious_context_of"></see>
    /// </summary>
    let U63i_is_religious_context_of = _prefix "U63i_is_religious_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U64_has_cultural_context"></see>
    /// </summary>
    let U64_has_cultural_context = _prefix "U64_has_cultural_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U64i_is_cultural_context_of"></see>
    /// </summary>
    let U64i_is_cultural_context_of = _prefix "U64i_is_cultural_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U65_has_geographical_context"></see>
    /// </summary>
    let U65_has_geographical_context = _prefix "U65_has_geographical_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U65i_is_geographical_context_of"></see>
    /// </summary>
    let U65i_is_geographical_context_of = _prefix "U65i_is_geographical_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U66_has_historical_context"></see>
    /// </summary>
    let U66_has_historical_context = _prefix "U66_has_historical_context"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U66i_is_historical_context_of"></see>
    /// </summary>
    let U66i_is_historical_context_of = _prefix "U66i_is_historical_context_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U67_has_subtitle"></see>
    /// </summary>
    let U67_has_subtitle = _prefix "U67_has_subtitle"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U68_has_variant_title"></see>
    /// </summary>
    let U68_has_variant_title = _prefix "U68_has_variant_title"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U69_has_WoO_number"></see>
    /// </summary>
    let U69_has_WoO_number = _prefix "U69_has_WoO_number"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U6_foresees_actor"></see>
    /// </summary>
    let U6_foresees_actor = _prefix "U6_foresees_actor"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U6i_is_foreseen_actor_of"></see>
    /// </summary>
    let U6i_is_foreseen_actor_of = _prefix "U6i_is_foreseen_actor_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U70_has_original_title"></see>
    /// </summary>
    let U70_has_original_title = _prefix "U70_has_original_title"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U71_has_uniform_title"></see>
    /// </summary>
    let U71_has_uniform_title = _prefix "U71_has_uniform_title"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U72_has_title_note"></see>
    /// </summary>
    let U72_has_title_note = _prefix "U72_has_title_note"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U73_is_derivative_of"></see>
    /// </summary>
    let U73_is_derivative_of = _prefix "U73_is_derivative_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U73i_has_derivative"></see>
    /// </summary>
    let U73i_has_derivative = _prefix "U73i_has_derivative"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U74_cited"></see>
    /// </summary>
    let U74_cited = _prefix "U74_cited"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U74i_was_cited_by"></see>
    /// </summary>
    let U74i_was_cited_by = _prefix "U74i_was_cited_by"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U75_has_harmonic_structure"></see>
    /// </summary>
    let U75_has_harmonic_structure = _prefix "U75_has_harmonic_structure"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U75i_is_harmonic_structure_of"></see>
    /// </summary>
    let U75i_is_harmonic_structure_of = _prefix "U75i_is_harmonic_structure_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U76_has_WoO_subnumber"></see>
    /// </summary>
    let U76_has_WoO_subnumber = _prefix "U76_has_WoO_subnumber"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U77_foresees_performing_plan"></see>
    /// </summary>
    let U77_foresees_performing_plan = _prefix "U77_foresees_performing_plan"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U77i_is_foreseen_plan_in"></see>
    /// </summary>
    let U77i_is_foreseen_plan_in = _prefix "U77i_is_foreseen_plan_in"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U78_estimated_duration"></see>
    /// </summary>
    let U78_estimated_duration = _prefix "U78_estimated_duration"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U79_has_lowest_pitch"></see>
    /// </summary>
    let U79_has_lowest_pitch = _prefix "U79_has_lowest_pitch"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U7_foresees_place_at"></see>
    /// </summary>
    let U7_foresees_place_at = _prefix "U7_foresees_place_at"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U7i_is_foreseen_place_of"></see>
    /// </summary>
    let U7i_is_foreseen_place_of = _prefix "U7i_is_foreseen_place_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U80_has_highest_pitch"></see>
    /// </summary>
    let U80_has_highest_pitch = _prefix "U80_has_highest_pitch"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U81_had_performer_status"></see>
    /// </summary>
    let U81_had_performer_status = _prefix "U81_had_performer_status"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U81i_is_performer_status_of"></see>
    /// </summary>
    let U81i_is_performer_status_of = _prefix "U81i_is_performer_status_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U82_has_foreseen_performer_status"></see>
    /// </summary>
    let U82_has_foreseen_performer_status = _prefix "U82_has_foreseen_performer_status"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U82i_is_foreseen_performer_status_of"></see>
    /// </summary>
    let U82i_is_foreseen_performer_status_of =
        _prefix "U82i_is_foreseen_performer_status_of"

    /// <summary>
    /// Examples: the key of 'C major' has 'A minor' as relative key
    /// Scope Note: This class allows to connect two M4 Keys that are in a relative relationship, i.e. one is the relative major or minor of the other one.
    /// see also http://en.wikipedia.org/wiki/Relative_key
    /// <see href="http://data.doremus.org/ontology#U83_has_relative_key"></see></summary>
    let U83_has_relative_key = _prefix "U83_has_relative_key"
    /// <summary>
    /// Scope Note: This class allows to connect two M4 Keys that are in a parallel relationship, i.e. one is the parallel major or minor of the other one.
    /// Examples: the key of 'C major' has 'C minor' as parallel key
    /// see also http://en.wikipedia.org/wiki/Parallel_key
    /// <see href="http://data.doremus.org/ontology#U84_has_parallel_key"></see></summary>
    let U84_has_parallel_key = _prefix "U84_has_parallel_key"
    /// <summary>
    /// see also http://en.wikipedia.org/wiki/Closely_related_key
    /// Examples: the key of 'C major' has 'G major' and 'D minor' as closely related keys
    /// Scope Note: This class allows to connect two M4 Keys that are mutually closely related from an harmonic point of view, e.g. they are commonly used destinations or transpositions in a modulation.
    /// <see href="http://data.doremus.org/ontology#U85_has_closely_related_key"></see></summary>
    let U85_has_closely_related_key = _prefix "U85_has_closely_related_key"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U87_has_member_casting_detail"></see>
    /// </summary>
    let U87_has_member_casting_detail = _prefix "U87_has_member_casting_detail"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U87i_is_member_casting_detail_of"></see>
    /// </summary>
    let U87i_is_member_casting_detail_of = _prefix "U87i_is_member_casting_detail_of"

    /// <summary>
    /// U88 has medium of performance section
    /// <see href="http://data.doremus.org/ontology#U88_has_medium_of_performance_section"></see></summary>
    let U88_has_medium_of_performance_section =
        _prefix "U88_has_medium_of_performance_section"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U88i_is_member_of_performance_section_of"></see>
    /// </summary>
    let U88i_is_member_of_performance_section_of =
        _prefix "U88i_is_member_of_performance_section_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U89_occured_in_performance_conditions"></see>
    /// </summary>
    let U89_occured_in_performance_conditions =
        _prefix "U89_occured_in_performance_conditions"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U89i_were_performance_conditions_of"></see>
    /// </summary>
    let U89i_were_performance_conditions_of =
        _prefix "U89i_were_performance_conditions_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U8_foresees_time_span"></see>
    /// </summary>
    let U8_foresees_time_span = _prefix "U8_foresees_time_span"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U8i_is_foreseen_time_span_of"></see>
    /// </summary>
    let U8i_is_foreseen_time_span_of = _prefix "U8i_is_foreseen_time_span_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U90_foresees_creation_or_performance_mode"></see>
    /// </summary>
    let U90_foresees_creation_or_performance_mode =
        _prefix "U90_foresees_creation_or_performance_mode"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U90i_were_performance_conditions_of"></see>
    /// </summary>
    let U90i_were_performance_conditions_of =
        _prefix "U90i_were_performance_conditions_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U91_put_into_effect"></see>
    /// </summary>
    let U91_put_into_effect = _prefix "U91_put_into_effect"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U91i_was_put_into_effect_through"></see>
    /// </summary>
    let U91i_was_put_into_effect_through = _prefix "U91i_was_put_into_effect_through"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U92_foresees_to_put_into_effect"></see>
    /// </summary>
    let U92_foresees_to_put_into_effect = _prefix "U92_foresees_to_put_into_effect"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U92_is_foreseen_to_be_put_into_effect_through"></see>
    /// </summary>
    let U92_is_foreseen_to_be_put_into_effect_through =
        _prefix "U92_is_foreseen_to_be_put_into_effect_through"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U93_is_realised_in"></see>
    /// </summary>
    let U93_is_realised_in = _prefix "U93_is_realised_in"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U93i_realises"></see>
    /// </summary>
    let U93i_realises = _prefix "U93i_realises"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U94_has_work_type"></see>
    /// </summary>
    let U94_has_work_type = _prefix "U94_has_work_type"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U94i_is_work_type_of"></see>
    /// </summary>
    let U94i_is_work_type_of = _prefix "U94i_is_work_type_of"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U95_has_hierarchical_level"></see>
    /// </summary>
    let U95_has_hierarchical_level = _prefix "U95_has_hierarchical_level"
    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U95i_is_hierarchical_level_of"></see>
    /// </summary>
    let U95i_is_hierarchical_level_of = _prefix "U95i_is_hierarchical_level_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U96_foresees_vocal_or_instrumental_technique"></see>
    /// </summary>
    let U96_foresees_vocal_or_instrumental_technique =
        _prefix "U96_foresees_vocal_or_instrumental_technique"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U96i_is_foreseen_vocal_or_instrumental_technique_of"></see>
    /// </summary>
    let U96i_is_foreseen_vocal_or_instrumental_technique_of =
        _prefix "U96i_is_foreseen_vocal_or_instrumental_technique_of"

    /// <summary>
    ///   <see href="http://data.doremus.org/ontology#U9_has_quantity"></see>
    /// </summary>
    let U9_has_quantity = _prefix "U9_has_quantity"

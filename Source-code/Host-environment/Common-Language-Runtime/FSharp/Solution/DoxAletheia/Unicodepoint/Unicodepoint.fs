module DoxAletheia.Unicodepoint
open IntervalErgonomics

module Plane =

    /// BMP
    let Basic_Multilingual_Plane = 0x0000 +-+ 0xFFFF
    /// SMP
    let Supplementary_Multilingual_Plane = 0x10000 +-+ 0x1FFFF
    /// SIP
    let Supplementary_Ideographic_Plane = 0x20000 +-+ 0x2FFFF
    /// unassigned
    let Tertiary_Ideographic_Plane = 0x30000 +-+ 0x3FFFF
    /// unassigned
    let Plane_5 = 0x40000 +-+ 0x4FFFF
    /// unassigned
    let Plane_6 = 0x50000 +-+ 0x5FFFF
    /// unassigned
    let Plane_7 = 0x60000 +-+ 0x6FFFF
    /// unassigned
    let Plane_8 = 0x70000 +-+ 0x7FFFF
    /// unassigned
    let Plane_9 = 0x80000 +-+ 0x8FFFF
    /// unassigned
    let Plane_10 = 0x90000 +-+ 0x9FFFF
    /// unassigned
    let Plane_11 = 0xA0000 +-+ 0xAFFFF
    /// unassigned
    let Plane_12 = 0xB0000 +-+ 0xBFFFF
    /// unassigned
    let Plane_13 = 0xC0000 +-+ 0xCFFFF
    /// unassigned
    let Plane_14 = 0xD0000 +-+ 0xDFFFF

    /// SSP
    let ``Supplement­ary_Special_purpose_Plane`` = 0xE0000 +-+ 0xEFFFF

    /// PUA
    let ``Supplement­ary_Private_Use_Area_plane_A`` = 0xF0000 +-+ 0xFFFFF

    /// PUA
    let ``Supplement­ary_Private_Use_Area_plane_B`` = 0x100000 +-+ 0x10FFFF

module Block =

    let Basic_Latin = 0x0000 +-+ 0x007F
    let Latin_1_Supplement = 0x0080 +-+ 0x00FF
    let Latin_Extended_A = 0x0100 +-+ 0x017F
    let Latin_Extended_B = 0x0180 +-+ 0x024F
    let IPA_Extensions = 0x0250 +-+ 0x02AF
    let Spacing_Modifier_Letters = 0x02B0 +-+ 0x02FF
    let Combining_Diacritical_Marks = 0x0300 +-+ 0x036F
    let Greek_and_Coptic = 0x0370 +-+ 0x03FF
    let Cyrillic = 0x0400 +-+ 0x04FF
    let Cyrillic_Supplement = 0x0500 +-+ 0x052F
    let Armenian = 0x0530 +-+ 0x058F
    let Hebrew = 0x0590 +-+ 0x05FF
    let Arabic = 0x0600 +-+ 0x06FF
    let Syriac = 0x0700 +-+ 0x074F
    let Arabic_Supplement = 0x0750 +-+ 0x077F
    let Thaana = 0x0780 +-+ 0x07BF
    let NKo = 0x07C0 +-+ 0x07FF
    let Samaritan = 0x0800 +-+ 0x083F
    let Mandaic = 0x0840 +-+ 0x085F
    let Syriac_Supplement = 0x0860 +-+ 0x086F
    let Arabic_Extended_A = 0x08A0 +-+ 0x08FF
    let Devanagari = 0x0900 +-+ 0x097F
    let Bengali = 0x0980 +-+ 0x09FF
    let Gurmukhi = 0x0A00 +-+ 0x0A7F
    let Gujarati = 0x0A80 +-+ 0x0AFF
    let Oriya = 0x0B00 +-+ 0x0B7F
    let Tamil = 0x0B80 +-+ 0x0BFF
    let Telugu = 0x0C00 +-+ 0x0C7F
    let Kannada = 0x0C80 +-+ 0x0CFF
    let Malayalam = 0x0D00 +-+ 0x0D7F
    let Sinhala = 0x0D80 +-+ 0x0DFF
    let Thai = 0x0E00 +-+ 0x0E7F
    let Lao = 0x0E80 +-+ 0x0EFF
    let Tibetan = 0x0F00 +-+ 0x0FFF
    let Myanmar = 0x1000 +-+ 0x109F
    let Georgian = 0x10A0 +-+ 0x10FF
    let Hangul_Jamo = 0x1100 +-+ 0x11FF
    let Ethiopic = 0x1200 +-+ 0x137F
    let Ethiopic_Supplement = 0x1380 +-+ 0x139F
    let Cherokee = 0x13A0 +-+ 0x13FF

    let Unified_Canadian_Aboriginal_Syllabics = 0x1400 +-+ 0x167F

    let Ogham = 0x1680 +-+ 0x169F
    let Runic = 0x16A0 +-+ 0x16FF
    let Tagalog = 0x1700 +-+ 0x171F
    let Hanunoo = 0x1720 +-+ 0x173F
    let Buhid = 0x1740 +-+ 0x175F
    let Tagbanwa = 0x1760 +-+ 0x177F
    let Khmer = 0x1780 +-+ 0x17FF
    let Mongolian = 0x1800 +-+ 0x18AF

    let Unified_Canadian_Aboriginal_Syllabics_Extended = 0x18B0 +-+ 0x18FF

    let Limbu = 0x1900 +-+ 0x194F
    let Tai_Le = 0x1950 +-+ 0x197F
    let New_Tai_Lue = 0x1980 +-+ 0x19DF
    let Khmer_Symbols = 0x19E0 +-+ 0x19FF
    let Buginese = 0x1A00 +-+ 0x1A1F
    let Tai_Tham = 0x1A20 +-+ 0x1AAF
    let Combining_Diacritical_Marks_Extended = 0x1AB0 +-+ 0x1AFF
    let Balinese = 0x1B00 +-+ 0x1B7F
    let Sundanese = 0x1B80 +-+ 0x1BBF
    let Batak = 0x1BC0 +-+ 0x1BFF
    let Lepcha = 0x1C00 +-+ 0x1C4F
    let Ol_Chiki = 0x1C50 +-+ 0x1C7F
    let Cyrillic_Extended_C = 0x1C80 +-+ 0x1C8F
    let Georgian_Extended = 0x1C90 +-+ 0x1CBF
    let Sundanese_Supplement = 0x1CC0 +-+ 0x1CCF
    let Vedic_Extensions = 0x1CD0 +-+ 0x1CFF
    let Phonetic_Extensions = 0x1D00 +-+ 0x1D7F
    let Phonetic_Extensions_Supplement = 0x1D80 +-+ 0x1DBF

    let Combining_Diacritical_Marks_Supplement = 0x1DC0 +-+ 0x1DFF

    let Latin_Extended_Additional = 0x1E00 +-+ 0x1EFF
    let Greek_Extended = 0x1F00 +-+ 0x1FFF
    let General_Punctuation = 0x2000 +-+ 0x206F
    let Superscripts_and_Subscripts = 0x2070 +-+ 0x209F
    let Currency_Symbols = 0x20A0 +-+ 0x20CF

    let Combining_Diacritical_Marks_for_Symbols = 0x20D0 +-+ 0x20FF

    let Letterlike_Symbols = 0x2100 +-+ 0x214F
    let Number_Forms = 0x2150 +-+ 0x218F
    let Arrows = 0x2190 +-+ 0x21FF
    let Mathematical_Operators = 0x2200 +-+ 0x22FF
    let Miscellaneous_Technical = 0x2300 +-+ 0x23FF
    let Control_Pictures = 0x2400 +-+ 0x243F
    let Optical_Character_Recognition = 0x2440 +-+ 0x245F
    let Enclosed_Alphanumerics = 0x2460 +-+ 0x24FF
    let Box_Drawing = 0x2500 +-+ 0x257F
    let Block_Elements = 0x2580 +-+ 0x259F
    let Geometric_Shapes = 0x25A0 +-+ 0x25FF
    let Miscellaneous_Symbols = 0x2600 +-+ 0x26FF
    let Dingbats = 0x2700 +-+ 0x27BF
    let Miscellaneous_Mathematical_Symbols_A = 0x27C0 +-+ 0x27EF
    let Supplemental_Arrows_A = 0x27F0 +-+ 0x27FF
    let Braille_Patterns = 0x2800 +-+ 0x28FF
    let Supplemental_Arrows_B = 0x2900 +-+ 0x297F
    let Miscellaneous_Mathematical_Symbols_B = 0x2980 +-+ 0x29FF
    let Supplemental_Mathematical_Operators = 0x2A00 +-+ 0x2AFF
    let Miscellaneous_Symbols_and_Arrows = 0x2B00 +-+ 0x2BFF
    let Glagolitic = 0x2C00 +-+ 0x2C5F
    let Latin_Extended_C = 0x2C60 +-+ 0x2C7F
    let Coptic = 0x2C80 +-+ 0x2CFF
    let Georgian_Supplement = 0x2D00 +-+ 0x2D2F
    let Tifinagh = 0x2D30 +-+ 0x2D7F
    let Ethiopic_Extended = 0x2D80 +-+ 0x2DDF
    let Cyrillic_Extended_A = 0x2DE0 +-+ 0x2DFF
    let Supplemental_Punctuation = 0x2E00 +-+ 0x2E7F
    let CJK_Radicals_Supplement = 0x2E80 +-+ 0x2EFF
    let Kangxi_Radicals = 0x2F00 +-+ 0x2FDF
    let Ideographic_Description_Characters = 0x2FF0 +-+ 0x2FFF
    let CJK_Symbols_and_Punctuation = 0x3000 +-+ 0x303F
    let Hiragana = 0x3040 +-+ 0x309F
    let Katakana = 0x30A0 +-+ 0x30FF
    let Bopomofo = 0x3100 +-+ 0x312F
    let Hangul_Compatibility_Jamo = 0x3130 +-+ 0x318F
    let Kanbun = 0x3190 +-+ 0x319F
    let Bopomofo_Extended = 0x31A0 +-+ 0x31BF
    let CJK_Strokes = 0x31C0 +-+ 0x31EF
    let Katakana_Phonetic_Extensions = 0x31F0 +-+ 0x31FF
    let Enclosed_CJK_Letters_and_Months = 0x3200 +-+ 0x32FF
    let CJK_Compatibility = 0x3300 +-+ 0x33FF
    let CJK_Unified_Ideographs_Extension_A = 0x3400 +-+ 0x4DBF
    let Yijing_Hexagram_Symbols = 0x4DC0 +-+ 0x4DFF
    let CJK_Unified_Ideographs = 0x4E00 +-+ 0x9FFF
    let Yi_Syllables = 0xA000 +-+ 0xA48F
    let Yi_Radicals = 0xA490 +-+ 0xA4CF
    let Lisu = 0xA4D0 +-+ 0xA4FF
    let Vai = 0xA500 +-+ 0xA63F
    let Cyrillic_Extended_B = 0xA640 +-+ 0xA69F
    let Bamum = 0xA6A0 +-+ 0xA6FF
    let Modifier_Tone_Letters = 0xA700 +-+ 0xA71F
    let Latin_Extended_D = 0xA720 +-+ 0xA7FF
    let Syloti_Nagri = 0xA800 +-+ 0xA82F
    let Common_Indic_Number_Forms = 0xA830 +-+ 0xA83F
    let Phags_pa = 0xA840 +-+ 0xA87F
    let Saurashtra = 0xA880 +-+ 0xA8DF
    let Devanagari_Extended = 0xA8E0 +-+ 0xA8FF
    let Kayah_Li = 0xA900 +-+ 0xA92F
    let Rejang = 0xA930 +-+ 0xA95F
    let Hangul_Jamo_Extended_A = 0xA960 +-+ 0xA97F
    let Javanese = 0xA980 +-+ 0xA9DF
    let Myanmar_Extended_B = 0xA9E0 +-+ 0xA9FF
    let Cham = 0xAA00 +-+ 0xAA5F
    let Myanmar_Extended_A = 0xAA60 +-+ 0xAA7F
    let Tai_Viet = 0xAA80 +-+ 0xAADF
    let Meetei_Mayek_Extensions = 0xAAE0 +-+ 0xAAFF
    let Ethiopic_Extended_A = 0xAB00 +-+ 0xAB2F
    let Latin_Extended_E = 0xAB30 +-+ 0xAB6F
    let Cherokee_Supplement = 0xAB70 +-+ 0xABBF
    let Meetei_Mayek = 0xABC0 +-+ 0xABFF
    let Hangul_Syllables = 0xAC00 +-+ 0xD7AF
    let Hangul_Jamo_Extended_B = 0xD7B0 +-+ 0xD7FF
    let High_Surrogates = 0xD800 +-+ 0xDB7F
    let High_Private_Use_Surrogates = 0xDB80 +-+ 0xDBFF
    let Low_Surrogates = 0xDC00 +-+ 0xDFFF
    let Private_Use_Area = 0xE000 +-+ 0xF8FF
    let CJK_Compatibility_Ideographs = 0xF900 +-+ 0xFAFF
    let Alphabetic_Presentation_Forms = 0xFB00 +-+ 0xFB4F
    let Arabic_Presentation_Forms_A = 0xFB50 +-+ 0xFDFF
    let Variation_Selectors = 0xFE00 +-+ 0xFE0F
    let Vertical_Forms = 0xFE10 +-+ 0xFE1F
    let Combining_Half_Marks = 0xFE20 +-+ 0xFE2F
    let CJK_Compatibility_Forms = 0xFE30 +-+ 0xFE4F
    let Small_Form_Variants = 0xFE50 +-+ 0xFE6F
    let Arabic_Presentation_Forms_B = 0xFE70 +-+ 0xFEFF
    let Halfwidth_and_Fullwidth_Forms = 0xFF00 +-+ 0xFFEF
    let Specials = 0xFFF0 +-+ 0xFFFF
    let Linear_B_Syllabary = 0x10000 +-+ 0x1007F
    let Linear_B_Ideograms = 0x10080 +-+ 0x100FF
    let Aegean_Numbers = 0x10100 +-+ 0x1013F
    let Ancient_Greek_Numbers = 0x10140 +-+ 0x1018F
    let Ancient_Symbols = 0x10190 +-+ 0x101CF
    let Phaistos_Disc = 0x101D0 +-+ 0x101FF
    let Lycian = 0x10280 +-+ 0x1029F
    let Carian = 0x102A0 +-+ 0x102DF
    let Coptic_Epact_Numbers = 0x102E0 +-+ 0x102FF
    let Old_Italic = 0x10300 +-+ 0x1032F
    let Gothic = 0x10330 +-+ 0x1034F
    let Old_Permic = 0x10350 +-+ 0x1037F
    let Ugaritic = 0x10380 +-+ 0x1039F
    let Old_Persian = 0x103A0 +-+ 0x103DF
    let Deseret = 0x10400 +-+ 0x1044F
    let Shavian = 0x10450 +-+ 0x1047F
    let Osmanya = 0x10480 +-+ 0x104AF
    let Osage = 0x104B0 +-+ 0x104FF
    let Elbasan = 0x10500 +-+ 0x1052F
    let Caucasian_Albanian = 0x10530 +-+ 0x1056F
    let Linear_A = 0x10600 +-+ 0x1077F
    let Cypriot_Syllabary = 0x10800 +-+ 0x1083F
    let Imperial_Aramaic = 0x10840 +-+ 0x1085F
    let Palmyrene = 0x10860 +-+ 0x1087F
    let Nabataean = 0x10880 +-+ 0x108AF
    let Hatran = 0x108E0 +-+ 0x108FF
    let Phoenician = 0x10900 +-+ 0x1091F
    let Lydian = 0x10920 +-+ 0x1093F
    let Meroitic_Hieroglyphs = 0x10980 +-+ 0x1099F
    let Meroitic_Cursive = 0x109A0 +-+ 0x109FF
    let Kharoshthi = 0x10A00 +-+ 0x10A5F
    let Old_South_Arabian = 0x10A60 +-+ 0x10A7F
    let Old_North_Arabian = 0x10A80 +-+ 0x10A9F
    let Manichaean = 0x10AC0 +-+ 0x10AFF
    let Avestan = 0x10B00 +-+ 0x10B3F
    let Inscriptional_Parthian = 0x10B40 +-+ 0x10B5F
    let Inscriptional_Pahlavi = 0x10B60 +-+ 0x10B7F
    let Psalter_Pahlavi = 0x10B80 +-+ 0x10BAF
    let Old_Turkic = 0x10C00 +-+ 0x10C4F
    let Old_Hungarian = 0x10C80 +-+ 0x10CFF
    let Hanifi_Rohingya = 0x10D00 +-+ 0x10D3F
    let Rumi_Numeral_Symbols = 0x10E60 +-+ 0x10E7F
    let Yezidi = 0x10E80 +-+ 0x10EBF
    let Old_Sogdian = 0x10F00 +-+ 0x10F2F
    let Sogdian = 0x10F30 +-+ 0x10F6F
    let Chorasmian = 0x10FB0 +-+ 0x10FDF
    let Elymaic = 0x10FE0 +-+ 0x10FFF
    let Brahmi = 0x11000 +-+ 0x1107F
    let Kaithi = 0x11080 +-+ 0x110CF
    let Sora_Sompeng = 0x110D0 +-+ 0x110FF
    let Chakma = 0x11100 +-+ 0x1114F
    let Mahajani = 0x11150 +-+ 0x1117F
    let Sharada = 0x11180 +-+ 0x111DF
    let Sinhala_Archaic_Numbers = 0x111E0 +-+ 0x111FF
    let Khojki = 0x11200 +-+ 0x1124F
    let Multani = 0x11280 +-+ 0x112AF
    let Khudawadi = 0x112B0 +-+ 0x112FF
    let Grantha = 0x11300 +-+ 0x1137F
    let Newa = 0x11400 +-+ 0x1147F
    let Tirhuta = 0x11480 +-+ 0x114DF
    let Siddham = 0x11580 +-+ 0x115FF
    let Modi = 0x11600 +-+ 0x1165F
    let Mongolian_Supplement = 0x11660 +-+ 0x1167F
    let Takri = 0x11680 +-+ 0x116CF
    let Ahom = 0x11700 +-+ 0x1173F
    let Dogra = 0x11800 +-+ 0x1184F
    let Warang_Citi = 0x118A0 +-+ 0x118FF
    let Dives_Akuru = 0x11900 +-+ 0x1195F
    let Nandinagari = 0x119A0 +-+ 0x119FF
    let Zanabazar_Square = 0x11A00 +-+ 0x11A4F
    let Soyombo = 0x11A50 +-+ 0x11AAF
    let Pau_Cin_Hau = 0x11AC0 +-+ 0x11AFF
    let Bhaiksuki = 0x11C00 +-+ 0x11C6F
    let Marchen = 0x11C70 +-+ 0x11CBF
    let Masaram_Gondi = 0x11D00 +-+ 0x11D5F
    let Gunjala_Gondi = 0x11D60 +-+ 0x11DAF
    let Makasar = 0x11EE0 +-+ 0x11EFF
    let Lisu_Supplement = 0x11FB0 +-+ 0x11FBF
    let Tamil_Supplement = 0x11FC0 +-+ 0x11FFF
    let Cuneiform = 0x12000 +-+ 0x123FF
    let Cuneiform_Numbers_and_Punctuation = 0x12400 +-+ 0x1247F
    let Early_Dynastic_Cuneiform = 0x12480 +-+ 0x1254F
    let Egyptian_Hieroglyphs = 0x13000 +-+ 0x1342F

    let Egyptian_Hieroglyph_Format_Controls = 0x13430 +-+ 0x1343F

    let Anatolian_Hieroglyphs = 0x14400 +-+ 0x1467F
    let Bamum_Supplement = 0x16800 +-+ 0x16A3F
    let Mro = 0x16A40 +-+ 0x16A6F
    let Bassa_Vah = 0x16AD0 +-+ 0x16AFF
    let Pahawh_Hmong = 0x16B00 +-+ 0x16B8F
    let Medefaidrin = 0x16E40 +-+ 0x16E9F
    let Miao = 0x16F00 +-+ 0x16F9F

    let Ideographic_Symbols_and_Punctuation = 0x16FE0 +-+ 0x16FFF

    let Tangut = 0x17000 +-+ 0x187FF
    let Tangut_Components = 0x18800 +-+ 0x18AFF
    let Khitan_Small_Script = 0x18B00 +-+ 0x18CFF
    let Tangut_Supplement = 0x18D00 +-+ 0x18D8F
    let Kana_Supplement = 0x1B000 +-+ 0x1B0FF
    let Kana_Extended_A = 0x1B100 +-+ 0x1B12F
    let Small_Kana_Extension = 0x1B130 +-+ 0x1B16F
    let Nushu = 0x1B170 +-+ 0x1B2FF
    let Duployan = 0x1BC00 +-+ 0x1BC9F
    let Shorthand_Format_Controls = 0x1BCA0 +-+ 0x1BCAF
    let Byzantine_Musical_Symbols = 0x1D000 +-+ 0x1D0FF
    let Musical_Symbols = 0x1D100 +-+ 0x1D1FF
    let Ancient_Greek_Musical_Notation = 0x1D200 +-+ 0x1D24F
    let Mayan_Numerals = 0x1D2E0 +-+ 0x1D2FF
    let Tai_Xuan_Jing_Symbols = 0x1D300 +-+ 0x1D35F
    let Counting_Rod_Numerals = 0x1D360 +-+ 0x1D37F
    let Mathematical_Alphanumeric_Symbols = 0x1D400 +-+ 0x1D7FF
    let Sutton_SignWriting = 0x1D800 +-+ 0x1DAAF
    let Glagolitic_Supplement = 0x1E000 +-+ 0x1E02F
    let Nyiakeng_Puachue_Hmong = 0x1E100 +-+ 0x1E14F
    let Wancho = 0x1E2C0 +-+ 0x1E2FF
    let Mende_Kikakui = 0x1E800 +-+ 0x1E8DF
    let Adlam = 0x1E900 +-+ 0x1E95F
    let Indic_Siyaq_Numbers = 0x1EC70 +-+ 0x1ECBF
    let Ottoman_Siyaq_Numbers = 0x1ED00 +-+ 0x1ED4F

    let Arabic_Mathematical_Alphabetic_Symbols = 0x1EE00 +-+ 0x1EEFF

    let Mahjong_Tiles = 0x1F000 +-+ 0x1F02F
    let Domino_Tiles = 0x1F030 +-+ 0x1F09F
    let Playing_Cards = 0x1F0A0 +-+ 0x1F0FF
    let Enclosed_Alphanumeric_Supplement = 0x1F100 +-+ 0x1F1FF
    let Enclosed_Ideographic_Supplement = 0x1F200 +-+ 0x1F2FF

    let Miscellaneous_Symbols_and_Pictographs = 0x1F300 +-+ 0x1F5FF

    let Emoticons = 0x1F600 +-+ 0x1F64F
    let Ornamental_Dingbats = 0x1F650 +-+ 0x1F67F
    let Transport_and_Map_Symbols = 0x1F680 +-+ 0x1F6FF
    let Alchemical_Symbols = 0x1F700 +-+ 0x1F77F
    let Geometric_Shapes_Extended = 0x1F780 +-+ 0x1F7FF
    let Supplemental_Arrows_C = 0x1F800 +-+ 0x1F8FF

    let Supplemental_Symbols_and_Pictographs = 0x1F900 +-+ 0x1F9FF

    let Chess_Symbols = 0x1FA00 +-+ 0x1FA6F
    let Symbols_and_Pictographs_Extended_A = 0x1FA70 +-+ 0x1FAFF
    let Symbols_for_Legacy_Computing = 0x1FB00 +-+ 0x1FBFF
    let CJK_Unified_Ideographs_Extension_B = 0x20000 +-+ 0x2A6DF
    let CJK_Unified_Ideographs_Extension_C = 0x2A700 +-+ 0x2B73F
    let CJK_Unified_Ideographs_Extension_D = 0x2B740 +-+ 0x2B81F
    let CJK_Unified_Ideographs_Extension_E = 0x2B820 +-+ 0x2CEAF
    let CJK_Unified_Ideographs_Extension_F = 0x2CEB0 +-+ 0x2EBEF

    let CJK_Compatibility_Ideographs_Supplement = 0x2F800 +-+ 0x2FA1F

    let CJK_Unified_Ideographs_Extension_G = 0x30000 +-+ 0x3134F
    let Tags = 0xE0000 +-+ 0xE007F
    let Variation_Selectors_Supplement = 0xE0100 +-+ 0xE01EF
    let Supplementary_Private_Use_Area_A = 0xF0000 +-+ 0xFFFFF
    let Supplementary_Private_Use_Area_B = 0x100000 +-+ 0x10FFFF

module Partition =


    let Ascii_Digits = 0x0030 +-+ 0x0039

    let Latin_Majuscule = 0x0041 +-+ 0x005A

    let Latin_Minuscule = 0x0061 +-+ 0x007A
    let A_to_F = 0x0041 +-+ 0x0046

    let a_to_f = 0x0061 +-+ 0x0066
    let Latin_Letters =     
        Interval_Range.union Latin_Majuscule Latin_Minuscule
        |> IntervalSet.from_interval_list

    let Hexadecimal_Letters =     
        Interval_Range.union A_to_F a_to_f
        |> IntervalSet.from_interval_list




let Codespace = 0x0000 +-+ 0x10FFFF

let Surrogates =
    Interval_Range.union Block.High_Surrogates Block.Low_Surrogates
    |> IntervalSet.from_interval_list

let Scalars =
    Codespace
    |> Interval_Range.except [ Block.Low_Surrogates
                               Block.High_Surrogates

                                ]
    |> IntervalSet.from_interval_list


let interval_0_4 = 0 +-+ 4
let interval_0_5 = 0 +-+ 5
let interval_1_9 = 1 +-+ 9
















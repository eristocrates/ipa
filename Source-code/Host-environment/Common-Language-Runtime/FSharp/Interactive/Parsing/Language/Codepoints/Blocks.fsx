open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics

// TODO automate this one day

/// Excludes C1 Controls
type Latin_1_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x00A0 <= codepoint && codepoint <= 0x00FF

    static member parse: Parser<Latin_1_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_1_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "00A0..D7FF Latin 1 Supplement Excluding C1 Controls"

type Latin_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0100 <= codepoint && codepoint <= 0x017F

    static member parse: Parser<Latin_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AC00..D7AF Latin Extended A"

type Latin_Extended_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0180 <= codepoint && codepoint <= 0x024F

    static member parse: Parser<Latin_Extended_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "ABC0..ABFF Latin Extended B"

type IPA_Extensions_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0250 <= codepoint && codepoint <= 0x02AF

    static member parse: Parser<IPA_Extensions_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy IPA_Extensions_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AB70..ABBF IPA Extensions"

type Spacing_Modifier_Letters_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x02B0 <= codepoint && codepoint <= 0x02FF

    static member parse: Parser<Spacing_Modifier_Letters_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Spacing_Modifier_Letters_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AB30..AB6F Spacing Modifier Letters"

type Combining_Diacritical_Marks_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0300 <= codepoint && codepoint <= 0x036F

    static member parse: Parser<Combining_Diacritical_Marks_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Combining_Diacritical_Marks_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AB00..AB2F Combining Diacritical Marks"

type Greek_and_Coptic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0370 <= codepoint && codepoint <= 0x03FF

    static member parse: Parser<Greek_and_Coptic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Greek_and_Coptic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AAE0..AAFF Greek and Coptic"

type Cyrillic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0400 <= codepoint && codepoint <= 0x04FF

    static member parse: Parser<Cyrillic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cyrillic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AA80..AADF Cyrillic"

type Cyrillic_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0500 <= codepoint && codepoint <= 0x052F

    static member parse: Parser<Cyrillic_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cyrillic_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AA60..AA7F Cyrillic Supplement"

type Armenian_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0530 <= codepoint && codepoint <= 0x058F

    static member parse: Parser<Armenian_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Armenian_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "AA00..AA5F Armenian"

type Hebrew_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0590 <= codepoint && codepoint <= 0x05FF

    static member parse: Parser<Hebrew_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hebrew_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A9E0..A9FF Hebrew"

type Arabic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0600 <= codepoint && codepoint <= 0x06FF

    static member parse: Parser<Arabic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Arabic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A980..A9DF Arabic"

type Syriac_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0700 <= codepoint && codepoint <= 0x074F

    static member parse: Parser<Syriac_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Syriac_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A960..A97F Syriac"

type Arabic_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0750 <= codepoint && codepoint <= 0x077F

    static member parse: Parser<Arabic_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Arabic_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A930..A95F Arabic Supplement"

type Thaana_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0780 <= codepoint && codepoint <= 0x07BF

    static member parse: Parser<Thaana_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Thaana_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A900..A92F Thaana"

type NKo_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x07C0 <= codepoint && codepoint <= 0x07FF

    static member parse: Parser<NKo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy NKo_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A8E0..A8FF NKo"

type Samaritan_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0800 <= codepoint && codepoint <= 0x083F

    static member parse: Parser<Samaritan_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Samaritan_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A880..A8DF Samaritan"

type Mandaic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0840 <= codepoint && codepoint <= 0x085F

    static member parse: Parser<Mandaic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Mandaic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A840..A87F Mandaic"

type Syriac_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0860 <= codepoint && codepoint <= 0x086F

    static member parse: Parser<Syriac_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Syriac_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A830..A83F Syriac Supplement"

type Arabic_Extended_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0870 <= codepoint && codepoint <= 0x089F

    static member parse: Parser<Arabic_Extended_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Arabic_Extended_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A800..A82F Arabic Extended B"

type Arabic_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x08A0 <= codepoint && codepoint <= 0x08FF

    static member parse: Parser<Arabic_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Arabic_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A720..A7FF Arabic Extended A"

type Devanagari_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0900 <= codepoint && codepoint <= 0x097F

    static member parse: Parser<Devanagari_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Devanagari_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A700..A71F Devanagari"

type Bengali_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0980 <= codepoint && codepoint <= 0x09FF

    static member parse: Parser<Bengali_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Bengali_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A6A0..A6FF Bengali"

type Gurmukhi_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0A00 <= codepoint && codepoint <= 0x0A7F

    static member parse: Parser<Gurmukhi_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Gurmukhi_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A640..A69F Gurmukhi"

type Gujarati_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0A80 <= codepoint && codepoint <= 0x0AFF

    static member parse: Parser<Gujarati_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Gujarati_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A500..A63F Gujarati"

type Oriya_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0B00 <= codepoint && codepoint <= 0x0B7F

    static member parse: Parser<Oriya_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Oriya_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A4D0..A4FF Oriya"

type Tamil_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0B80 <= codepoint && codepoint <= 0x0BFF

    static member parse: Parser<Tamil_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tamil_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A490..A4CF Tamil"

type Telugu_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0C00 <= codepoint && codepoint <= 0x0C7F

    static member parse: Parser<Telugu_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Telugu_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "A000..A48F Telugu"

type Kannada_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0C80 <= codepoint && codepoint <= 0x0CFF

    static member parse: Parser<Kannada_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Kannada_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "4E00..9FFF Kannada"

type Malayalam_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0D00 <= codepoint && codepoint <= 0x0D7F

    static member parse: Parser<Malayalam_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Malayalam_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "4DC0..4DFF Malayalam"

type Sinhala_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0D80 <= codepoint && codepoint <= 0x0DFF

    static member parse: Parser<Sinhala_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Sinhala_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3400..4DBF Sinhala"

type Thai_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0E00 <= codepoint && codepoint <= 0x0E7F

    static member parse: Parser<Thai_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Thai_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3300..33FF Thai"

type Lao_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0E80 <= codepoint && codepoint <= 0x0EFF

    static member parse: Parser<Lao_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Lao_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3200..32FF Lao"

type Tibetan_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x0F00 <= codepoint && codepoint <= 0x0FFF

    static member parse: Parser<Tibetan_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tibetan_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "31F0..31FF Tibetan"

type Myanmar_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1000 <= codepoint && codepoint <= 0x109F

    static member parse: Parser<Myanmar_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Myanmar_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "31C0..31EF Myanmar"

type Georgian_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x10A0 <= codepoint && codepoint <= 0x10FF

    static member parse: Parser<Georgian_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Georgian_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "31A0..31BF Georgian"

type Hangul_Jamo_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1100 <= codepoint && codepoint <= 0x11FF

    static member parse: Parser<Hangul_Jamo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hangul_Jamo_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3190..319F Hangul Jamo"

type Ethiopic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1200 <= codepoint && codepoint <= 0x137F

    static member parse: Parser<Ethiopic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ethiopic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3130..318F Ethiopic"

type Ethiopic_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1380 <= codepoint && codepoint <= 0x139F

    static member parse: Parser<Ethiopic_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ethiopic_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3100..312F Ethiopic Supplement"

type Cherokee_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x13A0 <= codepoint && codepoint <= 0x13FF

    static member parse: Parser<Cherokee_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cherokee_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "30A0..30FF Cherokee"

type Unified_Canadian_Aboriginal_Syllabics_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1400 <= codepoint && codepoint <= 0x167F

    static member parse: Parser<Unified_Canadian_Aboriginal_Syllabics_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Unified_Canadian_Aboriginal_Syllabics_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3040..309F Unified Canadian Aboriginal Syllabics"

type Ogham_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1680 <= codepoint && codepoint <= 0x169F

    static member parse: Parser<Ogham_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ogham_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "3000..303F Ogham"

type Runic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x16A0 <= codepoint && codepoint <= 0x16FF

    static member parse: Parser<Runic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Runic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2FF0..2FFF Runic"

type Tagalog_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1700 <= codepoint && codepoint <= 0x171F

    static member parse: Parser<Tagalog_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tagalog_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2F00..2FDF Tagalog"

type Hanunoo_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1720 <= codepoint && codepoint <= 0x173F

    static member parse: Parser<Hanunoo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hanunoo_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2E80..2EFF Hanunoo"

type Buhid_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1740 <= codepoint && codepoint <= 0x175F

    static member parse: Parser<Buhid_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Buhid_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2E00..2E7F Buhid"

type Tagbanwa_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1760 <= codepoint && codepoint <= 0x177F

    static member parse: Parser<Tagbanwa_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tagbanwa_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2DE0..2DFF Tagbanwa"

type Khmer_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1780 <= codepoint && codepoint <= 0x17FF

    static member parse: Parser<Khmer_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Khmer_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2D80..2DDF Khmer"

type Mongolian_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1800 <= codepoint && codepoint <= 0x18AF

    static member parse: Parser<Mongolian_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Mongolian_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2D30..2D7F Mongolian"

type Unified_Canadian_Aboriginal_Syllabics_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x18B0 <= codepoint && codepoint <= 0x18FF

    static member parse: Parser<Unified_Canadian_Aboriginal_Syllabics_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Unified_Canadian_Aboriginal_Syllabics_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2D00..2D2F Unified Canadian Aboriginal Syllabics Extended"

type Limbu_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1900 <= codepoint && codepoint <= 0x194F

    static member parse: Parser<Limbu_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Limbu_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2C80..2CFF Limbu"

type Tai_Le_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1950 <= codepoint && codepoint <= 0x197F

    static member parse: Parser<Tai_Le_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tai_Le_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2C60..2C7F Tai Le"

type New_Tai_Lue_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1980 <= codepoint && codepoint <= 0x19DF

    static member parse: Parser<New_Tai_Lue_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy New_Tai_Lue_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2C00..2C5F New Tai Lue"

type Khmer_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x19E0 <= codepoint && codepoint <= 0x19FF

    static member parse: Parser<Khmer_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Khmer_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2B00..2BFF Khmer Symbols"

type Buginese_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1A00 <= codepoint && codepoint <= 0x1A1F

    static member parse: Parser<Buginese_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Buginese_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2A00..2AFF Buginese"

type Tai_Tham_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1A20 <= codepoint && codepoint <= 0x1AAF

    static member parse: Parser<Tai_Tham_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tai_Tham_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2980..29FF Tai Tham"

type Combining_Diacritical_Marks_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1AB0 <= codepoint && codepoint <= 0x1AFF

    static member parse: Parser<Combining_Diacritical_Marks_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Combining_Diacritical_Marks_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2900..297F Combining Diacritical Marks Extended"

type Balinese_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1B00 <= codepoint && codepoint <= 0x1B7F

    static member parse: Parser<Balinese_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Balinese_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2800..28FF Balinese"

type Sundanese_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1B80 <= codepoint && codepoint <= 0x1BBF

    static member parse: Parser<Sundanese_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Sundanese_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "27F0..27FF Sundanese"

type Batak_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1BC0 <= codepoint && codepoint <= 0x1BFF

    static member parse: Parser<Batak_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Batak_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "27C0..27EF Batak"

type Lepcha_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1C00 <= codepoint && codepoint <= 0x1C4F

    static member parse: Parser<Lepcha_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Lepcha_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2700..27BF Lepcha"

type Ol_Chiki_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1C50 <= codepoint && codepoint <= 0x1C7F

    static member parse: Parser<Ol_Chiki_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ol_Chiki_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2600..26FF Ol Chiki"

type Cyrillic_Extended_C_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1C80 <= codepoint && codepoint <= 0x1C8F

    static member parse: Parser<Cyrillic_Extended_C_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cyrillic_Extended_C_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "25A0..25FF Cyrillic Extended C"

type Georgian_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1C90 <= codepoint && codepoint <= 0x1CBF

    static member parse: Parser<Georgian_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Georgian_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2580..259F Georgian Extended"

type Sundanese_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1CC0 <= codepoint && codepoint <= 0x1CCF

    static member parse: Parser<Sundanese_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Sundanese_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2500..257F Sundanese Supplement"

type Vedic_Extensions_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1CD0 <= codepoint && codepoint <= 0x1CFF

    static member parse: Parser<Vedic_Extensions_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Vedic_Extensions_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2460..24FF Vedic Extensions"

type Phonetic_Extensions_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1D00 <= codepoint && codepoint <= 0x1D7F

    static member parse: Parser<Phonetic_Extensions_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Phonetic_Extensions_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2440..245F Phonetic Extensions"

type Phonetic_Extensions_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1D80 <= codepoint && codepoint <= 0x1DBF

    static member parse: Parser<Phonetic_Extensions_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Phonetic_Extensions_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2400..243F Phonetic Extensions Supplement"

type Combining_Diacritical_Marks_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1DC0 <= codepoint && codepoint <= 0x1DFF

    static member parse: Parser<Combining_Diacritical_Marks_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Combining_Diacritical_Marks_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2300..23FF Combining Diacritical Marks Supplement"

type Latin_Extended_Additional_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1E00 <= codepoint && codepoint <= 0x1EFF

    static member parse: Parser<Latin_Extended_Additional_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_Additional_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2200..22FF Latin Extended Additional"

type Greek_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x1F00 <= codepoint && codepoint <= 0x1FFF

    static member parse: Parser<Greek_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Greek_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2190..21FF Greek Extended"

type General_Punctuation_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2000 <= codepoint && codepoint <= 0x206F

    static member parse: Parser<General_Punctuation_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy General_Punctuation_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2150..218F General Punctuation"

type Superscripts_and_Subscripts_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2070 <= codepoint && codepoint <= 0x209F

    static member parse: Parser<Superscripts_and_Subscripts_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Superscripts_and_Subscripts_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2100..214F Superscripts and Subscripts"

type Currency_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x20A0 <= codepoint && codepoint <= 0x20CF

    static member parse: Parser<Currency_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Currency_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "20D0..20FF Currency Symbols"

type Combining_Diacritical_Marks_for_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x20D0 <= codepoint && codepoint <= 0x20FF

    static member parse: Parser<Combining_Diacritical_Marks_for_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Combining_Diacritical_Marks_for_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "20A0..20CF Combining Diacritical Marks for Symbols"

type Letterlike_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2100 <= codepoint && codepoint <= 0x214F

    static member parse: Parser<Letterlike_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Letterlike_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2070..209F Letterlike Symbols"

type Number_Forms_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2150 <= codepoint && codepoint <= 0x218F

    static member parse: Parser<Number_Forms_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Number_Forms_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "2000..206F Number Forms"

type Arrows_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2190 <= codepoint && codepoint <= 0x21FF

    static member parse: Parser<Arrows_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Arrows_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1F00..1FFF Arrows"

type Mathematical_Operators_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2200 <= codepoint && codepoint <= 0x22FF

    static member parse: Parser<Mathematical_Operators_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Mathematical_Operators_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1E00..1EFF Mathematical Operators"

type Miscellaneous_Technical_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2300 <= codepoint && codepoint <= 0x23FF

    static member parse: Parser<Miscellaneous_Technical_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Miscellaneous_Technical_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1DC0..1DFF Miscellaneous Technical"

type Control_Pictures_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2400 <= codepoint && codepoint <= 0x243F

    static member parse: Parser<Control_Pictures_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Control_Pictures_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1D80..1DBF Control Pictures"

type Optical_Character_Recognition_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2440 <= codepoint && codepoint <= 0x245F

    static member parse: Parser<Optical_Character_Recognition_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Optical_Character_Recognition_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1D00..1D7F Optical Recognition"

type Enclosed_Alphanumerics_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2460 <= codepoint && codepoint <= 0x24FF

    static member parse: Parser<Enclosed_Alphanumerics_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Enclosed_Alphanumerics_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1CD0..1CFF Enclosed Alphanumerics"

type Box_Drawing_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2500 <= codepoint && codepoint <= 0x257F

    static member parse: Parser<Box_Drawing_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Box_Drawing_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1CC0..1CCF Box Drawing"

type Block_Elements_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2580 <= codepoint && codepoint <= 0x259F

    static member parse: Parser<Block_Elements_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Block_Elements_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1C90..1CBF Block Elements"

type Geometric_Shapes_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x25A0 <= codepoint && codepoint <= 0x25FF

    static member parse: Parser<Geometric_Shapes_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Geometric_Shapes_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1C80..1C8F Geometric Shapes"

type Miscellaneous_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2600 <= codepoint && codepoint <= 0x26FF

    static member parse: Parser<Miscellaneous_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Miscellaneous_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1C50..1C7F Miscellaneous Symbols"

type Dingbats_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2700 <= codepoint && codepoint <= 0x27BF

    static member parse: Parser<Dingbats_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Dingbats_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1C00..1C4F Dingbats"

type Miscellaneous_Mathematical_Symbols_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x27C0 <= codepoint && codepoint <= 0x27EF

    static member parse: Parser<Miscellaneous_Mathematical_Symbols_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Miscellaneous_Mathematical_Symbols_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1BC0..1BFF Miscellaneous Mathematical Symbols A"

type Supplemental_Arrows_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x27F0 <= codepoint && codepoint <= 0x27FF

    static member parse: Parser<Supplemental_Arrows_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplemental_Arrows_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1B80..1BBF Supplemental Arrows A"

type Braille_Patterns_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2800 <= codepoint && codepoint <= 0x28FF

    static member parse: Parser<Braille_Patterns_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Braille_Patterns_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1B00..1B7F Braille Patterns"

type Supplemental_Arrows_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2900 <= codepoint && codepoint <= 0x297F

    static member parse: Parser<Supplemental_Arrows_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplemental_Arrows_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1AB0..1AFF Supplemental Arrows B"

type Miscellaneous_Mathematical_Symbols_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2980 <= codepoint && codepoint <= 0x29FF

    static member parse: Parser<Miscellaneous_Mathematical_Symbols_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Miscellaneous_Mathematical_Symbols_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1A20..1AAF Miscellaneous Mathematical Symbols B"

type Supplemental_Mathematical_Operators_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2A00 <= codepoint && codepoint <= 0x2AFF

    static member parse: Parser<Supplemental_Mathematical_Operators_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplemental_Mathematical_Operators_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1A00..1A1F Supplemental Mathematical Operators"

type Miscellaneous_Symbols_and_Arrows_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2B00 <= codepoint && codepoint <= 0x2BFF

    static member parse: Parser<Miscellaneous_Symbols_and_Arrows_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Miscellaneous_Symbols_and_Arrows_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "19E0..19FF Miscellaneous Symbols and Arrows"

type Glagolitic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2C00 <= codepoint && codepoint <= 0x2C5F

    static member parse: Parser<Glagolitic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Glagolitic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1980..19DF Glagolitic"

type Latin_Extended_C_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2C60 <= codepoint && codepoint <= 0x2C7F

    static member parse: Parser<Latin_Extended_C_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_C_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1950..197F Latin Extended C"

type Coptic_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2C80 <= codepoint && codepoint <= 0x2CFF

    static member parse: Parser<Coptic_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Coptic_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1900..194F Coptic"

type Georgian_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2D00 <= codepoint && codepoint <= 0x2D2F

    static member parse: Parser<Georgian_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Georgian_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "18B0..18FF Georgian Supplement"

type Tifinagh_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2D30 <= codepoint && codepoint <= 0x2D7F

    static member parse: Parser<Tifinagh_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tifinagh_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1800..18AF Tifinagh"

type Ethiopic_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2D80 <= codepoint && codepoint <= 0x2DDF

    static member parse: Parser<Ethiopic_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ethiopic_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1780..17FF Ethiopic Extended"

type Cyrillic_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2DE0 <= codepoint && codepoint <= 0x2DFF

    static member parse: Parser<Cyrillic_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cyrillic_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1760..177F Cyrillic Extended A"

type Supplemental_Punctuation_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2E00 <= codepoint && codepoint <= 0x2E7F

    static member parse: Parser<Supplemental_Punctuation_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplemental_Punctuation_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1740..175F Supplemental Punctuation"

type CJK_Radicals_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2E80 <= codepoint && codepoint <= 0x2EFF

    static member parse: Parser<CJK_Radicals_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Radicals_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1720..173F CJK Radicals Supplement"

type Kangxi_Radicals_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2F00 <= codepoint && codepoint <= 0x2FDF

    static member parse: Parser<Kangxi_Radicals_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Kangxi_Radicals_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1700..171F Kangxi Radicals"

type Ideographic_Description_Characters_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x2FF0 <= codepoint && codepoint <= 0x2FFF

    static member parse: Parser<Ideographic_Description_Characters_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ideographic_Description_Characters_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "16A0..16FF Ideographic Descriptions"

type CJK_Symbols_and_Punctuation_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3000 <= codepoint && codepoint <= 0x303F

    static member parse: Parser<CJK_Symbols_and_Punctuation_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Symbols_and_Punctuation_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1680..169F CJK Symbols and Punctuation"

type Hiragana_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3040 <= codepoint && codepoint <= 0x309F

    static member parse: Parser<Hiragana_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hiragana_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1400..167F Hiragana"

type Katakana_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x30A0 <= codepoint && codepoint <= 0x30FF

    static member parse: Parser<Katakana_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Katakana_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "13A0..13FF Katakana"

type Bopomofo_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3100 <= codepoint && codepoint <= 0x312F

    static member parse: Parser<Bopomofo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Bopomofo_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1380..139F Bopomofo"

type Hangul_Compatibility_Jamo_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3130 <= codepoint && codepoint <= 0x318F

    static member parse: Parser<Hangul_Compatibility_Jamo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hangul_Compatibility_Jamo_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1200..137F Hangul Compatibility Jamo"

type Kanbun_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3190 <= codepoint && codepoint <= 0x319F

    static member parse: Parser<Kanbun_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Kanbun_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1100..11FF Kanbun"

type Bopomofo_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x31A0 <= codepoint && codepoint <= 0x31BF

    static member parse: Parser<Bopomofo_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Bopomofo_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "10A0..10FF Bopomofo Extended"

type CJK_Strokes_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x31C0 <= codepoint && codepoint <= 0x31EF

    static member parse: Parser<CJK_Strokes_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Strokes_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "1000..109F CJK Strokes"

type Katakana_Phonetic_Extensions_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x31F0 <= codepoint && codepoint <= 0x31FF

    static member parse: Parser<Katakana_Phonetic_Extensions_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Katakana_Phonetic_Extensions_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0F00..0FFF Katakana Phonetic Extensions"

type Enclosed_CJK_Letters_and_Months_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3200 <= codepoint && codepoint <= 0x32FF

    static member parse: Parser<Enclosed_CJK_Letters_and_Months_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Enclosed_CJK_Letters_and_Months_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0E80..0EFF Enclosed CJK Letters and Months"

type CJK_Compatibility_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3300 <= codepoint && codepoint <= 0x33FF

    static member parse: Parser<CJK_Compatibility_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Compatibility_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0E00..0E7F CJK Compatibility"

type CJK_Unified_Ideographs_Extension_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x3400 <= codepoint && codepoint <= 0x4DBF

    static member parse: Parser<CJK_Unified_Ideographs_Extension_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Unified_Ideographs_Extension_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0D80..0DFF CJK Unified Ideographs Extension A"

type Yijing_Hexagram_Symbols_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x4DC0 <= codepoint && codepoint <= 0x4DFF

    static member parse: Parser<Yijing_Hexagram_Symbols_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Yijing_Hexagram_Symbols_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0D00..0D7F Yijing Hexagram Symbols"

type CJK_Unified_Ideographs_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x4E00 <= codepoint && codepoint <= 0x9FFF

    static member parse: Parser<CJK_Unified_Ideographs_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy CJK_Unified_Ideographs_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0C80..0CFF CJK Unified Ideographs"

type Yi_Syllables_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA000 <= codepoint && codepoint <= 0xA48F

    static member parse: Parser<Yi_Syllables_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Yi_Syllables_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0C00..0C7F Yi Syllables"

type Yi_Radicals_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA490 <= codepoint && codepoint <= 0xA4CF

    static member parse: Parser<Yi_Radicals_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Yi_Radicals_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0B80..0BFF Yi Radicals"

type Lisu_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA4D0 <= codepoint && codepoint <= 0xA4FF

    static member parse: Parser<Lisu_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Lisu_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0B00..0B7F Lisu"

type Vai_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA500 <= codepoint && codepoint <= 0xA63F

    static member parse: Parser<Vai_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Vai_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0A80..0AFF Vai"

type Cyrillic_Extended_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA640 <= codepoint && codepoint <= 0xA69F

    static member parse: Parser<Cyrillic_Extended_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cyrillic_Extended_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0A00..0A7F Cyrillic Extended B"

type Bamum_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA6A0 <= codepoint && codepoint <= 0xA6FF

    static member parse: Parser<Bamum_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Bamum_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0980..09FF Bamum"

type Modifier_Tone_Letters_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA700 <= codepoint && codepoint <= 0xA71F

    static member parse: Parser<Modifier_Tone_Letters_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Modifier_Tone_Letters_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0900..097F Modifier Tone Letters"

type Latin_Extended_D_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA720 <= codepoint && codepoint <= 0xA7FF

    static member parse: Parser<Latin_Extended_D_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_D_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "08A0..08FF Latin Extended D"

type Syloti_Nagri_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA800 <= codepoint && codepoint <= 0xA82F

    static member parse: Parser<Syloti_Nagri_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Syloti_Nagri_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0870..089F Syloti Nagri"

type Common_Indic_Number_Forms_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA830 <= codepoint && codepoint <= 0xA83F

    static member parse: Parser<Common_Indic_Number_Forms_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Common_Indic_Number_Forms_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0860..086F Common Indic Number Forms"

type Phags_pa_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA840 <= codepoint && codepoint <= 0xA87F

    static member parse: Parser<Phags_pa_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Phags_pa_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0840..085F Phags pa"

type Saurashtra_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA880 <= codepoint && codepoint <= 0xA8DF

    static member parse: Parser<Saurashtra_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Saurashtra_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0800..083F Saurashtra"

type Devanagari_Extended_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA8E0 <= codepoint && codepoint <= 0xA8FF

    static member parse: Parser<Devanagari_Extended_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Devanagari_Extended_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "07C0..07FF Devanagari Extended"

type Kayah_Li_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA900 <= codepoint && codepoint <= 0xA92F

    static member parse: Parser<Kayah_Li_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Kayah_Li_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0780..07BF Kayah Li"

type Rejang_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA930 <= codepoint && codepoint <= 0xA95F

    static member parse: Parser<Rejang_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Rejang_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0750..077F Rejang"

type Hangul_Jamo_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA960 <= codepoint && codepoint <= 0xA97F

    static member parse: Parser<Hangul_Jamo_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hangul_Jamo_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0700..074F Hangul Jamo Extended A"

type Javanese_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA980 <= codepoint && codepoint <= 0xA9DF

    static member parse: Parser<Javanese_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Javanese_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0600..06FF Javanese"

type Myanmar_Extended_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xA9E0 <= codepoint && codepoint <= 0xA9FF

    static member parse: Parser<Myanmar_Extended_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Myanmar_Extended_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0590..05FF Myanmar Extended B"

type Cham_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAA00 <= codepoint && codepoint <= 0xAA5F

    static member parse: Parser<Cham_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cham_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0530..058F Cham"

type Myanmar_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAA60 <= codepoint && codepoint <= 0xAA7F

    static member parse: Parser<Myanmar_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Myanmar_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0500..052F Myanmar Extended A"

type Tai_Viet_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAA80 <= codepoint && codepoint <= 0xAADF

    static member parse: Parser<Tai_Viet_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Tai_Viet_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0400..04FF Tai Viet"

type Meetei_Mayek_Extensions_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAAE0 <= codepoint && codepoint <= 0xAAFF

    static member parse: Parser<Meetei_Mayek_Extensions_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Meetei_Mayek_Extensions_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0370..03FF Meetei Mayek Extensions"

type Ethiopic_Extended_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAB00 <= codepoint && codepoint <= 0xAB2F

    static member parse: Parser<Ethiopic_Extended_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Ethiopic_Extended_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0300..036F Ethiopic Extended A"

type Latin_Extended_E_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAB30 <= codepoint && codepoint <= 0xAB6F

    static member parse: Parser<Latin_Extended_E_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Latin_Extended_E_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "02B0..02FF Latin Extended E"

type Cherokee_Supplement_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAB70 <= codepoint && codepoint <= 0xABBF

    static member parse: Parser<Cherokee_Supplement_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Cherokee_Supplement_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0250..02AF Cherokee Supplement"

type Meetei_Mayek_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xABC0 <= codepoint && codepoint <= 0xABFF

    static member parse: Parser<Meetei_Mayek_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Meetei_Mayek_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0180..024F Meetei Mayek"

type Hangul_Syllables_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xAC00 <= codepoint && codepoint <= 0xD7AF

    static member parse: Parser<Hangul_Syllables_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hangul_Syllables_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0100..017F Hangul Syllables"

type Hangul_Jamo_Extended_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xD7B0 <= codepoint && codepoint <= 0xD7FF

    static member parse: Parser<Hangul_Jamo_Extended_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Hangul_Jamo_Extended_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "0080..00FF Hangul Jamo Extended B"

type Private_Use_Area_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xE000 <= codepoint && codepoint <= 0xF8FF

    static member parse: Parser<Private_Use_Area_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Private_Use_Area_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "E000..F8FF; Private Use Area"

type Supplementary_Private_Use_Area_A_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0xF0000 <= codepoint && codepoint <= 0xFFFFD

    static member parse: Parser<Supplementary_Private_Use_Area_A_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplementary_Private_Use_Area_A_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "F0000..FFFFD; Supplementary Private Use Area-A excluding noncharacters"

type Supplementary_Private_Use_Area_B_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value
        0x100000 <= codepoint && codepoint <= 0x10FFFD

    static member parse: Parser<Supplementary_Private_Use_Area_B_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Supplementary_Private_Use_Area_B_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            "100000..10FFFD; Supplementary Private Use Area-B excluding noncharacters"

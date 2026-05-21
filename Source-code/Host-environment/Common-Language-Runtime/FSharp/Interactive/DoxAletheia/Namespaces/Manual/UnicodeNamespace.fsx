#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module unicode =

    let _prefix = prefix_label "unicode"

    let Unicode_Character_Property = _prefix "Unicode_Character_Property"
    let Unicode_Name_Alias = _prefix "Unicode_Name_Alias"
    let name_alias = _prefix "name_alias"
    let Name_Alias = _prefix "Name_Alias"
    let alias_type = _prefix "alias_type"
    let Code_Point = _prefix "Code_Point"

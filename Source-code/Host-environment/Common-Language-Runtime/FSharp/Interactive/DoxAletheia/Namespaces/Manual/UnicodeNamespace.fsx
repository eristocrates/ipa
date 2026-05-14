#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"
open RDFErgonomics

module unicode =

    let prefix = prefix_label "unicode"

    let Unicode_Character_Property = prefix "Unicode_Character_Property"
    let Unicode_Name_Alias = prefix "Unicode_Name_Alias"
    let name_alias = prefix "name_alias"
    let Name_Alias = prefix "Name_Alias"
    let alias_type = prefix "alias_type"
    let Code_Point = prefix "Code_Point"

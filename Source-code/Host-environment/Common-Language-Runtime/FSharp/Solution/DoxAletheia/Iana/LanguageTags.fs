namespace DoxAletheia
open System
open DoxAletheia
// TODO consider closer conformance to rfc
/// https://datatracker.ietf.org/doc/html/rfc5646#section-2.2

type Language_Tag(primary_language:Language_Subtag, extended_languages:Extended_Language_Subtag array, region:Region_Subtag option, variants:Variant_Subtag array) =
    let demark_string (raw_string:string) = raw_string.Replace("_","-").Replace("Z'","")
    let _primary_language = primary_language
    let _primary_string = _primary_language.ToString() |> demark_string
    let _extended_languages = 
        if extended_languages.Length > 3 then 
            invalidArg (nameof extended_languages) "More than 3 Extended Language Subtags"
        extended_languages
    let _extended_strings = _extended_languages |> Array.map (fun extended -> extended.ToString() |> demark_string)
    let _region= region
    let _region_string = 
        match _region with 
        | Some region -> region.ToString() |> demark_string
        | None -> String.Empty
    let _variants = variants
    let _variant_strings = _variants |> Array.map (fun variant -> variant.ToString() |> demark_string)
    let _lexical_form = 
        Array.concat [|
            
            [|_primary_string|]
            _extended_strings
            [|_region_string|]
            _variant_strings

            
            
            |]
            |> Array.filter (fun subtag_string -> not (String.IsNullOrWhiteSpace subtag_string))
            |> String.concat "-"
        
        
    new(primary:Language_Subtag) = Language_Tag(primary,[||],None,[||])
    new(primary:Language_Subtag,region:Region_Subtag) = Language_Tag(primary,[||],Some region,[||])

    member this.primary_language = _primary_language
    member this.extended_languages = _extended_languages
    member this.region = _region
    member this.variants = _variants
    member this.as_string = _lexical_form



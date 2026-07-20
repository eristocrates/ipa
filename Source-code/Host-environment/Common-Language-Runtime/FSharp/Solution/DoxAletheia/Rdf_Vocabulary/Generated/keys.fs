namespace http.purl.org.NET.c4dm.keys.owl.hash

open DoxAletheia

module keys =
    let _namespace_name = "http://purl.org/NET/c4dm/keys.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#A"></see>
    /// </summary>
    let A = _prefix "A"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#Note"></see>
    /// </summary>
    let Note = _prefix "Note"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#AFlat"></see>
    /// </summary>
    let AFlat = _prefix "AFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#AFlatMajor"></see>
    /// </summary>
    let AFlatMajor = _prefix "AFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#mode"></see>
    /// </summary>
    let mode = _prefix "mode"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#tonic"></see>
    /// </summary>
    let tonic = _prefix "tonic"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#wikipedia"></see>
    /// </summary>
    let wikipedia = _prefix "wikipedia"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#Key"></see>
    /// </summary>
    let Key = _prefix "Key"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#AFlatMinor"></see>
    /// </summary>
    let AFlatMinor = _prefix "AFlatMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#AMajor"></see>
    /// </summary>
    let AMajor = _prefix "AMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#AMinor"></see>
    /// </summary>
    let AMinor = _prefix "AMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#ASharp"></see>
    /// </summary>
    let ASharp = _prefix "ASharp"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#ASharpMinor"></see>
    /// </summary>
    let ASharpMinor = _prefix "ASharpMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#B"></see>
    /// </summary>
    let B = _prefix "B"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#BFlat"></see>
    /// </summary>
    let BFlat = _prefix "BFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#BFlatMajor"></see>
    /// </summary>
    let BFlatMajor = _prefix "BFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#BFlatMinor"></see>
    /// </summary>
    let BFlatMinor = _prefix "BFlatMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#BMajor"></see>
    /// </summary>
    let BMajor = _prefix "BMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#BMinor"></see>
    /// </summary>
    let BMinor = _prefix "BMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#C"></see>
    /// </summary>
    let C = _prefix "C"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CFlat"></see>
    /// </summary>
    let CFlat = _prefix "CFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CFlatMajor"></see>
    /// </summary>
    let CFlatMajor = _prefix "CFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CMajor"></see>
    /// </summary>
    let CMajor = _prefix "CMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CMinor"></see>
    /// </summary>
    let CMinor = _prefix "CMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CSharp"></see>
    /// </summary>
    let CSharp = _prefix "CSharp"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CSharpMajor"></see>
    /// </summary>
    let CSharpMajor = _prefix "CSharpMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#CSharpMinor"></see>
    /// </summary>
    let CSharpMinor = _prefix "CSharpMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#D"></see>
    /// </summary>
    let D = _prefix "D"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DFlat"></see>
    /// </summary>
    let DFlat = _prefix "DFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DFlatMajor"></see>
    /// </summary>
    let DFlatMajor = _prefix "DFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DMajor"></see>
    /// </summary>
    let DMajor = _prefix "DMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DMinor"></see>
    /// </summary>
    let DMinor = _prefix "DMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DSharp"></see>
    /// </summary>
    let DSharp = _prefix "DSharp"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#DSharpMinor"></see>
    /// </summary>
    let DSharpMinor = _prefix "DSharpMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#E"></see>
    /// </summary>
    let E = _prefix "E"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#EFlat"></see>
    /// </summary>
    let EFlat = _prefix "EFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#EFlatMajor"></see>
    /// </summary>
    let EFlatMajor = _prefix "EFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#EFlatMinor"></see>
    /// </summary>
    let EFlatMinor = _prefix "EFlatMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#EMajor"></see>
    /// </summary>
    let EMajor = _prefix "EMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#EMinor"></see>
    /// </summary>
    let EMinor = _prefix "EMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#F"></see>
    /// </summary>
    let F = _prefix "F"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#FMajor"></see>
    /// </summary>
    let FMajor = _prefix "FMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#FMinor"></see>
    /// </summary>
    let FMinor = _prefix "FMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#FSharp"></see>
    /// </summary>
    let FSharp = _prefix "FSharp"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#FSharpMajor"></see>
    /// </summary>
    let FSharpMajor = _prefix "FSharpMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#FSharpMinor"></see>
    /// </summary>
    let FSharpMinor = _prefix "FSharpMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#G"></see>
    /// </summary>
    let G = _prefix "G"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GFlat"></see>
    /// </summary>
    let GFlat = _prefix "GFlat"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GFlatMajor"></see>
    /// </summary>
    let GFlatMajor = _prefix "GFlatMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GMajor"></see>
    /// </summary>
    let GMajor = _prefix "GMajor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GMinor"></see>
    /// </summary>
    let GMinor = _prefix "GMinor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GSharp"></see>
    /// </summary>
    let GSharp = _prefix "GSharp"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/keys.owl#GSharpMinor"></see>
    /// </summary>
    let GSharpMinor = _prefix "GSharpMinor"

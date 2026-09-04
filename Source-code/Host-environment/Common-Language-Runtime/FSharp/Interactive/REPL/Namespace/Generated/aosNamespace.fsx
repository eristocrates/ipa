#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module aos =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf.muninn-project.org/ontologies/appearances#" "aos"

    let AHG_AHG2288 = _prefixId.prefix "AHG_AHG2288"
    let AHG_AHG2354 = _prefixId.prefix "AHG_AHG2354"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Appearance^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Appearance">aos:Appearance</a>
    /// </summary>
    let Appearance = _prefixId.prefix "Appearance"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : EthnicityUKCensusCode Census Codes^^xsd:string</para>
    ///   <para>rdfs:label : UK CensusCodes</para>
    ///   <para>rdfs:comment : S</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKCensusCode">aos:EthnicityUKCensusCode</a>
    /// </summary>
    let EthnicityUKCensusCode = _prefixId.prefix "EthnicityUKCensusCode"
    let EthnicityUKCensusCodeA1 = _prefixId.prefix "EthnicityUKCensusCodeA1"
    let EthnicityUKCensusCodeA2 = _prefixId.prefix "EthnicityUKCensusCodeA2"
    let EthnicityUKCensusCodeA3 = _prefixId.prefix "EthnicityUKCensusCodeA3"
    let EthnicityUKCensusCodeA9 = _prefixId.prefix "EthnicityUKCensusCodeA9"
    let EthnicityUKCensusCodeB1 = _prefixId.prefix "EthnicityUKCensusCodeB1"
    let EthnicityUKCensusCodeB2 = _prefixId.prefix "EthnicityUKCensusCodeB2"
    let EthnicityUKCensusCodeB9 = _prefixId.prefix "EthnicityUKCensusCodeB9"
    let EthnicityUKCensusCodeM1 = _prefixId.prefix "EthnicityUKCensusCodeM1"
    let EthnicityUKCensusCodeM2 = _prefixId.prefix "EthnicityUKCensusCodeM2"
    let EthnicityUKCensusCodeM3 = _prefixId.prefix "EthnicityUKCensusCodeM3"
    let EthnicityUKCensusCodeM9 = _prefixId.prefix "EthnicityUKCensusCodeM9"
    let EthnicityUKCensusCodeNS = _prefixId.prefix "EthnicityUKCensusCodeNS"
    let EthnicityUKCensusCodeO1 = _prefixId.prefix "EthnicityUKCensusCodeO1"
    let EthnicityUKCensusCodeO9 = _prefixId.prefix "EthnicityUKCensusCodeO9"
    let EthnicityUKCensusCodeW1 = _prefixId.prefix "EthnicityUKCensusCodeW1"
    let EthnicityUKCensusCodeW2 = _prefixId.prefix "EthnicityUKCensusCodeW2"
    let EthnicityUKCensusCodeW9 = _prefixId.prefix "EthnicityUKCensusCodeW9"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : IC Codes^^xsd:string</para>
    ///   <para>rdfs:label : UK IC-Codes</para>
    ///   <para>rdfs:comment : Simple F/M coding of Gender types.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EthnicityUKICCode">aos:EthnicityUKICCode</a>
    /// </summary>
    let EthnicityUKICCode = _prefixId.prefix "EthnicityUKICCode"
    let EthnicityUKICCodeIC0 = _prefixId.prefix "EthnicityUKICCodeIC0"
    let EthnicityUKICCodeIC1 = _prefixId.prefix "EthnicityUKICCodeIC1"
    let EthnicityUKICCodeIC2 = _prefixId.prefix "EthnicityUKICCodeIC2"
    let EthnicityUKICCodeIC3 = _prefixId.prefix "EthnicityUKICCodeIC3"
    let EthnicityUKICCodeIC4 = _prefixId.prefix "EthnicityUKICCodeIC4"
    let EthnicityUKICCodeIC5 = _prefixId.prefix "EthnicityUKICCodeIC5"
    let EthnicityUKICCodeIC6 = _prefixId.prefix "EthnicityUKICCodeIC6"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Eye Color^^xsd:string</para>
    ///   <para>rdfs:label : Eye Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColor">aos:EyeColor</a>
    /// </summary>
    let EyeColor = _prefixId.prefix "EyeColor"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : EyeColorFBI^^xsd:string</para>
    ///   <para>rdfs:label : FBI Eye Color Reference</para>
    ///   <para>rdfs:comment : FBI Eye Color Reference - Essentially the same as used by the RCMP.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorFBI">aos:EyeColorFBI</a>
    /// </summary>
    let EyeColorFBI = _prefixId.prefix "EyeColorFBI"
    let EyeColorFBIBLK = _prefixId.prefix "EyeColorFBIBLK"
    let EyeColorFBIBLU = _prefixId.prefix "EyeColorFBIBLU"
    let EyeColorFBIBRO = _prefixId.prefix "EyeColorFBIBRO"
    let EyeColorFBIGRN = _prefixId.prefix "EyeColorFBIGRN"
    let EyeColorFBIGRY = _prefixId.prefix "EyeColorFBIGRY"
    let EyeColorFBIHAZ = _prefixId.prefix "EyeColorFBIHAZ"
    let EyeColorFBIMAR = _prefixId.prefix "EyeColorFBIMAR"
    /// <summary>
    ///   <para>rdfs:label :  Grieve Morant Eye Color Reference</para>
    ///   <para>http://xmlns.com/foaf/spec/name : EyeColorGrieveMorant^^xsd:string</para>
    ///   <para>rdfs:comment : Grieve Morant Eye Color Reference.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorGrieveMorant">aos:EyeColorGrieveMorant</a>
    /// </summary>
    let EyeColorGrieveMorant = _prefixId.prefix "EyeColorGrieveMorant"
    let EyeColorGrieveMorantA = _prefixId.prefix "EyeColorGrieveMorantA"
    let EyeColorGrieveMorantB = _prefixId.prefix "EyeColorGrieveMorantB"
    let EyeColorGrieveMorantC = _prefixId.prefix "EyeColorGrieveMorantC"
    let EyeColorGrieveMorantD = _prefixId.prefix "EyeColorGrieveMorantD"
    let EyeColorGrieveMorantE = _prefixId.prefix "EyeColorGrieveMorantE"
    let EyeColorGrieveMorantF = _prefixId.prefix "EyeColorGrieveMorantF"
    let EyeColorGrieveMorantG = _prefixId.prefix "EyeColorGrieveMorantG"
    let EyeColorGrieveMorantH = _prefixId.prefix "EyeColorGrieveMorantH"
    let EyeColorGrieveMorantI = _prefixId.prefix "EyeColorGrieveMorantI"
    let EyeColorGrieveMorantJ = _prefixId.prefix "EyeColorGrieveMorantJ"
    let EyeColorGrieveMorantK = _prefixId.prefix "EyeColorGrieveMorantK"
    let EyeColorGrieveMorantL = _prefixId.prefix "EyeColorGrieveMorantL"
    let EyeColorGrieveMorantM = _prefixId.prefix "EyeColorGrieveMorantM"

    let EyeColorGrieveMorantMoreBlueGreyThanBrown =
        _prefixId.prefix "EyeColorGrieveMorantMoreBlueGreyThanBrown"

    let EyeColorGrieveMorantMoreBrownThanBlueGrey =
        _prefixId.prefix "EyeColorGrieveMorantMoreBrownThanBlueGrey"

    let EyeColorGrieveMorantN = _prefixId.prefix "EyeColorGrieveMorantN"
    let EyeColorGrieveMorantNoBrown = _prefixId.prefix "EyeColorGrieveMorantNoBrown"
    let EyeColorGrieveMorantPureBrown = _prefixId.prefix "EyeColorGrieveMorantPureBrown"
    /// <summary>
    ///   <para>rdfs:label : Iris Color Classification System</para>
    ///   <para>http://xmlns.com/foaf/spec/name : Iris Color Classification System^^xsd:string</para>
    ///   <para>rdfs:comment : Iris Color Classification System</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorICCS">aos:EyeColorICCS</a>
    /// </summary>
    let EyeColorICCS = _prefixId.prefix "EyeColorICCS"
    let EyeColorICCS1 = _prefixId.prefix "EyeColorICCS1"
    let EyeColorICCS2 = _prefixId.prefix "EyeColorICCS2"
    let EyeColorICCS3 = _prefixId.prefix "EyeColorICCS3"
    let EyeColorICCS4 = _prefixId.prefix "EyeColorICCS4"
    let EyeColorICCS5 = _prefixId.prefix "EyeColorICCS5"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : EyeColorMartinSchultz^^xsd:string</para>
    ///   <para>rdfs:label : EyeColorMartinSchultz</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorMartinSchultz">aos:EyeColorMartinSchultz</a>
    /// </summary>
    let EyeColorMartinSchultz = _prefixId.prefix "EyeColorMartinSchultz"
    let EyeColorMartinSchultz1 = _prefixId.prefix "EyeColorMartinSchultz1"
    let EyeColorMartinSchultz10 = _prefixId.prefix "EyeColorMartinSchultz10"
    let EyeColorMartinSchultz11 = _prefixId.prefix "EyeColorMartinSchultz11"
    let EyeColorMartinSchultz12 = _prefixId.prefix "EyeColorMartinSchultz12"
    let EyeColorMartinSchultz13 = _prefixId.prefix "EyeColorMartinSchultz13"
    let EyeColorMartinSchultz14 = _prefixId.prefix "EyeColorMartinSchultz14"
    let EyeColorMartinSchultz15 = _prefixId.prefix "EyeColorMartinSchultz15"
    let EyeColorMartinSchultz16 = _prefixId.prefix "EyeColorMartinSchultz16"
    let EyeColorMartinSchultz1a = _prefixId.prefix "EyeColorMartinSchultz1a"
    let EyeColorMartinSchultz1b = _prefixId.prefix "EyeColorMartinSchultz1b"
    let EyeColorMartinSchultz1c = _prefixId.prefix "EyeColorMartinSchultz1c"
    let EyeColorMartinSchultz2a = _prefixId.prefix "EyeColorMartinSchultz2a"
    let EyeColorMartinSchultz2b = _prefixId.prefix "EyeColorMartinSchultz2b"
    let EyeColorMartinSchultz3 = _prefixId.prefix "EyeColorMartinSchultz3"
    let EyeColorMartinSchultz4 = _prefixId.prefix "EyeColorMartinSchultz4"
    let EyeColorMartinSchultz4a = _prefixId.prefix "EyeColorMartinSchultz4a"
    let EyeColorMartinSchultz4b = _prefixId.prefix "EyeColorMartinSchultz4b"
    let EyeColorMartinSchultz5 = _prefixId.prefix "EyeColorMartinSchultz5"
    let EyeColorMartinSchultz6 = _prefixId.prefix "EyeColorMartinSchultz6"
    let EyeColorMartinSchultz7 = _prefixId.prefix "EyeColorMartinSchultz7"
    let EyeColorMartinSchultz8 = _prefixId.prefix "EyeColorMartinSchultz8"
    let EyeColorMartinSchultz9 = _prefixId.prefix "EyeColorMartinSchultz9"

    let EyeColorMartinSchultzLightBlue =
        _prefixId.prefix "EyeColorMartinSchultzLightBlue"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : EyeColorNebraskaDMV^^xsd:string</para>
    ///   <para>rdfs:label : EyeColorNebraskaDMV</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorNebraskaDMV">aos:EyeColorNebraskaDMV</a>
    /// </summary>
    let EyeColorNebraskaDMV = _prefixId.prefix "EyeColorNebraskaDMV"
    let EyeColorNebraskaDMVBlack = _prefixId.prefix "EyeColorNebraskaDMVBlack"
    let EyeColorNebraskaDMVBlue = _prefixId.prefix "EyeColorNebraskaDMVBlue"
    let EyeColorNebraskaDMVBrown = _prefixId.prefix "EyeColorNebraskaDMVBrown"

    let EyeColorNebraskaDMVDichromatic =
        _prefixId.prefix "EyeColorNebraskaDMVDichromatic"

    let EyeColorNebraskaDMVGray = _prefixId.prefix "EyeColorNebraskaDMVGray"
    let EyeColorNebraskaDMVGreen = _prefixId.prefix "EyeColorNebraskaDMVGreen"
    let EyeColorNebraskaDMVHazel = _prefixId.prefix "EyeColorNebraskaDMVHazel"
    let EyeColorNebraskaDMVPink = _prefixId.prefix "EyeColorNebraskaDMVPink"
    let EyeColorNebraskaDMVUnknown = _prefixId.prefix "EyeColorNebraskaDMVUnknown"
    /// <summary>
    ///   <para>rdfs:comment : Pétrequin Eye Color Reference.</para>
    ///   <para>http://xmlns.com/foaf/spec/name : Pétrequin Eye Color Reference^^xsd:string</para>
    ///   <para>rdfs:label : Pétrequin Eye Color Reference</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorPetrequin">aos:EyeColorPetrequin</a>
    /// </summary>
    let EyeColorPetrequin = _prefixId.prefix "EyeColorPetrequin"
    let EyeColorPetrequinBleus = _prefixId.prefix "EyeColorPetrequinBleus"
    let EyeColorPetrequinBruns = _prefixId.prefix "EyeColorPetrequinBruns"
    let EyeColorPetrequinGris = _prefixId.prefix "EyeColorPetrequinGris"
    let EyeColorPetrequinNoirs = _prefixId.prefix "EyeColorPetrequinNoirs"
    let EyeColorPetrequinRoux = _prefixId.prefix "EyeColorPetrequinRoux"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Riddell Eye Color Reference^^xsd:string</para>
    ///   <para>rdfs:label : Riddell Eye Color Reference</para>
    ///   <para>rdfs:comment : Riddell Eye Color Reference. The Riddell standard makes use of a three part scale that marks up the main colour of the eye, the diffuse color of the eye and any colour spots within the eye.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorRiddell">aos:EyeColorRiddell</a>
    /// </summary>
    let EyeColorRiddell = _prefixId.prefix "EyeColorRiddell"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Simple Eye Color^^xsd:string</para>
    ///   <para>rdfs:label : Simple Eye Color Reference</para>
    ///   <para>rdfs:comment : Simple eye color reference.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorSimple">aos:EyeColorSimple</a>
    /// </summary>
    let EyeColorSimple = _prefixId.prefix "EyeColorSimple"
    let EyeColorSimpleBlack = _prefixId.prefix "EyeColorSimpleBlack"
    let EyeColorSimpleBlue = _prefixId.prefix "EyeColorSimpleBlue"
    let EyeColorSimpleBrown = _prefixId.prefix "EyeColorSimpleBrown"
    let EyeColorSimpleGreen = _prefixId.prefix "EyeColorSimpleGreen"
    let EyeColorSimpleGrey = _prefixId.prefix "EyeColorSimpleGrey"
    let EyeColorSimpleRed = _prefixId.prefix "EyeColorSimpleRed"
    /// <summary>
    ///   <para>rdfs:label : Wilde Eye Color Reference</para>
    ///   <para>http://xmlns.com/foaf/spec/name : Wilde Eye Color Reference^^xsd:string</para>
    ///   <para>rdfs:comment : Wilde Eye Color Reference.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#EyeColorWilde">aos:EyeColorWilde</a>
    /// </summary>
    let EyeColorWilde = _prefixId.prefix "EyeColorWilde"
    let EyeColorWildeBlack = _prefixId.prefix "EyeColorWildeBlack"
    let EyeColorWildeBlue = _prefixId.prefix "EyeColorWildeBlue"
    let EyeColorWildeBrown = _prefixId.prefix "EyeColorWildeBrown"
    let EyeColorWildeDark = _prefixId.prefix "EyeColorWildeDark"
    let EyeColorWildeGray = _prefixId.prefix "EyeColorWildeGray"
    let EyeColorWildeHazel = _prefixId.prefix "EyeColorWildeHazel"
    let EyeColorWildeLight = _prefixId.prefix "EyeColorWildeLight"
    let FBI = _prefixId.prefix "FBI"
    let FBIStandards = _prefixId.prefix "FBIStandards"
    let FemaleBodyMeasurement = _prefixId.prefix "FemaleBodyMeasurement"
    let FitzpatrickSkinColor = _prefixId.prefix "FitzpatrickSkinColor"
    let FitzpatrickSkinColorTypeII = _prefixId.prefix "FitzpatrickSkinColorTypeII"
    let FitzpatrickSkinColorTypeIII = _prefixId.prefix "FitzpatrickSkinColorTypeIII"
    let FitzpatrickSkinColorTypeIV = _prefixId.prefix "FitzpatrickSkinColorTypeIV"
    let FitzpatrickSkinColorTypeV = _prefixId.prefix "FitzpatrickSkinColorTypeV"
    let FitzpatrickSkinColorTypeVI = _prefixId.prefix "FitzpatrickSkinColorTypeVI"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Gender^^xsd:string</para>
    ///   <para>rdfs:label : Gender (Generic)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Gender">aos:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Gender^^xsd:string</para>
    ///   <para>rdfs:label : SimplebGender</para>
    ///   <para>rdfs:comment : Simple F/M coding of Gender types.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#GenderSimple">aos:GenderSimple</a>
    /// </summary>
    let GenderSimple = _prefixId.prefix "GenderSimple"
    let GenderSimple_F = _prefixId.prefix "GenderSimple-F"
    let GenderSimple_M = _prefixId.prefix "GenderSimple-M"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Gender^^xsd:string</para>
    ///   <para>rdfs:label : Gender (Strict)</para>
    ///   <para>rdfs:comment : Strict F/M coding of Gender types, with restriction.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#GenderStrict">aos:GenderStrict</a>
    /// </summary>
    let GenderStrict = _prefixId.prefix "GenderStrict"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Hair Color^^xsd:string</para>
    ///   <para>rdfs:label : Hair Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColor">aos:HairColor</a>
    /// </summary>
    let HairColor = _prefixId.prefix "HairColor"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Human Hair Atlas Color^^xsd:string</para>
    ///   <para>rdfs:label : HairColorAtlas</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorAtlas">aos:HairColorAtlas</a>
    /// </summary>
    let HairColorAtlas = _prefixId.prefix "HairColorAtlas"
    let HairColorAtlasAbsent = _prefixId.prefix "HairColorAtlasAbsent"
    let HairColorAtlasBlond = _prefixId.prefix "HairColorAtlasBlond"
    let HairColorAtlasBlondDark = _prefixId.prefix "HairColorAtlasBlondDark"
    let HairColorAtlasBlondLight = _prefixId.prefix "HairColorAtlasBlondLight"

    let HairColorAtlasBlondLightMedium =
        _prefixId.prefix "HairColorAtlasBlondLightMedium"

    let HairColorAtlasBlondMediumDark = _prefixId.prefix "HairColorAtlasBlondMediumDark"
    let HairColorAtlasBrown = _prefixId.prefix "HairColorAtlasBrown"
    let HairColorAtlasDarkGoldenBrown = _prefixId.prefix "HairColorAtlasDarkGoldenBrown"
    let HairColorAtlasDarkOpaqueBrown = _prefixId.prefix "HairColorAtlasDarkOpaqueBrown"

    let HairColorAtlasDarkOpaqueGrayBrown =
        _prefixId.prefix "HairColorAtlasDarkOpaqueGrayBrown"

    let HairColorAtlasDarkRed = _prefixId.prefix "HairColorAtlasDarkRed"
    let HairColorAtlasDarkRedBrown = _prefixId.prefix "HairColorAtlasDarkRedBrown"
    let HairColorAtlasGoldenBrown = _prefixId.prefix "HairColorAtlasGoldenBrown"
    let HairColorAtlasGrayBrown = _prefixId.prefix "HairColorAtlasGrayBrown"
    let HairColorAtlasLightBrown = _prefixId.prefix "HairColorAtlasLightBrown"

    let HairColorAtlasLightGoldenBrown =
        _prefixId.prefix "HairColorAtlasLightGoldenBrown"

    let HairColorAtlasLightGrayBrown = _prefixId.prefix "HairColorAtlasLightGrayBrown"

    let HairColorAtlasLightMediumBrown =
        _prefixId.prefix "HairColorAtlasLightMediumBrown"

    let HairColorAtlasLightMediumGoldenBrown =
        _prefixId.prefix "HairColorAtlasLightMediumGoldenBrown"

    let HairColorAtlasLightMediumGrayBrown =
        _prefixId.prefix "HairColorAtlasLightMediumGrayBrown"

    let HairColorAtlasLightMediumRed = _prefixId.prefix "HairColorAtlasLightMediumRed"

    let HairColorAtlasLightMediumRedBrown =
        _prefixId.prefix "HairColorAtlasLightMediumRedBrown"

    let HairColorAtlasLightRed = _prefixId.prefix "HairColorAtlasLightRed"
    let HairColorAtlasLightRedBrown = _prefixId.prefix "HairColorAtlasLightRedBrown"
    let HairColorAtlasMediumDarkBrown = _prefixId.prefix "HairColorAtlasMediumDarkBrown"

    let HairColorAtlasMediumDarkGoldenBrown =
        _prefixId.prefix "HairColorAtlasMediumDarkGoldenBrown"

    let HairColorAtlasMediumDarkGrayBrown =
        _prefixId.prefix "HairColorAtlasMediumDarkGrayBrown"

    let HairColorAtlasMediumDarkRed = _prefixId.prefix "HairColorAtlasMediumDarkRed"

    let HairColorAtlasMediumDarkRedBrown =
        _prefixId.prefix "HairColorAtlasMediumDarkRedBrown"

    let HairColorAtlasOpaqueBrown = _prefixId.prefix "HairColorAtlasOpaqueBrown"
    let HairColorAtlasOther = _prefixId.prefix "HairColorAtlasOther"
    let HairColorAtlasRed = _prefixId.prefix "HairColorAtlasRed"
    let HairColorAtlasRedBrown = _prefixId.prefix "HairColorAtlasRedBrown"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Dyed Hair Color^^xsd:string</para>
    ///   <para>rdfs:label : Dyed Hair Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorDyed">aos:HairColorDyed</a>
    /// </summary>
    let HairColorDyed = _prefixId.prefix "HairColorDyed"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : FBI Hair Color^^xsd:string</para>
    ///   <para>rdfs:label : FBI Hair Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorFBI">aos:HairColorFBI</a>
    /// </summary>
    let HairColorFBI = _prefixId.prefix "HairColorFBI"
    let HairColorFBIBLD = _prefixId.prefix "HairColorFBIBLD"
    let HairColorFBIBLK = _prefixId.prefix "HairColorFBIBLK"
    let HairColorFBIBLN = _prefixId.prefix "HairColorFBIBLN"
    let HairColorFBIBLU = _prefixId.prefix "HairColorFBIBLU"
    let HairColorFBIBRO = _prefixId.prefix "HairColorFBIBRO"
    let HairColorFBIGRN = _prefixId.prefix "HairColorFBIGRN"
    let HairColorFBIGRY = _prefixId.prefix "HairColorFBIGRY"
    let HairColorFBIONG = _prefixId.prefix "HairColorFBIONG"
    let HairColorFBIPLE = _prefixId.prefix "HairColorFBIPLE"
    let HairColorFBIPNK = _prefixId.prefix "HairColorFBIPNK"
    let HairColorFBIRED = _prefixId.prefix "HairColorFBIRED"
    let HairColorFBISDY = _prefixId.prefix "HairColorFBISDY"
    let HairColorFBIUNKNOWN = _prefixId.prefix "HairColorFBIUNKNOWN"
    let HairColorFBIWHI = _prefixId.prefix "HairColorFBIWHI"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Natural Hair Color^^xsd:string</para>
    ///   <para>rdfs:label : Natural Hair Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNatural">aos:HairColorNatural</a>
    /// </summary>
    let HairColorNatural = _prefixId.prefix "HairColorNatural"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : NebraskaDMVHairColor^^xsd:string</para>
    ///   <para>rdfs:label : NebraskaDMVHairColor</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorNebraskaDMV">aos:HairColorNebraskaDMV</a>
    /// </summary>
    let HairColorNebraskaDMV = _prefixId.prefix "HairColorNebraskaDMV"
    let HairColorNebraskaDMVBald = _prefixId.prefix "HairColorNebraskaDMVBald"
    let HairColorNebraskaDMVBlonde = _prefixId.prefix "HairColorNebraskaDMVBlonde"
    let HairColorNebraskaDMVBrown = _prefixId.prefix "HairColorNebraskaDMVBrown"
    let HairColorNebraskaDMVGray = _prefixId.prefix "HairColorNebraskaDMVGray"
    let HairColorNebraskaDMVRed = _prefixId.prefix "HairColorNebraskaDMVRed"
    let HairColorNebraskaDMVSandy = _prefixId.prefix "HairColorNebraskaDMVSandy"
    let HairColorNebraskaDMVUnknown = _prefixId.prefix "HairColorNebraskaDMVUnknown"
    let HairColorNebraskaDMVWhite = _prefixId.prefix "HairColorNebraskaDMVWhite"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : RCMP Hair Color^^xsd:string</para>
    ///   <para>rdfs:label : RCMP Hair Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#HairColorRCMP">aos:HairColorRCMP</a>
    /// </summary>
    let HairColorRCMP = _prefixId.prefix "HairColorRCMP"
    let HairColorRCMPBald = _prefixId.prefix "HairColorRCMPBald"
    let HairColorRCMPBlack = _prefixId.prefix "HairColorRCMPBlack"
    let HairColorRCMPBlond = _prefixId.prefix "HairColorRCMPBlond"
    let HairColorRCMPBrown = _prefixId.prefix "HairColorRCMPBrown"
    let HairColorRCMPGrey = _prefixId.prefix "HairColorRCMPGrey"
    let HairColorRCMPLightBrown = _prefixId.prefix "HairColorRCMPLightBrown"
    let HairColorRCMPLightRed = _prefixId.prefix "HairColorRCMPLightRed"

    let HairColorRCMPLightStrawberryRed =
        _prefixId.prefix "HairColorRCMPLightStrawberryRed"

    let HairColorRCMPWhite = _prefixId.prefix "HairColorRCMPWhite"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Kinsey Scale^^xsd:string</para>
    ///   <para>rdfs:label : Kinsey Scale</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#KinseyScale">aos:KinseyScale</a>
    /// </summary>
    let KinseyScale = _prefixId.prefix "KinseyScale"
    let KinseyScale0 = _prefixId.prefix "KinseyScale0"
    let KinseyScale1 = _prefixId.prefix "KinseyScale1"
    let KinseyScale2 = _prefixId.prefix "KinseyScale2"
    let KinseyScale3 = _prefixId.prefix "KinseyScale3"
    let KinseyScale4 = _prefixId.prefix "KinseyScale4"
    let KinseyScale5 = _prefixId.prefix "KinseyScale5"
    let KinseyScale6 = _prefixId.prefix "KinseyScale6"
    let KinseyScaleX = _prefixId.prefix "KinseyScaleX"
    let MaleBodyMeasurement = _prefixId.prefix "MaleBodyMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Nationality^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Nationality">aos:Nationality</a>
    /// </summary>
    let Nationality = _prefixId.prefix "Nationality"
    let NebraskaDMV = _prefixId.prefix "NebraskaDMV"
    let NebraskaDMVStandards = _prefixId.prefix "NebraskaDMVStandards"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Observation^^xsd:string</para>
    ///   <para>rdfs:label : Observation</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Observation">aos:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    let Ogle_1999fk = _prefixId.prefix "Ogle_1999fk"
    let PerceivedEthnicity = _prefixId.prefix "PerceivedEthnicity"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Person^^xsd:string</para>
    ///   <para>rdfs:label : Natural Person</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Person">aos:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    let RCMP = _prefixId.prefix "RCMP"
    let RCMPStandards = _prefixId.prefix "RCMPStandards"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Race^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Race">aos:Race</a>
    /// </summary>
    let Race = _prefixId.prefix "Race"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Religion^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Religion">aos:Religion</a>
    /// </summary>
    let Religion = _prefixId.prefix "Religion"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : RiddellColorScheme^^xsd:string</para>
    ///   <para>rdfs:label : Riddell Color Reference</para>
    ///   <para>rdfs:comment : Riddell Color Reference.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#RiddellColor">aos:RiddellColor</a>
    /// </summary>
    let RiddellColor = _prefixId.prefix "RiddellColor"
    let RiddellColorBlue = _prefixId.prefix "RiddellColorBlue"
    let RiddellColorChocolate = _prefixId.prefix "RiddellColorChocolate"
    let RiddellColorGreen = _prefixId.prefix "RiddellColorGreen"
    let RiddellColorGrey = _prefixId.prefix "RiddellColorGrey"
    let RiddellColorNil = _prefixId.prefix "RiddellColorNil"
    let RiddellColorTan = _prefixId.prefix "RiddellColorTan"
    let RiddellColorYellow = _prefixId.prefix "RiddellColorYellow"
    let RiddellDiffuseColor = _prefixId.prefix "RiddellDiffuseColor"
    let RiddellGeneralColor = _prefixId.prefix "RiddellGeneralColor"
    let RiddellSpotsColor = _prefixId.prefix "RiddellSpotsColor"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Self Reported^^xsd:string</para>
    ///   <para>rdfs:label : Self Reported</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SelfReported">aos:SelfReported</a>
    /// </summary>
    let SelfReported = _prefixId.prefix "SelfReported"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Sex^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#Sex">aos:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Sex^^xsd:string</para>
    ///   <para>rdfs:label : Sex (ISO/IEC 5218)</para>
    ///   <para>rdfs:comment : Strict F/M coding of Gender types, with restriction.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SexISO5218">aos:SexISO5218</a>
    /// </summary>
    let SexISO5218 = _prefixId.prefix "SexISO5218"
    let SexISO5218_0 = _prefixId.prefix "SexISO5218-0"
    let SexISO5218_1 = _prefixId.prefix "SexISO5218-1"
    let SexISO5218_2 = _prefixId.prefix "SexISO5218-2"
    let SexISO5218_9 = _prefixId.prefix "SexISO5218-9"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : SexGenomeTyping^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SexTyping">aos:SexTyping</a>
    /// </summary>
    let SexTyping = _prefixId.prefix "SexTyping"
    let SexTypingXX = _prefixId.prefix "SexTypingXX"
    let SexTypingXY = _prefixId.prefix "SexTypingXY"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Skin Color^^xsd:string</para>
    ///   <para>rdfs:label : Skin Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SkinColor">aos:SkinColor</a>
    /// </summary>
    let SkinColor = _prefixId.prefix "SkinColor"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Fitzpatrick scale^^xsd:string</para>
    ///   <para>rdfs:label : Fitzpatrick Scale Type</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorFitzpatrickType">aos:SkinColorFitzpatrickType</a>
    /// </summary>
    let SkinColorFitzpatrickType = _prefixId.prefix "SkinColorFitzpatrickType"
    let SkinColorFitzpatrickTypeI = _prefixId.prefix "SkinColorFitzpatrickTypeI"
    let SkinColorFitzpatrickTypeII = _prefixId.prefix "SkinColorFitzpatrickTypeII"
    let SkinColorFitzpatrickTypeIII = _prefixId.prefix "SkinColorFitzpatrickTypeIII"
    let SkinColorFitzpatrickTypeIV = _prefixId.prefix "SkinColorFitzpatrickTypeIV"
    let SkinColorFitzpatrickTypeV = _prefixId.prefix "SkinColorFitzpatrickTypeV"
    let SkinColorFitzpatrickTypeVI = _prefixId.prefix "SkinColorFitzpatrickTypeVI"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Simple Skin Color^^xsd:string</para>
    ///   <para>rdfs:label : Simple Skin Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorSimple">aos:SkinColorSimple</a>
    /// </summary>
    let SkinColorSimple = _prefixId.prefix "SkinColorSimple"
    let SkinColorSimpleAlbino = _prefixId.prefix "SkinColorSimpleAlbino"
    let SkinColorSimpleBlack = _prefixId.prefix "SkinColorSimpleBlack"
    let SkinColorSimpleBrown = _prefixId.prefix "SkinColorSimpleBrown"
    let SkinColorSimpleOlive = _prefixId.prefix "SkinColorSimpleOlive"
    let SkinColorSimpleWhite = _prefixId.prefix "SkinColorSimpleWhite"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Von_Luschan_scale^^xsd:string</para>
    ///   <para>rdfs:label : Skin Color</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#SkinColorVonLuschan">aos:SkinColorVonLuschan</a>
    /// </summary>
    let SkinColorVonLuschan = _prefixId.prefix "SkinColorVonLuschan"
    let SkinColorVonLuschan1 = _prefixId.prefix "SkinColorVonLuschan1"
    let SkinColorVonLuschan10 = _prefixId.prefix "SkinColorVonLuschan10"
    let SkinColorVonLuschan11 = _prefixId.prefix "SkinColorVonLuschan11"
    let SkinColorVonLuschan12 = _prefixId.prefix "SkinColorVonLuschan12"
    let SkinColorVonLuschan13 = _prefixId.prefix "SkinColorVonLuschan13"
    let SkinColorVonLuschan14 = _prefixId.prefix "SkinColorVonLuschan14"
    let SkinColorVonLuschan15 = _prefixId.prefix "SkinColorVonLuschan15"
    let SkinColorVonLuschan16 = _prefixId.prefix "SkinColorVonLuschan16"
    let SkinColorVonLuschan17 = _prefixId.prefix "SkinColorVonLuschan17"
    let SkinColorVonLuschan18 = _prefixId.prefix "SkinColorVonLuschan18"
    let SkinColorVonLuschan19 = _prefixId.prefix "SkinColorVonLuschan19"
    let SkinColorVonLuschan2 = _prefixId.prefix "SkinColorVonLuschan2"
    let SkinColorVonLuschan20 = _prefixId.prefix "SkinColorVonLuschan20"
    let SkinColorVonLuschan21 = _prefixId.prefix "SkinColorVonLuschan21"
    let SkinColorVonLuschan22 = _prefixId.prefix "SkinColorVonLuschan22"
    let SkinColorVonLuschan23 = _prefixId.prefix "SkinColorVonLuschan23"
    let SkinColorVonLuschan24 = _prefixId.prefix "SkinColorVonLuschan24"
    let SkinColorVonLuschan25 = _prefixId.prefix "SkinColorVonLuschan25"
    let SkinColorVonLuschan26 = _prefixId.prefix "SkinColorVonLuschan26"
    let SkinColorVonLuschan27 = _prefixId.prefix "SkinColorVonLuschan27"
    let SkinColorVonLuschan28 = _prefixId.prefix "SkinColorVonLuschan28"
    let SkinColorVonLuschan29 = _prefixId.prefix "SkinColorVonLuschan29"
    let SkinColorVonLuschan3 = _prefixId.prefix "SkinColorVonLuschan3"
    let SkinColorVonLuschan30 = _prefixId.prefix "SkinColorVonLuschan30"
    let SkinColorVonLuschan31 = _prefixId.prefix "SkinColorVonLuschan31"
    let SkinColorVonLuschan32 = _prefixId.prefix "SkinColorVonLuschan32"
    let SkinColorVonLuschan33 = _prefixId.prefix "SkinColorVonLuschan33"
    let SkinColorVonLuschan34 = _prefixId.prefix "SkinColorVonLuschan34"
    let SkinColorVonLuschan35 = _prefixId.prefix "SkinColorVonLuschan35"
    let SkinColorVonLuschan36 = _prefixId.prefix "SkinColorVonLuschan36"
    let SkinColorVonLuschan4 = _prefixId.prefix "SkinColorVonLuschan4"
    let SkinColorVonLuschan5 = _prefixId.prefix "SkinColorVonLuschan5"
    let SkinColorVonLuschan6 = _prefixId.prefix "SkinColorVonLuschan6"
    let SkinColorVonLuschan7 = _prefixId.prefix "SkinColorVonLuschan7"
    let SkinColorVonLuschan8 = _prefixId.prefix "SkinColorVonLuschan8"
    let SkinColorVonLuschan9 = _prefixId.prefix "SkinColorVonLuschan9"
    let VonLuschan1 = _prefixId.prefix "VonLuschan1"
    let adriel = _prefixId.prefix "adriel"
    let blackwell_publishing_ltd = _prefixId.prefix "blackwell_publishing_ltd"
    let c_r_sahagian = _prefixId.prefix "c_r_sahagian"
    let crc_press = _prefixId.prefix "crc_press"
    let e_s_gragoudas = _prefixId.prefix "e_s_gragoudas"
    let florent_cunier = _prefixId.prefix "florent_cunier"
    let fox_michelle_j = _prefixId.prefix "fox_michelle_j"
    let grieve_j = _prefixId.prefix "grieve_j"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasAppearance^^xsd:string</para>
    ///   <para>rdfs:label : has Appearance</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasAppearance">aos:hasAppearance</a>
    /// </summary>
    let hasAppearance = _prefixId.prefix "hasAppearance"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Arm Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Arm Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurement">aos:hasArmMeasurement</a>
    /// </summary>
    let hasArmMeasurement = _prefixId.prefix "hasArmMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Arm Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Arm Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementInches">aos:hasArmMeasurementInches</a>
    /// </summary>
    let hasArmMeasurementInches = _prefixId.prefix "hasArmMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Arm Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Arm Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasArmMeasurementMeters">aos:hasArmMeasurementMeters</a>
    /// </summary>
    let hasArmMeasurementMeters = _prefixId.prefix "hasArmMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Band Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Band Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurement">aos:hasBandMeasurement</a>
    /// </summary>
    let hasBandMeasurement = _prefixId.prefix "hasBandMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Band Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Band Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementInches">aos:hasBandMeasurementInches</a>
    /// </summary>
    let hasBandMeasurementInches = _prefixId.prefix "hasBandMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Band Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Band Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasBandMeasurementMeters">aos:hasBandMeasurementMeters</a>
    /// </summary>
    let hasBandMeasurementMeters = _prefixId.prefix "hasBandMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Body Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Body Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasBodyMeasurement">aos:hasBodyMeasurement</a>
    /// </summary>
    let hasBodyMeasurement = _prefixId.prefix "hasBodyMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Over Chest Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Chest Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurement">aos:hasChestMeasurement</a>
    /// </summary>
    let hasChestMeasurement = _prefixId.prefix "hasChestMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Chest Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Chest Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementInches">aos:hasChestMeasurementInches</a>
    /// </summary>
    let hasChestMeasurementInches = _prefixId.prefix "hasChestMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Chest Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Chest Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasChestMeasurementMeters">aos:hasChestMeasurementMeters</a>
    /// </summary>
    let hasChestMeasurementMeters = _prefixId.prefix "hasChestMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasEntertaimentAversion^^xsd:string</para>
    ///   <para>rdfs:label : has Entertaiment Aversion</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentAversion">aos:hasEntertaimentAversion</a>
    /// </summary>
    let hasEntertaimentAversion = _prefixId.prefix "hasEntertaimentAversion"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasEntertaimentPreference^^xsd:string</para>
    ///   <para>rdfs:label : has Entertaiment Preference</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasEntertaimentPreference">aos:hasEntertaimentPreference</a>
    /// </summary>
    let hasEntertaimentPreference = _prefixId.prefix "hasEntertaimentPreference"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Gender^^xsd:string</para>
    ///   <para>rdfs:label : Has Gender</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasGender">aos:hasGender</a>
    /// </summary>
    let hasGender = _prefixId.prefix "hasGender"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Height Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Height Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurement">aos:hasHeightMeasurement</a>
    /// </summary>
    let hasHeightMeasurement = _prefixId.prefix "hasHeightMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Height Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Height Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementInches">aos:hasHeightMeasurementInches</a>
    /// </summary>
    let hasHeightMeasurementInches = _prefixId.prefix "hasHeightMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Height Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : has Height Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHeightMeasurementMeters">aos:hasHeightMeasurementMeters</a>
    /// </summary>
    let hasHeightMeasurementMeters = _prefixId.prefix "hasHeightMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Hips Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Hips Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurement">aos:hasHipsMeasurement</a>
    /// </summary>
    let hasHipsMeasurement = _prefixId.prefix "hasHipsMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Hips Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Hips Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementInches">aos:hasHipsMeasurementInches</a>
    /// </summary>
    let hasHipsMeasurementInches = _prefixId.prefix "hasHipsMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Hips Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Hips Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasHipsMeasurementMeters">aos:hasHipsMeasurementMeters</a>
    /// </summary>
    let hasHipsMeasurementMeters = _prefixId.prefix "hasHipsMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Inseam Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Inseam Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurement">aos:hasInseamMeasurement</a>
    /// </summary>
    let hasInseamMeasurement = _prefixId.prefix "hasInseamMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Inseam Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Inseam Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementInches">aos:hasInseamMeasurementInches</a>
    /// </summary>
    let hasInseamMeasurementInches = _prefixId.prefix "hasInseamMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Inseam Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Inseam Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasInseamMeasurementMeters">aos:hasInseamMeasurementMeters</a>
    /// </summary>
    let hasInseamMeasurementMeters = _prefixId.prefix "hasInseamMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Knee Length Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Knee Length Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurement">aos:hasKneeLengthMeasurement</a>
    /// </summary>
    let hasKneeLengthMeasurement = _prefixId.prefix "hasKneeLengthMeasurement"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Knee Length Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Knee Length Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementInches">aos:hasKneeLengthMeasurementInches</a>
    /// </summary>
    let hasKneeLengthMeasurementInches =
        _prefixId.prefix "hasKneeLengthMeasurementInches"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Knee Length Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Knee Length Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasKneeLengthMeasurementMeters">aos:hasKneeLengthMeasurementMeters</a>
    /// </summary>
    let hasKneeLengthMeasurementMeters =
        _prefixId.prefix "hasKneeLengthMeasurementMeters"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Neck Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Neck Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurement">aos:hasNeckMeasurement</a>
    /// </summary>
    let hasNeckMeasurement = _prefixId.prefix "hasNeckMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Neck Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Neck Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementInches">aos:hasNeckMeasurementInches</a>
    /// </summary>
    let hasNeckMeasurementInches = _prefixId.prefix "hasNeckMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Neck Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Neck Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasNeckMeasurementMeters">aos:hasNeckMeasurementMeters</a>
    /// </summary>
    let hasNeckMeasurementMeters = _prefixId.prefix "hasNeckMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Over Arm Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Over Arm Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurement">aos:hasOverArmMeasurement</a>
    /// </summary>
    let hasOverArmMeasurement = _prefixId.prefix "hasOverArmMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Over Arm Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Over Arm Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementInches">aos:hasOverArmMeasurementInches</a>
    /// </summary>
    let hasOverArmMeasurementInches = _prefixId.prefix "hasOverArmMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Over Arm Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Over Arm Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasOverArmMeasurementMeters">aos:hasOverArmMeasurementMeters</a>
    /// </summary>
    let hasOverArmMeasurementMeters = _prefixId.prefix "hasOverArmMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Pant Length Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Pant Length Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurement">aos:hasPantLengthMeasurement</a>
    /// </summary>
    let hasPantLengthMeasurement = _prefixId.prefix "hasPantLengthMeasurement"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Pant Length Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Pant Length Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementInches">aos:hasPantLengthMeasurementInches</a>
    /// </summary>
    let hasPantLengthMeasurementInches =
        _prefixId.prefix "hasPantLengthMeasurementInches"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Pant Length Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Pant Length Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasPantLengthMeasurementMeters">aos:hasPantLengthMeasurementMeters</a>
    /// </summary>
    let hasPantLengthMeasurementMeters =
        _prefixId.prefix "hasPantLengthMeasurementMeters"

    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasRomanticAversion^^xsd:string</para>
    ///   <para>rdfs:label : has Romantic Aversion</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasRomanticAversion">aos:hasRomanticAversion</a>
    /// </summary>
    let hasRomanticAversion = _prefixId.prefix "hasRomanticAversion"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasRomanticPreference^^xsd:string</para>
    ///   <para>rdfs:label : has Romantic Preference</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasRomanticPreference">aos:hasRomanticPreference</a>
    /// </summary>
    let hasRomanticPreference = _prefixId.prefix "hasRomanticPreference"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Sex^^xsd:string</para>
    ///   <para>rdfs:label : Has Sex</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasSex">aos:hasSex</a>
    /// </summary>
    let hasSex = _prefixId.prefix "hasSex"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasSexualAversion^^xsd:string</para>
    ///   <para>rdfs:label : has Sexual Aversion</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasSexualAversion">aos:hasSexualAversion</a>
    /// </summary>
    let hasSexualAversion = _prefixId.prefix "hasSexualAversion"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : hasSexualPreference^^xsd:string</para>
    ///   <para>rdfs:label : has Sexual Preference</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasSexualPreference">aos:hasSexualPreference</a>
    /// </summary>
    let hasSexualPreference = _prefixId.prefix "hasSexualPreference"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Thigh Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Thigh Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurement">aos:hasThighMeasurement</a>
    /// </summary>
    let hasThighMeasurement = _prefixId.prefix "hasThighMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Thigh Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Thigh Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementInches">aos:hasThighMeasurementInches</a>
    /// </summary>
    let hasThighMeasurementInches = _prefixId.prefix "hasThighMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Thigh Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Thigh Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasThighMeasurementMeters">aos:hasThighMeasurementMeters</a>
    /// </summary>
    let hasThighMeasurementMeters = _prefixId.prefix "hasThighMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Waist Measurement^^xsd:string</para>
    ///   <para>rdfs:label : Has Waist Measurement</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurement">aos:hasWaistMeasurement</a>
    /// </summary>
    let hasWaistMeasurement = _prefixId.prefix "hasWaistMeasurement"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Waist Measurement Inches^^xsd:string</para>
    ///   <para>rdfs:label : Has Waist Measurement in Inches</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementInches">aos:hasWaistMeasurementInches</a>
    /// </summary>
    let hasWaistMeasurementInches = _prefixId.prefix "hasWaistMeasurementInches"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Waist Measurement Meters^^xsd:string</para>
    ///   <para>rdfs:label : Has Waist Measurement in Meters</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#hasWaistMeasurementMeters">aos:hasWaistMeasurementMeters</a>
    /// </summary>
    let hasWaistMeasurementMeters = _prefixId.prefix "hasWaistMeasurementMeters"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : htmlColor^^xsd:string</para>
    ///   <para>rdfs:label : htmlColor</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#htmlColor">aos:htmlColor</a>
    /// </summary>
    let htmlColor = _prefixId.prefix "htmlColor"
    let j_m_seddon = _prefixId.prefix "j_m_seddon"
    let j_petrequin = _prefixId.prefix "j_petrequin"
    let john_churchill = _prefixId.prefix "john_churchill"
    /// <summary>
    ///   <para>http://xmlns.com/foaf/spec/name : Macro Ethnicity^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/appearances#macroEthnicity">aos:macroEthnicity</a>
    /// </summary>
    let macroEthnicity = _prefixId.prefix "macroEthnicity"
    let morant_g_m = _prefixId.prefix "morant_g_m"
    let ogle_robert_r = _prefixId.prefix "ogle_robert_r"
    let petrequin = _prefixId.prefix "petrequin"
    let r_d_sperduto = _prefixId.prefix "r_d_sperduto"
    let r_j_glynn = _prefixId.prefix "r_j_glynn"
    let riddell_w_j_b = _prefixId.prefix "riddell_w_j_b"
    let seddon = _prefixId.prefix "seddon"
    let wilde1862 = _prefixId.prefix "wilde1862"

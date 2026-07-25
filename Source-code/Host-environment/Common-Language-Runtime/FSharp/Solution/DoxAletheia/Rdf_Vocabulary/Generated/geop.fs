namespace http.aims.fao.org.aos.geopolitical.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geop =
    let _namespace_iri = Namespace_Iri geop |> NamespaceIRI
    /// <summary>
    ///   <para>geop:AMU</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#AMU">http://aims.fao.org/aos/geopolitical.owl#AMU</seealso>
    let AMU = Prefixed_Name(geop, "AMU") |> PrefixedName
    /// <summary>
    ///   <para>geop:Algeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Algeria">http://aims.fao.org/aos/geopolitical.owl#Algeria</seealso>
    let Algeria = Prefixed_Name(geop, "Algeria") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListES">http://aims.fao.org/aos/geopolitical.owl#nameListES</seealso>
    let nameListES = Prefixed_Name(geop, "nameListES") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialEN">http://aims.fao.org/aos/geopolitical.owl#nameOfficialEN</seealso>
    let nameOfficialEN = Prefixed_Name(geop, "nameOfficialEN") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialFR">http://aims.fao.org/aos/geopolitical.owl#nameOfficialFR</seealso>
    let nameOfficialFR = Prefixed_Name(geop, "nameOfficialFR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortFR">http://aims.fao.org/aos/geopolitical.owl#nameShortFR</seealso>
    let nameShortFR = Prefixed_Name(geop, "nameShortFR") |> PrefixedName
    /// <summary>
    ///   <para>geop:sourceCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#sourceCreator">http://aims.fao.org/aos/geopolitical.owl#sourceCreator</seealso>
    let sourceCreator = Prefixed_Name(geop, "sourceCreator") |> PrefixedName

    /// <summary>
    ///   <para>geop:GDPTotalInCurrentPrices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#GDPTotalInCurrentPrices">http://aims.fao.org/aos/geopolitical.owl#GDPTotalInCurrentPrices</seealso>
    let GDPTotalInCurrentPrices =
        Prefixed_Name(geop, "GDPTotalInCurrentPrices") |> PrefixedName

    /// <summary>
    ///   <para>geop:HDINotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#HDINotes">http://aims.fao.org/aos/geopolitical.owl#HDINotes</seealso>
    let HDINotes = Prefixed_Name(geop, "HDINotes") |> PrefixedName

    /// <summary>
    ///   <para>geop:agriculturalAreaNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaNotes">http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaNotes</seealso>
    let agriculturalAreaNotes =
        Prefixed_Name(geop, "agriculturalAreaNotes") |> PrefixedName

    /// <summary>
    ///   <para>geop:agriculturalAreaYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaYear">http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaYear</seealso>
    let agriculturalAreaYear =
        Prefixed_Name(geop, "agriculturalAreaYear") |> PrefixedName

    /// <summary>
    ///   <para>geop:codeAGROVOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeAGROVOC">http://aims.fao.org/aos/geopolitical.owl#codeAGROVOC</seealso>
    let codeAGROVOC = Prefixed_Name(geop, "codeAGROVOC") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeGAUL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeGAUL">http://aims.fao.org/aos/geopolitical.owl#codeGAUL</seealso>
    let codeGAUL = Prefixed_Name(geop, "codeGAUL") |> PrefixedName
    /// <summary>
    ///   <para>geop:Eritrea</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Eritrea">http://aims.fao.org/aos/geopolitical.owl#Eritrea</seealso>
    let Eritrea = Prefixed_Name(geop, "Eritrea") |> PrefixedName
    /// <summary>
    ///   <para>geop:Lesotho</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Lesotho">http://aims.fao.org/aos/geopolitical.owl#Lesotho</seealso>
    let Lesotho = Prefixed_Name(geop, "Lesotho") |> PrefixedName

    /// <summary>
    ///   <para>geop:Democratic_Republic_of_the_Congo</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Republic_of_the_Congo">http://aims.fao.org/aos/geopolitical.owl#Democratic_Republic_of_the_Congo</seealso>
    let Democratic_Republic_of_the_Congo =
        Prefixed_Name(geop, "Democratic_Republic_of_the_Congo") |> PrefixedName

    /// <summary>
    ///   <para>geop:Somalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Somalia">http://aims.fao.org/aos/geopolitical.owl#Somalia</seealso>
    let Somalia = Prefixed_Name(geop, "Somalia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Seychelles</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Seychelles">http://aims.fao.org/aos/geopolitical.owl#Seychelles</seealso>
    let Seychelles = Prefixed_Name(geop, "Seychelles") |> PrefixedName

    /// <summary>
    ///   <para>geop:Central_African_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Central_African_Republic_the">http://aims.fao.org/aos/geopolitical.owl#Central_African_Republic_the</seealso>
    let Central_African_Republic_the =
        Prefixed_Name(geop, "Central_African_Republic_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Angola</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Angola">http://aims.fao.org/aos/geopolitical.owl#Angola</seealso>
    let Angola = Prefixed_Name(geop, "Angola") |> PrefixedName
    /// <summary>
    ///   <para>geop:Nigeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Nigeria">http://aims.fao.org/aos/geopolitical.owl#Nigeria</seealso>
    let Nigeria = Prefixed_Name(geop, "Nigeria") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cape_Verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cape_Verde">http://aims.fao.org/aos/geopolitical.owl#Cape_Verde</seealso>
    let Cape_Verde = Prefixed_Name(geop, "Cape_Verde") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mauritius</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mauritius">http://aims.fao.org/aos/geopolitical.owl#Mauritius</seealso>
    let Mauritius = Prefixed_Name(geop, "Mauritius") |> PrefixedName
    /// <summary>
    ///   <para>geop:Senegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Senegal">http://aims.fao.org/aos/geopolitical.owl#Senegal</seealso>
    let Senegal = Prefixed_Name(geop, "Senegal") |> PrefixedName
    /// <summary>
    ///   <para>geop:Togo</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Togo">http://aims.fao.org/aos/geopolitical.owl#Togo</seealso>
    let Togo = Prefixed_Name(geop, "Togo") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mali</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mali">http://aims.fao.org/aos/geopolitical.owl#Mali</seealso>
    let Mali = Prefixed_Name(geop, "Mali") |> PrefixedName
    /// <summary>
    ///   <para>geop:Namibia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Namibia">http://aims.fao.org/aos/geopolitical.owl#Namibia</seealso>
    let Namibia = Prefixed_Name(geop, "Namibia") |> PrefixedName
    /// <summary>
    ///   <para>geop:NFIDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#NFIDC">http://aims.fao.org/aos/geopolitical.owl#NFIDC</seealso>
    let NFIDC = Prefixed_Name(geop, "NFIDC") |> PrefixedName
    /// <summary>
    ///   <para>geop:Belarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Belarus">http://aims.fao.org/aos/geopolitical.owl#Belarus</seealso>
    let Belarus = Prefixed_Name(geop, "Belarus") |> PrefixedName
    /// <summary>
    ///   <para>geop:Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Poland">http://aims.fao.org/aos/geopolitical.owl#Poland</seealso>
    let Poland = Prefixed_Name(geop, "Poland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Lithuania">http://aims.fao.org/aos/geopolitical.owl#Lithuania</seealso>
    let Lithuania = Prefixed_Name(geop, "Lithuania") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ukraine">http://aims.fao.org/aos/geopolitical.owl#Ukraine</seealso>
    let Ukraine = Prefixed_Name(geop, "Ukraine") |> PrefixedName
    /// <summary>
    ///   <para>geop:eastern_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#eastern_Europe">http://aims.fao.org/aos/geopolitical.owl#eastern_Europe</seealso>
    let eastern_Europe = Prefixed_Name(geop, "eastern_Europe") |> PrefixedName
    /// <summary>
    ///   <para>geop:Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Romania">http://aims.fao.org/aos/geopolitical.owl#Romania</seealso>
    let Romania = Prefixed_Name(geop, "Romania") |> PrefixedName
    /// <summary>
    ///   <para>geop:CEN_SAD_1998</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD_1998">http://aims.fao.org/aos/geopolitical.owl#CEN_SAD_1998</seealso>
    let CEN_SAD_1998 = Prefixed_Name(geop, "CEN_SAD_1998") |> PrefixedName
    /// <summary>
    ///   <para>geop:eastern_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#eastern_Africa">http://aims.fao.org/aos/geopolitical.owl#eastern_Africa</seealso>
    let eastern_Africa = Prefixed_Name(geop, "eastern_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:COMESA_1994</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#COMESA_1994">http://aims.fao.org/aos/geopolitical.owl#COMESA_1994</seealso>
    let COMESA_1994 = Prefixed_Name(geop, "COMESA_1994") |> PrefixedName
    /// <summary>
    ///   <para>geop:COMESA</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#COMESA">http://aims.fao.org/aos/geopolitical.owl#COMESA</seealso>
    let COMESA = Prefixed_Name(geop, "COMESA") |> PrefixedName
    /// <summary>
    ///   <para>geop:sourceModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#sourceModified">http://aims.fao.org/aos/geopolitical.owl#sourceModified</seealso>
    let sourceModified = Prefixed_Name(geop, "sourceModified") |> PrefixedName
    /// <summary>
    ///   <para>geop:CAEU</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CAEU">http://aims.fao.org/aos/geopolitical.owl#CAEU</seealso>
    let CAEU = Prefixed_Name(geop, "CAEU") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasMember">http://aims.fao.org/aos/geopolitical.owl#hasMember</seealso>
    let hasMember = Prefixed_Name(geop, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>geop:Morocco</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Morocco">http://aims.fao.org/aos/geopolitical.owl#Morocco</seealso>
    let Morocco = Prefixed_Name(geop, "Morocco") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialAR">http://aims.fao.org/aos/geopolitical.owl#nameOfficialAR</seealso>
    let nameOfficialAR = Prefixed_Name(geop, "nameOfficialAR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortEN">http://aims.fao.org/aos/geopolitical.owl#nameShortEN</seealso>
    let nameShortEN = Prefixed_Name(geop, "nameShortEN") |> PrefixedName
    /// <summary>
    ///   <para>geop:validSince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of the datatype property *validSince* associated to a particular area (territory or group) indicates the area's  first year of validity.  The geopolitical ontology traces back historic changes only until 1985, therefore, if an area has a validSince = 1985, this indicates that the area is/was valid since 1985 or before.       </para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#validSince">http://aims.fao.org/aos/geopolitical.owl#validSince</seealso>
    let validSince = Prefixed_Name(geop, "validSince") |> PrefixedName
    /// <summary>
    ///   <para>geop:economic_region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#economic_region">http://aims.fao.org/aos/geopolitical.owl#economic_region</seealso>
    let economic_region = Prefixed_Name(geop, "economic_region") |> PrefixedName
    /// <summary>
    ///   <para>geop:GDPUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#GDPUnit">http://aims.fao.org/aos/geopolitical.owl#GDPUnit</seealso>
    let GDPUnit = Prefixed_Name(geop, "GDPUnit") |> PrefixedName
    /// <summary>
    ///   <para>geop:HDIYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#HDIYear">http://aims.fao.org/aos/geopolitical.owl#HDIYear</seealso>
    let HDIYear = Prefixed_Name(geop, "HDIYear") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeCurrency">http://aims.fao.org/aos/geopolitical.owl#codeCurrency</seealso>
    let codeCurrency = Prefixed_Name(geop, "codeCurrency") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeISO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeISO2">http://aims.fao.org/aos/geopolitical.owl#codeISO2</seealso>
    let codeISO2 = Prefixed_Name(geop, "codeISO2") |> PrefixedName
    /// <summary>
    ///   <para>geop:Gambia__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Gambia__the">http://aims.fao.org/aos/geopolitical.owl#Gambia__the</seealso>
    let Gambia__the = Prefixed_Name(geop, "Gambia__the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guinea-Bissau</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guinea-Bissau">http://aims.fao.org/aos/geopolitical.owl#Guinea-Bissau</seealso>
    let Guinea_Bissau = Prefixed_Name(geop, "Guinea-Bissau") |> PrefixedName
    /// <summary>
    ///   <para>geop:South_Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#South_Sudan">http://aims.fao.org/aos/geopolitical.owl#South_Sudan</seealso>
    let South_Sudan = Prefixed_Name(geop, "South_Sudan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Congo_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Congo_the">http://aims.fao.org/aos/geopolitical.owl#Congo_the</seealso>
    let Congo_the = Prefixed_Name(geop, "Congo_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Madagascar</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Madagascar">http://aims.fao.org/aos/geopolitical.owl#Madagascar</seealso>
    let Madagascar = Prefixed_Name(geop, "Madagascar") |> PrefixedName
    /// <summary>
    ///   <para>geop:Swaziland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Swaziland">http://aims.fao.org/aos/geopolitical.owl#Swaziland</seealso>
    let Swaziland = Prefixed_Name(geop, "Swaziland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Niger_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Niger_the">http://aims.fao.org/aos/geopolitical.owl#Niger_the</seealso>
    let Niger_the = Prefixed_Name(geop, "Niger_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Martinique</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Martinique">http://aims.fao.org/aos/geopolitical.owl#Martinique</seealso>
    let Martinique = Prefixed_Name(geop, "Martinique") |> PrefixedName

    /// <summary>
    ///   <para>geop:Serbia_and_Montenegro</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Serbia_and_Montenegro">http://aims.fao.org/aos/geopolitical.owl#Serbia_and_Montenegro</seealso>
    let Serbia_and_Montenegro =
        Prefixed_Name(geop, "Serbia_and_Montenegro") |> PrefixedName

    /// <summary>
    ///   <para>geop:Montserrat</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Montserrat">http://aims.fao.org/aos/geopolitical.owl#Montserrat</seealso>
    let Montserrat = Prefixed_Name(geop, "Montserrat") |> PrefixedName
    /// <summary>
    ///   <para>geop:Libya</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Libya">http://aims.fao.org/aos/geopolitical.owl#Libya</seealso>
    let Libya = Prefixed_Name(geop, "Libya") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialRU">http://aims.fao.org/aos/geopolitical.owl#nameOfficialRU</seealso>
    let nameOfficialRU = Prefixed_Name(geop, "nameOfficialRU") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortES">http://aims.fao.org/aos/geopolitical.owl#nameShortES</seealso>
    let nameShortES = Prefixed_Name(geop, "nameShortES") |> PrefixedName
    /// <summary>
    ///   <para>geop:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The value of the datatype property *validUntil* associated to a particular area (territory or group) indicates the area's last year of validity. In case the area is currently valid, this value is set by default to 9999.
    ///       </para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#validUntil">http://aims.fao.org/aos/geopolitical.owl#validUntil</seealso>
    let validUntil = Prefixed_Name(geop, "validUntil") |> PrefixedName
    /// <summary>
    ///   <para>geop:HDITotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#HDITotal">http://aims.fao.org/aos/geopolitical.owl#HDITotal</seealso>
    let HDITotal = Prefixed_Name(geop, "HDITotal") |> PrefixedName

    /// <summary>
    ///   <para>geop:agriculturalAreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaUnit">http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaUnit</seealso>
    let agriculturalAreaUnit =
        Prefixed_Name(geop, "agriculturalAreaUnit") |> PrefixedName

    /// <summary>
    ///   <para>geop:codeFAOSTAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeFAOSTAT">http://aims.fao.org/aos/geopolitical.owl#codeFAOSTAT</seealso>
    let codeFAOSTAT = Prefixed_Name(geop, "codeFAOSTAT") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mozambique</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mozambique">http://aims.fao.org/aos/geopolitical.owl#Mozambique</seealso>
    let Mozambique = Prefixed_Name(geop, "Mozambique") |> PrefixedName
    /// <summary>
    ///   <para>geop:Benin</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Benin">http://aims.fao.org/aos/geopolitical.owl#Benin</seealso>
    let Benin = Prefixed_Name(geop, "Benin") |> PrefixedName
    /// <summary>
    ///   <para>geop:Uganda</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Uganda">http://aims.fao.org/aos/geopolitical.owl#Uganda</seealso>
    let Uganda = Prefixed_Name(geop, "Uganda") |> PrefixedName
    /// <summary>
    ///   <para>geop:Equatorial_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Equatorial_Guinea">http://aims.fao.org/aos/geopolitical.owl#Equatorial_Guinea</seealso>
    let Equatorial_Guinea = Prefixed_Name(geop, "Equatorial_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>geop:Zimbabwe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Zimbabwe">http://aims.fao.org/aos/geopolitical.owl#Zimbabwe</seealso>
    let Zimbabwe = Prefixed_Name(geop, "Zimbabwe") |> PrefixedName
    /// <summary>
    ///   <para>geop:Burkina_Faso</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Burkina_Faso">http://aims.fao.org/aos/geopolitical.owl#Burkina_Faso</seealso>
    let Burkina_Faso = Prefixed_Name(geop, "Burkina_Faso") |> PrefixedName
    /// <summary>
    ///   <para>geop:southern_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#southern_Africa">http://aims.fao.org/aos/geopolitical.owl#southern_Africa</seealso>
    let southern_Africa = Prefixed_Name(geop, "southern_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:French_Guiana</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#French_Guiana">http://aims.fao.org/aos/geopolitical.owl#French_Guiana</seealso>
    let French_Guiana = Prefixed_Name(geop, "French_Guiana") |> PrefixedName
    /// <summary>
    ///   <para>geop:Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Portugal">http://aims.fao.org/aos/geopolitical.owl#Portugal</seealso>
    let Portugal = Prefixed_Name(geop, "Portugal") |> PrefixedName
    /// <summary>
    ///   <para>geop:Malta</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Malta">http://aims.fao.org/aos/geopolitical.owl#Malta</seealso>
    let Malta = Prefixed_Name(geop, "Malta") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ethiopia_1993</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia_1993">http://aims.fao.org/aos/geopolitical.owl#Ethiopia_1993</seealso>
    let Ethiopia_1993 = Prefixed_Name(geop, "Ethiopia_1993") |> PrefixedName
    /// <summary>
    ///   <para>geop:Faroe_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    ///   <para>associate member of FAO</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Faroe_Islands">http://aims.fao.org/aos/geopolitical.owl#Faroe_Islands</seealso>
    let Faroe_Islands = Prefixed_Name(geop, "Faroe_Islands") |> PrefixedName
    /// <summary>
    ///   <para>geop:Republic_of_Moldova</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Moldova">http://aims.fao.org/aos/geopolitical.owl#Republic_of_Moldova</seealso>
    let Republic_of_Moldova = Prefixed_Name(geop, "Republic_of_Moldova") |> PrefixedName
    /// <summary>
    ///   <para>geop:San_Marino</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#San_Marino">http://aims.fao.org/aos/geopolitical.owl#San_Marino</seealso>
    let San_Marino = Prefixed_Name(geop, "San_Marino") |> PrefixedName
    /// <summary>
    ///   <para>geop:Monaco</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Monaco">http://aims.fao.org/aos/geopolitical.owl#Monaco</seealso>
    let Monaco = Prefixed_Name(geop, "Monaco") |> PrefixedName
    /// <summary>
    ///   <para>geop:Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Norway">http://aims.fao.org/aos/geopolitical.owl#Norway</seealso>
    let Norway = Prefixed_Name(geop, "Norway") |> PrefixedName

    /// <summary>
    ///   <para>geop:United_States_Virgin_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#United_States_Virgin_Islands">http://aims.fao.org/aos/geopolitical.owl#United_States_Virgin_Islands</seealso>
    let United_States_Virgin_Islands =
        Prefixed_Name(geop, "United_States_Virgin_Islands") |> PrefixedName

    /// <summary>
    ///   <para>geop:Saint-Martin</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint-Martin">http://aims.fao.org/aos/geopolitical.owl#Saint-Martin</seealso>
    let Saint_Martin = Prefixed_Name(geop, "Saint-Martin") |> PrefixedName
    /// <summary>
    ///   <para>geop:Saint_Barthelemy</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Barthelemy">http://aims.fao.org/aos/geopolitical.owl#Saint_Barthelemy</seealso>
    let Saint_Barthelemy = Prefixed_Name(geop, "Saint_Barthelemy") |> PrefixedName
    /// <summary>
    ///   <para>geop:Saint_Helena</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Helena">http://aims.fao.org/aos/geopolitical.owl#Saint_Helena</seealso>
    let Saint_Helena = Prefixed_Name(geop, "Saint_Helena") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialES">http://aims.fao.org/aos/geopolitical.owl#nameOfficialES</seealso>
    let nameOfficialES = Prefixed_Name(geop, "nameOfficialES") |> PrefixedName
    /// <summary>
    ///   <para>geop:Andorra</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Andorra">http://aims.fao.org/aos/geopolitical.owl#Andorra</seealso>
    let Andorra = Prefixed_Name(geop, "Andorra") |> PrefixedName
    /// <summary>
    ///   <para>geop:Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Spain">http://aims.fao.org/aos/geopolitical.owl#Spain</seealso>
    let Spain = Prefixed_Name(geop, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>geop:middle_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#middle_Africa">http://aims.fao.org/aos/geopolitical.owl#middle_Africa</seealso>
    let middle_Africa = Prefixed_Name(geop, "middle_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:SADC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#SADC">http://aims.fao.org/aos/geopolitical.owl#SADC</seealso>
    let SADC = Prefixed_Name(geop, "SADC") |> PrefixedName
    /// <summary>
    ///   <para>geop:CEEAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CEEAC">http://aims.fao.org/aos/geopolitical.owl#CEEAC</seealso>
    let CEEAC = Prefixed_Name(geop, "CEEAC") |> PrefixedName
    /// <summary>
    ///   <para>geop:Anguilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Anguilla">http://aims.fao.org/aos/geopolitical.owl#Anguilla</seealso>
    let Anguilla = Prefixed_Name(geop, "Anguilla") |> PrefixedName

    /// <summary>
    ///   <para>geop:United_Kingdom_of_Great_Britain_and_Northern_Ireland__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#United_Kingdom_of_Great_Britain_and_Northern_Ireland__the">http://aims.fao.org/aos/geopolitical.owl#United_Kingdom_of_Great_Britain_and_Northern_Ireland__the</seealso>
    let United_Kingdom_of_Great_Britain_and_Northern_Ireland__the =
        Prefixed_Name(geop, "United_Kingdom_of_Great_Britain_and_Northern_Ireland__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Antarctica</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:other</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Antarctica">http://aims.fao.org/aos/geopolitical.owl#Antarctica</seealso>
    let Antarctica = Prefixed_Name(geop, "Antarctica") |> PrefixedName
    /// <summary>
    ///   <para>geop:other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#other">http://aims.fao.org/aos/geopolitical.owl#other</seealso>
    let other = Prefixed_Name(geop, "other") |> PrefixedName
    /// <summary>
    ///   <para>geop:CARIFORUM</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CARIFORUM">http://aims.fao.org/aos/geopolitical.owl#CARIFORUM</seealso>
    let CARIFORUM = Prefixed_Name(geop, "CARIFORUM") |> PrefixedName
    /// <summary>
    ///   <para>geop:Caribbean</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Caribbean">http://aims.fao.org/aos/geopolitical.owl#Caribbean</seealso>
    let Caribbean = Prefixed_Name(geop, "Caribbean") |> PrefixedName
    /// <summary>
    ///   <para>geop:CARICOM</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CARICOM">http://aims.fao.org/aos/geopolitical.owl#CARICOM</seealso>
    let CARICOM = Prefixed_Name(geop, "CARICOM") |> PrefixedName
    /// <summary>
    ///   <para>geop:CARICOM_1985</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CARICOM_1985">http://aims.fao.org/aos/geopolitical.owl#CARICOM_1985</seealso>
    let CARICOM_1985 = Prefixed_Name(geop, "CARICOM_1985") |> PrefixedName
    /// <summary>
    ///   <para>geop:South_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#South_America">http://aims.fao.org/aos/geopolitical.owl#South_America</seealso>
    let South_America = Prefixed_Name(geop, "South_America") |> PrefixedName
    /// <summary>
    ///   <para>geop:MERCOSUR_1991</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR_1991">http://aims.fao.org/aos/geopolitical.owl#MERCOSUR_1991</seealso>
    let MERCOSUR_1991 = Prefixed_Name(geop, "MERCOSUR_1991") |> PrefixedName
    /// <summary>
    ///   <para>geop:MERCOSUR</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#MERCOSUR">http://aims.fao.org/aos/geopolitical.owl#MERCOSUR</seealso>
    let MERCOSUR = Prefixed_Name(geop, "MERCOSUR") |> PrefixedName
    /// <summary>
    ///   <para>geop:Armenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Armenia">http://aims.fao.org/aos/geopolitical.owl#Armenia</seealso>
    let Armenia = Prefixed_Name(geop, "Armenia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Turkey">http://aims.fao.org/aos/geopolitical.owl#Turkey</seealso>
    let Turkey = Prefixed_Name(geop, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>geop:Georgia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Georgia">http://aims.fao.org/aos/geopolitical.owl#Georgia</seealso>
    let Georgia = Prefixed_Name(geop, "Georgia") |> PrefixedName
    /// <summary>
    ///   <para>geop:western_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#western_Asia">http://aims.fao.org/aos/geopolitical.owl#western_Asia</seealso>
    let western_Asia = Prefixed_Name(geop, "western_Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:isSuccessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#isSuccessorOf">http://aims.fao.org/aos/geopolitical.owl#isSuccessorOf</seealso>
    let isSuccessorOf = Prefixed_Name(geop, "isSuccessorOf") |> PrefixedName

    /// <summary>
    ///   <para>geop:Union_of_Soviet_Socialist_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Union_of_Soviet_Socialist_Republic_the">http://aims.fao.org/aos/geopolitical.owl#Union_of_Soviet_Socialist_Republic_the</seealso>
    let Union_of_Soviet_Socialist_Republic_the =
        Prefixed_Name(geop, "Union_of_Soviet_Socialist_Republic_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Aruba</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Aruba">http://aims.fao.org/aos/geopolitical.owl#Aruba</seealso>
    let Aruba = Prefixed_Name(geop, "Aruba") |> PrefixedName
    /// <summary>
    ///   <para>geop:Netherlands_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_the">http://aims.fao.org/aos/geopolitical.owl#Netherlands_the</seealso>
    let Netherlands_the = Prefixed_Name(geop, "Netherlands_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Netherlands_Antilles</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Netherlands_Antilles">http://aims.fao.org/aos/geopolitical.owl#Netherlands_Antilles</seealso>
    let Netherlands_Antilles =
        Prefixed_Name(geop, "Netherlands_Antilles") |> PrefixedName

    /// <summary>
    ///   <para>geop:Qatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Qatar">http://aims.fao.org/aos/geopolitical.owl#Qatar</seealso>
    let Qatar = Prefixed_Name(geop, "Qatar") |> PrefixedName
    /// <summary>
    ///   <para>geop:Oman</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Oman">http://aims.fao.org/aos/geopolitical.owl#Oman</seealso>
    let Oman = Prefixed_Name(geop, "Oman") |> PrefixedName
    /// <summary>
    ///   <para>geop:Nepal</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Nepal">http://aims.fao.org/aos/geopolitical.owl#Nepal</seealso>
    let Nepal = Prefixed_Name(geop, "Nepal") |> PrefixedName
    /// <summary>
    ///   <para>geop:Kazakhstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Kazakhstan">http://aims.fao.org/aos/geopolitical.owl#Kazakhstan</seealso>
    let Kazakhstan = Prefixed_Name(geop, "Kazakhstan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Viet_Nam</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Viet_Nam">http://aims.fao.org/aos/geopolitical.owl#Viet_Nam</seealso>
    let Viet_Nam = Prefixed_Name(geop, "Viet_Nam") |> PrefixedName
    /// <summary>
    ///   <para>geop:Israel</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Israel">http://aims.fao.org/aos/geopolitical.owl#Israel</seealso>
    let Israel = Prefixed_Name(geop, "Israel") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cyprus</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cyprus">http://aims.fao.org/aos/geopolitical.owl#Cyprus</seealso>
    let Cyprus = Prefixed_Name(geop, "Cyprus") |> PrefixedName
    /// <summary>
    ///   <para>geop:Myanmar</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Myanmar">http://aims.fao.org/aos/geopolitical.owl#Myanmar</seealso>
    let Myanmar = Prefixed_Name(geop, "Myanmar") |> PrefixedName

    /// <summary>
    ///   <para>geop:United_Arab_Emirates__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#United_Arab_Emirates__the">http://aims.fao.org/aos/geopolitical.owl#United_Arab_Emirates__the</seealso>
    let United_Arab_Emirates__the =
        Prefixed_Name(geop, "United_Arab_Emirates__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Sri_Lanka</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sri_Lanka">http://aims.fao.org/aos/geopolitical.owl#Sri_Lanka</seealso>
    let Sri_Lanka = Prefixed_Name(geop, "Sri_Lanka") |> PrefixedName
    /// <summary>
    ///   <para>geop:Yemen</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Yemen">http://aims.fao.org/aos/geopolitical.owl#Yemen</seealso>
    let Yemen = Prefixed_Name(geop, "Yemen") |> PrefixedName

    /// <summary>
    ///   <para>geop:Democratic_People_s_Republic_of_Korea_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Democratic_People_s_Republic_of_Korea_the">http://aims.fao.org/aos/geopolitical.owl#Democratic_People_s_Republic_of_Korea_the</seealso>
    let Democratic_People_s_Republic_of_Korea_the =
        Prefixed_Name(geop, "Democratic_People_s_Republic_of_Korea_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Bangladesh</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bangladesh">http://aims.fao.org/aos/geopolitical.owl#Bangladesh</seealso>
    let Bangladesh = Prefixed_Name(geop, "Bangladesh") |> PrefixedName
    /// <summary>
    ///   <para>geop:Kyrgyzstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Kyrgyzstan">http://aims.fao.org/aos/geopolitical.owl#Kyrgyzstan</seealso>
    let Kyrgyzstan = Prefixed_Name(geop, "Kyrgyzstan") |> PrefixedName
    /// <summary>
    ///   <para>geop:isPredecessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#isPredecessorOf">http://aims.fao.org/aos/geopolitical.owl#isPredecessorOf</seealso>
    let isPredecessorOf = Prefixed_Name(geop, "isPredecessorOf") |> PrefixedName
    /// <summary>
    ///   <para>geop:Zaire</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Zaire">http://aims.fao.org/aos/geopolitical.owl#Zaire</seealso>
    let Zaire = Prefixed_Name(geop, "Zaire") |> PrefixedName
    /// <summary>
    ///   <para>geop:Democratic_Yemen</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Democratic_Yemen">http://aims.fao.org/aos/geopolitical.owl#Democratic_Yemen</seealso>
    let Democratic_Yemen = Prefixed_Name(geop, "Democratic_Yemen") |> PrefixedName
    /// <summary>
    ///   <para>geop:Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Denmark">http://aims.fao.org/aos/geopolitical.owl#Denmark</seealso>
    let Denmark = Prefixed_Name(geop, "Denmark") |> PrefixedName
    /// <summary>
    ///   <para>geop:northern_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#northern_Europe">http://aims.fao.org/aos/geopolitical.owl#northern_Europe</seealso>
    let northern_Europe = Prefixed_Name(geop, "northern_Europe") |> PrefixedName

    /// <summary>
    ///   <para>geop:Federal_Republic_of_Germany_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Federal_Republic_of_Germany_the">http://aims.fao.org/aos/geopolitical.owl#Federal_Republic_of_Germany_the</seealso>
    let Federal_Republic_of_Germany_the =
        Prefixed_Name(geop, "Federal_Republic_of_Germany_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Melanesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Melanesia">http://aims.fao.org/aos/geopolitical.owl#Melanesia</seealso>
    let Melanesia = Prefixed_Name(geop, "Melanesia") |> PrefixedName
    /// <summary>
    ///   <para>geop:French_Polynesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#French_Polynesia">http://aims.fao.org/aos/geopolitical.owl#French_Polynesia</seealso>
    let French_Polynesia = Prefixed_Name(geop, "French_Polynesia") |> PrefixedName
    /// <summary>
    ///   <para>geop:GDP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#GDP">http://aims.fao.org/aos/geopolitical.owl#GDP</seealso>
    let GDP = Prefixed_Name(geop, "GDP") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasStatistics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasStatistics">http://aims.fao.org/aos/geopolitical.owl#hasStatistics</seealso>
    let hasStatistics = Prefixed_Name(geop, "hasStatistics") |> PrefixedName
    /// <summary>
    ///   <para>geop:sourceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#sourceIdentifier">http://aims.fao.org/aos/geopolitical.owl#sourceIdentifier</seealso>
    let sourceIdentifier = Prefixed_Name(geop, "sourceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>geop:GDPNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#GDPNotes">http://aims.fao.org/aos/geopolitical.owl#GDPNotes</seealso>
    let GDPNotes = Prefixed_Name(geop, "GDPNotes") |> PrefixedName
    /// <summary>
    ///   <para>geop:GDPYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#GDPYear">http://aims.fao.org/aos/geopolitical.owl#GDPYear</seealso>
    let GDPYear = Prefixed_Name(geop, "GDPYear") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeUN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeUN">http://aims.fao.org/aos/geopolitical.owl#codeUN</seealso>
    let codeUN = Prefixed_Name(geop, "codeUN") |> PrefixedName
    /// <summary>
    ///   <para>geop:Latvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Latvia">http://aims.fao.org/aos/geopolitical.owl#Latvia</seealso>
    let Latvia = Prefixed_Name(geop, "Latvia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Afghanistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Afghanistan">http://aims.fao.org/aos/geopolitical.owl#Afghanistan</seealso>
    let Afghanistan = Prefixed_Name(geop, "Afghanistan") |> PrefixedName

    /// <summary>
    ///   <para>geop:agriculturalAreaTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaTotal">http://aims.fao.org/aos/geopolitical.owl#agriculturalAreaTotal</seealso>
    let agriculturalAreaTotal =
        Prefixed_Name(geop, "agriculturalAreaTotal") |> PrefixedName

    /// <summary>
    ///   <para>geop:codeDBPediaID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeDBPediaID">http://aims.fao.org/aos/geopolitical.owl#codeDBPediaID</seealso>
    let codeDBPediaID = Prefixed_Name(geop, "codeDBPediaID") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeISO3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeISO3">http://aims.fao.org/aos/geopolitical.owl#codeISO3</seealso>
    let codeISO3 = Prefixed_Name(geop, "codeISO3") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeUNDP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeUNDP">http://aims.fao.org/aos/geopolitical.owl#codeUNDP</seealso>
    let codeUNDP = Prefixed_Name(geop, "codeUNDP") |> PrefixedName
    /// <summary>
    ///   <para>geop:Luxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Luxembourg">http://aims.fao.org/aos/geopolitical.owl#Luxembourg</seealso>
    let Luxembourg = Prefixed_Name(geop, "Luxembourg") |> PrefixedName
    /// <summary>
    ///   <para>geop:countryAreaTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#countryAreaTotal">http://aims.fao.org/aos/geopolitical.owl#countryAreaTotal</seealso>
    let countryAreaTotal = Prefixed_Name(geop, "countryAreaTotal") |> PrefixedName
    /// <summary>
    ///   <para>geop:Uzbekistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Uzbekistan">http://aims.fao.org/aos/geopolitical.owl#Uzbekistan</seealso>
    let Uzbekistan = Prefixed_Name(geop, "Uzbekistan") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasMaxLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLongitude">http://aims.fao.org/aos/geopolitical.owl#hasMaxLongitude</seealso>
    let hasMaxLongitude = Prefixed_Name(geop, "hasMaxLongitude") |> PrefixedName
    /// <summary>
    ///   <para>geop:ECO</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#ECO">http://aims.fao.org/aos/geopolitical.owl#ECO</seealso>
    let ECO = Prefixed_Name(geop, "ECO") |> PrefixedName
    /// <summary>
    ///   <para>geop:LIFDC_2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2009">http://aims.fao.org/aos/geopolitical.owl#LIFDC_2009</seealso>
    let LIFDC_2009 = Prefixed_Name(geop, "LIFDC_2009") |> PrefixedName
    /// <summary>
    ///   <para>geop:non_self_governing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#non_self_governing">http://aims.fao.org/aos/geopolitical.owl#non_self_governing</seealso>
    let non_self_governing = Prefixed_Name(geop, "non_self_governing") |> PrefixedName
    /// <summary>
    ///   <para>geop:Americas</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Americas">http://aims.fao.org/aos/geopolitical.owl#Americas</seealso>
    let Americas = Prefixed_Name(geop, "Americas") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ecuador</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ecuador">http://aims.fao.org/aos/geopolitical.owl#Ecuador</seealso>
    let Ecuador = Prefixed_Name(geop, "Ecuador") |> PrefixedName

    /// <summary>
    ///   <para>geop:Dominican_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Dominican_Republic_the">http://aims.fao.org/aos/geopolitical.owl#Dominican_Republic_the</seealso>
    let Dominican_Republic_the =
        Prefixed_Name(geop, "Dominican_Republic_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Antigua_and_Barbuda</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Antigua_and_Barbuda">http://aims.fao.org/aos/geopolitical.owl#Antigua_and_Barbuda</seealso>
    let Antigua_and_Barbuda = Prefixed_Name(geop, "Antigua_and_Barbuda") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bolivia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bolivia">http://aims.fao.org/aos/geopolitical.owl#Bolivia</seealso>
    let Bolivia = Prefixed_Name(geop, "Bolivia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Jamaica</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Jamaica">http://aims.fao.org/aos/geopolitical.owl#Jamaica</seealso>
    let Jamaica = Prefixed_Name(geop, "Jamaica") |> PrefixedName
    /// <summary>
    ///   <para>geop:Belize</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Belize">http://aims.fao.org/aos/geopolitical.owl#Belize</seealso>
    let Belize = Prefixed_Name(geop, "Belize") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guatemala</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guatemala">http://aims.fao.org/aos/geopolitical.owl#Guatemala</seealso>
    let Guatemala = Prefixed_Name(geop, "Guatemala") |> PrefixedName
    /// <summary>
    ///   <para>geop:Suriname</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Suriname">http://aims.fao.org/aos/geopolitical.owl#Suriname</seealso>
    let Suriname = Prefixed_Name(geop, "Suriname") |> PrefixedName
    /// <summary>
    ///   <para>geop:Dominica</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Dominica">http://aims.fao.org/aos/geopolitical.owl#Dominica</seealso>
    let Dominica = Prefixed_Name(geop, "Dominica") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cuba</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cuba">http://aims.fao.org/aos/geopolitical.owl#Cuba</seealso>
    let Cuba = Prefixed_Name(geop, "Cuba") |> PrefixedName
    /// <summary>
    ///   <para>geop:Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Canada">http://aims.fao.org/aos/geopolitical.owl#Canada</seealso>
    let Canada = Prefixed_Name(geop, "Canada") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mexico">http://aims.fao.org/aos/geopolitical.owl#Mexico</seealso>
    let Mexico = Prefixed_Name(geop, "Mexico") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bermuda</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bermuda">http://aims.fao.org/aos/geopolitical.owl#Bermuda</seealso>
    let Bermuda = Prefixed_Name(geop, "Bermuda") |> PrefixedName
    /// <summary>
    ///   <para>geop:CAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CAN">http://aims.fao.org/aos/geopolitical.owl#CAN</seealso>
    let CAN = Prefixed_Name(geop, "CAN") |> PrefixedName

    /// <summary>
    ///   <para>geop:Bonaire_Sint_Eustatius_and_Saba</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bonaire_Sint_Eustatius_and_Saba">http://aims.fao.org/aos/geopolitical.owl#Bonaire_Sint_Eustatius_and_Saba</seealso>
    let Bonaire_Sint_Eustatius_and_Saba =
        Prefixed_Name(geop, "Bonaire_Sint_Eustatius_and_Saba") |> PrefixedName

    /// <summary>
    ///   <para>geop:Bosnia_and_Herzegovina</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bosnia_and_Herzegovina">http://aims.fao.org/aos/geopolitical.owl#Bosnia_and_Herzegovina</seealso>
    let Bosnia_and_Herzegovina =
        Prefixed_Name(geop, "Bosnia_and_Herzegovina") |> PrefixedName

    /// <summary>
    ///   <para>geop:Croatia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Croatia">http://aims.fao.org/aos/geopolitical.owl#Croatia</seealso>
    let Croatia = Prefixed_Name(geop, "Croatia") |> PrefixedName

    /// <summary>
    ///   <para>geop:Socialist_Federal_Republic_of_Yugoslavia_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Socialist_Federal_Republic_of_Yugoslavia_the">http://aims.fao.org/aos/geopolitical.owl#Socialist_Federal_Republic_of_Yugoslavia_the</seealso>
    let Socialist_Federal_Republic_of_Yugoslavia_the =
        Prefixed_Name(geop, "Socialist_Federal_Republic_of_Yugoslavia_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Puerto_Rico</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Puerto_Rico">http://aims.fao.org/aos/geopolitical.owl#Puerto_Rico</seealso>
    let Puerto_Rico = Prefixed_Name(geop, "Puerto_Rico") |> PrefixedName
    /// <summary>
    ///   <para>geop:countryAreaNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#countryAreaNotes">http://aims.fao.org/aos/geopolitical.owl#countryAreaNotes</seealso>
    let countryAreaNotes = Prefixed_Name(geop, "countryAreaNotes") |> PrefixedName
    /// <summary>
    ///   <para>geop:countryAreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#countryAreaUnit">http://aims.fao.org/aos/geopolitical.owl#countryAreaUnit</seealso>
    let countryAreaUnit = Prefixed_Name(geop, "countryAreaUnit") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasBorderWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasBorderWith">http://aims.fao.org/aos/geopolitical.owl#hasBorderWith</seealso>
    let hasBorderWith = Prefixed_Name(geop, "hasBorderWith") |> PrefixedName
    /// <summary>
    ///   <para>geop:Tajikistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Tajikistan">http://aims.fao.org/aos/geopolitical.owl#Tajikistan</seealso>
    let Tajikistan = Prefixed_Name(geop, "Tajikistan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Turkmenistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Turkmenistan">http://aims.fao.org/aos/geopolitical.owl#Turkmenistan</seealso>
    let Turkmenistan = Prefixed_Name(geop, "Turkmenistan") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasMaxLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasMaxLatitude">http://aims.fao.org/aos/geopolitical.owl#hasMaxLatitude</seealso>
    let hasMaxLatitude = Prefixed_Name(geop, "hasMaxLatitude") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasMinLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasMinLatitude">http://aims.fao.org/aos/geopolitical.owl#hasMinLatitude</seealso>
    let hasMinLatitude = Prefixed_Name(geop, "hasMinLatitude") |> PrefixedName
    /// <summary>
    ///   <para>geop:LLDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LLDC">http://aims.fao.org/aos/geopolitical.owl#LLDC</seealso>
    let LLDC = Prefixed_Name(geop, "LLDC") |> PrefixedName
    /// <summary>
    ///   <para>geop:FAO_2006</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:organization</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#FAO_2006">http://aims.fao.org/aos/geopolitical.owl#FAO_2006</seealso>
    let FAO_2006 = Prefixed_Name(geop, "FAO_2006") |> PrefixedName
    /// <summary>
    ///   <para>geop:LDC_1993</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LDC_1993">http://aims.fao.org/aos/geopolitical.owl#LDC_1993</seealso>
    let LDC_1993 = Prefixed_Name(geop, "LDC_1993") |> PrefixedName
    /// <summary>
    ///   <para>geop:LIFDC_2008</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2008">http://aims.fao.org/aos/geopolitical.owl#LIFDC_2008</seealso>
    let LIFDC_2008 = Prefixed_Name(geop, "LIFDC_2008") |> PrefixedName
    /// <summary>
    ///   <para>geop:World</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#World">http://aims.fao.org/aos/geopolitical.owl#World</seealso>
    let World = Prefixed_Name(geop, "World") |> PrefixedName
    /// <summary>
    ///   <para>geop:SAARC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#SAARC">http://aims.fao.org/aos/geopolitical.owl#SAARC</seealso>
    let SAARC = Prefixed_Name(geop, "SAARC") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyAR">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyAR</seealso>
    let nameCurrencyAR = Prefixed_Name(geop, "nameCurrencyAR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyES">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyES</seealso>
    let nameCurrencyES = Prefixed_Name(geop, "nameCurrencyES") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyZH">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyZH</seealso>
    let nameCurrencyZH = Prefixed_Name(geop, "nameCurrencyZH") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListZH">http://aims.fao.org/aos/geopolitical.owl#nameListZH</seealso>
    let nameListZH = Prefixed_Name(geop, "nameListZH") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortAR">http://aims.fao.org/aos/geopolitical.owl#nameShortAR</seealso>
    let nameShortAR = Prefixed_Name(geop, "nameShortAR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityAR">http://aims.fao.org/aos/geopolitical.owl#nationalityAR</seealso>
    let nationalityAR = Prefixed_Name(geop, "nationalityAR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityEN">http://aims.fao.org/aos/geopolitical.owl#nationalityEN</seealso>
    let nationalityEN = Prefixed_Name(geop, "nationalityEN") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityIT">http://aims.fao.org/aos/geopolitical.owl#nationalityIT</seealso>
    let nationalityIT = Prefixed_Name(geop, "nationalityIT") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityRU">http://aims.fao.org/aos/geopolitical.owl#nationalityRU</seealso>
    let nationalityRU = Prefixed_Name(geop, "nationalityRU") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityZH">http://aims.fao.org/aos/geopolitical.owl#nationalityZH</seealso>
    let nationalityZH = Prefixed_Name(geop, "nationalityZH") |> PrefixedName
    /// <summary>
    ///   <para>geop:CCASG</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CCASG">http://aims.fao.org/aos/geopolitical.owl#CCASG</seealso>
    let CCASG = Prefixed_Name(geop, "CCASG") |> PrefixedName
    /// <summary>
    ///   <para>geop:countryAreaYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#countryAreaYear">http://aims.fao.org/aos/geopolitical.owl#countryAreaYear</seealso>
    let countryAreaYear = Prefixed_Name(geop, "countryAreaYear") |> PrefixedName
    /// <summary>
    ///   <para>geop:Pakistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Pakistan">http://aims.fao.org/aos/geopolitical.owl#Pakistan</seealso>
    let Pakistan = Prefixed_Name(geop, "Pakistan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Jordan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Jordan">http://aims.fao.org/aos/geopolitical.owl#Jordan</seealso>
    let Jordan = Prefixed_Name(geop, "Jordan") |> PrefixedName

    /// <summary>
    ///   <para>geop:Lao_People_s_Democratic_Republic__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Lao_People_s_Democratic_Republic__the">http://aims.fao.org/aos/geopolitical.owl#Lao_People_s_Democratic_Republic__the</seealso>
    let Lao_People_s_Democratic_Republic__the =
        Prefixed_Name(geop, "Lao_People_s_Democratic_Republic__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Thailand</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Thailand">http://aims.fao.org/aos/geopolitical.owl#Thailand</seealso>
    let Thailand = Prefixed_Name(geop, "Thailand") |> PrefixedName

    /// <summary>
    ///   <para>geop:Iran_Islamic_Rep_of_</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Iran_Islamic_Rep_of_">http://aims.fao.org/aos/geopolitical.owl#Iran_Islamic_Rep_of_</seealso>
    let Iran_Islamic_Rep_of_ =
        Prefixed_Name(geop, "Iran_Islamic_Rep_of_") |> PrefixedName

    /// <summary>
    ///   <para>geop:hasMinLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasMinLongitude">http://aims.fao.org/aos/geopolitical.owl#hasMinLongitude</seealso>
    let hasMinLongitude = Prefixed_Name(geop, "hasMinLongitude") |> PrefixedName
    /// <summary>
    ///   <para>geop:LDC_2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LDC_2010">http://aims.fao.org/aos/geopolitical.owl#LDC_2010</seealso>
    let LDC_2010 = Prefixed_Name(geop, "LDC_2010") |> PrefixedName
    /// <summary>
    ///   <para>geop:southern_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#southern_Asia">http://aims.fao.org/aos/geopolitical.owl#southern_Asia</seealso>
    let southern_Asia = Prefixed_Name(geop, "southern_Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:LIFDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LIFDC">http://aims.fao.org/aos/geopolitical.owl#LIFDC</seealso>
    let LIFDC = Prefixed_Name(geop, "LIFDC") |> PrefixedName
    /// <summary>
    ///   <para>geop:landAreaYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#landAreaYear">http://aims.fao.org/aos/geopolitical.owl#landAreaYear</seealso>
    let landAreaYear = Prefixed_Name(geop, "landAreaYear") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyFR">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyFR</seealso>
    let nameCurrencyFR = Prefixed_Name(geop, "nameCurrencyFR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyIT">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyIT</seealso>
    let nameCurrencyIT = Prefixed_Name(geop, "nameCurrencyIT") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListRU">http://aims.fao.org/aos/geopolitical.owl#nameListRU</seealso>
    let nameListRU = Prefixed_Name(geop, "nameListRU") |> PrefixedName
    /// <summary>
    ///   <para>geop:Honduras</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Honduras">http://aims.fao.org/aos/geopolitical.owl#Honduras</seealso>
    let Honduras = Prefixed_Name(geop, "Honduras") |> PrefixedName
    /// <summary>
    ///   <para>geop:Chile</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Chile">http://aims.fao.org/aos/geopolitical.owl#Chile</seealso>
    let Chile = Prefixed_Name(geop, "Chile") |> PrefixedName
    /// <summary>
    ///   <para>geop:Paraguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Paraguay">http://aims.fao.org/aos/geopolitical.owl#Paraguay</seealso>
    let Paraguay = Prefixed_Name(geop, "Paraguay") |> PrefixedName
    /// <summary>
    ///   <para>geop:Grenada</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Grenada">http://aims.fao.org/aos/geopolitical.owl#Grenada</seealso>
    let Grenada = Prefixed_Name(geop, "Grenada") |> PrefixedName
    /// <summary>
    ///   <para>geop:Barbados</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Barbados">http://aims.fao.org/aos/geopolitical.owl#Barbados</seealso>
    let Barbados = Prefixed_Name(geop, "Barbados") |> PrefixedName

    /// <summary>
    ///   <para>geop:Saint_Vincent_and_the_Grenadines</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Vincent_and_the_Grenadines">http://aims.fao.org/aos/geopolitical.owl#Saint_Vincent_and_the_Grenadines</seealso>
    let Saint_Vincent_and_the_Grenadines =
        Prefixed_Name(geop, "Saint_Vincent_and_the_Grenadines") |> PrefixedName

    /// <summary>
    ///   <para>geop:Panama</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Panama">http://aims.fao.org/aos/geopolitical.owl#Panama</seealso>
    let Panama = Prefixed_Name(geop, "Panama") |> PrefixedName
    /// <summary>
    ///   <para>geop:Nicaragua</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Nicaragua">http://aims.fao.org/aos/geopolitical.owl#Nicaragua</seealso>
    let Nicaragua = Prefixed_Name(geop, "Nicaragua") |> PrefixedName
    /// <summary>
    ///   <para>geop:Colombia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Colombia">http://aims.fao.org/aos/geopolitical.owl#Colombia</seealso>
    let Colombia = Prefixed_Name(geop, "Colombia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Peru</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Peru">http://aims.fao.org/aos/geopolitical.owl#Peru</seealso>
    let Peru = Prefixed_Name(geop, "Peru") |> PrefixedName
    /// <summary>
    ///   <para>geop:Trinidad_and_Tobago</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Trinidad_and_Tobago">http://aims.fao.org/aos/geopolitical.owl#Trinidad_and_Tobago</seealso>
    let Trinidad_and_Tobago = Prefixed_Name(geop, "Trinidad_and_Tobago") |> PrefixedName
    /// <summary>
    ///   <para>geop:El_Salvador</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#El_Salvador">http://aims.fao.org/aos/geopolitical.owl#El_Salvador</seealso>
    let El_Salvador = Prefixed_Name(geop, "El_Salvador") |> PrefixedName
    /// <summary>
    ///   <para>geop:western_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#western_Europe">http://aims.fao.org/aos/geopolitical.owl#western_Europe</seealso>
    let western_Europe = Prefixed_Name(geop, "western_Europe") |> PrefixedName

    /// <summary>
    ///   <para>geop:Russian_Federation__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Russian_Federation__the">http://aims.fao.org/aos/geopolitical.owl#Russian_Federation__the</seealso>
    let Russian_Federation__the =
        Prefixed_Name(geop, "Russian_Federation__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Yugoslavia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Yugoslavia">http://aims.fao.org/aos/geopolitical.owl#Yugoslavia</seealso>
    let Yugoslavia = Prefixed_Name(geop, "Yugoslavia") |> PrefixedName
    /// <summary>
    ///   <para>geop:China</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#China">http://aims.fao.org/aos/geopolitical.owl#China</seealso>
    let China = Prefixed_Name(geop, "China") |> PrefixedName
    /// <summary>
    ///   <para>geop:isInGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#isInGroup">http://aims.fao.org/aos/geopolitical.owl#isInGroup</seealso>
    let isInGroup = Prefixed_Name(geop, "isInGroup") |> PrefixedName
    /// <summary>
    ///   <para>geop:FAO</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:organization</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#FAO">http://aims.fao.org/aos/geopolitical.owl#FAO</seealso>
    let FAO = Prefixed_Name(geop, "FAO") |> PrefixedName
    /// <summary>
    ///   <para>geop:LIFDC_2005</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2005">http://aims.fao.org/aos/geopolitical.owl#LIFDC_2005</seealso>
    let LIFDC_2005 = Prefixed_Name(geop, "LIFDC_2005") |> PrefixedName

    /// <summary>
    ///   <para>geop:Republic_of_Korea__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Republic_of_Korea__the">http://aims.fao.org/aos/geopolitical.owl#Republic_of_Korea__the</seealso>
    let Republic_of_Korea__the =
        Prefixed_Name(geop, "Republic_of_Korea__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Japan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Japan">http://aims.fao.org/aos/geopolitical.owl#Japan</seealso>
    let Japan = Prefixed_Name(geop, "Japan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Czechoslovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Czechoslovakia">http://aims.fao.org/aos/geopolitical.owl#Czechoslovakia</seealso>
    let Czechoslovakia = Prefixed_Name(geop, "Czechoslovakia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Kiribati</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Kiribati">http://aims.fao.org/aos/geopolitical.owl#Kiribati</seealso>
    let Kiribati = Prefixed_Name(geop, "Kiribati") |> PrefixedName
    /// <summary>
    ///   <para>geop:Samoa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Samoa">http://aims.fao.org/aos/geopolitical.owl#Samoa</seealso>
    let Samoa = Prefixed_Name(geop, "Samoa") |> PrefixedName
    /// <summary>
    ///   <para>geop:Palau</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Palau">http://aims.fao.org/aos/geopolitical.owl#Palau</seealso>
    let Palau = Prefixed_Name(geop, "Palau") |> PrefixedName
    /// <summary>
    ///   <para>geop:Tokelau</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    ///   <para>associate member of FAO</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Tokelau">http://aims.fao.org/aos/geopolitical.owl#Tokelau</seealso>
    let Tokelau = Prefixed_Name(geop, "Tokelau") |> PrefixedName

    /// <summary>
    ///   <para>geop:Micronesia__Fed_States_of_</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Micronesia__Fed_States_of_">http://aims.fao.org/aos/geopolitical.owl#Micronesia__Fed_States_of_</seealso>
    let Micronesia__Fed_States_of_ =
        Prefixed_Name(geop, "Micronesia__Fed_States_of_") |> PrefixedName

    /// <summary>
    ///   <para>geop:Tuvalu</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Tuvalu">http://aims.fao.org/aos/geopolitical.owl#Tuvalu</seealso>
    let Tuvalu = Prefixed_Name(geop, "Tuvalu") |> PrefixedName
    /// <summary>
    ///   <para>geop:Solomon_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Solomon_Islands">http://aims.fao.org/aos/geopolitical.owl#Solomon_Islands</seealso>
    let Solomon_Islands = Prefixed_Name(geop, "Solomon_Islands") |> PrefixedName
    /// <summary>
    ///   <para>geop:Vanuatu</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Vanuatu">http://aims.fao.org/aos/geopolitical.owl#Vanuatu</seealso>
    let Vanuatu = Prefixed_Name(geop, "Vanuatu") |> PrefixedName
    /// <summary>
    ///   <para>geop:Papua_New_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Papua_New_Guinea">http://aims.fao.org/aos/geopolitical.owl#Papua_New_Guinea</seealso>
    let Papua_New_Guinea = Prefixed_Name(geop, "Papua_New_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>geop:Niue</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Niue">http://aims.fao.org/aos/geopolitical.owl#Niue</seealso>
    let Niue = Prefixed_Name(geop, "Niue") |> PrefixedName

    /// <summary>
    ///   <para>geop:Marshall_Islands__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Marshall_Islands__the">http://aims.fao.org/aos/geopolitical.owl#Marshall_Islands__the</seealso>
    let Marshall_Islands__the =
        Prefixed_Name(geop, "Marshall_Islands__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#organization">http://aims.fao.org/aos/geopolitical.owl#organization</seealso>
    let organization = Prefixed_Name(geop, "organization") |> PrefixedName
    /// <summary>
    ///   <para>geop:Falkland_Is</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Falkland_Is">http://aims.fao.org/aos/geopolitical.owl#Falkland_Is</seealso>
    let Falkland_Is = Prefixed_Name(geop, "Falkland_Is") |> PrefixedName

    /// <summary>
    ///   <para>geop:Saint_Pierre_and_Miquelon</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Pierre_and_Miquelon">http://aims.fao.org/aos/geopolitical.owl#Saint_Pierre_and_Miquelon</seealso>
    let Saint_Pierre_and_Miquelon =
        Prefixed_Name(geop, "Saint_Pierre_and_Miquelon") |> PrefixedName

    /// <summary>
    ///   <para>geop:agriculturalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#agriculturalArea">http://aims.fao.org/aos/geopolitical.owl#agriculturalArea</seealso>
    let agriculturalArea = Prefixed_Name(geop, "agriculturalArea") |> PrefixedName
    /// <summary>
    ///   <para>geop:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#area">http://aims.fao.org/aos/geopolitical.owl#area</seealso>
    let area = Prefixed_Name(geop, "area") |> PrefixedName
    /// <summary>
    ///   <para>geop:Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Asia">http://aims.fao.org/aos/geopolitical.owl#Asia</seealso>
    let Asia = Prefixed_Name(geop, "Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:LIFDC_2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LIFDC_2010">http://aims.fao.org/aos/geopolitical.owl#LIFDC_2010</seealso>
    let LIFDC_2010 = Prefixed_Name(geop, "LIFDC_2010") |> PrefixedName
    /// <summary>
    ///   <para>geop:landAreaTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#landAreaTotal">http://aims.fao.org/aos/geopolitical.owl#landAreaTotal</seealso>
    let landAreaTotal = Prefixed_Name(geop, "landAreaTotal") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyRU">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyRU</seealso>
    let nameCurrencyRU = Prefixed_Name(geop, "nameCurrencyRU") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListIT">http://aims.fao.org/aos/geopolitical.owl#nameListIT</seealso>
    let nameListIT = Prefixed_Name(geop, "nameListIT") |> PrefixedName
    /// <summary>
    ///   <para>geop:Haiti</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Haiti">http://aims.fao.org/aos/geopolitical.owl#Haiti</seealso>
    let Haiti = Prefixed_Name(geop, "Haiti") |> PrefixedName

    /// <summary>
    ///   <para>geop:Saint_Kitts_and_Nevis</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Kitts_and_Nevis">http://aims.fao.org/aos/geopolitical.owl#Saint_Kitts_and_Nevis</seealso>
    let Saint_Kitts_and_Nevis =
        Prefixed_Name(geop, "Saint_Kitts_and_Nevis") |> PrefixedName

    /// <summary>
    ///   <para>geop:Saint_Lucia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saint_Lucia">http://aims.fao.org/aos/geopolitical.owl#Saint_Lucia</seealso>
    let Saint_Lucia = Prefixed_Name(geop, "Saint_Lucia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guyana</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guyana">http://aims.fao.org/aos/geopolitical.owl#Guyana</seealso>
    let Guyana = Prefixed_Name(geop, "Guyana") |> PrefixedName
    /// <summary>
    ///   <para>geop:Costa_Rica</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Costa_Rica">http://aims.fao.org/aos/geopolitical.owl#Costa_Rica</seealso>
    let Costa_Rica = Prefixed_Name(geop, "Costa_Rica") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bahamas_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bahamas_the">http://aims.fao.org/aos/geopolitical.owl#Bahamas_the</seealso>
    let Bahamas_the = Prefixed_Name(geop, "Bahamas_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Tonga</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Tonga">http://aims.fao.org/aos/geopolitical.owl#Tonga</seealso>
    let Tonga = Prefixed_Name(geop, "Tonga") |> PrefixedName
    /// <summary>
    ///   <para>geop:Fiji</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Fiji">http://aims.fao.org/aos/geopolitical.owl#Fiji</seealso>
    let Fiji = Prefixed_Name(geop, "Fiji") |> PrefixedName
    /// <summary>
    ///   <para>geop:LDC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#LDC">http://aims.fao.org/aos/geopolitical.owl#LDC</seealso>
    let LDC = Prefixed_Name(geop, "LDC") |> PrefixedName
    /// <summary>
    ///   <para>geop:landAreaNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#landAreaNotes">http://aims.fao.org/aos/geopolitical.owl#landAreaNotes</seealso>
    let landAreaNotes = Prefixed_Name(geop, "landAreaNotes") |> PrefixedName
    /// <summary>
    ///   <para>geop:landAreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#landAreaUnit">http://aims.fao.org/aos/geopolitical.owl#landAreaUnit</seealso>
    let landAreaUnit = Prefixed_Name(geop, "landAreaUnit") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialIT">http://aims.fao.org/aos/geopolitical.owl#nameOfficialIT</seealso>
    let nameOfficialIT = Prefixed_Name(geop, "nameOfficialIT") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortIT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortIT">http://aims.fao.org/aos/geopolitical.owl#nameShortIT</seealso>
    let nameShortIT = Prefixed_Name(geop, "nameShortIT") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortRU">http://aims.fao.org/aos/geopolitical.owl#nameShortRU</seealso>
    let nameShortRU = Prefixed_Name(geop, "nameShortRU") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityFR">http://aims.fao.org/aos/geopolitical.owl#nationalityFR</seealso>
    let nationalityFR = Prefixed_Name(geop, "nationalityFR") |> PrefixedName
    /// <summary>
    ///   <para>geop:populationNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#populationNotes">http://aims.fao.org/aos/geopolitical.owl#populationNotes</seealso>
    let populationNotes = Prefixed_Name(geop, "populationNotes") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameCurrencyEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameCurrencyEN">http://aims.fao.org/aos/geopolitical.owl#nameCurrencyEN</seealso>
    let nameCurrencyEN = Prefixed_Name(geop, "nameCurrencyEN") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListAR">http://aims.fao.org/aos/geopolitical.owl#nameListAR</seealso>
    let nameListAR = Prefixed_Name(geop, "nameListAR") |> PrefixedName
    /// <summary>
    ///   <para>geop:CEMAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CEMAC">http://aims.fao.org/aos/geopolitical.owl#CEMAC</seealso>
    let CEMAC = Prefixed_Name(geop, "CEMAC") |> PrefixedName

    /// <summary>
    ///   <para>geop:Libyan_Arab_Jamahiriya__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Libyan_Arab_Jamahiriya__the">http://aims.fao.org/aos/geopolitical.owl#Libyan_Arab_Jamahiriya__the</seealso>
    let Libyan_Arab_Jamahiriya__the =
        Prefixed_Name(geop, "Libyan_Arab_Jamahiriya__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:PTA</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#PTA">http://aims.fao.org/aos/geopolitical.owl#PTA</seealso>
    let PTA = Prefixed_Name(geop, "PTA") |> PrefixedName
    /// <summary>
    ///   <para>geop:northern_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#northern_America">http://aims.fao.org/aos/geopolitical.owl#northern_America</seealso>
    let northern_America = Prefixed_Name(geop, "northern_America") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cayman_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cayman_Islands">http://aims.fao.org/aos/geopolitical.owl#Cayman_Islands</seealso>
    let Cayman_Islands = Prefixed_Name(geop, "Cayman_Islands") |> PrefixedName
    /// <summary>
    ///   <para>geop:eastern_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#eastern_Asia">http://aims.fao.org/aos/geopolitical.owl#eastern_Asia</seealso>
    let eastern_Asia = Prefixed_Name(geop, "eastern_Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cook_Islands_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cook_Islands_the">http://aims.fao.org/aos/geopolitical.owl#Cook_Islands_the</seealso>
    let Cook_Islands_the = Prefixed_Name(geop, "Cook_Islands_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:PIF_1985</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#PIF_1985">http://aims.fao.org/aos/geopolitical.owl#PIF_1985</seealso>
    let PIF_1985 = Prefixed_Name(geop, "PIF_1985") |> PrefixedName
    /// <summary>
    ///   <para>geop:Polynesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Polynesia">http://aims.fao.org/aos/geopolitical.owl#Polynesia</seealso>
    let Polynesia = Prefixed_Name(geop, "Polynesia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Curacao</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Curacao">http://aims.fao.org/aos/geopolitical.owl#Curacao</seealso>
    let Curacao = Prefixed_Name(geop, "Curacao") |> PrefixedName
    /// <summary>
    ///   <para>geop:Reunion</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Reunion">http://aims.fao.org/aos/geopolitical.owl#Reunion</seealso>
    let Reunion = Prefixed_Name(geop, "Reunion") |> PrefixedName
    /// <summary>
    ///   <para>geop:population</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#population">http://aims.fao.org/aos/geopolitical.owl#population</seealso>
    let population = Prefixed_Name(geop, "population") |> PrefixedName
    /// <summary>
    ///   <para>geop:Venezuela</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Venezuela">http://aims.fao.org/aos/geopolitical.owl#Venezuela</seealso>
    let Venezuela = Prefixed_Name(geop, "Venezuela") |> PrefixedName
    /// <summary>
    ///   <para>geop:Brazil</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Brazil">http://aims.fao.org/aos/geopolitical.owl#Brazil</seealso>
    let Brazil = Prefixed_Name(geop, "Brazil") |> PrefixedName
    /// <summary>
    ///   <para>geop:Uruguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Uruguay">http://aims.fao.org/aos/geopolitical.owl#Uruguay</seealso>
    let Uruguay = Prefixed_Name(geop, "Uruguay") |> PrefixedName
    /// <summary>
    ///   <para>geop:Argentina</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Argentina">http://aims.fao.org/aos/geopolitical.owl#Argentina</seealso>
    let Argentina = Prefixed_Name(geop, "Argentina") |> PrefixedName
    /// <summary>
    ///   <para>geop:EU</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#EU">http://aims.fao.org/aos/geopolitical.owl#EU</seealso>
    let EU = Prefixed_Name(geop, "EU") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameShortZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameShortZH">http://aims.fao.org/aos/geopolitical.owl#nameShortZH</seealso>
    let nameShortZH = Prefixed_Name(geop, "nameShortZH") |> PrefixedName
    /// <summary>
    ///   <para>geop:populationUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#populationUnit">http://aims.fao.org/aos/geopolitical.owl#populationUnit</seealso>
    let populationUnit = Prefixed_Name(geop, "populationUnit") |> PrefixedName
    /// <summary>
    ///   <para>geop:self_governing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#self_governing">http://aims.fao.org/aos/geopolitical.owl#self_governing</seealso>
    let self_governing = Prefixed_Name(geop, "self_governing") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cote_d_Ivoire</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cote_d_Ivoire">http://aims.fao.org/aos/geopolitical.owl#Cote_d_Ivoire</seealso>
    let Cote_d_Ivoire = Prefixed_Name(geop, "Cote_d_Ivoire") |> PrefixedName
    /// <summary>
    ///   <para>geop:Malawi</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Malawi">http://aims.fao.org/aos/geopolitical.owl#Malawi</seealso>
    let Malawi = Prefixed_Name(geop, "Malawi") |> PrefixedName
    /// <summary>
    ///   <para>geop:nationalityES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nationalityES">http://aims.fao.org/aos/geopolitical.owl#nationalityES</seealso>
    let nationalityES = Prefixed_Name(geop, "nationalityES") |> PrefixedName
    /// <summary>
    ///   <para>geop:populationTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#populationTotal">http://aims.fao.org/aos/geopolitical.owl#populationTotal</seealso>
    let populationTotal = Prefixed_Name(geop, "populationTotal") |> PrefixedName
    /// <summary>
    ///   <para>geop:populationYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#populationYear">http://aims.fao.org/aos/geopolitical.owl#populationYear</seealso>
    let populationYear = Prefixed_Name(geop, "populationYear") |> PrefixedName
    /// <summary>
    ///   <para>geop:Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Africa">http://aims.fao.org/aos/geopolitical.owl#Africa</seealso>
    let Africa = Prefixed_Name(geop, "Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:France</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#France">http://aims.fao.org/aos/geopolitical.owl#France</seealso>
    let France = Prefixed_Name(geop, "France") |> PrefixedName
    /// <summary>
    ///   <para>geop:Sudan_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the">http://aims.fao.org/aos/geopolitical.owl#Sudan_the</seealso>
    let Sudan_the = Prefixed_Name(geop, "Sudan_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guinea">http://aims.fao.org/aos/geopolitical.owl#Guinea</seealso>
    let Guinea = Prefixed_Name(geop, "Guinea") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ghana</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ghana">http://aims.fao.org/aos/geopolitical.owl#Ghana</seealso>
    let Ghana = Prefixed_Name(geop, "Ghana") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasCode">http://aims.fao.org/aos/geopolitical.owl#hasCode</seealso>
    let hasCode = Prefixed_Name(geop, "hasCode") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasCurrency">http://aims.fao.org/aos/geopolitical.owl#hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(geop, "hasCurrency") |> PrefixedName
    /// <summary>
    ///   <para>geop:countryArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#countryArea">http://aims.fao.org/aos/geopolitical.owl#countryArea</seealso>
    let countryArea = Prefixed_Name(geop, "countryArea") |> PrefixedName
    /// <summary>
    ///   <para>geop:disputed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#disputed">http://aims.fao.org/aos/geopolitical.owl#disputed</seealso>
    let disputed = Prefixed_Name(geop, "disputed") |> PrefixedName
    /// <summary>
    ///   <para>geop:territory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#territory">http://aims.fao.org/aos/geopolitical.owl#territory</seealso>
    let territory = Prefixed_Name(geop, "territory") |> PrefixedName
    /// <summary>
    ///   <para>geop:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#group">http://aims.fao.org/aos/geopolitical.owl#group</seealso>
    let group = Prefixed_Name(geop, "group") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasCoordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasCoordinate">http://aims.fao.org/aos/geopolitical.owl#hasCoordinate</seealso>
    let hasCoordinate = Prefixed_Name(geop, "hasCoordinate") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasListName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasListName">http://aims.fao.org/aos/geopolitical.owl#hasListName</seealso>
    let hasListName = Prefixed_Name(geop, "hasListName") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasNationality">http://aims.fao.org/aos/geopolitical.owl#hasNationality</seealso>
    let hasNationality = Prefixed_Name(geop, "hasNationality") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasOfficialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasOfficialName">http://aims.fao.org/aos/geopolitical.owl#hasOfficialName</seealso>
    let hasOfficialName = Prefixed_Name(geop, "hasOfficialName") |> PrefixedName
    /// <summary>
    ///   <para>geop:hasShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#hasShortName">http://aims.fao.org/aos/geopolitical.owl#hasShortName</seealso>
    let hasShortName = Prefixed_Name(geop, "hasShortName") |> PrefixedName
    /// <summary>
    ///   <para>geop:landArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#landArea">http://aims.fao.org/aos/geopolitical.owl#landArea</seealso>
    let landArea = Prefixed_Name(geop, "landArea") |> PrefixedName
    /// <summary>
    ///   <para>geop:Chad</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Chad">http://aims.fao.org/aos/geopolitical.owl#Chad</seealso>
    let Chad = Prefixed_Name(geop, "Chad") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ethiopia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ethiopia">http://aims.fao.org/aos/geopolitical.owl#Ethiopia</seealso>
    let Ethiopia = Prefixed_Name(geop, "Ethiopia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Burundi</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Burundi">http://aims.fao.org/aos/geopolitical.owl#Burundi</seealso>
    let Burundi = Prefixed_Name(geop, "Burundi") |> PrefixedName
    /// <summary>
    ///   <para>geop:Djibouti</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Djibouti">http://aims.fao.org/aos/geopolitical.owl#Djibouti</seealso>
    let Djibouti = Prefixed_Name(geop, "Djibouti") |> PrefixedName
    /// <summary>
    ///   <para>geop:Egypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Egypt">http://aims.fao.org/aos/geopolitical.owl#Egypt</seealso>
    let Egypt = Prefixed_Name(geop, "Egypt") |> PrefixedName
    /// <summary>
    ///   <para>geop:Comoros_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Comoros_the">http://aims.fao.org/aos/geopolitical.owl#Comoros_the</seealso>
    let Comoros_the = Prefixed_Name(geop, "Comoros_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:United_Republic_of_Tanzania__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#United_Republic_of_Tanzania__the">http://aims.fao.org/aos/geopolitical.owl#United_Republic_of_Tanzania__the</seealso>
    let United_Republic_of_Tanzania__the =
        Prefixed_Name(geop, "United_Republic_of_Tanzania__the") |> PrefixedName

    /// <summary>
    ///   <para>geop:geographical_region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#geographical_region">http://aims.fao.org/aos/geopolitical.owl#geographical_region</seealso>
    let geographical_region = Prefixed_Name(geop, "geographical_region") |> PrefixedName
    /// <summary>
    ///   <para>geop:Serbia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Serbia">http://aims.fao.org/aos/geopolitical.owl#Serbia</seealso>
    let Serbia = Prefixed_Name(geop, "Serbia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Greece">http://aims.fao.org/aos/geopolitical.owl#Greece</seealso>
    let Greece = Prefixed_Name(geop, "Greece") |> PrefixedName

    /// <summary>
    ///   <para>geop:The_former_Yugoslav_Republic_of_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#The_former_Yugoslav_Republic_of_Macedonia">http://aims.fao.org/aos/geopolitical.owl#The_former_Yugoslav_Republic_of_Macedonia</seealso>
    let The_former_Yugoslav_Republic_of_Macedonia =
        Prefixed_Name(geop, "The_former_Yugoslav_Republic_of_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>geop:southern_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#southern_Europe">http://aims.fao.org/aos/geopolitical.owl#southern_Europe</seealso>
    let southern_Europe = Prefixed_Name(geop, "southern_Europe") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bahrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bahrain">http://aims.fao.org/aos/geopolitical.owl#Bahrain</seealso>
    let Bahrain = Prefixed_Name(geop, "Bahrain") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mongolia">http://aims.fao.org/aos/geopolitical.owl#Mongolia</seealso>
    let Mongolia = Prefixed_Name(geop, "Mongolia") |> PrefixedName

    /// <summary>
    ///   <para>geop:Syrian_Arab_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Syrian_Arab_Republic_the">http://aims.fao.org/aos/geopolitical.owl#Syrian_Arab_Republic_the</seealso>
    let Syrian_Arab_Republic_the =
        Prefixed_Name(geop, "Syrian_Arab_Republic_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Iraq</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Iraq">http://aims.fao.org/aos/geopolitical.owl#Iraq</seealso>
    let Iraq = Prefixed_Name(geop, "Iraq") |> PrefixedName
    /// <summary>
    ///   <para>geop:Maldives</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Maldives">http://aims.fao.org/aos/geopolitical.owl#Maldives</seealso>
    let Maldives = Prefixed_Name(geop, "Maldives") |> PrefixedName
    /// <summary>
    ///   <para>geop:India</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#India">http://aims.fao.org/aos/geopolitical.owl#India</seealso>
    let India = Prefixed_Name(geop, "India") |> PrefixedName
    /// <summary>
    ///   <para>geop:Indonesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Indonesia">http://aims.fao.org/aos/geopolitical.owl#Indonesia</seealso>
    let Indonesia = Prefixed_Name(geop, "Indonesia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Malaysia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Malaysia">http://aims.fao.org/aos/geopolitical.owl#Malaysia</seealso>
    let Malaysia = Prefixed_Name(geop, "Malaysia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Brunei_Darussalam</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Brunei_Darussalam">http://aims.fao.org/aos/geopolitical.owl#Brunei_Darussalam</seealso>
    let Brunei_Darussalam = Prefixed_Name(geop, "Brunei_Darussalam") |> PrefixedName
    /// <summary>
    ///   <para>geop:Lebanon</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Lebanon">http://aims.fao.org/aos/geopolitical.owl#Lebanon</seealso>
    let Lebanon = Prefixed_Name(geop, "Lebanon") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bhutan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bhutan">http://aims.fao.org/aos/geopolitical.owl#Bhutan</seealso>
    let Bhutan = Prefixed_Name(geop, "Bhutan") |> PrefixedName
    /// <summary>
    ///   <para>geop:Saudi_Arabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Saudi_Arabia">http://aims.fao.org/aos/geopolitical.owl#Saudi_Arabia</seealso>
    let Saudi_Arabia = Prefixed_Name(geop, "Saudi_Arabia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cambodia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cambodia">http://aims.fao.org/aos/geopolitical.owl#Cambodia</seealso>
    let Cambodia = Prefixed_Name(geop, "Cambodia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Timor-Leste</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Timor-Leste">http://aims.fao.org/aos/geopolitical.owl#Timor-Leste</seealso>
    let Timor_Leste = Prefixed_Name(geop, "Timor-Leste") |> PrefixedName
    /// <summary>
    ///   <para>geop:Philippines__the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Philippines__the">http://aims.fao.org/aos/geopolitical.owl#Philippines__the</seealso>
    let Philippines__the = Prefixed_Name(geop, "Philippines__the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Kuwait</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Kuwait">http://aims.fao.org/aos/geopolitical.owl#Kuwait</seealso>
    let Kuwait = Prefixed_Name(geop, "Kuwait") |> PrefixedName
    /// <summary>
    ///   <para>geop:PIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#PIF">http://aims.fao.org/aos/geopolitical.owl#PIF</seealso>
    let PIF = Prefixed_Name(geop, "PIF") |> PrefixedName
    /// <summary>
    ///   <para>geop:Oceania</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Oceania">http://aims.fao.org/aos/geopolitical.owl#Oceania</seealso>
    let Oceania = Prefixed_Name(geop, "Oceania") |> PrefixedName

    /// <summary>
    ///   <para>geop:Australia_and_New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Australia_and_New_Zealand">http://aims.fao.org/aos/geopolitical.owl#Australia_and_New_Zealand</seealso>
    let Australia_and_New_Zealand =
        Prefixed_Name(geop, "Australia_and_New_Zealand") |> PrefixedName

    /// <summary>
    ///   <para>geop:New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#New_Zealand">http://aims.fao.org/aos/geopolitical.owl#New_Zealand</seealso>
    let New_Zealand = Prefixed_Name(geop, "New_Zealand") |> PrefixedName
    /// <summary>
    ///   <para>geop:Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Austria">http://aims.fao.org/aos/geopolitical.owl#Austria</seealso>
    let Austria = Prefixed_Name(geop, "Austria") |> PrefixedName
    /// <summary>
    ///   <para>geop:Slovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Slovakia">http://aims.fao.org/aos/geopolitical.owl#Slovakia</seealso>
    let Slovakia = Prefixed_Name(geop, "Slovakia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Liechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Liechtenstein">http://aims.fao.org/aos/geopolitical.owl#Liechtenstein</seealso>
    let Liechtenstein = Prefixed_Name(geop, "Liechtenstein") |> PrefixedName
    /// <summary>
    ///   <para>geop:Hungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Hungary">http://aims.fao.org/aos/geopolitical.owl#Hungary</seealso>
    let Hungary = Prefixed_Name(geop, "Hungary") |> PrefixedName
    /// <summary>
    ///   <para>geop:Czech_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Czech_Republic_the">http://aims.fao.org/aos/geopolitical.owl#Czech_Republic_the</seealso>
    let Czech_Republic_the = Prefixed_Name(geop, "Czech_Republic_the") |> PrefixedName
    /// <summary>
    ///   <para>geop:Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Germany">http://aims.fao.org/aos/geopolitical.owl#Germany</seealso>
    let Germany = Prefixed_Name(geop, "Germany") |> PrefixedName
    /// <summary>
    ///   <para>geop:Slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Slovenia">http://aims.fao.org/aos/geopolitical.owl#Slovenia</seealso>
    let Slovenia = Prefixed_Name(geop, "Slovenia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Switzerland">http://aims.fao.org/aos/geopolitical.owl#Switzerland</seealso>
    let Switzerland = Prefixed_Name(geop, "Switzerland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Italy">http://aims.fao.org/aos/geopolitical.owl#Italy</seealso>
    let Italy = Prefixed_Name(geop, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>geop:IGAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#IGAD">http://aims.fao.org/aos/geopolitical.owl#IGAD</seealso>
    let IGAD = Prefixed_Name(geop, "IGAD") |> PrefixedName
    /// <summary>
    ///   <para>geop:South_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#South_Africa">http://aims.fao.org/aos/geopolitical.owl#South_Africa</seealso>
    let South_Africa = Prefixed_Name(geop, "South_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:Cameroon</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Cameroon">http://aims.fao.org/aos/geopolitical.owl#Cameroon</seealso>
    let Cameroon = Prefixed_Name(geop, "Cameroon") |> PrefixedName
    /// <summary>
    ///   <para>geop:Kenya</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Kenya">http://aims.fao.org/aos/geopolitical.owl#Kenya</seealso>
    let Kenya = Prefixed_Name(geop, "Kenya") |> PrefixedName
    /// <summary>
    ///   <para>geop:Liberia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Liberia">http://aims.fao.org/aos/geopolitical.owl#Liberia</seealso>
    let Liberia = Prefixed_Name(geop, "Liberia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Gabon</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Gabon">http://aims.fao.org/aos/geopolitical.owl#Gabon</seealso>
    let Gabon = Prefixed_Name(geop, "Gabon") |> PrefixedName
    /// <summary>
    ///   <para>geop:IGADD</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#IGADD">http://aims.fao.org/aos/geopolitical.owl#IGADD</seealso>
    let IGADD = Prefixed_Name(geop, "IGADD") |> PrefixedName
    /// <summary>
    ///   <para>geop:Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Finland">http://aims.fao.org/aos/geopolitical.owl#Finland</seealso>
    let Finland = Prefixed_Name(geop, "Finland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sweden">http://aims.fao.org/aos/geopolitical.owl#Sweden</seealso>
    let Sweden = Prefixed_Name(geop, "Sweden") |> PrefixedName
    /// <summary>
    ///   <para>geop:Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Ireland">http://aims.fao.org/aos/geopolitical.owl#Ireland</seealso>
    let Ireland = Prefixed_Name(geop, "Ireland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Estonia">http://aims.fao.org/aos/geopolitical.owl#Estonia</seealso>
    let Estonia = Prefixed_Name(geop, "Estonia") |> PrefixedName

    /// <summary>
    ///   <para>geop:German_Democratic_Republic_the</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#German_Democratic_Republic_the">http://aims.fao.org/aos/geopolitical.owl#German_Democratic_Republic_the</seealso>
    let German_Democratic_Republic_the =
        Prefixed_Name(geop, "German_Democratic_Republic_the") |> PrefixedName

    /// <summary>
    ///   <para>geop:Gibraltar</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Gibraltar">http://aims.fao.org/aos/geopolitical.owl#Gibraltar</seealso>
    let Gibraltar = Prefixed_Name(geop, "Gibraltar") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guadeloupe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guadeloupe">http://aims.fao.org/aos/geopolitical.owl#Guadeloupe</seealso>
    let Guadeloupe = Prefixed_Name(geop, "Guadeloupe") |> PrefixedName
    /// <summary>
    ///   <para>geop:Guam</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Guam">http://aims.fao.org/aos/geopolitical.owl#Guam</seealso>
    let Guam = Prefixed_Name(geop, "Guam") |> PrefixedName
    /// <summary>
    ///   <para>geop:HDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#HDI">http://aims.fao.org/aos/geopolitical.owl#HDI</seealso>
    let HDI = Prefixed_Name(geop, "HDI") |> PrefixedName
    /// <summary>
    ///   <para>geop:HDIUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#HDIUnit">http://aims.fao.org/aos/geopolitical.owl#HDIUnit</seealso>
    let HDIUnit = Prefixed_Name(geop, "HDIUnit") |> PrefixedName
    /// <summary>
    ///   <para>geop:central_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#central_Asia">http://aims.fao.org/aos/geopolitical.owl#central_Asia</seealso>
    let central_Asia = Prefixed_Name(geop, "central_Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Micronesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Micronesia">http://aims.fao.org/aos/geopolitical.owl#Micronesia</seealso>
    let Micronesia = Prefixed_Name(geop, "Micronesia") |> PrefixedName
    /// <summary>
    ///   <para>geop:special_group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#special_group">http://aims.fao.org/aos/geopolitical.owl#special_group</seealso>
    let special_group = Prefixed_Name(geop, "special_group") |> PrefixedName
    /// <summary>
    ///   <para>geop:Sierra_Leone</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sierra_Leone">http://aims.fao.org/aos/geopolitical.owl#Sierra_Leone</seealso>
    let Sierra_Leone = Prefixed_Name(geop, "Sierra_Leone") |> PrefixedName
    /// <summary>
    ///   <para>geop:Rwanda</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Rwanda">http://aims.fao.org/aos/geopolitical.owl#Rwanda</seealso>
    let Rwanda = Prefixed_Name(geop, "Rwanda") |> PrefixedName
    /// <summary>
    ///   <para>geop:SAARC_1985</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#SAARC_1985">http://aims.fao.org/aos/geopolitical.owl#SAARC_1985</seealso>
    let SAARC_1985 = Prefixed_Name(geop, "SAARC_1985") |> PrefixedName
    /// <summary>
    ///   <para>geop:Zambia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Zambia">http://aims.fao.org/aos/geopolitical.owl#Zambia</seealso>
    let Zambia = Prefixed_Name(geop, "Zambia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Botswana</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Botswana">http://aims.fao.org/aos/geopolitical.owl#Botswana</seealso>
    let Botswana = Prefixed_Name(geop, "Botswana") |> PrefixedName

    /// <summary>
    ///   <para>geop:Sao_Tome_and_Principe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sao_Tome_and_Principe">http://aims.fao.org/aos/geopolitical.owl#Sao_Tome_and_Principe</seealso>
    let Sao_Tome_and_Principe =
        Prefixed_Name(geop, "Sao_Tome_and_Principe") |> PrefixedName

    /// <summary>
    ///   <para>geop:British_Virgin_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#British_Virgin_Islands">http://aims.fao.org/aos/geopolitical.owl#British_Virgin_Islands</seealso>
    let British_Virgin_Islands =
        Prefixed_Name(geop, "British_Virgin_Islands") |> PrefixedName

    /// <summary>
    ///   <para>geop:south-eastern_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#south-eastern_Asia">http://aims.fao.org/aos/geopolitical.owl#south-eastern_Asia</seealso>
    let south_eastern_Asia = Prefixed_Name(geop, "south-eastern_Asia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Bulgaria">http://aims.fao.org/aos/geopolitical.owl#Bulgaria</seealso>
    let Bulgaria = Prefixed_Name(geop, "Bulgaria") |> PrefixedName

    /// <summary>
    ///   <para>geop:Wallis_and_Futuna_Is</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Wallis_and_Futuna_Is">http://aims.fao.org/aos/geopolitical.owl#Wallis_and_Futuna_Is</seealso>
    let Wallis_and_Futuna_Is =
        Prefixed_Name(geop, "Wallis_and_Futuna_Is") |> PrefixedName

    /// <summary>
    ///   <para>geop:Yemen_1990</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Yemen_1990">http://aims.fao.org/aos/geopolitical.owl#Yemen_1990</seealso>
    let Yemen_1990 = Prefixed_Name(geop, "Yemen_1990") |> PrefixedName
    /// <summary>
    ///   <para>geop:Albania</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Albania">http://aims.fao.org/aos/geopolitical.owl#Albania</seealso>
    let Albania = Prefixed_Name(geop, "Albania") |> PrefixedName
    /// <summary>
    ///   <para>geop:NFIDC_2010</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#NFIDC_2010">http://aims.fao.org/aos/geopolitical.owl#NFIDC_2010</seealso>
    let NFIDC_2010 = Prefixed_Name(geop, "NFIDC_2010") |> PrefixedName
    /// <summary>
    ///   <para>geop:Montenegro</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Montenegro">http://aims.fao.org/aos/geopolitical.owl#Montenegro</seealso>
    let Montenegro = Prefixed_Name(geop, "Montenegro") |> PrefixedName
    /// <summary>
    ///   <para>geop:Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Europe">http://aims.fao.org/aos/geopolitical.owl#Europe</seealso>
    let Europe = Prefixed_Name(geop, "Europe") |> PrefixedName
    /// <summary>
    ///   <para>geop:Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Belgium">http://aims.fao.org/aos/geopolitical.owl#Belgium</seealso>
    let Belgium = Prefixed_Name(geop, "Belgium") |> PrefixedName
    /// <summary>
    ///   <para>geop:Sudan_the_1956</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sudan_the_1956">http://aims.fao.org/aos/geopolitical.owl#Sudan_the_1956</seealso>
    let Sudan_the_1956 = Prefixed_Name(geop, "Sudan_the_1956") |> PrefixedName

    /// <summary>
    ///   <para>geop:Turks_and_Caicos_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Turks_and_Caicos_Islands">http://aims.fao.org/aos/geopolitical.owl#Turks_and_Caicos_Islands</seealso>
    let Turks_and_Caicos_Islands =
        Prefixed_Name(geop, "Turks_and_Caicos_Islands") |> PrefixedName

    /// <summary>
    ///   <para>geop:Azerbaijan</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Azerbaijan">http://aims.fao.org/aos/geopolitical.owl#Azerbaijan</seealso>
    let Azerbaijan = Prefixed_Name(geop, "Azerbaijan") |> PrefixedName
    /// <summary>
    ///   <para>geop:CAC</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CAC">http://aims.fao.org/aos/geopolitical.owl#CAC</seealso>
    let CAC = Prefixed_Name(geop, "CAC") |> PrefixedName
    /// <summary>
    ///   <para>geop:central_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#central_America">http://aims.fao.org/aos/geopolitical.owl#central_America</seealso>
    let central_America = Prefixed_Name(geop, "central_America") |> PrefixedName
    /// <summary>
    ///   <para>geop:ECOWAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS">http://aims.fao.org/aos/geopolitical.owl#ECOWAS</seealso>
    let ECOWAS = Prefixed_Name(geop, "ECOWAS") |> PrefixedName
    /// <summary>
    ///   <para>geop:ECOWAS_1985</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#ECOWAS_1985">http://aims.fao.org/aos/geopolitical.owl#ECOWAS_1985</seealso>
    let ECOWAS_1985 = Prefixed_Name(geop, "ECOWAS_1985") |> PrefixedName
    /// <summary>
    ///   <para>geop:UEMOA</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#UEMOA">http://aims.fao.org/aos/geopolitical.owl#UEMOA</seealso>
    let UEMOA = Prefixed_Name(geop, "UEMOA") |> PrefixedName
    /// <summary>
    ///   <para>geop:CEN_SAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:economic_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#CEN_SAD">http://aims.fao.org/aos/geopolitical.owl#CEN_SAD</seealso>
    let CEN_SAD = Prefixed_Name(geop, "CEN_SAD") |> PrefixedName
    /// <summary>
    ///   <para>geop:western_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#western_Africa">http://aims.fao.org/aos/geopolitical.owl#western_Africa</seealso>
    let western_Africa = Prefixed_Name(geop, "western_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:Nauru</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Nauru">http://aims.fao.org/aos/geopolitical.owl#Nauru</seealso>
    let Nauru = Prefixed_Name(geop, "Nauru") |> PrefixedName
    /// <summary>
    ///   <para>geop:FAO_2007</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:organization</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#FAO_2007">http://aims.fao.org/aos/geopolitical.owl#FAO_2007</seealso>
    let FAO_2007 = Prefixed_Name(geop, "FAO_2007") |> PrefixedName
    /// <summary>
    ///   <para>geop:codeFAOTERM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#codeFAOTERM">http://aims.fao.org/aos/geopolitical.owl#codeFAOTERM</seealso>
    let codeFAOTERM = Prefixed_Name(geop, "codeFAOTERM") |> PrefixedName
    /// <summary>
    ///   <para>geop:Mauritania</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Mauritania">http://aims.fao.org/aos/geopolitical.owl#Mauritania</seealso>
    let Mauritania = Prefixed_Name(geop, "Mauritania") |> PrefixedName
    /// <summary>
    ///   <para>geop:Tunisia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Tunisia">http://aims.fao.org/aos/geopolitical.owl#Tunisia</seealso>
    let Tunisia = Prefixed_Name(geop, "Tunisia") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListEN">http://aims.fao.org/aos/geopolitical.owl#nameListEN</seealso>
    let nameListEN = Prefixed_Name(geop, "nameListEN") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameListFR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameListFR">http://aims.fao.org/aos/geopolitical.owl#nameListFR</seealso>
    let nameListFR = Prefixed_Name(geop, "nameListFR") |> PrefixedName
    /// <summary>
    ///   <para>geop:nameOfficialZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#nameOfficialZH">http://aims.fao.org/aos/geopolitical.owl#nameOfficialZH</seealso>
    let nameOfficialZH = Prefixed_Name(geop, "nameOfficialZH") |> PrefixedName
    /// <summary>
    ///   <para>geop:northern_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:geographical_region</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#northern_Africa">http://aims.fao.org/aos/geopolitical.owl#northern_Africa</seealso>
    let northern_Africa = Prefixed_Name(geop, "northern_Africa") |> PrefixedName
    /// <summary>
    ///   <para>geop:American_Samoa</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#American_Samoa">http://aims.fao.org/aos/geopolitical.owl#American_Samoa</seealso>
    let American_Samoa = Prefixed_Name(geop, "American_Samoa") |> PrefixedName
    /// <summary>
    ///   <para>geop:isAdministeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#isAdministeredBy">http://aims.fao.org/aos/geopolitical.owl#isAdministeredBy</seealso>
    let isAdministeredBy = Prefixed_Name(geop, "isAdministeredBy") |> PrefixedName

    /// <summary>
    ///   <para>geop:United_States_of_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#United_States_of_America">http://aims.fao.org/aos/geopolitical.owl#United_States_of_America</seealso>
    let United_States_of_America =
        Prefixed_Name(geop, "United_States_of_America") |> PrefixedName

    /// <summary>
    ///   <para>geop:SIDS</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:special_group</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#SIDS">http://aims.fao.org/aos/geopolitical.owl#SIDS</seealso>
    let SIDS = Prefixed_Name(geop, "SIDS") |> PrefixedName
    /// <summary>
    ///   <para>geop:Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Singapore">http://aims.fao.org/aos/geopolitical.owl#Singapore</seealso>
    let Singapore = Prefixed_Name(geop, "Singapore") |> PrefixedName
    /// <summary>
    ///   <para>geop:Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Australia">http://aims.fao.org/aos/geopolitical.owl#Australia</seealso>
    let Australia = Prefixed_Name(geop, "Australia") |> PrefixedName
    /// <summary>
    ///   <para>geop:Holy_See</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Holy_See">http://aims.fao.org/aos/geopolitical.owl#Holy_See</seealso>
    let Holy_See = Prefixed_Name(geop, "Holy_See") |> PrefixedName
    /// <summary>
    ///   <para>geop:Iceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Iceland">http://aims.fao.org/aos/geopolitical.owl#Iceland</seealso>
    let Iceland = Prefixed_Name(geop, "Iceland") |> PrefixedName
    /// <summary>
    ///   <para>geop:Sint_Maarten</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#Sint_Maarten">http://aims.fao.org/aos/geopolitical.owl#Sint_Maarten</seealso>
    let Sint_Maarten = Prefixed_Name(geop, "Sint_Maarten") |> PrefixedName
    /// <summary>
    ///   <para>geop:New_Caledonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>geop:non_self_governing</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/geopolitical.owl#New_Caledonia">http://aims.fao.org/aos/geopolitical.owl#New_Caledonia</seealso>
    let New_Caledonia = Prefixed_Name(geop, "New_Caledonia") |> PrefixedName

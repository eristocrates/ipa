namespace http.www.w3.org.TR._2003.PR_owl_guide_20031209.wine.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vin =
    let _namespace_iri = Namespace_Iri vin |> NamespaceIRI
    /// <summary>
    ///   <para>vin:Red</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineColor</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Red">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Red</seealso>
    let Red = Prefixed_Name(vin, "Red") |> PrefixedName
    /// <summary>
    ///   <para>vin:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineBody</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Medium">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Medium</seealso>
    let Medium = Prefixed_Name(vin, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>vin:Marietta</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Marietta">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Marietta</seealso>
    let Marietta = Prefixed_Name(vin, "Marietta") |> PrefixedName
    /// <summary>
    ///   <para>vin:Mountadam</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Mountadam">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Mountadam</seealso>
    let Mountadam = Prefixed_Name(vin, "Mountadam") |> PrefixedName
    /// <summary>
    ///   <para>vin:PageMillWinery</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PageMillWinery">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PageMillWinery</seealso>
    let PageMillWinery = Prefixed_Name(vin, "PageMillWinery") |> PrefixedName

    /// <summary>
    ///   <para>vin:SantaCruzMountainVineyard</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainVineyard">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainVineyard</seealso>
    let SantaCruzMountainVineyard =
        Prefixed_Name(vin, "SantaCruzMountainVineyard") |> PrefixedName

    /// <summary>
    ///   <para>vin:SeanThackrey</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SeanThackrey">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SeanThackrey</seealso>
    let SeanThackrey = Prefixed_Name(vin, "SeanThackrey") |> PrefixedName
    /// <summary>
    ///   <para>vin:Stonleigh</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Stonleigh">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Stonleigh</seealso>
    let Stonleigh = Prefixed_Name(vin, "Stonleigh") |> PrefixedName
    /// <summary>
    ///   <para>vin:Ventana</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Ventana">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Ventana</seealso>
    let Ventana = Prefixed_Name(vin, "Ventana") |> PrefixedName
    /// <summary>
    ///   <para>vin:Delicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineFlavor</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Delicate">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Delicate</seealso>
    let Delicate = Prefixed_Name(vin, "Delicate") |> PrefixedName
    /// <summary>
    ///   <para>vin:Sancerre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sancerre">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sancerre</seealso>
    let Sancerre = Prefixed_Name(vin, "Sancerre") |> PrefixedName

    /// <summary>
    ///   <para>vin:ClosDeVougeotCotesDOr</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CotesDOr</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeVougeotCotesDOr">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeVougeotCotesDOr</seealso>
    let ClosDeVougeotCotesDOr =
        Prefixed_Name(vin, "ClosDeVougeotCotesDOr") |> PrefixedName

    /// <summary>
    ///   <para>vin:CotesDOr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotesDOr">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotesDOr</seealso>
    let CotesDOr = Prefixed_Name(vin, "CotesDOr") |> PrefixedName

    /// <summary>
    ///   <para>vin:CongressSpringsSemillon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Semillon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CongressSpringsSemillon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CongressSpringsSemillon</seealso>
    let CongressSpringsSemillon =
        Prefixed_Name(vin, "CongressSpringsSemillon") |> PrefixedName

    /// <summary>
    ///   <para>vin:CortonMontrachetWhiteBurgundy</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WhiteBurgundy</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CortonMontrachetWhiteBurgundy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CortonMontrachetWhiteBurgundy</seealso>
    let CortonMontrachetWhiteBurgundy =
        Prefixed_Name(vin, "CortonMontrachetWhiteBurgundy") |> PrefixedName

    /// <summary>
    ///   <para>vin:WhiteBurgundy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteBurgundy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteBurgundy</seealso>
    let WhiteBurgundy = Prefixed_Name(vin, "WhiteBurgundy") |> PrefixedName
    /// <summary>
    ///   <para>vin:Zinfandel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Zinfandel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Zinfandel</seealso>
    let Zinfandel = Prefixed_Name(vin, "Zinfandel") |> PrefixedName
    /// <summary>
    ///   <para>vin:SonomaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SonomaRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SonomaRegion</seealso>
    let SonomaRegion = Prefixed_Name(vin, "SonomaRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:WineFlavor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineFlavor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineFlavor</seealso>
    let WineFlavor = Prefixed_Name(vin, "WineFlavor") |> PrefixedName
    /// <summary>
    ///   <para>vin:DessertWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DessertWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DessertWine</seealso>
    let DessertWine = Prefixed_Name(vin, "DessertWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:RedWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedWine</seealso>
    let RedWine = Prefixed_Name(vin, "RedWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:DryRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryRiesling</seealso>
    let DryRiesling = Prefixed_Name(vin, "DryRiesling") |> PrefixedName
    /// <summary>
    ///   <para>vin:SweetWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SweetWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SweetWine</seealso>
    let SweetWine = Prefixed_Name(vin, "SweetWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:TaylorPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Port</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TaylorPort">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TaylorPort</seealso>
    let TaylorPort = Prefixed_Name(vin, "TaylorPort") |> PrefixedName
    /// <summary>
    ///   <para>vin:TexasWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TexasWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TexasWine</seealso>
    let TexasWine = Prefixed_Name(vin, "TexasWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:ToursRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ToursRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ToursRegion</seealso>
    let ToursRegion = Prefixed_Name(vin, "ToursRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:VentanaCheninBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CheninBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#VentanaCheninBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#VentanaCheninBlanc</seealso>
    let VentanaCheninBlanc = Prefixed_Name(vin, "VentanaCheninBlanc") |> PrefixedName
    /// <summary>
    ///   <para>vin:Vintage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Vintage">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Vintage</seealso>
    let Vintage = Prefixed_Name(vin, "Vintage") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhiteLoire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteLoire">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteLoire</seealso>
    let WhiteLoire = Prefixed_Name(vin, "WhiteLoire") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhiteNonSweetWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteNonSweetWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteNonSweetWine</seealso>
    let WhiteNonSweetWine = Prefixed_Name(vin, "WhiteNonSweetWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhiteTableWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteTableWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteTableWine</seealso>
    let WhiteTableWine = Prefixed_Name(vin, "WhiteTableWine") |> PrefixedName

    /// <summary>
    ///   <para>vin:WhitehallLaneCabernetFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CabernetFranc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLaneCabernetFranc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLaneCabernetFranc</seealso>
    let WhitehallLaneCabernetFranc =
        Prefixed_Name(vin, "WhitehallLaneCabernetFranc") |> PrefixedName

    /// <summary>
    ///   <para>vin:WhitehallLanePrimavera</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:DessertWine</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLanePrimavera">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLanePrimavera</seealso>
    let WhitehallLanePrimavera =
        Prefixed_Name(vin, "WhitehallLanePrimavera") |> PrefixedName

    /// <summary>
    ///   <para>vin:WineTaste</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineTaste">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineTaste</seealso>
    let WineTaste = Prefixed_Name(vin, "WineTaste") |> PrefixedName
    /// <summary>
    ///   <para>vin:WineDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Made WineDescriptor unionType of tastes and color</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineDescriptor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineDescriptor</seealso>
    let WineDescriptor = Prefixed_Name(vin, "WineDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>vin:ZinfandelGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ZinfandelGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ZinfandelGrape</seealso>
    let ZinfandelGrape = Prefixed_Name(vin, "ZinfandelGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasWineDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasWineDescriptor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasWineDescriptor</seealso>
    let hasWineDescriptor = Prefixed_Name(vin, "hasWineDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>vin:madeIntoWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#madeIntoWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#madeIntoWine</seealso>
    let madeIntoWine = Prefixed_Name(vin, "madeIntoWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:producesWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#producesWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#producesWine</seealso>
    let producesWine = Prefixed_Name(vin, "producesWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:Rose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineColor</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Rose">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Rose</seealso>
    let Rose = Prefixed_Name(vin, "Rose") |> PrefixedName
    /// <summary>
    ///   <para>vin:Full</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineBody</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Full">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Full</seealso>
    let Full = Prefixed_Name(vin, "Full") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChateauDYchem</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDYchem">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDYchem</seealso>
    let ChateauDYchem = Prefixed_Name(vin, "ChateauDYchem") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChateauMorgon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMorgon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMorgon</seealso>
    let ChateauMorgon = Prefixed_Name(vin, "ChateauMorgon") |> PrefixedName
    /// <summary>
    ///   <para>vin:Corbans</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Corbans">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Corbans</seealso>
    let Corbans = Prefixed_Name(vin, "Corbans") |> PrefixedName
    /// <summary>
    ///   <para>vin:DAnjou</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DAnjou">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DAnjou</seealso>
    let DAnjou = Prefixed_Name(vin, "DAnjou") |> PrefixedName
    /// <summary>
    ///   <para>vin:GaryFarrell</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GaryFarrell">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GaryFarrell</seealso>
    let GaryFarrell = Prefixed_Name(vin, "GaryFarrell") |> PrefixedName
    /// <summary>
    ///   <para>vin:PinotBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotBlanc</seealso>
    let PinotBlanc = Prefixed_Name(vin, "PinotBlanc") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChateauChevalBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauChevalBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauChevalBlanc</seealso>
    let ChateauChevalBlanc = Prefixed_Name(vin, "ChateauChevalBlanc") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauMargauxWinery</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMargauxWinery">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMargauxWinery</seealso>
    let ChateauMargauxWinery =
        Prefixed_Name(vin, "ChateauMargauxWinery") |> PrefixedName

    /// <summary>
    ///   <para>vin:ClosDeVougeot</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeVougeot">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeVougeot</seealso>
    let ClosDeVougeot = Prefixed_Name(vin, "ClosDeVougeot") |> PrefixedName
    /// <summary>
    ///   <para>vin:CortonMontrachet</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CortonMontrachet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CortonMontrachet</seealso>
    let CortonMontrachet = Prefixed_Name(vin, "CortonMontrachet") |> PrefixedName
    /// <summary>
    ///   <para>vin:Loire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Loire">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Loire</seealso>
    let Loire = Prefixed_Name(vin, "Loire") |> PrefixedName
    /// <summary>
    ///   <para>vin:BancroftChardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chardonnay</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BancroftChardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BancroftChardonnay</seealso>
    let BancroftChardonnay = Prefixed_Name(vin, "BancroftChardonnay") |> PrefixedName
    /// <summary>
    ///   <para>vin:Beaujolais</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Beaujolais">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Beaujolais</seealso>
    let Beaujolais = Prefixed_Name(vin, "Beaujolais") |> PrefixedName
    /// <summary>
    ///   <para>vin:MariettaOldVinesRed</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:RedTableWine</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaOldVinesRed">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaOldVinesRed</seealso>
    let MariettaOldVinesRed = Prefixed_Name(vin, "MariettaOldVinesRed") |> PrefixedName
    /// <summary>
    ///   <para>vin:RedTableWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedTableWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedTableWine</seealso>
    let RedTableWine = Prefixed_Name(vin, "RedTableWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:ElyseZinfandel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Zinfandel</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ElyseZinfandel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ElyseZinfandel</seealso>
    let ElyseZinfandel = Prefixed_Name(vin, "ElyseZinfandel") |> PrefixedName
    /// <summary>
    ///   <para>vin:FoxenCheninBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CheninBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FoxenCheninBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FoxenCheninBlanc</seealso>
    let FoxenCheninBlanc = Prefixed_Name(vin, "FoxenCheninBlanc") |> PrefixedName
    /// <summary>
    ///   <para>vin:Gamay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Gamay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Gamay</seealso>
    let Gamay = Prefixed_Name(vin, "Gamay") |> PrefixedName
    /// <summary>
    ///   <para>vin:VintageYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#VintageYear">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#VintageYear</seealso>
    let VintageYear = Prefixed_Name(vin, "VintageYear") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhiteBordeaux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteBordeaux">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteBordeaux</seealso>
    let WhiteBordeaux = Prefixed_Name(vin, "WhiteBordeaux") |> PrefixedName
    /// <summary>
    ///   <para>vin:Elyse</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Elyse">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Elyse</seealso>
    let Elyse = Prefixed_Name(vin, "Elyse") |> PrefixedName
    /// <summary>
    ///   <para>vin:KalinCellars</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KalinCellars">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KalinCellars</seealso>
    let KalinCellars = Prefixed_Name(vin, "KalinCellars") |> PrefixedName
    /// <summary>
    ///   <para>vin:KathrynKennedy</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KathrynKennedy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KathrynKennedy</seealso>
    let KathrynKennedy = Prefixed_Name(vin, "KathrynKennedy") |> PrefixedName
    /// <summary>
    ///   <para>vin:LaneTanner</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LaneTanner">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LaneTanner</seealso>
    let LaneTanner = Prefixed_Name(vin, "LaneTanner") |> PrefixedName
    /// <summary>
    ///   <para>vin:MountEdenVineyard</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyard">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyard</seealso>
    let MountEdenVineyard = Prefixed_Name(vin, "MountEdenVineyard") |> PrefixedName
    /// <summary>
    ///   <para>vin:PeterMccoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PeterMccoy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PeterMccoy</seealso>
    let PeterMccoy = Prefixed_Name(vin, "PeterMccoy") |> PrefixedName
    /// <summary>
    ///   <para>vin:SaucelitoCanyon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyon</seealso>
    let SaucelitoCanyon = Prefixed_Name(vin, "SaucelitoCanyon") |> PrefixedName
    /// <summary>
    ///   <para>vin:Selaks</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Selaks">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Selaks</seealso>
    let Selaks = Prefixed_Name(vin, "Selaks") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhitehallLane</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLane">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhitehallLane</seealso>
    let WhitehallLane = Prefixed_Name(vin, "WhitehallLane") |> PrefixedName
    /// <summary>
    ///   <para>vin:Strong</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineFlavor</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Strong">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Strong</seealso>
    let Strong = Prefixed_Name(vin, "Strong") |> PrefixedName
    /// <summary>
    ///   <para>vin:Sweet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineSugar</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sweet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sweet</seealso>
    let Sweet = Prefixed_Name(vin, "Sweet") |> PrefixedName
    /// <summary>
    ///   <para>vin:Dry</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineSugar</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Dry">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Dry</seealso>
    let Dry = Prefixed_Name(vin, "Dry") |> PrefixedName
    /// <summary>
    ///   <para>vin:AlsaceRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AlsaceRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AlsaceRegion</seealso>
    let AlsaceRegion = Prefixed_Name(vin, "AlsaceRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Region">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Region</seealso>
    let Region = Prefixed_Name(vin, "Region") |> PrefixedName
    /// <summary>
    ///   <para>vin:Wine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>wine</para><para>vin</para></remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Wine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Wine</seealso>
    let Wine = Prefixed_Name(vin, "Wine") |> PrefixedName
    /// <summary>
    ///   <para>vin:USRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#USRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#USRegion</seealso>
    let USRegion = Prefixed_Name(vin, "USRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasColor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasColor</seealso>
    let hasColor = Prefixed_Name(vin, "hasColor") |> PrefixedName
    /// <summary>
    ///   <para>vin:GermanyRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GermanyRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GermanyRegion</seealso>
    let GermanyRegion = Prefixed_Name(vin, "GermanyRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:Handley</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Handley">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Handley</seealso>
    let Handley = Prefixed_Name(vin, "Handley") |> PrefixedName
    /// <summary>
    ///   <para>vin:LateHarvest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LateHarvest">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LateHarvest</seealso>
    let LateHarvest = Prefixed_Name(vin, "LateHarvest") |> PrefixedName

    /// <summary>
    ///   <para>vin:KalinCellarsSemillon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Semillon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KalinCellarsSemillon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KalinCellarsSemillon</seealso>
    let KalinCellarsSemillon =
        Prefixed_Name(vin, "KalinCellarsSemillon") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChardonnayGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChardonnayGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChardonnayGrape</seealso>
    let ChardonnayGrape = Prefixed_Name(vin, "ChardonnayGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:RoseDAnjou</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Anjou</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RoseDAnjou">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RoseDAnjou</seealso>
    let RoseDAnjou = Prefixed_Name(vin, "RoseDAnjou") |> PrefixedName
    /// <summary>
    ///   <para>vin:RoseWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RoseWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RoseWine</seealso>
    let RoseWine = Prefixed_Name(vin, "RoseWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:SancerreRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SancerreRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SancerreRegion</seealso>
    let SancerreRegion = Prefixed_Name(vin, "SancerreRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:PeterMccoyChardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chardonnay</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PeterMccoyChardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PeterMccoyChardonnay</seealso>
    let PeterMccoyChardonnay =
        Prefixed_Name(vin, "PeterMccoyChardonnay") |> PrefixedName

    /// <summary>
    ///   <para>vin:Longridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Longridge">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Longridge</seealso>
    let Longridge = Prefixed_Name(vin, "Longridge") |> PrefixedName
    /// <summary>
    ///   <para>vin:SauvignonBlancGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauvignonBlancGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauvignonBlancGrape</seealso>
    let SauvignonBlancGrape = Prefixed_Name(vin, "SauvignonBlancGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:SemillonGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SemillonGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SemillonGrape</seealso>
    let SemillonGrape = Prefixed_Name(vin, "SemillonGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:Meursault</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Meursault">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Meursault</seealso>
    let Meursault = Prefixed_Name(vin, "Meursault") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauMorgonBeaujolais</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Beaujolais</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMorgonBeaujolais">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMorgonBeaujolais</seealso>
    let ChateauMorgonBeaujolais =
        Prefixed_Name(vin, "ChateauMorgonBeaujolais") |> PrefixedName

    /// <summary>
    ///   <para>vin:hasVintageYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasVintageYear">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasVintageYear</seealso>
    let hasVintageYear = Prefixed_Name(vin, "hasVintageYear") |> PrefixedName
    /// <summary>
    ///   <para>vin:Year1998</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:VintageYear</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Year1998">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Year1998</seealso>
    let Year1998 = Prefixed_Name(vin, "Year1998") |> PrefixedName
    /// <summary>
    ///   <para>vin:McGuinnesso</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#McGuinnesso">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#McGuinnesso</seealso>
    let McGuinnesso = Prefixed_Name(vin, "McGuinnesso") |> PrefixedName
    /// <summary>
    ///   <para>vin:SchlossRothermel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossRothermel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossRothermel</seealso>
    let SchlossRothermel = Prefixed_Name(vin, "SchlossRothermel") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauDeMeursaultMeursault</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Meursault</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDeMeursaultMeursault">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDeMeursaultMeursault</seealso>
    let ChateauDeMeursaultMeursault =
        Prefixed_Name(vin, "ChateauDeMeursaultMeursault") |> PrefixedName

    /// <summary>
    ///   <para>vin:CheninBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CheninBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CheninBlanc</seealso>
    let CheninBlanc = Prefixed_Name(vin, "CheninBlanc") |> PrefixedName
    /// <summary>
    ///   <para>vin:PulignyMontrachet</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PulignyMontrachet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PulignyMontrachet</seealso>
    let PulignyMontrachet = Prefixed_Name(vin, "PulignyMontrachet") |> PrefixedName
    /// <summary>
    ///   <para>vin:SchlossVolrad</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossVolrad">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossVolrad</seealso>
    let SchlossVolrad = Prefixed_Name(vin, "SchlossVolrad") |> PrefixedName
    /// <summary>
    ///   <para>vin:StGenevieve</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StGenevieve">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StGenevieve</seealso>
    let StGenevieve = Prefixed_Name(vin, "StGenevieve") |> PrefixedName
    /// <summary>
    ///   <para>vin:CheninBlancGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CheninBlancGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CheninBlancGrape</seealso>
    let CheninBlancGrape = Prefixed_Name(vin, "CheninBlancGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:SevreEtMaine</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SevreEtMaine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SevreEtMaine</seealso>
    let SevreEtMaine = Prefixed_Name(vin, "SevreEtMaine") |> PrefixedName
    /// <summary>
    ///   <para>vin:Taylor</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Taylor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Taylor</seealso>
    let Taylor = Prefixed_Name(vin, "Taylor") |> PrefixedName

    /// <summary>
    ///   <para>vin:ClosDeLaPoussieSancerre</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Sancerre</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeLaPoussieSancerre">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeLaPoussieSancerre</seealso>
    let ClosDeLaPoussieSancerre =
        Prefixed_Name(vin, "ClosDeLaPoussieSancerre") |> PrefixedName

    /// <summary>
    ///   <para>vin:Semillon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Semillon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Semillon</seealso>
    let Semillon = Prefixed_Name(vin, "Semillon") |> PrefixedName
    /// <summary>
    ///   <para>vin:SauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauvignonBlanc</seealso>
    let SauvignonBlanc = Prefixed_Name(vin, "SauvignonBlanc") |> PrefixedName
    /// <summary>
    ///   <para>vin:Moderate</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineFlavor</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Moderate">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Moderate</seealso>
    let Moderate = Prefixed_Name(vin, "Moderate") |> PrefixedName
    /// <summary>
    ///   <para>vin:OffDry</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineSugar</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#OffDry">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#OffDry</seealso>
    let OffDry = Prefixed_Name(vin, "OffDry") |> PrefixedName
    /// <summary>
    ///   <para>vin:DryWhiteWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryWhiteWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryWhiteWine</seealso>
    let DryWhiteWine = Prefixed_Name(vin, "DryWhiteWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:EdnaValleyRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#EdnaValleyRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#EdnaValleyRegion</seealso>
    let EdnaValleyRegion = Prefixed_Name(vin, "EdnaValleyRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:FormanCabernetSauvignon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CabernetSauvignon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FormanCabernetSauvignon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FormanCabernetSauvignon</seealso>
    let FormanCabernetSauvignon =
        Prefixed_Name(vin, "FormanCabernetSauvignon") |> PrefixedName

    /// <summary>
    ///   <para>vin:FormanChardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chardonnay</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FormanChardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FormanChardonnay</seealso>
    let FormanChardonnay = Prefixed_Name(vin, "FormanChardonnay") |> PrefixedName
    /// <summary>
    ///   <para>vin:SantaBarbaraRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaBarbaraRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaBarbaraRegion</seealso>
    let SantaBarbaraRegion = Prefixed_Name(vin, "SantaBarbaraRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:FrenchWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FrenchWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FrenchWine</seealso>
    let FrenchWine = Prefixed_Name(vin, "FrenchWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:WineBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineBody">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineBody</seealso>
    let WineBody = Prefixed_Name(vin, "WineBody") |> PrefixedName
    /// <summary>
    ///   <para>vin:FullBodiedWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FullBodiedWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FullBodiedWine</seealso>
    let FullBodiedWine = Prefixed_Name(vin, "FullBodiedWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:Tours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Tours">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Tours</seealso>
    let Tours = Prefixed_Name(vin, "Tours") |> PrefixedName

    /// <summary>
    ///   <para>vin:CorbansSauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SauvignonBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansSauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansSauvignonBlanc</seealso>
    let CorbansSauvignonBlanc =
        Prefixed_Name(vin, "CorbansSauvignonBlanc") |> PrefixedName

    /// <summary>
    ///   <para>vin:RedBurgundy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedBurgundy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedBurgundy</seealso>
    let RedBurgundy = Prefixed_Name(vin, "RedBurgundy") |> PrefixedName
    /// <summary>
    ///   <para>vin:FrenchRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FrenchRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#FrenchRegion</seealso>
    let FrenchRegion = Prefixed_Name(vin, "FrenchRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:GaryFarrellMerlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Merlot</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GaryFarrellMerlot">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GaryFarrellMerlot</seealso>
    let GaryFarrellMerlot = Prefixed_Name(vin, "GaryFarrellMerlot") |> PrefixedName
    /// <summary>
    ///   <para>vin:GermanWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GermanWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GermanWine</seealso>
    let GermanWine = Prefixed_Name(vin, "GermanWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:AlsatianWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AlsatianWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AlsatianWine</seealso>
    let AlsatianWine = Prefixed_Name(vin, "AlsatianWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:Merlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Merlot">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Merlot</seealso>
    let Merlot = Prefixed_Name(vin, "Merlot") |> PrefixedName
    /// <summary>
    ///   <para>vin:IceWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#IceWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#IceWine</seealso>
    let IceWine = Prefixed_Name(vin, "IceWine") |> PrefixedName

    /// <summary>
    ///   <para>vin:KathrynKennedyLateral</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Meritage</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KathrynKennedyLateral">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#KathrynKennedyLateral</seealso>
    let KathrynKennedyLateral =
        Prefixed_Name(vin, "KathrynKennedyLateral") |> PrefixedName

    /// <summary>
    ///   <para>vin:Meritage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Meritage">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Meritage</seealso>
    let Meritage = Prefixed_Name(vin, "Meritage") |> PrefixedName
    /// <summary>
    ///   <para>vin:PinotNoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotNoir">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotNoir</seealso>
    let PinotNoir = Prefixed_Name(vin, "PinotNoir") |> PrefixedName
    /// <summary>
    ///   <para>vin:LongridgeMerlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Merlot</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LongridgeMerlot">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LongridgeMerlot</seealso>
    let LongridgeMerlot = Prefixed_Name(vin, "LongridgeMerlot") |> PrefixedName
    /// <summary>
    ///   <para>vin:MalbecGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MalbecGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MalbecGrape</seealso>
    let MalbecGrape = Prefixed_Name(vin, "MalbecGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:MargauxRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MargauxRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MargauxRegion</seealso>
    let MargauxRegion = Prefixed_Name(vin, "MargauxRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:MedocRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MedocRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MedocRegion</seealso>
    let MedocRegion = Prefixed_Name(vin, "MedocRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:MariettaCabernetSauvignon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CabernetSauvignon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaCabernetSauvignon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaCabernetSauvignon</seealso>
    let MariettaCabernetSauvignon =
        Prefixed_Name(vin, "MariettaCabernetSauvignon") |> PrefixedName

    /// <summary>
    ///   <para>vin:PetiteSyrah</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteSyrah">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteSyrah</seealso>
    let PetiteSyrah = Prefixed_Name(vin, "PetiteSyrah") |> PrefixedName
    /// <summary>
    ///   <para>vin:MariettaZinfandel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Zinfandel</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaZinfandel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaZinfandel</seealso>
    let MariettaZinfandel = Prefixed_Name(vin, "MariettaZinfandel") |> PrefixedName
    /// <summary>
    ///   <para>vin:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#locatedIn">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#locatedIn</seealso>
    let locatedIn = Prefixed_Name(vin, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>vin:AmericanWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AmericanWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AmericanWine</seealso>
    let AmericanWine = Prefixed_Name(vin, "AmericanWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasBody">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasBody</seealso>
    let hasBody = Prefixed_Name(vin, "hasBody") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasFlavor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasFlavor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasFlavor</seealso>
    let hasFlavor = Prefixed_Name(vin, "hasFlavor") |> PrefixedName
    /// <summary>
    ///   <para>vin:ArroyoGrandeRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ArroyoGrandeRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ArroyoGrandeRegion</seealso>
    let ArroyoGrandeRegion = Prefixed_Name(vin, "ArroyoGrandeRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:Chardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Chardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Chardonnay</seealso>
    let Chardonnay = Prefixed_Name(vin, "Chardonnay") |> PrefixedName
    /// <summary>
    ///   <para>vin:MerlotGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MerlotGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MerlotGrape</seealso>
    let MerlotGrape = Prefixed_Name(vin, "MerlotGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:Medoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Medoc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Medoc</seealso>
    let Medoc = Prefixed_Name(vin, "Medoc") |> PrefixedName
    /// <summary>
    ///   <para>vin:Anjou</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Anjou">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Anjou</seealso>
    let Anjou = Prefixed_Name(vin, "Anjou") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasSugar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasSugar">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasSugar</seealso>
    let hasSugar = Prefixed_Name(vin, "hasSugar") |> PrefixedName
    /// <summary>
    ///   <para>vin:LoireRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LoireRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LoireRegion</seealso>
    let LoireRegion = Prefixed_Name(vin, "LoireRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:NapaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#NapaRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#NapaRegion</seealso>
    let NapaRegion = Prefixed_Name(vin, "NapaRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:yearValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#yearValue">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#yearValue</seealso>
    let yearValue = Prefixed_Name(vin, "yearValue") |> PrefixedName
    /// <summary>
    ///   <para>vin:AnjouRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AnjouRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AnjouRegion</seealso>
    let AnjouRegion = Prefixed_Name(vin, "AnjouRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:AustralianRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AustralianRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#AustralianRegion</seealso>
    let AustralianRegion = Prefixed_Name(vin, "AustralianRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:CaliforniaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CaliforniaRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CaliforniaRegion</seealso>
    let CaliforniaRegion = Prefixed_Name(vin, "CaliforniaRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:hasMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasMaker">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#hasMaker</seealso>
    let hasMaker = Prefixed_Name(vin, "hasMaker") |> PrefixedName
    /// <summary>
    ///   <para>vin:LaneTannerPinotNoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:PinotNoir</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LaneTannerPinotNoir">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#LaneTannerPinotNoir</seealso>
    let LaneTannerPinotNoir = Prefixed_Name(vin, "LaneTannerPinotNoir") |> PrefixedName
    /// <summary>
    ///   <para>vin:Winery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Winery">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Winery</seealso>
    let Winery = Prefixed_Name(vin, "Winery") |> PrefixedName
    /// <summary>
    ///   <para>vin:madeFromGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#madeFromGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#madeFromGrape</seealso>
    let madeFromGrape = Prefixed_Name(vin, "madeFromGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:Beringer</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Beringer">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Beringer</seealso>
    let Beringer = Prefixed_Name(vin, "Beringer") |> PrefixedName
    /// <summary>
    ///   <para>vin:MeursaultRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MeursaultRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MeursaultRegion</seealso>
    let MeursaultRegion = Prefixed_Name(vin, "MeursaultRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:MountEdenVineyardEdnaValleyChardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chardonnay</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyardEdnaValleyChardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyardEdnaValleyChardonnay</seealso>
    let MountEdenVineyardEdnaValleyChardonnay =
        Prefixed_Name(vin, "MountEdenVineyardEdnaValleyChardonnay") |> PrefixedName

    /// <summary>
    ///   <para>vin:MountEdenVineyardEstatePinotNoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:PinotNoir</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyardEstatePinotNoir">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountEdenVineyardEstatePinotNoir</seealso>
    let MountEdenVineyardEstatePinotNoir =
        Prefixed_Name(vin, "MountEdenVineyardEstatePinotNoir") |> PrefixedName

    /// <summary>
    ///   <para>vin:SouthAustraliaRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SouthAustraliaRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SouthAustraliaRegion</seealso>
    let SouthAustraliaRegion =
        Prefixed_Name(vin, "SouthAustraliaRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:MountadamPinotNoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:PinotNoir</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamPinotNoir">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamPinotNoir</seealso>
    let MountadamPinotNoir = Prefixed_Name(vin, "MountadamPinotNoir") |> PrefixedName
    /// <summary>
    ///   <para>vin:MountadamRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:DryRiesling</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamRiesling</seealso>
    let MountadamRiesling = Prefixed_Name(vin, "MountadamRiesling") |> PrefixedName
    /// <summary>
    ///   <para>vin:Muscadet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Muscadet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Muscadet</seealso>
    let Muscadet = Prefixed_Name(vin, "Muscadet") |> PrefixedName
    /// <summary>
    ///   <para>vin:MariettaPetiteSyrah</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:PetiteSyrah</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaPetiteSyrah">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MariettaPetiteSyrah</seealso>
    let MariettaPetiteSyrah = Prefixed_Name(vin, "MariettaPetiteSyrah") |> PrefixedName
    /// <summary>
    ///   <para>vin:GamayGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GamayGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#GamayGrape</seealso>
    let GamayGrape = Prefixed_Name(vin, "GamayGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:BeaujolaisRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BeaujolaisRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BeaujolaisRegion</seealso>
    let BeaujolaisRegion = Prefixed_Name(vin, "BeaujolaisRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:Bordeaux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Bordeaux">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Bordeaux</seealso>
    let Bordeaux = Prefixed_Name(vin, "Bordeaux") |> PrefixedName
    /// <summary>
    ///   <para>vin:BourgogneRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BourgogneRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BourgogneRegion</seealso>
    let BourgogneRegion = Prefixed_Name(vin, "BourgogneRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:MendocinoRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MendocinoRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MendocinoRegion</seealso>
    let MendocinoRegion = Prefixed_Name(vin, "MendocinoRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:adjacentRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#adjacentRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#adjacentRegion</seealso>
    let adjacentRegion = Prefixed_Name(vin, "adjacentRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:PetiteVerdotGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteVerdotGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteVerdotGrape</seealso>
    let PetiteVerdotGrape = Prefixed_Name(vin, "PetiteVerdotGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:BordeauxRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BordeauxRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#BordeauxRegion</seealso>
    let BordeauxRegion = Prefixed_Name(vin, "BordeauxRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:Burgundy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Burgundy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Burgundy</seealso>
    let Burgundy = Prefixed_Name(vin, "Burgundy") |> PrefixedName
    /// <summary>
    ///   <para>vin:MountadamChardonnay</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chardonnay</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamChardonnay">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MountadamChardonnay</seealso>
    let MountadamChardonnay = Prefixed_Name(vin, "MountadamChardonnay") |> PrefixedName
    /// <summary>
    ///   <para>vin:PinotBlancGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotBlancGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotBlancGrape</seealso>
    let PinotBlancGrape = Prefixed_Name(vin, "PinotBlancGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:PauillacRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PauillacRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PauillacRegion</seealso>
    let PauillacRegion = Prefixed_Name(vin, "PauillacRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:PetiteSyrahGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteSyrahGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PetiteSyrahGrape</seealso>
    let PetiteSyrahGrape = Prefixed_Name(vin, "PetiteSyrahGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:PinotNoirGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotNoirGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PinotNoirGrape</seealso>
    let PinotNoirGrape = Prefixed_Name(vin, "PinotNoirGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:PortugalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PortugalRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PortugalRegion</seealso>
    let PortugalRegion = Prefixed_Name(vin, "PortugalRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:PulignyMontrachetWhiteBurgundy</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WhiteBurgundy</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PulignyMontrachetWhiteBurgundy">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PulignyMontrachetWhiteBurgundy</seealso>
    let PulignyMontrachetWhiteBurgundy =
        Prefixed_Name(vin, "PulignyMontrachetWhiteBurgundy") |> PrefixedName

    /// <summary>
    ///   <para>vin:WineColor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineColor">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineColor</seealso>
    let WineColor = Prefixed_Name(vin, "WineColor") |> PrefixedName
    /// <summary>
    ///   <para>vin:RedBordeaux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedBordeaux">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RedBordeaux</seealso>
    let RedBordeaux = Prefixed_Name(vin, "RedBordeaux") |> PrefixedName
    /// <summary>
    ///   <para>vin:CabernetFranc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetFranc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetFranc</seealso>
    let CabernetFranc = Prefixed_Name(vin, "CabernetFranc") |> PrefixedName
    /// <summary>
    ///   <para>vin:CabernetFrancGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetFrancGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetFrancGrape</seealso>
    let CabernetFrancGrape = Prefixed_Name(vin, "CabernetFrancGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:CabernetSauvignon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetSauvignon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetSauvignon</seealso>
    let CabernetSauvignon = Prefixed_Name(vin, "CabernetSauvignon") |> PrefixedName
    /// <summary>
    ///   <para>vin:MuscadetRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MuscadetRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#MuscadetRegion</seealso>
    let MuscadetRegion = Prefixed_Name(vin, "MuscadetRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:PageMillWineryCabernetSauvignon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CabernetSauvignon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PageMillWineryCabernetSauvignon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#PageMillWineryCabernetSauvignon</seealso>
    let PageMillWineryCabernetSauvignon =
        Prefixed_Name(vin, "PageMillWineryCabernetSauvignon") |> PrefixedName

    /// <summary>
    ///   <para>vin:WineGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineGrape</seealso>
    let WineGrape = Prefixed_Name(vin, "WineGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:Port</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Port">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Port</seealso>
    let Port = Prefixed_Name(vin, "Port") |> PrefixedName
    /// <summary>
    ///   <para>vin:TableWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TableWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TableWine</seealso>
    let TableWine = Prefixed_Name(vin, "TableWine") |> PrefixedName

    /// <summary>
    ///   <para>vin:CabernetSauvignonGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetSauvignonGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CabernetSauvignonGrape</seealso>
    let CabernetSauvignonGrape =
        Prefixed_Name(vin, "CabernetSauvignonGrape") |> PrefixedName

    /// <summary>
    ///   <para>vin:CentralCoastRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CentralCoastRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CentralCoastRegion</seealso>
    let CentralCoastRegion = Prefixed_Name(vin, "CentralCoastRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauChevalBlancStEmilion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:StEmilion</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauChevalBlancStEmilion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauChevalBlancStEmilion</seealso>
    let ChateauChevalBlancStEmilion =
        Prefixed_Name(vin, "ChateauChevalBlancStEmilion") |> PrefixedName

    /// <summary>
    ///   <para>vin:StEmilion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StEmilion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StEmilion</seealso>
    let StEmilion = Prefixed_Name(vin, "StEmilion") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauDYchemSauterne</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Sauternes</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDYchemSauterne">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDYchemSauterne</seealso>
    let ChateauDYchemSauterne =
        Prefixed_Name(vin, "ChateauDYchemSauterne") |> PrefixedName

    /// <summary>
    ///   <para>vin:Sauternes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sauternes">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Sauternes</seealso>
    let Sauternes = Prefixed_Name(vin, "Sauternes") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauLafiteRothschildPauillac</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Pauillac</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauLafiteRothschildPauillac">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauLafiteRothschildPauillac</seealso>
    let ChateauLafiteRothschildPauillac =
        Prefixed_Name(vin, "ChateauLafiteRothschildPauillac") |> PrefixedName

    /// <summary>
    ///   <para>vin:Pauillac</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Pauillac">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Pauillac</seealso>
    let Pauillac = Prefixed_Name(vin, "Pauillac") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChateauMargaux</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Margaux</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMargaux">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauMargaux</seealso>
    let ChateauMargaux = Prefixed_Name(vin, "ChateauMargaux") |> PrefixedName
    /// <summary>
    ///   <para>vin:Margaux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Margaux">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Margaux</seealso>
    let Margaux = Prefixed_Name(vin, "Margaux") |> PrefixedName
    /// <summary>
    ///   <para>vin:Chianti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Chianti">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Chianti</seealso>
    let Chianti = Prefixed_Name(vin, "Chianti") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChiantiRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChiantiRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChiantiRegion</seealso>
    let ChiantiRegion = Prefixed_Name(vin, "ChiantiRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:SangioveseGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SangioveseGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SangioveseGrape</seealso>
    let SangioveseGrape = Prefixed_Name(vin, "SangioveseGrape") |> PrefixedName
    /// <summary>
    ///   <para>vin:ItalianWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ItalianWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ItalianWine</seealso>
    let ItalianWine = Prefixed_Name(vin, "ItalianWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChiantiClassico</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Chianti</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChiantiClassico">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChiantiClassico</seealso>
    let ChiantiClassico = Prefixed_Name(vin, "ChiantiClassico") |> PrefixedName
    /// <summary>
    ///   <para>vin:ItalianRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ItalianRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ItalianRegion</seealso>
    let ItalianRegion = Prefixed_Name(vin, "ItalianRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:CorbansDryWhiteRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Riesling</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansDryWhiteRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansDryWhiteRiesling</seealso>
    let CorbansDryWhiteRiesling =
        Prefixed_Name(vin, "CorbansDryWhiteRiesling") |> PrefixedName

    /// <summary>
    ///   <para>vin:Riesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Riesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Riesling</seealso>
    let Riesling = Prefixed_Name(vin, "Riesling") |> PrefixedName
    /// <summary>
    ///   <para>vin:NewZealandRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#NewZealandRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#NewZealandRegion</seealso>
    let NewZealandRegion = Prefixed_Name(vin, "NewZealandRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:CorbansPrivateBinSauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SauvignonBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansPrivateBinSauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CorbansPrivateBinSauvignonBlanc</seealso>
    let CorbansPrivateBinSauvignonBlanc =
        Prefixed_Name(vin, "CorbansPrivateBinSauvignonBlanc") |> PrefixedName

    /// <summary>
    ///   <para>vin:CotesDOrRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotesDOrRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotesDOrRegion</seealso>
    let CotesDOrRegion = Prefixed_Name(vin, "CotesDOrRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:CotturiZinfandel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Zinfandel</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotturiZinfandel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CotturiZinfandel</seealso>
    let CotturiZinfandel = Prefixed_Name(vin, "CotturiZinfandel") |> PrefixedName
    /// <summary>
    ///   <para>vin:WineSugar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineSugar">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WineSugar</seealso>
    let WineSugar = Prefixed_Name(vin, "WineSugar") |> PrefixedName
    /// <summary>
    ///   <para>vin:DryRedWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryRedWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryRedWine</seealso>
    let DryRedWine = Prefixed_Name(vin, "DryRedWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:DryWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#DryWine</seealso>
    let DryWine = Prefixed_Name(vin, "DryWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:WhiteWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#WhiteWine</seealso>
    let WhiteWine = Prefixed_Name(vin, "WhiteWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:EarlyHarvest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#EarlyHarvest">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#EarlyHarvest</seealso>
    let EarlyHarvest = Prefixed_Name(vin, "EarlyHarvest") |> PrefixedName
    /// <summary>
    ///   <para>vin:White</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineColor</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#White">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#White</seealso>
    let White = Prefixed_Name(vin, "White") |> PrefixedName
    /// <summary>
    ///   <para>vin:Light</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>vin:WineBody</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Light">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Light</seealso>
    let Light = Prefixed_Name(vin, "Light") |> PrefixedName
    /// <summary>
    ///   <para>vin:Bancroft</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Bancroft">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Bancroft</seealso>
    let Bancroft = Prefixed_Name(vin, "Bancroft") |> PrefixedName
    /// <summary>
    ///   <para>vin:ChateauDeMeursault</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDeMeursault">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauDeMeursault</seealso>
    let ChateauDeMeursault = Prefixed_Name(vin, "ChateauDeMeursault") |> PrefixedName

    /// <summary>
    ///   <para>vin:ChateauLafiteRothschild</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauLafiteRothschild">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ChateauLafiteRothschild</seealso>
    let ChateauLafiteRothschild =
        Prefixed_Name(vin, "ChateauLafiteRothschild") |> PrefixedName

    /// <summary>
    ///   <para>vin:ClosDeLaPoussie</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeLaPoussie">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#ClosDeLaPoussie</seealso>
    let ClosDeLaPoussie = Prefixed_Name(vin, "ClosDeLaPoussie") |> PrefixedName
    /// <summary>
    ///   <para>vin:CongressSprings</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CongressSprings">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CongressSprings</seealso>
    let CongressSprings = Prefixed_Name(vin, "CongressSprings") |> PrefixedName
    /// <summary>
    ///   <para>vin:Cotturi</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Cotturi">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Cotturi</seealso>
    let Cotturi = Prefixed_Name(vin, "Cotturi") |> PrefixedName
    /// <summary>
    ///   <para>vin:Forman</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Forman">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Forman</seealso>
    let Forman = Prefixed_Name(vin, "Forman") |> PrefixedName
    /// <summary>
    ///   <para>vin:Foxen</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Winery</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Foxen">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#Foxen</seealso>
    let Foxen = Prefixed_Name(vin, "Foxen") |> PrefixedName
    /// <summary>
    ///   <para>vin:CaliforniaWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CaliforniaWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CaliforniaWine</seealso>
    let CaliforniaWine = Prefixed_Name(vin, "CaliforniaWine") |> PrefixedName
    /// <summary>
    ///   <para>vin:CentralTexasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CentralTexasRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#CentralTexasRegion</seealso>
    let CentralTexasRegion = Prefixed_Name(vin, "CentralTexasRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:TexasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TexasRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#TexasRegion</seealso>
    let TexasRegion = Prefixed_Name(vin, "TexasRegion") |> PrefixedName
    /// <summary>
    ///   <para>vin:RieslingGrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WineGrape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RieslingGrape">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#RieslingGrape</seealso>
    let RieslingGrape = Prefixed_Name(vin, "RieslingGrape") |> PrefixedName

    /// <summary>
    ///   <para>vin:SantaCruzMountainVineyardCabernetSauvignon</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:CabernetSauvignon</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainVineyardCabernetSauvignon">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainVineyardCabernetSauvignon</seealso>
    let SantaCruzMountainVineyardCabernetSauvignon =
        Prefixed_Name(vin, "SantaCruzMountainVineyardCabernetSauvignon") |> PrefixedName

    /// <summary>
    ///   <para>vin:SantaCruzMountainsRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainsRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SantaCruzMountainsRegion</seealso>
    let SantaCruzMountainsRegion =
        Prefixed_Name(vin, "SantaCruzMountainsRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:SaucelitoCanyonZinfandel</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Zinfandel</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyonZinfandel">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyonZinfandel</seealso>
    let SaucelitoCanyonZinfandel =
        Prefixed_Name(vin, "SaucelitoCanyonZinfandel") |> PrefixedName

    /// <summary>
    ///   <para>vin:SaucelitoCanyonZinfandel1998</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Zinfandel</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyonZinfandel1998">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SaucelitoCanyonZinfandel1998</seealso>
    let SaucelitoCanyonZinfandel1998 =
        Prefixed_Name(vin, "SaucelitoCanyonZinfandel1998") |> PrefixedName

    /// <summary>
    ///   <para>vin:SauterneRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauterneRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SauterneRegion</seealso>
    let SauterneRegion = Prefixed_Name(vin, "SauterneRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:SemillonOrSauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SemillonOrSauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SemillonOrSauvignonBlanc</seealso>
    let SemillonOrSauvignonBlanc =
        Prefixed_Name(vin, "SemillonOrSauvignonBlanc") |> PrefixedName

    /// <summary>
    ///   <para>vin:SchlossRothermelTrochenbierenausleseRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SweetRiesling</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossRothermelTrochenbierenausleseRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossRothermelTrochenbierenausleseRiesling</seealso>
    let SchlossRothermelTrochenbierenausleseRiesling =
        Prefixed_Name(vin, "SchlossRothermelTrochenbierenausleseRiesling") |> PrefixedName

    /// <summary>
    ///   <para>vin:SweetRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SweetRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SweetRiesling</seealso>
    let SweetRiesling = Prefixed_Name(vin, "SweetRiesling") |> PrefixedName

    /// <summary>
    ///   <para>vin:SchlossVolradTrochenbierenausleseRiesling</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SweetRiesling</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossVolradTrochenbierenausleseRiesling">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SchlossVolradTrochenbierenausleseRiesling</seealso>
    let SchlossVolradTrochenbierenausleseRiesling =
        Prefixed_Name(vin, "SchlossVolradTrochenbierenausleseRiesling") |> PrefixedName

    /// <summary>
    ///   <para>vin:SeanThackreySiriusPetiteSyrah</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:PetiteSyrah</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SeanThackreySiriusPetiteSyrah">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SeanThackreySiriusPetiteSyrah</seealso>
    let SeanThackreySiriusPetiteSyrah =
        Prefixed_Name(vin, "SeanThackreySiriusPetiteSyrah") |> PrefixedName

    /// <summary>
    ///   <para>vin:SelaksIceWine</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:IceWine</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SelaksIceWine">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SelaksIceWine</seealso>
    let SelaksIceWine = Prefixed_Name(vin, "SelaksIceWine") |> PrefixedName

    /// <summary>
    ///   <para>vin:SelaksSauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SauvignonBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SelaksSauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SelaksSauvignonBlanc</seealso>
    let SelaksSauvignonBlanc =
        Prefixed_Name(vin, "SelaksSauvignonBlanc") |> PrefixedName

    /// <summary>
    ///   <para>vin:SevreEtMaineMuscadet</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Muscadet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SevreEtMaineMuscadet">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#SevreEtMaineMuscadet</seealso>
    let SevreEtMaineMuscadet =
        Prefixed_Name(vin, "SevreEtMaineMuscadet") |> PrefixedName

    /// <summary>
    ///   <para>vin:StEmilionRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:Region</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StEmilionRegion">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StEmilionRegion</seealso>
    let StEmilionRegion = Prefixed_Name(vin, "StEmilionRegion") |> PrefixedName

    /// <summary>
    ///   <para>vin:StGenevieveTexasWhite</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:WhiteWine</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StGenevieveTexasWhite">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StGenevieveTexasWhite</seealso>
    let StGenevieveTexasWhite =
        Prefixed_Name(vin, "StGenevieveTexasWhite") |> PrefixedName

    /// <summary>
    ///   <para>vin:StonleighSauvignonBlanc</para>
    /// </summary>
    /// <remarks>
    ///   <para>vin:SauvignonBlanc</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StonleighSauvignonBlanc">http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#StonleighSauvignonBlanc</seealso>
    let StonleighSauvignonBlanc =
        Prefixed_Name(vin, "StonleighSauvignonBlanc") |> PrefixedName

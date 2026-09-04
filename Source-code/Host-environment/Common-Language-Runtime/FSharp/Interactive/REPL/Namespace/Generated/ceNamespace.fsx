#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ce =
    let _prefixId = PrefixId.fromNamespaceLabel "https://purl.org/cityexplorer#" "ce"
    let _namespaceIri = _prefixId.prefix ""
    let _100_FiraBarcelona = _prefixId.prefix "100_FiraBarcelona"
    let ``_100_HotelPalaceM%C3%A0laga`` = _prefixId.prefix "100_HotelPalaceM%C3%A0laga"
    let _100_MuseuBilbao = _prefixId.prefix "100_MuseuBilbao"
    let _100_RestaurantGourmetToledo = _prefixId.prefix "100_RestaurantGourmetToledo"
    let _100_TransPamplona = _prefixId.prefix "100_TransPamplona"
    let _10_CastellToledo = _prefixId.prefix "10_CastellToledo"
    let ``_10_Congr%C3%A9sBarcelona`` = _prefixId.prefix "10_Congr%C3%A9sBarcelona"
    let _10_HotelRoyalCadis = _prefixId.prefix "10_HotelRoyalCadis"
    let _10_RestaurantDeliciaCadis = _prefixId.prefix "10_RestaurantDeliciaCadis"
    let _10_TransSevilla = _prefixId.prefix "10_TransSevilla"
    let _11_CarnavalBilbao = _prefixId.prefix "11_CarnavalBilbao"
    let _11_HotelRoyalMadrid = _prefixId.prefix "11_HotelRoyalMadrid"
    let _11_ParcToledo = _prefixId.prefix "11_ParcToledo"
    let _11_RestaurantGourmetMadrid = _prefixId.prefix "11_RestaurantGourmetMadrid"
    let ``_11_TransVal%C3%A8ncia`` = _prefixId.prefix "11_TransVal%C3%A8ncia"
    let _12_CatedralCadis = _prefixId.prefix "12_CatedralCadis"
    let _12_CitySevilla = _prefixId.prefix "12_CitySevilla"
    let _12_FiraBarcelona = _prefixId.prefix "12_FiraBarcelona"
    let _12_HotelRoyalMadrid = _prefixId.prefix "12_HotelRoyalMadrid"
    let _12_RestaurantSaborCadis = _prefixId.prefix "12_RestaurantSaborCadis"
    let _13_CityCadis = _prefixId.prefix "13_CityCadis"

    let ``_13_Congr%C3%A9sVal%C3%A8ncia`` =
        _prefixId.prefix "13_Congr%C3%A9sVal%C3%A8ncia"

    let _13_HotelDelMarSevilla = _prefixId.prefix "13_HotelDelMarSevilla"
    let _13_PalauPamplona = _prefixId.prefix "13_PalauPamplona"

    let _13_RestaurantDeliciaSaragossa =
        _prefixId.prefix "13_RestaurantDeliciaSaragossa"

    let _14_CastellPamplona = _prefixId.prefix "14_CastellPamplona"
    let ``_14_Congr%C3%A9sToledo`` = _prefixId.prefix "14_Congr%C3%A9sToledo"
    let _14_HotelPalaceMadrid = _prefixId.prefix "14_HotelPalaceMadrid"
    let _14_MoviPamplona = _prefixId.prefix "14_MoviPamplona"

    let ``_14_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefixId.prefix "14_RestaurantFusi%C3%B3Val%C3%A8ncia"

    let _15_CastellCadis = _prefixId.prefix "15_CastellCadis"
    let _15_FestivalSaragossa = _prefixId.prefix "15_FestivalSaragossa"
    let _15_HotelPalaceCadis = _prefixId.prefix "15_HotelPalaceCadis"
    let _15_MoviCadis = _prefixId.prefix "15_MoviCadis"

    let _15_RestaurantDeliciaSaragossa =
        _prefixId.prefix "15_RestaurantDeliciaSaragossa"

    let _16_CastellBarcelona = _prefixId.prefix "16_CastellBarcelona"
    let ``_16_CityM%C3%A0laga`` = _prefixId.prefix "16_CityM%C3%A0laga"
    let _16_ConcertSevilla = _prefixId.prefix "16_ConcertSevilla"
    let _16_HotelPalaceSaragossa = _prefixId.prefix "16_HotelPalaceSaragossa"

    let ``_16_RestaurantFusi%C3%B3Pamplona`` =
        _prefixId.prefix "16_RestaurantFusi%C3%B3Pamplona"

    let ``_17_CarnavalVal%C3%A8ncia`` = _prefixId.prefix "17_CarnavalVal%C3%A8ncia"
    let _17_HotelDelMarToledo = _prefixId.prefix "17_HotelDelMarToledo"
    let _17_ParcMadrid = _prefixId.prefix "17_ParcMadrid"
    let _17_RestaurantGourmetCadis = _prefixId.prefix "17_RestaurantGourmetCadis"
    let _17_UrbanBilbao = _prefixId.prefix "17_UrbanBilbao"
    let _18_FestivalSaragossa = _prefixId.prefix "18_FestivalSaragossa"
    let _18_HotelPalaceMadrid = _prefixId.prefix "18_HotelPalaceMadrid"
    let _18_MetroBilbao = _prefixId.prefix "18_MetroBilbao"
    let ``_18_MuseuM%C3%A0laga`` = _prefixId.prefix "18_MuseuM%C3%A0laga"
    let _18_RestaurantSaborCadis = _prefixId.prefix "18_RestaurantSaborCadis"
    let _19_CityBilbao = _prefixId.prefix "19_CityBilbao"
    let ``_19_ConcertVal%C3%A8ncia`` = _prefixId.prefix "19_ConcertVal%C3%A8ncia"
    let _19_HotelSolBilbao = _prefixId.prefix "19_HotelSolBilbao"
    let _19_PalauBarcelona = _prefixId.prefix "19_PalauBarcelona"

    let ``_19_RestaurantFusi%C3%B3Madrid`` =
        _prefixId.prefix "19_RestaurantFusi%C3%B3Madrid"

    let _1_CastellSaragossa = _prefixId.prefix "1_CastellSaragossa"
    let ``_1_Congr%C3%A9sCadis`` = _prefixId.prefix "1_Congr%C3%A9sCadis"
    let _1_HotelVistaSevilla = _prefixId.prefix "1_HotelVistaSevilla"

    let ``_1_RestaurantTradici%C3%B3Toledo`` =
        _prefixId.prefix "1_RestaurantTradici%C3%B3Toledo"

    let _1_UrbanMadrid = _prefixId.prefix "1_UrbanMadrid"
    let _20_CarnavalSevilla = _prefixId.prefix "20_CarnavalSevilla"
    let _20_CatedralBarcelona = _prefixId.prefix "20_CatedralBarcelona"
    let ``_20_HotelVistaVal%C3%A8ncia`` = _prefixId.prefix "20_HotelVistaVal%C3%A8ncia"
    let _20_MoviBilbao = _prefixId.prefix "20_MoviBilbao"

    let ``_20_RestaurantGourmetM%C3%A0laga`` =
        _prefixId.prefix "20_RestaurantGourmetM%C3%A0laga"

    let ``_21_CatedralM%C3%A0laga`` = _prefixId.prefix "21_CatedralM%C3%A0laga"
    let _21_CityPamplona = _prefixId.prefix "21_CityPamplona"
    let _21_FiraSevilla = _prefixId.prefix "21_FiraSevilla"
    let ``_21_HotelSolVal%C3%A8ncia`` = _prefixId.prefix "21_HotelSolVal%C3%A8ncia"
    let _21_RestaurantDeliciaMadrid = _prefixId.prefix "21_RestaurantDeliciaMadrid"
    let ``_22_CatedralVal%C3%A8ncia`` = _prefixId.prefix "22_CatedralVal%C3%A8ncia"
    let _22_FestivalSevilla = _prefixId.prefix "22_FestivalSevilla"
    let ``_22_HotelVistaM%C3%A0laga`` = _prefixId.prefix "22_HotelVistaM%C3%A0laga"

    let ``_22_RestaurantTradici%C3%B3Madrid`` =
        _prefixId.prefix "22_RestaurantTradici%C3%B3Madrid"

    let _22_UrbanSaragossa = _prefixId.prefix "22_UrbanSaragossa"

    let ``_23_CastellSantSebasti%C3%A0`` =
        _prefixId.prefix "23_CastellSantSebasti%C3%A0"

    let ``_23_Congr%C3%A9sSaragossa`` = _prefixId.prefix "23_Congr%C3%A9sSaragossa"
    let _23_HotelVistaToledo = _prefixId.prefix "23_HotelVistaToledo"
    let _23_MoviPamplona = _prefixId.prefix "23_MoviPamplona"

    let ``_23_RestaurantFusi%C3%B3Sevilla`` =
        _prefixId.prefix "23_RestaurantFusi%C3%B3Sevilla"

    let _24_CastellSaragossa = _prefixId.prefix "24_CastellSaragossa"
    let ``_24_Congr%C3%A9sBarcelona`` = _prefixId.prefix "24_Congr%C3%A9sBarcelona"
    let _24_HotelRoyalSaragossa = _prefixId.prefix "24_HotelRoyalSaragossa"
    let _24_RestaurantGourmetSevilla = _prefixId.prefix "24_RestaurantGourmetSevilla"
    let ``_24_UrbanVal%C3%A8ncia`` = _prefixId.prefix "24_UrbanVal%C3%A8ncia"
    let ``_25_CarnavalM%C3%A0laga`` = _prefixId.prefix "25_CarnavalM%C3%A0laga"
    let _25_HotelRoyalSevilla = _prefixId.prefix "25_HotelRoyalSevilla"
    let _25_MetroSaragossa = _prefixId.prefix "25_MetroSaragossa"
    let _25_ParcBilbao = _prefixId.prefix "25_ParcBilbao"

    let ``_25_RestaurantFusi%C3%B3Sevilla`` =
        _prefixId.prefix "25_RestaurantFusi%C3%B3Sevilla"

    let _26_CarnavalBilbao = _prefixId.prefix "26_CarnavalBilbao"
    let _26_CatedralSaragossa = _prefixId.prefix "26_CatedralSaragossa"
    let _26_HotelSolCadis = _prefixId.prefix "26_HotelSolCadis"
    let _26_MetroPamplona = _prefixId.prefix "26_MetroPamplona"
    let _26_RestaurantGourmetPamplona = _prefixId.prefix "26_RestaurantGourmetPamplona"
    let ``_27_CastellM%C3%A0laga`` = _prefixId.prefix "27_CastellM%C3%A0laga"
    let ``_27_Congr%C3%A9sBilbao`` = _prefixId.prefix "27_Congr%C3%A9sBilbao"
    let _27_HotelSolBilbao = _prefixId.prefix "27_HotelSolBilbao"

    let ``_27_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefixId.prefix "27_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    let _27_UrbanBarcelona = _prefixId.prefix "27_UrbanBarcelona"
    let _28_FestivalToledo = _prefixId.prefix "28_FestivalToledo"

    let ``_28_HotelDelMarSantSebasti%C3%A0`` =
        _prefixId.prefix "28_HotelDelMarSantSebasti%C3%A0"

    let ``_28_ParcSantSebasti%C3%A0`` = _prefixId.prefix "28_ParcSantSebasti%C3%A0"

    let ``_28_RestaurantFusi%C3%B3Cadis`` =
        _prefixId.prefix "28_RestaurantFusi%C3%B3Cadis"

    let _28_UrbanPamplona = _prefixId.prefix "28_UrbanPamplona"

    let ``_29_CastellSantSebasti%C3%A0`` =
        _prefixId.prefix "29_CastellSantSebasti%C3%A0"

    let _29_FiraMadrid = _prefixId.prefix "29_FiraMadrid"
    let _29_HotelRoyalMadrid = _prefixId.prefix "29_HotelRoyalMadrid"
    let ``_29_MetroSantSebasti%C3%A0`` = _prefixId.prefix "29_MetroSantSebasti%C3%A0"

    let ``_29_RestaurantDeliciaVal%C3%A8ncia`` =
        _prefixId.prefix "29_RestaurantDeliciaVal%C3%A8ncia"

    let _2_CarnavalCadis = _prefixId.prefix "2_CarnavalCadis"
    let _2_CastellSevilla = _prefixId.prefix "2_CastellSevilla"
    let _2_HotelRoyalPamplona = _prefixId.prefix "2_HotelRoyalPamplona"
    let _2_RestaurantGourmetMadrid = _prefixId.prefix "2_RestaurantGourmetMadrid"
    let _2_TransBilbao = _prefixId.prefix "2_TransBilbao"
    let ``_30_CastellVal%C3%A8ncia`` = _prefixId.prefix "30_CastellVal%C3%A8ncia"
    let _30_FestivalMadrid = _prefixId.prefix "30_FestivalMadrid"
    let _30_HotelDelMarPamplona = _prefixId.prefix "30_HotelDelMarPamplona"
    let _30_RestaurantDeliciaPamplona = _prefixId.prefix "30_RestaurantDeliciaPamplona"
    let ``_30_UrbanM%C3%A0laga`` = _prefixId.prefix "30_UrbanM%C3%A0laga"
    let _31_FiraMadrid = _prefixId.prefix "31_FiraMadrid"
    let _31_HotelVistaMadrid = _prefixId.prefix "31_HotelVistaMadrid"
    let ``_31_PalauM%C3%A0laga`` = _prefixId.prefix "31_PalauM%C3%A0laga"

    let ``_31_RestaurantTradici%C3%B3Madrid`` =
        _prefixId.prefix "31_RestaurantTradici%C3%B3Madrid"

    let ``_31_UrbanSantSebasti%C3%A0`` = _prefixId.prefix "31_UrbanSantSebasti%C3%A0"
    let _32_ConcertPamplona = _prefixId.prefix "32_ConcertPamplona"
    let _32_HotelPalaceToledo = _prefixId.prefix "32_HotelPalaceToledo"
    let _32_MetroMadrid = _prefixId.prefix "32_MetroMadrid"
    let _32_MuseuSaragossa = _prefixId.prefix "32_MuseuSaragossa"
    let _32_RestaurantGourmetMadrid = _prefixId.prefix "32_RestaurantGourmetMadrid"
    let _33_FestivalBarcelona = _prefixId.prefix "33_FestivalBarcelona"
    let _33_HotelSolBarcelona = _prefixId.prefix "33_HotelSolBarcelona"
    let _33_MetroMadrid = _prefixId.prefix "33_MetroMadrid"
    let _33_MuseuBarcelona = _prefixId.prefix "33_MuseuBarcelona"

    let ``_33_RestaurantTradici%C3%B3Toledo`` =
        _prefixId.prefix "33_RestaurantTradici%C3%B3Toledo"

    let _34_CarnavalSaragossa = _prefixId.prefix "34_CarnavalSaragossa"
    let _34_HotelDelMarBarcelona = _prefixId.prefix "34_HotelDelMarBarcelona"
    let _34_MuseuSaragossa = _prefixId.prefix "34_MuseuSaragossa"
    let _34_RestaurantDeliciaSevilla = _prefixId.prefix "34_RestaurantDeliciaSevilla"
    let ``_34_UrbanSantSebasti%C3%A0`` = _prefixId.prefix "34_UrbanSantSebasti%C3%A0"
    let _35_ConcertToledo = _prefixId.prefix "35_ConcertToledo"
    let _35_HotelDelMarPamplona = _prefixId.prefix "35_HotelDelMarPamplona"
    let _35_MetroBilbao = _prefixId.prefix "35_MetroBilbao"
    let _35_PalauPamplona = _prefixId.prefix "35_PalauPamplona"

    let ``_35_RestaurantDeliciaSantSebasti%C3%A0`` =
        _prefixId.prefix "35_RestaurantDeliciaSantSebasti%C3%A0"

    let _36_CityBarcelona = _prefixId.prefix "36_CityBarcelona"
    let _36_ConcertPamplona = _prefixId.prefix "36_ConcertPamplona"
    let _36_HotelPalaceSaragossa = _prefixId.prefix "36_HotelPalaceSaragossa"
    let _36_ParcPamplona = _prefixId.prefix "36_ParcPamplona"

    let ``_36_RestaurantFusi%C3%B3Saragossa`` =
        _prefixId.prefix "36_RestaurantFusi%C3%B3Saragossa"

    let _37_CastellMadrid = _prefixId.prefix "37_CastellMadrid"
    let _37_FestivalMadrid = _prefixId.prefix "37_FestivalMadrid"

    let ``_37_HotelDelMarVal%C3%A8ncia`` =
        _prefixId.prefix "37_HotelDelMarVal%C3%A8ncia"

    let ``_37_RestaurantSaborVal%C3%A8ncia`` =
        _prefixId.prefix "37_RestaurantSaborVal%C3%A8ncia"

    let ``_37_TransM%C3%A0laga`` = _prefixId.prefix "37_TransM%C3%A0laga"
    let _38_CarnavalSevilla = _prefixId.prefix "38_CarnavalSevilla"
    let ``_38_HotelDelMarM%C3%A0laga`` = _prefixId.prefix "38_HotelDelMarM%C3%A0laga"
    let _38_MoviMadrid = _prefixId.prefix "38_MoviMadrid"
    let _38_PalauToledo = _prefixId.prefix "38_PalauToledo"
    let _38_RestaurantDeliciaPamplona = _prefixId.prefix "38_RestaurantDeliciaPamplona"

    let ``_39_CastellSantSebasti%C3%A0`` =
        _prefixId.prefix "39_CastellSantSebasti%C3%A0"

    let _39_FiraBarcelona = _prefixId.prefix "39_FiraBarcelona"
    let _39_HotelSolSaragossa = _prefixId.prefix "39_HotelSolSaragossa"
    let _39_MoviSevilla = _prefixId.prefix "39_MoviSevilla"

    let ``_39_RestaurantFusi%C3%B3Toledo`` =
        _prefixId.prefix "39_RestaurantFusi%C3%B3Toledo"

    let _3_CastellSaragossa = _prefixId.prefix "3_CastellSaragossa"
    let ``_3_Congr%C3%A9sBilbao`` = _prefixId.prefix "3_Congr%C3%A9sBilbao"
    let ``_3_HotelRoyalM%C3%A0laga`` = _prefixId.prefix "3_HotelRoyalM%C3%A0laga"

    let ``_3_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefixId.prefix "3_RestaurantFusi%C3%B3Val%C3%A8ncia"

    let _3_TransToledo = _prefixId.prefix "3_TransToledo"
    let ``_40_FestivalVal%C3%A8ncia`` = _prefixId.prefix "40_FestivalVal%C3%A8ncia"

    let ``_40_HotelDelMarSantSebasti%C3%A0`` =
        _prefixId.prefix "40_HotelDelMarSantSebasti%C3%A0"

    let _40_PalauCadis = _prefixId.prefix "40_PalauCadis"

    let ``_40_RestaurantGourmetVal%C3%A8ncia`` =
        _prefixId.prefix "40_RestaurantGourmetVal%C3%A8ncia"

    let _40_UrbanToledo = _prefixId.prefix "40_UrbanToledo"
    let _41_CatedralToledo = _prefixId.prefix "41_CatedralToledo"
    let _41_ConcertToledo = _prefixId.prefix "41_ConcertToledo"
    let _41_HotelRoyalCadis = _prefixId.prefix "41_HotelRoyalCadis"
    let _41_MetroBarcelona = _prefixId.prefix "41_MetroBarcelona"

    let ``_41_RestaurantTradici%C3%B3Saragossa`` =
        _prefixId.prefix "41_RestaurantTradici%C3%B3Saragossa"

    let _42_FestivalPamplona = _prefixId.prefix "42_FestivalPamplona"
    let _42_HotelPalaceMadrid = _prefixId.prefix "42_HotelPalaceMadrid"
    let _42_MuseuMadrid = _prefixId.prefix "42_MuseuMadrid"

    let ``_42_RestaurantTradici%C3%B3Sevilla`` =
        _prefixId.prefix "42_RestaurantTradici%C3%B3Sevilla"

    let _42_UrbanSevilla = _prefixId.prefix "42_UrbanSevilla"
    let _43_CityPamplona = _prefixId.prefix "43_CityPamplona"
    let _43_FestivalMadrid = _prefixId.prefix "43_FestivalMadrid"
    let _43_HotelRoyalPamplona = _prefixId.prefix "43_HotelRoyalPamplona"
    let _43_ParcBarcelona = _prefixId.prefix "43_ParcBarcelona"

    let ``_43_RestaurantFusi%C3%B3Barcelona`` =
        _prefixId.prefix "43_RestaurantFusi%C3%B3Barcelona"

    let ``_44_Congr%C3%A9sSevilla`` = _prefixId.prefix "44_Congr%C3%A9sSevilla"
    let _44_HotelVistaSaragossa = _prefixId.prefix "44_HotelVistaSaragossa"
    let ``_44_MoviSantSebasti%C3%A0`` = _prefixId.prefix "44_MoviSantSebasti%C3%A0"
    let _44_MuseuSevilla = _prefixId.prefix "44_MuseuSevilla"

    let ``_44_RestaurantGourmetM%C3%A0laga`` =
        _prefixId.prefix "44_RestaurantGourmetM%C3%A0laga"

    let _45_CatedralBarcelona = _prefixId.prefix "45_CatedralBarcelona"
    let ``_45_Congr%C3%A9sBarcelona`` = _prefixId.prefix "45_Congr%C3%A9sBarcelona"
    let _45_HotelRoyalBarcelona = _prefixId.prefix "45_HotelRoyalBarcelona"
    let _45_MetroPamplona = _prefixId.prefix "45_MetroPamplona"

    let ``_45_RestaurantFusi%C3%B3Saragossa`` =
        _prefixId.prefix "45_RestaurantFusi%C3%B3Saragossa"

    let ``_46_Congr%C3%A9sVal%C3%A8ncia`` =
        _prefixId.prefix "46_Congr%C3%A9sVal%C3%A8ncia"

    let _46_HotelVistaSevilla = _prefixId.prefix "46_HotelVistaSevilla"
    let _46_MetroPamplona = _prefixId.prefix "46_MetroPamplona"
    let _46_MuseuToledo = _prefixId.prefix "46_MuseuToledo"

    let ``_46_RestaurantSaborM%C3%A0laga`` =
        _prefixId.prefix "46_RestaurantSaborM%C3%A0laga"

    let ``_47_FestivalVal%C3%A8ncia`` = _prefixId.prefix "47_FestivalVal%C3%A8ncia"

    let ``_47_HotelDelMarSantSebasti%C3%A0`` =
        _prefixId.prefix "47_HotelDelMarSantSebasti%C3%A0"

    let ``_47_MoviSantSebasti%C3%A0`` = _prefixId.prefix "47_MoviSantSebasti%C3%A0"
    let _47_PalauToledo = _prefixId.prefix "47_PalauToledo"

    let ``_47_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefixId.prefix "47_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    let _48_FestivalBilbao = _prefixId.prefix "48_FestivalBilbao"
    let ``_48_HotelPalaceM%C3%A0laga`` = _prefixId.prefix "48_HotelPalaceM%C3%A0laga"
    let _48_MoviToledo = _prefixId.prefix "48_MoviToledo"
    let ``_48_ParcSantSebasti%C3%A0`` = _prefixId.prefix "48_ParcSantSebasti%C3%A0"

    let ``_48_RestaurantSaborSantSebasti%C3%A0`` =
        _prefixId.prefix "48_RestaurantSaborSantSebasti%C3%A0"

    let ``_49_CastellSantSebasti%C3%A0`` =
        _prefixId.prefix "49_CastellSantSebasti%C3%A0"

    let _49_CityMadrid = _prefixId.prefix "49_CityMadrid"

    let ``_49_ConcertSantSebasti%C3%A0`` =
        _prefixId.prefix "49_ConcertSantSebasti%C3%A0"

    let _49_HotelVistaPamplona = _prefixId.prefix "49_HotelVistaPamplona"

    let ``_49_RestaurantSaborM%C3%A0laga`` =
        _prefixId.prefix "49_RestaurantSaborM%C3%A0laga"

    let _4_CarnavalSevilla = _prefixId.prefix "4_CarnavalSevilla"
    let _4_CitySaragossa = _prefixId.prefix "4_CitySaragossa"
    let _4_HotelRoyalBilbao = _prefixId.prefix "4_HotelRoyalBilbao"
    let _4_MuseuMadrid = _prefixId.prefix "4_MuseuMadrid"

    let ``_4_RestaurantDeliciaM%C3%A0laga`` =
        _prefixId.prefix "4_RestaurantDeliciaM%C3%A0laga"

    let ``_50_FestivalVal%C3%A8ncia`` = _prefixId.prefix "50_FestivalVal%C3%A8ncia"
    let _50_HotelSolCadis = _prefixId.prefix "50_HotelSolCadis"
    let ``_50_ParcM%C3%A0laga`` = _prefixId.prefix "50_ParcM%C3%A0laga"

    let _50_RestaurantDeliciaBarcelona =
        _prefixId.prefix "50_RestaurantDeliciaBarcelona"

    let _50_UrbanSaragossa = _prefixId.prefix "50_UrbanSaragossa"
    let ``_51_CarnavalM%C3%A0laga`` = _prefixId.prefix "51_CarnavalM%C3%A0laga"
    let _51_HotelPalacePamplona = _prefixId.prefix "51_HotelPalacePamplona"
    let _51_PalauMadrid = _prefixId.prefix "51_PalauMadrid"
    let _51_RestaurantDeliciaSevilla = _prefixId.prefix "51_RestaurantDeliciaSevilla"
    let _51_UrbanMadrid = _prefixId.prefix "51_UrbanMadrid"
    let _52_CatedralMadrid = _prefixId.prefix "52_CatedralMadrid"
    let ``_52_Congr%C3%A9sToledo`` = _prefixId.prefix "52_Congr%C3%A9sToledo"
    let _52_HotelSolSevilla = _prefixId.prefix "52_HotelSolSevilla"

    let _52_RestaurantDeliciaSaragossa =
        _prefixId.prefix "52_RestaurantDeliciaSaragossa"

    let _52_TransMadrid = _prefixId.prefix "52_TransMadrid"
    let ``_53_CatedralVal%C3%A8ncia`` = _prefixId.prefix "53_CatedralVal%C3%A8ncia"
    let _53_FiraBarcelona = _prefixId.prefix "53_FiraBarcelona"
    let ``_53_HotelDelMarM%C3%A0laga`` = _prefixId.prefix "53_HotelDelMarM%C3%A0laga"
    let _53_RestaurantDeliciaCadis = _prefixId.prefix "53_RestaurantDeliciaCadis"
    let _53_UrbanToledo = _prefixId.prefix "53_UrbanToledo"
    let _54_CatedralToledo = _prefixId.prefix "54_CatedralToledo"
    let _54_FiraPamplona = _prefixId.prefix "54_FiraPamplona"
    let _54_HotelPalaceToledo = _prefixId.prefix "54_HotelPalaceToledo"
    let ``_54_MetroM%C3%A0laga`` = _prefixId.prefix "54_MetroM%C3%A0laga"
    let _54_RestaurantSaborSevilla = _prefixId.prefix "54_RestaurantSaborSevilla"
    let _55_FiraSaragossa = _prefixId.prefix "55_FiraSaragossa"
    let _55_HotelVistaCadis = _prefixId.prefix "55_HotelVistaCadis"
    let _55_MoviToledo = _prefixId.prefix "55_MoviToledo"
    let _55_ParcSaragossa = _prefixId.prefix "55_ParcSaragossa"

    let ``_55_RestaurantFusi%C3%B3M%C3%A0laga`` =
        _prefixId.prefix "55_RestaurantFusi%C3%B3M%C3%A0laga"

    let _56_FestivalBarcelona = _prefixId.prefix "56_FestivalBarcelona"
    let _56_HotelDelMarCadis = _prefixId.prefix "56_HotelDelMarCadis"
    let _56_MuseuToledo = _prefixId.prefix "56_MuseuToledo"

    let ``_56_RestaurantTradici%C3%B3Madrid`` =
        _prefixId.prefix "56_RestaurantTradici%C3%B3Madrid"

    let ``_56_TransVal%C3%A8ncia`` = _prefixId.prefix "56_TransVal%C3%A8ncia"
    let ``_57_Congr%C3%A9sBarcelona`` = _prefixId.prefix "57_Congr%C3%A9sBarcelona"
    let _57_HotelSolSevilla = _prefixId.prefix "57_HotelSolSevilla"
    let ``_57_MoviVal%C3%A8ncia`` = _prefixId.prefix "57_MoviVal%C3%A8ncia"
    let _57_ParcCadis = _prefixId.prefix "57_ParcCadis"

    let ``_57_RestaurantGourmetM%C3%A0laga`` =
        _prefixId.prefix "57_RestaurantGourmetM%C3%A0laga"

    let _58_CarnavalSevilla = _prefixId.prefix "58_CarnavalSevilla"
    let ``_58_CatedralM%C3%A0laga`` = _prefixId.prefix "58_CatedralM%C3%A0laga"
    let _58_HotelDelMarSevilla = _prefixId.prefix "58_HotelDelMarSevilla"
    let _58_MoviPamplona = _prefixId.prefix "58_MoviPamplona"

    let _58_RestaurantDeliciaSaragossa =
        _prefixId.prefix "58_RestaurantDeliciaSaragossa"

    let _59_CatedralBilbao = _prefixId.prefix "59_CatedralBilbao"
    let ``_59_FestivalM%C3%A0laga`` = _prefixId.prefix "59_FestivalM%C3%A0laga"

    let ``_59_HotelVistaSantSebasti%C3%A0`` =
        _prefixId.prefix "59_HotelVistaSantSebasti%C3%A0"

    let ``_59_MetroSantSebasti%C3%A0`` = _prefixId.prefix "59_MetroSantSebasti%C3%A0"

    let ``_59_RestaurantFusi%C3%B3Cadis`` =
        _prefixId.prefix "59_RestaurantFusi%C3%B3Cadis"

    let _5_CastellCadis = _prefixId.prefix "5_CastellCadis"
    let _5_FiraToledo = _prefixId.prefix "5_FiraToledo"
    let _5_HotelPalaceSaragossa = _prefixId.prefix "5_HotelPalaceSaragossa"
    let _5_MoviCadis = _prefixId.prefix "5_MoviCadis"
    let _5_RestaurantDeliciaPamplona = _prefixId.prefix "5_RestaurantDeliciaPamplona"
    let _60_FiraSevilla = _prefixId.prefix "60_FiraSevilla"
    let _60_HotelDelMarBarcelona = _prefixId.prefix "60_HotelDelMarBarcelona"
    let _60_ParcCadis = _prefixId.prefix "60_ParcCadis"

    let ``_60_RestaurantDeliciaSantSebasti%C3%A0`` =
        _prefixId.prefix "60_RestaurantDeliciaSantSebasti%C3%A0"

    let _60_UrbanMadrid = _prefixId.prefix "60_UrbanMadrid"
    let _61_CarnavalToledo = _prefixId.prefix "61_CarnavalToledo"
    let _61_HotelDelMarCadis = _prefixId.prefix "61_HotelDelMarCadis"
    let _61_MetroBilbao = _prefixId.prefix "61_MetroBilbao"
    let _61_PalauSaragossa = _prefixId.prefix "61_PalauSaragossa"
    let _61_RestaurantGourmetMadrid = _prefixId.prefix "61_RestaurantGourmetMadrid"
    let _62_CarnavalCadis = _prefixId.prefix "62_CarnavalCadis"
    let ``_62_CatedralVal%C3%A8ncia`` = _prefixId.prefix "62_CatedralVal%C3%A8ncia"
    let _62_CityCadis = _prefixId.prefix "62_CityCadis"
    let _62_HotelPalaceBarcelona = _prefixId.prefix "62_HotelPalaceBarcelona"

    let ``_62_RestaurantTradici%C3%B3SantSebasti%C3%A0`` =
        _prefixId.prefix "62_RestaurantTradici%C3%B3SantSebasti%C3%A0"

    let ``_63_FiraM%C3%A0laga`` = _prefixId.prefix "63_FiraM%C3%A0laga"
    let _63_HotelSolBarcelona = _prefixId.prefix "63_HotelSolBarcelona"
    let ``_63_MetroM%C3%A0laga`` = _prefixId.prefix "63_MetroM%C3%A0laga"
    let _63_MuseuSaragossa = _prefixId.prefix "63_MuseuSaragossa"

    let ``_63_RestaurantTradici%C3%B3Cadis`` =
        _prefixId.prefix "63_RestaurantTradici%C3%B3Cadis"

    let _64_CityBarcelona = _prefixId.prefix "64_CityBarcelona"
    let _64_FiraMadrid = _prefixId.prefix "64_FiraMadrid"
    let _64_HotelPalaceBarcelona = _prefixId.prefix "64_HotelPalaceBarcelona"
    let ``_64_MuseuSantSebasti%C3%A0`` = _prefixId.prefix "64_MuseuSantSebasti%C3%A0"

    let ``_64_RestaurantTradici%C3%B3M%C3%A0laga`` =
        _prefixId.prefix "64_RestaurantTradici%C3%B3M%C3%A0laga"

    let _65_CarnavalBarcelona = _prefixId.prefix "65_CarnavalBarcelona"
    let _65_HotelPalaceToledo = _prefixId.prefix "65_HotelPalaceToledo"
    let ``_65_ParcM%C3%A0laga`` = _prefixId.prefix "65_ParcM%C3%A0laga"

    let ``_65_RestaurantGourmetM%C3%A0laga`` =
        _prefixId.prefix "65_RestaurantGourmetM%C3%A0laga"

    let _65_UrbanPamplona = _prefixId.prefix "65_UrbanPamplona"
    let ``_66_FestivalVal%C3%A8ncia`` = _prefixId.prefix "66_FestivalVal%C3%A8ncia"
    let _66_HotelSolMadrid = _prefixId.prefix "66_HotelSolMadrid"
    let _66_MetroSevilla = _prefixId.prefix "66_MetroSevilla"
    let ``_66_MuseuSantSebasti%C3%A0`` = _prefixId.prefix "66_MuseuSantSebasti%C3%A0"

    let ``_66_RestaurantFusi%C3%B3Barcelona`` =
        _prefixId.prefix "66_RestaurantFusi%C3%B3Barcelona"

    let _67_ConcertToledo = _prefixId.prefix "67_ConcertToledo"
    let _67_HotelVistaMadrid = _prefixId.prefix "67_HotelVistaMadrid"
    let _67_MetroToledo = _prefixId.prefix "67_MetroToledo"
    let _67_ParcCadis = _prefixId.prefix "67_ParcCadis"

    let ``_67_RestaurantFusi%C3%B3Toledo`` =
        _prefixId.prefix "67_RestaurantFusi%C3%B3Toledo"

    let _68_CastellMadrid = _prefixId.prefix "68_CastellMadrid"
    let _68_FiraPamplona = _prefixId.prefix "68_FiraPamplona"
    let _68_HotelDelMarMadrid = _prefixId.prefix "68_HotelDelMarMadrid"
    let ``_68_TransM%C3%A0laga`` = _prefixId.prefix "68_TransM%C3%A0laga"
    let _68_estaurantGourmetBarcelona = _prefixId.prefix "68_estaurantGourmetBarcelona"
    let ``_69_Congr%C3%A9sSaragossa`` = _prefixId.prefix "69_Congr%C3%A9sSaragossa"
    let _69_HotelRoyalMadrid = _prefixId.prefix "69_HotelRoyalMadrid"
    let _69_MetroPamplona = _prefixId.prefix "69_MetroPamplona"
    let _69_ParcCadis = _prefixId.prefix "69_ParcCadis"

    let _69_RestaurantGourmetBarcelona =
        _prefixId.prefix "69_RestaurantGourmetBarcelona"

    let ``_6_Congr%C3%A9sBilbao`` = _prefixId.prefix "6_Congr%C3%A9sBilbao"

    let ``_6_HotelRoyalSantSebasti%C3%A0`` =
        _prefixId.prefix "6_HotelRoyalSantSebasti%C3%A0"

    let _6_PalauBilbao = _prefixId.prefix "6_PalauBilbao"
    let _6_RestaurantSaborSevilla = _prefixId.prefix "6_RestaurantSaborSevilla"
    let _6_TransPamplona = _prefixId.prefix "6_TransPamplona"
    let _70_CastellPamplona = _prefixId.prefix "70_CastellPamplona"
    let ``_70_Congr%C3%A9sSaragossa`` = _prefixId.prefix "70_Congr%C3%A9sSaragossa"
    let _70_HotelRoyalSaragossa = _prefixId.prefix "70_HotelRoyalSaragossa"

    let ``_70_RestaurantFusi%C3%B3Saragossa`` =
        _prefixId.prefix "70_RestaurantFusi%C3%B3Saragossa"

    let _70_UrbanBilbao = _prefixId.prefix "70_UrbanBilbao"
    let ``_71_FiraM%C3%A0laga`` = _prefixId.prefix "71_FiraM%C3%A0laga"
    let ``_71_HotelDelMarM%C3%A0laga`` = _prefixId.prefix "71_HotelDelMarM%C3%A0laga"
    let _71_MoviBarcelona = _prefixId.prefix "71_MoviBarcelona"
    let _71_ParcMadrid = _prefixId.prefix "71_ParcMadrid"

    let ``_71_RestaurantTradici%C3%B3Cadis`` =
        _prefixId.prefix "71_RestaurantTradici%C3%B3Cadis"

    let _72_FiraCadis = _prefixId.prefix "72_FiraCadis"
    let _72_HotelDelMarSaragossa = _prefixId.prefix "72_HotelDelMarSaragossa"
    let ``_72_ParcVal%C3%A8ncia`` = _prefixId.prefix "72_ParcVal%C3%A8ncia"

    let ``_72_RestaurantFusi%C3%B3Bilbao`` =
        _prefixId.prefix "72_RestaurantFusi%C3%B3Bilbao"

    let _72_UrbanSevilla = _prefixId.prefix "72_UrbanSevilla"

    let ``_73_CarnavalSantSebasti%C3%A0`` =
        _prefixId.prefix "73_CarnavalSantSebasti%C3%A0"

    let ``_73_CatedralVal%C3%A8ncia`` = _prefixId.prefix "73_CatedralVal%C3%A8ncia"

    let ``_73_HotelVistaSantSebasti%C3%A0`` =
        _prefixId.prefix "73_HotelVistaSantSebasti%C3%A0"

    let ``_73_RestaurantGourmetVal%C3%A8ncia`` =
        _prefixId.prefix "73_RestaurantGourmetVal%C3%A8ncia"

    let _73_TransCadis = _prefixId.prefix "73_TransCadis"
    let ``_74_CarnavalM%C3%A0laga`` = _prefixId.prefix "74_CarnavalM%C3%A0laga"
    let _74_HotelPalacePamplona = _prefixId.prefix "74_HotelPalacePamplona"
    let _74_PalauMadrid = _prefixId.prefix "74_PalauMadrid"
    let _74_RestaurantGourmetPamplona = _prefixId.prefix "74_RestaurantGourmetPamplona"
    let _74_UrbanSevilla = _prefixId.prefix "74_UrbanSevilla"
    let _75_CatedralToledo = _prefixId.prefix "75_CatedralToledo"
    let _75_FiraSevilla = _prefixId.prefix "75_FiraSevilla"
    let _75_HotelRoyalMadrid = _prefixId.prefix "75_HotelRoyalMadrid"
    let _75_MetroPamplona = _prefixId.prefix "75_MetroPamplona"
    let _75_RestaurantSaborSevilla = _prefixId.prefix "75_RestaurantSaborSevilla"
    let _76_CityMadrid = _prefixId.prefix "76_CityMadrid"
    let ``_76_ConcertM%C3%A0laga`` = _prefixId.prefix "76_ConcertM%C3%A0laga"
    let _76_HotelVistaBarcelona = _prefixId.prefix "76_HotelVistaBarcelona"
    let _76_PalauBarcelona = _prefixId.prefix "76_PalauBarcelona"

    let ``_76_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefixId.prefix "76_RestaurantFusi%C3%B3Val%C3%A8ncia"

    let _77_FestivalToledo = _prefixId.prefix "77_FestivalToledo"
    let _77_HotelSolBarcelona = _prefixId.prefix "77_HotelSolBarcelona"
    let _77_MetroMadrid = _prefixId.prefix "77_MetroMadrid"
    let _77_PalauPamplona = _prefixId.prefix "77_PalauPamplona"
    let _77_RestaurantDeliciaSevilla = _prefixId.prefix "77_RestaurantDeliciaSevilla"
    let _78_CarnavalCadis = _prefixId.prefix "78_CarnavalCadis"
    let _78_CastellBilbao = _prefixId.prefix "78_CastellBilbao"
    let _78_HotelRoyalBilbao = _prefixId.prefix "78_HotelRoyalBilbao"
    let _78_MoviBilbao = _prefixId.prefix "78_MoviBilbao"

    let ``_78_RestaurantFusi%C3%B3Val%C3%A8ncia`` =
        _prefixId.prefix "78_RestaurantFusi%C3%B3Val%C3%A8ncia"

    let _79_CatedralPamplona = _prefixId.prefix "79_CatedralPamplona"
    let ``_79_Congr%C3%A9sCadis`` = _prefixId.prefix "79_Congr%C3%A9sCadis"
    let ``_79_HotelSolM%C3%A0laga`` = _prefixId.prefix "79_HotelSolM%C3%A0laga"

    let ``_79_RestaurantSaborM%C3%A0laga`` =
        _prefixId.prefix "79_RestaurantSaborM%C3%A0laga"

    let _79_TransSevilla = _prefixId.prefix "79_TransSevilla"
    let _7_CatedralSevilla = _prefixId.prefix "7_CatedralSevilla"
    let _7_FestivalMadrid = _prefixId.prefix "7_FestivalMadrid"
    let ``_7_HotelRoyalVal%C3%A8ncia`` = _prefixId.prefix "7_HotelRoyalVal%C3%A8ncia"
    let _7_MetroCadis = _prefixId.prefix "7_MetroCadis"
    let _7_RestaurantGourmetSaragossa = _prefixId.prefix "7_RestaurantGourmetSaragossa"
    let ``_80_ConcertM%C3%A0laga`` = _prefixId.prefix "80_ConcertM%C3%A0laga"

    let ``_80_HotelVistaSantSebasti%C3%A0`` =
        _prefixId.prefix "80_HotelVistaSantSebasti%C3%A0"

    let _80_ParcMadrid = _prefixId.prefix "80_ParcMadrid"
    let _80_RestaurantGourmetPamplona = _prefixId.prefix "80_RestaurantGourmetPamplona"
    let _80_TransPamplona = _prefixId.prefix "80_TransPamplona"
    let _81_CityBilbao = _prefixId.prefix "81_CityBilbao"
    let ``_81_Congr%C3%A9sToledo`` = _prefixId.prefix "81_Congr%C3%A9sToledo"
    let _81_HotelVistaBarcelona = _prefixId.prefix "81_HotelVistaBarcelona"
    let _81_ParcSevilla = _prefixId.prefix "81_ParcSevilla"

    let ``_81_RestaurantGourmetSantSebasti%C3%A0`` =
        _prefixId.prefix "81_RestaurantGourmetSantSebasti%C3%A0"

    let _82_CityMadrid = _prefixId.prefix "82_CityMadrid"
    let ``_82_Congr%C3%A9sToledo`` = _prefixId.prefix "82_Congr%C3%A9sToledo"
    let _82_HotelPalaceBilbao = _prefixId.prefix "82_HotelPalaceBilbao"
    let ``_82_PalauVal%C3%A8ncia`` = _prefixId.prefix "82_PalauVal%C3%A8ncia"
    let _82_RestaurantGourmetMadrid = _prefixId.prefix "82_RestaurantGourmetMadrid"
    let ``_83_CastellM%C3%A0laga`` = _prefixId.prefix "83_CastellM%C3%A0laga"
    let _83_CityToledo = _prefixId.prefix "83_CityToledo"
    let _83_ConcertCadis = _prefixId.prefix "83_ConcertCadis"
    let _83_HotelPalaceCadis = _prefixId.prefix "83_HotelPalaceCadis"
    let _83_RestaurantDeliciaBilbao = _prefixId.prefix "83_RestaurantDeliciaBilbao"
    let _84_CastellPamplona = _prefixId.prefix "84_CastellPamplona"
    let _84_FestivalSaragossa = _prefixId.prefix "84_FestivalSaragossa"
    let _84_HotelVistaMadrid = _prefixId.prefix "84_HotelVistaMadrid"

    let ``_84_RestaurantFusi%C3%B3Pamplona`` =
        _prefixId.prefix "84_RestaurantFusi%C3%B3Pamplona"

    let ``_84_TransSantSebasti%C3%A0`` = _prefixId.prefix "84_TransSantSebasti%C3%A0"
    let _85_CastellPamplona = _prefixId.prefix "85_CastellPamplona"

    let ``_85_FestivalSantSebasti%C3%A0`` =
        _prefixId.prefix "85_FestivalSantSebasti%C3%A0"

    let _85_HotelPalaceMadrid = _prefixId.prefix "85_HotelPalaceMadrid"
    let _85_MoviSevilla = _prefixId.prefix "85_MoviSevilla"

    let ``_85_RestaurantFusi%C3%B3Madrid`` =
        _prefixId.prefix "85_RestaurantFusi%C3%B3Madrid"

    let _86_CitySevilla = _prefixId.prefix "86_CitySevilla"
    let _86_FiraToledo = _prefixId.prefix "86_FiraToledo"
    let _86_HotelVistaToledo = _prefixId.prefix "86_HotelVistaToledo"
    let _86_MuseuSaragossa = _prefixId.prefix "86_MuseuSaragossa"

    let ``_86_RestaurantFusi%C3%B3Cadis`` =
        _prefixId.prefix "86_RestaurantFusi%C3%B3Cadis"

    let _87_FestivalMadrid = _prefixId.prefix "87_FestivalMadrid"

    let ``_87_HotelSolSantSebasti%C3%A0`` =
        _prefixId.prefix "87_HotelSolSantSebasti%C3%A0"

    let _87_MoviBarcelona = _prefixId.prefix "87_MoviBarcelona"
    let ``_87_ParcSantSebasti%C3%A0`` = _prefixId.prefix "87_ParcSantSebasti%C3%A0"

    let ``_87_RestaurantSaborVal%C3%A8ncia`` =
        _prefixId.prefix "87_RestaurantSaborVal%C3%A8ncia"

    let _88_FestivalToledo = _prefixId.prefix "88_FestivalToledo"
    let _88_HotelVistaBarcelona = _prefixId.prefix "88_HotelVistaBarcelona"
    let _88_PalauToledo = _prefixId.prefix "88_PalauToledo"

    let ``_88_RestaurantFusi%C3%B3Barcelona`` =
        _prefixId.prefix "88_RestaurantFusi%C3%B3Barcelona"

    let _88_TransSaragossa = _prefixId.prefix "88_TransSaragossa"
    let _89_CastellSaragossa = _prefixId.prefix "89_CastellSaragossa"
    let _89_FiraSaragossa = _prefixId.prefix "89_FiraSaragossa"
    let _89_HotelVistaBilbao = _prefixId.prefix "89_HotelVistaBilbao"

    let ``_89_RestaurantGourmetM%C3%A0laga`` =
        _prefixId.prefix "89_RestaurantGourmetM%C3%A0laga"

    let ``_89_UrbanVal%C3%A8ncia`` = _prefixId.prefix "89_UrbanVal%C3%A8ncia"
    let _8_CityMadrid = _prefixId.prefix "8_CityMadrid"
    let ``_8_FiraM%C3%A0laga`` = _prefixId.prefix "8_FiraM%C3%A0laga"
    let _8_HotelVistaCadis = _prefixId.prefix "8_HotelVistaCadis"
    let ``_8_ParcSantSebasti%C3%A0`` = _prefixId.prefix "8_ParcSantSebasti%C3%A0"
    let _8_RestaurantGourmetToledo = _prefixId.prefix "8_RestaurantGourmetToledo"
    let _90_CitySaragossa = _prefixId.prefix "90_CitySaragossa"

    let ``_90_Congr%C3%A9sVal%C3%A8ncia`` =
        _prefixId.prefix "90_Congr%C3%A9sVal%C3%A8ncia"

    let _90_HotelDelMarSevilla = _prefixId.prefix "90_HotelDelMarSevilla"
    let _90_MuseuPamplona = _prefixId.prefix "90_MuseuPamplona"

    let _90_RestaurantDeliciaSaragossa =
        _prefixId.prefix "90_RestaurantDeliciaSaragossa"

    let _91_CarnavalMadrid = _prefixId.prefix "91_CarnavalMadrid"
    let _91_CatedralSevilla = _prefixId.prefix "91_CatedralSevilla"

    let ``_91_HotelDelMarVal%C3%A8ncia`` =
        _prefixId.prefix "91_HotelDelMarVal%C3%A8ncia"

    let _91_RestaurantGourmetSaragossa =
        _prefixId.prefix "91_RestaurantGourmetSaragossa"

    let _91_UrbanBilbao = _prefixId.prefix "91_UrbanBilbao"
    let _92_FestivalCadis = _prefixId.prefix "92_FestivalCadis"
    let ``_92_HotelRoyalM%C3%A0laga`` = _prefixId.prefix "92_HotelRoyalM%C3%A0laga"
    let _92_MetroMadrid = _prefixId.prefix "92_MetroMadrid"
    let _92_MuseuCadis = _prefixId.prefix "92_MuseuCadis"
    let _92_RestaurantGourmetPamplona = _prefixId.prefix "92_RestaurantGourmetPamplona"
    let _93_ConcertCadis = _prefixId.prefix "93_ConcertCadis"
    let _93_HotelDelMarMadrid = _prefixId.prefix "93_HotelDelMarMadrid"
    let _93_ParcToledo = _prefixId.prefix "93_ParcToledo"
    let _93_RestaurantSaborSaragossa = _prefixId.prefix "93_RestaurantSaborSaragossa"
    let ``_93_TransVal%C3%A8ncia`` = _prefixId.prefix "93_TransVal%C3%A8ncia"
    let _94_CatedralToledo = _prefixId.prefix "94_CatedralToledo"
    let _94_FestivalMadrid = _prefixId.prefix "94_FestivalMadrid"
    let _94_HotelVistaBilbao = _prefixId.prefix "94_HotelVistaBilbao"
    let ``_94_MoviM%C3%A0laga`` = _prefixId.prefix "94_MoviM%C3%A0laga"

    let ``_94_RestaurantTradici%C3%B3Sevilla`` =
        _prefixId.prefix "94_RestaurantTradici%C3%B3Sevilla"

    let ``_95_CatedralVal%C3%A8ncia`` = _prefixId.prefix "95_CatedralVal%C3%A8ncia"
    let _95_ConcertSaragossa = _prefixId.prefix "95_ConcertSaragossa"
    let _95_HotelPalacePamplona = _prefixId.prefix "95_HotelPalacePamplona"

    let ``_95_RestaurantTradici%C3%B3Sevilla`` =
        _prefixId.prefix "95_RestaurantTradici%C3%B3Sevilla"

    let _95_TransMadrid = _prefixId.prefix "95_TransMadrid"
    let ``_96_Congr%C3%A9sBarcelona`` = _prefixId.prefix "96_Congr%C3%A9sBarcelona"
    let _96_HotelVistaPamplona = _prefixId.prefix "96_HotelVistaPamplona"
    let _96_MuseuMadrid = _prefixId.prefix "96_MuseuMadrid"

    let ``_96_RestaurantTradici%C3%B3Madrid`` =
        _prefixId.prefix "96_RestaurantTradici%C3%B3Madrid"

    let _96_TransSaragossa = _prefixId.prefix "96_TransSaragossa"
    let _97_CarnavalBilbao = _prefixId.prefix "97_CarnavalBilbao"
    let _97_CatedralSaragossa = _prefixId.prefix "97_CatedralSaragossa"
    let ``_97_HotelPalaceM%C3%A0laga`` = _prefixId.prefix "97_HotelPalaceM%C3%A0laga"

    let ``_97_RestaurantFusi%C3%B3Saragossa`` =
        _prefixId.prefix "97_RestaurantFusi%C3%B3Saragossa"

    let _97_TransCadis = _prefixId.prefix "97_TransCadis"
    let _98_CityPamplona = _prefixId.prefix "98_CityPamplona"
    let ``_98_Congr%C3%A9sSaragossa`` = _prefixId.prefix "98_Congr%C3%A9sSaragossa"
    let _98_HotelPalaceMadrid = _prefixId.prefix "98_HotelPalaceMadrid"
    let _98_ParcCadis = _prefixId.prefix "98_ParcCadis"
    let _98_RestaurantDeliciaSevilla = _prefixId.prefix "98_RestaurantDeliciaSevilla"
    let _99_CatedralBilbao = _prefixId.prefix "99_CatedralBilbao"
    let _99_FiraSevilla = _prefixId.prefix "99_FiraSevilla"
    let _99_HotelSolSevilla = _prefixId.prefix "99_HotelSolSevilla"
    let ``_99_MetroSantSebasti%C3%A0`` = _prefixId.prefix "99_MetroSantSebasti%C3%A0"

    let ``_99_RestaurantGourmetVal%C3%A8ncia`` =
        _prefixId.prefix "99_RestaurantGourmetVal%C3%A8ncia"

    let _9_CatedralPamplona = _prefixId.prefix "9_CatedralPamplona"

    let ``_9_Congr%C3%A9sSantSebasti%C3%A0`` =
        _prefixId.prefix "9_Congr%C3%A9sSantSebasti%C3%A0"

    let _9_HotelRoyalBarcelona = _prefixId.prefix "9_HotelRoyalBarcelona"
    let _9_MetroBarcelona = _prefixId.prefix "9_MetroBarcelona"

    let ``_9_RestaurantDeliciaM%C3%A0laga`` =
        _prefixId.prefix "9_RestaurantDeliciaM%C3%A0laga"

    let Andalusian = _prefixId.prefix "Andalusian"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : AndalusianRestaurant</para>
    ///   <para>rdfs:comment : Refers to restaurants serving food from Andalusia</para>
    ///   <a href="https://purl.org/cityexplorer#AndalusianRestaurant">ce:AndalusianRestaurant</a>
    /// </summary>
    let AndalusianRestaurant = _prefixId.prefix "AndalusianRestaurant"
    /// <summary>
    ///   <para>rdfs:comment : Refers to an attraction type, which can be cultural, park, etc.</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:sameAs : https://schema.org/Attraction</para>
    ///   <para>rdfs:label : Attraction</para>
    ///   <a href="https://purl.org/cityexplorer#Attraction">ce:Attraction</a>
    /// </summary>
    let Attraction = _prefixId.prefix "Attraction"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : AttractionCategory</para>
    ///   <para>rdfs:comment : Includes different attraction categories</para>
    ///   <a href="https://purl.org/cityexplorer#AttractionCategory">ce:AttractionCategory</a>
    /// </summary>
    let AttractionCategory = _prefixId.prefix "AttractionCategory"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : AttractionType</para>
    ///   <para>rdfs:comment : Refers to the category of attractions</para>
    ///   <a href="https://purl.org/cityexplorer#AttractionTypes">ce:AttractionTypes</a>
    /// </summary>
    let AttractionTypes = _prefixId.prefix "AttractionTypes"
    let Barcelona = _prefixId.prefix "Barcelona"
    let Beach = _prefixId.prefix "Beach"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : BeachAttraction</para>
    ///   <para>rdfs:comment : Refers to attractions involving a beach</para>
    ///   <a href="https://purl.org/cityexplorer#BeachAttraction">ce:BeachAttraction</a>
    /// </summary>
    let BeachAttraction = _prefixId.prefix "BeachAttraction"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : BeachCities</para>
    ///   <para>rdfs:comment : Refers to cities located at the beach</para>
    ///   <a href="https://purl.org/cityexplorer#BeachCities">ce:BeachCities</a>
    /// </summary>
    let BeachCities = _prefixId.prefix "BeachCities"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : BeachHotel</para>
    ///   <para>rdfs:comment : Refers to hotels at the beach</para>
    ///   <a href="https://purl.org/cityexplorer#BeachHotel">ce:BeachHotel</a>
    /// </summary>
    let BeachHotel = _prefixId.prefix "BeachHotel"
    let Bilbao = _prefixId.prefix "Bilbao"
    let Bus = _prefixId.prefix "Bus"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : BusTransport</para>
    ///   <para>rdfs:comment : Refers to bus transport</para>
    ///   <a href="https://purl.org/cityexplorer#BusTransport">ce:BusTransport</a>
    /// </summary>
    let BusTransport = _prefixId.prefix "BusTransport"
    let Business = _prefixId.prefix "Business"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : BusinessHotel</para>
    ///   <para>rdfs:comment : Refers to hotels considered for business</para>
    ///   <a href="https://purl.org/cityexplorer#BusinessHotel">ce:BusinessHotel</a>
    /// </summary>
    let BusinessHotel = _prefixId.prefix "BusinessHotel"
    let Cadis = _prefixId.prefix "Cadis"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Category</para>
    ///   <para>rdfs:comment : Global category, including different categories</para>
    ///   <a href="https://purl.org/cityexplorer#Category">ce:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : CategoryTypes</para>
    ///   <para>rdfs:comment : Refers to different types of categories</para>
    ///   <a href="https://purl.org/cityexplorer#CategoryTypes">ce:CategoryTypes</a>
    /// </summary>
    let CategoryTypes = _prefixId.prefix "CategoryTypes"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>owl:equivalentClass : https://schema.org/City</para>
    ///   <para>rdfs:label : City</para>
    ///   <para>rdfs:comment : Refers to a city</para>
    ///   <a href="https://purl.org/cityexplorer#City">ce:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    let Cultural = _prefixId.prefix "Cultural"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : CulturalAttraction</para>
    ///   <para>rdfs:comment : Refers to attractions involving any kind of cultural activity</para>
    ///   <a href="https://purl.org/cityexplorer#CulturalAttraction">ce:CulturalAttraction</a>
    /// </summary>
    let CulturalAttraction = _prefixId.prefix "CulturalAttraction"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : CulturalCities</para>
    ///   <para>rdfs:comment : Refers to cities with cultural interest</para>
    ///   <a href="https://purl.org/cityexplorer#CulturalCities">ce:CulturalCities</a>
    /// </summary>
    let CulturalCities = _prefixId.prefix "CulturalCities"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : CulturalEvent</para>
    ///   <para>rdfs:comment : Refers to an event involving any kind of cultural activity</para>
    ///   <a href="https://purl.org/cityexplorer#CulturalEvent">ce:CulturalEvent</a>
    /// </summary>
    let CulturalEvent = _prefixId.prefix "CulturalEvent"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : Refers to an event</para>
    ///   <a href="https://purl.org/cityexplorer#Event">ce:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : EventCategory</para>
    ///   <para>rdfs:comment : Includes different event categories</para>
    ///   <a href="https://purl.org/cityexplorer#EventCategory">ce:EventCategory</a>
    /// </summary>
    let EventCategory = _prefixId.prefix "EventCategory"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : EventTypes</para>
    ///   <para>rdfs:comment : Refers to the category of events</para>
    ///   <a href="https://purl.org/cityexplorer#EventTypes">ce:EventTypes</a>
    /// </summary>
    let EventTypes = _prefixId.prefix "EventTypes"
    let Gastronomic = _prefixId.prefix "Gastronomic"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : GastronomicEvent</para>
    ///   <para>rdfs:comment : Refers to an event involving gastronomy</para>
    ///   <a href="https://purl.org/cityexplorer#GastronomicEvent">ce:GastronomicEvent</a>
    /// </summary>
    let GastronomicEvent = _prefixId.prefix "GastronomicEvent"
    /// <summary>
    ///   <para>rdfs:label : Hotel</para>
    ///   <para>rdfs:comment : Refers to an hotel</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:sameAs : https://schema.org/Hotel^^xsd:string</para>
    ///   <a href="https://purl.org/cityexplorer#Hotel">ce:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : HotelCategory</para>
    ///   <para>rdfs:comment : Includes different hotel categories</para>
    ///   <a href="https://purl.org/cityexplorer#HotelCategory">ce:HotelCategory</a>
    /// </summary>
    let HotelCategory = _prefixId.prefix "HotelCategory"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : HotelTypes</para>
    ///   <para>rdfs:comment : Refers to the category of hotels</para>
    ///   <a href="https://purl.org/cityexplorer#HotelTypes">ce:HotelTypes</a>
    /// </summary>
    let HotelTypes = _prefixId.prefix "HotelTypes"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : ItalianRestaurant</para>
    ///   <para>rdfs:comment : Refers to restaurants serving food from Italy</para>
    ///   <a href="https://purl.org/cityexplorer#ItalianRestaurant">ce:ItalianRestaurant</a>
    /// </summary>
    let ItalianRestaurant = _prefixId.prefix "ItalianRestaurant"
    let Italianian = _prefixId.prefix "Italianian"
    let Japanese = _prefixId.prefix "Japanese"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : JapaneseRestaurant</para>
    ///   <para>rdfs:comment : Refers to restaurants serving food from Japan</para>
    ///   <a href="https://purl.org/cityexplorer#JapaneseRestaurant">ce:JapaneseRestaurant</a>
    /// </summary>
    let JapaneseRestaurant = _prefixId.prefix "JapaneseRestaurant"
    let Luxury = _prefixId.prefix "Luxury"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : LuxuryHotel</para>
    ///   <para>rdfs:comment : Refers to hotels considered luxurious</para>
    ///   <a href="https://purl.org/cityexplorer#LuxuryHotel">ce:LuxuryHotel</a>
    /// </summary>
    let LuxuryHotel = _prefixId.prefix "LuxuryHotel"
    let ``M%C3%A0laga`` = _prefixId.prefix "M%C3%A0laga"
    let Madrid = _prefixId.prefix "Madrid"
    let Mediterranean = _prefixId.prefix "Mediterranean"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MediterraneanHotel</para>
    ///   <para>rdfs:comment : Refers to restaurants serving mediterranean food</para>
    ///   <a href="https://purl.org/cityexplorer#MediterraneanRestaurant">ce:MediterraneanRestaurant</a>
    /// </summary>
    let MediterraneanRestaurant = _prefixId.prefix "MediterraneanRestaurant"
    let Metro = _prefixId.prefix "Metro"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MetroTransport</para>
    ///   <para>rdfs:comment : Refers to metro transport</para>
    ///   <a href="https://purl.org/cityexplorer#MetroTransport">ce:MetroTransport</a>
    /// </summary>
    let MetroTransport = _prefixId.prefix "MetroTransport"
    let Mexican = _prefixId.prefix "Mexican"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MexicanRestaurant</para>
    ///   <para>rdfs:comment : Refers to restaurants serving food from Mexico</para>
    ///   <a href="https://purl.org/cityexplorer#MexicanRestaurant">ce:MexicanRestaurant</a>
    /// </summary>
    let MexicanRestaurant = _prefixId.prefix "MexicanRestaurant"
    let Monument = _prefixId.prefix "Monument"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MonumentAttraction</para>
    ///   <para>rdfs:comment : Refers to attractions involving a monument</para>
    ///   <a href="https://purl.org/cityexplorer#MonumentAttraction">ce:MonumentAttraction</a>
    /// </summary>
    let MonumentAttraction = _prefixId.prefix "MonumentAttraction"
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MuseumAttraction</para>
    ///   <para>rdfs:comment : Refers to attractions involving a museum</para>
    ///   <a href="https://purl.org/cityexplorer#MuseumAttraction">ce:MuseumAttraction</a>
    /// </summary>
    let MuseumAttraction = _prefixId.prefix "MuseumAttraction"
    let Music = _prefixId.prefix "Music"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : MusicEveent</para>
    ///   <para>rdfs:comment : Refers to an event involving music</para>
    ///   <a href="https://purl.org/cityexplorer#MusicEvent">ce:MusicEvent</a>
    /// </summary>
    let MusicEvent = _prefixId.prefix "MusicEvent"
    let Pamplona = _prefixId.prefix "Pamplona"
    let Park = _prefixId.prefix "Park"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : ParkAttraction</para>
    ///   <para>rdfs:comment : Refers to attractions involving a park</para>
    ///   <a href="https://purl.org/cityexplorer#ParkAttraction">ce:ParkAttraction</a>
    /// </summary>
    let ParkAttraction = _prefixId.prefix "ParkAttraction"
    let PublicBike = _prefixId.prefix "PublicBike"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : PublicBike</para>
    ///   <para>rdfs:comment : Refers to public bike transport</para>
    ///   <a href="https://purl.org/cityexplorer#PublicBikeTransport">ce:PublicBikeTransport</a>
    /// </summary>
    let PublicBikeTransport = _prefixId.prefix "PublicBikeTransport"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Recommendations</para>
    ///   <para>rdfs:isDefinedBy : https://schema.org/Recommendation</para>
    ///   <para>rdfs:comment : Base class to make searches based on rules</para>
    ///   <a href="https://purl.org/cityexplorer#Recommendation">ce:Recommendation</a>
    /// </summary>
    let Recommendation = _prefixId.prefix "Recommendation"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : RecommendedRestaurants</para>
    ///   <para>rdfs:comment : Refers to restaurants that are recommended</para>
    ///   <a href="https://purl.org/cityexplorer#RecommendedRestaurants">ce:RecommendedRestaurants</a>
    /// </summary>
    let RecommendedRestaurants = _prefixId.prefix "RecommendedRestaurants"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/Restaurant</para>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Refers to a restaurant</para>
    ///   <para>rdfs:label : Restaurant</para>
    ///   <a href="https://purl.org/cityexplorer#Restaurant">ce:Restaurant</a>
    /// </summary>
    let Restaurant = _prefixId.prefix "Restaurant"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : RestaurantCategory</para>
    ///   <para>rdfs:comment : Includes different restaurant categories</para>
    ///   <a href="https://purl.org/cityexplorer#RestaurantCategory">ce:RestaurantCategory</a>
    /// </summary>
    let RestaurantCategory = _prefixId.prefix "RestaurantCategory"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : RestaurantType</para>
    ///   <para>rdfs:comment : Refers to the category of restaurants</para>
    ///   <a href="https://purl.org/cityexplorer#RestaurantTypes">ce:RestaurantTypes</a>
    /// </summary>
    let RestaurantTypes = _prefixId.prefix "RestaurantTypes"
    let Rural = _prefixId.prefix "Rural"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : RuralHotel</para>
    ///   <para>rdfs:comment : Refers to hotels considered rural</para>
    ///   <a href="https://purl.org/cityexplorer#RuralHotel">ce:RuralHotel</a>
    /// </summary>
    let RuralHotel = _prefixId.prefix "RuralHotel"
    let ``SantSebasti%C3%A0`` = _prefixId.prefix "SantSebasti%C3%A0"
    let Saragossa = _prefixId.prefix "Saragossa"
    let Sevilla = _prefixId.prefix "Sevilla"
    let Sport = _prefixId.prefix "Sport"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : SportsEvent</para>
    ///   <para>rdfs:comment : Refers to an event involving sports</para>
    ///   <a href="https://purl.org/cityexplorer#SportsEvent">ce:SportsEvent</a>
    /// </summary>
    let SportsEvent = _prefixId.prefix "SportsEvent"
    let Taxi = _prefixId.prefix "Taxi"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TaxiTransport</para>
    ///   <para>rdfs:comment : Refers to taxi transport</para>
    ///   <a href="https://purl.org/cityexplorer#TaxiTransport">ce:TaxiTransport</a>
    /// </summary>
    let TaxiTransport = _prefixId.prefix "TaxiTransport"
    let Technological = _prefixId.prefix "Technological"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TechnologicalEvent</para>
    ///   <para>rdfs:comment : Refers to an event involving tecnology</para>
    ///   <a href="https://purl.org/cityexplorer#TechnologicalEvent">ce:TechnologicalEvent</a>
    /// </summary>
    let TechnologicalEvent = _prefixId.prefix "TechnologicalEvent"
    let Toledo = _prefixId.prefix "Toledo"
    let Tourist = _prefixId.prefix "Tourist"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TouristHotel</para>
    ///   <para>rdfs:comment : Refers to touristic hotels</para>
    ///   <a href="https://purl.org/cityexplorer#TouristHotel">ce:TouristHotel</a>
    /// </summary>
    let TouristHotel = _prefixId.prefix "TouristHotel"
    let Tram = _prefixId.prefix "Tram"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TramTransport</para>
    ///   <para>rdfs:comment : Refers to tram transport</para>
    ///   <a href="https://purl.org/cityexplorer#TramTransport">ce:TramTransport</a>
    /// </summary>
    let TramTransport = _prefixId.prefix "TramTransport"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : Transport</para>
    ///   <para>rdfs:comment : Refers to a way of transport</para>
    ///   <a href="https://purl.org/cityexplorer#Transport">ce:Transport</a>
    /// </summary>
    let Transport = _prefixId.prefix "Transport"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TransportCategory</para>
    ///   <para>rdfs:comment : Includes different attraction categories</para>
    ///   <a href="https://purl.org/cityexplorer#TransportCategory">ce:TransportCategory</a>
    /// </summary>
    let TransportCategory = _prefixId.prefix "TransportCategory"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : TransportType</para>
    ///   <para>rdfs:comment : Refers to the category of transports</para>
    ///   <a href="https://purl.org/cityexplorer#TransportTypes">ce:TransportTypes</a>
    /// </summary>
    let TransportTypes = _prefixId.prefix "TransportTypes"
    let ``Val%C3%A8ncia`` = _prefixId.prefix "Val%C3%A8ncia"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/aggregateRating</para>
    ///   <para>rdfs:label : aggregateRating</para>
    ///   <para>rdfs:comment : The overall rating, based on a collection of reviews or ratings, of the item</para>
    ///   <a href="https://purl.org/cityexplorer#aggregateRating">ce:aggregateRating</a>
    /// </summary>
    let aggregateRating = _prefixId.prefix "aggregateRating"
    /// <summary>
    ///   <para>rdfs:label : Company</para>
    ///   <para>rdfs:comment : The company of transport</para>
    ///   <a href="https://purl.org/cityexplorer#company">ce:company</a>
    /// </summary>
    let company = _prefixId.prefix "company"
    /// <summary>
    ///   <para>rdfs:label : hasCategory</para>
    ///   <para>rdfs:comment : Indicate if a class has a specific category</para>
    ///   <a href="https://purl.org/cityexplorer#hasCategory">ce:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/identifier</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : The identifier of the object (city, etc.)</para>
    ///   <a href="https://purl.org/cityexplorer#identifier">ce:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : isCategoryOf</para>
    ///   <para>rdfs:comment : Indicates if a category is a category of a class</para>
    ///   <a href="https://purl.org/cityexplorer#isCategoryOf">ce:isCategoryOf</a>
    /// </summary>
    let isCategoryOf = _prefixId.prefix "isCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : isCityOf</para>
    ///   <para>rdfs:comment : Indicates if the city contains the specific property</para>
    ///   <a href="https://purl.org/cityexplorer#isCityOf">ce:isCityOf</a>
    /// </summary>
    let isCityOf = _prefixId.prefix "isCityOf"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/latitude</para>
    ///   <para>rdfs:label : Latitude</para>
    ///   <para>rdfs:comment : The latitude of a location</para>
    ///   <a href="https://purl.org/cityexplorer#latitude">ce:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : locatedInCity</para>
    ///   <para>rdfs:comment : Indicates if it's located in a city</para>
    ///   <a href="https://purl.org/cityexplorer#locatedInCity">ce:locatedInCity</a>
    /// </summary>
    let locatedInCity = _prefixId.prefix "locatedInCity"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/longitude</para>
    ///   <para>rdfs:label : Longitude</para>
    ///   <para>rdfs:comment : The longitude of a location</para>
    ///   <a href="https://purl.org/cityexplorer#longitude">ce:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/name</para>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : The name of the item</para>
    ///   <a href="https://purl.org/cityexplorer#name">ce:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/priceRange</para>
    ///   <para>rdfs:label : priceRange</para>
    ///   <para>rdfs:comment : The price range of the business</para>
    ///   <a href="https://purl.org/cityexplorer#priceRange">ce:priceRange</a>
    /// </summary>
    let priceRange = _prefixId.prefix "priceRange"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/starRating</para>
    ///   <para>rdfs:label : starRating</para>
    ///   <para>rdfs:comment : An official rating for a lodging business or food establishment</para>
    ///   <a href="https://purl.org/cityexplorer#starRating">ce:starRating</a>
    /// </summary>
    let starRating = _prefixId.prefix "starRating"
    /// <summary>
    ///   <para>rdfs:sameAs : https://schema.org/startDate</para>
    ///   <para>rdfs:label : startDate</para>
    ///   <para>rdfs:comment : The start date and time of the item</para>
    ///   <a href="https://purl.org/cityexplorer#startDate">ce:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"

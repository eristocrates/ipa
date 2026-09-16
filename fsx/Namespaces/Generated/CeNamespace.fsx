#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ce =
    let _prefixId = PrefixId.fromNamespaceLabel "https://purl.org/cityexplorer#" "ce"
    let _namespaceIri = _prefixId.prefix ""
    let _100_FiraBarcelona = _prefixId.prefix "100_FiraBarcelona"
    let _100_HotelPalaceMàlaga = _prefixId.prefix "100_HotelPalaceMàlaga"
    let _100_MuseuBilbao = _prefixId.prefix "100_MuseuBilbao"
    let _100_RestaurantGourmetToledo = _prefixId.prefix "100_RestaurantGourmetToledo"
    let _100_TransPamplona = _prefixId.prefix "100_TransPamplona"
    let _10_CastellToledo = _prefixId.prefix "10_CastellToledo"
    let _10_CongrésBarcelona = _prefixId.prefix "10_CongrésBarcelona"
    let _10_HotelRoyalCadis = _prefixId.prefix "10_HotelRoyalCadis"
    let _10_RestaurantDeliciaCadis = _prefixId.prefix "10_RestaurantDeliciaCadis"
    let _10_TransSevilla = _prefixId.prefix "10_TransSevilla"
    let _11_CarnavalBilbao = _prefixId.prefix "11_CarnavalBilbao"
    let _11_HotelRoyalMadrid = _prefixId.prefix "11_HotelRoyalMadrid"
    let _11_ParcToledo = _prefixId.prefix "11_ParcToledo"
    let _11_RestaurantGourmetMadrid = _prefixId.prefix "11_RestaurantGourmetMadrid"
    let _11_TransValència = _prefixId.prefix "11_TransValència"
    let _12_CatedralCadis = _prefixId.prefix "12_CatedralCadis"
    let _12_CitySevilla = _prefixId.prefix "12_CitySevilla"
    let _12_FiraBarcelona = _prefixId.prefix "12_FiraBarcelona"
    let _12_HotelRoyalMadrid = _prefixId.prefix "12_HotelRoyalMadrid"
    let _12_RestaurantSaborCadis = _prefixId.prefix "12_RestaurantSaborCadis"
    let _13_CityCadis = _prefixId.prefix "13_CityCadis"
    let _13_CongrésValència = _prefixId.prefix "13_CongrésValència"
    let _13_HotelDelMarSevilla = _prefixId.prefix "13_HotelDelMarSevilla"
    let _13_PalauPamplona = _prefixId.prefix "13_PalauPamplona"

    let _13_RestaurantDeliciaSaragossa = _prefixId.prefix "13_RestaurantDeliciaSaragossa"

    let _14_CastellPamplona = _prefixId.prefix "14_CastellPamplona"
    let _14_CongrésToledo = _prefixId.prefix "14_CongrésToledo"
    let _14_HotelPalaceMadrid = _prefixId.prefix "14_HotelPalaceMadrid"
    let _14_MoviPamplona = _prefixId.prefix "14_MoviPamplona"
    let _14_RestaurantFusióValència = _prefixId.prefix "14_RestaurantFusióValència"
    let _15_CastellCadis = _prefixId.prefix "15_CastellCadis"
    let _15_FestivalSaragossa = _prefixId.prefix "15_FestivalSaragossa"
    let _15_HotelPalaceCadis = _prefixId.prefix "15_HotelPalaceCadis"
    let _15_MoviCadis = _prefixId.prefix "15_MoviCadis"

    let _15_RestaurantDeliciaSaragossa = _prefixId.prefix "15_RestaurantDeliciaSaragossa"

    let _16_CastellBarcelona = _prefixId.prefix "16_CastellBarcelona"
    let _16_CityMàlaga = _prefixId.prefix "16_CityMàlaga"
    let _16_ConcertSevilla = _prefixId.prefix "16_ConcertSevilla"
    let _16_HotelPalaceSaragossa = _prefixId.prefix "16_HotelPalaceSaragossa"
    let _16_RestaurantFusióPamplona = _prefixId.prefix "16_RestaurantFusióPamplona"
    let _17_CarnavalValència = _prefixId.prefix "17_CarnavalValència"
    let _17_HotelDelMarToledo = _prefixId.prefix "17_HotelDelMarToledo"
    let _17_ParcMadrid = _prefixId.prefix "17_ParcMadrid"
    let _17_RestaurantGourmetCadis = _prefixId.prefix "17_RestaurantGourmetCadis"
    let _17_UrbanBilbao = _prefixId.prefix "17_UrbanBilbao"
    let _18_FestivalSaragossa = _prefixId.prefix "18_FestivalSaragossa"
    let _18_HotelPalaceMadrid = _prefixId.prefix "18_HotelPalaceMadrid"
    let _18_MetroBilbao = _prefixId.prefix "18_MetroBilbao"
    let _18_MuseuMàlaga = _prefixId.prefix "18_MuseuMàlaga"
    let _18_RestaurantSaborCadis = _prefixId.prefix "18_RestaurantSaborCadis"
    let _19_CityBilbao = _prefixId.prefix "19_CityBilbao"
    let _19_ConcertValència = _prefixId.prefix "19_ConcertValència"
    let _19_HotelSolBilbao = _prefixId.prefix "19_HotelSolBilbao"
    let _19_PalauBarcelona = _prefixId.prefix "19_PalauBarcelona"
    let _19_RestaurantFusióMadrid = _prefixId.prefix "19_RestaurantFusióMadrid"
    let _1_CastellSaragossa = _prefixId.prefix "1_CastellSaragossa"
    let _1_CongrésCadis = _prefixId.prefix "1_CongrésCadis"
    let _1_HotelVistaSevilla = _prefixId.prefix "1_HotelVistaSevilla"
    let _1_RestaurantTradicióToledo = _prefixId.prefix "1_RestaurantTradicióToledo"
    let _1_UrbanMadrid = _prefixId.prefix "1_UrbanMadrid"
    let _20_CarnavalSevilla = _prefixId.prefix "20_CarnavalSevilla"
    let _20_CatedralBarcelona = _prefixId.prefix "20_CatedralBarcelona"
    let _20_HotelVistaValència = _prefixId.prefix "20_HotelVistaValència"
    let _20_MoviBilbao = _prefixId.prefix "20_MoviBilbao"
    let _20_RestaurantGourmetMàlaga = _prefixId.prefix "20_RestaurantGourmetMàlaga"
    let _21_CatedralMàlaga = _prefixId.prefix "21_CatedralMàlaga"
    let _21_CityPamplona = _prefixId.prefix "21_CityPamplona"
    let _21_FiraSevilla = _prefixId.prefix "21_FiraSevilla"
    let _21_HotelSolValència = _prefixId.prefix "21_HotelSolValència"
    let _21_RestaurantDeliciaMadrid = _prefixId.prefix "21_RestaurantDeliciaMadrid"
    let _22_CatedralValència = _prefixId.prefix "22_CatedralValència"
    let _22_FestivalSevilla = _prefixId.prefix "22_FestivalSevilla"
    let _22_HotelVistaMàlaga = _prefixId.prefix "22_HotelVistaMàlaga"
    let _22_RestaurantTradicióMadrid = _prefixId.prefix "22_RestaurantTradicióMadrid"
    let _22_UrbanSaragossa = _prefixId.prefix "22_UrbanSaragossa"
    let _23_CastellSantSebastià = _prefixId.prefix "23_CastellSantSebastià"
    let _23_CongrésSaragossa = _prefixId.prefix "23_CongrésSaragossa"
    let _23_HotelVistaToledo = _prefixId.prefix "23_HotelVistaToledo"
    let _23_MoviPamplona = _prefixId.prefix "23_MoviPamplona"
    let _23_RestaurantFusióSevilla = _prefixId.prefix "23_RestaurantFusióSevilla"
    let _24_CastellSaragossa = _prefixId.prefix "24_CastellSaragossa"
    let _24_CongrésBarcelona = _prefixId.prefix "24_CongrésBarcelona"
    let _24_HotelRoyalSaragossa = _prefixId.prefix "24_HotelRoyalSaragossa"
    let _24_RestaurantGourmetSevilla = _prefixId.prefix "24_RestaurantGourmetSevilla"
    let _24_UrbanValència = _prefixId.prefix "24_UrbanValència"
    let _25_CarnavalMàlaga = _prefixId.prefix "25_CarnavalMàlaga"
    let _25_HotelRoyalSevilla = _prefixId.prefix "25_HotelRoyalSevilla"
    let _25_MetroSaragossa = _prefixId.prefix "25_MetroSaragossa"
    let _25_ParcBilbao = _prefixId.prefix "25_ParcBilbao"
    let _25_RestaurantFusióSevilla = _prefixId.prefix "25_RestaurantFusióSevilla"
    let _26_CarnavalBilbao = _prefixId.prefix "26_CarnavalBilbao"
    let _26_CatedralSaragossa = _prefixId.prefix "26_CatedralSaragossa"
    let _26_HotelSolCadis = _prefixId.prefix "26_HotelSolCadis"
    let _26_MetroPamplona = _prefixId.prefix "26_MetroPamplona"
    let _26_RestaurantGourmetPamplona = _prefixId.prefix "26_RestaurantGourmetPamplona"
    let _27_CastellMàlaga = _prefixId.prefix "27_CastellMàlaga"
    let _27_CongrésBilbao = _prefixId.prefix "27_CongrésBilbao"
    let _27_HotelSolBilbao = _prefixId.prefix "27_HotelSolBilbao"

    let _27_RestaurantTradicióSantSebastià = _prefixId.prefix "27_RestaurantTradicióSantSebastià"

    let _27_UrbanBarcelona = _prefixId.prefix "27_UrbanBarcelona"
    let _28_FestivalToledo = _prefixId.prefix "28_FestivalToledo"
    let _28_HotelDelMarSantSebastià = _prefixId.prefix "28_HotelDelMarSantSebastià"
    let _28_ParcSantSebastià = _prefixId.prefix "28_ParcSantSebastià"
    let _28_RestaurantFusióCadis = _prefixId.prefix "28_RestaurantFusióCadis"
    let _28_UrbanPamplona = _prefixId.prefix "28_UrbanPamplona"
    let _29_CastellSantSebastià = _prefixId.prefix "29_CastellSantSebastià"
    let _29_FiraMadrid = _prefixId.prefix "29_FiraMadrid"
    let _29_HotelRoyalMadrid = _prefixId.prefix "29_HotelRoyalMadrid"
    let _29_MetroSantSebastià = _prefixId.prefix "29_MetroSantSebastià"
    let _29_RestaurantDeliciaValència = _prefixId.prefix "29_RestaurantDeliciaValència"
    let _2_CarnavalCadis = _prefixId.prefix "2_CarnavalCadis"
    let _2_CastellSevilla = _prefixId.prefix "2_CastellSevilla"
    let _2_HotelRoyalPamplona = _prefixId.prefix "2_HotelRoyalPamplona"
    let _2_RestaurantGourmetMadrid = _prefixId.prefix "2_RestaurantGourmetMadrid"
    let _2_TransBilbao = _prefixId.prefix "2_TransBilbao"
    let _30_CastellValència = _prefixId.prefix "30_CastellValència"
    let _30_FestivalMadrid = _prefixId.prefix "30_FestivalMadrid"
    let _30_HotelDelMarPamplona = _prefixId.prefix "30_HotelDelMarPamplona"
    let _30_RestaurantDeliciaPamplona = _prefixId.prefix "30_RestaurantDeliciaPamplona"
    let _30_UrbanMàlaga = _prefixId.prefix "30_UrbanMàlaga"
    let _31_FiraMadrid = _prefixId.prefix "31_FiraMadrid"
    let _31_HotelVistaMadrid = _prefixId.prefix "31_HotelVistaMadrid"
    let _31_PalauMàlaga = _prefixId.prefix "31_PalauMàlaga"
    let _31_RestaurantTradicióMadrid = _prefixId.prefix "31_RestaurantTradicióMadrid"
    let _31_UrbanSantSebastià = _prefixId.prefix "31_UrbanSantSebastià"
    let _32_ConcertPamplona = _prefixId.prefix "32_ConcertPamplona"
    let _32_HotelPalaceToledo = _prefixId.prefix "32_HotelPalaceToledo"
    let _32_MetroMadrid = _prefixId.prefix "32_MetroMadrid"
    let _32_MuseuSaragossa = _prefixId.prefix "32_MuseuSaragossa"
    let _32_RestaurantGourmetMadrid = _prefixId.prefix "32_RestaurantGourmetMadrid"
    let _33_FestivalBarcelona = _prefixId.prefix "33_FestivalBarcelona"
    let _33_HotelSolBarcelona = _prefixId.prefix "33_HotelSolBarcelona"
    let _33_MetroMadrid = _prefixId.prefix "33_MetroMadrid"
    let _33_MuseuBarcelona = _prefixId.prefix "33_MuseuBarcelona"
    let _33_RestaurantTradicióToledo = _prefixId.prefix "33_RestaurantTradicióToledo"
    let _34_CarnavalSaragossa = _prefixId.prefix "34_CarnavalSaragossa"
    let _34_HotelDelMarBarcelona = _prefixId.prefix "34_HotelDelMarBarcelona"
    let _34_MuseuSaragossa = _prefixId.prefix "34_MuseuSaragossa"
    let _34_RestaurantDeliciaSevilla = _prefixId.prefix "34_RestaurantDeliciaSevilla"
    let _34_UrbanSantSebastià = _prefixId.prefix "34_UrbanSantSebastià"
    let _35_ConcertToledo = _prefixId.prefix "35_ConcertToledo"
    let _35_HotelDelMarPamplona = _prefixId.prefix "35_HotelDelMarPamplona"
    let _35_MetroBilbao = _prefixId.prefix "35_MetroBilbao"
    let _35_PalauPamplona = _prefixId.prefix "35_PalauPamplona"

    let _35_RestaurantDeliciaSantSebastià = _prefixId.prefix "35_RestaurantDeliciaSantSebastià"

    let _36_CityBarcelona = _prefixId.prefix "36_CityBarcelona"
    let _36_ConcertPamplona = _prefixId.prefix "36_ConcertPamplona"
    let _36_HotelPalaceSaragossa = _prefixId.prefix "36_HotelPalaceSaragossa"
    let _36_ParcPamplona = _prefixId.prefix "36_ParcPamplona"
    let _36_RestaurantFusióSaragossa = _prefixId.prefix "36_RestaurantFusióSaragossa"
    let _37_CastellMadrid = _prefixId.prefix "37_CastellMadrid"
    let _37_FestivalMadrid = _prefixId.prefix "37_FestivalMadrid"
    let _37_HotelDelMarValència = _prefixId.prefix "37_HotelDelMarValència"
    let _37_RestaurantSaborValència = _prefixId.prefix "37_RestaurantSaborValència"
    let _37_TransMàlaga = _prefixId.prefix "37_TransMàlaga"
    let _38_CarnavalSevilla = _prefixId.prefix "38_CarnavalSevilla"
    let _38_HotelDelMarMàlaga = _prefixId.prefix "38_HotelDelMarMàlaga"
    let _38_MoviMadrid = _prefixId.prefix "38_MoviMadrid"
    let _38_PalauToledo = _prefixId.prefix "38_PalauToledo"
    let _38_RestaurantDeliciaPamplona = _prefixId.prefix "38_RestaurantDeliciaPamplona"
    let _39_CastellSantSebastià = _prefixId.prefix "39_CastellSantSebastià"
    let _39_FiraBarcelona = _prefixId.prefix "39_FiraBarcelona"
    let _39_HotelSolSaragossa = _prefixId.prefix "39_HotelSolSaragossa"
    let _39_MoviSevilla = _prefixId.prefix "39_MoviSevilla"
    let _39_RestaurantFusióToledo = _prefixId.prefix "39_RestaurantFusióToledo"
    let _3_CastellSaragossa = _prefixId.prefix "3_CastellSaragossa"
    let _3_CongrésBilbao = _prefixId.prefix "3_CongrésBilbao"
    let _3_HotelRoyalMàlaga = _prefixId.prefix "3_HotelRoyalMàlaga"
    let _3_RestaurantFusióValència = _prefixId.prefix "3_RestaurantFusióValència"
    let _3_TransToledo = _prefixId.prefix "3_TransToledo"
    let _40_FestivalValència = _prefixId.prefix "40_FestivalValència"
    let _40_HotelDelMarSantSebastià = _prefixId.prefix "40_HotelDelMarSantSebastià"
    let _40_PalauCadis = _prefixId.prefix "40_PalauCadis"
    let _40_RestaurantGourmetValència = _prefixId.prefix "40_RestaurantGourmetValència"
    let _40_UrbanToledo = _prefixId.prefix "40_UrbanToledo"
    let _41_CatedralToledo = _prefixId.prefix "41_CatedralToledo"
    let _41_ConcertToledo = _prefixId.prefix "41_ConcertToledo"
    let _41_HotelRoyalCadis = _prefixId.prefix "41_HotelRoyalCadis"
    let _41_MetroBarcelona = _prefixId.prefix "41_MetroBarcelona"

    let _41_RestaurantTradicióSaragossa = _prefixId.prefix "41_RestaurantTradicióSaragossa"

    let _42_FestivalPamplona = _prefixId.prefix "42_FestivalPamplona"
    let _42_HotelPalaceMadrid = _prefixId.prefix "42_HotelPalaceMadrid"
    let _42_MuseuMadrid = _prefixId.prefix "42_MuseuMadrid"
    let _42_RestaurantTradicióSevilla = _prefixId.prefix "42_RestaurantTradicióSevilla"
    let _42_UrbanSevilla = _prefixId.prefix "42_UrbanSevilla"
    let _43_CityPamplona = _prefixId.prefix "43_CityPamplona"
    let _43_FestivalMadrid = _prefixId.prefix "43_FestivalMadrid"
    let _43_HotelRoyalPamplona = _prefixId.prefix "43_HotelRoyalPamplona"
    let _43_ParcBarcelona = _prefixId.prefix "43_ParcBarcelona"
    let _43_RestaurantFusióBarcelona = _prefixId.prefix "43_RestaurantFusióBarcelona"
    let _44_CongrésSevilla = _prefixId.prefix "44_CongrésSevilla"
    let _44_HotelVistaSaragossa = _prefixId.prefix "44_HotelVistaSaragossa"
    let _44_MoviSantSebastià = _prefixId.prefix "44_MoviSantSebastià"
    let _44_MuseuSevilla = _prefixId.prefix "44_MuseuSevilla"
    let _44_RestaurantGourmetMàlaga = _prefixId.prefix "44_RestaurantGourmetMàlaga"
    let _45_CatedralBarcelona = _prefixId.prefix "45_CatedralBarcelona"
    let _45_CongrésBarcelona = _prefixId.prefix "45_CongrésBarcelona"
    let _45_HotelRoyalBarcelona = _prefixId.prefix "45_HotelRoyalBarcelona"
    let _45_MetroPamplona = _prefixId.prefix "45_MetroPamplona"
    let _45_RestaurantFusióSaragossa = _prefixId.prefix "45_RestaurantFusióSaragossa"
    let _46_CongrésValència = _prefixId.prefix "46_CongrésValència"
    let _46_HotelVistaSevilla = _prefixId.prefix "46_HotelVistaSevilla"
    let _46_MetroPamplona = _prefixId.prefix "46_MetroPamplona"
    let _46_MuseuToledo = _prefixId.prefix "46_MuseuToledo"
    let _46_RestaurantSaborMàlaga = _prefixId.prefix "46_RestaurantSaborMàlaga"
    let _47_FestivalValència = _prefixId.prefix "47_FestivalValència"
    let _47_HotelDelMarSantSebastià = _prefixId.prefix "47_HotelDelMarSantSebastià"
    let _47_MoviSantSebastià = _prefixId.prefix "47_MoviSantSebastià"
    let _47_PalauToledo = _prefixId.prefix "47_PalauToledo"

    let _47_RestaurantTradicióSantSebastià = _prefixId.prefix "47_RestaurantTradicióSantSebastià"

    let _48_FestivalBilbao = _prefixId.prefix "48_FestivalBilbao"
    let _48_HotelPalaceMàlaga = _prefixId.prefix "48_HotelPalaceMàlaga"
    let _48_MoviToledo = _prefixId.prefix "48_MoviToledo"
    let _48_ParcSantSebastià = _prefixId.prefix "48_ParcSantSebastià"

    let _48_RestaurantSaborSantSebastià = _prefixId.prefix "48_RestaurantSaborSantSebastià"

    let _49_CastellSantSebastià = _prefixId.prefix "49_CastellSantSebastià"
    let _49_CityMadrid = _prefixId.prefix "49_CityMadrid"
    let _49_ConcertSantSebastià = _prefixId.prefix "49_ConcertSantSebastià"
    let _49_HotelVistaPamplona = _prefixId.prefix "49_HotelVistaPamplona"
    let _49_RestaurantSaborMàlaga = _prefixId.prefix "49_RestaurantSaborMàlaga"
    let _4_CarnavalSevilla = _prefixId.prefix "4_CarnavalSevilla"
    let _4_CitySaragossa = _prefixId.prefix "4_CitySaragossa"
    let _4_HotelRoyalBilbao = _prefixId.prefix "4_HotelRoyalBilbao"
    let _4_MuseuMadrid = _prefixId.prefix "4_MuseuMadrid"
    let _4_RestaurantDeliciaMàlaga = _prefixId.prefix "4_RestaurantDeliciaMàlaga"
    let _50_FestivalValència = _prefixId.prefix "50_FestivalValència"
    let _50_HotelSolCadis = _prefixId.prefix "50_HotelSolCadis"
    let _50_ParcMàlaga = _prefixId.prefix "50_ParcMàlaga"

    let _50_RestaurantDeliciaBarcelona = _prefixId.prefix "50_RestaurantDeliciaBarcelona"

    let _50_UrbanSaragossa = _prefixId.prefix "50_UrbanSaragossa"
    let _51_CarnavalMàlaga = _prefixId.prefix "51_CarnavalMàlaga"
    let _51_HotelPalacePamplona = _prefixId.prefix "51_HotelPalacePamplona"
    let _51_PalauMadrid = _prefixId.prefix "51_PalauMadrid"
    let _51_RestaurantDeliciaSevilla = _prefixId.prefix "51_RestaurantDeliciaSevilla"
    let _51_UrbanMadrid = _prefixId.prefix "51_UrbanMadrid"
    let _52_CatedralMadrid = _prefixId.prefix "52_CatedralMadrid"
    let _52_CongrésToledo = _prefixId.prefix "52_CongrésToledo"
    let _52_HotelSolSevilla = _prefixId.prefix "52_HotelSolSevilla"

    let _52_RestaurantDeliciaSaragossa = _prefixId.prefix "52_RestaurantDeliciaSaragossa"

    let _52_TransMadrid = _prefixId.prefix "52_TransMadrid"
    let _53_CatedralValència = _prefixId.prefix "53_CatedralValència"
    let _53_FiraBarcelona = _prefixId.prefix "53_FiraBarcelona"
    let _53_HotelDelMarMàlaga = _prefixId.prefix "53_HotelDelMarMàlaga"
    let _53_RestaurantDeliciaCadis = _prefixId.prefix "53_RestaurantDeliciaCadis"
    let _53_UrbanToledo = _prefixId.prefix "53_UrbanToledo"
    let _54_CatedralToledo = _prefixId.prefix "54_CatedralToledo"
    let _54_FiraPamplona = _prefixId.prefix "54_FiraPamplona"
    let _54_HotelPalaceToledo = _prefixId.prefix "54_HotelPalaceToledo"
    let _54_MetroMàlaga = _prefixId.prefix "54_MetroMàlaga"
    let _54_RestaurantSaborSevilla = _prefixId.prefix "54_RestaurantSaborSevilla"
    let _55_FiraSaragossa = _prefixId.prefix "55_FiraSaragossa"
    let _55_HotelVistaCadis = _prefixId.prefix "55_HotelVistaCadis"
    let _55_MoviToledo = _prefixId.prefix "55_MoviToledo"
    let _55_ParcSaragossa = _prefixId.prefix "55_ParcSaragossa"
    let _55_RestaurantFusióMàlaga = _prefixId.prefix "55_RestaurantFusióMàlaga"
    let _56_FestivalBarcelona = _prefixId.prefix "56_FestivalBarcelona"
    let _56_HotelDelMarCadis = _prefixId.prefix "56_HotelDelMarCadis"
    let _56_MuseuToledo = _prefixId.prefix "56_MuseuToledo"
    let _56_RestaurantTradicióMadrid = _prefixId.prefix "56_RestaurantTradicióMadrid"
    let _56_TransValència = _prefixId.prefix "56_TransValència"
    let _57_CongrésBarcelona = _prefixId.prefix "57_CongrésBarcelona"
    let _57_HotelSolSevilla = _prefixId.prefix "57_HotelSolSevilla"
    let _57_MoviValència = _prefixId.prefix "57_MoviValència"
    let _57_ParcCadis = _prefixId.prefix "57_ParcCadis"
    let _57_RestaurantGourmetMàlaga = _prefixId.prefix "57_RestaurantGourmetMàlaga"
    let _58_CarnavalSevilla = _prefixId.prefix "58_CarnavalSevilla"
    let _58_CatedralMàlaga = _prefixId.prefix "58_CatedralMàlaga"
    let _58_HotelDelMarSevilla = _prefixId.prefix "58_HotelDelMarSevilla"
    let _58_MoviPamplona = _prefixId.prefix "58_MoviPamplona"

    let _58_RestaurantDeliciaSaragossa = _prefixId.prefix "58_RestaurantDeliciaSaragossa"

    let _59_CatedralBilbao = _prefixId.prefix "59_CatedralBilbao"
    let _59_FestivalMàlaga = _prefixId.prefix "59_FestivalMàlaga"
    let _59_HotelVistaSantSebastià = _prefixId.prefix "59_HotelVistaSantSebastià"
    let _59_MetroSantSebastià = _prefixId.prefix "59_MetroSantSebastià"
    let _59_RestaurantFusióCadis = _prefixId.prefix "59_RestaurantFusióCadis"
    let _5_CastellCadis = _prefixId.prefix "5_CastellCadis"
    let _5_FiraToledo = _prefixId.prefix "5_FiraToledo"
    let _5_HotelPalaceSaragossa = _prefixId.prefix "5_HotelPalaceSaragossa"
    let _5_MoviCadis = _prefixId.prefix "5_MoviCadis"
    let _5_RestaurantDeliciaPamplona = _prefixId.prefix "5_RestaurantDeliciaPamplona"
    let _60_FiraSevilla = _prefixId.prefix "60_FiraSevilla"
    let _60_HotelDelMarBarcelona = _prefixId.prefix "60_HotelDelMarBarcelona"
    let _60_ParcCadis = _prefixId.prefix "60_ParcCadis"

    let _60_RestaurantDeliciaSantSebastià = _prefixId.prefix "60_RestaurantDeliciaSantSebastià"

    let _60_UrbanMadrid = _prefixId.prefix "60_UrbanMadrid"
    let _61_CarnavalToledo = _prefixId.prefix "61_CarnavalToledo"
    let _61_HotelDelMarCadis = _prefixId.prefix "61_HotelDelMarCadis"
    let _61_MetroBilbao = _prefixId.prefix "61_MetroBilbao"
    let _61_PalauSaragossa = _prefixId.prefix "61_PalauSaragossa"
    let _61_RestaurantGourmetMadrid = _prefixId.prefix "61_RestaurantGourmetMadrid"
    let _62_CarnavalCadis = _prefixId.prefix "62_CarnavalCadis"
    let _62_CatedralValència = _prefixId.prefix "62_CatedralValència"
    let _62_CityCadis = _prefixId.prefix "62_CityCadis"
    let _62_HotelPalaceBarcelona = _prefixId.prefix "62_HotelPalaceBarcelona"

    let _62_RestaurantTradicióSantSebastià = _prefixId.prefix "62_RestaurantTradicióSantSebastià"

    let _63_FiraMàlaga = _prefixId.prefix "63_FiraMàlaga"
    let _63_HotelSolBarcelona = _prefixId.prefix "63_HotelSolBarcelona"
    let _63_MetroMàlaga = _prefixId.prefix "63_MetroMàlaga"
    let _63_MuseuSaragossa = _prefixId.prefix "63_MuseuSaragossa"
    let _63_RestaurantTradicióCadis = _prefixId.prefix "63_RestaurantTradicióCadis"
    let _64_CityBarcelona = _prefixId.prefix "64_CityBarcelona"
    let _64_FiraMadrid = _prefixId.prefix "64_FiraMadrid"
    let _64_HotelPalaceBarcelona = _prefixId.prefix "64_HotelPalaceBarcelona"
    let _64_MuseuSantSebastià = _prefixId.prefix "64_MuseuSantSebastià"
    let _64_RestaurantTradicióMàlaga = _prefixId.prefix "64_RestaurantTradicióMàlaga"
    let _65_CarnavalBarcelona = _prefixId.prefix "65_CarnavalBarcelona"
    let _65_HotelPalaceToledo = _prefixId.prefix "65_HotelPalaceToledo"
    let _65_ParcMàlaga = _prefixId.prefix "65_ParcMàlaga"
    let _65_RestaurantGourmetMàlaga = _prefixId.prefix "65_RestaurantGourmetMàlaga"
    let _65_UrbanPamplona = _prefixId.prefix "65_UrbanPamplona"
    let _66_FestivalValència = _prefixId.prefix "66_FestivalValència"
    let _66_HotelSolMadrid = _prefixId.prefix "66_HotelSolMadrid"
    let _66_MetroSevilla = _prefixId.prefix "66_MetroSevilla"
    let _66_MuseuSantSebastià = _prefixId.prefix "66_MuseuSantSebastià"
    let _66_RestaurantFusióBarcelona = _prefixId.prefix "66_RestaurantFusióBarcelona"
    let _67_ConcertToledo = _prefixId.prefix "67_ConcertToledo"
    let _67_HotelVistaMadrid = _prefixId.prefix "67_HotelVistaMadrid"
    let _67_MetroToledo = _prefixId.prefix "67_MetroToledo"
    let _67_ParcCadis = _prefixId.prefix "67_ParcCadis"
    let _67_RestaurantFusióToledo = _prefixId.prefix "67_RestaurantFusióToledo"
    let _68_CastellMadrid = _prefixId.prefix "68_CastellMadrid"
    let _68_FiraPamplona = _prefixId.prefix "68_FiraPamplona"
    let _68_HotelDelMarMadrid = _prefixId.prefix "68_HotelDelMarMadrid"
    let _68_TransMàlaga = _prefixId.prefix "68_TransMàlaga"
    let _68_estaurantGourmetBarcelona = _prefixId.prefix "68_estaurantGourmetBarcelona"
    let _69_CongrésSaragossa = _prefixId.prefix "69_CongrésSaragossa"
    let _69_HotelRoyalMadrid = _prefixId.prefix "69_HotelRoyalMadrid"
    let _69_MetroPamplona = _prefixId.prefix "69_MetroPamplona"
    let _69_ParcCadis = _prefixId.prefix "69_ParcCadis"

    let _69_RestaurantGourmetBarcelona = _prefixId.prefix "69_RestaurantGourmetBarcelona"

    let _6_CongrésBilbao = _prefixId.prefix "6_CongrésBilbao"
    let _6_HotelRoyalSantSebastià = _prefixId.prefix "6_HotelRoyalSantSebastià"
    let _6_PalauBilbao = _prefixId.prefix "6_PalauBilbao"
    let _6_RestaurantSaborSevilla = _prefixId.prefix "6_RestaurantSaborSevilla"
    let _6_TransPamplona = _prefixId.prefix "6_TransPamplona"
    let _70_CastellPamplona = _prefixId.prefix "70_CastellPamplona"
    let _70_CongrésSaragossa = _prefixId.prefix "70_CongrésSaragossa"
    let _70_HotelRoyalSaragossa = _prefixId.prefix "70_HotelRoyalSaragossa"
    let _70_RestaurantFusióSaragossa = _prefixId.prefix "70_RestaurantFusióSaragossa"
    let _70_UrbanBilbao = _prefixId.prefix "70_UrbanBilbao"
    let _71_FiraMàlaga = _prefixId.prefix "71_FiraMàlaga"
    let _71_HotelDelMarMàlaga = _prefixId.prefix "71_HotelDelMarMàlaga"
    let _71_MoviBarcelona = _prefixId.prefix "71_MoviBarcelona"
    let _71_ParcMadrid = _prefixId.prefix "71_ParcMadrid"
    let _71_RestaurantTradicióCadis = _prefixId.prefix "71_RestaurantTradicióCadis"
    let _72_FiraCadis = _prefixId.prefix "72_FiraCadis"
    let _72_HotelDelMarSaragossa = _prefixId.prefix "72_HotelDelMarSaragossa"
    let _72_ParcValència = _prefixId.prefix "72_ParcValència"
    let _72_RestaurantFusióBilbao = _prefixId.prefix "72_RestaurantFusióBilbao"
    let _72_UrbanSevilla = _prefixId.prefix "72_UrbanSevilla"
    let _73_CarnavalSantSebastià = _prefixId.prefix "73_CarnavalSantSebastià"
    let _73_CatedralValència = _prefixId.prefix "73_CatedralValència"
    let _73_HotelVistaSantSebastià = _prefixId.prefix "73_HotelVistaSantSebastià"
    let _73_RestaurantGourmetValència = _prefixId.prefix "73_RestaurantGourmetValència"
    let _73_TransCadis = _prefixId.prefix "73_TransCadis"
    let _74_CarnavalMàlaga = _prefixId.prefix "74_CarnavalMàlaga"
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
    let _76_ConcertMàlaga = _prefixId.prefix "76_ConcertMàlaga"
    let _76_HotelVistaBarcelona = _prefixId.prefix "76_HotelVistaBarcelona"
    let _76_PalauBarcelona = _prefixId.prefix "76_PalauBarcelona"
    let _76_RestaurantFusióValència = _prefixId.prefix "76_RestaurantFusióValència"
    let _77_FestivalToledo = _prefixId.prefix "77_FestivalToledo"
    let _77_HotelSolBarcelona = _prefixId.prefix "77_HotelSolBarcelona"
    let _77_MetroMadrid = _prefixId.prefix "77_MetroMadrid"
    let _77_PalauPamplona = _prefixId.prefix "77_PalauPamplona"
    let _77_RestaurantDeliciaSevilla = _prefixId.prefix "77_RestaurantDeliciaSevilla"
    let _78_CarnavalCadis = _prefixId.prefix "78_CarnavalCadis"
    let _78_CastellBilbao = _prefixId.prefix "78_CastellBilbao"
    let _78_HotelRoyalBilbao = _prefixId.prefix "78_HotelRoyalBilbao"
    let _78_MoviBilbao = _prefixId.prefix "78_MoviBilbao"
    let _78_RestaurantFusióValència = _prefixId.prefix "78_RestaurantFusióValència"
    let _79_CatedralPamplona = _prefixId.prefix "79_CatedralPamplona"
    let _79_CongrésCadis = _prefixId.prefix "79_CongrésCadis"
    let _79_HotelSolMàlaga = _prefixId.prefix "79_HotelSolMàlaga"
    let _79_RestaurantSaborMàlaga = _prefixId.prefix "79_RestaurantSaborMàlaga"
    let _79_TransSevilla = _prefixId.prefix "79_TransSevilla"
    let _7_CatedralSevilla = _prefixId.prefix "7_CatedralSevilla"
    let _7_FestivalMadrid = _prefixId.prefix "7_FestivalMadrid"
    let _7_HotelRoyalValència = _prefixId.prefix "7_HotelRoyalValència"
    let _7_MetroCadis = _prefixId.prefix "7_MetroCadis"
    let _7_RestaurantGourmetSaragossa = _prefixId.prefix "7_RestaurantGourmetSaragossa"
    let _80_ConcertMàlaga = _prefixId.prefix "80_ConcertMàlaga"
    let _80_HotelVistaSantSebastià = _prefixId.prefix "80_HotelVistaSantSebastià"
    let _80_ParcMadrid = _prefixId.prefix "80_ParcMadrid"
    let _80_RestaurantGourmetPamplona = _prefixId.prefix "80_RestaurantGourmetPamplona"
    let _80_TransPamplona = _prefixId.prefix "80_TransPamplona"
    let _81_CityBilbao = _prefixId.prefix "81_CityBilbao"
    let _81_CongrésToledo = _prefixId.prefix "81_CongrésToledo"
    let _81_HotelVistaBarcelona = _prefixId.prefix "81_HotelVistaBarcelona"
    let _81_ParcSevilla = _prefixId.prefix "81_ParcSevilla"

    let _81_RestaurantGourmetSantSebastià = _prefixId.prefix "81_RestaurantGourmetSantSebastià"

    let _82_CityMadrid = _prefixId.prefix "82_CityMadrid"
    let _82_CongrésToledo = _prefixId.prefix "82_CongrésToledo"
    let _82_HotelPalaceBilbao = _prefixId.prefix "82_HotelPalaceBilbao"
    let _82_PalauValència = _prefixId.prefix "82_PalauValència"
    let _82_RestaurantGourmetMadrid = _prefixId.prefix "82_RestaurantGourmetMadrid"
    let _83_CastellMàlaga = _prefixId.prefix "83_CastellMàlaga"
    let _83_CityToledo = _prefixId.prefix "83_CityToledo"
    let _83_ConcertCadis = _prefixId.prefix "83_ConcertCadis"
    let _83_HotelPalaceCadis = _prefixId.prefix "83_HotelPalaceCadis"
    let _83_RestaurantDeliciaBilbao = _prefixId.prefix "83_RestaurantDeliciaBilbao"
    let _84_CastellPamplona = _prefixId.prefix "84_CastellPamplona"
    let _84_FestivalSaragossa = _prefixId.prefix "84_FestivalSaragossa"
    let _84_HotelVistaMadrid = _prefixId.prefix "84_HotelVistaMadrid"
    let _84_RestaurantFusióPamplona = _prefixId.prefix "84_RestaurantFusióPamplona"
    let _84_TransSantSebastià = _prefixId.prefix "84_TransSantSebastià"
    let _85_CastellPamplona = _prefixId.prefix "85_CastellPamplona"
    let _85_FestivalSantSebastià = _prefixId.prefix "85_FestivalSantSebastià"
    let _85_HotelPalaceMadrid = _prefixId.prefix "85_HotelPalaceMadrid"
    let _85_MoviSevilla = _prefixId.prefix "85_MoviSevilla"
    let _85_RestaurantFusióMadrid = _prefixId.prefix "85_RestaurantFusióMadrid"
    let _86_CitySevilla = _prefixId.prefix "86_CitySevilla"
    let _86_FiraToledo = _prefixId.prefix "86_FiraToledo"
    let _86_HotelVistaToledo = _prefixId.prefix "86_HotelVistaToledo"
    let _86_MuseuSaragossa = _prefixId.prefix "86_MuseuSaragossa"
    let _86_RestaurantFusióCadis = _prefixId.prefix "86_RestaurantFusióCadis"
    let _87_FestivalMadrid = _prefixId.prefix "87_FestivalMadrid"
    let _87_HotelSolSantSebastià = _prefixId.prefix "87_HotelSolSantSebastià"
    let _87_MoviBarcelona = _prefixId.prefix "87_MoviBarcelona"
    let _87_ParcSantSebastià = _prefixId.prefix "87_ParcSantSebastià"
    let _87_RestaurantSaborValència = _prefixId.prefix "87_RestaurantSaborValència"
    let _88_FestivalToledo = _prefixId.prefix "88_FestivalToledo"
    let _88_HotelVistaBarcelona = _prefixId.prefix "88_HotelVistaBarcelona"
    let _88_PalauToledo = _prefixId.prefix "88_PalauToledo"
    let _88_RestaurantFusióBarcelona = _prefixId.prefix "88_RestaurantFusióBarcelona"
    let _88_TransSaragossa = _prefixId.prefix "88_TransSaragossa"
    let _89_CastellSaragossa = _prefixId.prefix "89_CastellSaragossa"
    let _89_FiraSaragossa = _prefixId.prefix "89_FiraSaragossa"
    let _89_HotelVistaBilbao = _prefixId.prefix "89_HotelVistaBilbao"
    let _89_RestaurantGourmetMàlaga = _prefixId.prefix "89_RestaurantGourmetMàlaga"
    let _89_UrbanValència = _prefixId.prefix "89_UrbanValència"
    let _8_CityMadrid = _prefixId.prefix "8_CityMadrid"
    let _8_FiraMàlaga = _prefixId.prefix "8_FiraMàlaga"
    let _8_HotelVistaCadis = _prefixId.prefix "8_HotelVistaCadis"
    let _8_ParcSantSebastià = _prefixId.prefix "8_ParcSantSebastià"
    let _8_RestaurantGourmetToledo = _prefixId.prefix "8_RestaurantGourmetToledo"
    let _90_CitySaragossa = _prefixId.prefix "90_CitySaragossa"
    let _90_CongrésValència = _prefixId.prefix "90_CongrésValència"
    let _90_HotelDelMarSevilla = _prefixId.prefix "90_HotelDelMarSevilla"
    let _90_MuseuPamplona = _prefixId.prefix "90_MuseuPamplona"

    let _90_RestaurantDeliciaSaragossa = _prefixId.prefix "90_RestaurantDeliciaSaragossa"

    let _91_CarnavalMadrid = _prefixId.prefix "91_CarnavalMadrid"
    let _91_CatedralSevilla = _prefixId.prefix "91_CatedralSevilla"
    let _91_HotelDelMarValència = _prefixId.prefix "91_HotelDelMarValència"

    let _91_RestaurantGourmetSaragossa = _prefixId.prefix "91_RestaurantGourmetSaragossa"

    let _91_UrbanBilbao = _prefixId.prefix "91_UrbanBilbao"
    let _92_FestivalCadis = _prefixId.prefix "92_FestivalCadis"
    let _92_HotelRoyalMàlaga = _prefixId.prefix "92_HotelRoyalMàlaga"
    let _92_MetroMadrid = _prefixId.prefix "92_MetroMadrid"
    let _92_MuseuCadis = _prefixId.prefix "92_MuseuCadis"
    let _92_RestaurantGourmetPamplona = _prefixId.prefix "92_RestaurantGourmetPamplona"
    let _93_ConcertCadis = _prefixId.prefix "93_ConcertCadis"
    let _93_HotelDelMarMadrid = _prefixId.prefix "93_HotelDelMarMadrid"
    let _93_ParcToledo = _prefixId.prefix "93_ParcToledo"
    let _93_RestaurantSaborSaragossa = _prefixId.prefix "93_RestaurantSaborSaragossa"
    let _93_TransValència = _prefixId.prefix "93_TransValència"
    let _94_CatedralToledo = _prefixId.prefix "94_CatedralToledo"
    let _94_FestivalMadrid = _prefixId.prefix "94_FestivalMadrid"
    let _94_HotelVistaBilbao = _prefixId.prefix "94_HotelVistaBilbao"
    let _94_MoviMàlaga = _prefixId.prefix "94_MoviMàlaga"
    let _94_RestaurantTradicióSevilla = _prefixId.prefix "94_RestaurantTradicióSevilla"
    let _95_CatedralValència = _prefixId.prefix "95_CatedralValència"
    let _95_ConcertSaragossa = _prefixId.prefix "95_ConcertSaragossa"
    let _95_HotelPalacePamplona = _prefixId.prefix "95_HotelPalacePamplona"
    let _95_RestaurantTradicióSevilla = _prefixId.prefix "95_RestaurantTradicióSevilla"
    let _95_TransMadrid = _prefixId.prefix "95_TransMadrid"
    let _96_CongrésBarcelona = _prefixId.prefix "96_CongrésBarcelona"
    let _96_HotelVistaPamplona = _prefixId.prefix "96_HotelVistaPamplona"
    let _96_MuseuMadrid = _prefixId.prefix "96_MuseuMadrid"
    let _96_RestaurantTradicióMadrid = _prefixId.prefix "96_RestaurantTradicióMadrid"
    let _96_TransSaragossa = _prefixId.prefix "96_TransSaragossa"
    let _97_CarnavalBilbao = _prefixId.prefix "97_CarnavalBilbao"
    let _97_CatedralSaragossa = _prefixId.prefix "97_CatedralSaragossa"
    let _97_HotelPalaceMàlaga = _prefixId.prefix "97_HotelPalaceMàlaga"
    let _97_RestaurantFusióSaragossa = _prefixId.prefix "97_RestaurantFusióSaragossa"
    let _97_TransCadis = _prefixId.prefix "97_TransCadis"
    let _98_CityPamplona = _prefixId.prefix "98_CityPamplona"
    let _98_CongrésSaragossa = _prefixId.prefix "98_CongrésSaragossa"
    let _98_HotelPalaceMadrid = _prefixId.prefix "98_HotelPalaceMadrid"
    let _98_ParcCadis = _prefixId.prefix "98_ParcCadis"
    let _98_RestaurantDeliciaSevilla = _prefixId.prefix "98_RestaurantDeliciaSevilla"
    let _99_CatedralBilbao = _prefixId.prefix "99_CatedralBilbao"
    let _99_FiraSevilla = _prefixId.prefix "99_FiraSevilla"
    let _99_HotelSolSevilla = _prefixId.prefix "99_HotelSolSevilla"
    let _99_MetroSantSebastià = _prefixId.prefix "99_MetroSantSebastià"
    let _99_RestaurantGourmetValència = _prefixId.prefix "99_RestaurantGourmetValència"
    let _9_CatedralPamplona = _prefixId.prefix "9_CatedralPamplona"
    let _9_CongrésSantSebastià = _prefixId.prefix "9_CongrésSantSebastià"
    let _9_HotelRoyalBarcelona = _prefixId.prefix "9_HotelRoyalBarcelona"
    let _9_MetroBarcelona = _prefixId.prefix "9_MetroBarcelona"
    let _9_RestaurantDeliciaMàlaga = _prefixId.prefix "9_RestaurantDeliciaMàlaga"
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
    let Màlaga = _prefixId.prefix "Màlaga"
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
    let SantSebastià = _prefixId.prefix "SantSebastià"
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
    let València = _prefixId.prefix "València"
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

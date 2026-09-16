#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``taxref-ld`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://taxref.mnhn.fr/lod/" "taxref-ld"
    let Agrovoc = _prefixId.prefix "Agrovoc"
    let Catalog = _prefixId.prefix "Catalog"
    let INPN = _prefixId.prefix "INPN"
    let NcbiTaxon = _prefixId.prefix "NcbiTaxon"
    let Organisms_in_adulte_stage = _prefixId.prefix "Organisms_in_adulte_stage"
    let ``Organisms_in_au%20nid_stage`` = _prefixId.prefix "Organisms_in_au%20nid_stage"

    let ``Organisms_in_copepodite%20III_stage`` = _prefixId.prefix "Organisms_in_copepodite%20III_stage"

    let ``Organisms_in_copepodite%20II_stage`` = _prefixId.prefix "Organisms_in_copepodite%20II_stage"

    let ``Organisms_in_copepodite%20IV_stage`` = _prefixId.prefix "Organisms_in_copepodite%20IV_stage"

    let ``Organisms_in_copepodite%20I_stage`` = _prefixId.prefix "Organisms_in_copepodite%20I_stage"

    let ``Organisms_in_copepodite%20VI_stage`` = _prefixId.prefix "Organisms_in_copepodite%20VI_stage"

    let ``Organisms_in_copepodite%20V_stage`` = _prefixId.prefix "Organisms_in_copepodite%20V_stage"

    let Organisms_in_cypris_stage = _prefixId.prefix "Organisms_in_cypris_stage"

    let ``Organisms_in_de%20l%27ann%C3%A9e_stage`` = _prefixId.prefix "Organisms_in_de%20l%27ann%C3%A9e_stage"

    let Organisms_in_ephyra_stage = _prefixId.prefix "Organisms_in_ephyra_stage"
    let Organisms_in_foetus_stage = _prefixId.prefix "Organisms_in_foetus_stage"

    let Organisms_in_gametophyte_stage = _prefixId.prefix "Organisms_in_gametophyte_stage"

    let Organisms_in_hydroïde_stage = _prefixId.prefix "Organisms_in_hydroïde_stage"
    let Organisms_in_juvénile_stage = _prefixId.prefix "Organisms_in_juvénile_stage"
    let Organisms_in_larve_stage = _prefixId.prefix "Organisms_in_larve_stage"

    let Organisms_in_macrothallus_stage = _prefixId.prefix "Organisms_in_macrothallus_stage"

    let Organisms_in_manca_stage = _prefixId.prefix "Organisms_in_manca_stage"
    let Organisms_in_megalopa_stage = _prefixId.prefix "Organisms_in_megalopa_stage"

    let Organisms_in_microthallus_stage = _prefixId.prefix "Organisms_in_microthallus_stage"

    let Organisms_in_méduse_stage = _prefixId.prefix "Organisms_in_méduse_stage"
    let Organisms_in_nauplius_stage = _prefixId.prefix "Organisms_in_nauplius_stage"
    let Organisms_in_nouveau_né_stage = _prefixId.prefix "Organisms_in_nouveau-né_stage"
    let Organisms_in_planula_stage = _prefixId.prefix "Organisms_in_planula_stage"
    let Organisms_in_polype_stage = _prefixId.prefix "Organisms_in_polype_stage"
    let Organisms_in_post_larve_stage = _prefixId.prefix "Organisms_in_post-larve_stage"
    let Organisms_in_sporophyte_stage = _prefixId.prefix "Organisms_in_sporophyte_stage"
    let Organisms_in_subadulte_stage = _prefixId.prefix "Organisms_in_subadulte_stage"
    let Organisms_in_zoea_stage = _prefixId.prefix "Organisms_in_zoea_stage"
    let Organisms_in_Œuf_stage = _prefixId.prefix "Organisms_in_Œuf_stage"
    let RdfGeneration = _prefixId.prefix "RdfGeneration"
    let Taxref2Agrovoc = _prefixId.prefix "Taxref2Agrovoc"
    let Taxref2NcbiTaxon = _prefixId.prefix "Taxref2NcbiTaxon"
    let Taxref2Worms = _prefixId.prefix "Taxref2Worms"
    let WebService = _prefixId.prefix "WebService"
    let Worms = _prefixId.prefix "Worms"
    let femelle_Organisms = _prefixId.prefix "femelle_Organisms"
    let hal01207828 = _prefixId.prefix "hal01207828"
    let hal01617708 = _prefixId.prefix "hal01617708"
    let johanmontagnat = _prefixId.prefix "johanmontagnat"
    let loicdjimenou = _prefixId.prefix "loicdjimenou"
    let mâle_Organisms = _prefixId.prefix "mâle_Organisms"
    let oliviergargominy = _prefixId.prefix "oliviergargominy"
    let sandrinetercerie = _prefixId.prefix "sandrinetercerie"
    let sparql_service = _prefixId.prefix "sparql-service"
    let taxref = _prefixId.prefix "taxref"
    let taxref_ld = _prefixId.prefix "taxref-ld"
    let taxrefmethodo = _prefixId.prefix "taxrefmethodo"
    let xR2RML = _prefixId.prefix "xR2RML"

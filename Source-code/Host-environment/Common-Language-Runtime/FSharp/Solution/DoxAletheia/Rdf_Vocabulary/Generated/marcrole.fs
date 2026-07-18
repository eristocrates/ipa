namespace http.id.loc.gov.vocabulary.relators.slash

open DoxAletheia.Rdf_Vocabulary

module marcrole =
    let _namespace_name = "http://id.loc.gov/vocabulary/relators/"

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDADistributor"></see>
    /// </summary>
    let collection_RDADistributor =
        Namespaced_IRI.parse _namespace_name "collection_RDADistributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDA"></see>
    /// </summary>
    let collection_RDA =
        Namespaced_IRI.parse _namespace_name "collection_RDA" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAWork"></see>
    /// </summary>
    let collection_RDAWork =
        Namespaced_IRI.parse _namespace_name "collection_RDAWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEWork"></see>
    /// </summary>
    let collection_BIBFRAMEWork =
        Namespaced_IRI.parse _namespace_name "collection_BIBFRAMEWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAExpression"></see>
    /// </summary>
    let collection_RDAExpression =
        Namespaced_IRI.parse _namespace_name "collection_RDAExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAOwner"></see>
    /// </summary>
    let collection_RDAOwner =
        Namespaced_IRI.parse _namespace_name "collection_RDAOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAManifestation"></see>
    /// </summary>
    let collection_RDAManifestation =
        Namespaced_IRI.parse _namespace_name "collection_RDAManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEInstance"></see>
    /// </summary>
    let collection_BIBFRAMEInstance =
        Namespaced_IRI.parse _namespace_name "collection_BIBFRAMEInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAContributor"></see>
    /// </summary>
    let collection_RDAContributor =
        Namespaced_IRI.parse _namespace_name "collection_RDAContributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDACreator"></see>
    /// </summary>
    let collection_RDACreator =
        Namespaced_IRI.parse _namespace_name "collection_RDACreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAOther"></see>
    /// </summary>
    let collection_RDAOther =
        Namespaced_IRI.parse _namespace_name "collection_RDAOther" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAManufacturer"></see>
    /// </summary>
    let collection_RDAManufacturer =
        Namespaced_IRI.parse _namespace_name "collection_RDAManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAPublisher"></see>
    /// </summary>
    let collection_RDAPublisher =
        Namespaced_IRI.parse _namespace_name "collection_RDAPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAItem"></see>
    /// </summary>
    let collection_RDAItem =
        Namespaced_IRI.parse _namespace_name "collection_RDAItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lso"></see>
    /// </summary>
    let lso = Namespaced_IRI.parse _namespace_name "lso" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/arc"></see>
    /// </summary>
    let arc = Namespaced_IRI.parse _namespace_name "arc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ppm"></see>
    /// </summary>
    let ppm = Namespaced_IRI.parse _namespace_name "ppm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctg"></see>
    /// </summary>
    let ctg = Namespaced_IRI.parse _namespace_name "ctg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpt"></see>
    /// </summary>
    let cpt = Namespaced_IRI.parse _namespace_name "cpt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dnc"></see>
    /// </summary>
    let dnc = Namespaced_IRI.parse _namespace_name "dnc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmt"></see>
    /// </summary>
    let cmt = Namespaced_IRI.parse _namespace_name "cmt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lse"></see>
    /// </summary>
    let lse = Namespaced_IRI.parse _namespace_name "lse" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dfd"></see>
    /// </summary>
    let dfd = Namespaced_IRI.parse _namespace_name "dfd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cou"></see>
    /// </summary>
    let cou = Namespaced_IRI.parse _namespace_name "cou" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prg"></see>
    /// </summary>
    let prg = Namespaced_IRI.parse _namespace_name "prg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ptf"></see>
    /// </summary>
    let ptf = Namespaced_IRI.parse _namespace_name "ptf" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ive"></see>
    /// </summary>
    let ive = Namespaced_IRI.parse _namespace_name "ive" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bdd"></see>
    /// </summary>
    let bdd = Namespaced_IRI.parse _namespace_name "bdd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/win"></see>
    /// </summary>
    let win = Namespaced_IRI.parse _namespace_name "win" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/vdg"></see>
    /// </summary>
    let vdg = Namespaced_IRI.parse _namespace_name "vdg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edm"></see>
    /// </summary>
    let edm = Namespaced_IRI.parse _namespace_name "edm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ilu"></see>
    /// </summary>
    let ilu = Namespaced_IRI.parse _namespace_name "ilu" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crr"></see>
    /// </summary>
    let crr = Namespaced_IRI.parse _namespace_name "crr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/arr"></see>
    /// </summary>
    let arr = Namespaced_IRI.parse _namespace_name "arr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsr"></see>
    /// </summary>
    let rsr = Namespaced_IRI.parse _namespace_name "rsr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pmn"></see>
    /// </summary>
    let pmn = Namespaced_IRI.parse _namespace_name "pmn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edt"></see>
    /// </summary>
    let edt = Namespaced_IRI.parse _namespace_name "edt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lgd"></see>
    /// </summary>
    let lgd = Namespaced_IRI.parse _namespace_name "lgd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spk"></see>
    /// </summary>
    let spk = Namespaced_IRI.parse _namespace_name "spk" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/coe"></see>
    /// </summary>
    let coe = Namespaced_IRI.parse _namespace_name "coe" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fnd"></see>
    /// </summary>
    let fnd = Namespaced_IRI.parse _namespace_name "fnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cot"></see>
    /// </summary>
    let cot = Namespaced_IRI.parse _namespace_name "cot" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prf"></see>
    /// </summary>
    let prf = Namespaced_IRI.parse _namespace_name "prf" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cnd"></see>
    /// </summary>
    let cnd = Namespaced_IRI.parse _namespace_name "cnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pat"></see>
    /// </summary>
    let pat = Namespaced_IRI.parse _namespace_name "pat" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prm"></see>
    /// </summary>
    let prm = Namespaced_IRI.parse _namespace_name "prm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/srv"></see>
    /// </summary>
    let srv = Namespaced_IRI.parse _namespace_name "srv" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/trl"></see>
    /// </summary>
    let trl = Namespaced_IRI.parse _namespace_name "trl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/acp"></see>
    /// </summary>
    let acp = Namespaced_IRI.parse _namespace_name "acp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wac"></see>
    /// </summary>
    let wac = Namespaced_IRI.parse _namespace_name "wac" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/eng"></see>
    /// </summary>
    let eng = Namespaced_IRI.parse _namespace_name "eng" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sec"></see>
    /// </summary>
    let sec = Namespaced_IRI.parse _namespace_name "sec" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mcp"></see>
    /// </summary>
    let mcp = Namespaced_IRI.parse _namespace_name "mcp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ccp"></see>
    /// </summary>
    let ccp = Namespaced_IRI.parse _namespace_name "ccp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pra"></see>
    /// </summary>
    let pra = Namespaced_IRI.parse _namespace_name "pra" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cre"></see>
    /// </summary>
    let cre = Namespaced_IRI.parse _namespace_name "cre" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rse"></see>
    /// </summary>
    let rse = Namespaced_IRI.parse _namespace_name "rse" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cas"></see>
    /// </summary>
    let cas = Namespaced_IRI.parse _namespace_name "cas" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edc"></see>
    /// </summary>
    let edc = Namespaced_IRI.parse _namespace_name "edc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pma"></see>
    /// </summary>
    let pma = Namespaced_IRI.parse _namespace_name "pma" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ldr"></see>
    /// </summary>
    let ldr = Namespaced_IRI.parse _namespace_name "ldr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctr"></see>
    /// </summary>
    let ctr = Namespaced_IRI.parse _namespace_name "ctr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lie"></see>
    /// </summary>
    let lie = Namespaced_IRI.parse _namespace_name "lie" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/oth"></see>
    /// </summary>
    let oth = Namespaced_IRI.parse _namespace_name "oth" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spy"></see>
    /// </summary>
    let spy = Namespaced_IRI.parse _namespace_name "spy" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lil"></see>
    /// </summary>
    let lil = Namespaced_IRI.parse _namespace_name "lil" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spn"></see>
    /// </summary>
    let spn = Namespaced_IRI.parse _namespace_name "spn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/asn"></see>
    /// </summary>
    let asn = Namespaced_IRI.parse _namespace_name "asn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lbr"></see>
    /// </summary>
    let lbr = Namespaced_IRI.parse _namespace_name "lbr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sht"></see>
    /// </summary>
    let sht = Namespaced_IRI.parse _namespace_name "sht" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpl"></see>
    /// </summary>
    let cpl = Namespaced_IRI.parse _namespace_name "cpl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wst"></see>
    /// </summary>
    let wst = Namespaced_IRI.parse _namespace_name "wst" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/chr"></see>
    /// </summary>
    let chr = Namespaced_IRI.parse _namespace_name "chr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lyr"></see>
    /// </summary>
    let lyr = Namespaced_IRI.parse _namespace_name "lyr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crt"></see>
    /// </summary>
    let crt = Namespaced_IRI.parse _namespace_name "crt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/anm"></see>
    /// </summary>
    let anm = Namespaced_IRI.parse _namespace_name "anm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpc"></see>
    /// </summary>
    let rpc = Namespaced_IRI.parse _namespace_name "rpc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bsl"></see>
    /// </summary>
    let bsl = Namespaced_IRI.parse _namespace_name "bsl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ant"></see>
    /// </summary>
    let ant = Namespaced_IRI.parse _namespace_name "ant" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fpy"></see>
    /// </summary>
    let fpy = Namespaced_IRI.parse _namespace_name "fpy" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/com"></see>
    /// </summary>
    let com = Namespaced_IRI.parse _namespace_name "com" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lit"></see>
    /// </summary>
    let lit = Namespaced_IRI.parse _namespace_name "lit" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stg"></see>
    /// </summary>
    let stg = Namespaced_IRI.parse _namespace_name "stg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mfr"></see>
    /// </summary>
    let mfr = Namespaced_IRI.parse _namespace_name "mfr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/enj"></see>
    /// </summary>
    let enj = Namespaced_IRI.parse _namespace_name "enj" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rcp"></see>
    /// </summary>
    let rcp = Namespaced_IRI.parse _namespace_name "rcp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cte"></see>
    /// </summary>
    let cte = Namespaced_IRI.parse _namespace_name "cte" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pte"></see>
    /// </summary>
    let pte = Namespaced_IRI.parse _namespace_name "pte" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/msd"></see>
    /// </summary>
    let msd = Namespaced_IRI.parse _namespace_name "msd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tyd"></see>
    /// </summary>
    let tyd = Namespaced_IRI.parse _namespace_name "tyd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stn"></see>
    /// </summary>
    let stn = Namespaced_IRI.parse _namespace_name "stn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aus"></see>
    /// </summary>
    let aus = Namespaced_IRI.parse _namespace_name "aus" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/scr"></see>
    /// </summary>
    let scr = Namespaced_IRI.parse _namespace_name "scr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/itr"></see>
    /// </summary>
    let itr = Namespaced_IRI.parse _namespace_name "itr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cns"></see>
    /// </summary>
    let cns = Namespaced_IRI.parse _namespace_name "cns" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pbd"></see>
    /// </summary>
    let pbd = Namespaced_IRI.parse _namespace_name "pbd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/trc"></see>
    /// </summary>
    let trc = Namespaced_IRI.parse _namespace_name "trc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/act"></see>
    /// </summary>
    let act = Namespaced_IRI.parse _namespace_name "act" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/hst"></see>
    /// </summary>
    let hst = Namespaced_IRI.parse _namespace_name "hst" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ths"></see>
    /// </summary>
    let ths = Namespaced_IRI.parse _namespace_name "ths" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/col"></see>
    /// </summary>
    let col = Namespaced_IRI.parse _namespace_name "col" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmp"></see>
    /// </summary>
    let fmp = Namespaced_IRI.parse _namespace_name "fmp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aqt"></see>
    /// </summary>
    let aqt = Namespaced_IRI.parse _namespace_name "aqt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/hnr"></see>
    /// </summary>
    let hnr = Namespaced_IRI.parse _namespace_name "hnr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cos"></see>
    /// </summary>
    let cos = Namespaced_IRI.parse _namespace_name "cos" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pre"></see>
    /// </summary>
    let pre = Namespaced_IRI.parse _namespace_name "pre" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rdd"></see>
    /// </summary>
    let rdd = Namespaced_IRI.parse _namespace_name "rdd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cph"></see>
    /// </summary>
    let cph = Namespaced_IRI.parse _namespace_name "cph" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stm"></see>
    /// </summary>
    let stm = Namespaced_IRI.parse _namespace_name "stm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctb"></see>
    /// </summary>
    let ctb = Namespaced_IRI.parse _namespace_name "ctb" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/osp"></see>
    /// </summary>
    let osp = Namespaced_IRI.parse _namespace_name "osp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crp"></see>
    /// </summary>
    let crp = Namespaced_IRI.parse _namespace_name "crp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ill"></see>
    /// </summary>
    let ill = Namespaced_IRI.parse _namespace_name "ill" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctt"></see>
    /// </summary>
    let ctt = Namespaced_IRI.parse _namespace_name "ctt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pbl"></see>
    /// </summary>
    let pbl = Namespaced_IRI.parse _namespace_name "pbl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bjd"></see>
    /// </summary>
    let bjd = Namespaced_IRI.parse _namespace_name "bjd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmo"></see>
    /// </summary>
    let fmo = Namespaced_IRI.parse _namespace_name "fmo" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmd"></see>
    /// </summary>
    let fmd = Namespaced_IRI.parse _namespace_name "fmd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rce"></see>
    /// </summary>
    let rce = Namespaced_IRI.parse _namespace_name "rce" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cor"></see>
    /// </summary>
    let cor = Namespaced_IRI.parse _namespace_name "cor" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/med"></see>
    /// </summary>
    let med = Namespaced_IRI.parse _namespace_name "med" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mrk"></see>
    /// </summary>
    let mrk = Namespaced_IRI.parse _namespace_name "mrk" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/asg"></see>
    /// </summary>
    let asg = Namespaced_IRI.parse _namespace_name "asg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/gis"></see>
    /// </summary>
    let gis = Namespaced_IRI.parse _namespace_name "gis" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pta"></see>
    /// </summary>
    let pta = Namespaced_IRI.parse _namespace_name "pta" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sad"></see>
    /// </summary>
    let sad = Namespaced_IRI.parse _namespace_name "sad" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wit"></see>
    /// </summary>
    let wit = Namespaced_IRI.parse _namespace_name "wit" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/scl"></see>
    /// </summary>
    let scl = Namespaced_IRI.parse _namespace_name "scl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ivr"></see>
    /// </summary>
    let ivr = Namespaced_IRI.parse _namespace_name "ivr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ape"></see>
    /// </summary>
    let ape = Namespaced_IRI.parse _namespace_name "ape" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wdc"></see>
    /// </summary>
    let wdc = Namespaced_IRI.parse _namespace_name "wdc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/apl"></see>
    /// </summary>
    let apl = Namespaced_IRI.parse _namespace_name "apl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cst"></see>
    /// </summary>
    let cst = Namespaced_IRI.parse _namespace_name "cst" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wpr"></see>
    /// </summary>
    let wpr = Namespaced_IRI.parse _namespace_name "wpr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dfe"></see>
    /// </summary>
    let dfe = Namespaced_IRI.parse _namespace_name "dfe" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/res"></see>
    /// </summary>
    let res = Namespaced_IRI.parse _namespace_name "res" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/str"></see>
    /// </summary>
    let str = Namespaced_IRI.parse _namespace_name "str" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rtm"></see>
    /// </summary>
    let rtm = Namespaced_IRI.parse _namespace_name "rtm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmk"></see>
    /// </summary>
    let fmk = Namespaced_IRI.parse _namespace_name "fmk" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/anl"></see>
    /// </summary>
    let anl = Namespaced_IRI.parse _namespace_name "anl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pop"></see>
    /// </summary>
    let pop = Namespaced_IRI.parse _namespace_name "pop" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/con"></see>
    /// </summary>
    let con = Namespaced_IRI.parse _namespace_name "con" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dto"></see>
    /// </summary>
    let dto = Namespaced_IRI.parse _namespace_name "dto" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/org"></see>
    /// </summary>
    let org = Namespaced_IRI.parse _namespace_name "org" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/csl"></see>
    /// </summary>
    let csl = Namespaced_IRI.parse _namespace_name "csl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dub"></see>
    /// </summary>
    let dub = Namespaced_IRI.parse _namespace_name "dub" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aut"></see>
    /// </summary>
    let aut = Namespaced_IRI.parse _namespace_name "aut" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sll"></see>
    /// </summary>
    let sll = Namespaced_IRI.parse _namespace_name "sll" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/his"></see>
    /// </summary>
    let his = Namespaced_IRI.parse _namespace_name "his" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prt"></see>
    /// </summary>
    let prt = Namespaced_IRI.parse _namespace_name "prt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tlp"></see>
    /// </summary>
    let tlp = Namespaced_IRI.parse _namespace_name "tlp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bkp"></see>
    /// </summary>
    let bkp = Namespaced_IRI.parse _namespace_name "bkp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/drm"></see>
    /// </summary>
    let drm = Namespaced_IRI.parse _namespace_name "drm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/isb"></see>
    /// </summary>
    let isb = Namespaced_IRI.parse _namespace_name "isb" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cov"></see>
    /// </summary>
    let cov = Namespaced_IRI.parse _namespace_name "cov" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dtc"></see>
    /// </summary>
    let dtc = Namespaced_IRI.parse _namespace_name "dtc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/csp"></see>
    /// </summary>
    let csp = Namespaced_IRI.parse _namespace_name "csp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mte"></see>
    /// </summary>
    let mte = Namespaced_IRI.parse _namespace_name "mte" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mfp"></see>
    /// </summary>
    let mfp = Namespaced_IRI.parse _namespace_name "mfp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/opn"></see>
    /// </summary>
    let opn = Namespaced_IRI.parse _namespace_name "opn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/red"></see>
    /// </summary>
    let red = Namespaced_IRI.parse _namespace_name "red" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stl"></see>
    /// </summary>
    let stl = Namespaced_IRI.parse _namespace_name "stl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cli"></see>
    /// </summary>
    let cli = Namespaced_IRI.parse _namespace_name "cli" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ins"></see>
    /// </summary>
    let ins = Namespaced_IRI.parse _namespace_name "ins" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sce"></see>
    /// </summary>
    let sce = Namespaced_IRI.parse _namespace_name "sce" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/clr"></see>
    /// </summary>
    let clr = Namespaced_IRI.parse _namespace_name "clr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/app"></see>
    /// </summary>
    let app = Namespaced_IRI.parse _namespace_name "app" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rcd"></see>
    /// </summary>
    let rcd = Namespaced_IRI.parse _namespace_name "rcd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rth"></see>
    /// </summary>
    let rth = Namespaced_IRI.parse _namespace_name "rth" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/elt"></see>
    /// </summary>
    let elt = Namespaced_IRI.parse _namespace_name "elt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mtk"></see>
    /// </summary>
    let mtk = Namespaced_IRI.parse _namespace_name "mtk" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dpt"></see>
    /// </summary>
    let dpt = Namespaced_IRI.parse _namespace_name "dpt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cwt"></see>
    /// </summary>
    let cwt = Namespaced_IRI.parse _namespace_name "cwt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/adi"></see>
    /// </summary>
    let adi = Namespaced_IRI.parse _namespace_name "adi" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cng"></see>
    /// </summary>
    let cng = Namespaced_IRI.parse _namespace_name "cng" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/etr"></see>
    /// </summary>
    let etr = Namespaced_IRI.parse _namespace_name "etr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prp"></see>
    /// </summary>
    let prp = Namespaced_IRI.parse _namespace_name "prp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/nrt"></see>
    /// </summary>
    let nrt = Namespaced_IRI.parse _namespace_name "nrt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/adp"></see>
    /// </summary>
    let adp = Namespaced_IRI.parse _namespace_name "adp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ann"></see>
    /// </summary>
    let ann = Namespaced_IRI.parse _namespace_name "ann" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aft"></see>
    /// </summary>
    let aft = Namespaced_IRI.parse _namespace_name "aft" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bnd"></see>
    /// </summary>
    let bnd = Namespaced_IRI.parse _namespace_name "bnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsp"></see>
    /// </summary>
    let rsp = Namespaced_IRI.parse _namespace_name "rsp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/blw"></see>
    /// </summary>
    let blw = Namespaced_IRI.parse _namespace_name "blw" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lee"></see>
    /// </summary>
    let lee = Namespaced_IRI.parse _namespace_name "lee" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tch"></see>
    /// </summary>
    let tch = Namespaced_IRI.parse _namespace_name "tch" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rps"></see>
    /// </summary>
    let rps = Namespaced_IRI.parse _namespace_name "rps" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aud"></see>
    /// </summary>
    let aud = Namespaced_IRI.parse _namespace_name "aud" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/len"></see>
    /// </summary>
    let len = Namespaced_IRI.parse _namespace_name "len" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dbp"></see>
    /// </summary>
    let dbp = Namespaced_IRI.parse _namespace_name "dbp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ppt"></see>
    /// </summary>
    let ppt = Namespaced_IRI.parse _namespace_name "ppt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wam"></see>
    /// </summary>
    let wam = Namespaced_IRI.parse _namespace_name "wam" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prd"></see>
    /// </summary>
    let prd = Namespaced_IRI.parse _namespace_name "prd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cll"></see>
    /// </summary>
    let cll = Namespaced_IRI.parse _namespace_name "cll" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mdc"></see>
    /// </summary>
    let mdc = Namespaced_IRI.parse _namespace_name "mdc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tld"></see>
    /// </summary>
    let tld = Namespaced_IRI.parse _namespace_name "tld" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/inv"></see>
    /// </summary>
    let inv = Namespaced_IRI.parse _namespace_name "inv" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sgn"></see>
    /// </summary>
    let sgn = Namespaced_IRI.parse _namespace_name "sgn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/own"></see>
    /// </summary>
    let own = Namespaced_IRI.parse _namespace_name "own" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dsr"></see>
    /// </summary>
    let dsr = Namespaced_IRI.parse _namespace_name "dsr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ltg"></see>
    /// </summary>
    let ltg = Namespaced_IRI.parse _namespace_name "ltg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/elg"></see>
    /// </summary>
    let elg = Namespaced_IRI.parse _namespace_name "elg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dte"></see>
    /// </summary>
    let dte = Namespaced_IRI.parse _namespace_name "dte" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpy"></see>
    /// </summary>
    let rpy = Namespaced_IRI.parse _namespace_name "rpy" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wal"></see>
    /// </summary>
    let wal = Namespaced_IRI.parse _namespace_name "wal" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fac"></see>
    /// </summary>
    let fac = Namespaced_IRI.parse _namespace_name "fac" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/let"></see>
    /// </summary>
    let let_ = Namespaced_IRI.parse _namespace_name "let" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/jug"></see>
    /// </summary>
    let jug = Namespaced_IRI.parse _namespace_name "jug" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tyg"></see>
    /// </summary>
    let tyg = Namespaced_IRI.parse _namespace_name "tyg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/clt"></see>
    /// </summary>
    let clt = Namespaced_IRI.parse _namespace_name "clt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mon"></see>
    /// </summary>
    let mon = Namespaced_IRI.parse _namespace_name "mon" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ptt"></see>
    /// </summary>
    let ptt = Namespaced_IRI.parse _namespace_name "ptt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/exp"></see>
    /// </summary>
    let exp = Namespaced_IRI.parse _namespace_name "exp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prs"></see>
    /// </summary>
    let prs = Namespaced_IRI.parse _namespace_name "prs" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pdr"></see>
    /// </summary>
    let pdr = Namespaced_IRI.parse _namespace_name "pdr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dtm"></see>
    /// </summary>
    let dtm = Namespaced_IRI.parse _namespace_name "dtm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tcd"></see>
    /// </summary>
    let tcd = Namespaced_IRI.parse _namespace_name "tcd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/att"></see>
    /// </summary>
    let att = Namespaced_IRI.parse _namespace_name "att" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/std"></see>
    /// </summary>
    let std = Namespaced_IRI.parse _namespace_name "std" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ren"></see>
    /// </summary>
    let ren = Namespaced_IRI.parse _namespace_name "ren" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aui"></see>
    /// </summary>
    let aui = Namespaced_IRI.parse _namespace_name "aui" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/brl"></see>
    /// </summary>
    let brl = Namespaced_IRI.parse _namespace_name "brl" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wat"></see>
    /// </summary>
    let wat = Namespaced_IRI.parse _namespace_name "wat" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/uvp"></see>
    /// </summary>
    let uvp = Namespaced_IRI.parse _namespace_name "uvp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpc"></see>
    /// </summary>
    let cpc = Namespaced_IRI.parse _namespace_name "cpc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pan"></see>
    /// </summary>
    let pan = Namespaced_IRI.parse _namespace_name "pan" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/evp"></see>
    /// </summary>
    let evp = Namespaced_IRI.parse _namespace_name "evp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/jud"></see>
    /// </summary>
    let jud = Namespaced_IRI.parse _namespace_name "jud" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rbr"></see>
    /// </summary>
    let rbr = Namespaced_IRI.parse _namespace_name "rbr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pth"></see>
    /// </summary>
    let pth = Namespaced_IRI.parse _namespace_name "pth" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/art"></see>
    /// </summary>
    let art = Namespaced_IRI.parse _namespace_name "art" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rst"></see>
    /// </summary>
    let rst = Namespaced_IRI.parse _namespace_name "rst" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pht"></see>
    /// </summary>
    let pht = Namespaced_IRI.parse _namespace_name "pht" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dis"></see>
    /// </summary>
    let dis = Namespaced_IRI.parse _namespace_name "dis" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mrb"></see>
    /// </summary>
    let mrb = Namespaced_IRI.parse _namespace_name "mrb" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rev"></see>
    /// </summary>
    let rev = Namespaced_IRI.parse _namespace_name "rev" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/abr"></see>
    /// </summary>
    let abr = Namespaced_IRI.parse _namespace_name "abr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wde"></see>
    /// </summary>
    let wde = Namespaced_IRI.parse _namespace_name "wde" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bkd"></see>
    /// </summary>
    let bkd = Namespaced_IRI.parse _namespace_name "bkd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/vac"></see>
    /// </summary>
    let vac = Namespaced_IRI.parse _namespace_name "vac" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pro"></see>
    /// </summary>
    let pro = Namespaced_IRI.parse _namespace_name "pro" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dst"></see>
    /// </summary>
    let dst = Namespaced_IRI.parse _namespace_name "dst" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dgs"></see>
    /// </summary>
    let dgs = Namespaced_IRI.parse _namespace_name "dgs" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpt"></see>
    /// </summary>
    let rpt = Namespaced_IRI.parse _namespace_name "rpt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bpd"></see>
    /// </summary>
    let bpd = Namespaced_IRI.parse _namespace_name "bpd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pup"></see>
    /// </summary>
    let pup = Namespaced_IRI.parse _namespace_name "pup" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/led"></see>
    /// </summary>
    let led = Namespaced_IRI.parse _namespace_name "led" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmp"></see>
    /// </summary>
    let cmp = Namespaced_IRI.parse _namespace_name "cmp" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/auc"></see>
    /// </summary>
    let auc = Namespaced_IRI.parse _namespace_name "auc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fld"></see>
    /// </summary>
    let fld = Namespaced_IRI.parse _namespace_name "fld" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lsa"></see>
    /// </summary>
    let lsa = Namespaced_IRI.parse _namespace_name "lsa" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/egr"></see>
    /// </summary>
    let egr = Namespaced_IRI.parse _namespace_name "egr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/flm"></see>
    /// </summary>
    let flm = Namespaced_IRI.parse _namespace_name "flm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dft"></see>
    /// </summary>
    let dft = Namespaced_IRI.parse _namespace_name "dft" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prn"></see>
    /// </summary>
    let prn = Namespaced_IRI.parse _namespace_name "prn" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sgd"></see>
    /// </summary>
    let sgd = Namespaced_IRI.parse _namespace_name "sgd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fds"></see>
    /// </summary>
    let fds = Namespaced_IRI.parse _namespace_name "fds" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prc"></see>
    /// </summary>
    let prc = Namespaced_IRI.parse _namespace_name "prc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/frg"></see>
    /// </summary>
    let frg = Namespaced_IRI.parse _namespace_name "frg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsg"></see>
    /// </summary>
    let rsg = Namespaced_IRI.parse _namespace_name "rsg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dgg"></see>
    /// </summary>
    let dgg = Namespaced_IRI.parse _namespace_name "dgg" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dln"></see>
    /// </summary>
    let dln = Namespaced_IRI.parse _namespace_name "dln" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ato"></see>
    /// </summary>
    let ato = Namespaced_IRI.parse _namespace_name "ato" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dnr"></see>
    /// </summary>
    let dnr = Namespaced_IRI.parse _namespace_name "dnr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/orm"></see>
    /// </summary>
    let orm = Namespaced_IRI.parse _namespace_name "orm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cur"></see>
    /// </summary>
    let cur = Namespaced_IRI.parse _namespace_name "cur" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lel"></see>
    /// </summary>
    let lel = Namespaced_IRI.parse _namespace_name "lel" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/drt"></see>
    /// </summary>
    let drt = Namespaced_IRI.parse _namespace_name "drt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmm"></see>
    /// </summary>
    let cmm = Namespaced_IRI.parse _namespace_name "cmm" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpe"></see>
    /// </summary>
    let cpe = Namespaced_IRI.parse _namespace_name "cpe" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prv"></see>
    /// </summary>
    let prv = Namespaced_IRI.parse _namespace_name "prv" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mod"></see>
    /// </summary>
    let mod_ = Namespaced_IRI.parse _namespace_name "mod" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lbt"></see>
    /// </summary>
    let lbt = Namespaced_IRI.parse _namespace_name "lbt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ard"></see>
    /// </summary>
    let ard = Namespaced_IRI.parse _namespace_name "ard" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cts"></see>
    /// </summary>
    let cts = Namespaced_IRI.parse _namespace_name "cts" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pfr"></see>
    /// </summary>
    let pfr = Namespaced_IRI.parse _namespace_name "pfr" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/brd"></see>
    /// </summary>
    let brd = Namespaced_IRI.parse _namespace_name "brd" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dpc"></see>
    /// </summary>
    let dpc = Namespaced_IRI.parse _namespace_name "dpc" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sng"></see>
    /// </summary>
    let sng = Namespaced_IRI.parse _namespace_name "sng" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sds"></see>
    /// </summary>
    let sds = Namespaced_IRI.parse _namespace_name "sds" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mus"></see>
    /// </summary>
    let mus = Namespaced_IRI.parse _namespace_name "mus" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/plt"></see>
    /// </summary>
    let plt = Namespaced_IRI.parse _namespace_name "plt" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lei"></see>
    /// </summary>
    let lei = Namespaced_IRI.parse _namespace_name "lei" |> NamespacedName

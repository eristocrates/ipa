namespace http.id.loc.gov.vocabulary.relators.slash

open DoxAletheia

module marcrole =
    let _namespace_name = "http://id.loc.gov/vocabulary/relators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDADistributor"></see>
    /// </summary>
    let collection_RDADistributor = _prefix "collection_RDADistributor"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDA"></see>
    /// </summary>
    let collection_RDA = _prefix "collection_RDA"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAWork"></see>
    /// </summary>
    let collection_RDAWork = _prefix "collection_RDAWork"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEWork"></see>
    /// </summary>
    let collection_BIBFRAMEWork = _prefix "collection_BIBFRAMEWork"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAExpression"></see>
    /// </summary>
    let collection_RDAExpression = _prefix "collection_RDAExpression"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAOwner"></see>
    /// </summary>
    let collection_RDAOwner = _prefix "collection_RDAOwner"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAManifestation"></see>
    /// </summary>
    let collection_RDAManifestation = _prefix "collection_RDAManifestation"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_BIBFRAMEInstance"></see>
    /// </summary>
    let collection_BIBFRAMEInstance = _prefix "collection_BIBFRAMEInstance"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAContributor"></see>
    /// </summary>
    let collection_RDAContributor = _prefix "collection_RDAContributor"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDACreator"></see>
    /// </summary>
    let collection_RDACreator = _prefix "collection_RDACreator"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAOther"></see>
    /// </summary>
    let collection_RDAOther = _prefix "collection_RDAOther"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAManufacturer"></see>
    /// </summary>
    let collection_RDAManufacturer = _prefix "collection_RDAManufacturer"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAPublisher"></see>
    /// </summary>
    let collection_RDAPublisher = _prefix "collection_RDAPublisher"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/collection_RDAItem"></see>
    /// </summary>
    let collection_RDAItem = _prefix "collection_RDAItem"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lso"></see>
    /// </summary>
    let lso = _prefix "lso"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/arc"></see>
    /// </summary>
    let arc = _prefix "arc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ppm"></see>
    /// </summary>
    let ppm = _prefix "ppm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctg"></see>
    /// </summary>
    let ctg = _prefix "ctg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpt"></see>
    /// </summary>
    let cpt = _prefix "cpt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dnc"></see>
    /// </summary>
    let dnc = _prefix "dnc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmt"></see>
    /// </summary>
    let cmt = _prefix "cmt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lse"></see>
    /// </summary>
    let lse = _prefix "lse"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dfd"></see>
    /// </summary>
    let dfd = _prefix "dfd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cou"></see>
    /// </summary>
    let cou = _prefix "cou"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prg"></see>
    /// </summary>
    let prg = _prefix "prg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ptf"></see>
    /// </summary>
    let ptf = _prefix "ptf"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ive"></see>
    /// </summary>
    let ive = _prefix "ive"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bdd"></see>
    /// </summary>
    let bdd = _prefix "bdd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/win"></see>
    /// </summary>
    let win = _prefix "win"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/vdg"></see>
    /// </summary>
    let vdg = _prefix "vdg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edm"></see>
    /// </summary>
    let edm = _prefix "edm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ilu"></see>
    /// </summary>
    let ilu = _prefix "ilu"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crr"></see>
    /// </summary>
    let crr = _prefix "crr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/arr"></see>
    /// </summary>
    let arr = _prefix "arr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsr"></see>
    /// </summary>
    let rsr = _prefix "rsr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pmn"></see>
    /// </summary>
    let pmn = _prefix "pmn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edt"></see>
    /// </summary>
    let edt = _prefix "edt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lgd"></see>
    /// </summary>
    let lgd = _prefix "lgd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spk"></see>
    /// </summary>
    let spk = _prefix "spk"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/coe"></see>
    /// </summary>
    let coe = _prefix "coe"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fnd"></see>
    /// </summary>
    let fnd = _prefix "fnd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cot"></see>
    /// </summary>
    let cot = _prefix "cot"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prf"></see>
    /// </summary>
    let prf = _prefix "prf"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cnd"></see>
    /// </summary>
    let cnd = _prefix "cnd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pat"></see>
    /// </summary>
    let pat = _prefix "pat"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prm"></see>
    /// </summary>
    let prm = _prefix "prm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/srv"></see>
    /// </summary>
    let srv = _prefix "srv"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/trl"></see>
    /// </summary>
    let trl = _prefix "trl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/acp"></see>
    /// </summary>
    let acp = _prefix "acp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wac"></see>
    /// </summary>
    let wac = _prefix "wac"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/eng"></see>
    /// </summary>
    let eng = _prefix "eng"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sec"></see>
    /// </summary>
    let sec = _prefix "sec"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mcp"></see>
    /// </summary>
    let mcp = _prefix "mcp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ccp"></see>
    /// </summary>
    let ccp = _prefix "ccp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pra"></see>
    /// </summary>
    let pra = _prefix "pra"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cre"></see>
    /// </summary>
    let cre = _prefix "cre"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rse"></see>
    /// </summary>
    let rse = _prefix "rse"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cas"></see>
    /// </summary>
    let cas = _prefix "cas"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/edc"></see>
    /// </summary>
    let edc = _prefix "edc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pma"></see>
    /// </summary>
    let pma = _prefix "pma"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ldr"></see>
    /// </summary>
    let ldr = _prefix "ldr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctr"></see>
    /// </summary>
    let ctr = _prefix "ctr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lie"></see>
    /// </summary>
    let lie = _prefix "lie"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/oth"></see>
    /// </summary>
    let oth = _prefix "oth"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spy"></see>
    /// </summary>
    let spy = _prefix "spy"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lil"></see>
    /// </summary>
    let lil = _prefix "lil"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/spn"></see>
    /// </summary>
    let spn = _prefix "spn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/asn"></see>
    /// </summary>
    let asn = _prefix "asn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lbr"></see>
    /// </summary>
    let lbr = _prefix "lbr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sht"></see>
    /// </summary>
    let sht = _prefix "sht"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpl"></see>
    /// </summary>
    let cpl = _prefix "cpl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wst"></see>
    /// </summary>
    let wst = _prefix "wst"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/chr"></see>
    /// </summary>
    let chr = _prefix "chr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lyr"></see>
    /// </summary>
    let lyr = _prefix "lyr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crt"></see>
    /// </summary>
    let crt = _prefix "crt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/anm"></see>
    /// </summary>
    let anm = _prefix "anm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpc"></see>
    /// </summary>
    let rpc = _prefix "rpc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bsl"></see>
    /// </summary>
    let bsl = _prefix "bsl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ant"></see>
    /// </summary>
    let ant = _prefix "ant"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fpy"></see>
    /// </summary>
    let fpy = _prefix "fpy"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/com"></see>
    /// </summary>
    let com = _prefix "com"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lit"></see>
    /// </summary>
    let lit = _prefix "lit"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stg"></see>
    /// </summary>
    let stg = _prefix "stg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mfr"></see>
    /// </summary>
    let mfr = _prefix "mfr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/enj"></see>
    /// </summary>
    let enj = _prefix "enj"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rcp"></see>
    /// </summary>
    let rcp = _prefix "rcp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cte"></see>
    /// </summary>
    let cte = _prefix "cte"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pte"></see>
    /// </summary>
    let pte = _prefix "pte"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/msd"></see>
    /// </summary>
    let msd = _prefix "msd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tyd"></see>
    /// </summary>
    let tyd = _prefix "tyd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stn"></see>
    /// </summary>
    let stn = _prefix "stn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aus"></see>
    /// </summary>
    let aus = _prefix "aus"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/scr"></see>
    /// </summary>
    let scr = _prefix "scr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/itr"></see>
    /// </summary>
    let itr = _prefix "itr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cns"></see>
    /// </summary>
    let cns = _prefix "cns"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pbd"></see>
    /// </summary>
    let pbd = _prefix "pbd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/trc"></see>
    /// </summary>
    let trc = _prefix "trc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/act"></see>
    /// </summary>
    let act = _prefix "act"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/hst"></see>
    /// </summary>
    let hst = _prefix "hst"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ths"></see>
    /// </summary>
    let ths = _prefix "ths"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/col"></see>
    /// </summary>
    let col = _prefix "col"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmp"></see>
    /// </summary>
    let fmp = _prefix "fmp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aqt"></see>
    /// </summary>
    let aqt = _prefix "aqt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/hnr"></see>
    /// </summary>
    let hnr = _prefix "hnr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cos"></see>
    /// </summary>
    let cos = _prefix "cos"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pre"></see>
    /// </summary>
    let pre = _prefix "pre"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rdd"></see>
    /// </summary>
    let rdd = _prefix "rdd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cph"></see>
    /// </summary>
    let cph = _prefix "cph"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stm"></see>
    /// </summary>
    let stm = _prefix "stm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctb"></see>
    /// </summary>
    let ctb = _prefix "ctb"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/osp"></see>
    /// </summary>
    let osp = _prefix "osp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/crp"></see>
    /// </summary>
    let crp = _prefix "crp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ill"></see>
    /// </summary>
    let ill = _prefix "ill"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ctt"></see>
    /// </summary>
    let ctt = _prefix "ctt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pbl"></see>
    /// </summary>
    let pbl = _prefix "pbl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bjd"></see>
    /// </summary>
    let bjd = _prefix "bjd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmo"></see>
    /// </summary>
    let fmo = _prefix "fmo"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmd"></see>
    /// </summary>
    let fmd = _prefix "fmd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rce"></see>
    /// </summary>
    let rce = _prefix "rce"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cor"></see>
    /// </summary>
    let cor = _prefix "cor"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/med"></see>
    /// </summary>
    let med = _prefix "med"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mrk"></see>
    /// </summary>
    let mrk = _prefix "mrk"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/asg"></see>
    /// </summary>
    let asg = _prefix "asg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/gis"></see>
    /// </summary>
    let gis = _prefix "gis"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pta"></see>
    /// </summary>
    let pta = _prefix "pta"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sad"></see>
    /// </summary>
    let sad = _prefix "sad"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wit"></see>
    /// </summary>
    let wit = _prefix "wit"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/scl"></see>
    /// </summary>
    let scl = _prefix "scl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ivr"></see>
    /// </summary>
    let ivr = _prefix "ivr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ape"></see>
    /// </summary>
    let ape = _prefix "ape"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wdc"></see>
    /// </summary>
    let wdc = _prefix "wdc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/apl"></see>
    /// </summary>
    let apl = _prefix "apl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cst"></see>
    /// </summary>
    let cst = _prefix "cst"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wpr"></see>
    /// </summary>
    let wpr = _prefix "wpr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dfe"></see>
    /// </summary>
    let dfe = _prefix "dfe"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/res"></see>
    /// </summary>
    let res = _prefix "res"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/str"></see>
    /// </summary>
    let str = _prefix "str"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rtm"></see>
    /// </summary>
    let rtm = _prefix "rtm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fmk"></see>
    /// </summary>
    let fmk = _prefix "fmk"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/anl"></see>
    /// </summary>
    let anl = _prefix "anl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pop"></see>
    /// </summary>
    let pop = _prefix "pop"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/con"></see>
    /// </summary>
    let con = _prefix "con"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dto"></see>
    /// </summary>
    let dto = _prefix "dto"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/org"></see>
    /// </summary>
    let org = _prefix "org"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/csl"></see>
    /// </summary>
    let csl = _prefix "csl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dub"></see>
    /// </summary>
    let dub = _prefix "dub"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aut"></see>
    /// </summary>
    let aut = _prefix "aut"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sll"></see>
    /// </summary>
    let sll = _prefix "sll"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/his"></see>
    /// </summary>
    let his = _prefix "his"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prt"></see>
    /// </summary>
    let prt = _prefix "prt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tlp"></see>
    /// </summary>
    let tlp = _prefix "tlp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bkp"></see>
    /// </summary>
    let bkp = _prefix "bkp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/drm"></see>
    /// </summary>
    let drm = _prefix "drm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/isb"></see>
    /// </summary>
    let isb = _prefix "isb"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cov"></see>
    /// </summary>
    let cov = _prefix "cov"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dtc"></see>
    /// </summary>
    let dtc = _prefix "dtc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/csp"></see>
    /// </summary>
    let csp = _prefix "csp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mte"></see>
    /// </summary>
    let mte = _prefix "mte"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mfp"></see>
    /// </summary>
    let mfp = _prefix "mfp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/opn"></see>
    /// </summary>
    let opn = _prefix "opn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/red"></see>
    /// </summary>
    let red = _prefix "red"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/stl"></see>
    /// </summary>
    let stl = _prefix "stl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cli"></see>
    /// </summary>
    let cli = _prefix "cli"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ins"></see>
    /// </summary>
    let ins = _prefix "ins"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sce"></see>
    /// </summary>
    let sce = _prefix "sce"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/clr"></see>
    /// </summary>
    let clr = _prefix "clr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/app"></see>
    /// </summary>
    let app = _prefix "app"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rcd"></see>
    /// </summary>
    let rcd = _prefix "rcd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rth"></see>
    /// </summary>
    let rth = _prefix "rth"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/elt"></see>
    /// </summary>
    let elt = _prefix "elt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mtk"></see>
    /// </summary>
    let mtk = _prefix "mtk"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dpt"></see>
    /// </summary>
    let dpt = _prefix "dpt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cwt"></see>
    /// </summary>
    let cwt = _prefix "cwt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/adi"></see>
    /// </summary>
    let adi = _prefix "adi"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cng"></see>
    /// </summary>
    let cng = _prefix "cng"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/etr"></see>
    /// </summary>
    let etr = _prefix "etr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prp"></see>
    /// </summary>
    let prp = _prefix "prp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/nrt"></see>
    /// </summary>
    let nrt = _prefix "nrt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/adp"></see>
    /// </summary>
    let adp = _prefix "adp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ann"></see>
    /// </summary>
    let ann = _prefix "ann"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aft"></see>
    /// </summary>
    let aft = _prefix "aft"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bnd"></see>
    /// </summary>
    let bnd = _prefix "bnd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsp"></see>
    /// </summary>
    let rsp = _prefix "rsp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/blw"></see>
    /// </summary>
    let blw = _prefix "blw"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lee"></see>
    /// </summary>
    let lee = _prefix "lee"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tch"></see>
    /// </summary>
    let tch = _prefix "tch"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rps"></see>
    /// </summary>
    let rps = _prefix "rps"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aud"></see>
    /// </summary>
    let aud = _prefix "aud"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/len"></see>
    /// </summary>
    let len = _prefix "len"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dbp"></see>
    /// </summary>
    let dbp = _prefix "dbp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ppt"></see>
    /// </summary>
    let ppt = _prefix "ppt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wam"></see>
    /// </summary>
    let wam = _prefix "wam"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prd"></see>
    /// </summary>
    let prd = _prefix "prd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cll"></see>
    /// </summary>
    let cll = _prefix "cll"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mdc"></see>
    /// </summary>
    let mdc = _prefix "mdc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tld"></see>
    /// </summary>
    let tld = _prefix "tld"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/inv"></see>
    /// </summary>
    let inv = _prefix "inv"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sgn"></see>
    /// </summary>
    let sgn = _prefix "sgn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/own"></see>
    /// </summary>
    let own = _prefix "own"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dsr"></see>
    /// </summary>
    let dsr = _prefix "dsr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ltg"></see>
    /// </summary>
    let ltg = _prefix "ltg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/elg"></see>
    /// </summary>
    let elg = _prefix "elg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dte"></see>
    /// </summary>
    let dte = _prefix "dte"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpy"></see>
    /// </summary>
    let rpy = _prefix "rpy"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wal"></see>
    /// </summary>
    let wal = _prefix "wal"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fac"></see>
    /// </summary>
    let fac = _prefix "fac"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/let"></see>
    /// </summary>
    let let_ = _prefix "let"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/jug"></see>
    /// </summary>
    let jug = _prefix "jug"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tyg"></see>
    /// </summary>
    let tyg = _prefix "tyg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/clt"></see>
    /// </summary>
    let clt = _prefix "clt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mon"></see>
    /// </summary>
    let mon = _prefix "mon"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ptt"></see>
    /// </summary>
    let ptt = _prefix "ptt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/exp"></see>
    /// </summary>
    let exp = _prefix "exp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prs"></see>
    /// </summary>
    let prs = _prefix "prs"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pdr"></see>
    /// </summary>
    let pdr = _prefix "pdr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dtm"></see>
    /// </summary>
    let dtm = _prefix "dtm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/tcd"></see>
    /// </summary>
    let tcd = _prefix "tcd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/att"></see>
    /// </summary>
    let att = _prefix "att"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/std"></see>
    /// </summary>
    let std = _prefix "std"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ren"></see>
    /// </summary>
    let ren = _prefix "ren"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/aui"></see>
    /// </summary>
    let aui = _prefix "aui"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/brl"></see>
    /// </summary>
    let brl = _prefix "brl"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wat"></see>
    /// </summary>
    let wat = _prefix "wat"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/uvp"></see>
    /// </summary>
    let uvp = _prefix "uvp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpc"></see>
    /// </summary>
    let cpc = _prefix "cpc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pan"></see>
    /// </summary>
    let pan = _prefix "pan"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/evp"></see>
    /// </summary>
    let evp = _prefix "evp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/jud"></see>
    /// </summary>
    let jud = _prefix "jud"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rbr"></see>
    /// </summary>
    let rbr = _prefix "rbr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pth"></see>
    /// </summary>
    let pth = _prefix "pth"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/art"></see>
    /// </summary>
    let art = _prefix "art"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rst"></see>
    /// </summary>
    let rst = _prefix "rst"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pht"></see>
    /// </summary>
    let pht = _prefix "pht"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dis"></see>
    /// </summary>
    let dis = _prefix "dis"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mrb"></see>
    /// </summary>
    let mrb = _prefix "mrb"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rev"></see>
    /// </summary>
    let rev = _prefix "rev"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/abr"></see>
    /// </summary>
    let abr = _prefix "abr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/wde"></see>
    /// </summary>
    let wde = _prefix "wde"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bkd"></see>
    /// </summary>
    let bkd = _prefix "bkd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/vac"></see>
    /// </summary>
    let vac = _prefix "vac"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pro"></see>
    /// </summary>
    let pro = _prefix "pro"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dst"></see>
    /// </summary>
    let dst = _prefix "dst"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dgs"></see>
    /// </summary>
    let dgs = _prefix "dgs"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rpt"></see>
    /// </summary>
    let rpt = _prefix "rpt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/bpd"></see>
    /// </summary>
    let bpd = _prefix "bpd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pup"></see>
    /// </summary>
    let pup = _prefix "pup"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/led"></see>
    /// </summary>
    let led = _prefix "led"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmp"></see>
    /// </summary>
    let cmp = _prefix "cmp"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/auc"></see>
    /// </summary>
    let auc = _prefix "auc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fld"></see>
    /// </summary>
    let fld = _prefix "fld"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lsa"></see>
    /// </summary>
    let lsa = _prefix "lsa"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/egr"></see>
    /// </summary>
    let egr = _prefix "egr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/flm"></see>
    /// </summary>
    let flm = _prefix "flm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dft"></see>
    /// </summary>
    let dft = _prefix "dft"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prn"></see>
    /// </summary>
    let prn = _prefix "prn"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sgd"></see>
    /// </summary>
    let sgd = _prefix "sgd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/fds"></see>
    /// </summary>
    let fds = _prefix "fds"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prc"></see>
    /// </summary>
    let prc = _prefix "prc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/frg"></see>
    /// </summary>
    let frg = _prefix "frg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/rsg"></see>
    /// </summary>
    let rsg = _prefix "rsg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dgg"></see>
    /// </summary>
    let dgg = _prefix "dgg"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dln"></see>
    /// </summary>
    let dln = _prefix "dln"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ato"></see>
    /// </summary>
    let ato = _prefix "ato"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dnr"></see>
    /// </summary>
    let dnr = _prefix "dnr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/orm"></see>
    /// </summary>
    let orm = _prefix "orm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cur"></see>
    /// </summary>
    let cur = _prefix "cur"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lel"></see>
    /// </summary>
    let lel = _prefix "lel"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/drt"></see>
    /// </summary>
    let drt = _prefix "drt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cmm"></see>
    /// </summary>
    let cmm = _prefix "cmm"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cpe"></see>
    /// </summary>
    let cpe = _prefix "cpe"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/prv"></see>
    /// </summary>
    let prv = _prefix "prv"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mod"></see>
    /// </summary>
    let mod_ = _prefix "mod"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lbt"></see>
    /// </summary>
    let lbt = _prefix "lbt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/ard"></see>
    /// </summary>
    let ard = _prefix "ard"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/cts"></see>
    /// </summary>
    let cts = _prefix "cts"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/pfr"></see>
    /// </summary>
    let pfr = _prefix "pfr"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/brd"></see>
    /// </summary>
    let brd = _prefix "brd"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/dpc"></see>
    /// </summary>
    let dpc = _prefix "dpc"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sng"></see>
    /// </summary>
    let sng = _prefix "sng"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/sds"></see>
    /// </summary>
    let sds = _prefix "sds"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/mus"></see>
    /// </summary>
    let mus = _prefix "mus"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/plt"></see>
    /// </summary>
    let plt = _prefix "plt"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/role"></see>
    /// </summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://id.loc.gov/vocabulary/relators/lei"></see>
    /// </summary>
    let lei = _prefix "lei"

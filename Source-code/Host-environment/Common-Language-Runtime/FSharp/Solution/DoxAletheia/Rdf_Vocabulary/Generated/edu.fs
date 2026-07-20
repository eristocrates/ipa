namespace https.schema.edu.ee.slash

open DoxAletheia

module edu =
    let _namespace_name = "https://schema.edu.ee/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/#Opivaljund"></see>
    /// </summary>
    let ``_#Opivaljund`` = _prefix "#Opivaljund"
    /// <summary>
    ///   <see href="https://schema.edu.ee/#Oppematerjal"></see>
    /// </summary>
    let ``_#Oppematerjal`` = _prefix "#Oppematerjal"
    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1"></see>
    /// </summary>
    let ``_0.1`` = _prefix "0.1"
    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` = _prefix "0.1/html"
    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1/"></see>
    /// </summary>
    let ``_0.1/`` = _prefix "0.1/"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Ainekava"></see>
    /// </summary>
    let Ainekava = _prefix "Ainekava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppekava"></see>
    /// </summary>
    let Oppekava = _prefix "Oppekava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Ainevaldkond"></see>
    /// </summary>
    let Ainevaldkond = _prefix "Ainevaldkond"
    /// <summary>
    ///   <see href="https://schema.edu.ee/AinevaldkonnaPadevus"></see>
    /// </summary>
    let AinevaldkonnaPadevus = _prefix "AinevaldkonnaPadevus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Padevus"></see>
    /// </summary>
    let Padevus = _prefix "Padevus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Haridusaste"></see>
    /// </summary>
    let Haridusaste = _prefix "Haridusaste"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Hoiak"></see>
    /// </summary>
    let Hoiak = _prefix "Hoiak"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Opivaljund"></see>
    /// </summary>
    let Opivaljund = _prefix "Opivaljund"
    /// <summary>
    ///   <see href="https://schema.edu.ee/IndividuaalneOppekava"></see>
    /// </summary>
    let IndividuaalneOppekava = _prefix "IndividuaalneOppekava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Kontrolltoo"></see>
    /// </summary>
    let Kontrolltoo = _prefix "Kontrolltoo"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Test"></see>
    /// </summary>
    let Test = _prefix "Test"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Koolitus"></see>
    /// </summary>
    let Koolitus = _prefix "Koolitus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Kusimus"></see>
    /// </summary>
    let Kusimus = _prefix "Kusimus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/OpetajaTookava"></see>
    /// </summary>
    let OpetajaTookava = _prefix "OpetajaTookava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Opirada"></see>
    /// </summary>
    let Opirada = _prefix "Opirada"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Opitulemus"></see>
    /// </summary>
    let Opitulemus = _prefix "Opitulemus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppeaine"></see>
    /// </summary>
    let Oppeaine = _prefix "Oppeaine"
    /// <summary>
    ///   <see href="https://schema.edu.ee/OppeasutuseOppekava"></see>
    /// </summary>
    let OppeasutuseOppekava = _prefix "OppeasutuseOppekava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppematerjal"></see>
    /// </summary>
    let Oppematerjal = _prefix "Oppematerjal"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oskus"></see>
    /// </summary>
    let Oskus = _prefix "Oskus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/RiiklikOppekava"></see>
    /// </summary>
    let RiiklikOppekava = _prefix "RiiklikOppekava"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Sihtgrupp"></see>
    /// </summary>
    let Sihtgrupp = _prefix "Sihtgrupp"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Tasemetoo"></see>
    /// </summary>
    let Tasemetoo = _prefix "Tasemetoo"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Teadmine"></see>
    /// </summary>
    let Teadmine = _prefix "Teadmine"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Teema"></see>
    /// </summary>
    let Teema = _prefix "Teema"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Tunnikontroll"></see>
    /// </summary>
    let Tunnikontroll = _prefix "Tunnikontroll"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Ulesanne"></see>
    /// </summary>
    let Ulesanne = _prefix "Ulesanne"
    /// <summary>
    ///   <see href="https://schema.edu.ee/Vastus"></see>
    /// </summary>
    let Vastus = _prefix "Vastus"
    /// <summary>
    ///   <see href="https://schema.edu.ee/ainevaldkondKoosneb"></see>
    /// </summary>
    let ainevaldkondKoosneb = _prefix "ainevaldkondKoosneb"
    /// <summary>
    ///   <see href="https://schema.edu.ee/alateema"></see>
    /// </summary>
    let alateema = _prefix "alateema"
    /// <summary>
    ///   <see href="https://schema.edu.ee/eeldab"></see>
    /// </summary>
    let eeldab = _prefix "eeldab"
    /// <summary>
    ///   <see href="https://schema.edu.ee/hindabOpitulemust"></see>
    /// </summary>
    let hindabOpitulemust = _prefix "hindabOpitulemust"
    /// <summary>
    ///   <see href="https://schema.edu.ee/kooliaste"></see>
    /// </summary>
    let kooliaste = _prefix "kooliaste"
    /// <summary>
    ///   <see href="https://schema.edu.ee/onEelduseks"></see>
    /// </summary>
    let onEelduseks = _prefix "onEelduseks"
    /// <summary>
    ///   <see href="https://schema.edu.ee/opivaljundEeldab"></see>
    /// </summary>
    let opivaljundEeldab = _prefix "opivaljundEeldab"
    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudAinevaldkond"></see>
    /// </summary>
    let seotudAinevaldkond = _prefix "seotudAinevaldkond"
    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudHaridusaste"></see>
    /// </summary>
    let seotudHaridusaste = _prefix "seotudHaridusaste"
    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudOpivaljund"></see>
    /// </summary>
    let seotudOpivaljund = _prefix "seotudOpivaljund"
    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudOppeaine"></see>
    /// </summary>
    let seotudOppeaine = _prefix "seotudOppeaine"
    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudTeema"></see>
    /// </summary>
    let seotudTeema = _prefix "seotudTeema"
    /// <summary>
    ///   <see href="https://schema.edu.ee/testKoosneb"></see>
    /// </summary>
    let testKoosneb = _prefix "testKoosneb"
    /// <summary>
    ///   <see href="https://schema.edu.ee/ulesanneKoosneb"></see>
    /// </summary>
    let ulesanneKoosneb = _prefix "ulesanneKoosneb"
    /// <summary>
    ///   <see href="https://schema.edu.ee/vanuseaste"></see>
    /// </summary>
    let vanuseaste = _prefix "vanuseaste"

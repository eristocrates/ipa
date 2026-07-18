namespace https.schema.edu.ee.slash

open DoxAletheia.Rdf_Vocabulary

module edu =
    let _namespace_name = "https://schema.edu.ee/"

    /// <summary>
    ///   <see href="https://schema.edu.ee/#Opivaljund"></see>
    /// </summary>
    let ``_#Opivaljund`` =
        Namespaced_IRI.parse _namespace_name "#Opivaljund" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/#Oppematerjal"></see>
    /// </summary>
    let ``_#Oppematerjal`` =
        Namespaced_IRI.parse _namespace_name "#Oppematerjal" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1"></see>
    /// </summary>
    let ``_0.1`` = Namespaced_IRI.parse _namespace_name "0.1" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1/html"></see>
    /// </summary>
    let ``_0.1/html`` =
        Namespaced_IRI.parse _namespace_name "0.1/html" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/0.1/"></see>
    /// </summary>
    let ``_0.1/`` = Namespaced_IRI.parse _namespace_name "0.1/" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Ainekava"></see>
    /// </summary>
    let Ainekava = Namespaced_IRI.parse _namespace_name "Ainekava" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppekava"></see>
    /// </summary>
    let Oppekava = Namespaced_IRI.parse _namespace_name "Oppekava" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Ainevaldkond"></see>
    /// </summary>
    let Ainevaldkond =
        Namespaced_IRI.parse _namespace_name "Ainevaldkond" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/AinevaldkonnaPadevus"></see>
    /// </summary>
    let AinevaldkonnaPadevus =
        Namespaced_IRI.parse _namespace_name "AinevaldkonnaPadevus" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Padevus"></see>
    /// </summary>
    let Padevus = Namespaced_IRI.parse _namespace_name "Padevus" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Haridusaste"></see>
    /// </summary>
    let Haridusaste =
        Namespaced_IRI.parse _namespace_name "Haridusaste" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Hoiak"></see>
    /// </summary>
    let Hoiak = Namespaced_IRI.parse _namespace_name "Hoiak" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Opivaljund"></see>
    /// </summary>
    let Opivaljund = Namespaced_IRI.parse _namespace_name "Opivaljund" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/IndividuaalneOppekava"></see>
    /// </summary>
    let IndividuaalneOppekava =
        Namespaced_IRI.parse _namespace_name "IndividuaalneOppekava" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Kontrolltoo"></see>
    /// </summary>
    let Kontrolltoo =
        Namespaced_IRI.parse _namespace_name "Kontrolltoo" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Test"></see>
    /// </summary>
    let Test = Namespaced_IRI.parse _namespace_name "Test" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Koolitus"></see>
    /// </summary>
    let Koolitus = Namespaced_IRI.parse _namespace_name "Koolitus" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Kusimus"></see>
    /// </summary>
    let Kusimus = Namespaced_IRI.parse _namespace_name "Kusimus" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/OpetajaTookava"></see>
    /// </summary>
    let OpetajaTookava =
        Namespaced_IRI.parse _namespace_name "OpetajaTookava" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Opirada"></see>
    /// </summary>
    let Opirada = Namespaced_IRI.parse _namespace_name "Opirada" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Opitulemus"></see>
    /// </summary>
    let Opitulemus = Namespaced_IRI.parse _namespace_name "Opitulemus" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppeaine"></see>
    /// </summary>
    let Oppeaine = Namespaced_IRI.parse _namespace_name "Oppeaine" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/OppeasutuseOppekava"></see>
    /// </summary>
    let OppeasutuseOppekava =
        Namespaced_IRI.parse _namespace_name "OppeasutuseOppekava" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Oppematerjal"></see>
    /// </summary>
    let Oppematerjal =
        Namespaced_IRI.parse _namespace_name "Oppematerjal" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Oskus"></see>
    /// </summary>
    let Oskus = Namespaced_IRI.parse _namespace_name "Oskus" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/RiiklikOppekava"></see>
    /// </summary>
    let RiiklikOppekava =
        Namespaced_IRI.parse _namespace_name "RiiklikOppekava" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Sihtgrupp"></see>
    /// </summary>
    let Sihtgrupp = Namespaced_IRI.parse _namespace_name "Sihtgrupp" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Tasemetoo"></see>
    /// </summary>
    let Tasemetoo = Namespaced_IRI.parse _namespace_name "Tasemetoo" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Teadmine"></see>
    /// </summary>
    let Teadmine = Namespaced_IRI.parse _namespace_name "Teadmine" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Teema"></see>
    /// </summary>
    let Teema = Namespaced_IRI.parse _namespace_name "Teema" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Tunnikontroll"></see>
    /// </summary>
    let Tunnikontroll =
        Namespaced_IRI.parse _namespace_name "Tunnikontroll" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/Ulesanne"></see>
    /// </summary>
    let Ulesanne = Namespaced_IRI.parse _namespace_name "Ulesanne" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/Vastus"></see>
    /// </summary>
    let Vastus = Namespaced_IRI.parse _namespace_name "Vastus" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/ainevaldkondKoosneb"></see>
    /// </summary>
    let ainevaldkondKoosneb =
        Namespaced_IRI.parse _namespace_name "ainevaldkondKoosneb" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/alateema"></see>
    /// </summary>
    let alateema = Namespaced_IRI.parse _namespace_name "alateema" |> NamespacedName
    /// <summary>
    ///   <see href="https://schema.edu.ee/eeldab"></see>
    /// </summary>
    let eeldab = Namespaced_IRI.parse _namespace_name "eeldab" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/hindabOpitulemust"></see>
    /// </summary>
    let hindabOpitulemust =
        Namespaced_IRI.parse _namespace_name "hindabOpitulemust" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/kooliaste"></see>
    /// </summary>
    let kooliaste = Namespaced_IRI.parse _namespace_name "kooliaste" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/onEelduseks"></see>
    /// </summary>
    let onEelduseks =
        Namespaced_IRI.parse _namespace_name "onEelduseks" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/opivaljundEeldab"></see>
    /// </summary>
    let opivaljundEeldab =
        Namespaced_IRI.parse _namespace_name "opivaljundEeldab" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudAinevaldkond"></see>
    /// </summary>
    let seotudAinevaldkond =
        Namespaced_IRI.parse _namespace_name "seotudAinevaldkond" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudHaridusaste"></see>
    /// </summary>
    let seotudHaridusaste =
        Namespaced_IRI.parse _namespace_name "seotudHaridusaste" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudOpivaljund"></see>
    /// </summary>
    let seotudOpivaljund =
        Namespaced_IRI.parse _namespace_name "seotudOpivaljund" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudOppeaine"></see>
    /// </summary>
    let seotudOppeaine =
        Namespaced_IRI.parse _namespace_name "seotudOppeaine" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/seotudTeema"></see>
    /// </summary>
    let seotudTeema =
        Namespaced_IRI.parse _namespace_name "seotudTeema" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/testKoosneb"></see>
    /// </summary>
    let testKoosneb =
        Namespaced_IRI.parse _namespace_name "testKoosneb" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/ulesanneKoosneb"></see>
    /// </summary>
    let ulesanneKoosneb =
        Namespaced_IRI.parse _namespace_name "ulesanneKoosneb" |> NamespacedName

    /// <summary>
    ///   <see href="https://schema.edu.ee/vanuseaste"></see>
    /// </summary>
    let vanuseaste = Namespaced_IRI.parse _namespace_name "vanuseaste" |> NamespacedName

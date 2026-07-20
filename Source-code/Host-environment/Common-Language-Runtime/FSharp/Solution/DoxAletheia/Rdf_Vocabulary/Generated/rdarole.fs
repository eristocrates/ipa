namespace http.rdvocab.info.roles.slash

open DoxAletheia

module rdarole =
    let _namespace_name = "http://rdvocab.info/roles/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/Filmmaker"></see>
    /// </summary>
    let Filmmaker = _prefix "Filmmaker"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/abridger"></see>
    /// </summary>
    let abridger = _prefix "abridger"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/abridgerExpression"></see>
    /// </summary>
    let abridgerExpression = _prefix "abridgerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/contributor"></see>
    /// </summary>
    let contributor = _prefix "contributor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/actor"></see>
    /// </summary>
    let actor = _prefix "actor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/performer"></see>
    /// </summary>
    let performer = _prefix "performer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/actorExpression"></see>
    /// </summary>
    let actorExpression = _prefix "actorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/performerExpression"></see>
    /// </summary>
    let performerExpression = _prefix "performerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/addressee"></see>
    /// </summary>
    let addressee = _prefix "addressee"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/addresseeWork"></see>
    /// </summary>
    let addresseeWork = _prefix "addresseeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/animator"></see>
    /// </summary>
    let animator = _prefix "animator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/animatorExpression"></see>
    /// </summary>
    let animatorExpression = _prefix "animatorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/annotator"></see>
    /// </summary>
    let annotator = _prefix "annotator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/annotatorItem"></see>
    /// </summary>
    let annotatorItem = _prefix "annotatorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellant"></see>
    /// </summary>
    let appellant = _prefix "appellant"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellantWork"></see>
    /// </summary>
    let appellantWork = _prefix "appellantWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellee"></see>
    /// </summary>
    let appellee = _prefix "appellee"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appelleeWork"></see>
    /// </summary>
    let appelleeWork = _prefix "appelleeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/architect"></see>
    /// </summary>
    let architect = _prefix "architect"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/landscapeArchitect"></see>
    /// </summary>
    let landscapeArchitect = _prefix "landscapeArchitect"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/architectWork"></see>
    /// </summary>
    let architectWork = _prefix "architectWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/creator"></see>
    /// </summary>
    let creator = _prefix "creator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/arrangerOfMusic"></see>
    /// </summary>
    let arrangerOfMusic = _prefix "arrangerOfMusic"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/arrangerOfMusicExpression"></see>
    /// </summary>
    let arrangerOfMusicExpression = _prefix "arrangerOfMusicExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artDirector"></see>
    /// </summary>
    let artDirector = _prefix "artDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artDirectorExpression"></see>
    /// </summary>
    let artDirectorExpression = _prefix "artDirectorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artist"></see>
    /// </summary>
    let artist = _prefix "artist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sculptor"></see>
    /// </summary>
    let sculptor = _prefix "sculptor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artistWork"></see>
    /// </summary>
    let artistWork = _prefix "artistWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/author"></see>
    /// </summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/screenwriter"></see>
    /// </summary>
    let screenwriter = _prefix "screenwriter"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lyricist"></see>
    /// </summary>
    let lyricist = _prefix "lyricist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/librettist"></see>
    /// </summary>
    let librettist = _prefix "librettist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/authorWork"></see>
    /// </summary>
    let authorWork = _prefix "authorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/librettistWork"></see>
    /// </summary>
    let librettistWork = _prefix "librettistWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/screenwriterWork"></see>
    /// </summary>
    let screenwriterWork = _prefix "screenwriterWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lyricistWork"></see>
    /// </summary>
    let lyricistWork = _prefix "lyricistWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/autographer"></see>
    /// </summary>
    let autographer = _prefix "autographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/autographerItem"></see>
    /// </summary>
    let autographerItem = _prefix "autographerItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/binder"></see>
    /// </summary>
    let binder = _prefix "binder"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/binderItem"></see>
    /// </summary>
    let binderItem = _prefix "binderItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/bookDesigner"></see>
    /// </summary>
    let bookDesigner = _prefix "bookDesigner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/manufacturer"></see>
    /// </summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/bookDesignerManifestation"></see>
    /// </summary>
    let bookDesignerManifestation = _prefix "bookDesignerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/manufacturerManifestation"></see>
    /// </summary>
    let manufacturerManifestation = _prefix "manufacturerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/brailleEmbosser"></see>
    /// </summary>
    let brailleEmbosser = _prefix "brailleEmbosser"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/brailleEmbosserManifestation"></see>
    /// </summary>
    let brailleEmbosserManifestation = _prefix "brailleEmbosserManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/broadcaster"></see>
    /// </summary>
    let broadcaster = _prefix "broadcaster"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/publisher"></see>
    /// </summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/broadcasterManifestation"></see>
    /// </summary>
    let broadcasterManifestation = _prefix "broadcasterManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/publisherManifestation"></see>
    /// </summary>
    let publisherManifestation = _prefix "publisherManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cartographer"></see>
    /// </summary>
    let cartographer = _prefix "cartographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cartographerWork"></see>
    /// </summary>
    let cartographerWork = _prefix "cartographerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/caster"></see>
    /// </summary>
    let caster = _prefix "caster"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/casterManifestation"></see>
    /// </summary>
    let casterManifestation = _prefix "casterManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographer"></see>
    /// </summary>
    let choreographer = _prefix "choreographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographerExpression"></see>
    /// </summary>
    let choreographerExpression = _prefix "choreographerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographerWork"></see>
    /// </summary>
    let choreographerWork = _prefix "choreographerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cinematographer"></see>
    /// </summary>
    let cinematographer = _prefix "cinematographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectionRegistrar"></see>
    /// </summary>
    let collectionRegistrar = _prefix "collectionRegistrar"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/curator"></see>
    /// </summary>
    let curator = _prefix "curator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectionRegistrarItem"></see>
    /// </summary>
    let collectionRegistrarItem = _prefix "collectionRegistrarItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collector"></see>
    /// </summary>
    let collector = _prefix "collector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectorItem"></see>
    /// </summary>
    let collectorItem = _prefix "collectorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collotyper"></see>
    /// </summary>
    let collotyper = _prefix "collotyper"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collotyperManifestation"></see>
    /// </summary>
    let collotyperManifestation = _prefix "collotyperManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/commentator"></see>
    /// </summary>
    let commentator = _prefix "commentator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/commentatorExpression"></see>
    /// </summary>
    let commentatorExpression = _prefix "commentatorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/compiler"></see>
    /// </summary>
    let compiler = _prefix "compiler"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/compilerWork"></see>
    /// </summary>
    let compilerWork = _prefix "compilerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composer"></see>
    /// </summary>
    let composer = _prefix "composer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerExpression"></see>
    /// </summary>
    let composerExpression = _prefix "composerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfAdditionalMusic"></see>
    /// </summary>
    let composerOfAdditionalMusic = _prefix "composerOfAdditionalMusic"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfAdditionalMusicExpression"></see>
    /// </summary>
    let composerOfAdditionalMusicExpression =
        _prefix "composerOfAdditionalMusicExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfIncidentalMusic"></see>
    /// </summary>
    let composerOfIncidentalMusic = _prefix "composerOfIncidentalMusic"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfIncidentalMusicExpression"></see>
    /// </summary>
    let composerOfIncidentalMusicExpression =
        _prefix "composerOfIncidentalMusicExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSilentFilm"></see>
    /// </summary>
    let composerOfMusicForSilentFilm = _prefix "composerOfMusicForSilentFilm"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSilentFilmExpression"></see>
    /// </summary>
    let composerOfMusicForSilentFilmExpression =
        _prefix "composerOfMusicForSilentFilmExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSoundFilm"></see>
    /// </summary>
    let composerOfMusicForSoundFilm = _prefix "composerOfMusicForSoundFilm"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSoundFilmExpression"></see>
    /// </summary>
    let composerOfMusicForSoundFilmExpression =
        _prefix "composerOfMusicForSoundFilmExpression"

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerWork"></see>
    /// </summary>
    let composerWork = _prefix "composerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/conductor"></see>
    /// </summary>
    let conductor = _prefix "conductor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/conductorExpression"></see>
    /// </summary>
    let conductorExpression = _prefix "conductorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfMovingImageWorkExpression"></see>
    /// </summary>
    let editorOfMovingImageWorkExpression = _prefix "editorOfMovingImageWorkExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtReporterExpression"></see>
    /// </summary>
    let courtReporterExpression = _prefix "courtReporterExpression"
    /// <summary>
    /// If the work is primarily the artistic content created by this entity, see artist and photographer.
    /// <see href="http://rdvocab.info/roles/illustratorExpression"></see></summary>
    let illustratorExpression = _prefix "illustratorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordingEngineerExpression"></see>
    /// </summary>
    let recordingEngineerExpression = _prefix "recordingEngineerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/stageDirectorExpression"></see>
    /// </summary>
    let stageDirectorExpression = _prefix "stageDirectorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordistExpression"></see>
    /// </summary>
    let recordistExpression = _prefix "recordistExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/transcriberExpression"></see>
    /// </summary>
    let transcriberExpression = _prefix "transcriberExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/intervieweeExpression"></see>
    /// </summary>
    let intervieweeExpression = _prefix "intervieweeExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/presenterExpression"></see>
    /// </summary>
    let presenterExpression = _prefix "presenterExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedTextExpression"></see>
    /// </summary>
    let writerOfAddedTextExpression = _prefix "writerOfAddedTextExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfCompilationExpression"></see>
    /// </summary>
    let editorOfCompilationExpression = _prefix "editorOfCompilationExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionDesignerExpression"></see>
    /// </summary>
    let productionDesignerExpression = _prefix "productionDesignerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/translatorExpression"></see>
    /// </summary>
    let translatorExpression = _prefix "translatorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewerExpression"></see>
    /// </summary>
    let interviewerExpression = _prefix "interviewerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/surveyorExpression"></see>
    /// </summary>
    let surveyorExpression = _prefix "surveyorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorExpression"></see>
    /// </summary>
    let editorExpression = _prefix "editorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/draftsmanExpression"></see>
    /// </summary>
    let draftsmanExpression = _prefix "draftsmanExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/musicalDirectorExpression"></see>
    /// </summary>
    let musicalDirectorExpression = _prefix "musicalDirectorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedCommentaryExpression"></see>
    /// </summary>
    let writerOfAddedCommentaryExpression = _prefix "writerOfAddedCommentaryExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/costumeDesignerExpression"></see>
    /// </summary>
    let costumeDesignerExpression = _prefix "costumeDesignerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/costumeDesigner"></see>
    /// </summary>
    let costumeDesigner = _prefix "costumeDesigner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtGoverned"></see>
    /// </summary>
    let courtGoverned = _prefix "courtGoverned"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtGovernedWork"></see>
    /// </summary>
    let courtGovernedWork = _prefix "courtGovernedWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtReporter"></see>
    /// </summary>
    let courtReporter = _prefix "courtReporter"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewerWork"></see>
    /// </summary>
    let interviewerWork = _prefix "interviewerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/designerWork"></see>
    /// </summary>
    let designerWork = _prefix "designerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmmakerWork"></see>
    /// </summary>
    let filmmakerWork = _prefix "filmmakerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inventorWork"></see>
    /// </summary>
    let inventorWork = _prefix "inventorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/intervieweeWork"></see>
    /// </summary>
    let intervieweeWork = _prefix "intervieweeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/photographerWork"></see>
    /// </summary>
    let photographerWork = _prefix "photographerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/programmerWork"></see>
    /// </summary>
    let programmerWork = _prefix "programmerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/enactingJurisdictionWork"></see>
    /// </summary>
    let enactingJurisdictionWork = _prefix "enactingJurisdictionWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/praesesWork"></see>
    /// </summary>
    let praesesWork = _prefix "praesesWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/respondentWork"></see>
    /// </summary>
    let respondentWork = _prefix "respondentWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/curatorItem"></see>
    /// </summary>
    let curatorItem = _prefix "curatorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/currentOwner"></see>
    /// </summary>
    let currentOwner = _prefix "currentOwner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/depositor"></see>
    /// </summary>
    let depositor = _prefix "depositor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/owner"></see>
    /// </summary>
    let owner = _prefix "owner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/currentOwnerItem"></see>
    /// </summary>
    let currentOwnerItem = _prefix "currentOwnerItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/ownerItem"></see>
    /// </summary>
    let ownerItem = _prefix "ownerItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/custodian"></see>
    /// </summary>
    let custodian = _prefix "custodian"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/custodianItem"></see>
    /// </summary>
    let custodianItem = _prefix "custodianItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dancer"></see>
    /// </summary>
    let dancer = _prefix "dancer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dancerExpression"></see>
    /// </summary>
    let dancerExpression = _prefix "dancerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicatee"></see>
    /// </summary>
    let dedicatee = _prefix "dedicatee"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicateeWork"></see>
    /// </summary>
    let dedicateeWork = _prefix "dedicateeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicateeOfItem"></see>
    /// </summary>
    let dedicateeOfItem = _prefix "dedicateeOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/defendant"></see>
    /// </summary>
    let defendant = _prefix "defendant"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/defendantWork"></see>
    /// </summary>
    let defendantWork = _prefix "defendantWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/degreeGrantingInstitution"></see>
    /// </summary>
    let degreeGrantingInstitution = _prefix "degreeGrantingInstitution"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/degreeGrantingInstitutionWork"></see>
    /// </summary>
    let degreeGrantingInstitutionWork = _prefix "degreeGrantingInstitutionWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/depositorItem"></see>
    /// </summary>
    let depositorItem = _prefix "depositorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/designer"></see>
    /// </summary>
    let designer = _prefix "designer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/director"></see>
    /// </summary>
    let director = _prefix "director"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioDirector"></see>
    /// </summary>
    let radioDirector = _prefix "radioDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDirector"></see>
    /// </summary>
    let filmDirector = _prefix "filmDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionDirector"></see>
    /// </summary>
    let televisionDirector = _prefix "televisionDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/directorWork"></see>
    /// </summary>
    let directorWork = _prefix "directorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/directorOfPhotography"></see>
    /// </summary>
    let directorOfPhotography = _prefix "directorOfPhotography"
    /// <summary>
    /// Use this designation also for videographers.
    /// <see href="http://rdvocab.info/roles/directorOfPhotographyWork"></see></summary>
    let directorOfPhotographyWork = _prefix "directorOfPhotographyWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionDirectorWork"></see>
    /// </summary>
    let televisionDirectorWork = _prefix "televisionDirectorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioDirectorWork"></see>
    /// </summary>
    let radioDirectorWork = _prefix "radioDirectorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDirectorWork"></see>
    /// </summary>
    let filmDirectorWork = _prefix "filmDirectorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/distributor"></see>
    /// </summary>
    let distributor = _prefix "distributor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/distributorManifestation"></see>
    /// </summary>
    let distributorManifestation = _prefix "distributorManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDistributor"></see>
    /// </summary>
    let filmDistributor = _prefix "filmDistributor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDistributorManifestation"></see>
    /// </summary>
    let filmDistributorManifestation = _prefix "filmDistributorManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/donor"></see>
    /// </summary>
    let donor = _prefix "donor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/formerOwner"></see>
    /// </summary>
    let formerOwner = _prefix "formerOwner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/donorItem"></see>
    /// </summary>
    let donorItem = _prefix "donorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/formerOwnerItem"></see>
    /// </summary>
    let formerOwnerItem = _prefix "formerOwnerItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/draftsman"></see>
    /// </summary>
    let draftsman = _prefix "draftsman"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfCompilation"></see>
    /// </summary>
    let editorOfCompilation = _prefix "editorOfCompilation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfMovingImageWork"></see>
    /// </summary>
    let editorOfMovingImageWork = _prefix "editorOfMovingImageWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/enactingJurisdiction"></see>
    /// </summary>
    let enactingJurisdiction = _prefix "enactingJurisdiction"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/engraver"></see>
    /// </summary>
    let engraver = _prefix "engraver"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/engraverManifestation"></see>
    /// </summary>
    let engraverManifestation = _prefix "engraverManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/etcher"></see>
    /// </summary>
    let etcher = _prefix "etcher"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/etcherManifestation"></see>
    /// </summary>
    let etcherManifestation = _prefix "etcherManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmProducer"></see>
    /// </summary>
    let filmProducer = _prefix "filmProducer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/producer"></see>
    /// </summary>
    let producer = _prefix "producer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmProducerWork"></see>
    /// </summary>
    let filmProducerWork = _prefix "filmProducerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/producerWork"></see>
    /// </summary>
    let producerWork = _prefix "producerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/seller"></see>
    /// </summary>
    let seller = _prefix "seller"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sellerItem"></see>
    /// </summary>
    let sellerItem = _prefix "sellerItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honouree"></see>
    /// </summary>
    let honouree = _prefix "honouree"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honoureeWork"></see>
    /// </summary>
    let honoureeWork = _prefix "honoureeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honoureeOfItem"></see>
    /// </summary>
    let honoureeOfItem = _prefix "honoureeOfItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/host"></see>
    /// </summary>
    let host = _prefix "host"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostExpression"></see>
    /// </summary>
    let hostExpression = _prefix "hostExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostInstitution"></see>
    /// </summary>
    let hostInstitution = _prefix "hostInstitution"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostInstitutionWork"></see>
    /// </summary>
    let hostInstitutionWork = _prefix "hostInstitutionWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illuminator"></see>
    /// </summary>
    let illuminator = _prefix "illuminator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illuminatorItem"></see>
    /// </summary>
    let illuminatorItem = _prefix "illuminatorItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illustrator"></see>
    /// </summary>
    let illustrator = _prefix "illustrator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inscriber"></see>
    /// </summary>
    let inscriber = _prefix "inscriber"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inscriberItem"></see>
    /// </summary>
    let inscriberItem = _prefix "inscriberItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/instrumentalist"></see>
    /// </summary>
    let instrumentalist = _prefix "instrumentalist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/instrumentalistExpression"></see>
    /// </summary>
    let instrumentalistExpression = _prefix "instrumentalistExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewee"></see>
    /// </summary>
    let interviewee = _prefix "interviewee"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewer"></see>
    /// </summary>
    let interviewer = _prefix "interviewer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inventor"></see>
    /// </summary>
    let inventor = _prefix "inventor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/issuingBody"></see>
    /// </summary>
    let issuingBody = _prefix "issuingBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/issuingBodyWork"></see>
    /// </summary>
    let issuingBodyWork = _prefix "issuingBodyWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/judge"></see>
    /// </summary>
    let judge = _prefix "judge"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/judgeWork"></see>
    /// </summary>
    let judgeWork = _prefix "judgeWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/jurisdictionGoverned"></see>
    /// </summary>
    let jurisdictionGoverned = _prefix "jurisdictionGoverned"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/jurisdictionGovernedWork"></see>
    /// </summary>
    let jurisdictionGovernedWork = _prefix "jurisdictionGovernedWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/landscapeArchitectWork"></see>
    /// </summary>
    let landscapeArchitectWork = _prefix "landscapeArchitectWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lithographer"></see>
    /// </summary>
    let lithographer = _prefix "lithographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lithographerManifestation"></see>
    /// </summary>
    let lithographerManifestation = _prefix "lithographerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printer"></see>
    /// </summary>
    let printer = _prefix "printer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printmaker"></see>
    /// </summary>
    let printmaker = _prefix "printmaker"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/platemaker"></see>
    /// </summary>
    let platemaker = _prefix "platemaker"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/platemakerManifestation"></see>
    /// </summary>
    let platemakerManifestation = _prefix "platemakerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printerManifestation"></see>
    /// </summary>
    let printerManifestation = _prefix "printerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printmakerManifestation"></see>
    /// </summary>
    let printmakerManifestation = _prefix "printmakerManifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/moderator"></see>
    /// </summary>
    let moderator = _prefix "moderator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/moderatorExpression"></see>
    /// </summary>
    let moderatorExpression = _prefix "moderatorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/musicalDirector"></see>
    /// </summary>
    let musicalDirector = _prefix "musicalDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/narrator"></see>
    /// </summary>
    let narrator = _prefix "narrator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/narratorExpression"></see>
    /// </summary>
    let narratorExpression = _prefix "narratorExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/onScreenPresenter"></see>
    /// </summary>
    let onScreenPresenter = _prefix "onScreenPresenter"
    /// <summary>
    /// Use when a more specific term (e.g., Narrator or Host) is either not applicable or not desired.
    /// <see href="http://rdvocab.info/roles/onScreenPresenterExpression"></see></summary>
    let onScreenPresenterExpression = _prefix "onScreenPresenterExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/panelist"></see>
    /// </summary>
    let panelist = _prefix "panelist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/panelistExpression"></see>
    /// </summary>
    let panelistExpression = _prefix "panelistExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/storyteller"></see>
    /// </summary>
    let storyteller = _prefix "storyteller"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/singer"></see>
    /// </summary>
    let singer = _prefix "singer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/teacher"></see>
    /// </summary>
    let teacher = _prefix "teacher"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/puppeteer"></see>
    /// </summary>
    let puppeteer = _prefix "puppeteer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/speaker"></see>
    /// </summary>
    let speaker = _prefix "speaker"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/singerExpression"></see>
    /// </summary>
    let singerExpression = _prefix "singerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/speakerExpression"></see>
    /// </summary>
    let speakerExpression = _prefix "speakerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/storytellerExpression"></see>
    /// </summary>
    let storytellerExpression = _prefix "storytellerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/photographer"></see>
    /// </summary>
    let photographer = _prefix "photographer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/plaintiff"></see>
    /// </summary>
    let plaintiff = _prefix "plaintiff"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/plaintiffWork"></see>
    /// </summary>
    let plaintiffWork = _prefix "plaintiffWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/praeses"></see>
    /// </summary>
    let praeses = _prefix "praeses"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/presenter"></see>
    /// </summary>
    let presenter = _prefix "presenter"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionProducer"></see>
    /// </summary>
    let televisionProducer = _prefix "televisionProducer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioProducer"></see>
    /// </summary>
    let radioProducer = _prefix "radioProducer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioProducerWork"></see>
    /// </summary>
    let radioProducerWork = _prefix "radioProducerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionProducerWork"></see>
    /// </summary>
    let televisionProducerWork = _prefix "televisionProducerWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionCompany"></see>
    /// </summary>
    let productionCompany = _prefix "productionCompany"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionCompanyWork"></see>
    /// </summary>
    let productionCompanyWork = _prefix "productionCompanyWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionDesigner"></see>
    /// </summary>
    let productionDesigner = _prefix "productionDesigner"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/programmer"></see>
    /// </summary>
    let programmer = _prefix "programmer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/puppeteerExpression"></see>
    /// </summary>
    let puppeteerExpression = _prefix "puppeteerExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordingEngineer"></see>
    /// </summary>
    let recordingEngineer = _prefix "recordingEngineer"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordist"></see>
    /// </summary>
    let recordist = _prefix "recordist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/respondent"></see>
    /// </summary>
    let respondent = _prefix "respondent"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/restorationist"></see>
    /// </summary>
    let restorationist = _prefix "restorationist"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/restorationistItem"></see>
    /// </summary>
    let restorationistItem = _prefix "restorationistItem"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sculptorWork"></see>
    /// </summary>
    let sculptorWork = _prefix "sculptorWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sponsoringBody"></see>
    /// </summary>
    let sponsoringBody = _prefix "sponsoringBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sponsoringBodyWork"></see>
    /// </summary>
    let sponsoringBodyWork = _prefix "sponsoringBodyWork"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/stageDirector"></see>
    /// </summary>
    let stageDirector = _prefix "stageDirector"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/surveyor"></see>
    /// </summary>
    let surveyor = _prefix "surveyor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/teacherExpression"></see>
    /// </summary>
    let teacherExpression = _prefix "teacherExpression"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/thesisAdvisor"></see>
    /// </summary>
    let thesisAdvisor = _prefix "thesisAdvisor"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/transcriber"></see>
    /// </summary>
    let transcriber = _prefix "transcriber"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/translator"></see>
    /// </summary>
    let translator = _prefix "translator"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedCommentary"></see>
    /// </summary>
    let writerOfAddedCommentary = _prefix "writerOfAddedCommentary"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedLyrics"></see>
    /// </summary>
    let writerOfAddedLyrics = _prefix "writerOfAddedLyrics"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedText"></see>
    /// </summary>
    let writerOfAddedText = _prefix "writerOfAddedText"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedLyricsExpression"></see>
    /// </summary>
    let writerOfAddedLyricsExpression = _prefix "writerOfAddedLyricsExpression"

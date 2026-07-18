namespace http.rdvocab.info.roles.slash

open DoxAletheia.Rdf_Vocabulary

module rdarole =
    let _namespace_name = "http://rdvocab.info/roles/"
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/Filmmaker"></see>
    /// </summary>
    let Filmmaker = Namespaced_IRI.parse _namespace_name "Filmmaker" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/abridger"></see>
    /// </summary>
    let abridger = Namespaced_IRI.parse _namespace_name "abridger" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/abridgerExpression"></see>
    /// </summary>
    let abridgerExpression =
        Namespaced_IRI.parse _namespace_name "abridgerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/contributor"></see>
    /// </summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/actor"></see>
    /// </summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/performer"></see>
    /// </summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/actorExpression"></see>
    /// </summary>
    let actorExpression =
        Namespaced_IRI.parse _namespace_name "actorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/performerExpression"></see>
    /// </summary>
    let performerExpression =
        Namespaced_IRI.parse _namespace_name "performerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/addressee"></see>
    /// </summary>
    let addressee = Namespaced_IRI.parse _namespace_name "addressee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/addresseeWork"></see>
    /// </summary>
    let addresseeWork =
        Namespaced_IRI.parse _namespace_name "addresseeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/animator"></see>
    /// </summary>
    let animator = Namespaced_IRI.parse _namespace_name "animator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/animatorExpression"></see>
    /// </summary>
    let animatorExpression =
        Namespaced_IRI.parse _namespace_name "animatorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/annotator"></see>
    /// </summary>
    let annotator = Namespaced_IRI.parse _namespace_name "annotator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/annotatorItem"></see>
    /// </summary>
    let annotatorItem =
        Namespaced_IRI.parse _namespace_name "annotatorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellant"></see>
    /// </summary>
    let appellant = Namespaced_IRI.parse _namespace_name "appellant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellantWork"></see>
    /// </summary>
    let appellantWork =
        Namespaced_IRI.parse _namespace_name "appellantWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appellee"></see>
    /// </summary>
    let appellee = Namespaced_IRI.parse _namespace_name "appellee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/appelleeWork"></see>
    /// </summary>
    let appelleeWork =
        Namespaced_IRI.parse _namespace_name "appelleeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/architect"></see>
    /// </summary>
    let architect = Namespaced_IRI.parse _namespace_name "architect" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/landscapeArchitect"></see>
    /// </summary>
    let landscapeArchitect =
        Namespaced_IRI.parse _namespace_name "landscapeArchitect" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/architectWork"></see>
    /// </summary>
    let architectWork =
        Namespaced_IRI.parse _namespace_name "architectWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/creator"></see>
    /// </summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/arrangerOfMusic"></see>
    /// </summary>
    let arrangerOfMusic =
        Namespaced_IRI.parse _namespace_name "arrangerOfMusic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/arrangerOfMusicExpression"></see>
    /// </summary>
    let arrangerOfMusicExpression =
        Namespaced_IRI.parse _namespace_name "arrangerOfMusicExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artDirector"></see>
    /// </summary>
    let artDirector =
        Namespaced_IRI.parse _namespace_name "artDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artDirectorExpression"></see>
    /// </summary>
    let artDirectorExpression =
        Namespaced_IRI.parse _namespace_name "artDirectorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artist"></see>
    /// </summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sculptor"></see>
    /// </summary>
    let sculptor = Namespaced_IRI.parse _namespace_name "sculptor" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/artistWork"></see>
    /// </summary>
    let artistWork = Namespaced_IRI.parse _namespace_name "artistWork" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/author"></see>
    /// </summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/screenwriter"></see>
    /// </summary>
    let screenwriter =
        Namespaced_IRI.parse _namespace_name "screenwriter" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lyricist"></see>
    /// </summary>
    let lyricist = Namespaced_IRI.parse _namespace_name "lyricist" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/librettist"></see>
    /// </summary>
    let librettist = Namespaced_IRI.parse _namespace_name "librettist" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/authorWork"></see>
    /// </summary>
    let authorWork = Namespaced_IRI.parse _namespace_name "authorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/librettistWork"></see>
    /// </summary>
    let librettistWork =
        Namespaced_IRI.parse _namespace_name "librettistWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/screenwriterWork"></see>
    /// </summary>
    let screenwriterWork =
        Namespaced_IRI.parse _namespace_name "screenwriterWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lyricistWork"></see>
    /// </summary>
    let lyricistWork =
        Namespaced_IRI.parse _namespace_name "lyricistWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/autographer"></see>
    /// </summary>
    let autographer =
        Namespaced_IRI.parse _namespace_name "autographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/autographerItem"></see>
    /// </summary>
    let autographerItem =
        Namespaced_IRI.parse _namespace_name "autographerItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/binder"></see>
    /// </summary>
    let binder = Namespaced_IRI.parse _namespace_name "binder" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/binderItem"></see>
    /// </summary>
    let binderItem = Namespaced_IRI.parse _namespace_name "binderItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/bookDesigner"></see>
    /// </summary>
    let bookDesigner =
        Namespaced_IRI.parse _namespace_name "bookDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/bookDesignerManifestation"></see>
    /// </summary>
    let bookDesignerManifestation =
        Namespaced_IRI.parse _namespace_name "bookDesignerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/manufacturerManifestation"></see>
    /// </summary>
    let manufacturerManifestation =
        Namespaced_IRI.parse _namespace_name "manufacturerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/brailleEmbosser"></see>
    /// </summary>
    let brailleEmbosser =
        Namespaced_IRI.parse _namespace_name "brailleEmbosser" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/brailleEmbosserManifestation"></see>
    /// </summary>
    let brailleEmbosserManifestation =
        Namespaced_IRI.parse _namespace_name "brailleEmbosserManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/broadcaster"></see>
    /// </summary>
    let broadcaster =
        Namespaced_IRI.parse _namespace_name "broadcaster" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/publisher"></see>
    /// </summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/broadcasterManifestation"></see>
    /// </summary>
    let broadcasterManifestation =
        Namespaced_IRI.parse _namespace_name "broadcasterManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/publisherManifestation"></see>
    /// </summary>
    let publisherManifestation =
        Namespaced_IRI.parse _namespace_name "publisherManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cartographer"></see>
    /// </summary>
    let cartographer =
        Namespaced_IRI.parse _namespace_name "cartographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cartographerWork"></see>
    /// </summary>
    let cartographerWork =
        Namespaced_IRI.parse _namespace_name "cartographerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/caster"></see>
    /// </summary>
    let caster = Namespaced_IRI.parse _namespace_name "caster" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/casterManifestation"></see>
    /// </summary>
    let casterManifestation =
        Namespaced_IRI.parse _namespace_name "casterManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographer"></see>
    /// </summary>
    let choreographer =
        Namespaced_IRI.parse _namespace_name "choreographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographerExpression"></see>
    /// </summary>
    let choreographerExpression =
        Namespaced_IRI.parse _namespace_name "choreographerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/choreographerWork"></see>
    /// </summary>
    let choreographerWork =
        Namespaced_IRI.parse _namespace_name "choreographerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/cinematographer"></see>
    /// </summary>
    let cinematographer =
        Namespaced_IRI.parse _namespace_name "cinematographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectionRegistrar"></see>
    /// </summary>
    let collectionRegistrar =
        Namespaced_IRI.parse _namespace_name "collectionRegistrar" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/curator"></see>
    /// </summary>
    let curator = Namespaced_IRI.parse _namespace_name "curator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectionRegistrarItem"></see>
    /// </summary>
    let collectionRegistrarItem =
        Namespaced_IRI.parse _namespace_name "collectionRegistrarItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collector"></see>
    /// </summary>
    let collector = Namespaced_IRI.parse _namespace_name "collector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collectorItem"></see>
    /// </summary>
    let collectorItem =
        Namespaced_IRI.parse _namespace_name "collectorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collotyper"></see>
    /// </summary>
    let collotyper = Namespaced_IRI.parse _namespace_name "collotyper" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/collotyperManifestation"></see>
    /// </summary>
    let collotyperManifestation =
        Namespaced_IRI.parse _namespace_name "collotyperManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/commentator"></see>
    /// </summary>
    let commentator =
        Namespaced_IRI.parse _namespace_name "commentator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/commentatorExpression"></see>
    /// </summary>
    let commentatorExpression =
        Namespaced_IRI.parse _namespace_name "commentatorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/compiler"></see>
    /// </summary>
    let compiler = Namespaced_IRI.parse _namespace_name "compiler" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/compilerWork"></see>
    /// </summary>
    let compilerWork =
        Namespaced_IRI.parse _namespace_name "compilerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composer"></see>
    /// </summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerExpression"></see>
    /// </summary>
    let composerExpression =
        Namespaced_IRI.parse _namespace_name "composerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfAdditionalMusic"></see>
    /// </summary>
    let composerOfAdditionalMusic =
        Namespaced_IRI.parse _namespace_name "composerOfAdditionalMusic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfAdditionalMusicExpression"></see>
    /// </summary>
    let composerOfAdditionalMusicExpression =
        Namespaced_IRI.parse _namespace_name "composerOfAdditionalMusicExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfIncidentalMusic"></see>
    /// </summary>
    let composerOfIncidentalMusic =
        Namespaced_IRI.parse _namespace_name "composerOfIncidentalMusic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfIncidentalMusicExpression"></see>
    /// </summary>
    let composerOfIncidentalMusicExpression =
        Namespaced_IRI.parse _namespace_name "composerOfIncidentalMusicExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSilentFilm"></see>
    /// </summary>
    let composerOfMusicForSilentFilm =
        Namespaced_IRI.parse _namespace_name "composerOfMusicForSilentFilm" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSilentFilmExpression"></see>
    /// </summary>
    let composerOfMusicForSilentFilmExpression =
        Namespaced_IRI.parse _namespace_name "composerOfMusicForSilentFilmExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSoundFilm"></see>
    /// </summary>
    let composerOfMusicForSoundFilm =
        Namespaced_IRI.parse _namespace_name "composerOfMusicForSoundFilm" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerOfMusicForSoundFilmExpression"></see>
    /// </summary>
    let composerOfMusicForSoundFilmExpression =
        Namespaced_IRI.parse _namespace_name "composerOfMusicForSoundFilmExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/composerWork"></see>
    /// </summary>
    let composerWork =
        Namespaced_IRI.parse _namespace_name "composerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/conductor"></see>
    /// </summary>
    let conductor = Namespaced_IRI.parse _namespace_name "conductor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/conductorExpression"></see>
    /// </summary>
    let conductorExpression =
        Namespaced_IRI.parse _namespace_name "conductorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfMovingImageWorkExpression"></see>
    /// </summary>
    let editorOfMovingImageWorkExpression =
        Namespaced_IRI.parse _namespace_name "editorOfMovingImageWorkExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtReporterExpression"></see>
    /// </summary>
    let courtReporterExpression =
        Namespaced_IRI.parse _namespace_name "courtReporterExpression" |> NamespacedName

    /// <summary>
    /// If the work is primarily the artistic content created by this entity, see artist and photographer.
    /// <see href="http://rdvocab.info/roles/illustratorExpression"></see></summary>
    let illustratorExpression =
        Namespaced_IRI.parse _namespace_name "illustratorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordingEngineerExpression"></see>
    /// </summary>
    let recordingEngineerExpression =
        Namespaced_IRI.parse _namespace_name "recordingEngineerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/stageDirectorExpression"></see>
    /// </summary>
    let stageDirectorExpression =
        Namespaced_IRI.parse _namespace_name "stageDirectorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordistExpression"></see>
    /// </summary>
    let recordistExpression =
        Namespaced_IRI.parse _namespace_name "recordistExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/transcriberExpression"></see>
    /// </summary>
    let transcriberExpression =
        Namespaced_IRI.parse _namespace_name "transcriberExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/intervieweeExpression"></see>
    /// </summary>
    let intervieweeExpression =
        Namespaced_IRI.parse _namespace_name "intervieweeExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/presenterExpression"></see>
    /// </summary>
    let presenterExpression =
        Namespaced_IRI.parse _namespace_name "presenterExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedTextExpression"></see>
    /// </summary>
    let writerOfAddedTextExpression =
        Namespaced_IRI.parse _namespace_name "writerOfAddedTextExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfCompilationExpression"></see>
    /// </summary>
    let editorOfCompilationExpression =
        Namespaced_IRI.parse _namespace_name "editorOfCompilationExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionDesignerExpression"></see>
    /// </summary>
    let productionDesignerExpression =
        Namespaced_IRI.parse _namespace_name "productionDesignerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/translatorExpression"></see>
    /// </summary>
    let translatorExpression =
        Namespaced_IRI.parse _namespace_name "translatorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewerExpression"></see>
    /// </summary>
    let interviewerExpression =
        Namespaced_IRI.parse _namespace_name "interviewerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/surveyorExpression"></see>
    /// </summary>
    let surveyorExpression =
        Namespaced_IRI.parse _namespace_name "surveyorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorExpression"></see>
    /// </summary>
    let editorExpression =
        Namespaced_IRI.parse _namespace_name "editorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/draftsmanExpression"></see>
    /// </summary>
    let draftsmanExpression =
        Namespaced_IRI.parse _namespace_name "draftsmanExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/musicalDirectorExpression"></see>
    /// </summary>
    let musicalDirectorExpression =
        Namespaced_IRI.parse _namespace_name "musicalDirectorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedCommentaryExpression"></see>
    /// </summary>
    let writerOfAddedCommentaryExpression =
        Namespaced_IRI.parse _namespace_name "writerOfAddedCommentaryExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/costumeDesignerExpression"></see>
    /// </summary>
    let costumeDesignerExpression =
        Namespaced_IRI.parse _namespace_name "costumeDesignerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/costumeDesigner"></see>
    /// </summary>
    let costumeDesigner =
        Namespaced_IRI.parse _namespace_name "costumeDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtGoverned"></see>
    /// </summary>
    let courtGoverned =
        Namespaced_IRI.parse _namespace_name "courtGoverned" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtGovernedWork"></see>
    /// </summary>
    let courtGovernedWork =
        Namespaced_IRI.parse _namespace_name "courtGovernedWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/courtReporter"></see>
    /// </summary>
    let courtReporter =
        Namespaced_IRI.parse _namespace_name "courtReporter" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewerWork"></see>
    /// </summary>
    let interviewerWork =
        Namespaced_IRI.parse _namespace_name "interviewerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/designerWork"></see>
    /// </summary>
    let designerWork =
        Namespaced_IRI.parse _namespace_name "designerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmmakerWork"></see>
    /// </summary>
    let filmmakerWork =
        Namespaced_IRI.parse _namespace_name "filmmakerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inventorWork"></see>
    /// </summary>
    let inventorWork =
        Namespaced_IRI.parse _namespace_name "inventorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/intervieweeWork"></see>
    /// </summary>
    let intervieweeWork =
        Namespaced_IRI.parse _namespace_name "intervieweeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/photographerWork"></see>
    /// </summary>
    let photographerWork =
        Namespaced_IRI.parse _namespace_name "photographerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/programmerWork"></see>
    /// </summary>
    let programmerWork =
        Namespaced_IRI.parse _namespace_name "programmerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/enactingJurisdictionWork"></see>
    /// </summary>
    let enactingJurisdictionWork =
        Namespaced_IRI.parse _namespace_name "enactingJurisdictionWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/praesesWork"></see>
    /// </summary>
    let praesesWork =
        Namespaced_IRI.parse _namespace_name "praesesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/respondentWork"></see>
    /// </summary>
    let respondentWork =
        Namespaced_IRI.parse _namespace_name "respondentWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/curatorItem"></see>
    /// </summary>
    let curatorItem =
        Namespaced_IRI.parse _namespace_name "curatorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/currentOwner"></see>
    /// </summary>
    let currentOwner =
        Namespaced_IRI.parse _namespace_name "currentOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/depositor"></see>
    /// </summary>
    let depositor = Namespaced_IRI.parse _namespace_name "depositor" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/owner"></see>
    /// </summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/currentOwnerItem"></see>
    /// </summary>
    let currentOwnerItem =
        Namespaced_IRI.parse _namespace_name "currentOwnerItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/ownerItem"></see>
    /// </summary>
    let ownerItem = Namespaced_IRI.parse _namespace_name "ownerItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/custodian"></see>
    /// </summary>
    let custodian = Namespaced_IRI.parse _namespace_name "custodian" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/custodianItem"></see>
    /// </summary>
    let custodianItem =
        Namespaced_IRI.parse _namespace_name "custodianItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dancer"></see>
    /// </summary>
    let dancer = Namespaced_IRI.parse _namespace_name "dancer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dancerExpression"></see>
    /// </summary>
    let dancerExpression =
        Namespaced_IRI.parse _namespace_name "dancerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicatee"></see>
    /// </summary>
    let dedicatee = Namespaced_IRI.parse _namespace_name "dedicatee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicateeWork"></see>
    /// </summary>
    let dedicateeWork =
        Namespaced_IRI.parse _namespace_name "dedicateeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/dedicateeOfItem"></see>
    /// </summary>
    let dedicateeOfItem =
        Namespaced_IRI.parse _namespace_name "dedicateeOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/defendant"></see>
    /// </summary>
    let defendant = Namespaced_IRI.parse _namespace_name "defendant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/defendantWork"></see>
    /// </summary>
    let defendantWork =
        Namespaced_IRI.parse _namespace_name "defendantWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/degreeGrantingInstitution"></see>
    /// </summary>
    let degreeGrantingInstitution =
        Namespaced_IRI.parse _namespace_name "degreeGrantingInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/degreeGrantingInstitutionWork"></see>
    /// </summary>
    let degreeGrantingInstitutionWork =
        Namespaced_IRI.parse _namespace_name "degreeGrantingInstitutionWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/depositorItem"></see>
    /// </summary>
    let depositorItem =
        Namespaced_IRI.parse _namespace_name "depositorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/designer"></see>
    /// </summary>
    let designer = Namespaced_IRI.parse _namespace_name "designer" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/director"></see>
    /// </summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioDirector"></see>
    /// </summary>
    let radioDirector =
        Namespaced_IRI.parse _namespace_name "radioDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDirector"></see>
    /// </summary>
    let filmDirector =
        Namespaced_IRI.parse _namespace_name "filmDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionDirector"></see>
    /// </summary>
    let televisionDirector =
        Namespaced_IRI.parse _namespace_name "televisionDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/directorWork"></see>
    /// </summary>
    let directorWork =
        Namespaced_IRI.parse _namespace_name "directorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/directorOfPhotography"></see>
    /// </summary>
    let directorOfPhotography =
        Namespaced_IRI.parse _namespace_name "directorOfPhotography" |> NamespacedName

    /// <summary>
    /// Use this designation also for videographers.
    /// <see href="http://rdvocab.info/roles/directorOfPhotographyWork"></see></summary>
    let directorOfPhotographyWork =
        Namespaced_IRI.parse _namespace_name "directorOfPhotographyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionDirectorWork"></see>
    /// </summary>
    let televisionDirectorWork =
        Namespaced_IRI.parse _namespace_name "televisionDirectorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioDirectorWork"></see>
    /// </summary>
    let radioDirectorWork =
        Namespaced_IRI.parse _namespace_name "radioDirectorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDirectorWork"></see>
    /// </summary>
    let filmDirectorWork =
        Namespaced_IRI.parse _namespace_name "filmDirectorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/distributor"></see>
    /// </summary>
    let distributor =
        Namespaced_IRI.parse _namespace_name "distributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/distributorManifestation"></see>
    /// </summary>
    let distributorManifestation =
        Namespaced_IRI.parse _namespace_name "distributorManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDistributor"></see>
    /// </summary>
    let filmDistributor =
        Namespaced_IRI.parse _namespace_name "filmDistributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmDistributorManifestation"></see>
    /// </summary>
    let filmDistributorManifestation =
        Namespaced_IRI.parse _namespace_name "filmDistributorManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/donor"></see>
    /// </summary>
    let donor = Namespaced_IRI.parse _namespace_name "donor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/formerOwner"></see>
    /// </summary>
    let formerOwner =
        Namespaced_IRI.parse _namespace_name "formerOwner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/donorItem"></see>
    /// </summary>
    let donorItem = Namespaced_IRI.parse _namespace_name "donorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/formerOwnerItem"></see>
    /// </summary>
    let formerOwnerItem =
        Namespaced_IRI.parse _namespace_name "formerOwnerItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/draftsman"></see>
    /// </summary>
    let draftsman = Namespaced_IRI.parse _namespace_name "draftsman" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editor"></see>
    /// </summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfCompilation"></see>
    /// </summary>
    let editorOfCompilation =
        Namespaced_IRI.parse _namespace_name "editorOfCompilation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/editorOfMovingImageWork"></see>
    /// </summary>
    let editorOfMovingImageWork =
        Namespaced_IRI.parse _namespace_name "editorOfMovingImageWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/enactingJurisdiction"></see>
    /// </summary>
    let enactingJurisdiction =
        Namespaced_IRI.parse _namespace_name "enactingJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/engraver"></see>
    /// </summary>
    let engraver = Namespaced_IRI.parse _namespace_name "engraver" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/engraverManifestation"></see>
    /// </summary>
    let engraverManifestation =
        Namespaced_IRI.parse _namespace_name "engraverManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/etcher"></see>
    /// </summary>
    let etcher = Namespaced_IRI.parse _namespace_name "etcher" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/etcherManifestation"></see>
    /// </summary>
    let etcherManifestation =
        Namespaced_IRI.parse _namespace_name "etcherManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmProducer"></see>
    /// </summary>
    let filmProducer =
        Namespaced_IRI.parse _namespace_name "filmProducer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/producer"></see>
    /// </summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/filmProducerWork"></see>
    /// </summary>
    let filmProducerWork =
        Namespaced_IRI.parse _namespace_name "filmProducerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/producerWork"></see>
    /// </summary>
    let producerWork =
        Namespaced_IRI.parse _namespace_name "producerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/seller"></see>
    /// </summary>
    let seller = Namespaced_IRI.parse _namespace_name "seller" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sellerItem"></see>
    /// </summary>
    let sellerItem = Namespaced_IRI.parse _namespace_name "sellerItem" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honouree"></see>
    /// </summary>
    let honouree = Namespaced_IRI.parse _namespace_name "honouree" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honoureeWork"></see>
    /// </summary>
    let honoureeWork =
        Namespaced_IRI.parse _namespace_name "honoureeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/honoureeOfItem"></see>
    /// </summary>
    let honoureeOfItem =
        Namespaced_IRI.parse _namespace_name "honoureeOfItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/host"></see>
    /// </summary>
    let host = Namespaced_IRI.parse _namespace_name "host" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostExpression"></see>
    /// </summary>
    let hostExpression =
        Namespaced_IRI.parse _namespace_name "hostExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostInstitution"></see>
    /// </summary>
    let hostInstitution =
        Namespaced_IRI.parse _namespace_name "hostInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/hostInstitutionWork"></see>
    /// </summary>
    let hostInstitutionWork =
        Namespaced_IRI.parse _namespace_name "hostInstitutionWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illuminator"></see>
    /// </summary>
    let illuminator =
        Namespaced_IRI.parse _namespace_name "illuminator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illuminatorItem"></see>
    /// </summary>
    let illuminatorItem =
        Namespaced_IRI.parse _namespace_name "illuminatorItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/illustrator"></see>
    /// </summary>
    let illustrator =
        Namespaced_IRI.parse _namespace_name "illustrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inscriber"></see>
    /// </summary>
    let inscriber = Namespaced_IRI.parse _namespace_name "inscriber" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inscriberItem"></see>
    /// </summary>
    let inscriberItem =
        Namespaced_IRI.parse _namespace_name "inscriberItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/instrumentalist"></see>
    /// </summary>
    let instrumentalist =
        Namespaced_IRI.parse _namespace_name "instrumentalist" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/instrumentalistExpression"></see>
    /// </summary>
    let instrumentalistExpression =
        Namespaced_IRI.parse _namespace_name "instrumentalistExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewee"></see>
    /// </summary>
    let interviewee =
        Namespaced_IRI.parse _namespace_name "interviewee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/interviewer"></see>
    /// </summary>
    let interviewer =
        Namespaced_IRI.parse _namespace_name "interviewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/inventor"></see>
    /// </summary>
    let inventor = Namespaced_IRI.parse _namespace_name "inventor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/issuingBody"></see>
    /// </summary>
    let issuingBody =
        Namespaced_IRI.parse _namespace_name "issuingBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/issuingBodyWork"></see>
    /// </summary>
    let issuingBodyWork =
        Namespaced_IRI.parse _namespace_name "issuingBodyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/judge"></see>
    /// </summary>
    let judge = Namespaced_IRI.parse _namespace_name "judge" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/judgeWork"></see>
    /// </summary>
    let judgeWork = Namespaced_IRI.parse _namespace_name "judgeWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/jurisdictionGoverned"></see>
    /// </summary>
    let jurisdictionGoverned =
        Namespaced_IRI.parse _namespace_name "jurisdictionGoverned" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/jurisdictionGovernedWork"></see>
    /// </summary>
    let jurisdictionGovernedWork =
        Namespaced_IRI.parse _namespace_name "jurisdictionGovernedWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/landscapeArchitectWork"></see>
    /// </summary>
    let landscapeArchitectWork =
        Namespaced_IRI.parse _namespace_name "landscapeArchitectWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lithographer"></see>
    /// </summary>
    let lithographer =
        Namespaced_IRI.parse _namespace_name "lithographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/lithographerManifestation"></see>
    /// </summary>
    let lithographerManifestation =
        Namespaced_IRI.parse _namespace_name "lithographerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printer"></see>
    /// </summary>
    let printer = Namespaced_IRI.parse _namespace_name "printer" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printmaker"></see>
    /// </summary>
    let printmaker = Namespaced_IRI.parse _namespace_name "printmaker" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/platemaker"></see>
    /// </summary>
    let platemaker = Namespaced_IRI.parse _namespace_name "platemaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/platemakerManifestation"></see>
    /// </summary>
    let platemakerManifestation =
        Namespaced_IRI.parse _namespace_name "platemakerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printerManifestation"></see>
    /// </summary>
    let printerManifestation =
        Namespaced_IRI.parse _namespace_name "printerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/printmakerManifestation"></see>
    /// </summary>
    let printmakerManifestation =
        Namespaced_IRI.parse _namespace_name "printmakerManifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/moderator"></see>
    /// </summary>
    let moderator = Namespaced_IRI.parse _namespace_name "moderator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/moderatorExpression"></see>
    /// </summary>
    let moderatorExpression =
        Namespaced_IRI.parse _namespace_name "moderatorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/musicalDirector"></see>
    /// </summary>
    let musicalDirector =
        Namespaced_IRI.parse _namespace_name "musicalDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/narrator"></see>
    /// </summary>
    let narrator = Namespaced_IRI.parse _namespace_name "narrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/narratorExpression"></see>
    /// </summary>
    let narratorExpression =
        Namespaced_IRI.parse _namespace_name "narratorExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/onScreenPresenter"></see>
    /// </summary>
    let onScreenPresenter =
        Namespaced_IRI.parse _namespace_name "onScreenPresenter" |> NamespacedName

    /// <summary>
    /// Use when a more specific term (e.g., Narrator or Host) is either not applicable or not desired.
    /// <see href="http://rdvocab.info/roles/onScreenPresenterExpression"></see></summary>
    let onScreenPresenterExpression =
        Namespaced_IRI.parse _namespace_name "onScreenPresenterExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/panelist"></see>
    /// </summary>
    let panelist = Namespaced_IRI.parse _namespace_name "panelist" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/panelistExpression"></see>
    /// </summary>
    let panelistExpression =
        Namespaced_IRI.parse _namespace_name "panelistExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/storyteller"></see>
    /// </summary>
    let storyteller =
        Namespaced_IRI.parse _namespace_name "storyteller" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/singer"></see>
    /// </summary>
    let singer = Namespaced_IRI.parse _namespace_name "singer" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/teacher"></see>
    /// </summary>
    let teacher = Namespaced_IRI.parse _namespace_name "teacher" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/puppeteer"></see>
    /// </summary>
    let puppeteer = Namespaced_IRI.parse _namespace_name "puppeteer" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/speaker"></see>
    /// </summary>
    let speaker = Namespaced_IRI.parse _namespace_name "speaker" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/singerExpression"></see>
    /// </summary>
    let singerExpression =
        Namespaced_IRI.parse _namespace_name "singerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/speakerExpression"></see>
    /// </summary>
    let speakerExpression =
        Namespaced_IRI.parse _namespace_name "speakerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/storytellerExpression"></see>
    /// </summary>
    let storytellerExpression =
        Namespaced_IRI.parse _namespace_name "storytellerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/photographer"></see>
    /// </summary>
    let photographer =
        Namespaced_IRI.parse _namespace_name "photographer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/plaintiff"></see>
    /// </summary>
    let plaintiff = Namespaced_IRI.parse _namespace_name "plaintiff" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/plaintiffWork"></see>
    /// </summary>
    let plaintiffWork =
        Namespaced_IRI.parse _namespace_name "plaintiffWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/praeses"></see>
    /// </summary>
    let praeses = Namespaced_IRI.parse _namespace_name "praeses" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/presenter"></see>
    /// </summary>
    let presenter = Namespaced_IRI.parse _namespace_name "presenter" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionProducer"></see>
    /// </summary>
    let televisionProducer =
        Namespaced_IRI.parse _namespace_name "televisionProducer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioProducer"></see>
    /// </summary>
    let radioProducer =
        Namespaced_IRI.parse _namespace_name "radioProducer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/radioProducerWork"></see>
    /// </summary>
    let radioProducerWork =
        Namespaced_IRI.parse _namespace_name "radioProducerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/televisionProducerWork"></see>
    /// </summary>
    let televisionProducerWork =
        Namespaced_IRI.parse _namespace_name "televisionProducerWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionCompany"></see>
    /// </summary>
    let productionCompany =
        Namespaced_IRI.parse _namespace_name "productionCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionCompanyWork"></see>
    /// </summary>
    let productionCompanyWork =
        Namespaced_IRI.parse _namespace_name "productionCompanyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/productionDesigner"></see>
    /// </summary>
    let productionDesigner =
        Namespaced_IRI.parse _namespace_name "productionDesigner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/programmer"></see>
    /// </summary>
    let programmer = Namespaced_IRI.parse _namespace_name "programmer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/puppeteerExpression"></see>
    /// </summary>
    let puppeteerExpression =
        Namespaced_IRI.parse _namespace_name "puppeteerExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordingEngineer"></see>
    /// </summary>
    let recordingEngineer =
        Namespaced_IRI.parse _namespace_name "recordingEngineer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/recordist"></see>
    /// </summary>
    let recordist = Namespaced_IRI.parse _namespace_name "recordist" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/roles/respondent"></see>
    /// </summary>
    let respondent = Namespaced_IRI.parse _namespace_name "respondent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/restorationist"></see>
    /// </summary>
    let restorationist =
        Namespaced_IRI.parse _namespace_name "restorationist" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/restorationistItem"></see>
    /// </summary>
    let restorationistItem =
        Namespaced_IRI.parse _namespace_name "restorationistItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sculptorWork"></see>
    /// </summary>
    let sculptorWork =
        Namespaced_IRI.parse _namespace_name "sculptorWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sponsoringBody"></see>
    /// </summary>
    let sponsoringBody =
        Namespaced_IRI.parse _namespace_name "sponsoringBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/sponsoringBodyWork"></see>
    /// </summary>
    let sponsoringBodyWork =
        Namespaced_IRI.parse _namespace_name "sponsoringBodyWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/stageDirector"></see>
    /// </summary>
    let stageDirector =
        Namespaced_IRI.parse _namespace_name "stageDirector" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/surveyor"></see>
    /// </summary>
    let surveyor = Namespaced_IRI.parse _namespace_name "surveyor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/teacherExpression"></see>
    /// </summary>
    let teacherExpression =
        Namespaced_IRI.parse _namespace_name "teacherExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/thesisAdvisor"></see>
    /// </summary>
    let thesisAdvisor =
        Namespaced_IRI.parse _namespace_name "thesisAdvisor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/transcriber"></see>
    /// </summary>
    let transcriber =
        Namespaced_IRI.parse _namespace_name "transcriber" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/translator"></see>
    /// </summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedCommentary"></see>
    /// </summary>
    let writerOfAddedCommentary =
        Namespaced_IRI.parse _namespace_name "writerOfAddedCommentary" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedLyrics"></see>
    /// </summary>
    let writerOfAddedLyrics =
        Namespaced_IRI.parse _namespace_name "writerOfAddedLyrics" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedText"></see>
    /// </summary>
    let writerOfAddedText =
        Namespaced_IRI.parse _namespace_name "writerOfAddedText" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/roles/writerOfAddedLyricsExpression"></see>
    /// </summary>
    let writerOfAddedLyricsExpression =
        Namespaced_IRI.parse _namespace_name "writerOfAddedLyricsExpression" |> NamespacedName

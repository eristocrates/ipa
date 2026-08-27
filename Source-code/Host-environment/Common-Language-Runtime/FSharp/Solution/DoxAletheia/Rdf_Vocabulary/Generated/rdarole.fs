namespace http.rdvocab.info.roles.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdarole =
    let _namespace_iri = Namespace_Iri rdarole |> NamespaceIRI
    /// <summary>
    ///   <para>rdarole:Filmmaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmmaker"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/Filmmaker">http://rdvocab.info/roles/Filmmaker</seealso>
    let Filmmaker = Prefixed_Name(rdarole, "Filmmaker") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:abridger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Abridger"</para><para>"Abridger "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/abridger">http://rdvocab.info/roles/abridger</seealso>
    let abridger = Prefixed_Name(rdarole, "abridger") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:abridgerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Abridger (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/abridgerExpression">http://rdvocab.info/roles/abridgerExpression</seealso>
    let abridgerExpression =
        Prefixed_Name(rdarole, "abridgerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Schauspieler "</para><para>"Actor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/actor">http://rdvocab.info/roles/actor</seealso>
    let actor = Prefixed_Name(rdarole, "actor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:actorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Actor (Expression)"</para><para>"Schauspieler (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/actorExpression">http://rdvocab.info/roles/actorExpression</seealso>
    let actorExpression = Prefixed_Name(rdarole, "actorExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:addressee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Adressat"</para><para>"addressee"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/addressee">http://rdvocab.info/roles/addressee</seealso>
    let addressee = Prefixed_Name(rdarole, "addressee") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:addresseeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Adressat (Werk)"</para><para>"addressee (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/addresseeWork">http://rdvocab.info/roles/addresseeWork</seealso>
    let addresseeWork = Prefixed_Name(rdarole, "addresseeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:animator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Animator"</para><para>"Animator "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/animator">http://rdvocab.info/roles/animator</seealso>
    let animator = Prefixed_Name(rdarole, "animator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:animatorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Animator (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/animatorExpression">http://rdvocab.info/roles/animatorExpression</seealso>
    let animatorExpression =
        Prefixed_Name(rdarole, "animatorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:annotator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Annotator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/annotator">http://rdvocab.info/roles/annotator</seealso>
    let annotator = Prefixed_Name(rdarole, "annotator") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:annotatorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Annotator (Exemplar)"</para><para>"Annotator (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/annotatorItem">http://rdvocab.info/roles/annotatorItem</seealso>
    let annotatorItem = Prefixed_Name(rdarole, "annotatorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:appellant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Appellant"</para><para>"Berufungskläger / Revisionskläger  "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/appellant">http://rdvocab.info/roles/appellant</seealso>
    let appellant = Prefixed_Name(rdarole, "appellant") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:appellantWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Appellant (Work)"</para><para>"Berufungskläger / Revisionskläger (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/appellantWork">http://rdvocab.info/roles/appellantWork</seealso>
    let appellantWork = Prefixed_Name(rdarole, "appellantWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:appellee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Berufungsbeklagter / Revisionsbeklagter "</para><para>"Appellee"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/appellee">http://rdvocab.info/roles/appellee</seealso>
    let appellee = Prefixed_Name(rdarole, "appellee") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:appelleeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Berufungsbeklagter / Revisionsbeklagter (Werk)"</para><para>"Appellee (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/appelleeWork">http://rdvocab.info/roles/appelleeWork</seealso>
    let appelleeWork = Prefixed_Name(rdarole, "appelleeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:architect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Architekt"</para><para>"Architect"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/architect">http://rdvocab.info/roles/architect</seealso>
    let architect = Prefixed_Name(rdarole, "architect") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:architectWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Architekt (Werk)"</para><para>"Architect (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/architectWork">http://rdvocab.info/roles/architectWork</seealso>
    let architectWork = Prefixed_Name(rdarole, "architectWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:arrangerOfMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Arrangeur"</para><para>"Arranger of music"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/arrangerOfMusic">http://rdvocab.info/roles/arrangerOfMusic</seealso>
    let arrangerOfMusic = Prefixed_Name(rdarole, "arrangerOfMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:arrangerOfMusicExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Arranger of music (Expression)"</para><para>"Arrangeur (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/arrangerOfMusicExpression">http://rdvocab.info/roles/arrangerOfMusicExpression</seealso>
    let arrangerOfMusicExpression =
        Prefixed_Name(rdarole, "arrangerOfMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:artDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Art director"</para><para>"Art Director"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/artDirector">http://rdvocab.info/roles/artDirector</seealso>
    let artDirector = Prefixed_Name(rdarole, "artDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:artDirectorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Art director (Expression)"</para><para>"Art Director (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/artDirectorExpression">http://rdvocab.info/roles/artDirectorExpression</seealso>
    let artDirectorExpression =
        Prefixed_Name(rdarole, "artDirectorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Künstler"</para><para>"Artist"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/artist">http://rdvocab.info/roles/artist</seealso>
    let artist = Prefixed_Name(rdarole, "artist") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:artistWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Artist (Work)"</para><para>"Künstler (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/artistWork">http://rdvocab.info/roles/artistWork</seealso>
    let artistWork = Prefixed_Name(rdarole, "artistWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Author"</para><para>"Verfasser"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/author">http://rdvocab.info/roles/author</seealso>
    let author = Prefixed_Name(rdarole, "author") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:authorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Verfasser (Werk)"</para><para>"Author (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/authorWork">http://rdvocab.info/roles/authorWork</seealso>
    let authorWork = Prefixed_Name(rdarole, "authorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:autographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Autographer"</para><para>"Unterzeichner"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/autographer">http://rdvocab.info/roles/autographer</seealso>
    let autographer = Prefixed_Name(rdarole, "autographer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:autographerItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Unterzeichner (Exemplar)"</para><para>"Autographer (item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/autographerItem">http://rdvocab.info/roles/autographerItem</seealso>
    let autographerItem = Prefixed_Name(rdarole, "autographerItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:binder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Buchbinder "</para><para>"Binder"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/binder">http://rdvocab.info/roles/binder</seealso>
    let binder = Prefixed_Name(rdarole, "binder") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:binderItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Binder (Item)"</para><para>"Eine Person, die ein Exemplar bindet. "</para><para>"Buchbinder (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/binderItem">http://rdvocab.info/roles/binderItem</seealso>
    let binderItem = Prefixed_Name(rdarole, "binderItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:bookDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Book designer"</para><para>"Buchgestalter"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/bookDesigner">http://rdvocab.info/roles/bookDesigner</seealso>
    let bookDesigner = Prefixed_Name(rdarole, "bookDesigner") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:bookDesignerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Buchgestalter (Manifestation)"</para><para>"Book designer (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/bookDesignerManifestation">http://rdvocab.info/roles/bookDesignerManifestation</seealso>
    let bookDesignerManifestation =
        Prefixed_Name(rdarole, "bookDesignerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:brailleEmbosser</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Brailleschriftpräger "</para><para>"Braille embosser"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/brailleEmbosser">http://rdvocab.info/roles/brailleEmbosser</seealso>
    let brailleEmbosser = Prefixed_Name(rdarole, "brailleEmbosser") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:brailleEmbosserManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Brailleschriftpräger (Manifestation)"</para><para>"Braille embosser (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/brailleEmbosserManifestation">http://rdvocab.info/roles/brailleEmbosserManifestation</seealso>
    let brailleEmbosserManifestation =
        Prefixed_Name(rdarole, "brailleEmbosserManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:broadcaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Broadcaster"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/broadcaster">http://rdvocab.info/roles/broadcaster</seealso>
    let broadcaster = Prefixed_Name(rdarole, "broadcaster") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:broadcasterManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Broadcaster (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/broadcasterManifestation">http://rdvocab.info/roles/broadcasterManifestation</seealso>
    let broadcasterManifestation =
        Prefixed_Name(rdarole, "broadcasterManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:cartographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kartograf "</para><para>"Cartographer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/cartographer">http://rdvocab.info/roles/cartographer</seealso>
    let cartographer = Prefixed_Name(rdarole, "cartographer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:cartographerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kartograf (Werk)"</para><para>"Cartographer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/cartographerWork">http://rdvocab.info/roles/cartographerWork</seealso>
    let cartographerWork = Prefixed_Name(rdarole, "cartographerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:caster</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Formgießer "</para><para>"Caster"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/caster">http://rdvocab.info/roles/caster</seealso>
    let caster = Prefixed_Name(rdarole, "caster") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:casterManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Caster (Manifestation)"</para><para>"Formgießer (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/casterManifestation">http://rdvocab.info/roles/casterManifestation</seealso>
    let casterManifestation =
        Prefixed_Name(rdarole, "casterManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:choreographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Choreographer "</para><para>"Choreograf "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/choreographer">http://rdvocab.info/roles/choreographer</seealso>
    let choreographer = Prefixed_Name(rdarole, "choreographer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:choreographerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Choreographer (Expression)"</para><para>"Choreograph (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/choreographerExpression">http://rdvocab.info/roles/choreographerExpression</seealso>
    let choreographerExpression =
        Prefixed_Name(rdarole, "choreographerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:choreographerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Choreograf (Werk)"</para><para>"Choreographer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/choreographerWork">http://rdvocab.info/roles/choreographerWork</seealso>
    let choreographerWork = Prefixed_Name(rdarole, "choreographerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:cinematographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kameramann"</para><para>"Cinematographer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/cinematographer">http://rdvocab.info/roles/cinematographer</seealso>
    let cinematographer = Prefixed_Name(rdarole, "cinematographer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:collectionRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Collection registrar"</para><para>"Registrar "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collectionRegistrar">http://rdvocab.info/roles/collectionRegistrar</seealso>
    let collectionRegistrar =
        Prefixed_Name(rdarole, "collectionRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:collectionRegistrarItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Collection registrar (Item)"</para><para>"Registrar (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collectionRegistrarItem">http://rdvocab.info/roles/collectionRegistrarItem</seealso>
    let collectionRegistrarItem =
        Prefixed_Name(rdarole, "collectionRegistrarItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sammler"</para><para>"Collector"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collector">http://rdvocab.info/roles/collector</seealso>
    let collector = Prefixed_Name(rdarole, "collector") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:collectorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sammler (Exemplar)"</para><para>"Collector (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collectorItem">http://rdvocab.info/roles/collectorItem</seealso>
    let collectorItem = Prefixed_Name(rdarole, "collectorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:collotyper</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Collotyper"</para><para>"Drucker (im Lichtdruckverfahren) "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collotyper">http://rdvocab.info/roles/collotyper</seealso>
    let collotyper = Prefixed_Name(rdarole, "collotyper") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:collotyperManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Collotyper (Manifestation)"</para><para>"Drucker (im Lichtdruckverfahren) (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/collotyperManifestation">http://rdvocab.info/roles/collotyperManifestation</seealso>
    let collotyperManifestation =
        Prefixed_Name(rdarole, "collotyperManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:commentator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kommentator (mündlich) "</para><para>"Commentator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/commentator">http://rdvocab.info/roles/commentator</seealso>
    let commentator = Prefixed_Name(rdarole, "commentator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:commentatorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kommentator (mündlich) (Expression)"</para><para>"Commentator (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/commentatorExpression">http://rdvocab.info/roles/commentatorExpression</seealso>
    let commentatorExpression =
        Prefixed_Name(rdarole, "commentatorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:compiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Compiler"</para><para>"Compiler "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/compiler">http://rdvocab.info/roles/compiler</seealso>
    let compiler = Prefixed_Name(rdarole, "compiler") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:compilerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Compiler (Werk)"</para><para>"Compiler (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/compilerWork">http://rdvocab.info/roles/compilerWork</seealso>
    let compilerWork = Prefixed_Name(rdarole, "compilerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Komponist "</para><para>"Composer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composer">http://rdvocab.info/roles/composer</seealso>
    let composer = Prefixed_Name(rdarole, "composer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer (Expression)"</para><para>"Komponist (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerExpression">http://rdvocab.info/roles/composerExpression</seealso>
    let composerExpression =
        Prefixed_Name(rdarole, "composerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfAdditionalMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Komponist eines zusätzlichen Musikstückes "</para><para>"Composer of Additional Music"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfAdditionalMusic">http://rdvocab.info/roles/composerOfAdditionalMusic</seealso>
    let composerOfAdditionalMusic =
        Prefixed_Name(rdarole, "composerOfAdditionalMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfAdditionalMusicExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer of Additional Music (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfAdditionalMusicExpression">http://rdvocab.info/roles/composerOfAdditionalMusicExpression</seealso>
    let composerOfAdditionalMusicExpression =
        Prefixed_Name(rdarole, "composerOfAdditionalMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfIncidentalMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Komponist von Begleitmusik "</para><para>"Composer of Incidental Music"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfIncidentalMusic">http://rdvocab.info/roles/composerOfIncidentalMusic</seealso>
    let composerOfIncidentalMusic =
        Prefixed_Name(rdarole, "composerOfIncidentalMusic") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfIncidentalMusicExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer of Incidental Music (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfIncidentalMusicExpression">http://rdvocab.info/roles/composerOfIncidentalMusicExpression</seealso>
    let composerOfIncidentalMusicExpression =
        Prefixed_Name(rdarole, "composerOfIncidentalMusicExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfMusicForSilentFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer of Music for Silent Film"</para><para>"Komponist von Stummfilm-Musik "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfMusicForSilentFilm">http://rdvocab.info/roles/composerOfMusicForSilentFilm</seealso>
    let composerOfMusicForSilentFilm =
        Prefixed_Name(rdarole, "composerOfMusicForSilentFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfMusicForSilentFilmExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer of Music for Silent Film (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfMusicForSilentFilmExpression">http://rdvocab.info/roles/composerOfMusicForSilentFilmExpression</seealso>
    let composerOfMusicForSilentFilmExpression =
        Prefixed_Name(rdarole, "composerOfMusicForSilentFilmExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfMusicForSoundFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Composer of Music for Sound Film"</para><para>"Filmkomponist "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfMusicForSoundFilm">http://rdvocab.info/roles/composerOfMusicForSoundFilm</seealso>
    let composerOfMusicForSoundFilm =
        Prefixed_Name(rdarole, "composerOfMusicForSoundFilm") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerOfMusicForSoundFilmExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmkomponist (Expression)"</para><para>"Composer of Music for Sound Film (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerOfMusicForSoundFilmExpression">http://rdvocab.info/roles/composerOfMusicForSoundFilmExpression</seealso>
    let composerOfMusicForSoundFilmExpression =
        Prefixed_Name(rdarole, "composerOfMusicForSoundFilmExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:composerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Komponist (Werk)"</para><para>"Composer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/composerWork">http://rdvocab.info/roles/composerWork</seealso>
    let composerWork = Prefixed_Name(rdarole, "composerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Dirigent "</para><para>"Conductor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/conductor">http://rdvocab.info/roles/conductor</seealso>
    let conductor = Prefixed_Name(rdarole, "conductor") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:conductorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Dirigent (Expression)"</para><para>"Conductor (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/conductorExpression">http://rdvocab.info/roles/conductorExpression</seealso>
    let conductorExpression =
        Prefixed_Name(rdarole, "conductorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Contributor"</para><para>"Mitwirkender "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/contributor">http://rdvocab.info/roles/contributor</seealso>
    let contributor = Prefixed_Name(rdarole, "contributor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:costumeDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kostümbildner "</para><para>"Costume designer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/costumeDesigner">http://rdvocab.info/roles/costumeDesigner</seealso>
    let costumeDesigner = Prefixed_Name(rdarole, "costumeDesigner") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:costumeDesignerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kostümbildner (Expression)"</para><para>"Costume designer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/costumeDesignerExpression">http://rdvocab.info/roles/costumeDesignerExpression</seealso>
    let costumeDesignerExpression =
        Prefixed_Name(rdarole, "costumeDesignerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:courtGoverned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Court governed"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/courtGoverned">http://rdvocab.info/roles/courtGoverned</seealso>
    let courtGoverned = Prefixed_Name(rdarole, "courtGoverned") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:courtGovernedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Court governed"</para><para>"Court governed (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/courtGovernedWork">http://rdvocab.info/roles/courtGovernedWork</seealso>
    let courtGovernedWork = Prefixed_Name(rdarole, "courtGovernedWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:courtReporter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Court reporter"</para><para>"Gerichtsstenograf"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/courtReporter">http://rdvocab.info/roles/courtReporter</seealso>
    let courtReporter = Prefixed_Name(rdarole, "courtReporter") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:courtReporterExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Court reporter (Expression)"</para><para>"Gerichtsstenograf (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/courtReporterExpression">http://rdvocab.info/roles/courtReporterExpression</seealso>
    let courtReporterExpression =
        Prefixed_Name(rdarole, "courtReporterExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Creator"</para><para>"geistiger Schöpfer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/creator">http://rdvocab.info/roles/creator</seealso>
    let creator = Prefixed_Name(rdarole, "creator") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:curator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Curator"</para><para>"Kurator "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/curator">http://rdvocab.info/roles/curator</seealso>
    let curator = Prefixed_Name(rdarole, "curator") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:curatorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Kurator (Exemplar)"</para><para>"Curator (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/curatorItem">http://rdvocab.info/roles/curatorItem</seealso>
    let curatorItem = Prefixed_Name(rdarole, "curatorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:currentOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Current owner"</para><para>"Derzeitiger Besitzer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/currentOwner">http://rdvocab.info/roles/currentOwner</seealso>
    let currentOwner = Prefixed_Name(rdarole, "currentOwner") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:currentOwnerItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Current owner (Item)"</para><para>"Derzeitiger Besitzer (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/currentOwnerItem">http://rdvocab.info/roles/currentOwnerItem</seealso>
    let currentOwnerItem = Prefixed_Name(rdarole, "currentOwnerItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:custodian</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Custodian"</para><para>"Besitzer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/custodian">http://rdvocab.info/roles/custodian</seealso>
    let custodian = Prefixed_Name(rdarole, "custodian") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:custodianItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Custodian (Item)"</para><para>"Besitzer (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/custodianItem">http://rdvocab.info/roles/custodianItem</seealso>
    let custodianItem = Prefixed_Name(rdarole, "custodianItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:dancer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Dancer"</para><para>"Tänzer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/dancer">http://rdvocab.info/roles/dancer</seealso>
    let dancer = Prefixed_Name(rdarole, "dancer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:dancerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Dancer (Expression)"</para><para>"Tänzer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/dancerExpression">http://rdvocab.info/roles/dancerExpression</seealso>
    let dancerExpression = Prefixed_Name(rdarole, "dancerExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:dedicatee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Person, der ein Werk gewidmet ist "</para><para>"Dedicatee"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/dedicatee">http://rdvocab.info/roles/dedicatee</seealso>
    let dedicatee = Prefixed_Name(rdarole, "dedicatee") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:dedicateeOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Person, der ein Exemplar gewidmet ist"</para><para>"Dedicatee of Item"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/dedicateeOfItem">http://rdvocab.info/roles/dedicateeOfItem</seealso>
    let dedicateeOfItem = Prefixed_Name(rdarole, "dedicateeOfItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:dedicateeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Person, der ein Werk gewidmet ist "</para><para>"Dedicatee (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/dedicateeWork">http://rdvocab.info/roles/dedicateeWork</seealso>
    let dedicateeWork = Prefixed_Name(rdarole, "dedicateeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:defendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Defendant"</para><para>"Angeklagter/Beklagter (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/defendant">http://rdvocab.info/roles/defendant</seealso>
    let defendant = Prefixed_Name(rdarole, "defendant") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:defendantWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Defendant (Work)"</para><para>"Angeklagter/Beklagter (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/defendantWork">http://rdvocab.info/roles/defendantWork</seealso>
    let defendantWork = Prefixed_Name(rdarole, "defendantWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:degreeGrantingInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Degree granting institution"</para><para>"Institution, die einen akademischen Grad verleiht "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/degreeGrantingInstitution">http://rdvocab.info/roles/degreeGrantingInstitution</seealso>
    let degreeGrantingInstitution =
        Prefixed_Name(rdarole, "degreeGrantingInstitution") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:degreeGrantingInstitutionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Institution, die einen akademischen Grad verleiht (Werk)"</para><para>"Degree granting institution (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/degreeGrantingInstitutionWork">http://rdvocab.info/roles/degreeGrantingInstitutionWork</seealso>
    let degreeGrantingInstitutionWork =
        Prefixed_Name(rdarole, "degreeGrantingInstitutionWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:depositor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Depositor"</para><para>"Leihgeber "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/depositor">http://rdvocab.info/roles/depositor</seealso>
    let depositor = Prefixed_Name(rdarole, "depositor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:depositorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Depositor (Item)"</para><para>"Leihgeber (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/depositorItem">http://rdvocab.info/roles/depositorItem</seealso>
    let depositorItem = Prefixed_Name(rdarole, "depositorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:designer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Designer"</para><para>"Designer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/designer">http://rdvocab.info/roles/designer</seealso>
    let designer = Prefixed_Name(rdarole, "designer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:designerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Designer (Werk)"</para><para>"Designer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/designerWork">http://rdvocab.info/roles/designerWork</seealso>
    let designerWork = Prefixed_Name(rdarole, "designerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:director</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Director"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/director">http://rdvocab.info/roles/director</seealso>
    let director = Prefixed_Name(rdarole, "director") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:directorOfPhotography</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Director of photography"</para><para>"Verantwortlicher Kameramann "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/directorOfPhotography">http://rdvocab.info/roles/directorOfPhotography</seealso>
    let directorOfPhotography =
        Prefixed_Name(rdarole, "directorOfPhotography") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:directorOfPhotographyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Use this designation also for videographers."</para>
    /// labels<para>"Director of photography (Work)"</para><para>"Verantwortlicher Kameramann (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/directorOfPhotographyWork">http://rdvocab.info/roles/directorOfPhotographyWork</seealso>
    let directorOfPhotographyWork =
        Prefixed_Name(rdarole, "directorOfPhotographyWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:directorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Director (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/directorWork">http://rdvocab.info/roles/directorWork</seealso>
    let directorWork = Prefixed_Name(rdarole, "directorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:distributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Distributor"</para><para>"Vertrieb"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/distributor">http://rdvocab.info/roles/distributor</seealso>
    let distributor = Prefixed_Name(rdarole, "distributor") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:distributorManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Vertrieb (Manifestation)"</para><para>"Distributor (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/distributorManifestation">http://rdvocab.info/roles/distributorManifestation</seealso>
    let distributorManifestation =
        Prefixed_Name(rdarole, "distributorManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:donor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stifter "</para><para>"Donor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/donor">http://rdvocab.info/roles/donor</seealso>
    let donor = Prefixed_Name(rdarole, "donor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:donorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stifter (Exemplar)"</para><para>"Donor (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/donorItem">http://rdvocab.info/roles/donorItem</seealso>
    let donorItem = Prefixed_Name(rdarole, "donorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:draftsman</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Draftsman"</para><para>"Technischer Zeichner"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/draftsman">http://rdvocab.info/roles/draftsman</seealso>
    let draftsman = Prefixed_Name(rdarole, "draftsman") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:draftsmanExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Technischer Zeichner (Expression)"</para><para>"Draftsman (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/draftsmanExpression">http://rdvocab.info/roles/draftsmanExpression</seealso>
    let draftsmanExpression =
        Prefixed_Name(rdarole, "draftsmanExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Editor"</para><para>"Herausgeber "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editor">http://rdvocab.info/roles/editor</seealso>
    let editor = Prefixed_Name(rdarole, "editor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:editorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Herausgeber (Expression)"</para><para>"Editor (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editorExpression">http://rdvocab.info/roles/editorExpression</seealso>
    let editorExpression = Prefixed_Name(rdarole, "editorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:editorOfCompilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Compilation Editor"</para><para>"Editor of compilation"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editorOfCompilation">http://rdvocab.info/roles/editorOfCompilation</seealso>
    let editorOfCompilation =
        Prefixed_Name(rdarole, "editorOfCompilation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:editorOfCompilationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Compilation Editor "</para><para>"Editor of compilation (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editorOfCompilationExpression">http://rdvocab.info/roles/editorOfCompilationExpression</seealso>
    let editorOfCompilationExpression =
        Prefixed_Name(rdarole, "editorOfCompilationExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:editorOfMovingImageWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Editor of moving image work"</para><para>"Cutter"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editorOfMovingImageWork">http://rdvocab.info/roles/editorOfMovingImageWork</seealso>
    let editorOfMovingImageWork =
        Prefixed_Name(rdarole, "editorOfMovingImageWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:editorOfMovingImageWorkExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Editor of moving image work (Expression)"</para><para>"Cutter (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/editorOfMovingImageWorkExpression">http://rdvocab.info/roles/editorOfMovingImageWorkExpression</seealso>
    let editorOfMovingImageWorkExpression =
        Prefixed_Name(rdarole, "editorOfMovingImageWorkExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:enactingJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Normerlassender Rechtsträger "</para><para>"Enacting jurisdiction"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/enactingJurisdiction">http://rdvocab.info/roles/enactingJurisdiction</seealso>
    let enactingJurisdiction =
        Prefixed_Name(rdarole, "enactingJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:enactingJurisdictionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Normerlassender Rechtsträger (Werk)"</para><para>"Enacting jurisdiction (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/enactingJurisdictionWork">http://rdvocab.info/roles/enactingJurisdictionWork</seealso>
    let enactingJurisdictionWork =
        Prefixed_Name(rdarole, "enactingJurisdictionWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:engraver</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Engraver"</para><para>"Graveur "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/engraver">http://rdvocab.info/roles/engraver</seealso>
    let engraver = Prefixed_Name(rdarole, "engraver") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:engraverManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Engraver (Manifestation)"</para><para>"Graveur (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/engraverManifestation">http://rdvocab.info/roles/engraverManifestation</seealso>
    let engraverManifestation =
        Prefixed_Name(rdarole, "engraverManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:etcher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radierer "</para><para>"Etcher"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/etcher">http://rdvocab.info/roles/etcher</seealso>
    let etcher = Prefixed_Name(rdarole, "etcher") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:etcherManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Etcher (Manifestation)"</para><para>"Radierer (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/etcherManifestation">http://rdvocab.info/roles/etcherManifestation</seealso>
    let etcherManifestation =
        Prefixed_Name(rdarole, "etcherManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:filmDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmregisseur "</para><para>"Film director"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmDirector">http://rdvocab.info/roles/filmDirector</seealso>
    let filmDirector = Prefixed_Name(rdarole, "filmDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:filmDirectorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmregisseur (Werk)"</para><para>"Film director (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmDirectorWork">http://rdvocab.info/roles/filmDirectorWork</seealso>
    let filmDirectorWork = Prefixed_Name(rdarole, "filmDirectorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:filmDistributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmverleiher "</para><para>"Film distributor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmDistributor">http://rdvocab.info/roles/filmDistributor</seealso>
    let filmDistributor = Prefixed_Name(rdarole, "filmDistributor") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:filmDistributorManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmverleiher (Manifestation)"</para><para>"Film distributor (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmDistributorManifestation">http://rdvocab.info/roles/filmDistributorManifestation</seealso>
    let filmDistributorManifestation =
        Prefixed_Name(rdarole, "filmDistributorManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:filmProducer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Film producer"</para><para>"Filmproduzent "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmProducer">http://rdvocab.info/roles/filmProducer</seealso>
    let filmProducer = Prefixed_Name(rdarole, "filmProducer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:filmProducerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmproduzent (Werk)"</para><para>"Film producer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmProducerWork">http://rdvocab.info/roles/filmProducerWork</seealso>
    let filmProducerWork = Prefixed_Name(rdarole, "filmProducerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:filmmakerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Filmemacher (Werk)"</para><para>"Filmmaker (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/filmmakerWork">http://rdvocab.info/roles/filmmakerWork</seealso>
    let filmmakerWork = Prefixed_Name(rdarole, "filmmakerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:formerOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Former owner"</para><para>"Früherer Besitzer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/formerOwner">http://rdvocab.info/roles/formerOwner</seealso>
    let formerOwner = Prefixed_Name(rdarole, "formerOwner") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:formerOwnerItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Früherer Besitzer (Exemplar)"</para><para>"Former owner (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/formerOwnerItem">http://rdvocab.info/roles/formerOwnerItem</seealso>
    let formerOwnerItem = Prefixed_Name(rdarole, "formerOwnerItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:honouree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Gefeierte Person"</para><para>"Honouree"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/honouree">http://rdvocab.info/roles/honouree</seealso>
    let honouree = Prefixed_Name(rdarole, "honouree") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:honoureeOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Honouree of item"</para><para>"Mit einem Exemplar geehrte Person."</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/honoureeOfItem">http://rdvocab.info/roles/honoureeOfItem</seealso>
    let honoureeOfItem = Prefixed_Name(rdarole, "honoureeOfItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:honoureeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Gefeierte Person (Werk)"</para><para>"Honouree (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/honoureeWork">http://rdvocab.info/roles/honoureeWork</seealso>
    let honoureeWork = Prefixed_Name(rdarole, "honoureeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:host</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Host"</para><para>"Gastgeber "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/host">http://rdvocab.info/roles/host</seealso>
    let host = Prefixed_Name(rdarole, "host") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:hostExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Gastgeber (Expression)"</para><para>"Host (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/hostExpression">http://rdvocab.info/roles/hostExpression</seealso>
    let hostExpression = Prefixed_Name(rdarole, "hostExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:hostInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Veranstalter "</para><para>"Host institution"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/hostInstitution">http://rdvocab.info/roles/hostInstitution</seealso>
    let hostInstitution = Prefixed_Name(rdarole, "hostInstitution") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:hostInstitutionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Veranstalter (Werk)"</para><para>"Host institution (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/hostInstitutionWork">http://rdvocab.info/roles/hostInstitutionWork</seealso>
    let hostInstitutionWork =
        Prefixed_Name(rdarole, "hostInstitutionWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:illuminator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Illuminator"</para><para>"Illuminator "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/illuminator">http://rdvocab.info/roles/illuminator</seealso>
    let illuminator = Prefixed_Name(rdarole, "illuminator") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:illuminatorItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Illuminator (Exemplar)"</para><para>"Illuminator (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/illuminatorItem">http://rdvocab.info/roles/illuminatorItem</seealso>
    let illuminatorItem = Prefixed_Name(rdarole, "illuminatorItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:illustrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Illustrator "</para><para>"Illustrator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/illustrator">http://rdvocab.info/roles/illustrator</seealso>
    let illustrator = Prefixed_Name(rdarole, "illustrator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:illustratorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"If the work is primarily the artistic content created by this entity, see artist and photographer."</para>
    /// labels<para>"Illustrator (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/illustratorExpression">http://rdvocab.info/roles/illustratorExpression</seealso>
    let illustratorExpression =
        Prefixed_Name(rdarole, "illustratorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:inscriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Person, deren handschriftliche Anmerkungen in einem Exemplar erscheinen"</para><para>"Inscriber"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/inscriber">http://rdvocab.info/roles/inscriber</seealso>
    let inscriber = Prefixed_Name(rdarole, "inscriber") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:inscriberItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Person, deren handschriftliche Anmerkungen in einem Exemplar erscheinen (Exemplar)"</para><para>"Inscriber (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/inscriberItem">http://rdvocab.info/roles/inscriberItem</seealso>
    let inscriberItem = Prefixed_Name(rdarole, "inscriberItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:instrumentalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Instrumentalist"</para><para>"Instrumentalmusiker "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/instrumentalist">http://rdvocab.info/roles/instrumentalist</seealso>
    let instrumentalist = Prefixed_Name(rdarole, "instrumentalist") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:instrumentalistExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Instrumentalist (Expression)"</para><para>"Instrumentalmusiker (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/instrumentalistExpression">http://rdvocab.info/roles/instrumentalistExpression</seealso>
    let instrumentalistExpression =
        Prefixed_Name(rdarole, "instrumentalistExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:interviewee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewee"</para><para>"Interviewter "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/interviewee">http://rdvocab.info/roles/interviewee</seealso>
    let interviewee = Prefixed_Name(rdarole, "interviewee") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:intervieweeExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewter (Expression)"</para><para>"Interviewee (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/intervieweeExpression">http://rdvocab.info/roles/intervieweeExpression</seealso>
    let intervieweeExpression =
        Prefixed_Name(rdarole, "intervieweeExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:intervieweeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewee (Work)"</para><para>"Interviewer (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/intervieweeWork">http://rdvocab.info/roles/intervieweeWork</seealso>
    let intervieweeWork = Prefixed_Name(rdarole, "intervieweeWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:interviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewer"</para><para>"Interviewer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/interviewer">http://rdvocab.info/roles/interviewer</seealso>
    let interviewer = Prefixed_Name(rdarole, "interviewer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:interviewerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/interviewerExpression">http://rdvocab.info/roles/interviewerExpression</seealso>
    let interviewerExpression =
        Prefixed_Name(rdarole, "interviewerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:interviewerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Interviewer (Work)"</para><para>"Interviewter (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/interviewerWork">http://rdvocab.info/roles/interviewerWork</seealso>
    let interviewerWork = Prefixed_Name(rdarole, "interviewerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:inventor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Erfinder "</para><para>"Inventor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/inventor">http://rdvocab.info/roles/inventor</seealso>
    let inventor = Prefixed_Name(rdarole, "inventor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:inventorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Inventor (Work)"</para><para>"Erfinder (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/inventorWork">http://rdvocab.info/roles/inventorWork</seealso>
    let inventorWork = Prefixed_Name(rdarole, "inventorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:issuingBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Issuing body"</para><para>"Veröffentlichendes Organ "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/issuingBody">http://rdvocab.info/roles/issuingBody</seealso>
    let issuingBody = Prefixed_Name(rdarole, "issuingBody") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:issuingBodyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Veröffentlichendes Organ (Werk)"</para><para>"Issuing body (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/issuingBodyWork">http://rdvocab.info/roles/issuingBodyWork</seealso>
    let issuingBodyWork = Prefixed_Name(rdarole, "issuingBodyWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:judge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Richter "</para><para>"Judge"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/judge">http://rdvocab.info/roles/judge</seealso>
    let judge = Prefixed_Name(rdarole, "judge") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:judgeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Richter (Werk)"</para><para>"Judge (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/judgeWork">http://rdvocab.info/roles/judgeWork</seealso>
    let judgeWork = Prefixed_Name(rdarole, "judgeWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:jurisdictionGoverned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Jurisdiction governed"</para><para>"Normunterworfener Rechtsträger "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/jurisdictionGoverned">http://rdvocab.info/roles/jurisdictionGoverned</seealso>
    let jurisdictionGoverned =
        Prefixed_Name(rdarole, "jurisdictionGoverned") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:jurisdictionGovernedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Normunterworfener Rechtsträger (Werk)"</para><para>"Jurisdiction governed (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/jurisdictionGovernedWork">http://rdvocab.info/roles/jurisdictionGovernedWork</seealso>
    let jurisdictionGovernedWork =
        Prefixed_Name(rdarole, "jurisdictionGovernedWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:landscapeArchitect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Landscape architect"</para><para>"Landschaftsarchitekt "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/landscapeArchitect">http://rdvocab.info/roles/landscapeArchitect</seealso>
    let landscapeArchitect =
        Prefixed_Name(rdarole, "landscapeArchitect") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:landscapeArchitectWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Landscape architect (Work)"</para><para>"Landschaftsarchitekt (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/landscapeArchitectWork">http://rdvocab.info/roles/landscapeArchitectWork</seealso>
    let landscapeArchitectWork =
        Prefixed_Name(rdarole, "landscapeArchitectWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:librettist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Librettist"</para><para>"Librettist "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/librettist">http://rdvocab.info/roles/librettist</seealso>
    let librettist = Prefixed_Name(rdarole, "librettist") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:librettistWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Librettist (Work)"</para><para>"Librettist (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/librettistWork">http://rdvocab.info/roles/librettistWork</seealso>
    let librettistWork = Prefixed_Name(rdarole, "librettistWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:lithographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Lithograf "</para><para>"Lithographer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/lithographer">http://rdvocab.info/roles/lithographer</seealso>
    let lithographer = Prefixed_Name(rdarole, "lithographer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:lithographerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Lithographer (Manifestation)"</para><para>"Lithograf (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/lithographerManifestation">http://rdvocab.info/roles/lithographerManifestation</seealso>
    let lithographerManifestation =
        Prefixed_Name(rdarole, "lithographerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:lyricist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Textdichter "</para><para>"Lyricist"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/lyricist">http://rdvocab.info/roles/lyricist</seealso>
    let lyricist = Prefixed_Name(rdarole, "lyricist") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:lyricistWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Lyricist (Work)"</para><para>"Textdichter (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/lyricistWork">http://rdvocab.info/roles/lyricistWork</seealso>
    let lyricistWork = Prefixed_Name(rdarole, "lyricistWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Hersteller "</para><para>"Manufacturer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/manufacturer">http://rdvocab.info/roles/manufacturer</seealso>
    let manufacturer = Prefixed_Name(rdarole, "manufacturer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:manufacturerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Hersteller (Manifestation)"</para><para>"Manufacturer (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/manufacturerManifestation">http://rdvocab.info/roles/manufacturerManifestation</seealso>
    let manufacturerManifestation =
        Prefixed_Name(rdarole, "manufacturerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:moderator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Moderator "</para><para>"Moderator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/moderator">http://rdvocab.info/roles/moderator</seealso>
    let moderator = Prefixed_Name(rdarole, "moderator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:moderatorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Moderator (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/moderatorExpression">http://rdvocab.info/roles/moderatorExpression</seealso>
    let moderatorExpression =
        Prefixed_Name(rdarole, "moderatorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:musicalDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Musical director"</para><para>"Musikalischer Leiter "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/musicalDirector">http://rdvocab.info/roles/musicalDirector</seealso>
    let musicalDirector = Prefixed_Name(rdarole, "musicalDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:musicalDirectorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Musical director (Expression)"</para><para>"Musikalischer Leiter (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/musicalDirectorExpression">http://rdvocab.info/roles/musicalDirectorExpression</seealso>
    let musicalDirectorExpression =
        Prefixed_Name(rdarole, "musicalDirectorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:narrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Erzähler "</para><para>"Narrator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/narrator">http://rdvocab.info/roles/narrator</seealso>
    let narrator = Prefixed_Name(rdarole, "narrator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:narratorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Narrator (Expression)"</para><para>"Erzähler (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/narratorExpression">http://rdvocab.info/roles/narratorExpression</seealso>
    let narratorExpression =
        Prefixed_Name(rdarole, "narratorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:onScreenPresenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"On-screen presenter"</para><para>"On-screen Presenter "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/onScreenPresenter">http://rdvocab.info/roles/onScreenPresenter</seealso>
    let onScreenPresenter = Prefixed_Name(rdarole, "onScreenPresenter") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:onScreenPresenterExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Use when a more specific term (e.g., Narrator or Host) is either not applicable or not desired."</para>
    /// labels<para>"On-screen Presenter (Expression)"</para><para>"On-screen presenter (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/onScreenPresenterExpression">http://rdvocab.info/roles/onScreenPresenterExpression</seealso>
    let onScreenPresenterExpression =
        Prefixed_Name(rdarole, "onScreenPresenterExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Owner"</para><para>"Besitzer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/owner">http://rdvocab.info/roles/owner</seealso>
    let owner = Prefixed_Name(rdarole, "owner") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:ownerItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Besitzer (Exemplar)"</para><para>"Owner (Item)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/ownerItem">http://rdvocab.info/roles/ownerItem</seealso>
    let ownerItem = Prefixed_Name(rdarole, "ownerItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:panelist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Panelist"</para><para>"Diskussionsteilnehmer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/panelist">http://rdvocab.info/roles/panelist</seealso>
    let panelist = Prefixed_Name(rdarole, "panelist") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:panelistExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Diskussionsteilnehmer (Expression)"</para><para>"Panelist (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/panelistExpression">http://rdvocab.info/roles/panelistExpression</seealso>
    let panelistExpression =
        Prefixed_Name(rdarole, "panelistExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Darsteller "</para><para>"Performer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/performer">http://rdvocab.info/roles/performer</seealso>
    let performer = Prefixed_Name(rdarole, "performer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:performerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Darsteller (Expression)"</para><para>"Performer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/performerExpression">http://rdvocab.info/roles/performerExpression</seealso>
    let performerExpression =
        Prefixed_Name(rdarole, "performerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:photographer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Photographer"</para><para>"Fotograf "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/photographer">http://rdvocab.info/roles/photographer</seealso>
    let photographer = Prefixed_Name(rdarole, "photographer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:photographerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Photographer (Work)"</para><para>"Fotograf (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/photographerWork">http://rdvocab.info/roles/photographerWork</seealso>
    let photographerWork = Prefixed_Name(rdarole, "photographerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:plaintiff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Zivilkläger "</para><para>"Plaintiff"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/plaintiff">http://rdvocab.info/roles/plaintiff</seealso>
    let plaintiff = Prefixed_Name(rdarole, "plaintiff") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:plaintiffWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Zivilkläger "</para><para>"Plaintiff (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/plaintiffWork">http://rdvocab.info/roles/plaintiffWork</seealso>
    let plaintiffWork = Prefixed_Name(rdarole, "plaintiffWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:platemaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Druckformhersteller "</para><para>"Platemaker"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/platemaker">http://rdvocab.info/roles/platemaker</seealso>
    let platemaker = Prefixed_Name(rdarole, "platemaker") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:platemakerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Druckformhersteller (Manifestation)"</para><para>"Platemaker (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/platemakerManifestation">http://rdvocab.info/roles/platemakerManifestation</seealso>
    let platemakerManifestation =
        Prefixed_Name(rdarole, "platemakerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:praeses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Disputationsleiter "</para><para>"Praeses"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/praeses">http://rdvocab.info/roles/praeses</seealso>
    let praeses = Prefixed_Name(rdarole, "praeses") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:praesesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Disputationsleiter (Werk)"</para><para>"Praeses (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/praesesWork">http://rdvocab.info/roles/praesesWork</seealso>
    let praesesWork = Prefixed_Name(rdarole, "praesesWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:presenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Presenter"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/presenter">http://rdvocab.info/roles/presenter</seealso>
    let presenter = Prefixed_Name(rdarole, "presenter") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:presenterExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Presenter (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/presenterExpression">http://rdvocab.info/roles/presenterExpression</seealso>
    let presenterExpression =
        Prefixed_Name(rdarole, "presenterExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:printer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Printer"</para><para>"Drucker "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/printer">http://rdvocab.info/roles/printer</seealso>
    let printer = Prefixed_Name(rdarole, "printer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:printerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Drucker (Manifestation)"</para><para>"Printer (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/printerManifestation">http://rdvocab.info/roles/printerManifestation</seealso>
    let printerManifestation =
        Prefixed_Name(rdarole, "printerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:printmaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Druckgrafiker "</para><para>"Printmaker"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/printmaker">http://rdvocab.info/roles/printmaker</seealso>
    let printmaker = Prefixed_Name(rdarole, "printmaker") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:printmakerManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Printmaker (Manifestation)"</para><para>"Druckgrafiker (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/printmakerManifestation">http://rdvocab.info/roles/printmakerManifestation</seealso>
    let printmakerManifestation =
        Prefixed_Name(rdarole, "printmakerManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Producer"</para><para>"Produzent "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/producer">http://rdvocab.info/roles/producer</seealso>
    let producer = Prefixed_Name(rdarole, "producer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:producerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Producer (Work)"</para><para>"Produzent (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/producerWork">http://rdvocab.info/roles/producerWork</seealso>
    let producerWork = Prefixed_Name(rdarole, "producerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:productionCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Production company"</para><para>"Produktionsunternehmen"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/productionCompany">http://rdvocab.info/roles/productionCompany</seealso>
    let productionCompany = Prefixed_Name(rdarole, "productionCompany") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:productionCompanyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Production company (Work)"</para><para>"Produktionsunternehmen (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/productionCompanyWork">http://rdvocab.info/roles/productionCompanyWork</seealso>
    let productionCompanyWork =
        Prefixed_Name(rdarole, "productionCompanyWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:productionDesigner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Production Designer "</para><para>"Production designer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/productionDesigner">http://rdvocab.info/roles/productionDesigner</seealso>
    let productionDesigner =
        Prefixed_Name(rdarole, "productionDesigner") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:productionDesignerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Production designer (Expression)"</para><para>"Production Designer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/productionDesignerExpression">http://rdvocab.info/roles/productionDesignerExpression</seealso>
    let productionDesignerExpression =
        Prefixed_Name(rdarole, "productionDesignerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:programmer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Programmierer "</para><para>"Programmer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/programmer">http://rdvocab.info/roles/programmer</seealso>
    let programmer = Prefixed_Name(rdarole, "programmer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:programmerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Programmierer (Werk)"</para><para>"Programmer (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/programmerWork">http://rdvocab.info/roles/programmerWork</seealso>
    let programmerWork = Prefixed_Name(rdarole, "programmerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Publisher "</para><para>"Verlag"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/publisher">http://rdvocab.info/roles/publisher</seealso>
    let publisher = Prefixed_Name(rdarole, "publisher") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:publisherManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Publisher (Manifestation)"</para><para>"Verlag (Manifestation)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/publisherManifestation">http://rdvocab.info/roles/publisherManifestation</seealso>
    let publisherManifestation =
        Prefixed_Name(rdarole, "publisherManifestation") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:puppeteer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Puppeteer"</para><para>"Puppenspieler "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/puppeteer">http://rdvocab.info/roles/puppeteer</seealso>
    let puppeteer = Prefixed_Name(rdarole, "puppeteer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:puppeteerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Puppeteer (Expression)"</para><para>"Puppenspieler (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/puppeteerExpression">http://rdvocab.info/roles/puppeteerExpression</seealso>
    let puppeteerExpression =
        Prefixed_Name(rdarole, "puppeteerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:radioDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio director"</para><para>"Hörfunkintendant "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/radioDirector">http://rdvocab.info/roles/radioDirector</seealso>
    let radioDirector = Prefixed_Name(rdarole, "radioDirector") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:radioDirectorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio director (Work)"</para><para>"Hörfunkintendant (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/radioDirectorWork">http://rdvocab.info/roles/radioDirectorWork</seealso>
    let radioDirectorWork = Prefixed_Name(rdarole, "radioDirectorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:radioProducer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio producer"</para><para>"Hörfunkproduzent "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/radioProducer">http://rdvocab.info/roles/radioProducer</seealso>
    let radioProducer = Prefixed_Name(rdarole, "radioProducer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:radioProducerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Radio producer (Work)"</para><para>"Hörfunkproduzent (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/radioProducerWork">http://rdvocab.info/roles/radioProducerWork</seealso>
    let radioProducerWork = Prefixed_Name(rdarole, "radioProducerWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:recordingEngineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Recording engineer"</para><para>"Toningenieur "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/recordingEngineer">http://rdvocab.info/roles/recordingEngineer</seealso>
    let recordingEngineer = Prefixed_Name(rdarole, "recordingEngineer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:recordingEngineerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Toningenieur (Expression)"</para><para>"Recording engineer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/recordingEngineerExpression">http://rdvocab.info/roles/recordingEngineerExpression</seealso>
    let recordingEngineerExpression =
        Prefixed_Name(rdarole, "recordingEngineerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:recordist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Recordist "</para><para>"Recordist"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/recordist">http://rdvocab.info/roles/recordist</seealso>
    let recordist = Prefixed_Name(rdarole, "recordist") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:recordistExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Recordist (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/recordistExpression">http://rdvocab.info/roles/recordistExpression</seealso>
    let recordistExpression =
        Prefixed_Name(rdarole, "recordistExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:respondent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Respondent "</para><para>"Respondent"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/respondent">http://rdvocab.info/roles/respondent</seealso>
    let respondent = Prefixed_Name(rdarole, "respondent") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:respondentWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Respondent (Werk)"</para><para>"Respondent (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/respondentWork">http://rdvocab.info/roles/respondentWork</seealso>
    let respondentWork = Prefixed_Name(rdarole, "respondentWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:restorationist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Restorationist"</para><para>"Restaurator "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/restorationist">http://rdvocab.info/roles/restorationist</seealso>
    let restorationist = Prefixed_Name(rdarole, "restorationist") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:restorationistItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Restorationist (Item)"</para><para>"Restaurator"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/restorationistItem">http://rdvocab.info/roles/restorationistItem</seealso>
    let restorationistItem =
        Prefixed_Name(rdarole, "restorationistItem") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:screenwriter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Drehbuchautor "</para><para>"Screenwriter"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/screenwriter">http://rdvocab.info/roles/screenwriter</seealso>
    let screenwriter = Prefixed_Name(rdarole, "screenwriter") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:screenwriterWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Drehbuchautor (Werk)"</para><para>"Screenwriter (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/screenwriterWork">http://rdvocab.info/roles/screenwriterWork</seealso>
    let screenwriterWork = Prefixed_Name(rdarole, "screenwriterWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:sculptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sculptor"</para><para>"Bildhauer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/sculptor">http://rdvocab.info/roles/sculptor</seealso>
    let sculptor = Prefixed_Name(rdarole, "sculptor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:sculptorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sculptor (Work)"</para><para>"Bildhauer (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/sculptorWork">http://rdvocab.info/roles/sculptorWork</seealso>
    let sculptorWork = Prefixed_Name(rdarole, "sculptorWork") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:seller</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Seller"</para><para>"Verkäufer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/seller">http://rdvocab.info/roles/seller</seealso>
    let seller = Prefixed_Name(rdarole, "seller") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:sellerItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Seller (Item)"</para><para>"Verkäufer (Exemplar)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/sellerItem">http://rdvocab.info/roles/sellerItem</seealso>
    let sellerItem = Prefixed_Name(rdarole, "sellerItem") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sänger "</para><para>"Singer"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/singer">http://rdvocab.info/roles/singer</seealso>
    let singer = Prefixed_Name(rdarole, "singer") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:singerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Singer (Expression)"</para><para>"Sänger (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/singerExpression">http://rdvocab.info/roles/singerExpression</seealso>
    let singerExpression = Prefixed_Name(rdarole, "singerExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:speaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Speaker"</para><para>"Sprecher "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/speaker">http://rdvocab.info/roles/speaker</seealso>
    let speaker = Prefixed_Name(rdarole, "speaker") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:speakerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sprecher (Expression)"</para><para>"Speaker (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/speakerExpression">http://rdvocab.info/roles/speakerExpression</seealso>
    let speakerExpression = Prefixed_Name(rdarole, "speakerExpression") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:sponsoringBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sponsoring body"</para><para>"Sponsor "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/sponsoringBody">http://rdvocab.info/roles/sponsoringBody</seealso>
    let sponsoringBody = Prefixed_Name(rdarole, "sponsoringBody") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:sponsoringBodyWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Sponsor (Werk)"</para><para>"Sponsoring body (Work)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/sponsoringBodyWork">http://rdvocab.info/roles/sponsoringBodyWork</seealso>
    let sponsoringBodyWork =
        Prefixed_Name(rdarole, "sponsoringBodyWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:stageDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stage director"</para><para>"Theaterregisseur "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/stageDirector">http://rdvocab.info/roles/stageDirector</seealso>
    let stageDirector = Prefixed_Name(rdarole, "stageDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:stageDirectorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Stage director (Expression)"</para><para>"Theaterregisseur "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/stageDirectorExpression">http://rdvocab.info/roles/stageDirectorExpression</seealso>
    let stageDirectorExpression =
        Prefixed_Name(rdarole, "stageDirectorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:storyteller</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Storyteller"</para><para>"Geschichtenerzähler "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/storyteller">http://rdvocab.info/roles/storyteller</seealso>
    let storyteller = Prefixed_Name(rdarole, "storyteller") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:storytellerExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Storyteller (Expression)"</para><para>"Geschichtenerzähler (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/storytellerExpression">http://rdvocab.info/roles/storytellerExpression</seealso>
    let storytellerExpression =
        Prefixed_Name(rdarole, "storytellerExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:surveyor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Surveyor"</para><para>"Vermesser "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/surveyor">http://rdvocab.info/roles/surveyor</seealso>
    let surveyor = Prefixed_Name(rdarole, "surveyor") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:surveyorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Vermesser (Expression)"</para><para>"Surveyor (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/surveyorExpression">http://rdvocab.info/roles/surveyorExpression</seealso>
    let surveyorExpression =
        Prefixed_Name(rdarole, "surveyorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:teacher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Lehrer "</para><para>"Teacher"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/teacher">http://rdvocab.info/roles/teacher</seealso>
    let teacher = Prefixed_Name(rdarole, "teacher") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:teacherExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Teacher (Expression)"</para><para>"Lehrer (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/teacherExpression">http://rdvocab.info/roles/teacherExpression</seealso>
    let teacherExpression = Prefixed_Name(rdarole, "teacherExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:televisionDirector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Fernsehintendant "</para><para>"Television director"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/televisionDirector">http://rdvocab.info/roles/televisionDirector</seealso>
    let televisionDirector =
        Prefixed_Name(rdarole, "televisionDirector") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:televisionDirectorWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Television director (Work)"</para><para>"Fernsehintendant (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/televisionDirectorWork">http://rdvocab.info/roles/televisionDirectorWork</seealso>
    let televisionDirectorWork =
        Prefixed_Name(rdarole, "televisionDirectorWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:televisionProducer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Television producer"</para><para>"Fernsehproduzent "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/televisionProducer">http://rdvocab.info/roles/televisionProducer</seealso>
    let televisionProducer =
        Prefixed_Name(rdarole, "televisionProducer") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:televisionProducerWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Television producer (Work)"</para><para>"Fernsehproduzent (Werk)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/televisionProducerWork">http://rdvocab.info/roles/televisionProducerWork</seealso>
    let televisionProducerWork =
        Prefixed_Name(rdarole, "televisionProducerWork") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:thesisAdvisor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Thesis Advisor"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/thesisAdvisor">http://rdvocab.info/roles/thesisAdvisor</seealso>
    let thesisAdvisor = Prefixed_Name(rdarole, "thesisAdvisor") |> PrefixedName
    /// <summary>
    ///   <para>rdarole:transcriber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Transkribierer "</para><para>"Transcriber"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/transcriber">http://rdvocab.info/roles/transcriber</seealso>
    let transcriber = Prefixed_Name(rdarole, "transcriber") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:transcriberExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Transkribierer (Expression)"</para><para>"Transcriber (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/transcriberExpression">http://rdvocab.info/roles/transcriberExpression</seealso>
    let transcriberExpression =
        Prefixed_Name(rdarole, "transcriberExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Translator"</para><para>"Übersetzer "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/translator">http://rdvocab.info/roles/translator</seealso>
    let translator = Prefixed_Name(rdarole, "translator") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:translatorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Übersetzer (Expression)"</para><para>"Translator (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/translatorExpression">http://rdvocab.info/roles/translatorExpression</seealso>
    let translatorExpression =
        Prefixed_Name(rdarole, "translatorExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedCommentary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Writer of added commentary"</para><para>"Kommentator (schriftlich) "</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedCommentary">http://rdvocab.info/roles/writerOfAddedCommentary</seealso>
    let writerOfAddedCommentary =
        Prefixed_Name(rdarole, "writerOfAddedCommentary") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedCommentaryExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Writer of added commentary (Expression)"</para><para>"Kommentator (schriftlich) (Eypression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedCommentaryExpression">http://rdvocab.info/roles/writerOfAddedCommentaryExpression</seealso>
    let writerOfAddedCommentaryExpression =
        Prefixed_Name(rdarole, "writerOfAddedCommentaryExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedLyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Verfasser eines Textes, der nachträglich einem Musikwerk unterlegt wird "</para><para>"Writer of added lyrics"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedLyrics">http://rdvocab.info/roles/writerOfAddedLyrics</seealso>
    let writerOfAddedLyrics =
        Prefixed_Name(rdarole, "writerOfAddedLyrics") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedLyricsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Verfasser eines Textes, der nachträglich einem Musikwerk unterlegt wird (Expression)."</para><para>"Writer of added lyrics (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedLyricsExpression">http://rdvocab.info/roles/writerOfAddedLyricsExpression</seealso>
    let writerOfAddedLyricsExpression =
        Prefixed_Name(rdarole, "writerOfAddedLyricsExpression") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedText</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Verfasser von Zusatztexten "</para><para>"Writer of added text"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedText">http://rdvocab.info/roles/writerOfAddedText</seealso>
    let writerOfAddedText = Prefixed_Name(rdarole, "writerOfAddedText") |> PrefixedName

    /// <summary>
    ///   <para>rdarole:writerOfAddedTextExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Verfasser von Zusatztexten (Expression)"</para><para>"Writer of added text (Expression)"</para></remarks>
    /// <seealso href="http://rdvocab.info/roles/writerOfAddedTextExpression">http://rdvocab.info/roles/writerOfAddedTextExpression</seealso>
    let writerOfAddedTextExpression =
        Prefixed_Name(rdarole, "writerOfAddedTextExpression") |> PrefixedName

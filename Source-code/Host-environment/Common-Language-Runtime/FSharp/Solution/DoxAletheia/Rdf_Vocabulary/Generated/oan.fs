namespace http.data.lirmm.fr.ontologies.oan.slash

open DoxAletheia.Rdf_Vocabulary

module oan =
    let _namespace_name = "http://data.lirmm.fr/ontologies/oan/"
    /// <summary>
    /// La classe "Alinea" représente les différents alinéas qui sont contenus dans un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Alinea"></see></summary>
    let Alinea = Namespaced_IRI.parse _namespace_name "Alinea" |> NamespacedName
    /// <summary>
    /// La classe "Presence" représente la présence d'un député lors d'une commission ou d'une session de l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Presence"></see></summary>
    let Presence = Namespaced_IRI.parse _namespace_name "Presence" |> NamespacedName

    /// <summary>
    /// La classe "PreuvePresence" représente les différentes types de preuves qu'il est possible d'avoir afin de prouver la présence d'un député à une commission ou à une session de l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/PreuvePresence"></see></summary>
    let PreuvePresence =
        Namespaced_IRI.parse _namespace_name "PreuvePresence" |> NamespacedName

    /// <summary>
    /// La classe "PositionArticle" indique dans quel partie du texte de loi est contenu l'article correspondant.
    /// <see href="http://data.lirmm.fr/ontologies/oan/PositionArticle"></see></summary>
    let PositionArticle =
        Namespaced_IRI.parse _namespace_name "PositionArticle" |> NamespacedName

    /// <summary>
    /// La classe "Reponse" représente la réponse des ministres aux différentes questions écrites émises par les députés.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Reponse"></see></summary>
    let Reponse = Namespaced_IRI.parse _namespace_name "Reponse" |> NamespacedName
    /// <summary>
    /// La classe "Article" représente les différents articles qui peuvent être contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    /// La classe "Depute" sert à représenter la notion de député siégeant à l'assemblée nationale. Un député est un représentant auprès de l'assemblée nationale élu par le peuple.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Depute"></see></summary>
    let Depute = Namespaced_IRI.parse _namespace_name "Depute" |> NamespacedName
    /// <summary>
    /// La classe "Organisme" représente les différents organismes possibles auxquels un député peut appartenir.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Organisme"></see></summary>
    let Organisme = Namespaced_IRI.parse _namespace_name "Organisme" |> NamespacedName
    /// <summary>
    /// La classe "Amendement" sert à représenter la notion d'amendement. Un amendement est une demande de modification d'une loi existante.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Amendement"></see></summary>
    let Amendement = Namespaced_IRI.parse _namespace_name "Amendement" |> NamespacedName
    /// <summary>
    /// La classe "Mandat" représente les différents mandats qu'il est possible d'avoir pour un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Mandat"></see></summary>
    let Mandat = Namespaced_IRI.parse _namespace_name "Mandat" |> NamespacedName
    /// <summary>
    /// La classe "Rapport" sert à représenter la notion de rapport écrit par les députés lors de commission ou d'hémicycle. Un rapport est établi dans le but de proposer des solutions à un problème.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Rapport"></see></summary>
    let Rapport = Namespaced_IRI.parse _namespace_name "Rapport" |> NamespacedName

    /// <summary>
    /// La classe "QuestionEcrite" représente les différentes question qui sont écrites par un député pour les ministres du gouvernements.
    /// <see href="http://data.lirmm.fr/ontologies/oan/QuestionEcrite"></see></summary>
    let QuestionEcrite =
        Namespaced_IRI.parse _namespace_name "QuestionEcrite" |> NamespacedName

    /// <summary>
    /// La classe "Loi" sert à représenter la notion de loi établi par les députés lors de différents hémicycles. Une loi est une règle juridique défini lors de différents rassemblements de l'assemblée nationale par les députés et les membres du gouvernements. Un projet de loi émane d'un membre du grouvernement et une proposition de loi émane d'un parlementaire.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Loi"></see></summary>
    let Loi = Namespaced_IRI.parse _namespace_name "Loi" |> NamespacedName
    /// <summary>
    /// La classe "Chapitre" représente les différents chapitres contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Chapitre"></see></summary>
    let Chapitre = Namespaced_IRI.parse _namespace_name "Chapitre" |> NamespacedName

    /// <summary>
    /// La classe "SousSection" représente les sous sections contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/SousSection"></see></summary>
    let SousSection =
        Namespaced_IRI.parse _namespace_name "SousSection" |> NamespacedName

    /// <summary>
    /// La classe "Section" représente les différentes sections contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Section"></see></summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName
    /// <summary>
    /// La classe "Seance" représente les différents rassemblements auxquels un député assiste. Ces rassemblements sont généralements les sessions de l'assemblée nationale et les commissions.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Seance"></see></summary>
    let Seance = Namespaced_IRI.parse _namespace_name "Seance" |> NamespacedName

    /// <summary>
    /// La classe "Intervention" représente l'intervention d'un député lors d'un rassemblement à l'assemblée nationale ou bien lors d'une commission.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// La classe "TexteLoi" représente le texte contenu dans une loi. Pour plus de détails voir la classe "Loi".
    /// <see href="http://data.lirmm.fr/ontologies/oan/TexteLoi"></see></summary>
    let TexteLoi = Namespaced_IRI.parse _namespace_name "TexteLoi" |> NamespacedName

    /// <summary>
    /// La propriété "aPourMandat" représente le mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourMandat"></see></summary>
    let aPourMandat =
        Namespaced_IRI.parse _namespace_name "aPourMandat" |> NamespacedName

    /// <summary>
    /// Désigne le parti du député correspondant.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourParti"></see></summary>
    let aPourParti = Namespaced_IRI.parse _namespace_name "aPourParti" |> NamespacedName
    /// <summary>
    /// La propriété "aPourTexte" représente la loi correspondant au texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourTexte"></see></summary>
    let aPourTexte = Namespaced_IRI.parse _namespace_name "aPourTexte" |> NamespacedName

    /// <summary>
    /// La propriété "alineaNumero" représente le numéro d'un alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/alineaNumero"></see></summary>
    let alineaNumero =
        Namespaced_IRI.parse _namespace_name "alineaNumero" |> NamespacedName

    /// <summary>
    /// La propriété "amendementConcerne" représente l'article pour lequel a été créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementConcerne"></see></summary>
    let amendementConcerne =
        Namespaced_IRI.parse _namespace_name "amendementConcerne" |> NamespacedName

    /// <summary>
    /// La propriété "amendementCorrespond" représente le texte de loi correspondant à un amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementCorrespond"></see></summary>
    let amendementCorrespond =
        Namespaced_IRI.parse _namespace_name "amendementCorrespond" |> NamespacedName

    /// <summary>
    /// La propriété "amendementNbFoisRectifier" représente le nombre de fois qu'un amendement a été rectifier par l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementNbFoisRectifier"></see></summary>
    let amendementNbFoisRectifier =
        Namespaced_IRI.parse _namespace_name "amendementNbFoisRectifier" |> NamespacedName

    /// <summary>
    /// La propriétté "appartientOrganisme" représente l'organisme auquel appartient un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/appartientOrganisme"></see></summary>
    let appartientOrganisme =
        Namespaced_IRI.parse _namespace_name "appartientOrganisme" |> NamespacedName

    /// <summary>
    /// La propriété "articleCorrespond" représente l'article correspondant à une loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/articleCorrespond"></see></summary>
    let articleCorrespond =
        Namespaced_IRI.parse _namespace_name "articleCorrespond" |> NamespacedName

    /// <summary>
    /// La propriété "articleCorrespondant" représente l'article correspondant à l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/articleCorrespondant"></see></summary>
    let articleCorrespondant =
        Namespaced_IRI.parse _namespace_name "articleCorrespondant" |> NamespacedName

    /// <summary>
    /// La propriété "auteurAmendement" représente le député qui est l'origine de l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/auteurAmendement"></see></summary>
    let auteurAmendement =
        Namespaced_IRI.parse _namespace_name "auteurAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "auteurRapport" représente le député qui est l'auteur du rapport.
    /// <see href="http://data.lirmm.fr/ontologies/oan/auteurRapport"></see></summary>
    let auteurRapport =
        Namespaced_IRI.parse _namespace_name "auteurRapport" |> NamespacedName

    /// <summary>
    /// La propriété "chapitreContient" représente les différentes sections qui sont contenus dans un chapitre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/chapitreContient"></see></summary>
    let chapitreContient =
        Namespaced_IRI.parse _namespace_name "chapitreContient" |> NamespacedName

    /// <summary>
    /// La propriété "dansChapitre" indique dans quel chapitre du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansChapitre"></see></summary>
    let dansChapitre =
        Namespaced_IRI.parse _namespace_name "dansChapitre" |> NamespacedName

    /// <summary>
    /// La propriété "dansSection" indique dans quel section du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansSection"></see></summary>
    let dansSection =
        Namespaced_IRI.parse _namespace_name "dansSection" |> NamespacedName

    /// <summary>
    /// La propriété "dansSousSection" indique dans quel sous section du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansSousSection"></see></summary>
    let dansSousSection =
        Namespaced_IRI.parse _namespace_name "dansSousSection" |> NamespacedName

    /// <summary>
    /// La propriété "dansTexte" indique dans quelle partie du texte de loi se trouve l'article. Car il est possible qu'un article ne soit contenu ni dans un chapitre, ni dans une section et ni dans une sous section, il est alors en général en tout début du texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansTexte"></see></summary>
    let dansTexte = Namespaced_IRI.parse _namespace_name "dansTexte" |> NamespacedName

    /// <summary>
    /// La propriété "dateCreationAmendement" représente la date à laquelle est créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateCreationAmendement"></see></summary>
    let dateCreationAmendement =
        Namespaced_IRI.parse _namespace_name "dateCreationAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "dateEcriture" représente la date à laquelle a été émise la question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateEcriture"></see></summary>
    let dateEcriture =
        Namespaced_IRI.parse _namespace_name "dateEcriture" |> NamespacedName

    /// <summary>
    /// La propriété "dateIntervention" représente la date à laquelle est faite l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateIntervention"></see></summary>
    let dateIntervention =
        Namespaced_IRI.parse _namespace_name "dateIntervention" |> NamespacedName

    /// <summary>
    /// La propriété "datePresence" représente la date à laquelle a été faite la présence.
    /// <see href="http://data.lirmm.fr/ontologies/oan/datePresence"></see></summary>
    let datePresence =
        Namespaced_IRI.parse _namespace_name "datePresence" |> NamespacedName

    /// <summary>
    /// La propriété "dateRapport" représente la date à laquel le rapport a été créé.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateRapport"></see></summary>
    let dateRapport =
        Namespaced_IRI.parse _namespace_name "dateRapport" |> NamespacedName

    /// <summary>
    /// La propriété "dateReponse" représente la data à laquelle a été émise la réponse à une question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateReponse"></see></summary>
    let dateReponse =
        Namespaced_IRI.parse _namespace_name "dateReponse" |> NamespacedName

    /// <summary>
    /// La propriété "dateSeance" représente la date à laquelle à lieu une séance d'un quelconque organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateSeance"></see></summary>
    let dateSeance = Namespaced_IRI.parse _namespace_name "dateSeance" |> NamespacedName

    /// <summary>
    /// La propriété "debutMandat" représente le début du mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/debutMandat"></see></summary>
    let debutMandat =
        Namespaced_IRI.parse _namespace_name "debutMandat" |> NamespacedName

    /// <summary>
    /// La propriété "deputecorrespondant" représente la présence d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/deputeCorrespondant"></see></summary>
    let deputeCorrespondant =
        Namespaced_IRI.parse _namespace_name "deputeCorrespondant" |> NamespacedName

    /// <summary>
    /// La propriété "deputeIntervenant" représente le député qui est l'auteur de l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/deputeIntervenant"></see></summary>
    let deputeIntervenant =
        Namespaced_IRI.parse _namespace_name "deputeIntervenant" |> NamespacedName

    /// <summary>
    /// La propriété "estEcrite" représente le député qui a écrit cette question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/estEcrite"></see></summary>
    let estEcrite = Namespaced_IRI.parse _namespace_name "estEcrite" |> NamespacedName

    /// <summary>
    /// La propriété "exposeAmendement" représente un petit texte résumé de cet amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/exposeAmendement"></see></summary>
    let exposeAmendement =
        Namespaced_IRI.parse _namespace_name "exposeAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "exposeArticle" représente un petit résumé de l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/exposeArticle"></see></summary>
    let exposeArticle =
        Namespaced_IRI.parse _namespace_name "exposeArticle" |> NamespacedName

    /// <summary>
    /// La propriété "finMandat" représente la fin du mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/finMandat"></see></summary>
    let finMandat = Namespaced_IRI.parse _namespace_name "finMandat" |> NamespacedName

    /// <summary>
    /// La propriété "fonctionIntervenant" représente la fonction du député qui intervient durant une séance d'un quelconque organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/fonctionIntervenant"></see></summary>
    let fonctionIntervenant =
        Namespaced_IRI.parse _namespace_name "fonctionIntervenant" |> NamespacedName

    /// <summary>
    /// La propriété "heureDebutSeance" représente l'heure à laquelle débute une séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/heureDebutSeance"></see></summary>
    let heureDebutSeance =
        Namespaced_IRI.parse _namespace_name "heureDebutSeance" |> NamespacedName

    /// <summary>
    /// La propriété "intervientLors" représente l'intervention d'un député qui survient lors d'une séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/intervientLors"></see></summary>
    let intervientLors =
        Namespaced_IRI.parse _namespace_name "intervientLors" |> NamespacedName

    /// <summary>
    /// La propriété "legislatureAmendement" représente la législature sous laquelle a été créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/legislatureAmendement"></see></summary>
    let legislatureAmendement =
        Namespaced_IRI.parse _namespace_name "legislatureAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "legislatureQuestion" représente la législature sous laquelle la question écrite à été émise.
    /// <see href="http://data.lirmm.fr/ontologies/oan/legislatureQuestion"></see></summary>
    let legislatureQuestion =
        Namespaced_IRI.parse _namespace_name "legislatureQuestion" |> NamespacedName

    /// <summary>
    /// La propriété "loiCorrespondante" indique à quelle loi est rataché l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/loiCorrespondante"></see></summary>
    let loiCorrespondante =
        Namespaced_IRI.parse _namespace_name "loiCorrespondante" |> NamespacedName

    /// <summary>
    /// La propriété "metier" représente le métier du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.
    /// <see href="http://data.lirmm.fr/ontologies/oan/metier"></see></summary>
    let metier = Namespaced_IRI.parse _namespace_name "metier" |> NamespacedName

    /// <summary>
    /// La propriété "motifRetrait" représente le motif pour lequel la question écrite a été supprimé.
    /// <see href="http://data.lirmm.fr/ontologies/oan/motifRetrait"></see></summary>
    let motifRetrait =
        Namespaced_IRI.parse _namespace_name "motifRetrait" |> NamespacedName

    /// <summary>
    /// La propriété "nbIntervention" représente le nombre d'interventions qu'il y a eu pour une section.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbIntervention"></see></summary>
    let nbIntervention =
        Namespaced_IRI.parse _namespace_name "nbIntervention" |> NamespacedName

    /// <summary>
    /// La propriété "nbMots" représente le nombre de mots que contient l'intervention d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbMots"></see></summary>
    let nbMots = Namespaced_IRI.parse _namespace_name "nbMots" |> NamespacedName

    /// <summary>
    /// La propriété "nbPreuvesPresence" représente le nombre de preuves d'une présence que peut avoir un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbPreuvesPresence"></see></summary>
    let nbPreuvesPresence =
        Namespaced_IRI.parse _namespace_name "nbPreuvesPresence" |> NamespacedName

    /// <summary>
    /// La propriété "nomMandat" représente le nom du mandat que peut avoir un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nomMandat"></see></summary>
    let nomMandat = Namespaced_IRI.parse _namespace_name "nomMandat" |> NamespacedName

    /// <summary>
    /// La propriété "nomOrganisme" représente le nom d'un organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nomOrganisme"></see></summary>
    let nomOrganisme =
        Namespaced_IRI.parse _namespace_name "nomOrganisme" |> NamespacedName

    /// <summary>
    /// La propriété "numCirco" représente le numéro de la circonscription dont le député est responsable.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numCirco"></see></summary>
    let numCirco = Namespaced_IRI.parse _namespace_name "numCirco" |> NamespacedName

    /// <summary>
    /// La propriété "numeroAmendement" représente le numéro donné à un amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroAmendement"></see></summary>
    let numeroAmendement =
        Namespaced_IRI.parse _namespace_name "numeroAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "numeroArticle" représente le numéro d'un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroArticle"></see></summary>
    let numeroArticle =
        Namespaced_IRI.parse _namespace_name "numeroArticle" |> NamespacedName

    /// <summary>
    /// La propriété "numeorQuestion" représente le numéro de la question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroQuestion"></see></summary>
    let numeroQuestion =
        Namespaced_IRI.parse _namespace_name "numeroQuestion" |> NamespacedName

    /// <summary>
    /// La propriété "numeroRapport" représente le numéro donné au rapport par les différents organismes qu'il concerne.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroRapport"></see></summary>
    let numeroRapport =
        Namespaced_IRI.parse _namespace_name "numeroRapport" |> NamespacedName

    /// <summary>
    /// La propriété "numeroSemaineSeance" représente le numéro de la semaine à laquelle à lieu la séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroSemaineSeance"></see></summary>
    let numeroSemaineSeance =
        Namespaced_IRI.parse _namespace_name "numeroSemaineSeance" |> NamespacedName

    /// <summary>
    /// La propriété "placeHemicycle" représente le numéro de la place qu'occupe le député à l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/placeHemicycle"></see></summary>
    let placeHemicycle =
        Namespaced_IRI.parse _namespace_name "placeHemicycle" |> NamespacedName

    /// <summary>
    /// La propriété "positionDans" représente la position de l'article dans un texte de loi, c'est-à-dire si il est dans une sous section, dans une section, dans un chapitre ou dans le texte tout court.
    /// <see href="http://data.lirmm.fr/ontologies/oan/positionDans"></see></summary>
    let positionDans =
        Namespaced_IRI.parse _namespace_name "positionDans" |> NamespacedName

    /// <summary>
    /// La propriété "pourMinistere" représente le nom du ministère pour lequel la lettre a été écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/pourMinistere"></see></summary>
    let pourMinistere =
        Namespaced_IRI.parse _namespace_name "pourMinistere" |> NamespacedName

    /// <summary>
    /// La propriété "presenceCorrespondante" représente la preuve d'une présence d'un député à une séance à la présence à cette séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/presenceCorrespondante"></see></summary>
    let presenceCorrespondante =
        Namespaced_IRI.parse _namespace_name "presenceCorrespondante" |> NamespacedName

    /// <summary>
    /// La propriété "reponseCorrespondante" représente la réponse écrite à une question écrite émise par un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/reponseCorrespondante"></see></summary>
    let reponseCorrespondante =
        Namespaced_IRI.parse _namespace_name "reponseCorrespondante" |> NamespacedName

    /// <summary>
    /// la propriété "seanceAppartient" représente la séance d'un organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceAppartient"></see></summary>
    let seanceAppartient =
        Namespaced_IRI.parse _namespace_name "seanceAppartient" |> NamespacedName

    /// <summary>
    /// La propriété "seanceCorrespondante" représente la présence d'un député correspondant à une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceCorrespondante"></see></summary>
    let seanceCorrespondante =
        Namespaced_IRI.parse _namespace_name "seanceCorrespondante" |> NamespacedName

    /// <summary>
    /// La propriété "seanceProduit" représente les différents rapports qui sont produit lors d'une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceProduit"></see></summary>
    let seanceProduit =
        Namespaced_IRI.parse _namespace_name "seanceProduit" |> NamespacedName

    /// <summary>
    /// La propriété "sectionContien" représente les différentes sous sections qui sont contenus dans une section.
    /// <see href="http://data.lirmm.fr/ontologies/oan/sectionContient"></see></summary>
    let sectionContient =
        Namespaced_IRI.parse _namespace_name "sectionContient" |> NamespacedName

    /// <summary>
    /// La propriété "sexe" représente le sexe du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.
    /// <see href="http://data.lirmm.fr/ontologies/oan/sexe"></see></summary>
    let sexe = Namespaced_IRI.parse _namespace_name "sexe" |> NamespacedName

    /// <summary>
    /// La propriété "statutAmendement" représente les status que peut prendre un amendement durant sa période de discussion.
    /// <see href="http://data.lirmm.fr/ontologies/oan/statutAmendement"></see></summary>
    let statutAmendement =
        Namespaced_IRI.parse _namespace_name "statutAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "texteAlinea" représente le texte d'un alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteAlinea"></see></summary>
    let texteAlinea =
        Namespaced_IRI.parse _namespace_name "texteAlinea" |> NamespacedName

    /// <summary>
    /// La propriété "texteAmendement" représente le texte de l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteAmendement"></see></summary>
    let texteAmendement =
        Namespaced_IRI.parse _namespace_name "texteAmendement" |> NamespacedName

    /// <summary>
    /// La propriété "texteContient" représente les différents chapitres contenu dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteContient"></see></summary>
    let texteContient =
        Namespaced_IRI.parse _namespace_name "texteContient" |> NamespacedName

    /// <summary>
    /// La propriété "texteIntervention" représente le texte de l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteIntervention"></see></summary>
    let texteIntervention =
        Namespaced_IRI.parse _namespace_name "texteIntervention" |> NamespacedName

    /// <summary>
    /// La propriété "texteLoiCorrespondantAlinea" représente le texte de loi correspondant à l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantAlinea"></see></summary>
    let texteLoiCorrespondantAlinea =
        Namespaced_IRI.parse _namespace_name "texteLoiCorrespondantAlinea" |> NamespacedName

    /// <summary>
    /// La propriété "texteLoiCorrespondantArticle" représente l'article correspondant au texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantArticle"></see></summary>
    let texteLoiCorrespondantArticle =
        Namespaced_IRI.parse _namespace_name "texteLoiCorrespondantArticle" |> NamespacedName

    /// <summary>
    /// La propriété "texteQuestion" représente le texte de la question écrite émise par le député pour un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteQuestion"></see></summary>
    let texteQuestion =
        Namespaced_IRI.parse _namespace_name "texteQuestion" |> NamespacedName

    /// <summary>
    /// La propriété "texteReponse" représente le texte de la réponse à une question écrite émise par un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteReponse"></see></summary>
    let texteReponse =
        Namespaced_IRI.parse _namespace_name "texteReponse" |> NamespacedName

    /// <summary>
    /// La propriété "themeQuestion" représente le thème de la question écrite émise par le député pour un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/themeQuestion"></see></summary>
    let themeQuestion =
        Namespaced_IRI.parse _namespace_name "themeQuestion" |> NamespacedName

    /// <summary>
    /// La propriété "titreArticle" représente le titre d'un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreArticle"></see></summary>
    let titreArticle =
        Namespaced_IRI.parse _namespace_name "titreArticle" |> NamespacedName

    /// <summary>
    /// La propriété "titrechapitre" représente le titre d'un chapitre contenu dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreChapitre"></see></summary>
    let titreChapitre =
        Namespaced_IRI.parse _namespace_name "titreChapitre" |> NamespacedName

    /// <summary>
    /// La propriété "titreSection" représente le titre d'une section contenu dans un chapitre d'un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreSection"></see></summary>
    let titreSection =
        Namespaced_IRI.parse _namespace_name "titreSection" |> NamespacedName

    /// <summary>
    /// La propriété "titreSousSection" représente le titre d'une sous section contenu dans une section d'un chapitre d'un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreSousSection"></see></summary>
    let titreSousSection =
        Namespaced_IRI.parse _namespace_name "titreSousSection" |> NamespacedName

    /// <summary>
    /// La propriété "typeIntervention" représente les différents types d'intervention possible que peuvent faire les députés lors de divers séances d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeIntervention"></see></summary>
    let typeIntervention =
        Namespaced_IRI.parse _namespace_name "typeIntervention" |> NamespacedName

    /// <summary>
    /// La propriété "typeOrganisme" représente les différents types existant d'organismes.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeOrganisme"></see></summary>
    let typeOrganisme =
        Namespaced_IRI.parse _namespace_name "typeOrganisme" |> NamespacedName

    /// <summary>
    /// La propriété "typePreuve" représente le type d'une preuve de présence d'un député à une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typePreuve"></see></summary>
    let typePreuve = Namespaced_IRI.parse _namespace_name "typePreuve" |> NamespacedName
    /// <summary>
    /// La propriété "typeSeance" représente les différents types existant de séances.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeSeance"></see></summary>
    let typeSeance = Namespaced_IRI.parse _namespace_name "typeSeance" |> NamespacedName

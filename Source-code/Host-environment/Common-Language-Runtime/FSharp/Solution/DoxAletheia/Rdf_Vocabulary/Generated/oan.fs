namespace http.data.lirmm.fr.ontologies.oan.slash

open DoxAletheia

module oan =
    let _namespace_name = "http://data.lirmm.fr/ontologies/oan/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// La classe "Alinea" représente les différents alinéas qui sont contenus dans un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Alinea"></see></summary>
    let Alinea = _prefix "Alinea"
    /// <summary>
    /// La classe "Presence" représente la présence d'un député lors d'une commission ou d'une session de l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Presence"></see></summary>
    let Presence = _prefix "Presence"
    /// <summary>
    /// La classe "PreuvePresence" représente les différentes types de preuves qu'il est possible d'avoir afin de prouver la présence d'un député à une commission ou à une session de l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/PreuvePresence"></see></summary>
    let PreuvePresence = _prefix "PreuvePresence"
    /// <summary>
    /// La classe "PositionArticle" indique dans quel partie du texte de loi est contenu l'article correspondant.
    /// <see href="http://data.lirmm.fr/ontologies/oan/PositionArticle"></see></summary>
    let PositionArticle = _prefix "PositionArticle"
    /// <summary>
    /// La classe "Reponse" représente la réponse des ministres aux différentes questions écrites émises par les députés.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Reponse"></see></summary>
    let Reponse = _prefix "Reponse"
    /// <summary>
    /// La classe "Article" représente les différents articles qui peuvent être contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// La classe "Depute" sert à représenter la notion de député siégeant à l'assemblée nationale. Un député est un représentant auprès de l'assemblée nationale élu par le peuple.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Depute"></see></summary>
    let Depute = _prefix "Depute"
    /// <summary>
    /// La classe "Organisme" représente les différents organismes possibles auxquels un député peut appartenir.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Organisme"></see></summary>
    let Organisme = _prefix "Organisme"
    /// <summary>
    /// La classe "Amendement" sert à représenter la notion d'amendement. Un amendement est une demande de modification d'une loi existante.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Amendement"></see></summary>
    let Amendement = _prefix "Amendement"
    /// <summary>
    /// La classe "Mandat" représente les différents mandats qu'il est possible d'avoir pour un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Mandat"></see></summary>
    let Mandat = _prefix "Mandat"
    /// <summary>
    /// La classe "Rapport" sert à représenter la notion de rapport écrit par les députés lors de commission ou d'hémicycle. Un rapport est établi dans le but de proposer des solutions à un problème.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Rapport"></see></summary>
    let Rapport = _prefix "Rapport"
    /// <summary>
    /// La classe "QuestionEcrite" représente les différentes question qui sont écrites par un député pour les ministres du gouvernements.
    /// <see href="http://data.lirmm.fr/ontologies/oan/QuestionEcrite"></see></summary>
    let QuestionEcrite = _prefix "QuestionEcrite"
    /// <summary>
    /// La classe "Loi" sert à représenter la notion de loi établi par les députés lors de différents hémicycles. Une loi est une règle juridique défini lors de différents rassemblements de l'assemblée nationale par les députés et les membres du gouvernements. Un projet de loi émane d'un membre du grouvernement et une proposition de loi émane d'un parlementaire.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Loi"></see></summary>
    let Loi = _prefix "Loi"
    /// <summary>
    /// La classe "Chapitre" représente les différents chapitres contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Chapitre"></see></summary>
    let Chapitre = _prefix "Chapitre"
    /// <summary>
    /// La classe "SousSection" représente les sous sections contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/SousSection"></see></summary>
    let SousSection = _prefix "SousSection"
    /// <summary>
    /// La classe "Section" représente les différentes sections contenus dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// La classe "Seance" représente les différents rassemblements auxquels un député assiste. Ces rassemblements sont généralements les sessions de l'assemblée nationale et les commissions.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Seance"></see></summary>
    let Seance = _prefix "Seance"
    /// <summary>
    /// La classe "Intervention" représente l'intervention d'un député lors d'un rassemblement à l'assemblée nationale ou bien lors d'une commission.
    /// <see href="http://data.lirmm.fr/ontologies/oan/Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// La classe "TexteLoi" représente le texte contenu dans une loi. Pour plus de détails voir la classe "Loi".
    /// <see href="http://data.lirmm.fr/ontologies/oan/TexteLoi"></see></summary>
    let TexteLoi = _prefix "TexteLoi"
    /// <summary>
    /// La propriété "aPourMandat" représente le mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourMandat"></see></summary>
    let aPourMandat = _prefix "aPourMandat"
    /// <summary>
    /// Désigne le parti du député correspondant.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourParti"></see></summary>
    let aPourParti = _prefix "aPourParti"
    /// <summary>
    /// La propriété "aPourTexte" représente la loi correspondant au texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/aPourTexte"></see></summary>
    let aPourTexte = _prefix "aPourTexte"
    /// <summary>
    /// La propriété "alineaNumero" représente le numéro d'un alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/alineaNumero"></see></summary>
    let alineaNumero = _prefix "alineaNumero"
    /// <summary>
    /// La propriété "amendementConcerne" représente l'article pour lequel a été créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementConcerne"></see></summary>
    let amendementConcerne = _prefix "amendementConcerne"
    /// <summary>
    /// La propriété "amendementCorrespond" représente le texte de loi correspondant à un amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementCorrespond"></see></summary>
    let amendementCorrespond = _prefix "amendementCorrespond"
    /// <summary>
    /// La propriété "amendementNbFoisRectifier" représente le nombre de fois qu'un amendement a été rectifier par l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/amendementNbFoisRectifier"></see></summary>
    let amendementNbFoisRectifier = _prefix "amendementNbFoisRectifier"
    /// <summary>
    /// La propriétté "appartientOrganisme" représente l'organisme auquel appartient un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/appartientOrganisme"></see></summary>
    let appartientOrganisme = _prefix "appartientOrganisme"
    /// <summary>
    /// La propriété "articleCorrespond" représente l'article correspondant à une loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/articleCorrespond"></see></summary>
    let articleCorrespond = _prefix "articleCorrespond"
    /// <summary>
    /// La propriété "articleCorrespondant" représente l'article correspondant à l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/articleCorrespondant"></see></summary>
    let articleCorrespondant = _prefix "articleCorrespondant"
    /// <summary>
    /// La propriété "auteurAmendement" représente le député qui est l'origine de l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/auteurAmendement"></see></summary>
    let auteurAmendement = _prefix "auteurAmendement"
    /// <summary>
    /// La propriété "auteurRapport" représente le député qui est l'auteur du rapport.
    /// <see href="http://data.lirmm.fr/ontologies/oan/auteurRapport"></see></summary>
    let auteurRapport = _prefix "auteurRapport"
    /// <summary>
    /// La propriété "chapitreContient" représente les différentes sections qui sont contenus dans un chapitre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/chapitreContient"></see></summary>
    let chapitreContient = _prefix "chapitreContient"
    /// <summary>
    /// La propriété "dansChapitre" indique dans quel chapitre du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansChapitre"></see></summary>
    let dansChapitre = _prefix "dansChapitre"
    /// <summary>
    /// La propriété "dansSection" indique dans quel section du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansSection"></see></summary>
    let dansSection = _prefix "dansSection"
    /// <summary>
    /// La propriété "dansSousSection" indique dans quel sous section du texte de loi se trouve l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansSousSection"></see></summary>
    let dansSousSection = _prefix "dansSousSection"
    /// <summary>
    /// La propriété "dansTexte" indique dans quelle partie du texte de loi se trouve l'article. Car il est possible qu'un article ne soit contenu ni dans un chapitre, ni dans une section et ni dans une sous section, il est alors en général en tout début du texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dansTexte"></see></summary>
    let dansTexte = _prefix "dansTexte"
    /// <summary>
    /// La propriété "dateCreationAmendement" représente la date à laquelle est créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateCreationAmendement"></see></summary>
    let dateCreationAmendement = _prefix "dateCreationAmendement"
    /// <summary>
    /// La propriété "dateEcriture" représente la date à laquelle a été émise la question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateEcriture"></see></summary>
    let dateEcriture = _prefix "dateEcriture"
    /// <summary>
    /// La propriété "dateIntervention" représente la date à laquelle est faite l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateIntervention"></see></summary>
    let dateIntervention = _prefix "dateIntervention"
    /// <summary>
    /// La propriété "datePresence" représente la date à laquelle a été faite la présence.
    /// <see href="http://data.lirmm.fr/ontologies/oan/datePresence"></see></summary>
    let datePresence = _prefix "datePresence"
    /// <summary>
    /// La propriété "dateRapport" représente la date à laquel le rapport a été créé.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateRapport"></see></summary>
    let dateRapport = _prefix "dateRapport"
    /// <summary>
    /// La propriété "dateReponse" représente la data à laquelle a été émise la réponse à une question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateReponse"></see></summary>
    let dateReponse = _prefix "dateReponse"
    /// <summary>
    /// La propriété "dateSeance" représente la date à laquelle à lieu une séance d'un quelconque organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/dateSeance"></see></summary>
    let dateSeance = _prefix "dateSeance"
    /// <summary>
    /// La propriété "debutMandat" représente le début du mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/debutMandat"></see></summary>
    let debutMandat = _prefix "debutMandat"
    /// <summary>
    /// La propriété "deputecorrespondant" représente la présence d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/deputeCorrespondant"></see></summary>
    let deputeCorrespondant = _prefix "deputeCorrespondant"
    /// <summary>
    /// La propriété "deputeIntervenant" représente le député qui est l'auteur de l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/deputeIntervenant"></see></summary>
    let deputeIntervenant = _prefix "deputeIntervenant"
    /// <summary>
    /// La propriété "estEcrite" représente le député qui a écrit cette question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/estEcrite"></see></summary>
    let estEcrite = _prefix "estEcrite"
    /// <summary>
    /// La propriété "exposeAmendement" représente un petit texte résumé de cet amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/exposeAmendement"></see></summary>
    let exposeAmendement = _prefix "exposeAmendement"
    /// <summary>
    /// La propriété "exposeArticle" représente un petit résumé de l'article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/exposeArticle"></see></summary>
    let exposeArticle = _prefix "exposeArticle"
    /// <summary>
    /// La propriété "finMandat" représente la fin du mandat d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/finMandat"></see></summary>
    let finMandat = _prefix "finMandat"
    /// <summary>
    /// La propriété "fonctionIntervenant" représente la fonction du député qui intervient durant une séance d'un quelconque organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/fonctionIntervenant"></see></summary>
    let fonctionIntervenant = _prefix "fonctionIntervenant"
    /// <summary>
    /// La propriété "heureDebutSeance" représente l'heure à laquelle débute une séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/heureDebutSeance"></see></summary>
    let heureDebutSeance = _prefix "heureDebutSeance"
    /// <summary>
    /// La propriété "intervientLors" représente l'intervention d'un député qui survient lors d'une séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/intervientLors"></see></summary>
    let intervientLors = _prefix "intervientLors"
    /// <summary>
    /// La propriété "legislatureAmendement" représente la législature sous laquelle a été créé l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/legislatureAmendement"></see></summary>
    let legislatureAmendement = _prefix "legislatureAmendement"
    /// <summary>
    /// La propriété "legislatureQuestion" représente la législature sous laquelle la question écrite à été émise.
    /// <see href="http://data.lirmm.fr/ontologies/oan/legislatureQuestion"></see></summary>
    let legislatureQuestion = _prefix "legislatureQuestion"
    /// <summary>
    /// La propriété "loiCorrespondante" indique à quelle loi est rataché l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/loiCorrespondante"></see></summary>
    let loiCorrespondante = _prefix "loiCorrespondante"
    /// <summary>
    /// La propriété "metier" représente le métier du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.
    /// <see href="http://data.lirmm.fr/ontologies/oan/metier"></see></summary>
    let metier = _prefix "metier"
    /// <summary>
    /// La propriété "motifRetrait" représente le motif pour lequel la question écrite a été supprimé.
    /// <see href="http://data.lirmm.fr/ontologies/oan/motifRetrait"></see></summary>
    let motifRetrait = _prefix "motifRetrait"
    /// <summary>
    /// La propriété "nbIntervention" représente le nombre d'interventions qu'il y a eu pour une section.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbIntervention"></see></summary>
    let nbIntervention = _prefix "nbIntervention"
    /// <summary>
    /// La propriété "nbMots" représente le nombre de mots que contient l'intervention d'un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbMots"></see></summary>
    let nbMots = _prefix "nbMots"
    /// <summary>
    /// La propriété "nbPreuvesPresence" représente le nombre de preuves d'une présence que peut avoir un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nbPreuvesPresence"></see></summary>
    let nbPreuvesPresence = _prefix "nbPreuvesPresence"
    /// <summary>
    /// La propriété "nomMandat" représente le nom du mandat que peut avoir un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nomMandat"></see></summary>
    let nomMandat = _prefix "nomMandat"
    /// <summary>
    /// La propriété "nomOrganisme" représente le nom d'un organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/nomOrganisme"></see></summary>
    let nomOrganisme = _prefix "nomOrganisme"
    /// <summary>
    /// La propriété "numCirco" représente le numéro de la circonscription dont le député est responsable.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numCirco"></see></summary>
    let numCirco = _prefix "numCirco"
    /// <summary>
    /// La propriété "numeroAmendement" représente le numéro donné à un amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroAmendement"></see></summary>
    let numeroAmendement = _prefix "numeroAmendement"
    /// <summary>
    /// La propriété "numeroArticle" représente le numéro d'un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroArticle"></see></summary>
    let numeroArticle = _prefix "numeroArticle"
    /// <summary>
    /// La propriété "numeorQuestion" représente le numéro de la question écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroQuestion"></see></summary>
    let numeroQuestion = _prefix "numeroQuestion"
    /// <summary>
    /// La propriété "numeroRapport" représente le numéro donné au rapport par les différents organismes qu'il concerne.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroRapport"></see></summary>
    let numeroRapport = _prefix "numeroRapport"
    /// <summary>
    /// La propriété "numeroSemaineSeance" représente le numéro de la semaine à laquelle à lieu la séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/numeroSemaineSeance"></see></summary>
    let numeroSemaineSeance = _prefix "numeroSemaineSeance"
    /// <summary>
    /// La propriété "placeHemicycle" représente le numéro de la place qu'occupe le député à l'assemblée nationale.
    /// <see href="http://data.lirmm.fr/ontologies/oan/placeHemicycle"></see></summary>
    let placeHemicycle = _prefix "placeHemicycle"
    /// <summary>
    /// La propriété "positionDans" représente la position de l'article dans un texte de loi, c'est-à-dire si il est dans une sous section, dans une section, dans un chapitre ou dans le texte tout court.
    /// <see href="http://data.lirmm.fr/ontologies/oan/positionDans"></see></summary>
    let positionDans = _prefix "positionDans"
    /// <summary>
    /// La propriété "pourMinistere" représente le nom du ministère pour lequel la lettre a été écrite.
    /// <see href="http://data.lirmm.fr/ontologies/oan/pourMinistere"></see></summary>
    let pourMinistere = _prefix "pourMinistere"
    /// <summary>
    /// La propriété "presenceCorrespondante" représente la preuve d'une présence d'un député à une séance à la présence à cette séance.
    /// <see href="http://data.lirmm.fr/ontologies/oan/presenceCorrespondante"></see></summary>
    let presenceCorrespondante = _prefix "presenceCorrespondante"
    /// <summary>
    /// La propriété "reponseCorrespondante" représente la réponse écrite à une question écrite émise par un député.
    /// <see href="http://data.lirmm.fr/ontologies/oan/reponseCorrespondante"></see></summary>
    let reponseCorrespondante = _prefix "reponseCorrespondante"
    /// <summary>
    /// la propriété "seanceAppartient" représente la séance d'un organisme.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceAppartient"></see></summary>
    let seanceAppartient = _prefix "seanceAppartient"
    /// <summary>
    /// La propriété "seanceCorrespondante" représente la présence d'un député correspondant à une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceCorrespondante"></see></summary>
    let seanceCorrespondante = _prefix "seanceCorrespondante"
    /// <summary>
    /// La propriété "seanceProduit" représente les différents rapports qui sont produit lors d'une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/seanceProduit"></see></summary>
    let seanceProduit = _prefix "seanceProduit"
    /// <summary>
    /// La propriété "sectionContien" représente les différentes sous sections qui sont contenus dans une section.
    /// <see href="http://data.lirmm.fr/ontologies/oan/sectionContient"></see></summary>
    let sectionContient = _prefix "sectionContient"
    /// <summary>
    /// La propriété "sexe" représente le sexe du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.
    /// <see href="http://data.lirmm.fr/ontologies/oan/sexe"></see></summary>
    let sexe = _prefix "sexe"
    /// <summary>
    /// La propriété "statutAmendement" représente les status que peut prendre un amendement durant sa période de discussion.
    /// <see href="http://data.lirmm.fr/ontologies/oan/statutAmendement"></see></summary>
    let statutAmendement = _prefix "statutAmendement"
    /// <summary>
    /// La propriété "texteAlinea" représente le texte d'un alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteAlinea"></see></summary>
    let texteAlinea = _prefix "texteAlinea"
    /// <summary>
    /// La propriété "texteAmendement" représente le texte de l'amendement.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteAmendement"></see></summary>
    let texteAmendement = _prefix "texteAmendement"
    /// <summary>
    /// La propriété "texteContient" représente les différents chapitres contenu dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteContient"></see></summary>
    let texteContient = _prefix "texteContient"
    /// <summary>
    /// La propriété "texteIntervention" représente le texte de l'intervention.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteIntervention"></see></summary>
    let texteIntervention = _prefix "texteIntervention"
    /// <summary>
    /// La propriété "texteLoiCorrespondantAlinea" représente le texte de loi correspondant à l'alinéa.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantAlinea"></see></summary>
    let texteLoiCorrespondantAlinea = _prefix "texteLoiCorrespondantAlinea"
    /// <summary>
    /// La propriété "texteLoiCorrespondantArticle" représente l'article correspondant au texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantArticle"></see></summary>
    let texteLoiCorrespondantArticle = _prefix "texteLoiCorrespondantArticle"
    /// <summary>
    /// La propriété "texteQuestion" représente le texte de la question écrite émise par le député pour un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteQuestion"></see></summary>
    let texteQuestion = _prefix "texteQuestion"
    /// <summary>
    /// La propriété "texteReponse" représente le texte de la réponse à une question écrite émise par un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/texteReponse"></see></summary>
    let texteReponse = _prefix "texteReponse"
    /// <summary>
    /// La propriété "themeQuestion" représente le thème de la question écrite émise par le député pour un ministre.
    /// <see href="http://data.lirmm.fr/ontologies/oan/themeQuestion"></see></summary>
    let themeQuestion = _prefix "themeQuestion"
    /// <summary>
    /// La propriété "titreArticle" représente le titre d'un article.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreArticle"></see></summary>
    let titreArticle = _prefix "titreArticle"
    /// <summary>
    /// La propriété "titrechapitre" représente le titre d'un chapitre contenu dans un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreChapitre"></see></summary>
    let titreChapitre = _prefix "titreChapitre"
    /// <summary>
    /// La propriété "titreSection" représente le titre d'une section contenu dans un chapitre d'un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreSection"></see></summary>
    let titreSection = _prefix "titreSection"
    /// <summary>
    /// La propriété "titreSousSection" représente le titre d'une sous section contenu dans une section d'un chapitre d'un texte de loi.
    /// <see href="http://data.lirmm.fr/ontologies/oan/titreSousSection"></see></summary>
    let titreSousSection = _prefix "titreSousSection"
    /// <summary>
    /// La propriété "typeIntervention" représente les différents types d'intervention possible que peuvent faire les députés lors de divers séances d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeIntervention"></see></summary>
    let typeIntervention = _prefix "typeIntervention"
    /// <summary>
    /// La propriété "typeOrganisme" représente les différents types existant d'organismes.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeOrganisme"></see></summary>
    let typeOrganisme = _prefix "typeOrganisme"
    /// <summary>
    /// La propriété "typePreuve" représente le type d'une preuve de présence d'un député à une séance d'un organisme quelconque.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typePreuve"></see></summary>
    let typePreuve = _prefix "typePreuve"
    /// <summary>
    /// La propriété "typeSeance" représente les différents types existant de séances.
    /// <see href="http://data.lirmm.fr/ontologies/oan/typeSeance"></see></summary>
    let typeSeance = _prefix "typeSeance"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oan =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/oan/" "oan"

    /// <summary>
    ///   <para>rdfs:comment : La classe "Alinea" représente les différents alinéas qui sont contenus dans un article.^^xsd:string</para>
    ///   <para>rdfs:label : Alinea^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Alinea">oan:Alinea</a>
    /// </summary>
    let Alinea = _prefixId.prefix "Alinea"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Amendement" sert à représenter la notion d'amendement. Un amendement est une demande de modification d'une loi existante.^^xsd:string</para>
    ///   <para>rdfs:label : Amendement^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Amendement">oan:Amendement</a>
    /// </summary>
    let Amendement = _prefixId.prefix "Amendement"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Article" représente les différents articles qui peuvent être contenus dans un texte de loi.^^xsd:string</para>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Article">oan:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:label : Chapitre^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "Chapitre" représente les différents chapitres contenus dans un texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Chapitre">oan:Chapitre</a>
    /// </summary>
    let Chapitre = _prefixId.prefix "Chapitre"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Depute" sert à représenter la notion de député siégeant à l'assemblée nationale. Un député est un représentant auprès de l'assemblée nationale élu par le peuple.^^xsd:string</para>
    ///   <para>rdfs:label : Député^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Depute">oan:Depute</a>
    /// </summary>
    let Depute = _prefixId.prefix "Depute"
    /// <summary>
    ///   <para>rdfs:label : Intervention^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "Intervention" représente l'intervention d'un député lors d'un rassemblement à l'assemblée nationale ou bien lors d'une commission.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Intervention">oan:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Loi" sert à représenter la notion de loi établi par les députés lors de différents hémicycles. Une loi est une règle juridique défini lors de différents rassemblements de l'assemblée nationale par les députés et les membres du gouvernements. Un projet de loi émane d'un membre du grouvernement et une proposition de loi émane d'un parlementaire.^^xsd:string</para>
    ///   <para>rdfs:label : Loi^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Loi">oan:Loi</a>
    /// </summary>
    let Loi = _prefixId.prefix "Loi"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Mandat" représente les différents mandats qu'il est possible d'avoir pour un député.^^xsd:string</para>
    ///   <para>rdfs:label : Mandat^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Mandat">oan:Mandat</a>
    /// </summary>
    let Mandat = _prefixId.prefix "Mandat"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Organisme" représente les différents organismes possibles auxquels un député peut appartenir.^^xsd:string</para>
    ///   <para>rdfs:label : Organisme^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Organisme">oan:Organisme</a>
    /// </summary>
    let Organisme = _prefixId.prefix "Organisme"
    /// <summary>
    ///   <para>rdfs:label : Position de l'article^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "PositionArticle" indique dans quel partie du texte de loi est contenu l'article correspondant.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/PositionArticle">oan:PositionArticle</a>
    /// </summary>
    let PositionArticle = _prefixId.prefix "PositionArticle"
    /// <summary>
    ///   <para>rdfs:label : Présence^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "Presence" représente la présence d'un député lors d'une commission ou d'une session de l'assemblée nationale.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Presence">oan:Presence</a>
    /// </summary>
    let Presence = _prefixId.prefix "Presence"
    /// <summary>
    ///   <para>rdfs:label : Preuve de Présence^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "PreuvePresence" représente les différentes types de preuves qu'il est possible d'avoir afin de prouver la présence d'un député à une commission ou à une session de l'assemblée nationale.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/PreuvePresence">oan:PreuvePresence</a>
    /// </summary>
    let PreuvePresence = _prefixId.prefix "PreuvePresence"
    /// <summary>
    ///   <para>rdfs:comment : La classe "QuestionEcrite" représente les différentes question qui sont écrites par un député pour les ministres du gouvernements.^^xsd:string</para>
    ///   <para>rdfs:label : Question Ecrite^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/QuestionEcrite">oan:QuestionEcrite</a>
    /// </summary>
    let QuestionEcrite = _prefixId.prefix "QuestionEcrite"
    /// <summary>
    ///   <para>rdfs:label : Rapport^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "Rapport" sert à représenter la notion de rapport écrit par les députés lors de commission ou d'hémicycle. Un rapport est établi dans le but de proposer des solutions à un problème.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Rapport">oan:Rapport</a>
    /// </summary>
    let Rapport = _prefixId.prefix "Rapport"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Reponse" représente la réponse des ministres aux différentes questions écrites émises par les députés.^^xsd:string</para>
    ///   <para>rdfs:label : Réponse^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Reponse">oan:Reponse</a>
    /// </summary>
    let Reponse = _prefixId.prefix "Reponse"
    /// <summary>
    ///   <para>rdfs:label : Séance^^xsd:string</para>
    ///   <para>rdfs:comment : La classe "Seance" représente les différents rassemblements auxquels un député assiste. Ces rassemblements sont généralements les sessions de l'assemblée nationale et les commissions.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Seance">oan:Seance</a>
    /// </summary>
    let Seance = _prefixId.prefix "Seance"
    /// <summary>
    ///   <para>rdfs:comment : La classe "Section" représente les différentes sections contenus dans un texte de loi.^^xsd:string</para>
    ///   <para>rdfs:label : Section^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/Section">oan:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:comment : La classe "SousSection" représente les sous sections contenus dans un texte de loi.^^xsd:string</para>
    ///   <para>rdfs:label : Sous Section^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/SousSection">oan:SousSection</a>
    /// </summary>
    let SousSection = _prefixId.prefix "SousSection"
    /// <summary>
    ///   <para>rdfs:comment : La classe "TexteLoi" représente le texte contenu dans une loi. Pour plus de détails voir la classe "Loi".^^xsd:string</para>
    ///   <para>rdfs:label : Texte de Loi^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/TexteLoi">oan:TexteLoi</a>
    /// </summary>
    let TexteLoi = _prefixId.prefix "TexteLoi"
    /// <summary>
    ///   <para>rdfs:label : aPourMandat^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "aPourMandat" représente le mandat d'un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/aPourMandat">oan:aPourMandat</a>
    /// </summary>
    let aPourMandat = _prefixId.prefix "aPourMandat"
    /// <summary>
    ///   <para>rdfs:label : aPourParti^^xsd:string</para>
    ///   <para>rdfs:comment : Désigne le parti du député correspondant.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/aPourParti">oan:aPourParti</a>
    /// </summary>
    let aPourParti = _prefixId.prefix "aPourParti"
    /// <summary>
    ///   <para>rdfs:label : aPourTexte^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "aPourTexte" représente la loi correspondant au texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/aPourTexte">oan:aPourTexte</a>
    /// </summary>
    let aPourTexte = _prefixId.prefix "aPourTexte"
    /// <summary>
    ///   <para>rdfs:label : alineaNumero^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "alineaNumero" représente le numéro d'un alinéa.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/alineaNumero">oan:alineaNumero</a>
    /// </summary>
    let alineaNumero = _prefixId.prefix "alineaNumero"
    /// <summary>
    ///   <para>rdfs:label : amendementConcerne^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "amendementConcerne" représente l'article pour lequel a été créé l'amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/amendementConcerne">oan:amendementConcerne</a>
    /// </summary>
    let amendementConcerne = _prefixId.prefix "amendementConcerne"
    /// <summary>
    ///   <para>rdfs:label : amendementCorrespond^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "amendementCorrespond" représente le texte de loi correspondant à un amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/amendementCorrespond">oan:amendementCorrespond</a>
    /// </summary>
    let amendementCorrespond = _prefixId.prefix "amendementCorrespond"
    /// <summary>
    ///   <para>rdfs:label : amendementNbFoisRectifier^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "amendementNbFoisRectifier" représente le nombre de fois qu'un amendement a été rectifier par l'assemblée nationale.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/amendementNbFoisRectifier">oan:amendementNbFoisRectifier</a>
    /// </summary>
    let amendementNbFoisRectifier = _prefixId.prefix "amendementNbFoisRectifier"
    /// <summary>
    ///   <para>rdfs:label : appartientOrganisme^^xsd:string</para>
    ///   <para>rdfs:comment : La propriétté "appartientOrganisme" représente l'organisme auquel appartient un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/appartientOrganisme">oan:appartientOrganisme</a>
    /// </summary>
    let appartientOrganisme = _prefixId.prefix "appartientOrganisme"
    /// <summary>
    ///   <para>rdfs:label : articleCorrespond^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "articleCorrespond" représente l'article correspondant à une loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/articleCorrespond">oan:articleCorrespond</a>
    /// </summary>
    let articleCorrespond = _prefixId.prefix "articleCorrespond"
    /// <summary>
    ///   <para>rdfs:label : articleCorrespondant^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "articleCorrespondant" représente l'article correspondant à l'alinéa.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/articleCorrespondant">oan:articleCorrespondant</a>
    /// </summary>
    let articleCorrespondant = _prefixId.prefix "articleCorrespondant"
    /// <summary>
    ///   <para>rdfs:label : auteurAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "auteurAmendement" représente le député qui est l'origine de l'amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/auteurAmendement">oan:auteurAmendement</a>
    /// </summary>
    let auteurAmendement = _prefixId.prefix "auteurAmendement"
    /// <summary>
    ///   <para>rdfs:label : auteurRapport^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "auteurRapport" représente le député qui est l'auteur du rapport.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/auteurRapport">oan:auteurRapport</a>
    /// </summary>
    let auteurRapport = _prefixId.prefix "auteurRapport"
    /// <summary>
    ///   <para>rdfs:label : chapitreContient^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "chapitreContient" représente les différentes sections qui sont contenus dans un chapitre.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/chapitreContient">oan:chapitreContient</a>
    /// </summary>
    let chapitreContient = _prefixId.prefix "chapitreContient"
    /// <summary>
    ///   <para>rdfs:label : dansChapitre^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dansChapitre" indique dans quel chapitre du texte de loi se trouve l'article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dansChapitre">oan:dansChapitre</a>
    /// </summary>
    let dansChapitre = _prefixId.prefix "dansChapitre"
    /// <summary>
    ///   <para>rdfs:label : dansSection^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dansSection" indique dans quel section du texte de loi se trouve l'article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dansSection">oan:dansSection</a>
    /// </summary>
    let dansSection = _prefixId.prefix "dansSection"
    /// <summary>
    ///   <para>rdfs:label : dansSousSection^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dansSousSection" indique dans quel sous section du texte de loi se trouve l'article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dansSousSection">oan:dansSousSection</a>
    /// </summary>
    let dansSousSection = _prefixId.prefix "dansSousSection"
    /// <summary>
    ///   <para>rdfs:label : dansTexte^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dansTexte" indique dans quelle partie du texte de loi se trouve l'article. Car il est possible qu'un article ne soit contenu ni dans un chapitre, ni dans une section et ni dans une sous section, il est alors en général en tout début du texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dansTexte">oan:dansTexte</a>
    /// </summary>
    let dansTexte = _prefixId.prefix "dansTexte"
    /// <summary>
    ///   <para>rdfs:label : dateCreationAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateCreationAmendement" représente la date à laquelle est créé l'amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateCreationAmendement">oan:dateCreationAmendement</a>
    /// </summary>
    let dateCreationAmendement = _prefixId.prefix "dateCreationAmendement"
    /// <summary>
    ///   <para>rdfs:label : dateEcriture^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateEcriture" représente la date à laquelle a été émise la question écrite.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateEcriture">oan:dateEcriture</a>
    /// </summary>
    let dateEcriture = _prefixId.prefix "dateEcriture"
    /// <summary>
    ///   <para>rdfs:label : dateIntervention^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateIntervention" représente la date à laquelle est faite l'intervention.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateIntervention">oan:dateIntervention</a>
    /// </summary>
    let dateIntervention = _prefixId.prefix "dateIntervention"
    /// <summary>
    ///   <para>rdfs:label : datePresence^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "datePresence" représente la date à laquelle a été faite la présence.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/datePresence">oan:datePresence</a>
    /// </summary>
    let datePresence = _prefixId.prefix "datePresence"
    /// <summary>
    ///   <para>rdfs:label : dateRapport^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateRapport" représente la date à laquel le rapport a été créé.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateRapport">oan:dateRapport</a>
    /// </summary>
    let dateRapport = _prefixId.prefix "dateRapport"
    /// <summary>
    ///   <para>rdfs:label : dateReponse^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateReponse" représente la data à laquelle a été émise la réponse à une question écrite.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateReponse">oan:dateReponse</a>
    /// </summary>
    let dateReponse = _prefixId.prefix "dateReponse"
    /// <summary>
    ///   <para>rdfs:label : dateSeance^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "dateSeance" représente la date à laquelle à lieu une séance d'un quelconque organisme.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/dateSeance">oan:dateSeance</a>
    /// </summary>
    let dateSeance = _prefixId.prefix "dateSeance"
    /// <summary>
    ///   <para>rdfs:label : debutMandat^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "debutMandat" représente le début du mandat d'un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/debutMandat">oan:debutMandat</a>
    /// </summary>
    let debutMandat = _prefixId.prefix "debutMandat"
    /// <summary>
    ///   <para>rdfs:label : deputeCorrespondant^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "deputecorrespondant" représente la présence d'un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/deputeCorrespondant">oan:deputeCorrespondant</a>
    /// </summary>
    let deputeCorrespondant = _prefixId.prefix "deputeCorrespondant"
    /// <summary>
    ///   <para>rdfs:label : deputeIntervenant^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "deputeIntervenant" représente le député qui est l'auteur de l'intervention.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/deputeIntervenant">oan:deputeIntervenant</a>
    /// </summary>
    let deputeIntervenant = _prefixId.prefix "deputeIntervenant"
    /// <summary>
    ///   <para>rdfs:label : estEcrite^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "estEcrite" représente le député qui a écrit cette question écrite.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/estEcrite">oan:estEcrite</a>
    /// </summary>
    let estEcrite = _prefixId.prefix "estEcrite"
    /// <summary>
    ///   <para>rdfs:label : exposeAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "exposeAmendement" représente un petit texte résumé de cet amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/exposeAmendement">oan:exposeAmendement</a>
    /// </summary>
    let exposeAmendement = _prefixId.prefix "exposeAmendement"
    /// <summary>
    ///   <para>rdfs:label : exposeArticle^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "exposeArticle" représente un petit résumé de l'article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/exposeArticle">oan:exposeArticle</a>
    /// </summary>
    let exposeArticle = _prefixId.prefix "exposeArticle"
    /// <summary>
    ///   <para>rdfs:label : finMandat^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "finMandat" représente la fin du mandat d'un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/finMandat">oan:finMandat</a>
    /// </summary>
    let finMandat = _prefixId.prefix "finMandat"
    /// <summary>
    ///   <para>rdfs:label : fonctionIntervenant^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "fonctionIntervenant" représente la fonction du député qui intervient durant une séance d'un quelconque organisme.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/fonctionIntervenant">oan:fonctionIntervenant</a>
    /// </summary>
    let fonctionIntervenant = _prefixId.prefix "fonctionIntervenant"
    /// <summary>
    ///   <para>rdfs:label : heureDebutSeance^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "heureDebutSeance" représente l'heure à laquelle débute une séance.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/heureDebutSeance">oan:heureDebutSeance</a>
    /// </summary>
    let heureDebutSeance = _prefixId.prefix "heureDebutSeance"
    /// <summary>
    ///   <para>rdfs:label : intervientLors^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "intervientLors" représente l'intervention d'un député qui survient lors d'une séance.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/intervientLors">oan:intervientLors</a>
    /// </summary>
    let intervientLors = _prefixId.prefix "intervientLors"
    /// <summary>
    ///   <para>rdfs:label : legislatureAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "legislatureAmendement" représente la législature sous laquelle a été créé l'amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/legislatureAmendement">oan:legislatureAmendement</a>
    /// </summary>
    let legislatureAmendement = _prefixId.prefix "legislatureAmendement"
    /// <summary>
    ///   <para>rdfs:label : legislatureQuestion^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "legislatureQuestion" représente la législature sous laquelle la question écrite à été émise.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/legislatureQuestion">oan:legislatureQuestion</a>
    /// </summary>
    let legislatureQuestion = _prefixId.prefix "legislatureQuestion"
    /// <summary>
    ///   <para>rdfs:label : loiCorrespondante^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "loiCorrespondante" indique à quelle loi est rataché l'alinéa.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/loiCorrespondante">oan:loiCorrespondante</a>
    /// </summary>
    let loiCorrespondante = _prefixId.prefix "loiCorrespondante"
    /// <summary>
    ///   <para>rdfs:label : metier^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "metier" représente le métier du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/metier">oan:metier</a>
    /// </summary>
    let metier = _prefixId.prefix "metier"
    /// <summary>
    ///   <para>rdfs:label : motifRetrait^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "motifRetrait" représente le motif pour lequel la question écrite a été supprimé.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/motifRetrait">oan:motifRetrait</a>
    /// </summary>
    let motifRetrait = _prefixId.prefix "motifRetrait"
    /// <summary>
    ///   <para>rdfs:label : nbIntervention^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "nbIntervention" représente le nombre d'interventions qu'il y a eu pour une section.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/nbIntervention">oan:nbIntervention</a>
    /// </summary>
    let nbIntervention = _prefixId.prefix "nbIntervention"
    /// <summary>
    ///   <para>rdfs:label : nbMots^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "nbMots" représente le nombre de mots que contient l'intervention d'un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/nbMots">oan:nbMots</a>
    /// </summary>
    let nbMots = _prefixId.prefix "nbMots"
    /// <summary>
    ///   <para>rdfs:label : nbPreuvesPresence^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "nbPreuvesPresence" représente le nombre de preuves d'une présence que peut avoir un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/nbPreuvesPresence">oan:nbPreuvesPresence</a>
    /// </summary>
    let nbPreuvesPresence = _prefixId.prefix "nbPreuvesPresence"
    /// <summary>
    ///   <para>rdfs:label : nomMandat^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "nomMandat" représente le nom du mandat que peut avoir un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/nomMandat">oan:nomMandat</a>
    /// </summary>
    let nomMandat = _prefixId.prefix "nomMandat"
    /// <summary>
    ///   <para>rdfs:label : nomOrganisme^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "nomOrganisme" représente le nom d'un organisme.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/nomOrganisme">oan:nomOrganisme</a>
    /// </summary>
    let nomOrganisme = _prefixId.prefix "nomOrganisme"
    /// <summary>
    ///   <para>rdfs:label : numCirco^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numCirco" représente le numéro de la circonscription dont le député est responsable.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numCirco">oan:numCirco</a>
    /// </summary>
    let numCirco = _prefixId.prefix "numCirco"
    /// <summary>
    ///   <para>rdfs:label : numeroAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numeroAmendement" représente le numéro donné à un amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numeroAmendement">oan:numeroAmendement</a>
    /// </summary>
    let numeroAmendement = _prefixId.prefix "numeroAmendement"
    /// <summary>
    ///   <para>rdfs:label : numeroArticle^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numeroArticle" représente le numéro d'un article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numeroArticle">oan:numeroArticle</a>
    /// </summary>
    let numeroArticle = _prefixId.prefix "numeroArticle"
    /// <summary>
    ///   <para>rdfs:label : numeroQuestion^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numeorQuestion" représente le numéro de la question écrite.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numeroQuestion">oan:numeroQuestion</a>
    /// </summary>
    let numeroQuestion = _prefixId.prefix "numeroQuestion"
    /// <summary>
    ///   <para>rdfs:label : numeroRapport^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numeroRapport" représente le numéro donné au rapport par les différents organismes qu'il concerne.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numeroRapport">oan:numeroRapport</a>
    /// </summary>
    let numeroRapport = _prefixId.prefix "numeroRapport"
    /// <summary>
    ///   <para>rdfs:label : numeroSemaineSeance^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "numeroSemaineSeance" représente le numéro de la semaine à laquelle à lieu la séance.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/numeroSemaineSeance">oan:numeroSemaineSeance</a>
    /// </summary>
    let numeroSemaineSeance = _prefixId.prefix "numeroSemaineSeance"
    /// <summary>
    ///   <para>rdfs:label : placeHemicycle^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "placeHemicycle" représente le numéro de la place qu'occupe le député à l'assemblée nationale.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/placeHemicycle">oan:placeHemicycle</a>
    /// </summary>
    let placeHemicycle = _prefixId.prefix "placeHemicycle"
    /// <summary>
    ///   <para>rdfs:label : positionDans^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "positionDans" représente la position de l'article dans un texte de loi, c'est-à-dire si il est dans une sous section, dans une section, dans un chapitre ou dans le texte tout court.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/positionDans">oan:positionDans</a>
    /// </summary>
    let positionDans = _prefixId.prefix "positionDans"
    /// <summary>
    ///   <para>rdfs:label : pourMinistere^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "pourMinistere" représente le nom du ministère pour lequel la lettre a été écrite.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/pourMinistere">oan:pourMinistere</a>
    /// </summary>
    let pourMinistere = _prefixId.prefix "pourMinistere"
    /// <summary>
    ///   <para>rdfs:label : presenceCorrespondante^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "presenceCorrespondante" représente la preuve d'une présence d'un député à une séance à la présence à cette séance.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/presenceCorrespondante">oan:presenceCorrespondante</a>
    /// </summary>
    let presenceCorrespondante = _prefixId.prefix "presenceCorrespondante"
    /// <summary>
    ///   <para>rdfs:label : reponseCorrespondante^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "reponseCorrespondante" représente la réponse écrite à une question écrite émise par un député.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/reponseCorrespondante">oan:reponseCorrespondante</a>
    /// </summary>
    let reponseCorrespondante = _prefixId.prefix "reponseCorrespondante"
    /// <summary>
    ///   <para>rdfs:label : seanceAppartient^^xsd:string</para>
    ///   <para>rdfs:comment : la propriété "seanceAppartient" représente la séance d'un organisme.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/seanceAppartient">oan:seanceAppartient</a>
    /// </summary>
    let seanceAppartient = _prefixId.prefix "seanceAppartient"
    /// <summary>
    ///   <para>rdfs:label : seanceCorrespondante^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "seanceCorrespondante" représente la présence d'un député correspondant à une séance d'un organisme quelconque.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/seanceCorrespondante">oan:seanceCorrespondante</a>
    /// </summary>
    let seanceCorrespondante = _prefixId.prefix "seanceCorrespondante"
    /// <summary>
    ///   <para>rdfs:label : seanceProduit^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "seanceProduit" représente les différents rapports qui sont produit lors d'une séance d'un organisme quelconque.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/seanceProduit">oan:seanceProduit</a>
    /// </summary>
    let seanceProduit = _prefixId.prefix "seanceProduit"
    /// <summary>
    ///   <para>rdfs:label : sectionContient^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "sectionContien" représente les différentes sous sections qui sont contenus dans une section.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/sectionContient">oan:sectionContient</a>
    /// </summary>
    let sectionContient = _prefixId.prefix "sectionContient"
    /// <summary>
    ///   <para>rdfs:label : sexe^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "sexe" représente le sexe du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/sexe">oan:sexe</a>
    /// </summary>
    let sexe = _prefixId.prefix "sexe"
    /// <summary>
    ///   <para>rdfs:label : statutAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "statutAmendement" représente les status que peut prendre un amendement durant sa période de discussion.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/statutAmendement">oan:statutAmendement</a>
    /// </summary>
    let statutAmendement = _prefixId.prefix "statutAmendement"
    /// <summary>
    ///   <para>rdfs:label : texteAlinea^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteAlinea" représente le texte d'un alinéa.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteAlinea">oan:texteAlinea</a>
    /// </summary>
    let texteAlinea = _prefixId.prefix "texteAlinea"
    /// <summary>
    ///   <para>rdfs:label : texteAmendement^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteAmendement" représente le texte de l'amendement.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteAmendement">oan:texteAmendement</a>
    /// </summary>
    let texteAmendement = _prefixId.prefix "texteAmendement"
    /// <summary>
    ///   <para>rdfs:label : texteContient^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteContient" représente les différents chapitres contenu dans un texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteContient">oan:texteContient</a>
    /// </summary>
    let texteContient = _prefixId.prefix "texteContient"
    /// <summary>
    ///   <para>rdfs:label : texteIntervention^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteIntervention" représente le texte de l'intervention.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteIntervention">oan:texteIntervention</a>
    /// </summary>
    let texteIntervention = _prefixId.prefix "texteIntervention"
    /// <summary>
    ///   <para>rdfs:label : texteLoiCorrespondantAlinea^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteLoiCorrespondantAlinea" représente le texte de loi correspondant à l'alinéa.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantAlinea">oan:texteLoiCorrespondantAlinea</a>
    /// </summary>
    let texteLoiCorrespondantAlinea = _prefixId.prefix "texteLoiCorrespondantAlinea"
    /// <summary>
    ///   <para>rdfs:label : texteLoiCorrespondantArticle^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteLoiCorrespondantArticle" représente l'article correspondant au texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantArticle">oan:texteLoiCorrespondantArticle</a>
    /// </summary>
    let texteLoiCorrespondantArticle = _prefixId.prefix "texteLoiCorrespondantArticle"
    /// <summary>
    ///   <para>rdfs:label : texteQuestion^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteQuestion" représente le texte de la question écrite émise par le député pour un ministre.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteQuestion">oan:texteQuestion</a>
    /// </summary>
    let texteQuestion = _prefixId.prefix "texteQuestion"
    /// <summary>
    ///   <para>rdfs:label : texteReponse^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "texteReponse" représente le texte de la réponse à une question écrite émise par un ministre.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/texteReponse">oan:texteReponse</a>
    /// </summary>
    let texteReponse = _prefixId.prefix "texteReponse"
    /// <summary>
    ///   <para>rdfs:label : themeQuestion^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "themeQuestion" représente le thème de la question écrite émise par le député pour un ministre.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/themeQuestion">oan:themeQuestion</a>
    /// </summary>
    let themeQuestion = _prefixId.prefix "themeQuestion"
    /// <summary>
    ///   <para>rdfs:label : titreArticle^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "titreArticle" représente le titre d'un article.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/titreArticle">oan:titreArticle</a>
    /// </summary>
    let titreArticle = _prefixId.prefix "titreArticle"
    /// <summary>
    ///   <para>rdfs:label : titreChapitre^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "titrechapitre" représente le titre d'un chapitre contenu dans un texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/titreChapitre">oan:titreChapitre</a>
    /// </summary>
    let titreChapitre = _prefixId.prefix "titreChapitre"
    /// <summary>
    ///   <para>rdfs:label : titreSection^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "titreSection" représente le titre d'une section contenu dans un chapitre d'un texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/titreSection">oan:titreSection</a>
    /// </summary>
    let titreSection = _prefixId.prefix "titreSection"
    /// <summary>
    ///   <para>rdfs:label : titreSousSection^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "titreSousSection" représente le titre d'une sous section contenu dans une section d'un chapitre d'un texte de loi.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/titreSousSection">oan:titreSousSection</a>
    /// </summary>
    let titreSousSection = _prefixId.prefix "titreSousSection"
    /// <summary>
    ///   <para>rdfs:label : typeIntervention^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "typeIntervention" représente les différents types d'intervention possible que peuvent faire les députés lors de divers séances d'un organisme quelconque.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/typeIntervention">oan:typeIntervention</a>
    /// </summary>
    let typeIntervention = _prefixId.prefix "typeIntervention"
    /// <summary>
    ///   <para>rdfs:label : typeOrganisme^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "typeOrganisme" représente les différents types existant d'organismes.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/typeOrganisme">oan:typeOrganisme</a>
    /// </summary>
    let typeOrganisme = _prefixId.prefix "typeOrganisme"
    /// <summary>
    ///   <para>rdfs:label : typePreuve^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "typePreuve" représente le type d'une preuve de présence d'un député à une séance d'un organisme quelconque.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/typePreuve">oan:typePreuve</a>
    /// </summary>
    let typePreuve = _prefixId.prefix "typePreuve"
    /// <summary>
    ///   <para>rdfs:label : typeSeance^^xsd:string</para>
    ///   <para>rdfs:comment : La propriété "typeSeance" représente les différents types existant de séances.^^xsd:string</para>
    ///   <a href="http://data.lirmm.fr/ontologies/oan/typeSeance">oan:typeSeance</a>
    /// </summary>
    let typeSeance = _prefixId.prefix "typeSeance"

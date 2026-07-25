namespace http.data.lirmm.fr.ontologies.oan.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oan =
    let _namespace_iri = Namespace_Iri oan |> NamespaceIRI
    /// <summary>
    ///   <para>oan:Alinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Alinea" représente les différents alinéas qui sont contenus dans un article.</para>
    /// labels<para>Alinea</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Alinea">http://data.lirmm.fr/ontologies/oan/Alinea</seealso>
    let Alinea = Prefixed_Name(oan, "Alinea") |> PrefixedName
    /// <summary>
    ///   <para>oan:Reponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "Reponse" représente la réponse des ministres aux différentes questions écrites émises par les députés.</para>
    /// labels<para>Réponse</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Reponse">http://data.lirmm.fr/ontologies/oan/Reponse</seealso>
    let Reponse = Prefixed_Name(oan, "Reponse") |> PrefixedName
    /// <summary>
    ///   <para>oan:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "Article" représente les différents articles qui peuvent être contenus dans un texte de loi.</para>
    /// labels<para>Article</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Article">http://data.lirmm.fr/ontologies/oan/Article</seealso>
    let Article = Prefixed_Name(oan, "Article") |> PrefixedName
    /// <summary>
    ///   <para>oan:Rapport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Rapport" sert à représenter la notion de rapport écrit par les députés lors de commission ou d'hémicycle. Un rapport est établi dans le but de proposer des solutions à un problème.</para>
    /// labels<para>Rapport</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Rapport">http://data.lirmm.fr/ontologies/oan/Rapport</seealso>
    let Rapport = Prefixed_Name(oan, "Rapport") |> PrefixedName
    /// <summary>
    ///   <para>oan:QuestionEcrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "QuestionEcrite" représente les différentes question qui sont écrites par un député pour les ministres du gouvernements.</para>
    /// labels<para>Question Ecrite</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/QuestionEcrite">http://data.lirmm.fr/ontologies/oan/QuestionEcrite</seealso>
    let QuestionEcrite = Prefixed_Name(oan, "QuestionEcrite") |> PrefixedName
    /// <summary>
    ///   <para>oan:SousSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "SousSection" représente les sous sections contenus dans un texte de loi.</para>
    /// labels<para>Sous Section</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/SousSection">http://data.lirmm.fr/ontologies/oan/SousSection</seealso>
    let SousSection = Prefixed_Name(oan, "SousSection") |> PrefixedName
    /// <summary>
    ///   <para>oan:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Section" représente les différentes sections contenus dans un texte de loi.</para>
    /// labels<para>Section</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Section">http://data.lirmm.fr/ontologies/oan/Section</seealso>
    let Section = Prefixed_Name(oan, "Section") |> PrefixedName
    /// <summary>
    ///   <para>oan:nbPreuvesPresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "nbPreuvesPresence" représente le nombre de preuves d'une présence que peut avoir un député.</para>
    /// labels<para>nbPreuvesPresence</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/nbPreuvesPresence">http://data.lirmm.fr/ontologies/oan/nbPreuvesPresence</seealso>
    let nbPreuvesPresence = Prefixed_Name(oan, "nbPreuvesPresence") |> PrefixedName
    /// <summary>
    ///   <para>oan:numeroAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "numeroAmendement" représente le numéro donné à un amendement.</para>
    /// labels<para>numeroAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numeroAmendement">http://data.lirmm.fr/ontologies/oan/numeroAmendement</seealso>
    let numeroAmendement = Prefixed_Name(oan, "numeroAmendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:numeroRapport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "numeroRapport" représente le numéro donné au rapport par les différents organismes qu'il concerne.</para>
    /// labels<para>numeroRapport</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numeroRapport">http://data.lirmm.fr/ontologies/oan/numeroRapport</seealso>
    let numeroRapport = Prefixed_Name(oan, "numeroRapport") |> PrefixedName
    /// <summary>
    ///   <para>oan:placeHemicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "placeHemicycle" représente le numéro de la place qu'occupe le député à l'assemblée nationale.</para>
    /// labels<para>placeHemicycle</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/placeHemicycle">http://data.lirmm.fr/ontologies/oan/placeHemicycle</seealso>
    let placeHemicycle = Prefixed_Name(oan, "placeHemicycle") |> PrefixedName

    /// <summary>
    ///   <para>oan:reponseCorrespondante</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "reponseCorrespondante" représente la réponse écrite à une question écrite émise par un député.</para>
    /// labels<para>reponseCorrespondante</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/reponseCorrespondante">http://data.lirmm.fr/ontologies/oan/reponseCorrespondante</seealso>
    let reponseCorrespondante =
        Prefixed_Name(oan, "reponseCorrespondante") |> PrefixedName

    /// <summary>
    ///   <para>oan:seanceAppartient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>la propriété "seanceAppartient" représente la séance d'un organisme.</para>
    /// labels<para>seanceAppartient</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/seanceAppartient">http://data.lirmm.fr/ontologies/oan/seanceAppartient</seealso>
    let seanceAppartient = Prefixed_Name(oan, "seanceAppartient") |> PrefixedName

    /// <summary>
    ///   <para>oan:seanceCorrespondante</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "seanceCorrespondante" représente la présence d'un député correspondant à une séance d'un organisme quelconque.</para>
    /// labels<para>seanceCorrespondante</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/seanceCorrespondante">http://data.lirmm.fr/ontologies/oan/seanceCorrespondante</seealso>
    let seanceCorrespondante =
        Prefixed_Name(oan, "seanceCorrespondante") |> PrefixedName

    /// <summary>
    ///   <para>oan:statutAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "statutAmendement" représente les status que peut prendre un amendement durant sa période de discussion.</para>
    /// labels<para>statutAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/statutAmendement">http://data.lirmm.fr/ontologies/oan/statutAmendement</seealso>
    let statutAmendement = Prefixed_Name(oan, "statutAmendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:texteAlinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "texteAlinea" représente le texte d'un alinéa.</para>
    /// labels<para>texteAlinea</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteAlinea">http://data.lirmm.fr/ontologies/oan/texteAlinea</seealso>
    let texteAlinea = Prefixed_Name(oan, "texteAlinea") |> PrefixedName

    /// <summary>
    ///   <para>oan:texteLoiCorrespondantAlinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "texteLoiCorrespondantAlinea" représente le texte de loi correspondant à l'alinéa.</para>
    /// labels<para>texteLoiCorrespondantAlinea</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantAlinea">http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantAlinea</seealso>
    let texteLoiCorrespondantAlinea =
        Prefixed_Name(oan, "texteLoiCorrespondantAlinea") |> PrefixedName

    /// <summary>
    ///   <para>oan:texteQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "texteQuestion" représente le texte de la question écrite émise par le député pour un ministre.</para>
    /// labels<para>texteQuestion</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteQuestion">http://data.lirmm.fr/ontologies/oan/texteQuestion</seealso>
    let texteQuestion = Prefixed_Name(oan, "texteQuestion") |> PrefixedName
    /// <summary>
    ///   <para>oan:titreChapitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "titrechapitre" représente le titre d'un chapitre contenu dans un texte de loi.</para>
    /// labels<para>titreChapitre</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/titreChapitre">http://data.lirmm.fr/ontologies/oan/titreChapitre</seealso>
    let titreChapitre = Prefixed_Name(oan, "titreChapitre") |> PrefixedName
    /// <summary>
    ///   <para>oan:titreSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "titreSection" représente le titre d'une section contenu dans un chapitre d'un texte de loi.</para>
    /// labels<para>titreSection</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/titreSection">http://data.lirmm.fr/ontologies/oan/titreSection</seealso>
    let titreSection = Prefixed_Name(oan, "titreSection") |> PrefixedName
    /// <summary>
    ///   <para>oan:typePreuve</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "typePreuve" représente le type d'une preuve de présence d'un député à une séance d'un organisme quelconque.</para>
    /// labels<para>typePreuve</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/typePreuve">http://data.lirmm.fr/ontologies/oan/typePreuve</seealso>
    let typePreuve = Prefixed_Name(oan, "typePreuve") |> PrefixedName
    /// <summary>
    ///   <para>oan:typeSeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "typeSeance" représente les différents types existant de séances.</para>
    /// labels<para>typeSeance</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/typeSeance">http://data.lirmm.fr/ontologies/oan/typeSeance</seealso>
    let typeSeance = Prefixed_Name(oan, "typeSeance") |> PrefixedName
    /// <summary>
    ///   <para>oan:PositionArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "PositionArticle" indique dans quel partie du texte de loi est contenu l'article correspondant.</para>
    /// labels<para>Position de l'article</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/PositionArticle">http://data.lirmm.fr/ontologies/oan/PositionArticle</seealso>
    let PositionArticle = Prefixed_Name(oan, "PositionArticle") |> PrefixedName
    /// <summary>
    ///   <para>oan:Mandat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "Mandat" représente les différents mandats qu'il est possible d'avoir pour un député.</para>
    /// labels<para>Mandat</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Mandat">http://data.lirmm.fr/ontologies/oan/Mandat</seealso>
    let Mandat = Prefixed_Name(oan, "Mandat") |> PrefixedName
    /// <summary>
    ///   <para>oan:Seance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Seance" représente les différents rassemblements auxquels un député assiste. Ces rassemblements sont généralements les sessions de l'assemblée nationale et les commissions.</para>
    /// labels<para>Séance</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Seance">http://data.lirmm.fr/ontologies/oan/Seance</seealso>
    let Seance = Prefixed_Name(oan, "Seance") |> PrefixedName
    /// <summary>
    ///   <para>oan:Presence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Presence" représente la présence d'un député lors d'une commission ou d'une session de l'assemblée nationale.</para>
    /// labels<para>Présence</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Presence">http://data.lirmm.fr/ontologies/oan/Presence</seealso>
    let Presence = Prefixed_Name(oan, "Presence") |> PrefixedName
    /// <summary>
    ///   <para>oan:Depute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Depute" sert à représenter la notion de député siégeant à l'assemblée nationale. Un député est un représentant auprès de l'assemblée nationale élu par le peuple.</para>
    /// labels<para>Député</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Depute">http://data.lirmm.fr/ontologies/oan/Depute</seealso>
    let Depute = Prefixed_Name(oan, "Depute") |> PrefixedName
    /// <summary>
    ///   <para>oan:Amendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "Amendement" sert à représenter la notion d'amendement. Un amendement est une demande de modification d'une loi existante.</para>
    /// labels<para>Amendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Amendement">http://data.lirmm.fr/ontologies/oan/Amendement</seealso>
    let Amendement = Prefixed_Name(oan, "Amendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:Chapitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Chapitre" représente les différents chapitres contenus dans un texte de loi.</para>
    /// labels<para>Chapitre</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Chapitre">http://data.lirmm.fr/ontologies/oan/Chapitre</seealso>
    let Chapitre = Prefixed_Name(oan, "Chapitre") |> PrefixedName
    /// <summary>
    ///   <para>oan:Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "Intervention" représente l'intervention d'un député lors d'un rassemblement à l'assemblée nationale ou bien lors d'une commission.</para>
    /// labels<para>Intervention</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Intervention">http://data.lirmm.fr/ontologies/oan/Intervention</seealso>
    let Intervention = Prefixed_Name(oan, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>oan:dansChapitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dansChapitre" indique dans quel chapitre du texte de loi se trouve l'article.</para>
    /// labels<para>dansChapitre</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dansChapitre">http://data.lirmm.fr/ontologies/oan/dansChapitre</seealso>
    let dansChapitre = Prefixed_Name(oan, "dansChapitre") |> PrefixedName
    /// <summary>
    ///   <para>oan:dansTexte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dansTexte" indique dans quelle partie du texte de loi se trouve l'article. Car il est possible qu'un article ne soit contenu ni dans un chapitre, ni dans une section et ni dans une sous section, il est alors en général en tout début du texte de loi.</para>
    /// labels<para>dansTexte</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dansTexte">http://data.lirmm.fr/ontologies/oan/dansTexte</seealso>
    let dansTexte = Prefixed_Name(oan, "dansTexte") |> PrefixedName
    /// <summary>
    ///   <para>oan:dateEcriture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "dateEcriture" représente la date à laquelle a été émise la question écrite.</para>
    /// labels<para>dateEcriture</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateEcriture">http://data.lirmm.fr/ontologies/oan/dateEcriture</seealso>
    let dateEcriture = Prefixed_Name(oan, "dateEcriture") |> PrefixedName
    /// <summary>
    ///   <para>oan:PreuvePresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "PreuvePresence" représente les différentes types de preuves qu'il est possible d'avoir afin de prouver la présence d'un député à une commission ou à une session de l'assemblée nationale.</para>
    /// labels<para>Preuve de Présence</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/PreuvePresence">http://data.lirmm.fr/ontologies/oan/PreuvePresence</seealso>
    let PreuvePresence = Prefixed_Name(oan, "PreuvePresence") |> PrefixedName
    /// <summary>
    ///   <para>oan:Loi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Loi" sert à représenter la notion de loi établi par les députés lors de différents hémicycles. Une loi est une règle juridique défini lors de différents rassemblements de l'assemblée nationale par les députés et les membres du gouvernements. Un projet de loi émane d'un membre du grouvernement et une proposition de loi émane d'un parlementaire.</para>
    /// labels<para>Loi</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Loi">http://data.lirmm.fr/ontologies/oan/Loi</seealso>
    let Loi = Prefixed_Name(oan, "Loi") |> PrefixedName
    /// <summary>
    ///   <para>oan:Organisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>La classe "Organisme" représente les différents organismes possibles auxquels un député peut appartenir.</para>
    /// labels<para>Organisme</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/Organisme">http://data.lirmm.fr/ontologies/oan/Organisme</seealso>
    let Organisme = Prefixed_Name(oan, "Organisme") |> PrefixedName
    /// <summary>
    ///   <para>oan:TexteLoi</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>La classe "TexteLoi" représente le texte contenu dans une loi. Pour plus de détails voir la classe "Loi".</para>
    /// labels<para>Texte de Loi</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/TexteLoi">http://data.lirmm.fr/ontologies/oan/TexteLoi</seealso>
    let TexteLoi = Prefixed_Name(oan, "TexteLoi") |> PrefixedName
    /// <summary>
    ///   <para>oan:estEcrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "estEcrite" représente le député qui a écrit cette question écrite.</para>
    /// labels<para>estEcrite</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/estEcrite">http://data.lirmm.fr/ontologies/oan/estEcrite</seealso>
    let estEcrite = Prefixed_Name(oan, "estEcrite") |> PrefixedName
    /// <summary>
    ///   <para>oan:fonctionIntervenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "fonctionIntervenant" représente la fonction du député qui intervient durant une séance d'un quelconque organisme.</para>
    /// labels<para>fonctionIntervenant</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/fonctionIntervenant">http://data.lirmm.fr/ontologies/oan/fonctionIntervenant</seealso>
    let fonctionIntervenant = Prefixed_Name(oan, "fonctionIntervenant") |> PrefixedName

    /// <summary>
    ///   <para>oan:legislatureAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "legislatureAmendement" représente la législature sous laquelle a été créé l'amendement.</para>
    /// labels<para>legislatureAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/legislatureAmendement">http://data.lirmm.fr/ontologies/oan/legislatureAmendement</seealso>
    let legislatureAmendement =
        Prefixed_Name(oan, "legislatureAmendement") |> PrefixedName

    /// <summary>
    ///   <para>oan:metier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "metier" représente le métier du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.</para>
    /// labels<para>metier</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/metier">http://data.lirmm.fr/ontologies/oan/metier</seealso>
    let metier = Prefixed_Name(oan, "metier") |> PrefixedName
    /// <summary>
    ///   <para>oan:nbMots</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "nbMots" représente le nombre de mots que contient l'intervention d'un député.</para>
    /// labels<para>nbMots</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/nbMots">http://data.lirmm.fr/ontologies/oan/nbMots</seealso>
    let nbMots = Prefixed_Name(oan, "nbMots") |> PrefixedName
    /// <summary>
    ///   <para>oan:nomMandat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "nomMandat" représente le nom du mandat que peut avoir un député.</para>
    /// labels<para>nomMandat</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/nomMandat">http://data.lirmm.fr/ontologies/oan/nomMandat</seealso>
    let nomMandat = Prefixed_Name(oan, "nomMandat") |> PrefixedName
    /// <summary>
    ///   <para>oan:numCirco</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "numCirco" représente le numéro de la circonscription dont le député est responsable.</para>
    /// labels<para>numCirco</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numCirco">http://data.lirmm.fr/ontologies/oan/numCirco</seealso>
    let numCirco = Prefixed_Name(oan, "numCirco") |> PrefixedName
    /// <summary>
    ///   <para>oan:numeroSemaineSeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "numeroSemaineSeance" représente le numéro de la semaine à laquelle à lieu la séance.</para>
    /// labels<para>numeroSemaineSeance</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numeroSemaineSeance">http://data.lirmm.fr/ontologies/oan/numeroSemaineSeance</seealso>
    let numeroSemaineSeance = Prefixed_Name(oan, "numeroSemaineSeance") |> PrefixedName
    /// <summary>
    ///   <para>oan:seanceProduit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "seanceProduit" représente les différents rapports qui sont produit lors d'une séance d'un organisme quelconque.</para>
    /// labels<para>seanceProduit</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/seanceProduit">http://data.lirmm.fr/ontologies/oan/seanceProduit</seealso>
    let seanceProduit = Prefixed_Name(oan, "seanceProduit") |> PrefixedName

    /// <summary>
    ///   <para>oan:texteLoiCorrespondantArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "texteLoiCorrespondantArticle" représente l'article correspondant au texte de loi.</para>
    /// labels<para>texteLoiCorrespondantArticle</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantArticle">http://data.lirmm.fr/ontologies/oan/texteLoiCorrespondantArticle</seealso>
    let texteLoiCorrespondantArticle =
        Prefixed_Name(oan, "texteLoiCorrespondantArticle") |> PrefixedName

    /// <summary>
    ///   <para>oan:texteReponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "texteReponse" représente le texte de la réponse à une question écrite émise par un ministre.</para>
    /// labels<para>texteReponse</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteReponse">http://data.lirmm.fr/ontologies/oan/texteReponse</seealso>
    let texteReponse = Prefixed_Name(oan, "texteReponse") |> PrefixedName
    /// <summary>
    ///   <para>oan:titreSousSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "titreSousSection" représente le titre d'une sous section contenu dans une section d'un chapitre d'un texte de loi.</para>
    /// labels<para>titreSousSection</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/titreSousSection">http://data.lirmm.fr/ontologies/oan/titreSousSection</seealso>
    let titreSousSection = Prefixed_Name(oan, "titreSousSection") |> PrefixedName
    /// <summary>
    ///   <para>oan:aPourMandat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "aPourMandat" représente le mandat d'un député.</para>
    /// labels<para>aPourMandat</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/aPourMandat">http://data.lirmm.fr/ontologies/oan/aPourMandat</seealso>
    let aPourMandat = Prefixed_Name(oan, "aPourMandat") |> PrefixedName
    /// <summary>
    ///   <para>oan:aPourParti</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Désigne le parti du député correspondant.</para>
    /// labels<para>aPourParti</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/aPourParti">http://data.lirmm.fr/ontologies/oan/aPourParti</seealso>
    let aPourParti = Prefixed_Name(oan, "aPourParti") |> PrefixedName
    /// <summary>
    ///   <para>oan:alineaNumero</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "alineaNumero" représente le numéro d'un alinéa.</para>
    /// labels<para>alineaNumero</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/alineaNumero">http://data.lirmm.fr/ontologies/oan/alineaNumero</seealso>
    let alineaNumero = Prefixed_Name(oan, "alineaNumero") |> PrefixedName

    /// <summary>
    ///   <para>oan:amendementCorrespond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "amendementCorrespond" représente le texte de loi correspondant à un amendement.</para>
    /// labels<para>amendementCorrespond</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/amendementCorrespond">http://data.lirmm.fr/ontologies/oan/amendementCorrespond</seealso>
    let amendementCorrespond =
        Prefixed_Name(oan, "amendementCorrespond") |> PrefixedName

    /// <summary>
    ///   <para>oan:articleCorrespond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "articleCorrespond" représente l'article correspondant à une loi.</para>
    /// labels<para>articleCorrespond</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/articleCorrespond">http://data.lirmm.fr/ontologies/oan/articleCorrespond</seealso>
    let articleCorrespond = Prefixed_Name(oan, "articleCorrespond") |> PrefixedName
    /// <summary>
    ///   <para>oan:auteurAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "auteurAmendement" représente le député qui est l'origine de l'amendement.</para>
    /// labels<para>auteurAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/auteurAmendement">http://data.lirmm.fr/ontologies/oan/auteurAmendement</seealso>
    let auteurAmendement = Prefixed_Name(oan, "auteurAmendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:chapitreContient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "chapitreContient" représente les différentes sections qui sont contenus dans un chapitre.</para>
    /// labels<para>chapitreContient</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/chapitreContient">http://data.lirmm.fr/ontologies/oan/chapitreContient</seealso>
    let chapitreContient = Prefixed_Name(oan, "chapitreContient") |> PrefixedName
    /// <summary>
    ///   <para>oan:dansSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dansSection" indique dans quel section du texte de loi se trouve l'article.</para>
    /// labels<para>dansSection</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dansSection">http://data.lirmm.fr/ontologies/oan/dansSection</seealso>
    let dansSection = Prefixed_Name(oan, "dansSection") |> PrefixedName
    /// <summary>
    ///   <para>oan:dansSousSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dansSousSection" indique dans quel sous section du texte de loi se trouve l'article.</para>
    /// labels<para>dansSousSection</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dansSousSection">http://data.lirmm.fr/ontologies/oan/dansSousSection</seealso>
    let dansSousSection = Prefixed_Name(oan, "dansSousSection") |> PrefixedName
    /// <summary>
    ///   <para>oan:datePresence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "datePresence" représente la date à laquelle a été faite la présence.</para>
    /// labels<para>datePresence</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/datePresence">http://data.lirmm.fr/ontologies/oan/datePresence</seealso>
    let datePresence = Prefixed_Name(oan, "datePresence") |> PrefixedName
    /// <summary>
    ///   <para>oan:dateRapport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dateRapport" représente la date à laquel le rapport a été créé.</para>
    /// labels<para>dateRapport</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateRapport">http://data.lirmm.fr/ontologies/oan/dateRapport</seealso>
    let dateRapport = Prefixed_Name(oan, "dateRapport") |> PrefixedName
    /// <summary>
    ///   <para>oan:dateSeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dateSeance" représente la date à laquelle à lieu une séance d'un quelconque organisme.</para>
    /// labels<para>dateSeance</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateSeance">http://data.lirmm.fr/ontologies/oan/dateSeance</seealso>
    let dateSeance = Prefixed_Name(oan, "dateSeance") |> PrefixedName
    /// <summary>
    ///   <para>oan:deputeIntervenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "deputeIntervenant" représente le député qui est l'auteur de l'intervention.</para>
    /// labels<para>deputeIntervenant</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/deputeIntervenant">http://data.lirmm.fr/ontologies/oan/deputeIntervenant</seealso>
    let deputeIntervenant = Prefixed_Name(oan, "deputeIntervenant") |> PrefixedName
    /// <summary>
    ///   <para>oan:exposeArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "exposeArticle" représente un petit résumé de l'article.</para>
    /// labels<para>exposeArticle</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/exposeArticle">http://data.lirmm.fr/ontologies/oan/exposeArticle</seealso>
    let exposeArticle = Prefixed_Name(oan, "exposeArticle") |> PrefixedName
    /// <summary>
    ///   <para>oan:heureDebutSeance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "heureDebutSeance" représente l'heure à laquelle débute une séance.</para>
    /// labels<para>heureDebutSeance</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/heureDebutSeance">http://data.lirmm.fr/ontologies/oan/heureDebutSeance</seealso>
    let heureDebutSeance = Prefixed_Name(oan, "heureDebutSeance") |> PrefixedName
    /// <summary>
    ///   <para>oan:legislatureQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "legislatureQuestion" représente la législature sous laquelle la question écrite à été émise.</para>
    /// labels<para>legislatureQuestion</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/legislatureQuestion">http://data.lirmm.fr/ontologies/oan/legislatureQuestion</seealso>
    let legislatureQuestion = Prefixed_Name(oan, "legislatureQuestion") |> PrefixedName
    /// <summary>
    ///   <para>oan:motifRetrait</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "motifRetrait" représente le motif pour lequel la question écrite a été supprimé.</para>
    /// labels<para>motifRetrait</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/motifRetrait">http://data.lirmm.fr/ontologies/oan/motifRetrait</seealso>
    let motifRetrait = Prefixed_Name(oan, "motifRetrait") |> PrefixedName
    /// <summary>
    ///   <para>oan:nomOrganisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "nomOrganisme" représente le nom d'un organisme.</para>
    /// labels<para>nomOrganisme</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/nomOrganisme">http://data.lirmm.fr/ontologies/oan/nomOrganisme</seealso>
    let nomOrganisme = Prefixed_Name(oan, "nomOrganisme") |> PrefixedName
    /// <summary>
    ///   <para>oan:numeroArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "numeroArticle" représente le numéro d'un article.</para>
    /// labels<para>numeroArticle</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numeroArticle">http://data.lirmm.fr/ontologies/oan/numeroArticle</seealso>
    let numeroArticle = Prefixed_Name(oan, "numeroArticle") |> PrefixedName
    /// <summary>
    ///   <para>oan:numeroQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "numeorQuestion" représente le numéro de la question écrite.</para>
    /// labels<para>numeroQuestion</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/numeroQuestion">http://data.lirmm.fr/ontologies/oan/numeroQuestion</seealso>
    let numeroQuestion = Prefixed_Name(oan, "numeroQuestion") |> PrefixedName
    /// <summary>
    ///   <para>oan:positionDans</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "positionDans" représente la position de l'article dans un texte de loi, c'est-à-dire si il est dans une sous section, dans une section, dans un chapitre ou dans le texte tout court.</para>
    /// labels<para>positionDans</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/positionDans">http://data.lirmm.fr/ontologies/oan/positionDans</seealso>
    let positionDans = Prefixed_Name(oan, "positionDans") |> PrefixedName
    /// <summary>
    ///   <para>oan:pourMinistere</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "pourMinistere" représente le nom du ministère pour lequel la lettre a été écrite.</para>
    /// labels<para>pourMinistere</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/pourMinistere">http://data.lirmm.fr/ontologies/oan/pourMinistere</seealso>
    let pourMinistere = Prefixed_Name(oan, "pourMinistere") |> PrefixedName

    /// <summary>
    ///   <para>oan:presenceCorrespondante</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "presenceCorrespondante" représente la preuve d'une présence d'un député à une séance à la présence à cette séance.</para>
    /// labels<para>presenceCorrespondante</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/presenceCorrespondante">http://data.lirmm.fr/ontologies/oan/presenceCorrespondante</seealso>
    let presenceCorrespondante =
        Prefixed_Name(oan, "presenceCorrespondante") |> PrefixedName

    /// <summary>
    ///   <para>oan:sectionContient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "sectionContien" représente les différentes sous sections qui sont contenus dans une section.</para>
    /// labels<para>sectionContient</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/sectionContient">http://data.lirmm.fr/ontologies/oan/sectionContient</seealso>
    let sectionContient = Prefixed_Name(oan, "sectionContient") |> PrefixedName
    /// <summary>
    ///   <para>oan:sexe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "sexe" représente le sexe du député. Cette propriété a été rajouté à la super classe "foaf:Person" car c'était plus convenable de procéder de cette manière.</para>
    /// labels<para>sexe</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/sexe">http://data.lirmm.fr/ontologies/oan/sexe</seealso>
    let sexe = Prefixed_Name(oan, "sexe") |> PrefixedName
    /// <summary>
    ///   <para>oan:texteAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "texteAmendement" représente le texte de l'amendement.</para>
    /// labels<para>texteAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteAmendement">http://data.lirmm.fr/ontologies/oan/texteAmendement</seealso>
    let texteAmendement = Prefixed_Name(oan, "texteAmendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:texteContient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "texteContient" représente les différents chapitres contenu dans un texte de loi.</para>
    /// labels<para>texteContient</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteContient">http://data.lirmm.fr/ontologies/oan/texteContient</seealso>
    let texteContient = Prefixed_Name(oan, "texteContient") |> PrefixedName
    /// <summary>
    ///   <para>oan:texteIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "texteIntervention" représente le texte de l'intervention.</para>
    /// labels<para>texteIntervention</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/texteIntervention">http://data.lirmm.fr/ontologies/oan/texteIntervention</seealso>
    let texteIntervention = Prefixed_Name(oan, "texteIntervention") |> PrefixedName
    /// <summary>
    ///   <para>oan:themeQuestion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "themeQuestion" représente le thème de la question écrite émise par le député pour un ministre.</para>
    /// labels<para>themeQuestion</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/themeQuestion">http://data.lirmm.fr/ontologies/oan/themeQuestion</seealso>
    let themeQuestion = Prefixed_Name(oan, "themeQuestion") |> PrefixedName
    /// <summary>
    ///   <para>oan:titreArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "titreArticle" représente le titre d'un article.</para>
    /// labels<para>titreArticle</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/titreArticle">http://data.lirmm.fr/ontologies/oan/titreArticle</seealso>
    let titreArticle = Prefixed_Name(oan, "titreArticle") |> PrefixedName
    /// <summary>
    ///   <para>oan:typeIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "typeIntervention" représente les différents types d'intervention possible que peuvent faire les députés lors de divers séances d'un organisme quelconque.</para>
    /// labels<para>typeIntervention</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/typeIntervention">http://data.lirmm.fr/ontologies/oan/typeIntervention</seealso>
    let typeIntervention = Prefixed_Name(oan, "typeIntervention") |> PrefixedName
    /// <summary>
    ///   <para>oan:typeOrganisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "typeOrganisme" représente les différents types existant d'organismes.</para>
    /// labels<para>typeOrganisme</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/typeOrganisme">http://data.lirmm.fr/ontologies/oan/typeOrganisme</seealso>
    let typeOrganisme = Prefixed_Name(oan, "typeOrganisme") |> PrefixedName
    /// <summary>
    ///   <para>oan:aPourTexte</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "aPourTexte" représente la loi correspondant au texte de loi.</para>
    /// labels<para>aPourTexte</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/aPourTexte">http://data.lirmm.fr/ontologies/oan/aPourTexte</seealso>
    let aPourTexte = Prefixed_Name(oan, "aPourTexte") |> PrefixedName
    /// <summary>
    ///   <para>oan:amendementConcerne</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "amendementConcerne" représente l'article pour lequel a été créé l'amendement.</para>
    /// labels<para>amendementConcerne</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/amendementConcerne">http://data.lirmm.fr/ontologies/oan/amendementConcerne</seealso>
    let amendementConcerne = Prefixed_Name(oan, "amendementConcerne") |> PrefixedName

    /// <summary>
    ///   <para>oan:amendementNbFoisRectifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "amendementNbFoisRectifier" représente le nombre de fois qu'un amendement a été rectifier par l'assemblée nationale.</para>
    /// labels<para>amendementNbFoisRectifier</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/amendementNbFoisRectifier">http://data.lirmm.fr/ontologies/oan/amendementNbFoisRectifier</seealso>
    let amendementNbFoisRectifier =
        Prefixed_Name(oan, "amendementNbFoisRectifier") |> PrefixedName

    /// <summary>
    ///   <para>oan:appartientOrganisme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriétté "appartientOrganisme" représente l'organisme auquel appartient un député.</para>
    /// labels<para>appartientOrganisme</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/appartientOrganisme">http://data.lirmm.fr/ontologies/oan/appartientOrganisme</seealso>
    let appartientOrganisme = Prefixed_Name(oan, "appartientOrganisme") |> PrefixedName

    /// <summary>
    ///   <para>oan:articleCorrespondant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "articleCorrespondant" représente l'article correspondant à l'alinéa.</para>
    /// labels<para>articleCorrespondant</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/articleCorrespondant">http://data.lirmm.fr/ontologies/oan/articleCorrespondant</seealso>
    let articleCorrespondant =
        Prefixed_Name(oan, "articleCorrespondant") |> PrefixedName

    /// <summary>
    ///   <para>oan:auteurRapport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "auteurRapport" représente le député qui est l'auteur du rapport.</para>
    /// labels<para>auteurRapport</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/auteurRapport">http://data.lirmm.fr/ontologies/oan/auteurRapport</seealso>
    let auteurRapport = Prefixed_Name(oan, "auteurRapport") |> PrefixedName

    /// <summary>
    ///   <para>oan:dateCreationAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "dateCreationAmendement" représente la date à laquelle est créé l'amendement.</para>
    /// labels<para>dateCreationAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateCreationAmendement">http://data.lirmm.fr/ontologies/oan/dateCreationAmendement</seealso>
    let dateCreationAmendement =
        Prefixed_Name(oan, "dateCreationAmendement") |> PrefixedName

    /// <summary>
    ///   <para>oan:dateIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dateIntervention" représente la date à laquelle est faite l'intervention.</para>
    /// labels<para>dateIntervention</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateIntervention">http://data.lirmm.fr/ontologies/oan/dateIntervention</seealso>
    let dateIntervention = Prefixed_Name(oan, "dateIntervention") |> PrefixedName
    /// <summary>
    ///   <para>oan:dateReponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "dateReponse" représente la data à laquelle a été émise la réponse à une question écrite.</para>
    /// labels<para>dateReponse</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/dateReponse">http://data.lirmm.fr/ontologies/oan/dateReponse</seealso>
    let dateReponse = Prefixed_Name(oan, "dateReponse") |> PrefixedName
    /// <summary>
    ///   <para>oan:debutMandat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La propriété "debutMandat" représente le début du mandat d'un député.</para>
    /// labels<para>debutMandat</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/debutMandat">http://data.lirmm.fr/ontologies/oan/debutMandat</seealso>
    let debutMandat = Prefixed_Name(oan, "debutMandat") |> PrefixedName
    /// <summary>
    ///   <para>oan:deputeCorrespondant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "deputecorrespondant" représente la présence d'un député.</para>
    /// labels<para>deputeCorrespondant</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/deputeCorrespondant">http://data.lirmm.fr/ontologies/oan/deputeCorrespondant</seealso>
    let deputeCorrespondant = Prefixed_Name(oan, "deputeCorrespondant") |> PrefixedName
    /// <summary>
    ///   <para>oan:exposeAmendement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "exposeAmendement" représente un petit texte résumé de cet amendement.</para>
    /// labels<para>exposeAmendement</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/exposeAmendement">http://data.lirmm.fr/ontologies/oan/exposeAmendement</seealso>
    let exposeAmendement = Prefixed_Name(oan, "exposeAmendement") |> PrefixedName
    /// <summary>
    ///   <para>oan:finMandat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "finMandat" représente la fin du mandat d'un député.</para>
    /// labels<para>finMandat</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/finMandat">http://data.lirmm.fr/ontologies/oan/finMandat</seealso>
    let finMandat = Prefixed_Name(oan, "finMandat") |> PrefixedName
    /// <summary>
    ///   <para>oan:intervientLors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "intervientLors" représente l'intervention d'un député qui survient lors d'une séance.</para>
    /// labels<para>intervientLors</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/intervientLors">http://data.lirmm.fr/ontologies/oan/intervientLors</seealso>
    let intervientLors = Prefixed_Name(oan, "intervientLors") |> PrefixedName
    /// <summary>
    ///   <para>oan:loiCorrespondante</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "loiCorrespondante" indique à quelle loi est rataché l'alinéa.</para>
    /// labels<para>loiCorrespondante</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/loiCorrespondante">http://data.lirmm.fr/ontologies/oan/loiCorrespondante</seealso>
    let loiCorrespondante = Prefixed_Name(oan, "loiCorrespondante") |> PrefixedName
    /// <summary>
    ///   <para>oan:nbIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>La propriété "nbIntervention" représente le nombre d'interventions qu'il y a eu pour une section.</para>
    /// labels<para>nbIntervention</para></remarks>
    /// <seealso href="http://data.lirmm.fr/ontologies/oan/nbIntervention">http://data.lirmm.fr/ontologies/oan/nbIntervention</seealso>
    let nbIntervention = Prefixed_Name(oan, "nbIntervention") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ntag =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.inria.fr/nicetag/2010/09/09/voc#" "ntag"

    /// <summary>
    ///   <para>rdfs:label : Verzamelenrdfs:label : Aggregaterdfs:label : Agrégerrdfs:label : Aggregarerdfs:label : Agregar</para>
    ///   <para>rdfs:comment : Descrive l'azione che viene compiuta quando delle risorse sono aggregate attorno a una tag definita collettivamente.rdfs:comment : Describes the action that is performed whenever resources are aggregated with a collectively defined tag.rdfs:comment : Décrit l'action que l'on accomplit lorsque des ressources sont aggrégées autour d'un tag défini de manière collective.rdfs:comment : Beschrijft de handeling die verricht wordt wanneer bronnen worden bijeenverzameld onder een gezamenlijk gedefinieerde tag.rdfs:comment : Describe la acción que se realiza cuando se agregan unos recursos alrededor de una etiqueta definita colectivamente.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Aggregate">ntag:Aggregate</a>
    /// </summary>
    let Aggregate = _prefixId.prefix "Aggregate"
    /// <summary>
    ///   <para>rdfs:comment : Usato per rappresentare la realizzazione di una risorsa informazionale accessibile sul Web mediante il protocollo HTTP. La risorsa annotata è quella che generalmente provaoca l'azione di tagging. Essendo per definizione dereferenziabile, fornisce anche l'indirizzo che sarà salvato su sistemi di bookmarking come delicious, e che avrà funzione di ancoraggio per le tag. In ogni caso, la risorsa taggata non è limitata a dati accessibili sul Web (ciò che è taggato può anche essere ciò che la rappresentazione Web di una risorsa rappresenta, per esempio una risorsa non-informazionale, piuttosto che la sua rappresentazione)rdfs:comment : Utilisé pour représenter la réalisation d'une ressource informationnelle accessible sur le Web via le protocole HTTP. La ressource annotée, consultable en ligne, est celle-là même qui déclenche généralement l'acte de taguer. En quoi d'ailleurs elle est l'équivalent de la classe irw:WebRepresentation. Etant par définition déréférençable, elle fournit également l'adresse qui servira d'ancrage aux tags par l'intermédiaire du signet, selon le modèle proposé par delicious. Par contraste, la ressource taguée n'est, quant à elle, aucunement limitée à des données accessibles sur le Web (ce qui est taguée peut bien se révéler ne pas être autre chose que ce que la représentation d'un ressource représente, une ressource non-informationnelle par exemple, plutôt que cette représentation elle-même).rdfs:comment : Usado para representar la realización de un recurso informacional accesible en la Web mediante el protocolo HTTP. El recurso anotado es aquel que generalmente provoca la acción de etiquetado. Siendo por definición dereferenciable, dota tambien de la dirección que quedarà guardada en sistemas de "bookmarking" como delicious, y que tendrà una función de anclaje para las etiqueta. De todas maneras, el recurso etiquetado no se limita a los datos accesibles en la Web (aquello que es etiquetado puede ser también lo que la representación Web de un recurso representa, por ejemplo un recurso no-informacional, en lugar de su representación)rdfs:comment : Wordt gebruikt om een via het HTTP protocol op het web toegankelijke informatiebron te representeren. De bron met annototies, online beschikbaar en gelijkwaardig aan een irw:WebRepresentation, is wat aanzet tot de taghandeling. Aangezien de bron via het web toegankelijk is, is het per definitie mogelijk om ernaar te verwijzen, dus de bron levert ook het adres dat gebookmarkt kan worden en als anker voor de tags dient. Echter, de bron die getagd wordt is op geen enkele wijze beperkt tot http-toegankelijke data (wat getagd wordt is hetgen waar de web-representatie voor staat, bijvoorbeeld een non-informatie bron, en niet de representatie zelf).rdfs:comment : Used to represent the HTTP-accessible realization of an information resource on the Web. The equivalent of irw:WebRepresentation, the Annotated Resource is that which generally triggers the act of tagging. Being dereferenceable by definition, it also provides the address that will be bookmarked on delicious-like sites and work like an anchor for tags. This said, the resource being tagged is in no way limited to HTTP-accessible data (indeed, what supports an act of tagging may very well be what the Web representation represents, a non-information resource for example, instead of the Web representation itself).</para>
    ///   <para>rdfs:label : Bron met aantekeningenrdfs:label : Ressource annotéerdfs:label : Annotated resourcerdfs:label : Recurso anotadordfs:label : Risorsa annotata</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#AnnotatedResource">ntag:AnnotatedResource</a>
    /// </summary>
    let AnnotatedResource = _prefixId.prefix "AnnotatedResource"
    /// <summary>
    ///   <para>rdfs:label : Porre una domandardfs:label : Askrdfs:label : Preguntarrdfs:label : Vraag stellenrdfs:label : Poser une question</para>
    ///   <para>rdfs:comment : Beschrijft de handeling die met de tag verricht wordt als het stellen van een vraag.rdfs:comment : Describes the action that is performed with a tag by asking a question.rdfs:comment : Descrive l'azione che viene compiuta con una tag quando questa viene usata per porre una domanda.rdfs:comment : Describe la acción que se realiza con una etiqueta cuando se usa para hacer una pregunta.rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour poser une question.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Ask">ntag:Ask</a>
    /// </summary>
    let Ask = _prefixId.prefix "Ask"
    /// <summary>
    ///   <para>rdfs:label : Assertrdfs:label : Asserterrdfs:label : Asserirerdfs:label : Bevestigenrdfs:label : Afirmar</para>
    ///   <para>rdfs:comment : Describes the action that is performed with a tag whenever it is used to assert anything about a resource.rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour affirmer quoi que ce soit à propos d'une ressource.rdfs:comment : Descrive l'azione che viene svolta con una tag quando questa è utilizzata per affermare qualcosa a proposito di una risorsa.rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om iets over een bron te bevestigen.rdfs:comment : Describe la acción realizada con una tag quando esta es usada para afirmar algo sobre un recurso.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Assert">ntag:Assert</a>
    /// </summary>
    let Assert = _prefixId.prefix "Assert"
    /// <summary>
    ///   <para>rdfs:label : Azione di tagging automaticardfs:label : Auto tag actionrdfs:label : Acte de taguer automatiquerdfs:label : Geautomatiseerde taghandelingrdfs:label : Acción de etiquetado automática</para>
    ///   <para>rdfs:comment : Descrive delle tag generate e/o associate automaticamente a una risorsa da un computer.rdfs:comment : Décrit des tags générés et/ou associés automatiquement à une ressource par une machine.rdfs:comment : Describe etiquetas generadas y/o asociadas manualmente a un recurso por un ordenador.rdfs:comment : Describes tags as automatically generated and/or associated to a resource by a computer.rdfs:comment : Beschrijft tags als zijnde gegenereerd en/of automatisch met een bron geasoccieerd, door een computerprogramma.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#AutoTagAction">ntag:AutoTagAction</a>
    /// </summary>
    let AutoTagAction = _prefixId.prefix "AutoTagAction"
    /// <summary>
    ///   <para>rdfs:comment : Una colección de etiquetas generada por los usuarios de una comunidad en linea o de un servicio Web dados.rdfs:comment : Une collection de tag constituée par les utilisateurs d'une communauté ou d'un service donnés.rdfs:comment : Una collezione di tag generata dagli utenti di una comunità online o di un servizio Web dati.rdfs:comment : Een verzameling tags die gegenereerd is door een groep gebruikers van een gemeenschap of digitale dienst.rdfs:comment : A collection of tags generated by the users of a given online community or Web service.</para>
    ///   <para>rdfs:label : Colección de etiquetas comunitariardfs:label : Collection de tags communautairerdfs:label : Collezione di tag comunitariardfs:label : Community tag collectionrdfs:label : Gemeenschapstagverzameling</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#CommunityTagCollection">ntag:CommunityTagCollection</a>
    /// </summary>
    let CommunityTagCollection = _prefixId.prefix "CommunityTagCollection"
    /// <summary>
    ///   <para>rdfs:comment : Used when the sign used to tag is disambiguated.rdfs:comment : Utilisé lorsque le signe utilisé pour taguer est désambiguïsé.rdfs:comment : Usado quando el signo usado para etiquetar es desambiguado.rdfs:comment : Wordt gebruikt wanneer het teken waarmee getagd wordt gedesambigueerd is.rdfs:comment : Usato quando il segno usato per taggare è disambiguato.</para>
    ///   <para>rdfs:label : Acte de taguer avec désambigüisationrdfs:label : Azione di tagging con disambiguazionerdfs:label : Disambiguate Tag Actionrdfs:label : Taghandeling met gedisambigueerd tekenrdfs:label : Acción de etiquetado con desambiguación</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#DisambiguatedTagAction">ntag:DisambiguatedTagAction</a>
    /// </summary>
    let DisambiguatedTagAction = _prefixId.prefix "DisambiguatedTagAction"
    /// <summary>
    ///   <para>rdfs:label : Evaluarrdfs:label : Beoordelenrdfs:label : Evaluerrdfs:label : Evaluaterdfs:label : Valutare</para>
    ///   <para>rdfs:comment : Describes the action that is performed with a tag whenever it is used to give a notation, a mark of approval and disapproval, or,
    ///   more generally speaking, an evaluation.rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om een klassering, een teken van goedkeuring of afkeuring, of meer algemeen een beoordeling te geven.rdfs:comment : Descrive l'azione che si compie con una tag quando questa è usata per esprimere approvazione o disapprovazione, o, più in generale, una valutazione.rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour donner une note, marquer son approbation ou sa désapprobation ou, plus généralement, produirez une évaluation.rdfs:comment : Describe la acción que se realiza con una etiqueta cuando es usada para expresar aprobación o desaprobación o, mas en general, una evaluación.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Evaluate">ntag:Evaluate</a>
    /// </summary>
    let Evaluate = _prefixId.prefix "Evaluate"
    /// <summary>
    ///   <para>rdfs:label : Expresar un sentimientordfs:label : Exprimer un ressentirdfs:label : Esprimere un sentimentordfs:label : Gevoelens uitdrukkenrdfs:label : Express feelings</para>
    ///   <para>rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om een gevoel, emotie, etc. uit te drukken.rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour exprimer un sentiment, une émotion, etc.rdfs:comment : Descrive l'azione che si compie con una tag quando questa è usata per esprimere un sentimento, un'emozione, ecc.rdfs:comment : Describes the action that is performed with a tag whenever it is used to express a feeling, an emotion, etc.rdfs:comment : Describe la acción que se realiza con una etiqueta cuando es usada para expresar un sentimiento, una emoción, etc.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#ExpressFeelings">ntag:ExpressFeelings</a>
    /// </summary>
    let ExpressFeelings = _prefixId.prefix "ExpressFeelings"
    /// <summary>
    ///   <para>rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om vast te stellen aaan wie toegangsrechten tot een bron worden toegekend of ontzegd.rdfs:comment : Descrive l'azione che si compie con una tag quando questa è usata per definire a chi sono accordati o negati i diritti di accesso a una risorsa.rdfs:comment : Describes the action that is performed with a tag whenever it is used to define to whom access rights to a resource are granted or denied.rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour définir les personnes auxquelles sont octroyés des droits d'accès à des ressource en ligne (permission ou refus).rdfs:comment : Describe la acción que se realiza con una etiqueta cuando es usada para definir a quien son concedidos o negados derechos de acceso a un recurso..</para>
    ///   <para>rdfs:label : Accorder des droits d'accès àrdfs:label : Acordar derechos de acceso ardfs:label : Toegangsrechten verlenen aanrdfs:label : Accordare diritti di accesso ardfs:label : Give access rights to</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#GiveAccessRights">ntag:GiveAccessRights</a>
    /// </summary>
    let GiveAccessRights = _prefixId.prefix "GiveAccessRights"
    /// <summary>
    ///   <para>rdfs:label : Acte de taguer avec machine tagrdfs:label : Azione di tagging con machine tagrdfs:label : Taghandeling met machinetagrdfs:label : Acción de etiquetado con machine tagrdfs:label : Machine tag action</para>
    ///   <para>rdfs:comment : Décrit des tags dont les libellés mobilisent la syntaxe des machine tags telle qu'implémentée d'abord sur le site Flickr.com.rdfs:comment : Describes tags whose labels are using the syntax of machine tags as implemented first in Flickr.com.rdfs:comment : Describe etiquetas cuyo texto sigue la sintaxis de las machine tag como implementada en Flickr.com.rdfs:comment : Beschrijft tags waarvan de labels gebruik maken van de machine-tag syntaxis, zoals voor het eerst geimplementeerd op flickr.com.rdfs:comment : Descrive delle tag il cui testo segue la sintassi delle machine tag come implementata su Flickr.com.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#MachineTagAction">ntag:MachineTagAction</a>
    /// </summary>
    let MachineTagAction = _prefixId.prefix "MachineTagAction"
    /// <summary>
    ///   <para>rdfs:label : Azione di tagging manualerdfs:label : Handmatige taghandelingrdfs:label : Acción de etiquetado manualrdfs:label : Manual tag actionrdfs:label : Acte de taguer manuel</para>
    ///   <para>rdfs:comment : Descrive delle tag associate manualmente a una risorsa da un essere umano.rdfs:comment : Describes tags as manually associated to a resource by a human.rdfs:comment : Describe etiquetas asociadas manualmente a un recurso por un ser humano.rdfs:comment : Décrit des tags associés manuellement à une ressource par un être humain.rdfs:comment : Beschrijft tags als handmatig met een bron geasssocieerd door een mens</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#ManualTagAction">ntag:ManualTagAction</a>
    /// </summary>
    let ManualTagAction = _prefixId.prefix "ManualTagAction"
    /// <summary>
    ///   <para>rdfs:label : Azione di tagging con una tag n-dimensionalerdfs:label : Acte de taguer avec un tag à n-dimensionsrdfs:label : Taghandeling met n-tuplerdfs:label : Acción de etiquetado con una etiqueta n-dimensionalrdfs:label : N-tuple tag action</para>
    ///   <para>rdfs:comment : Utilisé pour décrire des actes de taguer impliquant des tags dont les libellés ont n-dimensions (double tags, triple tags, etc.).rdfs:comment : Descrive azioni di tagging basate su tag n-dimensionali (doppie tag, triple tag, ecc.).rdfs:comment : Describes tagging involving N-tuple tags (double tags, triple tags, etc.).rdfs:comment : Describe acciones de etiquetado que incluyan etiquetas n-dimensionales (etiquetas dobles, triples, etc.).rdfs:comment : Wordt gebruikt om taghandelingen te beschrijven waarbij de labels meerdere (n) dimensies kunnen hebben (dubbele tags, driedubbele tags, etc.).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagAction">ntag:N-TupleTagAction</a>
    /// </summary>
    let N_TupleTagAction = _prefixId.prefix "N-TupleTagAction"
    /// <summary>
    ///   <para>rdfs:label : N-tuple tag action with machine tag syntaxrdfs:label : Azione di tagging con una tag a n-dimensionale e sintassi delle machine tagrdfs:label : Acción de etiquetado con una etiqueta n-dimensional y sintaxis de las machine tagsrdfs:label : Taghandeling met een n-tuple met machinetag syntaxisrdfs:label : Acte de taguer avec un tag à n-dimensions et syntaxe de machine tags</para>
    ///   <para>rdfs:comment : Utilisé pour décrire un acte de taguer impliquant des tags dont les libellés ont n-dimensions et suivent la syntaxe des machine tags mais dans un contexte où des APIs semblables à celle de Flickr font défaut.rdfs:comment : Descrive azioni di tagging basate su tag n-dimensionali che seguono la sintassi delle machine tag, ma in un contesto dove mancano API simili a quelle di Flickr.rdfs:comment : Describes tagging involving N-tuple tags which follow machine tags typed syntax in acontext where Flickr-like APIs are lacking.rdfs:comment : Wordt gebruikt om een taghandeling te beschrijven wanneer de labels meerdere dimensies hebben en machinetag syntaxis volgen, maar er geen Flickr-gelijkende API besachikbaar is.rdfs:comment : Describe acciones de etiquetado basadas en etiquetas n-dimensionales que siguen la sintaxis de las machine tag, pero en un contexto en el que faltan API parecidas a las de Flickr.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagActionMTS">ntag:N-TupleTagActionMTS</a>
    /// </summary>
    let N_TupleTagActionMTS = _prefixId.prefix "N-TupleTagActionMTS"
    /// <summary>
    ///   <para>rdfs:comment : Utilisé pour décrire un acte de taguer accompli par le propriétaire de l'URI qui identifie la ressource taguée.rdfs:comment : Usato per descrivere un'azione di tagging svolta dal proprietario dell'URI che identifica la risorsa taggata.rdfs:comment : Used to describe an act of tagging performed by the owner of the URI that identifies the tagged resource.rdfs:comment : Beschrijft een taghandeling verricht door de eigenaar van de URI waarmee de getagde bron geïdentificeerd wordt.rdfs:comment : Usado para describir una acción de etiquetado realizada por el propietario del URI que identifica el recurso etiquetado.</para>
    ///   <para>rdfs:label : Owner tag actionrdfs:label : Acción de etiquetado del propietariordfs:label : Taghandeling eigenaarrdfs:label : Azione di tagging del proprietariordfs:label : Acte de taguer d'un propriétaire</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#OwnerTagAction">ntag:OwnerTagAction</a>
    /// </summary>
    let OwnerTagAction = _prefixId.prefix "OwnerTagAction"
    /// <summary>
    ///   <para>rdfs:comment : Usato per rappresentare la parte della rappresentazione di una risorsa Web quando si è fatto uso dell'atto di tagging "Point".rdfs:comment : Utilisé pour représenter la partie de la représentation d'une ressource qui est taguée lorsque qu'il est fait usage de l'acte de taguer "Pointer".rdfs:comment : Used to represent the part of the Web representation resource being tagged after the "Point" TagAction is used.rdfs:comment : Wordt gebruikt om het getagde deel van een web-representatie aan te geven wanneer gebruikt is gemaakt van de "Aanwijs" taghandeling.rdfs:comment : Usado para representar la parte de la representación de un recurso Web quando se ha hecho uso del acto de etiquetado "Point".</para>
    ///   <para>rdfs:label : Onderdeel van de representatie van een bron op het webrdfs:label : Part Of Web representationrdfs:label : Partie de la représentation d'une ressource sur le Webrdfs:label : Parte della rappresentazione di una risorsa Webrdfs:label : Parte de la representación de un recurso en la Web</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#PartOfWebRepresentation">ntag:PartOfWebRepresentation</a>
    /// </summary>
    let PartOfWebRepresentation = _prefixId.prefix "PartOfWebRepresentation"
    /// <summary>
    ///   <para>rdfs:comment : Une collection de tags constituée par un utilisateur précis.rdfs:comment : A collection of tags generated by a single user.</para>
    ///   <para>rdfs:label : Persoonlijke tagverzamelingrdfs:label : Colección de etiquetas personalrdfs:label : Collezione di tag personalerdfs:label : Collection de tags personnellerdfs:label : Personal tag collection</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#PersonalTagCollection">ntag:PersonalTagCollection</a>
    /// </summary>
    let PersonalTagCollection = _prefixId.prefix "PersonalTagCollection"
    /// <summary>
    ///   <para>rdfs:label : Pointrdfs:label : Puntarerdfs:label : Pointerrdfs:label : Puntarrdfs:label : Aanwijzen</para>
    ///   <para>rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour faire référence à une portion spécifique de la représentation
    ///  d'une ressource sur le Web (le segment d'une vidéo, un commentaire produit par les utilisateurs au pied d'un article, etc.).rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om naar een specifiek deel van een web-representatie te verwijzen (een segment van een video, een door een gebruiker gegenereerd commentaar bij een krantenartikel, etc.).rdfs:comment : Descrive l'azione che si compie con una tag quando questa è usata per fare riferimento a una parte specifica della rappresentazione di una risorsa Web (il segmento di un video, il commento generato dagli utenti a un articolo di un quotidiano, ecc.).rdfs:comment : Describe la acción que se realiza con una etiqueta cuando es usada para referirse a una parte específica de un recurso Web (el segmento de un video, comentarios generados por los usuarios a un artículo de periódico).rdfs:comment : Describes the action that is performed with a tag whenever it is used to point to a specific part of a Web representation (the segment of a video,
    ///   a user-generated commentary to a newspaper article, etc.).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Point">ntag:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Définir une tâcherdfs:label : Taak definiërenrdfs:label : Definir una tareardfs:label : Definire un compitordfs:label : Set task</para>
    ///   <para>rdfs:comment : Décrit l'action que l'on accomplit avec un tag de type "àfaire" dès lors que celui-ci est utilisé pour définir une tâche attendant sa réalisation.rdfs:comment : Describe la acción que se realiza con una etiqueta de tipo "quehacer" cuando es usada para crear una tarea en espera de realización.rdfs:comment : Describes the action that is performed with a "todo" tag whenever it is used to create a task awaiting performance.rdfs:comment : Descrive l'azione che si compie con una tag di tipo "dafare", quando questa è usata per creare un compito in attesa di realizzazione.rdfs:comment : Beschrijft de handeling die verricht wordt met een tag van het type “te doen” wanneer deze gebruikt wordt om een taak te maken in afwachting van haar realisatie.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#SetTask">ntag:SetTask</a>
    /// </summary>
    let SetTask = _prefixId.prefix "SetTask"
    /// <summary>
    ///   <para>rdfs:comment : Describe la acción que se realiza con una etiqueta cuando es usada para compartir la representación de un recurso  en un servicio Web, por ejemplo Delicious o Twitter, con el titular de una cuenta en este servicio (sioc:UserAccount, que no es necesariamente una foaf:Person, porqué puede ser también un robot o una institución cuyos representantes pueden variar en el tiempo.rdfs:comment : Describes the action that is performed with a tag whenever it is used to share the representation of a WebResource on various services - Twitter or Delicious for instance - with the owner of a sioc:UserAccount (not necessarily a foaf:Person as it might be either a bot, a person or an institution whose representatives may well vary over time).rdfs:comment : Descrive l'azione che si compie con una tag quando questa è usata per condividere la rappresentazizone di una risorsa su uno specifico servizio Web, per esempio Delicious o Twitter, con il titolare di un account su tale servizio (sioc:UserAccount, che non è necessariamente una foaf:Person, ma può trattarsi anche di un robot, o di una istituzione i cui rappresentanti possono variare nel tempo).rdfs:comment : Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om de representatie van een bron op het web te delen met een gebruiker van een dienst als Twitter of Delicious. (sioc:UserAccount, wat niet per se een foaf:Person is aangezien het ook om een bot kan gaan of een instelling die met het verlopen van de tijd door verschillende personen vertegenwoordigd kan worden).rdfs:comment : Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour partager une représentation d'une ressource sur le Web, notamment sur Delicious ou Twitter. Ce partage ne se fait pas nécessairement avec une autre personne mais plutôt avec le  titulaire d'un compte sur l'un ou l'autre de ces services (sioc:UserAccount, qui n'est pas nécessairement une foaf:Person étant donné qu'il peut s'agir aussi bien d'un robot, d'une personne ou encore d'une institution dont les représentants sont potentiellement amenés à varier au fil du temps).</para>
    ///   <para>rdfs:label : Condividererdfs:label : Compartirrdfs:label : Partagerrdfs:label : Sharerdfs:label : Delen</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#Share">ntag:Share</a>
    /// </summary>
    let Share = _prefixId.prefix "Share"
    /// <summary>
    ///   <para>rdfs:label : Acción de etiquetado sintácticardfs:label : Azione di tagging sintatticardfs:label : Acte de taguer syntaxiquerdfs:label : Syntactische taghandelingrdfs:label : Syntactic Tag Action</para>
    ///   <para>rdfs:comment : Describes tags whose labels are following a given syntax for improved precision and tractability.rdfs:comment : Describe etiquetas cuyo texto sigue una sintaxis determinada para una mayor precisión y tratabilidad.rdfs:comment : Décrit des tags dont les libellés mobilisent une certaine syntaxe pour accroître leur précision et leur capacité à être manipulés.rdfs:comment : Descrive delle tag il cui testo segue una sintassi determinata per ottenere maggiore precisione e trattabilità.rdfs:comment : Beschrijft tags waarvan de labels van een bepaalde syntaxis gebruik maken om de precisie en manipuleerbaarheid te vergroten.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#SyntacticTagAction">ntag:SyntacticTagAction</a>
    /// </summary>
    let SyntacticTagAction = _prefixId.prefix "SyntacticTagAction"
    /// <summary>
    ///   <para>rdfs:label : Acte de taguerrdfs:label : Taghandelingrdfs:label : Acción de etiquetadordfs:label : Tag actionrdfs:label : Azione di tagging</para>
    ///   <para>rdfs:comment : A super class to describe every tag action as modelled by a named graph according to RDF Graph model (RDFG).rdfs:comment : Une super-classe qui permet de décrire et de modéliser les actes de taguer à l'aide d'un graphe nommé et au moyen du modèle de graphe RDF (RDFG).rdfs:comment : Een overkoepelende categorie die toestaat elke taghandeling te beschrijving als een gelabelde graaf binnen het RDF graph model (RDFG).rdfs:comment : Una super-clase que permite describir y modelar cada acción de etiquetado utilizando un named graph según el modelo del grafo RDF (RDFG).rdfs:comment : Una super-classe che permette di descrivere e di modellare ogni azione di tagging con un named graph secondo il modello del grafo RDF (RDFG).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#TagAction">ntag:TagAction</a>
    /// </summary>
    let TagAction = _prefixId.prefix "TagAction"
    /// <summary>
    ///   <para>rdfs:comment : Una generica collezione di tag.rdfs:comment : Undefined collection of tags.rdfs:comment : Une collection de tags ne répondant à aucune définition particulière.rdfs:comment : Een verzameling tags zonder verdere specifieke definitie.rdfs:comment : Una genérica colección de etiquetas.</para>
    ///   <para>rdfs:label : Tagverzamelingrdfs:label : Collection de tagsrdfs:label : Tag collectionrdfs:label : Colección de etiquetasrdfs:label : Collezione di tag</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#TagCollection">ntag:TagCollection</a>
    /// </summary>
    let TagCollection = _prefixId.prefix "TagCollection"
    /// <summary>
    ///   <para>rdfs:comment : Usado para representar el recurso etiquetado. Equivalente a irw:Resource.rdfs:comment : Wordt gebruikt als representatie van de bron die getagd wordt.rdfs:comment : Usato per rappresentare la risorsa taggata. Equivalente di irw:Resource.rdfs:comment : Used to represent the resource being tagged. Equivalent of irw:Resource.rdfs:comment : Utilisé pour représenter la ressource taguée. Equivalent de irw:Resource.</para>
    ///   <para>rdfs:label : Risorsa taggatardfs:label : Ressource taguéerdfs:label : Getagde bronrdfs:label : Tagged resourcerdfs:label : Recurso etiquetado</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#TaggedResource">ntag:TaggedResource</a>
    /// </summary>
    let TaggedResource = _prefixId.prefix "TaggedResource"
    /// <summary>
    ///   <para>rdfs:label : Acción de etiquetado de un visitanterdfs:label : Visitor tag actionrdfs:label : Azione di tagging di un visitatorerdfs:label : Acte de taguer d'un visiteurrdfs:label : Taghandeling bezoeker</para>
    ///   <para>rdfs:comment : Usado para describir una acción de etiquetado realizada por una persona que ha tenido acceso a la representación de un recurso en la Web.rdfs:comment : Utilisé pour décrire l'acte de taguer accompli par une personne ayant eu accès à la représentation d'une ressource sur le Web.rdfs:comment : Beschrijft een taghandeling verricht door een bezoeker van de web-representatie van een bron.rdfs:comment : Used to describe an act of tagging performed by a the person who browsed a Web representation.rdfs:comment : Usato per descrivere un'azione di tagging svolta da una persona che ha avuto accesso alla rappresentazione di una risorsa Web.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#VisitorTagAction">ntag:VisitorTagAction</a>
    /// </summary>
    let VisitorTagAction = _prefixId.prefix "VisitorTagAction"
    /// <summary>
    ///   <para>rdfs:label : Acción de etiquetado con Web conceptrdfs:label : Azione di tagging con Web conceptrdfs:label : Taghandeling met webconceptrdfs:label : Web concept tag actionrdfs:label : Acte de taguer par concept Web</para>
    ///   <para>rdfs:comment : Usata per descrivere un'azioni di tagging effettuata con l'aiuto di un concetto Web (per esempio geonames).rdfs:comment : Wordt gebruikt om taghandelingen te beschrijven waarbij gebruikt gemaakt woord van webconcepten (zoals geonames).rdfs:comment : Usada para describir una acción de etiquetado realizada con la ayuda de un concepto Web (por ejemplo geonames).rdfs:comment : Describes tagging involving Web concepts (such as geonames).rdfs:comment : Utilisé pour décrire un taggage effectué à l'aide de concepts Web (tels que geonames).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#WebConceptTagAction">ntag:WebConceptTagAction</a>
    /// </summary>
    let WebConceptTagAction = _prefixId.prefix "WebConceptTagAction"
    /// <summary>
    ///   <para>rdfs:comment : Propriedad usada para asociar una singola acción de etiquetado a una colección de etiquetas, con el objetivo de dar cuenta de los diferentes niveles de agregación proporcionados por los servicios de etiquetado existentes. Hay varias maneras de agregar la etiquetas (por ejemplo, http://delicious.com/fabion_gandon/OWL permite de acceder a una reppresentación de todas las acciones de etiquetado realizadas por el titular de la cuenta "fabien_gandon", en las cuales aparece la etiqueta "OWL" en del.icio.us.com en un instante "t").rdfs:comment : Proprietà usata per associare una singola azione di tagging a una collezione di tag, con lo scopo di rendere conto dei vari livelli di aggregazione forniti dai servizi di tagging esistenti. Ci sono vari modi di aggregare delle tag (per esempio, http://delicious.com/fabion_gandon/OWL permette di accedere a una rappresentazione di tutte le azioni di tagging svolte dal titolare dell'account "fabien_gandon", nelle quali compare la tag "OWL" su del.icio.us.com in un istante "t").rdfs:comment : Eigenschap die gebruikt wordt om een enkelvoudige taghandeling te koppelen aan een tagverzameling, zo rekenschap gevende van de verschillende niveaus waarop veelgebruikte tagdiensten tags bijeenverzamelen (http://delicious.com/fabion_gandon/OWL bijvoorbeeld, geeft een webrepresentatie van alle taghandelingen van de gebruiker "fabian_gandon" waar op een moment "t" het label "OWL" is gebruikt).rdfs:comment : Propriété employée pour associer un acte de taguer singulier à une collection de tags. Ceci sert à rendre compte des multiples manières d'aggréger les tags offertes par les différents services existants (l'URI http://delicious.com/fabion_gandon/OWL permet par exemple d'accéder à une représentation de tous les actes de taguer accomplis par le titulaire du compte "fabien_gandon" où figure le libellé "OWL" sur delicious.com à un instant "t").rdfs:comment : Property used to link a single and well individuated TagAction to a TagCollection to account for the various levels of aggregation provided by common tagging applications. There exist different ways to aggregate tags (for instance, http://delicious.com/fabion_gandon/OWL gives a Web representation of all taggings of user "fabien_gandon" involving the tag labeled 'OWL' on delicious.com at time "t").</para>
    ///   <para>rdfs:label : Appartient à une collection de tagsrdfs:label : Pertenece a una colección de etiquetasrdfs:label : Belongs to tag collectionrdfs:label : Appartiene a una collezione di tagrdfs:label : Behoort toe aan tagverzameling</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#belongsToTagCollection">ntag:belongsToTagCollection</a>
    /// </summary>
    let belongsToTagCollection = _prefixId.prefix "belongsToTagCollection"
    /// <summary>
    ///   <para>rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie toegangsrechten tot de getagde bron worden toegekend.rdfs:comment : Property used when the label of a tag indicates to whom access rights to the tagged resource are conferred.rdfs:comment : Corresponde al uso de etiquetas cuyo contenido indica el destinatario al cual vienen conferidos derechos de acceso a un recurso.rdfs:comment : Corrisponde all'uso di tag il cui contenuto indica il destinatario a cui vengono conferiti diritti di accesso a una risorsa.rdfs:comment : Corresponds à l'utilisation de tags dont le libellé indique le destinataire auquel des droits d'accès définis sur une ressource donnée ont été octroyés.</para>
    ///   <para>rdfs:label : Puede ser leído porrdfs:label : Può essere letto dardfs:label : Can be read byrdfs:label : Kan gelezen worden doorrdfs:label : Peut être lu par</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#canBeReadBy">ntag:canBeReadBy</a>
    /// </summary>
    let canBeReadBy = _prefixId.prefix "canBeReadBy"
    /// <summary>
    ///   <para>rdfs:label : Kan niet gelezen worden doorrdfs:label : Cannot be read byrdfs:label : Non può essere letto dardfs:label : No puede ser leído porrdfs:label : Ne peut être lu par</para>
    ///   <para>rdfs:comment : Proprietà usata quando il contenuto di una tag indica il destinatario a cui sono negati diritti di accesso a una risorsa.rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie de toegangsrechten tot de getagde bron worden ontzegd.rdfs:comment : Propriété utilisée quand le libellé d'un tag indique le destinataire auquel des droits d'accès définis sur une ressource donnée ont été déniés.rdfs:comment : Property used when the label of a tag indicates to whom access right to the tagged resource are denied.rdfs:comment : Propriedad usada cuando el contenido de una etiqueta indica el destinatario al cual se han negado derechos de acceso a un  recurso.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#cannotBeReadBy">ntag:cannotBeReadBy</a>
    /// </summary>
    let cannotBeReadBy = _prefixId.prefix "cannotBeReadBy"
    /// <summary>
    ///   <para>rdfs:comment : Propriété utilisée quand une ressource suscite l'accomplissement d'une action.rdfs:comment : Propriedad usada cuando un recurso suscita la realización de una acción.rdfs:comment : Property used when a resource elicits an action to be performed.rdfs:comment : Proprietà usata quando una risorsa suscita lo svolgimento di un'azione.rdfs:comment : Eigenschap die gebruikt wordt wanneer een bron aanzet tot het verrichten van een handeling.</para>
    ///   <para>rdfs:label : Elicits actionrdfs:label : Suscita l'azionerdfs:label : Ontlokt de handelingrdfs:label : Suscita la acciónrdfs:label : Suscite l'action</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#elicitsAction">ntag:elicitsAction</a>
    /// </summary>
    let elicitsAction = _prefixId.prefix "elicitsAction"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to uses of collectively approved labels shared inside a community.rdfs:comment : Corresponde al uso de etiquetas elegidas por una comunidad.rdfs:comment : Komt overeen met collectief afgestemd gebruik van door een gemeenschap gekozen labels.rdfs:comment : Corrisponde all'uso di tag scelte da una comunità.rdfs:comment : Correspond à des usages collectivement constitués de libellés choisis par une communauté.</para>
    ///   <para>rdfs:label : Has community signrdfs:label : A pour signe collectifrdfs:label : Ha segno collettivordfs:label : Heeft een gemeenschappelijk tekenrdfs:label : Tiene signo colectivo</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasCommunitySign">ntag:hasCommunitySign</a>
    /// </summary>
    let hasCommunitySign = _prefixId.prefix "hasCommunitySign"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà usata quando il contenuto di una tag indica il medium a cui appartiene la rappresentazione Web della risorsa a cui si accede ("forum", "vidéo", "photo", "pagina Web", "Webservice", etc.).rdfs:comment : Propriété utilisée quand le libellé d'un tag indique de quel média la représentation de la ressource à laquelle on accède ressortit ("forum", "vidéo", "photo", "page Web", "Webservice", etc.).rdfs:comment : Property used when the label of a tag indicates the medium which an HTTP-accessible Web representation belongs to ("forum", "video", "photo", "Webpage", "Webservice", etc.).rdfs:comment : Propriedad usada cuando el contenido de una etiqueta indica el medium al que pertenece la representación Web del recurso al cual se accede ("forum", "video", "foto", "página Web", "Webservice", etc.).rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft tot welk medium een via het web toegankelijke representatie behoort ("forum", "video", "foto", "webpagina", "webdienst", etc.)</para>
    ///   <para>rdfs:label : Est un medium de typerdfs:label : Has for mediumrdfs:label : È un medium di tipordfs:label : Es un medium de tipordfs:label : Is het medium</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasForMedium">ntag:hasForMedium</a>
    /// </summary>
    let hasForMedium = _prefixId.prefix "hasForMedium"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà usata quando il contenuto di una tag indica quale parte della rappresentazione di una risorsa su Web è taggata.rdfs:comment : Property used when the label of a tag indicates which part of a Web representation is being tagged.rdfs:comment : Propriété utilisée quand le libellé d'un tag indique quelle partie de la représentation d'une ressource sur le Web est taguée.rdfs:comment : Propriedad usada cuando el contenido de una etiqueta indica que parte de la representación de un recurso en la Web ha sido etiquetada.rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft welk gedeelte van een web-representatie getagd wordt.</para>
    ///   <para>rdfs:label : A pour partierdfs:label : Has partrdfs:label : Ha come parterdfs:label : Heeft als deelrdfs:label : Tiene como parte</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasPart">ntag:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : Corresponde al uso de etiquetas definidas por el usuario, que pueden servir para recoger, categorizar o distinguir etiquetas, o para estructurar su propria colección de etiquetas .rdfs:comment : Correspond à l'emploi de libellés définis par un utilisateur pour rassembler, catégoriser ou distinguer des ressources voire simplement structurer sa propre collection de tags.rdfs:comment : Corresponds to uses of user-defined labels that can either serve to gather, categorize, distinguish resources or simply add structure to one's collection of tags.rdfs:comment : Corrisponde all'uso di tag definite dall'utente che possono servire per raccogliere, categorizzare o distinguere risorse, oppure semplicemente per strutturare la propria collezione di tag.rdfs:comment : Komt overeen met het gebruik van persoonlijk gedefinieerde labels die tot doel hebben bronnen te verzamelen, categoriseren en onderscheiden, of die simpelweg een verzameling tags structureren.</para>
    ///   <para>rdfs:label : Heeft een persoonlijk tekenrdfs:label : Ha segno personalerdfs:label : Has personal signrdfs:label : Tiene signo personalrdfs:label : A pour signe personnel</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasPersonalSign">ntag:hasPersonalSign</a>
    /// </summary>
    let hasPersonalSign = _prefixId.prefix "hasPersonalSign"
    /// <summary>
    ///   <para>rdfs:comment : Property used when the label of a tag describes the topic of a resource.rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag het thema van een bron beschrijft.rdfs:comment : Proprietà usata quando il contenuto di una tag descrive il tema di una risorsa.rdfs:comment : Propriété utilisé pour indiquer que le libellé d'un tag décrit le thème d'une ressource.rdfs:comment : Propriedad usada cuando el contenido de una etiqueta describe el tema de un recurso.</para>
    ///   <para>rdfs:label : Is aboutrdfs:label : A pour thèmerdfs:label : Ha come temardfs:label : Tiene como temardfs:label : Betreft</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isAbout">ntag:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : Está relacionado conrdfs:label : È connesso conrdfs:label : Est relié àrdfs:label : Is related tordfs:label : Houdt verband met</para>
    ///   <para>rdfs:comment : Wordt gebruikt om een bron met een teken te verbinden. Dit teken kan om het even welk type zijn zolang de representatie toegankelijk is via een URI over HTTP. NiceTag definieert tags door een eigenschap die twee bronnen verbindt. Toch kunnen veel van de onderscheiden die te vinden zijn in de IRW ontologie gebruikt worden om een meer precies beeld te krijgen van nt:TaggedResource (in het bijzonder de klasse irw:Resource).rdfs:comment : Usato per associare una risorsa a un segno che può essere, di per sè, di qualsiasi tipo, purchè la sua rappresentazione, identificata da un URI, sia accessibile tramite il protocollo HTTP. NiceTag definisce le tag per mezzo di una proprietà che associa due risorse; l'ontologia IRW permette di comprendere più precisamente il significato di nt:TaggedResource (in particolare la classe irw:Resource).rdfs:comment : Used to link a resource to a sign, which can itself, be of any type, provided its representation is HTTP accessible from a URI. NiceTag defines tags by means of a mere property linking two Resources; this said, the many distinctions found in IRW ontology give a more precise account of nt:TaggedResource (see in particular irw:Resource).rdfs:comment : Utilisé pour lier une ressource à un signe qui, lui-même, peut être de n'importe quel type pourvu que sa représentation, identifiée par une URI, soit accessible via le protocole HTTP. NiceTag définit les tags au moyen d'une propriété qui relie deux Resource; toutefois, l'ontologie IRW permet de comprendre plus précisément la signification de nt:TaggedResource (en particulier la classe irw:Resource).rdfs:comment : Usado para asociar un recurso a un signo que puede ser, en sí mismo, de qualquier tipo, con tal que su representación, identificada por un URI, sea accesible mediante el protocolo HTTP. NiceTag define las etiquetas por medio de una propiedad que asocia dos recursos; la ontologia IRW permite comprender con mas claridad el significaso de nt:taggedResources(en especiàl la clase irw:Resource).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelatedTo">ntag:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : Propriété utilisée pour subsumer "isRelevantToSb" et "isRelevantToSt".rdfs:comment : Proprietà usata per sussumere "isRelevantToSb" e "isRelevantToSt".rdfs:comment : Eigenschap die gebruikt wordt om "isRelevantToSb" en "isRelevantToSt" onder één noemer te brengen.rdfs:comment : Property used to subsume "isRelevantToSb" and "isRelevantToSt".rdfs:comment : Propriedad usada para subsumir "isRelevantToSb" y "isRelevantToSt".</para>
    ///   <para>rdfs:label : È pertinenterdfs:label : Is relevantrdfs:label : Is relevantrdfs:label : Est pertinentrdfs:label : Es pertinente</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevant">ntag:isRelevant</a>
    /// </summary>
    let isRelevant = _prefixId.prefix "isRelevant"
    let isRelevantTo = _prefixId.prefix "isRelevantTo"
    /// <summary>
    ///   <para>rdfs:label : Is relevant to somebodyrdfs:label : Est pertinent pour quelqu'unrdfs:label : Es pertinente para alguienrdfs:label : È pertinente a qualcunordfs:label : Is relevant voor iemand</para>
    ///   <para>rdfs:comment : Subproperty of 'is relevant to' used to link a resource to the person whom it may be relevant to. In other words, in such a way that no immediate formal link can be inferred between the two except from the point of view of a precise person in addition to the user who defined the said link.rdfs:comment : Sub-propriedad de 'isRelevantTo' usada para asociar un recurso a la persona para la que puede ser pertinente, de manera que ningun enlace formal inmediato pueda ser inferido entre los dos, excepto desde el punto de vista del creador de esa asociación.rdfs:comment : Sous-propriété de 'isRelevantTo', utilisée pour associer une ressource à une personne de telle manière qu'aucun lien formel ne puisse être inféré entre les deux excepté du point de vue du destinataire et du destinateur du tag.rdfs:comment : Deeleigenschap van ‘isRelevantTo’, gebruikt om een verband tot stand te brengen tussen een bron en de persoon waar het betrekking tot kan hebben. In een zodanige vorm dat er geen onmiddelijke formele relatie tussen de twee afgeleid kan worden behalve vanuit het gezichtspunt van een specifiek persoon en de gebruiker die dit verband gelegd heeft.rdfs:comment : Sotto-proprietà di 'isRelevantTo' usata per associare una risorsa alla persona a cui può essere pertinente, in modo tale che nessun collegamento formale immediato possa essere inferito fra i due, eccetto dal punto  di vista del creatore di tale collegamento</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSb">ntag:isRelevantToSb</a>
    /// </summary>
    let isRelevantToSb = _prefixId.prefix "isRelevantToSb"
    /// <summary>
    ///   <para>rdfs:label : Is relevant to somethingrdfs:label : Es pertinente para algordfs:label : Is relevant met betrekking tot ietsrdfs:label : Est pertinent par rapport à quelque choserdfs:label : È pertinente a qualcosa</para>
    ///   <para>rdfs:comment : Subproperty of 'is relevant to', used to link a resource to anything that it may be relevant to. In other words, in such a way that no immediate formal link can be inferrend between the two except from the point of view of the creator of the said link.rdfs:comment : Sotto-proprietà di 'isRelevantTo' usata per associare una risorsa a qualsiasi cosa che possa essere pertinente, in modo che nessun collegamento formale immediato possa essere inferito fra i due, eccetto dal punto  di vista del creatore di tale collegamento.rdfs:comment : Deeleigenschap van ‘isRelevantTo’, gebruikt om een verband te leggen tussen de bron en iets anders, waarbij geen formeel verband is vast te stellen behalve vanuit het gezichtspunt van degene die dit verband legt.rdfs:comment : Sous-propriété de "isRelevantTo', utilisée pour lier quoi que ce soit à une ressource de telle manière qu'aucun lien immédiat formel ne puisse être inféré entre les deux excepté du point de vue du créateur d'un tel lien.rdfs:comment : Sub-propriedad de 'isRelevantTo' usada para asociar un recurso a qualquier cosa para la que pueda ser pertinente, de manera que ningun enlace formal inmediato pueda ser inferido entre los dos, excepto desde el punto de vista del creador de esa asociación.</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSt">ntag:isRelevantToSt</a>
    /// </summary>
    let isRelevantToSt = _prefixId.prefix "isRelevantToSt"
    /// <summary>
    ///   <para>rdfs:comment : Property used whenever a resource is evaluated, ranked, etc. thanks to a label ("***", "5/10", "0", "best", etc.).rdfs:comment : Propriedad usada para indicar que un recurso es evaluado, clasificado, etc., por medio del contenido de una etiqueta ("***", "5/10", "0", "best", etc.).rdfs:comment : Proprietà usata per indicare che una risorsa è valutata, classificata, ecc. per mezzo del contenuto di una tag ("***", "5/10", "0", "best", etc.).rdfs:comment : Propriété utilisée pour indiquer qu'une ressource est évaluée, classée, etc. à l'aide d'un libellé ("***", "5/10", "0", "le meilleur", etc.).rdfs:comment : Eigenschap die gebruikt wordt op het moment dat een een bron wordt gewaardeerd, geklassificeerd met een label ("***", "5/10", "0", "het beste", etc.).</para>
    ///   <para>rdfs:label : Ha valorerdfs:label : Is worthrdfs:label : Is waaardrdfs:label : Tiene valorrdfs:label : Vaut</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#isWorth">ntag:isWorth</a>
    /// </summary>
    let isWorth = _prefixId.prefix "isWorth"
    /// <summary>
    ///   <para>rdfs:comment : Propriété utilisée pour indiquer que le libellé d'un tag dénote/exprime une réaction émotionnelle.rdfs:comment : Property used to indicate that the label of a tag denotes/expresses an emotional reaction.rdfs:comment : Propriedad usada para indicar que el contenido de una etiqueta denota/expresa una reacción emocional.rdfs:comment : Proprietà usata per indicare che il contenuto di una tag denota/esprime una reazione emotiva.rdfs:comment : Eigenschap die gebruikt wordt om aan te geven dat het label van een tag een emotionele reactie weergeeft of uitdrukt.</para>
    ///   <para>rdfs:label : Makes me feelrdfs:label : Mi suscitardfs:label : Maakt dat ik me voelrdfs:label : Me provocardfs:label : Produit sur moi</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#makesMeFeel">ntag:makesMeFeel</a>
    /// </summary>
    let makesMeFeel = _prefixId.prefix "makesMeFeel"
    /// <summary>
    ///   <para>rdfs:comment : Propriedad usada cuando el contenido de una etiqueta indica que se esta planteando una pregunta.rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft dat een vraag gesteld wordt.rdfs:comment : Propriété utilisée quand le libellé d'un tag indique qu'une question est posée.rdfs:comment : Proprietà usata quando il contenuto di una tag indica che si sta ponendo una domanda.rdfs:comment : Property used when the label of a tag indicates that a question is being asked.</para>
    ///   <para>rdfs:label : Plantea una cuestión sobrerdfs:label : Roept vragen op overrdfs:label : Solleva una domanda surdfs:label : Soulève une interrogation au sujet derdfs:label : Raises question about</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#raisesQuestionAbout">ntag:raisesQuestionAbout</a>
    /// </summary>
    let raisesQuestionAbout = _prefixId.prefix "raisesQuestionAbout"
    /// <summary>
    ///   <para>rdfs:comment : Komt overeen met het gebruik van labels die aangeven door wie deze bron is voorgesteld.rdfs:comment : Corrisponde all'uso di tagche indicano da chi è stata suggerita una risorsa.rdfs:comment : Correspond à l'utilisation de signes qui indiquent à qui une ressource a été suggérée.rdfs:comment : Corresponds to uses of labels that indicate by whom a resource was suggested.rdfs:comment : Corresponde al uso de etiquetas que indican por quien ha sido sugerido un recurso.</para>
    ///   <para>rdfs:label : Sent byrdfs:label : Enviado porrdfs:label : Envoyé parrdfs:label : Inviato dardfs:label : Verstuurd door</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#sentBy">ntag:sentBy</a>
    /// </summary>
    let sentBy = _prefixId.prefix "sentBy"
    /// <summary>
    ///   <para>rdfs:label : Envoyé àrdfs:label : Inviato ardfs:label : Enviado ardfs:label : Sent tordfs:label : Verstuurd aan</para>
    ///   <para>rdfs:comment : Propriété utilisée quand le libellé d'un tag indique à quel utilisateur une ressource a été suggérée (modélise des fonctionalités existantes telles que les tags "for:-username" sur Delicious).rdfs:comment : Propriedad usada cuando el contenido de una etiqueta indica a que usuario un recurso ha sido sugerido (modeliza funcionalidades existentes como las etiquetas "for:usuario" en Delicious).rdfs:comment : Proprietà usata quando il contenuto di una tag indica a quale utente una risorsa è stata suggerita (modellizza funzionalità esistenti come le tag "for:utente" in Delicious).rdfs:comment : Property used when the label of a tag indicates to whom a resource was suggested (models existing features like delicious "for:-username" tags).rdfs:comment : Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie de bron is voorgesteld (modelleert bestaande functionaliteit zoals de "for:-username" tags op Delicious).</para>
    ///   <a href="http://ns.inria.fr/nicetag/2010/09/09/voc#sentTo">ntag:sentTo</a>
    /// </summary>
    let sentTo = _prefixId.prefix "sentTo"

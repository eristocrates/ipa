namespace http.ns.inria.fr.nicetag._2010._09._09.voc.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ntag =
    let _namespace_iri = Namespace_Iri ntag |> NamespaceIRI
    /// <summary>
    ///   <para>ntag:Aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the action that is performed whenever resources are aggregated with a collectively defined tag."</para>
    ///   <para>"Descrive l'azione che viene compiuta quando delle risorse sono aggregate attorno a una tag definita collettivamente."</para>
    ///   <para>"Décrit l'action que l'on accomplit lorsque des ressources sont aggrégées autour d'un tag défini de manière collective."</para>
    ///   <para>"Beschrijft de handeling die verricht wordt wanneer bronnen worden bijeenverzameld onder een gezamenlijk gedefinieerde tag."</para>
    ///   <para>"Describe la acción que se realiza cuando se agregan unos recursos alrededor de una etiqueta definita colectivamente."</para>
    /// labels<para>"Agregar"</para><para>"Agréger"</para><para>"Aggregate"</para><para>"Verzamelen"</para><para>"Aggregare"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Aggregate">http://ns.inria.fr/nicetag/2010/09/09/voc#Aggregate</seealso>
    let Aggregate = Prefixed_Name(ntag, "Aggregate") |> PrefixedName
    /// <summary>
    ///   <para>ntag:AnnotatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to represent the HTTP-accessible realization of an information resource on the Web. The equivalent of irw:WebRepresentation, the Annotated Resource is that which generally triggers the act of tagging. Being dereferenceable by definition, it also provides the address that will be bookmarked on delicious-like sites and work like an anchor for tags. This said, the resource being tagged is in no way limited to HTTP-accessible data (indeed, what supports an act of tagging may very well be what the Web representation represents, a non-information resource for example, instead of the Web representation itself)."</para>
    ///   <para>"Usado para representar la realización de un recurso informacional accesible en la Web mediante el protocolo HTTP. El recurso anotado es aquel que generalmente provoca la acción de etiquetado. Siendo por definición dereferenciable, dota tambien de la dirección que quedarà guardada en sistemas de "bookmarking" como delicious, y que tendrà una función de anclaje para las etiqueta. De todas maneras, el recurso etiquetado no se limita a los datos accesibles en la Web (aquello que es etiquetado puede ser también lo que la representación Web de un recurso representa, por ejemplo un recurso no-informacional, en lugar de su representación)"</para>
    ///   <para>"Utilisé pour représenter la réalisation d'une ressource informationnelle accessible sur le Web via le protocole HTTP. La ressource annotée, consultable en ligne, est celle-là même qui déclenche généralement l'acte de taguer. En quoi d'ailleurs elle est l'équivalent de la classe irw:WebRepresentation. Etant par définition déréférençable, elle fournit également l'adresse qui servira d'ancrage aux tags par l'intermédiaire du signet, selon le modèle proposé par delicious. Par contraste, la ressource taguée n'est, quant à elle, aucunement limitée à des données accessibles sur le Web (ce qui est taguée peut bien se révéler ne pas être autre chose que ce que la représentation d'un ressource représente, une ressource non-informationnelle par exemple, plutôt que cette représentation elle-même)."</para>
    ///   <para>"Usato per rappresentare la realizzazione di una risorsa informazionale accessibile sul Web mediante il protocollo HTTP. La risorsa annotata è quella che generalmente provaoca l'azione di tagging. Essendo per definizione dereferenziabile, fornisce anche l'indirizzo che sarà salvato su sistemi di bookmarking come delicious, e che avrà funzione di ancoraggio per le tag. In ogni caso, la risorsa taggata non è limitata a dati accessibili sul Web (ciò che è taggato può anche essere ciò che la rappresentazione Web di una risorsa rappresenta, per esempio una risorsa non-informazionale, piuttosto che la sua rappresentazione)"</para>
    ///   <para>"Wordt gebruikt om een via het HTTP protocol op het web toegankelijke informatiebron te representeren. De bron met annototies, online beschikbaar en gelijkwaardig aan een irw:WebRepresentation, is wat aanzet tot de taghandeling. Aangezien de bron via het web toegankelijk is, is het per definitie mogelijk om ernaar te verwijzen, dus de bron levert ook het adres dat gebookmarkt kan worden en als anker voor de tags dient. Echter, de bron die getagd wordt is op geen enkele wijze beperkt tot http-toegankelijke data (wat getagd wordt is hetgen waar de web-representatie voor staat, bijvoorbeeld een non-informatie bron, en niet de representatie zelf)."</para>
    /// labels<para>"Bron met aantekeningen"</para><para>"Ressource annotée"</para><para>"Risorsa annotata"</para><para>"Annotated resource"</para><para>"Recurso anotado"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#AnnotatedResource">http://ns.inria.fr/nicetag/2010/09/09/voc#AnnotatedResource</seealso>
    let AnnotatedResource = Prefixed_Name(ntag, "AnnotatedResource") |> PrefixedName
    /// <summary>
    ///   <para>ntag:Ask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the action that is performed with a tag by asking a question."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando se usa para hacer una pregunta."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour poser une question."</para>
    ///   <para>"Beschrijft de handeling die met de tag verricht wordt als het stellen van een vraag."</para>
    ///   <para>"Descrive l'azione che viene compiuta con una tag quando questa viene usata per porre una domanda."</para>
    /// labels<para>"Preguntar"</para><para>"Porre una domanda"</para><para>"Ask"</para><para>"Poser une question"</para><para>"Vraag stellen"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Ask">http://ns.inria.fr/nicetag/2010/09/09/voc#Ask</seealso>
    let Ask = Prefixed_Name(ntag, "Ask") |> PrefixedName
    /// <summary>
    ///   <para>ntag:Assert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om iets over een bron te bevestigen."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour affirmer quoi que ce soit à propos d'une ressource."</para>
    ///   <para>"Descrive l'azione che viene svolta con una tag quando questa è utilizzata per affermare qualcosa a proposito di una risorsa."</para>
    ///   <para>"Describe la acción realizada con una tag quando esta es usada para afirmar algo sobre un recurso."</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to assert anything about a resource."</para>
    /// labels<para>"Asserter"</para><para>"Asserire"</para><para>"Afirmar"</para><para>"Bevestigen"</para><para>"Assert"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Assert">http://ns.inria.fr/nicetag/2010/09/09/voc#Assert</seealso>
    let Assert = Prefixed_Name(ntag, "Assert") |> PrefixedName
    /// <summary>
    ///   <para>ntag:AutoTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe etiquetas generadas y/o asociadas manualmente a un recurso por un ordenador."</para>
    ///   <para>"Décrit des tags générés et/ou associés automatiquement à une ressource par une machine."</para>
    ///   <para>"Beschrijft tags als zijnde gegenereerd en/of automatisch met een bron geasoccieerd, door een computerprogramma."</para>
    ///   <para>"Descrive delle tag generate e/o associate automaticamente a una risorsa da un computer."</para>
    ///   <para>"Describes tags as automatically generated and/or associated to a resource by a computer."</para>
    /// labels<para>"Azione di tagging automatica"</para><para>"Acción de etiquetado automática"</para><para>"Acte de taguer automatique"</para><para>"Geautomatiseerde taghandeling"</para><para>"Auto tag action"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#AutoTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#AutoTagAction</seealso>
    let AutoTagAction = Prefixed_Name(ntag, "AutoTagAction") |> PrefixedName

    /// <summary>
    ///   <para>ntag:CommunityTagCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Une collection de tag constituée par les utilisateurs d'une communauté ou d'un service donnés."</para>
    ///   <para>"Una colección de etiquetas generada por los usuarios de una comunidad en linea o de un servicio Web dados."</para>
    ///   <para>"A collection of tags generated by the users of a given online community or Web service."</para>
    ///   <para>"Una collezione di tag generata dagli utenti di una comunità online o di un servizio Web dati."</para>
    ///   <para>"Een verzameling tags die gegenereerd is door een groep gebruikers van een gemeenschap of digitale dienst."</para>
    /// labels<para>"Community tag collection"</para><para>"Colección de etiquetas comunitaria"</para><para>"Collezione di tag comunitaria"</para><para>"Gemeenschapstagverzameling"</para><para>"Collection de tags communautaire"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#CommunityTagCollection">http://ns.inria.fr/nicetag/2010/09/09/voc#CommunityTagCollection</seealso>
    let CommunityTagCollection =
        Prefixed_Name(ntag, "CommunityTagCollection") |> PrefixedName

    /// <summary>
    ///   <para>ntag:DisambiguatedTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wordt gebruikt wanneer het teken waarmee getagd wordt gedesambigueerd is."</para>
    ///   <para>"Usado quando el signo usado para etiquetar es desambiguado."</para>
    ///   <para>"Utilisé lorsque le signe utilisé pour taguer est désambiguïsé."</para>
    ///   <para>"Used when the sign used to tag is disambiguated."</para>
    ///   <para>"Usato quando il segno usato per taggare è disambiguato."</para>
    /// labels<para>"Taghandeling met gedisambigueerd teken"</para><para>"Acción de etiquetado con desambiguación"</para><para>"Azione di tagging con disambiguazione"</para><para>"Acte de taguer avec désambigüisation"</para><para>"Disambiguate Tag Action"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#DisambiguatedTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#DisambiguatedTagAction</seealso>
    let DisambiguatedTagAction =
        Prefixed_Name(ntag, "DisambiguatedTagAction") |> PrefixedName

    /// <summary>
    ///   <para>ntag:Evaluate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om een klassering, een teken van goedkeuring of afkeuring, of meer algemeen een beoordeling te geven."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour donner une note, marquer son approbation ou sa désapprobation ou, plus généralement, produirez une évaluation."</para>
    ///   <para>"Descrive l'azione che si compie con una tag quando questa è usata per esprimere approvazione o disapprovazione, o, più in generale, una valutazione."</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to give a notation, a mark of approval and disapproval, or,
    ///   more generally speaking, an evaluation."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando es usada para expresar aprobación o desaprobación o, mas en general, una evaluación."</para>
    /// labels<para>"Evaluate"</para><para>"Beoordelen"</para><para>"Valutare"</para><para>"Evaluer"</para><para>"Evaluar"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Evaluate">http://ns.inria.fr/nicetag/2010/09/09/voc#Evaluate</seealso>
    let Evaluate = Prefixed_Name(ntag, "Evaluate") |> PrefixedName
    /// <summary>
    ///   <para>ntag:ExpressFeelings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om een gevoel, emotie, etc. uit te drukken."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour exprimer un sentiment, une émotion, etc."</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to express a feeling, an emotion, etc."</para>
    ///   <para>"Descrive l'azione che si compie con una tag quando questa è usata per esprimere un sentimento, un'emozione, ecc."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando es usada para expresar un sentimiento, una emoción, etc."</para>
    /// labels<para>"Expresar un sentimiento"</para><para>"Express feelings"</para><para>"Gevoelens uitdrukken"</para><para>"Esprimere un sentimento"</para><para>"Exprimer un ressenti"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#ExpressFeelings">http://ns.inria.fr/nicetag/2010/09/09/voc#ExpressFeelings</seealso>
    let ExpressFeelings = Prefixed_Name(ntag, "ExpressFeelings") |> PrefixedName
    /// <summary>
    ///   <para>ntag:GiveAccessRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to define to whom access rights to a resource are granted or denied."</para>
    ///   <para>"Descrive l'azione che si compie con una tag quando questa è usata per definire a chi sono accordati o negati i diritti di accesso a una risorsa."</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om vast te stellen aaan wie toegangsrechten tot een bron worden toegekend of ontzegd."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour définir les personnes auxquelles sont octroyés des droits d'accès à des ressource en ligne (permission ou refus)."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando es usada para definir a quien son concedidos o negados derechos de acceso a un recurso.."</para>
    /// labels<para>"Accorder des droits d'accès à"</para><para>"Toegangsrechten verlenen aan"</para><para>"Acordar derechos de acceso a"</para><para>"Accordare diritti di accesso a"</para><para>"Give access rights to"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#GiveAccessRights">http://ns.inria.fr/nicetag/2010/09/09/voc#GiveAccessRights</seealso>
    let GiveAccessRights = Prefixed_Name(ntag, "GiveAccessRights") |> PrefixedName
    /// <summary>
    ///   <para>ntag:MachineTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe etiquetas cuyo texto sigue la sintaxis de las machine tag como implementada en Flickr.com."</para>
    ///   <para>"Describes tags whose labels are using the syntax of machine tags as implemented first in Flickr.com."</para>
    ///   <para>"Descrive delle tag il cui testo segue la sintassi delle machine tag come implementata su Flickr.com."</para>
    ///   <para>"Beschrijft tags waarvan de labels gebruik maken van de machine-tag syntaxis, zoals voor het eerst geimplementeerd op flickr.com."</para>
    ///   <para>"Décrit des tags dont les libellés mobilisent la syntaxe des machine tags telle qu'implémentée d'abord sur le site Flickr.com."</para>
    /// labels<para>"Taghandeling met machinetag"</para><para>"Machine tag action"</para><para>"Azione di tagging con machine tag"</para><para>"Acción de etiquetado con machine tag"</para><para>"Acte de taguer avec machine tag"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#MachineTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#MachineTagAction</seealso>
    let MachineTagAction = Prefixed_Name(ntag, "MachineTagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:ManualTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe etiquetas asociadas manualmente a un recurso por un ser humano."</para>
    ///   <para>"Décrit des tags associés manuellement à une ressource par un être humain."</para>
    ///   <para>"Describes tags as manually associated to a resource by a human."</para>
    ///   <para>"Beschrijft tags als handmatig met een bron geasssocieerd door een mens"</para>
    ///   <para>"Descrive delle tag associate manualmente a una risorsa da un essere umano."</para>
    /// labels<para>"Manual tag action"</para><para>"Handmatige taghandeling"</para><para>"Acte de taguer manuel"</para><para>"Acción de etiquetado manual"</para><para>"Azione di tagging manuale"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#ManualTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#ManualTagAction</seealso>
    let ManualTagAction = Prefixed_Name(ntag, "ManualTagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:N-TupleTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utilisé pour décrire des actes de taguer impliquant des tags dont les libellés ont n-dimensions (double tags, triple tags, etc.)."</para>
    ///   <para>"Wordt gebruikt om taghandelingen te beschrijven waarbij de labels meerdere (n) dimensies kunnen hebben (dubbele tags, driedubbele tags, etc.)."</para>
    ///   <para>"Describe acciones de etiquetado que incluyan etiquetas n-dimensionales (etiquetas dobles, triples, etc.)."</para>
    ///   <para>"Descrive azioni di tagging basate su tag n-dimensionali (doppie tag, triple tag, ecc.)."</para>
    ///   <para>"Describes tagging involving N-tuple tags (double tags, triple tags, etc.)."</para>
    /// labels<para>"Acte de taguer avec un tag à n-dimensions"</para><para>"Taghandeling met n-tuple"</para><para>"N-tuple tag action"</para><para>"Acción de etiquetado con una etiqueta n-dimensional"</para><para>"Azione di tagging con una tag n-dimensionale"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagAction</seealso>
    let N_TupleTagAction = Prefixed_Name(ntag, "N-TupleTagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:N-TupleTagActionMTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utilisé pour décrire un acte de taguer impliquant des tags dont les libellés ont n-dimensions et suivent la syntaxe des machine tags mais dans un contexte où des APIs semblables à celle de Flickr font défaut."</para>
    ///   <para>"Descrive azioni di tagging basate su tag n-dimensionali che seguono la sintassi delle machine tag, ma in un contesto dove mancano API simili a quelle di Flickr."</para>
    ///   <para>"Describe acciones de etiquetado basadas en etiquetas n-dimensionales que siguen la sintaxis de las machine tag, pero en un contexto en el que faltan API parecidas a las de Flickr."</para>
    ///   <para>"Wordt gebruikt om een taghandeling te beschrijven wanneer de labels meerdere dimensies hebben en machinetag syntaxis volgen, maar er geen Flickr-gelijkende API besachikbaar is."</para>
    ///   <para>"Describes tagging involving N-tuple tags which follow machine tags typed syntax in acontext where Flickr-like APIs are lacking."</para>
    /// labels<para>"Acte de taguer avec un tag à n-dimensions et syntaxe de machine tags"</para><para>"N-tuple tag action with machine tag syntax"</para><para>"Taghandeling met een n-tuple met machinetag syntaxis"</para><para>"Azione di tagging con una tag a n-dimensionale e sintassi delle machine tag"</para><para>"Acción de etiquetado con una etiqueta n-dimensional y sintaxis de las machine tags"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagActionMTS">http://ns.inria.fr/nicetag/2010/09/09/voc#N-TupleTagActionMTS</seealso>
    let N_TupleTagActionMTS = Prefixed_Name(ntag, "N-TupleTagActionMTS") |> PrefixedName
    /// <summary>
    ///   <para>ntag:OwnerTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usado para describir una acción de etiquetado realizada por el propietario del URI que identifica el recurso etiquetado."</para>
    ///   <para>"Used to describe an act of tagging performed by the owner of the URI that identifies the tagged resource."</para>
    ///   <para>"Utilisé pour décrire un acte de taguer accompli par le propriétaire de l'URI qui identifie la ressource taguée."</para>
    ///   <para>"Beschrijft een taghandeling verricht door de eigenaar van de URI waarmee de getagde bron geïdentificeerd wordt."</para>
    ///   <para>"Usato per descrivere un'azione di tagging svolta dal proprietario dell'URI che identifica la risorsa taggata."</para>
    /// labels<para>"Azione di tagging del proprietario"</para><para>"Owner tag action"</para><para>"Acción de etiquetado del propietario"</para><para>"Taghandeling eigenaar"</para><para>"Acte de taguer d'un propriétaire"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#OwnerTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#OwnerTagAction</seealso>
    let OwnerTagAction = Prefixed_Name(ntag, "OwnerTagAction") |> PrefixedName

    /// <summary>
    ///   <para>ntag:PartOfWebRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utilisé pour représenter la partie de la représentation d'une ressource qui est taguée lorsque qu'il est fait usage de l'acte de taguer "Pointer"."</para>
    ///   <para>"Usato per rappresentare la parte della rappresentazione di una risorsa Web quando si è fatto uso dell'atto di tagging "Point"."</para>
    ///   <para>"Used to represent the part of the Web representation resource being tagged after the "Point" TagAction is used."</para>
    ///   <para>"Usado para representar la parte de la representación de un recurso Web quando se ha hecho uso del acto de etiquetado "Point"."</para>
    ///   <para>"Wordt gebruikt om het getagde deel van een web-representatie aan te geven wanneer gebruikt is gemaakt van de "Aanwijs" taghandeling."</para>
    /// labels<para>"Parte de la representación de un recurso en la Web"</para><para>"Onderdeel van de representatie van een bron op het web"</para><para>"Part Of Web representation"</para><para>"Parte della rappresentazione di una risorsa Web"</para><para>"Partie de la représentation d'une ressource sur le Web"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#PartOfWebRepresentation">http://ns.inria.fr/nicetag/2010/09/09/voc#PartOfWebRepresentation</seealso>
    let PartOfWebRepresentation =
        Prefixed_Name(ntag, "PartOfWebRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ntag:PersonalTagCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of tags generated by a single user."</para>
    ///   <para>"Une collection de tags constituée par un utilisateur précis."</para>
    /// labels<para>"Colección de etiquetas personal"</para><para>"Personal tag collection"</para><para>"Collezione di tag personale"</para><para>"Collection de tags personnelle"</para><para>"Persoonlijke tagverzameling"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#PersonalTagCollection">http://ns.inria.fr/nicetag/2010/09/09/voc#PersonalTagCollection</seealso>
    let PersonalTagCollection =
        Prefixed_Name(ntag, "PersonalTagCollection") |> PrefixedName

    /// <summary>
    ///   <para>ntag:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Descrive l'azione che si compie con una tag quando questa è usata per fare riferimento a una parte specifica della rappresentazione di una risorsa Web (il segmento di un video, il commento generato dagli utenti a un articolo di un quotidiano, ecc.)."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando es usada para referirse a una parte específica de un recurso Web (el segmento de un video, comentarios generados por los usuarios a un artículo de periódico)."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour faire référence à une portion spécifique de la représentation
    ///  d'une ressource sur le Web (le segment d'une vidéo, un commentaire produit par les utilisateurs au pied d'un article, etc.)."</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om naar een specifiek deel van een web-representatie te verwijzen (een segment van een video, een door een gebruiker gegenereerd commentaar bij een krantenartikel, etc.)."</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to point to a specific part of a Web representation (the segment of a video,
    ///   a user-generated commentary to a newspaper article, etc.)."</para>
    /// labels<para>"Puntar"</para><para>"Point"</para><para>"Puntare"</para><para>"Aanwijzen"</para><para>"Pointer"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Point">http://ns.inria.fr/nicetag/2010/09/09/voc#Point</seealso>
    let Point = Prefixed_Name(ntag, "Point") |> PrefixedName
    /// <summary>
    ///   <para>ntag:SetTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Descrive l'azione che si compie con una tag di tipo "dafare", quando questa è usata per creare un compito in attesa di realizzazione."</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta de tipo "quehacer" cuando es usada para crear una tarea en espera de realización."</para>
    ///   <para>"Describes the action that is performed with a "todo" tag whenever it is used to create a task awaiting performance."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag de type "àfaire" dès lors que celui-ci est utilisé pour définir une tâche attendant sa réalisation."</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag van het type “te doen” wanneer deze gebruikt wordt om een taak te maken in afwachting van haar realisatie."</para>
    /// labels<para>"Definire un compito"</para><para>"Definir una tarea"</para><para>"Taak definiëren"</para><para>"Set task"</para><para>"Définir une tâche"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#SetTask">http://ns.inria.fr/nicetag/2010/09/09/voc#SetTask</seealso>
    let SetTask = Prefixed_Name(ntag, "SetTask") |> PrefixedName
    /// <summary>
    ///   <para>ntag:Share</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describe la acción que se realiza con una etiqueta cuando es usada para compartir la representación de un recurso  en un servicio Web, por ejemplo Delicious o Twitter, con el titular de una cuenta en este servicio (sioc:UserAccount, que no es necesariamente una foaf:Person, porqué puede ser también un robot o una institución cuyos representantes pueden variar en el tiempo."</para>
    ///   <para>"Descrive l'azione che si compie con una tag quando questa è usata per condividere la rappresentazizone di una risorsa su uno specifico servizio Web, per esempio Delicious o Twitter, con il titolare di un account su tale servizio (sioc:UserAccount, che non è necessariamente una foaf:Person, ma può trattarsi anche di un robot, o di una istituzione i cui rappresentanti possono variare nel tempo)."</para>
    ///   <para>"Décrit l'action que l'on accomplit avec un tag dès lors que celui-ci est utilisé pour partager une représentation d'une ressource sur le Web, notamment sur Delicious ou Twitter. Ce partage ne se fait pas nécessairement avec une autre personne mais plutôt avec le  titulaire d'un compte sur l'un ou l'autre de ces services (sioc:UserAccount, qui n'est pas nécessairement une foaf:Person étant donné qu'il peut s'agir aussi bien d'un robot, d'une personne ou encore d'une institution dont les représentants sont potentiellement amenés à varier au fil du temps)."</para>
    ///   <para>"Describes the action that is performed with a tag whenever it is used to share the representation of a WebResource on various services - Twitter or Delicious for instance - with the owner of a sioc:UserAccount (not necessarily a foaf:Person as it might be either a bot, a person or an institution whose representatives may well vary over time)."</para>
    ///   <para>"Beschrijft de handeling die verricht wordt met een tag wanneer deze gebruikt wordt om de representatie van een bron op het web te delen met een gebruiker van een dienst als Twitter of Delicious. (sioc:UserAccount, wat niet per se een foaf:Person is aangezien het ook om een bot kan gaan of een instelling die met het verlopen van de tijd door verschillende personen vertegenwoordigd kan worden)."</para>
    /// labels<para>"Condividere"</para><para>"Share"</para><para>"Delen"</para><para>"Compartir"</para><para>"Partager"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#Share">http://ns.inria.fr/nicetag/2010/09/09/voc#Share</seealso>
    let Share = Prefixed_Name(ntag, "Share") |> PrefixedName
    /// <summary>
    ///   <para>ntag:SyntacticTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Décrit des tags dont les libellés mobilisent une certaine syntaxe pour accroître leur précision et leur capacité à être manipulés."</para>
    ///   <para>"Descrive delle tag il cui testo segue una sintassi determinata per ottenere maggiore precisione e trattabilità."</para>
    ///   <para>"Describes tags whose labels are following a given syntax for improved precision and tractability."</para>
    ///   <para>"Describe etiquetas cuyo texto sigue una sintaxis determinada para una mayor precisión y tratabilidad."</para>
    ///   <para>"Beschrijft tags waarvan de labels van een bepaalde syntaxis gebruik maken om de precisie en manipuleerbaarheid te vergroten."</para>
    /// labels<para>"Acción de etiquetado sintáctica"</para><para>"Syntactic Tag Action"</para><para>"Syntactische taghandeling"</para><para>"Azione di tagging sintattica"</para><para>"Acte de taguer syntaxique"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#SyntacticTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#SyntacticTagAction</seealso>
    let SyntacticTagAction = Prefixed_Name(ntag, "SyntacticTagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:TagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una super-clase que permite describir y modelar cada acción de etiquetado utilizando un named graph según el modelo del grafo RDF (RDFG)."</para>
    ///   <para>"Una super-classe che permette di descrivere e di modellare ogni azione di tagging con un named graph secondo il modello del grafo RDF (RDFG)."</para>
    ///   <para>"Een overkoepelende categorie die toestaat elke taghandeling te beschrijving als een gelabelde graaf binnen het RDF graph model (RDFG)."</para>
    ///   <para>"A super class to describe every tag action as modelled by a named graph according to RDF Graph model (RDFG)."</para>
    ///   <para>"Une super-classe qui permet de décrire et de modéliser les actes de taguer à l'aide d'un graphe nommé et au moyen du modèle de graphe RDF (RDFG)."</para>
    /// labels<para>"Azione di tagging"</para><para>"Tag action"</para><para>"Acte de taguer"</para><para>"Acción de etiquetado"</para><para>"Taghandeling"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#TagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#TagAction</seealso>
    let TagAction = Prefixed_Name(ntag, "TagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:TagCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Een verzameling tags zonder verdere specifieke definitie."</para>
    ///   <para>"Una generica collezione di tag."</para>
    ///   <para>"Une collection de tags ne répondant à aucune définition particulière."</para>
    ///   <para>"Una genérica colección de etiquetas."</para>
    ///   <para>"Undefined collection of tags."</para>
    /// labels<para>"Collection de tags"</para><para>"Tagverzameling"</para><para>"Tag collection"</para><para>"Collezione di tag"</para><para>"Colección de etiquetas"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#TagCollection">http://ns.inria.fr/nicetag/2010/09/09/voc#TagCollection</seealso>
    let TagCollection = Prefixed_Name(ntag, "TagCollection") |> PrefixedName
    /// <summary>
    ///   <para>ntag:TaggedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Utilisé pour représenter la ressource taguée. Equivalent de irw:Resource."</para>
    ///   <para>"Usato per rappresentare la risorsa taggata. Equivalente di irw:Resource."</para>
    ///   <para>"Usado para representar el recurso etiquetado. Equivalente a irw:Resource."</para>
    ///   <para>"Wordt gebruikt als representatie van de bron die getagd wordt."</para>
    ///   <para>"Used to represent the resource being tagged. Equivalent of irw:Resource."</para>
    /// labels<para>"Tagged resource"</para><para>"Getagde bron"</para><para>"Recurso etiquetado"</para><para>"Ressource taguée"</para><para>"Risorsa taggata"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#TaggedResource">http://ns.inria.fr/nicetag/2010/09/09/voc#TaggedResource</seealso>
    let TaggedResource = Prefixed_Name(ntag, "TaggedResource") |> PrefixedName
    /// <summary>
    ///   <para>ntag:VisitorTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to describe an act of tagging performed by a the person who browsed a Web representation."</para>
    ///   <para>"Beschrijft een taghandeling verricht door een bezoeker van de web-representatie van een bron."</para>
    ///   <para>"Usado para describir una acción de etiquetado realizada por una persona que ha tenido acceso a la representación de un recurso en la Web."</para>
    ///   <para>"Usato per descrivere un'azione di tagging svolta da una persona che ha avuto accesso alla rappresentazione di una risorsa Web."</para>
    ///   <para>"Utilisé pour décrire l'acte de taguer accompli par une personne ayant eu accès à la représentation d'une ressource sur le Web."</para>
    /// labels<para>"Acción de etiquetado de un visitante"</para><para>"Taghandeling bezoeker"</para><para>"Acte de taguer d'un visiteur"</para><para>"Azione di tagging di un visitatore"</para><para>"Visitor tag action"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#VisitorTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#VisitorTagAction</seealso>
    let VisitorTagAction = Prefixed_Name(ntag, "VisitorTagAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:WebConceptTagAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes tagging involving Web concepts (such as geonames)."</para>
    ///   <para>"Usata per descrivere un'azioni di tagging effettuata con l'aiuto di un concetto Web (per esempio geonames)."</para>
    ///   <para>"Wordt gebruikt om taghandelingen te beschrijven waarbij gebruikt gemaakt woord van webconcepten (zoals geonames)."</para>
    ///   <para>"Utilisé pour décrire un taggage effectué à l'aide de concepts Web (tels que geonames)."</para>
    ///   <para>"Usada para describir una acción de etiquetado realizada con la ayuda de un concepto Web (por ejemplo geonames)."</para>
    /// labels<para>"Acción de etiquetado con Web concept"</para><para>"Taghandeling met webconcept"</para><para>"Acte de taguer par concept Web"</para><para>"Azione di tagging con Web concept"</para><para>"Web concept tag action"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#WebConceptTagAction">http://ns.inria.fr/nicetag/2010/09/09/voc#WebConceptTagAction</seealso>
    let WebConceptTagAction = Prefixed_Name(ntag, "WebConceptTagAction") |> PrefixedName

    /// <summary>
    ///   <para>ntag:belongsToTagCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used to link a single and well individuated TagAction to a TagCollection to account for the various levels of aggregation provided by common tagging applications. There exist different ways to aggregate tags (for instance, http://delicious.com/fabion_gandon/OWL gives a Web representation of all taggings of user "fabien_gandon" involving the tag labeled 'OWL' on delicious.com at time "t")."</para>
    ///   <para>"Proprietà usata per associare una singola azione di tagging a una collezione di tag, con lo scopo di rendere conto dei vari livelli di aggregazione forniti dai servizi di tagging esistenti. Ci sono vari modi di aggregare delle tag (per esempio, http://delicious.com/fabion_gandon/OWL permette di accedere a una rappresentazione di tutte le azioni di tagging svolte dal titolare dell'account "fabien_gandon", nelle quali compare la tag "OWL" su del.icio.us.com in un istante "t")."</para>
    ///   <para>"Propriété employée pour associer un acte de taguer singulier à une collection de tags. Ceci sert à rendre compte des multiples manières d'aggréger les tags offertes par les différents services existants (l'URI http://delicious.com/fabion_gandon/OWL permet par exemple d'accéder à une représentation de tous les actes de taguer accomplis par le titulaire du compte "fabien_gandon" où figure le libellé "OWL" sur delicious.com à un instant "t")."</para>
    ///   <para>"Eigenschap die gebruikt wordt om een enkelvoudige taghandeling te koppelen aan een tagverzameling, zo rekenschap gevende van de verschillende niveaus waarop veelgebruikte tagdiensten tags bijeenverzamelen (http://delicious.com/fabion_gandon/OWL bijvoorbeeld, geeft een webrepresentatie van alle taghandelingen van de gebruiker "fabian_gandon" waar op een moment "t" het label "OWL" is gebruikt)."</para>
    ///   <para>"Propriedad usada para asociar una singola acción de etiquetado a una colección de etiquetas, con el objetivo de dar cuenta de los diferentes niveles de agregación proporcionados por los servicios de etiquetado existentes. Hay varias maneras de agregar la etiquetas (por ejemplo, http://delicious.com/fabion_gandon/OWL permite de acceder a una reppresentación de todas las acciones de etiquetado realizadas por el titular de la cuenta "fabien_gandon", en las cuales aparece la etiqueta "OWL" en del.icio.us.com en un instante "t")."</para>
    /// labels<para>"Appartient à une collection de tags"</para><para>"Appartiene a una collezione di tag"</para><para>"Belongs to tag collection"</para><para>"Behoort toe aan tagverzameling"</para><para>"Pertenece a una colección de etiquetas"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#belongsToTagCollection">http://ns.inria.fr/nicetag/2010/09/09/voc#belongsToTagCollection</seealso>
    let belongsToTagCollection =
        Prefixed_Name(ntag, "belongsToTagCollection") |> PrefixedName

    /// <summary>
    ///   <para>ntag:canBeReadBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Corresponde al uso de etiquetas cuyo contenido indica el destinatario al cual vienen conferidos derechos de acceso a un recurso."</para>
    ///   <para>"Corresponds à l'utilisation de tags dont le libellé indique le destinataire auquel des droits d'accès définis sur une ressource donnée ont été octroyés."</para>
    ///   <para>"Property used when the label of a tag indicates to whom access rights to the tagged resource are conferred."</para>
    ///   <para>"Corrisponde all'uso di tag il cui contenuto indica il destinatario a cui vengono conferiti diritti di accesso a una risorsa."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie toegangsrechten tot de getagde bron worden toegekend."</para>
    /// labels<para>"Può essere letto da"</para><para>"Can be read by"</para><para>"Puede ser leído por"</para><para>"Kan gelezen worden door"</para><para>"Peut être lu par"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#canBeReadBy">http://ns.inria.fr/nicetag/2010/09/09/voc#canBeReadBy</seealso>
    let canBeReadBy = Prefixed_Name(ntag, "canBeReadBy") |> PrefixedName
    /// <summary>
    ///   <para>ntag:cannotBeReadBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used when the label of a tag indicates to whom access right to the tagged resource are denied."</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta indica el destinatario al cual se han negado derechos de acceso a un  recurso."</para>
    ///   <para>"Propriété utilisée quand le libellé d'un tag indique le destinataire auquel des droits d'accès définis sur une ressource donnée ont été déniés."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie de toegangsrechten tot de getagde bron worden ontzegd."</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag indica il destinatario a cui sono negati diritti di accesso a una risorsa."</para>
    /// labels<para>"Non può essere letto da"</para><para>"No puede ser leído por"</para><para>"Cannot be read by"</para><para>"Ne peut être lu par"</para><para>"Kan niet gelezen worden door"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#cannotBeReadBy">http://ns.inria.fr/nicetag/2010/09/09/voc#cannotBeReadBy</seealso>
    let cannotBeReadBy = Prefixed_Name(ntag, "cannotBeReadBy") |> PrefixedName
    /// <summary>
    ///   <para>ntag:elicitsAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proprietà usata quando una risorsa suscita lo svolgimento di un'azione."</para>
    ///   <para>"Propriété utilisée quand une ressource suscite l'accomplissement d'une action."</para>
    ///   <para>"Propriedad usada cuando un recurso suscita la realización de una acción."</para>
    ///   <para>"Property used when a resource elicits an action to be performed."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer een bron aanzet tot het verrichten van een handeling."</para>
    /// labels<para>"Suscita la acción"</para><para>"Suscite l'action"</para><para>"Ontlokt de handeling"</para><para>"Suscita l'azione"</para><para>"Elicits action"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#elicitsAction">http://ns.inria.fr/nicetag/2010/09/09/voc#elicitsAction</seealso>
    let elicitsAction = Prefixed_Name(ntag, "elicitsAction") |> PrefixedName
    /// <summary>
    ///   <para>ntag:hasCommunitySign</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Correspond à des usages collectivement constitués de libellés choisis par une communauté."</para>
    ///   <para>"Komt overeen met collectief afgestemd gebruik van door een gemeenschap gekozen labels."</para>
    ///   <para>"Corresponde al uso de etiquetas elegidas por una comunidad."</para>
    ///   <para>"Corrisponde all'uso di tag scelte da una comunità."</para>
    ///   <para>"Corresponds to uses of collectively approved labels shared inside a community."</para>
    /// labels<para>"A pour signe collectif"</para><para>"Has community sign"</para><para>"Tiene signo colectivo"</para><para>"Heeft een gemeenschappelijk teken"</para><para>"Ha segno collettivo"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasCommunitySign">http://ns.inria.fr/nicetag/2010/09/09/voc#hasCommunitySign</seealso>
    let hasCommunitySign = Prefixed_Name(ntag, "hasCommunitySign") |> PrefixedName
    /// <summary>
    ///   <para>ntag:hasForMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta indica el medium al que pertenece la representación Web del recurso al cual se accede ("forum", "video", "foto", "página Web", "Webservice", etc.)."</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag indica il medium a cui appartiene la rappresentazione Web della risorsa a cui si accede ("forum", "vidéo", "photo", "pagina Web", "Webservice", etc.)."</para>
    ///   <para>"Propriété utilisée quand le libellé d'un tag indique de quel média la représentation de la ressource à laquelle on accède ressortit ("forum", "vidéo", "photo", "page Web", "Webservice", etc.)."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft tot welk medium een via het web toegankelijke representatie behoort ("forum", "video", "foto", "webpagina", "webdienst", etc.)"</para>
    ///   <para>"Property used when the label of a tag indicates the medium which an HTTP-accessible Web representation belongs to ("forum", "video", "photo", "Webpage", "Webservice", etc.)."</para>
    /// labels<para>"Es un medium de tipo"</para><para>"Est un medium de type"</para><para>"Has for medium"</para><para>"Is het medium"</para><para>"È un medium di tipo"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasForMedium">http://ns.inria.fr/nicetag/2010/09/09/voc#hasForMedium</seealso>
    let hasForMedium = Prefixed_Name(ntag, "hasForMedium") |> PrefixedName
    /// <summary>
    ///   <para>ntag:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used when the label of a tag indicates which part of a Web representation is being tagged."</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta indica que parte de la representación de un recurso en la Web ha sido etiquetada."</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag indica quale parte della rappresentazione di una risorsa su Web è taggata."</para>
    ///   <para>"Propriété utilisée quand le libellé d'un tag indique quelle partie de la représentation d'une ressource sur le Web est taguée."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft welk gedeelte van een web-representatie getagd wordt."</para>
    /// labels<para>"Has part"</para><para>"Heeft als deel"</para><para>"Ha come parte"</para><para>"A pour partie"</para><para>"Tiene como parte"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasPart">http://ns.inria.fr/nicetag/2010/09/09/voc#hasPart</seealso>
    let hasPart = Prefixed_Name(ntag, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>ntag:hasPersonalSign</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Corresponde al uso de etiquetas definidas por el usuario, que pueden servir para recoger, categorizar o distinguir etiquetas, o para estructurar su propria colección de etiquetas ."</para>
    ///   <para>"Corresponds to uses of user-defined labels that can either serve to gather, categorize, distinguish resources or simply add structure to one's collection of tags."</para>
    ///   <para>"Komt overeen met het gebruik van persoonlijk gedefinieerde labels die tot doel hebben bronnen te verzamelen, categoriseren en onderscheiden, of die simpelweg een verzameling tags structureren."</para>
    ///   <para>"Correspond à l'emploi de libellés définis par un utilisateur pour rassembler, catégoriser ou distinguer des ressources voire simplement structurer sa propre collection de tags."</para>
    ///   <para>"Corrisponde all'uso di tag definite dall'utente che possono servire per raccogliere, categorizzare o distinguere risorse, oppure semplicemente per strutturare la propria collezione di tag."</para>
    /// labels<para>"Heeft een persoonlijk teken"</para><para>"Ha segno personale"</para><para>"Tiene signo personal"</para><para>"Has personal sign"</para><para>"A pour signe personnel"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#hasPersonalSign">http://ns.inria.fr/nicetag/2010/09/09/voc#hasPersonalSign</seealso>
    let hasPersonalSign = Prefixed_Name(ntag, "hasPersonalSign") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used when the label of a tag describes the topic of a resource."</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta describe el tema de un recurso."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag het thema van een bron beschrijft."</para>
    ///   <para>"Propriété utilisé pour indiquer que le libellé d'un tag décrit le thème d'une ressource."</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag descrive il tema di una risorsa."</para>
    /// labels<para>"A pour thème"</para><para>"Ha come tema"</para><para>"Is about"</para><para>"Tiene como tema"</para><para>"Betreft"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isAbout">http://ns.inria.fr/nicetag/2010/09/09/voc#isAbout</seealso>
    let isAbout = Prefixed_Name(ntag, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Usado para asociar un recurso a un signo que puede ser, en sí mismo, de qualquier tipo, con tal que su representación, identificada por un URI, sea accesible mediante el protocolo HTTP. NiceTag define las etiquetas por medio de una propiedad que asocia dos recursos; la ontologia IRW permite comprender con mas claridad el significaso de nt:taggedResources(en especiàl la clase irw:Resource)."</para>
    ///   <para>"Used to link a resource to a sign, which can itself, be of any type, provided its representation is HTTP accessible from a URI. NiceTag defines tags by means of a mere property linking two Resources; this said, the many distinctions found in IRW ontology give a more precise account of nt:TaggedResource (see in particular irw:Resource)."</para>
    ///   <para>"Wordt gebruikt om een bron met een teken te verbinden. Dit teken kan om het even welk type zijn zolang de representatie toegankelijk is via een URI over HTTP. NiceTag definieert tags door een eigenschap die twee bronnen verbindt. Toch kunnen veel van de onderscheiden die te vinden zijn in de IRW ontologie gebruikt worden om een meer precies beeld te krijgen van nt:TaggedResource (in het bijzonder de klasse irw:Resource)."</para>
    ///   <para>"Utilisé pour lier une ressource à un signe qui, lui-même, peut être de n'importe quel type pourvu que sa représentation, identifiée par une URI, soit accessible via le protocole HTTP. NiceTag définit les tags au moyen d'une propriété qui relie deux Resource; toutefois, l'ontologie IRW permet de comprendre plus précisément la signification de nt:TaggedResource (en particulier la classe irw:Resource)."</para>
    ///   <para>"Usato per associare una risorsa a un segno che può essere, di per sè, di qualsiasi tipo, purchè la sua rappresentazione, identificata da un URI, sia accessibile tramite il protocollo HTTP. NiceTag definisce le tag per mezzo di una proprietà che associa due risorse; l'ontologia IRW permette di comprendere più precisamente il significato di nt:TaggedResource (in particolare la classe irw:Resource)."</para>
    /// labels<para>"Is related to"</para><para>"Houdt verband met"</para><para>"Está relacionado con"</para><para>"È connesso con"</para><para>"Est relié à"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelatedTo">http://ns.inria.fr/nicetag/2010/09/09/voc#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(ntag, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isRelevant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used to subsume "isRelevantToSb" and "isRelevantToSt"."</para>
    ///   <para>"Propriété utilisée pour subsumer "isRelevantToSb" et "isRelevantToSt"."</para>
    ///   <para>"Propriedad usada para subsumir "isRelevantToSb" y "isRelevantToSt"."</para>
    ///   <para>"Eigenschap die gebruikt wordt om "isRelevantToSb" en "isRelevantToSt" onder één noemer te brengen."</para>
    ///   <para>"Proprietà usata per sussumere "isRelevantToSb" e "isRelevantToSt"."</para>
    /// labels<para>"Est pertinent"</para><para>"Is relevant"</para><para>"È pertinente"</para><para>"Es pertinente"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevant">http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevant</seealso>
    let isRelevant = Prefixed_Name(ntag, "isRelevant") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isRelevantTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantTo">http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantTo</seealso>
    let isRelevantTo = Prefixed_Name(ntag, "isRelevantTo") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isRelevantToSb</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Deeleigenschap van ‘isRelevantTo’, gebruikt om een verband tot stand te brengen tussen een bron en de persoon waar het betrekking tot kan hebben. In een zodanige vorm dat er geen onmiddelijke formele relatie tussen de twee afgeleid kan worden behalve vanuit het gezichtspunt van een specifiek persoon en de gebruiker die dit verband gelegd heeft."</para>
    ///   <para>"Sub-propriedad de 'isRelevantTo' usada para asociar un recurso a la persona para la que puede ser pertinente, de manera que ningun enlace formal inmediato pueda ser inferido entre los dos, excepto desde el punto de vista del creador de esa asociación."</para>
    ///   <para>"Sotto-proprietà di 'isRelevantTo' usata per associare una risorsa alla persona a cui può essere pertinente, in modo tale che nessun collegamento formale immediato possa essere inferito fra i due, eccetto dal punto  di vista del creatore di tale collegamento"</para>
    ///   <para>"Subproperty of 'is relevant to' used to link a resource to the person whom it may be relevant to. In other words, in such a way that no immediate formal link can be inferred between the two except from the point of view of a precise person in addition to the user who defined the said link."</para>
    ///   <para>"Sous-propriété de 'isRelevantTo', utilisée pour associer une ressource à une personne de telle manière qu'aucun lien formel ne puisse être inféré entre les deux excepté du point de vue du destinataire et du destinateur du tag."</para>
    /// labels<para>"Is relevant to somebody"</para><para>"È pertinente a qualcuno"</para><para>"Es pertinente para alguien"</para><para>"Is relevant voor iemand"</para><para>"Est pertinent pour quelqu'un"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSb">http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSb</seealso>
    let isRelevantToSb = Prefixed_Name(ntag, "isRelevantToSb") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isRelevantToSt</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Subproperty of 'is relevant to', used to link a resource to anything that it may be relevant to. In other words, in such a way that no immediate formal link can be inferrend between the two except from the point of view of the creator of the said link."</para>
    ///   <para>"Sub-propriedad de 'isRelevantTo' usada para asociar un recurso a qualquier cosa para la que pueda ser pertinente, de manera que ningun enlace formal inmediato pueda ser inferido entre los dos, excepto desde el punto de vista del creador de esa asociación."</para>
    ///   <para>"Sous-propriété de "isRelevantTo', utilisée pour lier quoi que ce soit à une ressource de telle manière qu'aucun lien immédiat formel ne puisse être inféré entre les deux excepté du point de vue du créateur d'un tel lien."</para>
    ///   <para>"Sotto-proprietà di 'isRelevantTo' usata per associare una risorsa a qualsiasi cosa che possa essere pertinente, in modo che nessun collegamento formale immediato possa essere inferito fra i due, eccetto dal punto  di vista del creatore di tale collegamento."</para>
    ///   <para>"Deeleigenschap van ‘isRelevantTo’, gebruikt om een verband te leggen tussen de bron en iets anders, waarbij geen formeel verband is vast te stellen behalve vanuit het gezichtspunt van degene die dit verband legt."</para>
    /// labels<para>"Est pertinent par rapport à quelque chose"</para><para>"Es pertinente para algo"</para><para>"Is relevant to something"</para><para>"È pertinente a qualcosa"</para><para>"Is relevant met betrekking tot iets"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSt">http://ns.inria.fr/nicetag/2010/09/09/voc#isRelevantToSt</seealso>
    let isRelevantToSt = Prefixed_Name(ntag, "isRelevantToSt") |> PrefixedName
    /// <summary>
    ///   <para>ntag:isWorth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proprietà usata per indicare che una risorsa è valutata, classificata, ecc. per mezzo del contenuto di una tag ("***", "5/10", "0", "best", etc.)."</para>
    ///   <para>"Propriété utilisée pour indiquer qu'une ressource est évaluée, classée, etc. à l'aide d'un libellé ("***", "5/10", "0", "le meilleur", etc.)."</para>
    ///   <para>"Eigenschap die gebruikt wordt op het moment dat een een bron wordt gewaardeerd, geklassificeerd met een label ("***", "5/10", "0", "het beste", etc.)."</para>
    ///   <para>"Propriedad usada para indicar que un recurso es evaluado, clasificado, etc., por medio del contenido de una etiqueta ("***", "5/10", "0", "best", etc.)."</para>
    ///   <para>"Property used whenever a resource is evaluated, ranked, etc. thanks to a label ("***", "5/10", "0", "best", etc.)."</para>
    /// labels<para>"Is worth"</para><para>"Tiene valor"</para><para>"Ha valore"</para><para>"Vaut"</para><para>"Is waaard"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#isWorth">http://ns.inria.fr/nicetag/2010/09/09/voc#isWorth</seealso>
    let isWorth = Prefixed_Name(ntag, "isWorth") |> PrefixedName
    /// <summary>
    ///   <para>ntag:makesMeFeel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Propriedad usada para indicar que el contenido de una etiqueta denota/expresa una reacción emocional."</para>
    ///   <para>"Property used to indicate that the label of a tag denotes/expresses an emotional reaction."</para>
    ///   <para>"Eigenschap die gebruikt wordt om aan te geven dat het label van een tag een emotionele reactie weergeeft of uitdrukt."</para>
    ///   <para>"Propriété utilisée pour indiquer que le libellé d'un tag dénote/exprime une réaction émotionnelle."</para>
    ///   <para>"Proprietà usata per indicare che il contenuto di una tag denota/esprime una reazione emotiva."</para>
    /// labels<para>"Mi suscita"</para><para>"Maakt dat ik me voel"</para><para>"Produit sur moi"</para><para>"Makes me feel"</para><para>"Me provoca"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#makesMeFeel">http://ns.inria.fr/nicetag/2010/09/09/voc#makesMeFeel</seealso>
    let makesMeFeel = Prefixed_Name(ntag, "makesMeFeel") |> PrefixedName
    /// <summary>
    ///   <para>ntag:raisesQuestionAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag indica che si sta ponendo una domanda."</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta indica que se esta planteando una pregunta."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft dat een vraag gesteld wordt."</para>
    ///   <para>"Propriété utilisée quand le libellé d'un tag indique qu'une question est posée."</para>
    ///   <para>"Property used when the label of a tag indicates that a question is being asked."</para>
    /// labels<para>"Solleva una domanda su"</para><para>"Soulève une interrogation au sujet de"</para><para>"Plantea una cuestión sobre"</para><para>"Roept vragen op over"</para><para>"Raises question about"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#raisesQuestionAbout">http://ns.inria.fr/nicetag/2010/09/09/voc#raisesQuestionAbout</seealso>
    let raisesQuestionAbout = Prefixed_Name(ntag, "raisesQuestionAbout") |> PrefixedName
    /// <summary>
    ///   <para>ntag:sentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Correspond à l'utilisation de signes qui indiquent à qui une ressource a été suggérée."</para>
    ///   <para>"Corresponds to uses of labels that indicate by whom a resource was suggested."</para>
    ///   <para>"Corresponde al uso de etiquetas que indican por quien ha sido sugerido un recurso."</para>
    ///   <para>"Corrisponde all'uso di tagche indicano da chi è stata suggerita una risorsa."</para>
    ///   <para>"Komt overeen met het gebruik van labels die aangeven door wie deze bron is voorgesteld."</para>
    /// labels<para>"Envoyé par"</para><para>"Inviato da"</para><para>"Verstuurd door"</para><para>"Enviado por"</para><para>"Sent by"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#sentBy">http://ns.inria.fr/nicetag/2010/09/09/voc#sentBy</seealso>
    let sentBy = Prefixed_Name(ntag, "sentBy") |> PrefixedName
    /// <summary>
    ///   <para>ntag:sentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Property used when the label of a tag indicates to whom a resource was suggested (models existing features like delicious "for:-username" tags)."</para>
    ///   <para>"Eigenschap die gebruikt wordt wanneer het label van een tag aangeeft aan wie de bron is voorgesteld (modelleert bestaande functionaliteit zoals de "for:-username" tags op Delicious)."</para>
    ///   <para>"Propriété utilisée quand le libellé d'un tag indique à quel utilisateur une ressource a été suggérée (modélise des fonctionalités existantes telles que les tags "for:-username" sur Delicious)."</para>
    ///   <para>"Propriedad usada cuando el contenido de una etiqueta indica a que usuario un recurso ha sido sugerido (modeliza funcionalidades existentes como las etiquetas "for:usuario" en Delicious)."</para>
    ///   <para>"Proprietà usata quando il contenuto di una tag indica a quale utente una risorsa è stata suggerita (modellizza funzionalità esistenti come le tag "for:utente" in Delicious)."</para>
    /// labels<para>"Enviado a"</para><para>"Inviato a"</para><para>"Envoyé à"</para><para>"Verstuurd aan"</para><para>"Sent to"</para></remarks>
    /// <seealso href="http://ns.inria.fr/nicetag/2010/09/09/voc#sentTo">http://ns.inria.fr/nicetag/2010/09/09/voc#sentTo</seealso>
    let sentTo = Prefixed_Name(ntag, "sentTo") |> PrefixedName

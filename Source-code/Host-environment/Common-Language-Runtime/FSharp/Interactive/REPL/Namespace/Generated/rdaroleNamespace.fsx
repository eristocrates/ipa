#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdarole =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdvocab.info/roles/" "rdarole"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating an independent or personal film. A filmmaker is individually responsible for the conception, and execution of all aspects of the film.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Filmmaker</para>
    ///   <para>rdfs:label : Filmmaker</para>
    ///   <a href="http://rdvocab.info/roles/Filmmaker">rdarole:Filmmaker</a>
    /// </summary>
    let Filmmaker = _prefixId.prefix "Filmmaker"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridger</para>
    ///   <para>rdfs:label : Abridgerrdfs:label : Abridger </para>
    ///   <a href="http://rdvocab.info/roles/abridger">rdarole:abridger</a>
    /// </summary>
    let abridger = _prefixId.prefix "abridger"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgerExpression</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die eine Expression eines Werkes kürzt oder zusammenfasst, dabei aber das Wesen des Originalwerkes unverändert lässt. skos:definition : A person, family, or corporate body contributing to an expression of a work by shortening or condensing the original work but leaving the nature and content of the original work substantially unchanged.</para>
    ///   <para>rdfs:label : Abridger (Expression)rdfs:label : Abridger (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/abridgerExpression">rdarole:abridgerExpression</a>
    /// </summary>
    let abridgerExpression = _prefixId.prefix "abridgerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actor</para>
    ///   <para>rdfs:label : Actorrdfs:label : Schauspieler </para>
    ///   <a href="http://rdvocab.info/roles/actor">rdarole:actor</a>
    /// </summary>
    let actor = _prefixId.prefix "actor"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by acting as a cast member or player in a musical or dramatic presentation, etc.skos:definition : Ein Darsteller, der zu einer Expression eines Werkes als Ensemble-Mitglied oder Darsteller in einer musikalischen oder dramatischen Darbietung usw. beiträgt.</para>
    ///   <para>rdfs:label : Actor (Expression)rdfs:label : Schauspieler (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : actorExpression</para>
    ///   <a href="http://rdvocab.info/roles/actorExpression">rdarole:actorExpression</a>
    /// </summary>
    let actorExpression = _prefixId.prefix "actorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addressee</para>
    ///   <para>rdfs:label : addresseerdfs:label : Adressat</para>
    ///   <a href="http://rdvocab.info/roles/addressee">rdarole:addressee</a>
    /// </summary>
    let addressee = _prefixId.prefix "addressee"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, an die Korrespondenz in einem Werk adressiert ist. skos:definition : A person, family, or corporate body to whom the work or part of the work is addressed.</para>
    ///   <para>rdfs:label : Adressat (Werk)rdfs:label : addressee (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addresseeWork</para>
    ///   <a href="http://rdvocab.info/roles/addresseeWork">rdarole:addresseeWork</a>
    /// </summary>
    let addresseeWork = _prefixId.prefix "addresseeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animator</para>
    ///   <para>rdfs:label : Animatorrdfs:label : Animator </para>
    ///   <a href="http://rdvocab.info/roles/animator">rdarole:animator</a>
    /// </summary>
    let animator = _prefixId.prefix "animator"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : animatorExpression</para>
    ///   <para>rdfs:label : Animator (Expression)rdfs:label : Animator (Expression)</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a moving image work or computer program by giving apparent movement to inanimate objects or drawings.skos:definition : Eine Person, Familie oder Körperschaft, an die Korrespondenz in einem Werk adressiert ist. </para>
    ///   <a href="http://rdvocab.info/roles/animatorExpression">rdarole:animatorExpression</a>
    /// </summary>
    let animatorExpression = _prefixId.prefix "animatorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotator</para>
    ///   <para>rdfs:label : Annotatorrdfs:label : Annotator</para>
    ///   <a href="http://rdvocab.info/roles/annotator">rdarole:annotator</a>
    /// </summary>
    let annotator = _prefixId.prefix "annotator"
    /// <summary>
    ///   <para>rdfs:label : Annotator (Item)rdfs:label : Annotator (Exemplar)</para>
    ///   <para>skos:definition : Eine Person, die handschriftlich Anmerkungen in ein spezifisches Exemplar schreibt. skos:definition : A person who makes manuscript annotations on a specific item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotatorItem</para>
    ///   <a href="http://rdvocab.info/roles/annotatorItem">rdarole:annotatorItem</a>
    /// </summary>
    let annotatorItem = _prefixId.prefix "annotatorItem"
    /// <summary>
    ///   <para>skos:definition : Eine natürliche oder juristische Person, die gegen ein Gerichtsurteil einer unteren Instanz Rechtsmittel (Berufung / Revision) einlegt. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellant</para>
    ///   <para>rdfs:label : Appellantrdfs:label : Berufungskläger / Revisionskläger  </para>
    ///   <a href="http://rdvocab.info/roles/appellant">rdarole:appellant</a>
    /// </summary>
    let appellant = _prefixId.prefix "appellant"
    /// <summary>
    ///   <para>skos:definition : A person or corporate body who appeals a lower court's decision.skos:definition : Eine natürliche oder juristische Person, die gegen ein Gerichtsurteil einer unteren Instanz Rechtsmittel (Berufung / Revision) einlegt. </para>
    ///   <para>rdfs:label : Berufungskläger / Revisionskläger (Werk)rdfs:label : Appellant (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellantWork</para>
    ///   <a href="http://rdvocab.info/roles/appellantWork">rdarole:appellantWork</a>
    /// </summary>
    let appellantWork = _prefixId.prefix "appellantWork"
    /// <summary>
    ///   <para>skos:definition : Eine natürliche oder juristische Person, gegen die Rechtsmittel (Berufung / Revision) eingelegt wurde. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appellee</para>
    ///   <para>rdfs:label : Appelleerdfs:label : Berufungsbeklagter / Revisionsbeklagter </para>
    ///   <a href="http://rdvocab.info/roles/appellee">rdarole:appellee</a>
    /// </summary>
    let appellee = _prefixId.prefix "appellee"
    /// <summary>
    ///   <para>skos:definition : A person or corporate body against whom an appeal is taken.skos:definition : Eine natürliche oder juristische Person, gegen die Rechtsmittel (Berufung / Revision) eingelegt wurde. </para>
    ///   <para>rdfs:label : Berufungsbeklagter / Revisionsbeklagter (Werk)rdfs:label : Appellee (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appelleeWork</para>
    ///   <a href="http://rdvocab.info/roles/appelleeWork">rdarole:appelleeWork</a>
    /// </summary>
    let appelleeWork = _prefixId.prefix "appelleeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architect</para>
    ///   <para>rdfs:label : Architectrdfs:label : Architekt</para>
    ///   <a href="http://rdvocab.info/roles/architect">rdarole:architect</a>
    /// </summary>
    let architect = _prefixId.prefix "architect"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für eine architektonische Gestaltung verantwortlich ist, einschließlich einer bildlichen Darstellung, die zeigt, wie ein Gebäude o. ä. aussieht, wenn es fertig gebaut sein wird.skos:definition : A person, family, or corporate body responsible for creating an architectural design, including a pictorial representation intended to show how a building, etc., will look when completed.</para>
    ///   <para>rdfs:label : Architekt (Werk)rdfs:label : Architect (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : architectWork</para>
    ///   <a href="http://rdvocab.info/roles/architectWork">rdarole:architectWork</a>
    /// </summary>
    let architectWork = _prefixId.prefix "architectWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusic</para>
    ///   <para>rdfs:label : Arranger of musicrdfs:label : Arrangeur</para>
    ///   <a href="http://rdvocab.info/roles/arrangerOfMusic">rdarole:arrangerOfMusic</a>
    /// </summary>
    let arrangerOfMusic = _prefixId.prefix "arrangerOfMusic"
    /// <summary>
    ///   <para>rdfs:label : Arrangeur (Expression)rdfs:label : Arranger of music (Expression)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Musikwerkes beiträgt, indem sie eine Komposition mit einer bestimmen Originalbesetzung für eine andere Besetzung umschreibt oder das Werk für die Originalbesetzung modifiziert. Das Wesen des originären Musikstückes bleibt dabei unverändert. skos:definition : A person, family, or corporate body contributing to an expression of a musical work by rewriting the composition for a medium of performance different from that for which the work was originally intended, modifying the work for the same medium of performance, etc., such that the musical substance of the original composition remains essentially unchanged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : arrangerOfMusicExpression</para>
    ///   <a href="http://rdvocab.info/roles/arrangerOfMusicExpression">rdarole:arrangerOfMusicExpression</a>
    /// </summary>
    let arrangerOfMusicExpression = _prefixId.prefix "arrangerOfMusicExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirector</para>
    ///   <para>rdfs:label : Art directorrdfs:label : Art Director</para>
    ///   <a href="http://rdvocab.info/roles/artDirector">rdarole:artDirector</a>
    /// </summary>
    let artDirector = _prefixId.prefix "artDirector"
    /// <summary>
    ///   <para>rdfs:label : Art director (Expression)rdfs:label : Art Director (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artDirectorExpression</para>
    ///   <para>skos:definition : A person, family or corporate body responsible for overseeing the artists and craftspeople who build the sets for moving image productions.skos:definition : Eine Person, Familie oder Körperschaft, die für die Künstler und Kunsthandwerker, die ein Set für eine Bewegtbildproduktion aufbauen, verantwortlich ist. </para>
    ///   <a href="http://rdvocab.info/roles/artDirectorExpression">rdarole:artDirectorExpression</a>
    /// </summary>
    let artDirectorExpression = _prefixId.prefix "artDirectorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artist</para>
    ///   <para>rdfs:label : Artistrdfs:label : Künstler</para>
    ///   <a href="http://rdvocab.info/roles/artist">rdarole:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artistWork</para>
    ///   <para>rdfs:label : Künstler (Werk)rdfs:label : Artist (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Idee und meist auch Umsetzung eines Werkes in Form einer Grafik, einer Zeichnung oder eines Gemäldes verantwortlich ist.skos:definition : A person, family, or corporate body responsible for creating a work by conceiving, and often implementing, an original graphic design, drawing, painting, etc.</para>
    ///   <a href="http://rdvocab.info/roles/artistWork">rdarole:artistWork</a>
    /// </summary>
    let artistWork = _prefixId.prefix "artistWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die verantwortlich für die Erstellung eines Werkes ist, das im Wesentlichen aus Text besteht, unabhängig vom Medientyp (gedruckter Text, gesprochenes Wort, elektronischer Text, taktiler Text usw.) oder von der Gattung (Gedichte, Romane, Drehbücher, Blogs usw.). Die Rolle wird auch für Personen verwendet, die den Charakter und den Inhalt eines Originalwerkes wesentlich durch Paraphrasieren, Umschreiben oder Adaption verändern und so ein neues Werk erschaffen, oder den Medientyp einer Expression ändern. </para>
    ///   <para>rdfs:label : Verfasserrdfs:label : Author</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : author</para>
    ///   <a href="http://rdvocab.info/roles/author">rdarole:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : authorWork</para>
    ///   <para>rdfs:label : Author (Work)rdfs:label : Verfasser (Werk)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die verantwortlich für die Erstellung eines Werkes ist, das im Wesentlichen aus Text besteht, unabhängig vom Medientyp (gedruckter Text, gesprochenes Wort, elektronischer Text, taktiler Text usw.) oder von der Gattung (Gedichte, Romane, Drehbücher, Blogs usw.). Die Rolle wird auch für Personen verwendet, die den Charakter und den Inhalt eines Originalwerkes wesentlich durch Paraphrasieren, Umschreiben oder Adaption verändern und so ein neues Werk erschaffen, oder den Medientyp einer Expression ändern.skos:definition : A person, family, or corporate body responsible for creating a work that is primarily textual in content, regardless of media type (e.g., printed text, spoken word, electronic text, tactile text) or genre (e.g., poems, novels, screenplays, blogs). Use also for persons, etc., creating a new work by paraphrasing, rewriting, or adapting works by another creator such that the modification has substantially changed the nature and content of the original or changed the medium of expression.</para>
    ///   <a href="http://rdvocab.info/roles/authorWork">rdarole:authorWork</a>
    /// </summary>
    let authorWork = _prefixId.prefix "authorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographer</para>
    ///   <para>rdfs:label : Autographerrdfs:label : Unterzeichner</para>
    ///   <a href="http://rdvocab.info/roles/autographer">rdarole:autographer</a>
    /// </summary>
    let autographer = _prefixId.prefix "autographer"
    /// <summary>
    ///   <para>rdfs:label : Unterzeichner (Exemplar)rdfs:label : Autographer (item)</para>
    ///   <para>skos:definition : Eine Person, deren handschriftliche Unterschrift auf einem Exemplar steht.skos:definition : A person whose manuscript signature appears on an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographerItem</para>
    ///   <a href="http://rdvocab.info/roles/autographerItem">rdarole:autographerItem</a>
    /// </summary>
    let autographerItem = _prefixId.prefix "autographerItem"
    /// <summary>
    ///   <para>skos:definition : Eine Person, die ein Exemplar bindet. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binder</para>
    ///   <para>rdfs:label : Binderrdfs:label : Buchbinder </para>
    ///   <a href="http://rdvocab.info/roles/binder">rdarole:binder</a>
    /// </summary>
    let binder = _prefixId.prefix "binder"
    /// <summary>
    ///   <para>rdfs:label : Eine Person, die ein Exemplar bindet. rdfs:label : Buchbinder (Exemplar)rdfs:label : Binder (Item)</para>
    ///   <para>skos:definition : A person who binds a specific item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binderItem</para>
    ///   <a href="http://rdvocab.info/roles/binderItem">rdarole:binderItem</a>
    /// </summary>
    let binderItem = _prefixId.prefix "binderItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesigner</para>
    ///   <para>rdfs:label : Book designerrdfs:label : Buchgestalter</para>
    ///   <a href="http://rdvocab.info/roles/bookDesigner">rdarole:bookDesigner</a>
    /// </summary>
    let bookDesigner = _prefixId.prefix "bookDesigner"
    /// <summary>
    ///   <para>rdfs:label : Buchgestalter (Manifestation)rdfs:label : Book designer (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookDesignerManifestation</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das gesamte grafische Design eines Buches verantwortlich ist, einschließlich Schriftbild, Bildgestaltung, Materialwahl und der angewandten Verfahren.skos:definition : A person, family, or corporate body involved in manufacturing a manifestation by being responsible for the entire graphic design of a book, including arrangement of type and illustration, choice of materials, and process used.</para>
    ///   <a href="http://rdvocab.info/roles/bookDesignerManifestation">rdarole:bookDesignerManifestation</a>
    /// </summary>
    let bookDesignerManifestation = _prefixId.prefix "bookDesignerManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosser</para>
    ///   <para>rdfs:label : Braille embosserrdfs:label : Brailleschriftpräger </para>
    ///   <a href="http://rdvocab.info/roles/brailleEmbosser">rdarole:brailleEmbosser</a>
    /// </summary>
    let brailleEmbosser = _prefixId.prefix "brailleEmbosser"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die im Herstellungsprozess einer Manifestation in Form von Braillezeichen involviert ist. Für das Prägen wird ein Griffel, ein spezieller Brailledrucker oder ein anderes Gerät verwendet.skos:definition : A person, family, or corporate body involved in producing a manifestation by embossing Braille cells using a stylus, special embossing printer, or other device.</para>
    ///   <para>rdfs:label : Brailleschriftpräger (Manifestation)rdfs:label : Braille embosser (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : brailleEmbosserManifestation</para>
    ///   <a href="http://rdvocab.info/roles/brailleEmbosserManifestation">rdarole:brailleEmbosserManifestation</a>
    /// </summary>
    let brailleEmbosserManifestation = _prefixId.prefix "brailleEmbosserManifestation"
    /// <summary>
    ///   <para>skos:definition : Eine Person, eine Familie oder eine Körperschaft, die für Ausstrahlung einer Manifestation über Hörfunk, Fernsehen oder Webcast usw. verantwortlich ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcaster</para>
    ///   <para>rdfs:label : Broadcasterrdfs:label : Broadcaster</para>
    ///   <a href="http://rdvocab.info/roles/broadcaster">rdarole:broadcaster</a>
    /// </summary>
    let broadcaster = _prefixId.prefix "broadcaster"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for broadcasting a manifestation to an audience via radio, television, webcast, etc.skos:definition : Eine Person, eine Familie oder eine Körperschaft, die für Ausstrahlung einer Manifestation über Hörfunk, Fernsehen oder Webcast usw. verantwortlich ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcasterManifestation</para>
    ///   <para>rdfs:label : Broadcaster (Manifestation)rdfs:label : Broadcaster (Manifestation)</para>
    ///   <a href="http://rdvocab.info/roles/broadcasterManifestation">rdarole:broadcasterManifestation</a>
    /// </summary>
    let broadcasterManifestation = _prefixId.prefix "broadcasterManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographer</para>
    ///   <para>rdfs:label : Cartographerrdfs:label : Kartograf </para>
    ///   <a href="http://rdvocab.info/roles/cartographer">rdarole:cartographer</a>
    /// </summary>
    let cartographer = _prefixId.prefix "cartographer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cartographerWork</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating a map, atlase, globe, or other cartographic work.skos:definition : Eine Person, Familie oder Körperschaft, die für das Erstellen einer Karte, eines Atlasses, eines Globusses oder eines anderen kartografischen Werkes verantwortlich ist.</para>
    ///   <para>rdfs:label : Kartograf (Werk)rdfs:label : Cartographer (Work)</para>
    ///   <a href="http://rdvocab.info/roles/cartographerWork">rdarole:cartographerWork</a>
    /// </summary>
    let cartographerWork = _prefixId.prefix "cartographerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : caster</para>
    ///   <para>rdfs:label : Casterrdfs:label : Formgießer </para>
    ///   <a href="http://rdvocab.info/roles/caster">rdarole:caster</a>
    /// </summary>
    let caster = _prefixId.prefix "caster"
    /// <summary>
    ///   <para>rdfs:label : Formgießer (Manifestation)rdfs:label : Caster (Manifestation)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die in den Herstellungsprozess einer Manifestation durch das Gießen einer Flüssigkeit oder einer geschmolzenen Substanz in eine Form involviert ist.
    /// Die Substanz verbleibt in der Gießform, bis sie ausgehärtet ist. skos:definition : A person, family, or corporate body involved in producing a manifestation by pouring a liquid or molten substance into a mold and leaving it to solidify to take the shape of the mold.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : casterManifestation</para>
    ///   <a href="http://rdvocab.info/roles/casterManifestation">rdarole:casterManifestation</a>
    /// </summary>
    let casterManifestation = _prefixId.prefix "casterManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographer</para>
    ///   <para>rdfs:label : Choreographer rdfs:label : Choreograf </para>
    ///   <a href="http://rdvocab.info/roles/choreographer">rdarole:choreographer</a>
    /// </summary>
    let choreographer = _prefixId.prefix "choreographer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerExpression</para>
    ///   <para>rdfs:label : Choreographer (Expression)rdfs:label : Choreograph (Expression)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für ein aus Bewegung bestehendes Werk verantwortlich ist. skos:definition : A person, family, or corporate body contributing to an expression of a work by providing additional choreography, or by modifying the previous choreography.</para>
    ///   <a href="http://rdvocab.info/roles/choreographerExpression">rdarole:choreographerExpression</a>
    /// </summary>
    let choreographerExpression = _prefixId.prefix "choreographerExpression"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating a work of movement.skos:definition : Eine Person, Familie oder Körperschaft, die für ein aus Bewegung bestehendes Werk verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographerWork</para>
    ///   <para>rdfs:label : Choreograf (Werk)rdfs:label : Choreographer (Work)</para>
    ///   <a href="http://rdvocab.info/roles/choreographerWork">rdarole:choreographerWork</a>
    /// </summary>
    let choreographerWork = _prefixId.prefix "choreographerWork"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a moving image work by capturing images either electronically or on film or video stock using a visual recording device, and often the selection and arrangement of lighting. The chief cinematographer for a movie is also called the director of photography. Use this designation also for videographers.skos:definition : Eine Person, eine Familie oder eine Körperschaft, die zu einer Expression eines Bewegtbildwerkes  beiträgt, indem sie die Bilder mit einem Aufzeichnungsgerät aufnimmt, entweder in elektronischer Form oder auf Film oder Video. Häufig gehört auch die Auswahl der Bilder und die Beleuchtung dazu. Der leitende Kameramann wird auch verantwortlicher Kameramann genannt. Die Bezeichnung „Kameramann" wird auch für einen Videografen verwendet.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cinematographer</para>
    ///   <para>rdfs:label : Cinematographerrdfs:label : Kameramann</para>
    ///   <a href="http://rdvocab.info/roles/cinematographer">rdarole:cinematographer</a>
    /// </summary>
    let cinematographer = _prefixId.prefix "cinematographer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrar</para>
    ///   <para>rdfs:label : Collection registrarrdfs:label : Registrar </para>
    ///   <a href="http://rdvocab.info/roles/collectionRegistrar">rdarole:collectionRegistrar</a>
    /// </summary>
    let collectionRegistrar = _prefixId.prefix "collectionRegistrar"
    /// <summary>
    ///   <para>skos:definition : A type of curator who lists or inventories the items in an aggregate work such as a collection of items or works.skos:definition : Jemand, der die Exemplare eines zusammengestellten Werkes, wie beispielsweise eine Sammlung von Exemplaren oder Werken, verzeichnet und inventarisiert.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrarItem</para>
    ///   <para>rdfs:label : Collection registrar (Item)rdfs:label : Registrar (Exemplar)</para>
    ///   <a href="http://rdvocab.info/roles/collectionRegistrarItem">rdarole:collectionRegistrarItem</a>
    /// </summary>
    let collectionRegistrarItem = _prefixId.prefix "collectionRegistrarItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collector</para>
    ///   <para>rdfs:label : Collectorrdfs:label : Sammler</para>
    ///   <a href="http://rdvocab.info/roles/collector">rdarole:collector</a>
    /// </summary>
    let collector = _prefixId.prefix "collector"
    /// <summary>
    ///   <para>skos:definition : A curator who brings together material from various sources that are then arranged, described, and cataloged as a collection.skos:definition : Jemand, der Materialien aus unterschiedlichen Quellen zusammenträgt, die zu einer Sammlung zusammengestellt, beschrieben und katalogisiert werden.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectorItem</para>
    ///   <para>rdfs:label : Collector (Item)rdfs:label : Sammler (Exemplar)</para>
    ///   <a href="http://rdvocab.info/roles/collectorItem">rdarole:collectorItem</a>
    /// </summary>
    let collectorItem = _prefixId.prefix "collectorItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyper</para>
    ///   <para>rdfs:label : Collotyperrdfs:label : Drucker (im Lichtdruckverfahren) </para>
    ///   <a href="http://rdvocab.info/roles/collotyper">rdarole:collotyper</a>
    /// </summary>
    let collotyper = _prefixId.prefix "collotyper"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an der Produktion einer Manifestation aus Fotodrucken von Film oder einem anderem Kolloiden, der Druckerfarbe anziehende und abstoßende Flächen aufweist, beteiligt ist.skos:definition : A person, family, or corporate body involved in producing a manifestation of photographic prints from film or other colloid that has ink-receptive and ink-repellent surfaces.</para>
    ///   <para>rdfs:label : Drucker (im Lichtdruckverfahren) (Manifestation)rdfs:label : Collotyper (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collotyperManifestation</para>
    ///   <a href="http://rdvocab.info/roles/collotyperManifestation">rdarole:collotyperManifestation</a>
    /// </summary>
    let collotyperManifestation = _prefixId.prefix "collotyperManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentator</para>
    ///   <para>rdfs:label : Commentatorrdfs:label : Kommentator (mündlich) </para>
    ///   <a href="http://rdvocab.info/roles/commentator">rdarole:commentator</a>
    /// </summary>
    let commentator = _prefixId.prefix "commentator"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by providing interpretation, analysis, or a discussion of the subject matter on a recording, film, or other audiovisual medium.skos:definition : Jemand, der zu einer Expression eines Werkes in einer Aufnahme, in einem Film oder in einem anderen audiovisuellen Medium in Form einer Interpretation, einer Analyse oder einer Diskussion des Themas beiträgt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentatorExpression</para>
    ///   <para>rdfs:label : Commentator (Expression)rdfs:label : Kommentator (mündlich) (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/commentatorExpression">rdarole:commentatorExpression</a>
    /// </summary>
    let commentatorExpression = _prefixId.prefix "commentatorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compiler</para>
    ///   <para>rdfs:label : Compilerrdfs:label : Compiler </para>
    ///   <a href="http://rdvocab.info/roles/compiler">rdarole:compiler</a>
    /// </summary>
    let compiler = _prefixId.prefix "compiler"
    /// <summary>
    ///   <para>rdfs:label : Compiler (Werk)rdfs:label : Compiler (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das Erstellen eines Werkes durch eine Zusammenstellung verantwortlich ist, beispielsweise durch Selektieren, Gliedern, Zusammenstellen und Editieren von Daten, Information, usw. skos:definition : A person, family, or corporate body responsible for creating a new work (e.g., a bibliography, a directory) through the act of compilation, e.g., selecting, arranging, aggregating, and editing data, information, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : compilerWork</para>
    ///   <a href="http://rdvocab.info/roles/compilerWork">rdarole:compilerWork</a>
    /// </summary>
    let compilerWork = _prefixId.prefix "compilerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composer</para>
    ///   <para>rdfs:label : Composerrdfs:label : Komponist </para>
    ///   <a href="http://rdvocab.info/roles/composer">rdarole:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>rdfs:label : Composer (Expression)rdfs:label : Komponist (Expression)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Werkes beiträgt, indem sie als Ersatz für die Originalmusik neue Musik komponiert oder neue Musik komponiert, die die existierende Musik ergänzt.skos:definition : A person, family, or corporate body contributing to an expression by composing new music to substitute for the original music, or by composing new music to supplement the existing music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerExpression</para>
    ///   <a href="http://rdvocab.info/roles/composerExpression">rdarole:composerExpression</a>
    /// </summary>
    let composerExpression = _prefixId.prefix "composerExpression"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a musical work by composing accompaniments or additional parts (e.g., vocal/instrumental parts, musical numbers) that supplement the music written by the original composer.skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Musikwerkes durch Begleitkompositionen oder Zusätze (wie zusätzliche Parts für Stimmen/Instrumente oder weitere Musikstücke) beiträgt, welche die Musik des ursprünglichen Komponisten ergänzen.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfAdditionalMusic</para>
    ///   <para>rdfs:label : Composer of Additional Musicrdfs:label : Komponist eines zusätzlichen Musikstückes </para>
    ///   <a href="http://rdvocab.info/roles/composerOfAdditionalMusic">rdarole:composerOfAdditionalMusic</a>
    /// </summary>
    let composerOfAdditionalMusic = _prefixId.prefix "composerOfAdditionalMusic"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a musical work by composing accompaniments or additional parts (e.g., vocal/instrumental parts, musical numbers) that supplement the music written by the original composer. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfAdditionalMusicExpression</para>
    ///   <para>rdfs:label : Composer of Additional Music (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/composerOfAdditionalMusicExpression">rdarole:composerOfAdditionalMusicExpression</a>
    /// </summary>
    let composerOfAdditionalMusicExpression =
        _prefixId.prefix "composerOfAdditionalMusicExpression"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by composing music for a pre-existing, usually textual, work.skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Werkes durch die Komposition von Musik für ein bereits bestehendes, meist textliches, Werk beiträgt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfIncidentalMusic</para>
    ///   <para>rdfs:label : Composer of Incidental Musicrdfs:label : Komponist von Begleitmusik </para>
    ///   <a href="http://rdvocab.info/roles/composerOfIncidentalMusic">rdarole:composerOfIncidentalMusic</a>
    /// </summary>
    let composerOfIncidentalMusic = _prefixId.prefix "composerOfIncidentalMusic"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by composing music for a pre-existing, usually textual, work. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfIncidentalMusicExpression</para>
    ///   <para>rdfs:label : Composer of Incidental Music (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/composerOfIncidentalMusicExpression">rdarole:composerOfIncidentalMusicExpression</a>
    /// </summary>
    let composerOfIncidentalMusicExpression =
        _prefixId.prefix "composerOfIncidentalMusicExpression"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for contributing compositions to accompany the presentation of a moving image work produced in the silent film era and recorded without a synchronized, integrated soundtrack. These musical works may be originally written for the moving image or may consist of or incorporate pre-existing works in a manner that is intended to complement the moving image.skos:definition : Eine Person, Familie oder Körperschaft, die für Kompositionen zur Begleitung von Bewegtbildwerken aus der Stummfilmzeit, die ohne synchronisierten und integrierten Ton aufgenommen wurden, verantwortlich ist. Diese Musikwerke können entweder eigens für das bewegte Bild geschrieben sein oder aber aus bereits existierenden Werken bestehen bzw. sich zusammensetzen, die vorgesehen sind, das bewegte Bild zu ergänzen.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfMusicForSilentFilm</para>
    ///   <para>rdfs:label : Composer of Music for Silent Filmrdfs:label : Komponist von Stummfilm-Musik </para>
    ///   <a href="http://rdvocab.info/roles/composerOfMusicForSilentFilm">rdarole:composerOfMusicForSilentFilm</a>
    /// </summary>
    let composerOfMusicForSilentFilm = _prefixId.prefix "composerOfMusicForSilentFilm"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for contributing compositions to accompany the presentation of a moving image work produced in the silent film era and recorded without a synchronized, integrated soundtrack. These musical works may be originally written for the moving image or may consist of or incorporate pre-existing works in a manner that is intended to complement the moving image. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfMusicForSilentFilmExpression</para>
    ///   <para>rdfs:label : Composer of Music for Silent Film (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/composerOfMusicForSilentFilmExpression">rdarole:composerOfMusicForSilentFilmExpression</a>
    /// </summary>
    let composerOfMusicForSilentFilmExpression =
        _prefixId.prefix "composerOfMusicForSilentFilmExpression"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for contributing compositions that form part of the presentation of a moving image work recorded with a synchronized, integrated soundtrack. These musical works may be originally written for the moving image or be pre-existing works that are incorporated into the moving image soundtrack.skos:definition : Eine Person, Familie oder Körperschaft, die für Kompositionen verantwortlich ist, die einen Teil eines Bewegtbildwerkes  bilden, das mit synchronisiertem und integriertem Ton aufgenommen wurde. Diese Musikwerke können entweder eigens für das bewegte Bild geschriebene oder bereits bestehende Werke sein, die in den Bewegtbildsoundtrack eingebunden wurden.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfMusicForSoundFilm</para>
    ///   <para>rdfs:label : Composer of Music for Sound Filmrdfs:label : Filmkomponist </para>
    ///   <a href="http://rdvocab.info/roles/composerOfMusicForSoundFilm">rdarole:composerOfMusicForSoundFilm</a>
    /// </summary>
    let composerOfMusicForSoundFilm = _prefixId.prefix "composerOfMusicForSoundFilm"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for contributing compositions that form part of the presentation of a moving image work recorded with a synchronized, integrated soundtrack. These musical works may be originally written for the moving image or be pre-existing works that are incorporated into the moving image soundtrack.skos:definition : Eine Person, Familie oder Körperschaft, die für Kompositionen verantwortlich ist, die einen Teil eines Bewegtbildwerkes  bilden, das mit synchronisiertem und integriertem Ton aufgenommen wurde. Diese Musikwerke können entweder eigens für das bewegte Bild geschriebene oder bereits bestehende Werke sein, die in den Bewegtbildsoundtrack eingebunden wurden.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerOfMusicForSoundFilmExpression</para>
    ///   <para>rdfs:label : Composer of Music for Sound Film (Expression)rdfs:label : Filmkomponist (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/composerOfMusicForSoundFilmExpression">rdarole:composerOfMusicForSoundFilmExpression</a>
    /// </summary>
    let composerOfMusicForSoundFilmExpression =
        _prefixId.prefix "composerOfMusicForSoundFilmExpression"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating a musical work. Use also for persons, etc., adapting another musical work to form a distinct alteration (e.g., free transcription), paraphrasing a work or creating a work in the general style of another composer, or creating a work that is based on the music of another composer (e.g., variations on a theme).skos:definition :
    /// 	Eine Person, Familie oder Körperschaft, die für ein Musikwerk verantwortlich ist. Die Bezeichnung wird auch für Personen usw. verwendet, die ein anderes Musikwerk adaptiert haben, das sich deutlich vom Original unterscheidet, beispielsweise eine freie Bearbeitung. Oder die ein Werk im Stil eines anderen Komponisten umgeschrieben oder erschaffen hat oder ein Werk, das auf der Musik eines anderen Komponisten basiert, wie beispielsweise Variationen eines Themas. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : composerWork</para>
    ///   <para>rdfs:label : Composer (Work)rdfs:label : Komponist (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/composerWork">rdarole:composerWork</a>
    /// </summary>
    let composerWork = _prefixId.prefix "composerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductor</para>
    ///   <para>rdfs:label : Conductorrdfs:label : Dirigent </para>
    ///   <a href="http://rdvocab.info/roles/conductor">rdarole:conductor</a>
    /// </summary>
    let conductor = _prefixId.prefix "conductor"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a musical work by leading a performing group (orchestra, chorus, opera, etc.) in a musical or dramatic presentation, etc.skos:definition : Jemand, der zu einer Expression eines Musikwerkes beiträgt, indem er ein aufführendes Ensemble (Orchester, Chor, Oper usw.) in einer musikalischen oder darstellenden Vorführung leitet.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : conductorExpression</para>
    ///   <para>rdfs:label : Conductor (Expression)rdfs:label : Dirigent (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/conductorExpression">rdarole:conductorExpression</a>
    /// </summary>
    let conductorExpression = _prefixId.prefix "conductorExpression"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an der Realisierung eines Werkes durch eine Expression mitwirkt. Zu den Mitwirkenden gehören Herausgeber, Übersetzer, Arrangeure/Bearbeiter für Musik, Darsteller, usw. skos:definition : A person, family, or corporate body contributing to the realization of a work through an expression. Contributors include editors, translators, arrangers of music, performers, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contributor</para>
    ///   <para>rdfs:label : Contributorrdfs:label : Mitwirkender </para>
    ///   <a href="http://rdvocab.info/roles/contributor">rdarole:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesigner</para>
    ///   <para>rdfs:label : Costume designerrdfs:label : Kostümbildner </para>
    ///   <a href="http://rdvocab.info/roles/costumeDesigner">rdarole:costumeDesigner</a>
    /// </summary>
    let costumeDesigner = _prefixId.prefix "costumeDesigner"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das Design der Kostüme für eine Bewegtbildproduktion, ein Musical, eine Theateraufführung oder Entertainment verantwortlich ist.skos:definition : A person, family, or corporate body responsible for designing the costumes for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : costumeDesignerExpression</para>
    ///   <para>rdfs:label : Costume designer (Expression)rdfs:label : Kostümbildner (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/costumeDesignerExpression">rdarole:costumeDesignerExpression</a>
    /// </summary>
    let costumeDesignerExpression = _prefixId.prefix "costumeDesignerExpression"
    /// <summary>
    ///   <para>skos:definition : Ein Gericht geregelt von der Prozessordnung (unabhängig von deren förmlicher Rechtsnatur, zum Beispiel Gesetze, Verwaltungsvorschriften).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGoverned</para>
    ///   <para>rdfs:label : Court governedrdfs:label : Court governed</para>
    ///   <a href="http://rdvocab.info/roles/courtGoverned">rdarole:courtGoverned</a>
    /// </summary>
    let courtGoverned = _prefixId.prefix "courtGoverned"
    /// <summary>
    ///   <para>skos:definition : A court governed by court rules (regardless of their official nature, e.g., laws, administrative regulations).skos:definition : Ein Gericht geregelt von der Prozessordnung (unabhängig von deren förmlicher Rechtsnatur, zum Beispiel Gesetze, Verwaltungsvorschriften).</para>
    ///   <para>rdfs:label : Court governedrdfs:label : Court governed (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtGovernedWork</para>
    ///   <a href="http://rdvocab.info/roles/courtGovernedWork">rdarole:courtGovernedWork</a>
    /// </summary>
    let courtGovernedWork = _prefixId.prefix "courtGovernedWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Werkes beiträgt, indem sie die Auffassung eines Gerichts zur Veröffentlichung vorbereitet.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporter</para>
    ///   <para>rdfs:label : Court reporterrdfs:label : Gerichtsstenograf</para>
    ///   <a href="http://rdvocab.info/roles/courtReporter">rdarole:courtReporter</a>
    /// </summary>
    let courtReporter = _prefixId.prefix "courtReporter"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by preparing a court’s opinions for publication.skos:definition : Eine Person, Familie oder Körperschaft, die zu einer Expression eines Werkes beiträgt, indem sie die Auffassung eines Gerichts zur Veröffentlichung vorbereitet.
    /// </para>
    ///   <para>rdfs:label : Court reporter (Expression)rdfs:label : Gerichtsstenograf (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : courtReporterExpression</para>
    ///   <a href="http://rdvocab.info/roles/courtReporterExpression">rdarole:courtReporterExpression</a>
    /// </summary>
    let courtReporterExpression = _prefixId.prefix "courtReporterExpression"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for the creation of a work.skos:definition : Eine Person, Familie oder Körperschaft, die für die Schaffung eines Werkes verantwortlich ist.</para>
    ///   <para>rdfs:label : Creatorrdfs:label : geistiger Schöpfer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : creator</para>
    ///   <a href="http://rdvocab.info/roles/creator">rdarole:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curator</para>
    ///   <para>rdfs:label : Curatorrdfs:label : Kurator </para>
    ///   <a href="http://rdvocab.info/roles/curator">rdarole:curator</a>
    /// </summary>
    let curator = _prefixId.prefix "curator"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curatorItem</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die Zusammenstellungen entwirft und/oder eine Ausstellung, eine Sammlung oder andere Exemplare organisiert.skos:definition : A person, family, or corporate body conceiving, aggregating, and/or organizing an exhibition, collection, or other item.</para>
    ///   <para>rdfs:label : Kurator (Exemplar)rdfs:label : Curator (Item)</para>
    ///   <a href="http://rdvocab.info/roles/curatorItem">rdarole:curatorItem</a>
    /// </summary>
    let curatorItem = _prefixId.prefix "curatorItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwner</para>
    ///   <para>rdfs:label : Current ownerrdfs:label : Derzeitiger Besitzer </para>
    ///   <a href="http://rdvocab.info/roles/currentOwner">rdarole:currentOwner</a>
    /// </summary>
    let currentOwner = _prefixId.prefix "currentOwner"
    /// <summary>
    ///   <para>rdfs:label : Derzeitiger Besitzer (Exemplar)rdfs:label : Current owner (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwnerItem</para>
    ///   <para>skos:definition : A person, family, or corporate body currently having legal possession of an item (i.e., a specific copy or instance of a resource).skos:definition : Eine Person, Familie oder Körperschaft, die derzeit rechtmäßig im Besitz eines Exemplars ist (z. B. einer bestimmten Kopie oder eines bestimmten Exemplars einer Ressource).</para>
    ///   <a href="http://rdvocab.info/roles/currentOwnerItem">rdarole:currentOwnerItem</a>
    /// </summary>
    let currentOwnerItem = _prefixId.prefix "currentOwnerItem"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die der rechtmäßige Besitzer eines Objekts ist (d.h., einer bestimmten Kopie oder Instanz einer Ressource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodian</para>
    ///   <para>rdfs:label : Custodianrdfs:label : Besitzer</para>
    ///   <a href="http://rdvocab.info/roles/custodian">rdarole:custodian</a>
    /// </summary>
    let custodian = _prefixId.prefix "custodian"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die der rechtmäßige Besitzer eines Objekts ist (d.h., einer bestimmten Kopie oder Instanz einer Ressource).skos:definition : A person, family, or corporate body having legal custody of an item (i.e., a specific copy or instance of a resource).</para>
    ///   <para>rdfs:label : Besitzer (Exemplar)rdfs:label : Custodian (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodianItem</para>
    ///   <a href="http://rdvocab.info/roles/custodianItem">rdarole:custodianItem</a>
    /// </summary>
    let custodianItem = _prefixId.prefix "custodianItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancer</para>
    ///   <para>rdfs:label : Dancerrdfs:label : Tänzer </para>
    ///   <a href="http://rdvocab.info/roles/dancer">rdarole:dancer</a>
    /// </summary>
    let dancer = _prefixId.prefix "dancer"
    /// <summary>
    ///   <para>rdfs:label : Dancer (Expression)rdfs:label : Tänzer (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dancerExpression</para>
    ///   <para>skos:definition : A performer contributing to an expression of a work by dancing in a musical, dramatic, etc., presentation.skos:definition : Ein Darsteller, der durch Tanzen in einer musikalischen, dramatischen oder ähnlichen Darbietung an einer Expression eines Werkes mitwirkt.</para>
    ///   <a href="http://rdvocab.info/roles/dancerExpression">rdarole:dancerExpression</a>
    /// </summary>
    let dancerExpression = _prefixId.prefix "dancerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicatee</para>
    ///   <para>rdfs:label : Dedicateerdfs:label : Person, der ein Werk gewidmet ist </para>
    ///   <a href="http://rdvocab.info/roles/dedicatee">rdarole:dedicatee</a>
    /// </summary>
    let dedicatee = _prefixId.prefix "dedicatee"
    /// <summary>
    ///   <para>rdfs:label : Person, der ein Exemplar gewidmet istrdfs:label : Dedicatee of Item</para>
    ///   <para>skos:definition : A person, family, or corporate body to whom an item is dedicated.skos:definition : Eine Person, Familie oder Körperschaft, der ein Exemplar gewidmet ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeOfItem</para>
    ///   <a href="http://rdvocab.info/roles/dedicateeOfItem">rdarole:dedicateeOfItem</a>
    /// </summary>
    let dedicateeOfItem = _prefixId.prefix "dedicateeOfItem"
    /// <summary>
    ///   <para>rdfs:label : Dedicatee (Work)rdfs:label : Person, der ein Werk gewidmet ist </para>
    ///   <para>skos:definition : A person, family, or corporate body to whom the work is dedicated.skos:definition : Eine Person, Familie oder Körperschaft, der das Werk gewidmet ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeWork</para>
    ///   <a href="http://rdvocab.info/roles/dedicateeWork">rdarole:dedicateeWork</a>
    /// </summary>
    let dedicateeWork = _prefixId.prefix "dedicateeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendant</para>
    ///   <para>rdfs:label : Defendantrdfs:label : Angeklagter/Beklagter (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/defendant">rdarole:defendant</a>
    /// </summary>
    let defendant = _prefixId.prefix "defendant"
    /// <summary>
    ///   <para>rdfs:label : Angeklagter/Beklagter (Werk)rdfs:label : Defendant (Work)</para>
    ///   <para>skos:definition : Eine Person oder Körperschaft, die in einem Strafverfahren angeklagt oder in einem Zivilprozess verklagt ist. skos:definition : A person or corporate body who is accused in a criminal proceeding or sued in a civil proceeding.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : defendantWork</para>
    ///   <a href="http://rdvocab.info/roles/defendantWork">rdarole:defendantWork</a>
    /// </summary>
    let defendantWork = _prefixId.prefix "defendantWork"
    /// <summary>
    ///   <para>skos:definition : Eine Körperschaft, die einen akademischen Grad verleiht, z.T. basierend auf der Einreichung einer Hochschulschrift o.ä. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitution</para>
    ///   <para>rdfs:label : Degree granting institutionrdfs:label : Institution, die einen akademischen Grad verleiht </para>
    ///   <a href="http://rdvocab.info/roles/degreeGrantingInstitution">rdarole:degreeGrantingInstitution</a>
    /// </summary>
    let degreeGrantingInstitution = _prefixId.prefix "degreeGrantingInstitution"
    /// <summary>
    ///   <para>rdfs:label : Degree granting institution (Work)rdfs:label : Institution, die einen akademischen Grad verleiht (Werk)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : degreeGrantingInstitutionWork</para>
    ///   <para>skos:definition : Eine Körperschaft, die einen akademischen Grad verleiht, z.T. basierend auf der Einreichung einer Hochschulschrift o.ä. skos:definition : A corporate body granting an academic degree, based in part on the submission of a thesis, dissertation, etc.</para>
    ///   <a href="http://rdvocab.info/roles/degreeGrantingInstitutionWork">rdarole:degreeGrantingInstitutionWork</a>
    /// </summary>
    let degreeGrantingInstitutionWork = _prefixId.prefix "degreeGrantingInstitutionWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositor</para>
    ///   <para>rdfs:label : Depositorrdfs:label : Leihgeber </para>
    ///   <a href="http://rdvocab.info/roles/depositor">rdarole:depositor</a>
    /// </summary>
    let depositor = _prefixId.prefix "depositor"
    /// <summary>
    ///   <para>skos:definition : A current owner of an item who deposited the item into the custody of another person, family, or corporate body, while still retaining ownership.skos:definition : Der gegenwärtige Eigentümer eines Exemplars, der das Exemplar in die Obhut einer anderen Person, Familie oder Körperschaft gegeben hat, während er weiterhin der Eigentümer bleibt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositorItem</para>
    ///   <para>rdfs:label : Depositor (Item)rdfs:label : Leihgeber (Exemplar)</para>
    ///   <a href="http://rdvocab.info/roles/depositorItem">rdarole:depositorItem</a>
    /// </summary>
    let depositorItem = _prefixId.prefix "depositorItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designer</para>
    ///   <para>rdfs:label : Designerrdfs:label : Designer </para>
    ///   <a href="http://rdvocab.info/roles/designer">rdarole:designer</a>
    /// </summary>
    let designer = _prefixId.prefix "designer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designerWork</para>
    ///   <para>rdfs:label : Designer (Werk)rdfs:label : Designer (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Gestaltung des Designs eines Objekts verantwortlich ist. skos:definition : A person, family, or corporate body responsible for creating a design for an object.</para>
    ///   <a href="http://rdvocab.info/roles/designerWork">rdarole:designerWork</a>
    /// </summary>
    let designerWork = _prefixId.prefix "designerWork"
    /// <summary>
    ///   <para>rdfs:label : Directorrdfs:label : Director</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die allgemeine Leitung und Betreuung einer verfilmten Aufführung, einer Radio- oder Fernsehsendung usw. verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : director</para>
    ///   <a href="http://rdvocab.info/roles/director">rdarole:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotography</para>
    ///   <para>rdfs:label : Director of photographyrdfs:label : Verantwortlicher Kameramann </para>
    ///   <a href="http://rdvocab.info/roles/directorOfPhotography">rdarole:directorOfPhotography</a>
    /// </summary>
    let directorOfPhotography = _prefixId.prefix "directorOfPhotography"
    /// <summary>
    ///   <para>rdfs:comment : Use this designation also for videographers.</para>
    ///   <para>skos:definition : A person, family, or corporate body that captures images, either electronically or on film or video stock, and often selects and arranges the lighting. The director of photography for a movie is also called the chief cinematographer. skos:definition : Eine Person, Familie oder Körperschaft, die Bilder festhält, entweder elektronisch oder auf Film- oder Videomaterial, und häufig die Belichtung auswählt und arrangiert. Der verantwortliche Kameramann für einen Film wird auch als "Leitender Kamermann" bezeichnet. Diese Bezeichnung wird auch für "Videograph" verwendet.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorOfPhotographyWork</para>
    ///   <para>rdfs:label : Verantwortlicher Kameramann (Werk)rdfs:label : Director of photography (Work)</para>
    ///   <a href="http://rdvocab.info/roles/directorOfPhotographyWork">rdarole:directorOfPhotographyWork</a>
    /// </summary>
    let directorOfPhotographyWork = _prefixId.prefix "directorOfPhotographyWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : directorWork</para>
    ///   <para>rdfs:label : Director (Work)</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for the general management and supervision of a filmed performance, a radio or television program, etc.</para>
    ///   <a href="http://rdvocab.info/roles/directorWork">rdarole:directorWork</a>
    /// </summary>
    let directorWork = _prefixId.prefix "directorWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für den Vertrieb einer Ressource verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributor</para>
    ///   <para>rdfs:label : Distributorrdfs:label : Vertrieb</para>
    ///   <a href="http://rdvocab.info/roles/distributor">rdarole:distributor</a>
    /// </summary>
    let distributor = _prefixId.prefix "distributor"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für den Vertrieb einer Ressource verantwortlich ist. skos:definition : A person, family, or corporate body responsible for distributing a resource.</para>
    ///   <para>rdfs:label : Distributor (Manifestation)rdfs:label : Vertrieb (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorManifestation</para>
    ///   <a href="http://rdvocab.info/roles/distributorManifestation">rdarole:distributorManifestation</a>
    /// </summary>
    let distributorManifestation = _prefixId.prefix "distributorManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donor</para>
    ///   <para>rdfs:label : Donorrdfs:label : Stifter </para>
    ///   <a href="http://rdvocab.info/roles/donor">rdarole:donor</a>
    /// </summary>
    let donor = _prefixId.prefix "donor"
    /// <summary>
    ///   <para>skos:definition : Ein ehemaliger Eigentümer eines Exemplars, der dieses Exemplar jemand anderem überlassen hat. skos:definition : A former owner of an item who donated that item to the another owner.</para>
    ///   <para>rdfs:label : Donor (Item)rdfs:label : Stifter (Exemplar)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donorItem</para>
    ///   <a href="http://rdvocab.info/roles/donorItem">rdarole:donorItem</a>
    /// </summary>
    let donorItem = _prefixId.prefix "donorItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsman</para>
    ///   <para>rdfs:label : Draftsmanrdfs:label : Technischer Zeichner</para>
    ///   <a href="http://rdvocab.info/roles/draftsman">rdarole:draftsman</a>
    /// </summary>
    let draftsman = _prefixId.prefix "draftsman"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes eines Architekten, Erfinders oder ähnlichen mitwirkt, indem sie detaillierte Pläne oder Zeichnungen für Gebäude, Schiffe, Flugzeuge, Maschinen, Objekte o.ä. erstellt.skos:definition : A person, family, or corporate body contributing to an expression of a work by an architect, inventor, etc., by making detailed plans or drawings for buildings, ships, aircraft, machines, objects, etc.</para>
    ///   <para>rdfs:label : Draftsman (Expression)rdfs:label : Technischer Zeichner (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : draftsmanExpression</para>
    ///   <a href="http://rdvocab.info/roles/draftsmanExpression">rdarole:draftsmanExpression</a>
    /// </summary>
    let draftsmanExpression = _prefixId.prefix "draftsmanExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editor</para>
    ///   <para>rdfs:label : Editorrdfs:label : Herausgeber </para>
    ///   <a href="http://rdvocab.info/roles/editor">rdarole:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:label : Editor (Expression)rdfs:label : Herausgeber (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorExpression</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by revising or elucidating the content, e.g., adding an introduction, notes, or other critical matter. An editor may also prepare an expression of a work for production, publication, or distribution. skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie den Inhalt überarbeitet oder erläutert, beispielsweise indem sie eine Einleitung oder Anmerkungen oder anderes kritisches Material hinzufügt. Ein Herausgeber kann ebenso eine Expression eines Werkes für die Produktion, die Herausgabe oder den Vertrieb vorbereiten. </para>
    ///   <a href="http://rdvocab.info/roles/editorExpression">rdarole:editorExpression</a>
    /// </summary>
    let editorExpression = _prefixId.prefix "editorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfCompilation</para>
    ///   <para>rdfs:label : Editor of compilationrdfs:label : Compilation Editor</para>
    ///   <a href="http://rdvocab.info/roles/editorOfCompilation">rdarole:editorOfCompilation</a>
    /// </summary>
    let editorOfCompilation = _prefixId.prefix "editorOfCompilation"
    /// <summary>
    ///   <para>rdfs:label : Editor of compilation (Expression)rdfs:label : Compilation Editor </para>
    ///   <para>skos:scopeNote : For compilations of data, information, etc., that result in new works, see Compiler.</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a collective or aggregate work by selecting and putting together works, or parts of works, by one or more creators. The editor of compilation may also be involved in elucidating the content, e.g., adding an introduction, notes, or other critical matter, of the compilation.  For compilations of data, information, etc., that result in new works, see Compiler.skos:definition : Eine Person, Familie oder Körperschaft, die an einem gemeinschaftlichen oder gesammelten Werk mitwirken, indem sie die Werke oder Teile von Werken von einem oder mehreren Schöpfern auswählen und zusammenstellen. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfCompilationExpression</para>
    ///   <a href="http://rdvocab.info/roles/editorOfCompilationExpression">rdarole:editorOfCompilationExpression</a>
    /// </summary>
    let editorOfCompilationExpression = _prefixId.prefix "editorOfCompilationExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageWork</para>
    ///   <para>rdfs:label : Editor of moving image workrdfs:label : Cutter</para>
    ///   <a href="http://rdvocab.info/roles/editorOfMovingImageWork">rdarole:editorOfMovingImageWork</a>
    /// </summary>
    let editorOfMovingImageWork = _prefixId.prefix "editorOfMovingImageWork"

    /// <summary>
    ///   <para>rdfs:label : Editor of moving image work (Expression)rdfs:label : Cutter (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editorOfMovingImageWorkExpression</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for assembling, arranging, and trimming film, video, or other moving image formats, including both visual and audio aspects.skos:definition : Eine Person, Familie oder Körperschaft, die für das Zusammensetzen, Arrangieren und Nachschneiden von Film-, Video- oder anderen Bewegtbildformaten zuständig ist, sowohl Video- als auch Audio-Aspekte umfassend.</para>
    ///   <a href="http://rdvocab.info/roles/editorOfMovingImageWorkExpression">rdarole:editorOfMovingImageWorkExpression</a>
    /// </summary>
    let editorOfMovingImageWorkExpression =
        _prefixId.prefix "editorOfMovingImageWorkExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdiction</para>
    ///   <para>rdfs:label : Enacting jurisdictionrdfs:label : Normerlassender Rechtsträger </para>
    ///   <a href="http://rdvocab.info/roles/enactingJurisdiction">rdarole:enactingJurisdiction</a>
    /// </summary>
    let enactingJurisdiction = _prefixId.prefix "enactingJurisdiction"
    /// <summary>
    ///   <para>rdfs:label : Enacting jurisdiction (Work)rdfs:label : Normerlassender Rechtsträger (Werk)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : enactingJurisdictionWork</para>
    ///   <para>skos:definition : A jurisdiction enacting a law, regulation, constitution, court rule, etc.skos:definition : Ein Rechtsträger, der Gesetze, Verordnungen, eine Satzung, gerichtliche Anordnungen usw. erlassen kann. </para>
    ///   <a href="http://rdvocab.info/roles/enactingJurisdictionWork">rdarole:enactingJurisdictionWork</a>
    /// </summary>
    let enactingJurisdictionWork = _prefixId.prefix "enactingJurisdictionWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraver</para>
    ///   <para>rdfs:label : Engraverrdfs:label : Graveur </para>
    ///   <a href="http://rdvocab.info/roles/engraver">rdarole:engraver</a>
    /// </summary>
    let engraver = _prefixId.prefix "engraver"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : engraverManifestation</para>
    ///   <para>rdfs:label : Engraver (Manifestation)rdfs:label : Graveur (Manifestation)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die in die Produktion einer Manifestation eingebunden ist, indem sie Buchstaben, Zahlen usw. in eine Oberfläche, wie z.B. eine Holz- oder Metallplatte, die zum Drucken benutzt wird, schneidet.skos:definition : A person, family, or corporate body involved in manufacturing a manifestation by cutting letters, figures, etc., on a surface such as a wooden or metal plate used for printing.</para>
    ///   <a href="http://rdvocab.info/roles/engraverManifestation">rdarole:engraverManifestation</a>
    /// </summary>
    let engraverManifestation = _prefixId.prefix "engraverManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcher</para>
    ///   <para>rdfs:label : Etcherrdfs:label : Radierer </para>
    ///   <a href="http://rdvocab.info/roles/etcher">rdarole:etcher</a>
    /// </summary>
    let etcher = _prefixId.prefix "etcher"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body involved in manufacturing a manifestation by subjecting metal, glass, or some other surface used for printing, to acid or another corrosive substance.skos:definition : Eine Person, Familie oder Körperschaft, die in die Produktion einer Manifestation eingebunden ist, indem sie Metall, Glas oder eine andere Oberfläche, die zum Drucken benutzt wird, mit Säure oder einer anderen ätzenden Substanz behandelt.</para>
    ///   <para>rdfs:label : Radierer (Manifestation)rdfs:label : Etcher (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : etcherManifestation</para>
    ///   <a href="http://rdvocab.info/roles/etcherManifestation">rdarole:etcherManifestation</a>
    /// </summary>
    let etcherManifestation = _prefixId.prefix "etcherManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirector</para>
    ///   <para>rdfs:label : Film directorrdfs:label : Filmregisseur </para>
    ///   <a href="http://rdvocab.info/roles/filmDirector">rdarole:filmDirector</a>
    /// </summary>
    let filmDirector = _prefixId.prefix "filmDirector"
    /// <summary>
    ///   <para>rdfs:label : Filmregisseur (Werk)rdfs:label : Film director (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDirectorWork</para>
    ///   <para>skos:definition : A director responsible for the general management and supervision of a filmed performance.skos:definition : Eine Person, Familie oder Körperschaft, die für das allgemeine Management und die Leitung einer verfilmten Darbietung verantwortlich ist.</para>
    ///   <a href="http://rdvocab.info/roles/filmDirectorWork">rdarole:filmDirectorWork</a>
    /// </summary>
    let filmDirectorWork = _prefixId.prefix "filmDirectorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributor</para>
    ///   <para>rdfs:label : Film distributorrdfs:label : Filmverleiher </para>
    ///   <a href="http://rdvocab.info/roles/filmDistributor">rdarole:filmDistributor</a>
    /// </summary>
    let filmDistributor = _prefixId.prefix "filmDistributor"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für den Vertrieb einer verfilmten Bewegtbildmanifestation an Kinos oder andere Vertriebskanäle verantwortlich ist. skos:definition : A person, family, or corporate body responsible for distributing a moving image manifestation to theatres or other distribution channels.</para>
    ///   <para>rdfs:label : Filmverleiher (Manifestation)rdfs:label : Film distributor (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmDistributorManifestation</para>
    ///   <a href="http://rdvocab.info/roles/filmDistributorManifestation">rdarole:filmDistributorManifestation</a>
    /// </summary>
    let filmDistributorManifestation = _prefixId.prefix "filmDistributorManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducer</para>
    ///   <para>rdfs:label : Film producerrdfs:label : Filmproduzent </para>
    ///   <a href="http://rdvocab.info/roles/filmProducer">rdarole:filmProducer</a>
    /// </summary>
    let filmProducer = _prefixId.prefix "filmProducer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmProducerWork</para>
    ///   <para>rdfs:label : Film producer (Work)rdfs:label : Filmproduzent (Werk)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für einen Film die Verantwortung für die meisten geschäftlichen Aspekte übernimmt. Der Produzent ist hauptsächlich verantwortlich für die Geldbeschaffung, das Produktionsmanagement, die Einstellung der Kompetenzträger, die Organisation des Vertriebs, die Absicherung des kommerziellen Erfolges usw.skos:definition : A producer responsible for most of the business aspects of a film.</para>
    ///   <a href="http://rdvocab.info/roles/filmProducerWork">rdarole:filmProducerWork</a>
    /// </summary>
    let filmProducerWork = _prefixId.prefix "filmProducerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmmakerWork</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating an independent or personal film. A filmmaker is individually responsible for the conception, and execution of all aspects of the film.skos:definition : Eine Person, Familie oder Körperschaft, die für die Erstellung eines unabhängigen oder privaten Films verantwortlich ist. Ein Filmemacher ist individuell verantwortlich für das Konzept und die Ausführung aller Aspekte des Films.</para>
    ///   <para>rdfs:label : Filmmaker (Work)rdfs:label : Filmemacher (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/filmmakerWork">rdarole:filmmakerWork</a>
    /// </summary>
    let filmmakerWork = _prefixId.prefix "filmmakerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwner</para>
    ///   <para>rdfs:label : Former ownerrdfs:label : Früherer Besitzer </para>
    ///   <a href="http://rdvocab.info/roles/formerOwner">rdarole:formerOwner</a>
    /// </summary>
    let formerOwner = _prefixId.prefix "formerOwner"
    /// <summary>
    ///   <para>rdfs:label : Former owner (Item)rdfs:label : Früherer Besitzer (Exemplar)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwnerItem</para>
    ///   <para>skos:definition : A person, family, or corporate body formerly having legal possession of an item (i.e., a specific copy or instance of a resource).skos:definition : Eine Person, Familie oder Körperschaft, die früher rechtmäßiger Besitzer eines Exemplars war (d.h. einer bestimmten Kopie oder eines Exemplars einer Ressource) </para>
    ///   <a href="http://rdvocab.info/roles/formerOwnerItem">rdarole:formerOwnerItem</a>
    /// </summary>
    let formerOwnerItem = _prefixId.prefix "formerOwnerItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honouree</para>
    ///   <para>rdfs:label : Honoureerdfs:label : Gefeierte Person</para>
    ///   <a href="http://rdvocab.info/roles/honouree">rdarole:honouree</a>
    /// </summary>
    let honouree = _prefixId.prefix "honouree"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body honoured by an item, e.g., a person to whom a copy is presented.skos:definition : Eine Person, Familie oder Körperschaft, die durch ein Exemplar geehrt wird, z.B. die Person, der ein Exemplar gewidmet wird. </para>
    ///   <para>rdfs:label : Honouree of itemrdfs:label : Mit einem Exemplar geehrte Person.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeOfItem</para>
    ///   <a href="http://rdvocab.info/roles/honoureeOfItem">rdarole:honoureeOfItem</a>
    /// </summary>
    let honoureeOfItem = _prefixId.prefix "honoureeOfItem"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die durch ein Werk geehrt wird, z.B. die mit einer Festschrift gefeierte Person. skos:definition : A person, family, or corporate body honoured by a work, e.g., the honouree of a festschrift.</para>
    ///   <para>rdfs:label : Honouree (Work)rdfs:label : Gefeierte Person (Werk)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeWork</para>
    ///   <a href="http://rdvocab.info/roles/honoureeWork">rdarole:honoureeWork</a>
    /// </summary>
    let honoureeWork = _prefixId.prefix "honoureeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : host</para>
    ///   <para>rdfs:label : Hostrdfs:label : Gastgeber </para>
    ///   <a href="http://rdvocab.info/roles/host">rdarole:host</a>
    /// </summary>
    let host = _prefixId.prefix "host"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by leading a program (often broadcast) that includes other guests, performers, etc. (e.g., talk show host).skos:definition : Ein Darsteller, der an einer Expression eines Werkes mitwirkt, indem er ein Programm leitet, häufig im Rundfunk, an dem auch andere Gäste, Darsteller usw. teilnehmen (z.B. der Gastgeber einer Talkshow).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostExpression</para>
    ///   <para>rdfs:label : Host (Expression)rdfs:label : Gastgeber (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/hostExpression">rdarole:hostExpression</a>
    /// </summary>
    let hostExpression = _prefixId.prefix "hostExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostInstitution</para>
    ///   <para>rdfs:label : Host institutionrdfs:label : Veranstalter </para>
    ///   <a href="http://rdvocab.info/roles/hostInstitution">rdarole:hostInstitution</a>
    /// </summary>
    let hostInstitution = _prefixId.prefix "hostInstitution"
    /// <summary>
    ///   <para>skos:definition : A corporate body hosting an event, exhibit, conference, etc., which gave rise to the work, but having little or no responsibility for the content of the work.skos:definition : Eine Körperschaft, die eine Veranstaltung, eine Ausstellung, einen Kongress usw. ausrichtet, die/der ein Werk zur Folge hat, die aber für den Inhalt des Werkes wenig oder gar keine Verantwortung für trägt.</para>
    ///   <para>rdfs:label : Veranstalter (Werk)rdfs:label : Host institution (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hostInstitutionWork</para>
    ///   <a href="http://rdvocab.info/roles/hostInstitutionWork">rdarole:hostInstitutionWork</a>
    /// </summary>
    let hostInstitutionWork = _prefixId.prefix "hostInstitutionWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminator</para>
    ///   <para>rdfs:label : Illuminatorrdfs:label : Illuminator </para>
    ///   <a href="http://rdvocab.info/roles/illuminator">rdarole:illuminator</a>
    /// </summary>
    let illuminator = _prefixId.prefix "illuminator"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminatorItem</para>
    ///   <para>skos:definition : A person providing decoration to a specific item using precious metals or color, often with elaborate designs and motifs.skos:definition : Eine Person, die ein bestimmtes Exemplar durch Edelmetalle oder Farben (aus-)gestaltet, häufig mit kunstvollen Mustern und Motiven.</para>
    ///   <para>rdfs:label : Illuminator (Item)rdfs:label : Illuminator (Exemplar)</para>
    ///   <a href="http://rdvocab.info/roles/illuminatorItem">rdarole:illuminatorItem</a>
    /// </summary>
    let illuminatorItem = _prefixId.prefix "illuminatorItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrator</para>
    ///   <para>rdfs:label : Illustratorrdfs:label : Illustrator </para>
    ///   <a href="http://rdvocab.info/roles/illustrator">rdarole:illustrator</a>
    /// </summary>
    let illustrator = _prefixId.prefix "illustrator"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie den primären Inhalt mit Zeichnungen, Diagrammen, Fotografien usw. ausschmückt / ergänzt. skos:definition : A person, family, or corporate body contributing to an expression of a work by supplementing the primary content with drawings, diagrams, photographs, etc. </para>
    ///   <para>rdfs:comment : If the work is primarily the artistic content created by this entity, see artist and photographer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustratorExpression</para>
    ///   <para>rdfs:label : Illustrator (Expression)rdfs:label : Illustrator (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/illustratorExpression">rdarole:illustratorExpression</a>
    /// </summary>
    let illustratorExpression = _prefixId.prefix "illustratorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriber</para>
    ///   <para>rdfs:label : Inscriberrdfs:label : Person, deren handschriftliche Anmerkungen in einem Exemplar erscheinen</para>
    ///   <a href="http://rdvocab.info/roles/inscriber">rdarole:inscriber</a>
    /// </summary>
    let inscriber = _prefixId.prefix "inscriber"
    /// <summary>
    ///   <para>skos:definition : A person whose manuscript notes appear on an item.skos:definition : Eine Person, deren handschriftliche Anmerkungen in einem Exemplar erkennbar sind. </para>
    ///   <para>rdfs:label : Inscriber (Item)rdfs:label : Person, deren handschriftliche Anmerkungen in einem Exemplar erscheinen (Exemplar)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriberItem</para>
    ///   <a href="http://rdvocab.info/roles/inscriberItem">rdarole:inscriberItem</a>
    /// </summary>
    let inscriberItem = _prefixId.prefix "inscriberItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalist</para>
    ///   <para>rdfs:label : Instrumentalistrdfs:label : Instrumentalmusiker </para>
    ///   <a href="http://rdvocab.info/roles/instrumentalist">rdarole:instrumentalist</a>
    /// </summary>
    let instrumentalist = _prefixId.prefix "instrumentalist"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : instrumentalistExpression</para>
    ///   <para>skos:definition : A performer contributing to an expression of a work by playing a musical instrument.skos:definition : Ein Darsteller, der durch das Spielen eines Musikinstruments an einer Expression eines Werkes mitwirkt. </para>
    ///   <para>rdfs:label : Instrumentalist (Expression)rdfs:label : Instrumentalmusiker (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/instrumentalistExpression">rdarole:instrumentalistExpression</a>
    /// </summary>
    let instrumentalistExpression = _prefixId.prefix "instrumentalistExpression"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie einem Interviewer antwortet, normalerweise einem Reporter, einem Meinungsforscher oder einem anderen, der Informationen zusammenträgt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewee</para>
    ///   <para>rdfs:label : Intervieweerdfs:label : Interviewter </para>
    ///   <a href="http://rdvocab.info/roles/interviewee">rdarole:interviewee</a>
    /// </summary>
    let interviewee = _prefixId.prefix "interviewee"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie einem Interviewer antwortet, normalerweise einem Reporter, einem Meinungsforscher oder einem anderen, der Informationen zusammenträgt.skos:definition : A person, family, or corporate body contributing to an expression of a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <para>rdfs:label : Interviewee (Expression)rdfs:label : Interviewter (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeExpression</para>
    ///   <a href="http://rdvocab.info/roles/intervieweeExpression">rdarole:intervieweeExpression</a>
    /// </summary>
    let intervieweeExpression = _prefixId.prefix "intervieweeExpression"
    /// <summary>
    ///   <para>rdfs:label : Interviewer (Werk)rdfs:label : Interviewee (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie einem Interviewer antwortet, normalerweise einem Reporter, einem Meinungsforscher oder einem anderen, der Informationen zusammenträgt.skos:definition : A person, family, or corporate body responsible for creating a work by responding to an interviewer, usually a reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intervieweeWork</para>
    ///   <a href="http://rdvocab.info/roles/intervieweeWork">rdarole:intervieweeWork</a>
    /// </summary>
    let intervieweeWork = _prefixId.prefix "intervieweeWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie als Interviewer, Reporter, Meinungsforscher oder anderer Informationssammler tätig ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewer</para>
    ///   <para>rdfs:label : Interviewerrdfs:label : Interviewer rdfs:label : Interviewer</para>
    ///   <a href="http://rdvocab.info/roles/interviewer">rdarole:interviewer</a>
    /// </summary>
    let interviewer = _prefixId.prefix "interviewer"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie als Interviewer, Reporter, Meinungsforscher oder anderer Informationssammler tätig ist. skos:definition : A person, family, or corporate body contributing to an expression of a work by acting as an interviewer, reporter, pollster, or some other information gathering agent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerExpression</para>
    ///   <para>rdfs:label : Interviewer (Expression)rdfs:label : Interviewer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/interviewerExpression">rdarole:interviewerExpression</a>
    /// </summary>
    let interviewerExpression = _prefixId.prefix "interviewerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : interviewerWork</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating a work by acting as an interviewer, reporter, pollster, or some other information gathering agent.skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines Werkes verantwortlich ist, indem sie einem Interviewer antwortet, normalerweise einem Reporter, einem Meinungsforscher oder einem anderen, der Informationen zusammenträgt.</para>
    ///   <para>rdfs:label : Interviewter (Werk)rdfs:label : Interviewer (Work)</para>
    ///   <a href="http://rdvocab.info/roles/interviewerWork">rdarole:interviewerWork</a>
    /// </summary>
    let interviewerWork = _prefixId.prefix "interviewerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventor</para>
    ///   <para>rdfs:label : Inventorrdfs:label : Erfinder </para>
    ///   <a href="http://rdvocab.info/roles/inventor">rdarole:inventor</a>
    /// </summary>
    let inventor = _prefixId.prefix "inventor"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erschaffung eines neuen Gerätes oder Prozesses verantwortlich ist. skos:definition : A person, family, or corporate body responsible for creating a new device or process.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inventorWork</para>
    ///   <para>rdfs:label : Inventor (Work)rdfs:label : Erfinder (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/inventorWork">rdarole:inventorWork</a>
    /// </summary>
    let inventorWork = _prefixId.prefix "inventorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBody</para>
    ///   <para>rdfs:label : Issuing bodyrdfs:label : Veröffentlichendes Organ </para>
    ///   <a href="http://rdvocab.info/roles/issuingBody">rdarole:issuingBody</a>
    /// </summary>
    let issuingBody = _prefixId.prefix "issuingBody"
    /// <summary>
    ///   <para>skos:definition : A person, family or corporate body issuing the work, such as an official organ of the body. skos:definition : Eine Person, Familie oder Körperschaft, die ein Werk herausgibt, wie z.B. ein offizielles Organ der Körperschaft. </para>
    ///   <para>rdfs:label : Veröffentlichendes Organ (Werk)rdfs:label : Issuing body (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuingBodyWork</para>
    ///   <a href="http://rdvocab.info/roles/issuingBodyWork">rdarole:issuingBodyWork</a>
    /// </summary>
    let issuingBodyWork = _prefixId.prefix "issuingBodyWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judge</para>
    ///   <para>rdfs:label : Judgerdfs:label : Richter </para>
    ///   <a href="http://rdvocab.info/roles/judge">rdarole:judge</a>
    /// </summary>
    let judge = _prefixId.prefix "judge"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : judgeWork</para>
    ///   <para>skos:definition : A person who hears and decides on legal matters in court.skos:definition : Eine Person, die bei Gericht gesetzliche Angelegenheiten anhört und darüber entscheidet. </para>
    ///   <para>rdfs:label : Richter (Werk)rdfs:label : Judge (Work)</para>
    ///   <a href="http://rdvocab.info/roles/judgeWork">rdarole:judgeWork</a>
    /// </summary>
    let judgeWork = _prefixId.prefix "judgeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGoverned</para>
    ///   <para>rdfs:label : Jurisdiction governedrdfs:label : Normunterworfener Rechtsträger </para>
    ///   <a href="http://rdvocab.info/roles/jurisdictionGoverned">rdarole:jurisdictionGoverned</a>
    /// </summary>
    let jurisdictionGoverned = _prefixId.prefix "jurisdictionGoverned"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : jurisdictionGovernedWork</para>
    ///   <para>skos:definition : Ein Rechtsträger, der Gesetzen, Verordnungen o. ä. unterworfen ist, die von einem anderen Rechtsträger erlassen wurden. skos:definition : A jurisdiction governed by a law, regulation, etc., that was enacted by another jurisdiction.</para>
    ///   <para>rdfs:label : Jurisdiction governed (Work)rdfs:label : Normunterworfener Rechtsträger (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/jurisdictionGovernedWork">rdarole:jurisdictionGovernedWork</a>
    /// </summary>
    let jurisdictionGovernedWork = _prefixId.prefix "jurisdictionGovernedWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitect</para>
    ///   <para>rdfs:label : Landscape architectrdfs:label : Landschaftsarchitekt </para>
    ///   <a href="http://rdvocab.info/roles/landscapeArchitect">rdarole:landscapeArchitect</a>
    /// </summary>
    let landscapeArchitect = _prefixId.prefix "landscapeArchitect"
    /// <summary>
    ///   <para>skos:definition : An architect responsible for creating landscape works.skos:definition : Ein Architekt, der für die Erschaffung landschaftlicher Werke verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : landscapeArchitectWork</para>
    ///   <para>rdfs:label : Landscape architect (Work)rdfs:label : Landschaftsarchitekt (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/landscapeArchitectWork">rdarole:landscapeArchitectWork</a>
    /// </summary>
    let landscapeArchitectWork = _prefixId.prefix "landscapeArchitectWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettist</para>
    ///   <para>rdfs:label : Librettistrdfs:label : Librettist </para>
    ///   <a href="http://rdvocab.info/roles/librettist">rdarole:librettist</a>
    /// </summary>
    let librettist = _prefixId.prefix "librettist"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettistWork</para>
    ///   <para>skos:definition : Ein Verfasser eines Librettos einer Oper oder anderer Bühnenwerke oder eines Oratoriums. skos:definition : An author of a libretto of an opera or other stage work, or an oratorio.</para>
    ///   <para>rdfs:label : Librettist (Work)rdfs:label : Librettist (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/librettistWork">rdarole:librettistWork</a>
    /// </summary>
    let librettistWork = _prefixId.prefix "librettistWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographer</para>
    ///   <para>rdfs:label : Lithographerrdfs:label : Lithograf </para>
    ///   <a href="http://rdvocab.info/roles/lithographer">rdarole:lithographer</a>
    /// </summary>
    let lithographer = _prefixId.prefix "lithographer"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body involved in producing a manifestation by preparing a stone or plate for lithographic printing, including a graphic artist creating a design directly on the surface from which printing will be done.skos:definition : Eine Person, Familie oder Körperschaft, die in die Erstellung einer Manifestation eingebunden ist, indem sie einen Stein oder eine Platte für lithografischen Druck vorbereitet, einschließlich eines Grafikers, der ein Muster direkt auf der Oberfläche erstellt, von der aus gedruckt werden wird.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lithographerManifestation</para>
    ///   <para>rdfs:label : Lithograf (Manifestation)rdfs:label : Lithographer (Manifestation)</para>
    ///   <a href="http://rdvocab.info/roles/lithographerManifestation">rdarole:lithographerManifestation</a>
    /// </summary>
    let lithographerManifestation = _prefixId.prefix "lithographerManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricist</para>
    ///   <para>rdfs:label : Lyricistrdfs:label : Textdichter </para>
    ///   <a href="http://rdvocab.info/roles/lyricist">rdarole:lyricist</a>
    /// </summary>
    let lyricist = _prefixId.prefix "lyricist"
    /// <summary>
    ///   <para>skos:definition : An author of the words of a non-dramatic musical work, except for oratorios.skos:definition : Ein Verfasser des Textes eines nicht-dramatischen musikalischen Werkes, ausgenommen für Oratorien. </para>
    ///   <para>rdfs:label : Textdichter (Werk)rdfs:label : Lyricist (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : lyricistWork</para>
    ///   <a href="http://rdvocab.info/roles/lyricistWork">rdarole:lyricistWork</a>
    /// </summary>
    let lyricistWork = _prefixId.prefix "lyricistWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für den Druck, die Vervielfältigung, Auswahl etc. einer Ressource in einer veröffentlichten Form verantwortlich ist. </para>
    ///   <para>rdfs:label : Hersteller rdfs:label : Manufacturer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturer</para>
    ///   <a href="http://rdvocab.info/roles/manufacturer">rdarole:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturerManifestation</para>
    ///   <para>rdfs:label : Hersteller (Manifestation)rdfs:label : Manufacturer (Manifestation)</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.skos:definition : Eine Person, Familie oder Körperschaft, die für den Druck, die Vervielfältigung, Auswahl etc. einer Ressource in einer veröffentlichten Form verantwortlich ist. </para>
    ///   <a href="http://rdvocab.info/roles/manufacturerManifestation">rdarole:manufacturerManifestation</a>
    /// </summary>
    let manufacturerManifestation = _prefixId.prefix "manufacturerManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderator</para>
    ///   <para>rdfs:label : Moderatorrdfs:label : Moderator </para>
    ///   <a href="http://rdvocab.info/roles/moderator">rdarole:moderator</a>
    /// </summary>
    let moderator = _prefixId.prefix "moderator"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by leading a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.skos:definition : Ein Darsteller, der an einer Expression eines Werkes mitwirkt, indem er ein Programm leitet (oft eine Rundfunk-Sendung), in dem Themen diskutiert werden, normalerweise mit Teilnahme von Experten auf den diskutierten Gebieten.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : moderatorExpression</para>
    ///   <para>rdfs:label : Moderator (Expression)rdfs:label : Moderator (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/moderatorExpression">rdarole:moderatorExpression</a>
    /// </summary>
    let moderatorExpression = _prefixId.prefix "moderatorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirector</para>
    ///   <para>rdfs:label : Musical directorrdfs:label : Musikalischer Leiter </para>
    ///   <a href="http://rdvocab.info/roles/musicalDirector">rdarole:musicalDirector</a>
    /// </summary>
    let musicalDirector = _prefixId.prefix "musicalDirector"
    /// <summary>
    ///   <para>rdfs:label : Musical director (Expression)rdfs:label : Musikalischer Leiter (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalDirectorExpression</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Koordinierung der Arbeit des Komponisten, des Tonbearbeiters und Tonmeisters für eine Bewegtbildproduktion oder eine musikalische oder dramatische Darbietung oder Aufführung verantwortlich ist.skos:definition : A person, family, or corporate body contributing to an expression of a work by coordinating the activities of the composer, the sound editor, and sound mixers for a moving image production or for a musical or dramatic presentation or entertainment.</para>
    ///   <a href="http://rdvocab.info/roles/musicalDirectorExpression">rdarole:musicalDirectorExpression</a>
    /// </summary>
    let musicalDirectorExpression = _prefixId.prefix "musicalDirectorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narrator</para>
    ///   <para>rdfs:label : Narratorrdfs:label : Erzähler </para>
    ///   <a href="http://rdvocab.info/roles/narrator">rdarole:narrator</a>
    /// </summary>
    let narrator = _prefixId.prefix "narrator"
    /// <summary>
    ///   <para>rdfs:label : Narrator (Expression)rdfs:label : Erzähler (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : narratorExpression</para>
    ///   <para>skos:definition : Ein Darsteller, der eine Expression eines Werkes liest oder spricht, um einen Akt, ein Geschehnis, einen Ereignisablauf usw. darzustellen. skos:definition : A performer contributing to an expression of a work by reading or speaking in order to give an account of an act, occurrence, course of events, etc.</para>
    ///   <a href="http://rdvocab.info/roles/narratorExpression">rdarole:narratorExpression</a>
    /// </summary>
    let narratorExpression = _prefixId.prefix "narratorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenter</para>
    ///   <para>rdfs:label : On-screen presenterrdfs:label : On-screen Presenter </para>
    ///   <a href="http://rdvocab.info/roles/onScreenPresenter">rdarole:onScreenPresenter</a>
    /// </summary>
    let onScreenPresenter = _prefixId.prefix "onScreenPresenter"
    /// <summary>
    ///   <para>rdfs:comment : Use when a more specific term (e.g., Narrator or Host) is either not applicable or not desired.</para>
    ///   <para>skos:definition : Ein Darsteller, der an einer Expression eines Werkes mitwirkt, indem er über den Bildschirm Kontext- und Hintergrundinformationen zu nicht-fiktiven Bewegtbildmaterialien oder zu Einleitungen zu fiktivenBewegtbildmaterialien beisteuert. Die Funktionsbezeichnung wird verwendet, wenn ein spezifischerer Begriff (z. B. Erzähler oder Gastgeber) nicht anwendbar ist.skos:definition : A performer contributing to an expression of a work by appearing on screen in nonfiction moving image materials or introductions to fiction moving image materials to provide contextual or background information. </para>
    ///   <para>rdfs:label : On-screen presenter (Expression)rdfs:label : On-screen Presenter (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onScreenPresenterExpression</para>
    ///   <a href="http://rdvocab.info/roles/onScreenPresenterExpression">rdarole:onScreenPresenterExpression</a>
    /// </summary>
    let onScreenPresenterExpression = _prefixId.prefix "onScreenPresenterExpression"
    /// <summary>
    ///   <para>rdfs:label : Besitzer rdfs:label : Owner</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die im rechtmäßigen Besitz eines Exemplars ist (z.B. einer bestimmten Kopie oder einer bestimmten Instanz einer Ressource). </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : owner</para>
    ///   <a href="http://rdvocab.info/roles/owner">rdarole:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die im rechtmäßigen Besitz eines Exemplars ist (z.B. einer bestimmten Kopie oder einer bestimmten Instanz einer Ressource). skos:definition : A person, family, or corporate body having legal possession of an item (i.e., a specific copy or instance of a resource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ownerItem</para>
    ///   <para>rdfs:label : Besitzer (Exemplar)rdfs:label : Owner (Item)</para>
    ///   <a href="http://rdvocab.info/roles/ownerItem">rdarole:ownerItem</a>
    /// </summary>
    let ownerItem = _prefixId.prefix "ownerItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelist</para>
    ///   <para>rdfs:label : Panelistrdfs:label : Diskussionsteilnehmer </para>
    ///   <a href="http://rdvocab.info/roles/panelist">rdarole:panelist</a>
    /// </summary>
    let panelist = _prefixId.prefix "panelist"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by participating in a program (often broadcast) where topics are discussed, usually with participation of experts in fields related to the discussion.skos:definition :
    /// Ein Darsteller, der an einem Programm (oft einer Rundfunk-Sendung) teilnimmt, in dem Themen diskutiert werden, normalerweise mit Experten auf den diskutierten Gebieten. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : panelistExpression</para>
    ///   <para>rdfs:label : Panelist (Expression)rdfs:label : Diskussionsteilnehmer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/panelistExpression">rdarole:panelistExpression</a>
    /// </summary>
    let panelistExpression = _prefixId.prefix "panelistExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performer</para>
    ///   <para>rdfs:label : Darsteller rdfs:label : Performer</para>
    ///   <a href="http://rdvocab.info/roles/performer">rdarole:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by performing music, acting, dancing, speaking, etc., often in a musical or dramatic presentation, etc.skos:definition : Eine Person, Familie oder Körperschaft, die für die Expression eines Werkes Musik aufführen, auftreten, tanzen, sprechen usw., oft in einer musikalischen oder dramatischen Darbietung usw.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerExpression</para>
    ///   <para>rdfs:label : Darsteller (Expression)rdfs:label : Performer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/performerExpression">rdarole:performerExpression</a>
    /// </summary>
    let performerExpression = _prefixId.prefix "performerExpression"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erstellung eines fotografischen Werks verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographer</para>
    ///   <para>rdfs:label : Photographerrdfs:label : Fotograf </para>
    ///   <a href="http://rdvocab.info/roles/photographer">rdarole:photographer</a>
    /// </summary>
    let photographer = _prefixId.prefix "photographer"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for creating a photographic work.skos:definition : Eine Person, Familie oder Körperschaft, die für die Erstellung eines fotografischen Werks verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : photographerWork</para>
    ///   <para>rdfs:label : Photographer (Work)rdfs:label : Fotograf (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/photographerWork">rdarole:photographerWork</a>
    /// </summary>
    let photographerWork = _prefixId.prefix "photographerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiff</para>
    ///   <para>rdfs:label : Plaintiffrdfs:label : Zivilkläger </para>
    ///   <a href="http://rdvocab.info/roles/plaintiff">rdarole:plaintiff</a>
    /// </summary>
    let plaintiff = _prefixId.prefix "plaintiff"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plaintiffWork</para>
    ///   <para>skos:definition : A person or corporate body who brings a suit in a civil proceeding.skos:definition : Eine Person oder Körperschaft, die eine Klage in ein Zivilverfahren einbringt. </para>
    ///   <para>rdfs:label : Plaintiff (Work)rdfs:label : Zivilkläger </para>
    ///   <a href="http://rdvocab.info/roles/plaintiffWork">rdarole:plaintiffWork</a>
    /// </summary>
    let plaintiffWork = _prefixId.prefix "plaintiffWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemaker</para>
    ///   <para>rdfs:label : Platemakerrdfs:label : Druckformhersteller </para>
    ///   <a href="http://rdvocab.info/roles/platemaker">rdarole:platemaker</a>
    /// </summary>
    let platemaker = _prefixId.prefix "platemaker"
    /// <summary>
    ///   <para>rdfs:label : Platemaker (Manifestation)rdfs:label : Druckformhersteller (Manifestation)</para>
    ///   <para>skos:definition :
    /// Eine Person, Familie oder Körperschaft, die an der Produktion einer Manifestation beteiligt ist, indem sie Druckformen für die Produktion von gedruckten Bildern und/oder Text anfertigt. skos:definition : A person, family, or corporate body involved in producing a manifestation by preparing plates used in the production of printed images and/or text.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : platemakerManifestation</para>
    ///   <a href="http://rdvocab.info/roles/platemakerManifestation">rdarole:platemakerManifestation</a>
    /// </summary>
    let platemakerManifestation = _prefixId.prefix "platemakerManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praeses</para>
    ///   <para>rdfs:label : Praesesrdfs:label : Disputationsleiter </para>
    ///   <a href="http://rdvocab.info/roles/praeses">rdarole:praeses</a>
    /// </summary>
    let praeses = _prefixId.prefix "praeses"
    /// <summary>
    ///   <para>rdfs:label : Disputationsleiter (Werk)rdfs:label : Praeses (Work)</para>
    ///   <para>skos:definition : Angehöriger des Lehrpersonals, der eine akademische Disputation moderiert, normalerweise indem er eine These aufstellt und an der folgenden Disputation teilnimmt, aber nur indirekte Verbindung mit dem Inhalt der These hat.skos:definition : A person who is the faculty moderator of an academic disputation, normally proposing a thesis and participating in the ensuing disputation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : praesesWork</para>
    ///   <a href="http://rdvocab.info/roles/praesesWork">rdarole:praesesWork</a>
    /// </summary>
    let praesesWork = _prefixId.prefix "praesesWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenter</para>
    ///   <para>rdfs:label : Presenterrdfs:label : Presenter</para>
    ///   <a href="http://rdvocab.info/roles/presenter">rdarole:presenter</a>
    /// </summary>
    let presenter = _prefixId.prefix "presenter"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die in einem "X präsentiert"-Vorspann für Bewegtbildmaterialien erwähnt wird und die wahrscheinlich in gewisser Weise mit Produktion, Finanzierung oder Vertrieb in Zusammenhang steht. In den frühen Jahren der Filmproduktion wurde dies häufig  als "vanity credit" verwendet.skos:definition : A person, family, or corporate body mentioned in an “X presents” credit for moving image materials and who is probably associated with production, finance, or distribution in some way. In the early years of film production, this was often used as a vanity credit.</para>
    ///   <para>rdfs:label : Presenter (Expression)rdfs:label : Presenter (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presenterExpression</para>
    ///   <a href="http://rdvocab.info/roles/presenterExpression">rdarole:presenterExpression</a>
    /// </summary>
    let presenterExpression = _prefixId.prefix "presenterExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printer</para>
    ///   <para>rdfs:label : Printerrdfs:label : Drucker </para>
    ///   <a href="http://rdvocab.info/roles/printer">rdarole:printer</a>
    /// </summary>
    let printer = _prefixId.prefix "printer"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body involved in producing a manifestation of printed text, notated music, etc., from type or plates, such as a book, newspaper, magazine, broadside, score, etc.skos:definition : Eine Person, Familie oder Körperschaft, die an der Produktion einer Manifestation von gedrucktem Text, notierter Musik usw. durch Drucktypen oder Druckformen, wie z.B. ein Buch, eine Zeitung, ein Magazin, ein Einblattdruck, eine Partitur o.ä. beteiligt ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printerManifestation</para>
    ///   <para>rdfs:label : Drucker (Manifestation)rdfs:label : Printer (Manifestation)</para>
    ///   <a href="http://rdvocab.info/roles/printerManifestation">rdarole:printerManifestation</a>
    /// </summary>
    let printerManifestation = _prefixId.prefix "printerManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmaker</para>
    ///   <para>rdfs:label : Printmakerrdfs:label : Druckgrafiker </para>
    ///   <a href="http://rdvocab.info/roles/printmaker">rdarole:printmaker</a>
    /// </summary>
    let printmaker = _prefixId.prefix "printmaker"
    /// <summary>
    ///   <para>rdfs:label : Printmaker (Manifestation)rdfs:label : Druckgrafiker (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : printmakerManifestation</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an der Produktion einer Manifestation durch die Erstellung einer Hochdruck-, Tiefdruck- oder Flachdruckoberfläche beteiligt ist.skos:definition : A person, family, or corporate body involved in manufacturing a manifestation by making a relief, intaglio, or planographic printing surface.</para>
    ///   <a href="http://rdvocab.info/roles/printmakerManifestation">rdarole:printmakerManifestation</a>
    /// </summary>
    let printmakerManifestation = _prefixId.prefix "printmakerManifestation"
    /// <summary>
    ///   <para>rdfs:label : Produzent rdfs:label : Producer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producer</para>
    ///   <a href="http://rdvocab.info/roles/producer">rdarole:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>rdfs:label : Produzent (Werk)rdfs:label : Producer (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producerWork</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for most of the business aspects of a production for screen, audio recording, television, webcast, etc. The producer is generally responsible for fund raising, managing the production, hiring key personnel, arranging for distributors, etc.skos:definition : Eine Person, Familie oder Körperschaft,  die Verantwortung für die meisten geschäftlichen Aspekte einer Darbietung für die Bühne, die Leinwand, eine Tonaufnahme, das Fernsehen, eine Internetübertragung usw. übernimmt. Der Produzent ist allgemein verantwortlich für die Geldbeschaffung, das Produktionsmanagement, die Einstellung der Kompetenzträger, die Organisation des Vertriebs, o.ä.</para>
    ///   <a href="http://rdvocab.info/roles/producerWork">rdarole:producerWork</a>
    /// </summary>
    let producerWork = _prefixId.prefix "producerWork"
    /// <summary>
    ///   <para>skos:definition : Eine Körperschaft, die für das finanzielle, technische und organisatorische Management einer Produktion für Bühne, Leinwand, Tonaufnahme, Fernsehen, Internetübertragung o.ä. verantwortlich ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompany</para>
    ///   <para>rdfs:label : Production companyrdfs:label : Produktionsunternehmen</para>
    ///   <a href="http://rdvocab.info/roles/productionCompany">rdarole:productionCompany</a>
    /// </summary>
    let productionCompany = _prefixId.prefix "productionCompany"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionCompanyWork</para>
    ///   <para>rdfs:label : Production company (Work)rdfs:label : Produktionsunternehmen (Werk)</para>
    ///   <para>skos:definition : Eine Körperschaft, die für das finanzielle, technische und organisatorische Management einer Produktion für Bühne, Leinwand, Tonaufnahme, Fernsehen, Internetübertragung o.ä. verantwortlich ist.skos:definition : A corporate body that is responsible for financial, technical, and organizational management of a production for stage, screen, audio recording, television, webcast, etc.</para>
    ///   <a href="http://rdvocab.info/roles/productionCompanyWork">rdarole:productionCompanyWork</a>
    /// </summary>
    let productionCompanyWork = _prefixId.prefix "productionCompanyWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesigner</para>
    ///   <para>rdfs:label : Production designerrdfs:label : Production Designer </para>
    ///   <a href="http://rdvocab.info/roles/productionDesigner">rdarole:productionDesigner</a>
    /// </summary>
    let productionDesigner = _prefixId.prefix "productionDesigner"
    /// <summary>
    ///   <para>rdfs:label : Production designer (Expression)rdfs:label : Production Designer (Expression)</para>
    ///   <para>skos:definition : A person, family, or corporate body responsible for designing the overall visual appearance of a moving image production.skos:definition : Eine Person, Familie oder Körperschaft, die für die Gestaltung des gesamten visuellen Erscheinungsbildes einer Bewegtbildproduktion verantwortlich ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionDesignerExpression</para>
    ///   <a href="http://rdvocab.info/roles/productionDesignerExpression">rdarole:productionDesignerExpression</a>
    /// </summary>
    let productionDesignerExpression = _prefixId.prefix "productionDesignerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmer</para>
    ///   <para>rdfs:label : Programmerrdfs:label : Programmierer </para>
    ///   <a href="http://rdvocab.info/roles/programmer">rdarole:programmer</a>
    /// </summary>
    let programmer = _prefixId.prefix "programmer"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für die Erstellung eines Computerprogramms verantwortlich ist. skos:definition : A person, family, or corporate body responsible for creating a computer program.</para>
    ///   <para>rdfs:label : Programmer (Work)rdfs:label : Programmierer (Werk)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : programmerWork</para>
    ///   <a href="http://rdvocab.info/roles/programmerWork">rdarole:programmerWork</a>
    /// </summary>
    let programmerWork = _prefixId.prefix "programmerWork"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das Veröffentlichen, die Freigabe oder die Herausgabe einer Ressource verantwortlich ist. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisher</para>
    ///   <para>rdfs:label : Publisher rdfs:label : Verlag</para>
    ///   <a href="http://rdvocab.info/roles/publisher">rdarole:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:label : Publisher (Manifestation)rdfs:label : Verlag (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publisherManifestation</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das Veröffentlichen, die Freigabe oder die Herausgabe einer Ressource verantwortlich ist. </para>
    ///   <a href="http://rdvocab.info/roles/publisherManifestation">rdarole:publisherManifestation</a>
    /// </summary>
    let publisherManifestation = _prefixId.prefix "publisherManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteer</para>
    ///   <para>rdfs:label : Puppeteerrdfs:label : Puppenspieler </para>
    ///   <a href="http://rdvocab.info/roles/puppeteer">rdarole:puppeteer</a>
    /// </summary>
    let puppeteer = _prefixId.prefix "puppeteer"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by manipulating, controlling, or directing puppets or marionettes in a moving image production or a musical or dramatic presentation or entertainment.skos:definition : Ein Darsteller, der an einer Expression eines Werkes mitwirkt, indem er Puppen oder Marionetten in einer Bewegtbildproduktion oder einer musikalischen oder dramatischen Darbietung oder Aufführung bewegt, kontrolliert oder lenkt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : puppeteerExpression</para>
    ///   <para>rdfs:label : Puppeteer (Expression)rdfs:label : Puppenspieler (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/puppeteerExpression">rdarole:puppeteerExpression</a>
    /// </summary>
    let puppeteerExpression = _prefixId.prefix "puppeteerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirector</para>
    ///   <para>rdfs:label : Radio directorrdfs:label : Hörfunkintendant </para>
    ///   <a href="http://rdvocab.info/roles/radioDirector">rdarole:radioDirector</a>
    /// </summary>
    let radioDirector = _prefixId.prefix "radioDirector"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioDirectorWork</para>
    ///   <para>rdfs:label : Hörfunkintendant (Werk)rdfs:label : Radio director (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die für das allgemeine Management und die Leitung eines Radioprogramms verantwortlich ist.skos:definition : A director responsible for the general management and supervision of a radio program.</para>
    ///   <a href="http://rdvocab.info/roles/radioDirectorWork">rdarole:radioDirectorWork</a>
    /// </summary>
    let radioDirectorWork = _prefixId.prefix "radioDirectorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducer</para>
    ///   <para>rdfs:label : Radio producerrdfs:label : Hörfunkproduzent </para>
    ///   <a href="http://rdvocab.info/roles/radioProducer">rdarole:radioProducer</a>
    /// </summary>
    let radioProducer = _prefixId.prefix "radioProducer"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioProducerWork</para>
    ///   <para>rdfs:label : Hörfunkproduzent (Werk)rdfs:label : Radio producer (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die die Verantwortung für die meisten geschäftlichen Aspekte eines Radioprogramms übernimmt.
    /// Der Radioproduzent ist hauptsächlich verantwortlich für die Geldbeschaffung, das Produktionsmanagement, die Einstellung der Kompetenzträger, die Organisation des Vertriebs, die Absicherung des kommerziellen Erfolges usw.skos:definition : A producer responsible for most of the business aspects of a radio program.</para>
    ///   <a href="http://rdvocab.info/roles/radioProducerWork">rdarole:radioProducerWork</a>
    /// </summary>
    let radioProducerWork = _prefixId.prefix "radioProducerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineer</para>
    ///   <para>rdfs:label : Recording engineerrdfs:label : Toningenieur </para>
    ///   <a href="http://rdvocab.info/roles/recordingEngineer">rdarole:recordingEngineer</a>
    /// </summary>
    let recordingEngineer = _prefixId.prefix "recordingEngineer"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie die technischen Aspekte einer Ton- oder Videoaufnahme überwachtskos:definition : A person, family, or corporate body contributing to an expression of a work by supervising the technical aspects of a sound or video recording session.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingEngineerExpression</para>
    ///   <para>rdfs:label : Toningenieur (Expression)rdfs:label : Recording engineer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/recordingEngineerExpression">rdarole:recordingEngineerExpression</a>
    /// </summary>
    let recordingEngineerExpression = _prefixId.prefix "recordingEngineerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordist</para>
    ///   <para>rdfs:label : Recordistrdfs:label : Recordist </para>
    ///   <a href="http://rdvocab.info/roles/recordist">rdarole:recordist</a>
    /// </summary>
    let recordist = _prefixId.prefix "recordist"
    /// <summary>
    ///   <para>rdfs:label : Recordist (Expression)rdfs:label : Recordist (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordistExpression</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by using a recording device to capture sound and/or video during a recording session, including field recordings of natural sounds, folkloric events, music, etc.skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie mit einem Aufzeichnungsgerät Ton und/oder Bild aufnimmt, einschließlich Außenaufnahmen natürlicher Geräusche, folkloristischer Veranstaltungen, Musik o.ä.</para>
    ///   <a href="http://rdvocab.info/roles/recordistExpression">rdarole:recordistExpression</a>
    /// </summary>
    let recordistExpression = _prefixId.prefix "recordistExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondent</para>
    ///   <para>rdfs:label : Respondentrdfs:label : Respondent </para>
    ///   <a href="http://rdvocab.info/roles/respondent">rdarole:respondent</a>
    /// </summary>
    let respondent = _prefixId.prefix "respondent"
    /// <summary>
    ///   <para>rdfs:label : Respondent (Work)rdfs:label : Respondent (Werk)</para>
    ///   <para>skos:definition : Ein Kandidat für einen akademischen Grad, der eine These, die von dem Disputationsleiter in einer akademischen Disputation aufgestellt wurde, verteidigt oder ablehnt. Auch Proponent / Opponent genannt.skos:definition : A candidate for a degree who defends or opposes a theses provided by the praeses in an academic disputation. Also called defendant.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : respondentWork</para>
    ///   <a href="http://rdvocab.info/roles/respondentWork">rdarole:respondentWork</a>
    /// </summary>
    let respondentWork = _prefixId.prefix "respondentWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationist</para>
    ///   <para>rdfs:label : Restorationistrdfs:label : Restaurator </para>
    ///   <a href="http://rdvocab.info/roles/restorationist">rdarole:restorationist</a>
    /// </summary>
    let restorationist = _prefixId.prefix "restorationist"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for the set of technical, editorial and intellectual procedures aimed at compensating for the degradation of an artifact, such as bringing it back to a state as close as possible to its original condition.skos:definition : Eine Person, Familie oder Körperschaft, die für den Vertrieb einer Bewegtbildmanifestation an Kinos oder andere Vertriebskanäle verantwortlich ist. </para>
    ///   <para>rdfs:label : Restorationist (Item)rdfs:label : Restaurator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationistItem</para>
    ///   <a href="http://rdvocab.info/roles/restorationistItem">rdarole:restorationistItem</a>
    /// </summary>
    let restorationistItem = _prefixId.prefix "restorationistItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriter</para>
    ///   <para>rdfs:label : Screenwriterrdfs:label : Drehbuchautor </para>
    ///   <a href="http://rdvocab.info/roles/screenwriter">rdarole:screenwriter</a>
    /// </summary>
    let screenwriter = _prefixId.prefix "screenwriter"
    /// <summary>
    ///   <para>skos:definition : An author of a screenplay, script, or scene.skos:definition : Ein Autor eines Drehbuchs, eines Manuskripts oder einer Szene. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenwriterWork</para>
    ///   <para>rdfs:label : Screenwriter (Work)rdfs:label : Drehbuchautor (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/screenwriterWork">rdarole:screenwriterWork</a>
    /// </summary>
    let screenwriterWork = _prefixId.prefix "screenwriterWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptor</para>
    ///   <para>rdfs:label : Sculptorrdfs:label : Bildhauer </para>
    ///   <a href="http://rdvocab.info/roles/sculptor">rdarole:sculptor</a>
    /// </summary>
    let sculptor = _prefixId.prefix "sculptor"
    /// <summary>
    ///   <para>skos:definition : An artist responsible for creating a three-dimensional work by modeling, carving, or similar technique.skos:definition : Ein Künstler, der für die Erstellung eines dreidimensionalen Werkes durch Modellierung, Schnitzen oder ähnliche Techniken verantwortlich ist.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sculptorWork</para>
    ///   <para>rdfs:label : Sculptor (Work)rdfs:label : Bildhauer (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/sculptorWork">rdarole:sculptorWork</a>
    /// </summary>
    let sculptorWork = _prefixId.prefix "sculptorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seller</para>
    ///   <para>rdfs:label : Sellerrdfs:label : Verkäufer </para>
    ///   <a href="http://rdvocab.info/roles/seller">rdarole:seller</a>
    /// </summary>
    let seller = _prefixId.prefix "seller"
    /// <summary>
    ///   <para>skos:definition : Ein ehemaliger Eigentümer eines Exemplars, der dieses Exemplar an einen anderen Eigentümer verkauft hat. skos:definition : A former owner of an item who sold that item to another owner.</para>
    ///   <para>rdfs:label : Seller (Item)rdfs:label : Verkäufer (Exemplar)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sellerItem</para>
    ///   <a href="http://rdvocab.info/roles/sellerItem">rdarole:sellerItem</a>
    /// </summary>
    let sellerItem = _prefixId.prefix "sellerItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singer</para>
    ///   <para>rdfs:label : Singerrdfs:label : Sänger </para>
    ///   <a href="http://rdvocab.info/roles/singer">rdarole:singer</a>
    /// </summary>
    let singer = _prefixId.prefix "singer"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by using his/her/their voice, with or without instrumental accompaniment, to produce music. A singer’s performance may or may not include actual words.skos:definition : Ein Darsteller, der an einer Expression eines Werkes mitwirkt, indem er durch seine Stimme mit oder ohne instrumentale Begleitung Musik erzeugt. Die Darbietung eines Sängers kann Worte enthalten oder nicht. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : singerExpression</para>
    ///   <para>rdfs:label : Sänger (Expression)rdfs:label : Singer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/singerExpression">rdarole:singerExpression</a>
    /// </summary>
    let singerExpression = _prefixId.prefix "singerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speaker</para>
    ///   <para>rdfs:label : Speakerrdfs:label : Sprecher </para>
    ///   <a href="http://rdvocab.info/roles/speaker">rdarole:speaker</a>
    /// </summary>
    let speaker = _prefixId.prefix "speaker"
    /// <summary>
    ///   <para>rdfs:label : Sprecher (Expression)rdfs:label : Speaker (Expression)</para>
    ///   <para>skos:definition : A performer contributing to an expression of a work by speaking words, such as a lecture, speech, etc.skos:definition : Ein Darsteller, der an einer Expression eines Werkes durch das Sprechen von Worten, wie z.B. einen Vortrag, eine Rede o.ä. mitwirkt.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : speakerExpression</para>
    ///   <a href="http://rdvocab.info/roles/speakerExpression">rdarole:speakerExpression</a>
    /// </summary>
    let speakerExpression = _prefixId.prefix "speakerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBody</para>
    ///   <para>rdfs:label : Sponsoring bodyrdfs:label : Sponsor </para>
    ///   <a href="http://rdvocab.info/roles/sponsoringBody">rdarole:sponsoringBody</a>
    /// </summary>
    let sponsoringBody = _prefixId.prefix "sponsoringBody"
    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body sponsoring some aspect of the work, e.g., funding research, sponsoring an event. skos:definition : Eine Person, Familie oder Körperschaft, die einzelne Aspekte des Werks finanziell unterstützt, z. B. Forschungsförderung, finanzielle Unterstützung einer Veranstaltung.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sponsoringBodyWork</para>
    ///   <para>rdfs:label : Sponsoring body (Work)rdfs:label : Sponsor (Werk)</para>
    ///   <a href="http://rdvocab.info/roles/sponsoringBodyWork">rdarole:sponsoringBodyWork</a>
    /// </summary>
    let sponsoringBodyWork = _prefixId.prefix "sponsoringBodyWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirector</para>
    ///   <para>rdfs:label : Stage directorrdfs:label : Theaterregisseur </para>
    ///   <a href="http://rdvocab.info/roles/stageDirector">rdarole:stageDirector</a>
    /// </summary>
    let stageDirector = _prefixId.prefix "stageDirector"
    /// <summary>
    ///   <para>rdfs:label : Stage director (Expression)rdfs:label : Theaterregisseur </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stageDirectorExpression</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a stage work through the general management and supervision of a performance.skos:definition : Eine Person, Familie oder Körperschaft, die an der Expression eines Bühnenwerks durch die allgemeine Betreuung und Leitung einer Darbietung mitwirken.</para>
    ///   <a href="http://rdvocab.info/roles/stageDirectorExpression">rdarole:stageDirectorExpression</a>
    /// </summary>
    let stageDirectorExpression = _prefixId.prefix "stageDirectorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storyteller</para>
    ///   <para>rdfs:label : Storytellerrdfs:label : Geschichtenerzähler </para>
    ///   <a href="http://rdvocab.info/roles/storyteller">rdarole:storyteller</a>
    /// </summary>
    let storyteller = _prefixId.prefix "storyteller"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : storytellerExpression</para>
    ///   <para>rdfs:label : Geschichtenerzähler (Expression)rdfs:label : Storyteller (Expression)</para>
    ///   <para>skos:definition : Ein Darsteller, der an einer Expression eines Werks mitwirkt, indem er die ursprüngliche Geschichte eines geistigen Schöpfers mit dramatischer oder theatralischer Interpretation weitergibt.skos:definition : A performer contributing to an expression of a work by relaying a creator’s original story with dramatic or theatrical interpretation.</para>
    ///   <a href="http://rdvocab.info/roles/storytellerExpression">rdarole:storytellerExpression</a>
    /// </summary>
    let storytellerExpression = _prefixId.prefix "storytellerExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyor</para>
    ///   <para>rdfs:label : Surveyorrdfs:label : Vermesser </para>
    ///   <a href="http://rdvocab.info/roles/surveyor">rdarole:surveyor</a>
    /// </summary>
    let surveyor = _prefixId.prefix "surveyor"
    /// <summary>
    ///   <para>rdfs:label : Surveyor (Expression)rdfs:label : Vermesser (Expression)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an der Expression eines kartografischen Werkes mitwirkt, indem sie Messwerte oder Abmessungsverhältnisse
    /// für den dargestellten geografischen Bereich zur Verfügung stellt. skos:definition : A person, family, or corporate body contributing to an expression of a cartographic work by providing measurements or dimensional relationships for the geographic area represented.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : surveyorExpression</para>
    ///   <a href="http://rdvocab.info/roles/surveyorExpression">rdarole:surveyorExpression</a>
    /// </summary>
    let surveyorExpression = _prefixId.prefix "surveyorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacher</para>
    ///   <para>rdfs:label : Teacherrdfs:label : Lehrer </para>
    ///   <a href="http://rdvocab.info/roles/teacher">rdarole:teacher</a>
    /// </summary>
    let teacher = _prefixId.prefix "teacher"
    /// <summary>
    ///   <para>skos:definition : A performer contributing to an expression of a work by giving instruction or providing a demonstration.skos:definition : Ein Darsteller, der im Zusammenhang mit einer Expression eines Werkes Anleitungen gibt oder Demonstrationen bietet. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : teacherExpression</para>
    ///   <para>rdfs:label : Teacher (Expression)rdfs:label : Lehrer (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/teacherExpression">rdarole:teacherExpression</a>
    /// </summary>
    let teacherExpression = _prefixId.prefix "teacherExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirector</para>
    ///   <para>rdfs:label : Television directorrdfs:label : Fernsehintendant </para>
    ///   <a href="http://rdvocab.info/roles/televisionDirector">rdarole:televisionDirector</a>
    /// </summary>
    let televisionDirector = _prefixId.prefix "televisionDirector"
    /// <summary>
    ///   <para>skos:definition : A director responsible for the general management and supervision of a television program.skos:definition : Eine Person, Familie oder Körperschaft, die für das allgemeine Management und die Leitung eines Fernsehprogramms verantwortlich ist.</para>
    ///   <para>rdfs:label : Fernsehintendant (Werk)rdfs:label : Television director (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionDirectorWork</para>
    ///   <a href="http://rdvocab.info/roles/televisionDirectorWork">rdarole:televisionDirectorWork</a>
    /// </summary>
    let televisionDirectorWork = _prefixId.prefix "televisionDirectorWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducer</para>
    ///   <para>rdfs:label : Television producerrdfs:label : Fernsehproduzent </para>
    ///   <a href="http://rdvocab.info/roles/televisionProducer">rdarole:televisionProducer</a>
    /// </summary>
    let televisionProducer = _prefixId.prefix "televisionProducer"
    /// <summary>
    ///   <para>rdfs:label : Fernsehproduzent (Werk)rdfs:label : Television producer (Work)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die die Verantwortung für die meisten geschäftlichen Aspekte eines Fernsehprogramms übernimmt.
    /// Der Fernsehproduzent ist hauptsächlich verantwortlich für die Geldbeschaffung, das Produktionsmanagement, die Einstellung der Kompetenzträger, die Organisation des Vertriebs, die Absicherung des kommerziellen Erfolges usw.skos:definition : A producer responsible for most of the business aspects of a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionProducerWork</para>
    ///   <a href="http://rdvocab.info/roles/televisionProducerWork">rdarole:televisionProducerWork</a>
    /// </summary>
    let televisionProducerWork = _prefixId.prefix "televisionProducerWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : thesisAdvisor</para>
    ///   <para>rdfs:label : Thesis Advisor</para>
    ///   <a href="http://rdvocab.info/roles/thesisAdvisor">rdarole:thesisAdvisor</a>
    /// </summary>
    let thesisAdvisor = _prefixId.prefix "thesisAdvisor"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriber</para>
    ///   <para>rdfs:label : Transcriberrdfs:label : Transkribierer </para>
    ///   <a href="http://rdvocab.info/roles/transcriber">rdarole:transcriber</a>
    /// </summary>
    let transcriber = _prefixId.prefix "transcriber"
    /// <summary>
    ///   <para>rdfs:label : Transcriber (Expression)rdfs:label : Transkribierer (Expression)</para>
    ///   <para>skos:definition : A person, family, or corporate body contributing to an expression of a work by changing it from one system of notation to another.skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie es von einem Notationssystem in ein anderes überträgt. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transcriberExpression</para>
    ///   <a href="http://rdvocab.info/roles/transcriberExpression">rdarole:transcriberExpression</a>
    /// </summary>
    let transcriberExpression = _prefixId.prefix "transcriberExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translator</para>
    ///   <para>rdfs:label : Translatorrdfs:label : Übersetzer </para>
    ///   <a href="http://rdvocab.info/roles/translator">rdarole:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie eine Sprache in eine andere übersetzt, oder aus einer älteren Sprachform in die moderne Form, die mehr oder weniger eng dem Originaltext des Werkes folgt.skos:definition : A person, family, or corporate body contributing to an expression of a work by rendering one language into another, or from an older form of a language into the modern form, that more or less closely follows the original text of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatorExpression</para>
    ///   <para>rdfs:label : Übersetzer (Expression)rdfs:label : Translator (Expression)</para>
    ///   <a href="http://rdvocab.info/roles/translatorExpression">rdarole:translatorExpression</a>
    /// </summary>
    let translatorExpression = _prefixId.prefix "translatorExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentary</para>
    ///   <para>rdfs:label : Writer of added commentaryrdfs:label : Kommentator (schriftlich) </para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedCommentary">rdarole:writerOfAddedCommentary</a>
    /// </summary>
    let writerOfAddedCommentary = _prefixId.prefix "writerOfAddedCommentary"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedCommentaryExpression</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines Werkes mitwirkt, indem sie eine Interpretation oder kritische Erläuterung des Originalwerkes verfasst.skos:definition : A person, family, or corporate body contributing to an expression of a work by providing an interpretation or critical explanation of the original work.</para>
    ///   <para>rdfs:label : Writer of added commentary (Expression)rdfs:label : Kommentator (schriftlich) (Eypression)</para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedCommentaryExpression">rdarole:writerOfAddedCommentaryExpression</a>
    /// </summary>
    let writerOfAddedCommentaryExpression =
        _prefixId.prefix "writerOfAddedCommentaryExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyrics</para>
    ///   <para>rdfs:label : Writer of added lyricsrdfs:label : Verfasser eines Textes, der nachträglich einem Musikwerk unterlegt wird </para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedLyrics">rdarole:writerOfAddedLyrics</a>
    /// </summary>
    let writerOfAddedLyrics = _prefixId.prefix "writerOfAddedLyrics"
    /// <summary>
    ///   <para>skos:definition : A writer of words added to an expression of a musical work. skos:definition : Ein Verfasser eines Textes, der einer Expression eines Musikwerkes beigefügt wird. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedLyricsExpression</para>
    ///   <para>rdfs:label : Writer of added lyrics (Expression)rdfs:label : Verfasser eines Textes, der nachträglich einem Musikwerk unterlegt wird (Expression).</para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedLyricsExpression">rdarole:writerOfAddedLyricsExpression</a>
    /// </summary>
    let writerOfAddedLyricsExpression = _prefixId.prefix "writerOfAddedLyricsExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedText</para>
    ///   <para>rdfs:label : Writer of added textrdfs:label : Verfasser von Zusatztexten </para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedText">rdarole:writerOfAddedText</a>
    /// </summary>
    let writerOfAddedText = _prefixId.prefix "writerOfAddedText"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : writerOfAddedTextExpression</para>
    ///   <para>rdfs:label : Verfasser von Zusatztexten (Expression)rdfs:label : Writer of added text (Expression)</para>
    ///   <para>skos:definition : Eine Person, Familie oder Körperschaft, die an einer Expression eines primär nicht-textlichen Werkes mitwirkt, indem sie Texte für das nicht-textliche Werk eines anderen Schöpfers verfasst (z.B. Bildunterschriften für Fotografien, Beschreibungen von Karten).skos:definition : A person, family, or corporate body contributing to an expression of a primarily non-textual work by providing text for the non-textual work (e.g., writing captions for photographs, descriptions of maps).</para>
    ///   <a href="http://rdvocab.info/roles/writerOfAddedTextExpression">rdarole:writerOfAddedTextExpression</a>
    /// </summary>
    let writerOfAddedTextExpression = _prefixId.prefix "writerOfAddedTextExpression"

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cis =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://dati.beniculturali.it/cis/" "cis"

    let _namespaceIri = _prefixId.prefix ""
    let ``_2.0`` = _prefixId.prefix "2.0"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Condizioni di accessordfs:label : Access condition</para>
    ///   <para>rdfs:comment : Concept used to represent general information for the public access to the Cultural Institute or Site or to the Event. For instance, examples of information include: opening hours, type of admission, temporary closing, etc.rdfs:comment : Concetto che rappresenta le informazioni generali per l'accesso da parte del pubblico all'Istituto e Luogo della Cultura e all'evento. Per esempio consente di modellare informazioni quali gi orari di apertura, le chiusure temporanee (con le relative motivazioni), il tipo di apertura al pubblico, ecc.</para>
    ///   <para>dce:description : This class is used for representing the access conditions associated with a 'Cultural Institute or Site' or an 'Event'.
    /// Access conditions are meant to be indivuduals of the following classes:
    ///   * Opening Hours Specification
    ///   * Temporary Closure
    ///   * Type of Booking
    ///
    /// An example in turtle is the following:
    ///
    /// &lt;pre&gt;
    /// cis a CulturalInstituteOrSite ;
    ///   description "An entity representing an individual of the class 'Institute or Site.'" ;
    ///   hasAccessCondition cis_access_condition .
    ///
    /// cis_access_condition a Access ;
    ///   description "The individual of the class 'Access' that specifies the access
    ///   condition associated with the CulturalInstituteOrSite called cis" .
    /// &lt;/pre&gt;dce:description : Questa classe è utilizzata per rappresentare le condizioni di accesso associate a un "Istituto e luogo della Culrura" o a un "Evento": Le condizione di accesso sono individui delle seguenti classi:
    ///  * Orari di apertura
    ///  * Chiusara Temporanea
    ///  * Tipo di Prenotazione
    ///
    /// Un esempio dell'uso della classe in turle è il seguente:
    /// &lt;pre&gt;
    /// cis a CulturalInstituteOrSite ;
    ///   description "An entity representing an individual of the class 'Institute or Site.'" ;
    ///   hasAccessCondition cis_access_condition .
    ///
    /// cis_access_condition a Access ;
    ///   description "The individual of the class 'Access' that specifies the access
    ///   condition associated with the CulturalInstituteOrSite called cis" .
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/AccessCondition">cis:AccessCondition</a>
    /// </summary>
    let AccessCondition = _prefixId.prefix "AccessCondition"
    /// <summary>
    ///   <para>rdfs:comment : It represents an address as defined by the specifications of the EU INSPIRE directive https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538rdfs:comment : Rappresenta un indirizzo così come descritto nelle specifiche della direttiva Europea INSPIRE https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Indirizzordfs:label : Address</para>
    ///   <para>dce:description : Individuals of the class Site are associated with individual of the class Address by means of the object property hasAddress.
    /// An address is characterised by the following properties:
    ///
    ///  * addressIdentifier: a unique ID of the address;
    ///  * administrativeUnitLevel1: e.g., Rome;
    ///  * administrativeUnitLevel2: e.g., Lazio;
    ///  * fullAddress: the literal that records the full address as a string;
    ///  * postCode: the postal code corresponding to the address;
    ///  * postName: the key postal name, usually the city ;
    ///
    ///
    /// An example in turtle is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///
    ///
    /// address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Address ;
    ///       rdfs:label "Indirizzo della sede di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:addressID "IT-RM0267_IT_1" ;
    ///       cis:adminUnitL1 "Roma"@it ;
    ///       cis:adminUnitL2 "Lazio"@it ;
    ///       cis:fullAddress "Viale Castro Pretorio 105 - 00185 - Roma (RM" ;
    ///       cis:postName "Rome" ;
    ///       cis:postCode "00185" .
    ///
    /// &lt;/pre&gt;dce:description : Individui della classe Address sono connessi ad invididui della classe Site attraverso la proprietà che collega Site ad Address hasAddress.
    /// Un indirizzo è caratterizzato dalle seguenti proprietà:
    ///
    ///  * Identificativo dell'indirizzo: un ID univoco dell'indirizzo;
    ///  * livello amministrativo 1: di solito il comune, e.g., Roma;
    ///  * livello amministrativo 2: di solito la regione, e.g., Lazio;
    ///  * indirizzo completo: un literal che rappresenta l'indirizzo completo come una stringa
    ///  * codice postale: il codice postale corrispondere all'indirizzo.
    ///  * nome postale: il nome chiave postale di solito la città
    ///
    /// Un esempio in turtle è il seguente:
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///
    ///
    /// address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Address ;
    ///       rdfs:label "Indirizzo della sede di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:addressID "IT-RM0267_IT_1" ;
    ///       cis:adminUnitL1 "Roma"@it ;
    ///       cis:adminUnitL2 "Lazio"@it ;
    ///       cis:fullAddress "Viale Castro Pretorio 105 - 00185 - Roma (RM") ;
    ///       cis:postName "Roma" ;
    ///       cis:postCode "00185" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Address">cis:Address</a>
    /// </summary>
    let Address = _prefixId.prefix "Address"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Rappresenta il tipo di apertura al pubblico. Esempi sono: Settimanale, Mensile, Giornaliera, ecc.rdfs:comment : It represents the type of admission. Examples are: weekly, monthly, daily, etc. </para>
    ///   <para>rdfs:label : Tipo di aperturardfs:label : Admission Type</para>
    ///   <para>dce:description : Individui di questa classe identificano i possibili tipi di politiche di accesso che possono essere applicate agli orari di apertura di un luogo e istituto della cultura.
    ///
    /// Per esempio, indicano che un istituto e luogo della cultura apre alle 9:00 e chiude ogni giorno alle 17:00.
    ///
    /// Un esempio in turle è il seguente:
    /// &lt;pre&gt;
    ///
    ///
    /// openingHoursSpecification:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType
    ///               admissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    ///
    /// admissionType:Tipo_di_apertura_al_pubblico
    ///       a       cis:AdmissionType ;
    ///       rdfs:label "Tipo di apertura al pubblico" ;
    ///       cis:name "giornaliera" ;
    ///       cis:description "Apertura al pubblico giornaliera" .
    ///
    /// &lt;/pre&gt;dce:description : Individuals of this class identify the possible admission types (in terms of access policies) that can be applied to the opening hours specifications of a Cultural Institute or Site (CIS).
    ///
    /// For example. it can be used to indicate that the a CIS opens at 9:00 and closes at 17:00 &lt;b&gt;daily&lt;/b&gt;.
    ///
    /// An example in turtle is the following.
    ///
    /// &lt;pre&gt;
    ///
    ///
    /// openingHoursSpecification:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType
    ///               admissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    ///
    /// admissionType:Tipo_di_apertura_al_pubblico
    ///       a       cis:AdmissionType ;
    ///       rdfs:label "Tipo di apertura al pubblico" ;
    ///       cis:name "giornaliera" ;
    ///       cis:description "Apertura al pubblico giornaliera" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/AdmissionType">cis:AdmissionType</a>
    /// </summary>
    let AdmissionType = _prefixId.prefix "AdmissionType"
    /// <summary>
    ///   <para>rdfs:comment : Rappresenta un agente. Esso può essere un'organizzazione (pubblica e/o privata), un'associazione/fondazione, un singolo soggetto. Per esempio, nel contesto della presente ontologia può essere utilizzato per rappresentare una soprintendenza, un comune, un singolo soggetto privato, ecc.rdfs:comment : It represents an agent. It can be an organization (public and/or private), an association/foundation or a single person. In the context of this ontology it can be a municipality, a supervision authority, a single private citizen</para>
    ///   <para>rdfs:label : Agentrdfs:label : Agente</para>
    ///   <para>dce:description : An Agent is described by means of its name and a set of properties that allows modeling its role in time and, in case of physical persons, his/her belonging relationship to the public or private organization.
    ///
    /// An example of the use of the Agent class only is provided below in turtle (for an example of the role modeling, interested readers can refer to the examples provided with the  Role and RoleInTime classes):
    ///
    /// &lt;pre&gt;
    ///
    /// agent:Andrea_De_Pasquale
    ///     a cis:Agent ;
    ///     rdfs:label "Andrea De Pasquale" ;
    ///     cis:name "Andrea De Pasquale" ;
    ///     cis:reportsTo agent:Soprintendenza_Roma ;
    ///     cis:holdsRoleInTime roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale .
    ///
    /// agent:Soprintendenza_Roma
    ///     a cis:Agent ;
    ///     rdfs:label "Superintendence Rome"@en ;
    ///     rdfs:label "Soprintendenza Roma"@it ;
    ///     cis:name "Superintendence Rome"@en ;
    ///     cis:name "Soprintendenza Roma esempio"@it .
    ///
    /// &lt;/pre&gt;dce:description : Un agente è descritto mediante il suo nome e da una serie di proprietà che consentono di modellare il suo ruolo nel tempo e, nel caso di persone fisiche, di appartenenza a una certa organizzazione, pubblica o privata.
    ///
    /// Un esempio solo dell'uso della classe Agent in turtle è il seguente (per l'uso delle classi relative al ruolo si vedano le classi Role e RoleInTime):
    ///
    /// &lt;pre&gt;
    ///
    /// agent:Andrea_De_Pasquale
    ///     a cis:Agent ;
    ///     rdfs:label "Andrea De Pasquale" ;
    ///     cis:name "Andrea De Pasquale" ;
    ///     cis:reportsTo agent:Soprintendenza_Roma ;
    ///     cis:holdsRoleInTime roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale .
    ///
    /// agent:Soprintendenza_Roma
    ///     a cis:Agent ;
    ///     rdfs:label "Superintendence Rome"@en ;
    ///     rdfs:label "Soprintendenza Roma"@it ;
    ///     cis:name "Superintendence Rome"@en ;
    ///     cis:name "Soprintendenza Roma esempio"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/Agent">cis:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:ArchaeologicalArea is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_delle_navi_romane_di_Nemi
    ///     a cis:CulturalInstituteOrSite, cis:ArchaeologicalArea ;
    ///     rdfs:label "Museo delle navi romane di Nemi" ;
    ///     cis:institutionalName "Museo delle navi romane di Nemi" ;
    ///     cis:ISILIdentifier "IT-EX0001" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di uso della classe cis:ArchaeologicalArea è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_delle_navi_romane_di_Nemi
    ///     a cis:CulturalInstituteOrSite, cis:ArchaeologicalArea ;
    ///     rdfs:label "Museo delle navi romane di Nemi" ;
    ///     cis:institutionalName "Museo delle navi romane di Nemi" ;
    ///     cis:ISILIdentifier "IT-EX0001" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Area archeologica.rdfs:comment : It represents a specific type of Cultural Institute or SIte; that is, ArchaeologicalArea</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Archaeological Areardfs:label : Area Archeologica</para>
    ///   <a href="http://dati.beniculturali.it/cis/ArchaeologicalArea">cis:ArchaeologicalArea</a>
    /// </summary>
    let ArchaeologicalArea = _prefixId.prefix "ArchaeologicalArea"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Archaeological Parkrdfs:label : Parco Archeologico</para>
    ///   <para>rdfs:comment : It represents a specific type of Cultural Institute or SIte; that is, Archaeological Parkrdfs:comment : Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Parco Archeologico.</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:ArchaeologicalPark è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Parco_archeologico_di_Liternum
    ///     a cis:CulturalInstituteOrSite, cis:ArchaeologicalPark ;
    ///     rdfs:label "Parco archeologico di Liternum" ;
    ///     cis:institutionalName "Parco archeologico di Liternum" ;
    ///     cis:ISILIdentifier "IT-EX0002" .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:ArchaeologicalPark is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Parco_archeologico_di_Liternum
    ///     a cis:CulturalInstituteOrSite, cis:ArchaeologicalPark ;
    ///     rdfs:label "Parco archeologico di Liternum" ;
    ///     cis:institutionalName "Parco archeologico di Liternum" ;
    ///     cis:ISILIdentifier "IT-EX0002" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/ArchaeologicalPark">cis:ArchaeologicalPark</a>
    /// </summary>
    let ArchaeologicalPark = _prefixId.prefix "ArchaeologicalPark"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Rappresenta gli attributi di una certa descrizione della sede fisica di un istituto e luogo della cultura. Per esempio, metratura, scaffalatura, ecc.rdfs:comment : It represents the attribute that a site description of a site of a cultural institute or site may have. For instance, length, the shelving in a library, etc.</para>
    ///   <para>rdfs:label : Attributordfs:label : Attribute</para>
    ///   <para>dce:description : An example of usage of the class cis:Attribute is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// attribute:Shelving
    ///     a cis:Attribute ;
    ///     rdfs:label "Shelving"@en ;
    ///     rdfs:label "Scaffalature"@it ;
    ///     cis:name "Shelving"@en ;
    ///     cis:name "Scaffalature"@it ;
    ///     cis:description "The linear dimension of a shelf unit (e.g. 3 meters)"@en ;
    ///     cis:description "La dimensione di uno scaffale in metri lineari (es. 3 metri)"@it .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:Attribute è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// attribute:Shelving
    ///     a cis:Attribute ;
    ///     rdfs:label "Shelving"@en ;
    ///     rdfs:label "Scaffalature"@it ;
    ///     cis:name "Shelving"@en ;
    ///     cis:name "Scaffalature"@it ;
    ///     cis:description "The linear dimension of a shelf unit (e.g. 3 meters)"@en ;
    ///     cis:description "La dimensione di uno scaffale in metri lineari (es. 3 metri)"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Attribute">cis:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>rdfs:label : Oggetto audiordfs:label : Audio Object</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : An example of usage of the class cis:AudioObject is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// audio:Audio_Tour_Parco_archeologico_di_Liternum
    ///     a cis:AudioObject , cis:CreativeWork ;
    ///     rdfs:label "Audio Tour of the Parco archeologico di Liternum"@en ;
    ///     rdfs:label "Audio guida del Parco archeologico di Liternum"@it ;
    ///     cis:url http://www.example.com/Audio/Audio_Tour_Parco_archeologico_di_Liternum.mp3 ;
    ///     cis:isAbout cissite:Parco_archeologico_di_Liternum .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:AudioObject è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// audio:Audio_Tour_Parco_archeologico_di_Liternum
    ///     a cis:AudioObject , cis:CreativeWork ;
    ///     rdfs:label "Audio Tour of the Parco archeologico di Liternum"@en ;
    ///     rdfs:label "Audio guida del Parco archeologico di Liternum"@it ;
    ///     cis:url http://www.example.com/Audio/Audio_Tour_Parco_archeologico_di_Liternum.mp3 ;
    ///     cis:isAbout cissite:Parco_archeologico_di_Liternum .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Concetto utilizzato per rappresentare materiali multimediali di tipo audio.rdfs:comment : Concept used to represent multimedia objects of type audio.</para>
    ///   <a href="http://dati.beniculturali.it/cis/AudioObject">cis:AudioObject</a>
    /// </summary>
    let AudioObject = _prefixId.prefix "AudioObject"
    /// <summary>
    ///   <para>rdfs:comment : It represents the  type of booking for the cultural institute or site or for the event. Examples can be: Mandatory, Optional, None (free access).rdfs:comment : Rappresenta la tipologia di prenotazione per l'istituto e luogo della cultura o per l'evento. Esempi possono essere: Obbligatoria, Facoltativa, Nessuna (ingresso libero).</para>
    ///   <para>rdfs:label : Tipo prenotazionerdfs:label : Type of Booking</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : An example of usage of the class cis:Booking is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// booking:Mandatory
    ///     a cis:Booking , cis:AccessCondition ;
    ///     rdfs:label "Mandatory Booking"@en ;
    ///     rdfs:label "Prenotazione obbligatoria"@it ;
    ///     cis:name "Mandatory Booking"@en ;
    ///     cis:name "Prenotazione obbligatoria"@it ;
    ///     cis:description "Per accedere al luogo della cultura o evento è necessaria la prenotazione"@it ;
    ///     cis:description "Booking is mandatory in order to access to the CIS or the event"@en ;
    ///     cis:accessConditionFor event:Vincenzo_Gemito_al_Museo_di_Capodimonte .
    ///
    /// event:Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:Event ;
    ///     cis:isHostedBy site:Museo_di_Capodimonte ;
    ///     rdfs:label "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     cis:name "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     rdfs:comment "Apre al pubblico al Museo di Capodimonte la mostra ‘Vincenzo Gemito, dal salotto Minozzi
    ///     al Museo di Capodimonte’,
    ///     organizzata dalla Soprintendenza speciale per il patrimonio storico" ;
    ///     cis:involves culturalheritageobject:Il_giocatore_di_carte ;
    ///     cis:hasSubEvent event:VincenzoGemitoIlPescatorello ;
    ///     cis:hasAccessCondition booking:Mandatory ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di uso della classe cis:Booking è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// booking:Mandatory
    ///     a cis:Booking , cis:AccessCondition ;
    ///     rdfs:label "Mandatory Booking"@en ;
    ///     rdfs:label "Prenotazione obbligatoria"@it ;
    ///     cis:name "Mandatory Booking"@en ;
    ///     cis:name "Prenotazione obbligatoria"@it ;
    ///     cis:description "Per accedere al luogo della cultura o evento è necessaria la prenotazione"@it ;
    ///     cis:description "Booking is mandatory in order to access to the CIS or the event"@en ;
    ///     cis:accessConditionFor event:Vincenzo_Gemito_al_Museo_di_Capodimonte .
    ///
    /// event:Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:Event ;
    ///     cis:isHostedBy site:Museo_di_Capodimonte ;
    ///     rdfs:label "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     cis:name "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     rdfs:comment "Apre al pubblico al Museo di Capodimonte la mostra ‘Vincenzo Gemito, dal salotto
    ///     'Minozzi al Museo di Capodimonte’,
    ///     organizzata dalla Soprintendenza speciale per il patrimonio storico" ;
    ///     cis:involves culturalheritageobject:Il_giocatore_di_carte ;
    ///     cis:hasSubEvent event:VincenzoGemitoIlPescatorello ;
    ///     cis:hasAccessCondition booking:Mandatory ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Booking">cis:Booking</a>
    /// </summary>
    let Booking = _prefixId.prefix "Booking"
    /// <summary>
    ///   <para>rdfs:label : Cultural Institute or Site Typerdfs:label : Tipo di Istituto e Luogo della Cultura</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di istituto e luogo della cultura.rdfs:comment : This class represents the type of cultural institute or site.</para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <a href="http://dati.beniculturali.it/cis/CISType">cis:CISType</a>
    /// </summary>
    let CISType = _prefixId.prefix "CISType"
    /// <summary>
    ///   <para>rdfs:label : Cardrdfs:label : Carta d'ingresso</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a card valid for the entrance to more than one Cultural Institute or Site. It is a subclass of Ticket.rdfs:comment : Questa classe rappresenta una carta d'ingresso che dà diritto a più ingressi in più luoghi della cultura. E' sottoclasse di ticket.</para>
    ///   <para>dce:description : An example of usage of the class cis:Card is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// card:Parco_archeologico_di_Liternum_Card
    ///     a cis:Card ;
    ///     rdfs:label "Ingresso per due giorni al Parco archeologico di Liternum"@it ;
    ///     rdfs:label "Two-day access to Parco archeologico di Liternum"@en ;
    ///     cis:name "Ingresso per due giorni al Parco archeologico di Liternum"@it ;
    ///     cis:name "Two-day access to the Parco archeologico di Liternum"@en ;
    ///     cis:hasValidity Parco_archeologico_di_Liternum_Card_Validity ;
    ///     cis:forAccessTo cissite:Parco_archeologico_di_Liternum ;
    ///     cis:description "With this card a tourist can visit Parco archeologico di Liternum for 2 consecutive days"@en ;
    ///     cis:description "La card permette l'accesso al Parco archeologico di Liternum per 2 giorni consecutivi"@it .
    ///
    /// validity:Parco_archeologico_di_Liternum_Card_Validity
    ///     a cis:Validity ;
    ///     rdfs:label "Two-day validity"@en ;
    ///     rdfs:label "Validità per due giorni"@it ;
    ///     cis:hasDuration Parco_archeologico_di_Liternum_Card_Validity_Duration .
    ///
    /// quantitativevalue:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2" ;
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:Card  è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// card:Parco_archeologico_di_Liternum_Card
    ///     a cis:Card ;
    ///     rdfs:label "Ingresso per due giorni al Parco archeologico di Liternum"@it ;
    ///     rdfs:label "Two-day access to Parco archeologico di Liternum"@en ;
    ///     cis:name "Ingresso per due giorni al Parco archeologico di Liternum"@it ;
    ///     cis:name "Two-day access to the Parco archeologico di Liternum"@en ;
    ///     cis:hasValidity Parco_archeologico_di_Liternum_Card_Validity ;
    ///     cis:forAccessTo cissite:Parco_archeologico_di_Liternum ;
    ///     cis:description "With this card a tourist can visit Parco archeologico di Liternum for 2 consecutive days"@en ;
    ///     cis:description "La card permette l'accesso al Parco archeologico di Liternum per 2 giorni consecutivi"@it .
    ///
    /// validity:Parco_archeologico_di_Liternum_Card_Validity
    ///     a cis:Validity ;
    ///     rdfs:label "Two-day validity"@en ;
    ///     rdfs:label "Validità per due giorni"@it ;
    ///     cis:hasDuration Parco_archeologico_di_Liternum_Card_Validity_Duration .
    ///
    /// quantitativevalue:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2" ;
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Card">cis:Card</a>
    /// </summary>
    let Card = _prefixId.prefix "Card"
    /// <summary>
    ///   <para>dce:description : A catalogue is always associated with an individual of the class 'CulturalInstituteOrSite' (CIS) by means of the object property hasCatalogue (with domain CulturalInstituteOrSite and range Catalogue).
    ///
    /// The inverse property of hasCatalogue is isCatalogueOf and relates a catalogue to a CIS.
    ///
    /// An example in turtle is the following:
    ///
    /// &lt;pre&gt;
    /// catalogue:Catalogo_Generale_(autore)
    ///       a       cis:Catalogue ;
    ///       rdfs:label "Catalogo Generale (autore)" ;
    ///       cis:name "Catalogo Generale (autore)" ;
    ///       cis:isCatalogueOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:description "Catalogo Generale per autore - online"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasCatalogue catalogue:Catalogo_Generale_(autore) .
    /// &lt;/pre&gt;dce:description : Un catalogo è sempre associato a un individuo della classe "Istitute e luogo della cultura" attraverso la proprietà ha catalogo (che ha dominio CulturaInstituteOrSite e codominio Catalogue).
    ///
    /// La proprietà inversa di ha catalogo è "è catalogo di" e collega il catalogo all'istituto e luogo della cultura.
    ///
    /// Un esempio in turtle è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// catalogue:Catalogo_Generale_(autore)
    ///       a       cis:Catalogue ;
    ///       rdfs:label "Catalogo Generale (autore)" ;
    ///       cis:name "Catalogo Generale (autore)" ;
    ///       cis:isCatalogueOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:description "Catalogo Generale per autore - online"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasCatalogue catalogue:Catalogo_Generale_(autore) .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Cataloguerdfs:label : Catalogo</para>
    ///   <para>rdfs:comment : Concept used to represent the catalogue which describes the set of cultural heritage objects included in a Cultural Institute or Siterdfs:comment : Concetto utilizzato per rappresentare il catalogo che descrive l'insieme delle opere contenute in un istituto e luogo della cultura.</para>
    ///   <a href="http://dati.beniculturali.it/cis/Catalogue">cis:Catalogue</a>
    /// </summary>
    let Catalogue = _prefixId.prefix "Catalogue"
    /// <summary>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : non stabile</para>
    ///   <para>dce:description : An example of usage of the class cis:Cinema is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Cinema_Storico_Alberto_Sordi
    ///     a cis:CulturalInstituteOrSite, cis:Cinema ;
    ///     rdfs:label "Cinema storico Alberto Sordi" ;
    ///     cis:institutionalName "Cinema storico Alberto Sordi" ;
    ///     cis:ISILIdentifier "IT-EX0003" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:Cinema è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Cinema_Storico_Alberto_Sordi
    ///     a cis:CulturalInstituteOrSite, cis:Cinema ;
    ///     rdfs:label "Cinema storico Alberto Sordi" ;
    ///     cis:institutionalName "Cinema storico Alberto Sordi" ;
    ///     cis:ISILIdentifier "IT-EX0003" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un istituto e luogo della cultura di tipo Cinemardfs:comment : This class represents a cultural institute or site of type Cinema</para>
    ///   <para>rdfs:label : Cinemardfs:label : Cinema</para>
    ///   <a href="http://dati.beniculturali.it/cis/Cinema">cis:Cinema</a>
    /// </summary>
    let Cinema = _prefixId.prefix "Cinema"
    /// <summary>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:ClericalAdministrativeArea è il seguente
    ///
    /// &lt;pre&gt;
    ///
    /// caa:Diocesi_di_San_Marco_Argentano-Scalea
    ///     a cis:ClericalAdministrativeArea ;
    ///     rdfs:label "Diocese of San Marco Argentano-Scalea"@en ;
    ///     rdfs:label "Diocesi di San Marco Argentano-Scalea"@it ;
    ///     cis:toponym "Diocesi di San Marco Argentano-Scalea"@it ;
    ///     cis:toponym "Diocese of San Marco Argentano-Scalea"@en ;
    ///     cis:identifier "SMA-CS" .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:ClericalAdministrativeArea èil the following:
    ///
    /// &lt;pre&gt;
    ///
    /// caa:Diocesi_di_San_Marco_Argentano-Scalea
    ///     a cis:ClericalAdministrativeArea ;
    ///     rdfs:label "Diocese of San Marco Argentano-Scalea"@en ;
    ///     rdfs:label "Diocesi di San Marco Argentano-Scalea"@it ;
    ///     cis:toponym "Diocesi di San Marco Argentano-Scalea"@it ;
    ///     cis:toponym "Diocese of San Marco Argentano-Scalea"@en ;
    ///     cis:identifier "SMA-CS" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Area amministrativa ecclesiasticardfs:label : Clerical Administrative Area</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'area amministrativa territoriale ecclesiastica. Essa include le diocesi, parrocchie, ecc.rdfs:comment : This class represents the clerical administrative area. It can be used to represents Diocese, Parish, etc.</para>
    ///   <a href="http://dati.beniculturali.it/cis/ClericalAdministrativeArea">cis:ClericalAdministrativeArea</a>
    /// </summary>
    let ClericalAdministrativeArea = _prefixId.prefix "ClericalAdministrativeArea"
    /// <summary>
    ///   <para>dce:description : Individuals of this class represent cultural heritage included in a Cultural Institute or Site.
    ///
    /// A Cultural Institute or Site can be related to a collection by means of the object property hasCollection.
    ///
    /// Additionally, a collection can be composed of items that, in turn, can be individuals of the class 'Collection' or the class 'Cultural Heritage Object'.
    ///
    /// For example, this allows to assert that the Biblioteca Centrale di Roma has its own cultural heritage (e.g,, Patrimonio di Biblioteca Centrale di Roma). This cultural heritage is composed of different items, e.g., Archivio Capizucchi, Fondo Ceccarius, etc.
    ///
    /// This can be modelled by using turtle in the following way:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasCollection collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Collection ;
    ///       rdfs:label "Patrimonio di: Biblioteca nazionale centrale di Roma" ;
    ///       cis:hasMember collezioni:Archivio_Capizucchi, collezioni:Fondo_Ceccarius .
    ///
    ///
    /// collezioni:Archivio_Capizucchi
    ///       a       cis:Collection ;
    ///       rdfs:label "Archivio Capizucchi" ;
    ///       cis:isMemberOf collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:description "materiale documentario relativo alla famiglia Capizucchi"@it .
    ///
    ///
    /// collezioni:Fondo_Ceccarius
    ///       a       cis:Collection ;
    ///       rdfs:label "Fondo Ceccarius" ;
    ///       cis:isMemberOf collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:description "volumi, opuscoli, articoli e fotografie della biblioteca di G. Ceccarelli"@it .
    ///
    ///
    /// &lt;/pre&gt;dce:description : Individui di questa classe rappresentano il patrimonio culturale incluso in un Istituto e luogo della cultural.
    ///
    /// Un Istituto e luogo della cultural è relazionato a una collezione attraverso la proprietà "ha collezione".
    ///
    /// Inoltre, una collezione può essere composta da elementi che a loro volta possono essere individui della classe "Collezione" o della classe "Oggetto culturale".
    ///
    /// L'esempio sotto riportato permette di asserire che la Biblioteca Centrale di Roma ha il proprio patrimonio (e..g, Patrimonio della Biblioteca Centrale di Roma). Questo patrimonio culturale è formato da diversi elementi, e.g., Archivio Cpizucchi, Fondo Ceccarius, ecc.
    ///
    /// Nello specifico, questo può essere modellato in turtle come segue:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasCollection collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Collection ;
    ///       rdfs:label "Patrimonio di: Biblioteca nazionale centrale di Roma" ;
    ///       cis:hasMember collezioni:Archivio_Capizucchi, collezioni:Fondo_Ceccarius .
    ///
    ///
    /// collezioni:Archivio_Capizucchi
    ///       a       cis:Collection ;
    ///       rdfs:label "Archivio Capizucchi" ;
    ///       cis:isMemberOf collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:description "materiale documentario relativo alla famiglia Capizucchi"@it .
    ///
    ///
    /// collezioni:Fondo_Ceccarius
    ///       a       cis:Collection ;
    ///       rdfs:label "Fondo Ceccarius" ;
    ///       cis:isMemberOf collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:description "volumi, opuscoli, articoli e fotografie della biblioteca di G. Ceccarelli"@it .
    ///
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Collectionrdfs:label : Collezione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Rappresenta il patrimonio complessivo dell'Istituto e Luogo della Cultura o le singole collezioni di cui esso si compone.rdfs:comment : It represents the cultural heritage included in a Cultural Institute or Site or single collections that compone the cultural heritage</para>
    ///   <a href="http://dati.beniculturali.it/cis/Collection">cis:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : It represents a contact point which consists of phone numbers, e-mail addresses, web sites and their availability where applicable. We recommend the domain experts to specify better during the data production phase which type of contact point is in use (administrative contact point, tourist contact point, etc,).rdfs:comment : Rappresenta un punto di contatto (racchiude numeri di telefono, fax, indirizzi e-mail, siti web e relative disponibilità ove applicabili). Si raccomanda agli esperti di dominio di aver cura in fase di utilizzo di distinguere ulteriormente il tipo di punto di contatto (turistico, amministrativo, ecc).</para>
    ///   <para>dce:description : Gli individui delle classi Istituto e Luogo della Cultura, Evento e Sede possono avere dei punti di contatto, i.e., un numero di telefono, un indirizzo email, un fax, ecc. che sono utilizzati come riferimenti.
    ///
    /// Inoltre, un pubto di contatto potrebbe essere dichiarato come operativo in alcune fasce orarie.
    ///
    /// Queste informazioni sono modellate attraverso l'uso della proprietà ha punto di contatto il cui dominio può essere un Istituto e Luogo della Cultura, un Evento o una Sede e il suo range qualsiasi individuo della classe Punto di Contatto.
    ///
    /// Per esempio, il fatto che la Biblioteca Nazionale Centrale di Roma ha un numero di telefono di riferimento, un numero di fax, un email come pure una PEC può essere descritto nel seguente modo in turtle:
    ///
    ///
    /// &lt;pre&gt;
    ///
    /// contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:ContactPoint ;
    ///       rdfs:label "Contatti di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:available   openingHoursSpecification:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi ;
    ///       cis:hasCertifiedEmail
    ///               mailto:mbac-bnc-rm@mailcert.beniculturali.it ;
    ///       cis:hasEmail mailto:bnc-rm@beniculturali.it ;
    ///       cis:hasFax "+39064457635  " ;
    ///       cis:hasTelephone "+390649891" .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// &lt;/pre&gt;dce:description : Individuals of the classes CulturalInstituteOrSite, Event and Site may have a "contact point", i.e., a phone number, email address, fax, etc. that is used a reference contact.
    ///
    /// Additionally, a cantact point might be also declared to be operative with respect to specific hopening hours.
    ///
    /// This information is modelled into a knowledge base by using the object property hasContactPoint whose domain can be a CulturalInstituteOrSite, an Event or a Site, and its range is any indifvidual of the class ContactPoint.
    ///
    /// For example, the fact that the Biblioteca Nazionale Centrale of Rome has  reference phone and fax number and a email as well as certified email contacts can be described in the following way by using turtle:
    ///
    /// &lt;pre&gt;
    ///
    /// contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:ContactPoint ;
    ///       rdfs:label "Contatti di: Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:available   openingHoursSpecification:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi ;
    ///       cis:hasCertifiedEmail
    ///               mailto:mbac-bnc-rm@mailcert.beniculturali.it ;
    ///       cis:hasEmail mailto:bnc-rm@beniculturali.it ;
    ///       cis:hasFax "+39064457635  " ;
    ///       cis:hasTelephone "+390649891" .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Punto di Contattordfs:label : Contact Point</para>
    ///   <a href="http://dati.beniculturali.it/cis/ContactPoint">cis:ContactPoint</a>
    /// </summary>
    let ContactPoint = _prefixId.prefix "ContactPoint"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Creative Workrdfs:label : Lavoro Creativo</para>
    ///   <para>rdfs:comment : Concept used to represent all types of creative works such multimedia objects (audio, video, image files), bibliographic references, and different types of articles, that refer to and cite the Cultural Institute or Siterdfs:comment : Concetto utilizzato per rappresentare tutti quei materiali, multimediali (file audio, video), immagini), bibliografici, articoli di varia natura che si riferiscono e citano l'Istituto e Luogo della Cultura.</para>
    ///   <a href="http://dati.beniculturali.it/cis/CreativeWork">cis:CreativeWork</a>
    /// </summary>
    let CreativeWork = _prefixId.prefix "CreativeWork"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:CultReseachCenter is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// crc:Fondazione_Arnaldo_Pomodoro
    ///     a cis:CultReseachCenter ;
    ///     rdfs:label "Fondazione Arnaldo Pomodoro"@it ;
    ///     rdfs:label "Arnaldo Pomodoro Foundation"@en ;
    ///     cis:institutionalName "Fondazione Arnaldo Pomodoro"@it ;
    ///     cis:institutionalName "Arnaldo Pomodoro Foundation"@en ;
    ///     cis:ISILIdentifier "IT-EX0005" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:CultReseachCenter è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// crc:Fondazione_Arnaldo_Pomodoro
    ///     a cis:CultReseachCenter ;
    ///     rdfs:label "Fondazione Arnaldo Pomodoro"@it ;
    ///     rdfs:label "Arnaldo Pomodoro Foundation"@en ;
    ///     cis:institutionalName "Fondazione Arnaldo Pomodoro"@it ;
    ///     cis:institutionalName "Arnaldo Pomodoro Foundation"@en ;
    ///     cis:ISILIdentifier "IT-EX0005" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : This class represents cultural institutions that form so-called cultural research and promotion centers.rdfs:comment : Questa classe rappresenta istituti culturali che costituiscono centri di ricerca e di promozione culturale.</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <para>rdfs:label : Cultural Reseach and Promotion Centerrdfs:label : Centri di ricerca e promozione culturale</para>
    ///   <a href="http://dati.beniculturali.it/cis/CultReseachCenter">cis:CultReseachCenter</a>
    /// </summary>
    let CultReseachCenter = _prefixId.prefix "CultReseachCenter"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Cultural Entityrdfs:label : Entità culturale</para>
    ///   <para>rdfs:comment : Class that provides a generalization of three classes; that is , cultural institute or site, collection and cultural heritage object. It does not correspond to a concept used typically in the cultural domain but it is used in order to model properties and property restrictions that are common to all the these three classes. The class will never be directly instanziated.rdfs:comment : Classe che fornisce una generalizzazione per le tre classi di istituto e luogo della cultura,  collezione e oggetto culturale. Non corrisponde ad un concetto usato normalmente nel linguaggio del dominio, ma risponde all'esigenza di modellare proprietà e assiomi di property-restriction comuni ad ognuna di queste tre classi. La classe CulturalEntity non sarà mai istanziata direttamente</para>
    ///   <a href="http://dati.beniculturali.it/cis/CulturalEntity">cis:CulturalEntity</a>
    /// </summary>
    let CulturalEntity = _prefixId.prefix "CulturalEntity"
    /// <summary>
    ///   <para>rdfs:comment : It represents a cultural asset (even intagible) of the cultural heritage.rdfs:comment : Rappresenta un bene, materiale o immateriale, del patrimonio culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:CulturalHeritageObject iè il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// culturalheritageobject:Nascita_di_Venere
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Nascita di Venere"@it ;;
    ///     cis:name "Nascita di Venere"@it ;
    ///     cis:isInSite site:Palazzo_degli_uffizi .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:CulturalHeritageObject is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// culturalheritageobject:Nascita_di_Venere
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Nascita di Venere"@it ;;
    ///     cis:name "Nascita di Venere"@it ;
    ///     cis:isInSite site:Palazzo_degli_uffizi .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Cultural Heritage Objectrdfs:label : Oggetto Culturale</para>
    ///   <a href="http://dati.beniculturali.it/cis/CulturalHeritageObject">cis:CulturalHeritageObject</a>
    /// </summary>
    let CulturalHeritageObject = _prefixId.prefix "CulturalHeritageObject"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class 'Cultural Institute or Site' is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       rdfs:comment """La Biblioteca Nazionale Centrale di Roma fu inaugurata il 14 marzo 1876 in un'ala del
    ///       monumentale Palazzo cinquecentesco del Collegio Romano, sede dell'antica Bibliotheca Secreta o Major dei Gesuiti,
    ///       che costituì il nucleo originario della nuova istituzione, cui si aggiunsero i fondi manoscritti e a stampa di 69
    ///       biblioteche conventuali devolute al Regno d'Italia dopo la soppressione delle corporazioni religiose di Roma
    ///       nel 1873.
    /// 	  Cento anni dopo la Biblioteca venne trasferita nella nuova sede, all'interno della zona archeologica del
    /// 	  Castro Pretorio, fra la Città universitaria e la Stazione Termini, realizzata su progetto degli architetti Massimo
    ///       Castellazzi, Tullio Dell'Anese e Annibale Vitellozzi."""@it ;
    ///       rdfs:label "Biblioteca nazionale centrale"@it ;
    ///       cis:ISILIdentifier "IT-RM0267"^^xsd:string ;
    ///       cis:description """La Biblioteca Nazionale Centrale di Roma fu inaugurata il 14 marzo 1876 in un'ala del
    ///       monumentale Palazzo cinquecentesco del Collegio Romano, sede dell'antica Bibliotheca Secreta o Major dei Gesuiti,
    ///       che costituì il nucleo originario della nuova istituzione, cui si aggiunsero i fondi manoscritti e a stampa di 69
    ///       biblioteche conventuali devolute al Regno d'Italia dopo la soppressione delle corporazioni religiose di Roma
    ///       nel 1873. Cento anni dopo la Biblioteca venne trasferita nella nuova sede, all'interno della zona archeologica
    ///       del Castro Pretorio, fra la Città universitaria e la Stazione Termini, realizzata su progetto degli architetti
    ///       Massimo Castellazzi, Tullio Dell'Anese e Annibale Vitellozzi."""@it ;
    ///       cis:hasAccessCondition
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_mercoledi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_lunedi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_martedi&gt; , &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_venerdi&gt; ;
    ///       cis:hasCatalogue &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28topografico%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28titoli%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28autore%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28sistematico%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28soggetto%29&gt; ;
    ///       cis:hasCollection collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasNameInTime nameInTime:Biblioteca_Nazionale_Centrale ;
    ///       cis:hasSite site:Sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:institutionalName
    ///               "Biblioteca Nazionale Centrale"@it ;
    ///       cis:providesService service:Connessione_WI-FI , service:Visite_guidate , service:ala_per_la_didattica ;
    ///       owl:sameAs   &lt;http://it.dbpedia.org/resource/Biblioteca_Nazionale_Centrale_di_Roma&gt; ;
    ///       cis:institutionalName ""Biblioteca nazionale centrale"@it .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe "Istituto e Luogo della Cultura" è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       rdfs:comment "La Biblioteca Nazionale Centrale di Roma fu inaugurata il 14 marzo 1876 in un'ala del
    ///       monumentale Palazzo cinquecentesco del Collegio Romano, sede dell'antica Bibliotheca Secreta o Major dei Gesuiti,
    ///       che costituì il nucleo originario della nuova istituzione, cui si aggiunsero i fondi manoscritti e a stampa di 69
    ///       biblioteche conventuali devolute al Regno d'Italia dopo la soppressione delle corporazioni religiose di Roma
    ///       nel 1873.
    /// 	  Cento anni dopo la Biblioteca venne trasferita nella nuova sede, all'interno della zona archeologica del
    /// 	  Castro Pretorio, fra la Città universitaria e la Stazione Termini, realizzata su progetto degli architetti Massimo
    ///       Castellazzi, Tullio Dell'Anese e Annibale Vitellozzi."""@it ;
    ///       rdfs:label "Biblioteca nazionale centrale"@it ;
    ///       cis:ISILIdentifier "IT-RM0267"^^xsd:string ;
    ///       cis:description ""La Biblioteca Nazionale Centrale di Roma fu inaugurata il 14 marzo 1876 in un'ala del
    ///       monumentale Palazzo cinquecentesco del Collegio Romano, sede dell'antica Bibliotheca Secreta o Major dei Gesuiti,
    ///       che costituì il nucleo originario della nuova istituzione, cui si aggiunsero i fondi manoscritti e a stampa di 69
    ///       biblioteche conventuali devolute al Regno d'Italia dopo la soppressione delle corporazioni religiose di Roma
    ///       nel 1873. Cento anni dopo la Biblioteca venne trasferita nella nuova sede, all'interno della zona archeologica
    ///       del Castro Pretorio, fra la Città universitaria e la Stazione Termini, realizzata su progetto degli architetti
    ///       Massimo Castellazzi, Tullio Dell'Anese e Annibale Vitellozzi."""@it ;
    ///       cis:hasAccessCondition
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_mercoledi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_lunedi&gt; ,
    ///               &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_martedi&gt; , &lt;http://dati.beniculturali.it/cis/resource/OpeningHoursSpecification/Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_venerdi&gt; ;
    ///       cis:hasCatalogue &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28topografico%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28titoli%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28autore%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_%28sistematico%29&gt; , &lt;http://dati.beniculturali.it/cis/resource/Catalogue/Catalogo_Generale_(soggetto)&gt; ;
    ///       cis:hasCollection collezioni:Patrimonio_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasNameInTime nameInTime:Biblioteca_Nazionale_Centrale ;
    ///       cis:hasSite site:Sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:institutionalName
    ///               "Biblioteca Nazionale Centrale"@it ;
    ///       cis:providesService service:Connessione_WI-FI , service:Visite_guidate , service:ala_per_la_didattica ;
    ///       owl:sameAs &lt;http://it.dbpedia.org/resource/Biblioteca_Nazionale_Centrale_di_Roma&gt; ;
    ///        cis:institutionalName "Biblioteca nazionale centrale"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Istituto e Luogo Della Culturardfs:label : Cultural Institute or Site</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Sono istituti e luoghi della cultura i musei, le biblioteche e gli archivi, le aree e i parchi archeologici, i complessi monumentali. Gli istituti e luoghi e della cultura che appartengono a soggetti pubblici sono destinati alla pubblica fruizione ed espletano un servizio pubblico. Le strutture espositive e di consultazione nonché i luoghi della cultura che appartengono a soggetti privati e sono aperti al pubblico espletano un servizio privato di utilità sociale.rdfs:comment : The class Cultural Institute or Site represents museums, libraries, archive holders, archaeologic areas and parks, monumental areas. The cultural institutes of sites that are owned by public bodies are meant to offer public services. The cultural institutes or sites that are owned by private subjects, and are open to the public, offer a public and societal service.</para>
    ///   <a href="http://dati.beniculturali.it/cis/CulturalInstituteOrSite">cis:CulturalInstituteOrSite</a>
    /// </summary>
    let CulturalInstituteOrSite = _prefixId.prefix "CulturalInstituteOrSite"
    /// <summary>
    ///   <para>rdfs:label : Bene Paesaggisticordfs:label : Cultural Landscape Asset</para>
    ///   <para>rdfs:comment : This class represents a specific types of cultural institute or site, i.e., the cultural landscape asset.rdfs:comment : Questa classe rappresenta uno specifico tipo di istituto e luogo della cultura, i.e., il bene paessaggistico così come definito dall'art. 136 del Codice dei Beni Culturali.</para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>dce:description : An example of usage of the class cis:CulturalLandscapeAsset is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Costiera_Amalfitana
    ///  a cis:CulturalInstituteOrSite, cis:CulturalLandscapeAsset ;
    ///     rdfs:label "Costiera Amalfitana"@it ;
    ///     cis:institutionalName "Costiera Amalfitana"@en ;
    ///     cis:ISILIdentifier "IT-EX0004" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:CulturalLandscapeAsset è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Costiera_Amalfitana
    ///  a cis:CulturalInstituteOrSite, cis:CulturalLandscapeAsset ;
    ///     rdfs:label "Costiera Amalfitana"@it ;
    ///     cis:institutionalName "Costiera Amalfitana"@en ;
    ///     cis:ISILIdentifier "IT-EX0004" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/CulturalLandscapeAsset">cis:CulturalLandscapeAsset</a>
    /// </summary>
    let CulturalLandscapeAsset = _prefixId.prefix "CulturalLandscapeAsset"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la valuta per i biglietti di ingresso agli eventi o luoghi della cultura. Nel nostro dominio è associata alla descrizione del prezzo per i biglietti. Assume valori specifici (e.g., Euro).rdfs:comment : This class represents a currency. In our domain currency is typically associated with Price Specification for tickets, and assumes specific values (e.g., Euro).</para>
    ///   <para>rdfs:label : Currencyrdfs:label : Valuta</para>
    ///   <para>dce:description : Individuals of the this class represent currency instances (e.g., Euro, US Dollar, Pound, Australian Dollar, etc.); they are always associated with individuals of the class 'Price Specification'.
    ///
    /// This allows modelling Price Specification as a a quantified value, where the value is expressed as an integer and it is quantified in terms of a currency
    ///
    /// An example is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// priceSpecification:Under18&gt;
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo under 18 "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue
    ///               "5"^^xsd:float .
    ///
    /// cis:Euro a cis:Currency ;
    ///       rdfs:label "Euro"@en, "Euro"@it .
    ///
    /// &lt;/pre&gt;dce:description : Individui di questa classe rappresentano le istanze di valuta (e.g., euro, dollaro americano, sterlina, ecc) e sono sempre associati a individui della classe "Prezzo".
    ///
    /// Questo consente di modellare il prezzo come un valore quantitativo, dove il valore è espresso come un intero e è quantificato in termini di valura.
    ///
    /// Un esempio è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// priceSpecification:Under18&gt;
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo under 18 "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue
    ///               "5"^^xsd:float .
    ///
    /// cis:Euro a cis:Currency ;
    ///       rdfs:label "Euro"@en, "Euro"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Currency">cis:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:label : Giorno della settimana rdfs:label : Day of the Week</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <para>dce:description : An example of usage of the class cis:DayOfTheWeek is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ,
    ///       "Orari di apertura di Biblioteca nazionale centrale di Roma - giovedì"@it ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType addmissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    /// &lt;/pre&gt;
    ///
    /// For the complete example see the class cis:OpeningHoursSpecificationdce:description : Un esempio di utilizzo della classe cis:DayOfTheWeek è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ,
    ///       "Orari di apertura di Biblioteca nazionale centrale di Roma - giovedì"@it ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType addmissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    /// &lt;/pre&gt;
    ///
    /// Per un esempio più completo si veda la classe cis:OpeningHoursSpecification</para>
    ///   <para>rdfs:comment : This class represents the set of all the days of the week.rdfs:comment : Classe che rappresenta l'insieme dei giorni della settimana.</para>
    ///   <a href="http://dati.beniculturali.it/cis/DayOfWeek">cis:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : Equipmentrdfs:label : Attrezzatura</para>
    ///   <para>dce:description : An example of usage of the class cis:Equipment is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// equ:Photocopier
    ///     a cis:Equipment ;
    ///     rdfs:label "Photocopier"@en ;
    ///     rdfs:label "Fotocopiatrice"@it ;
    ///     cis:name "Photocopier"@en ;
    ///     cis:name "Fotocopiatrice"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale cis:makesAvailableEquipment equ:Photocopier .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:Equipment è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// equ:Photocopier
    ///     a cis:Equipment ;
    ///     rdfs:label "Photocopier"@en ;
    ///     rdfs:label "Fotocopiatrice"@it ;
    ///     cis:name "Photocopier"@en ;
    ///     cis:name "Fotocopiatrice"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale cis:makesAvailableEquipment equ:Photocopier .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Rappresenta l'attrezzatura resa disponibile dall'Istituto e luogo della cultura. Per esempio è un'attrezzatura un totem, ecc.rdfs:comment : It represents the equipment made available by the Cultural Institute or Site. For instance, the equipment can be a totem, etc.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/Equipment">cis:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    let Euro = _prefixId.prefix "Euro"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:Event è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// event:Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:Event;
    ///     cis:isHostedBy site:Museo_di_Capodimonte;
    ///     cis:name "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     rdfs:comment "Apre al pubblico al Museo di Capodimonte la mostra ‘Vincenzo Gemito, dal salotto
    ///     Minozzi al Museo di Capodimonte’,
    ///     organizzata dalla Soprintendenza speciale per il patrimonio storico" ;
    ///     cis:involves culturalheritageobject:Il_giocatore_di_carte ;
    ///     cis:hasSubEvent event:Vincenzo_Gemito_Il_Pescatorello ;
    ///     rdfs:label "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// event:Vincenzo_Gemito_Il_Pescatorello
    ///     a cis:Event ;
    ///     cis:isHostedBy site:Museo_di_Capodimonte;
    ///     rdfs:label "Vincenzo Gemito, esposizione de Il Pescatorello" ;
    ///     cis:name "Vincenzo Gemito, esposizione de Il Pescatorello&amp;apos" ;
    ///     cis:involves culturalheritageobject:Il_Pescatorello ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Intervallo di durata dell'evento 'Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte'";
    ///     cis:startDate "2014-11-28T00:00:00"^^xsd:dateTime;
    ///     cis:endDate "2015-07-16T00:00:00"^^xsd:dateTime .
    ///
    /// culturalheritageobject:Il_giocatore_di_carte
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Il giocatore di carte" ;;
    ///     cis:name "l giocatore di carte" ;
    ///     cis:isInSite site:Museo_di_Capodimonte .
    ///
    /// cultualheritageobject:Il_Pescatorello
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Il Pescatorello" ;
    ///     cis:name "Il Pescatorello&amp;quot" ;
    ///     cis:isInSite site:Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:Event is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// event:Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:Event;
    ///     cis:isHostedBy site:Museo_di_Capodimonte;
    ///     cis:name "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     rdfs:comment "Apre al pubblico al Museo di Capodimonte la mostra ‘Vincenzo Gemito, dal salotto Minozzi
    ///     al Museo di Capodimonte’,
    ///     organizzata dalla Soprintendenza speciale per il patrimonio storico" ;
    ///     cis:involves culturalheritageobject:Il_giocatore_di_carte ;
    ///     cis:hasSubEvent event:Vincenzo_Gemito_Il_Pescatorello ;
    ///     rdfs:label "Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte" ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// event:Vincenzo_Gemito_Il_Pescatorello
    ///     a cis:Event ;
    ///     cis:isHostedBy site:Museo_di_Capodimonte;
    ///     rdfs:label "Vincenzo Gemito, esposizione de Il Pescatorello" ;
    ///     cis:name "Vincenzo Gemito, esposizione de Il Pescatorello&amp;apos" ;
    ///     cis:involves culturalheritageobject:Il_Pescatorello ;
    ///     cis:takesPlaceDuring ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte .
    ///
    /// ti:Durata_di_Vincenzo_Gemito_dal_salotto_Minozzi_al_Museo_di_Capodimonte
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Intervallo di durata dell'evento 'Vincenzo Gemito, dal salotto Minozzi al Museo di Capodimonte'" ;
    ///     cis:startDate "2014-11-28T00:00:00"^^xsd:dateTime;
    ///     cis:endDate "2015-07-16T00:00:00"^^xsd:dateTime .
    ///
    /// culturalheritageobject:Il_giocatore_di_carte
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Il giocatore di carte" ;;
    ///     cis:name "l giocatore di carte" ;
    ///     cis:isInSite site:Museo_di_Capodimonte .
    ///
    /// cultualheritageobject:Il_Pescatorello
    ///     a cis:CulturalHeritageObject ;
    ///     rdfs:label "Il Pescatorello" ;
    ///     cis:name "Il Pescatorello&amp;quot" ;
    ///     cis:isInSite site:Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : it represents an event that typically is related to the cultural domainrdfs:comment : Rappresenta un evento culturale.</para>
    ///   <para>rdfs:label : Eventrdfs:label : Evento</para>
    ///   <a href="http://dati.beniculturali.it/cis/Event">cis:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let Friday = _prefixId.prefix "Friday"
    /// <summary>
    ///   <para>rdfs:comment : Rappresenta una caratteristica  geografica. Può essere usata per rappresentare un comune, o un'area che ricomprendere diverse aree ammistrative.rdfs:comment : It represents a geographical feature. It can be used to model a municipality or an area across different administrative areas.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Area Geograficardfs:label : Geographical Area</para>
    ///   <para>dce:description : Questa classe consente di descrivere un'area geografica.
    ///
    /// Le aree geografiche sono semrep associate a individui della classe Sede attraverso la proprietà ha locazione geografica (dominio Sede e codonimio Area Geografica).
    ///
    /// Un area geografica è descritta dall'insieme di individui della classe geometria. Un individuo della classe geometria è descritto utilizzando le coordinate del sistema di riferimento come per esempio WGS84. E? univocamente identificata da latitudine e longitudine. Questo significa che un area geografica può essere un punto, una linea o un poligono.
    ///
    /// Per esempio, il seguente frammento di codice in turtle fornisce rappresenta un area geografica corrispondente alla sede della Biblioteca Centrale di Roma.
    ///
    /// &lt;pre&gt;
    ///
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       cis:hasGeographicalLocation
    ///               geographicalArea:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:name "Biblioteca nazionale centrale di Roma"@it .
    ///
    /// geographicalArea:Comune_di_Roma
    ///       a       cis:GeographicalArea ;
    ///       rdfs:label "Comune di Roma"@it ;
    ///       cis:toponym "Roma" ;
    ///       owl:sameAs      &lt;http://spcdata.digitpa.gov.it/Comune/H501&gt; , &lt;http://datiopen.istat.it/odi/risorsa/territorio/comuni/Roma_58091&gt; ;
    ///       hasGeometry geometry:Comune_di_Roma .
    ///
    /// geometry:Comune_di_Roma
    ///       a       cis:Geometry ;
    ///       geo:lat "41.906784" ;
    ///       geo:long "12.504962" .
    ///
    /// &lt;/pre&gt;dce:description : This class allows describing a geographical area.
    /// Geographical areas are always associated with individuals of the class 'Site' by means of the object property hasGeographicalLocation (domain Site and range 'Geographical Area').
    ///
    /// A geographical area is described by a set of individuals of the class Geometry. A individual of the class Geometry is described by using a coordinate system related to Earth such as WGS84. It is univocally identified by lat/long. This means that a geographical area can be a point, a line or a polygon.
    ///
    /// For example, the following snippet provides a turtle model that represents a Geographical Area corresponding to the Site of the Biblioteca Centrale di Roma.
    ///
    /// &lt;pre&gt;
    ///
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       cis:hasGeographicalLocation
    ///               geographicalArea:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:name "Biblioteca nazionale centrale di Roma"@it .
    ///
    /// geographicalArea:Comune_di_Roma
    ///       a       cis:GeographicalArea ;
    ///       rdfs:label "Comune di Roma"@it ;
    ///       cis:toponym "Roma" ;
    ///       owl:sameAs      &lt;http://spcdata.digitpa.gov.it/Comune/H501&gt; , &lt;http://datiopen.istat.it/odi/risorsa/territorio/comuni/Roma_58091&gt; ;
    ///       hasGeometry geometry:Comune_di_Roma .
    ///
    /// geometry:Comune_di_Roma
    ///       a       cis:Geometry ;
    ///       geo:lat "41.906784" ;
    ///       geo:long "12.504962" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/GeographicalFeature">cis:GeographicalFeature</a>
    /// </summary>
    let GeographicalFeature = _prefixId.prefix "GeographicalFeature"
    /// <summary>
    ///   <para>rdfs:label : Geometriardfs:label : Geometry</para>
    ///   <para>rdfs:comment : It represents a geometry which is typically described by using a coordinate system related to Earth such as WGS84. It is univocally identified by lat/longrdfs:comment : Rappresenta una geometria tipicamente descritto utilizzando un sistema di coordinate geografiche come per esempio WGS84. Univocamente identificato da Lat/Long</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : An example of usage of the class cis:Geometry is the following:
    /// &lt;pre&gt;
    ///
    /// geometry:Museo_di_Capodimonte_Geometry
    ///       a       cis:Geometry ;
    ///       rdfs:label "Coordinate geografiche della sede di Museo di Capodimonte"@it;
    ///       cis:hasLat "40.867424" ;
    ///       cis:geometryType "Point";
    ///       cis:geoMethodology "Satellite data georeferentiation" ;
    ///       cis:hasLong "14.249192".
    ///
    /// &lt;/pre&gt;
    ///
    /// For a complete example refer to the class cis:GeographicalFeaturedce:description : Un esempio di utilizzo della classe cis:Geomery è il seguente:
    /// &lt;pre&gt;
    ///
    /// geometry:Museo_di_Capodimonte_Geometry
    ///       a       cis:Geometry ;
    ///       rdfs:label "Coordinate geografiche della sede di Museo di Capodimonte"@it;
    ///       cis:hasLat "40.867424" ;
    ///       cis:geometryType "Point";
    ///       cis:geoMethodology "Satellite data georeferentiation" ;
    ///       cis:hasLong "14.249192".
    ///
    /// &lt;/pre&gt;
    ///
    /// Per un esempio complete si veda la classe cis:GeographicalFeature</para>
    ///   <a href="http://dati.beniculturali.it/cis/Geometry">cis:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"

    /// <summary>
    ///   <para>rdfs:comment : This class represents an administrative geographical area that is typically managed by a public body. It can be a Region, a Municipality, a Province, a sub-municipality area, etc.rdfs:comment : Questa classe rappresenta un'area amministrativa territoriale statale gestita tipicamente da un organismo pubblico. Essa può essere una Regione, una Provincia, un Comune, un area sub comunale, etc.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Area Amministrativa statalerdfs:label : Governamental Administrative Area</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:GovernamentalAdministrativeArea è il seguente:
    /// &lt;pre&gt;
    ///
    /// gaa:Lazio
    ///     a cis:GovernamentalAdministrativeArea ;
    ///     rdfs:"Lazio";;
    ///     cis:toponym "Lazio";;
    ///     cis:hasISTATCode "12" .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:GovernamentalAdministrativeArea is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// gaa:Lazio
    ///     a cis:GovernamentalAdministrativeArea ;
    ///     rdfs:label "Lazio" ;
    ///     cis:toponym "Lazio" ;
    ///     cis:hasISTATCode "12" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/GovernamentalAdministrativeArea">cis:GovernamentalAdministrativeArea</a>
    /// </summary>
    let GovernamentalAdministrativeArea =
        _prefixId.prefix "GovernamentalAdministrativeArea"

    /// <summary>
    ///   <para>rdfs:comment : This class represents a specific tyep of cultural institute or site, i.e.,  Holder of Archiverdfs:comment : Questa classe rappresenta una specifica tipologia di istituto e luogo della cultura, i.e., Archivio</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:HolderOfArchive è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Archivio_di_Stato_di_Oristano
    ///     a cis:CulturalInstituteOrSite, cis:HolderOfArchive ;
    ///     rdfs:label "Archivio di Stato di Oristano" ;
    ///     cis:institutionalName "Archivio di Stato di Oristano" ;
    ///     cis:ISILIdentifier "IT-EX0006" .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:HolderOfArchive is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Archivio_di_Stato_di_Oristano
    ///     a cis:CulturalInstituteOrSite, cis:HolderOfArchive ;
    ///     rdfs:label "Archivio di Stato di Oristano" ;
    ///     cis:institutionalName "Archivio di Stato di Oristano" ;
    ///     cis:ISILIdentifier "IT-EX0006" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Holder of Archivesrdfs:label : Conservatore di archivi</para>
    ///   <a href="http://dati.beniculturali.it/cis/HolderOfArchive">cis:HolderOfArchive</a>
    /// </summary>
    let HolderOfArchive = _prefixId.prefix "HolderOfArchive"
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>owl:versionInfo : Stableowl:versionInfo : Stabile</para>
    ///   <para>rdfs:label : Identificativo ISILrdfs:label : ISIL identifier</para>
    ///   <para>rdfs:comment : This property is used to define the unique identifier of the cultural institute or site (i.e., the ISIL - International Standard Identifier for Libriaries and Related Organization - code). Subproperty of identifier.rdfs:comment : Questa proprietà è utilizzata per rappresentare l'identificativo univoco dell'Istituto e luogo della cultura, i.e., il codice ISIL (International Standard identifier for Libraries and Related Organization). Sotto proprietà di identificativo.</para>
    ///   <a href="http://dati.beniculturali.it/cis/ISILIdentifier">cis:ISILIdentifier</a>
    /// </summary>
    let ISILIdentifier = _prefixId.prefix "ISILIdentifier"
    /// <summary>
    ///   <para>rdfs:label : Image Objectrdfs:label : Oggetto immagine</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Concept used to represent an image file.rdfs:comment : Concetto utilizzato per rappresentare un file immagine.</para>
    ///   <para>dce:description : Un esempio dell'utilizzo della classe cis:ImageObject è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// image:Poster_Evento_Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:ImageObject , cis:CreativeWork ;
    ///     rdfs:label "Poster of the event 'Vincenzo Gemito al Museo di Capodimonte'"@en;
    ///     rdfs:label "Poster dell'evento 'Vincenzo Gemito al Museo di Capodimonte'"@it;
    ///     cis:url http://www.example.com/Image/Poster_Evento_Vincenzo_Gemito_al_Museo_di_Capodimonte.png ;
    ///     cis:isAbout event:Vincenzo_Gemito_al_Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;dce:description : An example of the usage of the class cis:ImageObject is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// image:Poster_Evento_Vincenzo_Gemito_al_Museo_di_Capodimonte
    ///     a cis:ImageObject , cis:CreativeWork ;
    ///     rdfs:label "Poster of the event 'Vincenzo Gemito al Museo di Capodimonte'"@en;
    ///     rdfs:label "Poster dell'evento 'Vincenzo Gemito al Museo di Capodimonte'"@it;
    ///     cis:url http://www.example.com/Image/Poster_Evento_Vincenzo_Gemito_al_Museo_di_Capodimonte.png ;
    ///     cis:isAbout event:Vincenzo_Gemito_al_Museo_di_Capodimonte .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/ImageObject">cis:ImageObject</a>
    /// </summary>
    let ImageObject = _prefixId.prefix "ImageObject"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : It represents a specific type of Cultural Institute or Site; that is, Libraryrdfs:comment : Rappresenta uno specifico tipo di Istituto e Luogo della Cultura, ovvero Biblioteca.</para>
    ///   <para>rdfs:label : Libraryrdfs:label : Biblioteca</para>
    ///   <a href="http://dati.beniculturali.it/cis/Library">cis:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : Unità di misurardfs:label : Measurement Unit</para>
    ///   <para>dce:description : Individuals of this class expresses a definite magnitude of physical quantities.
    ///
    /// For example it is possible to define a quantity for time (e.g., the second), space (e.g., the metre), or temperature (the celcius degree).
    ///
    /// A measurement unit is always related to individuals of the class 'Quantitative Value' by means of the object property hasMeasurementUnit.
    ///
    /// This allows representing as RDF assertions like 'the validity of the offer is of 7 days', e.g.,
    ///
    /// &lt;pre&gt;
    ///
    /// quantitativeValue:BaseOfferDuration
    ///       a       cis:QuantitativeValue ;
    ///       rdfs:label "Durata di validità dell'offerta base della biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasMeasurementUnit
    ///               cis:Day ;
    ///       cis:hasValue "7"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit
    ///
    /// &lt;/pre&gt;dce:description : Individui di questa classe rappresentano un insieme definito di quantità fisiche.
    ///
    /// Per esempio, è possibile definire una quantità per il tempo (e.g., il secondo), per lo spazio (e.g., metro) o per la temperatura (gradi celcius)
    ///
    /// Un'unità di misura è sempre collegata agli individui della classe "Valore Quantitativo" attraverso la proprietà "ha unità di misura".
    ///
    /// Questo consente di rappresentare in RDF asserzioni come " la validità dell'offerta è di 7 giorni".
    ///
    /// Per esempio:
    ///
    /// &lt;pre&gt;
    ///
    /// quantitativeValue:BaseOfferDuration
    ///       a       cis:QuantitativeValue ;
    ///       rdfs:label "Durata di validità dell'offerta base della biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasMeasurementUnit
    ///               cis:Day ;
    ///       cis:hasValue "7"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Classe che rappresenta un'unità di misurardfs:comment : Class that represents a measurement unit</para>
    ///   <a href="http://dati.beniculturali.it/cis/MeasurementUnit">cis:MeasurementUnit</a>
    /// </summary>
    let MeasurementUnit = _prefixId.prefix "MeasurementUnit"
    let Monday = _prefixId.prefix "Monday"
    /// <summary>
    ///   <para>rdfs:label : Complesso Monumentalerdfs:label : Monumental Area or Complex</para>
    ///   <para>rdfs:comment : It represents a specific type of Cultural Institute or Site; that is, Monumental Areardfs:comment : Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Complesso Monumentale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : An example of usage of the class cis:MonumentalArea is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:COMPLESSO_MONUMENTALE_DI_VICOPISANO_ROCCA_DEL_BRUNELLESCHI_E_PALAZZO_PRETORIO
    ///     a cis:CulturalInstituteOrSite, cis:MonumentalArea ;
    ///     rdfs:label "COMPLESSO MONUMENTALE DI VICOPISANO: ROCCA DEL BRUNELLESCHI E PALAZZO PRETORIO" ;
    ///     cis:institutionalName "COMPLESSO MONUMENTALE DI VICOPISANO: ROCCA DEL BRUNELLESCHI E PALAZZO PRETORIOi" ;
    ///     cis:ISILIdentifier "IT-EX0007" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:MonumentalArea è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:COMPLESSO_MONUMENTALE_DI_VICOPISANO_ROCCA_DEL_BRUNELLESCHI_E_PALAZZO_PRETORIO
    ///     a cis:CulturalInstituteOrSite, cis:MonumentalArea ;
    ///     rdfs:label "COMPLESSO MONUMENTALE DI VICOPISANO: ROCCA DEL BRUNELLESCHI E PALAZZO PRETORIO" ;
    ///     cis:institutionalName "COMPLESSO MONUMENTALE DI VICOPISANO: ROCCA DEL BRUNELLESCHI E PALAZZO PRETORIOi" ;
    ///     cis:ISILIdentifier "IT-EX0007" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/MonumentalArea">cis:MonumentalArea</a>
    /// </summary>
    let MonumentalArea = _prefixId.prefix "MonumentalArea"
    /// <summary>
    ///   <para>rdfs:comment : It represents a specific type of Cultural Institute or Site; that is, Museumrdfs:comment : Rappresenta uno specifico tipo di istituto e luogo della cultura ovvero museo.</para>
    ///   <para>rdfs:label : Museumrdfs:label : Museo</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : An example of usage of the class cis:Museum is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte"; ;
    ///     cis:institutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:Museum è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte"; ;
    ///     cis:institutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Museum">cis:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:NameInTime is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte" ;
    ///     cis:institutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" ;
    ///     cis:hasNameInTime nit:Museo_di_Capodimonte ;
    ///     cis:hasSite site:Museo_di_Capodimonte .
    ///
    /// nit:Museo_di_Capodimonte
    ///     a cis:NameInTime ;
    ///     rdfs:label "Denominazione nel tempo 'Museo di Capodimonte'"@it ;
    ///     cis:institutionalName "Museo di Capodimonte"@it ;
    ///     cis:altLabel "Museo Nazionale di Capodimonte"@it ;
    ///     cis:isValidDuring ti:Intervallo_di_tempo_per_denominazione_nel_tempo_Museo_di_Capodimonte  .
    ///
    /// ti:Intervallo_di_tempo_per_denominazione_nel_tempo_Museo_di_Capodimonte
    ///     a cis:TimeInterval ;
    ///     cis:startDate "1957" .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:NameInTime è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte" ;
    ///     cis:institutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" ;
    ///     cis:hasNameInTime nit:Museo_di_Capodimonte ;
    ///     cis:hasSite site:Museo_di_Capodimonte .
    ///
    /// nit:Museo_di_Capodimonte
    ///     a cis:NameInTime ;
    ///     rdfs:label "Denominazione nel tempo 'Museo di Capodimonte'"@it ;
    ///     cis:institutionalName "Museo di Capodimonte"@it ;
    ///     cis:altLabel "Museo Nazionale di Capodimonte"@it ;
    ///     cis:isValidDuring ti:Intervallo_di_tempo_per_denominazione_nel_tempo_Museo_di_Capodimonte  .
    ///
    /// ti:Intervallo_di_tempo_per_denominazione_nel_tempo_Museo_di_Capodimonte
    ///     a cis:TimeInterval ;
    ///     cis:startDate "1957" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Permette di rappresentare una situazione relativa alla denominazione di un istituto e luogo della cultura che cambia nel tempo.rdfs:comment : Permits to represent a situation in which a name of the Cultural Institute or Site change in time.</para>
    ///   <para>rdfs:label : Nome Nel Tempordfs:label : Name in Time</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/NameInTime">cis:NameInTime</a>
    /// </summary>
    let NameInTime = _prefixId.prefix "NameInTime"
    /// <summary>
    ///   <para>rdfs:label : News Articlerdfs:label :  Articolo</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Concept used to represent a news article.rdfs:comment : Concetto utilizzato per rappresentare un articolo</para>
    ///   <a href="http://dati.beniculturali.it/cis/NewsArticle">cis:NewsArticle</a>
    /// </summary>
    let NewsArticle = _prefixId.prefix "NewsArticle"
    /// <summary>
    ///   <para>dce:description : Any fare is expressed within the ontology by using instances of the class Offer.
    ///
    /// It is possible to specify:
    ///  * the type of user to whom the offer is applicable  (cf. object property cis:hasEligibleUser);
    ///  * the information about the price (cf. object property hasPriceSpecification);
    ///  * the information about the temporal validity of the offer (cf. object property hasValidity);
    ///  * the association with a ticket (cf. object property includes).
    ///
    /// The following turtle example exemplifies the base offer of the Biblioteca Nazionale Centrale di Roma.
    ///
    /// &lt;pre&gt;
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer "@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification
    ///               priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// &lt;/pre&gt;dce:description : Qualsiasi tariffa è rappresentata nell'ontologia attraverso istanze della classe "Offerta".
    ///
    /// E' possibile specificare:
    ///  * il tipo di utente al quale l'offerta è applicabile (con la proprietà has utente eligibile)
    ///  * l'informazione sul prezzo (con la proprietà ha prezzo)
    ///  * l'informazione sulla validità temporale dell'offerta (con la proprietà ha validità)
    ///  + l'associazione con il biglietto (con la proprietà "include").
    ///
    /// Il seguente codice turtle fornisce un esempio di offerta base per la Biblioteca Nazionale Centrale di Roma
    ///
    /// &lt;pre&gt;
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer "@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification
    ///               priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Offertardfs:label : Offer</para>
    ///   <para>rdfs:comment : Concetto utilizzato per rappresentare  offerte (riduzioni per specifiche categorie di utenti o importo intero) relative ai biglietti d'ingresso per un istituto e luogo della cultura o per un evento.rdfs:comment : It represents an offer (reduction  for specific types of users or base price) related to the entrance ticket for the Cultural Institute or Site or for the Event.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/Offer">cis:Offer</a>
    /// </summary>
    let Offer = _prefixId.prefix "Offer"
    let OneDay = _prefixId.prefix "OneDay"
    let OneWeek = _prefixId.prefix "OneWeek"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : Individui di questa classe specificano particolari condizioni di accesso ai luoghi della cultura o eventi, i.e., gli orari di apertura dei luoghi o degli eventi.
    ///
    /// Gli orari di apertura sono espressi in termini di
    ///  * orario apertura (con la proprietà "apre")
    ///  * orario di chiusura (con la proprietà "chiude")
    ///  * il giorno della settimana a cui l'orario di apertura si riferisce (con la proprietà ha giorno della settimana)
    ///  * il tipo di apertura (settimanale, mensile, giornaliera, ecc) (con la proprietà ha tipo di apertura)
    ///
    /// Un esempio in turle è il seguente:
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasAccessCondition            orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///
    /// orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ,
    ///       "Orari di apertura di Biblioteca nazionale centrale di Roma - giovedì"@it ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType          addmissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    /// admissionType:Tipo_di_apertura_al_pubblico
    ///       a       cis:AdmissionType ;
    ///       cis:description "daily" .
    ///
    /// &lt;/pre&gt;dce:description : Individuals of this class specify a particula access conditions, i.e., the opening hours of a 'Cultural Institute or Site' or an 'Event'.
    ///
    /// Opening hours are represented in terms of:
    ///    * opening time (cf. property opens);
    ///    * closing time (cf. property closes);
    ///    * the day of the week that the opening specification refers to (cf. property hasDayOfWeek);
    ///    * the admission type, e.g. weekly, monthly, daily, etc (cf. property hasAdmmissionType).
    ///
    /// An example in turtle is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasAccessCondition            orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///
    /// orari:Orari_di_apertura_di_Biblioteca_nazionale_centrale_di_Roma_giovedi
    ///       a       cis:OpeningHoursSpecification ;
    ///       rdfs:label "Opening Hours of Biblioteca nazionale centrale di Roma - thursday"@en ,
    ///       "Orari di apertura di Biblioteca nazionale centrale di Roma - giovedì"@it ;
    ///       cis:closes "19:00:00"^^xsd:time ;
    ///       cis:hasAdmissionType          addmissionType:Tipo_di_apertura_al_pubblico ;
    ///       cis:hasDayOfWeek cis:Thursday ;
    ///       cis:opens "08:30:00"^^xsd:time .
    ///
    /// admissionType:Tipo_di_apertura_al_pubblico
    ///       a       cis:AdmissionType ;
    ///       cis:description "daily" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Opening Hours Specificationrdfs:label : Orari di Apertura</para>
    ///   <para>rdfs:comment : Rappresenta gli orari di aperturardfs:comment : It represents the opening hours specification </para>
    ///   <a href="http://dati.beniculturali.it/cis/OpeningHoursSpecification">cis:OpeningHoursSpecification</a>
    /// </summary>
    let OpeningHoursSpecification = _prefixId.prefix "OpeningHoursSpecification"
    /// <summary>
    ///   <para>rdfs:label : Prezzordfs:label : Price Specification</para>
    ///   <para>dce:description : Un prezzo fornisce informazioni sul costo di un offerta necessaria per entrare in un luogo della cultura o accedere a un evento.
    ///
    /// E' associata a una valuta (e.g., euro) e al valore della valuta (quantità, e.g., 5).
    ///
    /// Il seguente esempio in turle mostra la specifica del prezzo per l'offerta base per entrare alla Biblioteca Nazionale Centrale di Roma
    ///
    /// &lt;pre&gt;
    ///
    /// priceSpecification:Under18
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo per i ragazzi sotto i 18 anni "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue
    ///               "5"^^xsd:float .
    ///
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer "@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification
    ///               priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    ///
    /// &lt;/pre&gt;dce:description : A price specification provides the information about the cost of an offer for entering a Cultural Institute or Site.
    ///
    /// It is associated to a currency (e.g., Euro) and a currency value (i.e., a quantity, e.g., 5).
    ///
    /// The following turtle provides an example about the price specification of the base offer for entering the Biblioteca Nazionale Centrale di Roma.
    ///
    /// &lt;pre&gt;
    ///
    /// priceSpecification:Under18
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo under 18 "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue
    ///               "5"^^xsd:float .
    ///
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer "@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification
    ///               priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Rappresenta la specifica del prezzo del biglietto.rdfs:comment : It represents the price specification of the ticket</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/PriceSpecification">cis:PriceSpecification</a>
    /// </summary>
    let PriceSpecification = _prefixId.prefix "PriceSpecification"
    /// <summary>
    ///   <para>rdfs:comment : It represents a Project the Cultural Institute and Site can be involved in.rdfs:comment : Rappresenta un progetto nel quale l'istitutto della Cultura può essere coinvolto.</para>
    ///   <para>dce:description : Un esempio di uso della classe cis:Project è il seguente:
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte" ;
    ///     cis:InstitutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" ;
    ///     cis:isInvolvedInProject project:ProgettoEsempio ;
    ///     cis:hasSite site:Museo_di_Capodimonte .
    ///
    /// project:ProgettoEsempio
    ///     a cis:Project;
    ///     rdfs:label "Example Project"@en ;
    ///     rdfs:label "Progetto di Esempio";@it;
    ///     cis:name "Example Project";@en ;
    ///     cis:name "Progetto di Esempio"@it;
    ///     cis:hasWebSite http://www.example-project.com/ .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:Project is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_di_Capodimonte
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo di Capodimonte" ;
    ///     cis:InstitutionalName "Museo di Capodimonte" ;
    ///     cis:ISILIdentifier "IT-EX0008" ;
    ///     cis:isInvolvedInProject project:ProgettoEsempio ;
    ///     cis:hasSite site:Museo_di_Capodimonte .
    ///
    /// project:ProgettoEsempio
    ///     a cis:Project;
    ///     rdfs:label "Example Project"@en ;
    ///     rdfs:label "Progetto di Esempio";@it;
    ///     cis:name "Example Project";@en ;
    ///     cis:name "Progetto di Esempio"@it;
    ///     cis:hasWebSite http://www.example-project.com/ .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Progettordfs:label : Project</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/Project">cis:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <para>rdfs:label : Quantitative Valuerdfs:label : Valore quantitativo</para>
    ///   <para>dce:description : An example of usage of the class cis:QuantitativeValue is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// qv:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2";
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:QuantitativeValue è il seguente:
    /// &lt;pre&gt;
    ///
    /// qv:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2";
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// cis:Day a cis:MeasurementUnit .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Class that represents a quantitative value.rdfs:comment : Classe che rappresenta un valore quantitativo</para>
    ///   <a href="http://dati.beniculturali.it/cis/QuantitativeValue">cis:QuantitativeValue</a>
    /// </summary>
    let QuantitativeValue = _prefixId.prefix "QuantitativeValue"
    let QuantityOfAdmissions = _prefixId.prefix "QuantityOfAdmissions"
    /// <summary>
    ///   <para>rdfs:label : Ruolordfs:label : Role</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:Role è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// role:Director
    ///     a cis:Role ;
    ///     rdfs:label "Director"@en ;
    ///     rdfs:label "Direttore"@it ;
    ///     cis:name "Direttore"@it ;
    ///     cis:name ";Director"@en .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:Role is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// role:Director
    ///     a cis:Role ;
    ///     rdfs:label "Director"@en ;
    ///     rdfs:label "Direttore"@it ;
    ///     cis:name "Direttore"@it ;
    ///     cis:name ";Director"@en .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Rappresenta un ruolo. Esso può essere definito facendo riferimento a un vocabolario controlalto. Esempi di ruoli possono essere: ente genstore, ente competente per la tutela, proprietario, direttore, ecc.rdfs:comment : It represents a role. It can be modelled using a controlled vocabulary. Examples of roles include: ManagingAuthority, AccountableAuthority, Owner, Director, etc.</para>
    ///   <a href="http://dati.beniculturali.it/cis/Role">cis:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Ruolo Nel Tempordfs:label : Role in Time</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:RoleInTime è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// agent:Andrea_De_Pasquale
    ///     a cis:Agent ;
    ///     rdfs:label "Andrea De Pasquale"; ;
    ///     cis:name "Andrea De Pasquale" ;
    ///     cis:reportsTo agent:Soprintendenza ;
    ///     cis:holdsRoleInTime roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale .
    ///
    /// roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale
    ///     a cis:RoleInTime ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale Centrale"@en ;
    ///     cis:atTime timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231 ;
    ///     cis:roleFor cissite:Biblioteca_nazionale_centrale ;
    ///     cis:withRole role:Director .
    ///
    /// timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale from 1-1-2013 through 31-12-2016"@en ;
    ///     cis:startDate  "2013-01-01"^^xsd:dateTime ;
    ///     cis:endDate "2016-12-31"^^xsd:dateTime .
    ///
    /// role:Director
    ///     a cis:Role ;
    ///     rdfs:label "Director"@en ;
    ///     rdfs:label "Direttore"@it ;
    ///     cis:name "Direttore"@it ;
    ///     cis:name ";Director"@en .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:RoleInTime is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// agent:Andrea_De_Pasquale
    ///     a cis:Agent ;
    ///     rdfs:label "Andrea De Pasquale"; ;
    ///     cis:name "Andrea De Pasquale" ;
    ///     cis:reportsTo agent:Soprintendenza ;
    ///     cis:holdsRoleInTime roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale .
    ///
    /// roleInTime:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale
    ///     a cis:RoleInTime ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale Centrale"@en ;
    ///     cis:atTime timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231 ;
    ///     cis:roleFor cissite:Biblioteca_nazionale_centrale ;
    ///     cis:withRole role:Director .
    ///
    /// timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale from 1-1-2013 through 31-12-2016"@en ;
    ///     cis:startDate  "2013-01-01"^^xsd:dateTime ;
    ///     cis:endDate "2016-12-31"^^xsd:dateTime .
    ///
    /// role:Director
    ///     a cis:Role ;
    ///     rdfs:label "Director"@en ;
    ///     rdfs:label "Direttore"@it ;
    ///     cis:name "Direttore"@it ;
    ///     cis:name ";Director"@en .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Concetto utilizzato per rappresentare una situazione relativa a un ruolo che evolve nel tempo. Nel caso specifico il ruolo è esercitato da un agente su un istituto e luogo della cultura.rdfs:comment : Concept used to represent a situation in which a role can vary in time. In this specific domain, it is the role of an agent played on a Cultural Institute or Site.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/RoleInTime">cis:RoleInTime</a>
    /// </summary>
    let RoleInTime = _prefixId.prefix "RoleInTime"
    let Saturday = _prefixId.prefix "Saturday"
    /// <summary>
    ///   <para>rdfs:label : Serviziordfs:label : Service</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>dce:description : Un istituto della cultura può offrire una serie di servizi (e.g., Wi-Fi, accesso ai disabili, caffetteria, ecc.).
    ///
    /// Questi servizi sono rappresentati da individui della classe "Servizio" e sono in relazione con l'istituto della cultural attraverso la proprietà "fornisce servizio".
    ///
    /// Il seguente esempio mostra in turtle l'uso della classe servizio:
    ///
    /// &lt;pre&gt;
    ///
    /// service:Caffetteria
    ///       a       cis:Service ;
    ///       cis:name "Caffetteria" .
    ///
    ///
    /// service:Connessione_WI-FI
    ///       a       cis:Service ;
    ///       cis:name "Connessione WI-FI" .
    ///
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:providesService service:Caffetteria, service:Connessione_WI-FI.
    ///
    /// &lt;/pre&gt;dce:description : A Cultural Institute or Site (CIS) might offer a variety of services (e.g., Wi-Fi Handicapped access, cafeteria, etc.).
    ///
    /// These services are represented as individuals of the class 'Service' and they are in relationship with a CIS by means of the object property providesService.
    ///
    /// The following is an example expressed by using the turtle syntax:
    ///
    /// &lt;pre&gt;
    ///
    /// service:Caffetteria
    ///       a       cis:Service ;
    ///       cis:name "Caffetteria" .
    ///
    ///
    /// service:Connessione_WI-FI
    ///       a       cis:Service ;
    ///       cis:name "Connessione WI-FI" .
    ///
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:providesService service:Caffetteria, service:Connessione_WI-FI.
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : It represents a service that is provided by the Cultural Institute or Site. For instance, a service can be: the presence of a restaurant internal to the Cultural Institute or Site, the uso of an educational room, the use of a free wifi connectionrdfs:comment : Rappresenta un servizio offerto da un istituto e luogo della cultura. Per esempio, un servizio può essere: la presenza di un ristorante interno al luogo, l'uso una sala didattica, l'uso di una connessione wifi libera, ecc.</para>
    ///   <a href="http://dati.beniculturali.it/cis/Service">cis:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : Una sede è sempre associata agli individui della classe "Istituto e Luogo della Cultura" attraverso la proprietà ha sede.
    ///
    /// Una sede è caratterizzata dalle seguenti proprietà:
    ///  * ha indirizzo: consente di associare una sede con un individuo della classe indirizzo che fornisce la descrizione dell'indirizzo;
    ///  * ha punto di contatto: consente di associare una sede con un individuo che identifica un punto di contatto;
    ///  * ha locazione geografica: consente di associare la sede con la descrizione dell'area geografica
    /// * nome: una proprietà che consente di specificare il nome della sede
    /// * è sede di: la proprietà inversa di ha sede
    ///
    /// Il seguente esempio in turle mostra una sede associata a un istituto e luogo della cultura:
    ///
    /// &lt;pre&gt;
    ///
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasGeographicalLocation
    ///               geographicalFeature:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:name "Sede di: Biblioteca nazionale centrale di Roma"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasSite site:Sede_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// &lt;/pre&gt;dce:description : A site is always associated with an individual of the class 'Cultural Institute or Site' (CIS) by means of the object property hasSite.
    ///
    /// A site is characterised by the following properties:
    ///
    ///  * hasAddress that allows associating the site with an indidivdual of the class Address, this latter providing the description of the address;
    ///  * hasContactPoint that associates the site with an individual identifying a contact point;
    ///  * hasGeographicalLocation for relating the site to the description of its geographical features, that, in turn, is represented by means of an individual of the class 'Geographical Area';
    ///  * name that is the datatype property for associating the site with a literal expressing a name;
    ///  * isSiteOf that is the inverse property of hasSite.
    ///
    /// The following is an example of a Site and its association with a CIS
    ///
    /// &lt;pre&gt;
    ///
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasGeographicalLocation
    ///               geographicalFeature:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:name "Sede di: Biblioteca nazionale centrale di Roma"@it .
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasSite site:Sede_di_Biblioteca_nazionale_centrale_di_Roma .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Siterdfs:label : Sede</para>
    ///   <para>rdfs:comment : It represents a georeferenced physical site related to the Cultural Institute or Site. A Cultural Institute or Site can be located in more than one physical site. For instance, a Site can be "Palazzo Venezia" which is the site of the "Museum of Palazzo Venezia" and of "Library of Archaelogy and Art History".rdfs:comment : Rappresenta un luogo fisico georeferenziato relativo all'Istituto e luogo della Cultura. Un Istituto e Luogo della Cultura può avere più di un luogo fisico associato. Nell'ambito dell'Istituto Centrale per il Catalogo e la Documentazione (ICC)D) tale concetto rappresenta il contenitore fisico. Per esempio, un luogo fisico può essere "Palazzo Venezia" dove ha sede il "Museo Nazionale di Palazzo Venezia" o la "Biblioteca di Archeologia e Storia dell'Arte".</para>
    ///   <a href="http://dati.beniculturali.it/cis/Site">cis:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:SiteDescription is the following:
    /// &lt;pre&gt;
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasGeographicalLocation geographicalFeature:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:hasSiteDescription sd:Sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:name "Sede di: Biblioteca nazionale centrale di Roma"@it .
    ///
    /// sd:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///     a cis:SiteDescription ;
    ///     rdfs:label"Description of the 'Sede di Biblioteca Nazionale Centrale di Roma'"@en ;
    ///     rdfs:label "Descrizione della 'Sede di Biblioteca Nazionale Centrale di Roma'"@it ;
    ///     cis:description "La libreria 1000 metri di scaffalature"@it ;
    ///     cis:description "The Library has 1000 meters of shelves"@en ;
    ///     cis:hasAttribute attribute:Shelving .
    ///
    /// attribute:Shelving
    ///     a cis:Attribute ;
    ///     rdfs:label "Shelving"@en ;
    ///     rdfs:label "Scaffalature";@it ;
    ///     cis:name "Shelving"@en ;
    ///     cis:name "Scaffalature"@it ;
    ///     cis:description "The linear dimension of a shelf unit (e.g. 3 meters)"@en ;
    ///     cis:description ";La dimensione di uno scaffale in metri lineari (es. 3 metri)"@it .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:SiteDescription è il seguente:
    /// &lt;pre&gt;
    ///
    /// site:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///       a       cis:Site ;
    ///       rdfs:label "Sede Biblioteca nazionale centrale di Roma"@it ;
    ///       cis:hasAddress address:Indirizzo_della_sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasContactPoint contactPoint:Contatti_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:hasGeographicalLocation geographicalFeature:Comune_di_Roma ;
    ///       cis:isSiteOf cissite:Biblioteca_nazionale_centrale ;
    ///       cis:hasSiteDescription sd:Sede_di_Biblioteca_nazionale_centrale_di_Roma ;
    ///       cis:name "Sede di: Biblioteca nazionale centrale di Roma"@it .
    ///
    /// sd:Sede_di_Biblioteca_nazionale_centrale_di_Roma
    ///     a cis:SiteDescription ;
    ///     rdfs:label"Description of the 'Sede di Biblioteca Nazionale Centrale di Roma'"@en ;
    ///     rdfs:label "Descrizione della 'Sede di Biblioteca Nazionale Centrale di Roma'"@it ;
    ///     cis:description "La libreria 1000 metri di scaffalature"@it ;
    ///     cis:description "The Library has 1000 meters of shelves"@en ;
    ///     cis:hasAttribute attribute:Shelving .
    ///
    /// attribute:Shelving
    ///     a cis:Attribute ;
    ///     rdfs:label "Shelving"@en ;
    ///     rdfs:label "Scaffalature";@it ;
    ///     cis:name "Shelving"@en ;
    ///     cis:name "Scaffalature"@it ;
    ///     cis:description "The linear dimension of a shelf unit (e.g. 3 meters)"@en ;
    ///     cis:description ";La dimensione di uno scaffale in metri lineari (es. 3 metri)"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Site Descriptionrdfs:label : Descrizione della sede</para>
    ///   <para>rdfs:comment : Permette di rappresentare una descrizione della sede fisica dell'istituto e luogo della cultura (per esempio, la sede ha una metratura complessiva di XX mq suddivisa in metratura al pubblico e una scaffalatura complessiva di n. YYY).rdfs:comment : Permits to represents a description of a site of the cultural institute or site (for instance, the site has a total space available XXX, and a shelving that consists of a set of XX X shelves, etc.)</para>
    ///   <a href="http://dati.beniculturali.it/cis/SiteDescription">cis:SiteDescription</a>
    /// </summary>
    let SiteDescription = _prefixId.prefix "SiteDescription"
    /// <summary>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:SubjectDiscipline è il seguente:
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_archeologico_statale
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo archeologico statale" ;
    ///     cis:institutionalName"Museo archeologico statale" ;
    ///     cis:ISILIdentifier "T-EX0010" ;
    ///     cis:hasDiscipline sd:Archeologia ;
    ///     cis:hasSite site:Museo_archeologico_statale .
    ///
    /// sd:Archeologia
    ///     a cis:SubjectDiscipline ;
    ///     rdfs:label "Archeologia"@it ;
    ///     rdfs:label "Archaeology"@en ;
    ///     cis:name "Archeologia"@it ;
    ///     cis:name "Archaeology"@en ;
    ///     cis:description "Archaeology, or archeology, is the study of human activity through the recovery and
    /// analysis of material culture"@en ;
    ///     cis:description "L'archeologia è la scienza che studia le civiltà e le culture umane del passato e le loro relazioni
    /// con l'ambiente circostante, mediante la raccolta, la documentazione e l'analisi delle tracce materiali che hanno
    /// lasciato architetture, manufatti, resti biologici e umani"@it .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:SubjectDiscipline is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Museo_archeologico_statale
    ///     a cis:CulturalInstituteOrSite, cis:Museum ;
    ///     rdfs:label "Museo archeologico statale" ;
    ///     cis:institutionalName"Museo archeologico statale" ;
    ///     cis:ISILIdentifier "T-EX0010" ;
    ///     cis:hasDiscipline sd:Archeologia ;
    ///     cis:hasSite site:Museo_archeologico_statale .
    ///
    /// sd:Archeologia
    ///     a cis:SubjectDiscipline ;
    ///     rdfs:label "Archeologia"@it ;
    ///     rdfs:label "Archaeology"@en ;
    ///     cis:name "Archeologia"@it ;
    ///     cis:name "Archaeology"@en ;
    ///     cis:description "Archaeology, or archeology, is the study of human activity through the recovery and analysis
    /// of material culture"@en ;
    ///     cis:description "L'archeologia è la scienza che studia le civiltà e le culture umane del passato e le loro relazioni
    /// con l'ambiente circostante, mediante la raccolta, la documentazione e l'analisi delle tracce materiali che hanno
    /// lasciato architetture, manufatti, resti biologici e umani"@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : It represents a a field of knowledge or human activity. This can be defined in a controlled vocabulary. Examples can be: Modern Art, Ancient History, Ethnografy, etc.rdfs:comment : Rappresenta un certo ambito della conoscenza o dell'attività umana. Tale ambito è preferibilmente modellato mediante un vocabolario controllato. Esempi: arte contemporanea, storia antica, etnografia, ecc.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Categoria prevalenterdfs:label : Subject Discipline</para>
    ///   <a href="http://dati.beniculturali.it/cis/SubjectDiscipline">cis:SubjectDiscipline</a>
    /// </summary>
    let SubjectDiscipline = _prefixId.prefix "SubjectDiscipline"
    let Sunday = _prefixId.prefix "Sunday"
    /// <summary>
    ///   <para>dce:description : A temporary closure is a subclass of 'AccessCondition' whose individuals provide information about a temporary closure.
    /// These individuals are described in terms of:
    ///  * the closure date (cf. property hasDate);
    ///  * the reason about the temporary closure (cf. property hasReason);
    ///  * the type associated with the temporary closure (cf. property hasTemporaryClosureType).
    ///
    /// An example in turtle is the following:
    ///
    /// &lt;pre&gt;
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasAccessCondition            orari:Chiusura_estiva_di_Biblioteca_nazionale_centrale_di_Roma
    ///
    /// orari:Chiusura_estiva_di_Biblioteca_nazionale_centrale_di_Roma
    ///       cis:hasDate "2015-08-15"^^xsd:dateTime ;
    ///       cis:hasReason "Chiusura estiva" ;
    /// &lt;/pre&gt;dce:description : La chiusura temporanea è una sottoclasse di Condizioni di accesso i cui individui forniscono informazioni sulla chiusura temporanea.
    ///
    /// Gli individui sono descritti in termini di:
    ///  * data di chiusura (con la proprietà ha data);
    ///  * la motivazione per la chiusura (con la proprietà ha motivazione)
    ///  * il tipo associato con la chiusura temporanea (con la proprietà ha tipo chiusura temporanea)
    ///
    /// Un esempio è il seguente:
    /// &lt;pre&gt;
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       cis:hasAccessCondition            orari:Chiusura_estiva_di_Biblioteca_nazionale_centrale_di_Roma
    ///
    /// orari:Chiusura_estiva_di_Biblioteca_nazionale_centrale_di_Roma
    ///       cis:hasDate "2015-08-15"^^xsd:dateTime ;
    ///       cis:hasReason "Chiusura estiva" ;
    /// &lt;/pre&gt;</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:label : Chiusura Temporaneardfs:label : Temporary Closure</para>
    ///   <para>rdfs:comment : Rappresenta le informazioni sulla chiusura temporaneardfs:comment : It represents the information on the temporary closure </para>
    ///   <a href="http://dati.beniculturali.it/cis/TemporaryClosure">cis:TemporaryClosure</a>
    /// </summary>
    let TemporaryClosure = _prefixId.prefix "TemporaryClosure"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:TemporaryClosureType is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       rdfs:label "Biblioteca nazionale centrale"@it ;
    ///       cis:ISILIdentifier "IT-RM0267" ;
    ///       cis:hasAccessCondition tc:Biblioteca_nazionale_centrale_temporary_closure .
    ///
    /// tc:Biblioteca_nazionale_centrale_temporary_closure
    ///     a cis:TemporaryClosure ;
    ///     rdfs:label "Chiusura temporanea della Biblioteca Nazionale Centrale di Roma per restauro"@it ;
    ///     rdfs:label "Temporary closure of Biblioteca Nazionale Centrale di Roma for renovation"@en ;
    ///     cis:description "Dal 19-01-2015 al 21-01-2015 la Biblioteca Nazionale centrale chiude per restauro"@it ;
    ///     cis:description "From 2015-01-19 al 2015-01-21 Biblioteca Nazionale centrale is closed for renovation"@en ;
    ///     cis:hasReason "Renovation"@en;
    ///     cis:hasReason "Restauro"@it ;
    ///     cis:hasTemporaryClosureType tct:Renovation ;
    ///     cis:hasDate "2015-01-19"^^xsd:date ;
    ///     cis:hasDate "2015-01-20"^^xsd:date ;
    ///     cis:hasDate "2015-01-21"^^xsd:date .
    ///
    /// tct:Renovation
    ///     a cis:TemporaryClosureType;
    ///     rdfs:label "Renovation"@en;
    ///     rdfs:label "Restauro"@it ;
    ///     cis:name "Renovation"@en;
    ///     cis:name "Restauro";@it ;
    ///     cis:description"Temporary Closure for Renovation";@en ;
    ///     cis:description "Chiusura per Restauro";@it .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:TemporaryClosureType è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Biblioteca_nazionale_centrale
    ///       a       cis:Library , cis:CulturalInstituteOrSite ;
    ///       rdfs:label "Biblioteca nazionale centrale"@it ;
    ///       cis:ISILIdentifier "IT-RM0267" ;
    ///       cis:hasAccessCondition tc:Biblioteca_nazionale_centrale_temporary_closure .
    ///
    /// tc:Biblioteca_nazionale_centrale_temporary_closure
    ///     a cis:TemporaryClosure ;
    ///     rdfs:label "Chiusura temporanea della Biblioteca Nazionale Centrale di Roma per restauro"@it ;
    ///     rdfs:label "Temporary closure of Biblioteca Nazionale Centrale di Roma for renovation"@en ;
    ///     cis:description "Dal 19-01-2015 al 21-01-2015 la Biblioteca Nazionale centrale chiude per restauro"@it ;
    ///     cis:description "From 2015-01-19 al 2015-01-21 Biblioteca Nazionale centrale is closed for renovation"@en ;
    ///     cis:hasReason "Renovation"@en;
    ///     cis:hasReason "Restauro"@it ;
    ///     cis:hasTemporaryClosureType tct:Renovation ;
    ///     cis:hasDate "2015-01-19"^^xsd:date ;
    ///     cis:hasDate "2015-01-20"^^xsd:date ;
    ///     cis:hasDate "2015-01-21"^^xsd:date .
    ///
    /// tct:Renovation
    ///     a cis:TemporaryClosureType;
    ///     rdfs:label "Renovation"@en;
    ///     rdfs:label "Restauro"@it ;
    ///     cis:name "Renovation"@en;
    ///     cis:name "Restauro";@it ;
    ///     cis:description"Temporary Closure for Renovation";@en ;
    ///     cis:description "Chiusura per Restauro";@it .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:comment : Rappresenta il tipo di chiusura temporanea. Per esempio: per restauro, per inagibilità, ecc. rdfs:comment : It represents the type of temporary. Examples can be: closed for renovation, unfit for use, etc. </para>
    ///   <para>rdfs:label : Tipo di Chiusura Temporaneardfs:label : Type of Temporary Closure</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/TemporaryClosureType">cis:TemporaryClosureType</a>
    /// </summary>
    let TemporaryClosureType = _prefixId.prefix "TemporaryClosureType"
    /// <summary>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:comment : This class represents a cultural institute or site of type Theatrerdfs:comment : Questa classe rappresenta un istituto e luogo della cultura di tipo Teatro</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:Theatre è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Teatro_Olimpico
    ///     a cis:CulturalInstituteOrSite, cis:Theatre ;
    ///     rdfs:label "Teatro Olimpico" ;
    ///     cis:name "Teatro Olimpico" ;
    ///     cis:ISILIdentifier "IT-EX0011" .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:Theatre is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// cissite:Teatro_Olimpico
    ///     a cis:CulturalInstituteOrSite, cis:Theatre ;
    ///     rdfs:label "Teatro Olimpico" ;
    ///     cis:name "Teatro Olimpico" ;
    ///     cis:ISILIdentifier "IT-EX0011" .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Teatrordfs:label : Theatre</para>
    ///   <a href="http://dati.beniculturali.it/cis/Theatre">cis:Theatre</a>
    /// </summary>
    let Theatre = _prefixId.prefix "Theatre"
    let Thursday = _prefixId.prefix "Thursday"
    /// <summary>
    ///   <para>rdfs:label : Bigliettordfs:label : Ticket</para>
    ///   <para>rdfs:comment : It represents an entrance ticket for a Cultural Institute or Site, if required, and for an eventrdfs:comment : Rappresenta il biglietto d'ingresso per l'Istitituto e Luogo della Cultura, qualora sia previsto, e per l'evento culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : An example of usage of the class cis:Ticket is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer"@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// ticket:Biblioteca_nazionale_centrale_ticket_1
    ///      a cis:Ticket ;
    ///      rdfs:label "Biglietto per accedere a 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      rdfs:label "Ticket for access to 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:name "Biglietto base per accedere 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      cis:name"Basic ticket for access to 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:description "Biglietto che permette l'accesso per un giorno alla 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      cis:description "One-day ticket for 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:hasValidity validity:Biblioteca_nazionale_centrale_ticket_1;
    ///      cis:forAccessTo cissite:Biblioteca_nazionale_centrale .
    ///
    /// validity:Biblioteca_nazionale_centrale_ticket_1
    ///     a cis:Validity ;
    ///     rdfs:label "One day validity"@en ;
    ///     rdfs:label "Validità per 1 giorno"@it ;
    ///     cis:hasDuration qv:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// qv:Biblioteca_nazionale_centrale_ticket_1
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "1";
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "1"^^xsd:positiveInteger .
    ///
    /// priceSpecification:Under18
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo per ragazzi sotto i 18 anni "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue "5"^^xsd:float .
    ///
    /// userType:Under18
    ///    a cis:UserType ;
    ///    rdfs:label "Under 18" ;
    ///    cis:name "Under 18"; ;
    ///    cis:description "People under 18 years old";@en;
    ///    cis:description "Persone con età inferiore ai 18 anni"@it  .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio dell'utilizzo della classe cis:Ticket è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// offer:Biblioteca_Nazionale_Centrale_base_offer
    ///       a       cis:Offer ;
    ///       rdfs:label "offerta base "@it , "base offer"@en ;
    ///       cis:hasEligibleUser userType:Under18 ;
    ///       cis:hasPriceSpecification priceSpecification:Under18 ;
    ///       cis:hasValidity validity:Biblioteca_nazionale_centrale_validity ;
    ///       cis:includes ticket:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// ticket:Biblioteca_nazionale_centrale_ticket_1
    ///      a cis:Ticket ;
    ///      rdfs:label "Biglietto per accedere a 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      rdfs:label "Ticket for access to 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:name "Biglietto base per accedere 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      cis:name"Basic ticket for access to 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:description "Biglietto che permette l'accesso per un giorno alla 'Biblioteca Nazionale Centrale di Roma'"@it ;
    ///      cis:description "One-day ticket for 'Biblioteca Nazionale Centrale di Roma'"@en ;
    ///      cis:hasValidity validity:Biblioteca_nazionale_centrale_ticket_1;
    ///      cis:forAccessTo cissite:Biblioteca_nazionale_centrale .
    ///
    /// validity:Biblioteca_nazionale_centrale_ticket_1
    ///     a cis:Validity ;
    ///     rdfs:label "One day validity"@en ;
    ///     rdfs:label "Validità per 1 giorno"@it ;
    ///     cis:hasDuration qv:Biblioteca_nazionale_centrale_ticket_1 .
    ///
    /// qv:Biblioteca_nazionale_centrale_ticket_1
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "1";
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "1"^^xsd:positiveInteger .
    ///
    /// priceSpecification:Under18
    ///       a       cis:PriceSpecification ;
    ///       rdfs:label "price specification under 18 "@en , "costo per ragazzi sotto i 18 anni "@it ;
    ///       cis:hasCurrency cis:Euro ;
    ///       cis:hasCurrencyValue "5"^^xsd:float .
    ///
    /// userType:Under18
    ///    a cis:UserType ;
    ///    rdfs:label "Under 18" ;
    ///    cis:name "Under 18"; ;
    ///    cis:description "People under 18 years old";@en;
    ///    cis:description "Persone con età inferiore ai 18 anni"@it  .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Ticket">cis:Ticket</a>
    /// </summary>
    let Ticket = _prefixId.prefix "Ticket"
    /// <summary>
    ///   <para>rdfs:comment : Rappresenta un intervallo temporale.rdfs:comment : It represents a temporal interval</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:TimeInterval è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale from 2013-01-01 to 2016-12-31"@en ;
    ///     cis:startDate "2013-01-01"^^xsd:dateTime ;
    ///     cis:endDate "2016-12-31"^^xsd:dateTime .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:TimeInterval is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// timeInteval:Andrea_De_Pasquale_DirectorOfBibliotecaNazionaleCentrale_20130101_20161231
    ///     a cis:TimeInterval ;
    ///     rdfs:label "Andrea De Pasquale director of Biblioteca Nazionale from 2013-01-01 to 2016-12-31"@en ;
    ///     cis:startDate "2013-01-01"^^xsd:dateTime ;
    ///     cis:endDate "2016-12-31"^^xsd:dateTime .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : Time Intervalrdfs:label : Intervallo di Tempo</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/TimeInterval">cis:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    let Tuesday = _prefixId.prefix "Tuesday"
    /// <summary>
    ///   <para>dce:description : An example of usage of the class cis:UserType is the following:
    ///
    /// &lt;pre&gt;
    /// userType:Under18
    ///    a cis:UserType ;
    ///    rdfs:label "Under 18" ;
    ///    cis:name "Under 18"; ;
    ///    cis:description "People under 18 years old";@en;
    ///    cis:description "Persone con età inferiore ai 18 anni"@it  .
    ///
    /// &lt;/pre&gt;dce:description : Un esempio di utilizzo della classe cis:UserType è il seguente:
    ///
    /// &lt;pre&gt;
    /// userType:Under18
    ///    a cis:UserType ;
    ///    rdfs:label "Under 18" ;
    ///    cis:name "Under 18"; ;
    ///    cis:description "People under 18 years old";@en;
    ///    cis:description "Persone con età inferiore ai 18 anni"@it  .
    ///
    /// &lt;/pre&gt;</para>
    ///   <para>rdfs:label : User Typerdfs:label : Tipo di utente</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Rappresenta la tipologia di utenti relativa ai biglietti per accedere a un evento o a un istituto e luogo della cultura. Esempi includono:  "maggiorenni over 25", oppure "over 65", "bambini", ecc.rdfs:comment : It represents the identified type of users related to the tickets used to access an event or a Cultural Institute or Site. Examples include: people over 25 years old, people over 65 years old,  children, etc.</para>
    ///   <a href="http://dati.beniculturali.it/cis/UserType">cis:UserType</a>
    /// </summary>
    let UserType = _prefixId.prefix "UserType"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta la validità di biglietti e di offerterdfs:comment : This class represents the validity for the ticket and offering.</para>
    ///   <para>owl:versionInfo : non stabileowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : Validitàrdfs:label : Validity</para>
    ///   <para>dce:description : Un esempio di utilizzo della classe cis:Validity è il seguente:
    ///
    /// &lt;pre&gt;
    ///
    /// validity:Parco_archeologico_di_Liternum_Card_Validity
    ///     a cis:Validity ;
    ///     rdfs:label "Two-day validity"@en ;
    ///     rdfs:label "Validità per due giorni"@it ;
    ///     cis:hasDuration Parco_archeologico_di_Liternum_Card_Validity_Duration .
    ///
    /// qv:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2";;
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// &lt;/pre&gt;dce:description : An example of usage of the class cis:Validity is the following:
    ///
    /// &lt;pre&gt;
    ///
    /// validity:Parco_archeologico_di_Liternum_Card_Validity
    ///     a cis:Validity ;
    ///     rdfs:label "Two-day validity"@en ;
    ///     rdfs:label "Validità per due giorni"@it ;
    ///     cis:hasDuration Parco_archeologico_di_Liternum_Card_Validity_Duration .
    ///
    /// qv:Parco_archeologico_di_Liternum_Card_Validity_Duration
    ///     a cis:QuantitativeValue ;
    ///     rdfs:label "2";;
    ///     cis:hasMeasurementUnit cis:Day ;
    ///     cis:hasValue "2"^^xsd:positiveInteger .
    ///
    /// &lt;/pre&gt;</para>
    ///   <a href="http://dati.beniculturali.it/cis/Validity">cis:Validity</a>
    /// </summary>
    let Validity = _prefixId.prefix "Validity"
    /// <summary>
    ///   <para>rdfs:comment : Concetto utilizzato per rappresentare materiali multimediali di tipo video.rdfs:comment : Concept used to represent multimedia objects of type video.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Oggetto videordfs:label : Video Object</para>
    ///   <a href="http://dati.beniculturali.it/cis/VideoObject">cis:VideoObject</a>
    /// </summary>
    let VideoObject = _prefixId.prefix "VideoObject"
    let Wednesday = _prefixId.prefix "Wednesday"
    let Week = _prefixId.prefix "Week"
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>rdfs:label : access condition forrdfs:label : condizione di accesso per</para>
    ///   <para>rdfs:comment : Inverse property of "has access condition"rdfs:comment : Proprietà inversa di "ha condizione di accesso"</para>
    ///   <a href="http://dati.beniculturali.it/cis/accessConditionFor">cis:accessConditionFor</a>
    /// </summary>
    let accessConditionFor = _prefixId.prefix "accessConditionFor"
    /// <summary>
    ///   <para>rdfs:label : address identifierrdfs:label : identificativo dell'indirizzo</para>
    ///   <para>owl:versionInfo : unstable^^xsd:stringowl:versionInfo : versione ancora non definitiva</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per rappresentare un identificatore univoco per ciascuna istanza di un indirizzo, Rappresenta un elemento cruciale delle specifiche INSPIRE. Sottoproprietà di identificativo.rdfs:comment : Property used to represent the globally unique identifier for each instance of an address. A crucial part of the INSPIRE data specifications. Subproperty of identifier.</para>
    ///   <a href="http://dati.beniculturali.it/cis/addressID">cis:addressID</a>
    /// </summary>
    let addressID = _prefixId.prefix "addressID"
    /// <summary>
    ///   <para>rdfs:comment : Property used to represent the uppermost administrative unit for the address of the site of the cultural institute or site, almost always a country.rdfs:comment : Proprietà utilizzata per l'unità amministrativa di più alto livello dell'indirizzo della sede di un istituto e luogo della cultura.</para>
    ///   <para>rdfs:label : unità amministrativa di livello 1rdfs:label : administrative unit level 1</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/adminUnitL1">cis:adminUnitL1</a>
    /// </summary>
    let adminUnitL1 = _prefixId.prefix "adminUnitL1"
    /// <summary>
    ///   <para>rdfs:label : administrative unit level 2rdfs:label : unità amministrativa di livello 2</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per rappresentare l'unità amministrativa di livello 2 dell'indirizzo della sede di un istituto e luogo della cultura, di solito uno stato, una contea o ogni altra area che tipicamente ricomprende diverse località.rdfs:comment : Property used to represent the region of the address of the site of a cultural institute or site, usually a county, state or other such area that typically encompasses several localities.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/adminUnitL2">cis:adminUnitL2</a>
    /// </summary>
    let adminUnitL2 = _prefixId.prefix "adminUnitL2"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare la situazione name in time a una denominazione alternativa dell'istituto e luogo della cultura.rdfs:comment : Property used to associate the situation name in time with the alternative name of the cultural institute or site</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : alternative labelrdfs:label : nome alternativo dell'istituto e luogo della cultura</para>
    ///   <a href="http://dati.beniculturali.it/cis/altLabel">cis:altLabel</a>
    /// </summary>
    let altLabel = _prefixId.prefix "altLabel"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : at timerdfs:label : al tempo</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare un ruolo nel tempo a un intervallo temporale. La stessa proprietà è utilizzata in maniera analoga per associare una collezione a un intervallo temporale.rdfs:comment : Property used to associate the situation role in time with a temporal interval. The same property is used in a similar way to link a site or a collection to a temporal interval</para>
    ///   <a href="http://dati.beniculturali.it/cis/atTime">cis:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare  un punto di contatto a fasce orarie in cui il punto di contatto è disponibile.rdfs:comment : Property used to associate a contact point with hours specification in which the contact point is available.</para>
    ///   <para>rdfs:label : availablerdfs:label : disponibile</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/available">cis:available</a>
    /// </summary>
    let available = _prefixId.prefix "available"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Property used to associate the Cultural Institute or SIte with a catalogue of cultural collections included in the institute or site. The relatioships can be used to indicate that a Cultural Institute or Site has an its own catalogue or situations where a Cultural Institute or Site contributes to a union catalogue (this latter case is represented by libraries that can contribute to or participate in a union catalogue).rdfs:comment : Proprietà utilizzata per associare l'istituto e luogo della cultura a un  catalogo che descrive le opere in esso contenute. Tale relazione può essere utilizzata per indicare che un istituto e luogo della cultura ha un catalogo ma anche una situazione per cui un istituto e luogo della cultura partecipa a un catalogo (in quest'ultimo caso un esempio è rappresentato dalle biblioteche che possono partecipare a un catalogo collettivo).</para>
    ///   <para>rdfs:label : cataloguerdfs:label : catalogo</para>
    ///   <a href="http://dati.beniculturali.it/cis/catalogue">cis:catalogue</a>
    /// </summary>
    let catalogue = _prefixId.prefix "catalogue"
    /// <summary>
    ///   <para>rdfs:label : chiude rdfs:label : closes </para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per rappresentare l'orario di chiusura.rdfs:comment : This property is used to represent the closing time</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/closes">cis:closes</a>
    /// </summary>
    let closes = _prefixId.prefix "closes"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate the catalogue with the cultural heritage objects of a cultural institute or site that the catalogue describes.rdfs:comment : Proprietà che consente di associare il catalogo alle opere di un istituto e luogo della cultura che esso descrive.</para>
    ///   <para>rdfs:label : describesrdfs:label : descrive</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/describes">cis:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to indicate a description of the cultural institute or siterdfs:comment : Questa proprietà è utilizzata per indicare una descrizione dell'istituto e luogo della cultura</para>
    ///   <para>rdfs:label : descrizionerdfs:label : description</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/description">cis:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : data di finerdfs:label : end Date</para>
    ///   <para>rdfs:comment : end Date of a Time Intervalrdfs:comment : Data di fine di un intervallo temporale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/endDate">cis:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà che consente di associare un biglietto a un evento o a un istituto e luogo della cultura.rdfs:comment : Property used to associate a ticket with an event or a cultural institute or site</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : for access tordfs:label : per l'accesso a</para>
    ///   <a href="http://dati.beniculturali.it/cis/forAccessTo">cis:forAccessTo</a>
    /// </summary>
    let forAccessTo = _prefixId.prefix "forAccessTo"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per indicare l'indirizzo completo della sede di un istituto e luogo della cultura.rdfs:comment : Property used to represent the full address of the site of a cultural institute or site.</para>
    ///   <para>rdfs:label : full addressrdfs:label : indirizzo completo</para>
    ///   <a href="http://dati.beniculturali.it/cis/fullAddress">cis:fullAddress</a>
    /// </summary>
    let fullAddress = _prefixId.prefix "fullAddress"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per rappresentare il metodo della georeferenziazione. Essa può essere i valori "approssimata" ed "esatta".rdfs:comment : This property is used to represent the methodology used for the georeferentiation.</para>
    ///   <para>rdfs:label : georeferentiation methodologyrdfs:label : metodologia di georeferenziazione</para>
    ///   <a href="http://dati.beniculturali.it/cis/geoMethodology">cis:geoMethodology</a>
    /// </summary>
    let geoMethodology = _prefixId.prefix "geoMethodology"
    /// <summary>
    ///   <para>rdfs:label : tipo di geometriardfs:label : geometry type</para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per identificare il tipo di geometria (punto, linea, o poligono) nella rappresentazione geospaziale.rdfs:comment : This property is used to represent the geometry type (point, line, or polygon) in the geospatial representation.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/geometryType">cis:geometryType</a>
    /// </summary>
    let geometryType = _prefixId.prefix "geometryType"
    /// <summary>
    ///   <para>rdfs:label : has access conditionrdfs:label : ha condizioni di accesso</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare l'istituto e luogo della cultura o l'evento con le condizioni di accesso.rdfs:comment : Property used to associate the Cultural Institute or Site or the Event with its access condition information</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasAccessCondition">cis:hasAccessCondition</a>
    /// </summary>
    let hasAccessCondition = _prefixId.prefix "hasAccessCondition"
    /// <summary>
    ///   <para>rdfs:label : ha indirizzordfs:label : has address</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare un sito fisico a un indirizzo.rdfs:comment : Property that permits to associate a site with an address</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasAddress">cis:hasAddress</a>
    /// </summary>
    let hasAddress = _prefixId.prefix "hasAddress"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has admission typerdfs:label : ha tipo di apertura</para>
    ///   <para>rdfs:comment : Property used to associate the opening hours specification to the admission typerdfs:comment : Proprietà che consente di associare gli orari di apertura al tipo di apertura.</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasAdmissionType">cis:hasAdmissionType</a>
    /// </summary>
    let hasAdmissionType = _prefixId.prefix "hasAdmissionType"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà che permette di associare una descrizione del sito dell'istituto e luogo della cultura a un attributo, inteso come caratteristica del sito (metratura, scaffalatura, etc)rdfs:comment : Property used to associate the description of the site of the cultural institute or site an attribute (e.g., total space, shelving, etc.)</para>
    ///   <para>rdfs:label : has attributerdfs:label : ha attribute</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasAttribute">cis:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:label : has typerdfs:label : ha tipo</para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:comment : La proprietà è utilizzata per collegare un istituto e luogo della cultura alla sua tipologia.rdfs:comment : The property is used to link a cultural institure or site to its type.</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasCISType">cis:hasCISType</a>
    /// </summary>
    let hasCISType = _prefixId.prefix "hasCISType"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare un indirizzo PEC a un punto di contattordfs:comment : Property used to associate a certified email address to a contact point</para>
    ///   <para>rdfs:label : ha posta elettronica certificata (PEC)rdfs:label : has certified email</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasCertifiedEmail">cis:hasCertifiedEmail</a>
    /// </summary>
    let hasCertifiedEmail = _prefixId.prefix "hasCertifiedEmail"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha collezionerdfs:label : has collection</para>
    ///   <para>rdfs:comment : Proprietà che permette di associare l'istituto e luogo della cultura all'insieme delle opere in esso contenute.rdfs:comment : Property used to associate the Cultural Institute or Site with the set of cultural objects it contains.</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasCollection">cis:hasCollection</a>
    /// </summary>
    let hasCollection = _prefixId.prefix "hasCollection"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Property which links a cultural insttiute or site to its contact points. The same property is used to link in a similar way the event to its contact points and to link the site of the cultural institute or site with its contact pointsrdfs:comment : Proprietà che collega un istituto e luogo della cultura ai propri punti di contatto. La stessa proprietà è utilizzata in maniera analoga per collegare il luogo fisico con i propri punti di contatto, ad anche per collegare un evento ai propri contatti</para>
    ///   <para>rdfs:label : has contact pointrdfs:label : ha punto di contatto</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasContactPoint">cis:hasContactPoint</a>
    /// </summary>
    let hasContactPoint = _prefixId.prefix "hasContactPoint"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to connected the Price specification to Currencyrdfs:comment : Questa proprietà collega la specifica del prezzo del ticket per un evento o istituto e luogo della cultura con la classe currency</para>
    ///   <para>rdfs:label : has currencyrdfs:label : ha valuta</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasCurrency">cis:hasCurrency</a>
    /// </summary>
    let hasCurrency = _prefixId.prefix "hasCurrency"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per indicare il prezzo del biglietto.rdfs:comment : Property used to represent the price of the ticket.</para>
    ///   <para>rdfs:label : ha prezzordfs:label : has currency value</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasCurrencyValue">cis:hasCurrencyValue</a>
    /// </summary>
    let hasCurrencyValue = _prefixId.prefix "hasCurrencyValue"
    /// <summary>
    ///   <para>rdfs:comment : Property used to represent the date of the temporary closure.rdfs:comment : Proprietà utilizzata per indicare una data della chiusura temporanea.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:label : ha datardfs:label : has date</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasDate">cis:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to specify the opening hours and in particular the days of the week.rdfs:comment : Questa proprietà è utilizzata per specificare gli orari di apertura e in particolare i giorni della settimana.</para>
    ///   <para>rdfs:label : ha giorno della settimana rdfs:label : has day of week </para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasDayOfWeek">cis:hasDayOfWeek</a>
    /// </summary>
    let hasDayOfWeek = _prefixId.prefix "hasDayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : ha categoriardfs:label : has discipline</para>
    ///   <para>rdfs:comment : Proprietà che permette di associare all&amp;apos;istituto e luogo della cultura la categoria a cui esso è tipicamente associato (es. archeologia, etnografia e antropologia, arte, ...).rdfs:comment : Property used to associate the Cultural Institute or Site with its own field of knowledge</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasDiscipline">cis:hasDiscipline</a>
    /// </summary>
    let hasDiscipline = _prefixId.prefix "hasDiscipline"
    /// <summary>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per specificare il periodo temporale di validità.rdfs:comment : This property is used to specify the temporal duration of the validity.</para>
    ///   <para>rdfs:label : has durationrdfs:label : ha durata</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasDuration">cis:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare un'offerta per l'accesso a un evento o a un istituto e luogo della cultura a una tipologia di utenterdfs:comment : Property used to associate the an offert for the access to an event or a cultural institute or site with the type of user</para>
    ///   <para>rdfs:label : ha utente eligibilerdfs:label : has eligible User</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasEligibleUser">cis:hasEligibleUser</a>
    /// </summary>
    let hasEligibleUser = _prefixId.prefix "hasEligibleUser"
    /// <summary>
    ///   <para>rdfs:comment : Property used to specify email address for a contact pointrdfs:comment : Proprietà utilizzata per specificare indirizzi email del punto di contatto</para>
    ///   <para>rdfs:label : ha emailrdfs:label : has email</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasEmail">cis:hasEmail</a>
    /// </summary>
    let hasEmail = _prefixId.prefix "hasEmail"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per rappresentare uno o più numeri di fax del punto di contattordfs:comment : Property used to represent one or more fax numbers for the contact point</para>
    ///   <para>rdfs:label : has faxrdfs:label : ha fax</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasFax">cis:hasFax</a>
    /// </summary>
    let hasFax = _prefixId.prefix "hasFax"
    /// <summary>
    ///   <para>rdfs:label : ha locazione geograficardfs:label : has geographical location</para>
    ///   <para>rdfs:comment : Property used to associate a site with a geographical area where the site is located.rdfs:comment : Proprietà che consente di associare una sede di un istituto e luogo della cultura a un'area geografica in cui si trova la sede.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasGeographicalLocation">cis:hasGeographicalLocation</a>
    /// </summary>
    let hasGeographicalLocation = _prefixId.prefix "hasGeographicalLocation"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare un sito alle proprie coordinate geografiche.rdfs:comment : Property used to associate a site with its own geographical coordinates</para>
    ///   <para>rdfs:label : ha geometriardfs:label : has geometry</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasGeometry">cis:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:label : has ISTAT coderdfs:label : ha codice ISTAT</para>
    ///   <para>rdfs:comment : This property is used to represent a specific code used in the Italian context for the governamental administrative areas.rdfs:comment : Questa proprietà è utilizzata per rappresentare il codice ISTAT associato a un'area amministrativa statale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasISTATCode">cis:hasISTATCode</a>
    /// </summary>
    let hasISTATCode = _prefixId.prefix "hasISTATCode"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Property used to associate a latitude with a Pointrdfs:comment : Proprietà utilizzata per associare la latitudine a un punto</para>
    ///   <para>rdfs:label : ha latitudinerdfs:label : has latitude</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasLat">cis:hasLat</a>
    /// </summary>
    let hasLat = _prefixId.prefix "hasLat"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare la longitudine a un puntordfs:comment : Property used to associate the longitude with a Point</para>
    ///   <para>rdfs:label : has longituderdfs:label : ha longitudine</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasLong">cis:hasLong</a>
    /// </summary>
    let hasLong = _prefixId.prefix "hasLong"
    /// <summary>
    ///   <para>rdfs:label : has measurement unitrdfs:label : ha unità di misura</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <para>rdfs:comment : Questa proprietà è utilizzata per rappresentare un'unità di misura.rdfs:comment : This property is used to represent a measurement unit.</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasMeasurementUnit">cis:hasMeasurementUnit</a>
    /// </summary>
    let hasMeasurementUnit = _prefixId.prefix "hasMeasurementUnit"
    /// <summary>
    ///   <para>rdfs:label : ha membrordfs:label : has member</para>
    ///   <para>rdfs:comment : Property that permits to specify the cultural heritage objects that form a specific collection or the entire cultural heritage included in a cultural institute or siterdfs:comment : Proprietà che consente di specificare le opere che formano una determinata collezione o l'intero patrimonio di un istituto e luogo della cultura</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasMember">cis:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : ha nome nel tempordfs:label : has name in time</para>
    ///   <para>rdfs:comment : Property which associate a cultural institute or site or a site with the situation name in timerdfs:comment : Proprietà che associa un istituto o luogo della cultura o un sito alla situazione "denominazione nel tempo", ovvero una determinata denominazione valida in un determinato arco temporale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasNameInTime">cis:hasNameInTime</a>
    /// </summary>
    let hasNameInTime = _prefixId.prefix "hasNameInTime"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà è utliizzata per collegare l'offerta per i biglietti a una specifica del prezzo.rdfs:comment : This property is used to link the offer for a ticket to its price specification.</para>
    ///   <para>rdfs:label : ha specifica di prezzo rdfs:label : has price specification </para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasPriceSpecification">cis:hasPriceSpecification</a>
    /// </summary>
    let hasPriceSpecification = _prefixId.prefix "hasPriceSpecification"
    /// <summary>
    ///   <para>rdfs:label : ha motivazionerdfs:label : has reason</para>
    ///   <para>rdfs:comment : Property used to describe a reason for the temporary closure.rdfs:comment : Proprietà utilizzata per descrivere una motivazione della chiusura temporanea.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasReason">cis:hasReason</a>
    /// </summary>
    let hasReason = _prefixId.prefix "hasReason"
    /// <summary>
    ///   <para>rdfs:label : ha contenitore fisicordfs:label : ha sederdfs:label : has site</para>
    ///   <para>rdfs:comment : Property which links a cultural institute or site to its own physical site(s).rdfs:comment : Proprietà che collega un istituto e luogo della cultura al proprio o ai propri siti fisici.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasSite">cis:hasSite</a>
    /// </summary>
    let hasSite = _prefixId.prefix "hasSite"
    /// <summary>
    ///   <para>rdfs:label : ha descrizione della sederdfs:label : has site description</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà che permette di associare una descrizione alla sede dell'istituto e luogo della cultura.rdfs:comment : Propery that permits to associate a site of a cultural institute or site with its description.</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasSiteDescription">cis:hasSiteDescription</a>
    /// </summary>
    let hasSiteDescription = _prefixId.prefix "hasSiteDescription"
    /// <summary>
    ///   <para>rdfs:label : has sub eventrdfs:label : ha sotto eventi</para>
    ///   <para>rdfs:comment : Property used to describe large events to which single sub events refer. For instance, a large event can be the first world war centenary to which single events celebrating the 100th anniversary referrdfs:comment : Proprietà utilizzata per rappresentare grandi eventi che hanno singoli eventi che ad esso fanno riferimento. Ad esempio, un grande evento può essere il centenario della prima guerra mondiale a cui fanno riferimento una serie di eventi singoli.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasSubEvent">cis:hasSubEvent</a>
    /// </summary>
    let hasSubEvent = _prefixId.prefix "hasSubEvent"
    /// <summary>
    ///   <para>rdfs:label : ha telefonordfs:label : has telephone</para>
    ///   <para>rdfs:comment : Property used to represent one or more telephone numbers for the contact pointrdfs:comment : proprietà utilizzata per rappresentare uno o più numeri di telefono per il punto di contatto</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasTelephone">cis:hasTelephone</a>
    /// </summary>
    let hasTelephone = _prefixId.prefix "hasTelephone"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate the temporary closure with its typerdfs:comment : Proprietà che consente di associare una chiusura temporanea al suo tipo.</para>
    ///   <para>rdfs:label : ha tipo di chiusura temporaneardfs:label : has temporary closure type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasTemporaryClosureType">cis:hasTemporaryClosureType</a>
    /// </summary>
    let hasTemporaryClosureType = _prefixId.prefix "hasTemporaryClosureType"
    /// <summary>
    ///   <para>rdfs:label : has ticketrdfs:label : ha biglietto</para>
    ///   <para>rdfs:comment : Inverse property of "for access to"rdfs:comment : proprietà inversa di "per accedere a"</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasTicket">cis:hasTicket</a>
    /// </summary>
    let hasTicket = _prefixId.prefix "hasTicket"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà utilizzata per specificare una validità di un offerta o di un biglietto.rdfs:comment : Property used to specify the validity of an offer or ticket.</para>
    ///   <para>rdfs:label : has validityrdfs:label : ha validità</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : versione non definitiva</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasValidity">cis:hasValidity</a>
    /// </summary>
    let hasValidity = _prefixId.prefix "hasValidity"
    /// <summary>
    ///   <para>rdfs:comment : Proprietà utilizzata per rappresentare un valorerdfs:comment : Property used to represent a value</para>
    ///   <para>owl:versionInfo : unstableowl:versionInfo : non stabile</para>
    ///   <para>rdfs:label : has valuerdfs:label : ha valore</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasValue">cis:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha sito webrdfs:label : has web site</para>
    ///   <para>rdfs:comment : Property used to represent a web siterdfs:comment : Proprietà utilizzata per rappresentare un sito web</para>
    ///   <a href="http://dati.beniculturali.it/cis/hasWebSite">cis:hasWebSite</a>
    /// </summary>
    let hasWebSite = _prefixId.prefix "hasWebSite"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate an agent with the situation role in time the agent can playrdfs:comment : Proprietà utilizzata per associare un agente alla situazione "ruolo nel tempo", ovvero ad un determinato ruolo ricoperto dall'agente stesso in un deteminato arco temporale</para>
    ///   <para>rdfs:label : holds role in timerdfs:label : detiene un ruolo nel tempo</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/holdsRoleInTime">cis:holdsRoleInTime</a>
    /// </summary>
    let holdsRoleInTime = _prefixId.prefix "holdsRoleInTime"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate a cultural institute or site to an eventrdfs:comment : Proprietà usata per associare un istituto e luogo della cultura a un evento.</para>
    ///   <para>owl:versionInfo : versione ancora non definitivaowl:versionInfo : unstable^^xsd:string</para>
    ///   <para>rdfs:label : ospitardfs:label : hosts</para>
    ///   <a href="http://dati.beniculturali.it/cis/hosts">cis:hosts</a>
    /// </summary>
    let hosts = _prefixId.prefix "hosts"
    /// <summary>
    ///   <para>rdfs:comment : This property represents an identifier for a Thing.rdfs:comment : Questa proprietà rappresenta un identificativo per una cosa.</para>
    ///   <para>rdfs:label : identificativordfs:label : identifier</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/identifier">cis:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : includesrdfs:label : include</para>
    ///   <para>rdfs:comment : Property used to associate an offer with the relative ticketrdfs:comment : Proprietà utilizzata per associare un'offerta al relativo biglietto.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/includes">cis:includes</a>
    /// </summary>
    let includes = _prefixId.prefix "includes"
    /// <summary>
    ///   <para>rdfs:label : Nome Istituzionalerdfs:label : Institutional Name^^xsd:string</para>
    ///   <para>rdfs:comment : This data property identifies  the institutional name of the Cultural Institute or Site.rdfs:comment : Questa proprietà identifica direttamente il nome istituzionale dell'Istituto e luogo della cultura</para>
    ///   <para>owl:versionInfo : Stabileowl:versionInfo : Stable</para>
    ///   <a href="http://dati.beniculturali.it/cis/institutionalName">cis:institutionalName</a>
    /// </summary>
    let institutionalName = _prefixId.prefix "institutionalName"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:label : involvesrdfs:label : coinvolge</para>
    ///   <para>rdfs:comment : Proprietà di coinvolgimento che associa un evento a una generica entità culturale.rdfs:comment : Involvment property that associates an event with a general cultural entity</para>
    ///   <a href="http://dati.beniculturali.it/cis/involves">cis:involves</a>
    /// </summary>
    let involves = _prefixId.prefix "involves"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare un lavoro creativo a un'entità culturale. La stessa proprietà può essere utilizzata in maniera analoga per associare un lavoro creativo a un evento o a un sito.rdfs:comment : Property used to associate a creative work with a cultural entity. The same property is used in a similar way to associate the creative work with an event or site</para>
    ///   <para>rdfs:label : tratta dirdfs:label : is about</para>
    ///   <a href="http://dati.beniculturali.it/cis/isAbout">cis:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:comment : Inverse property of "has catalogue".rdfs:comment : Proprietà inversa di "ha catalogo".</para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : is catalogue ofrdfs:label : è catalogo di</para>
    ///   <a href="http://dati.beniculturali.it/cis/isCatalogueOf">cis:isCatalogueOf</a>
    /// </summary>
    let isCatalogueOf = _prefixId.prefix "isCatalogueOf"
    /// <summary>
    ///   <para>rdfs:label : is day of week of rdfs:label : è giorno della settimana di </para>
    ///   <para>rdfs:comment : Proprietà inversa di "ha giorno della settimana".rdfs:comment : Inverse property of has day of week.</para>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <a href="http://dati.beniculturali.it/cis/isDayOfWeekOf">cis:isDayOfWeekOf</a>
    /// </summary>
    let isDayOfWeekOf = _prefixId.prefix "isDayOfWeekOf"
    /// <summary>
    ///   <para>rdfs:label : is described byrdfs:label : è descritto da</para>
    ///   <para>rdfs:comment : Inverse property of "describes"rdfs:comment : Proprietà inversa di "descrive"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isDescribedBy">cis:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : is held byrdfs:label : è svolto da</para>
    ///   <para>rdfs:comment : Inverse property of "holds a role in time"rdfs:comment : Proprietà inversa di "ha un ruolo nel tempo"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isHeldBy">cis:isHeldBy</a>
    /// </summary>
    let isHeldBy = _prefixId.prefix "isHeldBy"
    /// <summary>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:comment : This property is the inverse of "hosts" and links the Event to the Site of the Cultural Institute or Siterdfs:comment : Questa proprietà è l'inversa di "ospita" e collega un evento a una sede di un istituto e luogo della cultura</para>
    ///   <para>rdfs:label : is hosted byrdfs:label : è ospitato da</para>
    ///   <a href="http://dati.beniculturali.it/cis/isHostedBy">cis:isHostedBy</a>
    /// </summary>
    let isHostedBy = _prefixId.prefix "isHostedBy"
    /// <summary>
    ///   <para>rdfs:label : è nella sederdfs:label : is in site</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare  opere culturali al luogo fisico in cui sono conservate.rdfs:comment : Property that permits to associate cultural heritage objects with the site(s) which conserve(s) them</para>
    ///   <a href="http://dati.beniculturali.it/cis/isInSite">cis:isInSite</a>
    /// </summary>
    let isInSite = _prefixId.prefix "isInSite"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è coinvolto in progettordfs:label : is involved in a project</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per rappresentare una relazione di coinvolgimento tra l'istituto e luogo della cultura e un progetto.rdfs:comment : Property used to represent an involvement relationship between a cultural institute or site and a project</para>
    ///   <a href="http://dati.beniculturali.it/cis/isInvolvedInProject">cis:isInvolvedInProject</a>
    /// </summary>
    let isInvolvedInProject = _prefixId.prefix "isInvolvedInProject"
    /// <summary>
    ///   <para>rdfs:comment : Inverse property of hasMember.rdfs:comment : Proprietà inversa di hasMember.</para>
    ///   <para>rdfs:label : è membro di rdfs:label : is member of </para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/isMemberOf">cis:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:comment : This object property is meant to link a cultural institute or site with itself. This can be used to represent all those cases in which a institute or site can be part of another general institute or site. This property can be effectively used in the cases of Sections of the Central Archive.rdfs:comment : Questa proprietà è utilizzata per connettere, con una relazione "essere parte di", un istituto e luogo della cultura a se stesso. In particolare, tale proprietà può essere efficacemente usata per rappresentare sezioni dell'Archivio di Stato (sezione dell'Archivio di Spoleto che è parte dell'Archivio di Stato)</para>
    ///   <para>owl:versionInfo : non stabileowl:versionInfo : unstable</para>
    ///   <para>rdfs:label : è parte dirdfs:label : is part of</para>
    ///   <a href="http://dati.beniculturali.it/cis/isPartOf">cis:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : is provided byrdfs:label : è fornito da</para>
    ///   <para>rdfs:comment : Inverse property of "provides service"rdfs:comment : Proprietà inversa di "fornisce servizio"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isProvidedBy">cis:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    /// <summary>
    ///   <para>rdfs:label : is related to role in timerdfs:label : è relativo a ruolo nel tempo</para>
    ///   <para>rdfs:comment : inverse property for "roleFor"rdfs:comment : proprietà inversa di "ruolo per"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isRelatedToRiT">cis:isRelatedToRiT</a>
    /// </summary>
    let isRelatedToRiT = _prefixId.prefix "isRelatedToRiT"
    /// <summary>
    ///   <para>rdfs:label : is role inrdfs:label : è ruolo in</para>
    ///   <para>rdfs:comment : Inverse property of "with role"rdfs:comment : Proprietà inversa di "con ruolo"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isRoleIn">cis:isRoleIn</a>
    /// </summary>
    let isRoleIn = _prefixId.prefix "isRoleIn"
    /// <summary>
    ///   <para>rdfs:label : è contenitore fisico dirdfs:label : is site ofrdfs:label : è sede di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Inverse property of "has Site"rdfs:comment : Proprietà inversa di "ha sede".</para>
    ///   <a href="http://dati.beniculturali.it/cis/isSiteOf">cis:isSiteOf</a>
    /// </summary>
    let isSiteOf = _prefixId.prefix "isSiteOf"
    /// <summary>
    ///   <para>rdfs:label : is sub-event ofrdfs:label : è sotto evento di</para>
    ///   <para>rdfs:comment : Inverse Property of "has sub event"rdfs:comment : Proprietà inversa di "ha sotto eventi"</para>
    ///   <a href="http://dati.beniculturali.it/cis/isSubEventOf">cis:isSubEventOf</a>
    /// </summary>
    let isSubEventOf = _prefixId.prefix "isSubEventOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is subject ofrdfs:label : è soggetto di</para>
    ///   <para>rdfs:comment : Inverse propery of "is about".rdfs:comment : Proprietà inversa di "tratta di".</para>
    ///   <a href="http://dati.beniculturali.it/cis/isSubjectOf">cis:isSubjectOf</a>
    /// </summary>
    let isSubjectOf = _prefixId.prefix "isSubjectOf"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Property used to associate the situation name in time with a temporal validity intervalrdfs:comment : Proprietà usata per associare la situzione "nome nel tempo", ovvero una denominazione valida in un certo arco temporale, a un intervallo temporale di validità</para>
    ///   <para>rdfs:label : is valid duringrdfs:label : è valido durante</para>
    ///   <a href="http://dati.beniculturali.it/cis/isValidDuring">cis:isValidDuring</a>
    /// </summary>
    let isValidDuring = _prefixId.prefix "isValidDuring"
    /// <summary>
    ///   <para>rdfs:label : makes available equipmentrdfs:label : rende disponibile attrezzatura</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare l'istituto e luogo della cultura alle attrezzature da esso possedute.rdfs:comment : Property that permits to associate the Cultural Institute or Site with its own equipment</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/makesAvailableEquipment">cis:makesAvailableEquipment</a>
    /// </summary>
    let makesAvailableEquipment = _prefixId.prefix "makesAvailableEquipment"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate a name with an event and a projectrdfs:comment : Proprietà utilizzata per associare un nome all'evento o al progetto</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:label : namerdfs:label : nome</para>
    ///   <a href="http://dati.beniculturali.it/cis/name">cis:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : offersrdfs:label : offre</para>
    ///   <para>rdfs:comment : Property used to associate an agent with an offer for accessing an event or a cultural institute or siterdfs:comment : Proprietà che consente di associare un agente all'offerta per l'accesso a un evento o a un luogo della cultura.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <a href="http://dati.beniculturali.it/cis/offers">cis:offers</a>
    /// </summary>
    let offers = _prefixId.prefix "offers"
    /// <summary>
    ///   <para>rdfs:label : apre rdfs:label : opens </para>
    ///   <para>owl:versionInfo : non stabileowl:versionInfo : unstable</para>
    ///   <para>rdfs:comment : This property is used to represent the opening timerdfs:comment : Questa proprietà è utilizzata per rappresentare l'orario di apertura</para>
    ///   <a href="http://dati.beniculturali.it/cis/opens">cis:opens</a>
    /// </summary>
    let opens = _prefixId.prefix "opens"
    /// <summary>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Property used to represent the post code of the address of the site of a cultural institute or site.rdfs:comment : Proprietà utilizzata per rappresentare il codice postale.</para>
    ///   <para>rdfs:label : codice postalerdfs:label : post code</para>
    ///   <a href="http://dati.beniculturali.it/cis/postCode">cis:postCode</a>
    /// </summary>
    let postCode = _prefixId.prefix "postCode"
    /// <summary>
    ///   <para>rdfs:comment : Property used to represent the key postal division of the address of the site of the cultural institute or site, usually the city. (INSPIRE's definition is 'One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points.'). rdfs:comment : Proprietà utilizzata per rappresentare la divisione postale principale dell'indirizzo della sede dell'istituto e del luogo della cultura, di solito una città.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:label : nome divisione postalerdfs:label : post name</para>
    ///   <a href="http://dati.beniculturali.it/cis/postName">cis:postName</a>
    /// </summary>
    let postName = _prefixId.prefix "postName"
    /// <summary>
    ///   <para>rdfs:label : fornisce servizirdfs:label : provides Service</para>
    ///   <para>rdfs:comment : Property used to represent a supply service relationship between a cultural institute or site and a service.rdfs:comment : Proprietà utilizzata per rappresentare una relazione di fornitura di servizi da parte di un istituto e luogo della cultura.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <a href="http://dati.beniculturali.it/cis/providesService">cis:providesService</a>
    /// </summary>
    let providesService = _prefixId.prefix "providesService"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : reports tordfs:label : riporta a</para>
    ///   <para>rdfs:comment : Questa proprietà consente di rappresentare una relazione di appartenenza di un agente a un altro agente. Per esempio la relazione può essere utilizzata per poter esprimere che un certo responsabile di un istituto e luogo della cultura agisce per conto di una specifica organizzazione.rdfs:comment : This property permits to represent a general belonging relationship of an agent. For instance, the property can be used to represent the case in which an agent with Role responsible acts on the cultural Istitute or site on behalf of an Organization to which (s)he belongs.</para>
    ///   <a href="http://dati.beniculturali.it/cis/reportsTo">cis:reportsTo</a>
    /// </summary>
    let reportsTo = _prefixId.prefix "reportsTo"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proprietà che consente di associare la situazione ruolo nel tempo esercitato da un agente al relativo istituto e luogo della cultura. La stessa proprietà è utilizzata in modo analogo per associare ruolo nel tempo all'evento.rdfs:comment : Property used to associate the situation role in time played by an agent with the relative cultural institute or site. The same property is used in a similar way to associate role in time with an event</para>
    ///   <para>rdfs:label : role forrdfs:label : ruolo per</para>
    ///   <a href="http://dati.beniculturali.it/cis/roleFor">cis:roleFor</a>
    /// </summary>
    let roleFor = _prefixId.prefix "roleFor"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Data di inizio di un intervella temporalerdfs:comment : Srart date of a Time Interval</para>
    ///   <para>rdfs:label : start Daterdfs:label : Data di inizio</para>
    ///   <a href="http://dati.beniculturali.it/cis/startDate">cis:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:label : takes place duringrdfs:label : si tiene durante</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Proprietà utilizzata per associare un evento a un intervallo temporale entro cui l'evento ha luogo.rdfs:comment : Property used to associate an event with a temporal interval within which the event takes place</para>
    ///   <a href="http://dati.beniculturali.it/cis/takesPlaceDuring">cis:takesPlaceDuring</a>
    /// </summary>
    let takesPlaceDuring = _prefixId.prefix "takesPlaceDuring"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Proprietà che rappresenta il toponimo dell'area geografica.rdfs:comment : This property represents the toponym of a geographical area.</para>
    ///   <para>rdfs:label : toponimordfs:label : toponym</para>
    ///   <a href="http://dati.beniculturali.it/cis/toponym">cis:toponym</a>
    /// </summary>
    let toponym = _prefixId.prefix "toponym"
    /// <summary>
    ///   <para>owl:versionInfo : versione non definitivaowl:versionInfo : unstable</para>
    ///   <para>rdfs:comment : Thi property represents an URL.rdfs:comment : Questa proprietà rappresenta un URL</para>
    ///   <para>rdfs:label : urlrdfs:label : url</para>
    ///   <a href="http://dati.beniculturali.it/cis/url">cis:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:comment : Property used to associate the situation role in time with the role itselfrdfs:comment : Proprietà che consente di associare la situazione ruolo nel tempo con il ruolo stesso.</para>
    ///   <para>owl:versionInfo : stable^^xsd:stringowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : con ruolordfs:label : with Role</para>
    ///   <a href="http://dati.beniculturali.it/cis/withRole">cis:withRole</a>
    /// </summary>
    let withRole = _prefixId.prefix "withRole"

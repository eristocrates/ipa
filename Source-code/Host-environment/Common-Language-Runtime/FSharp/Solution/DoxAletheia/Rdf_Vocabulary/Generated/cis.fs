namespace http.dati.beniculturali.it.cis.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cis =
    let _namespace_iri = Namespace_Iri cis |> NamespaceIRI
    /// <summary>
    ///   <para>cis:fullAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per indicare l'indirizzo completo della sede di un istituto e luogo della cultura.</para>
    ///   <para>Property used to represent the full address of the site of a cultural institute or site.</para>
    /// labels<para>indirizzo completo</para><para>full address</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/fullAddress">http://dati.beniculturali.it/cis/fullAddress</seealso>
    let fullAddress = Prefixed_Name(cis, "fullAddress") |> PrefixedName
    /// <summary>
    ///   <para>cis:postName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent the key postal division of the address of the site of the cultural institute or site, usually the city. (INSPIRE's definition is 'One or more names created and maintained for postal purposes to identify a subdivision of addresses and postal delivery points.'). </para>
    ///   <para>Proprietà utilizzata per rappresentare la divisione postale principale dell'indirizzo della sede dell'istituto e del luogo della cultura, di solito una città.</para>
    /// labels<para>nome divisione postale</para><para>post name</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/postName">http://dati.beniculturali.it/cis/postName</seealso>
    let postName = Prefixed_Name(cis, "postName") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/admissionType.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/admissionType.png">http://dati.beniculturali.it/cis/img/admissionType.png</seealso>
    let ``img/admissionType.png`` =
        Prefixed_Name(cis, "img/admissionType.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasAccessCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the Cultural Institute or Site or the Event with its access condition information</para>
    ///   <para>Proprietà utilizzata per associare l'istituto e luogo della cultura o l'evento con le condizioni di accesso.</para>
    /// labels<para>ha condizioni di accesso</para><para>has access condition</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasAccessCondition">http://dati.beniculturali.it/cis/hasAccessCondition</seealso>
    let hasAccessCondition = Prefixed_Name(cis, "hasAccessCondition") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasTicket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà inversa di "per accedere a"</para>
    ///   <para>Inverse property of "for access to"</para>
    /// labels<para>ha biglietto</para><para>has ticket</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasTicket">http://dati.beniculturali.it/cis/hasTicket</seealso>
    let hasTicket = Prefixed_Name(cis, "hasTicket") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property which links a cultural insttiute or site to its contact points. The same property is used to link in a similar way the event to its contact points and to link the site of the cultural institute or site with its contact points</para>
    ///   <para>Proprietà che collega un istituto e luogo della cultura ai propri punti di contatto. La stessa proprietà è utilizzata in maniera analoga per collegare il luogo fisico con i propri punti di contatto, ad anche per collegare un evento ai propri contatti</para>
    /// labels<para>ha punto di contatto</para><para>has contact point</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasContactPoint">http://dati.beniculturali.it/cis/hasContactPoint</seealso>
    let hasContactPoint = Prefixed_Name(cis, "hasContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che permette di associare all&amp;apos;istituto e luogo della cultura la categoria a cui esso è tipicamente associato (es. archeologia, etnografia e antropologia, arte, ...).</para>
    ///   <para>Property used to associate the Cultural Institute or Site with its own field of knowledge</para>
    /// labels<para>has discipline</para><para>ha categoria</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasDiscipline">http://dati.beniculturali.it/cis/hasDiscipline</seealso>
    let hasDiscipline = Prefixed_Name(cis, "hasDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>cis:img/access.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/access.png">http://dati.beniculturali.it/cis/img/access.png</seealso>
    let ``img/access.png`` = Prefixed_Name(cis, "img/access.png") |> PrefixedName
    /// <summary>
    ///   <para>cis:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un evento culturale.</para>
    ///   <para>it represents an event that typically is related to the cultural domain</para>
    /// labels<para>Evento</para><para>Event</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Event">http://dati.beniculturali.it/cis/Event</seealso>
    let Event = Prefixed_Name(cis, "Event") |> PrefixedName
    /// <summary>
    ///   <para>cis:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of "describes"</para>
    ///   <para>Proprietà inversa di "descrive"</para>
    /// labels<para>is described by</para><para>è descritto da</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isDescribedBy">http://dati.beniculturali.it/cis/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(cis, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasTelephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>proprietà utilizzata per rappresentare uno o più numeri di telefono per il punto di contatto</para>
    ///   <para>Property used to represent one or more telephone numbers for the contact point</para>
    /// labels<para>has telephone</para><para>ha telefono</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasTelephone">http://dati.beniculturali.it/cis/hasTelephone</seealso>
    let hasTelephone = Prefixed_Name(cis, "hasTelephone") |> PrefixedName
    /// <summary>
    ///   <para>cis:Theatre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>cis:CISType</para>
    ///   <para>This class represents a cultural institute or site of type Theatre</para>
    ///   <para>Questa classe rappresenta un istituto e luogo della cultura di tipo Teatro</para>
    /// labels<para>Theatre</para><para>Teatro</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Theatre">http://dati.beniculturali.it/cis/Theatre</seealso>
    let Theatre = Prefixed_Name(cis, "Theatre") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega la specifica del prezzo del ticket per un evento o istituto e luogo della cultura con la classe currency</para>
    ///   <para>This property is used to connected the Price specification to Currency</para>
    /// labels<para>has currency</para><para>ha valuta</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasCurrency">http://dati.beniculturali.it/cis/hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(cis, "hasCurrency") |> PrefixedName
    /// <summary>
    ///   <para>cis:2.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/2.0">http://dati.beniculturali.it/cis/2.0</seealso>
    let ``_2.0`` = Prefixed_Name(cis, "2.0") |> PrefixedName
    /// <summary>
    ///   <para>cis:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the situation role in time with a temporal interval. The same property is used in a similar way to link a site or a collection to a temporal interval</para>
    ///   <para>Proprietà che consente di associare un ruolo nel tempo a un intervallo temporale. La stessa proprietà è utilizzata in maniera analoga per associare una collezione a un intervallo temporale.</para>
    /// labels<para>al tempo</para><para>at time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/atTime">http://dati.beniculturali.it/cis/atTime</seealso>
    let atTime = Prefixed_Name(cis, "atTime") |> PrefixedName

    /// <summary>
    ///   <para>cis:CulturalHeritageObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un bene, materiale o immateriale, del patrimonio culturale.</para>
    ///   <para>It represents a cultural asset (even intagible) of the cultural heritage.</para>
    /// labels<para>Cultural Heritage Object</para><para>Oggetto Culturale</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CulturalHeritageObject">http://dati.beniculturali.it/cis/CulturalHeritageObject</seealso>
    let CulturalHeritageObject =
        Prefixed_Name(cis, "CulturalHeritageObject") |> PrefixedName

    /// <summary>
    ///   <para>cis:CulturalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that provides a generalization of three classes; that is , cultural institute or site, collection and cultural heritage object. It does not correspond to a concept used typically in the cultural domain but it is used in order to model properties and property restrictions that are common to all the these three classes. The class will never be directly instanziated.</para>
    ///   <para>Classe che fornisce una generalizzazione per le tre classi di istituto e luogo della cultura,  collezione e oggetto culturale. Non corrisponde ad un concetto usato normalmente nel linguaggio del dominio, ma risponde all'esigenza di modellare proprietà e assiomi di property-restriction comuni ad ognuna di queste tre classi. La classe CulturalEntity non sarà mai istanziata direttamente</para>
    /// labels<para>Entità culturale</para><para>Cultural Entity</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CulturalEntity">http://dati.beniculturali.it/cis/CulturalEntity</seealso>
    let CulturalEntity = Prefixed_Name(cis, "CulturalEntity") |> PrefixedName
    /// <summary>
    ///   <para>cis:SiteDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permits to represents a description of a site of the cultural institute or site (for instance, the site has a total space available XXX, and a shelving that consists of a set of XX X shelves, etc.)</para>
    ///   <para>Permette di rappresentare una descrizione della sede fisica dell'istituto e luogo della cultura (per esempio, la sede ha una metratura complessiva di XX mq suddivisa in metratura al pubblico e una scaffalatura complessiva di n. YYY).</para>
    /// labels<para>Descrizione della sede</para><para>Site Description</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/SiteDescription">http://dati.beniculturali.it/cis/SiteDescription</seealso>
    let SiteDescription = Prefixed_Name(cis, "SiteDescription") |> PrefixedName
    /// <summary>
    ///   <para>cis:Address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un indirizzo così come descritto nelle specifiche della direttiva Europea INSPIRE https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538.</para>
    ///   <para>It represents an address as defined by the specifications of the EU INSPIRE directive https://inspire-twg.jrc.ec.europa.eu/inspire-fc.html#_C2538</para>
    /// labels<para>Indirizzo</para><para>Address</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Address">http://dati.beniculturali.it/cis/Address</seealso>
    let Address = Prefixed_Name(cis, "Address") |> PrefixedName
    /// <summary>
    ///   <para>cis:adminUnitL1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent the uppermost administrative unit for the address of the site of the cultural institute or site, almost always a country.</para>
    ///   <para>Proprietà utilizzata per l'unità amministrativa di più alto livello dell'indirizzo della sede di un istituto e luogo della cultura.</para>
    /// labels<para>unità amministrativa di livello 1</para><para>administrative unit level 1</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/adminUnitL1">http://dati.beniculturali.it/cis/adminUnitL1</seealso>
    let adminUnitL1 = Prefixed_Name(cis, "adminUnitL1") |> PrefixedName
    /// <summary>
    ///   <para>cis:postCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent the post code of the address of the site of a cultural institute or site.</para>
    ///   <para>Proprietà utilizzata per rappresentare il codice postale.</para>
    /// labels<para>codice postale</para><para>post code</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/postCode">http://dati.beniculturali.it/cis/postCode</seealso>
    let postCode = Prefixed_Name(cis, "postCode") |> PrefixedName
    /// <summary>
    ///   <para>cis:img/address.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/address.png">http://dati.beniculturali.it/cis/img/address.png</seealso>
    let ``img/address.png`` = Prefixed_Name(cis, "img/address.png") |> PrefixedName
    /// <summary>
    ///   <para>cis:addressID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Proprietà utilizzata per rappresentare un identificatore univoco per ciascuna istanza di un indirizzo, Rappresenta un elemento cruciale delle specifiche INSPIRE. Sottoproprietà di identificativo.</para>
    ///   <para>Property used to represent the globally unique identifier for each instance of an address. A crucial part of the INSPIRE data specifications. Subproperty of identifier.</para>
    /// labels<para>identificativo dell'indirizzo</para><para>address identifier</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/addressID">http://dati.beniculturali.it/cis/addressID</seealso>
    let addressID = Prefixed_Name(cis, "addressID") |> PrefixedName
    /// <summary>
    ///   <para>cis:adminUnitL2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per rappresentare l'unità amministrativa di livello 2 dell'indirizzo della sede di un istituto e luogo della cultura, di solito uno stato, una contea o ogni altra area che tipicamente ricomprende diverse località.</para>
    ///   <para>Property used to represent the region of the address of the site of a cultural institute or site, usually a county, state or other such area that typically encompasses several localities.</para>
    /// labels<para>unità amministrativa di livello 2</para><para>administrative unit level 2</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/adminUnitL2">http://dati.beniculturali.it/cis/adminUnitL2</seealso>
    let adminUnitL2 = Prefixed_Name(cis, "adminUnitL2") |> PrefixedName
    /// <summary>
    ///   <para>cis:isSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse propery of "is about".</para>
    ///   <para>Proprietà inversa di "tratta di".</para>
    /// labels<para>is subject of</para><para>è soggetto di</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isSubjectOf">http://dati.beniculturali.it/cis/isSubjectOf</seealso>
    let isSubjectOf = Prefixed_Name(cis, "isSubjectOf") |> PrefixedName
    /// <summary>
    ///   <para>cis:CultReseachCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>cis:CISType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This class represents cultural institutions that form so-called cultural research and promotion centers.</para>
    ///   <para>Questa classe rappresenta istituti culturali che costituiscono centri di ricerca e di promozione culturale.</para>
    /// labels<para>Centri di ricerca e promozione culturale</para><para>Cultural Reseach and Promotion Center</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CultReseachCenter">http://dati.beniculturali.it/cis/CultReseachCenter</seealso>
    let CultReseachCenter = Prefixed_Name(cis, "CultReseachCenter") |> PrefixedName
    /// <summary>
    ///   <para>cis:AdmissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta il tipo di apertura al pubblico. Esempi sono: Settimanale, Mensile, Giornaliera, ecc.</para>
    ///   <para>It represents the type of admission. Examples are: weekly, monthly, daily, etc. </para>
    /// labels<para>Tipo di apertura</para><para>Admission Type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/AdmissionType">http://dati.beniculturali.it/cis/AdmissionType</seealso>
    let AdmissionType = Prefixed_Name(cis, "AdmissionType") |> PrefixedName
    /// <summary>
    ///   <para>cis:Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:MeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Week">http://dati.beniculturali.it/cis/Week</seealso>
    let Week = Prefixed_Name(cis, "Week") |> PrefixedName
    /// <summary>
    ///   <para>cis:ISILIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare l'identificativo univoco dell'Istituto e luogo della cultura, i.e., il codice ISIL (International Standard identifier for Libraries and Related Organization). Sotto proprietà di identificativo.</para>
    ///   <para>This property is used to define the unique identifier of the cultural institute or site (i.e., the ISIL - International Standard Identifier for Libriaries and Related Organization - code). Subproperty of identifier.</para>
    /// labels<para>Identificativo ISIL</para><para>ISIL identifier</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ISILIdentifier">http://dati.beniculturali.it/cis/ISILIdentifier</seealso>
    let ISILIdentifier = Prefixed_Name(cis, "ISILIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>cis:SubjectDiscipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents a a field of knowledge or human activity. This can be defined in a controlled vocabulary. Examples can be: Modern Art, Ancient History, Ethnografy, etc.</para>
    ///   <para>Rappresenta un certo ambito della conoscenza o dell'attività umana. Tale ambito è preferibilmente modellato mediante un vocabolario controllato. Esempi: arte contemporanea, storia antica, etnografia, ecc.</para>
    /// labels<para>Categoria prevalente</para><para>Subject Discipline</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/SubjectDiscipline">http://dati.beniculturali.it/cis/SubjectDiscipline</seealso>
    let SubjectDiscipline = Prefixed_Name(cis, "SubjectDiscipline") |> PrefixedName
    /// <summary>
    ///   <para>cis:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la valuta per i biglietti di ingresso agli eventi o luoghi della cultura. Nel nostro dominio è associata alla descrizione del prezzo per i biglietti. Assume valori specifici (e.g., Euro).</para>
    ///   <para>This class represents a currency. In our domain currency is typically associated with Price Specification for tickets, and assumes specific values (e.g., Euro).</para>
    /// labels<para>Currency</para><para>Valuta</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Currency">http://dati.beniculturali.it/cis/Currency</seealso>
    let Currency = Prefixed_Name(cis, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>cis:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:MeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Day">http://dati.beniculturali.it/cis/Day</seealso>
    let Day = Prefixed_Name(cis, "Day") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/openingHoursSpecification.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/openingHoursSpecification.png">http://dati.beniculturali.it/cis/img/openingHoursSpecification.png</seealso>
    let ``img/openingHoursSpecification.png`` =
        Prefixed_Name(cis, "img/openingHoursSpecification.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property is used to indicate a description of the cultural institute or site</para>
    ///   <para>Questa proprietà è utilizzata per indicare una descrizione dell'istituto e luogo della cultura</para>
    /// labels<para>descrizione</para><para>description</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/description">http://dati.beniculturali.it/cis/description</seealso>
    let description = Prefixed_Name(cis, "description") |> PrefixedName
    /// <summary>
    ///   <para>cis:holdsRoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà utilizzata per associare un agente alla situazione "ruolo nel tempo", ovvero ad un determinato ruolo ricoperto dall'agente stesso in un deteminato arco temporale</para>
    ///   <para>Property used to associate an agent with the situation role in time the agent can play</para>
    /// labels<para>detiene un ruolo nel tempo</para><para>holds role in time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/holdsRoleInTime">http://dati.beniculturali.it/cis/holdsRoleInTime</seealso>
    let holdsRoleInTime = Prefixed_Name(cis, "holdsRoleInTime") |> PrefixedName
    /// <summary>
    ///   <para>cis:RoleInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept used to represent a situation in which a role can vary in time. In this specific domain, it is the role of an agent played on a Cultural Institute or Site.</para>
    ///   <para>Concetto utilizzato per rappresentare una situazione relativa a un ruolo che evolve nel tempo. Nel caso specifico il ruolo è esercitato da un agente su un istituto e luogo della cultura.</para>
    /// labels<para>Ruolo Nel Tempo</para><para>Role in Time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/RoleInTime">http://dati.beniculturali.it/cis/RoleInTime</seealso>
    let RoleInTime = Prefixed_Name(cis, "RoleInTime") |> PrefixedName
    /// <summary>
    ///   <para>cis:ArchaeologicalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>cis:CISType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>It represents a specific type of Cultural Institute or SIte; that is, ArchaeologicalArea</para>
    ///   <para>Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Area archeologica.</para>
    /// labels<para>Archaeological Area</para><para>Area Archeologica</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ArchaeologicalArea">http://dati.beniculturali.it/cis/ArchaeologicalArea</seealso>
    let ArchaeologicalArea = Prefixed_Name(cis, "ArchaeologicalArea") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasSubEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to describe large events to which single sub events refer. For instance, a large event can be the first world war centenary to which single events celebrating the 100th anniversary refer</para>
    ///   <para>Proprietà utilizzata per rappresentare grandi eventi che hanno singoli eventi che ad esso fanno riferimento. Ad esempio, un grande evento può essere il centenario della prima guerra mondiale a cui fanno riferimento una serie di eventi singoli.</para>
    /// labels<para>ha sotto eventi</para><para>has sub event</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasSubEvent">http://dati.beniculturali.it/cis/hasSubEvent</seealso>
    let hasSubEvent = Prefixed_Name(cis, "hasSubEvent") |> PrefixedName
    /// <summary>
    ///   <para>cis:isSubEventOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse Property of "has sub event"</para>
    ///   <para>Proprietà inversa di "ha sotto eventi"</para>
    /// labels<para>è sotto evento di</para><para>is sub-event of</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isSubEventOf">http://dati.beniculturali.it/cis/isSubEventOf</seealso>
    let isSubEventOf = Prefixed_Name(cis, "isSubEventOf") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/geographicalArea.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/geographicalArea.png">http://dati.beniculturali.it/cis/img/geographicalArea.png</seealso>
    let ``img/geographicalArea.png`` =
        Prefixed_Name(cis, "img/geographicalArea.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:toponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents the toponym of a geographical area.</para>
    ///   <para>Proprietà che rappresenta il toponimo dell'area geografica.</para>
    /// labels<para>toponimo</para><para>toponym</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/toponym">http://dati.beniculturali.it/cis/toponym</seealso>
    let toponym = Prefixed_Name(cis, "toponym") |> PrefixedName
    /// <summary>
    ///   <para>cis:geoMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property is used to represent the methodology used for the georeferentiation.</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare il metodo della georeferenziazione. Essa può essere i valori "approssimata" ed "esatta".</para>
    /// labels<para>metodologia di georeferenziazione</para><para>georeferentiation methodology</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/geoMethodology">http://dati.beniculturali.it/cis/geoMethodology</seealso>
    let geoMethodology = Prefixed_Name(cis, "geoMethodology") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasLat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per associare la latitudine a un punto</para>
    ///   <para>Property used to associate a latitude with a Point</para>
    /// labels<para>ha latitudine</para><para>has latitude</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasLat">http://dati.beniculturali.it/cis/hasLat</seealso>
    let hasLat = Prefixed_Name(cis, "hasLat") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasLong</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per associare la longitudine a un punto</para>
    ///   <para>Property used to associate the longitude with a Point</para>
    /// labels<para>ha longitudine</para><para>has longitude</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasLong">http://dati.beniculturali.it/cis/hasLong</seealso>
    let hasLong = Prefixed_Name(cis, "hasLong") |> PrefixedName
    /// <summary>
    ///   <para>cis:HolderOfArchive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cis:CISType</para>
    ///   <para>Questa classe rappresenta una specifica tipologia di istituto e luogo della cultura, i.e., Archivio</para>
    ///   <para>This class represents a specific tyep of cultural institute or site, i.e.,  Holder of Archive</para>
    /// labels<para>Conservatore di archivi</para><para>Holder of Archives</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/HolderOfArchive">http://dati.beniculturali.it/cis/HolderOfArchive</seealso>
    let HolderOfArchive = Prefixed_Name(cis, "HolderOfArchive") |> PrefixedName
    /// <summary>
    ///   <para>cis:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:MeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Hour">http://dati.beniculturali.it/cis/Hour</seealso>
    let Hour = Prefixed_Name(cis, "Hour") |> PrefixedName
    /// <summary>
    ///   <para>cis:ImageObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare un file immagine.</para>
    ///   <para>Concept used to represent an image file.</para>
    /// labels<para>Oggetto immagine</para><para>Image Object</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ImageObject">http://dati.beniculturali.it/cis/ImageObject</seealso>
    let ImageObject = Prefixed_Name(cis, "ImageObject") |> PrefixedName
    /// <summary>
    ///   <para>cis:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:DayOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Lunedì </para><para>Monday </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Monday">http://dati.beniculturali.it/cis/Monday</seealso>
    let Monday = Prefixed_Name(cis, "Monday") |> PrefixedName
    /// <summary>
    ///   <para>cis:MonumentalArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>cis:CISType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Complesso Monumentale.</para>
    ///   <para>It represents a specific type of Cultural Institute or Site; that is, Monumental Area</para>
    /// labels<para>Monumental Area or Complex</para><para>Complesso Monumentale</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/MonumentalArea">http://dati.beniculturali.it/cis/MonumentalArea</seealso>
    let MonumentalArea = Prefixed_Name(cis, "MonumentalArea") |> PrefixedName
    /// <summary>
    ///   <para>cis:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:CISType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta uno specifico tipo di istituto e luogo della cultura ovvero museo.</para>
    ///   <para>It represents a specific type of Cultural Institute or Site; that is, Museum</para>
    /// labels<para>Museum</para><para>Museo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Museum">http://dati.beniculturali.it/cis/Museum</seealso>
    let Museum = Prefixed_Name(cis, "Museum") |> PrefixedName
    /// <summary>
    ///   <para>cis:isValidDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà usata per associare la situzione "nome nel tempo", ovvero una denominazione valida in un certo arco temporale, a un intervallo temporale di validità</para>
    ///   <para>Property used to associate the situation name in time with a temporal validity interval</para>
    /// labels<para>è valido durante</para><para>is valid during</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isValidDuring">http://dati.beniculturali.it/cis/isValidDuring</seealso>
    let isValidDuring = Prefixed_Name(cis, "isValidDuring") |> PrefixedName
    /// <summary>
    ///   <para>cis:altLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per associare la situazione name in time a una denominazione alternativa dell'istituto e luogo della cultura.</para>
    ///   <para>Property used to associate the situation name in time with the alternative name of the cultural institute or site</para>
    /// labels<para>nome alternativo dell'istituto e luogo della cultura</para><para>alternative label</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/altLabel">http://dati.beniculturali.it/cis/altLabel</seealso>
    let altLabel = Prefixed_Name(cis, "altLabel") |> PrefixedName
    /// <summary>
    ///   <para>cis:NewsArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept used to represent a news article.</para>
    ///   <para>Concetto utilizzato per rappresentare un articolo</para>
    /// labels<para>News Article</para><para> Articolo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/NewsArticle">http://dati.beniculturali.it/cis/NewsArticle</seealso>
    let NewsArticle = Prefixed_Name(cis, "NewsArticle") |> PrefixedName
    /// <summary>
    ///   <para>cis:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare  offerte (riduzioni per specifiche categorie di utenti o importo intero) relative ai biglietti d'ingresso per un istituto e luogo della cultura o per un evento.</para>
    ///   <para>It represents an offer (reduction  for specific types of users or base price) related to the entrance ticket for the Cultural Institute or Site or for the Event.</para>
    /// labels<para>Offerta</para><para>Offer</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Offer">http://dati.beniculturali.it/cis/Offer</seealso>
    let Offer = Prefixed_Name(cis, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà utilizzata per specificare una validità di un offerta o di un biglietto.</para>
    ///   <para>Property used to specify the validity of an offer or ticket.</para>
    /// labels<para>has validity</para><para>ha validità</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasValidity">http://dati.beniculturali.it/cis/hasValidity</seealso>
    let hasValidity = Prefixed_Name(cis, "hasValidity") |> PrefixedName
    /// <summary>
    ///   <para>cis:Validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta la validità di biglietti e di offerte</para>
    ///   <para>This class represents the validity for the ticket and offering.</para>
    /// labels<para>Validità</para><para>Validity</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Validity">http://dati.beniculturali.it/cis/Validity</seealso>
    let Validity = Prefixed_Name(cis, "Validity") |> PrefixedName
    /// <summary>
    ///   <para>cis:OneDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/OneDay">http://dati.beniculturali.it/cis/OneDay</seealso>
    let OneDay = Prefixed_Name(cis, "OneDay") |> PrefixedName
    /// <summary>
    ///   <para>cis:OneWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/OneWeek">http://dati.beniculturali.it/cis/OneWeek</seealso>
    let OneWeek = Prefixed_Name(cis, "OneWeek") |> PrefixedName
    /// <summary>
    ///   <para>cis:closes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare l'orario di chiusura.</para>
    ///   <para>This property is used to represent the closing time</para>
    /// labels<para>chiude </para><para>closes </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/closes">http://dati.beniculturali.it/cis/closes</seealso>
    let closes = Prefixed_Name(cis, "closes") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasDayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to specify the opening hours and in particular the days of the week.</para>
    ///   <para>Questa proprietà è utilizzata per specificare gli orari di apertura e in particolare i giorni della settimana.</para>
    /// labels<para>ha giorno della settimana </para><para>has day of week </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasDayOfWeek">http://dati.beniculturali.it/cis/hasDayOfWeek</seealso>
    let hasDayOfWeek = Prefixed_Name(cis, "hasDayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasAdmissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the opening hours specification to the admission type</para>
    ///   <para>Proprietà che consente di associare gli orari di apertura al tipo di apertura.</para>
    /// labels<para>ha tipo di apertura</para><para>has admission type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasAdmissionType">http://dati.beniculturali.it/cis/hasAdmissionType</seealso>
    let hasAdmissionType = Prefixed_Name(cis, "hasAdmissionType") |> PrefixedName
    /// <summary>
    ///   <para>cis:PriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the price specification of the ticket</para>
    ///   <para>Rappresenta la specifica del prezzo del biglietto.</para>
    /// labels<para>Price Specification</para><para>Prezzo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/PriceSpecification">http://dati.beniculturali.it/cis/PriceSpecification</seealso>
    let PriceSpecification = Prefixed_Name(cis, "PriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/priceSpecification.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/priceSpecification.png">http://dati.beniculturali.it/cis/img/priceSpecification.png</seealso>
    let ``img/priceSpecification.png`` =
        Prefixed_Name(cis, "img/priceSpecification.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasCurrencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per indicare il prezzo del biglietto.</para>
    ///   <para>Property used to represent the price of the ticket.</para>
    /// labels<para>has currency value</para><para>ha prezzo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasCurrencyValue">http://dati.beniculturali.it/cis/hasCurrencyValue</seealso>
    let hasCurrencyValue = Prefixed_Name(cis, "hasCurrencyValue") |> PrefixedName
    /// <summary>
    ///   <para>cis:QuantitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents a quantitative value.</para>
    ///   <para>Classe che rappresenta un valore quantitativo</para>
    /// labels<para>Valore quantitativo</para><para>Quantitative Value</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/QuantitativeValue">http://dati.beniculturali.it/cis/QuantitativeValue</seealso>
    let QuantitativeValue = Prefixed_Name(cis, "QuantitativeValue") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasMeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare un'unità di misura.</para>
    ///   <para>This property is used to represent a measurement unit.</para>
    /// labels<para>has measurement unit</para><para>ha unità di misura</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasMeasurementUnit">http://dati.beniculturali.it/cis/hasMeasurementUnit</seealso>
    let hasMeasurementUnit = Prefixed_Name(cis, "hasMeasurementUnit") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent a value</para>
    ///   <para>Proprietà utilizzata per rappresentare un valore</para>
    /// labels<para>ha valore</para><para>has value</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasValue">http://dati.beniculturali.it/cis/hasValue</seealso>
    let hasValue = Prefixed_Name(cis, "hasValue") |> PrefixedName

    /// <summary>
    ///   <para>cis:QuantityOfAdmissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:MeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/QuantityOfAdmissions">http://dati.beniculturali.it/cis/QuantityOfAdmissions</seealso>
    let QuantityOfAdmissions =
        Prefixed_Name(cis, "QuantityOfAdmissions") |> PrefixedName

    /// <summary>
    ///   <para>cis:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un ruolo. Esso può essere definito facendo riferimento a un vocabolario controlalto. Esempi di ruoli possono essere: ente genstore, ente competente per la tutela, proprietario, direttore, ecc.</para>
    ///   <para>It represents a role. It can be modelled using a controlled vocabulary. Examples of roles include: ManagingAuthority, AccountableAuthority, Owner, Director, etc.</para>
    /// labels<para>Ruolo</para><para>Role</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Role">http://dati.beniculturali.it/cis/Role</seealso>
    let Role = Prefixed_Name(cis, "Role") |> PrefixedName
    /// <summary>
    ///   <para>cis:isRoleIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà inversa di "con ruolo"</para>
    ///   <para>Inverse property of "with role"</para>
    /// labels<para>è ruolo in</para><para>is role in</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isRoleIn">http://dati.beniculturali.it/cis/isRoleIn</seealso>
    let isRoleIn = Prefixed_Name(cis, "isRoleIn") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/roleInTime.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/roleInTime.png">http://dati.beniculturali.it/cis/img/roleInTime.png</seealso>
    let ``img/roleInTime.png`` =
        Prefixed_Name(cis, "img/roleInTime.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:withRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the situation role in time with the role itself</para>
    ///   <para>Proprietà che consente di associare la situazione ruolo nel tempo con il ruolo stesso.</para>
    /// labels<para>con ruolo</para><para>with Role</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/withRole">http://dati.beniculturali.it/cis/withRole</seealso>
    let withRole = Prefixed_Name(cis, "withRole") |> PrefixedName
    /// <summary>
    ///   <para>cis:roleFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che consente di associare la situazione ruolo nel tempo esercitato da un agente al relativo istituto e luogo della cultura. La stessa proprietà è utilizzata in modo analogo per associare ruolo nel tempo all'evento.</para>
    ///   <para>Property used to associate the situation role in time played by an agent with the relative cultural institute or site. The same property is used in a similar way to associate role in time with an event</para>
    /// labels<para>ruolo per</para><para>role for</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/roleFor">http://dati.beniculturali.it/cis/roleFor</seealso>
    let roleFor = Prefixed_Name(cis, "roleFor") |> PrefixedName
    /// <summary>
    ///   <para>cis:isHeldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of "holds a role in time"</para>
    ///   <para>Proprietà inversa di "ha un ruolo nel tempo"</para>
    /// labels<para>è svolto da</para><para>is held by</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isHeldBy">http://dati.beniculturali.it/cis/isHeldBy</seealso>
    let isHeldBy = Prefixed_Name(cis, "isHeldBy") |> PrefixedName
    /// <summary>
    ///   <para>cis:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:DayOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Saturday</para><para>Sabato</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Saturday">http://dati.beniculturali.it/cis/Saturday</seealso>
    let Saturday = Prefixed_Name(cis, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>cis:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of "provides service"</para>
    ///   <para>Proprietà inversa di "fornisce servizio"</para>
    /// labels<para>is provided by</para><para>è fornito da</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isProvidedBy">http://dati.beniculturali.it/cis/isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(cis, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>cis:hosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate a cultural institute or site to an event</para>
    ///   <para>Proprietà usata per associare un istituto e luogo della cultura a un evento.</para>
    /// labels<para>ospita</para><para>hosts</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hosts">http://dati.beniculturali.it/cis/hosts</seealso>
    let hosts = Prefixed_Name(cis, "hosts") |> PrefixedName
    /// <summary>
    ///   <para>cis:isSiteOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà inversa di "ha sede".</para>
    ///   <para>Inverse property of "has Site"</para>
    /// labels<para>è contenitore fisico di</para><para>is site of</para><para>è sede di</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isSiteOf">http://dati.beniculturali.it/cis/isSiteOf</seealso>
    let isSiteOf = Prefixed_Name(cis, "isSiteOf") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che consente di associare un sito fisico a un indirizzo.</para>
    ///   <para>Property that permits to associate a site with an address</para>
    /// labels<para>ha indirizzo</para><para>has address</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasAddress">http://dati.beniculturali.it/cis/hasAddress</seealso>
    let hasAddress = Prefixed_Name(cis, "hasAddress") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasGeographicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate a site with a geographical area where the site is located.</para>
    ///   <para>Proprietà che consente di associare una sede di un istituto e luogo della cultura a un'area geografica in cui si trova la sede.</para>
    /// labels<para>has geographical location</para><para>ha locazione geografica</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasGeographicalLocation">http://dati.beniculturali.it/cis/hasGeographicalLocation</seealso>
    let hasGeographicalLocation =
        Prefixed_Name(cis, "hasGeographicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasSiteDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Propery that permits to associate a site of a cultural institute or site with its description.</para>
    ///   <para>Proprietà che permette di associare una descrizione alla sede dell'istituto e luogo della cultura.</para>
    /// labels<para>ha descrizione della sede</para><para>has site description</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasSiteDescription">http://dati.beniculturali.it/cis/hasSiteDescription</seealso>
    let hasSiteDescription = Prefixed_Name(cis, "hasSiteDescription") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the description of the site of the cultural institute or site an attribute (e.g., total space, shelving, etc.)</para>
    ///   <para>Proprietà che permette di associare una descrizione del sito dell'istituto e luogo della cultura a un attributo, inteso come caratteristica del sito (metratura, scaffalatura, etc)</para>
    /// labels<para>has attribute</para><para>ha attribute</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasAttribute">http://dati.beniculturali.it/cis/hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(cis, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>cis:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:DayOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Domenica</para><para>Sunday</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Sunday">http://dati.beniculturali.it/cis/Sunday</seealso>
    let Sunday = Prefixed_Name(cis, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>cis:TemporaryClosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the information on the temporary closure </para>
    ///   <para>Rappresenta le informazioni sulla chiusura temporanea</para>
    /// labels<para>Chiusura Temporanea</para><para>Temporary Closure</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/TemporaryClosure">http://dati.beniculturali.it/cis/TemporaryClosure</seealso>
    let TemporaryClosure = Prefixed_Name(cis, "TemporaryClosure") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per indicare una data della chiusura temporanea.</para>
    ///   <para>Property used to represent the date of the temporary closure.</para>
    /// labels<para>has date</para><para>ha data</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasDate">http://dati.beniculturali.it/cis/hasDate</seealso>
    let hasDate = Prefixed_Name(cis, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to describe a reason for the temporary closure.</para>
    ///   <para>Proprietà utilizzata per descrivere una motivazione della chiusura temporanea.</para>
    /// labels<para>ha motivazione</para><para>has reason</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasReason">http://dati.beniculturali.it/cis/hasReason</seealso>
    let hasReason = Prefixed_Name(cis, "hasReason") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasTemporaryClosureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the temporary closure with its type</para>
    ///   <para>Proprietà che consente di associare una chiusura temporanea al suo tipo.</para>
    /// labels<para>ha tipo di chiusura temporanea</para><para>has temporary closure type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasTemporaryClosureType">http://dati.beniculturali.it/cis/hasTemporaryClosureType</seealso>
    let hasTemporaryClosureType =
        Prefixed_Name(cis, "hasTemporaryClosureType") |> PrefixedName

    /// <summary>
    ///   <para>cis:TemporaryClosureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the type of temporary. Examples can be: closed for renovation, unfit for use, etc. </para>
    ///   <para>Rappresenta il tipo di chiusura temporanea. Per esempio: per restauro, per inagibilità, ecc. </para>
    /// labels<para>Tipo di Chiusura Temporanea</para><para>Type of Temporary Closure</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/TemporaryClosureType">http://dati.beniculturali.it/cis/TemporaryClosureType</seealso>
    let TemporaryClosureType =
        Prefixed_Name(cis, "TemporaryClosureType") |> PrefixedName

    /// <summary>
    ///   <para>cis:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cis:DayOfWeek</para>
    ///
    /// labels<para>Thursday </para><para>Giovedì </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Thursday">http://dati.beniculturali.it/cis/Thursday</seealso>
    let Thursday = Prefixed_Name(cis, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>cis:forAccessTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate a ticket with an event or a cultural institute or site</para>
    ///   <para>Proprietà che consente di associare un biglietto a un evento o a un istituto e luogo della cultura.</para>
    /// labels<para>per l'accesso a</para><para>for access to</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/forAccessTo">http://dati.beniculturali.it/cis/forAccessTo</seealso>
    let forAccessTo = Prefixed_Name(cis, "forAccessTo") |> PrefixedName
    /// <summary>
    ///   <para>cis:startDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Srart date of a Time Interval</para>
    ///   <para>Data di inizio di un intervella temporale</para>
    /// labels<para>Data di inizio</para><para>start Date</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/startDate">http://dati.beniculturali.it/cis/startDate</seealso>
    let startDate = Prefixed_Name(cis, "startDate") |> PrefixedName
    /// <summary>
    ///   <para>cis:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Data di fine di un intervallo temporale</para>
    ///   <para>end Date of a Time Interval</para>
    /// labels<para>data di fine</para><para>end Date</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/endDate">http://dati.beniculturali.it/cis/endDate</seealso>
    let endDate = Prefixed_Name(cis, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>cis:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cis:DayOfWeek</para>
    ///
    /// labels<para>Tuesday</para><para>Martedì</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Tuesday">http://dati.beniculturali.it/cis/Tuesday</seealso>
    let Tuesday = Prefixed_Name(cis, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>cis:UserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the identified type of users related to the tickets used to access an event or a Cultural Institute or Site. Examples include: people over 25 years old, people over 65 years old,  children, etc.</para>
    ///   <para>Rappresenta la tipologia di utenti relativa ai biglietti per accedere a un evento o a un istituto e luogo della cultura. Esempi includono:  "maggiorenni over 25", oppure "over 65", "bambini", ecc.</para>
    /// labels<para>Tipo di utente</para><para>User Type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/UserType">http://dati.beniculturali.it/cis/UserType</seealso>
    let UserType = Prefixed_Name(cis, "UserType") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to specify the temporal duration of the validity.</para>
    ///   <para>Questa proprietà è utilizzata per specificare il periodo temporale di validità.</para>
    /// labels<para>has duration</para><para>ha durata</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasDuration">http://dati.beniculturali.it/cis/hasDuration</seealso>
    let hasDuration = Prefixed_Name(cis, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>cis:VideoObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare materiali multimediali di tipo video.</para>
    ///   <para>Concept used to represent multimedia objects of type video.</para>
    /// labels<para>Oggetto video</para><para>Video Object</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/VideoObject">http://dati.beniculturali.it/cis/VideoObject</seealso>
    let VideoObject = Prefixed_Name(cis, "VideoObject") |> PrefixedName
    /// <summary>
    ///   <para>cis:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cis:DayOfWeek</para>
    ///
    /// labels<para>Mercoledì</para><para>Wednesday</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Wednesday">http://dati.beniculturali.it/cis/Wednesday</seealso>
    let Wednesday = Prefixed_Name(cis, "Wednesday") |> PrefixedName
    /// <summary>
    ///   <para>cis:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:MeasurementUnit</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Year">http://dati.beniculturali.it/cis/Year</seealso>
    let Year = Prefixed_Name(cis, "Year") |> PrefixedName
    /// <summary>
    ///   <para>cis:isDayOfWeekOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of has day of week.</para>
    ///   <para>Proprietà inversa di "ha giorno della settimana".</para>
    /// labels<para>è giorno della settimana di </para><para>is day of week of </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isDayOfWeekOf">http://dati.beniculturali.it/cis/isDayOfWeekOf</seealso>
    let isDayOfWeekOf = Prefixed_Name(cis, "isDayOfWeekOf") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasEligibleUser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the an offert for the access to an event or a cultural institute or site with the type of user</para>
    ///   <para>Proprietà che consente di associare un'offerta per l'accesso a un evento o a un istituto e luogo della cultura a una tipologia di utente</para>
    /// labels<para>ha utente eligibile</para><para>has eligible User</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasEligibleUser">http://dati.beniculturali.it/cis/hasEligibleUser</seealso>
    let hasEligibleUser = Prefixed_Name(cis, "hasEligibleUser") |> PrefixedName
    /// <summary>
    ///   <para>cis:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà inversa di hasMember.</para>
    ///   <para>Inverse property of hasMember.</para>
    /// labels<para>is member of </para><para>è membro di </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isMemberOf">http://dati.beniculturali.it/cis/isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(cis, "isMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà è utliizzata per collegare l'offerta per i biglietti a una specifica del prezzo.</para>
    ///   <para>This property is used to link the offer for a ticket to its price specification.</para>
    /// labels<para>has price specification </para><para>ha specifica di prezzo </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasPriceSpecification">http://dati.beniculturali.it/cis/hasPriceSpecification</seealso>
    let hasPriceSpecification =
        Prefixed_Name(cis, "hasPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>cis:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Involvment property that associates an event with a general cultural entity</para>
    ///   <para>Proprietà di coinvolgimento che associa un evento a una generica entità culturale.</para>
    /// labels<para>coinvolge</para><para>involves</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/involves">http://dati.beniculturali.it/cis/involves</seealso>
    let involves = Prefixed_Name(cis, "involves") |> PrefixedName
    /// <summary>
    ///   <para>cis:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che consente di associare un agente all'offerta per l'accesso a un evento o a un luogo della cultura.</para>
    ///   <para>Property used to associate an agent with an offer for accessing an event or a cultural institute or site</para>
    /// labels<para>offers</para><para>offre</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/offers">http://dati.beniculturali.it/cis/offers</seealso>
    let offers = Prefixed_Name(cis, "offers") |> PrefixedName
    /// <summary>
    ///   <para>cis:takesPlaceDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate an event with a temporal interval within which the event takes place</para>
    ///   <para>Proprietà utilizzata per associare un evento a un intervallo temporale entro cui l'evento ha luogo.</para>
    /// labels<para>takes place during</para><para>si tiene durante</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/takesPlaceDuring">http://dati.beniculturali.it/cis/takesPlaceDuring</seealso>
    let takesPlaceDuring = Prefixed_Name(cis, "takesPlaceDuring") |> PrefixedName
    /// <summary>
    ///   <para>cis:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents an agent. It can be an organization (public and/or private), an association/foundation or a single person. In the context of this ontology it can be a municipality, a supervision authority, a single private citizen</para>
    ///   <para>Rappresenta un agente. Esso può essere un'organizzazione (pubblica e/o privata), un'associazione/fondazione, un singolo soggetto. Per esempio, nel contesto della presente ontologia può essere utilizzato per rappresentare una soprintendenza, un comune, un singolo soggetto privato, ecc.</para>
    /// labels<para>Agente</para><para>Agent</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Agent">http://dati.beniculturali.it/cis/Agent</seealso>
    let Agent = Prefixed_Name(cis, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>cis:DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe che rappresenta l'insieme dei giorni della settimana.</para>
    ///   <para>This class represents the set of all the days of the week.</para>
    /// labels<para>Giorno della settimana </para><para>Day of the Week</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/DayOfWeek">http://dati.beniculturali.it/cis/DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(cis, "DayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>cis:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per associare un nome all'evento o al progetto</para>
    ///   <para>Property used to associate a name with an event and a project</para>
    /// labels<para>nome</para><para>name</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/name">http://dati.beniculturali.it/cis/name</seealso>
    let name = Prefixed_Name(cis, "name") |> PrefixedName
    /// <summary>
    ///   <para>cis:MeasurementUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe che rappresenta un'unità di misura</para>
    ///   <para>Class that represents a measurement unit</para>
    /// labels<para>Measurement Unit</para><para>Unità di misura</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/MeasurementUnit">http://dati.beniculturali.it/cis/MeasurementUnit</seealso>
    let MeasurementUnit = Prefixed_Name(cis, "MeasurementUnit") |> PrefixedName
    /// <summary>
    ///   <para>cis:reportsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà consente di rappresentare una relazione di appartenenza di un agente a un altro agente. Per esempio la relazione può essere utilizzata per poter esprimere che un certo responsabile di un istituto e luogo della cultura agisce per conto di una specifica organizzazione.</para>
    ///   <para>This property permits to represent a general belonging relationship of an agent. For instance, the property can be used to represent the case in which an agent with Role responsible acts on the cultural Istitute or site on behalf of an Organization to which (s)he belongs.</para>
    /// labels<para>reports to</para><para>riporta a</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/reportsTo">http://dati.beniculturali.it/cis/reportsTo</seealso>
    let reportsTo = Prefixed_Name(cis, "reportsTo") |> PrefixedName
    /// <summary>
    ///   <para>cis:CISType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta il tipo di istituto e luogo della cultura.</para>
    ///   <para>This class represents the type of cultural institute or site.</para>
    /// labels<para>Tipo di Istituto e Luogo della Cultura</para><para>Cultural Institute or Site Type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CISType">http://dati.beniculturali.it/cis/CISType</seealso>
    let CISType = Prefixed_Name(cis, "CISType") |> PrefixedName
    /// <summary>
    ///   <para>cis:ArchaeologicalPark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>cis:CISType</para>
    ///   <para>Rappresenta uno specifico tipo di Istituto e Luogo della Cultura ovvero Parco Archeologico.</para>
    ///   <para>It represents a specific type of Cultural Institute or SIte; that is, Archaeological Park</para>
    /// labels<para>Archaeological Park</para><para>Parco Archeologico</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ArchaeologicalPark">http://dati.beniculturali.it/cis/ArchaeologicalPark</seealso>
    let ArchaeologicalPark = Prefixed_Name(cis, "ArchaeologicalPark") |> PrefixedName

    /// <summary>
    ///   <para>cis:GovernamentalAdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an administrative geographical area that is typically managed by a public body. It can be a Region, a Municipality, a Province, a sub-municipality area, etc.</para>
    ///   <para>Questa classe rappresenta un'area amministrativa territoriale statale gestita tipicamente da un organismo pubblico. Essa può essere una Regione, una Provincia, un Comune, un area sub comunale, etc.</para>
    /// labels<para>Governamental Administrative Area</para><para>Area Amministrativa statale</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/GovernamentalAdministrativeArea">http://dati.beniculturali.it/cis/GovernamentalAdministrativeArea</seealso>
    let GovernamentalAdministrativeArea =
        Prefixed_Name(cis, "GovernamentalAdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasCISType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà è utilizzata per collegare un istituto e luogo della cultura alla sua tipologia.</para>
    ///   <para>The property is used to link a cultural institure or site to its type.</para>
    /// labels<para>has type</para><para>ha tipo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasCISType">http://dati.beniculturali.it/cis/hasCISType</seealso>
    let hasCISType = Prefixed_Name(cis, "hasCISType") |> PrefixedName
    /// <summary>
    ///   <para>cis:Euro</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:Currency</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Euro">http://dati.beniculturali.it/cis/Euro</seealso>
    let Euro = Prefixed_Name(cis, "Euro") |> PrefixedName
    /// <summary>
    ///   <para>cis:isHostedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is the inverse of "hosts" and links the Event to the Site of the Cultural Institute or Site</para>
    ///   <para>Questa proprietà è l'inversa di "ospita" e collega un evento a una sede di un istituto e luogo della cultura</para>
    /// labels<para>è ospitato da</para><para>is hosted by</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isHostedBy">http://dati.beniculturali.it/cis/isHostedBy</seealso>
    let isHostedBy = Prefixed_Name(cis, "isHostedBy") |> PrefixedName
    /// <summary>
    ///   <para>cis:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:DayOfWeek</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Venerdì</para><para>Friday</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Friday">http://dati.beniculturali.it/cis/Friday</seealso>
    let Friday = Prefixed_Name(cis, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà utilizzata per associare un sito alle proprie coordinate geografiche.</para>
    ///   <para>Property used to associate a site with its own geographical coordinates</para>
    /// labels<para>ha geometria</para><para>has geometry</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasGeometry">http://dati.beniculturali.it/cis/hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(cis, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>cis:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the attribute that a site description of a site of a cultural institute or site may have. For instance, length, the shelving in a library, etc.</para>
    ///   <para>Rappresenta gli attributi di una certa descrizione della sede fisica di un istituto e luogo della cultura. Per esempio, metratura, scaffalatura, ecc.</para>
    /// labels<para>Attribute</para><para>Attributo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Attribute">http://dati.beniculturali.it/cis/Attribute</seealso>
    let Attribute = Prefixed_Name(cis, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>cis:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents a geometry which is typically described by using a coordinate system related to Earth such as WGS84. It is univocally identified by lat/long</para>
    ///   <para>Rappresenta una geometria tipicamente descritto utilizzando un sistema di coordinate geografiche come per esempio WGS84. Univocamente identificato da Lat/Long</para>
    /// labels<para>Geometria</para><para>Geometry</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Geometry">http://dati.beniculturali.it/cis/Geometry</seealso>
    let Geometry = Prefixed_Name(cis, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>cis:geometryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property is used to represent the geometry type (point, line, or polygon) in the geospatial representation.</para>
    ///   <para>Questa proprietà è utilizzata per identificare il tipo di geometria (punto, linea, o poligono) nella rappresentazione geospaziale.</para>
    /// labels<para>tipo di geometria</para><para>geometry type</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/geometryType">http://dati.beniculturali.it/cis/geometryType</seealso>
    let geometryType = Prefixed_Name(cis, "geometryType") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasISTATCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare il codice ISTAT associato a un'area amministrativa statale.</para>
    ///   <para>This property is used to represent a specific code used in the Italian context for the governamental administrative areas.</para>
    /// labels<para>ha codice ISTAT</para><para>has ISTAT code</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasISTATCode">http://dati.beniculturali.it/cis/hasISTATCode</seealso>
    let hasISTATCode = Prefixed_Name(cis, "hasISTATCode") |> PrefixedName
    /// <summary>
    ///   <para>cis:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>cis:CISType</para>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta uno specifico tipo di Istituto e Luogo della Cultura, ovvero Biblioteca.</para>
    ///   <para>It represents a specific type of Cultural Institute or Site; that is, Library</para>
    /// labels<para>Biblioteca</para><para>Library</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Library">http://dati.beniculturali.it/cis/Library</seealso>
    let Library = Prefixed_Name(cis, "Library") |> PrefixedName
    /// <summary>
    ///   <para>cis:AudioObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare materiali multimediali di tipo audio.</para>
    ///   <para>Concept used to represent multimedia objects of type audio.</para>
    /// labels<para>Oggetto audio</para><para>Audio Object</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/AudioObject">http://dati.beniculturali.it/cis/AudioObject</seealso>
    let AudioObject = Prefixed_Name(cis, "AudioObject") |> PrefixedName
    /// <summary>
    ///   <para>cis:CreativeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare tutti quei materiali, multimediali (file audio, video), immagini), bibliografici, articoli di varia natura che si riferiscono e citano l'Istituto e Luogo della Cultura.</para>
    ///   <para>Concept used to represent all types of creative works such multimedia objects (audio, video, image files), bibliographic references, and different types of articles, that refer to and cite the Cultural Institute or Site</para>
    /// labels<para>Lavoro Creativo</para><para>Creative Work</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CreativeWork">http://dati.beniculturali.it/cis/CreativeWork</seealso>
    let CreativeWork = Prefixed_Name(cis, "CreativeWork") |> PrefixedName
    /// <summary>
    ///   <para>cis:Booking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the  type of booking for the cultural institute or site or for the event. Examples can be: Mandatory, Optional, None (free access).</para>
    ///   <para>Rappresenta la tipologia di prenotazione per l'istituto e luogo della cultura o per l'evento. Esempi possono essere: Obbligatoria, Facoltativa, Nessuna (ingresso libero).</para>
    /// labels<para>Tipo prenotazione</para><para>Type of Booking</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Booking">http://dati.beniculturali.it/cis/Booking</seealso>
    let Booking = Prefixed_Name(cis, "Booking") |> PrefixedName
    /// <summary>
    ///   <para>cis:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà utilizzata per associare un'offerta al relativo biglietto.</para>
    ///   <para>Property used to associate an offer with the relative ticket</para>
    /// labels<para>includes</para><para>include</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/includes">http://dati.beniculturali.it/cis/includes</seealso>
    let includes = Prefixed_Name(cis, "includes") |> PrefixedName
    /// <summary>
    ///   <para>cis:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta un URL</para>
    ///   <para>Thi property represents an URL.</para>
    /// labels<para>url</para><para>url</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/url">http://dati.beniculturali.it/cis/url</seealso>
    let url = Prefixed_Name(cis, "url") |> PrefixedName
    /// <summary>
    ///   <para>cis:opens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà è utilizzata per rappresentare l'orario di apertura</para>
    ///   <para>This property is used to represent the opening time</para>
    /// labels<para>opens </para><para>apre </para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/opens">http://dati.beniculturali.it/cis/opens</seealso>
    let opens = Prefixed_Name(cis, "opens") |> PrefixedName
    /// <summary>
    ///   <para>cis:Card</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a card valid for the entrance to more than one Cultural Institute or Site. It is a subclass of Ticket.</para>
    ///   <para>Questa classe rappresenta una carta d'ingresso che dà diritto a più ingressi in più luoghi della cultura. E' sottoclasse di ticket.</para>
    /// labels<para>Carta d'ingresso</para><para>Card</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Card">http://dati.beniculturali.it/cis/Card</seealso>
    let Card = Prefixed_Name(cis, "Card") |> PrefixedName
    /// <summary>
    ///   <para>cis:Catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concetto utilizzato per rappresentare il catalogo che descrive l'insieme delle opere contenute in un istituto e luogo della cultura.</para>
    ///   <para>Concept used to represent the catalogue which describes the set of cultural heritage objects included in a Cultural Institute or Site</para>
    /// labels<para>Catalogue</para><para>Catalogo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Catalogue">http://dati.beniculturali.it/cis/Catalogue</seealso>
    let Catalogue = Prefixed_Name(cis, "Catalogue") |> PrefixedName
    /// <summary>
    ///   <para>cis:isCatalogueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà inversa di "ha catalogo".</para>
    ///   <para>Inverse property of "has catalogue".</para>
    /// labels<para>is catalogue of</para><para>è catalogo di</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isCatalogueOf">http://dati.beniculturali.it/cis/isCatalogueOf</seealso>
    let isCatalogueOf = Prefixed_Name(cis, "isCatalogueOf") |> PrefixedName
    /// <summary>
    ///   <para>cis:Ticket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents an entrance ticket for a Cultural Institute or Site, if required, and for an event</para>
    ///   <para>Rappresenta il biglietto d'ingresso per l'Istitituto e Luogo della Cultura, qualora sia previsto, e per l'evento culturale.</para>
    /// labels<para>Biglietto</para><para>Ticket</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Ticket">http://dati.beniculturali.it/cis/Ticket</seealso>
    let Ticket = Prefixed_Name(cis, "Ticket") |> PrefixedName
    /// <summary>
    ///   <para>cis:img/catalogue.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/catalogue.png">http://dati.beniculturali.it/cis/img/catalogue.png</seealso>
    let ``img/catalogue.png`` = Prefixed_Name(cis, "img/catalogue.png") |> PrefixedName
    /// <summary>
    ///   <para>cis:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the catalogue with the cultural heritage objects of a cultural institute or site that the catalogue describes.</para>
    ///   <para>Proprietà che consente di associare il catalogo alle opere di un istituto e luogo della cultura che esso descrive.</para>
    /// labels<para>describes</para><para>descrive</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/describes">http://dati.beniculturali.it/cis/describes</seealso>
    let describes = Prefixed_Name(cis, "describes") |> PrefixedName
    /// <summary>
    ///   <para>cis:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the cultural heritage included in a Cultural Institute or Site or single collections that compone the cultural heritage</para>
    ///   <para>Rappresenta il patrimonio complessivo dell'Istituto e Luogo della Cultura o le singole collezioni di cui esso si compone.</para>
    /// labels<para>Collezione</para><para>Collection</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Collection">http://dati.beniculturali.it/cis/Collection</seealso>
    let Collection = Prefixed_Name(cis, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasWebSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent a web site</para>
    ///   <para>Proprietà utilizzata per rappresentare un sito web</para>
    /// labels<para>has web site</para><para>ha sito web</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasWebSite">http://dati.beniculturali.it/cis/hasWebSite</seealso>
    let hasWebSite = Prefixed_Name(cis, "hasWebSite") |> PrefixedName
    /// <summary>
    ///   <para>cis:Cinema</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:CISType</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This class represents a cultural institute or site of type Cinema</para>
    ///   <para>Questa classe rappresenta un istituto e luogo della cultura di tipo Cinema</para>
    /// labels<para>Cinema</para><para>Cinema</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Cinema">http://dati.beniculturali.it/cis/Cinema</seealso>
    let Cinema = Prefixed_Name(cis, "Cinema") |> PrefixedName

    /// <summary>
    ///   <para>cis:ClericalAdministrativeArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the clerical administrative area. It can be used to represents Diocese, Parish, etc.</para>
    ///   <para>Questa classe rappresenta un'area amministrativa territoriale ecclesiastica. Essa include le diocesi, parrocchie, ecc.</para>
    /// labels<para>Area amministrativa ecclesiastica</para><para>Clerical Administrative Area</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ClericalAdministrativeArea">http://dati.beniculturali.it/cis/ClericalAdministrativeArea</seealso>
    let ClericalAdministrativeArea =
        Prefixed_Name(cis, "ClericalAdministrativeArea") |> PrefixedName

    /// <summary>
    ///   <para>cis:GeographicalFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta una caratteristica  geografica. Può essere usata per rappresentare un comune, o un'area che ricomprendere diverse aree ammistrative.</para>
    ///   <para>It represents a geographical feature. It can be used to model a municipality or an area across different administrative areas.</para>
    /// labels<para>Geographical Area</para><para>Area Geografica</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/GeographicalFeature">http://dati.beniculturali.it/cis/GeographicalFeature</seealso>
    let GeographicalFeature = Prefixed_Name(cis, "GeographicalFeature") |> PrefixedName
    /// <summary>
    ///   <para>cis:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property represents an identifier for a Thing.</para>
    ///   <para>Questa proprietà rappresenta un identificativo per una cosa.</para>
    /// labels<para>identificativo</para><para>identifier</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/identifier">http://dati.beniculturali.it/cis/identifier</seealso>
    let identifier = Prefixed_Name(cis, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>cis:</para>
    /// </summary>
    /// <remarks>
    ///   <para>adms:SemanticAsset</para>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Nel corso dell'elaborazione di Cultural-ON è stato avviato un approfondito confronto tra il gruppo di lavoro responsabile del progetto di valorizzazione del patrimonio informativo pubblico attraverso i linked open data, costituito dal Ministero dei beni e delle attività culturali e del turismo (Servizio I della Direzione generale Organizzazione) e dall’Istituto di Scienze e Tecnologie della Cognizione del Consiglio Nazionale delle Ricerche (CNR) con il gruppo costituito nell'ambito del progetto di pubblicazione di linked open data del dominio cultura, intrapreso dall'Istituto beni artistici culturali e naturali della Regione Emilia-Romagna che si inserisce nel più ampio progetto Open Data Emilia-Romagna, al fine di contribuire ad un’ampia integrazione tra le due ontologie, nella prospettiva di una sempre maggiore interoperabilità.</para>
    ///   <para>During the definition of Cultural-ON, an in depth discussion between the working group responsible for cultural linked open data, formed by the Ministry of Cultural Heritage and Activities and Tourism (Service I) and the Institute of Cognitive Sciences and Technologies of the Council of Research (CNR) and the working group of the "Istituto beni artistici culturali e naturali" of Emilia Romagna Region, in order to contribute to the integration of the two ontologies, thus guaranteeing semantic interoperability.</para>
    /// </remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/">http://dati.beniculturali.it/cis/</seealso>
    let _prefix_iri = Prefixed_Name(cis, "") |> PrefixedName

    /// <summary>
    ///   <para>cis:img/cultural-ON.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/cultural-ON.png">http://dati.beniculturali.it/cis/img/cultural-ON.png</seealso>
    let ``img/cultural_ON.png`` =
        Prefixed_Name(cis, "img/cultural-ON.png") |> PrefixedName

    /// <summary>
    ///   <para>cis:AccessCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept used to represent general information for the public access to the Cultural Institute or Site or to the Event. For instance, examples of information include: opening hours, type of admission, temporary closing, etc.</para>
    ///   <para>Concetto che rappresenta le informazioni generali per l'accesso da parte del pubblico all'Istituto e Luogo della Cultura e all'evento. Per esempio consente di modellare informazioni quali gi orari di apertura, le chiusure temporanee (con le relative motivazioni), il tipo di apertura al pubblico, ecc.</para>
    /// labels<para>Condizioni di accesso</para><para>Access condition</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/AccessCondition">http://dati.beniculturali.it/cis/AccessCondition</seealso>
    let AccessCondition = Prefixed_Name(cis, "AccessCondition") |> PrefixedName
    /// <summary>
    ///   <para>cis:accessConditionFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property of "has access condition"</para>
    ///   <para>Proprietà inversa di "ha condizione di accesso"</para>
    /// labels<para>condizione di accesso per</para><para>access condition for</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/accessConditionFor">http://dati.beniculturali.it/cis/accessConditionFor</seealso>
    let accessConditionFor = Prefixed_Name(cis, "accessConditionFor") |> PrefixedName

    /// <summary>
    ///   <para>cis:CulturalInstituteOrSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sono istituti e luoghi della cultura i musei, le biblioteche e gli archivi, le aree e i parchi archeologici, i complessi monumentali. Gli istituti e luoghi e della cultura che appartengono a soggetti pubblici sono destinati alla pubblica fruizione ed espletano un servizio pubblico. Le strutture espositive e di consultazione nonché i luoghi della cultura che appartengono a soggetti privati e sono aperti al pubblico espletano un servizio privato di utilità sociale.</para>
    ///   <para>The class Cultural Institute or Site represents museums, libraries, archive holders, archaeologic areas and parks, monumental areas. The cultural institutes of sites that are owned by public bodies are meant to offer public services. The cultural institutes or sites that are owned by private subjects, and are open to the public, offer a public and societal service.</para>
    /// labels<para>Istituto e Luogo Della Cultura</para><para>Cultural Institute or Site</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CulturalInstituteOrSite">http://dati.beniculturali.it/cis/CulturalInstituteOrSite</seealso>
    let CulturalInstituteOrSite =
        Prefixed_Name(cis, "CulturalInstituteOrSite") |> PrefixedName

    /// <summary>
    ///   <para>cis:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents a temporal interval</para>
    ///   <para>Rappresenta un intervallo temporale.</para>
    /// labels<para>Intervallo di Tempo</para><para>Time Interval</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/TimeInterval">http://dati.beniculturali.it/cis/TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(cis, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that permits to specify the cultural heritage objects that form a specific collection or the entire cultural heritage included in a cultural institute or site</para>
    ///   <para>Proprietà che consente di specificare le opere che formano una determinata collezione o l'intero patrimonio di un istituto e luogo della cultura</para>
    /// labels<para>has member</para><para>ha membro</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasMember">http://dati.beniculturali.it/cis/hasMember</seealso>
    let hasMember = Prefixed_Name(cis, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>cis:ContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un punto di contatto (racchiude numeri di telefono, fax, indirizzi e-mail, siti web e relative disponibilità ove applicabili). Si raccomanda agli esperti di dominio di aver cura in fase di utilizzo di distinguere ulteriormente il tipo di punto di contatto (turistico, amministrativo, ecc).</para>
    ///   <para>It represents a contact point which consists of phone numbers, e-mail addresses, web sites and their availability where applicable. We recommend the domain experts to specify better during the data production phase which type of contact point is in use (administrative contact point, tourist contact point, etc,).</para>
    /// labels<para>Punto di Contatto</para><para>Contact Point</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/ContactPoint">http://dati.beniculturali.it/cis/ContactPoint</seealso>
    let ContactPoint = Prefixed_Name(cis, "ContactPoint") |> PrefixedName
    /// <summary>
    ///   <para>cis:available</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate a contact point with hours specification in which the contact point is available.</para>
    ///   <para>Proprietà utilizzata per associare  un punto di contatto a fasce orarie in cui il punto di contatto è disponibile.</para>
    /// labels<para>disponibile</para><para>available</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/available">http://dati.beniculturali.it/cis/available</seealso>
    let available = Prefixed_Name(cis, "available") |> PrefixedName

    /// <summary>
    ///   <para>cis:OpeningHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents the opening hours specification </para>
    ///   <para>Rappresenta gli orari di apertura</para>
    /// labels<para>Opening Hours Specification</para><para>Orari di Apertura</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/OpeningHoursSpecification">http://dati.beniculturali.it/cis/OpeningHoursSpecification</seealso>
    let OpeningHoursSpecification =
        Prefixed_Name(cis, "OpeningHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>cis:hasCertifiedEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per associare un indirizzo PEC a un punto di contatto</para>
    ///   <para>Property used to associate a certified email address to a contact point</para>
    /// labels<para>ha posta elettronica certificata (PEC)</para><para>has certified email</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasCertifiedEmail">http://dati.beniculturali.it/cis/hasCertifiedEmail</seealso>
    let hasCertifiedEmail = Prefixed_Name(cis, "hasCertifiedEmail") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasEmail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proprietà utilizzata per specificare indirizzi email del punto di contatto</para>
    ///   <para>Property used to specify email address for a contact point</para>
    /// labels<para>has email</para><para>ha email</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasEmail">http://dati.beniculturali.it/cis/hasEmail</seealso>
    let hasEmail = Prefixed_Name(cis, "hasEmail") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasFax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property used to represent one or more fax numbers for the contact point</para>
    ///   <para>Proprietà utilizzata per rappresentare uno o più numeri di fax del punto di contatto</para>
    /// labels<para>has fax</para><para>ha fax</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasFax">http://dati.beniculturali.it/cis/hasFax</seealso>
    let hasFax = Prefixed_Name(cis, "hasFax") |> PrefixedName
    /// <summary>
    ///   <para>cis:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che consente di associare un lavoro creativo a un'entità culturale. La stessa proprietà può essere utilizzata in maniera analoga per associare un lavoro creativo a un evento o a un sito.</para>
    ///   <para>Property used to associate a creative work with a cultural entity. The same property is used in a similar way to associate the creative work with an event or site</para>
    /// labels<para>tratta di</para><para>is about</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isAbout">http://dati.beniculturali.it/cis/isAbout</seealso>
    let isAbout = Prefixed_Name(cis, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>cis:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta un luogo fisico georeferenziato relativo all'Istituto e luogo della Cultura. Un Istituto e Luogo della Cultura può avere più di un luogo fisico associato. Nell'ambito dell'Istituto Centrale per il Catalogo e la Documentazione (ICC)D) tale concetto rappresenta il contenitore fisico. Per esempio, un luogo fisico può essere "Palazzo Venezia" dove ha sede il "Museo Nazionale di Palazzo Venezia" o la "Biblioteca di Archeologia e Storia dell'Arte".</para>
    ///   <para>It represents a georeferenced physical site related to the Cultural Institute or Site. A Cultural Institute or Site can be located in more than one physical site. For instance, a Site can be "Palazzo Venezia" which is the site of the "Museum of Palazzo Venezia" and of "Library of Archaelogy and Art History".</para>
    /// labels<para>Sede</para><para>Site</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Site">http://dati.beniculturali.it/cis/Site</seealso>
    let Site = Prefixed_Name(cis, "Site") |> PrefixedName
    /// <summary>
    ///   <para>cis:isInSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that permits to associate cultural heritage objects with the site(s) which conserve(s) them</para>
    ///   <para>Proprietà che consente di associare  opere culturali al luogo fisico in cui sono conservate.</para>
    /// labels<para>è nella sede</para><para>is in site</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isInSite">http://dati.beniculturali.it/cis/isInSite</seealso>
    let isInSite = Prefixed_Name(cis, "isInSite") |> PrefixedName
    /// <summary>
    ///   <para>cis:img/cis.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/img/cis.png">http://dati.beniculturali.it/cis/img/cis.png</seealso>
    let ``img/cis.png`` = Prefixed_Name(cis, "img/cis.png") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che permette di associare l'istituto e luogo della cultura all'insieme delle opere in esso contenute.</para>
    ///   <para>Property used to associate the Cultural Institute or Site with the set of cultural objects it contains.</para>
    /// labels<para>has collection</para><para>ha collezione</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasCollection">http://dati.beniculturali.it/cis/hasCollection</seealso>
    let hasCollection = Prefixed_Name(cis, "hasCollection") |> PrefixedName
    /// <summary>
    ///   <para>cis:isInvolvedInProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to represent an involvement relationship between a cultural institute or site and a project</para>
    ///   <para>Proprietà utilizzata per rappresentare una relazione di coinvolgimento tra l'istituto e luogo della cultura e un progetto.</para>
    /// labels<para>is involved in a project</para><para>è coinvolto in progetto</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isInvolvedInProject">http://dati.beniculturali.it/cis/isInvolvedInProject</seealso>
    let isInvolvedInProject = Prefixed_Name(cis, "isInvolvedInProject") |> PrefixedName
    /// <summary>
    ///   <para>cis:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents a Project the Cultural Institute and Site can be involved in.</para>
    ///   <para>Rappresenta un progetto nel quale l'istitutto della Cultura può essere coinvolto.</para>
    /// labels<para>Progetto</para><para>Project</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Project">http://dati.beniculturali.it/cis/Project</seealso>
    let Project = Prefixed_Name(cis, "Project") |> PrefixedName
    /// <summary>
    ///   <para>cis:catalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property used to associate the Cultural Institute or SIte with a catalogue of cultural collections included in the institute or site. The relatioships can be used to indicate that a Cultural Institute or Site has an its own catalogue or situations where a Cultural Institute or Site contributes to a union catalogue (this latter case is represented by libraries that can contribute to or participate in a union catalogue).</para>
    ///   <para>Proprietà utilizzata per associare l'istituto e luogo della cultura a un  catalogo che descrive le opere in esso contenute. Tale relazione può essere utilizzata per indicare che un istituto e luogo della cultura ha un catalogo ma anche una situazione per cui un istituto e luogo della cultura partecipa a un catalogo (in quest'ultimo caso un esempio è rappresentato dalle biblioteche che possono partecipare a un catalogo collettivo).</para>
    /// labels<para>catalogue</para><para>catalogo</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/catalogue">http://dati.beniculturali.it/cis/catalogue</seealso>
    let catalogue = Prefixed_Name(cis, "catalogue") |> PrefixedName
    /// <summary>
    ///   <para>cis:institutionalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà identifica direttamente il nome istituzionale dell'Istituto e luogo della cultura</para>
    ///   <para>This data property identifies  the institutional name of the Cultural Institute or Site.</para>
    /// labels<para>Institutional Name</para><para>Nome Istituzionale</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/institutionalName">http://dati.beniculturali.it/cis/institutionalName</seealso>
    let institutionalName = Prefixed_Name(cis, "institutionalName") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasNameInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property which associate a cultural institute or site or a site with the situation name in time</para>
    ///   <para>Proprietà che associa un istituto o luogo della cultura o un sito alla situazione "denominazione nel tempo", ovvero una determinata denominazione valida in un determinato arco temporale</para>
    /// labels<para>ha nome nel tempo</para><para>has name in time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasNameInTime">http://dati.beniculturali.it/cis/hasNameInTime</seealso>
    let hasNameInTime = Prefixed_Name(cis, "hasNameInTime") |> PrefixedName
    /// <summary>
    ///   <para>cis:NameInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permits to represent a situation in which a name of the Cultural Institute or Site change in time.</para>
    ///   <para>Permette di rappresentare una situazione relativa alla denominazione di un istituto e luogo della cultura che cambia nel tempo.</para>
    /// labels<para>Nome Nel Tempo</para><para>Name in Time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/NameInTime">http://dati.beniculturali.it/cis/NameInTime</seealso>
    let NameInTime = Prefixed_Name(cis, "NameInTime") |> PrefixedName
    /// <summary>
    ///   <para>cis:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This object property is meant to link a cultural institute or site with itself. This can be used to represent all those cases in which a institute or site can be part of another general institute or site. This property can be effectively used in the cases of Sections of the Central Archive.</para>
    ///   <para>Questa proprietà è utilizzata per connettere, con una relazione "essere parte di", un istituto e luogo della cultura a se stesso. In particolare, tale proprietà può essere efficacemente usata per rappresentare sezioni dell'Archivio di Stato (sezione dell'Archivio di Spoleto che è parte dell'Archivio di Stato)</para>
    /// labels<para>is part of</para><para>è parte di</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isPartOf">http://dati.beniculturali.it/cis/isPartOf</seealso>
    let isPartOf = Prefixed_Name(cis, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>cis:providesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà utilizzata per rappresentare una relazione di fornitura di servizi da parte di un istituto e luogo della cultura.</para>
    ///   <para>Property used to represent a supply service relationship between a cultural institute or site and a service.</para>
    /// labels<para>fornisce servizi</para><para>provides Service</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/providesService">http://dati.beniculturali.it/cis/providesService</seealso>
    let providesService = Prefixed_Name(cis, "providesService") |> PrefixedName
    /// <summary>
    ///   <para>cis:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It represents a service that is provided by the Cultural Institute or Site. For instance, a service can be: the presence of a restaurant internal to the Cultural Institute or Site, the uso of an educational room, the use of a free wifi connection</para>
    ///   <para>Rappresenta un servizio offerto da un istituto e luogo della cultura. Per esempio, un servizio può essere: la presenza di un ristorante interno al luogo, l'uso una sala didattica, l'uso di una connessione wifi libera, ecc.</para>
    /// labels<para>Servizio</para><para>Service</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Service">http://dati.beniculturali.it/cis/Service</seealso>
    let Service = Prefixed_Name(cis, "Service") |> PrefixedName

    /// <summary>
    ///   <para>cis:makesAvailableEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Proprietà che consente di associare l'istituto e luogo della cultura alle attrezzature da esso possedute.</para>
    ///   <para>Property that permits to associate the Cultural Institute or Site with its own equipment</para>
    /// labels<para>rende disponibile attrezzatura</para><para>makes available equipment</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/makesAvailableEquipment">http://dati.beniculturali.it/cis/makesAvailableEquipment</seealso>
    let makesAvailableEquipment =
        Prefixed_Name(cis, "makesAvailableEquipment") |> PrefixedName

    /// <summary>
    ///   <para>cis:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rappresenta l'attrezzatura resa disponibile dall'Istituto e luogo della cultura. Per esempio è un'attrezzatura un totem, ecc.</para>
    ///   <para>It represents the equipment made available by the Cultural Institute or Site. For instance, the equipment can be a totem, etc.</para>
    /// labels<para>Attrezzatura</para><para>Equipment</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/Equipment">http://dati.beniculturali.it/cis/Equipment</seealso>
    let Equipment = Prefixed_Name(cis, "Equipment") |> PrefixedName
    /// <summary>
    ///   <para>cis:isRelatedToRiT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>proprietà inversa di "ruolo per"</para>
    ///   <para>inverse property for "roleFor"</para>
    /// labels<para>è relativo a ruolo nel tempo</para><para>is related to role in time</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/isRelatedToRiT">http://dati.beniculturali.it/cis/isRelatedToRiT</seealso>
    let isRelatedToRiT = Prefixed_Name(cis, "isRelatedToRiT") |> PrefixedName
    /// <summary>
    ///   <para>cis:hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property which links a cultural institute or site to its own physical site(s).</para>
    ///   <para>Proprietà che collega un istituto e luogo della cultura al proprio o ai propri siti fisici.</para>
    /// labels<para>ha contenitore fisico</para><para>has site</para><para>ha sede</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/hasSite">http://dati.beniculturali.it/cis/hasSite</seealso>
    let hasSite = Prefixed_Name(cis, "hasSite") |> PrefixedName

    /// <summary>
    ///   <para>cis:CulturalLandscapeAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>cis:CISType</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This class represents a specific types of cultural institute or site, i.e., the cultural landscape asset.</para>
    ///   <para>Questa classe rappresenta uno specifico tipo di istituto e luogo della cultura, i.e., il bene paessaggistico così come definito dall'art. 136 del Codice dei Beni Culturali.</para>
    /// labels<para>Cultural Landscape Asset</para><para>Bene Paesaggistico</para></remarks>
    /// <seealso href="http://dati.beniculturali.it/cis/CulturalLandscapeAsset">http://dati.beniculturali.it/cis/CulturalLandscapeAsset</seealso>
    let CulturalLandscapeAsset =
        Prefixed_Name(cis, "CulturalLandscapeAsset") |> PrefixedName

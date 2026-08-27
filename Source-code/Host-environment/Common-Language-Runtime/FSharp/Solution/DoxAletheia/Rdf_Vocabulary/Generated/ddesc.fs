namespace https.w3id.org.arco.ontology.denotative_description.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ddesc =
    let _namespace_iri = Namespace_Iri ddesc |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/">https://w3id.org/arco/ontology/denotative-description/</seealso>
    let _prefix_iri = Prefixed_Name(ddesc, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Accessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAccessibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Accessibile"</para><para>"Accessible"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Accessible">https://w3id.org/arco/ontology/denotative-description/Accessible</seealso>
    let Accessible = Prefixed_Name(ddesc, "Accessible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Accessory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un accessorio di un bene musicale, ovvero un oggetto collegabile al bene musicale, sia nel caso in cui sia funzionale alla produzione del suono, sia nel caso in cui sia di supporto alla produzione del suono o alla conservazione o alla prassi musicale del bene."</para>
    ///   <para>"This class represents an accessory of a musical property, both if it is functional to the sound production, or if it is the sound's production or conservation medium."</para>
    /// labels<para>"Accessorio"</para><para>"Accessory"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Accessory">https://w3id.org/arco/ontology/denotative-description/Accessory</seealso>
    let Accessory = Prefixed_Name(ddesc, "Accessory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/AffixedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an element (i.e. crest, trademark, postmark, inscription) which is affixed on a cultural property."</para>
    ///   <para>"Questa classe rappresenta un elemento (stemma, marchio, timbro, emblema, logo, iscrizione, etc.) apposto su un bene culturale."</para>
    /// labels<para>"Element affixed on cultural property"</para><para>"Elemento apposto su bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/AffixedElement">https://w3id.org/arco/ontology/denotative-description/AffixedElement</seealso>
    let AffixedElement = Prefixed_Name(ddesc, "AffixedElement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/AffixedElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the type (i.e. civil, religious) of an inscription, emblem, postmark, crest, etc."</para>
    ///   <para>"Questa classe rappresenta il tipo (es.: gentilizio, civile, religioso, etc.) di un'iscrizione, un emblema, un timbro, uno stemma, etc."</para>
    /// labels<para>"Tipo di elemento apposto"</para><para>"Affixed element type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/AffixedElementType">https://w3id.org/arco/ontology/denotative-description/AffixedElementType</seealso>
    let AffixedElementType = Prefixed_Name(ddesc, "AffixedElementType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/AgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the age range (child, teenager, adult, old person) of a person."</para>
    ///   <para>"Questa classe rappresenta la fascia d'età (bambino, ragazzo, adulto  anziano) di una persona."</para>
    /// labels<para>"Fascia d'età"</para><para>"Age range"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/AgeRange">https://w3id.org/arco/ontology/denotative-description/AgeRange</seealso>
    let AgeRange = Prefixed_Name(ddesc, "AgeRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Area">https://w3id.org/arco/ontology/denotative-description/Area</seealso>
    let Area = Prefixed_Name(ddesc, "Area") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/AssignedDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents an attributed denomination."</para>
    ///   <para>"Questo individuo rappresenta una denominazione attribuita."</para>
    /// labels<para>"Denominazione attribuita"</para><para>"Assigned designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/AssignedDesignation">https://w3id.org/arco/ontology/denotative-description/AssignedDesignation</seealso>
    let AssignedDesignation =
        Prefixed_Name(ddesc, "AssignedDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAvailability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Available"</para><para>"Disponibile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Available">https://w3id.org/arco/ontology/denotative-description/Available</seealso>
    let Available = Prefixed_Name(ddesc, "Available") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/AvailableNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta le note producibili da uno strumento musicale, dal grave all'acuto."</para>
    ///   <para>"This individual represents playable notes by a musical instrument, from low to high."</para>
    /// labels<para>"Note produbicili"</para><para>"Available notes"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/AvailableNotes">https://w3id.org/arco/ontology/denotative-description/AvailableNotes</seealso>
    let AvailableNotes = Prefixed_Name(ddesc, "AvailableNotes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/BackTotalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Back total length"</para><para>"Lunghezza totale parte posteriore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/BackTotalLength">https://w3id.org/arco/ontology/denotative-description/BackTotalLength</seealso>
    let BackTotalLength = Prefixed_Name(ddesc, "BackTotalLength") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/BackWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Back Width"</para><para>"Larghezza dorso"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/BackWidth">https://w3id.org/arco/ontology/denotative-description/BackWidth</seealso>
    let BackWidth = Prefixed_Name(ddesc, "BackWidth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/BadConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Stato di conservazione cattivo"</para><para>"Bad conservation status"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/BadConservationStatus">https://w3id.org/arco/ontology/denotative-description/BadConservationStatus</seealso>
    let BadConservationStatus =
        Prefixed_Name(ddesc, "BadConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un marchio, ovvero un segno, figura, simbolo impresso o applicato su qualcosa a scopo di distinzione e riconoscimento."</para>
    ///   <para>"This class represents a brand, that is a sign, an image, a symbol affixed on an object for identification."</para>
    /// labels<para>"Brand"</para><para>"Marchio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Brand">https://w3id.org/arco/ontology/denotative-description/Brand</seealso>
    let Brand = Prefixed_Name(ddesc, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Capacity"</para><para>"Capacità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Capacity">https://w3id.org/arco/ontology/denotative-description/Capacity</seealso>
    let Capacity = Prefixed_Name(ddesc, "Capacity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ChestCircumference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Chest Circumference"</para><para>"Circonferenza petto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ChestCircumference">https://w3id.org/arco/ontology/denotative-description/ChestCircumference</seealso>
    let ChestCircumference = Prefixed_Name(ddesc, "ChestCircumference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Circumference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Circonferenza"</para><para>"Circumference"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Circumference">https://w3id.org/arco/ontology/denotative-description/Circumference</seealso>
    let Circumference = Prefixed_Name(ddesc, "Circumference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CoatOfArms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta uno stemma, ovvero un insieme di figure e simboli che, in araldica, vengono rappresentati secondo determinate regole per contrassegnare persone o enti."</para>
    /// labels<para>"Stemma"</para><para>"Coat of arms"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CoatOfArms">https://w3id.org/arco/ontology/denotative-description/CoatOfArms</seealso>
    let CoatOfArms = Prefixed_Name(ddesc, "CoatOfArms") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CoinDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the design on the reverse or the obverse of a numismatic property, as the graphical part of what is represented on a side of a coin, together with the legend (lettering and wording)."</para>
    ///   <para>"Questa classe rappresenta la raffigurazione presente sul dritto o sul rovescio di un bene numismatico, intesa come l'insieme degli elementi grafici, che, uniti a una legenda (lettere e parole), fa parte dell'impronta della moneta."</para>
    /// labels<para>"Raffigurazione su moneta"</para><para>"Coin design"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CoinDesign">https://w3id.org/arco/ontology/denotative-description/CoinDesign</seealso>
    let CoinDesign = Prefixed_Name(ddesc, "CoinDesign") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CoinLegend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'insieme di lettere e parole presenti sul dritto o sul rovescio di un bene numismatico, che, unito alla raffigurazione, fa parte dell'impronta della moneta."</para>
    ///   <para>"This class represents the lettering and wording on the reverse or the obverse of a numismatic property."</para>
    /// labels<para>"Legenda della moneta"</para><para>"Coin legend"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CoinLegend">https://w3id.org/arco/ontology/denotative-description/CoinLegend</seealso>
    let CoinLegend = Prefixed_Name(ddesc, "CoinLegend") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la modalità comunicativa di un oggetto, definita dal tipo di modalità (es.: verbale, scritta, strumentale), la modalità esecutiva, il numero di voci e strumenti coinvolti, etc."</para>
    ///   <para>"This class represents the communication medium of an object, defined by the communication medium type (e.g.: verbal, written, instrumental), the implementation method, the number of voices or instruments involved, etc."</para>
    /// labels<para>"Communication medium"</para><para>"Modalità comunicativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CommunicationMedium">https://w3id.org/arco/ontology/denotative-description/CommunicationMedium</seealso>
    let CommunicationMedium =
        Prefixed_Name(ddesc, "CommunicationMedium") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di modalità comunicativa."</para>
    ///   <para>"This class represents the type of communication medium."</para>
    /// labels<para>"Communication medium type"</para><para>"Tipo di modalità comunicativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CommunicationMediumType">https://w3id.org/arco/ontology/denotative-description/CommunicationMediumType</seealso>
    let CommunicationMediumType =
        Prefixed_Name(ddesc, "CommunicationMediumType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CompleteLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Complete legibility"</para><para>"Leggibilità totale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CompleteLegibility">https://w3id.org/arco/ontology/denotative-description/CompleteLegibility</seealso>
    let CompleteLegibility = Prefixed_Name(ddesc, "CompleteLegibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta lo stato di conservazione di un bene culturale."</para>
    ///   <para>"This class represents the conservation status of the cultural property."</para>
    /// labels<para>"Conservation Status"</para><para>"Stato di Conservazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ConservationStatus">https://w3id.org/arco/ontology/denotative-description/ConservationStatus</seealso>
    let ConservationStatus = Prefixed_Name(ddesc, "ConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Tipo di stato di conservazione"</para><para>"Conservation Status Type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ConservationStatusType">https://w3id.org/arco/ontology/denotative-description/ConservationStatusType</seealso>
    let ConservationStatusType =
        Prefixed_Name(ddesc, "ConservationStatusType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Counterstamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represent a counterstamp (or countermark), that is a partial or complete over-stamping of a coin, generally affixed in order to change its value or issuing authority."</para>
    ///   <para>"Questa classe rappresenta una contromarca, ovvero una lettera o un altro segno punzonato su una moneta. Una contromarca viene apposta tramite un apposito punzone. La maggior parte delle monete vengono contromarcate per cambiarne il valore in seguito a una riforma monetaria. La contromarca è quindi un segno apposto dall'autorità emittente nel dritto o nel rovescio della moneta in epoca posteriore alla sua emissione, per aumentarne o diminuirne il valore e, in caso di necessità, per rimettere in circolazione monete già ritirate."</para>
    /// labels<para>"Contromarca"</para><para>"Counterstamp"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Counterstamp">https://w3id.org/arco/ontology/denotative-description/Counterstamp</seealso>
    let Counterstamp = Prefixed_Name(ddesc, "Counterstamp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CoveredArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Area coperta"</para><para>"Covered area"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CoveredArea">https://w3id.org/arco/ontology/denotative-description/CoveredArea</seealso>
    let CoveredArea = Prefixed_Name(ddesc, "CoveredArea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalEntityTechnicalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la descrizione tecnica di un'entità culturale, la quale utilizza tutti i concetti tecnici che possono classificare caratteristiche tecniche possedute da un'entità culturale. Questa classe è un tipo particolare di Description, la classe degli oggetti costruiti socialmente (testi, valori, categorie, relazioni, contesti), usati per descrivere qualcos'altro in modo strutturato."</para>
    ///   <para>"This class represents the technical description of a cultural entity, which uses all the technical concepts classifying the technical characteristics that a cultural entity can have. This class is a particular type of the class Description, which is the class for socially constructed objects (i.e. texts, values, categories, relations, contexts) used to describe other objects in a structured manner."</para>
    /// labels<para>"Cultural entity technical description"</para><para>"Descrizione tecnica di entità culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalDescription">https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalDescription</seealso>
    let CulturalEntityTechnicalDescription =
        Prefixed_Name(ddesc, "CulturalEntityTechnicalDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalEntityTechnicalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta lo stato tecnico di un'entità culturale, cioè una situazione in cui un'entità culturale ha associate una serie di caratteristiche tecniche. Lo stato di un'entità ha associata una validità temporale, relativa al momento in cui quelle caratteristiche sono state rilevate. Per esempio, una occorrenza di un dettaglio tecnico è: "bene culturale X realizzato con la materia terracotta e di forma cilindrica"."</para>
    ///   <para>"This class represents the technical status of a cultural entity, that is a situation in which the cultural entity is associated to technical characteristics. The technical status has a temporal validity, related to the moment when the characteristics were observed. For instance, a cultural property techncal status is: "the cultural property X realized with pottery material and cylindrical in shape"."</para>
    /// labels<para>"Stato tecnico di entità culturale"</para><para>"Technical status of cultural entity"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalStatus">https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalStatus</seealso>
    let CulturalEntityTechnicalStatus =
        Prefixed_Name(ddesc, "CulturalEntityTechnicalStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the cultural property accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)"</para>
    ///   <para>"Questa classe rappresenta l'accessibilità di un bene culturale, ovvero la possibilità di accedere al bene, in tutto o in parte, per esempio per effettuare un esame diretto finalizzato alla catalogazione (es.: un bene immobile posto in un luogo recintato non accessibile, un bene mobile che non si può osservare da vicino perché posto troppo in alto su una parete; un bene totalmente accessibile, etc.)."</para>
    /// labels<para>"Accessibilità del bene culturale"</para><para>"Cultural property accessibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAccessibility">https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAccessibility</seealso>
    let CulturalPropertyAccessibility =
        Prefixed_Name(ddesc, "CulturalPropertyAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la disponibilità materiale di un bene culturale, ovvero se il bene è materialmente disponibile, per esempio per attività di catalogazione, o se non è disponibile (es.: furto, distruzione)"</para>
    ///   <para>"This class represents the availability of a cultural property, wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities."</para>
    /// labels<para>"Disponibilità materiale del bene culturale"</para><para>"Cultural Property Availability"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAvailability">https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAvailability</seealso>
    let CulturalPropertyAvailability =
        Prefixed_Name(ddesc, "CulturalPropertyAvailability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the definition of a cultural property. It is the term or expression which identifies the property that is being catalogued."</para>
    ///   <para>"Questa classe rappresenta la definizione di un bene culturale, cioè il termine o la locuzione che individua il bene che si sta catalogando."</para>
    /// labels<para>"Definizione del bene culturale"</para><para>"Cultural Property Definition"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyDefinition">https://w3id.org/arco/ontology/denotative-description/CulturalPropertyDefinition</seealso>
    let CulturalPropertyDefinition =
        Prefixed_Name(ddesc, "CulturalPropertyDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta specifiche morfologiche o funzionali, utili a completare la definizione del bene per una sua più puntuale individuazione."</para>
    ///   <para>"This class represents the morphological or functional specification, which are useful to define a cultural property for a more precise individuation."</para>
    /// labels<para>"Cultural Property Specification"</para><para>"Specifiche del bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertySpecification">https://w3id.org/arco/ontology/denotative-description/CulturalPropertySpecification</seealso>
    let CulturalPropertySpecification =
        Prefixed_Name(ddesc, "CulturalPropertySpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di bene culturale, cioè il termine o la locuzione che individua il bene che si sta catalogando ed eventuali ulteriori specifiche sulla definizione del bene."</para>
    ///   <para>"This class represents a cultural property's type, that is the term or expression which specifies the cultural propery that is being catalogued and additional information on the cultural property's definition."</para>
    /// labels<para>"Tipo di bene culturale"</para><para>"Cultural property Type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyType">https://w3id.org/arco/ontology/denotative-description/CulturalPropertyType</seealso>
    let CulturalPropertyType =
        Prefixed_Name(ddesc, "CulturalPropertyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CurrentDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta la denominazione attuale."</para>
    ///   <para>"This individual represents the current designation."</para>
    /// labels<para>"Current designation"</para><para>"Denominazione attuale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CurrentDesignation">https://w3id.org/arco/ontology/denotative-description/CurrentDesignation</seealso>
    let CurrentDesignation = Prefixed_Name(ddesc, "CurrentDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/CustomaryDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents the usual designation."</para>
    ///   <para>"Questo individuo rappresenta una denominazione consuetudinaria."</para>
    /// labels<para>"Denominazione consuetudinaria"</para><para>"Customary designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/CustomaryDesignation">https://w3id.org/arco/ontology/denotative-description/CustomaryDesignation</seealso>
    let CustomaryDesignation =
        Prefixed_Name(ddesc, "CustomaryDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DecentConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Stato di conservazione discreto"</para><para>"Decent conservation status"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DecentConservationStatus">https://w3id.org/arco/ontology/denotative-description/DecentConservationStatus</seealso>
    let DecentConservationStatus =
        Prefixed_Name(ddesc, "DecentConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DecentLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    ///
    /// labels<para>"Decent Legibility"</para><para>"Leggibilità decente"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DecentLegibility">https://w3id.org/arco/ontology/denotative-description/DecentLegibility</seealso>
    let DecentLegibility = Prefixed_Name(ddesc, "DecentLegibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DecorativeApparatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicOrDecorativeApparatusType</para>
    ///
    /// labels<para>"Decorative apparatus"</para><para>"Apparato decorativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DecorativeApparatus">https://w3id.org/arco/ontology/denotative-description/DecorativeApparatus</seealso>
    let DecorativeApparatus =
        Prefixed_Name(ddesc, "DecorativeApparatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Dedication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una dedica, intesa come iscrizione dell'autore (dedicante) su un bene culturale contenente un testo che ha lo scopo di offrire l'oggetto a una persona o un ente (dedicatario)."</para>
    /// labels<para>"Dedication"</para><para>"Dedica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Dedication">https://w3id.org/arco/ontology/denotative-description/Dedication</seealso>
    let Dedication = Prefixed_Name(ddesc, "Dedication") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Depth"</para><para>"Profondità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Depth">https://w3id.org/arco/ontology/denotative-description/Depth</seealso>
    let Depth = Prefixed_Name(ddesc, "Depth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DepthOrHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Depth / Height"</para><para>"Profondità / Altezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DepthOrHeight">https://w3id.org/arco/ontology/denotative-description/DepthOrHeight</seealso>
    let DepthOrHeight = Prefixed_Name(ddesc, "DepthOrHeight") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una denominazione e/o dedicazione attestata nel corso del tempo per il bene in esame. Per la normativa FF, la classe rappresenta nello specifico la denominazione o il titolo del fondo attestati nel corso del tempo per il bene in esame; uno stesso fondo può avere più denominazioni/titoli nel corso del tempo."</para>
    ///   <para>"This class represents a certain cultural property's designation/denomination attested over time."</para>
    /// labels<para>"Designation In Time"</para><para>"Denominazione nel tempo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DesignationInTime">https://w3id.org/arco/ontology/denotative-description/DesignationInTime</seealso>
    let DesignationInTime = Prefixed_Name(ddesc, "DesignationInTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a cultural property's denomination or dedication type, or its title (i.e. other language, current, attributed, dialectal)."</para>
    ///   <para>"Questa classe rappresenta il tipo di denominazione o dedicazione o, per la normativa FF, titolo, del bene (altra lingua, attribuita, attuale, dialettale, etc.)"</para>
    /// labels<para>"Tipo di denominazione"</para><para>"Designation Type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DesignationType">https://w3id.org/arco/ontology/denotative-description/DesignationType</seealso>
    let DesignationType = Prefixed_Name(ddesc, "DesignationType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/DialectalDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>"This individual represents the dialect designation."</para>
    ///   <para>"Questo individuo rappresenta una denominazione dialettale."</para>
    /// labels<para>"Dialectal designation"</para><para>"Denominazione dialettale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/DialectalDesignation">https://w3id.org/arco/ontology/denotative-description/DialectalDesignation</seealso>
    let DialectalDesignation =
        Prefixed_Name(ddesc, "DialectalDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Diameter"</para><para>"Diametro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Diameter">https://w3id.org/arco/ontology/denotative-description/Diameter</seealso>
    let Diameter = Prefixed_Name(ddesc, "Diameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Diapason</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents the identified diapason (note, temperature and eventually humidity during the detection)."</para>
    ///   <para>"Questo individuo rappresenta il corista rilevato (nota, temperatura ed eventualmente umidità ambientale al momento della rilevazione)."</para>
    /// labels<para>"Corista"</para><para>"Diapason"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Diapason">https://w3id.org/arco/ontology/denotative-description/Diapason</seealso>
    let Diapason = Prefixed_Name(ddesc, "Diapason") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Duration"</para><para>"Durata temporale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Duration">https://w3id.org/arco/ontology/denotative-description/Duration</seealso>
    let Duration = Prefixed_Name(ddesc, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/EdgeCircumference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Circonferenza orlo"</para><para>"Edge circumference"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/EdgeCircumference">https://w3id.org/arco/ontology/denotative-description/EdgeCircumference</seealso>
    let EdgeCircumference = Prefixed_Name(ddesc, "EdgeCircumference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Emblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un emblema, ovvero una figura o un'immagine simbolica, talvolta accompagnata da un testo scritto (motto, testo in versi, ecc.)"</para>
    /// labels<para>"Emblema"</para><para>"Emblem"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Emblem">https://w3id.org/arco/ontology/denotative-description/Emblem</seealso>
    let Emblem = Prefixed_Name(ddesc, "Emblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents a musical instrument's musical extension."</para>
    ///   <para>"Questo individuo rappresenta l'estensione musicale di uno strumento musicale."</para>
    /// labels<para>"Extension"</para><para>"Estensione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Extension">https://w3id.org/arco/ontology/denotative-description/Extension</seealso>
    let Extension = Prefixed_Name(ddesc, "Extension") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ExternalInternalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Lunghezza esterna / interna"</para><para>"External / Internal length"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ExternalInternalLength">https://w3id.org/arco/ontology/denotative-description/ExternalInternalLength</seealso>
    let ExternalInternalLength =
        Prefixed_Name(ddesc, "ExternalInternalLength") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/FileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"This individual represents the format used to write a digital resource on a data medium."</para>
    ///   <para>"Questo individuo rappresenta il formato utilizzato per la scrittura di una risorsa digitale su supporto informatico."</para>
    /// labels<para>"Formato di compressione/estensione file"</para><para>"File Format"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/FileFormat">https://w3id.org/arco/ontology/denotative-description/FileFormat</seealso>
    let FileFormat = Prefixed_Name(ddesc, "FileFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Filigree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta la filigrana di un'opera d'arte, un disegno, una fotografia, una stampa."</para>
    ///   <para>"This individual represents the filigree of an artwork, painting, photography, print."</para>
    /// labels<para>"Filigree"</para><para>"Filigrana"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Filigree">https://w3id.org/arco/ontology/denotative-description/Filigree</seealso>
    let Filigree = Prefixed_Name(ddesc, "Filigree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/FontStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo di caratteri utilizzato in un testo (es.: corsivo, grassetto, caratteri gotici, etc.)"</para>
    ///   <para>"This class represents the font style used in a text (i.e. italic, bold, gothic)"</para>
    /// labels<para>"Tipo di caratteri"</para><para>"Font style"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/FontStyle">https://w3id.org/arco/ontology/denotative-description/FontStyle</seealso>
    let FontStyle = Prefixed_Name(ddesc, "FontStyle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/FrontTotalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Front total length"</para><para>"Lunghezza totale parte anteriore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/FrontTotalLength">https://w3id.org/arco/ontology/denotative-description/FrontTotalLength</seealso>
    let FrontTotalLength = Prefixed_Name(ddesc, "FrontTotalLength") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/FunctionalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta lo scopo funzionale (decorativo, religioso, simbolico, magico-offensivo, etc.), inteso come funzione che deve svolgere, di un oggetto (es bene culturale, apparato iconografico/decorativo o elemento apposto su un bene culturale come un'iscrizione)."</para>
    ///   <para>"This class represents the functional purpose (i.e. decorative, religious, symbolic, magic-offensive) of an object (i.e. culural property or iconographic/decorative apparatus or affixed element on a cultural property like an inscription). The functional purpose is intended as the function that an object has to perform."</para>
    /// labels<para>"Functional purpose"</para><para>"Scopo funzionale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/FunctionalPurpose">https://w3id.org/arco/ontology/denotative-description/FunctionalPurpose</seealso>
    let FunctionalPurpose = Prefixed_Name(ddesc, "FunctionalPurpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/GarmentAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta la definizione tecnica completa dei tessuti, secondo le norme fornite dal C.I.E.T.A., o dei merletti, oppure rappresenta la distinzione fra tessuto unito e tessuto operato."</para>
    ///   <para>"This individual represents the techincal definition of textured fabrics of an ancient or contemporary garment, according to the standard provided by C.I.E.T.A., or laces. It can also represent the dinstrinction between plain fabric and textured fabric."</para>
    /// labels<para>"Analisi del vestimento"</para><para>"Garment analysis"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/GarmentAnalysis">https://w3id.org/arco/ontology/denotative-description/GarmentAnalysis</seealso>
    let GarmentAnalysis = Prefixed_Name(ddesc, "GarmentAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/GarmentColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta il colore dominante, di solito quello del fondo del tessuto, o quello risultante dall'intreccio, di un vestimento antico o contemporaneoi."</para>
    ///   <para>"This individual represents the dominant color of a ancient and contemporary garment, usually it is base fabric's color, or the interlaced decoration's color."</para>
    /// labels<para>"Colore del vestimento"</para><para>"Garment colour"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/GarmentColour">https://w3id.org/arco/ontology/denotative-description/GarmentColour</seealso>
    let GarmentColour = Prefixed_Name(ddesc, "GarmentColour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/GoodConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    ///
    /// labels<para>"Stato di conservazione buono"</para><para>"Good conservation status"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/GoodConservationStatus">https://w3id.org/arco/ontology/denotative-description/GoodConservationStatus</seealso>
    let GoodConservationStatus =
        Prefixed_Name(ddesc, "GoodConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/GoodLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Buona leggibilità"</para><para>"Good legibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/GoodLegibility">https://w3id.org/arco/ontology/denotative-description/GoodLegibility</seealso>
    let GoodLegibility = Prefixed_Name(ddesc, "GoodLegibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Altezza"</para><para>"Height"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Height">https://w3id.org/arco/ontology/denotative-description/Height</seealso>
    let Height = Prefixed_Name(ddesc, "Height") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HeightLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Altezza x Lunghezza"</para><para>"Height x Length"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HeightLength">https://w3id.org/arco/ontology/denotative-description/HeightLength</seealso>
    let HeightLength = Prefixed_Name(ddesc, "HeightLength") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HeightLengthWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Height x Length x Width"</para><para>"Altezza x Lunghezza x Larghezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HeightLengthWidth">https://w3id.org/arco/ontology/denotative-description/HeightLengthWidth</seealso>
    let HeightLengthWidth = Prefixed_Name(ddesc, "HeightLengthWidth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HeightWidthThickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Height x Width x Thickness"</para><para>"Altezza x Larghezza x Spessore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HeightWidthThickness">https://w3id.org/arco/ontology/denotative-description/HeightWidthThickness</seealso>
    let HeightWidthThickness =
        Prefixed_Name(ddesc, "HeightWidthThickness") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HipCircumference</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Circonferenza fianchi"</para><para>"Hip circumference"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HipCircumference">https://w3id.org/arco/ontology/denotative-description/HipCircumference</seealso>
    let HipCircumference = Prefixed_Name(ddesc, "HipCircumference") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HistoricalDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>"This individual represents a historical designation."</para>
    ///   <para>"Questo individuo rappresenta una denominazione storica."</para>
    /// labels<para>"Historical designation"</para><para>"Denominazione storica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HistoricalDesignation">https://w3id.org/arco/ontology/denotative-description/HistoricalDesignation</seealso>
    let HistoricalDesignation =
        Prefixed_Name(ddesc, "HistoricalDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/HistoricalPlaque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una lapide, intesa come una lastra di pietra o marmo recante iscrizioni, figure, simboli, a scopo commemorativo, celebrativo, ecc."</para>
    /// labels<para>"Lapide"</para><para>"Historical Plaque"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/HistoricalPlaque">https://w3id.org/arco/ontology/denotative-description/HistoricalPlaque</seealso>
    let HistoricalPlaque = Prefixed_Name(ddesc, "HistoricalPlaque") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicAndDecorativeApparatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicOrDecorativeApparatusType</para>
    ///
    /// labels<para>"Apparato iconografico e decorativo"</para><para>"Iconographic and Decorative apparatus"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/IconographicAndDecorativeApparatus">https://w3id.org/arco/ontology/denotative-description/IconographicAndDecorativeApparatus</seealso>
    let IconographicAndDecorativeApparatus =
        Prefixed_Name(ddesc, "IconographicAndDecorativeApparatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicApparatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicOrDecorativeApparatusType</para>
    ///
    /// labels<para>"Iconographic apparatus"</para><para>"Apparato iconografico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/IconographicApparatus">https://w3id.org/arco/ontology/denotative-description/IconographicApparatus</seealso>
    let IconographicApparatus =
        Prefixed_Name(ddesc, "IconographicApparatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicOrDecorativeApparatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the iconographic or decorative apparaturs of a cultural property. It is intended as the more or less complex set of iconographic or decorative representations on the cultural property."</para>
    ///   <para>"Questa classe rappresenta l'apparato iconografico e/o decorativo di un bene culturale, inteso come l'insieme, che può essere più o meno complesso, delle rappresentazioni iconografiche e/o delle decorazioni presenti sul bene."</para>
    /// labels<para>"Iconographic or Decorative Apparatus"</para><para>"Apparato iconografico e decorativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatus">https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatus</seealso>
    let IconographicOrDecorativeApparatus =
        Prefixed_Name(ddesc, "IconographicOrDecorativeApparatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/IconographicOrDecorativeApparatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il tipo (iconografico, decorativo, iconografico-decorativo) di apparato iconografico e decorativo di un bene culturale."</para>
    ///   <para>"This class represents the iconographic or decorative apparatus' type (iconographic, decorative, iconographic-decorative) of a cultual property."</para>
    /// labels<para>"Tipo di apparato iconografico e decorativo"</para><para>"Iconographic Or Decorative Apparatus Type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatusType">https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatusType</seealso>
    let IconographicOrDecorativeApparatusType =
        Prefixed_Name(ddesc, "IconographicOrDecorativeApparatusType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/IdiomaticDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>"Questo individuo rappresenta una denominazione idiomatica."</para>
    ///   <para>"This individual represents an idiomatic designation."</para>
    /// labels<para>"Idiomatic designation"</para><para>"Denominazione idiomatica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/IdiomaticDesignation">https://w3id.org/arco/ontology/denotative-description/IdiomaticDesignation</seealso>
    let IdiomaticDesignation =
        Prefixed_Name(ddesc, "IdiomaticDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ImplementationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta la modalità esecutiva (es.: alternanza, polifonia) associata a una modalità comunicativa (verbale, musicale vocale, musicale strumentale)."</para>
    ///   <para>"This class represents the implementation method (e.g.: polyphonic) associated to a verbale or singing or instrumental communication medium."</para>
    /// labels<para>"Implementation method"</para><para>"Modalità esecutiva"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ImplementationMethod">https://w3id.org/arco/ontology/denotative-description/ImplementationMethod</seealso>
    let ImplementationMethod =
        Prefixed_Name(ddesc, "ImplementationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ImpossibleLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    ///
    /// labels<para>"Leggibilità assente"</para><para>"Impossible legibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ImpossibleLegibility">https://w3id.org/arco/ontology/denotative-description/ImpossibleLegibility</seealso>
    let ImpossibleLegibility =
        Prefixed_Name(ddesc, "ImpossibleLegibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Inaccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAccessibility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Inaccessible"</para><para>"Inaccessibile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Inaccessible">https://w3id.org/arco/ontology/denotative-description/Inaccessible</seealso>
    let Inaccessible = Prefixed_Name(ddesc, "Inaccessible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Inscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un'iscrizione, ovvero qualsiasi scritta o segno grafico volontario, realizzati con qualsiasi tecnica (incisione, pittura, stampa, ecc.)"</para>
    /// labels<para>"Inscription"</para><para>"Iscrizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Inscription">https://w3id.org/arco/ontology/denotative-description/Inscription</seealso>
    let Inscription = Prefixed_Name(ddesc, "Inscription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/InstrumentalCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Comunicazione musicale strumentale"</para><para>"Instrumental communication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/InstrumentalCommunication">https://w3id.org/arco/ontology/denotative-description/InstrumentalCommunication</seealso>
    let InstrumentalCommunication =
        Prefixed_Name(ddesc, "InstrumentalCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/KinesicCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///
    /// labels<para>"Comunicazione cinesica"</para><para>"Kinesic communication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/KinesicCommunication">https://w3id.org/arco/ontology/denotative-description/KinesicCommunication</seealso>
    let KinesicCommunication =
        Prefixed_Name(ddesc, "KinesicCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the legibility status (complete, decent, good, lowered, impossible) of a numinsmatic property. It is related to the property's conservation status."</para>
    ///   <para>"Questa classe rappresenta lo stato di leggibilità (totale, buona, discreta, ridotta, assente) di un bene numismatico, relativamente al suo stato di conservazione."</para>
    /// labels<para>"Legibility"</para><para>"Leggibilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Legibility">https://w3id.org/arco/ontology/denotative-description/Legibility</seealso>
    let Legibility = Prefixed_Name(ddesc, "Legibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Length"</para><para>"Lunghezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Length">https://w3id.org/arco/ontology/denotative-description/Length</seealso>
    let Length = Prefixed_Name(ddesc, "Length") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/LocalDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta una denominazione locale."</para>
    ///   <para>"This individual represents an local designation."</para>
    /// labels<para>"Denominazione locale"</para><para>"Local designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/LocalDesignation">https://w3id.org/arco/ontology/denotative-description/LocalDesignation</seealso>
    let LocalDesignation = Prefixed_Name(ddesc, "LocalDesignation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un logo, ovvero, in ambito commerciale e pubblicitario, scritta e/o simbolo grafico che identifica un prodotto,
    /// un'azienda, ecc."</para>
    /// labels<para>"Logo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Logo">https://w3id.org/arco/ontology/denotative-description/Logo</seealso>
    let Logo = Prefixed_Name(ddesc, "Logo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/LoweredLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/Legibility</para>
    ///
    /// labels<para>"Leggibilità ridotta"</para><para>"Lowered legibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/LoweredLegibility">https://w3id.org/arco/ontology/denotative-description/LoweredLegibility</seealso>
    let LoweredLegibility = Prefixed_Name(ddesc, "LoweredLegibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MassStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta la memoria di massa nella quale è stata memorizzata una fotografia digitale."</para>
    ///   <para>"This individual represents the mass storage where a digital photograph is stored."</para>
    /// labels<para>"Mass storage"</para><para>"Memoria di massa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MassStorage">https://w3id.org/arco/ontology/denotative-description/MassStorage</seealso>
    let MassStorage = Prefixed_Name(ddesc, "MassStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents the material through which an object has been realized, e.g. a cultural entity."</para>
    ///   <para>"Questo individuo rappresenta la materia con cui è realizzato un oggetto, per esempio un bene culturale."</para>
    /// labels<para>"Material"</para><para>"Materia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Material">https://w3id.org/arco/ontology/denotative-description/Material</seealso>
    let Material = Prefixed_Name(ddesc, "Material") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MaterialOrTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta la materia e/o la tecnica con cui è realizzato un oggetto, per esempio un bene culturale. Nel dominio delle normative  ICCD per la catalogazione dei beni culturali, si rende necessario nei casi in cui materia e tecnica sono registrate nello stesso campo, nella forma "materia/ tecnica"."</para>
    ///   <para>"This individual represents the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standard for cataloguing cultural entities, this label is necessary when material and techinque are registered in the same field."</para>
    /// labels<para>"Material or Technique"</para><para>"Materia o tecnica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MaterialOrTechnique">https://w3id.org/arco/ontology/denotative-description/MaterialOrTechnique</seealso>
    let MaterialOrTechnique =
        Prefixed_Name(ddesc, "MaterialOrTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MaximumMinimumWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Maximum / minimum width"</para><para>"Larghezza massima / minima"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MaximumMinimumWidth">https://w3id.org/arco/ontology/denotative-description/MaximumMinimumWidth</seealso>
    let MaximumMinimumWidth =
        Prefixed_Name(ddesc, "MaximumMinimumWidth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MaximumTotalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Maximum total length"</para><para>"Lunghezza totale massima"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalLength">https://w3id.org/arco/ontology/denotative-description/MaximumTotalLength</seealso>
    let MaximumTotalLength = Prefixed_Name(ddesc, "MaximumTotalLength") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MaximumTotalWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Maximum total width"</para><para>"Larghezza totale massima"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalWidth">https://w3id.org/arco/ontology/denotative-description/MaximumTotalWidth</seealso>
    let MaximumTotalWidth = Prefixed_Name(ddesc, "MaximumTotalWidth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a measurement of an object. Measurements realte to the cultural property's dimensions."</para>
    ///   <para>"Questa classe rappresenta una misura osservata per un oggetto. Le misure sono relative alle dimensioni del bene in esame. Per la normativa F, le misure possono essere relative anche a supporti secondari, custodie, cornici, singoli fotogrammi, ecc. Per la normativa VeAC, le misure possono essere relative all'ingombro per l'immagazzinaggio; alla base (individuano l'oggetto e la conformazione fisica del proprietario e sono fondamentali per l'allestimento museale, per individuare i tipi di supporti necessari per l'esposizione); alle maniche."</para>
    /// labels<para>"Misura"</para><para>"Measurement"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Measurement">https://w3id.org/arco/ontology/denotative-description/Measurement</seealso>
    let Measurement = Prefixed_Name(ddesc, "Measurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta l'insieme delle misurazioni osservate per un oggetto. Per la normativa F, le misure possono essere relative anche a supporti secondari, custodie, cornici, singoli fotogrammi, ecc. Per la normativa VeAC, le misure possono essere relative all'ingombro per l'immagazzinaggio; alla base (individuano l'oggetto e la conformazione fisica del proprietario e sono fondamentali per l'allestimento museale, per individuare i tipi di supporti necessari per l'esposizione); alle maniche."</para>
    ///   <para>"This class represents the set of measurments observed for an object."</para>
    /// labels<para>"Collezione di misure"</para><para>"Measurement collection"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MeasurementCollection">https://w3id.org/arco/ontology/denotative-description/MeasurementCollection</seealso>
    let MeasurementCollection =
        Prefixed_Name(ddesc, "MeasurementCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the observed measurement type (width, height, diameter, etc)."</para>
    ///   <para>"Questa classe rappresenta il tipo di misura osservata (larghezza, altezza, diametro, etc.)"</para>
    /// labels<para>"Measurement Type"</para><para>"Tipo di Misura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MeasurementType">https://w3id.org/arco/ontology/denotative-description/MeasurementType</seealso>
    let MeasurementType = Prefixed_Name(ddesc, "MeasurementType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/MediocreConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    ///
    /// labels<para>"Stato di conservazione mediocre"</para><para>"Mediocre conservation status"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/MediocreConservationStatus">https://w3id.org/arco/ontology/denotative-description/MediocreConservationStatus</seealso>
    let MediocreConservationStatus =
        Prefixed_Name(ddesc, "MediocreConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/NoLongerAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAvailability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"No longer available"</para><para>"Non più disponibile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/NoLongerAvailable">https://w3id.org/arco/ontology/denotative-description/NoLongerAvailable</seealso>
    let NoLongerAvailable = Prefixed_Name(ddesc, "NoLongerAvailable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/OccupiedStorageSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Occupied storage space"</para><para>"Memoria occupata"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/OccupiedStorageSpace">https://w3id.org/arco/ontology/denotative-description/OccupiedStorageSpace</seealso>
    let OccupiedStorageSpace =
        Prefixed_Name(ddesc, "OccupiedStorageSpace") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the orientation of an object (i.e. N.W., S.E.), considering the main axis."</para>
    ///   <para>"Questa classe rappresenta l'orientamento di un oggetto (NO, SE, etc.), secondo l'asse principale individuato."</para>
    /// labels<para>"Orientation"</para><para>"Orientamento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Orientation">https://w3id.org/arco/ontology/denotative-description/Orientation</seealso>
    let Orientation = Prefixed_Name(ddesc, "Orientation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/OriginalDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>"Questo individuo rappresenta una denominazione originaria."</para>
    ///   <para>"This individual represents original designation."</para>
    /// labels<para>"Denominazione originaria"</para><para>"Original designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/OriginalDesignation">https://w3id.org/arco/ontology/denotative-description/OriginalDesignation</seealso>
    let OriginalDesignation =
        Prefixed_Name(ddesc, "OriginalDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/OrnamentalMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il motivo decorativo (antropomorfo, zoomorfo, geometrico) rappresentato da un apparato iconografico e decorativo di un bene culturale."</para>
    ///   <para>"This class represents the ornamental motif (anthropomorphous, zoomorphic, geometric) represented by a cultural property's iconographic and decorative apparatus."</para>
    /// labels<para>"Ornamental Motif"</para><para>"Motivo decorativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/OrnamentalMotif">https://w3id.org/arco/ontology/denotative-description/OrnamentalMotif</seealso>
    let OrnamentalMotif = Prefixed_Name(ddesc, "OrnamentalMotif") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/OtherLanguageDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents a designation in other language."</para>
    ///   <para>"Questo individuo rappresenta una denominazione in altra lingua."</para>
    /// labels<para>"Denominazione in altra lingua"</para><para>"Other language designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/OtherLanguageDesignation">https://w3id.org/arco/ontology/denotative-description/OtherLanguageDesignation</seealso>
    let OtherLanguageDesignation =
        Prefixed_Name(ddesc, "OtherLanguageDesignation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/PartiallyAccessible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/CulturalPropertyAccessibility</para>
    ///
    /// labels<para>"Partially accessible"</para><para>"Parzialmente accessibile"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/PartiallyAccessible">https://w3id.org/arco/ontology/denotative-description/PartiallyAccessible</seealso>
    let PartiallyAccessible =
        Prefixed_Name(ddesc, "PartiallyAccessible") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Perimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Perimeter"</para><para>"Perimetro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Perimeter">https://w3id.org/arco/ontology/denotative-description/Perimeter</seealso>
    let Perimeter = Prefixed_Name(ddesc, "Perimeter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/PhotoColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents a digital photograph's colour, i.e. black and white or colours."</para>
    ///   <para>"Questo individuo rappresenta il colore della fotografia digitale, ovvero se trattasi di fotografia in bianco/nero o a colori."</para>
    /// labels<para>"Photo colour"</para><para>"Colore della fotografia"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/PhotoColour">https://w3id.org/arco/ontology/denotative-description/PhotoColour</seealso>
    let PhotoColour = Prefixed_Name(ddesc, "PhotoColour") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/PhotoProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta il programma di visualizzazione, memorizzazione ed elaborazione utilizzato per la fotografia digitale."</para>
    ///   <para>"This individual represents the visualization, storage and processing program used for a digital photograph."</para>
    /// labels<para>"Programma per la fotografia digitale"</para><para>"Photo program"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/PhotoProgram">https://w3id.org/arco/ontology/denotative-description/PhotoProgram</seealso>
    let PhotoProgram = Prefixed_Name(ddesc, "PhotoProgram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/PhotoSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta il formato di una fotografia digitale, inteso come la dimensione standardizzata dei materiali fotografici (negativi, positivi, ecc.)."</para>
    ///   <para>"This individual represents a digital photograph format, intended as the photogrphic material's standardised size (e.g. negative, positives)."</para>
    /// labels<para>"Dimensioni della foto (Formato)"</para><para>"Photo size"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/PhotoSize">https://w3id.org/arco/ontology/denotative-description/PhotoSize</seealso>
    let PhotoSize = Prefixed_Name(ddesc, "PhotoSize") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/PixelDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta le dimensioni, in pixel, di una fotografia digitale."</para>
    ///   <para>"This individual represents a digital photograph size in pixels."</para>
    /// labels<para>"Pixel dimension"</para><para>"Dimensioni in pixel"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/PixelDimension">https://w3id.org/arco/ontology/denotative-description/PixelDimension</seealso>
    let PixelDimension = Prefixed_Name(ddesc, "PixelDimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Power"</para><para>"Potenza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Power">https://w3id.org/arco/ontology/denotative-description/Power</seealso>
    let Power = Prefixed_Name(ddesc, "Power") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/ProxemicsCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Comunicazione prossemica"</para><para>"Proxemics communication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/ProxemicsCommunication">https://w3id.org/arco/ontology/denotative-description/ProxemicsCommunication</seealso>
    let ProxemicsCommunication =
        Prefixed_Name(ddesc, "ProxemicsCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/QualityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Questo individuo rappresenta il livello di qualità di una risorsa digitale (es.: alta risoluzione, bassa risoluzione, preview)"</para>
    ///   <para>"This individual represents a digital resource's quality level, e.g. high-resolution, low-resolution, preview."</para>
    /// labels<para>"Quality level"</para><para>"Livello di qualità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/QualityLevel">https://w3id.org/arco/ontology/denotative-description/QualityLevel</seealso>
    let QualityLevel = Prefixed_Name(ddesc, "QualityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"This individual represents the specific value and resolution used for storing a digital photograph."</para>
    ///   <para>"Questo individuo rappresenta la risoluzione e il valore specifico utilizzati per la memorizzazione di una fotografia digitale."</para>
    /// labels<para>"Resolution"</para><para>"Risoluzione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Resolution">https://w3id.org/arco/ontology/denotative-description/Resolution</seealso>
    let Resolution = Prefixed_Name(ddesc, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/SampleCollected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta un campione prelevato da un bene archeologico."</para>
    ///   <para>"This class represents a sample collected from an archeological property."</para>
    /// labels<para>"Sample collected"</para><para>"Campione prelevato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/SampleCollected">https://w3id.org/arco/ontology/denotative-description/SampleCollected</seealso>
    let SampleCollected = Prefixed_Name(ddesc, "SampleCollected") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/SampleCollectedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the sample type collected from an archaeologiacal property (i.e. coal, pottery, grout)"</para>
    ///   <para>"Questa classe rappresenta il tipo di campione prelevato da un bene archeologico (es.: carbone, ceramica, intonaco, etc.)"</para>
    /// labels<para>"Sample collected type"</para><para>"Tipo di campione prelevato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/SampleCollectedType">https://w3id.org/arco/ontology/denotative-description/SampleCollectedType</seealso>
    let SampleCollectedType =
        Prefixed_Name(ddesc, "SampleCollectedType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents an object's shape. It is used for bidimensional objects, e.g. octagonal or round shape."</para>
    ///   <para>"Questo individuo rappresenta la forma di un oggetto, per oggetti bidimensionali (es.: ottagonale, tondo)"</para>
    /// labels<para>"Shape"</para><para>"Formato"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Shape">https://w3id.org/arco/ontology/denotative-description/Shape</seealso>
    let Shape = Prefixed_Name(ddesc, "Shape") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/SingingCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Comunicazione musicale vocale"</para><para>"Singing communication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/SingingCommunication">https://w3id.org/arco/ontology/denotative-description/SingingCommunication</seealso>
    let SingingCommunication =
        Prefixed_Name(ddesc, "SingingCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/SlangDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/DesignationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents a slang designation."</para>
    ///   <para>"Questo individuo rappresenta una denominazione gergale."</para>
    /// labels<para>"Denominazione gergale"</para><para>"Slang designation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/SlangDesignation">https://w3id.org/arco/ontology/denotative-description/SlangDesignation</seealso>
    let SlangDesignation = Prefixed_Name(ddesc, "SlangDesignation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Stamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il segno impresso con un timbro, ovvero uno strumento di gomma o di metallo per imprimere segni a inchiostro oppure a secco."</para>
    /// labels<para>"Stamp"</para><para>"Timbro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Stamp">https://w3id.org/arco/ontology/denotative-description/Stamp</seealso>
    let Stamp = Prefixed_Name(ddesc, "Stamp") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/StorageCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Storage capacity"</para><para>"Capacità di memoria"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/StorageCapacity">https://w3id.org/arco/ontology/denotative-description/StorageCapacity</seealso>
    let StorageCapacity = Prefixed_Name(ddesc, "StorageCapacity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/StorageMethodColourDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta il metodo e la profondità di colore con cui è stata memorizzata la fotografia digitale."</para>
    ///   <para>"This individual represents the method and color depth through which a digital photograph has been stored."</para>
    /// labels<para>"Metodo di memorizzazione e profondità di colore"</para><para>"Storage method and colour depth"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/StorageMethodColourDepth">https://w3id.org/arco/ontology/denotative-description/StorageMethodColourDepth</seealso>
    let StorageMethodColourDepth =
        Prefixed_Name(ddesc, "StorageMethodColourDepth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the support on which an element can be located, for instance an inscription, emblem, postmark represented on a cultural property (i.e. "paper label")."</para>
    ///   <para>"Questa classe rappresenta il supporto sul quale può trovarsi un elemento, per esempio un'iscrizione, un emblema, un timbro, etc., rappresentati su un bene culturale (es. "etichetta di carta")."</para>
    /// labels<para>"Support"</para><para>"Supporto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Support">https://w3id.org/arco/ontology/denotative-description/Support</seealso>
    let Support = Prefixed_Name(ddesc, "Support") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta una caratteristica tecnica relativa a un bene culturale. Per esempio, può rappresentare una particolare materia di cui è composto, la tecnica con cui è stato realizzato, la sua forma, il suo colore. Ogni caratteristica tecnica utilizza è definito da un concetto (es.: "terracotta" è una caratteristica tecnica definita dal concetto "materia", relativamente a un bene culturale). Per ogni tipologia di bene culturale possono essere rilevati e registrate caratteristiche tecnice specifiche."</para>
    ///   <para>"This class represents a characteristic of a cultural property. For example it can represent a cultural property's particular costituent material or the technique with which it was made or its shape or color. Each technical characteristic is classified by a concept (i.e. "clay" is a techical characteristic classified by the technical concept "material" related to a cultural property). For each cultural property typology can be registered some specific technical characteristics."</para>
    /// labels<para>"Caratteristica tecnica"</para><para>"Technical Characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/TechnicalCharacteristic">https://w3id.org/arco/ontology/denotative-description/TechnicalCharacteristic</seealso>
    let TechnicalCharacteristic =
        Prefixed_Name(ddesc, "TechnicalCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a technical concept, a particular type of concept that classifies a technical characteristic of an entity, e.g. cultural property. For instance, "material" is a techincal concept that classifies the technical characteristic "pottery" related to a cultural property."</para>
    ///   <para>"Questa classe rappresenta un concetto tecnico, inteso come tipo particolare di concetto che fornisce una classificazione a una caratteristica tecnica di un'entità, es. un bene culturale. Per esempio, "materia" è un concetto tecnico che può essere utilizzato per classificare la caratteristica tecnica "terracotta" relativa a un bene culturale."</para>
    /// labels<para>"Concetto tecnico"</para><para>"Technical concept"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/TechnicalConcept">https://w3id.org/arco/ontology/denotative-description/TechnicalConcept</seealso>
    let TechnicalConcept = Prefixed_Name(ddesc, "TechnicalConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalDetailOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/TechnicalDetailOccurrence">https://w3id.org/arco/ontology/denotative-description/TechnicalDetailOccurrence</seealso>
    let TechnicalDetailOccurrence =
        Prefixed_Name(ddesc, "TechnicalDetailOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This individual represents an object's execution technique."</para>
    ///   <para>"Questo individuo rappresenta la tecnica di esecuzione di un oggetto, per esempio un bene culturale."</para>
    /// labels<para>"Tecnica"</para><para>"Technique"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Technique">https://w3id.org/arco/ontology/denotative-description/Technique</seealso>
    let Technique = Prefixed_Name(ddesc, "Technique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Temperament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"Questo individuo rappresenta il temperamento adottato, soprattutto in caso di oggetto in condizioni originali, o dopo un restauro, di uno strumento musicale. Per gli idiofoni a tasti fissi (come xilofoni, litofoni, metallofoni) rappresenta la successione degli intervalli."</para>
    ///   <para>"This individual represents a musical instrument adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals."</para>
    /// labels<para>"Temperamento"</para><para>"Temperament"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Temperament">https://w3id.org/arco/ontology/denotative-description/Temperament</seealso>
    let Temperament = Prefixed_Name(ddesc, "Temperament") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Thickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Thickness"</para><para>"Spessore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Thickness">https://w3id.org/arco/ontology/denotative-description/Thickness</seealso>
    let Thickness = Prefixed_Name(ddesc, "Thickness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Tuning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"This individual represents a musical instrument tuning."</para>
    ///   <para>"Questo individuo rappresenta l'accordatura di uno strumento musicale."</para>
    /// labels<para>"Tuning"</para><para>"Accordatura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Tuning">https://w3id.org/arco/ontology/denotative-description/Tuning</seealso>
    let Tuning = Prefixed_Name(ddesc, "Tuning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/UnavailableConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/ConservationStatusType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Dato sullo stato di conservazione non disponibile"</para><para>"Data on conservation status unavailable"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/UnavailableConservationStatus">https://w3id.org/arco/ontology/denotative-description/UnavailableConservationStatus</seealso>
    let UnavailableConservationStatus =
        Prefixed_Name(ddesc, "UnavailableConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/UndetectedMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/UndetectedMeasurements">https://w3id.org/arco/ontology/denotative-description/UndetectedMeasurements</seealso>
    let UndetectedMeasurements =
        Prefixed_Name(ddesc, "UndetectedMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/VariousMeasurements</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Various misurements"</para><para>"Misure varie"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/VariousMeasurements">https://w3id.org/arco/ontology/denotative-description/VariousMeasurements</seealso>
    let VariousMeasurements =
        Prefixed_Name(ddesc, "VariousMeasurements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/VerbalCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Comunicazione verbale"</para><para>"Verbal communication"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/VerbalCommunication">https://w3id.org/arco/ontology/denotative-description/VerbalCommunication</seealso>
    let VerbalCommunication =
        Prefixed_Name(ddesc, "VerbalCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/VibratingLenght</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/TechnicalConcept</para>
    ///   <para>"This individual represents a musical instrument vibrating length, in particular a chordophone."</para>
    ///   <para>"Questo individuo rappresenta la lunghezza vibrante di uno strumento, in particolare di un cordofono."</para>
    /// labels<para>"Vibrating lenght"</para><para>"Lunghezza vibrante"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/VibratingLenght">https://w3id.org/arco/ontology/denotative-description/VibratingLenght</seealso>
    let VibratingLenght = Prefixed_Name(ddesc, "VibratingLenght") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Volume"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Volume">https://w3id.org/arco/ontology/denotative-description/Volume</seealso>
    let Volume = Prefixed_Name(ddesc, "Volume") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/VolumetricDiamensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Volumetric dimensions"</para><para>"Ingombro"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/VolumetricDiamensions">https://w3id.org/arco/ontology/denotative-description/VolumetricDiamensions</seealso>
    let VolumetricDiamensions =
        Prefixed_Name(ddesc, "VolumetricDiamensions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/WaistCircumference</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Waist Circumference"</para><para>"Circonferenza vita"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/WaistCircumference">https://w3id.org/arco/ontology/denotative-description/WaistCircumference</seealso>
    let WaistCircumference = Prefixed_Name(ddesc, "WaistCircumference") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///
    /// labels<para>"Peso"</para><para>"Weight"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Weight">https://w3id.org/arco/ontology/denotative-description/Weight</seealso>
    let Weight = Prefixed_Name(ddesc, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/Width</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/MeasurementType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Width"</para><para>"Larghezza"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/Width">https://w3id.org/arco/ontology/denotative-description/Width</seealso>
    let Width = Prefixed_Name(ddesc, "Width") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/WritingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Questa classe rappresenta il sistema di scrittura/alfabeto adottati in una iscrizione, un timbro, uno stemma, etc."</para>
    ///   <para>"This class represents the writing system or alphabet of an inscription, postmark, crest etc."</para>
    /// labels<para>"Writing system"</para><para>"Sistema di scrittura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/WritingSystem">https://w3id.org/arco/ontology/denotative-description/WritingSystem</seealso>
    let WritingSystem = Prefixed_Name(ddesc, "WritingSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/WrittenCommunication</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:arco/ontology/denotative-description/CommunicationMediumType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Written communication"</para><para>"Comunicazione scritta"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/WrittenCommunication">https://w3id.org/arco/ontology/denotative-description/WrittenCommunication</seealso>
    let WrittenCommunication =
        Prefixed_Name(ddesc, "WrittenCommunication") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/anthropologicalMaterialMorphology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la morfologia di un reperto antropologico (es.: morfologia naturale; morfologia alterata intra-vitam per cause naturali e/o per intervento antropico; morfologia/ struttura alterata post-mortem per cause naturali)."</para>
    ///   <para>"This property represents the morphology of an anthropological material."</para>
    /// labels<para>"anthropological material morphology"</para><para>"morfologia di reperto antropologico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/anthropologicalMaterialMorphology">https://w3id.org/arco/ontology/denotative-description/anthropologicalMaterialMorphology</seealso>
    let anthropologicalMaterialMorphology =
        Prefixed_Name(ddesc, "anthropologicalMaterialMorphology") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/areAvailableNotesOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has available notes"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha note producibili"."</para>
    /// labels<para>"sono note producibili di"</para><para>"are available notes of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/areAvailableNotesOf">https://w3id.org/arco/ontology/denotative-description/areAvailableNotesOf</seealso>
    let areAvailableNotesOf =
        Prefixed_Name(ddesc, "areAvailableNotesOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/classifiesCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "è caratteristica classificata da", collega un concetto tecnico a una caratteristica tecnica di un'entità - come un bene culturale."</para>
    ///   <para>"This property connects a techical concept to an entity's technical characteristic. It is the inverse property of isCharacteristicClassifiedBy."</para>
    /// labels<para>"classifies technical characteristic"</para><para>"classifica caratteristica tecnica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/classifiesCharacteristic">https://w3id.org/arco/ontology/denotative-description/classifiesCharacteristic</seealso>
    let classifiesCharacteristic =
        Prefixed_Name(ddesc, "classifiesCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the date of construction of a musical instrument's accessory."</para>
    ///   <para>"Questa proprietà rappresenta la data di costruzione di un accessorio di uno strumento musicale."</para>
    /// labels<para>"creation date"</para><para>"data di creazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/creationDate">https://w3id.org/arco/ontology/denotative-description/creationDate</seealso>
    let creationDate = Prefixed_Name(ddesc, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasAccessory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a musical good to one of its accessories. In other words, it is an object linkable to a musical object, whether it is functional to the sound production, or if it is the sound's production or conservation medium."</para>
    ///   <para>"Questa proprietà collega un bene musicale a un suo accessorio, ovvero un oggetto collegabile al bene musicale, sia nel caso in cui sia funzionale alla produzione del suono, sia nel caso in cui sia di supporto alla produzione del suono o alla conservazione o alla prassi musicale del bene."</para>
    /// labels<para>"has accessory"</para><para>"ha accessorio"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasAccessory">https://w3id.org/arco/ontology/denotative-description/hasAccessory</seealso>
    let hasAccessory = Prefixed_Name(ddesc, "hasAccessory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasAffixedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural property to an element affixed on it (e.g. inscription, stamp, etc.)"</para>
    ///   <para>"Questa proprietà collega un bene culturale a un elemento apposto sul bene (es.: emblema, timbro, iscrizione, etc.)"</para>
    /// labels<para>"has element affixed to cultural property"</para><para>"ha elemento apposto sul bene"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElement">https://w3id.org/arco/ontology/denotative-description/hasAffixedElement</seealso>
    let hasAffixedElement = Prefixed_Name(ddesc, "hasAffixedElement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasAffixedElementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'iscrizione, un emblema, un timbro, uno stemma, etc., al suo tipo (es.: gentilizio, civile, religioso, etc.)"</para>
    ///   <para>"This property relatesan inscription (or an emblem, a mark, etc.) to its type."</para>
    /// labels<para>"has affixed element type"</para><para>"ha tipo di elemento apposto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElementType">https://w3id.org/arco/ontology/denotative-description/hasAffixedElementType</seealso>
    let hasAffixedElementType =
        Prefixed_Name(ddesc, "hasAffixedElementType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasAvailableNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno strumento musicale, dal grave all'acuto, alle note producibili dallo strumento."</para>
    ///   <para>"This property relates a musical instrument to the playable notes by it, from low to high."</para>
    /// labels<para>"ha note producibili"</para><para>"has available notes"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasAvailableNotes">https://w3id.org/arco/ontology/denotative-description/hasAvailableNotes</seealso>
    let hasAvailableNotes = Prefixed_Name(ddesc, "hasAvailableNotes") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCommunicationMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale immateriale a una modalità comunicativa mediante la quale il bene viene veicolato."</para>
    ///   <para>"This property relates an intangible cultural property to a communication medium."</para>
    /// labels<para>"has communication medium"</para><para>"ha modalità comunicativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMedium">https://w3id.org/arco/ontology/denotative-description/hasCommunicationMedium</seealso>
    let hasCommunicationMedium =
        Prefixed_Name(ddesc, "hasCommunicationMedium") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCommunicationMediumType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una modalità comunicativa di un oggetto al tipo di modalità comunicativa (verbale, strumentale, etc.)"</para>
    ///   <para>"This property relates a communication medium to its type (e.g.: verbal, singing, etc.)"</para>
    /// labels<para>"has communication medium type"</para><para>"ha tipo di modalità comunicativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMediumType">https://w3id.org/arco/ontology/denotative-description/hasCommunicationMediumType</seealso>
    let hasCommunicationMediumType =
        Prefixed_Name(ddesc, "hasCommunicationMediumType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasConservationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates the cultural property with its conservation status."</para>
    ///   <para>"Questa proprietà associa il bene culturale al suo stato di conservazione."</para>
    /// labels<para>"has conservation status"</para><para>"ha stato di conservazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatus">https://w3id.org/arco/ontology/denotative-description/hasConservationStatus</seealso>
    let hasConservationStatus =
        Prefixed_Name(ddesc, "hasConservationStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasConservationStatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà associa lo stato di conservazione a uno dei valori del tipo di stato di conservazione."</para>
    ///   <para>"This property relates a conservation status to one of its type's values."</para>
    /// labels<para>"ha tipo di stato di conservazione"</para><para>"has conservation status type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatusType">https://w3id.org/arco/ontology/denotative-description/hasConservationStatusType</seealso>
    let hasConservationStatusType =
        Prefixed_Name(ddesc, "hasConservationStatusType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCulturalPropertyAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il bene culturale alla sua accessibilità, ovvero la possibilità di accedere al bene, in tutto o in parte, per esempio per effettuare un esame diretto finalizzato alla catalogazione (es.: un bene immobile posto in un luogo recintato non accessibile, un bene mobile che non si può osservare da vicino perché posto troppo in alto su una parete; un bene totalmente accessibile, etc.)."</para>
    ///   <para>"This property relates the cultural property to its accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)"</para>
    /// labels<para>"has cultural property accessibility"</para><para>"ha accessibilità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAccessibility">https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAccessibility</seealso>
    let hasCulturalPropertyAccessibility =
        Prefixed_Name(ddesc, "hasCulturalPropertyAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCulturalPropertyAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega il bene culturale alla sua disponibilità materiale, ovvero se il bene è materialmente disponibile, per esempio per attività di catalogazione, o se non è disponibile (es.: furto, distruzione)"</para>
    ///   <para>"This class relates the cultural property to its availability, that is wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities."</para>
    /// labels<para>"has cultural property availability"</para><para>"ha disponibilità materiale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAvailability">https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAvailability</seealso>
    let hasCulturalPropertyAvailability =
        Prefixed_Name(ddesc, "hasCulturalPropertyAvailability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCulturalPropertyDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega la tipologia di un bene culturale a una delle sue componenti, cioè la definizione."</para>
    ///   <para>"This property relates a cultural entity's typology to one of its components, i.e.  its definition."</para>
    /// labels<para>"has cultural property definition"</para><para>"ha definizione del bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyDefinition">https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyDefinition</seealso>
    let hasCulturalPropertyDefinition =
        Prefixed_Name(ddesc, "hasCulturalPropertyDefinition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCulturalPropertySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity's typology to its components, i.e. morphological and functional specifications."</para>
    ///   <para>"Questa proprietà collega la tipologia di un bene culturale a una delle sue componenti, cioè alle specifiche morfologiche e funzionali."</para>
    /// labels<para>"ha specifiche del bene culturale"</para><para>"has cultural property specification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertySpecification">https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertySpecification</seealso>
    let hasCulturalPropertySpecification =
        Prefixed_Name(ddesc, "hasCulturalPropertySpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasCulturalPropertyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene culturale al tipo di bene, per permettere la corretta e precisa individuazione del bene."</para>
    ///   <para>"This property relates a cultural property to its type."</para>
    /// labels<para>"ha tipo di bene culturale"</para><para>"has cultural property type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyType">https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyType</seealso>
    let hasCulturalPropertyType =
        Prefixed_Name(ddesc, "hasCulturalPropertyType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasDedicatee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una dedica al dedicatario, cioè alla persona o ente cui è rivolta la dedica."</para>
    ///   <para>"This property connects a dedication to its dedicaatee, which is the person or institution to whom the dedication is addressed."</para>
    /// labels<para>"has dedicatee"</para><para>"ha dedicatario"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasDedicatee">https://w3id.org/arco/ontology/denotative-description/hasDedicatee</seealso>
    let hasDedicatee = Prefixed_Name(ddesc, "hasDedicatee") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasDesignationInTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà associa un bene culturale alla sua denominazione e/o dedicazione o, per la normativa FF, titolo, nel corso del tempo."</para>
    ///   <para>"This property connects a cultural entity to its denomination and/or dedication, or title (for FF legislation) over time."</para>
    /// labels<para>"ha designazione nel tempo"</para><para>"has designation in time"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasDesignationInTime">https://w3id.org/arco/ontology/denotative-description/hasDesignationInTime</seealso>
    let hasDesignationInTime =
        Prefixed_Name(ddesc, "hasDesignationInTime") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasDesignationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural entity designation to its type."</para>
    /// labels<para>"has designation type"</para><para>"ha tipo di denominazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasDesignationType">https://w3id.org/arco/ontology/denotative-description/hasDesignationType</seealso>
    let hasDesignationType = Prefixed_Name(ddesc, "hasDesignationType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasDiapason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno strumento musical al corista rilevato (nota, temperatura ed eventualmente umidità ambientale al momento della rilevazione)."</para>
    ///   <para>"This property relates a musical instrument to the identified diapason (note, temperature and eventually humidity during the detection)."</para>
    /// labels<para>"has diapason"</para><para>"ha corista"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasDiapason">https://w3id.org/arco/ontology/denotative-description/hasDiapason</seealso>
    let hasDiapason = Prefixed_Name(ddesc, "hasDiapason") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno strumento musicale alla sua estensione musicale."</para>
    ///   <para>"This property relates a musical instrument to its extension."</para>
    /// labels<para>"has extension"</para><para>"ha estensione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasExtension">https://w3id.org/arco/ontology/denotative-description/hasExtension</seealso>
    let hasExtension = Prefixed_Name(ddesc, "hasExtension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasFileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una risorsa digitale su supporto informatico al formato utilizzato per la scrittura della risorsa."</para>
    ///   <para>"This property relates a digital resource to the format used to write it on a data medium."</para>
    /// labels<para>"has file format"</para><para>"ha formato di estensione/compressione del file"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasFileFormat">https://w3id.org/arco/ontology/denotative-description/hasFileFormat</seealso>
    let hasFileFormat = Prefixed_Name(ddesc, "hasFileFormat") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasFiligree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an artwork, painting, photography, print to its filigree."</para>
    ///   <para>"Questa proprietà collega un'opera d'arte, un disegno, una fotografia, una stampa alla sua filigrana."</para>
    /// labels<para>"ha filigrana"</para><para>"has filigree"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasFiligree">https://w3id.org/arco/ontology/denotative-description/hasFiligree</seealso>
    let hasFiligree = Prefixed_Name(ddesc, "hasFiligree") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasFontStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects an inscription or emblem, postmark, crest, etc. to the font style which has been adopted (e.g.: italic, bold, gothic etc)."</para>
    ///   <para>"Questa proprietà collega un'iscrizione, uno stemma, un timbro, etc., al tipo di caratteri che viene adottato (es.: corsivo, grassetto, caratteri gotici, etc.)."</para>
    /// labels<para>"has font style"</para><para>"ha tipo di caratteri"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasFontStyle">https://w3id.org/arco/ontology/denotative-description/hasFontStyle</seealso>
    let hasFontStyle = Prefixed_Name(ddesc, "hasFontStyle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasFunctionalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property realtes an object (e.g. cultural entity, iconographic/decorative apparatus, affixed element like an inscription) to its functional purpose, intended as the function the object has to perform (decorative, religious, symbolic, magic-offensive etc.)."</para>
    ///   <para>"Questa proprietà collega un oggetto (es bene culturale, apparato iconografico/decorativo o elemento apposto su un bene culturale come un'iscrizione) al suo scopo funzionale (decorativo, religioso, simbolico, magico-offensivo, etc.), inteso come funzione che deve svolgere."</para>
    /// labels<para>"ha scopo funzionale"</para><para>"has functional purpose"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasFunctionalPurpose">https://w3id.org/arco/ontology/denotative-description/hasFunctionalPurpose</seealso>
    let hasFunctionalPurpose =
        Prefixed_Name(ddesc, "hasFunctionalPurpose") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasGarmentAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an ancient or contemporary garment to the technical definition of textured fabrics, according to the standard provided by C.I.E.T.A., or laces. It can represent the dinstinction between plain fabric and textured fabric."</para>
    ///   <para>"Questa proprietà collega un vestimento antico o contemporaneo alla definizione tecnica completa dei tessuti, secondo le norme fornite dal C.I.E.T.A., o dei merletti, oppure rappresenta la distinzione fra tessuto unito e tessuto operato."</para>
    /// labels<para>"ha analisi del vestimento"</para><para>"has garment analysis"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasGarmentAnalysis">https://w3id.org/arco/ontology/denotative-description/hasGarmentAnalysis</seealso>
    let hasGarmentAnalysis = Prefixed_Name(ddesc, "hasGarmentAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasGarmentColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an ancient and contemporary garment to its dominant color, usually it is base fabric's color, or the interlaced decoration's color."</para>
    ///   <para>"Questa proprietà collega un vestimento antico o contemporaneo al colore dominante, di solito quello del fondo del tessuto, o quello risultante dall'intreccio."</para>
    /// labels<para>"ha colore del vestimento"</para><para>"has garment colour"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasGarmentColour">https://w3id.org/arco/ontology/denotative-description/hasGarmentColour</seealso>
    let hasGarmentColour = Prefixed_Name(ddesc, "hasGarmentColour") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a cultural enitity to its iconographic or decorative apparatus."</para>
    ///   <para>"Questa proprietà collega un bene culturale al suo apparato iconografico e/o decorativo, inteso come l'insieme, che può essere più o meno complesso, delle rappresentazioni iconografiche e/o delle decorazioni presenti sul bene."</para>
    /// labels<para>"has iconographic or decorative apparatus"</para><para>"ha apparato iconografico e decorativo"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus">https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus</seealso>
    let hasIconographicOrDecorativeApparatus =
        Prefixed_Name(ddesc, "hasIconographicOrDecorativeApparatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà collega un apparato iconografico e decorativo di un bene culturale al tipo di apparato (iconografico, decorativo, iconografico-decorativo)."</para>
    ///   <para>"This property relates a iconographic or decorative apparatus to its type."</para>
    /// labels<para>"ha tipo di apparato iconografico e decorativo"</para><para>"has iconographic or decorative apparatus type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType">https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType</seealso>
    let hasIconographicOrDecorativeApparatusType =
        Prefixed_Name(ddesc, "hasIconographicOrDecorativeApparatusType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasImplementationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una modalità comunicativa verbale o musicale vocale o musicale strumentale alla modalità esecutiva associata (es.: polifonica)."</para>
    ///   <para>"This property relates a verbal or singing or instrumental communication medium to its implementation method (e.g.: polyphonic) associated to it."</para>
    /// labels<para>"has implementation method"</para><para>"ha modalità esecutiva"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasImplementationMethod">https://w3id.org/arco/ontology/denotative-description/hasImplementationMethod</seealso>
    let hasImplementationMethod =
        Prefixed_Name(ddesc, "hasImplementationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasLegibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a numismatic entity's conservation status to its legibility status."</para>
    ///   <para>"Questa proprietà collega lo stato di conservazione di un bene numismatico al suo stato di leggibilità."</para>
    /// labels<para>"ha leggibilità"</para><para>"has legibility"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasLegibility">https://w3id.org/arco/ontology/denotative-description/hasLegibility</seealso>
    let hasLegibility = Prefixed_Name(ddesc, "hasLegibility") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasLocationSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà rappresenta l'area rappresentata come soggetto di un bene culturale."</para>
    ///   <para>"This property represent the location as a subject of a cultural entity."</para>
    /// labels<para>"ha localizzazione rappresentata"</para><para>"has location as subject"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasLocationSubject">https://w3id.org/arco/ontology/denotative-description/hasLocationSubject</seealso>
    let hasLocationSubject = Prefixed_Name(ddesc, "hasLocationSubject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMassStorage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una risorsa digitale alla memoria di massa nella quale è stata memorizzata la fotografia digitale."</para>
    ///   <para>"This property relates a digital photograph to the mass storage where a digital photograph is stored."</para>
    /// labels<para>"ha memoria di massa"</para><para>"has mass storage"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMassStorage">https://w3id.org/arco/ontology/denotative-description/hasMassStorage</seealso>
    let hasMassStorage = Prefixed_Name(ddesc, "hasMassStorage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto (per esempio un bene culturale) alla materia con cui è realizzato."</para>
    ///   <para>"This property relates an object to its material."</para>
    /// labels<para>"ha materia"</para><para>"has material"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMaterial">https://w3id.org/arco/ontology/denotative-description/hasMaterial</seealso>
    let hasMaterial = Prefixed_Name(ddesc, "hasMaterial") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMaterialOrTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates an object to the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standards for cataloguing cultural entities, this label is necessary when material and technique are registered in the same field."</para>
    ///   <para>"Questa proprietà collega un oggetto alla materia e/o la tecnica con cui è realizzato l'oggetto, per esempio un bene culturale. Nel dominio delle normative  ICCD per la catalogazione dei beni culturali, si rende necessaria nei casi in cui materia e tecnica sono registrate nello stesso campo, nella forma "materia/ tecnica"."</para>
    /// labels<para>"has material or technique"</para><para>"ha materia e tecnica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMaterialOrTechnique">https://w3id.org/arco/ontology/denotative-description/hasMaterialOrTechnique</seealso>
    let hasMaterialOrTechnique =
        Prefixed_Name(ddesc, "hasMaterialOrTechnique") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects a set of observed measures on an object to one of those measures."</para>
    ///   <para>"Questa proprietà collega un insieme di misure osservate per un oggetto a una delle misure."</para>
    /// labels<para>"ha misura"</para><para>"has measurement"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMeasurement">https://w3id.org/arco/ontology/denotative-description/hasMeasurement</seealso>
    let hasMeasurement = Prefixed_Name(ddesc, "hasMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMeasurementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto all'insieme delle misure osservate per quell'oggetto."</para>
    ///   <para>"This property connects an object to the collection of observed measures on it."</para>
    /// labels<para>"has measurement collection"</para><para>"ha collezione di misure"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementCollection">https://w3id.org/arco/ontology/denotative-description/hasMeasurementCollection</seealso>
    let hasMeasurementCollection =
        Prefixed_Name(ddesc, "hasMeasurementCollection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasMeasurementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una misura al tipo di misura (altezza, larghezza, diametro, etc.)"</para>
    ///   <para>"This property relates a measurement to its type."</para>
    /// labels<para>"ha tipo di misura"</para><para>"has measurement type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementType">https://w3id.org/arco/ontology/denotative-description/hasMeasurementType</seealso>
    let hasMeasurementType = Prefixed_Name(ddesc, "hasMeasurementType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto al suo orientamento, secondo l'asse principale individuato."</para>
    ///   <para>"This property connects an object to its orientation, considering its major axis."</para>
    /// labels<para>"ha orientamento"</para><para>"has orientation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasOrientation">https://w3id.org/arco/ontology/denotative-description/hasOrientation</seealso>
    let hasOrientation = Prefixed_Name(ddesc, "hasOrientation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasOrnamentalMotif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects a cultural entity's iconographic or decorative apparatus to its ornamental motif (anthropomorphic, zoomorphic, geometric)."</para>
    ///   <para>"Questa proprietà collega l'apparato iconografico e decorativo di un bene culturale al motivo decorativo (antropomorfo, zoomorfo, geometrico) rappresentato."</para>
    /// labels<para>"ha motivo decorativo"</para><para>"has ornamental motif"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasOrnamentalMotif">https://w3id.org/arco/ontology/denotative-description/hasOrnamentalMotif</seealso>
    let hasOrnamentalMotif = Prefixed_Name(ddesc, "hasOrnamentalMotif") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasPhotoColour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a digital photograph to its colour, i.e. black and white or colours."</para>
    ///   <para>"Questo individuo collega una fotografia digitale al colore della fotografia digitale, ovvero se trattasi di fotografia in bianco/nero o a colori."</para>
    /// labels<para>"ha colore della foto"</para><para>"has photo colour"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasPhotoColour">https://w3id.org/arco/ontology/denotative-description/hasPhotoColour</seealso>
    let hasPhotoColour = Prefixed_Name(ddesc, "hasPhotoColour") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasPhotoProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a digital photograph to the visualization, storage and processing program used for the digital photograph."</para>
    ///   <para>"Questa proprietà collega una fotografia digitale al programma di visualizzazione, memorizzazione ed elaborazione utilizzato per la fotografia digitale."</para>
    /// labels<para>"ha programma per foto"</para><para>"has photo program"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasPhotoProgram">https://w3id.org/arco/ontology/denotative-description/hasPhotoProgram</seealso>
    let hasPhotoProgram = Prefixed_Name(ddesc, "hasPhotoProgram") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasPhotoSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una risorsa digitale al formato della risorsa, inteso come la dimensione standardizzata (es.: per i materiali fotografici negativi, positivi, ecc.)."</para>
    ///   <para>"This property relates a digital photograph to its format, intended as the photographic material's standardised size (e.g. negative, positives)."</para>
    /// labels<para>"ha dimensioni della foto"</para><para>"has photo size"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasPhotoSize">https://w3id.org/arco/ontology/denotative-description/hasPhotoSize</seealso>
    let hasPhotoSize = Prefixed_Name(ddesc, "hasPhotoSize") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasPixelDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a digital resource to its size in pixels."</para>
    ///   <para>"Questa proprietà collega un'immagine digitale (es.: fotografia) alle dimensioni, in pixel, dell'immagine."</para>
    /// labels<para>"has pixel dimension"</para><para>"ha dimensioni in pixel"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasPixelDimension">https://w3id.org/arco/ontology/denotative-description/hasPixelDimension</seealso>
    let hasPixelDimension = Prefixed_Name(ddesc, "hasPixelDimension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasQualityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a digital resource to its quality level, e.g. high-resolution, low-resolution, preview."</para>
    ///   <para>"Questa proprietà collega una risorsa digitale al livello di qualità della risorsa (es.: alta risoluzione, bassa risoluzione, preview)"</para>
    /// labels<para>"ha livello di qualità"</para><para>"has quality level"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasQualityLevel">https://w3id.org/arco/ontology/denotative-description/hasQualityLevel</seealso>
    let hasQualityLevel = Prefixed_Name(ddesc, "hasQualityLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una fotografia alla risoluzione e al valore specifico utilizzati per la memorizzazione di una fotografia digitale."</para>
    ///   <para>"This property relates a digital resource to theresolution used for storing it."</para>
    /// labels<para>"has resolution"</para><para>"ha risoluzione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasResolution">https://w3id.org/arco/ontology/denotative-description/hasResolution</seealso>
    let hasResolution = Prefixed_Name(ddesc, "hasResolution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasSampleCollected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un bene archeologico a un campione prelevato da esso."</para>
    ///   <para>"This property connects a archaeological entity to a sample collected from it."</para>
    /// labels<para>"ha campione prelevato"</para><para>"has sample collected"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollected">https://w3id.org/arco/ontology/denotative-description/hasSampleCollected</seealso>
    let hasSampleCollected = Prefixed_Name(ddesc, "hasSampleCollected") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasSampleCollectedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property relates a sample collected to its type."</para>
    ///   <para>"Questa proprietà collega un campione prelevato da un bene archeologico al tipo di campione (es.: intonaco, carbone, etc.)"</para>
    /// labels<para>"ha tipo di campione prelevato"</para><para>"has sample collected type"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollectedType">https://w3id.org/arco/ontology/denotative-description/hasSampleCollectedType</seealso>
    let hasSampleCollectedType =
        Prefixed_Name(ddesc, "hasSampleCollectedType") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto al formato dell'oggetto, per oggetti bidimensionali (es.: ottagonale, tondo)"</para>
    ///   <para>"This property relates an object to its shape. It is used for bidimensional objects, e.g. octagonal or round shape."</para>
    /// labels<para>"has shape"</para><para>"ha forma"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasShape">https://w3id.org/arco/ontology/denotative-description/hasShape</seealso>
    let hasShape = Prefixed_Name(ddesc, "hasShape") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasStorageMethodOrColourDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una fotografia al metodo e alla profondità di colore con cui è stata memorizzata la fotografia digitale."</para>
    ///   <para>"This property relates a digital photograph to the method and color depth through which a digital photograph has been stored."</para>
    /// labels<para>"has storage method or colour depth"</para><para>"ha metodo di memorizzazione e profondità del colore"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasStorageMethodOrColourDepth">https://w3id.org/arco/ontology/denotative-description/hasStorageMethodOrColourDepth</seealso>
    let hasStorageMethodOrColourDepth =
        Prefixed_Name(ddesc, "hasStorageMethodOrColourDepth") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una iscrizione, un timbro, un emblema, etc., rappresentato su un bene culturale al supporto su cui si trova l'elemento."</para>
    ///   <para>"This property connects an inscription, stamp, emblem etc., represented on a cultural entity to the support on which the entity is located."</para>
    /// labels<para>"has support"</para><para>"ha supporto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasSupport">https://w3id.org/arco/ontology/denotative-description/hasSupport</seealso>
    let hasSupport = Prefixed_Name(ddesc, "hasSupport") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasTechnicalCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità a una caratteristica tecnica (es.: materia, tecnica, colore, livello di qualità, formato)."</para>
    ///   <para>"This property relates an entity to a technical characteristic (e.g. material, technique, colour, quality level)."</para>
    /// labels<para>"has technical characteristic"</para><para>"ha caratteristica tecnica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalCharacteristic">https://w3id.org/arco/ontology/denotative-description/hasTechnicalCharacteristic</seealso>
    let hasTechnicalCharacteristic =
        Prefixed_Name(ddesc, "hasTechnicalCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasTechnicalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'entità culturale al suo stato tecnico, valido fino a determinato momento, che è rappresentato dalle caratteristiche tecniche che il bene culturale ha in quel momento."</para>
    ///   <para>"This property connects a cultural entity to its technical status, valid until a specific moment, that is represented by the technical characteristics that a cultural entity has in that moment."</para>
    /// labels<para>"has technical status"</para><para>"ha stato tecnico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalStatus">https://w3id.org/arco/ontology/denotative-description/hasTechnicalStatus</seealso>
    let hasTechnicalStatus = Prefixed_Name(ddesc, "hasTechnicalStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un oggetto alla tecnica di esecuzione dell'oggetto, per esempio un bene culturale."</para>
    ///   <para>"This property relates an object to its execution technique."</para>
    /// labels<para>"has technique"</para><para>"ha tecnica"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasTechnique">https://w3id.org/arco/ontology/denotative-description/hasTechnique</seealso>
    let hasTechnique = Prefixed_Name(ddesc, "hasTechnique") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasTemperament</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a musical instrument to the adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals."</para>
    ///   <para>"Questa proprietà collega uno strumento al temperamento adottato, soprattutto in caso di oggetto in condizioni originali, o dopo un restauro, dello strumento musicale. Per gli idiofoni a tasti fissi (come xilofoni, litofoni, metallofoni) rappresenta la successione degli intervalli."</para>
    /// labels<para>"ha temperamento"</para><para>"has temperament"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasTemperament">https://w3id.org/arco/ontology/denotative-description/hasTemperament</seealso>
    let hasTemperament = Prefixed_Name(ddesc, "hasTemperament") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasTuning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a musical instrument to its tuning."</para>
    ///   <para>"Questa proprietà collega uno strumento all'accordatura dello strumento musicale."</para>
    /// labels<para>"has tuning"</para><para>"ha accordatura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasTuning">https://w3id.org/arco/ontology/denotative-description/hasTuning</seealso>
    let hasTuning = Prefixed_Name(ddesc, "hasTuning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una misura al suo valore."</para>
    ///   <para>"This property relates a measurement to its value."</para>
    /// labels<para>"ha valore"</para><para>"has value"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasValue">https://w3id.org/arco/ontology/denotative-description/hasValue</seealso>
    let hasValue = Prefixed_Name(ddesc, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasVibratingLenght</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un uno strumento alla lunghezza vibrante dello strumento, in particolare di un cordofono."</para>
    ///   <para>"This property relates a musical instrument to its vibrating length, in particular a chordophone."</para>
    /// labels<para>"has vibrating lenght"</para><para>"ha lunghezza vibrante"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasVibratingLenght">https://w3id.org/arco/ontology/denotative-description/hasVibratingLenght</seealso>
    let hasVibratingLenght = Prefixed_Name(ddesc, "hasVibratingLenght") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects a collection of observed measures on an object to one of these measures, when the latter is relative to an ancient or contemporary apparel's size. The volumetric dimensions measurements determine the size for storage and can be considered as the object's orthogonal coordinates."</para>
    ///   <para>"Questa proprietà collega un insieme di misure osservate per un oggetto a una dell misure, quando questa sia relativa all'ingombro di un vestimento antico o contemporaneo. Le misure ingombro determinano l'ingombro per l'immagazzinaggio e si possono quindiconsiderare le coordinate ortogonali dell'oggetto."</para>
    /// labels<para>"has volumetric dimensions measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"ha misura di imgombro"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement">https://w3id.org/arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement</seealso>
    let hasVolumetricDimensionsMeasurement =
        Prefixed_Name(ddesc, "hasVolumetricDimensionsMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/hasWritingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una iscrizione, un timbro, uno stemma, etc., al sistema di scrittura/alfabeto adottati."</para>
    ///   <para>"This property connects an inscription, stamp, crest etc., to the adopted writing system or alphabet."</para>
    /// labels<para>"has writing system"</para><para>"ha sistema di scrittura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/hasWritingSystem">https://w3id.org/arco/ontology/denotative-description/hasWritingSystem</seealso>
    let hasWritingSystem = Prefixed_Name(ddesc, "hasWritingSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/includesTechnicalCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega lo stato tecnico di un'entità culturale a una delle caratteristiche tecniche dell'entità relativamente a quello stato."</para>
    ///   <para>"This property connects a technical status, with respect to a specific entity (as a cultural entity) to one of the technical characteristics related to that status."</para>
    /// labels<para>"include caratteristica tecnica"</para><para>"includes technical characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/includesTechnicalCharacteristic">https://w3id.org/arco/ontology/denotative-description/includesTechnicalCharacteristic</seealso>
    let includesTechnicalCharacteristic =
        Prefixed_Name(ddesc, "includesTechnicalCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/involvesAgeRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una modalità comunicativa (prossemica, cinesica) alla fascia d'età delle persone che attuano la comunicazione."</para>
    ///   <para>"This property relates a communication medium (proxemics, kinesic) to the age range of the participants to the communication."</para>
    /// labels<para>"involves age range"</para><para>"coinvolge fascia d'età"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/involvesAgeRange">https://w3id.org/arco/ontology/denotative-description/involvesAgeRange</seealso>
    let involvesAgeRange = Prefixed_Name(ddesc, "involvesAgeRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isAccessoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has accessory"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha accessorio"."</para>
    /// labels<para>"is accessory of"</para><para>"è accessorio di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isAccessoryOf">https://w3id.org/arco/ontology/denotative-description/isAccessoryOf</seealso>
    let isAccessoryOf = Prefixed_Name(ddesc, "isAccessoryOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isAffixedElementTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has affixed element type"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di elemento apposto"."</para>
    /// labels<para>"is affixed element type of"</para><para>"è tipo di elemento apposto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isAffixedElementTypeOf">https://w3id.org/arco/ontology/denotative-description/isAffixedElementTypeOf</seealso>
    let isAffixedElementTypeOf =
        Prefixed_Name(ddesc, "isAffixedElementTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isAgeRangeInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "involves age range"."</para>
    ///   <para>"Questa è la proprietà inversa di "coinvolge fascia d'età"."</para>
    /// labels<para>"è fascia d'età coinvolta in"</para><para>"is age range involved in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isAgeRangeInvolvedIn">https://w3id.org/arco/ontology/denotative-description/isAgeRangeInvolvedIn</seealso>
    let isAgeRangeInvolvedIn =
        Prefixed_Name(ddesc, "isAgeRangeInvolvedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isAgentReferredToBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "refers to agent"."</para>
    ///   <para>"Questa è la proprietà inversa a "si riferisce ad agente"."</para>
    /// labels<para>"è agente cui si riferisce"</para><para>"is agent referred to by"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isAgentReferredToBy">https://w3id.org/arco/ontology/denotative-description/isAgentReferredToBy</seealso>
    let isAgentReferredToBy =
        Prefixed_Name(ddesc, "isAgentReferredToBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCharacteristicClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects an entity's techincal characteristic to a technical concept, which classifies that characteristic."</para>
    ///   <para>"Questa proprietà collega una caratteristica tecnica di un'entità - come un bene culturale - a un concetto tecnico, che la classifica."</para>
    /// labels<para>"is technical characteristic classified by"</para><para>"è caratteristica tecnica classificata da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCharacteristicClassifiedBy">https://w3id.org/arco/ontology/denotative-description/isCharacteristicClassifiedBy</seealso>
    let isCharacteristicClassifiedBy =
        Prefixed_Name(ddesc, "isCharacteristicClassifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCommunicationMediumOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha modalità comunicativa"."</para>
    ///   <para>"This is the inverse property of "has communication medium"."</para>
    /// labels<para>"is communication medium of"</para><para>"è modalità comunicativa"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumOf">https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumOf</seealso>
    let isCommunicationMediumOf =
        Prefixed_Name(ddesc, "isCommunicationMediumOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCommunicationMediumTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has communication medium type"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di modalità comunicativa"."</para>
    /// labels<para>"è tipo di modalità comunicativa"</para><para>"is communication medium type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumTypeOf">https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumTypeOf</seealso>
    let isCommunicationMediumTypeOf =
        Prefixed_Name(ddesc, "isCommunicationMediumTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isConservationStatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a conservation status of a cultural property to that cultural property."</para>
    ///   <para>"Questa proprietà collega uno stato di conservazione al bene culturale che si trova in quello stato."</para>
    /// labels<para>"is conservation status of"</para><para>"è stato di conservazione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusOf">https://w3id.org/arco/ontology/denotative-description/isConservationStatusOf</seealso>
    let isConservationStatusOf =
        Prefixed_Name(ddesc, "isConservationStatusOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isConservationStatusTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has conservation status type"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di stato di conservazione"."</para>
    /// labels<para>"is conservation status type of"</para><para>"è tipo di stato di conservazione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusTypeOf">https://w3id.org/arco/ontology/denotative-description/isConservationStatusTypeOf</seealso>
    let isConservationStatusTypeOf =
        Prefixed_Name(ddesc, "isConservationStatusTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has cultural property accessibility"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha accessibilità"."</para>
    /// labels<para>"is cultural property accessibility of"</para><para>"è accessibilità di bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf">https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf</seealso>
    let isCulturalPropertyAccessibilityOf =
        Prefixed_Name(ddesc, "isCulturalPropertyAccessibilityOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha disponibilità materiale"."</para>
    ///   <para>"This is the inverse property of "has cultural property availability"."</para>
    /// labels<para>"is cultural property availability of"</para><para>"è disponibilità  materiale di bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf">https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf</seealso>
    let isCulturalPropertyAvailabilityOf =
        Prefixed_Name(ddesc, "isCulturalPropertyAvailabilityOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCulturalPropertyDefinitionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha definizione di bene culturale"."</para>
    ///   <para>"This is the inverse property of "has cultural property definition"."</para>
    /// labels<para>"is cultural property definition of"</para><para>"è definizione di bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyDefinitionOf">https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyDefinitionOf</seealso>
    let isCulturalPropertyDefinitionOf =
        Prefixed_Name(ddesc, "isCulturalPropertyDefinitionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCulturalPropertySpecificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has cultural property specification"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha specifiche del bene culturale"."</para>
    /// labels<para>"sono specifiche del bene culturale"</para><para>"is cultural property specification"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertySpecificationOf">https://w3id.org/arco/ontology/denotative-description/isCulturalPropertySpecificationOf</seealso>
    let isCulturalPropertySpecificationOf =
        Prefixed_Name(ddesc, "isCulturalPropertySpecificationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isCulturalPropertyTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di bene culturale"."</para>
    ///   <para>"This is the inverse property of "has cultural property type"."</para>
    /// labels<para>"is cultural property type of"</para><para>"è tipo di bene culturale"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyTypeOf">https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyTypeOf</seealso>
    let isCulturalPropertyTypeOf =
        Prefixed_Name(ddesc, "isCulturalPropertyTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isDedicateeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has dedicatee"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha dedicatario"."</para>
    /// labels<para>"is dedicatee of"</para><para>"è dedicatario di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isDedicateeOf">https://w3id.org/arco/ontology/denotative-description/isDedicateeOf</seealso>
    let isDedicateeOf = Prefixed_Name(ddesc, "isDedicateeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isDesignationInTimeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has designation in time"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha designazione nel tempo"."</para>
    /// labels<para>"is designation in time of"</para><para>"è denominazione nel tempo di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isDesignationInTimeOf">https://w3id.org/arco/ontology/denotative-description/isDesignationInTimeOf</seealso>
    let isDesignationInTimeOf =
        Prefixed_Name(ddesc, "isDesignationInTimeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isDesignationTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di denominazione"."</para>
    ///   <para>"This is the inverse property of "has designation type"."</para>
    /// labels<para>"è tipo di denominazione"</para><para>"is designation type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isDesignationTypeOf">https://w3id.org/arco/ontology/denotative-description/isDesignationTypeOf</seealso>
    let isDesignationTypeOf =
        Prefixed_Name(ddesc, "isDesignationTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isDiapasonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha corista"."</para>
    ///   <para>"This is the inverse property of "has diapason"."</para>
    /// labels<para>"è corista di"</para><para>"is diapason of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isDiapasonOf">https://w3id.org/arco/ontology/denotative-description/isDiapasonOf</seealso>
    let isDiapasonOf = Prefixed_Name(ddesc, "isDiapasonOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isElementAffixedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has affixed element"."</para>
    ///   <para>"Questa è la proprietà inversa a "ha elemento affisso"."</para>
    /// labels<para>"è elemento apposto su"</para><para>"is element affixed on"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isElementAffixedOn">https://w3id.org/arco/ontology/denotative-description/isElementAffixedOn</seealso>
    let isElementAffixedOn = Prefixed_Name(ddesc, "isElementAffixedOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isExtensionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha estensione"."</para>
    ///   <para>"This is the inverse property of "has extension"."</para>
    /// labels<para>"è estensione di"</para><para>"is extension of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isExtensionOf">https://w3id.org/arco/ontology/denotative-description/isExtensionOf</seealso>
    let isExtensionOf = Prefixed_Name(ddesc, "isExtensionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isFileFormatOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha formato di estensione/compressione del file""</para>
    ///   <para>"This is the inverse property of "has file format""</para>
    /// labels<para>"is file format of"</para><para>"è formato di estensione/compressione del file di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isFileFormatOf">https://w3id.org/arco/ontology/denotative-description/isFileFormatOf</seealso>
    let isFileFormatOf = Prefixed_Name(ddesc, "isFileFormatOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isFiligreeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has filigree"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha filigrana"."</para>
    /// labels<para>"è filigrana di"</para><para>"is filigree of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isFiligreeOf">https://w3id.org/arco/ontology/denotative-description/isFiligreeOf</seealso>
    let isFiligreeOf = Prefixed_Name(ddesc, "isFiligreeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isFontStyleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha tipo di caratteri"."</para>
    ///   <para>"This is the inverse property of "has font style"."</para>
    /// labels<para>"is font style of"</para><para>"è tipo di caratteri di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isFontStyleOf">https://w3id.org/arco/ontology/denotative-description/isFontStyleOf</seealso>
    let isFontStyleOf = Prefixed_Name(ddesc, "isFontStyleOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isFunctionalPurposeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha scopo funzionale"."</para>
    ///   <para>"This is the inverse property of "has functional purpose"."</para>
    /// labels<para>"è scopo funzionale di"</para><para>"is functional purpose of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isFunctionalPurposeOf">https://w3id.org/arco/ontology/denotative-description/isFunctionalPurposeOf</seealso>
    let isFunctionalPurposeOf =
        Prefixed_Name(ddesc, "isFunctionalPurposeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isGarmentAnalysisOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha analisi del vestimento"."</para>
    ///   <para>"This is the inverse property of "has garment analysis"."</para>
    /// labels<para>"is garment analysis of"</para><para>"è analisi del vestimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isGarmentAnalysisOf">https://w3id.org/arco/ontology/denotative-description/isGarmentAnalysisOf</seealso>
    let isGarmentAnalysisOf =
        Prefixed_Name(ddesc, "isGarmentAnalysisOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isGarmentColourOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha colore del vestimento"."</para>
    ///   <para>"This is the inverse property of "has garment colour"."</para>
    /// labels<para>"is garment colour of"</para><para>"è colore del vestimento"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isGarmentColourOf">https://w3id.org/arco/ontology/denotative-description/isGarmentColourOf</seealso>
    let isGarmentColourOf = Prefixed_Name(ddesc, "isGarmentColourOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has iconographic or decorative apparatus"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha apparato iconografico e decorativo"."</para>
    /// labels<para>"è apparato iconografico e decorativo di"</para><para>"is iconographic or decorative apparatus of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf">https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf</seealso>
    let isIconographicOrDecorativeApparatusOf =
        Prefixed_Name(ddesc, "isIconographicOrDecorativeApparatusOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di apparato iconografico e decorativo"."</para>
    ///   <para>"This is the inverse property of "has iconographic or decorative apparatus type"."</para>
    /// labels<para>"è tipo di apparato iconografico e decorativo"</para><para>"is iconographic or decorative apparatus type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf">https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf</seealso>
    let isIconographicOrDecorativeApparatusTypeOf =
        Prefixed_Name(ddesc, "isIconographicOrDecorativeApparatusTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isImplementationMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha modalità esecutiva"."</para>
    ///   <para>"This is the inverse property of "has implementation method"."</para>
    /// labels<para>"è modalità esecutiva di"</para><para>"is implementation method of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isImplementationMethodOf">https://w3id.org/arco/ontology/denotative-description/isImplementationMethodOf</seealso>
    let isImplementationMethodOf =
        Prefixed_Name(ddesc, "isImplementationMethodOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isIncludedInTechnicalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a technical characteristic (e.g. marble) to the status of a cultural entity that includes that characteristic."</para>
    ///   <para>"Questa proprietà, inversa a "include caratteristica tecnica", collega una caratteristica tecnica specifica (es.: marmo) allo stato di un'entità culturale che ha quella caratteristica."</para>
    /// labels<para>"è inclusa in stato tecnico"</para><para>"is included in technical status"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isIncludedInTechnicalStatus">https://w3id.org/arco/ontology/denotative-description/isIncludedInTechnicalStatus</seealso>
    let isIncludedInTechnicalStatus =
        Prefixed_Name(ddesc, "isIncludedInTechnicalStatus") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isLegibilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha leggibilità"."</para>
    ///   <para>"This is the inverse property of "has legibility"."</para>
    /// labels<para>"è leggibilità di"</para><para>"is legibility of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isLegibilityOf">https://w3id.org/arco/ontology/denotative-description/isLegibilityOf</seealso>
    let isLegibilityOf = Prefixed_Name(ddesc, "isLegibilityOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isLocationSubjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha localizzazione rappresentata"."</para>
    ///   <para>"This is the inverse property of "has location subject"."</para>
    /// labels<para>"is location subject of"</para><para>"è localizzazione rappresentata da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isLocationSubjectOf">https://w3id.org/arco/ontology/denotative-description/isLocationSubjectOf</seealso>
    let isLocationSubjectOf =
        Prefixed_Name(ddesc, "isLocationSubjectOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMassStorageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has mass storage"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha memoria di massa"."</para>
    /// labels<para>"is mass storage of"</para><para>"è memoria di massa di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMassStorageOf">https://w3id.org/arco/ontology/denotative-description/isMassStorageOf</seealso>
    let isMassStorageOf = Prefixed_Name(ddesc, "isMassStorageOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMaterialOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha materia e tecnica""</para>
    ///   <para>"This is the inverse property of "has material""</para>
    /// labels<para>"is material of"</para><para>"è materia di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMaterialOf">https://w3id.org/arco/ontology/denotative-description/isMaterialOf</seealso>
    let isMaterialOf = Prefixed_Name(ddesc, "isMaterialOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMaterialOrTechniqueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has material or technique""</para>
    ///   <para>"Questa è la proprietà inversa di "ha materia e tecnica""</para>
    /// labels<para>"is material or technique of"</para><para>"è materia e tecnica di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMaterialOrTechniqueOf">https://w3id.org/arco/ontology/denotative-description/isMaterialOrTechniqueOf</seealso>
    let isMaterialOrTechniqueOf =
        Prefixed_Name(ddesc, "isMaterialOrTechniqueOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMeasurementCollectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha collezione di misure"."</para>
    ///   <para>"This is the inverse property of "has measurement collection"."</para>
    /// labels<para>"is measurement collection of"</para><para>"è collezione di misure di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMeasurementCollectionOf">https://w3id.org/arco/ontology/denotative-description/isMeasurementCollectionOf</seealso>
    let isMeasurementCollectionOf =
        Prefixed_Name(ddesc, "isMeasurementCollectionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMeasurementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà, inversa a "ha misura", collega una misura di un oggetto all'insieme di misure osservate per l'oggetto."</para>
    ///   <para>"This property connects an object's measure to the observed measures' collection of that object. It is the inverse property of hasMeasurement."</para>
    /// labels<para>"è misura in collezione"</para><para>"is measurement in collection"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMeasurementIn">https://w3id.org/arco/ontology/denotative-description/isMeasurementIn</seealso>
    let isMeasurementIn = Prefixed_Name(ddesc, "isMeasurementIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isMeasurementTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di misura"."</para>
    ///   <para>"This is the inverse property of "has measurement type"."</para>
    /// labels<para>"is measurement type of"</para><para>"è tipo di misura"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isMeasurementTypeOf">https://w3id.org/arco/ontology/denotative-description/isMeasurementTypeOf</seealso>
    let isMeasurementTypeOf =
        Prefixed_Name(ddesc, "isMeasurementTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isOrientationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha orientamento"."</para>
    ///   <para>"This is the inverse property of "has orientation"."</para>
    /// labels<para>"is orientation of"</para><para>"è orientamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isOrientationOf">https://w3id.org/arco/ontology/denotative-description/isOrientationOf</seealso>
    let isOrientationOf = Prefixed_Name(ddesc, "isOrientationOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isOrnamentalMotifOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has ornamental motif"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha motivo decorativo"."</para>
    /// labels<para>"is ornamental motif of"</para><para>"è motivo decorativo di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isOrnamentalMotifOf">https://w3id.org/arco/ontology/denotative-description/isOrnamentalMotifOf</seealso>
    let isOrnamentalMotifOf =
        Prefixed_Name(ddesc, "isOrnamentalMotifOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isPhotoColourOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha colore della foto""</para>
    ///   <para>"This is the inverse property of "has photo colour""</para>
    /// labels<para>"is photo colour of"</para><para>"è colore della foto"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isPhotoColourOf">https://w3id.org/arco/ontology/denotative-description/isPhotoColourOf</seealso>
    let isPhotoColourOf = Prefixed_Name(ddesc, "isPhotoColourOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isPhotoProgramOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has photo program"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha programma per foto"."</para>
    /// labels<para>"è programma per foto di"</para><para>"is photo program of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isPhotoProgramOf">https://w3id.org/arco/ontology/denotative-description/isPhotoProgramOf</seealso>
    let isPhotoProgramOf = Prefixed_Name(ddesc, "isPhotoProgramOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isPhotoSizeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha dimensioni della foto""</para>
    ///   <para>"This is the inverse property of "has photo size""</para>
    /// labels<para>"è dimensione della foto"</para><para>"is photo size of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isPhotoSizeOf">https://w3id.org/arco/ontology/denotative-description/isPhotoSizeOf</seealso>
    let isPhotoSizeOf = Prefixed_Name(ddesc, "isPhotoSizeOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isPixelDimensionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has pixel dimension""</para>
    ///   <para>"Questa è la proprietà inversa di "ha dimensioni in pixel""</para>
    /// labels<para>"is pixel dimension of"</para><para>"è dimensione in pixel di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isPixelDimensionOf">https://w3id.org/arco/ontology/denotative-description/isPixelDimensionOf</seealso>
    let isPixelDimensionOf = Prefixed_Name(ddesc, "isPixelDimensionOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isQualityLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha livello di qualità""</para>
    ///   <para>"This is the inverse property of "has quality level""</para>
    /// labels<para>"è livello di qualità di"</para><para>"is quality level of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isQualityLevelOf">https://w3id.org/arco/ontology/denotative-description/isQualityLevelOf</seealso>
    let isQualityLevelOf = Prefixed_Name(ddesc, "isQualityLevelOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isResolutionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa a "ha risoluzione""</para>
    ///   <para>"This is the inverse property of "has resolution""</para>
    /// labels<para>"is resolution of"</para><para>"è risoluzione di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isResolutionOf">https://w3id.org/arco/ontology/denotative-description/isResolutionOf</seealso>
    let isResolutionOf = Prefixed_Name(ddesc, "isResolutionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isSampleCollectedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha campione prelevato"."</para>
    ///   <para>"This is the inverse property of "has sample collected"."</para>
    /// labels<para>"is sample collected from"</para><para>"è campione prelevato da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedFrom">https://w3id.org/arco/ontology/denotative-description/isSampleCollectedFrom</seealso>
    let isSampleCollectedFrom =
        Prefixed_Name(ddesc, "isSampleCollectedFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isSampleCollectedTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has sample collected type"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha tipo di campione prelevato"."</para>
    /// labels<para>"è tipo di campione prelevato"</para><para>"is sample collected type of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedTypeOf">https://w3id.org/arco/ontology/denotative-description/isSampleCollectedTypeOf</seealso>
    let isSampleCollectedTypeOf =
        Prefixed_Name(ddesc, "isSampleCollectedTypeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isShapeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha forma""</para>
    ///   <para>"This is the inverse property of "has shape""</para>
    /// labels<para>"è forma di"</para><para>"is shape of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isShapeOf">https://w3id.org/arco/ontology/denotative-description/isShapeOf</seealso>
    let isShapeOf = Prefixed_Name(ddesc, "isShapeOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isStorageMethodOrColourDepthOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha metodo di memorizzazione e profondità del colore"."</para>
    ///   <para>"This is the inverse property of "has storage method or colour depth"."</para>
    /// labels<para>"is storage method or colour depth of"</para><para>"è metodo di memorizzazione e profondità del colore di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isStorageMethodOrColourDepthOf">https://w3id.org/arco/ontology/denotative-description/isStorageMethodOrColourDepthOf</seealso>
    let isStorageMethodOrColourDepthOf =
        Prefixed_Name(ddesc, "isStorageMethodOrColourDepthOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isSupportOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects a support (e.g. "paper label") to an element (stamp, embelem, inscription, mark) which has been represented on it. It is the inverse property of hasSupport."</para>
    ///   <para>"Questa proprietà, inversa di "ha supporto", collega un supporto (es.: "etichetta di carta") all'elemento (timbro, emblema, iscrizione, marchio) che vi viene rappresentato."</para>
    /// labels<para>"is support of"</para><para>"è supporto di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isSupportOf">https://w3id.org/arco/ontology/denotative-description/isSupportOf</seealso>
    let isSupportOf = Prefixed_Name(ddesc, "isSupportOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechnicalCharacteristicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a technical characteristic to an entity."</para>
    ///   <para>"Questa proprietà collega una caratteristica tecnica all'entità che ha quella caratteristica."</para>
    /// labels<para>"is technical characteristic of"</para><para>"è caratteristica tecnica di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechnicalCharacteristicOf">https://w3id.org/arco/ontology/denotative-description/isTechnicalCharacteristicOf</seealso>
    let isTechnicalCharacteristicOf =
        Prefixed_Name(ddesc, "isTechnicalCharacteristicOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechnicalConceptUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a technical concept (e.g. material) used in the technical description of a cultural property."</para>
    ///   <para>"Questa proprietà collega un concetto tecnico (es.: materia) usato nella descrizione tecnica di un bene culturale."</para>
    /// labels<para>"is technical concept used in"</para><para>"è concetto tecnico usato in"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechnicalConceptUsedIn">https://w3id.org/arco/ontology/denotative-description/isTechnicalConceptUsedIn</seealso>
    let isTechnicalConceptUsedIn =
        Prefixed_Name(ddesc, "isTechnicalConceptUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a technical description of a cultural entity to a situation that satisfies that description."</para>
    /// labels<para>"is cultural entity description satisfied by"</para><para>"è descrizione di entità culturale soddisfatta da"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy">https://w3id.org/arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy</seealso>
    let isTechnicalDescriptionSatisfiedBy =
        Prefixed_Name(ddesc, "isTechnicalDescriptionSatisfiedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechnicalStatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno stato tecnico di un'entità culturale a un'entità culturale. Lo stato è valido fino a determinato momento ed è rappresentato dalle caratteristiche tecniche che il bene culturale ha in quel momento."</para>
    ///   <para>"This property connects a technical status to a cultural entity. This status is valid until a specific moment and is represented by the technical characteristics that a cultural entity has in that moment."</para>
    /// labels<para>"è stato tecnico di"</para><para>"is technical status of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusOf">https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusOf</seealso>
    let isTechnicalStatusOf =
        Prefixed_Name(ddesc, "isTechnicalStatusOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechnicalStatusValidAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega uno stato tecnico di un'entità culturale all'intervallo temporale entro il quale è valido, relativamente al momento in cui quelle caratteristiche sono state rilevate."</para>
    ///   <para>"This property relates a cultural entity technical status to the time interval until which that status is valid, with regard to the moment in which the characteristics are observed."</para>
    /// labels<para>"è stato tecnico di entità culturale valido fino a"</para><para>"is cultural entity technical status valid at"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusValidAt">https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusValidAt</seealso>
    let isTechnicalStatusValidAt =
        Prefixed_Name(ddesc, "isTechnicalStatusValidAt") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTechniqueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has technique""</para>
    ///   <para>"Questa è la proprietà inversa di "ha materia e tecnica""</para>
    /// labels<para>"è tecnica di"</para><para>"is technique of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTechniqueOf">https://w3id.org/arco/ontology/denotative-description/isTechniqueOf</seealso>
    let isTechniqueOf = Prefixed_Name(ddesc, "isTechniqueOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTemperamentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha temperamento"."</para>
    ///   <para>"This is the inverse property of "has temperament"."</para>
    /// labels<para>"is temperament of"</para><para>"è temperamento di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTemperamentOf">https://w3id.org/arco/ontology/denotative-description/isTemperamentOf</seealso>
    let isTemperamentOf = Prefixed_Name(ddesc, "isTemperamentOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTimeIntervalValidFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un intervallo temporale entro il quale è valido uno stato tecnico di un'entità culturale allo stato tecnico stesso, relativamente al momento in cui quelle caratteristiche sono state rilevate."</para>
    ///   <para>"This property relates the time interval, at which a cultural entity technical status is valid, to that technical status, with regard to the moment in which the characteristics are observed."</para>
    /// labels<para>"is time interval valid for"</para><para>"è intervallo di tempo valido per"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTimeIntervalValidFor">https://w3id.org/arco/ontology/denotative-description/isTimeIntervalValidFor</seealso>
    let isTimeIntervalValidFor =
        Prefixed_Name(ddesc, "isTimeIntervalValidFor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isTuningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has tuning"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha accordatura"."</para>
    /// labels<para>"is tuning of"</para><para>"è accordatura di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isTuningOf">https://w3id.org/arco/ontology/denotative-description/isTuningOf</seealso>
    let isTuningOf = Prefixed_Name(ddesc, "isTuningOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has value"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha valore"."</para>
    /// labels<para>"is value of"</para><para>"è valore di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isValueOf">https://w3id.org/arco/ontology/denotative-description/isValueOf</seealso>
    let isValueOf = Prefixed_Name(ddesc, "isValueOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isVibratingLenghtOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has vibrating lenght"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha lunghezza vibrante"."</para>
    /// labels<para>"is vibrating lenght of"</para><para>"è lunghezza vibrante di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isVibratingLenghtOf">https://w3id.org/arco/ontology/denotative-description/isVibratingLenghtOf</seealso>
    let isVibratingLenghtOf =
        Prefixed_Name(ddesc, "isVibratingLenghtOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa è la proprietà inversa di "ha misura di ingombro"."</para>
    ///   <para>"This is the inverse property of "has volumetric dimensions measurement"."</para>
    /// labels<para>"is volumetric dimensions measurement in"</para><para>"è misura di ingombro di"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn">https://w3id.org/arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn</seealso>
    let isVolumetricDimensionsMeasurementIn =
        Prefixed_Name(ddesc, "isVolumetricDimensionsMeasurementIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/isWritingSystemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the inverse property of "has writing system"."</para>
    ///   <para>"Questa è la proprietà inversa di "ha sistema di scrittura"."</para>
    /// labels<para>"è sistema di scrittura di"</para><para>"is writing system of"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/isWritingSystemOf">https://w3id.org/arco/ontology/denotative-description/isWritingSystemOf</seealso>
    let isWritingSystemOf = Prefixed_Name(ddesc, "isWritingSystemOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/italianTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la traduzione italiana della trascrizione di un testo contenuto in un'iscrizione, un'emblema, etc."</para>
    ///   <para>"This property represents the italian translation of a text transcription contained in an inscription, emblem etc."</para>
    /// labels<para>"traduzione italiana"</para><para>"italian translation"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/italianTranslation">https://w3id.org/arco/ontology/denotative-description/italianTranslation</seealso>
    let italianTranslation = Prefixed_Name(ddesc, "italianTranslation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/numberOfChildParticipants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il numero dei bambini che attuano una comunicazione (verbale, musicale vocale)."</para>
    ///   <para>"This property represents the number of the child participants to a communication (verbal, singing, kinesic)."</para>
    /// labels<para>"numero di partecipanti infantili"</para><para>"number of child participants"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/numberOfChildParticipants">https://w3id.org/arco/ontology/denotative-description/numberOfChildParticipants</seealso>
    let numberOfChildParticipants =
        Prefixed_Name(ddesc, "numberOfChildParticipants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/numberOfFemaleParticipants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the number of the male participants to a communication (verbal, singing, kinesic)."</para>
    ///   <para>"Questa proprietà rappresenta il numero delle persone di sesso femminile che attuano una comunicazione (verbale, musicale vocale, cinesica)."</para>
    /// labels<para>"number of female participants"</para><para>"numero di partecipanti femminili"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/numberOfFemaleParticipants">https://w3id.org/arco/ontology/denotative-description/numberOfFemaleParticipants</seealso>
    let numberOfFemaleParticipants =
        Prefixed_Name(ddesc, "numberOfFemaleParticipants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/numberOfMaleParticipants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta il numero delle persone di sesso maschile che attuano una comunicazione (verbale, musicale vocale, cinesica)"</para>
    ///   <para>"This property represents the number of the male participants to a communication (verbal, singing, kinesic)."</para>
    /// labels<para>"number of male participants"</para><para>"numero di partecipanti maschili"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/numberOfMaleParticipants">https://w3id.org/arco/ontology/denotative-description/numberOfMaleParticipants</seealso>
    let numberOfMaleParticipants =
        Prefixed_Name(ddesc, "numberOfMaleParticipants") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/occurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta le occorrenze di un emblema, marchio, iscrizione, etc., su uno stesso bene culturale, cioè quante volte l'elemento descritto compare sul bene."</para>
    ///   <para>"This property represents the occurrences of an affixed element on a cultular entity, that is how many times the outlined element appears on the cultual entity."</para>
    /// labels<para>"occurrences"</para><para>"occorrenze"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/occurrences">https://w3id.org/arco/ontology/denotative-description/occurrences</seealso>
    let occurrences = Prefixed_Name(ddesc, "occurrences") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/positionInComplexCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Questa proprietà rappresenta la posizione di un bene rispetto al bene complesso di cui è parte componente."</para>
    ///   <para>"This property represents a cultural entity's position with respect to a complex entity to which it belongs."</para>
    /// labels<para>"posizione rispetto al bene culturale complesso"</para><para>"position in complex cultural property"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/positionInComplexCulturalProperty">https://w3id.org/arco/ontology/denotative-description/positionInComplexCulturalProperty</seealso>
    let positionInComplexCulturalProperty =
        Prefixed_Name(ddesc, "positionInComplexCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/positionOnCulturalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà rappresenta la posizione di un oggetto (es.: elementi come stemmi, emblemi, timbri, etc., oppure i soggetti rappresentati) rispetto all'intero bene o a una sua specifica parte."</para>
    ///   <para>"This property represents a cultural entity's postion (e.g. elements like crests, emblems, stamps or the depicted subjects), with respect to the whole entity or to its specific part."</para>
    /// labels<para>"posizione su bene culturale"</para><para>"position on cultural property"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/positionOnCulturalProperty">https://w3id.org/arco/ontology/denotative-description/positionOnCulturalProperty</seealso>
    let positionOnCulturalProperty =
        Prefixed_Name(ddesc, "positionOnCulturalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/proposedIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents potential proposals for conservative interventions after evaluating the cultual entity's conditions at time of its cataloguing."</para>
    ///   <para>"Questa proprietà rappresenta eventuali proposte per interventi conservativi, dopo aver valutato le condizioni del bene al momento della sua catalogazione."</para>
    /// labels<para>"proposte di interventi"</para><para>"proposed intervention"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/proposedIntervention">https://w3id.org/arco/ontology/denotative-description/proposedIntervention</seealso>
    let proposedIntervention =
        Prefixed_Name(ddesc, "proposedIntervention") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/refersToAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un uno stemma, un emblema, un timbro, etc., presente su un bene culturale, all'agente (la famiglia, la fabbrica, la cava, l'argentiere, etc.) a cui si riferisce l'elemento."</para>
    ///   <para>"This property connects a crest, emblem, postmark etc., located on a cultural entity to the agent (e.g. family, factory, cave, silversmith) to which it refers."</para>
    /// labels<para>"si riferisce ad agente"</para><para>"refers to agent"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/refersToAgent">https://w3id.org/arco/ontology/denotative-description/refersToAgent</seealso>
    let refersToAgent = Prefixed_Name(ddesc, "refersToAgent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/sampleCollectedIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the seample collected identifier."</para>
    ///   <para>"Questa proprietà rappresenta il numero che identifica il campione."</para>
    /// labels<para>"identificativo del campione prelevato"</para><para>"sample collected identifier"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/sampleCollectedIdentifier">https://w3id.org/arco/ontology/denotative-description/sampleCollectedIdentifier</seealso>
    let sampleCollectedIdentifier =
        Prefixed_Name(ddesc, "sampleCollectedIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/satisfiesTechnicalDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property relates a technical status (intended as a situaiton) of a cultural entity to the technical description satisfied by that situation."</para>
    /// labels<para>"soddisfa descrizione tecnica"</para><para>"satisfies technical description"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/satisfiesTechnicalDescription">https://w3id.org/arco/ontology/denotative-description/satisfiesTechnicalDescription</seealso>
    let satisfiesTechnicalDescription =
        Prefixed_Name(ddesc, "satisfiesTechnicalDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/storageConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents informations about the storage conditions of a cultural property."</para>
    ///   <para>"Questa proprietà rappresenta informazioni sulle condizioni ambientali e microclimatiche in cui si trova il bene al momento della catalogazione ed eventuali indicazioni per una sua corretta conservazione."</para>
    /// labels<para>"modalità di conservazione"</para><para>"storage conditions"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/storageConditions">https://w3id.org/arco/ontology/denotative-description/storageConditions</seealso>
    let storageConditions = Prefixed_Name(ddesc, "storageConditions") |> PrefixedName
    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/transcript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Questa proprietà collega un'iscrizione, un emblema, etc., alla trascrizione del testo, utilizzando scioglimenti e integrazioni scientificamente accettati."</para>
    ///   <para>"This property connects an inscription, emblem etc., to the text's transcription, using scientifically accepted integrations."</para>
    /// labels<para>"transcript"</para><para>"trascrizione"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/transcript">https://w3id.org/arco/ontology/denotative-description/transcript</seealso>
    let transcript = Prefixed_Name(ddesc, "transcript") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/usesTechnicalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega una descrizione tecnica di un bene culturale a uno dei concetti usati in quella descrizione."</para>
    ///   <para>"This property relates a technical description of a cultural property to one of the concepts used in that description."</para>
    /// labels<para>"uses technical concept"</para><para>"usa concetto tecnico"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/usesTechnicalConcept">https://w3id.org/arco/ontology/denotative-description/usesTechnicalConcept</seealso>
    let usesTechnicalConcept =
        Prefixed_Name(ddesc, "usesTechnicalConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:arco/ontology/denotative-description/validity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the validity, intended as accurancy level, of an observed measure for an object."</para>
    ///   <para>"Questa proprietà rappresenta la validità, intesa come livello di accuratezza, di una misura osservata per un oggetto."</para>
    /// labels<para>"validity"</para><para>"validità"</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/denotative-description/validity">https://w3id.org/arco/ontology/denotative-description/validity</seealso>
    let validity = Prefixed_Name(ddesc, "validity") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ddesc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/denotative-description/" "ddesc"

    let _namespaceIri = _prefixId.prefix ""
    let Accessible = _prefixId.prefix "Accessible"
    /// <summary>
    ///   <para>rdfs:label : Accessoryrdfs:label : Accessorio</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents an accessory of a musical property, both if it is functional to the sound production, or if it is the sound's production or conservation medium.rdfs:comment : Questa classe rappresenta un accessorio di un bene musicale, ovvero un oggetto collegabile al bene musicale, sia nel caso in cui sia funzionale alla produzione del suono, sia nel caso in cui sia di supporto alla produzione del suono o alla conservazione o alla prassi musicale del bene.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: AS/ASS/ASST^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Accessory">ddesc:Accessory</a>
    /// </summary>
    let Accessory = _prefixId.prefix "Accessory"
    /// <summary>
    ///   <para>dce:description : Un esempio d'uso di una delle sottoclassi della classe "Elemento apposto su bene culturale" è il seguente:
    /// resource:Inscription/1200865151-inscription-1
    ///         a   dd:Inscription ;
    ///         rdfs:label "Iscrizione 1 del bene culturale 1200865151"@en ;
    ///         dd:hasFontStyle resource:FontStyle/lettere-capitali ;
    ///         dd:hasTechnicalDetailOccurrence resource:TechnicalDetailOccurrence/1200865151-inscription-1-material-technique-1 ;
    ///         dd:positionOnCulturalProperty "al centro" ;
    ///         dd:transcript "PAVLVS VENETVS PAPA SECVNDVS SVIS IMPENSIS FIERI FECIT ANNO CRISTI MCCCLXVII" ;
    ///         language:hasLanguage resource:Language/latino .dce:description : An example of usage of one of the subclasses of the class 'Affixed element' is the following:
    /// resource:Inscription/1200865151-inscription-1
    ///         a   dd:Inscription ;
    ///         rdfs:label "Inscription 1 of cultural property 1200865151"@en ;
    ///         dd:hasFontStyle resource:FontStyle/lettere-capitali ;
    ///         dd:hasTechnicalDetailOccurrence resource:TechnicalDetailOccurrence/1200865151-inscription-1-material-technique-1 ;
    ///         dd:positionOnCulturalProperty "in the middle" ;
    ///         dd:transcript "PAVLVS VENETVS PAPA SECVNDVS SVIS IMPENSIS FIERI FECIT ANNO CRISTI MCCCLXVII" ;
    ///         language:hasLanguage resource:Language/latino .</para>
    ///   <para>rdfs:label : Element affixed on cultural propertyrdfs:label : Elemento apposto su bene culturale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE - ICCD versioni precedenti alla 4.00: DA/ISR; DA/STM - ICCD Normativa A: LI/LSI</para>
    ///   <para>rdfs:comment : This class represents an element (i.e. crest, trademark, postmark, inscription) which is affixed on a cultural property.rdfs:comment : Questa classe rappresenta un elemento (stemma, marchio, timbro, emblema, logo, iscrizione, etc.) apposto su un bene culturale.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/AffixedElement">ddesc:AffixedElement</a>
    /// </summary>
    let AffixedElement = _prefixId.prefix "AffixedElement"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEE - Normative di versioni precedenti: DA/STM/STMQ</para>
    ///   <para>rdfs:label : Affixed element typerdfs:label : Tipo di elemento apposto</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo (es.: gentilizio, civile, religioso, etc.) di un'iscrizione, un emblema, un timbro, uno stemma, etc.rdfs:comment : This class represents the type (i.e. civil, religious) of an inscription, emblem, postmark, crest, etc.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/AffixedElementType">ddesc:AffixedElementType</a>
    /// </summary>
    let AffixedElementType = _prefixId.prefix "AffixedElementType"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta la fascia d'età (bambino, ragazzo, adulto  anziano) di una persona.rdfs:comment : This class represents the age range (child, teenager, adult, old person) of a person.</para>
    ///   <para>rdfs:label : Age rangerdfs:label : Fascia d'età</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUC/CUCE; CU/CUP/CUPE^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/AgeRange">ddesc:AgeRange</a>
    /// </summary>
    let AgeRange = _prefixId.prefix "AgeRange"
    let Area = _prefixId.prefix "Area"
    let AssignedDesignation = _prefixId.prefix "AssignedDesignation"
    let Available = _prefixId.prefix "Available"
    let AvailableNotes = _prefixId.prefix "AvailableNotes"
    let BackTotalLength = _prefixId.prefix "BackTotalLength"
    let BackWidth = _prefixId.prefix "BackWidth"
    let BadConservationStatus = _prefixId.prefix "BadConservationStatus"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un marchio, ovvero un segno, figura, simbolo impresso o applicato su qualcosa a scopo di distinzione e riconoscimento.rdfs:comment : This class represents a brand, that is a sign, an image, a symbol affixed on an object for identification.</para>
    ///   <para>rdfs:label : Marchiordfs:label : Brand</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'marchio' - ICCD versioni precedenti: DA/STM/STMC = 'marchio' - ICCD Normativa A: LI/LSI/LSIG = 'marchio'</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Brand">ddesc:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    let Capacity = _prefixId.prefix "Capacity"
    let ChestCircumference = _prefixId.prefix "ChestCircumference"
    let Circumference = _prefixId.prefix "Circumference"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'stemma' - ICCD versioni precedenti: DA/STM/STMC = 'stemma' - ICCD Normativa A: LI/LSI/LSIG = 'stemma'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Coat of armsrdfs:label : Stemma</para>
    ///   <para>rdfs:comment : Questa classe rappresenta uno stemma, ovvero un insieme di figure e simboli che, in araldica, vengono rappresentati secondo determinate regole per contrassegnare persone o enti.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CoatOfArms">ddesc:CoatOfArms</a>
    /// </summary>
    let CoatOfArms = _prefixId.prefix "CoatOfArms"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Coin designrdfs:label : Raffigurazione su moneta</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: DA/DES/DESA; DA/DES/DESM^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the design on the reverse or the obverse of a numismatic property, as the graphical part of what is represented on a side of a coin, together with the legend (lettering and wording).rdfs:comment : Questa classe rappresenta la raffigurazione presente sul dritto o sul rovescio di un bene numismatico, intesa come l'insieme degli elementi grafici, che, uniti a una legenda (lettere e parole), fa parte dell'impronta della moneta.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CoinDesign">ddesc:CoinDesign</a>
    /// </summary>
    let CoinDesign = _prefixId.prefix "CoinDesign"
    /// <summary>
    ///   <para>rdfs:label : Legenda della monetardfs:label : Coin legend</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: DA/DES/DELS; DA/DES/DESN; DA/DES/DESF; DA/DES/DESG; DA/DES/DESR; DA/DES/DEST.^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'insieme di lettere e parole presenti sul dritto o sul rovescio di un bene numismatico, che, unito alla raffigurazione, fa parte dell'impronta della moneta.rdfs:comment : This class represents the lettering and wording on the reverse or the obverse of a numismatic property.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CoinLegend">ddesc:CoinLegend</a>
    /// </summary>
    let CoinLegend = _prefixId.prefix "CoinLegend"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Modalità comunicativardfs:label : Communication medium</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la modalità comunicativa di un oggetto, definita dal tipo di modalità (es.: verbale, scritta, strumentale), la modalità esecutiva, il numero di voci e strumenti coinvolti, etc.rdfs:comment : This class represents the communication medium of an object, defined by the communication medium type (e.g.: verbal, written, instrumental), the implementation method, the number of voices or instruments involved, etc.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CommunicationMedium">ddesc:CommunicationMedium</a>
    /// </summary>
    let CommunicationMedium = _prefixId.prefix "CommunicationMedium"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di modalità comunicativa.rdfs:comment : This class represents the type of communication medium.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di modalità comunicativardfs:label : Communication medium type</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CommunicationMediumType">ddesc:CommunicationMediumType</a>
    /// </summary>
    let CommunicationMediumType = _prefixId.prefix "CommunicationMediumType"
    let CompleteLegibility = _prefixId.prefix "CompleteLegibility"
    /// <summary>
    ///   <para>dce:description : Un esempio d'uso della classe "Stato di conservazione" è il seguente:
    /// resource:ConservationStatus/0900750201-conservation-status-1
    ///         a  a-dd:ConservationStatus ;
    ///         rdfs:label  "Stato di conservazione 1 del bene: 0900750201"@it ;
    ///         core:specifications  "Macchie in corrispondenza della fodera, lungo lo scollo." ;
    ///        a-dd:hasConservationStatusType a-dd:GoodConservationStatus ;
    ///         tiapit:time   "2014" .dce:description : An example of usage of the class 'Conservation status' is the following:
    /// resource:ConservationStatus/0900750201-conservation-status-1
    ///         a   dd:ConservationStatus ;
    ///         rdfs:label  "Conservation status 1 of cultural property: 0900750201"@en ;
    ///         core:specifications  "Stains at the lining, along the neckline." ;
    ///        dd:hasConservationStatusType dd:GoodConservationStatus ;
    ///         tiapit:time   "2014" .</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Conservation Statusrdfs:label : Stato di Conservazione</para>
    ///   <para>ctlog:iccdNormTag : CO/STC^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta lo stato di conservazione di un bene culturale.rdfs:comment : This class represents the conservation status of the cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/ConservationStatus">ddesc:ConservationStatus</a>
    /// </summary>
    let ConservationStatus = _prefixId.prefix "ConservationStatus"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : CO/STC/STCC^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Conservation Status Typerdfs:label : Tipo di stato di conservazione</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/ConservationStatusType">ddesc:ConservationStatusType</a>
    /// </summary>
    let ConservationStatusType = _prefixId.prefix "ConservationStatusType"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta una contromarca, ovvero una lettera o un altro segno punzonato su una moneta. Una contromarca viene apposta tramite un apposito punzone. La maggior parte delle monete vengono contromarcate per cambiarne il valore in seguito a una riforma monetaria. La contromarca è quindi un segno apposto dall'autorità emittente nel dritto o nel rovescio della moneta in epoca posteriore alla sua emissione, per aumentarne o diminuirne il valore e, in caso di necessità, per rimettere in circolazione monete già ritirate.rdfs:comment : This class represent a counterstamp (or countermark), that is a partial or complete over-stamping of a coin, generally affixed in order to change its value or issuing authority.</para>
    ///   <para>rdfs:label : Contromarcardfs:label : Counterstamp</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU 4.00: DA/CON^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Counterstamp">ddesc:Counterstamp</a>
    /// </summary>
    let Counterstamp = _prefixId.prefix "Counterstamp"
    let CoveredArea = _prefixId.prefix "CoveredArea"

    /// <summary>
    ///   <para>rdfs:label : Descrizione tecnica di entità culturalerdfs:label : Cultural entity technical description</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the technical description of a cultural entity, which uses all the technical concepts classifying the technical characteristics that a cultural entity can have. This class is a particular type of the class Description, which is the class for socially constructed objects (i.e. texts, values, categories, relations, contexts) used to describe other objects in a structured manner.rdfs:comment : Questa classe rappresenta la descrizione tecnica di un'entità culturale, la quale utilizza tutti i concetti tecnici che possono classificare caratteristiche tecniche possedute da un'entità culturale. Questa classe è un tipo particolare di Description, la classe degli oggetti costruiti socialmente (testi, valori, categorie, relazioni, contesti), usati per descrivere qualcos'altro in modo strutturato.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalDescription">ddesc:CulturalEntityTechnicalDescription</a>
    /// </summary>
    let CulturalEntityTechnicalDescription =
        _prefixId.prefix "CulturalEntityTechnicalDescription"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>dce:description : An example of usage of the class 'Cultural entity technical status' is the following:
    /// resource:CulturalEntityTechnicalStatus/0900281817-4
    ///         a           a-dd:CulturalEntityTechnicalStatus ;
    ///         rdfs:label  "Technical status of cultural property 0900281817-4"@en ;
    ///         a-dd:includesTechnicalCharacteristic
    ///                 resource:TechnicalCharacteristic/centinato, resource:TechnicalCharacteristic/stone-sculpture .
    ///
    /// resource:TechnicalCharacteristic/stone-sculpture
    ///         a                    a-dd:TechnicalCharacteristic ;
    ///         rdfs:label           "stone/ sculpture" ;
    ///         a-dd:isClassifiedBy  a-dd:MaterialOrTechnique .dce:description : Un esempio d'uso della classe "Stato tecnico di entità culturale" è il seguente:
    /// resource:CulturalEntityTechnicalStatus/0900281817-4
    ///         a           a-dd:CulturalEntityTechnicalStatus ;
    ///         rdfs:label  "Stato tecnico del bene culturale 0900281817-4"@it ;
    ///         a-dd:includesTechnicalCharacteristic
    ///                 resource:TechnicalCharacteristic/centinato, resource:TechnicalCharacteristic/pietra-scultura .
    ///
    /// resource:TechnicalCharacteristic/pietra-scultura
    ///         a                    a-dd:TechnicalCharacteristic ;
    ///         rdfs:label           "pietra/ scultura" ;
    ///         a-dd:isClassifiedBy  a-dd:MaterialOrTechnique .</para>
    ///   <para>rdfs:label : Stato tecnico di entità culturalerdfs:label : Technical status of cultural entity</para>
    ///   <para>rdfs:comment : Questa classe rappresenta lo stato tecnico di un'entità culturale, cioè una situazione in cui un'entità culturale ha associate una serie di caratteristiche tecniche. Lo stato di un'entità ha associata una validità temporale, relativa al momento in cui quelle caratteristiche sono state rilevate. Per esempio, una occorrenza di un dettaglio tecnico è: "bene culturale X realizzato con la materia terracotta e di forma cilindrica".rdfs:comment : This class represents the technical status of a cultural entity, that is a situation in which the cultural entity is associated to technical characteristics. The technical status has a temporal validity, related to the moment when the characteristics were observed. For instance, a cultural property techncal status is: "the cultural property X realized with pottery material and cylindrical in shape".</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTC/MTCM; MT/MTC/MTCT - Normativa OA, D, F, S, MI: MT/FRM - Normativa OA, D, F, S: MT/FIL - Normativa VeAC: MT/MTC/MTCC; MT/MTC/MTCF - Normativa F: MT/FVC/FVCC; MT/FVC/FVCF; MT/FVC/FVCP; MT/FVC/FVCU; MT/FVC/FVCM; MT/FVM;^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalStatus">ddesc:CulturalEntityTechnicalStatus</a>
    /// </summary>
    let CulturalEntityTechnicalStatus = _prefixId.prefix "CulturalEntityTechnicalStatus"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta l'accessibilità di un bene culturale, ovvero la possibilità di accedere al bene, in tutto o in parte, per esempio per effettuare un esame diretto finalizzato alla catalogazione (es.: un bene immobile posto in un luogo recintato non accessibile, un bene mobile che non si può osservare da vicino perché posto troppo in alto su una parete; un bene totalmente accessibile, etc.).rdfs:comment : This class represents the cultural property accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)</para>
    ///   <para>rdfs:label : Accessibilità del bene culturalerdfs:label : Cultural property accessibility</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LC/ACB^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAccessibility">ddesc:CulturalPropertyAccessibility</a>
    /// </summary>
    let CulturalPropertyAccessibility = _prefixId.prefix "CulturalPropertyAccessibility"
    /// <summary>
    ///   <para>rdfs:label : Disponibilità materiale del bene culturalerdfs:label : Cultural Property Availability</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la disponibilità materiale di un bene culturale, ovvero se il bene è materialmente disponibile, per esempio per attività di catalogazione, o se non è disponibile (es.: furto, distruzione)rdfs:comment : This class represents the availability of a cultural property, wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAvailability">ddesc:CulturalPropertyAvailability</a>
    /// </summary>
    let CulturalPropertyAvailability = _prefixId.prefix "CulturalPropertyAvailability"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the definition of a cultural property. It is the term or expression which identifies the property that is being catalogued.rdfs:comment : Questa classe rappresenta la definizione di un bene culturale, cioè il termine o la locuzione che individua il bene che si sta catalogando.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Cultural Property Definitionrdfs:label : Definizione del bene culturale</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyDefinition">ddesc:CulturalPropertyDefinition</a>
    /// </summary>
    let CulturalPropertyDefinition = _prefixId.prefix "CulturalPropertyDefinition"
    /// <summary>
    ///   <para>rdfs:label : Specifiche del bene culturalerdfs:label : Cultural Property Specification</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta specifiche morfologiche o funzionali, utili a completare la definizione del bene per una sua più puntuale individuazione.rdfs:comment : This class represents the morphological or functional specification, which are useful to define a cultural property for a more precise individuation.</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertySpecification">ddesc:CulturalPropertySpecification</a>
    /// </summary>
    let CulturalPropertySpecification = _prefixId.prefix "CulturalPropertySpecification"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di bene culturale, cioè il termine o la locuzione che individua il bene che si sta catalogando ed eventuali ulteriori specifiche sulla definizione del bene.rdfs:comment : This class represents a cultural property's type, that is the term or expression which specifies the cultural propery that is being catalogued and additional information on the cultural property's definition.</para>
    ///   <para>rdfs:label : Cultural property Typerdfs:label : Tipo di bene culturale</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyType">ddesc:CulturalPropertyType</a>
    /// </summary>
    let CulturalPropertyType = _prefixId.prefix "CulturalPropertyType"
    let CurrentDesignation = _prefixId.prefix "CurrentDesignation"
    let CustomaryDesignation = _prefixId.prefix "CustomaryDesignation"
    let DecentConservationStatus = _prefixId.prefix "DecentConservationStatus"
    let DecentLegibility = _prefixId.prefix "DecentLegibility"
    let DecorativeApparatus = _prefixId.prefix "DecorativeApparatus"
    /// <summary>
    ///   <para>rdfs:label : Dedicardfs:label : Dedication</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una dedica, intesa come iscrizione dell'autore (dedicante) su un bene culturale contenente un testo che ha lo scopo di offrire l'oggetto a una persona o un ente (dedicatario).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MI 3.00: AU/DDC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Dedication">ddesc:Dedication</a>
    /// </summary>
    let Dedication = _prefixId.prefix "Dedication"
    let Depth = _prefixId.prefix "Depth"
    let DepthOrHeight = _prefixId.prefix "DepthOrHeight"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a certain cultural property's designation/denomination attested over time.rdfs:comment : Questa classe rappresenta una denominazione e/o dedicazione attestata nel corso del tempo per il bene in esame. Per la normativa FF, la classe rappresenta nello specifico la denominazione o il titolo del fondo attestati nel corso del tempo per il bene in esame; uno stesso fondo può avere più denominazioni/titoli nel corso del tempo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGD - Normative A, BDM, PG 3: OG/OGA.</para>
    ///   <para>rdfs:label : Denominazione nel tempordfs:label : Designation In Time</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/DesignationInTime">ddesc:DesignationInTime</a>
    /// </summary>
    let DesignationInTime = _prefixId.prefix "DesignationInTime"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGD/OGDT - Normative A, BDM, PG 3: OGA/OGAG.</para>
    ///   <para>rdfs:label : Tipo di denominazionerdfs:label : Designation Type</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di denominazione o dedicazione o, per la normativa FF, titolo, del bene (altra lingua, attribuita, attuale, dialettale, etc.)rdfs:comment : This class represents a cultural property's denomination or dedication type, or its title (i.e. other language, current, attributed, dialectal).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/DesignationType">ddesc:DesignationType</a>
    /// </summary>
    let DesignationType = _prefixId.prefix "DesignationType"
    let DialectalDesignation = _prefixId.prefix "DialectalDesignation"
    let Diameter = _prefixId.prefix "Diameter"
    let Diapason = _prefixId.prefix "Diapason"
    let Duration = _prefixId.prefix "Duration"
    let EdgeCircumference = _prefixId.prefix "EdgeCircumference"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'emblema' - ICCD versioni precedenti: DA/STM/STMC = 'emblema' - ICCD Normativa A: LI/LSI/LSIG = 'emblema'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Emblemrdfs:label : Emblema</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un emblema, ovvero una figura o un'immagine simbolica, talvolta accompagnata da un testo scritto (motto, testo in versi, ecc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Emblem">ddesc:Emblem</a>
    /// </summary>
    let Emblem = _prefixId.prefix "Emblem"
    let Extension = _prefixId.prefix "Extension"
    let ExternalInternalLength = _prefixId.prefix "ExternalInternalLength"
    let FileFormat = _prefixId.prefix "FileFormat"
    let Filigree = _prefixId.prefix "Filigree"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Tipo di caratterirdfs:label : Font style</para>
    ///   <para>rdfs:comment : This class represents the font style used in a text (i.e. italic, bold, gothic)rdfs:comment : Questa classe rappresenta il tipo di caratteri utilizzato in un testo (es.: corsivo, grassetto, caratteri gotici, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Traversale 4.00: DA/ISE/ISET - Normative di versioni precedenti: DA/ISR/ISRT</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/FontStyle">ddesc:FontStyle</a>
    /// </summary>
    let FontStyle = _prefixId.prefix "FontStyle"
    let FrontTotalLength = _prefixId.prefix "FrontTotalLength"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/ISE/ISEC - Normative di versioni precedenti: DA/ISR/ISRC; DA/APF/APFF - Normative MA e CA: OG/OGT/OGTF</para>
    ///   <para>rdfs:comment : This class represents the functional purpose (i.e. decorative, religious, symbolic, magic-offensive) of an object (i.e. culural property or iconographic/decorative apparatus or affixed element on a cultural property like an inscription). The functional purpose is intended as the function that an object has to perform.rdfs:comment : Questa classe rappresenta lo scopo funzionale (decorativo, religioso, simbolico, magico-offensivo, etc.), inteso come funzione che deve svolgere, di un oggetto (es bene culturale, apparato iconografico/decorativo o elemento apposto su un bene culturale come un'iscrizione).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Scopo funzionalerdfs:label : Functional purpose</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/FunctionalPurpose">ddesc:FunctionalPurpose</a>
    /// </summary>
    let FunctionalPurpose = _prefixId.prefix "FunctionalPurpose"
    let GarmentAnalysis = _prefixId.prefix "GarmentAnalysis"
    let GarmentColour = _prefixId.prefix "GarmentColour"
    let GoodConservationStatus = _prefixId.prefix "GoodConservationStatus"
    let GoodLegibility = _prefixId.prefix "GoodLegibility"
    let Height = _prefixId.prefix "Height"
    let HeightLength = _prefixId.prefix "HeightLength"
    let HeightLengthWidth = _prefixId.prefix "HeightLengthWidth"
    let HeightWidthThickness = _prefixId.prefix "HeightWidthThickness"
    let HipCircumference = _prefixId.prefix "HipCircumference"
    let HistoricalDesignation = _prefixId.prefix "HistoricalDesignation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa A: LI/LSI/LSIG = 'lapide'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Historical Plaquerdfs:label : Lapide</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una lapide, intesa come una lastra di pietra o marmo recante iscrizioni, figure, simboli, a scopo commemorativo, celebrativo, ecc.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/HistoricalPlaque">ddesc:HistoricalPlaque</a>
    /// </summary>
    let HistoricalPlaque = _prefixId.prefix "HistoricalPlaque"

    let IconographicAndDecorativeApparatus =
        _prefixId.prefix "IconographicAndDecorativeApparatus"

    let IconographicApparatus = _prefixId.prefix "IconographicApparatus"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/AID - ICCD Normative PST e BDM: DA/APF^^xsd:string</para>
    ///   <para>rdfs:label : Apparato iconografico e decorativordfs:label : Iconographic or Decorative Apparatus</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the iconographic or decorative apparaturs of a cultural property. It is intended as the more or less complex set of iconographic or decorative representations on the cultural property.rdfs:comment : Questa classe rappresenta l'apparato iconografico e/o decorativo di un bene culturale, inteso come l'insieme, che può essere più o meno complesso, delle rappresentazioni iconografiche e/o delle decorazioni presenti sul bene.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatus">ddesc:IconographicOrDecorativeApparatus</a>
    /// </summary>
    let IconographicOrDecorativeApparatus =
        _prefixId.prefix "IconographicOrDecorativeApparatus"

    /// <summary>
    ///   <para>rdfs:label : Iconographic Or Decorative Apparatus Typerdfs:label : Tipo di apparato iconografico e decorativo</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo (iconografico, decorativo, iconografico-decorativo) di apparato iconografico e decorativo di un bene culturale.rdfs:comment : This class represents the iconographic or decorative apparatus' type (iconographic, decorative, iconographic-decorative) of a cultual property.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/AID/AIDO^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatusType">ddesc:IconographicOrDecorativeApparatusType</a>
    /// </summary>
    let IconographicOrDecorativeApparatusType =
        _prefixId.prefix "IconographicOrDecorativeApparatusType"

    let IdiomaticDesignation = _prefixId.prefix "IdiomaticDesignation"
    /// <summary>
    ///   <para>rdfs:label : Modalità esecutivardfs:label : Implementation method</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUM/CUMD; CU/CUS/CUSD^^xsd:string</para>
    ///   <para>rdfs:comment : Questa classe rappresenta la modalità esecutiva (es.: alternanza, polifonia) associata a una modalità comunicativa (verbale, musicale vocale, musicale strumentale).rdfs:comment : This class represents the implementation method (e.g.: polyphonic) associated to a verbale or singing or instrumental communication medium.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/ImplementationMethod">ddesc:ImplementationMethod</a>
    /// </summary>
    let ImplementationMethod = _prefixId.prefix "ImplementationMethod"
    let ImpossibleLegibility = _prefixId.prefix "ImpossibleLegibility"
    let Inaccessible = _prefixId.prefix "Inaccessible"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'iscrizione' - ICCD versioni precedenti: DA/ISR - ICCD Normativa A: LI/LSI/LSIG = 'iscrizione'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Inscriptionrdfs:label : Iscrizione</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un'iscrizione, ovvero qualsiasi scritta o segno grafico volontario, realizzati con qualsiasi tecnica (incisione, pittura, stampa, ecc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Inscription">ddesc:Inscription</a>
    /// </summary>
    let Inscription = _prefixId.prefix "Inscription"
    let InstrumentalCommunication = _prefixId.prefix "InstrumentalCommunication"
    let KinesicCommunication = _prefixId.prefix "KinesicCommunication"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta lo stato di leggibilità (totale, buona, discreta, ridotta, assente) di un bene numismatico, relativamente al suo stato di conservazione.rdfs:comment : This class represents the legibility status (complete, decent, good, lowered, impossible) of a numinsmatic property. It is related to the property's conservation status.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Legibilityrdfs:label : Leggibilità</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: CO/STC/STCL^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Legibility">ddesc:Legibility</a>
    /// </summary>
    let Legibility = _prefixId.prefix "Legibility"
    let Length = _prefixId.prefix "Length"
    let LocalDesignation = _prefixId.prefix "LocalDesignation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'logo' - ICCD versioni precedenti: DA/STM/STMC = 'logo' - ICCD Normativa A: LI/LSI/LSIG = 'logo'^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Logordfs:label : Logo</para>
    ///   <para>rdfs:comment : Questa classe rappresenta un logo, ovvero, in ambito commerciale e pubblicitario, scritta e/o simbolo grafico che identifica un prodotto,
    /// un'azienda, ecc.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Logo">ddesc:Logo</a>
    /// </summary>
    let Logo = _prefixId.prefix "Logo"
    let LoweredLegibility = _prefixId.prefix "LoweredLegibility"
    let MassStorage = _prefixId.prefix "MassStorage"
    let Material = _prefixId.prefix "Material"
    let MaterialOrTechnique = _prefixId.prefix "MaterialOrTechnique"
    let MaximumMinimumWidth = _prefixId.prefix "MaximumMinimumWidth"
    let MaximumTotalLength = _prefixId.prefix "MaximumTotalLength"
    let MaximumTotalWidth = _prefixId.prefix "MaximumTotalWidth"
    /// <summary>
    ///   <para>rdfs:label : Measurementrdfs:label : Misura</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa classe rappresenta una misura osservata per un oggetto. Le misure sono relative alle dimensioni del bene in esame. Per la normativa F, le misure possono essere relative anche a supporti secondari, custodie, cornici, singoli fotogrammi, ecc. Per la normativa VeAC, le misure possono essere relative all'ingombro per l'immagazzinaggio; alla base (individuano l'oggetto e la conformazione fisica del proprietario e sono fondamentali per l'allestimento museale, per individuare i tipi di supporti necessari per l'esposizione); alle maniche.rdfs:comment : This class represents a measurement of an object. Measurements realte to the cultural property's dimensions.</para>
    ///   <para>dce:description : Un esempio d'uso della classe "Misura" è il seguente:
    /// resource:Measurement/0500212021-1-height
    ///         a  dd:Measurement ;
    ///         rdfs:label  "Misura del bene culturale 0500212021: 795mm."@it ;
    ///         dd:hasMeasurementType dd:Height ;
    ///         dd:hasValue resource:Value/0500212021-1-height-795 .dce:description : An example of usage of the class 'Measurement' is the following:
    /// resource:Measurement/0500212021-1-height
    ///         a  dd:Measurement ;
    ///         rdfs:label  "Measurement of cultural property 0500212021: 795mm."@en ;
    ///         dd:hasMeasurementType dd:Height ;
    ///         dd:hasValue resource:Value/0500212021-1-height-795 .</para>
    ///   <para>ctlog:iccdNormTag : MT/MIS</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Measurement">ddesc:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Measurement collectionrdfs:label : Collezione di misure</para>
    ///   <para>ctlog:iccdNormTag : MT/MIS - Normativa VeAC: anche MT/MII e MT/MIM</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa classe rappresenta l'insieme delle misurazioni osservate per un oggetto. Per la normativa F, le misure possono essere relative anche a supporti secondari, custodie, cornici, singoli fotogrammi, ecc. Per la normativa VeAC, le misure possono essere relative all'ingombro per l'immagazzinaggio; alla base (individuano l'oggetto e la conformazione fisica del proprietario e sono fondamentali per l'allestimento museale, per individuare i tipi di supporti necessari per l'esposizione); alle maniche.rdfs:comment : This class represents the set of measurments observed for an object.</para>
    ///   <para>dce:description : An example of usage of the class 'Measurement collection' is the following:
    /// resource:MeasurementCollection/1200865132-1
    ///         a  dd:MeasurementCollection ;
    ///         rdfs:label "Measurements of cultural property 1200865132 7"@en ;
    ///         dd:hasMeasurement resource:Measurement/1200865132-1-width , resource:Measurement/1200865132-1-height , resource:Measurement/1200865132-1-depth .dce:description : Un esempio d'uso della classe "Collezione di misure" è il seguente:
    /// resource:MeasurementCollection/1200865132-1
    ///         a  dd:MeasurementCollection ;
    ///         rdfs:label "Misure del bene culturale 1200865132 7"@it ;
    ///         dd:hasMeasurement resource:Measurement/1200865132-1-width , resource:Measurement/1200865132-1-height , resource:Measurement/1200865132-1-depth .</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/MeasurementCollection">ddesc:MeasurementCollection</a>
    /// </summary>
    let MeasurementCollection = _prefixId.prefix "MeasurementCollection"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Tipo di Misurardfs:label : Measurement Type</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il tipo di misura osservata (larghezza, altezza, diametro, etc.)rdfs:comment : This class represents the observed measurement type (width, height, diameter, etc).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: MT/MIS/MISZ; MT/MNR - Per versioni di normativa precedenti alla 4.00: MT/MIS/MISA; MT/MIS/MISD; MT/MIS/MISL; MT/MIS/MISN; MT/MIS/MISG; MT/MIS/MISP; MT/MIS/MISS; MT/MIS/MISR; MT/MIS/MISV - ICCD scheda VeAC: MT/MII/MIIA; MT/MII/MIIL; MT/MII/MIIP; MT/MIS/MISR; MT/MIS/MISD; MT/MIS/MISS; MT/MIS/MISP; MT/MIS/MISV; MT/MIS/MISF; MT/MIS/MISO</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/MeasurementType">ddesc:MeasurementType</a>
    /// </summary>
    let MeasurementType = _prefixId.prefix "MeasurementType"
    let MediocreConservationStatus = _prefixId.prefix "MediocreConservationStatus"
    let NoLongerAvailable = _prefixId.prefix "NoLongerAvailable"
    let OccupiedStorageSpace = _prefixId.prefix "OccupiedStorageSpace"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents the orientation of an object (i.e. N.W., S.E.), considering the main axis.rdfs:comment : Questa classe rappresenta l'orientamento di un oggetto (NO, SE, etc.), secondo l'asse principale individuato.</para>
    ///   <para>rdfs:label : Orientationrdfs:label : Orientamento</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: MT/ORT - ICCD Schede CA e MA: MT/ORT</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Orientation">ddesc:Orientation</a>
    /// </summary>
    let Orientation = _prefixId.prefix "Orientation"
    let OriginalDesignation = _prefixId.prefix "OriginalDesignation"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the ornamental motif (anthropomorphous, zoomorphic, geometric) represented by a cultural property's iconographic and decorative apparatus.rdfs:comment : Questa classe rappresenta il motivo decorativo (antropomorfo, zoomorfo, geometrico) rappresentato da un apparato iconografico e decorativo di un bene culturale.</para>
    ///   <para>rdfs:label : Motivo decorativordfs:label : Ornamental Motif</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/OrnamentalMotif">ddesc:OrnamentalMotif</a>
    /// </summary>
    let OrnamentalMotif = _prefixId.prefix "OrnamentalMotif"
    let OtherLanguageDesignation = _prefixId.prefix "OtherLanguageDesignation"
    let PartiallyAccessible = _prefixId.prefix "PartiallyAccessible"
    let Perimeter = _prefixId.prefix "Perimeter"
    let PhotoColour = _prefixId.prefix "PhotoColour"
    let PhotoProgram = _prefixId.prefix "PhotoProgram"
    let PhotoSize = _prefixId.prefix "PhotoSize"
    let PixelDimension = _prefixId.prefix "PixelDimension"
    let Power = _prefixId.prefix "Power"
    let ProxemicsCommunication = _prefixId.prefix "ProxemicsCommunication"
    let QualityLevel = _prefixId.prefix "QualityLevel"
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>rdfs:label : Campione prelevatordfs:label : Sample collected</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This class represents a sample collected from an archeological property.rdfs:comment : Questa classe rappresenta un campione prelevato da un bene archeologico.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MA, CA, SI, SAS: MC/CMN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/SampleCollected">ddesc:SampleCollected</a>
    /// </summary>
    let SampleCollected = _prefixId.prefix "SampleCollected"
    /// <summary>
    ///   <para>rdfs:label : Sample collected typerdfs:label : Tipo di campione prelevato</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents the sample type collected from an archaeologiacal property (i.e. coal, pottery, grout)rdfs:comment : Questa classe rappresenta il tipo di campione prelevato da un bene archeologico (es.: carbone, ceramica, intonaco, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MA, CA, SI, SAS: MC/CMN/CMNT^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/SampleCollectedType">ddesc:SampleCollectedType</a>
    /// </summary>
    let SampleCollectedType = _prefixId.prefix "SampleCollectedType"
    let Shape = _prefixId.prefix "Shape"
    let SingingCommunication = _prefixId.prefix "SingingCommunication"
    let SlangDesignation = _prefixId.prefix "SlangDesignation"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: se DA/ISE/ISED = 'timbro' - ICCD versioni precedenti: DA/STM/STMC = 'timbro' - ICCD Normativa A: LI/LSI/LSIG = 'timbro'</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Stamprdfs:label : Timbro</para>
    ///   <para>rdfs:comment : Questa classe rappresenta il segno impresso con un timbro, ovvero uno strumento di gomma o di metallo per imprimere segni a inchiostro oppure a secco.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Stamp">ddesc:Stamp</a>
    /// </summary>
    let Stamp = _prefixId.prefix "Stamp"
    let StorageCapacity = _prefixId.prefix "StorageCapacity"
    let StorageMethodColourDepth = _prefixId.prefix "StorageMethodColourDepth"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il supporto sul quale può trovarsi un elemento, per esempio un'iscrizione, un emblema, un timbro, etc., rappresentati su un bene culturale (es. "etichetta di carta").rdfs:comment : This class represents the support on which an element can be located, for instance an inscription, emblem, postmark represented on a cultural property (i.e. "paper label").</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISES^^xsd:string</para>
    ///   <para>rdfs:label : Supportordfs:label : Support</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/Support">ddesc:Support</a>
    /// </summary>
    let Support = _prefixId.prefix "Support"
    /// <summary>
    ///   <para>rdfs:label : Caratteristica tecnicardfs:label : Technical Characteristic</para>
    ///   <para>rdfs:comment : This class represents a characteristic of a cultural property. For example it can represent a cultural property's particular costituent material or the technique with which it was made or its shape or color. Each technical characteristic is classified by a concept (i.e. "clay" is a techical characteristic classified by the technical concept "material" related to a cultural property). For each cultural property typology can be registered some specific technical characteristics.rdfs:comment : Questa classe rappresenta una caratteristica tecnica relativa a un bene culturale. Per esempio, può rappresentare una particolare materia di cui è composto, la tecnica con cui è stato realizzato, la sua forma, il suo colore. Ogni caratteristica tecnica utilizza è definito da un concetto (es.: "terracotta" è una caratteristica tecnica definita dal concetto "materia", relativamente a un bene culturale). Per ogni tipologia di bene culturale possono essere rilevati e registrate caratteristiche tecnice specifiche.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTC/MTCM; MT/MTC/MTCT - Normativa OA, D, F, S, MI: MT/FRM - Normativa OA, D, F, S: MT/FIL - Normativa VeAC: MT/MTC/MTCC; MT/MTC/MTCF - Normativa F: MT/FVC/FVCC; MT/FVC/FVCF; MT/FVC/FVCP; MT/FVC/FVCU; MT/FVC/FVCM; MT/FVM;^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/TechnicalCharacteristic">ddesc:TechnicalCharacteristic</a>
    /// </summary>
    let TechnicalCharacteristic = _prefixId.prefix "TechnicalCharacteristic"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class represents a technical concept, a particular type of concept that classifies a technical characteristic of an entity, e.g. cultural property. For instance, "material" is a techincal concept that classifies the technical characteristic "pottery" related to a cultural property.rdfs:comment : Questa classe rappresenta un concetto tecnico, inteso come tipo particolare di concetto che fornisce una classificazione a una caratteristica tecnica di un'entità, es. un bene culturale. Per esempio, "materia" è un concetto tecnico che può essere utilizzato per classificare la caratteristica tecnica "terracotta" relativa a un bene culturale.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTC/MTCM; MT/MTC/MTCT - Normativa OA, D, S, MI: MT/FRM - Normativa OA, D, F, S: MT/FIL - Normativa VeAC: MT/MTC/MTCC; MT/MTC/MTCF - Normativa F: MT/FVC/FVCC; MT/FVC/FVCF; MT/FVC/FVCP; MT/FVC/FVCU; MT/FVC/FVCM; MT/FVM; MT/MTX; MT/FVM; MT/FRM;^^xsd:string</para>
    ///   <para>rdfs:label : Concetto tecnicordfs:label : Technical concept</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/TechnicalConcept">ddesc:TechnicalConcept</a>
    /// </summary>
    let TechnicalConcept = _prefixId.prefix "TechnicalConcept"
    let Technique = _prefixId.prefix "Technique"
    let Temperament = _prefixId.prefix "Temperament"
    let Thickness = _prefixId.prefix "Thickness"
    let Tuning = _prefixId.prefix "Tuning"
    let UnavailableConservationStatus = _prefixId.prefix "UnavailableConservationStatus"
    let UndetectedMeasurements = _prefixId.prefix "UndetectedMeasurements"
    let VariousMeasurements = _prefixId.prefix "VariousMeasurements"
    let VerbalCommunication = _prefixId.prefix "VerbalCommunication"
    let VibratingLenght = _prefixId.prefix "VibratingLenght"
    let Volume = _prefixId.prefix "Volume"
    let VolumetricDiamensions = _prefixId.prefix "VolumetricDiamensions"
    let WaistCircumference = _prefixId.prefix "WaistCircumference"
    let Weight = _prefixId.prefix "Weight"
    let Width = _prefixId.prefix "Width"
    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta il sistema di scrittura/alfabeto adottati in una iscrizione, un timbro, uno stemma, etc.rdfs:comment : This class represents the writing system or alphabet of an inscription, postmark, crest etc.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEF^^xsd:string</para>
    ///   <para>rdfs:label : Sistema di scritturardfs:label : Writing system</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/WritingSystem">ddesc:WritingSystem</a>
    /// </summary>
    let WritingSystem = _prefixId.prefix "WritingSystem"
    let WrittenCommunication = _prefixId.prefix "WrittenCommunication"

    /// <summary>
    ///   <para>rdfs:label : morfologia di reperto antropologicordfs:label : anthropological material morphology</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la morfologia di un reperto antropologico (es.: morfologia naturale; morfologia alterata intra-vitam per cause naturali e/o per intervento antropico; morfologia/ struttura alterata post-mortem per cause naturali).rdfs:comment : This property represents the morphology of an anthropological material.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa AT 3.01: OG/OGT/OGTM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/anthropologicalMaterialMorphology">ddesc:anthropologicalMaterialMorphology</a>
    /// </summary>
    let anthropologicalMaterialMorphology =
        _prefixId.prefix "anthropologicalMaterialMorphology"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha note producibili".rdfs:comment : This is the inverse property of "has available notes".</para>
    ///   <para>rdfs:label : sono note producibili dirdfs:label : are available notes of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/areAvailableNotesOf">ddesc:areAvailableNotesOf</a>
    /// </summary>
    let areAvailableNotesOf = _prefixId.prefix "areAvailableNotesOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : classifies technical characteristicrdfs:label : classifica caratteristica tecnica</para>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "è caratteristica classificata da", collega un concetto tecnico a una caratteristica tecnica di un'entità - come un bene culturale.rdfs:comment : This property connects a techical concept to an entity's technical characteristic. It is the inverse property of isCharacteristicClassifiedBy.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/classifiesCharacteristic">ddesc:classifiesCharacteristic</a>
    /// </summary>
    let classifiesCharacteristic = _prefixId.prefix "classifiesCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the date of construction of a musical instrument's accessory.rdfs:comment : Questa proprietà rappresenta la data di costruzione di un accessorio di uno strumento musicale.</para>
    ///   <para>rdfs:label : creation daterdfs:label : data di creazione</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: AS/ASS/ASSD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/creationDate">ddesc:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>rdfs:label : has accessoryrdfs:label : ha accessorio</para>
    ///   <para>rdfs:comment : This property relates a musical good to one of its accessories. In other words, it is an object linkable to a musical object, whether it is functional to the sound production, or if it is the sound's production or conservation medium.rdfs:comment : Questa proprietà collega un bene musicale a un suo accessorio, ovvero un oggetto collegabile al bene musicale, sia nel caso in cui sia funzionale alla produzione del suono, sia nel caso in cui sia di supporto alla produzione del suono o alla conservazione o alla prassi musicale del bene.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa SM 4.00: AS/ASS/ASST^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasAccessory">ddesc:hasAccessory</a>
    /// </summary>
    let hasAccessory = _prefixId.prefix "hasAccessory"
    /// <summary>
    ///   <para>rdfs:label : has element affixed to cultural propertyrdfs:label : ha elemento apposto sul bene</para>
    ///   <para>rdfs:comment : This property relates a cultural property to an element affixed on it (e.g. inscription, stamp, etc.)rdfs:comment : Questa proprietà collega un bene culturale a un elemento apposto sul bene (es.: emblema, timbro, iscrizione, etc.)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE - ICCD versioni precedenti alla 4.00: DA/ISR; DA/STM - ICCD Normativa A: LI/LSI - ICCD Normativa MI: AU/DDC</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElement">ddesc:hasAffixedElement</a>
    /// </summary>
    let hasAffixedElement = _prefixId.prefix "hasAffixedElement"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEE - Normative di versioni precedenti: DA/STM/STMQ</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'iscrizione, un emblema, un timbro, uno stemma, etc., al suo tipo (es.: gentilizio, civile, religioso, etc.)rdfs:comment : This property relatesan inscription (or an emblem, a mark, etc.) to its type.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has affixed element typerdfs:label : ha tipo di elemento apposto</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElementType">ddesc:hasAffixedElementType</a>
    /// </summary>
    let hasAffixedElementType = _prefixId.prefix "hasAffixedElementType"
    /// <summary>
    ///   <para>rdfs:label : has available notesrdfs:label : ha note producibili</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento musicale, dal grave all'acuto, alle note producibili dallo strumento.rdfs:comment : This property relates a musical instrument to the playable notes by it, from low to high.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasAvailableNotes">ddesc:hasAvailableNotes</a>
    /// </summary>
    let hasAvailableNotes = _prefixId.prefix "hasAvailableNotes"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU^^xsd:string</para>
    ///   <para>rdfs:label : ha modalità comunicativardfs:label : has communication medium</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale immateriale a una modalità comunicativa mediante la quale il bene viene veicolato.rdfs:comment : This property relates an intangible cultural property to a communication medium.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMedium">ddesc:hasCommunicationMedium</a>
    /// </summary>
    let hasCommunicationMedium = _prefixId.prefix "hasCommunicationMedium"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU^^xsd:string</para>
    ///   <para>rdfs:label : ha tipo di modalità comunicativardfs:label : has communication medium type</para>
    ///   <para>rdfs:comment : This property relates a communication medium to its type (e.g.: verbal, singing, etc.)rdfs:comment : Questa proprietà collega una modalità comunicativa di un oggetto al tipo di modalità comunicativa (verbale, strumentale, etc.)</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMediumType">ddesc:hasCommunicationMediumType</a>
    /// </summary>
    let hasCommunicationMediumType = _prefixId.prefix "hasCommunicationMediumType"
    /// <summary>
    ///   <para>rdfs:comment : This property relates the cultural property with its conservation status.rdfs:comment : Questa proprietà associa il bene culturale al suo stato di conservazione.</para>
    ///   <para>rdfs:label : has conservation statusrdfs:label : ha stato di conservazione</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : CO/STC^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatus">ddesc:hasConservationStatus</a>
    /// </summary>
    let hasConservationStatus = _prefixId.prefix "hasConservationStatus"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : CO/STC/STCC^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà associa lo stato di conservazione a uno dei valori del tipo di stato di conservazione.rdfs:comment : This property relates a conservation status to one of its type's values.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha tipo di stato di conservazionerdfs:label : has conservation status type</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatusType">ddesc:hasConservationStatusType</a>
    /// </summary>
    let hasConservationStatusType = _prefixId.prefix "hasConservationStatusType"

    /// <summary>
    ///   <para>rdfs:label : ha accessibilitàrdfs:label : has cultural property accessibility</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: LC/ACB^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega il bene culturale alla sua accessibilità, ovvero la possibilità di accedere al bene, in tutto o in parte, per esempio per effettuare un esame diretto finalizzato alla catalogazione (es.: un bene immobile posto in un luogo recintato non accessibile, un bene mobile che non si può osservare da vicino perché posto troppo in alto su una parete; un bene totalmente accessibile, etc.).rdfs:comment : This property relates the cultural property to its accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAccessibility">ddesc:hasCulturalPropertyAccessibility</a>
    /// </summary>
    let hasCulturalPropertyAccessibility =
        _prefixId.prefix "hasCulturalPropertyAccessibility"

    /// <summary>
    ///   <para>rdfs:label : has cultural property availabilityrdfs:label : ha disponibilità materiale</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This class relates the cultural property to its availability, that is wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.rdfs:comment : Questa proprietà collega il bene culturale alla sua disponibilità materiale, ovvero se il bene è materialmente disponibile, per esempio per attività di catalogazione, o se non è disponibile (es.: furto, distruzione)</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGR^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAvailability">ddesc:hasCulturalPropertyAvailability</a>
    /// </summary>
    let hasCulturalPropertyAvailability =
        _prefixId.prefix "hasCulturalPropertyAvailability"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega la tipologia di un bene culturale a una delle sue componenti, cioè la definizione.rdfs:comment : This property relates a cultural entity's typology to one of its components, i.e.  its definition.</para>
    ///   <para>rdfs:label : ha definizione del bene culturalerdfs:label : has cultural property definition</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTD^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyDefinition">ddesc:hasCulturalPropertyDefinition</a>
    /// </summary>
    let hasCulturalPropertyDefinition = _prefixId.prefix "hasCulturalPropertyDefinition"

    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural entity's typology to its components, i.e. morphological and functional specifications.rdfs:comment : Questa proprietà collega la tipologia di un bene culturale a una delle sue componenti, cioè alle specifiche morfologiche e funzionali.</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT/OGTT^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has cultural property specificationrdfs:label : ha specifiche del bene culturale</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertySpecification">ddesc:hasCulturalPropertySpecification</a>
    /// </summary>
    let hasCulturalPropertySpecification =
        _prefixId.prefix "hasCulturalPropertySpecification"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : OG/OGT^^xsd:string</para>
    ///   <para>rdfs:label : has cultural property typerdfs:label : ha tipo di bene culturale</para>
    ///   <para>rdfs:comment : This property relates a cultural property to its type.rdfs:comment : Questa proprietà collega un bene culturale al tipo di bene, per permettere la corretta e precisa individuazione del bene.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyType">ddesc:hasCulturalPropertyType</a>
    /// </summary>
    let hasCulturalPropertyType = _prefixId.prefix "hasCulturalPropertyType"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una dedica al dedicatario, cioè alla persona o ente cui è rivolta la dedica.rdfs:comment : This property connects a dedication to its dedicaatee, which is the person or institution to whom the dedication is addressed.</para>
    ///   <para>rdfs:label : has dedicateerdfs:label : ha dedicatario</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MI 3.00: AU/DDC/DDCM^^xsd:string</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasDedicatee">ddesc:hasDedicatee</a>
    /// </summary>
    let hasDedicatee = _prefixId.prefix "hasDedicatee"
    /// <summary>
    ///   <para>rdfs:comment : This property connects a cultural entity to its denomination and/or dedication, or title (for FF legislation) over time.rdfs:comment : Questa proprietà associa un bene culturale alla sua denominazione e/o dedicazione o, per la normativa FF, titolo, nel corso del tempo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGD^^xsd:string</para>
    ///   <para>rdfs:label : has designation in timerdfs:label : ha designazione nel tempo</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasDesignationInTime">ddesc:hasDesignationInTime</a>
    /// </summary>
    let hasDesignationInTime = _prefixId.prefix "hasDesignationInTime"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a cultural entity designation to its type.</para>
    ///   <para>rdfs:label : has designation typerdfs:label : ha tipo di denominazione</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: OG/OGD/OGDT^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : Questa proprietà collega una denominazione o dedicazione o, per la normativa FF, titolo nel tempo al tipo di denominazione del bene (altra lingua, attribuita, attuale, dialettale, etc.)owl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasDesignationType">ddesc:hasDesignationType</a>
    /// </summary>
    let hasDesignationType = _prefixId.prefix "hasDesignationType"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has diapasonrdfs:label : ha corista</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento musical al corista rilevato (nota, temperatura ed eventualmente umidità ambientale al momento della rilevazione).rdfs:comment : This property relates a musical instrument to the identified diapason (note, temperature and eventually humidity during the detection).</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasDiapason">ddesc:hasDiapason</a>
    /// </summary>
    let hasDiapason = _prefixId.prefix "hasDiapason"
    /// <summary>
    ///   <para>rdfs:label : ha estensionerdfs:label : has extension</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento musicale alla sua estensione musicale.rdfs:comment : This property relates a musical instrument to its extension.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasExtension">ddesc:hasExtension</a>
    /// </summary>
    let hasExtension = _prefixId.prefix "hasExtension"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has file formatrdfs:label : ha formato di estensione/compressione del file</para>
    ///   <para>rdfs:comment : Questa proprietà collega una risorsa digitale su supporto informatico al formato utilizzato per la scrittura della risorsa.rdfs:comment : This property relates a digital resource to the format used to write it on a data medium.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasFileFormat">ddesc:hasFileFormat</a>
    /// </summary>
    let hasFileFormat = _prefixId.prefix "hasFileFormat"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un'opera d'arte, un disegno, una fotografia, una stampa alla sua filigrana.rdfs:comment : This property relates an artwork, painting, photography, print to its filigree.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha filigranardfs:label : has filigree</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasFiligree">ddesc:hasFiligree</a>
    /// </summary>
    let hasFiligree = _prefixId.prefix "hasFiligree"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Traversale 4.00: DA/ISE/ISET - Normative di versioni precedenti: DA/ISR/ISRT</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property connects an inscription or emblem, postmark, crest, etc. to the font style which has been adopted (e.g.: italic, bold, gothic etc).rdfs:comment : Questa proprietà collega un'iscrizione, uno stemma, un timbro, etc., al tipo di caratteri che viene adottato (es.: corsivo, grassetto, caratteri gotici, etc.).</para>
    ///   <para>rdfs:label : ha tipo di caratterirdfs:label : has font style</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasFontStyle">ddesc:hasFontStyle</a>
    /// </summary>
    let hasFontStyle = _prefixId.prefix "hasFontStyle"
    /// <summary>
    ///   <para>rdfs:label : has functional purposerdfs:label : ha scopo funzionale</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: DA/ISE/ISEC - Normative di versioni precedenti: DA/ISR/ISRC; DA/APF/APFF</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un oggetto (es bene culturale, apparato iconografico/decorativo o elemento apposto su un bene culturale come un'iscrizione) al suo scopo funzionale (decorativo, religioso, simbolico, magico-offensivo, etc.), inteso come funzione che deve svolgere.rdfs:comment : This property realtes an object (e.g. cultural entity, iconographic/decorative apparatus, affixed element like an inscription) to its functional purpose, intended as the function the object has to perform (decorative, religious, symbolic, magic-offensive etc.).</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasFunctionalPurpose">ddesc:hasFunctionalPurpose</a>
    /// </summary>
    let hasFunctionalPurpose = _prefixId.prefix "hasFunctionalPurpose"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha analisi del vestimentordfs:label : has garment analysis</para>
    ///   <para>rdfs:comment : Questa proprietà collega un vestimento antico o contemporaneo alla definizione tecnica completa dei tessuti, secondo le norme fornite dal C.I.E.T.A., o dei merletti, oppure rappresenta la distinzione fra tessuto unito e tessuto operato.rdfs:comment : This property relates an ancient or contemporary garment to the technical definition of textured fabrics, according to the standard provided by C.I.E.T.A., or laces. It can represent the dinstinction between plain fabric and textured fabric.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasGarmentAnalysis">ddesc:hasGarmentAnalysis</a>
    /// </summary>
    let hasGarmentAnalysis = _prefixId.prefix "hasGarmentAnalysis"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an ancient and contemporary garment to its dominant color, usually it is base fabric's color, or the interlaced decoration's color.rdfs:comment : Questa proprietà collega un vestimento antico o contemporaneo al colore dominante, di solito quello del fondo del tessuto, o quello risultante dall'intreccio.</para>
    ///   <para>rdfs:label : has garment colourrdfs:label : ha colore del vestimento</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasGarmentColour">ddesc:hasGarmentColour</a>
    /// </summary>
    let hasGarmentColour = _prefixId.prefix "hasGarmentColour"

    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene culturale al suo apparato iconografico e/o decorativo, inteso come l'insieme, che può essere più o meno complesso, delle rappresentazioni iconografiche e/o delle decorazioni presenti sul bene.rdfs:comment : This property relates a cultural enitity to its iconographic or decorative apparatus.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has iconographic or decorative apparatusrdfs:label : ha apparato iconografico e decorativo</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/AID - ICCD Normative PST e BDM: DA/APF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus">ddesc:hasIconographicOrDecorativeApparatus</a>
    /// </summary>
    let hasIconographicOrDecorativeApparatus =
        _prefixId.prefix "hasIconographicOrDecorativeApparatus"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega un apparato iconografico e decorativo di un bene culturale al tipo di apparato (iconografico, decorativo, iconografico-decorativo).rdfs:comment : This property relates a iconographic or decorative apparatus to its type.</para>
    ///   <para>rdfs:label : has iconographic or decorative apparatus typerdfs:label : ha tipo di apparato iconografico e decorativo</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType">ddesc:hasIconographicOrDecorativeApparatusType</a>
    /// </summary>
    let hasIconographicOrDecorativeApparatusType =
        _prefixId.prefix "hasIconographicOrDecorativeApparatusType"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates a verbal or singing or instrumental communication medium to its implementation method (e.g.: polyphonic) associated to it.rdfs:comment : Questa proprietà collega una modalità comunicativa verbale o musicale vocale o musicale strumentale alla modalità esecutiva associata (es.: polifonica).</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUM/CUMD; CU/CUS/CUSD^^xsd:string</para>
    ///   <para>rdfs:label : ha modalità esecutivardfs:label : has implementation method</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasImplementationMethod">ddesc:hasImplementationMethod</a>
    /// </summary>
    let hasImplementationMethod = _prefixId.prefix "hasImplementationMethod"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega lo stato di conservazione di un bene numismatico al suo stato di leggibilità.rdfs:comment : This property relates a numismatic entity's conservation status to its legibility status.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa NU: CO/STC/STCL^^xsd:string</para>
    ///   <para>rdfs:label : ha leggibilitàrdfs:label : has legibility</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasLegibility">ddesc:hasLegibility</a>
    /// </summary>
    let hasLegibility = _prefixId.prefix "hasLegibility"
    /// <summary>
    ///   <para>ctlog:iccdNormTag : se 4.00 LA/TLC o versioni precedenti a 4.00 LA/TCL = "area rappresentata"</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta l'area rappresentata come soggetto di un bene culturale.rdfs:comment : This property represent the location as a subject of a cultural entity.</para>
    ///   <para>rdfs:label : ha localizzazione rappresentatardfs:label : has location as subject</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasLocationSubject">ddesc:hasLocationSubject</a>
    /// </summary>
    let hasLocationSubject = _prefixId.prefix "hasLocationSubject"
    /// <summary>
    ///   <para>rdfs:label : ha memoria di massardfs:label : has mass storage</para>
    ///   <para>rdfs:comment : Questa proprietà collega una risorsa digitale alla memoria di massa nella quale è stata memorizzata la fotografia digitale.rdfs:comment : This property relates a digital photograph to the mass storage where a digital photograph is stored.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMassStorage">ddesc:hasMassStorage</a>
    /// </summary>
    let hasMassStorage = _prefixId.prefix "hasMassStorage"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has materialrdfs:label : ha materia</para>
    ///   <para>rdfs:comment : This property relates an object to its material.rdfs:comment : Questa proprietà collega un oggetto (per esempio un bene culturale) alla materia con cui è realizzato.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMaterial">ddesc:hasMaterial</a>
    /// </summary>
    let hasMaterial = _prefixId.prefix "hasMaterial"
    /// <summary>
    ///   <para>rdfs:label : has material or techniquerdfs:label : ha materia e tecnica</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates an object to the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standards for cataloguing cultural entities, this label is necessary when material and technique are registered in the same field.rdfs:comment : Questa proprietà collega un oggetto alla materia e/o la tecnica con cui è realizzato l'oggetto, per esempio un bene culturale. Nel dominio delle normative  ICCD per la catalogazione dei beni culturali, si rende necessaria nei casi in cui materia e tecnica sono registrate nello stesso campo, nella forma "materia/ tecnica".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMaterialOrTechnique">ddesc:hasMaterialOrTechnique</a>
    /// </summary>
    let hasMaterialOrTechnique = _prefixId.prefix "hasMaterialOrTechnique"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha misurardfs:label : has measurement</para>
    ///   <para>ctlog:iccdNormTag : MT/MIS - Normativa VeAC: anche MT/MIM</para>
    ///   <para>rdfs:comment : Questa proprietà collega un insieme di misure osservate per un oggetto a una delle misure.rdfs:comment : This property connects a set of observed measures on an object to one of those measures.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMeasurement">ddesc:hasMeasurement</a>
    /// </summary>
    let hasMeasurement = _prefixId.prefix "hasMeasurement"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un oggetto all'insieme delle misure osservate per quell'oggetto.rdfs:comment : This property connects an object to the collection of observed measures on it.</para>
    ///   <para>ctlog:iccdNormTag : MT/MIS - Normativa VeAC: anche MT/MII e MT/MIM</para>
    ///   <para>rdfs:label : ha collezione di misurerdfs:label : has measurement collection</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementCollection">ddesc:hasMeasurementCollection</a>
    /// </summary>
    let hasMeasurementCollection = _prefixId.prefix "hasMeasurementCollection"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a measurement to its type.rdfs:comment : Questa proprietà collega una misura al tipo di misura (altezza, larghezza, diametro, etc.)</para>
    ///   <para>rdfs:label : ha tipo di misurardfs:label : has measurement type</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: MT/MIS/MISZ; MT/MNR - Per versioni di normativa precedenti alla 4.00: MT/MIS/MISA; MT/MIS/MISD; MT/MIS/MISL; MT/MIS/MISN; MT/MIS/MISG; MT/MIS/MISP; MT/MIS/MISS; MT/MIS/MISR; MT/MIS/MISV - ICCD scheda VeAC: MT/MII/MIIA; MT/MII/MIIL; MT/MII/MIIP; MT/MIS/MISR; MT/MIS/MISD; MT/MIS/MISS; MT/MIS/MISP; MT/MIS/MISV; MT/MIS/MISF; MT/MIS/MISO</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementType">ddesc:hasMeasurementType</a>
    /// </summary>
    let hasMeasurementType = _prefixId.prefix "hasMeasurementType"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un oggetto al suo orientamento, secondo l'asse principale individuato.rdfs:comment : This property connects an object to its orientation, considering its major axis.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale: MT/ORT - ICCD Schede CA e MA: MT/ORT</para>
    ///   <para>rdfs:label : has orientationrdfs:label : ha orientamento</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasOrientation">ddesc:hasOrientation</a>
    /// </summary>
    let hasOrientation = _prefixId.prefix "hasOrientation"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega l'apparato iconografico e decorativo di un bene culturale al motivo decorativo (antropomorfo, zoomorfo, geometrico) rappresentato.rdfs:comment : This property connects a cultural entity's iconographic or decorative apparatus to its ornamental motif (anthropomorphic, zoomorphic, geometric).</para>
    ///   <para>rdfs:isDefinedBy : unstablerdfs:isDefinedBy : provvisoria</para>
    ///   <para>rdfs:label : ha motivo decorativordfs:label : has ornamental motif</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasOrnamentalMotif">ddesc:hasOrnamentalMotif</a>
    /// </summary>
    let hasOrnamentalMotif = _prefixId.prefix "hasOrnamentalMotif"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a digital photograph to its colour, i.e. black and white or colours.rdfs:comment : Questo individuo collega una fotografia digitale al colore della fotografia digitale, ovvero se trattasi di fotografia in bianco/nero o a colori.</para>
    ///   <para>rdfs:label : has photo colourrdfs:label : ha colore della foto</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasPhotoColour">ddesc:hasPhotoColour</a>
    /// </summary>
    let hasPhotoColour = _prefixId.prefix "hasPhotoColour"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha programma per fotordfs:label : has photo program</para>
    ///   <para>rdfs:comment : Questa proprietà collega una fotografia digitale al programma di visualizzazione, memorizzazione ed elaborazione utilizzato per la fotografia digitale.rdfs:comment : This property relates a digital photograph to the visualization, storage and processing program used for the digital photograph.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasPhotoProgram">ddesc:hasPhotoProgram</a>
    /// </summary>
    let hasPhotoProgram = _prefixId.prefix "hasPhotoProgram"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a digital photograph to its format, intended as the photographic material's standardised size (e.g. negative, positives).rdfs:comment : Questa proprietà collega una risorsa digitale al formato della risorsa, inteso come la dimensione standardizzata (es.: per i materiali fotografici negativi, positivi, ecc.).</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has photo sizerdfs:label : ha dimensioni della foto</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasPhotoSize">ddesc:hasPhotoSize</a>
    /// </summary>
    let hasPhotoSize = _prefixId.prefix "hasPhotoSize"
    /// <summary>
    ///   <para>rdfs:label : has pixel dimensionrdfs:label : ha dimensioni in pixel</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'immagine digitale (es.: fotografia) alle dimensioni, in pixel, dell'immagine.rdfs:comment : This property relates a digital resource to its size in pixels.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasPixelDimension">ddesc:hasPixelDimension</a>
    /// </summary>
    let hasPixelDimension = _prefixId.prefix "hasPixelDimension"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a digital resource to its quality level, e.g. high-resolution, low-resolution, preview.rdfs:comment : Questa proprietà collega una risorsa digitale al livello di qualità della risorsa (es.: alta risoluzione, bassa risoluzione, preview)</para>
    ///   <para>rdfs:label : ha livello di qualitàrdfs:label : has quality level</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasQualityLevel">ddesc:hasQualityLevel</a>
    /// </summary>
    let hasQualityLevel = _prefixId.prefix "hasQualityLevel"
    /// <summary>
    ///   <para>rdfs:label : has resolutionrdfs:label : ha risoluzione</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega una fotografia alla risoluzione e al valore specifico utilizzati per la memorizzazione di una fotografia digitale.rdfs:comment : This property relates a digital resource to theresolution used for storing it.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasResolution">ddesc:hasResolution</a>
    /// </summary>
    let hasResolution = _prefixId.prefix "hasResolution"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un bene archeologico a un campione prelevato da esso.rdfs:comment : This property connects a archaeological entity to a sample collected from it.</para>
    ///   <para>rdfs:label : has sample collectedrdfs:label : ha campione prelevato</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MA, CA, SI, SAS: MC/CMN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollected">ddesc:hasSampleCollected</a>
    /// </summary>
    let hasSampleCollected = _prefixId.prefix "hasSampleCollected"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega un campione prelevato da un bene archeologico al tipo di campione (es.: intonaco, carbone, etc.)rdfs:comment : This property relates a sample collected to its type.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MA, CA, SI, SAS: MC/CMN/CMNT^^xsd:string</para>
    ///   <para>rdfs:label : has sample collected typerdfs:label : ha tipo di campione prelevato</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollectedType">ddesc:hasSampleCollectedType</a>
    /// </summary>
    let hasSampleCollectedType = _prefixId.prefix "hasSampleCollectedType"
    /// <summary>
    ///   <para>rdfs:label : ha formardfs:label : has shape</para>
    ///   <para>rdfs:comment : This property relates an object to its shape. It is used for bidimensional objects, e.g. octagonal or round shape.rdfs:comment : Questa proprietà collega un oggetto al formato dell'oggetto, per oggetti bidimensionali (es.: ottagonale, tondo)</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasShape">ddesc:hasShape</a>
    /// </summary>
    let hasShape = _prefixId.prefix "hasShape"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una fotografia al metodo e alla profondità di colore con cui è stata memorizzata la fotografia digitale.rdfs:comment : This property relates a digital photograph to the method and color depth through which a digital photograph has been stored.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has storage method or colour depthrdfs:label : ha metodo di memorizzazione e profondità del colore</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasStorageMethodOrColourDepth">ddesc:hasStorageMethodOrColourDepth</a>
    /// </summary>
    let hasStorageMethodOrColourDepth = _prefixId.prefix "hasStorageMethodOrColourDepth"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISES^^xsd:string</para>
    ///   <para>rdfs:label : has supportrdfs:label : ha supporto</para>
    ///   <para>rdfs:comment : This property connects an inscription, stamp, emblem etc., represented on a cultural entity to the support on which the entity is located.rdfs:comment : Questa proprietà collega una iscrizione, un timbro, un emblema, etc., rappresentato su un bene culturale al supporto su cui si trova l'elemento.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasSupport">ddesc:hasSupport</a>
    /// </summary>
    let hasSupport = _prefixId.prefix "hasSupport"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha caratteristica tecnicardfs:label : has technical characteristic</para>
    ///   <para>rdfs:comment : This property relates an entity to a technical characteristic (e.g. material, technique, colour, quality level).rdfs:comment : Questa proprietà collega un'entità a una caratteristica tecnica (es.: materia, tecnica, colore, livello di qualità, formato).</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalCharacteristic">ddesc:hasTechnicalCharacteristic</a>
    /// </summary>
    let hasTechnicalCharacteristic = _prefixId.prefix "hasTechnicalCharacteristic"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property connects a cultural entity to its technical status, valid until a specific moment, that is represented by the technical characteristics that a cultural entity has in that moment.rdfs:comment : Questa proprietà collega un'entità culturale al suo stato tecnico, valido fino a determinato momento, che è rappresentato dalle caratteristiche tecniche che il bene culturale ha in quel momento.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: MT/MTC/MTCM; MT/MTC/MTCT - Normativa OA, D, F, S, MI: MT/FRM - Normativa OA, D, F, S: MT/FIL - Normativa VeAC: MT/MTC/MTCC; MT/MTC/MTCF - Normativa F: MT/FVC/FVCC; MT/FVC/FVCF; MT/FVC/FVCP; MT/FVC/FVCU; MT/FVC/FVCM; MT/FVM;^^xsd:string</para>
    ///   <para>rdfs:label : has technical statusrdfs:label : ha stato tecnico</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalStatus">ddesc:hasTechnicalStatus</a>
    /// </summary>
    let hasTechnicalStatus = _prefixId.prefix "hasTechnicalStatus"
    /// <summary>
    ///   <para>rdfs:comment : This property relates an object to its execution technique.rdfs:comment : Questa proprietà collega un oggetto alla tecnica di esecuzione dell'oggetto, per esempio un bene culturale.</para>
    ///   <para>rdfs:label : ha tecnicardfs:label : has technique</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasTechnique">ddesc:hasTechnique</a>
    /// </summary>
    let hasTechnique = _prefixId.prefix "hasTechnique"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha temperamentordfs:label : has temperament</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento al temperamento adottato, soprattutto in caso di oggetto in condizioni originali, o dopo un restauro, dello strumento musicale. Per gli idiofoni a tasti fissi (come xilofoni, litofoni, metallofoni) rappresenta la successione degli intervalli.rdfs:comment : This property relates a musical instrument to the adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasTemperament">ddesc:hasTemperament</a>
    /// </summary>
    let hasTemperament = _prefixId.prefix "hasTemperament"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno strumento all'accordatura dello strumento musicale.rdfs:comment : This property relates a musical instrument to its tuning.</para>
    ///   <para>rdfs:label : ha accordaturardfs:label : has tuning</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasTuning">ddesc:hasTuning</a>
    /// </summary>
    let hasTuning = _prefixId.prefix "hasTuning"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una misura al suo valore.rdfs:comment : This property relates a measurement to its value.</para>
    ///   <para>rdfs:label : ha valorerdfs:label : has value</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasValue">ddesc:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : ha lunghezza vibranterdfs:label : has vibrating lenght</para>
    ///   <para>rdfs:comment : This property relates a musical instrument to its vibrating length, in particular a chordophone.rdfs:comment : Questa proprietà collega un uno strumento alla lunghezza vibrante dello strumento, in particolare di un cordofono.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasVibratingLenght">ddesc:hasVibratingLenght</a>
    /// </summary>
    let hasVibratingLenght = _prefixId.prefix "hasVibratingLenght"

    /// <summary>
    ///   <para>rdfs:label : has volumetric dimensions measurement^^xsd:stringrdfs:label : ha misura di imgombro^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property connects a collection of observed measures on an object to one of these measures, when the latter is relative to an ancient or contemporary apparel's size. The volumetric dimensions measurements determine the size for storage and can be considered as the object's orthogonal coordinates.rdfs:comment : Questa proprietà collega un insieme di misure osservate per un oggetto a una dell misure, quando questa sia relativa all'ingombro di un vestimento antico o contemporaneo. Le misure ingombro determinano l'ingombro per l'immagazzinaggio e si possono quindiconsiderare le coordinate ortogonali dell'oggetto.</para>
    ///   <para>ctlog:iccdNormTag : Normativa VeAC: MT/MII^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement">ddesc:hasVolumetricDimensionsMeasurement</a>
    /// </summary>
    let hasVolumetricDimensionsMeasurement =
        _prefixId.prefix "hasVolumetricDimensionsMeasurement"

    /// <summary>
    ///   <para>rdfs:label : has writing systemrdfs:label : ha sistema di scrittura</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property connects an inscription, stamp, crest etc., to the adopted writing system or alphabet.rdfs:comment : Questa proprietà collega una iscrizione, un timbro, uno stemma, etc., al sistema di scrittura/alfabeto adottati.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEF^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/hasWritingSystem">ddesc:hasWritingSystem</a>
    /// </summary>
    let hasWritingSystem = _prefixId.prefix "hasWritingSystem"

    /// <summary>
    ///   <para>rdfs:label : includes technical characteristicrdfs:label : include caratteristica tecnica</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property connects a technical status, with respect to a specific entity (as a cultural entity) to one of the technical characteristics related to that status.rdfs:comment : Questa proprietà collega lo stato tecnico di un'entità culturale a una delle caratteristiche tecniche dell'entità relativamente a quello stato.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/includesTechnicalCharacteristic">ddesc:includesTechnicalCharacteristic</a>
    /// </summary>
    let includesTechnicalCharacteristic =
        _prefixId.prefix "includesTechnicalCharacteristic"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUC/CUCE; CU/CUP/CUPE^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà collega una modalità comunicativa (prossemica, cinesica) alla fascia d'età delle persone che attuano la comunicazione.rdfs:comment : This property relates a communication medium (proxemics, kinesic) to the age range of the participants to the communication.</para>
    ///   <para>rdfs:label : coinvolge fascia d'etàrdfs:label : involves age range</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/involvesAgeRange">ddesc:involvesAgeRange</a>
    /// </summary>
    let involvesAgeRange = _prefixId.prefix "involvesAgeRange"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is accessory ofrdfs:label : è accessorio di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has accessory".rdfs:comment : Questa è la proprietà inversa di "ha accessorio".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isAccessoryOf">ddesc:isAccessoryOf</a>
    /// </summary>
    let isAccessoryOf = _prefixId.prefix "isAccessoryOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di elemento apposto".rdfs:comment : This is the inverse property of "has affixed element type".</para>
    ///   <para>rdfs:label : is affixed element type ofrdfs:label : è tipo di elemento apposto</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isAffixedElementTypeOf">ddesc:isAffixedElementTypeOf</a>
    /// </summary>
    let isAffixedElementTypeOf = _prefixId.prefix "isAffixedElementTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is age range involved inrdfs:label : è fascia d'età coinvolta in</para>
    ///   <para>rdfs:comment : This is the inverse property of "involves age range".rdfs:comment : Questa è la proprietà inversa di "coinvolge fascia d'età".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isAgeRangeInvolvedIn">ddesc:isAgeRangeInvolvedIn</a>
    /// </summary>
    let isAgeRangeInvolvedIn = _prefixId.prefix "isAgeRangeInvolvedIn"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "refers to agent".rdfs:comment : Questa è la proprietà inversa a "si riferisce ad agente".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is agent referred to byrdfs:label : è agente cui si riferisce</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isAgentReferredToBy">ddesc:isAgentReferredToBy</a>
    /// </summary>
    let isAgentReferredToBy = _prefixId.prefix "isAgentReferredToBy"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega una caratteristica tecnica di un'entità - come un bene culturale - a un concetto tecnico, che la classifica.rdfs:comment : This property connects an entity's techincal characteristic to a technical concept, which classifies that characteristic.</para>
    ///   <para>rdfs:label : è caratteristica tecnica classificata dardfs:label : is technical characteristic classified by</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCharacteristicClassifiedBy">ddesc:isCharacteristicClassifiedBy</a>
    /// </summary>
    let isCharacteristicClassifiedBy = _prefixId.prefix "isCharacteristicClassifiedBy"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è modalità comunicativardfs:label : is communication medium of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has communication medium".rdfs:comment : Questa è la proprietà inversa di "ha modalità comunicativa".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumOf">ddesc:isCommunicationMediumOf</a>
    /// </summary>
    let isCommunicationMediumOf = _prefixId.prefix "isCommunicationMediumOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is communication medium type ofrdfs:label : è tipo di modalità comunicativa</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di modalità comunicativa".rdfs:comment : This is the inverse property of "has communication medium type".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumTypeOf">ddesc:isCommunicationMediumTypeOf</a>
    /// </summary>
    let isCommunicationMediumTypeOf = _prefixId.prefix "isCommunicationMediumTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è stato di conservazione dirdfs:label : is conservation status of</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno stato di conservazione al bene culturale che si trova in quello stato.rdfs:comment : This property relates a conservation status of a cultural property to that cultural property.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusOf">ddesc:isConservationStatusOf</a>
    /// </summary>
    let isConservationStatusOf = _prefixId.prefix "isConservationStatusOf"
    /// <summary>
    ///   <para>rdfs:label : is conservation status type ofrdfs:label : è tipo di stato di conservazione</para>
    ///   <para>rdfs:comment : This is the inverse property of "has conservation status type".rdfs:comment : Questa è la proprietà inversa di "ha tipo di stato di conservazione".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusTypeOf">ddesc:isConservationStatusTypeOf</a>
    /// </summary>
    let isConservationStatusTypeOf = _prefixId.prefix "isConservationStatusTypeOf"

    /// <summary>
    ///   <para>rdfs:label : è accessibilità di bene culturalerdfs:label : is cultural property accessibility of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha accessibilità".rdfs:comment : This is the inverse property of "has cultural property accessibility".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf">ddesc:isCulturalPropertyAccessibilityOf</a>
    /// </summary>
    let isCulturalPropertyAccessibilityOf =
        _prefixId.prefix "isCulturalPropertyAccessibilityOf"

    /// <summary>
    ///   <para>rdfs:label : is cultural property availability ofrdfs:label : è disponibilità  materiale di bene culturale</para>
    ///   <para>rdfs:comment : This is the inverse property of "has cultural property availability".rdfs:comment : Questa è la proprietà inversa di "ha disponibilità materiale".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf">ddesc:isCulturalPropertyAvailabilityOf</a>
    /// </summary>
    let isCulturalPropertyAvailabilityOf =
        _prefixId.prefix "isCulturalPropertyAvailabilityOf"

    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has cultural property definition".rdfs:comment : Questa è la proprietà inversa di "ha definizione di bene culturale".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è definizione di bene culturalerdfs:label : is cultural property definition of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyDefinitionOf">ddesc:isCulturalPropertyDefinitionOf</a>
    /// </summary>
    let isCulturalPropertyDefinitionOf =
        _prefixId.prefix "isCulturalPropertyDefinitionOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has cultural property specification".rdfs:comment : Questa è la proprietà inversa di "ha specifiche del bene culturale".</para>
    ///   <para>rdfs:label : sono specifiche del bene culturalerdfs:label : is cultural property specification</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertySpecificationOf">ddesc:isCulturalPropertySpecificationOf</a>
    /// </summary>
    let isCulturalPropertySpecificationOf =
        _prefixId.prefix "isCulturalPropertySpecificationOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has cultural property type".rdfs:comment : Questa è la proprietà inversa di "ha tipo di bene culturale".</para>
    ///   <para>rdfs:label : è tipo di bene culturalerdfs:label : is cultural property type of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyTypeOf">ddesc:isCulturalPropertyTypeOf</a>
    /// </summary>
    let isCulturalPropertyTypeOf = _prefixId.prefix "isCulturalPropertyTypeOf"
    /// <summary>
    ///   <para>rdfs:label : è dedicatario dirdfs:label : is dedicatee of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has dedicatee".rdfs:comment : Questa è la proprietà inversa a "ha dedicatario".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isDedicateeOf">ddesc:isDedicateeOf</a>
    /// </summary>
    let isDedicateeOf = _prefixId.prefix "isDedicateeOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha designazione nel tempo".rdfs:comment : This is the inverse property of "has designation in time".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is designation in time ofrdfs:label : è denominazione nel tempo di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isDesignationInTimeOf">ddesc:isDesignationInTimeOf</a>
    /// </summary>
    let isDesignationInTimeOf = _prefixId.prefix "isDesignationInTimeOf"
    /// <summary>
    ///   <para>rdfs:label : is designation type ofrdfs:label : è tipo di denominazione</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di denominazione".rdfs:comment : This is the inverse property of "has designation type".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isDesignationTypeOf">ddesc:isDesignationTypeOf</a>
    /// </summary>
    let isDesignationTypeOf = _prefixId.prefix "isDesignationTypeOf"
    /// <summary>
    ///   <para>rdfs:label : è corista dirdfs:label : is diapason of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has diapason".rdfs:comment : Questa è la proprietà inversa di "ha corista".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isDiapasonOf">ddesc:isDiapasonOf</a>
    /// </summary>
    let isDiapasonOf = _prefixId.prefix "isDiapasonOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has affixed element".rdfs:comment : Questa è la proprietà inversa a "ha elemento affisso".</para>
    ///   <para>rdfs:label : è elemento apposto surdfs:label : is element affixed on</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isElementAffixedOn">ddesc:isElementAffixedOn</a>
    /// </summary>
    let isElementAffixedOn = _prefixId.prefix "isElementAffixedOn"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has extension".rdfs:comment : Questa è la proprietà inversa di "ha estensione".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è estensione dirdfs:label : is extension of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isExtensionOf">ddesc:isExtensionOf</a>
    /// </summary>
    let isExtensionOf = _prefixId.prefix "isExtensionOf"
    /// <summary>
    ///   <para>rdfs:label : è formato di estensione/compressione del file dirdfs:label : is file format of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has file format"rdfs:comment : Questa è la proprietà inversa a "ha formato di estensione/compressione del file"</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isFileFormatOf">ddesc:isFileFormatOf</a>
    /// </summary>
    let isFileFormatOf = _prefixId.prefix "isFileFormatOf"
    /// <summary>
    ///   <para>rdfs:label : is filigree ofrdfs:label : è filigrana di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has filigree".rdfs:comment : Questa è la proprietà inversa di "ha filigrana".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isFiligreeOf">ddesc:isFiligreeOf</a>
    /// </summary>
    let isFiligreeOf = _prefixId.prefix "isFiligreeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha tipo di caratteri".rdfs:comment : This is the inverse property of "has font style".</para>
    ///   <para>rdfs:label : è tipo di caratteri dirdfs:label : is font style of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isFontStyleOf">ddesc:isFontStyleOf</a>
    /// </summary>
    let isFontStyleOf = _prefixId.prefix "isFontStyleOf"
    /// <summary>
    ///   <para>rdfs:label : è scopo funzionale dirdfs:label : is functional purpose of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has functional purpose".rdfs:comment : Questa è la proprietà inversa di "ha scopo funzionale".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isFunctionalPurposeOf">ddesc:isFunctionalPurposeOf</a>
    /// </summary>
    let isFunctionalPurposeOf = _prefixId.prefix "isFunctionalPurposeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha analisi del vestimento".rdfs:comment : This is the inverse property of "has garment analysis".</para>
    ///   <para>rdfs:label : è analisi del vestimentordfs:label : is garment analysis of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isGarmentAnalysisOf">ddesc:isGarmentAnalysisOf</a>
    /// </summary>
    let isGarmentAnalysisOf = _prefixId.prefix "isGarmentAnalysisOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has garment colour".rdfs:comment : Questa è la proprietà inversa di "ha colore del vestimento".</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è colore del vestimentordfs:label : is garment colour of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isGarmentColourOf">ddesc:isGarmentColourOf</a>
    /// </summary>
    let isGarmentColourOf = _prefixId.prefix "isGarmentColourOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is iconographic or decorative apparatus ofrdfs:label : è apparato iconografico e decorativo di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has iconographic or decorative apparatus".rdfs:comment : Questa è la proprietà inversa di "ha apparato iconografico e decorativo".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf">ddesc:isIconographicOrDecorativeApparatusOf</a>
    /// </summary>
    let isIconographicOrDecorativeApparatusOf =
        _prefixId.prefix "isIconographicOrDecorativeApparatusOf"

    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di apparato iconografico e decorativo".rdfs:comment : This is the inverse property of "has iconographic or decorative apparatus type".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is iconographic or decorative apparatus type ofrdfs:label : è tipo di apparato iconografico e decorativo</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf">ddesc:isIconographicOrDecorativeApparatusTypeOf</a>
    /// </summary>
    let isIconographicOrDecorativeApparatusTypeOf =
        _prefixId.prefix "isIconographicOrDecorativeApparatusTypeOf"

    /// <summary>
    ///   <para>rdfs:label : is implementation method ofrdfs:label : è modalità esecutiva di</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has implementation method".rdfs:comment : Questa è la proprietà inversa di "ha modalità esecutiva".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isImplementationMethodOf">ddesc:isImplementationMethodOf</a>
    /// </summary>
    let isImplementationMethodOf = _prefixId.prefix "isImplementationMethodOf"
    /// <summary>
    ///   <para>rdfs:label : is included in technical statusrdfs:label : è inclusa in stato tecnico</para>
    ///   <para>rdfs:comment : This property relates a technical characteristic (e.g. marble) to the status of a cultural entity that includes that characteristic.rdfs:comment : Questa proprietà, inversa a "include caratteristica tecnica", collega una caratteristica tecnica specifica (es.: marmo) allo stato di un'entità culturale che ha quella caratteristica.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isIncludedInTechnicalStatus">ddesc:isIncludedInTechnicalStatus</a>
    /// </summary>
    let isIncludedInTechnicalStatus = _prefixId.prefix "isIncludedInTechnicalStatus"
    /// <summary>
    ///   <para>rdfs:label : is legibility ofrdfs:label : è leggibilità di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha leggibilità".rdfs:comment : This is the inverse property of "has legibility".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isLegibilityOf">ddesc:isLegibilityOf</a>
    /// </summary>
    let isLegibilityOf = _prefixId.prefix "isLegibilityOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has location subject".rdfs:comment : Questa è la proprietà inversa di "ha localizzazione rappresentata".</para>
    ///   <para>rdfs:label : is location subject ofrdfs:label : è localizzazione rappresentata da</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isLocationSubjectOf">ddesc:isLocationSubjectOf</a>
    /// </summary>
    let isLocationSubjectOf = _prefixId.prefix "isLocationSubjectOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is mass storage ofrdfs:label : è memoria di massa di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has mass storage".rdfs:comment : Questa è la proprietà inversa di "ha memoria di massa".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMassStorageOf">ddesc:isMassStorageOf</a>
    /// </summary>
    let isMassStorageOf = _prefixId.prefix "isMassStorageOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has material"rdfs:comment : Questa è la proprietà inversa di "ha materia e tecnica"</para>
    ///   <para>rdfs:label : è materia dirdfs:label : is material of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMaterialOf">ddesc:isMaterialOf</a>
    /// </summary>
    let isMaterialOf = _prefixId.prefix "isMaterialOf"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has material or technique"rdfs:comment : Questa è la proprietà inversa di "ha materia e tecnica"</para>
    ///   <para>rdfs:label : è materia e tecnica dirdfs:label : is material or technique of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMaterialOrTechniqueOf">ddesc:isMaterialOrTechniqueOf</a>
    /// </summary>
    let isMaterialOrTechniqueOf = _prefixId.prefix "isMaterialOrTechniqueOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha collezione di misure".rdfs:comment : This is the inverse property of "has measurement collection".</para>
    ///   <para>rdfs:label : è collezione di misure dirdfs:label : is measurement collection of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMeasurementCollectionOf">ddesc:isMeasurementCollectionOf</a>
    /// </summary>
    let isMeasurementCollectionOf = _prefixId.prefix "isMeasurementCollectionOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha misura", collega una misura di un oggetto all'insieme di misure osservate per l'oggetto.rdfs:comment : This property connects an object's measure to the observed measures' collection of that object. It is the inverse property of hasMeasurement.</para>
    ///   <para>ctlog:iccdNormTag : MT/MIS - Normativa VeAC: anche MT/MIM</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è misura in collezionerdfs:label : is measurement in collection</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMeasurementIn">ddesc:isMeasurementIn</a>
    /// </summary>
    let isMeasurementIn = _prefixId.prefix "isMeasurementIn"
    /// <summary>
    ///   <para>rdfs:label : è tipo di misurardfs:label : is measurement type of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha tipo di misura".rdfs:comment : This is the inverse property of "has measurement type".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isMeasurementTypeOf">ddesc:isMeasurementTypeOf</a>
    /// </summary>
    let isMeasurementTypeOf = _prefixId.prefix "isMeasurementTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has orientation".rdfs:comment : Questa è la proprietà inversa di "ha orientamento".</para>
    ///   <para>rdfs:label : is orientation ofrdfs:label : è orientamento di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isOrientationOf">ddesc:isOrientationOf</a>
    /// </summary>
    let isOrientationOf = _prefixId.prefix "isOrientationOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is ornamental motif ofrdfs:label : è motivo decorativo di</para>
    ///   <para>rdfs:comment : This is the inverse property of "has ornamental motif".rdfs:comment : Questa è la proprietà inversa di "ha motivo decorativo".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isOrnamentalMotifOf">ddesc:isOrnamentalMotifOf</a>
    /// </summary>
    let isOrnamentalMotifOf = _prefixId.prefix "isOrnamentalMotifOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha colore della foto"rdfs:comment : This is the inverse property of "has photo colour"</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è colore della fotordfs:label : is photo colour of</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isPhotoColourOf">ddesc:isPhotoColourOf</a>
    /// </summary>
    let isPhotoColourOf = _prefixId.prefix "isPhotoColourOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è programma per foto dirdfs:label : is photo program of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has photo program".rdfs:comment : Questa è la proprietà inversa di "ha programma per foto".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isPhotoProgramOf">ddesc:isPhotoProgramOf</a>
    /// </summary>
    let isPhotoProgramOf = _prefixId.prefix "isPhotoProgramOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è dimensione della fotordfs:label : is photo size of</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha dimensioni della foto"rdfs:comment : This is the inverse property of "has photo size"</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isPhotoSizeOf">ddesc:isPhotoSizeOf</a>
    /// </summary>
    let isPhotoSizeOf = _prefixId.prefix "isPhotoSizeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha dimensioni in pixel"rdfs:comment : This is the inverse property of "has pixel dimension"</para>
    ///   <para>rdfs:label : is pixel dimension ofrdfs:label : è dimensione in pixel di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isPixelDimensionOf">ddesc:isPixelDimensionOf</a>
    /// </summary>
    let isPixelDimensionOf = _prefixId.prefix "isPixelDimensionOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha livello di qualità"rdfs:comment : This is the inverse property of "has quality level"</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is quality level ofrdfs:label : è livello di qualità di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isQualityLevelOf">ddesc:isQualityLevelOf</a>
    /// </summary>
    let isQualityLevelOf = _prefixId.prefix "isQualityLevelOf"
    /// <summary>
    ///   <para>rdfs:label : è risoluzione dirdfs:label : is resolution of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa a "ha risoluzione"rdfs:comment : This is the inverse property of "has resolution"</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isResolutionOf">ddesc:isResolutionOf</a>
    /// </summary>
    let isResolutionOf = _prefixId.prefix "isResolutionOf"
    /// <summary>
    ///   <para>rdfs:label : is sample collected fromrdfs:label : è campione prelevato da</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has sample collected".rdfs:comment : Questa è la proprietà inversa di "ha campione prelevato".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedFrom">ddesc:isSampleCollectedFrom</a>
    /// </summary>
    let isSampleCollectedFrom = _prefixId.prefix "isSampleCollectedFrom"
    /// <summary>
    ///   <para>rdfs:label : è tipo di campione prelevatordfs:label : is sample collected type of</para>
    ///   <para>rdfs:comment : This is the inverse property of "has sample collected type".rdfs:comment : Questa è la proprietà inversa di "ha tipo di campione prelevato".</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedTypeOf">ddesc:isSampleCollectedTypeOf</a>
    /// </summary>
    let isSampleCollectedTypeOf = _prefixId.prefix "isSampleCollectedTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has shape"rdfs:comment : Questa è la proprietà inversa di "ha forma"</para>
    ///   <para>rdfs:label : is shape ofrdfs:label : è forma di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isShapeOf">ddesc:isShapeOf</a>
    /// </summary>
    let isShapeOf = _prefixId.prefix "isShapeOf"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is storage method or colour depth ofrdfs:label : è metodo di memorizzazione e profondità del colore di</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha metodo di memorizzazione e profondità del colore".rdfs:comment : This is the inverse property of "has storage method or colour depth".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isStorageMethodOrColourDepthOf">ddesc:isStorageMethodOrColourDepthOf</a>
    /// </summary>
    let isStorageMethodOrColourDepthOf =
        _prefixId.prefix "isStorageMethodOrColourDepthOf"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISES^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects a support (e.g. "paper label") to an element (stamp, embelem, inscription, mark) which has been represented on it. It is the inverse property of hasSupport.rdfs:comment : Questa proprietà, inversa di "ha supporto", collega un supporto (es.: "etichetta di carta") all'elemento (timbro, emblema, iscrizione, marchio) che vi viene rappresentato.</para>
    ///   <para>rdfs:label : is support ofrdfs:label : è supporto di</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isSupportOf">ddesc:isSupportOf</a>
    /// </summary>
    let isSupportOf = _prefixId.prefix "isSupportOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è caratteristica tecnica dirdfs:label : is technical characteristic of</para>
    ///   <para>rdfs:comment : This property relates a technical characteristic to an entity.rdfs:comment : Questa proprietà collega una caratteristica tecnica all'entità che ha quella caratteristica.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechnicalCharacteristicOf">ddesc:isTechnicalCharacteristicOf</a>
    /// </summary>
    let isTechnicalCharacteristicOf = _prefixId.prefix "isTechnicalCharacteristicOf"
    /// <summary>
    ///   <para>rdfs:label : is technical concept used inrdfs:label : è concetto tecnico usato in</para>
    ///   <para>rdfs:comment : This property relates a technical concept (e.g. material) used in the technical description of a cultural property.rdfs:comment : Questa proprietà collega un concetto tecnico (es.: materia) usato nella descrizione tecnica di un bene culturale.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechnicalConceptUsedIn">ddesc:isTechnicalConceptUsedIn</a>
    /// </summary>
    let isTechnicalConceptUsedIn = _prefixId.prefix "isTechnicalConceptUsedIn"

    /// <summary>
    ///   <para>rdfs:comment : This property relates a technical description of a cultural entity to a situation that satisfies that description.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è descrizione di entità culturale soddisfatta dardfs:label : is cultural entity description satisfied by</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy">ddesc:isTechnicalDescriptionSatisfiedBy</a>
    /// </summary>
    let isTechnicalDescriptionSatisfiedBy =
        _prefixId.prefix "isTechnicalDescriptionSatisfiedBy"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : is technical status ofrdfs:label : è stato tecnico di</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno stato tecnico di un'entità culturale a un'entità culturale. Lo stato è valido fino a determinato momento ed è rappresentato dalle caratteristiche tecniche che il bene culturale ha in quel momento.rdfs:comment : This property connects a technical status to a cultural entity. This status is valid until a specific moment and is represented by the technical characteristics that a cultural entity has in that moment.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusOf">ddesc:isTechnicalStatusOf</a>
    /// </summary>
    let isTechnicalStatusOf = _prefixId.prefix "isTechnicalStatusOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà collega uno stato tecnico di un'entità culturale all'intervallo temporale entro il quale è valido, relativamente al momento in cui quelle caratteristiche sono state rilevate.rdfs:comment : This property relates a cultural entity technical status to the time interval until which that status is valid, with regard to the moment in which the characteristics are observed.</para>
    ///   <para>rdfs:label : è stato tecnico di entità culturale valido fino ardfs:label : is cultural entity technical status valid at</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusValidAt">ddesc:isTechnicalStatusValidAt</a>
    /// </summary>
    let isTechnicalStatusValidAt = _prefixId.prefix "isTechnicalStatusValidAt"
    /// <summary>
    ///   <para>rdfs:comment : This is the inverse property of "has technique"rdfs:comment : Questa è la proprietà inversa di "ha materia e tecnica"</para>
    ///   <para>rdfs:label : è tecnica dirdfs:label : is technique of</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTechniqueOf">ddesc:isTechniqueOf</a>
    /// </summary>
    let isTechniqueOf = _prefixId.prefix "isTechniqueOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has temperament".rdfs:comment : Questa è la proprietà inversa di "ha temperamento".</para>
    ///   <para>rdfs:label : is temperament ofrdfs:label : è temperamento di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTemperamentOf">ddesc:isTemperamentOf</a>
    /// </summary>
    let isTemperamentOf = _prefixId.prefix "isTemperamentOf"
    /// <summary>
    ///   <para>rdfs:label : is time interval valid forrdfs:label : è intervallo di tempo valido per</para>
    ///   <para>rdfs:comment : Questa proprietà collega un intervallo temporale entro il quale è valido uno stato tecnico di un'entità culturale allo stato tecnico stesso, relativamente al momento in cui quelle caratteristiche sono state rilevate.rdfs:comment : This property relates the time interval, at which a cultural entity technical status is valid, to that technical status, with regard to the moment in which the characteristics are observed.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTimeIntervalValidFor">ddesc:isTimeIntervalValidFor</a>
    /// </summary>
    let isTimeIntervalValidFor = _prefixId.prefix "isTimeIntervalValidFor"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This is the inverse property of "has tuning".rdfs:comment : Questa è la proprietà inversa di "ha accordatura".</para>
    ///   <para>rdfs:label : is tuning ofrdfs:label : è accordatura di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isTuningOf">ddesc:isTuningOf</a>
    /// </summary>
    let isTuningOf = _prefixId.prefix "isTuningOf"
    /// <summary>
    ///   <para>rdfs:label : è valore dirdfs:label : is value of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha valore".rdfs:comment : This is the inverse property of "has value".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isValueOf">ddesc:isValueOf</a>
    /// </summary>
    let isValueOf = _prefixId.prefix "isValueOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è lunghezza vibrante dirdfs:label : is vibrating lenght of</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha lunghezza vibrante".rdfs:comment : This is the inverse property of "has vibrating lenght".</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isVibratingLenghtOf">ddesc:isVibratingLenghtOf</a>
    /// </summary>
    let isVibratingLenghtOf = _prefixId.prefix "isVibratingLenghtOf"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This is the inverse property of "has volumetric dimensions measurement".rdfs:comment : Questa è la proprietà inversa di "ha misura di ingombro".</para>
    ///   <para>rdfs:label : è misura di ingombro dirdfs:label : is volumetric dimensions measurement in</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn">ddesc:isVolumetricDimensionsMeasurementIn</a>
    /// </summary>
    let isVolumetricDimensionsMeasurementIn =
        _prefixId.prefix "isVolumetricDimensionsMeasurementIn"

    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa è la proprietà inversa di "ha sistema di scrittura".rdfs:comment : This is the inverse property of "has writing system".</para>
    ///   <para>rdfs:label : is writing system ofrdfs:label : è sistema di scrittura di</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/isWritingSystemOf">ddesc:isWritingSystemOf</a>
    /// </summary>
    let isWritingSystemOf = _prefixId.prefix "isWritingSystemOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEB^^xsd:string</para>
    ///   <para>rdfs:label : italian translationrdfs:label : traduzione italiana</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la traduzione italiana della trascrizione di un testo contenuto in un'iscrizione, un'emblema, etc.rdfs:comment : This property represents the italian translation of a text transcription contained in an inscription, emblem etc.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/italianTranslation">ddesc:italianTranslation</a>
    /// </summary>
    let italianTranslation = _prefixId.prefix "italianTranslation"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUV/CUVI; CU/CUM/CUMI^^xsd:string</para>
    ///   <para>rdfs:label : numero di partecipanti infantilirdfs:label : number of child participants</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero dei bambini che attuano una comunicazione (verbale, musicale vocale).rdfs:comment : This property represents the number of the child participants to a communication (verbal, singing, kinesic).</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/numberOfChildParticipants">ddesc:numberOfChildParticipants</a>
    /// </summary>
    let numberOfChildParticipants = _prefixId.prefix "numberOfChildParticipants"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero delle persone di sesso femminile che attuano una comunicazione (verbale, musicale vocale, cinesica).rdfs:comment : This property represents the number of the male participants to a communication (verbal, singing, kinesic).</para>
    ///   <para>rdfs:label : numero di partecipanti femminilirdfs:label : number of female participants</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUV/CUVF; CU/CUM/CUMF; CU/CUC/CUCF^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/numberOfFemaleParticipants">ddesc:numberOfFemaleParticipants</a>
    /// </summary>
    let numberOfFemaleParticipants = _prefixId.prefix "numberOfFemaleParticipants"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero delle persone di sesso maschile che attuano una comunicazione (verbale, musicale vocale, cinesica)rdfs:comment : This property represents the number of the male participants to a communication (verbal, singing, kinesic).</para>
    ///   <para>rdfs:label : numero di partecipanti maschilirdfs:label : number of male participants</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa BDI: CU/CUV/CUVM; CU/CUM/CUMM; CU/CUC/CUCM^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/numberOfMaleParticipants">ddesc:numberOfMaleParticipants</a>
    /// </summary>
    let numberOfMaleParticipants = _prefixId.prefix "numberOfMaleParticipants"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta le occorrenze di un emblema, marchio, iscrizione, etc., su uno stesso bene culturale, cioè quante volte l'elemento descritto compare sul bene.rdfs:comment : This property represents the occurrences of an affixed element on a cultular entity, that is how many times the outlined element appears on the cultual entity.</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEQ - Normative di versioni precedenti: DA/STM/STMU</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : occurrencesrdfs:label : occorrenze</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/occurrences">ddesc:occurrences</a>
    /// </summary>
    let occurrences = _prefixId.prefix "occurrences"

    /// <summary>
    ///   <para>rdfs:label : posizione rispetto al bene culturale complessordfs:label : position in complex cultural property</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normative OA e RA: OG/OGT/OGTP</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la posizione di un bene rispetto al bene complesso di cui è parte componente.rdfs:comment : This property represents a cultural entity's position with respect to a complex entity to which it belongs.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/positionInComplexCulturalProperty">ddesc:positionInComplexCulturalProperty</a>
    /// </summary>
    let positionInComplexCulturalProperty =
        _prefixId.prefix "positionInComplexCulturalProperty"

    /// <summary>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEP - Normative di versioni precedenti: DA/STM/STMP; DA/ISR/ISRP - Normativa A: LI/LSI/LSIU - Normativa PST: OG/SGT/SGTP - ICCD Normative MA, CA, SI, SAS: MC/CMN/CMNP</para>
    ///   <para>rdfs:label : position on cultural propertyrdfs:label : posizione su bene culturale</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la posizione di un oggetto (es.: elementi come stemmi, emblemi, timbri, etc., oppure i soggetti rappresentati) rispetto all'intero bene o a una sua specifica parte.rdfs:comment : This property represents a cultural entity's postion (e.g. elements like crests, emblems, stamps or the depicted subjects), with respect to the whole entity or to its specific part.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/positionOnCulturalProperty">ddesc:positionOnCulturalProperty</a>
    /// </summary>
    let positionOnCulturalProperty = _prefixId.prefix "positionOnCulturalProperty"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : proposte di interventirdfs:label : proposed intervention</para>
    ///   <para>ctlog:iccdNormTag : CO/STP^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta eventuali proposte per interventi conservativi, dopo aver valutato le condizioni del bene al momento della sua catalogazione.rdfs:comment : This property represents potential proposals for conservative interventions after evaluating the cultual entity's conditions at time of its cataloguing.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/proposedIntervention">ddesc:proposedIntervention</a>
    /// </summary>
    let proposedIntervention = _prefixId.prefix "proposedIntervention"
    /// <summary>
    ///   <para>rdfs:label : refers to agentrdfs:label : si riferisce ad agente</para>
    ///   <para>rdfs:comment : This property connects a crest, emblem, postmark etc., located on a cultural entity to the agent (e.g. family, factory, cave, silversmith) to which it refers.rdfs:comment : Questa proprietà collega un uno stemma, un emblema, un timbro, etc., presente su un bene culturale, all'agente (la famiglia, la fabbrica, la cava, l'argentiere, etc.) a cui si riferisce l'elemento.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISES - Normative di versioni precedenti: DA/STM/STMI</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/refersToAgent">ddesc:refersToAgent</a>
    /// </summary>
    let refersToAgent = _prefixId.prefix "refersToAgent"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta il numero che identifica il campione.rdfs:comment : This property represents the seample collected identifier.</para>
    ///   <para>rdfs:label : identificativo del campione prelevatordfs:label : sample collected identifier</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa MA, CA, SI, SAS: MC/CMN^^xsd:string</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/sampleCollectedIdentifier">ddesc:sampleCollectedIdentifier</a>
    /// </summary>
    let sampleCollectedIdentifier = _prefixId.prefix "sampleCollectedIdentifier"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : satisfies technical descriptionrdfs:label : soddisfa descrizione tecnica</para>
    ///   <para>rdfs:comment : This property relates a technical status (intended as a situaiton) of a cultural entity to the technical description satisfied by that situation.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/satisfiesTechnicalDescription">ddesc:satisfiesTechnicalDescription</a>
    /// </summary>
    let satisfiesTechnicalDescription = _prefixId.prefix "satisfiesTechnicalDescription"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà rappresenta informazioni sulle condizioni ambientali e microclimatiche in cui si trova il bene al momento della catalogazione ed eventuali indicazioni per una sua corretta conservazione.rdfs:comment : This property represents informations about the storage conditions of a cultural property.</para>
    ///   <para>ctlog:iccdNormTag : CO/STD^^xsd:string</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : storage conditionsrdfs:label : modalità di conservazione</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/storageConditions">ddesc:storageConditions</a>
    /// </summary>
    let storageConditions = _prefixId.prefix "storageConditions"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : trascrizionerdfs:label : transcript</para>
    ///   <para>ctlog:iccdNormTag : ICCD Normativa Trasversale 4.00: DA/ISE/ISEI - Normative di versioni precedenti: DA/ISR/ISRI</para>
    ///   <para>rdfs:comment : This property connects an inscription, emblem etc., to the text's transcription, using scientifically accepted integrations.rdfs:comment : Questa proprietà collega un'iscrizione, un emblema, etc., alla trascrizione del testo, utilizzando scioglimenti e integrazioni scientificamente accettati.</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/transcript">ddesc:transcript</a>
    /// </summary>
    let transcript = _prefixId.prefix "transcript"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega una descrizione tecnica di un bene culturale a uno dei concetti usati in quella descrizione.rdfs:comment : This property relates a technical description of a cultural property to one of the concepts used in that description.</para>
    ///   <para>rdfs:label : usa concetto tecnicordfs:label : uses technical concept</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/usesTechnicalConcept">ddesc:usesTechnicalConcept</a>
    /// </summary>
    let usesTechnicalConcept = _prefixId.prefix "usesTechnicalConcept"
    /// <summary>
    ///   <para>rdfs:label : validitàrdfs:label : validity</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta la validità, intesa come livello di accuratezza, di una misura osservata per un oggetto.rdfs:comment : This property represents the validity, intended as accurancy level, of an observed measure for an object.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/denotative-description/validity">ddesc:validity</a>
    /// </summary>
    let validity = _prefixId.prefix "validity"

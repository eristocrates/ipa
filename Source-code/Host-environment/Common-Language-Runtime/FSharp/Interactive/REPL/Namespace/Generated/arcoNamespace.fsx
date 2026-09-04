#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module arco =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/core/" "arco"

    /// <summary>
    ///   <para>rdfs:comment : Questa classe rappresenta una situazione relativa a un agente che ricopre un ruolo, senza la specificazione della dimensione tempo.rdfs:comment : This class represents a situation in which an agent holds a role, regardless of the timing.</para>
    ///   <para>rdfs:label : Agent Rolerdfs:label : Ruolo ricoperto da agente</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/AgentRole">arco:AgentRole</a>
    /// </summary>
    let AgentRole = _prefixId.prefix "AgentRole"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Categoryrdfs:label : Categoria</para>
    ///   <para>rdfs:comment : The class representing a category.rdfs:comment : La classe che rappresenta una categoria.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Category">arco:Category</a>
    /// </summary>
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:comment : La classe che rappresenta il concetto di classificazione.rdfs:comment : The class that models the concept of classification.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Classificationrdfs:label : Classificazione</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Classification">arco:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:comment : The class representing a concept.rdfs:comment : La classe che rappresenta un concetto.</para>
    ///   <para>rdfs:label : Concettordfs:label : Concept</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Concept">arco:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Cultural Entity Characteristicrdfs:label : Caratteristica di Entità Culturale</para>
    ///   <para>rdfs:comment : The class representing the characteristic of a cultural entity (e.g. a cultural property).rdfs:comment : La classe che rappresenta una caratteristica di un'entità di carattere culturale come ad esempio un bene culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/CulturalEntityCharacteristic">arco:CulturalEntityCharacteristic</a>
    /// </summary>
    let CulturalEntityCharacteristic = _prefixId.prefix "CulturalEntityCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : Cultural entity classificationrdfs:label : Classificazione relativa a bene culturale</para>
    ///   <para>rdfs:comment : The class that models the concept of cultural entity classification.rdfs:comment : La classe che rappresenta il concetto di classificazione di un'entità culturale.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/CulturalEntityClassification">arco:CulturalEntityClassification</a>
    /// </summary>
    let CulturalEntityClassification = _prefixId.prefix "CulturalEntityClassification"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Metodordfs:label : Method</para>
    ///   <para>rdfs:comment : The class representing the concept of method.rdfs:comment : Classe che rappresenta il concetto di metodo.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Method">arco:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Situazionerdfs:label : Situation</para>
    ///   <para>rdfs:comment : La classe che rappresenta il generico concetto di situazione.rdfs:comment : The class representing the generic concept of situation.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Situation">arco:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : Situazione nel tempordfs:label : Time indexed situation</para>
    ///   <para>rdfs:comment : The class representing the generic concept of time indexed situation.rdfs:comment : La classe che rappresenta il generico concetto di situazione indicizzata nel tempo.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/TimeIndexedSituation">arco:TimeIndexedSituation</a>
    /// </summary>
    let TimeIndexedSituation = _prefixId.prefix "TimeIndexedSituation"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : Typerdfs:label : Tipo</para>
    ///   <para>rdfs:comment : The class representing the concept of type.rdfs:comment : Classe che rappresenta il concetto di tipo.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/Type">arco:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : descriptionrdfs:label : descrizione</para>
    ///   <para>rdfs:comment : This property relates a description associated to an entity, in order to add details and some more information.rdfs:comment : Questa proprietà rappresenta una descrizione associata a una certa entità, che viene arricchita con ulteriori dettagli che la descrivono.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/description">arco:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a situation in which an agent holds a role to that agent.rdfs:comment : Questa proprietà collega una situazione in cui un ruolo viene ricoperto da un agente all'agente che lo ricopre.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : has agentrdfs:label : ha agente</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasAgent">arco:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : ha ruolo ricoperto da agenterdfs:label : has agent role</para>
    ///   <para>rdfs:comment : Questa proprietà collega un'entità a una situazione in cui un agente ricopre un ruolo.rdfs:comment : This property relates an entity to a situation in which an agent holds a role connected to that entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasAgentRole">arco:hasAgentRole</a>
    /// </summary>
    let hasAgentRole = _prefixId.prefix "hasAgentRole"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : The object property that associates any object with a category.rdfs:comment : La object property che associa un qualunque oggetto a una categoria.</para>
    ///   <para>rdfs:label : ha categoriardfs:label : has category</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasCategory">arco:hasCategory</a>
    /// </summary>
    let hasCategory = _prefixId.prefix "hasCategory"
    /// <summary>
    ///   <para>rdfs:label : ha caratteristicardfs:label : has characteristic</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : The object property that links an entity to one of its characteristics.rdfs:comment : La object property che collega un'entità a una sua caratteristica.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasCharacteristic">arco:hasCharacteristic</a>
    /// </summary>
    let hasCharacteristic = _prefixId.prefix "hasCharacteristic"
    /// <summary>
    ///   <para>rdfs:label : ha classificazionerdfs:label : has classification</para>
    ///   <para>rdfs:comment : The object property that allows to add a classification to any object.rdfs:comment : La object property che permette di aggiungere una classificazione a un qualsiasi oggetto.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasClassification">arco:hasClassification</a>
    /// </summary>
    let hasClassification = _prefixId.prefix "hasClassification"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates, non-transitively, an entity to a component.rdfs:comment : Questa proprietà collega, in maniera non-transitiva, un'entità a un suo componente.</para>
    ///   <para>rdfs:label : ha componenterdfs:label : has component</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasComponent">arco:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : The object property that associates any object with a concept, classifying it.rdfs:comment : La object property che associa un qualunque oggetto a un concetto, che lo classifica.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has conceptrdfs:label : ha concetto</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasConcept">arco:hasConcept</a>
    /// </summary>
    let hasConcept = _prefixId.prefix "hasConcept"

    /// <summary>
    ///   <para>rdfs:label : ha caratteristica di entità culturalerdfs:label : has cultural entity characteristic</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : La object property che collega una cultural entity a una sua caratteristica.rdfs:comment : The object property that links a cultural entity to one of its characteristics.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasCulturalEntityCharacteristic">arco:hasCulturalEntityCharacteristic</a>
    /// </summary>
    let hasCulturalEntityCharacteristic =
        _prefixId.prefix "hasCulturalEntityCharacteristic"

    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : ha luogordfs:label : has location</para>
    ///   <para>rdfs:comment : La object property che collega un'entità a un luogo in cui si trova.rdfs:comment : The object property that associates an entity to a location.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasLocation">arco:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : ha metodordfs:label : has method</para>
    ///   <para>rdfs:comment : L'object property che collega un'entità a un metodo.rdfs:comment : The object property that links an entity to a method.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasMethod">arco:hasMethod</a>
    /// </summary>
    let hasMethod = _prefixId.prefix "hasMethod"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : This property relates an entity to its part.rdfs:comment : Questa proprietà collega un'entità a una sua parte.</para>
    ///   <para>rdfs:label : has partrdfs:label : ha parte</para>
    ///   <para>arco:iccdNormTag : "Riferimento alla parte", presente in molti campi strutturati delle normative ICCD</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasPart">arco:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : This property relates a situation in which an agent holds a role to that role.rdfs:comment : Questa proprietà collega una situazione in cui un ruolo viene ricoperto da un agente al ruolo stesso.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has rolerdfs:label : ha ruolo</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasRole">arco:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:comment : La proprietà che collega un qualsiasi oggetto a una situazione.rdfs:comment : The property that links any object to a situation.</para>
    ///   <para>rdfs:label : ha situazionerdfs:label : has situation</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasSituation">arco:hasSituation</a>
    /// </summary>
    let hasSituation = _prefixId.prefix "hasSituation"
    /// <summary>
    ///   <para>rdfs:comment : La proprietà che collega un qualsiasi oggetto a una situazione indicizzata nel tempo.rdfs:comment : The property that links any object to a time indexed situation.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : has time indexed situationrdfs:label : ha situazione nel tempo</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasTimeIndexedSituation">arco:hasTimeIndexedSituation</a>
    /// </summary>
    let hasTimeIndexedSituation = _prefixId.prefix "hasTimeIndexedSituation"
    /// <summary>
    ///   <para>rdfs:label : ha tipordfs:label : has type</para>
    ///   <para>rdfs:comment : The object property that associates any object with a type.rdfs:comment : La object property che associa un qualunque oggetto a un tipo.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/core/hasType">arco:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    let iccdNormTag = _prefixId.prefix "iccdNormTag"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà, inversa a "ha agente", collega un agente alla situazione in cui l'agente ha ricoperto un ruolo.rdfs:comment : This property relates an agent to a situation in which that agent holds a role.</para>
    ///   <para>rdfs:label : is agent ofrdfs:label : è agente in</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isAgentOf">arco:isAgentOf</a>
    /// </summary>
    let isAgentOf = _prefixId.prefix "isAgentOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà collega una situazione in cui un agente ricopre un ruolo relativo a un'entità all'entità.rdfs:comment : This property relates a situation in which an agent holds a role connected to an entity to that entity.</para>
    ///   <para>rdfs:label : is agent role ofrdfs:label : è ruolo ricoperto da agente di</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isAgentRoleOf">arco:isAgentRoleOf</a>
    /// </summary>
    let isAgentRoleOf = _prefixId.prefix "isAgentRoleOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : La object property che associa una categoria a un qualunque oggetto.rdfs:comment : The object property that associates a category to any object.</para>
    ///   <para>rdfs:label : è categoria dirdfs:label : is category of</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isCategoryOf">arco:isCategoryOf</a>
    /// </summary>
    let isCategoryOf = _prefixId.prefix "isCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : is characteristic ofrdfs:label : è caratteristica di</para>
    ///   <para>rdfs:comment : The object property that links an entity characteristic to the entity.rdfs:comment : La object property che collega una caratteristica di un'entità all'entità stessa.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isCharacteristicOf">arco:isCharacteristicOf</a>
    /// </summary>
    let isCharacteristicOf = _prefixId.prefix "isCharacteristicOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:comment : The inverse object property of hasClassification, that links an object to a classification.rdfs:comment : La proprietà inversa di hasClassification, che collega un oggetto a una sua classificazione.</para>
    ///   <para>rdfs:label : is classification ofrdfs:label : è classificazione di</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isClassificationOf">arco:isClassificationOf</a>
    /// </summary>
    let isClassificationOf = _prefixId.prefix "isClassificationOf"
    /// <summary>
    ///   <para>rdfs:comment : Questa proprietà collega, in maniera non-transitiva, un componente a un'entità di cui è componente.rdfs:comment : This property relates, non-transitively, a component to an entity of which it is component.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è componente dirdfs:label : is component of</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isComponentOf">arco:isComponentOf</a>
    /// </summary>
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : La proprietà inversa di hasConcept, che collega un concetto a un qualunque oggetto.rdfs:comment : The inverse property of hasConcept, that relates a concept to any object.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : is concept ofrdfs:label : è concetto di</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isConceptOf">arco:isConceptOf</a>
    /// </summary>
    let isConceptOf = _prefixId.prefix "isConceptOf"

    /// <summary>
    ///   <para>rdfs:comment : The object property that links a cultural entity characteristic to the cultural entity.rdfs:comment : La object property che collega una caratteristica di una cultural entity alla cultural entity.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : è caratteristica di entità culturale dirdfs:label : is cultural entity characteristic of</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isCulturalEntityCharacteristicOf">arco:isCulturalEntityCharacteristicOf</a>
    /// </summary>
    let isCulturalEntityCharacteristicOf =
        _prefixId.prefix "isCulturalEntityCharacteristicOf"

    /// <summary>
    ///   <para>rdfs:comment : The object property that associates a location to an entity located there.rdfs:comment : La object property che collega un luogo a un'entità che si trova in quel luogo.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è luogo dirdfs:label : is location of</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isLocationOf">arco:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : The object property that links a method to an entity.rdfs:comment : L'object property che collega un metodo a un'entità.</para>
    ///   <para>rdfs:label : è metodo dirdfs:label : is method of</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isMethodOf">arco:isMethodOf</a>
    /// </summary>
    let isMethodOf = _prefixId.prefix "isMethodOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : This property relates the part of an entity to that entity.rdfs:comment : Questa proprietà collega una parte di un'entità all'entità.</para>
    ///   <para>rdfs:label : is part ofrdfs:label : è parte di</para>
    ///   <para>arco:iccdNormTag : "Riferimento alla parte", presente in molti campi strutturati delle normative ICCD</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isPartOf">arco:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : is role ofrdfs:label : è ruolo in</para>
    ///   <para>rdfs:comment : Questa proprietà collega un ruolo a una situazione in cui il ruolo viene ricoperto da un agente.rdfs:comment : This property relates a role to a situation in which an agent holds that role.</para>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isRoleOf">arco:isRoleOf</a>
    /// </summary>
    let isRoleOf = _prefixId.prefix "isRoleOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : La proprietà che collega una situazione ad un qualsiasi oggetto. La proprietà è modellata come proprietà inversa di hasSituation.rdfs:comment : The property that links a situation to any object. The property is modelled as inverse object property of hasSituation.</para>
    ///   <para>rdfs:label : is situation ofrdfs:label : è situazione di</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isSituationOf">arco:isSituationOf</a>
    /// </summary>
    let isSituationOf = _prefixId.prefix "isSituationOf"
    /// <summary>
    ///   <para>rdfs:comment : La proprietà che collega una situazione indicizzata nel tempo ad un qualsiasi oggetto. La proprietà è modellata come proprietà inversa di hasTimeIndexedSituation.rdfs:comment : The property that links a time indexed situation to any object. The property is modelled as inverse object property of hasTimeIndexedSituation.</para>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:label : è situazione nel tempo dirdfs:label : is time indexed situation of</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isTimeIndexedSituationOf">arco:isTimeIndexedSituationOf</a>
    /// </summary>
    let isTimeIndexedSituationOf = _prefixId.prefix "isTimeIndexedSituationOf"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : The object property that associates a type to any object.rdfs:comment : La object property che associa un tipo a un qualunque oggetto.</para>
    ///   <para>rdfs:label : is type ofrdfs:label : è tipo di</para>
    ///   <a href="https://w3id.org/arco/ontology/core/isTypeOf">arco:isTypeOf</a>
    /// </summary>
    let isTypeOf = _prefixId.prefix "isTypeOf"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : keywordrdfs:label : parola chiave</para>
    ///   <para>arco:iccdNormTag : ICCD Normativa PST: CT/CTC^^xsd:string</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta una parola chiave relativa a un'entità, che può essere utilizzata per la ricerca dell'entità.rdfs:comment : This property represents a keyword related to an entity, used to search for that entity.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/keyword">arco:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>owl:versionInfo : stableowl:versionInfo : stabile</para>
    ///   <para>rdfs:comment : Questa proprietà rappresenta eventuali note, relative a una certa informazione.rdfs:comment : This property represents notes associated to a piece of information.</para>
    ///   <para>rdfs:label : noterdfs:label : note</para>
    ///   <a href="https://w3id.org/arco/ontology/core/note">arco:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>owl:versionInfo : stabileowl:versionInfo : stable</para>
    ///   <para>rdfs:label : specificationsrdfs:label : specifiche</para>
    ///   <para>rdfs:comment : This property represents specifications associated to a piece of information.rdfs:comment : Questa proprietà rappresenta eventuali specifiche, relative a una certa informazione.</para>
    ///   <a href="https://w3id.org/arco/ontology/core/specifications">arco:specifications</a>
    /// </summary>
    let specifications = _prefixId.prefix "specifications"

namespace https.w3id.org.arco.ontology.core.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module arco =
    let _namespace_iri = Namespace_Iri arco |> NamespaceIRI
    /// <summary>
    ///   <para>arco:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe che rappresenta il generico concetto di situazione.</para>
    ///   <para>The class representing the generic concept of situation.</para>
    /// labels<para>Situazione</para><para>Situation</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Situation">https://w3id.org/arco/ontology/core/Situation</seealso>
    let Situation = Prefixed_Name(arco, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà che collega un qualsiasi oggetto a una situazione.</para>
    ///   <para>The property that links any object to a situation.</para>
    /// labels<para>has situation</para><para>ha situazione</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasSituation">https://w3id.org/arco/ontology/core/hasSituation</seealso>
    let hasSituation = Prefixed_Name(arco, "hasSituation") |> PrefixedName
    /// <summary>
    ///   <para>arco:isAgentRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a situation in which an agent holds a role connected to an entity to that entity.</para>
    ///   <para>Questa proprietà collega una situazione in cui un agente ricopre un ruolo relativo a un'entità all'entità.</para>
    /// labels<para>è ruolo ricoperto da agente di</para><para>is agent role of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isAgentRoleOf">https://w3id.org/arco/ontology/core/isAgentRoleOf</seealso>
    let isAgentRoleOf = Prefixed_Name(arco, "isAgentRoleOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates, non-transitively, an entity to a component.</para>
    ///   <para>Questa proprietà collega, in maniera non-transitiva, un'entità a un suo componente.</para>
    /// labels<para>ha componente</para><para>has component</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasComponent">https://w3id.org/arco/ontology/core/hasComponent</seealso>
    let hasComponent = Prefixed_Name(arco, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>arco:specifications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property represents specifications associated to a piece of information.</para>
    ///   <para>Questa proprietà rappresenta eventuali specifiche, relative a una certa informazione.</para>
    /// labels<para>specifications</para><para>specifiche</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/specifications">https://w3id.org/arco/ontology/core/specifications</seealso>
    let specifications = Prefixed_Name(arco, "specifications") |> PrefixedName
    /// <summary>
    ///   <para>arco:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Questa proprietà rappresenta una parola chiave relativa a un'entità, che può essere utilizzata per la ricerca dell'entità.</para>
    ///   <para>This property represents a keyword related to an entity, used to search for that entity.</para>
    /// labels<para>parola chiave</para><para>keyword</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/keyword">https://w3id.org/arco/ontology/core/keyword</seealso>
    let keyword = Prefixed_Name(arco, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>arco:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta eventuali note, relative a una certa informazione.</para>
    ///   <para>This property represents notes associated to a piece of information.</para>
    /// labels<para>note</para><para>note</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/note">https://w3id.org/arco/ontology/core/note</seealso>
    let note = Prefixed_Name(arco, "note") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a situation in which an agent holds a role to that agent.</para>
    ///   <para>Questa proprietà collega una situazione in cui un ruolo viene ricoperto da un agente all'agente che lo ricopre.</para>
    /// labels<para>has agent</para><para>ha agente</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasAgent">https://w3id.org/arco/ontology/core/hasAgent</seealso>
    let hasAgent = Prefixed_Name(arco, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>arco:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe che rappresenta il concetto di classificazione.</para>
    ///   <para>The class that models the concept of classification.</para>
    /// labels<para>Classificazione</para><para>Classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Classification">https://w3id.org/arco/ontology/core/Classification</seealso>
    let Classification = Prefixed_Name(arco, "Classification") |> PrefixedName

    /// <summary>
    ///   <para>arco:CulturalEntityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe che rappresenta una caratteristica di un'entità di carattere culturale come ad esempio un bene culturale.</para>
    ///   <para>The class representing the characteristic of a cultural entity (e.g. a cultural property).</para>
    /// labels<para>Caratteristica di Entità Culturale</para><para>Cultural Entity Characteristic</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/CulturalEntityCharacteristic">https://w3id.org/arco/ontology/core/CulturalEntityCharacteristic</seealso>
    let CulturalEntityCharacteristic =
        Prefixed_Name(arco, "CulturalEntityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>arco:AgentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Questa classe rappresenta una situazione relativa a un agente che ricopre un ruolo, senza la specificazione della dimensione tempo.</para>
    ///   <para>This class represents a situation in which an agent holds a role, regardless of the timing.</para>
    /// labels<para>Ruolo ricoperto da agente</para><para>Agent Role</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/AgentRole">https://w3id.org/arco/ontology/core/AgentRole</seealso>
    let AgentRole = Prefixed_Name(arco, "AgentRole") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a situation in which an agent holds a role to that role.</para>
    ///   <para>Questa proprietà collega una situazione in cui un ruolo viene ricoperto da un agente al ruolo stesso.</para>
    /// labels<para>ha ruolo</para><para>has role</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasRole">https://w3id.org/arco/ontology/core/hasRole</seealso>
    let hasRole = Prefixed_Name(arco, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>arco:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La classe che rappresenta una categoria.</para>
    ///   <para>The class representing a category.</para>
    /// labels<para>Categoria</para><para>Category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Category">https://w3id.org/arco/ontology/core/Category</seealso>
    let Category = Prefixed_Name(arco, "Category") |> PrefixedName
    /// <summary>
    ///   <para>arco:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class representing the concept of method.</para>
    ///   <para>Classe che rappresenta il concetto di metodo.</para>
    /// labels<para>Method</para><para>Metodo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Method">https://w3id.org/arco/ontology/core/Method</seealso>
    let Method = Prefixed_Name(arco, "Method") |> PrefixedName
    /// <summary>
    ///   <para>arco:isAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an agent to a situation in which that agent holds a role.</para>
    ///   <para>Questa proprietà, inversa a "ha agente", collega un agente alla situazione in cui l'agente ha ricoperto un ruolo.</para>
    /// labels<para>è agente in</para><para>is agent of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isAgentOf">https://w3id.org/arco/ontology/core/isAgentOf</seealso>
    let isAgentOf = Prefixed_Name(arco, "isAgentOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasAgentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Questa proprietà collega un'entità a una situazione in cui un agente ricopre un ruolo.</para>
    ///   <para>This property relates an entity to a situation in which an agent holds a role connected to that entity.</para>
    /// labels<para>ha ruolo ricoperto da agente</para><para>has agent role</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasAgentRole">https://w3id.org/arco/ontology/core/hasAgentRole</seealso>
    let hasAgentRole = Prefixed_Name(arco, "hasAgentRole") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che associa un qualunque oggetto a un concetto, che lo classifica.</para>
    ///   <para>The object property that associates any object with a concept, classifying it.</para>
    /// labels<para>has concept</para><para>ha concetto</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasConcept">https://w3id.org/arco/ontology/core/hasConcept</seealso>
    let hasConcept = Prefixed_Name(arco, "hasConcept") |> PrefixedName
    /// <summary>
    ///   <para>arco:isCharacteristicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that links an entity characteristic to the entity.</para>
    ///   <para>La object property che collega una caratteristica di un'entità all'entità stessa.</para>
    /// labels<para>is characteristic of</para><para>è caratteristica di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isCharacteristicOf">https://w3id.org/arco/ontology/core/isCharacteristicOf</seealso>
    let isCharacteristicOf = Prefixed_Name(arco, "isCharacteristicOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that allows to add a classification to any object.</para>
    ///   <para>La object property che permette di aggiungere una classificazione a un qualsiasi oggetto.</para>
    /// labels<para>has classification</para><para>ha classificazione</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasClassification">https://w3id.org/arco/ontology/core/hasClassification</seealso>
    let hasClassification = Prefixed_Name(arco, "hasClassification") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates an entity to its part.</para>
    ///   <para>Questa proprietà collega un'entità a una sua parte.</para>
    /// labels<para>has part</para><para>ha parte</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasPart">https://w3id.org/arco/ontology/core/hasPart</seealso>
    let hasPart = Prefixed_Name(arco, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>arco:isConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà inversa di hasConcept, che collega un concetto a un qualunque oggetto.</para>
    ///   <para>The inverse property of hasConcept, that relates a concept to any object.</para>
    /// labels<para>è concetto di</para><para>is concept of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isConceptOf">https://w3id.org/arco/ontology/core/isConceptOf</seealso>
    let isConceptOf = Prefixed_Name(arco, "isConceptOf") |> PrefixedName

    /// <summary>
    ///   <para>arco:hasCulturalEntityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che collega una cultural entity a una sua caratteristica.</para>
    ///   <para>The object property that links a cultural entity to one of its characteristics.</para>
    /// labels<para>ha caratteristica di entità culturale</para><para>has cultural entity characteristic</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasCulturalEntityCharacteristic">https://w3id.org/arco/ontology/core/hasCulturalEntityCharacteristic</seealso>
    let hasCulturalEntityCharacteristic =
        Prefixed_Name(arco, "hasCulturalEntityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>arco:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che collega un luogo a un'entità che si trova in quel luogo.</para>
    ///   <para>The object property that associates a location to an entity located there.</para>
    /// labels<para>is location of</para><para>è luogo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isLocationOf">https://w3id.org/arco/ontology/core/isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(arco, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that links an entity to a method.</para>
    ///   <para>L'object property che collega un'entità a un metodo.</para>
    /// labels<para>has method</para><para>ha metodo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasMethod">https://w3id.org/arco/ontology/core/hasMethod</seealso>
    let hasMethod = Prefixed_Name(arco, "hasMethod") |> PrefixedName
    /// <summary>
    ///   <para>arco:isMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>L'object property che collega un metodo a un'entità.</para>
    ///   <para>The object property that links a method to an entity.</para>
    /// labels<para>is method of</para><para>è metodo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isMethodOf">https://w3id.org/arco/ontology/core/isMethodOf</seealso>
    let isMethodOf = Prefixed_Name(arco, "isMethodOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:isRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a role to a situation in which an agent holds that role.</para>
    ///   <para>Questa proprietà collega un ruolo a una situazione in cui il ruolo viene ricoperto da un agente.</para>
    /// labels<para>is role of</para><para>è ruolo in</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isRoleOf">https://w3id.org/arco/ontology/core/isRoleOf</seealso>
    let isRoleOf = Prefixed_Name(arco, "isRoleOf") |> PrefixedName

    /// <summary>
    ///   <para>arco:hasTimeIndexedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà che collega un qualsiasi oggetto a una situazione indicizzata nel tempo.</para>
    ///   <para>The property that links any object to a time indexed situation.</para>
    /// labels<para>has time indexed situation</para><para>ha situazione nel tempo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasTimeIndexedSituation">https://w3id.org/arco/ontology/core/hasTimeIndexedSituation</seealso>
    let hasTimeIndexedSituation =
        Prefixed_Name(arco, "hasTimeIndexedSituation") |> PrefixedName

    /// <summary>
    ///   <para>arco:isTimeIndexedSituationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà che collega una situazione indicizzata nel tempo ad un qualsiasi oggetto. La proprietà è modellata come proprietà inversa di hasTimeIndexedSituation.</para>
    ///   <para>The property that links a time indexed situation to any object. The property is modelled as inverse object property of hasTimeIndexedSituation.</para>
    /// labels<para>is time indexed situation of</para><para>è situazione nel tempo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isTimeIndexedSituationOf">https://w3id.org/arco/ontology/core/isTimeIndexedSituationOf</seealso>
    let isTimeIndexedSituationOf =
        Prefixed_Name(arco, "isTimeIndexedSituationOf") |> PrefixedName

    /// <summary>
    ///   <para>arco:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that associates any object with a type.</para>
    ///   <para>La object property che associa un qualunque oggetto a un tipo.</para>
    /// labels<para>has type</para><para>ha tipo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasType">https://w3id.org/arco/ontology/core/hasType</seealso>
    let hasType = Prefixed_Name(arco, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>arco:isTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che associa un tipo a un qualunque oggetto.</para>
    ///   <para>The object property that associates a type to any object.</para>
    /// labels<para>is type of</para><para>è tipo di</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isTypeOf">https://w3id.org/arco/ontology/core/isTypeOf</seealso>
    let isTypeOf = Prefixed_Name(arco, "isTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class representing a concept.</para>
    ///   <para>La classe che rappresenta un concetto.</para>
    /// labels<para>Concetto</para><para>Concept</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Concept">https://w3id.org/arco/ontology/core/Concept</seealso>
    let Concept = Prefixed_Name(arco, "Concept") |> PrefixedName

    /// <summary>
    ///   <para>arco:CulturalEntityClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that models the concept of cultural entity classification.</para>
    ///   <para>La classe che rappresenta il concetto di classificazione di un'entità culturale.</para>
    /// labels<para>Classificazione relativa a bene culturale</para><para>Cultural entity classification</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/CulturalEntityClassification">https://w3id.org/arco/ontology/core/CulturalEntityClassification</seealso>
    let CulturalEntityClassification =
        Prefixed_Name(arco, "CulturalEntityClassification") |> PrefixedName

    /// <summary>
    ///   <para>arco:TimeIndexedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class representing the generic concept of time indexed situation.</para>
    ///   <para>La classe che rappresenta il generico concetto di situazione indicizzata nel tempo.</para>
    /// labels<para>Time indexed situation</para><para>Situazione nel tempo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/TimeIndexedSituation">https://w3id.org/arco/ontology/core/TimeIndexedSituation</seealso>
    let TimeIndexedSituation =
        Prefixed_Name(arco, "TimeIndexedSituation") |> PrefixedName

    /// <summary>
    ///   <para>arco:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class representing the concept of type.</para>
    ///   <para>Classe che rappresenta il concetto di tipo.</para>
    /// labels<para>Type</para><para>Tipo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/Type">https://w3id.org/arco/ontology/core/Type</seealso>
    let Type = Prefixed_Name(arco, "Type") |> PrefixedName
    /// <summary>
    ///   <para>arco:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Questa proprietà rappresenta una descrizione associata a una certa entità, che viene arricchita con ulteriori dettagli che la descrivono.</para>
    ///   <para>This property relates a description associated to an entity, in order to add details and some more information.</para>
    /// labels<para>description</para><para>descrizione</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/description">https://w3id.org/arco/ontology/core/description</seealso>
    let description = Prefixed_Name(arco, "description") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che associa un qualunque oggetto a una categoria.</para>
    ///   <para>The object property that associates any object with a category.</para>
    /// labels<para>ha categoria</para><para>has category</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasCategory">https://w3id.org/arco/ontology/core/hasCategory</seealso>
    let hasCategory = Prefixed_Name(arco, "hasCategory") |> PrefixedName
    /// <summary>
    ///   <para>arco:isCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that associates a category to any object.</para>
    ///   <para>La object property che associa una categoria a un qualunque oggetto.</para>
    /// labels<para>è categoria di</para><para>is category of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isCategoryOf">https://w3id.org/arco/ontology/core/isCategoryOf</seealso>
    let isCategoryOf = Prefixed_Name(arco, "isCategoryOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La object property che collega un'entità a una sua caratteristica.</para>
    ///   <para>The object property that links an entity to one of its characteristics.</para>
    /// labels<para>has characteristic</para><para>ha caratteristica</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasCharacteristic">https://w3id.org/arco/ontology/core/hasCharacteristic</seealso>
    let hasCharacteristic = Prefixed_Name(arco, "hasCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>arco:isClassificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La proprietà inversa di hasClassification, che collega un oggetto a una sua classificazione.</para>
    ///   <para>The inverse object property of hasClassification, that links an object to a classification.</para>
    /// labels<para>è classificazione di</para><para>is classification of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isClassificationOf">https://w3id.org/arco/ontology/core/isClassificationOf</seealso>
    let isClassificationOf = Prefixed_Name(arco, "isClassificationOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates, non-transitively, a component to an entity of which it is component.</para>
    ///   <para>Questa proprietà collega, in maniera non-transitiva, un componente a un'entità di cui è componente.</para>
    /// labels<para>è componente di</para><para>is component of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isComponentOf">https://w3id.org/arco/ontology/core/isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(arco, "isComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>arco:isCulturalEntityCharacteristicOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that links a cultural entity characteristic to the cultural entity.</para>
    ///   <para>La object property che collega una caratteristica di una cultural entity alla cultural entity.</para>
    /// labels<para>è caratteristica di entità culturale di</para><para>is cultural entity characteristic of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isCulturalEntityCharacteristicOf">https://w3id.org/arco/ontology/core/isCulturalEntityCharacteristicOf</seealso>
    let isCulturalEntityCharacteristicOf =
        Prefixed_Name(arco, "isCulturalEntityCharacteristicOf") |> PrefixedName

    /// <summary>
    ///   <para>arco:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>This property relates the part of an entity to that entity.</para>
    ///   <para>Questa proprietà collega una parte di un'entità all'entità.</para>
    /// labels<para>è parte di</para><para>is part of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isPartOf">https://w3id.org/arco/ontology/core/isPartOf</seealso>
    let isPartOf = Prefixed_Name(arco, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>arco:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that associates an entity to a location.</para>
    ///   <para>La object property che collega un'entità a un luogo in cui si trova.</para>
    /// labels<para>has location</para><para>ha luogo</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/hasLocation">https://w3id.org/arco/ontology/core/hasLocation</seealso>
    let hasLocation = Prefixed_Name(arco, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>arco:iccdNormTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/iccdNormTag">https://w3id.org/arco/ontology/core/iccdNormTag</seealso>
    let iccdNormTag = Prefixed_Name(arco, "iccdNormTag") |> PrefixedName
    /// <summary>
    ///   <para>arco:isSituationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that links a situation to any object. The property is modelled as inverse object property of hasSituation.</para>
    ///   <para>La proprietà che collega una situazione ad un qualsiasi oggetto. La proprietà è modellata come proprietà inversa di hasSituation.</para>
    /// labels<para>è situazione di</para><para>is situation of</para></remarks>
    /// <seealso href="https://w3id.org/arco/ontology/core/isSituationOf">https://w3id.org/arco/ontology/core/isSituationOf</seealso>
    let isSituationOf = Prefixed_Name(arco, "isSituationOf") |> PrefixedName

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module voaf =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vocommons/voaf#" "voaf"
    /// <summary>
    ///   <para>rdfs:comment : Class used to store the number of occurences of a vocabulary in a particular datasetrdfs:comment : Classe utilisée pour stocker l'information d'occurences d'un vocabulaire dans un jeu de données</para>
    ///   <para>rdfs:label : Dataset occurrencesrdfs:label : Occurrences dans un jeu de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#DatasetOccurrences">voaf:DatasetOccurrences</a>
    /// </summary>
    let DatasetOccurrences = _prefixId.prefix "DatasetOccurrences"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary used in the linked data cloud. An instance of voaf:Vocabulary relies on or is used by at least another instance of voaf:Vocabularyrdfs:comment : Un vocabulaire utilisé ou utilisable dans le Web des données. Une instance de voaf:Vocabulary s'appuie at/ou est utilisée par au moins une autre instance of voaf:Vocabulary</para>
    ///   <para>rdfs:label : Vocabulairerdfs:label : Vocabulary</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#Vocabulary">voaf:Vocabulary</a>
    /// </summary>
    let Vocabulary = _prefixId.prefix "Vocabulary"
    /// <summary>
    ///   <para>rdfs:comment : A vocabulary space defines any relevant grouping of vocabularies e.g., designed for similar purposes or domains, or designed by the same publisher or the same project, etc.
    ///           A vocabulary can belong to zero, one or more vocabulary spaces.Dublin Core properties isPartOf and hasPart are used to link a vocabulary to a vocabulary space.rdfs:comment : Un Espace de vocabulaires définit un regroupement pertinent de vocabulaires, par exemple construits pour des domaines ou objectifs similaires, ou par le même déditeur ou le même projet, etc.
    ///          Un Vocabulaire peut appartenir à zéro, un ou plusieurs Espace de vocabulaires. Les propriétés Dublin Core isPartOf et hasPart sont utilisées pour relier un Vocabulaire à un Espace de vocabulaires.</para>
    ///   <para>rdfs:label : Espace de vocabulairesrdfs:label : Vocabulary Space</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#VocabularySpace">voaf:VocabularySpace</a>
    /// </summary>
    let VocabularySpace = _prefixId.prefix "VocabularySpace"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 		?vocab voaf:classNumber ?nbClass
    /// 		}
    /// 		WHERE{
    /// 			SELECT (COUNT(distinct ?class) AS ?nbClass) ?vocab
    /// 			WHERE{
    /// 				{?class a rdfs:Class.}
    /// 				UNION{?class a owl:Class.}
    /// 				?class a ?type.
    /// 				FILTER(?type!=owl:DeprecatedClass)
    /// 				?class rdfs:isDefinedBy ?vocab.
    /// 				?vocab a voaf:Vocabulary.
    /// 			}GROUP BY ?vocab
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Le nombre de classes définies dans l'espace de noms du Vocabulaire. Les classes importées d'autres vocabulaires ne sont pas comptabilisées.rdfs:comment : The number of classes defined in the vocabulary namespace. Classes imported from other namespaces are not taken into account.</para>
    ///   <para>rdfs:label : nombre de classesrdfs:label : number of classes</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#classNumber">voaf:classNumber</a>
    /// </summary>
    let classNumber = _prefixId.prefix "classNumber"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated since v2.4rdfs:comment : Déprécié depuis la v2.4</para>
    ///   <para>rdfs:label : datasetrdfs:label : jeu de données</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#dataset">voaf:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:comment : Deprecated since v1.1rdfs:comment : Déprécié depuis la v1.1</para>
    ///   <para>rdfs:label : example datasetrdfs:label : exemple de jeu de données</para>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#exampleDataset">voaf:exampleDataset</a>
    /// </summary>
    let exampleDataset = _prefixId.prefix "exampleDataset"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:extends ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 owl:inverseOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:domain ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:range ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem2 rdfs:domain ?elem1. FILTER(!isBlank(?elem1))}
    /// 			UNION{?elem2 rdfs:range ?elem1. FILTER(!isBlank(?elem1))}
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary extends the expressivity of the object vocabulary by declaring subsumption relationships, using object vocabulary class as domain or range of a subject vocabulary property, defining local restrictions etc ...rdfs:comment : Indique que le vocabulaire sujet étend l'expressivité du vocabulaire objet en déclarant des relations de subsomption avec ce dernier, ou en utilisant ses classes comme domaine ou co-domaine d'un propriété du vocabulaire sujet, ou en définissant des contraintes locales etc.</para>
    ///   <para>rdfs:label : extendsrdfs:label : étend</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#extends">voaf:extends</a>
    /// </summary>
    let extends = _prefixId.prefix "extends"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdf:&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#&gt;
    /// 		PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:generalizes ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 skos:narrowMatch ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem2 rdfs:subPropertyOf ?elem1.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:rest ?union4. ?union4 rdf:first ?elem2.}
    /// 			UNION{?elem1 a owl:Class. ?elem1 owl:unionOf ?union. ?union rdf:rest ?union2. ?union2 rdf:rest ?union3. ?union3 rdf:rest ?union4. ?union4 rdf:rest ?union5. ?union5 rdf:first ?elem2.}
    /// 			FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet définit des super-classes ou super-propriétés du vocabulaire objet</para>
    ///   <para>rdfs:label : generalizesrdfs:label : généralise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#generalizes">voaf:generalizes</a>
    /// </summary>
    let generalizes = _prefixId.prefix "generalizes"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:hasDisjunctionsWith ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			?elem1 owl:disjointWith ?elem2. FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary contains some declaration of disjoint classes with the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet contient des déclarations de classes disjointes avec le vocabulaire objet</para>
    ///   <para>rdfs:label : a des disjonctions avecrdfs:label : has disjunctions with</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#hasDisjunctionsWith">voaf:hasDisjunctionsWith</a>
    /// </summary>
    let hasDisjunctionsWith = _prefixId.prefix "hasDisjunctionsWith"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:hasEquivalencesWith ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 owl:equivalentProperty ?elem2.}
    /// 			UNION{?elem1 owl:sameAs ?elem2.}
    /// 			UNION{?elem1 owl:equivalentClass ?elem2.}
    /// 			UNION{?elem2 owl:equivalentProperty ?elem1.}
    /// 			UNION{?elem2 owl:equivalentClass ?elem1.}
    /// 			UNION{?elem1 skos:exactMatch ?elem2.}
    /// 			UNION{?elem2 skos:exactMatch ?elem1.}
    /// 			FILTER(!isBlank(?elem2))
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.rdfs:comment : Indique que le vocabulaire sujet déclare des équivalences de classes ou de propriétés avec le vocabulaire objet</para>
    ///   <para>rdfs:label : a des équivalences avecrdfs:label : has equivalences with</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#hasEquivalencesWith">voaf:hasEquivalencesWith</a>
    /// </summary>
    let hasEquivalencesWith = _prefixId.prefix "hasEquivalencesWith"
    /// <summary>
    ///   <para>rdfs:comment : dataset in which a vocabulary occurredrdfs:comment : jeu de données dans lequel un vocabulaire apparait</para>
    ///   <para>rdfs:label : dans le jeu de donnéesrdfs:label : in dataset</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#inDataset">voaf:inDataset</a>
    /// </summary>
    let inDataset = _prefixId.prefix "inDataset"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:metadataVoc ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			?elem1 ?elem2 ?o.
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary uses the object vocabulary in metadata at global vocabulary level or at element levelrdfs:comment : Indique que le vocabulaire sujet utilise le vocabulaire objet pour décrire ses métadonnées, au niveau global du vocabulaire ou au niveau des éléments</para>
    ///   <para>rdfs:label : metadata vocabularyrdfs:label : vocabulaire de métadonnées</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#metadataVoc">voaf:metadataVoc</a>
    /// </summary>
    let metadataVoc = _prefixId.prefix "metadataVoc"
    /// <summary>
    ///   <para>rdfs:comment : Number of occurrences of a vocabulary in a datasetrdfs:comment : nombre d'occurrences d'un vocabulaire dans un dataset</para>
    ///   <para>rdfs:label : occurrencesrdfs:label : occurrences</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrences">voaf:occurrences</a>
    /// </summary>
    let occurrences = _prefixId.prefix "occurrences"
    /// <summary>
    ///   <para>rdfs:comment : Nombre de jeux de données utilisant une ressource.rdfs:comment : Number of datasets using a resource.</para>
    ///   <para>rdfs:label : occurences dans des datasetsrdfs:label : occurrences in datasets</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrencesInDatasets">voaf:occurrencesInDatasets</a>
    /// </summary>
    let occurrencesInDatasets = _prefixId.prefix "occurrencesInDatasets"
    /// <summary>
    ///   <para>rdfs:comment : Nombre de vocabulaires utilisant une ressource.rdfs:comment : Number of vocabularies using a resource</para>
    ///   <para>rdfs:label : occurences dans des vocabulairesrdfs:label : occurrences in vocabularies</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#occurrencesInVocabularies">voaf:occurrencesInVocabularies</a>
    /// </summary>
    let occurrencesInVocabularies = _prefixId.prefix "occurrencesInVocabularies"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdf:&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#&gt;
    /// 		PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX owl:&lt;http://www.w3.org/2002/07/owl#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    ///
    /// 		CONSTRUCT{
    /// 		?vocab voaf:propertyNumber ?nbProp
    /// 		}
    /// 		WHERE{
    /// 			SELECT (COUNT(distinct ?prop) AS ?nbProp) ?vocab
    /// 			WHERE{
    /// 				{?prop a rdf:Property.}
    /// 				UNION{?prop a owl:ObjectProperty.}
    /// 				UNION{?prop a owl:DatatypeProperty.}
    /// 				UNION{?prop a owl:AnnotationProperty.}
    /// 				UNION{?prop a owl:FunctionalProperty.}
    /// 				UNION{?prop a owl:OntologyProperty.}
    /// 				UNION{?prop a owl:AsymmetricProperty.}
    /// 				UNION{?prop a owl:InverseFunctionalProperty.}
    /// 				UNION{?prop a owl:IrreflexiveProperty.}
    /// 				UNION{?prop a owl:ReflexiveProperty.}
    /// 				UNION{?prop a owl:SymmetricProperty.}
    /// 				UNION{?prop a owl:TransitiveProperty.}
    /// 				?prop a ?type.
    /// 				FILTER(?type!=owl:DeprecatedProperty)
    /// 				?prop rdfs:isDefinedBy ?vocab.
    /// 				?vocab a voaf:Vocabulary.
    /// 			}GROUP BY ?vocab
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Le nombre de propriétés définies dans l'espace de noms du Vocabulaire. Les propriétés importées d'autres vocabulaires ne sont pas comptabilisées.rdfs:comment : The number of properties defined in the vocabulary namespace. Properties imported from other namespaces are not taken into account.</para>
    ///   <para>rdfs:label : nombre de propriétésrdfs:label : number of properties</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#propertyNumber">voaf:propertyNumber</a>
    /// </summary>
    let propertyNumber = _prefixId.prefix "propertyNumber"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary uses or extends some class or property of the object vocabularyrdfs:comment : Indique que le vocabulaire sujet utilise ou étend au moins une classe ou propriété du vocabulaire objet</para>
    ///   <para>rdfs:label : relies onrdfs:label : réutilise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reliesOn">voaf:reliesOn</a>
    /// </summary>
    let reliesOn = _prefixId.prefix "reliesOn"
    /// <summary>
    ///   <para>rdfs:comment : Distinct number of datasets reusing a resource.rdfs:comment : Nombre distinct de jeux de données reutilisant une resource.</para>
    ///   <para>rdfs:label : reused by datasetsrdfs:label : réutilisé par des jeux de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reusedByDatasets">voaf:reusedByDatasets</a>
    /// </summary>
    let reusedByDatasets = _prefixId.prefix "reusedByDatasets"
    /// <summary>
    ///   <para>rdfs:comment : Distinct number of vocabularies reusing a resource.rdfs:comment : Nombre distinct de vocabulaires reutilisant une resource.</para>
    ///   <para>rdfs:label : reused by vocabulariesrdfs:label : réutilisé par des vocabulaires</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#reusedByVocabularies">voaf:reusedByVocabularies</a>
    /// </summary>
    let reusedByVocabularies = _prefixId.prefix "reusedByVocabularies"
    /// <summary>
    ///   <para>rdfs:comment : Indique que deux vocabulaires sont similaires dans leur domaine et/ou leurs objectifs, sans être nécessairement reliés par des références.rdfs:comment : Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.</para>
    ///   <para>rdfs:label : similairerdfs:label : similar</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#similar">voaf:similar</a>
    /// </summary>
    let similar = _prefixId.prefix "similar"
    /// <summary>
    ///   <para>dcterms:description : PREFIX rdfs:&lt;http://www.w3.org/2000/01/rdf-schema#&gt;
    /// 		PREFIX voaf:&lt;http://purl.org/vocommons/voaf#&gt;
    /// 		PREFIX skos:&lt;http://www.w3.org/2004/02/skos/core#&gt;
    ///
    /// 		CONSTRUCT{
    /// 			?vocab1 voaf:specializes ?vocab2
    /// 		}
    /// 		WHERE{
    /// 			{?elem1 rdfs:subPropertyOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 rdfs:subClassOf ?elem2. FILTER(!isBlank(?elem2))}
    /// 			UNION{?elem1 skos:broadMatch ?elem2. FILTER(!isBlank(?elem2))}
    /// 			?elem1 rdfs:isDefinedBy ?vocab1.
    /// 			?vocab1 a voaf:Vocabulary.
    /// 			?elem2 rdfs:isDefinedBy ?vocab2.
    /// 			?vocab2 a voaf:Vocabulary.
    /// 			FILTER(?vocab1!=?vocab2)
    /// 		}^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.rdfs:comment : Indique que le vocabulaire sujet définit des sous-classes ou sous-propriétés du vocabulaire objet</para>
    ///   <para>rdfs:label : specializesrdfs:label : spécialise</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#specializes">voaf:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:comment : Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.rdfs:comment : Liste des tâches prévues par le gestionnaire d'une ressource. Cette propriété est destinée à l'usage des gestionnaires de vocabulaires ou de jeu de données mais son doamine est ouvert, elle peut être utilisée pour n'importe quelle ressource. Utiliser la classe ical:Vtodo pour une description fine des tâches : calendrier, priorités etc</para>
    ///   <para>rdfs:label : liste des choses à fairerdfs:label : to-do list</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#toDoList">voaf:toDoList</a>
    /// </summary>
    let toDoList = _prefixId.prefix "toDoList"
    /// <summary>
    ///   <para>rdfs:comment : statistiques d'utilisation dans un jeu de donnéesrdfs:comment : usage statistics in a dataset</para>
    ///   <para>rdfs:label : usage in datasetrdfs:label : utilisation dans un jeu de données</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#usageInDataset">voaf:usageInDataset</a>
    /// </summary>
    let usageInDataset = _prefixId.prefix "usageInDataset"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the subject vocabulary is used by the object vocabularyrdfs:comment : Indique que le vocabulaire sujet est utilisé par le vocabulaire objet</para>
    ///   <para>rdfs:label : used byrdfs:label : utilisé par</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/vocommons/voaf#usedBy">voaf:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"

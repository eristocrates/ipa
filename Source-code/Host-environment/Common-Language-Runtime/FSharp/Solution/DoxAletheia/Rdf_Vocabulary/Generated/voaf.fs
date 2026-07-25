namespace http.purl.org.vocommons.voaf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module voaf =
    let _namespace_iri = Namespace_Iri voaf |> NamespaceIRI
    /// <summary>
    ///   <para>voaf:Vocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un vocabulaire utilisé ou utilisable dans le Web des données. Une instance de voaf:Vocabulary s'appuie at/ou est utilisée par au moins une autre instance of voaf:Vocabulary</para>
    ///   <para>A vocabulary used in the linked data cloud. An instance of voaf:Vocabulary relies on or is used by at least another instance of voaf:Vocabulary</para>
    /// labels<para>Vocabulaire</para><para>Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#Vocabulary">http://purl.org/vocommons/voaf#Vocabulary</seealso>
    let Vocabulary = Prefixed_Name(voaf, "Vocabulary") |> PrefixedName
    /// <summary>
    ///   <para>voaf:DatasetOccurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe utilisée pour stocker l'information d'occurences d'un vocabulaire dans un jeu de données</para>
    ///   <para>Class used to store the number of occurences of a vocabulary in a particular dataset</para>
    /// labels<para>Occurrences dans un jeu de données</para><para>Dataset occurrences</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#DatasetOccurrences">http://purl.org/vocommons/voaf#DatasetOccurrences</seealso>
    let DatasetOccurrences = Prefixed_Name(voaf, "DatasetOccurrences") |> PrefixedName
    /// <summary>
    ///   <para>voaf:exampleDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Déprécié depuis la v1.1</para>
    ///   <para>Deprecated since v1.1</para>
    /// labels<para>exemple de jeu de données</para><para>example dataset</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#exampleDataset">http://purl.org/vocommons/voaf#exampleDataset</seealso>
    let exampleDataset = Prefixed_Name(voaf, "exampleDataset") |> PrefixedName
    /// <summary>
    ///   <para>voaf:reliesOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique que le vocabulaire sujet utilise ou étend au moins une classe ou propriété du vocabulaire objet</para>
    ///   <para>Indicates that the subject vocabulary uses or extends some class or property of the object vocabulary</para>
    /// labels<para>réutilise</para><para>relies on</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#reliesOn">http://purl.org/vocommons/voaf#reliesOn</seealso>
    let reliesOn = Prefixed_Name(voaf, "reliesOn") |> PrefixedName
    /// <summary>
    ///   <para>voaf:VocabularySpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vocabulary space defines any relevant grouping of vocabularies e.g., designed for similar purposes or domains, or designed by the same publisher or the same project, etc.
    ///           A vocabulary can belong to zero, one or more vocabulary spaces.Dublin Core properties isPartOf and hasPart are used to link a vocabulary to a vocabulary space.</para>
    ///   <para>Un Espace de vocabulaires définit un regroupement pertinent de vocabulaires, par exemple construits pour des domaines ou objectifs similaires, ou par le même déditeur ou le même projet, etc.
    ///          Un Vocabulaire peut appartenir à zéro, un ou plusieurs Espace de vocabulaires. Les propriétés Dublin Core isPartOf et hasPart sont utilisées pour relier un Vocabulaire à un Espace de vocabulaires.</para>
    /// labels<para>Espace de vocabulaires</para><para>Vocabulary Space</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#VocabularySpace">http://purl.org/vocommons/voaf#VocabularySpace</seealso>
    let VocabularySpace = Prefixed_Name(voaf, "VocabularySpace") |> PrefixedName
    /// <summary>
    ///   <para>voaf:classNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of classes defined in the vocabulary namespace. Classes imported from other namespaces are not taken into account.</para>
    ///   <para>Le nombre de classes définies dans l'espace de noms du Vocabulaire. Les classes importées d'autres vocabulaires ne sont pas comptabilisées.</para>
    /// labels<para>number of classes</para><para>nombre de classes</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#classNumber">http://purl.org/vocommons/voaf#classNumber</seealso>
    let classNumber = Prefixed_Name(voaf, "classNumber") |> PrefixedName
    /// <summary>
    ///   <para>voaf:usageInDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage statistics in a dataset</para>
    ///   <para>statistiques d'utilisation dans un jeu de données</para>
    /// labels<para>utilisation dans un jeu de données</para><para>usage in dataset</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#usageInDataset">http://purl.org/vocommons/voaf#usageInDataset</seealso>
    let usageInDataset = Prefixed_Name(voaf, "usageInDataset") |> PrefixedName
    /// <summary>
    ///   <para>voaf:extends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary extends the expressivity of the object vocabulary by declaring subsumption relationships, using object vocabulary class as domain or range of a subject vocabulary property, defining local restrictions etc ...</para>
    ///   <para>Indique que le vocabulaire sujet étend l'expressivité du vocabulaire objet en déclarant des relations de subsomption avec ce dernier, ou en utilisant ses classes comme domaine ou co-domaine d'un propriété du vocabulaire sujet, ou en définissant des contraintes locales etc.</para>
    /// labels<para>extends</para><para>étend</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#extends">http://purl.org/vocommons/voaf#extends</seealso>
    let extends = Prefixed_Name(voaf, "extends") |> PrefixedName
    /// <summary>
    ///   <para>voaf:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Déprécié depuis la v2.4</para>
    ///   <para>Deprecated since v2.4</para>
    /// labels<para>jeu de données</para><para>dataset</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#dataset">http://purl.org/vocommons/voaf#dataset</seealso>
    let dataset = Prefixed_Name(voaf, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>voaf:hasDisjunctionsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary contains some declaration of disjoint classes with the object vocabulary.</para>
    ///   <para>Indique que le vocabulaire sujet contient des déclarations de classes disjointes avec le vocabulaire objet</para>
    /// labels<para>a des disjonctions avec</para><para>has disjunctions with</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#hasDisjunctionsWith">http://purl.org/vocommons/voaf#hasDisjunctionsWith</seealso>
    let hasDisjunctionsWith = Prefixed_Name(voaf, "hasDisjunctionsWith") |> PrefixedName
    /// <summary>
    ///   <para>voaf:hasEquivalencesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indique que le vocabulaire sujet déclare des équivalences de classes ou de propriétés avec le vocabulaire objet</para>
    ///   <para>Indicates that the subject vocabulary declares some equivalent classes or properties with the object vocabulary.</para>
    /// labels<para>a des équivalences avec</para><para>has equivalences with</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#hasEquivalencesWith">http://purl.org/vocommons/voaf#hasEquivalencesWith</seealso>
    let hasEquivalencesWith = Prefixed_Name(voaf, "hasEquivalencesWith") |> PrefixedName
    /// <summary>
    ///   <para>voaf:generalizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary generalizes by some superclasses or superproperties the object vocabulary.</para>
    ///   <para>Indique que le vocabulaire sujet définit des super-classes ou super-propriétés du vocabulaire objet</para>
    /// labels<para>generalizes</para><para>généralise</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#generalizes">http://purl.org/vocommons/voaf#generalizes</seealso>
    let generalizes = Prefixed_Name(voaf, "generalizes") |> PrefixedName
    /// <summary>
    ///   <para>voaf:inDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>dataset in which a vocabulary occurred</para>
    ///   <para>jeu de données dans lequel un vocabulaire apparait</para>
    /// labels<para>dans le jeu de données</para><para>in dataset</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#inDataset">http://purl.org/vocommons/voaf#inDataset</seealso>
    let inDataset = Prefixed_Name(voaf, "inDataset") |> PrefixedName

    /// <summary>
    ///   <para>voaf:occurrencesInDatasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of datasets using a resource.</para>
    ///   <para>Nombre de jeux de données utilisant une ressource.</para>
    /// labels<para>occurences dans des datasets</para><para>occurrences in datasets</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#occurrencesInDatasets">http://purl.org/vocommons/voaf#occurrencesInDatasets</seealso>
    let occurrencesInDatasets =
        Prefixed_Name(voaf, "occurrencesInDatasets") |> PrefixedName

    /// <summary>
    ///   <para>voaf:propertyNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of properties defined in the vocabulary namespace. Properties imported from other namespaces are not taken into account.</para>
    ///   <para>Le nombre de propriétés définies dans l'espace de noms du Vocabulaire. Les propriétés importées d'autres vocabulaires ne sont pas comptabilisées.</para>
    /// labels<para>nombre de propriétés</para><para>number of properties</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#propertyNumber">http://purl.org/vocommons/voaf#propertyNumber</seealso>
    let propertyNumber = Prefixed_Name(voaf, "propertyNumber") |> PrefixedName
    /// <summary>
    ///   <para>voaf:reusedByDatasets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Distinct number of datasets reusing a resource.</para>
    ///   <para>Nombre distinct de jeux de données reutilisant une resource.</para>
    /// labels<para>réutilisé par des jeux de données</para><para>reused by datasets</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#reusedByDatasets">http://purl.org/vocommons/voaf#reusedByDatasets</seealso>
    let reusedByDatasets = Prefixed_Name(voaf, "reusedByDatasets") |> PrefixedName
    /// <summary>
    ///   <para>voaf:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary defines some subclasses or subproperties of the object vocabulary, or local restrictions on those.</para>
    ///   <para>Indique que le vocabulaire sujet définit des sous-classes ou sous-propriétés du vocabulaire objet</para>
    /// labels<para>specializes</para><para>spécialise</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#specializes">http://purl.org/vocommons/voaf#specializes</seealso>
    let specializes = Prefixed_Name(voaf, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>voaf:toDoList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Liste des tâches prévues par le gestionnaire d'une ressource. Cette propriété est destinée à l'usage des gestionnaires de vocabulaires ou de jeu de données mais son doamine est ouvert, elle peut être utilisée pour n'importe quelle ressource. Utiliser la classe ical:Vtodo pour une description fine des tâches : calendrier, priorités etc</para>
    ///   <para>Describes future tasks planned by a resource curator. This property is primarily intended to be used for vocabularies or datasets, but the domain is left open, it can be used for any resource. Use iCalendar Vtodo class and its properties to further describe the task calendar, priorities etc.</para>
    /// labels<para>liste des choses à faire</para><para>to-do list</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#toDoList">http://purl.org/vocommons/voaf#toDoList</seealso>
    let toDoList = Prefixed_Name(voaf, "toDoList") |> PrefixedName
    /// <summary>
    ///   <para>voaf:metadataVoc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary uses the object vocabulary in metadata at global vocabulary level or at element level</para>
    ///   <para>Indique que le vocabulaire sujet utilise le vocabulaire objet pour décrire ses métadonnées, au niveau global du vocabulaire ou au niveau des éléments</para>
    /// labels<para>vocabulaire de métadonnées</para><para>metadata vocabulary</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#metadataVoc">http://purl.org/vocommons/voaf#metadataVoc</seealso>
    let metadataVoc = Prefixed_Name(voaf, "metadataVoc") |> PrefixedName
    /// <summary>
    ///   <para>voaf:occurrences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Number of occurrences of a vocabulary in a dataset</para>
    ///   <para>nombre d'occurrences d'un vocabulaire dans un dataset</para>
    /// labels<para>occurrences</para><para>occurrences</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#occurrences">http://purl.org/vocommons/voaf#occurrences</seealso>
    let occurrences = Prefixed_Name(voaf, "occurrences") |> PrefixedName

    /// <summary>
    ///   <para>voaf:occurrencesInVocabularies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of vocabularies using a resource</para>
    ///   <para>Nombre de vocabulaires utilisant une ressource.</para>
    /// labels<para>occurences dans des vocabulaires</para><para>occurrences in vocabularies</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#occurrencesInVocabularies">http://purl.org/vocommons/voaf#occurrencesInVocabularies</seealso>
    let occurrencesInVocabularies =
        Prefixed_Name(voaf, "occurrencesInVocabularies") |> PrefixedName

    /// <summary>
    ///   <para>voaf:reusedByVocabularies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Distinct number of vocabularies reusing a resource.</para>
    ///   <para>Nombre distinct de vocabulaires reutilisant une resource.</para>
    /// labels<para>réutilisé par des vocabulaires</para><para>reused by vocabularies</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#reusedByVocabularies">http://purl.org/vocommons/voaf#reusedByVocabularies</seealso>
    let reusedByVocabularies =
        Prefixed_Name(voaf, "reusedByVocabularies") |> PrefixedName

    /// <summary>
    ///   <para>voaf:similar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Used to assert that two vocabularies are similar in scope and objectives, independently of the fact that they otherwise refer to each other.</para>
    ///   <para>Indique que deux vocabulaires sont similaires dans leur domaine et/ou leurs objectifs, sans être nécessairement reliés par des références.</para>
    /// labels<para>similaire</para><para>similar</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#similar">http://purl.org/vocommons/voaf#similar</seealso>
    let similar = Prefixed_Name(voaf, "similar") |> PrefixedName
    /// <summary>
    ///   <para>voaf:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the subject vocabulary is used by the object vocabulary</para>
    ///   <para>Indique que le vocabulaire sujet est utilisé par le vocabulaire objet</para>
    /// labels<para>utilisé par</para><para>used by</para></remarks>
    /// <seealso href="http://purl.org/vocommons/voaf#usedBy">http://purl.org/vocommons/voaf#usedBy</seealso>
    let usedBy = Prefixed_Name(voaf, "usedBy") |> PrefixedName

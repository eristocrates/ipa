namespace https.w3id.org.vocab.lingvoj.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lingvo =
    let _namespace_iri = Namespace_Iri lingvo |> NamespaceIRI
    /// <summary>
    ///   <para>lingvo:LanguageResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Woordenboeken, thesauri, taalcursussen, vertaaldiensten, etc.</para>
    ///   <para>辞書、シソーラス、言語コース、翻訳サービスなど</para>
    ///   <para>Dictionaries, thesauri, language courses, translation services, etc.</para>
    ///   <para>Dicionários, tesauros, cursos de idiomas, serviços de tradução, etc.</para>
    ///   <para>Dictionnaires, thesaurus, cours de langue, services de traduction, etc.</para>
    ///   <para>Diccionarios, tesauros, cursos de idiomas, servicios de traducción, etc.</para>
    /// labels<para>Ressource linguistique</para><para>Recurso linguístico</para><para>Recurso lingüístico</para><para>Language resource</para><para>Taal bron</para><para>言語資源</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#LanguageResource">https://w3id.org/vocab/lingvoj#LanguageResource</seealso>
    let LanguageResource = Prefixed_Name(lingvo, "LanguageResource") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:notRead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>その人はその言語をまったく読まない</para>
    ///   <para>The person does not read at all the language</para>
    ///   <para>De persoon leest de taal in het geheel niet</para>
    ///   <para>La personne ne lit pas du tout la langue</para>
    ///   <para>La persona no puede leer la lengua</para>
    ///   <para>A pessoa não sabe ler o idioma</para>
    /// labels<para>niet lezen</para><para>no leído</para><para>not read</para><para>não lido</para><para>non lue</para><para>読まれない</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#notRead">https://w3id.org/vocab/lingvoj#notRead</seealso>
    let notRead = Prefixed_Name(lingvo, "notRead") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:notUnderstood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A pessoa não compreende o idioma falado</para>
    ///   <para>その人はその話し言葉をまったく理解しない</para>
    ///   <para>La persona no comprende la lengua hablada</para>
    ///   <para>De persoon verstaat de taal in het geheel niet</para>
    ///   <para>La personne ne comprend pas du tout la langue parlée</para>
    ///   <para>The person does not understand at all the spoken language</para>
    /// labels<para>não compreendido</para><para>no comprendido</para><para>not understood</para><para>niet verstaan</para><para>non comprise</para><para>理解されない</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#notUnderstood">https://w3id.org/vocab/lingvoj#notUnderstood</seealso>
    let notUnderstood = Prefixed_Name(lingvo, "notUnderstood") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:notSpoken</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La persona no puede hablar la lengua</para>
    ///   <para>The person does not speak at all the language</para>
    ///   <para>De persoon spreekt de taal in het geheel niet</para>
    ///   <para>A pessoa não sabe falar o idioma</para>
    ///   <para>その人はその言語をまったく話さない</para>
    ///   <para>La personne ne parle pas du tout la langue</para>
    /// labels<para>niet spreken</para><para>not spoken</para><para>não falado</para><para>non parlée</para><para>no hablado</para><para>話されない</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#notSpoken">https://w3id.org/vocab/lingvoj#notSpoken</seealso>
    let notSpoken = Prefixed_Name(lingvo, "notSpoken") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:notWritten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person does not write at all the language</para>
    ///   <para>その人はその言語をまったく書かない</para>
    ///   <para>De persoon schrijft de taal in het geheel niet</para>
    ///   <para>La persona no puede escribir la lengua</para>
    ///   <para>La personne n'écrit pas du tout la langue</para>
    ///   <para>A pessoa não sabe escrever no idioma</para>
    /// labels<para>niet schrijven</para><para>not written</para><para>não escrito</para><para>no escrito</para><para>non écrite</para><para>書かれない</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#notWritten">https://w3id.org/vocab/lingvoj#notWritten</seealso>
    let notWritten = Prefixed_Name(lingvo, "notWritten") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:officialIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>langue officielle de</para><para>official language of</para><para>lengua oficial de</para><para>idioma oficial de</para><para>officiële taal</para><para>～の公用語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#officialIn">https://w3id.org/vocab/lingvoj#officialIn</seealso>
    let officialIn = Prefixed_Name(lingvo, "officialIn") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:officialLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Une langue officielle d'un pays, d'une organisation, d'un projet ou d'un événement</para>
    ///   <para>国、プロジェクト、組織やイベントの公用語</para>
    ///   <para>Una lengua oficial en un país, proyecto, organización o evento</para>
    ///   <para>An official language of a country, project, organization or event</para>
    ///   <para>De officiële taal van een land, organisatie, prject of evenement</para>
    ///   <para>Um idioma oficial de um país, projecto, organização ou evento</para>
    /// labels<para>langue officielle</para><para>official language</para><para>officiële taal</para><para>lengua oficial</para><para>idioma oficial</para><para>公用語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#officialLanguage">https://w3id.org/vocab/lingvoj#officialLanguage</seealso>
    let officialLanguage = Prefixed_Name(lingvo, "officialLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:interpreter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An agent (person or software) responsible of a real-time oral translation</para>
    ///   <para>Um agente (pessoa ou programa) responsável por uma tradução oral em tempo real</para>
    ///   <para>De agent (persoon of applicatie) verantwoordelijk voor het tolken</para>
    ///   <para>Un agente (persona, organización o software) responsable de la interpretación oral</para>
    ///   <para>即時の通訳に責任を持つエージェント（人またはソフトウェア）</para>
    ///   <para>Un agent (personne ou logiciel) responsable de la traduction orale en temps réel</para>
    /// labels<para>interpreter</para><para>interprete</para><para>intérprete</para><para>interprète</para><para>tolk</para><para>通訳者</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#interpreter">https://w3id.org/vocab/lingvoj#interpreter</seealso>
    let interpreter = Prefixed_Name(lingvo, "interpreter") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:translator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De agent (persoon, organisatie of applicatie) verantwoordelijk voor de vertaling</para>
    ///   <para>翻訳に責任を持つエージェント（人、組織またはソフトウェア）</para>
    ///   <para>Un agente (persona, organización o software) responsable de la traducción</para>
    ///   <para>An agent (person, organization or sofware) responsible of the translation</para>
    ///   <para>Un agent (personne, organisation ou logiciel) responsable de la traduction</para>
    ///   <para>um agente (pessoa, organização ou programa) responsável pela tradução</para>
    /// labels<para>traducteur</para><para>translator</para><para>traductor</para><para>tradutor</para><para>vertaler</para><para>翻訳者</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#translator">https://w3id.org/vocab/lingvoj#translator</seealso>
    let translator = Prefixed_Name(lingvo, "translator") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:iso2b</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#iso2b">https://w3id.org/vocab/lingvoj#iso2b</seealso>
    let iso2b = Prefixed_Name(lingvo, "iso2b") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:iso2t</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#iso2t">https://w3id.org/vocab/lingvoj#iso2t</seealso>
    let iso2t = Prefixed_Name(lingvo, "iso2t") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:iso3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#iso3">https://w3id.org/vocab/lingvoj#iso3</seealso>
    let iso3 = Prefixed_Name(lingvo, "iso3") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:minorityLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ある国の少数の人々（必ずしも特定地域ではない）が話す言語</para>
    ///   <para>O idioma falado por uma minoria num país, mas não necessariamente numa região específica</para>
    ///   <para>Une langue parlée par une minorité dans un pays, mais pas nécessairement dans une région spécifique</para>
    ///   <para>A language spoken by a minority in some country, but not necessarily in a specific region</para>
    ///   <para>Een taal die door een minderheid van de bevolking van een land gesproken wordt, maar niet noodzakelijkerwijs in een specifieke regio</para>
    ///   <para>Un lengua hablada por una minoría en algún país, pero no necesariamente en una región específica</para>
    /// labels<para>langue minoritaire</para><para>lengua minoritaria</para><para>idioma minoritário</para><para>minority language</para><para>minderheidstaal</para><para>少数言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#minorityLanguage">https://w3id.org/vocab/lingvoj#minorityLanguage</seealso>
    let minorityLanguage = Prefixed_Name(lingvo, "minorityLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:iso1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#iso1">https://w3id.org/vocab/lingvoj#iso1</seealso>
    let iso1 = Prefixed_Name(lingvo, "iso1") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:mainLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una lengua ampliamente hablada en un lugar (país, región, ciudad...)</para>
    ///   <para>O idioma principal utilizado num local ou recurso linguístico</para>
    ///   <para>De meest gebruikte taal op deze plek (land, regio, stad ...)</para>
    ///   <para>La langue principale utilisée dans le lieu ou la ressource linguistique</para>
    ///   <para>その場所または言語資源で用いられる主要言語</para>
    ///   <para>The main language used in the place or language resource </para>
    /// labels<para>langue principale</para><para>Idioma principal</para><para>lengua principal</para><para>main language</para><para>hoofdtaal</para><para>主要言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#mainLanguage">https://w3id.org/vocab/lingvoj#mainLanguage</seealso>
    let mainLanguage = Prefixed_Name(lingvo, "mainLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:Lingvo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Een taal gebruikt in geschreven of gesproken communicatie tussen mensen of in welke een bron is geschreven of opgenomen. Het is aan te raden instanties te gebruiken gedefinieerd op basis van de ISO 630 codes, zoals in deze voorbeelden</para>
    ///   <para>Une langue utilisée dans la communication orale ou écrite entre humains, ou dans laquelle une ressource est écrite ou enregistrée. Il est recommandé d'utiliser des instances définies sur la base d'un code ISO 639, comme dans les exemples</para>
    ///   <para>Una lengua utilizada en la comunicación oral o escrita entre personas, o en la que se escribe o graba un recurso. Se recomienda el uso de las instancias definidas según los códigos ISO 639, como los que aparecen en los ejemplos</para>
    ///   <para>会話または記述による人間のコミュニケーションで使用される言語、または資源が記述または記録される言語。例にあるような、ISO 639コードに基づいて定義されたインスタンスを使用することが推奨される</para>
    ///   <para>Um idioma utilizado na comunicação oral ou escrita entre pessoas, ou na que se escreve ou grava um recurso. Recomenda-se a utilização das instâncias definidas segundo os códigos ISO 639, como os que aparecem nos excemplos</para>
    ///   <para>A language used in spoken or written human communication, or in which a resource is written or recorded. It is recommended to use instances defined on the basis of ISO 639 codes, such as those in examples</para>
    /// labels<para>Linguaggio</para><para>Language</para><para>Lenguaje</para><para>Sprache</para><para>Idioma</para><para>Lingvo</para><para>Langue</para><para>Jezyk</para><para>Språk</para><para>Språk</para><para>Kieli</para><para>Язык</para><para>Taal</para><para>Dil</para><para>言語</para><para>语言</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#Lingvo">https://w3id.org/vocab/lingvoj#Lingvo</seealso>
    let Lingvo = Prefixed_Name(lingvo, "Lingvo") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:original_resource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#original_resource">https://w3id.org/vocab/lingvoj#original_resource</seealso>
    let original_resource = Prefixed_Name(lingvo, "original_resource") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:regionalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una lengua hablada en una región o un país</para>
    ///   <para>Um idioma falado num região de um país</para>
    ///   <para>ある国のある地域で話される言語</para>
    ///   <para>A language spoken in a region of a country</para>
    ///   <para>Een taal gesproken in bepaalde streek van een land</para>
    ///   <para>Une langue parlée dans une région d'un pays</para>
    /// labels<para>regional language</para><para>langue régionale</para><para>lengua regional</para><para>idioma regional</para><para>streektaal</para><para>地方言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#regionalLanguage">https://w3id.org/vocab/lingvoj#regionalLanguage</seealso>
    let regionalLanguage = Prefixed_Name(lingvo, "regionalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:supportingResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A language resource for this language</para>
    ///   <para>Une ressource linguistique pour cette langue</para>
    ///   <para>Un recurso lingüístico para este idioma</para>
    ///   <para>Een taal bron voor deze taal</para>
    ///   <para>この言語の言語資源</para>
    ///   <para>Um recurso linguístico para este idioma</para>
    /// labels<para>ondersteunende bron</para><para>recurso soportado</para><para>ressource support</para><para>recurso suportado</para><para>support resource</para><para>サポート資源</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#supportingResource">https://w3id.org/vocab/lingvoj#supportingResource</seealso>
    let supportingResource = Prefixed_Name(lingvo, "supportingResource") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:translatedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>翻訳タイトルは、Translation（翻訳）自体のプロパティーではなく、翻訳された資源のプロパティー（dcterms:titleを使用）</para>
    ///   <para>The translated title is a property of the translated resource (use dcterms:title) and not a property of the Translation itself</para>
    ///   <para>Le titre traduit est une propriété de la ressource traduite (utiliser dcterms:title) et non une propriété de la Traduction elle-même</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#translatedTitle">https://w3id.org/vocab/lingvoj#translatedTitle</seealso>
    let translatedTitle = Prefixed_Name(lingvo, "translatedTitle") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:Translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>De beschrijving of een vertaling zou de oorspronkelijke bron, de vertaalde bron, de brontaal en de doeltaal moeten bevatten. Het kan ook de vertaler(s), de vertaaldatum en andere relevante informatie, gebruik makend van de eigenschappen geërfd van de generieke Event klasse, bevatten</para>
    ///   <para>Translation（翻訳）の記述には、元の資源、翻訳後の資源、元の言語および翻訳先の言語が含まれているべきである。さらに、それには、翻訳者と翻訳日、そして、汎用的なEventクラスから継承されたプロパティーを用いた、関連するその他の情報が含まれるかもしれない</para>
    ///   <para>Descrição de uma tradução deverá inclrui o recurso original, o recurso traduzido, o idioma original e o idioma de destino. Também pode incluir o(s)/a(s) tradutore(s)/tradutora(s), a data de tradução e outra informação relevante utilizando propriedades herdadas da classe genérica Event</para>
    ///   <para>La description d'une Traduction inclut au minimum la ressource originale, la ressource traduite, la langue d'origine et la langue cible. Elle peut aussi inclure le(s) traducteur(s), la date de traduction, et toute autre information pertinente utilisant les propriétés de la classe générique Evénement</para>
    ///   <para>La descripción de una Traducción debe incluir la fuente original, la fuente traducida, la lengua  original y la lengua de  destino. También puede incluir  el o los traductor(es) , la fecha de traducción y otra información relevante utilizando propiedades heredadas de la clase generica Event</para>
    ///   <para>Description of a Translation should include original resource, translated resource, original language and target language. It might also include translator(s) and translation date, and relevant other information using properties inherited from the generic Event class</para>
    /// labels<para>Translation</para><para>Traduction</para><para>Traducción</para><para>Vertaling</para><para>Tradução</para><para>翻訳</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#Translation">https://w3id.org/vocab/lingvoj#Translation</seealso>
    let Translation = Prefixed_Name(lingvo, "Translation") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasAbility3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasAbility3">https://w3id.org/vocab/lingvoj#hasAbility3</seealso>
    let hasAbility3 = Prefixed_Name(lingvo, "hasAbility3") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:advancedSpeaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La personne parle la langue à un bon niveau</para>
    ///   <para>La persona puede hablar la lengua a un nivel avanzado</para>
    ///   <para>De persoon kan de taal goed spreken</para>
    ///   <para>A pessoa consegue falar o idioma a um nível avançado</para>
    ///   <para>その人はその言語を上級レベルで話すことができる</para>
    ///   <para>The person can speak the language at an advanced level</para>
    /// labels<para>buena expresión oral</para><para>boa expressão oral</para><para>goed spraakniveau</para><para>advanced speaking</para><para>bonne expression</para><para>高度な会話</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#advancedSpeaking">https://w3id.org/vocab/lingvoj#advancedSpeaking</seealso>
    let advancedSpeaking = Prefixed_Name(lingvo, "advancedSpeaking") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:advancedUnderstanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person has an advanced understanding of the spoken language</para>
    ///   <para>La personne a une bonne compréhension de la langue parlée</para>
    ///   <para>La persona tiene un nivel avanzado de comprensión de la lengua hablada</para>
    ///   <para>その人はその話し言葉について高度な理解力を有している</para>
    ///   <para>De persoon kan de gesproken taal goed begrijpen</para>
    ///   <para>A pessoa possui uma compreensão avançada do idioma falado</para>
    /// labels<para>advanced understanding</para><para>compreensão avançada</para><para>bonne compréhension</para><para>goed luisterniveau</para><para>buena comprensión</para><para>高度な理解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#advancedUnderstanding">https://w3id.org/vocab/lingvoj#advancedUnderstanding</seealso>
    let advancedUnderstanding =
        Prefixed_Name(lingvo, "advancedUnderstanding") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:originalResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>翻訳元の資源</para>
    ///   <para>De vertaalde bron</para>
    ///   <para>o recurso que se traduz</para>
    ///   <para>La fuente que se traduce</para>
    ///   <para>La ressource qui est traduite</para>
    ///   <para>The resource which is translated</para>
    /// labels<para>oorspronkelijke bron</para><para>ressource originale</para><para>original resource</para><para>recurso original</para><para>recurso original</para><para>元の資源</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#originalResource">https://w3id.org/vocab/lingvoj#originalResource</seealso>
    let originalResource = Prefixed_Name(lingvo, "originalResource") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:originalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>元の資源の言語</para>
    ///   <para>The language of the original ressource</para>
    ///   <para>La lengua de la fuente original</para>
    ///   <para>De taal van de de bron</para>
    ///   <para>O idioma do recurso original</para>
    ///   <para>La langue de la ressource originale</para>
    /// labels<para>oorspronkelijke taal</para><para>original language</para><para>langue d'origine</para><para>idioma original</para><para>lengua original</para><para>元の言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#originalLanguage">https://w3id.org/vocab/lingvoj#originalLanguage</seealso>
    let originalLanguage = Prefixed_Name(lingvo, "originalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:originalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>原タイトルは、Translation（翻訳）自体のプロパティーではなく、元の資源のプロパティー（dcterms:titleを使用）</para>
    ///   <para>The original title is a property of the original resource (use dcterms:title) and not a property of the Translation itself</para>
    ///   <para>Le titre original est une propriété de la ressource originale (utiliser dcterms:title) et non une propriété de la Traduction elle-même</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#originalTitle">https://w3id.org/vocab/lingvoj#originalTitle</seealso>
    let originalTitle = Prefixed_Name(lingvo, "originalTitle") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:resourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A concept defining the type of the language resource</para>
    ///   <para>言語資源の種類を定義する概念</para>
    ///   <para>Un concepto que define el tipo de recurso lingüístico</para>
    ///   <para>Um conceito que define o tipo de recuso linguístico</para>
    ///   <para>Un concept définissant le type de la ressource linguistique</para>
    ///   <para>Een concept van het definiëren van de aard van de taal bron</para>
    /// labels<para>type de ressource</para><para>tipo de recurso</para><para>tipo de recurso</para><para>resource type</para><para>bron type</para><para>資源の種類</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#resourceType">https://w3id.org/vocab/lingvoj#resourceType</seealso>
    let resourceType = Prefixed_Name(lingvo, "resourceType") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:spokenLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A language which is spoken in some place or event</para>
    ///   <para>Een taal gesproken op een bepaalde plek of tijdens een evenement</para>
    ///   <para>Une langue parlée dans un lieu ou lors d'un événement</para>
    ///   <para>Una lengua que se habla en algún lugar o evento</para>
    ///   <para>ある場所やイベントで話される言語</para>
    ///   <para>O idioma que é falado num determinado lugar ou evento</para>
    /// labels<para>spoken language</para><para>gesproken taal</para><para>lengua hablada</para><para>idioma falado</para><para>langue parlée</para><para>話し言葉</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#spokenLanguage">https://w3id.org/vocab/lingvoj#spokenLanguage</seealso>
    let spokenLanguage = Prefixed_Name(lingvo, "spokenLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:supportedLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Een taal die wordt ondersteund door de taal bron</para>
    ///   <para>Une langue supportée par la ressource linguistique</para>
    ///   <para>Um idioma suportado pelo recurso linguístico</para>
    ///   <para>Un idioma soportado por el recurso lingüístico</para>
    ///   <para>言語資源でサポートされている言語</para>
    ///   <para>A language supported by the language resource</para>
    /// labels<para>supported language</para><para>ondersteunde taal</para><para>idioma suportado</para><para>idioma soportado</para><para>langue supportée</para><para>サポートされている言語 </para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#supportedLanguage">https://w3id.org/vocab/lingvoj#supportedLanguage</seealso>
    let supportedLanguage = Prefixed_Name(lingvo, "supportedLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le tag à utiliser pour la langue, par exemple comme valeur de xml:lang. Voir https://tools.ietf.org/html/bcp47</para>
    ///   <para>The tag to use for the language, for example as value of xml:lang. See https://tools.ietf.org/html/bcp47</para>
    ///   <para>La etiqueta a utilizar para el lenguaje, por ejemplo como valor de xml:lang. Ver https://tools.ietf.org/html/bcp47</para>
    ///   <para>A tag para ser usada, por exemplo como valor de xml:lang. Ver https://tools.ietf.org/html/bcp47</para>
    ///   <para>例えばxml:langの値として、言語に用いるタグ。https://tools.ietf.org/html/bcp47を参照</para>
    /// labels<para>tag de langue</para><para>tag de idioma</para><para>language tag</para><para>taal tag</para><para>etiqueta</para><para>言語タグ</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#tag">https://w3id.org/vocab/lingvoj#tag</seealso>
    let tag = Prefixed_Name(lingvo, "tag") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:targetLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The language of the translated ressource</para>
    ///   <para>De taal waarin de bron vertaald is</para>
    ///   <para>La langue de la ressource traduite</para>
    ///   <para>翻訳後の資源の言語</para>
    ///   <para>O idioma do recurso traduzido</para>
    ///   <para>La lengua de la fuente traducida</para>
    /// labels<para>target language</para><para>lengua destino</para><para>idioma destino</para><para>langue cible</para><para>doeltaal</para><para>翻訳先の言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#targetLanguage">https://w3id.org/vocab/lingvoj#targetLanguage</seealso>
    let targetLanguage = Prefixed_Name(lingvo, "targetLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:translatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Het resultaat van de vertaling</para>
    ///   <para>La ressource qui est le résultat de la traduction</para>
    ///   <para>翻訳の結果である資源</para>
    ///   <para>The resource which is the result of the translation</para>
    ///   <para>La fuente que resulta de la traducción</para>
    ///   <para>O recurso que é o resultado da tradução</para>
    /// labels<para>translated resource</para><para>ressource traduite</para><para>recurso traduzido</para><para>recurso traducido</para><para>vertaalde bron</para><para>翻訳後の資源</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#translatedResource">https://w3id.org/vocab/lingvoj#translatedResource</seealso>
    let translatedResource = Prefixed_Name(lingvo, "translatedResource") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:advancedReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La personne lit la langue à un bon niveau</para>
    ///   <para>その人はその言語を上級レベルで読むことができる</para>
    ///   <para>A pessoa consegue ler o idioma a um nível avançado</para>
    ///   <para>La persona puede leer la lengua a un nivel avanzado</para>
    ///   <para>The person can read the language at an advanced level</para>
    ///   <para>De persoon kan de taal goed lezen</para>
    /// labels<para>buen nivel de lectura</para><para>bon niveau de lecture</para><para>advanced reading</para><para>leitura avançada</para><para>goed leesniveau</para><para>高度な読解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#advancedReading">https://w3id.org/vocab/lingvoj#advancedReading</seealso>
    let advancedReading = Prefixed_Name(lingvo, "advancedReading") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:advancedWriting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La persona puede escribir la lengua a un nivel avanzado</para>
    ///   <para>The person can write the language at an advanced level</para>
    ///   <para>A pessoa consegue escrever o idioma a um nível avançado</para>
    ///   <para>La personne écrit la langue à un bon niveau</para>
    ///   <para>その人はその言語を上級レベルで書くことができる</para>
    ///   <para>De persoon kan de taal goed schrijven</para>
    /// labels<para>buen nivel de escritura</para><para>bon niveau d'écriture</para><para>goed schrijfniveau</para><para>escrita avançada</para><para>advanced writing</para><para>高度な記述</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#advancedWriting">https://w3id.org/vocab/lingvoj#advancedWriting</seealso>
    let advancedWriting = Prefixed_Name(lingvo, "advancedWriting") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:basicSpeaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>その人はその言語を基礎レベルで話すことができる</para>
    ///   <para>De persoon kan eenvoudige taal spreken</para>
    ///   <para>La persona puede hablar la lengua a un nivel básico</para>
    ///   <para>La personne parle la langue à un niveau élémentaire</para>
    ///   <para>The person can speak the language at a basic level</para>
    ///   <para>A pessoa consegue falar o idioma a um nível básico</para>
    /// labels<para>expression élémentaire</para><para>expressão oral básica</para><para>expresión oral básica</para><para>basis spraakniveau</para><para>basic speaking</para><para>基礎的な会話</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#basicSpeaking">https://w3id.org/vocab/lingvoj#basicSpeaking</seealso>
    let basicSpeaking = Prefixed_Name(lingvo, "basicSpeaking") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:hasCommunicationLanguage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasCommunicationLanguage">https://w3id.org/vocab/lingvoj#hasCommunicationLanguage</seealso>
    let hasCommunicationLanguage =
        Prefixed_Name(lingvo, "hasCommunicationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:expertWriting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La personne écrit la langue à un niveau excellent</para>
    ///   <para>La persona puede escribir la lengua a un nivel experto</para>
    ///   <para>その人はその言語を専門家レベルで書くことができる</para>
    ///   <para>A pessoa consegue escrever o idioma a um nível de especialista</para>
    ///   <para>De persoon kan de taal uitstekend schrijven</para>
    ///   <para>The person can write the language at an expert level</para>
    /// labels<para>escrita a um nível de especialista</para><para>nivel de escritura excelente</para><para>uitstekend schrijfniveau</para><para>excellente écriture</para><para>expert writing</para><para>専門家レベルの記述</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#expertWriting">https://w3id.org/vocab/lingvoj#expertWriting</seealso>
    let expertWriting = Prefixed_Name(lingvo, "expertWriting") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:extinctLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Er zijn geen mensen meer die deze taal spreken</para>
    ///   <para>The language has no longer any speaker at the given date</para>
    ///   <para>La lengua no tiene ningún hablante en la fecha dada</para>
    ///   <para>ある時点でその言語を話す人はいなくなった</para>
    ///   <para>La langue n'a plus de locuteurs à la date indiquée</para>
    ///   <para>O idioma já não possui pessoas que o falam na data indicada</para>
    /// labels<para>uitgestorven taal</para><para>extinct language</para><para>lengua muerta</para><para>Idioma morto</para><para>langue morte</para><para>死語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#extinctLanguage">https://w3id.org/vocab/lingvoj#extinctLanguage</seealso>
    let extinctLanguage = Prefixed_Name(lingvo, "extinctLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:basicReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person can read the language at a basic level</para>
    ///   <para>De persoon kan eenvoudige taal lezen</para>
    ///   <para>La persona puede leer la lengua a un nivel básico</para>
    ///   <para>A pessoa consegue ler o idioma a um nível básico</para>
    ///   <para>その人はその言語を基礎レベルで読むことができる</para>
    ///   <para>La personne lit la langue à un niveau élémentaire</para>
    /// labels<para>lecture élémentaire</para><para>basis leesniveau</para><para>lectura básica</para><para>leitura básica</para><para>basic reading</para><para>基礎的な読解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#basicReading">https://w3id.org/vocab/lingvoj#basicReading</seealso>
    let basicReading = Prefixed_Name(lingvo, "basicReading") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasAbility1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasAbility1">https://w3id.org/vocab/lingvoj#hasAbility1</seealso>
    let hasAbility1 = Prefixed_Name(lingvo, "hasAbility1") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:basicUnderstanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A pessoa tem um nível de compreensão básico do idioma falado</para>
    ///   <para>その人はその話し言語について基礎的な理解力を有している</para>
    ///   <para>La personne a une compréhension élémentaire de la langue parlée</para>
    ///   <para>La persona tiene un nivel básico de comprensión de la lengua hablada</para>
    ///   <para>The person has a basic understanding of the spoken language</para>
    ///   <para>De persoon kan eenvoudige gesproken taal begrijpen</para>
    /// labels<para>compréhension élémentaire</para><para>basis luisterniveau</para><para>basic understanding</para><para>entendimento básico</para><para>comprensión básica</para><para>基礎的な理解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#basicUnderstanding">https://w3id.org/vocab/lingvoj#basicUnderstanding</seealso>
    let basicUnderstanding = Prefixed_Name(lingvo, "basicUnderstanding") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:basicWriting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De persoon kan eenvoudige taal schrijven</para>
    ///   <para>La persona puede escribir la lengua a un nivel básico</para>
    ///   <para>A pessoa consegue escrever o idioma a um nível básico</para>
    ///   <para>La personne écrit la langue à un niveau élémentaire</para>
    ///   <para>その人はその言語を基礎レベルで書くことができる</para>
    ///   <para>The person can write the language at a basic level</para>
    /// labels<para>écriture élémentaire</para><para>basis schrijfniveau</para><para>escritura básica</para><para>escrita básica</para><para>basic writing</para><para>基礎的な記述</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#basicWriting">https://w3id.org/vocab/lingvoj#basicWriting</seealso>
    let basicWriting = Prefixed_Name(lingvo, "basicWriting") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:communicationLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A language used for external communication</para>
    ///   <para>Een taal gebruikt voor externe communicatie</para>
    ///   <para>外部とのコミュニケーションに用いる言語</para>
    ///   <para>Une langue utilisée pour la communication externe</para>
    ///   <para>Una lengua utilizada para la comunicación externa</para>
    ///   <para>Um idioma utilizado para a comunicação externa</para>
    /// labels<para>lenguaje de comunicación</para><para>langue de communication</para><para>communication language</para><para>idioma de comunicação</para><para>kommunikation taal</para><para>コミュニケーション言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#communicationLanguage">https://w3id.org/vocab/lingvoj#communicationLanguage</seealso>
    let communicationLanguage =
        Prefixed_Name(lingvo, "communicationLanguage") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:endangeredLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La lengua está en vías de extinción en la fecha dada</para>
    ///   <para>ある時点でその言語は絶滅寸前である</para>
    ///   <para>O idioma está em vias de extinção na data indicada</para>
    ///   <para>La langue est menacée à la date indiquée</para>
    ///   <para>The language is endangered at the given date</para>
    ///   <para>De taal is bedreigd met uitsterven op de gegeven datum</para>
    /// labels<para>lengua en vías de extinción</para><para>idioma em vias de extinção</para><para>endangered language</para><para>bedreigde taal</para><para>langue menacée</para><para>絶滅危惧言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#endangeredLanguage">https://w3id.org/vocab/lingvoj#endangeredLanguage</seealso>
    let endangeredLanguage = Prefixed_Name(lingvo, "endangeredLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:livingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ある時点でその言語を話す人がいる</para>
    ///   <para>La lengua tiene hablantes en la fecha dada</para>
    ///   <para>De taal wordt door mensen gesproken op het aangegeven moment</para>
    ///   <para>La langue possède des locuteurs à la date indiquée</para>
    ///   <para>O idioma possui pessoas que o falam na data indicada</para>
    ///   <para>The language has speakers at the given date</para>
    /// labels<para>living language</para><para>langue vivante</para><para>levende taal</para><para>lengua viva</para><para>Idioma vivo</para><para>現用言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#livingLanguage">https://w3id.org/vocab/lingvoj#livingLanguage</seealso>
    let livingLanguage = Prefixed_Name(lingvo, "livingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:expertReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De persoon kan de taal uitstekend lezen</para>
    ///   <para>The person can read the language at a expert level</para>
    ///   <para>その人はその言語を専門家レベルで読むことができる</para>
    ///   <para>La personne lit la langue à un niveau excellent</para>
    ///   <para>La persona puede leer en la lengua a un nivel experto</para>
    /// labels<para>leitura a um nível de especialista</para><para>nivel de lectura excelente</para><para>uitstekend leesniveau</para><para>excellente lecture</para><para>expert reading</para><para>専門家レベルの読解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#expertReading">https://w3id.org/vocab/lingvoj#expertReading</seealso>
    let expertReading = Prefixed_Name(lingvo, "expertReading") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasAbility4</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasAbility4">https://w3id.org/vocab/lingvoj#hasAbility4</seealso>
    let hasAbility4 = Prefixed_Name(lingvo, "hasAbility4") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:expertSpeaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>La persona puede hablar la lengua a un nivel experto</para>
    ///   <para>その人はその言語を専門家レベルで話すことができる</para>
    ///   <para>A pessoa consegue falar o idioma a um nível de especialista</para>
    ///   <para>The person can speak the language at an expert level</para>
    ///   <para>De persoon kan de taal uitstekend spreken</para>
    ///   <para>La personne parle la langue à niveau excellent</para>
    /// labels<para>expressão oral a um nível de especialista</para><para>expresión oral excelente</para><para>uitstekend spraakniveau</para><para>excellente expression</para><para>expert speaking</para><para>専門家レベルの会話</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#expertSpeaking">https://w3id.org/vocab/lingvoj#expertSpeaking</seealso>
    let expertSpeaking = Prefixed_Name(lingvo, "expertSpeaking") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:expertUnderstanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The person has an expert understanding of the spoken language</para>
    ///   <para>A pessoa tem um nível de especialista do idioma falado</para>
    ///   <para>La persona tiene un nivel experto de comprensión de la lengua hablada</para>
    ///   <para>La personne a une excellente compréhension de la langue parlée</para>
    ///   <para>De persoon kan de gesproken taal uitstekend begrijpen</para>
    ///   <para>その人はその話し言葉について専門家レベルの理解力を有している</para>
    /// labels<para>compreensão a um nível de especialista</para><para>excellente compréhension</para><para>uitstekend luisterniveau</para><para>comprensión excelente</para><para>expert understanding</para><para>専門家レベルの理解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#expertUnderstanding">https://w3id.org/vocab/lingvoj#expertUnderstanding</seealso>
    let expertUnderstanding =
        Prefixed_Name(lingvo, "expertUnderstanding") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:fromCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Pays d'origine de la langue</para>
    ///   <para>言語の起源の国</para>
    ///   <para>Country of origin of the language</para>
    ///   <para>Land van herkomst van de taal</para>
    ///   <para>País de origem do idioma</para>
    ///   <para>País de origen de la lengua</para>
    /// labels<para>land van herkomst</para><para>país de origen</para><para>pays d'origine</para><para>from country</para><para>do país</para><para>起源の国</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#fromCountry">https://w3id.org/vocab/lingvoj#fromCountry</seealso>
    let fromCountry = Prefixed_Name(lingvo, "fromCountry") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasAbility2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasAbility2">https://w3id.org/vocab/lingvoj#hasAbility2</seealso>
    let hasAbility2 = Prefixed_Name(lingvo, "hasAbility2") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:intermediateWriting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>その人はその言語を中級レベルで書くことができる</para>
    ///   <para>La personne écrit la langue à un niveau moyen</para>
    ///   <para>The person can write the language at an intermediate level</para>
    ///   <para>A pessoa consegue escrever o idioma com um nível intermédio</para>
    ///   <para>De persoon schrijft de taal op een gemiddeld niveau</para>
    ///   <para>La persona puede escribir la lengua a un nivel intermedio</para>
    /// labels<para>nivel escrito intermedio</para><para>gemiddeld schrijfniveau</para><para>intermediate writing</para><para>escrita intermédia</para><para>écriture moyenne</para><para>中級の記述</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#intermediateWriting">https://w3id.org/vocab/lingvoj#intermediateWriting</seealso>
    let intermediateWriting =
        Prefixed_Name(lingvo, "intermediateWriting") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:intermediateReading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A pessoa consegue ler o idioma a um nível intermédio</para>
    ///   <para>De persoon leest de taal op een gemiddeld niveau</para>
    ///   <para>その人はその言語を中級レベルで読むことができる</para>
    ///   <para>La persona puede leer la lengua a un nivel intermedio</para>
    ///   <para>La personne lit la langue à un niveau moyen</para>
    ///   <para>The person can read the language at a intermediate level</para>
    /// labels<para>nivel de lectura intermedio</para><para>gemiddeld leesniveau</para><para>intermediate reading</para><para>leitura intermédia</para><para>lecture moyenne</para><para>中級の読解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#intermediateReading">https://w3id.org/vocab/lingvoj#intermediateReading</seealso>
    let intermediateReading =
        Prefixed_Name(lingvo, "intermediateReading") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:intermediateSpeaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>その人はその言語を中級レベルで話すことができる</para>
    ///   <para>The person can speak the language at an intermediate level</para>
    ///   <para>De persoon spreekt de taal op een gemiddeld niveau</para>
    ///   <para>A pessoa consegue falar o idioma a um nível intermédio</para>
    ///   <para>La personne parle la langue à un niveau moyen</para>
    ///   <para>La persona puede hablar la lengua a un nivel intermedio</para>
    /// labels<para>gemiddeld spraakniveau</para><para>nivel oral intermedio</para><para>intermediate speaking</para><para>nivel oral intermédio</para><para>expression moyenne</para><para>中級の会話</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#intermediateSpeaking">https://w3id.org/vocab/lingvoj#intermediateSpeaking</seealso>
    let intermediateSpeaking =
        Prefixed_Name(lingvo, "intermediateSpeaking") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:intermediateUnderstanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>De persoon begrijpt de gesproken taal op een gemiddeld niveau</para>
    ///   <para>A pessoa possui um nível intermédio de compreensão do idioma falado</para>
    ///   <para>その人はその話し言葉について中級レベルの理解力を有している</para>
    ///   <para>La persona tiene un nivel intermedio de comprensión de la lengua hablada</para>
    ///   <para>The person has an intermediate understanding of the spoken language</para>
    ///   <para>La personne a une compréhension moyenne de la langue parlée</para>
    /// labels<para>intermediate understanding</para><para>comprensión intermedia</para><para>compreensão intermédia</para><para>compréhension moyenne</para><para>voertaal</para><para>中級の理解</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#intermediateUnderstanding">https://w3id.org/vocab/lingvoj#intermediateUnderstanding</seealso>
    let intermediateUnderstanding =
        Prefixed_Name(lingvo, "intermediateUnderstanding") |> PrefixedName

    /// <summary>
    ///   <para>lingvo:hasAbility5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasAbility5">https://w3id.org/vocab/lingvoj#hasAbility5</seealso>
    let hasAbility5 = Prefixed_Name(lingvo, "hasAbility5") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasNativeLanguage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasNativeLanguage">https://w3id.org/vocab/lingvoj#hasNativeLanguage</seealso>
    let hasNativeLanguage = Prefixed_Name(lingvo, "hasNativeLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:nativeLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>このプロパティーは、流暢さ、読解力、記述能力のレベルに依存しない</para>
    ///   <para>Esta propiedad es independiente de el nivel de fluidez o de las habilidades de lectura o escritura</para>
    ///   <para>This property is independent of the level of fluency, reading or writing ability</para>
    ///   <para>Esta propriedade é independente do nível de fluência, de leitura ou de escrita</para>
    ///   <para>Deze eigenschap is onafhankelijk van het niveau van spreken, lezen of schrijven</para>
    ///   <para>Cette propriété est indépendante du niveau de langue parlée, lue ou écrite</para>
    /// labels<para>langue maternelle</para><para>native language</para><para>lengua materna</para><para>moedertaal</para><para>idioma mãe</para><para>母国語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#nativeLanguage">https://w3id.org/vocab/lingvoj#nativeLanguage</seealso>
    let nativeLanguage = Prefixed_Name(lingvo, "nativeLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:hasWorkingLanguage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#hasWorkingLanguage">https://w3id.org/vocab/lingvoj#hasWorkingLanguage</seealso>
    let hasWorkingLanguage = Prefixed_Name(lingvo, "hasWorkingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:workingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>O idioma que o projecto ou organização usa para a comunicação interna</para>
    ///   <para>Una lengua que el proyecto o la organización utiliza para comunicación interna</para>
    ///   <para>プロジェクトや組織が内部コミュニケーションに用いる言語</para>
    ///   <para>De taal gebruikt voor interne communicatie door een organisatie of binnen een project</para>
    ///   <para>A language the project or organization uses for internal communication</para>
    ///   <para>Une langue utilisée par l'organisation ou le projet pour sa communication interne</para>
    /// labels<para>lenguaje de trabajo</para><para>idioma de trabalho</para><para>langue de travail</para><para>working language</para><para>werktaal</para><para>実用言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#workingLanguage">https://w3id.org/vocab/lingvoj#workingLanguage</seealso>
    let workingLanguage = Prefixed_Name(lingvo, "workingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>lingvo:historicalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Um idioma falado no passado num determinado lugar, não sendo já utilizado no presente</para>
    ///   <para>A language spoken in the past in this place, but not used anymore</para>
    ///   <para>Une langue parlée dans le passé dans ce lieu, mais plus utilisée aujourd'hui</para>
    ///   <para>Een taal die vroeger in dit gebied gesproken werd, maar wordt nu niet meer gebruikt</para>
    ///   <para>Una lengua hablada en el pasado en este lugar, pero ya no se utiliza</para>
    ///   <para>この場所で過去に話されていたが、もはや用いられていない言語</para>
    /// labels<para>historical language</para><para>langue historique</para><para>lengua histórica</para><para>idioma histórico</para><para>historische taal</para><para>歴史的言語</para></remarks>
    /// <seealso href="https://w3id.org/vocab/lingvoj#historicalLanguage">https://w3id.org/vocab/lingvoj#historicalLanguage</seealso>
    let historicalLanguage = Prefixed_Name(lingvo, "historicalLanguage") |> PrefixedName

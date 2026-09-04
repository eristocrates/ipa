#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lingvo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/vocab/lingvoj#" "lingvo"

    /// <summary>
    ///   <para>rdfs:label : Recurso lingüísticordfs:label : Language resourcerdfs:label : Taal bronrdfs:label : Ressource linguistiquerdfs:label : 言語資源rdfs:label : Recurso linguístico</para>
    ///   <para>rdfs:comment : 辞書、シソーラス、言語コース、翻訳サービスなどrdfs:comment : Woordenboeken, thesauri, taalcursussen, vertaaldiensten, etc.rdfs:comment : Diccionarios, tesauros, cursos de idiomas, servicios de traducción, etc.rdfs:comment : Dictionaries, thesauri, language courses, translation services, etc.rdfs:comment : Dicionários, tesauros, cursos de idiomas, serviços de tradução, etc.rdfs:comment : Dictionnaires, thesaurus, cours de langue, services de traduction, etc.</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#LanguageResource">lingvo:LanguageResource</a>
    /// </summary>
    let LanguageResource = _prefixId.prefix "LanguageResource"
    /// <summary>
    ///   <para>rdfs:label : Jezykrdfs:label : 言語rdfs:label : Kielirdfs:label : Lenguajerdfs:label : Dilrdfs:label : Linguaggiordfs:label : Taalrdfs:label : Språkrdfs:label : Idiomardfs:label : Languagerdfs:label : Språkrdfs:label : Languerdfs:label : Spracherdfs:label : Lingvordfs:label : Языкrdfs:label : 语言</para>
    ///   <para>rdfs:comment : 会話または記述による人間のコミュニケーションで使用される言語、または資源が記述または記録される言語。例にあるような、ISO 639コードに基づいて定義されたインスタンスを使用することが推奨されるrdfs:comment : Una lengua utilizada en la comunicación oral o escrita entre personas, o en la que se escribe o graba un recurso. Se recomienda el uso de las instancias definidas según los códigos ISO 639, como los que aparecen en los ejemplosrdfs:comment : Een taal gebruikt in geschreven of gesproken communicatie tussen mensen of in welke een bron is geschreven of opgenomen. Het is aan te raden instanties te gebruiken gedefinieerd op basis van de ISO 630 codes, zoals in deze voorbeeldenrdfs:comment : Um idioma utilizado na comunicação oral ou escrita entre pessoas, ou na que se escreve ou grava um recurso. Recomenda-se a utilização das instâncias definidas segundo os códigos ISO 639, como os que aparecem nos excemplosrdfs:comment : Une langue utilisée dans la communication orale ou écrite entre humains, ou dans laquelle une ressource est écrite ou enregistrée. Il est recommandé d'utiliser des instances définies sur la base d'un code ISO 639, comme dans les exemplesrdfs:comment : A language used in spoken or written human communication, or in which a resource is written or recorded. It is recommended to use instances defined on the basis of ISO 639 codes, such as those in examples</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#Lingvo">lingvo:Lingvo</a>
    /// </summary>
    let Lingvo = _prefixId.prefix "Lingvo"
    /// <summary>
    ///   <para>rdfs:comment : Description of a Translation should include original resource, translated resource, original language and target language. It might also include translator(s) and translation date, and relevant other information using properties inherited from the generic Event classrdfs:comment : Descrição de uma tradução deverá inclrui o recurso original, o recurso traduzido, o idioma original e o idioma de destino. Também pode incluir o(s)/a(s) tradutore(s)/tradutora(s), a data de tradução e outra informação relevante utilizando propriedades herdadas da classe genérica Eventrdfs:comment : De beschrijving of een vertaling zou de oorspronkelijke bron, de vertaalde bron, de brontaal en de doeltaal moeten bevatten. Het kan ook de vertaler(s), de vertaaldatum en andere relevante informatie, gebruik makend van de eigenschappen geërfd van de generieke Event klasse, bevattenrdfs:comment : La description d'une Traduction inclut au minimum la ressource originale, la ressource traduite, la langue d'origine et la langue cible. Elle peut aussi inclure le(s) traducteur(s), la date de traduction, et toute autre information pertinente utilisant les propriétés de la classe générique Evénementrdfs:comment : La descripción de una Traducción debe incluir la fuente original, la fuente traducida, la lengua  original y la lengua de  destino. También puede incluir  el o los traductor(es) , la fecha de traducción y otra información relevante utilizando propiedades heredadas de la clase generica Eventrdfs:comment : Translation（翻訳）の記述には、元の資源、翻訳後の資源、元の言語および翻訳先の言語が含まれているべきである。さらに、それには、翻訳者と翻訳日、そして、汎用的なEventクラスから継承されたプロパティーを用いた、関連するその他の情報が含まれるかもしれない</para>
    ///   <para>rdfs:label : Translationrdfs:label : Traductionrdfs:label : Traducciónrdfs:label : Traduçãordfs:label : 翻訳rdfs:label : Vertaling</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#Translation">lingvo:Translation</a>
    /// </summary>
    let Translation = _prefixId.prefix "Translation"
    /// <summary>
    ///   <para>rdfs:comment : その人はその言語を上級レベルで読むことができるrdfs:comment : La personne lit la langue à un bon niveaurdfs:comment : A pessoa consegue ler o idioma a um nível avançadordfs:comment : La persona puede leer la lengua a un nivel avanzadordfs:comment : De persoon kan de taal goed lezenrdfs:comment : The person can read the language at an advanced level</para>
    ///   <para>rdfs:label : buen nivel de lecturardfs:label : leitura avançadardfs:label : goed leesniveaurdfs:label : bon niveau de lecturerdfs:label : 高度な読解rdfs:label : advanced reading</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#advancedReading">lingvo:advancedReading</a>
    /// </summary>
    let advancedReading = _prefixId.prefix "advancedReading"
    /// <summary>
    ///   <para>rdfs:comment : De persoon kan de taal goed sprekenrdfs:comment : A pessoa consegue falar o idioma a um nível avançadordfs:comment : The person can speak the language at an advanced levelrdfs:comment : その人はその言語を上級レベルで話すことができるrdfs:comment : La personne parle la langue à un bon niveaurdfs:comment : La persona puede hablar la lengua a un nivel avanzado</para>
    ///   <para>rdfs:label : buena expresión oralrdfs:label : bonne expressionrdfs:label : advanced speakingrdfs:label : boa expressão oralrdfs:label : goed spraakniveaurdfs:label : 高度な会話</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#advancedSpeaking">lingvo:advancedSpeaking</a>
    /// </summary>
    let advancedSpeaking = _prefixId.prefix "advancedSpeaking"
    /// <summary>
    ///   <para>rdfs:comment : その人はその話し言葉について高度な理解力を有しているrdfs:comment : La persona tiene un nivel avanzado de comprensión de la lengua habladardfs:comment : De persoon kan de gesproken taal goed begrijpenrdfs:comment : The person has an advanced understanding of the spoken languagerdfs:comment : A pessoa possui uma compreensão avançada do idioma faladordfs:comment : La personne a une bonne compréhension de la langue parlée</para>
    ///   <para>rdfs:label : compreensão avançadardfs:label : buena comprensiónrdfs:label : advanced understandingrdfs:label : goed luisterniveaurdfs:label : bonne compréhensionrdfs:label : 高度な理解</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#advancedUnderstanding">lingvo:advancedUnderstanding</a>
    /// </summary>
    let advancedUnderstanding = _prefixId.prefix "advancedUnderstanding"
    /// <summary>
    ///   <para>rdfs:comment : The person can write the language at an advanced levelrdfs:comment : La persona puede escribir la lengua a un nivel avanzadordfs:comment : La personne écrit la langue à un bon niveaurdfs:comment : De persoon kan de taal goed schrijvenrdfs:comment : A pessoa consegue escrever o idioma a um nível avançadordfs:comment : その人はその言語を上級レベルで書くことができる</para>
    ///   <para>rdfs:label : escrita avançadardfs:label : goed schrijfniveaurdfs:label : bon niveau d'écriturerdfs:label : buen nivel de escriturardfs:label : 高度な記述rdfs:label : advanced writing</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#advancedWriting">lingvo:advancedWriting</a>
    /// </summary>
    let advancedWriting = _prefixId.prefix "advancedWriting"
    /// <summary>
    ///   <para>rdfs:label : lectura básicardfs:label : 基礎的な読解rdfs:label : basis leesniveaurdfs:label : lecture élémentairerdfs:label : leitura básicardfs:label : basic reading</para>
    ///   <para>rdfs:comment : La persona puede leer la lengua a un nivel básicordfs:comment : De persoon kan eenvoudige taal lezenrdfs:comment : La personne lit la langue à un niveau élémentairerdfs:comment : A pessoa consegue ler o idioma a um nível básicordfs:comment : その人はその言語を基礎レベルで読むことができるrdfs:comment : The person can read the language at a basic level</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#basicReading">lingvo:basicReading</a>
    /// </summary>
    let basicReading = _prefixId.prefix "basicReading"
    /// <summary>
    ///   <para>rdfs:comment : その人はその言語を基礎レベルで話すことができるrdfs:comment : La persona puede hablar la lengua a un nivel básicordfs:comment : La personne parle la langue à un niveau élémentairerdfs:comment : The person can speak the language at a basic levelrdfs:comment : De persoon kan eenvoudige taal sprekenrdfs:comment : A pessoa consegue falar o idioma a um nível básico</para>
    ///   <para>rdfs:label : basis spraakniveaurdfs:label : expresión oral básicardfs:label : expression élémentairerdfs:label : basic speakingrdfs:label : 基礎的な会話rdfs:label : expressão oral básica</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#basicSpeaking">lingvo:basicSpeaking</a>
    /// </summary>
    let basicSpeaking = _prefixId.prefix "basicSpeaking"
    /// <summary>
    ///   <para>rdfs:label : basis luisterniveaurdfs:label : entendimento básicordfs:label : basic understandingrdfs:label : compréhension élémentairerdfs:label : comprensión básicardfs:label : 基礎的な理解</para>
    ///   <para>rdfs:comment : その人はその話し言語について基礎的な理解力を有しているrdfs:comment : The person has a basic understanding of the spoken languagerdfs:comment : La personne a une compréhension élémentaire de la langue parléerdfs:comment : La persona tiene un nivel básico de comprensión de la lengua habladardfs:comment : A pessoa tem um nível de compreensão básico do idioma faladordfs:comment : De persoon kan eenvoudige gesproken taal begrijpen</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#basicUnderstanding">lingvo:basicUnderstanding</a>
    /// </summary>
    let basicUnderstanding = _prefixId.prefix "basicUnderstanding"
    /// <summary>
    ///   <para>rdfs:comment : La personne écrit la langue à un niveau élémentairerdfs:comment : The person can write the language at a basic levelrdfs:comment : A pessoa consegue escrever o idioma a um nível básicordfs:comment : De persoon kan eenvoudige taal schrijvenrdfs:comment : La persona puede escribir la lengua a un nivel básicordfs:comment : その人はその言語を基礎レベルで書くことができる</para>
    ///   <para>rdfs:label : basic writingrdfs:label : écriture élémentairerdfs:label : 基礎的な記述rdfs:label : escritura básicardfs:label : escrita básicardfs:label : basis schrijfniveau</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#basicWriting">lingvo:basicWriting</a>
    /// </summary>
    let basicWriting = _prefixId.prefix "basicWriting"
    /// <summary>
    ///   <para>rdfs:label : kommunikation taalrdfs:label : communication languagerdfs:label : lenguaje de comunicaciónrdfs:label : idioma de comunicaçãordfs:label : langue de communicationrdfs:label : コミュニケーション言語</para>
    ///   <para>rdfs:comment : 外部とのコミュニケーションに用いる言語rdfs:comment : Una lengua utilizada para la comunicación externardfs:comment : A language used for external communicationrdfs:comment : Um idioma utilizado para a comunicação externardfs:comment : Een taal gebruikt voor externe communicatierdfs:comment : Une langue utilisée pour la communication externe</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#communicationLanguage">lingvo:communicationLanguage</a>
    /// </summary>
    let communicationLanguage = _prefixId.prefix "communicationLanguage"
    /// <summary>
    ///   <para>rdfs:label : langue menacéerdfs:label : endangered languagerdfs:label : 絶滅危惧言語rdfs:label : bedreigde taalrdfs:label : idioma em vias de extinçãordfs:label : lengua en vías de extinción</para>
    ///   <para>rdfs:comment : La langue est menacée à la date indiquéerdfs:comment : ある時点でその言語は絶滅寸前であるrdfs:comment : De taal is bedreigd met uitsterven op de gegeven datumrdfs:comment : La lengua está en vías de extinción en la fecha dadardfs:comment : The language is endangered at the given daterdfs:comment : O idioma está em vias de extinção na data indicada</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#endangeredLanguage">lingvo:endangeredLanguage</a>
    /// </summary>
    let endangeredLanguage = _prefixId.prefix "endangeredLanguage"
    /// <summary>
    ///   <para>rdfs:label : leitura a um nível de especialistardfs:label : uitstekend leesniveaurdfs:label : expert readingrdfs:label : nivel de lectura excelenterdfs:label : excellente lecturerdfs:label : 専門家レベルの読解</para>
    ///   <para>rdfs:comment : La personne lit la langue à un niveau excellentrdfs:comment : The person can read the language at a expert levelrdfs:comment : その人はその言語を専門家レベルで読むことができるrdfs:comment : La persona puede leer en la lengua a un nivel expertordfs:comment : De persoon kan de taal uitstekend lezen</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#expertReading">lingvo:expertReading</a>
    /// </summary>
    let expertReading = _prefixId.prefix "expertReading"
    /// <summary>
    ///   <para>rdfs:comment : De persoon kan de taal uitstekend sprekenrdfs:comment : La personne parle la langue à niveau excellentrdfs:comment : The person can speak the language at an expert levelrdfs:comment : その人はその言語を専門家レベルで話すことができるrdfs:comment : A pessoa consegue falar o idioma a um nível de especialistardfs:comment : La persona puede hablar la lengua a un nivel experto</para>
    ///   <para>rdfs:label : expresión oral excelenterdfs:label : uitstekend spraakniveaurdfs:label : expressão oral a um nível de especialistardfs:label : excellente expressionrdfs:label : expert speakingrdfs:label : 専門家レベルの会話</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#expertSpeaking">lingvo:expertSpeaking</a>
    /// </summary>
    let expertSpeaking = _prefixId.prefix "expertSpeaking"
    /// <summary>
    ///   <para>rdfs:comment : De persoon kan de gesproken taal uitstekend begrijpenrdfs:comment : The person has an expert understanding of the spoken languagerdfs:comment : その人はその話し言葉について専門家レベルの理解力を有しているrdfs:comment : A pessoa tem um nível de especialista do idioma faladordfs:comment : La persona tiene un nivel experto de comprensión de la lengua habladardfs:comment : La personne a une excellente compréhension de la langue parlée</para>
    ///   <para>rdfs:label : expert understandingrdfs:label : uitstekend luisterniveaurdfs:label : comprensión excelenterdfs:label : excellente compréhensionrdfs:label : compreensão a um nível de especialistardfs:label : 専門家レベルの理解</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#expertUnderstanding">lingvo:expertUnderstanding</a>
    /// </summary>
    let expertUnderstanding = _prefixId.prefix "expertUnderstanding"
    /// <summary>
    ///   <para>rdfs:comment : A pessoa consegue escrever o idioma a um nível de especialistardfs:comment : La personne écrit la langue à un niveau excellentrdfs:comment : その人はその言語を専門家レベルで書くことができるrdfs:comment : De persoon kan de taal uitstekend schrijvenrdfs:comment : La persona puede escribir la lengua a un nivel expertordfs:comment : The person can write the language at an expert level</para>
    ///   <para>rdfs:label : expert writingrdfs:label : uitstekend schrijfniveaurdfs:label : escrita a um nível de especialistardfs:label : excellente écriturerdfs:label : nivel de escritura excelenterdfs:label : 専門家レベルの記述</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#expertWriting">lingvo:expertWriting</a>
    /// </summary>
    let expertWriting = _prefixId.prefix "expertWriting"
    /// <summary>
    ///   <para>rdfs:comment : ある時点でその言語を話す人はいなくなったrdfs:comment : Er zijn geen mensen meer die deze taal sprekenrdfs:comment : La lengua no tiene ningún hablante en la fecha dadardfs:comment : La langue n'a plus de locuteurs à la date indiquéerdfs:comment : The language has no longer any speaker at the given daterdfs:comment : O idioma já não possui pessoas que o falam na data indicada</para>
    ///   <para>rdfs:label : 死語rdfs:label : uitgestorven taalrdfs:label : lengua muertardfs:label : langue morterdfs:label : Idioma mortordfs:label : extinct language</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#extinctLanguage">lingvo:extinctLanguage</a>
    /// </summary>
    let extinctLanguage = _prefixId.prefix "extinctLanguage"
    /// <summary>
    ///   <para>rdfs:comment : 言語の起源の国rdfs:comment : Land van herkomst van de taalrdfs:comment : País de origem do idiomardfs:comment : Pays d'origine de la languerdfs:comment : País de origen de la lenguardfs:comment : Country of origin of the language</para>
    ///   <para>rdfs:label : land van herkomstrdfs:label : do paísrdfs:label : 起源の国rdfs:label : país de origenrdfs:label : from countryrdfs:label : pays d'origine</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#fromCountry">lingvo:fromCountry</a>
    /// </summary>
    let fromCountry = _prefixId.prefix "fromCountry"
    let hasAbility1 = _prefixId.prefix "hasAbility1"
    let hasAbility2 = _prefixId.prefix "hasAbility2"
    let hasAbility3 = _prefixId.prefix "hasAbility3"
    let hasAbility4 = _prefixId.prefix "hasAbility4"
    let hasAbility5 = _prefixId.prefix "hasAbility5"
    let hasCommunicationLanguage = _prefixId.prefix "hasCommunicationLanguage"
    let hasNativeLanguage = _prefixId.prefix "hasNativeLanguage"
    let hasWorkingLanguage = _prefixId.prefix "hasWorkingLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A language spoken in the past in this place, but not used anymorerdfs:comment : Een taal die vroeger in dit gebied gesproken werd, maar wordt nu niet meer gebruiktrdfs:comment : Um idioma falado no passado num determinado lugar, não sendo já utilizado no presenterdfs:comment : Une langue parlée dans le passé dans ce lieu, mais plus utilisée aujourd'huirdfs:comment : この場所で過去に話されていたが、もはや用いられていない言語rdfs:comment : Una lengua hablada en el pasado en este lugar, pero ya no se utiliza</para>
    ///   <para>rdfs:label : lengua históricardfs:label : historische taalrdfs:label : langue historiquerdfs:label : historical languagerdfs:label : 歴史的言語rdfs:label : idioma histórico</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#historicalLanguage">lingvo:historicalLanguage</a>
    /// </summary>
    let historicalLanguage = _prefixId.prefix "historicalLanguage"
    /// <summary>
    ///   <para>rdfs:comment : その人はその言語を中級レベルで読むことができるrdfs:comment : A pessoa consegue ler o idioma a um nível intermédiordfs:comment : De persoon leest de taal op een gemiddeld niveaurdfs:comment : La persona puede leer la lengua a un nivel intermediordfs:comment : La personne lit la langue à un niveau moyenrdfs:comment : The person can read the language at a intermediate level</para>
    ///   <para>rdfs:label : 中級の読解rdfs:label : leitura intermédiardfs:label : nivel de lectura intermediordfs:label : gemiddeld leesniveaurdfs:label : lecture moyennerdfs:label : intermediate reading</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#intermediateReading">lingvo:intermediateReading</a>
    /// </summary>
    let intermediateReading = _prefixId.prefix "intermediateReading"
    /// <summary>
    ///   <para>rdfs:comment : A pessoa consegue falar o idioma a um nível intermédiordfs:comment : La persona puede hablar la lengua a un nivel intermediordfs:comment : De persoon spreekt de taal op een gemiddeld niveaurdfs:comment : その人はその言語を中級レベルで話すことができるrdfs:comment : La personne parle la langue à un niveau moyenrdfs:comment : The person can speak the language at an intermediate level</para>
    ///   <para>rdfs:label : intermediate speakingrdfs:label : expression moyennerdfs:label : gemiddeld spraakniveaurdfs:label : nivel oral intermédiordfs:label : 中級の会話rdfs:label : nivel oral intermedio</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#intermediateSpeaking">lingvo:intermediateSpeaking</a>
    /// </summary>
    let intermediateSpeaking = _prefixId.prefix "intermediateSpeaking"
    /// <summary>
    ///   <para>rdfs:label : intermediate understandingrdfs:label : comprensión intermediardfs:label : 中級の理解rdfs:label : compréhension moyennerdfs:label : voertaalrdfs:label : compreensão intermédia</para>
    ///   <para>rdfs:comment : A pessoa possui um nível intermédio de compreensão do idioma faladordfs:comment : La persona tiene un nivel intermedio de comprensión de la lengua habladardfs:comment : その人はその話し言葉について中級レベルの理解力を有しているrdfs:comment : De persoon begrijpt de gesproken taal op een gemiddeld niveaurdfs:comment : La personne a une compréhension moyenne de la langue parléerdfs:comment : The person has an intermediate understanding of the spoken language</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#intermediateUnderstanding">lingvo:intermediateUnderstanding</a>
    /// </summary>
    let intermediateUnderstanding = _prefixId.prefix "intermediateUnderstanding"
    /// <summary>
    ///   <para>rdfs:label : écriture moyennerdfs:label : escrita intermédiardfs:label : nivel escrito intermediordfs:label : gemiddeld schrijfniveaurdfs:label : intermediate writingrdfs:label : 中級の記述</para>
    ///   <para>rdfs:comment : The person can write the language at an intermediate levelrdfs:comment : A pessoa consegue escrever o idioma com um nível intermédiordfs:comment : La persona puede escribir la lengua a un nivel intermediordfs:comment : La personne écrit la langue à un niveau moyenrdfs:comment : その人はその言語を中級レベルで書くことができるrdfs:comment : De persoon schrijft de taal op een gemiddeld niveau</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#intermediateWriting">lingvo:intermediateWriting</a>
    /// </summary>
    let intermediateWriting = _prefixId.prefix "intermediateWriting"
    /// <summary>
    ///   <para>rdfs:label : intérpreterdfs:label : interpreterdfs:label : interpreterrdfs:label : 通訳者rdfs:label : tolkrdfs:label : interprète</para>
    ///   <para>rdfs:comment : Un agente (persona, organización o software) responsable de la interpretación oralrdfs:comment : Un agent (personne ou logiciel) responsable de la traduction orale en temps réelrdfs:comment : Um agente (pessoa ou programa) responsável por uma tradução oral em tempo realrdfs:comment : De agent (persoon of applicatie) verantwoordelijk voor het tolkenrdfs:comment : 即時の通訳に責任を持つエージェント（人またはソフトウェア）rdfs:comment : An agent (person or software) responsible of a real-time oral translation</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#interpreter">lingvo:interpreter</a>
    /// </summary>
    let interpreter = _prefixId.prefix "interpreter"
    let iso1 = _prefixId.prefix "iso1"
    let iso2b = _prefixId.prefix "iso2b"
    let iso2t = _prefixId.prefix "iso2t"
    let iso3 = _prefixId.prefix "iso3"
    /// <summary>
    ///   <para>rdfs:comment : La langue possède des locuteurs à la date indiquéerdfs:comment : The language has speakers at the given daterdfs:comment : ある時点でその言語を話す人がいるrdfs:comment : La lengua tiene hablantes en la fecha dadardfs:comment : De taal wordt door mensen gesproken op het aangegeven momentrdfs:comment : O idioma possui pessoas que o falam na data indicada</para>
    ///   <para>rdfs:label : langue vivanterdfs:label : Idioma vivordfs:label : lengua vivardfs:label : living languagerdfs:label : 現用言語rdfs:label : levende taal</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#livingLanguage">lingvo:livingLanguage</a>
    /// </summary>
    let livingLanguage = _prefixId.prefix "livingLanguage"
    /// <summary>
    ///   <para>rdfs:comment : その場所または言語資源で用いられる主要言語rdfs:comment : O idioma principal utilizado num local ou recurso linguísticordfs:comment : Una lengua ampliamente hablada en un lugar (país, región, ciudad...)rdfs:comment : The main language used in the place or language resource rdfs:comment : De meest gebruikte taal op deze plek (land, regio, stad ...)rdfs:comment : La langue principale utilisée dans le lieu ou la ressource linguistique</para>
    ///   <para>rdfs:label : main languagerdfs:label : Idioma principalrdfs:label : 主要言語rdfs:label : lengua principalrdfs:label : hoofdtaalrdfs:label : langue principale</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#mainLanguage">lingvo:mainLanguage</a>
    /// </summary>
    let mainLanguage = _prefixId.prefix "mainLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Une langue parlée par une minorité dans un pays, mais pas nécessairement dans une région spécifiquerdfs:comment : O idioma falado por uma minoria num país, mas não necessariamente numa região específicardfs:comment : Een taal die door een minderheid van de bevolking van een land gesproken wordt, maar niet noodzakelijkerwijs in een specifieke regiordfs:comment : ある国の少数の人々（必ずしも特定地域ではない）が話す言語rdfs:comment : Un lengua hablada por una minoría en algún país, pero no necesariamente en una región específicardfs:comment : A language spoken by a minority in some country, but not necessarily in a specific region</para>
    ///   <para>rdfs:label : minderheidstaalrdfs:label : lengua minoritariardfs:label : 少数言語rdfs:label : idioma minoritáriordfs:label : langue minoritairerdfs:label : minority language</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#minorityLanguage">lingvo:minorityLanguage</a>
    /// </summary>
    let minorityLanguage = _prefixId.prefix "minorityLanguage"
    /// <summary>
    ///   <para>rdfs:label : langue maternellerdfs:label : 母国語rdfs:label : native languagerdfs:label : lengua maternardfs:label : idioma mãerdfs:label : moedertaal</para>
    ///   <para>rdfs:comment : Esta propiedad es independiente de el nivel de fluidez o de las habilidades de lectura o escriturardfs:comment : このプロパティーは、流暢さ、読解力、記述能力のレベルに依存しないrdfs:comment : This property is independent of the level of fluency, reading or writing abilityrdfs:comment : Esta propriedade é independente do nível de fluência, de leitura ou de escritardfs:comment : Cette propriété est indépendante du niveau de langue parlée, lue ou écriterdfs:comment : Deze eigenschap is onafhankelijk van het niveau van spreken, lezen of schrijven</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#nativeLanguage">lingvo:nativeLanguage</a>
    /// </summary>
    let nativeLanguage = _prefixId.prefix "nativeLanguage"
    /// <summary>
    ///   <para>rdfs:comment : A pessoa não sabe ler o idiomardfs:comment : La personne ne lit pas du tout la languerdfs:comment : La persona no puede leer la lenguardfs:comment : The person does not read at all the languagerdfs:comment : その人はその言語をまったく読まないrdfs:comment : De persoon leest de taal in het geheel niet</para>
    ///   <para>rdfs:label : não lidordfs:label : non luerdfs:label : niet lezenrdfs:label : 読まれないrdfs:label : not readrdfs:label : no leído</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#notRead">lingvo:notRead</a>
    /// </summary>
    let notRead = _prefixId.prefix "notRead"
    /// <summary>
    ///   <para>rdfs:comment : La persona no puede hablar la lenguardfs:comment : その人はその言語をまったく話さないrdfs:comment : La personne ne parle pas du tout la languerdfs:comment : A pessoa não sabe falar o idiomardfs:comment : De persoon spreekt de taal in het geheel nietrdfs:comment : The person does not speak at all the language</para>
    ///   <para>rdfs:label : non parléerdfs:label : no habladordfs:label : 話されないrdfs:label : não faladordfs:label : niet sprekenrdfs:label : not spoken</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#notSpoken">lingvo:notSpoken</a>
    /// </summary>
    let notSpoken = _prefixId.prefix "notSpoken"
    /// <summary>
    ///   <para>rdfs:comment : A pessoa não compreende o idioma faladordfs:comment : De persoon verstaat de taal in het geheel nietrdfs:comment : La persona no comprende la lengua habladardfs:comment : The person does not understand at all the spoken languagerdfs:comment : その人はその話し言葉をまったく理解しないrdfs:comment : La personne ne comprend pas du tout la langue parlée</para>
    ///   <para>rdfs:label : não compreendidordfs:label : no comprendidordfs:label : not understoodrdfs:label : 理解されないrdfs:label : non compriserdfs:label : niet verstaan</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#notUnderstood">lingvo:notUnderstood</a>
    /// </summary>
    let notUnderstood = _prefixId.prefix "notUnderstood"
    /// <summary>
    ///   <para>rdfs:label : non écriterdfs:label : no escritordfs:label : niet schrijvenrdfs:label : not writtenrdfs:label : 書かれないrdfs:label : não escrito</para>
    ///   <para>rdfs:comment : その人はその言語をまったく書かないrdfs:comment : De persoon schrijft de taal in het geheel nietrdfs:comment : The person does not write at all the languagerdfs:comment : A pessoa não sabe escrever no idiomardfs:comment : La persona no puede escribir la lenguardfs:comment : La personne n'écrit pas du tout la langue</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#notWritten">lingvo:notWritten</a>
    /// </summary>
    let notWritten = _prefixId.prefix "notWritten"
    /// <summary>
    ///   <para>rdfs:label : idioma oficial derdfs:label : officiële taalrdfs:label : langue officielle derdfs:label : ～の公用語rdfs:label : lengua oficial derdfs:label : official language of</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#officialIn">lingvo:officialIn</a>
    /// </summary>
    let officialIn = _prefixId.prefix "officialIn"
    /// <summary>
    ///   <para>rdfs:label : langue officiellerdfs:label : officiële taalrdfs:label : idioma oficialrdfs:label : 公用語rdfs:label : lengua oficialrdfs:label : official language</para>
    ///   <para>rdfs:comment : De officiële taal van een land, organisatie, prject of evenementrdfs:comment : An official language of a country, project, organization or eventrdfs:comment : Um idioma oficial de um país, projecto, organização ou eventordfs:comment : Una lengua oficial en un país, proyecto, organización o eventordfs:comment : 国、プロジェクト、組織やイベントの公用語rdfs:comment : Une langue officielle d'un pays, d'une organisation, d'un projet ou d'un événement</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#officialLanguage">lingvo:officialLanguage</a>
    /// </summary>
    let officialLanguage = _prefixId.prefix "officialLanguage"
    /// <summary>
    ///   <para>rdfs:label : lengua originalrdfs:label : langue d'originerdfs:label : oorspronkelijke taalrdfs:label : idioma originalrdfs:label : 元の言語rdfs:label : original language</para>
    ///   <para>rdfs:comment : O idioma do recurso originalrdfs:comment : The language of the original ressourcerdfs:comment : La langue de la ressource originalerdfs:comment : La lengua de la fuente originalrdfs:comment : De taal van de de bronrdfs:comment : 元の資源の言語</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#originalLanguage">lingvo:originalLanguage</a>
    /// </summary>
    let originalLanguage = _prefixId.prefix "originalLanguage"
    /// <summary>
    ///   <para>rdfs:label : oorspronkelijke bronrdfs:label : ressource originalerdfs:label : recurso originalrdfs:label : recurso originalrdfs:label : original resourcerdfs:label : 元の資源</para>
    ///   <para>rdfs:comment : De vertaalde bronrdfs:comment : La fuente que se traducerdfs:comment : 翻訳元の資源rdfs:comment : The resource which is translatedrdfs:comment : La ressource qui est traduiterdfs:comment : o recurso que se traduz</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#originalResource">lingvo:originalResource</a>
    /// </summary>
    let originalResource = _prefixId.prefix "originalResource"
    let originalTitle = _prefixId.prefix "originalTitle"
    let original_resource = _prefixId.prefix "original_resource"
    /// <summary>
    ///   <para>rdfs:comment : Une langue parlée dans une région d'un paysrdfs:comment : Una lengua hablada en una región o un paísrdfs:comment : Een taal gesproken in bepaalde streek van een landrdfs:comment : Um idioma falado num região de um paísrdfs:comment : A language spoken in a region of a countryrdfs:comment : ある国のある地域で話される言語</para>
    ///   <para>rdfs:label : lengua regionalrdfs:label : regional languagerdfs:label : 地方言語rdfs:label : idioma regionalrdfs:label : streektaalrdfs:label : langue régionale</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#regionalLanguage">lingvo:regionalLanguage</a>
    /// </summary>
    let regionalLanguage = _prefixId.prefix "regionalLanguage"
    /// <summary>
    ///   <para>rdfs:label : bron typerdfs:label : type de ressourcerdfs:label : tipo de recursordfs:label : tipo de recursordfs:label : 資源の種類rdfs:label : resource type</para>
    ///   <para>rdfs:comment : Um conceito que define o tipo de recuso linguísticordfs:comment : Un concept définissant le type de la ressource linguistiquerdfs:comment : A concept defining the type of the language resourcerdfs:comment : Een concept van het definiëren van de aard van de taal bronrdfs:comment : 言語資源の種類を定義する概念rdfs:comment : Un concepto que define el tipo de recurso lingüístico</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#resourceType">lingvo:resourceType</a>
    /// </summary>
    let resourceType = _prefixId.prefix "resourceType"
    /// <summary>
    ///   <para>rdfs:comment : Een taal gesproken op een bepaalde plek of tijdens een evenementrdfs:comment : A language which is spoken in some place or eventrdfs:comment : Una lengua que se habla en algún lugar o eventordfs:comment : Une langue parlée dans un lieu ou lors d'un événementrdfs:comment : O idioma que é falado num determinado lugar ou eventordfs:comment : ある場所やイベントで話される言語</para>
    ///   <para>rdfs:label : langue parléerdfs:label : gesproken taalrdfs:label : spoken languagerdfs:label : idioma faladordfs:label : 話し言葉rdfs:label : lengua hablada</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#spokenLanguage">lingvo:spokenLanguage</a>
    /// </summary>
    let spokenLanguage = _prefixId.prefix "spokenLanguage"
    /// <summary>
    ///   <para>rdfs:label : サポートされている言語 rdfs:label : langue supportéerdfs:label : ondersteunde taalrdfs:label : idioma soportadordfs:label : supported languagerdfs:label : idioma suportado</para>
    ///   <para>rdfs:comment : Um idioma suportado pelo recurso linguísticordfs:comment : Une langue supportée par la ressource linguistiquerdfs:comment : 言語資源でサポートされている言語rdfs:comment : Un idioma soportado por el recurso lingüísticordfs:comment : A language supported by the language resourcerdfs:comment : Een taal die wordt ondersteund door de taal bron</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#supportedLanguage">lingvo:supportedLanguage</a>
    /// </summary>
    let supportedLanguage = _prefixId.prefix "supportedLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Un recurso lingüístico para este idiomardfs:comment : Um recurso linguístico para este idiomardfs:comment : A language resource for this languagerdfs:comment : Een taal bron voor deze taalrdfs:comment : この言語の言語資源rdfs:comment : Une ressource linguistique pour cette langue</para>
    ///   <para>rdfs:label : recurso suportadordfs:label : ressource supportrdfs:label : サポート資源rdfs:label : support resourcerdfs:label : recurso soportadordfs:label : ondersteunende bron</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#supportingResource">lingvo:supportingResource</a>
    /// </summary>
    let supportingResource = _prefixId.prefix "supportingResource"
    /// <summary>
    ///   <para>rdfs:label : tag de idiomardfs:label : etiquetardfs:label : 言語タグrdfs:label : taal tagrdfs:label : tag de languerdfs:label : language tag</para>
    ///   <para>rdfs:comment : A tag para ser usada, por exemplo como valor de xml:lang. Ver https://tools.ietf.org/html/bcp47rdfs:comment : Le tag à utiliser pour la langue, par exemple comme valeur de xml:lang. Voir https://tools.ietf.org/html/bcp47rdfs:comment : The tag to use for the language, for example as value of xml:lang. See https://tools.ietf.org/html/bcp47rdfs:comment : 例えばxml:langの値として、言語に用いるタグ。https://tools.ietf.org/html/bcp47を参照rdfs:comment : La etiqueta a utilizar para el lenguaje, por ejemplo como valor de xml:lang. Ver https://tools.ietf.org/html/bcp47</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#tag">lingvo:tag</a>
    /// </summary>
    let tag = _prefixId.prefix "tag"
    /// <summary>
    ///   <para>rdfs:comment : La lengua de la fuente traducidardfs:comment : De taal waarin de bron vertaald isrdfs:comment : 翻訳後の資源の言語rdfs:comment : The language of the translated ressourcerdfs:comment : La langue de la ressource traduiterdfs:comment : O idioma do recurso traduzido</para>
    ///   <para>rdfs:label : doeltaalrdfs:label : langue ciblerdfs:label : target languagerdfs:label : 翻訳先の言語rdfs:label : lengua destinordfs:label : idioma destino</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#targetLanguage">lingvo:targetLanguage</a>
    /// </summary>
    let targetLanguage = _prefixId.prefix "targetLanguage"
    /// <summary>
    ///   <para>rdfs:label : recurso traduzidordfs:label : recurso traducidordfs:label : vertaalde bronrdfs:label : 翻訳後の資源rdfs:label : translated resourcerdfs:label : ressource traduite</para>
    ///   <para>rdfs:comment : La fuente que resulta de la traducciónrdfs:comment : La ressource qui est le résultat de la traductionrdfs:comment : O recurso que é o resultado da traduçãordfs:comment : 翻訳の結果である資源rdfs:comment : Het resultaat van de vertalingrdfs:comment : The resource which is the result of the translation</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#translatedResource">lingvo:translatedResource</a>
    /// </summary>
    let translatedResource = _prefixId.prefix "translatedResource"
    let translatedTitle = _prefixId.prefix "translatedTitle"
    /// <summary>
    ///   <para>rdfs:comment : De agent (persoon, organisatie of applicatie) verantwoordelijk voor de vertalingrdfs:comment : An agent (person, organization or sofware) responsible of the translationrdfs:comment : 翻訳に責任を持つエージェント（人、組織またはソフトウェア）rdfs:comment : Un agent (personne, organisation ou logiciel) responsable de la traductionrdfs:comment : Un agente (persona, organización o software) responsable de la traducciónrdfs:comment : um agente (pessoa, organização ou programa) responsável pela tradução</para>
    ///   <para>rdfs:label : translatorrdfs:label : 翻訳者rdfs:label : traducteurrdfs:label : vertalerrdfs:label : tradutorrdfs:label : traductor</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#translator">lingvo:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>rdfs:label : werktaalrdfs:label : langue de travailrdfs:label : 実用言語rdfs:label : idioma de trabalhordfs:label : working languagerdfs:label : lenguaje de trabajo</para>
    ///   <para>rdfs:comment : Una lengua que el proyecto o la organización utiliza para comunicación internardfs:comment : A language the project or organization uses for internal communicationrdfs:comment : Une langue utilisée par l'organisation ou le projet pour sa communication internerdfs:comment : O idioma que o projecto ou organização usa para a comunicação internardfs:comment : De taal gebruikt voor interne communicatie door een organisatie of binnen een projectrdfs:comment : プロジェクトや組織が内部コミュニケーションに用いる言語</para>
    ///   <a href="https://w3id.org/vocab/lingvoj#workingLanguage">lingvo:workingLanguage</a>
    /// </summary>
    let workingLanguage = _prefixId.prefix "workingLanguage"

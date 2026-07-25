namespace http.www.lexinfo.net.ontology._3._0.lexinfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lexinfov3 =
    let _namespace_iri = Namespace_Iri lexinfov3 |> NamespaceIRI
    /// <summary>
    ///   <para>lexinfov3:TermType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>term type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TermType">http://www.lexinfo.net/ontology/3.0/lexinfo#TermType</seealso>
    let TermType = Prefixed_Name(lexinfov3, "TermType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjectival complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivalComplementFrame</seealso>
    let AdjectivalComplementFrame =
        Prefixed_Name(lexinfov3, "AdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:predicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>predicative adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjective</seealso>
    let predicativeAdjective =
        Prefixed_Name(lexinfov3, "predicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:partOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A category assigned to a word based on its grammatical and semantic properties. // Term used to describe how a particular word is used in a sentence.</para>
    /// labels<para>kategoria morfosintaktiko</para><para>categoria gramatical</para><para>categoría gramatical</para><para>γραμματική κατηγορία</para><para>categoría gramatical</para><para>parte del discorso</para><para>classe gramatical</para><para>parte de vorbire</para><para>klasë e fjalëve</para><para>part of speech</para><para>зборовна група</para><para>besedna vrsta</para><para>част на речта</para><para>частина мови</para><para>kalbos dalis</para><para>часціны мовы</para><para>slovný druh</para><para>slovní druh</para><para>врста речи</para><para>orðflokkur</para><para>część mowy</para><para>חלקי הדיבר</para><para>woordsoort</para><para>sanaluokka</para><para>часть речи</para><para>ordklasse</para><para>ordklasse</para><para>vārdšķira</para><para>ordklasse</para><para>sõnaliik</para><para>ordklass</para><para>Wortart</para><para>nature</para><para>szófaj</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partOfSpeech">http://www.lexinfo.net/ontology/3.0/lexinfo#partOfSpeech</seealso>
    let partOfSpeech = Prefixed_Name(lexinfov3, "partOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AdjectivePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bijvoeglijk naamwoord</para><para>прилагателно име</para><para>īpašības vārds</para><para>прилагательное</para><para>přídavné jméno</para><para>prídavné meno</para><para>lýsingarorð</para><para>przymiotnik</para><para>tillægsord</para><para>прикметник</para><para>adjektiivi</para><para>omadussõna</para><para>būdvardis</para><para>aggettivo</para><para>adxectivo</para><para>adjective</para><para>melléknév</para><para>pridevnik</para><para>adjektibo</para><para>прыметнік</para><para>adjetivo</para><para>adjectiv</para><para>adjektiv</para><para>adjektiv</para><para>aidiacht</para><para>Adjektiv</para><para>pridjevi</para><para>adjectiu</para><para>adjektiv</para><para>adjetivo</para><para>придавка</para><para>aġġettiv</para><para>adjectif</para><para>mbiemri</para><para>שם תואר</para><para>επίθετο</para><para>придев</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePOS">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePOS</seealso>
    let AdjectivePOS = Prefixed_Name(lexinfov3, "AdjectivePOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Adjective-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective-i</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-i">http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-i</seealso>
    let Adjective_i = Prefixed_Name(lexinfov3, "Adjective-i") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:adjective-na</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Denominal adjectives in Japanese formed from a noun plus the particle 'na'</para>
    /// labels<para>adjective-na</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-na">http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-na</seealso>
    let adjective_na = Prefixed_Name(lexinfov3, "adjective-na") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveAccusativePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective accusative post positive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAccusativePostPositiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAccusativePostPositiveFrame</seealso>
    let AdjectiveAccusativePostPositiveFrame =
        Prefixed_Name(lexinfov3, "AdjectiveAccusativePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An example of the usage of a frame</para>
    /// labels<para>example</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#example">http://www.lexinfo.net/ontology/3.0/lexinfo#example</seealso>
    let example = Prefixed_Name(lexinfov3, "example") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Pronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>įvardinis, įvardžiuotinis</para><para>voornaamwoord</para><para>vietniekvārds</para><para>местоимённый</para><para>pronominale</para><para>asesõnaline</para><para>местоимение</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>izenordain</para><para>pronominal</para><para>займеннік</para><para>zamjenice</para><para>pronomini</para><para>αντωνυμία</para><para>כינוי גוף</para><para>займенник</para><para>Pronomen</para><para>pronomen</para><para>pronomen</para><para>pronomen</para><para>заменица</para><para>zaimkowy</para><para>заменка</para><para>pronome</para><para>zájmeno</para><para>pronoun</para><para>forainm</para><para>fornafn</para><para>përemër</para><para>zámeno</para><para>zaimek</para><para>pronom</para><para>névmás</para><para>pronom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Pronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#Pronoun</seealso>
    let Pronoun = Prefixed_Name(lexinfov3, "Pronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:adverbialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>()</para>
    /// labels<para>adverbial pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialPronoun</seealso>
    let adverbialPronoun = Prefixed_Name(lexinfov3, "adverbialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AffirmativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>baieztapen partikula</para><para>partícula afirmativa</para><para>affirmative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AffirmativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#AffirmativeParticle</seealso>
    let AffirmativeParticle =
        Prefixed_Name(lexinfov3, "AffirmativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Particle">http://www.lexinfo.net/ontology/3.0/lexinfo#Particle</seealso>
    let Particle = Prefixed_Name(lexinfov3, "Particle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:allusivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun that refers to something characterized by allusions.</para>
    /// labels<para>allusive pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#allusivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#allusivePronoun</seealso>
    let allusivePronoun = Prefixed_Name(lexinfov3, "allusivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Animacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>animacidade (linguística)</para><para>animatum og inanimatum</para><para>назви істот і неістот</para><para>Животност (граматика)</para><para>Belebtheitshierarchie</para><para>animat și inanimat</para><para>одушевлённость</para><para>адушаўлёнасць</para><para>biziduntasun</para><para>animacidad</para><para>Animacitet</para><para>animacitat</para><para>żywotność</para><para>animathet</para><para>životnost</para><para>životnosť</para><para>animéité</para><para>Gyvumas</para><para>מונפשות</para><para>animacy</para><para>Élőség</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Animacy">http://www.lexinfo.net/ontology/3.0/lexinfo#Animacy</seealso>
    let Animacy = Prefixed_Name(lexinfov3, "Animacy") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>An adjective derived from a noun and denoting possession by the object described by the noun.</para>
    /// labels<para>possessive adjective</para><para>adjektibo posesibo</para><para>adjetivo posesivo</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjective</seealso>
    let possessiveAdjective =
        Prefixed_Name(lexinfov3, "possessiveAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>притяжательный детерминатив</para><para>determinatzaile posesibo</para><para>déterminant possessif</para><para>possessive determiner</para><para>determinante posesivo</para><para>aggettivo possessivo</para><para>присвојни придеви</para><para>adjectiv posesiv</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveDeterminer</seealso>
    let PossessiveDeterminer =
        Prefixed_Name(lexinfov3, "PossessiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>притяжательное местоимение</para><para>bezittelijk voornaamwoord</para><para>přivlastňovací zájmeno</para><para>присвійний займенник</para><para>possessiivipronomini</para><para>possessivt pronomen</para><para>possessivt pronomen</para><para>izenordain posesibo</para><para>possessiivpronoomen</para><para>pronome possessivo</para><para>pronombre posesivo</para><para>possessive pronoun</para><para>posvojne zamjenice</para><para>присвојна заменица</para><para>pronome possessivo</para><para>savybinis įvardis</para><para>Κτητική αντωνυμία</para><para>Possessivpronomen</para><para>pronom possessif</para><para>pronome posesivo</para><para>pronom possessiu</para><para>birtokos névmás</para><para>pronume posesiv</para><para>eignarfornafn</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessivePronoun</seealso>
    let PossessivePronoun =
        Prefixed_Name(lexinfov3, "PossessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SymbolPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>szimbólum</para><para>Simbolis</para><para>siombail</para><para>símbolo</para><para>símbolo</para><para>symbool</para><para>σύμβολο</para><para>Simboli</para><para>symboli</para><para>symbole</para><para>símbolo</para><para>simbols</para><para>simbolo</para><para>Символ</para><para>сімвал</para><para>symbol</para><para>symbol</para><para>symbol</para><para>symbol</para><para>symbol</para><para>симбол</para><para>Simbol</para><para>symbol</para><para>символ</para><para>симбол</para><para>símbol</para><para>symbol</para><para>символ</para><para>simbol</para><para>Symbol</para><para>symbol</para><para>sümbol</para><para>Simbol</para><para>ikur</para><para>Tákn</para><para>סמל</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SymbolPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#SymbolPOS</seealso>
    let SymbolPOS = Prefixed_Name(lexinfov3, "SymbolPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TemporalQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>temporal qualifier</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TemporalQualifier">http://www.lexinfo.net/ontology/3.0/lexinfo#TemporalQualifier</seealso>
    let TemporalQualifier =
        Prefixed_Name(lexinfov3, "TemporalQualifier") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gramatická kategória času</para><para>darbības vārda laiks</para><para>denbora gramatikal</para><para>γραμματικός χρόνος</para><para>tiempo gramatical</para><para>Gramatinis laikas</para><para>tempo gramatical</para><para>Tíðbeyging sagna</para><para>temps gramatical</para><para>tempo gramatical</para><para>глаголско време</para><para>werkwoordstijd</para><para>Glagolski čas</para><para>aikamuoto</para><para>tempus</para><para>igeidő</para><para>tempus</para><para>Tempus</para><para>време</para><para>tense</para><para>время</para><para>temps</para><para>Време</para><para>tempo</para><para>czas</para><para>Timp</para><para>час</para><para>час</para><para>Aeg</para><para>זמן</para><para>čas</para><para>tid</para><para>tid</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Tense">http://www.lexinfo.net/ontology/3.0/lexinfo#Tense</seealso>
    let Tense = Prefixed_Name(lexinfov3, "Tense") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:geographicalVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Description of a specific form used in a certain region as opposed to another form used in another region</para>
    /// labels<para>geographical variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#geographicalVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#geographicalVariant</seealso>
    let geographicalVariant =
        Prefixed_Name(lexinfov3, "geographicalVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:gerundClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>gerund clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#gerundClause">http://www.lexinfo.net/ontology/3.0/lexinfo#gerundClause</seealso>
    let gerundClause = Prefixed_Name(lexinfov3, "gerundClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:gerundive</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>gerundive</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#gerundive">http://www.lexinfo.net/ontology/3.0/lexinfo#gerundive</seealso>
    let gerundive = Prefixed_Name(lexinfov3, "gerundive") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:gloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.</para>
    /// labels<para>gloss</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#gloss">http://www.lexinfo.net/ontology/3.0/lexinfo#gloss</seealso>
    let gloss = Prefixed_Name(lexinfov3, "gloss") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:meronymTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates this is a part of another concept</para>
    /// labels<para>meronym term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#meronymTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#meronymTerm</seealso>
    let meronymTerm = Prefixed_Name(lexinfov3, "meronymTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:homograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin. // Word that is written like another, but that has a different pronunciation, meaning, and/or origin.</para>
    /// labels<para>homograph</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#homograph">http://www.lexinfo.net/ontology/3.0/lexinfo#homograph</seealso>
    let homograph = Prefixed_Name(lexinfov3, "homograph") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:homonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone). // Word that sounds the same and is written the same as another word but is different in meaning.</para>
    /// labels<para>homonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#homonym">http://www.lexinfo.net/ontology/3.0/lexinfo#homonym</seealso>
    let homonym = Prefixed_Name(lexinfov3, "homonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:homophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A word that is pronounced in the same way as another word but that is spelled differently. // Word that sounds like another word, but is different in writiing or meaning.</para>
    /// labels<para>homophone</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#homophone">http://www.lexinfo.net/ontology/3.0/lexinfo#homophone</seealso>
    let homophone = Prefixed_Name(lexinfov3, "homophone") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:hypernym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A term with a broader meaning</para>
    /// labels<para>hypernym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#hypernym">http://www.lexinfo.net/ontology/3.0/lexinfo#hypernym</seealso>
    let hypernym = Prefixed_Name(lexinfov3, "hypernym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:illativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses the meaning of 'motion into' or 'direction towards' the referent of the noun it marks.</para>
    /// labels<para>illative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCase</seealso>
    let illativeCase = Prefixed_Name(lexinfov3, "illativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:illativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>illative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#illativeCaseForm</seealso>
    let illativeCaseForm = Prefixed_Name(lexinfov3, "illativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:imperative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Mood</para>
    ///   <para>Mood used to express an order.</para>
    /// labels<para>imperative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperative">http://www.lexinfo.net/ontology/3.0/lexinfo#imperative</seealso>
    let imperative = Prefixed_Name(lexinfov3, "imperative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:imperativeMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imperative mood form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperativeMoodForm">http://www.lexinfo.net/ontology/3.0/lexinfo#imperativeMoodForm</seealso>
    let imperativeMoodForm =
        Prefixed_Name(lexinfov3, "imperativeMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:imperfect</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Tense</para>
    ///   <para>owl:Thing</para>
    ///   <para>Verb tense that refers to action in the past that is incomplete or ongoing.</para>
    /// labels<para>imperfect</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfect">http://www.lexinfo.net/ontology/3.0/lexinfo#imperfect</seealso>
    let imperfect = Prefixed_Name(lexinfov3, "imperfect") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:inchoative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>Aspect that expresses the beginning of an event or state.</para>
    /// labels<para>inchoative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inchoative">http://www.lexinfo.net/ontology/3.0/lexinfo#inchoative</seealso>
    let inchoative = Prefixed_Name(lexinfov3, "inchoative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:indefinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Value related to an entity in a situation where the identification of this entity is not clear cut.</para>
    /// labels<para>indefinite</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefinite">http://www.lexinfo.net/ontology/3.0/lexinfo#indefinite</seealso>
    let indefinite = Prefixed_Name(lexinfov3, "indefinite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:singular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Number</para>
    ///   <para>The form of a term or word (usually of a noun) used to designate one object. // Value that expresses one element.</para>
    /// labels<para>singular</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#singular">http://www.lexinfo.net/ontology/3.0/lexinfo#singular</seealso>
    let singular = Prefixed_Name(lexinfov3, "singular") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:singularNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>singular number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#singularNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#singularNumberForm</seealso>
    let singularNumberForm =
        Prefixed_Name(lexinfov3, "singularNumberForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:sku</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>An inventory item identified by a unique alphanumeric designation assigned to an object in an inventory control system.</para>
    /// labels<para>sku</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sku">http://www.lexinfo.net/ontology/3.0/lexinfo#sku</seealso>
    let sku = Prefixed_Name(lexinfov3, "sku") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:slangRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///   <para>An extremely informal register of a word, term, or text that is used in spoken and everyday language and less commonly in documents.</para>
    /// labels<para>slang register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#slangRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#slangRegister</seealso>
    let slangRegister = Prefixed_Name(lexinfov3, "slangRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DativeTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dative transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DativeTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#DativeTransitiveFrame</seealso>
    let DativeTransitiveFrame =
        Prefixed_Name(lexinfov3, "DativeTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized</para>
    /// labels<para>indirect object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indirectObject">http://www.lexinfo.net/ontology/3.0/lexinfo#indirectObject</seealso>
    let indirectObject = Prefixed_Name(lexinfov3, "indirectObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DeclarativeClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>declarative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeClause</seealso>
    let DeclarativeClause =
        Prefixed_Name(lexinfov3, "DeclarativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DeficientVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aditz defiziente</para><para>deficient verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeficientVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#DeficientVerb</seealso>
    let DeficientVerb = Prefixed_Name(lexinfov3, "DeficientVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:definiteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Article that allows the reference to a specific, identifiable entity (or class of entities).</para>
    /// labels<para>articolo determinativo</para><para>определенный артикль</para><para>przedimek określony</para><para>žymimasis artikelis</para><para>bestimmter Artikel</para><para>articolul hotărât</para><para>határozott névelő</para><para>artículo definido</para><para>artikulu mugatua</para><para>definite article</para><para>Bepaald lidwoord</para><para>ákveðinn greinir</para><para>bestemt artikel</para><para>artigo definido</para><para>artigo definido</para><para>määrav artikkel</para><para>article definit</para><para>οριστικό άρθρο</para><para>article défini</para><para>одређени члан</para><para>člen určitý</para><para>הא הידיעה</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#definiteArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#definiteArticle</seealso>
    let definiteArticle = Prefixed_Name(lexinfov3, "definiteArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>degree</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Degree">http://www.lexinfo.net/ontology/3.0/lexinfo#Degree</seealso>
    let Degree = Prefixed_Name(lexinfov3, "Degree") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DemonstrativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>determinante demostrativo</para><para>determinatzaile erakusle</para><para>demonstrative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativeDeterminer</seealso>
    let DemonstrativeDeterminer =
        Prefixed_Name(lexinfov3, "DemonstrativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:demonstrativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Determiner used to point to an entity in the situation or elsewhere in a sentence.</para>
    /// labels<para>determinante demostrativo</para><para>demonstrative determiner</para><para>determinatzaile erakusle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativeDeterminer</seealso>
    let demonstrativeDeterminer =
        Prefixed_Name(lexinfov3, "demonstrativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DemonstrativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>указательное местоимение</para><para>Aanwijzend voornaamwoord</para><para>demonstratiivipronomini</para><para>demonstrativt pronomen</para><para>demonstrative pronoun</para><para>pronome demonstrativo</para><para>demonstrativpronomen</para><para>Demonstrativpronomen</para><para>Pronume demonstrativ</para><para>вказівний займенник</para><para>pronom démonstratif</para><para>izenordain erakusle</para><para>ábendingarfornafn</para><para>zaimek wskazujący</para><para>Pokazne zamjenice</para><para>ukazovací zájmeno</para><para>показна заменица</para><para>näitav asesõna</para><para>mutató névmás</para><para>demostrativo</para><para>dimostrativo</para><para>demonstrativ</para><para>demonstrativ</para><para>demostrativo</para><para>parodomasis</para><para>demostratiu</para><para>כינוי רמז</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#DemonstrativePronoun</seealso>
    let DemonstrativePronoun =
        Prefixed_Name(lexinfov3, "DemonstrativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>pronoun which may act as a relative pronoun or an interrogative one</para>
    /// labels<para>interrogative relative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeRelativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeRelativePronoun</seealso>
    let interrogativeRelativePronoun =
        Prefixed_Name(lexinfov3, "interrogativeRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveAdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive adjectival complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdjectivalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdjectivalComplementFrame</seealso>
    let IntransitiveAdjectivalComplementFrame =
        Prefixed_Name(lexinfov3, "IntransitiveAdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intrantsitibotasun marko</para><para>marco instransitivo</para><para>intransitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveFrame</seealso>
    let IntransitiveFrame =
        Prefixed_Name(lexinfov3, "IntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun that expresses ownership and relationships like ownership, such as kinship, and other forms of association.</para>
    /// labels<para>притяжательное местоимение</para><para>bezittelijk voornaamwoord</para><para>přivlastňovací zájmeno</para><para>possessiivipronomini</para><para>присвійний займенник</para><para>possessiivpronoomen</para><para>izenordain posesibo</para><para>possessivt pronomen</para><para>possessivt pronomen</para><para>posvojne zamjenice</para><para>pronome possessivo</para><para>pronome possessivo</para><para>possessive pronoun</para><para>присвојна заменица</para><para>pronombre posesivo</para><para>Possessivpronomen</para><para>savybinis įvardis</para><para>Κτητική αντωνυμία</para><para>pronom possessif</para><para>pronome posesivo</para><para>pronom possessiu</para><para>pronume posesiv</para><para>birtokos névmás</para><para>eignarfornafn</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#possessivePronoun</seealso>
    let possessivePronoun =
        Prefixed_Name(lexinfov3, "possessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>possessive relative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveRelativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveRelativePronoun</seealso>
    let PossessiveRelativePronoun =
        Prefixed_Name(lexinfov3, "PossessiveRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A relative pronoun whose antecedent is the possessor of the subject or object in the relative clause.</para>
    /// labels<para>possessive relative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveRelativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveRelativePronoun</seealso>
    let possessiveRelativePronoun =
        Prefixed_Name(lexinfov3, "possessiveRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveAdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive adverbial complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdverbialComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdverbialComplementFrame</seealso>
    let TransitiveAdverbialComplementFrame =
        Prefixed_Name(lexinfov3, "TransitiveAdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:hint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which cannot be classified otherwise</para>
    /// labels<para>hint</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#hint">http://www.lexinfo.net/ontology/3.0/lexinfo#hint</seealso>
    let hint = Prefixed_Name(lexinfov3, "hint") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:holonymTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates that the referenced element is a part of this object</para>
    /// labels<para>holonym term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#holonymTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#holonymTerm</seealso>
    let holonymTerm = Prefixed_Name(lexinfov3, "holonymTerm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:partitiveRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.</para>
    /// labels<para>partitive relation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveRelation">http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveRelation</seealso>
    let partitiveRelation =
        Prefixed_Name(lexinfov3, "partitiveRelation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:hyponym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A term with a narrower meaning</para>
    /// labels<para>hyponym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#hyponym">http://www.lexinfo.net/ontology/3.0/lexinfo#hyponym</seealso>
    let hyponym = Prefixed_Name(lexinfov3, "hyponym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:idiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A group of words in a fixed order that have a particular meaning that is different from the meanings of each word understood on its own.</para>
    /// labels<para>idiom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#idiom">http://www.lexinfo.net/ontology/3.0/lexinfo#idiom</seealso>
    let idiom = Prefixed_Name(lexinfov3, "idiom") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:imperfectTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>imperfect tense form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfectTenseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#imperfectTenseForm</seealso>
    let imperfectTenseForm =
        Prefixed_Name(lexinfov3, "imperfectTenseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:imperfective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>Imperfective aspect is an aspect that expresses an event or state, with respect to its internal structure, instead of expressing it as a simple whole.</para>
    /// labels<para>imperfective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#imperfective">http://www.lexinfo.net/ontology/3.0/lexinfo#imperfective</seealso>
    let imperfective = Prefixed_Name(lexinfov3, "imperfective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:inHouseRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///   <para>Register of terms that are company-specific and not readily recognized outside this environment. // The register of terms that are company-specific and not readily recognized outside this environment.</para>
    /// labels<para>in house register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inHouseRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#inHouseRegister</seealso>
    let inHouseRegister = Prefixed_Name(lexinfov3, "inHouseRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:inanimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Animacy</para>
    ///   <para>owl:Thing</para>
    ///   <para>Perceived as not living.</para>
    /// labels<para>inanimate</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inanimate">http://www.lexinfo.net/ontology/3.0/lexinfo#inanimate</seealso>
    let inanimate = Prefixed_Name(lexinfov3, "inanimate") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectivePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective post positive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePostPositiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePostPositiveFrame</seealso>
    let AdjectivePostPositiveFrame =
        Prefixed_Name(lexinfov3, "AdjectivePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:demonstrativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Pronoun used to point to an entity in the situation or elsewhere in a sentence.</para>
    /// labels<para>Aanwijzend voornaamwoord</para><para>указательное местоимение</para><para>demonstratiivipronomini</para><para>demonstrativt pronomen</para><para>demonstrative pronoun</para><para>pronome demonstrativo</para><para>Demonstrativpronomen</para><para>Pronume demonstrativ</para><para>demonstrativpronomen</para><para>вказівний займенник</para><para>pronom démonstratif</para><para>izenordain erakusle</para><para>Pokazne zamjenice</para><para>ábendingarfornafn</para><para>ukazovací zájmeno</para><para>zaimek wskazujący</para><para>показна заменица</para><para>näitav asesõna</para><para>mutató névmás</para><para>demonstrativ</para><para>dimostrativo</para><para>demonstrativ</para><para>demostrativo</para><para>demostrativo</para><para>demostratiu</para><para>parodomasis</para><para>כינוי רמז</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#demonstrativePronoun</seealso>
    let demonstrativePronoun =
        Prefixed_Name(lexinfov3, "demonstrativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DiminutiveNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>deminutivní substantivum</para><para>zdrobniały rzeczownik</para><para>nombre diminutivo</para><para>izen txikigarria</para><para>diminutive noun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DiminutiveNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#DiminutiveNoun</seealso>
    let DiminutiveNoun = Prefixed_Name(lexinfov3, "DiminutiveNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:diminutiveNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>diminutive noun</para>
    /// labels<para>deminutivní substantivum</para><para>zdrobniały rzeczownik</para><para>nombre diminutivo</para><para>izen txikigarria</para><para>diminutive noun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#diminutiveNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#diminutiveNoun</seealso>
    let diminutiveNoun = Prefixed_Name(lexinfov3, "diminutiveNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:DirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>relation between a phrase and a verb, in which the relation is central to the verb</para>
    /// labels<para>direct object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DirectObject">http://www.lexinfo.net/ontology/3.0/lexinfo#DirectObject</seealso>
    let DirectObject = Prefixed_Name(lexinfov3, "DirectObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DistinctiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>distinctive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DistinctiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#DistinctiveParticle</seealso>
    let DistinctiveParticle =
        Prefixed_Name(lexinfov3, "DistinctiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:RaisingSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.</para>
    /// labels<para>raising subject</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisingSubject">http://www.lexinfo.net/ontology/3.0/lexinfo#RaisingSubject</seealso>
    let RaisingSubject = Prefixed_Name(lexinfov3, "RaisingSubject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveInfinitiveSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive infinitive sc frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveSCFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveSCFrame</seealso>
    let IntransitiveInfinitiveSCFrame =
        Prefixed_Name(lexinfov3, "IntransitiveInfinitiveSCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveInterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive interrogative infinitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame</seealso>
    let IntransitiveInterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfov3, "IntransitiveInterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:predicativeNominative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>predicative nominative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeNominative">http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeNominative</seealso>
    let predicativeNominative =
        Prefixed_Name(lexinfov3, "predicativeNominative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitivePPDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive pp declarative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPDeclarativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPDeclarativeFrame</seealso>
    let IntransitivePPDeclarativeFrame =
        Prefixed_Name(lexinfov3, "IntransitivePPDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lehenaldiko partizipio marko</para><para>pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#PPFrame</seealso>
    let PPFrame = Prefixed_Name(lexinfov3, "PPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveSententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive sentential frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveSententialFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveSententialFrame</seealso>
    let IntransitiveSententialFrame =
        Prefixed_Name(lexinfov3, "IntransitiveSententialFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause</para>
    /// labels<para>sentential frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SententialFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SententialFrame</seealso>
    let SententialFrame = Prefixed_Name(lexinfov3, "SententialFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PredicativeAdjective</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>predicative adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjective</seealso>
    let PredicativeAdjective =
        Prefixed_Name(lexinfov3, "PredicativeAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PredicativeAdverb</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>predicative adverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdverb</seealso>
    let PredicativeAdverb =
        Prefixed_Name(lexinfov3, "PredicativeAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PredicativeNominative</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>predicative nominative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeNominative">http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeNominative</seealso>
    let PredicativeNominative =
        Prefixed_Name(lexinfov3, "PredicativeNominative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adposition placed at the beginning of a noun phrase.</para>
    /// labels<para>preposizzjoni</para><para>Prepositioun</para><para>preposizione</para><para>preposisjon</para><para>preposition</para><para>prepozicija</para><para>preposición</para><para>Präposition</para><para>preposisjon</para><para>préposition</para><para>præposition</para><para>прыназоўнік</para><para>preposición</para><para>preposition</para><para>prijedlozi</para><para>прийменник</para><para>preposição</para><para>preposició</para><para>voorzetsel</para><para>prepoziție</para><para>prepozíció</para><para>forsetning</para><para>prepositio</para><para>preposizio</para><para>prievārds</para><para>předložka</para><para>predložka</para><para>przyimek</para><para>מילת יחס</para><para>πρόθεση</para><para>предлог</para><para>predlog</para><para>eessõna</para><para>предлог</para><para>предлог</para><para>предлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#preposition">http://www.lexinfo.net/ontology/3.0/lexinfo#preposition</seealso>
    let preposition = Prefixed_Name(lexinfov3, "preposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:root</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>base of a word</para>
    /// labels<para>root</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#root">http://www.lexinfo.net/ontology/3.0/lexinfo#root</seealso>
    let root = Prefixed_Name(lexinfov3, "root") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:secondPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Person</para>
    ///   <para>Second person deixis is deictic reference to a person or persons identified as addressee.</para>
    /// labels<para>second person</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#secondPerson">http://www.lexinfo.net/ontology/3.0/lexinfo#secondPerson</seealso>
    let secondPerson = Prefixed_Name(lexinfov3, "secondPerson") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AccusativePostPositiveArg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AccusativePostPositiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#AccusativePostPositiveArg</seealso>
    let AccusativePostPositiveArg =
        Prefixed_Name(lexinfov3, "AccusativePostPositiveArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PostPositiveArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something</para>
    /// labels<para>post positive arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PostPositiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#PostPositiveArg</seealso>
    let PostPositiveArg = Prefixed_Name(lexinfov3, "PostPositiveArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:VerbFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>marco verbal</para><para>aditz-marko</para><para>verb frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFrame</seealso>
    let VerbFrame = Prefixed_Name(lexinfov3, "VerbFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Adjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bijvoeglijk naamwoord</para><para>прилагателно име</para><para>прилагательное</para><para>přídavné jméno</para><para>īpašības vārds</para><para>prídavné meno</para><para>lýsingarorð</para><para>przymiotnik</para><para>adjektiivi</para><para>прикметник</para><para>omadussõna</para><para>tillægsord</para><para>adjective</para><para>pridevnik</para><para>adxectivo</para><para>aggettivo</para><para>adjektibo</para><para>būdvardis</para><para>melléknév</para><para>прыметнік</para><para>adjektiv</para><para>adjektiv</para><para>придавка</para><para>adjetivo</para><para>adjetivo</para><para>aġġettiv</para><para>adjectiv</para><para>aidiacht</para><para>adjectiu</para><para>pridjevi</para><para>adjektiv</para><para>Adjektiv</para><para>adjectif</para><para>επίθετο</para><para>שם תואר</para><para>mbiemri</para><para>придев</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective">http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective</seealso>
    let Adjective = Prefixed_Name(lexinfov3, "Adjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefinitePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun that does not allow reference.</para>
    /// labels<para>неопределённое местоимение</para><para>Onbepaald voornaamwoord</para><para>неозначений займенник</para><para>pronombre indefinido</para><para>Neodređene zamjenice</para><para>izenordain mugagabe</para><para>zaimek nieokreślony</para><para>неодређена заменица</para><para>nežymimasis įvardis</para><para>határozatlan névmás</para><para>pronome indefinito</para><para>indefinite pronoun</para><para>pronome indefinido</para><para>indefinit pronomen</para><para>indefinit pronomen</para><para>pronome indefinido</para><para>umbmäärane asesõna</para><para>Indefinitpronomen</para><para>Pronume nehotărât</para><para>αόριστη αντωνυμία</para><para>neurčité zájmeno</para><para>óákveðið fornafn</para><para>pronom indefinit</para><para>pronom indéfini</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefinitePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#indefinitePronoun</seealso>
    let indefinitePronoun =
        Prefixed_Name(lexinfov3, "indefinitePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndirectObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized</para>
    /// labels<para>indirect object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndirectObject">http://www.lexinfo.net/ontology/3.0/lexinfo#IndirectObject</seealso>
    let IndirectObject = Prefixed_Name(lexinfov3, "IndirectObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:InfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Infinitive frames take an infinitive clause as an argument</para>
    /// labels<para>infinitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveFrame</seealso>
    let InfinitiveFrame = Prefixed_Name(lexinfov3, "InfinitiveFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:infinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveClause</seealso>
    let infinitiveClause = Prefixed_Name(lexinfov3, "infinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InfinitiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>partícula de infinitivo</para><para>partikula infinitibo</para><para>infinitive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveParticle</seealso>
    let InfinitiveParticle =
        Prefixed_Name(lexinfov3, "InfinitiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:infinitiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Particle used to express infinitive.</para>
    /// labels<para>partícula de infinitivo</para><para>partikula infinitibo</para><para>infinitive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#infinitiveParticle</seealso>
    let infinitiveParticle =
        Prefixed_Name(lexinfov3, "infinitiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Infix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>infix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Infix">http://www.lexinfo.net/ontology/3.0/lexinfo#Infix</seealso>
    let Infix = Prefixed_Name(lexinfov3, "Infix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:plural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Number</para>
    ///   <para>The form of a term or word (usually of a noun) used to designate more than one object. // Value that expresses more than one element.</para>
    /// labels<para>plural</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#plural">http://www.lexinfo.net/ontology/3.0/lexinfo#plural</seealso>
    let plural = Prefixed_Name(lexinfov3, "plural") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AdjectiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveFrame</seealso>
    let AdjectiveFrame = Prefixed_Name(lexinfov3, "AdjectiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveComparativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective comparative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveComparativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveComparativeFrame</seealso>
    let AdjectiveComparativeFrame =
        Prefixed_Name(lexinfov3, "AdjectiveComparativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DeterminerPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>determinativt pronomen</para><para>определяющее слово</para><para>determinatzaile</para><para>määrav artikkel</para><para>προσδιοριστής</para><para>determinantas</para><para>Determinativ</para><para>determinante</para><para>determinativ</para><para>determinátor</para><para>determinativ</para><para>determinante</para><para>determinante</para><para>determinator</para><para>determinativ</para><para>determinante</para><para>детерминатор</para><para>Determinant</para><para>determináns</para><para>determinant</para><para>determinant</para><para>déterminant</para><para>determiner</para><para>ákvæðisorð</para><para>określnik</para><para>визначник</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeterminerPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#DeterminerPOS</seealso>
    let DeterminerPOS = Prefixed_Name(lexinfov3, "DeterminerPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aspecte gramatical</para><para>aspecto gramatical</para><para>aspecto gramatical</para><para>Ποιόν ενέργειας</para><para>Вид на глагола</para><para>Glagolski vid</para><para>глаголски вид</para><para>Slovesný vid</para><para>slovesný vid</para><para>igeszemlélet</para><para>вид глагола</para><para>veikslas</para><para>aspekti</para><para>aspetto</para><para>aspecto</para><para>Aspect</para><para>aspect</para><para>Aspekt</para><para>aspect</para><para>aspekt</para><para>aspekt</para><para>Aspekt</para><para>aspect</para><para>aspekt</para><para>aspekt</para><para>אספקט</para><para>вид</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Aspect">http://www.lexinfo.net/ontology/3.0/lexinfo#Aspect</seealso>
    let Aspect = Prefixed_Name(lexinfov3, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AttributiveArg</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>attributive arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AttributiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#AttributiveArg</seealso>
    let AttributiveArg = Prefixed_Name(lexinfov3, "AttributiveArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:auxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>a verb that adds functional or grammatical meaning to the clause in which it appears, so as to express tense, aspect, modality, voice, emphasis, etc.</para>
    /// labels<para>pagalbinis veiksmažodis</para><para>вспомогательный глагол</para><para>czasownik posiłkowy</para><para>допоміжне дієслово</para><para>aditz laguntzaile</para><para>verbe auxiliaire</para><para>verb awżiljarju</para><para>pomocné sloveso</para><para>briathar cúnta</para><para>verbo auxiliar</para><para>pomožni glagol</para><para>помошен глагол</para><para>verbo auxiliar</para><para>verbo auxiliar</para><para>помоћни глагол</para><para>Verb auxiliar</para><para>hulpwerkwoord</para><para>hjælpeverbum</para><para>hjálparsögn</para><para>abitegusõna</para><para>hjelpeverb</para><para>hjelpeverb</para><para>βοηθητικό</para><para>Hilfsverb</para><para>ausiliare</para><para>auxiliary</para><para>hjälpverb</para><para>auxiliar</para><para>פועל עזר</para><para>segédige</para><para>apuverbi</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#auxiliary">http://www.lexinfo.net/ontology/3.0/lexinfo#auxiliary</seealso>
    let auxiliary = Prefixed_Name(lexinfov3, "auxiliary") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Bullet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bullet</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Bullet">http://www.lexinfo.net/ontology/3.0/lexinfo#Bullet</seealso>
    let Bullet = Prefixed_Name(lexinfov3, "Bullet") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>szimbólum</para><para>Simbolis</para><para>siombail</para><para>σύμβολο</para><para>símbolo</para><para>symbole</para><para>simbolo</para><para>symbool</para><para>Simboli</para><para>símbolo</para><para>símbolo</para><para>symboli</para><para>simbols</para><para>Символ</para><para>символ</para><para>Simbol</para><para>symbol</para><para>symbol</para><para>símbol</para><para>sümbol</para><para>Symbol</para><para>символ</para><para>symbol</para><para>symbol</para><para>Simbol</para><para>симбол</para><para>symbol</para><para>simbol</para><para>сімвал</para><para>symbol</para><para>symbol</para><para>symbol</para><para>симбол</para><para>Tákn</para><para>ikur</para><para>סמל</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Symbol">http://www.lexinfo.net/ontology/3.0/lexinfo#Symbol</seealso>
    let Symbol = Prefixed_Name(lexinfov3, "Symbol") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:bullet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Sign used to mark an item in a list.</para>
    /// labels<para>bullet</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#bullet">http://www.lexinfo.net/ontology/3.0/lexinfo#bullet</seealso>
    let bullet = Prefixed_Name(lexinfov3, "bullet") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:CJK_compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A lexical unit in a CJKV language that is represented by at least two CJKV characters.</para>
    /// labels<para>cjk_compound</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CJK_compound">http://www.lexinfo.net/ontology/3.0/lexinfo#CJK_compound</seealso>
    let CJK_compound = Prefixed_Name(lexinfov3, "CJK_compound") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Finiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>finiteness</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Finiteness">http://www.lexinfo.net/ontology/3.0/lexinfo#Finiteness</seealso>
    let Finiteness = Prefixed_Name(lexinfov3, "Finiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hyppighet i statistikk</para><para>Релативна фреквенција</para><para>Frekvens i statistikk</para><para>Частота події</para><para>фреквенција</para><para>частотность</para><para>frecuencia</para><para>frequentie</para><para>freqüència</para><para>frequência</para><para>Häufigkeit</para><para>frecuencia</para><para>frekwencja</para><para>gyakoriság</para><para>συχνότητα</para><para>frekvenca</para><para>frequency</para><para>Maiztasun</para><para>fréquence</para><para>frecvență</para><para>frequenza</para><para>dažnumas</para><para>frekvens</para><para>Частата</para><para>sagedus</para><para>četnost</para><para>שכיחות</para><para>tíðni</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Frequency">http://www.lexinfo.net/ontology/3.0/lexinfo#Frequency</seealso>
    let Frequency = Prefixed_Name(lexinfov3, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Format e shtjelluara të foljes</para><para>gramatiskā izteiksme</para><para>наклонение глагола</para><para>grammatisk modus</para><para>Glagolski naklon</para><para>mod al verbului</para><para>slovesný způsob</para><para>modo gramatical</para><para>modo gramatical</para><para>глаголски начин</para><para>modu gramatikal</para><para>глаголски начин</para><para>slovesný spôsob</para><para>способи дієслів</para><para>лад дзеяслова</para><para>Hættir sagna</para><para>modo verbal</para><para>tapaluokka</para><para>Наклонение</para><para>Kõneviis</para><para>έγκλιση</para><para>Nuosaka</para><para>igemód</para><para>מודוס</para><para>modus</para><para>Modus</para><para>modus</para><para>Modus</para><para>mode</para><para>mood</para><para>mode</para><para>wijs</para><para>tryb</para><para>modo</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Mood">http://www.lexinfo.net/ontology/3.0/lexinfo#Mood</seealso>
    let Mood = Prefixed_Name(lexinfov3, "Mood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AbbreviatedForm">http://www.lexinfo.net/ontology/3.0/lexinfo#AbbreviatedForm</seealso>
    let AbbreviatedForm = Prefixed_Name(lexinfov3, "AbbreviatedForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PredicativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>predicative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#PredicativeAdjunct</seealso>
    let PredicativeAdjunct =
        Prefixed_Name(lexinfov3, "PredicativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ComparativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>partikula konparatibo</para><para>partícula comparativa</para><para>comparative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeParticle</seealso>
    let ComparativeParticle =
        Prefixed_Name(lexinfov3, "ComparativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:numeralFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Word used to denote the denominator of a fraction.</para>
    /// labels<para>numeral fraction</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#numeralFraction">http://www.lexinfo.net/ontology/3.0/lexinfo#numeralFraction</seealso>
    let numeralFraction = Prefixed_Name(lexinfov3, "numeralFraction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Number</para>
    ///   <para>A collective number is a number referring to 'a set of things'. Languages that have this feature can use it to get a phrase like 'flock of sheeps' by using 'sheep' in collective number.</para>
    /// labels<para>collective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#collective">http://www.lexinfo.net/ontology/3.0/lexinfo#collective</seealso>
    let collective = Prefixed_Name(lexinfov3, "collective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:personal</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:ReferentType</para>
    ///   <para>owl:Thing</para>
    ///   <para>Property that refers to the person.</para>
    /// labels<para>personal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#personal">http://www.lexinfo.net/ontology/3.0/lexinfo#personal</seealso>
    let personal = Prefixed_Name(lexinfov3, "personal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:pertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a term is the adjectival form of a word with a meaning of 'of or pertaining to X'</para>
    /// labels<para>pertains to</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pertainsTo">http://www.lexinfo.net/ontology/3.0/lexinfo#pertainsTo</seealso>
    let pertainsTo = Prefixed_Name(lexinfov3, "pertainsTo") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:phraseologicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>Any group of two or more words that form a unit, the meaning of which frequently cannot be deduced based on the combined sense of the words making up the phrase.</para>
    /// labels<para>phraseological unit</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#phraseologicalUnit">http://www.lexinfo.net/ontology/3.0/lexinfo#phraseologicalUnit</seealso>
    let phraseologicalUnit =
        Prefixed_Name(lexinfov3, "phraseologicalUnit") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:accusativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case used to indicate direct object.</para>
    /// labels<para>accusative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCase</seealso>
    let accusativeCase = Prefixed_Name(lexinfov3, "accusativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract frame for words that take a prepositional phrase as an argument</para>
    /// labels<para>prepositional frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalFrame</seealso>
    let PrepositionalFrame =
        Prefixed_Name(lexinfov3, "PrepositionalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectivePredicateFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Note this frame should be used when both attributive and predicative use of the adjective is allowed</para>
    /// labels<para>adjective predicate frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicateFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicateFrame</seealso>
    let AdjectivePredicateFrame =
        Prefixed_Name(lexinfov3, "AdjectivePredicateFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveScaleFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective scale frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveScaleFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveScaleFrame</seealso>
    let AdjectiveScaleFrame =
        Prefixed_Name(lexinfov3, "AdjectiveScaleFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adverbialComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adverbial complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialComplement">http://www.lexinfo.net/ontology/3.0/lexinfo#adverbialComplement</seealso>
    let adverbialComplement =
        Prefixed_Name(lexinfov3, "adverbialComplement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveSuperlativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective superlative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveSuperlativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveSuperlativeFrame</seealso>
    let AdjectiveSuperlativeFrame =
        Prefixed_Name(lexinfov3, "AdjectiveSuperlativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:conditionalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>conditional pronoun</para>
    /// labels<para>conditional pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalPronoun</seealso>
    let conditionalPronoun =
        Prefixed_Name(lexinfov3, "conditionalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>congiunzione</para><para>konjunksjon</para><para>konjunktion</para><para>konġunzjoni</para><para>konjunktion</para><para>Konjunktion</para><para>conjonction</para><para>konjunksjon</para><para>conjunction</para><para>samtenging</para><para>konjunktio</para><para>מילת קישור</para><para>juntagailu</para><para>conjunción</para><para>conjuncție</para><para>conxunción</para><para>сполучник</para><para>bindvlies</para><para>conjunció</para><para>jungtukas</para><para>σύνδεσμος</para><para>conjunção</para><para>sidesõna</para><para>saiklis</para><para>lidhëza</para><para>spójnik</para><para>veznici</para><para>kötőszó</para><para>злучнік</para><para>сврзник</para><para>spojka</para><para>veznik</para><para>везник</para><para>spojka</para><para>съюз</para><para>союз</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Conjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#Conjunction</seealso>
    let Conjunction = Prefixed_Name(lexinfov3, "Conjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefiniteMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A word indicating imprecise number of times something happened.</para>
    /// labels<para>indefinite multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteMultiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteMultiplicativeNumeral</seealso>
    let indefiniteMultiplicativeNumeral =
        Prefixed_Name(lexinfov3, "indefiniteMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefiniteOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>indefinite ordinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteOrdinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteOrdinalNumeral</seealso>
    let IndefiniteOrdinalNumeral =
        Prefixed_Name(lexinfov3, "IndefiniteOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:collectiveNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>collective number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#collectiveNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#collectiveNumberForm</seealso>
    let collectiveNumberForm =
        Prefixed_Name(lexinfov3, "collectiveNumberForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:copulativeArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama</para>
    /// labels<para>copulative arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeArg">http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeArg</seealso>
    let copulativeArg = Prefixed_Name(lexinfov3, "copulativeArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefiniteDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Determiner not capable of identification.</para>
    /// labels<para>determinatzaile mugagabe</para><para>determinante indefinido</para><para>indefinite determiner</para><para>déterminant indéfini</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteDeterminer</seealso>
    let indefiniteDeterminer =
        Prefixed_Name(lexinfov3, "indefiniteDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefiniteMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>indefinite multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteMultiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteMultiplicativeNumeral</seealso>
    let IndefiniteMultiplicativeNumeral =
        Prefixed_Name(lexinfov3, "IndefiniteMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefiniteOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>A word used to indicate imprecise rank of an object in a sequence.</para>
    /// labels<para>indefinite ordinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteOrdinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteOrdinalNumeral</seealso>
    let indefiniteOrdinalNumeral =
        Prefixed_Name(lexinfov3, "indefiniteOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefinitePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>неопределённое местоимение</para><para>Onbepaald voornaamwoord</para><para>неозначений займенник</para><para>Neodređene zamjenice</para><para>pronombre indefinido</para><para>nežymimasis įvardis</para><para>izenordain mugagabe</para><para>határozatlan névmás</para><para>zaimek nieokreślony</para><para>неодређена заменица</para><para>indefinit pronomen</para><para>pronome indefinido</para><para>pronome indefinito</para><para>indefinite pronoun</para><para>umbmäärane asesõna</para><para>pronome indefinido</para><para>indefinit pronomen</para><para>Indefinitpronomen</para><para>Pronume nehotărât</para><para>αόριστη αντωνυμία</para><para>óákveðið fornafn</para><para>neurčité zájmeno</para><para>pronom indefinit</para><para>pronom indéfini</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefinitePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefinitePronoun</seealso>
    let IndefinitePronoun =
        Prefixed_Name(lexinfov3, "IndefinitePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:OpenParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>open parenthesis</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#OpenParenthesis">http://www.lexinfo.net/ontology/3.0/lexinfo#OpenParenthesis</seealso>
    let OpenParenthesis = Prefixed_Name(lexinfov3, "OpenParenthesis") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:predicativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>predicative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdjunct</seealso>
    let predicativeAdjunct =
        Prefixed_Name(lexinfov3, "predicativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:comparativeDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>comparative degree form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeDegreeForm">http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeDegreeForm</seealso>
    let comparativeDegreeForm =
        Prefixed_Name(lexinfov3, "comparativeDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:pluralNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>plural number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pluralNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#pluralNumberForm</seealso>
    let pluralNumberForm = Prefixed_Name(lexinfov3, "pluralNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:positive</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Degree</para>
    ///   <para>owl:Thing</para>
    ///   <para>Value used in a comparison relationship when no comparison is involved.</para>
    /// labels<para>positive</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#positive">http://www.lexinfo.net/ontology/3.0/lexinfo#positive</seealso>
    let positive = Prefixed_Name(lexinfov3, "positive") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveDativePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective dative post positive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveDativePostPositiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveDativePostPositiveFrame</seealso>
    let AdjectiveDativePostPositiveFrame =
        Prefixed_Name(lexinfov3, "AdjectiveDativePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Auxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pagalbinis veiksmažodis</para><para>вспомогательный глагол</para><para>czasownik posiłkowy</para><para>допоміжне дієслово</para><para>aditz laguntzaile</para><para>verbe auxiliaire</para><para>pomocné sloveso</para><para>verb awżiljarju</para><para>помошен глагол</para><para>помоћни глагол</para><para>verbo auxiliar</para><para>verbo auxiliar</para><para>briathar cúnta</para><para>pomožni glagol</para><para>verbo auxiliar</para><para>hulpwerkwoord</para><para>Verb auxiliar</para><para>hjælpeverbum</para><para>abitegusõna</para><para>hjálparsögn</para><para>hjelpeverb</para><para>hjelpeverb</para><para>auxiliary</para><para>Hilfsverb</para><para>βοηθητικό</para><para>hjälpverb</para><para>ausiliare</para><para>segédige</para><para>פועל עזר</para><para>auxiliar</para><para>apuverbi</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Auxiliary">http://www.lexinfo.net/ontology/3.0/lexinfo#Auxiliary</seealso>
    let Auxiliary = Prefixed_Name(lexinfov3, "Auxiliary") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>darbības vārds</para><para>veiksmažodis</para><para>udsagnsord</para><para>werkwoord</para><para>czasownik</para><para>tegusõna</para><para>briathar</para><para>дієслово</para><para>дзеяслоў</para><para>sloveso</para><para>sagnorð</para><para>glagoli</para><para>sloveso</para><para>глагол</para><para>glagol</para><para>глагол</para><para>глагол</para><para>глагол</para><para>verbo</para><para>verbo</para><para>aditz</para><para>verbo</para><para>verbo</para><para>verbi</para><para>verbe</para><para>folje</para><para>verb</para><para>Verb</para><para>Verb</para><para>verb</para><para>פועל</para><para>verb</para><para>verb</para><para>verb</para><para>ρήμα</para><para>verb</para><para>verb</para><para>ige</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Verb">http://www.lexinfo.net/ontology/3.0/lexinfo#Verb</seealso>
    let Verb = Prefixed_Name(lexinfov3, "Verb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:CardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>количественное числительное</para><para>kiekinis skaitvardis</para><para>zenbatzaile kardinal</para><para>adjetivo cardinal</para><para>číslovka základní</para><para>απόλυτος αριθμός</para><para>numeral cardinal</para><para>numero cardinale</para><para>cardinal numeral</para><para>numeral cardinal</para><para>liczebnik główny</para><para>Glavni števnik</para><para>Hoofdtelwoord</para><para>Kardinalzahl</para><para>основни број</para><para>grunntall</para><para>tőszámnév</para><para>mængdetal</para><para>cardinal</para><para>frumtala</para><para>Grundtal</para><para>põhiarv</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#CardinalNumeral</seealso>
    let CardinalNumeral = Prefixed_Name(lexinfov3, "CardinalNumeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>имя числительное</para><para>числително име</para><para>skaitļa vārds</para><para>zenbatzaile</para><para>skaitvardis</para><para>αριθμητικό</para><para>numeraali</para><para>liczebnik</para><para>числівник</para><para>číslovka</para><para>Numerale</para><para>räkneord</para><para>numerale</para><para>číslovka</para><para>лічэбнік</para><para>telwoord</para><para>numerale</para><para>számnév</para><para>brojevi</para><para>Numeral</para><para>števnik</para><para>нумерал</para><para>töluorð</para><para>numeral</para><para>numeral</para><para>tallord</para><para>numeral</para><para>numeral</para><para>numéral</para><para>Numeral</para><para>numeral</para><para>arvsõna</para><para>talord</para><para>מספר</para><para>број</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Numeral">http://www.lexinfo.net/ontology/3.0/lexinfo#Numeral</seealso>
    let Numeral = Prefixed_Name(lexinfov3, "Numeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rasa gramatikore</para><para>cas grammatical</para><para>caso gramatical</para><para>caso gramatical</para><para>kasu gramatikal</para><para>caso gramatical</para><para>cas gramatical</para><para>mluvnický pád</para><para>przypadek</para><para>linksnis</para><para>відмінок</para><para>locījums</para><para>naamval</para><para>πτώση</para><para>kasus</para><para>падеж</para><para>kasus</para><para>Kasus</para><para>kasus</para><para>падеж</para><para>kasus</para><para>kääne</para><para>падеж</para><para>склон</para><para>padež</para><para>падеж</para><para>sklon</para><para>case</para><para>caso</para><para>יחסה</para><para>fall</para><para>sija</para><para>eset</para><para>caz</para><para>pád</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Case">http://www.lexinfo.net/ontology/3.0/lexinfo#Case</seealso>
    let Case = Prefixed_Name(lexinfov3, "Case") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:fusedPrepositionDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>word resulting from the aggregation of a proposition and a determiner</para>
    /// labels<para>fused preposition determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionDeterminer</seealso>
    let fusedPrepositionDeterminer =
        Prefixed_Name(lexinfov3, "fusedPrepositionDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FusedPrepositionPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fused preposition pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPronoun</seealso>
    let FusedPrepositionPronoun =
        Prefixed_Name(lexinfov3, "FusedPrepositionPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FutureParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>future particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FutureParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#FutureParticle</seealso>
    let FutureParticle = Prefixed_Name(lexinfov3, "FutureParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:futureParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Particle used in order to express future.</para>
    /// labels<para>future particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#futureParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#futureParticle</seealso>
    let futureParticle = Prefixed_Name(lexinfov3, "futureParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:locativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>locative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCaseForm</seealso>
    let locativeCaseForm = Prefixed_Name(lexinfov3, "locativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:logicalExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>An expression used to represent a concept based on mathematical or logical relations, such as statements of inequality, set relationships, boolean operations, and the like.</para>
    /// labels<para>logical expression</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#logicalExpression">http://www.lexinfo.net/ontology/3.0/lexinfo#logicalExpression</seealso>
    let logicalExpression =
        Prefixed_Name(lexinfov3, "logicalExpression") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:tabooRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///
    /// labels<para>taboo register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#tabooRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#tabooRegister</seealso>
    let tabooRegister = Prefixed_Name(lexinfov3, "tabooRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:technicalRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>The register appropriate to scientific texts or special languages.</para>
    /// labels<para>technical register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#technicalRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#technicalRegister</seealso>
    let technicalRegister =
        Prefixed_Name(lexinfov3, "technicalRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:tense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property referring to the way the grammar marks the time at which the action denoted by the verb took place.</para>
    /// labels<para>Gramatická kategória času</para><para>darbības vārda laiks</para><para>γραμματικός χρόνος</para><para>denbora gramatikal</para><para>Gramatinis laikas</para><para>tiempo gramatical</para><para>tempo gramatical</para><para>tempo gramatical</para><para>temps gramatical</para><para>Tíðbeyging sagna</para><para>глаголско време</para><para>werkwoordstijd</para><para>Glagolski čas</para><para>aikamuoto</para><para>tempus</para><para>tempus</para><para>igeidő</para><para>Tempus</para><para>время</para><para>temps</para><para>tense</para><para>време</para><para>Време</para><para>tempo</para><para>czas</para><para>Timp</para><para>čas</para><para>tid</para><para>זמן</para><para>час</para><para>час</para><para>Aeg</para><para>tid</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#tense">http://www.lexinfo.net/ontology/3.0/lexinfo#tense</seealso>
    let tense = Prefixed_Name(lexinfov3, "tense") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:termElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any logically significant portion of a larger term or lexeme.</para>
    /// labels<para>term element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#termElement">http://www.lexinfo.net/ontology/3.0/lexinfo#termElement</seealso>
    let termElement = Prefixed_Name(lexinfov3, "termElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:terminativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that indicates to what or where something ends.</para>
    /// labels<para>terminative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCase</seealso>
    let terminativeCase = Prefixed_Name(lexinfov3, "terminativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:terminativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>terminative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#terminativeCaseForm</seealso>
    let terminativeCaseForm =
        Prefixed_Name(lexinfov3, "terminativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:textType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the typical use of a lexical unit in a particular discourse type or genre</para>
    /// labels<para>text type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#textType">http://www.lexinfo.net/ontology/3.0/lexinfo#textType</seealso>
    let textType = Prefixed_Name(lexinfov3, "textType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:thirdPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>third person form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPersonForm">http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPersonForm</seealso>
    let thirdPersonForm = Prefixed_Name(lexinfov3, "thirdPersonForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:transcribedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A form of a term or lexeme resulting from an operation whereby the characters of one writing system are represented by characters from another writing system, taking into account the pronunciation of the characters converted.</para>
    /// labels<para>transcribed form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#transcribedForm">http://www.lexinfo.net/ontology/3.0/lexinfo#transcribedForm</seealso>
    let transcribedForm = Prefixed_Name(lexinfov3, "transcribedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:translation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Indicates that two terms are translations of one another; this is the same as interlingual synonymy</para>
    /// labels<para>translation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#translation">http://www.lexinfo.net/ontology/3.0/lexinfo#translation</seealso>
    let translation = Prefixed_Name(lexinfov3, "translation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:translativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case indicating that the referent of the noun, or the quality of the adjective, that it marks is the result of a process of change.</para>
    /// labels<para>translative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCase</seealso>
    let translativeCase = Prefixed_Name(lexinfov3, "translativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:translativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>translative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#translativeCaseForm</seealso>
    let translativeCaseForm =
        Prefixed_Name(lexinfov3, "translativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:superlativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>superlative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeAdjunct</seealso>
    let superlativeAdjunct =
        Prefixed_Name(lexinfov3, "superlativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>apposizione</para><para>adposition</para><para>adposition</para><para>adposition</para><para>adpozicija</para><para>adposisjon</para><para>adposición</para><para>Adposition</para><para>adposition</para><para>адпозиција</para><para>forsetning</para><para>Prepoziție</para><para>adposition</para><para>adpositio</para><para>adposizio</para><para>adpozíció</para><para>parafjalë</para><para>aposición</para><para>adposição</para><para>adposició</para><para>przyimek</para><para>מילת יחס</para><para>kaassõna</para><para>záložka</para><para>πρόθεση</para><para>адлог</para><para>афикс</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adposition">http://www.lexinfo.net/ontology/3.0/lexinfo#Adposition</seealso>
    let Adposition = Prefixed_Name(lexinfov3, "Adposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:InfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#InfinitiveClause</seealso>
    let InfinitiveClause = Prefixed_Name(lexinfov3, "InfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjectlessIntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>subjectless intransitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitivePPFrame</seealso>
    let SubjectlessIntransitivePPFrame =
        Prefixed_Name(lexinfov3, "SubjectlessIntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:directCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>An unmarked case which covers the single argument of a one-place verb and the agent and patient arguments of a transitive verb.</para>
    /// labels<para>direct case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#directCase">http://www.lexinfo.net/ontology/3.0/lexinfo#directCase</seealso>
    let directCase = Prefixed_Name(lexinfov3, "directCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:directCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>direct case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#directCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#directCaseForm</seealso>
    let directCaseForm = Prefixed_Name(lexinfov3, "directCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the specialized field of knowledge in which a lexical unit is mainly used</para>
    /// labels<para>domain</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#domain">http://www.lexinfo.net/ontology/3.0/lexinfo#domain</seealso>
    let domain = Prefixed_Name(lexinfov3, "domain") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:dual</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>Form used in some languages to designate two persons or things. // The form used in some languages to designate two persons or things.</para>
    /// labels<para>dual</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dual">http://www.lexinfo.net/ontology/3.0/lexinfo#dual</seealso>
    let dual = Prefixed_Name(lexinfov3, "dual") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Adjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#Adjunct</seealso>
    let Adjunct = Prefixed_Name(lexinfov3, "Adjunct") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AdpositionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>apposizione</para><para>adposition</para><para>Adposition</para><para>forsetning</para><para>adposisjon</para><para>adposition</para><para>Prepoziție</para><para>adposición</para><para>adposition</para><para>адпозиција</para><para>adpozicija</para><para>adposition</para><para>adposition</para><para>parafjalë</para><para>aposición</para><para>adpozíció</para><para>adpositio</para><para>adposição</para><para>adposizio</para><para>adposició</para><para>kaassõna</para><para>מילת יחס</para><para>przyimek</para><para>záložka</para><para>πρόθεση</para><para>афикс</para><para>адлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionPOS</seealso>
    let AdpositionPOS = Prefixed_Name(lexinfov3, "AdpositionPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Word or sound that expresses an emotion.</para>
    /// labels<para>pasthirrma - themelet e ngurtësuara të gjuhës</para><para>izsauksmes vārds</para><para>tussenwerpsel</para><para>inteġrezzjoni</para><para>Interjektion</para><para>interxección</para><para>interjeksjon</para><para>interjection</para><para>interjección</para><para>interiezione</para><para>interjektion</para><para>interjeksjon</para><para>interjektion</para><para>interjection</para><para>interjecció</para><para>interjekzio</para><para>interjektio</para><para>interjeição</para><para>interjecție</para><para>citoslovce</para><para>indulatszó</para><para>citoslovce</para><para>междуметие</para><para>междометие</para><para>מילת קריאה</para><para>wykrzyknik</para><para>выклічнік</para><para>upphrópun</para><para>intriacht</para><para>jaustukas</para><para>επιφώνημα</para><para>hüüdsõna</para><para>usklici</para><para>medmet</para><para>извик</para><para>узвик</para><para>вигук</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interjection">http://www.lexinfo.net/ontology/3.0/lexinfo#interjection</seealso>
    let interjection = Prefixed_Name(lexinfov3, "interjection") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>interrogative cardinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeCardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeCardinalNumeral</seealso>
    let InterrogativeCardinalNumeral =
        Prefixed_Name(lexinfov3, "InterrogativeCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>persoonlijk voornaamwoord</para><para>personligt pronomen</para><para>personligt pronomen</para><para>pertsona-izenordain</para><para>προσωπική αντωνυμία</para><para>pronombre personal</para><para>особовий займенник</para><para>личное местоимение</para><para>personleg pronomen</para><para>pronome personale</para><para>asmeninis įvardis</para><para>лично местоимение</para><para>isikuline asesõna</para><para>persoonapronomini</para><para>Pronume personal</para><para>Personalpronomen</para><para>personal pronoun</para><para>osobna zamjenica</para><para>pronom personnel</para><para>személyes névmás</para><para>pronome persoal</para><para>pronom personal</para><para>pronome pessoal</para><para>osobní zájmeno</para><para>лична заменица</para><para>persónufornafn</para><para>zaimek osobowy</para><para>osebni zaimek</para><para>כינוי גוף</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#PersonalPronoun</seealso>
    let PersonalPronoun = Prefixed_Name(lexinfov3, "PersonalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:personalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Pronoun referring a person.</para>
    /// labels<para>persoonlijk voornaamwoord</para><para>personligt pronomen</para><para>pertsona-izenordain</para><para>προσωπική αντωνυμία</para><para>personligt pronomen</para><para>особовий займенник</para><para>личное местоимение</para><para>pronombre personal</para><para>personleg pronomen</para><para>persoonapronomini</para><para>asmeninis įvardis</para><para>isikuline asesõna</para><para>лично местоимение</para><para>pronome personale</para><para>osobna zamjenica</para><para>személyes névmás</para><para>pronom personnel</para><para>Pronume personal</para><para>personal pronoun</para><para>Personalpronomen</para><para>pronome pessoal</para><para>pronome persoal</para><para>pronom personal</para><para>persónufornafn</para><para>zaimek osobowy</para><para>лична заменица</para><para>osobní zájmeno</para><para>osebni zaimek</para><para>כינוי גוף</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#personalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#personalPronoun</seealso>
    let personalPronoun = Prefixed_Name(lexinfov3, "personalPronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:PlainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>aditz arrunt</para><para>verbo común</para><para>plain verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PlainVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#PlainVerb</seealso>
    let PlainVerb = Prefixed_Name(lexinfov3, "PlainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:plainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>verb which has its own semantics</para>
    /// labels<para>aditz arrunt</para><para>verbo común</para><para>plain verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#plainVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#plainVerb</seealso>
    let plainVerb = Prefixed_Name(lexinfov3, "plainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>point</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Point">http://www.lexinfo.net/ontology/3.0/lexinfo#Point</seealso>
    let Point = Prefixed_Name(lexinfov3, "Point") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Sign (.) used to expresses the end of a sentence or an abbreviation.</para>
    /// labels<para>point</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#point">http://www.lexinfo.net/ontology/3.0/lexinfo#point</seealso>
    let point = Prefixed_Name(lexinfov3, "point") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>possessive adjective</para><para>adjektibo posesibo</para><para>adjetivo posesivo</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjective</seealso>
    let PossessiveAdjective =
        Prefixed_Name(lexinfov3, "PossessiveAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Determiner that expresses ownership.</para>
    /// labels<para>притяжательный детерминатив</para><para>determinatzaile posesibo</para><para>possessive determiner</para><para>determinante posesivo</para><para>déterminant possessif</para><para>aggettivo possessivo</para><para>присвојни придеви</para><para>adjectiv posesiv</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveDeterminer</seealso>
    let possessiveDeterminer =
        Prefixed_Name(lexinfov3, "possessiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>possessive infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveInfinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveInfinitiveClause</seealso>
    let PossessiveInfinitiveClause =
        Prefixed_Name(lexinfov3, "PossessiveInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>possessive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveParticle</seealso>
    let PossessiveParticle =
        Prefixed_Name(lexinfov3, "PossessiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Particle expressing ownship.</para>
    /// labels<para>possessive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveParticle</seealso>
    let possessiveParticle =
        Prefixed_Name(lexinfov3, "possessiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TermElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>term element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TermElement">http://www.lexinfo.net/ontology/3.0/lexinfo#TermElement</seealso>
    let TermElement = Prefixed_Name(lexinfov3, "TermElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:TransfixMorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transfix is a discontinuous affix that disrupts the base to which it is attached. The term is reserved for true single affixes, rather than combinations of an infix with an independent prefix or suffix. (Broselow, E., 2000. Transfixation. In G. Booij, et al. (eds.), Ein internationales Handbuch zur Flexion und Wortbildung. 1. Halbband. Mouton De Gruyter, New York, Berlin, p. 552-557.) Examples include discontinuous affixes inserted into a word root, as in root-and-pattern systems of several Semitic languages, e.g., in the Arabic word kitaba "writing" from the root k-t-b.</para>
    /// labels<para>transfix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransfixMorph">http://www.lexinfo.net/ontology/3.0/lexinfo#TransfixMorph</seealso>
    let TransfixMorph = Prefixed_Name(lexinfov3, "TransfixMorph") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveAdjectivalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive adjectival complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdjectivalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveAdjectivalComplementFrame</seealso>
    let TransitiveAdjectivalComplementFrame =
        Prefixed_Name(lexinfov3, "TransitiveAdjectivalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive declarative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveDeclarativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveDeclarativeFrame</seealso>
    let TransitiveDeclarativeFrame =
        Prefixed_Name(lexinfov3, "TransitiveDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveInfinitiveACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive infinitive ac frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveACFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveACFrame</seealso>
    let TransitiveInfinitiveACFrame =
        Prefixed_Name(lexinfov3, "TransitiveInfinitiveACFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveInfinitiveOCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive infinitive oc frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveOCFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveOCFrame</seealso>
    let TransitiveInfinitiveOCFrame =
        Prefixed_Name(lexinfov3, "TransitiveInfinitiveOCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indicative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Mood</para>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///   <para>Mood value used in the expression of statements and questions.</para>
    /// labels<para>indicative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indicative">http://www.lexinfo.net/ontology/3.0/lexinfo#indicative</seealso>
    let indicative = Prefixed_Name(lexinfov3, "indicative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indicativeMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>indicative mood form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indicativeMoodForm">http://www.lexinfo.net/ontology/3.0/lexinfo#indicativeMoodForm</seealso>
    let indicativeMoodForm =
        Prefixed_Name(lexinfov3, "indicativeMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indifferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:ModificationType</para>
    ///   <para>Markup to express that there is not any pertinence.</para>
    /// labels<para>indifferent</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indifferent">http://www.lexinfo.net/ontology/3.0/lexinfo#indifferent</seealso>
    let indifferent = Prefixed_Name(lexinfov3, "indifferent") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:inessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses the meaning of location or position within a place.</para>
    /// labels<para>inessive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCase</seealso>
    let inessiveCase = Prefixed_Name(lexinfov3, "inessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:inessiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inessive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#inessiveCaseForm</seealso>
    let inessiveCaseForm = Prefixed_Name(lexinfov3, "inessiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:infinitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///   <para>Mood cited as unmarked or base form.</para>
    /// labels<para>infinitive</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#infinitive">http://www.lexinfo.net/ontology/3.0/lexinfo#infinitive</seealso>
    let infinitive = Prefixed_Name(lexinfov3, "infinitive") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:infix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermElement</para>
    ///
    /// labels<para>Innskeyti</para><para>Intarpas</para><para>erdizki</para><para>wrostek</para><para>infisso</para><para>infiks</para><para>infixo</para><para>инфикс</para><para>infixe</para><para>Infiks</para><para>infijo</para><para>infiks</para><para>Infixo</para><para>инфикс</para><para>інфікс</para><para>Инфикс</para><para>Infix</para><para>infix</para><para>Vpona</para><para>infix</para><para>infix</para><para>infix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#infix">http://www.lexinfo.net/ontology/3.0/lexinfo#infix</seealso>
    let infix = Prefixed_Name(lexinfov3, "infix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:infrequentlyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Frequency</para>
    ///   <para>owl:Thing</para>
    ///   <para>Said of a term that does not appear frequently.</para>
    /// labels<para>infrequently used</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#infrequentlyUsed">http://www.lexinfo.net/ontology/3.0/lexinfo#infrequentlyUsed</seealso>
    let infrequentlyUsed = Prefixed_Name(lexinfov3, "infrequentlyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:initialism</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>owl:Thing</para>
    ///   <para>An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced letter by letter.</para>
    /// labels<para>initialism</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#initialism">http://www.lexinfo.net/ontology/3.0/lexinfo#initialism</seealso>
    let initialism = Prefixed_Name(lexinfov3, "initialism") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:initialismFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between an initialism and its full or expanded form.</para>
    /// labels<para>initialism for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#initialismFor">http://www.lexinfo.net/ontology/3.0/lexinfo#initialismFor</seealso>
    let initialismFor = Prefixed_Name(lexinfov3, "initialismFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:instrumentalCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case indicating that the referent of the noun it marks is the means of the accomplishment of the action expressed by the clause.</para>
    /// labels<para>instrumental case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCase">http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCase</seealso>
    let instrumentalCase = Prefixed_Name(lexinfov3, "instrumentalCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:instrumentalCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>instrumental case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#instrumentalCaseForm</seealso>
    let instrumentalCaseForm =
        Prefixed_Name(lexinfov3, "instrumentalCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:internationalScientificTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A term that is part of an international scientific nomenclature as adopted by an appropriate scientific body.</para>
    /// labels<para>international scientific term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#internationalScientificTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#internationalScientificTerm</seealso>
    let internationalScientificTerm =
        Prefixed_Name(lexinfov3, "internationalScientificTerm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:internationalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term that has the same or nearly identical orthographic or phonemic form in many languages.</para>
    /// labels<para>internationalism</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#internationalism">http://www.lexinfo.net/ontology/3.0/lexinfo#internationalism</seealso>
    let internationalism = Prefixed_Name(lexinfov3, "internationalism") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ironicRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///
    /// labels<para>ironic register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ironicRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#ironicRegister</seealso>
    let ironicRegister = Prefixed_Name(lexinfov3, "ironicRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:lativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses motion to a location.</para>
    /// labels<para>lative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCase</seealso>
    let lativeCase = Prefixed_Name(lexinfov3, "lativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:lativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#lativeCaseForm</seealso>
    let lativeCaseForm = Prefixed_Name(lexinfov3, "lativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:legalTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term that is legally defined and used in legally binding documents.</para>
    /// labels<para>legal term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#legalTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#legalTerm</seealso>
    let legalTerm = Prefixed_Name(lexinfov3, "legalTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:locativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that indicates a final location of action or a time of the action.</para>
    /// labels<para>locative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#locativeCase</seealso>
    let locativeCase = Prefixed_Name(lexinfov3, "locativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:masculine</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Gender</para>
    ///   <para>owl:Thing</para>
    ///   <para>Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to males.</para>
    /// labels<para>masculine</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#masculine">http://www.lexinfo.net/ontology/3.0/lexinfo#masculine</seealso>
    let masculine = Prefixed_Name(lexinfov3, "masculine") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:massNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>Designation of a term or word that is not countable and cannot generally be used with the indefinite article or in the plural.</para>
    /// labels<para>mass noun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#massNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#massNoun</seealso>
    let massNoun = Prefixed_Name(lexinfov3, "massNoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:massNounNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>mass noun number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#massNounNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#massNounNumberForm</seealso>
    let massNounNumberForm =
        Prefixed_Name(lexinfov3, "massNounNumberForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:meaningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies a semantic extension of the sense of a given lexical unit</para>
    /// labels<para>meaning type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#meaningType">http://www.lexinfo.net/ontology/3.0/lexinfo#meaningType</seealso>
    let meaningType = Prefixed_Name(lexinfov3, "meaningType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:memberHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the object is a member of this</para>
    /// labels<para>member holonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#memberHolonym">http://www.lexinfo.net/ontology/3.0/lexinfo#memberHolonym</seealso>
    let memberHolonym = Prefixed_Name(lexinfov3, "memberHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:memberMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates this is an element of the other</para>
    /// labels<para>member meronym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#memberMeronym">http://www.lexinfo.net/ontology/3.0/lexinfo#memberMeronym</seealso>
    let memberMeronym = Prefixed_Name(lexinfov3, "memberMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:middleVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Voice</para>
    ///   <para>Value for middle voice that expresses that the subject is both the agent and object, or that the subject is separate from the agent or that the receiver is the agent him/herself.</para>
    /// labels<para>middle voice</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#middleVoice">http://www.lexinfo.net/ontology/3.0/lexinfo#middleVoice</seealso>
    let middleVoice = Prefixed_Name(lexinfov3, "middleVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:modern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Dating</para>
    ///   <para>Currently in use.</para>
    /// labels<para>modern</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#modern">http://www.lexinfo.net/ontology/3.0/lexinfo#modern</seealso>
    let modern = Prefixed_Name(lexinfov3, "modern") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:morphologicalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>Unit resulting from the division of words into their smallest meaningful parts.
    /// Note: moved to lexeme element from being an independent element; note that this is currently an independent element in 12620</para>
    /// labels<para>morphological element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#morphologicalElement">http://www.lexinfo.net/ontology/3.0/lexinfo#morphologicalElement</seealso>
    let morphologicalElement =
        Prefixed_Name(lexinfov3, "morphologicalElement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>denotes the negation or the absence</para>
    /// labels<para>negative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#negative">http://www.lexinfo.net/ontology/3.0/lexinfo#negative</seealso>
    let negative = Prefixed_Name(lexinfov3, "negative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:negativeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>negative form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativeForm">http://www.lexinfo.net/ontology/3.0/lexinfo#negativeForm</seealso>
    let negativeForm = Prefixed_Name(lexinfov3, "negativeForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:neuter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Gender</para>
    ///   <para>Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to objects that are not characterized as male or female.</para>
    /// labels<para>neuter</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#neuter">http://www.lexinfo.net/ontology/3.0/lexinfo#neuter</seealso>
    let neuter = Prefixed_Name(lexinfov3, "neuter") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:neutralRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>The register appropriate to general texts or discourse.</para>
    /// labels<para>neutral register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#neutralRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#neutralRegister</seealso>
    let neutralRegister = Prefixed_Name(lexinfov3, "neutralRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:no</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Negative</para>
    ///   <para>lexinfov3:Cliticness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Value for negation.</para>
    /// labels<para>no</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#no">http://www.lexinfo.net/ontology/3.0/lexinfo#no</seealso>
    let no = Prefixed_Name(lexinfov3, "no") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:nominativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case used to indicate the subject of a verb.</para>
    /// labels<para>nominative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCase</seealso>
    let nominativeCase = Prefixed_Name(lexinfov3, "nominativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdpositionalObject</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>adpositional object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionalObject">http://www.lexinfo.net/ontology/3.0/lexinfo#AdpositionalObject</seealso>
    let AdpositionalObject =
        Prefixed_Name(lexinfov3, "AdpositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Adverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>apstākļa vārds</para><para>prieveiksmis</para><para>dobhriathar</para><para>határozószó</para><para>прислівник</para><para>przysłówek</para><para>příslovce</para><para>תואר פועל</para><para>príslovka</para><para>atviksorð</para><para>ndajfolje</para><para>määrsõna</para><para>advérbio</para><para>adberbio</para><para>επίρρημα</para><para>bijwoord</para><para>avverbio</para><para>прыслоўе</para><para>adverbio</para><para>adverbio</para><para>prilozi</para><para>prislov</para><para>наречие</para><para>adverbe</para><para>adverbi</para><para>adverbi</para><para>наречие</para><para>Adverb</para><para>adverb</para><para>прилог</para><para>adverb</para><para>прилог</para><para>adverb</para><para>adverb</para><para>avverb</para><para>adverb</para><para>biord</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adverb">http://www.lexinfo.net/ontology/3.0/lexinfo#Adverb</seealso>
    let Adverb = Prefixed_Name(lexinfov3, "Adverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Interjection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pasthirrma - themelet e ngurtësuara të gjuhës</para><para>izsauksmes vārds</para><para>tussenwerpsel</para><para>inteġrezzjoni</para><para>interiezione</para><para>interjection</para><para>interjeksjon</para><para>interxección</para><para>interjektion</para><para>interjection</para><para>Interjektion</para><para>interjeksjon</para><para>interjektion</para><para>interjección</para><para>interjekzio</para><para>interjektio</para><para>interjecció</para><para>interjecție</para><para>interjeição</para><para>wykrzyknik</para><para>междометие</para><para>מילת קריאה</para><para>междуметие</para><para>citoslovce</para><para>indulatszó</para><para>citoslovce</para><para>intriacht</para><para>jaustukas</para><para>επιφώνημα</para><para>выклічнік</para><para>upphrópun</para><para>hüüdsõna</para><para>usklici</para><para>medmet</para><para>узвик</para><para>вигук</para><para>извик</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Interjection">http://www.lexinfo.net/ontology/3.0/lexinfo#Interjection</seealso>
    let Interjection = Prefixed_Name(lexinfov3, "Interjection") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:pastParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adjective based on a past participle.</para>
    /// labels<para>lehenaldiko partizipio-adjektibo</para><para>adjetivo de participio pasado</para><para>past participle adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pastParticipleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#pastParticipleAdjective</seealso>
    let pastParticipleAdjective =
        Prefixed_Name(lexinfov3, "pastParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>proprietate morfosintactică a persoanei</para><para>darbības vārda persona</para><para>ιδιότητα του προσώπου</para><para>proprietà di persona</para><para>pertsona gramatikal</para><para>persona gramatical</para><para>persoa gramatical</para><para>grammatisk person</para><para>grammatisk person</para><para>grammatisk person</para><para>pessoa gramatical</para><para>граматична особа</para><para>Veta gramatikore</para><para>Slovnična oseba</para><para>asmens požymis</para><para>personne</para><para>persoona</para><para>persóna</para><para>személy</para><para>persona</para><para>persoon</para><para>person</para><para>person</para><para>Person</para><para>osoba</para><para>Osoba</para><para>osoba</para><para>isik</para><para>лице</para><para>лицо</para><para>лице</para><para>גוף</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Person">http://www.lexinfo.net/ontology/3.0/lexinfo#Person</seealso>
    let Person = Prefixed_Name(lexinfov3, "Person") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:explanation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.</para>
    /// labels<para>explanation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#explanation">http://www.lexinfo.net/ontology/3.0/lexinfo#explanation</seealso>
    let explanation = Prefixed_Name(lexinfov3, "explanation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:facetiousRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Register</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>facetious register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#facetiousRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#facetiousRegister</seealso>
    let facetiousRegister =
        Prefixed_Name(lexinfov3, "facetiousRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:feminine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Gender</para>
    ///   <para>Of, relating to, or constituting the gender that ordinarily includes most words or grammatical forms referring to females.</para>
    /// labels<para>feminine</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#feminine">http://www.lexinfo.net/ontology/3.0/lexinfo#feminine</seealso>
    let feminine = Prefixed_Name(lexinfov3, "feminine") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prepositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prepositional object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalObject">http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalObject</seealso>
    let prepositionalObject =
        Prefixed_Name(lexinfov3, "prepositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Tense</para>
    ///   <para>Verb tense that indicates action or state of being in the present.</para>
    /// labels<para>present</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#present">http://www.lexinfo.net/ontology/3.0/lexinfo#present</seealso>
    let present = Prefixed_Name(lexinfov3, "present") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Object</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Object">http://www.lexinfo.net/ontology/3.0/lexinfo#Object</seealso>
    let Object = Prefixed_Name(lexinfov3, "Object") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AdverbPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>apstākļa vārds</para><para>prieveiksmis</para><para>határozószó</para><para>dobhriathar</para><para>прислівник</para><para>przysłówek</para><para>תואר פועל</para><para>atviksorð</para><para>príslovka</para><para>příslovce</para><para>ndajfolje</para><para>määrsõna</para><para>adverbio</para><para>bijwoord</para><para>avverbio</para><para>advérbio</para><para>επίρρημα</para><para>прыслоўе</para><para>adverbio</para><para>adberbio</para><para>adverbi</para><para>prilozi</para><para>наречие</para><para>adverbi</para><para>prislov</para><para>adverbe</para><para>наречие</para><para>adverb</para><para>Adverb</para><para>avverb</para><para>adverb</para><para>прилог</para><para>adverb</para><para>adverb</para><para>adverb</para><para>прилог</para><para>biord</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbPOS</seealso>
    let AdverbPOS = Prefixed_Name(lexinfov3, "AdverbPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdverbialComplement</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>adverbial complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplement">http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplement</seealso>
    let AdverbialComplement =
        Prefixed_Name(lexinfov3, "AdverbialComplement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early</para>
    /// labels<para>complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Complement">http://www.lexinfo.net/ontology/3.0/lexinfo#Complement</seealso>
    let Complement = Prefixed_Name(lexinfov3, "Complement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adverbial complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialComplementFrame</seealso>
    let AdverbialComplementFrame =
        Prefixed_Name(lexinfov3, "AdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:predicativeAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>predicative adverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#predicativeAdverb</seealso>
    let predicativeAdverb =
        Prefixed_Name(lexinfov3, "predicativeAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdverbialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adverbial pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#AdverbialPronoun</seealso>
    let AdverbialPronoun = Prefixed_Name(lexinfov3, "AdverbialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:affirmativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Particle used to express affirmation.</para>
    /// labels<para>baieztapen partikula</para><para>partícula afirmativa</para><para>affirmative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#affirmativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#affirmativeParticle</seealso>
    let affirmativeParticle =
        Prefixed_Name(lexinfov3, "affirmativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AffixedPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>affixed personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AffixedPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#AffixedPersonalPronoun</seealso>
    let AffixedPersonalPronoun =
        Prefixed_Name(lexinfov3, "AffixedPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:affixedPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Personnal pronoun that is affixed, i.e. added as an affix to another word.</para>
    /// labels<para>affixed personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#affixedPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#affixedPersonalPronoun</seealso>
    let affixedPersonalPronoun =
        Prefixed_Name(lexinfov3, "affixedPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AllusivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>allusive pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AllusivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#AllusivePronoun</seealso>
    let AllusivePronoun = Prefixed_Name(lexinfov3, "AllusivePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ArbitraryControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates either the subject or object of the main clause may be the omitted argument of the subclause</para>
    /// labels<para>arbitrary control</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ArbitraryControl">http://www.lexinfo.net/ontology/3.0/lexinfo#ArbitraryControl</seealso>
    let ArbitraryControl = Prefixed_Name(lexinfov3, "ArbitraryControl") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures</para>
    /// labels<para>control</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Control">http://www.lexinfo.net/ontology/3.0/lexinfo#Control</seealso>
    let Control = Prefixed_Name(lexinfov3, "Control") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>граматички члан</para><para>przedimek</para><para>членуване</para><para>artikelis</para><para>artikkeli</para><para>lidwoord</para><para>artikkel</para><para>artículo</para><para>kendeord</para><para>articolo</para><para>artikulu</para><para>artikuls</para><para>artikkel</para><para>artiklu</para><para>artikel</para><para>артикль</para><para>article</para><para>Artikel</para><para>артикль</para><para>articol</para><para>article</para><para>артыкль</para><para>article</para><para>greinir</para><para>Artikel</para><para>artigo</para><para>trajta</para><para>névelő</para><para>artigo</para><para>άρθρο</para><para>תווית</para><para>član</para><para>člen</para><para>член</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Article">http://www.lexinfo.net/ontology/3.0/lexinfo#Article</seealso>
    let Article = Prefixed_Name(lexinfov3, "Article") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveInfinitiveRSFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive infinitive rs frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveRSFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveRSFrame</seealso>
    let IntransitiveInfinitiveRSFrame =
        Prefixed_Name(lexinfov3, "IntransitiveInfinitiveRSFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive interrogative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInterrogativeFrame</seealso>
    let IntransitiveInterrogativeFrame =
        Prefixed_Name(lexinfov3, "IntransitiveInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveNominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive nominal complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveNominalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveNominalComplementFrame</seealso>
    let IntransitiveNominalComplementFrame =
        Prefixed_Name(lexinfov3, "IntransitiveNominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitivePPFrame</seealso>
    let IntransitivePPFrame =
        Prefixed_Name(lexinfov3, "IntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InvertedComma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>inverted comma</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InvertedComma">http://www.lexinfo.net/ontology/3.0/lexinfo#InvertedComma</seealso>
    let InvertedComma = Prefixed_Name(lexinfov3, "InvertedComma") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:invertedComma</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Inverted comma.</para>
    /// labels<para>inverted comma</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#invertedComma">http://www.lexinfo.net/ontology/3.0/lexinfo#invertedComma</seealso>
    let invertedComma = Prefixed_Name(lexinfov3, "invertedComma") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IrreflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>irreflexive personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IrreflexivePersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#IrreflexivePersonalPronoun</seealso>
    let IrreflexivePersonalPronoun =
        Prefixed_Name(lexinfov3, "IrreflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:irreflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>personal pronoun which is not reflexive</para>
    /// labels<para>irreflexive personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#irreflexivePersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#irreflexivePersonalPronoun</seealso>
    let irreflexivePersonalPronoun =
        Prefixed_Name(lexinfov3, "irreflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Buchstabe</para><para>Bókstafur</para><para>Shkronja</para><para>Buschtaf</para><para>kirjain</para><para>bogstav</para><para>bokstav</para><para>bokstav</para><para>bokstav</para><para>písmeno</para><para>lettera</para><para>písmeno</para><para>letter</para><para>literă</para><para>lettre</para><para>litera</para><para>lletra</para><para>letter</para><para>літара</para><para>Γράμμα</para><para>litir</para><para>letra</para><para>letra</para><para>burts</para><para>буква</para><para>letra</para><para>буква</para><para>letra</para><para>Raidė</para><para>буква</para><para>слово</para><para>Slovo</para><para>Буква</para><para>täht</para><para>Črka</para><para>betű</para><para>אות</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Letter">http://www.lexinfo.net/ontology/3.0/lexinfo#Letter</seealso>
    let Letter = Prefixed_Name(lexinfov3, "Letter") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///
    /// labels<para>Buchstabe</para><para>Bókstafur</para><para>Shkronja</para><para>Buschtaf</para><para>bokstav</para><para>bokstav</para><para>písmeno</para><para>lettera</para><para>kirjain</para><para>písmeno</para><para>bogstav</para><para>bokstav</para><para>letter</para><para>lettre</para><para>literă</para><para>літара</para><para>Γράμμα</para><para>litera</para><para>letter</para><para>lletra</para><para>letra</para><para>слово</para><para>letra</para><para>Буква</para><para>litir</para><para>буква</para><para>Raidė</para><para>Slovo</para><para>burts</para><para>буква</para><para>letra</para><para>буква</para><para>letra</para><para>täht</para><para>betű</para><para>Črka</para><para>אות</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#letter">http://www.lexinfo.net/ontology/3.0/lexinfo#letter</seealso>
    let letter = Prefixed_Name(lexinfov3, "letter") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:LightVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kategoriální sloveso</para><para>Funktionsverb</para><para>verbo ligero</para><para>aditz arin</para><para>light verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#LightVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#LightVerb</seealso>
    let LightVerb = Prefixed_Name(lexinfov3, "LightVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:lightVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>verb participating in a complex predication that has little semantic content of its own.</para>
    /// labels<para>Kategoriální sloveso</para><para>Funktionsverb</para><para>verbo ligero</para><para>light verb</para><para>aditz arin</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#lightVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#lightVerb</seealso>
    let lightVerb = Prefixed_Name(lexinfov3, "lightVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:MainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>verbo principal</para><para>hoofdwerkwoord</para><para>aditz nagusi</para><para>main verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#MainVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#MainVerb</seealso>
    let MainVerb = Prefixed_Name(lexinfov3, "MainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:mainVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Main verb in contrast to a modal or an auxiliary.</para>
    /// labels<para>verbo principal</para><para>hoofdwerkwoord</para><para>aditz nagusi</para><para>main verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#mainVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#mainVerb</seealso>
    let mainVerb = Prefixed_Name(lexinfov3, "mainVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Modal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modalinis veiksmažodis</para><para>modalt hjelpeverb</para><para>způsobové sloveso</para><para>modalt hjelpeverb</para><para>модальній дієслів</para><para>czasownik modalny</para><para>modalt hjälpverb</para><para>modaal werkwoord</para><para>модальный глагол</para><para>модален глагол</para><para>модални глагол</para><para>moduzko aditz</para><para>verbo modal</para><para>modális ige</para><para>verbe modal</para><para>modalverbum</para><para>Verb modal</para><para>háttarsögn</para><para>modaalverb</para><para>Modalverb</para><para>modale</para><para>modal</para><para>modal</para><para>modal</para><para>modal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Modal">http://www.lexinfo.net/ontology/3.0/lexinfo#Modal</seealso>
    let Modal = Prefixed_Name(lexinfov3, "Modal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:modal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Verb form that is usually used with another verb to express ideas such as possibilities, permission, or intention.</para>
    /// labels<para>modalinis veiksmažodis</para><para>modalt hjelpeverb</para><para>modalt hjelpeverb</para><para>czasownik modalny</para><para>způsobové sloveso</para><para>модальній дієслів</para><para>modaal werkwoord</para><para>modalt hjälpverb</para><para>модальный глагол</para><para>модални глагол</para><para>модален глагол</para><para>moduzko aditz</para><para>verbo modal</para><para>modalverbum</para><para>verbe modal</para><para>modális ige</para><para>háttarsögn</para><para>modaalverb</para><para>Verb modal</para><para>Modalverb</para><para>modale</para><para>modal</para><para>modal</para><para>modal</para><para>modal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#modal">http://www.lexinfo.net/ontology/3.0/lexinfo#modal</seealso>
    let modal = Prefixed_Name(lexinfov3, "modal") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ModificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>modification type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ModificationType">http://www.lexinfo.net/ontology/3.0/lexinfo#ModificationType</seealso>
    let ModificationType = Prefixed_Name(lexinfov3, "ModificationType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:MultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#MultiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#MultiplicativeNumeral</seealso>
    let MultiplicativeNumeral =
        Prefixed_Name(lexinfov3, "MultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:multiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>A word that expresses the number of times something happened.</para>
    /// labels<para>multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#multiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#multiplicativeNumeral</seealso>
    let multiplicativeNumeral =
        Prefixed_Name(lexinfov3, "multiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Negative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>negative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Negative">http://www.lexinfo.net/ontology/3.0/lexinfo#Negative</seealso>
    let Negative = Prefixed_Name(lexinfov3, "Negative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NegativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ezeztapen partikula</para><para>partícula negativa</para><para>negative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NegativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#NegativeParticle</seealso>
    let NegativeParticle = Prefixed_Name(lexinfov3, "NegativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:negativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Particle used to express negation.</para>
    /// labels<para>ezeztapen partikula</para><para>partícula negativa</para><para>negative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#negativeParticle</seealso>
    let negativeParticle = Prefixed_Name(lexinfov3, "negativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NegativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ezeztapen izenordain</para><para>pronombre negativo</para><para>negative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NegativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#NegativePronoun</seealso>
    let NegativePronoun = Prefixed_Name(lexinfov3, "NegativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:negativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun used in a context of a negation or for expressing a negation.</para>
    /// labels<para>ezeztapen izenordain</para><para>pronombre negativo</para><para>negative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#negativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#negativePronoun</seealso>
    let negativePronoun = Prefixed_Name(lexinfov3, "negativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>normative authorization</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NormativeAuthorization">http://www.lexinfo.net/ontology/3.0/lexinfo#NormativeAuthorization</seealso>
    let NormativeAuthorization =
        Prefixed_Name(lexinfov3, "NormativeAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NounPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>zelfstandig naamwoord</para><para>имя существительное</para><para>съществително име</para><para>podstatné jméno</para><para>podstatné meno</para><para>daiktavardis</para><para>substantiivi</para><para>substantivo</para><para>substantivo</para><para>samostalnik</para><para>rzeczownik</para><para>substantiv</para><para>Substantiv</para><para>substantiv</para><para>супстантив</para><para>substantiv</para><para>sustantivo</para><para>substantiu</para><para>ουσιαστικό</para><para>substantiv</para><para>Substantiv</para><para>ainmfhocal</para><para>sostantivo</para><para>lietvārds</para><para>nimisõna</para><para>назоўнік</para><para>imenice</para><para>іменник</para><para>nafnorð</para><para>שם עצם</para><para>именка</para><para>főnév</para><para>emër</para><para>nume</para><para>noun</para><para>izen</para><para>nom</para><para>nom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#NounPOS</seealso>
    let NounPOS = Prefixed_Name(lexinfov3, "NounPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NounFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>marco nominal</para><para>noun frame</para><para>izen-marko</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#NounFrame</seealso>
    let NounFrame = Prefixed_Name(lexinfov3, "NounFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NounPPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>izen-partizipio-marko</para><para>noun pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#NounPPFrame</seealso>
    let NounPPFrame = Prefixed_Name(lexinfov3, "NounPPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NounPredicateFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>noun predicate frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPredicateFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#NounPredicateFrame</seealso>
    let NounPredicateFrame =
        Prefixed_Name(lexinfov3, "NounPredicateFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NounPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>noun phrase</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPhrase">http://www.lexinfo.net/ontology/3.0/lexinfo#NounPhrase</seealso>
    let NounPhrase = Prefixed_Name(lexinfov3, "NounPhrase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NounPossessiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>noun possessive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NounPossessiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#NounPossessiveFrame</seealso>
    let NounPossessiveFrame =
        Prefixed_Name(lexinfov3, "NounPossessiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PossessiveAdjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>possessive adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#PossessiveAdjunct</seealso>
    let PossessiveAdjunct =
        Prefixed_Name(lexinfov3, "PossessiveAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>possessive adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveAdjunct</seealso>
    let possessiveAdjunct =
        Prefixed_Name(lexinfov3, "possessiveAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>proprietate morfosintactică a numărului</para><para>gramatiskais skaitlis</para><para>propiedade de número</para><para>Kieliopillinen luku</para><para>proprietà di numero</para><para>nombre grammatical</para><para>Slovnično število</para><para>numero gramatikal</para><para>número gramatical</para><para>skaičiaus požymis</para><para>numër gramatikor</para><para>rasgo de número</para><para>grammatisk tall</para><para>arvukategooria</para><para>свойство числа</para><para>numerus</para><para>Numerus</para><para>numerus</para><para>Αριθμός</para><para>number</para><para>nombre</para><para>liczba</para><para>getal</para><para>číslo</para><para>číslo</para><para>число</para><para>число</para><para>број</para><para>szám</para><para>tala</para><para>מספר</para><para>број</para><para>tal</para><para>лік</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Number">http://www.lexinfo.net/ontology/3.0/lexinfo#Number</seealso>
    let Number = Prefixed_Name(lexinfov3, "Number") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pronombre personal reflexivo</para><para>pertsona-izenordain bihurkai</para><para>reflexive personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePersonalPronoun</seealso>
    let ReflexivePersonalPronoun =
        Prefixed_Name(lexinfov3, "ReflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:reflexivePersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>personal pronoun which is reflexive</para>
    /// labels<para>pronombre personal reflexivo</para><para>pertsona-izenordain bihurkai</para><para>reflexive personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePersonalPronoun</seealso>
    let reflexivePersonalPronoun =
        Prefixed_Name(lexinfov3, "reflexivePersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexivePossessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive possessive pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePossessivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexivePossessivePronoun</seealso>
    let ReflexivePossessivePronoun =
        Prefixed_Name(lexinfov3, "ReflexivePossessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:reflexivePossessivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A possessive pronoun that refers to the subject as the possessor.</para>
    /// labels<para>reflexive possessive pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePossessivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#reflexivePossessivePronoun</seealso>
    let reflexivePossessivePronoun =
        Prefixed_Name(lexinfov3, "reflexivePossessivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveReciprocalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive reciprocal frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveReciprocalFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveReciprocalFrame</seealso>
    let ReflexiveReciprocalFrame =
        Prefixed_Name(lexinfov3, "ReflexiveReciprocalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitiveFrame</seealso>
    let ReflexiveTransitiveFrame =
        Prefixed_Name(lexinfov3, "ReflexiveTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitivePPFrame</seealso>
    let TransitivePPFrame =
        Prefixed_Name(lexinfov3, "TransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Register</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hizkuntza-erregistro</para><para>registro lingüístico</para><para>registo linguístico</para><para>registre de langue</para><para>Registru de limbă</para><para>языковой регистр</para><para>Sprachebene</para><para>registras</para><para>regiszter</para><para>rekisteri</para><para>stilleje</para><para>Register</para><para>register</para><para>registro</para><para>register</para><para>registre</para><para>rexistro</para><para>register</para><para>регистар</para><para>málsnið</para><para>rejestr</para><para>משלב</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Register">http://www.lexinfo.net/ontology/3.0/lexinfo#Register</seealso>
    let Register = Prefixed_Name(lexinfov3, "Register") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:RelationNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>nombre de relación</para><para>relation noun</para><para>erlazio-izen</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelationNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#RelationNoun</seealso>
    let RelationNoun = Prefixed_Name(lexinfov3, "RelationNoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:RelativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>relative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeDeterminer</seealso>
    let RelativeDeterminer =
        Prefixed_Name(lexinfov3, "RelativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:relativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Determiner related to a referent.</para>
    /// labels<para>relative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#relativeDeterminer</seealso>
    let relativeDeterminer =
        Prefixed_Name(lexinfov3, "relativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:RelativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>relative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#RelativeParticle</seealso>
    let RelativeParticle = Prefixed_Name(lexinfov3, "RelativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:relativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>relative particle</para>
    /// labels<para>relative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#relativeParticle</seealso>
    let relativeParticle = Prefixed_Name(lexinfov3, "relativeParticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:RelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>betrekkelijk voornaamwoord</para><para>относительное местоимение</para><para>αναφορική αντωνυμία</para><para>izenordain erlatibo</para><para>відносний займенник</para><para>santykinis įvardis</para><para>relatiivipronomini</para><para>pronombre relativo</para><para>tilvísunarfornafn</para><para>relativt pronomen</para><para>odnosne zamjenice</para><para>relativt pronomen</para><para>pronome relativo</para><para>vonatkozó névmás</para><para>односна заменица</para><para>relative pronoun</para><para>pronome relativo</para><para>pronome relativo</para><para>Relativpronomen</para><para>zaimek względny</para><para>relativpronomen</para><para>Pronume relativ</para><para>zájmeno vztažné</para><para>pronom relatiu</para><para>pronom relatif</para><para>siduv asesõna</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RelativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#RelativePronoun</seealso>
    let RelativePronoun = Prefixed_Name(lexinfov3, "RelativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:relativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun which introduces a relative clause and refers to something that has been said before.</para>
    /// labels<para>betrekkelijk voornaamwoord</para><para>относительное местоимение</para><para>відносний займенник</para><para>izenordain erlatibo</para><para>αναφορική αντωνυμία</para><para>relatiivipronomini</para><para>pronombre relativo</para><para>santykinis įvardis</para><para>relativt pronomen</para><para>odnosne zamjenice</para><para>tilvísunarfornafn</para><para>relativt pronomen</para><para>vonatkozó névmás</para><para>pronome relativo</para><para>pronome relativo</para><para>односна заменица</para><para>relative pronoun</para><para>pronome relativo</para><para>Pronume relativ</para><para>zaimek względny</para><para>relativpronomen</para><para>Relativpronomen</para><para>zájmeno vztažné</para><para>pronom relatif</para><para>pronom relatiu</para><para>siduv asesõna</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#relativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#relativePronoun</seealso>
    let relativePronoun = Prefixed_Name(lexinfov3, "relativePronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:RootMorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>After publishing OntoLex-Morph, this should be re-defined as a subclass of morph:Morph.</para>
    ///   <para>A root is the portion of a word that (a) is common to a set of derived or inflected forms, (b) is not further analyzable into meaningful elements, and (c) carries the principle portion of meaning of the words in which it functions (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/root).</para>
    /// labels<para>morphological root</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RootMorph">http://www.lexinfo.net/ontology/3.0/lexinfo#RootMorph</seealso>
    let RootMorph = Prefixed_Name(lexinfov3, "RootMorph") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:SemiColon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>semi colon</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SemiColon">http://www.lexinfo.net/ontology/3.0/lexinfo#SemiColon</seealso>
    let SemiColon = Prefixed_Name(lexinfov3, "SemiColon") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:semiColon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Sign (;) usually used to separate phrases.</para>
    /// labels<para>semi colon</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#semiColon">http://www.lexinfo.net/ontology/3.0/lexinfo#semiColon</seealso>
    let semiColon = Prefixed_Name(lexinfov3, "semiColon") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:SententialClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>sentential clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SententialClause">http://www.lexinfo.net/ontology/3.0/lexinfo#SententialClause</seealso>
    let SententialClause = Prefixed_Name(lexinfov3, "SententialClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:sententialClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sentential clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sententialClause">http://www.lexinfo.net/ontology/3.0/lexinfo#sententialClause</seealso>
    let sententialClause = Prefixed_Name(lexinfov3, "sententialClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:SimulfixMorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A simulfix is a change or replacement of vowels or consonants (usually vowels) which changes the meaning of a word (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/simulfix). Examples include umlaut in Germanic languages, e.g., in the formation of the English plural feet from the singular foot.</para>
    /// labels<para>simulfix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SimulfixMorph">http://www.lexinfo.net/ontology/3.0/lexinfo#SimulfixMorph</seealso>
    let SimulfixMorph = Prefixed_Name(lexinfov3, "SimulfixMorph") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Slash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bară oblică spre dreapta</para><para>Pasvirasis brūkšnys</para><para>Barra diagonal</para><para>Schuine streep</para><para>barra obliqua</para><para>barra obliqua</para><para>barre oblique</para><para>Schrägstrich</para><para>Скісна риска</para><para>ferde vonal</para><para>косая черта</para><para>snedstreck</para><para>Skråstreg</para><para>Коса црта</para><para>Poševnica</para><para>Коса црта</para><para>Vinoviiva</para><para>skråstrek</para><para>Kosa crta</para><para>lomítko</para><para>Ukośnik</para><para>לוכסן</para><para>Barra</para><para>barra</para><para>slash</para><para>Lomka</para><para>barra</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Slash">http://www.lexinfo.net/ontology/3.0/lexinfo#Slash</seealso>
    let Slash = Prefixed_Name(lexinfov3, "Slash") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:slash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>The punctuation sign /</para>
    /// labels<para>Bară oblică spre dreapta</para><para>Pasvirasis brūkšnys</para><para>Schuine streep</para><para>Barra diagonal</para><para>barra obliqua</para><para>barre oblique</para><para>barra obliqua</para><para>Schrägstrich</para><para>Скісна риска</para><para>ferde vonal</para><para>косая черта</para><para>snedstreck</para><para>Kosa crta</para><para>Коса црта</para><para>skråstrek</para><para>Skråstreg</para><para>Коса црта</para><para>Poševnica</para><para>Vinoviiva</para><para>Ukośnik</para><para>lomítko</para><para>slash</para><para>barra</para><para>Lomka</para><para>Barra</para><para>barra</para><para>לוכסן</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#slash">http://www.lexinfo.net/ontology/3.0/lexinfo#slash</seealso>
    let slash = Prefixed_Name(lexinfov3, "slash") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:StemMorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A stem is the root or roots of a word, together with any derivational affixes, to which inflectional affixes are added (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/stem). A stem consists minimally of a root, but may be analyzable into a root plus derivational morphemes.</para>
    ///   <para>After publishing OntoLex-Morph, this should be re-defined as subclass of morph:Morph.</para>
    /// labels<para>morphological stem</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#StemMorph">http://www.lexinfo.net/ontology/3.0/lexinfo#StemMorph</seealso>
    let StemMorph = Prefixed_Name(lexinfov3, "StemMorph") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:StrongPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>strong personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#StrongPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#StrongPersonalPronoun</seealso>
    let StrongPersonalPronoun =
        Prefixed_Name(lexinfov3, "StrongPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:strongPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Personal pronoun that can occupy the position after a preposition and/or reinforce a weak personal pronoun.</para>
    /// labels<para>strong personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#strongPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#strongPersonalPronoun</seealso>
    let strongPersonalPronoun =
        Prefixed_Name(lexinfov3, "strongPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjectlessFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>subjectless frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessFrame</seealso>
    let SubjectlessFrame = Prefixed_Name(lexinfov3, "SubjectlessFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjectlessIntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>subjectless intransitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessIntransitiveFrame</seealso>
    let SubjectlessIntransitiveFrame =
        Prefixed_Name(lexinfov3, "SubjectlessIntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:fullFormFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.</para>
    /// labels<para>full form for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullFormFor">http://www.lexinfo.net/ontology/3.0/lexinfo#fullFormFor</seealso>
    let fullFormFor = Prefixed_Name(lexinfov3, "fullFormFor") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:coordinateConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.</para>
    /// labels<para>coordinate concept</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinateConcept">http://www.lexinfo.net/ontology/3.0/lexinfo#coordinateConcept</seealso>
    let coordinateConcept =
        Prefixed_Name(lexinfov3, "coordinateConcept") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indication specifying whether the usage is old or modern.</para>
    /// labels<para>dating</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dating">http://www.lexinfo.net/ontology/3.0/lexinfo#dating</seealso>
    let dating = Prefixed_Name(lexinfov3, "dating") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:dativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCaseForm</seealso>
    let dativeCaseForm = Prefixed_Name(lexinfov3, "dativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:definite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Value referring to the capacity of identification of an entity.</para>
    /// labels<para>definite</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#definite">http://www.lexinfo.net/ontology/3.0/lexinfo#definite</seealso>
    let definite = Prefixed_Name(lexinfov3, "definite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:definiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property about the possiblity to identify an entity.</para>
    /// labels<para>definitud gramatical</para><para>определённость</para><para>definiteness</para><para>визначеність</para><para>определеност</para><para>określoność</para><para>Definitheit</para><para>bestemthed</para><para>bestemthet</para><para>määräisyys</para><para>určitost</para><para>binding</para><para>Species</para><para>species</para><para>יידוע</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#definiteness">http://www.lexinfo.net/ontology/3.0/lexinfo#definiteness</seealso>
    let definiteness = Prefixed_Name(lexinfov3, "definiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property concerning comparison.</para>
    /// labels<para>degree</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#degree">http://www.lexinfo.net/ontology/3.0/lexinfo#degree</seealso>
    let degree = Prefixed_Name(lexinfov3, "degree") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:delativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case which expresses motion downward from the referent of the noun it marks.</para>
    /// labels<para>delative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCase</seealso>
    let delativeCase = Prefixed_Name(lexinfov3, "delativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:delativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>delative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#delativeCaseForm</seealso>
    let delativeCaseForm = Prefixed_Name(lexinfov3, "delativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:deprecatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>A term rated according to the scale of a term acceptability rating as undesired.</para>
    /// labels<para>deprecated term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#deprecatedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#deprecatedTerm</seealso>
    let deprecatedTerm = Prefixed_Name(lexinfov3, "deprecatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#description">http://www.lexinfo.net/ontology/3.0/lexinfo#description</seealso>
    let description = Prefixed_Name(lexinfov3, "description") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Word or affix that belongs to a class of noun modifiers that expresses the reference, including quantity, of a noun.</para>
    /// labels<para>determinativt pronomen</para><para>определяющее слово</para><para>determinatzaile</para><para>määrav artikkel</para><para>προσδιοριστής</para><para>determinantas</para><para>determinativ</para><para>determinante</para><para>determinativ</para><para>детерминатор</para><para>determinante</para><para>determinativ</para><para>determinante</para><para>determinante</para><para>determinátor</para><para>Determinativ</para><para>determinator</para><para>determinant</para><para>determináns</para><para>déterminant</para><para>determinant</para><para>Determinant</para><para>ákvæðisorð</para><para>determiner</para><para>визначник</para><para>określnik</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#determiner">http://www.lexinfo.net/ontology/3.0/lexinfo#determiner</seealso>
    let determiner = Prefixed_Name(lexinfov3, "determiner") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:dialectRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///
    /// labels<para>dialect register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dialectRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#dialectRegister</seealso>
    let dialectRegister = Prefixed_Name(lexinfov3, "dialectRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:dualNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>dual number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dualNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#dualNumberForm</seealso>
    let dualNumberForm = Prefixed_Name(lexinfov3, "dualNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:elativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses the meaning of motion 'away from' from the referent of the noun it marks.</para>
    /// labels<para>elative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCase</seealso>
    let elativeCase = Prefixed_Name(lexinfov3, "elativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:elativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>elative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#elativeCaseForm</seealso>
    let elativeCaseForm = Prefixed_Name(lexinfov3, "elativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:entryTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term that heads a terminological entry.</para>
    /// labels<para>entry term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#entryTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#entryTerm</seealso>
    let entryTerm = Prefixed_Name(lexinfov3, "entryTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:equation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>An expression used to represent a concept based on a statement that two mathematical expressions are, for instance, equal as identified by the equal sign (=), or assigned to one another by a similar sign.</para>
    /// labels<para>equation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#equation">http://www.lexinfo.net/ontology/3.0/lexinfo#equation</seealso>
    let equation = Prefixed_Name(lexinfov3, "equation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:equativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that expresses likeness or identity to the referent of the noun it marks. It can have meaning, such as: 'as', 'like', or 'in the capacity of'.</para>
    /// labels<para>equative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCase</seealso>
    let equativeCase = Prefixed_Name(lexinfov3, "equativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:equativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>equative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#equativeCaseForm</seealso>
    let equativeCaseForm = Prefixed_Name(lexinfov3, "equativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ergativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case assigned to the subject of a transitive verb as opposed to absolutive case.</para>
    /// labels<para>ergative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCase</seealso>
    let ergativeCase = Prefixed_Name(lexinfov3, "ergativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ergativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ergative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#ergativeCaseForm</seealso>
    let ergativeCaseForm = Prefixed_Name(lexinfov3, "ergativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:essiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case which expresses a state of being.</para>
    /// labels<para>essive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCase</seealso>
    let essiveCase = Prefixed_Name(lexinfov3, "essiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:essiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>essive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#essiveCaseForm</seealso>
    let essiveCaseForm = Prefixed_Name(lexinfov3, "essiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:etymologicalRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Morpheme that has a particular status with regards to the word's etymology.</para>
    /// labels<para>etymological root</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#etymologicalRoot">http://www.lexinfo.net/ontology/3.0/lexinfo#etymologicalRoot</seealso>
    let etymologicalRoot = Prefixed_Name(lexinfov3, "etymologicalRoot") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:etymology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information on the origin of a word and the development of its meaning.</para>
    /// labels<para>etymology</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#etymology">http://www.lexinfo.net/ontology/3.0/lexinfo#etymology</seealso>
    let etymology = Prefixed_Name(lexinfov3, "etymology") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:exact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Completely equal in every detail</para>
    /// labels<para>exact</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#exact">http://www.lexinfo.net/ontology/3.0/lexinfo#exact</seealso>
    let exact = Prefixed_Name(lexinfov3, "exact") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:finite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Finiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Property applied to a verb form that can occur on its own in an independent sentence.</para>
    /// labels<para>finite</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#finite">http://www.lexinfo.net/ontology/3.0/lexinfo#finite</seealso>
    let finite = Prefixed_Name(lexinfov3, "finite") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:finiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property referring to finite and non-finite status of a verbal form.</para>
    /// labels<para>finiteness</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#finiteness">http://www.lexinfo.net/ontology/3.0/lexinfo#finiteness</seealso>
    let finiteness = Prefixed_Name(lexinfov3, "finiteness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:firstPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Person</para>
    ///   <para>First person deixis is deictic reference that refers to the speaker, or both the speaker and referents grouped with the speaker</para>
    /// labels<para>first person</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#firstPerson">http://www.lexinfo.net/ontology/3.0/lexinfo#firstPerson</seealso>
    let firstPerson = Prefixed_Name(lexinfov3, "firstPerson") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:firstPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>first person form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#firstPersonForm">http://www.lexinfo.net/ontology/3.0/lexinfo#firstPersonForm</seealso>
    let firstPersonForm = Prefixed_Name(lexinfov3, "firstPersonForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formPersonVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form person variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formPersonVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formPersonVariant</seealso>
    let formPersonVariant =
        Prefixed_Name(lexinfov3, "formPersonVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formMoodVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form mood variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formMoodVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formMoodVariant</seealso>
    let formMoodVariant = Prefixed_Name(lexinfov3, "formMoodVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formNegativeVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form negative variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formNegativeVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formNegativeVariant</seealso>
    let formNegativeVariant =
        Prefixed_Name(lexinfov3, "formNegativeVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formTenseVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form tense variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formTenseVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formTenseVariant</seealso>
    let formTenseVariant = Prefixed_Name(lexinfov3, "formTenseVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:formalRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Register</para>
    ///
    /// labels<para>formal register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formalRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#formalRegister</seealso>
    let formalRegister = Prefixed_Name(lexinfov3, "formalRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>Figures, symbols or the like used to express a concept briefly, such as a mathematical or chemical formula.</para>
    /// labels<para>formula</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formula">http://www.lexinfo.net/ontology/3.0/lexinfo#formula</seealso>
    let formula = Prefixed_Name(lexinfov3, "formula") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relative commonness with which a term occurs.</para>
    /// labels<para>Hyppighet i statistikk</para><para>Frekvens i statistikk</para><para>Релативна фреквенција</para><para>Частота події</para><para>фреквенција</para><para>частотность</para><para>frequência</para><para>frecuencia</para><para>frecuencia</para><para>Häufigkeit</para><para>freqüència</para><para>frequentie</para><para>frekwencja</para><para>gyakoriság</para><para>συχνότητα</para><para>fréquence</para><para>frequenza</para><para>Maiztasun</para><para>frekvenca</para><para>frequency</para><para>frecvență</para><para>dažnumas</para><para>frekvens</para><para>sagedus</para><para>Частата</para><para>četnost</para><para>שכיחות</para><para>tíðni</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#frequency">http://www.lexinfo.net/ontology/3.0/lexinfo#frequency</seealso>
    let frequency = Prefixed_Name(lexinfov3, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:frequencyUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the relative rate of occurrence of a lexical unit in a given textual context</para>
    /// labels<para>frequency usage</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#frequencyUsage">http://www.lexinfo.net/ontology/3.0/lexinfo#frequencyUsage</seealso>
    let frequencyUsage = Prefixed_Name(lexinfov3, "frequencyUsage") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:fullArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>For definiteness, when a specific form is the syntactic subject of the clause.</para>
    /// labels<para>full article</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#fullArticle</seealso>
    let fullArticle = Prefixed_Name(lexinfov3, "fullArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:fullForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>The complete presentation of a term or lexeme for which there is an abbreviated form.</para>
    /// labels<para>full form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fullForm">http://www.lexinfo.net/ontology/3.0/lexinfo#fullForm</seealso>
    let fullForm = Prefixed_Name(lexinfov3, "fullForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:fusedPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Preposition that is the result of a morphological merge from at least two words.</para>
    /// labels<para>fused preposition</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPreposition">http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPreposition</seealso>
    let fusedPreposition = Prefixed_Name(lexinfov3, "fusedPreposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:presentTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>present tense form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentTenseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#presentTenseForm</seealso>
    let presentTenseForm = Prefixed_Name(lexinfov3, "presentTenseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:preterite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Tense</para>
    ///   <para>The simple past or preterite as distinct from the perfect form, e.g,, "showed" not "shown"</para>
    /// labels<para>preterite</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#preterite">http://www.lexinfo.net/ontology/3.0/lexinfo#preterite</seealso>
    let preterite = Prefixed_Name(lexinfov3, "preterite") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:preteriteTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>preterite tense form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#preteriteTenseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#preteriteTenseForm</seealso>
    let preteriteTenseForm =
        Prefixed_Name(lexinfov3, "preteriteTenseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:productName</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>An attribute assigned to a term indicating that that term is the official designator for a product.</para>
    /// labels<para>product name</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#productName">http://www.lexinfo.net/ontology/3.0/lexinfo#productName</seealso>
    let productName = Prefixed_Name(lexinfov3, "productName") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:prolativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case for a noun or a pronoun that expresses motion within a place or a period of time needed for an event.</para>
    /// labels<para>prolative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCase</seealso>
    let prolativeCase = Prefixed_Name(lexinfov3, "prolativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prolativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prolative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#prolativeCaseForm</seealso>
    let prolativeCaseForm =
        Prefixed_Name(lexinfov3, "prolativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:pronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Word used in place of a noun or a noun phrase.</para>
    /// labels<para>įvardinis, įvardžiuotinis</para><para>vietniekvārds</para><para>voornaamwoord</para><para>местоимённый</para><para>местоимение</para><para>asesõnaline</para><para>pronominale</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>izenordain</para><para>zamjenice</para><para>займеннік</para><para>כינוי גוף</para><para>pronomini</para><para>αντωνυμία</para><para>займенник</para><para>pronomen</para><para>заменица</para><para>zaimkowy</para><para>Pronomen</para><para>pronomen</para><para>pronomen</para><para>pronoun</para><para>заменка</para><para>zájmeno</para><para>pronome</para><para>përemër</para><para>forainm</para><para>fornafn</para><para>pronom</para><para>zámeno</para><para>névmás</para><para>zaimek</para><para>pronom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#pronoun</seealso>
    let pronoun = Prefixed_Name(lexinfov3, "pronoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:pronunciation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The representation of the manner by which a term or word is articulated.</para>
    /// labels<para>pronunciation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronunciation">http://www.lexinfo.net/ontology/3.0/lexinfo#pronunciation</seealso>
    let pronunciation = Prefixed_Name(lexinfov3, "pronunciation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:proverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A brief popular axiom or saying.</para>
    /// labels<para>proverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#proverb">http://www.lexinfo.net/ontology/3.0/lexinfo#proverb</seealso>
    let proverb = Prefixed_Name(lexinfov3, "proverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:quadrial</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>Property related to four elements.</para>
    /// labels<para>quadrial</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#quadrial">http://www.lexinfo.net/ontology/3.0/lexinfo#quadrial</seealso>
    let quadrial = Prefixed_Name(lexinfov3, "quadrial") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:quadrialNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>quadrial number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#quadrialNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#quadrialNumberForm</seealso>
    let quadrialNumberForm =
        Prefixed_Name(lexinfov3, "quadrialNumberForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:quasiEquivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A term that is very similar but with some differences</para>
    /// labels<para>quasi equivalent</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#quasiEquivalent">http://www.lexinfo.net/ontology/3.0/lexinfo#quasiEquivalent</seealso>
    let quasiEquivalent = Prefixed_Name(lexinfov3, "quasiEquivalent") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:radical</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>A basic identifiable component of every CJKV character, often found on the left side of the character, that sometimes gives a rough indication of meaning and is used for collating lexical and terminological resources.</para>
    /// labels<para>radical</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#radical">http://www.lexinfo.net/ontology/3.0/lexinfo#radical</seealso>
    let radical = Prefixed_Name(lexinfov3, "radical") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:rarelyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Frequency</para>
    ///   <para>owl:Thing</para>
    ///   <para>Said of a term that is almost never used.</para>
    /// labels<para>rarely used</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#rarelyUsed">http://www.lexinfo.net/ontology/3.0/lexinfo#rarelyUsed</seealso>
    let rarelyUsed = Prefixed_Name(lexinfov3, "rarelyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Adjective-na</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective-na</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-na">http://www.lexinfo.net/ontology/3.0/lexinfo#Adjective-na</seealso>
    let Adjective_na = Prefixed_Name(lexinfov3, "Adjective-na") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:postPositiveArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something</para>
    /// labels<para>post positive arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#postPositiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#postPositiveArg</seealso>
    let postPositiveArg = Prefixed_Name(lexinfov3, "postPositiveArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>determinativt pronomen</para><para>определяющее слово</para><para>määrav artikkel</para><para>determinatzaile</para><para>προσδιοριστής</para><para>determinantas</para><para>determinativ</para><para>determinativ</para><para>determinante</para><para>детерминатор</para><para>Determinativ</para><para>determinativ</para><para>determinante</para><para>determinator</para><para>determinátor</para><para>determinante</para><para>determinante</para><para>determinant</para><para>determináns</para><para>déterminant</para><para>determinant</para><para>Determinant</para><para>determiner</para><para>ákvæðisorð</para><para>określnik</para><para>визначник</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Determiner">http://www.lexinfo.net/ontology/3.0/lexinfo#Determiner</seealso>
    let Determiner = Prefixed_Name(lexinfov3, "Determiner") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ArticlePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>граматички члан</para><para>членуване</para><para>przedimek</para><para>artikkeli</para><para>artikelis</para><para>lidwoord</para><para>artikuls</para><para>artículo</para><para>articolo</para><para>kendeord</para><para>artikkel</para><para>artikkel</para><para>artikulu</para><para>article</para><para>articol</para><para>artiklu</para><para>артикль</para><para>artikel</para><para>артикль</para><para>article</para><para>Artikel</para><para>greinir</para><para>article</para><para>артыкль</para><para>Artikel</para><para>névelő</para><para>artigo</para><para>trajta</para><para>artigo</para><para>άρθρο</para><para>תווית</para><para>član</para><para>člen</para><para>член</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ArticlePOS">http://www.lexinfo.net/ontology/3.0/lexinfo#ArticlePOS</seealso>
    let ArticlePOS = Prefixed_Name(lexinfov3, "ArticlePOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PresentParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>orainaldiko partizipio-adjektibo</para><para>adjetivo de participio presente</para><para>present participle adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PresentParticipleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#PresentParticipleAdjective</seealso>
    let PresentParticipleAdjective =
        Prefixed_Name(lexinfov3, "PresentParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PresentativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>presentative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PresentativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#PresentativePronoun</seealso>
    let PresentativePronoun =
        Prefixed_Name(lexinfov3, "PresentativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:presentativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>pronoun that identify the current locative or temporal situation</para>
    /// labels<para>presentative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#presentativePronoun</seealso>
    let presentativePronoun =
        Prefixed_Name(lexinfov3, "presentativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PronominalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>voornaamwoordelijk bijwoord</para><para>местоименное наречие</para><para>pronominaladverbium</para><para>izenordain-adberbio</para><para>adverbio pronominal</para><para>adverbe pronominal</para><para>pronominal adverb</para><para>Pronominaladverb</para><para>pronominaladverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PronominalAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#PronominalAdverb</seealso>
    let PronominalAdverb = Prefixed_Name(lexinfov3, "PronominalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:inflectionElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>An element of language used to change the form of a word (noun, adjective) by declension, and (verbs) by conjugation.</para>
    /// labels<para>inflection element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#inflectionElement">http://www.lexinfo.net/ontology/3.0/lexinfo#inflectionElement</seealso>
    let inflectionElement =
        Prefixed_Name(lexinfov3, "inflectionElement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adjective-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Deverbal adjective in Japanese ending with the '-i' suffix in dictionary form</para>
    /// labels<para>adjective-i</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-i">http://www.lexinfo.net/ontology/3.0/lexinfo#adjective-i</seealso>
    let adjective_i = Prefixed_Name(lexinfov3, "adjective-i") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:directObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relation between a phrase and a verb, in which the relation is central to the verb</para>
    /// labels<para>direct object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#directObject">http://www.lexinfo.net/ontology/3.0/lexinfo#directObject</seealso>
    let directObject = Prefixed_Name(lexinfov3, "directObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#subject">http://www.lexinfo.net/ontology/3.0/lexinfo#subject</seealso>
    let subject = Prefixed_Name(lexinfov3, "subject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:DeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction (&amp;quot;that&amp;quot; in English)</para>
    /// labels<para>declarative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#DeclarativeFrame</seealso>
    let DeclarativeFrame = Prefixed_Name(lexinfov3, "DeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:declarativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>declarative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#declarativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#declarativeClause</seealso>
    let declarativeClause =
        Prefixed_Name(lexinfov3, "declarativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:deficientVerb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>verb lacking certain morphosyntactic properties</para>
    /// labels<para>aditz defiziente</para><para>deficient verb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#deficientVerb">http://www.lexinfo.net/ontology/3.0/lexinfo#deficientVerb</seealso>
    let deficientVerb = Prefixed_Name(lexinfov3, "deficientVerb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:DefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>articolo determinativo</para><para>определенный артикль</para><para>žymimasis artikelis</para><para>przedimek określony</para><para>bestimmter Artikel</para><para>articolul hotărât</para><para>határozott névelő</para><para>artículo definido</para><para>definite article</para><para>Bepaald lidwoord</para><para>artikulu mugatua</para><para>ákveðinn greinir</para><para>artigo definido</para><para>bestemt artikel</para><para>article definit</para><para>määrav artikkel</para><para>artigo definido</para><para>οριστικό άρθρο</para><para>article défini</para><para>одређени члан</para><para>člen určitý</para><para>הא הידיעה</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DefiniteArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#DefiniteArticle</seealso>
    let DefiniteArticle = Prefixed_Name(lexinfov3, "DefiniteArticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>interrogative infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveClause</seealso>
    let InterrogativeInfinitiveClause =
        Prefixed_Name(lexinfov3, "InterrogativeInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A significant word or phrase.</para>
    /// labels<para>expression</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#expression">http://www.lexinfo.net/ontology/3.0/lexinfo#expression</seealso>
    let expression = Prefixed_Name(lexinfov3, "expression") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:preferredTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term rated according to the scale of a term acceptability rating as the primary term for a given concept.</para>
    /// labels<para>preferred term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#preferredTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#preferredTerm</seealso>
    let preferredTerm = Prefixed_Name(lexinfov3, "preferredTerm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prepositionalGerundClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prepositional gerund clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalGerundClause">http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalGerundClause</seealso>
    let prepositionalGerundClause =
        Prefixed_Name(lexinfov3, "prepositionalGerundClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>interrogative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeClause</seealso>
    let interrogativeClause =
        Prefixed_Name(lexinfov3, "interrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:preModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:ModificationType</para>
    ///   <para>Situation where the modifier is before the modified.</para>
    /// labels<para>pre modifier</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#preModifier">http://www.lexinfo.net/ontology/3.0/lexinfo#preModifier</seealso>
    let preModifier = Prefixed_Name(lexinfov3, "preModifier") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prefix">http://www.lexinfo.net/ontology/3.0/lexinfo#prefix</seealso>
    let prefix = Prefixed_Name(lexinfov3, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Definiteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>definitud gramatical</para><para>определённость</para><para>определеност</para><para>definiteness</para><para>визначеність</para><para>określoność</para><para>Definitheit</para><para>bestemthet</para><para>bestemthed</para><para>määräisyys</para><para>určitost</para><para>species</para><para>Species</para><para>binding</para><para>יידוע</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Definiteness">http://www.lexinfo.net/ontology/3.0/lexinfo#Definiteness</seealso>
    let Definiteness = Prefixed_Name(lexinfov3, "Definiteness") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>An interrogative/relative word used to ask about numeric ranking.</para>
    /// labels<para>interrogative ordinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeOrdinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeOrdinalNumeral</seealso>
    let interrogativeOrdinalNumeral =
        Prefixed_Name(lexinfov3, "interrogativeOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>partícula interrogativa</para><para>interrogative particle</para><para>вопросительная частица</para><para>partikula galdetzaile</para><para>Fragepartikel</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeParticle</seealso>
    let InterrogativeParticle =
        Prefixed_Name(lexinfov3, "InterrogativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:distinctiveParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>distinctive particle</para>
    /// labels<para>distinctive particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#distinctiveParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#distinctiveParticle</seealso>
    let distinctiveParticle =
        Prefixed_Name(lexinfov3, "distinctiveParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>marko ditrantsitibo</para><para>ditransitive frame</para><para>marco ditransitivo</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame</seealso>
    let DitransitiveFrame =
        Prefixed_Name(lexinfov3, "DitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DitransitiveFrame_For</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ditransitive frame_ for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_For">http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_For</seealso>
    let DitransitiveFrame_For =
        Prefixed_Name(lexinfov3, "DitransitiveFrame_For") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DitransitiveFrame_To</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ditransitive frame_ to</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_To">http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveFrame_To</seealso>
    let DitransitiveFrame_To =
        Prefixed_Name(lexinfov3, "DitransitiveFrame_To") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:emphaticPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>An emphatic pronoun is a personal pronoun that is used to emphasize its referent.</para>
    /// labels<para>izenordain enfatiko</para><para>pronombre enfático</para><para>emphatic pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#emphaticPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#emphaticPronoun</seealso>
    let emphaticPronoun = Prefixed_Name(lexinfov3, "emphaticPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ExclamativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>exclamative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativeDeterminer</seealso>
    let ExclamativeDeterminer =
        Prefixed_Name(lexinfov3, "ExclamativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ExclamativePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>exclamative point</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePoint">http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePoint</seealso>
    let ExclamativePoint = Prefixed_Name(lexinfov3, "ExclamativePoint") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:exclamativePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Special sign (!) usually used in writing to mark exclamation.</para>
    /// labels<para>exclamative point</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePoint">http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePoint</seealso>
    let exclamativePoint = Prefixed_Name(lexinfov3, "exclamativePoint") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:exclamativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun marked with an emotional utterance and/or a strong intonation.</para>
    /// labels<para>pronombre exclamativo</para><para>harridura-izenordain</para><para>exclamative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativePronoun</seealso>
    let exclamativePronoun =
        Prefixed_Name(lexinfov3, "exclamativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ExistentialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>existential pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExistentialPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ExistentialPronoun</seealso>
    let ExistentialPronoun =
        Prefixed_Name(lexinfov3, "ExistentialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FusedPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fused preposition</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPreposition">http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPreposition</seealso>
    let FusedPreposition = Prefixed_Name(lexinfov3, "FusedPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FusedPrepositionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fused preposition</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionPOS</seealso>
    let FusedPrepositionPOS =
        Prefixed_Name(lexinfov3, "FusedPrepositionPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FusedPrepositionDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fused preposition determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPrepositionDeterminer</seealso>
    let FusedPrepositionDeterminer =
        Prefixed_Name(lexinfov3, "FusedPrepositionDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:fusedPrepositionPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>word resulting from the aggregation of a preposition and a pronoun</para>
    /// labels<para>fused preposition pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPrepositionPronoun</seealso>
    let fusedPrepositionPronoun =
        Prefixed_Name(lexinfov3, "fusedPrepositionPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:FusedPronounAuxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>fused pronoun auxiliary</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPronounAuxiliary">http://www.lexinfo.net/ontology/3.0/lexinfo#FusedPronounAuxiliary</seealso>
    let FusedPronounAuxiliary =
        Prefixed_Name(lexinfov3, "FusedPronounAuxiliary") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ImpersonalIntransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>impersonal intransitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitiveFrame</seealso>
    let ImpersonalIntransitiveFrame =
        Prefixed_Name(lexinfov3, "ImpersonalIntransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:fusedPronounAuxiliary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>word resulting from the aggregation of a pronoun and an auxiliary</para>
    /// labels<para>fused pronoun auxiliary</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPronounAuxiliary">http://www.lexinfo.net/ontology/3.0/lexinfo#fusedPronounAuxiliary</seealso>
    let fusedPronounAuxiliary =
        Prefixed_Name(lexinfov3, "fusedPronounAuxiliary") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>propiedade de xénero</para><para>proprietà di genere</para><para>gjinia gramatikore</para><para>rodzaj gramatyczny</para><para>genero gramatikal</para><para>genre grammatical</para><para>género gramatical</para><para>grammatisk kjønn</para><para>grammatisk kjønn</para><para>Γραμματικό γένος</para><para>giminės požymis</para><para>rasgo de género</para><para>slovnični spol</para><para>Граматычны род</para><para>категория рода</para><para>gramatický rod</para><para>Gramatički rod</para><para>kyneiginleiki</para><para>jmenný rod</para><para>מין דקדוקי</para><para>geslacht</para><para>gender</para><para>gènere</para><para>dzimte</para><para>genus</para><para>genus</para><para>Genus</para><para>Genus</para><para>suku</para><para>sugu</para><para>род</para><para>gen</para><para>род</para><para>nem</para><para>Род</para><para>рід</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Gender">http://www.lexinfo.net/ontology/3.0/lexinfo#Gender</seealso>
    let Gender = Prefixed_Name(lexinfov3, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GeneralAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>general adverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralAdverb</seealso>
    let GeneralAdverb = Prefixed_Name(lexinfov3, "GeneralAdverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:generalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adverb belonging to the general class of adverbs</para>
    /// labels<para>general adverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#generalAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#generalAdverb</seealso>
    let generalAdverb = Prefixed_Name(lexinfov3, "generalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:GeneralizationWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>generalization word</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralizationWord">http://www.lexinfo.net/ontology/3.0/lexinfo#GeneralizationWord</seealso>
    let GeneralizationWord =
        Prefixed_Name(lexinfov3, "GeneralizationWord") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:generalizationWord</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>A word that does not carry its own meaning but generalizes the meaning of a neighboring word, adding the &amp;quot;etc.&amp;quot; sense.</para>
    /// labels<para>generalization word</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#generalizationWord">http://www.lexinfo.net/ontology/3.0/lexinfo#generalizationWord</seealso>
    let generalizationWord =
        Prefixed_Name(lexinfov3, "generalizationWord") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:GenericNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>generic numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenericNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#GenericNumeral</seealso>
    let GenericNumeral = Prefixed_Name(lexinfov3, "GenericNumeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:genericNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A numeral used to indicate the number of sets/kinds of objects.</para>
    /// labels<para>generic numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#genericNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#genericNumeral</seealso>
    let genericNumeral = Prefixed_Name(lexinfov3, "genericNumeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:genitiveObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>genitive object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveObject">http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveObject</seealso>
    let genitiveObject = Prefixed_Name(lexinfov3, "genitiveObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GenitiveObject</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>genitive object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveObject">http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveObject</seealso>
    let GenitiveObject = Prefixed_Name(lexinfov3, "GenitiveObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:genitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses a possessive relationship (e.g. the boy's book) or some other similarly close connection (e.g. a summer's day).</para>
    /// labels<para>genitive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCase</seealso>
    let genitiveCase = Prefixed_Name(lexinfov3, "genitiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GerundACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>gerund ac frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundACFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GerundACFrame</seealso>
    let GerundACFrame = Prefixed_Name(lexinfov3, "GerundACFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GerundFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates one of the arguments is a gerund clause</para>
    /// labels<para>gerundio-marko</para><para>gerund frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GerundFrame</seealso>
    let GerundFrame = Prefixed_Name(lexinfov3, "GerundFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GerundOCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>gerund oc frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundOCFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GerundOCFrame</seealso>
    let GerundOCFrame = Prefixed_Name(lexinfov3, "GerundOCFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GerundSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>gerund sc frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundSCFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GerundSCFrame</seealso>
    let GerundSCFrame = Prefixed_Name(lexinfov3, "GerundSCFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:SubjectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the subject of the main clause is the (omitted) subject of the subclause</para>
    /// labels<para>subject control</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectControl">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectControl</seealso>
    let SubjectControl = Prefixed_Name(lexinfov3, "SubjectControl") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ImpersonalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>impersonal frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalFrame</seealso>
    let ImpersonalFrame = Prefixed_Name(lexinfov3, "ImpersonalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ImpersonalIntransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>impersonal intransitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalIntransitivePPFrame</seealso>
    let ImpersonalIntransitivePPFrame =
        Prefixed_Name(lexinfov3, "ImpersonalIntransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ImpersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>izenordain inpertsonal</para><para>pronombre impersonal</para><para>impersonal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalPronoun</seealso>
    let ImpersonalPronoun =
        Prefixed_Name(lexinfov3, "ImpersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:impersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Pronoun lacking person referent.</para>
    /// labels<para>izenordain inpertsonal</para><para>pronombre impersonal</para><para>impersonal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#impersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#impersonalPronoun</seealso>
    let impersonalPronoun =
        Prefixed_Name(lexinfov3, "impersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ImpersonalTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>impersonal transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ImpersonalTransitiveFrame</seealso>
    let ImpersonalTransitiveFrame =
        Prefixed_Name(lexinfov3, "ImpersonalTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>articolo indeterminativo</para><para>przedimek nieokreślony</para><para>неопределенный артикль</para><para>nežymimasis artikelis</para><para>határozatlan névelő</para><para>artículo indefinido</para><para>articolul nehotărât</para><para>umbmäärane artikkel</para><para>Onbepaald lidwoord</para><para>indefinite article</para><para>artigo indefinido</para><para>óákveðinn greinir</para><para>article indefinit</para><para>artigo indefinido</para><para>artikulu mugagabe</para><para>ubestemt artikel</para><para>Indefinitartikel</para><para>article indéfini</para><para>неодређени члан</para><para>člen neurčitý</para><para>αόριστο άρθρο</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteArticle</seealso>
    let IndefiniteArticle =
        Prefixed_Name(lexinfov3, "IndefiniteArticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefiniteArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Article not capable of expressing identification.</para>
    /// labels<para>articolo indeterminativo</para><para>przedimek nieokreślony</para><para>неопределенный артикль</para><para>nežymimasis artikelis</para><para>artículo indefinido</para><para>umbmäärane artikkel</para><para>határozatlan névelő</para><para>articolul nehotărât</para><para>Onbepaald lidwoord</para><para>indefinite article</para><para>óákveðinn greinir</para><para>artikulu mugagabe</para><para>article indefinit</para><para>artigo indefinido</para><para>artigo indefinido</para><para>article indéfini</para><para>ubestemt artikel</para><para>Indefinitartikel</para><para>неодређени члан</para><para>αόριστο άρθρο</para><para>člen neurčitý</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteArticle</seealso>
    let indefiniteArticle =
        Prefixed_Name(lexinfov3, "indefiniteArticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefiniteCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>indefinite cardinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteCardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteCardinalNumeral</seealso>
    let IndefiniteCardinalNumeral =
        Prefixed_Name(lexinfov3, "IndefiniteCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:indefiniteCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A word used to express imprecise quantity.</para>
    /// labels<para>indefinite cardinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteCardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#indefiniteCardinalNumeral</seealso>
    let indefiniteCardinalNumeral =
        Prefixed_Name(lexinfov3, "indefiniteCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IndefiniteDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>determinatzaile mugagabe</para><para>determinante indefinido</para><para>indefinite determiner</para><para>déterminant indéfini</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#IndefiniteDeterminer</seealso>
    let IndefiniteDeterminer =
        Prefixed_Name(lexinfov3, "IndefiniteDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:associativeRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.</para>
    /// labels<para>associative relation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#associativeRelation">http://www.lexinfo.net/ontology/3.0/lexinfo#associativeRelation</seealso>
    let associativeRelation =
        Prefixed_Name(lexinfov3, "associativeRelation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:relatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A term connected to another term by a coordinate or associative relation.</para>
    /// labels<para>related term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#relatedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#relatedTerm</seealso>
    let relatedTerm = Prefixed_Name(lexinfov3, "relatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:attitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the speaker’s subjective point of view, positive or negative, regarding the object referred to by a given lexical unit</para>
    /// labels<para>attitude</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#attitude">http://www.lexinfo.net/ontology/3.0/lexinfo#attitude</seealso>
    let attitude = Prefixed_Name(lexinfov3, "attitude") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:baseElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>The root form of a word or term that is used as the formal dictionary entry for the term.</para>
    /// labels<para>base element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#baseElement">http://www.lexinfo.net/ontology/3.0/lexinfo#baseElement</seealso>
    let baseElement = Prefixed_Name(lexinfov3, "baseElement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:benchLevelRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>Register of terms used in applications-oriented as opposed to theoretical or academic levels of language. // The register of terms used in applications-oriented as opposed to theoretical or academic levels of language.</para>
    /// labels<para>bench level register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#benchLevelRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#benchLevelRegister</seealso>
    let benchLevelRegister =
        Prefixed_Name(lexinfov3, "benchLevelRegister") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:benefactiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case that expresses that the referent of the noun it marks receives the benefit of the situation expressed by the clause.</para>
    /// labels<para>benefactive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCase</seealso>
    let benefactiveCase = Prefixed_Name(lexinfov3, "benefactiveCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:benefactiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>benefactive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#benefactiveCaseForm</seealso>
    let benefactiveCaseForm =
        Prefixed_Name(lexinfov3, "benefactiveCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:bound</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Cliticness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Linked to a particular element.</para>
    /// labels<para>bound</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#bound">http://www.lexinfo.net/ontology/3.0/lexinfo#bound</seealso>
    let bound = Prefixed_Name(lexinfov3, "bound") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:causallyRelatedConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.</para>
    /// labels<para>causally related concept</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#causallyRelatedConcept">http://www.lexinfo.net/ontology/3.0/lexinfo#causallyRelatedConcept</seealso>
    let causallyRelatedConcept =
        Prefixed_Name(lexinfov3, "causallyRelatedConcept") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:causativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case which expresses that the referent of the noun it marks is the cause of the situation expressed by the clause.</para>
    /// labels<para>causative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCase</seealso>
    let causativeCase = Prefixed_Name(lexinfov3, "causativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:causativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>causative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#causativeCaseForm</seealso>
    let causativeCaseForm =
        Prefixed_Name(lexinfov3, "causativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:cessative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>Aspect that expresses the cessation of an event or state.</para>
    /// labels<para>cessative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#cessative">http://www.lexinfo.net/ontology/3.0/lexinfo#cessative</seealso>
    let cessative = Prefixed_Name(lexinfov3, "cessative") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:clausalArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>clausal arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#clausalArg">http://www.lexinfo.net/ontology/3.0/lexinfo#clausalArg</seealso>
    let clausalArg = Prefixed_Name(lexinfov3, "clausalArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:clippedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>An abbreviation formed by truncating a part of a simple term.</para>
    /// labels<para>clipped term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTerm</seealso>
    let clippedTerm = Prefixed_Name(lexinfov3, "clippedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:clippedTermFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between a clipped term and its full or expanded form.</para>
    /// labels<para>clipped term for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTermFor">http://www.lexinfo.net/ontology/3.0/lexinfo#clippedTermFor</seealso>
    let clippedTermFor = Prefixed_Name(lexinfov3, "clippedTermFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:derivedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A form that is derived morphosyntactically from another form</para>
    /// labels<para>derived form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#derivedForm">http://www.lexinfo.net/ontology/3.0/lexinfo#derivedForm</seealso>
    let derivedForm = Prefixed_Name(lexinfov3, "derivedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:cliticness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Categorization of the different types of clitics</para>
    /// labels<para>cliticness</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#cliticness">http://www.lexinfo.net/ontology/3.0/lexinfo#cliticness</seealso>
    let cliticness = Prefixed_Name(lexinfov3, "cliticness") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formNumberVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form number variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formNumberVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formNumberVariant</seealso>
    let formNumberVariant =
        Prefixed_Name(lexinfov3, "formNumberVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:collocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Two terms that occur together far more frequently than chance</para>
    /// labels<para>collocation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#collocation">http://www.lexinfo.net/ontology/3.0/lexinfo#collocation</seealso>
    let collocation = Prefixed_Name(lexinfov3, "collocation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:comitativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case which expresses a meaning similar to 'along with' or 'accompagnied by'.</para>
    /// labels<para>comitative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCase</seealso>
    let comitativeCase = Prefixed_Name(lexinfov3, "comitativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:comitativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>comitative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#comitativeCaseForm</seealso>
    let comitativeCaseForm =
        Prefixed_Name(lexinfov3, "comitativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:commonGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Gender</para>
    ///   <para>Indistinguished gender for epicenes.</para>
    /// labels<para>common gender</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonGender">http://www.lexinfo.net/ontology/3.0/lexinfo#commonGender</seealso>
    let commonGender = Prefixed_Name(lexinfov3, "commonGender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:commonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A synonym for an international scientific term that is used in general discourse in a given language.</para>
    /// labels<para>common name</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonName">http://www.lexinfo.net/ontology/3.0/lexinfo#commonName</seealso>
    let commonName = Prefixed_Name(lexinfov3, "commonName") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:commonlyUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Frequency</para>
    ///   <para>owl:Thing</para>
    ///   <para>Said of a term that appears frequently.</para>
    /// labels<para>commonly used</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonlyUsed">http://www.lexinfo.net/ontology/3.0/lexinfo#commonlyUsed</seealso>
    let commonlyUsed = Prefixed_Name(lexinfov3, "commonlyUsed") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:comparative</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Degree</para>
    ///   <para>owl:Thing</para>
    ///   <para>Comparative is the comparison where only two entites are involved.</para>
    /// labels<para>comparative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparative">http://www.lexinfo.net/ontology/3.0/lexinfo#comparative</seealso>
    let comparative = Prefixed_Name(lexinfov3, "comparative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:formDegreeVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form degree variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formDegreeVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formDegreeVariant</seealso>
    let formDegreeVariant =
        Prefixed_Name(lexinfov3, "formDegreeVariant") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:compound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A lexical unit that combines two or sometimes more different words, frequently such that the sense of the new lexical unit is not clearly derivable from the combination of its parts.</para>
    /// labels<para>compound</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#compound">http://www.lexinfo.net/ontology/3.0/lexinfo#compound</seealso>
    let compound = Prefixed_Name(lexinfov3, "compound") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:conditional</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///   <para>A conditional relation is a logical relation in which the illocutionary act employing one of a pair of propositions is expressed or implied to be true or in force if the other proposition is true.</para>
    /// labels<para>conditional</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditional">http://www.lexinfo.net/ontology/3.0/lexinfo#conditional</seealso>
    let conditional = Prefixed_Name(lexinfov3, "conditional") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:confidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The confidence in a given relationship.</para>
    /// labels<para>confidence</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#confidence">http://www.lexinfo.net/ontology/3.0/lexinfo#confidence</seealso>
    let confidence = Prefixed_Name(lexinfov3, "confidence") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:conjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Word that syntactically links words or constituents, and expresses a semantic relationship between them.</para>
    /// labels<para>congiunzione</para><para>conjunction</para><para>konjunktion</para><para>konjunksjon</para><para>Konjunktion</para><para>konjunktion</para><para>konġunzjoni</para><para>konjunksjon</para><para>conjonction</para><para>conjuncție</para><para>מילת קישור</para><para>samtenging</para><para>juntagailu</para><para>conjunción</para><para>conxunción</para><para>konjunktio</para><para>bindvlies</para><para>σύνδεσμος</para><para>сполучник</para><para>conjunció</para><para>conjunção</para><para>jungtukas</para><para>sidesõna</para><para>сврзник</para><para>spójnik</para><para>veznici</para><para>злучнік</para><para>lidhëza</para><para>kötőszó</para><para>saiklis</para><para>veznik</para><para>везник</para><para>spojka</para><para>spojka</para><para>съюз</para><para>союз</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#conjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#conjunction</seealso>
    let conjunction = Prefixed_Name(lexinfov3, "conjunction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:contraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>A lexical unit formed by a shortening of a word, syllable, or word group by omission of a sound or letter.</para>
    /// labels<para>contraction</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#contraction">http://www.lexinfo.net/ontology/3.0/lexinfo#contraction</seealso>
    let contraction = Prefixed_Name(lexinfov3, "contraction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:positiveDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>positive degree form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#positiveDegreeForm">http://www.lexinfo.net/ontology/3.0/lexinfo#positiveDegreeForm</seealso>
    let positiveDegreeForm =
        Prefixed_Name(lexinfov3, "positiveDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:positiveForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>positive form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#positiveForm">http://www.lexinfo.net/ontology/3.0/lexinfo#positiveForm</seealso>
    let positiveForm = Prefixed_Name(lexinfov3, "positiveForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:possessive</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:ReferentType</para>
    ///   <para>owl:Thing</para>
    ///   <para>Relative to the possession or association.</para>
    /// labels<para>possessive</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessive">http://www.lexinfo.net/ontology/3.0/lexinfo#possessive</seealso>
    let possessive = Prefixed_Name(lexinfov3, "possessive") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:possessiveInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>possessive infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveInfinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#possessiveInfinitiveClause</seealso>
    let possessiveInfinitiveClause =
        Prefixed_Name(lexinfov3, "possessiveInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:postModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:ModificationType</para>
    ///   <para>owl:Thing</para>
    ///   <para>Situation where the modifier is after the modified.</para>
    /// labels<para>post modifier</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#postModifier">http://www.lexinfo.net/ontology/3.0/lexinfo#postModifier</seealso>
    let postModifier = Prefixed_Name(lexinfov3, "postModifier") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:attributiveArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>attributive arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#attributiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#attributiveArg</seealso>
    let attributiveArg = Prefixed_Name(lexinfov3, "attributiveArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:copulativeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him</para>
    /// labels<para>copulative subject</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeSubject">http://www.lexinfo.net/ontology/3.0/lexinfo#copulativeSubject</seealso>
    let copulativeSubject =
        Prefixed_Name(lexinfov3, "copulativeSubject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveSententialFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive sentential frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveSententialFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveSententialFrame</seealso>
    let TransitiveSententialFrame =
        Prefixed_Name(lexinfov3, "TransitiveSententialFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:subjunctive</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Mood</para>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>owl:Thing</para>
    ///   <para>Mood often used to express uncertainty, whishes or desires.</para>
    /// labels<para>subjunctive</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctive">http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctive</seealso>
    let subjunctive = Prefixed_Name(lexinfov3, "subjunctive") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:comparativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>comparative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeAdjunct</seealso>
    let comparativeAdjunct =
        Prefixed_Name(lexinfov3, "comparativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DativePostPositiveArg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DativePostPositiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#DativePostPositiveArg</seealso>
    let DativePostPositiveArg =
        Prefixed_Name(lexinfov3, "DativePostPositiveArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Circumposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>circumposition</para><para>circumposición</para><para>zirkumposizio</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Circumposition">http://www.lexinfo.net/ontology/3.0/lexinfo#Circumposition</seealso>
    let Circumposition = Prefixed_Name(lexinfov3, "Circumposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:circumposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adposition which consists of two parts which are positioned ahead and after the adpositional foci.</para>
    /// labels<para>circumposition</para><para>circumposición</para><para>zirkumposizio</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#circumposition">http://www.lexinfo.net/ontology/3.0/lexinfo#circumposition</seealso>
    let circumposition = Prefixed_Name(lexinfov3, "circumposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ClausalArg</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>clausal arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ClausalArg">http://www.lexinfo.net/ontology/3.0/lexinfo#ClausalArg</seealso>
    let ClausalArg = Prefixed_Name(lexinfov3, "ClausalArg") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:CloseParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>close parenthesis</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CloseParenthesis">http://www.lexinfo.net/ontology/3.0/lexinfo#CloseParenthesis</seealso>
    let CloseParenthesis = Prefixed_Name(lexinfov3, "CloseParenthesis") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:CollectivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>collective pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CollectivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#CollectivePronoun</seealso>
    let CollectivePronoun =
        Prefixed_Name(lexinfov3, "CollectivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:collectivePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>A pronoun that refers to all elements of a set.</para>
    /// labels<para>collective pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#collectivePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#collectivePronoun</seealso>
    let collectivePronoun =
        Prefixed_Name(lexinfov3, "collectivePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:GenitiveDitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>genitive ditransitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveDitransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveDitransitiveFrame</seealso>
    let GenitiveDitransitiveFrame =
        Prefixed_Name(lexinfov3, "GenitiveDitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#adjunct</seealso>
    let adjunct = Prefixed_Name(lexinfov3, "adjunct") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:admittedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term rated according to the scale of a term acceptability rating as a synonym for a preferred term.</para>
    /// labels<para>admitted term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#admittedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#admittedTerm</seealso>
    let admittedTerm = Prefixed_Name(lexinfov3, "admittedTerm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adpositionalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adpositional object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adpositionalObject">http://www.lexinfo.net/ontology/3.0/lexinfo#adpositionalObject</seealso>
    let adpositionalObject =
        Prefixed_Name(lexinfov3, "adpositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Part of speech to refer to an heterogeneous group of words whose most frequent function is to specify the mode of action of the verb.</para>
    /// labels<para>apstākļa vārds</para><para>prieveiksmis</para><para>dobhriathar</para><para>határozószó</para><para>прислівник</para><para>przysłówek</para><para>ndajfolje</para><para>atviksorð</para><para>příslovce</para><para>תואר פועל</para><para>príslovka</para><para>määrsõna</para><para>avverbio</para><para>bijwoord</para><para>прыслоўе</para><para>adverbio</para><para>adberbio</para><para>επίρρημα</para><para>adverbio</para><para>advérbio</para><para>наречие</para><para>adverbe</para><para>adverbi</para><para>наречие</para><para>prislov</para><para>adverbi</para><para>prilozi</para><para>adverb</para><para>adverb</para><para>прилог</para><para>прилог</para><para>Adverb</para><para>adverb</para><para>avverb</para><para>adverb</para><para>adverb</para><para>biord</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adverb">http://www.lexinfo.net/ontology/3.0/lexinfo#adverb</seealso>
    let adverb = Prefixed_Name(lexinfov3, "adverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:otherNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Number</para>
    ///   <para>Designation used to classify number-related grammatical information that can differ from the standard European classifications cited above.</para>
    /// labels<para>other number</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumber">http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumber</seealso>
    let otherNumber = Prefixed_Name(lexinfov3, "otherNumber") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:otherNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>other number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#otherNumberForm</seealso>
    let otherNumberForm = Prefixed_Name(lexinfov3, "otherNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:partHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates a part of this object</para>
    /// labels<para>part holonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partHolonym">http://www.lexinfo.net/ontology/3.0/lexinfo#partHolonym</seealso>
    let partHolonym = Prefixed_Name(lexinfov3, "partHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:partMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates this a component of the other concept</para>
    /// labels<para>part meronym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partMeronym">http://www.lexinfo.net/ontology/3.0/lexinfo#partMeronym</seealso>
    let partMeronym = Prefixed_Name(lexinfov3, "partMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:partNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A unique alphanumeric designation assigned to an object in a manufacturing system.</para>
    /// labels<para>part number</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partNumber">http://www.lexinfo.net/ontology/3.0/lexinfo#partNumber</seealso>
    let partNumber = Prefixed_Name(lexinfov3, "partNumber") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:participle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:VerbFormMood</para>
    ///   <para>Term referring to a word derived from a verb and used as an adjective.</para>
    /// labels<para>participle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#participle">http://www.lexinfo.net/ontology/3.0/lexinfo#participle</seealso>
    let participle = Prefixed_Name(lexinfov3, "participle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:participleFormOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'</para>
    /// labels<para>participle form of</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#participleFormOf">http://www.lexinfo.net/ontology/3.0/lexinfo#participleFormOf</seealso>
    let participleFormOf = Prefixed_Name(lexinfov3, "participleFormOf") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:languageSpecific</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#languageSpecific">http://www.lexinfo.net/ontology/3.0/lexinfo#languageSpecific</seealso>
    let languageSpecific = Prefixed_Name(lexinfov3, "languageSpecific") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:EmphaticPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>izenordain enfatiko</para><para>pronombre enfático</para><para>emphatic pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#EmphaticPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#EmphaticPronoun</seealso>
    let EmphaticPronoun = Prefixed_Name(lexinfov3, "EmphaticPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:exclamativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Determiner expressing an emotional utterance and marked with a strong intonation.</para>
    /// labels<para>exclamative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#exclamativeDeterminer</seealso>
    let exclamativeDeterminer =
        Prefixed_Name(lexinfov3, "exclamativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ExclamativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pronombre exclamativo</para><para>harridura-izenordain</para><para>exclamative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ExclamativePronoun</seealso>
    let ExclamativePronoun =
        Prefixed_Name(lexinfov3, "ExclamativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:existentialPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>pronoun that indicates the existence of something or someone</para>
    /// labels<para>existential pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#existentialPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#existentialPronoun</seealso>
    let existentialPronoun =
        Prefixed_Name(lexinfov3, "existentialPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:GenitivePostPositiveArg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitivePostPositiveArg">http://www.lexinfo.net/ontology/3.0/lexinfo#GenitivePostPositiveArg</seealso>
    let GenitivePostPositiveArg =
        Prefixed_Name(lexinfov3, "GenitivePostPositiveArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#object">http://www.lexinfo.net/ontology/3.0/lexinfo#object</seealso>
    let object = Prefixed_Name(lexinfov3, "object") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:PartOfSpeech</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>kategoria morfosintaktiko</para><para>categoría gramatical</para><para>categoría gramatical</para><para>γραμματική κατηγορία</para><para>categoria gramatical</para><para>parte del discorso</para><para>classe gramatical</para><para>parte de vorbire</para><para>klasë e fjalëve</para><para>part of speech</para><para>зборовна група</para><para>besedna vrsta</para><para>част на речта</para><para>часціны мовы</para><para>kalbos dalis</para><para>частина мови</para><para>slovný druh</para><para>slovní druh</para><para>sanaluokka</para><para>врста речи</para><para>часть речи</para><para>orðflokkur</para><para>חלקי הדיבר</para><para>część mowy</para><para>woordsoort</para><para>vārdšķira</para><para>ordklasse</para><para>ordklasse</para><para>ordklasse</para><para>sõnaliik</para><para>ordklass</para><para>Wortart</para><para>szófaj</para><para>nature</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PartOfSpeech">http://www.lexinfo.net/ontology/3.0/lexinfo#PartOfSpeech</seealso>
    let PartOfSpeech = Prefixed_Name(lexinfov3, "PartOfSpeech") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:AdjectivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePPFrame</seealso>
    let AdjectivePPFrame = Prefixed_Name(lexinfov3, "AdjectivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectivePredicativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective predicative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePredicativeFrame</seealso>
    let AdjectivePredicativeFrame =
        Prefixed_Name(lexinfov3, "AdjectivePredicativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectivePhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective phrase</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePhrase">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectivePhrase</seealso>
    let AdjectivePhrase = Prefixed_Name(lexinfov3, "AdjectivePhrase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:head</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the head element of a phrase</para>
    /// labels<para>head</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#head">http://www.lexinfo.net/ontology/3.0/lexinfo#head</seealso>
    let head = Prefixed_Name(lexinfov3, "head") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:TransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>marku trantsitibo</para><para>marco transitivo</para><para>transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveFrame</seealso>
    let TransitiveFrame = Prefixed_Name(lexinfov3, "TransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveTransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive transitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveTransitivePPFrame</seealso>
    let ReflexiveTransitivePPFrame =
        Prefixed_Name(lexinfov3, "ReflexiveTransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:relationNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>relation noun</para>
    /// labels<para>nombre de relación</para><para>relation noun</para><para>erlazio-izen</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#relationNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#relationNoun</seealso>
    let relationNoun = Prefixed_Name(lexinfov3, "relationNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:case</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.</para>
    /// labels<para>Rasa gramatikore</para><para>caso gramatical</para><para>cas grammatical</para><para>caso gramatical</para><para>caso gramatical</para><para>kasu gramatikal</para><para>cas gramatical</para><para>mluvnický pád</para><para>przypadek</para><para>linksnis</para><para>locījums</para><para>відмінок</para><para>naamval</para><para>πτώση</para><para>склон</para><para>kasus</para><para>kasus</para><para>padež</para><para>Kasus</para><para>падеж</para><para>kasus</para><para>падеж</para><para>kasus</para><para>sklon</para><para>kääne</para><para>падеж</para><para>падеж</para><para>case</para><para>eset</para><para>fall</para><para>יחסה</para><para>caso</para><para>sija</para><para>pád</para><para>caz</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#case">http://www.lexinfo.net/ontology/3.0/lexinfo#case</seealso>
    let case = Prefixed_Name(lexinfov3, "case") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:paucalNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>paucal number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#paucalNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#paucalNumberForm</seealso>
    let paucalNumberForm = Prefixed_Name(lexinfov3, "paucalNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:perfective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Aspect</para>
    ///   <para>owl:Thing</para>
    ///   <para>Perfective aspect is an aspect that expresses a temporal view of an event or state as a simple whole, apart from the consideration of the internal structure of the time in which it occurs.</para>
    /// labels<para>perfective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#perfective">http://www.lexinfo.net/ontology/3.0/lexinfo#perfective</seealso>
    let perfective = Prefixed_Name(lexinfov3, "perfective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.</para>
    /// labels<para>proprietate morfosintactică a persoanei</para><para>darbības vārda persona</para><para>ιδιότητα του προσώπου</para><para>proprietà di persona</para><para>pertsona gramatikal</para><para>persona gramatical</para><para>grammatisk person</para><para>pessoa gramatical</para><para>grammatisk person</para><para>grammatisk person</para><para>persoa gramatical</para><para>Veta gramatikore</para><para>граматична особа</para><para>Slovnična oseba</para><para>asmens požymis</para><para>persoona</para><para>personne</para><para>persóna</para><para>személy</para><para>persona</para><para>persoon</para><para>person</para><para>person</para><para>Person</para><para>osoba</para><para>osoba</para><para>Osoba</para><para>isik</para><para>лице</para><para>лицо</para><para>лице</para><para>גוף</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#person">http://www.lexinfo.net/ontology/3.0/lexinfo#person</seealso>
    let person = Prefixed_Name(lexinfov3, "person") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveGenitivePostPositiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective genitive post positive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveGenitivePostPositiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveGenitivePostPositiveFrame</seealso>
    let AdjectiveGenitivePostPositiveFrame =
        Prefixed_Name(lexinfov3, "AdjectiveGenitivePostPositiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:cardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>A word denoting a number.</para>
    /// labels<para>количественное числительное</para><para>kiekinis skaitvardis</para><para>zenbatzaile kardinal</para><para>číslovka základní</para><para>adjetivo cardinal</para><para>numeral cardinal</para><para>numeral cardinal</para><para>cardinal numeral</para><para>liczebnik główny</para><para>numero cardinale</para><para>απόλυτος αριθμός</para><para>Glavni števnik</para><para>Hoofdtelwoord</para><para>основни број</para><para>Kardinalzahl</para><para>tőszámnév</para><para>mængdetal</para><para>grunntall</para><para>frumtala</para><para>cardinal</para><para>Grundtal</para><para>põhiarv</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#cardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#cardinalNumeral</seealso>
    let cardinalNumeral = Prefixed_Name(lexinfov3, "cardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:NominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>nominal complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NominalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#NominalComplementFrame</seealso>
    let NominalComplementFrame =
        Prefixed_Name(lexinfov3, "NominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///
    /// labels<para>abbreviation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviation">http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviation</seealso>
    let abbreviation = Prefixed_Name(lexinfov3, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:modificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to the prenominal or postnominal positions of determiners which distinguish different forms.</para>
    /// labels<para>modification type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#modificationType">http://www.lexinfo.net/ontology/3.0/lexinfo#modificationType</seealso>
    let modificationType = Prefixed_Name(lexinfov3, "modificationType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:mood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).</para>
    /// labels<para>Format e shtjelluara të foljes</para><para>gramatiskā izteiksme</para><para>наклонение глагола</para><para>grammatisk modus</para><para>Glagolski naklon</para><para>глаголски начин</para><para>modo gramatical</para><para>slovesný spôsob</para><para>slovesný způsob</para><para>mod al verbului</para><para>modo gramatical</para><para>глаголски начин</para><para>способи дієслів</para><para>modu gramatikal</para><para>лад дзеяслова</para><para>Hættir sagna</para><para>modo verbal</para><para>Наклонение</para><para>tapaluokka</para><para>Kõneviis</para><para>έγκλιση</para><para>Nuosaka</para><para>igemód</para><para>Modus</para><para>modus</para><para>Modus</para><para>מודוס</para><para>modus</para><para>mode</para><para>mood</para><para>tryb</para><para>wijs</para><para>mode</para><para>modo</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#mood">http://www.lexinfo.net/ontology/3.0/lexinfo#mood</seealso>
    let mood = Prefixed_Name(lexinfov3, "mood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:termType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An attribute assigned to a lexeme or a term.</para>
    /// labels<para>term type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#termType">http://www.lexinfo.net/ontology/3.0/lexinfo#termType</seealso>
    let termType = Prefixed_Name(lexinfov3, "termType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:thirdPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Person</para>
    ///   <para>Third person deixis is deictic reference to a referent(s) not identified as the speaker or addressee.</para>
    /// labels<para>third person</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPerson">http://www.lexinfo.net/ontology/3.0/lexinfo#thirdPerson</seealso>
    let thirdPerson = Prefixed_Name(lexinfov3, "thirdPerson") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:translationConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The confidence in a given translation.</para>
    /// labels<para>translation confidence</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#translationConfidence">http://www.lexinfo.net/ontology/3.0/lexinfo#translationConfidence</seealso>
    let translationConfidence =
        Prefixed_Name(lexinfov3, "translationConfidence") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:transliteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Form resulting from the conversion of one writing system into another</para>
    /// labels<para>transliteration</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#transliteration">http://www.lexinfo.net/ontology/3.0/lexinfo#transliteration</seealso>
    let transliteration = Prefixed_Name(lexinfov3, "transliteration") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:trialNumberForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>trial number form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#trialNumberForm">http://www.lexinfo.net/ontology/3.0/lexinfo#trialNumberForm</seealso>
    let trialNumberForm = Prefixed_Name(lexinfov3, "trialNumberForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:unaccomplished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Aspect</para>
    ///   <para>aspect that expresses an event or state that is not finished.</para>
    /// labels<para>unaccomplished</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#unaccomplished">http://www.lexinfo.net/ontology/3.0/lexinfo#unaccomplished</seealso>
    let unaccomplished = Prefixed_Name(lexinfov3, "unaccomplished") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveImpersonalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective impersonal frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveImpersonalFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveImpersonalFrame</seealso>
    let AdjectiveImpersonalFrame =
        Prefixed_Name(lexinfov3, "AdjectiveImpersonalFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Cliticness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>cliticness</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Cliticness">http://www.lexinfo.net/ontology/3.0/lexinfo#Cliticness</seealso>
    let Cliticness = Prefixed_Name(lexinfov3, "Cliticness") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Colon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kaksoispiste</para><para>dous puntos</para><para>Doppelpunkt</para><para>Două puncte</para><para>dois pontos</para><para>dubbelepunt</para><para>deux-points</para><para>dos puntos</para><para>kettőspont</para><para>двоеточие</para><para>due punti</para><para>Dvojbodka</para><para>двукроп'е</para><para>Dvojtečka</para><para>двокрапка</para><para>Dwukropek</para><para>Две тачке</para><para>Две точки</para><para>Dvitaškis</para><para>Двоеточие</para><para>dos punts</para><para>נקודתיים</para><para>Bi puntu</para><para>Dvopičje</para><para>Dy pikat</para><para>Dvotočje</para><para>Koolon</para><para>kolon</para><para>colon</para><para>kolon</para><para>kolon</para><para>kolon</para><para>kols</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Colon">http://www.lexinfo.net/ontology/3.0/lexinfo#Colon</seealso>
    let Colon = Prefixed_Name(lexinfov3, "Colon") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:GenitiveTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>genitive transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#GenitiveTransitiveFrame</seealso>
    let GenitiveTransitiveFrame =
        Prefixed_Name(lexinfov3, "GenitiveTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReciprocalFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reciprocal frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalFrame</seealso>
    let ReciprocalFrame = Prefixed_Name(lexinfov3, "ReciprocalFrame") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:affix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermElement</para>
    ///
    /// labels<para>affix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#affix">http://www.lexinfo.net/ontology/3.0/lexinfo#affix</seealso>
    let affix = Prefixed_Name(lexinfov3, "affix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:allativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case which expresses the meaning of motion 'to' or 'towards' the referent it marks.</para>
    /// labels<para>allative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCase</seealso>
    let allativeCase = Prefixed_Name(lexinfov3, "allativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:animacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.</para>
    /// labels<para>animacidade (linguística)</para><para>animatum og inanimatum</para><para>Животност (граматика)</para><para>Belebtheitshierarchie</para><para>назви істот і неістот</para><para>animat și inanimat</para><para>одушевлённость</para><para>адушаўлёнасць</para><para>biziduntasun</para><para>animacidad</para><para>animacitat</para><para>Animacitet</para><para>animathet</para><para>żywotność</para><para>životnosť</para><para>životnost</para><para>animéité</para><para>animacy</para><para>Gyvumas</para><para>מונפשות</para><para>Élőség</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#animacy">http://www.lexinfo.net/ontology/3.0/lexinfo#animacy</seealso>
    let animacy = Prefixed_Name(lexinfov3, "animacy") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:trial</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>Grammatical number referring to 'three things', as opposed to 'singular' and 'plural'.</para>
    /// labels<para>trial</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#trial">http://www.lexinfo.net/ontology/3.0/lexinfo#trial</seealso>
    let trial = Prefixed_Name(lexinfov3, "trial") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the the terms have the same meaning lexicographically</para>
    /// labels<para>synonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#synonym">http://www.lexinfo.net/ontology/3.0/lexinfo#synonym</seealso>
    let synonym = Prefixed_Name(lexinfov3, "synonym") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:temporalQualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An attribution of a term or lexeme with respect to its use over time.</para>
    /// labels<para>temporal qualifier</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#temporalQualifier">http://www.lexinfo.net/ontology/3.0/lexinfo#temporalQualifier</seealso>
    let temporalQualifier =
        Prefixed_Name(lexinfov3, "temporalQualifier") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:adposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Part of speech that occurs before/inside/after a complement composed of a noun phrase, noun, pronoun or clause that functions as a noun phrase and form a single structure with the complement to express its grammatical and semantic relation to another unit.</para>
    /// labels<para>apposizione</para><para>forsetning</para><para>adposisjon</para><para>adposition</para><para>Prepoziție</para><para>adposition</para><para>adposition</para><para>adpozicija</para><para>адпозиција</para><para>Adposition</para><para>adposición</para><para>adposition</para><para>adposition</para><para>parafjalë</para><para>aposición</para><para>adpozíció</para><para>adposizio</para><para>adpositio</para><para>adposició</para><para>adposição</para><para>przyimek</para><para>מילת יחס</para><para>kaassõna</para><para>πρόθεση</para><para>záložka</para><para>афикс</para><para>адлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adposition">http://www.lexinfo.net/ontology/3.0/lexinfo#adposition</seealso>
    let adposition = Prefixed_Name(lexinfov3, "adposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:closeParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>End of a parenthesis pair.</para>
    /// labels<para>close parenthesis</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#closeParenthesis">http://www.lexinfo.net/ontology/3.0/lexinfo#closeParenthesis</seealso>
    let closeParenthesis = Prefixed_Name(lexinfov3, "closeParenthesis") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:colon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Sign with two vertical points that is used in writing and printing to introduce an explanation, example or quotation.</para>
    /// labels<para>Kaksoispiste</para><para>Două puncte</para><para>dubbelepunt</para><para>dous puntos</para><para>dois pontos</para><para>deux-points</para><para>Doppelpunkt</para><para>kettőspont</para><para>dos puntos</para><para>Двоеточие</para><para>Dvitaškis</para><para>Две тачке</para><para>dos punts</para><para>Dvojbodka</para><para>Dvojtečka</para><para>двокрапка</para><para>Две точки</para><para>двукроп'е</para><para>due punti</para><para>Dwukropek</para><para>двоеточие</para><para>Bi puntu</para><para>נקודתיים</para><para>Dvotočje</para><para>Dy pikat</para><para>Dvopičje</para><para>Koolon</para><para>kolon</para><para>kolon</para><para>kolon</para><para>colon</para><para>kolon</para><para>kols</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#colon">http://www.lexinfo.net/ontology/3.0/lexinfo#colon</seealso>
    let colon = Prefixed_Name(lexinfov3, "colon") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Comma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>kommatecken</para><para>Przecinek</para><para>Kablelis</para><para>Запетая</para><para>virgola</para><para>Запирка</para><para>Virgulă</para><para>vírgula</para><para>запятая</para><para>virgule</para><para>Vejica</para><para>Čiarka</para><para>pilkku</para><para>Komats</para><para>Presja</para><para>vessző</para><para>čárka</para><para>Κόμμα</para><para>komma</para><para>Camóg</para><para>comma</para><para>Komma</para><para>Komma</para><para>Zarez</para><para>komma</para><para>Komma</para><para>коска</para><para>Зарез</para><para>komma</para><para>Кома</para><para>Koma</para><para>Koma</para><para>Coma</para><para>פסיק</para><para>coma</para><para>coma</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Comma">http://www.lexinfo.net/ontology/3.0/lexinfo#Comma</seealso>
    let Comma = Prefixed_Name(lexinfov3, "Comma") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:comma</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Mark (,) used in writing to show a short pause or to separate items in a list.</para>
    /// labels<para>kommatecken</para><para>Przecinek</para><para>Kablelis</para><para>virgola</para><para>запятая</para><para>Запирка</para><para>Virgulă</para><para>virgule</para><para>Запетая</para><para>vírgula</para><para>Vejica</para><para>pilkku</para><para>vessző</para><para>Komats</para><para>Presja</para><para>Čiarka</para><para>Camóg</para><para>comma</para><para>komma</para><para>komma</para><para>komma</para><para>Κόμμα</para><para>коска</para><para>Komma</para><para>Komma</para><para>Zarez</para><para>čárka</para><para>Komma</para><para>Зарез</para><para>פסיק</para><para>coma</para><para>Koma</para><para>Coma</para><para>coma</para><para>Koma</para><para>Кома</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comma">http://www.lexinfo.net/ontology/3.0/lexinfo#comma</seealso>
    let comma = Prefixed_Name(lexinfov3, "comma") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:CommonNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>bendrinis daiktavardis</para><para>rzeczownik pospolity</para><para>заједничка именица</para><para>іменник загальний</para><para>имя нарицательное</para><para>substantiv comun</para><para>хадзячая назва</para><para>všeobecné meno</para><para>nombre común</para><para>nome comune</para><para>common noun</para><para>izen arrunt</para><para>appellativ</para><para>nome comum</para><para>sugasvārds</para><para>ουσιαστικό</para><para>Appellativ</para><para>appellativ</para><para>fellesnavn</para><para>nom commun</para><para>apelativum</para><para>nome común</para><para>soortnaam</para><para>občno ime</para><para>yleisnimi</para><para>nom comú</para><para>samnafn</para><para>samnamn</para><para>üldnimi</para><para>köznév</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CommonNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#CommonNoun</seealso>
    let CommonNoun = Prefixed_Name(lexinfov3, "CommonNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>zelfstandig naamwoord</para><para>имя существительное</para><para>съществително име</para><para>podstatné jméno</para><para>podstatné meno</para><para>daiktavardis</para><para>substantiivi</para><para>substantivo</para><para>samostalnik</para><para>substantivo</para><para>супстантив</para><para>substantiv</para><para>substantiv</para><para>substantiv</para><para>Substantiv</para><para>substantiv</para><para>ainmfhocal</para><para>ουσιαστικό</para><para>rzeczownik</para><para>Substantiv</para><para>sustantivo</para><para>sostantivo</para><para>substantiu</para><para>lietvārds</para><para>назоўнік</para><para>nimisõna</para><para>іменник</para><para>imenice</para><para>nafnorð</para><para>именка</para><para>שם עצם</para><para>főnév</para><para>noun</para><para>emër</para><para>nume</para><para>izen</para><para>nom</para><para>nom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Noun">http://www.lexinfo.net/ontology/3.0/lexinfo#Noun</seealso>
    let Noun = Prefixed_Name(lexinfov3, "Noun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:commonNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A noun or adjective denoting a class of objects. // Noun that signifies a non-specific member of a group.</para>
    /// labels<para>bendrinis daiktavardis</para><para>rzeczownik pospolity</para><para>заједничка именица</para><para>іменник загальний</para><para>имя нарицательное</para><para>substantiv comun</para><para>хадзячая назва</para><para>všeobecné meno</para><para>nombre común</para><para>common noun</para><para>nome comune</para><para>izen arrunt</para><para>nome comum</para><para>appellativ</para><para>Appellativ</para><para>nome común</para><para>fellesnavn</para><para>nom commun</para><para>ουσιαστικό</para><para>appellativ</para><para>apelativum</para><para>sugasvārds</para><para>yleisnimi</para><para>soortnaam</para><para>občno ime</para><para>nom comú</para><para>samnamn</para><para>samnafn</para><para>üldnimi</para><para>köznév</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#commonNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#commonNoun</seealso>
    let commonNoun = Prefixed_Name(lexinfov3, "commonNoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ComparativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>comparative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#ComparativeAdjunct</seealso>
    let ComparativeAdjunct =
        Prefixed_Name(lexinfov3, "ComparativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:comparativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Particle used to compare.</para>
    /// labels<para>partikula konparatibo</para><para>partícula comparativa</para><para>comparative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#comparativeParticle</seealso>
    let comparativeParticle =
        Prefixed_Name(lexinfov3, "comparativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:CompoundPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>compound preposition</para><para>preposición compleja</para><para>preposizio elkartu</para><para>составной предлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CompoundPreposition">http://www.lexinfo.net/ontology/3.0/lexinfo#CompoundPreposition</seealso>
    let CompoundPreposition =
        Prefixed_Name(lexinfov3, "CompoundPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:compoundPreposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Preposition that is a aggregation of words</para>
    /// labels<para>compound preposition</para><para>preposición compleja</para><para>preposizio elkartu</para><para>составной предлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#compoundPreposition">http://www.lexinfo.net/ontology/3.0/lexinfo#compoundPreposition</seealso>
    let compoundPreposition =
        Prefixed_Name(lexinfov3, "compoundPreposition") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ConditionalParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>conditional particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalParticle</seealso>
    let ConditionalParticle =
        Prefixed_Name(lexinfov3, "ConditionalParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:conditionalParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>conditional particule</para>
    /// labels<para>conditional particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#conditionalParticle</seealso>
    let conditionalParticle =
        Prefixed_Name(lexinfov3, "conditionalParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ConditionalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>conditional pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ConditionalPronoun</seealso>
    let ConditionalPronoun =
        Prefixed_Name(lexinfov3, "ConditionalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ConjunctionPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>congiunzione</para><para>conjunction</para><para>konjunktion</para><para>konjunktion</para><para>Konjunktion</para><para>konjunksjon</para><para>konġunzjoni</para><para>konjunksjon</para><para>conjonction</para><para>samtenging</para><para>conjunción</para><para>מילת קישור</para><para>conjuncție</para><para>konjunktio</para><para>conxunción</para><para>juntagailu</para><para>сполучник</para><para>conjunção</para><para>conjunció</para><para>jungtukas</para><para>bindvlies</para><para>σύνδεσμος</para><para>sidesõna</para><para>spójnik</para><para>сврзник</para><para>lidhëza</para><para>saiklis</para><para>злучнік</para><para>veznici</para><para>kötőszó</para><para>spojka</para><para>spojka</para><para>везник</para><para>veznik</para><para>съюз</para><para>союз</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ConjunctionPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#ConjunctionPOS</seealso>
    let ConjunctionPOS = Prefixed_Name(lexinfov3, "ConjunctionPOS") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:CoordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>conjonction de coordination</para><para>nebenordnende Konjunktion</para><para>congiunzione coordinante</para><para>coordinating conjunction</para><para>konġunzjoni koordinanti</para><para>conjunción coordinante</para><para>conjunção coordenativa</para><para>emendiozko juntagailu</para><para>соединительный союз</para><para>sideordnet bindeord</para><para>priraďovacia spojka</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinatingConjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinatingConjunction</seealso>
    let CoordinatingConjunction =
        Prefixed_Name(lexinfov3, "CoordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:coordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Conjunction that links constituents.</para>
    /// labels<para>conjonction de coordination</para><para>nebenordnende Konjunktion</para><para>congiunzione coordinante</para><para>coordinating conjunction</para><para>konġunzjoni koordinanti</para><para>conjunción coordinante</para><para>conjunção coordenativa</para><para>emendiozko juntagailu</para><para>sideordnet bindeord</para><para>priraďovacia spojka</para><para>соединительный союз</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinatingConjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#coordinatingConjunction</seealso>
    let coordinatingConjunction =
        Prefixed_Name(lexinfov3, "coordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:CoordinationParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>coordination particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinationParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#CoordinationParticle</seealso>
    let CoordinationParticle =
        Prefixed_Name(lexinfov3, "CoordinationParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:coordinationParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>particle for coordination</para>
    /// labels<para>coordination particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#coordinationParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#coordinationParticle</seealso>
    let coordinationParticle =
        Prefixed_Name(lexinfov3, "coordinationParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Copula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Còpula (lingüística)</para><para>koppelwerkwoord</para><para>Verb copulativ</para><para>Tengisögn</para><para>Koopula</para><para>Copail</para><para>copule</para><para>Kopula</para><para>kopula</para><para>kopula</para><para>copula</para><para>copula</para><para>связка</para><para>kopula</para><para>kopula</para><para>Kopula</para><para>copula</para><para>Kopula</para><para>copula</para><para>Spona</para><para>אוגד</para><para>Vez</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Copula">http://www.lexinfo.net/ontology/3.0/lexinfo#Copula</seealso>
    let Copula = Prefixed_Name(lexinfov3, "Copula") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:copula</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Special word that combines the subject of a sentence and its description.</para>
    /// labels<para>Còpula (lingüística)</para><para>koppelwerkwoord</para><para>Verb copulativ</para><para>Tengisögn</para><para>Koopula</para><para>copule</para><para>kopula</para><para>kopula</para><para>copula</para><para>связка</para><para>Kopula</para><para>copula</para><para>kopula</para><para>kopula</para><para>Kopula</para><para>Kopula</para><para>copula</para><para>copula</para><para>Copail</para><para>Spona</para><para>אוגד</para><para>Vez</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#copula">http://www.lexinfo.net/ontology/3.0/lexinfo#copula</seealso>
    let copula = Prefixed_Name(lexinfov3, "copula") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:CopulativeArg</para>
    /// </summary>
    /// <remarks>
    ///   <para>Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama</para>
    /// labels<para>copulative arg</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeArg">http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeArg</seealso>
    let CopulativeArg = Prefixed_Name(lexinfov3, "CopulativeArg") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:CopulativeSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him</para>
    /// labels<para>copulative subject</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeSubject">http://www.lexinfo.net/ontology/3.0/lexinfo#CopulativeSubject</seealso>
    let CopulativeSubject =
        Prefixed_Name(lexinfov3, "CopulativeSubject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated</para>
    /// labels<para>subject</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Subject">http://www.lexinfo.net/ontology/3.0/lexinfo#Subject</seealso>
    let Subject = Prefixed_Name(lexinfov3, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Dating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>dating</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Dating">http://www.lexinfo.net/ontology/3.0/lexinfo#Dating</seealso>
    let Dating = Prefixed_Name(lexinfov3, "Dating") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:dativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that expresses an indirect object relationship or a range of meaning similar to that covered by 'to' or 'for' in English; but there is a great deal of variation between languages in the way this case is used.</para>
    /// labels<para>dative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#dativeCase</seealso>
    let dativeCase = Prefixed_Name(lexinfov3, "dativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeCardinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>An interrogative/relative word used to ask about quantity.</para>
    /// labels<para>interrogative cardinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeCardinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeCardinalNumeral</seealso>
    let interrogativeCardinalNumeral =
        Prefixed_Name(lexinfov3, "interrogativeCardinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>interrogative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeClause</seealso>
    let InterrogativeClause =
        Prefixed_Name(lexinfov3, "InterrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>interrogative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeDeterminer</seealso>
    let InterrogativeDeterminer =
        Prefixed_Name(lexinfov3, "InterrogativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Determiner used to express a question.</para>
    /// labels<para>interrogative determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeDeterminer</seealso>
    let interrogativeDeterminer =
        Prefixed_Name(lexinfov3, "interrogativeDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., &amp;quot;who&amp;quot;, &amp;quot;where&amp;quot;, &amp;quot;how&amp;quot;)</para>
    /// labels<para>interrogative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeFrame</seealso>
    let InterrogativeFrame =
        Prefixed_Name(lexinfov3, "InterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form</para>
    /// labels<para>interrogative infinitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeInfinitiveFrame</seealso>
    let InterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfov3, "InterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeInfinitiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>interrogative infinitive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeInfinitiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeInfinitiveClause</seealso>
    let interrogativeInfinitiveClause =
        Prefixed_Name(lexinfov3, "interrogativeInfinitiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>interrogative multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeMultiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeMultiplicativeNumeral</seealso>
    let InterrogativeMultiplicativeNumeral =
        Prefixed_Name(lexinfov3, "InterrogativeMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeMultiplicativeNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>An interrogative/relative word used to ask about the number of times something happened.</para>
    /// labels<para>interrogative multiplicative numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeMultiplicativeNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeMultiplicativeNumeral</seealso>
    let interrogativeMultiplicativeNumeral =
        Prefixed_Name(lexinfov3, "interrogativeMultiplicativeNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeOrdinalNumeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>interrogative ordinal numeral</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeOrdinalNumeral">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeOrdinalNumeral</seealso>
    let InterrogativeOrdinalNumeral =
        Prefixed_Name(lexinfov3, "InterrogativeOrdinalNumeral") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Particle used to express a question.</para>
    /// labels<para>partícula interrogativa</para><para>interrogative particle</para><para>вопросительная частица</para><para>partikula galdetzaile</para><para>Fragepartikel</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativeParticle</seealso>
    let interrogativeParticle =
        Prefixed_Name(lexinfov3, "interrogativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pronombre interrogativo</para><para>izenordain galdetzaile</para><para>interrogative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativePronoun</seealso>
    let InterrogativePronoun =
        Prefixed_Name(lexinfov3, "InterrogativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:interrogativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Pronoun used to express a question.</para>
    /// labels<para>pronombre interrogativo</para><para>izenordain galdetzaile</para><para>interrogative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#interrogativePronoun</seealso>
    let interrogativePronoun =
        Prefixed_Name(lexinfov3, "interrogativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:InterrogativeRelativePronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>interrogative relative pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeRelativePronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#InterrogativeRelativePronoun</seealso>
    let InterrogativeRelativePronoun =
        Prefixed_Name(lexinfov3, "InterrogativeRelativePronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveAdverbialComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive adverbial complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdverbialComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveAdverbialComplementFrame</seealso>
    let IntransitiveAdverbialComplementFrame =
        Prefixed_Name(lexinfov3, "IntransitiveAdverbialComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveDeclarativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive declarative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveDeclarativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveDeclarativeFrame</seealso>
    let IntransitiveDeclarativeFrame =
        Prefixed_Name(lexinfov3, "IntransitiveDeclarativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:IntransitiveInfinitiveACFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>intransitive infinitive ac frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveACFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#IntransitiveInfinitiveACFrame</seealso>
    let IntransitiveInfinitiveACFrame =
        Prefixed_Name(lexinfov3, "IntransitiveInfinitiveACFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Postposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>postpozīcija</para><para>postpozicija</para><para>postposition</para><para>postposisjon</para><para>постпозиција</para><para>achterzetsel</para><para>eftirsetning</para><para>posposizione</para><para>postposisjon</para><para>післяйменник</para><para>postposition</para><para>postposition</para><para>postposition</para><para>Postposition</para><para>postpositio</para><para>posposición</para><para>postposizio</para><para>posposición</para><para>постпозиция</para><para>postpoziție</para><para>posposição</para><para>posposició</para><para>μετά-θεση</para><para>tagasõna</para><para>névutó</para><para>poimek</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Postposition">http://www.lexinfo.net/ontology/3.0/lexinfo#Postposition</seealso>
    let Postposition = Prefixed_Name(lexinfov3, "Postposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:postposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Adposition that appears at the end of the noun phrase.</para>
    /// labels<para>postposition</para><para>постпозиција</para><para>postposisjon</para><para>postposisjon</para><para>achterzetsel</para><para>postposition</para><para>Postposition</para><para>posposizione</para><para>postpozicija</para><para>postpozīcija</para><para>postposition</para><para>eftirsetning</para><para>післяйменник</para><para>postposition</para><para>postpoziție</para><para>postposizio</para><para>постпозиция</para><para>posposición</para><para>postpositio</para><para>posposición</para><para>posposició</para><para>posposição</para><para>μετά-θεση</para><para>tagasõna</para><para>poimek</para><para>névutó</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#postposition">http://www.lexinfo.net/ontology/3.0/lexinfo#postposition</seealso>
    let postposition = Prefixed_Name(lexinfov3, "postposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Prefix">http://www.lexinfo.net/ontology/3.0/lexinfo#Prefix</seealso>
    let Prefix = Prefixed_Name(lexinfov3, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Preposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>preposizzjoni</para><para>Prepositioun</para><para>preposizione</para><para>preposition</para><para>preposisjon</para><para>прыназоўнік</para><para>præposition</para><para>preposición</para><para>preposición</para><para>preposisjon</para><para>Präposition</para><para>préposition</para><para>preposition</para><para>prepozicija</para><para>preposició</para><para>prepoziție</para><para>forsetning</para><para>prepozíció</para><para>voorzetsel</para><para>прийменник</para><para>prepositio</para><para>preposição</para><para>preposizio</para><para>prijedlozi</para><para>predložka</para><para>prievārds</para><para>předložka</para><para>przyimek</para><para>מילת יחס</para><para>eessõna</para><para>предлог</para><para>предлог</para><para>предлог</para><para>predlog</para><para>πρόθεση</para><para>предлог</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Preposition">http://www.lexinfo.net/ontology/3.0/lexinfo#Preposition</seealso>
    let Preposition = Prefixed_Name(lexinfov3, "Preposition") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:PrepositionFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>marco preposicional</para><para>preposition frame</para><para>preposizio-marko</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionFrame</seealso>
    let PrepositionFrame = Prefixed_Name(lexinfov3, "PrepositionFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>preposition phrase</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionPhrase">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionPhrase</seealso>
    let PrepositionPhrase =
        Prefixed_Name(lexinfov3, "PrepositionPhrase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalAdjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>prepositional adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdjunct</seealso>
    let PrepositionalAdjunct =
        Prefixed_Name(lexinfov3, "PrepositionalAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adverbio preposicional</para><para>prepositional adverb</para><para>preposizio-adberbio</para><para>voorzetselbijwoord</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalAdverb</seealso>
    let PrepositionalAdverb =
        Prefixed_Name(lexinfov3, "PrepositionalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prepositionalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>adverb which is very similar in its form to a preposition</para>
    /// labels<para>adverbio preposicional</para><para>prepositional adverb</para><para>preposizio-adberbio</para><para>voorzetselbijwoord</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdverb</seealso>
    let prepositionalAdverb =
        Prefixed_Name(lexinfov3, "prepositionalAdverb") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prepositionalAdjunct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prepositional adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalAdjunct</seealso>
    let prepositionalAdjunct =
        Prefixed_Name(lexinfov3, "prepositionalAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalGerundClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>prepositional gerund clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalGerundClause">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalGerundClause</seealso>
    let PrepositionalGerundClause =
        Prefixed_Name(lexinfov3, "PrepositionalGerundClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalInterrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>prepositional interrogative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeClause</seealso>
    let PrepositionalInterrogativeClause =
        Prefixed_Name(lexinfov3, "PrepositionalInterrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prepositional interrogative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalInterrogativeFrame</seealso>
    let PrepositionalInterrogativeFrame =
        Prefixed_Name(lexinfov3, "PrepositionalInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveInfinitiveSCFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive infinitive sc frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveSCFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInfinitiveSCFrame</seealso>
    let TransitiveInfinitiveSCFrame =
        Prefixed_Name(lexinfov3, "TransitiveInfinitiveSCFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveInterrogativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive interrogative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeFrame</seealso>
    let TransitiveInterrogativeFrame =
        Prefixed_Name(lexinfov3, "TransitiveInterrogativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveInterrogativeInfinitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive interrogative infinitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeInfinitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveInterrogativeInfinitiveFrame</seealso>
    let TransitiveInterrogativeInfinitiveFrame =
        Prefixed_Name(lexinfov3, "TransitiveInterrogativeInfinitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:TransitiveNominalComplementFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>transitive nominal complement frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveNominalComplementFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#TransitiveNominalComplementFrame</seealso>
    let TransitiveNominalComplementFrame =
        Prefixed_Name(lexinfov3, "TransitiveNominalComplementFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:UnclassifiedParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>unclassified particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#UnclassifiedParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#UnclassifiedParticle</seealso>
    let UnclassifiedParticle =
        Prefixed_Name(lexinfov3, "UnclassifiedParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:unclassifiedParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Particle that is not covered by other sorts of particle definitions.</para>
    /// labels<para>unclassified particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#unclassifiedParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#unclassifiedParticle</seealso>
    let unclassifiedParticle =
        Prefixed_Name(lexinfov3, "unclassifiedParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:VerbPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>darbības vārds</para><para>veiksmažodis</para><para>udsagnsord</para><para>czasownik</para><para>werkwoord</para><para>tegusõna</para><para>дзеяслоў</para><para>дієслово</para><para>briathar</para><para>sloveso</para><para>glagoli</para><para>sloveso</para><para>sagnorð</para><para>glagol</para><para>глагол</para><para>глагол</para><para>глагол</para><para>глагол</para><para>folje</para><para>verbi</para><para>verbo</para><para>verbe</para><para>aditz</para><para>verbo</para><para>verbo</para><para>verbo</para><para>verb</para><para>ρήμα</para><para>פועל</para><para>Verb</para><para>verb</para><para>Verb</para><para>verb</para><para>verb</para><para>verb</para><para>verb</para><para>verb</para><para>ige</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPOS</seealso>
    let VerbPOS = Prefixed_Name(lexinfov3, "VerbPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:VerbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>verb form mood</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFormMood">http://www.lexinfo.net/ontology/3.0/lexinfo#VerbFormMood</seealso>
    let VerbFormMood = Prefixed_Name(lexinfov3, "VerbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:VerbPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>verb phrase</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPhrase">http://www.lexinfo.net/ontology/3.0/lexinfo#VerbPhrase</seealso>
    let VerbPhrase = Prefixed_Name(lexinfov3, "VerbPhrase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>грамматический залог</para><para>Darbības vārda kārta</para><para>Glagolski način</para><para>veu gramatical</para><para>actief/passief</para><para>voz gramatical</para><para>slovesný rod</para><para>slovesný rod</para><para>מעמד דקדוקי</para><para>voz verbal</para><para>Sagnmyndir</para><para>Pääluokka</para><para>Tegumood</para><para>Diathese</para><para>diathèse</para><para>diatesi</para><para>diatese</para><para>Diateza</para><para>Diatese</para><para>diatese</para><para>Diateză</para><para>diates</para><para>strona</para><para>igenem</para><para>Залог</para><para>rūšis</para><para>Залог</para><para>voice</para><para>стан</para><para>Φωνή</para><para>voz</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Voice">http://www.lexinfo.net/ontology/3.0/lexinfo#Voice</seealso>
    let Voice = Prefixed_Name(lexinfov3, "Voice") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:WeakPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>weak personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#WeakPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#WeakPersonalPronoun</seealso>
    let WeakPersonalPronoun =
        Prefixed_Name(lexinfov3, "WeakPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:weakPersonalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Personal pronoun that cannot occupy the position after a preposition and/or reinforce a strong personal pronoun.</para>
    /// labels<para>weak personal pronoun</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#weakPersonalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#weakPersonalPronoun</seealso>
    let weakPersonalPronoun =
        Prefixed_Name(lexinfov3, "weakPersonalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ZeroMorph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A zero morph is a morph, consisting of no phonetic form, that is proposed in some analyses as an allomorph of a morpheme that is ordinarily realized by a morph having some phonetic form (as defined by the SIL Glossary of Linguistic Terms, https://glossary.sil.org/term/zero-morph). Examples include the English plural sheep along with the singular sheep.</para>
    /// labels<para>zero morph</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ZeroMorph">http://www.lexinfo.net/ontology/3.0/lexinfo#ZeroMorph</seealso>
    let ZeroMorph = Prefixed_Name(lexinfov3, "ZeroMorph") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:abbreviatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term or lexeme resulting from the omission of any part of the full term or lexeme while designating the same concept.</para>
    /// labels<para>abbreviated form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviatedForm">http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviatedForm</seealso>
    let abbreviatedForm = Prefixed_Name(lexinfov3, "abbreviatedForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:abbreviationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between an abbreviation and its full or expanded form.</para>
    /// labels<para>abbreviation for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviationFor">http://www.lexinfo.net/ontology/3.0/lexinfo#abbreviationFor</seealso>
    let abbreviationFor = Prefixed_Name(lexinfov3, "abbreviationFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:contractionFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The full form that corresponds to a contracted form.</para>
    /// labels<para>contraction for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#contractionFor">http://www.lexinfo.net/ontology/3.0/lexinfo#contractionFor</seealso>
    let contractionFor = Prefixed_Name(lexinfov3, "contractionFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:abessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case that expresses the lack or absence of the referent of the noun it marks.</para>
    /// labels<para>abessive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCase</seealso>
    let abessiveCase = Prefixed_Name(lexinfov3, "abessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:abessiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>abessive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#abessiveCaseForm</seealso>
    let abessiveCaseForm = Prefixed_Name(lexinfov3, "abessiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:formCaseVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>form case variant</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#formCaseVariant">http://www.lexinfo.net/ontology/3.0/lexinfo#formCaseVariant</seealso>
    let formCaseVariant = Prefixed_Name(lexinfov3, "formCaseVariant") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ablativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case used to typically indicate locative or instrumental function.</para>
    /// labels<para>ablative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCase</seealso>
    let ablativeCase = Prefixed_Name(lexinfov3, "ablativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ablativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>ablative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#ablativeCaseForm</seealso>
    let ablativeCaseForm = Prefixed_Name(lexinfov3, "ablativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:absolutiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case for nouns in ergative-absolute languages that would generally be the subjects of intransitive verbs or the objects of transitive verbs in the translational equivalents of nominative-accusative languages such as English.</para>
    /// labels<para>absolutive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCase</seealso>
    let absolutiveCase = Prefixed_Name(lexinfov3, "absolutiveCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:absolutiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>absolutive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#absolutiveCaseForm</seealso>
    let absolutiveCaseForm =
        Prefixed_Name(lexinfov3, "absolutiveCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:accusativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>accusative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#accusativeCaseForm</seealso>
    let accusativeCaseForm =
        Prefixed_Name(lexinfov3, "accusativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:acronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>lexinfov3:AbbreviatedForm</para>
    ///   <para>An abbreviation made up of the initial letters of the components of the full form of the designation or from syllables of the full form and pronounced syllabically.</para>
    /// labels<para>acronym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#acronym">http://www.lexinfo.net/ontology/3.0/lexinfo#acronym</seealso>
    let acronym = Prefixed_Name(lexinfov3, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:acronymFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between an acronym and its full or expanded form.</para>
    /// labels<para>acronym for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#acronymFor">http://www.lexinfo.net/ontology/3.0/lexinfo#acronymFor</seealso>
    let acronymFor = Prefixed_Name(lexinfov3, "acronymFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:activeVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Voice</para>
    ///   <para>owl:Thing</para>
    ///   <para>Value that expresses the situation where the grammatical subject is also the semantic actor of the verb.</para>
    /// labels<para>active voice</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#activeVoice">http://www.lexinfo.net/ontology/3.0/lexinfo#activeVoice</seealso>
    let activeVoice = Prefixed_Name(lexinfov3, "activeVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:adessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case which expresses the meaning of presence 'at' or 'near' a place.</para>
    /// labels<para>adessive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCase</seealso>
    let adessiveCase = Prefixed_Name(lexinfov3, "adessiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:adessiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>adessive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#adessiveCaseForm</seealso>
    let adessiveCaseForm = Prefixed_Name(lexinfov3, "adessiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:aditiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case expressing &amp;quot;to&amp;quot; in Basque studies.</para>
    /// labels<para>aditive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCase</seealso>
    let aditiveCase = Prefixed_Name(lexinfov3, "aditiveCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:aditiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>aditive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#aditiveCaseForm</seealso>
    let aditiveCaseForm = Prefixed_Name(lexinfov3, "aditiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:adjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Part of speech related to attributes of noun.</para>
    /// labels<para>bijvoeglijk naamwoord</para><para>прилагателно име</para><para>īpašības vārds</para><para>прилагательное</para><para>přídavné jméno</para><para>prídavné meno</para><para>lýsingarorð</para><para>przymiotnik</para><para>omadussõna</para><para>прикметник</para><para>tillægsord</para><para>adjektiivi</para><para>pridevnik</para><para>adjektibo</para><para>melléknév</para><para>aggettivo</para><para>прыметнік</para><para>adxectivo</para><para>būdvardis</para><para>adjective</para><para>pridjevi</para><para>adjetivo</para><para>adjektiv</para><para>aidiacht</para><para>adjektiv</para><para>Adjektiv</para><para>adjektiv</para><para>adjetivo</para><para>adjectiv</para><para>придавка</para><para>aġġettiv</para><para>adjectiu</para><para>adjectif</para><para>επίθετο</para><para>mbiemri</para><para>שם תואר</para><para>придев</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#adjective">http://www.lexinfo.net/ontology/3.0/lexinfo#adjective</seealso>
    let adjective = Prefixed_Name(lexinfov3, "adjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:nominativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>nominative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#nominativeCaseForm</seealso>
    let nominativeCaseForm =
        Prefixed_Name(lexinfov3, "nominativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:nonFinite</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Finiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>Property related for verb forms occurring on their own only in dependent clauses and lacking tense and mood contrasts.</para>
    /// labels<para>non finite</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#nonFinite">http://www.lexinfo.net/ontology/3.0/lexinfo#nonFinite</seealso>
    let nonFinite = Prefixed_Name(lexinfov3, "nonFinite") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:normativeAuthorization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.</para>
    /// labels<para>normative authorization</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#normativeAuthorization">http://www.lexinfo.net/ontology/3.0/lexinfo#normativeAuthorization</seealso>
    let normativeAuthorization =
        Prefixed_Name(lexinfov3, "normativeAuthorization") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:normativity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the use of a given lexical unit which is in some aspect considered to be non-standard or incorrect</para>
    /// labels<para>normativity</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#normativity">http://www.lexinfo.net/ontology/3.0/lexinfo#normativity</seealso>
    let normativity = Prefixed_Name(lexinfov3, "normativity") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A statement that provides further information on any part of a language resource entry.</para>
    /// labels<para>note</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#note">http://www.lexinfo.net/ontology/3.0/lexinfo#note</seealso>
    let note = Prefixed_Name(lexinfov3, "note") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:noun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Part of speech used to express the name of a person, place, action or thing.</para>
    /// labels<para>zelfstandig naamwoord</para><para>имя существительное</para><para>съществително име</para><para>podstatné jméno</para><para>podstatné meno</para><para>daiktavardis</para><para>substantiivi</para><para>substantivo</para><para>samostalnik</para><para>substantivo</para><para>substantiv</para><para>Substantiv</para><para>substantiv</para><para>sostantivo</para><para>sustantivo</para><para>substantiu</para><para>ainmfhocal</para><para>ουσιαστικό</para><para>Substantiv</para><para>substantiv</para><para>rzeczownik</para><para>substantiv</para><para>супстантив</para><para>lietvārds</para><para>nimisõna</para><para>назоўнік</para><para>imenice</para><para>іменник</para><para>nafnorð</para><para>שם עצם</para><para>именка</para><para>főnév</para><para>emër</para><para>izen</para><para>nume</para><para>noun</para><para>nom</para><para>nom</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#noun">http://www.lexinfo.net/ontology/3.0/lexinfo#noun</seealso>
    let noun = Prefixed_Name(lexinfov3, "noun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:nucleus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>The component of a multiword or multi-morphemic compound term that is determined or modified by the other components making up the term.</para>
    /// labels<para>nucleus</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#nucleus">http://www.lexinfo.net/ontology/3.0/lexinfo#nucleus</seealso>
    let nucleus = Prefixed_Name(lexinfov3, "nucleus") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to. // In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.</para>
    /// labels<para>proprietate morfosintactică a numărului</para><para>gramatiskais skaitlis</para><para>propiedade de número</para><para>proprietà di numero</para><para>Kieliopillinen luku</para><para>nombre grammatical</para><para>número gramatical</para><para>numero gramatikal</para><para>Slovnično število</para><para>skaičiaus požymis</para><para>numër gramatikor</para><para>rasgo de número</para><para>grammatisk tall</para><para>свойство числа</para><para>arvukategooria</para><para>numerus</para><para>numerus</para><para>Αριθμός</para><para>Numerus</para><para>number</para><para>liczba</para><para>nombre</para><para>число</para><para>číslo</para><para>getal</para><para>číslo</para><para>число</para><para>szám</para><para>tala</para><para>מספר</para><para>број</para><para>број</para><para>лік</para><para>tal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#number">http://www.lexinfo.net/ontology/3.0/lexinfo#number</seealso>
    let number = Prefixed_Name(lexinfov3, "number") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:numeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Part of speech that expresses a number or the relation to a number.</para>
    /// labels<para>имя числительное</para><para>числително име</para><para>skaitļa vārds</para><para>skaitvardis</para><para>zenbatzaile</para><para>αριθμητικό</para><para>liczebnik</para><para>numeraali</para><para>числівник</para><para>лічэбнік</para><para>číslovka</para><para>räkneord</para><para>telwoord</para><para>numerale</para><para>numerale</para><para>číslovka</para><para>Numerale</para><para>numeral</para><para>numeral</para><para>numeral</para><para>numeral</para><para>tallord</para><para>brojevi</para><para>нумерал</para><para>töluorð</para><para>Numeral</para><para>numéral</para><para>számnév</para><para>arvsõna</para><para>numeral</para><para>Numeral</para><para>števnik</para><para>talord</para><para>број</para><para>מספר</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#numeral">http://www.lexinfo.net/ontology/3.0/lexinfo#numeral</seealso>
    let numeral = Prefixed_Name(lexinfov3, "numeral") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:objectComplement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>object complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#objectComplement">http://www.lexinfo.net/ontology/3.0/lexinfo#objectComplement</seealso>
    let objectComplement = Prefixed_Name(lexinfov3, "objectComplement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:obliqueCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that is used when a noun is the object of a verb or a proposition, except for nominative and vocative case.</para>
    /// labels<para>oblique case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCase">http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCase</seealso>
    let obliqueCase = Prefixed_Name(lexinfov3, "obliqueCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:obliqueCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>oblique case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#obliqueCaseForm</seealso>
    let obliqueCaseForm = Prefixed_Name(lexinfov3, "obliqueCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:obsoleteForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TemporalQualifier</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term or lexeme which is no longer in common use.</para>
    /// labels<para>obsolete form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#obsoleteForm">http://www.lexinfo.net/ontology/3.0/lexinfo#obsoleteForm</seealso>
    let obsoleteForm = Prefixed_Name(lexinfov3, "obsoleteForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:old</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Dating</para>
    ///   <para>Used in the past.</para>
    /// labels<para>old</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#old">http://www.lexinfo.net/ontology/3.0/lexinfo#old</seealso>
    let old = Prefixed_Name(lexinfov3, "old") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:optionalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>1951: An optional part of a headword.
    /// 1951; examples? The question arises whether these are true options or whether the options reflect synonyms or hyponyms (e.g., barrage, barrage de retenue). The question is not whether 1951 should use this markup, but rather how to map this markup in a global environment.</para>
    /// labels<para>optional element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#optionalElement">http://www.lexinfo.net/ontology/3.0/lexinfo#optionalElement</seealso>
    let optionalElement = Prefixed_Name(lexinfov3, "optionalElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:otherAnimacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Animacy</para>
    ///   <para>Perceived as related to animacy, but without specific reference to the previous items.</para>
    /// labels<para>other animacy</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherAnimacy">http://www.lexinfo.net/ontology/3.0/lexinfo#otherAnimacy</seealso>
    let otherAnimacy = Prefixed_Name(lexinfov3, "otherAnimacy") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:otherGender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Gender</para>
    ///   <para>A grammatical category that indicates grammatical relationships between words in sentences.</para>
    /// labels<para>other gender</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#otherGender">http://www.lexinfo.net/ontology/3.0/lexinfo#otherGender</seealso>
    let otherGender = Prefixed_Name(lexinfov3, "otherGender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:usageNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A note containing information on the usage of the associated word or term.</para>
    /// labels<para>usage note</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#usageNote">http://www.lexinfo.net/ontology/3.0/lexinfo#usageNote</seealso>
    let usageNote = Prefixed_Name(lexinfov3, "usageNote") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Element which, singly or in combination with other verbs is used as the minimal predicate of a sentence, co-occurring with a subject. If the predicate contains other elements (e.g. object, complement), then it is the verb which more than any other is the unit which influences the choice and extent of these elements.</para>
    /// labels<para>darbības vārds</para><para>veiksmažodis</para><para>udsagnsord</para><para>werkwoord</para><para>czasownik</para><para>дзеяслоў</para><para>briathar</para><para>дієслово</para><para>tegusõna</para><para>sloveso</para><para>sloveso</para><para>glagoli</para><para>sagnorð</para><para>глагол</para><para>глагол</para><para>glagol</para><para>глагол</para><para>глагол</para><para>verbo</para><para>verbo</para><para>verbe</para><para>verbo</para><para>verbo</para><para>folje</para><para>verbi</para><para>aditz</para><para>Verb</para><para>verb</para><para>verb</para><para>verb</para><para>verb</para><para>verb</para><para>Verb</para><para>ρήμα</para><para>verb</para><para>פועל</para><para>verb</para><para>ige</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#verb">http://www.lexinfo.net/ontology/3.0/lexinfo#verb</seealso>
    let verb = Prefixed_Name(lexinfov3, "verb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:verbFormMood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.</para>
    /// labels<para>verb form mood</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#verbFormMood">http://www.lexinfo.net/ontology/3.0/lexinfo#verbFormMood</seealso>
    let verbFormMood = Prefixed_Name(lexinfov3, "verbFormMood") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:vocativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case used to indicate direct address.</para>
    /// labels<para>vocative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCase</seealso>
    let vocativeCase = Prefixed_Name(lexinfov3, "vocativeCase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:vocativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>vocative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#vocativeCaseForm</seealso>
    let vocativeCaseForm = Prefixed_Name(lexinfov3, "vocativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:voice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.</para>
    /// labels<para>Darbības vārda kārta</para><para>грамматический залог</para><para>Glagolski način</para><para>voz gramatical</para><para>actief/passief</para><para>veu gramatical</para><para>slovesný rod</para><para>slovesný rod</para><para>מעמד דקדוקי</para><para>Sagnmyndir</para><para>voz verbal</para><para>Pääluokka</para><para>Diathese</para><para>diathèse</para><para>Tegumood</para><para>diatese</para><para>Diateza</para><para>diatese</para><para>diatesi</para><para>Diatese</para><para>Diateză</para><para>diates</para><para>strona</para><para>igenem</para><para>Залог</para><para>rūšis</para><para>Залог</para><para>voice</para><para>стан</para><para>Φωνή</para><para>voz</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#voice">http://www.lexinfo.net/ontology/3.0/lexinfo#voice</seealso>
    let voice = Prefixed_Name(lexinfov3, "voice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:vulgarRegister</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Register</para>
    ///   <para>owl:Thing</para>
    ///   <para>Register of a term or text type that can be characterized as profane or socially unacceptable. // The register of a term or text type that can be characterized as profane or socially unacceptable.</para>
    /// labels<para>vulgar register</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#vulgarRegister">http://www.lexinfo.net/ontology/3.0/lexinfo#vulgarRegister</seealso>
    let vulgarRegister = Prefixed_Name(lexinfov3, "vulgarRegister") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:wordElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>Any lexeme element in a compound lexical unit that is itself a word.</para>
    /// labels<para>word element</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#wordElement">http://www.lexinfo.net/ontology/3.0/lexinfo#wordElement</seealso>
    let wordElement = Prefixed_Name(lexinfov3, "wordElement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:yes</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Cliticness</para>
    ///   <para>lexinfov3:Negative</para>
    ///   <para>owl:Thing</para>
    ///   <para>Positive value</para>
    /// labels<para>yes</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#yes">http://www.lexinfo.net/ontology/3.0/lexinfo#yes</seealso>
    let yes = Prefixed_Name(lexinfov3, "yes") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:GerundClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>gerund clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#GerundClause">http://www.lexinfo.net/ontology/3.0/lexinfo#GerundClause</seealso>
    let GerundClause = Prefixed_Name(lexinfov3, "GerundClause") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ObjectControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the object of the main clause is also the (omitted) object of the subclause</para>
    /// labels<para>object control</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectControl">http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectControl</seealso>
    let ObjectControl = Prefixed_Name(lexinfov3, "ObjectControl") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>determinatzaile bihurkari</para><para>determinante reflexivo</para><para>reflexive determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDeterminer</seealso>
    let ReflexiveDeterminer =
        Prefixed_Name(lexinfov3, "ReflexiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:morphosyntacticProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>morphosyntactic property</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#morphosyntacticProperty">http://www.lexinfo.net/ontology/3.0/lexinfo#morphosyntacticProperty</seealso>
    let morphosyntacticProperty =
        Prefixed_Name(lexinfov3, "morphosyntacticProperty") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:animate</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Animacy</para>
    ///   <para>owl:Thing</para>
    ///   <para>Perceived as alive.</para>
    /// labels<para>animate</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#animate">http://www.lexinfo.net/ontology/3.0/lexinfo#animate</seealso>
    let animate = Prefixed_Name(lexinfov3, "animate") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NumeralPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>имя числительное</para><para>числително име</para><para>skaitļa vārds</para><para>skaitvardis</para><para>zenbatzaile</para><para>αριθμητικό</para><para>числівник</para><para>liczebnik</para><para>numeraali</para><para>numerale</para><para>telwoord</para><para>numerale</para><para>Numerale</para><para>číslovka</para><para>räkneord</para><para>číslovka</para><para>лічэбнік</para><para>numeral</para><para>számnév</para><para>нумерал</para><para>numeral</para><para>arvsõna</para><para>brojevi</para><para>Numeral</para><para>töluorð</para><para>numeral</para><para>numeral</para><para>Numeral</para><para>numéral</para><para>tallord</para><para>numeral</para><para>števnik</para><para>talord</para><para>מספר</para><para>број</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralPOS</seealso>
    let NumeralPOS = Prefixed_Name(lexinfov3, "NumeralPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:NumeralFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>numeral fraction</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralFraction">http://www.lexinfo.net/ontology/3.0/lexinfo#NumeralFraction</seealso>
    let NumeralFraction = Prefixed_Name(lexinfov3, "NumeralFraction") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ObjectComplement</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>object complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectComplement">http://www.lexinfo.net/ontology/3.0/lexinfo#ObjectComplement</seealso>
    let ObjectComplement = Prefixed_Name(lexinfov3, "ObjectComplement") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:openParenthesis</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Beginning of a pair of parenthesis.</para>
    /// labels<para>open parenthesis</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#openParenthesis">http://www.lexinfo.net/ontology/3.0/lexinfo#openParenthesis</seealso>
    let openParenthesis = Prefixed_Name(lexinfov3, "openParenthesis") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:OrdinalAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ordinal adjective</para><para>adjektibo ordinal</para><para>adjetivo ordinal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#OrdinalAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#OrdinalAdjective</seealso>
    let OrdinalAdjective = Prefixed_Name(lexinfov3, "OrdinalAdjective") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ordinalAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adjective/numeral/number expressing a numeric ranking.</para>
    /// labels<para>adjektibo ordinal</para><para>ordinal adjective</para><para>adjetivo ordinal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ordinalAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#ordinalAdjective</seealso>
    let ordinalAdjective = Prefixed_Name(lexinfov3, "ordinalAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>partizipio-adjektibo</para><para>participle adjective</para><para>adjetivo participio</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ParticipleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#ParticipleAdjective</seealso>
    let ParticipleAdjective =
        Prefixed_Name(lexinfov3, "ParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:participleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Adjective based on a verb.</para>
    /// labels<para>partizipio-adjektibo</para><para>participle adjective</para><para>adjetivo participio</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#participleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#participleAdjective</seealso>
    let participleAdjective =
        Prefixed_Name(lexinfov3, "participleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ParticlePOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>grammaticaal partikel</para><para>partícula gramatical</para><para>particella</para><para>partikkeli</para><para>partícula</para><para>partícula</para><para>particulă</para><para>partícula</para><para>partikula</para><para>partykuła</para><para>partikkel</para><para>particule</para><para>partikula</para><para>partikula</para><para>partikel</para><para>Partikel</para><para>честичка</para><para>dalelytė</para><para>partikel</para><para>particle</para><para>частица</para><para>Часціца</para><para>častica</para><para>částice</para><para>частица</para><para>abisõna</para><para>Čestice</para><para>частка</para><para>Členek</para><para>מילית</para><para>μόριο</para><para>речца</para><para>mír</para><para>ögn</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ParticlePOS">http://www.lexinfo.net/ontology/3.0/lexinfo#ParticlePOS</seealso>
    let ParticlePOS = Prefixed_Name(lexinfov3, "ParticlePOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:PartitiveArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>partitive article</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PartitiveArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#PartitiveArticle</seealso>
    let PartitiveArticle = Prefixed_Name(lexinfov3, "PartitiveArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:partitiveArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Article expressing a part or quantity.</para>
    /// labels<para>partitive article</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveArticle</seealso>
    let partitiveArticle = Prefixed_Name(lexinfov3, "partitiveArticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PastParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>lehenaldiko partizipio-adjektibo</para><para>adjetivo de participio pasado</para><para>past participle adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PastParticipleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#PastParticipleAdjective</seealso>
    let PastParticipleAdjective =
        Prefixed_Name(lexinfov3, "PastParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjectlessTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>subjectless transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitiveFrame</seealso>
    let SubjectlessTransitiveFrame =
        Prefixed_Name(lexinfov3, "SubjectlessTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjectlessTransitivePPFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>subjectless transitive pp frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitivePPFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjectlessTransitivePPFrame</seealso>
    let SubjectlessTransitivePPFrame =
        Prefixed_Name(lexinfov3, "SubjectlessTransitivePPFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubjunctiveClause</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>subjunctive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubjunctiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#SubjunctiveClause</seealso>
    let SubjunctiveClause =
        Prefixed_Name(lexinfov3, "SubjunctiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SubordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>conjonction de subordination</para><para>konkunkzio subordinatzaile</para><para>subordinating conjunction</para><para>unterordnende Konjunktion</para><para>congiunzione subordinante</para><para>conjunção subordinativa</para><para>conjunción subordinante</para><para>betrekkelijk voegwoord</para><para>underordnende bindeord</para><para>подчинительный союз</para><para>Podraďovacia spojka</para><para>alistuskonjunktio</para><para>podřízená spojka</para><para>subjunksjon</para><para>subjunktion</para><para>subjunksjon</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SubordinatingConjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#SubordinatingConjunction</seealso>
    let SubordinatingConjunction =
        Prefixed_Name(lexinfov3, "SubordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:subordinatingConjunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Conjunction that links constructions by making one of them a constituent of another. The subordinating conjunction typically marks the incorporated constituent.</para>
    /// labels<para>conjonction de subordination</para><para>konkunkzio subordinatzaile</para><para>subordinating conjunction</para><para>unterordnende Konjunktion</para><para>congiunzione subordinante</para><para>conjunção subordinativa</para><para>conjunción subordinante</para><para>betrekkelijk voegwoord</para><para>underordnende bindeord</para><para>Podraďovacia spojka</para><para>подчинительный союз</para><para>alistuskonjunktio</para><para>podřízená spojka</para><para>subjunktion</para><para>subjunksjon</para><para>subjunksjon</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#subordinatingConjunction">http://www.lexinfo.net/ontology/3.0/lexinfo#subordinatingConjunction</seealso>
    let subordinatingConjunction =
        Prefixed_Name(lexinfov3, "subordinatingConjunction") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:Suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>suffix</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Suffix">http://www.lexinfo.net/ontology/3.0/lexinfo#Suffix</seealso>
    let Suffix = Prefixed_Name(lexinfov3, "Suffix") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SuperlativeAdjunct</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>superlative adjunct</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeAdjunct">http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeAdjunct</seealso>
    let SuperlativeAdjunct =
        Prefixed_Name(lexinfov3, "SuperlativeAdjunct") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SuperlativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>superlative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#SuperlativeParticle</seealso>
    let SuperlativeParticle =
        Prefixed_Name(lexinfov3, "SuperlativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:superlativeParticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Particle expressing superlative degree. Superlative is the comparison between more than two entities and contrasts with comparative where only two entities are involved and positive where no comparison is implied.</para>
    /// labels<para>superlative particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeParticle">http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeParticle</seealso>
    let superlativeParticle =
        Prefixed_Name(lexinfov3, "superlativeParticle") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:SuspensionPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Zënia e Hënës (Eklipsi)</para><para>points de suspension</para><para>punti di sospensione</para><para>Puncte de suspensie</para><para>Udeladelsesprikker</para><para>uteslutningstecken</para><para>puntos suspensivos</para><para>puntos suspensivos</para><para>suspension points</para><para>Auslassungspunkte</para><para>Три тачке (знак)</para><para>punts suspensius</para><para>Kolme pistettä</para><para>beletselteken</para><para>Αποσιωπητικά</para><para>Mõttepunktid</para><para>reticências</para><para>Daudzpunkte</para><para>Wielokropek</para><para>etenpuntuak</para><para>שלוש נקודות</para><para>Многоточие</para><para>три крапки</para><para>három pont</para><para>многоточие</para><para>Daugtaškis</para><para>Три точки</para><para>Tri bodky</para><para>výpustka</para><para>Focalbhá</para><para>Tripičje</para><para>Trotočje</para><para>ellipse</para><para>ellipse</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#SuspensionPoints">http://www.lexinfo.net/ontology/3.0/lexinfo#SuspensionPoints</seealso>
    let SuspensionPoints = Prefixed_Name(lexinfov3, "SuspensionPoints") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:suspensionPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Sequence of three dots having the same meaning as &amp;quot;et cetera&amp;quot; (full form) or &amp;quot;etc&amp;quot; (abbreviated form).</para>
    /// labels<para>Zënia e Hënës (Eklipsi)</para><para>punti di sospensione</para><para>points de suspension</para><para>Puncte de suspensie</para><para>puntos suspensivos</para><para>puntos suspensivos</para><para>Udeladelsesprikker</para><para>uteslutningstecken</para><para>Auslassungspunkte</para><para>suspension points</para><para>Три тачке (знак)</para><para>punts suspensius</para><para>Kolme pistettä</para><para>beletselteken</para><para>Αποσιωπητικά</para><para>Mõttepunktid</para><para>Daudzpunkte</para><para>reticências</para><para>etenpuntuak</para><para>Wielokropek</para><para>שלוש נקודות</para><para>многоточие</para><para>три крапки</para><para>Многоточие</para><para>Daugtaškis</para><para>három pont</para><para>Tri bodky</para><para>Три точки</para><para>Focalbhá</para><para>Tripičje</para><para>výpustka</para><para>Trotočje</para><para>ellipse</para><para>ellipse</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#suspensionPoints">http://www.lexinfo.net/ontology/3.0/lexinfo#suspensionPoints</seealso>
    let suspensionPoints = Prefixed_Name(lexinfov3, "suspensionPoints") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:future</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Tense</para>
    ///   <para>Verb tense that indicates action or state of being in the future.</para>
    /// labels<para>future</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#future">http://www.lexinfo.net/ontology/3.0/lexinfo#future</seealso>
    let future = Prefixed_Name(lexinfov3, "future") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:futureTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>future tense form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#futureTenseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#futureTenseForm</seealso>
    let futureTenseForm = Prefixed_Name(lexinfov3, "futureTenseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A grammatical category that indicates grammatical relationships between words in sentences.</para>
    /// labels<para>propiedade de xénero</para><para>proprietà di genere</para><para>rodzaj gramatyczny</para><para>gjinia gramatikore</para><para>genero gramatikal</para><para>género gramatical</para><para>genre grammatical</para><para>grammatisk kjønn</para><para>grammatisk kjønn</para><para>Γραμματικό γένος</para><para>rasgo de género</para><para>giminės požymis</para><para>gramatický rod</para><para>Граматычны род</para><para>slovnični spol</para><para>категория рода</para><para>Gramatički rod</para><para>kyneiginleiki</para><para>jmenný rod</para><para>מין דקדוקי</para><para>geslacht</para><para>gender</para><para>gènere</para><para>dzimte</para><para>Genus</para><para>Genus</para><para>genus</para><para>genus</para><para>sugu</para><para>suku</para><para>род</para><para>рід</para><para>nem</para><para>род</para><para>gen</para><para>Род</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#gender">http://www.lexinfo.net/ontology/3.0/lexinfo#gender</seealso>
    let gender = Prefixed_Name(lexinfov3, "gender") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:genitiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>genitive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#genitiveCaseForm</seealso>
    let genitiveCaseForm = Prefixed_Name(lexinfov3, "genitiveCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:geographic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the place or region where a lexical unit is mainly used</para>
    /// labels<para>geographic</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#geographic">http://www.lexinfo.net/ontology/3.0/lexinfo#geographic</seealso>
    let geographic = Prefixed_Name(lexinfov3, "geographic") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:referentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of concrete object or concept (the referent) that an expression represents (the reference).</para>
    /// labels<para>referent type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#referentType">http://www.lexinfo.net/ontology/3.0/lexinfo#referentType</seealso>
    let referentType = Prefixed_Name(lexinfov3, "referentType") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:reflexiveObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>reflexive object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveObject">http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveObject</seealso>
    let reflexiveObject = Prefixed_Name(lexinfov3, "reflexiveObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:register</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.</para>
    /// labels<para>registro lingüístico</para><para>Hizkuntza-erregistro</para><para>registo linguístico</para><para>registre de langue</para><para>Registru de limbă</para><para>языковой регистр</para><para>Sprachebene</para><para>regiszter</para><para>rekisteri</para><para>registras</para><para>rexistro</para><para>registre</para><para>register</para><para>registro</para><para>register</para><para>Register</para><para>регистар</para><para>stilleje</para><para>register</para><para>rejestr</para><para>málsnið</para><para>משלב</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#register">http://www.lexinfo.net/ontology/3.0/lexinfo#register</seealso>
    let register = Prefixed_Name(lexinfov3, "register") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:regulatedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>A term defined by law or government regulation.</para>
    /// labels<para>regulated term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#regulatedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#regulatedTerm</seealso>
    let regulatedTerm = Prefixed_Name(lexinfov3, "regulatedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:romanization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Transcription or transliteration from non-Latin script into Latin script.</para>
    /// labels<para>romanization</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#romanization">http://www.lexinfo.net/ontology/3.0/lexinfo#romanization</seealso>
    let romanization = Prefixed_Name(lexinfov3, "romanization") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:secondPersonForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>second person form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#secondPersonForm">http://www.lexinfo.net/ontology/3.0/lexinfo#secondPersonForm</seealso>
    let secondPersonForm = Prefixed_Name(lexinfov3, "secondPersonForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:segmentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specification of the pointers in time or sequence that indicates the segmentation process.</para>
    /// labels<para>segmentation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#segmentation">http://www.lexinfo.net/ontology/3.0/lexinfo#segmentation</seealso>
    let segmentation = Prefixed_Name(lexinfov3, "segmentation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:senseExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptive material that provides a sample of an object or entity defined in the entry.</para>
    /// labels<para>sense example</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#senseExample">http://www.lexinfo.net/ontology/3.0/lexinfo#senseExample</seealso>
    let senseExample = Prefixed_Name(lexinfov3, "senseExample") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:senseTranslation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A label for this sense in another language</para>
    /// labels<para>sense translation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#senseTranslation">http://www.lexinfo.net/ontology/3.0/lexinfo#senseTranslation</seealso>
    let senseTranslation = Prefixed_Name(lexinfov3, "senseTranslation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:setPhrase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A fixed, lexicalized phrase.</para>
    /// labels<para>set phrase</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#setPhrase">http://www.lexinfo.net/ontology/3.0/lexinfo#setPhrase</seealso>
    let setPhrase = Prefixed_Name(lexinfov3, "setPhrase") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:shortArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Definiteness</para>
    ///   <para>owl:Thing</para>
    ///   <para>For definiteness, when a specific form is not the syntactic subject of the clause.</para>
    /// labels<para>short article</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortArticle">http://www.lexinfo.net/ontology/3.0/lexinfo#shortArticle</seealso>
    let shortArticle = Prefixed_Name(lexinfov3, "shortArticle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:shortForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A variant of a multiword term or lexeme that includes fewer words than the full form.</para>
    /// labels<para>short form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortForm">http://www.lexinfo.net/ontology/3.0/lexinfo#shortForm</seealso>
    let shortForm = Prefixed_Name(lexinfov3, "shortForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:shortFormFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A linking element used to identify a relation between a short form and its full or expanded form.</para>
    /// labels<para>short form for</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#shortFormFor">http://www.lexinfo.net/ontology/3.0/lexinfo#shortFormFor</seealso>
    let shortFormFor = Prefixed_Name(lexinfov3, "shortFormFor") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:sociativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Case</para>
    ///   <para>owl:Thing</para>
    ///   <para>Case related to the person in whose company the action is carried out, or to any belongings of people which take part in the action.</para>
    /// labels<para>sociative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCase</seealso>
    let sociativeCase = Prefixed_Name(lexinfov3, "sociativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:sociativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sociative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#sociativeCaseForm</seealso>
    let sociativeCaseForm =
        Prefixed_Name(lexinfov3, "sociativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:socioCultural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>usage marker which identifies the use of a given lexical unit by particular social groups and/or in certain types of communicative situations depending on their level of formality</para>
    /// labels<para>socio cultural</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#socioCultural">http://www.lexinfo.net/ontology/3.0/lexinfo#socioCultural</seealso>
    let socioCultural = Prefixed_Name(lexinfov3, "socioCultural") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:standardText</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A fixed chunk of recurring text.</para>
    /// labels<para>standard text</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#standardText">http://www.lexinfo.net/ontology/3.0/lexinfo#standardText</seealso>
    let standardText = Prefixed_Name(lexinfov3, "standardText") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:standardizedTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>A term that has been standardized by a standardizing body.</para>
    /// labels<para>standardized term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#standardizedTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#standardizedTerm</seealso>
    let standardizedTerm = Prefixed_Name(lexinfov3, "standardizedTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>owl:Thing</para>
    ///   <para>A chunk of text used in a software interface, documentation, help file, or the like.</para>
    /// labels<para>string</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#string">http://www.lexinfo.net/ontology/3.0/lexinfo#string</seealso>
    let string = Prefixed_Name(lexinfov3, "string") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:stringCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A type value assigned to a string.</para>
    /// labels<para>string category</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#stringCategory">http://www.lexinfo.net/ontology/3.0/lexinfo#stringCategory</seealso>
    let stringCategory = Prefixed_Name(lexinfov3, "stringCategory") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:subjunctiveClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subjunctive clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveClause">http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveClause</seealso>
    let subjunctiveClause =
        Prefixed_Name(lexinfov3, "subjunctiveClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:subjunctiveMoodForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>subjunctive mood form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveMoodForm">http://www.lexinfo.net/ontology/3.0/lexinfo#subjunctiveMoodForm</seealso>
    let subjunctiveMoodForm =
        Prefixed_Name(lexinfov3, "subjunctiveMoodForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:sublativeCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case for a move of something to the surface of another object.</para>
    /// labels<para>sublative case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCase">http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCase</seealso>
    let sublativeCase = Prefixed_Name(lexinfov3, "sublativeCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:sublativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sublative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#sublativeCaseForm</seealso>
    let sublativeCaseForm =
        Prefixed_Name(lexinfov3, "sublativeCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:substanceHolonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates what this is composed of</para>
    /// labels<para>substance holonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#substanceHolonym">http://www.lexinfo.net/ontology/3.0/lexinfo#substanceHolonym</seealso>
    let substanceHolonym = Prefixed_Name(lexinfov3, "substanceHolonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:substanceMeronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Indicates this is a substance that composes the other</para>
    /// labels<para>substance meronym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#substanceMeronym">http://www.lexinfo.net/ontology/3.0/lexinfo#substanceMeronym</seealso>
    let substanceMeronym = Prefixed_Name(lexinfov3, "substanceMeronym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>prapashtesa</para><para>przyrostek</para><para>piedēklis</para><para>Viðskeyti</para><para>suffisso</para><para>наставка</para><para>Наставка</para><para>suffiksi</para><para>Priesaga</para><para>Iarmhír</para><para>suffixe</para><para>atzizki</para><para>suffiss</para><para>Pripona</para><para>suffiks</para><para>суффикс</para><para>suffiks</para><para>επίθημα</para><para>prípona</para><para>suffiks</para><para>Sufixo</para><para>suffix</para><para>Sufiks</para><para>sufijo</para><para>suffix</para><para>суфікс</para><para>суфікс</para><para>Suffix</para><para>sufixo</para><para>suffix</para><para>суфикс</para><para>sufiks</para><para>sufix</para><para>sufix</para><para>סיומת</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#suffix">http://www.lexinfo.net/ontology/3.0/lexinfo#suffix</seealso>
    let suffix = Prefixed_Name(lexinfov3, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:superessiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case indicating location on top of something or on the surface of something.</para>
    /// labels<para>superessive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCase</seealso>
    let superessiveCase = Prefixed_Name(lexinfov3, "superessiveCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:superessiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>superessive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#superessiveCaseForm</seealso>
    let superessiveCaseForm =
        Prefixed_Name(lexinfov3, "superessiveCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:superlative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Degree</para>
    ///   <para>Value used in a comparison between more than two entities.</para>
    /// labels<para>superlative</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlative">http://www.lexinfo.net/ontology/3.0/lexinfo#superlative</seealso>
    let superlative = Prefixed_Name(lexinfov3, "superlative") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:superlativeDegreeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>superlative degree form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeDegreeForm">http://www.lexinfo.net/ontology/3.0/lexinfo#superlativeDegreeForm</seealso>
    let superlativeDegreeForm =
        Prefixed_Name(lexinfov3, "superlativeDegreeForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:supersededTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:NormativeAuthorization</para>
    ///   <para>A term that is no longer preferred or admitted.</para>
    /// labels<para>superseded term</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#supersededTerm">http://www.lexinfo.net/ontology/3.0/lexinfo#supersededTerm</seealso>
    let supersededTerm = Prefixed_Name(lexinfov3, "supersededTerm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:syllable</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TermElement</para>
    ///   <para>owl:Thing</para>
    ///   <para>A unit of spoken language that is next bigger than a speech sound and consists of one or more vowel sounds alone or of a syllabic consonant alone or of either with one or more consonant sounds preceding or following.</para>
    /// labels<para>syllable</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#syllable">http://www.lexinfo.net/ontology/3.0/lexinfo#syllable</seealso>
    let syllable = Prefixed_Name(lexinfov3, "syllable") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:symbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A character or glyph representing an idea, concept or object</para>
    /// labels<para>szimbólum</para><para>Simbolis</para><para>siombail</para><para>symboli</para><para>σύμβολο</para><para>simbolo</para><para>símbolo</para><para>simbols</para><para>símbolo</para><para>symbool</para><para>Simboli</para><para>símbolo</para><para>symbole</para><para>Символ</para><para>symbol</para><para>сімвал</para><para>symbol</para><para>sümbol</para><para>symbol</para><para>symbol</para><para>symbol</para><para>симбол</para><para>символ</para><para>symbol</para><para>Simbol</para><para>symbol</para><para>Simbol</para><para>simbol</para><para>символ</para><para>símbol</para><para>симбол</para><para>symbol</para><para>Symbol</para><para>Tákn</para><para>ikur</para><para>סמל</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#symbol">http://www.lexinfo.net/ontology/3.0/lexinfo#symbol</seealso>
    let symbol = Prefixed_Name(lexinfov3, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:allativeCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allative case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#allativeCaseForm</seealso>
    let allativeCaseForm = Prefixed_Name(lexinfov3, "allativeCaseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:outdatedForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TemporalQualifier</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term or lexeme that has fallen from fashion, but the meaning of which is readily recognizable.</para>
    /// labels<para>outdated form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#outdatedForm">http://www.lexinfo.net/ontology/3.0/lexinfo#outdatedForm</seealso>
    let outdatedForm = Prefixed_Name(lexinfov3, "outdatedForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:AdjectiveAttributiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>adjective attributive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAttributiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#AdjectiveAttributiveFrame</seealso>
    let AdjectiveAttributiveFrame =
        Prefixed_Name(lexinfov3, "AdjectiveAttributiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:DitransitiveDoubleAccusativeFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ditransitive double accusative frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveDoubleAccusativeFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#DitransitiveDoubleAccusativeFrame</seealso>
    let DitransitiveDoubleAccusativeFrame =
        Prefixed_Name(lexinfov3, "DitransitiveDoubleAccusativeFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:prepositionalInterrogativeClause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>prepositional interrogative clause</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalInterrogativeClause">http://www.lexinfo.net/ontology/3.0/lexinfo#prepositionalInterrogativeClause</seealso>
    let prepositionalInterrogativeClause =
        Prefixed_Name(lexinfov3, "prepositionalInterrogativeClause") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalObject</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>prepositional object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalObject">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalObject</seealso>
    let PrepositionalObject =
        Prefixed_Name(lexinfov3, "PrepositionalObject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:PrepositionalPhraseFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prepositional phrase frame</para><para>preposizio-sintagma marko</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalPhraseFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#PrepositionalPhraseFrame</seealso>
    let PrepositionalPhraseFrame =
        Prefixed_Name(lexinfov3, "PrepositionalPhraseFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:complement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early</para>
    /// labels<para>complement</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#complement">http://www.lexinfo.net/ontology/3.0/lexinfo#complement</seealso>
    let complement = Prefixed_Name(lexinfov3, "complement") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:presentParticipleAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Adjective based on a present participle.</para>
    /// labels<para>orainaldiko partizipio-adjektibo</para><para>adjetivo de participio presente</para><para>present participle adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#presentParticipleAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#presentParticipleAdjective</seealso>
    let presentParticipleAdjective =
        Prefixed_Name(lexinfov3, "presentParticipleAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:pronominalAdverb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>adverb formed in replacement of a preposition and a pronoun</para>
    /// labels<para>voornaamwoordelijk bijwoord</para><para>местоименное наречие</para><para>adverbio pronominal</para><para>pronominaladverbium</para><para>izenordain-adberbio</para><para>adverbe pronominal</para><para>pronominal adverb</para><para>Pronominaladverb</para><para>pronominaladverb</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pronominalAdverb">http://www.lexinfo.net/ontology/3.0/lexinfo#pronominalAdverb</seealso>
    let pronominalAdverb = Prefixed_Name(lexinfov3, "pronominalAdverb") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:PronounPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>įvardinis, įvardžiuotinis</para><para>vietniekvārds</para><para>voornaamwoord</para><para>местоимённый</para><para>asesõnaline</para><para>pronominale</para><para>местоимение</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>pronominal</para><para>izenordain</para><para>pronominal</para><para>займенник</para><para>αντωνυμία</para><para>pronomini</para><para>כינוי גוף</para><para>займеннік</para><para>zamjenice</para><para>pronomen</para><para>zaimkowy</para><para>pronomen</para><para>Pronomen</para><para>pronomen</para><para>заменица</para><para>pronoun</para><para>fornafn</para><para>zájmeno</para><para>pronome</para><para>përemër</para><para>заменка</para><para>forainm</para><para>zaimek</para><para>névmás</para><para>pronom</para><para>pronom</para><para>zámeno</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#PronounPOS">http://www.lexinfo.net/ontology/3.0/lexinfo#PronounPOS</seealso>
    let PronounPOS = Prefixed_Name(lexinfov3, "PronounPOS") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:ProperNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>vlastné podstatné meno</para><para>tikrinis daiktavardis</para><para>substantivo próprio</para><para>rzeczownik własny</para><para>властита именица</para><para>ainmfhocal dílis</para><para>имя собственное</para><para>vlastní jméno</para><para>nombre propio</para><para>nome proprio</para><para>лична именка</para><para>власна назва</para><para>nume propriu</para><para>nome propio</para><para>שם עצם פרטי</para><para>уласнае імя</para><para>κύριο όνομα</para><para>izen propio</para><para>proper noun</para><para>tulajdonnév</para><para>Lastno ime</para><para>nom propju</para><para>nom propre</para><para>Eigenname</para><para>pärisnimi</para><para>nom propi</para><para>eigennaam</para><para>īpašvārds</para><para>egennamn</para><para>erisnimi</para><para>proprium</para><para>egennavn</para><para>sérnafn</para><para>særnamn</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ProperNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ProperNoun</seealso>
    let ProperNoun = Prefixed_Name(lexinfov3, "ProperNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:properNoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>A noun or adjective denoting a single object. // Noun that is the name of a specific individual, place, or object.</para>
    /// labels<para>vlastné podstatné meno</para><para>tikrinis daiktavardis</para><para>substantivo próprio</para><para>rzeczownik własny</para><para>ainmfhocal dílis</para><para>властита именица</para><para>имя собственное</para><para>vlastní jméno</para><para>nombre propio</para><para>nume propriu</para><para>nome proprio</para><para>лична именка</para><para>власна назва</para><para>κύριο όνομα</para><para>tulajdonnév</para><para>שם עצם פרטי</para><para>izen propio</para><para>nome propio</para><para>proper noun</para><para>уласнае імя</para><para>nom propju</para><para>nom propre</para><para>Lastno ime</para><para>īpašvārds</para><para>eigennaam</para><para>pärisnimi</para><para>Eigenname</para><para>nom propi</para><para>egennavn</para><para>erisnimi</para><para>egennamn</para><para>proprium</para><para>særnamn</para><para>sérnafn</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#properNoun">http://www.lexinfo.net/ontology/3.0/lexinfo#properNoun</seealso>
    let properNoun = Prefixed_Name(lexinfov3, "properNoun") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:Punctuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Interpunktsioon</para><para>Zeichensetzung</para><para>Σημείο στίξης</para><para>интерпункција</para><para>interpunktion</para><para>interpunkcija</para><para>интерпункција</para><para>punteggiatura</para><para>teiknsetjing</para><para>interpunctie</para><para>välimerkkejä</para><para>interpunkcia</para><para>interpunkcja</para><para>tegnsætning</para><para>tegnsetting</para><para>interpunkce</para><para>ponctuation</para><para>punctuation</para><para>puntuación</para><para>puntuación</para><para>пунктуация</para><para>geнктуацыя</para><para>пунктуація</para><para>punctuație</para><para>poncaíocht</para><para>пунктуация</para><para>puntuació</para><para>puntuazio</para><para>pontuação</para><para>razgodak</para><para>skyryba</para><para>ločilo</para><para>פיסוק</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#Punctuation">http://www.lexinfo.net/ontology/3.0/lexinfo#Punctuation</seealso>
    let Punctuation = Prefixed_Name(lexinfov3, "Punctuation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:punctuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Graphical mark used either at word level to indicate an abbreviation or at a text level to separate phrases or sentences.</para>
    /// labels<para>Interpunktsioon</para><para>Zeichensetzung</para><para>Σημείο στίξης</para><para>интерпункција</para><para>interpunktion</para><para>punteggiatura</para><para>interpunkcija</para><para>интерпункција</para><para>interpunkcja</para><para>teiknsetjing</para><para>välimerkkejä</para><para>interpunctie</para><para>interpunkcia</para><para>tegnsetting</para><para>interpunkce</para><para>ponctuation</para><para>tegnsætning</para><para>punctuation</para><para>пунктуация</para><para>пунктуація</para><para>poncaíocht</para><para>puntuación</para><para>пунктуация</para><para>puntuación</para><para>geнктуацыя</para><para>punctuație</para><para>pontuação</para><para>puntuazio</para><para>puntuació</para><para>razgodak</para><para>skyryba</para><para>ločilo</para><para>פיסוק</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#punctuation">http://www.lexinfo.net/ontology/3.0/lexinfo#punctuation</seealso>
    let punctuation = Prefixed_Name(lexinfov3, "punctuation") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:QualifierAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>qualifier adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#QualifierAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#QualifierAdjective</seealso>
    let QualifierAdjective =
        Prefixed_Name(lexinfov3, "QualifierAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:qualifierAdjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Adjective used to qualify.</para>
    /// labels<para>qualifier adjective</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#qualifierAdjective">http://www.lexinfo.net/ontology/3.0/lexinfo#qualifierAdjective</seealso>
    let qualifierAdjective =
        Prefixed_Name(lexinfov3, "qualifierAdjective") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:QuestionMark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>signo de interrogación</para><para>signo de interrogación</para><para>point d'interrogation</para><para>ponto de interrogação</para><para>signe d'interrogació</para><para>punto interrogativo</para><para>вопросительный знак</para><para>Semnul întrebării</para><para>Въпросителен знак</para><para>Comhartha ceiste</para><para>Spurningarmerki</para><para>spørsmålsteikn</para><para>Jautājuma zīme</para><para>Znak zapytania</para><para>spørgsmålstegn</para><para>Kysymysmerkki</para><para>question mark</para><para>galdera-marka</para><para>Spørsmålstegn</para><para>Fragezeichen</para><para>Знак питання</para><para>frågetecken</para><para>Знак питања</para><para>ερωτηματικό</para><para>Klaustukas</para><para>vraagteken</para><para>Прашалник</para><para>Пытальнік</para><para>סימן שאלה</para><para>Küsimärk</para><para>kérdőjel</para><para>Vprašaj</para><para>Upitnik</para><para>otazník</para><para>Otáznik</para><para>?</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#QuestionMark">http://www.lexinfo.net/ontology/3.0/lexinfo#QuestionMark</seealso>
    let QuestionMark = Prefixed_Name(lexinfov3, "QuestionMark") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:questionMark</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Sign used to express a question.</para>
    /// labels<para>signo de interrogación</para><para>signo de interrogación</para><para>point d'interrogation</para><para>ponto de interrogação</para><para>signe d'interrogació</para><para>вопросительный знак</para><para>punto interrogativo</para><para>Въпросителен знак</para><para>Semnul întrebării</para><para>Comhartha ceiste</para><para>Spurningarmerki</para><para>spørgsmålstegn</para><para>Znak zapytania</para><para>Jautājuma zīme</para><para>spørsmålsteikn</para><para>Kysymysmerkki</para><para>question mark</para><para>galdera-marka</para><para>Spørsmålstegn</para><para>Знак питання</para><para>Fragezeichen</para><para>frågetecken</para><para>Знак питања</para><para>ερωτηματικό</para><para>Klaustukas</para><para>vraagteken</para><para>סימן שאלה</para><para>Прашалник</para><para>Пытальнік</para><para>kérdőjel</para><para>Küsimärk</para><para>Otáznik</para><para>otazník</para><para>Upitnik</para><para>Vprašaj</para><para>?</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#questionMark">http://www.lexinfo.net/ontology/3.0/lexinfo#questionMark</seealso>
    let questionMark = Prefixed_Name(lexinfov3, "questionMark") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:RaisableArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableArgument">http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableArgument</seealso>
    let RaisableArgument = Prefixed_Name(lexinfov3, "RaisableArgument") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:RaisableSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableSubject">http://www.lexinfo.net/ontology/3.0/lexinfo#RaisableSubject</seealso>
    let RaisableSubject = Prefixed_Name(lexinfov3, "RaisableSubject") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReciprocalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>wederkerig voornaamwoord</para><para>αλληλοπαθής αντωνυμία</para><para>gagnverkandi fornafn</para><para>reciprokinis įvardis</para><para>vastastikune asesõna</para><para>взаимное местоимение</para><para>izenordain elkarkari</para><para>реципрочна заменица</para><para>pronombre recíproco</para><para>reciprocal pronoun</para><para>reciprokt pronomen</para><para>Взаємні займенники</para><para>resiprokt pronomen</para><para>pronome reciproco</para><para>pronome recíproco</para><para>kölcsönös névmás</para><para>Reziprokpronomen</para><para>pronom recíproc</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#ReciprocalPronoun</seealso>
    let ReciprocalPronoun =
        Prefixed_Name(lexinfov3, "ReciprocalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:reciprocalPronoun</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Pronoun expressing mutual relationship.</para>
    /// labels<para>wederkerig voornaamwoord</para><para>αλληλοπαθής αντωνυμία</para><para>izenordain elkarkari</para><para>reciprokinis įvardis</para><para>взаимное местоимение</para><para>vastastikune asesõna</para><para>gagnverkandi fornafn</para><para>pronombre recíproco</para><para>реципрочна заменица</para><para>reciprocal pronoun</para><para>reciprokt pronomen</para><para>resiprokt pronomen</para><para>Взаємні займенники</para><para>pronome reciproco</para><para>pronome recíproco</para><para>kölcsönös névmás</para><para>Reziprokpronomen</para><para>pronom recíproc</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#reciprocalPronoun">http://www.lexinfo.net/ontology/3.0/lexinfo#reciprocalPronoun</seealso>
    let reciprocalPronoun =
        Prefixed_Name(lexinfov3, "reciprocalPronoun") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReferentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>referent type</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReferentType">http://www.lexinfo.net/ontology/3.0/lexinfo#ReferentType</seealso>
    let ReferentType = Prefixed_Name(lexinfov3, "ReferentType") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveDativeTransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive dative transitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDativeTransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDativeTransitiveFrame</seealso>
    let ReflexiveDativeTransitiveFrame =
        Prefixed_Name(lexinfov3, "ReflexiveDativeTransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveFrame</seealso>
    let ReflexiveFrame = Prefixed_Name(lexinfov3, "ReflexiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:reflexiveDeterminer</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Determiner that refers to the same entity.</para>
    /// labels<para>determinatzaile bihurkari</para><para>determinante reflexivo</para><para>reflexive determiner</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveDeterminer">http://www.lexinfo.net/ontology/3.0/lexinfo#reflexiveDeterminer</seealso>
    let reflexiveDeterminer =
        Prefixed_Name(lexinfov3, "reflexiveDeterminer") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveDitransitiveFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>reflexive ditransitive frame</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDitransitiveFrame">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveDitransitiveFrame</seealso>
    let ReflexiveDitransitiveFrame =
        Prefixed_Name(lexinfov3, "ReflexiveDitransitiveFrame") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:ReflexiveObject</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>reflexive object</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveObject">http://www.lexinfo.net/ontology/3.0/lexinfo#ReflexiveObject</seealso>
    let ReflexiveObject = Prefixed_Name(lexinfov3, "ReflexiveObject") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:antonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.</para>
    /// labels<para>antonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#antonym">http://www.lexinfo.net/ontology/3.0/lexinfo#antonym</seealso>
    let antonym = Prefixed_Name(lexinfov3, "antonym") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:appellation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:TermType</para>
    ///   <para>A designation that represents an individual concept.</para>
    /// labels<para>appellation</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#appellation">http://www.lexinfo.net/ontology/3.0/lexinfo#appellation</seealso>
    let appellation = Prefixed_Name(lexinfov3, "appellation") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:approximate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Property used to qualify something similar but not exactly the same</para>
    /// labels<para>approximate</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#approximate">http://www.lexinfo.net/ontology/3.0/lexinfo#approximate</seealso>
    let approximate = Prefixed_Name(lexinfov3, "approximate") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:approximateSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A synonym that differs in some minor way</para>
    /// labels<para>approximate synonym</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#approximateSynonym">http://www.lexinfo.net/ontology/3.0/lexinfo#approximateSynonym</seealso>
    let approximateSynonym =
        Prefixed_Name(lexinfov3, "approximateSynonym") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:archaicForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:TemporalQualifier</para>
    ///   <para>owl:Thing</para>
    ///   <para>A term or lexeme no longer in ordinary use, though retained for special purposes.</para>
    /// labels<para>archaic form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#archaicForm">http://www.lexinfo.net/ontology/3.0/lexinfo#archaicForm</seealso>
    let archaicForm = Prefixed_Name(lexinfov3, "archaicForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:article</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>owl:Thing</para>
    ///   <para>Term used in the grammatical classification of words referring to a subclass of determiners which displays a primary role in differentiating the uses of nouns.</para>
    /// labels<para>граматички члан</para><para>artikkeli</para><para>artikelis</para><para>przedimek</para><para>членуване</para><para>lidwoord</para><para>articolo</para><para>artículo</para><para>kendeord</para><para>artikkel</para><para>artikulu</para><para>artikkel</para><para>artikuls</para><para>article</para><para>артикль</para><para>article</para><para>Artikel</para><para>Artikel</para><para>artiklu</para><para>articol</para><para>артикль</para><para>article</para><para>артыкль</para><para>artikel</para><para>greinir</para><para>artigo</para><para>artigo</para><para>névelő</para><para>trajta</para><para>תווית</para><para>άρθρο</para><para>член</para><para>član</para><para>člen</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#article">http://www.lexinfo.net/ontology/3.0/lexinfo#article</seealso>
    let article = Prefixed_Name(lexinfov3, "article") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.</para>
    /// labels<para>aspecto gramatical</para><para>aspecto gramatical</para><para>aspecte gramatical</para><para>Ποιόν ενέργειας</para><para>Вид на глагола</para><para>глаголски вид</para><para>Glagolski vid</para><para>Slovesný vid</para><para>slovesný vid</para><para>igeszemlélet</para><para>вид глагола</para><para>veikslas</para><para>aspekti</para><para>aspecto</para><para>aspetto</para><para>aspect</para><para>Aspect</para><para>aspekt</para><para>aspekt</para><para>aspect</para><para>aspekt</para><para>aspekt</para><para>Aspekt</para><para>Aspekt</para><para>aspect</para><para>אספקט</para><para>вид</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#aspect">http://www.lexinfo.net/ontology/3.0/lexinfo#aspect</seealso>
    let aspect = Prefixed_Name(lexinfov3, "aspect") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:particle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:PartOfSpeech</para>
    ///   <para>Word that does not belong to one of the main classes of words, is invariable in form, and typically has grammatical or pragmatic meaning.</para>
    /// labels<para>particle</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#particle">http://www.lexinfo.net/ontology/3.0/lexinfo#particle</seealso>
    let particle = Prefixed_Name(lexinfov3, "particle") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:partitiveCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>lexinfov3:Case</para>
    ///   <para>Case that expresses the partial nature of the referent of the noun it marks, as opposed to expressing the whole unit or class of which the referent is a part.</para>
    /// labels<para>partitive case</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCase">http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCase</seealso>
    let partitiveCase = Prefixed_Name(lexinfov3, "partitiveCase") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:partitiveCaseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>partitive case form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCaseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#partitiveCaseForm</seealso>
    let partitiveCaseForm =
        Prefixed_Name(lexinfov3, "partitiveCaseForm") |> PrefixedName

    /// <summary>
    ///   <para>lexinfov3:passiveVoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Voice</para>
    ///   <para>owl:Thing</para>
    ///   <para>Term referring to a situation where the grammatical subject is typically the recipient or goal of the action denoted by the verb.</para>
    /// labels<para>passive voice</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#passiveVoice">http://www.lexinfo.net/ontology/3.0/lexinfo#passiveVoice</seealso>
    let passiveVoice = Prefixed_Name(lexinfov3, "passiveVoice") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:past</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Tense</para>
    ///   <para>owl:Thing</para>
    ///   <para>Past tense is an absolute tense that refers to a time before the moment of utterance.</para>
    /// labels<para>past</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#past">http://www.lexinfo.net/ontology/3.0/lexinfo#past</seealso>
    let past = Prefixed_Name(lexinfov3, "past") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:pastTenseForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>past tense form</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#pastTenseForm">http://www.lexinfo.net/ontology/3.0/lexinfo#pastTenseForm</seealso>
    let pastTenseForm = Prefixed_Name(lexinfov3, "pastTenseForm") |> PrefixedName
    /// <summary>
    ///   <para>lexinfov3:paucal</para>
    /// </summary>
    /// <remarks>
    ///   <para>lexinfov3:Number</para>
    ///   <para>owl:Thing</para>
    ///   <para>Number that specifies 'a few' things.</para>
    /// labels<para>paucal</para></remarks>
    /// <seealso href="http://www.lexinfo.net/ontology/3.0/lexinfo#paucal">http://www.lexinfo.net/ontology/3.0/lexinfo#paucal</seealso>
    let paucal = Prefixed_Name(lexinfov3, "paucal") |> PrefixedName

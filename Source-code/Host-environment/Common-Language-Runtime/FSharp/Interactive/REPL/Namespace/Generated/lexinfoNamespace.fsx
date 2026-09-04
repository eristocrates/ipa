#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lexinfo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.lexinfo.net/ontology/2.0/lexinfo#" "lexinfo"

    /// <summary>
    ///   <para>rdfs:label : Сокращенная форма</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AbbreviatedForm">lexinfo:AbbreviatedForm</a>
    /// </summary>
    let AbbreviatedForm = _prefixId.prefix "AbbreviatedForm"

    let AccusativePostPositiveArgument =
        _prefixId.prefix "AccusativePostPositiveArgument"

    let AdjectivalComplementFrame = _prefixId.prefix "AdjectivalComplementFrame"
    /// <summary>
    ///   <para>rdfs:label : Прилагательное</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adjective">lexinfo:Adjective</a>
    /// </summary>
    let Adjective = _prefixId.prefix "Adjective"

    /// <summary>
    ///   <para>lexinfo:example : wird wurden unseren irrtum GEWAHR</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAccusativePostPositiveFrame">lexinfo:AdjectiveAccusativePostPositiveFrame</a>
    /// </summary>
    let AdjectiveAccusativePostPositiveFrame =
        _prefixId.prefix "AdjectiveAccusativePostPositiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : the RED ball</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveAttributiveFrame">lexinfo:AdjectiveAttributiveFrame</a>
    /// </summary>
    let AdjectiveAttributiveFrame = _prefixId.prefix "AdjectiveAttributiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : new york is BIGGER THAN berlin</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveComparativeFrame">lexinfo:AdjectiveComparativeFrame</a>
    /// </summary>
    let AdjectiveComparativeFrame = _prefixId.prefix "AdjectiveComparativeFrame"

    /// <summary>
    ///   <para>lexinfo:example : er ist seinem bruder ÄHNLICH</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveDativePostPositiveFrame">lexinfo:AdjectiveDativePostPositiveFrame</a>
    /// </summary>
    let AdjectiveDativePostPositiveFrame =
        _prefixId.prefix "AdjectiveDativePostPositiveFrame"

    let AdjectiveFrame = _prefixId.prefix "AdjectiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : er ist des hochverrats SCHULDIG</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveGenitivePostPositiveFrame">lexinfo:AdjectiveGenitivePostPositiveFrame</a>
    /// </summary>
    let AdjectiveGenitivePostPositiveFrame =
        _prefixId.prefix "AdjectiveGenitivePostPositiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : es ist mir HEISS</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveImpersonalFrame">lexinfo:AdjectiveImpersonalFrame</a>
    /// </summary>
    let AdjectiveImpersonalFrame = _prefixId.prefix "AdjectiveImpersonalFrame"
    let AdjectivePOS = _prefixId.prefix "AdjectivePOS"
    /// <summary>
    ///   <para>lexinfo:example : he is RELATED TO her</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePPFrame">lexinfo:AdjectivePPFrame</a>
    /// </summary>
    let AdjectivePPFrame = _prefixId.prefix "AdjectivePPFrame"
    let AdjectivePhrase = _prefixId.prefix "AdjectivePhrase"
    /// <summary>
    ///   <para>lexinfo:example : that is something INTERESTING</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePostPositiveFrame">lexinfo:AdjectivePostPositiveFrame</a>
    /// </summary>
    let AdjectivePostPositiveFrame = _prefixId.prefix "AdjectivePostPositiveFrame"
    /// <summary>
    ///   <para>rdfs:comment : Note this frame should be used when both attributive and predicative use of the adjective is allowed</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicateFrame">lexinfo:AdjectivePredicateFrame</a>
    /// </summary>
    let AdjectivePredicateFrame = _prefixId.prefix "AdjectivePredicateFrame"
    /// <summary>
    ///   <para>lexinfo:example : he is HAPPY</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectivePredicativeFrame">lexinfo:AdjectivePredicativeFrame</a>
    /// </summary>
    let AdjectivePredicativeFrame = _prefixId.prefix "AdjectivePredicativeFrame"
    /// <summary>
    ///   <para>lexinfo:example : Everest is 8,848m HIGH</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveScaleFrame">lexinfo:AdjectiveScaleFrame</a>
    /// </summary>
    let AdjectiveScaleFrame = _prefixId.prefix "AdjectiveScaleFrame"
    /// <summary>
    ///   <para>lexinfo:example : tokyo is the BIGGEST of all metropoles</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#AdjectiveSuperlativeFrame">lexinfo:AdjectiveSuperlativeFrame</a>
    /// </summary>
    let AdjectiveSuperlativeFrame = _prefixId.prefix "AdjectiveSuperlativeFrame"
    let Adjunct = _prefixId.prefix "Adjunct"
    /// <summary>
    ///   <para>rdfs:label : Прелог или послелог</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adposition">lexinfo:Adposition</a>
    /// </summary>
    let Adposition = _prefixId.prefix "Adposition"
    let AdpositionPOS = _prefixId.prefix "AdpositionPOS"
    let AdpositionalObject = _prefixId.prefix "AdpositionalObject"
    /// <summary>
    ///   <para>rdfs:label : Наречие</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Adverb">lexinfo:Adverb</a>
    /// </summary>
    let Adverb = _prefixId.prefix "Adverb"
    let AdverbPOS = _prefixId.prefix "AdverbPOS"
    let AdverbialComplementFrame = _prefixId.prefix "AdverbialComplementFrame"
    /// <summary>
    ///   <para>rdfs:label : Аффикс</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Affix">lexinfo:Affix</a>
    /// </summary>
    let Affix = _prefixId.prefix "Affix"
    /// <summary>
    ///   <para>rdfs:label : Одушевленность</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Animacy">lexinfo:Animacy</a>
    /// </summary>
    let Animacy = _prefixId.prefix "Animacy"
    /// <summary>
    ///   <para>rdfs:comment : Indicates either the subject or object of the main clause may be the omitted argument of the subclause</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ArbitraryControl">lexinfo:ArbitraryControl</a>
    /// </summary>
    let ArbitraryControl = _prefixId.prefix "ArbitraryControl"
    /// <summary>
    ///   <para>rdfs:label : Артикль</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Article">lexinfo:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    let ArticlePOS = _prefixId.prefix "ArticlePOS"
    /// <summary>
    ///   <para>rdfs:label : Вид</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Aspect">lexinfo:Aspect</a>
    /// </summary>
    let Aspect = _prefixId.prefix "Aspect"
    let AttributiveArgument = _prefixId.prefix "AttributiveArgument"
    let CJK_compound = _prefixId.prefix "CJK_compound"
    /// <summary>
    ///   <para>rdfs:label : Падеж</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Case">lexinfo:Case</a>
    /// </summary>
    let Case = _prefixId.prefix "Case"
    let ClausalArgument = _prefixId.prefix "ClausalArgument"
    /// <summary>
    ///   <para>rdfs:label : Клитика</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Cliticness">lexinfo:Cliticness</a>
    /// </summary>
    let Cliticness = _prefixId.prefix "Cliticness"
    /// <summary>
    ///   <para>rdfs:label : Имя нарицательное</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#CommonNoun">lexinfo:CommonNoun</a>
    /// </summary>
    let CommonNoun = _prefixId.prefix "CommonNoun"
    let ComparativeAdjunct = _prefixId.prefix "ComparativeAdjunct"
    let Complement = _prefixId.prefix "Complement"
    /// <summary>
    ///   <para>rdfs:label : Союз</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Conjunction">lexinfo:Conjunction</a>
    /// </summary>
    let Conjunction = _prefixId.prefix "Conjunction"
    let ConjunctionPOS = _prefixId.prefix "ConjunctionPOS"
    /// <summary>
    ///   <para>rdfs:comment : Control indicates how a an argument from a main clause will be utilized in a subclause. This class includes both control structures and raising structures</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Control">lexinfo:Control</a>
    /// </summary>
    let Control = _prefixId.prefix "Control"
    /// <summary>
    ///   <para>rdfs:label : Датирование</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Dating">lexinfo:Dating</a>
    /// </summary>
    let Dating = _prefixId.prefix "Dating"
    let DativePostPositiveArgument = _prefixId.prefix "DativePostPositiveArgument"
    /// <summary>
    ///   <para>lexinfo:example : ich DANKE dir</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DativeTransitiveFrame">lexinfo:DativeTransitiveFrame</a>
    /// </summary>
    let DativeTransitiveFrame = _prefixId.prefix "DativeTransitiveFrame"
    /// <summary>
    ///   <para>rdfs:comment : A clause beginning with the declarative conjunction ("that" in English)</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeClause">lexinfo:DeclarativeClause</a>
    /// </summary>
    let DeclarativeClause = _prefixId.prefix "DeclarativeClause"
    /// <summary>
    ///   <para>rdfs:comment : Declarative frames take a clause as an argument, this argument is marker with the declarative conjunction ("that" in English)</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DeclarativeFrame">lexinfo:DeclarativeFrame</a>
    /// </summary>
    let DeclarativeFrame = _prefixId.prefix "DeclarativeFrame"
    /// <summary>
    ///   <para>rdfs:label : Определенность</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Definiteness">lexinfo:Definiteness</a>
    /// </summary>
    let Definiteness = _prefixId.prefix "Definiteness"
    /// <summary>
    ///   <para>rdfs:label : Степень</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Degree">lexinfo:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    /// <summary>
    ///   <para>rdfs:label : Детерминанта</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Determiner">lexinfo:Determiner</a>
    /// </summary>
    let Determiner = _prefixId.prefix "Determiner"
    let DeterminerPOS = _prefixId.prefix "DeterminerPOS"
    /// <summary>
    ///   <para>rdfs:label : Прямое дополнение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DirectObject">lexinfo:DirectObject</a>
    /// </summary>
    let DirectObject = _prefixId.prefix "DirectObject"

    /// <summary>
    ///   <para>lexinfo:example : das KOSTET ihn sein leben</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveDoubleAccusativeFrame">lexinfo:DitransitiveDoubleAccusativeFrame</a>
    /// </summary>
    let DitransitiveDoubleAccusativeFrame =
        _prefixId.prefix "DitransitiveDoubleAccusativeFrame"

    /// <summary>
    ///   <para>lexinfo:example : i GAVE him itlexinfo:example : mein vater SCHREIBT ihr einen brief</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame">lexinfo:DitransitiveFrame</a>
    /// </summary>
    let DitransitiveFrame = _prefixId.prefix "DitransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : she BOUGHT him it
    /// she BOUGHT it FOR him</para>
    ///   <para>lexinfo:languageSpecific : en^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_For">lexinfo:DitransitiveFrame_For</a>
    /// </summary>
    let DitransitiveFrame_For = _prefixId.prefix "DitransitiveFrame_For"
    /// <summary>
    ///   <para>lexinfo:example : he GAVE his mother a present
    /// he GAVE a present TO his mother</para>
    ///   <para>lexinfo:languageSpecific : en^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#DitransitiveFrame_To">lexinfo:DitransitiveFrame_To</a>
    /// </summary>
    let DitransitiveFrame_To = _prefixId.prefix "DitransitiveFrame_To"
    /// <summary>
    ///   <para>rdfs:label : Конечность</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Finiteness">lexinfo:Finiteness</a>
    /// </summary>
    let Finiteness = _prefixId.prefix "Finiteness"
    /// <summary>
    ///   <para>rdfs:label : Частота использования</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Frequency">lexinfo:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:comment : A word that is a fusion of a preposition and some other word... examples include the German words "zum" and "daran"</para>
    ///   <para>rdfs:label : Слитный предлог</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#FusedPreposition">lexinfo:FusedPreposition</a>
    /// </summary>
    let FusedPreposition = _prefixId.prefix "FusedPreposition"
    let FusedPrepositionPOS = _prefixId.prefix "FusedPrepositionPOS"
    /// <summary>
    ///   <para>rdfs:label : Род</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gender">lexinfo:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>lexinfo:example : man KLAGTE ihn des diebstahls AN</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveDitransitiveFrame">lexinfo:GenitiveDitransitiveFrame</a>
    /// </summary>
    let GenitiveDitransitiveFrame = _prefixId.prefix "GenitiveDitransitiveFrame"
    /// <summary>
    ///   <para>rdfs:label : Дополнение в родительном падеже</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveObject">lexinfo:GenitiveObject</a>
    /// </summary>
    let GenitiveObject = _prefixId.prefix "GenitiveObject"
    let GenitivePostPositiveArgument = _prefixId.prefix "GenitivePostPositiveArgument"
    /// <summary>
    ///   <para>lexinfo:example : wir BEDENKEN jenes mannes</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#GenitiveTransitiveFrame">lexinfo:GenitiveTransitiveFrame</a>
    /// </summary>
    let GenitiveTransitiveFrame = _prefixId.prefix "GenitiveTransitiveFrame"
    /// <summary>
    ///   <para>rdfs:comment : A clause, whose head is a non-finite verb form, which is used in place of an argument. In English these use the "-ing" suffix</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Gerund">lexinfo:Gerund</a>
    /// </summary>
    let Gerund = _prefixId.prefix "Gerund"
    let GerundACFrame = _prefixId.prefix "GerundACFrame"
    /// <summary>
    ///   <para>rdfs:comment : Indicates one of the arguments is a gerund clause</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#GerundFrame">lexinfo:GerundFrame</a>
    /// </summary>
    let GerundFrame = _prefixId.prefix "GerundFrame"
    let GerundOCFrame = _prefixId.prefix "GerundOCFrame"
    let GerundSCFrame = _prefixId.prefix "GerundSCFrame"
    let ImpersonalFrame = _prefixId.prefix "ImpersonalFrame"
    let ImpersonalIntransitiveFrame = _prefixId.prefix "ImpersonalIntransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : it REEKS OF tar</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalIntransitivePPFrame">lexinfo:ImpersonalIntransitivePPFrame</a>
    /// </summary>
    let ImpersonalIntransitivePPFrame = _prefixId.prefix "ImpersonalIntransitivePPFrame"
    /// <summary>
    ///   <para>lexinfo:example : es JUCKT mich</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ImpersonalTransitiveFrame">lexinfo:ImpersonalTransitiveFrame</a>
    /// </summary>
    let ImpersonalTransitiveFrame = _prefixId.prefix "ImpersonalTransitiveFrame"
    /// <summary>
    ///   <para>rdfs:label : Косвенное дополнение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IndirectObject">lexinfo:IndirectObject</a>
    /// </summary>
    let IndirectObject = _prefixId.prefix "IndirectObject"
    /// <summary>
    ///   <para>rdfs:comment : A clause whose main verb is infinitive</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveClause">lexinfo:InfinitiveClause</a>
    /// </summary>
    let InfinitiveClause = _prefixId.prefix "InfinitiveClause"
    /// <summary>
    ///   <para>rdfs:comment : Infinitive frames take an infinitive clause as an argument</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#InfinitiveFrame">lexinfo:InfinitiveFrame</a>
    /// </summary>
    let InfinitiveFrame = _prefixId.prefix "InfinitiveFrame"
    /// <summary>
    ///   <para>rdfs:label : Суффикс</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Infix">lexinfo:Infix</a>
    /// </summary>
    let Infix = _prefixId.prefix "Infix"
    /// <summary>
    ///   <para>rdfs:label : Междометие</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Interjection">lexinfo:Interjection</a>
    /// </summary>
    let Interjection = _prefixId.prefix "Interjection"
    /// <summary>
    ///   <para>rdfs:comment : A subclause that begins interrogative construction ("wh"-word in English)</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeClause">lexinfo:InterrogativeClause</a>
    /// </summary>
    let InterrogativeClause = _prefixId.prefix "InterrogativeClause"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the frame has a subframe indicated with the appropriate interrogative (e.g., "who", "where", "how")</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeFrame">lexinfo:InterrogativeFrame</a>
    /// </summary>
    let InterrogativeFrame = _prefixId.prefix "InterrogativeFrame"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the frame has an argument that is a clause with both an interrogative and the clause is in the infinitive form</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#InterrogativeInfinitiveFrame">lexinfo:InterrogativeInfinitiveFrame</a>
    /// </summary>
    let InterrogativeInfinitiveFrame = _prefixId.prefix "InterrogativeInfinitiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : his reputation SANK low</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdjectivalComplementFrame">lexinfo:IntransitiveAdjectivalComplementFrame</a>
    /// </summary>
    let IntransitiveAdjectivalComplementFrame =
        _prefixId.prefix "IntransitiveAdjectivalComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : he SEEMED well</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveAdverbialComplementFrame">lexinfo:IntransitiveAdverbialComplementFrame</a>
    /// </summary>
    let IntransitiveAdverbialComplementFrame =
        _prefixId.prefix "IntransitiveAdverbialComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : i KNOW [that is a bad idea]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveDeclarativeFrame">lexinfo:IntransitiveDeclarativeFrame</a>
    /// </summary>
    let IntransitiveDeclarativeFrame = _prefixId.prefix "IntransitiveDeclarativeFrame"
    /// <summary>
    ///   <para>lexinfo:example : he LEFT</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveFrame">lexinfo:IntransitiveFrame</a>
    /// </summary>
    let IntransitiveFrame = _prefixId.prefix "IntransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : I HELPED [to save the child]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveACFrame">lexinfo:IntransitiveInfinitiveACFrame</a>
    /// </summary>
    let IntransitiveInfinitiveACFrame = _prefixId.prefix "IntransitiveInfinitiveACFrame"
    /// <summary>
    ///   <para>lexinfo:example : he SEEMED [to be happy]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveRSFrame">lexinfo:IntransitiveInfinitiveRSFrame</a>
    /// </summary>
    let IntransitiveInfinitiveRSFrame = _prefixId.prefix "IntransitiveInfinitiveRSFrame"
    /// <summary>
    ///   <para>lexinfo:example : I WANTED [to come]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInfinitiveSCFrame">lexinfo:IntransitiveInfinitiveSCFrame</a>
    /// </summary>
    let IntransitiveInfinitiveSCFrame = _prefixId.prefix "IntransitiveInfinitiveSCFrame"

    /// <summary>
    ///   <para>rdfs:comment : he ASKED [what he should do]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeFrame">lexinfo:IntransitiveInterrogativeFrame</a>
    /// </summary>
    let IntransitiveInterrogativeFrame =
        _prefixId.prefix "IntransitiveInterrogativeFrame"

    /// <summary>
    ///   <para>lexinfo:example : he ASKED [what to do]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveInterrogativeInfinitiveFrame">lexinfo:IntransitiveInterrogativeInfinitiveFrame</a>
    /// </summary>
    let IntransitiveInterrogativeInfinitiveFrame =
        _prefixId.prefix "IntransitiveInterrogativeInfinitiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : he SEEMED a fool</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveNominalComplementFrame">lexinfo:IntransitiveNominalComplementFrame</a>
    /// </summary>
    let IntransitiveNominalComplementFrame =
        _prefixId.prefix "IntransitiveNominalComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : the SUGGESTED to him [that he should go]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPDeclarativeFrame">lexinfo:IntransitivePPDeclarativeFrame</a>
    /// </summary>
    let IntransitivePPDeclarativeFrame =
        _prefixId.prefix "IntransitivePPDeclarativeFrame"

    /// <summary>
    ///   <para>lexinfo:example : he TOOK CARE OF her</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitivePPFrame">lexinfo:IntransitivePPFrame</a>
    /// </summary>
    let IntransitivePPFrame = _prefixId.prefix "IntransitivePPFrame"
    /// <summary>
    ///   <para>lexinfo:example : they THOUGHT he was always late</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#IntransitiveSententialFrame">lexinfo:IntransitiveSententialFrame</a>
    /// </summary>
    let IntransitiveSententialFrame = _prefixId.prefix "IntransitiveSententialFrame"
    let ModificationType = _prefixId.prefix "ModificationType"
    /// <summary>
    ///   <para>rdfs:label : Наклонение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Mood">lexinfo:Mood</a>
    /// </summary>
    let Mood = _prefixId.prefix "Mood"
    /// <summary>
    ///   <para>rdfs:label : Морфосинтаксическое свойство</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#MorphosyntacticProperty">lexinfo:MorphosyntacticProperty</a>
    /// </summary>
    let MorphosyntacticProperty = _prefixId.prefix "MorphosyntacticProperty"
    /// <summary>
    ///   <para>rdfs:label : Отрицание</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Negative">lexinfo:Negative</a>
    /// </summary>
    let Negative = _prefixId.prefix "Negative"
    let NominalComplementFrame = _prefixId.prefix "NominalComplementFrame"
    /// <summary>
    ///   <para>rdfs:label : Норматив</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#NormativeAuthorization">lexinfo:NormativeAuthorization</a>
    /// </summary>
    let NormativeAuthorization = _prefixId.prefix "NormativeAuthorization"
    /// <summary>
    ///   <para>rdfs:label : Имя существительное</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Noun">lexinfo:Noun</a>
    /// </summary>
    let Noun = _prefixId.prefix "Noun"
    let NounFrame = _prefixId.prefix "NounFrame"
    let NounPOS = _prefixId.prefix "NounPOS"
    let NounPPFrame = _prefixId.prefix "NounPPFrame"
    let NounPhrase = _prefixId.prefix "NounPhrase"
    /// <summary>
    ///   <para>lexinfo:example : the CAPITAL OF france is paris</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPossessiveFrame">lexinfo:NounPossessiveFrame</a>
    /// </summary>
    let NounPossessiveFrame = _prefixId.prefix "NounPossessiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : he is a MAN</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#NounPredicateFrame">lexinfo:NounPredicateFrame</a>
    /// </summary>
    let NounPredicateFrame = _prefixId.prefix "NounPredicateFrame"
    /// <summary>
    ///   <para>rdfs:label : Число</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Number">lexinfo:Number</a>
    /// </summary>
    let Number = _prefixId.prefix "Number"
    /// <summary>
    ///   <para>rdfs:label : Имя числительное</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Numeral">lexinfo:Numeral</a>
    /// </summary>
    let Numeral = _prefixId.prefix "Numeral"
    let NumeralPOS = _prefixId.prefix "NumeralPOS"
    /// <summary>
    ///   <para>rdfs:label : Объектrdfs:label : Дополнение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Object">lexinfo:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    let ObjectComplement = _prefixId.prefix "ObjectComplement"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the object of the main clause is also the (omitted) object of the subclause</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ObjectControl">lexinfo:ObjectControl</a>
    /// </summary>
    let ObjectControl = _prefixId.prefix "ObjectControl"
    let PPFrame = _prefixId.prefix "PPFrame"
    /// <summary>
    ///   <para>rdfs:label : Часть речи</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#PartOfSpeech">lexinfo:PartOfSpeech</a>
    /// </summary>
    let PartOfSpeech = _prefixId.prefix "PartOfSpeech"
    /// <summary>
    ///   <para>rdfs:label : Частица</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Particle">lexinfo:Particle</a>
    /// </summary>
    let Particle = _prefixId.prefix "Particle"
    let ParticlePOS = _prefixId.prefix "ParticlePOS"
    /// <summary>
    ///   <para>rdfs:label : Лицо</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Person">lexinfo:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    let PossessiveAdjunct = _prefixId.prefix "PossessiveAdjunct"
    let PostPositiveArgument = _prefixId.prefix "PostPositiveArgument"
    /// <summary>
    ///   <para>rdfs:label : Послелог</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Postposition">lexinfo:Postposition</a>
    /// </summary>
    let Postposition = _prefixId.prefix "Postposition"
    let PredicativeAdjective = _prefixId.prefix "PredicativeAdjective"
    let PredicativeAdverb = _prefixId.prefix "PredicativeAdverb"
    let PredicativeNominative = _prefixId.prefix "PredicativeNominative"
    /// <summary>
    ///   <para>rdfs:label : Приставка</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Prefix">lexinfo:Prefix</a>
    /// </summary>
    let Prefix = _prefixId.prefix "Prefix"
    /// <summary>
    ///   <para>rdfs:label : Предлог</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Preposition">lexinfo:Preposition</a>
    /// </summary>
    let Preposition = _prefixId.prefix "Preposition"
    let PrepositionFrame = _prefixId.prefix "PrepositionFrame"
    let PrepositionPhrase = _prefixId.prefix "PrepositionPhrase"
    let PrepositionalAdjunct = _prefixId.prefix "PrepositionalAdjunct"
    /// <summary>
    ///   <para>rdfs:comment : Abstract frame for words that take a prepositional phrase as an argument</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalFrame">lexinfo:PrepositionalFrame</a>
    /// </summary>
    let PrepositionalFrame = _prefixId.prefix "PrepositionalFrame"

    let PrepositionalInterrogativeFrame =
        _prefixId.prefix "PrepositionalInterrogativeFrame"

    /// <summary>
    ///   <para>rdfs:label : Предложное дополнение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalObject">lexinfo:PrepositionalObject</a>
    /// </summary>
    let PrepositionalObject = _prefixId.prefix "PrepositionalObject"
    /// <summary>
    ///   <para>lexinfo:example : he is IN london</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#PrepositionalPhraseFrame">lexinfo:PrepositionalPhraseFrame</a>
    /// </summary>
    let PrepositionalPhraseFrame = _prefixId.prefix "PrepositionalPhraseFrame"
    /// <summary>
    ///   <para>rdfs:label : Местоимение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Pronoun">lexinfo:Pronoun</a>
    /// </summary>
    let Pronoun = _prefixId.prefix "Pronoun"
    let PronounPOS = _prefixId.prefix "PronounPOS"
    /// <summary>
    ///   <para>rdfs:label : Имя собственное</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ProperNoun">lexinfo:ProperNoun</a>
    /// </summary>
    let ProperNoun = _prefixId.prefix "ProperNoun"
    let RaisableSubject = _prefixId.prefix "RaisableSubject"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the syntactic subject of the main clause is in fact the subject of the subclause. The main clause should then be interpreted as being impersonal.</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#RaisingSubject">lexinfo:RaisingSubject</a>
    /// </summary>
    let RaisingSubject = _prefixId.prefix "RaisingSubject"
    /// <summary>
    ///   <para>lexinfo:example : mary and john MET</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReciprocalFrame">lexinfo:ReciprocalFrame</a>
    /// </summary>
    let ReciprocalFrame = _prefixId.prefix "ReciprocalFrame"
    /// <summary>
    ///   <para>rdfs:label : Принадлежность</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReferentType">lexinfo:ReferentType</a>
    /// </summary>
    let ReferentType = _prefixId.prefix "ReferentType"

    /// <summary>
    ///   <para>rdfs:comment : ist diese frame echt?</para>
    ///   <para>lexinfo:example : ich TUE mir WEH</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDativeTransitiveFrame">lexinfo:ReflexiveDativeTransitiveFrame</a>
    /// </summary>
    let ReflexiveDativeTransitiveFrame =
        _prefixId.prefix "ReflexiveDativeTransitiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : das habe ich mir EINGEBILDET</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveDitransitiveFrame">lexinfo:ReflexiveDitransitiveFrame</a>
    /// </summary>
    let ReflexiveDitransitiveFrame = _prefixId.prefix "ReflexiveDitransitiveFrame"
    let ReflexiveFrame = _prefixId.prefix "ReflexiveFrame"
    /// <summary>
    ///   <para>rdfs:label : Рефлексивное дополнение</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveObject">lexinfo:ReflexiveObject</a>
    /// </summary>
    let ReflexiveObject = _prefixId.prefix "ReflexiveObject"
    /// <summary>
    ///   <para>lexinfo:example : hans und marie TREFFEN sich</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveReciprocalFrame">lexinfo:ReflexiveReciprocalFrame</a>
    /// </summary>
    let ReflexiveReciprocalFrame = _prefixId.prefix "ReflexiveReciprocalFrame"
    /// <summary>
    ///   <para>lexinfo:example : elle se COUCHElexinfo:example : er ERHOLT sich</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitiveFrame">lexinfo:ReflexiveTransitiveFrame</a>
    /// </summary>
    let ReflexiveTransitiveFrame = _prefixId.prefix "ReflexiveTransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : elle se APPROCHE DE la garelexinfo:example : ich ERRINERE mich AN seinen vater</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#ReflexiveTransitivePPFrame">lexinfo:ReflexiveTransitivePPFrame</a>
    /// </summary>
    let ReflexiveTransitivePPFrame = _prefixId.prefix "ReflexiveTransitivePPFrame"
    /// <summary>
    ///   <para>rdfs:label : Регистр</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Register">lexinfo:Register</a>
    /// </summary>
    let Register = _prefixId.prefix "Register"
    /// <summary>
    ///   <para>rdfs:comment : Sentential frames take a clause as argument, no conjunction is used and the syntax of the clause is the same as a main clause</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SententialFrame">lexinfo:SententialFrame</a>
    /// </summary>
    let SententialFrame = _prefixId.prefix "SententialFrame"
    /// <summary>
    ///   <para>rdfs:label : Подлежащее</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Subject">lexinfo:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the subject of the main clause is the (omitted) subject of the subclause</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectControl">lexinfo:SubjectControl</a>
    /// </summary>
    let SubjectControl = _prefixId.prefix "SubjectControl"
    let SubjectlessFrame = _prefixId.prefix "SubjectlessFrame"
    /// <summary>
    ///   <para>lexinfo:example : mir SCHWINDELT</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitiveFrame">lexinfo:SubjectlessIntransitiveFrame</a>
    /// </summary>
    let SubjectlessIntransitiveFrame = _prefixId.prefix "SubjectlessIntransitiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : mir TRÄUMT VON jener zeit</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessIntransitivePPFrame">lexinfo:SubjectlessIntransitivePPFrame</a>
    /// </summary>
    let SubjectlessIntransitivePPFrame =
        _prefixId.prefix "SubjectlessIntransitivePPFrame"

    /// <summary>
    ///   <para>lexinfo:example : mich FRIERT</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitiveFrame">lexinfo:SubjectlessTransitiveFrame</a>
    /// </summary>
    let SubjectlessTransitiveFrame = _prefixId.prefix "SubjectlessTransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : mich EKELT VOR fleisch</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjectlessTransitivePPFrame">lexinfo:SubjectlessTransitivePPFrame</a>
    /// </summary>
    let SubjectlessTransitivePPFrame = _prefixId.prefix "SubjectlessTransitivePPFrame"
    /// <summary>
    ///   <para>rdfs:comment : A subclause that is in the subjunctive mood</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#SubjunctiveClause">lexinfo:SubjunctiveClause</a>
    /// </summary>
    let SubjunctiveClause = _prefixId.prefix "SubjunctiveClause"
    /// <summary>
    ///   <para>rdfs:label : Окончание</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Suffix">lexinfo:Suffix</a>
    /// </summary>
    let Suffix = _prefixId.prefix "Suffix"
    let SuperlativeAdjunct = _prefixId.prefix "SuperlativeAdjunct"
    /// <summary>
    ///   <para>rdfs:label : Символ</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Symbol">lexinfo:Symbol</a>
    /// </summary>
    let Symbol = _prefixId.prefix "Symbol"
    let SymbolPOS = _prefixId.prefix "SymbolPOS"
    /// <summary>
    ///   <para>rdfs:label : Временной классификатор</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TemporalQualifier">lexinfo:TemporalQualifier</a>
    /// </summary>
    let TemporalQualifier = _prefixId.prefix "TemporalQualifier"
    /// <summary>
    ///   <para>rdfs:label : Видовременная форма</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Tense">lexinfo:Tense</a>
    /// </summary>
    let Tense = _prefixId.prefix "Tense"
    let TermElement = _prefixId.prefix "TermElement"
    /// <summary>
    ///   <para>rdfs:label : Тип термина</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TermType">lexinfo:TermType</a>
    /// </summary>
    let TermType = _prefixId.prefix "TermType"

    /// <summary>
    ///   <para>lexinfo:example : they PAINTED it red</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdjectivalComplementFrame">lexinfo:TransitiveAdjectivalComplementFrame</a>
    /// </summary>
    let TransitiveAdjectivalComplementFrame =
        _prefixId.prefix "TransitiveAdjectivalComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : she PUT the cheese back</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveAdverbialComplementFrame">lexinfo:TransitiveAdverbialComplementFrame</a>
    /// </summary>
    let TransitiveAdverbialComplementFrame =
        _prefixId.prefix "TransitiveAdverbialComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : he CONVINCED her [that she should go]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveDeclarativeFrame">lexinfo:TransitiveDeclarativeFrame</a>
    /// </summary>
    let TransitiveDeclarativeFrame = _prefixId.prefix "TransitiveDeclarativeFrame"
    /// <summary>
    ///   <para>lexinfo:example : the dog BIT the man</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveFrame">lexinfo:TransitiveFrame</a>
    /// </summary>
    let TransitiveFrame = _prefixId.prefix "TransitiveFrame"
    /// <summary>
    ///   <para>lexinfo:example : they CONVINCED him [to go]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveACFrame">lexinfo:TransitiveInfinitiveACFrame</a>
    /// </summary>
    let TransitiveInfinitiveACFrame = _prefixId.prefix "TransitiveInfinitiveACFrame"
    /// <summary>
    ///   <para>lexinfo:example : i WANT john [to go]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveOCFrame">lexinfo:TransitiveInfinitiveOCFrame</a>
    /// </summary>
    let TransitiveInfinitiveOCFrame = _prefixId.prefix "TransitiveInfinitiveOCFrame"
    /// <summary>
    ///   <para>lexinfo:example : john PROMISED mary [to resign]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInfinitiveSCFrame">lexinfo:TransitiveInfinitiveSCFrame</a>
    /// </summary>
    let TransitiveInfinitiveSCFrame = _prefixId.prefix "TransitiveInfinitiveSCFrame"
    /// <summary>
    ///   <para>lexinfo:example : he ASKED her [what he should do]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeFrame">lexinfo:TransitiveInterrogativeFrame</a>
    /// </summary>
    let TransitiveInterrogativeFrame = _prefixId.prefix "TransitiveInterrogativeFrame"

    /// <summary>
    ///   <para>lexinfo:example : he ASKED her [what to do]</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveInterrogativeInfinitiveFrame">lexinfo:TransitiveInterrogativeInfinitiveFrame</a>
    /// </summary>
    let TransitiveInterrogativeInfinitiveFrame =
        _prefixId.prefix "TransitiveInterrogativeInfinitiveFrame"

    /// <summary>
    ///   <para>lexinfo:example : they ELECTED him president</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveNominalComplementFrame">lexinfo:TransitiveNominalComplementFrame</a>
    /// </summary>
    let TransitiveNominalComplementFrame =
        _prefixId.prefix "TransitiveNominalComplementFrame"

    /// <summary>
    ///   <para>lexinfo:example : she ADDED salt TO the stew</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitivePPFrame">lexinfo:TransitivePPFrame</a>
    /// </summary>
    let TransitivePPFrame = _prefixId.prefix "TransitivePPFrame"
    /// <summary>
    ///   <para>lexinfo:example : he TOLD the audience he was leaving</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#TransitiveSententialFrame">lexinfo:TransitiveSententialFrame</a>
    /// </summary>
    let TransitiveSententialFrame = _prefixId.prefix "TransitiveSententialFrame"
    /// <summary>
    ///   <para>rdfs:label : Глагол</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Verb">lexinfo:Verb</a>
    /// </summary>
    let Verb = _prefixId.prefix "Verb"
    let VerbFormMood = _prefixId.prefix "VerbFormMood"
    let VerbFrame = _prefixId.prefix "VerbFrame"
    let VerbPOS = _prefixId.prefix "VerbPOS"
    let VerbPhrase = _prefixId.prefix "VerbPhrase"
    /// <summary>
    ///   <para>rdfs:label : Залог</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#Voice">lexinfo:Voice</a>
    /// </summary>
    let Voice = _prefixId.prefix "Voice"
    let abbreviatedForm = _prefixId.prefix "abbreviatedForm"
    let abbreviation = _prefixId.prefix "abbreviation"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : A linking element used to identify a relation between an abbreviation and its full or expanded form.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : abbreviationFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#abbreviationFor">lexinfo:abbreviationFor</a>
    /// </summary>
    let abbreviationFor = _prefixId.prefix "abbreviationFor"
    let abessiveCase = _prefixId.prefix "abessiveCase"
    let ablativeCase = _prefixId.prefix "ablativeCase"
    let absolutiveCase = _prefixId.prefix "absolutiveCase"
    let accusativeCase = _prefixId.prefix "accusativeCase"
    let accusativeCaseForm = _prefixId.prefix "accusativeCaseForm"
    let acronym = _prefixId.prefix "acronym"
    /// <summary>
    ///   <para>rdfs:comment : A linking element used to identify a relation between an acronym and its full or expanded form.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : acronymFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#acronymFor">lexinfo:acronymFor</a>
    /// </summary>
    let acronymFor = _prefixId.prefix "acronymFor"
    let activeVoice = _prefixId.prefix "activeVoice"
    let adessiveCase = _prefixId.prefix "adessiveCase"
    let aditiveCase = _prefixId.prefix "aditiveCase"
    let adjective = _prefixId.prefix "adjective"
    let adjective_i = _prefixId.prefix "adjective-i"
    let adjective_na = _prefixId.prefix "adjective-na"
    let adjunct = _prefixId.prefix "adjunct"
    let admittedTerm = _prefixId.prefix "admittedTerm"
    let adposition = _prefixId.prefix "adposition"
    let adpositionalObject = _prefixId.prefix "adpositionalObject"
    let adverb = _prefixId.prefix "adverb"
    let adverbialComplement = _prefixId.prefix "adverbialComplement"
    let adverbialPronoun = _prefixId.prefix "adverbialPronoun"
    let affirmativeParticle = _prefixId.prefix "affirmativeParticle"
    let affix = _prefixId.prefix "affix"
    let affixedPersonalPronoun = _prefixId.prefix "affixedPersonalPronoun"
    let allativeCase = _prefixId.prefix "allativeCase"
    let allusivePronoun = _prefixId.prefix "allusivePronoun"
    /// <summary>
    ///   <para>rdfs:label : animacy^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : The characteristic of a word indicating that in a given discourse community, its referent is considered to be alive or to possess a quality of volition or consciousness.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#animacy">lexinfo:animacy</a>
    /// </summary>
    let animacy = _prefixId.prefix "animacy"
    let animate = _prefixId.prefix "animate"
    /// <summary>
    ///   <para>rdfs:comment : A term or lexeme whose concept or sense constitutes the opposite of the concept represented by a second term or lexeme.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : antonym term^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#antonym">lexinfo:antonym</a>
    /// </summary>
    let antonym = _prefixId.prefix "antonym"
    let appellation = _prefixId.prefix "appellation"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : Property used to qualify something similar but not exactly the same^^xsd:string</para>
    ///   <para>rdfs:label : approximate^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#approximate">lexinfo:approximate</a>
    /// </summary>
    let approximate = _prefixId.prefix "approximate"
    let approximateSynonym = _prefixId.prefix "approximateSynonym"
    let archaicForm = _prefixId.prefix "archaicForm"
    let article = _prefixId.prefix "article"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Category associated to verbs and referring to the way the grammar marks the duration or type of temporal activity.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : aspect^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#aspect">lexinfo:aspect</a>
    /// </summary>
    let aspect = _prefixId.prefix "aspect"
    /// <summary>
    ///   <para>rdfs:comment : A relation between two concepts having a non-hierarchical thematic connection by virtue of experience.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : concept relation^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#associativeRelation">lexinfo:associativeRelation</a>
    /// </summary>
    let associativeRelation = _prefixId.prefix "associativeRelation"
    let attributiveArg = _prefixId.prefix "attributiveArg"
    let baseElement = _prefixId.prefix "baseElement"
    let benchLevelRegister = _prefixId.prefix "benchLevelRegister"
    let benefactiveCase = _prefixId.prefix "benefactiveCase"
    let bound = _prefixId.prefix "bound"
    let bullet = _prefixId.prefix "bullet"
    let cardinalNumeral = _prefixId.prefix "cardinalNumeral"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : In a given sentence, the way in which the form of a word changes in order to express a relationship with one or several words of the sentence. The morphological modification may apply to nouns, pronouns noun phrase constituents, such as adjectives or numerals.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : case^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#case">lexinfo:case</a>
    /// </summary>
    let case = _prefixId.prefix "case"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : A concept that is related to another concept by virtue of the fact that it plays a causative role with respect to that concept.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : causallyRelatedConcept^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#causallyRelatedConcept">lexinfo:causallyRelatedConcept</a>
    /// </summary>
    let causallyRelatedConcept = _prefixId.prefix "causallyRelatedConcept"
    let causativeCase = _prefixId.prefix "causativeCase"
    let cessative = _prefixId.prefix "cessative"
    let circumposition = _prefixId.prefix "circumposition"
    let clausalArg = _prefixId.prefix "clausalArg"
    let clippedTerm = _prefixId.prefix "clippedTerm"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A linking element used to identify a relation between a clipped term and its full or expanded form.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : clippedTermFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#clippedTermFor">lexinfo:clippedTermFor</a>
    /// </summary>
    let clippedTermFor = _prefixId.prefix "clippedTermFor"
    /// <summary>
    ///   <para>rdfs:comment : Categorization of the different types of clitics^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : cliticness^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#cliticness">lexinfo:cliticness</a>
    /// </summary>
    let cliticness = _prefixId.prefix "cliticness"
    let closeParenthesis = _prefixId.prefix "closeParenthesis"
    let collective = _prefixId.prefix "collective"
    let collectivePronoun = _prefixId.prefix "collectivePronoun"
    let collocation = _prefixId.prefix "collocation"
    let colon = _prefixId.prefix "colon"
    let comitativeCase = _prefixId.prefix "comitativeCase"
    let comma = _prefixId.prefix "comma"
    let commonGender = _prefixId.prefix "commonGender"
    let commonName = _prefixId.prefix "commonName"
    let commonNoun = _prefixId.prefix "commonNoun"
    let commonlyUsed = _prefixId.prefix "commonlyUsed"
    let comparative = _prefixId.prefix "comparative"
    let comparativeAdjunct = _prefixId.prefix "comparativeAdjunct"
    let comparativeDegreeForm = _prefixId.prefix "comparativeDegreeForm"
    let comparativeParticle = _prefixId.prefix "comparativeParticle"
    /// <summary>
    ///   <para>rdfs:comment : A noun phrase that follows a copula or similar verb, as for example an idiot in the sentence He is an idiot. - A clause that serves as the subject or direct object of a verb or the direct object of a preposition, as for example that he would be early in the sentence I hoped that he would be early^^xsd:string</para>
    ///   <para>rdfs:label : complement^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#complement">lexinfo:complement</a>
    /// </summary>
    let complement = _prefixId.prefix "complement"
    let compound = _prefixId.prefix "compound"
    let compoundPreposition = _prefixId.prefix "compoundPreposition"
    let conditional = _prefixId.prefix "conditional"
    let conditionalParticle = _prefixId.prefix "conditionalParticle"
    let conditionalPronoun = _prefixId.prefix "conditionalPronoun"
    /// <summary>
    ///   <para>rdfs:comment : The confidence in a given relationship.</para>
    ///   <para>rdfs:label : Confidence</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#confidence">lexinfo:confidence</a>
    /// </summary>
    let confidence = _prefixId.prefix "confidence"
    let conjunction = _prefixId.prefix "conjunction"
    let contraction = _prefixId.prefix "contraction"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : The full form that corresponds to a contracted form.^^xsd:string</para>
    ///   <para>rdfs:label : contractionFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#contractionFor">lexinfo:contractionFor</a>
    /// </summary>
    let contractionFor = _prefixId.prefix "contractionFor"
    /// <summary>
    ///   <para>rdfs:comment : A subordinate concept having the same nearest superordinate concept and same criterion of subdivision as some other concept in a given concept system.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : coordinateConcept^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#coordinateConcept">lexinfo:coordinateConcept</a>
    /// </summary>
    let coordinateConcept = _prefixId.prefix "coordinateConcept"
    let coordinatingConjunction = _prefixId.prefix "coordinatingConjunction"
    let coordinationParticle = _prefixId.prefix "coordinationParticle"
    let copula = _prefixId.prefix "copula"
    /// <summary>
    ///   <para>rdfs:comment : Used with copula constructions. This represents the subject/object in a copula construction. As such constructions are reversible this property is used instead of the usual verb subject/object. E,g.,
    ///
    /// Barack Obama is the president/The president is Barack Obama</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeArg">lexinfo:copulativeArg</a>
    /// </summary>
    let copulativeArg = _prefixId.prefix "copulativeArg"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the subject of a copula construction. It is assumed that by using this the copula construction is not reversible e.g.,
    ///
    /// He is happy/*happy is him</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#copulativeSubject">lexinfo:copulativeSubject</a>
    /// </summary>
    let copulativeSubject = _prefixId.prefix "copulativeSubject"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Indication specifying whether the usage is old or modern.^^xsd:string</para>
    ///   <para>rdfs:label : dating^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#dating">lexinfo:dating</a>
    /// </summary>
    let dating = _prefixId.prefix "dating"
    let dativeCase = _prefixId.prefix "dativeCase"
    let dativeCaseForm = _prefixId.prefix "dativeCaseForm"
    let declarativeClause = _prefixId.prefix "declarativeClause"
    let deficientVerb = _prefixId.prefix "deficientVerb"
    let definite = _prefixId.prefix "definite"
    let definiteArticle = _prefixId.prefix "definiteArticle"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : Property about the possiblity to identify an entity.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : definiteness^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#definiteness">lexinfo:definiteness</a>
    /// </summary>
    let definiteness = _prefixId.prefix "definiteness"
    /// <summary>
    ///   <para>rdfs:comment : Property concerning comparison.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : degree^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#degree">lexinfo:degree</a>
    /// </summary>
    let degree = _prefixId.prefix "degree"
    let delativeCase = _prefixId.prefix "delativeCase"
    let demonstrativeDeterminer = _prefixId.prefix "demonstrativeDeterminer"
    let demonstrativePronoun = _prefixId.prefix "demonstrativePronoun"
    let deprecatedTerm = _prefixId.prefix "deprecatedTerm"
    let derivedForm = _prefixId.prefix "derivedForm"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A description in general prose text of the issues that are indicated by the context. The description field can occur at many different places in a component and profile.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wittenburg, Peter^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#description">lexinfo:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let determiner = _prefixId.prefix "determiner"
    let dialectRegister = _prefixId.prefix "dialectRegister"
    let diminutiveNoun = _prefixId.prefix "diminutiveNoun"
    /// <summary>
    ///   <para>rdfs:comment : relation between a phrase and a verb, in which the relation is central to the verb^^xsd:string</para>
    ///   <para>rdfs:label : direct object^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#directObject">lexinfo:directObject</a>
    /// </summary>
    let directObject = _prefixId.prefix "directObject"
    let distinctiveParticle = _prefixId.prefix "distinctiveParticle"
    let dual = _prefixId.prefix "dual"
    let dualNumberForm = _prefixId.prefix "dualNumberForm"
    let elativeCase = _prefixId.prefix "elativeCase"
    let emphaticPronoun = _prefixId.prefix "emphaticPronoun"
    let entryTerm = _prefixId.prefix "entryTerm"
    let equation = _prefixId.prefix "equation"
    let equativeCase = _prefixId.prefix "equativeCase"
    let ergativeCase = _prefixId.prefix "ergativeCase"
    let essiveCase = _prefixId.prefix "essiveCase"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : Morpheme that has a particular status with regards to the word's etymology.^^xsd:string</para>
    ///   <para>rdfs:label : etymological root^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymologicalRoot">lexinfo:etymologicalRoot</a>
    /// </summary>
    let etymologicalRoot = _prefixId.prefix "etymologicalRoot"
    /// <summary>
    ///   <para>rdfs:comment : Information on the origin of a word and the development of its meaning.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : etymology^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#etymology">lexinfo:etymology</a>
    /// </summary>
    let etymology = _prefixId.prefix "etymology"
    /// <summary>
    ///   <para>rdfs:comment : Completely correct in every detail^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : exact^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#exact">lexinfo:exact</a>
    /// </summary>
    let exact = _prefixId.prefix "exact"
    /// <summary>
    ///   <para>rdfs:comment : An example of the usage of a frame.</para>
    ///   <para>rdfs:label : example^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#example">lexinfo:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    let exclamativeDeterminer = _prefixId.prefix "exclamativeDeterminer"
    let exclamativePoint = _prefixId.prefix "exclamativePoint"
    let exclamativePronoun = _prefixId.prefix "exclamativePronoun"
    let existentialPronoun = _prefixId.prefix "existentialPronoun"
    /// <summary>
    ///   <para>rdfs:comment : A statement that describes and clarifies a concept and makes it understandable, but does not necessarily differentiate it from other concepts.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : explanation^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#explanation">lexinfo:explanation</a>
    /// </summary>
    let explanation = _prefixId.prefix "explanation"
    let expression = _prefixId.prefix "expression"
    let facetiousRegister = _prefixId.prefix "facetiousRegister"
    let feminine = _prefixId.prefix "feminine"
    let finite = _prefixId.prefix "finite"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Property referring to finite and non-finite status of a verbal form.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : finitness^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#finiteness">lexinfo:finiteness</a>
    /// </summary>
    let finiteness = _prefixId.prefix "finiteness"
    let firstPerson = _prefixId.prefix "firstPerson"
    let firstPersonForm = _prefixId.prefix "firstPersonForm"
    let formCaseVariant = _prefixId.prefix "formCaseVariant"
    let formDegreeVariant = _prefixId.prefix "formDegreeVariant"
    let formMoodVariant = _prefixId.prefix "formMoodVariant"
    let formNumberVariant = _prefixId.prefix "formNumberVariant"
    let formPersonVariant = _prefixId.prefix "formPersonVariant"
    let formPositivityVariant = _prefixId.prefix "formPositivityVariant"
    let formTenseVariant = _prefixId.prefix "formTenseVariant"
    let formalRegister = _prefixId.prefix "formalRegister"
    let formula = _prefixId.prefix "formula"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : The relative commonness with which a term occurs.^^xsd:string</para>
    ///   <para>rdfs:label : frequency^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#frequency">lexinfo:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    let fullArticle = _prefixId.prefix "fullArticle"
    let fullForm = _prefixId.prefix "fullForm"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : A linking element used to identify a relation between any full form of a term or lexical unit and its abbreviated form.^^xsd:string</para>
    ///   <para>rdfs:label : fullFormFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#fullFormFor">lexinfo:fullFormFor</a>
    /// </summary>
    let fullFormFor = _prefixId.prefix "fullFormFor"
    let fusedPreposition = _prefixId.prefix "fusedPreposition"
    let fusedPrepositionDeterminer = _prefixId.prefix "fusedPrepositionDeterminer"
    let fusedPrepositionPronoun = _prefixId.prefix "fusedPrepositionPronoun"
    let fusedPronounAuxiliary = _prefixId.prefix "fusedPronounAuxiliary"
    let future = _prefixId.prefix "future"
    let futureParticle = _prefixId.prefix "futureParticle"
    let futureTenseForm = _prefixId.prefix "futureTenseForm"
    /// <summary>
    ///   <para>rdfs:comment : A grammatical category that indicates grammatical relationships between words in sentences.^^xsd:string</para>
    ///   <para>rdfs:label : grammatical gender^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#gender">lexinfo:gender</a>
    /// </summary>
    let gender = _prefixId.prefix "gender"
    let generalAdverb = _prefixId.prefix "generalAdverb"
    let generalizationWord = _prefixId.prefix "generalizationWord"
    let genericNumeral = _prefixId.prefix "genericNumeral"
    let genitiveCase = _prefixId.prefix "genitiveCase"
    let genitiveCaseForm = _prefixId.prefix "genitiveCaseForm"
    let genitiveObject = _prefixId.prefix "genitiveObject"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Description of a specific form used in a certain region as opposed to another form used in another region^^xsd:string</para>
    ///   <para>rdfs:label : geographical variant^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#geographicalVariant">lexinfo:geographicalVariant</a>
    /// </summary>
    let geographicalVariant = _prefixId.prefix "geographicalVariant"
    let gerundClause = _prefixId.prefix "gerundClause"
    let gerundive = _prefixId.prefix "gerundive"
    /// <summary>
    ///   <para>rdfs:comment : In TEI: A phrase or word used to provide a gloss or definition for some other word or phrase.
    /// In 1951: Any editorial comment.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : gloss^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#gloss">lexinfo:gloss</a>
    /// </summary>
    let gloss = _prefixId.prefix "gloss"
    let head = _prefixId.prefix "head"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that the referenced element is a part of this object</para>
    ///   <para>rdfs:label : holonym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#holonymTerm">lexinfo:holonymTerm</a>
    /// </summary>
    let holonymTerm = _prefixId.prefix "holonymTerm"
    /// <summary>
    ///   <para>rdfs:comment : A word that is spelled like another, but that has a different pronunciation, meaning, and/or origin.^^xsd:stringrdfs:comment : Word that is written like another, but that has a different pronunciation, meaning, and/or origin.^^xsd:string</para>
    ///   <para>rdfs:label : homograph^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#homograph">lexinfo:homograph</a>
    /// </summary>
    let homograph = _prefixId.prefix "homograph"
    /// <summary>
    ///   <para>rdfs:comment : A word that is pronounced like another word and that can be spelled the same way (homograph) or can merely sound the same (homophone).^^xsd:stringrdfs:comment : Word that sounds the same and is written the same as another word but is different in meaning.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : homonym^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#homonym">lexinfo:homonym</a>
    /// </summary>
    let homonym = _prefixId.prefix "homonym"
    /// <summary>
    ///   <para>rdfs:comment : A word that is pronounced in the same way as another word but that is spelled differently.^^xsd:stringrdfs:comment : Word that sounds like another word, but is different in writiing or meaning.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : homophone^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#homophone">lexinfo:homophone</a>
    /// </summary>
    let homophone = _prefixId.prefix "homophone"
    let hypernym = _prefixId.prefix "hypernym"
    let hyponym = _prefixId.prefix "hyponym"
    let idiom = _prefixId.prefix "idiom"
    let illativeCase = _prefixId.prefix "illativeCase"
    let imperative = _prefixId.prefix "imperative"
    let imperativeMoodForm = _prefixId.prefix "imperativeMoodForm"
    let imperfect = _prefixId.prefix "imperfect"
    let imperfectTenseForm = _prefixId.prefix "imperfectTenseForm"
    let imperfective = _prefixId.prefix "imperfective"
    let impersonalPronoun = _prefixId.prefix "impersonalPronoun"
    let inHouseRegister = _prefixId.prefix "inHouseRegister"
    let inanimate = _prefixId.prefix "inanimate"
    let inchoative = _prefixId.prefix "inchoative"
    let indefinite = _prefixId.prefix "indefinite"
    let indefiniteArticle = _prefixId.prefix "indefiniteArticle"
    let indefiniteCardinalNumeral = _prefixId.prefix "indefiniteCardinalNumeral"
    let indefiniteDeterminer = _prefixId.prefix "indefiniteDeterminer"

    let indefiniteMultiplicativeNumeral =
        _prefixId.prefix "indefiniteMultiplicativeNumeral"

    let indefiniteOrdinalNumeral = _prefixId.prefix "indefiniteOrdinalNumeral"
    let indefinitePronoun = _prefixId.prefix "indefinitePronoun"
    let indicative = _prefixId.prefix "indicative"
    let indicativeMoodForm = _prefixId.prefix "indicativeMoodForm"
    let indifferent = _prefixId.prefix "indifferent"
    /// <summary>
    ///   <para>rdfs:comment : An indirect object is a grammatical relation that is one means of expressing the semantic role of goal and other similar roles. It is proposed for languages in which the role is distinct from the direct object and the oblique object on the basis of multiple independent syntactic or morphological criteria, such as the following: - Having a particular case marking, commonly dative - Governing an agreement affix on the verb, such as person or number - Being distinct from oblique relations in that it may be relativized^^xsd:string</para>
    ///   <para>rdfs:label : indirect object^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#indirectObject">lexinfo:indirectObject</a>
    /// </summary>
    let indirectObject = _prefixId.prefix "indirectObject"
    let inessiveCase = _prefixId.prefix "inessiveCase"
    let infinitive = _prefixId.prefix "infinitive"
    let infinitiveClause = _prefixId.prefix "infinitiveClause"
    let infinitiveParticle = _prefixId.prefix "infinitiveParticle"
    let infix = _prefixId.prefix "infix"
    let inflectionElement = _prefixId.prefix "inflectionElement"
    let infrequentlyUsed = _prefixId.prefix "infrequentlyUsed"
    let initialism = _prefixId.prefix "initialism"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A linking element used to identify a relation between an initialism and its full or expanded form.^^xsd:string</para>
    ///   <para>rdfs:label : initialismFor^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#initialismFor">lexinfo:initialismFor</a>
    /// </summary>
    let initialismFor = _prefixId.prefix "initialismFor"
    let instrumentalCase = _prefixId.prefix "instrumentalCase"
    let interjection = _prefixId.prefix "interjection"
    let internationalScientificTerm = _prefixId.prefix "internationalScientificTerm"
    let internationalism = _prefixId.prefix "internationalism"
    let interrogativeCardinalNumeral = _prefixId.prefix "interrogativeCardinalNumeral"
    let interrogativeClause = _prefixId.prefix "interrogativeClause"
    let interrogativeDeterminer = _prefixId.prefix "interrogativeDeterminer"
    let interrogativeInfinitiveClause = _prefixId.prefix "interrogativeInfinitiveClause"

    let interrogativeMultiplicativeNumeral =
        _prefixId.prefix "interrogativeMultiplicativeNumeral"

    let interrogativeOrdinalNumeral = _prefixId.prefix "interrogativeOrdinalNumeral"
    let interrogativeParticle = _prefixId.prefix "interrogativeParticle"
    let interrogativePronoun = _prefixId.prefix "interrogativePronoun"
    let interrogativeRelativePronoun = _prefixId.prefix "interrogativeRelativePronoun"
    let invertedComma = _prefixId.prefix "invertedComma"
    let ironicRegister = _prefixId.prefix "ironicRegister"
    let irreflexivePersonalPronoun = _prefixId.prefix "irreflexivePersonalPronoun"
    let languageSpecific = _prefixId.prefix "languageSpecific"
    let lativeCase = _prefixId.prefix "lativeCase"
    let legalTerm = _prefixId.prefix "legalTerm"
    let letter = _prefixId.prefix "letter"
    let lightVerb = _prefixId.prefix "lightVerb"
    let locativeCase = _prefixId.prefix "locativeCase"
    let logicalExpression = _prefixId.prefix "logicalExpression"
    let mainVerb = _prefixId.prefix "mainVerb"
    let masculine = _prefixId.prefix "masculine"
    let massNoun = _prefixId.prefix "massNoun"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the object is a member of this</para>
    ///   <para>rdfs:label : member holonym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberHolonym">lexinfo:memberHolonym</a>
    /// </summary>
    let memberHolonym = _prefixId.prefix "memberHolonym"
    /// <summary>
    ///   <para>rdfs:comment : Indicates this is an element of the other</para>
    ///   <para>rdfs:label : member meronym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#memberMeronym">lexinfo:memberMeronym</a>
    /// </summary>
    let memberMeronym = _prefixId.prefix "memberMeronym"
    /// <summary>
    ///   <para>rdfs:comment : Indicates this is a part of another concept</para>
    ///   <para>rdfs:label : meronym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#meronymTerm">lexinfo:meronymTerm</a>
    /// </summary>
    let meronymTerm = _prefixId.prefix "meronymTerm"
    let middleVoice = _prefixId.prefix "middleVoice"
    let modal = _prefixId.prefix "modal"
    let modern = _prefixId.prefix "modern"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the prenominal or postnominal positions of determiners which distinguish different forms.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : modification type^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#modificationType">lexinfo:modificationType</a>
    /// </summary>
    let modificationType = _prefixId.prefix "modificationType"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : In TEI: contains information about the grammatical mood of verbs (e.g. indicative, subjunctive, imperative).^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : mood^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#mood">lexinfo:mood</a>
    /// </summary>
    let mood = _prefixId.prefix "mood"
    let morphologicalElement = _prefixId.prefix "morphologicalElement"
    let morphosyntacticProperty = _prefixId.prefix "morphosyntacticProperty"
    let multiplicativeNumeral = _prefixId.prefix "multiplicativeNumeral"
    /// <summary>
    ///   <para>rdfs:comment : denotes the negation or the absence^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : negative^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#negative">lexinfo:negative</a>
    /// </summary>
    let negative = _prefixId.prefix "negative"
    let negativeForm = _prefixId.prefix "negativeForm"
    let negativeParticle = _prefixId.prefix "negativeParticle"
    let negativePronoun = _prefixId.prefix "negativePronoun"
    let neuter = _prefixId.prefix "neuter"
    let neutralRegister = _prefixId.prefix "neutralRegister"
    let no = _prefixId.prefix "no"
    let nominativeCase = _prefixId.prefix "nominativeCase"
    let nominativeCaseForm = _prefixId.prefix "nominativeCaseForm"
    let nonFinite = _prefixId.prefix "nonFinite"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : A term status qualifier assigned by an authoritative body, such as a standards body or a governmental entity with a regulatory function.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : normative authorization^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#normativeAuthorization">lexinfo:normativeAuthorization</a>
    /// </summary>
    let normativeAuthorization = _prefixId.prefix "normativeAuthorization"
    /// <summary>
    ///   <para>rdfs:comment : A statement that provides further information on any part of a language resource entry.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : note^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#note">lexinfo:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    let noun = _prefixId.prefix "noun"
    let nucleus = _prefixId.prefix "nucleus"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : grammatical number^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : Grammatical category for the variation in form of nouns, pronouns, and any words agreeing with them, depending on how many persons or things are referred to.^^xsd:stringrdfs:comment : In many languages, the grammatical distinction that indicates the number of objects referred to by the term or word.^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#number">lexinfo:number</a>
    /// </summary>
    let number = _prefixId.prefix "number"
    let numeral = _prefixId.prefix "numeral"
    let numeralFraction = _prefixId.prefix "numeralFraction"
    let object = _prefixId.prefix "object"
    let objectComplement = _prefixId.prefix "objectComplement"
    let obliqueCase = _prefixId.prefix "obliqueCase"
    let obsoleteForm = _prefixId.prefix "obsoleteForm"
    let old = _prefixId.prefix "old"
    let openParenthesis = _prefixId.prefix "openParenthesis"
    let optionalElement = _prefixId.prefix "optionalElement"
    let ordinalAdjective = _prefixId.prefix "ordinalAdjective"
    let otherAnimacy = _prefixId.prefix "otherAnimacy"
    let otherGender = _prefixId.prefix "otherGender"
    let otherNumber = _prefixId.prefix "otherNumber"
    let outdatedForm = _prefixId.prefix "outdatedForm"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a part of this object</para>
    ///   <para>rdfs:label : part holonym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#partHolonym">lexinfo:partHolonym</a>
    /// </summary>
    let partHolonym = _prefixId.prefix "partHolonym"
    /// <summary>
    ///   <para>rdfs:comment : Indicates this a component of the other concept</para>
    ///   <para>rdfs:label : part meronym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#partMeronym">lexinfo:partMeronym</a>
    /// </summary>
    let partMeronym = _prefixId.prefix "partMeronym"
    let partNumber = _prefixId.prefix "partNumber"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : part of speech^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A category assigned to a word based on its grammatical and semantic properties.^^xsd:stringrdfs:comment : Term used to describe how a particular word is used in a sentence.^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#partOfSpeech">lexinfo:partOfSpeech</a>
    /// </summary>
    let partOfSpeech = _prefixId.prefix "partOfSpeech"
    let participle = _prefixId.prefix "participle"
    let participleAdjective = _prefixId.prefix "participleAdjective"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that one lexical entry is the participle form of another, e.g., the adjective 'reassuring' is the participle of 'to reassure'</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#participleFormOf">lexinfo:participleFormOf</a>
    /// </summary>
    let participleFormOf = _prefixId.prefix "participleFormOf"
    let particle = _prefixId.prefix "particle"
    let partitiveArticle = _prefixId.prefix "partitiveArticle"
    let partitiveCase = _prefixId.prefix "partitiveCase"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between two concepts where one of the concepts constitutes the whole and the other concept a part of that whole.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : partitive relation^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#partitiveRelation">lexinfo:partitiveRelation</a>
    /// </summary>
    let partitiveRelation = _prefixId.prefix "partitiveRelation"
    let passiveVoice = _prefixId.prefix "passiveVoice"
    let past = _prefixId.prefix "past"
    let pastParticipleAdjective = _prefixId.prefix "pastParticipleAdjective"
    let pastTenseForm = _prefixId.prefix "pastTenseForm"
    let paucal = _prefixId.prefix "paucal"
    let perfective = _prefixId.prefix "perfective"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : Indication of grammatical person (1st, 2nd, 3rd, etc.) associated with a given inflected form.^^xsd:string</para>
    ///   <para>rdfs:label : person^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#person">lexinfo:person</a>
    /// </summary>
    let person = _prefixId.prefix "person"
    let personal = _prefixId.prefix "personal"
    let personalPronoun = _prefixId.prefix "personalPronoun"
    let pertainsTo = _prefixId.prefix "pertainsTo"
    let phraseologicalUnit = _prefixId.prefix "phraseologicalUnit"
    let plainVerb = _prefixId.prefix "plainVerb"
    let plural = _prefixId.prefix "plural"
    let pluralNumberForm = _prefixId.prefix "pluralNumberForm"
    let point = _prefixId.prefix "point"
    let positive = _prefixId.prefix "positive"
    let positiveDegreeForm = _prefixId.prefix "positiveDegreeForm"
    let positiveForm = _prefixId.prefix "positiveForm"
    let possessive = _prefixId.prefix "possessive"
    let possessiveAdjective = _prefixId.prefix "possessiveAdjective"
    let possessiveAdjunct = _prefixId.prefix "possessiveAdjunct"
    let possessiveDeterminer = _prefixId.prefix "possessiveDeterminer"
    let possessiveInfinitiveClause = _prefixId.prefix "possessiveInfinitiveClause"
    let possessiveParticle = _prefixId.prefix "possessiveParticle"
    let possessivePronoun = _prefixId.prefix "possessivePronoun"
    let possessiveRelativePronoun = _prefixId.prefix "possessiveRelativePronoun"
    let postModifier = _prefixId.prefix "postModifier"
    /// <summary>
    ///   <para>rdfs:comment : Indicates an argument of an adjective indicated by post-positive modification. An example in english would be that "that is something interesting", where the adjective interesting post-postively modifies something</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#postPositiveArg">lexinfo:postPositiveArg</a>
    /// </summary>
    let postPositiveArg = _prefixId.prefix "postPositiveArg"
    let postposition = _prefixId.prefix "postposition"
    let preModifier = _prefixId.prefix "preModifier"
    let predicativeAdjective = _prefixId.prefix "predicativeAdjective"
    let predicativeAdjunct = _prefixId.prefix "predicativeAdjunct"
    let predicativeAdverb = _prefixId.prefix "predicativeAdverb"
    let predicativeNominative = _prefixId.prefix "predicativeNominative"
    let preferredTerm = _prefixId.prefix "preferredTerm"
    let prefix = _prefixId.prefix "prefix"
    let preposition = _prefixId.prefix "preposition"
    let prepositionalAdjunct = _prefixId.prefix "prepositionalAdjunct"
    let prepositionalAdverb = _prefixId.prefix "prepositionalAdverb"
    let prepositionalGerundClause = _prefixId.prefix "prepositionalGerundClause"

    let prepositionalInterrogativeClause =
        _prefixId.prefix "prepositionalInterrogativeClause"

    let prepositionalObject = _prefixId.prefix "prepositionalObject"
    let present = _prefixId.prefix "present"
    let presentParticipleAdjective = _prefixId.prefix "presentParticipleAdjective"
    let presentTenseForm = _prefixId.prefix "presentTenseForm"
    let presentativePronoun = _prefixId.prefix "presentativePronoun"
    let preterite = _prefixId.prefix "preterite"
    let productName = _prefixId.prefix "productName"
    let prolativeCase = _prefixId.prefix "prolativeCase"
    let pronominalAdverb = _prefixId.prefix "pronominalAdverb"
    let pronoun = _prefixId.prefix "pronoun"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : The representation of the manner by which a term or word is articulated.^^xsd:string</para>
    ///   <para>rdfs:label : pronunciation^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#pronunciation">lexinfo:pronunciation</a>
    /// </summary>
    let pronunciation = _prefixId.prefix "pronunciation"
    let properNoun = _prefixId.prefix "properNoun"
    let proverb = _prefixId.prefix "proverb"
    let punctuation = _prefixId.prefix "punctuation"
    let quadrial = _prefixId.prefix "quadrial"
    let qualifierAdjective = _prefixId.prefix "qualifierAdjective"
    let quasiEquivalent = _prefixId.prefix "quasiEquivalent"
    let questionMark = _prefixId.prefix "questionMark"
    let radical = _prefixId.prefix "radical"
    let rarelyUsed = _prefixId.prefix "rarelyUsed"
    let reciprocalPronoun = _prefixId.prefix "reciprocalPronoun"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : Type of concrete object or concept (the referent) that an expression represents (the reference).^^xsd:string</para>
    ///   <para>rdfs:label : referent type^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#referentType">lexinfo:referentType</a>
    /// </summary>
    let referentType = _prefixId.prefix "referentType"
    let reflexiveDeterminer = _prefixId.prefix "reflexiveDeterminer"
    let reflexivePersonalPronoun = _prefixId.prefix "reflexivePersonalPronoun"
    let reflexivePossessivePronoun = _prefixId.prefix "reflexivePossessivePronoun"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : register^^xsd:string</para>
    ///   <para>rdfs:comment : Classification indicating the relative level of language individually assigned to a lexeme or term or to a text type.^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#register">lexinfo:register</a>
    /// </summary>
    let register = _prefixId.prefix "register"
    let regulatedTerm = _prefixId.prefix "regulatedTerm"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A term connected to another term by a coordinate or associative relation.^^xsd:string</para>
    ///   <para>rdfs:label : relatedTerm^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#relatedTerm">lexinfo:relatedTerm</a>
    /// </summary>
    let relatedTerm = _prefixId.prefix "relatedTerm"
    let relationNoun = _prefixId.prefix "relationNoun"
    let relativeDeterminer = _prefixId.prefix "relativeDeterminer"
    let relativeParticle = _prefixId.prefix "relativeParticle"
    let relativePronoun = _prefixId.prefix "relativePronoun"
    /// <summary>
    ///   <para>rdfs:comment : Transcription or transliteration from non-Latin script into Latin script.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : romanization^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#romanization">lexinfo:romanization</a>
    /// </summary>
    let romanization = _prefixId.prefix "romanization"
    /// <summary>
    ///   <para>rdfs:comment : base of a word^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : root^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#root">lexinfo:root</a>
    /// </summary>
    let root = _prefixId.prefix "root"
    let secondPerson = _prefixId.prefix "secondPerson"
    let secondPersonForm = _prefixId.prefix "secondPersonForm"
    /// <summary>
    ///   <para>rdfs:comment : Specification of the pointers in time or sequence that indicates the segmentation process.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wittenburg, Peter^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : segmentation^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#segmentation">lexinfo:segmentation</a>
    /// </summary>
    let segmentation = _prefixId.prefix "segmentation"
    let semiColon = _prefixId.prefix "semiColon"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:stringhttp://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : Descriptive material that provides a sample of an object or entity defined in the entry.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : sense example^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#senseExample">lexinfo:senseExample</a>
    /// </summary>
    let senseExample = _prefixId.prefix "senseExample"
    let sententialClause = _prefixId.prefix "sententialClause"
    let setPhrase = _prefixId.prefix "setPhrase"
    let shortArticle = _prefixId.prefix "shortArticle"
    let shortForm = _prefixId.prefix "shortForm"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A linking element used to identify a relation between a short form and its full or expanded form.^^xsd:string</para>
    ///   <para>rdfs:label : short form for^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#shortFormFor">lexinfo:shortFormFor</a>
    /// </summary>
    let shortFormFor = _prefixId.prefix "shortFormFor"
    let singular = _prefixId.prefix "singular"
    let singularNumberForm = _prefixId.prefix "singularNumberForm"
    let sku = _prefixId.prefix "sku"
    let slangRegister = _prefixId.prefix "slangRegister"
    let slash = _prefixId.prefix "slash"
    let sociativeCase = _prefixId.prefix "sociativeCase"
    let standardText = _prefixId.prefix "standardText"
    let standardizedTerm = _prefixId.prefix "standardizedTerm"
    let string = _prefixId.prefix "string"
    let stringCategory = _prefixId.prefix "stringCategory"
    let strongPersonalPronoun = _prefixId.prefix "strongPersonalPronoun"
    /// <summary>
    ///   <para>rdfs:comment : relation between a phrase and a verb, that represents the person or thing that performs the action or about which something is stated^^xsd:string</para>
    ///   <para>rdfs:label : subject^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#subject">lexinfo:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    let subjunctive = _prefixId.prefix "subjunctive"
    let subjunctiveClause = _prefixId.prefix "subjunctiveClause"
    let subjunctiveMoodForm = _prefixId.prefix "subjunctiveMoodForm"
    let sublativeCase = _prefixId.prefix "sublativeCase"
    let subordinatingConjunction = _prefixId.prefix "subordinatingConjunction"
    /// <summary>
    ///   <para>rdfs:comment : Indicates what this is composed of</para>
    ///   <para>rdfs:label : substance holonym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceHolonym">lexinfo:substanceHolonym</a>
    /// </summary>
    let substanceHolonym = _prefixId.prefix "substanceHolonym"
    /// <summary>
    ///   <para>rdfs:comment : Indicates this is a substance that composes the other</para>
    ///   <para>rdfs:label : substance meronym</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#substanceMeronym">lexinfo:substanceMeronym</a>
    /// </summary>
    let substanceMeronym = _prefixId.prefix "substanceMeronym"
    let suffix = _prefixId.prefix "suffix"
    let superessiveCase = _prefixId.prefix "superessiveCase"
    let superlative = _prefixId.prefix "superlative"
    let superlativeAdjunct = _prefixId.prefix "superlativeAdjunct"
    let superlativeDegreeForm = _prefixId.prefix "superlativeDegreeForm"
    let superlativeParticle = _prefixId.prefix "superlativeParticle"
    let supersededTerm = _prefixId.prefix "supersededTerm"
    let suspensionPoints = _prefixId.prefix "suspensionPoints"
    let syllable = _prefixId.prefix "syllable"
    let symbol = _prefixId.prefix "symbol"
    let synonym = _prefixId.prefix "synonym"
    let tabooRegister = _prefixId.prefix "tabooRegister"
    let technicalRegister = _prefixId.prefix "technicalRegister"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : An attribution of a term or lexeme with respect to its use over time.^^xsd:string</para>
    ///   <para>rdfs:label : temporal qualifier^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#temporalQualifier">lexinfo:temporalQualifier</a>
    /// </summary>
    let temporalQualifier = _prefixId.prefix "temporalQualifier"
    /// <summary>
    ///   <para>rdfs:comment : Property referring to the way the grammar marks the time at which the action denoted by the verb took place.^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : tense^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#tense">lexinfo:tense</a>
    /// </summary>
    let tense = _prefixId.prefix "tense"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : Any logically significant portion of a larger term or lexeme.^^xsd:string</para>
    ///   <para>rdfs:label : lexTermElement^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#termElement">lexinfo:termElement</a>
    /// </summary>
    let termElement = _prefixId.prefix "termElement"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:comment : An attribute assigned to a lexeme or a term.^^xsd:string</para>
    ///   <para>rdfs:label : lexTermType^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#termType">lexinfo:termType</a>
    /// </summary>
    let termType = _prefixId.prefix "termType"
    let terminativeCase = _prefixId.prefix "terminativeCase"
    let thirdPerson = _prefixId.prefix "thirdPerson"
    let thirdPersonForm = _prefixId.prefix "thirdPersonForm"
    let transcribedForm = _prefixId.prefix "transcribedForm"
    let translation = _prefixId.prefix "translation"
    /// <summary>
    ///   <para>rdfs:comment : The confidence in a given translation.</para>
    ///   <para>rdfs:label : Translation confidence</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#translationConfidence">lexinfo:translationConfidence</a>
    /// </summary>
    let translationConfidence = _prefixId.prefix "translationConfidence"
    let translativeCase = _prefixId.prefix "translativeCase"
    /// <summary>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Form resulting from the conversion of one writing system into another^^xsd:string</para>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:label : transliteration^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#transliteration">lexinfo:transliteration</a>
    /// </summary>
    let transliteration = _prefixId.prefix "transliteration"
    let trial = _prefixId.prefix "trial"
    let unaccomplished = _prefixId.prefix "unaccomplished"
    let unclassifiedParticle = _prefixId.prefix "unclassifiedParticle"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : A note containing information on the usage of the associated word or term.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Wright, Sue Ellen^^xsd:string</para>
    ///   <para>rdfs:label : usage note^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#usageNote">lexinfo:usageNote</a>
    /// </summary>
    let usageNote = _prefixId.prefix "usageNote"
    let verb = _prefixId.prefix "verb"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>rdfs:comment : One of a set of distinctive forms that are used to signal modality. Modality is a facet of illocutionary point or general intent of a speaker, or a speaker's degree of commitment to the expressed proposition's believability, obligatoriness, desirability or reality.^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:label : verb form mood^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#verbFormMood">lexinfo:verbFormMood</a>
    /// </summary>
    let verbFormMood = _prefixId.prefix "verbFormMood"
    let vocativeCase = _prefixId.prefix "vocativeCase"
    /// <summary>
    ///   <para>owl:versionInfo : 1:0^^xsd:string</para>
    ///   <para>http://purl.org/dc/elements/1.1/#creator : Francopoulo, Gil^^xsd:string</para>
    ///   <para>rdfs:comment : Way sentences may alter the relationship between the subject and object of a verb, without changing the meaning of the sentence.^^xsd:string</para>
    ///   <para>rdfs:label : voice^^xsd:string</para>
    ///   <a href="http://www.lexinfo.net/ontology/2.0/lexinfo#voice">lexinfo:voice</a>
    /// </summary>
    let voice = _prefixId.prefix "voice"
    let vulgarRegister = _prefixId.prefix "vulgarRegister"
    let weakPersonalPronoun = _prefixId.prefix "weakPersonalPronoun"
    let wordElement = _prefixId.prefix "wordElement"
    let yes = _prefixId.prefix "yes"
